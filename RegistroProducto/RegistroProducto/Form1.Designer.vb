<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroProducto
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
        Me.lblCodigoProducto = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblTipoProducto = New System.Windows.Forms.Label()
        Me.lblNombreDelProveedor = New System.Windows.Forms.Label()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.gbxProcedencia = New System.Windows.Forms.GroupBox()
        Me.rdbImportado = New System.Windows.Forms.RadioButton()
        Me.rdbLocal = New System.Windows.Forms.RadioButton()
        Me.gbxCanalesVenta = New System.Windows.Forms.GroupBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.chkExportacion = New System.Windows.Forms.CheckBox()
        Me.chkMayorista = New System.Windows.Forms.CheckBox()
        Me.chkMinorista = New System.Windows.Forms.CheckBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.gbxProcedencia.SuspendLayout()
        Me.gbxCanalesVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCodigoProducto
        '
        Me.lblCodigoProducto.AutoSize = True
        Me.lblCodigoProducto.Location = New System.Drawing.Point(12, 22)
        Me.lblCodigoProducto.Name = "lblCodigoProducto"
        Me.lblCodigoProducto.Size = New System.Drawing.Size(100, 13)
        Me.lblCodigoProducto.TabIndex = 0
        Me.lblCodigoProducto.Text = "Código de producto"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 54)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblTipoProducto
        '
        Me.lblTipoProducto.AutoSize = True
        Me.lblTipoProducto.Location = New System.Drawing.Point(12, 86)
        Me.lblTipoProducto.Name = "lblTipoProducto"
        Me.lblTipoProducto.Size = New System.Drawing.Size(88, 13)
        Me.lblTipoProducto.TabIndex = 4
        Me.lblTipoProducto.Text = "Tipo de producto"
        '
        'lblNombreDelProveedor
        '
        Me.lblNombreDelProveedor.AutoSize = True
        Me.lblNombreDelProveedor.Location = New System.Drawing.Point(16, 118)
        Me.lblNombreDelProveedor.Name = "lblNombreDelProveedor"
        Me.lblNombreDelProveedor.Size = New System.Drawing.Size(56, 13)
        Me.lblNombreDelProveedor.TabIndex = 6
        Me.lblNombreDelProveedor.Text = "Proveedor"
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Location = New System.Drawing.Point(118, 19)
        Me.txtCodigoProducto.MaxLength = 30
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(153, 20)
        Me.txtCodigoProducto.TabIndex = 1
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(118, 54)
        Me.txtDescripcion.MaxLength = 30
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(153, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoProducto.FormattingEnabled = True
        Me.cboTipoProducto.Items.AddRange(New Object() {"Bebidas", "Limpieza", "Comestibles", "Papeles", "Fármacos"})
        Me.cboTipoProducto.Location = New System.Drawing.Point(118, 83)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Size = New System.Drawing.Size(153, 21)
        Me.cboTipoProducto.TabIndex = 5
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Location = New System.Drawing.Point(118, 115)
        Me.txtNombreProveedor.MaxLength = 30
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(153, 20)
        Me.txtNombreProveedor.TabIndex = 7
        '
        'gbxProcedencia
        '
        Me.gbxProcedencia.Controls.Add(Me.rdbImportado)
        Me.gbxProcedencia.Controls.Add(Me.rdbLocal)
        Me.gbxProcedencia.Location = New System.Drawing.Point(12, 150)
        Me.gbxProcedencia.Name = "gbxProcedencia"
        Me.gbxProcedencia.Size = New System.Drawing.Size(125, 68)
        Me.gbxProcedencia.TabIndex = 8
        Me.gbxProcedencia.TabStop = False
        Me.gbxProcedencia.Text = "Procedencia"
        '
        'rdbImportado
        '
        Me.rdbImportado.AutoSize = True
        Me.rdbImportado.Location = New System.Drawing.Point(7, 43)
        Me.rdbImportado.Name = "rdbImportado"
        Me.rdbImportado.Size = New System.Drawing.Size(72, 17)
        Me.rdbImportado.TabIndex = 1
        Me.rdbImportado.TabStop = True
        Me.rdbImportado.Text = "Importado"
        Me.rdbImportado.UseVisualStyleBackColor = True
        '
        'rdbLocal
        '
        Me.rdbLocal.AutoSize = True
        Me.rdbLocal.Location = New System.Drawing.Point(6, 19)
        Me.rdbLocal.Name = "rdbLocal"
        Me.rdbLocal.Size = New System.Drawing.Size(51, 17)
        Me.rdbLocal.TabIndex = 0
        Me.rdbLocal.TabStop = True
        Me.rdbLocal.Text = "Local"
        Me.rdbLocal.UseVisualStyleBackColor = True
        '
        'gbxCanalesVenta
        '
        Me.gbxCanalesVenta.Controls.Add(Me.chkTodos)
        Me.gbxCanalesVenta.Controls.Add(Me.chkExportacion)
        Me.gbxCanalesVenta.Controls.Add(Me.chkMayorista)
        Me.gbxCanalesVenta.Controls.Add(Me.chkMinorista)
        Me.gbxCanalesVenta.Location = New System.Drawing.Point(146, 150)
        Me.gbxCanalesVenta.Name = "gbxCanalesVenta"
        Me.gbxCanalesVenta.Size = New System.Drawing.Size(125, 112)
        Me.gbxCanalesVenta.TabIndex = 9
        Me.gbxCanalesVenta.TabStop = False
        Me.gbxCanalesVenta.Text = "Canales de venta"
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(7, 90)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(56, 17)
        Me.chkTodos.TabIndex = 3
        Me.chkTodos.Text = "Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'chkExportacion
        '
        Me.chkExportacion.AutoSize = True
        Me.chkExportacion.Location = New System.Drawing.Point(7, 67)
        Me.chkExportacion.Name = "chkExportacion"
        Me.chkExportacion.Size = New System.Drawing.Size(88, 17)
        Me.chkExportacion.TabIndex = 2
        Me.chkExportacion.Text = "Exportanción"
        Me.chkExportacion.UseVisualStyleBackColor = True
        '
        'chkMayorista
        '
        Me.chkMayorista.AutoSize = True
        Me.chkMayorista.Location = New System.Drawing.Point(7, 44)
        Me.chkMayorista.Name = "chkMayorista"
        Me.chkMayorista.Size = New System.Drawing.Size(71, 17)
        Me.chkMayorista.TabIndex = 1
        Me.chkMayorista.Text = "Mayorista"
        Me.chkMayorista.UseVisualStyleBackColor = True
        '
        'chkMinorista
        '
        Me.chkMinorista.AutoSize = True
        Me.chkMinorista.Location = New System.Drawing.Point(7, 20)
        Me.chkMinorista.Name = "chkMinorista"
        Me.chkMinorista.Size = New System.Drawing.Size(68, 17)
        Me.chkMinorista.TabIndex = 0
        Me.chkMinorista.Text = "Minorista"
        Me.chkMinorista.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.AccessibleName = ""
        Me.btnAceptar.Location = New System.Drawing.Point(293, 249)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(374, 249)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.AccessibleName = ""
        Me.btnLimpiar.Location = New System.Drawing.Point(331, 213)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'frmRegistroProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 274)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gbxCanalesVenta)
        Me.Controls.Add(Me.gbxProcedencia)
        Me.Controls.Add(Me.txtNombreProveedor)
        Me.Controls.Add(Me.cboTipoProducto)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigoProducto)
        Me.Controls.Add(Me.lblNombreDelProveedor)
        Me.Controls.Add(Me.lblTipoProducto)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCodigoProducto)
        Me.Name = "frmRegistroProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de producto"
        Me.gbxProcedencia.ResumeLayout(False)
        Me.gbxProcedencia.PerformLayout()
        Me.gbxCanalesVenta.ResumeLayout(False)
        Me.gbxCanalesVenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodigoProducto As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblTipoProducto As Label
    Friend WithEvents lblNombreDelProveedor As Label
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents cboTipoProducto As ComboBox
    Friend WithEvents txtNombreProveedor As TextBox
    Friend WithEvents gbxProcedencia As GroupBox
    Friend WithEvents gbxCanalesVenta As GroupBox
    Friend WithEvents rdbImportado As RadioButton
    Friend WithEvents rdbLocal As RadioButton
    Friend WithEvents chkTodos As CheckBox
    Friend WithEvents chkExportacion As CheckBox
    Friend WithEvents chkMayorista As CheckBox
    Friend WithEvents chkMinorista As CheckBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
End Class
