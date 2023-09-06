<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStockAuditNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle97 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle98 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle104 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle99 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle100 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle101 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle102 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle103 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ConsolePanel = New System.Windows.Forms.Panel()
        Me.PBLoading = New System.Windows.Forms.ProgressBar()
        Me.BtnSave = New FontAwesome.Sharp.IconButton()
        Me.BtnUpload = New System.Windows.Forms.Button()
        Me.BtnDisplay = New System.Windows.Forms.Button()
        Me.CmbCat = New System.Windows.Forms.ComboBox()
        Me.CmbDept = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtRemarks = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.PictureBoxClose = New FontAwesome.Sharp.IconPictureBox()
        Me.TitlePanel2 = New System.Windows.Forms.Panel()
        Me.TitleIconBox = New FontAwesome.Sharp.IconPictureBox()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.GrdPanel = New System.Windows.Forms.Panel()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblUpload = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblVariation = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblUploadCP = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblStockCP = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblVariationCP = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DetailsPanel = New System.Windows.Forms.Panel()
        Me.ConsolePanel.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel2.SuspendLayout()
        CType(Me.TitleIconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrdPanel.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConsolePanel
        '
        Me.ConsolePanel.BackColor = System.Drawing.Color.White
        Me.ConsolePanel.Controls.Add(Me.PBLoading)
        Me.ConsolePanel.Controls.Add(Me.DetailsPanel)
        Me.ConsolePanel.Controls.Add(Me.BtnSave)
        Me.ConsolePanel.Controls.Add(Me.BtnUpload)
        Me.ConsolePanel.Controls.Add(Me.BtnDisplay)
        Me.ConsolePanel.Controls.Add(Me.CmbCat)
        Me.ConsolePanel.Controls.Add(Me.CmbDept)
        Me.ConsolePanel.Controls.Add(Me.Panel1)
        Me.ConsolePanel.Controls.Add(Me.Label4)
        Me.ConsolePanel.Controls.Add(Me.TxtRemarks)
        Me.ConsolePanel.Controls.Add(Me.Label3)
        Me.ConsolePanel.Controls.Add(Me.Label1)
        Me.ConsolePanel.Controls.Add(Me.Label2)
        Me.ConsolePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ConsolePanel.Location = New System.Drawing.Point(0, 35)
        Me.ConsolePanel.Margin = New System.Windows.Forms.Padding(2)
        Me.ConsolePanel.Name = "ConsolePanel"
        Me.ConsolePanel.Size = New System.Drawing.Size(1044, 179)
        Me.ConsolePanel.TabIndex = 1
        '
        'PBLoading
        '
        Me.PBLoading.BackColor = System.Drawing.Color.White
        Me.PBLoading.Location = New System.Drawing.Point(367, 129)
        Me.PBLoading.Margin = New System.Windows.Forms.Padding(2)
        Me.PBLoading.Name = "PBLoading"
        Me.PBLoading.Size = New System.Drawing.Size(240, 25)
        Me.PBLoading.TabIndex = 36
        Me.PBLoading.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSave.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnSave.IconColor = System.Drawing.Color.Black
        Me.BtnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSave.Location = New System.Drawing.Point(531, 69)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(76, 25)
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnUpload
        '
        Me.BtnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.BtnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpload.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpload.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUpload.Location = New System.Drawing.Point(449, 69)
        Me.BtnUpload.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUpload.Name = "BtnUpload"
        Me.BtnUpload.Size = New System.Drawing.Size(76, 25)
        Me.BtnUpload.TabIndex = 3
        Me.BtnUpload.Text = "UPLOAD"
        Me.BtnUpload.UseVisualStyleBackColor = False
        '
        'BtnDisplay
        '
        Me.BtnDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.BtnDisplay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDisplay.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisplay.ForeColor = System.Drawing.Color.Transparent
        Me.BtnDisplay.Location = New System.Drawing.Point(367, 69)
        Me.BtnDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(76, 25)
        Me.BtnDisplay.TabIndex = 2
        Me.BtnDisplay.Text = "DISPLAY"
        Me.BtnDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDisplay.UseVisualStyleBackColor = False
        '
        'CmbCat
        '
        Me.CmbCat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CmbCat.FormattingEnabled = True
        Me.CmbCat.Location = New System.Drawing.Point(192, 69)
        Me.CmbCat.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbCat.Name = "CmbCat"
        Me.CmbCat.Size = New System.Drawing.Size(155, 25)
        Me.CmbCat.TabIndex = 1
        '
        'CmbDept
        '
        Me.CmbDept.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CmbDept.FormattingEnabled = True
        Me.CmbDept.Location = New System.Drawing.Point(15, 69)
        Me.CmbDept.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbDept.Name = "CmbDept"
        Me.CmbDept.Size = New System.Drawing.Size(155, 25)
        Me.CmbDept.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Location = New System.Drawing.Point(15, 26)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(125, 1)
        Me.Panel1.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(188, 48)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "CATEGORY"
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRemarks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TxtRemarks.Location = New System.Drawing.Point(15, 129)
        Me.TxtRemarks.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(332, 25)
        Me.TxtRemarks.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "DEPARTMENT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "REMARKS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "PRODUCT FILTER"
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TitlePanel.Controls.Add(Me.PictureBoxClose)
        Me.TitlePanel.Controls.Add(Me.TitlePanel2)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Margin = New System.Windows.Forms.Padding(2)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(1044, 35)
        Me.TitlePanel.TabIndex = 0
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBoxClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxClose.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.PictureBoxClose.IconColor = System.Drawing.Color.White
        Me.PictureBoxClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PictureBoxClose.IconSize = 30
        Me.PictureBoxClose.Location = New System.Drawing.Point(1012, 5)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(30, 30)
        Me.PictureBoxClose.TabIndex = 4
        Me.PictureBoxClose.TabStop = False
        '
        'TitlePanel2
        '
        Me.TitlePanel2.Controls.Add(Me.TitleIconBox)
        Me.TitlePanel2.Controls.Add(Me.labelTitle)
        Me.TitlePanel2.Location = New System.Drawing.Point(445, 4)
        Me.TitlePanel2.Name = "TitlePanel2"
        Me.TitlePanel2.Size = New System.Drawing.Size(255, 31)
        Me.TitlePanel2.TabIndex = 3
        '
        'TitleIconBox
        '
        Me.TitleIconBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TitleIconBox.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TitleIconBox.IconChar = FontAwesome.Sharp.IconChar.Sign
        Me.TitleIconBox.IconColor = System.Drawing.SystemColors.HighlightText
        Me.TitleIconBox.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.TitleIconBox.IconSize = 28
        Me.TitleIconBox.Location = New System.Drawing.Point(3, 3)
        Me.TitleIconBox.Name = "TitleIconBox"
        Me.TitleIconBox.Size = New System.Drawing.Size(29, 28)
        Me.TitleIconBox.TabIndex = 2
        Me.TitleIconBox.TabStop = False
        '
        'labelTitle
        '
        Me.labelTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelTitle.AutoSize = True
        Me.labelTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelTitle.Location = New System.Drawing.Point(32, 2)
        Me.labelTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(221, 25)
        Me.labelTitle.TabIndex = 1
        Me.labelTitle.Text = "PHYSICAL STOCK AUDIT"
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrdPanel
        '
        Me.GrdPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GrdPanel.Controls.Add(Me.TG)
        Me.GrdPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdPanel.Location = New System.Drawing.Point(0, 214)
        Me.GrdPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.GrdPanel.Name = "GrdPanel"
        Me.GrdPanel.Size = New System.Drawing.Size(1044, 407)
        Me.GrdPanel.TabIndex = 2
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        DataGridViewCellStyle97.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.TG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle97
        Me.TG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TG.BackgroundColor = System.Drawing.Color.White
        Me.TG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle98.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle98.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer))
        DataGridViewCellStyle98.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle98.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle98.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle98.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle98.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle98
        Me.TG.ColumnHeadersHeight = 30
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column9, Me.Column10, Me.Column11})
        DataGridViewCellStyle104.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle104.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle104.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle104.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle104.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(107, Byte), Integer))
        DataGridViewCellStyle104.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle104.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TG.DefaultCellStyle = DataGridViewCellStyle104
        Me.TG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.GridColor = System.Drawing.SystemColors.HighlightText
        Me.TG.Location = New System.Drawing.Point(0, 0)
        Me.TG.Name = "TG"
        Me.TG.ReadOnly = True
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TG.RowHeadersVisible = False
        Me.TG.RowTemplate.Height = 30
        Me.TG.Size = New System.Drawing.Size(1044, 407)
        Me.TG.TabIndex = 3
        '
        'Column8
        '
        Me.Column8.HeaderText = "Pluid"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Barcode"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Design"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle99.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle99
        Me.Column4.HeaderText = "Size"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        DataGridViewCellStyle100.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle100.Format = "N2"
        DataGridViewCellStyle100.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle100
        Me.Column5.HeaderText = "Cost Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        DataGridViewCellStyle101.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle101
        Me.Column6.HeaderText = "Stock"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        DataGridViewCellStyle102.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle102
        Me.Column7.HeaderText = "Uploaded"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column9
        '
        DataGridViewCellStyle103.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle103
        Me.Column9.HeaderText = "Variation"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "STOCK CP"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'Column11
        '
        Me.Column11.HeaderText = "UPLOAD CP"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        '
        'OFD
        '
        Me.OFD.Filter = "Excel Files|*.xlsx;*.xls"
        Me.OFD.Title = "Select Excel Files"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(24, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "UPLOAD"
        '
        'LblUpload
        '
        Me.LblUpload.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUpload.ForeColor = System.Drawing.Color.Navy
        Me.LblUpload.Location = New System.Drawing.Point(105, 62)
        Me.LblUpload.Name = "LblUpload"
        Me.LblUpload.Size = New System.Drawing.Size(60, 30)
        Me.LblUpload.TabIndex = 37
        Me.LblUpload.Text = "0"
        Me.LblUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(24, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "VARIATION"
        '
        'LblVariation
        '
        Me.LblVariation.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVariation.ForeColor = System.Drawing.Color.Green
        Me.LblVariation.Location = New System.Drawing.Point(105, 93)
        Me.LblVariation.Name = "LblVariation"
        Me.LblVariation.Size = New System.Drawing.Size(60, 30)
        Me.LblVariation.TabIndex = 39
        Me.LblVariation.Text = "0"
        Me.LblVariation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(24, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "STOCK"
        '
        'LblStock
        '
        Me.LblStock.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStock.ForeColor = System.Drawing.Color.Firebrick
        Me.LblStock.Location = New System.Drawing.Point(104, 31)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(60, 30)
        Me.LblStock.TabIndex = 41
        Me.LblStock.Text = "0"
        Me.LblStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(199, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 15)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "UPLOAD VALUE"
        '
        'LblUploadCP
        '
        Me.LblUploadCP.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUploadCP.ForeColor = System.Drawing.Color.Navy
        Me.LblUploadCP.Location = New System.Drawing.Point(295, 63)
        Me.LblUploadCP.Name = "LblUploadCP"
        Me.LblUploadCP.Size = New System.Drawing.Size(99, 30)
        Me.LblUploadCP.TabIndex = 43
        Me.LblUploadCP.Text = "0.00"
        Me.LblUploadCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(199, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "STOCK VALUE"
        '
        'LblStockCP
        '
        Me.LblStockCP.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockCP.ForeColor = System.Drawing.Color.Firebrick
        Me.LblStockCP.Location = New System.Drawing.Point(295, 33)
        Me.LblStockCP.Name = "LblStockCP"
        Me.LblStockCP.Size = New System.Drawing.Size(99, 30)
        Me.LblStockCP.TabIndex = 45
        Me.LblStockCP.Text = "0.00"
        Me.LblStockCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(199, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 15)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "VARIATION"
        '
        'LblVariationCP
        '
        Me.LblVariationCP.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVariationCP.ForeColor = System.Drawing.Color.Green
        Me.LblVariationCP.Location = New System.Drawing.Point(295, 93)
        Me.LblVariationCP.Name = "LblVariationCP"
        Me.LblVariationCP.Size = New System.Drawing.Size(99, 30)
        Me.LblVariationCP.TabIndex = 47
        Me.LblVariationCP.Text = "0.00"
        Me.LblVariationCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(180, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 110)
        Me.Panel2.TabIndex = 48
        '
        'DetailsPanel
        '
        Me.DetailsPanel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DetailsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.DetailsPanel.Controls.Add(Me.Panel2)
        Me.DetailsPanel.Controls.Add(Me.LblVariationCP)
        Me.DetailsPanel.Controls.Add(Me.Label14)
        Me.DetailsPanel.Controls.Add(Me.LblStockCP)
        Me.DetailsPanel.Controls.Add(Me.Label9)
        Me.DetailsPanel.Controls.Add(Me.LblUploadCP)
        Me.DetailsPanel.Controls.Add(Me.Label12)
        Me.DetailsPanel.Controls.Add(Me.LblStock)
        Me.DetailsPanel.Controls.Add(Me.Label8)
        Me.DetailsPanel.Controls.Add(Me.LblVariation)
        Me.DetailsPanel.Controls.Add(Me.Label6)
        Me.DetailsPanel.Controls.Add(Me.LblUpload)
        Me.DetailsPanel.Controls.Add(Me.Label5)
        Me.DetailsPanel.Location = New System.Drawing.Point(634, 12)
        Me.DetailsPanel.Name = "DetailsPanel"
        Me.DetailsPanel.Size = New System.Drawing.Size(397, 154)
        Me.DetailsPanel.TabIndex = 43
        '
        'FrmStockAuditNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 621)
        Me.Controls.Add(Me.GrdPanel)
        Me.Controls.Add(Me.ConsolePanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmStockAuditNew"
        Me.Text = "FrmStockAuditNew"
        Me.ConsolePanel.ResumeLayout(False)
        Me.ConsolePanel.PerformLayout()
        Me.TitlePanel.ResumeLayout(False)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel2.ResumeLayout(False)
        Me.TitlePanel2.PerformLayout()
        CType(Me.TitleIconBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrdPanel.ResumeLayout(False)
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailsPanel.ResumeLayout(False)
        Me.DetailsPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents labelTitle As Label
    Friend WithEvents ConsolePanel As Panel
    Friend WithEvents CmbCat As ComboBox
    Friend WithEvents CmbDept As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtRemarks As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnUpload As Button
    Friend WithEvents BtnDisplay As Button
    Friend WithEvents PBLoading As ProgressBar
    Friend WithEvents GrdPanel As Panel
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents TG As DataGridView
    Friend WithEvents TitleIconBox As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents TitlePanel2 As Panel
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBoxClose As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents DetailsPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblVariationCP As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LblStockCP As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblUploadCP As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LblStock As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LblVariation As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblUpload As Label
    Friend WithEvents Label5 As Label
End Class
