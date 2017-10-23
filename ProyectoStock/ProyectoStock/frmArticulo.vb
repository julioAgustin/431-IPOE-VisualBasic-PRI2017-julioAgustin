Imports System.Data.SqlClient
Public Class frmArticulo

    'Comentarios Iniciales acerca del Diseño del Formulario
    'Dejamos inhabilitado el control txtCodigo seteando la propiedad ENABLED en FALSE
    'Se setea propiedad MAXIMUM de los controles NumericUpDown
    'Se setea propiedad DropDownStyle de los controles ComboBox, de manera a que no sean editables
    'Se agregan imágenes a los botones mediante la propiedad Image. También se setea la propiedad ImageAlign. Se setea propiedad TextAlign

    'Declaramos e instanciamos un variable de la clase Conexión
    Dim vConexion As New SqlConnection("data source = MACHINE-01; initial catalog = stock; user = sa; password = 123456")

    'Bandera que vamos a utilizar para saber si vamos a insertar o actualizar un registro en la BD
    Dim vNuevo As Boolean = True

    Private Sub frmArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Evento que se ejecuta cuando se carga el formulario. Es el primer evento que se ejecuta cuando se llama o instancia un form.
        Try
            'Creamos un objeto del tipo Comando y luego lo configuramos
            Dim vComando As New SqlCommand
            vComando.Connection = vConexion
            vComando.CommandText = "select * from proveedor"

            'Creamos el objeto DataTable para los registros que vamos a traer desde la tabla Proveedores
            Dim dtProveedor As New DataTable
            'Creamos el objeto adaptador para los registros de Proveedores y a su constructor ya le pasamos el objeto comando
            Dim adaptadorProveedor As New SqlDataAdapter(vComando)
            'Con el método Fill traemos los datos desde la BD y los volcamos al objeto DataTable
            adaptadorProveedor.Fill(dtProveedor)

            'Configuramos el ComboBox que va a mostrar los datos de Proveedores
            'Primero especificamos el origen de datos. Le asignamos el DataTable que ya cuenta con los registros traídos desde la BD
            cboProveedor.DataSource = dtProveedor
            'Especificamos el campo que se va a mostrar al usuario al desplegar el ComboBox
            cboProveedor.DisplayMember = "Nombre"
            'Especificamos el campo que contiene el ID que finalmente va a guardar el ComboBox una vez que se seleccione una opción
            cboProveedor.ValueMember = "ProveedorId"


            'Mismo proceso que lo explicado más arriba, pero esta vez para el ComboBox del campo TipoImpuestoID

            vComando.CommandText = "select * from TipoImpuesto"

            Dim dtTipoImpuesto As New DataTable
            Dim adaptadorTipoImpuesto As New SqlDataAdapter(vComando)
            adaptadorTipoImpuesto.Fill(dtTipoImpuesto)

            cboTipoImpuesto.DataSource = dtTipoImpuesto
            cboTipoImpuesto.DisplayMember = "Descripcion"
            cboTipoImpuesto.ValueMember = "TipoImpuestoID"


            'Cargamos el ComboBox del campo UnidadMedidaID

            vComando.CommandText = "select * from UnidadMedida"

            Dim dtUnidadMedida As New DataTable
            Dim adaptadorUnidadMedida As New SqlDataAdapter(vComando)
            adaptadorUnidadMedida.Fill(dtUnidadMedida)

            cboUnidadMedida.DataSource = dtUnidadMedida
            cboUnidadMedida.DisplayMember = "Descripcion"
            cboUnidadMedida.ValueMember = "UnidadMedidaID"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub tbcABM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcABM.SelectedIndexChanged
        'Evento que se ejecuta cuando se cambia de página dentro de un TabControl

        'Preguntamos si se seleccionó la segunda página (Página de Consulta)
        If tbcABM.SelectedIndex = 1 Then
            Try
                'Creamos un objeto comando
                'Al momento de su creación, ya podemos pasarle el valor para el CommandText y el objeto Conexión (En lugar de hacerlo en 3 líneas)
                Dim vComando As New SqlCommand("select * from Articulo", vConexion)
                'Creamos un DataTable
                Dim dtArticulo As New DataTable
                'Creamos un Adaptador 
                Dim adaptadorArticulo As New SqlDataAdapter(vComando)
                'Llenamos el DataTable con el resultado del SELECT a la tabla Artículo
                adaptadorArticulo.Fill(dtArticulo)

                'Finalmente mostramos el contenido del DataTable en el DataGridView
                dgvDatos.DataSource = dtArticulo
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If DatosValidos() Then
            Try
                Dim vComando As New SqlCommand()
                vComando.Connection = vConexion

                If vNuevo Then
                    vComando.CommandText = "insert into Articulo values('" & txtDescripcion.Text.Trim() & "'," & CInt(nudPrecioVenta.Value) & "," & CInt(nudPrecioCompra.Value) & "," & cboProveedor.SelectedValue & "," & CInt(nudExistenciaMaxima.Value) & "," & CInt(nudExistenciaMinima.Value) & "," & CInt(nudExistencia.Value) & "," & cboTipoImpuesto.SelectedValue & "," & cboUnidadMedida.SelectedValue & ")"
                Else
                    vComando.CommandText = "update Articulos set descripcion = '" & txtDescripcion.Text.Trim() & "',PrecioVenta = " & CInt(nudPrecioVenta.Value) & ", PrecioCompra = " & CInt(nudPrecioCompra.Value) & ", ProveedorId = " & cboProveedor.SelectedValue & ", ExistenciaMaxima = " & CInt(nudExistenciaMaxima.Value) & ", ExistenciaMinima = " & CInt(nudExistenciaMinima.Value) & ", Existencia = " & CInt(nudExistencia.Value) & ",TipoImpuestoId = " & cboTipoImpuesto.SelectedValue & ", UnidadMedidaId = " & cboUnidadMedida.SelectedValue & " where ArticuloId = " & txtCodigo.Text.Trim()
                End If

                'Abrimos la Conexión
                vConexion.Open()
                'Ejecutamos la Sentencia SQL en la BD
                vComando.ExecuteNonQuery()
                'Cerramos la conexión
                vConexion.Close()

                'Mostramos un mensaje al Usuario
                MessageBox.Show("Registro Guardado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Limpiamos el formulario
                LimpiarFormulario()
            Catch ex As Exception
                'Mostramos un mensaje de error en caso de que se haya dado un Excepción.
                'Con vbNewLine Logramos insertar un salto de línea dentro de un String
                MessageBox.Show("Error al momento de confirmar los datos" & vbNewLine & ex.Message)
            End Try
        End If
    End Sub

    Function DatosValidos() As Boolean

        If txtDescripcion.Text.Trim() = "" Then
            MessageBox.Show("Debe ingresar la Descripción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescripcion.Focus()
            Return False
        End If

        If nudPrecioCompra.Value = 0 Then
            MessageBox.Show("Debe ingresar el Precio de Compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            nudPrecioCompra.Focus()
            Return False
        End If

        If nudPrecioVenta.Value = 0 Then
            MessageBox.Show("Debe ingresar el Precio de Venta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            nudPrecioVenta.Focus()
            Return False
        End If

        If cboProveedor.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar el Proveedor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboProveedor.Focus()
            Return False
        End If


        If nudExistenciaMinima.Value > nudExistenciaMaxima.Value Then
            MessageBox.Show("La existencia mínima no puede ser superior a la existencia máxima", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            nudExistenciaMinima.Focus()
            Return False
        End If

        If (nudExistencia.Value < nudExistenciaMinima.Value) Or (nudExistencia.Value > nudExistenciaMaxima.Value) Then
            MessageBox.Show("La existencia debe estar entre la mínima y la máxima permitida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            nudExistencia.Focus()
            Return False
        End If

        If cboTipoImpuesto.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar el Tipo de Impuesto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboTipoImpuesto.Focus()
            Return False
        End If

        If cboUnidadMedida.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar la Unidad de Medida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboUnidadMedida.Focus()
            Return False
        End If

        Return True
    End Function

    Sub LimpiarFormulario()
        txtCodigo.Clear()
        txtDescripcion.Text = ""
        nudPrecioCompra.Value = 0
        nudPrecioVenta.Value = 0
        cboProveedor.SelectedIndex = -1
        nudExistenciaMaxima.Value = 0
        nudExistenciaMinima.Value = 0
        nudExistencia.Value = 0
        cboTipoImpuesto.SelectedIndex = -1
        cboUnidadMedida.SelectedIndex = -1

        txtDescripcion.Focus()
        vNuevo = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
    End Sub

    Private Sub dgvDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellDoubleClick
        'Evento que se dispara cuando se hace doble clic en alguna celda del DataGridView
        Try
            'Creamos un sqlCommand y al momento de instanciarlo ya configuramos el CommandText y la conexión
            Dim vComando As New SqlCommand("select * from Articulo where ArticuloId = " & dgvDatos(0, e.RowIndex).Value, vConexion)
            'Creamos e instanciamos un objeto DataTable
            Dim dtConsulta As New DataTable
            'Creamos e instanciamos un Adaptador
            Dim adaptadorConsulta As New SqlDataAdapter(vComando)
            'Ejecutamos la consulta en la bd y el resultado lo volcamos al objeto DataTable
            adaptadorConsulta.Fill(dtConsulta)

            'Si después de realizar la consulta el DataTable cuenta con Registros o filas mostramos el contenido de cada campo en el control correspondiente
            'Rows(0): Primera fila del DataTable.
            'Item("xxxx"): Especificamos el nombre de la columna que queremos recuperar
            If dtConsulta.Rows.Count > 0 Then
                txtCodigo.Text = dtConsulta.Rows(0).Item("ArticuloId")
                txtDescripcion.Text = dtConsulta.Rows(0).Item("Descripcion")
                nudPrecioVenta.Value = dtConsulta.Rows(0).Item("PrecioVenta")
                nudPrecioCompra.Value = dtConsulta.Rows(0).Item("PrecioCompra")
                cboProveedor.SelectedValue = dtConsulta.Rows(0).Item("ProveedorId")
                nudExistenciaMaxima.Value = dtConsulta.Rows(0).Item("ExistenciaMaxima")
                nudExistenciaMinima.Value = dtConsulta.Rows(0).Item("ExistenciaMinima")
                nudExistencia.Value = dtConsulta.Rows(0).Item("Existencia")
                cboTipoImpuesto.SelectedValue = dtConsulta.Rows(0).Item("TipoImpuestoId")
                cboUnidadMedida.SelectedValue = dtConsulta.Rows(0).Item("UnidadMedidaId")

                'Pasamos a la primera pestaña (Mantenimiento)
                tbcABM.SelectedIndex = 0
                'Bajamos la bandera de Nuevo Registro
                vNuevo = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If vNuevo = False Then
            'Preguntamos al usuario si está seguro de querer borrar el registro
            If MessageBox.Show("¿Está seguro de Eliminar el Registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

                Try
                    'Creación y seteo de objeto comando
                    Dim vComando As New SqlCommand
                    vComando.Connection = vConexion
                    vComando.CommandText = "delete from Articulo where ArticuloId = " & txtCodigo.Text

                    'Abrimos la conexión
                    vConexion.Open()
                    'Ejecutamos la sentencia SQL en la BD
                    vComando.ExecuteNonQuery()

                    MessageBox.Show("Registro Eliminado")
                    LimpiarFormulario()

                Catch ex As Exception
                    MessageBox.Show("Error al momento de Eliminar Registro" & vbNewLine & ex.Message)
                Finally
                    'Bloque opcional en una estructura TRY
                    'El bloque Finally se ejecuta siempre, haya habido o no una excepción
                    'En este bloque nos aseguramos que al final del proceso, sea exitoso o no, se cierre la conexión
                    vConexion.Close()
                End Try
            End If
        End If
    End Sub
End Class
