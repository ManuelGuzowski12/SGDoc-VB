Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Public NotInheritable Class DatosBusquedaDAL
    Sub New()

    End Sub
    Public Shared Function InsertarDatos(ByVal datos As DatosBusqueda)
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "INSERT INTO DatosBusquda ( id_documento, id_plantilla, valor) " & _
                                "VALUES (@id_documento, @id_plantilla, @valor) " & _
                                "SELECT SCOPE_IDENTITY()"

            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_documento", datos.id_doc)
            cmd.Parameters.AddWithValue("@id_plantilla", datos.id_plantilla)
            cmd.Parameters.AddWithValue("@valor", datos.valor)

            cmd.ExecuteNonQuery()

        End Using

        Return datos
    End Function
    Public Shared Function buscar_Doc(ByVal id_doc As String) As List(Of DatosBusqueda)
        Dim datos As List(Of DatosBusqueda) = New List(Of DatosBusqueda)
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT * FROM DatosBusquda where id_documento = @id_doc"
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_doc", id_doc)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                datos.Add(CargarDatos(reader))
            End While
        End Using

        Return datos
    End Function
    Private Shared Function CargarDatos(reader As IDataReader) As DatosBusqueda

        Dim doc As New DatosBusqueda()
        With doc
            .id_doc = reader("id_documento")
            .id_datobusqueda = reader("id_busqueda")
            .id_plantilla = reader("id_plantilla")
            .valor = reader("valor")

        End With

        Return doc
    End Function
    
End Class
