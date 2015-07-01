Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Datos
Imports Entidades
Public Class ModuloBOL
    Public Shared Function GetAll() As List(Of UsersEntidades)
        Return UsuarioDAL.GetAll
    End Function
End Class
