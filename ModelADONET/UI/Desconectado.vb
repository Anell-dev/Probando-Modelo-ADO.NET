Imports BLL
Imports Entities
Imports System.Data
Public Class Desconectado
    Private negociode As New Negocio()
    Private usuariosDataSet As DataSet ' Variable para almacenar los datos desconectados

    'Private negocio As New Negocio()
    Private usuarios As List(Of Usuario)

    Private Sub Desconectado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuariosDataSet = negociode.ObtenerUsuariosDesconectado()
        dtwDesconectado.DataSource = usuariosDataSet.Tables("Usuarios")
    End Sub

    Private Sub CargarUsuarios()
        usuarios = negociode.ObtenerTodosLosUsuarios()
        dtwDesconectado.DataSource = usuarios
    End Sub

    Private Sub btnConectado_Click(sender As Object, e As EventArgs) Handles btnConectado.Click
        Dim frm As New frmVista()
        Me.Hide()
        frm.Show()
    End Sub

    Private Sub btnEditarDesconectado_Click(sender As Object, e As EventArgs) Handles btnEditarDesconectado.Click

        If String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("Porfavor llena el campo de nombre.")
            Return
        End If

        If String.IsNullOrEmpty(TextBox3.Text) Then
            MessageBox.Show("Porfavor Llena el campo de email.")
            Return
        End If


        If dtwDesconectado.CurrentRow IsNot Nothing Then
            Dim usuarioActualizado As New Usuario() With {
                .id = CInt(dtwDesconectado.CurrentRow.Cells("id").Value),
                .name = TextBox2.Text,
                .email = TextBox3.Text
            }

            If negociode.ActualizacionBDdesconectado(usuarioActualizado) Then
                MessageBox.Show("Usuario actualizado correctamente.")
                CargarUsuarios() ' Recargar la lista de usuarios
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
            Else
                MessageBox.Show("Error al actualizar el usuario.")
            End If
        Else
            MessageBox.Show("Seleccione un usuario para actualizar.")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub dtwDesconectado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtwDesconectado.CellClick
        If e.RowIndex >= 0 AndAlso dtwDesconectado.CurrentRow IsNot Nothing Then
            Dim id As Integer = CInt(dtwDesconectado.CurrentRow.Cells("id").Value)
            Dim name As String = dtwDesconectado.CurrentRow.Cells("name").Value.ToString()
            Dim email As String = dtwDesconectado.CurrentRow.Cells("email").Value.ToString()

            TextBox1.Text = id
            TextBox2.Text = name
            TextBox3.Text = email

        Else
            MessageBox.Show("Seleccione una fila válida.")
        End If

    End Sub


End Class