Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Public NotInheritable Class BindingCajaDAL
    Private Sub New()
    End Sub

    Public Shared Function Create(binc As BindingCajaEntity) As BindingCajaEntity
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "INSERT INTO Binding_Caja (id_binding, id_caja, id_usuario, fecha_insercion) " & _
                                "VALUES ( @id_binding, @id_caja, @id_usuario, @fecha_insercion) "

            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_binding", binc.id_binding)
            cmd.Parameters.AddWithValue("@id_caja", binc.id_caja)
            cmd.Parameters.AddWithValue("@id_usuario", binc.id_usuario)
            cmd.Parameters.AddWithValue("@fecha_insercion", binc.fecha_insercion)
            cmd.ExecuteNonQuery()

        End Using

        Return binc
    End Function

    'traer todos los binding que no esten en cajas
    Public Shared Function GetBinding() As List(Of BindingEntity)
        Dim list As New List(Of BindingEntity)()

        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "select id_binding, codigo from Binding where id_binding not in (select id_binding from Binding_Caja)"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(LoadBinding(reader))
            End While
        End Using

        Return list
    End Function

    Private Shared Function LoadBinding(reader As IDataReader) As BindingEntity
        Dim bin As New BindingEntity()

        bin.id_binding = Convert.ToString(reader("id_binding"))
        bin.codigo = Convert.ToString(reader("codigo"))


        Return bin
    End Function
    'trae las cajas
    Public Shared Function GetCaja() As List(Of CajaEntity)
        Dim list As New List(Of CajaEntity)()


        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT id_caja, codigo from Cajas"
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
    '----------deptos----------------
    'trae el id del dep del Binding
    Public Shared Function Getdepbin(id_dep As Integer) As Integer
        Dim depb As Integer
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT id_dep FROM Binding where id_binding = @id_dep "
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_dep", id_dep)

            depb = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
        Return depb
    End Function

    'trae el id del dep de la caja
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
    '-----------------------------------------------Capacidad----------------------
    '-----cuantas cajas hay en el id que le envio
    Public Shared Function count(id_caja As Integer) As Integer
        Dim idcaja As Integer
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT COUNT(*) FROM Binding_Caja where id_caja = @id_caja "
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_caja", id_caja)

            idcaja = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
        Return idcaja
    End Function

    'trae la capacidad de la caja del id_tipo que le envio
    Public Shared Function Getcap(id_tipo As Integer) As Integer
        Dim cap As Integer
        ' cap = 0
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "select capacidad  from TipoCaja where id_tipo = @id_tipo "
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_tipo", id_tipo)

            cap = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
        Return cap
    End Function

    'compara el id del tipo de la caja
    Public Shared Function GetTipoC(id_caja As Integer) As Integer
        Dim idtipo As Integer
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT id_tipo FROM Cajas where id_caja = @id_caja "
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_caja", id_caja)

            idtipo = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
        Return idtipo
    End Function
End Class
