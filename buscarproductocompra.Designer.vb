<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscarproductocompra
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
        tabladeproveedores = New DataGridView()
        Panel1 = New Panel()
        btnbuscardetallecompra = New Button()
        Label12 = New Label()
        txtbuscar = New TextBox()
        ComboBoxbuscar = New ComboBox()
        Label2 = New Label()
        CType(tabladeproveedores, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabladeproveedores
        ' 
        tabladeproveedores.AllowUserToAddRows = False
        tabladeproveedores.BackgroundColor = Color.White
        tabladeproveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabladeproveedores.Location = New Point(12, 132)
        tabladeproveedores.Name = "tabladeproveedores"
        tabladeproveedores.ReadOnly = True
        tabladeproveedores.Size = New Size(662, 178)
        tabladeproveedores.TabIndex = 25
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(btnbuscardetallecompra)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(txtbuscar)
        Panel1.Controls.Add(ComboBoxbuscar)
        Panel1.Location = New Point(12, 46)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(662, 66)
        Panel1.TabIndex = 24
        ' 
        ' btnbuscardetallecompra
        ' 
        btnbuscardetallecompra.Image = My.Resources.Resources.lupa
        btnbuscardetallecompra.Location = New Point(559, 12)
        btnbuscardetallecompra.Name = "btnbuscardetallecompra"
        btnbuscardetallecompra.Size = New Size(87, 36)
        btnbuscardetallecompra.TabIndex = 38
        btnbuscardetallecompra.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(3, 18)
        Label12.Name = "Label12"
        Label12.Size = New Size(102, 23)
        Label12.TabIndex = 38
        Label12.Text = "Buscar por:"
        ' 
        ' txtbuscar
        ' 
        txtbuscar.BackColor = SystemColors.Menu
        txtbuscar.Location = New Point(318, 20)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(226, 23)
        txtbuscar.TabIndex = 36
        ' 
        ' ComboBoxbuscar
        ' 
        ComboBoxbuscar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBoxbuscar.FormattingEnabled = True
        ComboBoxbuscar.Location = New Point(101, 18)
        ComboBoxbuscar.Name = "ComboBoxbuscar"
        ComboBoxbuscar.Size = New Size(199, 25)
        ComboBoxbuscar.TabIndex = 39
        ComboBoxbuscar.Text = "Categoria"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(240, 25)
        Label2.TabIndex = 23
        Label2.Text = "LISTA DE PRODUCTOS"
        ' 
        ' buscarproductocompra
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(690, 333)
        Controls.Add(tabladeproveedores)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Name = "buscarproductocompra"
        Text = "buscarproductocompra"
        CType(tabladeproveedores, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tabladeproveedores As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnbuscardetallecompra As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBoxbuscar As ComboBox
    Friend WithEvents txtbuscar As TextBox
End Class
