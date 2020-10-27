﻿Imports Negocio
Imports Entidades

Public Class frmNuevaVentaP
    Dim objCrud As New nCrud
    Dim objCA As New nCuentaAsiento
    Dim objMon As New nMonedas
    Dim iCarga As Integer = 0
    Dim dtPagos As New DataTable
    Dim objTDA As New nTipoDocumentoAsiento
    Dim idTipoOperacion As Integer = 1
    'Dim CodigoLocalSession As Integer = 1
    'Dim CodigoEmpresaSession As Integer = 1
    Dim dataAsientos As New DataTable
    Dim mIgv As Decimal = 0
    Dim mTotal As Decimal = 0
    Dim montoDetraccion As Decimal = 0
    Public idCentroCosto As String = 0

    Private Sub cargarTipoCompra()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add("CREDITO", "CRÉDITO")
        data.Rows.Add("CONTADO", "CONTADO")
        With cboTipoVenta
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub
    Private Sub cargarImpuestosSunatCredito()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "SIN AFECTO")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from impuestos_sunat where tipo_comprobante='COMPRA' and estado=1", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString)
            Next
            With cboPercepcion
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Impuestos")
        End Try
    End Sub
    Private Sub CargarTipoDocumento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objTDA.nListarCuentasSegunTipoAsientoBD(idTipoOperacion, CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(2).ToString.ToUpper)
            Next
            With cboTipoDocumento
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Documentos")
        End Try
    End Sub
    Private Sub cargarTipoOperacion()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListarBD("select * from gravaciones where estado=1 order by id asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboOperacion
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Impuestos")
        End Try
    End Sub
    Private Sub cargarTipoDeCambio()
        If iCarga = 1 Then
            Dim data As New DataTable
            data = objMon.nTipoDeCambioPorMoneda(cboMoneda.SelectedValue.ToString)
            'lblTipoDeCambio.Text = "Tipo de cambio: S/. " & data.Rows(0)("valor").ToString
            If data.Rows.Count > 0 Then
                txtTipoCambio.Text = data.Rows(0)("venta").ToString
            Else
                txtTipoCambio.Text = "1.00"
            End If
        End If
    End Sub
    Private Sub cargarMonedas()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        Dim data2 As DataTable
        Try
            data2 = objCrud.nCrudListar("select id,codigo,descripcion from tipo_moneda where estado=1 order by codigo asc")
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboMoneda
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                .SelectedValue = 115
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Monedas")
        End Try
    End Sub
    Private Sub realizarSumasTotales()
        Dim tDebe, tHaber, tDiferencia As Decimal
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            tDebe += Decimal.Parse(row.Cells("debe").Value)
            tHaber += Decimal.Parse(row.Cells("haber").Value)
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
    End Sub
    Private Sub frmNuevaCompraP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOperaciones.RowTemplate.Height = 25
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(182, 205, 226))
        cargarImpuestosSunatCredito()
        CargarTipoDocumento()
        cargarTipoOperacion()
        cargarTipoCompra()
        cargarMonedas()
        iCarga = 1
        cargarTipoDeCambio()
        realizarSumasTotales()
        With dtPagos.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("costo")
            .Add("base_imponible")
            .Add("igv")
            '.Add("isc")
            '.Add("otros_impuestos")
            '.Add("descuento")
            .Add("total")
        End With
    End Sub
    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        agregarCuentaContable()
    End Sub
    Private Sub dgvOperaciones_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvOperaciones.RowsRemoved
        On Error Resume Next
        If iCarga = 1 Then
            realizarSumasTotales()
        End If
    End Sub
    Private Sub dgvOperaciones_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOperaciones.CellValueChanged
        On Error Resume Next
        If iCarga = 1 Then
            realizarSumasTotales()
        End If
    End Sub

    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        cargarTipoDeCambio()
    End Sub

    Public Sub adicionarCuentas(cuenta As String, monto As Decimal, orden As String)
        Dim dtData As New DataTable

        With dtData.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
            .Add("descripcion")
        End With

        If dgvOperaciones.RowCount = 0 Then
            If orden = "D" Then
                dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), monto, "0.00", "-")
            End If
            If orden = "H" Then
                dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), "0.00", monto, "-")
            End If
        Else
            Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row As DataRow = dtI.NewRow()
            row.Item(0) = cuenta
            row.Item(1) = obtenerDatosCuenta(cuenta)
            row.Item(2) = IIf(orden = "D", monto, "0.00")
            row.Item(3) = IIf(orden = "H", monto, "0.00")
            row.Item(4) = "-"
            dtI.Rows.Add(row)
        End If

        dataAsientos.Merge(dtData)
        dgvOperaciones.DataSource = dataAsientos
        realizarSumasTotales()
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub guardarDatos(estadoComprobante As String)
        Dim dataIgv As New DataTable
        dataIgv = objCrud.nCrudListarBD("select * from  igv where estado=1", CadenaConexion)
        Dim preIGV As Decimal = 0
        Dim valIGV As Decimal = 0
        If cboOperacion.SelectedValue = "1" Or cboOperacion.SelectedValue = "2" Then
            preIGV = txtTotalVenta.Text / (1 + (Decimal.Parse(dataIgv.Rows(0)("valor").ToString) / 100))
            valIGV = txtTotalVenta.Text - preIGV
        Else
            valIGV = 0
        End If

        'REGISTRAR PERCEPCION, DETRACCION, RETENCION
        'If cboPercepcion.Text = "PERCEPCIÓN" Then
        '    Dim dataPorc As New DataTable
        '    dataPorc = objCrud.nCrudListar("select * from impuestos_sunat where tipo_comprobante='VENTA' and id='" & cboPercepcion.SelectedValue.ToString & "'")
        '    Dim entiImpuesto As New ImpuestosSunatEntity
        '    For Each row As DataGridViewRow In dgvOperaciones.Rows
        '        If dataPorc.Rows(0)("cuenta").ToString = row.Cells("num_cuenta").Value.ToString Then
        '            With entiImpuesto
        '                .operacion = "VENTA"
        '                .id_impuesto = "0"
        '                .serie = "0"
        '                .numero = "0"
        '                .id_tipo_comprobante = cboTipoDocumento.SelectedValue
        '                .tipo_comprobante = "0"
        '                .total_comprobante = txtTotalVenta.Text.Trim
        '                .porcentaje = "0"
        '                .monto = Decimal.Parse(row.Cells("debe").Value.ToString) + Decimal.Parse(row.Cells("haber").Value.ToString)
        '                .estado = "1"
        '            End With
        '            Dim objImp As New nImpuestosSunat
        '            Dim rptaImp As String
        '            rptaImp = objImp.nRegistrarImpuestosBD(entiImpuesto, CadenaConexion)
        '        End If
        '    Next
        'End If

        Dim entiCVenta, entiCabVent As New ComprobanteVentaEntity
        Dim entiCostoVenta As New CostoVentasEntity
        Dim objAC As New nAsientosContables
        With entiCabVent
            .numero_cuo = objAC.nObtenerNumeroCUOBD(CadenaConexion)
            .numero_maquina = "-"
            .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
            .fec_emision = dtFechaEmision.Value
            .fec_pago = dtFechaPago.Value
            .tipo_venta = cboTipoVenta.SelectedValue.ToString
            .id_gravado = cboOperacion.SelectedValue
            .marca = "0" 'IIf(cboTipoVenta.SelectedValue = "CREDITO", cboPercepcion.SelectedValue & "@" & IIf(cboPercepcion.Text = "SIN AFECTO", "0", cboTipoPercepcion.SelectedValue), "0" & "@I")
            .centro = idCentroCosto
            .serie_comprobante = txtSerie.Text
            .numero_comprobante = txtNumero.Text
            .cod_dni = "6"
            .num_dni = txtRuc.Text.Trim
            .razon_social = txtRazonSocial.Text.Trim
            .glosa = txtGlosa.Text.Trim
            .valor_facturado = Decimal.Parse(txtTotalVenta.Text.Trim) - valIGV
            .base_imponible = Decimal.Parse(txtTotalVenta.Text.Trim) - valIGV
            .valor_exonerado = 0
            .valor_inafecto = 0
            .valor_isc = 0
            .valor_igv = valIGV
            .otros_base_imponible = 0
            .total = Decimal.Parse(txtTotalVenta.Text.Trim)
            .id_moneda = cboMoneda.SelectedValue.ToString
            .tipo_cambio = txtTipoCambio.Text.Trim
            .fec_comp_origen = dtFechaEmision.Value
            .tip_comp_origen = "-"
            .serie_comp_origen = "-"
            .numero_comp_origen = "-"
            .estado = 1
            .cuenta = ""
            .debe = 0
            .haber = 0
            .estado_comprobante = estadoComprobante
        End With
        Dim objCV As New nComprobanteVenta
        Dim rptaRCC As String = objCV.nRegistrarComprobanteVentaBD(entiCabVent, CadenaConexion)
        If rptaRCC <> "ok" Then
            MsgBox("Error en el registro del comprobante: " & rptaRCC)
        End If

        Dim dataComVenta As New DataTable
        Dim dataCV As New DataTable
        dataCV = objCV.obtenerIdComprobanteVentaBD(CadenaConexion)
        With entiCVenta
            .id_asiento_venta = dataCV.Rows("0")("id").ToString
            .id_moneda = cboMoneda.SelectedValue
            .tipo_cambio = txtTipoCambio.Text.Trim
            .fec_emision = Date.Parse(dtFechaEmision.Value)
            .id_tipo_comprobante = cboTipoDocumento.SelectedValue.ToString
            .numero_comprobante = txtNumero.Text
            .tipo_tasa_detraccion = cboPercepcion.SelectedValue
            .numero_detraccion = txtNumeroImpuesto.Text
            .valor_detraccion = Decimal.Parse(txtTotalVenta.Text) * Decimal.Parse(txtPorcPercep.Text) / 100
            .fecha_detraccion = Date.Parse(dtFechaEmision.Value)
        End With

        For Each row As DataGridViewRow In dgvOperaciones.Rows
            entiCVenta.cuenta = row.Cells("num_cuenta").Value
            entiCVenta.debe = row.Cells("debe").Value
            entiCVenta.haber = row.Cells("haber").Value
            entiCVenta.glosa = txtGlosa.Text.Trim

            Dim rptaRAV As String = objCV.nRegistrarDetalleAsientoVentaBD(entiCVenta, CadenaConexion)
            If rptaRAV <> "ok" Then
                MsgBox("Error en el registro del comprobante: " & rptaRCC)
            End If
        Next

        MsgBox("VENTA GRABADA CON EXITO")
        frmListaComprobanteVentas.realizarConsulta()
        Me.Dispose()
    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        guardarDatos("P")
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        procesarBoton()
    End Sub

    Private Sub procesarBoton()
        If validarEntradas() = True Then
            If btnFinalizar.Text = "FINALIZAR" Then
                guardarDatos("F")
            ElseIf btnFinalizar.Text = "PAGAR" Then
                frmNuevaVentaPago.Show()
            End If
        End If
    End Sub

    Private Function validarEntradas() As Boolean
        Dim rpta As Boolean = False
        If cboTipoDocumento.SelectedValue.ToString = "0" Then
            rpta = False
            MsgBox("Seleccione un tipo de documento")
            cboTipoDocumento.Focus()
        ElseIf txtSerie.Text.Trim.Length = 0 Then
            rpta = False
            MsgBox("Ingrese la Serie del comprobante")
            txtSerie.Focus()
        ElseIf txtNumero.Text.Trim.Length = 0 Then
            rpta = False
            MsgBox("Ingrese el Número del comprobante")
            txtNumero.Focus()
        ElseIf txtRuc.Text.Trim.Length = 0 Then
            rpta = False
            MsgBox("Ingrese el RUC/DNI del Cliente")
            txtRuc.Focus()
        ElseIf txtRazonSocial.Text.Trim.Length = 0 Then
            rpta = False
            MsgBox("Ingrese la Datos del Cliente")
            txtRazonSocial.Focus()
        ElseIf txtGlosa.Text.Trim.Length = 0 Then
            rpta = False
            MsgBox("Ingrese la Glosa para el registro del comprobante")
            txtGlosa.Focus()
        ElseIf Decimal.Parse(txtTotalVenta.Text.Trim) = 0 Then
            rpta = False
            MsgBox("Ingrese el Total de la Venta")
            txtTotalVenta.Focus()
        ElseIf dgvOperaciones.RowCount = 0 Then
            rpta = False
            MsgBox("Ingrese cuentas contables")
            agregarCuentaContable()
        Else
            rpta = True
        End If
        Return rpta
    End Function
    Private Sub cboTipoCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoVenta.SelectedIndexChanged
        If iCarga = 1 Then
            If cboTipoVenta.SelectedValue = "CONTADO" Then
                btnFinalizar.Text = "PAGAR"
                btnFinalizar.BackColor = Color.Green
            Else
                btnFinalizar.Text = "FINALIZAR"
                btnFinalizar.BackColor = Drawing.Color.FromArgb(6, 63, 114)
            End If
        End If
    End Sub

    Private Sub txtRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRuc.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtRuc.Text.Trim.Length >= 2 Then
                With frmEscogerCliente
                    .formInicio = "ventaP"
                    .datoCliente = txtRuc.Text.Trim
                    .txtDescripcion.Text = .datoCliente
                    .realizarBusqueda()
                    .ShowDialog()
                End With
            End If
        End If
    End Sub

    Private Sub txtRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRazonSocial.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            buscarProveedor()
        End If
    End Sub

    Private Sub buscarProveedor()
        If txtRuc.Focused = True Then
            With frmEscogerCliente
                .formInicio = "ventaP"
                .datoCliente = txtRuc.Text.Trim
                .txtDescripcion.Text = .datoCliente
                .realizarBusqueda()
                .ShowDialog()
            End With
        ElseIf txtRazonSocial.Focused = True Then
            With frmEscogerCliente
                .formInicio = "ventaP"
                .datoCliente = txtRazonSocial.Text.Trim
                .txtDescripcion.Text = .datoCliente
                .realizarBusqueda()
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    'Private Sub cboPercepcion_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If iCarga = 1 Then
    '        Dim dataPorc As New DataTable
    '        dataPorc = objCrud.nCrudListar("select * from impuestos_sunat where tipo_comprobante='VENTA' and  id='" & cboPercepcion.SelectedValue.ToString & "'")
    '        If dataPorc.Rows.Count > 0 Then
    '            txtPorcPercep.Text = dataPorc.Rows(0)("porcentaje").ToString
    '            If cboPercepcion.Text = "PERCEPCIÓN" Then
    '                cboTipoPercepcion.Enabled = True
    '                Dim data As New DataTable
    '                data.Columns.Add("Codigo")
    '                data.Columns.Add("Descripcion")
    '                data.Rows.Add("I", "INTERNA")
    '                data.Rows.Add("E", "EXTERNA")
    '                With cboTipoPercepcion
    '                    .DataSource = data
    '                    .ValueMember = "Codigo"
    '                    .DisplayMember = "Descripcion"
    '                End With
    '            Else
    '                cboTipoPercepcion.Enabled = False
    '            End If
    '        Else
    '            txtPorcPercep.Text = "0"
    '        End If
    '    End If
    'End Sub

    Private Sub frmNuevaCompraP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Insert Then
            If txtRuc.Focused = True Or txtRazonSocial.Focused = True Then
                buscarProveedor()
            Else
                agregarCuentaContable()
            End If
        ElseIf e.KeyCode = Keys.End Then
            procesarBoton()
        End If
    End Sub

    Private Sub agregarCuentaContable()
        frmAgregarCuentasNuevo.formIni = "nuevaVentaP"
        frmAgregarCuentasNuevo.tipoOperacion = cboOperacion.SelectedValue.ToString
        frmAgregarCuentasNuevo.ShowDialog()
        frmAgregarCuentasNuevo.txtCuenta.Select()
    End Sub

    'Private Sub cboTipoPercepcion_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If iCarga = 1 Then
    '        If cboPercepcion.Text = "PERCEPCIÓN" Then
    '            If cboTipoPercepcion.SelectedValue.ToString = "E" Then
    '                cboSerieImpuesto.Enabled = True
    '                txtNumeroImpuesto.Enabled = True
    '                Dim data As New DataTable
    '                data.Columns.Add("Codigo")
    '                data.Columns.Add("Descripcion")
    '                Dim data2 As DataTable
    '                Try
    '                    data2 = objCrud.nCrudListarBD("select * from empresa_agente where id_empresa='" & CodigoEmpresaSession & "' and id_impuesto_sunat='" & cboPercepcion.SelectedValue.ToString & "' and estado=1", CadenaConexion)
    '                    For Each row As DataRow In data2.Rows
    '                        data.Rows.Add(row.Item("id").ToString, row.Item("serie").ToString)
    '                    Next
    '                    With cboSerieImpuesto
    '                        .DataSource = data
    '                        .ValueMember = "Codigo"
    '                        .DisplayMember = "Descripcion"
    '                    End With
    '                    data2.Dispose()
    '                Catch ex As Exception
    '                    MsgBox("No se pudo cargar la lista de Impuestos")
    '                End Try
    '            Else
    '                cboSerieImpuesto.Enabled = False
    '                txtNumeroImpuesto.Enabled = False
    '            End If
    '        End If
    '    End If
    'End Sub

End Class