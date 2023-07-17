<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DayEnd
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkFloorwise = New System.Windows.Forms.CheckBox()
        Me.dgvTerm = New System.Windows.Forms.DataGridView()
        Me.chkDosPrinter = New System.Windows.Forms.CheckBox()
        Me.btnSSM = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.txtCopies = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lstPhone = New System.Windows.Forms.ListBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.SimpleLine6 = New simpleline.assemblies.simpleLine()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SimpleLine5 = New simpleline.assemblies.simpleLine()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SimpleLine4 = New simpleline.assemblies.simpleLine()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SimpleLine3 = New simpleline.assemblies.simpleLine()
        Me.lblCard = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkdhb = New System.Windows.Forms.CheckBox()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.mebnbd = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.chkFloorwise)
        Me.Panel1.Controls.Add(Me.dgvTerm)
        Me.Panel1.Controls.Add(Me.chkDosPrinter)
        Me.Panel1.Controls.Add(Me.btnSSM)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnMin)
        Me.Panel1.Controls.Add(Me.txtCopies)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.lstPhone)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.SimpleLine6)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.btnSend)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.SimpleLine5)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.SimpleLine4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.SimpleLine3)
        Me.Panel1.Controls.Add(Me.lblCard)
        Me.Panel1.Controls.Add(Me.lblCash)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.SimpleLine2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.chkdhb)
        Me.Panel1.Controls.Add(Me.SimpleLine1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.mebnbd)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 450)
        Me.Panel1.TabIndex = 1
        '
        'chkFloorwise
        '
        Me.chkFloorwise.AutoSize = True
        Me.chkFloorwise.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFloorwise.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.chkFloorwise.Location = New System.Drawing.Point(189, 315)
        Me.chkFloorwise.Name = "chkFloorwise"
        Me.chkFloorwise.Size = New System.Drawing.Size(105, 17)
        Me.chkFloorwise.TabIndex = 37
        Me.chkFloorwise.Text = "Load Floorwise"
        Me.chkFloorwise.UseVisualStyleBackColor = True
        '
        'dgvTerm
        '
        Me.dgvTerm.AllowUserToAddRows = False
        Me.dgvTerm.AllowUserToDeleteRows = False
        Me.dgvTerm.BackgroundColor = System.Drawing.Color.White
        Me.dgvTerm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5})
        Me.dgvTerm.EnableHeadersVisualStyles = False
        Me.dgvTerm.Location = New System.Drawing.Point(13, 338)
        Me.dgvTerm.Name = "dgvTerm"
        Me.dgvTerm.ReadOnly = True
        Me.dgvTerm.RowHeadersVisible = False
        Me.dgvTerm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvTerm.Size = New System.Drawing.Size(280, 100)
        Me.dgvTerm.TabIndex = 36
        '
        'chkDosPrinter
        '
        Me.chkDosPrinter.AutoSize = True
        Me.chkDosPrinter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkDosPrinter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.chkDosPrinter.Location = New System.Drawing.Point(466, 46)
        Me.chkDosPrinter.Name = "chkDosPrinter"
        Me.chkDosPrinter.Size = New System.Drawing.Size(132, 17)
        Me.chkDosPrinter.TabIndex = 35
        Me.chkDosPrinter.Text = "DOS PRINTER MODE"
        Me.chkDosPrinter.UseVisualStyleBackColor = True
        '
        'btnSSM
        '
        Me.btnSSM.AutoSize = True
        Me.btnSSM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSSM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSSM.Location = New System.Drawing.Point(473, 144)
        Me.btnSSM.Name = "btnSSM"
        Me.btnSSM.Size = New System.Drawing.Size(124, 15)
        Me.btnSSM.TabIndex = 34
        Me.btnSSM.Text = "Send Sample Message"
        Me.btnSSM.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(317, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 23)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "+91"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(575, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 26)
        Me.btnClose.TabIndex = 31
        Me.btnClose.Text = "r"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMin
        '
        Me.btnMin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnMin.ForeColor = System.Drawing.Color.White
        Me.btnMin.Location = New System.Drawing.Point(542, 3)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(32, 26)
        Me.btnMin.TabIndex = 32
        Me.btnMin.Text = "0"
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'txtCopies
        '
        Me.txtCopies.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopies.Location = New System.Drawing.Point(372, 414)
        Me.txtCopies.Name = "txtCopies"
        Me.txtCopies.Size = New System.Drawing.Size(66, 27)
        Me.txtCopies.TabIndex = 6
        Me.txtCopies.Text = "1"
        Me.txtCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkGray
        Me.Label18.Location = New System.Drawing.Point(314, 422)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Copies"
        '
        'lstPhone
        '
        Me.lstPhone.FormattingEnabled = True
        Me.lstPhone.ItemHeight = 15
        Me.lstPhone.Location = New System.Drawing.Point(317, 209)
        Me.lstPhone.Name = "lstPhone"
        Me.lstPhone.Size = New System.Drawing.Size(280, 199)
        Me.lstPhone.TabIndex = 5
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(361, 180)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(236, 23)
        Me.txtPhone.TabIndex = 4
        '
        'SimpleLine6
        '
        Me.SimpleLine6.Enabled = False
        Me.SimpleLine6.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine6.FitToParent = False
        Me.SimpleLine6.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine6.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine6.LineColor = System.Drawing.Color.WhiteSmoke
        Me.SimpleLine6.LineWidth = 1
        Me.SimpleLine6.Location = New System.Drawing.Point(317, 168)
        Me.SimpleLine6.Name = "SimpleLine6"
        Me.SimpleLine6.Size = New System.Drawing.Size(280, 1)
        Me.SimpleLine6.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine6.TabIndex = 27
        Me.SimpleLine6.UseGradient = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkGray
        Me.Label17.Location = New System.Drawing.Point(314, 145)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "MOBILE NUMBERS"
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(429, 84)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(168, 39)
        Me.btnSend.TabIndex = 3
        Me.btnSend.Text = "SEND MESSAGE"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(317, 84)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(106, 39)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "PRINT REPORT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'SimpleLine5
        '
        Me.SimpleLine5.Enabled = False
        Me.SimpleLine5.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine5.FitToParent = False
        Me.SimpleLine5.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine5.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine5.LineColor = System.Drawing.Color.WhiteSmoke
        Me.SimpleLine5.LineWidth = 1
        Me.SimpleLine5.Location = New System.Drawing.Point(317, 70)
        Me.SimpleLine5.Name = "SimpleLine5"
        Me.SimpleLine5.Size = New System.Drawing.Size(280, 1)
        Me.SimpleLine5.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine5.TabIndex = 23
        Me.SimpleLine5.UseGradient = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkGray
        Me.Label16.Location = New System.Drawing.Point(314, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "OPTIONS"
        '
        'SimpleLine4
        '
        Me.SimpleLine4.Enabled = False
        Me.SimpleLine4.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine4.FitToParent = False
        Me.SimpleLine4.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine4.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine4.LineColor = System.Drawing.Color.WhiteSmoke
        Me.SimpleLine4.LineWidth = 1
        Me.SimpleLine4.Location = New System.Drawing.Point(13, 338)
        Me.SimpleLine4.Name = "SimpleLine4"
        Me.SimpleLine4.Size = New System.Drawing.Size(280, 1)
        Me.SimpleLine4.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine4.TabIndex = 17
        Me.SimpleLine4.UseGradient = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGray
        Me.Label11.Location = New System.Drawing.Point(10, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "FLOOR SUMMARY"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(134, 274)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(160, 21)
        Me.lblTotal.TabIndex = 15
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(9, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 21)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "TOTAL SALES"
        '
        'SimpleLine3
        '
        Me.SimpleLine3.Enabled = False
        Me.SimpleLine3.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine3.FitToParent = False
        Me.SimpleLine3.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine3.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine3.LineColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.SimpleLine3.LineWidth = 1
        Me.SimpleLine3.Location = New System.Drawing.Point(13, 259)
        Me.SimpleLine3.Name = "SimpleLine3"
        Me.SimpleLine3.Size = New System.Drawing.Size(280, 1)
        Me.SimpleLine3.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine3.TabIndex = 13
        Me.SimpleLine3.UseGradient = False
        '
        'lblCard
        '
        Me.lblCard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCard.ForeColor = System.Drawing.Color.Black
        Me.lblCard.Location = New System.Drawing.Point(134, 223)
        Me.lblCard.Name = "lblCard"
        Me.lblCard.Size = New System.Drawing.Size(160, 21)
        Me.lblCard.TabIndex = 12
        Me.lblCard.Text = "0.00"
        Me.lblCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCash
        '
        Me.lblCash.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.ForeColor = System.Drawing.Color.Black
        Me.lblCash.Location = New System.Drawing.Point(134, 182)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(160, 21)
        Me.lblCash.TabIndex = 11
        Me.lblCash.Text = "0.00"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "CARD SALES "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CASH SALES "
        '
        'SimpleLine2
        '
        Me.SimpleLine2.Enabled = False
        Me.SimpleLine2.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine2.FitToParent = False
        Me.SimpleLine2.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine2.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine2.LineColor = System.Drawing.Color.WhiteSmoke
        Me.SimpleLine2.LineWidth = 1
        Me.SimpleLine2.Location = New System.Drawing.Point(13, 168)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(280, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 8
        Me.SimpleLine2.UseGradient = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(10, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DAYEND SUMMARY"
        '
        'chkdhb
        '
        Me.chkdhb.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.chkdhb.AutoSize = True
        Me.chkdhb.BackColor = System.Drawing.Color.Transparent
        Me.chkdhb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkdhb.ForeColor = System.Drawing.Color.Black
        Me.chkdhb.Location = New System.Drawing.Point(487, 421)
        Me.chkdhb.Name = "chkdhb"
        Me.chkdhb.Size = New System.Drawing.Size(111, 17)
        Me.chkdhb.TabIndex = 7
        Me.chkdhb.Text = "Delete Hold Bills"
        Me.chkdhb.UseVisualStyleBackColor = False
        Me.chkdhb.Visible = False
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Enabled = False
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.WhiteSmoke
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(13, 70)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(280, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 6
        Me.SimpleLine1.UseGradient = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(10, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DAYEND GENERATOR"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(610, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DAY END"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(138, 84)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(155, 39)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "GENERATE DAY END"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'mebnbd
        '
        Me.mebnbd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mebnbd.Location = New System.Drawing.Point(13, 100)
        Me.mebnbd.Name = "mebnbd"
        Me.mebnbd.Size = New System.Drawing.Size(103, 23)
        Me.mebnbd.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Business Date"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Floor"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column2.HeaderText = "Sales"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 27
        '
        'DayEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(618, 458)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DayEnd"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DayEnd"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkdhb As System.Windows.Forms.CheckBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents mebnbd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCopies As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lstPhone As System.Windows.Forms.ListBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents SimpleLine6 As simpleline.assemblies.simpleLine
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents SimpleLine5 As simpleline.assemblies.simpleLine
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine4 As simpleline.assemblies.simpleLine
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine3 As simpleline.assemblies.simpleLine
    Friend WithEvents lblCard As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine2 As simpleline.assemblies.simpleLine
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMin As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSSM As System.Windows.Forms.Label
    Friend WithEvents chkDosPrinter As System.Windows.Forms.CheckBox
    Friend WithEvents dgvTerm As DataGridView
    Friend WithEvents chkFloorwise As CheckBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
