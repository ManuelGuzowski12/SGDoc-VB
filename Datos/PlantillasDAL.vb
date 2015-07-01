
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Imports Datos

Public NotInheritable Class PlantillasDAL
    Sub New()

    End Sub
    Public Shared Function plantilla(ByVal id_tipo As Integer) As List(Of Plantillas)
        Dim list As New List(Of Plantillas)
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT * FROM Plantilla WHERE id_tipodoc = @id_tipo ORDER BY id_plantilla"

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id_tipo", id_tipo)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(cargarPlantilla(reader))
            End While
        End Using

        Return list
    End Function
    Public Shared Function getNombreCampos(ByVal id_plantilla As String) As String
        Dim nombre As String = ""
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT * FROM Plantilla WHERE id_plantilla = @id_plantilla"

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id_plantilla", id_plantilla)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                nombre = reader("campo")
            End While
        End Using

        Return nombre
    End Function
    Public Shared Function cargarPlantilla(ByVal reader As IDataReader) As Plantillas
        Dim plantilla As New Plantillas()
        With plantilla
            .id_plantilla = reader("id_plantilla")
            .id_tipodoc = reader("id_tipodoc")
            .campo = reader("campo")
            .descripcon = reader("descripcion")
        End With
        Return plantilla
    End Function

End Class
