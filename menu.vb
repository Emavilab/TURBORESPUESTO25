Public Class menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Crear una nueva instancia del formulario registraproducto
        Dim formularioRegistroProducto As New registraproducto()

        ' Mostrar el formulario registraproducto
        formularioRegistroProducto.Show()

        ' Cerrar el formulario actual (menu)
        Me.Close()
    End Sub

    Private Sub REGISTARPRO_Click(sender As Object, e As EventArgs) Handles REGISTARPRO.Click
        ' Crear una nueva instancia del formulario registraproducto
        Dim formularioRegistroProducto As New proveedores()

        ' Mostrar el formulario registraproducto
        formularioRegistroProducto.Show()

        ' Cerrar el formulario actual (menu)
        Me.Close()
    End Sub
End Class
