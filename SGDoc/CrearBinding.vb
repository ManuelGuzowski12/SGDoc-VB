Imports Negocio
Imports Entidades
Public Class CrearBinding
    Dim bin As New BindingEntity
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = BindingBO.GetDep
        ComboBox1.DisplayMember = "descripcion"
        ComboBox1.ValueMember = "id_dep"

        ComboBox2.DataSource = BindingBO.GetTipo
        ComboBox2.DisplayMember = "Capacidad"
        ComboBox2.ValueMember = "id_tipo"


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bin.id_tipo = ComboBox2.SelectedValue
        bin.id_dep = ComboBox1.SelectedValue
        bin.codigo = txtcod.Text
        BindingBO.Guardar(bin)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
