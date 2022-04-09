Option Explicit On
Option Strict On

Imports System.IO
Imports System.Xml

Public NotInheritable Class Config

    Private Shared _instance As Config
    Private Shared ReadOnly _mutex As New Object

    Private virtualConfig As XmlDocument
    Private physicalConfig As FileInfo

    Private Sub New()
        Try
            virtualConfig = New XmlDocument()
            physicalConfig = New FileInfo(Path.Combine(Application.StartupPath, "config.cfg"))

            ' Default Configuration
            Me.ImageSize = 500
            Me.PixelSize = 400
            Me.CorrectionLevel = 3
            Me.QuietZone = 0
            Me.SSID = ""
            Me.WifiPwd = ""
            Me.WifiHidden = False
            Me.Encryption = 2
            Me.SaveWifiSettings = False
            Me.StyleID = 6
            Me.ThemeID = 0

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Singleton
    ''' </summary>
    ''' <returns>Instance of Config Class</returns>
    Public Shared ReadOnly Property Instance As Config
        Get
            SyncLock _mutex
                If _instance Is Nothing Then
                    _instance = New Config
                End If
            End SyncLock
            Return _instance
        End Get
    End Property


    Private Sub CheckIntegrity(ByVal sectionName As String, ByVal nodeName As String)
        Try
            Dim cfgRoot As XmlElement = virtualConfig.DocumentElement

            Select Case sectionName

                Case "QR"
                    Dim cfgQR As XmlNode = virtualConfig.SelectSingleNode("//QR")
                    If cfgQR Is Nothing Then
                        cfgQR = virtualConfig.CreateElement("QR")
                        cfgRoot.AppendChild(cfgQR)
                    End If
                    Dim key As XmlElement = cfgQR.Item(nodeName)

                    If key Is Nothing Then
                        Select Case nodeName
                            Case "ImageSize"
                                Dim keyImageSize As XmlElement = virtualConfig.CreateElement("ImageSize")
                                keyImageSize.InnerText = Me.ImageSize.ToString
                                cfgQR.AppendChild(keyImageSize)
                            Case "PixelSize"
                                Dim keyPixelSize As XmlElement = virtualConfig.CreateElement("PixelSize")
                                keyPixelSize.InnerText = Me.PixelSize.ToString
                                cfgQR.AppendChild(keyPixelSize)
                            Case "CorrectionLevel"
                                Dim keyCorrectionLevel As XmlElement = virtualConfig.CreateElement("CorrectionLevel")
                                keyCorrectionLevel.InnerText = Me.CorrectionLevel.ToString
                                cfgQR.AppendChild(keyCorrectionLevel)
                            Case "QuietZone"
                                Dim keyQuietZone As XmlElement = virtualConfig.CreateElement("QuietZone")
                                keyQuietZone.InnerText = Me.QuietZone.ToString
                                cfgQR.AppendChild(keyQuietZone)
                        End Select
                        Save()
                    End If

                Case "Wifi"
                    Dim cfgWifi As XmlNode = virtualConfig.SelectSingleNode("//Wifi")
                    If cfgWifi Is Nothing Then
                        cfgWifi = virtualConfig.CreateElement("Wifi")
                        cfgRoot.AppendChild(cfgWifi)
                    End If
                    Dim key As XmlElement = cfgWifi.Item(nodeName)

                    If key Is Nothing Then
                        Select Case nodeName
                            Case "SSID"
                                Dim keySSID As XmlElement = virtualConfig.CreateElement("SSID")
                                keySSID.InnerText = Me.SSID
                                cfgWifi.AppendChild(keySSID)
                            Case "WifiPwd"
                                Dim keyWifiPwd As XmlElement = virtualConfig.CreateElement("WifiPwd")
                                keyWifiPwd.InnerText = Me.WifiPwd
                                cfgWifi.AppendChild(keyWifiPwd)
                            Case "WifiHidden"
                                Dim keyWifiHidden As XmlElement = virtualConfig.CreateElement("WifiHidden")
                                keyWifiHidden.InnerText = Me.WifiHidden.ToString
                                cfgWifi.AppendChild(keyWifiHidden)
                            Case "Encryption"
                                Dim keyEncryption As XmlElement = virtualConfig.CreateElement("Encryption")
                                keyEncryption.InnerText = Me.Encryption.ToString
                                cfgWifi.AppendChild(keyEncryption)
                            Case "SaveWifiSettings"
                                Dim keySaveWifiSettings As XmlElement = virtualConfig.CreateElement("SaveWifiSettings")
                                keySaveWifiSettings.InnerText = Me.SaveWifiSettings.ToString
                                cfgWifi.AppendChild(keySaveWifiSettings)
                        End Select
                        Save()
                    End If

                Case "Appearance"
                    Dim cfgAppearance As XmlNode = virtualConfig.SelectSingleNode("//Appearance")
                    If cfgAppearance Is Nothing Then
                        cfgAppearance = virtualConfig.CreateElement("Appearance")
                        cfgRoot.AppendChild(cfgAppearance)
                    End If
                    Dim key As XmlElement = cfgAppearance.Item(nodeName)

                    If key Is Nothing Then
                        Select Case nodeName
                            Case "Style"
                                Dim keyStyle As XmlElement = virtualConfig.CreateElement("Style")
                                keyStyle.InnerText = Me.StyleID.ToString
                                cfgAppearance.AppendChild(keyStyle)
                            Case "Theme"
                                Dim keyTheme As XmlElement = virtualConfig.CreateElement("Theme")
                                keyTheme.InnerText = Me.ThemeID.ToString
                                cfgAppearance.AppendChild(keyTheme)
                        End Select
                        Save()
                    End If

            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub CreateNewConfigFile()
        Try
            virtualConfig = New XmlDocument()

            Dim cfgRoot As XmlElement = virtualConfig.CreateElement("Configuration")
            virtualConfig.AppendChild(cfgRoot)

#Region "QR"
            Dim cfgQR As XmlElement = virtualConfig.CreateElement("QR")
            cfgRoot.AppendChild(cfgQR)

            Dim keyImageSize As XmlElement = virtualConfig.CreateElement("ImageSize")
            keyImageSize.InnerText = Me.ImageSize.ToString
            cfgQR.AppendChild(keyImageSize)

            Dim keyPixelSize As XmlElement = virtualConfig.CreateElement("PixelSize")
            keyPixelSize.InnerText = Me.PixelSize.ToString
            cfgQR.AppendChild(keyPixelSize)

            Dim keyCorrectionLevel As XmlElement = virtualConfig.CreateElement("CorrectionLevel")
            keyCorrectionLevel.InnerText = Me.CorrectionLevel.ToString
            cfgQR.AppendChild(keyCorrectionLevel)

            Dim keyQuietZone As XmlElement = virtualConfig.CreateElement("QuietZone")
            keyQuietZone.InnerText = Me.QuietZone.ToString
            cfgQR.AppendChild(keyQuietZone)
#End Region

#Region "Wifi"
            Dim cfgWifi As XmlElement = virtualConfig.CreateElement("Wifi")
            cfgRoot.AppendChild(cfgWifi)

            Dim keySSID As XmlElement = virtualConfig.CreateElement("SSID")
            keySSID.InnerText = Me.SSID
            cfgWifi.AppendChild(keySSID)

            Dim keyWifiPwd As XmlElement = virtualConfig.CreateElement("WifiPwd")
            keyWifiPwd.InnerText = Me.WifiPwd
            cfgWifi.AppendChild(keyWifiPwd)

            Dim keyWifiHidden As XmlElement = virtualConfig.CreateElement("WifiHidden")
            keyWifiHidden.InnerText = Me.WifiHidden.ToString
            cfgWifi.AppendChild(keyWifiHidden)

            Dim keyEncryption As XmlElement = virtualConfig.CreateElement("Encryption")
            keyEncryption.InnerText = Me.Encryption.ToString
            cfgWifi.AppendChild(keyEncryption)

            Dim keySaveWifiSettings As XmlElement = virtualConfig.CreateElement("SaveWifiSettings")
            keySaveWifiSettings.InnerText = Me.SaveWifiSettings.ToString
            cfgWifi.AppendChild(keySaveWifiSettings)
#End Region

#Region "Appearance"
            Dim cfgAppearance As XmlElement = virtualConfig.CreateElement("Appearance")
            cfgRoot.AppendChild(cfgAppearance)

            Dim keyStyle As XmlElement = virtualConfig.CreateElement("Style")
            keyStyle.InnerText = Me.StyleID.ToString
            cfgAppearance.AppendChild(keyStyle)

            Dim keyTheme As XmlElement = virtualConfig.CreateElement("Theme")
            keyTheme.InnerText = Me.ThemeID.ToString
            cfgAppearance.AppendChild(keyTheme)
#End Region

            virtualConfig.Save(physicalConfig.FullName)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Load()
        Try
            virtualConfig.Load(physicalConfig.FullName)

            CheckIntegrity("QR", "ImageSize")
            CheckIntegrity("QR", "PixelSize")
            CheckIntegrity("QR", "CorrectionLevel")
            CheckIntegrity("QR", "QuietZone")
            CheckIntegrity("Wifi", "SSID")
            CheckIntegrity("Wifi", "WifiPwd")
            CheckIntegrity("Wifi", "WifiHidden")
            CheckIntegrity("Wifi", "Encryption")
            CheckIntegrity("Wifi", "SaveWifiSettings")
            CheckIntegrity("Appearance", "Style")
            CheckIntegrity("Appearance", "Theme")


            Dim cfgList As XmlNodeList = virtualConfig.SelectNodes("//QR/*")
            For Each key As XmlNode In cfgList
                Select Case key.Name
                    Case "ImageSize" : Me.ImageSize = Decimal.Parse(key.InnerText)
                    Case "PixelSize" : Me.PixelSize = Decimal.Parse(key.InnerText)
                    Case "CorrectionLevel" : Me.CorrectionLevel = Integer.Parse(key.InnerText)
                    Case "QuietZone" : Me.QuietZone = Integer.Parse(key.InnerText)
                End Select
            Next

            Dim wifiList As XmlNodeList = virtualConfig.SelectNodes("//Wifi/*")
            For Each key As XmlNode In wifiList
                Select Case key.Name
                    Case "SSID" : Me.SSID = key.InnerText
                    Case "WifiPwd" : Me.WifiPwd = key.InnerText
                    Case "WifiHidden" : Me.WifiHidden = Boolean.Parse(key.InnerText)
                    Case "Encryption" : Me.Encryption = Integer.Parse(key.InnerText)
                    Case "SaveWifiSettings" : Me.SaveWifiSettings = Boolean.Parse(key.InnerText)
                End Select
            Next

            Dim appearanceList As XmlNodeList = virtualConfig.SelectNodes("//Appearance/*")
            For Each key As XmlNode In appearanceList
                Select Case key.Name
                    Case "Style" : Me.StyleID = Integer.Parse(key.InnerText)
                    Case "Theme" : Me.ThemeID = Integer.Parse(key.InnerText)
                End Select
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Save()
        Try
            Dim cfgList As XmlNodeList = virtualConfig.SelectNodes("//QR/*")
            For Each key As XmlNode In cfgList
                Select Case key.Name
                    Case "ImageSize" : key.InnerText = Me.ImageSize.ToString
                    Case "PixelSize" : key.InnerText = Me.PixelSize.ToString
                    Case "CorrectionLevel" : key.InnerText = Me.CorrectionLevel.ToString
                    Case "QuietZone" : key.InnerText = Me.QuietZone.ToString
                End Select
            Next

            Dim wifiList As XmlNodeList = virtualConfig.SelectNodes("//Wifi/*")
            For Each key As XmlNode In wifiList
                Select Case key.Name
                    Case "SSID" : key.InnerText = Me.SSID
                    Case "WifiPwd" : key.InnerText = Me.WifiPwd
                    Case "WifiHidden" : key.InnerText = Me.WifiHidden.ToString
                    Case "Encryption" : key.InnerText = Me.Encryption.ToString
                    Case "SaveWifiSettings" : key.InnerText = Me.SaveWifiSettings.ToString
                End Select
            Next

            Dim appearanceList As XmlNodeList = virtualConfig.SelectNodes("//Appearance/*")
            For Each key As XmlNode In appearanceList
                Select Case key.Name
                    Case "Style" : key.InnerText = Me.StyleID.ToString
                    Case "Theme" : key.InnerText = Me.ThemeID.ToString
                End Select
            Next

            virtualConfig.Save(physicalConfig.FullName)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Property ImageSize As Decimal

    Public Property PixelSize As Decimal

    Public Property CorrectionLevel As Integer

    Public Property QuietZone As Integer

    Public Property SSID As String

    Public Property WifiPwd As String

    Public Property WifiHidden As Boolean

    Public Property Encryption As Integer

    Public Property SaveWifiSettings As Boolean

    Public Property StyleID As Integer

    Public Property ThemeID As Integer

    Public ReadOnly Property Exists As Boolean
        Get
            Return File.Exists(physicalConfig.FullName)
        End Get
    End Property

End Class