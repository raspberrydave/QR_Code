Option Strict On
Option Explicit On

Imports System.IO
Imports System.Net


Public Class Network

    Public Function SendMail(ByVal recipient As String, ByVal message As String, ByVal attachment As String) As Integer
        Try
            Dim mapi As New MAPI()
            mapi.AddAttachment(attachment)
            mapi.AddRecipientTo(recipient)

            Dim exitCode As Integer = mapi.SendMailDirect("QR-Code", message)
            Return exitCode
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UploadFile(ByVal _FileName As String, ByVal _UploadPath As String, ByVal _FTPUser As String, ByVal _FTPPass As String) As Boolean

        ' Reset Progressbar
        'ProgressBar1.Value = 0

        _UploadPath = _UploadPath.Replace("\", "/")

        Dim _FileInfo As New FileInfo(_FileName)
        Dim _FtpWebRequest As FtpWebRequest = CType(FtpWebRequest.Create(New Uri(_UploadPath)), FtpWebRequest)

        _FtpWebRequest.Credentials = New NetworkCredential(_FTPUser, _FTPPass)
        _FtpWebRequest.KeepAlive = False

        _FtpWebRequest.Timeout = 20000
        _FtpWebRequest.Method = WebRequestMethods.Ftp.UploadFile
        _FtpWebRequest.UseBinary = True
        _FtpWebRequest.ContentLength = _FileInfo.Length

        ' The buffer size is set to 2kb
        Dim buffLength As Integer = 2048
        Dim buff(buffLength - 1) As Byte

        'ProgressBar1.Maximum = _FileInfo.Length
        'ProgressBar1.Step = buffLength

        Dim _FileStream As FileStream = _FileInfo.OpenRead()

        Try
            Dim _Stream As Stream = _FtpWebRequest.GetRequestStream()
            Dim contentLen As Integer = _FileStream.Read(buff, 0, buffLength)

            Do While contentLen <> 0
                _Stream.Write(buff, 0, contentLen)
                contentLen = _FileStream.Read(buff, 0, buffLength)

                'ProgressBar1.PerformStep()
            Loop

            ' Close the file stream and the Request Stream
            _Stream.Close()
            _Stream.Dispose()
            _FileStream.Close()
            _FileStream.Dispose()

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class