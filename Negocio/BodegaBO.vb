Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Datos
Imports Entidades
Public NotInheritable Class BodegaBO
    Private Sub New()
    End Sub

    Public Shared Function GetAll() As List(Of BodegaEntity)
        Return BodegaDAL.GetAll()
    End Function

    Public Shared Function Guardar(bod As BodegaEntity) As BodegaEntity
        If BodegaDAL.Exists(bod.id_bodega) Then
            Return BodegaDAL.Update(bod)
        Else
            Return BodegaDAL.Create(bod)
        End If
    End Function
End Class
