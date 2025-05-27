
Imports MySql.Data.MySqlClient
Public Class login
    Private Sub accederbtn_Click(sender As Object, e As EventArgs) Handles accederbtn.Click
        Dim connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"
        Dim query As String = "SELECT u.id_usuario, u.id_rol, r.nombre_rol FROM usuarios u INNER JOIN rol r ON u.id_rol = r.id_rol WHERE u.nombre_usuario = @usuario AND u.contraseña = @contraseña"

        Dim usuario As String = txtusuario.Text.Trim()
        Dim contraseña As String = txtcontraseña.Text.Trim()

        If String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(contraseña) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@usuario", usuario)
                    command.Parameters.AddWithValue("@contraseña", contraseña)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim idRol As Integer = Convert.ToInt32(reader("id_rol"))
                            Dim rol As String = reader("nombre_rol").ToString()
                            Dim idUsuario As Integer = Convert.ToInt32(reader("id_usuario"))

                            Dim siguienteFormulario As New menu()
                            siguienteFormulario.RolUsuario = rol
                            siguienteFormulario.IdUsuarioLogueado = idUsuario
                            siguienteFormulario.IdRolUsuario = idRol
                            siguienteFormulario.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub salirbtn_Click(sender As Object, e As EventArgs) Handles salirbtn.Click
        Me.Close()
    End Sub

    Private Sub checkmostrar_CheckedChanged(sender As Object, e As EventArgs) Handles checkmostrar.CheckedChanged
        ' Mostrar u ocultar la contraseña según el estado del CheckBox
        If checkmostrar.Checked Then
            txtcontraseña.PasswordChar = ControlChars.NullChar ' Muestra la contraseña
        Else
            txtcontraseña.PasswordChar = "*" ' Oculta la contraseña
        End If
    End Sub

    Private Sub txtcontraseña_TextChanged(sender As Object, e As EventArgs) Handles txtcontraseña.TextChanged
        ' Este evento puede usarse para validaciones adicionales si es necesario
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class