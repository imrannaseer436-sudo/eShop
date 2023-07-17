<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillUpdater
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblMin = New System.Windows.Forms.Label()
        Me.LblClose = New System.Windows.Forms.Label()
        Me.LblBillAmt = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnLoad2 = New System.Windows.Forms.Button()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpRef = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdate2 = New System.Windows.Forms.Button()
        Me.dgvPmt = New System.Windows.Forms.DataGridView()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPAmt = New System.Windows.Forms.TextBox()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.cmbPmtType = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPmt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.BtnClear)
        Me.Panel6.Controls.Add(Me.Panel1)
        Me.Panel6.Controls.Add(Me.LblBillAmt)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.btnLoad2)
        Me.Panel6.Controls.Add(Me.txtBillNo)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.dtpRef)
        Me.Panel6.Controls.Add(Me.btnUpdate2)
        Me.Panel6.Controls.Add(Me.dgvPmt)
        Me.Panel6.Controls.Add(Me.txtPAmt)
        Me.Panel6.Controls.Add(Me.txtRefNo)
        Me.Panel6.Controls.Add(Me.cmbPmtType)
        Me.Panel6.Controls.Add(Me.Label25)
        Me.Panel6.Controls.Add(Me.Label24)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(384, 334)
        Me.Panel6.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LblMin)
        Me.Panel1.Controls.Add(Me.LblClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 30)
        Me.Panel1.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 30)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Bill Updater"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblMin
        '
        Me.LblMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblMin.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMin.ForeColor = System.Drawing.Color.White
        Me.LblMin.Location = New System.Drawing.Point(302, 0)
        Me.LblMin.Name = "LblMin"
        Me.LblMin.Size = New System.Drawing.Size(40, 30)
        Me.LblMin.TabIndex = 13
        Me.LblMin.Text = "-"
        Me.LblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblClose
        '
        Me.LblClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClose.ForeColor = System.Drawing.Color.White
        Me.LblClose.Location = New System.Drawing.Point(342, 0)
        Me.LblClose.Name = "LblClose"
        Me.LblClose.Size = New System.Drawing.Size(40, 30)
        Me.LblClose.TabIndex = 12
        Me.LblClose.Text = "X"
        Me.LblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBillAmt
        '
        Me.LblBillAmt.AutoSize = True
        Me.LblBillAmt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBillAmt.Location = New System.Drawing.Point(82, 308)
        Me.LblBillAmt.Name = "LblBillAmt"
        Me.LblBillAmt.Size = New System.Drawing.Size(35, 14)
        Me.LblBillAmt.TabIndex = 11
        Me.LblBillAmt.Text = "0.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 308)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 14)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Amount :"
        '
        'btnLoad2
        '
        Me.btnLoad2.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnLoad2.FlatAppearance.BorderSize = 0
        Me.btnLoad2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad2.ForeColor = System.Drawing.Color.White
        Me.btnLoad2.Location = New System.Drawing.Point(199, 64)
        Me.btnLoad2.Name = "btnLoad2"
        Me.btnLoad2.Size = New System.Drawing.Size(76, 21)
        Me.btnLoad2.TabIndex = 1
        Me.btnLoad2.Text = "Load"
        Me.btnLoad2.UseVisualStyleBackColor = False
        '
        'txtBillNo
        '
        Me.txtBillNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNo.Location = New System.Drawing.Point(20, 64)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(173, 21)
        Me.txtBillNo.TabIndex = 0
        Me.txtBillNo.Tag = "1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 14)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Bill No."
        '
        'dtpRef
        '
        Me.dtpRef.Checked = False
        Me.dtpRef.CustomFormat = "MMM-yyy"
        Me.dtpRef.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRef.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRef.Location = New System.Drawing.Point(199, 114)
        Me.dtpRef.Name = "dtpRef"
        Me.dtpRef.Size = New System.Drawing.Size(76, 21)
        Me.dtpRef.TabIndex = 4
        '
        'btnUpdate2
        '
        Me.btnUpdate2.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnUpdate2.FlatAppearance.BorderSize = 0
        Me.btnUpdate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate2.ForeColor = System.Drawing.Color.White
        Me.btnUpdate2.Location = New System.Drawing.Point(296, 293)
        Me.btnUpdate2.Name = "btnUpdate2"
        Me.btnUpdate2.Size = New System.Drawing.Size(71, 29)
        Me.btnUpdate2.TabIndex = 7
        Me.btnUpdate2.Text = "Update"
        Me.btnUpdate2.UseVisualStyleBackColor = False
        '
        'dgvPmt
        '
        Me.dgvPmt.AllowUserToAddRows = False
        Me.dgvPmt.AllowUserToResizeColumns = False
        Me.dgvPmt.AllowUserToResizeRows = False
        Me.dgvPmt.BackgroundColor = System.Drawing.Color.White
        Me.dgvPmt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPmt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPmt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPmt.ColumnHeadersHeight = 25
        Me.dgvPmt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPmt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column21, Me.Column13})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPmt.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPmt.EnableHeadersVisualStyles = False
        Me.dgvPmt.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgvPmt.Location = New System.Drawing.Point(20, 144)
        Me.dgvPmt.Name = "dgvPmt"
        Me.dgvPmt.ReadOnly = True
        Me.dgvPmt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPmt.RowHeadersVisible = False
        Me.dgvPmt.RowTemplate.Height = 25
        Me.dgvPmt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPmt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPmt.Size = New System.Drawing.Size(347, 143)
        Me.dgvPmt.TabIndex = 6
        '
        'Column17
        '
        Me.Column17.HeaderText = "PaymentID"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Visible = False
        '
        'Column18
        '
        Me.Column18.HeaderText = "Payment Type"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        '
        'Column19
        '
        Me.Column19.HeaderText = "Ref No"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Width = 80
        '
        'Column20
        '
        Me.Column20.HeaderText = "Date"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.Width = 60
        '
        'Column21
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column21.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column21.HeaderText = "Amount"
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        Me.Column21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column21.Width = 105
        '
        'Column13
        '
        Me.Column13.HeaderText = "Refund"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Visible = False
        '
        'txtPAmt
        '
        Me.txtPAmt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPAmt.Location = New System.Drawing.Point(285, 114)
        Me.txtPAmt.Name = "txtPAmt"
        Me.txtPAmt.Size = New System.Drawing.Size(82, 21)
        Me.txtPAmt.TabIndex = 5
        Me.txtPAmt.Tag = "1"
        Me.txtPAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRefNo
        '
        Me.txtRefNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.Location = New System.Drawing.Point(117, 114)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(76, 21)
        Me.txtRefNo.TabIndex = 3
        '
        'cmbPmtType
        '
        Me.cmbPmtType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPmtType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPmtType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPmtType.FormattingEnabled = True
        Me.cmbPmtType.Location = New System.Drawing.Point(20, 114)
        Me.cmbPmtType.Name = "cmbPmtType"
        Me.cmbPmtType.Size = New System.Drawing.Size(91, 21)
        Me.cmbPmtType.TabIndex = 2
        Me.cmbPmtType.Tag = "1"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(316, 96)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 14)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Amount"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(196, 96)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 14)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Date"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(114, 96)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 14)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Ref No"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(17, 96)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 14)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Payment Type"
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BtnClear.FlatAppearance.BorderSize = 0
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(219, 292)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(71, 29)
        Me.BtnClear.TabIndex = 8
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'frmBillUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 334)
        Me.Controls.Add(Me.Panel6)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmBillUpdater"
        Me.Text = "frmBillUpdater"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvPmt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LblBillAmt As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnLoad2 As Button
    Friend WithEvents txtBillNo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpRef As DateTimePicker
    Friend WithEvents btnUpdate2 As Button
    Friend WithEvents dgvPmt As DataGridView
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents txtPAmt As TextBox
    Friend WithEvents txtRefNo As TextBox
    Friend WithEvents cmbPmtType As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LblMin As Label
    Friend WithEvents LblClose As Label
    Friend WithEvents BtnClear As Button
End Class
