<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColorUpdater
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.lblMacID = New System.Windows.Forms.Label()
        Me.btnUpdateColor = New System.Windows.Forms.Button()
        Me.pnlColors = New System.Windows.Forms.Panel()
        Me.btnHide = New System.Windows.Forms.Label()
        Me.btnChangeColor = New System.Windows.Forms.Button()
        Me.cmbColor2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlColors.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Color"
        '
        'cmbColor
        '
        Me.cmbColor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbColor.FormattingEnabled = True
        Me.cmbColor.Location = New System.Drawing.Point(15, 429)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(190, 22)
        Me.cmbColor.TabIndex = 3
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.AllowUserToResizeColumns = False
        Me.dgvList.AllowUserToResizeRows = False
        Me.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column7, Me.Column5, Me.Column9, Me.Column6, Me.Column8})
        Me.dgvList.EnableHeadersVisualStyles = False
        Me.dgvList.Location = New System.Drawing.Point(15, 58)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        Me.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvList.Size = New System.Drawing.Size(600, 345)
        Me.dgvList.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
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
        Me.Column3.Width = 160
        '
        'Column4
        '
        Me.Column4.HeaderText = "Rate"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 82
        '
        'Column7
        '
        Me.Column7.HeaderText = "Color"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'Column5
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Text = "r"
        Me.Column5.UseColumnTextForButtonValue = True
        Me.Column5.Width = 40
        '
        'Column9
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column9.HeaderText = ""
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Text = "2"
        Me.Column9.UseColumnTextForButtonValue = True
        Me.Column9.Width = 40
        '
        'Column6
        '
        Me.Column6.HeaderText = ""
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 25
        '
        'Column8
        '
        Me.Column8.HeaderText = "ColorId"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(15, 30)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(532, 22)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Code"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(553, 29)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(62, 24)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(465, 427)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(150, 25)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(357, 411)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total Items"
        '
        'lblRows
        '
        Me.lblRows.AutoSize = True
        Me.lblRows.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRows.Location = New System.Drawing.Point(357, 432)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(15, 14)
        Me.lblRows.TabIndex = 8
        Me.lblRows.Text = "0"
        '
        'lblMacID
        '
        Me.lblMacID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMacID.ForeColor = System.Drawing.Color.Maroon
        Me.lblMacID.Location = New System.Drawing.Point(387, 12)
        Me.lblMacID.Name = "lblMacID"
        Me.lblMacID.Size = New System.Drawing.Size(160, 13)
        Me.lblMacID.TabIndex = 9
        Me.lblMacID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpdateColor
        '
        Me.btnUpdateColor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateColor.Location = New System.Drawing.Point(211, 428)
        Me.btnUpdateColor.Name = "btnUpdateColor"
        Me.btnUpdateColor.Size = New System.Drawing.Size(62, 24)
        Me.btnUpdateColor.TabIndex = 10
        Me.btnUpdateColor.Text = "&Update"
        Me.btnUpdateColor.UseVisualStyleBackColor = True
        '
        'pnlColors
        '
        Me.pnlColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlColors.Controls.Add(Me.btnHide)
        Me.pnlColors.Controls.Add(Me.btnChangeColor)
        Me.pnlColors.Controls.Add(Me.cmbColor2)
        Me.pnlColors.Controls.Add(Me.Label5)
        Me.pnlColors.Controls.Add(Me.Label4)
        Me.pnlColors.Location = New System.Drawing.Point(146, 170)
        Me.pnlColors.Name = "pnlColors"
        Me.pnlColors.Size = New System.Drawing.Size(339, 127)
        Me.pnlColors.TabIndex = 11
        Me.pnlColors.Visible = False
        '
        'btnHide
        '
        Me.btnHide.AutoSize = True
        Me.btnHide.BackColor = System.Drawing.Color.Navy
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.White
        Me.btnHide.Location = New System.Drawing.Point(315, 3)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(19, 17)
        Me.btnHide.TabIndex = 2
        Me.btnHide.Text = "r"
        '
        'btnChangeColor
        '
        Me.btnChangeColor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeColor.Location = New System.Drawing.Point(245, 86)
        Me.btnChangeColor.Name = "btnChangeColor"
        Me.btnChangeColor.Size = New System.Drawing.Size(79, 24)
        Me.btnChangeColor.TabIndex = 1
        Me.btnChangeColor.Text = "&Change"
        Me.btnChangeColor.UseVisualStyleBackColor = True
        '
        'cmbColor2
        '
        Me.cmbColor2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbColor2.FormattingEnabled = True
        Me.cmbColor2.Location = New System.Drawing.Point(16, 55)
        Me.cmbColor2.Name = "cmbColor2"
        Me.cmbColor2.Size = New System.Drawing.Size(308, 22)
        Me.cmbColor2.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 14)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Color"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Navy
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(337, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Update Color"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmColorUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 467)
        Me.Controls.Add(Me.pnlColors)
        Me.Controls.Add(Me.btnUpdateColor)
        Me.Controls.Add(Me.lblMacID)
        Me.Controls.Add(Me.lblRows)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.dgvList)
        Me.Controls.Add(Me.cmbColor)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmColorUpdater"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Updater"
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlColors.ResumeLayout(False)
        Me.pnlColors.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbColor As ComboBox
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRows As Label
    Friend WithEvents lblMacID As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents Column9 As DataGridViewButtonColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdateColor As Button
    Friend WithEvents pnlColors As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnChangeColor As Button
    Friend WithEvents cmbColor2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnHide As Label
End Class
