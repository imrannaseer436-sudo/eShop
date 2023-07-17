<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductReport
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkEZQ = New System.Windows.Forms.CheckBox()
        Me.chkSBK = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.lblSearchMode = New System.Windows.Forms.Label()
        Me.btnAdvanceSearch = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.pnlSearchOpn = New System.Windows.Forms.Panel()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.cmbSCat5 = New System.Windows.Forms.ComboBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.cmbSCat4 = New System.Windows.Forms.ComboBox()
        Me.cmbSCat3 = New System.Windows.Forms.ComboBox()
        Me.cmbSCat2 = New System.Windows.Forms.ComboBox()
        Me.cmbSCat1 = New System.Windows.Forms.ComboBox()
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearchOpn.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TG, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(982, 592)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel2, 2)
        Me.Panel2.Controls.Add(Me.lblStock)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.chkEZQ)
        Me.Panel2.Controls.Add(Me.chkSBK)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnShowAll)
        Me.Panel2.Controls.Add(Me.lblSearchMode)
        Me.Panel2.Controls.Add(Me.btnAdvanceSearch)
        Me.Panel2.Controls.Add(Me.txtCode)
        Me.Panel2.Controls.Add(Me.lblCode)
        Me.Panel2.Location = New System.Drawing.Point(3, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(932, 66)
        Me.Panel2.TabIndex = 0
        '
        'lblStock
        '
        Me.lblStock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.lblStock.Location = New System.Drawing.Point(664, 32)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(85, 15)
        Me.lblStock.TabIndex = 17
        Me.lblStock.Text = "0"
        Me.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(664, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "TOTAL STOCK"
        '
        'chkEZQ
        '
        Me.chkEZQ.AutoSize = True
        Me.chkEZQ.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEZQ.Location = New System.Drawing.Point(450, 3)
        Me.chkEZQ.Name = "chkEZQ"
        Me.chkEZQ.Size = New System.Drawing.Size(157, 17)
        Me.chkEZQ.TabIndex = 16
        Me.chkEZQ.Text = "EXCLUDE ZERO QUANTITY"
        Me.chkEZQ.UseVisualStyleBackColor = True
        '
        'chkSBK
        '
        Me.chkSBK.AutoSize = True
        Me.chkSBK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSBK.ForeColor = System.Drawing.Color.DimGray
        Me.chkSBK.Location = New System.Drawing.Point(276, 3)
        Me.chkSBK.Name = "chkSBK"
        Me.chkSBK.Size = New System.Drawing.Size(136, 17)
        Me.chkSBK.TabIndex = 15
        Me.chkSBK.Text = "SEARCH BY KEYWORD"
        Me.chkSBK.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(536, 26)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 27)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnShowAll
        '
        Me.btnShowAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnShowAll.FlatAppearance.BorderSize = 0
        Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAll.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAll.ForeColor = System.Drawing.Color.White
        Me.btnShowAll.Location = New System.Drawing.Point(448, 26)
        Me.btnShowAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(82, 27)
        Me.btnShowAll.TabIndex = 2
        Me.btnShowAll.Text = "SHOW ALL"
        Me.btnShowAll.UseVisualStyleBackColor = False
        '
        'lblSearchMode
        '
        Me.lblSearchMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSearchMode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchMode.ForeColor = System.Drawing.Color.Gray
        Me.lblSearchMode.Location = New System.Drawing.Point(198, 9)
        Me.lblSearchMode.Name = "lblSearchMode"
        Me.lblSearchMode.Size = New System.Drawing.Size(72, 15)
        Me.lblSearchMode.TabIndex = 14
        Me.lblSearchMode.Text = "< PRODUCT"
        Me.lblSearchMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAdvanceSearch
        '
        Me.btnAdvanceSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnAdvanceSearch.FlatAppearance.BorderSize = 0
        Me.btnAdvanceSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdvanceSearch.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvanceSearch.ForeColor = System.Drawing.Color.White
        Me.btnAdvanceSearch.Location = New System.Drawing.Point(276, 26)
        Me.btnAdvanceSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdvanceSearch.Name = "btnAdvanceSearch"
        Me.btnAdvanceSearch.Size = New System.Drawing.Size(166, 27)
        Me.btnAdvanceSearch.TabIndex = 1
        Me.btnAdvanceSearch.Text = "ADVANCE SEARCH OPTIONS"
        Me.btnAdvanceSearch.UseVisualStyleBackColor = False
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(9, 27)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(261, 25)
        Me.txtCode.TabIndex = 0
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(6, 9)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(38, 15)
        Me.lblCode.TabIndex = 0
        Me.lblCode.Text = "CODE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Product Report"
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        Me.TG.BackgroundColor = System.Drawing.Color.White
        Me.TG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.TG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TG.ColumnHeadersHeight = 30
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TG.DefaultCellStyle = DataGridViewCellStyle2
        Me.TG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TG.EnableHeadersVisualStyles = False
        Me.TG.Location = New System.Drawing.Point(11, 107)
        Me.TG.Name = "TG"
        Me.TG.ReadOnly = True
        Me.TG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TG.RowHeadersVisible = False
        Me.TG.RowTemplate.Height = 30
        Me.TG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TG.Size = New System.Drawing.Size(968, 482)
        Me.TG.TabIndex = 1
        '
        'pnlSearchOpn
        '
        Me.pnlSearchOpn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlSearchOpn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearchOpn.Controls.Add(Me.btnHide)
        Me.pnlSearchOpn.Controls.Add(Me.cmbSCat5)
        Me.pnlSearchOpn.Controls.Add(Me.btnShow)
        Me.pnlSearchOpn.Controls.Add(Me.cmbSCat4)
        Me.pnlSearchOpn.Controls.Add(Me.cmbSCat3)
        Me.pnlSearchOpn.Controls.Add(Me.cmbSCat2)
        Me.pnlSearchOpn.Controls.Add(Me.cmbSCat1)
        Me.pnlSearchOpn.Controls.Add(Me.cmbCat)
        Me.pnlSearchOpn.Controls.Add(Me.Label8)
        Me.pnlSearchOpn.Controls.Add(Me.Label7)
        Me.pnlSearchOpn.Controls.Add(Me.Label6)
        Me.pnlSearchOpn.Controls.Add(Me.Label5)
        Me.pnlSearchOpn.Controls.Add(Me.Label4)
        Me.pnlSearchOpn.Controls.Add(Me.Label3)
        Me.pnlSearchOpn.Controls.Add(Me.Label1)
        Me.pnlSearchOpn.Location = New System.Drawing.Point(171, 133)
        Me.pnlSearchOpn.Name = "pnlSearchOpn"
        Me.pnlSearchOpn.Size = New System.Drawing.Size(427, 327)
        Me.pnlSearchOpn.TabIndex = 5
        Me.pnlSearchOpn.Visible = False
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(383, 7)
        Me.btnHide.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(34, 27)
        Me.btnHide.TabIndex = 7
        Me.btnHide.Text = "r"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'cmbSCat5
        '
        Me.cmbSCat5.FormattingEnabled = True
        Me.cmbSCat5.Location = New System.Drawing.Point(118, 243)
        Me.cmbSCat5.Name = "cmbSCat5"
        Me.cmbSCat5.Size = New System.Drawing.Size(299, 23)
        Me.cmbSCat5.TabIndex = 5
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnShow.FlatAppearance.BorderSize = 0
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(327, 285)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(90, 27)
        Me.btnShow.TabIndex = 6
        Me.btnShow.Text = "SHOW"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'cmbSCat4
        '
        Me.cmbSCat4.FormattingEnabled = True
        Me.cmbSCat4.Location = New System.Drawing.Point(118, 203)
        Me.cmbSCat4.Name = "cmbSCat4"
        Me.cmbSCat4.Size = New System.Drawing.Size(299, 23)
        Me.cmbSCat4.TabIndex = 4
        '
        'cmbSCat3
        '
        Me.cmbSCat3.FormattingEnabled = True
        Me.cmbSCat3.Location = New System.Drawing.Point(118, 163)
        Me.cmbSCat3.Name = "cmbSCat3"
        Me.cmbSCat3.Size = New System.Drawing.Size(299, 23)
        Me.cmbSCat3.TabIndex = 3
        '
        'cmbSCat2
        '
        Me.cmbSCat2.FormattingEnabled = True
        Me.cmbSCat2.Location = New System.Drawing.Point(118, 123)
        Me.cmbSCat2.Name = "cmbSCat2"
        Me.cmbSCat2.Size = New System.Drawing.Size(299, 23)
        Me.cmbSCat2.TabIndex = 2
        '
        'cmbSCat1
        '
        Me.cmbSCat1.FormattingEnabled = True
        Me.cmbSCat1.Location = New System.Drawing.Point(118, 83)
        Me.cmbSCat1.Name = "cmbSCat1"
        Me.cmbSCat1.Size = New System.Drawing.Size(299, 23)
        Me.cmbSCat1.TabIndex = 1
        '
        'cmbCat
        '
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Location = New System.Drawing.Point(118, 43)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(299, 23)
        Me.cmbCat.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(5, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "PATTERN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(5, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "STYLE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(5, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "BRAND"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(5, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "MATERIAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "CATEGORY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "DEPARTMENT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search options"
        '
        'ProductReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(982, 592)
        Me.Controls.Add(Me.pnlSearchOpn)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ProductReport"
        Me.Text = "ProductReport"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearchOpn.ResumeLayout(False)
        Me.pnlSearchOpn.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents btnAdvanceSearch As System.Windows.Forms.Button
    Friend WithEvents lblSearchMode As System.Windows.Forms.Label
    Friend WithEvents pnlSearchOpn As System.Windows.Forms.Panel
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents cmbSCat5 As System.Windows.Forms.ComboBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents cmbSCat4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSCat3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSCat2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSCat1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCat As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents chkSBK As System.Windows.Forms.CheckBox
    Friend WithEvents chkEZQ As System.Windows.Forms.CheckBox
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
