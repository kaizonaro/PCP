Imports InnerLibs
Imports MySql.Data.MySqlClient

Public Class MEIAS
    Private Sub MEIAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarItens()
    End Sub


    Sub ListarItens()
        LISTA_MALHA.SetPairDataSource(Malhas)
        LISTA_MODELO.SetPairDataSource(Modelos)
    End Sub


    Sub EditarMalha()
        Me.Hide()
        Dim item = LISTA_MALHA.GetSelectedItemPair(Of Integer)
        Dim novo = "" & Prompt("Editando malha:", item.Text)
        novo.AppendIf(item.Text, novo.IsBlank)
        Banco.RunSQL("UPDATE Malha set MAL_TITULO = " & novo.IsNull() & " where MAL_ID = " & item.Value)
        LISTA_MALHA.SetPairDataSource(Malhas)
        Me.Show()
    End Sub

    Sub EditarModelo()
        Me.Hide()
        Dim item = LISTA_MODELO.GetSelectedItemPair(Of Integer)
        Dim novo = "" & Prompt("Editando modelo:", item.Text)
        novo.AppendIf(item.Text, novo.IsBlank)
        Banco.RunSQL("UPDATE Modelo set MOD_TITULO = " & novo.IsNull() & " where MOD_ID = " & item.Value)
        LISTA_MODELO.SetPairDataSource(Modelos)
        Me.Show()
    End Sub

    Sub InserirMalha()
        If Confirm("Deseja inserir a malha " & INPUT_MALHA.Text.Quote & " na lista? ") Then
            Banco.RunSQL("INSERT INTO Malha (MAL_TITULO) values (" & INPUT_MALHA.Text.IsNull() & ")")
            INPUT_MALHA.Clear()
        End If
        LISTA_MALHA.SetPairDataSource(Malhas)
    End Sub

    Sub InserirModelo()
        If Confirm("Deseja inserir o modelo " & INPUT_MODELO.Text.Quote & " na lista? ") Then
            Banco.RunSQL("INSERT INTO Modelo (MOD_TITULO) values (" & INPUT_MODELO.Text.IsNull() & ")")
            INPUT_MODELO.Clear()
        End If
        LISTA_MODELO.SetPairDataSource(Modelos)

    End Sub

    Sub ApagarMalha()
        Dim item = LISTA_MALHA.GetSelectedItemPair(Of Integer)
        If Confirm("Deseja realmente apagar a malha " & item.Text.Quote & "?" & Environment.NewLine & "Esta ação também vai apagar todas as demandas que utilizam esta malha!") Then
            Dim reader As MySqlDataReader = Banco.RunSQL("SELECT PCP_ID FROM Demanda where MAL_ID = " & item.Value.ToString.IsNull)
            While reader.Read
                ApagarDemanda(reader("PCP_ID"))
            End While
            Banco.RunSQL("DELETE FROM Malha where MAL_ID = " & item.Value.ToString.IsNull)
            LISTA_MALHA.SetPairDataSource(Malhas)
        End If
    End Sub

    Sub ApagarModelo()
        Dim item = LISTA_MODELO.GetSelectedItemPair(Of Integer)
        If Confirm("Deseja realmente apagar o modelo " & item.Text.Quote & "?" & Environment.NewLine & "Esta ação também vai apagar todas as demandas que utilizam este modelo!") Then
            Dim reader As MySqlDataReader = Banco.RunSQL("SELECT PCP_ID FROM Demanda where MOD_ID = " & item.Value.ToString.IsNull)
            While reader.Read
                ApagarDemanda(reader("PCP_ID"))
            End While
            Banco.RunSQL("DELETE FROM Modelo where MOD_ID = " & item.Value.ToString.IsNull)
            LISTA_MODELO.SetPairDataSource(Modelos)
        End If
    End Sub


    Private Sub LISTA_MODELO_SelectedIndexChanged(sender As Object, e As MouseEventArgs) Handles LISTA_MODELO.MouseDoubleClick
        EditarModelo()
    End Sub

    Private Sub LISTA_MALHA_SelectedIndexChanged(sender As Object, e As MouseEventArgs) Handles LISTA_MALHA.MouseDoubleClick
        EditarMalha()
    End Sub

    Private Sub SALVAR_MALHA_Click(sender As Object, e As EventArgs) Handles SALVAR_MALHA.Click
        InserirMalha()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InserirModelo()
    End Sub

    Private Sub EXCLUIR_MODELO_Click(sender As Object, e As EventArgs) Handles EXCLUIR_MODELO.Click
        ApagarModelo()
    End Sub

    Private Sub excluir_malha_Click(sender As Object, e As EventArgs) Handles excluir_malha.Click
        ApagarMalha()
    End Sub
End Class