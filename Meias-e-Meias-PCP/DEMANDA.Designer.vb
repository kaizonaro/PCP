<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DEMANDA
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CLI_ID = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MOD_ID = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MAL_ID = New System.Windows.Forms.ComboBox()
        Me.salvar = New System.Windows.Forms.Button()
        Me.PCP_DH_PEDIDO = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PCP_TEMPO_PE = New System.Windows.Forms.DateTimePicker()
        Me.PCP_QUANT_PE = New System.Windows.Forms.NumericUpDown()
        Me.LABEL_ESTIMATIVA = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DATAS = New System.Windows.Forms.GroupBox()
        Me.PCP_DH_SAIDA = New System.Windows.Forms.DateTimePicker()
        Me.PCP_DH_ENTRADA = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MAQ_ID = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PCP_OBSERVACOES = New System.Windows.Forms.RichTextBox()
        Me.PCP_PRIORIDADE = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PCP_QUANT_PE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DATAS.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cliente"
        '
        'CLI_ID
        '
        Me.CLI_ID.FormattingEnabled = True
        Me.CLI_ID.Location = New System.Drawing.Point(10, 25)
        Me.CLI_ID.Name = "CLI_ID"
        Me.CLI_ID.Size = New System.Drawing.Size(260, 21)
        Me.CLI_ID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Modelo"
        '
        'MOD_ID
        '
        Me.MOD_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MOD_ID.FormattingEnabled = True
        Me.MOD_ID.Location = New System.Drawing.Point(12, 40)
        Me.MOD_ID.Name = "MOD_ID"
        Me.MOD_ID.Size = New System.Drawing.Size(117, 21)
        Me.MOD_ID.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Malha"
        '
        'MAL_ID
        '
        Me.MAL_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MAL_ID.FormattingEnabled = True
        Me.MAL_ID.Location = New System.Drawing.Point(135, 40)
        Me.MAL_ID.Name = "MAL_ID"
        Me.MAL_ID.Size = New System.Drawing.Size(116, 21)
        Me.MAL_ID.TabIndex = 1
        '
        'salvar
        '
        Me.salvar.Location = New System.Drawing.Point(630, 253)
        Me.salvar.Name = "salvar"
        Me.salvar.Size = New System.Drawing.Size(143, 39)
        Me.salvar.TabIndex = 2
        Me.salvar.Text = "Cadastrar Demanda"
        Me.salvar.UseVisualStyleBackColor = True
        '
        'PCP_DH_PEDIDO
        '
        Me.PCP_DH_PEDIDO.Location = New System.Drawing.Point(11, 158)
        Me.PCP_DH_PEDIDO.Name = "PCP_DH_PEDIDO"
        Me.PCP_DH_PEDIDO.Size = New System.Drawing.Size(239, 20)
        Me.PCP_DH_PEDIDO.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Data do Pedido"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PCP_TEMPO_PE)
        Me.GroupBox1.Controls.Add(Me.PCP_QUANT_PE)
        Me.GroupBox1.Controls.Add(Me.PCP_DH_PEDIDO)
        Me.GroupBox1.Controls.Add(Me.MAL_ID)
        Me.GroupBox1.Controls.Add(Me.LABEL_ESTIMATIVA)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.MOD_ID)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 195)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Produto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tempo de Produção"
        '
        'PCP_TEMPO_PE
        '
        Me.PCP_TEMPO_PE.CustomFormat = "mm:ss"
        Me.PCP_TEMPO_PE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PCP_TEMPO_PE.Location = New System.Drawing.Point(135, 88)
        Me.PCP_TEMPO_PE.MaxDate = New Date(3017, 1, 15, 0, 0, 0, 0)
        Me.PCP_TEMPO_PE.MinDate = New Date(1900, 1, 14, 0, 0, 0, 0)
        Me.PCP_TEMPO_PE.Name = "PCP_TEMPO_PE"
        Me.PCP_TEMPO_PE.ShowUpDown = True
        Me.PCP_TEMPO_PE.Size = New System.Drawing.Size(116, 20)
        Me.PCP_TEMPO_PE.TabIndex = 6
        Me.PCP_TEMPO_PE.Value = New Date(2017, 1, 14, 0, 0, 0, 0)
        '
        'PCP_QUANT_PE
        '
        Me.PCP_QUANT_PE.Location = New System.Drawing.Point(12, 88)
        Me.PCP_QUANT_PE.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.PCP_QUANT_PE.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PCP_QUANT_PE.Name = "PCP_QUANT_PE"
        Me.PCP_QUANT_PE.Size = New System.Drawing.Size(120, 20)
        Me.PCP_QUANT_PE.TabIndex = 2
        Me.PCP_QUANT_PE.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LABEL_ESTIMATIVA
        '
        Me.LABEL_ESTIMATIVA.AutoSize = True
        Me.LABEL_ESTIMATIVA.Location = New System.Drawing.Point(13, 111)
        Me.LABEL_ESTIMATIVA.Name = "LABEL_ESTIMATIVA"
        Me.LABEL_ESTIMATIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LABEL_ESTIMATIVA.Size = New System.Drawing.Size(43, 13)
        Me.LABEL_ESTIMATIVA.TabIndex = 0
        Me.LABEL_ESTIMATIVA.Text = "PARES"
        Me.LABEL_ESTIMATIVA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tempo por Pé"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Quantidade de Pés"
        '
        'DATAS
        '
        Me.DATAS.Controls.Add(Me.PCP_DH_SAIDA)
        Me.DATAS.Controls.Add(Me.PCP_DH_ENTRADA)
        Me.DATAS.Controls.Add(Me.Label13)
        Me.DATAS.Controls.Add(Me.MAQ_ID)
        Me.DATAS.Controls.Add(Me.Label12)
        Me.DATAS.Controls.Add(Me.Label10)
        Me.DATAS.Location = New System.Drawing.Point(276, 54)
        Me.DATAS.Name = "DATAS"
        Me.DATAS.Size = New System.Drawing.Size(256, 193)
        Me.DATAS.TabIndex = 5
        Me.DATAS.TabStop = False
        Me.DATAS.Text = "Produção"
        '
        'PCP_DH_SAIDA
        '
        Me.PCP_DH_SAIDA.CustomFormat = "dddd, d/MM/yyyy HH:mm"
        Me.PCP_DH_SAIDA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PCP_DH_SAIDA.Location = New System.Drawing.Point(16, 156)
        Me.PCP_DH_SAIDA.Name = "PCP_DH_SAIDA"
        Me.PCP_DH_SAIDA.Size = New System.Drawing.Size(223, 20)
        Me.PCP_DH_SAIDA.TabIndex = 2
        '
        'PCP_DH_ENTRADA
        '
        Me.PCP_DH_ENTRADA.CustomFormat = "dddd, d/MM/yyyy HH:mm"
        Me.PCP_DH_ENTRADA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PCP_DH_ENTRADA.Location = New System.Drawing.Point(16, 109)
        Me.PCP_DH_ENTRADA.Name = "PCP_DH_ENTRADA"
        Me.PCP_DH_ENTRADA.Size = New System.Drawing.Size(223, 20)
        Me.PCP_DH_ENTRADA.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Data de Saída da Produção"
        '
        'MAQ_ID
        '
        Me.MAQ_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MAQ_ID.FormattingEnabled = True
        Me.MAQ_ID.Location = New System.Drawing.Point(16, 59)
        Me.MAQ_ID.Name = "MAQ_ID"
        Me.MAQ_ID.Size = New System.Drawing.Size(223, 21)
        Me.MAQ_ID.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Data de Início da Produção"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Máquina"
        '
        'PCP_OBSERVACOES
        '
        Me.PCP_OBSERVACOES.Location = New System.Drawing.Point(538, 58)
        Me.PCP_OBSERVACOES.Name = "PCP_OBSERVACOES"
        Me.PCP_OBSERVACOES.Size = New System.Drawing.Size(318, 189)
        Me.PCP_OBSERVACOES.TabIndex = 6
        Me.PCP_OBSERVACOES.Text = ""
        '
        'PCP_PRIORIDADE
        '
        Me.PCP_PRIORIDADE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PCP_PRIORIDADE.FormattingEnabled = True
        Me.PCP_PRIORIDADE.Items.AddRange(New Object() {"1 - Alta", "2 - Média", "3 - Baixa"})
        Me.PCP_PRIORIDADE.Location = New System.Drawing.Point(292, 25)
        Me.PCP_PRIORIDADE.Name = "PCP_PRIORIDADE"
        Me.PCP_PRIORIDADE.Size = New System.Drawing.Size(223, 21)
        Me.PCP_PRIORIDADE.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(289, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Prioridade"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(652, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Observações"
        '
        'DEMANDA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 298)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PCP_PRIORIDADE)
        Me.Controls.Add(Me.PCP_OBSERVACOES)
        Me.Controls.Add(Me.DATAS)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.salvar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CLI_ID)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DEMANDA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nova Demanda"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PCP_QUANT_PE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DATAS.ResumeLayout(False)
        Me.DATAS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents CLI_ID As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MOD_ID As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MAL_ID As ComboBox
    Friend WithEvents salvar As Button
    Friend WithEvents PCP_DH_PEDIDO As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PCP_QUANT_PE As NumericUpDown
    Friend WithEvents LABEL_ESTIMATIVA As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DATAS As GroupBox
    Friend WithEvents MAQ_ID As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PCP_TEMPO_PE As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents PCP_OBSERVACOES As RichTextBox
    Friend WithEvents PCP_PRIORIDADE As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PCP_DH_SAIDA As DateTimePicker
    Friend WithEvents PCP_DH_ENTRADA As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
End Class
