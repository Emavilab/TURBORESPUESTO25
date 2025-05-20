Imports MySql.Data.MySqlClient

Public Class registrarventa

    Private idClienteSeleccionado As Integer
    Private idUsuarioActual As Integer ' Asigna este valor al abrir el formulario desde el login/menu
    Private idProductoSeleccionado As Integer

    Public Sub New(idUsuario As Integer)
        InitializeComponent()
        idUsuarioActual = idUsuario
    End Sub


    Private Sub LimpiarCampos()
        txtnombrecliente.Clear()
        txtdnicliente.Clear()
        txtcodigoproducto.Clear()
        txtnombreproducto.Clear()
        txtpreciocom.Clear()
        txtstock.Clear()
        txtimpuesto.Clear()
        txtdescuento.Clear()
        txttotal.Clear()
        txtpagacon.Clear()
        txtcambio.Clear()
        NumericUpDowncantiddad.Value = 1
    End Sub



    Private Function ObtenerIdProductoPorNombre(nombreProducto As String) As Integer
        ' Busca el id_producto en la base de datos por el nombre
        Dim idProducto As Integer = 0
        Dim connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"
        Using conn As New MySqlConnection(connectionString)

            conn.Open()
            Dim cmd As New MySqlCommand("SELECT id_producto FROM productos WHERE nombre = @nombre", conn)
            cmd.Parameters.AddWithValue("@nombre", nombreProducto)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                idProducto = Convert.ToInt32(result)
            End If
        End Using
        Return idProducto
    End Function


    Private Sub btnbuscarcliente_Click(sender As Object, e As EventArgs) Handles btnbuscarcliente.Click
        Dim frmBuscarCliente As New buscarclienteventas()
        AddHandler frmBuscarCliente.ClienteSeleccionado, AddressOf ClienteSeleccionadoHandler
        frmBuscarCliente.ShowDialog()
    End Sub
    Private Sub ClienteSeleccionadoHandler(idCliente As Integer, nombre As String, dni As String)
        idClienteSeleccionado = idCliente
        txtnombrecliente.Text = nombre
        txtdnicliente.Text = dni
    End Sub



    Private Sub btnbuscarproducto_Click(sender As Object, e As EventArgs) Handles btnbuscarproducto.Click
        Dim frmBuscarProducto As New buscarproductocompra()
        AddHandler frmBuscarProducto.ProductoSeleccionado, AddressOf ProductoSeleccionadoHandler
        frmBuscarProducto.ShowDialog()
    End Sub

    Private Sub ProductoSeleccionadoHandler(idProducto As Integer, codigo As String, nombre As String, precioCompra As Decimal, precioVenta As Decimal, stock As Integer)
        idProductoSeleccionado = idProducto
        txtcodigoproducto.Text = codigo
        txtnombreproducto.Text = nombre
        txtpreciocom.Text = precioVenta.ToString("0.00")
        txtstock.Text = stock.ToString()
    End Sub


    Private Sub ProductoSeleccionadoHandler(idProducto As Integer, codigo As String, nombre As String)

    End Sub

    Private Sub NumericUpDowncantiddad_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDowncantiddad.ValueChanged
        CalcularSubtotal()
    End Sub
    Private Sub CalcularSubtotal()
        Dim precioVenta As Decimal
        Decimal.TryParse(txtpreciocom.Text, precioVenta)
        Dim cantidad As Integer = NumericUpDowncantiddad.Value
        txttotal.Text = (precioVenta * cantidad).ToString("0.00")
    End Sub

    Private Sub btnagergartabla_Click(sender As Object, e As EventArgs) Handles btnagergartabla.Click
        If String.IsNullOrEmpty(txtnombreproducto.Text) OrElse String.IsNullOrEmpty(txtpreciocom.Text) Then
            MessageBox.Show("Seleccione un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim nombreProducto As String = txtnombreproducto.Text
        Dim precioVenta As Decimal = Convert.ToDecimal(txtpreciocom.Text)
        Dim cantidad As Integer = NumericUpDowncantiddad.Value
        Dim subtotal As Decimal = precioVenta * cantidad

        tabladecompras.Rows.Add(nombreProducto, precioVenta.ToString("0.00"), cantidad, subtotal.ToString("0.00"))
        CalcularTotales()
    End Sub

    Private Sub CalcularTotales()
        Dim subtotal As Decimal = 0
        For Each row As DataGridViewRow In tabladecompras.Rows
            If row.Cells(3).Value IsNot Nothing Then
                subtotal += Convert.ToDecimal(row.Cells(3).Value)
            End If
        Next

        txttotal.Text = subtotal.ToString("0.00")

        ' Impuesto fijo 5%
        Dim impuesto As Decimal = subtotal * 0.05D
        txtimpuesto.Text = impuesto.ToString("0.00")

        ' Descuento si subtotal > 3000
        Dim descuento As Decimal = 0
        If subtotal > 3000 Then
            descuento = (subtotal + impuesto) * 0.15D
            txtdescuento.Text = descuento.ToString("0.00")
        Else
            txtdescuento.Text = "0.00"
        End If

        ' Total
        Dim total As Decimal = subtotal + impuesto - descuento
        txttotal.Text = total.ToString("0.00")
    End Sub

    Private Sub txtpagacon_TextChanged(sender As Object, e As EventArgs) Handles txtpagacon.TextChanged
        CalcularCambio()
    End Sub

    Private Sub CalcularCambio()
        Dim total As Decimal
        Dim pagacon As Decimal
        Decimal.TryParse(txttotal.Text, total)
        Decimal.TryParse(txtpagacon.Text, pagacon)
        Dim cambio As Decimal = pagacon - total
        txtcambio.Text = cambio.ToString("0.00")
    End Sub

    Private Sub txtFECHA_TextChanged(sender As Object, e As EventArgs) Handles txtFECHA.TextChanged

    End Sub

    Private Sub registrarventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFECHA.Text = DateTime.Now.ToString("yyyy-MM-dd")

        ' Agregar columna de botón "Eliminar" si no existe
        If Not tabladecompras.Columns.Contains("Eliminar") Then
            Dim btnEliminar As New DataGridViewButtonColumn()
            btnEliminar.Name = "Eliminar"
            btnEliminar.HeaderText = "Eliminar"
            btnEliminar.Text = "Eliminar"
            btnEliminar.UseColumnTextForButtonValue = True
            tabladecompras.Columns.Add(btnEliminar)
        End If
    End Sub

    Private Sub tabladecompras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabladecompras.CellContentClick
        If e.ColumnIndex = tabladecompras.Columns("Eliminar").Index AndAlso e.RowIndex >= 0 Then
            tabladecompras.Rows.RemoveAt(e.RowIndex)
            CalcularTotales()
        End If
    End Sub

    Private Sub btnverdetalle_Click(sender As Object, e As EventArgs) Handles btnverdetalle.Click
        Dim frm As New DETALLEVENTA()
        frm.ShowDialog()
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        If idClienteSeleccionado = 0 Then
            MessageBox.Show("Seleccione un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If tabladecompras.Rows.Count = 0 OrElse tabladecompras.Rows.Cast(Of DataGridViewRow)().All(Function(r) r.IsNewRow) Then
            MessageBox.Show("Agregue al menos un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim totalVenta As Decimal = Convert.ToDecimal(txttotal.Text)
        Dim montoPago As Decimal = Convert.ToDecimal(txtpagacon.Text)
        Dim montoCambio As Decimal = Convert.ToDecimal(txtcambio.Text)
        Dim subtotal As Decimal = 0
        For Each row As DataGridViewRow In tabladecompras.Rows
            If row.IsNewRow Then Continue For
            subtotal += Convert.ToDecimal(row.Cells(3).Value)
        Next
        Dim impuesto As Decimal = Convert.ToDecimal(txtimpuesto.Text)
        Dim descuento As Decimal = Convert.ToDecimal(txtdescuento.Text)

        Dim connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim trans As MySqlTransaction = conn.BeginTransaction()
            Try
                ' 1. Insertar en venta
                Dim cmdVenta As New MySqlCommand("INSERT INTO ventas (id_cliente, total, id_usuario, monto_pago, monto_cambio) VALUES (@id_cliente, @total, @id_usuario, @monto_pago, @monto_cambio); SELECT LAST_INSERT_ID();", conn, trans)
                cmdVenta.Parameters.AddWithValue("@id_cliente", idClienteSeleccionado)
                cmdVenta.Parameters.AddWithValue("@total", totalVenta)
                cmdVenta.Parameters.AddWithValue("@id_usuario", idUsuarioActual)
                cmdVenta.Parameters.AddWithValue("@monto_pago", montoPago)
                cmdVenta.Parameters.AddWithValue("@monto_cambio", montoCambio)
                Dim idVenta As Integer = Convert.ToInt32(cmdVenta.ExecuteScalar())

                ' 2. Insertar en detalle_venta
                For Each row As DataGridViewRow In tabladecompras.Rows
                    If row.IsNewRow Then Continue For
                    Dim idProducto As Integer = ObtenerIdProductoPorNombre(row.Cells(0).Value.ToString())
                    Dim precioUnitario As Decimal = Convert.ToDecimal(row.Cells(1).Value)
                    Dim cantidad As Integer = Convert.ToInt32(row.Cells(2).Value)
                    Dim subtotalDetalle As Decimal = Convert.ToDecimal(row.Cells(3).Value)

                    Dim cmdDetalleVenta As New MySqlCommand("INSERT INTO detalle_venta (id_venta, id_producto, cantidad, precio_unitario, subtotal) VALUES (@id_venta, @id_producto, @cantidad, @precio_unitario, @subtotal)", conn, trans)
                    cmdDetalleVenta.Parameters.AddWithValue("@id_venta", idVenta)
                    cmdDetalleVenta.Parameters.AddWithValue("@id_producto", idProducto)
                    cmdDetalleVenta.Parameters.AddWithValue("@cantidad", cantidad)
                    cmdDetalleVenta.Parameters.AddWithValue("@precio_unitario", precioUnitario)
                    cmdDetalleVenta.Parameters.AddWithValue("@subtotal", subtotalDetalle)
                    cmdDetalleVenta.ExecuteNonQuery()
                    Dim cmdUpdateStock As New MySqlCommand("UPDATE productos SET stock = stock - @cantidad WHERE id_producto = @id_producto", conn, trans)
                    cmdUpdateStock.Parameters.AddWithValue("@cantidad", cantidad)
                    cmdUpdateStock.Parameters.AddWithValue("@id_producto", idProducto)
                    cmdUpdateStock.ExecuteNonQuery()
                Next


                ' 3. Insertar en factura
                Dim cmdFactura As New MySqlCommand("INSERT INTO facturas (id_cliente, total, impuesto, descuento, total_final, id_venta) VALUES (@id_cliente, @total, @impuesto, @descuento, @total_final, @id_venta); SELECT LAST_INSERT_ID();", conn, trans)
                cmdFactura.Parameters.AddWithValue("@id_cliente", idClienteSeleccionado)
                cmdFactura.Parameters.AddWithValue("@total", subtotal)
                cmdFactura.Parameters.AddWithValue("@impuesto", impuesto)
                cmdFactura.Parameters.AddWithValue("@descuento", descuento)
                cmdFactura.Parameters.AddWithValue("@total_final", totalVenta)
                cmdFactura.Parameters.AddWithValue("@id_venta", idVenta)
                Dim idFactura As Integer = Convert.ToInt32(cmdFactura.ExecuteScalar())

                ' 4. Insertar en detalle_factura
                For Each row As DataGridViewRow In tabladecompras.Rows
                    If row.IsNewRow Then Continue For
                    Dim idProducto As Integer = ObtenerIdProductoPorNombre(row.Cells(0).Value.ToString())
                    Dim precioUnitario As Decimal = Convert.ToDecimal(row.Cells(1).Value)
                    Dim cantidad As Integer = Convert.ToInt32(row.Cells(2).Value)
                    Dim subtotalDetalle As Decimal = Convert.ToDecimal(row.Cells(3).Value)

                    Dim cmdDetalleFactura As New MySqlCommand("INSERT INTO detalle_factura (id_factura, id_producto, cantidad, precio_unitario, subtotal) VALUES (@id_factura, @id_producto, @cantidad, @precio_unitario, @subtotal)", conn, trans)
                    cmdDetalleFactura.Parameters.AddWithValue("@id_factura", idFactura)
                    cmdDetalleFactura.Parameters.AddWithValue("@id_producto", idProducto)
                    cmdDetalleFactura.Parameters.AddWithValue("@cantidad", cantidad)
                    cmdDetalleFactura.Parameters.AddWithValue("@precio_unitario", precioUnitario)
                    cmdDetalleFactura.Parameters.AddWithValue("@subtotal", subtotalDetalle)
                    cmdDetalleFactura.ExecuteNonQuery()
                Next

                trans.Commit()
                MessageBox.Show("Venta y factura registradas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tabladecompras.Rows.Clear()
                LimpiarCampos()
            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("Error al registrar la venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class