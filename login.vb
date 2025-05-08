Imports MySql.Data.MySqlClient

Public Class login
    Private Sub accederbtn_Click(sender As Object, e As EventArgs) Handles accederbtn.Click
        ' Cadena de conexión para MySQL
        Dim connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"
        Dim query As String = "SELECT COUNT(*) FROM usuarios WHERE nombre_usuario = @usuario AND contraseña = @contraseña"

        ' Obtener valores de los campos
        Dim usuario As String = txtusuario.Text.Trim()
        Dim contraseña As String = txtcontraseña.Text.Trim()

        ' Validación de campos vacíos
        If String.IsNullOrEmpty(usuario) OrElse String.IsNullOrEmpty(contraseña) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Conexión y validación
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    ' Parámetros para evitar inyección SQL
                    command.Parameters.AddWithValue("@usuario", usuario)
                    command.Parameters.AddWithValue("@contraseña", contraseña)

                    ' Ejecutar consulta
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim siguienteFormulario As New menu()
                        siguienteFormulario.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
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
End Class
