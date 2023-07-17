<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesPerson
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.btnAddSalesPerson = New System.Windows.Forms.Button()
        Me.pnlRegister = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSupervisor = New System.Windows.Forms.ComboBox()
        Me.rdoDiscontinued = New System.Windows.Forms.RadioButton()
        Me.rdoWorking = New System.Windows.Forms.RadioButton()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.txtPerc = New System.Windows.Forms.TextBox()
        Me.txtFloor = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSPID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column8, Me.Column5, Me.Column6, Me.Column7})
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.Location = New System.Drawing.Point(12, 12)
        Me.TG.Name = "TG"
        Me.TG.ReadOnly = True
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TG.RowHeadersVisible = False
        Me.TG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TG.Size = New System.Drawing.Size(506, 390)
        Me.TG.TabIndex = 0
        Me.TG.Tag = "1"
        '
        'btnAddSalesPerson
        '
        Me.btnAddSalesPerson.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSalesPerson.Location = New System.Drawing.Point(12, 409)
        Me.btnAddSalesPerson.Name = "btnAddSalesPerson"
        Me.btnAddSalesPerson.Size = New System.Drawing.Size(143, 28)
        Me.btnAddSalesPerson.TabIndex = 1
        Me.btnAddSalesPerson.Text = "&Add Sales Person - F2"
        Me.btnAddSalesPerson.UseVisualStyleBackColor = True
        '
        'pnlRegister
        '
        Me.pnlRegister.BackColor = System.Drawing.Color.White
        Me.pnlRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRegister.Controls.Add(Me.Label1)
        Me.pnlRegister.Controls.Add(Me.cmbSupervisor)
        Me.pnlRegister.Controls.Add(Me.rdoDiscontinued)
        Me.pnlRegister.Controls.Add(Me.rdoWorking)
        Me.pnlRegister.Controls.Add(Me.btnHide)
        Me.pnlRegister.Controls.Add(Me.btnUpdate)
        Me.pnlRegister.Controls.Add(Me.SimpleLine1)
        Me.pnlRegister.Controls.Add(Me.txtPerc)
        Me.pnlRegister.Controls.Add(Me.txtFloor)
        Me.pnlRegister.Controls.Add(Me.txtName)
        Me.pnlRegister.Controls.Add(Me.txtSPID)
        Me.pnlRegister.Controls.Add(Me.Label5)
        Me.pnlRegister.Controls.Add(Me.Label4)
        Me.pnlRegister.Controls.Add(Me.Label3)
        Me.pnlRegister.Controls.Add(Me.Label2)
        Me.pnlRegister.Controls.Add(Me.lblRegister)
        Me.pnlRegister.Location = New System.Drawing.Point(35, 67)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Size = New System.Drawing.Size(460, 305)
        Me.pnlRegister.TabIndex = 2
        Me.pnlRegister.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SUPERVISOR"
        '
        'cmbSupervisor
        '
        Me.cmbSupervisor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupervisor.FormattingEnabled = True
        Me.cmbSupervisor.Items.AddRange(New Object() {"No", "Yes"})
        Me.cmbSupervisor.Location = New System.Drawing.Point(137, 180)
        Me.cmbSupervisor.Name = "cmbSupervisor"
        Me.cmbSupervisor.Size = New System.Drawing.Size(75, 24)
        Me.cmbSupervisor.TabIndex = 4
        '
        'rdoDiscontinued
        '
        Me.rdoDiscontinued.AutoSize = True
        Me.rdoDiscontinued.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDiscontinued.ForeColor = System.Drawing.Color.Red
        Me.rdoDiscontinued.Location = New System.Drawing.Point(115, 254)
        Me.rdoDiscontinued.Name = "rdoDiscontinued"
        Me.rdoDiscontinued.Size = New System.Drawing.Size(108, 20)
        Me.rdoDiscontinued.TabIndex = 7
        Me.rdoDiscontinued.Text = "Discontinued"
        Me.rdoDiscontinued.UseVisualStyleBackColor = True
        '
        'rdoWorking
        '
        Me.rdoWorking.AutoSize = True
        Me.rdoWorking.Checked = True
        Me.rdoWorking.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoWorking.ForeColor = System.Drawing.Color.Blue
        Me.rdoWorking.Location = New System.Drawing.Point(30, 254)
        Me.rdoWorking.Name = "rdoWorking"
        Me.rdoWorking.Size = New System.Drawing.Size(78, 20)
        Me.rdoWorking.TabIndex = 6
        Me.rdoWorking.TabStop = True
        Me.rdoWorking.Text = "Working"
        Me.rdoWorking.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Black
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(425, -1)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(34, 26)
        Me.btnHide.TabIndex = 8
        Me.btnHide.Text = "r"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(319, 251)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 30)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Enabled = False
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.Gainsboro
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(32, 230)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(397, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 7
        Me.SimpleLine1.UseGradient = False
        '
        'txtPerc
        '
        Me.txtPerc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPerc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPerc.Location = New System.Drawing.Point(137, 148)
        Me.txtPerc.Name = "txtPerc"
        Me.txtPerc.Size = New System.Drawing.Size(75, 23)
        Me.txtPerc.TabIndex = 3
        Me.txtPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFloor
        '
        Me.txtFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFloor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFloor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFloor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFloor.Location = New System.Drawing.Point(137, 115)
        Me.txtFloor.MaxLength = 1
        Me.txtFloor.Name = "txtFloor"
        Me.txtFloor.Size = New System.Drawing.Size(75, 23)
        Me.txtFloor.TabIndex = 2
        Me.txtFloor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(137, 82)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(292, 23)
        Me.txtName.TabIndex = 1
        '
        'txtSPID
        '
        Me.txtSPID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSPID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSPID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSPID.Location = New System.Drawing.Point(137, 49)
        Me.txtSPID.Name = "txtSPID"
        Me.txtSPID.Size = New System.Drawing.Size(75, 23)
        Me.txtSPID.TabIndex = 0
        Me.txtSPID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "PERC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FLOOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "PERSON NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SP Code"
        '
        'lblRegister
        '
        Me.lblRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRegister.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRegister.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.ForeColor = System.Drawing.Color.White
        Me.lblRegister.Location = New System.Drawing.Point(0, 0)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(458, 25)
        Me.lblRegister.TabIndex = 0
        Me.lblRegister.Text = "Sales Person Register"
        Me.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(393, 417)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "SUPER - SUPERVISOR"
        '
        'Column9
        '
        Me.Column9.HeaderText = "ID"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "SPID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "PERSON NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "FLOOR"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 60
        '
        'Column4
        '
        Me.Column4.HeaderText = "PERC (%)"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 60
        '
        'Column8
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column8.HeaderText = "SUPER"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 50
        '
        'Column5
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 30
        '
        'Column6
        '
        Me.Column6.HeaderText = ""
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 23
        '
        'Column7
        '
        Me.Column7.HeaderText = "Status"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'SalesPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 446)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pnlRegister)
        Me.Controls.Add(Me.btnAddSalesPerson)
        Me.Controls.Add(Me.TG)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "SalesPerson"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Person"
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddSalesPerson As System.Windows.Forms.Button
    Friend WithEvents pnlRegister As System.Windows.Forms.Panel
    Friend WithEvents lblRegister As System.Windows.Forms.Label
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents txtPerc As System.Windows.Forms.TextBox
    Friend WithEvents txtFloor As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtSPID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdoDiscontinued As System.Windows.Forms.RadioButton
    Friend WithEvents rdoWorking As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSupervisor As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
