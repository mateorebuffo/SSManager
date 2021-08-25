<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaProducto
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
        Me.gpbAltaProducto = New System.Windows.Forms.GroupBox()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcionProducto = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gpbAltaProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbAltaProducto
        '
        Me.gpbAltaProducto.Controls.Add(Me.cmbCategoria)
        Me.gpbAltaProducto.Controls.Add(Me.lblCategoria)
        Me.gpbAltaProducto.Controls.Add(Me.txtDescripcion)
        Me.gpbAltaProducto.Controls.Add(Me.lblDescripcionProducto)
        Me.gpbAltaProducto.Controls.Add(Me.txtNombreProducto)
        Me.gpbAltaProducto.Controls.Add(Me.lblNombreProducto)
        Me.gpbAltaProducto.Controls.Add(Me.txtCodigo)
        Me.gpbAltaProducto.Controls.Add(Me.lblCodigo)
        Me.gpbAltaProducto.Location = New System.Drawing.Point(12, 12)
        Me.gpbAltaProducto.Name = "gpbAltaProducto"
        Me.gpbAltaProducto.Size = New System.Drawing.Size(200, 199)
        Me.gpbAltaProducto.TabIndex = 0
        Me.gpbAltaProducto.TabStop = False
        Me.gpbAltaProducto.Text = "Datos de producto"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCategoria.Enabled = False
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Items.AddRange(New Object() {"Mineria", "Central ip", "Telefono ip", "Gateway", "Router", "Amplificador", "Robot", "Otro"})
        Me.cmbCategoria.Location = New System.Drawing.Point(92, 83)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(102, 21)
        Me.cmbCategoria.TabIndex = 3
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(13, 87)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(52, 13)
        Me.lblCategoria.TabIndex = 6
        Me.lblCategoria.Text = "Categoria"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(15, 132)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(178, 58)
        Me.txtDescripcion.TabIndex = 5
        '
        'lblDescripcionProducto
        '
        Me.lblDescripcionProducto.AutoSize = True
        Me.lblDescripcionProducto.Location = New System.Drawing.Point(12, 116)
        Me.lblDescripcionProducto.Name = "lblDescripcionProducto"
        Me.lblDescripcionProducto.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcionProducto.TabIndex = 4
        Me.lblDescripcionProducto.Text = "Descripcion"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Enabled = False
        Me.txtNombreProducto.Location = New System.Drawing.Point(92, 54)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(102, 20)
        Me.txtNombreProducto.TabIndex = 2
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Location = New System.Drawing.Point(13, 58)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(44, 13)
        Me.lblNombreProducto.TabIndex = 2
        Me.lblNombreProducto.Text = "Nombre"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(92, 24)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(102, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(13, 28)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Codigo"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Enabled = False
        Me.btnRegistrar.Location = New System.Drawing.Point(137, 217)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 1
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(13, 217)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmAltaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 253)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.gpbAltaProducto)
        Me.Name = "frmAltaProducto"
        Me.Text = "Alta producto"
        Me.gpbAltaProducto.ResumeLayout(False)
        Me.gpbAltaProducto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbAltaProducto As GroupBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcionProducto As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents lblCategoria As Label
End Class
