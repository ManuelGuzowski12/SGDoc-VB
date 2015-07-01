Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Datos
Imports Entidades
Public NotInheritable Class CajaBO
    Private Sub New()
    End Sub

    Public Shared Function GetAll() As List(Of CajaEntity)
        Return CajaDAL.GetAll()
    End Function

    Public Shared Function Guardar(caja As CajaEntity) As CajaEntity
        If CajaDAL.Exists(caja.id_caja) Then
            Return CajaDAL.Update(caja)
        Else
            Return CajaDAL.Create(caja)
        End If
    End Function

    Public Shared Function GetDep() As List(Of Departamento)
        Return BindingDAL.GetDep()
    End Function
    Public Shared Function GetTipo() As List(Of Tipos)
        Return CajaDAL.GetTipo()
    End Function

End Class
