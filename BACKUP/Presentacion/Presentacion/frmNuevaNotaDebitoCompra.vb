Imports Negocio
Imports Entidades

Public Class frmNuevaNotaDebitoCompra

    Dim obj As New nCrud
    Dim objTDA As New nTipoDocumentoAsiento
    Public codComprobante As Integer = 0
    Public codTipoComprobante As Integer = 0
    Dim objNCD As New nNotaCreditoDebito
    Dim tipoOperacion As Integer = 4 'CONSIGNACIONES

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

    Private Sub frmNuevaNotaDebitoCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipoDocumento()
        cargarMotivos()
        If codComprobante > 0 Then
            cargarRegistroCuentas(codComprobante)
        End If
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
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmTsCuentasTipoOperacion.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAgregarCuentaNotas.formIni = "notadebitocompra"
        frmAgregarCuentaNotas.Show()
    End Sub

    Public Sub agregarCuenta(numcuenta, desccuenta, debe, haber)
        If dgvLista.RowCount = 0 Then
            Dim dtItem As New DataTable
            With dtItem.Columns
                .Add("id")
                .Add("id_asiento_compra")
                .Add("num_cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
            End With
            dtItem.Rows.Add("0", codComprobante, _
                            numcuenta, _
                            desccuenta, _
                            debe, _
                            haber)
            dgvLista.DataSource = dtItem
            seleccionarCuentaAdicionada(numcuenta)
        Else
            Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
            Dim row As DataRow = dt.NewRow()
            row.Item(0) = "0"
            row.Item(1) = codComprobante
            row.Item(2) = numcuenta
            row.Item(3) = desccuenta
            row.Item(4) = debe
            row.Item(5) = haber
            dt.Rows.Add(row)
            seleccionarCuentaAdicionada(numcuenta)
        End If
        realizarSumasTotales()
    End Sub
    Private Sub seleccionarCuentaAdicionada(numcuenta)
        For i As Integer = 0 To dgvLista.Rows.Count - 1
            For x As Integer = 0 To dgvLista.ColumnCount - 1
                If dgvLista.Rows(i).Cells("num_cuenta").Value.ToString = numcuenta Then
                    dgvLista.CurrentCell = dgvLista.Rows(i).Cells("num_cuenta")
                End If
            Next
        Next
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim sumaDebe As Decimal = 0
        sumaDebe = txtTotalNota.Text.Trim
        Dim mMonto, mIgv, mTotal As Decimal
        Dim dataIgv As New DataTable
        dataIgv = obj.nCrudListarBD("select * from igv", CadenaConexion)
        mMonto = sumaDebe / (1 + (dataIgv.Rows(0)("valor").ToString) / 100)
        mTotal = sumaDebe
        mIgv = mTotal - mMonto

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
        'MsgBox(objNCD.registrarNotaDebitoBD(entiNCD, CadenaConexion))
        objNCD.registrarNotaDebitoBD(entiNCD, CadenaConexion)

        Dim objCC As New nComprobanteCompra
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
            .valor_facturado = mMonto
            .glosa = txtGlosa.Text
            .id_moneda = "115"
            .valor_igv = mIgv
            .total = mTotal
            .tipo_cambio = "1.00"
            .detraccion = 1
            .fec_comp_origen = dtFecha.Value
            .tip_comp_origen = cboTipoDocumento.SelectedValue.ToString
            .serie_comp_origen = txtSerie.Text.Trim
            .numero_comp_origen = txtNumero.Text.Trim
            .estado = 1
            .id_usuario = CodigoUsuarioSession
        End With
        'MsgBox("REGISTRANDO COMPROBANTE DE COMPRA: " & objCC.nRegistrarComprobanteCompraBD(entiCCompra, CadenaConexion))
        objCC.nRegistrarComprobanteCompraBD(entiCCompra, CadenaConexion)

        Dim idNC As String
        idNC = objNCD.obtenerIdNotaDebitoBD(CadenaConexion)

        For Each row As DataGridViewRow In dgvLista.Rows
            With entiNCD
                .id_nota_credito = idNC
                .glosa = txtComentarios.Text.Trim
                .cuenta = row.Cells("num_cuenta").Value
                .debe = row.Cells("debe").Value
                .haber = row.Cells("haber").Value
            End With
            'MsgBox(objNCD.registrarAsientoNotaDebitoBD(entiNCD, CadenaConexion))
            objNCD.registrarAsientoNotaDebitoBD(entiNCD, CadenaConexion)
        Next
        MsgBox("LA NOTA DE DEBITO PARA COMPRA HA SIDO GUARDADA CON ÉXITO")
    End Sub
    Private Sub realizarSumasTotales()
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

    Private Sub btnBuscarComprobante_Click(sender As Object, e As EventArgs) Handles btnBuscarComprobante.Click
        cargarComprobante()
    End Sub

    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged
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
            End With
        Else
            MsgBox("No se han encontrado resultados con el comprobante de compra ingresado...")
        End If

    End Sub

End Class