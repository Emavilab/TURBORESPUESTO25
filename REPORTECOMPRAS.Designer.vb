<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTECOMPRAS
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
        btndescargar = New Button()
        tabladeventas = New DataGridView()
        DateTimePickerFIN = New DateTimePicker()
        Label3 = New Label()
        DateTimePickerINICIO = New DateTimePicker()
        Label1 = New Label()
        Label12 = New Label()
        txtbuscar = New TextBox()
        CType(tabladeventas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(191, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(582, 25)
        Label2.TabIndex = 32
        Label2.Text = "LISTA DE REPORTES DE COMPRAS TURBORESPUESTOS"
        ' 
        ' btndescargar
        ' 
        btndescargar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndescargar.Image = My.Resources.Resources.sobresalir
        btndescargar.ImageAlign = ContentAlignment.MiddleLeft
        btndescargar.Location = New Point(423, 604)
        btndescargar.Name = "btndescargar"
        btndescargar.Size = New Size(165, 49)
        btndescargar.TabIndex = 52
        btndescargar.Text = "Descargar Excel"
        btndescargar.UseVisualStyleBackColor = True
        ' 
        ' tabladeventas
        ' 
        tabladeventas.BackgroundColor = Color.White
        tabladeventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tabladeventas.Location = New Point(12, 189)
        tabladeventas.Name = "tabladeventas"
        tabladeventas.Size = New Size(991, 409)
        tabladeventas.TabIndex = 51
        ' 
        ' DateTimePickerFIN
        ' 
        DateTimePickerFIN.Location = New Point(446, 58)
        DateTimePickerFIN.Name = "DateTimePickerFIN"
        DateTimePickerFIN.Size = New Size(211, 23)
        DateTimePickerFIN.TabIndex = 50
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(354, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 23)
        Label3.TabIndex = 49
        Label3.Text = "Fecha Fin:"
        ' 
        ' DateTimePickerINICIO
        ' 
        DateTimePickerINICIO.Location = New Point(120, 59)
        DateTimePickerINICIO.Name = "DateTimePickerINICIO"
        DateTimePickerINICIO.Size = New Size(211, 23)
        DateTimePickerINICIO.TabIndex = 48
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 23)
        Label1.TabIndex = 47
        Label1.Text = "Fecha inicio:"
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(12, 135)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 23)
        Label12.TabIndex = 46
        Label12.Text = "Buscar por:"
        ' 
        ' txtbuscar
        ' 
        txtbuscar.BackColor = SystemColors.Menu
        txtbuscar.Location = New Point(106, 134)
        txtbuscar.Multiline = True
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(735, 23)
        txtbuscar.TabIndex = 45
        ' 
        ' REPORTECOMPRAS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
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
        Name = "REPORTECOMPRAS"
        Text = "REPORTECOMPRAS"
        CType(tabladeventas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btndescargar As Button
    Friend WithEvents tabladeventas As DataGridView
    Friend WithEvents DateTimePickerFIN As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickerINICIO As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbuscar As TextBox
End Class
