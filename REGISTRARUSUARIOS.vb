Imports MySql.Data.MySqlClient

Public Class REGISTRARUSUARIOS
    Private connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"
    Private rolesDict As New Dictionary(Of String, Integer) ' nombre_rol -> id_rol

    ' Cargar roles en ComboBoxroles y ComboBoxbuscar
    Private Sub CargarRoles()
        rolesDict.Clear()
        ComboBoxroles.Items.Clear()
        ComboBoxbuscar.Items.Clear()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT id_rol, nombre_rol FROM rol", conn)
            Dim reader = cmd.ExecuteReader()
            While reader.Read()
                Dim idRol = Convert.ToInt32(reader("id_rol"))
                Dim nombreRol = reader("nombre_rol").ToString()
                rolesDict(nombreRol) = idRol
                ComboBoxroles.Items.Add(nombreRol)
                ComboBoxbuscar.Items.Add(nombreRol)
            End While
        End Using
    End Sub

    ' Cargar usuarios en la tabla
    Private Sub CargarUsuarios(Optional filtroRol As String = "", Optional filtroTexto As String = "")
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT u.id_usuario, u.nombre_completo, u.nombre_usuario, u.contraseña, r.nombre_rol " &
                                  "FROM usuarios u INNER JOIN rol r ON u.id_rol = r.id_rol WHERE 1=1"
            If Not String.IsNullOrEmpty(filtroRol) Then
                query &= " AND r.nombre_rol = @rol"
            End If
            If Not String.IsNullOrEmpty(filtroTexto) Then
                query &= " AND (u.nombre_usuario LIKE @texto OR u.nombre_completo LIKE @texto)"
            End If
            Dim cmd As New MySqlCommand(query, conn)
            If Not String.IsNullOrEmpty(filtroRol) Then
                cmd.Parameters.AddWithValue("@rol", filtroRol)
            End If
            If Not String.IsNullOrEmpty(filtroTexto) Then
                cmd.Parameters.AddWithValue("@texto", "%" & filtroTexto & "%")
            End If
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            tabladeusuarios.DataSource = table
            If tabladeusuarios.Columns.Contains("id_usuario") Then
                tabladeusuarios.Columns("id_usuario").Visible = False
            End If
        End Using
    End Sub
    Private Sub LimpiarCampos()
        txtnombrecompleto.Clear()
        txtusuario.Clear()
        txtcontraseña.Clear()
        ComboBoxroles.SelectedIndex = -1
    End Sub
    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub agregarbtn_Click(sender As Object, e As EventArgs) Handles agregarbtn.Click
        ' Validaciones de campos obligatorios
        If String.IsNullOrWhiteSpace(txtnombrecompleto.Text) Then
            MessageBox.Show("Ingrese el nombre completo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtnombrecompleto.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(txtusuario.Text) Then
            MessageBox.Show("Ingrese el nombre de usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtusuario.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(txtcontraseña.Text) Then
            MessageBox.Show("Ingrese la contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtcontraseña.Focus()
            Return
        End If
        If ComboBoxroles.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un rol.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBoxroles.Focus()
            Return
        End If

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO usuarios (nombre_completo, nombre_usuario, contraseña, id_rol) VALUES (@nombre_completo, @nombre_usuario, @contraseña, @id_rol)", conn)
            cmd.Parameters.AddWithValue("@nombre_completo", txtnombrecompleto.Text.Trim())
            cmd.Parameters.AddWithValue("@nombre_usuario", txtusuario.Text.Trim())
            cmd.Parameters.AddWithValue("@contraseña", txtcontraseña.Text.Trim())
            cmd.Parameters.AddWithValue("@id_rol", rolesDict(ComboBoxroles.SelectedItem.ToString()))
            cmd.ExecuteNonQuery()
            MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarUsuarios()
            LimpiarCampos()
        End Using
    End Sub

    Private Sub editarbtn_Click(sender As Object, e As EventArgs) Handles editarbtn.Click
        If tabladeusuarios.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un usuario para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim idUsuario = tabladeusuarios.SelectedRows(0).Cells("id_usuario").Value
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE usuarios SET nombre_completo=@nombre_completo, nombre_usuario=@nombre_usuario, contraseña=@contraseña, id_rol=@id_rol WHERE id_usuario=@id_usuario", conn)
            cmd.Parameters.AddWithValue("@nombre_completo", txtnombrecompleto.Text.Trim())
            cmd.Parameters.AddWithValue("@nombre_usuario", txtusuario.Text.Trim())
            cmd.Parameters.AddWithValue("@contraseña", txtcontraseña.Text.Trim())
            cmd.Parameters.AddWithValue("@id_rol", rolesDict(ComboBoxroles.SelectedItem.ToString()))
            cmd.Parameters.AddWithValue("@id_usuario", idUsuario)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Usuario editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarUsuarios()
            LimpiarCampos()
        End Using
    End Sub

    Private Sub eliminarbtn_Click(sender As Object, e As EventArgs) Handles eliminarbtn.Click
        If tabladeusuarios.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim idUsuario = tabladeusuarios.SelectedRows(0).Cells("id_usuario").Value
        If MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM usuarios WHERE id_usuario=@id_usuario", conn)
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarUsuarios()
                LimpiarCampos()
            End Using
        End If
    End Sub
    ' Cargar datos seleccionados en los campos
    Private Sub tabladeusuarios_SelectionChanged(sender As Object, e As EventArgs) Handles tabladeusuarios.SelectionChanged
        If tabladeusuarios.SelectedRows.Count > 0 Then
            Dim row = tabladeusuarios.SelectedRows(0)
            txtnombrecompleto.Text = row.Cells("nombre_completo").Value.ToString()
            txtusuario.Text = row.Cells("nombre_usuario").Value.ToString()
            txtcontraseña.Text = row.Cells("contraseña").Value.ToString()
            ComboBoxroles.SelectedItem = row.Cells("nombre_rol").Value.ToString()
        End If
    End Sub

    Private Sub tabladeusuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabladeusuarios.CellContentClick

    End Sub

    Private Sub ComboBoxbuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxbuscar.SelectedIndexChanged

        CargarUsuarios(ComboBoxbuscar.SelectedItem.ToString(), txtbuscar.Text.Trim())

    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Dim rolFiltro As String = ""
        If ComboBoxbuscar.SelectedIndex <> -1 Then rolFiltro = ComboBoxbuscar.SelectedItem.ToString()
        CargarUsuarios(rolFiltro, txtbuscar.Text.Trim())
    End Sub

    Private Sub buscarbtn_Click(sender As Object, e As EventArgs) Handles buscarbtn.Click

    End Sub

    Private Sub REGISTRARUSUARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRoles()
        CargarUsuarios()

    End Sub
End Class