
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class Buscar

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
    Private _id_usuario As String
    Public Property id_usuario() As String
        Get
            Return _id_usuario
        End Get
        Set(ByVal value As String)
            _id_usuario = value
        End Set
    End Property
    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Private _fecha_creacion As Date
    Public Property fecha_creacion() As Date
        Get
            Return _fecha_creacion
        End Get
        Set(ByVal value As Date)
            _fecha_creacion = value
        End Set
    End Property
    Private _activacion As String
    Public Property activacion() As String
        Get
            Return _activacion
        End Get
        Set(ByVal value As String)
            _activacion = value
        End Set
    End Property
    Private _id_departamento As String
    Public Property id_departamento() As String
        Get
            Return _id_departamento
        End Get
        Set(ByVal value As String)
            _id_departamento = value
        End Set
    End Property
    Private _id_tipodoc As String
    Public Property id_tipodoc() As String
        Get
            Return _id_tipodoc
        End Get
        Set(ByVal value As String)
            _id_tipodoc = value
        End Set
    End Property
    Private _descripcion As String
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property
End Class
