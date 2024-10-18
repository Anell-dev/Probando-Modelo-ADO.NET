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
        ' frmVista
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dtwUsuarios)
        Name = "frmVista"
        Text = "Form1"
        CType(dtwUsuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dtwUsuarios As DataGridView

End Class
