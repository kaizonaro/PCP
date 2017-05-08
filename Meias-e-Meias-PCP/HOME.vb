Imports InnerLibs
Imports MySql.Data.MySqlClient

Public Class HOME

    Dim timercount As Integer = 0

    Private Sub HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        USER_MENU.Text = USUARIO.USU_NOME
        Notify(Greeting & " " & USUARIO.USU_NOME)
        AtualizarDemandas()
        AddClientes()
        AddUsuarios()
        AddMaquinas()

    End Sub

    Private Sub NovaDemandaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaDemandaToolStripMenuItem.Click
        Dim formi As New DEMANDA()
        AddHandler formi.FormClosed, AddressOf AtualizarDemandas
        formi.ShowDialog()
    End Sub

    Sub AtualizarDemandas()
        grade_demandas.Rows.Clear()
        Timer1.Stop()
        Dim Reader As DataBase.Reader = Banco.RunSQL("SELECT * FROM Demanda as D inner join Maquina as M on M.MAQ_ID = D.MAQ_ID inner join Malha as P on P.MAL_ID = D.MAL_ID inner join Modelo as A on A.MOD_ID = D.MOD_ID inner join Cliente as C on C.CLI_ID = D.CLI_ID order by PCP_STATUS, PCP_PRIORIDADE ASC, D.MAL_ID, PCP_DH_SAIDA")
        While Reader.Read
            Dim saida = Convert.ToDateTime(Reader("PCP_DH_SAIDA"))
            Dim entrada = Convert.ToDateTime(Reader("PCP_DH_ENTRADA"))

            Dim formato = "dddd, d/MM/yyyy HH:mm"
            Dim datapedido = Convert.ToDateTime(Reader("PCP_DH_PEDIDO")).ToString(formato)
            Dim dataentrada = entrada.ToString(formato)
            Dim datasaida = saida.ToString(formato)
            Dim PCP_STATUS = Reader("PCP_STATUS").ToString.ToLower

            If (PCP_STATUS = "ativo" And andamento.Checked) Or (PCP_STATUS = "finalizado" And concluidas.Checked) Then
                grade_demandas.Rows.Add(Reader("PCP_ID"), Reader("CLI_ID"), Reader("CLI_NOME"), datapedido, Reader("PCP_QUANT_PE"), Reader("PCP_TEMPO_PE"), Reader("MOD_ID"), Reader("MOD_TITULO"), Reader("MAL_ID"), Reader("MAL_TITULO"), Reader("MAQ_ID"), Reader("MAQ_TITULO"), dataentrada, 0, datasaida)
                Dim celula As InnerLibs.DataGridViewProgressCell = grade_demandas.Rows(grade_demandas.Rows.GetLastRow(DataGridViewElementStates.Visible)).Cells("PCP_ANDAMENTO")
                celula.ProgressColor = Color.Orange
            End If
        End While
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        For Each linha As DataGridViewRow In grade_demandas.Rows
            Dim data_inicio = linha.Cells()("PCP_DH_ENTRADA").Value.ToString.To(Of Date)
            Dim data_fim = linha.Cells()("PCP_DH_SAIDA").Value.ToString.To(Of Date)
            Dim p = Now.CalculatePercent(data_inicio, data_fim)
            linha.Cells()("PCP_ANDAMENTO").Value = p
            If p = 100 And Not linha.Cells(0).Style.BackColor = Color.Green Then
                Notify("Demanda " & linha.Cells()("PCP_ID").Value & " concluída")
                For Each celula As DataGridViewCell In linha.Cells
                    celula.Style.BackColor = Color.Green
                Next
                Banco.RunSQL("UPDATE Demanda set PCP_STATUS = 'Finalizado' where PCP_ID = " & linha.Cells()("PCP_ID").Value.ToString.IsNull)
            End If
        Next
        If timercount = 60 * 5 Then
            timercount = 0
            AtualizarDemandas()
        End If
        timercount.Increment
    End Sub

    Private Sub malmodbt_Click(sender As Object, e As EventArgs) Handles malmodbt.Click
        MEIAS.Show()
    End Sub



    Private Sub TrocarUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrocarUsuárioToolStripMenuItem.Click
        LOGIN.Show()
        USUARIO = New UsuarioClass
        Me.Close()
    End Sub



    Sub AddTempo(Tempo As TimeSpan, Add As Boolean)
        Dim ID_MAQUINA As Integer = grade_demandas.CurrentRow.Cells("MAQ_ID").Value
        Dim ID_DEMANDA As Integer = grade_demandas.CurrentRow.Cells("PCP_ID").Value
        Dim DH_ENTRADA = grade_demandas.CurrentRow.Cells("PCP_DH_ENTRADA").Value.ToString.To(Of DateTime)
        AjustarCronograma(DH_ENTRADA, ID_MAQUINA, Tempo, Add)
        AtualizarDemandas()
    End Sub


    Private Sub ApagarDemandaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApagarDemandaToolStripMenuItem.Click
        Try
            ApagarDemanda(grade_demandas.SelectedRows(0).Cells("PCP_ID").Value)
            AtualizarDemandas()
        Catch ex2 As ArgumentOutOfRangeException
            Alert("Selecione uma demanda!")
        Catch ex As Exception
            Alert(ex.Message)
        End Try
    End Sub

    Private Sub grade_demandas_CellClick(sender As Object, e As MouseEventArgs) Handles grade_demandas.MouseClick
        If IsNothing(grade_demandas.CurrentRow) Then Exit Sub
        If e.Button = MouseButtons.Right And grade_demandas.CurrentRow.Frozen = False Then
            Dim coluna As String = grade_demandas.CurrentCell.OwningColumn.Name
            Dim ID_DEMANDA As Integer = grade_demandas.CurrentRow.Cells("PCP_ID").Value
            Dim reader As DataBase.Reader = Banco.RunSQL("SELECT * from Demanda  where PCP_ID =  " & ID_DEMANDA.ToString.IsNull)
            reader.Read()
            Select Case coluna
                Case "PCP_DH_SAIDA", "PCP_DH_ENTRADA"
                    Using formi As New EditorHora
                        If formi.ShowDialog = DialogResult.OK Then
                            Dim DH_ENTRADA = reader("PCP_DH_ENTRADA").ToString.To(Of Date)
                            Dim DH_SAIDA = reader("PCP_DH_SAIDA").ToString.To(Of Date)
                            Dim ID_MAQUINA = reader("MAQ_ID").ToString
                            Dim tempo = formi.Tempo
                            If coluna = "PCP_DH_ENTRADA" Then If formi.AddTempo Then DH_ENTRADA.Add(tempo) Else DH_ENTRADA.Subtract(tempo)
                            If formi.AddTempo Then DH_SAIDA.Add(tempo) Else DH_SAIDA.Subtract(tempo)
                            AjustarCronograma(DH_ENTRADA, ID_MAQUINA, tempo, formi.AddTempo)
                        End If
                    End Using
                Case "CLI_NOME"
                    If reader("PCP_OBSERVACOES").ToString.IsNotBlank Then
                        Alert(reader("PCP_OBSERVACOES"))
                    End If
            End Select
            AtualizarDemandas()
        End If
    End Sub

    Private Sub concluidas_Click(sender As Object, e As EventArgs) Handles concluidas.Click, andamento.Click
        AtualizarDemandas()
    End Sub

    Sub AddClientes()
        menuclientes.DropDownItems.Clear()
        menuclientes.DropDownItems.Add(bt_addcliente)
        menuclientes.DropDownItems.Add(New ToolStripSeparator())
        For Each cli In Clientes()
            Dim cliente As New ToolStripMenuItem(cli.Text)
            cliente.ToolTipText = cli.Value
            AddHandler cliente.Click, AddressOf MostraCliente
            menuclientes.DropDownItems.Add(cliente)
        Next
    End Sub

    Sub AddUsuarios()
        menuusuarios.DropDownItems.Clear()
        For Each usu In Usuarios()
            Dim u As New ToolStripMenuItem(usu.Text)
            u.ToolTipText = usu.Value
            AddHandler u.Click, AddressOf mostrausuario
            menuusuarios.DropDownItems.Add(u)
        Next
    End Sub

    Private Sub MostraCliente(sender As Object, e As EventArgs)
        Dim formi As New CLIENTE()
        formi.CLI_ID = sender.ToolTipText
        formi.savebt.Text = "Alterar"
        AddHandler formi.FormClosed, AddressOf AddClientes
        formi.ShowDialog()
    End Sub

    Private Sub MostraMaquina(sender As Object, e As EventArgs)
        Dim formi As New MAQUINA()
        formi.MAQ_ID = sender.ToolTipText
        formi.savebt.Text = "Alterar"
        AddHandler formi.FormClosed, AddressOf AddMaquinas
        formi.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles bt_addcliente.Click
        Dim formi As New CLIENTE()
        AddHandler formi.FormClosed, AddressOf AddClientes
        formi.ShowDialog()
    End Sub

    Private Sub HOME_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        NotificationForm.DestroyNotifications()
    End Sub

    Private Sub ToolStripMenuItem3_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        MostraUsuario(USUARIO.USU_ID)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        MostraUsuario(0)
    End Sub

    Sub MostraUsuario(ID As Integer)
        Using formi As New CRIAR_USUARIO()
            formi.USU_ID = ID
            formi.ShowDialog()
            If formi.USU_ID > 0 Then
                formi.savebt.Text = "Alterar"
            End If
            AddHandler formi.FormClosed, AddressOf AddUsuarios
        End Using
    End Sub

    Sub mostrausuario(sender As Object, e As EventArgs)
        MostraUsuario(sender.ToolTipText)
    End Sub

    Sub AddMaquinas()
        maquinamenu.DropDownItems.Clear()
        maquinamenu.DropDownItems.Add(cadmaquina)
        maquinamenu.DropDownItems.Add(New ToolStripSeparator())
        For Each maq In Maquinas()
            Dim maquina As New ToolStripMenuItem(maq.Text)
            maquina.ToolTipText = maq.Value
            AddHandler maquina.Click, AddressOf MostraMaquina
            maquinamenu.DropDownItems.Add(maquina)
        Next
    End Sub

    Private Sub cadmaquina_Click(sender As Object, e As EventArgs) Handles cadmaquina.Click
        Dim formi As New MAQUINA()
        formi.MAQ_ID = 0
        AddHandler formi.FormClosed, AddressOf AddMaquinas
        formi.ShowDialog()
    End Sub

    Private Sub grade_demandas_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles grade_demandas.MouseDoubleClick

    End Sub

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case GAL_TAB.TabIndex
                TrazGaleria(FlowLayoutPanel1)
            Case Else
                AtualizarDemandas()
        End Select

    End Sub
End Class