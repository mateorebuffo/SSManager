Imports System.Data.OleDb
Module ModuloBD
    Public objConexionBaseDatos As New OleDbConnection
    Public objComandoBaseDatos As New OleDbCommand
    Public objLectorBaseDatos As OleDbDataReader


    Sub ConectarBaseDeDatos()
        Try
            objConexionBaseDatos.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mateo\Desktop\Desarrollo\pryControlStock\pryControlStock\bin\Debug\Voip.accdb"
            objConexionBaseDatos.Open()
        Catch ex As Exception
            MessageBox.Show("Ocurrio un problema: " & ex.Message & " No se pudo abrir la base de datos")
        End Try
    End Sub

    Sub CerrarBaseDeDatos()
        objConexionBaseDatos.Close()
    End Sub
#Region "Insertar Datos -> (INSERT)"


    Sub InsertarDatos(nombreTabla As String, dato1 As String, dato2 As String, dato3 As String, dato4 As String)
        'La uso para cargar el producto con todas sus caracteristicas
        objComandoBaseDatos.Connection = objConexionBaseDatos
        objComandoBaseDatos.CommandType = CommandType.Text
        objComandoBaseDatos.CommandText = "INSERT INTO " & nombreTabla & " VALUES ('" & dato1 & "','" & dato2 & "','" & dato3 & "','" & dato4 & "')"

        Try
            objComandoBaseDatos.ExecuteNonQuery()
            MessageBox.Show("Producto cargado con exito!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Sub InsertarDatos(nombreTabla As String, dato1 As String, dato2 As String, dato3 As String, dato4 As Long)
        'La uso para cargar AUTOMATICAMENTE en la tabla STOCK el producto apenas lo creo'
        objComandoBaseDatos.Connection = objConexionBaseDatos
        objComandoBaseDatos.CommandType = CommandType.Text
        objComandoBaseDatos.CommandText = "INSERT INTO " & nombreTabla & " VALUES ('" & dato1 & "','" & dato2 & "','" & dato3 & "','" & dato4 & "')"

        Try
            objComandoBaseDatos.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub InsertarDatos(nombreTabla As String, dato1 As Long, dato2 As Date, dato3 As String, dato4 As Long, dato5 As Long, dato6 As Long, dato7 As String)
        'La uso para cargar una nueva venta'
        objComandoBaseDatos.Connection = objConexionBaseDatos
        objComandoBaseDatos.CommandType = CommandType.Text
        objComandoBaseDatos.CommandText = "INSERT INTO " & nombreTabla & " VALUES ('" & dato1 & "','" & dato2 & "','" & dato3 & "','" & dato4 & "','" & dato5 & "','" & dato6 & "','" & dato7 & "')"

        Try
            objComandoBaseDatos.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub InsertarDatos(nombreTabla As String, dato1 As Long, dato2 As Date, dato3 As Long, dato4 As String, dato5 As String, dato6 As String, dato7 As String, dato8 As Long)
        'La uso para cargar un nuevo registro de venta'
        objComandoBaseDatos.Connection = objConexionBaseDatos
        objComandoBaseDatos.CommandType = CommandType.Text
        objComandoBaseDatos.CommandText = "INSERT INTO " & nombreTabla & " VALUES ('" & dato1 & "','" & dato2 & "','" & dato3 & "','" & dato4 & "','" & dato5 & "','" & dato6 & "','" & dato7 & "','" & dato8 & "')"

        Try
            objComandoBaseDatos.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "Cambio de cantidades -> (UPDATE)"
    Sub CambiarCantidadStock(nombre As String, dato1 As Long)
        'Actualiza la cantidad de un producto en stock'
        objComandoBaseDatos.Connection = objConexionBaseDatos
        objComandoBaseDatos.CommandType = CommandType.Text
        'Le concatene el chr 34 que son las comillas dobles porque asi lo pide la consulta update sql"
        objComandoBaseDatos.CommandText = "UPDATE Stock SET Stock.Cantidad = " & dato1 & " WHERE Stock.Nombre = " & Chr(34) & nombre & Chr(34)
        Try
            objComandoBaseDatos.ExecuteNonQuery()
            MessageBox.Show("Stock cargado con exito!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub CambiarCantidadStockPorVenta(nombre As String, dato1 As Long)
        'Actualiza la cantidad de un producto en stock restodolo por venta'
        objComandoBaseDatos.Connection = objConexionBaseDatos
        objComandoBaseDatos.CommandType = CommandType.Text
        'Le concatene el chr 34 que son las comillas dobles porque asi lo pide la consulta update sql"
        objComandoBaseDatos.CommandText = "UPDATE Stock SET Stock.Cantidad = Stock.Cantidad - " & dato1 & " WHERE Stock.Nombre = " & Chr(34) & nombre & Chr(34)
        Try
            objComandoBaseDatos.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Busqueda de productos / Lectura de ultima factura / Carga combo box ->  (SELECT)"
    Sub BuscarStockProductoPorNombre(Dato As String, Lista As DataGridView)
        objComandoBaseDatos.Connection = objConexionBaseDatos
        objComandoBaseDatos.CommandType = CommandType.Text
        objComandoBaseDatos.CommandText = "SELECT * FROM Stock WHERE Nombre ='" & Dato & "'"


        objLectorBaseDatos = objComandoBaseDatos.ExecuteReader

        If objLectorBaseDatos.HasRows Then
            While objLectorBaseDatos.Read
                Lista.Rows.Add(objLectorBaseDatos(1), objLectorBaseDatos(2), objLectorBaseDatos(3), objLectorBaseDatos(4))
            End While
        End If
        objLectorBaseDatos.Close()
    End Sub

    Sub BuscarStockProductoPorTipo(Dato As String, Lista As DataGridView)
        objComandoBaseDatos.Connection = objConexionBaseDatos
        objComandoBaseDatos.CommandType = CommandType.Text
        objComandoBaseDatos.CommandText = "SELECT * FROM Stock WHERE Categoria ='" & Dato & "'"


        objLectorBaseDatos = objComandoBaseDatos.ExecuteReader

        If objLectorBaseDatos.HasRows Then
            While objLectorBaseDatos.Read
                Lista.Rows.Add(objLectorBaseDatos(1), objLectorBaseDatos(2), objLectorBaseDatos(3), objLectorBaseDatos(4))
            End While
        End If
        objLectorBaseDatos.Close()
    End Sub

    Function LeerDatosUltimaFactura(nombreTabla As String)

        Dim ultFactura As Long

        objComandoBaseDatos.Connection = objConexionBaseDatos
        objComandoBaseDatos.CommandType = CommandType.Text
        objComandoBaseDatos.CommandText = "SELECT * FROM " & nombreTabla & " WHERE id=(SELECT max(id) FROM " & nombreTabla & ");"



        objLectorBaseDatos = objComandoBaseDatos.ExecuteReader

        If objLectorBaseDatos.HasRows Then
            While objLectorBaseDatos.Read
                ultFactura = CInt(objLectorBaseDatos(1))
            End While
        End If
        objLectorBaseDatos.Close()

        Return ultFactura
    End Function

    Sub CargarComboBox(nombreTabla As String, nombreCampo As String, cmb As ComboBox)

        objComandoBaseDatos.Connection = objConexionBaseDatos
        objComandoBaseDatos.CommandType = CommandType.Text
        objComandoBaseDatos.CommandText = "SELECT DISTINCT " & nombreCampo & " FROM " & nombreTabla

        objLectorBaseDatos = objComandoBaseDatos.ExecuteReader

        If objLectorBaseDatos.HasRows Then
            While objLectorBaseDatos.Read
                cmb.Items.Add(objLectorBaseDatos(0))
            End While
        End If
        objLectorBaseDatos.Close()

    End Sub

    Sub BuscarTodasLasVentas(Lista As DataGridView)
        objComandoBaseDatos.Connection = objConexionBaseDatos
        objComandoBaseDatos.CommandType = CommandType.Text
        objComandoBaseDatos.CommandText = "SELECT * FROM Ventas"


        objLectorBaseDatos = objComandoBaseDatos.ExecuteReader

        If objLectorBaseDatos.HasRows Then
            While objLectorBaseDatos.Read
                Lista.Rows.Add(objLectorBaseDatos(1), objLectorBaseDatos(2), objLectorBaseDatos(3), objLectorBaseDatos(4), objLectorBaseDatos(5), objLectorBaseDatos(6), objLectorBaseDatos(7))
            End While
        End If
        objLectorBaseDatos.Close()
    End Sub

    Sub BuscarVentasPorFecha(Lista As DataGridView, dato1 As Date, dato2 As Date)
        'Hay que sumarle un dia a la fecha hasta por ahora'
        objComandoBaseDatos.Connection = objConexionBaseDatos
        objComandoBaseDatos.CommandType = CommandType.Text
        objComandoBaseDatos.CommandText = "SELECT * FROM Ventas Where Ventas.Fecha Between #" & dato1 & "# And #" & dato2 & "#"


        objLectorBaseDatos = objComandoBaseDatos.ExecuteReader

        If objLectorBaseDatos.HasRows Then
            While objLectorBaseDatos.Read
                Lista.Rows.Add(objLectorBaseDatos(1), objLectorBaseDatos(2), objLectorBaseDatos(3), objLectorBaseDatos(4), objLectorBaseDatos(5), objLectorBaseDatos(6), objLectorBaseDatos(7))
            End While
        End If
        objLectorBaseDatos.Close()
    End Sub

    Sub BuscarVentasPorVendedor(Lista As DataGridView, dato1 As String)

        objComandoBaseDatos.Connection = objConexionBaseDatos
        objComandoBaseDatos.CommandType = CommandType.Text
        objComandoBaseDatos.CommandText = "SELECT * FROM Ventas Where Vendedor = '" & dato1 & "'"


        objLectorBaseDatos = objComandoBaseDatos.ExecuteReader

        If objLectorBaseDatos.HasRows Then
            While objLectorBaseDatos.Read
                Lista.Rows.Add(objLectorBaseDatos(1), objLectorBaseDatos(2), objLectorBaseDatos(3), objLectorBaseDatos(4), objLectorBaseDatos(5), objLectorBaseDatos(6), objLectorBaseDatos(7))
            End While
        End If
        objLectorBaseDatos.Close()
    End Sub
#End Region

End Module
