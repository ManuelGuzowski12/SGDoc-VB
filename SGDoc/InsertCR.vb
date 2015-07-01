Imports Negocio
Imports Entidades
Public Class InsertCR
    Dim cajar As New CajasRackEntity

    Dim iddepcaja As New CajaEntity
    Dim iddepRck As New RackEntity
    Dim caja As Integer
    Dim rck As Integer
    '--------
    Dim tipor As Integer
    Dim cap As Integer
    Dim cont As Integer
    Private Sub InsertCR_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ComboBox1.DisplayMember = "codigo"
        ComboBox1.ValueMember = "id_caja"
        ComboBox1.DataSource = CajaRackBO.GetCaja


        ComboBox2.DisplayMember = "codigo"
        ComboBox2.ValueMember = "id_rack"
        ComboBox2.DataSource = CajaRackBO.GetRack

        txtuser.Text = id_user
        txtuser.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (caja = rck) And (cont < cap) Then
            cajar.id_caja = ComboBox1.SelectedValue
            cajar.id_rack = ComboBox2.SelectedValue
            cajar.fecha_insercion = txtdate.Text
            cajar.id_usuario = txtuser.Text

            CajaRackBO.Guardar(cajar)
            MsgBox("Insertado Correctamente...")
            Me.Close()

        Else
            MsgBox("Depertamento equivocado o Rack lleno ")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        caja = CajaRackBO.GetdepCaja(CInt(ComboBox1.SelectedValue.ToString))
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        rck = CajaRackBO.GetdepRack(CInt(ComboBox2.SelectedValue.ToString))
        '-----
        tipor = CajaRackBO.GetTipo(CInt(ComboBox2.SelectedValue.ToString))
        cap = CajaRackBO.Getcap(tipor)
        cont = CajaRackBO.Count(CInt(ComboBox2.SelectedValue.ToString))
    End Sub
End Class