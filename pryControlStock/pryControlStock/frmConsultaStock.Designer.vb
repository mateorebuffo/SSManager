<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaStock
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
        Me.gpbDatosProducto = New System.Windows.Forms.GroupBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cmbTipoProducto = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dgvListaStock = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblLista = New System.Windows.Forms.Label()
        Me.gpbDatosProducto.SuspendLayout()
        CType(Me.dgvListaStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbDatosProducto
        '
        Me.gpbDatosProducto.Controls.Add(Me.lblTipo)
        Me.gpbDatosProducto.Controls.Add(Me.cmbTipoProducto)
        Me.gpbDatosProducto.Controls.Add(Me.lblProducto)
        Me.gpbDatosProducto.Controls.Add(Me.cmbProductos)
        Me.gpbDatosProducto.Location = New System.Drawing.Point(12, 12)
        Me.gpbDatosProducto.Name = "gpbDatosProducto"
        Me.gpbDatosProducto.Size = New System.Drawing.Size(481, 65)
        Me.gpbDatosProducto.TabIndex = 0
        Me.gpbDatosProducto.TabStop = False
        Me.gpbDatosProducto.Text = "Datos Producto"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(320, 28)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 3
        Me.lblTipo.Text = "Tipo"
        '
        'cmbTipoProducto
        '
        Me.cmbTipoProducto.FormattingEnabled = True
        Me.cmbTipoProducto.Items.AddRange(New Object() {"Mineria", "Central ip", "Telefono ip", "Gateway", "Router", "Amplificador", "Robot", "Otro"})
        Me.cmbTipoProducto.Location = New System.Drawing.Point(354, 25)
        Me.cmbTipoProducto.Name = "cmbTipoProducto"
        Me.cmbTipoProducto.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoProducto.TabIndex = 3
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(8, 29)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 1
        Me.lblProducto.Text = "Producto"
        '
        'cmbProductos
        '
        Me.cmbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(78, 25)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(154, 21)
        Me.cmbProductos.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Location = New System.Drawing.Point(412, 83)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 83)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'dgvListaStock
        '
        Me.dgvListaStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Categoria, Me.Cantidad})
        Me.dgvListaStock.Location = New System.Drawing.Point(12, 130)
        Me.dgvListaStock.Name = "dgvListaStock"
        Me.dgvListaStock.Size = New System.Drawing.Size(481, 150)
        Me.dgvListaStock.TabIndex = 3
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 70
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 170
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'lblLista
        '
        Me.lblLista.AutoSize = True
        Me.lblLista.Location = New System.Drawing.Point(9, 114)
        Me.lblLista.Name = "lblLista"
        Me.lblLista.Size = New System.Drawing.Size(94, 13)
        Me.lblLista.TabIndex = 4
        Me.lblLista.Text = "Lista de productos"
        '
        'frmConsultaStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 291)
        Me.Controls.Add(Me.lblLista)
        Me.Controls.Add(Me.dgvListaStock)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.gpbDatosProducto)
        Me.Name = "frmConsultaStock"
        Me.Text = "Consula stock"
        Me.gpbDatosProducto.ResumeLayout(False)
        Me.gpbDatosProducto.PerformLayout()
        CType(Me.dgvListaStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpbDatosProducto As GroupBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents cmbTipoProducto As ComboBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents dgvListaStock As DataGridView
    Friend WithEvents lblLista As Label
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
End Class
