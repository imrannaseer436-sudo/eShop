Public Class Denomination

    Private rpt1 As New Denomination1
    Private rpt2 As New Denomination2
    Private rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

    Private Sub txt2000_TextChanged(sender As Object, e As EventArgs) Handles txt2000.TextChanged, txt500.TextChanged, txt200.TextChanged, txt100.TextChanged, txt50.TextChanged, txt20.TextChanged, txt10.TextChanged, txtCoins.TextChanged, txtToken.TextChanged

        lbl2000.Text = Val(txt2000.Text) * 2000
        lbl500.Text = Val(txt500.Text) * 500
        lbl200.Text = Val(txt200.Text) * 200
        lbl100.Text = Val(txt100.Text) * 100
        lbl50.Text = Val(txt50.Text) * 50
        lbl20.Text = Val(txt20.Text) * 20
        lbl10.Text = Val(txt10.Text) * 10
        lblCoins.Text = Val(txtCoins.Text) * 1
        lblToken.Text = Val(txtToken.Text) * 1000
        lblTot.Text = Val(lbl2000.Text) + Val(lbl500.Text) + Val(lbl200.Text) + Val(lbl100.Text) + Val(lbl50.Text) + Val(lbl20.Text) + Val(lbl10.Text) + Val(lblCoins.Text) + Val(lblToken.Text)
        If rbCounter.Checked Then
            lblDiff.Text = Val(lblTot.Text) - Val(txtIrupu.Text)
        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        rpt = IIf(rbSales.Checked, rpt1, rpt2)

        Dim card As Double = 0
        Dim upi As Double = 0
        Dim irupu As Double = 0

        'Dim nullValue As New ParameterDiscreteValue
        'nullValue = DBNull.Value

        rpt.SetParameterValue("Date", Format(Now.Date, "yyyy-MM-dd"))
        rpt.SetParameterValue("Count2000", txt2000.Text)
        rpt.SetParameterValue("Count500", txt500.Text)
        rpt.SetParameterValue("Count200", txt200.Text)
        rpt.SetParameterValue("Count100", txt100.Text)
        rpt.SetParameterValue("Count50", txt50.Text)
        rpt.SetParameterValue("Count20", txt20.Text)
        rpt.SetParameterValue("Count10", txt10.Text)
        rpt.SetParameterValue("CountCoins", txtCoins.Text)
        rpt.SetParameterValue("CountToken", txtToken.Text)
        rpt.SetParameterValue("Value2000", Val(lbl2000.Text))
        rpt.SetParameterValue("Value500", Val(lbl500.Text))
        rpt.SetParameterValue("Value200", Val(lbl200.Text))
        rpt.SetParameterValue("Value100", Val(lbl100.Text))
        rpt.SetParameterValue("Value50", Val(lbl50.Text))
        rpt.SetParameterValue("Value20", Val(lbl20.Text))
        rpt.SetParameterValue("Value10", Val(lbl10.Text))
        rpt.SetParameterValue("ValueCoins", Val(lblCoins.Text))
        rpt.SetParameterValue("ValueToken", Val(lblToken.Text))
        rpt.SetParameterValue("UserName", cmbUser.Text)

        If rbSales.Checked Then

            SQL = "SELECT DISTINCT A.PaymentMode, SUM(A.Value) Value FROM " _
                & "( " _
                & "Select Case(P.PaymentDesc) " _
                & "When 'cahs' THEN 'CASH' " _
                & "WHEN 'CARD' THEN 'CARD' " _
                & "When 'CASH' THEN 'CASH' " _
                & "WHEN 'MAESTRO CARD' THEN 'CARD' " _
                & "WHEN 'MASTER CARD' THEN 'CARD' " _
                & "When 'NEFT' THEN 'UPI' " _
                & "WHEN 'RUPAY' THEN 'CARD' " _
                & "When 'UPI' THEN 'UPI' " _
                & "WHEN 'VISA' THEN 'CARD' " _
                & "END AS [PaymentMode] , SUM(P.Paid - P.Refund) Value " _
                & "FROM " _
                & "BillMaster M, BillPayments P " _
                & "WHERE M.BillID = P.BillID AND M.BillDt = '" & Format(Now.Date, "yyyy-MM-dd") & "'"

            If cmbUser.SelectedIndex > 0 Then
                SQL &= " AND M.UserId =" & cmbUser.SelectedValue
            End If

            SQL &= "GROUP BY P.PaymentDesc) A " _
                & "GROUP BY A.PaymentMode"

            With ESSA.OpenReader(SQL)
                While .Read
                    If .GetString(0) = "CARD" Then
                        card = .Item(1)
                    ElseIf .GetString(0) = "UPI" Then
                        upi = .Item(1)
                    End If
                End While
                .Close()
            End With

            rpt.SetParameterValue("AccNo", "106105013119")
            rpt.SetParameterValue("CARD", card)
            rpt.SetParameterValue("UPI", upi)

        ElseIf rbCounter.Checked Then

            rpt.SetParameterValue("IRUPU", Val(txtIrupu.Text))

        End If

        rpt.PrintToPrinter(1, True, 1, 1)

        'frmReportViewer.CRViewer.ReportSource = rpt
        'frmReportViewer.Visible = False
        'frmReportViewer.Show()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ESSA.ClearTextBox(Me)
        lbl2000.Text = "0.00"
        lbl500.Text = "0.00"
        lbl200.Text = "0.00"
        lbl100.Text = "0.00"
        lbl50.Text = "0.00"
        lbl20.Text = "0.00"
        lbl10.Text = "0.00"
        lblCoins.Text = "0.00"
        lblToken.Text = "0.00"
        lblTot.Text = "0.00"
        lblDiff.Text = "0.00"
        cmbUser.SelectedIndex = 0
        txt2000.Focus()

    End Sub

    Private Sub Denomination_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then

            If Me.ActiveControl.Tag <> "1" Then
                e.SuppressKeyPress = True
                Me.ProcessTabKey(True)
            End If

        ElseIf e.KeyCode = Keys.Escape Then

            If MsgBox("Close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Me.Close()

        End If

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click

        If MsgBox("Close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()

    End Sub

    Private Sub rbCounter_CheckedChanged(sender As Object, e As EventArgs) Handles rbCounter.CheckedChanged

        IrupuControl()

    End Sub

    Private Sub IrupuControl()

        If rbCounter.Checked = True Then
            txtIrupu.Enabled = True
            txtIrupu.Text = 120000
            If Val(lblTot.Text) > 0 Then
                lblDiff.Text = Val(lblTot.Text) - Val(txtIrupu.Text)
            End If
        Else
            txtIrupu.Enabled = False
            txtIrupu.Text = ""
            lblDiff.Text = "0.00"
        End If

    End Sub

    Private Sub txtIrupu_TextChanged(sender As Object, e As EventArgs) Handles txtIrupu.TextChanged

        lblDiff.Text = Val(lblTot.Text) - Val(txtIrupu.Text)

    End Sub

    Private Sub Denomination_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL = "SELECT UserId,UserName FROM Users ORDER BY UserName"
        ESSA.LoadCombo(cmbUser, SQL, "UserName", "UserID", "All")

        txt2000.Focus()

    End Sub
End Class