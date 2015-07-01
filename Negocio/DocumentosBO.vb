Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Imports Datos
Public Class DocumentosBO
    Sub New()

    End Sub
    Public Shared Function InsertarDocumentos(ByVal documento As Documentos)
        Return DocumentosDAL.InsertarDocumentos(documento)
    End Function
    Public Shared Function GetAll() As List(Of Documentos)
        Return DocumentosDAL.GetAll()
    End Function
    Public Shared Function buscar(ByVal id_doc As String) As Documentos
        Return DocumentosDAL.buscar_por_ID(id_doc)
    End Function
    Public Shared Function buscarX(ByVal yo As String) As List(Of Documentos)
        Return DocumentosDAL.buscar(yo)
    End Function
    Public Shared Function actualizar(ByVal doc As Documentos)
        Return DocumentosDAL.actualizar(doc)
    End Function
End Class
