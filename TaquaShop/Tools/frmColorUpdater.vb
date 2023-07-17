Imports System.Data.SqlClient

Public Class frmColorUpdater

    Private Sub frmColorUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        createTable()

        lblMacID.Text = ESSA.getMacAddress()

        dgvList.ColumnHeadersDefaultCellStyle.Font = New Font(dgvList.Font, FontStyle.Bold)

        SQL = "SELECT  ColorId,Color FROM  TSColor WHERE ISActive=1 ORDER BY Color"
        ESSA.LoadCombo(cmbColor, SQL, "Color", "ColorId")

        SQL = "SELECT  ColorId,Color FROM  TSColor WHERE ISActive=1 ORDER BY Color"
        ESSA.LoadCombo(cmbColor2, SQL, "Color", "ColorId")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtCode.Text.Trim = "" Then
            MsgBox("Product code cannot be empty.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        SQL = "SELECT M.PluId, M.Plucode, M.Pluname, M.RetailPrice " _
            & "FROM ProductMaster M, ProductAttributes A " _
            & "WHERE M.PluId = A.PluId AND M.Plucode = '" _
            & txtCode.Text.Trim & "'"

        With ESSA.OpenReader(SQL)
            If .Read Then
                dgvList.Rows.Add()
                dgvList.Item(0, dgvList.Rows.Count - 1).Value = .Item(0)
                dgvList.Item(1, dgvList.Rows.Count - 1).Value = .GetString(1).Trim
                dgvList.Item(2, dgvList.Rows.Count - 1).Value = .GetString(2).Trim
                dgvList.Item(3, dgvList.Rows.Count - 1).Value = Format(.Item(3), "0.00")
                dgvList.Item(4, dgvList.Rows.Count - 1).Value = cmbColor.Text.Trim
                dgvList.Item(8, dgvList.Rows.Count - 1).Value = cmbColor.SelectedValue
                txtCode.Clear()
                txtCode.Focus()
            Else
                MsgBox("Product code not found!", MsgBoxStyle.Critical)
                txtCode.Focus()
            End If
            .Close()
        End With

    End Sub

    Private Sub frmColorUpdater_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Escape

                If pnlColors.Visible Then pnlColors.Hide() : Exit Sub
                If MsgBox("Do you want to exit ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Close()

        End Select

    End Sub

    Private Sub dgvList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvList.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 5 Then
            If MsgBox("Do you want to remove this code?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            dgvList.Rows.RemoveAt(e.RowIndex)
        ElseIf e.ColumnIndex = 6 Then
            pnlColors.Show()
            cmbColor2.SelectedValue = Val(dgvList.Item(8, e.RowIndex).Value)
            cmbColor2.Focus()
        End If

    End Sub

    Private Sub dgvList_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvList.RowsAdded

        lblRows.Text = dgvList.Rows.Count

    End Sub

    Private Sub dgvList_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvList.RowsRemoved

        lblRows.Text = dgvList.Rows.Count

    End Sub

    Private Sub btnUpdateColor_Click(sender As Object, e As EventArgs) Handles btnUpdateColor.Click

        If MsgBox("Do you want to update color ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        For i As Integer = 0 To dgvList.Rows.Count - 1

            dgvList.Item(4, i).Value = cmbColor.Text.Trim
            dgvList.Item(8, i).Value = cmbColor.SelectedValue

        Next

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If dgvList.Rows.Count = 0 Then
            MsgBox("No data to update !", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("Do you want to update ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            Dim entryNo = ESSA.GenerateID("SELECT MAX(ENo) FROM ColorRegister")

            For i As Short = 0 To dgvList.Rows.Count - 1

                SQL = "INSERT INTO ColorRegister VALUES (" _
                    & entryNo & ",'" _
                    & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                    & Val(dgvList.Item(0, i).Value) & "," _
                    & Val(dgvList.Item(8, i).Value) & ",'" _
                    & lblMacID.Text.Trim & "'," _
                    & i + 1 & ", 0)"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            For j As Short = 0 To dgvList.Rows.Count - 1

                SQL = "UPDATE ProductAttributes SET ColorId=" _
                    & Val(dgvList.Item(8, j).Value) & ", Color='" _
                    & Trim(dgvList.Item(4, j).Value) & "' WHERE PluId=" _
                    & Val(dgvList.Item(0, j).Value)

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()
            Con.Close()

            MsgBox("Color updated successfully..!", MsgBoxStyle.Exclamation)
            dgvList.Rows.Clear()
            txtCode.Focus()

        Catch ex As SqlException

            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlColors.Hide()

    End Sub

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnAdd.PerformClick()
        End If

    End Sub

    Private Sub btnChangeColor_Click(sender As Object, e As EventArgs) Handles btnChangeColor.Click

        dgvList.Item(8, dgvList.CurrentRow.Index).Value = cmbColor2.SelectedValue
        dgvList.Item(4, dgvList.CurrentRow.Index).Value = cmbColor2.Text.Trim

        pnlColors.Hide()

    End Sub

    Private Sub createTable()

        Dim tableExists As Boolean = False

        SQL = "SELECT * FROM sys.tables WHERE name = 'ColorRegister' AND type = 'U'"
        With ESSA.OpenReader(SQL)
            If .Read Then
                tableExists = True
            End If
            .Close()
        End With

        If Not tableExists Then

            SQL = "CREATE TABLE [dbo].[ColorRegister](
	                [ENo] [int] NULL,
	                [EDate] [smalldatetime] NULL,
	                [Pluid] [int] NULL,
	                [ColorId] [smallint] NULL,
	                [MacId] [varchar](50) NULL,
	                [Sno] [smallint] NULL,
	                [IsUpdated] [bit] NULL
                    )"

            ESSA.Execute(SQL)

        End If

    End Sub

End Class
