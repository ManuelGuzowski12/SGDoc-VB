Imports Negocio
Imports Entidades
Public Class MostrarCaja

    Private Sub MostrarCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DisplayMember = "codigo"
        ComboBox1.ValueMember = "id_caja"
        ComboBox1.DataSource = BindingCajasBO.GetCaja
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgv.DataSource = BindingCajasBO.GetBinc(ComboBox1.SelectedValue)
    End Sub
End Class