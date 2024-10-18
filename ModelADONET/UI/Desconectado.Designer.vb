<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desconectado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dtwDesconectado = New DataGridView()
        btnConectado = New Button()
        btnEditarDesconectado = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        CType(dtwDesconectado, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtwDesconectado
        ' 
        dtwDesconectado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtwDesconectado.Location = New Point(256, 98)
        dtwDesconectado.Name = "dtwDesconectado"
        dtwDesconectado.Size = New Size(389, 214)
        dtwDesconectado.TabIndex = 0
        ' 
        ' btnConectado
        ' 
        btnConectado.Location = New Point(34, 405)
        btnConectado.Name = "btnConectado"
        btnConectado.Size = New Size(148, 23)
        btnConectado.TabIndex = 1
        btnConectado.Text = "Conectado"
        btnConectado.UseVisualStyleBackColor = True
        ' 
        ' btnEditarDesconectado
        ' 
        btnEditarDesconectado.Location = New Point(282, 404)
        btnEditarDesconectado.Name = "btnEditarDesconectado"
        btnEditarDesconectado.Size = New Size(75, 23)
        btnEditarDesconectado.TabIndex = 2
        btnEditarDesconectado.Text = "Actualizar"
        btnEditarDesconectado.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(24, 124)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Id"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(24, 188)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Name"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(24, 258)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Email"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 5
        ' 
        ' Desconectado
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(708, 450)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btnEditarDesconectado)
        Controls.Add(btnConectado)
        Controls.Add(dtwDesconectado)
        FormBorderStyle = FormBorderStyle.None
        Name = "Desconectado"
        Text = "Desconectado"
        CType(dtwDesconectado, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtwDesconectado As DataGridView
    Friend WithEvents btnConectado As Button
    Friend WithEvents btnEditarDesconectado As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
