Imports MySql.Data.MySqlClient


Public Class registraproducto
    ' Cadena de conexión a la base de datos
    Private connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"

    ' Cargar los nombres de los proveedores en el ComboBox al cargar el formulario
    Private Sub registraproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProveedores()
        CargarProductos()
    End Sub

    ' Método para cargar los proveedores en el ComboBox
    Private Sub CargarProveedores()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT id_proveedor, nombre FROM proveedores"
                Dim command As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ComboBoxproveedores.Items.Clear()
                While reader.Read()
                    ComboBoxproveedores.Items.Add(New With {
                        .Id = reader("id_proveedor"),
                        .Nombre = reader("nombre").ToString()
                    })
                End While
                ComboBoxproveedores.DisplayMember = "Nombre"
                ComboBoxproveedores.ValueMember = "Id"
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error al cargar proveedores: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub CargarProductos()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT p.codigo, p.nombre, p.descripcion, p.marca, p.modelo, p.precio_compra, p.precio_venta, p.stock, pr.nombre AS proveedor 
                                   FROM productos p 
                                   INNER JOIN proveedores pr ON p.id_proveedor = pr.id_proveedor"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                tabladeproductos.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error al cargar productos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    ' Botón para agregar un nuevo producto
    Private Sub agregarbtn_Click(sender As Object, e As EventArgs) Handles agregarbtn.Click
        ' Validaciones
        If String.IsNullOrEmpty(txtcodigo.Text.Trim()) OrElse
           String.IsNullOrEmpty(txtproducto.Text.Trim()) OrElse
           String.IsNullOrEmpty(txtmarca.Text.Trim()) OrElse
           String.IsNullOrEmpty(txtmodelo.Text.Trim()) OrElse
           String.IsNullOrEmpty(txtstock.Text.Trim()) OrElse
           String.IsNullOrEmpty(txtpreciocompra.Text.Trim()) OrElse
           String.IsNullOrEmpty(txtprecioventa.Text.Trim()) OrElse
           ComboBoxproveedores.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Integer.TryParse(txtstock.Text.Trim(), Nothing) Then
            MessageBox.Show("El stock debe ser un número entero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Decimal.TryParse(txtpreciocompra.Text.Trim(), Nothing) OrElse Not Decimal.TryParse(txtprecioventa.Text.Trim(), Nothing) Then
            MessageBox.Show("Los precios deben ser valores numéricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insertar producto
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO productos (codigo, nombre, descripcion, marca, modelo, precio_compra, precio_venta, stock, id_proveedor) 
                                       VALUES (@codigo, @nombre, @descripcion, @marca, @modelo, @precio_compra, @precio_venta, @stock, @id_proveedor)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@codigo", txtcodigo.Text.Trim())
                command.Parameters.AddWithValue("@nombre", txtproducto.Text.Trim())
                command.Parameters.AddWithValue("@descripcion", txtdescripcion.Text.Trim())
                command.Parameters.AddWithValue("@marca", txtmarca.Text.Trim())
                command.Parameters.AddWithValue("@modelo", txtmodelo.Text.Trim())
                command.Parameters.AddWithValue("@precio_compra", Convert.ToDecimal(txtpreciocompra.Text.Trim()))
                command.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(txtprecioventa.Text.Trim()))
                command.Parameters.AddWithValue("@stock", Convert.ToInt32(txtstock.Text.Trim()))
                command.Parameters.AddWithValue("@id_proveedor", CType(ComboBoxproveedores.SelectedItem, Object).Id)

                command.ExecuteNonQuery()
                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarProductos()
            Catch ex As Exception
                MessageBox.Show("Error al agregar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Botón para eliminar un producto
    Private Sub eliminarbtn_Click(sender As Object, e As EventArgs) Handles eliminarbtn.Click
        If tabladeproductos.SelectedRows.Count > 0 Then
            Dim codigoProducto = tabladeproductos.SelectedRows(0).Cells("codigo").Value.ToString
            Using connection As New MySqlConnection(connectionString)
                Try
                    connection.Open()
                    Dim query = "DELETE FROM productos WHERE codigo = @codigo"
                    Dim command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@codigo", codigoProducto)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarProductos()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub ATRASBTN_Click(sender As Object, e As EventArgs) Handles ATRASBTN.Click
        ' Crear una instancia del formulario menu
        Dim formularioMenu As New menu()

        ' Mostrar el formulario menu
        formularioMenu.Show()

        ' Cerrar el formulario actual
        Me.Close()
    End Sub

    ' Botón para editar un producto
    Private Sub editarbtn_Click(sender As Object, e As EventArgs) Handles editarbtn.Click
        ' Verificar si hay una fila seleccionada
        If tabladeproductos.SelectedRows.Count > 0 Then
            ' Obtener el código del producto de la fila seleccionada
            Dim codigoProducto As String = tabladeproductos.SelectedRows(0).Cells("codigo").Value.ToString()

            ' Validaciones
            If String.IsNullOrEmpty(txtproducto.Text.Trim()) OrElse
           String.IsNullOrEmpty(txtdescripcion.Text.Trim()) OrElse
           String.IsNullOrEmpty(txtmarca.Text.Trim()) OrElse
           String.IsNullOrEmpty(txtmodelo.Text.Trim()) OrElse
           String.IsNullOrEmpty(txtpreciocompra.Text.Trim()) OrElse
           String.IsNullOrEmpty(txtprecioventa.Text.Trim()) OrElse
           String.IsNullOrEmpty(txtstock.Text.Trim()) OrElse
           ComboBoxproveedores.SelectedItem Is Nothing Then
                MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim precioCompra As Decimal
            Dim precioVenta As Decimal
            Dim stock As Integer

            ' Validar que los campos numéricos sean correctos
            If Not Decimal.TryParse(txtpreciocompra.Text.Trim(), precioCompra) Then
                MessageBox.Show("El precio de compra debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not Decimal.TryParse(txtprecioventa.Text.Trim(), precioVenta) Then
                MessageBox.Show("El precio de venta debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not Integer.TryParse(txtstock.Text.Trim(), stock) Then
                MessageBox.Show("El stock debe ser un número entero válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Actualizar el producto en la base de datos
            Using connection As New MySqlConnection(connectionString)
                Try
                    connection.Open()
                    Dim query As String = "UPDATE productos 
                                       SET nombre = @nombre, descripcion = @descripcion, marca = @marca, modelo = @modelo, 
                                           precio_compra = @precio_compra, precio_venta = @precio_venta, stock = @stock, id_proveedor = @id_proveedor 
                                       WHERE codigo = @codigo"
                    Dim command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@codigo", codigoProducto)
                    command.Parameters.AddWithValue("@nombre", txtproducto.Text.Trim())
                    command.Parameters.AddWithValue("@descripcion", txtdescripcion.Text.Trim())
                    command.Parameters.AddWithValue("@marca", txtmarca.Text.Trim())
                    command.Parameters.AddWithValue("@modelo", txtmodelo.Text.Trim())
                    command.Parameters.AddWithValue("@precio_compra", precioCompra)
                    command.Parameters.AddWithValue("@precio_venta", precioVenta)
                    command.Parameters.AddWithValue("@stock", stock)
                    command.Parameters.AddWithValue("@id_proveedor", CType(ComboBoxproveedores.SelectedItem, Object).Id)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Producto editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Recargar los productos en la tabla
                    CargarProductos()
                Catch ex As Exception
                    MessageBox.Show("Error al editar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            MessageBox.Show("Seleccione un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub tabladeproductos_SelectionChanged(sender As Object, e As EventArgs) Handles tabladeproductos.SelectionChanged
        ' Verificar si hay una fila seleccionada
        If tabladeproductos.SelectedRows.Count > 0 Then
            Dim selectedRow = tabladeproductos.SelectedRows(0)

            ' Cargar los datos de la fila seleccionada en las cajas de texto
            txtcodigo.Text = selectedRow.Cells("codigo").Value.ToString()
            txtproducto.Text = selectedRow.Cells("nombre").Value.ToString()
            txtdescripcion.Text = selectedRow.Cells("descripcion").Value.ToString()
            txtmarca.Text = selectedRow.Cells("marca").Value.ToString()
            txtmodelo.Text = selectedRow.Cells("modelo").Value.ToString()
            txtpreciocompra.Text = selectedRow.Cells("precio_compra").Value.ToString()
            txtprecioventa.Text = selectedRow.Cells("precio_venta").Value.ToString()
            txtstock.Text = selectedRow.Cells("stock").Value.ToString()

            ' Seleccionar el proveedor correspondiente en el ComboBox
            Dim proveedorNombre = selectedRow.Cells("proveedor").Value.ToString()
            For Each item In ComboBoxproveedores.Items
                If item.Nombre = proveedorNombre Then
                    ComboBoxproveedores.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub


End Class
