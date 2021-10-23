Imports mrotica_util
Public Class frmDevolvePedido
    Dim pedido As New objPedidoBalcao
    Public numPedido, IDfilial As Integer
    Dim tb_itens As New DataTable
    Dim conf As New config
    Dim valor_cancelamento As Double
    Public dev As New objDevolucaoEstoquePedido
    Dim user As New objUsuario
    Dim prod As New produtoClass
    Dim credito As New objCreditoCliente
    Private Sub frmDevolvePedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_pedido(numPedido, IDfilial)
    End Sub
    Public Sub carrega_pedido(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        pedido.Source("Select * from pedido_balcao where num_pedido = " & x_num_pedido & _
        " and id_filial = " & x_id_filial)
        If pedido.max > 0 Then
            lblNpedido.Text = pedido.num_pedido
            carrega_itens(x_num_pedido, x_id_filial)
        End If

    End Sub
    Private Sub carrega_itens(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        tb_itens = pedido.lista_itens(x_num_pedido, x_id_filial, False)
        formata_grid_itens()
    End Sub
    Private Sub formata_grid_itens()
        Dim TStb As New DataGridTableStyle
        grdProd.DataSource = tb_itens
        TStb.MappingName = grdProd.DataSource.tablename
        Dim cItem As New DataGridTextBoxColumn
        With cItem
            .MappingName = "item"
            .HeaderText = " "
            .Width = 20
        End With
        TStb.GridColumnStyles.Add(cItem)

        Dim cProd As New DataGridTextBoxColumn
        With cProd
            .MappingName = "Produto"
            .HeaderText = "Produto"
            .Width = 320
        End With
        TStb.GridColumnStyles.Add(cProd)

        Dim cQuant As New DataGridTextBoxColumn
        With cQuant
            .MappingName = "quant"
            .HeaderText = "Q."
            .Width = 20
        End With
        TStb.GridColumnStyles.Add(cQuant)

        Dim cDesc As New DataGridTextBoxColumn
        With cDesc
            .MappingName = "desconto"
            .HeaderText = "Desc."
            .Format = "#,##0.00 "
            .Alignment = HorizontalAlignment.Right
            .Width = 33
        End With
        TStb.GridColumnStyles.Add(cDesc)

        Dim cPreco As New DataGridTextBoxColumn
        With cPreco
            .MappingName = "preco"
            .HeaderText = "P. Unit."
            .Format = "#,##0.00 "
            .Alignment = HorizontalAlignment.Right
        End With
        TStb.GridColumnStyles.Add(cPreco)

        Dim cTotal As New DataGridTextBoxColumn
        With cTotal
            .MappingName = "Total"
            .HeaderText = "Total."
            .Format = "#,##0.00 "
            .Alignment = HorizontalAlignment.Right
        End With
        TStb.GridColumnStyles.Add(cTotal)

        Dim cStatus_item As New DataGridTextBoxColumn
        With cStatus_item
            .MappingName = "status_item"
            .HeaderText = "Status"
            .Width = 120
        End With
        TStb.GridColumnStyles.Add(cStatus_item)
        Dim cPacote As New DataGridTextBoxColumn
        With cPacote
            .MappingName = "cod_pacote"
            .HeaderText = "Pct."
        End With
        TStb.GridColumnStyles.Add(cPacote)
        grdProd.TableStyles.Clear()
        grdProd.TableStyles.Add(TStb)
    End Sub
    Private Sub btnDevolverItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolverItens.Click
        Dim f As New frmDevolucaoPedido
        dev.filtrar(pedido.num_pedido, pedido.id_filial)
        If dev.max = 0 Then
            dev.novo()
            dev.id_usuario = UserID
            dev.id_filial = conf.Filial
            dev.doc = "Devolução do Pedido " & adiciona_zeros(pedido.id_filial, 3) & "-" & pedido.num_pedido
            dev.data = Now
            dev.id_filial_pedido = pedido.id_filial
            dev.num_pedido = pedido.num_pedido
            dev.Salvar()
        Else
            If dev.concluido = "S" Then
                dev.novo()
                dev.id_usuario = UserID
                dev.id_filial = conf.Filial
                dev.doc = "Devolução do Pedido " & adiciona_zeros(pedido.id_filial, 3) & "-" & pedido.num_pedido
                dev.data = Now
                dev.id_filial_pedido = pedido.id_filial
                dev.num_pedido = pedido.num_pedido
                dev.Salvar()
            End If
        End If
        Dim i, m As Integer
        i = 0
        m = grdProd.DataSource.rows.count
        While i < m
            If grdProd.IsSelected(i) = True Then
                Dim item As Integer = grdProd.Item(i, 0)
                Dim status As status_item_pedido
                status = pedido.retorna_status_item(item)
                If status = status_item_pedido.baixado_estoque Then
                    dev.insere_item_devolucao(item, 1, 1)
                End If
            End If
            i = i + 1
        End While
        f.dev = dev
        f.ShowDialog(Me)
        i = 0
        m = grdProd.DataSource.rows.count
        dev.refreshData()
        For Each r As DataRow In dev.lista_itens_devolucao.Rows
            Dim item As Integer = r("id_item")
            Dim status As status_item_pedido
            status = status_item_pedido.devolvido_estoque
            If r("quant") = r("devolvido") Then
                pedido.altera_status_item(item, status)
                dev.atualiza_valor_itens(grdProd.Item(item - 1, 5))
            Else
                If r("devolvido") > 0 Then
                    Dim re As MsgBoxResult
                    re = MsgBox("A quantidade devolvida é menor que a quantidade de itens, " & _
                               "deseja devolver apenas " & r("devolvido") & " unidade(s)", MsgBoxStyle.YesNo)
                    If re = MsgBoxResult.Yes Then
                        'Cancela o item inteiro,
                        Dim vcan As Double = grdProd.Item(item - 1, 5)
                        Dim q As Integer = grdProd.Item(item - 1, 2)
                        vcan = vcan / q
                        dev.atualiza_valor_itens(vcan * r("devolvido"))
                        status = status_item_pedido.devolvido_estoque
                        pedido.devolve_item_status(pedido.num_pedido, pedido.id_filial, item, status)
                        'e lanca um novo item com a quantidade não devolvida
                        MsgBox(pedido.insere_item_dev(r("cod_produto"), rdNum(r("quant")) - rdNum(r("devolvido")), _
                              rdNum(r("desconto")), rdNum(r("preco")), rdNum(r("cod_pacote")), rdNum(r("desc_caixa"))))
                        MsgBox(dev.devolve_produto(r("cod_produto"), rdNum(r("quant")) - rdNum(r("devolvido"))))
                        MsgBox(saida_pedido(r("cod_produto"), (rdNum(r("quant")) - rdNum(r("devolvido") * -1))))
                        MsgBox(pedido.altera_status_item(pedido.ultimo_item, status_item_pedido.baixado_estoque))

                    End If
                End If
            End If
        Next
        carrega_itens(pedido.num_pedido, pedido.id_filial)
        conclui_Devolucao()
    End Sub
    Public Function saida_pedido(ByVal x_cod_prod As Integer, ByVal xq As Integer) As String
        Dim saida As New objSaidaPedido
        saida.novo()
        saida.cod_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial & "")
        saida.cod_saida_pedido = retorna_Chave("cod_saida_os", "saida_os", " where cod_movimento = " & saida.cod_movimento & " and id_filial = " & conf.Filial & "") + 1
        saida.cod_natureza = 2
        saida.id_filial = pedido.id_filial
        saida.num_pedido = pedido.num_pedido
        saida.data = Now.ToString
        saida.doc = "Pedido.: " & pedido.id_filial & " - " & pedido.num_pedido & " Ajuste devolução"
        saida.id_usuario = UserID
        saida.Salvar()
        Return saida.baixa_produto(x_cod_prod, xq, "Baixa automática da devolução do pedido:" & _
                                   pedido.id_filial & "-" & pedido.num_pedido)
    End Function
    Private Sub conclui_Devolucao()
        If dev.todos_devolvidos = True Then
            AVISO(dev.conclui_movimento(), Me, frmAviso.tipo_aviso.tipo_ok)
            fimPedido(False)
            Me.Close()
        End If
    End Sub
    Private Sub conclui_cancela()
        fimPedido(False)
        Me.Close()
    End Sub
    Private Sub fimPedido(ByVal cancelamento As Boolean)
        Dim rpt As New rptCancOSrpx
        Dim f As New frmRpt
        Dim valor_credito As Double
        Dim fat_apagar As Double = 0
        Dim fatura As New objFatura
        Dim lista_servicos As String
        Dim lista_devolucao As String
        Dim res As String = ""
        valor_cancelamento = dev.valor_itens
        fatura.abrir_fatura(pedido.fatura(1), pedido.fatura(0))
        fat_apagar = fatura.a_pagar
        If pedido.faturado Then
            If fat_apagar < valor_cancelamento Then
                valor_credito = valor_cancelamento - fat_apagar
                If valor_credito < 0 Then
                    valor_credito = valor_cancelamento
                End If
            ElseIf fat_apagar = 0 Then
                valor_credito = valor_cancelamento
            Else
                valor_credito = 0
            End If
            If valor_credito > 0 Then
                res = credito.credito_cancelamento(conf.Filial, valor_credito, pedido.cod_filial_cliente, _
                    pedido.cod_cliente, "Crédito devolução pedido " & pedido.id_filial & _
                    "-" & pedido.num_pedido & vbCrLf & txtDescricao.Text)
                If res.StartsWith("OK") Then
                    fatura.insere_acrescimo(valor_credito, 3, "Ajuste Ref. devolução do pedido " & pedido.id_filial & _
                "-" & pedido.num_pedido)
                End If
            Else
                res = "Sem Crédito!"
            End If
        End If
        lista_servicos = preenche_lista_servicos(pedido.lista_servicos(pedido.num_pedido, pedido.id_filial))

        If cancelamento = False Then
            lista_devolucao = preenche_lista_devolucao(dev.lista_itens_devolucao, cancelamento)
            txtDescricao.Text = "Devolução de Pedido nº " & dev.cod_devolucao_pedido & vbCrLf & _
            " Num. Pedido: " & pedido.num_pedido & " Usuário: " & user.nome & vbCrLf & _
            " PRODUTOS DEVOLVIDOS: " & _
            lista_devolucao & vbCrLf & _
            res
        Else
            valor_cancelamento = pedido.total_itens + pedido.total_servicos
            lista_devolucao = preenche_lista_devolucao(pedido.lista_itens(pedido.num_pedido, pedido.id_filial, False), cancelamento)
            pedido.cancelamento_itens()
            pedido.cancela_servicos()
            txtDescricao.Text = "Cancelamento de OS nº " & dev.cod_devolucao_pedido & vbCrLf & _
            " Num. Pedido: " & pedido.num_pedido & " Usuário: " & user.nome & vbCrLf & _
            " PRODUTOS CANCELADOS: " & _
            lista_devolucao & vbCrLf & _
            " SERVIÇOS CANCELADOS: " & _
            lista_servicos
        End If
        pedido.zera_valor_devolvidos()
        rpt.txtRTF = txtDescricao.Text
        f.Relat(rpt)
        f.ShowDialog(Me)
    End Sub
    Private Function preenche_lista_servicos(ByVal tb As DataTable) As String
        Dim i, m As Integer
        Dim str As String = ""
        i = 0
        m = tb.Rows.Count
        While i < m
            str = str & vbCrLf & i + 1 & "-" & tb.Rows(i)("produto") & " Quant.: " & tb.Rows(i)("quant") & " Cancelado"
            i = i + 1
        End While
        Return str
    End Function
    Private Function preenche_lista_devolucao(ByVal tb As DataTable, ByVal devolucao As Boolean) As String
        Dim i, m As Integer
        Dim str As String = ""
        Dim dev As String
        If devolucao = True Then
            dev = " devolvido"
        Else
            dev = " cancelado"
        End If
        i = 0
        m = tb.Rows.Count
        While i < m
            str = str & vbCrLf & i + 1 & "-" & prod.Retorna_nome_prod(tb.Rows(i)("cod_produto")) & " Quant.: " & tb.Rows(i)("quant") & dev & "!"
            i = i + 1
        End While
        Return str
    End Function

End Class