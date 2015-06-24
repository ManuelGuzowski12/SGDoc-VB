Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class UsersEntidades

    Inherits PersonaEntidades

    Private u_id_usuario As Integer
    Private u_username As String
    Private u_password As String


    Public Property id_usuario As Integer
        Get
            Return u_id_usuario
        End Get
        Set(ByVal value As Integer)
            u_id_usuario = value
        End Set
    End Property

    Public Property username As String
        Get
            Return u_username
        End Get
        Set(ByVal value As String)
            u_username = value
        End Set
    End Property

    Public Property password As String
        Get
            Return u_password
        End Get
        Set(ByVal value As String)
            u_password = value
        End Set
    End Property

End Class
