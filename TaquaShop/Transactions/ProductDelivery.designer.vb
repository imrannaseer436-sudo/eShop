<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductDelivery
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.lblDCode = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDCLocation = New System.Windows.Forms.ComboBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblRAmt = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LBLCAmt = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblTQty = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlImport = New System.Windows.Forms.Panel()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnGetColumn = New System.Windows.Forms.Button()
        Me.btnSendToDelivery = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbQty = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.cmbSheet = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnPick = New System.Windows.Forms.Button()
        Me.txtSelect = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.chkAutoEntry = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlImport.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnImport)
        Me.Panel1.Controls.Add(Me.lblDCode)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(805, 36)
        Me.Panel1.TabIndex = 3
        '
        'btnImport
        '
        Me.btnImport.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnImport.FlatAppearance.BorderSize = 0
        Me.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImport.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.ForeColor = System.Drawing.Color.White
        Me.btnImport.Location = New System.Drawing.Point(646, 7)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 19
        Me.btnImport.Text = "IMPORT"
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'lblDCode
        '
        Me.lblDCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDCode.ForeColor = System.Drawing.Color.Navy
        Me.lblDCode.Location = New System.Drawing.Point(467, 11)
        Me.lblDCode.Name = "lblDCode"
        Me.lblDCode.Size = New System.Drawing.Size(95, 15)
        Me.lblDCode.TabIndex = 18
        Me.lblDCode.Text = "L02201300001"
        Me.lblDCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDCode.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(367, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "DELIVERY CODE :"
        Me.Label10.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(8, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Delivery"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.BackColor = System.Drawing.Color.OrangeRed
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(727, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(-3, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DELIVERY LOCATION"
        '
        'cmbDCLocation
        '
        Me.cmbDCLocation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbDCLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDCLocation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDCLocation.FormattingEnabled = True
        Me.cmbDCLocation.Location = New System.Drawing.Point(-1, 57)
        Me.cmbDCLocation.Name = "cmbDCLocation"
        Me.cmbDCLocation.Size = New System.Drawing.Size(284, 23)
        Me.cmbDCLocation.TabIndex = 4
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(301, 56)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "SEND"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(-3, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "PLUCODE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(109, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "PRODUCT DESCRIPTION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(392, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "QUANTITY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(-4, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Destination Info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(-4, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Product Info"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(0, 182)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(106, 23)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "1"
        '
        'txtProduct
        '
        Me.txtProduct.BackColor = System.Drawing.SystemColors.Window
        Me.txtProduct.Location = New System.Drawing.Point(112, 182)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.ReadOnly = True
        Me.txtProduct.Size = New System.Drawing.Size(239, 23)
        Me.txtProduct.TabIndex = 1
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(357, 182)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(100, 23)
        Me.txtQty.TabIndex = 2
        Me.txtQty.Tag = "1"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(473, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "STOCK"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStock
        '
        Me.lblStock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.ForeColor = System.Drawing.Color.Navy
        Me.lblStock.Location = New System.Drawing.Point(475, 185)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(92, 15)
        Me.lblStock.TabIndex = 13
        Me.lblStock.Text = "0"
        Me.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(298, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "OPTIONS"
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.TG.BackgroundColor = System.Drawing.Color.White
        Me.TG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.TG.ColumnHeadersHeight = 30
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TG.DefaultCellStyle = DataGridViewCellStyle8
        Me.TG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.Location = New System.Drawing.Point(13, 219)
        Me.TG.Name = "TG"
        Me.TG.ReadOnly = True
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TG.RowHeadersVisible = False
        Me.TG.RowTemplate.Height = 30
        Me.TG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TG.Size = New System.Drawing.Size(789, 301)
        Me.TG.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "PLUID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "CODE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "PRODUCT DESCRIPTION"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 350
        '
        'Column4
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column4.HeaderText = "QUANTITY"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column5
        '
        Me.Column5.HeaderText = "COSTPRICE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "RETAILPRICE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TG, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 36)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(805, 523)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkAutoEntry)
        Me.Panel2.Controls.Add(Me.txtRemarks)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.lblRAmt)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.LBLCAmt)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Controls.Add(Me.lblTQty)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.cmbDCLocation)
        Me.Panel2.Controls.Add(Me.lblStock)
        Me.Panel2.Controls.Add(Me.btnSend)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtQty)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtProduct)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtCode)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(13, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(789, 210)
        Me.Panel2.TabIndex = 0
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(-1, 103)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(458, 23)
        Me.txtRemarks.TabIndex = 3
        Me.txtRemarks.Tag = "1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(-2, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 15)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "REMARKS"
        '
        'lblRAmt
        '
        Me.lblRAmt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRAmt.ForeColor = System.Drawing.Color.Red
        Me.lblRAmt.Location = New System.Drawing.Point(581, 185)
        Me.lblRAmt.Name = "lblRAmt"
        Me.lblRAmt.Size = New System.Drawing.Size(100, 15)
        Me.lblRAmt.TabIndex = 22
        Me.lblRAmt.Text = "0.00"
        Me.lblRAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblRAmt.Visible = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(581, 164)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 15)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "TOTAL AMOUNT"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label15.Visible = False
        '
        'LBLCAmt
        '
        Me.LBLCAmt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCAmt.ForeColor = System.Drawing.Color.Red
        Me.LBLCAmt.Location = New System.Drawing.Point(470, 108)
        Me.LBLCAmt.Name = "LBLCAmt"
        Me.LBLCAmt.Size = New System.Drawing.Size(97, 18)
        Me.LBLCAmt.TabIndex = 20
        Me.LBLCAmt.Text = "0.00"
        Me.LBLCAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(470, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 15)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "TOTAL AMOUNT"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.OrangeRed
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(382, 56)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblTQty
        '
        Me.lblTQty.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTQty.ForeColor = System.Drawing.Color.Red
        Me.lblTQty.Location = New System.Drawing.Point(473, 60)
        Me.lblTQty.Name = "lblTQty"
        Me.lblTQty.Size = New System.Drawing.Size(94, 19)
        Me.lblTQty.TabIndex = 17
        Me.lblTQty.Text = "0"
        Me.lblTQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(467, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 15)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "TOTAL ITEMS"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(471, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 21)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Summary"
        '
        'TTip
        '
        Me.TTip.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        Me.TTip.ToolTipTitle = "Error..!"
        '
        'pnlImport
        '
        Me.pnlImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.pnlImport.Controls.Add(Me.btnHide)
        Me.pnlImport.Controls.Add(Me.Label21)
        Me.pnlImport.Controls.Add(Me.Panel4)
        Me.pnlImport.Location = New System.Drawing.Point(146, 250)
        Me.pnlImport.Name = "pnlImport"
        Me.pnlImport.Size = New System.Drawing.Size(617, 206)
        Me.pnlImport.TabIndex = 4
        Me.pnlImport.Visible = False
        '
        'btnHide
        '
        Me.btnHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHide.BackColor = System.Drawing.Color.Transparent
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(576, 7)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(32, 26)
        Me.btnHide.TabIndex = 4
        Me.btnHide.Text = "r"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 11)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(143, 42)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "IMPORT PRODUCT"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.btnGetColumn)
        Me.Panel4.Controls.Add(Me.btnSendToDelivery)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.cmbQty)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.cmbName)
        Me.Panel4.Controls.Add(Me.cmbSheet)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.btnPick)
        Me.Panel4.Controls.Add(Me.txtSelect)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Location = New System.Drawing.Point(10, 53)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(597, 142)
        Me.Panel4.TabIndex = 2
        '
        'btnGetColumn
        '
        Me.btnGetColumn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnGetColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetColumn.ForeColor = System.Drawing.Color.Gray
        Me.btnGetColumn.Location = New System.Drawing.Point(144, 101)
        Me.btnGetColumn.Name = "btnGetColumn"
        Me.btnGetColumn.Size = New System.Drawing.Size(32, 22)
        Me.btnGetColumn.TabIndex = 27
        Me.btnGetColumn.Text = "..."
        Me.btnGetColumn.UseVisualStyleBackColor = True
        '
        'btnSendToDelivery
        '
        Me.btnSendToDelivery.Enabled = False
        Me.btnSendToDelivery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnSendToDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendToDelivery.ForeColor = System.Drawing.Color.Gray
        Me.btnSendToDelivery.Location = New System.Drawing.Point(430, 100)
        Me.btnSendToDelivery.Name = "btnSendToDelivery"
        Me.btnSendToDelivery.Size = New System.Drawing.Size(143, 23)
        Me.btnSendToDelivery.TabIndex = 6
        Me.btnSendToDelivery.Text = "SEND TO DELIVERY"
        Me.btnSendToDelivery.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(311, 85)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 15)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Quantity"
        '
        'cmbQty
        '
        Me.cmbQty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQty.FormattingEnabled = True
        Me.cmbQty.Location = New System.Drawing.Point(314, 101)
        Me.cmbQty.Name = "cmbQty"
        Me.cmbQty.Size = New System.Drawing.Size(110, 23)
        Me.cmbQty.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(195, 85)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 15)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Name"
        '
        'cmbName
        '
        Me.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(198, 101)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(110, 23)
        Me.cmbName.TabIndex = 4
        '
        'cmbSheet
        '
        Me.cmbSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSheet.FormattingEnabled = True
        Me.cmbSheet.Location = New System.Drawing.Point(17, 101)
        Me.cmbSheet.Name = "cmbSheet"
        Me.cmbSheet.Size = New System.Drawing.Size(121, 23)
        Me.cmbSheet.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 85)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 15)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Sheet"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(14, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "IMPORT"
        '
        'btnPick
        '
        Me.btnPick.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPick.ForeColor = System.Drawing.Color.Gray
        Me.btnPick.Location = New System.Drawing.Point(430, 53)
        Me.btnPick.Name = "btnPick"
        Me.btnPick.Size = New System.Drawing.Size(143, 23)
        Me.btnPick.TabIndex = 1
        Me.btnPick.Text = "BROWSE FILE"
        Me.btnPick.UseVisualStyleBackColor = True
        '
        'txtSelect
        '
        Me.txtSelect.Location = New System.Drawing.Point(17, 54)
        Me.txtSelect.Name = "txtSelect"
        Me.txtSelect.Size = New System.Drawing.Size(407, 23)
        Me.txtSelect.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(14, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 15)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Select Excel File"
        '
        'OFD
        '
        Me.OFD.Filter = "Excel Files|*.xlsx;*.xls"
        Me.OFD.Title = "Select Excel File"
        '
        'chkAutoEntry
        '
        Me.chkAutoEntry.AutoSize = True
        Me.chkAutoEntry.Checked = True
        Me.chkAutoEntry.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoEntry.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoEntry.Location = New System.Drawing.Point(360, 137)
        Me.chkAutoEntry.Name = "chkAutoEntry"
        Me.chkAutoEntry.Size = New System.Drawing.Size(95, 17)
        Me.chkAutoEntry.TabIndex = 24
        Me.chkAutoEntry.Text = "AUTO ENTRY"
        Me.chkAutoEntry.UseVisualStyleBackColor = True
        '
        'ProductDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(805, 559)
        Me.Controls.Add(Me.pnlImport)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ProductDelivery"
        Me.Text = "ProductDelivery"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlImport.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbDCLocation As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTQty As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblDCode As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblRAmt As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LBLCAmt As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents pnlImport As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSendToDelivery As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbQty As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSheet As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnPick As System.Windows.Forms.Button
    Friend WithEvents txtSelect As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnGetColumn As System.Windows.Forms.Button
    Friend WithEvents chkAutoEntry As System.Windows.Forms.CheckBox
End Class
