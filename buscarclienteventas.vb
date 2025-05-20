Imports MySql.Data.MySqlClient

Public Class buscarclienteventas
    ' Cadena de conexión a la base de datos
    Private connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"

    ' Método para cargar clientes en el DataGridView
    Private Sub CargarClientes(Optional terminoBusqueda As String = "")
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT id_cliente, nombre, dni FROM clientes"
                If Not String.IsNullOrEmpty(terminoBusqueda) Then
                    query &= " WHERE nombre LIKE @termino OR dni LIKE @termino"
                End If
                Dim command As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(terminoBusqueda) Then
                    command.Parameters.AddWithValue("@termino", "%" & terminoBusqueda & "%")
                End If
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                tabladeproveedores.DataSource = table
                If tabladeproveedores.Columns.Contains("id_cliente") Then
                    tabladeproveedores.Columns("id_cliente").Visible = False
                End If
            Catch ex As Exception
                MessageBox.Show("Error al cargar clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    ' Cargar clientes al abrir el formulario
    Private Sub buscarclienteventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
    End Sub

    ' Buscar clientes por nombre o dni en tiempo real
    Private Sub txtbuscarpro_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarpro.TextChanged
        If String.IsNullOrEmpty(txtbuscarpro.Text.Trim()) Then
            CargarClientes()
        Else
            CargarClientes(txtbuscarpro.Text.Trim())
        End If
    End Sub

    Private Sub tabladeproveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabladeproveedores.CellContentClick

    End Sub

    Public Event ClienteSeleccionado(idCliente As Integer, nombre As String, dni As String)


    Private Sub tabladeproveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabladeproveedores.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row = tabladeproveedores.Rows(e.RowIndex)
            RaiseEvent ClienteSeleccionado(
                Convert.ToInt32(row.Cells("id_cliente").Value),
                row.Cells("nombre").Value.ToString(),
                row.Cells("dni").Value.ToString()
            )
            Me.Close()
        End If
    End Sub

End Class