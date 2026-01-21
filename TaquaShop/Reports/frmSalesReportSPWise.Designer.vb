<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesReportSPWise
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
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkCommission = New System.Windows.Forms.CheckBox()
        Me.btnCommission = New System.Windows.Forms.Button()
        Me.LblUnknown = New System.Windows.Forms.Label()
        Me.CmbUnknown = New System.Windows.Forms.ComboBox()
        Me.LblAmt = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblQty = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbRptStyle = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mebTo = New System.Windows.Forms.DateTimePicker()
        Me.mebFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlCommission = New System.Windows.Forms.Panel()
        Me.dgvCommission = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCommissionClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCommissionPerc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtToAmount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFromAmount = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlCommission.SuspendLayout()
        CType(Me.dgvCommission, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TG, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1002, 473)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.TG.BackgroundColor = System.Drawing.Color.White
        Me.TG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.TG.ColumnHeadersHeight = 30
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TableLayoutPanel1.SetColumnSpan(Me.TG, 2)
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TG.DefaultCellStyle = DataGridViewCellStyle24
        Me.TG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.Location = New System.Drawing.Point(8, 155)
        Me.TG.Name = "TG"
        Me.TG.ReadOnly = True
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TG.RowHeadersVisible = False
        Me.TG.RowTemplate.Height = 30
        Me.TG.Size = New System.Drawing.Size(991, 315)
        Me.TG.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Report - SP Wise"
        '
        'Panel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.chkCommission)
        Me.Panel1.Controls.Add(Me.btnCommission)
        Me.Panel1.Controls.Add(Me.LblUnknown)
        Me.Panel1.Controls.Add(Me.CmbUnknown)
        Me.Panel1.Controls.Add(Me.LblAmt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.LblQty)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CmbRptStyle)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnDisplay)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.mebTo)
        Me.Panel1.Controls.Add(Me.mebFrom)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(991, 114)
        Me.Panel1.TabIndex = 1
        '
        'chkCommission
        '
        Me.chkCommission.AutoSize = True
        Me.chkCommission.Location = New System.Drawing.Point(356, 31)
        Me.chkCommission.Name = "chkCommission"
        Me.chkCommission.Size = New System.Drawing.Size(135, 19)
        Me.chkCommission.TabIndex = 25
        Me.chkCommission.Text = "LOAD COMMISSION"
        Me.chkCommission.UseVisualStyleBackColor = True
        '
        'btnCommission
        '
        Me.btnCommission.BackColor = System.Drawing.Color.ForestGreen
        Me.btnCommission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommission.ForeColor = System.Drawing.Color.White
        Me.btnCommission.Location = New System.Drawing.Point(522, 20)
        Me.btnCommission.Name = "btnCommission"
        Me.btnCommission.Size = New System.Drawing.Size(158, 29)
        Me.btnCommission.TabIndex = 24
        Me.btnCommission.Text = "COMMISSION"
        Me.btnCommission.UseVisualStyleBackColor = False
        '
        'LblUnknown
        '
        Me.LblUnknown.AutoSize = True
        Me.LblUnknown.Enabled = False
        Me.LblUnknown.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUnknown.ForeColor = System.Drawing.Color.Black
        Me.LblUnknown.Location = New System.Drawing.Point(353, 53)
        Me.LblUnknown.Name = "LblUnknown"
        Me.LblUnknown.Size = New System.Drawing.Size(71, 15)
        Me.LblUnknown.TabIndex = 23
        Me.LblUnknown.Text = "Combo Box"
        '
        'CmbUnknown
        '
        Me.CmbUnknown.Enabled = False
        Me.CmbUnknown.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUnknown.FormattingEnabled = True
        Me.CmbUnknown.Items.AddRange(New Object() {"Summary", "Details"})
        Me.CmbUnknown.Location = New System.Drawing.Point(356, 69)
        Me.CmbUnknown.Name = "CmbUnknown"
        Me.CmbUnknown.Size = New System.Drawing.Size(150, 23)
        Me.CmbUnknown.TabIndex = 3
        '
        'LblAmt
        '
        Me.LblAmt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmt.ForeColor = System.Drawing.Color.Green
        Me.LblAmt.Location = New System.Drawing.Point(836, 63)
        Me.LblAmt.Name = "LblAmt"
        Me.LblAmt.Size = New System.Drawing.Size(109, 30)
        Me.LblAmt.TabIndex = 21
        Me.LblAmt.Text = "0.00"
        Me.LblAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(837, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "TOTAL AMOUNT"
        '
        'LblQty
        '
        Me.LblQty.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQty.ForeColor = System.Drawing.Color.Navy
        Me.LblQty.Location = New System.Drawing.Point(698, 63)
        Me.LblQty.Name = "LblQty"
        Me.LblQty.Size = New System.Drawing.Size(109, 30)
        Me.LblQty.TabIndex = 19
        Me.LblQty.Text = "0"
        Me.LblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(700, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "TOTAL QUANTITY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(226, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Report Style"
        '
        'CmbRptStyle
        '
        Me.CmbRptStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbRptStyle.FormattingEnabled = True
        Me.CmbRptStyle.Items.AddRange(New Object() {"Summary", "Details", "Floor", "Sales Person"})
        Me.CmbRptStyle.Location = New System.Drawing.Point(229, 69)
        Me.CmbRptStyle.Name = "CmbRptStyle"
        Me.CmbRptStyle.Size = New System.Drawing.Size(121, 23)
        Me.CmbRptStyle.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(441, -491)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 30)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "DISPLAY"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(342, -166)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 30)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "DISPLAY"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Navy
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(604, 64)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 30)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnDisplay.FlatAppearance.BorderSize = 0
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplay.ForeColor = System.Drawing.Color.White
        Me.btnDisplay.Location = New System.Drawing.Point(522, 64)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(76, 30)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "DISPLAY"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(226, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 15)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "OPTIONS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(9, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "DURATION FILTER"
        '
        'mebTo
        '
        Me.mebTo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mebTo.Location = New System.Drawing.Point(120, 69)
        Me.mebTo.Name = "mebTo"
        Me.mebTo.Size = New System.Drawing.Size(103, 23)
        Me.mebTo.TabIndex = 1
        '
        'mebFrom
        '
        Me.mebFrom.Checked = False
        Me.mebFrom.CustomFormat = ""
        Me.mebFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mebFrom.Location = New System.Drawing.Point(11, 69)
        Me.mebFrom.Name = "mebFrom"
        Me.mebFrom.Size = New System.Drawing.Size(103, 23)
        Me.mebFrom.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(117, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "From"
        '
        'pnlCommission
        '
        Me.pnlCommission.BackColor = System.Drawing.Color.White
        Me.pnlCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCommission.Controls.Add(Me.dgvCommission)
        Me.pnlCommission.Controls.Add(Me.Panel2)
        Me.pnlCommission.Controls.Add(Me.btnClear)
        Me.pnlCommission.Controls.Add(Me.btnSave)
        Me.pnlCommission.Controls.Add(Me.Label9)
        Me.pnlCommission.Controls.Add(Me.txtCommissionPerc)
        Me.pnlCommission.Controls.Add(Me.Label8)
        Me.pnlCommission.Controls.Add(Me.txtToAmount)
        Me.pnlCommission.Controls.Add(Me.Label7)
        Me.pnlCommission.Controls.Add(Me.txtFromAmount)
        Me.pnlCommission.Location = New System.Drawing.Point(146, 89)
        Me.pnlCommission.Name = "pnlCommission"
        Me.pnlCommission.Size = New System.Drawing.Size(780, 372)
        Me.pnlCommission.TabIndex = 25
        '
        'dgvCommission
        '
        Me.dgvCommission.AllowUserToAddRows = False
        Me.dgvCommission.AllowUserToDeleteRows = False
        Me.dgvCommission.AllowUserToResizeColumns = False
        Me.dgvCommission.AllowUserToResizeRows = False
        Me.dgvCommission.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCommission.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.dgvCommission.ColumnHeadersHeight = 25
        Me.dgvCommission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCommission.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column6, Me.Column8, Me.Column2, Me.Column3, Me.Column4, Me.Column1, Me.Column5})
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCommission.DefaultCellStyle = DataGridViewCellStyle28
        Me.dgvCommission.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvCommission.EnableHeadersVisualStyles = False
        Me.dgvCommission.Location = New System.Drawing.Point(0, 95)
        Me.dgvCommission.Name = "dgvCommission"
        Me.dgvCommission.ReadOnly = True
        Me.dgvCommission.RowHeadersVisible = False
        Me.dgvCommission.Size = New System.Drawing.Size(778, 275)
        Me.dgvCommission.TabIndex = 12
        '
        'Column7
        '
        Me.Column7.HeaderText = "ID"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "SNO"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "CREATED DATE"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "FROM AMOUNT"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 130
        '
        'Column3
        '
        Me.Column3.HeaderText = "TO AMOUNT"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 115
        '
        'Column4
        '
        Me.Column4.HeaderText = "COMMISSION %"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 130
        '
        'Column1
        '
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle26
        Me.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column1.HeaderText = "EDIT"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Text = "EDIT"
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'Column5
        '
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle27
        Me.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column5.HeaderText = "DELETE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Text = "DELETE"
        Me.Column5.UseColumnTextForButtonValue = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.btnCommissionClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(778, 31)
        Me.Panel2.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(332, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 21)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "COMMISSION"
        '
        'btnCommissionClose
        '
        Me.btnCommissionClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCommissionClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnCommissionClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCommissionClose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommissionClose.ForeColor = System.Drawing.Color.White
        Me.btnCommissionClose.Location = New System.Drawing.Point(703, 0)
        Me.btnCommissionClose.Name = "btnCommissionClose"
        Me.btnCommissionClose.Size = New System.Drawing.Size(75, 31)
        Me.btnCommissionClose.TabIndex = 9
        Me.btnCommissionClose.Text = "CLOSE"
        Me.btnCommissionClose.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(462, 59)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(381, 59)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(253, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "COMMISSION %"
        '
        'txtCommissionPerc
        '
        Me.txtCommissionPerc.Location = New System.Drawing.Point(256, 66)
        Me.txtCommissionPerc.Name = "txtCommissionPerc"
        Me.txtCommissionPerc.Size = New System.Drawing.Size(116, 23)
        Me.txtCommissionPerc.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(131, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "TO AMOUNT"
        '
        'txtToAmount
        '
        Me.txtToAmount.Location = New System.Drawing.Point(134, 66)
        Me.txtToAmount.Name = "txtToAmount"
        Me.txtToAmount.Size = New System.Drawing.Size(116, 23)
        Me.txtToAmount.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FROM AMOUNT"
        '
        'txtFromAmount
        '
        Me.txtFromAmount.Location = New System.Drawing.Point(12, 66)
        Me.txtFromAmount.Name = "txtFromAmount"
        Me.txtFromAmount.Size = New System.Drawing.Size(116, 23)
        Me.txtFromAmount.TabIndex = 1
        '
        'frmSalesReportSPWise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1002, 473)
        Me.Controls.Add(Me.pnlCommission)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSalesReportSPWise"
        Me.Text = "Sales Report SP Wise"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlCommission.ResumeLayout(False)
        Me.pnlCommission.PerformLayout()
        CType(Me.dgvCommission, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents mebTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents mebFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbRptStyle As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LblAmt As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblQty As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblUnknown As Label
    Friend WithEvents CmbUnknown As ComboBox
    Friend WithEvents btnCommission As Button
    Friend WithEvents pnlCommission As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFromAmount As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnCommissionClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCommissionPerc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtToAmount As TextBox
    Friend WithEvents chkCommission As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvCommission As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
End Class
