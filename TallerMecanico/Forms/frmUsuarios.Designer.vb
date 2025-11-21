<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        dgvUsuarios = New DataGridView()
        Label1 = New Label()
        txtRut = New TextBox()
        Label2 = New Label()
        txtCorreo = New TextBox()
        Label3 = New Label()
        txtContraseña = New TextBox()
        Label4 = New Label()
        cmbTipo = New ComboBox()
        btnGuardar = New Button()
        btnNuevo = New Button()
        btnEliminar = New Button()
        Label5 = New Label()
        chbIngresar = New CheckBox()
        chbModificar = New CheckBox()
        chbEliminar = New CheckBox()
        Label6 = New Label()
        tbBusquedarut = New TextBox()
        btBusquedarut = New Button()
        btVolver = New Button()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvUsuarios
        ' 
        dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsuarios.Location = New Point(72, 122)
        dgvUsuarios.Margin = New Padding(3, 2, 3, 2)
        dgvUsuarios.Name = "dgvUsuarios"
        dgvUsuarios.RowHeadersWidth = 51
        dgvUsuarios.Size = New Size(454, 141)
        dgvUsuarios.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(80, 342)
        Label1.Name = "Label1"
        Label1.Size = New Size(27, 15)
        Label1.TabIndex = 2
        Label1.Text = "Rut"
        ' 
        ' txtRut
        ' 
        txtRut.BorderStyle = BorderStyle.FixedSingle
        txtRut.Location = New Point(180, 334)
        txtRut.Margin = New Padding(3, 2, 3, 2)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(132, 23)
        txtRut.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(80, 375)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 4
        Label2.Text = "Correo"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.BorderStyle = BorderStyle.FixedSingle
        txtCorreo.Location = New Point(179, 373)
        txtCorreo.Margin = New Padding(3, 2, 3, 2)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(186, 23)
        txtCorreo.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(80, 412)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 6
        Label3.Text = "Contraseña"
        ' 
        ' txtContraseña
        ' 
        txtContraseña.BorderStyle = BorderStyle.FixedSingle
        txtContraseña.Location = New Point(179, 410)
        txtContraseña.Margin = New Padding(3, 2, 3, 2)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.PasswordChar = "*"c
        txtContraseña.Size = New Size(186, 23)
        txtContraseña.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(80, 456)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 8
        Label4.Text = "Tipo"
        ' 
        ' cmbTipo
        ' 
        cmbTipo.FormattingEnabled = True
        cmbTipo.Location = New Point(179, 453)
        cmbTipo.Margin = New Padding(3, 2, 3, 2)
        cmbTipo.Name = "cmbTipo"
        cmbTipo.Size = New Size(133, 23)
        cmbTipo.TabIndex = 9
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardar.Location = New Point(444, 368)
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
        btnNuevo.Location = New Point(444, 408)
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
        btnEliminar.Location = New Point(444, 446)
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
        Label5.Location = New Point(52, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(260, 37)
        Label5.TabIndex = 13
        Label5.Text = "Gestión de Usuario"
        ' 
        ' chbIngresar
        ' 
        chbIngresar.AutoSize = True
        chbIngresar.BackColor = Color.Transparent
        chbIngresar.ForeColor = SystemColors.ControlLightLight
        chbIngresar.Location = New Point(113, 288)
        chbIngresar.Name = "chbIngresar"
        chbIngresar.Size = New Size(110, 19)
        chbIngresar.TabIndex = 14
        chbIngresar.Text = "Ingresar usuario"
        chbIngresar.UseVisualStyleBackColor = False
        ' 
        ' chbModificar
        ' 
        chbModificar.AutoSize = True
        chbModificar.BackColor = Color.Transparent
        chbModificar.ForeColor = SystemColors.ControlLightLight
        chbModificar.Location = New Point(246, 288)
        chbModificar.Name = "chbModificar"
        chbModificar.Size = New Size(119, 19)
        chbModificar.TabIndex = 15
        chbModificar.Text = "Modificar usuario"
        chbModificar.UseVisualStyleBackColor = False
        ' 
        ' chbEliminar
        ' 
        chbEliminar.AutoSize = True
        chbEliminar.BackColor = Color.Transparent
        chbEliminar.ForeColor = SystemColors.ControlLightLight
        chbEliminar.Location = New Point(381, 288)
        chbEliminar.Name = "chbEliminar"
        chbEliminar.Size = New Size(111, 19)
        chbEliminar.TabIndex = 16
        chbEliminar.Text = "Eliminar usuario"
        chbEliminar.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(72, 77)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 15)
        Label6.TabIndex = 17
        Label6.Text = "Busqueda de Usuario (RUT): "
        ' 
        ' tbBusquedarut
        ' 
        tbBusquedarut.Location = New Point(275, 74)
        tbBusquedarut.Name = "tbBusquedarut"
        tbBusquedarut.Size = New Size(134, 23)
        tbBusquedarut.TabIndex = 18
        ' 
        ' btBusquedarut
        ' 
        btBusquedarut.Location = New Point(451, 73)
        btBusquedarut.Name = "btBusquedarut"
        btBusquedarut.Size = New Size(75, 23)
        btBusquedarut.TabIndex = 19
        btBusquedarut.Text = "Buscar"
        btBusquedarut.UseVisualStyleBackColor = True
        ' 
        ' btVolver
        ' 
        btVolver.Location = New Point(515, 492)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(75, 23)
        btVolver.TabIndex = 20
        btVolver.Text = "Volver"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' frmUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(602, 537)
        Controls.Add(btVolver)
        Controls.Add(btBusquedarut)
        Controls.Add(tbBusquedarut)
        Controls.Add(Label6)
        Controls.Add(chbEliminar)
        Controls.Add(chbModificar)
        Controls.Add(chbIngresar)
        Controls.Add(Label5)
        Controls.Add(btnEliminar)
        Controls.Add(btnNuevo)
        Controls.Add(btnGuardar)
        Controls.Add(cmbTipo)
        Controls.Add(Label4)
        Controls.Add(txtContraseña)
        Controls.Add(Label3)
        Controls.Add(txtCorreo)
        Controls.Add(Label2)
        Controls.Add(txtRut)
        Controls.Add(Label1)
        Controls.Add(dgvUsuarios)
        DoubleBuffered = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmUsuarios"
        Text = "frmUsuarios"
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents chbIngresar As CheckBox
    Friend WithEvents chbModificar As CheckBox
    Friend WithEvents chbEliminar As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbBusquedarut As TextBox
    Friend WithEvents btBusquedarut As Button
    Friend WithEvents btVolver As Button
End Class
