Imports System.IO
Public Class frmCargaUsuario
    Dim vFile As New StreamWriter("D:\Visual\cargadeusuarios.txt", True)

    Function CheckDate() As Boolean
        If txtNombre.Text.Trim = "" Then
            MessageBox.Show("Debe ingresar el nombre del usuario.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombre.Focus()
            Return False
        End If

        If txtApellido.Text.Trim = "" Then
            MessageBox.Show("Debe ingresar el apellido del usuario.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtApellido.Focus()
            Return False
        End If

        If txtNombreUsuario.Text.Trim = "" Then
            MessageBox.Show("Debe ingresar el nombre de inicio de sesión del usuario.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombreUsuario.Focus()
            Return False
        End If

        If cboDepartamento.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar al menos una opcion.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboDepartamento.Focus()
            Return False
        End If
        If rdbMatriz.Checked = False And rdbCiudadDelEste.Checked = False And rdbSanLorenzo.Checked = False And rdbMarianoRoqueAlonso.Checked = False Then
            MessageBox.Show("Debe seleccionar al menos una opcion.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function

    Sub WriteFile()
        vFile.Write(txtNombre.Text & ", ")
        vFile.Write(txtApellido.Text & ", ")
        vFile.Write(txtNombreUsuario.Text & ", ")

        If cboDepartamento.SelectedItem = "Informática" Then
            vFile.Write("Informática, ")
        End If
        If cboDepartamento.SelectedItem = "Contabilidad" Then
            vFile.Write("Contabilidad, ")
        End If
        If cboDepartamento.SelectedItem = "Recursos Humanos" Then
            vFile.Write("Recursos Humanos, ")
        End If
        If cboDepartamento.SelectedItem = "Administración" Then
            vFile.Write("Administración, ")
        End If
        If rdbMatriz.Checked = True Then
            vFile.Write("Matriz, ")
        End If
        If rdbCiudadDelEste.Checked = True Then
            vFile.Write("Ciudad del Este, ")
        End If
        If rdbSanLorenzo.Checked = True Then
            vFile.Write("San Lorenzo, ")
        End If
        If rdbMarianoRoqueAlonso.Checked = True Then
            vFile.Write("Mariano Roque Alonso, ")
        End If

        vFile.WriteLine()
        vFile.Flush()

        MessageBox.Show("Registro guardado.")
    End Sub
    Sub LimpiarControles()
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtNombreUsuario.Text = ""
        cboDepartamento.SelectedIndex = -1
        rdbMatriz.Checked = False
        rdbSanLorenzo.Checked = False
        rdbCiudadDelEste.Checked = False
        rdbMarianoRoqueAlonso.Checked = False
    End Sub
    Private Sub frmCargaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If CheckDate() = True Then
            WriteFile()
            LimpiarControles()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea salir del formulario?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
        Else
            Close()
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("¿Desea cancelar la operación?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
        Else
            LimpiarControles()
        End If



    End Sub
End Class
