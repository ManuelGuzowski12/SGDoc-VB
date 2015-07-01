Imports System.Linq
Imports System.Text
Imports Datos
Imports Entidades
Public NotInheritable Class CajaRackBO
    Private Sub New()
    End Sub

    Public Shared Function GetCaja() As List(Of CajaEntity)
        Return CajaRackDAL.GetCaja()
    End Function

    Public Shared Function GetRack() As List(Of RackEntity)
        Return CajaRackDAL.GetRack()
    End Function

    Public Shared Function Guardar(cajar As CajasRackEntity) As CajasRackEntity
        Return CajaRackDAL.Create(cajar)
    End Function

    '-----depto---

    Public Shared Function GetdepCaja(iddep As Integer) As Integer
        Return CajaRackDAL.Getdepcaja(iddep)
    End Function

    Public Shared Function GetdepRack(iddep As Integer) As Integer
        Return CajaRackDAL.GetdepRack(iddep)
    End Function

    '--------capacidad------
    '--- trae la capacidad
    Public Shared Function Getcap(idtipo As Integer) As Integer
        Return CajaRackDAL.Getcap(idtipo)
    End Function

    'cuenta 
    Public Shared Function Count(cont As Integer) As Integer
        Return CajaRackDAL.count(cont)
    End Function

    'tipo del rack
    Public Shared Function GetTipo(tipoR As Integer) As Integer
        Return CajaRackDAL.GetTipoR(tipoR)
    End Function
End Class
