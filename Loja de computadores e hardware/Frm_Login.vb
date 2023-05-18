Imports System.Diagnostics.Eventing.Reader

Public Class Frm_Login
    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        txt_usuario.Focus()

    End Sub
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_usuario.Text = "" Or txt_senha.Text = "" Then
            MsgBox("Preencha todos os campos para realizar o login!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
        ElseIf txt_usuario.Text = "adm" And txt_senha.Text = "adm" Then
            admin = True
            Frm_menu.ShowDialog()
        Else
            'Tentativa de login com leitura do banco
            sql = "select usuario, senha from tb_cadastro where usuario = '" & txt_usuario.Text & "' and senha = '" & txt_senha.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                Frm_menu.ShowDialog()
            Else
                MsgBox("Login/senha inválidos ou seu acesso pode estar bloqueado. Tente novamente e, se necessário, contate o administrador!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                txt_senha.Clear()

            End If
        End If
    End Sub
    Private Sub chk_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visualizar.CheckedChanged
        If chk_visualizar.Checked = True Then
            txt_senha.PasswordChar = String.Empty
        Else
            txt_senha.PasswordChar = "•"
        End If
    End Sub


End Class