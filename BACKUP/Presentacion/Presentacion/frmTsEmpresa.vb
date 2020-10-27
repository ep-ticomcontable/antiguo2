Imports Negocio

Public Class frmTsEmpresa
    Dim obj As New nCrud
    Dim ind_carga As Integer = 0
    Dim tipo As String = ""

    Private Function codigoCeldaSeleccionada() As Integer
        Dim c As String
        Try
            Dim f As Integer
            f = dgvLista.CurrentCell.RowIndex() 'obtiene la fila seleccionada del Grid
            c = dgvLista.Rows(f).Cells("id").Value.ToString
        Catch ex As Exception
            c = 0
        End Try
        Return c
    End Function

    Private Sub cargarMonedas()
        Dim tbData As New DataTable
        tbData.Columns.Add("Codigo")
        tbData.Columns.Add("Nombre")
        tbData.Rows.Add(0, "Seleccione")
        Dim tbData2 As DataTable
        Try
            tbData2 = obj.nCrudListarBD("select * from tipo_moneda where estado=1 order by descripcion asc", CadenaConexion)
            For Each row As DataRow In tbData2.Rows
                tbData.Rows.Add(row.Item(0).ToString, "(" & row.Item(1).ToString & ") " & row.Item(2).ToString)
            Next
            With cboMoneda
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

    Private Sub cargarPlanContable()
        Dim tbData As New DataTable
        tbData.Columns.Add("Codigo")
        tbData.Columns.Add("Nombre")
        tbData.Rows.Add(0, "Nuevo")
        Dim tbData2 As DataTable
        Try
            tbData2 = obj.nCrudListarBD("select * from empresas where estado=1 and id>1 order by nombre asc", CadenaConexion)
            For Each row As DataRow In tbData2.Rows
                tbData.Rows.Add(row.Item("ruc").ToString, row.Item("nombre").ToString)
            Next
            With cboPlan
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

    Private Sub cargarDatos()
        Dim data As New DataTable
        If CodigoUsuarioSession = "1" Then
            data = obj.nCrudListarBD("select * from vista_listaEmpresas order by nombre asc", CadenaConexion)
        Else
            data = obj.nCrudListarBD("select v.id,v.nombre,v.ruc,v.direccion,v.periodo,v.estado from vista_listaEmpresas v inner join usuarios_empresas u on v.id=u.id_empresa where u.id_usuario='" & CodigoUsuarioSession & "' order by v.nombre asc", CadenaConexion)
        End If

        dgvLista.DataSource = data
        data = Nothing
        cargaInicialEstados()
    End Sub

    Private Sub frmTsEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cargarMonedas()
        cargarPlanContable()
        txtDato.Focus()
        txtDato.Select()
    End Sub

    Private Sub dgvLista_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLista.SelectionChanged
        cargarDatosCuenta()
    End Sub

    Private Sub cargarDatosCuenta()
        If tipo <> "new" Or tipo = "" Then
            Me.Enabled = False
            On Error Resume Next
            Dim sql As String
            sql = "select * from empresas where id=" & codigoCeldaSeleccionada()
            Dim data As New DataTable
            data = obj.nCrudListarBD(sql, CadenaConexion)
            With data
                txtNombre.Text = .Rows(0)("nombre").ToString
                txtAlias.Text = .Rows(0)("alias").ToString
                txtRuc.Text = .Rows(0)("ruc").ToString
                txtPeriodo.Text = .Rows(0)("periodo").ToString
                txtDireccion.Text = .Rows(0)("direccion").ToString
                cboMoneda.SelectedValue = .Rows(0)("id_moneda").ToString

                If .Rows(0)("estado") = "0" Then
                    rbNo.Checked = True
                ElseIf .Rows(0)("estado") = "1" Then
                    rbSi.Checked = True
                End If
            End With
            data = Nothing
            Me.Enabled = True
        ElseIf tipo = "new" Then
            txtNombre.Focus()
        End If
        cargaInicialEstados()
    End Sub

    Private Sub frmTsTipoPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            cargarDatos()
        End If
    End Sub

    Private Sub txtDato_TextChanged(sender As Object, e As EventArgs) Handles txtDato.TextChanged
        'If txtDato.Text.Length > 2 Then

        'End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        gbGrupo.Enabled = True
        tipo = "update"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        gbGrupo.Enabled = True
        tipo = "new"
        limpiarEntradas()
    End Sub

    Private Sub limpiarEntradas()
        txtNombre.Text = "BTEC PERU SCRL"
        txtAlias.Text = "BTECPERU"
        txtRuc.Text = "20447393302"
        txtPeriodo.Text = "2016"
        txtDireccion.Text = "Av Petith Thouars 1255 Of. 302 Lima - Perú"
        cboMoneda.SelectedValue = 115
        rbSi.Checked = True
        txtNombre.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        gbGrupo.Enabled = False
        tipo = ""
        cargarDatosCuenta()
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
        campos = "nombre@alias@ruc@direccion@periodo@id_moneda@estado"
        valores = txtNombre.Text.ToString & "@" & txtAlias.Text.Trim & "@" & txtRuc.Text.ToString & "@" & txtDireccion.Text.ToString & "@" & txtPeriodo.Text.ToString & "@" & cboMoneda.SelectedValue.ToString & "@" & estado

        Dim rpta As String = ""
        Dim tabla As String = "empresas"
        If tipo = "update" Then
            txtAlias.Enabled = False
            condicion = "id=" & codigoCeldaSeleccionada()
            rpta = obj.nCrudActualizarBD("@", tabla, campos, valores, condicion, CadenaConexion)
            If codigoCeldaSeleccionada() > 1 Then
                Dim query As String
                query = "UPDATE empresas SET [nombre] = '" & txtNombre.Text.ToString & "',[alias] ='" & txtAlias.Text.Trim & "',[ruc] ='" & txtRuc.Text.ToString & "',[direccion] ='" & txtDireccion.Text.ToString & "',[periodo] ='" & txtPeriodo.Text.ToString & "',[id_moneda] ='" & cboMoneda.SelectedValue.ToString & "',[estado] =  '" & estado & "' WHERE id='" & codigoCeldaSeleccionada() & "'"
                MsgBox("ACTUALIZACION DE EMPRESA: " & obj.nEjecutarConsultaEnBD(txtAlias.Text.Trim, query))
            End If
        ElseIf tipo = "new" Then
            Dim data As New DataTable
            data = obj.nCrudListarBD("select * from empresas where alias like '%" & txtAlias.Text.Trim & "%'", CadenaConexion)
            If data.Rows.Count > 0 Then
                rpta = "No se puedo completar el proceso"
                MsgBox("El ALIAS de la Empresa a crear ya existe, ingrese otra descripción para continuar.")
            Else
                Dim dataBD As New DataTable
                dataBD = obj.nCrudListarBD("SELECT * FROM sys.databases where log_reuse_wait_desc='LOG_BACKUP' and name like '%" & txtAlias.Text.Trim & "%'", CadenaConexion)
                If dataBD.Rows.Count > 0 Then
                    rpta = "No se puedo completar el proceso"
                    MsgBox("El nombre de la Base de Datos: " & txtAlias.Text.Trim & ", ya se encuentra registrada. Ingrese otro ALIAS para usar como nombre de la Base de Datos en el sistema.")
                Else
                    Dim query1 As String
                    query1 = "usp_registrarEmpresa '" & txtNombre.Text.ToString & "','" & txtAlias.Text.Trim & "','" & txtRuc.Text.ToString & "','" & txtDireccion.Text.ToString & "','" & txtPeriodo.Text.ToString & "','" & cboMoneda.SelectedValue.ToString & "','" & estado & "'"

                    rpta = obj.nEjecutarQueryBD(query1, CadenaConexion)
                    copiarBD()
                    'asignar empresa de la BD principal a la BD de la empresa creada
                    Dim query As String
                    query = "usp_registrarEmpresa '" & txtNombre.Text.ToString & "','" & txtAlias.Text.Trim & "','" & txtRuc.Text.ToString & "','" & txtDireccion.Text.ToString & "','" & txtPeriodo.Text.ToString & "','" & cboMoneda.SelectedValue.ToString & "','" & estado & "'"
                    'MsgBox("ASIGNACION DE EMPRESA: " & obj.nEjecutarConsultaEnBD(txtAlias.Text.Trim, query))
                    obj.nEjecutarConsultaEnBD(txtAlias.Text.Trim, query)

                    If cboPlan.SelectedValue.ToString <> "0" Then
                        Dim dEmpresa As New DataTable
                        dEmpresa = obj.nCrudListarBD("select * from [TICOM-CONTABLE].[dbo].[empresas] where ruc='" & cboPlan.SelectedValue.ToString & "'", CadenaConexion)

                        Dim queryLimpiar, queryInst As String
                        queryLimpiar = "truncate table [" & txtAlias.Text.Trim & "].[dbo].[cuenta_contable]"
                        'MsgBox("LIMPIEZA DE PLAN CONTABLE: " & obj.nEjecutarConsultaEnBD(txtAlias.Text.Trim, queryLimpiar))
                        obj.nEjecutarConsultaEnBD(txtAlias.Text.Trim, queryLimpiar)
                        queryInst = "insert into [" & txtAlias.Text.Trim & "].[dbo].[cuenta_contable] select * from [" & dEmpresa.Rows(0)("alias").ToString & "].[dbo].[cuenta_contable]"
                        'MsgBox("CARGAR DE PLAN CONTABLE: " & obj.nEjecutarConsultaEnBD(txtAlias.Text.Trim, queryInst))
                        obj.nEjecutarConsultaEnBD(txtAlias.Text.Trim, queryInst)
                    End If

                    cargarPlanContable()
                End If

            End If

        End If

        If rpta = "ok" Then
            MessageBox.Show("El proceso se ha realizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            gbGrupo.Enabled = False
            limpiarEntradas()
            cargarDatos()
            txtDato.Focus()
        Else
            MessageBox.Show(rpta, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub controlarServicio(control As String, nombreServicio As String)
        Dim myProcess As New Process()
        myProcess.StartInfo.UseShellExecute = False

        myProcess.StartInfo.FileName = "cmd.exe" 'Aquí  le pasarías el nombre de tu programa
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.Arguments = "/c net " & control & " " & nombreServicio 'Aquí le pasarías los argumentos
        myProcess.StartInfo.CreateNoWindow = False
        myProcess.Start()
        myProcess.WaitForExit()
    End Sub

    Private Sub copiarBD()

        'controlarServicio("stop", "MSSQL$PCPROG")
        Dim carpetaDestino As String = "D:\BDS\empresas\"

        Dim nomBD As String = txtAlias.Text.Trim
        Dim fileMdf As String = "D:\BDS\plantilla\TICOM-CONTABLE.mdf"
        My.Computer.FileSystem.CopyFile(
            fileMdf,
            carpetaDestino & nomBD & ".mdf",
            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        Dim fileLdf As String = "D:\BDS\plantilla\TICOM-CONTABLE_log.ldf"
        My.Computer.FileSystem.CopyFile(
            fileLdf,
            carpetaDestino & nomBD & "_log.ldf",
            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        'controlarServicio("start", "MSSQL$PCPROG")
        'MsgBox("REGISTRO DE EMPRESA: " & obj.nCargarBD(nomBD, carpetaDestino))
        obj.nCargarBD(nomBD, carpetaDestino)

    End Sub

    Private Sub cargaInicialEstados()
        Try
            For Each row As DataGridViewRow In dgvLista.Rows
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
        If CodigoUsuarioSession = "1" Then
            data = obj.nCrudListarBD("select * from vista_listaEmpresas where nombre like '%" & dato & "%' or ruc like '%" & dato & "%' order by nombre asc", CadenaConexion)
        Else
            data = obj.nCrudListarBD("select v.id,v.nombre,v.ruc,v.direccion,v.periodo,v.estado from vista_listaEmpresas v inner join usuarios_empresas u on v.id=u.id_empresa where u.id_usuario='" & CodigoUsuarioSession & "' and (v.nombre like '%" & dato & "%' or v.ruc like '%" & dato & "%') order by v.nombre asc", CadenaConexion)
        End If

        dgvLista.DataSource = data
        cargaInicialEstados()
    End Sub

    Private Sub txtDato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDato.KeyPress
        On Error Resume Next
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            realizarBusqueda()
        End If
    End Sub

    Private Sub btnAsignarUsuarios_Click(sender As Object, e As EventArgs) Handles btnAsignarUsuarios.Click
        frmTsUsuarios.Show()
    End Sub
End Class
