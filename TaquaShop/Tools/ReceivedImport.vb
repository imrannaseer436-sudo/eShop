'*********************************** in the name of Allah, most merciful, most compassionate *********************************
Imports System.Data.SqlClient
Public Class ReceivedImport

    Private FilterDate As Date
    Private GFD As Boolean = False

    Public Sub LoadExportList()

        lblStatus.Text = "Loading, Please wait...!"
        pnlLoading.Visible = True
        pnlLoading.Refresh()

        SQL = "select deliverycode,deliverydate,totalqty,totcp from eserver.eWarehouseDB.dbo.deliverymaster where " _
            & "deliverycode not in (select deliverycode from receivedmasterlist) and deliveryto=" & ShopID _
            & " and isupdated=0"

        If GFD = True Then
            SQL &= " and deliverydate>='" & Format(FilterDate, "yyyy-MM-dd") & "'"
        End If

        SQL &= " order by deliverydate"

        'SQL = "select deliverycode,deliverydate,totalqty,totcp from deliverymaster where deliveryto=" & ShopID _
        '    & " order by deliverydate"

        TG.Rows.Clear()
        With ESSA.OpenReader(SQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .GetString(0)
                TG.Item(1, TG.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MMM-yyyy")
                TG.Item(2, TG.Rows.Count - 1).Value = .Item(2)
                TG.Item(3, TG.Rows.Count - 1).Value = Format(.Item(3), "0.00")
            End While
            .Close()
        End With

        pnlLoading.Visible = False

    End Sub

    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click

        LoadExportList()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub TG_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TG.CellClick

        If e.ColumnIndex = 4 Then

            lblStatus.Text = "Importing, Please wait...!"
            pnlLoading.Visible = True
            pnlLoading.Refresh()

            ESSA.OpenConnection()
            Dim Cmd = Con.CreateCommand
            Dim Trn = Con.BeginTransaction
            Cmd.Transaction = Trn

            Try

                SQL = "delete from receivedmastertemp where deliverycode='" & Trim(TG.Item(0, e.RowIndex).Value) & "';" _
                    & "delete from receiveddetailstemp where deliverycode='" & Trim(TG.Item(0, e.RowIndex).Value) & "'"
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                SQL = "insert into receivedmastertemp " _
                    & "select * from eserver.eWarehouseDB.dbo.deliverymaster where deliverycode='" & Trim(TG.Item(0, e.RowIndex).Value) & "';" _
                    & "insert into receiveddetailstemp " _
                    & "select * from eserver.eWarehouseDB.dbo.deliverydetails where deliverycode='" & Trim(TG.Item(0, e.RowIndex).Value) & "'"
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                Trn.Commit()
                Con.Close()

            Catch ex As SqlException
                pnlLoading.Visible = False
                Trn.Rollback()
                Con.Close()
                MsgBox("Sorry, Unable to import products, Please try again later..!", MsgBoxStyle.Critical)
                Exit Sub
            End Try

            pnlLoading.Visible = False
            MsgBox("Delivery code imported successfully...!", MsgBoxStyle.Information)
            TG.Rows.RemoveAt(e.RowIndex)
            TG.Focus()

        End If

    End Sub

    Private Sub ReceivedImport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        SQL = "SELECT PARAM_VALUE FROM SETTINGS WHERE PARAM_NAME='EnableDeliveryFilter'"
        With ESSA.OpenReader(SQL)
            If .Read Then
                GFD = True
            End If
            .Close()
        End With

        If GFD = True Then

            SQL = "SELECT PARAM_VALUE FROM SETTINGS WHERE PARAM_NAME='DeliveryFilterDate'"
            With ESSA.OpenReader(SQL)
                If .Read Then
                    FilterDate = CDate(.GetString(0)).Date
                End If
                .Close()
            End With

        End If

    End Sub

End Class