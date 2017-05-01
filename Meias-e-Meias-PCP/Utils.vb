Imports System.IO
Imports InnerLibs
Imports MySql.Data.MySqlClient

Module Utils
    Public HOME_FORM As Form = New HOME
    Public ConnectionString As String = ""
    Public dbpath As String = CurDir() & "\" & "db.cfg"
    Public USUARIO As New UsuarioClass


    Public Sub ValidateDatabase()
        Try
            If File.Exists(dbpath) Then ConnectionString = File.ReadAllText(dbpath).Decrypt
            If ConnectionString.IsBlank Then
                Alert("Banco de dados não está configurado!")
                Dim dialog As New OpenFileDialog()
                dialog.Filter = "Arquivos de configuração |*.cfg"
                dialog.Title = "Selecione o arquivo de configuração do banco de dados"
                If dialog.ShowDialog = DialogResult.OK Then
                    File.Copy(dialog.FileName, dbpath, True)
                    ConnectionString = File.ReadAllText(dbpath).Decrypt
                End If
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel conectar com o banco de dados!", MsgBoxStyle.Critical, "Erro!")
            Application.Exit()
        End Try

    End Sub


    Public Function Banco() As DataBase(Of MySqlConnection)
        ValidateDatabase()
        Return New DataBase(Of MySqlConnection)(ConnectionString)
    End Function


    Function QuickTime(Minute As Integer, Seconds As Integer) As DateTime

        Return New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, Minute, Seconds)
    End Function



    Function CalculaPreviaDemanda(DataInicio As DateTime, TempoAdd As DateTime) As DateTime

        Dim ts As New TimeSpan(TempoAdd.Ticks)
        Dim datafinal = DataInicio.Add(ts).AddDays(1)
        Dim relevante = New TimeMachine(DataInicio, datafinal, DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday)
        datafinal = datafinal.AddDays(relevante.NonRelevantDays.Count) 'adiciona a contagem dos dias nao letivos
        datafinal = datafinal.AddHours((24 - 8) * relevante.RelevantDays.Count) 'adiciona horas fora da jornada de trabalho de cada dia letivo
        If datafinal.DayOfWeek = DayOfWeek.Sunday Then
            datafinal = datafinal.AddDays(1)
        End If
        If datafinal.DayOfWeek = DayOfWeek.Saturday Then
            datafinal = datafinal.AddDays(2)
        End If


        Return datafinal

    End Function


    Function Malhas() As TextValueList(Of Integer)
        Return Banco.RunSQL("SELECT * FROM Malha").ToTextValueList(Of Integer)("MAL_TITULO", "MAL_ID")
    End Function

    Function Modelos() As TextValueList(Of Integer)
        Return Banco.RunSQL("SELECT * FROM Modelo").ToTextValueList(Of Integer)("MOD_TITULO", "MOD_ID")
    End Function

    Function Maquinas() As TextValueList(Of Integer)
        Return Banco.RunSQL("SELECT * FROM Maquina").ToTextValueList(Of Integer)("MAQ_TITULO", "MAQ_ID")
    End Function

    Function Clientes() As TextValueList(Of Integer)
        Return Banco.RunSQL("SELECT * FROM Cliente").ToTextValueList(Of Integer)("CLI_NOME", "CLI_ID")
    End Function

    Function Usuarios() As TextValueList(Of Integer)
        Return Banco.RunSQL("SELECT USU_ID, concat(USU_NOME,' ',USU_SOBRENOME) as USU_NOME FROM Usuario").ToTextValueList(Of Integer)("USU_NOME", "USU_ID")
    End Function

    Function CadastrarCliente(CLI_NOME As String) As Integer
        Dim reader As MySqlDataReader = Banco.RunSQL("INSERT INTO Cliente (CLI_NOME) values (" & CLI_NOME.IsNull & "); SELECT LAST_INSERT_ID();")
        While reader.Read
            Return reader(0)
        End While
        Return 0
    End Function

    Sub AjustarCronograma(DH_ENTRADA As DateTime, ID_MAQUINA As String, Tempo As TimeSpan, plus As Boolean)
        Dim cmd As String = "SELECT * From Demanda where MAQ_ID = " & ID_MAQUINA & " AND PCP_DH_ENTRADA >= STR_TO_DATE(" & DH_ENTRADA.ToSQLDateString.IsNull & ",'%Y-%m-%d %T')"
        Dim maquinas As MySqlDataReader = Banco.RunSQL(cmd)
        While maquinas.Read
            DH_ENTRADA = maquinas("PCP_DH_ENTRADA").ToString.To(Of Date)
            Dim DH_SAIDA = maquinas("PCP_DH_SAIDA").ToString.To(Of Date)
            DH_ENTRADA = If(plus, DH_ENTRADA.Add(Tempo), DH_ENTRADA.Subtract(Tempo))
            DH_SAIDA = If(plus, DH_SAIDA.Add(Tempo), DH_SAIDA.Subtract(Tempo))
            cmd = "UPDATE Demanda set PCP_DH_ENTRADA = " & DH_ENTRADA.ToSQLDateString.IsNull & ", PCP_DH_SAIDA = " & DH_SAIDA.ToSQLDateString.IsNull & " where PCP_ID = " & maquinas("PCP_ID").ToString
            Banco.RunSQL(cmd)
            Notify("Atualizando demanda #" & maquinas("PCP_ID").ToString)
        End While

    End Sub



    Sub ApagarDemanda(ID As String)
        Dim reader As MySqlDataReader = Banco.RunSQL("SELECT * from Demanda  where PCP_ID =  " & ID.IsNull)
        While reader.Read
            Dim DH_ENTRADA = reader("PCP_DH_ENTRADA").ToString.To(Of Date)
            Dim DH_SAIDA = reader("PCP_DH_SAIDA").ToString.To(Of Date)
            Dim ID_MAQUINA = reader("MAQ_ID").ToString
            Dim tempo = DH_SAIDA - DH_ENTRADA
            AjustarCronograma(DH_ENTRADA, ID_MAQUINA, tempo, False)
        End While
        Banco.RunSQL("DELETE FROM Demanda where PCP_ID =  " & ID.IsNull)
        Notify("Apagando demanda #" & ID)
    End Sub

End Module



Public Class UsuarioClass
    Property USU_NOME As String
    Property USU_EMAIL As String
    Property USU_ID As Integer

End Class
