<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnUs = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtRtype = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.rdoAdmin = New System.Windows.Forms.RadioButton()
        Me.rdoUser = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkAOD = New System.Windows.Forms.CheckBox()
        Me.chkLDV = New System.Windows.Forms.CheckBox()
        Me.txtDis = New System.Windows.Forms.TextBox()
        Me.lblPer = New System.Windows.Forms.Label()
        Me.lblDis = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnManageUsr = New System.Windows.Forms.Button()
        Me.btnUM = New System.Windows.Forms.Label()
        Me.cmbUsers = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LstModule = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LstChkLst = New System.Windows.Forms.CheckedListBox()
        Me.chkAllowPOS = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControlEX1 = New Dotnetrix.Controls.TabControlEX()
        Me.TabPageEX1 = New Dotnetrix.Controls.TabPageEX()
        Me.TabPageEX2 = New Dotnetrix.Controls.TabPageEX()
        Me.TTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControlEX1.SuspendLayout()
        Me.TabPageEX1.SuspendLayout()
        Me.TabPageEX2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUs
        '
        Me.btnUs.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUs.Location = New System.Drawing.Point(5, 4)
        Me.btnUs.Name = "btnUs"
        Me.btnUs.Size = New System.Drawing.Size(90, 42)
        Me.btnUs.TabIndex = 0
        Me.btnUs.Text = "Users"
        Me.btnUs.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Retype Password"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(19, 64)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(263, 25)
        Me.txtUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(19, 111)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(263, 25)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtRtype
        '
        Me.txtRtype.Location = New System.Drawing.Point(19, 155)
        Me.txtRtype.Name = "txtRtype"
        Me.txtRtype.Size = New System.Drawing.Size(263, 25)
        Me.txtRtype.TabIndex = 2
        Me.txtRtype.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(12, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "User info"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(12, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "User type"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightGray
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(305, 196)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'rdoAdmin
        '
        Me.rdoAdmin.AutoSize = True
        Me.rdoAdmin.Checked = True
        Me.rdoAdmin.Location = New System.Drawing.Point(19, 228)
        Me.rdoAdmin.Name = "rdoAdmin"
        Me.rdoAdmin.Size = New System.Drawing.Size(105, 21)
        Me.rdoAdmin.TabIndex = 6
        Me.rdoAdmin.TabStop = True
        Me.rdoAdmin.Text = "Administrator"
        Me.rdoAdmin.UseVisualStyleBackColor = True
        '
        'rdoUser
        '
        Me.rdoUser.AutoSize = True
        Me.rdoUser.Location = New System.Drawing.Point(145, 228)
        Me.rdoUser.Name = "rdoUser"
        Me.rdoUser.Size = New System.Drawing.Size(59, 21)
        Me.rdoUser.TabIndex = 7
        Me.rdoUser.TabStop = True
        Me.rdoUser.Text = "Users"
        Me.rdoUser.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(301, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Options"
        '
        'chkAOD
        '
        Me.chkAOD.AutoSize = True
        Me.chkAOD.Location = New System.Drawing.Point(305, 89)
        Me.chkAOD.Name = "chkAOD"
        Me.chkAOD.Size = New System.Drawing.Size(164, 21)
        Me.chkAOD.TabIndex = 9
        Me.chkAOD.Text = "Allow override discount"
        Me.chkAOD.UseVisualStyleBackColor = True
        '
        'chkLDV
        '
        Me.chkLDV.AutoSize = True
        Me.chkLDV.Location = New System.Drawing.Point(305, 115)
        Me.chkLDV.Name = "chkLDV"
        Me.chkLDV.Size = New System.Drawing.Size(159, 21)
        Me.chkLDV.TabIndex = 10
        Me.chkLDV.Text = "Limited Discount Value"
        Me.chkLDV.UseVisualStyleBackColor = True
        '
        'txtDis
        '
        Me.txtDis.Location = New System.Drawing.Point(373, 155)
        Me.txtDis.Name = "txtDis"
        Me.txtDis.Size = New System.Drawing.Size(46, 25)
        Me.txtDis.TabIndex = 11
        Me.txtDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDis.Visible = False
        '
        'lblPer
        '
        Me.lblPer.AutoSize = True
        Me.lblPer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPer.Location = New System.Drawing.Point(425, 156)
        Me.lblPer.Name = "lblPer"
        Me.lblPer.Size = New System.Drawing.Size(19, 17)
        Me.lblPer.TabIndex = 12
        Me.lblPer.Text = "%"
        Me.lblPer.Visible = False
        '
        'lblDis
        '
        Me.lblDis.AutoSize = True
        Me.lblDis.Location = New System.Drawing.Point(302, 158)
        Me.lblDis.Name = "lblDis"
        Me.lblDis.Size = New System.Drawing.Size(58, 17)
        Me.lblDis.TabIndex = 13
        Me.lblDis.Text = "Discount"
        Me.lblDis.Visible = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.LightGray
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Location = New System.Drawing.Point(386, 196)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnManageUsr
        '
        Me.btnManageUsr.BackColor = System.Drawing.Color.LightGray
        Me.btnManageUsr.FlatAppearance.BorderSize = 0
        Me.btnManageUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageUsr.Location = New System.Drawing.Point(305, 225)
        Me.btnManageUsr.Name = "btnManageUsr"
        Me.btnManageUsr.Size = New System.Drawing.Size(156, 27)
        Me.btnManageUsr.TabIndex = 5
        Me.btnManageUsr.Text = "Manage Users"
        Me.btnManageUsr.UseVisualStyleBackColor = False
        '
        'btnUM
        '
        Me.btnUM.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUM.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUM.Location = New System.Drawing.Point(92, 9)
        Me.btnUM.Name = "btnUM"
        Me.btnUM.Size = New System.Drawing.Size(300, 37)
        Me.btnUM.TabIndex = 14
        Me.btnUM.Text = "User management"
        Me.btnUM.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cmbUsers
        '
        Me.cmbUsers.FormattingEnabled = True
        Me.cmbUsers.Location = New System.Drawing.Point(16, 60)
        Me.cmbUsers.Name = "cmbUsers"
        Me.cmbUsers.Size = New System.Drawing.Size(379, 25)
        Me.cmbUsers.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGray
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 21)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "List of Users"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 17)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Username"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGray
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 21)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Main Module"
        '
        'LstModule
        '
        Me.LstModule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstModule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstModule.FormattingEnabled = True
        Me.LstModule.ItemHeight = 17
        Me.LstModule.Location = New System.Drawing.Point(3, 24)
        Me.LstModule.Name = "LstModule"
        Me.LstModule.Size = New System.Drawing.Size(183, 145)
        Me.LstModule.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkGray
        Me.Label14.Location = New System.Drawing.Point(192, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 21)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Program List"
        '
        'LstChkLst
        '
        Me.LstChkLst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstChkLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstChkLst.FormattingEnabled = True
        Me.LstChkLst.Location = New System.Drawing.Point(192, 24)
        Me.LstChkLst.Name = "LstChkLst"
        Me.LstChkLst.Size = New System.Drawing.Size(184, 145)
        Me.LstChkLst.TabIndex = 20
        '
        'chkAllowPOS
        '
        Me.chkAllowPOS.AutoSize = True
        Me.chkAllowPOS.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllowPOS.Location = New System.Drawing.Point(305, 64)
        Me.chkAllowPOS.Name = "chkAllowPOS"
        Me.chkAllowPOS.Size = New System.Drawing.Size(85, 19)
        Me.chkAllowPOS.TabIndex = 8
        Me.chkAllowPOS.Text = "Allow POS"
        Me.chkAllowPOS.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LstChkLst, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LstModule, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(16, 91)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(379, 172)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'TabControlEX1
        '
        Me.TabControlEX1.Appearance = Dotnetrix.Controls.TabAppearanceEX.FlatTab
        Me.TabControlEX1.Controls.Add(Me.TabPageEX1)
        Me.TabControlEX1.Controls.Add(Me.TabPageEX2)
        Me.TabControlEX1.FlatBorderColor = System.Drawing.Color.White
        Me.TabControlEX1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlEX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabControlEX1.ItemSize = New System.Drawing.Size(0, 1)
        Me.TabControlEX1.Location = New System.Drawing.Point(8, 49)
        Me.TabControlEX1.Name = "TabControlEX1"
        Me.TabControlEX1.SelectedIndex = 1
        Me.TabControlEX1.SelectedTabFontStyle = System.Drawing.FontStyle.Bold
        Me.TabControlEX1.Size = New System.Drawing.Size(483, 289)
        Me.TabControlEX1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControlEX1.TabIndex = 0
        Me.TabControlEX1.UseVisualStyles = False
        '
        'TabPageEX1
        '
        Me.TabPageEX1.Controls.Add(Me.Label5)
        Me.TabPageEX1.Controls.Add(Me.Label2)
        Me.TabPageEX1.Controls.Add(Me.chkAllowPOS)
        Me.TabPageEX1.Controls.Add(Me.Label3)
        Me.TabPageEX1.Controls.Add(Me.Label4)
        Me.TabPageEX1.Controls.Add(Me.txtUsername)
        Me.TabPageEX1.Controls.Add(Me.txtPassword)
        Me.TabPageEX1.Controls.Add(Me.btnManageUsr)
        Me.TabPageEX1.Controls.Add(Me.txtRtype)
        Me.TabPageEX1.Controls.Add(Me.lblDis)
        Me.TabPageEX1.Controls.Add(Me.Label6)
        Me.TabPageEX1.Controls.Add(Me.lblPer)
        Me.TabPageEX1.Controls.Add(Me.btnSave)
        Me.TabPageEX1.Controls.Add(Me.txtDis)
        Me.TabPageEX1.Controls.Add(Me.btnReset)
        Me.TabPageEX1.Controls.Add(Me.chkLDV)
        Me.TabPageEX1.Controls.Add(Me.rdoAdmin)
        Me.TabPageEX1.Controls.Add(Me.chkAOD)
        Me.TabPageEX1.Controls.Add(Me.rdoUser)
        Me.TabPageEX1.Controls.Add(Me.Label7)
        Me.TabPageEX1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPageEX1.Location = New System.Drawing.Point(4, 14)
        Me.TabPageEX1.Name = "TabPageEX1"
        Me.TabPageEX1.Size = New System.Drawing.Size(475, 271)
        Me.TabPageEX1.TabIndex = 0
        Me.TabPageEX1.Text = "Users"
        '
        'TabPageEX2
        '
        Me.TabPageEX2.Controls.Add(Me.Label11)
        Me.TabPageEX2.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPageEX2.Controls.Add(Me.cmbUsers)
        Me.TabPageEX2.Controls.Add(Me.Label12)
        Me.TabPageEX2.Location = New System.Drawing.Point(4, 5)
        Me.TabPageEX2.Name = "TabPageEX2"
        Me.TabPageEX2.Size = New System.Drawing.Size(475, 280)
        Me.TabPageEX2.TabIndex = 1
        Me.TabPageEX2.Text = "User management"
        '
        'TTip
        '
        Me.TTip.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        Me.TTip.ToolTipTitle = "Error..!"
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(499, 352)
        Me.Controls.Add(Me.TabControlEX1)
        Me.Controls.Add(Me.btnUM)
        Me.Controls.Add(Me.btnUs)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Users"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabControlEX1.ResumeLayout(False)
        Me.TabPageEX1.ResumeLayout(False)
        Me.TabPageEX1.PerformLayout()
        Me.TabPageEX2.ResumeLayout(False)
        Me.TabPageEX2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUs As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtRtype As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents rdoAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUser As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkAOD As System.Windows.Forms.CheckBox
    Friend WithEvents chkLDV As System.Windows.Forms.CheckBox
    Friend WithEvents txtDis As System.Windows.Forms.TextBox
    Friend WithEvents lblPer As System.Windows.Forms.Label
    Friend WithEvents lblDis As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnManageUsr As System.Windows.Forms.Button
    Friend WithEvents btnUM As System.Windows.Forms.Label
    Friend WithEvents cmbUsers As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LstModule As System.Windows.Forms.ListBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LstChkLst As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkAllowPOS As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TabControlEX1 As Dotnetrix.Controls.TabControlEX
    Friend WithEvents TabPageEX1 As Dotnetrix.Controls.TabPageEX
    Friend WithEvents TabPageEX2 As Dotnetrix.Controls.TabPageEX
    Friend WithEvents TTip As System.Windows.Forms.ToolTip
End Class
