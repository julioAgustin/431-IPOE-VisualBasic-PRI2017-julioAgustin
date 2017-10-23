Public Class frmMenuPrincipal

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        'Primera forma de llamar o instanciar otro formulario
        'MdiParent: Con esta propiedad indicamos quién va a ser el contenedor del form a instanciar
        My.Forms.frmArticulo.MdiParent = Me
        My.Forms.frmArticulo.Show()
    End Sub

    Private Sub ProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutoToolStripMenuItem.Click

        'Segunda forma de llamar o instanciar otro formulario

        'Declaramos una variable de la clase frmArticulo y al mismo tiempo instanciamos el objeto de clase mencionada
        Dim f As New frmArticulo

        'MdiParent: Con esta propiedad indicamos quién va a ser el contenedor del form a instanciar
        f.MdiParent = Me

        'Finalmente mostramos el form
        f.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        'Utilizamos una sobrecarga del método Show de la clase MessageBox para emitir una pregunta al usuario. Si el usuario oprime el botón YES, se ejecutará la línea "Me.Close()"

        If MessageBox.Show("¿Está seguro de Salir de la Aplicación?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos en tiempo de ejecución una imagen de fondo para el menú principal
        'Para ello hacemos uso del espacion de nombre para tratar mapas de bits
        Try
            Me.BackgroundImage = System.Drawing.Bitmap.FromFile("fondo.jpg")
        Catch ex As IO.FileNotFoundException
            MessageBox.Show("Archivo de fondo no encontrado")
        Catch ex As Exception
            MessageBox.Show("Error al cargar formulario")
        End Try
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        Dim f As New frmArticulo
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub TamañoVentanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TamañoVentanaToolStripMenuItem.Click

        'Si no está maximizada la ventana, la maximizamos
        'Si ya está maximizada, la dejamos con el tamaño normal

        If Not Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

        'Emitir Mensaje de Notificacion
        ntiNotificacion.BalloonTipText = "Ha hecho Click sobre el Menú Contextual..."
        ntiNotificacion.BalloonTipTitle = "Ayuda"
        ntiNotificacion.BalloonTipIcon = ToolTipIcon.Info
        ntiNotificacion.ShowBalloonTip(2000)
    End Sub

    Private Sub frmMenuPrincipal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Emitir Mensaje de Notificacion
        ntiNotificacion.BalloonTipText = "Bienvenido al Sistema..."
        ntiNotificacion.BalloonTipTitle = Me.Text
        ntiNotificacion.BalloonTipIcon = ToolTipIcon.Info
        ntiNotificacion.ShowBalloonTip(2000)
    End Sub

    Private Sub tmrRecordatorio_Tick(sender As Object, e As EventArgs) Handles tmrRecordatorio.Tick
        'Emitir Mensaje de Notificacion
        ntiNotificacion.BalloonTipText = "Tiene tareas pendientes..."
        ntiNotificacion.BalloonTipTitle = Me.Text
        ntiNotificacion.BalloonTipIcon = ToolTipIcon.Info
        ntiNotificacion.ShowBalloonTip(3000)
    End Sub

    Private Sub tsbProducto_Click(sender As Object, e As EventArgs) Handles tsbProducto.Click
        Dim f As New frmArticulo
        f.MdiParent = Me
        f.Show()
    End Sub
End Class
