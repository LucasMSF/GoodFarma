<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstoque
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEstoque))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.txt_vunitario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_qtd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_criar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.data_items = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_editar_produto = New System.Windows.Forms.Button()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.txt_qtde = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_produto = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.data_items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel2.Controls.Add(Me.btn_editar)
        Me.Panel2.Controls.Add(Me.txt_vunitario)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt_qtd)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_nome)
        Me.Panel2.Controls.Add(Me.btn_voltar)
        Me.Panel2.Controls.Add(Me.btn_criar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(11, 238)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(409, 414)
        Me.Panel2.TabIndex = 14
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.Orange
        Me.btn_editar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_editar.Location = New System.Drawing.Point(273, 348)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(126, 54)
        Me.btn_editar.TabIndex = 18
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'txt_vunitario
        '
        Me.txt_vunitario.Location = New System.Drawing.Point(10, 209)
        Me.txt_vunitario.Name = "txt_vunitario"
        Me.txt_vunitario.Size = New System.Drawing.Size(388, 23)
        Me.txt_vunitario.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(10, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Valor unitário:"
        '
        'txt_qtd
        '
        Me.txt_qtd.Location = New System.Drawing.Point(10, 138)
        Me.txt_qtd.Name = "txt_qtd"
        Me.txt_qtd.Size = New System.Drawing.Size(388, 23)
        Me.txt_qtd.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(10, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Quantidade:"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(10, 65)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(388, 23)
        Me.txt_nome.TabIndex = 13
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Crimson
        Me.btn_voltar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_voltar.Location = New System.Drawing.Point(9, 348)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(126, 54)
        Me.btn_voltar.TabIndex = 12
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'btn_criar
        '
        Me.btn_criar.BackColor = System.Drawing.Color.SpringGreen
        Me.btn_criar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_criar.ForeColor = System.Drawing.Color.White
        Me.btn_criar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_criar.Location = New System.Drawing.Point(141, 348)
        Me.btn_criar.Name = "btn_criar"
        Me.btn_criar.Size = New System.Drawing.Size(126, 54)
        Me.btn_criar.TabIndex = 11
        Me.btn_criar.Text = "Cadastrar"
        Me.btn_criar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(10, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_nome)
        Me.Panel1.Location = New System.Drawing.Point(11, 190)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(409, 42)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome do Gestor:"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_nome.ForeColor = System.Drawing.Color.White
        Me.lbl_nome.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_nome.Location = New System.Drawing.Point(167, 10)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(50, 21)
        Me.lbl_nome.TabIndex = 1
        Me.lbl_nome.Text = "nome"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GoodFarma.My.Resources.Resources.logo_small
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(11, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(409, 167)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(5, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(685, 655)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.data_items)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(677, 627)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tabela de Estoque"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(7, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(664, 42)
        Me.Panel3.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(282, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 37)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Estoque"
        '
        'data_items
        '
        Me.data_items.AllowUserToAddRows = False
        Me.data_items.AllowUserToDeleteRows = False
        Me.data_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column5, Me.Column6, Me.Column7, Me.Column2, Me.Column1})
        Me.data_items.Location = New System.Drawing.Point(7, 67)
        Me.data_items.Name = "data_items"
        Me.data_items.ReadOnly = True
        Me.data_items.RowTemplate.Height = 25
        Me.data_items.Size = New System.Drawing.Size(664, 554)
        Me.data_items.TabIndex = 17
        '
        'Column9
        '
        Me.Column9.HeaderText = "ID"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Produto"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Valor unitário"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Quantidade"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Editar"
        Me.Column2.Image = CType(resources.GetObject("Column2.Image"), System.Drawing.Image)
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column1
        '
        Me.Column1.HeaderText = "Remover"
        Me.Column1.Image = CType(resources.GetObject("Column1.Image"), System.Drawing.Image)
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txt_id)
        Me.TabPage1.Controls.Add(Me.btn_cancelar)
        Me.TabPage1.Controls.Add(Me.btn_editar_produto)
        Me.TabPage1.Controls.Add(Me.btn_cadastrar)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txt_valor)
        Me.TabPage1.Controls.Add(Me.txt_qtde)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txt_produto)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(677, 627)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Formulário de Estoque"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(580, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 21)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "ID:"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(617, 54)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(50, 23)
        Me.txt_id.TabIndex = 25
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Crimson
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_cancelar.Location = New System.Drawing.Point(417, 206)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(106, 33)
        Me.btn_cancelar.TabIndex = 24
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_editar_produto
        '
        Me.btn_editar_produto.BackColor = System.Drawing.Color.Gold
        Me.btn_editar_produto.Enabled = False
        Me.btn_editar_produto.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_editar_produto.ForeColor = System.Drawing.Color.White
        Me.btn_editar_produto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_editar_produto.Location = New System.Drawing.Point(226, 196)
        Me.btn_editar_produto.Name = "btn_editar_produto"
        Me.btn_editar_produto.Size = New System.Drawing.Size(182, 43)
        Me.btn_editar_produto.TabIndex = 23
        Me.btn_editar_produto.Text = "Editar"
        Me.btn_editar_produto.UseVisualStyleBackColor = False
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_cadastrar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cadastrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_cadastrar.Location = New System.Drawing.Point(12, 196)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(196, 43)
        Me.btn_cadastrar.TabIndex = 20
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(195, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 21)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Valor unitário:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(11, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 21)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Quantidade:"
        '
        'txt_valor
        '
        Me.txt_valor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_valor.Location = New System.Drawing.Point(195, 151)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.ShortcutsEnabled = False
        Me.txt_valor.Size = New System.Drawing.Size(165, 23)
        Me.txt_valor.TabIndex = 2
        '
        'txt_qtde
        '
        Me.txt_qtde.Location = New System.Drawing.Point(12, 151)
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.Size = New System.Drawing.Size(165, 23)
        Me.txt_qtde.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(12, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nome do produto:"
        '
        'txt_produto
        '
        Me.txt_produto.Location = New System.Drawing.Point(12, 95)
        Me.txt_produto.Name = "txt_produto"
        Me.txt_produto.Size = New System.Drawing.Size(655, 23)
        Me.txt_produto.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Location = New System.Drawing.Point(7, 6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(664, 42)
        Me.Panel5.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(251, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 37)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Formulário"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(9, 673)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 54)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Voltar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 736)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEstoque"
        Me.Text = "Controle de Estoque"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.data_items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_criar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_vunitario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_qtd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents btn_editar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents data_items As DataGridView
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents txt_qtde As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_produto As TextBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_editar_produto As Button
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_id As TextBox
End Class
