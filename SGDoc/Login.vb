Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Negocio
Imports Entidades


Public Class Login
    Private usuario As New UsersEntidades
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim count As Integer
        count = UsuarioBOL.Verify(txt_username.Text, txt_password.Text)
        If count = 1 Then
            MsgBox("Bienvenido!...")
            user = txt_username.Text
            Usuarios.Show()
            Me.Hide()
        Else
            MsgBox("No encontrado!...")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("GOOD BYE!...")
        Me.Close()
    End Sub
End Class