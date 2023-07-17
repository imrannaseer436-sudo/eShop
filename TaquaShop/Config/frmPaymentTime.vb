Public Class frmPaymentTime

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

        If Not txtBillNo.Text.Trim = "" Then

            Dim billno = "T" + cmbTerm.Text + "-" + txtBillNo.Text.Trim

            SQL = "SELECT PaidAt FROM BillPaymentConfirmation WHERE BillNo = '" & billno & "'"

            With ESSA.OpenReader(SQL)
                If .Read Then
                    txtTime.Text = Format(.GetDateTime(0), "dd-MM-yyyy hh:mm tt")
                Else
                    MsgBox("Detail not found..!", MsgBoxStyle.Critical)
                    txtBillNo.SelectAll()
                    txtBillNo.Focus()
                End If
                .Close()
            End With

        Else

            MsgBox("Please fill bill no..!", MsgBoxStyle.Critical)
            txtBillNo.Focus()

        End If


    End Sub

    Private Function GetBillId(input As String) As Long

        GetBillId = 0
        Dim termId = input.Chars(1)
        Dim BillNo = input.Substring(3)

        SQL = "SELECT BillId FROM BillMaster WHERE TermId =" & Val(termId) & " AND BillNo =" & Val(BillNo) & "" _
            & " AND BillDt BETWEEN '" & Format(SDate, "yyyy-MM-dd") & "' AND '" & Format(EDate, "yyyy-MM-dd") & "'"
        With ESSA.OpenReader(SQL)

            If .Read Then

                GetBillId = .Item(0)

            End If

            .Close()
        End With

    End Function

    Private Sub frmPaymentTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'SQL = "SELECT Param_Value FROM Settings WHERE Param_Name = 'BeginDate';" _
        '& "SELECT Param_Value FROM Settings WHERE Param_Name = 'EndDate'"

        'With ESSA.OpenReader(SQL)
        '    If .Read Then
        '        SDate = CDate(.GetString(0))
        '    End If
        '    .NextResult()
        '    If .Read Then
        '        EDate = CDate(.GetString(0))
        '    End If
        '    .Close()
        'End With

        SQL = "SELECT Distinct TermId From BillMaster"
        ESSA.LoadCombo(cmbTerm, SQL, "TermId")

        cmbTerm.Select()

    End Sub

    Private Sub txtBillNo_KeyDown(sender As Object, e As KeyEventArgs)

        If e.KeyCode = Keys.Enter Then
            btnFind.PerformClick()
        End If

    End Sub
End Class