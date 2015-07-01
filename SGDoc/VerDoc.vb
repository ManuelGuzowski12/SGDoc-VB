Option Explicit On
Imports Negocio
Imports Entidades
Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing

Public Class VerDoc
    Private existen_imagenes As Boolean = False
    Private pic As PictureBox() = New PictureBox(1) {}
    Private txt As TextBox() = New TextBox(1) {}
    Private lab As Label() = New Label(1) {}
    Private i As Long = 0
    Private documentoTemp As Documentos = New Documentos
    Private mostrando As Boolean = False

    Private Sub VerDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recargar()
    End Sub
    Private Function recargar()
        dgv.DataSource = DocumentosBO.GetAll
        Button1.Enabled = False
    End Function

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
    Private Function limpiar()

        If existen_imagenes = True Then
            For x As Integer = 0 To txt.Count - 1 Step 1
                GTxt.Controls.Remove(txt(x))

                GTxt.Controls.Remove(lab(x))

            Next

            txt = Nothing
            lab = Nothing
            Me.ResumeLayout()
        End If

    End Function
    Private Function crearTxt(ByVal id_doc As Integer)
        If existen_imagenes Then
            limpiar()
        End If

        i = 0
        Dim doc As Documentos = DocumentosBO.buscar(id_doc)
        Dim datos As List(Of DatosBusqueda) = New List(Of DatosBusqueda)
        datos = DatosBusquedaBO.buscarPorId_doc(id_doc)

        Dim t = 6 + datos.LongCount
        ReDim txt(t)
        ReDim lab(t)
        Dim y As Long = 20
        With doc
            txt(1) = New TextBox
            lab(1) = New Label
            txt(1).Text = .id_doc
            lab(1).Text = "ID Documento:"

            txt(2) = New TextBox
            lab(2) = New Label
            txt(2).Text = .id_usuario
            lab(2).Text = "Creado Por:"

            txt(4) = New TextBox
            lab(4) = New Label
            txt(4).Text = .fecha_creacion
            lab(4).Text = "Fecha de Creacion:"

            txt(3) = New TextBox
            lab(3) = New Label
            txt(3).Text = .nombre
            lab(3).Text = "Titulo del Documento:"

            txt(5) = New TextBox
            lab(5) = New Label
            txt(5).Text = DepartamentosBO.getDepartamentosID(.id_departamento)
            lab(5).Text = "Departamento:"

        End With
        i = 5
        For Each r As DatosBusqueda In datos
            If i = 5 Then
                i = i + 1
                lab(i) = New Label
                With lab(i)
                    .Text = "Tipo de Doc:"
                End With
                txt(i) = New TextBox
                With txt(i)
                    .Text = TipoDocBO.buscarNombre(r.id_plantilla)
                End With
            End If
        Next
        For Each l As DatosBusqueda In datos

            i = i + 1
            lab(i) = New Label
            With lab(i)
                .Text = PlantillasBO.buscarNombreCampo(l.id_plantilla)
            End With
            txt(i) = New TextBox
            With txt(i)
                .Text = l.valor
            End With
        Next
        For cont As Integer = 1 To i Step 1
            With lab(cont)
                .Size = New System.Drawing.Size(100, 25)
                .Location = New Point(10, ((.Top + 30) * cont))
                .Visible = True
            End With

            With txt(cont)
                .Top = lab(cont).Top
                .Left = lab(cont).Left + 120
                .Enabled = False
                .Visible = True
            End With
            GTxt.Controls.Add(lab(cont))
            GTxt.Controls.Add(txt(cont))
        Next

        i = 0

        With chk
            If doc.activacion = 1 Then
                .Checked = True
                documentoTemp.activacion = 1
            Else
                .Checked = False
                documentoTemp.activacion = 0
            End If
            .Text = "Activo"
        End With
        documentoTemp.id_doc = doc.id_doc
        existen_imagenes = True
        mostrando = True

    End Function
    Private Function limpiarImg()
        existen_imagenes = False
        If pic.Count > 0 Then
            For y As Integer = 0 To pic.Count - 1 Step 1
                GImg.Controls.Remove(pic(y))
            Next
            pic = Nothing
        End If
    End Function
    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If existen_imagenes = True Then
            limpiarImg()
        End If
        Dim listaImg As List(Of Imagenes)
        listaImg = ImagenesBO.buscar(dgv.CurrentRow.Cells(0).Value.ToString)

        ReDim pic(listaImg.Count)

        crearTxt(dgv.CurrentRow.Cells(0).Value.ToString)
        If listaImg.Count > 0 Then
            i = 0
            For Each img As Imagenes In listaImg

                pic(i) = New PictureBox
                AddHandler pic(i).DoubleClick, AddressOf eventoHola

                Dim y As Long = 100

                With pic(i)

                    .Size = New System.Drawing.Size(75, 125)
                    .Location = New Point(10 + ((.Left + .Width + 10) * i), 30)
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    .Visible = True
                    Dim memoria As MemoryStream = New MemoryStream(img.imagen)

                    .Image = Image.FromStream(memoria)

                End With
                GImg.Controls.Add(pic(i))


                i = i + 1
            Next
        Else
            MsgBox("No existen Digitalizados de este Documento")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If mostrando = True Then
            limpiar()
            limpiarImg()
            recargar()
        End If
        mostrando = False
        dgv.DataSource = DocumentosBO.buscarX(TextBox1.Text)
        If TextBox1.Text = "" Then
           
            recargar()
        End If
    End Sub


    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged


    End Sub
    Public Event hola(ByVal x As String)
    Public Sub eventoHola(sender As PictureBox, e As EventArgs)
        Dim pro As New ImpImagen
        Dim pict As New PictureBox

        pro.PictureBox1.Image = sender.Image
        With pro
            .Show()
        End With
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DocumentosBO.actualizar(documentoTemp)
        limpiar()
        limpiarImg()
        recargar()

    End Sub

    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs) Handles chk.CheckedChanged
        If sender.Checked = True Then
            documentoTemp.activacion = 1
        Else
            documentoTemp.activacion = 0
        End If
        Me.Button1.Enabled = True
    End Sub
End Class