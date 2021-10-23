Imports mrotica_util
Public Class frmPedidoProducao
    Dim tb_pedido As New DataTable
    Dim tb_itens As New DataTable
    Dim tb_servico As New DataTable
    Dim tb_Serv As New DataTable
    Dim pedido As New objPedidoBalcao
    Dim cliente As New objCliente
    Dim tbUs As New DataTable
    Dim p As New produtoClass
    Dim d As New dados
    Dim usuario As New objUsuario
    Dim COD_PROD As Long
    Public _num_pedido, _id_filial As Integer
    Public origem As String
    Public os As Boolean = False
    Dim L As New objLentesDiop
    Dim conf As New config
    Dim user As New objUsuario
    Dim OD As itemProducao
    Dim OE As itemProducao
    Dim EntradaProducao As New objEntradaProducao
    Dim objMaster As New objMaster

    Private Sub frmPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_combos()
        If origem = "novo" Then
            Novo()
            Exit Sub
        End If
        If origem = "troca" Then
            troca()
        End If
        carrega_pedido(_num_pedido, _id_filial)
    End Sub
    Private Sub troca()
        travaControles(Me.grpCabecalho.Controls)
        travaControles(Me.grpProdutos.Controls)
        travaControles(Me.grpProdutos.Controls)
        btnSalvarPedido.Enabled = False
        btnSalvarItem.Enabled = False
    End Sub
    Public Sub Novo()
        'Procedimento 4: Novo Pedido
        If usuario.acesso(UserID, 4) = False Then
            AVISO("Usuário não tem permissão para criar um novo pedido de Balcão!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            Me.Close()
            Exit Sub
        End If
        grpCabecalho.Enabled = True
        grpProdutos.Enabled = False
        grpServicos.Enabled = False
        pedido.novo()
        pedido.id_filial = conf.Filial
        lblFilial.Text = pedido.id_filial
        EntradaProducao.novo()
    End Sub
    Public Sub carrega_combos()
        d.carrega_Tabela("Select * from usuarios order by nome", tbUs)
        cbVendedor.DataSource = tbUs
        cbVendedor.DisplayMember = "NOME"
        cbVendedor.ValueMember = "cod_usuario"

    End Sub
    Public Sub carrega_cliente(ByVal x_cod_cliente As Integer, ByVal x_cod_filial_cliente As Integer)
        cliente.Source("Select * from cliente where cod_filial_cliente = " & x_cod_filial_cliente & _
        " and cod_cliente = " & x_cod_cliente & "")
        cliente.primeiro()
        txtCliente.Text = cliente.nome_cliente
    End Sub
    Public Sub carrega_pedido(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        pedido.Source("Select * from pedido_balcao where num_pedido = " & x_num_pedido & _
        " and id_filial = " & x_id_filial)
        If pedido.max > 0 Then
            lblNpedido.Text = pedido.num_pedido
            lblFilial.Text = pedido.id_filial
            cbVendedor.SelectedValue = pedido.cod_vendedor
            dtData.Value = pedido.data_pedido
            Me.carrega_cliente(pedido.cod_cliente, pedido.cod_filial_cliente)
        End If
        EntradaProducao.carrega_producao(x_num_pedido, x_id_filial)
        carrega_itens(x_num_pedido, x_id_filial)
    End Sub
    Private Sub carrega_itens(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        tb_itens = pedido.lista_itens(x_num_pedido, x_id_filial, False)
        tb_servico = pedido.lista_servicos(x_num_pedido, x_id_filial)
        formata_grid_itens()
        formata_grid_OS()
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
        Dim cCod As New DataGridTextBoxColumn
        With cCod
            .MappingName = "cod_produto"
            .HeaderText = "Cod"
        End With
        TStb.GridColumnStyles.Add(cCod)
        grdProd.TableStyles.Clear()
        grdProd.TableStyles.Add(TStb)
    End Sub
    Private Sub formata_grid_OS()
        Dim TStb As New DataGridTableStyle
        grdOS.DataSource = pedido.lista_OSs
        TStb.MappingName = grdOS.DataSource.tablename
        Dim cFilial As New DataGridTextBoxColumn
        With cFilial
            .MappingName = "id_filial"
            .HeaderText = "filial"
            .Width = 50
        End With
        TStb.GridColumnStyles.Add(cFilial)

        Dim cOS As New DataGridTextBoxColumn
        With cOS
            .MappingName = "cod_os"
            .HeaderText = "OS"
            .Width = 100
        End With
        TStb.GridColumnStyles.Add(cOS)

       
        grdOS.TableStyles.Clear()
        grdOS.TableStyles.Add(TStb)
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Me.Cursor = Cursors.AppStarting
        'Dim r As New rptPedido
        Dim r As New rptPedidoBalcao2vias
        Dim f As New frmRpt
        Dim eco As String = ""
        If pedido.diferenca_desconto > 0 Then
            eco = "VOCÊ ECONOMIZOU " & cdinShow(pedido.diferenca_desconto) & " EM DESCONTOS!"
        End If
        r.r.filial = pedido.id_filial
        r.r2.filial = pedido.id_filial
        r.r.data = pedido.data_pedido
        r.r2.data = pedido.data_pedido
        r.r.tbItens = tb_itens
        r.r2.tbItens = tb_itens
        r.r.tbServ = tb_servico
        r.r2.tbServ = tb_servico
        r.r.cliente = txtCliente.Text
        r.r2.cliente = txtCliente.Text
        r.r.n_pedido = pedido.num_pedido
        r.r2.n_pedido = pedido.num_pedido
        r.r.Vendedor = cbVendedor.Text
        r.r2.Vendedor = cbVendedor.Text
        r.r.cod_cliente = pedido.cod_cliente
        r.r2.cod_cliente = pedido.cod_cliente
        r.r.Total = pedido.total_pedido
        r.r2.Total = pedido.total_pedido

        r.data = pedido.data_pedido
        r.cliente = txtCliente.Text
        r.n_pedido = pedido.num_pedido
        r.Vendedor = cbVendedor.Text
        r.cod_cliente = pedido.cod_cliente
        r.Total = pedido.total_pedido
        r.Serv = cdinShow(pedido.total_servicos)
        r.Prod = cdinShow(pedido.total_itens)
        f.Relat(r)
        Me.Cursor = Cursors.Default
        f.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.AppStarting
        Dim r As New rptPedidoProducao
        Dim f As New frmRpt
        Dim eco As String = ""
        If pedido.diferenca_desconto > 0 Then
            eco = "VOCÊ ECONOMIZOU " & cdinShow(pedido.diferenca_desconto) & " EM DESCONTOS!"
        End If
        r.filial = pedido.id_filial
        r.data = pedido.data_pedido
        r.cliente = txtCliente.Text
        r.n_pedido = pedido.num_pedido
        r.Vendedor = cbVendedor.Text
        r.tbItens = tb_itens
        r.tbServ = tb_servico
        r.cod_cliente = pedido.cod_cliente
        r.Total = pedido.total_pedido
        r.OSs = pedido.lista_OS_string
        f.Relat(r)
        Me.Cursor = Cursors.Default
        f.Show()
    End Sub

    Private Sub btnSalvarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarPedido.Click
        Dim res As String
        pedido.data_pedido = dtData.Value
        pedido.cod_vendedor = cbVendedor.SelectedValue
        pedido.cod_tipo_pedido = 2
        pedido.autorizacao = 1
        'If cliente.cod_tipo_cliente <> 4 Then
        'AVISO("Produção só pode ser solicitada para filiais!", Me, frmAviso.tipo_aviso.tipo_ok, True)
        'origem = ""
        'Exit Sub
        'End If
        If origem = "novo" Then
            origem = "editar"
            lblNpedido.Text = pedido.num_pedido
            grpProdutos.Enabled = True
            grpServicos.Enabled = True
            res = pedido.Salvar()
            If res.StartsWith("OK") Then
                EntradaProducao.id_filial_Pedido = pedido.id_filial
                EntradaProducao.num_pedido = pedido.num_pedido
                EntradaProducao.data = Now
                EntradaProducao.doc = "Pedido " & adiciona_zeros(pedido.id_filial, 3) & "-" & pedido.num_pedido
                EntradaProducao.id_usuario = user.cod_usuario
                MsgBox(EntradaProducao.Salvar())

                lblNpedido.Text = pedido.num_pedido
                GoTo final
            End If
        End If
        If origem = "editar" Then
            'Proedimento 5: Editar Pedido
            If usuario.acesso(UserID, 5) = False Then
                AVISO("Usuario não tem permissão para editar esse pedido!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                Exit Sub
            End If
            pedido.editar()
            pedido.Criterio_id_filial = pedido.id_filial
            pedido.Criterio_num_pedido = pedido.num_pedido
            pedido.Salvar()
        End If
final:
    End Sub

    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim f As New frmConsultaCliente
                f.txtNome.Text = txtCliente.Text
                f.ShowDialog(Me)

                carrega_cliente(f.cod_cliente, f.cod_filial)
                'If cliente.cod_tipo_cliente <> 4 Then
                'AVISO("Pedidos de produção devem ser feitos para filiais", Me, frmAviso.tipo_aviso.tipo_ok, True)
                'Exit Sub
                'End If
                pedido.cod_cliente = f.cod_cliente
                pedido.cod_filial_cliente = f.cod_filial
                txtCliente.Text = f.nome
        End Select
    End Sub
    Private Sub txtAdicaoOD_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAdicaoOD.Validating
        OD = Nothing
        OD = New itemProducao(txtCodTabelaOD.Text, txtAdicaoOD.Text, txtBaseOD.Text, txtEsfOD.Text, txtCilOD.Text, "D")

        If OD.existe = False Then
            OD = Nothing
            OD = New itemProducao(txtCodTabelaOD.Text, txtAdicaoOD.Text, txtBaseOD.Text, txtEsfOD.Text, txtCilOD.Text, "A")
        End If

        If OD.existe = True Then
            lblProdOD.Text = OD.nome_destino
            txtBaseOD.Text = OD.base
        Else
            AVISO("Esta combinação de dioptria, base, adição e olho não existe, escolha uma válida!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            txtBaseOD.Focus()
        End If
    End Sub


    Private Sub btnSalvarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarItem.Click
        'Procedimento 6: Inserir Item Pedido
        ' If usuario.acesso(UserID, 6) = False Then
        'AVISO("Usuário não tem permissão para inserir produtos no pedido!", Me, frmAviso.tipo_aviso.tipo_ok, True)
        'Exit Sub
        'End If

        If existe_item(OD.cod_produto_destino) = True Then
            MsgBox("Este produto já existe no pedido!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If pedido.cod_status_pedido <> status_pedido.Em_Aberto Then
            With pedido
                If .cod_status_pedido = status_pedido.cancelado Then
                    AVISO("Este pedido foi cancelado e não pode ser editado!", Me, frmAviso.tipo_aviso.tipo_ok)
                    Exit Sub
                End If
                If .cod_status_pedido = status_pedido.Processado_no_estoque Then
                    AVISO("Este pedido já foi processado no estoque e não pode ser alterado!", Me, frmAviso.tipo_aviso.tipo_ok)
                    Exit Sub
                End If
                If .cod_status_pedido = status_pedido.Faturado Then
                    AVISO("Este pedido já foi faturado e não pode ser alterado!", Me, frmAviso.tipo_aviso.tipo_ok)
                    Exit Sub
                End If
            End With
        End If

        If Cria_OS(OD, OE) = True Then
            inserir_produtos(pedido, pedido.num_pedido, pedido.id_filial, OD.cod_produto_destino, txtQuantidade.Text)
            inserir_produtos(pedido, pedido.num_pedido, pedido.id_filial, OE.cod_produto_destino, txtQuantidade.Text)
        Else
            inserir_produtos(pedido, pedido.num_pedido, pedido.id_filial, OD.cod_produto_destino, txtQuantidade.Text)
        End If

        LimpaControles(grpProdutos.Controls)
        lblProdOD.Text = ""
        lblProdOE.Text = ""
        txtQuantidade.Text = 1

    End Sub
    Private Function Cria_OS(ByVal XOD As itemProducao, ByVal XOE As itemProducao) As Boolean
        Dim i As Integer = 0
        Dim q As Integer = txtQuantidade.Text
        Dim OS As New ObjOS
        Dim andamentos As objAndamentos
        Dim res As String = ""
        While i < q
            OS.novo()
            OS.id_filial = conf.Filial
            OS.num_pedido = pedido.num_pedido
            OS.cod_tab_od = OD.cod_tabela_origem
            OS.cod_tab_oe = OE.cod_tabela_origem
            OS.cod_produto_od = OD.cod_produto_origem
            OS.cod_produto_oe = OE.cod_produto_origem

            OS.esf_od_longe = OD.esf
            OS.cil_od_longe = OD.cil
            OS.esf_od_perto = OD.esf + OD.adicao
            OS.cil_od_perto = OD.cil
            OS.dnp_od_longe = 0
            OS.dnp_od_perto = 0
            OS.base_od = OD.base
            OS.adicao_od = OD.adicao
            OS.altura_od = 0
            OS.diametro_od = 70
            OS.eixo_od = 0

            OS.esf_oe_longe = OE.esf
            OS.cil_oe_longe = OE.cil
            OS.esf_oe_perto = OE.esf + OE.adicao
            OS.cil_oe_perto = OE.cil
            OS.dnp_oe_longe = 0
            OS.dnp_oe_perto = 0
            OS.base_oe = OE.base
            OS.adicao_oe = OE.adicao
            OS.altura_oe = 0
            OS.diametro_oe = 70
            OS.eixo_oe = 0

            OS.aro_horizontal = 0
            OS.aro_vertical = 0
            OS.maior_diametro = 0
            OS.ponte = 0
            OS.cod_tipo_armacao = 1
            OS.crm_oftalmologista = 0

            OS.cod_filial_cliente = pedido.cod_filial_cliente
            OS.cod_cliente = pedido.cod_cliente
            OS.doc_cliente = 0
            OS.data_venda = pedido.data_pedido
            OS.data_previsao_entrega = rdData("")
            OS.hora_previsao_entrega = rdData("")
            OS.cod_vendedora = pedido.cod_vendedor
            OS.observacao = "OS para produção de Bloco Surfaçado"
            OS.nota_serie = ""
            OS.cod_verif_por = 2
            OS.data_verificacao = rdData(Now)
            OS.cod_surfacagem = 16077
            OS.cod_montagem = 36908
            OS.confeccao = "N"
            OS.coloracao = rdNum(0)
            OS.cor_coloracao = ""
            OS.cod_fase = Fases_os.Verificacao
            OS.tipo_receita_OD = tipo_Receita.PROGRESSIVA
            OS.tipo_receita_OE = tipo_Receita.PROGRESSIVA
            OS.id_laboratorio = 1 'Laboratorio Montagem
            OS.cod_lab_surf = 1
            OS.cod_tipo_os = 2
            res = OS.Salvar
            If res.StartsWith("OK") Then
                i = i + 1
                andamentos = New objAndamentos(OS.cod_os, OS.id_filial, d)
                'Caso a os tenha sido inserida, coloca andamentos de inclusao e verificacao
                andamentos.insere_andamento(objAndamentos.tipo.inclusao_os, OS.id_filial, OS.cod_os, _
                2, "Os de produção")
                andamentos.insere_andamento(objAndamentos.tipo.verificacao_os, OS.id_filial, _
                OS.cod_os, 2, "Os de produção")
            Else
                MsgBox(res)
                Return False
                Exit Function
            End If
        End While
        Return True
    End Function
    Private Sub inserir_produtos(ByVal xPedido As objPedidoBalcao, ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer, ByVal x_cod_prod As Integer, ByVal q As Integer)
        Dim p As New produtoClass
        Dim m As Integer
        Dim status_item As Integer = 1

        p.Source("Select * from produtos where cod_produto = " & x_cod_prod & "")
        m = txtQuantidade.Text
        status_item = status_item_pedido.aguardando_pedido
        Dim res As String
        res = xPedido.insere_item(x_num_pedido, x_id_filial, p.fldCod_produto, q, 0, p.Preco_venda, status_item)
        If res.StartsWith("ER") Then
            MsgBox(res.Substring(3), MsgBoxStyle.Critical)
        End If
        carrega_itens(pedido.num_pedido, pedido.id_filial)
fim:
    End Sub
    Private Function existe_item(ByVal cod_prod As Integer) As Boolean
        Dim dv As New DataView
        Try
            dv.Table = tb_itens
            dv.RowFilter = "cod_produto = " & cod_prod & " AND ((cod_status_item <> 4) or (cod_status_item <> 5))"
            If dv.Count >= 1 Then Return True
            If dv.Count < 1 Then Return False
        Catch ex As Exception
            Return False
        End Try
    End Function
    

    Private Sub btnPrintEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintEstoque.Click
        Dim rpt As New rptListaEstoqueForncecedor
        Dim rp As New frmRpt
        Dim os As New ObjOS
        Try
            rpt.DataSource = EntradaProducao.listagem_estoque
            rp.Relat(rpt)
            rp.ShowDialog(Me)
        Catch ex As Exception
            AVISO(ex.Message, Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End Try
        Exit Sub
    End Sub
    Private Sub mniAtualizaPreco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniAtualizaPreco.Click
        Dim item As Integer
        Dim i As Integer = 0
        Dim res As String
        Dim desc As Double = 0.0
        Dim prod As New produtoClass
        Dim user As New objUsuario
        If user.login(Me).StartsWith("OK") Then
            'Procedimento 29 atualiza o preço do item de acordo com 
            'o valor cadastrado na tabela
            If user.acesso(29) = False Then
                AVISO("Usuário não tem permissão para atualizar preço!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                Exit Sub
            End If
            While i < grdProd.DataSource.rows.count
                If grdProd.IsSelected(i) Then
                    item = grdProd.Item(i, 0)
                    desc = grdProd.Item(i, 3)
                    prod.filtra(pedido.retorna_cod_item(item))
                    res = res & vbCrLf & pedido.altera_preco_item(item, prod.Preco_venda, desc)
                End If
                i = i + 1
            End While
            carrega_itens(pedido.num_pedido, pedido.id_filial)
            formata_grid_itens()
            MsgBox("Concluido!")
        End If
    End Sub

  
    Private Sub txtAdicaoOE_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtAdicaoOE.Validating
        OE = Nothing
        OE = New itemProducao(txtCodTabOE.Text, txtAdicaoOE.Text, txtBaseOE.Text, txtEsfOE.Text, txtCilOE.Text, "E")

        If OE.existe = False Then
            OE = Nothing
            OE = New itemProducao(txtCodTabelaOD.Text, txtAdicaoOD.Text, txtBaseOD.Text, txtEsfOD.Text, txtCilOD.Text, "A")
        End If

        If OE.existe = True Then
            lblProdOE.Text = OE.nome_destino
            txtBaseOE.Text = OE.base
        Else
            AVISO("Esta combinação de dioptria, base, adição e olho não existe, escolha uma válida!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            txtBaseOE.Focus()
        End If
    End Sub

    Private Sub ExcluirOSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExcluirOSToolStripMenuItem.Click
        If MessageBox.Show("Deseja cancelar a OS selecionada?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim strAndamento As String = "WHERE COD_OS = " & grdOS.Item(grdOS.CurrentRowIndex, 1) & " AND ID_FILIAL = " & conf.Filial
                objMaster.excluir_registros("ANDAMENTOS", strAndamento, True)

                Dim strOS As String = "WHERE COD_OS = " & grdOS.Item(grdOS.CurrentRowIndex, 1) & " AND ID_FILIAL = " & conf.Filial
                objMaster.excluir_registros("OS", strOS, True)

                Dim strPedido As String = "QUANT = (QUANT - 1) WHERE NUM_PEDIDO = " & CInt(lblNpedido.Text) & " AND ID_FILIAL = " & conf.Filial
                objMaster.atualiza_registros("PEDIDO_BALCAO_ITENS", strPedido, True)
                carrega_pedido(CInt(lblNpedido.Text), conf.Filial)
                formata_grid_itens()
                formata_grid_OS()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
