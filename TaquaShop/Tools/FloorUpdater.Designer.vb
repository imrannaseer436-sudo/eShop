<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FloorUpdater
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvList = New Zuby.ADGV.AdvancedDataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkShowAll = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SimpleLine2 = New simpleline.assemblies.simpleLine()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SimpleLine1 = New simpleline.assemblies.simpleLine()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDeliveryCode = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPerc = New System.Windows.Forms.Label()
        Me.pbar1 = New System.Windows.Forms.ProgressBar()
        Me.pnlLoad = New System.Windows.Forms.Panel()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.pnlFloorUpdate = New System.Windows.Forms.Panel()
        Me.btnHide = New System.Windows.Forms.Label()
        Me.btnUpdate2 = New System.Windows.Forms.Button()
        Me.cmbFloor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bgw1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlLoad.SuspendLayout()
        Me.pnlFloorUpdate.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvList)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 314)
        Me.Panel1.TabIndex = 0
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.AllowUserToResizeRows = False
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvList.FilterAndSortEnabled = True
        Me.dgvList.Location = New System.Drawing.Point(0, 0)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        Me.dgvList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvList.Size = New System.Drawing.Size(735, 314)
        Me.dgvList.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightGray
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(735, 110)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.chkShowAll)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.SimpleLine2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.SimpleLine1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cmbDeliveryCode)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnDisplay)
        Me.Panel2.Location = New System.Drawing.Point(137, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(461, 98)
        Me.Panel2.TabIndex = 0
        '
        'chkShowAll
        '
        Me.chkShowAll.AutoSize = True
        Me.chkShowAll.Location = New System.Drawing.Point(209, 39)
        Me.chkShowAll.Name = "chkShowAll"
        Me.chkShowAll.Size = New System.Drawing.Size(66, 17)
        Me.chkShowAll.TabIndex = 7
        Me.chkShowAll.Text = "&Show All"
        Me.chkShowAll.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(283, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "OPTIONS"
        '
        'SimpleLine2
        '
        Me.SimpleLine2.Enabled = False
        Me.SimpleLine2.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine2.FitToParent = False
        Me.SimpleLine2.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine2.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine2.LineColor = System.Drawing.Color.Silver
        Me.SimpleLine2.LineWidth = 1
        Me.SimpleLine2.Location = New System.Drawing.Point(286, 30)
        Me.SimpleLine2.Name = "SimpleLine2"
        Me.SimpleLine2.Size = New System.Drawing.Size(156, 1)
        Me.SimpleLine2.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine2.TabIndex = 5
        Me.SimpleLine2.UseGradient = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "DELIVERY CODE"
        '
        'SimpleLine1
        '
        Me.SimpleLine1.Enabled = False
        Me.SimpleLine1.FillColor = System.Drawing.Color.Transparent
        Me.SimpleLine1.FitToParent = False
        Me.SimpleLine1.Gradient = System.Drawing.Color.Transparent
        Me.SimpleLine1.GradientAngle = simpleline.assemblies.GradientDirection.Horizontal
        Me.SimpleLine1.LineColor = System.Drawing.Color.Silver
        Me.SimpleLine1.LineWidth = 1
        Me.SimpleLine1.Location = New System.Drawing.Point(19, 30)
        Me.SimpleLine1.Name = "SimpleLine1"
        Me.SimpleLine1.Size = New System.Drawing.Size(250, 1)
        Me.SimpleLine1.Style = simpleline.assemblies.LineStyle.Horizontal
        Me.SimpleLine1.TabIndex = 3
        Me.SimpleLine1.UseGradient = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Delivery Code"
        '
        'cmbDeliveryCode
        '
        Me.cmbDeliveryCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDeliveryCode.FormattingEnabled = True
        Me.cmbDeliveryCode.Location = New System.Drawing.Point(19, 59)
        Me.cmbDeliveryCode.Name = "cmbDeliveryCode"
        Me.cmbDeliveryCode.Size = New System.Drawing.Size(250, 21)
        Me.cmbDeliveryCode.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(367, 56)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 25)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(286, 56)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 25)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MistyRose
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.lblPerc)
        Me.Panel3.Controls.Add(Me.pbar1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 424)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(735, 32)
        Me.Panel3.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(372, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Status :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPerc
        '
        Me.lblPerc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPerc.Location = New System.Drawing.Point(684, 9)
        Me.lblPerc.Name = "lblPerc"
        Me.lblPerc.Size = New System.Drawing.Size(39, 13)
        Me.lblPerc.TabIndex = 1
        Me.lblPerc.Text = "0%"
        Me.lblPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbar1
        '
        Me.pbar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbar1.Location = New System.Drawing.Point(528, 8)
        Me.pbar1.Name = "pbar1"
        Me.pbar1.Size = New System.Drawing.Size(150, 16)
        Me.pbar1.TabIndex = 0
        '
        'pnlLoad
        '
        Me.pnlLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLoad.Controls.Add(Me.lblMessage)
        Me.pnlLoad.Location = New System.Drawing.Point(242, 191)
        Me.pnlLoad.Name = "pnlLoad"
        Me.pnlLoad.Size = New System.Drawing.Size(250, 75)
        Me.pnlLoad.TabIndex = 6
        Me.pnlLoad.Visible = False
        '
        'lblMessage
        '
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMessage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(0, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(248, 73)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Loading, Please Wait..!"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlFloorUpdate
        '
        Me.pnlFloorUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlFloorUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFloorUpdate.Controls.Add(Me.btnHide)
        Me.pnlFloorUpdate.Controls.Add(Me.btnUpdate2)
        Me.pnlFloorUpdate.Controls.Add(Me.cmbFloor)
        Me.pnlFloorUpdate.Controls.Add(Me.Label2)
        Me.pnlFloorUpdate.Controls.Add(Me.Label1)
        Me.pnlFloorUpdate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlFloorUpdate.Location = New System.Drawing.Point(259, 178)
        Me.pnlFloorUpdate.Name = "pnlFloorUpdate"
        Me.pnlFloorUpdate.Size = New System.Drawing.Size(216, 101)
        Me.pnlFloorUpdate.TabIndex = 7
        Me.pnlFloorUpdate.Visible = False
        '
        'btnHide
        '
        Me.btnHide.AutoSize = True
        Me.btnHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHide.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHide.Location = New System.Drawing.Point(189, 5)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(19, 17)
        Me.btnHide.TabIndex = 4
        Me.btnHide.Text = "r"
        '
        'btnUpdate2
        '
        Me.btnUpdate2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate2.Location = New System.Drawing.Point(125, 56)
        Me.btnUpdate2.Name = "btnUpdate2"
        Me.btnUpdate2.Size = New System.Drawing.Size(75, 26)
        Me.btnUpdate2.TabIndex = 3
        Me.btnUpdate2.Text = "&Update"
        Me.btnUpdate2.UseVisualStyleBackColor = True
        '
        'cmbFloor
        '
        Me.cmbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFloor.FormattingEnabled = True
        Me.cmbFloor.Location = New System.Drawing.Point(17, 57)
        Me.cmbFloor.Name = "cmbFloor"
        Me.cmbFloor.Size = New System.Drawing.Size(102, 24)
        Me.cmbFloor.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FLOOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FLOOR UPDATER"
        '
        'bgw1
        '
        '
        'FloorUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 456)
        Me.Controls.Add(Me.pnlFloorUpdate)
        Me.Controls.Add(Me.pnlLoad)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FloorUpdater"
        Me.Text = "Floor Updater"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.pnlLoad.ResumeLayout(False)
        Me.pnlFloorUpdate.ResumeLayout(False)
        Me.pnlFloorUpdate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvList As Zuby.ADGV.AdvancedDataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents SimpleLine2 As simpleline.assemblies.simpleLine
    Friend WithEvents Label4 As Label
    Friend WithEvents SimpleLine1 As simpleline.assemblies.simpleLine
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbDeliveryCode As ComboBox
    Friend WithEvents chkShowAll As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlLoad As Panel
    Friend WithEvents lblMessage As Label
    Friend WithEvents pnlFloorUpdate As Panel
    Friend WithEvents btnHide As Label
    Friend WithEvents btnUpdate2 As Button
    Friend WithEvents cmbFloor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPerc As Label
    Friend WithEvents pbar1 As ProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents bgw1 As System.ComponentModel.BackgroundWorker
End Class
