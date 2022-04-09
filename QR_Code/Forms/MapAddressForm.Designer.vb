<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapAddressForm
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
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnSearch = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tbMapsSearch = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(172, 103)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseSelectable = True
        '
        'btnSearch
        '
        Me.btnSearch.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSearch.Location = New System.Drawing.Point(253, 103)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(13, 25)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(128, 19)
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "Search by Keywords:"
        '
        'tbMapsSearch
        '
        '
        '
        '
        Me.tbMapsSearch.CustomButton.Image = Nothing
        Me.tbMapsSearch.CustomButton.Location = New System.Drawing.Point(281, 1)
        Me.tbMapsSearch.CustomButton.Name = ""
        Me.tbMapsSearch.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.tbMapsSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbMapsSearch.CustomButton.TabIndex = 1
        Me.tbMapsSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbMapsSearch.CustomButton.UseSelectable = True
        Me.tbMapsSearch.CustomButton.Visible = False
        Me.tbMapsSearch.DisplayIcon = True
        Me.tbMapsSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbMapsSearch.Icon = Global.QR_Code.My.Resources.Resources.search_lookup_glyph_24
        Me.tbMapsSearch.Lines = New String(-1) {}
        Me.tbMapsSearch.Location = New System.Drawing.Point(13, 47)
        Me.tbMapsSearch.MaxLength = 32767
        Me.tbMapsSearch.Name = "tbMapsSearch"
        Me.tbMapsSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbMapsSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbMapsSearch.SelectedText = ""
        Me.tbMapsSearch.SelectionLength = 0
        Me.tbMapsSearch.SelectionStart = 0
        Me.tbMapsSearch.Size = New System.Drawing.Size(315, 35)
        Me.tbMapsSearch.TabIndex = 3
        Me.tbMapsSearch.UseSelectable = True
        Me.tbMapsSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbMapsSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MapAddressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(339, 142)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.tbMapsSearch)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MapAddressForm"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents tbMapsSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
