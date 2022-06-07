Public Class FormCaixa
    Private Sub FormCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nome.Text = sessao.Fields(1).Value
        carergar_dados()
    End Sub

    Private Sub carergar_dados(Optional sql As String = "SELECT * from tb_produtos ORDER BY nome DESC")
        rs = db.Execute(sql)
        With data_produtos
            data_produtos.Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, "R$ " & rs.Fields(2).Value, rs.Fields(3).Value, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub data_produtos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_produtos.CellContentDoubleClick
        With data_produtos
            If .CurrentRow.Cells(4).Selected = True Then
                addItem(.CurrentRow.Cells)
            End If
        End With
    End Sub

    Private Sub addItem(row As DataGridViewCellCollection)
        Dim exists As Boolean = False
        Dim extRow As DataGridViewRow = Nothing
        With data_items
            For Each rows As DataGridViewRow In .Rows
                If row(1).Value = rows.Cells(1).Value Then
                    exists = True
                    extRow = rows
                End If
            Next
            If exists <> False Then
                extRow.Cells(3).Value = extRow.Cells(3).Value + 1
                extRow.Cells(2).Value = "R$ " & Format(row(2).Value * extRow.Cells(3).Value, "0.00")
            Else
                .Rows.Add(row(0).Value, row(1).Value, row(2).Value, 1, Nothing)
            End If
        End With
        row(3).Value = row(3).Value - 1
        valorTotal()
    End Sub

    Private Sub removeItem(row As DataGridViewRow, Optional one As Boolean = False, Optional value As Double = 0)
        If one = True Then
            If row.Cells(3).Value = 1 Then
                returnProduct(row, True)
                data_items.Rows.Remove(row)
            Else
                returnProduct(row, True)
                row.Cells(3).Value = row.Cells(3).Value - 1
                row.Cells(2).Value = "R$ " & Format(searchDataById(data_produtos, CInt(row.Cells(0).Value), "valor_unitario") * row.Cells(3).Value, "0.00")
            End If
        Else
            returnProduct(row, True)
            data_items.Rows.Remove(row)
        End If
        valorTotal()
    End Sub

    Private Sub returnProduct(itemRow As DataGridViewRow, Optional one As Boolean = False)
        For Each rows As DataGridViewRow In data_produtos.Rows
            If rows.Cells(0).Value = itemRow.Cells(0).Value Then
                If (one = True) Then
                    rows.Cells(3).Value = rows.Cells(3).Value + 1
                Else
                    rows.Cells(3).Value = rows.Cells(3).Value + itemRow.Cells(2).Value
                End If

            End If
        Next
    End Sub

    Private Sub valorTotal()
        Dim total As Double = 0
        Dim itens As Integer = 0
        For Each rows As DataGridViewRow In data_items.Rows
            total = total + rows.Cells(2).Value
            itens = itens + rows.Cells(3).Value
        Next
        lbl_total.Text = Format(total, "0.00")
        lbl_itens.Text = itens
    End Sub

    Private Sub data_items_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_items.CellContentDoubleClick
        With data_items
            If .CurrentRow.Cells(4).Selected = True Then
                removeItem(.CurrentRow)
            End If
        End With
    End Sub

    Private Sub data_items_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_items.CellContentClick
        With data_items
            If .CurrentRow.Cells(4).Selected = True Then
                removeItem(.CurrentRow, True)
            End If
        End With
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Dim resp = MsgBox("Deseja Voltar?" & vbCrLf & "Isso irá cancelar qualquer compra em andamento.", vbQuestion + vbYesNo, "Atenção")
        If (resp = vbYes) Then
            If sessao(2).Value = 1 Then
                FormDashboardGerencial.Show()
            Else
                FormDashboardFunc.Show()
            End If
            Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub finalizarCompra()
        Try
            sql = "INSERT INTO tb_vendas (valor_total, itens_total, id_funcionario, data_venda) VALUES (" & Replace(lbl_total.Text, ",", ".") & "," & lbl_itens.Text & "," & sessao.Fields(0).Value & ",'" & Now() & "')"
            db.Execute(sql)
            rs = db.Execute("SELECT @@identity AS novaVenda")

            Dim idVenda = rs.Fields("novaVenda").Value

            For Each row As DataGridViewRow In data_items.Rows
                sql = "INSERT INTO tb_itens_venda (quantidade, id_produto, id_venda) VALUES (" & row.Cells(3).Value & "," & row.Cells(0).Value & "," & idVenda & ")"
                db.Execute(sql)
            Next

            For Each row As DataGridViewRow In data_produtos.Rows
                sql = "UPDATE tb_produtos SET qtd_estoque = " & row.Cells(3).Value & " WHERE id = " & row.Cells(0).Value
                db.Execute(sql)
            Next

            MsgBox("Compra finalizada com sucesso!", vbInformation + vbOKOnly, "Compra")
            limpar()

        Catch ex As Exception
            MsgBox("Erro ao inserir registro no banco de dados", vbCritical + vbOKOnly, "Erro")
        End Try
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        If (lbl_itens.Text > 0) Then
            finalizarCompra()
        Else
            MsgBox("Você deve inserir ao menos UM item no carrinho!", vbCritical + vbOKOnly, "Erro")
        End If

    End Sub

    Private Sub limpar()
        lbl_total.Text = "0,00"
        lbl_itens.Text = 0
        data_items.Rows.Clear()
    End Sub
    Function searchDataById(Obj As DataGridView, id As Integer, item As String)
        For Each row As DataGridViewRow In Obj.Rows
            If row.Cells.Item("id").Value = id Then
                searchDataById = row.Cells.Item(item).Value
                Exit Function
            End If
        Next
        Return False
    End Function

End Class