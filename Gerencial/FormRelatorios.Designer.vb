<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRelatorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRelatorios))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.cmb_relat = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_gerar = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_relat
        '
        Me.cmb_relat.FormattingEnabled = True
        Me.cmb_relat.Items.AddRange(New Object() {"Relatório anual de vendas", "Relatório de vendas por funcionário", "Relatório de Produtos mais Vendidos"})
        Me.cmb_relat.Location = New System.Drawing.Point(12, 54)
        Me.cmb_relat.Name = "cmb_relat"
        Me.cmb_relat.Size = New System.Drawing.Size(326, 23)
        Me.cmb_relat.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Location = New System.Drawing.Point(12, 17)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(326, 31)
        Me.Panel4.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(113, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 30)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Relatórios"
        '
        'btn_gerar
        '
        Me.btn_gerar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_gerar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_gerar.ForeColor = System.Drawing.Color.White
        Me.btn_gerar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_gerar.Location = New System.Drawing.Point(12, 249)
        Me.btn_gerar.Name = "btn_gerar"
        Me.btn_gerar.Size = New System.Drawing.Size(326, 40)
        Me.btn_gerar.TabIndex = 20
        Me.btn_gerar.Text = "Gerar Relatório"
        Me.btn_gerar.UseVisualStyleBackColor = False
        '
        'FormRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 301)
        Me.Controls.Add(Me.btn_gerar)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.cmb_relat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRelatorios"
        Me.Text = "Relatórios"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents cmb_relat As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_gerar As Button
End Class
