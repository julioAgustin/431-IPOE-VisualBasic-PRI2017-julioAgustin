<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentanaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentanaPrincipal))
        Me.mnuMenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsBarraEstado = New System.Windows.Forms.StatusStrip()
        Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ntiNotificacion = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.mnuMenuPrincipal.SuspendLayout()
        Me.stsBarraEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuPrincipal
        '
        Me.mnuMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.mnuMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuPrincipal.Name = "mnuMenuPrincipal"
        Me.mnuMenuPrincipal.Size = New System.Drawing.Size(675, 24)
        Me.mnuMenuPrincipal.TabIndex = 1
        Me.mnuMenuPrincipal.Text = "Menú Principal"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ProgramasToolStripMenuItem
        '
        Me.ProgramasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMToolStripMenuItem})
        Me.ProgramasToolStripMenuItem.Name = "ProgramasToolStripMenuItem"
        Me.ProgramasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProgramasToolStripMenuItem.Text = "Programas"
        '
        'ABMToolStripMenuItem
        '
        Me.ABMToolStripMenuItem.Name = "ABMToolStripMenuItem"
        Me.ABMToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ABMToolStripMenuItem.Text = "ABM"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'stsBarraEstado
        '
        Me.stsBarraEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblVersion})
        Me.stsBarraEstado.Location = New System.Drawing.Point(0, 478)
        Me.stsBarraEstado.Name = "stsBarraEstado"
        Me.stsBarraEstado.Size = New System.Drawing.Size(675, 22)
        Me.stsBarraEstado.TabIndex = 2
        Me.stsBarraEstado.Text = "Barra de estado"
        '
        'lblVersion
        '
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(146, 17)
        Me.lblVersion.Text = "Versión del sistema: 1.0.0.1"
        '
        'ntiNotificacion
        '
        Me.ntiNotificacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ntiNotificacion.Icon = CType(resources.GetObject("ntiNotificacion.Icon"), System.Drawing.Icon)
        Me.ntiNotificacion.Text = "Notificación"
        Me.ntiNotificacion.Visible = True
        '
        'frmVentanaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 500)
        Me.Controls.Add(Me.stsBarraEstado)
        Me.Controls.Add(Me.mnuMenuPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMenuPrincipal
        Me.Name = "frmVentanaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventana Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMenuPrincipal.ResumeLayout(False)
        Me.mnuMenuPrincipal.PerformLayout()
        Me.stsBarraEstado.ResumeLayout(False)
        Me.stsBarraEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMenuPrincipal As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents stsBarraEstado As StatusStrip
    Friend WithEvents lblVersion As ToolStripStatusLabel
    Friend WithEvents ntiNotificacion As NotifyIcon
End Class
