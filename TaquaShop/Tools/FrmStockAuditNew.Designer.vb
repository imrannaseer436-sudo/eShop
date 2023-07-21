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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ConsolePanel = New System.Windows.Forms.Panel()
        Me.DetailsPanel = New System.Windows.Forms.Panel()
        Me.labelStock = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.labelUpload = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.labelVariation = New System.Windows.Forms.Label()
        Me.labelStockQty = New System.Windows.Forms.Label()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.IconTitle = New FontAwesome.Sharp.IconPictureBox()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.GrdPanel = New System.Windows.Forms.Panel()
        Me.MainTG = New System.Windows.Forms.DataGridView()
        Me.Pluid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Design = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cost_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Uploaded = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Variation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsolePanel.SuspendLayout()
        Me.DetailsPanel.SuspendLayout()
        Me.TitlePanel.SuspendLayout()
        CType(Me.IconTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrdPanel.SuspendLayout()
        CType(Me.MainTG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsolePanel
        '
        Me.ConsolePanel.BackColor = System.Drawing.Color.White
        Me.ConsolePanel.Controls.Add(Me.DetailsPanel)
        Me.ConsolePanel.Controls.Add(Me.btnSave)
        Me.ConsolePanel.Controls.Add(Me.btnClose)
        Me.ConsolePanel.Controls.Add(Me.btnUpload)
        Me.ConsolePanel.Controls.Add(Me.btnDisplay)
        Me.ConsolePanel.Controls.Add(Me.ProgressBar1)
        Me.ConsolePanel.Controls.Add(Me.ComboBox2)
        Me.ConsolePanel.Controls.Add(Me.ComboBox1)
        Me.ConsolePanel.Controls.Add(Me.Panel1)
        Me.ConsolePanel.Controls.Add(Me.Label4)
        Me.ConsolePanel.Controls.Add(Me.TextBox1)
        Me.ConsolePanel.Controls.Add(Me.Label3)
        Me.ConsolePanel.Controls.Add(Me.Label1)
        Me.ConsolePanel.Controls.Add(Me.Label2)
        Me.ConsolePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ConsolePanel.Location = New System.Drawing.Point(0, 41)
        Me.ConsolePanel.Margin = New System.Windows.Forms.Padding(2)
        Me.ConsolePanel.Name = "ConsolePanel"
        Me.ConsolePanel.Size = New System.Drawing.Size(1144, 186)
        Me.ConsolePanel.TabIndex = 1
        '
        'DetailsPanel
        '
        Me.DetailsPanel.Controls.Add(Me.labelStock)
        Me.DetailsPanel.Controls.Add(Me.Label9)
        Me.DetailsPanel.Controls.Add(Me.labelUpload)
        Me.DetailsPanel.Controls.Add(Me.Label8)
        Me.DetailsPanel.Controls.Add(Me.labelVariation)
        Me.DetailsPanel.Controls.Add(Me.labelStockQty)
        Me.DetailsPanel.Location = New System.Drawing.Point(895, 26)
        Me.DetailsPanel.Name = "DetailsPanel"
        Me.DetailsPanel.Size = New System.Drawing.Size(206, 133)
        Me.DetailsPanel.TabIndex = 43
        '
        'labelStock
        '
        Me.labelStock.AutoSize = True
        Me.labelStock.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStock.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.labelStock.Location = New System.Drawing.Point(30, 9)
        Me.labelStock.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelStock.Name = "labelStock"
        Me.labelStock.Size = New System.Drawing.Size(46, 17)
        Me.labelStock.TabIndex = 37
        Me.labelStock.Text = "STOCK"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(126, 106)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 17)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "0"
        '
        'labelUpload
        '
        Me.labelUpload.AutoSize = True
        Me.labelUpload.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelUpload.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.labelUpload.Location = New System.Drawing.Point(30, 58)
        Me.labelUpload.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelUpload.Name = "labelUpload"
        Me.labelUpload.Size = New System.Drawing.Size(56, 17)
        Me.labelUpload.TabIndex = 38
        Me.labelUpload.Text = "UPLOAD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(126, 58)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 17)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "0"
        '
        'labelVariation
        '
        Me.labelVariation.AutoSize = True
        Me.labelVariation.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVariation.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.labelVariation.Location = New System.Drawing.Point(30, 106)
        Me.labelVariation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelVariation.Name = "labelVariation"
        Me.labelVariation.Size = New System.Drawing.Size(71, 17)
        Me.labelVariation.TabIndex = 39
        Me.labelVariation.Text = "VARIATION"
        '
        'labelStockQty
        '
        Me.labelStockQty.AutoSize = True
        Me.labelStockQty.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStockQty.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.labelStockQty.Location = New System.Drawing.Point(126, 9)
        Me.labelStockQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelStockQty.Name = "labelStockQty"
        Me.labelStockQty.Size = New System.Drawing.Size(15, 17)
        Me.labelStockQty.TabIndex = 40
        Me.labelStockQty.Text = "0"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Transparent
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnSave.IconColor = System.Drawing.Color.Black
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.Location = New System.Drawing.Point(679, 131)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 28)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.LightPink
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Transparent
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnClose.IconColor = System.Drawing.Color.Black
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.Location = New System.Drawing.Point(760, 131)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 28)
        Me.btnClose.TabIndex = 34
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.Transparent
        Me.btnUpload.Location = New System.Drawing.Point(598, 131)
        Me.btnUpload.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(76, 28)
        Me.btnUpload.TabIndex = 33
        Me.btnUpload.Text = "UPLOAD"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnDisplay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.Transparent
        Me.btnDisplay.Location = New System.Drawing.Point(517, 131)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(76, 28)
        Me.btnDisplay.TabIndex = 32
        Me.btnDisplay.Text = "DISPLAY"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(517, 67)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(319, 28)
        Me.ProgressBar1.TabIndex = 36
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(243, 74)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(213, 21)
        Me.ComboBox2.TabIndex = 28
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(11, 74)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(213, 21)
        Me.ComboBox1.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Location = New System.Drawing.Point(15, 30)
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
        Me.Label4.Location = New System.Drawing.Point(240, 53)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "CATEGORY"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(11, 139)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(445, 22)
        Me.TextBox1.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 53)
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
        Me.Label1.Location = New System.Drawing.Point(8, 118)
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
        Me.Label2.Location = New System.Drawing.Point(11, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "PRODUCT FILTER"
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TitlePanel.Controls.Add(Me.IconTitle)
        Me.TitlePanel.Controls.Add(Me.labelTitle)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Margin = New System.Windows.Forms.Padding(2)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(1144, 41)
        Me.TitlePanel.TabIndex = 0
        '
        'IconTitle
        '
        Me.IconTitle.BackColor = System.Drawing.Color.Transparent
        Me.IconTitle.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking
        Me.IconTitle.IconColor = System.Drawing.Color.White
        Me.IconTitle.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconTitle.IconSize = 30
        Me.IconTitle.Location = New System.Drawing.Point(437, 7)
        Me.IconTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.IconTitle.Name = "IconTitle"
        Me.IconTitle.Size = New System.Drawing.Size(30, 30)
        Me.IconTitle.TabIndex = 13
        Me.IconTitle.TabStop = False
        '
        'labelTitle
        '
        Me.labelTitle.AutoSize = True
        Me.labelTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelTitle.Location = New System.Drawing.Point(471, 6)
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
        Me.GrdPanel.Controls.Add(Me.MainTG)
        Me.GrdPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdPanel.Location = New System.Drawing.Point(0, 227)
        Me.GrdPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.GrdPanel.Name = "GrdPanel"
        Me.GrdPanel.Size = New System.Drawing.Size(1144, 394)
        Me.GrdPanel.TabIndex = 2
        '
        'MainTG
        '
        Me.MainTG.AllowUserToAddRows = False
        Me.MainTG.AllowUserToDeleteRows = False
        Me.MainTG.BackgroundColor = System.Drawing.Color.White
        Me.MainTG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainTG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MainTG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MainTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MainTG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pluid, Me.Barcode, Me.Product, Me.Design, Me.Size, Me.Cost_Price, Me.Uploaded, Me.Variation})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MainTG.DefaultCellStyle = DataGridViewCellStyle2
        Me.MainTG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTG.EnableHeadersVisualStyles = False
        Me.MainTG.GridColor = System.Drawing.SystemColors.Highlight
        Me.MainTG.Location = New System.Drawing.Point(0, 0)
        Me.MainTG.Margin = New System.Windows.Forms.Padding(2)
        Me.MainTG.Name = "MainTG"
        Me.MainTG.RowHeadersVisible = False
        Me.MainTG.RowHeadersWidth = 51
        Me.MainTG.RowTemplate.Height = 24
        Me.MainTG.Size = New System.Drawing.Size(1144, 394)
        Me.MainTG.TabIndex = 10
        '
        'Pluid
        '
        Me.Pluid.HeaderText = "Pluid"
        Me.Pluid.MinimumWidth = 6
        Me.Pluid.Name = "Pluid"
        Me.Pluid.Visible = False
        '
        'Barcode
        '
        Me.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Barcode.HeaderText = "Barcode"
        Me.Barcode.MinimumWidth = 6
        Me.Barcode.Name = "Barcode"
        Me.Barcode.Width = 150
        '
        'Product
        '
        Me.Product.FillWeight = 84.52747!
        Me.Product.HeaderText = "Product"
        Me.Product.MinimumWidth = 6
        Me.Product.Name = "Product"
        Me.Product.Width = 144
        '
        'Design
        '
        Me.Design.FillWeight = 84.52747!
        Me.Design.HeaderText = "Design"
        Me.Design.MinimumWidth = 6
        Me.Design.Name = "Design"
        Me.Design.Width = 144
        '
        'Size
        '
        Me.Size.FillWeight = 110.9569!
        Me.Size.HeaderText = "Size"
        Me.Size.MinimumWidth = 6
        Me.Size.Name = "Size"
        Me.Size.Width = 188
        '
        'Cost_Price
        '
        Me.Cost_Price.FillWeight = 105.9567!
        Me.Cost_Price.HeaderText = "Cost Price"
        Me.Cost_Price.MinimumWidth = 6
        Me.Cost_Price.Name = "Cost_Price"
        Me.Cost_Price.Width = 180
        '
        'Uploaded
        '
        Me.Uploaded.FillWeight = 101.9025!
        Me.Uploaded.HeaderText = "Uploaded"
        Me.Uploaded.MinimumWidth = 6
        Me.Uploaded.Name = "Uploaded"
        Me.Uploaded.Width = 173
        '
        'Variation
        '
        Me.Variation.FillWeight = 98.61537!
        Me.Variation.HeaderText = "Variation"
        Me.Variation.MinimumWidth = 6
        Me.Variation.Name = "Variation"
        Me.Variation.Width = 168
        '
        'FrmStockAuditNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 621)
        Me.Controls.Add(Me.GrdPanel)
        Me.Controls.Add(Me.ConsolePanel)
        Me.Controls.Add(Me.TitlePanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmStockAuditNew"
        Me.Text = "FrmStockAuditNew"
        Me.ConsolePanel.ResumeLayout(False)
        Me.ConsolePanel.PerformLayout()
        Me.DetailsPanel.ResumeLayout(False)
        Me.DetailsPanel.PerformLayout()
        Me.TitlePanel.ResumeLayout(False)
        Me.TitlePanel.PerformLayout()
        CType(Me.IconTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrdPanel.ResumeLayout(False)
        CType(Me.MainTG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents labelTitle As Label
    Friend WithEvents IconTitle As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ConsolePanel As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents labelStock As Label
    Friend WithEvents labelUpload As Label
    Friend WithEvents labelVariation As Label
    Friend WithEvents labelStockQty As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DetailsPanel As Panel
    Friend WithEvents GrdPanel As Panel
    Friend WithEvents MainTG As DataGridView
    Friend WithEvents Pluid As DataGridViewTextBoxColumn
    Friend WithEvents Barcode As DataGridViewTextBoxColumn
    Friend WithEvents Product As DataGridViewTextBoxColumn
    Friend WithEvents Design As DataGridViewTextBoxColumn
    Friend WithEvents Size As DataGridViewTextBoxColumn
    Friend WithEvents Cost_Price As DataGridViewTextBoxColumn
    Friend WithEvents Uploaded As DataGridViewTextBoxColumn
    Friend WithEvents Variation As DataGridViewTextBoxColumn
End Class
