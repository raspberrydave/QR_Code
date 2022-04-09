<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits MetroFramework.Forms.MetroForm
    'Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MetroLabel47 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabFree = New MetroFramework.Controls.MetroTabPage()
        Me.txtFreeText = New MetroFramework.Controls.MetroTextBox()
        Me.tabURL = New MetroFramework.Controls.MetroTabPage()
        Me.txtURL = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.tabvCard = New MetroFramework.Controls.MetroTabPage()
        Me.btnSaveVCard = New MetroFramework.Controls.MetroButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbvCountryWork = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel30 = New MetroFramework.Controls.MetroLabel()
        Me.txtvCityWork = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel31 = New MetroFramework.Controls.MetroLabel()
        Me.txtvPostalWork = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel32 = New MetroFramework.Controls.MetroLabel()
        Me.txtvStreetWork = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel33 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel34 = New MetroFramework.Controls.MetroLabel()
        Me.txtvEmailWork = New MetroFramework.Controls.MetroTextBox()
        Me.txtvFaxWork = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.txtvWebsiteWork = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel24 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.txtvTelWork = New MetroFramework.Controls.MetroTextBox()
        Me.txtvTitle = New MetroFramework.Controls.MetroTextBox()
        Me.txtvOrganisation = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkvYear = New MetroFramework.Controls.MetroComboBox()
        Me.chkvMonth = New MetroFramework.Controls.MetroComboBox()
        Me.chkvDay = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel36 = New MetroFramework.Controls.MetroLabel()
        Me.txtvCellphonePrivate = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel35 = New MetroFramework.Controls.MetroLabel()
        Me.cmbvCountryPrivate = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel29 = New MetroFramework.Controls.MetroLabel()
        Me.txtvCityPrivate = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel28 = New MetroFramework.Controls.MetroLabel()
        Me.txtvPostalPrivate = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel27 = New MetroFramework.Controls.MetroLabel()
        Me.txtvStreetPrivate = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel26 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel25 = New MetroFramework.Controls.MetroLabel()
        Me.txtvFaxPrivate = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel23 = New MetroFramework.Controls.MetroLabel()
        Me.txtvWebsitePrivate = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.txtvTelPrivate = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.txtvEmailPrivate = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.txtvFamilyName = New MetroFramework.Controls.MetroTextBox()
        Me.txtvGivenName = New MetroFramework.Controls.MetroTextBox()
        Me.tabPhone = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lvPhoneBook = New System.Windows.Forms.ListView()
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPhoneNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddPhoneNumber = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txtPhoneNumber = New MetroFramework.Controls.MetroTextBox()
        Me.tabEmail = New MetroFramework.Controls.MetroTabPage()
        Me.txtBody = New MetroFramework.Controls.MetroTextBox()
        Me.txtSubject = New MetroFramework.Controls.MetroTextBox()
        Me.txtRecipient = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.tabSMS = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtSMSMSG = New MetroFramework.Controls.MetroTextBox()
        Me.txtSMSTO = New MetroFramework.Controls.MetroTextBox()
        Me.tabWIFI = New MetroFramework.Controls.MetroTabPage()
        Me.cbSaveWifiSettings = New MetroFramework.Controls.MetroCheckBox()
        Me.cbHiddenSSID = New MetroFramework.Controls.MetroCheckBox()
        Me.rbNoEncryption = New MetroFramework.Controls.MetroRadioButton()
        Me.chkShowWifiPwd = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.rbWPA = New MetroFramework.Controls.MetroRadioButton()
        Me.rbWEP = New MetroFramework.Controls.MetroRadioButton()
        Me.txtWIFIPwd = New MetroFramework.Controls.MetroTextBox()
        Me.txtSSID = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tabGeo = New MetroFramework.Controls.MetroTabPage()
        Me.mlSearch = New MetroFramework.Controls.MetroLink()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.chkCreateGoogleMapsLink = New MetroFramework.Controls.MetroCheckBox()
        Me.txtLongitude = New MetroFramework.Controls.MetroTextBox()
        Me.cmbMapProvider = New MetroFramework.Controls.MetroComboBox()
        Me.lblMapProvider = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel38 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel37 = New MetroFramework.Controls.MetroLabel()
        Me.txtLatitude = New MetroFramework.Controls.MetroTextBox()
        Me.GMapControl1 = New GMap.NET.WindowsForms.GMapControl()
        Me.tabEvent = New MetroFramework.Controls.MetroTabPage()
        Me.dtEndTime = New System.Windows.Forms.MaskedTextBox()
        Me.dtStartTime = New System.Windows.Forms.MaskedTextBox()
        Me.MetroLabel46 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel45 = New MetroFramework.Controls.MetroLabel()
        Me.dtEndDate = New MetroFramework.Controls.MetroDateTime()
        Me.dtStartDate = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel44 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel43 = New MetroFramework.Controls.MetroLabel()
        Me.txtMemo = New MetroFramework.Controls.MetroTextBox()
        Me.txtLocation = New MetroFramework.Controls.MetroTextBox()
        Me.txtEventName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel42 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel41 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel40 = New MetroFramework.Controls.MetroLabel()
        Me.cmbStyle = New MetroFramework.Controls.MetroComboBox()
        Me.rbHiddenSSID = New MetroFramework.Controls.MetroCheckBox()
        Me.pnlOptions = New System.Windows.Forms.Panel()
        Me.lblSkinOptions = New MetroFramework.Controls.MetroLabel()
        Me.LineSeparator3 = New QR_Code.LineSeparator()
        Me.lblTheme = New MetroFramework.Controls.MetroLabel()
        Me.cmbTheme = New MetroFramework.Controls.MetroComboBox()
        Me.LineSeparator2 = New QR_Code.LineSeparator()
        Me.lblQrOptions = New MetroFramework.Controls.MetroLabel()
        Me.lblImageSize = New MetroFramework.Controls.MetroLabel()
        Me.cbFormat = New MetroFramework.Controls.MetroComboBox()
        Me.lblFormat = New MetroFramework.Controls.MetroLabel()
        Me.lblQuietZone = New MetroFramework.Controls.MetroLabel()
        Me.lblCorrLevel = New MetroFramework.Controls.MetroLabel()
        Me.cbQuietZone = New MetroFramework.Controls.MetroComboBox()
        Me.cbLevel = New MetroFramework.Controls.MetroComboBox()
        Me.numImageSize = New System.Windows.Forms.NumericUpDown()
        Me.lblStyle = New MetroFramework.Controls.MetroLabel()
        Me.ctxMenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.VisitWebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.mapMenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.MinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.GoToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchByKeywordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mlTools = New MetroFramework.Controls.MetroLink()
        Me.mlMenu = New MetroFramework.Controls.MetroLink()
        Me.ctxAddressBook = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.tsmiDeleteContact = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroTabControl1.SuspendLayout()
        Me.tabFree.SuspendLayout()
        Me.tabURL.SuspendLayout()
        Me.tabvCard.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabPhone.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabEmail.SuspendLayout()
        Me.tabSMS.SuspendLayout()
        Me.tabWIFI.SuspendLayout()
        Me.tabGeo.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEvent.SuspendLayout()
        Me.pnlOptions.SuspendLayout()
        CType(Me.numImageSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxMenu.SuspendLayout()
        Me.mapMenu.SuspendLayout()
        Me.ctxAddressBook.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel47
        '
        Me.MetroLabel47.AutoSize = True
        Me.MetroLabel47.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel47.Location = New System.Drawing.Point(9, 169)
        Me.MetroLabel47.Name = "MetroLabel47"
        Me.MetroLabel47.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel47.TabIndex = 15
        Me.MetroLabel47.Text = "Format:"
        Me.MetroLabel47.UseCustomBackColor = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tabFree)
        Me.MetroTabControl1.Controls.Add(Me.tabURL)
        Me.MetroTabControl1.Controls.Add(Me.tabvCard)
        Me.MetroTabControl1.Controls.Add(Me.tabPhone)
        Me.MetroTabControl1.Controls.Add(Me.tabEmail)
        Me.MetroTabControl1.Controls.Add(Me.tabSMS)
        Me.MetroTabControl1.Controls.Add(Me.tabWIFI)
        Me.MetroTabControl1.Controls.Add(Me.tabGeo)
        Me.MetroTabControl1.Controls.Add(Me.tabEvent)
        Me.MetroTabControl1.HotTrack = True
        Me.MetroTabControl1.Location = New System.Drawing.Point(20, 103)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 7
        Me.MetroTabControl1.Size = New System.Drawing.Size(618, 324)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'tabFree
        '
        Me.tabFree.BackColor = System.Drawing.Color.Transparent
        Me.tabFree.BackgroundImage = Global.QR_Code.My.Resources.Resources.text_64
        Me.tabFree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tabFree.Controls.Add(Me.txtFreeText)
        Me.tabFree.HorizontalScrollbarBarColor = True
        Me.tabFree.HorizontalScrollbarHighlightOnWheel = False
        Me.tabFree.HorizontalScrollbarSize = 10
        Me.tabFree.Location = New System.Drawing.Point(4, 38)
        Me.tabFree.Name = "tabFree"
        Me.tabFree.Size = New System.Drawing.Size(610, 282)
        Me.tabFree.TabIndex = 0
        Me.tabFree.Text = "Free Text"
        Me.tabFree.VerticalScrollbarBarColor = True
        Me.tabFree.VerticalScrollbarHighlightOnWheel = False
        Me.tabFree.VerticalScrollbarSize = 10
        '
        'txtFreeText
        '
        '
        '
        '
        Me.txtFreeText.CustomButton.Image = Nothing
        Me.txtFreeText.CustomButton.Location = New System.Drawing.Point(262, 2)
        Me.txtFreeText.CustomButton.Name = ""
        Me.txtFreeText.CustomButton.Size = New System.Drawing.Size(215, 215)
        Me.txtFreeText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFreeText.CustomButton.TabIndex = 1
        Me.txtFreeText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFreeText.CustomButton.UseSelectable = True
        Me.txtFreeText.CustomButton.Visible = False
        Me.txtFreeText.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtFreeText.Lines = New String(-1) {}
        Me.txtFreeText.Location = New System.Drawing.Point(93, 29)
        Me.txtFreeText.MaxLength = 32767
        Me.txtFreeText.Multiline = True
        Me.txtFreeText.Name = "txtFreeText"
        Me.txtFreeText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFreeText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFreeText.SelectedText = ""
        Me.txtFreeText.SelectionLength = 0
        Me.txtFreeText.SelectionStart = 0
        Me.txtFreeText.ShortcutsEnabled = True
        Me.txtFreeText.Size = New System.Drawing.Size(480, 220)
        Me.txtFreeText.TabIndex = 0
        Me.txtFreeText.UseSelectable = True
        Me.txtFreeText.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFreeText.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tabURL
        '
        Me.tabURL.BackColor = System.Drawing.Color.Transparent
        Me.tabURL.BackgroundImage = Global.QR_Code.My.Resources.Resources.world_64
        Me.tabURL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tabURL.Controls.Add(Me.txtURL)
        Me.tabURL.Controls.Add(Me.MetroLabel5)
        Me.tabURL.HorizontalScrollbarBarColor = True
        Me.tabURL.HorizontalScrollbarHighlightOnWheel = False
        Me.tabURL.HorizontalScrollbarSize = 10
        Me.tabURL.Location = New System.Drawing.Point(4, 38)
        Me.tabURL.Name = "tabURL"
        Me.tabURL.Size = New System.Drawing.Size(610, 282)
        Me.tabURL.TabIndex = 6
        Me.tabURL.Text = "URL"
        Me.tabURL.VerticalScrollbarBarColor = True
        Me.tabURL.VerticalScrollbarHighlightOnWheel = False
        Me.tabURL.VerticalScrollbarSize = 10
        '
        'txtURL
        '
        '
        '
        '
        Me.txtURL.CustomButton.Image = Nothing
        Me.txtURL.CustomButton.Location = New System.Drawing.Point(327, 2)
        Me.txtURL.CustomButton.Name = ""
        Me.txtURL.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtURL.CustomButton.TabIndex = 1
        Me.txtURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtURL.CustomButton.UseSelectable = True
        Me.txtURL.CustomButton.Visible = False
        Me.txtURL.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtURL.Lines = New String() {"http://"}
        Me.txtURL.Location = New System.Drawing.Point(192, 79)
        Me.txtURL.MaxLength = 32767
        Me.txtURL.Name = "txtURL"
        Me.txtURL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtURL.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtURL.SelectedText = ""
        Me.txtURL.SelectionLength = 0
        Me.txtURL.SelectionStart = 0
        Me.txtURL.ShortcutsEnabled = True
        Me.txtURL.Size = New System.Drawing.Size(357, 32)
        Me.txtURL.TabIndex = 3
        Me.txtURL.Text = "http://"
        Me.txtURL.UseSelectable = True
        Me.txtURL.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtURL.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(110, 86)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(76, 25)
        Me.MetroLabel5.TabIndex = 2
        Me.MetroLabel5.Text = "Address:"
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'tabvCard
        '
        Me.tabvCard.AutoScroll = True
        Me.tabvCard.BackColor = System.Drawing.Color.Transparent
        Me.tabvCard.BackgroundImage = Global.QR_Code.My.Resources.Resources.card_64
        Me.tabvCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tabvCard.Controls.Add(Me.btnSaveVCard)
        Me.tabvCard.Controls.Add(Me.GroupBox3)
        Me.tabvCard.Controls.Add(Me.GroupBox1)
        Me.tabvCard.HorizontalScrollbar = True
        Me.tabvCard.HorizontalScrollbarBarColor = True
        Me.tabvCard.HorizontalScrollbarHighlightOnWheel = False
        Me.tabvCard.HorizontalScrollbarSize = 10
        Me.tabvCard.Location = New System.Drawing.Point(4, 38)
        Me.tabvCard.Name = "tabvCard"
        Me.tabvCard.Size = New System.Drawing.Size(610, 282)
        Me.tabvCard.TabIndex = 2
        Me.tabvCard.Text = "vCard"
        Me.tabvCard.VerticalScrollbar = True
        Me.tabvCard.VerticalScrollbarBarColor = True
        Me.tabvCard.VerticalScrollbarHighlightOnWheel = False
        Me.tabvCard.VerticalScrollbarSize = 20
        '
        'btnSaveVCard
        '
        Me.btnSaveVCard.Location = New System.Drawing.Point(416, 844)
        Me.btnSaveVCard.Name = "btnSaveVCard"
        Me.btnSaveVCard.Size = New System.Drawing.Size(155, 23)
        Me.btnSaveVCard.TabIndex = 0
        Me.btnSaveVCard.Text = "Save vCard (.vcf)"
        Me.btnSaveVCard.UseSelectable = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cmbvCountryWork)
        Me.GroupBox3.Controls.Add(Me.MetroLabel30)
        Me.GroupBox3.Controls.Add(Me.txtvCityWork)
        Me.GroupBox3.Controls.Add(Me.MetroLabel31)
        Me.GroupBox3.Controls.Add(Me.txtvPostalWork)
        Me.GroupBox3.Controls.Add(Me.MetroLabel32)
        Me.GroupBox3.Controls.Add(Me.txtvStreetWork)
        Me.GroupBox3.Controls.Add(Me.MetroLabel33)
        Me.GroupBox3.Controls.Add(Me.MetroLabel34)
        Me.GroupBox3.Controls.Add(Me.txtvEmailWork)
        Me.GroupBox3.Controls.Add(Me.txtvFaxWork)
        Me.GroupBox3.Controls.Add(Me.MetroLabel22)
        Me.GroupBox3.Controls.Add(Me.txtvWebsiteWork)
        Me.GroupBox3.Controls.Add(Me.MetroLabel24)
        Me.GroupBox3.Controls.Add(Me.MetroLabel19)
        Me.GroupBox3.Controls.Add(Me.MetroLabel15)
        Me.GroupBox3.Controls.Add(Me.MetroLabel14)
        Me.GroupBox3.Controls.Add(Me.txtvTelWork)
        Me.GroupBox3.Controls.Add(Me.txtvTitle)
        Me.GroupBox3.Controls.Add(Me.txtvOrganisation)
        Me.GroupBox3.Controls.Add(Me.MetroLabel18)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(89, 475)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(482, 348)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Company Information:"
        '
        'cmbvCountryWork
        '
        Me.cmbvCountryWork.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbvCountryWork.FormattingEnabled = True
        Me.cmbvCountryWork.ItemHeight = 19
        Me.cmbvCountryWork.Location = New System.Drawing.Point(127, 305)
        Me.cmbvCountryWork.Name = "cmbvCountryWork"
        Me.cmbvCountryWork.Size = New System.Drawing.Size(262, 25)
        Me.cmbvCountryWork.TabIndex = 9
        Me.cmbvCountryWork.UseSelectable = True
        '
        'MetroLabel30
        '
        Me.MetroLabel30.AutoSize = True
        Me.MetroLabel30.Location = New System.Drawing.Point(60, 305)
        Me.MetroLabel30.Name = "MetroLabel30"
        Me.MetroLabel30.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel30.TabIndex = 39
        Me.MetroLabel30.Text = "Country:"
        '
        'txtvCityWork
        '
        '
        '
        '
        Me.txtvCityWork.CustomButton.Image = Nothing
        Me.txtvCityWork.CustomButton.Location = New System.Drawing.Point(240, 1)
        Me.txtvCityWork.CustomButton.Name = ""
        Me.txtvCityWork.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvCityWork.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvCityWork.CustomButton.TabIndex = 1
        Me.txtvCityWork.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvCityWork.CustomButton.UseSelectable = True
        Me.txtvCityWork.CustomButton.Visible = False
        Me.txtvCityWork.Lines = New String(-1) {}
        Me.txtvCityWork.Location = New System.Drawing.Point(127, 279)
        Me.txtvCityWork.MaxLength = 32767
        Me.txtvCityWork.Name = "txtvCityWork"
        Me.txtvCityWork.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvCityWork.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvCityWork.SelectedText = ""
        Me.txtvCityWork.SelectionLength = 0
        Me.txtvCityWork.SelectionStart = 0
        Me.txtvCityWork.ShortcutsEnabled = True
        Me.txtvCityWork.Size = New System.Drawing.Size(262, 23)
        Me.txtvCityWork.TabIndex = 8
        Me.txtvCityWork.UseSelectable = True
        Me.txtvCityWork.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvCityWork.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel31
        '
        Me.MetroLabel31.AutoSize = True
        Me.MetroLabel31.Location = New System.Drawing.Point(60, 279)
        Me.MetroLabel31.Name = "MetroLabel31"
        Me.MetroLabel31.Size = New System.Drawing.Size(34, 19)
        Me.MetroLabel31.TabIndex = 37
        Me.MetroLabel31.Text = "City:"
        '
        'txtvPostalWork
        '
        '
        '
        '
        Me.txtvPostalWork.CustomButton.Image = Nothing
        Me.txtvPostalWork.CustomButton.Location = New System.Drawing.Point(240, 1)
        Me.txtvPostalWork.CustomButton.Name = ""
        Me.txtvPostalWork.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvPostalWork.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvPostalWork.CustomButton.TabIndex = 1
        Me.txtvPostalWork.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvPostalWork.CustomButton.UseSelectable = True
        Me.txtvPostalWork.CustomButton.Visible = False
        Me.txtvPostalWork.Lines = New String(-1) {}
        Me.txtvPostalWork.Location = New System.Drawing.Point(127, 253)
        Me.txtvPostalWork.MaxLength = 32767
        Me.txtvPostalWork.Name = "txtvPostalWork"
        Me.txtvPostalWork.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvPostalWork.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvPostalWork.SelectedText = ""
        Me.txtvPostalWork.SelectionLength = 0
        Me.txtvPostalWork.SelectionStart = 0
        Me.txtvPostalWork.ShortcutsEnabled = True
        Me.txtvPostalWork.Size = New System.Drawing.Size(262, 23)
        Me.txtvPostalWork.TabIndex = 7
        Me.txtvPostalWork.UseSelectable = True
        Me.txtvPostalWork.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvPostalWork.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel32
        '
        Me.MetroLabel32.AutoSize = True
        Me.MetroLabel32.Location = New System.Drawing.Point(60, 253)
        Me.MetroLabel32.Name = "MetroLabel32"
        Me.MetroLabel32.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel32.TabIndex = 35
        Me.MetroLabel32.Text = "Postal:"
        '
        'txtvStreetWork
        '
        '
        '
        '
        Me.txtvStreetWork.CustomButton.Image = Nothing
        Me.txtvStreetWork.CustomButton.Location = New System.Drawing.Point(240, 1)
        Me.txtvStreetWork.CustomButton.Name = ""
        Me.txtvStreetWork.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvStreetWork.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvStreetWork.CustomButton.TabIndex = 1
        Me.txtvStreetWork.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvStreetWork.CustomButton.UseSelectable = True
        Me.txtvStreetWork.CustomButton.Visible = False
        Me.txtvStreetWork.Lines = New String(-1) {}
        Me.txtvStreetWork.Location = New System.Drawing.Point(127, 227)
        Me.txtvStreetWork.MaxLength = 32767
        Me.txtvStreetWork.Name = "txtvStreetWork"
        Me.txtvStreetWork.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvStreetWork.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvStreetWork.SelectedText = ""
        Me.txtvStreetWork.SelectionLength = 0
        Me.txtvStreetWork.SelectionStart = 0
        Me.txtvStreetWork.ShortcutsEnabled = True
        Me.txtvStreetWork.Size = New System.Drawing.Size(262, 23)
        Me.txtvStreetWork.TabIndex = 6
        Me.txtvStreetWork.UseSelectable = True
        Me.txtvStreetWork.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvStreetWork.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel33
        '
        Me.MetroLabel33.AutoSize = True
        Me.MetroLabel33.Location = New System.Drawing.Point(60, 227)
        Me.MetroLabel33.Name = "MetroLabel33"
        Me.MetroLabel33.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel33.TabIndex = 33
        Me.MetroLabel33.Text = "Street:"
        '
        'MetroLabel34
        '
        Me.MetroLabel34.AutoSize = True
        Me.MetroLabel34.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel34.Location = New System.Drawing.Point(45, 199)
        Me.MetroLabel34.Name = "MetroLabel34"
        Me.MetroLabel34.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel34.TabIndex = 32
        Me.MetroLabel34.Text = "Adress:"
        '
        'txtvEmailWork
        '
        '
        '
        '
        Me.txtvEmailWork.CustomButton.Image = Nothing
        Me.txtvEmailWork.CustomButton.Location = New System.Drawing.Point(334, 1)
        Me.txtvEmailWork.CustomButton.Name = ""
        Me.txtvEmailWork.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvEmailWork.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvEmailWork.CustomButton.TabIndex = 1
        Me.txtvEmailWork.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvEmailWork.CustomButton.UseSelectable = True
        Me.txtvEmailWork.CustomButton.Visible = False
        Me.txtvEmailWork.Lines = New String(-1) {}
        Me.txtvEmailWork.Location = New System.Drawing.Point(90, 155)
        Me.txtvEmailWork.MaxLength = 32767
        Me.txtvEmailWork.Name = "txtvEmailWork"
        Me.txtvEmailWork.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvEmailWork.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvEmailWork.SelectedText = ""
        Me.txtvEmailWork.SelectionLength = 0
        Me.txtvEmailWork.SelectionStart = 0
        Me.txtvEmailWork.ShortcutsEnabled = True
        Me.txtvEmailWork.Size = New System.Drawing.Size(356, 23)
        Me.txtvEmailWork.TabIndex = 5
        Me.txtvEmailWork.UseSelectable = True
        Me.txtvEmailWork.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvEmailWork.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtvFaxWork
        '
        '
        '
        '
        Me.txtvFaxWork.CustomButton.Image = Nothing
        Me.txtvFaxWork.CustomButton.Location = New System.Drawing.Point(334, 1)
        Me.txtvFaxWork.CustomButton.Name = ""
        Me.txtvFaxWork.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvFaxWork.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvFaxWork.CustomButton.TabIndex = 1
        Me.txtvFaxWork.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvFaxWork.CustomButton.UseSelectable = True
        Me.txtvFaxWork.CustomButton.Visible = False
        Me.txtvFaxWork.Lines = New String(-1) {}
        Me.txtvFaxWork.Location = New System.Drawing.Point(90, 126)
        Me.txtvFaxWork.MaxLength = 32767
        Me.txtvFaxWork.Name = "txtvFaxWork"
        Me.txtvFaxWork.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvFaxWork.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvFaxWork.SelectedText = ""
        Me.txtvFaxWork.SelectionLength = 0
        Me.txtvFaxWork.SelectionStart = 0
        Me.txtvFaxWork.ShortcutsEnabled = True
        Me.txtvFaxWork.Size = New System.Drawing.Size(356, 23)
        Me.txtvFaxWork.TabIndex = 4
        Me.txtvFaxWork.UseSelectable = True
        Me.txtvFaxWork.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvFaxWork.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel22
        '
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.Location = New System.Drawing.Point(7, 126)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel22.TabIndex = 20
        Me.MetroLabel22.Text = "Fax work:"
        '
        'txtvWebsiteWork
        '
        '
        '
        '
        Me.txtvWebsiteWork.CustomButton.Image = Nothing
        Me.txtvWebsiteWork.CustomButton.Location = New System.Drawing.Point(335, 1)
        Me.txtvWebsiteWork.CustomButton.Name = ""
        Me.txtvWebsiteWork.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvWebsiteWork.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvWebsiteWork.CustomButton.TabIndex = 1
        Me.txtvWebsiteWork.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvWebsiteWork.CustomButton.UseSelectable = True
        Me.txtvWebsiteWork.CustomButton.Visible = False
        Me.txtvWebsiteWork.Lines = New String(-1) {}
        Me.txtvWebsiteWork.Location = New System.Drawing.Point(89, 65)
        Me.txtvWebsiteWork.MaxLength = 32767
        Me.txtvWebsiteWork.Name = "txtvWebsiteWork"
        Me.txtvWebsiteWork.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvWebsiteWork.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvWebsiteWork.SelectedText = ""
        Me.txtvWebsiteWork.SelectionLength = 0
        Me.txtvWebsiteWork.SelectionStart = 0
        Me.txtvWebsiteWork.ShortcutsEnabled = True
        Me.txtvWebsiteWork.Size = New System.Drawing.Size(357, 23)
        Me.txtvWebsiteWork.TabIndex = 2
        Me.txtvWebsiteWork.UseSelectable = True
        Me.txtvWebsiteWork.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvWebsiteWork.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel24
        '
        Me.MetroLabel24.AutoSize = True
        Me.MetroLabel24.Location = New System.Drawing.Point(7, 155)
        Me.MetroLabel24.Name = "MetroLabel24"
        Me.MetroLabel24.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel24.TabIndex = 24
        Me.MetroLabel24.Text = "Email work:"
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(5, 65)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel19.TabIndex = 16
        Me.MetroLabel19.Text = "Homepage:"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(6, 96)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel15.TabIndex = 5
        Me.MetroLabel15.Text = "Tel. work:"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(6, 36)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel14.TabIndex = 4
        Me.MetroLabel14.Text = "Company:"
        '
        'txtvTelWork
        '
        '
        '
        '
        Me.txtvTelWork.CustomButton.Image = Nothing
        Me.txtvTelWork.CustomButton.Location = New System.Drawing.Point(334, 1)
        Me.txtvTelWork.CustomButton.Name = ""
        Me.txtvTelWork.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvTelWork.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvTelWork.CustomButton.TabIndex = 1
        Me.txtvTelWork.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvTelWork.CustomButton.UseSelectable = True
        Me.txtvTelWork.CustomButton.Visible = False
        Me.txtvTelWork.Lines = New String(-1) {}
        Me.txtvTelWork.Location = New System.Drawing.Point(90, 96)
        Me.txtvTelWork.MaxLength = 32767
        Me.txtvTelWork.Name = "txtvTelWork"
        Me.txtvTelWork.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvTelWork.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvTelWork.SelectedText = ""
        Me.txtvTelWork.SelectionLength = 0
        Me.txtvTelWork.SelectionStart = 0
        Me.txtvTelWork.ShortcutsEnabled = True
        Me.txtvTelWork.Size = New System.Drawing.Size(356, 23)
        Me.txtvTelWork.TabIndex = 3
        Me.txtvTelWork.UseSelectable = True
        Me.txtvTelWork.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvTelWork.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtvTitle
        '
        '
        '
        '
        Me.txtvTitle.CustomButton.Image = Nothing
        Me.txtvTitle.CustomButton.Location = New System.Drawing.Point(129, 1)
        Me.txtvTitle.CustomButton.Name = ""
        Me.txtvTitle.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvTitle.CustomButton.TabIndex = 1
        Me.txtvTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvTitle.CustomButton.UseSelectable = True
        Me.txtvTitle.CustomButton.Visible = False
        Me.txtvTitle.Lines = New String(-1) {}
        Me.txtvTitle.Location = New System.Drawing.Point(295, 36)
        Me.txtvTitle.MaxLength = 32767
        Me.txtvTitle.Name = "txtvTitle"
        Me.txtvTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvTitle.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvTitle.SelectedText = ""
        Me.txtvTitle.SelectionLength = 0
        Me.txtvTitle.SelectionStart = 0
        Me.txtvTitle.ShortcutsEnabled = True
        Me.txtvTitle.Size = New System.Drawing.Size(151, 23)
        Me.txtvTitle.TabIndex = 1
        Me.txtvTitle.UseSelectable = True
        Me.txtvTitle.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvTitle.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtvOrganisation
        '
        '
        '
        '
        Me.txtvOrganisation.CustomButton.Image = Nothing
        Me.txtvOrganisation.CustomButton.Location = New System.Drawing.Point(129, 1)
        Me.txtvOrganisation.CustomButton.Name = ""
        Me.txtvOrganisation.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvOrganisation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvOrganisation.CustomButton.TabIndex = 1
        Me.txtvOrganisation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvOrganisation.CustomButton.UseSelectable = True
        Me.txtvOrganisation.CustomButton.Visible = False
        Me.txtvOrganisation.Lines = New String(-1) {}
        Me.txtvOrganisation.Location = New System.Drawing.Point(89, 36)
        Me.txtvOrganisation.MaxLength = 32767
        Me.txtvOrganisation.Name = "txtvOrganisation"
        Me.txtvOrganisation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvOrganisation.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvOrganisation.SelectedText = ""
        Me.txtvOrganisation.SelectionLength = 0
        Me.txtvOrganisation.SelectionStart = 0
        Me.txtvOrganisation.ShortcutsEnabled = True
        Me.txtvOrganisation.Size = New System.Drawing.Size(151, 23)
        Me.txtvOrganisation.TabIndex = 0
        Me.txtvOrganisation.UseSelectable = True
        Me.txtvOrganisation.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvOrganisation.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Location = New System.Drawing.Point(255, 36)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(36, 19)
        Me.MetroLabel18.TabIndex = 8
        Me.MetroLabel18.Text = "Title:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chkvYear)
        Me.GroupBox1.Controls.Add(Me.chkvMonth)
        Me.GroupBox1.Controls.Add(Me.chkvDay)
        Me.GroupBox1.Controls.Add(Me.MetroLabel36)
        Me.GroupBox1.Controls.Add(Me.txtvCellphonePrivate)
        Me.GroupBox1.Controls.Add(Me.MetroLabel35)
        Me.GroupBox1.Controls.Add(Me.cmbvCountryPrivate)
        Me.GroupBox1.Controls.Add(Me.MetroLabel29)
        Me.GroupBox1.Controls.Add(Me.txtvCityPrivate)
        Me.GroupBox1.Controls.Add(Me.MetroLabel28)
        Me.GroupBox1.Controls.Add(Me.txtvPostalPrivate)
        Me.GroupBox1.Controls.Add(Me.MetroLabel27)
        Me.GroupBox1.Controls.Add(Me.txtvStreetPrivate)
        Me.GroupBox1.Controls.Add(Me.MetroLabel26)
        Me.GroupBox1.Controls.Add(Me.MetroLabel25)
        Me.GroupBox1.Controls.Add(Me.txtvFaxPrivate)
        Me.GroupBox1.Controls.Add(Me.MetroLabel23)
        Me.GroupBox1.Controls.Add(Me.txtvWebsitePrivate)
        Me.GroupBox1.Controls.Add(Me.MetroLabel21)
        Me.GroupBox1.Controls.Add(Me.txtvTelPrivate)
        Me.GroupBox1.Controls.Add(Me.MetroLabel12)
        Me.GroupBox1.Controls.Add(Me.MetroLabel13)
        Me.GroupBox1.Controls.Add(Me.MetroLabel16)
        Me.GroupBox1.Controls.Add(Me.txtvEmailPrivate)
        Me.GroupBox1.Controls.Add(Me.MetroLabel17)
        Me.GroupBox1.Controls.Add(Me.txtvFamilyName)
        Me.GroupBox1.Controls.Add(Me.txtvGivenName)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(89, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 442)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information:"
        '
        'chkvYear
        '
        Me.chkvYear.FormattingEnabled = True
        Me.chkvYear.ItemHeight = 23
        Me.chkvYear.Location = New System.Drawing.Point(319, 248)
        Me.chkvYear.Name = "chkvYear"
        Me.chkvYear.Size = New System.Drawing.Size(127, 29)
        Me.chkvYear.TabIndex = 9
        Me.chkvYear.UseSelectable = True
        '
        'chkvMonth
        '
        Me.chkvMonth.FormattingEnabled = True
        Me.chkvMonth.ItemHeight = 23
        Me.chkvMonth.Location = New System.Drawing.Point(211, 248)
        Me.chkvMonth.Name = "chkvMonth"
        Me.chkvMonth.Size = New System.Drawing.Size(86, 29)
        Me.chkvMonth.TabIndex = 8
        Me.chkvMonth.UseSelectable = True
        '
        'chkvDay
        '
        Me.chkvDay.FormattingEnabled = True
        Me.chkvDay.ItemHeight = 23
        Me.chkvDay.Location = New System.Drawing.Point(101, 248)
        Me.chkvDay.Name = "chkvDay"
        Me.chkvDay.Size = New System.Drawing.Size(86, 29)
        Me.chkvDay.TabIndex = 7
        Me.chkvDay.UseSelectable = True
        '
        'MetroLabel36
        '
        Me.MetroLabel36.AutoSize = True
        Me.MetroLabel36.Location = New System.Drawing.Point(7, 254)
        Me.MetroLabel36.Name = "MetroLabel36"
        Me.MetroLabel36.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel36.TabIndex = 34
        Me.MetroLabel36.Text = "Date of Birth:"
        Me.MetroLabel36.UseCustomBackColor = True
        '
        'txtvCellphonePrivate
        '
        '
        '
        '
        Me.txtvCellphonePrivate.CustomButton.Image = Nothing
        Me.txtvCellphonePrivate.CustomButton.Location = New System.Drawing.Point(323, 1)
        Me.txtvCellphonePrivate.CustomButton.Name = ""
        Me.txtvCellphonePrivate.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvCellphonePrivate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvCellphonePrivate.CustomButton.TabIndex = 1
        Me.txtvCellphonePrivate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvCellphonePrivate.CustomButton.UseSelectable = True
        Me.txtvCellphonePrivate.CustomButton.Visible = False
        Me.txtvCellphonePrivate.Lines = New String(-1) {}
        Me.txtvCellphonePrivate.Location = New System.Drawing.Point(101, 154)
        Me.txtvCellphonePrivate.MaxLength = 32767
        Me.txtvCellphonePrivate.Name = "txtvCellphonePrivate"
        Me.txtvCellphonePrivate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvCellphonePrivate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvCellphonePrivate.SelectedText = ""
        Me.txtvCellphonePrivate.SelectionLength = 0
        Me.txtvCellphonePrivate.SelectionStart = 0
        Me.txtvCellphonePrivate.ShortcutsEnabled = True
        Me.txtvCellphonePrivate.Size = New System.Drawing.Size(345, 23)
        Me.txtvCellphonePrivate.TabIndex = 4
        Me.txtvCellphonePrivate.UseSelectable = True
        Me.txtvCellphonePrivate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvCellphonePrivate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel35
        '
        Me.MetroLabel35.AutoSize = True
        Me.MetroLabel35.Location = New System.Drawing.Point(7, 155)
        Me.MetroLabel35.Name = "MetroLabel35"
        Me.MetroLabel35.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel35.TabIndex = 32
        Me.MetroLabel35.Text = "Cellphone:"
        Me.MetroLabel35.UseCustomBackColor = True
        '
        'cmbvCountryPrivate
        '
        Me.cmbvCountryPrivate.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbvCountryPrivate.FormattingEnabled = True
        Me.cmbvCountryPrivate.ItemHeight = 19
        Me.cmbvCountryPrivate.Location = New System.Drawing.Point(138, 398)
        Me.cmbvCountryPrivate.Name = "cmbvCountryPrivate"
        Me.cmbvCountryPrivate.Size = New System.Drawing.Size(251, 25)
        Me.cmbvCountryPrivate.TabIndex = 13
        Me.cmbvCountryPrivate.UseSelectable = True
        '
        'MetroLabel29
        '
        Me.MetroLabel29.AutoSize = True
        Me.MetroLabel29.Location = New System.Drawing.Point(60, 398)
        Me.MetroLabel29.Name = "MetroLabel29"
        Me.MetroLabel29.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel29.TabIndex = 30
        Me.MetroLabel29.Text = "Country:"
        Me.MetroLabel29.UseCustomBackColor = True
        '
        'txtvCityPrivate
        '
        '
        '
        '
        Me.txtvCityPrivate.CustomButton.Image = Nothing
        Me.txtvCityPrivate.CustomButton.Location = New System.Drawing.Point(229, 1)
        Me.txtvCityPrivate.CustomButton.Name = ""
        Me.txtvCityPrivate.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvCityPrivate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvCityPrivate.CustomButton.TabIndex = 1
        Me.txtvCityPrivate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvCityPrivate.CustomButton.UseSelectable = True
        Me.txtvCityPrivate.CustomButton.Visible = False
        Me.txtvCityPrivate.Lines = New String(-1) {}
        Me.txtvCityPrivate.Location = New System.Drawing.Point(138, 372)
        Me.txtvCityPrivate.MaxLength = 32767
        Me.txtvCityPrivate.Name = "txtvCityPrivate"
        Me.txtvCityPrivate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvCityPrivate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvCityPrivate.SelectedText = ""
        Me.txtvCityPrivate.SelectionLength = 0
        Me.txtvCityPrivate.SelectionStart = 0
        Me.txtvCityPrivate.ShortcutsEnabled = True
        Me.txtvCityPrivate.Size = New System.Drawing.Size(251, 23)
        Me.txtvCityPrivate.TabIndex = 12
        Me.txtvCityPrivate.UseSelectable = True
        Me.txtvCityPrivate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvCityPrivate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel28
        '
        Me.MetroLabel28.AutoSize = True
        Me.MetroLabel28.Location = New System.Drawing.Point(60, 372)
        Me.MetroLabel28.Name = "MetroLabel28"
        Me.MetroLabel28.Size = New System.Drawing.Size(34, 19)
        Me.MetroLabel28.TabIndex = 28
        Me.MetroLabel28.Text = "City:"
        Me.MetroLabel28.UseCustomBackColor = True
        '
        'txtvPostalPrivate
        '
        '
        '
        '
        Me.txtvPostalPrivate.CustomButton.Image = Nothing
        Me.txtvPostalPrivate.CustomButton.Location = New System.Drawing.Point(229, 1)
        Me.txtvPostalPrivate.CustomButton.Name = ""
        Me.txtvPostalPrivate.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvPostalPrivate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvPostalPrivate.CustomButton.TabIndex = 1
        Me.txtvPostalPrivate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvPostalPrivate.CustomButton.UseSelectable = True
        Me.txtvPostalPrivate.CustomButton.Visible = False
        Me.txtvPostalPrivate.Lines = New String(-1) {}
        Me.txtvPostalPrivate.Location = New System.Drawing.Point(138, 346)
        Me.txtvPostalPrivate.MaxLength = 32767
        Me.txtvPostalPrivate.Name = "txtvPostalPrivate"
        Me.txtvPostalPrivate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvPostalPrivate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvPostalPrivate.SelectedText = ""
        Me.txtvPostalPrivate.SelectionLength = 0
        Me.txtvPostalPrivate.SelectionStart = 0
        Me.txtvPostalPrivate.ShortcutsEnabled = True
        Me.txtvPostalPrivate.Size = New System.Drawing.Size(251, 23)
        Me.txtvPostalPrivate.TabIndex = 11
        Me.txtvPostalPrivate.UseSelectable = True
        Me.txtvPostalPrivate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvPostalPrivate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel27
        '
        Me.MetroLabel27.AutoSize = True
        Me.MetroLabel27.Location = New System.Drawing.Point(60, 346)
        Me.MetroLabel27.Name = "MetroLabel27"
        Me.MetroLabel27.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel27.TabIndex = 26
        Me.MetroLabel27.Text = "Postal:"
        Me.MetroLabel27.UseCustomBackColor = True
        '
        'txtvStreetPrivate
        '
        '
        '
        '
        Me.txtvStreetPrivate.CustomButton.Image = Nothing
        Me.txtvStreetPrivate.CustomButton.Location = New System.Drawing.Point(229, 1)
        Me.txtvStreetPrivate.CustomButton.Name = ""
        Me.txtvStreetPrivate.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvStreetPrivate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvStreetPrivate.CustomButton.TabIndex = 1
        Me.txtvStreetPrivate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvStreetPrivate.CustomButton.UseSelectable = True
        Me.txtvStreetPrivate.CustomButton.Visible = False
        Me.txtvStreetPrivate.Lines = New String(-1) {}
        Me.txtvStreetPrivate.Location = New System.Drawing.Point(138, 320)
        Me.txtvStreetPrivate.MaxLength = 32767
        Me.txtvStreetPrivate.Name = "txtvStreetPrivate"
        Me.txtvStreetPrivate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvStreetPrivate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvStreetPrivate.SelectedText = ""
        Me.txtvStreetPrivate.SelectionLength = 0
        Me.txtvStreetPrivate.SelectionStart = 0
        Me.txtvStreetPrivate.ShortcutsEnabled = True
        Me.txtvStreetPrivate.Size = New System.Drawing.Size(251, 23)
        Me.txtvStreetPrivate.TabIndex = 10
        Me.txtvStreetPrivate.UseSelectable = True
        Me.txtvStreetPrivate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvStreetPrivate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel26
        '
        Me.MetroLabel26.AutoSize = True
        Me.MetroLabel26.Location = New System.Drawing.Point(60, 320)
        Me.MetroLabel26.Name = "MetroLabel26"
        Me.MetroLabel26.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel26.TabIndex = 24
        Me.MetroLabel26.Text = "Street:"
        Me.MetroLabel26.UseCustomBackColor = True
        '
        'MetroLabel25
        '
        Me.MetroLabel25.AutoSize = True
        Me.MetroLabel25.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel25.Location = New System.Drawing.Point(45, 292)
        Me.MetroLabel25.Name = "MetroLabel25"
        Me.MetroLabel25.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel25.TabIndex = 23
        Me.MetroLabel25.Text = "Adress:"
        Me.MetroLabel25.UseCustomBackColor = True
        '
        'txtvFaxPrivate
        '
        '
        '
        '
        Me.txtvFaxPrivate.CustomButton.Image = Nothing
        Me.txtvFaxPrivate.CustomButton.Location = New System.Drawing.Point(323, 1)
        Me.txtvFaxPrivate.CustomButton.Name = ""
        Me.txtvFaxPrivate.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvFaxPrivate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvFaxPrivate.CustomButton.TabIndex = 1
        Me.txtvFaxPrivate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvFaxPrivate.CustomButton.UseSelectable = True
        Me.txtvFaxPrivate.CustomButton.Visible = False
        Me.txtvFaxPrivate.Lines = New String(-1) {}
        Me.txtvFaxPrivate.Location = New System.Drawing.Point(101, 188)
        Me.txtvFaxPrivate.MaxLength = 32767
        Me.txtvFaxPrivate.Name = "txtvFaxPrivate"
        Me.txtvFaxPrivate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvFaxPrivate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvFaxPrivate.SelectedText = ""
        Me.txtvFaxPrivate.SelectionLength = 0
        Me.txtvFaxPrivate.SelectionStart = 0
        Me.txtvFaxPrivate.ShortcutsEnabled = True
        Me.txtvFaxPrivate.Size = New System.Drawing.Size(345, 23)
        Me.txtvFaxPrivate.TabIndex = 5
        Me.txtvFaxPrivate.UseSelectable = True
        Me.txtvFaxPrivate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvFaxPrivate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel23
        '
        Me.MetroLabel23.AutoSize = True
        Me.MetroLabel23.Location = New System.Drawing.Point(7, 188)
        Me.MetroLabel23.Name = "MetroLabel23"
        Me.MetroLabel23.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel23.TabIndex = 21
        Me.MetroLabel23.Text = "Fax-Number::"
        Me.MetroLabel23.UseCustomBackColor = True
        '
        'txtvWebsitePrivate
        '
        '
        '
        '
        Me.txtvWebsitePrivate.CustomButton.Image = Nothing
        Me.txtvWebsitePrivate.CustomButton.Location = New System.Drawing.Point(323, 1)
        Me.txtvWebsitePrivate.CustomButton.Name = ""
        Me.txtvWebsitePrivate.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvWebsitePrivate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvWebsitePrivate.CustomButton.TabIndex = 1
        Me.txtvWebsitePrivate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvWebsitePrivate.CustomButton.UseSelectable = True
        Me.txtvWebsitePrivate.CustomButton.Visible = False
        Me.txtvWebsitePrivate.Lines = New String(-1) {}
        Me.txtvWebsitePrivate.Location = New System.Drawing.Point(101, 92)
        Me.txtvWebsitePrivate.MaxLength = 32767
        Me.txtvWebsitePrivate.Name = "txtvWebsitePrivate"
        Me.txtvWebsitePrivate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvWebsitePrivate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvWebsitePrivate.SelectedText = ""
        Me.txtvWebsitePrivate.SelectionLength = 0
        Me.txtvWebsitePrivate.SelectionStart = 0
        Me.txtvWebsitePrivate.ShortcutsEnabled = True
        Me.txtvWebsitePrivate.Size = New System.Drawing.Size(345, 23)
        Me.txtvWebsitePrivate.TabIndex = 2
        Me.txtvWebsitePrivate.UseSelectable = True
        Me.txtvWebsitePrivate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvWebsitePrivate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.Location = New System.Drawing.Point(6, 92)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel21.TabIndex = 17
        Me.MetroLabel21.Text = "Homepage:"
        Me.MetroLabel21.UseCustomBackColor = True
        '
        'txtvTelPrivate
        '
        '
        '
        '
        Me.txtvTelPrivate.CustomButton.Image = Nothing
        Me.txtvTelPrivate.CustomButton.Location = New System.Drawing.Point(323, 1)
        Me.txtvTelPrivate.CustomButton.Name = ""
        Me.txtvTelPrivate.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvTelPrivate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvTelPrivate.CustomButton.TabIndex = 1
        Me.txtvTelPrivate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvTelPrivate.CustomButton.UseSelectable = True
        Me.txtvTelPrivate.CustomButton.Visible = False
        Me.txtvTelPrivate.Lines = New String(-1) {}
        Me.txtvTelPrivate.Location = New System.Drawing.Point(101, 122)
        Me.txtvTelPrivate.MaxLength = 32767
        Me.txtvTelPrivate.Name = "txtvTelPrivate"
        Me.txtvTelPrivate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvTelPrivate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvTelPrivate.SelectedText = ""
        Me.txtvTelPrivate.SelectionLength = 0
        Me.txtvTelPrivate.SelectionStart = 0
        Me.txtvTelPrivate.ShortcutsEnabled = True
        Me.txtvTelPrivate.Size = New System.Drawing.Size(345, 23)
        Me.txtvTelPrivate.TabIndex = 3
        Me.txtvTelPrivate.UseSelectable = True
        Me.txtvTelPrivate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvTelPrivate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(6, 31)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel12.TabIndex = 2
        Me.MetroLabel12.Text = "First Name: *"
        Me.MetroLabel12.UseCustomBackColor = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(6, 64)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel13.TabIndex = 3
        Me.MetroLabel13.Text = "Last Name: *"
        Me.MetroLabel13.UseCustomBackColor = True
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(6, 121)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel16.TabIndex = 6
        Me.MetroLabel16.Text = "Telephone:"
        Me.MetroLabel16.UseCustomBackColor = True
        '
        'txtvEmailPrivate
        '
        '
        '
        '
        Me.txtvEmailPrivate.CustomButton.Image = Nothing
        Me.txtvEmailPrivate.CustomButton.Location = New System.Drawing.Point(323, 1)
        Me.txtvEmailPrivate.CustomButton.Name = ""
        Me.txtvEmailPrivate.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvEmailPrivate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvEmailPrivate.CustomButton.TabIndex = 1
        Me.txtvEmailPrivate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvEmailPrivate.CustomButton.UseSelectable = True
        Me.txtvEmailPrivate.CustomButton.Visible = False
        Me.txtvEmailPrivate.Lines = New String(-1) {}
        Me.txtvEmailPrivate.Location = New System.Drawing.Point(101, 219)
        Me.txtvEmailPrivate.MaxLength = 32767
        Me.txtvEmailPrivate.Name = "txtvEmailPrivate"
        Me.txtvEmailPrivate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvEmailPrivate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvEmailPrivate.SelectedText = ""
        Me.txtvEmailPrivate.SelectionLength = 0
        Me.txtvEmailPrivate.SelectionStart = 0
        Me.txtvEmailPrivate.ShortcutsEnabled = True
        Me.txtvEmailPrivate.Size = New System.Drawing.Size(345, 23)
        Me.txtvEmailPrivate.TabIndex = 6
        Me.txtvEmailPrivate.UseSelectable = True
        Me.txtvEmailPrivate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvEmailPrivate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(7, 219)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel17.TabIndex = 7
        Me.MetroLabel17.Text = "E-Mail:"
        Me.MetroLabel17.UseCustomBackColor = True
        '
        'txtvFamilyName
        '
        '
        '
        '
        Me.txtvFamilyName.CustomButton.Image = Nothing
        Me.txtvFamilyName.CustomButton.Location = New System.Drawing.Point(188, 1)
        Me.txtvFamilyName.CustomButton.Name = ""
        Me.txtvFamilyName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvFamilyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvFamilyName.CustomButton.TabIndex = 1
        Me.txtvFamilyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvFamilyName.CustomButton.UseSelectable = True
        Me.txtvFamilyName.CustomButton.Visible = False
        Me.txtvFamilyName.Lines = New String(-1) {}
        Me.txtvFamilyName.Location = New System.Drawing.Point(101, 60)
        Me.txtvFamilyName.MaxLength = 32767
        Me.txtvFamilyName.Name = "txtvFamilyName"
        Me.txtvFamilyName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvFamilyName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvFamilyName.SelectedText = ""
        Me.txtvFamilyName.SelectionLength = 0
        Me.txtvFamilyName.SelectionStart = 0
        Me.txtvFamilyName.ShortcutsEnabled = True
        Me.txtvFamilyName.Size = New System.Drawing.Size(210, 23)
        Me.txtvFamilyName.TabIndex = 1
        Me.txtvFamilyName.UseSelectable = True
        Me.txtvFamilyName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvFamilyName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtvGivenName
        '
        '
        '
        '
        Me.txtvGivenName.CustomButton.Image = Nothing
        Me.txtvGivenName.CustomButton.Location = New System.Drawing.Point(188, 1)
        Me.txtvGivenName.CustomButton.Name = ""
        Me.txtvGivenName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtvGivenName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtvGivenName.CustomButton.TabIndex = 1
        Me.txtvGivenName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtvGivenName.CustomButton.UseSelectable = True
        Me.txtvGivenName.CustomButton.Visible = False
        Me.txtvGivenName.Lines = New String(-1) {}
        Me.txtvGivenName.Location = New System.Drawing.Point(101, 31)
        Me.txtvGivenName.MaxLength = 32767
        Me.txtvGivenName.Name = "txtvGivenName"
        Me.txtvGivenName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtvGivenName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtvGivenName.SelectedText = ""
        Me.txtvGivenName.SelectionLength = 0
        Me.txtvGivenName.SelectionStart = 0
        Me.txtvGivenName.ShortcutsEnabled = True
        Me.txtvGivenName.Size = New System.Drawing.Size(210, 23)
        Me.txtvGivenName.TabIndex = 0
        Me.txtvGivenName.UseSelectable = True
        Me.txtvGivenName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtvGivenName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tabPhone
        '
        Me.tabPhone.BackColor = System.Drawing.Color.Transparent
        Me.tabPhone.BackgroundImage = Global.QR_Code.My.Resources.Resources.phone_64
        Me.tabPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tabPhone.Controls.Add(Me.GroupBox2)
        Me.tabPhone.Controls.Add(Me.btnAddPhoneNumber)
        Me.tabPhone.Controls.Add(Me.MetroLabel11)
        Me.tabPhone.Controls.Add(Me.txtPhoneNumber)
        Me.tabPhone.HorizontalScrollbarBarColor = True
        Me.tabPhone.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPhone.HorizontalScrollbarSize = 10
        Me.tabPhone.Location = New System.Drawing.Point(4, 38)
        Me.tabPhone.Name = "tabPhone"
        Me.tabPhone.Size = New System.Drawing.Size(610, 282)
        Me.tabPhone.TabIndex = 3
        Me.tabPhone.Text = "Phone Number"
        Me.tabPhone.VerticalScrollbarBarColor = True
        Me.tabPhone.VerticalScrollbarHighlightOnWheel = False
        Me.tabPhone.VerticalScrollbarSize = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvPhoneBook)
        Me.GroupBox2.Location = New System.Drawing.Point(97, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox2.Size = New System.Drawing.Size(442, 184)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Phonebook"
        '
        'lvPhoneBook
        '
        Me.lvPhoneBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvPhoneBook.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colPhoneNumber})
        Me.lvPhoneBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPhoneBook.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPhoneBook.FullRowSelect = True
        Me.lvPhoneBook.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvPhoneBook.Location = New System.Drawing.Point(10, 24)
        Me.lvPhoneBook.MultiSelect = False
        Me.lvPhoneBook.Name = "lvPhoneBook"
        Me.lvPhoneBook.Size = New System.Drawing.Size(422, 150)
        Me.lvPhoneBook.TabIndex = 5
        Me.lvPhoneBook.UseCompatibleStateImageBehavior = False
        Me.lvPhoneBook.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Text = "Name"
        '
        'colPhoneNumber
        '
        Me.colPhoneNumber.Text = "Phone Number"
        '
        'btnAddPhoneNumber
        '
        Me.btnAddPhoneNumber.Location = New System.Drawing.Point(502, 44)
        Me.btnAddPhoneNumber.Name = "btnAddPhoneNumber"
        Me.btnAddPhoneNumber.Size = New System.Drawing.Size(37, 32)
        Me.btnAddPhoneNumber.TabIndex = 5
        Me.btnAddPhoneNumber.Text = "Add"
        Me.btnAddPhoneNumber.UseSelectable = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel11.Location = New System.Drawing.Point(97, 48)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(134, 25)
        Me.MetroLabel11.TabIndex = 3
        Me.MetroLabel11.Text = "Phone Number:"
        Me.MetroLabel11.UseCustomBackColor = True
        '
        'txtPhoneNumber
        '
        '
        '
        '
        Me.txtPhoneNumber.CustomButton.Image = Nothing
        Me.txtPhoneNumber.CustomButton.Location = New System.Drawing.Point(229, 2)
        Me.txtPhoneNumber.CustomButton.Name = ""
        Me.txtPhoneNumber.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtPhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhoneNumber.CustomButton.TabIndex = 1
        Me.txtPhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhoneNumber.CustomButton.UseSelectable = True
        Me.txtPhoneNumber.CustomButton.Visible = False
        Me.txtPhoneNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtPhoneNumber.Lines = New String(-1) {}
        Me.txtPhoneNumber.Location = New System.Drawing.Point(237, 44)
        Me.txtPhoneNumber.MaxLength = 32767
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhoneNumber.SelectedText = ""
        Me.txtPhoneNumber.SelectionLength = 0
        Me.txtPhoneNumber.SelectionStart = 0
        Me.txtPhoneNumber.ShortcutsEnabled = True
        Me.txtPhoneNumber.Size = New System.Drawing.Size(259, 32)
        Me.txtPhoneNumber.TabIndex = 2
        Me.txtPhoneNumber.UseSelectable = True
        Me.txtPhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhoneNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tabEmail
        '
        Me.tabEmail.BackColor = System.Drawing.Color.Transparent
        Me.tabEmail.BackgroundImage = Global.QR_Code.My.Resources.Resources.email_64
        Me.tabEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tabEmail.Controls.Add(Me.txtBody)
        Me.tabEmail.Controls.Add(Me.txtSubject)
        Me.tabEmail.Controls.Add(Me.txtRecipient)
        Me.tabEmail.Controls.Add(Me.MetroLabel10)
        Me.tabEmail.Controls.Add(Me.MetroLabel9)
        Me.tabEmail.Controls.Add(Me.MetroLabel8)
        Me.tabEmail.HorizontalScrollbarBarColor = True
        Me.tabEmail.HorizontalScrollbarHighlightOnWheel = False
        Me.tabEmail.HorizontalScrollbarSize = 10
        Me.tabEmail.Location = New System.Drawing.Point(4, 38)
        Me.tabEmail.Name = "tabEmail"
        Me.tabEmail.Size = New System.Drawing.Size(610, 282)
        Me.tabEmail.TabIndex = 4
        Me.tabEmail.Text = "E-Mail"
        Me.tabEmail.VerticalScrollbarBarColor = True
        Me.tabEmail.VerticalScrollbarHighlightOnWheel = False
        Me.tabEmail.VerticalScrollbarSize = 10
        '
        'txtBody
        '
        '
        '
        '
        Me.txtBody.CustomButton.Image = Nothing
        Me.txtBody.CustomButton.Location = New System.Drawing.Point(206, 2)
        Me.txtBody.CustomButton.Name = ""
        Me.txtBody.CustomButton.Size = New System.Drawing.Size(125, 125)
        Me.txtBody.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBody.CustomButton.TabIndex = 1
        Me.txtBody.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBody.CustomButton.UseSelectable = True
        Me.txtBody.CustomButton.Visible = False
        Me.txtBody.Lines = New String(-1) {}
        Me.txtBody.Location = New System.Drawing.Point(201, 109)
        Me.txtBody.MaxLength = 32767
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBody.SelectedText = ""
        Me.txtBody.SelectionLength = 0
        Me.txtBody.SelectionStart = 0
        Me.txtBody.ShortcutsEnabled = True
        Me.txtBody.Size = New System.Drawing.Size(334, 130)
        Me.txtBody.TabIndex = 8
        Me.txtBody.UseSelectable = True
        Me.txtBody.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBody.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSubject
        '
        '
        '
        '
        Me.txtSubject.CustomButton.Image = Nothing
        Me.txtSubject.CustomButton.Location = New System.Drawing.Point(211, 1)
        Me.txtSubject.CustomButton.Name = ""
        Me.txtSubject.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSubject.CustomButton.TabIndex = 1
        Me.txtSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSubject.CustomButton.UseSelectable = True
        Me.txtSubject.CustomButton.Visible = False
        Me.txtSubject.Lines = New String(-1) {}
        Me.txtSubject.Location = New System.Drawing.Point(201, 75)
        Me.txtSubject.MaxLength = 32767
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSubject.SelectedText = ""
        Me.txtSubject.SelectionLength = 0
        Me.txtSubject.SelectionStart = 0
        Me.txtSubject.ShortcutsEnabled = True
        Me.txtSubject.Size = New System.Drawing.Size(233, 23)
        Me.txtSubject.TabIndex = 7
        Me.txtSubject.UseSelectable = True
        Me.txtSubject.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSubject.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtRecipient
        '
        '
        '
        '
        Me.txtRecipient.CustomButton.Image = Nothing
        Me.txtRecipient.CustomButton.Location = New System.Drawing.Point(211, 1)
        Me.txtRecipient.CustomButton.Name = ""
        Me.txtRecipient.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtRecipient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRecipient.CustomButton.TabIndex = 1
        Me.txtRecipient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRecipient.CustomButton.UseSelectable = True
        Me.txtRecipient.CustomButton.Visible = False
        Me.txtRecipient.Lines = New String(-1) {}
        Me.txtRecipient.Location = New System.Drawing.Point(201, 41)
        Me.txtRecipient.MaxLength = 32767
        Me.txtRecipient.Name = "txtRecipient"
        Me.txtRecipient.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRecipient.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRecipient.SelectedText = ""
        Me.txtRecipient.SelectionLength = 0
        Me.txtRecipient.SelectionStart = 0
        Me.txtRecipient.ShortcutsEnabled = True
        Me.txtRecipient.Size = New System.Drawing.Size(233, 23)
        Me.txtRecipient.TabIndex = 6
        Me.txtRecipient.UseSelectable = True
        Me.txtRecipient.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRecipient.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel10.Location = New System.Drawing.Point(130, 109)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel10.TabIndex = 5
        Me.MetroLabel10.Text = "Body:"
        Me.MetroLabel10.UseCustomBackColor = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel9.Location = New System.Drawing.Point(130, 75)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel9.TabIndex = 4
        Me.MetroLabel9.Text = "Subject:"
        Me.MetroLabel9.UseCustomBackColor = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel8.Location = New System.Drawing.Point(130, 41)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel8.TabIndex = 3
        Me.MetroLabel8.Text = "Recipient:"
        Me.MetroLabel8.UseCustomBackColor = True
        '
        'tabSMS
        '
        Me.tabSMS.BackColor = System.Drawing.Color.Transparent
        Me.tabSMS.BackgroundImage = Global.QR_Code.My.Resources.Resources._1459370524_SMS
        Me.tabSMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tabSMS.Controls.Add(Me.MetroLabel7)
        Me.tabSMS.Controls.Add(Me.MetroLabel6)
        Me.tabSMS.Controls.Add(Me.txtSMSMSG)
        Me.tabSMS.Controls.Add(Me.txtSMSTO)
        Me.tabSMS.HorizontalScrollbarBarColor = True
        Me.tabSMS.HorizontalScrollbarHighlightOnWheel = False
        Me.tabSMS.HorizontalScrollbarSize = 10
        Me.tabSMS.Location = New System.Drawing.Point(4, 38)
        Me.tabSMS.Name = "tabSMS"
        Me.tabSMS.Size = New System.Drawing.Size(610, 282)
        Me.tabSMS.TabIndex = 5
        Me.tabSMS.Text = "SMS"
        Me.tabSMS.UseCustomBackColor = True
        Me.tabSMS.VerticalScrollbarBarColor = True
        Me.tabSMS.VerticalScrollbarHighlightOnWheel = False
        Me.tabSMS.VerticalScrollbarSize = 10
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.Location = New System.Drawing.Point(95, 93)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel7.TabIndex = 5
        Me.MetroLabel7.Text = "SMS Message:"
        Me.MetroLabel7.UseCustomBackColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.Location = New System.Drawing.Point(95, 49)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(103, 19)
        Me.MetroLabel6.TabIndex = 4
        Me.MetroLabel6.Text = "Phone Number:"
        Me.MetroLabel6.UseCustomBackColor = True
        '
        'txtSMSMSG
        '
        '
        '
        '
        Me.txtSMSMSG.CustomButton.Image = Nothing
        Me.txtSMSMSG.CustomButton.Location = New System.Drawing.Point(189, 2)
        Me.txtSMSMSG.CustomButton.Name = ""
        Me.txtSMSMSG.CustomButton.Size = New System.Drawing.Size(141, 141)
        Me.txtSMSMSG.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSMSMSG.CustomButton.TabIndex = 1
        Me.txtSMSMSG.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSMSMSG.CustomButton.UseSelectable = True
        Me.txtSMSMSG.CustomButton.Visible = False
        Me.txtSMSMSG.Lines = New String(-1) {}
        Me.txtSMSMSG.Location = New System.Drawing.Point(201, 89)
        Me.txtSMSMSG.MaxLength = 32767
        Me.txtSMSMSG.Multiline = True
        Me.txtSMSMSG.Name = "txtSMSMSG"
        Me.txtSMSMSG.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSMSMSG.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSMSMSG.SelectedText = ""
        Me.txtSMSMSG.SelectionLength = 0
        Me.txtSMSMSG.SelectionStart = 0
        Me.txtSMSMSG.ShortcutsEnabled = True
        Me.txtSMSMSG.Size = New System.Drawing.Size(333, 146)
        Me.txtSMSMSG.TabIndex = 3
        Me.txtSMSMSG.UseSelectable = True
        Me.txtSMSMSG.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSMSMSG.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSMSTO
        '
        '
        '
        '
        Me.txtSMSTO.CustomButton.Image = Nothing
        Me.txtSMSTO.CustomButton.Location = New System.Drawing.Point(311, 1)
        Me.txtSMSTO.CustomButton.Name = ""
        Me.txtSMSTO.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSMSTO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSMSTO.CustomButton.TabIndex = 1
        Me.txtSMSTO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSMSTO.CustomButton.UseSelectable = True
        Me.txtSMSTO.CustomButton.Visible = False
        Me.txtSMSTO.Lines = New String(-1) {}
        Me.txtSMSTO.Location = New System.Drawing.Point(201, 49)
        Me.txtSMSTO.MaxLength = 32767
        Me.txtSMSTO.Name = "txtSMSTO"
        Me.txtSMSTO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSMSTO.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSMSTO.SelectedText = ""
        Me.txtSMSTO.SelectionLength = 0
        Me.txtSMSTO.SelectionStart = 0
        Me.txtSMSTO.ShortcutsEnabled = True
        Me.txtSMSTO.Size = New System.Drawing.Size(333, 23)
        Me.txtSMSTO.TabIndex = 2
        Me.txtSMSTO.UseSelectable = True
        Me.txtSMSTO.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSMSTO.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tabWIFI
        '
        Me.tabWIFI.BackColor = System.Drawing.Color.Transparent
        Me.tabWIFI.BackgroundImage = Global.QR_Code.My.Resources.Resources.wifi_64
        Me.tabWIFI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tabWIFI.Controls.Add(Me.cbSaveWifiSettings)
        Me.tabWIFI.Controls.Add(Me.cbHiddenSSID)
        Me.tabWIFI.Controls.Add(Me.rbNoEncryption)
        Me.tabWIFI.Controls.Add(Me.chkShowWifiPwd)
        Me.tabWIFI.Controls.Add(Me.MetroLabel20)
        Me.tabWIFI.Controls.Add(Me.rbWPA)
        Me.tabWIFI.Controls.Add(Me.rbWEP)
        Me.tabWIFI.Controls.Add(Me.txtWIFIPwd)
        Me.tabWIFI.Controls.Add(Me.txtSSID)
        Me.tabWIFI.Controls.Add(Me.MetroLabel4)
        Me.tabWIFI.Controls.Add(Me.MetroLabel1)
        Me.tabWIFI.HorizontalScrollbarBarColor = True
        Me.tabWIFI.HorizontalScrollbarHighlightOnWheel = False
        Me.tabWIFI.HorizontalScrollbarSize = 10
        Me.tabWIFI.Location = New System.Drawing.Point(4, 38)
        Me.tabWIFI.Name = "tabWIFI"
        Me.tabWIFI.Size = New System.Drawing.Size(610, 282)
        Me.tabWIFI.TabIndex = 7
        Me.tabWIFI.Text = "WIFI"
        Me.tabWIFI.VerticalScrollbarBarColor = True
        Me.tabWIFI.VerticalScrollbarHighlightOnWheel = False
        Me.tabWIFI.VerticalScrollbarSize = 10
        '
        'cbSaveWifiSettings
        '
        Me.cbSaveWifiSettings.AutoSize = True
        Me.cbSaveWifiSettings.Location = New System.Drawing.Point(489, 250)
        Me.cbSaveWifiSettings.Name = "cbSaveWifiSettings"
        Me.cbSaveWifiSettings.Size = New System.Drawing.Size(118, 15)
        Me.cbSaveWifiSettings.TabIndex = 6
        Me.cbSaveWifiSettings.Text = "Save WIFI Settings"
        Me.cbSaveWifiSettings.UseSelectable = True
        '
        'cbHiddenSSID
        '
        Me.cbHiddenSSID.AutoSize = True
        Me.cbHiddenSSID.BackColor = System.Drawing.Color.Transparent
        Me.cbHiddenSSID.Location = New System.Drawing.Point(449, 53)
        Me.cbHiddenSSID.Name = "cbHiddenSSID"
        Me.cbHiddenSSID.Size = New System.Drawing.Size(62, 15)
        Me.cbHiddenSSID.TabIndex = 11
        Me.cbHiddenSSID.Text = "Hidden"
        Me.cbHiddenSSID.UseCustomBackColor = True
        Me.cbHiddenSSID.UseSelectable = True
        '
        'rbNoEncryption
        '
        Me.rbNoEncryption.AutoSize = True
        Me.rbNoEncryption.BackColor = System.Drawing.Color.Transparent
        Me.rbNoEncryption.Location = New System.Drawing.Point(210, 194)
        Me.rbNoEncryption.Name = "rbNoEncryption"
        Me.rbNoEncryption.Size = New System.Drawing.Size(99, 15)
        Me.rbNoEncryption.TabIndex = 10
        Me.rbNoEncryption.Text = "No Encryption"
        Me.rbNoEncryption.UseCustomBackColor = True
        Me.rbNoEncryption.UseSelectable = True
        '
        'chkShowWifiPwd
        '
        Me.chkShowWifiPwd.AutoSize = True
        Me.chkShowWifiPwd.BackColor = System.Drawing.Color.Transparent
        Me.chkShowWifiPwd.Location = New System.Drawing.Point(210, 107)
        Me.chkShowWifiPwd.Name = "chkShowWifiPwd"
        Me.chkShowWifiPwd.Size = New System.Drawing.Size(105, 15)
        Me.chkShowWifiPwd.TabIndex = 2
        Me.chkShowWifiPwd.Text = "Show Password"
        Me.chkShowWifiPwd.UseCustomBackColor = True
        Me.chkShowWifiPwd.UseSelectable = True
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel20.Location = New System.Drawing.Point(104, 148)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel20.TabIndex = 9
        Me.MetroLabel20.Text = "Authentication:"
        Me.MetroLabel20.UseCustomBackColor = True
        '
        'rbWPA
        '
        Me.rbWPA.AutoSize = True
        Me.rbWPA.BackColor = System.Drawing.Color.Transparent
        Me.rbWPA.Checked = True
        Me.rbWPA.Location = New System.Drawing.Point(210, 152)
        Me.rbWPA.Name = "rbWPA"
        Me.rbWPA.Size = New System.Drawing.Size(90, 15)
        Me.rbWPA.TabIndex = 4
        Me.rbWPA.TabStop = True
        Me.rbWPA.Text = "WPA / WPA2"
        Me.rbWPA.UseCustomBackColor = True
        Me.rbWPA.UseSelectable = True
        '
        'rbWEP
        '
        Me.rbWEP.AutoSize = True
        Me.rbWEP.BackColor = System.Drawing.Color.Transparent
        Me.rbWEP.Location = New System.Drawing.Point(210, 173)
        Me.rbWEP.Name = "rbWEP"
        Me.rbWEP.Size = New System.Drawing.Size(47, 15)
        Me.rbWEP.TabIndex = 3
        Me.rbWEP.Text = "WEP"
        Me.rbWEP.UseCustomBackColor = True
        Me.rbWEP.UseSelectable = True
        '
        'txtWIFIPwd
        '
        '
        '
        '
        Me.txtWIFIPwd.CustomButton.Image = Nothing
        Me.txtWIFIPwd.CustomButton.Location = New System.Drawing.Point(288, 1)
        Me.txtWIFIPwd.CustomButton.Name = ""
        Me.txtWIFIPwd.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtWIFIPwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtWIFIPwd.CustomButton.TabIndex = 1
        Me.txtWIFIPwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtWIFIPwd.CustomButton.UseSelectable = True
        Me.txtWIFIPwd.CustomButton.Visible = False
        Me.txtWIFIPwd.Lines = New String(-1) {}
        Me.txtWIFIPwd.Location = New System.Drawing.Point(201, 79)
        Me.txtWIFIPwd.MaxLength = 32767
        Me.txtWIFIPwd.Name = "txtWIFIPwd"
        Me.txtWIFIPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtWIFIPwd.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtWIFIPwd.SelectedText = ""
        Me.txtWIFIPwd.SelectionLength = 0
        Me.txtWIFIPwd.SelectionStart = 0
        Me.txtWIFIPwd.ShortcutsEnabled = True
        Me.txtWIFIPwd.Size = New System.Drawing.Size(310, 23)
        Me.txtWIFIPwd.TabIndex = 1
        Me.txtWIFIPwd.UseSelectable = True
        Me.txtWIFIPwd.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtWIFIPwd.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSSID
        '
        '
        '
        '
        Me.txtSSID.CustomButton.Image = Nothing
        Me.txtSSID.CustomButton.Location = New System.Drawing.Point(220, 1)
        Me.txtSSID.CustomButton.Name = ""
        Me.txtSSID.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSSID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSSID.CustomButton.TabIndex = 1
        Me.txtSSID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSSID.CustomButton.UseSelectable = True
        Me.txtSSID.CustomButton.Visible = False
        Me.txtSSID.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtSSID.Lines = New String(-1) {}
        Me.txtSSID.Location = New System.Drawing.Point(201, 49)
        Me.txtSSID.MaxLength = 32767
        Me.txtSSID.Name = "txtSSID"
        Me.txtSSID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSSID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSSID.SelectedText = ""
        Me.txtSSID.SelectionLength = 0
        Me.txtSSID.SelectionStart = 0
        Me.txtSSID.ShortcutsEnabled = True
        Me.txtSSID.Size = New System.Drawing.Size(242, 23)
        Me.txtSSID.TabIndex = 0
        Me.txtSSID.UseSelectable = True
        Me.txtSSID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSSID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.Location = New System.Drawing.Point(104, 79)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel4.TabIndex = 4
        Me.MetroLabel4.Text = "Password:"
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.Location = New System.Drawing.Point(104, 49)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Network SSID:"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'tabGeo
        '
        Me.tabGeo.BackColor = System.Drawing.Color.Transparent
        Me.tabGeo.BackgroundImage = Global.QR_Code.My.Resources.Resources._1460309282_geolocation
        Me.tabGeo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tabGeo.Controls.Add(Me.mlSearch)
        Me.tabGeo.Controls.Add(Me.TrackBar1)
        Me.tabGeo.Controls.Add(Me.chkCreateGoogleMapsLink)
        Me.tabGeo.Controls.Add(Me.txtLongitude)
        Me.tabGeo.Controls.Add(Me.cmbMapProvider)
        Me.tabGeo.Controls.Add(Me.lblMapProvider)
        Me.tabGeo.Controls.Add(Me.MetroLabel38)
        Me.tabGeo.Controls.Add(Me.MetroLabel37)
        Me.tabGeo.Controls.Add(Me.txtLatitude)
        Me.tabGeo.Controls.Add(Me.GMapControl1)
        Me.tabGeo.HorizontalScrollbarBarColor = True
        Me.tabGeo.HorizontalScrollbarHighlightOnWheel = False
        Me.tabGeo.HorizontalScrollbarSize = 10
        Me.tabGeo.Location = New System.Drawing.Point(4, 38)
        Me.tabGeo.Name = "tabGeo"
        Me.tabGeo.Size = New System.Drawing.Size(610, 282)
        Me.tabGeo.TabIndex = 8
        Me.tabGeo.Text = "GeoLocation"
        Me.tabGeo.VerticalScrollbarBarColor = True
        Me.tabGeo.VerticalScrollbarHighlightOnWheel = False
        Me.tabGeo.VerticalScrollbarSize = 10
        '
        'mlSearch
        '
        Me.mlSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mlSearch.Image = Global.QR_Code.My.Resources.Resources.search_lookup_glyph_32
        Me.mlSearch.ImageSize = 32
        Me.mlSearch.Location = New System.Drawing.Point(0, 187)
        Me.mlSearch.Name = "mlSearch"
        Me.mlSearch.Size = New System.Drawing.Size(40, 40)
        Me.mlSearch.TabIndex = 14
        Me.mlSearch.UseSelectable = True
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.White
        Me.TrackBar1.LargeChange = 100
        Me.TrackBar1.Location = New System.Drawing.Point(565, 3)
        Me.TrackBar1.Maximum = 0
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 224)
        Me.TrackBar1.SmallChange = 100
        Me.TrackBar1.TabIndex = 13
        Me.TrackBar1.TickFrequency = 100
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'chkCreateGoogleMapsLink
        '
        Me.chkCreateGoogleMapsLink.AutoSize = True
        Me.chkCreateGoogleMapsLink.Location = New System.Drawing.Point(56, 5)
        Me.chkCreateGoogleMapsLink.Name = "chkCreateGoogleMapsLink"
        Me.chkCreateGoogleMapsLink.Size = New System.Drawing.Size(149, 15)
        Me.chkCreateGoogleMapsLink.TabIndex = 7
        Me.chkCreateGoogleMapsLink.Text = "Create GoogleMaps link"
        Me.chkCreateGoogleMapsLink.UseSelectable = True
        Me.chkCreateGoogleMapsLink.Visible = False
        '
        'txtLongitude
        '
        '
        '
        '
        Me.txtLongitude.CustomButton.Image = Nothing
        Me.txtLongitude.CustomButton.Location = New System.Drawing.Point(113, 1)
        Me.txtLongitude.CustomButton.Name = ""
        Me.txtLongitude.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLongitude.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLongitude.CustomButton.TabIndex = 1
        Me.txtLongitude.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLongitude.CustomButton.UseSelectable = True
        Me.txtLongitude.CustomButton.Visible = False
        Me.txtLongitude.Lines = New String(-1) {}
        Me.txtLongitude.Location = New System.Drawing.Point(224, 255)
        Me.txtLongitude.MaxLength = 32767
        Me.txtLongitude.Name = "txtLongitude"
        Me.txtLongitude.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLongitude.ReadOnly = True
        Me.txtLongitude.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLongitude.SelectedText = ""
        Me.txtLongitude.SelectionLength = 0
        Me.txtLongitude.SelectionStart = 0
        Me.txtLongitude.ShortcutsEnabled = True
        Me.txtLongitude.Size = New System.Drawing.Size(135, 23)
        Me.txtLongitude.TabIndex = 6
        Me.txtLongitude.UseSelectable = True
        Me.txtLongitude.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLongitude.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cmbMapProvider
        '
        Me.cmbMapProvider.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbMapProvider.FormattingEnabled = True
        Me.cmbMapProvider.ItemHeight = 19
        Me.cmbMapProvider.Location = New System.Drawing.Point(409, 253)
        Me.cmbMapProvider.Name = "cmbMapProvider"
        Me.cmbMapProvider.Size = New System.Drawing.Size(188, 25)
        Me.cmbMapProvider.TabIndex = 4
        Me.cmbMapProvider.UseSelectable = True
        '
        'lblMapProvider
        '
        Me.lblMapProvider.AutoSize = True
        Me.lblMapProvider.Location = New System.Drawing.Point(409, 233)
        Me.lblMapProvider.Name = "lblMapProvider"
        Me.lblMapProvider.Size = New System.Drawing.Size(94, 19)
        Me.lblMapProvider.TabIndex = 5
        Me.lblMapProvider.Text = "Map Provider:"
        '
        'MetroLabel38
        '
        Me.MetroLabel38.AutoSize = True
        Me.MetroLabel38.Location = New System.Drawing.Point(224, 234)
        Me.MetroLabel38.Name = "MetroLabel38"
        Me.MetroLabel38.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel38.TabIndex = 5
        Me.MetroLabel38.Text = "Longitude:"
        '
        'MetroLabel37
        '
        Me.MetroLabel37.AutoSize = True
        Me.MetroLabel37.Location = New System.Drawing.Point(56, 233)
        Me.MetroLabel37.Name = "MetroLabel37"
        Me.MetroLabel37.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel37.TabIndex = 4
        Me.MetroLabel37.Text = "Latitude:"
        '
        'txtLatitude
        '
        '
        '
        '
        Me.txtLatitude.CustomButton.Image = Nothing
        Me.txtLatitude.CustomButton.Location = New System.Drawing.Point(113, 1)
        Me.txtLatitude.CustomButton.Name = ""
        Me.txtLatitude.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLatitude.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLatitude.CustomButton.TabIndex = 1
        Me.txtLatitude.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLatitude.CustomButton.UseSelectable = True
        Me.txtLatitude.CustomButton.Visible = False
        Me.txtLatitude.Lines = New String(-1) {}
        Me.txtLatitude.Location = New System.Drawing.Point(56, 255)
        Me.txtLatitude.MaxLength = 32767
        Me.txtLatitude.Name = "txtLatitude"
        Me.txtLatitude.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLatitude.ReadOnly = True
        Me.txtLatitude.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLatitude.SelectedText = ""
        Me.txtLatitude.SelectionLength = 0
        Me.txtLatitude.SelectionStart = 0
        Me.txtLatitude.ShortcutsEnabled = True
        Me.txtLatitude.Size = New System.Drawing.Size(135, 23)
        Me.txtLatitude.TabIndex = 3
        Me.txtLatitude.UseSelectable = True
        Me.txtLatitude.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLatitude.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GMapControl1
        '
        Me.GMapControl1.Bearing = 0!
        Me.GMapControl1.CanDragMap = True
        Me.GMapControl1.EmptyTileColor = System.Drawing.Color.Navy
        Me.GMapControl1.GrayScaleMode = False
        Me.GMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.GMapControl1.LevelsKeepInMemmory = 5
        Me.GMapControl1.Location = New System.Drawing.Point(56, 3)
        Me.GMapControl1.MarkersEnabled = True
        Me.GMapControl1.MaxZoom = 20
        Me.GMapControl1.MinZoom = 2
        Me.GMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter
        Me.GMapControl1.Name = "GMapControl1"
        Me.GMapControl1.NegativeMode = False
        Me.GMapControl1.PolygonsEnabled = True
        Me.GMapControl1.RetryLoadTile = 0
        Me.GMapControl1.RoutesEnabled = True
        Me.GMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.GMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GMapControl1.ShowTileGridLines = False
        Me.GMapControl1.Size = New System.Drawing.Size(503, 224)
        Me.GMapControl1.TabIndex = 2
        Me.GMapControl1.Zoom = 2.0R
        '
        'tabEvent
        '
        Me.tabEvent.BackColor = System.Drawing.Color.Transparent
        Me.tabEvent.BackgroundImage = Global.QR_Code.My.Resources.Resources.event_64
        Me.tabEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tabEvent.Controls.Add(Me.dtEndTime)
        Me.tabEvent.Controls.Add(Me.dtStartTime)
        Me.tabEvent.Controls.Add(Me.MetroLabel46)
        Me.tabEvent.Controls.Add(Me.MetroLabel45)
        Me.tabEvent.Controls.Add(Me.dtEndDate)
        Me.tabEvent.Controls.Add(Me.dtStartDate)
        Me.tabEvent.Controls.Add(Me.MetroLabel44)
        Me.tabEvent.Controls.Add(Me.MetroLabel43)
        Me.tabEvent.Controls.Add(Me.txtMemo)
        Me.tabEvent.Controls.Add(Me.txtLocation)
        Me.tabEvent.Controls.Add(Me.txtEventName)
        Me.tabEvent.Controls.Add(Me.MetroLabel42)
        Me.tabEvent.Controls.Add(Me.MetroLabel41)
        Me.tabEvent.Controls.Add(Me.MetroLabel40)
        Me.tabEvent.HorizontalScrollbarBarColor = True
        Me.tabEvent.HorizontalScrollbarHighlightOnWheel = False
        Me.tabEvent.HorizontalScrollbarSize = 10
        Me.tabEvent.Location = New System.Drawing.Point(4, 38)
        Me.tabEvent.Name = "tabEvent"
        Me.tabEvent.Size = New System.Drawing.Size(610, 282)
        Me.tabEvent.TabIndex = 9
        Me.tabEvent.Text = "Event"
        Me.tabEvent.VerticalScrollbarBarColor = True
        Me.tabEvent.VerticalScrollbarHighlightOnWheel = False
        Me.tabEvent.VerticalScrollbarSize = 10
        '
        'dtEndTime
        '
        Me.dtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtEndTime.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEndTime.Location = New System.Drawing.Point(443, 224)
        Me.dtEndTime.Mask = "90:00"
        Me.dtEndTime.Name = "dtEndTime"
        Me.dtEndTime.Size = New System.Drawing.Size(74, 27)
        Me.dtEndTime.TabIndex = 19
        Me.dtEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dtEndTime.ValidatingType = GetType(Date)
        '
        'dtStartTime
        '
        Me.dtStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtStartTime.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtStartTime.Location = New System.Drawing.Point(443, 189)
        Me.dtStartTime.Mask = "90:00"
        Me.dtStartTime.Name = "dtStartTime"
        Me.dtStartTime.Size = New System.Drawing.Size(74, 27)
        Me.dtStartTime.TabIndex = 18
        Me.dtStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dtStartTime.ValidatingType = GetType(Date)
        '
        'MetroLabel46
        '
        Me.MetroLabel46.AutoSize = True
        Me.MetroLabel46.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel46.Location = New System.Drawing.Point(421, 229)
        Me.MetroLabel46.Name = "MetroLabel46"
        Me.MetroLabel46.Size = New System.Drawing.Size(14, 19)
        Me.MetroLabel46.TabIndex = 16
        Me.MetroLabel46.Text = "/"
        Me.MetroLabel46.UseCustomBackColor = True
        '
        'MetroLabel45
        '
        Me.MetroLabel45.AutoSize = True
        Me.MetroLabel45.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel45.Location = New System.Drawing.Point(421, 193)
        Me.MetroLabel45.Name = "MetroLabel45"
        Me.MetroLabel45.Size = New System.Drawing.Size(14, 19)
        Me.MetroLabel45.TabIndex = 15
        Me.MetroLabel45.Text = "/"
        Me.MetroLabel45.UseCustomBackColor = True
        '
        'dtEndDate
        '
        Me.dtEndDate.Location = New System.Drawing.Point(200, 224)
        Me.dtEndDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtEndDate.Name = "dtEndDate"
        Me.dtEndDate.Size = New System.Drawing.Size(214, 29)
        Me.dtEndDate.TabIndex = 5
        '
        'dtStartDate
        '
        Me.dtStartDate.CalendarTitleBackColor = System.Drawing.Color.White
        Me.dtStartDate.Location = New System.Drawing.Point(200, 189)
        Me.dtStartDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtStartDate.Name = "dtStartDate"
        Me.dtStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtStartDate.Size = New System.Drawing.Size(214, 29)
        Me.dtStartDate.TabIndex = 3
        '
        'MetroLabel44
        '
        Me.MetroLabel44.AutoSize = True
        Me.MetroLabel44.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel44.Location = New System.Drawing.Point(108, 229)
        Me.MetroLabel44.Name = "MetroLabel44"
        Me.MetroLabel44.Size = New System.Drawing.Size(34, 19)
        Me.MetroLabel44.TabIndex = 10
        Me.MetroLabel44.Text = "End:"
        Me.MetroLabel44.UseCustomBackColor = True
        '
        'MetroLabel43
        '
        Me.MetroLabel43.AutoSize = True
        Me.MetroLabel43.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel43.Location = New System.Drawing.Point(108, 194)
        Me.MetroLabel43.Name = "MetroLabel43"
        Me.MetroLabel43.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel43.TabIndex = 9
        Me.MetroLabel43.Text = "Start:"
        Me.MetroLabel43.UseCustomBackColor = True
        '
        'txtMemo
        '
        '
        '
        '
        Me.txtMemo.CustomButton.Image = Nothing
        Me.txtMemo.CustomButton.Location = New System.Drawing.Point(233, 2)
        Me.txtMemo.CustomButton.Name = ""
        Me.txtMemo.CustomButton.Size = New System.Drawing.Size(81, 81)
        Me.txtMemo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMemo.CustomButton.TabIndex = 1
        Me.txtMemo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMemo.CustomButton.UseSelectable = True
        Me.txtMemo.CustomButton.Visible = False
        Me.txtMemo.Lines = New String(-1) {}
        Me.txtMemo.Location = New System.Drawing.Point(200, 84)
        Me.txtMemo.MaxLength = 32767
        Me.txtMemo.Multiline = True
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMemo.SelectedText = ""
        Me.txtMemo.SelectionLength = 0
        Me.txtMemo.SelectionStart = 0
        Me.txtMemo.ShortcutsEnabled = True
        Me.txtMemo.Size = New System.Drawing.Size(317, 86)
        Me.txtMemo.TabIndex = 2
        Me.txtMemo.UseSelectable = True
        Me.txtMemo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMemo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLocation
        '
        '
        '
        '
        Me.txtLocation.CustomButton.Image = Nothing
        Me.txtLocation.CustomButton.Location = New System.Drawing.Point(208, 1)
        Me.txtLocation.CustomButton.Name = ""
        Me.txtLocation.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLocation.CustomButton.TabIndex = 1
        Me.txtLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLocation.CustomButton.UseSelectable = True
        Me.txtLocation.CustomButton.Visible = False
        Me.txtLocation.Lines = New String(-1) {}
        Me.txtLocation.Location = New System.Drawing.Point(200, 50)
        Me.txtLocation.MaxLength = 32767
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLocation.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLocation.SelectedText = ""
        Me.txtLocation.SelectionLength = 0
        Me.txtLocation.SelectionStart = 0
        Me.txtLocation.ShortcutsEnabled = True
        Me.txtLocation.Size = New System.Drawing.Size(230, 23)
        Me.txtLocation.TabIndex = 1
        Me.txtLocation.UseSelectable = True
        Me.txtLocation.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLocation.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEventName
        '
        '
        '
        '
        Me.txtEventName.CustomButton.Image = Nothing
        Me.txtEventName.CustomButton.Location = New System.Drawing.Point(208, 1)
        Me.txtEventName.CustomButton.Name = ""
        Me.txtEventName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEventName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEventName.CustomButton.TabIndex = 1
        Me.txtEventName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEventName.CustomButton.UseSelectable = True
        Me.txtEventName.CustomButton.Visible = False
        Me.txtEventName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtEventName.Lines = New String(-1) {}
        Me.txtEventName.Location = New System.Drawing.Point(200, 21)
        Me.txtEventName.MaxLength = 32767
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEventName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEventName.SelectedText = ""
        Me.txtEventName.SelectionLength = 0
        Me.txtEventName.SelectionStart = 0
        Me.txtEventName.ShortcutsEnabled = True
        Me.txtEventName.Size = New System.Drawing.Size(230, 23)
        Me.txtEventName.TabIndex = 0
        Me.txtEventName.UseSelectable = True
        Me.txtEventName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEventName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel42
        '
        Me.MetroLabel42.AutoSize = True
        Me.MetroLabel42.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel42.Location = New System.Drawing.Point(108, 88)
        Me.MetroLabel42.Name = "MetroLabel42"
        Me.MetroLabel42.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel42.TabIndex = 5
        Me.MetroLabel42.Text = "Memo:"
        Me.MetroLabel42.UseCustomBackColor = True
        '
        'MetroLabel41
        '
        Me.MetroLabel41.AutoSize = True
        Me.MetroLabel41.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel41.Location = New System.Drawing.Point(108, 54)
        Me.MetroLabel41.Name = "MetroLabel41"
        Me.MetroLabel41.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel41.TabIndex = 3
        Me.MetroLabel41.Text = "Location:"
        Me.MetroLabel41.UseCustomBackColor = True
        '
        'MetroLabel40
        '
        Me.MetroLabel40.AutoSize = True
        Me.MetroLabel40.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel40.Location = New System.Drawing.Point(108, 21)
        Me.MetroLabel40.Name = "MetroLabel40"
        Me.MetroLabel40.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel40.TabIndex = 2
        Me.MetroLabel40.Text = "Event Name:"
        Me.MetroLabel40.UseCustomBackColor = True
        '
        'cmbStyle
        '
        Me.cmbStyle.FormattingEnabled = True
        Me.cmbStyle.ItemHeight = 23
        Me.cmbStyle.Location = New System.Drawing.Point(31, 383)
        Me.cmbStyle.Name = "cmbStyle"
        Me.cmbStyle.Size = New System.Drawing.Size(115, 29)
        Me.cmbStyle.TabIndex = 2
        Me.cmbStyle.UseSelectable = True
        '
        'rbHiddenSSID
        '
        Me.rbHiddenSSID.AutoSize = True
        Me.rbHiddenSSID.BackColor = System.Drawing.Color.Transparent
        Me.rbHiddenSSID.Location = New System.Drawing.Point(449, 53)
        Me.rbHiddenSSID.Name = "rbHiddenSSID"
        Me.rbHiddenSSID.Size = New System.Drawing.Size(62, 15)
        Me.rbHiddenSSID.TabIndex = 11
        Me.rbHiddenSSID.Text = "Hidden"
        Me.rbHiddenSSID.UseCustomBackColor = True
        Me.rbHiddenSSID.UseSelectable = True
        '
        'pnlOptions
        '
        Me.pnlOptions.Controls.Add(Me.lblSkinOptions)
        Me.pnlOptions.Controls.Add(Me.LineSeparator3)
        Me.pnlOptions.Controls.Add(Me.lblTheme)
        Me.pnlOptions.Controls.Add(Me.cmbTheme)
        Me.pnlOptions.Controls.Add(Me.LineSeparator2)
        Me.pnlOptions.Controls.Add(Me.lblQrOptions)
        Me.pnlOptions.Controls.Add(Me.lblImageSize)
        Me.pnlOptions.Controls.Add(Me.cbFormat)
        Me.pnlOptions.Controls.Add(Me.lblFormat)
        Me.pnlOptions.Controls.Add(Me.lblQuietZone)
        Me.pnlOptions.Controls.Add(Me.lblCorrLevel)
        Me.pnlOptions.Controls.Add(Me.cbQuietZone)
        Me.pnlOptions.Controls.Add(Me.cbLevel)
        Me.pnlOptions.Controls.Add(Me.numImageSize)
        Me.pnlOptions.Controls.Add(Me.lblStyle)
        Me.pnlOptions.Controls.Add(Me.cmbStyle)
        Me.pnlOptions.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlOptions.Location = New System.Drawing.Point(647, 60)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(170, 419)
        Me.pnlOptions.TabIndex = 6
        '
        'lblSkinOptions
        '
        Me.lblSkinOptions.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblSkinOptions.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblSkinOptions.Location = New System.Drawing.Point(9, 271)
        Me.lblSkinOptions.Name = "lblSkinOptions"
        Me.lblSkinOptions.Size = New System.Drawing.Size(72, 26)
        Me.lblSkinOptions.TabIndex = 21
        Me.lblSkinOptions.Text = "Design"
        Me.lblSkinOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSkinOptions.UseStyleColors = True
        '
        'LineSeparator3
        '
        Me.LineSeparator3.Location = New System.Drawing.Point(81, 285)
        Me.LineSeparator3.MaximumSize = New System.Drawing.Size(2000, 2)
        Me.LineSeparator3.MinimumSize = New System.Drawing.Size(0, 2)
        Me.LineSeparator3.Name = "LineSeparator3"
        Me.LineSeparator3.Size = New System.Drawing.Size(75, 2)
        Me.LineSeparator3.TabIndex = 19
        '
        'lblTheme
        '
        Me.lblTheme.AutoSize = True
        Me.lblTheme.Location = New System.Drawing.Point(31, 306)
        Me.lblTheme.Name = "lblTheme"
        Me.lblTheme.Size = New System.Drawing.Size(52, 19)
        Me.lblTheme.TabIndex = 18
        Me.lblTheme.Text = "Theme:"
        '
        'cmbTheme
        '
        Me.cmbTheme.FormattingEnabled = True
        Me.cmbTheme.ItemHeight = 23
        Me.cmbTheme.Location = New System.Drawing.Point(31, 328)
        Me.cmbTheme.Name = "cmbTheme"
        Me.cmbTheme.Size = New System.Drawing.Size(115, 29)
        Me.cmbTheme.TabIndex = 17
        Me.cmbTheme.UseSelectable = True
        '
        'LineSeparator2
        '
        Me.LineSeparator2.Location = New System.Drawing.Point(98, 19)
        Me.LineSeparator2.MaximumSize = New System.Drawing.Size(2000, 2)
        Me.LineSeparator2.MinimumSize = New System.Drawing.Size(0, 2)
        Me.LineSeparator2.Name = "LineSeparator2"
        Me.LineSeparator2.Size = New System.Drawing.Size(58, 2)
        Me.LineSeparator2.TabIndex = 16
        '
        'lblQrOptions
        '
        Me.lblQrOptions.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblQrOptions.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblQrOptions.Location = New System.Drawing.Point(9, 5)
        Me.lblQrOptions.Name = "lblQrOptions"
        Me.lblQrOptions.Size = New System.Drawing.Size(91, 26)
        Me.lblQrOptions.TabIndex = 15
        Me.lblQrOptions.Text = "QR-Code"
        Me.lblQrOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblQrOptions.UseStyleColors = True
        '
        'lblImageSize
        '
        Me.lblImageSize.AutoSize = True
        Me.lblImageSize.Location = New System.Drawing.Point(27, 38)
        Me.lblImageSize.Name = "lblImageSize"
        Me.lblImageSize.Size = New System.Drawing.Size(76, 19)
        Me.lblImageSize.TabIndex = 14
        Me.lblImageSize.Text = "Image Size:"
        '
        'cbFormat
        '
        Me.cbFormat.FormattingEnabled = True
        Me.cbFormat.ItemHeight = 23
        Me.cbFormat.Items.AddRange(New Object() {"Png", "Bitmap", "Gif"})
        Me.cbFormat.Location = New System.Drawing.Point(31, 229)
        Me.cbFormat.Name = "cbFormat"
        Me.cbFormat.Size = New System.Drawing.Size(115, 29)
        Me.cbFormat.TabIndex = 12
        Me.cbFormat.UseSelectable = True
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.Location = New System.Drawing.Point(31, 207)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(55, 19)
        Me.lblFormat.TabIndex = 11
        Me.lblFormat.Text = "Format:"
        '
        'lblQuietZone
        '
        Me.lblQuietZone.AutoSize = True
        Me.lblQuietZone.Cursor = System.Windows.Forms.Cursors.Help
        Me.lblQuietZone.Location = New System.Drawing.Point(27, 151)
        Me.lblQuietZone.Name = "lblQuietZone"
        Me.lblQuietZone.Size = New System.Drawing.Size(78, 19)
        Me.lblQuietZone.TabIndex = 10
        Me.lblQuietZone.Text = "Quiet Zone:"
        '
        'lblCorrLevel
        '
        Me.lblCorrLevel.AutoSize = True
        Me.lblCorrLevel.Cursor = System.Windows.Forms.Cursors.Help
        Me.lblCorrLevel.Location = New System.Drawing.Point(27, 93)
        Me.lblCorrLevel.Name = "lblCorrLevel"
        Me.lblCorrLevel.Size = New System.Drawing.Size(107, 19)
        Me.lblCorrLevel.TabIndex = 9
        Me.lblCorrLevel.Text = "Correction Level:"
        '
        'cbQuietZone
        '
        Me.cbQuietZone.FormattingEnabled = True
        Me.cbQuietZone.ItemHeight = 23
        Me.cbQuietZone.Items.AddRange(New Object() {"No quiet zone", "2 squares", "4 squares"})
        Me.cbQuietZone.Location = New System.Drawing.Point(31, 173)
        Me.cbQuietZone.Name = "cbQuietZone"
        Me.cbQuietZone.Size = New System.Drawing.Size(115, 29)
        Me.cbQuietZone.TabIndex = 8
        Me.cbQuietZone.UseSelectable = True
        '
        'cbLevel
        '
        Me.cbLevel.DisplayFocus = True
        Me.cbLevel.FormattingEnabled = True
        Me.cbLevel.ItemHeight = 23
        Me.cbLevel.Items.AddRange(New Object() {"Low", "Medium", "Quartile", "High"})
        Me.cbLevel.Location = New System.Drawing.Point(31, 115)
        Me.cbLevel.Name = "cbLevel"
        Me.cbLevel.Size = New System.Drawing.Size(115, 29)
        Me.cbLevel.TabIndex = 7
        Me.cbLevel.UseSelectable = True
        '
        'numImageSize
        '
        Me.numImageSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numImageSize.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numImageSize.Location = New System.Drawing.Point(31, 60)
        Me.numImageSize.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numImageSize.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numImageSize.Name = "numImageSize"
        Me.numImageSize.Size = New System.Drawing.Size(115, 27)
        Me.numImageSize.TabIndex = 6
        Me.numImageSize.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'lblStyle
        '
        Me.lblStyle.AutoSize = True
        Me.lblStyle.Location = New System.Drawing.Point(31, 361)
        Me.lblStyle.Name = "lblStyle"
        Me.lblStyle.Size = New System.Drawing.Size(39, 19)
        Me.lblStyle.TabIndex = 3
        Me.lblStyle.Text = "Style:"
        '
        'ctxMenu
        '
        Me.ctxMenu.BackColor = System.Drawing.SystemColors.Control
        Me.ctxMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisitWebsiteToolStripMenuItem, Me.ToolStripMenuItem1, Me.CreditsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.ctxMenu.Name = "ctxMenu"
        Me.ctxMenu.Size = New System.Drawing.Size(142, 104)
        '
        'VisitWebsiteToolStripMenuItem
        '
        Me.VisitWebsiteToolStripMenuItem.Name = "VisitWebsiteToolStripMenuItem"
        Me.VisitWebsiteToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.VisitWebsiteToolStripMenuItem.Text = "Visit Website"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(138, 6)
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CreditsToolStripMenuItem.Text = "Credits"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(138, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MetroButton1
        '
        Me.MetroButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.MetroButton1.Highlight = True
        Me.MetroButton1.Location = New System.Drawing.Point(20, 433)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(627, 46)
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.Text = "Generate QR-Code"
        Me.MetroButton1.UseSelectable = True
        '
        'mapMenu
        '
        Me.mapMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomToolStripMenuItem, Me.ToolStripMenuItem3, Me.GoToToolStripMenuItem, Me.SearchByKeywordsToolStripMenuItem})
        Me.mapMenu.Name = "mapMenu"
        Me.mapMenu.Size = New System.Drawing.Size(119, 76)
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaxToolStripMenuItem, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.MinToolStripMenuItem})
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ZoomToolStripMenuItem.Text = "Zoom"
        '
        'MaxToolStripMenuItem
        '
        Me.MaxToolStripMenuItem.Name = "MaxToolStripMenuItem"
        Me.MaxToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.MaxToolStripMenuItem.Text = "Max"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(96, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(99, 22)
        Me.ToolStripMenuItem5.Text = "75 %"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(99, 22)
        Me.ToolStripMenuItem6.Text = "50 %"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(99, 22)
        Me.ToolStripMenuItem7.Text = "25 %"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(96, 6)
        '
        'MinToolStripMenuItem
        '
        Me.MinToolStripMenuItem.Name = "MinToolStripMenuItem"
        Me.MinToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.MinToolStripMenuItem.Text = "Min"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(115, 6)
        '
        'GoToToolStripMenuItem
        '
        Me.GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        Me.GoToToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.GoToToolStripMenuItem.Text = "GoTo"
        '
        'SearchByKeywordsToolStripMenuItem
        '
        Me.SearchByKeywordsToolStripMenuItem.Name = "SearchByKeywordsToolStripMenuItem"
        Me.SearchByKeywordsToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SearchByKeywordsToolStripMenuItem.Text = "Search..."
        '
        'mlTools
        '
        Me.mlTools.Image = Global.QR_Code.My.Resources.Resources._1460935292_menu_alt
        Me.mlTools.ImageSize = 32
        Me.mlTools.Location = New System.Drawing.Point(24, 55)
        Me.mlTools.Name = "mlTools"
        Me.mlTools.Size = New System.Drawing.Size(48, 48)
        Me.mlTools.TabIndex = 8
        Me.mlTools.UseSelectable = True
        '
        'mlMenu
        '
        Me.mlMenu.Cursor = System.Windows.Forms.Cursors.Default
        Me.mlMenu.Image = Global.QR_Code.My.Resources.Resources._1460938015_Working_Tools_2
        Me.mlMenu.ImageSize = 32
        Me.mlMenu.Location = New System.Drawing.Point(597, 55)
        Me.mlMenu.Name = "mlMenu"
        Me.mlMenu.Size = New System.Drawing.Size(48, 48)
        Me.mlMenu.TabIndex = 7
        Me.mlMenu.UseSelectable = True
        '
        'ctxAddressBook
        '
        Me.ctxAddressBook.BackColor = System.Drawing.SystemColors.Control
        Me.ctxAddressBook.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctxAddressBook.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiDeleteContact})
        Me.ctxAddressBook.Name = "ctxMenu"
        Me.ctxAddressBook.Size = New System.Drawing.Size(153, 26)
        '
        'tsmiDeleteContact
        '
        Me.tsmiDeleteContact.Name = "tsmiDeleteContact"
        Me.tsmiDeleteContact.Size = New System.Drawing.Size(152, 22)
        Me.tsmiDeleteContact.Text = "Delete Contact"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(837, 499)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.mlTools)
        Me.Controls.Add(Me.mlMenu)
        Me.Controls.Add(Me.pnlOptions)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "QR-Code Generator"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tabFree.ResumeLayout(False)
        Me.tabURL.ResumeLayout(False)
        Me.tabURL.PerformLayout()
        Me.tabvCard.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabPhone.ResumeLayout(False)
        Me.tabPhone.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.tabEmail.ResumeLayout(False)
        Me.tabEmail.PerformLayout()
        Me.tabSMS.ResumeLayout(False)
        Me.tabSMS.PerformLayout()
        Me.tabWIFI.ResumeLayout(False)
        Me.tabWIFI.PerformLayout()
        Me.tabGeo.ResumeLayout(False)
        Me.tabGeo.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEvent.ResumeLayout(False)
        Me.tabEvent.PerformLayout()
        Me.pnlOptions.ResumeLayout(False)
        Me.pnlOptions.PerformLayout()
        CType(Me.numImageSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxMenu.ResumeLayout(False)
        Me.mapMenu.ResumeLayout(False)
        Me.ctxAddressBook.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFreeText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabFree As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabvCard As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabPhone As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabEmail As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabSMS As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabURL As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txtPhoneNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSMSTO As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tabWIFI As MetroFramework.Controls.MetroTabPage
    Friend WithEvents rbWPA As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbWEP As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents txtWIFIPwd As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSSID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtURL As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSMSMSG As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBody As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSubject As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtRecipient As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtvEmailPrivate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtvGivenName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtvFamilyName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtvTelPrivate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtvTelWork As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtvTitle As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtvOrganisation As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chkShowWifiPwd As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtvFaxPrivate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtvFaxWork As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel22 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel23 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtvWebsitePrivate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtvWebsiteWork As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtvEmailWork As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel24 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel26 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel25 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSaveVCard As MetroFramework.Controls.MetroButton
    Friend WithEvents cmbvCountryWork As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel30 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtvCityWork As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel31 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtvPostalWork As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel32 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtvStreetWork As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel33 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel34 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbvCountryPrivate As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel29 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtvCityPrivate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel28 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtvPostalPrivate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel27 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtvStreetPrivate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chkvYear As MetroFramework.Controls.MetroComboBox
    Friend WithEvents chkvMonth As MetroFramework.Controls.MetroComboBox
    Friend WithEvents chkvDay As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel36 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtvCellphonePrivate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel35 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbHiddenSSID As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents rbNoEncryption As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents tabGeo As MetroFramework.Controls.MetroTabPage
    Friend WithEvents GMapControl1 As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents MetroLabel38 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel37 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtLatitude As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLongitude As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chkCreateGoogleMapsLink As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents tabEvent As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel41 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel40 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMemo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLocation As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEventName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel42 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel44 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel43 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtStartDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtEndDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel46 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel45 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel47 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbSaveWifiSettings As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents rbHiddenSSID As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cmbStyle As MetroFramework.Controls.MetroComboBox
    Friend WithEvents pnlOptions As Panel
    Friend WithEvents lblStyle As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMapProvider As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbMapProvider As MetroFramework.Controls.MetroComboBox
    Friend WithEvents numImageSize As NumericUpDown
    Friend WithEvents cbLevel As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbQuietZone As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblQuietZone As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCorrLevel As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbFormat As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblFormat As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblImageSize As MetroFramework.Controls.MetroLabel
    Friend WithEvents LineSeparator2 As LineSeparator
    Friend WithEvents lblQrOptions As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTheme As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbTheme As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtStartTime As MaskedTextBox
    Friend WithEvents dtEndTime As MaskedTextBox
    Friend WithEvents mlMenu As MetroFramework.Controls.MetroLink
    Friend WithEvents LineSeparator3 As LineSeparator
    Friend WithEvents mlTools As MetroFramework.Controls.MetroLink
    Friend WithEvents ctxMenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents VisitWebsiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CreditsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSkinOptions As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlSearch As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents mapMenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents SearchByKeywordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Friend WithEvents MinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents btnAddPhoneNumber As MetroFramework.Controls.MetroButton
    Friend WithEvents ctxAddressBook As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents tsmiDeleteContact As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lvPhoneBook As ListView
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colPhoneNumber As ColumnHeader
    Friend WithEvents GoToToolStripMenuItem As ToolStripMenuItem
End Class
