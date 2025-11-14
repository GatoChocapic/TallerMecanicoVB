Imports MySql.Data.MySqlClient
Imports System.Reflection
Imports System.IO
Imports System.Text.RegularExpressions ' Añade esta línea para usar expresiones regulares para limpiar el RUT

Public Class frmUsuarios
    Private editando As Boolean = False
    Private rutActual As String = ""

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTiposUsuario() ' Cargar los ítems del ComboBox al iniciar el formulario
        CargarUsuarios()     ' Cargar los usuarios en el DataGridView al iniciar
        LimpiarCampos()      ' Asegurarse de que los campos estén limpios al inicio
    End Sub

    Private Sub CargarUsuarios()
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion() ' Asegúrate que "Conexion" es tu módulo
                conn.Open()
                Dim query As String = "SELECT Rut, Correo, Contraseña, Tipo FROM usuarios ORDER BY Rut" ' Ordenar para mejor visualización
                Using cmd As New MySqlCommand(query, conn)
                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvUsuarios.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar usuarios: " & ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarTiposUsuario()
        ' Limpiar antes de añadir para evitar duplicados si se llama más de una vez
        cmbTipo.Items.Clear()
        cmbTipo.Items.AddRange({"Administrador", "Gerente", "Mecanico", "Analista", "Vendedor"})
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidarCampos() Then
            If editando Then
                ActualizarUsuario()
            Else
                GuardarUsuario()

            End If
        End If
    End Sub

    Private Sub GuardarUsuario()
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()
                Dim query As String = "INSERT INTO usuarios (Rut, Correo, Contraseña, Tipo) VALUES (@rut, @correo, @contraseña, @tipo)"
                Using cmd As New MySqlCommand(query, conn)
                    ' Limpiar el RUT antes de guardar
                    Dim rutLimpio As String = LimpiarRut(txtRut.Text)
                    cmd.Parameters.AddWithValue("@rut", rutLimpio)
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text)
                    cmd.Parameters.AddWithValue("@contraseña", txtContraseña.Text)
                    cmd.Parameters.AddWithValue("@tipo", cmbTipo.SelectedItem.ToString())
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarUsuarios()
            LimpiarCampos()
        Catch ex As MySqlException
            If ex.Number = 1062 Then ' Error de entrada duplicada (Duplicate entry for key 'PRIMARY' o UNIQUE KEY)
                MessageBox.Show("Ya existe un usuario con el RUT ingresado.", "Error de Duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Error al guardar usuario en la base de datos: " & ex.Message, "Error de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error general al guardar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ActualizarUsuario()
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()
                Dim query As String = "UPDATE usuarios SET Correo = @correo, Contraseña = @contraseña, Tipo = @tipo WHERE Rut = @rutActual"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text)
                    cmd.Parameters.AddWithValue("@contraseña", txtContraseña.Text)
                    cmd.Parameters.AddWithValue("@tipo", cmbTipo.SelectedItem.ToString())
                    ' rutActual ya debería estar limpio o en el formato de la DB si se cargó desde ella.
                    cmd.Parameters.AddWithValue("@rutActual", rutActual)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarUsuarios()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Verificar si el CheckBox de eliminar está seleccionado
        If Not chbEliminar.Checked Then
            MessageBox.Show("Debe seleccionar la opción 'Eliminar Usuario' para poder eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir de la función si el CheckBox no está marcado
        End If

        'Verificar si hay alguna fila seleccionada en el DataGridView
        If dgvUsuarios.SelectedRows.Count > 0 Then
            Dim rutAEliminar As String = dgvUsuarios.SelectedRows(0).Cells("Rut").Value.ToString()

            ' Mostrar un mensaje de confirmación antes de eliminar
            Dim resultado As DialogResult = MessageBox.Show(
            "¿Está seguro de eliminar el usuario con RUT: " & rutAEliminar & "?" & Environment.NewLine &
            "Esta acción no se puede deshacer.",
            "Confirmar Eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

            If resultado = DialogResult.Yes Then
                ' Si el usuario confirma, proceder con la eliminación
                EliminarUsuario(rutAEliminar)
                chbEliminar.Checked = False ' Desmarcar el checkbox de eliminar después de la acción
            Else
                MessageBox.Show("La eliminación ha sido cancelada.", "Eliminación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Seleccione un usuario de la lista para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub EliminarUsuario(rut As String)
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()
                Dim query As String = "DELETE FROM usuarios WHERE Rut = @rut"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarUsuarios()
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'Manejador de los checkboxes para comportamiento de selección única
    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chbIngresar.CheckedChanged, chbModificar.CheckedChanged, chbEliminar.CheckedChanged
        Dim currentCheckBox As CheckBox = CType(sender, CheckBox)

        If currentCheckBox.Checked Then
            ' Desmarcar los otros
            If currentCheckBox IsNot chbIngresar Then chbIngresar.Checked = False
            If currentCheckBox IsNot chbModificar Then chbModificar.Checked = False
            If currentCheckBox IsNot chbEliminar Then chbEliminar.Checked = False

            ' --- Lógica específica según cuál está marcado ---
            If currentCheckBox Is chbIngresar Then
                editando = False
                btnGuardar.Text = "Guardar"
                txtRut.Enabled = True
            ElseIf currentCheckBox Is chbModificar Then
                editando = True
                btnGuardar.Text = "Actualizar"
                txtRut.Enabled = False
            ElseIf currentCheckBox Is chbEliminar Then
                editando = False
                btnGuardar.Text = "Guardar"
                txtRut.Enabled = True
            End If

        End If
    End Sub


    ' Manejador para CellClick, no CellContentClick para mayor robustez
    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsuarios.Rows(e.RowIndex)
            rutActual = row.Cells("Rut").Value.ToString()
            txtRut.Text = rutActual     ' Muestra el RUT como está en la DB
            txtCorreo.Text = row.Cells("Correo").Value.ToString()
            txtContraseña.Text = row.Cells("Contraseña").Value.ToString()
            ' Asegurarse de que el valor existe en el ComboBox
            Dim tipoDB As String = row.Cells("Tipo").Value.ToString()
            If cmbTipo.Items.Contains(tipoDB) Then
                cmbTipo.SelectedItem = tipoDB
            Else
                cmbTipo.Text = tipoDB ' Si no existe, al menos mostrar el texto
            End If

            editando = True
            btnGuardar.Text = "Actualizar"
            txtRut.Enabled = False ' No permitir editar el RUT al actualizar
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        txtRut.Clear()
        txtCorreo.Clear()
        txtContraseña.Clear()
        cmbTipo.SelectedIndex = -1 ' Desselecciona cualquier ítem
        editando = False
        rutActual = ""
        btnGuardar.Text = "Guardar"
        txtRut.Enabled = True ' Habilitar RUT para un nuevo ingreso
        txtRut.Focus()
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(txtRut.Text) Then
            MessageBox.Show("Ingrese el RUT del usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRut.Focus()
            Return False
        End If
        If Not EsRutValido(txtRut.Text) Then ' Nueva validación de formato de RUT
            MessageBox.Show("El formato del RUT ingresado no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRut.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtCorreo.Text) Then
            MessageBox.Show("Ingrese el correo del usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCorreo.Focus()
            Return False
        End If
        If Not EsCorreoValido(txtCorreo.Text) Then ' Nueva validación de formato de correo
            MessageBox.Show("El formato del correo electrónico no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCorreo.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtContraseña.Text) Then
            MessageBox.Show("Ingrese la contraseña del usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContraseña.Focus()
            Return False
        End If
        If cmbTipo.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el tipo de usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbTipo.Focus()
            Return False
        End If
        Return True
    End Function

    ' NUEVA FUNCIÓN: Limpia el RUT (quita puntos y guiones)
    Private Function LimpiarRut(rut As String) As String
        If String.IsNullOrEmpty(rut) Then Return ""
        ' Usa expresiones regulares para eliminar cualquier caracter que no sea nzxúmero o 'k'/'K'
        Return Regex.Replace(rut, "[^0-9kK]", "").ToUpper()
    End Function

    ' NUEVA FUNCIÓN: Valida el formato del RUT (sin verificar dígito verificador)
    Private Function EsRutValido(rut As String) As Boolean
        If String.IsNullOrWhiteSpace(rut) Then Return False

        ' Quita puntos y espacios
        rut = rut.Replace(".", "").Replace(" ", "")

        ' Esta expresión permite:
        '  - Con o sin guion
        '  - Con o sin puntos
        '  - Dígito verificador numérico o K/k
        Return Regex.IsMatch(rut, "^\d{7,8}-?[\dkK]$")
    End Function


    ' NUEVA FUNCIÓN: Valida un formato básico de correo electrónico
    Private Function EsCorreoValido(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then Return False
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function


    Private Sub FiltrarUsuarios(filtro As String)
        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion()
                conn.Open()
                ' Busca en Rut (limpio), Correo o Tipo.
                ' IMPORTANTE: Si los RUTs en la DB están limpios, busca con el filtro limpio también.
                Dim query As String = "SELECT Rut, Correo, Contraseña, Tipo FROM usuarios WHERE REPLACE(REPLACE(Rut, '.', ''), '-', '') LIKE @filtro OR Correo LIKE @filtro OR Tipo LIKE @filtro"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@filtro", "%" & LimpiarRut(filtro) & "%") ' Limpiar el filtro antes de buscar
                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvUsuarios.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al filtrar usuarios: " & ex.Message, "Error de Filtro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Liberar recursos cuando se cierre el formulario
    Private Sub frmUsuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.BackgroundImage IsNot Nothing Then
            Me.BackgroundImage.Dispose()
        End If
    End Sub




    Private Sub btBusquedarut_Click(sender As Object, e As EventArgs) Handles btBusquedarut.Click
        ' Validar que el campo RUT no esté vacío
        If String.IsNullOrWhiteSpace(txtRut.Text) Then
            MessageBox.Show("Por favor, ingrese un RUT para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'Limpiar el RUT del textbox antes de buscarlo en la base de datos.
        'Esto asegura que el formato enviado a la DB coincida con el formato almacenado.
        Dim rutABuscar As String = LimpiarRut(txtRut.Text)

        Try
            Using conn As MySqlConnection = Conexion.ObtenerConexion() ' <<-- Correcto: la variable local es 'conn'

                ' Asegurarse de que la conexión se obtuvo correctamente
                If conn Is Nothing Then
                    MessageBox.Show("No se pudo establecer la conexión con la base de datos.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If


                If conn.State <> ConnectionState.Open Then ' 

                    conn.Open()
                End If

                ' Ajustar la consulta SQL para que coincida con el formato del RUT en la DB
                Dim sql As String = "SELECT Rut, Correo, Contraseña, Tipo FROM usuarios WHERE Rut = @Rut LIMIT 1"


                Using comando As New MySqlCommand(sql, conn)
                    comando.Parameters.AddWithValue("@Rut", rutABuscar)

                    Using lector As MySqlDataReader = comando.ExecuteReader()
                        If lector.Read() Then
                            ' Asignar datos a los controles
                            txtRut.Text = lector("Rut").ToString() ' Mostrar el RUT tal como está en la DB
                            txtCorreo.Text = lector("Correo").ToString()
                            txtContraseña.Text = lector("Contraseña").ToString()

                            ' Asignar el tipo al ComboBox
                            Dim tipoUsuarioDB As String = lector("Tipo").ToString()
                            If cmbTipo.Items.Contains(tipoUsuarioDB) Then
                                cmbTipo.SelectedItem = tipoUsuarioDB
                            Else
                                cmbTipo.Text = tipoUsuarioDB ' Si no está en la lista, al menos mostrar el texto
                                MessageBox.Show("El tipo de usuario '" & tipoUsuarioDB & "' no se encuentra en las opciones del ComboBox. Se ha mostrado el texto directamente.", "Advertencia de Tipo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If

                            editando = True ' Si lo encuentras, podrías querer editarlo
                            btnGuardar.Text = "Actualizar"
                            txtRut.Enabled = False ' Para evitar que cambie el RUT en modo edición

                            MessageBox.Show("Usuario encontrado exitosamente.", "Búsqueda exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No se encontró ningún usuario con el RUT: " & rutABuscar, "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            ' Limpiar campos si no se encontró
                            LimpiarCampos()
                            txtRut.Text = rutABuscar ' Se puede dejar el RUT buscado para que el usuario corrija
                        End If
                    End Using
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error al acceder a la base de datos durante la búsqueda: " & ex.Message, "Error de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Se produjo un error general durante la búsqueda: " & ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class

