Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class BodegaEntity
    Private _id_bodega As Integer
    Private _capacidad As Integer
    Private _codigo As String
    Private _descripcion As String

    Public Property id_bodega As Integer
        Get
            id_bodega = _id_bodega
        End Get
        Set(value As Integer)
            _id_bodega = value
        End Set
    End Property

    Public Property capacidad As Integer
        Get
            capacidad = _capacidad
        End Get
        Set(value As Integer)
            _capacidad = value
        End Set
    End Property

    Public Property codigo As String
        Get
            codigo = _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property descripcion As String
        Get
            descripcion = _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
End Class