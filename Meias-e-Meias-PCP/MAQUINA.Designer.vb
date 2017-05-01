<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAQUINA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.savebt = New System.Windows.Forms.Button()
        Me.MAQ_TITULO = New System.Windows.Forms.TextBox()
        Me.delbt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'savebt
        '
        Me.savebt.Location = New System.Drawing.Point(191, 52)
        Me.savebt.Name = "savebt"
        Me.savebt.Size = New System.Drawing.Size(75, 23)
        Me.savebt.TabIndex = 1
        Me.savebt.Text = "Salvar"
        Me.savebt.UseVisualStyleBackColor = True
        '
        'MAQ_TITULO
        '
        Me.MAQ_TITULO.Location = New System.Drawing.Point(12, 26)
        Me.MAQ_TITULO.Name = "MAQ_TITULO"
        Me.MAQ_TITULO.Size = New System.Drawing.Size(254, 20)
        Me.MAQ_TITULO.TabIndex = 2
        '
        'delbt
        '
        Me.delbt.Location = New System.Drawing.Point(12, 52)
        Me.delbt.Name = "delbt"
        Me.delbt.Size = New System.Drawing.Size(75, 23)
        Me.delbt.TabIndex = 3
        Me.delbt.Text = "Excluir"
        Me.delbt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nome da Máquina"
        '
        'MAQUINA
        '
        Me.AcceptButton = Me.savebt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 81)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.delbt)
        Me.Controls.Add(Me.MAQ_TITULO)
        Me.Controls.Add(Me.savebt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MAQUINA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAQUINA"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents savebt As Button
    Friend WithEvents MAQ_TITULO As TextBox
    Friend WithEvents delbt As Button
    Friend WithEvents Label1 As Label
End Class
