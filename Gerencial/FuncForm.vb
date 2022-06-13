Public Class FuncForm
    Private Sub FuncForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados()
    End Sub
    Sub carregar_dados(Optional sql As String = "SELECT f.id, f.nome, f.cpf, c.nome FROM tb_funcionarios as f INNER JOIN tb_cargos as c ON f.cargo = c.id")
        rs = db.Execute(sql)
        With data_func
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub
    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        carregar_dados("SELECT f.id, f.nome, f.cpf, c.nome FROM tb_funcionarios as f INNER JOIN tb_cargos as c ON f.cargo = c.id WHERE f.nome LIKE'" & txt_pesquisa.Text & "%' OR f.cpf LIKE '" & txt_pesquisa.Text & "%'")
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        FormCadFunc.Show()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        FormDashboardGerencial.Show()
        Close()
    End Sub
End Class