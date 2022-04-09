<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
    Inherits MetroFramework.Forms.MetroForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.mQrNetLink = New MetroFramework.Controls.MetroLink()
        Me.mMetroLink = New MetroFramework.Controls.MetroLink()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.mGmapsLink = New MetroFramework.Controls.MetroLink()
        Me.mllRaspberryDave = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mQrNetLink
        '
        Me.mQrNetLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mQrNetLink.Location = New System.Drawing.Point(23, 204)
        Me.mQrNetLink.Name = "mQrNetLink"
        Me.mQrNetLink.Size = New System.Drawing.Size(512, 23)
        Me.mQrNetLink.TabIndex = 13
        Me.mQrNetLink.Text = "https://qrcodenet.codeplex.com/"
        Me.mQrNetLink.UseSelectable = True
        '
        'mMetroLink
        '
        Me.mMetroLink.BackColor = System.Drawing.SystemColors.Control
        Me.mMetroLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mMetroLink.Location = New System.Drawing.Point(23, 226)
        Me.mMetroLink.Name = "mMetroLink"
        Me.mMetroLink.Size = New System.Drawing.Size(512, 23)
        Me.mMetroLink.Style = MetroFramework.MetroColorStyle.Lime
        Me.mMetroLink.TabIndex = 14
        Me.mMetroLink.Text = "https://github.com/dennismagno/metroframework-modern-ui"
        Me.mMetroLink.UseSelectable = True
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(304, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(69, 69)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String() {"A small Tool for generating QR-Codes with ease. This program makes use of the QRC" &
            "ode.Net library, the MetroFramework UI controls and the GMaps library."}
        Me.MetroTextBox1.Location = New System.Drawing.Point(161, 120)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Multiline = True
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ReadOnly = True
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(374, 71)
        Me.MetroTextBox1.TabIndex = 18
        Me.MetroTextBox1.Text = "A small Tool for generating QR-Codes with ease. This program makes use of the QRC" &
    "ode.Net library, the MetroFramework UI controls and the GMaps library."
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnClose.Location = New System.Drawing.Point(428, 305)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(109, 23)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "OK"
        Me.btnClose.UseSelectable = True
        '
        'mGmapsLink
        '
        Me.mGmapsLink.BackColor = System.Drawing.SystemColors.Control
        Me.mGmapsLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mGmapsLink.Location = New System.Drawing.Point(23, 249)
        Me.mGmapsLink.Name = "mGmapsLink"
        Me.mGmapsLink.Size = New System.Drawing.Size(512, 23)
        Me.mGmapsLink.Style = MetroFramework.MetroColorStyle.Lime
        Me.mGmapsLink.TabIndex = 20
        Me.mGmapsLink.Text = "https://greatmaps.codeplex.com/"
        Me.mGmapsLink.UseSelectable = True
        '
        'mllRaspberryDave
        '
        Me.mllRaspberryDave.Location = New System.Drawing.Point(161, 89)
        Me.mllRaspberryDave.Name = "mllRaspberryDave"
        Me.mllRaspberryDave.Size = New System.Drawing.Size(177, 25)
        Me.mllRaspberryDave.TabIndex = 21
        Me.mllRaspberryDave.Text = "by David Niedermeyer"
        Me.mllRaspberryDave.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(161, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(177, 25)
        Me.MetroLabel1.TabIndex = 22
        Me.MetroLabel1.Text = "QR Code Generator"
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(560, 351)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.mllRaspberryDave)
        Me.Controls.Add(Me.mGmapsLink)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.mQrNetLink)
        Me.Controls.Add(Me.mMetroLink)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mQrNetLink As MetroFramework.Controls.MetroLink
    Friend WithEvents mMetroLink As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents mGmapsLink As MetroFramework.Controls.MetroLink
    Friend WithEvents mllRaspberryDave As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
