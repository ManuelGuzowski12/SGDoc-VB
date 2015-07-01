Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Public NotInheritable Class RackDAL
    Private Sub New()
    End Sub
    Public Shared Function Exists(id_rack As Integer) As Boolean
        Dim nrorecord As Integer = 0

        Using conn As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=SGDoc;" _
   & "Integrated Security=true;user id=student;password=12345")
            conn.Open()

            Dim sql As String = "SELECT Count(*) " & _
                                "FROM Racks " & _
                                "WHERE id_racks = @id_racks "

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("id_racks", id_rack)
            nrorecord = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return nrorecord > 0

    End Function

    Public Shared Function Create(rack As RackEntity) As RackEntity
        Using conn As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=SGDoc;" _
 & "Integrated Security=true;user id=student;password=12345")
            conn.Open()
            Dim sql As String = "INSERT INTO Racks (id_tipo, id_dep, codigo) " & _
                                "VALUES ( @id_tipo, @id_dep, @codigo) "

            Dim cmd As New SqlCommand(sql, conn)


            cmd.Parameters.AddWithValue("@id_tipo", rack.id_tipo)
            cmd.Parameters.AddWithValue("@id_dep", rack.id_dep)
            cmd.Parameters.AddWithValue("@codigo", rack.codigo)
            cmd.ExecuteNonQuery()

        End Using

        Return rack
    End Function

    Public Shared Function Update(rack As RackEntity) As RackEntity
        Using conn As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=SGDoc;" _
 & "Integrated Security=true;user id=student;password=12345")
            conn.Open()
            Dim sql As String = "UPDATE Racks SET  " & _
                                "id_tipo = @id_tipo, " & _
                                "id_dep = @id_dep, " & _
                                "codigo= @codigo " & _
                                "WHERE id_racks = @id_racks"

            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_racks", rack.id_rack)
            cmd.Parameters.AddWithValue("@id_tipo", rack.id_tipo)
            cmd.Parameters.AddWithValue("@id_dep", rack.id_dep)
            cmd.Parameters.AddWithValue("@codigo", rack.codigo)
            cmd.ExecuteNonQuery()

        End Using

        Return rack
    End Function

    Public Shared Function GetAll() As List(Of RackEntity)
        Dim list As New List(Of RackEntity)()
        Using conn As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=SGDoc;" _
   & "Integrated Security=true;user id=student;password=12345")
            conn.Open()

            Dim sql As String = "SELECT id_racks, id_tipo, id_dep, codigo FROM Racks ORDER BY codigo"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(LoadRack(reader))
            End While
        End Using

        Return list
    End Function

    Private Shared Function LoadRack(reader As IDataReader) As RackEntity
        Dim rack As New RackEntity()

        rack.id_rack = Convert.ToString(reader("id_racks"))
        rack.id_tipo = Convert.ToString(reader("id_tipo"))
        rack.id_dep = Convert.ToString(reader("id_dep"))
        rack.codigo = Convert.ToString(reader("codigo"))

        Return rack
    End Function

    Public Shared Function GetTipo() As List(Of Tipos)
        Dim list As New List(Of Tipos)()

        Using conn As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=SGDoc;" _
   & "Integrated Security=true;user id=student;password=12345")
            conn.Open()

            Dim sql As String = "SELECT  id_tipo, capacidad FROM TipoRack"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(LoadTipo(reader))
            End While
        End Using

        Return list
    End Function

    Private Shared Function LoadTipo(reader As IDataReader) As Tipos
        Dim tip As New Tipos()
        tip.id_tipo = Convert.ToString(reader("id_tipo"))
        tip.capacidad = Convert.ToString(reader("capacidad"))

        Return tip
    End Function
End Class
