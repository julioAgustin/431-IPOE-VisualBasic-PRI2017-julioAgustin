<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulo))
        Me.tbcPrincipal = New System.Windows.Forms.TabControl()
        Me.tbpABM = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboTipoImpuesto = New System.Windows.Forms.ComboBox()
        Me.nudExistencia = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudExistenciaMin = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudExistenciaMax = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.nudPrecioCompra = New System.Windows.Forms.NumericUpDown()
        Me.nudPrecioVenta = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodArticulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbpConsulta = New System.Windows.Forms.TabPage()
        Me.nudCodigoConsulta = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtDescripcionConsulta = New System.Windows.Forms.TextBox()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.tbcPrincipal.SuspendLayout()
        Me.tbpABM.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudExistenciaMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudExistenciaMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrecioCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrecioVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpConsulta.SuspendLayout()
        CType(Me.nudCodigoConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcPrincipal
        '
        Me.tbcPrincipal.Controls.Add(Me.tbpABM)
        Me.tbcPrincipal.Controls.Add(Me.tbpConsulta)
        Me.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tbcPrincipal.Name = "tbcPrincipal"
        Me.tbcPrincipal.SelectedIndex = 0
        Me.tbcPrincipal.Size = New System.Drawing.Size(487, 404)
        Me.tbcPrincipal.TabIndex = 0
        '
        'tbpABM
        '
        Me.tbpABM.Controls.Add(Me.GroupBox1)
        Me.tbpABM.Controls.Add(Me.Label10)
        Me.tbpABM.Controls.Add(Me.cboUnidadMedida)
        Me.tbpABM.Controls.Add(Me.Label9)
        Me.tbpABM.Controls.Add(Me.cboTipoImpuesto)
        Me.tbpABM.Controls.Add(Me.nudExistencia)
        Me.tbpABM.Controls.Add(Me.Label8)
        Me.tbpABM.Controls.Add(Me.nudExistenciaMin)
        Me.tbpABM.Controls.Add(Me.Label7)
        Me.tbpABM.Controls.Add(Me.nudExistenciaMax)
        Me.tbpABM.Controls.Add(Me.Label6)
        Me.tbpABM.Controls.Add(Me.Label5)
        Me.tbpABM.Controls.Add(Me.cboProveedor)
        Me.tbpABM.Controls.Add(Me.nudPrecioCompra)
        Me.tbpABM.Controls.Add(Me.nudPrecioVenta)
        Me.tbpABM.Controls.Add(Me.Label4)
        Me.tbpABM.Controls.Add(Me.Label3)
        Me.tbpABM.Controls.Add(Me.txtDescripcion)
        Me.tbpABM.Controls.Add(Me.Label2)
        Me.tbpABM.Controls.Add(Me.txtCodArticulo)
        Me.tbpABM.Controls.Add(Me.Label1)
        Me.tbpABM.Location = New System.Drawing.Point(4, 22)
        Me.tbpABM.Name = "tbpABM"
        Me.tbpABM.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpABM.Size = New System.Drawing.Size(479, 378)
        Me.tbpABM.TabIndex = 0
        Me.tbpABM.Text = "ABM"
        Me.tbpABM.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnConfirmar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 65)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConfirmar.Location = New System.Drawing.Point(55, 16)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(87, 38)
        Me.btnConfirmar.TabIndex = 2
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(167, 16)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 38)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(285, 16)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 38)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Unidad Medida"
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.Location = New System.Drawing.Point(90, 251)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.Size = New System.Drawing.Size(143, 21)
        Me.cboUnidadMedida.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tipo Impuesto"
        '
        'cboTipoImpuesto
        '
        Me.cboTipoImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoImpuesto.FormattingEnabled = True
        Me.cboTipoImpuesto.Location = New System.Drawing.Point(90, 224)
        Me.cboTipoImpuesto.Name = "cboTipoImpuesto"
        Me.cboTipoImpuesto.Size = New System.Drawing.Size(144, 21)
        Me.cboTipoImpuesto.TabIndex = 16
        '
        'nudExistencia
        '
        Me.nudExistencia.Location = New System.Drawing.Point(90, 198)
        Me.nudExistencia.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudExistencia.Name = "nudExistencia"
        Me.nudExistencia.Size = New System.Drawing.Size(71, 20)
        Me.nudExistencia.TabIndex = 15
        Me.nudExistencia.ThousandsSeparator = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Existencia"
        '
        'nudExistenciaMin
        '
        Me.nudExistenciaMin.Location = New System.Drawing.Point(91, 172)
        Me.nudExistenciaMin.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudExistenciaMin.Name = "nudExistenciaMin"
        Me.nudExistenciaMin.Size = New System.Drawing.Size(71, 20)
        Me.nudExistenciaMin.TabIndex = 13
        Me.nudExistenciaMin.ThousandsSeparator = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Existencia Min"
        '
        'nudExistenciaMax
        '
        Me.nudExistenciaMax.Location = New System.Drawing.Point(91, 146)
        Me.nudExistenciaMax.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudExistenciaMax.Name = "nudExistenciaMax"
        Me.nudExistenciaMax.Size = New System.Drawing.Size(71, 20)
        Me.nudExistenciaMax.TabIndex = 11
        Me.nudExistenciaMax.ThousandsSeparator = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Existencia Max"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Proveedor"
        '
        'cboProveedor
        '
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(90, 119)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(225, 21)
        Me.cboProveedor.TabIndex = 8
        '
        'nudPrecioCompra
        '
        Me.nudPrecioCompra.Location = New System.Drawing.Point(91, 93)
        Me.nudPrecioCompra.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPrecioCompra.Name = "nudPrecioCompra"
        Me.nudPrecioCompra.Size = New System.Drawing.Size(120, 20)
        Me.nudPrecioCompra.TabIndex = 7
        Me.nudPrecioCompra.ThousandsSeparator = True
        '
        'nudPrecioVenta
        '
        Me.nudPrecioVenta.Location = New System.Drawing.Point(91, 66)
        Me.nudPrecioVenta.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPrecioVenta.Name = "nudPrecioVenta"
        Me.nudPrecioVenta.Size = New System.Drawing.Size(120, 20)
        Me.nudPrecioVenta.TabIndex = 6
        Me.nudPrecioVenta.ThousandsSeparator = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Precio Compra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio Venta"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(91, 39)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(224, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción"
        '
        'txtCodArticulo
        '
        Me.txtCodArticulo.Location = New System.Drawing.Point(91, 13)
        Me.txtCodArticulo.Name = "txtCodArticulo"
        Me.txtCodArticulo.ReadOnly = True
        Me.txtCodArticulo.Size = New System.Drawing.Size(127, 20)
        Me.txtCodArticulo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cód. Articulo"
        '
        'tbpConsulta
        '
        Me.tbpConsulta.Controls.Add(Me.nudCodigoConsulta)
        Me.tbpConsulta.Controls.Add(Me.Label12)
        Me.tbpConsulta.Controls.Add(Me.Label11)
        Me.tbpConsulta.Controls.Add(Me.btnBuscar)
        Me.tbpConsulta.Controls.Add(Me.txtDescripcionConsulta)
        Me.tbpConsulta.Controls.Add(Me.dgvConsulta)
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpConsulta.Size = New System.Drawing.Size(479, 378)
        Me.tbpConsulta.TabIndex = 1
        Me.tbpConsulta.Text = "Consulta"
        Me.tbpConsulta.UseVisualStyleBackColor = True
        '
        'nudCodigoConsulta
        '
        Me.nudCodigoConsulta.Location = New System.Drawing.Point(100, 59)
        Me.nudCodigoConsulta.Name = "nudCodigoConsulta"
        Me.nudCodigoConsulta.Size = New System.Drawing.Size(120, 20)
        Me.nudCodigoConsulta.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Código"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Descripción:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(388, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(82, 53)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtDescripcionConsulta
        '
        Me.txtDescripcionConsulta.Location = New System.Drawing.Point(100, 23)
        Me.txtDescripcionConsulta.Name = "txtDescripcionConsulta"
        Me.txtDescripcionConsulta.Size = New System.Drawing.Size(246, 20)
        Me.txtDescripcionConsulta.TabIndex = 1
        '
        'dgvConsulta
        '
        Me.dgvConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Location = New System.Drawing.Point(7, 96)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.Size = New System.Drawing.Size(465, 265)
        Me.dgvConsulta.TabIndex = 0
        '
        'frmArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 404)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Name = "frmArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Articulos"
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tbpABM.ResumeLayout(False)
        Me.tbpABM.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.nudExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudExistenciaMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudExistenciaMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrecioCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrecioVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpConsulta.ResumeLayout(False)
        Me.tbpConsulta.PerformLayout()
        CType(Me.nudCodigoConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcPrincipal As System.Windows.Forms.TabControl
  Friend WithEvents tbpABM As System.Windows.Forms.TabPage
  Friend WithEvents tbpConsulta As System.Windows.Forms.TabPage
  Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtCodArticulo As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents cboTipoImpuesto As System.Windows.Forms.ComboBox
  Friend WithEvents nudExistencia As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents nudExistenciaMin As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents nudExistenciaMax As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents cboProveedor As System.Windows.Forms.ComboBox
  Friend WithEvents nudPrecioCompra As System.Windows.Forms.NumericUpDown
  Friend WithEvents nudPrecioVenta As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents cboUnidadMedida As System.Windows.Forms.ComboBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents btnConfirmar As System.Windows.Forms.Button
  Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dgvConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtDescripcionConsulta As System.Windows.Forms.TextBox
    Friend WithEvents nudCodigoConsulta As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
