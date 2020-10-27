Public Class frmInicioVentas

    Private Sub btnComprasGeneral_Click(sender As Object, e As EventArgs) Handles btnComprasGeneral.Click
        frmNuevaVenta.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmListaComprobanteVentas.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmNuevaVentaP.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        frmDepositoDetracciones.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frmNuevaVentaMercaderias.Show()
    End Sub
End Class