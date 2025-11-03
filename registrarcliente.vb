Imports MySql.Data.MySqlClient

Public Class registrarcliente
    ' Cadena de conexión a la base de datos
    Private connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"

    ' Cargar tipos de cliente en el ComboBox
    Private Sub CargarTiposCliente()
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT id_tipo_cliente, descripcion FROM tipo_cliente"
                Dim command As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()
                ComboBoxTIPOCLIENTE.Items.Clear()
                While reader.Read()
                    ComboBoxTIPOCLIENTE.Items.Add(New With {
                        .Id = reader("id_tipo_cliente"),
                        .Nombre = reader("descripcion").ToString()
                    })
                End While
                ComboBoxTIPOCLIENTE.DisplayMember = "Nombre"
                ComboBoxTIPOCLIENTE.ValueMember = "Id"
            Catch ex As Exception
                MessageBox.Show("Error al cargar tipos de cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Limpiar campos
    Private Sub LimpiarCampos()
        txtNOMBREPRO.Clear()
        txtTELEFONOPRO.Clear()
        txtUBICACION.Clear()
        txtEMAILPRO.Clear()
        txtdni.Clear()
        ComboBoxTIPOCLIENTE.SelectedIndex = -1
    End Sub

    Private Sub CargarClientes(Optional terminoBusqueda As String = "")
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT c.id_cliente, c.nombre, c.telefono, c.direccion, c.email, c.dni, t.descripcion AS tipo_cliente " &
                      "FROM clientes c " &
                      "INNER JOIN tipo_cliente t ON c.id_tipo_cliente = t.id_tipo_cliente"

                If Not String.IsNullOrEmpty(terminoBusqueda) Then
                    query &= " WHERE c.nombre LIKE @termino OR c.telefono LIKE @termino OR c.direccion LIKE @termino OR c.email LIKE @termino OR c.dni LIKE @termino OR t.descripcion LIKE @termino"
                End If
                Dim command As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(terminoBusqueda) Then
                    command.Parameters.AddWithValue("@termino", "%" & terminoBusqueda & "%")
                End If
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                tabladeclientes.DataSource = table

                If tabladeclientes.Columns.Contains("id_cliente") Then
                    tabladeclientes.Columns("id_cliente").Visible = False

                End If
            Catch ex As Exception
                MessageBox.Show("Error al cargar clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub eliminarprobtn_Click(sender As Object, e As EventArgs) Handles eliminarprobtn.Click
        If tabladeclientes.SelectedRows.Count > 0 Then
            Dim idCliente = tabladeclientes.SelectedRows(0).Cells("id_cliente").Value.ToString()
            Using connection As New MySqlConnection(connectionString)
                Try
                    connection.Open()
                    Dim query = "DELETE FROM clientes WHERE id_cliente = @id"
                    Dim command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", idCliente)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarClientes()
                    LimpiarCampos()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            MessageBox.Show("Seleccione un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Validación centralizada: no permitir agregar/editar si faltan campos
    Private Function ValidarCamposCliente() As Boolean
        ' comprueba y enfoca el primer control faltante
        If String.IsNullOrWhiteSpace(txtNOMBREPRO.Text) Then
            MessageBox.Show("Ingrese el nombre del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNOMBREPRO.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtTELEFONOPRO.Text) Then
            MessageBox.Show("Ingrese el teléfono del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTELEFONOPRO.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtUBICACION.Text) Then
            MessageBox.Show("Ingrese la dirección del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUBICACION.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtEMAILPRO.Text) Then
            MessageBox.Show("Ingrese el email del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEMAILPRO.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtdni.Text) Then
            MessageBox.Show("Ingrese el DNI del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtdni.Focus()
            Return False
        End If
        If ComboBoxTIPOCLIENTE.SelectedIndex = -1 OrElse ComboBoxTIPOCLIENTE.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione el tipo de cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBoxTIPOCLIENTE.Focus()
            Return False
        End If

        ' (Opcional) validaciones adicionales: formato email, longitud DNI, etc.
        Return True
    End Function

    Private Sub editarprobtn_Click(sender As Object, e As EventArgs) Handles editarprobtn.Click
        If tabladeclientes.SelectedRows.Count > 0 Then
            Dim idCliente As String = tabladeclientes.SelectedRows(0).Cells("id_cliente").Value.ToString()

            ' Usar validación centralizada
            If Not ValidarCamposCliente() Then
                Return
            End If

            Dim tipoClienteId As Integer = CType(ComboBoxTIPOCLIENTE.SelectedItem, Object).Id

            Using connection As New MySqlConnection(connectionString)
                Try
                    connection.Open()
                    Dim query As String = "UPDATE clientes SET nombre = @nombre, telefono = @telefono, direccion = @direccion, email = @email, dni = @dni, id_tipo_cliente = @id_tipo_cliente WHERE id_cliente = @id"
                    Dim command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", idCliente)
                    command.Parameters.AddWithValue("@nombre", txtNOMBREPRO.Text.Trim())
                    command.Parameters.AddWithValue("@telefono", txtTELEFONOPRO.Text.Trim())
                    command.Parameters.AddWithValue("@direccion", txtUBICACION.Text.Trim())
                    command.Parameters.AddWithValue("@email", txtEMAILPRO.Text.Trim())
                    command.Parameters.AddWithValue("@dni", txtdni.Text.Trim())
                    command.Parameters.AddWithValue("@id_tipo_cliente", tipoClienteId)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Cliente editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarClientes()
                    LimpiarCampos()
                Catch ex As Exception
                    MessageBox.Show("Error al editar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            MessageBox.Show("Seleccione un cliente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub agregarprobtn_Click(sender As Object, e As EventArgs) Handles agregarprobtn.Click
        ' Reutiliza la validación centralizada
        If Not ValidarCamposCliente() Then Return

        Dim tipoClienteId As Integer = CType(ComboBoxTIPOCLIENTE.SelectedItem, Object).Id

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO clientes (nombre, telefono, direccion, email, dni, id_tipo_cliente) 
                                       VALUES (@nombre, @telefono, @direccion, @email, @dni, @id_tipo_cliente)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@nombre", txtNOMBREPRO.Text.Trim())
                command.Parameters.AddWithValue("@telefono", txtTELEFONOPRO.Text.Trim())
                command.Parameters.AddWithValue("@direccion", txtUBICACION.Text.Trim())
                command.Parameters.AddWithValue("@email", txtEMAILPRO.Text.Trim())
                command.Parameters.AddWithValue("@dni", txtdni.Text.Trim())
                command.Parameters.AddWithValue("@id_tipo_cliente", tipoClienteId)

                command.ExecuteNonQuery()
                MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al agregar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub tabladeclientes_SelectionChanged(sender As Object, e As EventArgs) Handles tabladeclientes.SelectionChanged
        If tabladeclientes.SelectedRows.Count > 0 Then
            Dim selectedRow = tabladeclientes.SelectedRows(0)
            txtNOMBREPRO.Text = selectedRow.Cells("nombre").Value.ToString()
            txtTELEFONOPRO.Text = selectedRow.Cells("telefono").Value.ToString()
            txtUBICACION.Text = selectedRow.Cells("direccion").Value.ToString()
            txtEMAILPRO.Text = selectedRow.Cells("email").Value.ToString()
            txtdni.Text = selectedRow.Cells("dni").Value.ToString()
            ' Selecciona el tipo de cliente en el ComboBox por nombre
            For i As Integer = 0 To ComboBoxTIPOCLIENTE.Items.Count - 1
                If CType(ComboBoxTIPOCLIENTE.Items(i), Object).Nombre = selectedRow.Cells("tipo_cliente").Value.ToString() Then
                    ComboBoxTIPOCLIENTE.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
    End Sub


    Private Sub tabladeproveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabladeclientes.CellContentClick

    End Sub

    Private Sub txtbuscarpro_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarpro.TextChanged
        If String.IsNullOrEmpty(txtbuscarpro.Text.Trim()) Then
            CargarClientes()
        Else
            CargarClientes(txtbuscarpro.Text.Trim())
        End If
    End Sub



    Private Sub registrarcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTiposCliente()
        CargarClientes()
    End Sub
End Class