Imports Negocio
Imports Entidades

Public Class frmAbonoComprobanteVentas

    Dim objCom As New nComprobanteVenta
    Dim objPag As New nPagosCompras
    Dim objDet As New nDetraccion
    Dim objCrud As New nCrud
    Dim objCA As New nCuentaAsiento
    Dim objTP As New nTipoPagos
    Dim objAbono As New nAbonosPagos

    Dim dataVenta As New DataTable
    Public codVenta As String
    Dim iCarga As Integer = 0
    Dim idTipoOperacion As Integer = 2
    'Dim CodigoLocalSession As Integer = 1
    'Dim CodigoEmpresaSession As Integer = 1
    Dim montoDetraccion As Decimal = 0
    Dim calculoImpuesto As Decimal = 0

    Public Sub cargarTipoPagos(codCaja As String)
        Dim data, data2, data3 As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        'data.Rows.Add(0, "SIN AFECTO")

        data2 = objCrud.nCrudListarBD("select * from cajas_tipo_pago where id_caja='" & codCaja & "'", CadenaConexion)
        For Each row As DataRow In data2.Rows
            data3 = objCrud.nCrudListarBD("select * from tipo_pago where id='" & row.Item("id_tipo_pago") & "'", CadenaConexion)
            data.Rows.Add(data3.Rows(0)("id").ToString, data3.Rows(0)("descripcion").ToString)
        Next
        With cboTipoPago
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Public Sub cargarTipoPagos2(codCaja As String)
        Dim data, data2, data3 As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        'data.Rows.Add(0, "SIN AFECTO")

        data2 = objCrud.nCrudListarBD("select * from cajas_tipo_pago where id_caja='" & codCaja & "'", CadenaConexion)
        For Each row As DataRow In data2.Rows
            data3 = objCrud.nCrudListarBD("select * from tipo_pago where id='" & row.Item("id_tipo_pago") & "'", CadenaConexion)
            data.Rows.Add(data3.Rows(0)("id").ToString, data3.Rows(0)("descripcion").ToString)
        Next
        With cboTipoPagoI
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub

    Private Sub cargarTipoMovimientos()
        cargarTipoPagos("1")
        'Dim data As New DataTable
        'data.Columns.Add("Codigo")
        'data.Columns.Add("Descripcion")
        'data.Rows.Add(0, "SIN AFECTO")
        'Dim data2 As DataTable
        'Try
        '    data2 = objCrud.nCrudListarBD("select * from tipo_pago where estado=1 order by codigo asc", CadenaConexion)
        '    For Each row As DataRow In data2.Rows
        '        data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
        '    Next
        '    With cboTipoPago
        '        .DataSource = data
        '        .ValueMember = "Codigo"
        '        .DisplayMember = "Descripcion"
        '    End With
        '    data2.Dispose()
        'Catch ex As Exception
        '    MsgBox("No se pudo cargar los tipos de pago")
        'End Try
    End Sub
    Private Sub cargarTipoMovimientos2()
        cargarTipoPagos2("1")
        'Dim data As New DataTable
        'data.Columns.Add("Codigo")
        'data.Columns.Add("Descripcion")
        'data.Rows.Add(0, "SIN AFECTO")
        'Dim data2 As DataTable
        'Try
        '    data2 = objCrud.nCrudListarBD("select * from tipo_pago where estado=1 order by codigo asc", CadenaConexion)
        '    For Each row As DataRow In data2.Rows
        '        data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
        '    Next
        '    With cboTipoPagoI
        '        .DataSource = data
        '        .ValueMember = "Codigo"
        '        .DisplayMember = "Descripcion"
        '    End With
        '    data2.Dispose()
        'Catch ex As Exception
        '    MsgBox("No se pudo cargar los tipos de pago")
        'End Try
    End Sub
    Private Sub cargarImpuestosSunat()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "SIN AFECTO")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='VENTA' and descripcion<>'PERCEPCIÓN' and estado=1", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            With cboImpuestos
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Impuestos")
        End Try
    End Sub
    Private Sub txtCDetraccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCDetraccion.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCDetraccion.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmAbonoVenta"
                    .cuentaInicio = txtCDetraccion.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
    End Sub

    Private Sub cargarDatosComprobanteVenta()
        dataVenta = objCom.nDataComprobanteVentaPorId(codVenta, CadenaConexion)

        Dim cadena As String()
        cadena = dataVenta.Rows(0)("marca").ToString.Split("@")
        If cadena.Count > 0 Then
            'MsgBox(cadena(0).ToString & "-" & cadena(1).ToString)
            cboImpuestos.SelectedValue = cadena(0).ToString
            cargarDatosImpuestos()
            'If cadena(1).ToString = "EXTERNA" Then
            '    cargarDatosImpuestos()
            '    'MsgBox(cboImpuestos.SelectedValue)
            'End If
        End If

        lblDniRuc.Text = dataVenta.Rows(0)("num_dni")
        lblRazonNombre.Text = dataVenta.Rows(0)("razon_social")
        lblDocumento.Text = dataVenta.Rows(0)("documento")
        lblSerieNumero.Text = dataVenta.Rows(0)("serie") & "-" & dataVenta.Rows(0)("numero")
        LblMoneda.Text = dataVenta.Rows(0)("moneda")
        lblTipoCambio.Text = dataVenta.Rows(0)("tipo_cambio")
        lblDescripcionCompra.Text = dataVenta.Rows(0)("glosa")
        lblFechaEmision.Text = dataVenta.Rows(0)("fec_emision")
        lblFechaPago.Text = dataVenta.Rows(0)("fec_pago")
        'txtBaseDetraccion.Text = dataVenta.Rows(0)("total")
        lblMontoCompra.Text = (dataVenta.Rows(0)("total"))
        Dim dtAbono As New DataTable
        dtAbono = objCrud.nCrudListarBD("select isnull(sum(monto),0) as 'abono' from abono_pagos_ventas where id_venta='" & codVenta & "'", CadenaConexion)
        If Decimal.Parse(dtAbono.Rows(0)("abono").ToString) > 0 Then
            lblDeuda.Text = (dataVenta.Rows(0)("total") - Decimal.Parse(dtAbono.Rows(0)("abono")))
        Else
            lblDeuda.Text = (dataVenta.Rows(0)("total"))
        End If
        txtMonto.Text = lblDeuda.Text

        Dim dtVenta As New DataTable
        dtVenta = objCrud.nCrudListarBD("select * from detalle_asiento_venta where id_asiento_venta='" & codVenta & "'", CadenaConexion)

        cboImpuestos.SelectedValue = dtVenta.Rows(0)("tipo_tasa_detraccion").ToString
        txtPorcentaje.Text = dtVenta.Rows(0)("tasa_detraccion").ToString
        dtFecImpuesto.Value = Date.Parse(dtVenta.Rows(0)("fecha_detraccion").ToString)
        txtNumeroImpuesto.Text = dtVenta.Rows(0)("numero_detraccion").ToString

        'Cargar montos
        If cadena(0).ToString <> "0" Then
            txtMontoDet.Text = Decimal.Round((Decimal.Parse(lblMontoCompra.Text.Trim) * Decimal.Parse(txtPorcentaje.Text) / 100), 2)
            txtMonto.Text = Decimal.Parse(lblMontoCompra.Text.Trim) - Decimal.Parse(txtMontoDet.Text.Trim)
        Else
            txtMonto.Text = lblDeuda.Text.Trim
            txtMontoDet.Text = "0.00"
        End If

        txtDescripcion.Text = "POR EL COBRO DE LA FACTURA: " & lblSerieNumero.Text
    End Sub
    Private Sub cargarAbonosPagoVenta()
        Dim data As New DataTable
        data = objAbono.nSumaAbonoPagoCompras(codVenta)

        If data.Rows.Count > 0 Then
            Dim dataVenta As New DataTable
            dataVenta = objCom.nDataComprobanteVentaPorId(codVenta, CadenaConexion)
            txtMonto.Text = (dataVenta.Rows(0)("total") - data.Rows(0)("abono"))
        End If

    End Sub
    Private Sub frmAbonoComprobanteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipoMovimientos()
        cargarTipoMovimientos2()
        cargarImpuestosSunat()
        iCarga = 1
        cargarDatosComprobanteVenta()
        cargarAbonosPagoVenta()
        cargarCuentaInicial()
        cargarDeudaPendiente()
        cargarPagosPredeterminados()
    End Sub

    Private Sub cargarDeudaPendiente()
        'Deshabilitar pago de Impuestos
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from asientos_abono_ventas where id_venta='" & codVenta & "'", CadenaConexion)
        If dt.Rows.Count > 0 Then
            Dim estadoDetraccion As Boolean = False
            For Each row As DataRow In dt.Rows
                If row.Item("cuenta").ToString = txtCuentaI.Text.Trim Then
                    estadoDetraccion = True
                    Exit For
                End If
            Next
            If estadoDetraccion = False Then
                gbImpuestos.Enabled = True
                txtBI.Text = "0"

                Dim dtAbono As New DataTable
                dtAbono = objCrud.nCrudListarBD("select isnull(sum(monto),0) as 'abono' from abono_pagos_ventas where id_venta='" & codVenta & "'", CadenaConexion)
                If Decimal.Parse(dtAbono.Rows(0)("abono").ToString) > 0 Then
                    If gbImpuestos.Enabled = True Then
                        txtMonto.Text = (dataVenta.Rows(0)("total") - Decimal.Parse(dtAbono.Rows(0)("abono"))) - Decimal.Parse(txtMontoDet.Text.Trim)
                    Else
                        txtMonto.Text = lblDeuda.Text.Trim
                    End If
                Else
                    txtMonto.Text = (dataVenta.Rows(0)("total"))
                End If

            Else
                gbImpuestos.Enabled = False
                txtBI.Text = "0"
                If gbImpuestos.Enabled = False Then
                    txtMonto.Text = lblDeuda.Text.Trim
                End If
            End If
        Else
            gbImpuestos.Enabled = True
            txtBI.Text = "0"
        End If
    End Sub

    Private Sub cargarCuentaInicial()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objCrud.nCrudListarBD("select * from detalle_asiento_venta where id_asiento_venta='" & codVenta & "'", CadenaConexion)
            If data.Rows(0)("tipo_tasa_detraccion").ToString <> "0" Then
                Dim dataImp As New DataTable
                dataImp = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
                txtCuentaI.Text = dataImp.Rows(0)("cuenta").ToString

                For Each row As DataRow In data.Rows
                    If row.Item("cuenta").ToString.StartsWith("1") And row.Item("cuenta").ToString <> dataImp.Rows(0)("cuenta").ToString Then
                        txtCuentaP.Text = row.Item("cuenta").ToString
                        lblCuentaP.Text = obtenerDatosCuenta(row.Item("cuenta").ToString)
                        Exit For
                    End If
                Next
            Else
                For Each row As DataRow In data.Rows
                    If row.Item("cuenta").ToString.StartsWith("1") And row.Item("cuenta").ToString Then
                        txtCuentaP.Text = row.Item("cuenta").ToString
                        lblCuentaP.Text = obtenerDatosCuenta(row.Item("cuenta").ToString)
                        Exit For
                    End If
                Next
            End If
        End If

    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub realizarSumasTotales()
        Dim tDebe, tHaber, tDiferencia As Decimal
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            tDebe += row.Cells("debe").Value
            tHaber += row.Cells("haber").Value
        Next
        tDiferencia = tDebe - tHaber

        lblDebe.Text = Format(tDebe, "#,##0.00")
        lblHaber.Text = Format(tHaber, "#,##0.00")
        lblDiferencia.Text = Format(tDiferencia, "#,##0.00")
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim EntiAboCom As New AbonoVentasEntity
        Dim EntiAsientoAboCom, EntiAsientoAboCom2 As New AbonoComprasEntity
        If txtBE.Text = "1" Then
            With EntiAboCom
                .id_venta = codVenta
                .tipo_comprobante = dataVenta.Rows(0)("id_tipo_comprobante").ToString
                .monto = txtMonto.Text.Trim
                .id_banco = "0"
                .id_caja = txtIdCaja.Text.Trim
                .tipo = cboTipoPago.SelectedValue.ToString
                .numero = txtNumero.Text.Trim
                .descripcion = txtDescripcion.Text.Trim
                .fecha = DateTime.Now.ToString("yyyy/MM/dd") & " " & Now.ToString("HH:mm:ss")
                .estado = "1"
            End With
            objAbono.nRegistrarAbonoVentasBD(EntiAboCom, CadenaConexion)

            Dim idVenta As String = objAbono.nObtenerUltimoAbonoVenta(CadenaConexion)
            With EntiAsientoAboCom
                .id = idVenta
                .id_cliente = dataVenta.Rows(0)("num_dni").ToString
                .id_compra = codVenta
                .cuenta = txtCuenta.Text.Trim
                .base_imponible = txtMonto.Text.Trim
                .nro_detraccion = txtNumeroImpuesto.Text
                .tipo_tasa_detraccion = cboImpuestos.SelectedValue.ToString
                .valor_tasa = txtPorcentaje.Text.Trim
                .valor_detraccion = txtMontoDet.Text.Trim
                .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                .monto = txtMonto.Text.Trim
                .tipo = cboTipoPago.SelectedValue
                .descripcion = txtDescripcion.Text
                .debe = txtMonto.Text.Trim
                .haber = "0.00"
                .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
            End With
            objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboCom, CadenaConexion)
            With EntiAsientoAboCom
                .id = idVenta
                .id_cliente = dataVenta.Rows(0)("num_dni").ToString
                .id_compra = codVenta
                .cuenta = txtCuentaP.Text.Trim
                .base_imponible = txtMonto.Text.Trim
                .nro_detraccion = txtNumeroImpuesto.Text
                .tipo_tasa_detraccion = cboImpuestos.SelectedValue.ToString
                .valor_tasa = txtPorcentaje.Text.Trim
                .valor_detraccion = txtMontoDet.Text.Trim
                .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                .monto = txtMonto.Text.Trim
                .tipo = cboTipoPago.SelectedValue
                .descripcion = txtDescripcion.Text
                .debe = "0.00"
                .haber = txtMonto.Text.Trim
                .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
            End With
            objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboCom, CadenaConexion)
        End If
        
        If txtBI.Text = "1" Then
            If Decimal.Parse(txtMontoDet.Text.Trim) > 0 Then
                'REGISTRO DE DETRACCION
                With EntiAboCom
                    .id_venta = codVenta
                    .tipo_comprobante = dataVenta.Rows(0)("id_tipo_comprobante").ToString
                    .monto = txtMontoDet.Text.Trim
                    .id_banco = "0"
                    .id_caja = txtIdCaja2.Text.Trim
                    .tipo = cboTipoPagoI.SelectedValue.ToString
                    .numero = txtNumeroImpuesto.Text.Trim
                    .descripcion = txtGlosaDet.Text.Trim
                    .fecha = DateTime.Now.ToString("yyyy/MM/dd") & " " & Now.ToString("HH:mm:ss")
                    .estado = "1"
                End With
                objAbono.nRegistrarAbonoVentasBD(EntiAboCom, CadenaConexion)

                Dim idVenta2 As String = "0"
                idVenta2 = objAbono.nObtenerUltimoAbonoVenta(CadenaConexion)
                With EntiAsientoAboCom2
                    .id = idVenta2
                    .id_cliente = dataVenta.Rows(0)("num_dni").ToString
                    .id_compra = codVenta
                    .cuenta = txtCDetraccion.Text.Trim
                    .base_imponible = txtMontoDet.Text.Trim
                    .nro_detraccion = txtNumeroImpuesto.Text
                    .tipo_tasa_detraccion = cboImpuestos.SelectedValue.ToString
                    .valor_tasa = txtPorcentaje.Text.Trim
                    .valor_detraccion = txtMontoDet.Text.Trim
                    .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                    .monto = txtMontoDet.Text.Trim
                    .tipo = cboTipoPagoI.SelectedValue
                    .descripcion = txtGlosaDet.Text
                    .debe = txtMontoDet.Text.Trim
                    .haber = "0.00"
                    .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
                End With
                objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboCom2, CadenaConexion)

                With EntiAsientoAboCom2
                    .id = idVenta2
                    .id_cliente = dataVenta.Rows(0)("num_dni").ToString
                    .id_compra = codVenta
                    .cuenta = txtCuentaI.Text.Trim
                    .base_imponible = txtMontoDet.Text.Trim
                    .nro_detraccion = txtNumeroImpuesto.Text
                    .tipo_tasa_detraccion = cboImpuestos.SelectedValue.ToString
                    .valor_tasa = txtPorcentaje.Text.Trim
                    .valor_detraccion = txtMontoDet.Text.Trim
                    .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                    .monto = txtMontoDet.Text.Trim
                    .tipo = cboTipoPagoI.SelectedValue
                    .descripcion = txtGlosaDet.Text
                    .debe = "0.00"
                    .haber = txtMontoDet.Text.Trim
                    .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
                End With
                objAbono.nRegistrarAsientoAbonoVentas(EntiAsientoAboCom2, CadenaConexion)
            End If
        End If
        

        MsgBox("PAGO REGISTRADO CON ÉXITO")
        frmListaComprobanteVentas.realizarConsulta()
        Me.Dispose()
    End Sub
    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        frmEscogerCaja.formInicio = "abonoVenta"
        frmEscogerCaja.Show()
    End Sub
    Private Sub btnBuscar2_Click(sender As Object, e As EventArgs) Handles btnBuscar2.Click
        frmEscogerCaja.formInicio = "abonoVenta2"
        frmEscogerCaja.Show()
    End Sub
    Private Sub cboImpuestos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboImpuestos.SelectedIndexChanged
        If iCarga = 1 Then
            cargarDatosImpuestos()
        End If
    End Sub
    Private Sub cargarDatosImpuestos()
        If cboImpuestos.SelectedValue.ToString <> "0" Then
            'cboSerieImpuesto.Enabled = True
            txtNumeroImpuesto.Enabled = True

            Dim dataPorc As New DataTable
            dataPorc = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
            txtCuentaI.Text = dataPorc.Rows(0)("cuenta").ToString
            If dataPorc.Rows.Count > 0 Then
                txtPorcentaje.Text = dataPorc.Rows(0)("porcentaje").ToString
            Else
                txtPorcentaje.Text = "0"
            End If

            If cboImpuestos.Text = "DETRACCIÓN" Then
                panelDetraccion.Enabled = True
            Else
                panelDetraccion.Enabled = False
            End If

            If cboImpuestos.SelectedValue = "0" Then
                'cboSerieImpuesto.Enabled = False
                txtNumeroImpuesto.Enabled = False
            Else
                '    cboSerieImpuesto.Enabled = True
                '    txtNumeroImpuesto.Enabled = True
                '    Dim data As New DataTable
                '    data.Columns.Add("Codigo")
                '    data.Columns.Add("Descripcion")
                '    Dim data2 As DataTable
                '    Try
                '        data2 = objCrud.nCrudListarBD("select * from empresa_agente where id_empresa='" & CodigoEmpresaSession & "' and id_impuesto_sunat='" & cboImpuestos.SelectedValue.ToString & "' and estado=1", CadenaConexion)
                '        For Each row As DataRow In data2.Rows
                '            data.Rows.Add(row.Item("id").ToString, row.Item("serie").ToString)
                '        Next
                '        With cboSerieImpuesto
                '            .DataSource = data
                '            .ValueMember = "Codigo"
                '            .DisplayMember = "Descripcion"
                '        End With
                '        data2.Dispose()
                '    Catch ex As Exception
                '        MsgBox("No se pudo cargar la lista de Impuestos")
                '    End Try
            End If
            Dim dataImp As New DataTable
            dataImp = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
            txtCuentaI.Text = dataImp.Rows(0)("cuenta").ToString
        Else
            'cboSerieImpuesto.Enabled = False
            txtNumeroImpuesto.Enabled = False
        End If
    End Sub


    Private Sub cargarPagosPredeterminados()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & txtIdCaja.Text.Trim & "'", CadenaConexion)
            If data.Rows.Count > 0 Then
                If data.Rows(0)("tipo").ToString = "PRINCIPAL" Or data.Rows(0)("tipo").ToString = "CHICA" Then
                    cboTipoPago.SelectedValue = "8"
                ElseIf data.Rows(0)("tipo").ToString = "BANCOS" Then
                    cboTipoPago.SelectedValue = "1"
                End If
            End If

            Dim dataI As New DataTable
            dataI = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & txtIdCaja2.Text.Trim & "'", CadenaConexion)
            If dataI.Rows.Count > 0 Then
                If dataI.Rows(0)("tipo").ToString = "PRINCIPAL" Or dataI.Rows(0)("tipo").ToString = "CHICA" Then
                    cboTipoPagoI.SelectedValue = "8"
                ElseIf dataI.Rows(0)("tipo").ToString = "BANCOS" Then
                    cboTipoPagoI.SelectedValue = "1"
                End If
            End If
        End If
    End Sub

    Private Sub txtIdCaja_TextChanged(sender As Object, e As EventArgs) Handles txtIdCaja.TextChanged, txtIdCaja2.TextChanged
        cargarPagosPredeterminados()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim dt1 As New DataTable
        With dt1
            .Columns.Add("num_cuenta")
            .Columns.Add("desc_cuenta")
            .Columns.Add("debe")
            .Columns.Add("haber")
            .Columns.Add("id_tipo_pago")
            .Columns.Add("documento_pago")
            .Columns.Add("descripcion_pago")
        End With
        Dim montoTotal As Decimal = 0
        montoTotal = IIf(txtMonto.Text.Trim.Length = 0, 0, txtMonto.Text.Trim)
        Dim calculoI As Decimal
        Dim dataIC As New DataTable
        'para los tipos de impuestos
        If cboImpuestos.SelectedValue <> "0" Then
            dataIC = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
            calculoI = Decimal.Round((Decimal.Parse(txtPorcentaje.Text.Trim) * Decimal.Parse(lblMontoCompra.Text.Trim) / 100), 2)
            calculoImpuesto = calculoI
        End If
        If cboImpuestos.SelectedValue <> "0" And cboImpuestos.Text <> "PERCEPCIÓN" Then
            montoDetraccion = calculoI
            montoTotal = montoTotal - calculoI
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'detectar si se cancela con caja chica
        Dim idCaja As String = "1"
        idCaja = txtIdCaja.Text.Trim
        Dim dataCaja As New DataTable
        dataCaja = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & idCaja & "'", CadenaConexion)

        If dataCaja.Rows(0)("tipo").ToString = "CHICA" Then
            dt1.Rows.Add(txtCuentaP.Text.Trim, obtenerDatosCuenta(txtCuentaP.Text.Trim), "0.00", txtMonto.Text.Trim, "0", "0", "CANJE")
            dt1.Rows.Add(dataCaja.Rows(0)("contra_cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("contra_cuenta").ToString), txtMonto.Text.Trim, "0.00", "0", "0", "CANJE")

            'cuentas de pago o abono
            dt1.Rows.Add(dataCaja.Rows(0)("contra_cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("contra_cuenta").ToString), "0.00", txtMonto.Text.Trim, "0", "0", "ABONO: " & dataCaja.Rows(0)("descripcion").ToString)
            dt1.Rows.Add(dataCaja.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("cuenta").ToString), txtMonto.Text.Trim, "0.00", "0", "0", "ABONO: " & dataCaja.Rows(0)("descripcion").ToString)
            dgvOperaciones.DataSource = dt1
        ElseIf dataCaja.Rows(0)("tipo").ToString = "BANCOS" Then
            dt1.Rows.Add(txtCuentaP.Text.Trim, obtenerDatosCuenta(txtCuentaP.Text.Trim), "0.00", txtMonto.Text.Trim, "0", lblDocumento.Text, txtDescripcion.Text.Trim)
            dgvOperaciones.DataSource = dt1

            Dim dt As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row As DataRow = dt.NewRow()
            row.Item(0) = dataCaja.Rows(0)("cuenta").ToString
            row.Item(1) = obtenerDatosCuenta(dataCaja.Rows(0)("cuenta").ToString)
            row.Item(2) = txtMonto.Text.Trim
            row.Item(3) = "0.00"
            row.Item(4) = "0"
            row.Item(5) = "0"
            row.Item(6) = txtDescripcion.Text.Trim
            dt.Rows.Add(row)
        Else
            dt1.Rows.Add(txtCuentaP.Text.Trim, obtenerDatosCuenta(txtCuentaP.Text.Trim), "0.00", txtMonto.Text.Trim, "0", lblDocumento.Text, txtDescripcion.Text.Trim)
            dgvOperaciones.DataSource = dt1

            Dim dt As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row As DataRow = dt.NewRow()
            row.Item(0) = txtCuenta.Text.Trim
            row.Item(1) = obtenerDatosCuenta(txtCuenta.Text.Trim)
            row.Item(2) = txtMonto.Text.Trim
            row.Item(3) = "0.00"
            row.Item(4) = "0"
            row.Item(5) = "0"
            row.Item(6) = txtDescripcion.Text.Trim
            dt.Rows.Add(row)
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        realizarSumasTotales()
        txtBE.Text = "1"
    End Sub

    Private Sub btnAgregar2_Click(sender As Object, e As EventArgs) Handles btnAgregar2.Click
        Dim dt1 As New DataTable
        With dt1
            .Columns.Add("num_cuenta")
            .Columns.Add("desc_cuenta")
            .Columns.Add("debe")
            .Columns.Add("haber")
            .Columns.Add("id_tipo_pago")
            .Columns.Add("documento_pago")
            .Columns.Add("descripcion_pago")
        End With
        Dim montoTotal As Decimal = 0
        montoTotal = IIf(txtMonto.Text.Trim.Length = 0, 0, txtMonto.Text.Trim)
        Dim calculoI As Decimal
        Dim dataIC As New DataTable
        'para los tipos de impuestos
        If cboImpuestos.SelectedValue <> "0" Then
            dataIC = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)
            calculoI = Decimal.Round((Decimal.Parse(dataIC.Rows(0)("porcentaje").ToString) * Decimal.Parse(lblMontoCompra.Text.Trim) / 100), 2)
            calculoImpuesto = calculoI
        End If
        If cboImpuestos.SelectedValue <> "0" And cboImpuestos.Text <> "PERCEPCIÓN" Then
            montoDetraccion = calculoI
            montoTotal = montoTotal - calculoI
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'detectar si se cancela con caja chica
        Dim idCaja As String = "1"
        idCaja = txtIdCaja.Text.Trim
        Dim dataCaja As New DataTable
        dataCaja = objCrud.nCrudListarBD("select * from caja_configuracion where id='" & idCaja & "'", CadenaConexion)


        'para los impuestos'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If cboImpuestos.SelectedValue <> "0" Then
            If dgvOperaciones.RowCount = 0 Then
                dt1.Rows.Add(IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim), obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim)), "0.00", IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00"), "0", "0", txtGlosaDet.Text.Trim)
                dt1.Rows.Add(IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString), obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString)), IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00"), "0.00", "0", "0", txtGlosaDet.Text.Trim)
                dgvOperaciones.DataSource = dt1
            Else
                '''''CUENTA 42 IMPUESTO
                Dim dt3 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row3 As DataRow = dt3.NewRow()
                row3.Item(0) = IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim)
                row3.Item(1) = obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim))
                row3.Item(2) = IIf(cboImpuestos.Text = "PERCEPCIÓN", calculoI, "0.00")
                row3.Item(3) = IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00")
                row3.Item(4) = "0"
                row3.Item(5) = "0"
                row3.Item(6) = txtGlosaDet.Text.Trim
                dt3.Rows.Add(row3)


                Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row4 As DataRow = dtI.NewRow()
                row4.Item(0) = IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString)
                row4.Item(1) = obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString))
                row4.Item(2) = IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00")
                row4.Item(3) = IIf(cboImpuestos.Text = "PERCEPCIÓN", calculoI, "0.00")
                row4.Item(4) = "0"
                row4.Item(5) = "0"
                row4.Item(6) = txtGlosaDet.Text.Trim
                dtI.Rows.Add(row4)
            End If

        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        realizarSumasTotales()
        txtBI.Text = "1"
    End Sub
End Class