' In the name of Allah, Most Merciful, Most Compassionate

Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Net

Public Class frmEMessage

#Region "Group"

    Private Sub loadContactGroup()

        SQL = "select distinct cgroup from contacts where len(cgroup)>0 order by cgroup"
        ESSA.LoadCombo(cmbGroup, SQL, "cgroup")

        SQL = "select distinct cgroup from contacts where len(cgroup)>0 order by cgroup"
        ESSA.LoadCombo(cmbGroup2, SQL, "cgroup")

    End Sub

    Private Sub frmEMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

            Case Keys.Escape

                If pnlContact.Visible = True Then pnlContact.Visible = False : Exit Sub
                If pnlTemplate.Visible = True Then pnlTemplate.Visible = False : Exit Sub
                If pnlContactList.Visible = True Then pnlContactList.Visible = False : Exit Sub

        End Select

    End Sub

    Private Sub frmEMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim findTableExists As Boolean = True

        SQL = "select name from sys.objects where name = 'Templates' and type = 'u'"
        With ESSA.OpenReader(SQL)
            If Not .HasRows Then
                findTableExists = False
            End If
            .Close()
        End With

        If Not findTableExists Then

            generateScript()
            Exit Sub

        End If


        SQL = "select param_value from settings where param_name='SMSApi'"
        Dim apiValid As String = ESSA.GenerateData(SQL)

        If apiValid = "" Then
            lblSettings.Visible = True
        End If


        Call loadContactGroup()
        Call loadSMSApi()

        ESSA.AlignHeader(TGList, 1, DataGridViewContentAlignment.MiddleCenter)

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

        SQL = "select sno,cname,phone from contacts where cgroup='" _
            & cmbGroup.Text.Trim & "' order by cname"

        TG.Rows.Clear()
        With ESSA.OpenReader(SQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
                TG.Item(3, TG.Rows.Count - 1).Value = "r"
            End While
            .Close()
        End With

        lblCount.Text = TG.Rows.Count

    End Sub

    Private Sub TG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 3 Then

            If MsgBox("Do you want to delete this number..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            SQL = "delete from contacts where sno=" & Val(TG.Item(0, e.RowIndex).Value)
            ESSA.Execute(SQL)
            TG.Rows.RemoveAt(e.RowIndex)

        End If

    End Sub

    Private Sub TG_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles TG.RowsRemoved

        lblCount.Text = TG.Rows.Count

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        loadContactGroup()
        pnlContact.Visible = False

    End Sub

    Private Sub btnNewContact_Click(sender As Object, e As EventArgs) Handles btnNewContact.Click

        pnlContact.Visible = True
        cmbGroup2.Focus()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If cmbGroup2.Text.Trim = "" Then
            MsgBox("Group name cannot be empty..!", MsgBoxStyle.Critical)
            cmbGroup2.Focus()
            Exit Sub
        ElseIf txtName.Text.Trim = "" Then
            MsgBox("Name cannot be empty..!", MsgBoxStyle.Critical)
            txtName.Focus()
            Exit Sub
        ElseIf txtPhone.Text.Trim = "" Then
            MsgBox("Phone cannot be empty..!", MsgBoxStyle.Critical)
            txtPhone.Focus()
            Exit Sub
        ElseIf ESSA.ISFound("select sno from contacts where phone='" & txtPhone.Text.Trim & "'") Then
            MsgBox("Phone number already exists..!", MsgBoxStyle.Critical)
            txtPhone.Focus()
            Exit Sub
        End If

        If MsgBox("Do you want to update..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim slno = ESSA.GenerateID("select max(sno) from contacts")

        SQL = "insert into contacts values ('" _
            & cmbGroup2.Text.Trim & "','" _
            & txtName.Text.Trim & "','" _
            & txtPhone.Text.Trim & "'," _
            & slno & ")"

        ESSA.Execute(SQL)

        lblStatus.Visible = True

        txtName.Clear()
        txtPhone.Clear()
        cmbGroup2.Focus()

    End Sub

    Private Sub tabCtl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabCtl.SelectedIndexChanged

        Select Case tabCtl.SelectedIndex

            Case 0

            Case 1

                loadContactGroup()
                cmbGroup.Focus()

            Case 2

                loadTemplates()

        End Select

    End Sub

#End Region

#Region "Template"

    Private tempID As Short = 0

    Private Sub loadTemplates()

        SQL = "select tid,tname,tdesc from templates order by tname"
        With ESSA.OpenReader(SQL)
            TG2.Rows.Clear()
            While .Read
                TG2.Rows.Add()
                TG2.Item(0, TG2.Rows.Count - 1).Value = .Item(0)
                TG2.Item(1, TG2.Rows.Count - 1).Value = .GetString(1).Trim
                TG2.Item(2, TG2.Rows.Count - 1).Value = "View"
                TG2.Item(3, TG2.Rows.Count - 1).Value = "Pick"
                TG2.Item(5, TG2.Rows.Count - 1).Value = .GetString(2).Trim
            End While
            .Close()
        End With

    End Sub

    Private Sub btnNewTemplate_Click(sender As Object, e As EventArgs) Handles btnNewTemplate.Click

        pnlTemplate.Visible = True
        txtTemplate.Focus()

    End Sub

    Private Sub btnHide2_Click(sender As Object, e As EventArgs) Handles btnHide2.Click

        pnlTemplate.Visible = False
        btnDelete.Visible = False
        btnOr.Visible = False

    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged

        lblLength.Text = txtDesc.Text.Trim.Length

    End Sub

#End Region

    Private tempEdit As Boolean = False

    Private Sub btnUpdate3_Click(sender As Object, e As EventArgs) Handles btnUpdate3.Click

        If txtTemplate.Text.Trim = "" Then
            MsgBox("Template name cannot be empty..!", MsgBoxStyle.Critical)
            txtTemplate.Focus()
            Exit Sub
        ElseIf txtDesc.Text.Trim = "" Then
            MsgBox("Description cannot be empty..!", MsgBoxStyle.Critical)
            txtName.Focus()
            Exit Sub
        ElseIf ESSA.ISFound("select tid from templates where tname='" & txtTemplate.Text.Trim & "' and tid<>" & tempID) Then
            MsgBox("Template name already exists..!", MsgBoxStyle.Critical)
            txtTemplate.Focus()
            Exit Sub
        End If


        If MsgBox("Do you want to update..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        If tempID > 0 Then

            SQL = "delete from templates where tid=" & tempID
            ESSA.Execute(SQL)

        Else

            tempID = ESSA.GenerateID("select max(tid) from templates")

        End If

        SQL = "insert into templates values (" _
            & tempID & ",'" _
            & txtTemplate.Text.Trim & "','" _
            & txtDesc.Text.Trim & "')"

        ESSA.Execute(SQL)

        MsgBox("Entry updated successfully..!", MsgBoxStyle.Exclamation)

        clearTemplates()

    End Sub

    Private Sub clearTemplates()

        txtTemplate.Clear()
        txtDesc.Clear()
        txtTemplate.Focus()
        tempID = 0
        loadTemplates()

    End Sub

    Private Sub TG2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG2.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 2 Then

            viewTemplate(TG2.Item(0, e.RowIndex).Value)

        ElseIf e.ColumnIndex = 3 Then

            txtSMS.Text = TG2.Item(5, e.RowIndex).Value
            tabCtl.SelectedIndex = 3

        End If

    End Sub

    Private Sub viewTemplate(templateID As Short)

        SQL = "select * from templates where tid=" & templateID
        With ESSA.OpenReader(SQL)
            If .Read Then
                tempID = .Item(0)
                txtTemplate.Text = .GetString(1).Trim
                txtDesc.Text = .GetString(2).Trim
                btnDelete.Visible = True
                btnOr.Visible = True
                pnlTemplate.Visible = True
                txtTemplate.Focus()
            End If
            .Close()
        End With

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If MsgBox("Do you want to delete..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        SQL = "delete from templates where tid=" & tempID
        ESSA.Execute(SQL)

        MsgBox("Entry deleted successfully..!", MsgBoxStyle.Exclamation)

        pnlTemplate.Visible = False
        btnDelete.Visible = False
        btnOr.Visible = False
        clearTemplates()

    End Sub

    Private Sub cmbGroup2_Leave(sender As Object, e As EventArgs) Handles cmbGroup2.Leave

        lblStatus.Visible = False

    End Sub

    Private Sub chkMM_CheckedChanged(sender As Object, e As EventArgs) Handles chkMM.CheckedChanged

        txtGroup3.ReadOnly = Not chkMM.Checked
        txtGroup3.Text = ""
        lblMM.Visible = chkMM.Checked
        btnPick.Enabled = Not chkMM.Checked
        If chkMM.Checked Then txtGroup3.Focus()

    End Sub

    Private Sub btnHide3_Click(sender As Object, e As EventArgs) Handles btnHide3.Click

        pnlContactList.Visible = False

    End Sub

    Private Sub btnPickTemplate_Click(sender As Object, e As EventArgs) Handles btnPickTemplate.Click

        tabCtl.SelectedIndex = 2

    End Sub

    Private Sub btnPick_Click(sender As Object, e As EventArgs) Handles btnPick.Click

        SQL = "select cgroup,count(*) from contacts group by cgroup order by cgroup"
        With ESSA.OpenReader(SQL)
            TGList.Rows.Clear()
            While .Read
                TGList.Rows.Add()
                TGList.Item(0, TGList.Rows.Count - 1).Value = .GetString(0).Trim
                TGList.Item(1, TGList.Rows.Count - 1).Value = .Item(1)
            End While
            .Close()
        End With

        If TGList.Rows.Count > 0 Then
            pnlContactList.Visible = True
            TGList.Focus()
        End If

    End Sub

    Private Sub chkSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectAll.CheckedChanged

        For i As Short = 0 To TGList.Rows.Count - 1
            TGList.Item(2, i).Value = IIf(chkSelectAll.Checked, 1, 0)
        Next

    End Sub

    Private tblContacts As New DataTable

    Private Sub fillContactTable(groupList As String)

        SQL = "select cname,phone from contacts where cgroup in (" & groupList & ") order by cname"
        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            tblContacts.Columns.Clear()
            Adp.Fill(tblContacts)
        End Using
        Con.Close()

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        Dim validated As Boolean = False

        For i As Short = 0 To TGList.Rows.Count - 1
            If Val(TGList.Item(2, i).Value) = 1 Then
                validated = True
                Exit For
            End If
        Next

        If Not validated Then

            MsgBox("Please select contact list..!", MsgBoxStyle.Critical)
            Exit Sub

        End If

        Dim groupList As String = ""

        For i As Short = 0 To TGList.Rows.Count - 1
            If Val(TGList.Item(2, i).Value) = 1 Then
                groupList &= "'" & TGList.Item(0, i).Value & "',"
                Exit For
            End If
        Next

        groupList = Mid(groupList, 1, groupList.Length - 1)

        txtGroup3.Text = groupList.Replace("'", "")

        Call fillContactTable(groupList)

        pnlContactList.Visible = False

    End Sub

    Private Sub chkSelectTemplate_Click(sender As Object, e As EventArgs) Handles chkSelectTemplate.Click

        txtSMS.Text = txtDesc.Text.Trim
        tabCtl.SelectedIndex = 3
        pnlTemplate.Visible = False

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        '// SMSApi Settings

        SQL = "update settings set param_value='{0}' where param_name='SMSApi'"
        ESSA.Execute(String.Format(SQL, txtHTTP.Text.Trim))

        '// SMSApi Username

        SQL = "update settings set param_value='{0}' where param_name='SMSApiUN'"
        ESSA.Execute(String.Format(SQL, txtUsername.Text.Trim))

        '// SMSApi Password

        SQL = "update settings set param_value='{0}' where param_name='SMSApiPW'"
        ESSA.Execute(String.Format(SQL, txtPassword.Text))

        MsgBox("Settings updated successfully")

        pnlSMSSettings.Visible = False

    End Sub

    Private Sub loadSMSApi()

        '// Load SMSApi Settings

        SQL = "select param_value from settings where param_name='SMSApi'"
        txtHTTP.Text = ESSA.GenerateData(SQL)

        '// Load SMSUN Settings

        SQL = "select param_value from settings where param_name='SMSApiUN'"
        txtUsername.Text = ESSA.GenerateData(SQL)

        '// Load SMSPW Settings

        SQL = "select param_value from settings where param_name='SMSApiPW'"
        txtPassword.Text = ESSA.GenerateData(SQL)

        '// Apply Api Settings

        SMSApi = Replace(txtHTTP.Text.Trim, "@ID", txtUsername.Text.Trim)
        SMSApi = Replace(SMSApi, "@Pwd", txtPassword.Text)

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        Call loadSMSApi()

        pnlSMSSettings.Visible = True

        txtHTTP.Focus()

    End Sub

    Private Sub btnHide4_Click(sender As Object, e As EventArgs) Handles btnHide4.Click

        pnlSMSSettings.Visible = False

    End Sub

    Private Function validateSenderList() As Boolean

        If chkMM.Checked = True Then

            validateSenderList = IIf(txtGroup3.Text.Trim.Length = 0, False, True)

        Else

            validateSenderList = IIf(tblContacts.Rows.Count = 0, False, True)

        End If

    End Function

    Private Sub prepareManualList()

        prepareContactTable()

        Dim items = txtGroup3.Text.Trim.Split(";")

        For Each item As String In items

            If item.Trim.Length = 10 Then

                Dim dr As DataRow = tblContacts.NewRow

                dr(0) = "Person" : dr(1) = item.Trim

                tblContacts.Rows.Add(dr)

            End If

        Next

    End Sub

    Private Sub prepareContactTable()

        tblContacts.Columns.Clear()

        tblContacts.Columns.Add("CName", System.Type.GetType("System.String"))
        tblContacts.Columns.Add("Phone", System.Type.GetType("System.String"))

    End Sub

    Private Sub btnSendSMS_Click(sender As Object, e As EventArgs) Handles btnSendSMS.Click

        If chkMM.Checked = True Then

            prepareManualList()

        End If

        If Not validateSenderList() Then
            MsgBox("Sender List should not be empty..!", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf txtSMS.Text.Trim = "" Then
            MsgBox("Please type any message..!", MsgBoxStyle.Information)
            txtSMS.Focus()
            Exit Sub
        ElseIf DNSTest() = False Then
            MsgBox("Connection Error, Check your internet connection..!", vbCritical)
            Exit Sub
        End If

        If MsgBox("Do you want to send message..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing

        For i As Short = 0 To tblContacts.Rows.Count - 1

            If tblContacts.Rows(i).Item(1).ToString.Length = 10 Then

                Try

                    request = DirectCast(WebRequest.Create(FinalURL(tblContacts.Rows(i).Item(1), txtSMS.Text)), HttpWebRequest)
                    response = DirectCast(request.GetResponse(), HttpWebResponse)
                    response.Close()

                Catch ex As Exception


                End Try

            End If

        Next

        MsgBox("Message Send Successfully..!", MsgBoxStyle.Exclamation)

    End Sub

    Private SMSApi As String = ""

    Private Function FinalURL(PhNo As String, SMS As String) As String

        FinalURL = Replace(SMSApi, "@PhNo", "91" & PhNo)
        FinalURL = Replace(FinalURL, "@Text", SMS)

    End Function

    Private Function DNSTest() As Boolean

        Try

            Dim ipHe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry("www.google.com")
            DNSTest = True

        Catch ex As Exception
            DNSTest = False
        End Try

    End Function

    Private Sub btnImportContacts_Click(sender As Object, e As EventArgs) Handles btnImportContacts.Click

        pnlImportContacts.Show()
        btnBrowseFile.Focus()

    End Sub

    Private Sub btnBrowseFile_Click(sender As Object, e As EventArgs) Handles btnBrowseFile.Click

        If OFD1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            txtBrowseFile.Text = OFD1.FileName

        End If

    End Sub

    Private Sub btnOK2_Click(sender As Object, e As EventArgs) Handles btnOK2.Click

        If MsgBox("Do you want to update ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        '// if the File extension is .XLSX using below connection string

        Dim tblExcel As New DataTable

        Dim szConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" _
                                         & "Data Source='" & txtBrowseFile.Text.Trim _
                                         & "';Extended Properties=Excel 12.0 XML;"


        Using xlCon As New OleDbConnection(szConnectionString)

            xlCon.Open()

            Using Adp As New OleDbDataAdapter("SELECT * FROM [SHEET1$]", xlCon)

                Adp.Fill(tblExcel)

            End Using

            xlCon.Close()

        End Using

        '// insert data into database

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand

        SQL = "delete from contactsduplex"
        Cmd.CommandText = SQL
        Cmd.ExecuteNonQuery()

        For i As Integer = 0 To tblExcel.Rows.Count - 1

            If tblExcel.Rows(i).Item(2).ToString.Trim.Length > 0 Then

                SQL = "insert into contactsduplex values ('" _
                    & tblExcel.Rows(i).Item(0) & "','" _
                    & tblExcel.Rows(i).Item(1) & "','" _
                    & tblExcel.Rows(i).Item(2) & "'," _
                    & i + 1 & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            End If

        Next

        SQL = "insert into contacts " _
            & "select * from contactsduplex where phone not in " _
            & "(select distinct phone from contacts)"

        Cmd.CommandText = SQL
        Cmd.ExecuteNonQuery()

        pnlImportContacts.Hide()

        MsgBox("Data updated successfully..!", MsgBoxStyle.Information)

    End Sub

    Private Sub btnHide5_Click(sender As Object, e As EventArgs) Handles btnHide5.Click

        pnlImportContacts.Hide()

    End Sub

    '// Script for e-messanger

    Private Sub generateScript()

        '// Remove old settings

        SQL = "delete from settings where param_name='SMSApi';" _
            & "delete from settings where param_name='SMSApiUN';" _
            & "delete from settings where param_name='SMSApiPW'"

        ESSA.Execute(SQL)

        '// Update new settings

        SQL = "insert into settings values ('SMSApi', '');" _
            & "insert into settings values ('SMSApiUN', '');" _
            & "insert into settings values ('SMSApiPW', '');"

        ESSA.Execute(SQL)



        '// Insert into contacts

        SQL = "if exists (select * from sys.objects where name = 'Contacts' and type = 'u') " _
            & "drop table Contacts"

        ESSA.Execute(SQL)

        SQL = "CREATE TABLE [dbo].[Contacts](" _
            & "[cgroup] [varchar](20) NULL," _
            & "[cname] [varchar](20) NULL," _
            & "[phone] [varchar](10) NULL," _
            & "[sno] [int] NULL" _
            & ") ON [PRIMARY]"

        ESSA.Execute(SQL)



        '// Insert into contactsduplex

        SQL = "if exists (select * from sys.objects where name = 'ContactsDuplex' and type = 'u') " _
            & "drop table ContactsDuplex"

        ESSA.Execute(SQL)

        SQL = "CREATE TABLE [dbo].[ContactsDuplex](" _
            & "[cgroup] [varchar](20) NULL," _
            & "[cname] [varchar](20) NULL," _
            & "[phone] [varchar](10) NULL," _
            & "[sno] [int] NULL" _
            & ") ON [PRIMARY]"

        ESSA.Execute(SQL)



        '// Create template table

        SQL = "if exists (select * from sys.objects where name = 'Templates' and type = 'u') " _
            & "drop table Templates"

        ESSA.Execute(SQL)

        SQL = "CREATE TABLE [dbo].[Templates](" _
            & "[tid] [tinyint] NULL," _
            & "[tname] [varchar](50) NULL," _
            & "[tdesc] [varchar](300) NULL" _
            & ") ON [PRIMARY]"

        ESSA.Execute(SQL)

    End Sub

End Class