<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaUsuario
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.gbxSucursal = New System.Windows.Forms.GroupBox()
        Me.rdbMatriz = New System.Windows.Forms.RadioButton()
        Me.rdbCiudadDelEste = New System.Windows.Forms.RadioButton()
        Me.rdbMarianoRoqueAlonso = New System.Windows.Forms.RadioButton()
        Me.rdbSanLorenzo = New System.Windows.Forms.RadioButton()
        Me.cboDepartamento = New System.Windows.Forms.ComboBox()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxSucursal.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(36, 40)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Location = New System.Drawing.Point(12, 128)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(96, 13)
        Me.lblNombreUsuario.TabIndex = 4
        Me.lblNombreUsuario.Text = "Nombre de usuario"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(36, 81)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(118, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(128, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(118, 78)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(128, 20)
        Me.txtApellido.TabIndex = 3
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(118, 125)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(128, 20)
        Me.txtNombreUsuario.TabIndex = 5
        '
        'gbxSucursal
        '
        Me.gbxSucursal.Controls.Add(Me.rdbSanLorenzo)
        Me.gbxSucursal.Controls.Add(Me.rdbMarianoRoqueAlonso)
        Me.gbxSucursal.Controls.Add(Me.rdbCiudadDelEste)
        Me.gbxSucursal.Controls.Add(Me.rdbMatriz)
        Me.gbxSucursal.Location = New System.Drawing.Point(267, 31)
        Me.gbxSucursal.Name = "gbxSucursal"
        Me.gbxSucursal.Size = New System.Drawing.Size(193, 149)
        Me.gbxSucursal.TabIndex = 8
        Me.gbxSucursal.TabStop = False
        Me.gbxSucursal.Text = "Sucursal"
        '
        'rdbMatriz
        '
        Me.rdbMatriz.AutoSize = True
        Me.rdbMatriz.Location = New System.Drawing.Point(7, 20)
        Me.rdbMatriz.Name = "rdbMatriz"
        Me.rdbMatriz.Size = New System.Drawing.Size(53, 17)
        Me.rdbMatriz.TabIndex = 0
        Me.rdbMatriz.TabStop = True
        Me.rdbMatriz.Text = "Matriz"
        Me.rdbMatriz.UseVisualStyleBackColor = True
        '
        'rdbCiudadDelEste
        '
        Me.rdbCiudadDelEste.AutoSize = True
        Me.rdbCiudadDelEste.Location = New System.Drawing.Point(6, 50)
        Me.rdbCiudadDelEste.Name = "rdbCiudadDelEste"
        Me.rdbCiudadDelEste.Size = New System.Drawing.Size(99, 17)
        Me.rdbCiudadDelEste.TabIndex = 1
        Me.rdbCiudadDelEste.TabStop = True
        Me.rdbCiudadDelEste.Text = "Ciudad del Este"
        Me.rdbCiudadDelEste.UseVisualStyleBackColor = True
        '
        'rdbMarianoRoqueAlonso
        '
        Me.rdbMarianoRoqueAlonso.AutoSize = True
        Me.rdbMarianoRoqueAlonso.Location = New System.Drawing.Point(6, 115)
        Me.rdbMarianoRoqueAlonso.Name = "rdbMarianoRoqueAlonso"
        Me.rdbMarianoRoqueAlonso.Size = New System.Drawing.Size(133, 17)
        Me.rdbMarianoRoqueAlonso.TabIndex = 3
        Me.rdbMarianoRoqueAlonso.TabStop = True
        Me.rdbMarianoRoqueAlonso.Text = "Mariano Roque Alonso"
        Me.rdbMarianoRoqueAlonso.UseVisualStyleBackColor = True
        '
        'rdbSanLorenzo
        '
        Me.rdbSanLorenzo.Location = New System.Drawing.Point(6, 83)
        Me.rdbSanLorenzo.Name = "rdbSanLorenzo"
        Me.rdbSanLorenzo.Size = New System.Drawing.Size(90, 17)
        Me.rdbSanLorenzo.TabIndex = 2
        Me.rdbSanLorenzo.TabStop = True
        Me.rdbSanLorenzo.Text = "San Lorenzo"
        Me.rdbSanLorenzo.UseVisualStyleBackColor = True
        '
        'cboDepartamento
        '
        Me.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.Items.AddRange(New Object() {"Informática", "Contabilidad", "Recursos Humanos", "Administración"})
        Me.cboDepartamento.Location = New System.Drawing.Point(118, 176)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(128, 21)
        Me.cboDepartamento.TabIndex = 7
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(12, 179)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.lblDepartamento.TabIndex = 6
        Me.lblDepartamento.Text = "Departamento"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(289, 200)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(385, 200)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(483, 200)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmCargaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 233)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Controls.Add(Me.gbxSucursal)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "frmCargaUsuario"
        Me.Text = "Carga de Usuario"
        Me.gbxSucursal.ResumeLayout(False)
        Me.gbxSucursal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents gbxSucursal As GroupBox
    Friend WithEvents rdbSanLorenzo As RadioButton
    Friend WithEvents rdbMarianoRoqueAlonso As RadioButton
    Friend WithEvents rdbCiudadDelEste As RadioButton
    Friend WithEvents rdbMatriz As RadioButton
    Friend WithEvents cboDepartamento As ComboBox
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSalir As Button
End Class
