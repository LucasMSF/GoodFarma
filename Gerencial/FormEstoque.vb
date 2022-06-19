Public Class FormEstoque
    Private Sub FormEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_produtos(data_items)
    End Sub

    Private Sub carregar_produtos(grid As DataGridView, Optional sql As String = "SELECT * from tb_produtos ORDER BY nome DESC")
        rs = db.Execute(sql)
        With grid
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, "R$ " & rs.Fields(2).Value, rs.Fields(3).Value, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If sessao(2).Value = 1 Then
            FormDashboardGerencial.Show()
        Else
            FormDashboardFunc.Show()
        End If
        Close()
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If verificar_campos() = True Then
            addProduct(txt_produto.Text, FormatNumber(txt_valor.Text, 2), txt_qtde.Text)
            carregar_produtos(data_items)
            limpar()
        Else
            MsgBox("Dados inválidos!" & vbCrLf & "Revise os campos", vbCritical + vbOKOnly, "Erro")
        End If
    End Sub

    Private Sub addProduct(nome As String, valor As Double, qtd As Integer)
        Try
            sql = "INSERT INTO tb_produtos (nome, valor_unitario, qtd_estoque) VALUES ('" & nome & "', " & Replace(valor, ",", ".") & ", " & qtd & ")"
            db.Execute(sql)
            MsgBox("Produto adicionado ao estoque", vbInformation + vbOKOnly, "Informação")
        Catch ex As Exception
            MsgBox("Erro no Banco de dados", vbCritical + vbOKOnly, "Erro")
        End Try
    End Sub

    Private Sub editProduct(id As Integer, nome As String, valor As Double, qtd As Integer)
        Try
            sql = "UPDATE tb_produtos SET nome = '" & nome & "', valor_unitario = " & Replace(valor, ",", ".") & ", qtd_estoque = " & qtd & " WHERE id = " & id
            db.Execute(sql)
            MsgBox("Produto atualizado no estoque", vbInformation + vbOKOnly, "Informação")
            estado_btn(False)
            carregar_produtos(data_items)
            limpar()
        Catch ex As Exception
            MsgBox("Erro no Banco de dados", vbCritical + vbOKOnly, "Erro")
            MsgBox(ex.Message, vbCritical + vbOKOnly, "Erro")
        End Try
    End Sub

    Private Sub deleteProduct(id As Integer)
        Try
            sql = "DELETE FROM tb_produtos WHERE id = " & id
            db.Execute(sql)
            MsgBox("Produto descartado do estoque", vbInformation + vbOKOnly, "Informação")
        Catch ex As Exception
            MsgBox("Erro no Banco de dados", vbCritical + vbOKOnly, "Erro")
            MsgBox(ex.Message, vbCritical + vbOKOnly, "Erro")
        End Try
    End Sub

    Private Function verificar_campos()
        If txt_produto Is Nothing Or txt_valor Is Nothing Or txt_qtde Is Nothing Or Not IsNumeric(txt_valor.Text) Or Not IsNumeric(txt_qtde.Text) Then
            verificar_campos = False
            Exit Function
        End If
        verificar_campos = True
    End Function

    Private Sub limpar()
        txt_produto.Text = Nothing
        txt_valor.Text = Nothing
        txt_qtde.Text = Nothing
        txt_id.Text = Nothing
    End Sub

    Private Sub data_items_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_items.CellContentDoubleClick
        With data_items
            If .CurrentRow.Cells(4).Selected Then
                txt_produto.Text = .CurrentRow.Cells(1).Value
                txt_valor.Text = .CurrentRow.Cells(2).Value
                txt_qtde.Text = .CurrentRow.Cells(3).Value
                txt_id.Text = .CurrentRow.Cells(0).Value
                TabControl1.SelectedTab = TabPage1
                estado_btn(True)
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub estado_btn(estado As Boolean)
        If (estado = True) Then
            btn_cadastrar.Enabled = False
            btn_editar_produto.Enabled = True
            btn_cancelar.Enabled = True
        Else
            btn_cadastrar.Enabled = True
            btn_editar_produto.Enabled = False
            btn_cancelar.Enabled = False
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        estado_btn(False)
        limpar()
    End Sub

    Private Sub btn_editar_produto_Click(sender As Object, e As EventArgs) Handles btn_editar_produto.Click
        If verificar_campos() = True Then
            editProduct(txt_id.Text, txt_produto.Text, FormatNumber(txt_valor.Text, 2), txt_qtde.Text)
        Else
            MsgBox("Dados inválidos!" & vbCrLf & "Revise os campos", vbCritical + vbOKOnly, "Erro")
        End If
    End Sub
End Class