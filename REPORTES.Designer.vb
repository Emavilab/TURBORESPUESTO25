<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTESVENTAS
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
        Label12 = New Label()
        txtbuscar = New TextBox()
        Label1 = New Label()
        DateTimePickerINICIO = New DateTimePicker()
        DateTimePickerFIN = New DateTimePicker()
        Label3 = New Label()
        tabladeventas = New DataGridView()
        btndescargar = New Button()
        CType(tabladeventas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(192, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(563, 25)
        Label2.TabIndex = 31
        Label2.Text = "LISTA DE REPORTES DE VENTAS TURBORESPUESTOS"
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(12, 141)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 23)
        Label12.TabIndex = 37
        Label12.Text = "Buscar por:"
        ' 
        ' txtbuscar
        ' 
        txtbuscar.BackColor = SystemColors.Menu
        txtbuscar.Location = New Point(106, 140)
        txtbuscar.Multiline = True
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(735, 23)
        txtbuscar.TabIndex = 35
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 23)
        Label1.TabIndex = 38
        Label1.Text = "Fecha inicio:"
        ' 
        ' DateTimePickerINICIO
        ' 
        DateTimePickerINICIO.Location = New Point(120, 65)
        DateTimePickerINICIO.Name = "DateTimePickerINICIO"
        DateTimePickerINICIO.Size = New Size(211, 23)
        DateTimePickerINICIO.TabIndex = 39
        ' 
        ' DateTimePickerFIN
        ' 
        DateTimePickerFIN.Location = New Point(446, 64)
        DateTimePickerFIN.Name = "DateTimePickerFIN"
        DateTimePickerFIN.Size = New Size(211, 23)
        DateTimePickerFIN.TabIndex = 41
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(354, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 23)
        Label3.TabIndex = 40
        Label3.Text = "Fecha Fin:"
        ' 
        ' tabladeventas
        ' 
        tabladeventas.BackgroundColor = Color.White
        tabladeventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabladeventas.Location = New Point(12, 195)
        tabladeventas.Name = "tabladeventas"
        tabladeventas.Size = New Size(991, 409)
        tabladeventas.TabIndex = 43
        ' 
        ' btndescargar
        ' 
        btndescargar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndescargar.Image = My.Resources.Resources.sobresalir
        btndescargar.ImageAlign = ContentAlignment.MiddleLeft
        btndescargar.Location = New Point(423, 610)
        btndescargar.Name = "btndescargar"
        btndescargar.Size = New Size(165, 49)
        btndescargar.TabIndex = 44
        btndescargar.Text = "Descargar Excel"
        btndescargar.UseVisualStyleBackColor = True
        ' 
        ' REPORTESVENTAS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1015, 710)
        Controls.Add(btndescargar)
        Controls.Add(tabladeventas)
        Controls.Add(DateTimePickerFIN)
        Controls.Add(Label3)
        Controls.Add(DateTimePickerINICIO)
        Controls.Add(Label1)
        Controls.Add(Label12)
        Controls.Add(txtbuscar)
        Controls.Add(Label2)
        Name = "REPORTESVENTAS"
        Text = "REPORTESDEVENTAS"
        CType(tabladeventas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePickerINICIO As DateTimePicker
    Friend WithEvents DateTimePickerFIN As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents tabladeventas As DataGridView
    Friend WithEvents btndescargar As Button
End Class
