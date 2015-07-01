Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class User_ModDAL
    Public Shared Function Permiso(id_modulo As Integer, id_usario As Integer)
        Dim permisos As Integer
        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()
            Dim sql As String = "Select permiso from User_Mod where id_modulo = @id_modulo and id_usuario = @id_usuario"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id_modulo", id_modulo)
            cmd.Parameters.AddWithValue("@id_usuario", id_usario)
            permisos = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
        Return permisos
    End Function
    Public Shared Function UpdatePermiso(id_modulo As Integer, id_usuario As Integer, permiso As Integer)

        Using conn As New SqlConnection(conexion.Conexion())
            conn.Open()

            Dim sql As String = "UPDATE User_Mod set permiso = @permiso where id_modulo = @id_modulo and id_usuario = @id_usuario"

            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id_modulo", id_modulo)
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario)
            cmd.Parameters.AddWithValue("@permiso", permiso)
            cmd.ExecuteNonQuery()
        End Using

        Return 0
    End Function
End Class
