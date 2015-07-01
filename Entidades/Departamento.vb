Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class Departamento
    Private _id_dep As Integer
    Private _descripcion As String


    Public Property id_dep As Integer
        Get
            id_dep = _id_dep
        End Get
        Set(value As Integer)
            _id_dep = value
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

