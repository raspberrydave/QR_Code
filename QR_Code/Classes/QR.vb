Option Strict On
Option Explicit On

Imports System.Drawing.Imaging
Imports System.IO

Imports Gma.QrCodeNet.Encoding
Imports Gma.QrCodeNet.Encoding.Windows.Render

Public Class QR

    Private _qrImage As Image

    Private _content As String
    Private _pixel As Integer
    Private _imageSize As Integer
    Private _ecLevel As Integer
    Private _quietZone As Integer

    Private _colFront As Brush = Brushes.Black
    Private _colBack As Brush = Brushes.White

    Private _imgType As ImageFormat = ImageFormat.Png


    Public Sub New(ByVal content As String, ByVal pixel As Integer, ByVal imageSize As Integer, ByVal ecLevel As Integer, ByVal quietZone As Integer)
        Try
            Me._content = content
            Me._pixel = pixel
            Me._imageSize = imageSize
            Me._ecLevel = ecLevel
            Me._quietZone = quietZone * 2
            'Me._imgType = imgType

            Me.GenerateCode()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public ReadOnly Property QR_Image As Image
        Get
            Return Me._qrImage
        End Get
    End Property

    Public Property CorrectionLevel As Integer
        Get
            Return _ecLevel
        End Get
        Set(value As Integer)
            _ecLevel = value
            GenerateCode()
        End Set
    End Property

    Public Property QuietZone As Integer
        Get
            Return _quietZone
        End Get
        Set(value As Integer)
            _quietZone = value
            GenerateCode()
        End Set
    End Property

    Public Property FrontColor As SolidBrush
        Get
            Return CType(Me._colFront, SolidBrush)
        End Get
        Set(value As SolidBrush)
            Me._colFront = value
            GenerateCode()
        End Set
    End Property

    Public Property BackColor As SolidBrush
        Get
            Return CType(Me._colBack, SolidBrush)
        End Get
        Set(value As SolidBrush)
            Me._colBack = value
            GenerateCode()
        End Set
    End Property

    Public Property ImageType As ImageFormat
        Get
            Return Me._imgType
        End Get
        Set(value As ImageFormat)
            Me._imgType = value
            GenerateCode()
        End Set
    End Property

    Private Sub GenerateCode()
        Try
            If Not String.IsNullOrEmpty(_content) Then
                Dim corrLevel As ErrorCorrectionLevel = CType(_ecLevel, ErrorCorrectionLevel)
                Dim qZone As QuietZoneModules = CType(_quietZone, QuietZoneModules)

                Dim encoder As New QrEncoder(corrLevel)
                Dim qrCode As QrCode = encoder.Encode(_content)
                Dim renderer As New GraphicsRenderer(New FixedCodeSize(_pixel, qZone), _colFront, _colBack)

                Using ms As New MemoryStream
                    renderer.WriteToStream(qrCode.Matrix, _imgType, ms)

                    Dim imageTemp As New Bitmap(ms)
                    Dim padding As Integer = CInt(_imageSize / 2)

                    _qrImage = New Bitmap(imageTemp, New Size(New Point(padding, padding)))
                End Using
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class