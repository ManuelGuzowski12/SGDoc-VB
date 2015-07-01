Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Negocio
Imports Entidades
Public Class Permisos
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ck_admifisica.Checked = True Then
            User_ModBOL.UpdatePermiso(2, id, 1)
        Else
            User_ModBOL.UpdatePermiso(2, id, 0)
        End If
        If ck_binding.Checked = True Then
            User_ModBOL.UpdatePermiso(3, id, 1)
        Else
            User_ModBOL.UpdatePermiso(3, id, 0)
        End If
        If ck_caja.Checked = True Then
            User_ModBOL.UpdatePermiso(4, id, 1)
        Else
            User_ModBOL.UpdatePermiso(4, id, 0)
        End If
        If ck_racks.Checked = True Then
            User_ModBOL.UpdatePermiso(5, id, 1)
        Else
            User_ModBOL.UpdatePermiso(5, id, 0)
        End If
        If ck_bodegas.Checked = True Then
            User_ModBOL.UpdatePermiso(6, id, 1)
        Else
            User_ModBOL.UpdatePermiso(6, id, 0)
        End If
        If ck_documentos.Checked = True Then
            User_ModBOL.UpdatePermiso(7, id, 1)
        Else
            User_ModBOL.UpdatePermiso(7, id, 0)
        End If
        If ck_crear.Checked = True Then
            User_ModBOL.UpdatePermiso(8, id, 1)
        Else
            User_ModBOL.UpdatePermiso(8, id, 0)
        End If
        If ck_modificar.Checked = True Then
            User_ModBOL.UpdatePermiso(9, id, 1)
        Else
            User_ModBOL.UpdatePermiso(9, id, 0)
        End If
        If ck_menu.Checked = True Then
            User_ModBOL.UpdatePermiso(10, id, 1)
        Else
            User_ModBOL.UpdatePermiso(10, id, 0)
        End If
        If ck_admi_usuario.Checked = True Then
            User_ModBOL.UpdatePermiso(1011, id, 1)
        Else
            User_ModBOL.UpdatePermiso(1011, id, 0)
        End If
        LoadPermisos()
        Me.Close()
    End Sub

    Private Sub Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPermisos()
    End Sub

    Private Function LoadPermisos()
        Dim permiso As Integer
        permiso = User_ModBOL.Permiso(2, id)
        If permiso = 0 Then
            ck_admifisica.Checked = False
        Else
            ck_admifisica.Checked = True
        End If
        permiso = User_ModBOL.Permiso(3, id)
        If permiso = 0 Then
            ck_binding.Checked = False
        Else
            ck_binding.Checked = True
        End If
        permiso = User_ModBOL.Permiso(4, id)
        If permiso = 0 Then
            ck_caja.Checked = False
        Else
            ck_caja.Checked = True
        End If
        permiso = User_ModBOL.Permiso(5, id)
        If permiso = 0 Then
            ck_racks.Checked = False
        Else
            ck_racks.Checked = True
        End If
        permiso = User_ModBOL.Permiso(6, id)
        If permiso = 0 Then
            ck_bodegas.Checked = False
        Else
            ck_bodegas.Checked = True
        End If
        permiso = User_ModBOL.Permiso(7, id)

        If permiso = 0 Then
            ck_documentos.Checked = False
        Else
            ck_documentos.Checked = True
        End If

        permiso = User_ModBOL.Permiso(8, id)
        If permiso = 0 Then
            ck_crear.Checked = False
        Else
            ck_crear.Checked = True
        End If
        permiso = User_ModBOL.Permiso(9, id)
        If permiso = 0 Then
            ck_modificar.Checked = False
        Else
            ck_modificar.Checked = True
        End If
        permiso = User_ModBOL.Permiso(10, id)
        If permiso = 0 Then
            ck_menu.Checked = False
        Else
            ck_menu.Checked = True
        End If
        permiso = User_ModBOL.Permiso(1011, id)
        If permiso = 0 Then
            ck_admi_usuario.Checked = False
        Else
            ck_admi_usuario.Checked = True
        End If
        Return 0
    End Function
End Class