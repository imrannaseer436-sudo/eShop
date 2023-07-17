Imports System.Data.SqlClient
Public Class CreditBill

    Private PluID As Integer = 0
    Private Sub GenerateBillNo()

        txtBillNo.Text = ESSA.GenerateID("select max(billno) from creditmaster")

    End Sub

    Private Sub LoadCustomers()

        SQL = "select customerid,customername from customers order by customername"
        ESSA.LoadCombo(cmbCust, SQL, "customername", "customerid")

    End Sub

    Private Sub CreditBill_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F2
                btnSave.PerformClick()
            Case Keys.F3
                btnAlter.PerformClick()
            Case Keys.F5
                btnReset.PerformClick()
            Case Keys.Escape
                btnClose.PerformClick()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub CreditBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadCustomers()
        GenerateBillNo()
        mebBillDt.Text = Format(Now.Date, "dd-MM-yyyy")
        txtRefNo.Select()

    End Sub

    Private Sub mebRefDt_Leave(sender As Object, e As EventArgs) Handles mebRefDt.Leave

        If IsDate(mebRefDt.Text) = False Then
            mebRefDt.Text = Format(Now.Date, "dd-MM-yyyy")
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub LoadProductDetails(iPlucode As String)

        SQL = "select pluid,plucode,pluname from productmaster where plucode='" & iPlucode & "'"
        With ESSA.OpenReader(SQL)
            If .Read Then
                PluID = .Item(0)
                txtDesc.Text = .GetString(2)
                txtQty.Focus()
            Else
                MsgBox("Product code not found..!", vbCritical)
                txtPlucode.Focus()
            End If
            .Close()
        End With

    End Sub

End Class