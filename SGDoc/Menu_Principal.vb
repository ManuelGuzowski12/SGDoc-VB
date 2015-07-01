Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Negocio
Imports Entidades
Public Class Menu_Principal

    Private Sub Menu_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If User_ModBOL.Permiso(1011, id_user) = 1 Then
            AdministracionDeUsuariosYPermisosToolStripMenuItem.Enabled = True
        Else
            AdministracionDeUsuariosYPermisosToolStripMenuItem.Enabled = False
        End If
        If User_ModBOL.Permiso(2, id_user) = 1 Then
            AdministracionFisicaToolStripMenuItem.Enabled = True
        Else
            AdministracionFisicaToolStripMenuItem.Enabled = False
        End If
        If User_ModBOL.Permiso(3, id_user) = 1 Then
            BindingToolStripMenuItem.Enabled = True
        Else
            BindingToolStripMenuItem.Enabled = False
        End If
        If User_ModBOL.Permiso(4, id_user) = 1 Then
            CajasToolStripMenuItem.Enabled = True
        Else
            CajasToolStripMenuItem.Enabled = False
        End If
        If User_ModBOL.Permiso(5, id_user) = 1 Then
            RacksToolStripMenuItem.Enabled = True
        Else
            RacksToolStripMenuItem.Enabled = False
        End If
        If User_ModBOL.Permiso(6, id_user) = 1 Then
            BodegasToolStripMenuItem.Enabled = True
        Else
            BodegasToolStripMenuItem.Enabled = False
        End If
        If User_ModBOL.Permiso(7, id_user) = 1 Then
            GestionDocumentalToolStripMenuItem.Enabled = True
        Else
            GestionDocumentalToolStripMenuItem.Enabled = False
        End If
        If User_ModBOL.Permiso(8, id_user) = 1 Then
            CrearToolStripMenuItem.Enabled = True
        Else
            CrearToolStripMenuItem.Enabled = False
        End If
        If User_ModBOL.Permiso(9, id_user) = 1 Then
            ModificarToolStripMenuItem.Enabled = True
        Else
            ModificarToolStripMenuItem.Enabled = False
        End If
    End Sub
    Private Sub AdministracionDeUsuariosYPermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministracionDeUsuariosYPermisosToolStripMenuItem.Click
        Usuarios.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CrearNuevoBindingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearNuevoBindingToolStripMenuItem.Click
        CrearBinding.Show()
    End Sub

    Private Sub InsertarDocumentoEnBindingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarDocumentoEnBindingToolStripMenuItem.Click
        InsertDB.Show()
    End Sub

    Private Sub CrearNuevaCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearNuevaCajaToolStripMenuItem.Click
        CrearCaja.Show()
    End Sub

    Private Sub InsertarBindingEnCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarBindingEnCajaToolStripMenuItem.Click
        InsertBC.Show()
    End Sub

    Private Sub CrearNuevoRackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearNuevoRackToolStripMenuItem.Click
        CrearRack.Show()

    End Sub

    Private Sub InsertarRackEnBodegaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarRackEnBodegaToolStripMenuItem.Click
        InsertCR.Show()
    End Sub

    Private Sub CrearNuevaBodegaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearNuevaBodegaToolStripMenuItem.Click
        CrearBodega.Show()

    End Sub

    Private Sub InsertarRackABodegaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarRackABodegaToolStripMenuItem.Click
        InsertRB.Show()
    End Sub

    Private Sub CrearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearToolStripMenuItem.Click
        doc.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        VerDoc.Show()
    End Sub
End Class