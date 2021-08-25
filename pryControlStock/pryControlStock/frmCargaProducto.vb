Public Class frmCargaProducto

    Private Sub frmCargaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        'Limpio el combobox por si carga dos veces el load no me repita los productos en el cmb'
        cmbProductos.Items.Clear()

        'Cargo los productos en el combo box'
        ConectarBaseDeDatos()
        CargarComboBox("Productos", "Nombre", cmbProductos)
        CerrarBaseDeDatos()
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        'Actualizo la cantida de stock de un producto'
        ConectarBaseDeDatos()
        CambiarCantidadStock(cmbProductos.Text, CInt(mskCantidad.Text))
        CerrarBaseDeDatos()
        LimpiarControles()
    End Sub


    Sub LimpiarControles()
        cmbProductos.Text = ""
        cmbProductos.SelectedIndex = -1
        mskCantidad.Text = ""
        mskCantidad.Enabled = False
        btnCargar.Enabled = False
        cmbProductos.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarControles()
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        mskCantidad.Enabled = True
    End Sub

    Private Sub mskCantidad_TextChanged(sender As Object, e As EventArgs) Handles mskCantidad.TextChanged
        btnCargar.Enabled = True
    End Sub
End Class