<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaProducto
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
        Me.mskCantidad = New System.Windows.Forms.MaskedTextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gpbDatosProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbDatosProducto
        '
        Me.gpbDatosProducto.Controls.Add(Me.mskCantidad)
        Me.gpbDatosProducto.Controls.Add(Me.lblCantidad)
        Me.gpbDatosProducto.Controls.Add(Me.cmbProductos)
        Me.gpbDatosProducto.Controls.Add(Me.lblProducto)
        Me.gpbDatosProducto.Location = New System.Drawing.Point(12, 12)
        Me.gpbDatosProducto.Name = "gpbDatosProducto"
        Me.gpbDatosProducto.Size = New System.Drawing.Size(274, 99)
        Me.gpbDatosProducto.TabIndex = 0
        Me.gpbDatosProducto.TabStop = False
        Me.gpbDatosProducto.Text = "Datos de producto"
        '
        'mskCantidad
        '
        Me.mskCantidad.Enabled = False
        Me.mskCantidad.Location = New System.Drawing.Point(90, 66)
        Me.mskCantidad.Mask = "99999999999"
        Me.mskCantidad.Name = "mskCantidad"
        Me.mskCantidad.Size = New System.Drawing.Size(75, 20)
        Me.mskCantidad.TabIndex = 2
        Me.mskCantidad.ValidatingType = GetType(Integer)
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(7, 70)
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
        Me.cmbProductos.Location = New System.Drawing.Point(90, 28)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(173, 21)
        Me.cmbProductos.TabIndex = 1
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(7, 32)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Producto"
        '
        'btnCargar
        '
        Me.btnCargar.Enabled = False
        Me.btnCargar.Location = New System.Drawing.Point(211, 117)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 1
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(12, 117)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmCargaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 146)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.gpbDatosProducto)
        Me.Name = "frmCargaProducto"
        Me.Text = "Carga de stock"
        Me.gpbDatosProducto.ResumeLayout(False)
        Me.gpbDatosProducto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbDatosProducto As GroupBox
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents mskCantidad As MaskedTextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnCancelar As Button
End Class
