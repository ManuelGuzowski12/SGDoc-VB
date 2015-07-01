Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Public NotInheritable Class CajaRackDAL
    Private Sub New()
    End Sub

    Public Shared Function Create(cajar As CajasRackEntity) As CajasRackEntity
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "INSERT INTO Cajas_rack ( id_caja, id_rack, id_usuario, fecha_insercion) " & _
                                "VALUES ( @id_caja, @id_rack, @id_usuario, @fecha_insercion) "

            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_caja", cajar.id_caja)
            cmd.Parameters.AddWithValue("@id_rack", cajar.id_rack)
            cmd.Parameters.AddWithValue("@id_usuario", cajar.id_usuario)
            cmd.Parameters.AddWithValue("@fecha_insercion", cajar.fecha_insercion)
            cmd.ExecuteNonQuery()

        End Using

        Return cajar
    End Function

    'traer todas las cajas que no esten en rack
    Public Shared Function GetCaja() As List(Of CajaEntity)
        Dim list As New List(Of CajaEntity)()

        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "select id_caja, codigo from Cajas where id_caja not in (select id_caja from Cajas_rack)"
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
        caja.codigo = Convert.ToString(reader("codigo"))


        Return caja
    End Function

    'trae los Rack
    Public Shared Function GetRack() As List(Of RackEntity)
        Dim list As New List(Of RackEntity)()


        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT id_racks, codigo from Racks"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(LoadRack(reader))
            End While
        End Using

        Return list
    End Function

    Private Shared Function LoadRack(reader As IDataReader) As RackEntity
        Dim rsk As New RackEntity()

        rsk.id_rack = Convert.ToString(reader("id_racks"))
        rsk.codigo = Convert.ToString(reader("codigo"))


        Return rsk
    End Function
    '--------------------deptos----------
    'trae el id del dep de las cajas
    Public Shared Function Getdepcaja(id_dep As Integer) As Integer
        Dim depc As Integer
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT id_dep FROM Cajas where id_caja = @id_dep "
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_dep", id_dep)

            depc = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
        Return depc
    End Function

    'trae el id del dep del rack
    Public Shared Function GetdepRack(id_dep As Integer) As Integer
        Dim depr As Integer
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT id_dep FROM Racks where id_racks = @id_dep "
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_dep", id_dep)

            depr = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
        Return depr
    End Function

    '------------Capacidad-----------------------
    '-----cuantas racks hay en el id que le envio
    Public Shared Function count(id_rack As Integer) As Integer
        Dim idrck As Integer
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT COUNT(*) FROM Cajas_rack where id_rack = @id_rack "
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_rack", id_rack)

            idrck = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
        Return idrck
    End Function

    'trae la capacidad del rack del id_tipo que le envio
    Public Shared Function Getcap(id_tipo As Integer) As Integer
        Dim cap As Integer
        ' cap = 0
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "select capacidad  from TipoRack where id_tipo = @id_tipo "
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_tipo", id_tipo)

            cap = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
        Return cap
    End Function

    'compara el id del tipo del rack
    Public Shared Function GetTipoR(id_rack As Integer) As Integer
        Dim idtipo As Integer
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT id_tipo FROM Racks where id_racks = @id_racks "
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_racks", id_rack)

            idtipo = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
        Return idtipo
    End Function
End Class
