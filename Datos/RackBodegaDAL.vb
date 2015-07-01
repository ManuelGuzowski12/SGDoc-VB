Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Public NotInheritable Class RackBodegaDAL
    Private Sub New()
    End Sub

    Public Shared Function Create(rbod As RacksBodegaEntity) As RacksBodegaEntity
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "INSERT INTO Racks_bodega ( id_rack, id_bodega, id_usuario, fecha_insercion) " & _
                                "VALUES ( @id_rack, @id_bodega, @id_usuario, @fecha_insercion) "

            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_rack", rbod.id_rack)
            cmd.Parameters.AddWithValue("@id_bodega", rbod.id_bodega)
            cmd.Parameters.AddWithValue("@id_usuario", rbod.id_usuario)
            cmd.Parameters.AddWithValue("@fecha_insercion", rbod.fecha_insercion)
            cmd.ExecuteNonQuery()

        End Using

        Return rbod
    End Function

    'traer todos los rack que no esten en bodega
    Public Shared Function GetRack() As List(Of RackEntity)
        Dim list As New List(Of RackEntity)()

        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "select id_racks, codigo from Racks where id_racks not in (select id_rack from Racks_bodega)"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(LoadRsk(reader))
            End While
        End Using

        Return list
    End Function
    Private Shared Function LoadRsk(reader As IDataReader) As RackEntity
        Dim rsk As New RackEntity()

        rsk.id_rack = Convert.ToString(reader("id_racks"))
        rsk.codigo = Convert.ToString(reader("codigo"))

        Return rsk
    End Function

    'trae las bodegas
    Public Shared Function GetBodega() As List(Of BodegaEntity)
        Dim list As New List(Of BodegaEntity)()


        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT id_bodega, codigo from Bodegas"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(LoadBodega(reader))
            End While
        End Using

        Return list
    End Function

    Private Shared Function LoadBodega(reader As IDataReader) As BodegaEntity
        Dim bod As New BodegaEntity()


        bod.id_bodega = Convert.ToString(reader("id_bodega"))
        bod.codigo = Convert.ToString(reader("codigo"))


        Return bod
    End Function
End Class
