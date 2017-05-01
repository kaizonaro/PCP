<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRIAR_USUARIO
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
        Me.USU_NOME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.USU_SOBRENOME = New System.Windows.Forms.TextBox()
        Me.USU_EMAIL = New System.Windows.Forms.TextBox()
        Me.USU_SENHA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.savebt = New System.Windows.Forms.Button()
        Me.apagabt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'USU_NOME
        '
        Me.USU_NOME.Location = New System.Drawing.Point(79, 12)
        Me.USU_NOME.Name = "USU_NOME"
        Me.USU_NOME.Size = New System.Drawing.Size(260, 20)
        Me.USU_NOME.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome"
        '
        'USU_SOBRENOME
        '
        Me.USU_SOBRENOME.Location = New System.Drawing.Point(79, 38)
        Me.USU_SOBRENOME.Name = "USU_SOBRENOME"
        Me.USU_SOBRENOME.Size = New System.Drawing.Size(260, 20)
        Me.USU_SOBRENOME.TabIndex = 1
        '
        'USU_EMAIL
        '
        Me.USU_EMAIL.Location = New System.Drawing.Point(79, 64)
        Me.USU_EMAIL.Name = "USU_EMAIL"
        Me.USU_EMAIL.Size = New System.Drawing.Size(260, 20)
        Me.USU_EMAIL.TabIndex = 2
        '
        'USU_SENHA
        '
        Me.USU_SENHA.Location = New System.Drawing.Point(79, 90)
        Me.USU_SENHA.Name = "USU_SENHA"
        Me.USU_SENHA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.USU_SENHA.Size = New System.Drawing.Size(260, 20)
        Me.USU_SENHA.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sobrenome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Senha"
        '
        'savebt
        '
        Me.savebt.Location = New System.Drawing.Point(262, 118)
        Me.savebt.Name = "savebt"
        Me.savebt.Size = New System.Drawing.Size(75, 23)
        Me.savebt.TabIndex = 4
        Me.savebt.Text = "Salvar"
        Me.savebt.UseVisualStyleBackColor = True
        '
        'apagabt
        '
        Me.apagabt.Location = New System.Drawing.Point(10, 118)
        Me.apagabt.Name = "apagabt"
        Me.apagabt.Size = New System.Drawing.Size(75, 23)
        Me.apagabt.TabIndex = 5
        Me.apagabt.Text = "Apagar"
        Me.apagabt.UseVisualStyleBackColor = True
        Me.apagabt.Visible = False
        '
        'CRIAR_USUARIO
        '
        Me.AcceptButton = Me.savebt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 150)
        Me.Controls.Add(Me.apagabt)
        Me.Controls.Add(Me.savebt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.USU_SENHA)
        Me.Controls.Add(Me.USU_EMAIL)
        Me.Controls.Add(Me.USU_SOBRENOME)
        Me.Controls.Add(Me.USU_NOME)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CRIAR_USUARIO"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Usuário"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents USU_NOME As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents USU_SOBRENOME As TextBox
    Friend WithEvents USU_EMAIL As TextBox
    Friend WithEvents USU_SENHA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents savebt As Button
    Friend WithEvents apagabt As Button
End Class
