Imports Negocio
Imports Entidades
Public Class CrearBodega

    Dim bod As New BodegaEntity
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        bod.capacidad = txtcap.Text
        bod.codigo = txtcod.Text
        bod.descripcion = txtdesc.Text
        BodegaBO.Guardar(bod)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class