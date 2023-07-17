<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xTile
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CtlTileText = New System.Windows.Forms.Label()
        Me.Icon = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CtlTileText, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Icon, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(150, 150)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'CtlTileText
        '
        Me.CtlTileText.BackColor = System.Drawing.Color.Transparent
        Me.CtlTileText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlTileText.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtlTileText.Location = New System.Drawing.Point(3, 120)
        Me.CtlTileText.Name = "CtlTileText"
        Me.CtlTileText.Size = New System.Drawing.Size(144, 30)
        Me.CtlTileText.TabIndex = 1
        Me.CtlTileText.Text = "UNTITLED"
        Me.CtlTileText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Icon
        '
        Me.Icon.BackColor = System.Drawing.Color.Transparent
        Me.Icon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon.Font = New System.Drawing.Font("Segoe UI Symbol", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon.Location = New System.Drawing.Point(3, 0)
        Me.Icon.Name = "Icon"
        Me.Icon.Size = New System.Drawing.Size(144, 120)
        Me.Icon.TabIndex = 0
        Me.Icon.Text = ""
        Me.Icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xTile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "xTile"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CtlTileText As System.Windows.Forms.Label
    Friend WithEvents Icon As System.Windows.Forms.Label

End Class
