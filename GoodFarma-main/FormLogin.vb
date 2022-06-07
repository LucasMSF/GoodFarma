Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If verificar_campos() = True Then
            autenticar()
        Else
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
        End If
    End Sub

    Private Function login(usuario As String, senha As String)
        Try
            sql = "SELECT id, func_id FROM tb_usuarios WHERE login = '" & usuario & "' AND senha = '" & senha & "'"
            rs = db.Execute(sql)

            If Not rs.EOF = True Then
                sql = "SELECT * FROM tb_funcionarios WHERE id = " & rs.Fields(1).Value
                rs = db.Execute(sql)
                sessao = rs
                login = True
            Else
                login = False
            End If
        Catch ex As Exception
            MsgBox("Erro na autenticação:", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Autenticação")
            End
        End Try
    End Function

    Private Sub autenticar()
        If login(txt_usuario.Text, txt_senha.Text) = True Then
            MsgBox("Bem-vindo(a) " & sessao(1).Value & " !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Autenticação")
            Select Case sessao.Fields(2).Value
                Case 1
                    FormDashboardGerencial.Show()
                Case 2
                    FormDashboardFunc.Show()
            End Select
            Close()
        Else
            MsgBox("Usuário ou Senha incorretos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Autenticação")
            limpar()
        End If
    End Sub

    Private Sub limpar()
        txt_usuario.Text = ""
        txt_senha.Text = ""
        txt_usuario.Focus()
    End Sub

    Private Sub txt_senha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_senha.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If verificar_campos() = True Then
                autenticar()
            Else
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            End If
        End If
    End Sub

    Private Sub txt_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_usuario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If e.KeyChar = Convert.ToChar(13) Then
                If verificar_campos() = True Then
                    autenticar()
                Else
                    MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                End If
            End If
        End If
    End Sub

    Private Function verificar_campos()
        If txt_usuario.Text = "" Or txt_senha.Text = "" Then
            verificar_campos = False
        Else
            verificar_campos = True
        End If
    End Function
End Class