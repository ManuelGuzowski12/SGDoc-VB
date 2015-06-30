Imports Negocio
Imports Entidades
Public Class InsertRB
    Dim rbod As New RacksBodegaEntity
    Private Sub InsertRB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.DisplayMember = "codigo"
        ComboBox1.ValueMember = "id_rack"
        ComboBox1.DataSource = RackBodegaBO.GetRack


        ComboBox2.DisplayMember = "codigo"
        ComboBox2.ValueMember = "id_bodega"
        ComboBox2.DataSource = RackBodegaBO.GetBodega

        txtuser.Text = id_user
        txtuser.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        rbod.id_rack = ComboBox1.SelectedValue
        rbod.id_bodega = ComboBox2.SelectedValue
        rbod.fecha_insercion = txtdate.Text
        rbod.id_usuario = txtuser.Text
        RackBodegaBO.Guardar(rbod)
        ComboBox1.DataSource = RackBodegaBO.GetRack
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class