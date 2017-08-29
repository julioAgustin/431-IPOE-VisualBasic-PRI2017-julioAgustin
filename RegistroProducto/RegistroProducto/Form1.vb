Imports System.IO

Public Class frmRegistroProducto
    Dim VFile As New StreamWriter("C:\Productos.txt", True)

    Function ValidarDatos() As Boolean

        If txtCodigoProducto.Text = "" Then
            MessageBox.Show("¡Debe ingresar cógido de proveedor!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCodigoProducto.Focus()
            Return False
        End If

        If txtDescripcion.Text = "" Then
            MessageBox.Show("¡Debe ingresar la descripción!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescripcion.Focus()
            Return False
        End If

        If txtNombreProveedor.Text = "" Then
            MessageBox.Show("¡Debe ingresar el nombre del vendedor!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If cboTipoProducto.SelectedIndex = -1 Then
            MessageBox.Show("¡Debe seleccionar por lo menos un producto!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If rdbImportado.Checked = False And rdbLocal.Checked = False Then
            MessageBox.Show("¡Debe seleccionar una opción!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If chkTodos.Checked = True Then
            If chkExportacion.Checked = True Or chkMayorista.Checked = True Or chkMinorista.Checked = True Then
                chkExportacion.Checked = False
                chkMayorista.Checked = False
                chkMinorista.Checked = False
            End If
        End If

            If chkMinorista.Checked = False And chkMayorista.Checked = False And chkExportacion.Checked = False And chkTodos.Checked = False Then
            MessageBox.Show("¡Debe seleccionar al menos una opción!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Return True

    End Function

    Sub WriteFile()

        VFile.Write(txtCodigoProducto.Text & ", ")
        VFile.Write(txtDescripcion.Text & ", ")
        VFile.Write(txtNombreProveedor.Text & ", ")

        If cboTipoProducto.SelectedItem = "Bebidas" Then
            VFile.Write("Bebidas, ")
        End If

        If cboTipoProducto.SelectedItem = "Limpieza" Then
            VFile.Write("Limpieza, ")
        End If

        If cboTipoProducto.SelectedItem = "Comestibles" Then
            VFile.Write("Comestibles, ")
        End If

        If cboTipoProducto.SelectedItem = "Papeles" Then
            VFile.Write("Papeles, ")
        End If
        If cboTipoProducto.SelectedItem = "Fármacos" Then
            VFile.Write("Fármacos, ")
        End If

        If chkExportacion.Checked Then
            VFile.Write("Exportación, ")
        End If

        If chkMinorista.Checked Then
            VFile.Write("Minorista, ")
        End If

        If chkMayorista.Checked Then
            VFile.Write("Mayorista, ")
        End If

        If chkTodos.Checked Then
            VFile.Write("Todos, ")
        End If

        If rdbImportado.Checked = True Then
            VFile.Write("Importado.")
        Else
            VFile.Write("Local.")
        End If

        VFile.WriteLine()
        VFile.Flush()

        MessageBox.Show("¡Registro guardado!")

    End Sub

    Sub LimpiarControles()
        txtCodigoProducto.Text = ""
        txtDescripcion.Text = ""
        cboTipoProducto.SelectedIndex = -1
        txtNombreProveedor.Text = ""
        chkMinorista.Checked = False
        chkMayorista.Checked = False
        chkExportacion.Checked = False
        chkTodos.Checked = False
        rdbImportado.Checked = False
        rdbLocal.Checked = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarControles()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ValidarDatos() = True Then
            WriteFile()
            LimpiarControles()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
