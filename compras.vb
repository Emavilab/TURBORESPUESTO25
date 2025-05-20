Public Class compras
    Private IdUsuarioActual As Integer

    Public Sub New(idUsuario As Integer)
        InitializeComponent()
        IdUsuarioActual = idUsuario
    End Sub

    Private Sub compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFECHA.Text = DateTime.Now.ToString("yyyy-MM-dd")
        btnregistrar.Enabled = False
    End Sub

    Private Function ObtenerIdUsuarioActual() As Integer
        Return IdUsuarioActual
    End Function


    Private Sub txtFECHA_TextChanged(sender As Object, e As EventArgs) Handles txtFECHA.TextChanged

    End Sub

    Private Sub txtnombrepro_TextChanged(sender As Object, e As EventArgs) Handles txtnombrepro.TextChanged

    End Sub

    Private Sub txttelefonopro_TextChanged(sender As Object, e As EventArgs) Handles txttelefonopro.TextChanged

    End Sub

    Private Sub btnbuscarpro_Click(sender As Object, e As EventArgs) Handles btnbuscarpro.Click
        Dim frmBuscarProveedor As New buscarproveedorcompra()
        AddHandler frmBuscarProveedor.ProveedorSeleccionado, AddressOf ProveedorSeleccionadoHandler
        frmBuscarProveedor.ShowDialog()
    End Sub

    Private Sub ProveedorSeleccionadoHandler(idProveedor As Integer, nombre As String, telefono As String)
        idProveedorSeleccionado = idProveedor
        txtnombrepro.Text = nombre
        txttelefonopro.Text = telefono
    End Sub


    Private Sub txtnombreproducto_TextChanged(sender As Object, e As EventArgs) Handles txtnombreproducto.TextChanged

    End Sub

    Private Sub txtcodigoproducto_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoproducto.TextChanged

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
        txtpreciocom.Text = precioCompra.ToString("0.00")
        txtprecioven.Text = precioVenta.ToString("0.00")

    End Sub


    Private Sub ProductoSeleccionadoHandler(idProducto As Integer, codigo As String, nombre As String)
        idProductoSeleccionado = idProducto
        txtcodigoproducto.Text = codigo
        txtnombreproducto.Text = nombre
    End Sub



    Private Sub txtpreciocom_TextChanged(sender As Object, e As EventArgs) Handles txtpreciocom.TextChanged

    End Sub

    Private Sub txtprecioven_TextChanged(sender As Object, e As EventArgs) Handles txtprecioven.TextChanged

    End Sub

    Private Sub NumericUpDowncantiddad_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDowncantiddad.ValueChanged, txtpreciocom.TextChanged
        CalcularSubtotal()
    End Sub

    Private Sub CalcularSubtotal()
        Dim precio As Decimal
        Dim cantidad As Integer = NumericUpDowncantiddad.Value
        Decimal.TryParse(txtpreciocom.Text, precio)
        txttotal.Text = (precio * cantidad).ToString("0.00")
    End Sub

    Private Sub btnagergartabla_Click(sender As Object, e As EventArgs) Handles btnagergartabla.Click
        If String.IsNullOrEmpty(txtnombreproducto.Text) OrElse String.IsNullOrEmpty(txtpreciocom.Text) Then
            MessageBox.Show("Seleccione un producto y asegúrese de tener precio de compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If



        Dim nombreProducto As String = txtnombreproducto.Text
        Dim precioCompra As Decimal = Convert.ToDecimal(txtpreciocom.Text)
        Dim cantidad As Integer = NumericUpDowncantiddad.Value
        Dim subtotal As Decimal = precioCompra * cantidad

        tabladecompras.Rows.Add(idProductoSeleccionado, nombreProducto, precioCompra.ToString("0.00"), cantidad, subtotal.ToString("0.00"), "Eliminar")
        CalcularTotal()
        btnregistrar.Enabled = True
    End Sub

    Private Sub CalcularTotal()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In tabladecompras.Rows
            If row.Cells(4).Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells(4).Value)
            End If
        Next
        txttotal.Text = total.ToString("0.00")
    End Sub


    Private Sub tabladecompras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabladecompras.CellContentClick
        If e.ColumnIndex = tabladecompras.Columns("Eliminar").Index AndAlso e.RowIndex >= 0 Then
            tabladecompras.Rows.RemoveAt(e.RowIndex)
            CalcularTotal()
            If tabladecompras.Rows.Cast(Of DataGridViewRow)().All(Function(r) r.IsNewRow) Then
                btnregistrar.Enabled = False
            End If
        End If
    End Sub
    Private idProveedorSeleccionado As Integer = 0
    Private idProductoSeleccionado As Integer = 0



    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub
    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        ' Validaciones básicas
        If idProveedorSeleccionado = 0 Then
            MessageBox.Show("Seleccione un proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If tabladecompras.Rows.Cast(Of DataGridViewRow)().All(Function(r) r.IsNewRow) Then
            MessageBox.Show("Agregue al menos un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If



        Dim totalCompra As Decimal = Convert.ToDecimal(txttotal.Text)
        Dim idUsuario As Integer = ObtenerIdUsuarioActual()
        Using conn As New MySql.Data.MySqlClient.MySqlConnection("Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;")
            conn.Open()
            Dim trans As MySql.Data.MySqlClient.MySqlTransaction = conn.BeginTransaction()
            Try
                ' 1. Insertar en compra
                Dim cmdCompra As New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO compras (id_proveedor, total, id_usuario, fecha) VALUES (@id_proveedor, @total, @id_usuario, @fecha); SELECT LAST_INSERT_ID();", conn, trans)
                cmdCompra.Parameters.AddWithValue("@id_proveedor", idProveedorSeleccionado)
                cmdCompra.Parameters.AddWithValue("@total", totalCompra)
                cmdCompra.Parameters.AddWithValue("@id_usuario", idUsuario)
                cmdCompra.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"))
                Dim idCompra As Integer = Convert.ToInt32(cmdCompra.ExecuteScalar())

                ' 2. Insertar detalles y actualizar productos
                For Each row As DataGridViewRow In tabladecompras.Rows
                    If row.IsNewRow Then Continue For
                    Dim idProducto As Integer = Convert.ToInt32(row.Cells(0).Value)
                    Dim precioUnitario As Decimal = Convert.ToDecimal(row.Cells(2).Value)
                    Dim cantidad As Integer = Convert.ToInt32(row.Cells(3).Value)
                    Dim subtotal As Decimal = Convert.ToDecimal(row.Cells(4).Value)
                    Dim precioVenta As Decimal = Convert.ToDecimal(txtprecioven.Text) ' Toma el precio de venta del textbox

                    ' Insertar detalle de compra
                    Dim cmdDetalle As New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO detalle_compra (id_compra, id_producto, cantidad, precio_unitario, subtotal) VALUES (@id_compra, @id_producto, @cantidad, @precio_unitario, @subtotal)", conn, trans)
                    cmdDetalle.Parameters.AddWithValue("@id_compra", idCompra)
                    cmdDetalle.Parameters.AddWithValue("@id_producto", idProducto)
                    cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad)
                    cmdDetalle.Parameters.AddWithValue("@precio_unitario", precioUnitario)
                    cmdDetalle.Parameters.AddWithValue("@subtotal", subtotal)
                    cmdDetalle.ExecuteNonQuery()

                    ' Actualizar producto: precio_compra, precio_venta y stock
                    Dim cmdUpdate As New MySql.Data.MySqlClient.MySqlCommand("UPDATE productos SET precio_compra = @precio_compra, precio_venta = @precio_venta, stock = stock + @cantidad WHERE id_producto = @id_producto", conn, trans)
                    cmdUpdate.Parameters.AddWithValue("@precio_compra", precioUnitario)
                    cmdUpdate.Parameters.AddWithValue("@precio_venta", precioVenta)
                    cmdUpdate.Parameters.AddWithValue("@cantidad", cantidad)
                    cmdUpdate.Parameters.AddWithValue("@id_producto", idProducto)
                    cmdUpdate.ExecuteNonQuery()
                Next

                trans.Commit()
                MessageBox.Show("Compra registrada y productos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Limpiar tabla y campos
                tabladecompras.Rows.Clear()
                txtnombrepro.Clear()
                txttelefonopro.Clear()
                txtcodigoproducto.Clear()
                txtnombreproducto.Clear()
                txtpreciocom.Clear()
                txtprecioven.Clear()
                txttotal.Clear()
                NumericUpDowncantiddad.Value = 1
                idProveedorSeleccionado = 0
                idProductoSeleccionado = 0
                btnregistrar.Enabled = False
            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("Error al registrar la compra: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub btnverdetalle_Click(sender As Object, e As EventArgs) Handles btnverdetalle.Click
        Dim frm As New detallecompra()
        frm.ShowDialog()
    End Sub
End Class