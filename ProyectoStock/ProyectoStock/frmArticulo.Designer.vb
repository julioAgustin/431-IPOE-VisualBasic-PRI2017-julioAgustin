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
        Me.tbcABM = New System.Windows.Forms.TabControl()
        Me.tbpMantenimiento = New System.Windows.Forms.TabPage()
        Me.gbxOperaciones = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.cboTipoImpuesto = New System.Windows.Forms.ComboBox()
        Me.lblTipoImpuesto = New System.Windows.Forms.Label()
        Me.cboUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.lblUnidadMedida = New System.Windows.Forms.Label()
        Me.nudExistencia = New System.Windows.Forms.NumericUpDown()
        Me.lblExistencia = New System.Windows.Forms.Label()
        Me.nudExistenciaMinima = New System.Windows.Forms.NumericUpDown()
        Me.lblExistenciaMinima = New System.Windows.Forms.Label()
        Me.nudExistenciaMaxima = New System.Windows.Forms.NumericUpDown()
        Me.lblExistenciaMaxima = New System.Windows.Forms.Label()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.nudPrecioCompra = New System.Windows.Forms.NumericUpDown()
        Me.lblPrecioCompra = New System.Windows.Forms.Label()
        Me.nudPrecioVenta = New System.Windows.Forms.NumericUpDown()
        Me.lblPrecioVenta = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.tbpConsulta = New System.Windows.Forms.TabPage()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.tbcABM.SuspendLayout()
        Me.tbpMantenimiento.SuspendLayout()
        Me.gbxOperaciones.SuspendLayout()
        CType(Me.nudExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudExistenciaMinima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudExistenciaMaxima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrecioCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPrecioVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpConsulta.SuspendLayout()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcABM
        '
        Me.tbcABM.Controls.Add(Me.tbpMantenimiento)
        Me.tbcABM.Controls.Add(Me.tbpConsulta)
        Me.tbcABM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcABM.Location = New System.Drawing.Point(0, 0)
        Me.tbcABM.Name = "tbcABM"
        Me.tbcABM.SelectedIndex = 0
        Me.tbcABM.Size = New System.Drawing.Size(506, 455)
        Me.tbcABM.TabIndex = 0
        '
        'tbpMantenimiento
        '
        Me.tbpMantenimiento.Controls.Add(Me.gbxOperaciones)
        Me.tbpMantenimiento.Controls.Add(Me.cboTipoImpuesto)
        Me.tbpMantenimiento.Controls.Add(Me.lblTipoImpuesto)
        Me.tbpMantenimiento.Controls.Add(Me.cboUnidadMedida)
        Me.tbpMantenimiento.Controls.Add(Me.lblUnidadMedida)
        Me.tbpMantenimiento.Controls.Add(Me.nudExistencia)
        Me.tbpMantenimiento.Controls.Add(Me.lblExistencia)
        Me.tbpMantenimiento.Controls.Add(Me.nudExistenciaMinima)
        Me.tbpMantenimiento.Controls.Add(Me.lblExistenciaMinima)
        Me.tbpMantenimiento.Controls.Add(Me.nudExistenciaMaxima)
        Me.tbpMantenimiento.Controls.Add(Me.lblExistenciaMaxima)
        Me.tbpMantenimiento.Controls.Add(Me.cboProveedor)
        Me.tbpMantenimiento.Controls.Add(Me.lblProveedor)
        Me.tbpMantenimiento.Controls.Add(Me.nudPrecioCompra)
        Me.tbpMantenimiento.Controls.Add(Me.lblPrecioCompra)
        Me.tbpMantenimiento.Controls.Add(Me.nudPrecioVenta)
        Me.tbpMantenimiento.Controls.Add(Me.lblPrecioVenta)
        Me.tbpMantenimiento.Controls.Add(Me.txtDescripcion)
        Me.tbpMantenimiento.Controls.Add(Me.lblDescripcion)
        Me.tbpMantenimiento.Controls.Add(Me.txtCodigo)
        Me.tbpMantenimiento.Controls.Add(Me.lblCodigo)
        Me.tbpMantenimiento.Location = New System.Drawing.Point(4, 22)
        Me.tbpMantenimiento.Name = "tbpMantenimiento"
        Me.tbpMantenimiento.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpMantenimiento.Size = New System.Drawing.Size(498, 429)
        Me.tbpMantenimiento.TabIndex = 0
        Me.tbpMantenimiento.Text = "Mantenimiento"
        Me.tbpMantenimiento.UseVisualStyleBackColor = True
        '
        'gbxOperaciones
        '
        Me.gbxOperaciones.Controls.Add(Me.btnCancelar)
        Me.gbxOperaciones.Controls.Add(Me.btnEliminar)
        Me.gbxOperaciones.Controls.Add(Me.btnConfirmar)
        Me.gbxOperaciones.Location = New System.Drawing.Point(19, 357)
        Me.gbxOperaciones.Name = "gbxOperaciones"
        Me.gbxOperaciones.Size = New System.Drawing.Size(454, 60)
        Me.gbxOperaciones.TabIndex = 20
        Me.gbxOperaciones.TabStop = False
        Me.gbxOperaciones.Text = "Acciones"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(315, 15)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 36)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cance&lar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(191, 15)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(91, 36)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConfirmar.Location = New System.Drawing.Point(65, 15)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(91, 36)
        Me.btnConfirmar.TabIndex = 0
        Me.btnConfirmar.Text = "&Confirmar"
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'cboTipoImpuesto
        '
        Me.cboTipoImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoImpuesto.FormattingEnabled = True
        Me.cboTipoImpuesto.Location = New System.Drawing.Point(117, 288)
        Me.cboTipoImpuesto.Name = "cboTipoImpuesto"
        Me.cboTipoImpuesto.Size = New System.Drawing.Size(120, 21)
        Me.cboTipoImpuesto.TabIndex = 17
        '
        'lblTipoImpuesto
        '
        Me.lblTipoImpuesto.AutoSize = True
        Me.lblTipoImpuesto.Location = New System.Drawing.Point(18, 296)
        Me.lblTipoImpuesto.Name = "lblTipoImpuesto"
        Me.lblTipoImpuesto.Size = New System.Drawing.Size(89, 13)
        Me.lblTipoImpuesto.TabIndex = 16
        Me.lblTipoImpuesto.Text = "Tipo de Impuesto"
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadMedida.FormattingEnabled = True
        Me.cboUnidadMedida.Location = New System.Drawing.Point(117, 319)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.Size = New System.Drawing.Size(120, 21)
        Me.cboUnidadMedida.TabIndex = 19
        '
        'lblUnidadMedida
        '
        Me.lblUnidadMedida.AutoSize = True
        Me.lblUnidadMedida.Location = New System.Drawing.Point(18, 327)
        Me.lblUnidadMedida.Name = "lblUnidadMedida"
        Me.lblUnidadMedida.Size = New System.Drawing.Size(79, 13)
        Me.lblUnidadMedida.TabIndex = 18
        Me.lblUnidadMedida.Text = "Unidad Medida"
        '
        'nudExistencia
        '
        Me.nudExistencia.Location = New System.Drawing.Point(117, 255)
        Me.nudExistencia.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.nudExistencia.Name = "nudExistencia"
        Me.nudExistencia.Size = New System.Drawing.Size(120, 20)
        Me.nudExistencia.TabIndex = 15
        Me.nudExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblExistencia
        '
        Me.lblExistencia.AutoSize = True
        Me.lblExistencia.Location = New System.Drawing.Point(18, 262)
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Size = New System.Drawing.Size(55, 13)
        Me.lblExistencia.TabIndex = 14
        Me.lblExistencia.Text = "Existencia"
        '
        'nudExistenciaMinima
        '
        Me.nudExistenciaMinima.Location = New System.Drawing.Point(117, 224)
        Me.nudExistenciaMinima.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.nudExistenciaMinima.Name = "nudExistenciaMinima"
        Me.nudExistenciaMinima.Size = New System.Drawing.Size(120, 20)
        Me.nudExistenciaMinima.TabIndex = 13
        Me.nudExistenciaMinima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblExistenciaMinima
        '
        Me.lblExistenciaMinima.AutoSize = True
        Me.lblExistenciaMinima.Location = New System.Drawing.Point(18, 231)
        Me.lblExistenciaMinima.Name = "lblExistenciaMinima"
        Me.lblExistenciaMinima.Size = New System.Drawing.Size(93, 13)
        Me.lblExistenciaMinima.TabIndex = 12
        Me.lblExistenciaMinima.Text = "Existencia Mínima"
        '
        'nudExistenciaMaxima
        '
        Me.nudExistenciaMaxima.Location = New System.Drawing.Point(117, 189)
        Me.nudExistenciaMaxima.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.nudExistenciaMaxima.Name = "nudExistenciaMaxima"
        Me.nudExistenciaMaxima.Size = New System.Drawing.Size(120, 20)
        Me.nudExistenciaMaxima.TabIndex = 11
        Me.nudExistenciaMaxima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblExistenciaMaxima
        '
        Me.lblExistenciaMaxima.AutoSize = True
        Me.lblExistenciaMaxima.Location = New System.Drawing.Point(18, 196)
        Me.lblExistenciaMaxima.Name = "lblExistenciaMaxima"
        Me.lblExistenciaMaxima.Size = New System.Drawing.Size(94, 13)
        Me.lblExistenciaMaxima.TabIndex = 10
        Me.lblExistenciaMaxima.Text = "Existencia Máxima"
        '
        'cboProveedor
        '
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(117, 154)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(204, 21)
        Me.cboProveedor.TabIndex = 9
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Location = New System.Drawing.Point(18, 162)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(56, 13)
        Me.lblProveedor.TabIndex = 8
        Me.lblProveedor.Text = "Proveedor"
        '
        'nudPrecioCompra
        '
        Me.nudPrecioCompra.Location = New System.Drawing.Point(117, 121)
        Me.nudPrecioCompra.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.nudPrecioCompra.Name = "nudPrecioCompra"
        Me.nudPrecioCompra.Size = New System.Drawing.Size(120, 20)
        Me.nudPrecioCompra.TabIndex = 7
        Me.nudPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPrecioCompra
        '
        Me.lblPrecioCompra.AutoSize = True
        Me.lblPrecioCompra.Location = New System.Drawing.Point(18, 128)
        Me.lblPrecioCompra.Name = "lblPrecioCompra"
        Me.lblPrecioCompra.Size = New System.Drawing.Size(91, 13)
        Me.lblPrecioCompra.TabIndex = 6
        Me.lblPrecioCompra.Text = "Precio de Compra"
        '
        'nudPrecioVenta
        '
        Me.nudPrecioVenta.Location = New System.Drawing.Point(117, 88)
        Me.nudPrecioVenta.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.nudPrecioVenta.Name = "nudPrecioVenta"
        Me.nudPrecioVenta.Size = New System.Drawing.Size(120, 20)
        Me.nudPrecioVenta.TabIndex = 5
        Me.nudPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPrecioVenta
        '
        Me.lblPrecioVenta.AutoSize = True
        Me.lblPrecioVenta.Location = New System.Drawing.Point(18, 95)
        Me.lblPrecioVenta.Name = "lblPrecioVenta"
        Me.lblPrecioVenta.Size = New System.Drawing.Size(83, 13)
        Me.lblPrecioVenta.TabIndex = 4
        Me.lblPrecioVenta.Text = "Precio de Venta"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(117, 56)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(288, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(18, 63)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripción"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(117, 27)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(70, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(18, 34)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código"
        '
        'tbpConsulta
        '
        Me.tbpConsulta.Controls.Add(Me.dgvDatos)
        Me.tbpConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tbpConsulta.Name = "tbpConsulta"
        Me.tbpConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpConsulta.Size = New System.Drawing.Size(498, 429)
        Me.tbpConsulta.TabIndex = 1
        Me.tbpConsulta.Text = "Consulta"
        Me.tbpConsulta.UseVisualStyleBackColor = True
        '
        'dgvDatos
        '
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDatos.Location = New System.Drawing.Point(3, 3)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.Size = New System.Drawing.Size(492, 423)
        Me.dgvDatos.TabIndex = 0
        '
        'frmArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 455)
        Me.Controls.Add(Me.tbcABM)
        Me.MaximizeBox = False
        Me.Name = "frmArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":::Articulos:::"
        Me.tbcABM.ResumeLayout(False)
        Me.tbpMantenimiento.ResumeLayout(False)
        Me.tbpMantenimiento.PerformLayout()
        Me.gbxOperaciones.ResumeLayout(False)
        CType(Me.nudExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudExistenciaMinima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudExistenciaMaxima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrecioCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPrecioVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpConsulta.ResumeLayout(False)
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcABM As TabControl
    Friend WithEvents tbpMantenimiento As TabPage
    Friend WithEvents gbxOperaciones As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents cboTipoImpuesto As ComboBox
    Friend WithEvents lblTipoImpuesto As Label
    Friend WithEvents cboUnidadMedida As ComboBox
    Friend WithEvents lblUnidadMedida As Label
    Friend WithEvents nudExistencia As NumericUpDown
    Friend WithEvents lblExistencia As Label
    Friend WithEvents nudExistenciaMinima As NumericUpDown
    Friend WithEvents lblExistenciaMinima As Label
    Friend WithEvents nudExistenciaMaxima As NumericUpDown
    Friend WithEvents lblExistenciaMaxima As Label
    Friend WithEvents cboProveedor As ComboBox
    Friend WithEvents lblProveedor As Label
    Friend WithEvents nudPrecioCompra As NumericUpDown
    Friend WithEvents lblPrecioCompra As Label
    Friend WithEvents nudPrecioVenta As NumericUpDown
    Friend WithEvents lblPrecioVenta As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents tbpConsulta As TabPage
    Friend WithEvents dgvDatos As DataGridView
End Class
