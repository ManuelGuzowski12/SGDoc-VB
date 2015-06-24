Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Negocio
Imports Entidades
Public Class Usuarios
    Dim usuario As New UsersEntidades
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.DataSource = UsuarioBOL.GetAll()
    End Sub


    Private Sub Button_crear_user_Click(sender As Object, e As EventArgs) Handles Button_crear_user.Click
        usuario.id_persona = txt_idpersona.Text
        usuario.nombre = txt_nombre.Text
        usuario.apellido = txt_apellido.Text
        usuario.direccion = txt_direccion.Text
        usuario.telefono = txt_telefono.Text
        usuario.sexo = txt_sexo.Text
        usuario.username = txt_username.Text
        usuario.password = txt_password.Text
        UsuarioBOL.Save(usuario)
        dgv.DataSource = UsuarioBOL.GetAll()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick
        txt_idpersona.Text = dgv.CurrentRow.Cells(3).Value.ToString
        txt_nombre.Text = dgv.CurrentRow.Cells(4).Value.ToString
        txt_apellido.Text = dgv.CurrentRow.Cells(5).Value.ToString
        txt_direccion.Text = dgv.CurrentRow.Cells(6).Value.ToString
        txt_telefono.Text = dgv.CurrentRow.Cells(7).Value.ToString
        txt_sexo.Text = dgv.CurrentRow.Cells(8).Value.ToString
        txt_username.Text = dgv.CurrentRow.Cells(1).Value.ToString
        txt_password.Text = dgv.CurrentRow.Cells(2).Value.ToString
        txt_idpersona.Enabled = False
    End Sub

    Private Sub Button_actualizar_user_Click(sender As Object, e As EventArgs) Handles Button_actualizar_user.Click
        usuario.id_persona = txt_idpersona.Text
        usuario.nombre = txt_nombre.Text
        usuario.apellido = txt_apellido.Text
        usuario.direccion = txt_direccion.Text
        usuario.telefono = txt_telefono.Text
        usuario.sexo = txt_sexo.Text
        usuario.username = txt_username.Text
        usuario.password = txt_password.Text
        UsuarioBOL.Save(usuario)
        dgv.DataSource = UsuarioBOL.GetAll()
        Clear_textbox()
    End Sub

    Private Sub Button_Eliminar_user_Click(sender As Object, e As EventArgs) Handles Button_Eliminar_user.Click
        UsuarioBOL.Delete(txt_idpersona.Text)
        dgv.DataSource = UsuarioBOL.GetAll()
        Clear_textbox()
    End Sub

    Private Sub Clear_textbox()
        txt_idpersona.Text = ""
        txt_nombre.Text = ""
        txt_apellido.Text = ""
        txt_direccion.Text = ""
        txt_telefono.Text = ""
        txt_sexo.Text = ""
        txt_username.Text = ""
        txt_password.Text = ""
    End Sub
    
End Class