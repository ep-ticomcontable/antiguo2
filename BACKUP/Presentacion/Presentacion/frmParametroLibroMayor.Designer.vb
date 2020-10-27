<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParametroLibroMayor
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
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.txtDigitos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHojaTrabajo = New System.Windows.Forms.Button()
        Me.btnVerLibroMayor = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSD = New System.Windows.Forms.Label()
        Me.lblSH = New System.Windows.Forms.Label()
        Me.btnGenerarPLE = New System.Windows.Forms.Button()
        Me.btnGeneral = New System.Windows.Forms.Button()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(148, 21)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(109, 23)
        Me.btnEnviar.TabIndex = 0
        Me.btnEnviar.Text = "Mostrar registros"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'dgvLista
        '
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Location = New System.Drawing.Point(12, 50)
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.Size = New System.Drawing.Size(657, 276)
        Me.dgvLista.TabIndex = 1
        '
        'txtDigitos
        '
        Me.txtDigitos.Location = New System.Drawing.Point(86, 23)
        Me.txtDigitos.MaxLength = 5
        Me.txtDigitos.Name = "txtDigitos"
        Me.txtDigitos.Size = New System.Drawing.Size(56, 20)
        Me.txtDigitos.TabIndex = 2
        Me.txtDigitos.Text = "3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "# de dígitos:"
        '
        'btnHojaTrabajo
        '
        Me.btnHojaTrabajo.Location = New System.Drawing.Point(642, 21)
        Me.btnHojaTrabajo.Name = "btnHojaTrabajo"
        Me.btnHojaTrabajo.Size = New System.Drawing.Size(109, 23)
        Me.btnHojaTrabajo.TabIndex = 4
        Me.btnHojaTrabajo.Text = "Hoja de Trabajo"
        Me.btnHojaTrabajo.UseVisualStyleBackColor = True
        '
        'btnVerLibroMayor
        '
        Me.btnVerLibroMayor.Location = New System.Drawing.Point(527, 21)
        Me.btnVerLibroMayor.Name = "btnVerLibroMayor"
        Me.btnVerLibroMayor.Size = New System.Drawing.Size(109, 23)
        Me.btnVerLibroMayor.TabIndex = 5
        Me.btnVerLibroMayor.Text = "Libro Mayor"
        Me.btnVerLibroMayor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(675, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Suma Debe:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(675, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Suma Haber:"
        '
        'lblSD
        '
        Me.lblSD.AutoSize = True
        Me.lblSD.ForeColor = System.Drawing.Color.Blue
        Me.lblSD.Location = New System.Drawing.Point(675, 83)
        Me.lblSD.Name = "lblSD"
        Me.lblSD.Size = New System.Drawing.Size(66, 13)
        Me.lblSD.TabIndex = 10
        Me.lblSD.Text = "Suma Debe:"
        '
        'lblSH
        '
        Me.lblSH.AutoSize = True
        Me.lblSH.ForeColor = System.Drawing.Color.Blue
        Me.lblSH.Location = New System.Drawing.Point(675, 159)
        Me.lblSH.Name = "lblSH"
        Me.lblSH.Size = New System.Drawing.Size(66, 13)
        Me.lblSH.TabIndex = 11
        Me.lblSH.Text = "Suma Debe:"
        '
        'btnGenerarPLE
        '
        Me.btnGenerarPLE.Location = New System.Drawing.Point(441, 21)
        Me.btnGenerarPLE.Name = "btnGenerarPLE"
        Me.btnGenerarPLE.Size = New System.Drawing.Size(80, 23)
        Me.btnGenerarPLE.TabIndex = 7
        Me.btnGenerarPLE.Text = "Lista PLE"
        Me.btnGenerarPLE.UseVisualStyleBackColor = True
        '
        'btnGeneral
        '
        Me.btnGeneral.Location = New System.Drawing.Point(309, 20)
        Me.btnGeneral.Name = "btnGeneral"
        Me.btnGeneral.Size = New System.Drawing.Size(126, 23)
        Me.btnGeneral.TabIndex = 12
        Me.btnGeneral.Text = "BALANCE GENERAL"
        Me.btnGeneral.UseVisualStyleBackColor = True
        '
        'frmParametroLibroMayor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 338)
        Me.Controls.Add(Me.btnGeneral)
        Me.Controls.Add(Me.lblSH)
        Me.Controls.Add(Me.lblSD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerarPLE)
        Me.Controls.Add(Me.btnVerLibroMayor)
        Me.Controls.Add(Me.btnHojaTrabajo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDigitos)
        Me.Controls.Add(Me.dgvLista)
        Me.Controls.Add(Me.btnEnviar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmParametroLibroMayor"
        Me.Text = "Parámetrización para el Libro Mayor"
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents dgvLista As System.Windows.Forms.DataGridView
    Friend WithEvents txtDigitos As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHojaTrabajo As System.Windows.Forms.Button
    Friend WithEvents btnVerLibroMayor As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSD As System.Windows.Forms.Label
    Friend WithEvents lblSH As System.Windows.Forms.Label
    Friend WithEvents btnGenerarPLE As System.Windows.Forms.Button
    Friend WithEvents btnGeneral As System.Windows.Forms.Button
End Class
