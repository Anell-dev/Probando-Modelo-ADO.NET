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
        ' Desconectado
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(708, 450)
        Controls.Add(btnConectado)
        Controls.Add(dtwDesconectado)
        Name = "Desconectado"
        Text = "Desconectado"
        CType(dtwDesconectado, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dtwDesconectado As DataGridView
    Friend WithEvents btnConectado As Button
End Class
