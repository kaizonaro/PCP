<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditorHora
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dias = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Horas = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Minutos = New System.Windows.Forms.NumericUpDown()
        Me.AddBt = New System.Windows.Forms.Button()
        Me.RemBt = New System.Windows.Forms.Button()
        Me.CancelarBt = New System.Windows.Forms.Button()
        CType(Me.Dias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dias"
        '
        'Dias
        '
        Me.Dias.Location = New System.Drawing.Point(58, 12)
        Me.Dias.Name = "Dias"
        Me.Dias.Size = New System.Drawing.Size(235, 20)
        Me.Dias.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Horas"
        '
        'Horas
        '
        Me.Horas.Location = New System.Drawing.Point(58, 38)
        Me.Horas.Name = "Horas"
        Me.Horas.Size = New System.Drawing.Size(235, 20)
        Me.Horas.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Minutos"
        '
        'Minutos
        '
        Me.Minutos.Location = New System.Drawing.Point(58, 64)
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Size = New System.Drawing.Size(235, 20)
        Me.Minutos.TabIndex = 2
        '
        'AddBt
        '
        Me.AddBt.Location = New System.Drawing.Point(58, 90)
        Me.AddBt.Name = "AddBt"
        Me.AddBt.Size = New System.Drawing.Size(75, 23)
        Me.AddBt.TabIndex = 3
        Me.AddBt.Text = "Adicionar"
        Me.AddBt.UseVisualStyleBackColor = True
        '
        'RemBt
        '
        Me.RemBt.Location = New System.Drawing.Point(139, 90)
        Me.RemBt.Name = "RemBt"
        Me.RemBt.Size = New System.Drawing.Size(75, 23)
        Me.RemBt.TabIndex = 3
        Me.RemBt.Text = "Remover"
        Me.RemBt.UseVisualStyleBackColor = True
        '
        'CancelarBt
        '
        Me.CancelarBt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelarBt.Location = New System.Drawing.Point(220, 90)
        Me.CancelarBt.Name = "CancelarBt"
        Me.CancelarBt.Size = New System.Drawing.Size(75, 23)
        Me.CancelarBt.TabIndex = 4
        Me.CancelarBt.Text = "Cancelar"
        Me.CancelarBt.UseVisualStyleBackColor = True
        '
        'EditorHora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelarBt
        Me.ClientSize = New System.Drawing.Size(305, 122)
        Me.Controls.Add(Me.CancelarBt)
        Me.Controls.Add(Me.RemBt)
        Me.Controls.Add(Me.AddBt)
        Me.Controls.Add(Me.Minutos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Horas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Dias)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditorHora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Adicionar/Remover Horas"
        CType(Me.Dias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Dias As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Horas As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Minutos As NumericUpDown
    Friend WithEvents AddBt As Button
    Friend WithEvents RemBt As Button
    Friend WithEvents CancelarBt As Button
End Class
