Public Class FormDashboardGerencial
    Private Sub FormDashboardGerencial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nome.Text = sessao.Fields(1).Value
        lbl_cargo.Text = selecionar_cargo(sessao.Fields(2).Value)
        lbl_cpf.Text = sessao.Fields(3).Value
    End Sub

    Private Sub btn_caixa_Click(sender As Object, e As EventArgs) Handles btn_caixa.Click
        FormCaixa.Show()
        Close()
    End Sub

    Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        FormEstoque.Show()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormRelatorios.Show()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Dim resp = MsgBox("Deseja Sair?", vbQuestion + vbYesNo, "Pergunta")
        If resp = vbYes Then
            sessao = Nothing
            FormLogin.Show()
            Close()
        Else
            Exit Sub
        End If
    End Sub
End Class