<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductReceivedNew
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDCode = New System.Windows.Forms.ComboBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TGTmp = New System.Windows.Forms.DataGridView()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TG = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblVar = New System.Windows.Forms.Label()
        Me.lblRcv = New System.Windows.Forms.Label()
        Me.lblDel = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.cmbFloor = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CmbReceiver = New System.Windows.Forms.ComboBox()
        Me.CmbScanner = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TGTmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Delivery Code"
        '
        'cmbDCode
        '
        Me.cmbDCode.FormattingEnabled = True
        Me.cmbDCode.Location = New System.Drawing.Point(17, 40)
        Me.cmbDCode.Name = "cmbDCode"
        Me.cmbDCode.Size = New System.Drawing.Size(206, 21)
        Me.cmbDCode.TabIndex = 0
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(229, 38)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(15, 30)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(156, 23)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "&Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnReject
        '
        Me.btnReject.Location = New System.Drawing.Point(177, 30)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(117, 23)
        Me.btnReject.TabIndex = 1
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbDCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnDisplay)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Delivery Info"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnImport)
        Me.GroupBox2.Controls.Add(Me.btnReject)
        Me.GroupBox2.Location = New System.Drawing.Point(332, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 76)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Delivery Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 590)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total Quantity"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TGTmp)
        Me.GroupBox4.Controls.Add(Me.TG)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 234)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(633, 345)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Product List"
        '
        'TGTmp
        '
        Me.TGTmp.AllowUserToAddRows = False
        Me.TGTmp.AllowUserToDeleteRows = False
        Me.TGTmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TGTmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.TGTmp.Location = New System.Drawing.Point(131, 83)
        Me.TGTmp.Name = "TGTmp"
        Me.TGTmp.ReadOnly = True
        Me.TGTmp.Size = New System.Drawing.Size(370, 245)
        Me.TGTmp.TabIndex = 1
        Me.TGTmp.Visible = False
        '
        'Column11
        '
        Me.Column11.HeaderText = "PLUID"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "QUANTITY"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "CP"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "RP"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'TG
        '
        Me.TG.AllowUserToAddRows = False
        Me.TG.AllowUserToDeleteRows = False
        Me.TG.AllowUserToResizeColumns = False
        Me.TG.AllowUserToResizeRows = False
        Me.TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column10, Me.Column8, Me.Column9, Me.Column15, Me.Column16})
        Me.TG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TG.Location = New System.Drawing.Point(3, 18)
        Me.TG.Name = "TG"
        Me.TG.RowHeadersVisible = False
        Me.TG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TG.Size = New System.Drawing.Size(627, 324)
        Me.TG.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "PluID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Sno"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 40
        '
        'Column3
        '
        Me.Column3.HeaderText = "Plucode"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "Description of Goods"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "UOM"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 50
        '
        'Column6
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column6.HeaderText = "Delivered"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 60
        '
        'Column7
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column7.HeaderText = "Received"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 60
        '
        'Column10
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column10.HeaderText = "Variation"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 60
        '
        'Column8
        '
        Me.Column8.HeaderText = "CP"
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        '
        'Column9
        '
        Me.Column9.HeaderText = "RP"
        Me.Column9.Name = "Column9"
        Me.Column9.Visible = False
        '
        'Column15
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column15.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column15.HeaderText = "Floor"
        Me.Column15.Name = "Column15"
        '
        'Column16
        '
        Me.Column16.HeaderText = ""
        Me.Column16.Name = "Column16"
        Me.Column16.Width = 23
        '
        'lblVar
        '
        Me.lblVar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVar.Location = New System.Drawing.Point(452, 590)
        Me.lblVar.Name = "lblVar"
        Me.lblVar.Size = New System.Drawing.Size(60, 13)
        Me.lblVar.TabIndex = 7
        Me.lblVar.Text = "0"
        Me.lblVar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRcv
        '
        Me.lblRcv.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRcv.Location = New System.Drawing.Point(396, 590)
        Me.lblRcv.Name = "lblRcv"
        Me.lblRcv.Size = New System.Drawing.Size(60, 13)
        Me.lblRcv.TabIndex = 8
        Me.lblRcv.Text = "0"
        Me.lblRcv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDel
        '
        Me.lblDel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDel.Location = New System.Drawing.Point(330, 590)
        Me.lblDel.Name = "lblDel"
        Me.lblDel.Size = New System.Drawing.Size(60, 13)
        Me.lblDel.TabIndex = 9
        Me.lblDel.Text = "0"
        Me.lblDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtRemarks)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(633, 48)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.SystemColors.Window
        Me.txtRemarks.Location = New System.Drawing.Point(11, 17)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ReadOnly = True
        Me.txtRemarks.Size = New System.Drawing.Size(608, 22)
        Me.txtRemarks.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnDone)
        Me.GroupBox5.Controls.Add(Me.cmbFloor)
        Me.GroupBox5.Location = New System.Drawing.Point(475, 149)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(165, 79)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Floor"
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(110, 37)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(49, 23)
        Me.btnDone.TabIndex = 1
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'cmbFloor
        '
        Me.cmbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFloor.FormattingEnabled = True
        Me.cmbFloor.Location = New System.Drawing.Point(6, 38)
        Me.cmbFloor.Name = "cmbFloor"
        Me.cmbFloor.Size = New System.Drawing.Size(98, 21)
        Me.cmbFloor.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CmbReceiver)
        Me.GroupBox6.Controls.Add(Me.CmbScanner)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Location = New System.Drawing.Point(10, 149)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(459, 79)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Additional Info"
        '
        'CmbReceiver
        '
        Me.CmbReceiver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbReceiver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbReceiver.FormattingEnabled = True
        Me.CmbReceiver.Location = New System.Drawing.Point(235, 38)
        Me.CmbReceiver.Name = "CmbReceiver"
        Me.CmbReceiver.Size = New System.Drawing.Size(218, 21)
        Me.CmbReceiver.TabIndex = 1
        '
        'CmbScanner
        '
        Me.CmbScanner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbScanner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbScanner.FormattingEnabled = True
        Me.CmbScanner.Location = New System.Drawing.Point(11, 38)
        Me.CmbScanner.Name = "CmbScanner"
        Me.CmbScanner.Size = New System.Drawing.Size(218, 21)
        Me.CmbScanner.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Received By"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Scanned By"
        '
        'ProductReceivedNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 615)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblDel)
        Me.Controls.Add(Me.lblRcv)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblVar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ProductReceivedNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Received"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.TGTmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbDCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnReject As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TG As System.Windows.Forms.DataGridView
    Friend WithEvents lblVar As System.Windows.Forms.Label
    Friend WithEvents lblRcv As System.Windows.Forms.Label
    Friend WithEvents lblDel As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents TGTmp As System.Windows.Forms.DataGridView
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnDone As Button
    Friend WithEvents cmbFloor As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CmbReceiver As ComboBox
    Friend WithEvents CmbScanner As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
