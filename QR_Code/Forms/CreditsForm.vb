Option Strict On
Option Explicit On

Imports System.Media

Public Class CreditsForm

    'Private player As SoundPlayer

    Public Sub New()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        AddCloseHandler(Me)
        Me.Height = 390

        Timer1.Interval = 20
    End Sub

    Private Sub CreditsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Play()
    End Sub

    Private Sub AddCloseHandler(ByVal ctrl As Control)
        AddHandler ctrl.Click, AddressOf CloseMe
        For Each control As Control In ctrl.Controls
            AddCloseHandler(control)
        Next
    End Sub

    Private Sub Play()
        Panel1.Location = New Point(Panel1.Location.X, Me.Height)

        If Not Timer1.Enabled Then
            Timer1.Enabled = True
        End If

        'player = New SoundPlayer(My.Resources.dexter)
        'player.Play()
    End Sub

    Private Sub CloseMe(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel1.Location = New Point(Panel1.Location.X, Panel1.Location.Y - 1)
        Refresh()

        If (Panel1.Location.Y + Panel1.Height) <= -10 Then
            Play()
        End If
    End Sub

    Private Sub CreditsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'player.Stop()
    End Sub

End Class