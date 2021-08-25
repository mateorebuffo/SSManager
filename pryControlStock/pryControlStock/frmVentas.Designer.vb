<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Me.gpbDatosVentas = New System.Windows.Forms.GroupBox()
        Me.mskPrecio = New System.Windows.Forms.MaskedTextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.mskCantidad = New System.Windows.Forms.MaskedTextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblListaProductos = New System.Windows.Forms.Label()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpbDatosVenta = New System.Windows.Forms.GroupBox()
        Me.txtMailCliente = New System.Windows.Forms.TextBox()
        Me.lblMailCliente = New System.Windows.Forms.Label()
        Me.mskTelCliente = New System.Windows.Forms.MaskedTextBox()
        Me.lblNumeroTelCliente = New System.Windows.Forms.Label()
        Me.dtpFechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaVenta = New System.Windows.Forms.Label()
        Me.cmbFormasPago = New System.Windows.Forms.ComboBox()
        Me.lblFormaPago = New System.Windows.Forms.Label()
        Me.cmbVendedores = New System.Windows.Forms.ComboBox()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.gpbTotales = New System.Windows.Forms.GroupBox()
        Me.mskTotalAPagar = New System.Windows.Forms.MaskedTextBox()
        Me.lblTotalAPagar = New System.Windows.Forms.Label()
        Me.chkDescuento = New System.Windows.Forms.CheckBox()
        Me.lblPrecioTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCargarVenta = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.gpbDatosVentas.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDatosVenta.SuspendLayout()
        Me.gpbTotales.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbDatosVentas
        '
        Me.gpbDatosVentas.Controls.Add(Me.mskPrecio)
        Me.gpbDatosVentas.Controls.Add(Me.lblPrecio)
        Me.gpbDatosVentas.Controls.Add(Me.btnCancelar)
        Me.gpbDatosVentas.Controls.Add(Me.mskCantidad)
        Me.gpbDatosVentas.Controls.Add(Me.btnAgregar)
        Me.gpbDatosVentas.Controls.Add(Me.lblCantidad)
        Me.gpbDatosVentas.Controls.Add(Me.cmbProductos)
        Me.gpbDatosVentas.Controls.Add(Me.lblProducto)
        Me.gpbDatosVentas.Location = New System.Drawing.Point(12, 12)
        Me.gpbDatosVentas.Name = "gpbDatosVentas"
        Me.gpbDatosVentas.Size = New System.Drawing.Size(231, 158)
        Me.gpbDatosVentas.TabIndex = 0
        Me.gpbDatosVentas.TabStop = False
        Me.gpbDatosVentas.Text = "Productos"
        '
        'mskPrecio
        '
        Me.mskPrecio.Location = New System.Drawing.Point(75, 96)
        Me.mskPrecio.Mask = "99999999"
        Me.mskPrecio.Name = "mskPrecio"
        Me.mskPrecio.Size = New System.Drawing.Size(58, 20)
        Me.mskPrecio.TabIndex = 3
        Me.mskPrecio.ValidatingType = GetType(Integer)
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(7, 99)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 4
        Me.lblPrecio.Text = "Precio"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(6, 129)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'mskCantidad
        '
        Me.mskCantidad.Location = New System.Drawing.Point(75, 56)
        Me.mskCantidad.Mask = "99999"
        Me.mskCantidad.Name = "mskCantidad"
        Me.mskCantidad.Size = New System.Drawing.Size(58, 20)
        Me.mskCantidad.TabIndex = 2
        Me.mskCantidad.ValidatingType = GetType(Integer)
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Location = New System.Drawing.Point(152, 129)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(7, 60)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 2
        Me.lblCantidad.Text = "Cantidad"
        '
        'cmbProductos
        '
        Me.cmbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(75, 21)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(152, 21)
        Me.cmbProductos.TabIndex = 1
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(7, 25)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Producto"
        '
        'lblListaProductos
        '
        Me.lblListaProductos.AutoSize = True
        Me.lblListaProductos.Location = New System.Drawing.Point(249, 12)
        Me.lblListaProductos.Name = "lblListaProductos"
        Me.lblListaProductos.Size = New System.Drawing.Size(79, 13)
        Me.lblListaProductos.TabIndex = 3
        Me.lblListaProductos.Text = "Lista productos"
        '
        'dgvVentas
        '
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Subtotal})
        Me.dgvVentas.Location = New System.Drawing.Point(252, 30)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(413, 140)
        Me.dgvVentas.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Producto"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cantidad"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio Unitario"
        Me.Column3.Name = "Column3"
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Precio Cantidad"
        Me.Subtotal.Name = "Subtotal"
        '
        'gpbDatosVenta
        '
        Me.gpbDatosVenta.Controls.Add(Me.txtMailCliente)
        Me.gpbDatosVenta.Controls.Add(Me.lblMailCliente)
        Me.gpbDatosVenta.Controls.Add(Me.mskTelCliente)
        Me.gpbDatosVenta.Controls.Add(Me.lblNumeroTelCliente)
        Me.gpbDatosVenta.Controls.Add(Me.dtpFechaVenta)
        Me.gpbDatosVenta.Controls.Add(Me.lblFechaVenta)
        Me.gpbDatosVenta.Controls.Add(Me.cmbFormasPago)
        Me.gpbDatosVenta.Controls.Add(Me.lblFormaPago)
        Me.gpbDatosVenta.Controls.Add(Me.cmbVendedores)
        Me.gpbDatosVenta.Controls.Add(Me.lblVendedor)
        Me.gpbDatosVenta.Location = New System.Drawing.Point(12, 177)
        Me.gpbDatosVenta.Name = "gpbDatosVenta"
        Me.gpbDatosVenta.Size = New System.Drawing.Size(398, 106)
        Me.gpbDatosVenta.TabIndex = 1
        Me.gpbDatosVenta.TabStop = False
        Me.gpbDatosVenta.Text = "Datos Venta"
        '
        'txtMailCliente
        '
        Me.txtMailCliente.Location = New System.Drawing.Point(267, 77)
        Me.txtMailCliente.Name = "txtMailCliente"
        Me.txtMailCliente.Size = New System.Drawing.Size(112, 20)
        Me.txtMailCliente.TabIndex = 4
        '
        'lblMailCliente
        '
        Me.lblMailCliente.AutoSize = True
        Me.lblMailCliente.Location = New System.Drawing.Point(200, 80)
        Me.lblMailCliente.Name = "lblMailCliente"
        Me.lblMailCliente.Size = New System.Drawing.Size(61, 13)
        Me.lblMailCliente.TabIndex = 11
        Me.lblMailCliente.Text = "Mail Cliente"
        '
        'mskTelCliente
        '
        Me.mskTelCliente.Location = New System.Drawing.Point(91, 77)
        Me.mskTelCliente.Mask = "9999999999"
        Me.mskTelCliente.Name = "mskTelCliente"
        Me.mskTelCliente.Size = New System.Drawing.Size(92, 20)
        Me.mskTelCliente.TabIndex = 3
        Me.mskTelCliente.ValidatingType = GetType(Integer)
        '
        'lblNumeroTelCliente
        '
        Me.lblNumeroTelCliente.AutoSize = True
        Me.lblNumeroTelCliente.Location = New System.Drawing.Point(9, 80)
        Me.lblNumeroTelCliente.Name = "lblNumeroTelCliente"
        Me.lblNumeroTelCliente.Size = New System.Drawing.Size(57, 13)
        Me.lblNumeroTelCliente.TabIndex = 9
        Me.lblNumeroTelCliente.Text = "Tel Cliente"
        '
        'dtpFechaVenta
        '
        Me.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVenta.Location = New System.Drawing.Point(91, 19)
        Me.dtpFechaVenta.Name = "dtpFechaVenta"
        Me.dtpFechaVenta.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaVenta.TabIndex = 0
        Me.dtpFechaVenta.Value = New Date(2021, 7, 25, 12, 21, 32, 0)
        '
        'lblFechaVenta
        '
        Me.lblFechaVenta.AutoSize = True
        Me.lblFechaVenta.Location = New System.Drawing.Point(9, 23)
        Me.lblFechaVenta.Name = "lblFechaVenta"
        Me.lblFechaVenta.Size = New System.Drawing.Size(37, 13)
        Me.lblFechaVenta.TabIndex = 7
        Me.lblFechaVenta.Text = "Fecha"
        '
        'cmbFormasPago
        '
        Me.cmbFormasPago.FormattingEnabled = True
        Me.cmbFormasPago.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbFormasPago.Items.AddRange(New Object() {"Efectivo", "Transferencia", "Tarjeta"})
        Me.cmbFormasPago.Location = New System.Drawing.Point(91, 47)
        Me.cmbFormasPago.Name = "cmbFormasPago"
        Me.cmbFormasPago.Size = New System.Drawing.Size(93, 21)
        Me.cmbFormasPago.TabIndex = 2
        '
        'lblFormaPago
        '
        Me.lblFormaPago.AutoSize = True
        Me.lblFormaPago.Location = New System.Drawing.Point(7, 51)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(78, 13)
        Me.lblFormaPago.TabIndex = 2
        Me.lblFormaPago.Text = "Forma de pago"
        '
        'cmbVendedores
        '
        Me.cmbVendedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbVendedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbVendedores.FormattingEnabled = True
        Me.cmbVendedores.Items.AddRange(New Object() {"Mateo", "Tomas", "Nicolas", "Fernando"})
        Me.cmbVendedores.Location = New System.Drawing.Point(267, 19)
        Me.cmbVendedores.Name = "cmbVendedores"
        Me.cmbVendedores.Size = New System.Drawing.Size(113, 21)
        Me.cmbVendedores.TabIndex = 1
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Location = New System.Drawing.Point(200, 23)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(53, 13)
        Me.lblVendedor.TabIndex = 1
        Me.lblVendedor.Text = "Vendedor"
        '
        'gpbTotales
        '
        Me.gpbTotales.Controls.Add(Me.mskTotalAPagar)
        Me.gpbTotales.Controls.Add(Me.lblTotalAPagar)
        Me.gpbTotales.Controls.Add(Me.chkDescuento)
        Me.gpbTotales.Controls.Add(Me.lblPrecioTotal)
        Me.gpbTotales.Controls.Add(Me.lblTotal)
        Me.gpbTotales.Location = New System.Drawing.Point(416, 177)
        Me.gpbTotales.Name = "gpbTotales"
        Me.gpbTotales.Size = New System.Drawing.Size(249, 106)
        Me.gpbTotales.TabIndex = 3
        Me.gpbTotales.TabStop = False
        Me.gpbTotales.Text = "Totales"
        '
        'mskTotalAPagar
        '
        Me.mskTotalAPagar.Enabled = False
        Me.mskTotalAPagar.Location = New System.Drawing.Point(98, 73)
        Me.mskTotalAPagar.Mask = "9999999999999"
        Me.mskTotalAPagar.Name = "mskTotalAPagar"
        Me.mskTotalAPagar.Size = New System.Drawing.Size(92, 20)
        Me.mskTotalAPagar.TabIndex = 1
        Me.mskTotalAPagar.ValidatingType = GetType(Integer)
        '
        'lblTotalAPagar
        '
        Me.lblTotalAPagar.AutoSize = True
        Me.lblTotalAPagar.Enabled = False
        Me.lblTotalAPagar.Location = New System.Drawing.Point(10, 75)
        Me.lblTotalAPagar.Name = "lblTotalAPagar"
        Me.lblTotalAPagar.Size = New System.Drawing.Size(82, 13)
        Me.lblTotalAPagar.TabIndex = 3
        Me.lblTotalAPagar.Text = "Total a pagar: $"
        '
        'chkDescuento
        '
        Me.chkDescuento.AutoSize = True
        Me.chkDescuento.Location = New System.Drawing.Point(14, 47)
        Me.chkDescuento.Name = "chkDescuento"
        Me.chkDescuento.Size = New System.Drawing.Size(78, 17)
        Me.chkDescuento.TabIndex = 0
        Me.chkDescuento.Text = "Descuento"
        Me.chkDescuento.UseVisualStyleBackColor = True
        '
        'lblPrecioTotal
        '
        Me.lblPrecioTotal.AutoSize = True
        Me.lblPrecioTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrecioTotal.Location = New System.Drawing.Point(55, 23)
        Me.lblPrecioTotal.Name = "lblPrecioTotal"
        Me.lblPrecioTotal.Size = New System.Drawing.Size(15, 15)
        Me.lblPrecioTotal.TabIndex = 1
        Me.lblPrecioTotal.Text = "0"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(10, 23)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(43, 13)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total: $"
        '
        'btnCargarVenta
        '
        Me.btnCargarVenta.Location = New System.Drawing.Point(578, 289)
        Me.btnCargarVenta.Name = "btnCargarVenta"
        Me.btnCargarVenta.Size = New System.Drawing.Size(87, 31)
        Me.btnCargarVenta.TabIndex = 2
        Me.btnCargarVenta.Text = "Cargar"
        Me.btnCargarVenta.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 289)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(87, 31)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 325)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCargarVenta)
        Me.Controls.Add(Me.gpbTotales)
        Me.Controls.Add(Me.gpbDatosVenta)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.lblListaProductos)
        Me.Controls.Add(Me.gpbDatosVentas)
        Me.Name = "frmVentas"
        Me.Text = "Ventas"
        Me.gpbDatosVentas.ResumeLayout(False)
        Me.gpbDatosVentas.PerformLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDatosVenta.ResumeLayout(False)
        Me.gpbDatosVenta.PerformLayout()
        Me.gpbTotales.ResumeLayout(False)
        Me.gpbTotales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpbDatosVentas As GroupBox
    Friend WithEvents mskPrecio As MaskedTextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents mskCantidad As MaskedTextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblListaProductos As Label
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents gpbDatosVenta As GroupBox
    Friend WithEvents dtpFechaVenta As DateTimePicker
    Friend WithEvents lblFechaVenta As Label
    Friend WithEvents cmbFormasPago As ComboBox
    Friend WithEvents lblFormaPago As Label
    Friend WithEvents cmbVendedores As ComboBox
    Friend WithEvents lblVendedor As Label
    Friend WithEvents gpbTotales As GroupBox
    Friend WithEvents lblPrecioTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtMailCliente As TextBox
    Friend WithEvents lblMailCliente As Label
    Friend WithEvents mskTelCliente As MaskedTextBox
    Friend WithEvents lblNumeroTelCliente As Label
    Friend WithEvents mskTotalAPagar As MaskedTextBox
    Friend WithEvents lblTotalAPagar As Label
    Friend WithEvents chkDescuento As CheckBox
    Friend WithEvents btnCargarVenta As Button
    Friend WithEvents btnLimpiar As Button
End Class
