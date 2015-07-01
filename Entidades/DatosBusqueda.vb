Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class DatosBusqueda
    Private _id_datobusqueda As String
    Public Property id_datobusqueda() As String
        Get
            Return _id_datobusqueda
        End Get
        Set(ByVal value As String)
            _id_datobusqueda = value
        End Set
    End Property
    Private _id_doc As String
    Public Property id_doc() As String
        Get
            Return _id_doc
        End Get
        Set(ByVal value As String)
            _id_doc = value
        End Set
    End Property
    Private _id_plantilla As String
    Public Property id_plantilla() As String
        Get
            Return _id_plantilla
        End Get
        Set(ByVal value As String)
            _id_plantilla = value
        End Set
    End Property
    Private _valor As String
    Public Property valor() As String
        Get
            Return _valor
        End Get
        Set(ByVal value As String)
            _valor = value
        End Set
    End Property



End Class
