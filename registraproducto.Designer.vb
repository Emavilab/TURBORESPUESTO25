<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registraproducto
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
        Label1 = New Label()
        txtcodigo = New TextBox()
        txtproducto = New TextBox()
        Label3 = New Label()
        txtdescripcion = New TextBox()
        Label4 = New Label()
        txtmarca = New TextBox()
        Label5 = New Label()
        txtmodelo = New TextBox()
        Label6 = New Label()
        txtpreciocompra = New TextBox()
        Label7 = New Label()
        txtprecioventa = New TextBox()
        Label8 = New Label()
        txtstock = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        ComboBoxproveedores = New ComboBox()
        tabladeproductos = New DataGridView()
        agregarbtn = New Button()
        editarbtn = New Button()
        eliminarbtn = New Button()
        txtbuscar = New TextBox()
        buscarbtn = New Button()
        ComboBoxcategorias = New ComboBox()
        Label11 = New Label()
        Label12 = New Label()
        ComboBoxbuscar = New ComboBox()
        Label13 = New Label()
        txtcodigo1 = New TextBox()
        Label14 = New Label()
        txtproducto1 = New TextBox()
        Label15 = New Label()
        txtmarca1 = New TextBox()
        Label16 = New Label()
        CType(tabladeproductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(333, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(291, 25)
        Label2.TabIndex = 2
        Label2.Text = "REGISTRO DE PRODUCTOS"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 14)
        Label1.TabIndex = 3
        Label1.Text = "CODIGO"
        ' 
        ' txtcodigo
        ' 
        txtcodigo.Location = New Point(12, 84)
        txtcodigo.Name = "txtcodigo"
        txtcodigo.Size = New Size(75, 23)
        txtcodigo.TabIndex = 4
        ' 
        ' txtproducto
        ' 
        txtproducto.Location = New Point(104, 84)
        txtproducto.Name = "txtproducto"
        txtproducto.Size = New Size(228, 23)
        txtproducto.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(104, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 14)
        Label3.TabIndex = 5
        Label3.Text = "NOMBRE DEL PRODUCTO"
        ' 
        ' txtdescripcion
        ' 
        txtdescripcion.Location = New Point(715, 139)
        txtdescripcion.Multiline = True
        txtdescripcion.Name = "txtdescripcion"
        txtdescripcion.Size = New Size(294, 50)
        txtdescripcion.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(715, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 14)
        Label4.TabIndex = 7
        Label4.Text = "DESCRIPCIÓN"
        ' 
        ' txtmarca
        ' 
        txtmarca.Location = New Point(366, 84)
        txtmarca.Name = "txtmarca"
        txtmarca.Size = New Size(158, 23)
        txtmarca.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(366, 67)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 14)
        Label5.TabIndex = 9
        Label5.Text = "MARCA"
        ' 
        ' txtmodelo
        ' 
        txtmodelo.Location = New Point(555, 84)
        txtmodelo.Name = "txtmodelo"
        txtmodelo.Size = New Size(161, 23)
        txtmodelo.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(555, 67)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 14)
        Label6.TabIndex = 11
        Label6.Text = "MODELO"
        ' 
        ' txtpreciocompra
        ' 
        txtpreciocompra.Location = New Point(868, 84)
        txtpreciocompra.Name = "txtpreciocompra"
        txtpreciocompra.Size = New Size(157, 23)
        txtpreciocompra.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(868, 67)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 14)
        Label7.TabIndex = 13
        Label7.Text = "PRECIO COMPRA"
        ' 
        ' txtprecioventa
        ' 
        txtprecioventa.Location = New Point(15, 157)
        txtprecioventa.Name = "txtprecioventa"
        txtprecioventa.Size = New Size(150, 23)
        txtprecioventa.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(15, 140)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 14)
        Label8.TabIndex = 15
        Label8.Text = "PRECIO VENTA"
        ' 
        ' txtstock
        ' 
        txtstock.Location = New Point(734, 84)
        txtstock.Name = "txtstock"
        txtstock.Size = New Size(114, 23)
        txtstock.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(734, 67)
        Label9.Name = "Label9"
        Label9.Size = New Size(47, 14)
        Label9.TabIndex = 17
        Label9.Text = "STOCK"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(213, 140)
        Label10.Name = "Label10"
        Label10.Size = New Size(82, 14)
        Label10.TabIndex = 19
        Label10.Text = "PROVEEDOR"
        ' 
        ' ComboBoxproveedores
        ' 
        ComboBoxproveedores.FormattingEnabled = True
        ComboBoxproveedores.Location = New Point(204, 157)
        ComboBoxproveedores.Name = "ComboBoxproveedores"
        ComboBoxproveedores.Size = New Size(200, 23)
        ComboBoxproveedores.TabIndex = 20
        ' 
        ' tabladeproductos
        ' 
        tabladeproductos.AllowUserToAddRows = False
        tabladeproductos.AllowUserToDeleteRows = False
        tabladeproductos.BackgroundColor = Color.White
        tabladeproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabladeproductos.GridColor = Color.White
        tabladeproductos.Location = New Point(12, 275)
        tabladeproductos.Name = "tabladeproductos"
        tabladeproductos.ReadOnly = True
        tabladeproductos.Size = New Size(1026, 340)
        tabladeproductos.TabIndex = 22
        ' 
        ' agregarbtn
        ' 
        agregarbtn.BackColor = SystemColors.MenuHighlight
        agregarbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        agregarbtn.ForeColor = Color.White
        agregarbtn.Image = My.Resources.Resources.anadir_al_carrito
        agregarbtn.ImageAlign = ContentAlignment.MiddleLeft
        agregarbtn.Location = New Point(314, 621)
        agregarbtn.Name = "agregarbtn"
        agregarbtn.Size = New Size(116, 51)
        agregarbtn.TabIndex = 26
        agregarbtn.Text = "AGREGAR"
        agregarbtn.TextAlign = ContentAlignment.MiddleRight
        agregarbtn.UseVisualStyleBackColor = False
        ' 
        ' editarbtn
        ' 
        editarbtn.BackColor = SystemColors.MenuHighlight
        editarbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        editarbtn.ForeColor = Color.White
        editarbtn.Image = My.Resources.Resources.productos_cosmeticos
        editarbtn.ImageAlign = ContentAlignment.MiddleLeft
        editarbtn.Location = New Point(445, 621)
        editarbtn.Name = "editarbtn"
        editarbtn.Size = New Size(116, 51)
        editarbtn.TabIndex = 27
        editarbtn.Text = "EDITAR"
        editarbtn.TextAlign = ContentAlignment.MiddleRight
        editarbtn.UseVisualStyleBackColor = False
        ' 
        ' eliminarbtn
        ' 
        eliminarbtn.BackColor = SystemColors.MenuHighlight
        eliminarbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        eliminarbtn.ForeColor = Color.White
        eliminarbtn.Image = My.Resources.Resources.eliminar_producto
        eliminarbtn.ImageAlign = ContentAlignment.MiddleLeft
        eliminarbtn.Location = New Point(581, 621)
        eliminarbtn.Name = "eliminarbtn"
        eliminarbtn.Size = New Size(116, 51)
        eliminarbtn.TabIndex = 28
        eliminarbtn.Text = "ELIMINAR"
        eliminarbtn.TextAlign = ContentAlignment.MiddleRight
        eliminarbtn.UseVisualStyleBackColor = False
        ' 
        ' txtbuscar
        ' 
        txtbuscar.BackColor = SystemColors.Menu
        txtbuscar.Location = New Point(314, 236)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(548, 23)
        txtbuscar.TabIndex = 30
        ' 
        ' buscarbtn
        ' 
        buscarbtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        buscarbtn.Location = New Point(868, 232)
        buscarbtn.Name = "buscarbtn"
        buscarbtn.Size = New Size(157, 29)
        buscarbtn.TabIndex = 31
        buscarbtn.Text = "Buscar"
        buscarbtn.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxcategorias
        ' 
        ComboBoxcategorias.FormattingEnabled = True
        ComboBoxcategorias.Location = New Point(421, 157)
        ComboBoxcategorias.Name = "ComboBoxcategorias"
        ComboBoxcategorias.Size = New Size(276, 23)
        ComboBoxcategorias.TabIndex = 33
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(421, 140)
        Label11.Name = "Label11"
        Label11.Size = New Size(86, 14)
        Label11.TabIndex = 32
        Label11.Text = "CATEGORIAS"
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(20, 237)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 23)
        Label12.TabIndex = 34
        Label12.Text = "Buscar por:"
        ' 
        ' ComboBoxbuscar
        ' 
        ComboBoxbuscar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBoxbuscar.FormattingEnabled = True
        ComboBoxbuscar.Location = New Point(113, 236)
        ComboBoxbuscar.Name = "ComboBoxbuscar"
        ComboBoxbuscar.Size = New Size(182, 25)
        ComboBoxbuscar.TabIndex = 35
        ComboBoxbuscar.Text = "Categoria"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(12, 67)
        Label13.Name = "Label13"
        Label13.Size = New Size(55, 14)
        Label13.TabIndex = 3
        Label13.Text = "CODIGO"
        ' 
        ' txtcodigo1
        ' 
        txtcodigo1.Location = New Point(12, 84)
        txtcodigo1.Name = "txtcodigo1"
        txtcodigo1.Size = New Size(75, 23)
        txtcodigo1.TabIndex = 4
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(104, 67)
        Label14.Name = "Label14"
        Label14.Size = New Size(157, 14)
        Label14.TabIndex = 5
        Label14.Text = "NOMBRE DEL PRODUCTO"
        ' 
        ' txtproducto1
        ' 
        txtproducto1.Location = New Point(104, 84)
        txtproducto1.Name = "txtproducto1"
        txtproducto1.Size = New Size(228, 23)
        txtproducto1.TabIndex = 6
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(366, 67)
        Label15.Name = "Label15"
        Label15.Size = New Size(53, 14)
        Label15.TabIndex = 9
        Label15.Text = "MARCA"
        ' 
        ' txtmarca1
        ' 
        txtmarca1.Location = New Point(366, 84)
        txtmarca1.Name = "txtmarca1"
        txtmarca1.Size = New Size(158, 23)
        txtmarca1.TabIndex = 10
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(213, 140)
        Label16.Name = "Label16"
        Label16.Size = New Size(82, 14)
        Label16.TabIndex = 19
        Label16.Text = "PROVEEDOR"
        ' 
        ' registraproducto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1050, 710)
        Controls.Add(ComboBoxbuscar)
        Controls.Add(Label12)
        Controls.Add(ComboBoxcategorias)
        Controls.Add(Label11)
        Controls.Add(buscarbtn)
        Controls.Add(txtbuscar)
        Controls.Add(eliminarbtn)
        Controls.Add(editarbtn)
        Controls.Add(agregarbtn)
        Controls.Add(tabladeproductos)
        Controls.Add(ComboBoxproveedores)
        Controls.Add(Label16)
        Controls.Add(Label10)
        Controls.Add(txtstock)
        Controls.Add(Label9)
        Controls.Add(txtprecioventa)
        Controls.Add(Label8)
        Controls.Add(txtpreciocompra)
        Controls.Add(Label7)
        Controls.Add(txtmodelo)
        Controls.Add(Label6)
        Controls.Add(txtmarca1)
        Controls.Add(txtmarca)
        Controls.Add(Label15)
        Controls.Add(Label5)
        Controls.Add(txtdescripcion)
        Controls.Add(Label4)
        Controls.Add(txtproducto1)
        Controls.Add(txtproducto)
        Controls.Add(Label14)
        Controls.Add(Label3)
        Controls.Add(txtcodigo1)
        Controls.Add(txtcodigo)
        Controls.Add(Label13)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "registraproducto"
        Text = "REGISTRAR PRODUCTOS"
        CType(tabladeproductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmodelo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtpreciocompra As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtprecioventa As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBoxproveedores As ComboBox
    Friend WithEvents tabladeproductos As DataGridView
    Friend WithEvents agregarbtn As Button
    Friend WithEvents editarbtn As Button
    Friend WithEvents eliminarbtn As Button
    Friend WithEvents ATRASBTN As Button
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents buscarbtn As Button
    Friend WithEvents ComboBoxcategorias As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBoxbuscar As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtcodigo1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtproducto1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtmarca1 As TextBox
    Friend WithEvents Label16 As Label
End Class
