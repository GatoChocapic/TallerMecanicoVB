Imports MySql.Data.MySqlClient

Public Class frmSiniestros
    Private editando As Boolean = False
    Private siniestroIdActual As Integer = 0

    Private Sub frmSiniestros_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Agregamos las opciones
        cbEstadoSeguro.Items.Clear()
        cbEstadoSeguro.Items.Add("Vigente")
        cbEstadoSeguro.Items.Add("Vencido")
        cbEstadoSeguro.Items.Add("Suspendido")

        ' 1. Pone la letra NEGRA para las filas normales (las que no estás tocando)
        dgvSiniestros.DefaultCellStyle.ForeColor = Color.Black

        ' 2. (Opcional) Asegura que el fondo sea BLANCO
        dgvSiniestros.DefaultCellStyle.BackColor = Color.White

        ' 3. Mantiene tu configuración de selección (para que se vea bien al hacer click)
        dgvSiniestros.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvSiniestros.DefaultCellStyle.SelectionBackColor = Color.LightBlue
        CargarSiniestros()

        CargarComboCompanias()
        CargarComboEstados()
    End Sub

    Private Sub CargarSiniestros(Optional filtro As String = "")
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()

                ' ... (Tu SELECT sigue igual) ...
                Dim query As String =
                "SELECT s.SiniestroID, s.Detalle, s.Estado_Siniestro, s.Fecha_Siniestro, s.RutCompania, s.Rut, " &
                "c.Nombre AS NombreCliente, c.ApellidoP AS ApellidoPCliente, c.ApellidoM AS ApellidoMCliente, s.Estado_Seguro " &
                "FROM siniestro s " &
                "INNER JOIN clientes c ON s.Rut = c.Rut " &
                "WHERE 1 = 1 " & filtro & " " &  ' <--- OJO AQUI
                "ORDER BY s.Fecha_Siniestro DESC"

                ' TRUCO DEPURACIÓN: Descomenta la siguiente línea para ver la consulta real
                ' MessageBox.Show(query) 

                Using da As New MySqlDataAdapter(query, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    dgvSiniestros.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar: " & ex.Message)
        End Try
    End Sub



    Private Sub CargarComboCompanias()
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()
                Dim query As String = "SELECT Rut, Descripcion FROM compania ORDER BY Descripcion"
                Using da As New MySqlDataAdapter(query, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    cbCompania.DataSource = dt
                    cbCompania.DisplayMember = "Descripcion"
                    cbCompania.ValueMember = "Rut"
                    cbCompania.SelectedIndex = -1
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar compañías: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarComboEstados()
        ' Para el combo de edición
        cbEstado.Items.AddRange({"Pendiente", "Activo", "Finalizado"})

        ' Para el combo de filtro
        cbEstadoFiltro.Items.Add("")
        cbEstadoFiltro.Items.AddRange({"Pendiente", "Activo", "Finalizado"})
        cbEstadoFiltro.SelectedIndex = 0
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim filtro As String = ""
        Dim textoBusqueda As String = tbClienteFiltro.Text.Trim()

        ' 1. Filtro por Estado
        If cbEstadoFiltro.SelectedItem IsNot Nothing AndAlso cbEstadoFiltro.SelectedItem.ToString() <> "" Then
            filtro &= " AND s.Estado_Siniestro = '" & cbEstadoFiltro.SelectedItem.ToString() & "'"
        End If

        ' 2. Filtro de la Caja de Texto (Inteligente)
        If textoBusqueda <> "" Then

            ' Verificamos si lo que escribiste es un NÚMERO
            If IsNumeric(textoBusqueda) Then
                ' CORRECCIÓN: Si es número, buscamos SOLO por ID exacto.
                ' Quitamos la parte del RUT para que no traiga otros datos por error.
                filtro &= " AND s.SiniestroID = " & textoBusqueda
            Else
                ' CASO 2: Es texto (ej: "Juan"). Buscamos solo en Nombre o Rut.
                filtro &= " AND (c.Nombre LIKE '%" & textoBusqueda & "%' OR c.Rut LIKE '%" & textoBusqueda & "%')"
            End If

        End If

        CargarSiniestros(filtro)
    End Sub

    Private Sub btnMostrarTodos_Click(sender As Object, e As EventArgs) Handles btnMostrarTodos.Click
        tbClienteFiltro.Clear()
        cbEstadoFiltro.SelectedIndex = 0
        CargarSiniestros()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidarCampos() Then
            If editando Then
                ActualizarSiniestro()
            Else
                GuardarSiniestro()
            End If
        End If
    End Sub

    Private Sub GuardarSiniestro()
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()
                Dim query As String = "INSERT INTO siniestro (Detalle, Estado_Siniestro, Fecha_Siniestro, RutCompania, Rut, Estado_Seguro) " &
                                    "VALUES (@detalle, @estado, @fecha, @rutCompania, @rutCliente, @estadoSeguro)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@detalle", tbDetalle.Text)
                    cmd.Parameters.AddWithValue("@estado", cbEstado.Text)
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@rutCompania", cbCompania.SelectedValue)
                    cmd.Parameters.AddWithValue("@rutCliente", tbCliente.Text)
                    cmd.Parameters.AddWithValue("@estadoSeguro", cbEstadoSeguro.Text)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Siniestro guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarSiniestros()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al guardar siniestro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ActualizarSiniestro()
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()
                Dim query As String = "UPDATE siniestro SET Detalle=@detalle, Estado_Siniestro=@estado, " &
                                    "Fecha_Siniestro=@fecha, RutCompania=@rutCompania, Rut=@rutCliente, " &
                                    "Estado_Seguro=@estadoSeguro WHERE SiniestroID=@id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@detalle", tbDetalle.Text)
                    cmd.Parameters.AddWithValue("@estado", cbEstado.Text)
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@rutCompania", cbCompania.SelectedValue)
                    cmd.Parameters.AddWithValue("@Nombre", tbCliente.Text)
                    cmd.Parameters.AddWithValue("@estadoSeguro", cbEstadoSeguro.Text)
                    cmd.Parameters.AddWithValue("@id", siniestroIdActual)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Siniestro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarSiniestros()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar siniestro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub SeleccionarCompaniaEnCombo(descripcionCompania As String)
        For i As Integer = 0 To cbCompania.Items.Count - 1
            Dim drv As DataRowView = TryCast(cbCompania.Items(i), DataRowView)
            If drv IsNot Nothing AndAlso drv("Descripcion").ToString() = descripcionCompania Then
                cbCompania.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If siniestroIdActual > 0 Then
            If MessageBox.Show("¿Está seguro de eliminar este siniestro?", "Confirmar eliminación",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                EliminarSiniestro()
            End If
        Else
            MessageBox.Show("Seleccione un siniestro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub EliminarSiniestro()
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()
                Dim query As String = "DELETE FROM siniestro WHERE SiniestroID=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", siniestroIdActual)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Siniestro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarSiniestros()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar siniestro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(tbDetalle.Text) Then
            MessageBox.Show("Ingrese el detalle del siniestro.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbDetalle.Focus()
            Return False
        End If

        If cbEstado.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un estado para el siniestro.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbEstado.Focus()
            Return False
        End If

        If cbCompania.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione una compañía de seguros.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbCompania.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(tbCliente.Text) Then
            MessageBox.Show("Ingrese el RUT del cliente.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbCliente.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(cbEstadoSeguro.Text) Then
            MessageBox.Show("Ingrese el estado del seguro.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbEstadoSeguro.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub LimpiarCampos()
        tbDetalle.Clear()
        cbEstado.SelectedIndex = -1
        dtpFecha.Value = DateTime.Now
        cbCompania.SelectedIndex = -1
        tbCliente.Clear()


        editando = False
        siniestroIdActual = 0
        btnGuardar.Text = "Guardar"
    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub tbClienteFiltro_TextChanged(sender As Object, e As EventArgs) Handles tbClienteFiltro.TextChanged

    End Sub

    Private Sub dgvSiniestros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiniestros.CellClick
        ' 1. Verificar que no sea el encabezado (-1)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSiniestros.Rows(e.RowIndex)

            ' 2. IMPORTANTE: Verificar que no sea la "Fila Nueva" (la vacía del final)
            If row.IsNewRow Then Return

            ' 3. IMPORTANTE: Verificar que la celda SiniestroID no sea NULA (DBNull)
            If IsDBNull(row.Cells("SiniestroID").Value) OrElse row.Cells("SiniestroID").Value Is Nothing Then
                Return ' Si es nula, salimos y no hacemos nada para evitar el error
            End If

            ' Si pasamos las validaciones, ahora es seguro leer
            siniestroIdActual = Convert.ToInt32(row.Cells("SiniestroID").Value)

            ' Usamos verificaciones también para los textos por si vienen vacíos
            tbDetalle.Text = If(IsDBNull(row.Cells("Detalle").Value), "", row.Cells("Detalle").Value.ToString())

            If Not IsDBNull(row.Cells("Estado_Siniestro").Value) Then
                cbEstado.Text = row.Cells("Estado_Siniestro").Value.ToString()
            End If

            If Not IsDBNull(row.Cells("Fecha_Siniestro").Value) Then
                dtpFecha.Value = Convert.ToDateTime(row.Cells("Fecha_Siniestro").Value)
            End If

            If Not IsDBNull(row.Cells("Estado_Seguro").Value) Then
                cbEstadoSeguro.Text = row.Cells("Estado_Seguro").Value.ToString()
            End If

            tbIdsiniestro.Text = siniestroIdActual.ToString()

            ' Armar nombre completo con seguridad
            Dim nombre As String = If(IsDBNull(row.Cells("NombreCliente").Value), "", row.Cells("NombreCliente").Value.ToString())
            Dim apP As String = If(IsDBNull(row.Cells("ApellidoPCliente").Value), "", row.Cells("ApellidoPCliente").Value.ToString())
            Dim apM As String = If(IsDBNull(row.Cells("ApellidoMCliente").Value), "", row.Cells("ApellidoMCliente").Value.ToString())

            tbCliente.Text = (nombre & " " & apP & " " & apM).Trim()

            editando = True
            btnGuardar.Text = "Actualizar"
        End If
    End Sub


    Private Sub tbIdsiniestro_TextChanged(sender As Object, e As EventArgs) Handles tbIdsiniestro.TextChanged

    End Sub

    Private Sub cbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstado.SelectedIndexChanged

    End Sub

    Private Sub cbCompania_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCompania.SelectedIndexChanged

    End Sub

    Private Sub cbEstadoSeguro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstadoSeguro.SelectedIndexChanged

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbDetalle.TextChanged

    End Sub

    Private Sub cbEstadoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEstadoFiltro.SelectedIndexChanged

    End Sub

    Private Sub tbCliente_TextChanged(sender As Object, e As EventArgs) Handles tbCliente.TextChanged

    End Sub

    Private Sub dgvSiniestros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSiniestros.CellContentClick

    End Sub
End Class