Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class Departamentos
    Private _id_departamento As String
    Public Property id_departamento() As String
        Get
            Return _id_departamento
        End Get
        Set(ByVal value As String)
            _id_departamento = value
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
