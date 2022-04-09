Option Strict On
Option Explicit On

Public Class AboutForm

    Public Sub New()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
    End Sub

    Private Sub mQrNetLink_Click(sender As Object, e As EventArgs) Handles mQrNetLink.Click
        Process.Start(mQrNetLink.Text)
    End Sub

    Private Sub mMetroLink_Click(sender As Object, e As EventArgs) Handles mMetroLink.Click
        Process.Start(mMetroLink.Text)
    End Sub

    Private Sub mGmapsLink_Click(sender As Object, e As EventArgs) Handles mGmapsLink.Click
        Process.Start(mGmapsLink.Text)
    End Sub

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sHelper = StyleHelper.Instance
        sHelper.ApplyTo(Me)
    End Sub

    Private Sub mllRaspberryDave_Click(sender As Object, e As EventArgs) Handles mllRaspberryDave.Click
        Process.Start("http://raspberrydave.ddns.net")
    End Sub
End Class