<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutos
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
        Me.lblNumeroChapa = New System.Windows.Forms.Label()
        Me.txtChapa = New System.Windows.Forms.TextBox()
        Me.lblAnho = New System.Windows.Forms.Label()
        Me.ltbTipoAuto = New System.Windows.Forms.ListBox()
        Me.rdbManual = New System.Windows.Forms.RadioButton()
        Me.rdbAutomatico = New System.Windows.Forms.RadioButton()
        Me.gbxTipoCambio = New System.Windows.Forms.GroupBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.lblTipoAuto = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblImpuesto = New System.Windows.Forms.Label()
        Me.nudPrecio = New System.Windows.Forms.NumericUpDown()
        Me.nudImpuesto = New System.Windows.Forms.NumericUpDown()
        Me.nudAnho = New System.Windows.Forms.NumericUpDown()
        Me.gbxTipoCambio.SuspendLayout()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudImpuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAnho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumeroChapa
        '
        Me.lblNumeroChapa.AutoSize = True
        Me.lblNumeroChapa.Location = New System.Drawing.Point(24, 19)
        Me.lblNumeroChapa.Name = "lblNumeroChapa"
        Me.lblNumeroChapa.Size = New System.Drawing.Size(50, 13)
        Me.lblNumeroChapa.TabIndex = 0
        Me.lblNumeroChapa.Text = "N°Chapa"
        '
        'txtChapa
        '
        Me.txtChapa.Location = New System.Drawing.Point(80, 16)
        Me.txtChapa.Name = "txtChapa"
        Me.txtChapa.Size = New System.Drawing.Size(166, 20)
        Me.txtChapa.TabIndex = 1
        '
        'lblAnho
        '
        Me.lblAnho.AutoSize = True
        Me.lblAnho.Location = New System.Drawing.Point(24, 60)
        Me.lblAnho.Name = "lblAnho"
        Me.lblAnho.Size = New System.Drawing.Size(26, 13)
        Me.lblAnho.TabIndex = 2
        Me.lblAnho.Text = "Año"
        '
        'ltbTipoAuto
        '
        Me.ltbTipoAuto.FormattingEnabled = True
        Me.ltbTipoAuto.Location = New System.Drawing.Point(80, 148)
        Me.ltbTipoAuto.Name = "ltbTipoAuto"
        Me.ltbTipoAuto.Size = New System.Drawing.Size(166, 95)
        Me.ltbTipoAuto.TabIndex = 7
        '
        'rdbManual
        '
        Me.rdbManual.AutoSize = True
        Me.rdbManual.Location = New System.Drawing.Point(15, 24)
        Me.rdbManual.Name = "rdbManual"
        Me.rdbManual.Size = New System.Drawing.Size(60, 17)
        Me.rdbManual.TabIndex = 0
        Me.rdbManual.TabStop = True
        Me.rdbManual.Text = "Manual"
        Me.rdbManual.UseVisualStyleBackColor = True
        '
        'rdbAutomatico
        '
        Me.rdbAutomatico.AutoSize = True
        Me.rdbAutomatico.Location = New System.Drawing.Point(110, 24)
        Me.rdbAutomatico.Name = "rdbAutomatico"
        Me.rdbAutomatico.Size = New System.Drawing.Size(78, 17)
        Me.rdbAutomatico.TabIndex = 1
        Me.rdbAutomatico.TabStop = True
        Me.rdbAutomatico.Text = "Automático"
        Me.rdbAutomatico.UseVisualStyleBackColor = True
        '
        'gbxTipoCambio
        '
        Me.gbxTipoCambio.Controls.Add(Me.rdbAutomatico)
        Me.gbxTipoCambio.Controls.Add(Me.rdbManual)
        Me.gbxTipoCambio.Location = New System.Drawing.Point(12, 262)
        Me.gbxTipoCambio.Name = "gbxTipoCambio"
        Me.gbxTipoCambio.Size = New System.Drawing.Size(234, 73)
        Me.gbxTipoCambio.TabIndex = 8
        Me.gbxTipoCambio.TabStop = False
        Me.gbxTipoCambio.Text = "Tipo Cambio"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(195, 425)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(291, 425)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(21, 102)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(37, 13)
        Me.lblMarca.TabIndex = 4
        Me.lblMarca.Text = "Marca"
        '
        'cboMarca
        '
        Me.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(80, 99)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(166, 21)
        Me.cboMarca.TabIndex = 5
        '
        'lblTipoAuto
        '
        Me.lblTipoAuto.AutoSize = True
        Me.lblTipoAuto.Location = New System.Drawing.Point(21, 148)
        Me.lblTipoAuto.Name = "lblTipoAuto"
        Me.lblTipoAuto.Size = New System.Drawing.Size(53, 13)
        Me.lblTipoAuto.TabIndex = 6
        Me.lblTipoAuto.Text = "Tipo Auto"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(24, 359)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 9
        Me.lblPrecio.Text = "Precio"
        '
        'lblImpuesto
        '
        Me.lblImpuesto.AutoSize = True
        Me.lblImpuesto.Location = New System.Drawing.Point(24, 390)
        Me.lblImpuesto.Name = "lblImpuesto"
        Me.lblImpuesto.Size = New System.Drawing.Size(50, 13)
        Me.lblImpuesto.TabIndex = 11
        Me.lblImpuesto.Text = "Impuesto"
        '
        'nudPrecio
        '
        Me.nudPrecio.Location = New System.Drawing.Point(109, 352)
        Me.nudPrecio.Maximum = New Decimal(New Integer() {1661992959, 1808227885, 5, 0})
        Me.nudPrecio.Name = "nudPrecio"
        Me.nudPrecio.Size = New System.Drawing.Size(120, 20)
        Me.nudPrecio.TabIndex = 10
        '
        'nudImpuesto
        '
        Me.nudImpuesto.Location = New System.Drawing.Point(109, 383)
        Me.nudImpuesto.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.nudImpuesto.Name = "nudImpuesto"
        Me.nudImpuesto.Size = New System.Drawing.Size(120, 20)
        Me.nudImpuesto.TabIndex = 12
        '
        'nudAnho
        '
        Me.nudAnho.Location = New System.Drawing.Point(80, 58)
        Me.nudAnho.Maximum = New Decimal(New Integer() {-1304428545, 434162106, 542, 0})
        Me.nudAnho.Name = "nudAnho"
        Me.nudAnho.Size = New System.Drawing.Size(166, 20)
        Me.nudAnho.TabIndex = 3
        '
        'frmAutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 460)
        Me.Controls.Add(Me.nudAnho)
        Me.Controls.Add(Me.nudImpuesto)
        Me.Controls.Add(Me.nudPrecio)
        Me.Controls.Add(Me.lblImpuesto)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.cboMarca)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gbxTipoCambio)
        Me.Controls.Add(Me.lblTipoAuto)
        Me.Controls.Add(Me.ltbTipoAuto)
        Me.Controls.Add(Me.lblAnho)
        Me.Controls.Add(Me.txtChapa)
        Me.Controls.Add(Me.lblNumeroChapa)
        Me.Name = "frmAutos"
        Me.Text = "frmAutos"
        Me.gbxTipoCambio.ResumeLayout(False)
        Me.gbxTipoCambio.PerformLayout()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudImpuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAnho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumeroChapa As Label
    Friend WithEvents txtChapa As TextBox
    Friend WithEvents lblAnho As Label
    Friend WithEvents ltbTipoAuto As ListBox
    Friend WithEvents rdbManual As RadioButton
    Friend WithEvents rdbAutomatico As RadioButton
    Friend WithEvents gbxTipoCambio As GroupBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblMarca As Label
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents lblTipoAuto As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblImpuesto As Label
    Friend WithEvents nudPrecio As NumericUpDown
    Friend WithEvents nudImpuesto As NumericUpDown
    Friend WithEvents nudAnho As NumericUpDown
End Class
