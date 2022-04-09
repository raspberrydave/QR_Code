Option Explicit On
Option Strict On

Imports MetroFramework
Imports MetroFramework.Components
Imports MetroFramework.Forms
Imports MetroFramework.Interfaces

Public NotInheritable Class StyleHelper

    Private Shared _instance As StyleHelper
    Private Shared _styleManager As MetroStyleManager
    Private Shared ReadOnly _mutex As New Object


    Private Sub New()
        Try
            _styleManager = New MetroStyleManager
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Singleton
    ''' </summary>
    ''' <returns>Instance of Config Class</returns>
    Public Shared ReadOnly Property Instance As StyleHelper
        Get
            SyncLock _mutex
                If _instance Is Nothing Then
                    _instance = New StyleHelper
                End If
            End SyncLock
            Return _instance
        End Get
    End Property

    Public Sub ApplyTo(form As MetroForm)
        Try
            form.StyleManager = _styleManager
            SetControlStyle(form)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SetControlStyle(ByVal container As Control)
        Try
            For Each ctrl As Control In container.Controls
                If TypeOf ctrl IsNot myColorPicker Then
                    SetControlStyle(ctrl)

                    If TypeOf ctrl Is IMetroControl Then
                        Dim metroCtrl As IMetroControl = DirectCast(ctrl, IMetroControl)

                        metroCtrl.Theme = _styleManager.Theme
                        metroCtrl.Style = _styleManager.Style
                    Else
                        Select Case _styleManager.Theme
                            Case MetroThemeStyle.Light
                                ctrl.ForeColor = Color.FromArgb(100, 100, 100)
                                'ctrl.ForeColor = Color.FromKnownColor(KnownColor.WindowText)
                                ctrl.BackColor = Color.FromKnownColor(KnownColor.Window)
                            Case MetroThemeStyle.Dark
                                ctrl.ForeColor = Color.FromArgb(153, 153, 153)
                                ctrl.BackColor = Color.FromArgb(17, 17, 17)
                        End Select
                    End If
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetStyleColor() As Color
        Try
            Select Case _styleManager.Style
                Case MetroColorStyle.Black : Return Color.FromArgb(0, 0, 0)
                Case MetroColorStyle.Blue : Return Color.FromArgb(0, 174, 219)
                Case MetroColorStyle.Brown : Return Color.FromArgb(165, 81, 0)
                Case MetroColorStyle.Default : Return Color.FromArgb(0, 174, 219)
                Case MetroColorStyle.Green : Return Color.FromArgb(0, 177, 89)
                Case MetroColorStyle.Lime : Return Color.FromArgb(142, 188, 0)
                Case MetroColorStyle.Magenta : Return Color.FromArgb(255, 0, 148)
                Case MetroColorStyle.Orange : Return Color.FromArgb(243, 119, 53)
                Case MetroColorStyle.Pink : Return Color.FromArgb(231, 113, 189)
                Case MetroColorStyle.Purple : Return Color.FromArgb(124, 65, 153)
                Case MetroColorStyle.Red : Return Color.FromArgb(209, 17, 65)
                Case MetroColorStyle.Silver : Return Color.FromArgb(85, 85, 85)
                Case MetroColorStyle.Teal : Return Color.FromArgb(0, 170, 173)
                Case MetroColorStyle.White : Return Color.FromArgb(255, 255, 255)
                Case MetroColorStyle.Yellow : Return Color.FromArgb(255, 196, 37)
                Case Else
                    Return Color.FromArgb(0, 174, 219)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetContrastColor(ByVal color As Color) As Color
        Return If(color.GetBrightness() > 0.5, Color.Black, Color.White)
    End Function

    Public Property Style As MetroColorStyle
        Get
            Return _styleManager.Style
        End Get
        Set(value As MetroColorStyle)
            _styleManager.Style = value
        End Set
    End Property

    Public Property Theme As MetroThemeStyle
        Get
            Return _styleManager.Theme
        End Get
        Set(value As MetroThemeStyle)
            _styleManager.Theme = value
        End Set
    End Property

End Class