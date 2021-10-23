Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmPedidoData

    Dim labowcf As New labonorte.Service1Client
    Dim tRetorno As New DataTable
    Dim tbImpRec As New DataTable
    Dim d As New dados
    Dim c As New config
    Dim master As New objMaster
    Dim enviando As Boolean = False
    Dim recebendo As Boolean = False
    Dim processando As Boolean = False
    Dim hora As Date = Now
    Dim importados As Long = 0
    Dim importando As Boolean = False
    Dim objPedido As New objMaster
    Dim wsPedido As New labonorte_cliente.Service
    Dim strTexto As String

    Private Sub btnImportar_Click(sender As System.Object, e As System.EventArgs) Handles btnImportar.Click
        strTexto = ""
        If rbPedido.Checked = True Then
            pedido()
        End If

        If rbFatura.Checked = True Then
            fatura()
        End If

        If rbOS.Checked = True Then
            os()
        End If

    End Sub

    Private Sub pedido()
        Dim tbPedido As New DataTable
        Dim tbPedidoItem As New DataTable
        Dim tbServico As New DataTable
        Dim tbOS As New DataTable
        Dim tbOSAndamento As New DataTable
        Dim di As DateTime = DateTimePicker1.Value.ToShortDateString & " 00:00:00"
        Dim df As DateTime = DateTimePicker2.Value.ToShortDateString & " 23:59:59"
        Dim i, j, l, m, n As Integer
        Try
            If rbData.Checked = True Then
                tbPedido = wsPedido.importaPedidoData(CInt(txtFilial.Text), di, df).Tables(0)
            Else
                tbPedido = wsPedido.importaPedido(CInt(txtNumero.Text), CInt(txtFilial.Text)).Tables(0)
            End If

            If tbPedido.Rows.Count > 0 Then
                For i = 0 To tbPedido.Rows.Count - 1
                    tbOS = wsPedido.importaOSFiliaisLabonortePedido(tbPedido.Rows(i)("num_pedido"), tbPedido.Rows(i)("id_filial")).Tables(0)

                    If tbOS.Rows.Count > 0 Then
                        For n = 0 To tbOS.Rows.Count - 1
                            If tbOS.Rows(n)("num_pedido") IsNot DBNull.Value Then
                                Dim strSQLOS As String = "Select 1 from os where num_pedido = " & tbPedido.Rows(n)("num_pedido") & " and id_filial = " & tbPedido.Rows(n)("id_filial")
                                If objPedido.verifica_existencia_registro(strSQLOS) = False Then
                                    Dim strSQLInsert As String = "Insert Into OS(id_filial, cod_os, num_pedido, cod_tab_od, cod_tab_oe, cod_produto_od, cod_produto_oe, " & _
                                    "esf_od_longe, cil_od_longe, esf_od_perto, cil_od_perto, dnp_od_longe, dnp_od_perto, base_od, adicao_od, altura_od, diametro_od, " & _
                                    "eixo_od, esf_oe_longe, cil_oe_longe, esf_oe_perto, cil_oe_perto, dnp_oe_longe, dnp_oe_perto, base_oe, adicao_oe, altura_oe, " & _
                                    "diametro_oe, eixo_oe, aro_horizontal, aro_vertical, maior_diametro, ponte, cod_Tipo_Armacao, crm_oftalmologista, " & _
                                    "cod_filial_cliente, doc_cliente, cod_cliente, data_venda, data_previsao_entrega, hora_previsao_entrega, cod_vendedora, " & _
                                    "cod_qfez, observacao, nota_serie, cod_verif_por, data_verificacao, cod_surfacagem, cod_montagem, confeccao, coloracao, " & _
                                    "cor_coloracao, data_recebimento, data_fim_servico, cod_fase, tipo_receita_OD, tipo_receita_OE, id_laboratorio, cod_lab_surf, " & _
                                    "listado, forma, cod_tipo_os) values(" & tbOS.Rows(n)("id_filial") & "," & tbOS.Rows(n)("cod_os") & "," & _
                                    d.cdin(tbOS.Rows(n)("num_pedido")) & "," & d.cdin(tbOS.Rows(n)("cod_tab_od")) & "," & tbOS.Rows(n)("cod_tab_oe") & "," & _
                                    d.cdin(tbOS.Rows(n)("cod_produto_od")) & "," & d.cdin(tbOS.Rows(n)("cod_produto_oe")) & "," & _
                                    d.cdin(tbOS.Rows(n)("esf_od_longe")) & "," & d.cdin(tbOS.Rows(n)("cil_od_longe")) & "," & d.cdin(tbOS.Rows(n)("esf_od_perto")) & "," & _
                                    d.cdin(tbOS.Rows(n)("cil_od_perto")) & "," & d.cdin(tbOS.Rows(n)("dnp_od_longe")) & "," & d.cdin(tbOS.Rows(n)("dnp_od_perto")) & "," & _
                                    d.cdin(tbOS.Rows(n)("base_od")) & "," & d.cdin(tbOS.Rows(n)("adicao_od")) & "," & d.cdin(tbOS.Rows(n)("altura_od")) & "," & _
                                    d.cdin(tbOS.Rows(n)("diametro_od")) & "," & d.cdin(tbOS.Rows(n)("eixo_od")) & "," & d.cdin(tbOS.Rows(n)("esf_oe_longe")) & "," & _
                                    d.cdin(tbOS.Rows(n)("cil_oe_longe")) & "," & d.cdin(tbOS.Rows(n)("esf_oe_perto")) & "," & d.cdin(tbOS.Rows(n)("cil_oe_perto")) & "," & _
                                    d.cdin(tbOS.Rows(n)("dnp_oe_longe")) & "," & d.cdin(tbOS.Rows(n)("dnp_oe_perto")) & "," & d.cdin(tbOS.Rows(n)("base_oe")) & "," & _
                                    d.cdin(tbOS.Rows(n)("adicao_oe")) & "," & d.cdin(tbOS.Rows(n)("altura_oe")) & "," & d.cdin(tbOS.Rows(n)("diametro_oe")) & "," & _
                                    d.cdin(tbOS.Rows(n)("eixo_oe")) & "," & d.cdin(tbOS.Rows(n)("aro_horizontal")) & "," & d.cdin(tbOS.Rows(n)("aro_vertical")) & "," & _
                                    d.cdin(tbOS.Rows(n)("maior_diametro")) & "," & d.cdin(tbOS.Rows(n)("ponte")) & "," & d.cdin(tbOS.Rows(n)("cod_Tipo_Armacao")) & "," & _
                                    d.cdin(tbOS.Rows(n)("crm_oftalmologista")) & "," & d.cdin(tbOS.Rows(n)("cod_filial_cliente")) & "," & _
                                    d.cdin(tbOS.Rows(n)("doc_cliente")) & "," & d.cdin(tbOS.Rows(n)("cod_cliente")) & "," & d.Pdt(tbOS.Rows(n)("data_venda")) & "," & _
                                    d.Pdt(tbOS.Rows(n)("data_previsao_entrega")) & "," & d.Pdt(tbOS.Rows(n)("hora_previsao_entrega")) & "," & _
                                    d.cdin(tbOS.Rows(n)("cod_vendedora")) & "," & d.cdin(tbOS.Rows(n)("cod_qfez")) & "," & d.PStr(tbOS.Rows(n)("observacao")) & "," & _
                                    d.PStr(tbOS.Rows(n)("nota_serie")) & "," & d.cdin(tbOS.Rows(n)("cod_verif_por")) & "," & _
                                    d.Pdt(tbOS.Rows(n)("data_verificacao")) & "," & d.cdin(tbOS.Rows(n)("cod_surfacagem")) & "," & d.cdin(tbOS.Rows(n)("cod_montagem")) & "," & _
                                    d.PStr(tbOS.Rows(n)("confeccao")) & "," & d.PStr(tbOS.Rows(n)("coloracao")) & "," & _
                                    d.PStr(tbOS.Rows(n)("cor_coloracao")) & "," & d.Pdt(tbOS.Rows(n)("data_recebimento")) & "," & _
                                    d.Pdt(tbOS.Rows(n)("data_fim_servico")) & "," & d.cdin(tbOS.Rows(n)("cod_fase")) & "," & d.cdin(tbOS.Rows(n)("tipo_receita_OD")) & "," & _
                                    d.cdin(tbOS.Rows(n)("tipo_receita_OE")) & "," & d.cdin(tbOS.Rows(n)("id_laboratorio")) & "," & d.cdin(tbOS.Rows(n)("cod_lab_surf")) & "," & _
                                    d.Pdt(tbOS.Rows(n)("listado")) & "," & d.PStr(tbOS.Rows(n)("forma")) & "," & d.cdin(tbOS.Rows(n)("cod_tipo_os")) & ")"

                                    d.conecta()
                                    Dim cmd As New SqlCommand(strSQLInsert, d.con)
                                    cmd.ExecuteNonQuery()
                                End If

                                'Importa os andamentos da OS em questão
                                tbOSAndamento = wsPedido.importaAndamentoOS(tbOS.Rows(n)("cod_os"), tbOS.Rows(n)("id_filial")).Tables(0)
                                If tbOSAndamento.Rows.Count > 0 Then
                                    For l = 0 To tbOSAndamento.Rows.Count - 1
                                        Dim strSQLAndamento As String = "Select 1 from andamentos where cod_os = " & tbOSAndamento.Rows(l)("cod_os") & _
                                            " and id_filial = " & tbOSAndamento.Rows(l)("id_filial") & " and id_filial_andamento = " & _
                                            tbOSAndamento.Rows(l)("id_filial_andamento") & " and ordem = " & tbOSAndamento.Rows(l)("ordem")
                                        If objPedido.verifica_existencia_registro(strSQLAndamento) = False Then
                                            'Grava os andamentos da OS
                                            inseriAndamento(tbOSAndamento.Rows(l)("id_filial"), tbOSAndamento.Rows(l)("cod_os"), tbOSAndamento.Rows(l)("id_filial_andamento"), _
                                            tbOSAndamento.Rows(l)("ordem"), tbOSAndamento.Rows(l)("data"), tbOSAndamento.Rows(l)("cod_andamento"), _
                                            tbOSAndamento.Rows(l)("cod_usuario"), tbOSAndamento.Rows(l)("cod_status_andamento"), _
                                            tbOSAndamento.Rows(l)("observacao").ToString)
                                        End If
                                    Next
                                End If
                            End If
                        Next
                    End If


                    Dim strSQLPedido As String = "Select 1 from pedido_balcao where num_pedido = " & tbPedido.Rows(i)("num_pedido") & " and id_filial = " & tbPedido.Rows(i)("id_filial") & ""
                    If objPedido.verifica_existencia_registro(strSQLPedido) = False Then
                        Dim strSQL As String = "Insert Into Pedido_Balcao(num_pedido, id_filial, cod_vendedor, data_pedido, cod_cliente, cod_filial_cliente, " & _
                        "cod_status_pedido, cod_autorizacao, filial_autorizacao, forma, cod_tipo_pedido, valor_pago, valor_apagar, " & _
                        "valor_devolvido, cod_vendedor_ext, desconto) values(" & tbPedido.Rows(i)("num_pedido") & "," & tbPedido.Rows(i)("id_filial") & "," & _
                        tbPedido.Rows(i)("cod_vendedor") & "," & d.pdtm(tbPedido.Rows(i)("data_pedido")) & "," & tbPedido.Rows(i)("cod_cliente") & "," & _
                        tbPedido.Rows(i)("cod_filial_cliente") & "," & tbPedido.Rows(i)("cod_status_pedido") & "," & _
                        d.cdin(tbPedido.Rows(i)("cod_autorizacao")) & "," & d.cdin(tbPedido.Rows(i)("filial_autorizacao")) & "," & _
                        d.PStr(tbPedido.Rows(i)("forma")) & "," & d.cdin(tbPedido.Rows(i)("cod_tipo_pedido")) & "," & _
                        d.cdin(tbPedido.Rows(i)("valor_pago")) & "," & d.cdin(tbPedido.Rows(i)("valor_apagar")) & "," & _
                        d.cdin(tbPedido.Rows(i)("valor_devolvido")) & "," & _
                        tbPedido.Rows(i)("cod_vendedor_ext") & "," & d.PStr(tbPedido.Rows(i)("desconto")) & ")"
                        d.conecta()
                        Dim cmd As New SqlCommand(strSQL, d.con)
                        cmd.ExecuteNonQuery()
                        strTexto = "Pedido Nº " & tbPedido.Rows(i)("num_pedido") & " inserido com sucesso."
                        txtLog.Text = strTexto & vbCrLf & txtLog.Text

                        tbPedidoItem = wsPedido.importaPedidoItem(tbPedido.Rows(i)("num_pedido"), tbPedido.Rows(i)("id_filial")).Tables(0)
                        If tbPedidoItem.Rows.Count > 0 Then
                            For j = 0 To tbPedidoItem.Rows.Count - 1
                                Dim strSQLPedidoItem As String = "Select 1 from pedido_balcao_itens where num_pedido = " & tbPedidoItem.Rows(j)("num_pedido") & " and id_filial = " & tbPedidoItem.Rows(j)("id_filial") & ""
                                If objPedido.verifica_existencia_registro(strSQLPedidoItem) = False Then
                                    Dim strSQLItem As String = "Insert Into Pedido_Balcao_Itens(num_pedido, id_filial, item, cod_produto, quant, compra, " & _
                                    "desconto, preco, cod_status_item, Pacote, cod_pacote, desc_caixa, usuario_can, tipo_devolucao, devolvido_estoque, " & _
                                    "data_devolucao, preco_tab) values(" & tbPedidoItem.Rows(j)("num_pedido") & "," & _
                                    tbPedidoItem.Rows(j)("id_filial") & "," & tbPedidoItem.Rows(j)("item") & "," & _
                                    tbPedidoItem.Rows(j)("cod_produto") & "," & tbPedidoItem.Rows(j)("quant") & "," & _
                                    d.cdin(tbPedidoItem.Rows(j)("compra")) & "," & d.cdin(tbPedidoItem.Rows(j)("desconto")) & "," & _
                                    d.cdin(tbPedidoItem.Rows(j)("preco")) & "," & tbPedidoItem.Rows(j)("cod_status_item") & "," & _
                                    d.PStr(tbPedidoItem.Rows(j)("pacote")) & "," & d.cdin(tbPedidoItem.Rows(j)("cod_pacote")) & "," & _
                                    d.cdin(tbPedidoItem.Rows(j)("desc_caixa")) & "," & d.cdin(tbPedidoItem.Rows(j)("usuario_can")) & "," & _
                                    d.PStr(tbPedidoItem.Rows(j)("tipo_devolucao")) & "," & d.PStr(tbPedidoItem.Rows(j)("devolvido_estoque")) & "," & _
                                    d.pdtm(tbPedidoItem.Rows(j)("data_devolucao")) & "," & d.cdin(tbPedidoItem.Rows(j)("preco_tab")) & ")"
                                    d.conecta()

                                    Dim cmdItem As New SqlCommand(strSQLItem, d.con)
                                    cmdItem.ExecuteNonQuery()
                                End If
                            Next
                        End If

                        'Importa os serviços vinculados ao pedido
                        tbServico = wsPedido.importaPedidoServico(tbPedido.Rows(i)("num_pedido"), tbPedido.Rows(i)("id_filial")).Tables(0)
                        If tbServico.Rows.Count > 0 Then
                            For m = 0 To tbServico.Rows.Count - 1
                                Dim strSQLServicoPedido As String = "Select 1 from pedido_balcao_servicos where num_pedido = " & tbServico.Rows(m)("num_pedido") & _
                                " and id_filial = " & tbServico.Rows(m)("id_filial") & ""
                                If objPedido.verifica_existencia_registro(strSQLServicoPedido) = False Then
                                    'Grava os serviços do Pedido
                                    Dim strSQLServico As String = "Insert Into Pedido_Balcao_Servicos(num_pedido, id_filial, item_servico, " & _
                                        "cod_servico, quant, compra, desconto, preco, desc_caixa, cod_status_servico, pacote, cod_pacote, " & _
                                        "usuario_can, tipo_devolucao, devolvido_estoque, data_devolucao, preco_tab) values(" & _
                                        tbServico.Rows(m)("num_pedido") & "," & tbServico.Rows(m)("id_filial") & "," & _
                                        tbServico.Rows(m)("item_servico") & "," & tbServico.Rows(m)("cod_servico") & "," & _
                                        tbServico.Rows(m)("quant") & "," & d.cdin(tbServico.Rows(m)("compra")) & "," & _
                                        d.cdin(tbServico.Rows(m)("desconto")) & "," & d.cdin(tbServico.Rows(m)("preco")) & "," & _
                                        d.cdin(tbServico.Rows(m)("desc_caixa")) & "," & tbServico.Rows(m)("cod_status_servico") & "," & _
                                        d.PStr(tbServico.Rows(m)("pacote")) & "," & d.cdin(tbServico.Rows(m)("cod_pacote")) & "," & _
                                        d.cdin(tbServico.Rows(m)("usuario_can")) & "," & d.PStr(tbServico.Rows(m)("tipo_devolucao")) & "," & _
                                        d.cdin(tbServico.Rows(m)("devolvido_estoque")) & "," & d.pdtm(tbServico.Rows(m)("data_devolucao")) & "," & _
                                        d.cdin(tbServico.Rows(m)("preco_tab")) & ")"
                                    d.conecta()

                                    Dim cmdServido As New SqlCommand(strSQLServico, d.con)
                                    cmdServido.ExecuteNonQuery()
                                End If
                            Next
                        End If
                    Else
                        tbPedidoItem = wsPedido.importaPedidoItem(tbPedido.Rows(i)("num_pedido"), tbPedido.Rows(i)("id_filial")).Tables(0)
                        If tbPedidoItem.Rows.Count > 0 Then
                            For j = 0 To tbPedidoItem.Rows.Count - 1
                                Dim strSQLPedidoItem As String = "Select 1 from pedido_balcao_itens where num_pedido = " & tbPedidoItem.Rows(j)("num_pedido") & " and id_filial = " & tbPedidoItem.Rows(j)("id_filial") & _
                                    " and item = " & tbPedidoItem.Rows(j)("item") & ""
                                If objPedido.verifica_existencia_registro(strSQLPedidoItem) = False Then
                                    Dim strSQLItem As String = "Insert Into Pedido_Balcao_Itens(num_pedido, id_filial, item, cod_produto, quant, compra, " & _
                                    "desconto, preco, cod_status_item, Pacote, cod_pacote, desc_caixa, usuario_can, tipo_devolucao, devolvido_estoque, " & _
                                    "data_devolucao, preco_tab) values(" & tbPedidoItem.Rows(j)("num_pedido") & "," & _
                                    tbPedidoItem.Rows(j)("id_filial") & "," & tbPedidoItem.Rows(j)("item") & "," & _
                                    tbPedidoItem.Rows(j)("cod_produto") & "," & tbPedidoItem.Rows(j)("quant") & "," & _
                                    d.cdin(tbPedidoItem.Rows(j)("compra")) & "," & d.cdin(tbPedidoItem.Rows(j)("desconto")) & "," & _
                                    d.cdin(tbPedidoItem.Rows(j)("preco")) & "," & tbPedidoItem.Rows(j)("cod_status_item") & "," & _
                                    d.PStr(tbPedidoItem.Rows(j)("pacote")) & "," & d.cdin(tbPedidoItem.Rows(j)("cod_pacote")) & "," & _
                                    d.cdin(tbPedidoItem.Rows(j)("desc_caixa")) & "," & d.cdin(tbPedidoItem.Rows(j)("usuario_can")) & "," & _
                                    d.PStr(tbPedidoItem.Rows(j)("tipo_devolucao")) & "," & d.PStr(tbPedidoItem.Rows(j)("devolvido_estoque")) & "," & _
                                    d.pdtm(tbPedidoItem.Rows(j)("data_devolucao")) & "," & d.cdin(tbPedidoItem.Rows(j)("preco_tab")) & ")"
                                    d.conecta()

                                    Dim cmdItem As New SqlCommand(strSQLItem, d.con)
                                    cmdItem.ExecuteNonQuery()
                                End If
                            Next
                        End If

                        'Importa os serviços vinculados ao pedido
                        tbServico = wsPedido.importaPedidoServico(tbPedido.Rows(i)("num_pedido"), tbPedido.Rows(i)("id_filial")).Tables(0)
                        If tbServico.Rows.Count > 0 Then
                            For m = 0 To tbServico.Rows.Count - 1
                                Dim strSQLServicoPedido As String = "Select 1 from pedido_balcao_servicos where num_pedido = " & tbServico.Rows(m)("num_pedido") & _
                                " and id_filial = " & tbServico.Rows(m)("id_filial") & " and item_servico = " & tbServico.Rows(m)("item_servico") & ""
                                If objPedido.verifica_existencia_registro(strSQLServicoPedido) = False Then
                                    'Grava os serviços do Pedido
                                    Dim strSQLServico As String = "Insert Into Pedido_Balcao_Servicos(num_pedido, id_filial, item_servico, " & _
                                        "cod_servico, quant, compra, desconto, preco, desc_caixa, cod_status_servico, pacote, cod_pacote, " & _
                                        "usuario_can, tipo_devolucao, devolvido_estoque, data_devolucao, preco_tab) values(" & _
                                        tbServico.Rows(m)("num_pedido") & "," & tbServico.Rows(m)("id_filial") & "," & _
                                        tbServico.Rows(m)("item_servico") & "," & tbServico.Rows(m)("cod_servico") & "," & _
                                        tbServico.Rows(m)("quant") & "," & d.cdin(tbServico.Rows(m)("compra")) & "," & _
                                        d.cdin(tbServico.Rows(m)("desconto")) & "," & d.cdin(tbServico.Rows(m)("preco")) & "," & _
                                        d.cdin(tbServico.Rows(m)("desc_caixa")) & "," & tbServico.Rows(m)("cod_status_servico") & "," & _
                                        d.PStr(tbServico.Rows(m)("pacote")) & "," & d.cdin(tbServico.Rows(m)("cod_pacote")) & "," & _
                                        d.cdin(tbServico.Rows(m)("usuario_can")) & "," & d.PStr(tbServico.Rows(m)("tipo_devolucao")) & "," & _
                                        d.cdin(tbServico.Rows(m)("devolvido_estoque")) & "," & d.pdtm(tbServico.Rows(m)("data_devolucao")) & "," & _
                                        d.cdin(tbServico.Rows(m)("preco_tab")) & ")"
                                    d.conecta()

                                    Dim cmdServido As New SqlCommand(strSQLServico, d.con)
                                    cmdServido.ExecuteNonQuery()
                                End If
                            Next
                        End If
                    End If
                Next
            End If

            d.desconecta()
        Catch ex As System.Web.Services.Protocols.SoapException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub fatura()
        Dim tbFatura As New DataTable
        Dim tbFaturaItem As New DataTable
        Dim di As DateTime = DateTimePicker1.Value.ToShortDateString & " 00:00:00"
        Dim df As DateTime = DateTimePicker2.Value.ToShortDateString & " 23:59:59"
        Dim i, j As Integer
        Try
            If rbData.Checked = True Then
                tbFatura = wsPedido.importaFatura(CInt(txtFilial.Text), di, df).Tables(0)
            Else
                tbFatura = wsPedido.importaFaturaNumero(CInt(txtNumero.Text), CInt(txtFilial.Text)).Tables(0)
            End If

            If tbFatura.Rows.Count > 0 Then
                For i = 0 To tbFatura.Rows.Count - 1
                    Dim strSQLFatura As String = "Select 1 from fatura where cod_fatura = " & tbFatura.Rows(i)("cod_fatura") & " and id_filial = " & tbFatura.Rows(i)("id_filial") & ""
                    If objPedido.verifica_existencia_registro(strSQLFatura) = False Then
                        Dim strSQL As String = "Insert Into Fatura(cod_fatura, id_filial, data_lancamento, cod_filial_cliente, cod_cliente, id_usuario, " & _
                        "cod_status_fatura, Observacao, vencimento, NF_emitente, NF_numero) Values(" & tbFatura.Rows(i)("cod_fatura") & "," & _
                        tbFatura.Rows(i)("id_filial") & "," & d.pdtm(tbFatura.Rows(i)("data_lancamento")) & "," & _
                        tbFatura.Rows(i)("cod_filial_cliente") & "," & tbFatura.Rows(i)("cod_cliente") & "," & _
                        tbFatura.Rows(i)("id_usuario") & "," & tbFatura.Rows(i)("cod_status_fatura") & "," & _
                        d.PStr(tbFatura.Rows(i)("observacao")) & "," & d.pdtm(tbFatura.Rows(i)("vencimento")) & "," & _
                        d.cdin(tbFatura.Rows(i)("NF_emitente")) & "," & d.cdin(tbFatura.Rows(i)("NF_numero")) & ")"
                        d.conecta()

                        Dim cmd As New SqlCommand(strSQL, d.con)
                        cmd.ExecuteNonQuery()
                        strTexto = "Fatura Nº " & tbFatura.Rows(i)("cod_fatura") & " inserida com sucesso."
                        txtLog.Text = strTexto & vbCrLf & txtLog.Text
                    End If

                    tbFaturaItem = wsPedido.importaFaturaItem(tbFatura.Rows(i)("cod_fatura"), tbFatura.Rows(i)("id_filial")).Tables(0)
                    If tbFaturaItem.Rows.Count > 0 Then
                        For j = 0 To tbFaturaItem.Rows.Count - 1
                            Dim strSQLFaturaItem As String = "Select 1 from fatura_itens where cod_fatura = " & tbFaturaItem.Rows(j)("cod_fatura") & " and id_filial = " & tbFaturaItem.Rows(j)("id_filial") & ""
                            If objPedido.verifica_existencia_registro(strSQLFaturaItem) = False Then
                                Dim strSQLItem As String = "Insert Into Fatura_Itens(item, cod_fatura, id_filial, num_pedido, id_filial_pedido) " & _
                                "Values(" & tbFaturaItem.Rows(j)("item") & "," & tbFaturaItem.Rows(j)("cod_fatura") & "," & _
                                tbFaturaItem.Rows(j)("id_filial") & "," & tbFaturaItem.Rows(j)("num_pedido") & "," & _
                                tbFaturaItem.Rows(j)("id_filial_pedido") & ")"
                                d.conecta()

                                Dim cmdItem As New SqlCommand(strSQLItem, d.con)
                                cmdItem.ExecuteNonQuery()
                            End If
                        Next
                    End If
                Next
            End If

            d.desconecta()
        Catch ex As System.Web.Services.Protocols.SoapException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub inseriAndamento(ByVal idfilial As Int16, ByVal intCodOs As Integer, ByVal intFilialAndamento As Integer, ByVal intOrdem As Integer, _
                            ByVal dtData As DateTime, ByVal intCodAndamento As Integer, ByVal intUsuario As Integer, _
                            ByVal intCodStatusAndamento As Integer, ByVal obs As String)
        Dim strSQLInsertAndamento As String = "insert into andamentos (id_filial, cod_os, id_filial_andamento, ordem, data," & _
                        "cod_andamento, cod_usuario, cod_status_andamento, Observacao) values(" & idfilial & "," & _
                        intCodOs & "," & intFilialAndamento & "," & intOrdem & "," & _
                        d.pdtm(dtData) & "," & intCodAndamento & "," & intUsuario & "," & _
                        intCodStatusAndamento & "," & d.PStr(obs) & ")"
        d.conecta()
        Try
            Dim cmdAndamento As New SqlCommand(strSQLInsertAndamento, d.con)
            cmdAndamento.ExecuteNonQuery()
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub rbData_Click(sender As System.Object, e As System.EventArgs) Handles rbData.Click
        txtNumero.Enabled = False
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
    End Sub

    Private Sub rbNumero_Click(sender As System.Object, e As System.EventArgs) Handles rbNumero.Click
        txtNumero.Enabled = True
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
    End Sub

    Private Sub os()
        Dim tbOS As New DataTable
        Dim tbOSAndamento As New DataTable
        Dim tbPedido As New DataTable
        Dim tbPedidoItem As New DataTable
        Dim tbServico As New DataTable
        Dim di As DateTime = DateTimePicker1.Value.ToShortDateString & " 00:00:00"
        Dim df As DateTime = DateTimePicker2.Value.ToShortDateString & " 23:59:59"
        Dim i, j, l, m As Integer
        Dim strTexto As String = ""
        If rbData.Checked = True Then
            tbOS = wsPedido.importaOSFiliaisLabonorteData(di, df).Tables(0)
        End If
        If rbNumero.Checked = True Then
            tbOS = wsPedido.importaOSFiliaisLabonorteNumero(CInt(txtNumero.Text), CInt(txtFilial.Text)).Tables(0)
        End If
        'Pecorre todos os registros da tabela OS
        For i = 0 To tbOS.Rows.Count - 1
            'Retorna se a OS foi encontrada
            Dim strSQL As String = "Select 1 From OS where num_pedido = " & tbOS.Rows(i)("num_pedido") & " and id_filial = " & tbOS.Rows(i)("id_filial")
            If tbOS.Rows(i)("num_pedido") IsNot DBNull.Value Then
                If objPedido.verifica_existencia_registro(strSQL) = False Then 'Caso não exista a OS na base local insere a OS
                    Dim strSQLInsertOS As String = "Insert Into OS(id_filial, cod_os, num_pedido, cod_tab_od, cod_tab_oe, cod_produto_od, cod_produto_oe, " & _
                    "esf_od_longe, cil_od_longe, esf_od_perto, cil_od_perto, dnp_od_longe, dnp_od_perto, base_od, adicao_od, altura_od, diametro_od, " & _
                    "eixo_od, esf_oe_longe, cil_oe_longe, esf_oe_perto, cil_oe_perto, dnp_oe_longe, dnp_oe_perto, base_oe, adicao_oe, altura_oe, " & _
                    "diametro_oe, eixo_oe, aro_horizontal, aro_vertical, maior_diametro, ponte, cod_Tipo_Armacao, crm_oftalmologista, " & _
                    "cod_filial_cliente, doc_cliente, cod_cliente, data_venda, data_previsao_entrega, hora_previsao_entrega, cod_vendedora, " & _
                    "cod_qfez, observacao, nota_serie, cod_verif_por, data_verificacao, cod_surfacagem, cod_montagem, confeccao, coloracao, " & _
                    "cor_coloracao, data_recebimento, data_fim_servico, cod_fase, tipo_receita_OD, tipo_receita_OE, id_laboratorio, cod_lab_surf, " & _
                    "listado, forma, cod_tipo_os) values(" & tbOS.Rows(i)("id_filial") & "," & tbOS.Rows(i)("cod_os") & "," & _
                    d.cdin(tbOS.Rows(i)("num_pedido")) & "," & d.cdin(tbOS.Rows(i)("cod_tab_od")) & "," & tbOS.Rows(i)("cod_tab_oe") & "," & _
                    d.cdin(tbOS.Rows(i)("cod_produto_od")) & "," & d.cdin(tbOS.Rows(i)("cod_produto_oe")) & "," & _
                    d.cdin(tbOS.Rows(i)("esf_od_longe")) & "," & d.cdin(tbOS.Rows(i)("cil_od_longe")) & "," & d.cdin(tbOS.Rows(i)("esf_od_perto")) & "," & _
                    d.cdin(tbOS.Rows(i)("cil_od_perto")) & "," & d.cdin(tbOS.Rows(i)("dnp_od_longe")) & "," & d.cdin(tbOS.Rows(i)("dnp_od_perto")) & "," & _
                    d.cdin(tbOS.Rows(i)("base_od")) & "," & d.cdin(tbOS.Rows(i)("adicao_od")) & "," & d.cdin(tbOS.Rows(i)("altura_od")) & "," & _
                    d.cdin(tbOS.Rows(i)("diametro_od")) & "," & d.cdin(tbOS.Rows(i)("eixo_od")) & "," & d.cdin(tbOS.Rows(i)("esf_oe_longe")) & "," & _
                    d.cdin(tbOS.Rows(i)("cil_oe_longe")) & "," & d.cdin(tbOS.Rows(i)("esf_oe_perto")) & "," & d.cdin(tbOS.Rows(i)("cil_oe_perto")) & "," & _
                    d.cdin(tbOS.Rows(i)("dnp_oe_longe")) & "," & d.cdin(tbOS.Rows(i)("dnp_oe_perto")) & "," & d.cdin(tbOS.Rows(i)("base_oe")) & "," & _
                    d.cdin(tbOS.Rows(i)("adicao_oe")) & "," & d.cdin(tbOS.Rows(i)("altura_oe")) & "," & d.cdin(tbOS.Rows(i)("diametro_oe")) & "," & _
                    d.cdin(tbOS.Rows(i)("eixo_oe")) & "," & d.cdin(tbOS.Rows(i)("aro_horizontal")) & "," & d.cdin(tbOS.Rows(i)("aro_vertical")) & "," & _
                    d.cdin(tbOS.Rows(i)("maior_diametro")) & "," & d.cdin(tbOS.Rows(i)("ponte")) & "," & d.cdin(tbOS.Rows(i)("cod_Tipo_Armacao")) & "," & _
                    d.cdin(tbOS.Rows(i)("crm_oftalmologista")) & "," & d.cdin(tbOS.Rows(i)("cod_filial_cliente")) & "," & _
                    d.cdin(tbOS.Rows(i)("doc_cliente")) & "," & d.cdin(tbOS.Rows(i)("cod_cliente")) & "," & d.Pdt(tbOS.Rows(i)("data_venda")) & "," & _
                    d.Pdt(tbOS.Rows(i)("data_previsao_entrega")) & "," & d.PStr(tbOS.Rows(i)("hora_previsao_entrega")) & "," & _
                    d.cdin(tbOS.Rows(i)("cod_vendedora")) & "," & d.cdin(tbOS.Rows(i)("cod_qfez")) & "," & d.PStr(tbOS.Rows(i)("observacao")) & "," & _
                    d.PStr(tbOS.Rows(i)("nota_serie")) & "," & d.cdin(tbOS.Rows(i)("cod_verif_por")) & "," & _
                    d.Pdt(tbOS.Rows(i)("data_verificacao")) & "," & d.cdin(tbOS.Rows(i)("cod_surfacagem")) & "," & d.cdin(tbOS.Rows(i)("cod_montagem")) & "," & _
                    d.PStr(tbOS.Rows(i)("confeccao")) & "," & d.PStr(tbOS.Rows(i)("coloracao")) & "," & _
                    d.PStr(tbOS.Rows(i)("cor_coloracao")) & "," & d.Pdt(tbOS.Rows(i)("data_recebimento")) & "," & _
                    d.Pdt(tbOS.Rows(i)("data_fim_servico")) & "," & d.cdin(tbOS.Rows(i)("cod_fase")) & "," & d.cdin(tbOS.Rows(i)("tipo_receita_OD")) & "," & _
                    d.cdin(tbOS.Rows(i)("tipo_receita_OE")) & "," & d.cdin(tbOS.Rows(i)("id_laboratorio")) & "," & d.cdin(tbOS.Rows(i)("cod_lab_surf")) & "," & _
                    d.Pdt(tbOS.Rows(i)("listado")) & "," & d.PStr(tbOS.Rows(i)("forma")) & "," & d.cdin(tbOS.Rows(i)("cod_tipo_os")) & ")"
                    d.conecta()
                    Dim cmdOS As New SqlCommand(strSQLInsertOS, d.con)
                    cmdOS.ExecuteNonQuery()
                    strTexto = "OS Nº " & tbOS.Rows(i)("cod_os") & " inserida com sucesso."
                    txtLog.Text = strTexto & vbCrLf & txtLog.Text

                    'Importa os andamentos da OS em questão
                    tbOSAndamento = wsPedido.importaAndamentoOS(tbOS.Rows(i)("cod_os"), tbOS.Rows(i)("id_filial")).Tables(0)
                    If tbOSAndamento.Rows.Count > 0 Then
                        For j = 0 To tbOSAndamento.Rows.Count - 1
                            Dim strSQLAndamento As String = "Select 1 from andamentos where cod_os = " & tbOSAndamento.Rows(j)("cod_os") & _
                                " and id_filial = " & tbOSAndamento.Rows(j)("id_filial") & " and id_filial_andamento = " & _
                                tbOSAndamento.Rows(j)("id_filial_andamento") & " and ordem = " & tbOSAndamento.Rows(j)("ordem")
                            If objPedido.verifica_existencia_registro(strSQLAndamento) = False Then
                                'Grava os andamentos da OS
                                inseriAndamento(tbOSAndamento.Rows(j)("id_filial"), tbOSAndamento.Rows(j)("cod_os"), tbOSAndamento.Rows(j)("id_filial_andamento"), _
                                tbOSAndamento.Rows(j)("ordem"), tbOSAndamento.Rows(j)("data"), tbOSAndamento.Rows(j)("cod_andamento"), _
                                tbOSAndamento.Rows(j)("cod_usuario"), tbOSAndamento.Rows(j)("cod_status_andamento"), _
                                tbOSAndamento.Rows(j)("observacao").ToString)
                            End If
                        Next
                    End If

                    'Importa Pedido
                    tbPedido = wsPedido.importaPedido(tbOS.Rows(i)("num_pedido"), tbOS.Rows(i)("id_filial")).Tables(0) 'Retorna o Pedido
                    If tbPedido.Rows.Count > 0 Then
                        Dim strSQLPedido As String = "Select 1 From Pedido_Balcao where num_pedido = " & tbPedido.Rows(0)("num_pedido") & " and id_filial = " & tbPedido.Rows(0)("id_filial")
                        If objPedido.verifica_existencia_registro(strSQLPedido) = False Then
                            Dim strSQLInsertPedido As String = "Insert Into Pedido_Balcao(num_pedido, id_filial, cod_vendedor, data_pedido, cod_cliente, cod_filial_cliente, " & _
                            "cod_status_pedido, cod_autorizacao, filial_autorizacao, forma, cod_tipo_pedido, valor_pago, valor_apagar, " & _
                            "valor_devolvido, cod_vendedor_ext, desconto) values(" & tbPedido.Rows(0)("num_pedido") & "," & tbPedido.Rows(0)("id_filial") & "," & _
                            tbPedido.Rows(0)("cod_vendedor") & "," & d.pdtm(tbPedido.Rows(0)("data_pedido")) & "," & tbPedido.Rows(0)("cod_cliente") & "," & _
                            tbPedido.Rows(0)("cod_filial_cliente") & "," & tbPedido.Rows(0)("cod_status_pedido") & "," & _
                            d.cdin(tbPedido.Rows(0)("cod_autorizacao")) & "," & d.cdin(tbPedido.Rows(0)("filial_autorizacao")) & "," & _
                            d.PStr(tbPedido.Rows(0)("forma")) & "," & d.cdin(tbPedido.Rows(0)("cod_tipo_pedido")) & "," & _
                            d.cdin(tbPedido.Rows(0)("valor_pago")) & "," & d.cdin(tbPedido.Rows(0)("valor_apagar")) & "," & _
                            d.cdin(tbPedido.Rows(0)("valor_devolvido")) & "," & _
                            tbPedido.Rows(0)("cod_vendedor_ext") & "," & d.PStr(tbPedido.Rows(0)("desconto")) & ")"
                            d.conecta()
                            Dim cmdPedido As New SqlCommand(strSQLInsertPedido, d.con)
                            cmdPedido.ExecuteNonQuery()

                            'Retorna o item do pedido apta dentro do obejto tbPedidoItem
                            tbPedidoItem = wsPedido.importaPedidoItem(tbPedido.Rows(0)("num_pedido"), tbPedido.Rows(0)("id_filial")).Tables(0)
                            If tbPedidoItem.Rows.Count > 0 Then
                                For l = 0 To tbPedidoItem.Rows.Count - 1
                                    Dim strSQLPedidoItem As String = "Select 1 from pedido_balcao_itens where num_pedido = " & tbPedidoItem.Rows(l)("num_pedido") & " and id_filial = " & tbPedidoItem.Rows(l)("id_filial") & _
                                        " and item = " & tbPedidoItem.Rows(l)("item")
                                    If objPedido.verifica_existencia_registro(strSQLPedidoItem) = False Then
                                        Dim strSQLItemPedido As String = "Insert Into Pedido_Balcao_Itens(num_pedido, id_filial, item, cod_produto, quant, compra, " & _
                                        "desconto, preco, cod_status_item, Pacote, cod_pacote, desc_caixa, usuario_can, tipo_devolucao, devolvido_estoque, " & _
                                        "data_devolucao, preco_tab) values(" & tbPedidoItem.Rows(l)("num_pedido") & "," & _
                                        tbPedidoItem.Rows(l)("id_filial") & "," & tbPedidoItem.Rows(l)("item") & "," & _
                                        tbPedidoItem.Rows(l)("cod_produto") & "," & tbPedidoItem.Rows(l)("quant") & "," & _
                                        d.cdin(tbPedidoItem.Rows(l)("compra")) & "," & d.cdin(tbPedidoItem.Rows(l)("desconto")) & "," & _
                                        d.cdin(tbPedidoItem.Rows(l)("preco")) & "," & tbPedidoItem.Rows(l)("cod_status_item") & "," & _
                                        d.PStr(tbPedidoItem.Rows(l)("pacote")) & "," & d.cdin(tbPedidoItem.Rows(l)("cod_pacote")) & "," & _
                                        d.cdin(tbPedidoItem.Rows(l)("desc_caixa")) & "," & d.cdin(tbPedidoItem.Rows(l)("usuario_can")) & "," & _
                                        d.PStr(tbPedidoItem.Rows(l)("tipo_devolucao")) & "," & d.PStr(tbPedidoItem.Rows(l)("devolvido_estoque")) & "," & _
                                        d.pdtm(tbPedidoItem.Rows(l)("data_devolucao")) & "," & d.cdin(tbPedidoItem.Rows(l)("preco_tab")) & ")"
                                        d.conecta()

                                        Dim cmdItemPedido As New SqlCommand(strSQLItemPedido, d.con)
                                        cmdItemPedido.ExecuteNonQuery()
                                    End If
                                Next
                            End If

                            'Retorna o serviço caso exista para dentro do objeto tbServico
                            tbServico = wsPedido.importaPedidoServico(tbPedido.Rows(0)("num_pedido"), tbPedido.Rows(0)("id_filial")).Tables(0)
                            If tbServico.Rows.Count > 0 Then
                                For m = 0 To tbServico.Rows.Count - 1
                                    Dim strSQLServicoPedido As String = "Select 1 from pedido_balcao_servicos where num_pedido = " & tbServico.Rows(m)("num_pedido") & _
                                    " and id_filial = " & tbServico.Rows(m)("id_filial") & " and item_servico = " & tbServico.Rows(m)("item_servico")
                                    If objPedido.verifica_existencia_registro(strSQLServicoPedido) = False Then
                                        'Grava os serviços do Pedido
                                        Dim strSQLServico As String = "Insert Into Pedido_Balcao_Servicos(num_pedido, id_filial, item_servico, " & _
                                            "cod_servico, quant, compra, desconto, preco, desc_caixa, cod_status_servico, pacote, cod_pacote, " & _
                                            "usuario_can, tipo_devolucao, devolvido_estoque, data_devolucao, preco_tab) values(" & _
                                            tbServico.Rows(m)("num_pedido") & "," & tbServico.Rows(m)("id_filial") & "," & _
                                            tbServico.Rows(m)("item_servico") & "," & tbServico.Rows(m)("cod_servico") & "," & _
                                            tbServico.Rows(m)("quant") & "," & d.cdin(tbServico.Rows(m)("compra")) & "," & _
                                            d.cdin(tbServico.Rows(m)("desconto")) & "," & d.cdin(tbServico.Rows(m)("preco")) & "," & _
                                            d.cdin(tbServico.Rows(m)("desc_caixa")) & "," & tbServico.Rows(m)("cod_status_servico") & "," & _
                                            d.PStr(tbServico.Rows(m)("pacote")) & "," & d.cdin(tbServico.Rows(m)("cod_pacote")) & "," & _
                                            d.cdin(tbServico.Rows(m)("usuario_can")) & "," & d.PStr(tbServico.Rows(m)("tipo_devolucao")) & "," & _
                                            d.cdin(tbServico.Rows(m)("devolvido_estoque")) & "," & d.pdtm(tbServico.Rows(m)("data_devolucao")) & "," & _
                                            d.cdin(tbServico.Rows(m)("preco_tab")) & ")"
                                        d.conecta()

                                        Dim cmdServido As New SqlCommand(strSQLServico, d.con)
                                        cmdServido.ExecuteNonQuery()
                                    End If
                                Next
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub
End Class