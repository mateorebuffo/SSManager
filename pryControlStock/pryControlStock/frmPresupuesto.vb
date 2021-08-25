Public Class frmPresupuesto
    Dim precioTotal = 0
    Private Sub frmPresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        dgvPresupuesto.Rows.Clear()

        'Cargo el combo box de productos'
        cmbProductos.Items.Clear()
        ConectarBaseDeDatos()
        CargarComboBox("Productos", "Nombre", cmbProductos)
        CerrarBaseDeDatos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim precioCantidad As Long = 0

        precioCantidad = CInt(mskPrecio.Text) * CInt(mskCantidad.Text)

        dgvPresupuesto.Rows.Add(cmbProductos.Text, mskCantidad.Text, mskPrecio.Text, precioCantidad)

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

    Private Sub btnCopiar_Click(sender As Object, e As EventArgs) Handles btnCopiar.Click
        Dim cadenaCopiado, producto, cantidad, precioUnitario, precioCant, total As String

        cadenaCopiado = ""
        producto = ""
        cantidad = ""
        precioUnitario = ""
        precioCant = ""
        total = ""

        For i = 0 To dgvPresupuesto.Rows.Count - 2
            producto = dgvPresupuesto.Rows.Item(i).Cells(0).Value
            cantidad = dgvPresupuesto.Rows.Item(i).Cells(1).Value
            precioUnitario = dgvPresupuesto.Rows.Item(i).Cells(2).Value
            precioCant = dgvPresupuesto.Rows.Item(i).Cells(3).Value
            cadenaCopiado = cadenaCopiado & "- " & producto & "          $" & precioUnitario & " C/U  = $" & precioCant & vbCrLf
        Next

        cadenaCopiado = cadenaCopiado & vbCrLf & "TOTAL = $ " & precioTotal

        Clipboard.SetText(cadenaCopiado)

        MessageBox.Show("Presupuesto Copiado con exito")
    End Sub

    Private Sub mskPrecio_TextChanged(sender As Object, e As EventArgs) Handles mskPrecio.TextChanged
        btnAgregar.Enabled = True
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarControles()
    End Sub

    Sub limpiarControles()
        dgvPresupuesto.Rows.Clear()
        lblPrecioTotal.Text = "0"
        cmbProductos.SelectedIndex = -1
        cmbProductos.Text = ""
        mskCantidad.Text = ""
        mskPrecio.Text = ""
        btnAgregar.Enabled = False
        cmbProductos.Focus()
    End Sub
End Class