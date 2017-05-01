<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HOME
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.PCP_TAB = New System.Windows.Forms.TabPage()
        Me.grade_demandas = New System.Windows.Forms.DataGridView()
        Me.PCP_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLI_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLI_NOME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCP_DH_PEDIDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCP_QUANT_PE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCP_TEMPO_PE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOD_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOD_TITULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAL_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAL_TITULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAQ_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAQ_NOME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCP_DH_ENTRADA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCP_ANDAMENTO = New InnerLibs.DataGridViewProgressColumn()
        Me.PCP_DH_SAIDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.USER_MENU = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuusuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrocarUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuclientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.bt_addcliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.NOVOITEMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaDemandaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApagarDemandaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.concluidas = New System.Windows.Forms.ToolStripMenuItem()
        Me.andamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.maquinamenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.cadmaquina = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.malmodbt = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridViewProgressColumn1 = New InnerLibs.DataGridViewProgressColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.PCP_TAB.SuspendLayout()
        CType(Me.grade_demandas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.PCP_TAB)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(893, 446)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 0
        '
        'PCP_TAB
        '
        Me.PCP_TAB.Controls.Add(Me.grade_demandas)
        Me.PCP_TAB.Controls.Add(Me.MenuStrip1)
        Me.PCP_TAB.Location = New System.Drawing.Point(4, 24)
        Me.PCP_TAB.Name = "PCP_TAB"
        Me.PCP_TAB.Padding = New System.Windows.Forms.Padding(3)
        Me.PCP_TAB.Size = New System.Drawing.Size(885, 418)
        Me.PCP_TAB.TabIndex = 0
        Me.PCP_TAB.Text = "CRONOGRAMA"
        Me.PCP_TAB.UseVisualStyleBackColor = True
        '
        'grade_demandas
        '
        Me.grade_demandas.AllowUserToAddRows = False
        Me.grade_demandas.AllowUserToDeleteRows = False
        Me.grade_demandas.AllowUserToOrderColumns = True
        Me.grade_demandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grade_demandas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PCP_ID, Me.CLI_ID, Me.CLI_NOME, Me.PCP_DH_PEDIDO, Me.PCP_QUANT_PE, Me.PCP_TEMPO_PE, Me.MOD_ID, Me.MOD_TITULO, Me.MAL_ID, Me.MAL_TITULO, Me.MAQ_ID, Me.MAQ_NOME, Me.PCP_DH_ENTRADA, Me.PCP_ANDAMENTO, Me.PCP_DH_SAIDA})
        Me.grade_demandas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grade_demandas.Location = New System.Drawing.Point(3, 27)
        Me.grade_demandas.Name = "grade_demandas"
        Me.grade_demandas.ReadOnly = True
        Me.grade_demandas.Size = New System.Drawing.Size(879, 388)
        Me.grade_demandas.TabIndex = 2
        '
        'PCP_ID
        '
        Me.PCP_ID.HeaderText = "ID"
        Me.PCP_ID.Name = "PCP_ID"
        Me.PCP_ID.ReadOnly = True
        Me.PCP_ID.Visible = False
        '
        'CLI_ID
        '
        Me.CLI_ID.HeaderText = "CLI_ID"
        Me.CLI_ID.Name = "CLI_ID"
        Me.CLI_ID.ReadOnly = True
        Me.CLI_ID.Visible = False
        '
        'CLI_NOME
        '
        Me.CLI_NOME.HeaderText = "Cliente"
        Me.CLI_NOME.Name = "CLI_NOME"
        Me.CLI_NOME.ReadOnly = True
        '
        'PCP_DH_PEDIDO
        '
        Me.PCP_DH_PEDIDO.HeaderText = "Data do Pedido"
        Me.PCP_DH_PEDIDO.Name = "PCP_DH_PEDIDO"
        Me.PCP_DH_PEDIDO.ReadOnly = True
        '
        'PCP_QUANT_PE
        '
        Me.PCP_QUANT_PE.HeaderText = "Quantidade (Pé)"
        Me.PCP_QUANT_PE.Name = "PCP_QUANT_PE"
        Me.PCP_QUANT_PE.ReadOnly = True
        '
        'PCP_TEMPO_PE
        '
        Me.PCP_TEMPO_PE.HeaderText = "Tempo por Pé"
        Me.PCP_TEMPO_PE.Name = "PCP_TEMPO_PE"
        Me.PCP_TEMPO_PE.ReadOnly = True
        '
        'MOD_ID
        '
        Me.MOD_ID.HeaderText = "MOD_ID"
        Me.MOD_ID.Name = "MOD_ID"
        Me.MOD_ID.ReadOnly = True
        Me.MOD_ID.Visible = False
        '
        'MOD_TITULO
        '
        Me.MOD_TITULO.HeaderText = "Modelo"
        Me.MOD_TITULO.Name = "MOD_TITULO"
        Me.MOD_TITULO.ReadOnly = True
        '
        'MAL_ID
        '
        Me.MAL_ID.HeaderText = "MAL_ID"
        Me.MAL_ID.Name = "MAL_ID"
        Me.MAL_ID.ReadOnly = True
        Me.MAL_ID.Visible = False
        '
        'MAL_TITULO
        '
        Me.MAL_TITULO.HeaderText = "Malha"
        Me.MAL_TITULO.Name = "MAL_TITULO"
        Me.MAL_TITULO.ReadOnly = True
        '
        'MAQ_ID
        '
        Me.MAQ_ID.HeaderText = "MAQ_ID"
        Me.MAQ_ID.Name = "MAQ_ID"
        Me.MAQ_ID.ReadOnly = True
        Me.MAQ_ID.Visible = False
        '
        'MAQ_NOME
        '
        Me.MAQ_NOME.HeaderText = "Máquina"
        Me.MAQ_NOME.Name = "MAQ_NOME"
        Me.MAQ_NOME.ReadOnly = True
        '
        'PCP_DH_ENTRADA
        '
        Me.PCP_DH_ENTRADA.HeaderText = "Data e Hora de Entrada"
        Me.PCP_DH_ENTRADA.Name = "PCP_DH_ENTRADA"
        Me.PCP_DH_ENTRADA.ReadOnly = True
        '
        'PCP_ANDAMENTO
        '
        Me.PCP_ANDAMENTO.HeaderText = "Andamento"
        Me.PCP_ANDAMENTO.Name = "PCP_ANDAMENTO"
        Me.PCP_ANDAMENTO.ReadOnly = True
        '
        'PCP_DH_SAIDA
        '
        Me.PCP_DH_SAIDA.HeaderText = "Data e Hora de Saída"
        Me.PCP_DH_SAIDA.Name = "PCP_DH_SAIDA"
        Me.PCP_DH_SAIDA.ReadOnly = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USER_MENU, Me.menuclientes, Me.NOVOITEMToolStripMenuItem, Me.maquinamenu, Me.malmodbt})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(879, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'USER_MENU
        '
        Me.USER_MENU.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripSeparator2, Me.menuusuarios, Me.TrocarUsuárioToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.USER_MENU.Image = Global.InnerSocks.My.Resources.Resources.User_100px
        Me.USER_MENU.Name = "USER_MENU"
        Me.USER_MENU.Size = New System.Drawing.Size(62, 20)
        Me.USER_MENU.Text = "USER"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.InnerSocks.My.Resources.Resources.Create_New_100px
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem3.Text = "Editar Perfil"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'menuusuarios
        '
        Me.menuusuarios.Image = Global.InnerSocks.My.Resources.Resources.User_100px
        Me.menuusuarios.Name = "menuusuarios"
        Me.menuusuarios.Size = New System.Drawing.Size(152, 22)
        Me.menuusuarios.Text = "Editar Usuário"
        '
        'TrocarUsuárioToolStripMenuItem
        '
        Me.TrocarUsuárioToolStripMenuItem.Image = Global.InnerSocks.My.Resources.Resources.Change_User_Male_100px
        Me.TrocarUsuárioToolStripMenuItem.Name = "TrocarUsuárioToolStripMenuItem"
        Me.TrocarUsuárioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TrocarUsuárioToolStripMenuItem.Text = "Trocar Usuário"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.InnerSocks.My.Resources.Resources.Add_User_Male_100px
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "Novo Usuário"
        '
        'menuclientes
        '
        Me.menuclientes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bt_addcliente, Me.ToolStripSeparator3})
        Me.menuclientes.Image = Global.InnerSocks.My.Resources.Resources.Client_Company_100px
        Me.menuclientes.Name = "menuclientes"
        Me.menuclientes.Size = New System.Drawing.Size(77, 20)
        Me.menuclientes.Text = "Clientes"
        '
        'bt_addcliente
        '
        Me.bt_addcliente.Image = Global.InnerSocks.My.Resources.Resources.New_Company_100px
        Me.bt_addcliente.Name = "bt_addcliente"
        Me.bt_addcliente.Size = New System.Drawing.Size(143, 22)
        Me.bt_addcliente.Text = "Novo Cliente"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(140, 6)
        '
        'NOVOITEMToolStripMenuItem
        '
        Me.NOVOITEMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaDemandaToolStripMenuItem, Me.ApagarDemandaToolStripMenuItem, Me.ToolStripSeparator4, Me.ToolStripMenuItem2})
        Me.NOVOITEMToolStripMenuItem.Image = Global.InnerSocks.My.Resources.Resources.Feed_In_100px
        Me.NOVOITEMToolStripMenuItem.Name = "NOVOITEMToolStripMenuItem"
        Me.NOVOITEMToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.NOVOITEMToolStripMenuItem.Text = "Demandas"
        '
        'NovaDemandaToolStripMenuItem
        '
        Me.NovaDemandaToolStripMenuItem.Image = Global.InnerSocks.My.Resources.Resources.Create_New_100px
        Me.NovaDemandaToolStripMenuItem.Name = "NovaDemandaToolStripMenuItem"
        Me.NovaDemandaToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NovaDemandaToolStripMenuItem.Text = "Nova Demanda"
        '
        'ApagarDemandaToolStripMenuItem
        '
        Me.ApagarDemandaToolStripMenuItem.Image = Global.InnerSocks.My.Resources.Resources.Delete_100px
        Me.ApagarDemandaToolStripMenuItem.Name = "ApagarDemandaToolStripMenuItem"
        Me.ApagarDemandaToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ApagarDemandaToolStripMenuItem.Text = "Apagar Demanda"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(163, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.concluidas, Me.andamento})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuItem2.Text = "Exibir/Esconder"
        '
        'concluidas
        '
        Me.concluidas.Checked = True
        Me.concluidas.CheckOnClick = True
        Me.concluidas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.concluidas.Name = "concluidas"
        Me.concluidas.Size = New System.Drawing.Size(137, 22)
        Me.concluidas.Text = "Concluidas"
        '
        'andamento
        '
        Me.andamento.Checked = True
        Me.andamento.CheckOnClick = True
        Me.andamento.CheckState = System.Windows.Forms.CheckState.Checked
        Me.andamento.Name = "andamento"
        Me.andamento.Size = New System.Drawing.Size(137, 22)
        Me.andamento.Text = "Andamento"
        '
        'maquinamenu
        '
        Me.maquinamenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cadmaquina, Me.ToolStripSeparator1})
        Me.maquinamenu.Image = Global.InnerSocks.My.Resources.Resources.Needle_96px
        Me.maquinamenu.Name = "maquinamenu"
        Me.maquinamenu.Size = New System.Drawing.Size(87, 20)
        Me.maquinamenu.Text = "Máquinas"
        '
        'cadmaquina
        '
        Me.cadmaquina.Image = Global.InnerSocks.My.Resources.Resources.Create_New_100px
        Me.cadmaquina.Name = "cadmaquina"
        Me.cadmaquina.Size = New System.Drawing.Size(174, 22)
        Me.cadmaquina.Text = "Cadastrar Máquina"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        'malmodbt
        '
        Me.malmodbt.Image = Global.InnerSocks.My.Resources.Resources.Socks_100px
        Me.malmodbt.Name = "malmodbt"
        Me.malmodbt.Size = New System.Drawing.Size(131, 20)
        Me.malmodbt.Text = "Malhas e Modelos"
        '
        'DataGridViewProgressColumn1
        '
        Me.DataGridViewProgressColumn1.HeaderText = "Andamento"
        Me.DataGridViewProgressColumn1.Name = "DataGridViewProgressColumn1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'HOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 446)
        Me.Controls.Add(Me.TabControl1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HOME"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HOME"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.PCP_TAB.ResumeLayout(False)
        Me.PCP_TAB.PerformLayout()
        CType(Me.grade_demandas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PCP_TAB As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NOVOITEMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents maquinamenu As ToolStripMenuItem
    Friend WithEvents cadmaquina As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents grade_demandas As DataGridView
    Friend WithEvents NovaDemandaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApagarDemandaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USER_MENU As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TrocarUsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuclientes As ToolStripMenuItem
    Friend WithEvents bt_addcliente As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents PCP_ID As DataGridViewTextBoxColumn
    Friend WithEvents CLI_ID As DataGridViewTextBoxColumn
    Friend WithEvents CLI_NOME As DataGridViewTextBoxColumn
    Friend WithEvents PCP_DH_PEDIDO As DataGridViewTextBoxColumn
    Friend WithEvents PCP_QUANT_PE As DataGridViewTextBoxColumn
    Friend WithEvents PCP_TEMPO_PE As DataGridViewTextBoxColumn
    Friend WithEvents MOD_ID As DataGridViewTextBoxColumn
    Friend WithEvents MOD_TITULO As DataGridViewTextBoxColumn
    Friend WithEvents MAL_ID As DataGridViewTextBoxColumn
    Friend WithEvents MAL_TITULO As DataGridViewTextBoxColumn
    Friend WithEvents MAQ_ID As DataGridViewTextBoxColumn
    Friend WithEvents MAQ_NOME As DataGridViewTextBoxColumn
    Friend WithEvents PCP_DH_ENTRADA As DataGridViewTextBoxColumn
    Friend WithEvents PCP_ANDAMENTO As InnerLibs.DataGridViewProgressColumn
    Friend WithEvents PCP_DH_SAIDA As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewProgressColumn1 As InnerLibs.DataGridViewProgressColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents malmodbt As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents concluidas As ToolStripMenuItem
    Friend WithEvents andamento As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents menuusuarios As ToolStripMenuItem
End Class
