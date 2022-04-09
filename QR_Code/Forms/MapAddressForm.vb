Option Strict On
Option Explicit On

Public Class MapAddressForm

    Private Sub MapAddressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sHelper = StyleHelper.Instance
        sHelper.ApplyTo(Me)

        CheckButtons()
    End Sub

    Public ReadOnly Property Keywords As String
        Get
            Return tbMapsSearch.Text
        End Get
    End Property

    Private Sub CheckButtons()
        btnSearch.Enabled = Not String.IsNullOrEmpty(tbMapsSearch.Text.Trim)
    End Sub

    Private Sub tbMapsSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMapsSearch.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter : btnSearch.PerformClick()
            Case Keys.Escape : btnCancel.PerformClick()
        End Select
    End Sub

    Private Sub tbMapsSearch_TextChanged(sender As Object, e As EventArgs) Handles tbMapsSearch.TextChanged
        CheckButtons()
    End Sub

End Class