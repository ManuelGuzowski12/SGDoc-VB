Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Datos
Imports Entidades
Public NotInheritable Class DocBindingBO
    Private Sub New()
    End Sub

    Public Shared Function GetDoc() As List(Of Documentos)
        Return DocBindingDAL.GetDoc()
    End Function


    Public Shared Function GetBinding() As List(Of BindingEntity)
        Return DocBindingDAL.GetBinding()
    End Function

    Public Shared Function Guardar(docb As DocBindingEntity) As DocBindingEntity
        Return DocBindingDAL.Create(docb)
    End Function
    '------depto-----
    Public Shared Function Getdepdoc(iddep As Integer) As Integer
        Return DocBindingDAL.Getdepdoc(iddep)
    End Function

    Public Shared Function Getdepbin(iddep As Integer) As Integer
        Return DocBindingDAL.Getdepbin(iddep)
    End Function
    '------capacidad--------
    'trae la capacidad
    Public Shared Function Getcap(idtipo As Integer) As Integer
        Return DocBindingDAL.Getcap(idtipo)
    End Function

    'cuenta 
    Public Shared Function Count(cont As Integer) As Integer
        Return DocBindingDAL.count(cont)
    End Function

    'tipo del binding
    Public Shared Function GetTipo(tipob As Integer) As Integer
        Return DocBindingDAL.GetTipoB(tipob)
    End Function
End Class
