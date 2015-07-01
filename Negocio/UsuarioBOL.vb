Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Datos
Imports Entidades
Imports System.Security
Imports System.Security.Cryptography.SHA512
Imports System.Windows.Forms
Public NotInheritable Class UsuarioBOL

    Private Sub New()

    End Sub
    Public Shared Function GetAll() As List(Of UsersEntidades)
        Return UsuarioDAL.GetAll
    End Function
    Public Shared Function Save_User(usuario As UsersEntidades) As UsersEntidades
        Dim user As New UsuarioBOL
        Dim password As String
        password = user.EncryptSHA512(usuario.username, usuario.password)
        usuario.password = password
        If UsuarioDAL.Exist(usuario.id_persona) Then
            MsgBox("Este usuario ya existe!...")
        Else
            UsuarioDAL.Insert(usuario)
            UsuarioDAL.setPermisos(usuario.id_usuario)
        End If
        Return usuario
    End Function
    Public Shared Function Update_User(usuario As UsersEntidades) As UsersEntidades
        Dim user As New UsuarioBOL
        Dim password As String
        Dim username As String
        password = usuario.password
        username = usuario.username
        If UsuarioDAL.Verify_password(password) Then
            Return UsuarioDAL.Update(usuario)
        Else
            password = user.EncryptSHA512(username, password)
            usuario.password = password
            Return UsuarioDAL.Update(usuario)
        End If
        Return usuario
    End Function
    Public Shared Function Delete(id_persona As String)
        Return UsuarioDAL.Desactivar_user(id_persona)
    End Function
    Public Shared Function Verify(username As String, password As String)
        Dim user As New UsuarioBOL
        password = user.EncryptSHA512(username, password)
        Dim count As Integer
        Try
            count = UsuarioDAL.Verify_User(username, password)
        Catch ex As Exception
            MsgBox("Error" + ex.Message)
        End Try
        Return count
    End Function
    Private Function EncryptSHA512(username As String, password As String)
        Dim SHA512 As New Security.Cryptography.SHA512CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(username + password)
        ByteString = SHA512.ComputeHash(ByteString)
        Dim FinalString As String = Nothing
        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next
        Return FinalString
    End Function
    Public Shared Function GetId_user(username As String)
        Return UsuarioDAL.Get_idusuario(username)
    End Function
End Class
