Imports System.ComponentModel

Public Class myColorPicker

    Private _selectedColor As Color = Color.FromKnownColor(KnownColor.Control)
    Public Event ValueChanged(ByVal sender As Object, ByVal e As EventArgs)

    Public Sub New()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        Me.MinimumSize = New Size(pnlColor.Width + mbChooseColor.Width, pnlColor.Height)
    End Sub

    Private Sub ChooseColor(e As EventArgs)
        Dim colDlg As New ColorDialog
        colDlg.Color = _selectedColor
        Dim dr As DialogResult = colDlg.ShowDialog()

        If dr = DialogResult.OK Then
            Me.SelectedColor = colDlg.Color
            RaiseEvent ValueChanged(Me, e)
        End If
    End Sub

    Private Sub mbChooseColor_Click(sender As Object, e As EventArgs) Handles mbChooseColor.Click
        ChooseColor(e)
    End Sub

    Private Sub pnlColor_Click(sender As Object, e As EventArgs) Handles pnlColor.Click
        ChooseColor(e)
    End Sub

    Private Sub pnlColor_MouseHover(sender As Object, e As EventArgs) Handles pnlColor.MouseHover
        Me.pnlColor.BorderStyle = BorderStyle.FixedSingle
        Me.mbChooseColor.Focus()
    End Sub

    Private Sub pnlColor_MouseLeave(sender As Object, e As EventArgs) Handles pnlColor.MouseLeave
        Me.pnlColor.BorderStyle = BorderStyle.None
    End Sub

    Private Sub mbChooseColor_MouseHover(sender As Object, e As EventArgs) Handles mbChooseColor.MouseHover
        Me.mbChooseColor.Focus()
    End Sub

    <Browsable(True), EditorBrowsable(EditorBrowsableState.Always),
    Category("Appearance"),
    Description("Selected Color"),
    DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property SelectedColor As Color
        Get
            Return Me._selectedColor
        End Get
        Set(value As Color)
            Me._selectedColor = value
            pnlColor.BackColor = Me._selectedColor

            Me.Refresh()
        End Set
    End Property

End Class