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
        btRegistrarVentas = New Button()
        btnGestionSiniestros = New Button()
        SuspendLayout()
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.BackColor = Color.Transparent
        lblUsuario.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsuario.ForeColor = SystemColors.ButtonHighlight
        lblUsuario.Location = New Point(59, 77)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(200, 46)
        lblUsuario.TabIndex = 0
        lblUsuario.Text = "Bienvenido"
        ' 
        ' btnInventarioRepuestos
        ' 
        btnInventarioRepuestos.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInventarioRepuestos.Location = New Point(230, 332)
        btnInventarioRepuestos.Name = "btnInventarioRepuestos"
        btnInventarioRepuestos.Size = New Size(203, 29)
        btnInventarioRepuestos.TabIndex = 1
        btnInventarioRepuestos.Text = "Inventario Repuestos"
        btnInventarioRepuestos.UseVisualStyleBackColor = True
        ' 
        ' btnGestionUsuarios
        ' 
        btnGestionUsuarios.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGestionUsuarios.Location = New Point(230, 217)
        btnGestionUsuarios.Name = "btnGestionUsuarios"
        btnGestionUsuarios.Size = New Size(203, 29)
        btnGestionUsuarios.TabIndex = 2
        btnGestionUsuarios.Text = "Gestion de Usuarios"
        btnGestionUsuarios.UseVisualStyleBackColor = True
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrarSesion.Location = New Point(495, 579)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New Size(136, 29)
        btnCerrarSesion.TabIndex = 3
        btnCerrarSesion.Text = "Cerrar Sesión"
        btnCerrarSesion.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.Location = New Point(537, 647)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(94, 29)
        btnSalir.TabIndex = 4
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btRegistrarVentas
        ' 
        btRegistrarVentas.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btRegistrarVentas.Location = New Point(230, 377)
        btRegistrarVentas.Margin = New Padding(3, 4, 3, 4)
        btRegistrarVentas.Name = "btRegistrarVentas"
        btRegistrarVentas.Size = New Size(203, 31)
        btRegistrarVentas.TabIndex = 5
        btRegistrarVentas.Text = "Registrar Ventas"
        btRegistrarVentas.UseVisualStyleBackColor = True
        ' 
        ' btnGestionSiniestros
        ' 
        btnGestionSiniestros.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGestionSiniestros.Location = New Point(230, 273)
        btnGestionSiniestros.Name = "btnGestionSiniestros"
        btnGestionSiniestros.Size = New Size(203, 29)
        btnGestionSiniestros.TabIndex = 6
        btnGestionSiniestros.Text = "Gestión de Siniestros"
        btnGestionSiniestros.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(688, 716)
        Controls.Add(btnGestionSiniestros)
        Controls.Add(btRegistrarVentas)
        Controls.Add(btnSalir)
        Controls.Add(btnCerrarSesion)
        Controls.Add(btnGestionUsuarios)
        Controls.Add(btnInventarioRepuestos)
        Controls.Add(lblUsuario)
        DoubleBuffered = True
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
    Friend WithEvents btRegistrarVentas As Button
    Friend WithEvents btnGestionSiniestros As Button
End Class
