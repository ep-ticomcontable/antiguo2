Imports Negocio
Imports Entidades
Public Class frmCanjeLetraComprobantes

    Dim obj As New nCrud
    Dim objTDA As New nTipoDocumentoAsiento
    Dim objAC As New nAsientosContables
    Public codComprobante As Integer = 0
    Public codTipoComprobante As Integer = 0
    Public dataComprobante As New DataTable
    Dim objNCD As New nNotaCreditoDebito
    Dim tipoOperacion As Integer = 5 'DEVOLUCIONES
    Dim objCV As New nComprobanteVenta
    Dim id_comprobante As String
    Dim objCanje As New nCanjeLetra
    Dim entiCanje As New CanjeLetraEntity
    Public tipo As String = ""
    Dim data As New DataTable
    Public Sub cargarDatosComprobante()
        If tipo = "COMPRA" Then
            data = obj.nCrudListarBD("select * from comprobante_compra where id='" & codComprobante & "'", CadenaConexion)
        Else
            data = obj.nCrudListarBD("select * from comprobante_venta where id='" & codComprobante & "'", CadenaConexion)
        End If
        With data
            dgvComprobante.DataSource = dataComprobante
        End With
    End Sub

    Private Sub frmPagoConLetras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFechaVencimiento.Value = DateTime.Today.AddMonths("+1")
        dgvOperaciones.RowTemplate.Height = 30
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        With entiCanje
            .id_comprobante = dgvComprobante.Rows(0).Cells("id").Value.ToString
            .tipo_comprobante = tipo
            .estado_deuda = "DEBE"
            .serie = txtSerie.Text.Trim
            .numero = txtNumero.Text.Trim
            .librado = txtLibrado.Text.Trim
            .aval = txtAval.Text.Trim
            .direccion = txtDireccion.Text.Trim
            .lugar_giro = txtGiro.Text.Trim
            .monto = txtTDebeS.Text.Trim
            .fecha_emision = dtFechaEmision.Value
            .fecha_vencimiento = dtFechaVencimiento.Value
            .estado = "1"
        End With
        MsgBox("REGISTRO DE CANJE A LETRA: " & objCanje.nRegistrarCanjeLetraBD(entiCanje, CadenaConexion))

        'registrar asiento
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from canje_letra where estado=1 order by id desc", CadenaConexion)
        Dim idLetra As String
        idLetra = data.Rows(0)("id").ToString
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            Dim rpta As String
            rpta = objCanje.nRegistrarAsientosLetrasBD(codComprobante, idLetra, tipo, txtDescripcion.Text.Trim, row.Cells("num_cuenta").Value, row.Cells("debe").Value, row.Cells("haber").Value, dtFechaEmision.Value, CadenaConexion)
            'MsgBox("REGISTRO DE ASIENTO CONTABLE PARA LA LETRA: " & rpta)
        Next
        Me.Dispose()
    End Sub

    Public Sub agregarCuenta(numcuenta, desccuenta, debe, haber)
        If dgvOperaciones.Rows.Count = 0 Then
            Dim data As New DataTable
            data.Columns.Add("num_cuenta")
            data.Columns.Add("desc_cuenta")
            data.Columns.Add("debe")
            data.Columns.Add("haber")
            data.Rows.Add(numcuenta, desccuenta, debe, haber)
            dgvOperaciones.DataSource = data
        Else
            Dim dt As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row As DataRow = dt.NewRow()
            row.Item(0) = numcuenta
            row.Item(1) = desccuenta
            row.Item(2) = debe
            row.Item(3) = haber
            dt.Rows.Add(row)
        End If
        realizarSumasTotales()
    End Sub
    Private Sub realizarSumasTotales()
        'MsgBox("suma total")
        Dim tDebe, tHaber, tDiferencia As Decimal
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            tDebe += row.Cells("debe").Value
            tHaber += row.Cells("haber").Value
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCuenta.Text.Trim.Length > 2 Then
            Dim dtAsiento As New DataTable
            Dim cuentaComp As String = ""

            Dim cuentas As New DataTable
            cuentas.Columns.Add("num_cuenta")
            cuentas.Columns.Add("desc_cuenta")
            cuentas.Columns.Add("debe")
            cuentas.Columns.Add("haber")

            If tipo = "COMPRA" Then
                dtAsiento = obj.nCrudListarBD("select * from asientos_comprobante_compra where id_comprobante_compra='" & data.Rows(0)("id").ToString & "'", CadenaConexion)
                For Each fila As DataRow In dtAsiento.Rows
                    With fila
                        If .Item("cuenta").ToString.StartsWith("42") = True Then
                            cuentaComp = .Item("cuenta").ToString
                            Exit For
                        End If
                    End With
                Next
                cuentas.Rows.Add(cuentaComp, obtenerDatosCuenta(cuentaComp), txtMonto.Text.Trim, "0.00")
                cuentas.Rows.Add(txtCuenta.Text.Trim, obtenerDatosCuenta(txtCuenta.Text.Trim), "0.00", txtMonto.Text.Trim)
            ElseIf tipo = "VENTA" Then
                dtAsiento = obj.nCrudListarBD("select * from detalle_asiento_venta where id_asiento_venta='" & data.Rows(0)("id").ToString & "'", CadenaConexion)
                For Each fila As DataRow In dtAsiento.Rows
                    With fila
                        If .Item("cuenta").ToString.StartsWith("12") = True Then
                            cuentaComp = .Item("cuenta").ToString
                            Exit For
                        End If
                    End With
                Next
                cuentas.Rows.Add(cuentaComp, obtenerDatosCuenta(cuentaComp), "0.00", txtMonto.Text.Trim)
                cuentas.Rows.Add(txtCuenta.Text.Trim, obtenerDatosCuenta(txtCuenta.Text.Trim), txtMonto.Text.Trim, "0.00")
            End If
            dgvOperaciones.DataSource = cuentas
            txtDescripcion.Focus()
        Else
            MsgBox("Ingrese una cuenta correspondiente al canje de letra.")
            txtCuenta.Focus()
        End If

    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub btnCuenta_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "canje"
                    .cuentaInicio = txtCuenta.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
        If Asc(e.KeyChar) = 13 Then
            txtMonto.Focus()
        End If
    End Sub
End Class