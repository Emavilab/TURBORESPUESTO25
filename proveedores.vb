Imports MySql.Data.MySqlClient

Public Class proveedores
    ' Cadena de conexión a la base de datos
    Private connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"

    ' Método para cargar los proveedores en la tabla
    Private Sub CargarProveedores(Optional terminoBusqueda As String = "")
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT id_proveedor, nombre, telefono, direccion, email FROM proveedores"

                ' Agregar filtro de búsqueda si se proporciona un término
                If Not String.IsNullOrEmpty(terminoBusqueda) Then
                    query &= " WHERE nombre LIKE @termino OR telefono LIKE @termino OR direccion LIKE @termino OR email LIKE @termino"
                End If

                Dim command As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(terminoBusqueda) Then
                    command.Parameters.AddWithValue("@termino", "%" & terminoBusqueda & "%")
                End If

                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                tabladeproveedores.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error al cargar proveedores: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Método para limpiar los campos de texto
    Private Sub LimpiarCampos()
        txtNOMBREPRO.Clear()
        txtTELEFONOPRO.Clear()
        txtUBICACION.Clear()
        txtEMAILPRO.Clear()
    End Sub

    ' Validación centralizada: no permitir agregar/editar si faltan campos
    Private Function ValidarCamposProveedor() As Boolean
        If String.IsNullOrWhiteSpace(txtNOMBREPRO.Text) Then
            MessageBox.Show("Ingrese el nombre del proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNOMBREPRO.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtTELEFONOPRO.Text) Then
            MessageBox.Show("Ingrese el teléfono del proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTELEFONOPRO.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtUBICACION.Text) Then
            MessageBox.Show("Ingrese la dirección del proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUBICACION.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtEMAILPRO.Text) Then
            MessageBox.Show("Ingrese el email del proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEMAILPRO.Focus()
            Return False
        End If

        ' (Opcional) Validaciones adicionales: formato de email, longitud teléfono, etc.

        Return True
    End Function

    ' Botón para agregar un nuevo proveedor
    Private Sub agregarprobtn_Click(sender As Object, e As EventArgs) Handles agregarprobtn.Click
        ' Reutiliza la validación centralizada
        If Not ValidarCamposProveedor() Then Return

        ' Insertar proveedor
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO proveedores (nombre, telefono, direccion, email) 
                                       VALUES (@nombre, @telefono, @direccion, @email)"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@nombre", txtNOMBREPRO.Text.Trim())
                command.Parameters.AddWithValue("@telefono", txtTELEFONOPRO.Text.Trim())
                command.Parameters.AddWithValue("@direccion", txtUBICACION.Text.Trim())
                command.Parameters.AddWithValue("@email", txtEMAILPRO.Text.Trim())

                command.ExecuteNonQuery()
                MessageBox.Show("Proveedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarProveedores()
                LimpiarCampos() ' Limpiar los campos después de agregar
            Catch ex As Exception
                MessageBox.Show("Error al agregar proveedor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Botón para eliminar un proveedor
    Private Sub eliminarprobtn_Click(sender As Object, e As EventArgs) Handles eliminarprobtn.Click
        If tabladeproveedores.SelectedRows.Count > 0 Then
            Dim idProveedor = tabladeproveedores.SelectedRows(0).Cells("id_proveedor").Value.ToString()
            Using connection As New MySqlConnection(connectionString)
                Try
                    connection.Open()
                    Dim query = "DELETE FROM proveedores WHERE id_proveedor = @id"
                    Dim command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", idProveedor)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarProveedores()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar proveedor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            MessageBox.Show("Seleccione un proveedor para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Botón para editar un proveedor
    Private Sub editarprobtn_Click(sender As Object, e As EventArgs) Handles editarprobtn.Click
        ' Verificar si hay una fila seleccionada
        If tabladeproveedores.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un proveedor para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idProveedor As String = tabladeproveedores.SelectedRows(0).Cells("id_proveedor").Value.ToString()

        ' Usar validación centralizada
        If Not ValidarCamposProveedor() Then
            Return
        End If

        ' Actualizar proveedor en la base de datos
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "UPDATE proveedores 
                                       SET nombre = @nombre, telefono = @telefono, direccion = @direccion, email = @email 
                                       WHERE id_proveedor = @id"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", idProveedor)
                command.Parameters.AddWithValue("@nombre", txtNOMBREPRO.Text.Trim())
                command.Parameters.AddWithValue("@telefono", txtTELEFONOPRO.Text.Trim())
                command.Parameters.AddWithValue("@direccion", txtUBICACION.Text.Trim())
                command.Parameters.AddWithValue("@email", txtEMAILPRO.Text.Trim())

                command.ExecuteNonQuery()
                MessageBox.Show("Proveedor editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarProveedores()
                LimpiarCampos() ' Limpiar los campos después de editar
            Catch ex As Exception
                MessageBox.Show("Error al editar proveedor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Evento para cargar los datos del proveedor seleccionado en los campos de texto
    Private Sub tabladeproveedores_SelectionChanged(sender As Object, e As EventArgs) Handles tabladeproveedores.SelectionChanged
        If tabladeproveedores.SelectedRows.Count > 0 Then
            Dim selectedRow = tabladeproveedores.SelectedRows(0)
            txtNOMBREPRO.Text = selectedRow.Cells("nombre").Value.ToString()
            txtTELEFONOPRO.Text = selectedRow.Cells("telefono").Value.ToString()
            txtUBICACION.Text = selectedRow.Cells("direccion").Value.ToString()
            txtEMAILPRO.Text = selectedRow.Cells("email").Value.ToString()
        End If
    End Sub

    ' Evento para buscar proveedores
    Private Sub txtbuscarpro_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarpro.TextChanged
        If String.IsNullOrEmpty(txtbuscarpro.Text.Trim()) Then
            CargarProveedores() ' Cargar todos los registros si el campo de búsqueda está vacío
        Else
            CargarProveedores(txtbuscarpro.Text.Trim()) ' Filtrar los registros según el término de búsqueda
        End If
    End Sub

    ' Evento para cargar los proveedores al abrir el formulario
    Private Sub proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProveedores()
    End Sub

    Private Sub ATRASBTNPRO_Click(sender As Object, e As EventArgs)
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

    Private Sub tabladeproveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabladeproveedores.CellContentClick

    End Sub
End Class
