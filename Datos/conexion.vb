Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public NotInheritable Class conexion
    Sub New()

    End Sub
    Public Shared Function Conexion() As String
        Dim con As String
        con = "Data Source="
        con += "localhost\SQLEXPRESS;"
        con += "Initial Catalog="
        con += "SGdoc;"
        con += "Integrated Security="
        con += "True;"
        con += "user id="
        con += "student;"
        con += "password="
        con += "12345"
        Return con
    End Function
End Class
