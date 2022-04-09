Option Strict On
Option Explicit On

Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.IO
Imports System.Text

Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers

Public Class MainForm

    Private qr As QR

    Private dictCountries As New Dictionary(Of String, String)()

    Private ReadOnly overlay As New GMapOverlay
    Private currentMarker As GMapMarker
    Private isMouseDown As Boolean = False

    Private mttQuietZone As New ToolTip()
    Private mttCorrLevel As New ToolTip()

    Private hitinfo As ListViewHitTestInfo
    Private editbox As New TextBox
    'Private editbox As New MetroFramework.Controls.MetroTextBox


    Public Sub New()
        Try
            ' Dieser Aufruf ist für den Designer erforderlich.
            InitializeComponent()

            ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
            Dim config As Config = Config.Instance
            If Not config.Exists Then
                config.CreateNewConfigFile()
            End If
            config.Load()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToggleOptionsPanel()
        Try
            If pnlOptions.Visible Then
                pnlOptions.Visible = False
                Me.Size = New Size(Me.Width - pnlOptions.Width, Me.Height)
            Else
                Me.Size = New Size(Me.Width + pnlOptions.Width, Me.Height)
                pnlOptions.Visible = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MetroTabControl1.SelectedIndex = 0
            cbFormat.SelectedIndex = 0
            dtStartTime.Text = Date.Now.ToShortTimeString

            cmbStyle.DataSource = [Enum].GetValues(GetType(MetroFramework.MetroColorStyle))
            cmbTheme.DataSource = [Enum].GetValues(GetType(MetroFramework.MetroThemeStyle))

            LoadSettings()

            InitPhoneBook()
            InitInputFields()
            InitGmaps()
            InitToolTips()

            ToggleOptionsPanel()
            SetMetroStyle()
            GetPhoneBookEntries()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetMetroStyle()
        Try
            Dim style As MetroFramework.MetroColorStyle = CType(cmbStyle.SelectedIndex, MetroFramework.MetroColorStyle)
            Dim theme As MetroFramework.MetroThemeStyle = CType(cmbTheme.SelectedIndex, MetroFramework.MetroThemeStyle)

            '''''Dim sManager As MetroFramework.Components.MetroStyleManager
            '''''If Me.StyleManager Is Nothing Then
            '''''    sManager = New MetroFramework.Components.MetroStyleManager
            '''''    Me.StyleManager = sManager
            '''''    sManager.Owner = Me
            '''''Else
            '''''    sManager = Me.StyleManager
            '''''End If
            '''''sManager.Style = style
            '''''sManager.Theme = theme

            Dim sHelper = StyleHelper.Instance
            sHelper.Style = style
            sHelper.Theme = theme
            sHelper.ApplyTo(Me)

            Me.Refresh()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InitPhoneBook()
        Try
            lvPhoneBook.OwnerDraw = True

            AddHandler lvPhoneBook.SelectedIndexChanged, AddressOf lvPhoneBook_SelectedIndexChanged
            AddHandler lvPhoneBook.MouseClick, AddressOf lvPhoneBook_MouseClick
            AddHandler lvPhoneBook.MouseDoubleClick, AddressOf lvPhoneBook_MouseDoubleClick
            AddHandler lvPhoneBook.KeyDown, AddressOf lvPhoneBook_KeyDown

            AddHandler lvPhoneBook.DrawColumnHeader, AddressOf lvPhoneBook_DrawColumnHeader
            AddHandler lvPhoneBook.DrawItem, AddressOf lvPhoneBook_DrawItem
            AddHandler lvPhoneBook.DrawSubItem, AddressOf lvPhoneBook_DrawSubItem

            editbox.Parent = lvPhoneBook
            editbox.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
            editbox.Hide()

            AddHandler editbox.KeyPress, AddressOf editbox_KeyPress
            AddHandler editbox.LostFocus, AddressOf editbox_LostFocus

            Dim offset As Integer = 50
            colName.Width = CInt(lvPhoneBook.Width / 2) - offset
            colPhoneNumber.Width = CInt(lvPhoneBook.Width / 2) + (offset - SystemInformation.VerticalScrollBarWidth) - 1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InitToolTips()
        Try
            mttCorrLevel.ToolTipIcon = ToolTipIcon.Info
            mttCorrLevel.IsBalloon = True
            mttCorrLevel.ToolTipTitle = "Correction level"
            mttCorrLevel.SetToolTip(lblCorrLevel, "Improves how the QR code will be decoded In difficult conditions" & Environment.NewLine &
                               "(damaged QR code, far capture distance, low light...).Higher correction levels also increase the QR code size.")

            mttQuietZone.ToolTipIcon = ToolTipIcon.Info
            mttQuietZone.IsBalloon = True
            mttQuietZone.ToolTipTitle = "Quiet zone"
            mttQuietZone.SetToolTip(lblQuietZone, "The quiet zone Is a blank area surrounding the QR code" & Environment.NewLine &
                               "improving decoding by helping separate the actual code from other content.")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub FocusControls()
        Try
            Select Case MetroTabControl1.SelectedTab.Name
                Case "tabFree"
                    txtFreeText.Focus()
                    txtFreeText.SelectionStart = txtFreeText.Text.Length
                Case "tabURL"
                    txtURL.Focus()
                    txtURL.SelectionStart = txtURL.Text.Length
                Case "tabvCard"
                    txtvGivenName.Focus()
                    txtvGivenName.SelectionStart = txtvGivenName.Text.Length
                Case "tabPhone"
                    txtPhoneNumber.Focus()
                    txtPhoneNumber.SelectionStart = txtPhoneNumber.Text.Length
                Case "tabEmail"
                    txtRecipient.Focus()
                    txtRecipient.SelectionStart = txtRecipient.Text.Length
                Case "tabSMS"
                    txtSMSTO.Focus()
                    txtSMSTO.SelectionStart = txtSMSTO.Text.Length
                Case "tabWIFI"
                    txtSSID.Focus()
                    txtSSID.SelectionStart = txtSSID.Text.Length
                Case "tabEvent"
                    txtEventName.Focus()
                    txtEventName.SelectionStart = txtEventName.Text.Length
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InitInputFields()
        Try
            For intDays As Integer = 1 To 31
                chkvDay.Items.Add(intDays)
            Next
            For intMonths As Integer = 1 To 12
                chkvMonth.Items.Add(intMonths)
            Next
            For intYears As Integer = 1920 To DateTime.Now.Year
                chkvYear.Items.Add(intYears)
            Next

            For Each cultureInfo As CultureInfo In CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                Dim regionInfo As New RegionInfo(cultureInfo.Name)
                If Not dictCountries.ContainsKey(regionInfo.DisplayName) Then
                    dictCountries.Add(regionInfo.DisplayName, regionInfo.TwoLetterISORegionName.ToLower())
                End If
            Next

            Dim obj = dictCountries.OrderBy(Function(p) p.Key)
            For Each val As KeyValuePair(Of String, String) In obj
                cmbvCountryPrivate.Items.Add(val.Key)
                cmbvCountryWork.Items.Add(val.Key)

                Dim tsiCountry As ToolStripItem = GoToToolStripMenuItem.DropDownItems.Add(val.Key)
                AddHandler tsiCountry.Click, AddressOf tsiCountry_Click
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub tsiCountry_Click(sender As Object, e As EventArgs)
        Try
            Dim tsi As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)

            If tsi IsNot Nothing Then
                Dim code As GeoCoderStatusCode = Maps_GoTo(tsi.Text)
                If code = GeoCoderStatusCode.G_GEO_SUCCESS Then
                    currentMarker.Position = GMapControl1.Position
                    GMapControl1.Zoom = 4
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Function GeneratevCardString() As String
        Try
            If String.IsNullOrEmpty(txtvGivenName.Text) Or String.IsNullOrEmpty(txtvFamilyName.Text) Then
                MetroFramework.MetroMessageBox.Show(Me, "FirstName and LastName are mandatory", "vCard", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim vCardBuilder As New StringBuilder

                vCardBuilder.AppendLine("BEGIN:VCARD")
                vCardBuilder.AppendLine("VERSION:3.0")

                vCardBuilder.AppendLine(String.Format("N:{0};{1}", txtvFamilyName.Text, txtvGivenName.Text))
                vCardBuilder.AppendLine(String.Format("FN:{0} {1}", txtvGivenName.Text, txtvFamilyName.Text))

                If Not String.IsNullOrEmpty(txtvTitle.Text) Then vCardBuilder.AppendLine(String.Format("TITLE:{0}", txtvTitle.Text))
                If Not String.IsNullOrEmpty(txtvOrganisation.Text) Then vCardBuilder.AppendLine(String.Format("ORG:{0}", txtvOrganisation.Text))
                If Not String.IsNullOrEmpty(txtvWebsiteWork.Text) Then vCardBuilder.AppendLine(String.Format("URL;type=WORK:{0}", txtvWebsiteWork.Text))
                If Not String.IsNullOrEmpty(txtvWebsitePrivate.Text) Then vCardBuilder.AppendLine(String.Format("URL;type=HOME:{0}", txtvWebsitePrivate.Text))
                If Not String.IsNullOrEmpty(txtvTelWork.Text) Then vCardBuilder.AppendLine(String.Format("TEL;TYPE=WORK:{0}", txtvTelWork.Text))
                If Not String.IsNullOrEmpty(txtvTelPrivate.Text) Then vCardBuilder.AppendLine(String.Format("TEL;TYPE=HOME:{0}", txtvTelPrivate.Text))
                If Not String.IsNullOrEmpty(txtvCellphonePrivate.Text) Then vCardBuilder.AppendLine(String.Format("TEL;TYPE=CELL:{0}", txtvCellphonePrivate.Text))
                If Not String.IsNullOrEmpty(txtvFaxWork.Text) Then vCardBuilder.AppendLine(String.Format("TEL;type=FAX;type=WORK:{0}", txtvFaxWork.Text))
                If Not String.IsNullOrEmpty(txtvFaxPrivate.Text) Then vCardBuilder.AppendLine(String.Format("TEL;type=FAX;type=HOME:{0}", txtvFaxPrivate.Text))
                If Not String.IsNullOrEmpty(txtvEmailWork.Text) Then vCardBuilder.AppendLine(String.Format("EMAIL;type=INTERNET;type=WORK:{0}", txtvEmailWork.Text))
                If Not String.IsNullOrEmpty(txtvEmailPrivate.Text) Then vCardBuilder.AppendLine(String.Format("EMAIL;type=INTERNET;type=HOME:{0}", txtvEmailPrivate.Text))

                If Not String.IsNullOrEmpty(txtvStreetWork.Text) AndAlso Not String.IsNullOrEmpty(txtvCityWork.Text) AndAlso Not String.IsNullOrEmpty(txtvPostalWork.Text) AndAlso Not String.IsNullOrEmpty(cmbvCountryWork.SelectedItem.ToString()) Then
                    vCardBuilder.AppendLine(String.Format("ADR;type=WORK:;;{0};{1};;{2};{3}", txtvStreetWork.Text, txtvCityWork.Text, txtvPostalWork.Text, cmbvCountryWork.SelectedItem.ToString()))
                End If

                If Not String.IsNullOrEmpty(txtvStreetPrivate.Text) AndAlso Not String.IsNullOrEmpty(txtvCityPrivate.Text) AndAlso Not String.IsNullOrEmpty(txtvPostalPrivate.Text) AndAlso Not String.IsNullOrEmpty(cmbvCountryPrivate.SelectedItem.ToString()) Then
                    vCardBuilder.AppendLine(String.Format("ADR;type=HOME:;;{0};{1};;{2};{3}", txtvStreetPrivate.Text, txtvCityPrivate.Text, txtvPostalPrivate.Text, cmbvCountryPrivate.SelectedItem.ToString()))
                End If

                If chkvYear.SelectedItem IsNot Nothing AndAlso chkvMonth.SelectedItem IsNot Nothing AndAlso chkvDay.SelectedItem IsNot Nothing Then
                    vCardBuilder.AppendLine(String.Format("BDAY;value=DATE:{0}-{1}-{2}", chkvYear.SelectedItem.ToString(), chkvMonth.SelectedItem.ToString(), chkvDay.SelectedItem.ToString()))
                End If

                vCardBuilder.AppendLine("END:VCARD")

                Return vCardBuilder.ToString
            End If
            Return String.Empty
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GenerateWifiString() As String
        Try
            If String.IsNullOrEmpty(txtSSID.Text) Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter your SSID", "WIFI", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim wifiBuilder As New StringBuilder
                wifiBuilder.Append("WIFI:")

                wifiBuilder.Append("T:")
                If rbWEP.Checked Then
                    wifiBuilder.Append("WEP;")
                ElseIf rbWPA.Checked Then
                    wifiBuilder.Append("WPA;")
                ElseIf rbNoEncryption.Checked Then
                    wifiBuilder.Append("nopass;")
                End If

                wifiBuilder.Append(String.Format("S:{0};", txtSSID.Text))

                If Not rbNoEncryption.Checked Then
                    wifiBuilder.Append(String.Format("P:{0};", txtWIFIPwd.Text))
                Else
                    wifiBuilder.Append("P:;")
                End If

                If cbHiddenSSID.Checked Then
                    wifiBuilder.Append("H:true")
                End If

                wifiBuilder.Append(";")

                Return wifiBuilder.ToString
            End If
            Return String.Empty
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GenerateVEventString() As String
        Try
            If String.IsNullOrEmpty(txtEventName.Text) Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter Event-Name", "Event", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim eventBuilder As New StringBuilder

                eventBuilder.AppendLine("BEGIN:VEVENT")
                eventBuilder.AppendLine(String.Format("SUMMARY:{0}", txtEventName.Text))
                eventBuilder.AppendLine(String.Format("LOCATION:{0}", txtLocation.Text))
                eventBuilder.AppendLine(String.Format("DESCRIPTION:{0}", txtMemo.Text.Replace(Environment.NewLine, " ")))
                'eventBuilder.AppendLine(String.Format("DTSTART:{0}T{1}", dtStartDate.Value.ToString("yyyyMMdd"), dtStartTime.Value.ToString("HHmmss")))
                eventBuilder.AppendLine(String.Format("DTSTART:{0}T{1}", dtStartDate.Value.ToString("yyyyMMdd"), dtStartTime.Text.Replace(":", "") & "00"))
                'eventBuilder.AppendLine(String.Format("DTEND:{0}T{1}", dtEndDate.Value.ToString("yyyyMMdd"), dtEndTime.Value.ToString("HHmmss")))
                eventBuilder.AppendLine(String.Format("DTEND:{0}T{1}", dtEndDate.Value.ToString("yyyyMMdd"), dtEndTime.Text.Replace(":", "") & "00"))

                eventBuilder.AppendLine("END:VEVENT")

                Return eventBuilder.ToString
            End If
            Return String.Empty
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim content As String = String.Empty

            Select Case MetroTabControl1.SelectedTab.Name
                Case "tabFree"
                    content = txtFreeText.Text.Trim

                    If String.IsNullOrEmpty(content) Then
                        MetroFramework.MetroMessageBox.Show(Me, "Please enter some Text", "Free Text", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Case "tabURL"
                    Dim url As String = txtURL.Text.Trim
                    If RegexHelper.IsValidURL(url) Then
                        content = url
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "The URL is not valid", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Case "tabvCard"
                    content = GeneratevCardString()

                Case "tabPhone"
                    Dim phoneNumber As String = txtPhoneNumber.Text
                    If RegexHelper.IsValidPhoneNumber(phoneNumber) Then
                        content = String.Format("TEL:{0}", phoneNumber)
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "The Phone-Number is not valid", "Invalid Phone-Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Case "tabEmail"
                    Dim eMail As String = txtRecipient.Text
                    If RegexHelper.IsValidEmail(eMail) Then
                        content = String.Format("MATMSG:TO:{0};SUB:{1};Body:{2};;", eMail, txtSubject.Text, txtBody.Text)
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "The E-Mail address is not valid", "Invalid E-Mail address", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Case "tabSMS"
                    Dim smsTo As String = txtSMSTO.Text
                    If RegexHelper.IsValidPhoneNumber(smsTo) Then
                        content = String.Format("SMSTO:{0}:{1}", smsTo, txtSMSMSG.Text)
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "The Phone-Number is not valid", "Invalid Phone-Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Case "tabWIFI"
                    content = GenerateWifiString()

                Case "tabGeo"
                    'If chkCreateGoogleMapsLink.Checked Then
                    Dim lat As String = currentMarker.Position.Lat.ToString.Replace(",", ".")
                    Dim lng As String = currentMarker.Position.Lng.ToString.Replace(",", ".")

                    content = String.Format("https://maps.google.com/?q={0},{1}", lat, lng)
                    'Else
                    '    ' TODO: Implement QR GeoLocation Syntax
                    'End If

                Case "tabEvent"
                    'If RegexHelper.IsValidTime(dtStartTime.Text) And RegexHelper.IsValidTime(dtEndTime.Text) Then
                    content = GenerateVEventString()
                    'Else
                    '    MetroFramework.MetroMessageBox.Show(Me, "Invalid Time", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'End If
            End Select

            If Not String.IsNullOrEmpty(content) Then

                Dim config As Config = Config.Instance
                qr = New QR(content, CInt(config.PixelSize), CInt(numImageSize.Value), cbLevel.SelectedIndex, cbQuietZone.SelectedIndex)

                Select Case cbFormat.SelectedItem.ToString.ToLower
                    Case "png" : qr.ImageType = ImageFormat.Png
                    Case "bitmap" : qr.ImageType = ImageFormat.Bmp
                    Case "gif" : qr.ImageType = ImageFormat.Gif
                End Select

                Using frmQR As New QrForm(qr)
                    frmQR.ShowDialog()
                End Using
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InitGmaps()
        Try
            TrackBar1.Minimum = GMapControl1.MinZoom * 100
            TrackBar1.Maximum = GMapControl1.MaxZoom * 100
            TrackBar1.TickFrequency = 100

            cmbMapProvider.DataSource = GMapProviders.List
            GMapControl1.Overlays.Add(overlay)
            GMapControl1.MapProvider = OpenStreetMapProvider.Instance
            GMaps.Instance.Mode = AccessMode.ServerAndCache

            cmbMapProvider.SelectedItem = GMapControl1.MapProvider

            Dim regionInfo As New RegionInfo(CultureInfo.CurrentCulture.Name)
            Dim country As String = regionInfo.EnglishName
            Maps_GoTo(country)

            currentMarker = New GMarkerGoogle(GMapControl1.Position, GMarkerGoogleType.arrow)
            currentMarker.IsHitTestVisible = False

            overlay.Markers.Add(currentMarker)

            GMapControl1.Zoom = 5
            TrackBar1.Value = CInt(GMapControl1.Zoom * 100)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Maps_GoTo(ByVal searchTerm As String) As GeoCoderStatusCode
        Try
            Dim code As GeoCoderStatusCode = GMapControl1.SetPositionByKeywords(searchTerm)

            Select Case code
                Case GeoCoderStatusCode.G_GEO_UNKNOWN_ADDRESS
                    MetroFramework.MetroMessageBox.Show(Me, "Unknown Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case GeoCoderStatusCode.G_GEO_SERVER_ERROR
                    MetroFramework.MetroMessageBox.Show(Me, "Server Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case GeoCoderStatusCode.G_GEO_UNAVAILABLE_ADDRESS
                    MetroFramework.MetroMessageBox.Show(Me, "Unavailable Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case GeoCoderStatusCode.G_GEO_BAD_KEY
                    MetroFramework.MetroMessageBox.Show(Me, "Bad Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case GeoCoderStatusCode.G_GEO_BAD_REQUEST
                    MetroFramework.MetroMessageBox.Show(Me, "Bad Request", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case GeoCoderStatusCode.G_GEO_MISSING_ADDRESS
                    MetroFramework.MetroMessageBox.Show(Me, "Missing Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case GeoCoderStatusCode.G_GEO_MISSING_QUERY
                    MetroFramework.MetroMessageBox.Show(Me, "Missing Query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case GeoCoderStatusCode.G_GEO_UNKNOWN_DIRECTIONS
                    MetroFramework.MetroMessageBox.Show(Me, "Unknown Directions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case GeoCoderStatusCode.G_GEO_TOO_MANY_QUERIES
                    MetroFramework.MetroMessageBox.Show(Me, "Too many Queries", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case GeoCoderStatusCode.Unknow
                    MetroFramework.MetroMessageBox.Show(Me, "Unknown Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
            Return code
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub LoadSettings()
        Try
            Dim config As Config = Config.Instance

            If config.ImageSize < numImageSize.Minimum Then
                numImageSize.Value = numImageSize.Minimum
            ElseIf config.ImageSize > numImageSize.Maximum Then
                numImageSize.Value = numImageSize.Maximum
            Else
                numImageSize.Value = config.ImageSize
            End If
            'numImageSize.Value = config.ImageSize

            cbLevel.SelectedIndex = config.CorrectionLevel
            cbQuietZone.SelectedIndex = config.QuietZone

            If config.SaveWifiSettings Then
                Dim wrapper As New Simple3Des(Application.ProductName)

                txtSSID.Text = config.SSID
                txtWIFIPwd.Text = wrapper.Decrypt(config.WifiPwd)
                cbHiddenSSID.Checked = config.WifiHidden

                Select Case config.Encryption
                    Case 2 : rbWPA.Checked = True
                    Case 1 : rbWEP.Checked = True
                    Case 0 : rbNoEncryption.Checked = True
                End Select

            End If
            cbSaveWifiSettings.Checked = config.SaveWifiSettings

            cmbStyle.SelectedIndex = config.StyleID
            cmbTheme.SelectedIndex = config.ThemeID

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SaveSettings()
        Try
            Dim config As Config = Config.Instance

            config.ImageSize = numImageSize.Value
            config.CorrectionLevel = cbLevel.SelectedIndex
            config.QuietZone = cbQuietZone.SelectedIndex

            If cbSaveWifiSettings.Checked Then
                Dim wrapper As New Simple3Des(Application.ProductName)

                config.SSID = txtSSID.Text
                config.WifiPwd = wrapper.Encrypt(txtWIFIPwd.Text)
                config.WifiHidden = cbHiddenSSID.Checked

                If rbWPA.Checked Then config.Encryption = 2
                If rbWEP.Checked Then config.Encryption = 1
                If rbNoEncryption.Checked Then config.Encryption = 0
            Else
                config.SSID = ""
                config.WifiPwd = ""
                config.WifiHidden = False
                config.Encryption = 2
            End If

            config.SaveWifiSettings = cbSaveWifiSettings.Checked

            config.StyleID = cmbStyle.SelectedIndex
            config.ThemeID = cmbTheme.SelectedIndex

            config.Save()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GetPhoneBookEntries()
        Try
            Dim filePath As String = Path.Combine(Application.StartupPath, "phonebook.txt")

            If File.Exists(filePath) Then
                Using sr As StreamReader = File.OpenText(filePath)

                    Dim content As String = sr.ReadToEnd()
                    Dim sArray As String() = content.Split(CType(Environment.NewLine, Char()))

                    For Each str As String In sArray
                        str = str.Trim()
                        Dim pArray As String() = str.Split(CType("|", Char()))

                        ' We don't want to add empty or corrupt entries :)
                        If pArray.Length = lvPhoneBook.Columns.Count Then
                            Dim lvi As New ListViewItem(pArray)
                            lvPhoneBook.Items.Add(lvi)
                        End If
                    Next
                End Using
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub WritePhoneBookEntries()
        Try
            Dim filePath As String = Path.Combine(Application.StartupPath, "phonebook.txt")

            Using sr As StreamWriter = File.CreateText(filePath)
                For Each lvi As ListViewItem In lvPhoneBook.Items
                    Dim name As String = lvi.Text
                    Dim phone As String = lvi.SubItems(1).Text

                    sr.WriteLine(String.Format("{0}|{1}", name, phone))
                Next
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            SaveSettings()
            WritePhoneBookEntries()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkShowWifiPwd_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowWifiPwd.CheckedChanged
        txtWIFIPwd.PasswordChar = If(chkShowWifiPwd.Checked, ControlChars.NullChar, "●"c)
    End Sub

    Private Sub btnSaveVCard_Click(sender As Object, e As EventArgs) Handles btnSaveVCard.Click
        Try
            If String.IsNullOrEmpty(txtvGivenName.Text) Or String.IsNullOrEmpty(txtvFamilyName.Text) Then
                MetroFramework.MetroMessageBox.Show(Me, "FirstName and LastName are mandatory", "vCard", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim sfd As New SaveFileDialog
                sfd.Filter = "vCard|*.vcf"
                Dim dr As DialogResult = sfd.ShowDialog()

                If dr = DialogResult.OK Then
                    Dim StrvCard As String = GeneratevCardString()

                    Using streamWriter As New StreamWriter(sfd.FileName, False, Encoding.Default)
                        streamWriter.Write(StrvCard)
                    End Using
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GMapControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles GMapControl1.MouseDown
        If e.Button = MouseButtons.Left Then
            isMouseDown = True
            currentMarker.Position = GMapControl1.FromLocalToLatLng(e.X, e.Y)
        End If
    End Sub

    Private Sub GMapControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles GMapControl1.MouseUp
        Select Case e.Button
            Case MouseButtons.Left
                isMouseDown = False
            Case MouseButtons.Right
                If Not GMapControl1.IsDragging Then
                    mapMenu.Show(GMapControl1, e.X, e.Y)
                End If
        End Select
    End Sub

    Private Sub GMapControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles GMapControl1.MouseMove
        If e.Button = MouseButtons.Left And isMouseDown Then
            currentMarker.Position = GMapControl1.FromLocalToLatLng(e.X, e.Y)
            GMapControl1.Refresh()
        End If
    End Sub

    Private Sub GMapControl1_Paint(sender As Object, e As PaintEventArgs) Handles GMapControl1.Paint
        txtLatitude.Text = currentMarker.Position.Lat.ToString.Replace(",", ".")
        txtLongitude.Text = currentMarker.Position.Lng.ToString.Replace(",", ".")
    End Sub

    Private Sub GMapControl1_OnMapZoomChanged() Handles GMapControl1.OnMapZoomChanged
        TrackBar1.Value = CInt(GMapControl1.Zoom * 100.0)
    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        GMapControl1.Zoom = TrackBar1.Value / 100.0
    End Sub

    Private Sub cmbMapProvider_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMapProvider.SelectedIndexChanged
        Try
            GMapControl1.MapProvider = CType(cmbMapProvider.SelectedItem, GMapProvider)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtStartDate.ValueChanged
        dtEndDate.Value = dtStartDate.Value

        dtStartTime.Focus()
        dtStartTime.Select(0, 2)
    End Sub

    Private Sub dtEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtEndDate.ValueChanged
        Me.Focus()

        dtEndTime.Focus()
        dtEndTime.Select(0, 2)
    End Sub

    Private Sub dtStartTime_TextChanged(sender As Object, e As EventArgs) Handles dtStartTime.TextChanged
        dtEndTime.Text = dtStartTime.Text
    End Sub

    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        Try
            FocusControls()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FocusControls()
    End Sub

    Private Sub cmbStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStyle.SelectedIndexChanged
        SetMetroStyle()
    End Sub

    Private Sub cmbTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTheme.SelectedIndexChanged
        SetMetroStyle()
    End Sub

    Private Sub mlMenu_Click(sender As Object, e As EventArgs) Handles mlMenu.Click
        ToggleOptionsPanel()
    End Sub

    Private Sub mlTools_Click(sender As Object, e As EventArgs) Handles mlTools.Click
        ctxMenu.Show(mlTools, 0, mlTools.Height)
    End Sub

    Private Sub VisitWebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitWebsiteToolStripMenuItem.Click
        Process.Start("http://raspberrydave.ddns.net")
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        Dim dlgCredits As New CreditsForm
        dlgCredits.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim dlgAbout As New AboutForm()
        dlgAbout.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub mlSearch_Click(sender As Object, e As EventArgs) Handles mlSearch.Click
        Try
            Dim frmAddress As New MapAddressForm
            Dim dr As DialogResult = frmAddress.ShowDialog()

            If dr = DialogResult.OK Then
                Dim code As GeoCoderStatusCode = Maps_GoTo(frmAddress.Keywords)
                If code = GeoCoderStatusCode.G_GEO_SUCCESS Then
                    currentMarker.Position = GMapControl1.Position
                    GMapControl1.Zoom = GMapControl1.MaxZoom - 6
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchByKeywordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByKeywordsToolStripMenuItem.Click
        mlSearch.PerformClick()
    End Sub

    ' Zoom Max
    Private Sub MaxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaxToolStripMenuItem.Click
        GMapControl1.Zoom = GMapControl1.MaxZoom
    End Sub

    ' Zoom 75 %
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        GMapControl1.Zoom = Convert.ToInt32(GMapControl1.MaxZoom / 1.33)
    End Sub

    ' Zoom 50 %
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        GMapControl1.Zoom = Convert.ToInt32(GMapControl1.MaxZoom / 2)
    End Sub

    ' Zoom 25 %
    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        GMapControl1.Zoom = Convert.ToInt32(GMapControl1.MaxZoom / 4)
    End Sub

    ' Zoom Min
    Private Sub MinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinToolStripMenuItem.Click
        GMapControl1.Zoom = GMapControl1.MinZoom
    End Sub

    Private Sub btnAddPhoneNumber_Click(sender As Object, e As EventArgs) Handles btnAddPhoneNumber.Click
        Try
            Dim phoneNumber As String = txtPhoneNumber.Text

            If Not String.IsNullOrEmpty(phoneNumber) Then
                If RegexHelper.IsValidPhoneNumber(phoneNumber) Then

                    Using frmContactName As New MetroFramework.Forms.MetroForm

                        frmContactName.Width = 300
                        frmContactName.Height = 120
                        frmContactName.MinimizeBox = False
                        frmContactName.MaximizeBox = False
                        frmContactName.DisplayHeader = False
                        frmContactName.Resizable = False
                        frmContactName.ShowInTaskbar = False
                        frmContactName.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
                        frmContactName.StartPosition = FormStartPosition.CenterParent

                        Dim lblText As New MetroFramework.Controls.MetroLabel
                        lblText.AutoSize = True
                        lblText.Text = String.Format("Name of Contact: ({0})", phoneNumber)
                        lblText.Location = New Point(10, 18)

                        Dim txtContactName As New MetroFramework.Controls.MetroTextBox
                        txtContactName.Width = 260
                        txtContactName.Location = New Point(15, 45)

                        Dim btnCancel As New MetroFramework.Controls.MetroButton
                        btnCancel.Text = "Cancel"
                        btnCancel.Location = New Point(120, 85)
                        btnCancel.DialogResult = DialogResult.Cancel

                        Dim btnOK As New MetroFramework.Controls.MetroButton
                        btnOK.Text = "OK"
                        btnOK.Location = New Point(200, 85)
                        btnOK.DialogResult = DialogResult.OK

                        frmContactName.Controls.Add(lblText)
                        frmContactName.Controls.Add(txtContactName)
                        frmContactName.Controls.Add(btnCancel)
                        frmContactName.Controls.Add(btnOK)

                        StyleHelper.Instance.ApplyTo(frmContactName)

                        Dim dr As DialogResult = frmContactName.ShowDialog()

                        If dr = DialogResult.OK Then
                            Dim contact As String = txtContactName.Text.Trim

                            If Not String.IsNullOrEmpty(contact) Then
                                Dim lvItem As New ListViewItem(contact)
                                lvItem.SubItems.Add(phoneNumber)
                                lvPhoneBook.Items.Add(lvItem)
                            End If
                        End If

                    End Using
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "The Phone-Number is not valid", "Invalid Phone-Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Please enter a Phone Number")
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub tsmiDeleteContact_Click(sender As Object, e As EventArgs) Handles tsmiDeleteContact.Click
        If lvPhoneBook.SelectedItems.Count > 0 Then
            Dim lvi As ListViewItem = lvPhoneBook.SelectedItems(0)
            lvi.Remove()
        End If
    End Sub


    Private Sub editbox_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case e.KeyChar
            Case ChrW(Keys.Enter)
                hitinfo.SubItem.Text = editbox.Text
                editbox.Hide()
            Case ChrW(Keys.Escape)
                editbox.Hide()
        End Select
    End Sub

    Private Sub editbox_LostFocus(sender As Object, e As EventArgs)
        editbox.Hide()
    End Sub

    Private Sub lvPhoneBook_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        hitinfo = lvPhoneBook.HitTest(e.X, e.Y)
        With editbox
            .Bounds = hitinfo.SubItem.Bounds
            .Text = hitinfo.SubItem.Text
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub lvPhoneBook_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            If lvPhoneBook.SelectedItems.Count > 0 Then
                ctxAddressBook.Show(MousePosition)
            End If
        End If
    End Sub

    Private Sub lvPhoneBook_KeyDown(sender As Object, e As KeyEventArgs)
        If lvPhoneBook.SelectedItems.Count > 0 Then
            Dim lvi As ListViewItem = lvPhoneBook.SelectedItems(0)
            Select Case e.KeyCode
                Case Keys.Delete
                    lvi.Remove()
            End Select
        End If
    End Sub

    Private Sub lvPhoneBook_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            If lvPhoneBook.SelectedItems.Count > 0 Then
                Dim lvItem As ListViewItem = lvPhoneBook.SelectedItems(0)

                txtPhoneNumber.Text = lvItem.SubItems(1).Text
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub lvPhoneBook_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs)
        If e.Item.Selected = True Then
            Dim foreColor As Color = StyleHelper.Instance.GetStyleColor()
            Dim backColor As Color = StyleHelper.Instance.GetContrastColor(foreColor)

            e.Graphics.FillRectangle(New SolidBrush(foreColor), e.Bounds)

            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, New Font(lvPhoneBook.Font, Nothing), New Point(e.Bounds.Left, e.Bounds.Top), backColor)
        Else
            e.DrawDefault = True
        End If
    End Sub

    Private Sub lvPhoneBook_DrawItem(sender As Object, e As DrawListViewItemEventArgs)
        If e.Item.Selected = False Then
            e.DrawDefault = True
        End If
    End Sub

    Private Sub lvPhoneBook_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs)
        'e.DrawDefault = True

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

        Select Case StyleHelper.Instance.Theme
            Case MetroFramework.MetroThemeStyle.Dark
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(34, 34, 34)), e.Bounds)
                TextRenderer.DrawText(e.Graphics, e.Header.Text, New Font(lvPhoneBook.Font, FontStyle.Bold), New Point(e.Bounds.Left + 10, e.Bounds.Top + 1), StyleHelper.Instance.GetStyleColor)
            Case MetroFramework.MetroThemeStyle.Default
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(238, 238, 238)), e.Bounds)
                TextRenderer.DrawText(e.Graphics, e.Header.Text, New Font(lvPhoneBook.Font, FontStyle.Bold), New Point(e.Bounds.Left + 10, e.Bounds.Top + 1), StyleHelper.Instance.GetStyleColor)
            Case MetroFramework.MetroThemeStyle.Light
                e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(238, 238, 238)), e.Bounds)
                TextRenderer.DrawText(e.Graphics, e.Header.Text, New Font(lvPhoneBook.Font, FontStyle.Bold), New Point(e.Bounds.Left + 10, e.Bounds.Top + 1), StyleHelper.Instance.GetStyleColor)
        End Select

        'e.Graphics.FillEllipse(New SolidBrush(Color.FromArgb(100, 100, 100)), e.Bounds)
        'TextRenderer.DrawText(e.Graphics, e.Header.Text, New Font(lvPhoneBook.Font, Nothing), New Point(e.Bounds.Left + 10, e.Bounds.Top), Color.White)
    End Sub

End Class