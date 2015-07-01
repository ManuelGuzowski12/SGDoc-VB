Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Entidades
Imports Datos
Public Class DepartamentosBO
    Sub New()

    End Sub
    Public Shared Function getDepartamentos() As List(Of Departamentos)
        Return DepartamentosDAL.getDepartamentos()
    End Function
    Public Shared Function getDepartamentosID(ByVal id_dep As String) As String
        Return DepartamentosDAL.getDepartamentosID(id_dep)
    End Function

End Class
