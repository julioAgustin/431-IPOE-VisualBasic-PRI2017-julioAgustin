Imports System.Data.SqlClient
Public Class frmAutos
    Dim vConexion As New SqlConnection("data source = M203-16; initial catalog = Cars; user = sa; password = @lumno123")
    Dim vNuevo As Boolean = True

    Private Sub frmAutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim vComando As New SqlCommand
            vComando.Connection = vConexion
            vComando.CommandText = "SELECT * FROM Marca"
            Dim dtMarca As New DataTable
            Dim adaptadorMarca As New SqlDataAdapter(vComando)
            adaptadorMarca.Fill(dtMarca)

            cboMarca.DataSource = dtMarca
            cboMarca.DisplayMember = "Descripcion"
            cboMarca.ValueMember = "MarcaID"

            Dim vComando2 As New SqlCommand
            vComando2.Connection = vConexion
            vComando2.CommandText = "SELECT * FROM TipoVehiculo"
            Dim dtTipoVehiculo As New DataTable
            Dim adaptadorTipoVehiculo As New SqlDataAdapter(vComando2)
            adaptadorTipoVehiculo.Fill(dtTipoVehiculo)

            ltbTipoAuto.DataSource = dtTipoVehiculo
            ltbTipoAuto.DisplayMember = "Descripcion"
            ltbTipoAuto.ValueMember = "TipoVehiculoID"


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtChapa_Leave(sender As Object, e As EventArgs) Handles txtChapa.Leave
        If Not vNuevo = True Then



        End If
    End Sub

    Function validarDatos() As Boolean
        If txtChapa.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar el número de chapa", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtChapa.Focus()
            Return False
        End If

        If nudAnho.Value <= 0 Then
            MessageBox.Show("El año no puede ser menor o igual a 0", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            nudAnho.Focus()
            Return False
        End If

        If cboMarca.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar la marca", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboMarca.Focus()
            Return False
        End If

        If ltbTipoAuto.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar el tipo de vehículo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboMarca.Focus()
            Return False
        End If

        If rdbAutomatico.Checked = False And rdbManual.Checked = False Then
            MessageBox.Show("Debe seleccionar una opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboMarca.Focus()
            Return False
        End If

        If nudPrecio.Value <= 0 Then
            MessageBox.Show("El precio no puede ser menor o igual a 0", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            nudPrecio.Focus()
            Return False
        End If

        If nudImpuesto.Value <= 0 Then
            MessageBox.Show("El impuesto no puede ser menor o igual a 0", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            nudImpuesto.Focus()
            Return False
        End If

        Return True

    End Function
    Sub limpiarFormulario()
        txtChapa.Text = ""
        nudAnho.Value = 0
        cboMarca.SelectedIndex = -1
        ltbTipoAuto.SelectedIndex = -1
        rdbAutomatico.Checked = False
        rdbManual.Checked = False
        nudPrecio.Value = 0
        nudImpuesto.Value = 0

        vNuevo = True

    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If validarDatos() = True Then
            Try
                Dim vComando As New SqlCommand()
                vComando.Connection = vConexion

                Dim vCambio As Char
                If rdbManual.Checked Then
                    vCambio = "M"
                Else
                    vCambio = "A"
                End If

                If vNuevo = True Then
                    vComando.CommandText = "INSERT INTO Vehiculo VALUES('" & txtChapa.Text.Trim() & "', " & CInt(nudAnho.Value) & ", " & cboMarca.SelectedValue & ", " & ltbTipoAuto.SelectedValue & ", '" & vCambio & "', " & CInt(nudPrecio.Value) & ", " & CInt(nudImpuesto.Value) & ");"
                End If

                vConexion.Open()
                vComando.ExecuteNonQuery()
                MessageBox.Show("Vehículo creado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarFormulario()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                vConexion.Close()
            End Try

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Está seguro de cancelar y cerrar?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub nudPrecio_Leave(sender As Object, e As EventArgs) Handles nudPrecio.Leave

        If nudAnho.Value < 2000 Then
            nudImpuesto.Value = nudPrecio.Value * 5 / 100

        ElseIf nudAnho.Value >= 2000 Then

            nudImpuesto.Value = nudPrecio.Value * 10 / 100
        End If
    End Sub
End Class