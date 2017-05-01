Imports InnerLibs
Imports MySql.Data.MySqlClient

Public Class CRIAR_USUARIO
    Dim UserConnection As TableQuickConnector

    Public Property USU_ID As Integer = 0

    Sub SalvarUsuario()


        If Validar() Then
            If USU_SENHA.Text.IsNotBlank Then
                USU_SENHA.Text = USU_SENHA.Text.Trim.ToMD5String
                UserConnection.AddColumns(USU_SENHA)
            End If
            Banco.RunSQL(UserConnection, TableQuickConnector.Action.INSERTorUPDATE, "USU_ID = " & USU_ID)
            If USU_ID = 0 Then
                ' manda email
                Notify("Usuário Criado")
            End If
            Me.Close()
            UserConnection.RemoveColumns(USU_SENHA)
        End If
        USU_SENHA.Clear()
    End Sub



    Private Sub CRIAR_USUARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserConnection = New TableQuickConnector("Usuario", USU_NOME, USU_SOBRENOME, USU_EMAIL)

        USU_NOME.Select()
        If USU_ID > 0 Then
            Banco.RunSQL(UserConnection, TableQuickConnector.Action.SELECT, "USU_ID = " & USU_ID)
            If Not USU_ID = USUARIO.USU_ID Then
                apagabt.Visible = True
            End If
        Else
            USU_SENHA.Text = RandomWord(8)
        End If

    End Sub

    Function Validar() As Boolean


        If (USU_SENHA.Text.Length > 0) Then
            If USU_SENHA.Text.Length < 8 Then
                Alert("Senha deve ter no mínimo 8 caracteres!")
                Return False
            End If
        Else
            If USU_ID = 0 Then
                Alert("Digite uma senha!")
                Return False
            End If
        End If

        If USU_EMAIL.Text.IsBlank Or Not USU_EMAIL.Text.IsEmail Then
            Alert("Preencha seu email corretamente!")
            Return False
        End If
        If USU_NOME.Text.IsBlank Or USU_SOBRENOME.Text.IsBlank Then
            Alert("Preencha seu nome e sobrenome!")
            Return False
        End If

        If Banco.RunSQL("SELECT USU_EMAIL from Usuario where USU_EMAIL = " & USU_EMAIL.Text.IsNull & " and USU_ID <> " & USU_ID).HasRows Then
            Alert("Este email já está em uso. Utilize outro endereço de email.")
            Return False
        End If


        Return True
    End Function

    Private Sub savebt_Click(sender As Object, e As EventArgs) Handles savebt.Click
        SalvarUsuario()
    End Sub

    Private Sub USU_SENHA_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles USU_SENHA.MouseDoubleClick
        USU_SENHA.PasswordChar.Toggle("*", "")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles apagabt.Click
        If Confirm("Tem certeza que deseja apagar este usuário? " & Environment.NewLine & " Esta ação não poderá ser desfeita!") Then
            Banco.RunSQL(UserConnection, TableQuickConnector.Action.DELETE, "USU_ID = " & USU_ID)
            Me.Close()
        End If
    End Sub
End Class