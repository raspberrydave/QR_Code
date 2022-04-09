<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myColorPicker
    Inherits MetroFramework.Controls.MetroUserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Me.mbChooseColor = New MetroFramework.Controls.MetroButton()
        Me.pnlColor = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'mbChooseColor
        '
        Me.mbChooseColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mbChooseColor.Dock = System.Windows.Forms.DockStyle.Right
        Me.mbChooseColor.Location = New System.Drawing.Point(78, 0)
        Me.mbChooseColor.Name = "mbChooseColor"
        Me.mbChooseColor.Size = New System.Drawing.Size(22, 20)
        Me.mbChooseColor.Style = MetroFramework.MetroColorStyle.Lime
        Me.mbChooseColor.TabIndex = 0
        Me.mbChooseColor.Text = "..."
        Me.mbChooseColor.UseSelectable = True
        '
        'pnlColor
        '
        Me.pnlColor.BackColor = System.Drawing.Color.White
        Me.pnlColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlColor.Location = New System.Drawing.Point(0, 0)
        Me.pnlColor.Name = "pnlColor"
        Me.pnlColor.Size = New System.Drawing.Size(78, 20)
        Me.pnlColor.TabIndex = 1
        '
        'myColorPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.pnlColor)
        Me.Controls.Add(Me.mbChooseColor)
        Me.Name = "myColorPicker"
        Me.Size = New System.Drawing.Size(100, 20)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mbChooseColor As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlColor As Panel
End Class
