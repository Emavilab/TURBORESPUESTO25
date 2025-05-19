Imports MySql.Data.MySqlClient

Public Class buscarproveedorcompra
    ' Cadena de conexión a la base de datos
    Private connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"

    ' Método para cargar los proveedores en la tabla (solo nombre y telefono)
    Private Sub CargarProveedores(Optional terminoBusqueda As String = "")
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT id_proveedor, nombre, telefono FROM proveedores"

                ' Agregar filtro de búsqueda si se proporciona un término
                If Not String.IsNullOrEmpty(terminoBusqueda) Then
                    query &= " WHERE nombre LIKE @termino OR telefono LIKE @termino"
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



    Public Event ProveedorSeleccionado(idProveedor As Integer, nombre As String, telefono As String)


    Private Sub tabladeproveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabladeproveedores.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row = tabladeproveedores.Rows(e.RowIndex)
            RaiseEvent ProveedorSeleccionado(
            Convert.ToInt32(row.Cells("id_proveedor").Value),
            row.Cells("nombre").Value.ToString(),
            row.Cells("telefono").Value.ToString()
        )
            Me.Close()
        End If
    End Sub





    ' Evento para buscar proveedores solo por nombre o telefono
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
End Class
