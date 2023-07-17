'***************************************** Bismillah **************************************
Imports System.Data.SqlClient
Public Class PaymentType

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtPmtDesc.Text.Trim = "" Then
            MsgBox("Payment description cannot be empty..!", MsgBoxStyle.Information)
            txtPmtDesc.Focus()
            Exit Sub
        ElseIf ESSA.ISFound("select paymentid from paymenttype where paymentdesc='" & txtPmtDesc.Text.Trim & "'") = True Then
            MsgBox("Payment description already exists..!", MsgBoxStyle.Information)
            txtPmtDesc.SelectAll()
            txtPmtDesc.Focus()
            Exit Sub
        End If

        Dim PmtID = ESSA.GenerateID("select max(paymentid) from paymenttype")

        SQL = "insert into paymenttype values (" _
            & PmtID & ",'" _
            & txtPmtDesc.Text.Trim & "','" _
            & GetPaymentMode() & "'," _
            & ShopID & ",'" _
            & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
            & UserID & ")"

        ESSA.Execute(SQL)
        MsgBox("Payment type has been created successfully..!", MsgBoxStyle.Information)
        txtPmtDesc.Clear()
        txtPmtDesc.Focus()

    End Sub

    Private Function GetPaymentMode() As String

        If rdoCash.Checked = True Then
            GetPaymentMode = "Cash"
        ElseIf rdoCard.Checked = True Then
            GetPaymentMode = "Card"
        ElseIf RdoVoucher.Checked = True Then
            GetPaymentMode = "Voucher"
        Else
            GetPaymentMode = "Credit"
        End If

    End Function



End Class