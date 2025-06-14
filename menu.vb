Imports MySql.Data.MySqlClient

Public Class menu

    Public Property RolUsuario As String
    Public Property IdUsuario As Integer
    Public Property IdRolUsuario As Integer
    Public Property NombreUsuario As String



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Crear una nueva instancia del formulario registraproducto
        Dim formularioRegistroProducto As New registraproducto

        ' Mostrar el formulario registraproducto
        formularioRegistroProducto.Show()

        ' Cerrar el formulario actual (menu)
        Close()
    End Sub

    Private Sub REGISTARPRO_Click(sender As Object, e As EventArgs)
        ' Crear una nueva instancia del formulario registraproducto
        Dim formularioRegistroProducto As New proveedores

        ' Mostrar el formulario registraproducto
        formularioRegistroProducto.Show()

        ' Cerrar el formulario actual (menu)
        Close()
    End Sub


    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        USUARIOLOG.Text = NombreUsuario

        ' Ocultar controles según el rol
        If IdRolUsuario = 2 Then ' 2 = empleado
            labelusuario.Visible = False
            Labelreportes.Visible = False
        ElseIf IdRolUsuario = 1 Then ' 1 = administrador
            labelusuario.Visible = True
            Labelreportes.Visible = True
        End If

        ActualizarTotalVentasDelDia()
    End Sub

    Private Sub ActualizarTotalVentasDelDia()
        Dim connectionString As String = "Server=127.0.0.1;Database=turborepuestodb;Uid=root;Pwd=;"
        Dim totalVentas As Decimal = 0

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT IFNULL(SUM(total),0) FROM ventas WHERE DATE(fecha) = CURDATE()"
            Using cmd As New MySqlCommand(query, conn)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    totalVentas = Convert.ToDecimal(result)
                End If
            End Using
        End Using

        labeltotal.Text = "Total ventas del día: " & totalVentas.ToString("C2")
    End Sub

    Private Sub Labelproducto_Click(sender As Object, e As EventArgs) Handles Labelproducto.Click
        ' Limpiar el panel contenedor
        contenedor.Controls.Clear()

        ' Crear una instancia del formulario
        Dim frm As New registraproducto()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        ' Agregar el formulario al panel y mostrarlo
        contenedor.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Labelproveedores_Click(sender As Object, e As EventArgs) Handles Labelproveedores.Click
        ' Limpiar el panel contenedor
        contenedor.Controls.Clear()

        ' Crear una instancia del formulario
        Dim frm As New proveedores()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        ' Agregar el formulario al panel y mostrarlo
        contenedor.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Labelventas_Click(sender As Object, e As EventArgs) Handles Labelventas.Click
        contenedor.Controls.Clear()
        Dim frm As New registrarventa(IdUsuarioLogueado)
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        contenedor.Controls.Add(frm)
        frm.Show()

    End Sub
    Public Property IdUsuarioLogueado As Integer


    Private Sub Labelcompras_Click(sender As Object, e As EventArgs) Handles Labelcompras.Click
        contenedor.Controls.Clear()
        Dim frm As New compras(IdUsuarioLogueado)
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        contenedor.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Labelclientes_Click(sender As Object, e As EventArgs) Handles Labelclientes.Click
        ' Limpiar el panel contenedor
        contenedor.Controls.Clear()

        ' Crear una instancia del formulario
        Dim frm As New registrarcliente()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        ' Agregar el formulario al panel y mostrarlo
        contenedor.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub labelusuario_Click(sender As Object, e As EventArgs) Handles labelusuario.Click
        ' Limpiar el panel contenedor
        contenedor.Controls.Clear()

        ' Crear una instancia del formulario
        Dim frm As New REGISTRARUSUARIOS()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        ' Agregar el formulario al panel y mostrarlo
        contenedor.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub PictureBoxcerrarsesion_Click(sender As Object, e As EventArgs) Handles PictureBoxcerrarsesion.Click
        Dim frmLogin As New login()
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Labelreportes_Click(sender As Object, e As EventArgs) Handles Labelreportes.Click
        ContextMenuReportes.Show(Labelreportes, New Point(0, Labelreportes.Height))
    End Sub

    Private Sub REPORTEVENTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTEVENTASToolStripMenuItem.Click
        ' Limpiar el panel contenedor
        contenedor.Controls.Clear()

        ' Crear una instancia del formulario
        Dim frm As New REPORTESVENTAS()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        ' Agregar el formulario al panel y mostrarlo
        contenedor.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub REPORTECOMPRAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTECOMPRAToolStripMenuItem.Click
        ' Limpiar el panel contenedor
        contenedor.Controls.Clear()

        ' Crear una instancia del formulario
        Dim frm As New REPORTECOMPRAS()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        ' Agregar el formulario al panel y mostrarlo
        contenedor.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles labelventasdeldia.Click

    End Sub

    Private Sub contenedor_Paint(sender As Object, e As PaintEventArgs) Handles contenedor.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ActualizarTotalVentasDelDia()
    End Sub
End Class