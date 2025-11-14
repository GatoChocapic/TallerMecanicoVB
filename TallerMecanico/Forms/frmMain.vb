Imports MySql.Data.MySqlClient
Imports System.Reflection
Imports System.IO

Public Class frmMain
    Private usuarioCorreo As String
    Private usuarioTipo As String

    ' Constructor: Recibe el correo y el tipo de usuario al crear el formulario
    Public Sub New(correo As String, tipo As String)
        InitializeComponent()
        usuarioCorreo = correo
        usuarioTipo = tipo

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llama a esta función para configurar los permisos cuando el formulario se carga
        ConfigurarPermisosMenu()
    End Sub

    Private Sub ConfigurarPermisosMenu()
        ' Por defecto, ocultar todos los botones al inicio para simplificar la lógica
        btnInventarioRepuestos.Visible = False
        btnGestionUsuarios.Visible = False



        Select Case usuarioTipo
            Case "Administrador"
                ' Administrador ve ambos botones
                btnInventarioRepuestos.Visible = True
                btnGestionUsuarios.Visible = True

            Case "Gerente"
                ' Gerente ve ambos botones
                btnInventarioRepuestos.Visible = True
                btnGestionUsuarios.Visible = True

            Case "Vendedor"
                ' Vendedor solo ve Inventario Repuestos
                btnInventarioRepuestos.Visible = True
                ' btnGestionUsuarios.Visible = False (ya está oculto por defecto)

            Case "Mecanico", "Analista"
                ' Mecánico y Analista no ven ninguno de estos botones
                ' (ya están ocultos por defecto)

            Case Else
                ' Tipo de usuario no reconocido o sin permisos
                MessageBox.Show("Tipo de usuario no reconocido o sin permisos. Cerrando sesión.", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim loginForm As New frmLogin()
                loginForm.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub btnInventarioRepuestos_Click(sender As Object, e As EventArgs) Handles btnInventarioRepuestos.Click
        Dim frmRepuestos As New frmRepuestos(usuarioTipo)
        frmRepuestos.ShowDialog()
    End Sub

    Private Sub btnGestionUsuarios_Click(sender As Object, e As EventArgs) Handles btnGestionUsuarios.Click
        ' Si el botón ya es visible/habilitado por ConfigurarPermisosMenu,
        ' no se necesita la validación adicional aquí, porque el usuario no podría hacer clic si no tiene permiso.
        ' Si se dejan los botones visibles pero Enabled=False, esta validación es una buena segunda capa.

        ' Si se usa Visible=False en ConfigurarPermisosMenu, esta validación es redundante.
        ' If usuarioTipo = "Administrador" Or usuarioTipo = "Gerente" Then
        Dim frmUsuarios As New frmUsuarios()
        frmUsuarios.ShowDialog()
        'Else
        '     MessageBox.Show("No tiene permisos para acceder a esta opción.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ' End If
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim loginForm As New frmLogin()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    ' Liberar recursos al cerrar
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.BackgroundImage IsNot Nothing Then
            Me.BackgroundImage.Dispose()
        End If
    End Sub
End Class