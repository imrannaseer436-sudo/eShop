<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImporterNew
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReloadData = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSQLS = New System.Windows.Forms.TextBox()
        Me.txtUIDS = New System.Windows.Forms.TextBox()
        Me.txtPWDS = New System.Windows.Forms.TextBox()
        Me.txtDBSS = New System.Windows.Forms.TextBox()
        Me.btnSourceUpdate = New System.Windows.Forms.Button()
        Me.btnReloadSettings = New System.Windows.Forms.Button()
        Me.btnLocalUpdate = New System.Windows.Forms.Button()
        Me.txtDBS = New System.Windows.Forms.TextBox()
        Me.txtPWD = New System.Windows.Forms.TextBox()
        Me.txtUID = New System.Windows.Forms.TextBox()
        Me.txtSQL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(403, 444)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnReloadData)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TG)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(395, 417)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Importer"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnLocalUpdate)
        Me.TabPage2.Controls.Add(Me.txtDBS)
        Me.TabPage2.Controls.Add(Me.txtPWD)
        Me.TabPage2.Controls.Add(Me.txtUID)
        Me.TabPage2.Controls.Add(Me.txtSQL)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.btnReloadSettings)
        Me.TabPage2.Controls.Add(Me.btnSourceUpdate)
        Me.TabPage2.Controls.Add(Me.txtDBSS)
        Me.TabPage2.Controls.Add(Me.txtPWDS)
        Me.TabPage2.Controls.Add(Me.txtUIDS)
        Me.TabPage2.Controls.Add(Me.txtSQLS)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(395, 417)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.TG.Location = New System.Drawing.Point(8, 39)
        Me.TG.Name = "TG"
        Me.TG.RowHeadersVisible = False
        Me.TG.Size = New System.Drawing.Size(378, 370)
        Me.TG.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 60
        '
        'Column4
        '
        Me.Column4.HeaderText = "Import"
        Me.Column4.Name = "Column4"
        Me.Column4.Text = "Import"
        Me.Column4.Width = 60
        '
        'Column5
        '
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IMPORTS AVAILABLE"
        '
        'btnReloadData
        '
        Me.btnReloadData.Location = New System.Drawing.Point(292, 9)
        Me.btnReloadData.Name = "btnReloadData"
        Me.btnReloadData.Size = New System.Drawing.Size(94, 23)
        Me.btnReloadData.TabIndex = 2
        Me.btnReloadData.Text = "Reload Data"
        Me.btnReloadData.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SOURCE DATABASE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "LOCAL DATABASE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "SQL Server"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 14)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 14)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 14)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Database"
        '
        'txtSQLS
        '
        Me.txtSQLS.Location = New System.Drawing.Point(96, 44)
        Me.txtSQLS.Name = "txtSQLS"
        Me.txtSQLS.Size = New System.Drawing.Size(289, 20)
        Me.txtSQLS.TabIndex = 0
        '
        'txtUIDS
        '
        Me.txtUIDS.Location = New System.Drawing.Point(96, 77)
        Me.txtUIDS.Name = "txtUIDS"
        Me.txtUIDS.Size = New System.Drawing.Size(289, 20)
        Me.txtUIDS.TabIndex = 1
        '
        'txtPWDS
        '
        Me.txtPWDS.Location = New System.Drawing.Point(96, 110)
        Me.txtPWDS.Name = "txtPWDS"
        Me.txtPWDS.Size = New System.Drawing.Size(289, 20)
        Me.txtPWDS.TabIndex = 2
        Me.txtPWDS.UseSystemPasswordChar = True
        '
        'txtDBSS
        '
        Me.txtDBSS.Location = New System.Drawing.Point(96, 143)
        Me.txtDBSS.Name = "txtDBSS"
        Me.txtDBSS.Size = New System.Drawing.Size(289, 20)
        Me.txtDBSS.TabIndex = 3
        '
        'btnSourceUpdate
        '
        Me.btnSourceUpdate.Location = New System.Drawing.Point(291, 181)
        Me.btnSourceUpdate.Name = "btnSourceUpdate"
        Me.btnSourceUpdate.Size = New System.Drawing.Size(94, 23)
        Me.btnSourceUpdate.TabIndex = 4
        Me.btnSourceUpdate.Text = "Update"
        Me.btnSourceUpdate.UseVisualStyleBackColor = True
        '
        'btnReloadSettings
        '
        Me.btnReloadSettings.Location = New System.Drawing.Point(291, 9)
        Me.btnReloadSettings.Name = "btnReloadSettings"
        Me.btnReloadSettings.Size = New System.Drawing.Size(94, 23)
        Me.btnReloadSettings.TabIndex = 7
        Me.btnReloadSettings.Text = "Reload Settings"
        Me.btnReloadSettings.UseVisualStyleBackColor = True
        '
        'btnLocalUpdate
        '
        Me.btnLocalUpdate.Location = New System.Drawing.Point(291, 379)
        Me.btnLocalUpdate.Name = "btnLocalUpdate"
        Me.btnLocalUpdate.Size = New System.Drawing.Size(94, 23)
        Me.btnLocalUpdate.TabIndex = 9
        Me.btnLocalUpdate.Text = "Update"
        Me.btnLocalUpdate.UseVisualStyleBackColor = True
        '
        'txtDBS
        '
        Me.txtDBS.Location = New System.Drawing.Point(96, 341)
        Me.txtDBS.Name = "txtDBS"
        Me.txtDBS.Size = New System.Drawing.Size(289, 20)
        Me.txtDBS.TabIndex = 8
        '
        'txtPWD
        '
        Me.txtPWD.Location = New System.Drawing.Point(96, 308)
        Me.txtPWD.Name = "txtPWD"
        Me.txtPWD.Size = New System.Drawing.Size(289, 20)
        Me.txtPWD.TabIndex = 7
        Me.txtPWD.UseSystemPasswordChar = True
        '
        'txtUID
        '
        Me.txtUID.Location = New System.Drawing.Point(96, 275)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.Size = New System.Drawing.Size(289, 20)
        Me.txtUID.TabIndex = 6
        '
        'txtSQL
        '
        Me.txtSQL.Location = New System.Drawing.Point(96, 242)
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New System.Drawing.Size(289, 20)
        Me.txtSQL.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 14)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Database"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 14)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 278)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 14)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Username"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 245)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 14)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "SQL Server"
        '
        'ImporterNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 444)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ImporterNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importer New"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnReloadData As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnLocalUpdate As System.Windows.Forms.Button
    Friend WithEvents txtDBS As System.Windows.Forms.TextBox
    Friend WithEvents txtPWD As System.Windows.Forms.TextBox
    Friend WithEvents txtUID As System.Windows.Forms.TextBox
    Friend WithEvents txtSQL As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnReloadSettings As System.Windows.Forms.Button
    Friend WithEvents btnSourceUpdate As System.Windows.Forms.Button
    Friend WithEvents txtDBSS As System.Windows.Forms.TextBox
    Friend WithEvents txtPWDS As System.Windows.Forms.TextBox
    Friend WithEvents txtUIDS As System.Windows.Forms.TextBox
    Friend WithEvents txtSQLS As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TTip As System.Windows.Forms.ToolTip
End Class
