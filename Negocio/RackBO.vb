Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Datos
Imports Entidades
Public NotInheritable Class RackBO
    Private Sub New()
    End Sub

    Public Shared Function GetAll() As List(Of RackEntity)
        Return RackDAL.GetAll()
    End Function

    Public Shared Function Guardar(rack As RackEntity) As RackEntity
        If RackDAL.Exists(rack.id_rack) Then
            Return RackDAL.Update(rack)
        Else
            Return RackDAL.Create(rack)
        End If
    End Function

    Public Shared Function GetDep() As List(Of Departamento)
        Return BindingDAL.GetDep()
    End Function
    Public Shared Function GetTipo() As List(Of Tipos)
        Return RackDAL.GetTipo()
    End Function

End Class
