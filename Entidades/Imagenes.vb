Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Public Class Imagenes
    Private _id_imagen As String
    Public Property id_imagen() As String
        Get
            Return _id_imagen
        End Get
        Set(ByVal value As String)
            _id_imagen = value

        End Set
    End Property
    Private _id_doc As String
    Public Property id_doc() As String
        Get
            Return _id_doc
        End Get
        Set(ByVal value As String)
            _id_doc = value
        End Set
    End Property
    Private _imagen As Byte()
    Public Property imagen() As Byte()
        Get
            Return _imagen
        End Get
        Set(ByVal value As Byte())
            _imagen = value
        End Set
    End Property
   

    Public Function convertir(ByVal direccion As String) As Byte()
        Dim memoria As MemoryStream = New MemoryStream()
        Dim lectura As FileStream = New FileStream(direccion, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)

        memoria.SetLength(lectura.Length)
        lectura.Read(memoria.GetBuffer, 0, lectura.Length)

        imagen = memoria.GetBuffer
        memoria.Flush()
        lectura.Close()
    End Function

End Class
