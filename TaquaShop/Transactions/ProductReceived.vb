'********************************************* Bismillah ******************************************
Imports System.Data.SqlClient
Public Class ProductReceived

    Private EQTot As Integer = 0 'Expected Quantity Total
    Private AQTot As Integer = 0 'Actual Quantity Total

    Private Sub ProductReceived_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadDeliveryCode()

    End Sub

    Private Sub LoadDeliveryCode()

        SQL = "select deliveryfrom,deliverycode from receivedmastertemp order by deliverycode"
        ESSA.LoadCombo(cmbDeliveryCode, SQL, "deliverycode", "deliveryfrom")

    End Sub

    Private Sub btnListOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListOut.Click

        SQL = "select remarks from receivedmastertemp where deliverycode='" & cmbDeliveryCode.Text.Trim & "'"
        With ESSA.OpenReader(SQL)
            If .Read Then
                txtRemarks.Text = .GetString(0).Trim
            End If
            .Close()
        End With

        SQL = "select d.pluid,p.plucode 'CODE',p.pluname 'PRODUCT DESCRIPTION',d.Quantity 'DELIVERED',d.Quantity 'RECEIVED',d.costprice,d.retailprice from " _
            & "receiveddetailstemp d,productmaster p where d.pluid=p.pluid and d.deliverycode='" & cmbDeliveryCode.Text.Trim & "'" _
            & " order by d.sno"

        TG.Columns.Clear()
        ESSA.LoadDataGrid(TG, SQL)
        TG.Columns(0).Visible = False
        TG.Columns(1).Width = 100
        TG.Columns(2).Width = TG.Width - 280
        TG.Columns(3).Width = 100
        TG.Columns(4).Width = 80
        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
        TG.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(5).Visible = True
        TG.Columns(6).Visible = True

        If TG.Rows.Count > 0 Then
            TG.CurrentCell = TG.Item(4, 0)
            TG.Focus()
        End If

        CalculateTotal()
        CalculateRowTotal()

    End Sub

    Private Sub CalculateTotal()

        EQTot = 0
        AQTot = 0

        For i As Short = 0 To TG.Rows.Count - 1

            EQTot += Val(TG.Item(3, i).Value)
            AQTot += Val(TG.Item(4, i).Value)

        Next

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnReject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReject.Click

        If TG.Rows.Count = 0 Then Exit Sub
        If MsgBox("Are you sure, do you want to reject this delivery..?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If EQTot <> AQTot Then 'Which means expected quantity not equal to received quantity

                SQL = "INSERT INTO DELIVERYMASTERTEMP VALUES ('" _
                    & cmbDeliveryCode.Text.Trim & "','" _
                    & Format(Now.Date, "yyyy-MM-dd hh:mm:ssss") & "'," _
                    & ShopID & "," _
                    & cmbDeliveryCode.SelectedValue & "," _
                    & Val(lblQty.Text) & "," _
                    & Val(lblctot.Text) & "," _
                    & Val(lblrtot.Text) & ",0,''," _
                    & UserID & ",0)"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                For I As Short = 0 To TG.Rows.Count - 1

                    SQL = "INSERT INTO DELIVERYDETAILSTEMP VALUES ('" _
                        & cmbDeliveryCode.Text.Trim & "'," _
                        & Val(TG.Item(0, I).Value) & "," _
                        & Val(TG.Item(3, I).Value) & "," _
                        & Val(TG.Item(5, I).Value) & "," _
                        & Val(TG.Item(6, I).Value) & "," _
                        & ShopID & "," _
                        & cmbDeliveryCode.SelectedValue & "," _
                        & I + 1 & ",0)"

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                Next

            End If

            SQL = "delete from receivedmastertemp where deliverycode='" & cmbDeliveryCode.Text.Trim & "';" _
                & "delete from receiveddetailstemp where deliverycode='" & cmbDeliveryCode.Text.Trim & "'"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        MsgBox("Product rejected successfully..!", vbExclamation)
        TG.DataSource = Nothing
        cmbDeliveryCode.Text = ""
        txtRemarks.Clear()
        LoadDeliveryCode()
        cmbDeliveryCode.Focus()


    End Sub

    Private Sub CalculateRowTotal()

        Dim TQty As Integer = 0
        Dim CAmt As Double = 0
        Dim RAmt As Double = 0
        Dim Temp As Double = 0

        For i As Short = 0 To TG.Rows.Count - 1

            TQty += Val(TG.Item(4, i).Value)

            Temp = Val(TG.Item(4, i).Value) * Val(TG.Item(5, i).Value)
            CAmt += Temp

            Temp = Val(TG.Item(4, i).Value) * Val(TG.Item(6, i).Value)
            RAmt += Temp

        Next

        lblQty.Text = TQty
        lblctot.Text = Format(CAmt, "0.00")
        lblrtot.Text = Format(RAmt, "0.00")

    End Sub

    Private Sub btnApproved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApproved.Click

        If TG.Rows.Count = 0 Then Exit Sub
        If MsgBox("Are you sure, do you want approved..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If EQTot <> AQTot Then 'Which means expected quantity not equal to received quantity

                SQL = "INSERT INTO DELIVERYMASTERTEMP VALUES ('" _
                    & cmbDeliveryCode.Text.Trim & "','" _
                    & Format(Now.Date, "yyyy-MM-dd hh:mm:ssss") & "'," _
                    & ShopID & "," _
                    & cmbDeliveryCode.SelectedValue & ",0,0,0,0,''," _
                    & UserID & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                For I As Short = 0 To TG.Rows.Count - 1

                    If Val(TG.Item(3, I).Value) - Val(TG.Item(4, I).Value) > 0 Then

                        SQL = "INSERT INTO DELIVERYDETAILSTEMP VALUES ('" _
                            & cmbDeliveryCode.Text.Trim & "'," _
                            & Val(TG.Item(0, I).Value) & "," _
                            & Val(TG.Item(3, I).Value) - Val(TG.Item(4, I).Value) & "," _
                            & Val(TG.Item(5, I).Value) & "," _
                            & Val(TG.Item(6, I).Value) & "," _
                            & ShopID & "," _
                            & cmbDeliveryCode.SelectedValue & "," _
                            & I + 1 & ",0)"

                        Cmd.CommandText = SQL
                        Cmd.ExecuteNonQuery()

                    End If

                Next

            End If

            SQL = "delete from receivedmaster where deliverycode='" & cmbDeliveryCode.Text.Trim & "';" _
                & "insert into receivedmaster select * from receivedmastertemp where deliverycode='" & cmbDeliveryCode.Text.Trim & "'"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "update receiveddetails set quantity=" & Val(TG.Item(4, i).Value) _
                    & " where pluid=" & Val(TG.Item(0, i).Value)

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            SQL = "delete from receiveddetails where deliverycode='" & cmbDeliveryCode.Text.Trim & "';" _
                & "insert into receiveddetails select * from receiveddetailstemp where deliverycode='" & cmbDeliveryCode.Text.Trim & "'"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            SQL = "UPDATE RECEIVEDMASTER SET TOTALQTY=" & Val(lblQty.Text) & ",TOTCP=" _
                & Val(lblctot.Text) & ",TOTRP=" & Val(lblrtot.Text) & ",STATUS=1 WHERE DELIVERYCODE='" _
                & cmbDeliveryCode.Text.Trim & "';" _
                & "delete from receivedmastertemp where deliverycode='" & cmbDeliveryCode.Text.Trim & "';" _
                & "delete from receiveddetailstemp where deliverycode='" & cmbDeliveryCode.Text.Trim & "'"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()

        Catch ex As SqlException
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        MsgBox("Product received successfully..!", vbExclamation)
        TG.DataSource = Nothing
        cmbDeliveryCode.Text = ""
        txtRemarks.Clear()
        LoadDeliveryCode()
        cmbDeliveryCode.Focus()

    End Sub

    Private Sub TG_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TG.CellEndEdit

        CalculateRowTotal()
        CalculateTotal()

    End Sub

End Class
