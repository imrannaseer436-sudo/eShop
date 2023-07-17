Imports System.Net.NetworkInformation

Public Class frmPrinterLocations

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlPrinter.Hide()

    End Sub

    Private Sub loadPrinterList()

        SQL = "SELECT * FROM PrinterLocations ORDER BY Id"
        With ESSA.OpenReader(SQL)
            dgv.Rows.Clear()
            While .Read
                dgv.Rows.Add()
                dgv.Item(0, dgv.Rows.Count - 1).Value = .Item(0)
                dgv.Item(1, dgv.Rows.Count - 1).Value = .GetString(1).Trim
                dgv.Item(2, dgv.Rows.Count - 1).Value = .GetString(2).Trim
                dgv.Item(3, dgv.Rows.Count - 1).Value = .Item(3)
            End While
            .Close()
        End With

    End Sub

    Private Sub frmPrinterLocations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadPrinterList()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtName.Text.Trim = "" Then
            MsgBox("Printer name cannot be empty.", MsgBoxStyle.Critical)
            txtName.Focus()
            Exit Sub
        ElseIf txtBatch.Text.Trim = "" Then
            MsgBox("Batch location cannot be empty.", MsgBoxStyle.Critical)
            txtBatch.Focus()
            Exit Sub
        ElseIf ESSA.ISFound("SELECT Id FROM PrinterLocations WHERE Name='" & txtName.Text.Trim & "'") Then
            MsgBox("Printer name already exists.", MsgBoxStyle.Critical)
            txtName.Focus()
            Exit Sub
        End If

        Dim printerId = ESSA.GenerateID("SELECT MAX(Id) FROM PrinterLocations")

        SQL = "INSERT INTO PrinterLocations VALUES (" _
            & printerId & ",'" _
            & txtName.Text.Trim & "','" _
            & txtBatch.Text.Trim & "'," _
            & IIf(chkSuspended.Checked, 1, 0) & ",'" _
            & getMacAddress() & "')"

        ESSA.Execute(SQL)

        txtName.Clear()
        txtBatch.Clear()

    End Sub

    Private Sub frmPrinterLocations_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If
            Case Keys.Escape
                If MsgBox("Do you want to exit..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Close()

        End Select

    End Sub

    Private Function getMacAddress() As String

        Dim nics() As NetworkInterface =
              NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString

    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        pnlPrinter.Show()
        txtName.Focus()

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        If OFD1.ShowDialog = DialogResult.OK Then
            txtBatch.Text = OFD1.FileName
        End If

    End Sub

End Class