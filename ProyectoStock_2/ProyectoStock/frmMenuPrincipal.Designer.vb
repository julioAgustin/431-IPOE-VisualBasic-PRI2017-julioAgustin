<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.mnuMenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsBarraEstado = New System.Windows.Forms.StatusStrip()
        Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMenuContextual = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TamañoVentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntiNotificacion = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.tmrRecordatorio = New System.Windows.Forms.Timer(Me.components)
        Me.tlsBarraHerramientas = New System.Windows.Forms.ToolStrip()
        Me.tsbProducto = New System.Windows.Forms.ToolStripButton()
        Me.tltAyuda = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuMenuPrincipal.SuspendLayout()
        Me.stsBarraEstado.SuspendLayout()
        Me.cmsMenuContextual.SuspendLayout()
        Me.tlsBarraHerramientas.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuPrincipal
        '
        Me.mnuMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.mnuMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuPrincipal.Name = "mnuMenuPrincipal"
        Me.mnuMenuPrincipal.Size = New System.Drawing.Size(611, 24)
        Me.mnuMenuPrincipal.TabIndex = 1
        Me.mnuMenuPrincipal.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramasToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ProgramasToolStripMenuItem
        '
        Me.ProgramasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ProdutoToolStripMenuItem})
        Me.ProgramasToolStripMenuItem.Name = "ProgramasToolStripMenuItem"
        Me.ProgramasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProgramasToolStripMenuItem.Text = "&Programas"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProductosToolStripMenuItem.Text = "P&roductos"
        '
        'ProdutoToolStripMenuItem
        '
        Me.ProdutoToolStripMenuItem.Name = "ProdutoToolStripMenuItem"
        Me.ProdutoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProdutoToolStripMenuItem.Text = "Productos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'stsBarraEstado
        '
        Me.stsBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblVersion, Me.ToolStripDropDownButton1})
        Me.stsBarraEstado.Location = New System.Drawing.Point(0, 427)
        Me.stsBarraEstado.Name = "stsBarraEstado"
        Me.stsBarraEstado.Size = New System.Drawing.Size(611, 22)
        Me.stsBarraEstado.TabIndex = 3
        Me.stsBarraEstado.Text = "StatusStrip1"
        '
        'lblVersion
        '
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(148, 17)
        Me.lblVersion.Text = "Versión del Sistema: 1.0.0.1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem1})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ProductosToolStripMenuItem1
        '
        Me.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        Me.ProductosToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ProductosToolStripMenuItem1.Text = "Productos"
        '
        'cmsMenuContextual
        '
        Me.cmsMenuContextual.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TamañoVentanaToolStripMenuItem})
        Me.cmsMenuContextual.Name = "cmsMenuContextual"
        Me.cmsMenuContextual.Size = New System.Drawing.Size(165, 26)
        '
        'TamañoVentanaToolStripMenuItem
        '
        Me.TamañoVentanaToolStripMenuItem.Name = "TamañoVentanaToolStripMenuItem"
        Me.TamañoVentanaToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TamañoVentanaToolStripMenuItem.Text = "Tamaño Ventana"
        '
        'ntiNotificacion
        '
        Me.ntiNotificacion.Icon = CType(resources.GetObject("ntiNotificacion.Icon"), System.Drawing.Icon)
        Me.ntiNotificacion.Text = "Ayuda"
        Me.ntiNotificacion.Visible = True
        '
        'tmrRecordatorio
        '
        Me.tmrRecordatorio.Enabled = True
        Me.tmrRecordatorio.Interval = 10000
        '
        'tlsBarraHerramientas
        '
        Me.tlsBarraHerramientas.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlsBarraHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbProducto})
        Me.tlsBarraHerramientas.Location = New System.Drawing.Point(0, 24)
        Me.tlsBarraHerramientas.Name = "tlsBarraHerramientas"
        Me.tlsBarraHerramientas.Size = New System.Drawing.Size(32, 403)
        Me.tlsBarraHerramientas.TabIndex = 5
        Me.tlsBarraHerramientas.Text = "ToolStrip1"
        '
        'tsbProducto
        '
        Me.tsbProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbProducto.Image = CType(resources.GetObject("tsbProducto.Image"), System.Drawing.Image)
        Me.tsbProducto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProducto.Name = "tsbProducto"
        Me.tsbProducto.Size = New System.Drawing.Size(29, 20)
        Me.tsbProducto.Text = "Productos"
        Me.tsbProducto.ToolTipText = "Abre el formulario de Productos"
        '
        'tltAyuda
        '
        Me.tltAyuda.IsBalloon = True
        Me.tltAyuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tltAyuda.ToolTipTitle = "Ayuda"
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(611, 449)
        Me.ContextMenuStrip = Me.cmsMenuContextual
        Me.Controls.Add(Me.tlsBarraHerramientas)
        Me.Controls.Add(Me.stsBarraEstado)
        Me.Controls.Add(Me.mnuMenuPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMenuPrincipal
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMenuPrincipal.ResumeLayout(False)
        Me.mnuMenuPrincipal.PerformLayout()
        Me.stsBarraEstado.ResumeLayout(False)
        Me.stsBarraEstado.PerformLayout()
        Me.cmsMenuContextual.ResumeLayout(False)
        Me.tlsBarraHerramientas.ResumeLayout(False)
        Me.tlsBarraHerramientas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMenuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stsBarraEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents lblVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ProductosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsMenuContextual As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TamañoVentanaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntiNotificacion As System.Windows.Forms.NotifyIcon
    Friend WithEvents tmrRecordatorio As System.Windows.Forms.Timer
    Friend WithEvents tlsBarraHerramientas As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbProducto As System.Windows.Forms.ToolStripButton
    Friend WithEvents tltAyuda As System.Windows.Forms.ToolTip

End Class
