Imports MySql.Data.MySqlClient

Public Class frmRepuestos
    Private editando As Boolean = False
    Private repuestoIdActual As Integer = 0
    Private rolUsuario As String ' Esta variable es para almacenar el rol

    ' Modificar el constructor para recibir el rol
    Public Sub New(rolUsuario As String)
        InitializeComponent()
        Me.rolUsuario = rolUsuario
    End Sub

    Private Sub frmRepuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRepuestos()
        ConfigurarPermisos()
    End Sub

    Private Sub ConfigurarPermisos()
        ' Convertir a minúsculas para hacer la comparación insensible a mayúsculas
        Dim rol = rolUsuario.ToLower()

        ' Solo gerente y administrador pueden realizar estas acciones
        Dim puedeEditar As Boolean = (rol = "gerente" OrElse rol = "administrador")

        ' Configurar visibilidad/habilitación de controles
        btnNuevo.Visible = puedeEditar
        btnGuardar.Visible = puedeEditar
        btnEliminar.Visible = puedeEditar

        ' Deshabilitar campos de edición si no tiene permisos
        txtNombre.ReadOnly = Not puedeEditar
        txtCantidad.ReadOnly = Not puedeEditar
        txtPrecio.ReadOnly = Not puedeEditar
        txtProveedor.ReadOnly = Not puedeEditar

        ' La búsqueda está disponible para todos los roles
        tbBuscar.Enabled = True
        btBuscar.Enabled = True

        ' Configurar el DataGridView para que no permita edición si no tiene permisos
        dgvRepuestos.AllowUserToAddRows = puedeEditar
        dgvRepuestos.AllowUserToDeleteRows = puedeEditar
        dgvRepuestos.ReadOnly = Not puedeEditar
    End Sub




    Private Sub CargarRepuestos()
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()
                Dim query As String = "SELECT RepuestoID, NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor FROM repuestos"
                Using cmd As New MySqlCommand(query, conn)
                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvRepuestos.DataSource = dt

                        ' Ajustar columnas automáticamente
                        dgvRepuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar repuestos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not TienePermisosEdicion() Then
            MessageBox.Show("No tiene permisos para realizar esta operación.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ValidarCampos() Then
            If editando Then
                ActualizarRepuesto()
            Else
                GuardarRepuesto()
            End If
        End If
    End Sub

    Private Sub GuardarRepuesto()
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()
                Dim query As String = "INSERT INTO repuestos (NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor) VALUES (@nombre, @cantidad, @precio, @proveedor)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
                    cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txtCantidad.Text))
                    cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text))
                    cmd.Parameters.AddWithValue("@proveedor", txtProveedor.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Repuesto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarRepuestos()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al guardar repuesto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ActualizarRepuesto()
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()
                Dim query As String = "UPDATE repuestos SET NombreRepuesto = @nombre, CantidadStock = @cantidad, PrecioUnitario = @precio, Proveedor = @proveedor WHERE RepuestoID = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
                    cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txtCantidad.Text))
                    cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text))
                    cmd.Parameters.AddWithValue("@proveedor", txtProveedor.Text)
                    cmd.Parameters.AddWithValue("@id", repuestoIdActual)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Repuesto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarRepuestos()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar repuesto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Not TienePermisosEdicion() Then
            MessageBox.Show("No tiene permisos para realizar esta operación.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If dgvRepuestos.SelectedRows.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(dgvRepuestos.SelectedRows(0).Cells("RepuestoID").Value)
            Dim nombreRepuesto As String = dgvRepuestos.SelectedRows(0).Cells("NombreRepuesto").Value.ToString()

            If MessageBox.Show($"¿Está seguro de eliminar el repuesto '{nombreRepuesto}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                EliminarRepuesto(id)
            End If
        Else
            MessageBox.Show("Seleccione un repuesto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub EliminarRepuesto(id As Integer)
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()
                Dim query As String = "DELETE FROM repuestos WHERE RepuestoID = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Repuesto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarRepuestos()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar repuesto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvRepuestos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRepuestos.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvRepuestos.Rows(e.RowIndex)

            If row.Cells("RepuestoID").Value Is DBNull.Value Then
                LimpiarCampos()
                Return
            End If

            repuestoIdActual = Convert.ToInt32(row.Cells("RepuestoID").Value)
            txtNombre.Text = If(row.Cells("NombreRepuesto").Value Is DBNull.Value, "", row.Cells("NombreRepuesto").Value.ToString())
            txtCantidad.Text = If(row.Cells("CantidadStock").Value Is DBNull.Value, "", row.Cells("CantidadStock").Value.ToString())
            txtPrecio.Text = If(row.Cells("PrecioUnitario").Value Is DBNull.Value, "", row.Cells("PrecioUnitario").Value.ToString())
            txtProveedor.Text = If(row.Cells("Proveedor").Value Is DBNull.Value, "", row.Cells("Proveedor").Value.ToString())
            editando = True
            btnGuardar.Text = "Actualizar"
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If Not TienePermisosEdicion() Then
            MessageBox.Show("No tiene permisos para realizar esta operación.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        txtCantidad.Clear()
        txtPrecio.Clear()
        txtProveedor.Clear()
        editando = False
        repuestoIdActual = 0
        btnGuardar.Text = "Guardar"
        txtNombre.Focus()
    End Sub

    Private Function ValidarCampos() As Boolean
        ' Validar campos obligatorios
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("Ingrese el nombre del repuesto.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCantidad.Text) Or Not IsNumeric(txtCantidad.Text) Then
            MessageBox.Show("Ingrese una cantidad válida.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantidad.Focus()
            Return False
        End If

        If Convert.ToInt32(txtCantidad.Text) < 0 Then
            MessageBox.Show("La cantidad no puede ser negativa.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantidad.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPrecio.Text) Or Not IsNumeric(txtPrecio.Text) Then
            MessageBox.Show("Ingrese un precio válido.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrecio.Focus()
            Return False
        End If

        If Convert.ToDecimal(txtPrecio.Text) < 0 Then
            MessageBox.Show("El precio no puede ser negativo.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrecio.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtProveedor.Text) Then
            MessageBox.Show("Ingrese el nombre del proveedor.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProveedor.Focus()
            Return False
        End If

        ' Validar repuesto duplicado
        If ExisteRepuestoDuplicado() Then
            MessageBox.Show("Ya existe un repuesto con este nombre.", "Repuesto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function ExisteRepuestoDuplicado() As Boolean
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()
                Dim query As String

                If editando Then
                    ' Si estamos editando, excluimos el repuesto actual de la búsqueda
                    query = "SELECT COUNT(*) FROM repuestos WHERE LOWER(NombreRepuesto) = LOWER(@nombre) AND RepuestoID <> @id"
                Else
                    ' Si es nuevo, buscamos cualquier coincidencia
                    query = "SELECT COUNT(*) FROM repuestos WHERE LOWER(NombreRepuesto) = LOWER(@nombre)"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim())
                    If editando Then
                        cmd.Parameters.AddWithValue("@id", repuestoIdActual)
                    End If

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al verificar repuesto duplicado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True ' En caso de error, prevenimos la inserción/actualización
        End Try
    End Function



    Private Sub FiltrarRepuestos(filtro As String)
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()
                Dim query As String = "SELECT RepuestoID, NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor FROM repuestos WHERE NombreRepuesto LIKE @filtro OR Proveedor LIKE @filtro"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@filtro", "%" & filtro & "%")
                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvRepuestos.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al filtrar repuestos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Liberar recursos cuando se cierre el formulario
    Private Sub frmRepuestos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.BackgroundImage IsNot Nothing Then
            Me.BackgroundImage.Dispose()
        End If
    End Sub

    Private Sub dgvRepuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRepuestos.CellContentClick

    End Sub


    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                Dim query As String = "SELECT * FROM repuestos WHERE RepuestoID = @busqueda OR NombreRepuesto LIKE @nombre"
                Dim cmd As New MySqlCommand(query, conn)

                ' Si el texto es numérico, puede coincidir con el ID
                cmd.Parameters.AddWithValue("@busqueda", tbBuscar.Text)
                ' Siempre buscar por nombre también
                cmd.Parameters.AddWithValue("@nombre", "%" & tbBuscar.Text & "%")

                Dim adaptador As New MySqlDataAdapter(cmd)
                Dim tabla As New DataTable
                adaptador.Fill(tabla)

                dgvRepuestos.DataSource = tabla
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message)
        End Try
    End Sub

    ' Función auxiliar para verificar permisos
    Private Function TienePermisosEdicion() As Boolean
        Dim rol = rolUsuario.ToLower()
        Return rol = "gerente" OrElse rol = "administrador"
    End Function

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Me.Close()
    End Sub

End Class

















