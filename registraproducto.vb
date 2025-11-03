Imports MySql.Data.MySqlClient


Public Class registraproducto
    ' Cadena de conexión a la base de datos
    Private connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"

    ' Cargar los nombres de los proveedores en el ComboBox al cargar el formulario
    Private Sub registraproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load, tabladeproductos.SystemColorsChanged
        CargarProveedores()
        CargarProductos()
        CargarCategorias()
        CargarCategoriasBuscar()
    End Sub
    Private Sub CargarCategorias()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT id_categoria, nombre_categoria FROM categoria"
                Dim command As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ComboBoxcategorias.Items.Clear()
                While reader.Read()
                    ComboBoxcategorias.Items.Add(New With {
                    .Id = reader("id_categoria"),
                    .Nombre = reader("nombre_categoria").ToString()
                })
                End While
                ComboBoxcategorias.DisplayMember = "Nombre"
                ComboBoxcategorias.ValueMember = "Id"
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error al cargar categorías: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub CargarCategoriasBuscar()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT id_categoria, nombre_categoria FROM categoria"
                Dim command As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ComboBoxbuscar.Items.Clear()
                ComboBoxbuscar.Items.Add(New With {.Id = 0, .Nombre = "Todas las categorías"}) ' Opción para mostrar todos
                While reader.Read()
                    ComboBoxbuscar.Items.Add(New With {
                    .Id = reader("id_categoria"),
                    .Nombre = reader("nombre_categoria").ToString()
                })
                End While
                ComboBoxbuscar.DisplayMember = "Nombre"
                ComboBoxbuscar.ValueMember = "Id"
                ComboBoxbuscar.SelectedIndex = 0
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error al cargar categorías de búsqueda: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub CargarProductosPorCategoria(idCategoria As Integer)
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT p.codigo, p.nombre, p.descripcion, p.marca, p.modelo, p.precio_compra, p.precio_venta, p.stock, pr.nombre AS proveedor, c.nombre_categoria AS categoria
                       FROM productos p
                       INNER JOIN proveedores pr ON p.id_proveedor = pr.id_proveedor
                       INNER JOIN categoria c ON p.id_categoria = c.id_categoria
                       WHERE p.id_categoria = @id_categoria"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id_categoria", idCategoria)

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                tabladeproductos.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error al filtrar productos por categoría: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
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
    Private Sub CargarProductos(Optional terminoBusqueda As String = "")
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT p.codigo, p.nombre, p.descripcion, p.marca, p.modelo, p.precio_compra, p.precio_venta, p.stock, pr.nombre AS proveedor, c.nombre_categoria AS categoria
                       FROM productos p
                       INNER JOIN proveedores pr ON p.id_proveedor = pr.id_proveedor
                       INNER JOIN categoria c ON p.id_categoria = c.id_categoria"

                ' Agregar filtro de búsqueda si se proporciona un término
                If Not String.IsNullOrEmpty(terminoBusqueda) Then
                    query &= " WHERE p.codigo LIKE @termino OR p.nombre LIKE @termino OR p.marca LIKE @termino OR p.modelo LIKE @termino"
                End If

                Dim command As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(terminoBusqueda) Then
                    command.Parameters.AddWithValue("@termino", "%" & terminoBusqueda & "%")
                End If

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                tabladeproductos.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error al cargar productos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Método para limpiar los campos de texto y el ComboBox
    Private Sub LimpiarCampos()
        txtcodigo1.Clear()
        txtproducto1.Clear()
        txtdescripcion.Clear()
        txtmarca1.Clear()
        txtmodelo.Clear()
        txtpreciocompra.Clear()
        txtprecioventa.Clear()
        txtstock.Clear()
        ComboBoxproveedores.SelectedIndex = -1
        ComboBoxcategorias.SelectedIndex = -1
    End Sub
    ' Botón para agregar un nuevo producto
    Private Sub agregarbtn_Click(sender As Object, e As EventArgs) Handles agregarbtn.Click
        ' Validaciones
        If String.IsNullOrEmpty(txtcodigo1.Text.Trim()) OrElse
       String.IsNullOrEmpty(txtproducto1.Text.Trim()) OrElse
       String.IsNullOrEmpty(txtmarca1.Text.Trim()) OrElse
       String.IsNullOrEmpty(txtmodelo.Text.Trim()) OrElse
       String.IsNullOrEmpty(txtstock.Text.Trim()) OrElse
       String.IsNullOrEmpty(txtpreciocompra.Text.Trim()) OrElse
       String.IsNullOrEmpty(txtprecioventa.Text.Trim()) OrElse
       ComboBoxproveedores.SelectedItem Is Nothing OrElse
       ComboBoxcategorias.SelectedItem Is Nothing Then
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
                Dim query As String = "INSERT INTO productos (codigo, nombre, descripcion, marca, modelo, precio_compra, precio_venta, stock, id_proveedor, id_categoria) 
                                   VALUES (@codigo, @nombre, @descripcion, @marca, @modelo, @precio_compra, @precio_venta, @stock, @id_proveedor, @id_categoria)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@codigo", txtcodigo1.Text.Trim())
                command.Parameters.AddWithValue("@nombre", txtproducto1.Text.Trim())
                command.Parameters.AddWithValue("@descripcion", txtdescripcion.Text.Trim())
                command.Parameters.AddWithValue("@marca", txtmarca1.Text.Trim())
                command.Parameters.AddWithValue("@modelo", txtmodelo.Text.Trim())
                command.Parameters.AddWithValue("@precio_compra", Convert.ToDecimal(txtpreciocompra.Text.Trim()))
                command.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(txtprecioventa.Text.Trim()))
                command.Parameters.AddWithValue("@stock", Convert.ToInt32(txtstock.Text.Trim()))
                command.Parameters.AddWithValue("@id_proveedor", CType(ComboBoxproveedores.SelectedItem, Object).Id)
                command.Parameters.AddWithValue("@id_categoria", CType(ComboBoxcategorias.SelectedItem, Object).Id)

                command.ExecuteNonQuery()
                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarProductos()
                LimpiarCampos() ' Limpiar los campos después de agregar
            Catch ex As Exception
                MessageBox.Show("Error al agregar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    ' Validación reforzada para evitar editar con campos vacíos o inválidos
    Private Function ValidarCamposParaEditar() As Boolean
        Dim camposFaltantes As New List(Of String)()
        Dim primerControlAEnfocar As Control = Nothing

        If String.IsNullOrWhiteSpace(txtproducto1.Text) Then
            camposFaltantes.Add("Nombre del producto")
            If primerControlAEnfocar Is Nothing Then primerControlAEnfocar = txtproducto1
        End If
        If String.IsNullOrWhiteSpace(txtdescripcion.Text) Then
            camposFaltantes.Add("Descripción")
            If primerControlAEnfocar Is Nothing Then primerControlAEnfocar = txtdescripcion
        End If
        If String.IsNullOrWhiteSpace(txtmarca1.Text) Then
            camposFaltantes.Add("Marca")
            If primerControlAEnfocar Is Nothing Then primerControlAEnfocar = txtmarca1
        End If
        If String.IsNullOrWhiteSpace(txtmodelo.Text) Then
            camposFaltantes.Add("Modelo")
            If primerControlAEnfocar Is Nothing Then primerControlAEnfocar = txtmodelo
        End If
        If String.IsNullOrWhiteSpace(txtpreciocompra.Text) Then
            camposFaltantes.Add("Precio de compra")
            If primerControlAEnfocar Is Nothing Then primerControlAEnfocar = txtpreciocompra
        End If
        If String.IsNullOrWhiteSpace(txtprecioventa.Text) Then
            camposFaltantes.Add("Precio de venta")
            If primerControlAEnfocar Is Nothing Then primerControlAEnfocar = txtprecioventa
        End If
        If String.IsNullOrWhiteSpace(txtstock.Text) Then
            camposFaltantes.Add("Stock")
            If primerControlAEnfocar Is Nothing Then primerControlAEnfocar = txtstock
        End If

        If ComboBoxproveedores.SelectedItem Is Nothing Then
            camposFaltantes.Add("Proveedor")
            If primerControlAEnfocar Is Nothing Then primerControlAEnfocar = ComboBoxproveedores
        End If
        If ComboBoxcategorias.SelectedItem Is Nothing Then
            camposFaltantes.Add("Categoría")
            If primerControlAEnfocar Is Nothing Then primerControlAEnfocar = ComboBoxcategorias
        End If

        ' Mostrar mensaje si falta algo
        If camposFaltantes.Count > 0 Then
            Dim msg As String = "Complete los siguientes campos antes de editar:" & Environment.NewLine & String.Join(Environment.NewLine, camposFaltantes)
            MessageBox.Show(msg, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If primerControlAEnfocar IsNot Nothing Then primerControlAEnfocar.Focus()
            Return False
        End If

        ' Validar formatos numéricos
        Dim precioCompra As Decimal
        Dim precioVenta As Decimal
        Dim stock As Integer

        If Not Decimal.TryParse(txtpreciocompra.Text.Trim(), precioCompra) Then
            MessageBox.Show("El precio de compra debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpreciocompra.Focus()
            Return False
        End If

        If Not Decimal.TryParse(txtprecioventa.Text.Trim(), precioVenta) Then
            MessageBox.Show("El precio de venta debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtprecioventa.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtstock.Text.Trim(), stock) Then
            MessageBox.Show("El stock debe ser un número entero válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtstock.Focus()
            Return False
        End If

        Return True
    End Function

    ' Botón para editar un producto
    Private Sub editarbtn_Click(sender As Object, e As EventArgs) Handles editarbtn.Click
        ' Verificar si hay una fila seleccionada
        If tabladeproductos.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim codigoProducto As String = tabladeproductos.SelectedRows(0).Cells("codigo").Value.ToString()

        ' Validación reforzada: impedir editar si faltan campos o son inválidos
        If Not ValidarCamposParaEditar() Then
            Return
        End If

        ' Ya validado, convertir valores numéricos de forma segura
        Dim precioCompra As Decimal = Convert.ToDecimal(txtpreciocompra.Text.Trim())
        Dim precioVenta As Decimal = Convert.ToDecimal(txtprecioventa.Text.Trim())
        Dim stock As Integer = Convert.ToInt32(txtstock.Text.Trim())

        ' Actualizar el producto en la base de datos
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "UPDATE productos 
                                   SET nombre = @nombre, descripcion = @descripcion, marca = @marca, modelo = @modelo, 
                                       precio_compra = @precio_compra, precio_venta = @precio_venta, stock = @stock, 
                                       id_proveedor = @id_proveedor, id_categoria = @id_categoria
                                   WHERE codigo = @codigo"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@codigo", codigoProducto)
                command.Parameters.AddWithValue("@nombre", txtproducto1.Text.Trim())
                command.Parameters.AddWithValue("@descripcion", txtdescripcion.Text.Trim())
                command.Parameters.AddWithValue("@marca", txtmarca1.Text.Trim())
                command.Parameters.AddWithValue("@modelo", txtmodelo.Text.Trim())
                command.Parameters.AddWithValue("@precio_compra", precioCompra)
                command.Parameters.AddWithValue("@precio_venta", precioVenta)
                command.Parameters.AddWithValue("@stock", stock)
                command.Parameters.AddWithValue("@id_proveedor", CType(ComboBoxproveedores.SelectedItem, Object).Id)
                command.Parameters.AddWithValue("@id_categoria", CType(ComboBoxcategorias.SelectedItem, Object).Id)

                command.ExecuteNonQuery()
                MessageBox.Show("Producto editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarProductos()
                LimpiarCampos() ' Limpiar los campos después de editar
            Catch ex As Exception
                MessageBox.Show("Error al editar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    LimpiarCampos() ' Limpiar los campos después de eliminar
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



    Private Sub tabladeproductos_SelectionChanged(sender As Object, e As EventArgs) Handles tabladeproductos.SelectionChanged
        ' Verificar si hay una fila seleccionada
        If tabladeproductos.SelectedRows.Count > 0 Then
            Dim selectedRow = tabladeproductos.SelectedRows(0)

            txtcodigo1.Text = selectedRow.Cells("codigo").Value.ToString()
            txtproducto1.Text = selectedRow.Cells("nombre").Value.ToString()
            txtdescripcion.Text = selectedRow.Cells("descripcion").Value.ToString()
            txtmarca1.Text = selectedRow.Cells("marca").Value.ToString()
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

            ' Seleccionar la categoría correspondiente en el ComboBox
            Dim categoriaNombre = selectedRow.Cells("categoria").Value.ToString()
            For Each item In ComboBoxcategorias.Items
                If item.Nombre = categoriaNombre Then
                    ComboBoxcategorias.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub
    Private Sub ATRASBTN_Click(sender As Object, e As EventArgs)
        ' Verificar si ya existe una instancia del formulario menu
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is menu Then
                frm.Show() ' Mostrar el formulario existente
                Close() ' Cerrar el formulario actual
                Return
            End If
        Next

        ' Si no existe, crear una nueva instancia del formulario menu
        Dim formularioMenu As New menu
        formularioMenu.Show()
        Close()
    End Sub

    Private Sub buscarbtn_Click(sender As Object, e As EventArgs) Handles buscarbtn.Click
        Dim terminoBusqueda As String = txtbuscar.Text.Trim()
        CargarProductos(terminoBusqueda)
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        ' Verificar si el texto está vacío
        If String.IsNullOrEmpty(txtbuscar.Text.Trim()) Then
            ' Cargar todos los registros
            CargarProductos()
        End If

    End Sub

    Private Sub txtmodelo_TextChanged(sender As Object, e As EventArgs) Handles txtmodelo.TextChanged

    End Sub

    Private Sub ComboBoxcategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxcategorias.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxbuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxbuscar.SelectedIndexChanged
        If ComboBoxbuscar.SelectedItem IsNot Nothing Then
            Dim categoriaSeleccionada = CType(ComboBoxbuscar.SelectedItem, Object)
            If categoriaSeleccionada.Id = 0 Then
                ' Mostrar todos los productos
                CargarProductos()
            Else
                ' Filtrar productos por la categoría seleccionada
                CargarProductosPorCategoria(categoriaSeleccionada.Id)
            End If
        End If
    End Sub
End Class
