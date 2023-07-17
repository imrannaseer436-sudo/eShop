<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscountUpdater
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDis = New System.Windows.Forms.TextBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblGrnNo = New System.Windows.Forms.Label()
        Me.lblGrnDt = New System.Windows.Forms.Label()
        Me.lblInvDt = New System.Windows.Forms.Label()
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblVendor = New System.Windows.Forms.Label()
        Me.chkShowPurchase = New System.Windows.Forms.CheckBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCode = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv.ColumnHeadersHeight = 25
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15})
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.Location = New System.Drawing.Point(15, 58)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 25
        Me.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv.Size = New System.Drawing.Size(757, 361)
        Me.dgv.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Code"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(15, 30)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(302, 22)
        Me.txtCode.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(323, 29)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(71, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(683, 433)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 70)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(416, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Discount"
        '
        'txtDis
        '
        Me.txtDis.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDis.Location = New System.Drawing.Point(476, 30)
        Me.txtDis.Name = "txtDis"
        Me.txtDis.Size = New System.Drawing.Size(56, 22)
        Me.txtDis.TabIndex = 3
        Me.txtDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnApply
        '
        Me.btnApply.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(538, 29)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(71, 24)
        Me.btnApply.TabIndex = 4
        Me.btnApply.Text = "&Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(492, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(639, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total Pieces :"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.Purple
        Me.lblQty.Location = New System.Drawing.Point(732, 33)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(15, 14)
        Me.lblQty.TabIndex = 10
        Me.lblQty.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaShell
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblInvDt)
        Me.Panel1.Controls.Add(Me.lblInvNo)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblGrnDt)
        Me.Panel1.Controls.Add(Me.lblGrnNo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(15, 434)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 68)
        Me.Panel1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "GRN No :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(171, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Date :"
        '
        'lblGrnNo
        '
        Me.lblGrnNo.AutoSize = True
        Me.lblGrnNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrnNo.ForeColor = System.Drawing.Color.Maroon
        Me.lblGrnNo.Location = New System.Drawing.Point(75, 12)
        Me.lblGrnNo.Name = "lblGrnNo"
        Me.lblGrnNo.Size = New System.Drawing.Size(0, 14)
        Me.lblGrnNo.TabIndex = 2
        '
        'lblGrnDt
        '
        Me.lblGrnDt.AutoSize = True
        Me.lblGrnDt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrnDt.ForeColor = System.Drawing.Color.Maroon
        Me.lblGrnDt.Location = New System.Drawing.Point(218, 12)
        Me.lblGrnDt.Name = "lblGrnDt"
        Me.lblGrnDt.Size = New System.Drawing.Size(0, 14)
        Me.lblGrnDt.TabIndex = 3
        '
        'lblInvDt
        '
        Me.lblInvDt.AutoSize = True
        Me.lblInvDt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvDt.ForeColor = System.Drawing.Color.Maroon
        Me.lblInvDt.Location = New System.Drawing.Point(218, 38)
        Me.lblInvDt.Name = "lblInvDt"
        Me.lblInvDt.Size = New System.Drawing.Size(0, 14)
        Me.lblInvDt.TabIndex = 7
        '
        'lblInvNo
        '
        Me.lblInvNo.AutoSize = True
        Me.lblInvNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNo.ForeColor = System.Drawing.Color.Maroon
        Me.lblInvNo.Location = New System.Drawing.Point(75, 38)
        Me.lblInvNo.Name = "lblInvNo"
        Me.lblInvNo.Size = New System.Drawing.Size(0, 14)
        Me.lblInvNo.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(171, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 14)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Days :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 14)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "INV No :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Beige
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblCode)
        Me.Panel2.Controls.Add(Me.lblVendor)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Location = New System.Drawing.Point(349, 434)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(328, 68)
        Me.Panel2.TabIndex = 12
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 14)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Vendor"
        '
        'lblVendor
        '
        Me.lblVendor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblVendor.Location = New System.Drawing.Point(12, 38)
        Me.lblVendor.Name = "lblVendor"
        Me.lblVendor.Size = New System.Drawing.Size(300, 14)
        Me.lblVendor.TabIndex = 8
        '
        'chkShowPurchase
        '
        Me.chkShowPurchase.AutoSize = True
        Me.chkShowPurchase.Checked = True
        Me.chkShowPurchase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowPurchase.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPurchase.Location = New System.Drawing.Point(186, 9)
        Me.chkShowPurchase.Name = "chkShowPurchase"
        Me.chkShowPurchase.Size = New System.Drawing.Size(134, 17)
        Me.chkShowPurchase.TabIndex = 13
        Me.chkShowPurchase.Text = "Show Purchase Details"
        Me.chkShowPurchase.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "PluId"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Code"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "C.Price"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "R.Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 80
        '
        'Column6
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column6.HeaderText = "Discount"
        Me.Column6.Name = "Column6"
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "N.R Price"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 80
        '
        'Column8
        '
        Me.Column8.HeaderText = "P.Diff"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 80
        '
        'Column9
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column9.HeaderText = ""
        Me.Column9.Name = "Column9"
        Me.Column9.Text = "r"
        Me.Column9.UseColumnTextForButtonValue = True
        Me.Column9.Width = 40
        '
        'Column10
        '
        Me.Column10.HeaderText = ""
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 23
        '
        'Column11
        '
        Me.Column11.HeaderText = "GrnNo"
        Me.Column11.Name = "Column11"
        Me.Column11.Visible = False
        '
        'Column12
        '
        Me.Column12.HeaderText = "GrnDt"
        Me.Column12.Name = "Column12"
        Me.Column12.Visible = False
        '
        'Column13
        '
        Me.Column13.HeaderText = "InvNo"
        Me.Column13.Name = "Column13"
        Me.Column13.Visible = False
        '
        'Column14
        '
        Me.Column14.HeaderText = "Vendor"
        Me.Column14.Name = "Column14"
        Me.Column14.Visible = False
        '
        'Column15
        '
        Me.Column15.HeaderText = "Days"
        Me.Column15.Name = "Column15"
        Me.Column15.Visible = False
        '
        'lblCode
        '
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCode.Location = New System.Drawing.Point(162, 12)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(150, 14)
        Me.lblCode.TabIndex = 9
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DiscountUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 517)
        Me.Controls.Add(Me.chkShowPurchase)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.txtDis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DiscountUpdater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discount Updater"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDis As TextBox
    Friend WithEvents btnApply As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblInvDt As Label
    Friend WithEvents lblInvNo As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblGrnDt As Label
    Friend WithEvents lblGrnNo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblVendor As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents chkShowPurchase As CheckBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewButtonColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents lblCode As Label
End Class
