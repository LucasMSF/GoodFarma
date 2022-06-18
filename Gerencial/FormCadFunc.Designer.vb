<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadFunc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCadFunc))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_cargos = New System.Windows.Forms.ComboBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(12, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 21)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nome do funcionário:"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(12, 49)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(357, 23)
        Me.txt_nome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CPF:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(12, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cargo:"
        '
        'cmb_cargos
        '
        Me.cmb_cargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cargos.FormattingEnabled = True
        Me.cmb_cargos.Location = New System.Drawing.Point(12, 184)
        Me.cmb_cargos.Name = "cmb_cargos"
        Me.cmb_cargos.Size = New System.Drawing.Size(357, 23)
        Me.cmb_cargos.TabIndex = 2
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(12, 113)
        Me.txt_cpf.Mask = "000,000,000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(357, 23)
        Me.txt_cpf.TabIndex = 1
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_cadastrar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Location = New System.Drawing.Point(13, 360)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_cadastrar.Size = New System.Drawing.Size(357, 50)
        Me.btn_cadastrar.TabIndex = 5
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.Crimson
        Me.btn_sair.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.Location = New System.Drawing.Point(13, 416)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(357, 50)
        Me.btn_sair.TabIndex = 6
        Me.btn_sair.Text = "Voltar"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(13, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Usuário:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(13, 251)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(357, 23)
        Me.txt_usuario.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(13, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 21)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Senha do usuário:"
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(13, 316)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(357, 23)
        Me.txt_senha.TabIndex = 4
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.Gold
        Me.btn_editar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.Location = New System.Drawing.Point(13, 360)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_editar.Size = New System.Drawing.Size(357, 50)
        Me.btn_editar.TabIndex = 20
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = False
        Me.btn_editar.Visible = False
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(270, 12)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 23)
        Me.txt_id.TabIndex = 21
        Me.txt_id.Visible = False
        '
        'FormCadFunc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 501)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.cmb_cargos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormCadFunc"
        Me.Text = "Cadastro de funcionário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_cargos As ComboBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_editar As Button
    Friend WithEvents txt_id As TextBox
End Class
