Imports Negocio
Imports Entidades
Public Class frmNuevaNotaCreditoCompra

    Dim obj As New nCrud
    Dim objTDA As New nTipoDocumentoAsiento
    Public codComprobante As Integer = 0
    Public codTipoComprobante As Integer = 0
    Dim objCC As New nComprobanteCompra
    Dim objNCD As New nNotaCreditoDebito
    Dim tipoOperacion As Integer = 6 'DEVOLUCIONES
    Dim codigoComprobante As Integer = 0

    Public Sub cargarDatosComprobante()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from comprobante_compra where id='" & codComprobante & "'", CadenaConexion)
        With data
            cboTipoDocumento.SelectedValue = .Rows(0)("id_tipo_comprobante").ToString
            txtSerie.Text = .Rows(0)("serie_comprobante").ToString
            txtNumero.Text = .Rows(0)("numero_comprobante").ToString
            dtFecha.Value = .Rows(0)("fec_emision").ToString
            txtRuc.Text = .Rows(0)("num_dni").ToString
            txtRazon.Text = .Rows(0)("razon_social").ToString
            txtMonto.Text = .Rows(0)("valor_facturado").ToString
            txtIgv.Text = .Rows(0)("valor_igv").ToString
            txtTotal.Text = .Rows(0)("total").ToString
        End With
    End Sub
    Private Sub cargarTipoDocumento()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")
        Dim data2 As DataTable
        Try
            data2 = objTDA.nListarCuentasSegunTipoAsientoBD(1, CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(0).ToString, "(" & row.Item(1).ToString & ") " & row.Item(2).ToString.ToUpper)
            Next
            With cboTipoDocumento
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
                .SelectedValue = codTipoComprobante
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Documentos")
        End Try
    End Sub
    Private Sub cargarMotivos()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(0, "Seleccione")

        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select * from motivo_credito_debito where estado=1 order by descripcion asc", CadenaConexion)
            For Each row As DataRow In data2.Rows
                data.Rows.Add(row.Item(1).ToString, row.Item(1).ToString)
            Next
            With cboMotivo
                .DataSource = data
                .ValueMember = "Codigo"
                .DisplayMember = "Descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar la lista de Documentos")
        End Try
    End Sub
    Private Sub cargarRegistroCuentas(codigoComprobante)

        'If dgvLista.RowCount = 0 Then
        '    Dim dtItem As New DataTable
        '    With dtItem.Columns
        '        .Add("id")
        '        .Add("id_asiento_compra")
        '        .Add("num_cuenta")
        '        .Add("desc_cuenta")
        '        .Add("debe")
        '        .Add("haber")
        '    End With
        '    Dim data As New DataTable
        '    data = obj.nCrudListar("[usp_cuentaComprobanteCompraTodos] '" & codigoComprobante & "'")
        '    For Each row As DataRow In data.Rows
        '        dtItem.Rows.Add(row.Item("id").ToString, row.Item("id_comprobante_compra").ToString, _
        '                    row.Item("num_cuenta").ToString, _
        '                    obtenerDatosCuenta(row.Item("num_cuenta").ToString), _
        '                    row.Item("debe").ToString, _
        '                    row.Item("haber").ToString)

        '    Next
        '    dgvLista.DataSource = dtItem
        'End If

        realizarSumasTotales()
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub frmNuevaNotaCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipoDocumento()
        cargarMotivos()
        If codComprobante > 0 Then
            cargarRegistroCuentas(codComprobante)
        End If
    End Sub
    Private Sub btnRuc_Click(sender As Object, e As EventArgs)
        frmConsultaSunat.formInicio = "notacredito"
        frmConsultaSunat.ShowDialog()
    End Sub
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim sumaDebe As Decimal = 0
        sumaDebe = txtTotalNota.Text.Trim
        Dim mMonto, mIgv, mTotal As Decimal
        Dim dataIgv As New DataTable
        dataIgv = obj.nCrudListarBD("select * from igv", CadenaConexion)
        mMonto =  sumaDebe / (1 + (dataIgv.Rows(0)("valor").ToString) / 100)
        mTotal = sumaDebe
        mIgv = mTotal - mMonto

        'MsgBox("Monto: " & mMonto & " - IGV: " & mIgv & " - Total: " & mTotal)
        Dim entiNCD As New ComprobanteNotaCreditoDebito
        With entiNCD
            .tipo = "COMPRA"
            .numero_cuo = "0"
            .serie = txtSerieN.Text.Trim
            .numero = txtNumeroN.Text.Trim
            .fec_emision = dtFechaEmision.Value
            .serie_ref = txtSerie.Text.Trim
            .numero_ref = txtNumero.Text.Trim
            .num_dni = txtRuc.Text.Trim
            .razon_social = txtRazon.Text.Trim
            .glosa = txtGlosa.Text.Trim
            .monto = mMonto
            .valor_igv = mIgv
            .total = mTotal
            .motivo = cboMotivo.Text
            .comentario = txtComentarios.Text.Trim
            .estado = 1
        End With
        objNCD.registrarNotaCreditoBD(entiNCD, CadenaConexion)

        Dim entiCCompra As New ComprobanteCompraEntity
        With entiCCompra
            .tipo_compra = "CONTADO"
            .marca = "SIN AFECTO@I"
            .centro = "0"
            .estado_comprobante = "F"
            .id_tipo_comprobante = "8"
            .fec_emision = dtFechaEmision.Value
            .fec_pago = dtFechaEmision.Value
            .serie_comprobante = txtSerieN.Text
            .numero_comprobante = txtNumeroN.Text
            .cod_dni = "6"
            .num_dni = txtRuc.Text.Trim
            .razon_social = txtRazon.Text.Trim
            .valor_facturado = "-" & mMonto
            .glosa = txtGlosa.Text
            .id_moneda = "115"
            .valor_igv = "-" & mIgv
            .total = "-" & mTotal
            .tipo_cambio = "1.00"
            .detraccion = 1
            .fec_comp_origen = dtFecha.Value
            .tip_comp_origen = cboTipoDocumento.SelectedValue.ToString
            .serie_comp_origen = txtSerie.Text.Trim
            .numero_comp_origen = txtNumero.Text.Trim
            .estado = 1
            .id_usuario = CodigoUsuarioSession
        End With
        MsgBox("REGISTRANDO COMPROBANTE DE COMPRA: " & objCC.nRegistrarComprobanteCompraBD(entiCCompra, CadenaConexion))

        Dim idNC As String
        idNC = objNCD.obtenerIdNotaCreditoBD(CadenaConexion)

        For Each row As DataGridViewRow In dgvLista.Rows
            With entiNCD
                .id_nota_credito = idNC
                .glosa = txtComentarios.Text.Trim
                .cuenta = row.Cells("num_cuenta").Value
                .debe = row.Cells("debe").Value
                .haber = row.Cells("haber").Value
            End With
            MsgBox(objNCD.registrarAsientoNotaCreditoBD(entiNCD, CadenaConexion))
        Next
        MsgBox("LA NOTA DE CREDITO PARA COMPRA HA SIDO GUARDADA CON ÉXITO")
    End Sub
    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        'Dim dataIgv As New DataTable
        'dataIgv = obj.nCrudListar("select * from igv")
        'Dim monto As Decimal = 0
        'monto = IIf((txtMonto.Text.Trim.Length > 0), txtMonto.Text, 0)

        'Dim totalConIgv As Decimal
        'totalConIgv = Format(monto * (1 + (dataIgv.Rows(0)("valor").ToString) / 100), "#,##0.00")
        'txtIgv.Text = Format(monto * ((dataIgv.Rows(0)("valor").ToString) / 100), "#,##0.00")
        'txtTotal.Text = totalConIgv
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAgregarCuentaNotas.formIni = "notacreditocompra"
        frmAgregarCuentaNotas.Show()
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs)
        cargarRegistroCuentas(codigoComprobante)
        'MsgBox(codComprobante)
        Dim dtItem As New DataTable
        With dtItem.Columns
            .Add("id")
            .Add("id_asiento_compra")
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
        End With
        dgvLista.DataSource = dtItem

        'If dgvLista.RowCount = 0 Then
        '    Dim data As New DataTable
        '    data = obj.nCrudListar("usp_cuentaComprobanteCompra '" & codComprobante & "','42'")
        '    Dim dataParam As New DataTable
        '    dataParam = obj.nCrudListar("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','42'")

        '    dtItem.Rows.Add(data.Rows(0)("id").ToString, data.Rows(0)("id_comprobante_compra").ToString, _
        '                    dataParam.Rows(0)("num_cuenta").ToString, _
        '                    dataParam.Rows(0)("desc_cuenta").ToString, _
        '                    "0.00", _
        '                    txtTotal.Text.Trim)
        '    dgvLista.DataSource = dtItem
        'End If

        'Dim dataParam1 As New DataTable
        'dataParam1 = obj.nCrudListar("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','40'")
        'Dim data2 As New DataTable
        'data2 = obj.nCrudListar("usp_cuentaComprobanteCompra '" & codComprobante & "','40'")
        'Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        'Dim row As DataRow = dt.NewRow()
        'row.Item(0) = data2.Rows(0)("id").ToString
        'row.Item(1) = data2.Rows(0)("id_comprobante_compra").ToString
        'row.Item(2) = dataParam1.Rows(0)("num_cuenta").ToString
        'row.Item(3) = dataParam1.Rows(0)("desc_cuenta").ToString
        'row.Item(4) = txtIgv.Text.Trim
        'row.Item(5) = "0.00"
        'dt.Rows.Add(row)

        'Dim dataParam2 As New DataTable
        'dataParam2 = obj.nCrudListar("usp_parametrosNotaCreditoDebito '" & tipoOperacion & "','60'")
        'Dim data3 As New DataTable
        'data3 = obj.nCrudListar("usp_cuentaComprobanteCompra '" & codComprobante & "','60'")
        'Dim dt2 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        'Dim row2 As DataRow = dt2.NewRow()
        'row2.Item(0) = data3.Rows(0)("id").ToString
        'row2.Item(1) = data3.Rows(0)("id_comprobante_compra").ToString
        'row2.Item(2) = dataParam2.Rows(0)("num_cuenta").ToString
        'row2.Item(3) = dataParam2.Rows(0)("desc_cuenta").ToString
        'row2.Item(4) = txtMonto.Text.Trim
        'row2.Item(5) = "0.00"
        'dt2.Rows.Add(row2)

        'Dim data4 As New DataTable
        'data4 = obj.nCrudListar("usp_cuentaComprobanteCompra '" & codComprobante & "','61'")
        'Dim dt3 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        'Dim row3 As DataRow = dt3.NewRow()
        'row3.Item(0) = data4.Rows(0)("id").ToString
        'row3.Item(1) = data4.Rows(0)("id_comprobante_compra").ToString
        'row3.Item(2) = data4.Rows(0)("num_cuenta").ToString
        'row3.Item(3) = data4.Rows(0)("desc_cuenta").ToString
        'row3.Item(4) = data4.Rows(0)("debe").ToString
        'row3.Item(5) = data4.Rows(0)("haber").ToString
        'dt3.Rows.Add(row3)

        'Dim data5 As New DataTable
        'data5 = obj.nCrudListar("usp_cuentaComprobanteCompra '" & codComprobante & "','20'")
        'Dim dt4 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
        'Dim row4 As DataRow = dt4.NewRow()
        'row4.Item(0) = data5.Rows(0)("id").ToString
        'row4.Item(1) = data5.Rows(0)("id_comprobante_compra").ToString
        'row4.Item(2) = data5.Rows(0)("num_cuenta").ToString
        'row4.Item(3) = data5.Rows(0)("desc_cuenta").ToString
        'row4.Item(4) = data5.Rows(0)("debe").ToString
        'row4.Item(5) = data5.Rows(0)("haber").ToString
        'dt4.Rows.Add(row4)
        'realizarSumasTotales()
    End Sub
    Public Sub agregarCuenta(numcuenta, desccuenta, debe, haber)
        If dgvLista.Rows.Count = 0 Then
            Dim dtItem As New DataTable
            With dtItem.Columns
                .Add("id")
                .Add("id_asiento_compra")
                .Add("num_cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
            End With
            dtItem.Rows.Add("0", codComprobante, numcuenta, desccuenta, haber, debe)
            dgvLista.DataSource = dtItem
        Else
            Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
            Dim row As DataRow = dt.NewRow()
            row.Item(0) = "0"
            row.Item(1) = codComprobante
            row.Item(2) = numcuenta
            row.Item(3) = desccuenta
            row.Item(4) = haber
            row.Item(5) = debe
            dt.Rows.Add(row)
        End If
        seleccionarCuentaAdicionada(numcuenta)
        realizarSumasTotales()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmTsCuentasTipoOperacion.Show()
    End Sub
    Private Sub btnBuscarComprobante_Click(sender As Object, e As EventArgs) Handles btnBuscarComprobante.Click
        cargarComprobante()
    End Sub
    Private Sub cargarComprobante()
        Dim numero As String = txtNumero.Text.Trim
        Dim serie As String = txtSerie.Text.Trim
        Dim data As New DataTable
        data = objNCD.comprobanteCompraPorSerieNumeroBD(serie, numero, CadenaConexion)
        'MsgBox(data.Rows(0)("num_dni").ToString)
        If data.Rows.Count > 0 Then
            With data
                cboTipoDocumento.SelectedValue = .Rows(0)("id_tipo_comprobante").ToString
                dtFecha.Value = .Rows(0)("fec_emision").ToString
                txtRuc.Text = .Rows(0)("num_dni").ToString
                txtRazon.Text = .Rows(0)("razon_social").ToString
                txtMonto.Text = .Rows(0)("valor_facturado").ToString
                txtIgv.Text = .Rows(0)("valor_igv").ToString
                txtTotal.Text = .Rows(0)("total").ToString
                codComprobante = .Rows(0)("id").ToString
                codigoComprobante = .Rows(0)("id").ToString
            End With
            cargarRegistroCuentas(codComprobante)
            'realizarSumasTotales()
        Else
            MsgBox("No se han encontrado resultados con el comprobante de compra ingresado...")
        End If

    End Sub
    Private Sub realizarSumasTotales()
        'MsgBox("suma total")
        Dim tDebe, tHaber, tDiferencia As Decimal
        For Each row As DataGridViewRow In dgvLista.Rows
            tDebe += row.Cells("debe").Value
            tHaber += row.Cells("haber").Value
        Next
        tDiferencia = tDebe - tHaber

        txtTDebeS.Text = Format(tDebe, "#,##0.00")
        txtTHaberS.Text = Format(tHaber, "#,##0.00")
        txtDiferenciaS.Text = Format(tDiferencia, "#,##0.00")
    End Sub
    Private Sub seleccionarCuentaAdicionada(numcuenta)
        For i As Integer = 0 To dgvLista.Rows.Count - 1
            For x As Integer = 0 To dgvLista.ColumnCount - 1
                If dgvLista.Rows(i).Cells("num_cuenta").Value.ToString = numcuenta Then
                    'dgvDetalle.MultiSelect = False
                    'dgvDetalle.Rows(i).Selected = True
                    'dgvDetalle.Rows(i).Cells("cantidad").Select = True

                    dgvLista.CurrentCell = dgvLista.Rows(i).Cells("num_cuenta")
                    'dgvDetalle.CurrentCell = dgvDetalle.Item("cantidad", i)
                    'dgvDetalle.SelectionMode = DataGridViewSelectionMode.CellSelect
                End If
            Next
        Next
    End Sub
End Class