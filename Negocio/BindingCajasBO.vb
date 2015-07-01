Imports System.Linq
Imports System.Text
Imports Datos
Imports Entidades
Public NotInheritable Class BindingCajasBO
    Private Sub New()
    End Sub

    Public Shared Function GetBinding() As List(Of BindingEntity)
        Return BindingCajaDAL.GetBinding()
    End Function

    Public Shared Function GetCaja() As List(Of CajaEntity)
        Return BindingCajaDAL.GetCaja()
    End Function

    Public Shared Function Guardar(binc As BindingCajaEntity) As BindingCajaEntity
        Return BindingCajaDAL.Create(binc)
    End Function
    '-----depto---
    Public Shared Function Getdepbin(iddep As Integer) As Integer
        Return BindingCajaDAL.Getdepbin(iddep)
    End Function

    Public Shared Function Getdepcaja(iddep As Integer) As Integer
        Return BindingCajaDAL.Getdepcaja(iddep)
    End Function
    '--------capacidad------
    '--- trae la capacidad
    Public Shared Function Getcap(idtipo As Integer) As Integer
        Return BindingCajaDAL.Getcap(idtipo)
    End Function

    'cuenta 
    Public Shared Function Count(cont As Integer) As Integer
        Return BindingCajaDAL.count(cont)
    End Function

    'tipo del caja
    Public Shared Function GetTipo(tipoc As Integer) As Integer
        Return BindingCajaDAL.GetTipoC(tipoc)
    End Function

End Class
