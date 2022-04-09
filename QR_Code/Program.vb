Option Strict On
Option Explicit On

Imports System.Reflection

Class Program

    Private Shared _initialized As Boolean = False

    Shared Sub Main()
        Try
            EnsureInitialized()
            Application.Run(New MainForm())
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Shared Function AssemblyResolve(ByVal sender As Object, ByVal e As ResolveEventArgs) As Assembly
        Try
            Dim desiredAssembly = New AssemblyName(e.Name)
            Select Case desiredAssembly.Name
                Case "Gma.QrCodeNet.Encoding.Net35"
                    Return Assembly.Load(My.Resources.Gma_QrCodeNet_Encoding_Net35)
                Case "MetroFramework.Fonts"
                    Return Assembly.Load(My.Resources.MetroFramework_Fonts)
                Case "GMap.NET.Core"
                    Return Assembly.Load(My.Resources.GMap_NET_Core)
                Case "GMap.NET.WindowsForms"
                    Return Assembly.Load(My.Resources.GMap_NET_WindowsForms)
            End Select

            Return Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Shared Sub EnsureInitialized()
        Try
            If Not _initialized Then
                AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf AssemblyResolve
                _initialized = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class