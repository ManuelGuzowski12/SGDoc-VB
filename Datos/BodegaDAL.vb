Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Public NotInheritable Class BodegaDAL
    Private Sub New()
    End Sub

    Public Shared Function Exists(id_bodega As Integer) As Boolean
        Dim nrorecord As Integer = 0

        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT Count(*) " & _
                                "FROM Bodegas " & _
                                "WHERE id_bodega = @id_bodega "

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("id_bodega", id_bodega)
            nrorecord = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Return nrorecord > 0

    End Function

    Public Shared Function Create(bodega As BodegaEntity) As BodegaEntity
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "INSERT INTO Bodegas (capacidad, codigo, descripcion) " & _
                                "VALUES ( @capacidad, @codigo, @descripcion) "

            Dim cmd As New SqlCommand(sql, conn)


            cmd.Parameters.AddWithValue("@capacidad", bodega.capacidad)
            cmd.Parameters.AddWithValue("@codigo", bodega.codigo)
            cmd.Parameters.AddWithValue("@descripcion", bodega.descripcion)
            cmd.ExecuteNonQuery()

        End Using

        Return bodega
    End Function

    Public Shared Function GetAll() As List(Of BodegaEntity)
        Dim list As New List(Of BodegaEntity)()


        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT id_bodega, capacidad, codigo, descripcion FROM Bodegas ORDER BY codigo"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(LoadBodega(reader))
            End While
        End Using

        Return list
    End Function

    Public Shared Function Update(bodega As BodegaEntity) As BodegaEntity
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "UPDATE Bodegas SET  " & _
                                "capacidad = @capacidad, " & _
                                "codigo = @codigo, " & _
                                "descripcion = @descripcion " & _
                                "WHERE id_bodega = @id_bodega"

            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@capacidad", bodega.capacidad)
            cmd.Parameters.AddWithValue("@codigo", bodega.codigo)
            cmd.Parameters.AddWithValue("@descripcion", bodega.descripcion)
            cmd.ExecuteNonQuery()

        End Using

        Return bodega
    End Function

    Private Shared Function LoadBodega(reader As IDataReader) As BodegaEntity
        Dim bodega As New BodegaEntity()

        bodega.id_bodega = Convert.ToString(reader("id_bodega"))
        bodega.capacidad = Convert.ToString(reader("capacidad"))
        bodega.codigo = Convert.ToString(reader("codigo"))
        bodega.descripcion = Convert.ToString(reader("descripcion"))

        Return bodega
    End Function

    
End Class
