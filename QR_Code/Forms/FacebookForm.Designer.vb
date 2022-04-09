<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FacebookForm
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtStatusUpdate = New MetroFramework.Controls.MetroTextBox()
        Me.cmbFriends = New MetroFramework.Controls.MetroComboBox()
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
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.txtStatusUpdate)
        Me.MetroPanel1.Controls.Add(Me.cmbFriends)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 263)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(520, 97)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        Me.MetroPanel1.Visible = False
        '
        'mlUpload
        '
        Me.mlUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mlUpload.Image = Global.QR_Code.My.Resources.Resources.CloudUpload_64
        Me.mlUpload.ImageSize = 48
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
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(11, 10)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel1.TabIndex = 9
        Me.MetroLabel1.Text = "Select Wall:"
        '
        'txtStatusUpdate
        '
        '
        '
        '
        Me.txtStatusUpdate.CustomButton.Image = Nothing
        Me.txtStatusUpdate.CustomButton.Location = New System.Drawing.Point(266, 2)
        Me.txtStatusUpdate.CustomButton.Name = ""
        Me.txtStatusUpdate.CustomButton.Size = New System.Drawing.Size(47, 47)
        Me.txtStatusUpdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStatusUpdate.CustomButton.TabIndex = 1
        Me.txtStatusUpdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStatusUpdate.CustomButton.UseSelectable = True
        Me.txtStatusUpdate.CustomButton.Visible = False
        Me.txtStatusUpdate.Lines = New String() {"Description..."}
        Me.txtStatusUpdate.Location = New System.Drawing.Point(11, 37)
        Me.txtStatusUpdate.MaxLength = 32767
        Me.txtStatusUpdate.Multiline = True
        Me.txtStatusUpdate.Name = "txtStatusUpdate"
        Me.txtStatusUpdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatusUpdate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStatusUpdate.SelectedText = ""
        Me.txtStatusUpdate.SelectionLength = 0
        Me.txtStatusUpdate.SelectionStart = 0
        Me.txtStatusUpdate.Size = New System.Drawing.Size(316, 52)
        Me.txtStatusUpdate.TabIndex = 0
        Me.txtStatusUpdate.Text = "Description..."
        Me.txtStatusUpdate.UseSelectable = True
        Me.txtStatusUpdate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStatusUpdate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbFriends
        '
        Me.cmbFriends.FormattingEnabled = True
        Me.cmbFriends.ItemHeight = 23
        Me.cmbFriends.Location = New System.Drawing.Point(91, 5)
        Me.cmbFriends.Name = "cmbFriends"
        Me.cmbFriends.Size = New System.Drawing.Size(235, 29)
        Me.cmbFriends.TabIndex = 1
        Me.cmbFriends.UseSelectable = True
        '
        'pnlBrowser
        '
        Me.pnlBrowser.Controls.Add(Me.WebBrowser1)
        Me.pnlBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBrowser.HorizontalScrollbarBarColor = True
        Me.pnlBrowser.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlBrowser.HorizontalScrollbarSize = 10
        Me.pnlBrowser.Location = New System.Drawing.Point(101, 30)
        Me.pnlBrowser.Name = "pnlBrowser"
        Me.pnlBrowser.Size = New System.Drawing.Size(439, 233)
        Me.pnlBrowser.TabIndex = 1
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
        Me.WebBrowser1.Size = New System.Drawing.Size(439, 233)
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
        Me.MetroPanel2.TabIndex = 7
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QR_Code.My.Resources.Resources.square_facebook_64
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'pbImage
        '
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImage.Location = New System.Drawing.Point(177, 33)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(200, 200)
        Me.pbImage.TabIndex = 3
        Me.pbImage.TabStop = False
        '
        'FacebookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(560, 380)
        Me.Controls.Add(Me.pnlBrowser)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.MetroPanel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FacebookForm"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.Text = "FacebookForm"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.pnlBrowser.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents txtAccessToken As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbFriends As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtStatusUpdate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pnlBrowser As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents mlClose As MetroFramework.Controls.MetroLink
    Friend WithEvents mlUpload As MetroFramework.Controls.MetroLink
End Class
