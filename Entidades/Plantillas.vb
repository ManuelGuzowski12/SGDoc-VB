Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Capas.Entidades.TipoDoc

Public Class Plantillas
    Private _id_plantilla As String

    Public Property id_plantilla() As String
        Get
            Return _id_plantilla
        End Get
        Set(ByVal value As String)
            _id_plantilla = value
        End Set
    End Property
    Private _id_tipoDoc As Integer
    Public Property id_tipodoc() As Integer
        Get
            Return _id_tipoDoc
        End Get
        Set(ByVal value As Integer)
            _id_tipoDoc = value
        End Set
    End Property
    Private _campo As String
    Public Property campo() As String
        Get
            Return _campo
        End Get
        Set(ByVal value As String)
            _campo = value
        End Set
    End Property
    Private _descripcion As String
    Public Property descripcon() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property



End Class
