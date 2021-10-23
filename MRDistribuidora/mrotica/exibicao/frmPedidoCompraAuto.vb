Imports mrotica_util
Public Class frmPedidoCompraAuto
    Dim d As New dados
    Dim pedido As New objPedidoCompra
    Public acao As Integer
    Public tipo_pedido As Integer
    Dim prod As New produtoClass
    Dim tb_Prod_n_pedido As New DataTable
    Dim cp As New objcompras
    Dim mov As New objMovimentoDetalhe
    Dim andamentos As New objAndamentos
    Dim item_atual As Integer = 0
    Dim conf As New config
    Private Sub frmPedidoCompraAuto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Ao abrir o Form, avalia se um novo pedido será incluido ou se 
        'será feita a edição de um pedido existente.
        If acao = pedido_compra_acao.pedido_novo Then
            pedido.novo()
            pedido.cod_tipo = tipo_pedido_compra.Pedido_auto 'Identifica o pedido como um pedido 
            'gerado automaticamente pelas necessidades de Os's já feitas, que aguardam itens não
            'disponíveis em estoque quando de sua venda.
            grpItens.Enabled = True
        End If
        If acao = pedido_compra_acao.pedido_edicao Then
            carrega_pedido()
            grpItens.Enabled = True
        End If
        If acao = pedido_compra_acao.pedido_Entrada Then
            'Abre pedido para conferencia e entrada no estoque.
            carrega_pedido()
            If pedido.cod_status_pedido = pedido.status_pedido.pedido_chegou _
            Or pedido.cod_status_pedido = pedido.status_pedido.Pedido_em_aberto Or _
            pedido.cod_status_pedido = objPedidoCompra.status_pedido.pedido_efetuado Then
                pedido.editar()
                pedido.cod_status_pedido = pedido.status_pedido.pedido_em_conferencia
                pedido.Salvar()
            End If
            txtDoc.ReadOnly = False
            grpConferir.Visible = True
            grpConferir.Enabled = False
            cria_tabela_prod_n_pedido()
            Carrega_extras()
        End If
    End Sub
    Private Sub Carrega_extras()
        Try
            tb_Prod_n_pedido.ReadXml(Application.StartupPath & "\temp_data\" & pedido.cod_pedido & pedido.id_filial & ".xml")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cria_tabela_prod_n_pedido()
        'Cria uma tabela temporária para armazenar as lentes que vieram na nota 
        'mas não foram pedidas.
        tb_Prod_n_pedido.TableName = "Temp"
        tb_Prod_n_pedido.Columns.Add("id")
        tb_Prod_n_pedido.Columns.Add("cod_produto")
        tb_Prod_n_pedido.Columns.Add("quant")
        tb_Prod_n_pedido.Columns.Add("desconto")
        tb_Prod_n_pedido.Columns.Add("preco")
        tb_Prod_n_pedido.Columns.Add("cod_tabela")
        tb_Prod_n_pedido.Columns.Add("produto")
        tb_Prod_n_pedido.Columns.Add("cod_barra")

    End Sub
    Private Sub carrega_pedido()
        Dim n_pedido As Integer
        n_pedido = InputBox("Digite o Número do pedido:")
        pedido.carrega_pedido(n_pedido, conf.Filial)
        If pedido.max > 0 Then
            travaControles(grpCabecalho.Controls)
            txtFornecedor.Text = nome_fornecedor(pedido.cod_fornecedor)
            dtPedido.Value = pedido.data_pedido
            txtDoc.Text = pedido.nota_fiscal
            carrega_grid()
            item_atual = 1
        Else
            MsgBox("Pedido não encontrado!")
            Me.Close()
        End If
    End Sub
    Private Function nome_fornecedor(ByVal cod As Integer) As String
        Dim forn As New objForn
        Return forn.retorna_nome(cod)
    End Function
    Private Sub txtFornecedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFornecedor.KeyDown
        Dim f As New frmConsultaForPesq
        Select Case e.KeyCode
            Case Keys.Enter
                f.ShowDialog(Me)
                pedido.cod_fornecedor = f.cod_fornecedor
                txtFornecedor.Text = f.nome
                f.Dispose()
        End Select
    End Sub
    Private Sub btnSalvarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarPedido.Click
        'Salva o cabeçalho do pedido de fornecedor, e abre o form de itens sugeridos pelo sistema
        'baseados nas Os's que não tinham estoque disponível para atendê-las.
        If acao = pedido_compra_acao.pedido_novo Then
            pedido.cod_usuario = UserID
            pedido.cod_status_pedido = 1
            pedido.id_filial = conf.Filial
            pedido.data_pedido = dtPedido.Value
            MsgBox(pedido.Salvar)
            acao = pedido_compra_acao.pedido_edicao
            grpItens.Enabled = True
            abre_form_sugestao()
        End If
        If acao = pedido_compra_acao.pedido_edicao Or acao = pedido_compra_acao.pedido_Entrada Then
            pedido.editar()
            pedido.nota_fiscal = txtDoc.Text
            MsgBox(pedido.Salvar())
            grpConferir.Enabled = True
            txtCodBarra.Focus()
        End If

    End Sub
    Private Sub abre_form_sugestao()
        Dim f As New frmSugestaoCompraOS
        Dim sql As String
        Dim fab As String
        Dim tb_fab As New DataTable
        Dim i As Integer
        'Identifica os Fabricantes que determindao fornecedor
        'vende e passa os códigos para o form de sugestão de compra
        'exibindo apenas os produtos que o fornecedor oferece.
        sql = "select id_fabricante from fabricantes_do_fornecedor where cod_fornecedor = " & _
        pedido.cod_fornecedor & ""
        d.carrega_Tabela(sql, tb_fab)
        While tb_fab.Rows.Count > i
            If i = 0 Then
                fab = tb_fab.Rows(i)(0) & ";"
            Else
                fab = tb_fab.Rows(i)(0) & ";" & fab
            End If
            i = i + 1
        End While
        fab = fab.Remove(fab.Length - 1, 1)
        f.fabricantes = fab.Split(";")
        f.ShowDialog(Me)

        'Ao retornar do form com os itens do pedido escolhidos, 
        'insere os itens marcados no pedido!
        Insere_itens(f.tbRet)
        carrega_grid()
        f.Dispose()

    End Sub
    Private Sub Insere_itens(ByVal x_tb As DataTable)
        'Insere os itens escolhidos no pedido
        Dim i As Integer
        Dim item As Integer
        Dim p_compra, d_compra As Object
        i = 0
        item = pedido.lista_itens.Rows.Count + 1
        While i < x_tb.Rows.Count
            insere_pedidos_os(x_tb.Rows(i), item)
            p_compra = rdDinheiro(x_tb.Rows(i)("preco_compra"))
            d_compra = rdDinheiro(x_tb.Rows(i)("desconto"))
            pedido.insere_item(pedido.cod_pedido, pedido.id_filial, x_tb.Rows(i)("cod_produto") _
            , x_tb.Rows(i)("quant"), p_compra, d_compra, 1, _
            x_tb.Rows(i)("doc_cliente"))
            item = item + 1
            i = i + 1
        End While
    End Sub
    Private Sub insere_pedidos_os(ByVal r As DataRow, ByVal x_item As Integer)
        'Cria a referencia do item do pedido para a OS na tabela auxiliar
        'pedido_fornecedor_os. Esta referência será usada quando o pedido 
        'for atendido, para encaminhar os produtos com rapidez para as 
        'devidas OS's.
        Dim sql As String
        Dim os, ped As Integer

        If IsDBNull(r("cod_os")) = True Then
            os = Nothing
        Else
            os = r("cod_os")
        End If
        If IsDBNull(r("num_pedido")) = True Then
            ped = Nothing
        Else
            ped = r("num_pedido")
        End If
        sql = "INSERT INTO pedido_fornecedor_os (cod_os,id_filial,cod_pedido,item" & _
        ",id,num_pedido) VALUES(" & _
        os & _
        "," & r("id_filial") & _
        "," & pedido.cod_pedido & _
        "," & x_item & _
        "," & r("id") & "," & ped & ")"
        d.Comando(sql, True)
    End Sub
    Private Sub carrega_grid()
        grdItens.DataSource = pedido.lista_itens
        If acao = pedido_compra_acao.pedido_Entrada Then
            grdItens.DataSource = pedido.lista_atendidos
            Dim TStb As New DataGridTableStyle
            TStb.MappingName = grdItens.DataSource.tablename

            Dim cTab As New DataGridTextBoxColumn
            With cTab
                .MappingName = "cod_tabela"
                .HeaderText = "Tabela"
            End With
            TStb.GridColumnStyles.Add(cTab)

            Dim cItem As New DataGridTextBoxColumn
            With cItem
                .MappingName = "produto"
                .HeaderText = "Produto"
                .Width = 360
            End With
            TStb.GridColumnStyles.Add(cItem)

            Dim cQ As New DataGridTextBoxColumn
            With cQ
                .MappingName = "quant"
                .HeaderText = "Pedido"

            End With
            TStb.GridColumnStyles.Add(cQ)

            Dim cA As New DataGridTextBoxColumn
            With cA
                .MappingName = "Atend"
                .HeaderText = "Atendido"
            End With
            TStb.GridColumnStyles.Add(cA)

            grdItens.TableStyles.Clear()
            grdItens.TableStyles.Add(TStb)
        End If
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If acao = pedido_compra_acao.pedido_Entrada Then
            relat_diferenca()
        Else
            relat_pedido()
        End If
    End Sub
    Private Sub relat_pedido()
        Dim t As New DataTable
        Dim sql As String
        Dim f As New frmRpt
        Dim r As New rptListaPedido
        sql = "SELECT lentes_tabela.cod_tabela, produtos.produto, produtos.cod_barra," & _
        "SUM(pedido_fornecedor_itens.quantidade) AS quant, " & _
        "pedido_fornecedor_itens.Preco_compra - pedido_fornecedor_itens.Preco_compra * " & _
        "(pedido_fornecedor_itens.desconto_compra / 100) AS Preco, " & _
        "pedido_fornecedor_itens.Preco_compra, pedido_fornecedor_itens.desconto_compra, " & _
        "SUM((pedido_fornecedor_itens.Preco_compra - pedido_fornecedor_itens.Preco_compra * " & _
        "(pedido_fornecedor_itens.desconto_compra / 100)) * pedido_fornecedor_itens.quantidade) " & _
        "AS Total,lentes_tabela.nome_comercial FROM pedido_fornecedor_itens INNER JOIN " & _
        "produtos ON pedido_fornecedor_itens.cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " & _
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " & _
        "WHERE  (pedido_fornecedor_itens.cod_pedido =" & pedido.cod_pedido & ") AND " & _
        "(pedido_fornecedor_itens.id_filial = " & pedido.id_filial & ") " & _
        " GROUP BY lentes_tabela.cod_tabela, produtos.produto, produtos.cod_barra, " & _
        "pedido_fornecedor_itens.Preco_compra,pedido_fornecedor_itens.desconto_compra, " & _
        "pedido_fornecedor_itens.Preco_compra - pedido_fornecedor_itens.Preco_compra " & _
        "* (pedido_fornecedor_itens.desconto_compra / 100),lentes_tabela.nome_comercial"
        d.carrega_Tabela(sql, t)
        r.DataSource = t
        r.titulo = "Pedido Auto Nº " & pedido.cod_pedido & " " & txtFornecedor.Text & " em " & _
        pedido.data_pedido & ""
        f.Relat(r)
        f.ShowDialog(Me)
        Dim resp As Integer

        If pedido.cod_status_pedido = objPedidoCompra.status_pedido.Pedido_em_aberto Then
            resp = AVISO("Deseja Efetuar o Pedido?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
            If resp = frmAviso.respo.SIM Then
                pedido.editar()
                pedido.cod_status_pedido = objPedidoCompra.status_pedido.pedido_efetuado
                pedido.Salvar()
                andamentos_pedido()
                Me.Close()
            End If
        End If
    End Sub
    Private Sub relat_diferenca()
        Dim f As New frmRpt
        Dim r As New rptListaPedidoatendido
        Dim re As Integer
        r.DataSource = pedido.lista_atendidos
        r.tb_n_pedido = tb_Prod_n_pedido
        r.titulo = "Conferência do pedido nº " & pedido.cod_pedido
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
        If pedido.cod_status_pedido = pedido.status_pedido.pedido_em_conferencia Then
            re = AVISO("Concluir pedido e lançar Nota?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
            If re = frmAviso.respo.SIM Then
                Cria_nota_compra()
                Me.Close()
            Else
                Exit Sub
            End If
        End If
    End Sub
    Private Sub relat_pedido_x_os()
        Dim f As New frmRpt
        Dim r As New rptPedido_X_OS
        Dim re As Integer
        r.DataSource = pedido.lista_Pedido_x_OS
        r.tb = pedido.lista_Pedido_x_Balcao
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub
    Private Sub grdItens_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdItens.CurrentCellChanged
        Dim i As Integer
        Dim tt As New DataTable
        Try
            i = grdItens.CurrentRowIndex
            tt = pedido.lista_itens
            item_atual = tt.Rows(i)("item")
        Catch ex As Exception
            item_atual = Nothing
        End Try
    End Sub
    Private Sub grdItens_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdItens.DoubleClick
        If pedido.cod_status_pedido = status_pedido.Em_Aberto Then
            abre_form_sugestao()
        End If
    End Sub
    Private Sub txtCodBarra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodBarra.KeyDown
        If pedido.cod_status_pedido = pedido.status_pedido.pedido_em_conferencia Then
            Select Case e.KeyCode
                Case Keys.Enter
                    checa_produto(txtCodBarra.Text)
                    txtCodBarra.Focus()
            End Select
        Else
            If pedido.cod_status_pedido = pedido.status_pedido.pedido_cancelado Then
                AVISO("Este pedido foi cancelado!", Me, frmAviso.tipo_aviso.tipo_ok)
            End If
            If pedido.cod_status_pedido = pedido.status_pedido.Nota_Lancada Then
                AVISO("Esta nota já foi lançada e o pedido concluído!", Me, frmAviso.tipo_aviso.tipo_ok)
            End If
        End If
    End Sub
    Private Sub checa_produto(ByVal x_barra As String)
        txtCodBarra.Text = ""
        Dim q As Integer = -1 'Quatidade de itens saindo
        Dim f As New frmConsultaProdDiopCod
        Dim cod_prod As Integer
        Dim eS As String
        'Caso não seja informado o código de barras
        'abre formulário para informar detalhes da
        'lente.
        If x_barra = "" Then
            eS = InputBox("Informe o tipo, se 'LENTE' digitar L. Se 'BLOCO' digitar B!").Trim.ToUpper
            If eS.ToString.Trim.ToUpper <> "L" And eS.ToString.ToUpper <> "B" Then
                som_erro()
                MsgBox("Erro!")
                Exit Sub
            End If
            'Se o produto for Lente pronta, abre o formulário 
            'de lente.
            If eS = "L" Then
                f.tipo = "L"
                f.ShowDialog(Me)
                cod_prod = f.Result
            Else
                'Se o produto for bloco, abre o formulário 
                'de bloco.
                f.tipo = "B"
                f.ShowDialog(Me)
                cod_prod = f.Result
            End If
        Else
            'Caso seja informado o código de barras do produto, 
            cod_prod = prod.Retorna_cod_prod(x_barra)
        End If
        Dim atend As String
        atend = pedido.item_atendido(cod_prod)
        Dim r As frmAviso.respo
        Select Case atend.Substring(0, 1)
            Case "N"
                som_erro()
                r = AVISO("Produto " & _
                prod.Retorna_nome_prod(cod_prod) & _
                " não existe no pedido. Deseja inserí-lo na nota? ", Me, _
                 frmAviso.tipo_aviso.tipo_sim_nao)
                If r = frmAviso.respo.SIM Then
                    insere_item_extra(cod_prod)
                Else
                    MsgBox(r)
                End If
            Case "E"
                Dim it As Integer
                If atend.Length > 1 Then
                    it = atend.Substring(1)
                    pedido.atende_pedido(it)
                    som_ok()
                    carrega_grid()
                Else
                    som_erro()
                    r = AVISO("Este item já foi completamente atendido! " & _
                    prod.Retorna_nome_prod(cod_prod) & _
                    " .Deseja inserir mais um na nota de entrada?", Me, _
                    frmAviso.tipo_aviso.tipo_sim_nao)
                    If r = frmAviso.respo.SIM Then
                        insere_item_extra(cod_prod)
                    End If
                End If
            Case "S"
                Dim it As Integer
                it = atend.Substring(1)
                som_erro()
                AVISO("O Status deste item é: " & _
                pedido.retorna_status_item(it)(1) & "!" _
                , Me, _
                frmAviso.tipo_aviso.tipo_ok)
        End Select
    End Sub
    Private Sub insere_item_extra(ByVal x_cod_prod As Integer)
        Dim sql As String
        Dim dv As New DataView
        Dim r As DataRow
        dv.Table = tb_Prod_n_pedido
        dv.RowFilter = "cod_produto = " & x_cod_prod & ""
        If dv.Count = 1 Then
            Dim i As Integer
            i = dv(0)("id") - 1
            r = tb_Prod_n_pedido.Rows(i)
            r("quant") = tb_Prod_n_pedido.Rows(i)("quant") + 1
            GoTo fim
        End If
        prod.filtra(x_cod_prod)
        r = tb_Prod_n_pedido.NewRow
        r("id") = tb_Prod_n_pedido.Rows.Count + 1
        r("cod_produto") = prod.fldCod_produto
        r("quant") = 1
        r("desconto") = prod.Desconto_compra
        r("preco") = prod.Preco_compra
        r("cod_tabela") = prod.Retorna_cod_Tabela(prod.fldCod_produto)
        r("produto") = prod.fldProduto
        r("cod_barra") = prod.fldCod_barra
        tb_Prod_n_pedido.Rows.Add(r)
fim:
        tb_Prod_n_pedido.WriteXml(Application.StartupPath & "\temp_data\" & pedido.cod_pedido & pedido.id_filial & ".xml")
    End Sub
    Private Sub andamentos_pedido()
        Dim i As Integer = 0
        Dim tb_os As New DataTable
        Dim os, id_fil As Integer
        Dim sql As String
        While pedido.lista_itens.Rows.Count > i
            sql = "Select * from pedido_fornecedor_os where " & _
            " cod_pedido = " & pedido.cod_pedido & " and " & _
            " item = " & pedido.lista_itens.Rows(i)("item") & ""
            d.carrega_Tabela(sql, tb_os)
            If tb_os.Rows.Count > 0 Then
                id_fil = rdNum(tb_os.Rows(0)("id_filial"))
                os = rdNum(tb_os.Rows(0)("cod_os"))
                If os <> Nothing Then
                    andamentos.insere_andamento(objAndamentos.tipo.Prod_solicitado_fornecedor, _
                    id_fil, os, UserID, "Lente " & pedido.lista_itens.Rows(i)("produto") & " solicitada ao fornecedor!")
                End If
            End If
            tb_os.Clear()
            i = i + 1
        End While
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If pedido.cod_status_pedido = status_pedido.Em_Aberto Then
            If pedido.retorna_status_item(item_atual)("cod_status") <> 3 Then
                AVISO(pedido.exclui_item(item_atual) & vbCrLf & "Exclusão de Item.", Me, frmAviso.tipo_aviso.tipo_ok)
                carrega_grid()
                Carrega_extras()
            End If
        End If
    End Sub
#Region "Nota"
    Private Sub Cria_nota_compra()
        Dim t, tb_os As New DataTable
        Dim i As Integer
        Dim dif As New DataView
        Dim sql As String
        Dim os, filial As Integer
        i = 0
        t = pedido.lista_atendidos
        dif.Table = t
        dif.RowFilter = " quant > atend and cod_status = 1"
        If dif.Count > 0 Then
            som_erro()
            AVISO("Há itens não atendidos no pedido!", Me, frmAviso.tipo_aviso.tipo_ok)
            trata_itens_nao_atendidos()
            Exit Sub
        End If
        inserenota()
        While i < t.Rows.Count
            If t.Rows(i)("cod_status") = 1 Then
                insere_item_nota(t.Rows(i)("cod_produto"), t.Rows(i)("atend"))
                sql = "Select * from pedido_fornecedor_os where " & _
            " cod_pedido = " & pedido.cod_pedido & " and " & _
            " item = " & t.Rows(i)("item") & ""
                d.carrega_Tabela(Sql, tb_os)
                If tb_os.Rows.Count > 0 Then
                    filial = rdNum(tb_os.Rows(0)("id_filial"))
                    os = rdNum(tb_os.Rows(0)("cod_os"))
                    If os <> Nothing Then
                        andamentos.insere_andamento(objAndamentos.tipo.prod_chegou_forn, _
                        filial, os, UserID, "Lente " & t.Rows(i)("produto") & " Chegou do fornecedor!")
                    End If
                End If
            End If
            i = i + 1
        End While
        i = 0
        Dim r As DataRow
        While i < tb_Prod_n_pedido.Rows.Count
            r = tb_Prod_n_pedido.Rows(i)
            insere_item_nota(r("cod_produto"), r("quant"))
            i = i + 1
        End While
        pedido.editar()
        pedido.cod_status_pedido = pedido.status_pedido.Nota_Lancada
        pedido.Salvar()
        cp.conclui_movimento()
        AVISO("Concluído!", Me, frmAviso.tipo_aviso.tipo_ok)
    End Sub
    Private Sub inserenota()
        cp.novo()
        cp.cod_fornecedor = pedido.cod_fornecedor
        cp.data = Now.Date
        cp.doc = pedido.nota_fiscal
        cp.Salvar()

    End Sub
    Private Sub insere_item_nota(ByVal _x_cod_prod As Integer, ByVal q As Double)
        Dim media_len, media_prod As Double
        Dim cod_len As Integer
        Dim p As New produtoClass
        p.filtra(_x_cod_prod)
        mov.novo()
        mov.item = mov.ret_ultimo_item(cp.cod_movimento)
        mov.cod_movimento = cp.cod_movimento
        mov.cod_produto = p.fldCod_produto
        mov.quant = q
        mov.desconto = p.Desconto_compra
        mov.pUnit = p.Preco_compra
        mov.estoqueFis = mov.ret_saldo_fisico(p.fldCod_produto) + CDbl(q)
        mov.estoqueFin = mov.estoqueFis * ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))))
        '( + mov.ret_saldo_fin(txtCodProd.Text)
        cod_len = mov.retorna_cod_lentebloco(p.fldCod_produto)

        media_len = media_movel(mov.ret_saldo_todos_fisico(cod_len), mov.ret_saldo_todos_fin(cod_len), q, (p.Preco_compra) - (p.Preco_compra * (p.Desconto_compra / 100)))
        media_prod = media_movel(mov.ret_saldo_fisico(p.fldCod_produto), mov.ret_saldo_fin(p.fldCod_produto), q, (p.Preco_compra) - (p.Preco_compra * (p.Desconto_compra / 100)))
        mov.atualiza_custo(cod_len, media_len, p.fldCod_produto, media_prod)
        mov.historico = "Compra conforme Doc. " & txtDoc.Text & ""
        mov.Salvar()
    End Sub
    Private Sub trata_itens_nao_atendidos()
        Dim x_tb As New DataTable
        Dim i As Integer
        i = 0
        x_tb = pedido.listar_nao_atendidos_auto
        While i < x_tb.Rows.Count
            trata_item_nao_atendido(x_tb.Rows(i)("item"))
            i = i + 1
        End While
    End Sub
    Private Sub trata_item_nao_atendido(ByVal x_item As Integer)
        Dim x_tb As New DataTable
        Dim r As frmAviso.respo
        Dim dv_pedido As New DataView
        Dim prod As String
        dv_pedido.Table = pedido.lista_itens
        dv_pedido.RowFilter = " item = " & x_item & ""
        prod = dv_pedido(0)("Produto")
        r = AVISO("O Produto " & prod & " não foi atendido! Caso deseje adicioná-lo a um novo pedido, " & _
        "clique em 'SIM' case deseje cancelá-lo, clique em 'NÃO'", Me, frmAviso.tipo_aviso.tipo_sim_nao)
        If r = frmAviso.respo.SIM Then
            novo_pedido(x_item)
        End If
        If r = frmAviso.respo.NAO Then
            cancela_item(x_item)
        End If
    End Sub
    Private Sub novo_pedido(ByVal x_item As Integer)
        Dim r As String
        r = pedido.status_item(x_item, objPedidoCompra.status_item_pedido.pedido_2)
        r = r & vbCrLf & pedido.Atualizar_status_item_auto(x_item, pedido.id_filial, pedido.cod_pedido _
        , objPedidoCompra.status_sugestao_pedido.pedido_2)
        AVISO(r, Me, frmAviso.tipo_aviso.tipo_ok)
        carrega_grid()
    End Sub
    Private Sub cancela_item(ByVal x_item As Integer)
        Dim r As String
        r = pedido.status_item(x_item, objPedidoCompra.status_item_pedido.cancelado)
        r = r & vbCrLf & pedido.Atualizar_status_item_auto(x_item, pedido.id_filial, _
        pedido.cod_pedido, objPedidoCompra.status_sugestao_pedido.cancelado)
        AVISO(r, Me, frmAviso.tipo_aviso.tipo_ok)
        carrega_grid()
    End Sub
#End Region
    Private Sub btnPrintRelacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRelacao.Click
        relat_pedido_x_os()
    End Sub

    
    Private Sub btnExcluiNumero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiNumero.Click
        Dim item As Integer
        item = InputBox("Digite item")
        Try
            If pedido.cod_status_pedido = status_pedido.Em_Aberto Then
                If pedido.retorna_status_item(item)("cod_status") <> 3 Then
                    AVISO(pedido.exclui_item(item) & vbCrLf & "Exclusão de Item.", Me, frmAviso.tipo_aviso.tipo_ok)
                    carrega_grid()
                    Carrega_extras()
                End If
            End If
        Catch ex As Exception
            MsgBox("produto não exixte!")
        End Try
  
    End Sub

    Private Sub btnCadBarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadBarra.Click
        Dim f As New frmCadBarraDiop
        f.ShowDialog(Me)
        f.Dispose()
    End Sub
End Class