Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class User_ModEntidades
    Private u_id_modulo As Integer
    Private u_id_usuario As Integer
    Private u_permiso As Integer

    Public Property id_modulo As Integer
        Get
            Return u_id_modulo
        End Get
        Set(ByVal value As Integer)
            u_id_modulo = value
        End Set
    End Property
    Public Property id_usuario As Integer
        Get
            Return u_id_usuario
        End Get
        Set(ByVal value As Integer)
            u_id_usuario = value
        End Set
    End Property

    Public Property permiso As Integer
        Get
            Return u_permiso
        End Get
        Set(ByVal value As Integer)
            u_permiso = value
        End Set
    End Property
End Class
