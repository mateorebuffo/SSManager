Public Class frmAltaProducto
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ConectarBaseDeDatos()
        InsertarDatos("Productos(Codigo, Nombre, Categoria, Descripcion)", txtCodigo.Text, txtNombreProducto.Text, cmbCategoria.Text, txtDescripcion.Text)
        InsertarDatos("Stock(Codigo, Nombre, Categoria, Cantidad)", txtCodigo.Text, txtNombreProducto.Text, cmbCategoria.Text, 0)
        CerrarBaseDeDatos()
        LimpiarControles()
    End Sub

    Sub LimpiarControles()
        txtCodigo.Text = ""
        txtNombreProducto.Text = ""
        cmbCategoria.Text = ""
        cmbCategoria.SelectedIndex = -1
        txtDescripcion.Text = ""
        txtNombreProducto.Enabled = False
        cmbCategoria.Enabled = False
        txtDescripcion.Enabled = False
        txtCodigo.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpiarControles()
    End Sub

    Private Sub frmAltaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        txtNombreProducto.Enabled = True
    End Sub

    Private Sub txtNombreProducto_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProducto.TextChanged
        cmbCategoria.Enabled = True
    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedIndexChanged
        txtDescripcion.Enabled = True
        btnRegistrar.Enabled = True
    End Sub
End Class