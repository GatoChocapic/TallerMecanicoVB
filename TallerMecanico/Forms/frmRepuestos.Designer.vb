<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepuestos))
        dgvRepuestos = New DataGridView()
        Label1 = New Label()
        txtNombre = New TextBox()
        Label2 = New Label()
        txtCantidad = New TextBox()
        Label3 = New Label()
        txtPrecio = New TextBox()
        Label4 = New Label()
        txtProveedor = New TextBox()
        btnGuardar = New Button()
        btnNuevo = New Button()
        btnEliminar = New Button()
        Label5 = New Label()
        tbBuscar = New TextBox()
        btBuscar = New Button()
        Label6 = New Label()
        CType(dgvRepuestos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvRepuestos
        ' 
        dgvRepuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRepuestos.Location = New Point(104, 330)
        dgvRepuestos.Margin = New Padding(3, 2, 3, 2)
        dgvRepuestos.Name = "dgvRepuestos"
        dgvRepuestos.RowHeadersWidth = 51
        dgvRepuestos.Size = New Size(431, 141)
        dgvRepuestos.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(102, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 15)
        Label1.TabIndex = 2
        Label1.Text = "Nombre"
        ' 
        ' txtNombre
        ' 
        txtNombre.BorderStyle = BorderStyle.FixedSingle
        txtNombre.Location = New Point(226, 142)
        txtNombre.Margin = New Padding(3, 2, 3, 2)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(196, 23)
        txtNombre.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(102, 286)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 4
        Label2.Text = "Cantidad"
        ' 
        ' txtCantidad
        ' 
        txtCantidad.BorderStyle = BorderStyle.FixedSingle
        txtCantidad.Location = New Point(226, 284)
        txtCantidad.Margin = New Padding(3, 2, 3, 2)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(47, 23)
        txtCantidad.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(102, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 6
        Label3.Text = "Precio"
        ' 
        ' txtPrecio
        ' 
        txtPrecio.BorderStyle = BorderStyle.FixedSingle
        txtPrecio.Location = New Point(226, 235)
        txtPrecio.Margin = New Padding(3, 2, 3, 2)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(110, 23)
        txtPrecio.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(102, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 15)
        Label4.TabIndex = 8
        Label4.Text = "Proveedor"
        ' 
        ' txtProveedor
        ' 
        txtProveedor.BorderStyle = BorderStyle.FixedSingle
        txtProveedor.Location = New Point(226, 190)
        txtProveedor.Margin = New Padding(3, 2, 3, 2)
        txtProveedor.Name = "txtProveedor"
        txtProveedor.Size = New Size(194, 23)
        txtProveedor.TabIndex = 9
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardar.Location = New Point(453, 140)
        btnGuardar.Margin = New Padding(3, 2, 3, 2)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(82, 22)
        btnGuardar.TabIndex = 10
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNuevo.Location = New Point(453, 192)
        btnNuevo.Margin = New Padding(3, 2, 3, 2)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(82, 22)
        btnNuevo.TabIndex = 11
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.AutoSize = True
        btnEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminar.Location = New Point(453, 276)
        btnEliminar.Margin = New Padding(3, 2, 3, 2)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(82, 25)
        btnEliminar.TabIndex = 12
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(55, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(293, 37)
        Label5.TabIndex = 13
        Label5.Text = "Gestión de Repuestos"
        ' 
        ' tbBuscar
        ' 
        tbBuscar.ForeColor = SystemColors.WindowFrame
        tbBuscar.Location = New Point(228, 90)
        tbBuscar.Name = "tbBuscar"
        tbBuscar.Size = New Size(194, 23)
        tbBuscar.TabIndex = 14
        tbBuscar.Tag = ""
        tbBuscar.Text = "Ingrese ID o Nombre del repuesto"
        ' 
        ' btBuscar
        ' 
        btBuscar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btBuscar.Location = New Point(453, 90)
        btBuscar.Name = "btBuscar"
        btBuscar.Size = New Size(82, 23)
        btBuscar.TabIndex = 15
        btBuscar.Text = "Buscar"
        btBuscar.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(102, 94)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 15)
        Label6.TabIndex = 16
        Label6.Text = "Buscar Repuesto"
        ' 
        ' frmRepuestos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(602, 537)
        Controls.Add(Label6)
        Controls.Add(btBuscar)
        Controls.Add(tbBuscar)
        Controls.Add(Label5)
        Controls.Add(btnEliminar)
        Controls.Add(btnNuevo)
        Controls.Add(btnGuardar)
        Controls.Add(txtProveedor)
        Controls.Add(Label4)
        Controls.Add(txtPrecio)
        Controls.Add(Label3)
        Controls.Add(txtCantidad)
        Controls.Add(Label2)
        Controls.Add(txtNombre)
        Controls.Add(Label1)
        Controls.Add(dgvRepuestos)
        DoubleBuffered = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmRepuestos"
        Text = "frmRepuestos"
        CType(dgvRepuestos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvRepuestos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents btBuscar As Button
    Friend WithEvents Label6 As Label
End Class
