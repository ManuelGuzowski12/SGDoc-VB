Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class RacksBodegaEntity

    Private _id_rack As Integer
    Private _id_bodega As Integer
    Private _id_usuario As Integer
    Private _fecha_insercion As String


    Public Property id_rack As Integer
        Get
            id_rack = _id_rack
        End Get
        Set(value As Integer)
            _id_rack = value
        End Set
    End Property

    Public Property id_bodega As Integer
        Get
            id_bodega = _id_bodega
        End Get
        Set(value As Integer)
            _id_bodega = value
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