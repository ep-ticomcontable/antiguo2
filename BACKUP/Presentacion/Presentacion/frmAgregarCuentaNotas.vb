Public Class frmAgregarCuentaNotas
    Public formIni As String
    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cargarCuentaContable()
        End If
    End Sub
    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
        cargarCuentaContable()
    End Sub
    Private Sub cargarCuentaContable()
        If txtCuenta.Text.Trim.Length >= 2 Then
            With frmEscogerPlanContable
                .formInicio = "agregarCuentaNota"
                .cuentaInicio = txtCuenta.Text.Trim
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If formIni = "notacreditocompra" Then
            frmNuevaNotaCreditoCompra.agregarCuenta(txtCuenta.Text.Trim, lblCuenta.Text, txtDebe.Text.Trim, txtHaber.Text.Trim)
        ElseIf formIni = "notacreditoventa" Then
            frmNuevaNotaCreditoVenta.agregarCuenta(txtCuenta.Text.Trim, lblCuenta.Text, txtDebe.Text.Trim, txtHaber.Text.Trim)
        ElseIf formIni = "notadebitoventa" Then
            frmNuevaNotaDebitoVenta.agregarCuenta(txtCuenta.Text.Trim, lblCuenta.Text, txtDebe.Text.Trim, txtHaber.Text.Trim)
        ElseIf formIni = "notadebitocompra" Then
            frmNuevaNotaDebitoCompra.agregarCuenta(txtCuenta.Text.Trim, lblCuenta.Text, txtDebe.Text.Trim, txtHaber.Text.Trim)
        ElseIf formIni = "cobranza" Then
            frmPagoDeudas.agregarCuenta(txtCuenta.Text.Trim, lblCuenta.Text, txtDebe.Text.Trim, txtHaber.Text.Trim)
        ElseIf formIni = "letraCompra" Then
            frmCanjeLetraComprobantes.agregarCuenta(txtCuenta.Text.Trim, lblCuenta.Text, txtDebe.Text.Trim, txtHaber.Text.Trim)
        End If
        Me.Dispose()
    End Sub

End Class