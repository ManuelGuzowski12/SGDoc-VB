Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Public NotInheritable Class BindingDAL
    Private Sub New()
    End Sub

    Public Shared Function Exists(id_binding As Integer) As Boolean
        Dim nrorecord As Integer = 0

        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT Count(*) " & _
                                "FROM Binding " & _
                                "WHERE id_binding = @id_binding "

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("id_binding", id_binding)
            nrorecord = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return nrorecord > 0

    End Function

    Public Shared Function Create(binding As BindingEntity) As BindingEntity
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "INSERT INTO Binding (id_tipo, id_dep, codigo) " & _
                                "VALUES ( @id_tipo, @id_dep, @codigo) "

            Dim cmd As New SqlCommand(sql, conn)


            cmd.Parameters.AddWithValue("@id_tipo", binding.id_tipo)
            cmd.Parameters.AddWithValue("@id_dep", binding.id_dep)
            cmd.Parameters.AddWithValue("@codigo", binding.codigo)
            cmd.ExecuteNonQuery()

        End Using

        Return binding
    End Function

    Public Shared Function GetAll() As List(Of BindingEntity)
        Dim list As New List(Of BindingEntity)()


        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT id_binding, id_tipo, id_dep, codigo FROM Binding ORDER BY codigo"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(LoadBinding(reader))
            End While
        End Using

        Return list
    End Function

    Public Shared Function Update(binding As BindingEntity) As BindingEntity
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "UPDATE Binding SET  " & _
                                "id_tipo = @id_tipo, " & _
                                "id_dep = @id_dep, " & _
                                "codigo= @codigo " & _
                                "WHERE id_binding = @id_binding"

            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_binding", binding.id_binding)
            cmd.Parameters.AddWithValue("@id_tipo", binding.id_tipo)
            cmd.Parameters.AddWithValue("@id_dep", binding.id_dep)
            cmd.Parameters.AddWithValue("@codigo", binding.codigo)
            cmd.ExecuteNonQuery()

        End Using

        Return binding
    End Function
    Private Shared Function LoadBinding(reader As IDataReader) As BindingEntity
        Dim binding As New BindingEntity()

        binding.id_binding = Convert.ToString(reader("id_binding"))
        binding.id_tipo = Convert.ToString(reader("id_tipo"))
        binding.id_dep = Convert.ToString(reader("id_dep"))
        binding.codigo = Convert.ToString(reader("codigo"))

        Return binding
    End Function

    Public Shared Function GetDep() As List(Of Departamento)
        Dim list As New List(Of Departamento)()


        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT  id_dep, descripcion FROM Departamentos"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(LoadDepto(reader))
            End While
        End Using

        Return list
    End Function

    Private Shared Function LoadDepto(reader As IDataReader) As Departamento
        Dim dep As New Departamento()
        dep.id_dep = Convert.ToString(reader("id_dep"))
        dep.descripcion = Convert.ToString(reader("descripcion"))

        Return dep
    End Function

    Private Shared Function LoadTipo(reader As IDataReader) As Tipos
        Dim tip As New Tipos()
        tip.id_tipo = Convert.ToString(reader("id_tipo"))
        tip.capacidad = Convert.ToString(reader("capacidad"))

        Return tip
    End Function


    Public Shared Function GetTipo() As List(Of Tipos)
        Dim list As New List(Of Tipos)()

        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT  id_tipo, capacidad FROM TipoBinding"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(LoadTipo(reader))
            End While
        End Using

        Return list
    End Function
    

End Class