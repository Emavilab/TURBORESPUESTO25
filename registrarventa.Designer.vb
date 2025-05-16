<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrarventa
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
        btnverdetalle = New Button()
        btnregistrar = New Button()
        txttotal = New TextBox()
        Label10 = New Label()
        tabladecompras = New DataGridView()
        btnagergartabla = New Button()
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
        GroupBox2 = New GroupBox()
        btnbuscarpro = New Button()
        txttelefonopro = New TextBox()
        Label4 = New Label()
        txtnombrepro = New TextBox()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        txtFECHA = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label11 = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        CType(tabladecompras, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(NumericUpDowncantiddad, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnverdetalle
        ' 
        btnverdetalle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnverdetalle.Image = My.Resources.Resources.etiqueta_de_precio1
        btnverdetalle.ImageAlign = ContentAlignment.TopCenter
        btnverdetalle.Location = New Point(13, 627)
        btnverdetalle.Name = "btnverdetalle"
        btnverdetalle.Size = New Size(97, 48)
        btnverdetalle.TabIndex = 39
        btnverdetalle.Text = "Ver detalles"
        btnverdetalle.TextAlign = ContentAlignment.BottomCenter
        btnverdetalle.UseVisualStyleBackColor = True
        ' 
        ' btnregistrar
        ' 
        btnregistrar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnregistrar.Image = My.Resources.Resources.etiqueta_de_precio1
        btnregistrar.ImageAlign = ContentAlignment.TopCenter
        btnregistrar.Location = New Point(907, 573)
        btnregistrar.Name = "btnregistrar"
        btnregistrar.Size = New Size(97, 48)
        btnregistrar.TabIndex = 36
        btnregistrar.Text = "Crear Venta"
        btnregistrar.TextAlign = ContentAlignment.BottomCenter
        btnregistrar.UseVisualStyleBackColor = True
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(907, 401)
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(97, 23)
        txttotal.TabIndex = 38
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(907, 384)
        Label10.Name = "Label10"
        Label10.Size = New Size(92, 14)
        Label10.TabIndex = 37
        Label10.Text = "Total a pagar:"
        ' 
        ' tabladecompras
        ' 
        tabladecompras.AllowUserToAddRows = False
        tabladecompras.BackgroundColor = Color.White
        tabladecompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabladecompras.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        tabladecompras.Location = New Point(13, 240)
        tabladecompras.Name = "tabladecompras"
        tabladecompras.ReadOnly = True
        tabladecompras.Size = New Size(887, 381)
        tabladecompras.TabIndex = 35
        ' 
        ' btnagergartabla
        ' 
        btnagergartabla.Image = My.Resources.Resources.boton_mas
        btnagergartabla.Location = New Point(917, 158)
        btnagergartabla.Name = "btnagergartabla"
        btnagergartabla.Size = New Size(87, 76)
        btnagergartabla.TabIndex = 33
        btnagergartabla.UseVisualStyleBackColor = True
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
        GroupBox3.Location = New Point(13, 151)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(893, 83)
        GroupBox3.TabIndex = 34
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
        Label8.Size = New Size(46, 14)
        Label8.TabIndex = 22
        Label8.Text = "Stock:"
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
        Label7.Size = New Size(87, 14)
        Label7.TabIndex = 20
        Label7.Text = "Precio venta:"
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
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnbuscarpro)
        GroupBox2.Controls.Add(txttelefonopro)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txtnombrepro)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(442, 53)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(529, 83)
        GroupBox2.TabIndex = 32
        GroupBox2.TabStop = False
        GroupBox2.Text = "Informacion de Cliente"
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
        Label4.Size = New Size(33, 14)
        Label4.TabIndex = 17
        Label4.Text = "DNI:"
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
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtFECHA)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(13, 53)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(370, 83)
        GroupBox1.TabIndex = 31
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informacion de venta"
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(243, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(471, 25)
        Label2.TabIndex = 30
        Label2.Text = "REGISTROS DE VENTAS TURBORESPUESTOS"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(906, 490)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(97, 23)
        TextBox1.TabIndex = 41
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(906, 473)
        Label11.Name = "Label11"
        Label11.Size = New Size(67, 14)
        Label11.TabIndex = 40
        Label11.Text = "paga con:"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Producto"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Precio venta"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Cantidad"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Sub Total"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' registrarventa
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1015, 710)
        Controls.Add(TextBox1)
        Controls.Add(Label11)
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
        Name = "registrarventa"
        Text = "registrarventa"
        CType(tabladecompras, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(NumericUpDowncantiddad, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnverdetalle As Button
    Friend WithEvents btnregistrar As Button
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tabladecompras As DataGridView
    Friend WithEvents btnagergartabla As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NumericUpDowncantiddad As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents txtprecioven As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtpreciocom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnbuscarproducto As Button
    Friend WithEvents txtnombreproducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcodigoproducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnbuscarpro As Button
    Friend WithEvents txttelefonopro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnombrepro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFECHA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label11 As Label
End Class
