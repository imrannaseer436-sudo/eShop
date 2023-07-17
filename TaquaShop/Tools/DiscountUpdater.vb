Imports System.Data.SqlClient

Public Class DiscountUpdater

    '-- Some information about this module
    '-- Table: ProductDiscounts

    Private Sub getGrnDetails(code As String)

        Dim productId As Integer = 0

        SQL = "SELECT PluId FROM CRDetail WHERE NewCode = '" & code & "' AND NewCode IS NOT NULL"
        Dim newCode = ESSA.GetDataObj(SQL)

        If newCode Is Nothing Then
            SQL = "SELECT PluId FROM ProductMaster WHERE Plucode = '" & code & "'"
            productId = ESSA.GetData(SQL)
        Else
            productId = newCode
        End If

        SQL = "SELECT M.GrnNo, M.GrnDt, M.InvNo, V.VendorName " _
            & "FROM GrnMaster M, GrnDetails D, Vendors V " _
            & "WHERE M.GrnNo=D.GrnNo AND M.VendorId=V.VendorId AND D.PluId=" & productId

        With ESSA.OpenReader(SQL)
            If .Read Then
                lblCode.Text = code
                lblGrnNo.Text = .Item(0)
                lblGrnDt.Text = Format(.GetDateTime(1).Date, "dd-MMM-yyyy")
                lblInvNo.Text = .GetString(2).Trim
                lblVendor.Text = .GetString(3).Trim
                lblInvDt.Text = DateDiff(DateInterval.Day, .GetDateTime(1).Date, Now.Date)
            End If
            .Close()
        End With

    End Sub

    Private Function getYMD(fromDate As Date) As String

        Dim years As Object = DateDiff(DateInterval.Year, fromDate, Now.Date)
        Dim months As Object = DateDiff(DateInterval.Month, fromDate, Now.Date)
        Dim days As Object = DateDiff(DateInterval.Day, fromDate, Now.Date)

        years = IIf(years > 0, years & " Y ", "")
        months = IIf(months > 0, months & " M ", "")
        days = IIf(days > 0, days & " D", "")

        Return years & months & days

    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtCode.Text.Trim = "" Then
            MsgBox("Product code cannot be empty.", MsgBoxStyle.Critical)
            txtCode.Focus()
            Exit Sub
        End If

        If chkShowPurchase.Checked Then
            getGrnDetails(txtCode.Text.Trim)
        End If

        SQL = "SELECT M.PluID, M.Plucode, M.Pluname, M.CostPrice, M.RetailPrice, M.Discount " _
            & "FROM ProductMaster M WHERE M.Plucode='" & txtCode.Text.Trim & "'"

        With ESSA.OpenReader(SQL)
            If .Read Then
                dgv.Rows.Add()
                dgv.Item(0, dgv.Rows.Count - 1).Value = .Item(0)
                dgv.Item(1, dgv.Rows.Count - 1).Value = .GetString(1).Trim
                dgv.Item(2, dgv.Rows.Count - 1).Value = .GetString(2).Trim
                dgv.Item(3, dgv.Rows.Count - 1).Value = Format(.Item(3), "0.00")
                dgv.Item(4, dgv.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                dgv.Item(5, dgv.Rows.Count - 1).Value = .Item(5)
                If chkShowPurchase.Checked Then
                    dgv.Item(10, dgv.Rows.Count - 1).Value = lblGrnNo.Text
                    dgv.Item(11, dgv.Rows.Count - 1).Value = lblGrnDt.Text
                    dgv.Item(12, dgv.Rows.Count - 1).Value = lblInvNo.Text
                    dgv.Item(13, dgv.Rows.Count - 1).Value = lblVendor.Text
                    dgv.Item(14, dgv.Rows.Count - 1).Value = lblInvDt.Text
                End If
                txtCode.Clear()
                txtCode.Focus()
            Else
                MsgBox("Product code not found!", MsgBoxStyle.Critical)
                txtCode.Focus()
            End If
            .Close()
        End With

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If dgv.Rows.Count = 0 Then
            MsgBox("No data to update!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("Do you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            For i As Short = 0 To dgv.Rows.Count - 1

                SQL = "UPDATE ProductMaster SET " _
                    & "Discount=" & Val(dgv.Item(5, i).Value) & "," _
                    & "UpdatedDate='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                    & "UserId=" & UserID _
                    & " WHERE PluId=" & Val(dgv.Item(0, i).Value)

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                SQL = "INSERT INTO ProductDiscounts VALUES (" _
                    & Val(dgv.Item(0, i).Value) & "," _
                    & Val(dgv.Item(4, i).Value) & "," _
                    & Val(dgv.Item(6, i).Value) & "," _
                    & Val(dgv.Item(5, i).Value) & ",'" _
                    & Format(Now, "yyyy-MM-dd HH:mm:ss") & "')"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()
            Con.Close()

        Catch ex As SqlException

            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub

        End Try

        MsgBox("Discount updated successfully!", MsgBoxStyle.Exclamation)
        dgv.Rows.Clear()
        txtCode.Focus()

    End Sub

    Private Sub DiscountUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgv.ColumnHeadersDefaultCellStyle.Font = New Font(dgv.Font, FontStyle.Bold)
        ESSA.AlignHeader(dgv, 5, DataGridViewContentAlignment.MiddleCenter)

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 8 Then
            If MsgBox("Remove this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            dgv.Rows.RemoveAt(e.RowIndex)
        Else
            lblCode.Text = dgv.Item(1, e.RowIndex).Value
            lblGrnNo.Text = dgv.Item(10, e.RowIndex).Value
            lblGrnDt.Text = dgv.Item(11, e.RowIndex).Value
            lblInvNo.Text = dgv.Item(12, e.RowIndex).Value
            lblVendor.Text = dgv.Item(13, e.RowIndex).Value
            lblInvDt.Text = dgv.Item(14, e.RowIndex).Value
        End If

    End Sub

    Private Sub resetPurchaseDetails()

        lblGrnNo.Text = ""
        lblGrnDt.Text = ""
        lblInvNo.Text = ""
        lblVendor.Text = ""
        lblInvDt.Text = ""

    End Sub

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnAdd.PerformClick()
        End If

    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click

        For i As Short = 0 To dgv.Rows.Count - 1

            dgv.Item(5, i).Value = Format(Val(txtDis.Text), "0.0")
            dgv.Item(6, i).Value = Format(Val(dgv.Item(4, i).Value) - (Val(dgv.Item(4, i).Value) * Val(dgv.Item(5, i).Value)) / 100, "0.00")
            dgv.Item(7, i).Value = Format(Val(dgv.Item(6, i).Value) - Val(dgv.Item(4, i).Value), "0.00")

        Next

    End Sub

    Private Sub UpdateRetailPrice(rowIndex As Short)

        dgv.Item(5, rowIndex).Value = Format(Val(dgv.Item(5, rowIndex).Value), "0.0")
        dgv.Item(6, rowIndex).Value = Format(Val(dgv.Item(4, rowIndex).Value) - (Val(dgv.Item(4, rowIndex).Value) * Val(dgv.Item(5, rowIndex).Value)) / 100, "0.00")
        dgv.Item(7, rowIndex).Value = Format(Val(dgv.Item(6, rowIndex).Value) - Val(dgv.Item(4, rowIndex).Value), "0.00")

    End Sub

    Private Sub dgv_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv.RowsAdded

        lblQty.Text = dgv.Rows.Count

    End Sub

    Private Sub dgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEndEdit

        If e.RowIndex = -1 Then Exit Sub
        UpdateRetailPrice(e.RowIndex)

    End Sub

    Private Sub dgv_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgv.RowsRemoved

        lblQty.Text = dgv.Rows.Count

    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class