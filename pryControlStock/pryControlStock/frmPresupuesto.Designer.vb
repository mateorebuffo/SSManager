<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresupuesto
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
        Me.dgvPresupuesto = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblListaProductos = New System.Windows.Forms.Label()
        Me.gpbDatosPresupuesto = New System.Windows.Forms.GroupBox()
        Me.mskPrecio = New System.Windows.Forms.MaskedTextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.mskCantidad = New System.Windows.Forms.MaskedTextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.gpbTotales = New System.Windows.Forms.GroupBox()
        Me.lblPrecioTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCopiar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.dgvPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDatosPresupuesto.SuspendLayout()
        Me.gpbTotales.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPresupuesto
        '
        Me.dgvPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPresupuesto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Subtotal})
        Me.dgvPresupuesto.Location = New System.Drawing.Point(252, 30)
        Me.dgvPresupuesto.Name = "dgvPresupuesto"
        Me.dgvPresupuesto.Size = New System.Drawing.Size(442, 201)
        Me.dgvPresupuesto.TabIndex = 7
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
        'lblListaProductos
        '
        Me.lblListaProductos.AutoSize = True
        Me.lblListaProductos.Location = New System.Drawing.Point(249, 12)
        Me.lblListaProductos.Name = "lblListaProductos"
        Me.lblListaProductos.Size = New System.Drawing.Size(79, 13)
        Me.lblListaProductos.TabIndex = 6
        Me.lblListaProductos.Text = "Lista productos"
        '
        'gpbDatosPresupuesto
        '
        Me.gpbDatosPresupuesto.Controls.Add(Me.mskPrecio)
        Me.gpbDatosPresupuesto.Controls.Add(Me.lblPrecio)
        Me.gpbDatosPresupuesto.Controls.Add(Me.btnCancelar)
        Me.gpbDatosPresupuesto.Controls.Add(Me.mskCantidad)
        Me.gpbDatosPresupuesto.Controls.Add(Me.btnAgregar)
        Me.gpbDatosPresupuesto.Controls.Add(Me.lblCantidad)
        Me.gpbDatosPresupuesto.Controls.Add(Me.cmbProductos)
        Me.gpbDatosPresupuesto.Controls.Add(Me.lblProducto)
        Me.gpbDatosPresupuesto.Location = New System.Drawing.Point(12, 12)
        Me.gpbDatosPresupuesto.Name = "gpbDatosPresupuesto"
        Me.gpbDatosPresupuesto.Size = New System.Drawing.Size(231, 158)
        Me.gpbDatosPresupuesto.TabIndex = 0
        Me.gpbDatosPresupuesto.TabStop = False
        Me.gpbDatosPresupuesto.Text = "Productos"
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
        'gpbTotales
        '
        Me.gpbTotales.Controls.Add(Me.lblPrecioTotal)
        Me.gpbTotales.Controls.Add(Me.lblTotal)
        Me.gpbTotales.Location = New System.Drawing.Point(12, 176)
        Me.gpbTotales.Name = "gpbTotales"
        Me.gpbTotales.Size = New System.Drawing.Size(231, 55)
        Me.gpbTotales.TabIndex = 8
        Me.gpbTotales.TabStop = False
        Me.gpbTotales.Text = "Totales"
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
        'btnCopiar
        '
        Me.btnCopiar.Location = New System.Drawing.Point(578, 237)
        Me.btnCopiar.Name = "btnCopiar"
        Me.btnCopiar.Size = New System.Drawing.Size(111, 30)
        Me.btnCopiar.TabIndex = 1
        Me.btnCopiar.Text = "Copiar"
        Me.btnCopiar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 241)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'frmPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 278)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCopiar)
        Me.Controls.Add(Me.gpbTotales)
        Me.Controls.Add(Me.dgvPresupuesto)
        Me.Controls.Add(Me.lblListaProductos)
        Me.Controls.Add(Me.gpbDatosPresupuesto)
        Me.Name = "frmPresupuesto"
        Me.Text = "Presupuestos"
        CType(Me.dgvPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDatosPresupuesto.ResumeLayout(False)
        Me.gpbDatosPresupuesto.PerformLayout()
        Me.gpbTotales.ResumeLayout(False)
        Me.gpbTotales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPresupuesto As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents lblListaProductos As Label
    Friend WithEvents gpbDatosPresupuesto As GroupBox
    Friend WithEvents mskPrecio As MaskedTextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents mskCantidad As MaskedTextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblCantidad As Label
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents gpbTotales As GroupBox
    Friend WithEvents lblPrecioTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCopiar As Button
    Friend WithEvents btnLimpiar As Button
End Class
