Imports MySql.Data.MySqlClient

Public Class frmListadoVentas

    Private Sub frmListadoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComboRepuestos()
        CargarVentas()
    End Sub



    ' CARGA COMBO DE REPUESTOS

    Private Sub CargarComboRepuestos()

        Dim query As String = "SELECT NombreRepuesto FROM repuestos ORDER BY NombreRepuesto ASC"

        Using conn As MySqlConnection = ObtenerConexion()
            conn.Open()

            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            cbRepuesto.DataSource = dt
            cbRepuesto.DisplayMember = "NombreRepuesto"
            cbRepuesto.SelectedIndex = -1
        End Using

    End Sub




    ' FUNCIÓN PARA CARGAR TODAS LAS VENTAS

    Private Sub CargarVentas(Optional filtros As String = "")

        Dim query As String =
        "SELECT 
            VentaID,
            NombreRepuesto,
            CantidadVendida,
            Cliente,
            FechaVenta,
            Total
         FROM ventasrepuestos 
         WHERE 1=1 " & filtros & "
         ORDER BY FechaVenta DESC"

        Using conn As MySqlConnection = ObtenerConexion()
            conn.Open()

            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            dgvVentas.DataSource = dt
        End Using

    End Sub




    ' BOTÓN FILTRAR

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btFiltrar.Click

        Dim filtro As String = ""

        ' Filtrar por fecha (solo si el checkbox está activado)
        If chkFecha.Checked Then
            filtro &= " AND FechaVenta BETWEEN '" &
                  dtpDesde.Value.ToString("yyyy-MM-dd") & "' AND '" &
                  dtpHasta.Value.ToString("yyyy-MM-dd") & "' "
        End If

        ' Filtrar por repuesto
        If cbRepuesto.SelectedIndex <> -1 Then
            filtro &= " AND NombreRepuesto = '" & cbRepuesto.Text & "'"
        End If

        ' Filtrar por cliente
        If tbCliente.Text.Trim() <> "" Then
            filtro &= " AND Cliente LIKE '%" & tbCliente.Text.Trim() & "%'"
        End If

        CargarVentas(filtro)

    End Sub





    ' BOTÓN MOSTRAR TODO

    Private Sub btnMostrarTodos_Click(sender As Object, e As EventArgs) Handles btMostrartodos.Click
        cbRepuesto.SelectedIndex = -1
        tbCliente.Clear()
        chkFecha.Checked = False
        CargarVentas()
    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click

        Me.Close()
    End Sub
End Class