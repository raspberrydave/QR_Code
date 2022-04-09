<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmailForm
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnOK = New MetroFramework.Controls.MetroButton()
        Me.txtRecipiant = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtMessage = New MetroFramework.Controls.MetroTextBox()
        Me.LineSeparator1 = New QR_Code.LineSeparator()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QR_Code.My.Resources.Resources.email_64
        Me.PictureBox1.Location = New System.Drawing.Point(13, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btnCancel)
        Me.MetroPanel1.Controls.Add(Me.btnOK)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(10, 212)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(389, 41)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(223, 9)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Back"
        Me.btnCancel.UseSelectable = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(304, 9)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "Send"
        Me.btnOK.UseSelectable = True
        '
        'txtRecipiant
        '
        Me.txtRecipiant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtRecipiant.CustomButton.Image = Nothing
        Me.txtRecipiant.CustomButton.Location = New System.Drawing.Point(193, 1)
        Me.txtRecipiant.CustomButton.Name = ""
        Me.txtRecipiant.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtRecipiant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRecipiant.CustomButton.TabIndex = 1
        Me.txtRecipiant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRecipiant.CustomButton.UseSelectable = True
        Me.txtRecipiant.CustomButton.Visible = False
        Me.txtRecipiant.Lines = New String(-1) {}
        Me.txtRecipiant.Location = New System.Drawing.Point(174, 70)
        Me.txtRecipiant.MaxLength = 32767
        Me.txtRecipiant.Name = "txtRecipiant"
        Me.txtRecipiant.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRecipiant.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRecipiant.SelectedText = ""
        Me.txtRecipiant.SelectionLength = 0
        Me.txtRecipiant.SelectionStart = 0
        Me.txtRecipiant.Size = New System.Drawing.Size(215, 23)
        Me.txtRecipiant.TabIndex = 0
        Me.txtRecipiant.UseSelectable = True
        Me.txtRecipiant.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRecipiant.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(99, 74)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel1.TabIndex = 17
        Me.MetroLabel1.Text = "Recipiant:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(99, 103)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel2.TabIndex = 18
        Me.MetroLabel2.Text = "Message:"
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtMessage.CustomButton.Image = Nothing
        Me.txtMessage.CustomButton.Location = New System.Drawing.Point(137, 2)
        Me.txtMessage.CustomButton.Name = ""
        Me.txtMessage.CustomButton.Size = New System.Drawing.Size(75, 75)
        Me.txtMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMessage.CustomButton.TabIndex = 1
        Me.txtMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMessage.CustomButton.UseSelectable = True
        Me.txtMessage.CustomButton.Visible = False
        Me.txtMessage.Lines = New String() {"Your QR-Code"}
        Me.txtMessage.Location = New System.Drawing.Point(174, 103)
        Me.txtMessage.MaxLength = 32767
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMessage.SelectedText = ""
        Me.txtMessage.SelectionLength = 0
        Me.txtMessage.SelectionStart = 0
        Me.txtMessage.Size = New System.Drawing.Size(215, 80)
        Me.txtMessage.TabIndex = 1
        Me.txtMessage.Text = "Your QR-Code"
        Me.txtMessage.UseSelectable = True
        Me.txtMessage.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMessage.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LineSeparator1
        '
        Me.LineSeparator1.Location = New System.Drawing.Point(13, 204)
        Me.LineSeparator1.MaximumSize = New System.Drawing.Size(2000, 2)
        Me.LineSeparator1.MinimumSize = New System.Drawing.Size(0, 2)
        Me.LineSeparator1.Name = "LineSeparator1"
        Me.LineSeparator1.Size = New System.Drawing.Size(383, 2)
        Me.LineSeparator1.TabIndex = 21
        '
        'EmailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(409, 263)
        Me.Controls.Add(Me.LineSeparator1)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtRecipiant)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmailForm"
        Me.Padding = New System.Windows.Forms.Padding(10, 60, 10, 10)
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "Send via E-Mail"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnOK As MetroFramework.Controls.MetroButton
    Friend WithEvents txtRecipiant As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMessage As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LineSeparator1 As LineSeparator
End Class
