Imports System.Text.RegularExpressions
Public Class frmUsuario
    Dim conexion As New Conexion()

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Conectar()
    End Sub

    Private Sub insertarUsuario()
        Dim idUsuario As Integer
        Dim nombre, apellido, username, psw, correo, estado, rol As String

        idUsuario = txtCodigo.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        username = txtUserName.Text
        psw = txtPsw.Text
        correo = txtCorreo.Text
        estado = "activo"
        rol = cmbRol.SelectedItem

        Try
            If conexion.insertarUsuario(idUsuario, nombre, apellido, username, psw, rol, estado, correo) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Limpiar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtUserName.Clear()
        txtPsw.Clear()
        txtCorreo.Clear()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If validarCorreo(LCase(txtCorreo.Text)) = False Then
            MessageBox.Show("Correo invalido, *username@midominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCorreo.Focus()
            txtCorreo.SelectAll()
        Else
            insertarUsuario()
            conexion.conexion.Close()
        End If
    End Sub

    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarUsuario()
    End Sub

    Private Sub eliminarUsuario()
        Dim idUsuario As Integer
        Dim rol As String
        idUsuario = txtCodigo.Text
        rol = cmbRol.Text
        Try
            If (conexion.eliminarUsuario(idUsuario, rol)) Then
                MsgBox("Dado de baja")
            Else
                MsgBox("Error al dar de baja usuario")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificarUsuario()
    End Sub

    Private Sub modificarUsuario()
        Dim idUsuario As Integer
        Dim nombre, apellido, username, psw, correo, rol As String

        idUsuario = txtCodigo.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        username = txtUserName.Text
        psw = txtPsw.Text
        correo = txtCorreo.Text
        rol = cmbRol.SelectedItem

        Try
            If conexion.modificarUsuario(idUsuario, nombre, apellido, username, psw, rol, correo) Then
                MessageBox.Show("Usuario modificado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
