Imports InnerLibs
Public Class MAQUINA

    Property MAQ_ID As Integer = 0
    Dim Maquinas As TableQuickConnector

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles savebt.Click
        Banco.RunSQL(Maquinas.INSERTorUPDATE(MAQ_ID, "MAQ_ID"))
        Me.Close()
    End Sub

    Private Sub MAQUINA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Maquinas = New TableQuickConnector("Maquina", MAQ_TITULO)

        If MAQ_ID > 0 Then
            delbt.Visible = True
            Banco.RunSQL(Maquinas, TableQuickConnector.Action.SELECT, "MAQ_ID=" & MAQ_ID)
        Else
            delbt.Visible = False
        End If

    End Sub

    Private Sub delbt_Click(sender As Object, e As EventArgs) Handles delbt.Click
        If Confirm("Deseja realmente apagar esta maquina?" & Environment.NewLine & "Esta ação também vai apagar todas as demandas desta maquina!") Then
            Banco.RunSQL(Maquinas, TableQuickConnector.Action.DELETE, "MAQ_ID=" & MAQ_ID)
        End If
        Me.Close()
    End Sub
End Class