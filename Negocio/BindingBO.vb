Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Datos
Imports Entidades
Public NotInheritable Class BindingBO
    Private Sub New()
    End Sub

    Public Shared Function GetAll() As List(Of BindingEntity)
        Return BindingDAL.GetAll()
    End Function

    Public Shared Function Guardar(binding As BindingEntity) As BindingEntity
        If BindingDAL.Exists(binding.id_binding) Then
            Return BindingDAL.Update(binding)
        Else
            Return BindingDAL.Create(binding)
        End If
    End Function

    Public Shared Function GetDep() As List(Of Departamento)
        Return BindingDAL.GetDep()
    End Function
    Public Shared Function GetTipo() As List(Of Tipos)
        Return BindingDAL.GetTipo()
    End Function

End Class

