Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class DocBindingEntity
    Private _id_documento As Integer
    Private _id_binding As Integer
    Private _id_usuario As Integer
    Private _fecha_insercion As String

    Public Property id_documento As Integer
        Get
            id_documento = _id_documento
        End Get
        Set(value As Integer)
            _id_documento = value
        End Set
    End Property

    Public Property id_binding As Integer
        Get
            id_binding = _id_binding
        End Get
        Set(value As Integer)
            _id_binding = value
        End Set
    End Property

    Public Property id_usuario As Integer
        Get
            id_usuario = _id_usuario
        End Get
        Set(value As Integer)
            _id_usuario = value
        End Set
    End Property

    Public Property fecha_insercion As String
        Get
            fecha_insercion = _fecha_insercion
        End Get
        Set(value As String)
            _fecha_insercion = value
        End Set
    End Property
End Class
