Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Entidades
Imports Datos
Public NotInheritable Class TipoDocBO
    Sub New()

    End Sub
    Public Shared Function MostrarTipoDoc() As List(Of TipoDoc)
        Return TipoDocDAL.TiposDoc()
    End Function
    Public Shared Function buscarNombre(ByVal id_plantilla As String) As String
        Return TipoDocDAL.buscarNombre(id_plantilla)
    End Function
End Class
