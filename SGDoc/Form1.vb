Public Class Form1

    Dim libros As New Libros
    Dim autores As New Autores
    Dim estudiantes As New Estudiantes
    Dim datatable As New Object
    Dim adater As New Object
    Private _x As Integer
    Property x As Integer
        Get
            x = _x
        End Get
        Set(ByVal value As Integer)
            _x = value
        End Set
    End Property

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        libros.usardatos.msconexion = "Data Source=NIELSEN\SQLEXPRESS;Initial Catalog=biblioteca;Integrated Security=True;user id=mel;password=12345"
        autores.usardatos.msconexion = "Data Source=NIELSEN\SQLEXPRESS;Initial Catalog=biblioteca;Integrated Security=True;user id=mel;password=12345"
        estudiantes.usardatos.msconexion = "Data Source=NIELSEN\SQLEXPRESS;Initial Catalog=biblioteca;Integrated Security=True;user id=mel;password=12345"
        Select Case x
            Case 1
                Button2.Visible = False
                cargarLabel(1)
                mostrar()
            Case 2
                Button2.Visible = False
                cargarLabel(2)
                mostrar()
            Case 3
                Button2.Visible = False
                cargarLabel(3)
                mostrar()

        End Select




    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Select Case x
            Case 1
                libros.isbn = TextBox1.Text
                libros.titulo = TextBox2.Text
                libros.idautor = TextBox3.Text
                libros.edicion = TextBox4.Text
                libros.editorial = TextBox5.Text
                libros.fechaPublicacion = TextBox6.Text
                If libros.existeAutor() Then
                    libros.insertar()
                    limpiar()
                    mostrar()
                Else
                    If (MessageBox.Show("NO existe El autor al que hace referencia, " & libros.idautor & ".\n" +
                   "¿Quieres agregar un nuevo autor?", "No existe el autor", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                        limpiar()
                        cargarLabel(10)
                    End If
                End If
            Case 2
                autores.idautor = TextBox1.Text
                autores.nombre = TextBox2.Text
                autores.apellido = TextBox3.Text
                autores.fechaNacimiento = TextBox4.Text
                autores.sexo = TextBox5.Text
                autores.nacionalidad = TextBox6.Text
                autores.insertar()
                limpiar()
                mostrar()
            Case 3
                estudiantes.idestudiante = TextBox1.Text
                estudiantes.nombre = TextBox2.Text
                estudiantes.apellido = TextBox3.Text
                estudiantes.correo = TextBox4.Text
                estudiantes.direccion = TextBox5.Text
                estudiantes.bachiller = TextBox6.Text
                estudiantes.insertar()
                limpiar()
                mostrar()

        End Select
    End Sub
    Function mostrar()
        Select Case x
            Case 1
                libros.usardatos.ptabla = "libros"
                libros.usardatos.plistadecampos = "isbn,titulo,idautor,edicion,editorial,fechaPublicacion"
                libros.usardatos.pcondicion = ""
                dgv.DataSource = libros.usardatos.MostrarRegistro()
            Case 2
                autores.usardatos.ptabla = "autores"
                autores.usardatos.plistadecampos = "idautor,nombre,apellido,fechadenacimiento,lugardenacimiento,sexo"
                autores.usardatos.pcondicion = ""
                dgv.DataSource = autores.usardatos.MostrarRegistro()
            Case 3
                estudiantes.usardatos.ptabla = "estudiantes"
                estudiantes.usardatos.plistadecampos = "idestudiante,nombre,apellido,correo,direccion,bachiller"
                estudiantes.usardatos.pcondicion = ""
                dgv.DataSource = estudiantes.usardatos.MostrarRegistro()
        End Select
        
    End Function
    Function cargarLabel(a As Integer)
        Select Case a
            Case 1

                Label1.Text = "ISBN"
                Label2.Text = "Titulo del Libro"
                Label3.Text = "Id de Autor"
                Label4.Text = "Edicion #"
                Label5.Text = "Editorial"
                Label6.Text = "Fecha de Publicacion"
                TextBox1.Enabled = True
                Button1.Visible = True
                Button1.Enabled = True
                Button2.Visible = False
                Button3.Enabled = False
                Button4.Enabled = False
                TextBox8.Visible = False
                Label8.Visible = False
            Case 10
                Label1.Text = "Id Autor"
                Label2.Text = "Nombre"
                Label3.Text = "Apellido"
                Label4.Text = "Fecha de Nacimiento"
                Label5.Text = "Sexo"
                Label6.Text = "Lugar de Nacimiento"
                TextBox1.Text = libros.idautor
                TextBox1.Enabled = False
                Label6.Visible = True
                Button2.Visible = True
                Button1.Visible = False
                Button4.Enabled = False
                TextBox8.Visible = False
                Label8.Visible = False
            Case 2
                Label1.Text = "Id Autor"
                Label2.Text = "Nombre"
                Label3.Text = "Apellido"
                Label4.Text = "Fecha de Nacimiento"
                Label5.Text = "Sexo"
                Label6.Text = "Lugar de Nacimiento"
                Label6.Visible = True
                TextBox8.Visible = False
                Label8.Visible = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button1.Enabled = True
                TextBox1.Enabled = True
            Case 3
                Label1.Text = "Cedula"
                Label2.Text = "Nombre"
                Label3.Text = "Apellido"
                Label4.Text = "Correo Electronico"
                Label5.Text = "Direccion"
                Label6.Text = "Bachiller"
                Label6.Visible = True
                TextBox8.Visible = False
                Label8.Visible = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button1.Enabled = True
                TextBox1.Enabled = True

        End Select
    End Function
    Function limpiar()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox8.Text = ""
    End Function

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        autores.idautor = TextBox1.Text
        autores.nombre = TextBox2.Text
        autores.apellido = TextBox3.Text
        autores.fechaNacimiento = TextBox4.Text
        autores.sexo = TextBox5.Text
        autores.nacionalidad = TextBox6.Text
        autores.insertar()
        libros.idautor = TextBox1.Text
        libros.insertar()
        mostrar()
        limpiar()
        cargarLabel(1)
    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox7.TextChanged
        Select Case x
            Case 1
                libros.busco = TextBox7.Text
                dgv.DataSource = libros.buscar()
            Case 2
                autores.busco = TextBox7.Text
                dgv.DataSource = autores.buscar()
            Case 3
                estudiantes.busco = TextBox7.Text
                dgv.DataSource = estudiantes.buscar()
        End Select
    End Sub

    Private Sub dgv_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentDoubleClick
        cargarDGV(1)
    End Sub
    Function cargarDGV(x As Integer)
        Select Case x
            Case 1
                TextBox1.Text = dgv.CurrentRow.Cells(0).Value.ToString
                TextBox2.Text = dgv.CurrentRow.Cells(1).Value.ToString
                TextBox3.Text = dgv.CurrentRow.Cells(2).Value.ToString
                TextBox4.Text = dgv.CurrentRow.Cells(3).Value.ToString
                TextBox5.Text = dgv.CurrentRow.Cells(4).Value.ToString
                TextBox6.Text = dgv.CurrentRow.Cells(5).Value.ToString
                Button1.Enabled = False
                TextBox1.Enabled = False
                Button3.Enabled = True
                Button4.Enabled = True
                Button5.Enabled = True
        End Select

    End Function

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Select Case x
            Case 1
                libros.isbn = TextBox1.Text
                libros.titulo = TextBox2.Text
                libros.idautor = TextBox3.Text
                libros.edicion = TextBox4.Text
                libros.editorial = TextBox5.Text
                libros.actualizar()
                cargarLabel(1)
                limpiar()
                mostrar()
            Case 2
                autores.idautor = TextBox1.Text
                autores.nombre = TextBox2.Text
                autores.apellido = TextBox3.Text
                autores.fechaNacimiento = TextBox4.Text
                autores.sexo = TextBox5.Text
                autores.nacionalidad = TextBox6.Text
                autores.actualizar()
                TextBox1.Enabled = True
                Button1.Enabled = True
                limpiar()
                mostrar()
            Case 3
                estudiantes.idestudiante = TextBox1.Text
                estudiantes.nombre = TextBox2.Text
                estudiantes.apellido = TextBox3.Text
                estudiantes.correo = TextBox4.Text
                estudiantes.direccion = TextBox5.Text
                estudiantes.bachiller = TextBox6.Text
                estudiantes.actualizar()
                TextBox1.Enabled = True
                Button1.Enabled = True
                limpiar()
                mostrar()
        End Select
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        limpiar()
        cargarLabel(x)
    End Sub
End Class
