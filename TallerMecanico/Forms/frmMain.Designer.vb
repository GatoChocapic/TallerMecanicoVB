<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        lblUsuario = New Label()
        btnInventarioRepuestos = New Button()
        btnGestionUsuarios = New Button()
        btnCerrarSesion = New Button()
        btnSalir = New Button()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        SuspendLayout()
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.BackColor = Color.Transparent
        lblUsuario.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsuario.ForeColor = SystemColors.ButtonHighlight
        lblUsuario.Location = New Point(52, 58)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(161, 37)
        lblUsuario.TabIndex = 0
        lblUsuario.Text = "Bienvenido"
        ' 
        ' btnInventarioRepuestos
        ' 
        btnInventarioRepuestos.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInventarioRepuestos.Location = New Point(52, 163)
        btnInventarioRepuestos.Margin = New Padding(3, 2, 3, 2)
        btnInventarioRepuestos.Name = "btnInventarioRepuestos"
        btnInventarioRepuestos.Size = New Size(142, 22)
        btnInventarioRepuestos.TabIndex = 1
        btnInventarioRepuestos.Text = "Inventario Repuestos"
        btnInventarioRepuestos.UseVisualStyleBackColor = True
        ' 
        ' btnGestionUsuarios
        ' 
        btnGestionUsuarios.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGestionUsuarios.Location = New Point(213, 163)
        btnGestionUsuarios.Margin = New Padding(3, 2, 3, 2)
        btnGestionUsuarios.Name = "btnGestionUsuarios"
        btnGestionUsuarios.Size = New Size(178, 22)
        btnGestionUsuarios.TabIndex = 2
        btnGestionUsuarios.Text = "Gestion de Usuarios"
        btnGestionUsuarios.UseVisualStyleBackColor = True
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrarSesion.Location = New Point(433, 434)
        btnCerrarSesion.Margin = New Padding(3, 2, 3, 2)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(119, 22)
        btnCerrarSesion.TabIndex = 3
        btnCerrarSesion.Text = "Cerrar Sesión"
        btnCerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.Location = New Point(470, 485)
        btnSalir.Margin = New Padding(3, 2, 3, 2)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(82, 22)
        btnSalir.TabIndex = 4
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(602, 537)
        Controls.Add(btnSalir)
        Controls.Add(btnCerrarSesion)
        Controls.Add(btnGestionUsuarios)
        Controls.Add(btnInventarioRepuestos)
        Controls.Add(lblUsuario)
        DoubleBuffered = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmMain"
        Text = "frmMain"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnInventarioRepuestos As Button
    Friend WithEvents btnGestionUsuarios As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
