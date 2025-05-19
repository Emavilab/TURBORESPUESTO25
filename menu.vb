Public Class menu

    Public Property RolUsuario As String
    Public Property IdUsuario As Integer

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

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menutitulo_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs)

    End Sub



    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        USUARIOLOG.Text = RolUsuario
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub contenedor_Paint(sender As Object, e As PaintEventArgs) Handles contenedor.Paint

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
        ' Limpiar el panel contenedor
        contenedor.Controls.Clear()

        ' Crear una instancia del formulario
        Dim frm As New registrarventa()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        ' Agregar el formulario al panel y mostrarlo
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
End Class