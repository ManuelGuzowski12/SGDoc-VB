Imports Negocio
Imports Entidades
Public Class CrearRack
    Dim rck As New RackEntity
    Private Sub CrearRack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = BindingBO.GetDep
        ComboBox1.DisplayMember = "descripcion"
        ComboBox1.ValueMember = "id_dep"

        ComboBox2.DataSource = RackBO.GetTipo
        ComboBox2.DisplayMember = "Capacidad"
        ComboBox2.ValueMember = "id_tipo"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        rck.id_tipo = ComboBox2.SelectedValue
        rck.id_dep = ComboBox1.SelectedValue
        rck.codigo = txtcod.Text
        RackBO.Guardar(rck)
        MsgBox("Rack Creado Correctamente")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class