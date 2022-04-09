<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TwitterForm
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
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.mlUpload = New MetroFramework.Controls.MetroLink()
        Me.mlClose = New MetroFramework.Controls.MetroLink()
        Me.txtAccessToken = New MetroFramework.Controls.MetroTextBox()
        Me.txtTweet = New MetroFramework.Controls.MetroTextBox()
        Me.pnlBrowser = New MetroFramework.Controls.MetroPanel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.MetroPanel1.SuspendLayout()
        Me.pnlBrowser.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.mlUpload)
        Me.MetroPanel1.Controls.Add(Me.mlClose)
        Me.MetroPanel1.Controls.Add(Me.txtAccessToken)
        Me.MetroPanel1.Controls.Add(Me.txtTweet)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 263)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(520, 97)
        Me.MetroPanel1.TabIndex = 9
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'mlUpload
        '
        Me.mlUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mlUpload.Image = Global.QR_Code.My.Resources.Resources.CloudUpload_64
        Me.mlUpload.ImageSize = 64
        Me.mlUpload.Location = New System.Drawing.Point(333, 3)
        Me.mlUpload.Name = "mlUpload"
        Me.mlUpload.Size = New System.Drawing.Size(75, 90)
        Me.mlUpload.TabIndex = 12
        Me.mlUpload.UseSelectable = True
        '
        'mlClose
        '
        Me.mlClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mlClose.Image = Global.QR_Code.My.Resources.Resources.ArrowRight_48
        Me.mlClose.ImageSize = 48
        Me.mlClose.Location = New System.Drawing.Point(457, 3)
        Me.mlClose.Name = "mlClose"
        Me.mlClose.Size = New System.Drawing.Size(60, 90)
        Me.mlClose.TabIndex = 11
        Me.mlClose.UseSelectable = True
        '
        'txtAccessToken
        '
        '
        '
        '
        Me.txtAccessToken.CustomButton.Image = Nothing
        Me.txtAccessToken.CustomButton.Location = New System.Drawing.Point(228, 1)
        Me.txtAccessToken.CustomButton.Name = ""
        Me.txtAccessToken.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAccessToken.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAccessToken.CustomButton.TabIndex = 1
        Me.txtAccessToken.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAccessToken.CustomButton.UseSelectable = True
        Me.txtAccessToken.CustomButton.Visible = False
        Me.txtAccessToken.Lines = New String(-1) {}
        Me.txtAccessToken.Location = New System.Drawing.Point(15, 62)
        Me.txtAccessToken.MaxLength = 32767
        Me.txtAccessToken.Name = "txtAccessToken"
        Me.txtAccessToken.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAccessToken.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAccessToken.SelectedText = ""
        Me.txtAccessToken.SelectionLength = 0
        Me.txtAccessToken.SelectionStart = 0
        Me.txtAccessToken.Size = New System.Drawing.Size(250, 23)
        Me.txtAccessToken.TabIndex = 5
        Me.txtAccessToken.UseSelectable = True
        Me.txtAccessToken.Visible = False
        Me.txtAccessToken.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAccessToken.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTweet
        '
        '
        '
        '
        Me.txtTweet.CustomButton.Image = Nothing
        Me.txtTweet.CustomButton.Location = New System.Drawing.Point(234, 1)
        Me.txtTweet.CustomButton.Name = ""
        Me.txtTweet.CustomButton.Size = New System.Drawing.Size(81, 81)
        Me.txtTweet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTweet.CustomButton.TabIndex = 1
        Me.txtTweet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTweet.CustomButton.UseSelectable = True
        Me.txtTweet.CustomButton.Visible = False
        Me.txtTweet.Lines = New String() {"Description..."}
        Me.txtTweet.Location = New System.Drawing.Point(11, 6)
        Me.txtTweet.MaxLength = 32767
        Me.txtTweet.Multiline = True
        Me.txtTweet.Name = "txtTweet"
        Me.txtTweet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTweet.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTweet.SelectedText = ""
        Me.txtTweet.SelectionLength = 0
        Me.txtTweet.SelectionStart = 0
        Me.txtTweet.Size = New System.Drawing.Size(316, 83)
        Me.txtTweet.TabIndex = 0
        Me.txtTweet.Text = "Description..."
        Me.txtTweet.UseSelectable = True
        Me.txtTweet.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTweet.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pnlBrowser
        '
        Me.pnlBrowser.Controls.Add(Me.WebBrowser1)
        Me.pnlBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBrowser.HorizontalScrollbarBarColor = True
        Me.pnlBrowser.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlBrowser.HorizontalScrollbarSize = 10
        Me.pnlBrowser.Location = New System.Drawing.Point(20, 30)
        Me.pnlBrowser.Name = "pnlBrowser"
        Me.pnlBrowser.Size = New System.Drawing.Size(520, 330)
        Me.pnlBrowser.TabIndex = 8
        Me.pnlBrowser.VerticalScrollbarBarColor = True
        Me.pnlBrowser.VerticalScrollbarHighlightOnWheel = False
        Me.pnlBrowser.VerticalScrollbarSize = 10
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(520, 330)
        Me.WebBrowser1.TabIndex = 0
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.PictureBox1)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(20, 30)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(81, 233)
        Me.MetroPanel2.TabIndex = 11
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QR_Code.My.Resources.Resources.square_twitter_64
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'pbImage
        '
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImage.Location = New System.Drawing.Point(177, 35)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(200, 200)
        Me.pbImage.TabIndex = 10
        Me.pbImage.TabStop = False
        '
        'TwitterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 380)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.pnlBrowser)
        Me.Controls.Add(Me.pbImage)
        Me.DisplayHeader = False
        Me.Name = "TwitterForm"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.Text = "TwitterForm"
        Me.MetroPanel1.ResumeLayout(False)
        Me.pnlBrowser.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents mlUpload As MetroFramework.Controls.MetroLink
    Friend WithEvents mlClose As MetroFramework.Controls.MetroLink
    Friend WithEvents txtAccessToken As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTweet As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pnlBrowser As MetroFramework.Controls.MetroPanel
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbImage As PictureBox
End Class
