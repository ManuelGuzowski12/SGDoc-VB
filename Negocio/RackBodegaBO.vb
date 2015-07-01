Imports System.Linq
Imports System.Text
Imports Datos
Imports Entidades
Public NotInheritable Class RackBodegaBO
    Private Sub New()
    End Sub

    Public Shared Function GetRack() As List(Of RackEntity)
        Return RackBodegaDAL.GetRack()
    End Function

    Public Shared Function GetBodega() As List(Of BodegaEntity)
        Return RackBodegaDAL.GetBodega()
    End Function

    Public Shared Function Guardar(rbod As RacksBodegaEntity) As RacksBodegaEntity
        Return RackBodegaDAL.Create(rbod)
    End Function
End Class
