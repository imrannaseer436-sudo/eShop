<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentType
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
        Me.txtPmtDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdoCash = New System.Windows.Forms.RadioButton()
        Me.rdoCard = New System.Windows.Forms.RadioButton()
        Me.RdoVoucher = New System.Windows.Forms.RadioButton()
        Me.rdoCredit = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAlter = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPmtDesc
        '
        Me.txtPmtDesc.Location = New System.Drawing.Point(20, 69)
        Me.txtPmtDesc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPmtDesc.Name = "txtPmtDesc"
        Me.txtPmtDesc.Size = New System.Drawing.Size(305, 25)
        Me.txtPmtDesc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Payment Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Payment Type"
        '
        'rdoCash
        '
        Me.rdoCash.AutoSize = True
        Me.rdoCash.Checked = True
        Me.rdoCash.Location = New System.Drawing.Point(20, 154)
        Me.rdoCash.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoCash.Name = "rdoCash"
        Me.rdoCash.Size = New System.Drawing.Size(54, 21)
        Me.rdoCash.TabIndex = 1
        Me.rdoCash.TabStop = True
        Me.rdoCash.Text = "Cash"
        Me.rdoCash.UseVisualStyleBackColor = True
        '
        'rdoCard
        '
        Me.rdoCard.AutoSize = True
        Me.rdoCard.Location = New System.Drawing.Point(96, 154)
        Me.rdoCard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoCard.Name = "rdoCard"
        Me.rdoCard.Size = New System.Drawing.Size(54, 21)
        Me.rdoCard.TabIndex = 2
        Me.rdoCard.TabStop = True
        Me.rdoCard.Text = "Card"
        Me.rdoCard.UseVisualStyleBackColor = True
        '
        'RdoVoucher
        '
        Me.RdoVoucher.AutoSize = True
        Me.RdoVoucher.Location = New System.Drawing.Point(172, 154)
        Me.RdoVoucher.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdoVoucher.Name = "RdoVoucher"
        Me.RdoVoucher.Size = New System.Drawing.Size(74, 21)
        Me.RdoVoucher.TabIndex = 3
        Me.RdoVoucher.TabStop = True
        Me.RdoVoucher.Text = "Voucher"
        Me.RdoVoucher.UseVisualStyleBackColor = True
        '
        'rdoCredit
        '
        Me.rdoCredit.AutoSize = True
        Me.rdoCredit.Location = New System.Drawing.Point(265, 154)
        Me.rdoCredit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoCredit.Name = "rdoCredit"
        Me.rdoCredit.Size = New System.Drawing.Size(61, 21)
        Me.rdoCredit.TabIndex = 4
        Me.rdoCredit.TabStop = True
        Me.rdoCredit.Text = "Credit"
        Me.rdoCredit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(53, 229)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 30)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Store"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAlter
        '
        Me.btnAlter.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnAlter.FlatAppearance.BorderSize = 0
        Me.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlter.ForeColor = System.Drawing.Color.White
        Me.btnAlter.Location = New System.Drawing.Point(146, 229)
        Me.btnAlter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAlter.Name = "btnAlter"
        Me.btnAlter.Size = New System.Drawing.Size(87, 30)
        Me.btnAlter.TabIndex = 6
        Me.btnAlter.Text = "&Alter"
        Me.btnAlter.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(239, 229)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(87, 30)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Options"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(716, 36)
        Me.Panel1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(14, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Payment Type"
        '
        'PaymentType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(716, 515)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAlter)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.rdoCredit)
        Me.Controls.Add(Me.RdoVoucher)
        Me.Controls.Add(Me.rdoCard)
        Me.Controls.Add(Me.rdoCash)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPmtDesc)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PaymentType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Mode"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPmtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdoCash As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCard As System.Windows.Forms.RadioButton
    Friend WithEvents RdoVoucher As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCredit As System.Windows.Forms.RadioButton
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAlter As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
