Public Class Frm_menu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_usuario.Text = Frm_Login.txt_usuario.Text
        lbl_data.Text = Date.Today
        lbl_hora.Text = TimeOfDay
    End Sub

    Private Sub Frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frm_Login.Hide()
        conectar_banco()
        Timer1.Start()


    End Sub

    Private Sub CadastrarNovaContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarNovaContaToolStripMenuItem.Click
        If admin = True Then
            Frm_CadastroContas.ShowDialog()
        Else
            MsgBox("Apenas administradores podem acessar essa area", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub

    Private Sub LISTADECONTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTADECONTASToolStripMenuItem.Click
        If admin = True Then
            Frm_ListaContas.ShowDialog()
        Else
            MsgBox("Apenas administradores podem acessar essa area", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub

    Private Sub CadastrarNovoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarNovoClienteToolStripMenuItem.Click
        Frm_CadastroClientes.ShowDialog()
    End Sub

    Private Sub GerenciamentoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerenciamentoDeClientesToolStripMenuItem.Click
        Frm_ListaClientes.ShowDialog()
    End Sub

    Private Sub CAIXAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CAIXAToolStripMenuItem.Click
        Frm_Caixa.ShowDialog()
    End Sub

    Private Sub ESTOQUEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTOQUEToolStripMenuItem.Click
        Frm_Estoque.ShowDialog()
    End Sub

    Private Sub SairDaContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairDaContaToolStripMenuItem.Click
        Me.Close()
        Frm_Caixa.Close()
        Frm_CadastroContas.Close()
        Frm_CadastroClientes.Close()
        Frm_Estoque.Close()
        Frm_ListaClientes.Close()
        Frm_ListaContas.Close()

        Frm_Login.Show()
    End Sub


End Class