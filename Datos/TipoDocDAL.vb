Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Imports Datos
Public NotInheritable Class TipoDocDAL
    Sub New()

    End Sub
    Public Shared Function TiposDoc() As List(Of TipoDoc)
        Dim list As New List(Of TipoDoc)
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT * FROM TipoDoc ORDER BY id_tipodoc"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(cargarTipos(reader))
            End While
        End Using

        Return list
    End Function
    Public Shared Function buscarNombre(ByVal id_plantilla As String) As String
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT descripcion FROM TipoDoc where id_tipodoc = any(select id_tipodoc from Plantilla where id_plantilla = @plantilla)"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@plantilla", id_plantilla)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Return reader("descripcion")
            End While
        End Using
    End Function
    Public Shared Function cargarTipos(ByVal reader As IDataReader) As TipoDoc
        Dim tipo As New TipoDoc()
        With tipo
            .descripcion = reader("descripcion")
            .id_tipodoc = reader("id_tipodoc")
        End With
        Return tipo
    End Function
End Class
