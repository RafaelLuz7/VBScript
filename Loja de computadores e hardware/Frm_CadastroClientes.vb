Public Class Frm_CadastroClientes

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = "select * from tb_clientes where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                txt_nome.Focus()
            Else
                MsgBox("Esse CPF já está cadastrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_dados()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_cadCliente_Click(sender As Object, e As EventArgs) Handles btn_cadCliente.Click

        sql = "insert into tb_clientes values ('" & txt_cpf.Text & "' , " &
                                              "'" & txt_nome.Text & "', " &
                                              "'" & cmb_data.Text & "', " &
                                              "'" & txt_telefone.Text & "', " &
                                              "'" & txt_email.Text & "', " &
                                              "'" & txt_endereco.Text & "', " &
                                              "'" & txt_n.Text & "')"
        rs = db.Execute(UCase(sql))
        MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        limpar_dados()
        carregar_clientes()

    End Sub


End Class