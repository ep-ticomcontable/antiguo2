﻿Imports Negocio
Imports Entidades

Public Class frmAccionPagosVentas
    Public idComprobante As String
    Public idTipoComprobante As String
    Dim obj As New nCrud

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        frmListaAbonosVentas.idComprobante = "0"
        frmListaAbonosVentas.idComprobante = idComprobante
        frmListaAbonosVentas.ShowDialog()
    End Sub

    Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnAbonar.Click
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from comprobante_venta where id='" & idComprobante & "'", CadenaConexion)
        If data.Rows(0)("estado_comprobante").ToString = "F" Then
            frmAbonoComprobanteVentas.codVenta = idComprobante
            frmAbonoComprobanteVentas.Show()
        Else
            MessageBox.Show("Solo se puede realizar COBROS o PAGOS a un comprobante de compra FINALIZADO", "Módulo de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs)
        frmModificarVenta.idVenta = idComprobante
        frmModificarVenta.Show()
    End Sub

    Private Sub frmAccionesCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from vista_ventas_con_abonos where id='" & idComprobante & "'", CadenaConexion)
        With data
            lblComprobante.Text = .Rows(0)("serie").ToString & "-" & .Rows(0)("numero").ToString
            lblDeuda.Text = "(" & .Rows(0)("moneda").ToString & ")" & vbCrLf & Format((Decimal.Parse(.Rows(0)("total").ToString) - Decimal.Parse(.Rows(0)("abono").ToString)), "#,##0.00")
            lblTotal.Text = "(" & .Rows(0)("moneda").ToString & ")" & Format(Decimal.Parse(.Rows(0)("total").ToString), "#,##0.00")
            lblFP.Text = Date.Parse(.Rows(0)("fec_pago").ToString).ToString("yyyy-MM-dd")
            lblProv.Text = .Rows(0)("razon_social").ToString
            lblRuc.Text = .Rows(0)("num_dni").ToString
            If .Rows(0)("estado_comprobante").ToString = "P" Or .Rows(0)("estado_comprobante").ToString = "E" Or Decimal.Parse(.Rows(0)("total").ToString) = Decimal.Parse(.Rows(0)("abono").ToString) Then
                btnAbonar.Enabled = False
            Else
                btnAbonar.Enabled = True
            End If
        End With
    End Sub

    Private Sub pbCerrar_Click(sender As Object, e As EventArgs) Handles pbCerrar.Click
        Me.Close()
    End Sub
End Class