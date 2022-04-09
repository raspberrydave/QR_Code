Option Strict On
Option Explicit On

Imports System.IO
Imports System.Runtime.Serialization.Json
Imports System.Net

Public Class FacebookForm

    Dim _image As Image

    Dim myFriendList As New FriendList

    Private Const AppId As String = ""
    Private Const ExtendedPermissions As String = "publish_actions"

    'Private Const AppSecretId As String = "c62e83d720dff604af80baa8703498f2"
    Private accessToken As String = String.Empty
    Private success As Boolean = False

    Public Sub New(ByVal img As Image)
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Dim bmp As New Bitmap(img, New Size(200, 200))
        Me._image = bmp
    End Sub

    Private Sub FacebookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sHelper = StyleHelper.Instance
            sHelper.ApplyTo(Me)

            pbImage.Image = _image

            Dim fbLogin As String = GenerateLoginUrl()
            WebBrowser1.Navigate(fbLogin)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        Try
            Dim url As String = WebBrowser1.Url.ToString()

            If url.Contains("#access_token=") Then
                url = url.Substring(url.IndexOf("access_token=") + 13)

                Me.accessToken = url.Substring(0, url.IndexOf("&"))
                txtAccessToken.Text = accessToken

                LoadFriends()
            End If

            If url.EndsWith("user_denied#_=_") Then
                Close()
            ElseIf url.Contains("expires_in") Then
                Me.success = True

                pnlBrowser.Visible = False
                MetroPanel1.Visible = True
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GenerateLoginUrl() As String
        Try
            Dim url As String = "https://graph.facebook.com/oauth/authorize?"
            url += "client_id=" & AppId
            url += "&scope=" & ExtendedPermissions
            url += "&redirect_uri=http://www.facebook.com/connect/login_success.html"
            url += "&type=user_agent"
            url += "&display=popup"

            Return url
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub LoadFriends()
        Try
            cmbFriends.Items.Clear()

            Dim answer As Byte()
            Dim myWebClient As New WebClient

            Try
                answer = myWebClient.DownloadData("https://graph.facebook.com/me/friends?access_token=" & accessToken)
                'MessageBox.Show("Freundeliste geladen!")
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error loading friendlist...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            'JSON-Antwort deserialisieren
            Dim ser As New DataContractJsonSerializer(GetType(FriendList))
            Dim ms As New MemoryStream(answer)
            myFriendList = TryCast(ser.ReadObject(ms), FriendList)

            cmbFriends.Items.Add("me")
            For i = 0 To myFriendList.Friend.Length - 1
                cmbFriends.Items.Add(myFriendList.Friend(i).name & " (ID: " & myFriendList.Friend(i).id & ")")
            Next i
            cmbFriends.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mlClose_Click(sender As Object, e As EventArgs) Handles mlClose.Click
        Close()
    End Sub

    Private Sub mlUpload_Click(sender As Object, e As EventArgs) Handles mlUpload.Click
        If String.IsNullOrEmpty(Me.accessToken) Then
            MetroFramework.MetroMessageBox.Show(Me, "No Access-Token", "Error: Access-Token could not be generated", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            mlUpload.Enabled = False

            Dim answer As Byte()
            Dim urlParam As String = String.Empty

            'Dim graphURL As String = "https://graph.facebook.com/me/feed"
            Dim graphUrl As String = "https://graph.facebook.com/me/photos"
            If cmbFriends.Text <> "me" Then
                'graphURL = "https://graph.facebook.com/" & myFriendList.Friend(cmbFriends.SelectedIndex - 1).id & "/feed"
                graphUrl = "https://graph.facebook.com/" & myFriendList.Friend(cmbFriends.SelectedIndex - 1).id & "/photos"
            End If

            Dim myWebClient As New WebClient
            ServicePointManager.Expect100Continue = False

            Dim tmpPath As String = Path.Combine(Path.GetTempPath(), Guid.NewGuid.ToString & ".png")
            pbImage.Image.Save(tmpPath)

            urlParam = "?message=" & txtStatusUpdate.Text & "&access_token=" & accessToken

            Try
                'answer = myWebClient.UploadData(graphURL, message)
                answer = myWebClient.UploadFile(graphUrl & urlParam, "POST", tmpPath)

                MetroFramework.MetroMessageBox.Show(Me, "Successfully posted!")
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If File.Exists(tmpPath) Then
                    File.Delete(tmpPath)
                End If

                Close()
            End Try
        End If
    End Sub

End Class