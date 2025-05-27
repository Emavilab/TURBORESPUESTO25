<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtusuario = New TextBox()
        txtcontraseña = New TextBox()
        accederbtn = New Button()
        PictureBox2 = New PictureBox()
        salirbtn = New Button()
        checkmostrar = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(304, 378)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(363, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 25)
        Label1.TabIndex = 1
        Label1.Text = "INICIAR SESIÓN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 12F, FontStyle.Bold)
        Label2.Location = New Point(324, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 19)
        Label2.TabIndex = 2
        Label2.Text = "USUARIO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stencil", 12F, FontStyle.Bold)
        Label3.Location = New Point(324, 235)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 19)
        Label3.TabIndex = 3
        Label3.Text = "CONTRASEÑA"
        ' 
        ' txtusuario
        ' 
        txtusuario.Location = New Point(324, 185)
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(179, 23)
        txtusuario.TabIndex = 4
        ' 
        ' txtcontraseña
        ' 
        txtcontraseña.Location = New Point(324, 257)
        txtcontraseña.Name = "txtcontraseña"
        txtcontraseña.PasswordChar = "*"c
        txtcontraseña.Size = New Size(179, 23)
        txtcontraseña.TabIndex = 5
        ' 
        ' accederbtn
        ' 
        accederbtn.BackColor = SystemColors.MenuHighlight
        accederbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        accederbtn.ForeColor = Color.White
        accederbtn.Image = CType(resources.GetObject("accederbtn.Image"), Image)
        accederbtn.ImageAlign = ContentAlignment.MiddleLeft
        accederbtn.Location = New Point(324, 315)
        accederbtn.Name = "accederbtn"
        accederbtn.Size = New Size(116, 51)
        accederbtn.TabIndex = 6
        accederbtn.Text = "ACCEDER"
        accederbtn.TextAlign = ContentAlignment.MiddleRight
        accederbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(410, 37)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(93, 92)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' salirbtn
        ' 
        salirbtn.BackColor = SystemColors.MenuHighlight
        salirbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        salirbtn.ForeColor = Color.White
        salirbtn.Image = CType(resources.GetObject("salirbtn.Image"), Image)
        salirbtn.ImageAlign = ContentAlignment.MiddleLeft
        salirbtn.Location = New Point(456, 315)
        salirbtn.Name = "salirbtn"
        salirbtn.Size = New Size(114, 51)
        salirbtn.TabIndex = 9
        salirbtn.Text = "SALIR"
        salirbtn.TextAlign = ContentAlignment.MiddleRight
        salirbtn.UseVisualStyleBackColor = False
        ' 
        ' checkmostrar
        ' 
        checkmostrar.AutoSize = True
        checkmostrar.Location = New Point(324, 286)
        checkmostrar.Name = "checkmostrar"
        checkmostrar.Size = New Size(128, 19)
        checkmostrar.TabIndex = 10
        checkmostrar.Text = "Mostrar contraseña"
        checkmostrar.UseVisualStyleBackColor = True
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(600, 378)
        Controls.Add(checkmostrar)
        Controls.Add(salirbtn)
        Controls.Add(PictureBox2)
        Controls.Add(accederbtn)
        Controls.Add(txtcontraseña)
        Controls.Add(txtusuario)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents accederbtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents salirbtn As Button
    Friend WithEvents checkmostrar As CheckBox

End Class
