Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class ModulosDAL
    Public Shared Function GetAll() As List(Of ModuloEntidades)
        Dim list As New List(Of ModuloEntidades)
        Using conn As New SqlConnection("Data Source=localhost\sqlexpress;Initial Catalog=sgdoc;" _
             & "Integrated Security=true;user id=student;password=12345")
            conn.Open()
            Dim sql As String = "SELECT * FROM Modulo"
            Dim cmd As New SqlCommand(sql, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                list.Add(LoadModulos(reader))
            End While
        End Using
        Return list
    End Function
    Private Shared Function LoadModulos(reader As IDataReader) As ModuloEntidades
        Dim user As New ModuloEntidades
        user.id_modulo = Convert.ToInt32(reader("id_modulo"))
        user.nombre = Convert.ToString(reader("nombre"))
        user.descripcion = Convert.ToString(reader("descripcion"))
        user.id_padre = Convert.ToInt32(reader("id_padre"))
        Return user
    End Function
End Class

