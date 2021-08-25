Public Class frmVentas
    Dim precioTotal As Long = 0
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        'Limpio la lista de venta'
        dgvVentas.Rows.Clear()

        'Cargo el combo box de productos'
        cmbProductos.Items.Clear()
        ConectarBaseDeDatos()
        CargarComboBox("Productos", "Nombre", cmbProductos)
        CerrarBaseDeDatos()

        'Cargo valor por defecto efectivo en forma de pago'
        cmbFormasPago.SelectedIndex = 0
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim precioCantidad As Long = 0

        precioCantidad = CInt(mskPrecio.Text) * CInt(mskCantidad.Text)

        dgvVentas.Rows.Add(cmbProductos.Text, mskCantidad.Text, mskPrecio.Text, precioCantidad)

        'Limpio los controles de la carga de producto'
        LimpiarControlesCargaProducto()

        precioTotal = precioTotal + precioCantidad
        lblPrecioTotal.Text = precioTotal
    End Sub

    Sub LimpiarControlesCargaProducto()
        cmbProductos.Text = ""
        cmbProductos.SelectedIndex = -1
        mskCantidad.Text = ""
        mskPrecio.Text = ""
        btnAgregar.Enabled = False
        cmbProductos.Focus()
    End Sub

    Private Sub chkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescuento.CheckedChanged
        lblTotalAPagar.Enabled = True
        mskTotalAPagar.Enabled = True
    End Sub

    Private Sub btnCargarVenta_Click(sender As Object, e As EventArgs) Handles btnCargarVenta.Click
        Dim montoAPagar, precioUnitario, precioCantidad, cantidad, codFactura, precioTotal As Long
        Dim producto As String

        If dgvVentas.Rows.Count < 1 Then
            MessageBox.Show("No se ingreso ningun articulo, carge la venta de nuevo!")
            Exit Sub
        End If

        ConectarBaseDeDatos()
        montoAPagar = 0
        precioUnitario = 0
        precioCantidad = 0
        precioTotal = 0



        'Leo el numero de factura anterior y le sumo 1' 
        codFactura = CInt(LeerDatosUltimaFactura("Ventas") + 1)

        'Recorro la la lista para cargar en la base de datos'

        If dgvVentas.Rows.Count > 0 Then
            For i = 0 To dgvVentas.Rows.Count - 2
                producto = dgvVentas.Rows.Item(i).Cells(0).Value
                cantidad = dgvVentas.Rows.Item(i).Cells(1).Value
                precioUnitario = dgvVentas.Rows.Item(i).Cells(2).Value
                precioCantidad = dgvVentas.Rows.Item(i).Cells(3).Value
                precioTotal = precioTotal + precioCantidad
                InsertarDatos("Ventas(Factura, Fecha, Producto, Cantidad, PrecioUnitario, PrecioCantidad, Vendedor)", codFactura, dtpFechaVenta.Value, producto, cantidad, precioUnitario, precioCantidad, cmbVendedores.Text)
                CambiarCantidadStockPorVenta(producto, cantidad)

            Next
        End If

        'Verifico si tiene descuento o no la venta'
        If chkDescuento.Checked Then
            montoAPagar = CInt(mskTotalAPagar.Text)
        Else
            montoAPagar = precioTotal
        End If

        'Cargo la venta completa en registro de ventas'
        If mskTelCliente.Text = "" And txtMailCliente.Text = "" Then
            InsertarDatos("RegistroVentas(Factura, Fecha, MontoTotal, FormaPago, Vendedor, MailCliente, TelCliente, PrecioDescuento)", codFactura, dtpFechaVenta.Value, precioTotal, cmbFormasPago.Text, cmbVendedores.Text, "",
                      0, montoAPagar)
        ElseIf Not mskTelCliente.Text = "" And txtMailCliente.Text = "" Then
            InsertarDatos("RegistroVentas(Factura, Fecha, MontoTotal, FormaPago, Vendedor, MailCliente, TelCliente, PrecioDescuento)", codFactura, dtpFechaVenta.Value, precioTotal, cmbFormasPago.Text, cmbVendedores.Text, "",
                      mskTelCliente.Text, montoAPagar)
        ElseIf mskTelCliente.Text = "" And Not txtMailCliente.Text = "" Then
            InsertarDatos("RegistroVentas(Factura, Fecha, MontoTotal, FormaPago, Vendedor, MailCliente, TelCliente, PrecioDescuento)", codFactura, dtpFechaVenta.Value, precioTotal, cmbFormasPago.Text, cmbVendedores.Text, txtMailCliente.Text,
                      0, montoAPagar)
        Else
            InsertarDatos("RegistroVentas(Factura, Fecha, MontoTotal, FormaPago, Vendedor, MailCliente, TelCliente, PrecioDescuento)", codFactura, dtpFechaVenta.Value, precioTotal, cmbFormasPago.Text, cmbVendedores.Text, txtMailCliente.Text,
                      mskTelCliente.Text, montoAPagar)
        End If
        CerrarBaseDeDatos()

        MessageBox.Show("Venta cargada con exito!")
        LimpiarControles()
    End Sub

    Sub LimpiarControles()
        dtpFechaVenta.Value = Today
        cmbVendedores.SelectedIndex = -1
        cmbVendedores.Text = ""
        cmbFormasPago.SelectedIndex = 0
        mskTelCliente.Text = ""
        txtMailCliente.Text = ""
        lblPrecioTotal.Text = "0"
        chkDescuento.Checked = False
        mskTotalAPagar.Text = ""
        mskTotalAPagar.Enabled = False
        dgvVentas.Rows.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarControles()
    End Sub

    Private Sub mskPrecio_TextChanged(sender As Object, e As EventArgs) Handles mskPrecio.TextChanged
        btnAgregar.Enabled = True
    End Sub

End Class