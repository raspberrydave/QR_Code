Imports System.Runtime.Serialization

<DataContract>
Public Class FriendList

    Private m_Friend As FriendData()

    <DataMember(Name:="data")>
    Public Property [Friend]() As FriendData()
        Get
            Return m_Friend
        End Get
        Set
            m_Friend = Value
        End Set
    End Property

End Class

<DataContract>
Public Class FriendData

    Private m_id As String
    Private m_name As String

    <DataMember>
    Public Property id() As String
        Get
            Return m_id
        End Get
        Set
            m_id = Value
        End Set
    End Property

    <DataMember>
    Public Property name() As String
        Get
            Return m_name
        End Get
        Set
            m_name = Value
        End Set
    End Property

End Class