'******************************************** Bismillah *******************************************
Imports System.Data.SqlClient
Public Class Terminals

    Private TermID As SByte
    Private Edit As Boolean = False
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        If txtTCode.Text.Trim = "" Then
            MsgBox("Terminal code cannot be empty!", MsgBoxStyle.Critical)
            txtTCode.Focus()
            Exit Sub
        ElseIf txtDesc.Text.Trim = "" Then
            MsgBox("Terminal description cannot be empty!", MsgBoxStyle.Critical)
            txtDesc.Focus()
            Exit Sub
        End If

        SQL = "SELECT TermId FROM Terminal WHERE ShopId = " & ShopID & " AND TermId = " & Val(txtTCode.Text.Trim)
        If ESSA.ISFound(SQL) And txtTCode.Enabled = True Then
            MsgBox("Terminal already exists!")
            Exit Sub
        End If

        If txtTCode.Enabled = False Then
            SQL = "DELETE Terminal WHERE TermId = " & Val(txtTCode.Text)
            ESSA.Execute(SQL)
            'GenerateTerminalID()
        End If

        SQL = "insert into terminal values (" _
            & Val(txtTCode.Text) & "," _
            & ShopID & ",'" _
            & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "',0," _
            & UserID & ",'" _
            & txtDesc.Text.Trim & "')"

        ESSA.Execute(SQL)

        LoadTerminalList()
        txtTCode.Clear()

    End Sub

    Private Sub LoadTerminalList()

        SQL = "SELECT TermId, Description FROM Terminal WHERE ShopId = " & ShopID & " ORDER BY TermId"
        TGList.Rows.Clear()
        With ESSA.OpenReader(SQL)
            While .Read
                TGList.Rows.Add()
                TGList.Item(0, TGList.Rows.Count - 1).Value = .Item(0)
                TGList.Item(1, TGList.Rows.Count - 1).Value = .GetString(1).Trim
            End While
            .Close()
        End With

        'SQL = "select termid from terminal order by termid"
        'ESSA.LoadDataGrid(TGList, SQL)

    End Sub

    Private Sub GenerateTerminalID()

        SQL = "select max(termid) from terminal"
        TermID = ESSA.GenerateID(SQL)

    End Sub

    Private Sub txtTCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnCreate.PerformClick()
        End If

    End Sub

    Private Sub Terminals_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadTerminalList()

    End Sub

    Private Sub TGList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TGList.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 2 Then
            txtTCode.Text = TGList.Item(0, e.RowIndex).Value
            txtDesc.Text = TGList.Item(1, e.RowIndex).Value
            editMode(True)
        End If

    End Sub

    Private Sub editMode(enable As Boolean)

        btnCreate.Text = IIf(enable, "UPDATE", "CREATE")
        txtTCode.Enabled = If(enable = True, False, True)

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtTCode.Clear()
        txtDesc.Clear()
        editMode(False)
        txtTCode.Focus()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close()

    End Sub

End Class