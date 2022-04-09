<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QrForm
    Inherits MetroFramework.Forms.MetroForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.mmEmail = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mmFacebook = New System.Windows.Forms.ToolStripMenuItem()
        Me.mmTwitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mmSaveToDisk = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tbCorrectionLevel = New MetroFramework.Controls.MetroTrackBar()
        Me.tbQuietZone = New MetroFramework.Controls.MetroTrackBar()
        Me.lblCL = New MetroFramework.Controls.MetroLabel()
        Me.lblQZ = New MetroFramework.Controls.MetroLabel()
        Me.btnOptions = New MetroFramework.Controls.MetroButton()
        Me.pnlOptions = New MetroFramework.Controls.MetroPanel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tbImage = New MetroFramework.Controls.MetroTabPage()
        Me.LineSeparator1 = New QR_Code.LineSeparator()
        Me.MyColorPickerBack = New QR_Code.myColorPicker()
        Me.MyColorPickerFront = New QR_Code.myColorPicker()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.btnPrint = New MetroFramework.Controls.MetroButton()
        Me.btnFacebook = New MetroFramework.Controls.MetroButton()
        Me.btnSaveToDisk = New MetroFramework.Controls.MetroButton()
        Me.btnSendMail = New MetroFramework.Controls.MetroButton()
        Me.LineSeparator2 = New QR_Code.LineSeparator()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.pbQrCode = New System.Windows.Forms.PictureBox()
        Me.MetroContextMenu1.SuspendLayout()
        Me.pnlOptions.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.tbImage.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        CType(Me.pbQrCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mmEmail, Me.ToolStripMenuItem2, Me.mmFacebook, Me.mmTwitter, Me.ToolStripMenuItem1, Me.PrintToolStripMenuItem, Me.mmSaveToDisk})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(190, 126)
        Me.MetroContextMenu1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroContextMenu1.UseStyleColors = True
        '
        'mmEmail
        '
        Me.mmEmail.Name = "mmEmail"
        Me.mmEmail.Size = New System.Drawing.Size(189, 22)
        Me.mmEmail.Text = "Send via E-Mail"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(186, 6)
        '
        'mmFacebook
        '
        Me.mmFacebook.Name = "mmFacebook"
        Me.mmFacebook.Size = New System.Drawing.Size(189, 22)
        Me.mmFacebook.Text = "Upload to Facebook..."
        '
        'mmTwitter
        '
        Me.mmTwitter.Enabled = False
        Me.mmTwitter.Name = "mmTwitter"
        Me.mmTwitter.Size = New System.Drawing.Size(189, 22)
        Me.mmTwitter.Text = "Upload to Twitter..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(186, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.PrintToolStripMenuItem.Text = "Print..."
        '
        'mmSaveToDisk
        '
        Me.mmSaveToDisk.Name = "mmSaveToDisk"
        Me.mmSaveToDisk.Size = New System.Drawing.Size(189, 22)
        Me.mmSaveToDisk.Text = "Save to Disk..."
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 42)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Quiet-Zone:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 14)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Correction:"
        '
        'tbCorrectionLevel
        '
        Me.tbCorrectionLevel.BackColor = System.Drawing.Color.Transparent
        Me.tbCorrectionLevel.LargeChange = 1
        Me.tbCorrectionLevel.Location = New System.Drawing.Point(88, 15)
        Me.tbCorrectionLevel.Maximum = 3
        Me.tbCorrectionLevel.Name = "tbCorrectionLevel"
        Me.tbCorrectionLevel.Size = New System.Drawing.Size(106, 23)
        Me.tbCorrectionLevel.TabIndex = 3
        Me.tbCorrectionLevel.Text = "MetroTrackBar2"
        Me.tbCorrectionLevel.Value = 3
        '
        'tbQuietZone
        '
        Me.tbQuietZone.BackColor = System.Drawing.Color.Transparent
        Me.tbQuietZone.LargeChange = 1
        Me.tbQuietZone.Location = New System.Drawing.Point(88, 42)
        Me.tbQuietZone.Maximum = 2
        Me.tbQuietZone.Name = "tbQuietZone"
        Me.tbQuietZone.Size = New System.Drawing.Size(106, 23)
        Me.tbQuietZone.TabIndex = 2
        Me.tbQuietZone.Text = "MetroTrackBar1"
        Me.tbQuietZone.Value = 2
        '
        'lblCL
        '
        Me.lblCL.AutoSize = True
        Me.lblCL.Location = New System.Drawing.Point(200, 19)
        Me.lblCL.Name = "lblCL"
        Me.lblCL.Size = New System.Drawing.Size(17, 19)
        Me.lblCL.TabIndex = 6
        Me.lblCL.Text = "X"
        '
        'lblQZ
        '
        Me.lblQZ.AutoSize = True
        Me.lblQZ.Location = New System.Drawing.Point(200, 42)
        Me.lblQZ.Name = "lblQZ"
        Me.lblQZ.Size = New System.Drawing.Size(17, 19)
        Me.lblQZ.TabIndex = 7
        Me.lblQZ.Text = "X"
        '
        'btnOptions
        '
        Me.btnOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOptions.Location = New System.Drawing.Point(0, 8)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(95, 24)
        Me.btnOptions.TabIndex = 2
        Me.btnOptions.Text = "<<"
        Me.btnOptions.UseSelectable = True
        '
        'pnlOptions
        '
        Me.pnlOptions.Controls.Add(Me.MetroTabControl1)
        Me.pnlOptions.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlOptions.HorizontalScrollbarBarColor = True
        Me.pnlOptions.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlOptions.HorizontalScrollbarSize = 10
        Me.pnlOptions.Location = New System.Drawing.Point(117, 60)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(224, 195)
        Me.pnlOptions.TabIndex = 8
        Me.pnlOptions.VerticalScrollbarBarColor = True
        Me.pnlOptions.VerticalScrollbarHighlightOnWheel = False
        Me.pnlOptions.VerticalScrollbarSize = 10
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tbImage)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(224, 195)
        Me.MetroTabControl1.TabIndex = 8
        Me.MetroTabControl1.UseSelectable = True
        '
        'tbImage
        '
        Me.tbImage.Controls.Add(Me.LineSeparator1)
        Me.tbImage.Controls.Add(Me.MyColorPickerBack)
        Me.tbImage.Controls.Add(Me.MyColorPickerFront)
        Me.tbImage.Controls.Add(Me.MetroLabel4)
        Me.tbImage.Controls.Add(Me.MetroLabel3)
        Me.tbImage.Controls.Add(Me.tbCorrectionLevel)
        Me.tbImage.Controls.Add(Me.tbQuietZone)
        Me.tbImage.Controls.Add(Me.MetroLabel2)
        Me.tbImage.Controls.Add(Me.MetroLabel1)
        Me.tbImage.Controls.Add(Me.lblCL)
        Me.tbImage.Controls.Add(Me.lblQZ)
        Me.tbImage.HorizontalScrollbarBarColor = True
        Me.tbImage.HorizontalScrollbarHighlightOnWheel = False
        Me.tbImage.HorizontalScrollbarSize = 10
        Me.tbImage.Location = New System.Drawing.Point(4, 38)
        Me.tbImage.Name = "tbImage"
        Me.tbImage.Size = New System.Drawing.Size(216, 153)
        Me.tbImage.TabIndex = 0
        Me.tbImage.Text = "Image"
        Me.tbImage.VerticalScrollbarBarColor = True
        Me.tbImage.VerticalScrollbarHighlightOnWheel = False
        Me.tbImage.VerticalScrollbarSize = 10
        '
        'LineSeparator1
        '
        Me.LineSeparator1.Location = New System.Drawing.Point(9, 72)
        Me.LineSeparator1.MaximumSize = New System.Drawing.Size(2000, 2)
        Me.LineSeparator1.MinimumSize = New System.Drawing.Size(0, 2)
        Me.LineSeparator1.Name = "LineSeparator1"
        Me.LineSeparator1.Size = New System.Drawing.Size(202, 2)
        Me.LineSeparator1.TabIndex = 14
        '
        'MyColorPickerBack
        '
        Me.MyColorPickerBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyColorPickerBack.Location = New System.Drawing.Point(90, 113)
        Me.MyColorPickerBack.MinimumSize = New System.Drawing.Size(55, 20)
        Me.MyColorPickerBack.Name = "MyColorPickerBack"
        Me.MyColorPickerBack.SelectedColor = System.Drawing.SystemColors.Control
        Me.MyColorPickerBack.Size = New System.Drawing.Size(104, 22)
        Me.MyColorPickerBack.TabIndex = 13
        Me.MyColorPickerBack.UseSelectable = True
        '
        'MyColorPickerFront
        '
        Me.MyColorPickerFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyColorPickerFront.Location = New System.Drawing.Point(90, 86)
        Me.MyColorPickerFront.MinimumSize = New System.Drawing.Size(55, 20)
        Me.MyColorPickerFront.Name = "MyColorPickerFront"
        Me.MyColorPickerFront.SelectedColor = System.Drawing.SystemColors.Control
        Me.MyColorPickerFront.Size = New System.Drawing.Size(104, 22)
        Me.MyColorPickerFront.TabIndex = 12
        Me.MyColorPickerFront.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 116)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(77, 19)
        Me.MetroLabel4.TabIndex = 10
        Me.MetroLabel4.Text = "Back Color:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 86)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "Front Color:"
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.btnPrint)
        Me.MetroTabPage1.Controls.Add(Me.btnFacebook)
        Me.MetroTabPage1.Controls.Add(Me.btnSaveToDisk)
        Me.MetroTabPage1.Controls.Add(Me.btnSendMail)
        Me.MetroTabPage1.Controls.Add(Me.LineSeparator2)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(216, 153)
        Me.MetroTabPage1.TabIndex = 1
        Me.MetroTabPage1.Text = "Export"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(15, 92)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(186, 23)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "Print..."
        Me.btnPrint.UseSelectable = True
        '
        'btnFacebook
        '
        Me.btnFacebook.Location = New System.Drawing.Point(15, 50)
        Me.btnFacebook.Name = "btnFacebook"
        Me.btnFacebook.Size = New System.Drawing.Size(186, 23)
        Me.btnFacebook.TabIndex = 12
        Me.btnFacebook.Text = "Upload to Facebook"
        Me.btnFacebook.UseSelectable = True
        '
        'btnSaveToDisk
        '
        Me.btnSaveToDisk.Location = New System.Drawing.Point(15, 121)
        Me.btnSaveToDisk.Name = "btnSaveToDisk"
        Me.btnSaveToDisk.Size = New System.Drawing.Size(186, 23)
        Me.btnSaveToDisk.TabIndex = 11
        Me.btnSaveToDisk.Text = "Save to Disk..."
        Me.btnSaveToDisk.UseSelectable = True
        '
        'btnSendMail
        '
        Me.btnSendMail.Location = New System.Drawing.Point(15, 21)
        Me.btnSendMail.Name = "btnSendMail"
        Me.btnSendMail.Size = New System.Drawing.Size(186, 23)
        Me.btnSendMail.TabIndex = 2
        Me.btnSendMail.Text = "Send via E-Mail"
        Me.btnSendMail.UseSelectable = True
        '
        'LineSeparator2
        '
        Me.LineSeparator2.Location = New System.Drawing.Point(15, 82)
        Me.LineSeparator2.MaximumSize = New System.Drawing.Size(2000, 2)
        Me.LineSeparator2.MinimumSize = New System.Drawing.Size(0, 2)
        Me.LineSeparator2.Name = "LineSeparator2"
        Me.LineSeparator2.Size = New System.Drawing.Size(186, 2)
        Me.LineSeparator2.TabIndex = 13
        '
        'pnlFooter
        '
        Me.pnlFooter.Controls.Add(Me.btnOptions)
        Me.pnlFooter.Location = New System.Drawing.Point(16, 131)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
        Me.pnlFooter.Size = New System.Drawing.Size(95, 40)
        Me.pnlFooter.TabIndex = 9
        '
        'pbQrCode
        '
        Me.pbQrCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbQrCode.ContextMenuStrip = Me.MetroContextMenu1
        Me.pbQrCode.Location = New System.Drawing.Point(10, 63)
        Me.pbQrCode.Name = "pbQrCode"
        Me.pbQrCode.Size = New System.Drawing.Size(84, 49)
        Me.pbQrCode.TabIndex = 3
        Me.pbQrCode.TabStop = False
        '
        'QrForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(351, 255)
        Me.Controls.Add(Me.pnlOptions)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pbQrCode)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(0, 255)
        Me.Name = "QrForm"
        Me.Padding = New System.Windows.Forms.Padding(10, 60, 10, 0)
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "QR-Code"
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.pnlOptions.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tbImage.ResumeLayout(False)
        Me.tbImage.PerformLayout()
        Me.MetroTabPage1.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        CType(Me.pbQrCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbQrCode As PictureBox
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents mmEmail As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents mmSaveToDisk As ToolStripMenuItem
    Friend WithEvents tbCorrectionLevel As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents tbQuietZone As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblQZ As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCL As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnOptions As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents btnSaveToDisk As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSendMail As MetroFramework.Controls.MetroButton
    Friend WithEvents tbImage As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pnlOptions As MetroFramework.Controls.MetroPanel
    Friend WithEvents MyColorPickerBack As myColorPicker
    Friend WithEvents MyColorPickerFront As myColorPicker
    Friend WithEvents LineSeparator1 As LineSeparator
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mmFacebook As ToolStripMenuItem
    Friend WithEvents mmTwitter As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents LineSeparator2 As LineSeparator
    Friend WithEvents btnFacebook As MetroFramework.Controls.MetroButton
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroButton
End Class
