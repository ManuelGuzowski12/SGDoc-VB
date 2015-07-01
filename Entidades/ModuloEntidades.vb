Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class ModuloEntidades

    Private u_id_modulo As Integer
    Private u_nombre As String
    Private u_descripcion As String
    Private u_id_padre As Integer

    Public Property id_modulo As Integer
        Get
            Return u_id_modulo
        End Get
        Set(ByVal value As Integer)
            u_id_modulo = value
        End Set
    End Property
    Public Property nombre As String
        Get
            Return u_nombre
        End Get
        Set(ByVal value As String)
            u_nombre = value
        End Set
    End Property
    Public Property descripcion As String
        Get
            Return u_descripcion
        End Get
        Set(ByVal value As String)
            u_descripcion = value
        End Set
    End Property
    Public Property id_padre As Integer
        Get
            Return u_id_padre
        End Get
        Set(ByVal value As Integer)
            u_id_padre = value
        End Set
    End Property
End Class
