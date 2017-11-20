Public Class frmArticulo

    'Variable que se usa como bandera para determinar si es un nuevo registro
    Dim vNuevo As Boolean = True
    Dim dvArticulo As DataView

    Private Sub frmArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Determinamos el origen de datos del combo
        cboProveedor.DataSource = generar_datatabla("select * from Proveedor")
        'Campo a mostrar
        cboProveedor.DisplayMember = "Nombre"
        'Campo de la tabla que identifica al código
        cboProveedor.ValueMember = "ProveedorID"

        cboTipoImpuesto.DataSource = generar_datatabla("select * from TipoImpuesto")
        cboTipoImpuesto.DisplayMember = "Descripcion"
        cboTipoImpuesto.ValueMember = "TipoImpuestoID"

        cboUnidadMedida.DataSource = generar_datatabla("select * from UnidadMedida")
        cboUnidadMedida.ValueMember = "UnidadMedidaID"
        cboUnidadMedida.DisplayMember = "Descripcion"
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        'Try...Catch es una estructura para control de errores
        Try
            If DatosValidos() Then
                'Si nuevo es igual a verdadero significa que tenemos que insertar un registro a la bd
                If vNuevo = True Then
                    EjecutarSQL("insert into Articulo values(@1,@2,@3,@4,@5,@6,@7,@8,@9)",
txtDescripcion.Text.Trim, nudPrecioVenta.Value, nudPrecioCompra.Value, cboProveedor.SelectedValue, nudExistenciaMax.Value, nudExistenciaMin.Value, nudExistencia.Value, cboTipoImpuesto.SelectedValue, cboUnidadMedida.SelectedValue)
                    'Sino, significa que el registro ya existe y se debe actualizar
                Else
                    EjecutarSQL("update Articulo set descripcion=@1, precioventa=@2, preciocompra=@3, proveedorid=@4, existenciamaxima=@5, existenciaminima=@6, existencia=@7, tipoimpuestoid=@8, unidadmedidaid=@9 where articuloid=@10",
txtDescripcion.Text.Trim, nudPrecioVenta.Value, nudPrecioCompra.Value, cboProveedor.SelectedValue, nudExistenciaMax.Value, nudExistenciaMin.Value, nudExistencia.Value, cboTipoImpuesto.SelectedValue, cboUnidadMedida.SelectedValue, txtCodArticulo.Text.Trim)
                End If

                MessageBox.Show("Registro guardado con éxito!!!")
                LimpiarForm()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Function DatosValidos() As Boolean
        If txtDescripcion.Text.Trim = "" Then
            MessageBox.Show("Debe ingresar la descripción!!", "Sistema Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescripcion.Focus()
            Return False
        End If

        If nudPrecioVenta.Value = 0 Then
            MessageBox.Show("Debe ingresar el precio de venta!!", "Sistema Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            nudPrecioVenta.Focus()
            Return False
        End If

        If nudPrecioCompra.Value = 0 Then
            MessageBox.Show("Debe ingresar el precio de compra!!", "Sistema Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            nudPrecioVenta.Focus()
            Return False
        End If

        'FALTA VALIDAR EXISTENCIA MAX, MIN, EXISTENCIA...SE VALIDA IGUAL QUE LOS NUD ANTERIORES

        If cboProveedor.Text.Trim = "" Then
            MessageBox.Show("Debe ingresar seleccionar un proveedor!!", "Sistema Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboProveedor.Focus()
            Return False
        End If

        'FALTA VALIDAR TIPO IMPUESTO Y UNIDAD DE MEDIDA, SE VALIDA IGUAL QUE EL COMBO DE PROVEEDOR


        Return True
    End Function

    Private Sub LimpiarForm()
        txtCodArticulo.Text = ""
        txtDescripcion.Text = ""
        nudPrecioVenta.Value = 0
        nudPrecioCompra.Value = 0
        cboProveedor.SelectedIndex = -1
        nudExistencia.Value = 0
        nudExistenciaMin.Value = 0
        nudExistenciaMax.Value = 0
        cboTipoImpuesto.SelectedIndex = -1
        cboUnidadMedida.SelectedIndex = -1

        vNuevo = True
    End Sub

    'Evento que hace referencia al cambio de pestaña en el tab control
    Sub tabTabla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcPrincipal.SelectedIndexChanged

        'Si la pestaña seleccionada es 1, significa que está seleccionada la pestaña de consulta

        If tbcPrincipal.SelectedIndex = 1 Then

            'A nivel de clase habíamos declarado un DataView, que ahora lo llenamos mediante la función generar_datatabla, pero el resultado (Un DataTable) lo convertimos a un DataView

            dvArticulo = generar_datatabla("SELECT ArticuloID, Articulo.Descripcion, PrecioVenta, PrecioCompra, Articulo.ProveedorID, Proveedor.Nombre, ExistenciaMaxima, ExistenciaMinima, Existencia, Articulo.TipoImpuestoID, TipoImpuesto.Descripcion AS DescTipoImpuesto, Articulo.UnidadMedidaID, UnidadMedida.Descripcion DescUnidadMedida FROM Articulo JOIN Proveedor ON Articulo.ProveedorID = Proveedor.ProveedorID JOIN TipoImpuesto ON Articulo.TipoImpuestoID = TipoImpuesto.TipoImpuestoID JOIN UnidadMedida ON Articulo.UnidadMedidaID = UnidadMedida.UnidadMedidaID").DefaultView

            'Asignamos el DataView como Origen de Datos de la grilla

            dgvConsulta.DataSource = dvArticulo


            'Editamos los titulos de las columnas de la Grilla

            dgvConsulta.Columns(0).HeaderText = "Cód."
            dgvConsulta.Columns(1).HeaderText = "Descripción"
            dgvConsulta.Columns(2).HeaderText = "Precio de Venta"
            dgvConsulta.Columns(3).HeaderText = "Precio de Compra"
            dgvConsulta.Columns(4).HeaderText = "Cód. Proveedor"
            dgvConsulta.Columns(5).HeaderText = "Proveedor"
            dgvConsulta.Columns(6).HeaderText = "Existencia Máxima"
            dgvConsulta.Columns(7).HeaderText = "Existencia Mínima"
            dgvConsulta.Columns(8).HeaderText = "Existencia"
            dgvConsulta.Columns(9).HeaderText = "Cód. Tipo Impuesto"
            dgvConsulta.Columns(10).HeaderText = "Tipo de Impuesto"
            dgvConsulta.Columns(11).HeaderText = "Cód. Unidad Medida"
            dgvConsulta.Columns(12).HeaderText = "Unidad de Medida"

            'Ponemos la grila en modo Solo Lectura, de manera a que el usuario no pueda editar su contenido.

            dgvConsulta.ReadOnly = True

        End If


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarForm()
    End Sub

    'CellDoubleClick evento que se dispara al dar doble click sobre una celda de la grilla
    Private Sub dgvConsulta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConsulta.CellDoubleClick
        'Instanciamos un objeto del tipo DataTable, que es una tabla en memoria, en la cual volcaremos los datos de la base datos a nuestra aplicación
        Dim dtArticulo As New DataTable
        'En el commandText filtramos para que traiga los datos solo del articulo seleccionado, a través de la instrucción "where"
        'dgvConsulta(0, e.RowIndex) --> Cero hace referencia a la primera columna, y e.RowIndex hace referencia a la fila seleccionada
        dtArticulo = generar_datatabla("select * from articulo where articuloid=" & dgvConsulta(0, e.RowIndex).Value)
        If dtArticulo.Rows.Count > 0 Then
            'Rows(0) hace referencia a la primera fila recuperada de la base de datos, que en este caso es la única, ya que por el where en la sentencia sql estamos recuperando un solo registro. Item("Columna") hace referencia a la columna que queremos recuperar de la tabla, tiene que coincidir con el nombre del campo en la tabla.
            txtCodArticulo.Text = dtArticulo.Rows(0).Item("ArticuloID")
            txtDescripcion.Text = dtArticulo.Rows(0).Item("Descripcion")
            nudPrecioVenta.Value = dtArticulo.Rows(0).Item("PrecioVenta")
            nudPrecioCompra.Value = dtArticulo.Rows(0).Item("PrecioCompra")
            cboProveedor.SelectedValue = dtArticulo.Rows(0).Item("ProveedorID")
            nudExistenciaMax.Value = dtArticulo.Rows(0).Item("ExistenciaMaxima")
            nudExistenciaMin.Value = dtArticulo.Rows(0).Item("ExistenciaMinima")
            nudExistencia.Value = dtArticulo.Rows(0).Item("Existencia")
            cboTipoImpuesto.SelectedValue = dtArticulo.Rows(0).Item("TipoImpuestoID")
            cboUnidadMedida.SelectedValue = dtArticulo.Rows(0).Item("UnidadMedidaID")

            'Para pasar a la primera pestaña (ABM) del tabControl
            tbcPrincipal.SelectedIndex = 0

            'La bandera que nos permite determinar si un registro es nuevo o no, en este caso como recuperamos datos de la bd asignamos false ya que sabemos el registro no es nuevo.
            vNuevo = False
        End If


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            'Para poder eliminar el registro ya tiene que existir en la bd, sé que ya existe cuando vNuevo = False porque se asignó este valor en el cellDoubleClick de la grilla.
            If MessageBox.Show("Está seguro que desea eliminar el registro?", "Sistema de Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
                If vNuevo = False Then
                    EjecutarSQL("delete from articulo where articuloid=@1", txtCodArticulo.Text.Trim)
                    LimpiarForm()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'Dejamos el DataView sin ningún filtro
        dvArticulo.RowFilter = ""

        'Dependiendo de lo ingresado por el usuario, armamos el filtro correspondiente

        If txtDescripcionConsulta.Text.Trim() <> "" Then
            dvArticulo.RowFilter = "Descripcion like '%" & txtDescripcionConsulta.Text.Trim() & "%'"
        End If

        If nudCodigoConsulta.Value <> 0 Then
            If dvArticulo.RowFilter <> "" Then
                dvArticulo.RowFilter = dvArticulo.RowFilter & " and ArticuloID = " & nudCodigoConsulta.Value
            Else
                dvArticulo.RowFilter = dvArticulo.RowFilter & "ArticuloId = " & nudCodigoConsulta.Value
            End If
        End If

        'Es importante recordar que el filtro aplicado a un DataView ya es realizado en memoria, es decir, ya no va a la BD.

    End Sub

    Private Sub txtDescripcionConsulta_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcionConsulta.TextChanged
        'Hacer click en el botón Buscar mediante código
        btnBuscar.PerformClick()

    End Sub

    Private Sub nudCodigoConsulta_ValueChanged(sender As Object, e As EventArgs) Handles nudCodigoConsulta.ValueChanged
        'Invocar a un Evento ya existente
        btnBuscar_Click(Me, New EventArgs)
    End Sub
End Class