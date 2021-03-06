﻿Imports Negocio

Public Class frmListaComprobanteVentas_ant
    Dim obj As New nCrud
    Dim iCarga As Integer = 0

    Private Sub cargarTipo()
        Dim data As New DataTable
        data.Columns.Add("Codigo")
        data.Columns.Add("Descripcion")
        data.Rows.Add(1, "DNI/RUC")
        data.Rows.Add(2, "RAZON SOCIAL")
        With cboTipo
            .DataSource = data
            .ValueMember = "Codigo"
            .DisplayMember = "Descripcion"
        End With
    End Sub

    Private Sub cargarComprobantes()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from comprobante_venta where estado=1 order by fec_emision asc", CadenaConexion)
        dgvLista.DataSource = data
    End Sub

    Private Sub frmListaComprobanteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipo()
        dtDesde.Value = DateTime.Today.AddMonths("-3")
        cargarComprobantes()
        iCarga = 1
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        realizarConsulta()
    End Sub
    Private Sub realizarConsulta()
        If txtDato.Text.Trim.Length > 0 Then
            Dim data As New DataTable
            Dim query As String
            If cboTipo.SelectedValue = 1 Then
                query = "select * from comprobante_venta where estado=1 and num_dni like '%" & txtDato.Text.Trim & "%' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' order by fec_emision asc"
            Else
                query = "select * from comprobante_venta where estado=1 and razon_social like '%" & txtDato.Text.Trim & "%' DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))>='" & dtDesde.Value().ToString("yyyy-MM-dd") & "' and DATEADD(dd, 0, DATEDIFF(dd, 0, fec_emision))<='" & dtHasta.Value().ToString("yyyy-MM-dd") & "' order by fec_emision asc"
            End If
            'MsgBox(query)
            data = obj.nCrudListarBD(query, CadenaConexion)
            dgvLista.DataSource = data
        Else
            cargarComprobantes()
        End If
    End Sub

    Private Sub btnGenerarNota_Click(sender As Object, e As EventArgs) Handles btnGenerarNota.Click
        If iCarga = 1 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            Dim idComprobante As Integer = 0
            idComprobante = dgvLista.Rows(f).Cells(0).Value
            With frmNuevaNotaCreditoVenta
                .Text = "Nueva Nota de Crédito Venta - N° registro: " & idComprobante
                .codComprobante = idComprobante
                .codTipoComprobante = dgvLista.Rows(f).Cells("id_tipo_comprobante").Value
                .cargarDatosComprobante()
                .Show()
            End With
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If iCarga = 1 Then
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            Dim idComprobante As Integer = 0
            idComprobante = dgvLista.Rows(f).Cells(0).Value
            With frmNuevaNotaDebitoVenta
                .Text = "Nueva Nota de Débito Venta - N° registro: " & idComprobante
                .codComprobante = idComprobante
                .codTipoComprobante = dgvLista.Rows(f).Cells("id_tipo_comprobante").Value
                .cargarDatosComprobante()
                .Show()
            End With
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmNuevaVenta.Show()
    End Sub
End Class