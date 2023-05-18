<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_menu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ms_gerenciamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarNovaContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTADECONTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CADASTROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarNovoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciamentoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CAIXAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTOQUEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SISTEMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairDaContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharAplicaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_usuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataAtual = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_data = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_hora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_gerenciamento, Me.CADASTROToolStripMenuItem, Me.CAIXAToolStripMenuItem, Me.ESTOQUEToolStripMenuItem, Me.SISTEMAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(14, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(564, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ms_gerenciamento
        '
        Me.ms_gerenciamento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarNovaContaToolStripMenuItem, Me.LISTADECONTASToolStripMenuItem})
        Me.ms_gerenciamento.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ms_gerenciamento.ForeColor = System.Drawing.Color.Black
        Me.ms_gerenciamento.Image = CType(resources.GetObject("ms_gerenciamento.Image"), System.Drawing.Image)
        Me.ms_gerenciamento.Name = "ms_gerenciamento"
        Me.ms_gerenciamento.Size = New System.Drawing.Size(151, 20)
        Me.ms_gerenciamento.Text = "GERENCIAMENTO"
        '
        'CadastrarNovaContaToolStripMenuItem
        '
        Me.CadastrarNovaContaToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CadastrarNovaContaToolStripMenuItem.Image = CType(resources.GetObject("CadastrarNovaContaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastrarNovaContaToolStripMenuItem.Name = "CadastrarNovaContaToolStripMenuItem"
        Me.CadastrarNovaContaToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.CadastrarNovaContaToolStripMenuItem.Text = "Cadastrar Nova Conta"
        '
        'LISTADECONTASToolStripMenuItem
        '
        Me.LISTADECONTASToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue
        Me.LISTADECONTASToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LISTADECONTASToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LISTADECONTASToolStripMenuItem.Image = CType(resources.GetObject("LISTADECONTASToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LISTADECONTASToolStripMenuItem.Name = "LISTADECONTASToolStripMenuItem"
        Me.LISTADECONTASToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.LISTADECONTASToolStripMenuItem.Text = "Lista de Contas"
        '
        'CADASTROToolStripMenuItem
        '
        Me.CADASTROToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarNovoClienteToolStripMenuItem, Me.GerenciamentoDeClientesToolStripMenuItem})
        Me.CADASTROToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CADASTROToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CADASTROToolStripMenuItem.Image = CType(resources.GetObject("CADASTROToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CADASTROToolStripMenuItem.Name = "CADASTROToolStripMenuItem"
        Me.CADASTROToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.CADASTROToolStripMenuItem.Text = "CADASTRO"
        '
        'CadastrarNovoClienteToolStripMenuItem
        '
        Me.CadastrarNovoClienteToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CadastrarNovoClienteToolStripMenuItem.Image = CType(resources.GetObject("CadastrarNovoClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastrarNovoClienteToolStripMenuItem.Name = "CadastrarNovoClienteToolStripMenuItem"
        Me.CadastrarNovoClienteToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.CadastrarNovoClienteToolStripMenuItem.Text = "Cadastrar Novo Cliente"
        '
        'GerenciamentoDeClientesToolStripMenuItem
        '
        Me.GerenciamentoDeClientesToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GerenciamentoDeClientesToolStripMenuItem.Image = CType(resources.GetObject("GerenciamentoDeClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GerenciamentoDeClientesToolStripMenuItem.Name = "GerenciamentoDeClientesToolStripMenuItem"
        Me.GerenciamentoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.GerenciamentoDeClientesToolStripMenuItem.Text = "Lista De Clientes"
        '
        'CAIXAToolStripMenuItem
        '
        Me.CAIXAToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAIXAToolStripMenuItem.Image = CType(resources.GetObject("CAIXAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CAIXAToolStripMenuItem.Name = "CAIXAToolStripMenuItem"
        Me.CAIXAToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CAIXAToolStripMenuItem.Text = "CAIXA"
        '
        'ESTOQUEToolStripMenuItem
        '
        Me.ESTOQUEToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESTOQUEToolStripMenuItem.Image = CType(resources.GetObject("ESTOQUEToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ESTOQUEToolStripMenuItem.Name = "ESTOQUEToolStripMenuItem"
        Me.ESTOQUEToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.ESTOQUEToolStripMenuItem.Text = "ESTOQUE"
        '
        'SISTEMAToolStripMenuItem
        '
        Me.SISTEMAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairDaContaToolStripMenuItem, Me.FecharAplicaçãoToolStripMenuItem})
        Me.SISTEMAToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SISTEMAToolStripMenuItem.Image = CType(resources.GetObject("SISTEMAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SISTEMAToolStripMenuItem.Name = "SISTEMAToolStripMenuItem"
        Me.SISTEMAToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.SISTEMAToolStripMenuItem.Text = "SISTEMA"
        '
        'SairDaContaToolStripMenuItem
        '
        Me.SairDaContaToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue
        Me.SairDaContaToolStripMenuItem.Image = CType(resources.GetObject("SairDaContaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairDaContaToolStripMenuItem.Name = "SairDaContaToolStripMenuItem"
        Me.SairDaContaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.SairDaContaToolStripMenuItem.Text = "Sair Da Conta"
        '
        'FecharAplicaçãoToolStripMenuItem
        '
        Me.FecharAplicaçãoToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue
        Me.FecharAplicaçãoToolStripMenuItem.Image = CType(resources.GetObject("FecharAplicaçãoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FecharAplicaçãoToolStripMenuItem.Name = "FecharAplicaçãoToolStripMenuItem"
        Me.FecharAplicaçãoToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.FecharAplicaçãoToolStripMenuItem.Text = "Fechar Aplicação"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbl_usuario, Me.DataAtual, Me.lbl_data, Me.lbl_hora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 233)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(564, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(113, 17)
        Me.ToolStripStatusLabel1.Text = "USUÁRIO LOGADO: "
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(56, 17)
        Me.lbl_usuario.Text = "USUARIO"
        '
        'DataAtual
        '
        Me.DataAtual.Name = "DataAtual"
        Me.DataAtual.Size = New System.Drawing.Size(79, 17)
        Me.DataAtual.Text = "DATA ATUAL: "
        '
        'lbl_data
        '
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(35, 17)
        Me.lbl_data.Text = "DATA"
        '
        'lbl_hora
        '
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(40, 17)
        Me.lbl_hora.Text = "HORA"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(564, 255)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Slipstream", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.Name = "Frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU - SPEED OF LIGHT INFORMÁTICA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ms_gerenciamento As ToolStripMenuItem
    Friend WithEvents LISTADECONTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CADASTROToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CAIXAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarNovaContaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarNovoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GerenciamentoDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ESTOQUEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SISTEMAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairDaContaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FecharAplicaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lbl_usuario As ToolStripStatusLabel
    Friend WithEvents DataAtual As ToolStripStatusLabel
    Friend WithEvents lbl_data As ToolStripStatusLabel
    Friend WithEvents lbl_hora As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer

End Class
