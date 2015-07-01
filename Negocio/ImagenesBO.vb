Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Imports Datos
Public Class ImagenesBO
    Sub New()

    End Sub
    Public Shared Function guardar(ByVal imagen As Imagenes)
        Return ImagenesDAL.Guardar(imagen)
    End Function
    Public Shared Function buscar(ByVal id_doc As String) As List(Of Imagenes)
        Return ImagenesDAL.buscarImagenes(id_doc)

    End Function
End Class
