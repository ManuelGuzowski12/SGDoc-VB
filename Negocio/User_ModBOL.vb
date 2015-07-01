Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Datos
Imports Entidades
Public Class User_ModBOL
    Private Sub New()

    End Sub
    Public Shared Function Permiso(id_modulo As Integer, id_usuario As Integer)
        Return User_ModDAL.Permiso(id_modulo, id_usuario)
    End Function
    Public Shared Function UpdatePermiso(id_modulo As Integer, id_usuario As Integer, permisos As Integer)
        User_ModDAL.UpdatePermiso(id_modulo, id_usuario, permisos)
        Return 0
    End Function
End Class
