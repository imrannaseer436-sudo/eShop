Imports System.Data.SqlClient

Public Class frmProductSync

    Private StringWait = "Connecting, Please Wait !"
    Private StringNormal = "Sync Manually !"
    Private StringComplete = "Sync Completed !"

    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSync.Click

        btnSync.Text = StringWait
        btnSync.Refresh()

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand

        Try

            Cmd.CommandTimeout = 3000
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "SP_MSYNC"
            Cmd.ExecuteNonQuery()

            Con.Close()

        Catch ex As SqlException

            btnSync.Text = StringNormal
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub

        End Try

        btnSync.Text = StringComplete
        btnSync.Refresh()
        MsgBox("Manual sync process completed successfully..!", MsgBoxStyle.Information)

    End Sub

End Class