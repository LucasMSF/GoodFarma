Public Class FormCadFunc
    Private Sub FormCadFunc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_cmb()
    End Sub

    Sub carregar_cmb(Optional sql = "SELECT nome FROM tb_cargos")
        rs = db.Execute(sql)
        With cmb_cargos
            .Items.Clear()
            While (rs.EOF = False)
                .Items.Add(rs.Fields(0).Value)
                rs.MoveNext()
            End While
        End With
    End Sub

    Sub addFunc(nome As String, cargo As String, cpf As String, usuario As String, senha As String)
        Try
            If verificar_registro(cpf) = False Then
                Throw New Exception("Funcionário existente")
            End If

            rs = db.Execute("SELECT id FROM tb_cargos WHERE nome = '" & cargo & "'")
            Dim idCargo = rs.Fields(0).Value

            sql = "INSERT INTO tb_funcionarios (nome, cargo, cpf) VALUES ('" & nome & "'," & idCargo & ",'" & cpf & "')"
            db.Execute(sql)

            rs = db.Execute("SELECT @@identity AS novoFunc")
            Dim idFunc = rs.Fields("novoFunc").Value

            sql = "INSERT INTO tb_usuarios (login, senha, func_id) VALUES ('" & usuario & "','" & senha & "','" & idFunc & "')"
            db.Execute(sql)

            MsgBox("Funcionário cadastrado com sucesso!", vbInformation + vbOKOnly, "Cadastro")
            FuncForm.carregar_dados()
            limpar()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar usuário!" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Erro")
        End Try

    End Sub

    Sub editFunc(nome As String, cargo As String, cpf As String, usuario As String, senha As String, id As Integer)
        Try
            sql = "UPDATE tb_usuarios SET login = '" & usuario & "', senha = '" & senha & "' WHERE func_id = " & id
            db.Execute(sql)

            sql = "SELECT id FROM tb_cargos WHERE nome = '" & cargo & "'"
            rs = db.Execute(sql)

            sql = "UPDATE tb_funcionarios SET nome = '" & nome & "', cpf = '" & cpf & "', cargo = '" & rs.Fields(0).Value & "' WHERE id = " & id
            db.Execute(sql)

            MsgBox("Funcionário atualizado com sucesso!", vbInformation + vbOKOnly, "Cadastro")
            FuncForm.carregar_dados()
            limpar()
            trocar_botoes()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar usuário!" & vbCrLf & ex.Message, vbCritical + vbOKOnly, "Erro")
        End Try

    End Sub

    Sub limpar()
        txt_nome.Text = Nothing
        txt_cpf.Text = Nothing
        txt_usuario.Text = Nothing
        txt_senha.Text = Nothing
        txt_nome.Focus()
    End Sub

    Function verificar_registro(cpf As String)
        sql = "SELECT id from tb_funcionarios WHERE cpf = '" & cpf & "'"
        rs = db.Execute(sql)
        If rs.EOF = True Then
            verificar_registro = True
        Else
            verificar_registro = False
        End If
    End Function

    Function verificar_campos()
        If txt_nome.Text = Nothing Or txt_cpf.MaskCompleted = False Or cmb_cargos.Text = Nothing Or txt_usuario.Text = Nothing Or txt_senha.Text = Nothing Then
            verificar_campos = False
        Else
            verificar_campos = True
        End If
    End Function

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If verificar_campos() = True Then
            addFunc(txt_nome.Text, cmb_cargos.Text, txt_cpf.Text, txt_usuario.Text, txt_senha.Text)
        Else
            MsgBox("Dados inválidos!" & vbCrLf & "Revise os campos", vbCritical + vbOKOnly, "Erro")
        End If
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        FuncForm.Show()
        Close()
    End Sub

    Sub popular_edicao(nome As String, cpf As String, usuario As String, senha As String, id As Integer)
        txt_nome.Text = nome
        txt_cpf.Text = cpf
        txt_usuario.Text = usuario
        txt_senha.Text = senha
        txt_id.Text = id
        trocar_botoes()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If verificar_campos() = True Then
            editFunc(txt_nome.Text, cmb_cargos.Text, txt_cpf.Text, txt_usuario.Text, txt_senha.Text, txt_id.Text)
        Else
            MsgBox("Dados inválidos!" & vbCrLf & "Revise os campos", vbCritical + vbOKOnly, "Erro")
        End If
    End Sub

    Private Sub trocar_botoes()
        If btn_editar.Visible = False Then
            btn_cadastrar.Visible = False
            btn_editar.Visible = True
        Else
            btn_cadastrar.Visible = True
            btn_editar.Visible = False
        End If
    End Sub
End Class