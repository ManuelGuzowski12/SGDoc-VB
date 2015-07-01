Imports Negocio
Imports Entidades
Public Class MostrarBinding

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgv.DataSource = DocBindingBO.GetDocB(ComboBox1.SelectedValue)
    End Sub

    Private Sub MostrarBinding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DisplayMember = "codigo"
        ComboBox1.ValueMember = "id_binding"
        ComboBox1.DataSource = DocBindingBO.GetBinding
    End Sub
End Class