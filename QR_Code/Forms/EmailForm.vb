Option Strict On
Option Explicit On


Public Class EmailForm

    Public Sub New()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
    End Sub

    Private Sub CheckButtons()
        btnOK.Enabled = RegexHelper.IsValidEmail(txtRecipiant.Text)
    End Sub

    Private Sub EmailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CheckButtons()

            Dim sHelper = StyleHelper.Instance
            sHelper.ApplyTo(Me)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txtRecipiant_TextChanged(sender As Object, e As EventArgs) Handles txtRecipiant.TextChanged
        CheckButtons()
    End Sub

    Public ReadOnly Property Recipiant As String
        Get
            Return txtRecipiant.Text
        End Get
    End Property

    Public ReadOnly Property Message As String
        Get
            Return txtMessage.Text
        End Get
    End Property

End Class