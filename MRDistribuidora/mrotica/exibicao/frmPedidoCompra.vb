Imports mrotica_util
Imports System.Net.Mail
Public Class frmPedidoCompra
    Dim d As New dados
    Dim pedido As New objPedidoCompra
    Public acao As Integer
    Public tipo_pedido As Integer
    Dim prod As New produtoClass
    Dim tb_Prod_n_pedido As New DataTable
    Dim cp As New objcompras
    Dim mov As New objMovimentoDetalhe
    Dim item_atual As Integer
    Dim conf As New config
    Public n_pedido As Integer
    Private Sub frmPedidoCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Ao abrir o Form, avalia se um novo pedido será incluido ou se 
        'será feita a edição de um pedido existente.
        If acao = pedido_compra_acao.pedido_novo Then
            pedido.novo()
            pedido.cod_tipo = tipo_pedido_compra.Pedido_normal  'Identifica o pedido como um pedido 
            ativaCabecalho()
        End If
        If acao = pedido_compra_acao.pedido_edicao Then
            carrega_pedido()
            grpItens.Enabled = True
            desativaCabecalho()
        End If
        If acao = pedido_compra_acao.pedido_Entrada Then
            'Abre pedido para conferencia e entrada no estoque.
            carrega_pedido()
            If pedido.cod_status_pedido = pedido.status_pedido.pedido_chegou _
            Or pedido.cod_status_pedido = pedido.status_pedido.Pedido_em_aberto Or _
            pedido.cod_status_pedido = pedido.status_pedido.pedido_efetuado Then
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
        pedido.carrega_pedido(n_pedido, conf.Filial)
        If pedido.max > 0 Then
            travaControles(grpCabecalho.Controls)
            txtFornecedor.Text = nome_fornecedor(pedido.cod_fornecedor)
            dtPedido.Value = pedido.data_pedido
            txtDoc.Text = pedido.nota_fiscal
            lblNumPedido.Text = pedido.cod_pedido
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
                If txtFornecedor.ReadOnly = False Then
                    f.ShowDialog(Me)
                    pedido.cod_fornecedor = f.cod_fornecedor
                    txtFornecedor.Text = f.nome
                    f.Dispose()
                End If
        End Select
    End Sub
    Private Sub btnSalvarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarPedido.Click
        'Salva o cabeçalho do pedido de fornecedor, 
        If acao = pedido_compra_acao.pedido_novo Then
            pedido.cod_usuario = UserID
            pedido.cod_status_pedido = 1
            pedido.id_filial = conf.Filial
            pedido.data_pedido = dtPedido.Value
            MsgBox(pedido.Salvar)
            lblNumPedido.Text = pedido.cod_pedido
            acao = pedido_compra_acao.pedido_edicao
            grpItens.Enabled = True
            desativaCabecalho()
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
        i = 0
        item = pedido.lista_itens.Rows.Count + 1
        While i < x_tb.Rows.Count
            pedido.insere_item(pedido.cod_pedido, pedido.id_filial, x_tb.Rows(i)("cod_produto") _
            , x_tb.Rows(i)("quant"), x_tb.Rows(i)("preco_compra"), x_tb.Rows(i)("desconto"), 1, _
            x_tb.Rows(i)("doc_cliente"))
            item = item + 1
            i = i + 1
        End While
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
        Else
            grdItens.DataSource = pedido.lista_atendidos
            Dim TStb As New DataGridTableStyle
            TStb.MappingName = grdItens.DataSource.tablename

            Dim citem As New DataGridTextBoxColumn
            With citem
                .MappingName = "item"
                .HeaderText = "Item"
            End With
            TStb.GridColumnStyles.Add(citem)

            Dim cTab As New DataGridTextBoxColumn
            With cTab
                .MappingName = "cod_tabela"
                .HeaderText = "Tabela"
            End With
            TStb.GridColumnStyles.Add(cTab)

            Dim cProduto As New DataGridTextBoxColumn
            With cProduto
                .MappingName = "produto"
                .HeaderText = "Produto"
                .Width = 450
            End With
            TStb.GridColumnStyles.Add(cProduto)

            Dim cQ As New DataGridTextBoxColumn
            With cQ
                .MappingName = "quant"
                .HeaderText = "Pedido"

            End With
            TStb.GridColumnStyles.Add(cQ)

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
        Dim path As String
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
        "* (pedido_fornecedor_itens.desconto_compra / 100),lentes_tabela.nome_comercial " & _
        " order by lentes_tabela.nome_comercial"
        d.carrega_Tabela(sql, t)
        r.DataSource = t
        r.titulo = pedido.Razao_faturamento & vbCrLf & _
        "Pedido Nº " & pedido.cod_pedido & " " & txtFornecedor.Text & " em " & _
            pedido.data_pedido & ""
        f.Relat(r)
        f.ShowDialog(Me)
        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Pedido " & pedido.cod_pedido & ".pdf"
        Dim res As frmAviso.respo
        res = AVISO("Deseja Salvar PDF do pedido?", Me, frmAviso.tipo_aviso.tipo_sim_nao, False)
        If res = frmAviso.respo.SIM Then
            PdfExport.Export(r.Document, path)
        End If
        Dim resp As Integer
        If pedido.cod_status_pedido = objPedidoCompra.status_pedido.Pedido_em_aberto Then
            resp = AVISO("Deseja Efetuar o Pedido?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
            If resp = frmAviso.respo.SIM Then
                pedido.editar()
                pedido.cod_status_pedido = objPedidoCompra.status_pedido.pedido_efetuado
                pedido.Salvar()
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
        f.Relat(r)
        f.ShowDialog(Me)
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
            Dim f As New frmConsultaProduto
            Dim q As Integer
            f.ShowDialog(Me)
            Try
                q = InputBox("Digite a quantidade desejada:")
            Catch ex As Exception
                Exit Sub
            End Try
            'Insere os itens escolhidos no pedido
            Dim item As Integer
            prod.filtra(f.cod_prod)
            item = pedido.lista_itens.Rows.Count + 1
            pedido.insere_item(pedido.cod_pedido, pedido.id_filial, prod.fldCod_produto _
            , q, prod.Preco_compra, prod.Desconto_compra, 1, _
            d.PStr(Nothing))
            carrega_grid()
            item_atual = 1
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
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If pedido.cod_status_pedido = status_pedido.Em_Aberto Then
            Try
                If pedido.retorna_status_item(item_atual)("cod_status") <> 3 Then
                    AVISO(pedido.exclui_item(item_atual) & vbCrLf & "Exclusão de Item.", Me, frmAviso.tipo_aviso.tipo_ok)
                    carrega_grid()
                    Carrega_extras()
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub
#Region "Nota"
    Private Sub Cria_nota_compra()
        Dim t As New DataTable
        Dim tNat As New DataTable
        Dim i As Integer
        Dim dif As New DataView
        i = 0
        t = pedido.lista_atendidos
        tNat = pedido.listar_nao_atendidos_comum
        MsgBox(dif.Count)
        If tNat.Rows.Count > 0 Then
            som_erro()
            AVISO("Há itens não atendidos no pedido!", Me, frmAviso.tipo_aviso.tipo_ok)
            trata_itens_nao_atendidos()
            Exit Sub
        End If
        inserenota()
        While i < t.Rows.Count
            If t.Rows(i)("cod_status") = 1 Then
                insere_item_nota(t.Rows(i)("cod_produto"), t.Rows(i)("atend"))
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
        x_tb = pedido.listar_nao_atendidos_comum
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

    Private Sub grdItens_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grdItens.Navigate

    End Sub

    Private Sub btnItensDaOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItensDaOS.Click
        Dim f As New frmOSPedido
        f.ShowDialog(Me)
        If f.chkOd.Checked = True Then
            INSERE_ITEM(f.retPOD, f.cod_OS, f.Filial, "D")
        End If
        If f.chkOE.Checked = True Then
            INSERE_ITEM(f.retPOE, f.cod_OS, f.Filial, "E")
        End If
        f.Dispose()
    End Sub
    Private Sub INSERE_ITEM(ByVal X_COD_PROD As Long, ByVal xos As Integer, ByVal id_filial As Integer, ByVal olho As String)
        If pedido.cod_status_pedido = status_pedido.Em_Aberto Then
            Dim f As New frmConsultaProduto
            Dim q As Integer = 1
            Dim anda As New objAndamentos
            'Insere os itens escolhidos no pedido
            Dim item As Integer
            prod.filtra(X_COD_PROD)
            item = pedido.lista_itens.Rows.Count + 1
            pedido.insere_item(pedido.cod_pedido, pedido.id_filial, prod.fldCod_produto _
            , q, prod.Preco_compra, prod.Desconto_compra, 1, _
            d.PStr(Nothing))

            insere_pedidos_os(xos, id_filial, olho, X_COD_PROD)
            anda = New objAndamentos(xos, id_filial)
            anda.insere_andamento(objAndamentos.tipo.Prod_solicitado_fornecedor, id_filial, xos, UserID, "Solicitado produto do olho " & olho & " no pedido " & pedido.cod_pedido)
            carrega_grid()
            item_atual = 1
        End If

    End Sub
    Private Sub txtCodProd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodProd.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                busca_produto()
        End Select
    End Sub
    Private Sub busca_produto()
        Dim COD_PROD As Integer
        Dim l As New objLentesDiop
        Dim p As New produtoClass
        Dim fc As New frmConsultaProdDiopCod
        If txtCodProd.Text.Length > 10 Then
            txtCodProd.Text = ""
            txtCodProd.Focus()
            Exit Sub
        End If
        If txtCodProd.Text = "0" Then
            Exit Sub
        End If
        If txtCodProd.Text = "" Then
            MsgBox("Digite o código da Tabela!")
            txtCodProd.Focus()
            Exit Sub
        End If

        fc.txtCodTabela.Text = txtCodProd.Text
        fc.tipo = l.tipo(txtCodProd.Text)
        fc.ShowDialog(Me)
        COD_PROD = fc.Result

        'If txtCodProd.Text = "" Then GoTo consulta
Consulta_cod:
        p.Source("Select * from produtos where cod_produto = " & COD_PROD & "")
        If p.max = 1 Then
            txtCodProd.Text = COD_PROD
            txtCodProd.Text = ""
            GoTo saida
            Exit Sub
        Else
            Dim ret As String
            ret = p.Retorna_cod_prod(txtCodProd.Text)
            If ret <> "0" Then
                txtCodProd.Text = ret
                GoTo Consulta_cod
            Else
                GoTo consulta
            End If
        End If
saida:
        If pedido.cod_status_pedido = status_pedido.Em_Aberto Then
            Dim q As Integer
            Try
                q = InputBox("Digite a quantidade desejada:")
            Catch ex As Exception
                Exit Sub
            End Try
            'Insere os itens escolhidos no pedido
            Dim item As Integer
            prod.filtra(COD_PROD)
            item = pedido.lista_itens.Rows.Count + 1
            pedido.insere_item(pedido.cod_pedido, pedido.id_filial, prod.fldCod_produto _
            , q, prod.Preco_compra, prod.Desconto_compra, 1, _
            d.PStr(Nothing))
            carrega_grid()
            item_atual = 1
        End If
consulta:

        'Dim f As New frmConsultaProduto
        'f.ShowDialog(Me)
        'txtCodProd.Text = f.cod_prod
        'f.Dispose()
        'GoTo Consulta_cod
    End Sub
    Private Sub insere_pedidos_os(ByVal xcod_os As Integer, ByVal xid_filial As Integer, ByVal x_olho As String, ByVal xcodprod As Integer)
        'Cria a referencia do item do pedido para a OS na tabela auxiliar
        'pedido_fornecedor_os. Esta referência será usada quando o pedido 
        'for atendido, para encaminhar os produtos com rapidez para as 
        'devidas OS's.
        Dim sql As String

        sql = "INSERT INTO OS_pedido (cod_os,id_filial,cod_pedido,id_filial_pedido,Olho,cod_prod)" & _
        " VALUES(" & _
        xcod_os & _
        "," & xid_filial & _
        "," & pedido.cod_pedido & _
        "," & pedido.id_filial & _
        "," & d.PStr(x_olho) & _
        "," & xcodprod & ")"
        d.Comando(sql, True)
    End Sub

    Private Sub btnMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnXMLEssilor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXMLEssilor.Click
        Dim arquivo, nomeArq As String
        arquivo = pedido.itens_xml_essilor()
        nomeArq = My.Computer.FileSystem.SpecialDirectories.Desktop & _
        "\Pedido " & pedido.cod_pedido & _
        ".XML"
        IO.File.WriteAllText(nomeArq, arquivo)
        MsgBox("OK")
    End Sub

    Public Sub ativaCabecalho()
        txtFornecedor.Enabled = True
        dtPedido.Enabled = True
        txtDoc.Enabled = True
        btnSalvarPedido.Enabled = True
        btnImprimir.Enabled = False
        btnXMLEssilor.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Public Sub desativaCabecalho()
        txtFornecedor.Enabled = False
        dtPedido.Enabled = False
        txtDoc.Enabled = False
        btnSalvarPedido.Enabled = False
        btnImprimir.Enabled = True
        btnXMLEssilor.Enabled = True
        btnExcluir.Enabled = True
    End Sub

End Class