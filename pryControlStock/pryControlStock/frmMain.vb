Public Class frmMain
    Private Sub pbNuevoProducto_Click(sender As Object, e As EventArgs) Handles pbNuevoProducto.Click
        frmAltaProducto.ShowDialog()
    End Sub

    Private Sub lblNuevoProducto_Click(sender As Object, e As EventArgs) Handles lblNuevoProducto.Click
        frmAltaProducto.ShowDialog()
    End Sub

    Private Sub pbCargarStock_Click(sender As Object, e As EventArgs) Handles pbCargarStock.Click
        frmCargaProducto.ShowDialog()
    End Sub

    Private Sub lblCargaStock_Click(sender As Object, e As EventArgs) Handles lblCargaStock.Click
        frmCargaProducto.ShowDialog()
    End Sub

    Private Sub pbConsultaStock_Click(sender As Object, e As EventArgs) Handles pbConsultaStock.Click
        frmConsultaStock.ShowDialog()
    End Sub

    Private Sub lblConsultarStock_Click(sender As Object, e As EventArgs) Handles lblConsultarStock.Click
        frmConsultaStock.ShowDialog()
    End Sub

    Private Sub pbNuevaVenta_Click(sender As Object, e As EventArgs) Handles pbNuevaVenta.Click
        frmVentas.ShowDialog()
    End Sub

    Private Sub lblNuevaVenta_Click(sender As Object, e As EventArgs) Handles lblNuevaVenta.Click
        frmVentas.ShowDialog()
    End Sub

    Private Sub pbConsultaVentas_Click(sender As Object, e As EventArgs) Handles pbConsultaVentas.Click
        frmConsultasVentas.ShowDialog()
    End Sub

    Private Sub lblConsultaVentas_Click(sender As Object, e As EventArgs) Handles lblConsultaVentas.Click
        frmConsultasVentas.ShowDialog()
    End Sub

    Private Sub pbNuevoPresupuesto_Click(sender As Object, e As EventArgs) Handles pbNuevoPresupuesto.Click
        frmPresupuesto.ShowDialog()
    End Sub

    Private Sub lblNuevoPresupuesto_Click(sender As Object, e As EventArgs) Handles lblNuevoPresupuesto.Click
        frmPresupuesto.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
