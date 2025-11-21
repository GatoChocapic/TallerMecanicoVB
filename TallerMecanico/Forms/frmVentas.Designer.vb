<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        cbRepuestos = New ComboBox()
        lbStock = New Label()
        lbPrecio = New Label()
        tbCantidad = New TextBox()
        tbCliente = New TextBox()
        dtpFechaVenta = New DateTimePicker()
        lbTotal = New Label()
        btRegistrarVenta = New Button()
        btCalcularTotal = New Button()
        Label8 = New Label()
        btVerListadoVentas = New Button()
        btVolver = New Button()
        gbCrearCliente = New GroupBox()
        btCancelarCliente = New Button()
        btGuardarNuevoCliente = New Button()
        tbNuevaComuna = New TextBox()
        tbNUevoTelefono = New TextBox()
        Label11 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label10 = New Label()
        tbNuevoDireccion = New TextBox()
        tbNuevoApellidoM = New TextBox()
        tbNuevoApellidoP = New TextBox()
        tbNuevoNombre = New TextBox()
        Label9 = New Label()
        gbCrearCliente.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(111, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 0
        Label1.Text = "Repuesto:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(111, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 1
        Label2.Text = "Stock Actual:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(111, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 15)
        Label3.TabIndex = 2
        Label3.Text = "Precio Unitario:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(111, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 15)
        Label4.TabIndex = 3
        Label4.Text = "Cantidad a Vender:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(111, 284)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 4
        Label5.Text = "Total:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(113, 417)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 15)
        Label6.TabIndex = 5
        Label6.Text = "Fecha de Venta"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(113, 368)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 15)
        Label7.TabIndex = 6
        Label7.Text = "Cliente:"
        ' 
        ' cbRepuestos
        ' 
        cbRepuestos.FormattingEnabled = True
        cbRepuestos.Location = New Point(279, 92)
        cbRepuestos.Name = "cbRepuestos"
        cbRepuestos.Size = New Size(121, 23)
        cbRepuestos.TabIndex = 7
        ' 
        ' lbStock
        ' 
        lbStock.AutoSize = True
        lbStock.Location = New Point(279, 135)
        lbStock.Name = "lbStock"
        lbStock.Size = New Size(0, 15)
        lbStock.TabIndex = 8
        ' 
        ' lbPrecio
        ' 
        lbPrecio.AutoSize = True
        lbPrecio.Location = New Point(279, 181)
        lbPrecio.Name = "lbPrecio"
        lbPrecio.Size = New Size(0, 15)
        lbPrecio.TabIndex = 9
        ' 
        ' tbCantidad
        ' 
        tbCantidad.Location = New Point(279, 232)
        tbCantidad.Name = "tbCantidad"
        tbCantidad.Size = New Size(67, 23)
        tbCantidad.TabIndex = 10
        ' 
        ' tbCliente
        ' 
        tbCliente.Location = New Point(279, 365)
        tbCliente.Name = "tbCliente"
        tbCliente.Size = New Size(200, 23)
        tbCliente.TabIndex = 11
        ' 
        ' dtpFechaVenta
        ' 
        dtpFechaVenta.Location = New Point(279, 411)
        dtpFechaVenta.Name = "dtpFechaVenta"
        dtpFechaVenta.Size = New Size(200, 23)
        dtpFechaVenta.TabIndex = 12
        ' 
        ' lbTotal
        ' 
        lbTotal.AutoSize = True
        lbTotal.Location = New Point(284, 284)
        lbTotal.Name = "lbTotal"
        lbTotal.Size = New Size(0, 15)
        lbTotal.TabIndex = 13
        ' 
        ' btRegistrarVenta
        ' 
        btRegistrarVenta.Location = New Point(66, 464)
        btRegistrarVenta.Name = "btRegistrarVenta"
        btRegistrarVenta.Size = New Size(94, 23)
        btRegistrarVenta.TabIndex = 14
        btRegistrarVenta.Text = "Registrar Venta"
        btRegistrarVenta.UseVisualStyleBackColor = True
        ' 
        ' btCalcularTotal
        ' 
        btCalcularTotal.Location = New Point(167, 318)
        btCalcularTotal.Name = "btCalcularTotal"
        btCalcularTotal.Size = New Size(103, 23)
        btCalcularTotal.TabIndex = 15
        btCalcularTotal.Text = "Calcular Total"
        btCalcularTotal.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(52, 21)
        Label8.Name = "Label8"
        Label8.Size = New Size(214, 37)
        Label8.TabIndex = 16
        Label8.Text = "Registrar Venta"
        ' 
        ' btVerListadoVentas
        ' 
        btVerListadoVentas.Location = New Point(192, 464)
        btVerListadoVentas.Name = "btVerListadoVentas"
        btVerListadoVentas.Size = New Size(128, 23)
        btVerListadoVentas.TabIndex = 17
        btVerListadoVentas.Text = "Ver listado de Ventas"
        btVerListadoVentas.UseVisualStyleBackColor = True
        ' 
        ' btVolver
        ' 
        btVolver.Location = New Point(515, 487)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(75, 23)
        btVolver.TabIndex = 18
        btVolver.Text = "Volver"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' gbCrearCliente
        ' 
        gbCrearCliente.BackColor = SystemColors.ControlDarkDark
        gbCrearCliente.Controls.Add(btCancelarCliente)
        gbCrearCliente.Controls.Add(btGuardarNuevoCliente)
        gbCrearCliente.Controls.Add(tbNuevaComuna)
        gbCrearCliente.Controls.Add(tbNUevoTelefono)
        gbCrearCliente.Controls.Add(Label11)
        gbCrearCliente.Controls.Add(Label15)
        gbCrearCliente.Controls.Add(Label14)
        gbCrearCliente.Controls.Add(Label13)
        gbCrearCliente.Controls.Add(Label12)
        gbCrearCliente.Controls.Add(Label10)
        gbCrearCliente.Controls.Add(tbNuevoDireccion)
        gbCrearCliente.Controls.Add(tbNuevoApellidoM)
        gbCrearCliente.Controls.Add(tbNuevoApellidoP)
        gbCrearCliente.Controls.Add(tbNuevoNombre)
        gbCrearCliente.Controls.Add(Label9)
        gbCrearCliente.Location = New Point(130, 21)
        gbCrearCliente.Name = "gbCrearCliente"
        gbCrearCliente.Size = New Size(349, 449)
        gbCrearCliente.TabIndex = 20
        gbCrearCliente.TabStop = False
        gbCrearCliente.Text = "Nuevo Cliente Detectado"
        gbCrearCliente.Visible = False
        ' 
        ' btCancelarCliente
        ' 
        btCancelarCliente.Location = New Point(249, 407)
        btCancelarCliente.Name = "btCancelarCliente"
        btCancelarCliente.Size = New Size(75, 23)
        btCancelarCliente.TabIndex = 15
        btCancelarCliente.Text = "Cancelar"
        btCancelarCliente.UseVisualStyleBackColor = True
        ' 
        ' btGuardarNuevoCliente
        ' 
        btGuardarNuevoCliente.Location = New Point(128, 356)
        btGuardarNuevoCliente.Name = "btGuardarNuevoCliente"
        btGuardarNuevoCliente.Size = New Size(107, 23)
        btGuardarNuevoCliente.TabIndex = 14
        btGuardarNuevoCliente.Text = "Guardar Cliente"
        btGuardarNuevoCliente.UseVisualStyleBackColor = True
        ' 
        ' tbNuevaComuna
        ' 
        tbNuevaComuna.Location = New Point(187, 309)
        tbNuevaComuna.Name = "tbNuevaComuna"
        tbNuevaComuna.Size = New Size(100, 23)
        tbNuevaComuna.TabIndex = 13
        ' 
        ' tbNUevoTelefono
        ' 
        tbNUevoTelefono.Location = New Point(187, 265)
        tbNUevoTelefono.Name = "tbNUevoTelefono"
        tbNUevoTelefono.Size = New Size(100, 23)
        tbNUevoTelefono.TabIndex = 12
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(50, 312)
        Label11.Name = "Label11"
        Label11.Size = New Size(56, 15)
        Label11.TabIndex = 11
        Label11.Text = "Comuna:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(50, 268)
        Label15.Name = "Label15"
        Label15.Size = New Size(56, 15)
        Label15.TabIndex = 10
        Label15.Text = "Telefono:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(50, 223)
        Label14.Name = "Label14"
        Label14.Size = New Size(60, 15)
        Label14.TabIndex = 9
        Label14.Text = "Direccion:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(46, 187)
        Label13.Name = "Label13"
        Label13.Size = New Size(102, 15)
        Label13.TabIndex = 8
        Label13.Text = "Apellido Materno:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(50, 140)
        Label12.Name = "Label12"
        Label12.Size = New Size(98, 15)
        Label12.TabIndex = 7
        Label12.Text = "Apellido Paterno:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(50, 97)
        Label10.Name = "Label10"
        Label10.Size = New Size(54, 15)
        Label10.TabIndex = 5
        Label10.Text = "Nombre:"
        ' 
        ' tbNuevoDireccion
        ' 
        tbNuevoDireccion.Location = New Point(187, 220)
        tbNuevoDireccion.Name = "tbNuevoDireccion"
        tbNuevoDireccion.Size = New Size(100, 23)
        tbNuevoDireccion.TabIndex = 4
        ' 
        ' tbNuevoApellidoM
        ' 
        tbNuevoApellidoM.Location = New Point(187, 179)
        tbNuevoApellidoM.Name = "tbNuevoApellidoM"
        tbNuevoApellidoM.Size = New Size(100, 23)
        tbNuevoApellidoM.TabIndex = 3
        ' 
        ' tbNuevoApellidoP
        ' 
        tbNuevoApellidoP.Location = New Point(187, 137)
        tbNuevoApellidoP.Name = "tbNuevoApellidoP"
        tbNuevoApellidoP.Size = New Size(100, 23)
        tbNuevoApellidoP.TabIndex = 2
        ' 
        ' tbNuevoNombre
        ' 
        tbNuevoNombre.Location = New Point(187, 94)
        tbNuevoNombre.Name = "tbNuevoNombre"
        tbNuevoNombre.Size = New Size(100, 23)
        tbNuevoNombre.TabIndex = 1
        ' 
        ' Label9
        ' 
        Label9.Cursor = Cursors.IBeam
        Label9.Location = New Point(29, 26)
        Label9.Name = "Label9"
        Label9.Size = New Size(295, 46)
        Label9.TabIndex = 0
        Label9.Text = "El cliente no existe, completa los datos para continuar la venta"
        ' 
        ' frmVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(602, 537)
        Controls.Add(gbCrearCliente)
        Controls.Add(btVolver)
        Controls.Add(btVerListadoVentas)
        Controls.Add(Label8)
        Controls.Add(btCalcularTotal)
        Controls.Add(btRegistrarVenta)
        Controls.Add(lbTotal)
        Controls.Add(dtpFechaVenta)
        Controls.Add(tbCliente)
        Controls.Add(tbCantidad)
        Controls.Add(lbPrecio)
        Controls.Add(lbStock)
        Controls.Add(cbRepuestos)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "frmVentas"
        Text = "frmVentas"
        gbCrearCliente.ResumeLayout(False)
        gbCrearCliente.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbRepuestos As ComboBox
    Friend WithEvents lbStock As Label
    Friend WithEvents lbPrecio As Label
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents tbCliente As TextBox
    Friend WithEvents dtpFechaVenta As DateTimePicker
    Friend WithEvents lbTotal As Label
    Friend WithEvents btRegistrarVenta As Button
    Friend WithEvents btCalcularTotal As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btVerListadoVentas As Button
    Friend WithEvents btVolver As Button
    Friend WithEvents gbCrearCliente As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbNuevoDireccion As TextBox
    Friend WithEvents tbNuevoApellidoM As TextBox
    Friend WithEvents tbNuevoApellidoP As TextBox
    Friend WithEvents tbNuevoNombre As TextBox
    Friend WithEvents tbNUevoTelefono As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tbNuevaComuna As TextBox
    Friend WithEvents btGuardarNuevoCliente As Button
    Friend WithEvents btCancelarCliente As Button
End Class
