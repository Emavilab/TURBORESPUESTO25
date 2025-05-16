<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proveedores
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
        txtUBICACION = New TextBox()
        Label6 = New Label()
        txtEMAILPRO = New TextBox()
        Label5 = New Label()
        txtTELEFONOPRO = New TextBox()
        Label3 = New Label()
        txtNOMBREPRO = New TextBox()
        Label1 = New Label()
        tabladeproveedores = New DataGridView()
        eliminarprobtn = New Button()
        editarprobtn = New Button()
        agregarprobtn = New Button()
        btnbuscarpro = New Button()
        txtbuscarpro = New TextBox()
        CType(tabladeproveedores, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(244, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(544, 25)
        Label2.TabIndex = 3
        Label2.Text = "REGISTROS DE PROVEEDORES TURBORESPUESTOS"
        ' 
        ' txtUBICACION
        ' 
        txtUBICACION.Location = New Point(99, 140)
        txtUBICACION.Multiline = True
        txtUBICACION.Name = "txtUBICACION"
        txtUBICACION.Size = New Size(250, 47)
        txtUBICACION.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(99, 123)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 14)
        Label6.TabIndex = 19
        Label6.Text = "UBICACION"
        ' 
        ' txtEMAILPRO
        ' 
        txtEMAILPRO.Location = New Point(656, 82)
        txtEMAILPRO.Name = "txtEMAILPRO"
        txtEMAILPRO.Size = New Size(205, 23)
        txtEMAILPRO.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(656, 65)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 14)
        Label5.TabIndex = 17
        Label5.Text = "EMAIL"
        ' 
        ' txtTELEFONOPRO
        ' 
        txtTELEFONOPRO.Location = New Point(390, 82)
        txtTELEFONOPRO.Name = "txtTELEFONOPRO"
        txtTELEFONOPRO.Size = New Size(228, 23)
        txtTELEFONOPRO.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(390, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 14)
        Label3.TabIndex = 15
        Label3.Text = "TELEFONO"
        ' 
        ' txtNOMBREPRO
        ' 
        txtNOMBREPRO.Location = New Point(99, 82)
        txtNOMBREPRO.Name = "txtNOMBREPRO"
        txtNOMBREPRO.Size = New Size(250, 23)
        txtNOMBREPRO.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(99, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 14)
        Label1.TabIndex = 13
        Label1.Text = "NOMBRE PROVEEDOR"
        ' 
        ' tabladeproveedores
        ' 
        tabladeproveedores.BackgroundColor = Color.White
        tabladeproveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabladeproveedores.Location = New Point(99, 309)
        tabladeproveedores.Name = "tabladeproveedores"
        tabladeproveedores.Size = New Size(776, 202)
        tabladeproveedores.TabIndex = 21
        ' 
        ' eliminarprobtn
        ' 
        eliminarprobtn.BackColor = SystemColors.MenuHighlight
        eliminarprobtn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        eliminarprobtn.ForeColor = Color.White
        eliminarprobtn.Image = My.Resources.Resources.eliminar_producto
        eliminarprobtn.ImageAlign = ContentAlignment.MiddleLeft
        eliminarprobtn.Location = New Point(554, 544)
        eliminarprobtn.Name = "eliminarprobtn"
        eliminarprobtn.Size = New Size(116, 51)
        eliminarprobtn.TabIndex = 32
        eliminarprobtn.Text = "ELIMINAR"
        eliminarprobtn.TextAlign = ContentAlignment.MiddleRight
        eliminarprobtn.UseVisualStyleBackColor = False
        ' 
        ' editarprobtn
        ' 
        editarprobtn.BackColor = SystemColors.MenuHighlight
        editarprobtn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        editarprobtn.ForeColor = Color.White
        editarprobtn.Image = My.Resources.Resources.productos_cosmeticos
        editarprobtn.ImageAlign = ContentAlignment.MiddleLeft
        editarprobtn.Location = New Point(418, 544)
        editarprobtn.Name = "editarprobtn"
        editarprobtn.Size = New Size(116, 51)
        editarprobtn.TabIndex = 31
        editarprobtn.Text = "EDITAR"
        editarprobtn.TextAlign = ContentAlignment.MiddleRight
        editarprobtn.UseVisualStyleBackColor = False
        ' 
        ' agregarprobtn
        ' 
        agregarprobtn.BackColor = SystemColors.MenuHighlight
        agregarprobtn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        agregarprobtn.ForeColor = Color.White
        agregarprobtn.Image = My.Resources.Resources.anadir_al_carrito
        agregarprobtn.ImageAlign = ContentAlignment.MiddleLeft
        agregarprobtn.Location = New Point(287, 544)
        agregarprobtn.Name = "agregarprobtn"
        agregarprobtn.Size = New Size(116, 51)
        agregarprobtn.TabIndex = 30
        agregarprobtn.Text = "AGREGAR"
        agregarprobtn.TextAlign = ContentAlignment.MiddleRight
        agregarprobtn.UseVisualStyleBackColor = False
        ' 
        ' btnbuscarpro
        ' 
        btnbuscarpro.Location = New Point(786, 265)
        btnbuscarpro.Name = "btnbuscarpro"
        btnbuscarpro.Size = New Size(75, 28)
        btnbuscarpro.TabIndex = 34
        btnbuscarpro.Text = "Buscar"
        btnbuscarpro.UseVisualStyleBackColor = True
        ' 
        ' txtbuscarpro
        ' 
        txtbuscarpro.Location = New Point(105, 270)
        txtbuscarpro.Name = "txtbuscarpro"
        txtbuscarpro.Size = New Size(675, 23)
        txtbuscarpro.TabIndex = 35
        ' 
        ' proveedores
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1015, 710)
        Controls.Add(txtbuscarpro)
        Controls.Add(btnbuscarpro)
        Controls.Add(eliminarprobtn)
        Controls.Add(editarprobtn)
        Controls.Add(agregarprobtn)
        Controls.Add(tabladeproveedores)
        Controls.Add(txtUBICACION)
        Controls.Add(Label6)
        Controls.Add(txtEMAILPRO)
        Controls.Add(Label5)
        Controls.Add(txtTELEFONOPRO)
        Controls.Add(Label3)
        Controls.Add(txtNOMBREPRO)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "proveedores"
        Text = "proveedores"
        CType(tabladeproveedores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtUBICACION As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEMAILPRO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTELEFONOPRO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNOMBREPRO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tabladeproveedores As DataGridView
    Friend WithEvents eliminarprobtn As Button
    Friend WithEvents editarprobtn As Button
    Friend WithEvents agregarprobtn As Button
    Friend WithEvents btnbuscarpro As Button
    Friend WithEvents txtbuscarpro As TextBox
End Class
