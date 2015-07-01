Imports System.Drawing

Public Class ImpImagen

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings

            PrintDocument1.Print()

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(PictureBox1.Image, 10, 20, 900, 920)
    End Sub
End Class