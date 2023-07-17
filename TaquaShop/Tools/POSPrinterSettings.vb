'*********************************************** Bismillah ******************************************
Imports System.Data.SqlClient
Public Class POSPrinterSettings

    Private Sub POSPrinterSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "select top 5 * from printersettings order by sno;" _
            & "select top 1 * from printersettings order by sno desc"
        With ESSA.OpenReader(SQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .GetString(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1)
                TG.Item(2, TG.Rows.Count - 1).Value = .Item(3)
                TG.Item(3, TG.Rows.Count - 1).Value = .Item(4)
                TG.Item(4, TG.Rows.Count - 1).Value = .Item(5)
                TG.Item(5, TG.Rows.Count - 1).Value = .GetString(2)
            End While
            .NextResult()
            If .Read Then
                txtImgLoc.Text = .GetString(1)
            End If
            .Close()
        End With

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            SQL = "delete from printersettings"
            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "insert into printersettings values ('" _
                    & TG.Item(0, i).Value & "','" _
                    & TG.Item(1, i).Value & "','" _
                    & TG.Item(5, i).Value & "'," _
                    & TG.Item(2, i).Value & "," _
                    & TG.Item(3, i).Value & "," _
                    & TG.Item(4, i).Value & "," _
                    & i + 1 & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            SQL = "insert into printersettings values ('Image','" _
                & txtImgLoc.Text.Trim & "','Img',0,0,0,6)"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()
            MsgBox("Settings updated successfully..!", MsgBoxStyle.Information)

        Catch ex As SqlException
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

End Class