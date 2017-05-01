Imports System.IO
Imports InnerLibs
Imports MySql.Data.MySqlClient

Public Class LOGIN


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        FazerLogin()
    End Sub


    Sub FazerLogin()
        If USU_EMAIL.Text.IsNotBlank And USU_EMAIL.Text.IsEmail Then
            If USU_SENHA.Text.IsNotBlank Then
                Dim Reader As MySqlDataReader = Banco.RunSQL("SELECT * FROM Usuario where USU_EMAIL = " & USU_EMAIL.Text.IsNull & " and USU_SENHA =  " & USU_SENHA.Text.ToMD5String.IsNull)
                If Reader.HasRows Then
                    While Reader.Read
                        USUARIO.USU_NOME = Reader("USU_NOME")
                        USUARIO.USU_EMAIL = Reader("USU_EMAIL")
                        USUARIO.USU_ID = Reader("USU_ID")
                        My.Settings.LastUser = USUARIO.USU_EMAIL
                        My.Settings.Save()
                        HOME.Show()
                        Me.Close()
                    End While
                Else
                    Alert("Usuário ou senha incorretos")
                    USU_SENHA.Select()
                    USU_SENHA.Clear()
                End If
            Else
                Alert("Preencha sua senha")
            End If
        Else
            Alert("Preencha seu email corretamente")
            USU_EMAIL.Select()
            USU_EMAIL.Clear()
        End If
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        USU_EMAIL.Text = My.Settings.LastUser
        If USU_EMAIL.Text.IsEmail Then
            USU_SENHA.Select()
        End If
    End Sub
End Class
