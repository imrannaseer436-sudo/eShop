<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditBill
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAlter = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.mebBillDt = New System.Windows.Forms.MaskedTextBox()
        Me.mebRefDt = New System.Windows.Forms.MaskedTextBox()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbCust = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPlucode = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDis = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbDType = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAmt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtPaid = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblAC = New System.Windows.Forms.Label()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblBillAmt = New System.Windows.Forms.Label()
        Me.lblPaidAmt = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbRate = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnAlter)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.SimpleLine1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 47)
        Me.Panel1.TabIndex = 30
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnClose.Location = New System.Drawing.Point(713, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 26)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close (Esc)"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnReset.Location = New System.Drawing.Point(618, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(90, 26)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset (F5)"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAlter
        '
        Me.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlter.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlter.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnAlter.Location = New System.Drawing.Point(522, 12)
        Me.btnAlter.Name = "btnAlter"
        Me.btnAlter.Size = New System.Drawing.Size(90, 26)
        Me.btnAlter.TabIndex = 1
        Me.btnAlter.Text = "&Alter (F3)"
        Me.btnAlter.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnSave.Location = New System.Drawing.Point(426, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 26)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save Bill (F2)"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleLine1.Enabled = False
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.Gainsboro
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(0, 46)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(816, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 1
        Me.SimpleLine1.UseGradient = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Credit Bill"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(13, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BILL INFO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bill No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Bill Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(167, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Ref No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(244, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 14)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Ref Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(334, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 14)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Customer Name"
        '
        'txtBillNo
        '
        Me.txtBillNo.BackColor = System.Drawing.Color.White
        Me.txtBillNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNo.Location = New System.Drawing.Point(16, 116)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.ReadOnly = True
        Me.txtBillNo.Size = New System.Drawing.Size(71, 20)
        Me.txtBillNo.TabIndex = 0
        '
        'mebBillDt
        '
        Me.mebBillDt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebBillDt.Location = New System.Drawing.Point(93, 116)
        Me.mebBillDt.Mask = "00/00/0000"
        Me.mebBillDt.Name = "mebBillDt"
        Me.mebBillDt.Size = New System.Drawing.Size(71, 20)
        Me.mebBillDt.TabIndex = 1
        Me.mebBillDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mebBillDt.ValidatingType = GetType(Date)
        '
        'mebRefDt
        '
        Me.mebRefDt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mebRefDt.Location = New System.Drawing.Point(247, 116)
        Me.mebRefDt.Mask = "00/00/0000"
        Me.mebRefDt.Name = "mebRefDt"
        Me.mebRefDt.Size = New System.Drawing.Size(71, 20)
        Me.mebRefDt.TabIndex = 3
        Me.mebRefDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mebRefDt.ValidatingType = GetType(Date)
        '
        'txtRefNo
        '
        Me.txtRefNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.Location = New System.Drawing.Point(170, 116)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(71, 20)
        Me.txtRefNo.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(334, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "CUSTOMER INFO"
        '
        'cmbCust
        '
        Me.cmbCust.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCust.FormattingEnabled = True
        Me.cmbCust.Location = New System.Drawing.Point(337, 114)
        Me.cmbCust.Name = "cmbCust"
        Me.cmbCust.Size = New System.Drawing.Size(293, 22)
        Me.cmbCust.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(13, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 14)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "PRODUCT DETAILS"
        '
        'txtPlucode
        '
        Me.txtPlucode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlucode.Location = New System.Drawing.Point(16, 200)
        Me.txtPlucode.Name = "txtPlucode"
        Me.txtPlucode.Size = New System.Drawing.Size(102, 20)
        Me.txtPlucode.TabIndex = 5
        Me.txtPlucode.Tag = "1"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(291, 200)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(71, 20)
        Me.txtQty.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 14)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Plucode"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(288, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 14)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Quantity"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(365, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 14)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Rate"
        '
        'txtDis
        '
        Me.txtDis.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDis.Location = New System.Drawing.Point(505, 200)
        Me.txtDis.Name = "txtDis"
        Me.txtDis.Size = New System.Drawing.Size(48, 20)
        Me.txtDis.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(502, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 14)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Dis %"
        '
        'cmbDType
        '
        Me.cmbDType.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDType.FormattingEnabled = True
        Me.cmbDType.Location = New System.Drawing.Point(445, 198)
        Me.cmbDType.Name = "cmbDType"
        Me.cmbDType.Size = New System.Drawing.Size(54, 22)
        Me.cmbDType.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(442, 181)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 14)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Dis Type"
        '
        'txtAmt
        '
        Me.txtAmt.BackColor = System.Drawing.Color.White
        Me.txtAmt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmt.Location = New System.Drawing.Point(559, 200)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.ReadOnly = True
        Me.txtAmt.Size = New System.Drawing.Size(71, 20)
        Me.txtAmt.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(556, 181)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 14)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Amount"
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.White
        Me.txtDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(124, 200)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.Size = New System.Drawing.Size(161, 20)
        Me.txtDesc.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(121, 181)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 14)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Description"
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        Me.TG.BackgroundColor = System.Drawing.Color.White
        Me.TG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TG.DefaultCellStyle = DataGridViewCellStyle2
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.GridColor = System.Drawing.Color.LightGray
        Me.TG.Location = New System.Drawing.Point(16, 231)
        Me.TG.Name = "TG"
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.TG.RowHeadersVisible = False
        Me.TG.Size = New System.Drawing.Size(787, 259)
        Me.TG.TabIndex = 14
        '
        'Column1
        '
        Me.Column1.HeaderText = "Plucode"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 105
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 165
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "Rate"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "D.Type"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 60
        '
        'Column6
        '
        Me.Column6.HeaderText = "Dis %"
        Me.Column6.Name = "Column6"
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column6.Width = 55
        '
        'Column7
        '
        Me.Column7.HeaderText = "Amount"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 75
        '
        'Column8
        '
        Me.Column8.HeaderText = "Paid"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 75
        '
        'Column9
        '
        Me.Column9.HeaderText = "Balance"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 75
        '
        'Column10
        '
        Me.Column10.HeaderText = ""
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 20
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnAdd.Location = New System.Drawing.Point(713, 197)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add Product"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtPaid
        '
        Me.txtPaid.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaid.Location = New System.Drawing.Point(636, 200)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(71, 20)
        Me.txtPaid.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(633, 181)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 14)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Paid"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(649, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 14)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "A/C Balance"
        '
        'lblAC
        '
        Me.lblAC.AutoSize = True
        Me.lblAC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAC.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAC.Location = New System.Drawing.Point(649, 115)
        Me.lblAC.Name = "lblAC"
        Me.lblAC.Size = New System.Drawing.Size(33, 16)
        Me.lblAC.TabIndex = 29
        Me.lblAC.Text = "0.00"
        '
        'SimpleLine2
        '
        Me.SimpleLine2.Enabled = False
        Me.SimpleLine2.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine2.FitToParent = False
        Me.SimpleLine2.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine2.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine2.LineColor = System.Drawing.Color.WhiteSmoke
        Me.SimpleLine2.LineWidth = 2
        Me.SimpleLine2.Location = New System.Drawing.Point(16, 496)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(787, 2)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 30
        Me.SimpleLine2.UseGradient = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(13, 518)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 16)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "BILL AMOUNT  :"
        '
        'lblBillAmt
        '
        Me.lblBillAmt.AutoSize = True
        Me.lblBillAmt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillAmt.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblBillAmt.Location = New System.Drawing.Point(128, 518)
        Me.lblBillAmt.Name = "lblBillAmt"
        Me.lblBillAmt.Size = New System.Drawing.Size(33, 16)
        Me.lblBillAmt.TabIndex = 32
        Me.lblBillAmt.Text = "0.00"
        '
        'lblPaidAmt
        '
        Me.lblPaidAmt.AutoSize = True
        Me.lblPaidAmt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaidAmt.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblPaidAmt.Location = New System.Drawing.Point(442, 518)
        Me.lblPaidAmt.Name = "lblPaidAmt"
        Me.lblPaidAmt.Size = New System.Drawing.Size(33, 16)
        Me.lblPaidAmt.TabIndex = 34
        Me.lblPaidAmt.Text = "0.00"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(334, 518)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(106, 16)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "PAID AMOUNT :"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblBalance.Location = New System.Drawing.Point(694, 518)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(33, 16)
        Me.lblBalance.TabIndex = 36
        Me.lblBalance.Text = "0.00"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(613, 518)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 16)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "BALANCE :"
        '
        'cmbRate
        '
        Me.cmbRate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRate.FormattingEnabled = True
        Me.cmbRate.Location = New System.Drawing.Point(368, 198)
        Me.cmbRate.Name = "cmbRate"
        Me.cmbRate.Size = New System.Drawing.Size(71, 22)
        Me.cmbRate.TabIndex = 8
        '
        'CreditBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(816, 558)
        Me.Controls.Add(Me.cmbRate)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lblPaidAmt)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lblBillAmt)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.SimpleLine2)
        Me.Controls.Add(Me.lblAC)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtPaid)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.TG)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtAmt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbDType)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDis)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtPlucode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbCust)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.mebRefDt)
        Me.Controls.Add(Me.txtRefNo)
        Me.Controls.Add(Me.mebBillDt)
        Me.Controls.Add(Me.txtBillNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "CreditBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credit Bill"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents mebBillDt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mebRefDt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCust As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPlucode As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDis As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbDType As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblAC As System.Windows.Forms.Label
    Friend WithEvents SimpleLine2 As simpleline.assemblies.simpleLine
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblBillAmt As System.Windows.Forms.Label
    Friend WithEvents lblPaidAmt As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnAlter As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cmbRate As System.Windows.Forms.ComboBox
End Class
