Public Class frmConsultaStock
    Private Sub frmConsultaStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        'Limpio la lista por si quedo algun registro de antes'
        LimpiarControles()
        cmbProductos.Items.Clear()
        'Cargo los productos en el combo box'
        ConectarBaseDeDatos()
        CargarComboBox("Productos", "Nombre", cmbProductos)
        CerrarBaseDeDatos()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Not cmbProductos.Text = "" Then
            ConectarBaseDeDatos()
            BuscarStockProductoPorNombre(cmbProductos.Text, dgvListaStock)
            CerrarBaseDeDatos()
        ElseIf Not cmbTipoProducto.Text = "" Then
            ConectarBaseDeDatos()
            BuscarStockProductoPorTipo(cmbTipoProducto.Text, dgvListaStock)
            CerrarBaseDeDatos()
        Else
            MessageBox.Show("Por favor ingresar Producto a buscar o tipo de producto que desa buscar!")
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarControles()
    End Sub

    Sub LimpiarControles()
        cmbProductos.Text = ""
        cmbProductos.SelectedIndex = -1
        cmbTipoProducto.Text = ""
        cmbTipoProducto.SelectedIndex = -1
        dgvListaStock.Rows.Clear()
        btnBuscar.Enabled = False
        cmbProductos.Focus()
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        btnBuscar.Enabled = True
    End Sub
End Class