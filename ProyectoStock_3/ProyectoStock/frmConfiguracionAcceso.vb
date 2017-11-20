Public Class frmConfiguracionAcceso
    Private Sub frmConfiguracionAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al cargarse el formulario tomamos los valores actuales de la configuración de la aplicación y los volcamos a los controles correspondientes.

        txtServidor.Text = My.Settings.ServidorBD
        txtBaseDatos.Text = My.Settings.BaseDatos
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Cerramos el formulario
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'Asignamos lo ingresado por el usuario a las variables que habíamos creado dentro de la configuración de la aplicación.
        My.Settings.ServidorBD = txtServidor.Text.Trim()
        My.Settings.BaseDatos = txtBaseDatos.Text.Trim()

        'Guardamos los cambios
        My.Settings.Save()

        'Finalmente cerramos el form de configuración
        Me.Close()
    End Sub
End Class