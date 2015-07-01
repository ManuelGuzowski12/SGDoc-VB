Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Imports Datos
Public Class DatosBusquedaBO
    Sub New()

    End Sub
    Public Shared Function InsertarDatos(datos As DatosBusqueda)
        Return DatosBusquedaDAL.InsertarDatos(datos)
    End Function
    Public Shared Function buscarPorId_doc(ByVal id_doc As String) As List(Of DatosBusqueda)
        Return DatosBusquedaDAL.buscar_Doc(id_doc)
    End Function
End Class
