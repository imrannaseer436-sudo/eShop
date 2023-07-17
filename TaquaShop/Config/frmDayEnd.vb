Public Class frmDayEnd

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        SQL = "UPDATE Settings SET Param_Value = '{0}' WHERE Param_Name = 'BusinessDate'"
        ESSA.Execute(String.Format(SQL, Format(dtpDate.Value, "yyyy-MM-dd")))

        MsgBox("Updated successfully..!", MsgBoxStyle.Exclamation)

    End Sub

End Class