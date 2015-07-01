Imports Negocio
Imports Entidades
Public Class InsertBC

    Dim binc As New BindingCajaEntity
    Dim iddepbin As New BindingEntity
    Dim iddepcaja As New CajaEntity
    Dim bin As Integer
    Dim caja As Integer
    '--------
    Dim tipoc As Integer
    Dim cap As Integer
    Dim cont As Integer
    Private Sub InsertBC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.DisplayMember = "codigo"
        ComboBox1.ValueMember = "id_binding"
        ComboBox1.DataSource = BindingCajasBO.GetBinding


        ComboBox2.DisplayMember = "codigo"
        ComboBox2.ValueMember = "id_caja"
        ComboBox2.DataSource = BindingCajasBO.GetCaja

        txtuser.Text = id_user
        txtuser.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (bin = caja) And (cont < cap) Then

            binc.id_binding = ComboBox1.SelectedValue
            binc.id_caja = ComboBox2.SelectedValue
            binc.fecha_insercion = txtdate.Text
            binc.id_usuario = txtuser.Text
            BindingCajasBO.Guardar(binc)
            MsgBox("Insertado Correctamente...")
            ComboBox1.DataSource = BindingCajasBO.GetBinding

        Else
            MsgBox("Depertamento equivocado o Caja llena ")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        bin = BindingCajasBO.Getdepbin(CInt(ComboBox1.SelectedValue.ToString))
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        caja = BindingCajasBO.Getdepcaja(CInt(ComboBox2.SelectedValue.ToString))
        '-----
        tipoc = BindingCajasBO.GetTipo(CInt(ComboBox2.SelectedValue.ToString))
        cap = BindingCajasBO.Getcap(tipoc)
        cont = BindingCajasBO.Count(CInt(ComboBox2.SelectedValue.ToString))
    End Sub
End Class