Public Class frmConsultasVentas
    Private Sub frmConsultasVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()

        dgvVentas.Rows.Clear()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'Uso el rdb todos items vendidos por detallar que voy a necesitar el reporte de cada articulo vendido, en cambio si necesito la factura usaria rdb Ventas por factura'
        ConectarBaseDeDatos()
        If rdbTodasLasVentas.Checked = True And rdbTodosItemsVendidos.Checked = True And cmbVendedores.Text = "" Then
            BuscarTodasLasVentas(dgvVentas)
        ElseIf rdbVentasPorFecha.Checked = True And rdbTodosItemsVendidos.Checked = True Then
            BuscarVentasPorFecha(dgvVentas, dtpDesde.Value, dtpHasta.Value)

        ElseIf Not cmbVendedores.Text = "" Then
            BuscarVentasPorVendedor(dgvVentas, cmbVendedores.Text)
        End If


        CerrarBaseDeDatos()
    End Sub

    Private Sub rdbVentasPorFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rdbVentasPorFecha.CheckedChanged
        lblDesde.Enabled = True
        lblHasta.Enabled = True
        dtpDesde.Enabled = True
        dtpHasta.Enabled = True
    End Sub

    Private Sub rdbTodasLasVentas_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTodasLasVentas.CheckedChanged
        lblDesde.Enabled = False
        lblHasta.Enabled = False
        dtpDesde.Enabled = False
        dtpHasta.Enabled = False
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dgvVentas.Rows.Clear()
        dtpDesde.Value = Today
        dtpHasta.Value = Today
        lblDesde.Enabled = False
        lblHasta.Enabled = False
        dtpDesde.Enabled = False
        dtpHasta.Enabled = False
        rdbTodasLasVentas.Checked = True
        rdbTodosItemsVendidos.Checked = True
        cmbVendedores.SelectedIndex = -1
        cmbVendedores.Text = ""

    End Sub
End Class