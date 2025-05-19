<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscarproveedorcompra
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
        Panel1 = New Panel()
        btnbuscardetallecompra = New Button()
        txtbuscarpro = New TextBox()
        tabladeproveedores = New DataGridView()
        Panel1.SuspendLayout()
        CType(tabladeproveedores, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(268, 25)
        Label2.TabIndex = 6
        Label2.Text = "LISTA DE PROVEEDORES"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(btnbuscardetallecompra)
        Panel1.Controls.Add(txtbuscarpro)
        Panel1.Location = New Point(12, 46)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(473, 66)
        Panel1.TabIndex = 7
        ' 
        ' btnbuscardetallecompra
        ' 
        btnbuscardetallecompra.Image = My.Resources.Resources.lupa
        btnbuscardetallecompra.Location = New Point(356, 19)
        btnbuscardetallecompra.Name = "btnbuscardetallecompra"
        btnbuscardetallecompra.Size = New Size(87, 36)
        btnbuscardetallecompra.TabIndex = 38
        btnbuscardetallecompra.UseVisualStyleBackColor = True
        ' 
        ' txtbuscarpro
        ' 
        txtbuscarpro.Location = New Point(14, 32)
        txtbuscarpro.Name = "txtbuscarpro"
        txtbuscarpro.Size = New Size(336, 23)
        txtbuscarpro.TabIndex = 37
        ' 
        ' tabladeproveedores
        ' 
        tabladeproveedores.AllowUserToAddRows = False
        tabladeproveedores.BackgroundColor = Color.White
        tabladeproveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabladeproveedores.Location = New Point(12, 132)
        tabladeproveedores.Name = "tabladeproveedores"
        tabladeproveedores.ReadOnly = True
        tabladeproveedores.Size = New Size(473, 178)
        tabladeproveedores.TabIndex = 22
        ' 
        ' buscarproveedorcompra
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(498, 363)
        Controls.Add(tabladeproveedores)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Name = "buscarproveedorcompra"
        RightToLeftLayout = True
        Text = "buscarproveedorcompra"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(tabladeproveedores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtbuscarpro As TextBox
    Friend WithEvents btnbuscardetallecompra As Button
    Friend WithEvents tabladeproveedores As DataGridView
End Class
