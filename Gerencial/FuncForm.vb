Public Class FuncForm
    Private Sub FuncForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados()
    End Sub
    Sub carregar_dados(Optional sql As String = "SELECT f.id, f.nome, f.cpf, c.nome, f.status FROM tb_funcionarios as f INNER JOIN tb_cargos as c ON f.cargo = c.id")
        rs = db.Execute(sql)
        With data_func
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, rs.Fields(4).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub
    Private Sub txt_pesquisa_TextChanged(sender As Object, e As EventArgs) Handles txt_pesquisa.TextChanged
        carregar_dados("SELECT f.id, f.nome, f.cpf, c.nome FROM tb_funcionarios as f INNER JOIN tb_cargos as c ON f.cargo = c.id WHERE f.nome LIKE'" & txt_pesquisa.Text & "%' OR f.cpf LIKE '" & txt_pesquisa.Text & "%'")
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        FormCadFunc.Show()
        Close()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        FormDashboardGerencial.Show()
        Close()
    End Sub

    Private Sub deleteFunc(id As String)
        Try
            sql = "SELECT id FROM tb_usuarios WHERE func_id = " & id
            rs = db.Execute(sql)

            sql = "DELETE FROM tb_usuarios WHERE id = " & rs.Fields(0).Value
            db.Execute(sql)

            sql = "DELETE FROM tb_funcionarios WHERE id = " & id
            db.Execute(sql)
            carregar_dados()
        Catch ex As Exception
            MsgBox("Erro no Banco de dados" & ex.Message, vbCritical + vbOKOnly, "Erro")
        End Try
    End Sub

    Private Sub data_func_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_func.CellContentDoubleClick
        With data_func
            If .CurrentRow.Cells(4).Selected Then
                sql = "SELECT login, senha FROM tb_usuarios WHERE func_id = " & .CurrentRow.Cells(0).Value
                rs = db.Execute(sql)

                FormCadFunc.popular_edicao(.CurrentRow.Cells(1).Value, .CurrentRow.Cells(2).Value, rs.Fields(0).Value, rs.Fields(1).Value, .CurrentRow.Cells(0).Value)
                FormCadFunc.Show()
                Close()
                Exit Sub
            End If
        End With
    End Sub

    Private Sub data_func_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_func.CellContentClick
        With data_func
            If .CurrentRow.Cells(5).Selected Then
                Try
                    sql = "UPDATE tb_funcionarios SET status = NOT status WHERE id = " & .CurrentRow.Cells(0).Value
                    db.Execute(sql)
                    .CurrentRow.Cells(5).Value = Not .CurrentRow.Cells(5).Value
                Catch ex As Exception
                    MsgBox("Erro no Banco de dados", vbCritical + vbOKOnly, "Erro")
                End Try
            End If
        End With
    End Sub
End Class