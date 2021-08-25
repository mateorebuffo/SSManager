<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.gpbPresupuestos = New System.Windows.Forms.GroupBox()
        Me.lblNuevoPresupuesto = New System.Windows.Forms.Label()
        Me.pbNuevoPresupuesto = New System.Windows.Forms.PictureBox()
        Me.lblConsultaPresupuesto = New System.Windows.Forms.Label()
        Me.pbConsultaPrespuesto = New System.Windows.Forms.PictureBox()
        Me.gpbVentas = New System.Windows.Forms.GroupBox()
        Me.lblNuevaVenta = New System.Windows.Forms.Label()
        Me.pbNuevaVenta = New System.Windows.Forms.PictureBox()
        Me.lblConsultaVentas = New System.Windows.Forms.Label()
        Me.pbConsultaVentas = New System.Windows.Forms.PictureBox()
        Me.gpbStock = New System.Windows.Forms.GroupBox()
        Me.lblConsultarStock = New System.Windows.Forms.Label()
        Me.pbConsultaStock = New System.Windows.Forms.PictureBox()
        Me.gpbProducto = New System.Windows.Forms.GroupBox()
        Me.lblCargaStock = New System.Windows.Forms.Label()
        Me.pbCargarStock = New System.Windows.Forms.PictureBox()
        Me.lblNuevoProducto = New System.Windows.Forms.Label()
        Me.pbNuevoProducto = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor.SuspendLayout()
        Me.gpbPresupuestos.SuspendLayout()
        CType(Me.pbNuevoPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbConsultaPrespuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbVentas.SuspendLayout()
        CType(Me.pbNuevaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbConsultaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbStock.SuspendLayout()
        CType(Me.pbConsultaStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbProducto.SuspendLayout()
        CType(Me.pbCargarStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNuevoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.gpbPresupuestos)
        Me.PanelContenedor.Controls.Add(Me.gpbVentas)
        Me.PanelContenedor.Controls.Add(Me.gpbStock)
        Me.PanelContenedor.Controls.Add(Me.gpbProducto)
        Me.PanelContenedor.Location = New System.Drawing.Point(3, 4)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(596, 100)
        Me.PanelContenedor.TabIndex = 0
        '
        'gpbPresupuestos
        '
        Me.gpbPresupuestos.Controls.Add(Me.lblNuevoPresupuesto)
        Me.gpbPresupuestos.Controls.Add(Me.pbNuevoPresupuesto)
        Me.gpbPresupuestos.Controls.Add(Me.lblConsultaPresupuesto)
        Me.gpbPresupuestos.Controls.Add(Me.pbConsultaPrespuesto)
        Me.gpbPresupuestos.Location = New System.Drawing.Point(261, 8)
        Me.gpbPresupuestos.Name = "gpbPresupuestos"
        Me.gpbPresupuestos.Size = New System.Drawing.Size(174, 88)
        Me.gpbPresupuestos.TabIndex = 5
        Me.gpbPresupuestos.TabStop = False
        Me.gpbPresupuestos.Text = "Presupuestos"
        '
        'lblNuevoPresupuesto
        '
        Me.lblNuevoPresupuesto.AutoSize = True
        Me.lblNuevoPresupuesto.Location = New System.Drawing.Point(93, 61)
        Me.lblNuevoPresupuesto.Name = "lblNuevoPresupuesto"
        Me.lblNuevoPresupuesto.Size = New System.Drawing.Size(75, 13)
        Me.lblNuevoPresupuesto.TabIndex = 3
        Me.lblNuevoPresupuesto.Text = "Nuevo Presup"
        '
        'pbNuevoPresupuesto
        '
        Me.pbNuevoPresupuesto.Image = Global.pryControlStock.My.Resources.Resources.medico
        Me.pbNuevoPresupuesto.Location = New System.Drawing.Point(99, 19)
        Me.pbNuevoPresupuesto.Name = "pbNuevoPresupuesto"
        Me.pbNuevoPresupuesto.Size = New System.Drawing.Size(62, 39)
        Me.pbNuevoPresupuesto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbNuevoPresupuesto.TabIndex = 2
        Me.pbNuevoPresupuesto.TabStop = False
        '
        'lblConsultaPresupuesto
        '
        Me.lblConsultaPresupuesto.AutoSize = True
        Me.lblConsultaPresupuesto.Location = New System.Drawing.Point(3, 61)
        Me.lblConsultaPresupuesto.Name = "lblConsultaPresupuesto"
        Me.lblConsultaPresupuesto.Size = New System.Drawing.Size(84, 13)
        Me.lblConsultaPresupuesto.TabIndex = 1
        Me.lblConsultaPresupuesto.Text = "Consulta Presup"
        '
        'pbConsultaPrespuesto
        '
        Me.pbConsultaPrespuesto.Image = Global.pryControlStock.My.Resources.Resources.ventas
        Me.pbConsultaPrespuesto.Location = New System.Drawing.Point(14, 19)
        Me.pbConsultaPrespuesto.Name = "pbConsultaPrespuesto"
        Me.pbConsultaPrespuesto.Size = New System.Drawing.Size(62, 39)
        Me.pbConsultaPrespuesto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbConsultaPrespuesto.TabIndex = 0
        Me.pbConsultaPrespuesto.TabStop = False
        '
        'gpbVentas
        '
        Me.gpbVentas.Controls.Add(Me.lblNuevaVenta)
        Me.gpbVentas.Controls.Add(Me.pbNuevaVenta)
        Me.gpbVentas.Controls.Add(Me.lblConsultaVentas)
        Me.gpbVentas.Controls.Add(Me.pbConsultaVentas)
        Me.gpbVentas.Location = New System.Drawing.Point(441, 9)
        Me.gpbVentas.Name = "gpbVentas"
        Me.gpbVentas.Size = New System.Drawing.Size(152, 88)
        Me.gpbVentas.TabIndex = 4
        Me.gpbVentas.TabStop = False
        Me.gpbVentas.Text = "Ventas"
        '
        'lblNuevaVenta
        '
        Me.lblNuevaVenta.AutoSize = True
        Me.lblNuevaVenta.Location = New System.Drawing.Point(81, 61)
        Me.lblNuevaVenta.Name = "lblNuevaVenta"
        Me.lblNuevaVenta.Size = New System.Drawing.Size(70, 13)
        Me.lblNuevaVenta.TabIndex = 3
        Me.lblNuevaVenta.Text = "Nueva Venta"
        '
        'pbNuevaVenta
        '
        Me.pbNuevaVenta.Image = Global.pryControlStock.My.Resources.Resources.medico
        Me.pbNuevaVenta.Location = New System.Drawing.Point(84, 19)
        Me.pbNuevaVenta.Name = "pbNuevaVenta"
        Me.pbNuevaVenta.Size = New System.Drawing.Size(62, 39)
        Me.pbNuevaVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbNuevaVenta.TabIndex = 2
        Me.pbNuevaVenta.TabStop = False
        '
        'lblConsultaVentas
        '
        Me.lblConsultaVentas.AutoSize = True
        Me.lblConsultaVentas.Location = New System.Drawing.Point(16, 61)
        Me.lblConsultaVentas.Name = "lblConsultaVentas"
        Me.lblConsultaVentas.Size = New System.Drawing.Size(48, 13)
        Me.lblConsultaVentas.TabIndex = 1
        Me.lblConsultaVentas.Text = "Consulta"
        '
        'pbConsultaVentas
        '
        Me.pbConsultaVentas.Image = Global.pryControlStock.My.Resources.Resources.ventas
        Me.pbConsultaVentas.Location = New System.Drawing.Point(6, 19)
        Me.pbConsultaVentas.Name = "pbConsultaVentas"
        Me.pbConsultaVentas.Size = New System.Drawing.Size(62, 39)
        Me.pbConsultaVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbConsultaVentas.TabIndex = 0
        Me.pbConsultaVentas.TabStop = False
        '
        'gpbStock
        '
        Me.gpbStock.Controls.Add(Me.lblConsultarStock)
        Me.gpbStock.Controls.Add(Me.pbConsultaStock)
        Me.gpbStock.Location = New System.Drawing.Point(168, 8)
        Me.gpbStock.Name = "gpbStock"
        Me.gpbStock.Size = New System.Drawing.Size(87, 88)
        Me.gpbStock.TabIndex = 4
        Me.gpbStock.TabStop = False
        Me.gpbStock.Text = "Stock"
        '
        'lblConsultarStock
        '
        Me.lblConsultarStock.AutoSize = True
        Me.lblConsultarStock.Location = New System.Drawing.Point(6, 62)
        Me.lblConsultarStock.Name = "lblConsultarStock"
        Me.lblConsultarStock.Size = New System.Drawing.Size(79, 13)
        Me.lblConsultarStock.TabIndex = 1
        Me.lblConsultarStock.Text = "Consulta Stock"
        '
        'pbConsultaStock
        '
        Me.pbConsultaStock.Image = Global.pryControlStock.My.Resources.Resources.en_stock
        Me.pbConsultaStock.Location = New System.Drawing.Point(14, 20)
        Me.pbConsultaStock.Name = "pbConsultaStock"
        Me.pbConsultaStock.Size = New System.Drawing.Size(62, 39)
        Me.pbConsultaStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbConsultaStock.TabIndex = 0
        Me.pbConsultaStock.TabStop = False
        '
        'gpbProducto
        '
        Me.gpbProducto.Controls.Add(Me.lblCargaStock)
        Me.gpbProducto.Controls.Add(Me.pbCargarStock)
        Me.gpbProducto.Controls.Add(Me.lblNuevoProducto)
        Me.gpbProducto.Controls.Add(Me.pbNuevoProducto)
        Me.gpbProducto.Location = New System.Drawing.Point(10, 9)
        Me.gpbProducto.Name = "gpbProducto"
        Me.gpbProducto.Size = New System.Drawing.Size(152, 88)
        Me.gpbProducto.TabIndex = 0
        Me.gpbProducto.TabStop = False
        Me.gpbProducto.Text = "Producto"
        '
        'lblCargaStock
        '
        Me.lblCargaStock.AutoSize = True
        Me.lblCargaStock.Location = New System.Drawing.Point(81, 61)
        Me.lblCargaStock.Name = "lblCargaStock"
        Me.lblCargaStock.Size = New System.Drawing.Size(69, 13)
        Me.lblCargaStock.TabIndex = 3
        Me.lblCargaStock.Text = "Cargar Stock"
        '
        'pbCargarStock
        '
        Me.pbCargarStock.Image = Global.pryControlStock.My.Resources.Resources.valores
        Me.pbCargarStock.Location = New System.Drawing.Point(84, 19)
        Me.pbCargarStock.Name = "pbCargarStock"
        Me.pbCargarStock.Size = New System.Drawing.Size(62, 39)
        Me.pbCargarStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCargarStock.TabIndex = 2
        Me.pbCargarStock.TabStop = False
        '
        'lblNuevoProducto
        '
        Me.lblNuevoProducto.AutoSize = True
        Me.lblNuevoProducto.Location = New System.Drawing.Point(16, 61)
        Me.lblNuevoProducto.Name = "lblNuevoProducto"
        Me.lblNuevoProducto.Size = New System.Drawing.Size(39, 13)
        Me.lblNuevoProducto.TabIndex = 1
        Me.lblNuevoProducto.Text = "Nuevo"
        '
        'pbNuevoProducto
        '
        Me.pbNuevoProducto.Image = Global.pryControlStock.My.Resources.Resources.caja
        Me.pbNuevoProducto.Location = New System.Drawing.Point(6, 19)
        Me.pbNuevoProducto.Name = "pbNuevoProducto"
        Me.pbNuevoProducto.Size = New System.Drawing.Size(62, 39)
        Me.pbNuevoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbNuevoProducto.TabIndex = 0
        Me.pbNuevoProducto.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 394)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Name = "frmMain"
        Me.Text = "Inicio"
        Me.PanelContenedor.ResumeLayout(False)
        Me.gpbPresupuestos.ResumeLayout(False)
        Me.gpbPresupuestos.PerformLayout()
        CType(Me.pbNuevoPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbConsultaPrespuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbVentas.ResumeLayout(False)
        Me.gpbVentas.PerformLayout()
        CType(Me.pbNuevaVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbConsultaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbStock.ResumeLayout(False)
        Me.gpbStock.PerformLayout()
        CType(Me.pbConsultaStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbProducto.ResumeLayout(False)
        Me.gpbProducto.PerformLayout()
        CType(Me.pbCargarStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNuevoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents gpbProducto As GroupBox
    Friend WithEvents lblNuevoProducto As Label
    Friend WithEvents pbNuevoProducto As PictureBox
    Friend WithEvents gpbStock As GroupBox
    Friend WithEvents lblConsultarStock As Label
    Friend WithEvents pbConsultaStock As PictureBox
    Friend WithEvents lblCargaStock As Label
    Friend WithEvents pbCargarStock As PictureBox
    Friend WithEvents gpbVentas As GroupBox
    Friend WithEvents lblNuevaVenta As Label
    Friend WithEvents pbNuevaVenta As PictureBox
    Friend WithEvents lblConsultaVentas As Label
    Friend WithEvents pbConsultaVentas As PictureBox
    Friend WithEvents gpbPresupuestos As GroupBox
    Friend WithEvents lblNuevoPresupuesto As Label
    Friend WithEvents pbNuevoPresupuesto As PictureBox
    Friend WithEvents lblConsultaPresupuesto As Label
    Friend WithEvents pbConsultaPrespuesto As PictureBox
End Class
