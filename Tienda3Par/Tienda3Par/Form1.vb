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
        insertarUsuario()
        conexion.conexion.Close()
    End Sub
End Class
