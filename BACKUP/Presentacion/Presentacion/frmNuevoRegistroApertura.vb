Imports Negocio
Imports Entidades

Public Class frmNuevoRegistroApertura
    Dim objCrud As New nCrud
    Dim iCarga As Integer = 0
    Dim dataAsientos As New DataTable
    Public idAsiento As String

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
        iCarga = 1
        realizarSumasTotales()
    End Sub
    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        agregarCuentaContable()
    End Sub
    Private Sub dgvProductos_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOperaciones.CellValueChanged
        On Error Resume Next
        If iCarga = 1 Then
            realizarSumasTotales()
        End If
    End Sub
    Private Sub agregarCuentaContable()
        frmAgregarCuentasNuevo.formIni = "apertura"
        frmAgregarCuentasNuevo.ShowDialog()
    End Sub
    Public Sub adicionarCuentas(cuenta As String, monto As Decimal, orden As String, glosa As String)
        Dim dtData As New DataTable
        With dtData.Columns
            .Add("num_cuenta")
            .Add("desc_cuenta")
            .Add("debe")
            .Add("haber")
            .Add("glosa")
        End With
        If dgvOperaciones.RowCount = 0 Then
            If orden = "D" Then
                dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), monto, "0.00", glosa)
            End If
            If orden = "H" Then
                dtData.Rows.Add(cuenta, obtenerDatosCuenta(cuenta), "0.00", monto, glosa)
            End If
        Else
            Dim dtI As DataTable = DirectCast(dgvOperaciones.DataSource, DataTable)
            Dim row As DataRow = dtI.NewRow()
            row.Item(0) = cuenta
            row.Item(1) = obtenerDatosCuenta(cuenta)
            row.Item(2) = IIf(orden = "D", monto, "0.00")
            row.Item(3) = IIf(orden = "H", monto, "0.00")
            row.Item(4) = glosa
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
    Private Sub frmNuevaCompraP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'If e.KeyCode = Keys.Insert Then
        '    If txtRuc.Focused = True Or txtRazonSocial.Focused = True Then
        '        buscarProveedor()
        '    Else
        '        agregarCuentaContable()
        '    End If
        'ElseIf e.KeyCode = Keys.End Then
        '    procesarBoton()
        'End If
    End Sub
    Private Sub txtGlosa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGlosa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'txtCuenta.Focus()
        End If
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Me.Enabled = False
        Dim obj As New nAsientoApertura
        idAsiento = obj.nObtenerNumeroDeAsientoAperturaBD(CadenaConexion)
        Dim entiAA As New AAperturaEntity
        With entiAA
            .id = idAsiento
            .id_asiento = 1
            .glosa = txtGlosa.Text.Trim
            .numero = 1
            .total_debe_s = txtTDebeS.Text.Trim
            .total_haber_s = txtTHaberS.Text.Trim
            .diferencia_s = txtDiferenciaS.Text.Trim
            .total_debe_d = "0.00"
            .total_haber_d = "0.00"
            .diferencia_d = "0.00"
            .periodo = AnioEjercicio
            .fecha = dtFechaEmision.Value
            .id_empresa = CodigoEmpresaSession
            .id_usuario = CodigoUsuarioSession
            .estado = 1
        End With

        'MsgBox("Asiento de Apertura registrado: " & vbCrLf & obj.nRegistrarAsientoAperturaBD(entiAA, CadenaConexion))
        obj.nRegistrarAsientoAperturaBD(entiAA, CadenaConexion)
        Dim entiDAA As New DetalleAAperturaEntity
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            With entiDAA
                .id_asiento_apertura = idAsiento
                .cuenta = row.Cells("num_cuenta").Value.ToString
                .debe = row.Cells("debe").Value.ToString
                .haber = row.Cells("haber").Value.ToString
                .id_moneda = "115"
                .tipo_cambio = "1.00"
                .glosa = row.Cells("glosa").Value.ToString
                .id_doc_cont = "1"
                .num_doc = "-"
                .fec_emision = dtFechaEmision.Value
            End With
            'MsgBox("Detalle de Asiento de Apertura agregado: " & vbCrLf & obj.nRegistrarDetalleAsientoAperturaBD(entiDAA, CadenaConexion))
            obj.nRegistrarDetalleAsientoAperturaBD(entiDAA, CadenaConexion)
        Next
        MsgBox("¡Asiento de Apertura FINALIZADO correctamente!")
        Me.Enabled = True
        frmListaAperturas.cabeceraApertura()
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Me.Enabled = False
        Dim obj As New nAsientoApertura
        idAsiento = obj.nObtenerNumeroDeAsientoAperturaBD(CadenaConexion)
        Dim entiAA As New AAperturaEntity
        With entiAA
            .id = idAsiento
            .id_asiento = 1
            .glosa = txtGlosa.Text.Trim
            .numero = idAsiento
            .total_debe_s = txtTDebeS.Text.Trim
            .total_haber_s = txtTHaberS.Text.Trim
            .diferencia_s = txtDiferenciaS.Text.Trim
            .total_debe_d = "0.00"
            .total_haber_d = "0.00"
            .diferencia_d = "0.00"
            .periodo = AnioEjercicio
            .fecha = dtFechaEmision.Value
            .id_empresa = CodigoEmpresaSession
            .id_usuario = CodigoUsuarioSession
            .estado = 0
        End With

        'MsgBox("Asiento de Apertura registrado: " & vbCrLf & obj.nRegistrarAsientoAperturaBD(entiAA, CadenaConexion))
        obj.nRegistrarAsientoAperturaBD(entiAA, CadenaConexion)
        Dim entiDAA As New DetalleAAperturaEntity
        For Each row As DataGridViewRow In dgvOperaciones.Rows
            With entiDAA
                .id_asiento_apertura = idAsiento
                .cuenta = row.Cells("num_cuenta").Value.ToString
                .debe = row.Cells("debe").Value.ToString
                .haber = row.Cells("haber").Value.ToString
                .id_moneda = "115"
                .tipo_cambio = "1.00"
                .glosa = row.Cells("glosa").Value.ToString
                .id_doc_cont = "0"
                .num_doc = "-"
                .fec_emision = dtFechaEmision.Value
            End With
            'MsgBox("Detalle de Asiento de Apertura agregado: " & vbCrLf & obj.nRegistrarDetalleAsientoAperturaBD(entiDAA, CadenaConexion))
            obj.nRegistrarDetalleAsientoAperturaBD(entiDAA, CadenaConexion)
        Next
        MsgBox("¡Asiento de Apertura GUARDADO correctamente!")
        Me.Enabled = True
        frmListaAperturas.cabeceraApertura()
        Me.Dispose()
    End Sub
End Class