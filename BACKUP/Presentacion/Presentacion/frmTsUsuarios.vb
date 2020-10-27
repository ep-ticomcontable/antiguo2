Imports Negocio

Public Class frmTsUsuarios
    Dim obj As New nCrud
    Dim ind_carga As Integer = 0
    Dim tipo As String = ""

    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvUsuarios.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvUsuarios.Rows(f).Cells("id").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

    Private Sub cargarTipoUsuario()
        Dim tbData As New DataTable
        tbData.Columns.Add("Codigo")
        tbData.Columns.Add("Nombre")
        tbData.Rows.Add(0, "Seleccione")
        Dim tbData2 As DataTable
        Try
            tbData2 = obj.nCrudListarBD("select id ,nombre from perfiles where estado=1 order by nombre asc", CadenaConexion)
            For Each row As DataRow In tbData2.Rows
                tbData.Rows.Add(row.Item(0).ToString, row.Item(1).ToString)
            Next
            With cboTipo
                .DataSource = tbData
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With
            tbData2.Dispose()
        Catch ex As Exception
            MsgBox("Error en la carga de Monedas")
            Exit Sub
        End Try
    End Sub

    Private Sub cargarUsuarios()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from vista_usuarios order by nombres asc", CadenaConexion)
        dgvUsuarios.DataSource = data
        data = Nothing
        cargaInicialEstados()
    End Sub

    Private Sub cargarEmpresas()
        Dim data As New DataTable
        data = obj.nCrudListarBD("select * from vista_empresas order by empresa asc", CadenaConexion)
        dgvEmpresas.DataSource = data

        For Each filaCol As DataGridViewRow In dgvEmpresas.Rows
            ' filaCol.Cells(0).Value = True
        Next

        data = Nothing
        cargaInicialEstados()

    End Sub

    Private Sub frmTsClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarTipoUsuario()
        cargarUsuarios()
        cargarEmpresas()
        ind_carga = 1
        cargarDatosUsuario()
        txtDato.Focus()
        txtDato.Select()
        bloquearEntradas()
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvUsuarios.SelectionChanged
        cargarDatosUsuario()
    End Sub

    Private Sub cargarDatosUsuario()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from usuarios where id=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = obj.nCrudListarBD(sql, CadenaConexion)
            With data
                txtUsuario.Text = .Rows(0)("usuario").ToString
                txtNombres.Text = .Rows(0)("nombres").ToString
                txtClave.Text = .Rows(0)("clave").ToString
                cboTipo.SelectedValue = .Rows(0)("tipo").ToString

                If .Rows(0)("estado") = "0" Then
                    rbNo.Checked = True
                ElseIf .Rows(0)("estado") = "1" Then
                    rbSi.Checked = True
                End If
            End With

            'cargar empresas asignadas a usuarios
            Dim dataEmp As New DataTable
            dataEmp = obj.nCrudListarBD("select * from usuarios_empresas where id_usuario='" & codigoCeldaSeleccionada() & "'", CadenaConexion)
            For Each filaCol As DataGridViewRow In dgvEmpresas.Rows
                filaCol.Cells(0).Value = False
            Next

            For Each fila As DataGridViewRow In dgvEmpresas.Rows
                For it As Integer = 0 To dataEmp.Rows.Count - 1
                    If fila.Cells(1).Value = dataEmp.Rows(it)(0) Then
                        fila.Cells(0).Value = True
                        'fila.Cells(0).ReadOnly = True
                    End If
                Next
            Next

            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "new" Then
            txtUsuario.Focus()
        End If
        cargaInicialEstados()
    End Sub

    Private Sub frmTsTipoPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            cargarUsuarios()
        End If
    End Sub

    Private Sub txtDato_TextChanged(sender As Object, e As EventArgs) Handles txtDato.TextChanged
        'If txtDato.Text.Length > 2 Then

        'End If
    End Sub

    Private Sub bloquearEntradas()
        txtNombres.Enabled = False
        txtUsuario.Enabled = False
        txtClave.Enabled = False
        cboTipo.Enabled = False
        rbNo.Enabled = False
        rbSi.Enabled = False
        dgvEmpresas.ReadOnly = True
    End Sub

    Private Sub habilitarEntradas()
        gbGrupo.Enabled = True
        txtNombres.Enabled = True
        txtUsuario.Enabled = True
        txtClave.Enabled = True
        cboTipo.Enabled = True
        rbNo.Enabled = True
        rbSi.Enabled = True
        dgvEmpresas.ReadOnly = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        gbGrupo.Enabled = True
        habilitarEntradas()
        tipo = "update"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        habilitarEntradas()
        tipo = "new"
        limpiarEntradas()
    End Sub

    Private Sub limpiarEntradas()
        txtUsuario.Text = ""
        txtNombres.Text = ""
        txtClave.Text = ""
        rbSi.Checked = True
        txtUsuario.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbGrupo.Enabled = False
        'cargarDatosCuenta()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim campos As String
        Dim valores As String
        Dim condicion As String
        Dim estado As String
        If rbNo.Checked = True Then
            estado = "0"
        Else
            estado = "1"
        End If

        campos = "usuario@nombres@clave@tipo@estado"
        valores = txtUsuario.Text.ToString & "@" & txtNombres.Text.ToString & "@" & txtClave.Text.ToString & "@" & cboTipo.SelectedValue.ToString & "@" & estado

        Dim rpta As String = ""
        Dim tabla As String = "usuarios"
        Dim tablaE As String = "usuarios_empresas"
        If tipo = "update" Then
            condicion = "id=" & codigoCeldaSeleccionada()
            rpta = obj.nCrudActualizarBD("@", tabla, campos, valores, condicion, CadenaConexion)

            'Eliminar las empresas asignadas al usuario para volver a cargar si hay modificaciones
            'MsgBox("ELIMINACION DE USUARIOS: " & codigoCeldaSeleccionada() & " - " & obj.nEjecutarQueryBD("delete from [TICOM-CONTABLE].dbo." & tablaE & " where id_usuario='" & codigoCeldaSeleccionada() & "'", CadenaConexion))
            obj.nEjecutarQueryBD("delete from [TICOM-CONTABLE].dbo." & tablaE & " where id_usuario='" & codigoCeldaSeleccionada() & "'", CadenaConexion)

            'Insertamos las empresas seleccionadas al usuario
            For Each filaCol As DataGridViewRow In dgvEmpresas.Rows
                If filaCol.Cells(0).Value = True Then
                    'MsgBox(filaCol.Cells(2).Value)
                    Dim rptaI As String
                    rptaI = obj.nCrudInsertarBD("@", "[TICOM-CONTABLE].dbo." & tablaE, "id_empresa@id_usuario", filaCol.Cells(1).Value & "@" & codigoCeldaSeleccionada(), CadenaConexion)
                    'MsgBox("ACTUALIZACION DE EMPRESAS USUARIOS: " & rptaI)
                End If
            Next

            For Each filaCol As DataGridViewRow In dgvEmpresas.Rows
                If filaCol.Cells(0).Value = False Then
                    Dim dataEmp As New DataTable
                    dataEmp = obj.nCrudListarBD("select * from  [TICOM-CONTABLE].dbo.empresas where id='" & filaCol.Cells(1).Value & "'", CadenaConexion)
                    obj.nEjecutarQueryBD("delete from [" & dataEmp.Rows(0)("alias").ToString & "].dbo.usuarios_empresas where id_usuario='" & codigoCeldaSeleccionada() & "' and id_empresa='" & filaCol.Cells(1).Value & "'", CadenaConexion)
                End If
            Next

            'AÑADIR EMPRESA-USUARIOS DE LA PLANTILLA A SUS RESPECTIVAS BD'S
            Dim dataUE As New DataTable
            dataUE = obj.nCrudListarBD("select * from [TICOM-CONTABLE].dbo.usuarios_empresas where id_usuario='" & codigoCeldaSeleccionada() & "' and id_empresa<>1", CadenaConexion)

            For Each row As DataRow In dataUE.Rows
                Dim dataEmp As New DataTable
                dataEmp = obj.nCrudListarBD("select * from  [TICOM-CONTABLE].dbo.empresas where id='" & row.Item("id_empresa").ToString & "'", CadenaConexion)
                'MsgBox(dataEmp.Rows(0)("alias").ToString)
                obj.nEjecutarQueryBD("delete from [" & dataEmp.Rows(0)("alias").ToString & "].dbo.usuarios_empresas where id_usuario='" & row.Item("id_usuario").ToString & "'", CadenaConexion)

                obj.nCrudInsertarBD("@", "[" & dataEmp.Rows(0)("alias").ToString & "].dbo.usuarios_empresas", "id_empresa@id_usuario", row.Item("id_empresa").ToString & "@" & row.Item("id_usuario").ToString, CadenaConexion)
            Next

        ElseIf tipo = "new" Then
            'rpta = obj.nCrudInsertarBD("@", tabla, campos, valores, CadenaConexion)
            Dim query1 As String
            query1 = "usp_registrarUsuario '" & txtUsuario.Text.ToString & "','" & txtNombres.Text.ToString & "','" & txtClave.Text.ToString & "','" & cboTipo.SelectedValue.ToString & "'"
            rpta = obj.nEjecutarQueryBD(query1, CadenaConexion)
            'MsgBox("REGISTRAR USUARIO: " & rpta)

            Dim dataU As New DataTable
            dataU = obj.nCrudListarBD("select * from usuarios where estado=1 order by id desc", CadenaConexion)

            'Eliminar las empresas asignadas al usuario para volver a cargar si hay modificaciones
            obj.nEjecutarQueryBD("delete from " & tablaE & " where id_usuario='" & dataU.Rows(0)("id").ToString & "' and id_empresa<>'1'", CadenaConexion)

            'Insertamos las empresas seleccionadas al usuario
            For Each filaCol As DataGridViewRow In dgvEmpresas.Rows
                If filaCol.Cells(0).Value = True Then
                    'MsgBox(filaCol.Cells(2).Value)
                    Dim rptaE As String
                    rptaE = obj.nCrudInsertarBD("@", tablaE, "id_empresa@id_usuario", filaCol.Cells(1).Value & "@" & dataU.Rows(0)("id").ToString, CadenaConexion)
                    If filaCol.Cells(1).Value > 1 Then
                        Dim dataEmp As New DataTable
                        dataEmp = obj.nCrudListarBD("select * from empresas where id='" & filaCol.Cells(1).Value & "'", CadenaConexion)

                        Dim dEmpresa As New DataTable
                        dEmpresa = obj.nCrudListarBD("select * from [" & dataEmp.Rows(0)("alias").ToString & "].[dbo].[empresas] where ruc='" & dataEmp.Rows(0)("ruc").ToString & "'", CadenaConexion)

                        'Dim queryLimpiar, queryInst As String
                        'queryLimpiar = "truncate table [TICOM].[dbo].[cuenta_contable]"
                        'queryInst = "insert into [" & dEmpresa.Rows(0)("alias") & "].[dbo].[cuenta_contable] select * from [" & dEmpresa.Rows(0)("alias").ToString & "].[dbo].[cuenta_contable]"

                        Dim query As String
                        query = "usp_registrarUsuario '" & txtUsuario.Text.ToString & "','" & txtNombres.Text.ToString & "','" & txtClave.Text.ToString & "','" & cboTipo.SelectedValue.ToString & "'"
                        obj.nEjecutarConsultaEnBD(dataEmp.Rows(0)("alias").ToString, query)
                        'MsgBox("REGISTRAR USUARIO: " & )

                        Dim queryElim As String
                        queryElim = "delete from usuarios_empresas where id_usuario='" & codigoCeldaSeleccionada() & "' and id_empresa<>'1'"
                        obj.nEjecutarConsultaEnBD(dataEmp.Rows(0)("alias").ToString, queryElim)
                        'MsgBox("ELIMINACION DE EMPRESAS POR USUARIO: " & obj.nEjecutarConsultaEnBD(dataEmp.Rows(0)("alias").ToString, queryElim))

                        Dim queryUpd As String
                        queryUpd = "insert usuarios_empresas (id_empresa,id_usuario) values ('" & filaCol.Cells(1).Value & "','" & codigoCeldaSeleccionada() & "')"
                        obj.nEjecutarConsultaEnBD(dataEmp.Rows(0)("alias").ToString, queryUpd)
                        'MsgBox("INSERCION DE EMPRESAS POR USUARIO: " & obj.nEjecutarConsultaEnBD(dataEmp.Rows(0)("alias").ToString, queryUpd))
                        'MsgBox(rptaE)
                    End If
                End If
            Next
        End If

        If rpta = "ok" Then
            MessageBox.Show("El proceso se ha realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            gbGrupo.Enabled = False
            limpiarEntradas()
            cargarUsuarios()
            cargarDatosUsuario()
            txtDato.Focus()
        Else
            MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub cargaInicialEstados()
        Try
            For Each row As DataGridViewRow In dgvUsuarios.Rows
                If row.Cells("estado").Value.ToString = "INACTIVO" Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 87, 87) '(245, 230, 108)
                ElseIf row.Cells("estado").Value.ToString = "ACTIVO" Then
                    row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(255, 255, 255)
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        realizarBusqueda()
    End Sub

    Private Sub realizarBusqueda()
        Dim data As New DataTable
        Dim dato As String = ""
        dato = txtDato.Text.ToString.Trim()
        data = obj.nCrudListar("select * from vista_usuarios where usuario like '%" & dato & "%' and tipo_u<>'S' order by usuario asc")
        dgvUsuarios.DataSource = data
        cargaInicialEstados()
    End Sub

    Private Sub txtDato_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtDato.TextChanged
        On Error Resume Next
        'If e.KeyChar = Convert.ToChar(Keys.Enter) Then
        realizarBusqueda()
        'End If
    End Sub
End Class

