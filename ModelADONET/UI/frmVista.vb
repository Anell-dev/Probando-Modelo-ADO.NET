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

        If String.IsNullOrEmpty(txtName.Text) Then
            MessageBox.Show("Porfavor llena el campo de nombre.")
            Return
        End If

        If String.IsNullOrEmpty(txtEmail.Text) Then
            MessageBox.Show("Porfavor Llena el campo de email.")
            Return
        End If

        Dim nuevoUsuario As New Usuario() With {
            .name = txtName.Text,
            .email = txtEmail.Text
        }

        If negocio.AgregarUsuario(nuevoUsuario) Then
            MessageBox.Show("Usuario insertado correctamente.")
            CargarUsuarios()
            txtName.Clear()
            txtEmail.Clear()
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

    End Sub
    Private Sub dtwUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtwUsuarios.CellClick

        If e.RowIndex >= 0 AndAlso dtwUsuarios.CurrentRow IsNot Nothing Then
            Dim id As Integer = CInt(dtwUsuarios.CurrentRow.Cells("id").Value)
            Dim name As String = dtwUsuarios.CurrentRow.Cells("name").Value.ToString()
            Dim email As String = dtwUsuarios.CurrentRow.Cells("email").Value.ToString()

            TextBox1.Text = id
            txtEmail.Text = email
            txtName.Text = name
        Else
            MessageBox.Show("Seleccione una fila válida.")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
