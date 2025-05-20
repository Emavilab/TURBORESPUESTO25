<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detallecompra
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
        txtbuscaridcompra = New TextBox()
        Label10 = New Label()
        btnbuscardetallecompra = New Button()
        GroupBox2 = New GroupBox()
        txttelefonopro = New TextBox()
        Label4 = New Label()
        txtnombrepro = New TextBox()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        txtusuario = New TextBox()
        txtFECHA = New TextBox()
        Label11 = New Label()
        Label1 = New Label()
        tabladettalecompra = New DataGridView()
        txtmontototal = New TextBox()
        Label5 = New Label()
        btndescargar = New Button()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(tabladettalecompra, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(198, 25)
        Label2.TabIndex = 5
        Label2.Text = "DETALLE COMPRA"
        ' 
        ' txtbuscaridcompra
        ' 
        txtbuscaridcompra.Location = New Point(431, 17)
        txtbuscaridcompra.Name = "txtbuscaridcompra"
        txtbuscaridcompra.Size = New Size(207, 23)
        txtbuscaridcompra.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(288, 20)
        Label10.Name = "Label10"
        Label10.Size = New Size(137, 14)
        Label10.TabIndex = 20
        Label10.Text = "Buscar por N.compra:"
        ' 
        ' btnbuscardetallecompra
        ' 
        btnbuscardetallecompra.Image = My.Resources.Resources.lupa
        btnbuscardetallecompra.Location = New Point(644, 9)
        btnbuscardetallecompra.Name = "btnbuscardetallecompra"
        btnbuscardetallecompra.Size = New Size(87, 36)
        btnbuscardetallecompra.TabIndex = 20
        btnbuscardetallecompra.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txttelefonopro)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txtnombrepro)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(12, 155)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(497, 83)
        GroupBox2.TabIndex = 22
        GroupBox2.TabStop = False
        GroupBox2.Text = "Informacion de Proveedor"
        ' 
        ' txttelefonopro
        ' 
        txttelefonopro.Location = New Point(257, 36)
        txttelefonopro.Name = "txttelefonopro"
        txttelefonopro.Size = New Size(207, 23)
        txttelefonopro.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(257, 19)
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
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtusuario)
        GroupBox1.Controls.Add(txtFECHA)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 57)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(719, 83)
        GroupBox1.TabIndex = 24
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
        ' tabladettalecompra
        ' 
        tabladettalecompra.BackgroundColor = Color.White
        tabladettalecompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabladettalecompra.Location = New Point(12, 256)
        tabladettalecompra.Name = "tabladettalecompra"
        tabladettalecompra.Size = New Size(719, 161)
        tabladettalecompra.TabIndex = 25
        ' 
        ' txtmontototal
        ' 
        txtmontototal.Location = New Point(14, 460)
        txtmontototal.Name = "txtmontototal"
        txtmontototal.Size = New Size(117, 23)
        txtmontototal.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(14, 443)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 14)
        Label5.TabIndex = 22
        Label5.Text = "Monto Total:"
        ' 
        ' btndescargar
        ' 
        btndescargar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndescargar.Image = My.Resources.Resources.archivo
        btndescargar.ImageAlign = ContentAlignment.MiddleLeft
        btndescargar.Location = New Point(497, 443)
        btndescargar.Name = "btndescargar"
        btndescargar.Size = New Size(234, 36)
        btndescargar.TabIndex = 26
        btndescargar.Text = "Descagar en PDF"
        btndescargar.UseVisualStyleBackColor = True
        ' 
        ' detallecompra
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(749, 495)
        Controls.Add(btndescargar)
        Controls.Add(txtmontototal)
        Controls.Add(Label5)
        Controls.Add(tabladettalecompra)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(btnbuscardetallecompra)
        Controls.Add(txtbuscaridcompra)
        Controls.Add(Label10)
        Controls.Add(Label2)
        Name = "detallecompra"
        Text = "detallecompra"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(tabladettalecompra, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtbuscaridcompra As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnbuscardetallecompra As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txttelefonopro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnombrepro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtFECHA As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tabladettalecompra As DataGridView
    Friend WithEvents txtmontototal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btndescargar As Button
End Class
