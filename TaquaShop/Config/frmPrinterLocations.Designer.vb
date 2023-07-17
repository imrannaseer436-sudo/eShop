<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrinterLocations
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pnlPrinter = New System.Windows.Forms.Panel()
        Me.chkSuspended = New System.Windows.Forms.CheckBox()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtBatch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMacID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPrinter.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv.ColumnHeadersHeight = 25
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.Location = New System.Drawing.Point(12, 12)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 25
        Me.dgv.Size = New System.Drawing.Size(543, 250)
        Me.dgv.TabIndex = 0
        Me.dgv.Tag = "1"
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
        Me.Column2.HeaderText = "Printer"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Location"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 40
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(423, 270)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(132, 30)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add Printer"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'pnlPrinter
        '
        Me.pnlPrinter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrinter.Controls.Add(Me.chkSuspended)
        Me.pnlPrinter.Controls.Add(Me.btnHide)
        Me.pnlPrinter.Controls.Add(Me.btnSave)
        Me.pnlPrinter.Controls.Add(Me.btnBrowse)
        Me.pnlPrinter.Controls.Add(Me.txtBatch)
        Me.pnlPrinter.Controls.Add(Me.Label3)
        Me.pnlPrinter.Controls.Add(Me.txtName)
        Me.pnlPrinter.Controls.Add(Me.Label2)
        Me.pnlPrinter.Controls.Add(Me.Label1)
        Me.pnlPrinter.Location = New System.Drawing.Point(83, 48)
        Me.pnlPrinter.Name = "pnlPrinter"
        Me.pnlPrinter.Size = New System.Drawing.Size(400, 200)
        Me.pnlPrinter.TabIndex = 2
        Me.pnlPrinter.Visible = False
        '
        'chkSuspended
        '
        Me.chkSuspended.AutoSize = True
        Me.chkSuspended.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSuspended.Location = New System.Drawing.Point(287, 157)
        Me.chkSuspended.Name = "chkSuspended"
        Me.chkSuspended.Size = New System.Drawing.Size(88, 17)
        Me.chkSuspended.TabIndex = 4
        Me.chkSuspended.Text = "Suspended"
        Me.chkSuspended.UseVisualStyleBackColor = True
        Me.chkSuspended.Visible = False
        '
        'btnHide
        '
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.Location = New System.Drawing.Point(362, 3)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(33, 30)
        Me.btnHide.TabIndex = 4
        Me.btnHide.Text = "r"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(24, 149)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 30)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save && Close"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(341, 113)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(34, 25)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtBatch
        '
        Me.txtBatch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatch.Location = New System.Drawing.Point(24, 114)
        Me.txtBatch.Name = "txtBatch"
        Me.txtBatch.Size = New System.Drawing.Size(311, 23)
        Me.txtBatch.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Batch Location"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(24, 63)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(351, 23)
        Me.txtName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Printer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Printers"
        '
        'lblMacID
        '
        Me.lblMacID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMacID.ForeColor = System.Drawing.Color.Navy
        Me.lblMacID.Location = New System.Drawing.Point(59, 279)
        Me.lblMacID.Name = "lblMacID"
        Me.lblMacID.Size = New System.Drawing.Size(160, 13)
        Me.lblMacID.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Mac ID :"
        '
        'OFD1
        '
        Me.OFD1.Filter = "BAT Files (*.bat) | *.bat "
        Me.OFD1.Title = "Select printer locations"
        '
        'frmPrinterLocations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 311)
        Me.Controls.Add(Me.lblMacID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnlPrinter)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgv)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrinterLocations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Printer Locations"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPrinter.ResumeLayout(False)
        Me.pnlPrinter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewButtonColumn
    Friend WithEvents btnAdd As Button
    Friend WithEvents pnlPrinter As Panel
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtBatch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHide As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents chkSuspended As CheckBox
    Friend WithEvents lblMacID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents OFD1 As OpenFileDialog
End Class
