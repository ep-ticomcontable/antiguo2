﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaComprobanteCompras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.dtHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnFormatoCompra = New System.Windows.Forms.Button()
        Me.btnGenerarPle = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumRegistros = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblIgv = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMontos = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.panelDetalle = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgvPagos = New System.Windows.Forms.DataGridView()
        Me.fecha_abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa_abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda_abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto_abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotalAbonos = New System.Windows.Forms.TextBox()
        Me.lblTotalAbono = New System.Windows.Forms.Label()
        Me.lblNoPagos = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtDiferencia = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtTotalHaber = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtTotalDebe = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dgvAsientos = New System.Windows.Forms.DataGridView()
        Me.num_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTipoOperacion = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtGlosa = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDeuda = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTc = New System.Windows.Forms.TextBox()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.txtFechaPago = New System.Windows.Forms.TextBox()
        Me.txtFechaEmision = New System.Windows.Forms.TextBox()
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.txtRazon = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtTipoDocumento = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTipoDeCambio = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grupoBusqueda = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkDolares = New System.Windows.Forms.CheckBox()
        Me.chkSoles = New System.Windows.Forms.CheckBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboAnio = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnLDCompra = New System.Windows.Forms.Button()
        Me.btnCanje = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.btnPagos = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnDebito = New System.Windows.Forms.Button()
        Me.btnCredito = New System.Windows.Forms.Button()
        Me.PanelLetra = New System.Windows.Forms.Panel()
        Me.btnCanjear = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvLetras = New System.Windows.Forms.DataGridView()
        Me.idL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_emisionL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_vencimientoL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serieL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeroL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.librado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lugar_giro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aval = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotalCanjes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtDiferenciaL = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtTotalHaberL = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtTotalDebeL = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.dgvCuentasLetras = New System.Windows.Forms.DataGridView()
        Me.cuentaL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosaL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debeL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.haberL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtTipoOperacion2 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtGlosa2 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtDeuda2 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtTotal2 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtTc2 = New System.Windows.Forms.TextBox()
        Me.txtMoneda2 = New System.Windows.Forms.TextBox()
        Me.txtFechaPago2 = New System.Windows.Forms.TextBox()
        Me.txtFechaEmision2 = New System.Windows.Forms.TextBox()
        Me.txtFormaPago2 = New System.Windows.Forms.TextBox()
        Me.txtRazon2 = New System.Windows.Forms.TextBox()
        Me.txtRuc2 = New System.Windows.Forms.TextBox()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.txtSerie2 = New System.Windows.Forms.TextBox()
        Me.txtTipoDocumento2 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadoCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sujeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.razon_social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.igv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gravado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glosa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_emision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.centro_costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.panelDetalle.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvAsientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoBusqueda.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.PanelLetra.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dgvCuentasLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToOrderColumns = True
        Me.dgvLista.BackgroundColor = System.Drawing.Color.White
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tipo_compra, Me.estadoCompra, Me.id_tipo_comprobante, Me.sujeto, Me.comprobante, Me.serie, Me.numero, Me.num_dni, Me.razon_social, Me.moneda, Me.tc, Me.monto, Me.igv, Me.total, Me.abono, Me.gravado, Me.glosa, Me.fec_emision, Me.fec_pago, Me.estado_comprobante, Me.estado, Me.centro_costo})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLista.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvLista.Location = New System.Drawing.Point(6, 20)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(665, 376)
        Me.dgvLista.TabIndex = 0
        '
        'txtDato
        '
        Me.txtDato.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtDato.Location = New System.Drawing.Point(7, 87)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(165, 21)
        Me.txtDato.TabIndex = 103
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Cliente.Location = New System.Drawing.Point(4, 23)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(67, 16)
        Me.Cliente.TabIndex = 102
        Me.Cliente.Text = "Buscar por:"
        '
        'cboTipo
        '
        Me.cboTipo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(7, 42)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(165, 23)
        Me.cboTipo.TabIndex = 106
        '
        'dtHasta
        '
        Me.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtHasta.Location = New System.Drawing.Point(91, 132)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Size = New System.Drawing.Size(81, 21)
        Me.dtHasta.TabIndex = 110
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label1.Location = New System.Drawing.Point(88, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Hasta:"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Location = New System.Drawing.Point(77, 255)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(95, 27)
        Me.btnConsultar.TabIndex = 109
        Me.btnConsultar.Text = "CONSULTAR"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'dtDesde
        '
        Me.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDesde.Location = New System.Drawing.Point(7, 132)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Size = New System.Drawing.Size(78, 21)
        Me.dtDesde.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label2.Location = New System.Drawing.Point(4, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(4, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Dato:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(30, 435)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 27)
        Me.Button2.TabIndex = 116
        Me.Button2.Text = "&NUEVA COMPRA"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnFormatoCompra
        '
        Me.btnFormatoCompra.BackColor = System.Drawing.Color.Black
        Me.btnFormatoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormatoCompra.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnFormatoCompra.ForeColor = System.Drawing.Color.White
        Me.btnFormatoCompra.Location = New System.Drawing.Point(30, 468)
        Me.btnFormatoCompra.Name = "btnFormatoCompra"
        Me.btnFormatoCompra.Size = New System.Drawing.Size(118, 27)
        Me.btnFormatoCompra.TabIndex = 118
        Me.btnFormatoCompra.Text = "FORMATO 8.1"
        Me.btnFormatoCompra.UseVisualStyleBackColor = False
        '
        'btnGenerarPle
        '
        Me.btnGenerarPle.BackColor = System.Drawing.Color.Black
        Me.btnGenerarPle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarPle.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnGenerarPle.ForeColor = System.Drawing.Color.White
        Me.btnGenerarPle.Location = New System.Drawing.Point(30, 501)
        Me.btnGenerarPle.Name = "btnGenerarPle"
        Me.btnGenerarPle.Size = New System.Drawing.Size(118, 27)
        Me.btnGenerarPle.TabIndex = 119
        Me.btnGenerarPle.Text = "GENERAR PLE"
        Me.btnGenerarPle.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(781, 34)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(92, 27)
        Me.btnActualizar.TabIndex = 123
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(4, 4)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(325, 40)
        Me.lblTitulo.TabIndex = 211
        Me.lblTitulo.Text = "LISTA DE COMPRAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNumRegistros)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblIgv)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblMontos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dgvLista)
        Me.GroupBox1.Controls.Add(Me.lblMoneda)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(195, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(677, 438)
        Me.GroupBox1.TabIndex = 212
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTROS"
        '
        'lblNumRegistros
        '
        Me.lblNumRegistros.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumRegistros.Location = New System.Drawing.Point(3, 417)
        Me.lblNumRegistros.Name = "lblNumRegistros"
        Me.lblNumRegistros.Size = New System.Drawing.Size(87, 17)
        Me.lblNumRegistros.TabIndex = 117
        Me.lblNumRegistros.Text = "0"
        Me.lblNumRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label13.Location = New System.Drawing.Point(3, 399)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 17)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "N° REGISTROS:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(601, 417)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(36, 17)
        Me.lblTotal.TabIndex = 114
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label10.Location = New System.Drawing.Point(601, 399)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 17)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "TOTAL:"
        '
        'lblIgv
        '
        Me.lblIgv.AutoSize = True
        Me.lblIgv.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblIgv.Location = New System.Drawing.Point(533, 417)
        Me.lblIgv.Name = "lblIgv"
        Me.lblIgv.Size = New System.Drawing.Size(36, 17)
        Me.lblIgv.TabIndex = 112
        Me.lblIgv.Text = "0.00"
        Me.lblIgv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label8.Location = New System.Drawing.Point(533, 399)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 17)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "IGV:"
        '
        'lblMontos
        '
        Me.lblMontos.AutoSize = True
        Me.lblMontos.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblMontos.Location = New System.Drawing.Point(447, 417)
        Me.lblMontos.Name = "lblMontos"
        Me.lblMontos.Size = New System.Drawing.Size(36, 17)
        Me.lblMontos.TabIndex = 110
        Me.lblMontos.Text = "0.00"
        Me.lblMontos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.5!)
        Me.Label4.Location = New System.Drawing.Point(447, 399)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "MONTOS:"
        '
        'lblMoneda
        '
        Me.lblMoneda.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblMoneda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblMoneda.Location = New System.Drawing.Point(271, 399)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(175, 35)
        Me.lblMoneda.TabIndex = 115
        Me.lblMoneda.Text = "(PEN/USD)"
        Me.lblMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panelDetalle
        '
        Me.panelDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelDetalle.Controls.Add(Me.Panel2)
        Me.panelDetalle.Controls.Add(Me.GroupBox6)
        Me.panelDetalle.Controls.Add(Me.GroupBox5)
        Me.panelDetalle.Controls.Add(Me.GroupBox4)
        Me.panelDetalle.Controls.Add(Me.PictureBox1)
        Me.panelDetalle.Controls.Add(Me.Label6)
        Me.panelDetalle.Cursor = System.Windows.Forms.Cursors.Default
        Me.panelDetalle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelDetalle.Location = New System.Drawing.Point(196, 125)
        Me.panelDetalle.Name = "panelDetalle"
        Me.panelDetalle.Padding = New System.Windows.Forms.Padding(20)
        Me.panelDetalle.Size = New System.Drawing.Size(677, 328)
        Me.panelDetalle.TabIndex = 223
        Me.panelDetalle.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Location = New System.Drawing.Point(62, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(63, 39)
        Me.Panel2.TabIndex = 278
        Me.Panel2.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgvPagos)
        Me.GroupBox6.Controls.Add(Me.txtTotalAbonos)
        Me.GroupBox6.Controls.Add(Me.lblTotalAbono)
        Me.GroupBox6.Controls.Add(Me.lblNoPagos)
        Me.GroupBox6.Location = New System.Drawing.Point(23, 220)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(629, 134)
        Me.GroupBox6.TabIndex = 216
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ABONOS - PAGOS"
        '
        'dgvPagos
        '
        Me.dgvPagos.AllowUserToAddRows = False
        Me.dgvPagos.BackgroundColor = System.Drawing.Color.White
        Me.dgvPagos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvPagos.ColumnHeadersHeight = 30
        Me.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha_abono, Me.glosa_abono, Me.moneda_abono, Me.monto_abono})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPagos.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvPagos.Location = New System.Drawing.Point(6, 20)
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.RowHeadersVisible = False
        Me.dgvPagos.Size = New System.Drawing.Size(529, 107)
        Me.dgvPagos.TabIndex = 275
        '
        'fecha_abono
        '
        Me.fecha_abono.DataPropertyName = "fecha_abono"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.fecha_abono.DefaultCellStyle = DataGridViewCellStyle12
        Me.fecha_abono.HeaderText = "FECHA"
        Me.fecha_abono.Name = "fecha_abono"
        Me.fecha_abono.Width = 125
        '
        'glosa_abono
        '
        Me.glosa_abono.DataPropertyName = "glosa_abono"
        Me.glosa_abono.HeaderText = "DESCRIPCIÓN"
        Me.glosa_abono.Name = "glosa_abono"
        Me.glosa_abono.Width = 256
        '
        'moneda_abono
        '
        Me.moneda_abono.DataPropertyName = "moneda_abono"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.moneda_abono.DefaultCellStyle = DataGridViewCellStyle13
        Me.moneda_abono.HeaderText = "MND"
        Me.moneda_abono.Name = "moneda_abono"
        Me.moneda_abono.Width = 50
        '
        'monto_abono
        '
        Me.monto_abono.DataPropertyName = "monto_abono"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.monto_abono.DefaultCellStyle = DataGridViewCellStyle14
        Me.monto_abono.HeaderText = "MONTO"
        Me.monto_abono.Name = "monto_abono"
        Me.monto_abono.Width = 80
        '
        'txtTotalAbonos
        '
        Me.txtTotalAbonos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalAbonos.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAbonos.ForeColor = System.Drawing.Color.Black
        Me.txtTotalAbonos.Location = New System.Drawing.Point(541, 67)
        Me.txtTotalAbonos.Multiline = True
        Me.txtTotalAbonos.Name = "txtTotalAbonos"
        Me.txtTotalAbonos.Size = New System.Drawing.Size(82, 20)
        Me.txtTotalAbonos.TabIndex = 343
        Me.txtTotalAbonos.Text = "3.43"
        '
        'lblTotalAbono
        '
        Me.lblTotalAbono.AutoSize = True
        Me.lblTotalAbono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTotalAbono.Location = New System.Drawing.Point(538, 48)
        Me.lblTotalAbono.Name = "lblTotalAbono"
        Me.lblTotalAbono.Size = New System.Drawing.Size(88, 16)
        Me.lblTotalAbono.TabIndex = 342
        Me.lblTotalAbono.Text = "Total Abono(s):"
        '
        'lblNoPagos
        '
        Me.lblNoPagos.AutoSize = True
        Me.lblNoPagos.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.lblNoPagos.ForeColor = System.Drawing.Color.Silver
        Me.lblNoPagos.Location = New System.Drawing.Point(44, 47)
        Me.lblNoPagos.Name = "lblNoPagos"
        Me.lblNoPagos.Size = New System.Drawing.Size(540, 40)
        Me.lblNoPagos.TabIndex = 345
        Me.lblNoPagos.Text = "NO SE HAN REGISTRADO PAGOS"
        Me.lblNoPagos.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtDiferencia)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.txtTotalHaber)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.txtTotalDebe)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.dgvAsientos)
        Me.GroupBox5.Location = New System.Drawing.Point(23, 360)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(629, 202)
        Me.GroupBox5.TabIndex = 215
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ASIENTOS DEL COMPROBANTE"
        '
        'txtDiferencia
        '
        Me.txtDiferencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiferencia.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferencia.ForeColor = System.Drawing.Color.Black
        Me.txtDiferencia.Location = New System.Drawing.Point(541, 143)
        Me.txtDiferencia.Multiline = True
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.Size = New System.Drawing.Size(82, 20)
        Me.txtDiferencia.TabIndex = 349
        Me.txtDiferencia.Text = "0.00"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(538, 124)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 16)
        Me.Label26.TabIndex = 348
        Me.Label26.Text = "Diferencia:"
        '
        'txtTotalHaber
        '
        Me.txtTotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalHaber.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHaber.ForeColor = System.Drawing.Color.Black
        Me.txtTotalHaber.Location = New System.Drawing.Point(541, 101)
        Me.txtTotalHaber.Multiline = True
        Me.txtTotalHaber.Name = "txtTotalHaber"
        Me.txtTotalHaber.Size = New System.Drawing.Size(82, 20)
        Me.txtTotalHaber.TabIndex = 347
        Me.txtTotalHaber.Text = "0.00"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(538, 82)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 16)
        Me.Label25.TabIndex = 346
        Me.Label25.Text = "Total Haber:"
        '
        'txtTotalDebe
        '
        Me.txtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalDebe.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDebe.ForeColor = System.Drawing.Color.Black
        Me.txtTotalDebe.Location = New System.Drawing.Point(541, 59)
        Me.txtTotalDebe.Multiline = True
        Me.txtTotalDebe.Name = "txtTotalDebe"
        Me.txtTotalDebe.Size = New System.Drawing.Size(82, 20)
        Me.txtTotalDebe.TabIndex = 345
        Me.txtTotalDebe.Text = "0.00"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(538, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 16)
        Me.Label24.TabIndex = 344
        Me.Label24.Text = "Total Debe:"
        '
        'dgvAsientos
        '
        Me.dgvAsientos.AllowUserToAddRows = False
        Me.dgvAsientos.BackgroundColor = System.Drawing.Color.White
        Me.dgvAsientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAsientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAsientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvAsientos.ColumnHeadersHeight = 30
        Me.dgvAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAsientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_cuenta, Me.desc_cuenta, Me.debe, Me.haber})
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAsientos.DefaultCellStyle = DataGridViewCellStyle20
        Me.dgvAsientos.Location = New System.Drawing.Point(6, 20)
        Me.dgvAsientos.Name = "dgvAsientos"
        Me.dgvAsientos.RowHeadersVisible = False
        Me.dgvAsientos.Size = New System.Drawing.Size(529, 176)
        Me.dgvAsientos.TabIndex = 274
        '
        'num_cuenta
        '
        Me.num_cuenta.DataPropertyName = "num_cuenta"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.num_cuenta.DefaultCellStyle = DataGridViewCellStyle17
        Me.num_cuenta.HeaderText = "N° CTA."
        Me.num_cuenta.Name = "num_cuenta"
        Me.num_cuenta.Width = 65
        '
        'desc_cuenta
        '
        Me.desc_cuenta.DataPropertyName = "desc_cuenta"
        Me.desc_cuenta.HeaderText = "DESCRIPCIÓN"
        Me.desc_cuenta.Name = "desc_cuenta"
        Me.desc_cuenta.Width = 286
        '
        'debe
        '
        Me.debe.DataPropertyName = "debe"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "N2"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.debe.DefaultCellStyle = DataGridViewCellStyle18
        Me.debe.HeaderText = "DEBE"
        Me.debe.Name = "debe"
        Me.debe.Width = 80
        '
        'haber
        '
        Me.haber.DataPropertyName = "haber"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "N2"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.haber.DefaultCellStyle = DataGridViewCellStyle19
        Me.haber.HeaderText = "HABER"
        Me.haber.Name = "haber"
        Me.haber.Width = 80
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtTipoOperacion)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtGlosa)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtDeuda)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtTotal)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtTc)
        Me.GroupBox4.Controls.Add(Me.txtMoneda)
        Me.GroupBox4.Controls.Add(Me.txtFechaPago)
        Me.GroupBox4.Controls.Add(Me.txtFechaEmision)
        Me.GroupBox4.Controls.Add(Me.txtFormaPago)
        Me.GroupBox4.Controls.Add(Me.txtRazon)
        Me.GroupBox4.Controls.Add(Me.txtRuc)
        Me.GroupBox4.Controls.Add(Me.txtNumero)
        Me.GroupBox4.Controls.Add(Me.txtSerie)
        Me.GroupBox4.Controls.Add(Me.txtTipoDocumento)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.lblTipoDeCambio)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Location = New System.Drawing.Point(23, 59)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(629, 150)
        Me.GroupBox4.TabIndex = 214
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DATOS DEL COMPROBANTE DE COMPRA"
        '
        'txtTipoOperacion
        '
        Me.txtTipoOperacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTipoOperacion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoOperacion.ForeColor = System.Drawing.Color.Black
        Me.txtTipoOperacion.Location = New System.Drawing.Point(246, 124)
        Me.txtTipoOperacion.Multiline = True
        Me.txtTipoOperacion.Name = "txtTipoOperacion"
        Me.txtTipoOperacion.Size = New System.Drawing.Size(377, 20)
        Me.txtTipoOperacion.TabIndex = 345
        Me.txtTipoOperacion.Text = "[DATO CAMPO]"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(243, 105)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(113, 16)
        Me.Label22.TabIndex = 344
        Me.Label22.Text = "Tipo de Operación:"
        '
        'txtGlosa
        '
        Me.txtGlosa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGlosa.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.Black
        Me.txtGlosa.Location = New System.Drawing.Point(6, 124)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(234, 20)
        Me.txtGlosa.TabIndex = 343
        Me.txtGlosa.Text = "[DATO CAMPO]"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(3, 105)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 16)
        Me.Label21.TabIndex = 342
        Me.Label21.Text = "Glosa:"
        '
        'txtDeuda
        '
        Me.txtDeuda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDeuda.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeuda.ForeColor = System.Drawing.Color.Red
        Me.txtDeuda.Location = New System.Drawing.Point(541, 80)
        Me.txtDeuda.Multiline = True
        Me.txtDeuda.Name = "txtDeuda"
        Me.txtDeuda.Size = New System.Drawing.Size(82, 20)
        Me.txtDeuda.TabIndex = 341
        Me.txtDeuda.Text = "3.43"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(538, 61)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 16)
        Me.Label20.TabIndex = 340
        Me.Label20.Text = "Total Deuda:"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(453, 80)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(82, 20)
        Me.txtTotal.TabIndex = 339
        Me.txtTotal.Text = "3.43"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(450, 61)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 16)
        Me.Label18.TabIndex = 338
        Me.Label18.Text = "Total Compra:"
        '
        'txtTc
        '
        Me.txtTc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTc.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTc.ForeColor = System.Drawing.Color.Black
        Me.txtTc.Location = New System.Drawing.Point(409, 80)
        Me.txtTc.Multiline = True
        Me.txtTc.Name = "txtTc"
        Me.txtTc.Size = New System.Drawing.Size(38, 20)
        Me.txtTc.TabIndex = 337
        Me.txtTc.Text = "3.43"
        '
        'txtMoneda
        '
        Me.txtMoneda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMoneda.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoneda.ForeColor = System.Drawing.Color.Black
        Me.txtMoneda.Location = New System.Drawing.Point(346, 80)
        Me.txtMoneda.Multiline = True
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(57, 20)
        Me.txtMoneda.TabIndex = 336
        Me.txtMoneda.Text = "PEN"
        '
        'txtFechaPago
        '
        Me.txtFechaPago.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaPago.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaPago.ForeColor = System.Drawing.Color.Red
        Me.txtFechaPago.Location = New System.Drawing.Point(146, 80)
        Me.txtFechaPago.Multiline = True
        Me.txtFechaPago.Name = "txtFechaPago"
        Me.txtFechaPago.Size = New System.Drawing.Size(94, 20)
        Me.txtFechaPago.TabIndex = 335
        Me.txtFechaPago.Text = "[DATO CAMPO]"
        '
        'txtFechaEmision
        '
        Me.txtFechaEmision.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaEmision.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaEmision.ForeColor = System.Drawing.Color.Black
        Me.txtFechaEmision.Location = New System.Drawing.Point(6, 80)
        Me.txtFechaEmision.Multiline = True
        Me.txtFechaEmision.Name = "txtFechaEmision"
        Me.txtFechaEmision.Size = New System.Drawing.Size(134, 20)
        Me.txtFechaEmision.TabIndex = 334
        Me.txtFechaEmision.Text = "[DATO CAMPO]"
        '
        'txtFormaPago
        '
        Me.txtFormaPago.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFormaPago.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormaPago.ForeColor = System.Drawing.Color.Black
        Me.txtFormaPago.Location = New System.Drawing.Point(246, 80)
        Me.txtFormaPago.Multiline = True
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.Size = New System.Drawing.Size(94, 20)
        Me.txtFormaPago.TabIndex = 333
        Me.txtFormaPago.Text = "[DATO CAMPO]"
        '
        'txtRazon
        '
        Me.txtRazon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRazon.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazon.ForeColor = System.Drawing.Color.Black
        Me.txtRazon.Location = New System.Drawing.Point(306, 36)
        Me.txtRazon.Multiline = True
        Me.txtRazon.Name = "txtRazon"
        Me.txtRazon.Size = New System.Drawing.Size(317, 20)
        Me.txtRazon.TabIndex = 332
        Me.txtRazon.Text = "[DATO CAMPO]"
        '
        'txtRuc
        '
        Me.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRuc.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.ForeColor = System.Drawing.Color.Black
        Me.txtRuc.Location = New System.Drawing.Point(231, 36)
        Me.txtRuc.Multiline = True
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(69, 20)
        Me.txtRuc.TabIndex = 331
        Me.txtRuc.Text = "00000000000"
        '
        'txtNumero
        '
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumero.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.Black
        Me.txtNumero.Location = New System.Drawing.Point(178, 36)
        Me.txtNumero.Multiline = True
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(47, 20)
        Me.txtNumero.TabIndex = 330
        Me.txtNumero.Text = "[DATO CAMPO]"
        '
        'txtSerie
        '
        Me.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSerie.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.ForeColor = System.Drawing.Color.Black
        Me.txtSerie.Location = New System.Drawing.Point(125, 36)
        Me.txtSerie.Multiline = True
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(47, 20)
        Me.txtSerie.TabIndex = 329
        Me.txtSerie.Text = "[DATO CAMPO]"
        '
        'txtTipoDocumento
        '
        Me.txtTipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTipoDocumento.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.txtTipoDocumento.Location = New System.Drawing.Point(6, 36)
        Me.txtTipoDocumento.Multiline = True
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.Size = New System.Drawing.Size(113, 20)
        Me.txtTipoDocumento.TabIndex = 328
        Me.txtTipoDocumento.Text = "[DATO CAMPO]"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(143, 61)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 16)
        Me.Label28.TabIndex = 327
        Me.Label28.Text = "Fecha pago:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(3, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 325
        Me.Label9.Text = "Fecha emisión:"
        '
        'lblTipoDeCambio
        '
        Me.lblTipoDeCambio.AutoSize = True
        Me.lblTipoDeCambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.lblTipoDeCambio.Location = New System.Drawing.Point(409, 61)
        Me.lblTipoDeCambio.Name = "lblTipoDeCambio"
        Me.lblTipoDeCambio.Size = New System.Drawing.Size(28, 16)
        Me.lblTipoDeCambio.TabIndex = 322
        Me.lblTipoDeCambio.Text = "T.C:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(344, 61)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 16)
        Me.Label29.TabIndex = 323
        Me.Label29.Text = "Moneda:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(243, 61)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 16)
        Me.Label19.TabIndex = 319
        Me.Label19.Text = "Forma pago:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(122, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 16)
        Me.Label12.TabIndex = 317
        Me.Label12.Text = "Serie:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(228, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 16)
        Me.Label14.TabIndex = 313
        Me.Label14.Text = "RUC:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(3, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 16)
        Me.Label15.TabIndex = 315
        Me.Label15.Text = "Tipo Documento:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(175, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(23, 16)
        Me.Label16.TabIndex = 316
        Me.Label16.Text = "N°:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(303, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 16)
        Me.Label17.TabIndex = 314
        Me.Label17.Text = "Razón Social:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.cerrar_detalle
        Me.PictureBox1.Location = New System.Drawing.Point(6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 213
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(146, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(382, 33)
        Me.Label6.TabIndex = 212
        Me.Label6.Text = "DETALLE DEL COMPROBANTE"
        '
        'grupoBusqueda
        '
        Me.grupoBusqueda.Controls.Add(Me.GroupBox3)
        Me.grupoBusqueda.Controls.Add(Me.cboMes)
        Me.grupoBusqueda.Controls.Add(Me.Label11)
        Me.grupoBusqueda.Controls.Add(Me.cboAnio)
        Me.grupoBusqueda.Controls.Add(Me.Label5)
        Me.grupoBusqueda.Controls.Add(Me.cboTipo)
        Me.grupoBusqueda.Controls.Add(Me.Cliente)
        Me.grupoBusqueda.Controls.Add(Me.Label2)
        Me.grupoBusqueda.Controls.Add(Me.dtDesde)
        Me.grupoBusqueda.Controls.Add(Me.Label1)
        Me.grupoBusqueda.Controls.Add(Me.dtHasta)
        Me.grupoBusqueda.Controls.Add(Me.txtDato)
        Me.grupoBusqueda.Controls.Add(Me.Label3)
        Me.grupoBusqueda.Controls.Add(Me.btnGenerarPle)
        Me.grupoBusqueda.Controls.Add(Me.btnConsultar)
        Me.grupoBusqueda.Controls.Add(Me.btnFormatoCompra)
        Me.grupoBusqueda.Controls.Add(Me.Button2)
        Me.grupoBusqueda.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoBusqueda.Location = New System.Drawing.Point(11, 58)
        Me.grupoBusqueda.Name = "grupoBusqueda"
        Me.grupoBusqueda.Size = New System.Drawing.Size(178, 541)
        Me.grupoBusqueda.TabIndex = 220
        Me.grupoBusqueda.TabStop = False
        Me.grupoBusqueda.Text = "PARAMETROS DE BUSQUEDA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkDolares)
        Me.GroupBox3.Controls.Add(Me.chkSoles)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 204)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(166, 45)
        Me.GroupBox3.TabIndex = 130
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Monedas"
        '
        'chkDolares
        '
        Me.chkDolares.AutoSize = True
        Me.chkDolares.Checked = True
        Me.chkDolares.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDolares.Location = New System.Drawing.Point(94, 20)
        Me.chkDolares.Name = "chkDolares"
        Me.chkDolares.Size = New System.Drawing.Size(66, 20)
        Me.chkDolares.TabIndex = 1
        Me.chkDolares.Text = "Dólares"
        Me.chkDolares.UseVisualStyleBackColor = True
        '
        'chkSoles
        '
        Me.chkSoles.AutoSize = True
        Me.chkSoles.Checked = True
        Me.chkSoles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSoles.Location = New System.Drawing.Point(6, 20)
        Me.chkSoles.Name = "chkSoles"
        Me.chkSoles.Size = New System.Drawing.Size(53, 20)
        Me.chkSoles.TabIndex = 0
        Me.chkSoles.Text = "Soles"
        Me.chkSoles.UseVisualStyleBackColor = True
        '
        'cboMes
        '
        Me.cboMes.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Location = New System.Drawing.Point(77, 175)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(95, 23)
        Me.cboMes.TabIndex = 127
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label11.Location = New System.Drawing.Point(74, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 16)
        Me.Label11.TabIndex = 126
        Me.Label11.Text = "Mes:"
        '
        'cboAnio
        '
        Me.cboAnio.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.cboAnio.FormattingEnabled = True
        Me.cboAnio.Location = New System.Drawing.Point(7, 175)
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Size = New System.Drawing.Size(64, 23)
        Me.cboAnio.TabIndex = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(4, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Año:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.Presentacion.My.Resources.Resources.eliminar
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(782, 559)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 40)
        Me.Button3.TabIndex = 222
        Me.Button3.Text = "ELIMINAR"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnLDCompra
        '
        Me.btnLDCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLDCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLDCompra.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnLDCompra.ForeColor = System.Drawing.Color.White
        Me.btnLDCompra.Image = Global.Presentacion.My.Resources.Resources.eliminar
        Me.btnLDCompra.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnLDCompra.Location = New System.Drawing.Point(195, 559)
        Me.btnLDCompra.Name = "btnLDCompra"
        Me.btnLDCompra.Size = New System.Drawing.Size(165, 40)
        Me.btnLDCompra.TabIndex = 221
        Me.btnLDCompra.Text = "LIBRO DIARIO COMPRA"
        Me.btnLDCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLDCompra.UseVisualStyleBackColor = False
        '
        'btnCanje
        '
        Me.btnCanje.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanje.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCanje.ForeColor = System.Drawing.Color.White
        Me.btnCanje.Image = Global.Presentacion.My.Resources.Resources.nota_credito1
        Me.btnCanje.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCanje.Location = New System.Drawing.Point(488, 513)
        Me.btnCanje.Name = "btnCanje"
        Me.btnCanje.Size = New System.Drawing.Size(92, 40)
        Me.btnCanje.TabIndex = 219
        Me.btnCanje.Text = "CANJE A LETRA"
        Me.btnCanje.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnCanje.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Image = Global.Presentacion.My.Resources.Resources.eliminar
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnEliminar.Location = New System.Drawing.Point(782, 513)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(90, 40)
        Me.btnEliminar.TabIndex = 218
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnDetalle
        '
        Me.btnDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalle.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnDetalle.ForeColor = System.Drawing.Color.White
        Me.btnDetalle.Image = Global.Presentacion.My.Resources.Resources.ver_detalle
        Me.btnDetalle.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDetalle.Location = New System.Drawing.Point(195, 513)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(88, 40)
        Me.btnDetalle.TabIndex = 217
        Me.btnDetalle.Text = "VER     DETALLE"
        Me.btnDetalle.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnDetalle.UseVisualStyleBackColor = False
        '
        'btnPagos
        '
        Me.btnPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagos.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnPagos.ForeColor = System.Drawing.Color.White
        Me.btnPagos.Image = Global.Presentacion.My.Resources.Resources.pago
        Me.btnPagos.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPagos.Location = New System.Drawing.Point(395, 513)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(87, 40)
        Me.btnPagos.TabIndex = 216
        Me.btnPagos.Text = "ABONO PAGO"
        Me.btnPagos.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnPagos.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Image = Global.Presentacion.My.Resources.Resources.editar
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnModificar.Location = New System.Drawing.Point(289, 513)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 40)
        Me.btnModificar.TabIndex = 215
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnDebito
        '
        Me.btnDebito.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebito.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnDebito.ForeColor = System.Drawing.Color.White
        Me.btnDebito.Image = Global.Presentacion.My.Resources.Resources.nota_debito1
        Me.btnDebito.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDebito.Location = New System.Drawing.Point(684, 513)
        Me.btnDebito.Name = "btnDebito"
        Me.btnDebito.Size = New System.Drawing.Size(92, 40)
        Me.btnDebito.TabIndex = 214
        Me.btnDebito.Text = "NOTA DE DÉBITO"
        Me.btnDebito.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnDebito.UseVisualStyleBackColor = False
        '
        'btnCredito
        '
        Me.btnCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredito.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCredito.ForeColor = System.Drawing.Color.White
        Me.btnCredito.Image = Global.Presentacion.My.Resources.Resources.nota_credito1
        Me.btnCredito.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCredito.Location = New System.Drawing.Point(586, 513)
        Me.btnCredito.Name = "btnCredito"
        Me.btnCredito.Size = New System.Drawing.Size(92, 40)
        Me.btnCredito.TabIndex = 213
        Me.btnCredito.Text = "NOTA DE CRÉDITO"
        Me.btnCredito.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnCredito.UseVisualStyleBackColor = False
        '
        'PanelLetra
        '
        Me.PanelLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLetra.Controls.Add(Me.btnCanjear)
        Me.PanelLetra.Controls.Add(Me.Panel3)
        Me.PanelLetra.Controls.Add(Me.GroupBox2)
        Me.PanelLetra.Controls.Add(Me.GroupBox7)
        Me.PanelLetra.Controls.Add(Me.GroupBox8)
        Me.PanelLetra.Controls.Add(Me.PictureBox2)
        Me.PanelLetra.Controls.Add(Me.Label46)
        Me.PanelLetra.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelLetra.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelLetra.Location = New System.Drawing.Point(127, 4)
        Me.PanelLetra.Name = "PanelLetra"
        Me.PanelLetra.Padding = New System.Windows.Forms.Padding(20)
        Me.PanelLetra.Size = New System.Drawing.Size(677, 475)
        Me.PanelLetra.TabIndex = 224
        Me.PanelLetra.Visible = False
        '
        'btnCanjear
        '
        Me.btnCanjear.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCanjear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanjear.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnCanjear.ForeColor = System.Drawing.Color.White
        Me.btnCanjear.Location = New System.Drawing.Point(534, 21)
        Me.btnCanjear.Name = "btnCanjear"
        Me.btnCanjear.Size = New System.Drawing.Size(118, 27)
        Me.btnCanjear.TabIndex = 279
        Me.btnCanjear.Text = "&REALIZAR CANJE"
        Me.btnCanjear.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Location = New System.Drawing.Point(62, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(78, 39)
        Me.Panel3.TabIndex = 278
        Me.Panel3.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvLetras)
        Me.GroupBox2.Controls.Add(Me.txtTotalCanjes)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(629, 193)
        Me.GroupBox2.TabIndex = 216
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LETRAS CANJEADAS"
        '
        'dgvLetras
        '
        Me.dgvLetras.AllowUserToAddRows = False
        Me.dgvLetras.BackgroundColor = System.Drawing.Color.White
        Me.dgvLetras.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLetras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvLetras.ColumnHeadersHeight = 30
        Me.dgvLetras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLetras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idL, Me.fec_emisionL, Me.fec_vencimientoL, Me.montoL, Me.serieL, Me.numeroL, Me.librado, Me.lugar_giro, Me.aval, Me.direccion})
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLetras.DefaultCellStyle = DataGridViewCellStyle24
        Me.dgvLetras.Location = New System.Drawing.Point(6, 20)
        Me.dgvLetras.Name = "dgvLetras"
        Me.dgvLetras.RowHeadersVisible = False
        Me.dgvLetras.Size = New System.Drawing.Size(550, 167)
        Me.dgvLetras.TabIndex = 275
        '
        'idL
        '
        Me.idL.DataPropertyName = "idL"
        Me.idL.HeaderText = "idL"
        Me.idL.Name = "idL"
        Me.idL.Visible = False
        '
        'fec_emisionL
        '
        Me.fec_emisionL.DataPropertyName = "fec_emisionL"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.fec_emisionL.DefaultCellStyle = DataGridViewCellStyle22
        Me.fec_emisionL.HeaderText = "EMIS."
        Me.fec_emisionL.Name = "fec_emisionL"
        Me.fec_emisionL.Width = 80
        '
        'fec_vencimientoL
        '
        Me.fec_vencimientoL.DataPropertyName = "fec_vencimientoL"
        Me.fec_vencimientoL.HeaderText = "VENC."
        Me.fec_vencimientoL.Name = "fec_vencimientoL"
        Me.fec_vencimientoL.Width = 80
        '
        'montoL
        '
        Me.montoL.DataPropertyName = "montoL"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.Format = "N2"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.montoL.DefaultCellStyle = DataGridViewCellStyle23
        Me.montoL.HeaderText = "MONTO"
        Me.montoL.Name = "montoL"
        Me.montoL.Width = 80
        '
        'serieL
        '
        Me.serieL.DataPropertyName = "serieL"
        Me.serieL.HeaderText = "SERIE"
        Me.serieL.Name = "serieL"
        Me.serieL.Width = 50
        '
        'numeroL
        '
        Me.numeroL.DataPropertyName = "numeroL"
        Me.numeroL.HeaderText = "N°"
        Me.numeroL.Name = "numeroL"
        Me.numeroL.Width = 50
        '
        'librado
        '
        Me.librado.DataPropertyName = "librado"
        Me.librado.HeaderText = "LIBRADO"
        Me.librado.Name = "librado"
        '
        'lugar_giro
        '
        Me.lugar_giro.DataPropertyName = "lugar_giro"
        Me.lugar_giro.HeaderText = "LUGAR GIRO"
        Me.lugar_giro.Name = "lugar_giro"
        '
        'aval
        '
        Me.aval.DataPropertyName = "aval"
        Me.aval.HeaderText = "AVAL"
        Me.aval.Name = "aval"
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "DIRECCION"
        Me.direccion.Name = "direccion"
        '
        'txtTotalCanjes
        '
        Me.txtTotalCanjes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalCanjes.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCanjes.ForeColor = System.Drawing.Color.Black
        Me.txtTotalCanjes.Location = New System.Drawing.Point(565, 67)
        Me.txtTotalCanjes.Multiline = True
        Me.txtTotalCanjes.Name = "txtTotalCanjes"
        Me.txtTotalCanjes.Size = New System.Drawing.Size(58, 20)
        Me.txtTotalCanjes.TabIndex = 343
        Me.txtTotalCanjes.Text = "3.43"
        Me.txtTotalCanjes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(560, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 42)
        Me.Label7.TabIndex = 342
        Me.Label7.Text = "Total Canjes:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 25.0!)
        Me.Label23.ForeColor = System.Drawing.Color.Silver
        Me.Label23.Location = New System.Drawing.Point(44, 47)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(540, 40)
        Me.Label23.TabIndex = 345
        Me.Label23.Text = "NO SE HAN REGISTRADO PAGOS"
        Me.Label23.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtDiferenciaL)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Controls.Add(Me.txtTotalHaberL)
        Me.GroupBox7.Controls.Add(Me.Label30)
        Me.GroupBox7.Controls.Add(Me.txtTotalDebeL)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.dgvCuentasLetras)
        Me.GroupBox7.Location = New System.Drawing.Point(23, 419)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(629, 143)
        Me.GroupBox7.TabIndex = 215
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "ASIENTOS DEL CANJE"
        '
        'txtDiferenciaL
        '
        Me.txtDiferenciaL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiferenciaL.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiferenciaL.ForeColor = System.Drawing.Color.Black
        Me.txtDiferenciaL.Location = New System.Drawing.Point(541, 119)
        Me.txtDiferenciaL.Multiline = True
        Me.txtDiferenciaL.Name = "txtDiferenciaL"
        Me.txtDiferenciaL.Size = New System.Drawing.Size(82, 20)
        Me.txtDiferenciaL.TabIndex = 349
        Me.txtDiferenciaL.Text = "0.00"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(538, 100)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(65, 16)
        Me.Label27.TabIndex = 348
        Me.Label27.Text = "Diferencia:"
        '
        'txtTotalHaberL
        '
        Me.txtTotalHaberL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalHaberL.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHaberL.ForeColor = System.Drawing.Color.Black
        Me.txtTotalHaberL.Location = New System.Drawing.Point(541, 77)
        Me.txtTotalHaberL.Multiline = True
        Me.txtTotalHaberL.Name = "txtTotalHaberL"
        Me.txtTotalHaberL.Size = New System.Drawing.Size(82, 20)
        Me.txtTotalHaberL.TabIndex = 347
        Me.txtTotalHaberL.Text = "0.00"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(538, 58)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(74, 16)
        Me.Label30.TabIndex = 346
        Me.Label30.Text = "Total Haber:"
        '
        'txtTotalDebeL
        '
        Me.txtTotalDebeL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalDebeL.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDebeL.ForeColor = System.Drawing.Color.Black
        Me.txtTotalDebeL.Location = New System.Drawing.Point(541, 35)
        Me.txtTotalDebeL.Multiline = True
        Me.txtTotalDebeL.Name = "txtTotalDebeL"
        Me.txtTotalDebeL.Size = New System.Drawing.Size(82, 20)
        Me.txtTotalDebeL.TabIndex = 345
        Me.txtTotalDebeL.Text = "0.00"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(538, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(70, 16)
        Me.Label31.TabIndex = 344
        Me.Label31.Text = "Total Debe:"
        '
        'dgvCuentasLetras
        '
        Me.dgvCuentasLetras.AllowUserToAddRows = False
        Me.dgvCuentasLetras.BackgroundColor = System.Drawing.Color.White
        Me.dgvCuentasLetras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCuentasLetras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCuentasLetras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.dgvCuentasLetras.ColumnHeadersHeight = 30
        Me.dgvCuentasLetras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCuentasLetras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuentaL, Me.glosaL, Me.debeL, Me.haberL})
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCuentasLetras.DefaultCellStyle = DataGridViewCellStyle29
        Me.dgvCuentasLetras.Location = New System.Drawing.Point(6, 20)
        Me.dgvCuentasLetras.Name = "dgvCuentasLetras"
        Me.dgvCuentasLetras.RowHeadersVisible = False
        Me.dgvCuentasLetras.Size = New System.Drawing.Size(529, 117)
        Me.dgvCuentasLetras.TabIndex = 274
        '
        'cuentaL
        '
        Me.cuentaL.DataPropertyName = "cuentaL"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cuentaL.DefaultCellStyle = DataGridViewCellStyle26
        Me.cuentaL.HeaderText = "N° CTA."
        Me.cuentaL.Name = "cuentaL"
        Me.cuentaL.Width = 65
        '
        'glosaL
        '
        Me.glosaL.DataPropertyName = "glosaL"
        Me.glosaL.HeaderText = "DESCRIPCIÓN"
        Me.glosaL.Name = "glosaL"
        Me.glosaL.Width = 286
        '
        'debeL
        '
        Me.debeL.DataPropertyName = "debeL"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Format = "N2"
        DataGridViewCellStyle27.NullValue = Nothing
        Me.debeL.DefaultCellStyle = DataGridViewCellStyle27
        Me.debeL.HeaderText = "DEBE"
        Me.debeL.Name = "debeL"
        Me.debeL.Width = 80
        '
        'haberL
        '
        Me.haberL.DataPropertyName = "haberL"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.Format = "N2"
        DataGridViewCellStyle28.NullValue = Nothing
        Me.haberL.DefaultCellStyle = DataGridViewCellStyle28
        Me.haberL.HeaderText = "HABER"
        Me.haberL.Name = "haberL"
        Me.haberL.Width = 80
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtTipoOperacion2)
        Me.GroupBox8.Controls.Add(Me.Label32)
        Me.GroupBox8.Controls.Add(Me.txtGlosa2)
        Me.GroupBox8.Controls.Add(Me.Label33)
        Me.GroupBox8.Controls.Add(Me.txtDeuda2)
        Me.GroupBox8.Controls.Add(Me.Label34)
        Me.GroupBox8.Controls.Add(Me.txtTotal2)
        Me.GroupBox8.Controls.Add(Me.Label35)
        Me.GroupBox8.Controls.Add(Me.txtTc2)
        Me.GroupBox8.Controls.Add(Me.txtMoneda2)
        Me.GroupBox8.Controls.Add(Me.txtFechaPago2)
        Me.GroupBox8.Controls.Add(Me.txtFechaEmision2)
        Me.GroupBox8.Controls.Add(Me.txtFormaPago2)
        Me.GroupBox8.Controls.Add(Me.txtRazon2)
        Me.GroupBox8.Controls.Add(Me.txtRuc2)
        Me.GroupBox8.Controls.Add(Me.txtNumero2)
        Me.GroupBox8.Controls.Add(Me.txtSerie2)
        Me.GroupBox8.Controls.Add(Me.txtTipoDocumento2)
        Me.GroupBox8.Controls.Add(Me.Label36)
        Me.GroupBox8.Controls.Add(Me.Label37)
        Me.GroupBox8.Controls.Add(Me.Label38)
        Me.GroupBox8.Controls.Add(Me.Label39)
        Me.GroupBox8.Controls.Add(Me.Label40)
        Me.GroupBox8.Controls.Add(Me.Label41)
        Me.GroupBox8.Controls.Add(Me.Label42)
        Me.GroupBox8.Controls.Add(Me.Label43)
        Me.GroupBox8.Controls.Add(Me.Label44)
        Me.GroupBox8.Controls.Add(Me.Label45)
        Me.GroupBox8.Location = New System.Drawing.Point(23, 59)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(629, 150)
        Me.GroupBox8.TabIndex = 214
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "DATOS DEL COMPROBANTE DE COMPRA"
        '
        'txtTipoOperacion2
        '
        Me.txtTipoOperacion2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTipoOperacion2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoOperacion2.ForeColor = System.Drawing.Color.Black
        Me.txtTipoOperacion2.Location = New System.Drawing.Point(246, 124)
        Me.txtTipoOperacion2.Multiline = True
        Me.txtTipoOperacion2.Name = "txtTipoOperacion2"
        Me.txtTipoOperacion2.Size = New System.Drawing.Size(377, 20)
        Me.txtTipoOperacion2.TabIndex = 345
        Me.txtTipoOperacion2.Text = "[DATO CAMPO]"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(243, 105)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(113, 16)
        Me.Label32.TabIndex = 344
        Me.Label32.Text = "Tipo de Operación:"
        '
        'txtGlosa2
        '
        Me.txtGlosa2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGlosa2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa2.ForeColor = System.Drawing.Color.Black
        Me.txtGlosa2.Location = New System.Drawing.Point(6, 124)
        Me.txtGlosa2.Multiline = True
        Me.txtGlosa2.Name = "txtGlosa2"
        Me.txtGlosa2.Size = New System.Drawing.Size(234, 20)
        Me.txtGlosa2.TabIndex = 343
        Me.txtGlosa2.Text = "[DATO CAMPO]"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label33.Location = New System.Drawing.Point(3, 105)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(42, 16)
        Me.Label33.TabIndex = 342
        Me.Label33.Text = "Glosa:"
        '
        'txtDeuda2
        '
        Me.txtDeuda2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDeuda2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeuda2.ForeColor = System.Drawing.Color.Red
        Me.txtDeuda2.Location = New System.Drawing.Point(541, 80)
        Me.txtDeuda2.Multiline = True
        Me.txtDeuda2.Name = "txtDeuda2"
        Me.txtDeuda2.Size = New System.Drawing.Size(82, 20)
        Me.txtDeuda2.TabIndex = 341
        Me.txtDeuda2.Text = "3.43"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(538, 61)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(78, 16)
        Me.Label34.TabIndex = 340
        Me.Label34.Text = "Total Deuda:"
        '
        'txtTotal2
        '
        Me.txtTotal2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal2.ForeColor = System.Drawing.Color.Black
        Me.txtTotal2.Location = New System.Drawing.Point(453, 80)
        Me.txtTotal2.Multiline = True
        Me.txtTotal2.Name = "txtTotal2"
        Me.txtTotal2.Size = New System.Drawing.Size(82, 20)
        Me.txtTotal2.TabIndex = 339
        Me.txtTotal2.Text = "3.43"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(450, 61)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(85, 16)
        Me.Label35.TabIndex = 338
        Me.Label35.Text = "Total Compra:"
        '
        'txtTc2
        '
        Me.txtTc2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTc2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTc2.ForeColor = System.Drawing.Color.Black
        Me.txtTc2.Location = New System.Drawing.Point(409, 80)
        Me.txtTc2.Multiline = True
        Me.txtTc2.Name = "txtTc2"
        Me.txtTc2.Size = New System.Drawing.Size(38, 20)
        Me.txtTc2.TabIndex = 337
        Me.txtTc2.Text = "3.43"
        '
        'txtMoneda2
        '
        Me.txtMoneda2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMoneda2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMoneda2.ForeColor = System.Drawing.Color.Black
        Me.txtMoneda2.Location = New System.Drawing.Point(346, 80)
        Me.txtMoneda2.Multiline = True
        Me.txtMoneda2.Name = "txtMoneda2"
        Me.txtMoneda2.Size = New System.Drawing.Size(57, 20)
        Me.txtMoneda2.TabIndex = 336
        Me.txtMoneda2.Text = "PEN"
        '
        'txtFechaPago2
        '
        Me.txtFechaPago2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaPago2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaPago2.ForeColor = System.Drawing.Color.Red
        Me.txtFechaPago2.Location = New System.Drawing.Point(146, 80)
        Me.txtFechaPago2.Multiline = True
        Me.txtFechaPago2.Name = "txtFechaPago2"
        Me.txtFechaPago2.Size = New System.Drawing.Size(94, 20)
        Me.txtFechaPago2.TabIndex = 335
        Me.txtFechaPago2.Text = "[DATO CAMPO]"
        '
        'txtFechaEmision2
        '
        Me.txtFechaEmision2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaEmision2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaEmision2.ForeColor = System.Drawing.Color.Black
        Me.txtFechaEmision2.Location = New System.Drawing.Point(6, 80)
        Me.txtFechaEmision2.Multiline = True
        Me.txtFechaEmision2.Name = "txtFechaEmision2"
        Me.txtFechaEmision2.Size = New System.Drawing.Size(134, 20)
        Me.txtFechaEmision2.TabIndex = 334
        Me.txtFechaEmision2.Text = "[DATO CAMPO]"
        '
        'txtFormaPago2
        '
        Me.txtFormaPago2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFormaPago2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormaPago2.ForeColor = System.Drawing.Color.Black
        Me.txtFormaPago2.Location = New System.Drawing.Point(246, 80)
        Me.txtFormaPago2.Multiline = True
        Me.txtFormaPago2.Name = "txtFormaPago2"
        Me.txtFormaPago2.Size = New System.Drawing.Size(94, 20)
        Me.txtFormaPago2.TabIndex = 333
        Me.txtFormaPago2.Text = "[DATO CAMPO]"
        '
        'txtRazon2
        '
        Me.txtRazon2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRazon2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazon2.ForeColor = System.Drawing.Color.Black
        Me.txtRazon2.Location = New System.Drawing.Point(306, 36)
        Me.txtRazon2.Multiline = True
        Me.txtRazon2.Name = "txtRazon2"
        Me.txtRazon2.Size = New System.Drawing.Size(317, 20)
        Me.txtRazon2.TabIndex = 332
        Me.txtRazon2.Text = "[DATO CAMPO]"
        '
        'txtRuc2
        '
        Me.txtRuc2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRuc2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc2.ForeColor = System.Drawing.Color.Black
        Me.txtRuc2.Location = New System.Drawing.Point(231, 36)
        Me.txtRuc2.Multiline = True
        Me.txtRuc2.Name = "txtRuc2"
        Me.txtRuc2.Size = New System.Drawing.Size(69, 20)
        Me.txtRuc2.TabIndex = 331
        Me.txtRuc2.Text = "00000000000"
        '
        'txtNumero2
        '
        Me.txtNumero2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumero2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero2.ForeColor = System.Drawing.Color.Black
        Me.txtNumero2.Location = New System.Drawing.Point(178, 36)
        Me.txtNumero2.Multiline = True
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(47, 20)
        Me.txtNumero2.TabIndex = 330
        Me.txtNumero2.Text = "[DATO CAMPO]"
        '
        'txtSerie2
        '
        Me.txtSerie2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSerie2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie2.ForeColor = System.Drawing.Color.Black
        Me.txtSerie2.Location = New System.Drawing.Point(125, 36)
        Me.txtSerie2.Multiline = True
        Me.txtSerie2.Name = "txtSerie2"
        Me.txtSerie2.Size = New System.Drawing.Size(47, 20)
        Me.txtSerie2.TabIndex = 329
        Me.txtSerie2.Text = "[DATO CAMPO]"
        '
        'txtTipoDocumento2
        '
        Me.txtTipoDocumento2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTipoDocumento2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoDocumento2.ForeColor = System.Drawing.Color.Black
        Me.txtTipoDocumento2.Location = New System.Drawing.Point(6, 36)
        Me.txtTipoDocumento2.Multiline = True
        Me.txtTipoDocumento2.Name = "txtTipoDocumento2"
        Me.txtTipoDocumento2.Size = New System.Drawing.Size(113, 20)
        Me.txtTipoDocumento2.TabIndex = 328
        Me.txtTipoDocumento2.Text = "[DATO CAMPO]"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(143, 61)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(78, 16)
        Me.Label36.TabIndex = 327
        Me.Label36.Text = "Fecha pago:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(3, 61)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(87, 16)
        Me.Label37.TabIndex = 325
        Me.Label37.Text = "Fecha emisión:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(409, 61)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(28, 16)
        Me.Label38.TabIndex = 322
        Me.Label38.Text = "T.C:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label39.Location = New System.Drawing.Point(344, 61)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(59, 16)
        Me.Label39.TabIndex = 323
        Me.Label39.Text = "Moneda:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label40.Location = New System.Drawing.Point(243, 61)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(77, 16)
        Me.Label40.TabIndex = 319
        Me.Label40.Text = "Forma pago:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label41.Location = New System.Drawing.Point(122, 17)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(36, 16)
        Me.Label41.TabIndex = 317
        Me.Label41.Text = "Serie:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(228, 17)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(35, 16)
        Me.Label42.TabIndex = 313
        Me.Label42.Text = "RUC:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(3, 17)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(100, 16)
        Me.Label43.TabIndex = 315
        Me.Label43.Text = "Tipo Documento:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(175, 17)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(23, 16)
        Me.Label44.TabIndex = 316
        Me.Label44.Text = "N°:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(303, 17)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(80, 16)
        Me.Label45.TabIndex = 314
        Me.Label45.Text = "Razón Social:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Presentacion.My.Resources.Resources.cerrar_detalle
        Me.PictureBox2.Location = New System.Drawing.Point(6, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 213
        Me.PictureBox2.TabStop = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label46.Location = New System.Drawing.Point(146, 16)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(266, 33)
        Me.Label46.TabIndex = 212
        Me.Label46.Text = "LETRAS CANJEADAS"
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.id.DefaultCellStyle = DataGridViewCellStyle1
        Me.id.HeaderText = "N°"
        Me.id.Name = "id"
        Me.id.Width = 50
        '
        'tipo_compra
        '
        Me.tipo_compra.DataPropertyName = "tipo_compra"
        Me.tipo_compra.HeaderText = "TIPO"
        Me.tipo_compra.Name = "tipo_compra"
        Me.tipo_compra.Width = 70
        '
        'estadoCompra
        '
        Me.estadoCompra.DataPropertyName = "estadoCompra"
        Me.estadoCompra.HeaderText = "DEUDA"
        Me.estadoCompra.Name = "estadoCompra"
        '
        'id_tipo_comprobante
        '
        Me.id_tipo_comprobante.DataPropertyName = "id_tipo_comprobante"
        Me.id_tipo_comprobante.HeaderText = "id_tipo_comprobante"
        Me.id_tipo_comprobante.Name = "id_tipo_comprobante"
        Me.id_tipo_comprobante.Visible = False
        '
        'sujeto
        '
        Me.sujeto.DataPropertyName = "sujeto"
        Me.sujeto.HeaderText = "SUJETO A"
        Me.sujeto.Name = "sujeto"
        '
        'comprobante
        '
        Me.comprobante.DataPropertyName = "comprobante"
        Me.comprobante.HeaderText = "COMPROB."
        Me.comprobante.Name = "comprobante"
        Me.comprobante.Width = 80
        '
        'serie
        '
        Me.serie.DataPropertyName = "serie"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.serie.DefaultCellStyle = DataGridViewCellStyle2
        Me.serie.HeaderText = "SERIE"
        Me.serie.Name = "serie"
        Me.serie.Width = 50
        '
        'numero
        '
        Me.numero.DataPropertyName = "numero"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.numero.DefaultCellStyle = DataGridViewCellStyle3
        Me.numero.HeaderText = "NUM."
        Me.numero.Name = "numero"
        Me.numero.Width = 50
        '
        'num_dni
        '
        Me.num_dni.DataPropertyName = "num_dni"
        Me.num_dni.HeaderText = "DNI/RUC"
        Me.num_dni.Name = "num_dni"
        Me.num_dni.Width = 80
        '
        'razon_social
        '
        Me.razon_social.DataPropertyName = "razon_social"
        Me.razon_social.HeaderText = "PROVEEDOR"
        Me.razon_social.Name = "razon_social"
        Me.razon_social.Width = 200
        '
        'moneda
        '
        Me.moneda.DataPropertyName = "moneda"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.moneda.DefaultCellStyle = DataGridViewCellStyle4
        Me.moneda.HeaderText = "MND."
        Me.moneda.Name = "moneda"
        Me.moneda.Width = 50
        '
        'tc
        '
        Me.tc.DataPropertyName = "tc"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.tc.DefaultCellStyle = DataGridViewCellStyle5
        Me.tc.HeaderText = "T.C."
        Me.tc.Name = "tc"
        Me.tc.Width = 50
        '
        'monto
        '
        Me.monto.DataPropertyName = "monto"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.monto.DefaultCellStyle = DataGridViewCellStyle6
        Me.monto.HeaderText = "MONTO"
        Me.monto.Name = "monto"
        Me.monto.Width = 70
        '
        'igv
        '
        Me.igv.DataPropertyName = "igv"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.igv.DefaultCellStyle = DataGridViewCellStyle7
        Me.igv.HeaderText = "IGV"
        Me.igv.Name = "igv"
        Me.igv.Width = 70
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.DefaultCellStyle = DataGridViewCellStyle8
        Me.total.HeaderText = "TOTAL"
        Me.total.Name = "total"
        Me.total.Width = 70
        '
        'abono
        '
        Me.abono.DataPropertyName = "abono"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abono.DefaultCellStyle = DataGridViewCellStyle9
        Me.abono.HeaderText = "ABONO"
        Me.abono.Name = "abono"
        Me.abono.Width = 70
        '
        'gravado
        '
        Me.gravado.DataPropertyName = "gravado"
        Me.gravado.HeaderText = "GRAVADO"
        Me.gravado.Name = "gravado"
        Me.gravado.Width = 150
        '
        'glosa
        '
        Me.glosa.DataPropertyName = "glosa"
        Me.glosa.HeaderText = "GLOSA"
        Me.glosa.Name = "glosa"
        Me.glosa.Width = 200
        '
        'fec_emision
        '
        Me.fec_emision.DataPropertyName = "fec_emision"
        Me.fec_emision.HeaderText = "EMISION"
        Me.fec_emision.Name = "fec_emision"
        Me.fec_emision.Width = 70
        '
        'fec_pago
        '
        Me.fec_pago.DataPropertyName = "fec_pago"
        Me.fec_pago.HeaderText = "PAGO"
        Me.fec_pago.Name = "fec_pago"
        Me.fec_pago.Width = 70
        '
        'estado_comprobante
        '
        Me.estado_comprobante.DataPropertyName = "estado_comprobante"
        Me.estado_comprobante.HeaderText = "estado_comprobante"
        Me.estado_comprobante.Name = "estado_comprobante"
        Me.estado_comprobante.Visible = False
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "ESTADO"
        Me.estado.Name = "estado"
        Me.estado.Width = 75
        '
        'centro_costo
        '
        Me.centro_costo.DataPropertyName = "centro_costo"
        Me.centro_costo.HeaderText = "centro_costo"
        Me.centro_costo.Name = "centro_costo"
        Me.centro_costo.Visible = False
        '
        'frmListaComprobanteCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.Controls.Add(Me.panelDetalle)
        Me.Controls.Add(Me.PanelLetra)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnLDCompra)
        Me.Controls.Add(Me.grupoBusqueda)
        Me.Controls.Add(Me.btnCanje)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.btnPagos)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnDebito)
        Me.Controls.Add(Me.btnCredito)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmListaComprobanteCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panelDetalle.ResumeLayout(False)
        Me.panelDetalle.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvAsientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoBusqueda.ResumeLayout(False)
        Me.grupoBusqueda.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.PanelLetra.ResumeLayout(False)
        Me.PanelLetra.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvLetras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.dgvCuentasLetras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents Cliente As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents dtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dtDesde As System.Windows.Forms.DateTimePicker
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnFormatoCompra As System.Windows.Forms.Button
    Friend WithEvents btnGenerarPle As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCanje As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents btnPagos As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnDebito As System.Windows.Forms.Button
    Friend WithEvents btnCredito As System.Windows.Forms.Button
    Friend WithEvents grupoBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents btnLDCompra As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents lblTotal As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents lblIgv As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents lblMontos As System.Windows.Forms.Label
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDolares As System.Windows.Forms.CheckBox
    Friend WithEvents chkSoles As System.Windows.Forms.CheckBox
    Private WithEvents lblMoneda As System.Windows.Forms.Label
    Private WithEvents lblNumRegistros As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents panelDetalle As System.Windows.Forms.Panel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblTipoDeCambio As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents txtRazon As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtFechaPago As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaEmision As System.Windows.Forms.TextBox
    Friend WithEvents txtFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents txtTc As System.Windows.Forms.TextBox
    Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDeuda As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dgvAsientos As System.Windows.Forms.DataGridView
    Friend WithEvents txtTipoOperacion As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtGlosa As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dgvPagos As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalAbonos As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalAbono As System.Windows.Forms.Label
    Friend WithEvents txtDiferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblNoPagos As System.Windows.Forms.Label
    Friend WithEvents fecha_abono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa_abono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda_abono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto_abono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc_cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelLetra As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvLetras As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalCanjes As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDiferenciaL As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtTotalHaberL As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtTotalDebeL As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents dgvCuentasLetras As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTipoOperacion2 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtGlosa2 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtDeuda2 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtTotal2 As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtTc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMoneda2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaPago2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaEmision2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFormaPago2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRazon2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRuc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSerie2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoDocumento2 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents cuentaL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosaL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents debeL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents haberL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCanjear As System.Windows.Forms.Button
    Friend WithEvents idL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_emisionL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_vencimientoL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents montoL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serieL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numeroL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents librado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lugar_giro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aval As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_compra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estadoCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sujeto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents razon_social As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents igv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents abono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gravado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents glosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_emision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fec_pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents centro_costo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
