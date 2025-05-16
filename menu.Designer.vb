<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel1 = New Panel()
        USUARIOLOG = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Labelreportes = New Label()
        Labelclientes = New Label()
        Labelcompras = New Label()
        Labelventas = New Label()
        PictureBox1 = New PictureBox()
        Labelproveedores = New Label()
        Labelproducto = New Label()
        labelusuario = New Label()
        contenedor = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(USUARIOLOG)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1240, 50)
        Panel1.TabIndex = 0
        ' 
        ' USUARIOLOG
        ' 
        USUARIOLOG.AutoSize = True
        USUARIOLOG.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        USUARIOLOG.ForeColor = SystemColors.ButtonFace
        USUARIOLOG.Location = New Point(1061, 9)
        USUARIOLOG.Name = "USUARIOLOG"
        USUARIOLOG.Size = New Size(148, 30)
        USUARIOLOG.TabIndex = 2
        USUARIOLOG.Text = "USUARIOLOG"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(951, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 30)
        Label2.TabIndex = 1
        Label2.Text = "USUARIO:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(472, 30)
        Label1.TabIndex = 0
        Label1.Text = "SISTEMA DE INVENTARIO TURBORESPUESTOS"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.MenuHighlight
        Panel2.Controls.Add(Labelreportes)
        Panel2.Controls.Add(Labelclientes)
        Panel2.Controls.Add(Labelcompras)
        Panel2.Controls.Add(Labelventas)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Labelproveedores)
        Panel2.Controls.Add(Labelproducto)
        Panel2.Controls.Add(labelusuario)
        Panel2.Location = New Point(1, 42)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 727)
        Panel2.TabIndex = 1
        ' 
        ' Labelreportes
        ' 
        Labelreportes.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelreportes.ForeColor = SystemColors.ButtonHighlight
        Labelreportes.Image = My.Resources.Resources.reporte_de_negocios
        Labelreportes.ImageAlign = ContentAlignment.MiddleLeft
        Labelreportes.Location = New Point(11, 593)
        Labelreportes.Name = "Labelreportes"
        Labelreportes.Size = New Size(175, 59)
        Labelreportes.TabIndex = 10
        Labelreportes.Text = "Reportes"
        Labelreportes.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Labelclientes
        ' 
        Labelclientes.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelclientes.ForeColor = SystemColors.ButtonHighlight
        Labelclientes.Image = My.Resources.Resources.la_satisfaccion_del_cliente
        Labelclientes.ImageAlign = ContentAlignment.MiddleLeft
        Labelclientes.Location = New Point(11, 500)
        Labelclientes.Name = "Labelclientes"
        Labelclientes.Size = New Size(165, 59)
        Labelclientes.TabIndex = 9
        Labelclientes.Text = "Clientes"
        Labelclientes.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Labelcompras
        ' 
        Labelcompras.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelcompras.ForeColor = SystemColors.ButtonHighlight
        Labelcompras.Image = My.Resources.Resources.carrito_de_compras
        Labelcompras.ImageAlign = ContentAlignment.MiddleLeft
        Labelcompras.Location = New Point(11, 414)
        Labelcompras.Name = "Labelcompras"
        Labelcompras.Size = New Size(165, 59)
        Labelcompras.TabIndex = 8
        Labelcompras.Text = "Compras"
        Labelcompras.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Labelventas
        ' 
        Labelventas.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelventas.ForeColor = SystemColors.ButtonHighlight
        Labelventas.Image = My.Resources.Resources.etiqueta_de_precio
        Labelventas.ImageAlign = ContentAlignment.MiddleLeft
        Labelventas.Location = New Point(11, 323)
        Labelventas.Name = "Labelventas"
        Labelventas.Size = New Size(152, 59)
        Labelventas.TabIndex = 7
        Labelventas.Text = "Ventas"
        Labelventas.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(0, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 77)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Labelproveedores
        ' 
        Labelproveedores.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelproveedores.ForeColor = SystemColors.ButtonHighlight
        Labelproveedores.Image = My.Resources.Resources.cadena_de_suministro
        Labelproveedores.ImageAlign = ContentAlignment.MiddleLeft
        Labelproveedores.Location = New Point(8, 238)
        Labelproveedores.Name = "Labelproveedores"
        Labelproveedores.Size = New Size(189, 59)
        Labelproveedores.TabIndex = 5
        Labelproveedores.Text = "Proveedores"
        Labelproveedores.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Labelproducto
        ' 
        Labelproducto.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelproducto.ForeColor = SystemColors.ButtonHighlight
        Labelproducto.Image = My.Resources.Resources.carro_de_entregas
        Labelproducto.ImageAlign = ContentAlignment.MiddleLeft
        Labelproducto.Location = New Point(11, 160)
        Labelproducto.Name = "Labelproducto"
        Labelproducto.Size = New Size(175, 59)
        Labelproducto.TabIndex = 4
        Labelproducto.Text = "Productos"
        Labelproducto.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelusuario
        ' 
        labelusuario.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelusuario.ForeColor = SystemColors.ButtonHighlight
        labelusuario.Image = My.Resources.Resources.nuevo_usuario
        labelusuario.ImageAlign = ContentAlignment.MiddleLeft
        labelusuario.Location = New Point(8, 83)
        labelusuario.Name = "labelusuario"
        labelusuario.Size = New Size(155, 59)
        labelusuario.TabIndex = 3
        labelusuario.Text = "Usuarios"
        labelusuario.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' contenedor
        ' 
        contenedor.Location = New Point(193, 45)
        contenedor.Name = "contenedor"
        contenedor.Size = New Size(1048, 684)
        contenedor.TabIndex = 2
        ' 
        ' menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1240, 729)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(contenedor)
        Name = "menu"
        Text = "MENU"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Panel1 As Panel
    Friend WithEvents USUARIOLOG As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Labelreportes As Label
    Friend WithEvents Labelclientes As Label
    Friend WithEvents Labelcompras As Label
    Friend WithEvents Labelventas As Label
    Friend WithEvents Labelproveedores As Label
    Friend WithEvents Labelproducto As Label
    Friend WithEvents labelusuario As Label
    Friend WithEvents contenedor As Panel
End Class
