<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerifier
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.dgvCode = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblRefID = New System.Windows.Forms.Label()
        Me.pnlList = New System.Windows.Forms.Panel()
        Me.btnHide = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbDCode = New System.Windows.Forms.ComboBox()
        Me.btnLoad2 = New System.Windows.Forms.Button()
        Me.dgvDCode = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.dgvRst = New System.Windows.Forms.DataGridView()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblReceived = New System.Windows.Forms.Label()
        Me.lblDelivered = New System.Windows.Forms.Label()
        Me.lblVariation = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pnlErr = New System.Windows.Forms.Panel()
        Me.btnHide2 = New System.Windows.Forms.Label()
        Me.dgvErr = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlList.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlErr.SuspendLayout()
        CType(Me.dgvErr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Code (F8)"
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(16, 64)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(266, 22)
        Me.txtCode.TabIndex = 0
        '
        'dgvCode
        '
        Me.dgvCode.AllowUserToAddRows = False
        Me.dgvCode.AllowUserToDeleteRows = False
        Me.dgvCode.AllowUserToResizeColumns = False
        Me.dgvCode.AllowUserToResizeRows = False
        Me.dgvCode.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column9})
        Me.dgvCode.EnableHeadersVisualStyles = False
        Me.dgvCode.Location = New System.Drawing.Point(16, 92)
        Me.dgvCode.MultiSelect = False
        Me.dgvCode.Name = "dgvCode"
        Me.dgvCode.ReadOnly = True
        Me.dgvCode.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvCode.RowHeadersVisible = False
        Me.dgvCode.RowTemplate.Height = 23
        Me.dgvCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCode.Size = New System.Drawing.Size(266, 328)
        Me.dgvCode.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product Code"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Text = "r"
        Me.Column3.ToolTipText = "Remove"
        Me.Column3.UseColumnTextForButtonValue = True
        Me.Column3.Width = 40
        '
        'Column4
        '
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 23
        '
        'Column9
        '
        Me.Column9.HeaderText = "Sno"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.Navy
        Me.lblCount.Location = New System.Drawing.Point(189, 44)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(100, 15)
        Me.lblCount.TabIndex = 3
        Me.lblCount.Text = "[ 0 ] "
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "BARCODE READER"
        '
        'btnReload
        '
        Me.btnReload.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReload.ForeColor = System.Drawing.Color.Purple
        Me.btnReload.Location = New System.Drawing.Point(16, 426)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(130, 30)
        Me.btnReload.TabIndex = 2
        Me.btnReload.Text = "Reload &Data"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.Location = New System.Drawing.Point(152, 426)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(130, 30)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "&Remove All"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblRefID
        '
        Me.lblRefID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRefID.Location = New System.Drawing.Point(826, 12)
        Me.lblRefID.Name = "lblRefID"
        Me.lblRefID.Size = New System.Drawing.Size(120, 14)
        Me.lblRefID.TabIndex = 6
        Me.lblRefID.Text = "My-PC"
        Me.lblRefID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlList
        '
        Me.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlList.Controls.Add(Me.btnHide)
        Me.pnlList.Controls.Add(Me.btnLoad)
        Me.pnlList.Controls.Add(Me.dgvList)
        Me.pnlList.Controls.Add(Me.Label3)
        Me.pnlList.Location = New System.Drawing.Point(17, 122)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Size = New System.Drawing.Size(264, 286)
        Me.pnlList.TabIndex = 9
        Me.pnlList.Visible = False
        '
        'btnHide
        '
        Me.btnHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(231, -1)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(32, 24)
        Me.btnHide.TabIndex = 8
        Me.btnHide.Text = "r"
        Me.btnHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(185, 255)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(74, 23)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "&Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.AllowUserToResizeColumns = False
        Me.dgvList.AllowUserToResizeRows = False
        Me.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvList.EnableHeadersVisualStyles = False
        Me.dgvList.Location = New System.Drawing.Point(3, 27)
        Me.dgvList.MultiSelect = False
        Me.dgvList.Name = "dgvList"
        Me.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.RowTemplate.Height = 23
        Me.dgvList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvList.Size = New System.Drawing.Size(256, 222)
        Me.dgvList.TabIndex = 0
        '
        'Column5
        '
        Me.Column5.HeaderText = "Ref ID"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 130
        '
        'Column6
        '
        Me.Column6.HeaderText = "Count"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 60
        '
        'Column7
        '
        Me.Column7.FalseValue = "0"
        Me.Column7.HeaderText = ""
        Me.Column7.Name = "Column7"
        Me.Column7.TrueValue = "1"
        Me.Column7.Width = 40
        '
        'Column8
        '
        Me.Column8.HeaderText = ""
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 23
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "List of Entries"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(301, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "DELIVERY LIST"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(301, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "List of Delivery Code"
        '
        'cmbDCode
        '
        Me.cmbDCode.FormattingEnabled = True
        Me.cmbDCode.Location = New System.Drawing.Point(304, 64)
        Me.cmbDCode.Name = "cmbDCode"
        Me.cmbDCode.Size = New System.Drawing.Size(227, 22)
        Me.cmbDCode.TabIndex = 4
        '
        'btnLoad2
        '
        Me.btnLoad2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad2.Location = New System.Drawing.Point(537, 63)
        Me.btnLoad2.Name = "btnLoad2"
        Me.btnLoad2.Size = New System.Drawing.Size(33, 23)
        Me.btnLoad2.TabIndex = 5
        Me.btnLoad2.Text = "..."
        Me.btnLoad2.UseVisualStyleBackColor = True
        '
        'dgvDCode
        '
        Me.dgvDCode.AllowUserToAddRows = False
        Me.dgvDCode.AllowUserToDeleteRows = False
        Me.dgvDCode.AllowUserToResizeColumns = False
        Me.dgvDCode.AllowUserToResizeRows = False
        Me.dgvDCode.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDCode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewButtonColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgvDCode.EnableHeadersVisualStyles = False
        Me.dgvDCode.Location = New System.Drawing.Point(304, 92)
        Me.dgvDCode.MultiSelect = False
        Me.dgvDCode.Name = "dgvDCode"
        Me.dgvDCode.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvDCode.RowHeadersVisible = False
        Me.dgvDCode.RowTemplate.Height = 23
        Me.dgvDCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvDCode.Size = New System.Drawing.Size(266, 328)
        Me.dgvDCode.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Delivery Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewButtonColumn1
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        DataGridViewCellStyle4.NullValue = False
        Me.DataGridViewButtonColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewButtonColumn1.FalseValue = "0"
        Me.DataGridViewButtonColumn1.HeaderText = ""
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewButtonColumn1.ToolTipText = "Remove"
        Me.DataGridViewButtonColumn1.TrueValue = "1"
        Me.DataGridViewButtonColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = ""
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 23
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sno"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'btnRun
        '
        Me.btnRun.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.ForeColor = System.Drawing.Color.Navy
        Me.btnRun.Location = New System.Drawing.Point(304, 426)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(266, 30)
        Me.btnRun.TabIndex = 7
        Me.btnRun.Text = "&Run Verification"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'dgvRst
        '
        Me.dgvRst.AllowUserToAddRows = False
        Me.dgvRst.AllowUserToDeleteRows = False
        Me.dgvRst.AllowUserToResizeColumns = False
        Me.dgvRst.AllowUserToResizeRows = False
        Me.dgvRst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvRst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15})
        Me.dgvRst.EnableHeadersVisualStyles = False
        Me.dgvRst.Location = New System.Drawing.Point(590, 64)
        Me.dgvRst.MultiSelect = False
        Me.dgvRst.Name = "dgvRst"
        Me.dgvRst.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvRst.RowHeadersVisible = False
        Me.dgvRst.RowTemplate.Height = 23
        Me.dgvRst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvRst.Size = New System.Drawing.Size(356, 356)
        Me.dgvRst.TabIndex = 8
        '
        'Column10
        '
        Me.Column10.HeaderText = "Plucode"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 120
        '
        'Column11
        '
        Me.Column11.HeaderText = "Delivered"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 70
        '
        'Column12
        '
        Me.Column12.HeaderText = "Received"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 70
        '
        'Column13
        '
        Me.Column13.HeaderText = "Variation"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 70
        '
        'Column14
        '
        Me.Column14.HeaderText = ""
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 23
        '
        'Column15
        '
        Me.Column15.HeaderText = "PluID"
        Me.Column15.Name = "Column15"
        Me.Column15.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(587, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 14)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "VERIFICATION"
        '
        'lblReceived
        '
        Me.lblReceived.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceived.Location = New System.Drawing.Point(787, 433)
        Me.lblReceived.Name = "lblReceived"
        Me.lblReceived.Size = New System.Drawing.Size(70, 16)
        Me.lblReceived.TabIndex = 17
        Me.lblReceived.Text = "0"
        Me.lblReceived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDelivered
        '
        Me.lblDelivered.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelivered.Location = New System.Drawing.Point(711, 433)
        Me.lblDelivered.Name = "lblDelivered"
        Me.lblDelivered.Size = New System.Drawing.Size(70, 16)
        Me.lblDelivered.TabIndex = 18
        Me.lblDelivered.Text = "0"
        Me.lblDelivered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVariation
        '
        Me.lblVariation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVariation.Location = New System.Drawing.Point(863, 433)
        Me.lblVariation.Name = "lblVariation"
        Me.lblVariation.Size = New System.Drawing.Size(70, 16)
        Me.lblVariation.TabIndex = 19
        Me.lblVariation.Text = "0"
        Me.lblVariation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(587, 433)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Result"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(587, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 14)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Verification Result"
        '
        'pnlErr
        '
        Me.pnlErr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlErr.Controls.Add(Me.btnHide2)
        Me.pnlErr.Controls.Add(Me.dgvErr)
        Me.pnlErr.Controls.Add(Me.Label8)
        Me.pnlErr.Location = New System.Drawing.Point(643, 109)
        Me.pnlErr.Name = "pnlErr"
        Me.pnlErr.Size = New System.Drawing.Size(264, 286)
        Me.pnlErr.TabIndex = 22
        Me.pnlErr.Visible = False
        '
        'btnHide2
        '
        Me.btnHide2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHide2.BackColor = System.Drawing.Color.Black
        Me.btnHide2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHide2.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide2.ForeColor = System.Drawing.Color.White
        Me.btnHide2.Location = New System.Drawing.Point(231, -1)
        Me.btnHide2.Name = "btnHide2"
        Me.btnHide2.Size = New System.Drawing.Size(32, 24)
        Me.btnHide2.TabIndex = 8
        Me.btnHide2.Text = "r"
        Me.btnHide2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvErr
        '
        Me.dgvErr.AllowUserToAddRows = False
        Me.dgvErr.AllowUserToDeleteRows = False
        Me.dgvErr.AllowUserToResizeColumns = False
        Me.dgvErr.AllowUserToResizeRows = False
        Me.dgvErr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvErr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvErr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7})
        Me.dgvErr.EnableHeadersVisualStyles = False
        Me.dgvErr.Location = New System.Drawing.Point(3, 27)
        Me.dgvErr.MultiSelect = False
        Me.dgvErr.Name = "dgvErr"
        Me.dgvErr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvErr.RowHeadersVisible = False
        Me.dgvErr.RowTemplate.Height = 23
        Me.dgvErr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvErr.Size = New System.Drawing.Size(256, 253)
        Me.dgvErr.TabIndex = 0
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Delivery Code"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 230
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = ""
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 23
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Teal
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(262, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "List of Errors"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmVerifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 467)
        Me.Controls.Add(Me.pnlErr)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblVariation)
        Me.Controls.Add(Me.lblDelivered)
        Me.Controls.Add(Me.lblReceived)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvRst)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.dgvDCode)
        Me.Controls.Add(Me.btnLoad2)
        Me.Controls.Add(Me.cmbDCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnlList)
        Me.Controls.Add(Me.lblRefID)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.dgvCode)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmVerifier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Verifier"
        CType(Me.dgvCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlList.ResumeLayout(False)
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlErr.ResumeLayout(False)
        CType(Me.dgvErr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents dgvCode As System.Windows.Forms.DataGridView
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lblRefID As System.Windows.Forms.Label
    Friend WithEvents pnlList As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnHide As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbDCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnLoad2 As System.Windows.Forms.Button
    Friend WithEvents dgvDCode As System.Windows.Forms.DataGridView
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvRst As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblReceived As System.Windows.Forms.Label
    Friend WithEvents lblDelivered As System.Windows.Forms.Label
    Friend WithEvents lblVariation As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pnlErr As System.Windows.Forms.Panel
    Friend WithEvents btnHide2 As System.Windows.Forms.Label
    Friend WithEvents dgvErr As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
