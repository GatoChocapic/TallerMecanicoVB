<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadoVentas))
        dgvVentas = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        dtpDesde = New DateTimePicker()
        dtpHasta = New DateTimePicker()
        tbCliente = New TextBox()
        cbRepuesto = New ComboBox()
        btFiltrar = New Button()
        btMostrartodos = New Button()
        chkFecha = New CheckBox()
        btVolver = New Button()
        CType(dgvVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvVentas
        ' 
        dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVentas.Location = New Point(89, 310)
        dgvVentas.Name = "dgvVentas"
        dgvVentas.Size = New Size(407, 150)
        dgvVentas.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(52, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(241, 37)
        Label1.TabIndex = 1
        Label1.Text = "Listado de ventas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(329, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 2
        Label2.Text = "Fecha hasta:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(329, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 3
        Label3.Text = "Repuesto:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(83, 215)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 15)
        Label5.TabIndex = 5
        Label5.Text = "Cliente:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(83, 154)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 15)
        Label6.TabIndex = 6
        Label6.Text = "Fecha desde:"
        ' 
        ' dtpDesde
        ' 
        dtpDesde.Location = New Point(187, 148)
        dtpDesde.Name = "dtpDesde"
        dtpDesde.Size = New Size(122, 23)
        dtpDesde.TabIndex = 7
        ' 
        ' dtpHasta
        ' 
        dtpHasta.Location = New Point(424, 148)
        dtpHasta.Name = "dtpHasta"
        dtpHasta.Size = New Size(122, 23)
        dtpHasta.TabIndex = 8
        ' 
        ' tbCliente
        ' 
        tbCliente.Location = New Point(187, 212)
        tbCliente.Name = "tbCliente"
        tbCliente.Size = New Size(100, 23)
        tbCliente.TabIndex = 9
        ' 
        ' cbRepuesto
        ' 
        cbRepuesto.FormattingEnabled = True
        cbRepuesto.Location = New Point(425, 212)
        cbRepuesto.Name = "cbRepuesto"
        cbRepuesto.Size = New Size(121, 23)
        cbRepuesto.TabIndex = 10
        ' 
        ' btFiltrar
        ' 
        btFiltrar.Location = New Point(122, 270)
        btFiltrar.Name = "btFiltrar"
        btFiltrar.Size = New Size(75, 23)
        btFiltrar.TabIndex = 11
        btFiltrar.Text = "Filtrar"
        btFiltrar.UseVisualStyleBackColor = True
        ' 
        ' btMostrartodos
        ' 
        btMostrartodos.Location = New Point(389, 270)
        btMostrartodos.Name = "btMostrartodos"
        btMostrartodos.Size = New Size(92, 23)
        btMostrartodos.TabIndex = 12
        btMostrartodos.Text = "Mostrar todos"
        btMostrartodos.UseVisualStyleBackColor = True
        ' 
        ' chkFecha
        ' 
        chkFecha.AutoSize = True
        chkFecha.BackColor = Color.Transparent
        chkFecha.ForeColor = SystemColors.ControlLightLight
        chkFecha.Location = New Point(83, 101)
        chkFecha.Name = "chkFecha"
        chkFecha.Size = New Size(109, 19)
        chkFecha.TabIndex = 13
        chkFecha.Text = "Filtrar por fecha"
        chkFecha.UseVisualStyleBackColor = False
        ' 
        ' btVolver
        ' 
        btVolver.Location = New Point(493, 487)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(75, 23)
        btVolver.TabIndex = 14
        btVolver.Text = "Volver"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' frmListadoVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(602, 537)
        Controls.Add(btVolver)
        Controls.Add(chkFecha)
        Controls.Add(btMostrartodos)
        Controls.Add(btFiltrar)
        Controls.Add(cbRepuesto)
        Controls.Add(tbCliente)
        Controls.Add(dtpHasta)
        Controls.Add(dtpDesde)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvVentas)
        DoubleBuffered = True
        Name = "frmListadoVentas"
        Text = "frmListadoVentas"
        CType(dgvVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents tbCliente As TextBox
    Friend WithEvents cbRepuesto As ComboBox
    Friend WithEvents btFiltrar As Button
    Friend WithEvents btMostrartodos As Button
    Friend WithEvents chkFecha As CheckBox
    Friend WithEvents btVolver As Button
End Class
