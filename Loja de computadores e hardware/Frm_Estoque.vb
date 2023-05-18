Public Class Frm_Estoque
    Private Sub Frm_Estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_estoque()


    End Sub

    Private Sub btn_add_prod_Click(sender As Object, e As EventArgs) Handles btn_add_prod.Click
        sql = "insert into tb_estoque values ('" & txt_produto.Text & "' , " &
                                           "'" & txt_tipo.Text & "', " &
                                           "'" & txt_valor_u.Text & "', " &
                                           "'" & txt_qtde.Text & "')"
        rs = db.Execute(UCase(sql))
        carregar_estoque()
        MsgBox("Produto adicionado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        limpar_dados()

    End Sub
End Class