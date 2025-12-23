'****************************************** Bismillah ***********************************
Imports System.Data.SqlClient
Imports System.Xml
Public Class Login

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        If txtUsername.Text.Trim = "" Then
            TTip.Show("Username cannot be empty..!", txtUsername, 0, 25, 2000)
            txtUsername.Focus()
            Exit Sub
        ElseIf txtPassword.Text.Trim = "" Then
            TTip.Show("Password cannot be empty..!", txtPassword, 0, 25, 2000)
            txtPassword.Focus()
            Exit Sub
        End If

        SQL = "select userid,username,isadmin from users where username='" & txtUsername.Text.Trim & "' " _
            & "and password='" & ClsEncodeDecode.Encode(txtPassword.Text) & "'; select param_value from settings where param_name='TaxVersion';"
        With ESSA.OpenReader(SQL)
            If .Read Then
                UserID = .Item(0)
                UserName = .GetString(1)
                IsAdmin = IIf(.Item(2), True, False)

                If .NextResult Then
                    If .Read Then
                        TaxVersion = CShort(.Item(0))
                    End If
                End If
                .Close()
                MainWindow.Show()
                Me.Close()
                Exit Sub
            End If

        End With

        TTip.Show("Incorrect username or password..!", btnLogin, 0, 25, 2000)
        txtPassword.Clear()
        txtPassword.SelectAll()
        txtPassword.Focus()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If

    End Sub

    Private Sub Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Escape
                Close()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Async Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click

        SQL = "select password from users where isadmin = 1"
        Dim isFound = False
        With Await ESSA.OpenReaderAsync(SQL)
            While Await .ReadAsync
                If txtPassword.Text = ClsEncodeDecode.DCode(.Item(0)) Then
                    isFound = True
                    Exit While
                End If
            End While
            .Close()
        End With

        If isFound Then
            StoreSettings.Show()
        Else
            TTip.Show("please enter admin password..!", txtPassword, 0, 25, 2000)
            txtPassword.Focus()
        End If

    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblVer.Text = "Build Version " & My.Application.AppVersion

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\ShopSettings.xml") = True Then

            Dim xDoc As XmlReader = XmlReader.Create(My.Application.Info.DirectoryPath & "\ShopSettings.xml")
            While xDoc.Read
                If xDoc.Name = "DBSettings" Then
                    ConStr = ClsEncodeDecode.DCode(xDoc.ReadElementString("DBSettings"))
                ElseIf xDoc.Name = "ShopCode" Then
                    ShopCode = xDoc.ReadElementString("ShopCode")
                ElseIf xDoc.Name = "POSPRINTER" Then
                    POSPrinterName = xDoc.ReadElementString("POSPRINTER")
                End If
            End While
            xDoc.Close()


            'If ConStr.Trim.Length > 0 Then
            '    If ESSA.GenerateID("select max(userid) from users") = 1 Then
            '        btnNewUser.Visible = True
            '    End If
            'End If

        Else

            MsgBox("Application settings not configured..!", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub btnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewUser.Click

        Users.Show()
        Me.Close()

    End Sub

End Class