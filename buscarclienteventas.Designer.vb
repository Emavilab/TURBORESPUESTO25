<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscarclienteventas
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
        txtbuscarpro = New TextBox()
        Label2 = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        CType(tabladeproveedores, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabladeproveedores
        ' 
        tabladeproveedores.AllowUserToAddRows = False
        tabladeproveedores.BackgroundColor = Color.White
        tabladeproveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabladeproveedores.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        tabladeproveedores.Location = New Point(12, 132)
        tabladeproveedores.Name = "tabladeproveedores"
        tabladeproveedores.ReadOnly = True
        tabladeproveedores.Size = New Size(473, 178)
        tabladeproveedores.TabIndex = 25
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(btnbuscardetallecompra)
        Panel1.Controls.Add(txtbuscarpro)
        Panel1.Location = New Point(12, 46)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(473, 66)
        Panel1.TabIndex = 24
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(214, 25)
        Label2.TabIndex = 23
        Label2.Text = "LISTA DE CLIENTES"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Nombre cliente"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "DNI"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' buscarclienteventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(494, 324)
        Controls.Add(tabladeproveedores)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Name = "buscarclienteventas"
        Text = "buscarclienteventas"
        CType(tabladeproveedores, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tabladeproveedores As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnbuscardetallecompra As Button
    Friend WithEvents txtbuscarpro As TextBox
    Friend WithEvents Label2 As Label
End Class
