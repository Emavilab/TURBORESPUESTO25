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
        txtusuario = New TextBox()
        txtcontraseña = New TextBox()
        accederbtn = New Button()
        PictureBox2 = New PictureBox()
        salirbtn = New Button()
        checkmostrar = New CheckBox()
        Label4 = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Azure
        PictureBox1.Image = My.Resources.Resources.Trend_closet__10_
        PictureBox1.Location = New Point(-1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(845, 530)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Azure
        Label1.Font = New Font("Tempus Sans ITC", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(324, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 46)
        Label1.TabIndex = 1
        Label1.Text = "INICIAR SESIÓN"
        ' 
        ' txtusuario
        ' 
        txtusuario.BorderStyle = BorderStyle.FixedSingle
        txtusuario.Font = New Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtusuario.ForeColor = SystemColors.MenuText
        txtusuario.Location = New Point(312, 223)
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(332, 33)
        txtusuario.TabIndex = 4
        ' 
        ' txtcontraseña
        ' 
        txtcontraseña.BorderStyle = BorderStyle.FixedSingle
        txtcontraseña.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtcontraseña.Location = New Point(312, 343)
        txtcontraseña.Name = "txtcontraseña"
        txtcontraseña.PasswordChar = "*"c
        txtcontraseña.Size = New Size(332, 33)
        txtcontraseña.TabIndex = 5
        ' 
        ' accederbtn
        ' 
        accederbtn.BackColor = Color.Azure
        accederbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        accederbtn.ForeColor = Color.Black
        accederbtn.Image = CType(resources.GetObject("accederbtn.Image"), Image)
        accederbtn.ImageAlign = ContentAlignment.MiddleLeft
        accederbtn.Location = New Point(324, 441)
        accederbtn.Name = "accederbtn"
        accederbtn.Size = New Size(116, 51)
        accederbtn.TabIndex = 6
        accederbtn.Text = "ACCEDER"
        accederbtn.TextAlign = ContentAlignment.MiddleRight
        accederbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(420, 70)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(93, 92)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' salirbtn
        ' 
        salirbtn.BackColor = Color.Azure
        salirbtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        salirbtn.ForeColor = Color.Black
        salirbtn.Image = CType(resources.GetObject("salirbtn.Image"), Image)
        salirbtn.ImageAlign = ContentAlignment.MiddleLeft
        salirbtn.Location = New Point(459, 441)
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
        checkmostrar.BackColor = Color.Azure
        checkmostrar.Location = New Point(324, 382)
        checkmostrar.Name = "checkmostrar"
        checkmostrar.Size = New Size(128, 19)
        checkmostrar.TabIndex = 10
        checkmostrar.Text = "Mostrar contraseña"
        checkmostrar.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Azure
        Label4.Font = New Font("Tempus Sans ITC", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(307, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 46)
        Label4.TabIndex = 11
        Label4.Text = "Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Azure
        Label2.Font = New Font("Tempus Sans ITC", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(307, 294)
        Label2.Name = "Label2"
        Label2.Size = New Size(184, 46)
        Label2.TabIndex = 12
        Label2.Text = "Contraseña"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(843, 526)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(checkmostrar)
        Controls.Add(salirbtn)
        Controls.Add(PictureBox2)
        Controls.Add(accederbtn)
        Controls.Add(txtcontraseña)
        Controls.Add(txtusuario)
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
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents accederbtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents salirbtn As Button
    Friend WithEvents checkmostrar As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label

End Class
