Imports Negocio
Imports Entidades
Public Class CrearCaja
    Dim caja As New CajaEntity
    Private Sub CrearCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = BindingBO.GetDep
        ComboBox1.DisplayMember = "descripcion"
        ComboBox1.ValueMember = "id_dep"

        ComboBox2.DataSource = cajaBO.GetTipo
        ComboBox2.DisplayMember = "Capacidad"
        ComboBox2.ValueMember = "id_tipo"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        caja.id_tipo = ComboBox2.SelectedValue
        caja.id_dep = ComboBox1.SelectedValue
        caja.codigo = txtcod.Text
        CajaBO.Guardar(caja)
        MsgBox("Caja Creada Correctamente")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class