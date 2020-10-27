Imports Negocio

Public Class frmListaComodin
    Dim objCrud As New nCrud
    Dim iCarga As Integer = 0
    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("id_c").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function
    Public Sub cargarComodines()
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select * from vista_cabeceraComodin order by fec_reg asc", CadenaConexion)
        dgvLista.DataSource = data
    End Sub

    Private Sub frmListaPlanillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLista.RowTemplate.Height = 30
        cebrasDatagrid(dgvLista, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))
        dgvOperaciones.RowTemplate.Height = 30
        cebrasDatagrid(dgvOperaciones, Drawing.Color.White, Drawing.Color.FromArgb(227, 242, 247))

        cargarComodines()
        iCarga = 1
        If iCarga = 1 Then
            cargarDetalleComodin()
        End If
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        On Error Resume Next
        cargarDetalleComodin()
    End Sub

    Private Sub cargarDetalleComodin()
        If dgvLista.RowCount > 0 Then
            Dim sql As String
            sql = "select * from asientos_comodin where id_comodin='" & codigoCeldaSeleccionada() & "' order by id asc"
            Dim data As New DataTable
            data = objCrud.nCrudListarBD(sql, CadenaConexion)
            dgvOperaciones.DataSource = data

            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            If dgvLista.Rows(f).Cells("tipo").Value.ToString.StartsWith("GRAB") Then
                btnModificar.Enabled = True
            Else
                btnModificar.Enabled = False
            End If
            realizarSumasTotales()
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        frmIngresosGenericos.ShowDialog()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        cargarComodines()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim f As Integer
        f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
        'MsgBox(dgvLista.Rows(f).Cells("id").Value.ToString)
        If dgvLista.Rows(f).Cells("tipo").Value.ToString.StartsWith("GRA") Then
            frmModificarIngresosGenericos.idComodin = dgvLista.Rows(f).Cells("id_c").Value.ToString
            frmModificarIngresosGenericos.lblNumero.Text = "N° " & dgvLista.Rows(f).Cells("id_c").Value.ToString
            frmModificarIngresosGenericos.ShowDialog()
        End If
        
    End Sub

    Private Sub realizarSumasTotales()
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
End Class