Module ModGeral
    Public diretorio, sql As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dirBanco = Application.StartupPath
    Public sessao As ADODB.Recordset

    Sub conectar()
        Try
            db = CreateObject("ADODB.Connection")
            'String passada em aula: Provider=Microsoft.Jet.OLEDB.4.0
            db.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dirBanco & "db\goodfarma_db.mdb")
            'MsgBox("Conexão bem sucedida", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informação")
        Catch ex As Exception
            MsgBox("Erro na conexão com o banco. " + vbCrLf + ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informação")
        End Try
    End Sub

    Public Function selecionar_cargo(id As Integer)
        sql = "SELECT nome FROM tb_cargos WHERE id = " & id
        rs = db.Execute(sql)
        selecionar_cargo = rs.Fields(0).Value
    End Function
End Module
