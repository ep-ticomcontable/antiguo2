Imports Negocio
Imports Entidades

Public Class frmParametrosCentroCosto

    Dim objCrud As New nCrud
    Dim obj As New nCentroCostos
    Dim iCarga As Integer = 0
    Public idCentro As String = ""
    Public tipo As String = ""

    Private Sub cargarIdCentro()
        Dim data As New DataTable
        data = objCrud.nCrudListarBD("select MAX(id)+1 as 'id' from centro_costos", CadenaConexion)
        txtCodigo.Text = data.Rows(0)("id").ToString
    End Sub

    Private Sub frmCrearCentroCosto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarIdCentro()
        txtDescripcion.Select()
        txtDescripcion.Focus()
        iCarga = 1
    End Sub

    Private Sub txtDebe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDebe.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtDebe.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmCentroCosto"
                    .input = "debe"
                    .cuentaInicio = (txtDebe.Text.Trim)
                    .ShowDialog()
                End With
            End If
        End If
        If Asc(e.KeyChar) = 13 Then
            txtHaber.Focus()
        End If
    End Sub

    Private Sub txtHaber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHaber.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If txtHaber.Text.Trim.Length >= 2 Then
                With frmEscogerPlanContable
                    .formInicio = "frmCentroCosto"
                    .input = "haber"
                    .cuentaInicio = (txtHaber.Text.Trim)
                    .ShowDialog()
                End With
            End If
        End If
        If Asc(e.KeyChar) = 13 Then
            txtPorcentaje.Focus()
        End If
    End Sub

    Private Function obtenerDatosCuenta(cuenta As String) As String
        Dim dt As New DataTable
        dt = objCrud.nCrudListarBD("select * from cuenta_contable where id='" & cuenta & "'", CadenaConexion)
        Return dt.Rows(0)("nombre").ToString
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtDebe.Text.Trim.Length > 0 And txtDebe.Text.Trim.Length > 0 And Decimal.Parse(txtPorcentaje.Text.Trim) > 0 Then
            Dim data As New DataTable
            With data.Columns
                .Add("cuenta")
                .Add("desc_cuenta")
                .Add("debe")
                .Add("haber")
                .Add("porcentaje")
            End With

            If dgvLista.RowCount = 0 Then
                data.Rows.Add(txtDebe.Text.Trim, obtenerDatosCuenta(txtDebe.Text.Trim), "X", "", Decimal.Parse(txtPorcentaje.Text.Trim))
                data.Rows.Add(txtHaber.Text.Trim, obtenerDatosCuenta(txtHaber.Text.Trim), "", "X", Decimal.Parse(txtPorcentaje.Text.Trim))
                dgvLista.DataSource = data
            Else
                Dim dt As DataTable = DirectCast(dgvLista.DataSource, DataTable)
                Dim row As DataRow = dt.NewRow()
                row.Item(0) = txtDebe.Text.Trim
                row.Item(1) = obtenerDatosCuenta(txtDebe.Text.Trim)
                row.Item(2) = "X"
                row.Item(3) = ""
                row.Item(4) = Decimal.Parse(txtPorcentaje.Text.Trim)
                dt.Rows.Add(row)
                Dim dt2 As DataTable = DirectCast(dgvLista.DataSource, DataTable)
                Dim row2 As DataRow = dt2.NewRow()
                row2.Item(0) = txtHaber.Text.Trim
                row2.Item(1) = obtenerDatosCuenta(txtHaber.Text.Trim)
                row2.Item(2) = ""
                row2.Item(3) = "X"
                row2.Item(4) = Decimal.Parse(txtPorcentaje.Text.Trim)
                dt2.Rows.Add(row2)
            End If
            txtDebe.Text = ""
            lblDebe.Text = "[Nombre Cuenta]"
            txtHaber.Text = ""
            lblHaber.Text = "[Nombre Cuenta]"
            txtPorcentaje.Text = "0.00"
            txtDebe.Focus()
        Else
            MsgBox("Ingrese parametros para agregar la cuenta")
        End If
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If txtDescripcion.Text.Trim.Length > 2 Then
            Dim rpta As String
            Dim subCentro As Integer
            subCentro = 1
            rpta = obj.registrarCentroCostoBD("1", txtDescripcion.Text.Trim, "1", subCentro, "1", CadenaConexion)
            If rpta = "ok" Then
                Dim rpta1 As String
                For Each row As DataGridViewRow In dgvLista.Rows
                    rpta1 = obj.registrarParametroCentroCostoBD(txtCodigo.Text.Trim, row.Cells("desc_cuenta").Value.ToString, row.Cells("porcentaje").Value.ToString, row.Cells("cuenta").Value.ToString, row.Cells("debe").Value.ToString, row.Cells("haber").Value.ToString, "1", CadenaConexion)
                Next                
            Else
                MessageBox.Show("Error al registrar: " & vbCrLf & rpta, "Centro de Costo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            frmListaCentroCostos.cargarDataCentroCostos()
            'resetear entradas
            cargarIdCentro()
            txtDescripcion.Text = ""
            Me.Dispose()
        ElseIf txtDescripcion.Text.Trim.Length = "0" Then
            MessageBox.Show("Ingrese una descripción", "Centro de Costo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txtDescripcion.Focus()
        End If

        MessageBox.Show("Parámetros registrados con éxito", "Parámetros del Centro de Costo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDebe.Focus()
        End If
    End Sub
    Private Sub txtPorcentaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcentaje.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAgregar.PerformClick()
        End If
    End Sub

End Class