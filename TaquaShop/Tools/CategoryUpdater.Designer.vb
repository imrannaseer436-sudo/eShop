<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryUpdater
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnImport = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDeselect = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSelectAll = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.txtSCat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.cmbDCode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.pnlCat = New System.Windows.Forms.Panel()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tvCat = New System.Windows.Forms.TreeView()
        Me.TTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlImport = New System.Windows.Forms.Panel()
        Me.btniHide = New System.Windows.Forms.Button()
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
        Me.Panel1.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCat.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlImport.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnImport)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtCode)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnDeselect)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnSelectAll)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnSelect)
        Me.Panel1.Controls.Add(Me.txtSCat)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.TG)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnDisplay)
        Me.Panel1.Controls.Add(Me.cmbDCode)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(4, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(730, 488)
        Me.Panel1.TabIndex = 0
        '
        'btnImport
        '
        Me.btnImport.AutoSize = True
        Me.btnImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImport.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.ForeColor = System.Drawing.Color.Black
        Me.btnImport.Location = New System.Drawing.Point(678, 130)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(42, 13)
        Me.btnImport.TabIndex = 36
        Me.btnImport.Text = "Import"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(661, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "|"
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(596, 130)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(59, 13)
        Me.btnClear.TabIndex = 33
        Me.btnClear.Text = "&Clear Row"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(579, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "|"
        '
        'txtCode
        '
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Location = New System.Drawing.Point(11, 127)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(305, 22)
        Me.txtCode.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(8, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Code"
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoSize = True
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(530, 130)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(45, 13)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "&Update"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(515, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "|"
        '
        'btnDeselect
        '
        Me.btnDeselect.AutoSize = True
        Me.btnDeselect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeselect.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeselect.ForeColor = System.Drawing.Color.Black
        Me.btnDeselect.Location = New System.Drawing.Point(445, 130)
        Me.btnDeselect.Name = "btnDeselect"
        Me.btnDeselect.Size = New System.Drawing.Size(67, 13)
        Me.btnDeselect.TabIndex = 26
        Me.btnDeselect.Text = "Deselect All"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(428, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "|"
        '
        'btnSelectAll
        '
        Me.btnSelectAll.AutoSize = True
        Me.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectAll.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll.ForeColor = System.Drawing.Color.Black
        Me.btnSelectAll.Location = New System.Drawing.Point(368, 130)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(54, 13)
        Me.btnSelectAll.TabIndex = 25
        Me.btnSelectAll.Text = "Select All"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(334, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Selected Category"
        '
        'btnSelect
        '
        Me.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.ForeColor = System.Drawing.Color.Gray
        Me.btnSelect.Location = New System.Drawing.Point(645, 52)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 23
        Me.btnSelect.Text = "SELECT"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'txtSCat
        '
        Me.txtSCat.Location = New System.Drawing.Point(337, 54)
        Me.txtSCat.Name = "txtSCat"
        Me.txtSCat.Size = New System.Drawing.Size(302, 22)
        Me.txtSCat.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(334, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "SELECT CATEGORY"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "LIST OF PRODUCTS"
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        Me.TG.BackgroundColor = System.Drawing.Color.White
        Me.TG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TG.ColumnHeadersHeight = 25
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column7, Me.Column1, Me.Column8, Me.Column2, Me.Column9, Me.Column3, Me.Column10, Me.Column4, Me.Column11, Me.Column13, Me.Column12, Me.Column14, Me.Column15, Me.Column5})
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.GridColor = System.Drawing.Color.WhiteSmoke
        Me.TG.Location = New System.Drawing.Point(11, 164)
        Me.TG.Name = "TG"
        Me.TG.RowHeadersVisible = False
        Me.TG.RowTemplate.Height = 25
        Me.TG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TG.Size = New System.Drawing.Size(709, 317)
        Me.TG.TabIndex = 19
        '
        'Column6
        '
        Me.Column6.FalseValue = "0"
        Me.Column6.HeaderText = "TICK"
        Me.Column6.Name = "Column6"
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column6.TrueValue = "1"
        Me.Column6.Width = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "PLUID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "CODE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "PRODUCT DESCRIPTION"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "CATID"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "CATEGORY"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "SCID1"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "SUBCATEGORY - 1"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 110
        '
        'Column9
        '
        Me.Column9.HeaderText = "SCID2"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "SUBCATEGORY - 2"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 110
        '
        'Column10
        '
        Me.Column10.HeaderText = "SCID3"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'Column4
        '
        Me.Column4.HeaderText = "SUBCATEGORY - 3"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 110
        '
        'Column11
        '
        Me.Column11.HeaderText = "SCID4"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        '
        'Column13
        '
        Me.Column13.HeaderText = "SUBCATEGORY - 4"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Visible = False
        '
        'Column12
        '
        Me.Column12.HeaderText = "SCID5"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Visible = False
        '
        'Column14
        '
        Me.Column14.HeaderText = "SUBCATEGORY - 5"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Visible = False
        '
        'Column15
        '
        Me.Column15.HeaderText = "CATLINK"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Visible = False
        '
        'Column5
        '
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "RECEIVED FILTER"
        '
        'btnDisplay
        '
        Me.btnDisplay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplay.ForeColor = System.Drawing.Color.Gray
        Me.btnDisplay.Location = New System.Drawing.Point(241, 52)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 17
        Me.btnDisplay.Text = "DISPLAY"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'cmbDCode
        '
        Me.cmbDCode.FormattingEnabled = True
        Me.cmbDCode.Location = New System.Drawing.Point(11, 54)
        Me.cmbDCode.Name = "cmbDCode"
        Me.cmbDCode.Size = New System.Drawing.Size(224, 21)
        Me.cmbDCode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(8, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Delivery Code"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CATEGORY UPDATER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(702, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 26)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "r"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMin
        '
        Me.btnMin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnMin.ForeColor = System.Drawing.Color.White
        Me.btnMin.Location = New System.Drawing.Point(664, 12)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(32, 26)
        Me.btnMin.TabIndex = 3
        Me.btnMin.Text = "0"
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'pnlCat
        '
        Me.pnlCat.Controls.Add(Me.btnHide)
        Me.pnlCat.Controls.Add(Me.Label6)
        Me.pnlCat.Controls.Add(Me.Panel3)
        Me.pnlCat.Location = New System.Drawing.Point(175, 52)
        Me.pnlCat.Name = "pnlCat"
        Me.pnlCat.Size = New System.Drawing.Size(388, 451)
        Me.pnlCat.TabIndex = 4
        Me.pnlCat.Visible = False
        '
        'btnHide
        '
        Me.btnHide.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnHide.BackColor = System.Drawing.Color.Transparent
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHide.Location = New System.Drawing.Point(352, 8)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(32, 26)
        Me.btnHide.TabIndex = 3
        Me.btnHide.Text = "r"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(4, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 38)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "PICK CATEGORY"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.tvCat)
        Me.Panel3.Location = New System.Drawing.Point(4, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(380, 407)
        Me.Panel3.TabIndex = 0
        '
        'tvCat
        '
        Me.tvCat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvCat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvCat.Location = New System.Drawing.Point(0, 0)
        Me.tvCat.Name = "tvCat"
        Me.tvCat.PathSeparator = "->"
        Me.tvCat.Size = New System.Drawing.Size(380, 407)
        Me.tvCat.TabIndex = 1
        '
        'TTip
        '
        Me.TTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TTip.ToolTipTitle = "Category Updater"
        '
        'pnlImport
        '
        Me.pnlImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.pnlImport.Controls.Add(Me.btniHide)
        Me.pnlImport.Controls.Add(Me.Label21)
        Me.pnlImport.Controls.Add(Me.Panel4)
        Me.pnlImport.Location = New System.Drawing.Point(61, 167)
        Me.pnlImport.Name = "pnlImport"
        Me.pnlImport.Size = New System.Drawing.Size(617, 206)
        Me.pnlImport.TabIndex = 5
        Me.pnlImport.Visible = False
        '
        'btniHide
        '
        Me.btniHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btniHide.BackColor = System.Drawing.Color.Transparent
        Me.btniHide.FlatAppearance.BorderSize = 0
        Me.btniHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btniHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btniHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btniHide.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btniHide.ForeColor = System.Drawing.Color.White
        Me.btniHide.Location = New System.Drawing.Point(576, 7)
        Me.btniHide.Name = "btniHide"
        Me.btniHide.Size = New System.Drawing.Size(32, 26)
        Me.btniHide.TabIndex = 4
        Me.btniHide.Text = "r"
        Me.btniHide.UseVisualStyleBackColor = False
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
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Quantity"
        '
        'cmbQty
        '
        Me.cmbQty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQty.FormattingEnabled = True
        Me.cmbQty.Location = New System.Drawing.Point(314, 101)
        Me.cmbQty.Name = "cmbQty"
        Me.cmbQty.Size = New System.Drawing.Size(110, 21)
        Me.cmbQty.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(195, 85)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Name"
        '
        'cmbName
        '
        Me.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(198, 101)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(110, 21)
        Me.cmbName.TabIndex = 4
        '
        'cmbSheet
        '
        Me.cmbSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSheet.FormattingEnabled = True
        Me.cmbSheet.Location = New System.Drawing.Point(17, 101)
        Me.cmbSheet.Name = "cmbSheet"
        Me.cmbSheet.Size = New System.Drawing.Size(121, 21)
        Me.cmbSheet.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 85)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 13)
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
        Me.txtSelect.Size = New System.Drawing.Size(407, 22)
        Me.txtSelect.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(14, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Select Excel File"
        '
        'OFD
        '
        Me.OFD.Filter = "Excel Files|*.xlsx;*.xls"
        Me.OFD.Title = "Select Excel File"
        '
        'CategoryUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(738, 540)
        Me.Controls.Add(Me.pnlImport)
        Me.Controls.Add(Me.pnlCat)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CategoryUpdater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category Updater"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCat.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.pnlImport.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMin As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbDCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents txtSCat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDeselect As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSelectAll As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pnlCat As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tvCat As System.Windows.Forms.TreeView
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnClear As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnImport As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents pnlImport As System.Windows.Forms.Panel
    Friend WithEvents btniHide As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnGetColumn As System.Windows.Forms.Button
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
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
