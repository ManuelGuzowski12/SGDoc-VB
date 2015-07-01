Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Imports Datos
Public NotInheritable Class DocumentosDAL
    Sub New()

    End Sub
    Public Shared Function GetAll() As List(Of Documentos)
        Dim list As New List(Of Documentos)
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT * FROM documentos where activacion = 1 ORDER BY fecha_creacion"
            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                list.Add(CargarDocumentos(reader))
            End While
        End Using

        Return list
    End Function
    Public Shared Function buscar_por_ID(ByVal id_doc As String) As Documentos
        Dim doc As New Documentos
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT * FROM documentos where id_documento = @id_doc"
            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_doc", id_doc)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                doc = CargarDocumentos(reader)
            End While
        End Using

        Return doc
    End Function
    Private Shared Function CargarDocumentos(reader As IDataReader) As Documentos

        Dim doc As New Documentos()
        With doc
            .id_doc = reader("id_documento")
            .id_usuario = reader("id_usuario")
            .nombre = reader("nombre")
            .id_departamento = reader("id_dep")
            .activacion = reader("activacion")
            .fecha_creacion = reader("fecha_creacion")

        End With
        
        Return doc
    End Function
    Public Shared Function InsertarDocumentos(ByVal documento As Documentos) As Documentos
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "INSERT INTO Documentos (id_usuario, nombre, fecha_creacion, activacion, id_dep) " & _
                                "VALUES (@id_usuario, @nombre, @fecha, @activacion, @id_dep) " & _
                                "SELECT SCOPE_IDENTITY()"

            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_usuario", documento.id_usuario)
            cmd.Parameters.AddWithValue("@nombre", documento.nombre)
            cmd.Parameters.AddWithValue("@fecha", documento.fecha_creacion.ToShortDateString)
            cmd.Parameters.AddWithValue("@activacion", documento.activacion)
            cmd.Parameters.AddWithValue("@id_dep", documento.id_departamento)

            documento.id_doc = Convert.ToString(cmd.ExecuteScalar())
        End Using

        Return documento
    End Function
    

    Public Shared Function buscar(ByVal yo As String) As List(Of Documentos)
        Dim doc As List(Of Documentos) = New List(Of Documentos)
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "select * from Documentos where id_documento = any(select id_documento from DatosBusquda where id_plantilla = any(select id_plantilla from plantilla where campo like'%" & yo & "%' or id_tipodoc = any(select id_tipodoc from TipoDoc where descripcion like'%" & yo & "%')) or valor like'%" & yo & "%') or fecha_creacion like'%" & yo.ToString & "%' or id_dep = any(select id_dep from Departamentos where descripcion like'%" & yo & "%') or nombre like'%" & yo & "%' or id_usuario = any(select id_usuario from Usuarios where id_persona = any(Select id_persona  from Personas where nombre like'%" & yo & "%'))"

            Dim cmd As New SqlCommand(sql, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                doc.Add(CargarDocumentos(reader))
            End While
        End Using

        Return doc
    End Function
    Public Shared Function actualizar(documento As Documentos)
        Using conn As New SqlConnection(conexion.Conexion)
            conn.Open()

            Dim sql As String = "UPDATE Documentos SET activacion = @activacion WHERE id_documento = @id"

            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@activacion", documento.activacion)
            cmd.Parameters.AddWithValue("@id", documento.id_doc)



            cmd.ExecuteNonQuery()
        End Using

    End Function


End Class
