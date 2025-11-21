<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSiniestros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSiniestros))
        dgvSiniestros = New DataGridView()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        btnMostrarTodos = New Button()
        btnFiltrar = New Button()
        tbClienteFiltro = New TextBox()
        cbEstadoFiltro = New ComboBox()
        GroupBox2 = New GroupBox()
        tbCliente = New TextBox()
        cbEstadoSeguro = New ComboBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        tbIdsiniestro = New TextBox()
        tbDetalle = New RichTextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnEliminar = New Button()
        btnGuardar = New Button()
        btnNuevo = New Button()
        cbCompania = New ComboBox()
        dtpFecha = New DateTimePicker()
        cbEstado = New ComboBox()
        btVolver = New Button()
        Label9 = New Label()
        CType(dgvSiniestros, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvSiniestros
        ' 
        dgvSiniestros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSiniestros.GridColor = Color.Black
        dgvSiniestros.Location = New Point(278, 36)
        dgvSiniestros.Margin = New Padding(3, 2, 3, 2)
        dgvSiniestros.Name = "dgvSiniestros"
        dgvSiniestros.RowHeadersWidth = 51
        dgvSiniestros.Size = New Size(276, 102)
        dgvSiniestros.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnMostrarTodos)
        GroupBox1.Controls.Add(btnFiltrar)
        GroupBox1.Controls.Add(dgvSiniestros)
        GroupBox1.Controls.Add(tbClienteFiltro)
        GroupBox1.Controls.Add(cbEstadoFiltro)
        GroupBox1.ForeColor = SystemColors.ControlLightLight
        GroupBox1.Location = New Point(58, 361)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(560, 192)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Siniestros Ingresados"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 15)
        Label1.TabIndex = 4
        Label1.Text = "Ingrese ID de Siniestro:"
        ' 
        ' btnMostrarTodos
        ' 
        btnMostrarTodos.BackColor = SystemColors.ControlLightLight
        btnMostrarTodos.ForeColor = SystemColors.ActiveCaptionText
        btnMostrarTodos.Location = New Point(368, 151)
        btnMostrarTodos.Margin = New Padding(3, 2, 3, 2)
        btnMostrarTodos.Name = "btnMostrarTodos"
        btnMostrarTodos.Size = New Size(120, 22)
        btnMostrarTodos.TabIndex = 3
        btnMostrarTodos.Text = "Mostrar Todos"
        btnMostrarTodos.UseVisualStyleBackColor = False
        ' 
        ' btnFiltrar
        ' 
        btnFiltrar.ForeColor = SystemColors.ActiveCaptionText
        btnFiltrar.Location = New Point(173, 151)
        btnFiltrar.Margin = New Padding(3, 2, 3, 2)
        btnFiltrar.Name = "btnFiltrar"
        btnFiltrar.Size = New Size(82, 22)
        btnFiltrar.TabIndex = 2
        btnFiltrar.Text = "Filtrar"
        btnFiltrar.UseVisualStyleBackColor = True
        ' 
        ' tbClienteFiltro
        ' 
        tbClienteFiltro.Location = New Point(144, 55)
        tbClienteFiltro.Margin = New Padding(3, 2, 3, 2)
        tbClienteFiltro.Name = "tbClienteFiltro"
        tbClienteFiltro.Size = New Size(129, 23)
        tbClienteFiltro.TabIndex = 1
        ' 
        ' cbEstadoFiltro
        ' 
        cbEstadoFiltro.FormattingEnabled = True
        cbEstadoFiltro.Location = New Point(144, 91)
        cbEstadoFiltro.Margin = New Padding(3, 2, 3, 2)
        cbEstadoFiltro.Name = "cbEstadoFiltro"
        cbEstadoFiltro.Size = New Size(129, 23)
        cbEstadoFiltro.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(tbCliente)
        GroupBox2.Controls.Add(cbEstadoSeguro)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(tbIdsiniestro)
        GroupBox2.Controls.Add(tbDetalle)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(btnEliminar)
        GroupBox2.Controls.Add(btnGuardar)
        GroupBox2.Controls.Add(btnNuevo)
        GroupBox2.Controls.Add(cbCompania)
        GroupBox2.Controls.Add(dtpFecha)
        GroupBox2.Controls.Add(cbEstado)
        GroupBox2.ForeColor = SystemColors.ControlLightLight
        GroupBox2.Location = New Point(23, 28)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(627, 314)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Ingresar Siniestros"
        ' 
        ' tbCliente
        ' 
        tbCliente.Location = New Point(227, 187)
        tbCliente.Name = "tbCliente"
        tbCliente.Size = New Size(121, 23)
        tbCliente.TabIndex = 16
        ' 
        ' cbEstadoSeguro
        ' 
        cbEstadoSeguro.FormattingEnabled = True
        cbEstadoSeguro.Location = New Point(227, 230)
        cbEstadoSeguro.Name = "cbEstadoSeguro"
        cbEstadoSeguro.Size = New Size(123, 23)
        cbEstadoSeguro.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(53, 230)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 15)
        Label8.TabIndex = 14
        Label8.Text = "Estado del seguro:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(53, 190)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 15)
        Label7.TabIndex = 13
        Label7.Text = "Cliente:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(53, 153)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 15)
        Label6.TabIndex = 12
        Label6.Text = "Compañía:"
        ' 
        ' tbIdsiniestro
        ' 
        tbIdsiniestro.Location = New Point(227, 32)
        tbIdsiniestro.Name = "tbIdsiniestro"
        tbIdsiniestro.Size = New Size(123, 23)
        tbIdsiniestro.TabIndex = 11
        ' 
        ' tbDetalle
        ' 
        tbDetalle.Location = New Point(383, 80)
        tbDetalle.Name = "tbDetalle"
        tbDetalle.Size = New Size(222, 199)
        tbDetalle.TabIndex = 10
        tbDetalle.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(53, 112)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 15)
        Label5.TabIndex = 9
        Label5.Text = "Fecha del siniestro:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(53, 75)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 15)
        Label4.TabIndex = 8
        Label4.Text = "Estado del siniestro:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 15)
        Label3.TabIndex = 7
        Label3.Text = "ID del siniestro:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(403, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 15)
        Label2.TabIndex = 6
        Label2.Text = "Ingrese detalle del siniestro:"
        ' 
        ' btnEliminar
        ' 
        btnEliminar.ForeColor = SystemColors.ActiveCaptionText
        btnEliminar.Location = New Point(240, 278)
        btnEliminar.Margin = New Padding(3, 2, 3, 2)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(82, 22)
        btnEliminar.TabIndex = 5
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.ForeColor = SystemColors.ActiveCaptionText
        btnGuardar.Location = New Point(132, 278)
        btnGuardar.Margin = New Padding(3, 2, 3, 2)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(82, 22)
        btnGuardar.TabIndex = 4
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.ForeColor = SystemColors.ActiveCaptionText
        btnNuevo.Location = New Point(16, 278)
        btnNuevo.Margin = New Padding(3, 2, 3, 2)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(82, 22)
        btnNuevo.TabIndex = 3
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' cbCompania
        ' 
        cbCompania.FormattingEnabled = True
        cbCompania.Location = New Point(227, 150)
        cbCompania.Margin = New Padding(3, 2, 3, 2)
        cbCompania.Name = "cbCompania"
        cbCompania.Size = New Size(123, 23)
        cbCompania.TabIndex = 3
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Location = New Point(227, 112)
        dtpFecha.Margin = New Padding(3, 2, 3, 2)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(123, 23)
        dtpFecha.TabIndex = 2
        ' 
        ' cbEstado
        ' 
        cbEstado.FormattingEnabled = True
        cbEstado.Location = New Point(227, 72)
        cbEstado.Margin = New Padding(3, 2, 3, 2)
        cbEstado.Name = "cbEstado"
        cbEstado.Size = New Size(123, 23)
        cbEstado.TabIndex = 1
        ' 
        ' btVolver
        ' 
        btVolver.Location = New Point(579, 557)
        btVolver.Margin = New Padding(3, 2, 3, 2)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(82, 22)
        btVolver.TabIndex = 6
        btVolver.Text = "Volver"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(17, 94)
        Label9.Name = "Label9"
        Label9.Size = New Size(112, 15)
        Label9.TabIndex = 5
        Label9.Text = "Estado del Siniestro:"
        ' 
        ' frmSiniestros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(673, 597)
        Controls.Add(btVolver)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        DoubleBuffered = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmSiniestros"
        Text = "frmSiniestros"
        CType(dgvSiniestros, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvSiniestros As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents tbClienteFiltro As TextBox
    Friend WithEvents cbEstadoFiltro As ComboBox
    Friend WithEvents btnMostrarTodos As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbCompania As ComboBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btVolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbDetalle As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbIdsiniestro As TextBox
    Friend WithEvents cbEstadoSeguro As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbCliente As TextBox
    Friend WithEvents Label9 As Label
End Class
