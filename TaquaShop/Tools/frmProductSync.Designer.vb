<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductSync
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
        Me.btnSync = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSync
        '
        Me.btnSync.Location = New System.Drawing.Point(54, 36)
        Me.btnSync.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSync.Name = "btnSync"
        Me.btnSync.Size = New System.Drawing.Size(232, 74)
        Me.btnSync.TabIndex = 0
        Me.btnSync.Text = "SYNC MANUALLY"
        Me.btnSync.UseVisualStyleBackColor = True
        '
        'frmProductSync
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 147)
        Me.Controls.Add(Me.btnSync)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductSync"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Sync - Manually"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSync As System.Windows.Forms.Button
End Class
