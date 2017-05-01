Imports InnerLibs


Public Class CLIENTE

    Property CLI_ID As Integer = 0
    Dim TabelaCliente As TableQuickConnector

    Private Sub CLIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabelaCliente = New TableQuickConnector("Cliente", Lista.ToArray)
        apagacliente.Visible = False
        If CLI_ID > 0 Then
            TravaForm(False)
            Banco.RunSQL(TabelaCliente, TableQuickConnector.Action.SELECT, "CLI_ID = " & CLI_ID)
            apagacliente.Visible = True
        End If
    End Sub

    Private Sub foca(sender As Object, e As EventArgs) Handles CLI_TELEFONE.GotFocus, CLI_TELEFONE.LostFocus
        CLI_TELEFONE.SetTelephoneMask
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles savebt.Click
        If savebt.Text = "Alterar" Then
            TravaForm(True)
            savebt.Text = "Salvar"
        Else
            If CLI_NOME.Text.IsNotBlank Then
                Banco.RunSQL(TabelaCliente.INSERTorUPDATE(CLI_ID, "CLI_ID"))
                Me.Close()
            Else
                Alert("Nome do Cliente está em branco!")
            End If
        End If

    End Sub

    Function TravaForm(Enable As Boolean) As List(Of Control)
        For Each c In Lista()
            c.Enabled = Enable
        Next
        Return Lista()
    End Function

    Function Lista() As List(Of Control)
        Lista = New List(Of Control)
        Lista.AddRange(Me.GetAllControls(Of TextBox))
        Lista.AddRange(Me.GetAllControls(Of MaskedTextBox))
        Lista.AddRange(Me.GetAllControls(Of ComboBox))
        Lista.AddRange(Me.GetAllControls(Of DateTimePicker))
        Return Lista
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles apagacliente.Click
        If Not Banco.RunSQL("SELECT CLI_ID from Demanda where CLI_ID = " & CLI_ID).HasRows Then
            If Confirm("Deseja realmente apagar este cliente?" & Environment.NewLine) Then
                Banco.RunSQL(TabelaCliente.DELETE("CLI_ID = " & CLI_ID))
                Me.Close()
            End If
        Else
            Alert("Você não pode apagar um cliente enquanto houverem demandas dele. Apague as demandas e tente novamente.")
        End If

    End Sub




End Class