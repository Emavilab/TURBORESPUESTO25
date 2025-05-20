Imports MySql.Data.MySqlClient

Public Class buscarproductocompra
    Private connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"

    ' Cargar categorías en el ComboBox de búsqueda
    Private Sub CargarCategoriasBuscar()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT id_categoria, nombre_categoria FROM categoria"
                Dim command As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ComboBoxbuscar.Items.Clear()
                ComboBoxbuscar.Items.Add(New With {.Id = 0, .Nombre = "Todas las categorías"})
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
                MessageBox.Show("Error al cargar categorías: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Cargar productos filtrados por categoría y/o término de búsqueda
    Private Sub CargarProductosFiltrados(Optional idCategoria As Integer = 0, Optional termino As String = "")
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT p.id_producto, p.codigo, p.nombre, c.nombre_categoria AS categoria, " &
                                  "p.precio_compra, p.precio_venta, p.stock " &
                                  "FROM productos p " &
                                  "INNER JOIN categoria c ON p.id_categoria = c.id_categoria " &
                                  "WHERE 1=1"

                If idCategoria > 0 Then
                    query &= " AND p.id_categoria = @id_categoria"
                End If
                If Not String.IsNullOrEmpty(termino) Then
                    query &= " AND (p.codigo LIKE @termino OR p.nombre LIKE @termino)"
                End If

                Dim command As New MySqlCommand(query, connection)
                If idCategoria > 0 Then
                    command.Parameters.AddWithValue("@id_categoria", idCategoria)
                End If
                If Not String.IsNullOrEmpty(termino) Then
                    command.Parameters.AddWithValue("@termino", "%" & termino & "%")
                End If

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                tabladeproveedores.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error al cargar productos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Evento de carga del formulario
    Private Sub buscarproductocompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategoriasBuscar()
        CargarProductosFiltrados() ' Mostrar todos al inicio
    End Sub

    ' Evento al cambiar la categoría seleccionada
    Private Sub ComboBoxbuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxbuscar.SelectedIndexChanged
        Dim idCategoria As Integer = 0
        If ComboBoxbuscar.SelectedItem IsNot Nothing Then
            idCategoria = CType(ComboBoxbuscar.SelectedItem, Object).Id
        End If
        CargarProductosFiltrados(idCategoria, txtbuscar.Text.Trim())
    End Sub

    ' Evento al cambiar el texto de búsqueda
    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Dim idCategoria As Integer = 0
        If ComboBoxbuscar.SelectedItem IsNot Nothing Then
            idCategoria = CType(ComboBoxbuscar.SelectedItem, Object).Id
        End If
        CargarProductosFiltrados(idCategoria, txtbuscar.Text.Trim())
    End Sub
    Public Event ProductoSeleccionado(idProducto As Integer, codigo As String, nombre As String, precioCompra As Decimal, precioVenta As Decimal, stock As Integer)

    ' Ejemplo de cómo lanzar el evento al seleccionar un producto (por doble clic en la tabla)
    Private Sub tablaproductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabladeproveedores.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row = tabladeproveedores.Rows(e.RowIndex)
            RaiseEvent ProductoSeleccionado(
            Convert.ToInt32(row.Cells("id_producto").Value),
            row.Cells("codigo").Value.ToString(),
            row.Cells("nombre").Value.ToString(),
            Convert.ToDecimal(row.Cells("precio_compra").Value),
            Convert.ToDecimal(row.Cells("precio_venta").Value),
            Convert.ToInt32(row.Cells("stock").Value)
        )
            Me.Close()
        End If
    End Sub




    Private Sub tabladeproveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabladeproveedores.CellContentClick

    End Sub
End Class
