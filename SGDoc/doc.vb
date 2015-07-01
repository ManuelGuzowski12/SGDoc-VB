Option Explicit On
Imports Negocio
Imports Entidades
Imports System.Windows.Forms
Imports System.Drawing

Public Class doc

    Private txt As TextBox() = New TextBox(1) {}
    Private lab As Label() = New Label(1) {}
    Private pic As PictureBox() = New PictureBox(1) {}
    Private i As Long = 0
    Private imgCont As Long = 0
    Private bnd As Boolean = False
    Private idPlantilla As String() = New String(1) {}
    Private list_DatosBusq As List(Of DatosBusqueda) = New List(Of DatosBusqueda)
    Private list_Img As List(Of Imagenes) = New List(Of Imagenes)
    Private dep As String

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        limpiar()
        crearTxt(CInt(ComboBox1.SelectedValue))

    End Sub
    Private Function limpiar()
        If bnd Then
            For x As Integer = 0 To txt.Count - 1 Step 1
                Me.Controls.Remove(txt(x))

                Me.Controls.Remove(lab(x))

            Next
            txt = Nothing
            lab = Nothing
            Me.ResumeLayout()
            list_DatosBusq.Clear()
        End If
    End Function
    Private Function guardar()
        Dim doc As New Documentos()
        With doc
            .id_usuario = id_user
            .nombre = TextBox2.Text
            .id_departamento = "" + dep.ToString
            .fecha_creacion = Format(DateTimePicker1.Value, "yyyy/MM/dd")
            .activacion = "1"
        End With
        Dim id_docuemnto As Documentos = DocumentosBO.InsertarDocumentos(doc)
        i = 0
        For Each l As DatosBusqueda In list_DatosBusq
            Dim x As New DatosBusqueda
            x.id_doc = id_docuemnto.id_doc
            x.id_plantilla = l.id_plantilla
            x.valor = txt(i).Text
            i = i + 1
            DatosBusquedaBO.InsertarDatos(x)
        Next
        For Each img As Imagenes In list_Img
            img.id_doc = id_docuemnto.id_doc
            ImagenesBO.guardar(img)
        Next
    End Function
    Private Sub doc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bnd = False
        i = 0
        With ComboBox1
            .DisplayMember = "descripcion"
            .ValueMember = "id_tipodoc"
            .DataSource = TipoDocBO.MostrarTipoDoc()
        End With
        With ComboBox2
            .DisplayMember = "descripcion"
            .ValueMember = "id_departamento"
            .DataSource = DepartamentosBO.getDepartamentos
        End With
        TextBox1.Text = username & "-" & id_user
        TextBox1.Enabled = False
    End Sub
    Private Function crearTxt(ByVal id_tipo As Integer)
        Dim lista As List(Of Plantillas)
        i = 0
        lista = PlantillasBO.MostrarPlantilla(id_tipo)
        Dim t = lista.Count
        ReDim txt(t)
        ReDim lab(t)
        Dim pos As Long = ComboBox1.Top + 20
        Dim x As Long = ComboBox1.Left
        Dim y As Long = 20

        For Each l As Plantillas In lista

            lab(i) = New Label
            With lab(i)
                .Text = l.descripcon
                .Top = (pos + y)
                .Left = (x)
                y = y + 25
            End With
            txt(i) = New TextBox
            With txt(i)
                .Visible = True
                .Top = lab(i).Top
                .Left = lab(i).Left + 100
            End With
            Me.Controls.Add(lab(i))
            Me.Controls.Add(txt(i))
            Dim datosBusq As New DatosBusqueda()
            datosBusq.id_plantilla = l.id_plantilla
            i = i + 1
            list_DatosBusq.Add(datosBusq)
        Next
        bnd = True

    End Function

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        dep = ComboBox2.SelectedValue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        guardar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Abrir As New OpenFileDialog
        Abrir.Filter = "*.bmp;*.gif;*.jpg;*.png;|*.bmp;*.gif;*.jpg;*.png;"
        Abrir.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        Abrir.Title = "seleccionar la imagen que se guardará en la base de datos"
        Abrir.RestoreDirectory = True

        Dim pict As PictureBox = New PictureBox
        Dim y As Long = Gimg.Left

        With pict

            .Size = New System.Drawing.Size(50, 75)
            .Location = New Point(10 + ((.Left + .Width + 10) * imgCont), 30)
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Visible = True
        End With
        Gimg.Controls.Add(pict)

        If Abrir.ShowDialog = Windows.Forms.DialogResult.OK Then
            Label6.Text = Abrir.FileName
            pict.Image = Image.FromFile(Abrir.FileName)


            Dim img As Imagenes = New Imagenes
            img.convertir(Label6.Text)
            list_Img.Add(img)

            y = y + 50
            imgCont = imgCont + 1
        Else
            Label6.Text = ""
            pict.Image = Nothing

        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class