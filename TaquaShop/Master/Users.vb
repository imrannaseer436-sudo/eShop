'*************************************************** Bismillah ******************************
Imports System.Data.SqlClient
Public Class Users

    Private Edit As Boolean = False
    Private UID As SByte = 0

    Private Sub btnUs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUs.Click

        ActivateTab(True)

    End Sub

    Private Sub ActivateTab(ByVal ISUserTab As Boolean)

        If ISUserTab = True Then
            btnUs.ForeColor = Color.FromArgb(192, 0, 0)
            btnUs.Font = New Font("Segoe UI", 20.25F)
            btnUM.ForeColor = Color.Gainsboro
            btnUM.Font = New Font("Segoe UI", 15.75F)
            TabControlEX1.SelectedIndex = 0
        Else
            btnUM.ForeColor = Color.FromArgb(192, 0, 0)
            btnUM.Font = New Font("Segoe UI", 20.25F)
            btnUs.ForeColor = Color.Gainsboro
            btnUs.Font = New Font("Segoe UI", 15.75F)
            TabControlEX1.SelectedIndex = 1
        End If

    End Sub

    Private Sub btnUM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUM.Click

        ActivateTab(False)

    End Sub

    Private Sub Users_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F5
                btnReset.PerformClick()
            Case Keys.Escape
                Close()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TabControlEX1.SelectedIndex = 0
        txtUsername.Select()

        SQL = "select userid,username from users order by username"
        ESSA.LoadCombo(cmbUsers, SQL, "username", "userid")

    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If txtUsername.Text.Trim = "" Then
                TTip.Show("Username should not be empty..!", txtUsername, 0, 25, 2000)
                Exit Sub
            ElseIf ESSA.ISFound("select userid from users where username='" & txtUsername.Text.Trim & "'" & IIf(Edit = True, " and userid<>" & UserID, "")) = True Then
                TTip.Show("Username already exists..!", txtUsername, 0, 25, 2000)
                txtUsername.SelectAll()
                txtUsername.Focus()
                Exit Sub
            ElseIf txtPassword.Text <> txtRtype.Text Then
                TTip.Show("Mismatch retype password..!", txtRtype, 0, 25, 2000)
                txtRtype.Clear()
                txtRtype.Focus()
                Exit Sub
            End If

        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtUsername.Text.Trim = "" Then
            TTip.Show("Username should not be empty..!", txtUsername, 0, 25, 2000)
            Exit Sub
        ElseIf ESSA.ISFound("select userid from users where username='" & txtUsername.Text.Trim & "'" & IIf(Edit = True, " and userid<>" & UserID, "")) = True Then
            TTip.Show("Username already exists..!", txtUsername, 0, 25, 2000)
            txtUsername.SelectAll()
            txtUsername.Focus()
            Exit Sub
        ElseIf txtPassword.Text <> txtRtype.Text Then
            TTip.Show("Mismatch retype password..!", txtRtype, 0, 25, 2000)
            txtRtype.Clear()
            txtRtype.Focus()
            Exit Sub
        End If

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then
                SQL = "delete from users where userid=" & UserID
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                GenerateUserID()
            End If

            SQL = "insert into users values (" _
                & UID & ",'" _
                & txtUsername.Text.Trim & "','" _
                & ClsEncodeDecode.Encode(txtPassword.Text) & "'," _
                & IIf(rdoAdmin.Checked = True, 1, 0) & "," _
                & IIf(chkAllowPOS.Checked = True, 1, 0) & "," _
                & IIf(chkAOD.Checked = True, 1, 0) & "," _
                & IIf(chkLDV.Checked = True, 1, 0) & "," _
                & IIf(chkLDV.Checked = True, Val(txtDis.Text), 0) & ",'" _
                & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
                & ShopID & "," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()
            MsgBox("User details updated successfully..!", vbExclamation)
            btnReset.PerformClick()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub GenerateUserID()

        SQL = "select max(userid) from users"
        UID = ESSA.GenerateID(SQL)

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        Edit = False
        txtUsername.Clear()
        txtPassword.Clear()
        txtRtype.Clear()
        chkAllowPOS.Checked = False
        chkAOD.Checked = False
        chkLDV.Checked = False
        txtUsername.Focus()

    End Sub

    Private Sub chkLDV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLDV.CheckedChanged

        If chkLDV.Checked = True Then
            lblDis.Visible = True
            txtDis.Visible = True
            lblPer.Visible = True
        Else
            lblDis.Visible = False
            txtDis.Visible = False
            lblPer.Visible = False
        End If

    End Sub

    Private Sub cmbUsers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUsers.SelectedIndexChanged

        If cmbUsers.SelectedIndex = -1 Then Exit Sub

        SQL = "select distinct headid,headname from menulist order by headid"
        ESSA.LoadList(LstModule, SQL, "headname", "headid")

    End Sub

    Private Sub LstModule_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstModule.Click

        SQL = "select menuid,menuname from menulist where headid=" & LstModule.SelectedValue _
            & " order by menuid"
        ESSA.LoadList(LstChkLst, SQL, "menuname", "menuid")

    End Sub

End Class