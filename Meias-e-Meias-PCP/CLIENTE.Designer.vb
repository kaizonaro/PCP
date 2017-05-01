<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLIENTE
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
        Me.CLI_NOME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CLI_TELEFONE = New System.Windows.Forms.MaskedTextBox()
        Me.CLI_CONTATO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.apagacliente = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CLI_DH_CADASTRO = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CLI_CNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'savebt
        '
        Me.savebt.Location = New System.Drawing.Point(470, 111)
        Me.savebt.Name = "savebt"
        Me.savebt.Size = New System.Drawing.Size(88, 23)
        Me.savebt.TabIndex = 6
        Me.savebt.Text = "Salvar"
        Me.savebt.UseVisualStyleBackColor = True
        '
        'CLI_NOME
        '
        Me.CLI_NOME.Location = New System.Drawing.Point(116, 14)
        Me.CLI_NOME.Name = "CLI_NOME"
        Me.CLI_NOME.Size = New System.Drawing.Size(158, 20)
        Me.CLI_NOME.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cliente"
        '
        'CLI_TELEFONE
        '
        Me.CLI_TELEFONE.Location = New System.Drawing.Point(400, 38)
        Me.CLI_TELEFONE.Name = "CLI_TELEFONE"
        Me.CLI_TELEFONE.Size = New System.Drawing.Size(158, 20)
        Me.CLI_TELEFONE.TabIndex = 5
        '
        'CLI_CONTATO
        '
        Me.CLI_CONTATO.Location = New System.Drawing.Point(400, 12)
        Me.CLI_CONTATO.Name = "CLI_CONTATO"
        Me.CLI_CONTATO.Size = New System.Drawing.Size(158, 20)
        Me.CLI_CONTATO.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contato do Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefone do Cliente"
        '
        'apagacliente
        '
        Me.apagacliente.Location = New System.Drawing.Point(12, 111)
        Me.apagacliente.Name = "apagacliente"
        Me.apagacliente.Size = New System.Drawing.Size(105, 23)
        Me.apagacliente.TabIndex = 7
        Me.apagacliente.Text = "Apagar Cliente"
        Me.apagacliente.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "CNPJ"
        '
        'CLI_DH_CADASTRO
        '
        Me.CLI_DH_CADASTRO.Location = New System.Drawing.Point(116, 66)
        Me.CLI_DH_CADASTRO.Name = "CLI_DH_CADASTRO"
        Me.CLI_DH_CADASTRO.Size = New System.Drawing.Size(158, 20)
        Me.CLI_DH_CADASTRO.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Data de Cadastro"
        '
        'CLI_CNPJ
        '
        Me.CLI_CNPJ.Location = New System.Drawing.Point(116, 39)
        Me.CLI_CNPJ.Mask = "99,999,999/9999-99"
        Me.CLI_CNPJ.Name = "CLI_CNPJ"
        Me.CLI_CNPJ.Size = New System.Drawing.Size(158, 20)
        Me.CLI_CNPJ.TabIndex = 1
        '
        'CLIENTE
        '
        Me.AcceptButton = Me.savebt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 142)
        Me.Controls.Add(Me.CLI_CNPJ)
        Me.Controls.Add(Me.CLI_DH_CADASTRO)
        Me.Controls.Add(Me.apagacliente)
        Me.Controls.Add(Me.CLI_TELEFONE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CLI_CONTATO)
        Me.Controls.Add(Me.CLI_NOME)
        Me.Controls.Add(Me.savebt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CLIENTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENTE"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents savebt As Button
    Friend WithEvents CLI_NOME As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CLI_TELEFONE As MaskedTextBox
    Friend WithEvents CLI_CONTATO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents apagacliente As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CLI_DH_CADASTRO As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents CLI_CNPJ As MaskedTextBox
End Class
