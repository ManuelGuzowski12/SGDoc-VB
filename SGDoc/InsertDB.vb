Imports Negocio
Imports Entidades
Public Class InsertDB
    Dim docb As New DocBindingEntity
    Dim iddepdoc As New Documentos
    Dim iddepbin As New BindingEntity
    Dim doc As Integer
    Dim bin As Integer
    '-----------------
    Dim tipob As Integer
    Dim cap As Integer
    Dim cont As Integer

    Private Sub InsertDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DisplayMember = "nombre"
        ComboBox1.ValueMember = "id_doc"
        ComboBox1.DataSource = DocBindingBO.GetDoc
        
        ComboBox2.DisplayMember = "codigo"
        ComboBox2.ValueMember = "id_binding"
        ComboBox2.DataSource = DocBindingBO.GetBinding
        

        txtuser.Text = id_user
        txtuser.Enabled = False
       

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       

        If (doc = bin) And (cont < cap) Then

            docb.id_documento = ComboBox1.SelectedValue
            docb.id_binding = ComboBox2.SelectedValue
            docb.fecha_insercion = txtdate.Text
            docb.id_usuario = txtuser.Text
            DocBindingBO.Guardar(docb)
            MsgBox("Insertado Correctamente...")
            ComboBox1.DataSource = DocBindingBO.GetDoc

        Else
            MsgBox("Depertamento equivocado o Binding lleno")

        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        doc = DocBindingBO.Getdepdoc(CInt(ComboBox1.SelectedValue.ToString))

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        bin = DocBindingBO.Getdepbin(CInt(ComboBox2.SelectedValue.ToString))

        '-----
        tipob = DocBindingBO.GetTipo(CInt(ComboBox2.SelectedValue.ToString))
        cap = DocBindingBO.Getcap(tipob)
        cont = DocBindingBO.Count(CInt(ComboBox2.SelectedValue.ToString))
    End Sub

End Class