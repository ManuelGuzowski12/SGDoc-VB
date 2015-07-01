Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Public NotInheritable Class DepartamentosDAL
    Sub New()

    End Sub
    Public Shared Function getDepartamentos() As List(Of Departamentos)
        Dim list As New List(Of Departamentos)
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT * FROM Departamentos ORDER BY id_dep"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(CargarDepartamentos(reader))
            End While
        End Using

        Return list
    End Function
    Public Shared Function getDepartamentosID(ByVal id_dep As String) As String
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT * FROM Departamentos where id_dep = @id_dep"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id_dep", id_dep)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Return reader("descripcion").ToString
            End While
        End Using


    End Function
    Private Shared Function CargarDepartamentos(reader As IDataReader) As Departamentos

        Dim dep As New Departamentos()
        With dep
            .id_departamento = reader("id_dep")
            .descripcion = reader("descripcion")
        End With

        Return dep
    End Function
End Class
