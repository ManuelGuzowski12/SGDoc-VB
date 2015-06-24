Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class PersonaEntidades
    Private u_id_persona As String
    Private u_nombre As String
    Private u_apellido As String
    Private u_direccion As String
    Private u_telefono As String
    Private u_sexo As Char

    Public Property id_persona As String
        Get
            Return u_id_persona
        End Get
        Set(ByVal value As String)
            u_id_persona = value
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
    Public Property apellido As String
        Get
            Return u_apellido
        End Get
        Set(ByVal value As String)
            u_apellido = value
        End Set
    End Property
    Public Property direccion As String
        Get
            Return u_direccion
        End Get
        Set(ByVal value As String)
            u_direccion = value
        End Set
    End Property
    Public Property telefono As String
        Get
            Return u_telefono
        End Get
        Set(ByVal value As String)
            u_telefono = value
        End Set
    End Property
    Public Property sexo As String
        Get
            Return u_sexo
        End Get
        Set(ByVal value As String)
            u_sexo = value
        End Set
    End Property
End Class
