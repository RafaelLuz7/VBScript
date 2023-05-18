Public Class Frm_CadastroContas
    Private Sub btn_cadConta_Click(sender As Object, e As EventArgs) Handles btn_cadConta.Click
        If txt_user.Text = "" Or txt_csenha.Text = "" Or txt_rsenha.Text = "" Then
            MsgBox("Preencha todos os campos para finalizar o cadastro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        ElseIf txt_csenha.Text <> txt_rsenha.Text Then
            MsgBox("As senhas digitadas não conferem!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            txt_csenha.Clear()
            txt_rsenha.Clear()


        Else
            sql = "select * from tb_cadastro where usuario = '" & txt_user.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("O nome de usuário já está em uso. Tente outro!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                txt_user.Clear()
                txt_csenha.Clear()
                txt_rsenha.Clear()
                txt_user.Focus()

            Else

                Try
                    sql = "insert into tb_cadastro values ('" & txt_user.Text & "', " &
                                                   "'" & txt_csenha.Text & "')"
                    rs = db.Execute(sql)
                    carregar_contas()
                Catch ex As Exception

                End Try

            End If
        End If
    End Sub
End Class