Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class CajaEntity
    Private _id_caja As Integer
    Private _id_tipo As Integer
    Private _id_dep As Integer
    Private _codigo As String


    Public Property id_caja As Integer
        Get
            id_caja = _id_caja
        End Get
        Set(value As Integer)
            _id_caja = value
        End Set
    End Property

    Public Property id_tipo As Integer
        Get
            id_tipo = _id_tipo
        End Get
        Set(value As Integer)
            _id_tipo = value
        End Set
    End Property

    Public Property id_dep As Integer
        Get
            id_dep = _id_dep
        End Get
        Set(value As Integer)
            _id_dep = value
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

  
End Class
