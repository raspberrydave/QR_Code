Option Explicit On
Option Strict On

Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO

Public Class QrForm

    Private _qr As QR
    Private _initialized As Boolean = False


    Public Sub New(ByVal qr As QR)
        Try
            ' Dieser Aufruf ist für den Designer erforderlich.
            InitializeComponent()

            ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
            Me._qr = qr

            pbQrCode.Size = _qr.QR_Image.Size
            pbQrCode.Image = _qr.QR_Image

            Dim offsetY As Integer = Me.Padding.Top + Me.Padding.Bottom + pnlFooter.Height
            'Dim offsetY As Integer = Me.Padding.Top + Me.Padding.Bottom + pnlOptions.Height
            Dim offsetX As Integer = Me.Padding.Left + Me.Padding.Right + pnlOptions.Width

            Me.Size = New Size(_qr.QR_Image.Width + offsetX, _qr.QR_Image.Height + offsetY)

            pnlOptions.Location = New Point(pbQrCode.Location.X + pbQrCode.Width, pbQrCode.Location.Y)
            pnlFooter.Location = New Point(pbQrCode.Location.X, pbQrCode.Location.Y + pbQrCode.Height)
            pnlFooter.Width = pbQrCode.Width

            tbCorrectionLevel.Value = _qr.CorrectionLevel
            tbQuietZone.Value = CInt(_qr.QuietZone / 2)

            MyColorPickerFront.SelectedColor = _qr.FrontColor.Color
            MyColorPickerBack.SelectedColor = _qr.BackColor.Color

            DisplayImageValues()
            'ToggleOptionsPanel()

            _initialized = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToggleOptionsPanel()
        Try
            If btnOptions.Text = "<<" Then
                Me.Size = New Size(Me.Width - pnlOptions.Width, Me.Height)

                pnlOptions.Visible = False
                btnOptions.Text = ">>"
            Else
                Me.Size = New Size(Me.Width + pnlOptions.Width, Me.Height)

                pnlOptions.Visible = True
                btnOptions.Text = "<<"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ChangeFrontColor()
        Try
            Dim brush As New SolidBrush(MyColorPickerFront.SelectedColor)
            Me._qr.FrontColor = Brush

            pbQrCode.Image = _qr.QR_Image
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChangeBackColor()
        Try
            Dim brush As New SolidBrush(MyColorPickerBack.SelectedColor)
            Me._qr.BackColor = Brush

            pbQrCode.Image = _qr.QR_Image
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DisplayImageValues()
        Try
            Select Case tbCorrectionLevel.Value
                Case 0 : lblCL.Text = "L"
                Case 1 : lblCL.Text = "M"
                Case 2 : lblCL.Text = "Q"
                Case 3 : lblCL.Text = "H"
            End Select
            lblQZ.Text = tbQuietZone.Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PerformMail()
        Try
            Using frmEmail As New EmailForm()
                frmEmail.StyleManager = Me.StyleManager
                Dim dr As DialogResult = frmEmail.ShowDialog()

                If dr = DialogResult.OK Then
                    Dim strEmail As String = frmEmail.Recipiant
                    Dim message As String = frmEmail.Message

                    If Not String.IsNullOrEmpty(strEmail) Then
                        Dim tmpQr As String = Path.Combine(Path.GetTempPath, Guid.NewGuid.ToString() & ".png")
                        pbQrCode.Image.Save(tmpQr)
                        Dim tmpFile As New FileInfo(tmpQr)

                        Dim network As New Network()
                        Dim code As Integer = network.SendMail(strEmail, message, tmpFile.FullName)

                        If code <> 0 Then
                            MessageBox.Show("Error sending E-Mail", "QR-Code Generator", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        tmpFile.Delete()
                    End If
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PerformSaveToDisk()
        Try
            Using saveFileDlg As New SaveFileDialog()
                Dim format As ImageFormat = _qr.ImageType

                If format.Equals(ImageFormat.Png) Then
                    saveFileDlg.Filter = "Png|*.png"
                ElseIf format.Equals(ImageFormat.Bmp) Then
                    saveFileDlg.Filter = "Bitmap|*.bmp"
                ElseIf format.Equals(ImageFormat.Gif) Then
                    saveFileDlg.Filter = "Gif|*.gif"
                End If

                saveFileDlg.FileName = "qr_image"

                Dim dr As DialogResult = saveFileDlg.ShowDialog()
                If dr = DialogResult.OK Then
                    pbQrCode.Image.Save(saveFileDlg.FileName)
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PerformFacebook()
        Try
            Dim frmFacebook As New FacebookForm(_qr.QR_Image)
            frmFacebook.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PerformTwitter()
        Try
            Dim twitter As New TwitterForm
            twitter.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PerformPrint()
        Try
            Using printDoc As New PrintDocument
                AddHandler printDoc.PrintPage, AddressOf Print_QR_Image

                Dim preview As New PrintPreviewDialog
                preview.Document = printDoc
                preview.StartPosition = FormStartPosition.CenterParent
                preview.WindowState = FormWindowState.Maximized

                Dim dr As DialogResult = preview.ShowDialog()
                If dr = DialogResult.OK Then
                    printDoc.Print()
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Print_QR_Image(sender As Object, e As PrintPageEventArgs)
        Try
            Dim offsetX As Integer = 10
            Dim offsetY As Integer = 10

            Dim image As Image = Me.pbQrCode.Image
            Dim pen As New Pen(Color.Black, 3)
            Dim rect As New Rectangle(0, 0, image.Width, image.Height)

            Dim g As Graphics = Graphics.FromImage(image)
            g.DrawRectangle(pen, rect)

            e.Graphics.DrawImage(image, offsetX, offsetY, image.Width, image.Height)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Try
            ToggleOptionsPanel()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mmEmail_Click(sender As Object, e As EventArgs) Handles mmEmail.Click
        Try
            PerformMail()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mmFacebook_Click(sender As Object, e As EventArgs) Handles mmFacebook.Click
        Try
            PerformFacebook()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mmTwitter_Click(sender As Object, e As EventArgs) Handles mmTwitter.Click
        Try
            PerformTwitter()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mmSaveToDisk_Click(sender As Object, e As EventArgs) Handles mmSaveToDisk.Click
        Try
            PerformSaveToDisk()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click
        Try
            PerformMail()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnFacebook_Click(sender As Object, e As EventArgs) Handles btnFacebook.Click
        Try
            PerformFacebook()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Try
            PerformPrint()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            PerformPrint()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSaveToDisk_Click(sender As Object, e As EventArgs) Handles btnSaveToDisk.Click
        Try
            PerformSaveToDisk()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub colPnlFront_Click(sender As Object, e As EventArgs)
        Try
            ChangeFrontColor()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub colPnlBack_Click(sender As Object, e As EventArgs)
        Try
            ChangeBackColor()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbCorrectionLevel_ValueChanged(sender As Object, e As EventArgs) Handles tbCorrectionLevel.ValueChanged
        Try
            If _initialized Then
                Me._qr.CorrectionLevel = tbCorrectionLevel.Value
                pbQrCode.Image = _qr.QR_Image

                DisplayImageValues()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tbQuietZone_ValueChanged(sender As Object, e As EventArgs) Handles tbQuietZone.ValueChanged
        Try
            If _initialized Then
                Me._qr.QuietZone = tbQuietZone.Value * 2
                pbQrCode.Image = _qr.QR_Image

                DisplayImageValues()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MyColorPickerBack_ValueChanged(sender As Object, e As EventArgs) Handles MyColorPickerBack.ValueChanged
        ChangeBackColor()
    End Sub

    Private Sub MyColorPickerFront_ValueChanged(sender As Object, e As EventArgs) Handles MyColorPickerFront.ValueChanged
        ChangeFrontColor()
    End Sub

    Private Sub QrForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sHelper = StyleHelper.Instance
            sHelper.ApplyTo(Me)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class