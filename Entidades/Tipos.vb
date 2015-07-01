Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class Tipos
    Private _id_tipo As Integer
    Private _capacidad As Integer

    Public Property id_tipo As Integer
        Get
            id_tipo = _id_tipo
        End Get
        Set(value As Integer)
            _id_tipo = value
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


End Class
