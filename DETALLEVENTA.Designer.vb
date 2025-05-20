<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DETALLEVENTA
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
        btndescargar = New Button()
        txtmontototal = New TextBox()
        Label5 = New Label()
        tabladettalecompra = New DataGridView()
        GroupBox1 = New GroupBox()
        txtusuario = New TextBox()
        txtFECHA = New TextBox()
        Label11 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        txtdni = New TextBox()
        Label4 = New Label()
        txtnombrecliente = New TextBox()
        Label3 = New Label()
        btnbuscardetalleventa = New Button()
        txtbuscaridventa = New TextBox()
        Label10 = New Label()
        Label2 = New Label()
        txtmontopago = New TextBox()
        Label6 = New Label()
        txtmontocambio = New TextBox()
        Label7 = New Label()
        CType(tabladettalecompra, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btndescargar
        ' 
        btndescargar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndescargar.Image = My.Resources.Resources.archivo
        btndescargar.ImageAlign = ContentAlignment.MiddleLeft
        btndescargar.Location = New Point(532, 452)
        btndescargar.Name = "btndescargar"
        btndescargar.Size = New Size(234, 36)
        btndescargar.TabIndex = 36
        btndescargar.Text = "Descagar en PDF"
        btndescargar.UseVisualStyleBackColor = True
        ' 
        ' txtmontototal
        ' 
        txtmontototal.Location = New Point(49, 469)
        txtmontototal.Name = "txtmontototal"
        txtmontototal.Size = New Size(117, 23)
        txtmontototal.TabIndex = 33
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(49, 452)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 14)
        Label5.TabIndex = 31
        Label5.Text = "Monto Total:"
        ' 
        ' tabladettalecompra
        ' 
        tabladettalecompra.BackgroundColor = Color.White
        tabladettalecompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabladettalecompra.Location = New Point(47, 265)
        tabladettalecompra.Name = "tabladettalecompra"
        tabladettalecompra.Size = New Size(719, 161)
        tabladettalecompra.TabIndex = 35
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtusuario)
        GroupBox1.Controls.Add(txtFECHA)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(47, 66)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(719, 83)
        GroupBox1.TabIndex = 34
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informacion de compra"
        ' 
        ' txtusuario
        ' 
        txtusuario.Location = New Point(235, 36)
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(207, 23)
        txtusuario.TabIndex = 21
        ' 
        ' txtFECHA
        ' 
        txtFECHA.Location = New Point(6, 36)
        txtFECHA.Name = "txtFECHA"
        txtFECHA.Size = New Size(100, 23)
        txtFECHA.TabIndex = 16
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(235, 19)
        Label11.Name = "Label11"
        Label11.Size = New Size(56, 14)
        Label11.TabIndex = 20
        Label11.Text = "Usuario:"
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
        GroupBox2.Controls.Add(txtdni)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txtnombrecliente)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(47, 164)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(497, 83)
        GroupBox2.TabIndex = 32
        GroupBox2.TabStop = False
        GroupBox2.Text = "Informacion de Cliente"
        ' 
        ' txtdni
        ' 
        txtdni.Location = New Point(257, 36)
        txtdni.Name = "txtdni"
        txtdni.Size = New Size(207, 23)
        txtdni.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(257, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 14)
        Label4.TabIndex = 17
        Label4.Text = "Dni:"
        ' 
        ' txtnombrecliente
        ' 
        txtnombrecliente.Location = New Point(6, 36)
        txtnombrecliente.Name = "txtnombrecliente"
        txtnombrecliente.Size = New Size(207, 23)
        txtnombrecliente.TabIndex = 16
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
        ' btnbuscardetalleventa
        ' 
        btnbuscardetalleventa.Image = My.Resources.Resources.lupa
        btnbuscardetalleventa.Location = New Point(679, 18)
        btnbuscardetalleventa.Name = "btnbuscardetalleventa"
        btnbuscardetalleventa.Size = New Size(87, 36)
        btnbuscardetalleventa.TabIndex = 28
        btnbuscardetalleventa.UseVisualStyleBackColor = True
        ' 
        ' txtbuscaridventa
        ' 
        txtbuscaridventa.Location = New Point(466, 26)
        txtbuscaridventa.Name = "txtbuscaridventa"
        txtbuscaridventa.Size = New Size(207, 23)
        txtbuscaridventa.TabIndex = 30
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(323, 29)
        Label10.Name = "Label10"
        Label10.Size = New Size(127, 14)
        Label10.TabIndex = 29
        Label10.Text = "Buscar por N.venta:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(58, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 25)
        Label2.TabIndex = 27
        Label2.Text = "DETALLE VENTA"
        ' 
        ' txtmontopago
        ' 
        txtmontopago.Location = New Point(207, 469)
        txtmontopago.Name = "txtmontopago"
        txtmontopago.Size = New Size(117, 23)
        txtmontopago.TabIndex = 38
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(207, 452)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 14)
        Label6.TabIndex = 37
        Label6.Text = "Monto Pago:"
        ' 
        ' txtmontocambio
        ' 
        txtmontocambio.Location = New Point(355, 469)
        txtmontocambio.Name = "txtmontocambio"
        txtmontocambio.Size = New Size(117, 23)
        txtmontocambio.TabIndex = 40
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(355, 452)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 14)
        Label7.TabIndex = 39
        Label7.Text = "Monto Cambio:"
        ' 
        ' DETALLEVENTA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(811, 532)
        Controls.Add(txtmontocambio)
        Controls.Add(Label7)
        Controls.Add(txtmontopago)
        Controls.Add(Label6)
        Controls.Add(btndescargar)
        Controls.Add(txtmontototal)
        Controls.Add(Label5)
        Controls.Add(tabladettalecompra)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(btnbuscardetalleventa)
        Controls.Add(txtbuscaridventa)
        Controls.Add(Label10)
        Controls.Add(Label2)
        Name = "DETALLEVENTA"
        Text = "DETALLEVENTA"
        CType(tabladettalecompra, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btndescargar As Button
    Friend WithEvents txtmontototal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tabladettalecompra As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtFECHA As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnombrecliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnbuscardetalleventa As Button
    Friend WithEvents txtbuscaridventa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmontopago As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtmontocambio As TextBox
    Friend WithEvents Label7 As Label
End Class
