Imports MySql.Data.MySqlClient

Public Class frmVentas

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim query As String = "SELECT RepuestoID, NombreRepuesto, CantidadStock, PrecioUnitario FROM repuestos"

        Using conn As MySqlConnection = ObtenerConexion()
            conn.Open()

            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            cbRepuestos.DataSource = dt
            cbRepuestos.DisplayMember = "NombreRepuesto"
            cbRepuestos.ValueMember = "RepuestoID"
        End Using

    End Sub


    Private Sub cbRepuestos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRepuestos.SelectedIndexChanged

        If cbRepuestos.SelectedValue Is Nothing Then Exit Sub

        Dim query As String =
            "SELECT CantidadStock, PrecioUnitario 
             FROM repuestos 
             WHERE RepuestoID = @id"

        Using conn As MySqlConnection = ObtenerConexion()
            conn.Open()

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", cbRepuestos.SelectedValue)

            Dim rd = cmd.ExecuteReader()
            If rd.Read() Then
                lbStock.Text = rd("CantidadStock").ToString()
                lbPrecio.Text = rd("PrecioUnitario").ToString()
            End If
            rd.Close()
        End Using

    End Sub


    Private Sub btCalcularTotal_Click(sender As Object, e As EventArgs) Handles btCalcularTotal.Click

        If Not IsNumeric(tbCantidad.Text) Then
            MsgBox("Ingrese una cantidad válida.")
            Exit Sub
        End If

        Dim precio As Decimal = CDec(lbPrecio.Text)
        Dim cantidad As Integer = CInt(tbCantidad.Text)
        Dim stock As Integer = CInt(lbStock.Text)

        ' VALIDACIÓN DE STOCK
        If cantidad > stock Then
            MsgBox("La cantidad ingresada excede el stock disponible (" & stock & ").", MsgBoxStyle.Critical)
            lbTotal.Text = "0"  ' Opcional, para evitar valores inválidos
            Exit Sub
        End If

        lbTotal.Text = (precio * cantidad).ToString("N0")

    End Sub




    Private Sub btRegistrarVenta_Click_1(sender As Object, e As EventArgs) Handles btRegistrarVenta.Click
        Dim cantidad As Integer = CInt(tbCantidad.Text)
        Dim stock As Integer = CInt(lbStock.Text)

        If cantidad > stock Then
            MsgBox("No hay stock suficiente", MsgBoxStyle.Critical)
            Exit Sub
        End If

        ' Usamos conexión para verificar cliente antes de abrir transacción
        Using conn As MySqlConnection = ObtenerConexion()
            conn.Open()

            ' 1. VERIFICAR SI EL CLIENTE EXISTE
            Dim queryCheck As String = "SELECT COUNT(*) FROM clientes WHERE Rut = @rutCheck"
            Dim cmdCheck As New MySqlCommand(queryCheck, conn)
            cmdCheck.Parameters.AddWithValue("@rutCheck", tbCliente.Text)

            Dim existe As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

            If existe = 0 Then
                ' --- CLIENTE NO EXISTE ---
                ' Mostramos el panel para llenar los datos faltantes de tu tabla
                gbCrearCliente.Visible = True

                ' Llevamos el foco al nombre para empezar a escribir
                tbNuevoNombre.Focus()

                MsgBox("El RUT " & tbCliente.Text & " no existe. Por favor complete los datos del cliente para continuar.", MsgBoxStyle.Information)
                Exit Sub ' Detenemos la venta aquí
            End If

            ' 2. SI EL CLIENTE EXISTE, PROCEDEMOS CON LA VENTA NORMAL
            Dim transaction = conn.BeginTransaction()
            Try
                Dim total As Decimal = CDec(lbPrecio.Text) * cantidad

                ' INSERTAR VENTA
                Dim queryVenta As String =
            "INSERT INTO ventasrepuestos (NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total) VALUES (@nom, @cant, @cli, @fecha, @total)"

                Dim cmdVenta As New MySqlCommand(queryVenta, conn, transaction)
                cmdVenta.Parameters.AddWithValue("@nom", cbRepuestos.Text)
                cmdVenta.Parameters.AddWithValue("@cant", cantidad)
                cmdVenta.Parameters.AddWithValue("@cli", tbCliente.Text)
                cmdVenta.Parameters.AddWithValue("@fecha", dtpFechaVenta.Value.ToString("yyyy-MM-dd"))
                cmdVenta.Parameters.AddWithValue("@total", total)
                cmdVenta.ExecuteNonQuery()

                ' ACTUALIZAR STOCK
                Dim queryStock As String = "UPDATE repuestos SET CantidadStock = CantidadStock - @cant WHERE RepuestoID = @id"
                Dim cmdStock As New MySqlCommand(queryStock, conn, transaction)
                cmdStock.Parameters.AddWithValue("@cant", cantidad)
                cmdStock.Parameters.AddWithValue("@id", cbRepuestos.SelectedValue)
                cmdStock.ExecuteNonQuery()

                transaction.Commit()
                MsgBox("Venta registrada correctamente.")
                Me.Close()

            Catch ex As Exception
                transaction.Rollback()
                MsgBox("Error en la venta: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btVerListadoVentas_Click(sender As Object, e As EventArgs) Handles btVerListadoVentas.Click
        Dim f As New frmListadoVentas()
        f.ShowDialog()
    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Me.Close()
    End Sub

    Private Sub btGuardarNuevoCliente_Click(sender As Object, e As EventArgs) Handles btGuardarNuevoCliente.Click
        ' Validación básica: Al menos Nombre y Apellido deben estar
        If tbNuevoNombre.Text = "" Or tbNuevoApellidoP.Text = "" Then
            MsgBox("Por favor ingrese al menos Nombre y Apellido Paterno.")
            Exit Sub
        End If

        Using conn As MySqlConnection = ObtenerConexion()
            conn.Open()
            Try
                ' SQL adaptado a TU tabla (según la imagen)
                Dim queryCli As String =
                "INSERT INTO clientes 
                (Rut, Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna) 
                VALUES 
                (@rut, @nom, @app, @apm, @dir, @tel, @com)"

                Dim cmd As New MySqlCommand(queryCli, conn)
                ' El RUT lo sacamos de la caja principal de la venta
                cmd.Parameters.AddWithValue("@rut", tbCliente.Text)

                ' El resto lo sacamos del panel
                cmd.Parameters.AddWithValue("@nom", tbNuevoNombre.Text)
                cmd.Parameters.AddWithValue("@app", tbNuevoApellidoP.Text)
                cmd.Parameters.AddWithValue("@apm", tbNuevoApellidoM.Text)
                cmd.Parameters.AddWithValue("@dir", tbNuevoDireccion.Text)
                cmd.Parameters.AddWithValue("@tel", tbNUevoTelefono.Text)
                cmd.Parameters.AddWithValue("@com", tbNuevaComuna.Text)

                cmd.ExecuteNonQuery()

                MsgBox("Cliente creado exitosamente.")

                ' LIMPIEZA Y CIERRE DEL PANEL
                gbCrearCliente.Visible = False

                ' Limpiamos las cajas del panel por si acaso
                tbNuevoNombre.Clear()
                tbNuevoApellidoP.Clear()
                tbNuevoApellidoM.Clear()
                tbNuevoDireccion.Clear()
                tbNUevoTelefono.Clear()
                tbNuevaComuna.Clear()

                ' TRUCO: Hacemos click automático en "Registrar Venta" de nuevo
                ' Como el cliente ya existe, ahora la venta pasará sin errores.
                btRegistrarVenta.PerformClick()

            Catch ex As Exception
                MsgBox("Error al crear cliente: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btCancelarCliente_Click(sender As Object, e As EventArgs) Handles btCancelarCliente.Click
        gbCrearCliente.Visible = False
        MsgBox("Operación cancelada. No se registró la venta.")
    End Sub


End Class
