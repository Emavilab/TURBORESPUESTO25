<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTRARUSUARIOS
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
        Label2 = New Label()
        ComboBoxroles = New ComboBox()
        Label16 = New Label()
        txtcontraseña = New TextBox()
        Label15 = New Label()
        txtusuario = New TextBox()
        Label14 = New Label()
        txtnombrecompleto = New TextBox()
        Label13 = New Label()
        tabladeusuarios = New DataGridView()
        eliminarbtn = New Button()
        editarbtn = New Button()
        agregarbtn = New Button()
        ComboBoxbuscar = New ComboBox()
        Label12 = New Label()
        buscarbtn = New Button()
        txtbuscar = New TextBox()
        CType(tabladeusuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(263, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(483, 25)
        Label2.TabIndex = 3
        Label2.Text = "REGISTRO DE USUARIOS TURBOREPUESTOS"
        ' 
        ' ComboBoxroles
        ' 
        ComboBoxroles.FormattingEnabled = True
        ComboBoxroles.Location = New Point(23, 138)
        ComboBoxroles.Name = "ComboBoxroles"
        ComboBoxroles.Size = New Size(200, 23)
        ComboBoxroles.TabIndex = 28
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(23, 121)
        Label16.Name = "Label16"
        Label16.Size = New Size(119, 14)
        Label16.TabIndex = 27
        Label16.Text = "ROL DEL USUARIO"
        ' 
        ' txtcontraseña
        ' 
        txtcontraseña.Location = New Point(708, 78)
        txtcontraseña.Name = "txtcontraseña"
        txtcontraseña.Size = New Size(273, 23)
        txtcontraseña.TabIndex = 26
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(708, 61)
        Label15.Name = "Label15"
        Label15.Size = New Size(89, 14)
        Label15.TabIndex = 25
        Label15.Text = "CONTRASEÑA"
        ' 
        ' txtusuario
        ' 
        txtusuario.Location = New Point(369, 78)
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(297, 23)
        txtusuario.TabIndex = 24
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(369, 61)
        Label14.Name = "Label14"
        Label14.Size = New Size(141, 14)
        Label14.TabIndex = 23
        Label14.Text = "USARIO DEL SISTEMA"
        ' 
        ' txtnombrecompleto
        ' 
        txtnombrecompleto.Location = New Point(23, 78)
        txtnombrecompleto.Name = "txtnombrecompleto"
        txtnombrecompleto.Size = New Size(298, 23)
        txtnombrecompleto.TabIndex = 22
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(23, 61)
        Label13.Name = "Label13"
        Label13.Size = New Size(129, 14)
        Label13.TabIndex = 21
        Label13.Text = "NOMBRE COMPLETO"
        ' 
        ' tabladeusuarios
        ' 
        tabladeusuarios.AllowUserToAddRows = False
        tabladeusuarios.AllowUserToDeleteRows = False
        tabladeusuarios.BackgroundColor = Color.White
        tabladeusuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabladeusuarios.GridColor = Color.White
        tabladeusuarios.Location = New Point(144, 240)
        tabladeusuarios.Name = "tabladeusuarios"
        tabladeusuarios.ReadOnly = True
        tabladeusuarios.Size = New Size(744, 340)
        tabladeusuarios.TabIndex = 29
        ' 
        ' eliminarbtn
        ' 
        eliminarbtn.BackColor = SystemColors.MenuHighlight
        eliminarbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        eliminarbtn.ForeColor = Color.White
        eliminarbtn.Image = My.Resources.Resources.eliminar_producto
        eliminarbtn.ImageAlign = ContentAlignment.MiddleLeft
        eliminarbtn.Location = New Point(580, 614)
        eliminarbtn.Name = "eliminarbtn"
        eliminarbtn.Size = New Size(116, 51)
        eliminarbtn.TabIndex = 32
        eliminarbtn.Text = "ELIMINAR"
        eliminarbtn.TextAlign = ContentAlignment.MiddleRight
        eliminarbtn.UseVisualStyleBackColor = False
        ' 
        ' editarbtn
        ' 
        editarbtn.BackColor = SystemColors.MenuHighlight
        editarbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        editarbtn.ForeColor = Color.White
        editarbtn.Image = My.Resources.Resources.productos_cosmeticos
        editarbtn.ImageAlign = ContentAlignment.MiddleLeft
        editarbtn.Location = New Point(444, 614)
        editarbtn.Name = "editarbtn"
        editarbtn.Size = New Size(116, 51)
        editarbtn.TabIndex = 31
        editarbtn.Text = "EDITAR"
        editarbtn.TextAlign = ContentAlignment.MiddleRight
        editarbtn.UseVisualStyleBackColor = False
        ' 
        ' agregarbtn
        ' 
        agregarbtn.BackColor = SystemColors.MenuHighlight
        agregarbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        agregarbtn.ForeColor = Color.White
        agregarbtn.Image = My.Resources.Resources.anadir_al_carrito
        agregarbtn.ImageAlign = ContentAlignment.MiddleLeft
        agregarbtn.Location = New Point(313, 614)
        agregarbtn.Name = "agregarbtn"
        agregarbtn.Size = New Size(116, 51)
        agregarbtn.TabIndex = 30
        agregarbtn.Text = "AGREGAR"
        agregarbtn.TextAlign = ContentAlignment.MiddleRight
        agregarbtn.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxbuscar
        ' 
        ComboBoxbuscar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBoxbuscar.FormattingEnabled = True
        ComboBoxbuscar.Location = New Point(105, 195)
        ComboBoxbuscar.Name = "ComboBoxbuscar"
        ComboBoxbuscar.Size = New Size(182, 25)
        ComboBoxbuscar.TabIndex = 39
        ComboBoxbuscar.Text = "Roles"
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(12, 196)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 23)
        Label12.TabIndex = 38
        Label12.Text = "Buscar por:"
        ' 
        ' buscarbtn
        ' 
        buscarbtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buscarbtn.Location = New Point(860, 191)
        buscarbtn.Name = "buscarbtn"
        buscarbtn.Size = New Size(157, 29)
        buscarbtn.TabIndex = 37
        buscarbtn.Text = "Buscar"
        buscarbtn.UseVisualStyleBackColor = True
        ' 
        ' txtbuscar
        ' 
        txtbuscar.BackColor = SystemColors.Menu
        txtbuscar.Location = New Point(306, 195)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(548, 23)
        txtbuscar.TabIndex = 36
        ' 
        ' REGISTRARUSUARIOS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1050, 710)
        Controls.Add(ComboBoxbuscar)
        Controls.Add(Label12)
        Controls.Add(buscarbtn)
        Controls.Add(txtbuscar)
        Controls.Add(eliminarbtn)
        Controls.Add(editarbtn)
        Controls.Add(agregarbtn)
        Controls.Add(tabladeusuarios)
        Controls.Add(ComboBoxroles)
        Controls.Add(Label16)
        Controls.Add(txtcontraseña)
        Controls.Add(Label15)
        Controls.Add(txtusuario)
        Controls.Add(Label14)
        Controls.Add(txtnombrecompleto)
        Controls.Add(Label13)
        Controls.Add(Label2)
        Name = "REGISTRARUSUARIOS"
        Text = "REGISTRARUSUARIOS"
        CType(tabladeusuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxroles As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtnombrecompleto As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tabladeusuarios As DataGridView
    Friend WithEvents eliminarbtn As Button
    Friend WithEvents editarbtn As Button
    Friend WithEvents agregarbtn As Button
    Friend WithEvents ComboBoxbuscar As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents buscarbtn As Button
    Friend WithEvents txtbuscar As TextBox
End Class
