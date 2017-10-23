Public Class frmVentanaPrincipal
    Private Sub ABMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMToolStripMenuItem.Click
        Dim form As New frmAutos
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de Salir de la Aplicación?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub frmVentanaPrincipal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ntiNotificacion.BalloonTipText = "Bienvenido al Sistema..."
        ntiNotificacion.BalloonTipTitle = Me.Text
        ntiNotificacion.BalloonTipIcon = ToolTipIcon.Info
        ntiNotificacion.ShowBalloonTip(2000)

    End Sub

    Private Sub frmVentanaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
