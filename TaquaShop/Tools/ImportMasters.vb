'********************************************* Bismillah *************************************
Imports System.Data.SqlClient
Public Class ImportMasters

    Private nConStr As String = ""

    Private Sub LoadDatabase()

        SQL = "select * from importdatabase"
        With ESSA.OpenReader(SQL)
            If .Read Then

                txtSQL2.Text = .GetString(0)
                txtDB2.Text = .GetString(1)

            End If
            .Close()
        End With

    End Sub

    'Private Sub CheckConnections()

    '    Dim nCon As New SqlConnection(nConStr)

    '    Try

    '        nCon.Open()
    '        If nCon.State = ConnectionState.Open Then
    '            lblSStat.Text = "Connected...!"
    '            nCon.Close()
    '        End If

    '    Catch ex As SqlException
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '        lblSStat.Text = "Not Connected...!"
    '    Finally
    '        nCon.Dispose()
    '    End Try

    'End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        SQL = "delete importdatabase;insert into importdatabase values ('" _
            & txtSQL2.Text.Trim & "','" _
            & txtDB2.Text.Trim & "')"

        ESSA.Execute(SQL)
        MsgBox("Settings updated successfully..!", MsgBoxStyle.Information)

    End Sub

    Private Sub ImportMasters_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblLStat.Text = "Connected..!"
        SQL = "select tablename from importtable"
        With ESSA.OpenReader(SQL)
            lstTL.Items.Clear()
            While .Read
                lstTL.Items.Add(.Item(0))
            End While
            .Close()
        End With

        LoadDatabase()

    End Sub

    Private Sub txtTL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTL.KeyDown

        If e.KeyCode = Keys.Enter Then

            If lstTL.FindStringExact(txtTL.Text) = -1 Then

                SQL = "insert into importtable values ('" _
                    & txtTL.Text.Trim & "')"
                ESSA.Execute(SQL)
                lstTL.Items.Add(txtTL.Text.Trim)
                txtTL.Clear()


            End If

        End If

    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click

        If MsgBox("Are you sure, do you want to import master data..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        btnImport.Enabled = False
        PictureBox1.Visible = True
        BW.RunWorkerAsync()
        btnImport.Enabled = True
        PictureBox1.Visible = False

    End Sub

    Private Sub BW_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            For i As SByte = 0 To lstTL.Items.Count - 1

                BW.ReportProgress(0)
                SQL = "DELETE FROM " & lstTL.Items(i)
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                BW.ReportProgress(1)
                SQL = "INSERT INTO " & lstTL.Items(i) _
                    & " SELECT * FROM " & txtSQL2.Text & "." & txtDB2.Text.Trim & ".DBO." & lstTL.Items(i)
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                BW.ReportProgress(3)

            Next

            Trn.Commit()
            Con.Close()
            MsgBox("Data has been imported successfully..!", vbExclamation)

        Catch ex As SqlException
            BW.ReportProgress(2)
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub BW_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BW.ProgressChanged

        lblStatus.Refresh()

        If e.ProgressPercentage = 0 Then
            lblStatus.Text = "Cleaning..!"
        ElseIf e.ProgressPercentage = 1 Then
            lblStatus.Text = "Importing..!"
        ElseIf e.ProgressPercentage = 2 Then
            lblStatus.Text = "Interupted due to error..!"
        ElseIf e.ProgressPercentage = 3 Then
            lblStatus.Text = "Import Completed..!"
        End If

    End Sub

End Class