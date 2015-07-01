Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades

Public NotInheritable Class ImagenesDAL
    Sub New()

    End Sub
    Public Shared Function Guardar(ByVal imagen As Imagenes)
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "INSERT INTO Imagenes ( id_documento, imagen) " & _
                                "VALUES (@id_documento, @imagen) " & _
                                "SELECT SCOPE_IDENTITY()"

            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_documento", imagen.id_doc)
            cmd.Parameters.AddWithValue("@imagen", imagen.imagen)

            cmd.ExecuteNonQuery()

        End Using
    End Function
    Public Shared Function buscarImagenes(ByVal id_doc As String) As List(Of Imagenes)
        Dim list As New List(Of Imagenes)
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT * FROM Imagenes where id_documento = @id_doc"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id_doc", id_doc)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(cargarImagenes(reader))
            End While
        End Using

        Return list
    End Function
    Public Shared Function cargarImagenes(ByVal reader As IDataReader) As Imagenes
        Dim img As New Imagenes()
        With img
            .id_imagen = reader("id_img")
            .id_doc = reader("id_documento")
            .imagen = reader("imagen")
        End With

        Return img
    End Function
End Class
