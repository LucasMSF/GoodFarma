Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class FormRelatorios
    Private Sub FormRelatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub gerarPdf(titulo As String, colunas() As String, dados As ADODB.Recordset, data As String)
        Try
            Dim doc As New Document(iTextSharp.text.PageSize.A4, 20, 20, 20, 20)
            Dim arq As FileStream = New FileStream(TextBox1.Text & "\" & data & ".pdf", FileMode.Create)
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, arq)
            doc.Open()

            doc.AddAuthor("GoodFarma")
            doc.AddTitle("Relatório")

            Dim arqImg As String = Application.StartupPath & "/img/logo-smalll.png"
            Dim img As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(New Uri(arqImg))
            doc.Add(img)

            Dim fontA As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 24, Font.Bold, BaseColor.BLACK)
            Dim docTitulo As New Paragraph(titulo, fontA)
            docTitulo.Alignment = Element.ALIGN_CENTER
            doc.Add(docTitulo)
            doc.Add(New Paragraph(" ", fontA))

            Dim table As New PdfPTable(colunas.Length)

            For Each coluna As String In colunas
                Dim cell As New PdfPCell(New Phrase(coluna))
                cell.HorizontalAlignment = 1  '0=Left, 1=Centre, 2=Right
                table.AddCell(cell)
            Next

            While dados.EOF = False
                Dim i = colunas.Length
                For j = 0 To i - 1 Step 1
                    table.AddCell(dados.Fields(j).Value)
                Next j
                dados.MoveNext()
            End While

            doc.Add(table)

            doc.Close()
            arq.Close()
            MsgBox("Relatório gerado com sucesso!", vbInformation + vbOKOnly, "Informação")
        Catch ex As Exception
            MsgBox("Erro ao gerar relatório!", vbCritical + vbOKOnly, "Erro")
        End Try
    End Sub

    Private Sub btn_gerar_Click(sender As Object, e As EventArgs) Handles btn_gerar.Click
        If TextBox1.Text = Nothing Then
            MsgBox("Selecione o diretório", vbExclamation + vbOKOnly, "Atenção")
            Exit Sub
        End If
        Select Case cmb_relat.Text
            Case "Relatório anual de vendas"
                sql = "SELECT UCase(MONTHNAME(MONTH(data_venda))), COUNT(id), 'R$ ' & SUM(valor_total) FROM tb_vendas WHERE YEAR(data_venda) = YEAR(Date()) GROUP BY MONTH(data_venda) ORDER BY MONTH(data_venda)"
                rs = db.Execute(sql)
                gerarPdf("Relatório Anual de Vendas", {"Mês", "Qtde de Vendas", "Valor Total"}, rs, "Relatorio-anual-" & DateTime.Now.ToString("yyyy-MM-dd"))
            Case "Relatório de vendas por funcionário"
                sql = "SELECT f.nome, f.cpf, COUNT(v.id) AS ContarDeid, 'R$ ' & SUM(IIF(ISNULL(v.valor_total), 0, v.valor_total)) AS SomaDevalor_total FROM tb_funcionarios AS f LEFT JOIN tb_vendas AS v ON f.id = v.id_funcionario GROUP BY f.nome, f.cpf ORDER BY Sum(v.valor_total) DESC"
                rs = db.Execute(sql)
                gerarPdf("Relatório de Vendas por Funcionário", {"Nome", "CPF", "Total de vendas", "Valor total vendido"}, rs, "Relatorio-funcionarios-" & DateTime.Now.ToString("yyyy-MM-dd"))
            Case "Relatório de Produtos mais Vendidos"
                sql = "SELECT p.nome, Sum(iv.quantidade) AS SomaDequantidade, 'R$ ' & Sum(p.valor_unitario) AS SomaDevalor_unitario FROM tb_produtos AS p INNER JOIN tb_itens_venda AS iv ON p.id = iv.id_produto GROUP BY p.nome ORDER BY Sum(iv.quantidade) DESC"
                rs = db.Execute(sql)
                gerarPdf("Relatório de Produtos mais Vendidos", {"Nome do Produto", "Unidades vendidas", "Valor total vendido"}, rs, "Relatorio-produtos-" & DateTime.Now.ToString("yyyy-MM-dd"))
            Case Else
                MsgBox("Opção inválida!", vbExclamation + vbOKOnly, "Atenção")
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If fbd.ShowDialog() = 1 Then
            TextBox1.Text = fbd.SelectedPath
        End If
    End Sub
End Class