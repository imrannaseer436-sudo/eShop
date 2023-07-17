Public Class frmFinancialYearUpdate

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        SQL = "UPDATE Settings SET Param_Value = '{0}' WHERE Param_Name = 'BeginDate'"
        ESSA.Execute(String.Format(SQL, Format(dtpFrom.Value, "yyyy-MM-dd")))

        SQL = "UPDATE Settings SET Param_Value = '{0}' WHERE Param_Name = 'EndDate'"
        ESSA.Execute(String.Format(SQL, Format(dtpTo.Value, "yyyy-MM-dd")))

        MsgBox("Updated successfully..!", MsgBoxStyle.Exclamation)

    End Sub

    Private Sub frmFinancialYearUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL = "SELECT Param_Value FROM Settings WHERE Param_Name = 'BeginDate';" _
            & "SELECT Param_Value FROM Settings WHERE Param_Name = 'EndDate'"

        With ESSA.OpenReader(SQL)
            If .Read Then
                dtpFrom.Value = CDate(.GetString(0))
            End If
            .NextResult()
            If .Read Then
                dtpTo.Value = CDate(.GetString(0))
            End If
            .Close()
        End With

    End Sub
End Class