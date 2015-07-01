Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Entidades
Imports Datos
Public NotInheritable Class PlantillasBO
    Private Sub New()
    End Sub
    Public Shared Function MostrarPlantilla(ByVal id_tipo As Integer) As List(Of Plantillas)
        Return PlantillasDAL.plantilla(id_tipo)
    End Function
    Public Shared Function buscarNombreCampo(ByVal id_plantilla As String) As String
        Return PlantillasDAL.getNombreCampos(id_plantilla)
    End Function
End Class
