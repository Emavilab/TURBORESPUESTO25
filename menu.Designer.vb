<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Button1 = New Button()
        REGISTARPRO = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(50, 48)
        Button1.Name = "Button1"
        Button1.Size = New Size(159, 107)
        Button1.TabIndex = 0
        Button1.Text = "REGISTRAR PRODUCTO"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' REGISTARPRO
        ' 
        REGISTARPRO.Location = New Point(285, 48)
        REGISTARPRO.Name = "REGISTARPRO"
        REGISTARPRO.Size = New Size(159, 107)
        REGISTARPRO.TabIndex = 1
        REGISTARPRO.Text = "REGISTRAR PROVEEDORES"
        REGISTARPRO.UseVisualStyleBackColor = True
        ' 
        ' menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(REGISTARPRO)
        Controls.Add(Button1)
        Name = "menu"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents REGISTARPRO As Button
End Class
