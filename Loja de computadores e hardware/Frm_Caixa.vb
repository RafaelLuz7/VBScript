Imports System.Data.SqlClient
Imports System.Xml

Public Class Frm_Caixa



    Private Sub rd_cartao_CheckedChanged(sender As Object, e As EventArgs) Handles rd_cartao.CheckedChanged
        If rd_cartao.Checked Then
            txt_parcelas.Enabled = True
        End If
    End Sub
    Private Sub rd_avista_CheckedChanged(sender As Object, e As EventArgs) Handles rd_avista.CheckedChanged
        If rd_avista.Checked Then
            txt_parcelas.Enabled = False
            pm = "PLACA MÃE"
            sql = "select * from tb_estoque where tipo =  '" & pm & "'"
            rs = db.Execute(sql)
            txt_total.Text = rs.Fields(2).Value
        End If
    End Sub
    Private Sub txt_parcelas_LostFocus(sender As Object, e As EventArgs) Handles txt_parcelas.LostFocus
        If txt_parcelas.Text <> "" Then
            parcela = txt_parcelas.Text
        End If

        If parcela > 10 Then
            MsgBox("O valor da parcela não pode ser maior que 10.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            txt_parcelas.Clear()
            txt_juros.Text = "5%"


        End If



    End Sub


    Private Sub ts_cliente_LostFocus(sender As Object, e As EventArgs) Handles ts_cliente.LostFocus
        sql = "select * from tb_clientes where nome = '" & ts_cliente.Text & "' "
        rs = db.Execute(sql)
        txt_cx_cpf.Text = rs.Fields(0).Value
    End Sub




    Private Sub rd_placamae_CheckedChanged(sender As Object, e As EventArgs) Handles rd_placamae.CheckedChanged
        If rd_placamae.Checked = True Then
            rd_dvd.Checked = False
            rd_fonte.Checked = False
            rd_hdsd.Checked = False
            rd_placavideo.Checked = False
            rd_processador.Checked = False
            rd_ram.Checked = False
            rd_acessorios.Checked = False
            pm = "PLACA MÃE"
            sql = "select * from tb_estoque where tipo =  '" & pm & "'"
            rs = db.Execute(sql)


            With cmb_produto
                .Items.Clear()
                .Items.Add(rs.Fields(0).Value)

            End With


        End If
    End Sub

    Private Sub rd_plavideo_CheckedChanged(sender As Object, e As EventArgs) Handles rd_placavideo.CheckedChanged
        If rd_placavideo.Checked = True Then
            rd_dvd.Checked = False
            rd_fonte.Checked = False
            rd_hdsd.Checked = False
            rd_placamae.Checked = False
            rd_processador.Checked = False
            rd_ram.Checked = False
            rd_acessorios.Checked = False

            pm = "PLACA DE VIDEO"
            sql = "select * from tb_estoque where tipo =  '" & pm & "'"
            rs = db.Execute(sql)


            With cmb_produto
                .Items.Clear()
                .Items.Add(rs.Fields(0).Value)

            End With
        End If
    End Sub
    Private Sub rd_processador_CheckedChanged(sender As Object, e As EventArgs) Handles rd_processador.CheckedChanged
        If rd_processador.Checked = True Then
            rd_dvd.Checked = False
            rd_fonte.Checked = False
            rd_hdsd.Checked = False
            rd_placavideo.Checked = False
            rd_placamae.Checked = False
            rd_ram.Checked = False
            rd_acessorios.Checked = False

            pm = "PROCESSADOR"
            sql = "select * from tb_estoque where tipo =  '" & pm & "'"
            rs = db.Execute(sql)


            With cmb_produto
                .Items.Clear()
                .Items.Add(rs.Fields(0).Value)

            End With
        End If
    End Sub
    Private Sub rd_ram_CheckedChanged(sender As Object, e As EventArgs) Handles rd_ram.CheckedChanged
        If rd_ram.Checked = True Then
            rd_dvd.Checked = False
            rd_fonte.Checked = False
            rd_hdsd.Checked = False
            rd_placavideo.Checked = False
            rd_processador.Checked = False
            rd_placamae.Checked = False
            rd_acessorios.Checked = False

            pm = "MEMORIA RAM"
            sql = "select * from tb_estoque where tipo =  '" & pm & "'"
            rs = db.Execute(sql)


            With cmb_produto
                .Items.Clear()
                .Items.Add(rs.Fields(0).Value)

            End With
        End If
    End Sub
    Private Sub rd_hdsd_CheckedChanged(sender As Object, e As EventArgs) Handles rd_hdsd.CheckedChanged
        If rd_hdsd.Checked = True Then
            rd_dvd.Checked = False
            rd_fonte.Checked = False
            rd_placamae.Checked = False
            rd_placavideo.Checked = False
            rd_processador.Checked = False
            rd_ram.Checked = False
            rd_acessorios.Checked = False


            sql = "select * from tb_estoque where tipo =  '" & pm & "'"
            rs = db.Execute(sql)


            With cmb_produto
                .Items.Clear()
                .Items.Add(rs.Fields(0).Value)

            End With
        End If
    End Sub
    Private Sub rd_dvd_CheckedChanged(sender As Object, e As EventArgs) Handles rd_dvd.CheckedChanged
        If rd_dvd.Checked = True Then
            rd_placamae.Checked = False
            rd_fonte.Checked = False
            rd_hdsd.Checked = False
            rd_placavideo.Checked = False
            rd_processador.Checked = False
            rd_ram.Checked = False
            rd_acessorios.Checked = False

            pm = ""
            sql = "select * from tb_estoque where tipo =  '" & pm & "'"
            rs = db.Execute(sql)


            With cmb_produto
                .Items.Clear()
                .Items.Add(rs.Fields(0).Value)

            End With
        End If
    End Sub
    Private Sub rd_fonte_CheckedChanged(sender As Object, e As EventArgs) Handles rd_fonte.CheckedChanged
        If rd_fonte.Checked = True Then
            rd_dvd.Checked = False
            rd_placamae.Checked = False
            rd_hdsd.Checked = False
            rd_placavideo.Checked = False
            rd_processador.Checked = False
            rd_ram.Checked = False
            rd_acessorios.Checked = False

            pm = "FONTE"
            sql = "select * from tb_estoque where tipo =  '" & pm & "'"
            rs = db.Execute(sql)


            With cmb_produto
                .Items.Clear()
                .Items.Add(rs.Fields(0).Value)

            End With
        End If
    End Sub
    Private Sub rd_acessorios_CheckedChanged(sender As Object, e As EventArgs) Handles rd_acessorios.CheckedChanged
        If rd_acessorios.Checked = True Then
            rd_dvd.Checked = False
            rd_fonte.Checked = False
            rd_hdsd.Checked = False
            rd_placavideo.Checked = False
            rd_processador.Checked = False
            rd_ram.Checked = False
            rd_placamae.Checked = False

            pm = "ACESSORIO"
            sql = "select * from tb_estoque where tipo =  '" & pm & "'"
            rs = db.Execute(sql)


            With cmb_produto
                .Items.Clear()
                .Items.Add(rs.Fields(0).Value)

            End With
        End If
    End Sub

    Private Sub btn_add_prod_Click(sender As Object, e As EventArgs) Handles btn_add_prod.Click
        carregar_pagamento()
    End Sub

    Private Sub cmb_produto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_produto.SelectedIndexChanged
        cmb_produto.SelectedIndex = prod
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_total.Clear()

    End Sub
End Class

