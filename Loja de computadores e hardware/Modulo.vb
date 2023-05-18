Module Modulo
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, pm, prod As String

    Public cont, id_user As Integer
    Public admin, c_ad As Boolean
    Public parcela As Double


    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-SRHSCVR;Initial Catalog=p2_si;trusted_connection=yes;")
            MsgBox("Conexão bem sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("ERRO AO CONECTAR", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Sub limpar_dados()
        Try
            With Frm_CadastroClientes
                .txt_cpf.Clear()
                .txt_nome.Clear()
                .txt_telefone.Clear()
                .txt_email.Clear()
                .txt_n.Clear()
                .txt_endereco.Clear()
                .txt_cpf.Focus()
            End With


        Catch ex As Exception

        End Try
    End Sub

    Sub carregar_contas()
        With Frm_ListaContas.dgv_contas
            cont = 1
            sql = "select * from tb_cadastro order by usuario asc"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub
    Sub carregar_clientes()
        With Frm_ListaClientes.dgv_clientes
            cont = 1
            sql = "select * from tb_clientes order by cpf asc"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub carregar_estoque()
        With Frm_Estoque.dg_estoque
            cont = 1
            sql = "select * from tb_estoque order by produto asc"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub carregar_pagamento()
        With Frm_Caixa.dt_caixa_prod
            cont = 1
            sql = "select * from tb_pagamento where p_produto = '" & prod & "'"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub


End Module
