Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Public NotInheritable Class DocBindingDAL
    Private Sub New()
    End Sub

    Public Shared Function Create(docb As DocBindingEntity) As DocBindingEntity
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "INSERT INTO Doc_binding (id_documento, id_binding, id_usuario, fecha_insercion) " & _
                                "VALUES ( @id_documento, @id_binding, @id_usuario, @fecha_insercion) "

            Dim cmd As New SqlCommand(sql, conn)


            cmd.Parameters.AddWithValue("@id_documento", docb.id_documento)
            cmd.Parameters.AddWithValue("@id_binding", docb.id_binding)
            cmd.Parameters.AddWithValue("@id_usuario", docb.id_usuario)
            cmd.Parameters.AddWithValue("@fecha_insercion", docb.fecha_insercion)
            cmd.ExecuteNonQuery()

        End Using

        Return docb
    End Function

    'traer todos los documentos
    Public Shared Function GetDoc() As List(Of Documentos)
        Dim list As New List(Of Documentos)()


        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "select id_documento, nombre from Documentos where id_documento not in (select id_documento from Doc_binding)"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(Loaddocumento(reader))
            End While
        End Using

        Return list
    End Function

    Private Shared Function Loaddocumento(reader As IDataReader) As Documentos
        Dim doc As New Documentos()

        doc.id_doc = Convert.ToString(reader("id_documento"))
        doc.nombre = Convert.ToString(reader("nombre"))
        

        Return doc
    End Function

    'traer todos los binding
    Public Shared Function GetBinding() As List(Of BindingEntity)
        Dim list As New List(Of BindingEntity)()

        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT id_binding, codigo from Binding"
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
    'trae el id del dep del documento
    Public Shared Function Getdepdoc(id_dep As Integer) As Integer
        Dim dep As Integer
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT id_dep FROM Documentos where id_documento = @id_dep "
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_dep", id_dep)

            dep = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
        Return dep
    End Function

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

    '-------------------Capacidad------------------
    'cuenta cuantos binding hay con el id que le envio
    Public Shared Function count(id_binding As Integer) As Integer
        Dim idbin As Integer
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT COUNT(*) FROM Doc_binding where id_binding = @id_binding "
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_binding", id_binding)

            idbin = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
        Return idbin
    End Function

    'trae la capacidad del binding del id_tipo que le envio
    Public Shared Function Getcap(id_tipo As Integer) As Integer
        Dim cap As Integer
        ' cap = 0
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "select capacidad  from TipoBinding where id_tipo = @id_tipo "
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_tipo", id_tipo)

            cap = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
        Return cap
    End Function

    'compara el ide del tipo del binding
    Public Shared Function GetTipoB(id_binding As Integer) As Integer
        Dim idtipo As Integer
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "SELECT id_tipo FROM Binding where id_binding = @id_binding "
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_binding", id_binding)

            idtipo = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
        Return idtipo
    End Function


End Class
