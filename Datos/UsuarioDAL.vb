Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public NotInheritable Class UsuarioDAL
    Private Sub New()

    End Sub

    Public Shared Function GetAll() As List(Of UsersEntidades)
        Dim list As New List(Of UsersEntidades)
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT p.id_persona, p.nombre, p.apellido, p.direccion, p.telefono, p.sexo," & _
                " u.id_usuario, u.username, u.password  FROM Personas p, Usuarios u WHERE u.id_persona = p.id_persona and state = 0"
            Dim cmd As New SqlCommand(sql, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                list.Add(LoadUsuario(reader))
            End While
        End Using
        Return list
    End Function

    Public Shared Function Insert(usuario As UsersEntidades) As UsersEntidades
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "INSERT INTO Personas (id_persona, nombre, apellido, direccion, telefono, sexo) " & _
                              "VALUES (@id_persona, @nombre, @apellido, @direccion, @telefono, @sexo);" _
                              & "INSERT INTO Usuarios (id_persona, username, password, state) VALUES(@id_persona, @username, @password, 0) SELECT SCOPE_IDENTITY()"

            Dim cmd As New SqlCommand(sql, conn)

            cmd.Parameters.AddWithValue("@id_persona", usuario.id_persona)
            cmd.Parameters.AddWithValue("@nombre", usuario.nombre)
            cmd.Parameters.AddWithValue("@apellido", usuario.apellido)
            cmd.Parameters.AddWithValue("@direccion", usuario.direccion)
            cmd.Parameters.AddWithValue("@telefono", usuario.telefono)
            cmd.Parameters.AddWithValue("@sexo", usuario.sexo)
            cmd.Parameters.AddWithValue("@username", usuario.username)
            cmd.Parameters.AddWithValue("@password", usuario.password)
            usuario.id_usuario = Convert.ToInt32(cmd.ExecuteScalar())

        End Using
        Return usuario
    End Function
    Public Shared Function Update(usuario As UsersEntidades) As UsersEntidades

        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "UPDATE Personas SET nombre = @nombre, apellido = @apellido, direccion = @direccion, " & _
                                " telefono = @telefono, sexo = @sexo  WHERE id_persona = @id_persona;" & _
                                "UPDATE Usuarios SET username = @username, password = @password WHERE id_persona = @id_persona;"

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id_persona", usuario.id_persona)
            cmd.Parameters.AddWithValue("@nombre", usuario.nombre)
            cmd.Parameters.AddWithValue("@apellido", usuario.apellido)
            cmd.Parameters.AddWithValue("@direccion", usuario.direccion)
            cmd.Parameters.AddWithValue("@telefono", usuario.telefono)
            cmd.Parameters.AddWithValue("@sexo", usuario.sexo)
            cmd.Parameters.AddWithValue("@username", usuario.username)
            cmd.Parameters.AddWithValue("@password", usuario.password)
            cmd.ExecuteNonQuery()
        End Using

        Return usuario
    End Function
    Public Shared Function setPermisos(id_usuario As Integer)
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "insert into User_Mod(id_modulo, id_usuario, permiso)select  id_modulo,@id_usuario,'0' from  Modulo"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario)
            cmd.ExecuteNonQuery()

        End Using
        Return 0
    End Function
    Public Shared Function Desactivar_user(id_persona As String)
        Dim usuario As UsersEntidades = Nothing
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "Update Usuarios SET state = 1 WHERE id_persona = @id_persona"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id_persona", id_persona)
            cmd.ExecuteNonQuery()
        End Using
        Return usuario
    End Function
    Public Shared Function Exist(id_persona As String)
        Dim nrorecord As Integer = 0
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT Count(*) " & _
                                "FROM Usuarios " & _
                                "WHERE id_persona = @id_persona"

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id_persona", id_persona)
            nrorecord = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
        Return nrorecord > 0

    End Function
    Public Shared Function Verify_User(username As String, password As String)
        Dim nrorecord As Integer = 0
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT Count(*) " & _
                                "FROM usuarios " & _
                                "WHERE username = @username and password = @password and state = 0"

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("username", username)
            cmd.Parameters.AddWithValue("password", password)
            nrorecord = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
        Return nrorecord

    End Function
    Public Shared Function Verify_password(password As String)
        Dim nrorecord As Integer = 0
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT Count(*) FROM Usuarios Where password = @password"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("password", password)
            nrorecord = Convert.ToInt32(cmd.ExecuteScalar)
        End Using
        Return nrorecord > 0
    End Function
    Public Shared Function Get_idusuario(username As String)
        Dim idusuario As Integer
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "SELECT id_usuario from Usuarios where username = @username"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@username", username)
            idusuario = Convert.ToInt32(cmd.ExecuteScalar)
        End Using
        Return idusuario
    End Function

    Private Shared Function LoadUsuario(reader As IDataReader) As UsersEntidades
        Dim user As New UsersEntidades
        user.id_persona = Convert.ToString(reader("id_persona"))
        user.nombre = Convert.ToString(reader("nombre"))
        user.apellido = Convert.ToString(reader("apellido"))
        user.direccion = Convert.ToString(reader("direccion"))
        user.telefono = Convert.ToString(reader("telefono"))
        user.sexo = Convert.ToChar(reader("sexo"))
        user.id_usuario = Convert.ToInt32(reader("id_usuario"))
        user.username = Convert.ToString(reader("username"))
        user.password = Convert.ToString(reader("password"))

        Return user
    End Function
End Class
