Public Class EditorHora

    Property Tempo As TimeSpan = New TimeSpan(0, 0, 0)
    Property AddTempo As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddBt.Click, RemBt.Click
        DialogResult = DialogResult.OK
        Tempo = New TimeSpan(Dias.Value, Horas.Value, Minutos.Value, 0, 0)
        AddTempo = (sender Is AddBt)
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CancelarBt.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub EditorHora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(MousePosition.X - Me.Width, MousePosition.Y)
    End Sub
End Class