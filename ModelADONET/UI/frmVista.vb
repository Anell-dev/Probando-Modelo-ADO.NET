Imports BLL
Imports Entities

Public Class frmVista
    Private negocio As New Negocio()
    Private usuarios As List(Of Usuario)

    Private Sub frmVista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar usuarios en modo conectado al iniciar el formulario
        CargarUsuarios()
    End Sub

    Private Sub CargarUsuarios()
        usuarios = negocio.ObtenerTodosLosUsuarios()
        dtwUsuarios.DataSource = usuarios
    End Sub

    ' Evento para insertar un nuevo usuario
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim nuevoUsuario As New Usuario() With {
            .name = txtName.Text,
            .email = txtEmail.Text
        }

        If negocio.AgregarUsuario(nuevoUsuario) Then
            MessageBox.Show("Usuario insertado correctamente.")
            CargarUsuarios() ' Recargar la lista de usuarios
        Else
            MessageBox.Show("Error al insertar el usuario.")
        End If
    End Sub

    ' Evento para actualizar un usuario existente
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If dtwUsuarios.CurrentRow IsNot Nothing Then
            Dim usuarioActualizado As New Usuario() With {
                .id = CInt(dtwUsuarios.CurrentRow.Cells("id").Value),
                .name = txtName.Text,
                .email = txtEmail.Text
            }

            If negocio.ModificarUsuario(usuarioActualizado) Then
                MessageBox.Show("Usuario actualizado correctamente.")
                CargarUsuarios() ' Recargar la lista de usuarios
            Else
                MessageBox.Show("Error al actualizar el usuario.")
            End If
        Else
            MessageBox.Show("Seleccione un usuario para actualizar.")
        End If
    End Sub

    ' Evento para eliminar un usuario
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dtwUsuarios.CurrentRow IsNot Nothing Then
            Dim usuarioId As Integer = CInt(dtwUsuarios.CurrentRow.Cells("id").Value)

            If negocio.BorrarUsuario(usuarioId) Then
                MessageBox.Show("Usuario eliminado correctamente.")
                CargarUsuarios() ' Recargar la lista de usuarios
            Else
                MessageBox.Show("Error al eliminar el usuario.")
            End If
        Else
            MessageBox.Show("Seleccione un usuario para eliminar.")
        End If
    End Sub

    Private Sub btnDesconectado_Click(sender As Object, e As EventArgs) Handles btnDesconectado.Click
        Dim frm As New Desconectado()
        Me.Hide()
        frm.Show()
    End Sub
End Class
