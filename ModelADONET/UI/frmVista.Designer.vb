<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVista
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dtwUsuarios = New DataGridView()
        btnDesconectado = New Button()
        btnInsertar = New Button()
        btnActualizar = New Button()
        btnEliminar = New Button()
        TextBox1 = New TextBox()
        txtName = New TextBox()
        txtEmail = New TextBox()
        btnCerrar = New Button()
        CType(dtwUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtwUsuarios
        ' 
        dtwUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtwUsuarios.Location = New Point(285, 63)
        dtwUsuarios.Name = "dtwUsuarios"
        dtwUsuarios.Size = New Size(455, 244)
        dtwUsuarios.TabIndex = 0
        ' 
        ' btnDesconectado
        ' 
        btnDesconectado.Location = New Point(42, 394)
        btnDesconectado.Name = "btnDesconectado"
        btnDesconectado.Size = New Size(138, 44)
        btnDesconectado.TabIndex = 1
        btnDesconectado.Text = "Modo Desconectado"
        btnDesconectado.UseVisualStyleBackColor = True
        ' 
        ' btnInsertar
        ' 
        btnInsertar.Location = New Point(296, 374)
        btnInsertar.Name = "btnInsertar"
        btnInsertar.Size = New Size(75, 23)
        btnInsertar.TabIndex = 2
        btnInsertar.Text = "Insertar"
        btnInsertar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(394, 374)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(75, 23)
        btnActualizar.TabIndex = 3
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(499, 374)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 4
        btnEliminar.Text = "Borrar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(54, 92)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "ID"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 5
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(54, 150)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Name"
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(54, 209)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(100, 23)
        txtEmail.TabIndex = 7
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(678, 386)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(87, 52)
        btnCerrar.TabIndex = 8
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' frmVista
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCerrar)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(TextBox1)
        Controls.Add(btnEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnInsertar)
        Controls.Add(btnDesconectado)
        Controls.Add(dtwUsuarios)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmVista"
        Text = "Form1"
        CType(dtwUsuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtwUsuarios As DataGridView
    Friend WithEvents btnDesconectado As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnCerrar As Button

End Class
