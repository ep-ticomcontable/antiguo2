Imports Negocio
Imports Entidades

Public Class frmAbonoComprobanteCompras

    Dim objCom As New nComprobanteCompra
    Dim objPag As New nPagosCompras
    Dim objDet As New nDetraccion
    Dim objCrud As New nCrud
    Dim objCA As New nCuentaAsiento
    Dim objTP As New nTipoPagos
    Dim objAbono As New nAbonosPagos

    Dim dataCompra As New DataTable
    Public codCompra As String
    Dim iCarga As Integer = 0
    Dim idTipoOperacion As Integer = 2
    'Dim CodigoLocalSession As Integer = 1
    'Dim CodigoEmpresaSession As Integer = 1
    Dim montoDetraccion As Decimal = 0
    Dim calculoImpuesto As Decimal = 0
    Dim tipoCompra As String = ""
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
        'With cboTipoPago
        '    .DataSource = data
        '    .ValueMember = "Codigo"
        '    .DisplayMember = "Descripcion"
        'End With
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
        'data.Rows.Add("EF", "Efectivo")
        'data.Rows.Add("CH", "Cheque")
        'data.Rows.Add("TB", "Transferencia Bancaria")
        'data.Rows.Add("DB", "Depósito Bancario")
        'data.Rows.Add("NC", "Nota Crédito")
        'With cboTipo
        '    .DataSource = data
        '    .ValueMember = "Codigo"
        '    .DisplayMember = "Descripcion"
        'End With
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
    Private Sub txtCDetraccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCDetraccion.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCDetraccion.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmAbonoCompra"
                    .cuentaInicio = txtCDetraccion.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
    End Sub
    Private Sub cargarImpuestosSunat()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "SIN AFECTO")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='COMPRA' and descripcion<>'PERCEPCIÓN' and estado=1", CadenaConexion)
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
    Private Sub cargarDatosComprobanteCompra()
        'Dim dataCliente As New DataTable
        'dataCliente = objPag.nBuscarProveedorBD(datoProveedor, CadenaConexion)
        dataCompra = objCom.nDataComprobanteCompraPorIdBD(codCompra, CadenaConexion)
        Dim cadena As String()

        cadena = dataCompra.Rows(0)("marca").ToString.Split("@")
        If cadena.Count > 0 Then
            'MsgBox(cadena(0).ToString & "-" & cadena(1).ToString)
            cboImpuestos.SelectedValue = cadena(0).ToString
            cargarDatosImpuestos()
            'If cadena(1).ToString = "EXTERNA" Then
            '    cargarDatosImpuestos()
            '    'MsgBox(cboImpuestos.SelectedValue)
            'End If
        End If

        lblDniRuc.Text = dataCompra.Rows(0)("num_dni")
        lblRazonNombre.Text = dataCompra.Rows(0)("razon_social")
        lblDocumento.Text = dataCompra.Rows(0)("documento")
        lblSerieNumero.Text = dataCompra.Rows(0)("serie") & "-" & dataCompra.Rows(0)("numero")
        LblMoneda.Text = dataCompra.Rows(0)("moneda")
        lblTipoCambio.Text = dataCompra.Rows(0)("tipo_cambio")
        lblDescripcionCompra.Text = dataCompra.Rows(0)("glosa")
        lblFechaEmision.Text = dataCompra.Rows(0)("fec_emision")
        lblFechaPago.Text = dataCompra.Rows(0)("fec_pago")
        'txtBaseDetraccion.Text = dataCompra.Rows(0)("total")
        lblMontoCompra.Text = (dataCompra.Rows(0)("total"))
        Dim dtAbono As New DataTable
        dtAbono = objCrud.nCrudListarBD("select isnull(sum(monto),0) as 'abono' from abono_pagos_compras where id_compra='" & codCompra & "'", CadenaConexion)
        If Decimal.Parse(dtAbono.Rows(0)("abono").ToString) > 0 Then
            lblDeuda.Text = (dataCompra.Rows(0)("total") - Decimal.Parse(dtAbono.Rows(0)("abono")))
        Else
            lblDeuda.Text = (dataCompra.Rows(0)("total"))
        End If

        Dim dtCompra As New DataTable
        dtCompra = objCrud.nCrudListarBD("select * from asientos_comprobante_compra where id_comprobante_compra='" & codCompra & "'", CadenaConexion)

        cboImpuestos.SelectedValue = dtCompra.Rows(0)("tipo_tasa_detraccion").ToString
        txtPorcentaje.Text = dtCompra.Rows(0)("tasa_detraccion").ToString
        dtFecImpuesto.Value = Date.Parse(dtCompra.Rows(0)("fecha_detraccion").ToString)
        txtNumeroImpuesto.Text = dtCompra.Rows(0)("numero_detraccion").ToString

        'Cargar montos
        If cadena(0).ToString <> "0" Then
            txtMontoDet.Text = Decimal.Round((Decimal.Parse(lblMontoCompra.Text.Trim) * Decimal.Parse(txtPorcentaje.Text) / 100), 2)
            txtMonto.Text = Decimal.Parse(lblMontoCompra.Text.Trim) - Decimal.Parse(txtMontoDet.Text.Trim)
        Else
            txtMonto.Text = lblDeuda.Text.Trim
            txtMontoDet.Text = "0.00"
        End If

        Dim dtCanje As New DataTable
        dtCanje = objCrud.nCrudListarBD("select tipo_compra from comprobante_compra where id='" & codCompra & "'", CadenaConexion)
        tipoCompra = dtCanje.Rows(0)("tipo_compra").ToString
        If tipoCompra.StartsWith("LETRA") Then
            gbImpuestos.Enabled = False
        Else
            gbImpuestos.Enabled = True
        End If


    End Sub
    Private Sub cargarAbonosPagoCompra()
        Dim data As New DataTable
        data = objAbono.nSumaAbonoPagoCompras(codCompra)

        If data.Rows.Count > 0 Then
            Dim dataCompra As New DataTable
            dataCompra = objCom.nDataComprobanteCompraPorId(codCompra)
            txtMonto.Text = (dataCompra.Rows(0)("total") - data.Rows(0)("abono"))
        End If
    End Sub
    Private Sub cargarDeudaPendiente()
        'Deshabilitar pago de Impuestos
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from asientos_abono_compras where id_compra='" & codCompra & "'", CadenaConexion)
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
                dtAbono = objCrud.nCrudListarBD("select isnull(sum(monto),0) as 'abono' from abono_pagos_compras where id_compra='" & codCompra & "'", CadenaConexion)
                If Decimal.Parse(dtAbono.Rows(0)("abono").ToString) > 0 Then
                    If gbImpuestos.Enabled = True Then
                        txtMonto.Text = (dataCompra.Rows(0)("total") - Decimal.Parse(dtAbono.Rows(0)("abono"))) - Decimal.Parse(txtMontoDet.Text.Trim)
                    Else
                        txtMonto.Text = lblDeuda.Text.Trim
                    End If
                Else
                    txtMonto.Text = (dataCompra.Rows(0)("total"))
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
    Private Sub frmAbonoComprobanteCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'datoProveedor = "10447301500"
        'codCompra = 1
        cargarImpuestosSunat()
        cargarTipoMovimientos()
        cargarTipoMovimientos2()
        dgvOperaciones.RowTemplate.Height = 34
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        iCarga = 1
        cargarDatosComprobanteCompra()
        cargarAbonosPagoCompra()
        cargarCuentaInicial()
        cargarDeudaPendiente()
        cboTipoPago.SelectedValue = "8"
    End Sub
    Private Sub cargarCuentaInicial()
        If Not tipoCompra.StartsWith("LETRA") Then
            Dim data As New DataTable
            data = objCrud.nCrudListarBD("select * from asientos_comprobante_compra where id_comprobante_compra='" & codCompra & "'", CadenaConexion)
            If cboImpuestos.SelectedValue = 0 Then
                For Each row As DataRow In data.Rows
                    If row.Item("cuenta").ToString.StartsWith("4") And Not row.Item("cuenta").ToString.StartsWith("40") Then
                        txtCuentaP.Text = row.Item("cuenta").ToString
                        lblCuentaP.Text = obtenerDatosCuenta(row.Item("cuenta").ToString)
                        Exit For
                    End If
                Next
            Else
                Dim dataImp As New DataTable
                dataImp = objCrud.nCrudListarBD("select * from impuestos_sunat where id='" & cboImpuestos.SelectedValue.ToString & "'", CadenaConexion)

                txtCuentaI.Text = dataImp.Rows(0)("cuenta").ToString

                For Each row As DataRow In data.Rows
                    If row.Item("cuenta").ToString.StartsWith("4") And Not row.Item("cuenta").ToString.StartsWith("40") And row.Item("cuenta").ToString <> dataImp.Rows(0)("cuenta").ToString Then
                        txtCuentaP.Text = row.Item("cuenta").ToString
                        lblCuentaP.Text = obtenerDatosCuenta(row.Item("cuenta").ToString)
                        Exit For
                    End If
                Next
            End If

        Else
            Dim dtCL1, dtCL2 As New DataTable
            dtCL1 = objCrud.nCrudListarBD("select * from canje_letra where id_comprobante='" & codCompra & "'", CadenaConexion)
            dtCL2 = objCrud.nCrudListarBD("select * from asientos_libro_diario where id_comprobante='LC" & dtCL1.Rows(0)("id") & "'", CadenaConexion)
            For Each row As DataRow In dtCL2.Rows
                If row.Item("cuenta").ToString.StartsWith("423") Then
                    txtCuentaP.Text = row.Item("cuenta").ToString
                    lblCuentaP.Text = obtenerDatosCuenta(row.Item("cuenta").ToString)
                    Exit For
                End If
            Next
        End If
    End Sub
    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuenta.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmAbonoComprobanteCompras"
                    .cuentaInicio = txtCuenta.Text.Trim
                    .ShowDialog()
                End With
            End If
        End If
    End Sub
    Private Sub txtCuentaP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuentaP.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtCuentaP.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmAbonoComprobanteCompras2"
                    .cuentaInicio = txtCuentaP.Text.Trim
                    .ShowDialog()
                End With
            End If

        End If
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
            dt1.Rows.Add(txtCuentaP.Text.Trim, obtenerDatosCuenta(txtCuentaP.Text.Trim), txtMonto.Text.Trim, "0.00", "0", "0", "CANJE")
            dt1.Rows.Add(dataCaja.Rows(0)("contra_cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("contra_cuenta").ToString), "0.00", txtMonto.Text.Trim, "0", "0", "CANJE")

            'cuentas de pago o abono
            dt1.Rows.Add(dataCaja.Rows(0)("contra_cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("contra_cuenta").ToString), txtMonto.Text.Trim, "0.00", "0", "0", "ABONO: " & dataCaja.Rows(0)("descripcion").ToString)
            dt1.Rows.Add(dataCaja.Rows(0)("cuenta").ToString, obtenerDatosCuenta(dataCaja.Rows(0)("cuenta").ToString), "0.00", txtMonto.Text.Trim, "0", "0", "ABONO: " & dataCaja.Rows(0)("descripcion").ToString)
            dgvOperaciones.DataSource = dt1
        ElseIf dataCaja.Rows(0)("tipo").ToString = "BANCOS" Then
            dt1.Rows.Add(txtCuentaP.Text.Trim, obtenerDatosCuenta(txtCuentaP.Text.Trim), txtMonto.Text.Trim, "0.00", "0", lblDocumento.Text, txtDescripcion.Text.Trim)
            dgvOperaciones.DataSource = dt1

            Dim dt As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row As DataRow = dt.NewRow()
            row.Item(0) = dataCaja.Rows(0)("cuenta").ToString
            row.Item(1) = obtenerDatosCuenta(dataCaja.Rows(0)("cuenta").ToString)
            row.Item(2) = "0.00"
            row.Item(3) = txtMonto.Text.Trim
            row.Item(4) = "0"
            row.Item(5) = "0"
            row.Item(6) = txtDescripcion.Text.Trim
            dt.Rows.Add(row)
        Else
            dt1.Rows.Add(txtCuentaP.Text.Trim, obtenerDatosCuenta(txtCuentaP.Text.Trim), txtMonto.Text.Trim, "0.00", "0", lblDocumento.Text, txtDescripcion.Text.Trim)
            dgvOperaciones.DataSource = dt1

            Dim dt As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row As DataRow = dt.NewRow()
            row.Item(0) = txtCuenta.Text.Trim
            row.Item(1) = obtenerDatosCuenta(txtCuenta.Text.Trim)
            row.Item(2) = "0.00"
            row.Item(3) = txtMonto.Text.Trim
            row.Item(4) = "0"
            row.Item(5) = "0"
            row.Item(6) = txtDescripcion.Text.Trim
            dt.Rows.Add(row)
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ''para los impuestos'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'If cboImpuestos.SelectedValue <> "0" Then
        '    '''''CUENTA 42 IMPUESTO
        '    Dim dt3 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
        '    Dim row3 As DataRow = dt3.NewRow()
        '    row3.Item(0) = IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim)
        '    row3.Item(1) = obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim))
        '    row3.Item(2) = IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00")
        '    row3.Item(3) = IIf(cboImpuestos.Text = "PERCEPCIÓN", calculoI, "0.00")
        '    row3.Item(4) = "0"
        '    row3.Item(5) = "0"
        '    row3.Item(6) = cboImpuestos.Text & ": " & IIf(cboImpuestos.Text = "PERCEPCIÓN" Or cboImpuestos.SelectedValue = "0", "0" & "-", "0" & "-") & txtNumeroImpuesto.Text
        '    dt3.Rows.Add(row3)

        '    Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
        '    Dim row4 As DataRow = dtI.NewRow()
        '    row4.Item(0) = IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString)
        '    row4.Item(1) = obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString))
        '    row4.Item(2) = IIf(cboImpuestos.Text = "PERCEPCIÓN", calculoI, "0.00")
        '    row4.Item(3) = IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00")
        '    row4.Item(4) = "0"
        '    row4.Item(5) = "0"
        '    row4.Item(6) = cboImpuestos.Text & ": " & IIf(cboImpuestos.Text = "PERCEPCIÓN" Or cboImpuestos.SelectedValue = "0", "0" & "-", "0" & "-") & txtNumeroImpuesto.Text
        '    dtI.Rows.Add(row4)
        'End If
        ' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
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
                dt1.Rows.Add(IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim), obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim)), IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00"), "0.00", "0", "0", txtGlosaDet.Text.Trim)
                dt1.Rows.Add(IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString), obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString)), "0.00", IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00"), "0", "0", txtGlosaDet.Text.Trim)
                dgvOperaciones.DataSource = dt1
            Else
                '''''CUENTA 42 IMPUESTO
                Dim dt3 As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row3 As DataRow = dt3.NewRow()
                row3.Item(0) = IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim)
                row3.Item(1) = obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", dataIC.Rows(0)("cuenta").ToString, txtCuentaP.Text.Trim))
                row3.Item(2) = IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00")
                row3.Item(3) = IIf(cboImpuestos.Text = "PERCEPCIÓN", calculoI, "0.00")
                row3.Item(4) = "0"
                row3.Item(5) = "0"
                row3.Item(6) = txtGlosaDet.Text.Trim
                dt3.Rows.Add(row3)


                Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
                Dim row4 As DataRow = dtI.NewRow()
                row4.Item(0) = IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString)
                row4.Item(1) = obtenerDatosCuenta(IIf(cboImpuestos.Text = "DETRACCIÓN", txtCDetraccion.Text.Trim, dataIC.Rows(0)("cuenta").ToString))
                row4.Item(2) = IIf(cboImpuestos.Text = "PERCEPCIÓN", calculoI, "0.00")
                row4.Item(3) = IIf(cboImpuestos.Text <> "PERCEPCIÓN", calculoI, "0.00")
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
    Private Sub dgvOperaciones_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvOperaciones.EditingControlShowing
        txtBE.Text = "0"
        txtBI.Text = "0"
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If dgvOperaciones.RowCount > 0 Then
            guardarAbonos()
        Else
            MsgBox("No se han cargado los asientos contables para los abonos respectivos.")
        End If
    End Sub
    Private Sub guardarAbonos()
        Dim EntiAboCom, EntiAsientoAboCom As New AbonoComprasEntity
        If txtBE.Text = "1" Then
            With EntiAboCom
                .id_compra = codCompra
                .id_caja = txtIdCaja.Text.Trim
                .tipo_comprobante = dataCompra.Rows(0)("id_tipo_comprobante").ToString
                .monto = txtMonto.Text.Trim
                .tipo = cboTipoPago.SelectedValue.ToString
                .numero = txtNumero.Text.Trim
                .descripcion = txtDescripcion.Text.Trim
                .fecha = DateTime.Now.ToString("yyyy/MM/dd") & " " & Now.ToString("HH:mm:ss")
                .estado = "1"
            End With
            objAbono.nRegistrarAbonoComprasBD(EntiAboCom, CadenaConexion)
            Dim codAbono As String = objAbono.nObtenerUltimoAbonoCompraBD(CadenaConexion)
            With EntiAsientoAboCom
                .id = codAbono
                .id_cliente = dataCompra.Rows(0)("num_dni").ToString
                .id_compra = codCompra
                .cuenta = txtCuentaP.Text.Trim
                .base_imponible = txtMonto.Text.Trim
                .nro_detraccion = IIf(cboImpuestos.Text = "DETRACCIÓN", txtNumeroImpuesto.Text.Trim, "0")
                .tipo_tasa_detraccion = cboImpuestos.SelectedValue
                .valor_tasa = txtPorcentaje.Text.Trim
                .valor_detraccion = calculoImpuesto
                .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                .monto = txtMonto.Text.Trim
                .tipo = cboTipoPago.SelectedValue
                .descripcion = txtDescripcion.Text
                .debe = txtMonto.Text.Trim
                .haber = "0.00"
                .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
            End With
            objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion)
            With EntiAsientoAboCom
                .id = codAbono
                .id_cliente = dataCompra.Rows(0)("num_dni").ToString
                .id_compra = codCompra
                .cuenta = txtCuenta.Text.Trim
                .base_imponible = txtMonto.Text.Trim
                .nro_detraccion = IIf(cboImpuestos.Text = "DETRACCIÓN", txtNumeroImpuesto.Text.Trim, "0")
                .tipo_tasa_detraccion = cboImpuestos.SelectedValue
                .valor_tasa = txtPorcentaje.Text.Trim
                .valor_detraccion = calculoImpuesto
                .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                .monto = txtMonto.Text.Trim
                .tipo = cboTipoPago.SelectedValue
                .descripcion = txtDescripcion.Text
                .debe = "0.00"
                .haber = txtMonto.Text.Trim
                .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
            End With
            objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion)
            'MsgBox("ASIENTOS ABONOS: " & objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion))
        End If
        If txtBI.Text = "1" Then
            With EntiAboCom
                .id_compra = codCompra
                .id_caja = txtIdCaja2.Text.Trim
                .tipo_comprobante = dataCompra.Rows(0)("id_tipo_comprobante").ToString
                .monto = txtMontoDet.Text.Trim
                .tipo = cboTipoPagoI.SelectedValue.ToString
                .numero = txtNumeroImpuesto.Text.Trim
                .descripcion = txtGlosaDet.Text.Trim
                .fecha = dtFecImpuesto.Value
                .estado = "1"
            End With
            objAbono.nRegistrarAbonoComprasBD(EntiAboCom, CadenaConexion)

            Dim codAbono As String = objAbono.nObtenerUltimoAbonoCompraBD(CadenaConexion)
            With EntiAsientoAboCom
                .id = codAbono
                .id_cliente = dataCompra.Rows(0)("num_dni").ToString
                .id_compra = codCompra
                .cuenta = txtCuentaI.Text.Trim
                .base_imponible = txtMontoDet.Text.Trim
                .nro_detraccion = IIf(cboImpuestos.Text = "DETRACCIÓN", txtNumeroImpuesto.Text.Trim, "0")
                .tipo_tasa_detraccion = cboImpuestos.SelectedValue
                .valor_tasa = txtPorcentaje.Text.Trim
                .valor_detraccion = calculoImpuesto
                .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                .monto = txtMontoDet.Text.Trim
                .tipo = cboTipoPagoI.SelectedValue
                .descripcion = txtGlosaDet.Text
                .debe = txtMontoDet.Text.Trim
                .haber = "0.00"
                .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
            End With
            objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion)
            With EntiAsientoAboCom
                .id = codAbono
                .id_cliente = dataCompra.Rows(0)("num_dni").ToString
                .id_compra = codCompra
                .cuenta = txtCDetraccion.Text.Trim
                .base_imponible = txtMontoDet.Text.Trim
                .nro_detraccion = IIf(cboImpuestos.Text = "DETRACCIÓN", txtNumeroImpuesto.Text.Trim, "0")
                .tipo_tasa_detraccion = cboImpuestos.SelectedValue
                .valor_tasa = txtPorcentaje.Text.Trim
                .valor_detraccion = calculoImpuesto
                .fecha_detraccion = dtFecImpuesto.Value.ToString("yyyy/MM/dd")
                .monto = txtMontoDet.Text.Trim
                .tipo = cboTipoPagoI.SelectedValue
                .descripcion = txtGlosaDet.Text
                .debe = "0.00"
                .haber = txtMontoDet.Text.Trim
                .fecha = dtFechaAbono.Value.ToString("yyyy/MM/dd")
            End With
            objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion)
            'MsgBox("ASIENTOS ABONOS: " & objAbono.nRegistrarAsientoAbonoComprasBD(EntiAsientoAboCom, CadenaConexion))
        End If
        MsgBox("ABONO REGISTRADO CON ÉXITO")
        frmListaComprobanteCompras.realizarConsulta()
        'frmPagos.cargarComprasPorPagar()
        Me.Dispose()
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
        Else
            'cboSerieImpuesto.Enabled = False
            txtNumeroImpuesto.Enabled = False
        End If
    End Sub
    Private Sub cboSerieImpuesto_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If iCarga = 1 Then
        '    Dim data As New DataTable
        '    data = objCrud.nCrudListarBD("select * from empresa_agente where id='" & cboSerieImpuesto.SelectedValue.ToString & "' and estado=1", CadenaConexion)
        '    If data.Rows.Count > 0 Then
        '        txtNumeroImpuesto.Text = data.Rows(0)("numero").ToString
        '    Else
        '        txtNumeroImpuesto.Text = 0
        '    End If
        'End If
    End Sub
    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPago.SelectedIndexChanged
        If iCarga = 1 Then
            If cboTipoPago.SelectedValue.ToString = "7" Then
                frmGirarCheque.tipoAbono = "compra"
                frmGirarCheque.valMoneda = dataCompra.Rows(0)("moneda")
                frmGirarCheque.btnCargarDatosAbono.Visible = True
                frmGirarCheque.btnElegirCheque.Visible = True
                frmGirarCheque.redimensionar()
                frmGirarCheque.Show()
            End If
        End If
    End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        frmEscogerCaja.formInicio = "abonoCompra"
        frmEscogerCaja.Show()
    End Sub

    Private Sub btnBuscar2_Click(sender As Object, e As EventArgs) Handles btnBuscar2.Click
        frmEscogerCaja.formInicio = "abonoCompra2"
        frmEscogerCaja.Show()
    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class