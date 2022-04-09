Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions

Public Class RegexHelper

    Public Shared Function IsValidURL(ByVal input As String) As Boolean
        Try
            Dim regex As New Regex("^http\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(/\S*)?$")
            Return regex.IsMatch(input)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function IsValidEmail(ByVal input As String) As Boolean
        Try
            Dim regex As New Regex("^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
            Return regex.IsMatch(input)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function IsValidPhoneNumber(ByVal input As String) As Boolean
        Try
            Dim regex As New Regex("((\(\d{3,4}\)|\d{3,4}-)\d{4,9}(-\d{1,5}|\d{0}))|(\d{4,12})")
            Return regex.IsMatch(input)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function IsValidTime(ByVal input As String) As Boolean
        Try
            Dim regex As New Regex("[0-2][0-3]\:[0-5][0-9]")
            Return regex.IsMatch(input)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class