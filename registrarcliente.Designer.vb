<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrarcliente
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
        txtbuscarpro = New TextBox()
        btnbuscarpro = New Button()
        eliminarprobtn = New Button()
        editarprobtn = New Button()
        agregarprobtn = New Button()
        tabladeclientes = New DataGridView()
        txtUBICACION = New TextBox()
        Label6 = New Label()
        txtEMAILPRO = New TextBox()
        Label5 = New Label()
        txtTELEFONOPRO = New TextBox()
        Label3 = New Label()
        txtNOMBREPRO = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtdni = New TextBox()
        Label4 = New Label()
        ComboBoxTIPOCLIENTE = New ComboBox()
        Label7 = New Label()
        CType(tabladeclientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtbuscarpro
        ' 
        txtbuscarpro.Location = New Point(68, 289)
        txtbuscarpro.Name = "txtbuscarpro"
        txtbuscarpro.Size = New Size(675, 23)
        txtbuscarpro.TabIndex = 50
        ' 
        ' btnbuscarpro
        ' 
        btnbuscarpro.Location = New Point(749, 284)
        btnbuscarpro.Name = "btnbuscarpro"
        btnbuscarpro.Size = New Size(75, 28)
        btnbuscarpro.TabIndex = 49
        btnbuscarpro.Text = "Buscar"
        btnbuscarpro.UseVisualStyleBackColor = True
        ' 
        ' eliminarprobtn
        ' 
        eliminarprobtn.BackColor = SystemColors.MenuHighlight
        eliminarprobtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        eliminarprobtn.ForeColor = Color.White
        eliminarprobtn.Image = My.Resources.Resources.eliminar_producto
        eliminarprobtn.ImageAlign = ContentAlignment.MiddleLeft
        eliminarprobtn.Location = New Point(517, 563)
        eliminarprobtn.Name = "eliminarprobtn"
        eliminarprobtn.Size = New Size(116, 51)
        eliminarprobtn.TabIndex = 48
        eliminarprobtn.Text = "ELIMINAR"
        eliminarprobtn.TextAlign = ContentAlignment.MiddleRight
        eliminarprobtn.UseVisualStyleBackColor = False
        ' 
        ' editarprobtn
        ' 
        editarprobtn.BackColor = SystemColors.MenuHighlight
        editarprobtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        editarprobtn.ForeColor = Color.White
        editarprobtn.Image = My.Resources.Resources.productos_cosmeticos
        editarprobtn.ImageAlign = ContentAlignment.MiddleLeft
        editarprobtn.Location = New Point(381, 563)
        editarprobtn.Name = "editarprobtn"
        editarprobtn.Size = New Size(116, 51)
        editarprobtn.TabIndex = 47
        editarprobtn.Text = "EDITAR"
        editarprobtn.TextAlign = ContentAlignment.MiddleRight
        editarprobtn.UseVisualStyleBackColor = False
        ' 
        ' agregarprobtn
        ' 
        agregarprobtn.BackColor = SystemColors.MenuHighlight
        agregarprobtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        agregarprobtn.ForeColor = Color.White
        agregarprobtn.Image = My.Resources.Resources.anadir_al_carrito
        agregarprobtn.ImageAlign = ContentAlignment.MiddleLeft
        agregarprobtn.Location = New Point(250, 563)
        agregarprobtn.Name = "agregarprobtn"
        agregarprobtn.Size = New Size(116, 51)
        agregarprobtn.TabIndex = 46
        agregarprobtn.Text = "AGREGAR"
        agregarprobtn.TextAlign = ContentAlignment.MiddleRight
        agregarprobtn.UseVisualStyleBackColor = False
        ' 
        ' tabladeclientes
        ' 
        tabladeclientes.BackgroundColor = Color.White
        tabladeclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabladeclientes.Location = New Point(62, 328)
        tabladeclientes.Name = "tabladeclientes"
        tabladeclientes.Size = New Size(776, 202)
        tabladeclientes.TabIndex = 45
        ' 
        ' txtUBICACION
        ' 
        txtUBICACION.Location = New Point(353, 161)
        txtUBICACION.Multiline = True
        txtUBICACION.Name = "txtUBICACION"
        txtUBICACION.Size = New Size(250, 47)
        txtUBICACION.TabIndex = 44
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(353, 144)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 14)
        Label6.TabIndex = 43
        Label6.Text = "UBICACION"
        ' 
        ' txtEMAILPRO
        ' 
        txtEMAILPRO.Location = New Point(619, 101)
        txtEMAILPRO.Name = "txtEMAILPRO"
        txtEMAILPRO.Size = New Size(205, 23)
        txtEMAILPRO.TabIndex = 42
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(619, 84)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 14)
        Label5.TabIndex = 41
        Label5.Text = "EMAIL"
        ' 
        ' txtTELEFONOPRO
        ' 
        txtTELEFONOPRO.Location = New Point(353, 101)
        txtTELEFONOPRO.Name = "txtTELEFONOPRO"
        txtTELEFONOPRO.Size = New Size(228, 23)
        txtTELEFONOPRO.TabIndex = 40
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(353, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 14)
        Label3.TabIndex = 39
        Label3.Text = "TELEFONO"
        ' 
        ' txtNOMBREPRO
        ' 
        txtNOMBREPRO.Location = New Point(62, 101)
        txtNOMBREPRO.Name = "txtNOMBREPRO"
        txtNOMBREPRO.Size = New Size(250, 23)
        txtNOMBREPRO.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(62, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 14)
        Label1.TabIndex = 37
        Label1.Text = "NOMBRE CLIENTE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(207, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(490, 25)
        Label2.TabIndex = 36
        Label2.Text = "REGISTROS DE CLIENTES TURBORESPUESTOS"
        ' 
        ' txtdni
        ' 
        txtdni.Location = New Point(62, 161)
        txtdni.Name = "txtdni"
        txtdni.Size = New Size(228, 23)
        txtdni.TabIndex = 52
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(62, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 14)
        Label4.TabIndex = 51
        Label4.Text = "DNI"
        ' 
        ' ComboBoxTIPOCLIENTE
        ' 
        ComboBoxTIPOCLIENTE.FormattingEnabled = True
        ComboBoxTIPOCLIENTE.Location = New Point(619, 161)
        ComboBoxTIPOCLIENTE.Name = "ComboBoxTIPOCLIENTE"
        ComboBoxTIPOCLIENTE.Size = New Size(202, 23)
        ComboBoxTIPOCLIENTE.TabIndex = 53
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(619, 144)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 14)
        Label7.TabIndex = 54
        Label7.Text = "TIPO CLIENTE"
        ' 
        ' registrarcliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1015, 710)
        Controls.Add(Label7)
        Controls.Add(ComboBoxTIPOCLIENTE)
        Controls.Add(txtdni)
        Controls.Add(Label4)
        Controls.Add(txtbuscarpro)
        Controls.Add(btnbuscarpro)
        Controls.Add(eliminarprobtn)
        Controls.Add(editarprobtn)
        Controls.Add(agregarprobtn)
        Controls.Add(tabladeclientes)
        Controls.Add(txtUBICACION)
        Controls.Add(Label6)
        Controls.Add(txtEMAILPRO)
        Controls.Add(Label5)
        Controls.Add(txtTELEFONOPRO)
        Controls.Add(Label3)
        Controls.Add(txtNOMBREPRO)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "registrarcliente"
        Text = "registrarcliente"
        CType(tabladeclientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtbuscarpro As TextBox
    Friend WithEvents btnbuscarpro As Button
    Friend WithEvents eliminarprobtn As Button
    Friend WithEvents editarprobtn As Button
    Friend WithEvents agregarprobtn As Button
    Friend WithEvents tabladeclientes As DataGridView
    Friend WithEvents txtUBICACION As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEMAILPRO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTELEFONOPRO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNOMBREPRO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdni As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxTIPOCLIENTE As ComboBox
    Friend WithEvents Label7 As Label
End Class
