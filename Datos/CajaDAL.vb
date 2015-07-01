Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Public NotInheritable Class CajaDAL
    Private Sub New()
    End Sub

    Public Shared Function Exists(id_caja As Integer) As Boolean
        Dim nrorecord As Integer = 0

        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT Count(*) " & _
                                "FROM Cajas " & _
                                "WHERE id_caja = @id_caja "

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("id_caja", id_caja)
            nrorecord = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return nrorecord > 0

    End Function
    Public Shared Function Create(caja As CajaEntity) As CajaEntity
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "INSERT INTO Cajas (id_tipo, id_dep, codigo) " & _
                                "VALUES ( @id_tipo, @id_dep, @codigo) "

            Dim cmd As New SqlCommand(sql, conn)


            cmd.Parameters.AddWithValue("@id_tipo", caja.id_tipo)
            cmd.Parameters.AddWithValue("@id_dep", caja.id_dep)
            cmd.Parameters.AddWithValue("@codigo", caja.codigo)
            cmd.ExecuteNonQuery()

        End Using

        Return caja
    End Function


    Public Shared Function Update(caja As CajaEntity) As CajaEntity
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "UPDATE Cajas SET  " & _
                                "id_tipo = @id_tipo, " & _
                                "id_dep = @id_dep, " & _
                                "codigo= @codigo " & _
                                "WHERE id_caja = @id_caja"

            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_caja", caja.id_caja)
            cmd.Parameters.AddWithValue("@id_tipo", caja.id_tipo)
            cmd.Parameters.AddWithValue("@id_dep", caja.id_dep)
            cmd.Parameters.AddWithValue("@codigo", caja.codigo)
            cmd.ExecuteNonQuery()

        End Using

        Return caja
    End Function

    Public Shared Function GetAll() As List(Of CajaEntity)
        Dim list As New List(Of CajaEntity)()


        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT id_caja, id_tipo, id_dep, codigo FROM Cajas ORDER BY codigo"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(LoadCaja(reader))
            End While
        End Using

        Return list
    End Function

    Private Shared Function LoadCaja(reader As IDataReader) As CajaEntity
        Dim caja As New CajaEntity()

        caja.id_caja = Convert.ToString(reader("id_caja"))
        caja.id_tipo = Convert.ToString(reader("id_tipo"))
        caja.id_dep = Convert.ToString(reader("id_dep"))
        caja.codigo = Convert.ToString(reader("codigo"))

        Return caja
    End Function
    Public Shared Function GetTipo() As List(Of Tipos)
        Dim list As New List(Of Tipos)()

        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT  id_tipo, capacidad FROM TipoCaja"
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
