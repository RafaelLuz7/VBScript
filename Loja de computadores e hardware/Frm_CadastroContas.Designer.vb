<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CadastroContas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CadastroContas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_csenha = New System.Windows.Forms.TextBox()
        Me.txt_rsenha = New System.Windows.Forms.TextBox()
        Me.btn_cadConta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(57, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(57, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(57, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Repetir senha"
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(165, 21)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(168, 20)
        Me.txt_user.TabIndex = 3
        '
        'txt_csenha
        '
        Me.txt_csenha.Location = New System.Drawing.Point(165, 71)
        Me.txt_csenha.Name = "txt_csenha"
        Me.txt_csenha.Size = New System.Drawing.Size(168, 20)
        Me.txt_csenha.TabIndex = 4
        '
        'txt_rsenha
        '
        Me.txt_rsenha.Location = New System.Drawing.Point(165, 121)
        Me.txt_rsenha.Name = "txt_rsenha"
        Me.txt_rsenha.Size = New System.Drawing.Size(168, 20)
        Me.txt_rsenha.TabIndex = 5
        '
        'btn_cadConta
        '
        Me.btn_cadConta.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_cadConta.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadConta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_cadConta.Location = New System.Drawing.Point(138, 158)
        Me.btn_cadConta.Name = "btn_cadConta"
        Me.btn_cadConta.Size = New System.Drawing.Size(122, 34)
        Me.btn_cadConta.TabIndex = 6
        Me.btn_cadConta.Text = "CADASTRAR"
        Me.btn_cadConta.UseVisualStyleBackColor = False
        '
        'Frm_CadastroContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(413, 204)
        Me.Controls.Add(Me.btn_cadConta)
        Me.Controls.Add(Me.txt_rsenha)
        Me.Controls.Add(Me.txt_csenha)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_CadastroContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE CONTAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_csenha As TextBox
    Friend WithEvents txt_rsenha As TextBox
    Friend WithEvents btn_cadConta As Button
End Class
