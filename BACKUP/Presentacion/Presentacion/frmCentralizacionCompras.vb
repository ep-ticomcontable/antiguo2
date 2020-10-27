Imports Negocio
Imports Entidades
Public Class frmCentralizacionCompras

    Dim obj As New nCrud

    Private Sub cargarMeses()
        Dim dataMes As New DataTable
        dataMes.Columns.Add("codigo")
        dataMes.Columns.Add("descripcion")
        dataMes.Rows.Add(0, "SELECCIONE")
        Dim data3 As DataTable
        Try
            data3 = obj.nCrudListarBD("select month(fec_emision) as mes from comprobante_compra group by month(fec_emision) order by month(fec_emision)", CadenaConexion)
            For Each row As DataRow In data3.Rows
                Select Case row.Item("mes").ToString
                    Case "1"
                        dataMes.Rows.Add(row.Item("mes").ToString, "ENERO")
                    Case "2"
                        dataMes.Rows.Add(row.Item("mes").ToString, "FEBRERO")
                    Case "3"
                        dataMes.Rows.Add(row.Item("mes").ToString, "MARZO")
                    Case "4"
                        dataMes.Rows.Add(row.Item("mes").ToString, "ABRIL")
                    Case "5"
                        dataMes.Rows.Add(row.Item("mes").ToString, "MAYO")
                    Case "6"
                        dataMes.Rows.Add(row.Item("mes").ToString, "JUNIO")
                    Case "7"
                        dataMes.Rows.Add(row.Item("mes").ToString, "JULIO")
                    Case "8"
                        dataMes.Rows.Add(row.Item("mes").ToString, "AGOSTO")
                    Case "9"
                        dataMes.Rows.Add(row.Item("mes").ToString, "SEPTIEMBRE")
                    Case "10"
                        dataMes.Rows.Add(row.Item("mes").ToString, "OCTUBRE")
                    Case "11"
                        dataMes.Rows.Add(row.Item("mes").ToString, "NOVIEMBRE")
                    Case "12"
                        dataMes.Rows.Add(row.Item("mes").ToString, "DICIEMBRE")
                End Select
            Next
            With cboMes
                .DataSource = dataMes
                .ValueMember = "codigo"
                .DisplayMember = "descripcion"
            End With
            data3.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar los Meses")
        End Try
    End Sub

    Private Sub cargarAños()
        Dim dataAnio As New DataTable
        dataAnio.Columns.Add("codigo")
        dataAnio.Columns.Add("descripcion")
        dataAnio.Rows.Add(0, "SELECCIONE")
        Dim data2 As DataTable
        Try
            data2 = obj.nCrudListarBD("select year(fec_emision) as anio from comprobante_compra group by year(fec_emision)", CadenaConexion)
            For Each row As DataRow In data2.Rows
                dataAnio.Rows.Add(row.Item("anio").ToString, row.Item("anio").ToString)
            Next
            With cboAnio
                .DataSource = dataAnio
                .ValueMember = "codigo"
                .DisplayMember = "descripcion"
            End With
            data2.Dispose()
        Catch ex As Exception
            MsgBox("No se pudo cargar los Años")
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        cargarDatosListado()
    End Sub

    Private Sub cargarDatosListado()
        Dim grilla As New DataTable
        With grilla
            .Columns.Add("cuenta")
            .Columns.Add("desc_cuenta")
            .Columns.Add("debe")
            .Columns.Add("haber")
            .Columns.Add("descripcion")
        End With

        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from asientos_comprobante_compra where month(fec_emision)='" & cboMes.SelectedValue.ToString & "' and year(fec_emision)='" & cboAnio.SelectedValue.ToString & "' order by fec_emision asc", CadenaConexion)
        For Each row As DataRow In data.Rows
            With row
                grilla.Rows.Add(.Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString, .Item("glosa").ToString)
            End With
        Next
        dgvLista.DataSource = grilla

        Dim sd, sh As Decimal
        For Each row As DataGridViewRow In dgvLista.Rows
            sd += row.Cells("debe").Value
            sh += row.Cells("haber").Value
        Next
        txtDebe1.Text = Format(sd, "#,##0.00")
        txtHaber1.Text = Format(sh, "#,##0.00")
        txtDiferencia1.Text = Format((sd - sh), "#,##0.00")
    End Sub
    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = obj.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function
    Private Sub frmCentralizacionCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarMeses()
        cargarAños()
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        cargarCentralizacion()
    End Sub

    Private Sub cargarCentralizacion()
        If txtNumero.Text.Trim > 0 Then
            Dim grilla As New DataTable
            With grilla
                .Columns.Add("cuenta2")
                .Columns.Add("desc_cuenta2")
                .Columns.Add("debe2")
                .Columns.Add("haber2")
            End With

            Dim data As New DataTable
            data = obj.nCrudListarBD("[usp_vistaCentralizacion] '" & txtNumero.Text.Trim & "','" & cboMes.SelectedValue.ToString & "','" & cboAnio.SelectedValue.ToString & "'", CadenaConexion)
            For Each row As DataRow In data.Rows
                With row
                    grilla.Rows.Add(.Item("cuenta").ToString, obtenerDatosCuenta(.Item("cuenta").ToString), .Item("debe").ToString, .Item("haber").ToString)
                End With
            Next
            dgvCentralizacion.DataSource = grilla

            Dim sd, sh As Decimal
            For Each row As DataGridViewRow In dgvCentralizacion.Rows
                sd += row.Cells("debe2").Value
                sh += row.Cells("haber2").Value
            Next
            txtDebe2.Text = Format(sd, "#,##0.00")
            txtHaber2.Text = Format(sh, "#,##0.00")
            txtDiferencia2.Text = Format((sd - sh), "#,##0.00")
        Else
            MsgBox("Ingrese el número de dígitos")
            txtNumero.Focus()
        End If
        
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Dim data As New DataTable
        'data = obj.nCrudListarBD("select * from cierre_procesos where proceso='COMPRA' and anio='" & cboAnio.SelectedValue & "' and mes='" & cboMes.SelectedValue & "'", CadenaConexion)
        Dim objAC As New nAsientoCierre
        Dim data As New DataTable
        Dim objAD As New nAsientoLibroDiario
        Dim entiLD As New ALDiarioEntity

        data = obj.nCrudListarBD("SELECT * FROM vista_compras_con_abonos where estado_comprobante='P' and month(fec_emision)='" & cboMes.SelectedValue.ToString & "' and year(fec_emision)='" & cboAnio.SelectedValue.ToString & "' ", CadenaConexion)
        If data.Rows.Count > 0 Then
            MessageBox.Show("Se han encontrado (" & data.Rows.Count & ") compra(s) 'PENDIENTE(S)' por finalizar. " & vbCrLf & "Para poder realizar el Asiento de Centralización ó Cierre, se deben finalizar todas las compras con estado de PENDIENTE.", "Centralización - Cierre del Mes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Else
            With entiLD
                .id_comprobante = "CIERRE" & cboMes.SelectedValue.ToString & cboAnio.SelectedValue.ToString
                .cuo = "0"
                .fecha_operacion = dtFecha.Value.ToString("yyyy-MM-dd")
                .glosa = txtComentarios.Text.Trim
                .denominacion = txtComentarios.Text.Trim
                .numero_correlativo = "-"
                .numero_documento = "-"
            End With
            For Each row As DataGridViewRow In dgvCentralizacion.Rows
                With row
                    entiLD.cod_libro = .Cells("cuenta2").Value
                    entiLD.cuenta = .Cells("cuenta2").Value
                    entiLD.debe = .Cells("debe2").Value
                    entiLD.haber = .Cells("haber2").Value
                End With
                objAC.registrarCierreMensual(cboAnio.SelectedValue, cboMes.SelectedValue, "COMPRA", row.Cells("cuenta2").Value, txtComentarios.Text.Trim, row.Cells("debe2").Value, row.Cells("haber2").Value, CadenaConexion)
                objAD.registrarAsientoLibroDiarioBD(entiLD, CadenaConexion)
            Next
            MsgBox("REGISTRO LIBRO DIARIO")
        End If
    End Sub
End Class