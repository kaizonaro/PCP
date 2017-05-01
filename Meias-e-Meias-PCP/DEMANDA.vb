Imports InnerLibs
Public Class DEMANDA
    Dim FullLoaded = False
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles PCP_QUANT_PE.ValueChanged, PCP_TEMPO_PE.ValueChanged, PCP_DH_ENTRADA.ValueChanged
        If FullLoaded Then
            ValidaDataUtil(PCP_DH_ENTRADA)

            Dim segundos = PCP_TEMPO_PE.Value.Second + (PCP_TEMPO_PE.Value.Minute * 60)
            Dim demand As New TimeDemand(PCP_DH_ENTRADA.Value, New TimeSpan(0, 0, segundos), PCP_QUANT_PE.Value)

            Dim hora_inicial = Today.AddHours(8)
            Dim jornada = New TimeSpan(14, 0, 0)

            demand.Monday.SetJourney(hora_inicial, jornada)
            demand.Tuesday.SetJourney(hora_inicial, jornada)
            demand.Wednesday.SetJourney(hora_inicial, jornada)
            demand.Thursday.SetJourney(hora_inicial, jornada)
            demand.Friday.SetJourney(hora_inicial, jornada)
            demand.Saturday.SetJourney(hora_inicial, jornada)

            Dim datafinal = demand.EndDate.AddDays(1)
            demand.GetPercentCompletion(Now)
            PCP_DH_SAIDA.MinDate = datafinal
            PCP_DH_SAIDA.Value = PCP_DH_SAIDA.MinDate

            Dim texto_estimativa = "Total de "
            Dim pares = PCP_QUANT_PE.Value / 2
            texto_estimativa.Append(pares & If(pares = 1, " par ", " pares "))
            Label8.Text = New TimeMachine(PCP_DH_ENTRADA.Value, datafinal).ToTimeElapsedString
            LABEL_ESTIMATIVA.Text = texto_estimativa.AdjustWhiteSpaces
        End If
    End Sub

    Private Sub DEMANDA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCP_TEMPO_PE.Value = QuickTime(0, 40)
        MOD_ID.SetPairDataSource(Modelos)
        MAL_ID.SetPairDataSource(Malhas)
        MAQ_ID.SetPairDataSource(Maquinas)
        CLI_ID.SetPairDataSource(Clientes)
        PCP_DH_ENTRADA.MinDate = Today
        PCP_DH_SAIDA.MinDate = Today
        FullLoaded = True
    End Sub



    Private Sub salvar_Click(sender As Object, e As EventArgs) Handles salvar.Click
        If PCP_PRIORIDADE.SelectedText.IsBlank Then
            PCP_PRIORIDADE.SelectedIndex = 1
        End If
        Enviar(0)
        Me.Close()
    End Sub

    Sub Enviar(ID As Integer)
        Dim command As String = ""
        If ID = 0 Then
            command.Append("INSERT INTO Demanda (CLI_ID,PCP_DH_PEDIDO,PCP_QUANT_PE,PCP_TEMPO_PE,MOD_ID,MAL_ID,MAQ_ID,PCP_DH_ENTRADA,PCP_DH_SAIDA,PCP_PRIORIDADE,PCP_STATUS,PCP_OBSERVACOES) values (")
            command.Append(CLI_ID.GetSelectedItemPair(Of Integer).Value.ToString.IsNull() & ",")
            command.Append(PCP_DH_PEDIDO.Value.ToSQLDateString.IsNull() & ",")
            command.Append(PCP_QUANT_PE.Value.ToString.IsNull() & ",")
            command.Append(PCP_TEMPO_PE.Value.ToSQLDateString.IsNull() & ",")
            command.Append(MOD_ID.GetSelectedItemPair(Of Integer).Value.ToString.IsNull() & ",")
            command.Append(MAL_ID.GetSelectedItemPair(Of Integer).Value.ToString.IsNull() & ",")
            command.Append(MAQ_ID.GetSelectedItemPair(Of Integer).Value.ToString.IsNull() & ",")
            command.Append(PCP_DH_ENTRADA.Value.ToSQLDateString.IsNull() & ",")
            command.Append(PCP_DH_SAIDA.Value.ToSQLDateString.IsNull() & ",")
            command.Append(PCP_PRIORIDADE.Text.IsNull() & ",")
            command.Append("Ativo".IsNull() & ",")
            command.Append(PCP_OBSERVACOES.Text.IsNull())
            command.Append(")")
        Else

        End If
        Banco.RunSQL(command)
    End Sub





    Sub ValidaDataUtil(Picker As DateTimePicker)
        If Picker.Value.DayOfWeek = DayOfWeek.Sunday Then
            Picker.Value = Picker.Value.AddDays(1)
        End If
        'If Picker.Value.DayOfWeek = DayOfWeek.Saturday Then
        '    Picker.Value = Picker.Value.AddDays(2)
        'End If
    End Sub


    Private Sub CLI_ID_LostFocus(sender As Object, e As EventArgs) Handles CLI_ID.LostFocus
        For Each cli In Clientes()
            If cli.Text = CLI_ID.Text Then
                Exit Sub
            End If
        Next
        Dim clid = CadastrarCliente(CLI_ID.Text)
        CLI_ID.SetPairDataSource(Clientes)
        CLI_ID.SelectedValue = clid

    End Sub

    Private Sub PCP_DH_SAIDA_ValueChanged(sender As Object, e As EventArgs) Handles PCP_DH_SAIDA.ValueChanged
        ValidaDataUtil(PCP_DH_SAIDA)
    End Sub
End Class