<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultasVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gpbBusquedaPorFecha = New System.Windows.Forms.GroupBox()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.cmbVendedores = New System.Windows.Forms.ComboBox()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.lblLista = New System.Windows.Forms.Label()
        Me.gpbBusquedaPorVendedor = New System.Windows.Forms.GroupBox()
        Me.gpbDetalladoItems = New System.Windows.Forms.GroupBox()
        Me.rdbTodosItemsVendidos = New System.Windows.Forms.RadioButton()
        Me.rdbVentasPorFactura = New System.Windows.Forms.RadioButton()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rdbTodasLasVentas = New System.Windows.Forms.RadioButton()
        Me.rdbVentasPorFecha = New System.Windows.Forms.RadioButton()
        Me.gpbBusquedaPorFecha.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBusquedaPorVendedor.SuspendLayout()
        Me.gpbDetalladoItems.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbBusquedaPorFecha
        '
        Me.gpbBusquedaPorFecha.Controls.Add(Me.rdbVentasPorFecha)
        Me.gpbBusquedaPorFecha.Controls.Add(Me.rdbTodasLasVentas)
        Me.gpbBusquedaPorFecha.Controls.Add(Me.dtpHasta)
        Me.gpbBusquedaPorFecha.Controls.Add(Me.lblHasta)
        Me.gpbBusquedaPorFecha.Controls.Add(Me.dtpDesde)
        Me.gpbBusquedaPorFecha.Controls.Add(Me.lblDesde)
        Me.gpbBusquedaPorFecha.Location = New System.Drawing.Point(12, 12)
        Me.gpbBusquedaPorFecha.Name = "gpbBusquedaPorFecha"
        Me.gpbBusquedaPorFecha.Size = New System.Drawing.Size(372, 78)
        Me.gpbBusquedaPorFecha.TabIndex = 0
        Me.gpbBusquedaPorFecha.TabStop = False
        Me.gpbBusquedaPorFecha.Text = "Busqueda Por Fecha"
        '
        'dtpHasta
        '
        Me.dtpHasta.Enabled = False
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(282, 49)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(77, 20)
        Me.dtpHasta.TabIndex = 3
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Enabled = False
        Me.lblHasta.Location = New System.Drawing.Point(241, 53)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 2
        Me.lblHasta.Text = "Hasta"
        '
        'dtpDesde
        '
        Me.dtpDesde.Enabled = False
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(155, 49)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(77, 20)
        Me.dtpDesde.TabIndex = 1
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Enabled = False
        Me.lblDesde.Location = New System.Drawing.Point(111, 53)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(38, 13)
        Me.lblDesde.TabIndex = 0
        Me.lblDesde.Text = "Desde"
        '
        'cmbVendedores
        '
        Me.cmbVendedores.FormattingEnabled = True
        Me.cmbVendedores.Items.AddRange(New Object() {"Mateo", "Tomas", "Nicolas", "Fernando"})
        Me.cmbVendedores.Location = New System.Drawing.Point(80, 19)
        Me.cmbVendedores.Name = "cmbVendedores"
        Me.cmbVendedores.Size = New System.Drawing.Size(98, 21)
        Me.cmbVendedores.TabIndex = 10
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Location = New System.Drawing.Point(11, 23)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(53, 13)
        Me.lblVendedor.TabIndex = 9
        Me.lblVendedor.Text = "Vendedor"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(309, 211)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 211)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Factura, Me.Fecha, Me.Producto, Me.Cant, Me.PrecioUnitario, Me.PrecioCant, Me.Vendedor})
        Me.dgvVentas.Location = New System.Drawing.Point(401, 25)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(664, 209)
        Me.dgvVentas.TabIndex = 3
        '
        'lblLista
        '
        Me.lblLista.AutoSize = True
        Me.lblLista.Location = New System.Drawing.Point(401, 6)
        Me.lblLista.Name = "lblLista"
        Me.lblLista.Size = New System.Drawing.Size(79, 13)
        Me.lblLista.TabIndex = 4
        Me.lblLista.Text = "Lista de ventas"
        '
        'gpbBusquedaPorVendedor
        '
        Me.gpbBusquedaPorVendedor.Controls.Add(Me.cmbVendedores)
        Me.gpbBusquedaPorVendedor.Controls.Add(Me.lblVendedor)
        Me.gpbBusquedaPorVendedor.Location = New System.Drawing.Point(12, 156)
        Me.gpbBusquedaPorVendedor.Name = "gpbBusquedaPorVendedor"
        Me.gpbBusquedaPorVendedor.Size = New System.Drawing.Size(372, 49)
        Me.gpbBusquedaPorVendedor.TabIndex = 11
        Me.gpbBusquedaPorVendedor.TabStop = False
        Me.gpbBusquedaPorVendedor.Text = "Busqueda por Vendedor"
        '
        'gpbDetalladoItems
        '
        Me.gpbDetalladoItems.Controls.Add(Me.rdbVentasPorFactura)
        Me.gpbDetalladoItems.Controls.Add(Me.rdbTodosItemsVendidos)
        Me.gpbDetalladoItems.Location = New System.Drawing.Point(12, 96)
        Me.gpbDetalladoItems.Name = "gpbDetalladoItems"
        Me.gpbDetalladoItems.Size = New System.Drawing.Size(372, 54)
        Me.gpbDetalladoItems.TabIndex = 12
        Me.gpbDetalladoItems.TabStop = False
        Me.gpbDetalladoItems.Text = "Caracteristicas Reporte"
        '
        'rdbTodosItemsVendidos
        '
        Me.rdbTodosItemsVendidos.AutoSize = True
        Me.rdbTodosItemsVendidos.Checked = True
        Me.rdbTodosItemsVendidos.Location = New System.Drawing.Point(14, 20)
        Me.rdbTodosItemsVendidos.Name = "rdbTodosItemsVendidos"
        Me.rdbTodosItemsVendidos.Size = New System.Drawing.Size(144, 17)
        Me.rdbTodosItemsVendidos.TabIndex = 0
        Me.rdbTodosItemsVendidos.TabStop = True
        Me.rdbTodosItemsVendidos.Text = "Todos los items vendidos"
        Me.rdbTodosItemsVendidos.UseVisualStyleBackColor = True
        '
        'rdbVentasPorFactura
        '
        Me.rdbVentasPorFactura.AutoSize = True
        Me.rdbVentasPorFactura.Location = New System.Drawing.Point(175, 19)
        Me.rdbVentasPorFactura.Name = "rdbVentasPorFactura"
        Me.rdbVentasPorFactura.Size = New System.Drawing.Size(167, 17)
        Me.rdbVentasPorFactura.TabIndex = 1
        Me.rdbVentasPorFactura.Text = "Por factura (con datos cliente)"
        Me.rdbVentasPorFactura.UseVisualStyleBackColor = True
        '
        'Factura
        '
        Me.Factura.HeaderText = "Factura"
        Me.Factura.Name = "Factura"
        Me.Factura.Width = 50
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 75
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.Width = 150
        '
        'Cant
        '
        Me.Cant.HeaderText = "Cant"
        Me.Cant.Name = "Cant"
        Me.Cant.Width = 50
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.HeaderText = "PrecioUnit"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.Width = 95
        '
        'PrecioCant
        '
        Me.PrecioCant.HeaderText = "PrecioCant"
        Me.PrecioCant.Name = "PrecioCant"
        Me.PrecioCant.Width = 95
        '
        'Vendedor
        '
        Me.Vendedor.HeaderText = "Vendedor"
        Me.Vendedor.Name = "Vendedor"
        '
        'rdbTodasLasVentas
        '
        Me.rdbTodasLasVentas.AutoSize = True
        Me.rdbTodasLasVentas.Checked = True
        Me.rdbTodasLasVentas.Location = New System.Drawing.Point(14, 19)
        Me.rdbTodasLasVentas.Name = "rdbTodasLasVentas"
        Me.rdbTodasLasVentas.Size = New System.Drawing.Size(55, 17)
        Me.rdbTodasLasVentas.TabIndex = 4
        Me.rdbTodasLasVentas.TabStop = True
        Me.rdbTodasLasVentas.Text = "Todas"
        Me.rdbTodasLasVentas.UseVisualStyleBackColor = True
        '
        'rdbVentasPorFecha
        '
        Me.rdbVentasPorFecha.AutoSize = True
        Me.rdbVentasPorFecha.Location = New System.Drawing.Point(14, 49)
        Me.rdbVentasPorFecha.Name = "rdbVentasPorFecha"
        Me.rdbVentasPorFecha.Size = New System.Drawing.Size(74, 17)
        Me.rdbVentasPorFecha.TabIndex = 5
        Me.rdbVentasPorFecha.Text = "Por Fecha"
        Me.rdbVentasPorFecha.UseVisualStyleBackColor = True
        '
        'frmConsultasVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 246)
        Me.Controls.Add(Me.gpbDetalladoItems)
        Me.Controls.Add(Me.gpbBusquedaPorVendedor)
        Me.Controls.Add(Me.lblLista)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.gpbBusquedaPorFecha)
        Me.Name = "frmConsultasVentas"
        Me.Text = "Consulta Ventas"
        Me.gpbBusquedaPorFecha.ResumeLayout(False)
        Me.gpbBusquedaPorFecha.PerformLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBusquedaPorVendedor.ResumeLayout(False)
        Me.gpbBusquedaPorVendedor.PerformLayout()
        Me.gpbDetalladoItems.ResumeLayout(False)
        Me.gpbDetalladoItems.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpbBusquedaPorFecha As GroupBox
    Friend WithEvents cmbVendedores As ComboBox
    Friend WithEvents lblVendedor As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents lblHasta As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents lblDesde As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents lblLista As Label
    Friend WithEvents gpbBusquedaPorVendedor As GroupBox
    Friend WithEvents gpbDetalladoItems As GroupBox
    Friend WithEvents rdbVentasPorFactura As RadioButton
    Friend WithEvents rdbTodosItemsVendidos As RadioButton
    Friend WithEvents Factura As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCant As DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As DataGridViewTextBoxColumn
    Friend WithEvents rdbVentasPorFecha As RadioButton
    Friend WithEvents rdbTodasLasVentas As RadioButton
End Class
