Public Class frmRateUpdater

    Private Pluid As Integer = 0

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            SQL = "SELECT PluId, Pluname, RetailPrice FROM ProductMaster WHERE Plucode='" & txtCode.Text.Trim & "'"
            With ESSA.OpenReader(SQL)
                If .Read Then
                    Pluid = .Item(0)
                    txtName.Text = .GetString(1).Trim
                    txtRate.Text = Format(.Item(2), "0.00")
                    txtRate.Focus()
                Else
                    MsgBox("Code not found.", MsgBoxStyle.Critical)
                    Pluid = 0
                End If
                .Close()
            End With
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If Pluid = 0 Then
            MsgBox("Code not found.", MsgBoxStyle.Critical)
            txtCode.Focus()
            Exit Sub
        ElseIf Val(txtRate.Text) <= 0 Then
            MsgBox("Rate cannot be zero.", MsgBoxStyle.Critical)
            txtRate.Focus()
            Exit Sub
        End If

        If MsgBox("Do you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Using Cmd As New SqlClient.SqlCommand("UpdateRate", Con)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Pluid", Pluid)
            Cmd.Parameters.AddWithValue("@Rate", Val(txtRate.Text))
            Cmd.ExecuteNonQuery()
        End Using
        Con.Close()

        MsgBox("Rate Updated!", MsgBoxStyle.Information)
        txtCode.Clear()
        txtName.Clear()
        txtRate.Clear()
        Pluid = 0
        txtCode.Focus()

    End Sub

    Private Sub frmRateUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class