Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class TipoDoc
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
