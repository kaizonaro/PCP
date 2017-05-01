<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MEIAS
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
        Me.LISTA_MALHA = New System.Windows.Forms.ListBox()
        Me.INPUT_MALHA = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.MALHA_TAB = New System.Windows.Forms.TabPage()
        Me.SALVAR_MALHA = New System.Windows.Forms.Button()
        Me.excluir_malha = New System.Windows.Forms.Button()
        Me.MODELO_TAB = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EXCLUIR_MODELO = New System.Windows.Forms.Button()
        Me.INPUT_MODELO = New System.Windows.Forms.TextBox()
        Me.LISTA_MODELO = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.MALHA_TAB.SuspendLayout()
        Me.MODELO_TAB.SuspendLayout()
        Me.SuspendLayout()
        '
        'LISTA_MALHA
        '
        Me.LISTA_MALHA.FormattingEnabled = True
        Me.LISTA_MALHA.Location = New System.Drawing.Point(9, 38)
        Me.LISTA_MALHA.Name = "LISTA_MALHA"
        Me.LISTA_MALHA.Size = New System.Drawing.Size(216, 95)
        Me.LISTA_MALHA.TabIndex = 0
        '
        'INPUT_MALHA
        '
        Me.INPUT_MALHA.Location = New System.Drawing.Point(6, 9)
        Me.INPUT_MALHA.Name = "INPUT_MALHA"
        Me.INPUT_MALHA.Size = New System.Drawing.Size(129, 20)
        Me.INPUT_MALHA.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.MALHA_TAB)
        Me.TabControl1.Controls.Add(Me.MODELO_TAB)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(241, 191)
        Me.TabControl1.TabIndex = 2
        '
        'MALHA_TAB
        '
        Me.MALHA_TAB.Controls.Add(Me.SALVAR_MALHA)
        Me.MALHA_TAB.Controls.Add(Me.excluir_malha)
        Me.MALHA_TAB.Controls.Add(Me.INPUT_MALHA)
        Me.MALHA_TAB.Controls.Add(Me.LISTA_MALHA)
        Me.MALHA_TAB.Location = New System.Drawing.Point(4, 22)
        Me.MALHA_TAB.Name = "MALHA_TAB"
        Me.MALHA_TAB.Padding = New System.Windows.Forms.Padding(3)
        Me.MALHA_TAB.Size = New System.Drawing.Size(233, 165)
        Me.MALHA_TAB.TabIndex = 0
        Me.MALHA_TAB.Text = "MALHAS"
        Me.MALHA_TAB.UseVisualStyleBackColor = True
        '
        'SALVAR_MALHA
        '
        Me.SALVAR_MALHA.Location = New System.Drawing.Point(144, 9)
        Me.SALVAR_MALHA.Name = "SALVAR_MALHA"
        Me.SALVAR_MALHA.Size = New System.Drawing.Size(81, 20)
        Me.SALVAR_MALHA.TabIndex = 2
        Me.SALVAR_MALHA.Text = "Salvar Malha"
        Me.SALVAR_MALHA.UseVisualStyleBackColor = True
        '
        'excluir_malha
        '
        Me.excluir_malha.Location = New System.Drawing.Point(144, 139)
        Me.excluir_malha.Name = "excluir_malha"
        Me.excluir_malha.Size = New System.Drawing.Size(81, 20)
        Me.excluir_malha.TabIndex = 2
        Me.excluir_malha.Text = "Excluir Malha"
        Me.excluir_malha.UseVisualStyleBackColor = True
        '
        'MODELO_TAB
        '
        Me.MODELO_TAB.Controls.Add(Me.Button1)
        Me.MODELO_TAB.Controls.Add(Me.EXCLUIR_MODELO)
        Me.MODELO_TAB.Controls.Add(Me.INPUT_MODELO)
        Me.MODELO_TAB.Controls.Add(Me.LISTA_MODELO)
        Me.MODELO_TAB.Location = New System.Drawing.Point(4, 22)
        Me.MODELO_TAB.Name = "MODELO_TAB"
        Me.MODELO_TAB.Padding = New System.Windows.Forms.Padding(3)
        Me.MODELO_TAB.Size = New System.Drawing.Size(233, 165)
        Me.MODELO_TAB.TabIndex = 1
        Me.MODELO_TAB.Text = "MODELOS"
        Me.MODELO_TAB.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 20)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Salvar Modelo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EXCLUIR_MODELO
        '
        Me.EXCLUIR_MODELO.Location = New System.Drawing.Point(126, 139)
        Me.EXCLUIR_MODELO.Name = "EXCLUIR_MODELO"
        Me.EXCLUIR_MODELO.Size = New System.Drawing.Size(99, 20)
        Me.EXCLUIR_MODELO.TabIndex = 6
        Me.EXCLUIR_MODELO.Text = "Excluir Modelo"
        Me.EXCLUIR_MODELO.UseVisualStyleBackColor = True
        '
        'INPUT_MODELO
        '
        Me.INPUT_MODELO.Location = New System.Drawing.Point(9, 9)
        Me.INPUT_MODELO.Name = "INPUT_MODELO"
        Me.INPUT_MODELO.Size = New System.Drawing.Size(111, 20)
        Me.INPUT_MODELO.TabIndex = 4
        '
        'LISTA_MODELO
        '
        Me.LISTA_MODELO.FormattingEnabled = True
        Me.LISTA_MODELO.Location = New System.Drawing.Point(9, 38)
        Me.LISTA_MODELO.Name = "LISTA_MODELO"
        Me.LISTA_MODELO.Size = New System.Drawing.Size(216, 95)
        Me.LISTA_MODELO.TabIndex = 3
        '
        'MEIAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 191)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MEIAS"
        Me.ShowInTaskbar = False
        Me.Text = "TIPOS DE MEIAS"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.MALHA_TAB.ResumeLayout(False)
        Me.MALHA_TAB.PerformLayout()
        Me.MODELO_TAB.ResumeLayout(False)
        Me.MODELO_TAB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LISTA_MALHA As ListBox
    Friend WithEvents INPUT_MALHA As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents MALHA_TAB As TabPage
    Friend WithEvents MODELO_TAB As TabPage
    Friend WithEvents SALVAR_MALHA As Button
    Friend WithEvents excluir_malha As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents EXCLUIR_MODELO As Button
    Friend WithEvents INPUT_MODELO As TextBox
    Friend WithEvents LISTA_MODELO As ListBox
End Class
