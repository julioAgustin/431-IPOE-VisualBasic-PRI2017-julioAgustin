Public Class frmLogin
    Private Sub lblConfiguracion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblConfiguracion.LinkClicked
        'Llamamos en forma MODAL al formulario de Configuración
        My.Forms.frmConfiguracionAcceso.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Cerramos el Login
        Me.Close()
    End Sub

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Evento que se ejecuta al momento en que se cierra el form
        'Preguntamos si el Menú Principal, que al momento de su Load, había sido ocultado, sigue sin ser visto (Significa que el usuario no se pudo loguear).
        If Not My.Forms.frmMenuPrincipal.Visible Then
            'En ese caso, destruimos el menú principal, con lo que termina la ejecución de la aplicación
            My.Forms.frmMenuPrincipal.Dispose()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'Validamos el ingreso de Usuario y Contraseña

        If txtUsuario.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar el Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsuario.Focus()
            Return
        End If

        If txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar el Password", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Return
        End If

        Try

            With conexion
                'Asignamos una cadena de conexión al objeto sqlConection

                .ConnectionString = "data source = " & My.Settings.ServidorBD & "; initial catalog = " & My.Settings.BaseDatos & "; user = " & txtUsuario.Text.Trim() & "; password = " & txtPassword.Text.Trim()

                'Intentamos abrir la conexión

                .Open()
            End With

            'Si se pudo establecer conexión, ponemos visible el menú principal

            My.Forms.frmMenuPrincipal.Visible = True

            'Tiramos el foco al menú principal

            My.Forms.frmMenuPrincipal.Focus()

            'Emitimos Mensaje de Notificacion

            My.Forms.frmMenuPrincipal.ntiNotificacion.BalloonTipText = "Bienvenido al Sistema..."
            My.Forms.frmMenuPrincipal.ntiNotificacion.BalloonTipTitle = Me.Text
            My.Forms.frmMenuPrincipal.ntiNotificacion.BalloonTipIcon = ToolTipIcon.Info
            My.Forms.frmMenuPrincipal.ntiNotificacion.ShowBalloonTip(2000)

            'Cerramos el Login

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al ingresar al Sistema." & vbNewLine & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

            'vbNewLine sirve para aplicar un salto de línea
        Finally
            'Se haya establecido o no la conexión, al final cerramos la misma
            conexion.Close()
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class