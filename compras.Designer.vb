<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class compras
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
        GroupBox1 = New GroupBox()
        txtFECHA = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        btnbuscarpro = New Button()
        txttelefonopro = New TextBox()
        Label4 = New Label()
        txtnombrepro = New TextBox()
        Label3 = New Label()
        GroupBox3 = New GroupBox()
        NumericUpDowncantiddad = New NumericUpDown()
        Label9 = New Label()
        txtprecioven = New TextBox()
        Label8 = New Label()
        txtpreciocom = New TextBox()
        Label7 = New Label()
        btnbuscarproducto = New Button()
        txtnombreproducto = New TextBox()
        Label5 = New Label()
        txtcodigoproducto = New TextBox()
        Label6 = New Label()
        btnagergartabla = New Button()
        tabladecompras = New DataGridView()
        id_producto = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Eliminar = New DataGridViewTextBoxColumn()
        txttotal = New TextBox()
        Label10 = New Label()
        btnregistrar = New Button()
        btnverdetalle = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(NumericUpDowncantiddad, ComponentModel.ISupportInitialize).BeginInit()
        CType(tabladecompras, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(249, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(490, 25)
        Label2.TabIndex = 4
        Label2.Text = "REGISTROS DE COMPRAS TURBORESPUESTOS"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtFECHA)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(370, 83)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informacion de compra"
        ' 
        ' txtFECHA
        ' 
        txtFECHA.Location = New Point(6, 36)
        txtFECHA.Name = "txtFECHA"
        txtFECHA.Size = New Size(100, 23)
        txtFECHA.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 14)
        Label1.TabIndex = 15
        Label1.Text = "Fecha:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnbuscarpro)
        GroupBox2.Controls.Add(txttelefonopro)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txtnombrepro)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(441, 41)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(529, 83)
        GroupBox2.TabIndex = 17
        GroupBox2.TabStop = False
        GroupBox2.Text = "Informacion de Proveedor"
        ' 
        ' btnbuscarpro
        ' 
        btnbuscarpro.Image = My.Resources.Resources.lupa
        btnbuscarpro.Location = New Point(219, 22)
        btnbuscarpro.Name = "btnbuscarpro"
        btnbuscarpro.Size = New Size(87, 36)
        btnbuscarpro.TabIndex = 19
        btnbuscarpro.UseVisualStyleBackColor = True
        ' 
        ' txttelefonopro
        ' 
        txttelefonopro.Location = New Point(312, 36)
        txttelefonopro.Name = "txttelefonopro"
        txttelefonopro.Size = New Size(207, 23)
        txttelefonopro.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(312, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 14)
        Label4.TabIndex = 17
        Label4.Text = "Telefono:"
        ' 
        ' txtnombrepro
        ' 
        txtnombrepro.Location = New Point(6, 36)
        txtnombrepro.Name = "txtnombrepro"
        txtnombrepro.Size = New Size(207, 23)
        txtnombrepro.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(6, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 14)
        Label3.TabIndex = 15
        Label3.Text = "Nombre:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(NumericUpDowncantiddad)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(txtprecioven)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(txtpreciocom)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(btnbuscarproducto)
        GroupBox3.Controls.Add(txtnombreproducto)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(txtcodigoproducto)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Location = New Point(12, 139)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(893, 83)
        GroupBox3.TabIndex = 20
        GroupBox3.TabStop = False
        GroupBox3.Text = "Informacion del Producto"
        ' 
        ' NumericUpDowncantiddad
        ' 
        NumericUpDowncantiddad.Location = New Point(770, 36)
        NumericUpDowncantiddad.Name = "NumericUpDowncantiddad"
        NumericUpDowncantiddad.Size = New Size(101, 23)
        NumericUpDowncantiddad.TabIndex = 26
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(770, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(62, 14)
        Label9.TabIndex = 24
        Label9.Text = "Cantidad"
        ' 
        ' txtprecioven
        ' 
        txtprecioven.Location = New Point(657, 36)
        txtprecioven.Name = "txtprecioven"
        txtprecioven.Size = New Size(97, 23)
        txtprecioven.TabIndex = 23
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(657, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 14)
        Label8.TabIndex = 22
        Label8.Text = "Precio Venta:"
        ' 
        ' txtpreciocom
        ' 
        txtpreciocom.Location = New Point(545, 35)
        txtpreciocom.Multiline = True
        txtpreciocom.Name = "txtpreciocom"
        txtpreciocom.Size = New Size(97, 23)
        txtpreciocom.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(545, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 14)
        Label7.TabIndex = 20
        Label7.Text = "Precio Compra:"
        ' 
        ' btnbuscarproducto
        ' 
        btnbuscarproducto.Image = My.Resources.Resources.lupa
        btnbuscarproducto.Location = New Point(219, 22)
        btnbuscarproducto.Name = "btnbuscarproducto"
        btnbuscarproducto.Size = New Size(87, 36)
        btnbuscarproducto.TabIndex = 19
        btnbuscarproducto.UseVisualStyleBackColor = True
        ' 
        ' txtnombreproducto
        ' 
        txtnombreproducto.Location = New Point(312, 36)
        txtnombreproducto.Name = "txtnombreproducto"
        txtnombreproducto.Size = New Size(207, 23)
        txtnombreproducto.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(312, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 14)
        Label5.TabIndex = 17
        Label5.Text = "Producto:"
        ' 
        ' txtcodigoproducto
        ' 
        txtcodigoproducto.Location = New Point(6, 36)
        txtcodigoproducto.Name = "txtcodigoproducto"
        txtcodigoproducto.Size = New Size(207, 23)
        txtcodigoproducto.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(6, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 14)
        Label6.TabIndex = 15
        Label6.Text = "Codigo.Producto:"
        ' 
        ' btnagergartabla
        ' 
        btnagergartabla.Image = My.Resources.Resources.boton_mas
        btnagergartabla.Location = New Point(916, 146)
        btnagergartabla.Name = "btnagergartabla"
        btnagergartabla.Size = New Size(87, 76)
        btnagergartabla.TabIndex = 20
        btnagergartabla.UseVisualStyleBackColor = True
        ' 
        ' tabladecompras
        ' 
        tabladecompras.BackgroundColor = Color.White
        tabladecompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabladecompras.Columns.AddRange(New DataGridViewColumn() {id_producto, Column1, Column2, Column3, Column4, Eliminar})
        tabladecompras.Location = New Point(12, 228)
        tabladecompras.Name = "tabladecompras"
        tabladecompras.Size = New Size(887, 381)
        tabladecompras.TabIndex = 21
        ' 
        ' id_producto
        ' 
        id_producto.HeaderText = "id_producto"
        id_producto.Name = "id_producto"
        id_producto.Visible = False
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Producto"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Precio compra"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Cantidad"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Sub Total"
        Column4.Name = "Column4"
        ' 
        ' Eliminar
        ' 
        Eliminar.HeaderText = "Eliminar"
        Eliminar.Name = "Eliminar"
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(906, 532)
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(97, 23)
        txttotal.TabIndex = 28
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(906, 515)
        Label10.Name = "Label10"
        Label10.Size = New Size(92, 14)
        Label10.TabIndex = 27
        Label10.Text = "Total a pagar:"
        ' 
        ' btnregistrar
        ' 
        btnregistrar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnregistrar.Image = My.Resources.Resources.etiqueta_de_precio1
        btnregistrar.ImageAlign = ContentAlignment.TopCenter
        btnregistrar.Location = New Point(906, 561)
        btnregistrar.Name = "btnregistrar"
        btnregistrar.Size = New Size(97, 48)
        btnregistrar.TabIndex = 27
        btnregistrar.Text = "Registrar"
        btnregistrar.TextAlign = ContentAlignment.BottomCenter
        btnregistrar.UseVisualStyleBackColor = True
        ' 
        ' btnverdetalle
        ' 
        btnverdetalle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnverdetalle.Image = My.Resources.Resources.etiqueta_de_precio1
        btnverdetalle.ImageAlign = ContentAlignment.TopCenter
        btnverdetalle.Location = New Point(12, 615)
        btnverdetalle.Name = "btnverdetalle"
        btnverdetalle.Size = New Size(97, 48)
        btnverdetalle.TabIndex = 29
        btnverdetalle.Text = "Ver detalles"
        btnverdetalle.TextAlign = ContentAlignment.BottomCenter
        btnverdetalle.UseVisualStyleBackColor = True
        ' 
        ' compras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1015, 710)
        Controls.Add(btnverdetalle)
        Controls.Add(btnregistrar)
        Controls.Add(txttotal)
        Controls.Add(Label10)
        Controls.Add(tabladecompras)
        Controls.Add(btnagergartabla)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Name = "compras"
        Text = "compras"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(NumericUpDowncantiddad, ComponentModel.ISupportInitialize).EndInit()
        CType(tabladecompras, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFECHA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtnombrepro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnbuscarpro As Button
    Friend WithEvents txttelefonopro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtprecioven As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtpreciocom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnbuscarproducto As Button
    Friend WithEvents txtnombreproducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcodigoproducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDowncantiddad As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents btnagergartabla As Button
    Friend WithEvents tabladecompras As DataGridView
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnregistrar As Button
    Friend WithEvents btnverdetalle As Button
    Friend WithEvents id_producto As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewTextBoxColumn
End Class
