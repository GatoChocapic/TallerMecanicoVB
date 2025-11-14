<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        txtCorreo = New TextBox()
        txtContraseña = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnIngresar = New Button()
        btnSalir = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtCorreo
        ' 
        txtCorreo.BorderStyle = BorderStyle.FixedSingle
        txtCorreo.Location = New Point(213, 221)
        txtCorreo.Margin = New Padding(3, 2, 3, 2)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(180, 23)
        txtCorreo.TabIndex = 0
        ' 
        ' txtContraseña
        ' 
        txtContraseña.BorderStyle = BorderStyle.FixedSingle
        txtContraseña.Location = New Point(213, 268)
        txtContraseña.Margin = New Padding(3, 2, 3, 2)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.PasswordChar = "*"c
        txtContraseña.Size = New Size(180, 23)
        txtContraseña.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(123, 229)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 2
        Label1.Text = "Correo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLight
        Label2.Location = New Point(123, 276)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 3
        Label2.Text = "Contraseña"
        ' 
        ' btnIngresar
        ' 
        btnIngresar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIngresar.Location = New Point(421, 244)
        btnIngresar.Margin = New Padding(3, 2, 3, 2)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(82, 22)
        btnIngresar.TabIndex = 4
        btnIngresar.Text = "Ingresar"
        btnIngresar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.Location = New Point(458, 416)
        btnSalir.Margin = New Padding(3, 2, 3, 2)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(82, 22)
        btnSalir.TabIndex = 5
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(68, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(208, 20)
        Label3.TabIndex = 6
        Label3.Text = "Login de Taller Mecanico"
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(583, 484)
        Controls.Add(Label3)
        Controls.Add(btnSalir)
        Controls.Add(btnIngresar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtContraseña)
        Controls.Add(txtCorreo)
        DoubleBuffered = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmLogin"
        Text = ","
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label3 As Label
End Class
