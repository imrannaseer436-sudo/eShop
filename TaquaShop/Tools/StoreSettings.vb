'****************************************** Bismillah ************************************
Imports System.Xml
Imports System.Data.SqlClient
Public Class StoreSettings

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim ConnectionString As String = "Data Source=" & txtSqlserver.Text.Trim & ";" _
                         & "Initial Catalog=" & txtDatabase.Text.Trim & ";" _
                         & "User ID=" & txtUsername.Text.Trim & ";" _
                         & "Password=" & txtPassword.Text & ";"

        Dim XTag As String = "<ShopSettings>" & vbCrLf _
                           & "<DBSettings>" & ClsEncodeDecode.Encode(ConnectionString) & "</DBSettings>" & vbCrLf _
                           & "<ShopCode>" & txtShopCode.Text.Trim & "</ShopCode>" & vbCrLf _
                           & "<VersionPath>" & txtVersionPath.Text.Trim & "</VersionPath>" & vbCrLf _
                           & "<SQLSERVER>" & txtSqlserver.Text.Trim & "</SQLSERVER>" & vbCrLf _
                           & "<USERID>" & txtUsername.Text.Trim & "</USERID>" & vbCrLf _
                           & "<PASSWORD>" & ClsEncodeDecode.Encode(txtPassword.Text) & "</PASSWORD>" & vbCrLf _
                           & "<DATABASE>" & txtDatabase.Text.Trim & "</DATABASE>" & vbCrLf _
                           & "<POSPRINTER>" & txtPOSPrinter.Text.Trim & "</POSPRINTER>" & vbCrLf _
                           & "</ShopSettings>"

        Dim nCon As New SqlConnection(ConnectionString)
        Try
            nCon.Open()
            If nCon.State = ConnectionState.Open Then
                nCon.Close()
            End If
            nCon.Dispose()
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            nCon.Dispose()
            Exit Sub
        End Try

        Dim xDoc As New XmlDocument
        xDoc.LoadXml(XTag)
        xDoc.Save(My.Application.Info.DirectoryPath & "\ShopSettings.xml")
        MsgBox("Congratulations, Settings updated successfully..!", vbExclamation)


    End Sub

    Private Sub StoreSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub StoreSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\ShopSettings.xml") = True Then

            Dim xDoc As XmlReader = XmlReader.Create(My.Application.Info.DirectoryPath & "\ShopSettings.xml")
                While xDoc.Read
                If xDoc.Name = "SQLSERVER" Then
                    txtSqlserver.Text = xDoc.ReadElementString("SQLSERVER")
                ElseIf xDoc.Name = "USERID" Then
                    txtUsername.Text = xDoc.ReadElementString("USERID")
                ElseIf xDoc.Name = "PASSWORD" Then
                    txtPassword.Text = ClsEncodeDecode.DCode(xDoc.ReadElementString("PASSWORD"))
                ElseIf xDoc.Name = "DATABASE" Then
                    txtDatabase.Text = xDoc.ReadElementString("DATABASE")
                ElseIf xDoc.Name = "VersionPath" Then
                    txtVersionPath.Text = xDoc.ReadElementString("VersionPath")
                ElseIf xDoc.Name = "ShopCode" Then
                    txtShopCode.Text = xDoc.ReadElementString("ShopCode")
                ElseIf xDoc.Name = "POSPRINTER" Then
                    txtPOSPrinter.Text = xDoc.ReadElementString("POSPRINTER")
                End If
                End While
            xDoc.Close()

        End If

    End Sub

    Private Sub txtVersionPath_TextChanged(sender As Object, e As EventArgs) Handles txtVersionPath.TextChanged

    End Sub

    Private Sub txtPOSPrinter_TextChanged(sender As Object, e As EventArgs) Handles txtPOSPrinter.TextChanged

    End Sub

    Private Sub txtShopCode_TextChanged(sender As Object, e As EventArgs) Handles txtShopCode.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtDatabase_TextChanged(sender As Object, e As EventArgs) Handles txtDatabase.TextChanged

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtSqlserver_TextChanged(sender As Object, e As EventArgs) Handles txtSqlserver.TextChanged

    End Sub
End Class