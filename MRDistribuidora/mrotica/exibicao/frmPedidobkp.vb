Imports System.Data
Imports System.Data.SqlClient
Imports winotica_util
Public Class frmPedidobkp
    Dim tb_pedido As New DataTable
    Dim tb_itens As New DataTable
    Dim tb_servico As New DataTable
    Dim tb_Serv As New DataTable
    Dim ttForma As New DataTable
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
    Public intContador As Integer
    Dim L As New objLentesDiop
    Dim conf As New config
    Dim user As New objUsuario
    Dim acesso As New objMaster
    Dim intUsuario As Integer
    Dim intItem As Int16
    Dim descavista As Double = 0
    Dim resultado As Integer = 0
    Dim valorpedido As Double = 0.0
    Dim dn As New dados(conf.usuarioSql, conf.SenhaSql, conf.servidorSQL, conf.dbBazar)

    Private Sub frmPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_combos()

        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(frmMain.strUsuario)
        Dim intAcesso As Integer = acesso.verifica_permissao_menu(intUsuario)

        If origem = "novo" Then
            Novo()
            Exit Sub
        End If
        If origem = "troca" Then
            troca()
        End If
        carrega_pedido(_num_pedido, _id_filial)

        If (intContador = 1) Or (intContador = 2) Or (intContador = 3) Then
            cbForma.SelectedIndex = 1
            cbForma.Enabled = False
        Else
            cbForma.SelectedValue = retornaFormaPagPed()
        End If

        Dim strSQLOSPed As String = "select cod_os from os where num_pedido = " & CInt(lblNpedido.Text) & " and id_filial = " & CInt(lblFilial.Text)

        If acesso.verifica_existencia_registro(strSQLOSPed) = True Then
            txtVendedorExterno.Enabled = False
            chkLente.Enabled = False
            txtQuant.Enabled = False
            txtCodProd.Enabled = False
            btnExcluirProd.Enabled = False
            cbServicos.Enabled = False
            txtQuantServ.Enabled = False
            btnSalvarPedido.Enabled = False
            btnExcluirServico.Enabled = False

            If comparaAutorizacao() = True Then
                MessageBox.Show("Valor autorizado é menor que o valor total do pedido." & Chr(13) & "Por favor fale com seu gerente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim strSQLAtuPed As String = "cod_status_pedido = 4 where num_pedido = " & pedido.num_pedido & " and cod_cliente = " & pedido.cod_cliente & _
                    " and id_filial = " & conf.Loja
                acesso.atualiza_registros("Pedido_balcao", strSQLAtuPed)

                Dim strSQLAtuItem As String = "cod_status_item = 4 where num_pedido = " & pedido.num_pedido & " And id_filial = " & conf.Loja
                acesso.atualiza_registros("Pedido_balcao_itens", strSQLAtuItem)

                Exit Sub
            End If
        End If
    End Sub

    Private Sub troca()
        travaControles(Me.grpCabecalho.Controls)
        travaControles(Me.grpProdutos.Controls)
        travaControles(Me.grpProdutos.Controls)
        btnSalvarItem.Enabled = False
        btnExcluirProd.Enabled = False
        btnExcluirServico.Enabled = False
        btnIncluirTodoEstoque.Enabled = False
        btnSalvarServico.Enabled = False
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
        pedido.id_filial = conf.Loja
        lblFilial.Text = pedido.id_filial
        Dim intCodUsuario As Integer = acesso.retorna_codigo_usuario(frmMain.strUsuario)
        lblVendedor.Text = acesso.retornaUsuario(intCodUsuario)
    End Sub
    Public Sub carrega_combos()
        Dim sqlc As String

        sqlc = "SELECT produtos.cod_produto, " & _
        "(produtos.produto + ' R$ ' +  cast(produtos.preco_venda as varchar(12)) + " & _
        "',00') AS produto FROM produtos INNER JOIN  " & _
        "servicos ON produtos.cod_produto = servicos.cod_produto  " & _
        "WHERE servicos.cod_tipo_servico = 1 or " & _
        "servicos.cod_tipo_servico = 2 or " & _
        "servicos.cod_tipo_servico = 3 or " & _
        "servicos.cod_tipo_servico = 4 " & _
        "order by servicos.cod_tipo_servico "
        d.carrega_Tabela(sqlc, tb_Serv)
        cbServicos.DataSource = tb_Serv
        cbServicos.DisplayMember = "produto"
        cbServicos.ValueMember = "cod_produto"

        strSQL = "select * from tipo_compra"
        d.carrega_Tabela(strSQL, ttForma)
        cbForma.DisplayMember = "descricao"
        cbForma.ValueMember = "codigo"
        cbForma.DataSource = ttForma
    End Sub
    Public Sub cerrega_cliente(ByVal x_cod_cliente As Integer, ByVal x_cod_filial_cliente As Integer)
        cliente.Source("Select * from cliente where cod_filial_cliente = " & x_cod_filial_cliente & _
        " and cod_cliente = " & x_cod_cliente & "")
        cliente.primeiro()
        lblCliente.Text = cliente.nome_cliente
    End Sub
    Public Sub carrega_pedido(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        pedido.Source("Select * from pedido_balcao where num_pedido = " & x_num_pedido & _
        " and id_filial = " & x_id_filial)
        If pedido.max > 0 Then
            lblNpedido.Text = pedido.num_pedido
            lblFilial.Text = pedido.id_filial
            lblVendedor.Text = acesso.retornaUsuario(pedido.cod_vendedor)
            lblData.Text = Format(pedido.data_pedido, "Short Date")
            txtVendedorExterno.Text = pedido.cod_vendedor_externo
            txtTotalPago.Text = Format(pedido.valor_pago, "#,##0.00")
            Me.cerrega_cliente(pedido.cod_cliente, pedido.cod_filial_cliente)
        End If
        carrega_itens(x_num_pedido, x_id_filial)
    End Sub
    Private Sub carrega_itens(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        tb_itens = pedido.lista_itens(x_num_pedido, x_id_filial, False)
        tb_servico = pedido.lista_servicos(x_num_pedido, x_id_filial)
        formata_grid_itens()
        formata_grid_Servicos()
        saldo(x_num_pedido, x_id_filial)
    End Sub
    Private Sub saldo(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        lblTotProd.Text = Format(pedido.total_itens(x_num_pedido, x_id_filial), "#,##0.00")
        lblTotServ.Text = Format(pedido.total_servicos(x_num_pedido, x_id_filial), "#,##0.00")
        lblTotal.Text = Format(CDbl(lblTotProd.Text) + CDbl(lblTotServ.Text), "#,##0.00")
    End Sub
    Private Sub formata_grid_itens()
        grdProd.Columns.Clear()
        grdProd.DataSource = Nothing
        grdProd.AllowUserToAddRows = False
        grdProd.AutoGenerateColumns = False

        Dim cItem As New DataGridViewTextBoxColumn 'Posição 00
        With cItem
            .DataPropertyName = "item"
            .HeaderText = " "
            .Width = 20
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdProd.Columns.Add(cItem)

        Dim cProd As New DataGridViewTextBoxColumn 'Posição 01
        With cProd
            .DataPropertyName = "Produto"
            .HeaderText = "Produto"
            .Width = 320
        End With
        grdProd.Columns.Add(cProd)

        Dim cQuant As New DataGridViewTextBoxColumn 'Posição 02
        With cQuant
            .DataPropertyName = "quant"
            .HeaderText = "Qtde"
            .Width = 40
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdProd.Columns.Add(cQuant)

        Dim cDesc As New DataGridViewTextBoxColumn 'Posição 03
        With cDesc
            .DataPropertyName = "desconto"
            .HeaderText = "Desc."
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 50
        End With
        grdProd.Columns.Add(cDesc)

        Dim cPreco As New DataGridViewTextBoxColumn 'Posição 04
        With cPreco
            .DataPropertyName = "preco"
            .HeaderText = "P. Unit."
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 70
        End With
        grdProd.Columns.Add(cPreco)

        Dim cTotal As New DataGridViewTextBoxColumn 'Posição 05
        With cTotal
            .DataPropertyName = "Total"
            .HeaderText = "Total."
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 70
        End With
        grdProd.Columns.Add(cTotal)

        Dim cDescCaixa As New DataGridViewTextBoxColumn 'Posição 06
        With cDescCaixa
            .DataPropertyName = "desc_caixa"
            .HeaderText = "Desc. Caixa"
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 90
        End With
        grdProd.Columns.Add(cDescCaixa)

        Dim cPago As New DataGridViewTextBoxColumn 'Posição 07
        With cPago
            .DataPropertyName = "pago"
            .HeaderText = "Pago"
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 70
        End With
        grdProd.Columns.Add(cPago)

        Dim cStatus_item As New DataGridViewTextBoxColumn ' Posição 08
        With cStatus_item
            .DataPropertyName = "status_item"
            .HeaderText = "Status"
            .Width = 120
        End With
        grdProd.Columns.Add(cStatus_item)

        Dim cPacote As New DataGridViewTextBoxColumn 'Posição 09
        With cPacote
            .DataPropertyName = "cod_pacote"
            .HeaderText = "Pct."
        End With
        grdProd.Columns.Add(cPacote)

        Dim cCod As New DataGridViewTextBoxColumn 'Posição 10
        With cCod
            .DataPropertyName = "cod_produto"
            .HeaderText = "Código"
        End With
        grdProd.Columns.Add(cCod)

        grdProd.DataSource = tb_itens

        If tb_itens.Rows.Count > 0 Then
            btnExcluirProd.Enabled = True
            If (pedido.cod_status_pedido = 2) Or (pedido.cod_status_pedido = 3) Or (pedido.cod_status_pedido = 4) Then
                txtVendedorExterno.Enabled = False
                cbForma.Enabled = False
                chkLente.Enabled = False
                txtQuant.Enabled = False
                txtCodProd.Enabled = False
                btnExcluirProd.Enabled = False
                cbServicos.Enabled = False
                txtQuantServ.Enabled = False
                btnSalvarPedido.Enabled = False
                btnExcluirServico.Enabled = False
            End If
        Else
            btnExcluirProd.Enabled = False
        End If
    End Sub

    Private Sub formata_grid_Servicos()
        grdServico.Columns.Clear()
        grdServico.DataSource = Nothing
        grdServico.AutoGenerateColumns = False
        grdServico.AllowUserToAddRows = False

        Dim cItem As New DataGridViewTextBoxColumn 'Posição 00
        With cItem
            .DataPropertyName = "item_servico"
            .HeaderText = " "
            .Width = 20
        End With
        grdServico.Columns.Add(cItem)

        Dim cProd As New DataGridViewTextBoxColumn 'Posição 01
        With cProd
            .DataPropertyName = "Produto"
            .HeaderText = "Produto"
            .Width = 250
        End With
        grdServico.Columns.Add(cProd)

        Dim cQuant As New DataGridViewTextBoxColumn ' Posição 02
        With cQuant
            .DataPropertyName = "quant"
            .HeaderText = "Q."
            .Width = 20
        End With
        grdServico.Columns.Add(cQuant)

        Dim cAtend As New DataGridViewTextBoxColumn ' Posição 03
        With cAtend
            .DataPropertyName = "Atendido"
            .HeaderText = "At;"
            .Width = 20
        End With
        grdProd.Columns.Add(cAtend)

        Dim cDesc As New DataGridViewTextBoxColumn ' Posição 04
        With cDesc
            .DataPropertyName = "desconto"
            .HeaderText = "Desc."
            .DefaultCellStyle.Format = "#,##0.00"
            .Width = 33
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdServico.Columns.Add(cDesc)

        Dim cPreco As New DataGridViewTextBoxColumn 'Posição 05
        With cPreco
            .DataPropertyName = "preco"
            .HeaderText = "P. Unit."
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdServico.Columns.Add(cPreco)

        Dim cTotal As New DataGridViewTextBoxColumn 'Posição 06
        With cTotal
            .DataPropertyName = "Total"
            .HeaderText = "Total."
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DefaultCellStyle.Format = "#,##0.00"
        End With
        grdServico.Columns.Add(cTotal)

        Dim cDescCaixa As New DataGridViewTextBoxColumn ' Posição 07
        With cDescCaixa
            .DataPropertyName = "desc_caixa"
            .HeaderText = "Desc. Caixa"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DefaultCellStyle.Format = "#,##0.00"
        End With
        grdServico.Columns.Add(cDescCaixa)

        Dim cPago As New DataGridViewTextBoxColumn ' Posição 08
        With cPago
            .DataPropertyName = "pago"
            .HeaderText = "Pago"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DefaultCellStyle.Format = "#,##0.00"
        End With
        grdServico.Columns.Add(cPago)

        Dim cPacote As New DataGridViewTextBoxColumn
        With cPacote
            .DataPropertyName = "cod_pacote"
            .HeaderText = "Pct."
        End With
        grdServico.Columns.Add(cPacote)

        grdServico.DataSource = tb_servico

        If grdServico.Rows.Count > 0 Then
            If (pedido.cod_status_pedido = 2) Or (pedido.cod_status_pedido = 3) Or (pedido.cod_status_pedido = 4) Then
                txtVendedorExterno.Enabled = False
                cbForma.Enabled = False
                chkLente.Enabled = False
                txtQuant.Enabled = False
                txtCodProd.Enabled = False
                btnExcluirProd.Enabled = False
                cbServicos.Enabled = False
                txtQuantServ.Enabled = False
                btnSalvarPedido.Enabled = False
                btnExcluirServico.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Me.Cursor = Cursors.AppStarting
        'Dim r As New rptPedido
        Dim r As New rptPedidoBalcao2vias
        Dim f As New frmRpt
        Dim eco As String = ""
        If pedido.diferenca_desconto > 0 Then
            eco = "VOCÊ ECONOMIZOU " & pedido.diferenca_desconto & " EM DESCONTOS!"
        End If
        r.r.filial = pedido.id_filial
        r.r2.filial = pedido.id_filial
        r.r.economia = eco
        r.r2.economia = eco
        r.r.data = pedido.data_pedido
        r.r2.data = pedido.data_pedido
        r.r.tbItens = tb_itens
        r.r2.tbItens = tb_itens
        r.r.tbServ = tb_servico
        r.r2.tbServ = tb_servico
        r.r.cliente = lblCliente.Text
        r.r2.cliente = lblCliente.Text
        r.r.n_pedido = pedido.num_pedido
        r.r2.n_pedido = pedido.num_pedido
        r.r.Vendedor = lblVendedor.Text
        r.r2.Vendedor = lblVendedor.Text
        r.r.cod_cliente = pedido.cod_cliente
        r.r2.cod_cliente = pedido.cod_cliente
        r.r.Total = lblTotal.Text
        r.r2.Total = lblTotal.Text

        r.data = pedido.data_pedido
        r.cliente = lblCliente.Text
        r.n_pedido = pedido.num_pedido
        r.Vendedor = lblVendedor.Text
        r.cod_cliente = pedido.cod_cliente
        r.Total = lblTotal.Text
        r.Serv = Format(pedido.total_servicos, "#,##0.00")
        r.Prod = Format(pedido.total_itens, "#,##0.00")
        f.Relat(r)
        Me.Cursor = Cursors.Default
        f.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.AppStarting
        Dim r As New rptPedido
        Dim f As New frmRpt
        Dim eco As String = ""
        If pedido.diferenca_desconto > 0 Then
            eco = "VOCÊ ECONOMIZOU " & pedido.diferenca_desconto & " EM DESCONTOS!"
        End If
        r.filial = pedido.id_filial
        r.data = pedido.data_pedido
        r.cliente = lblCliente.Text
        r.n_pedido = pedido.num_pedido
        r.Vendedor = lblVendedor.Text
        r.tbItens = tb_itens
        r.tbServ = tb_servico
        r.cod_cliente = pedido.cod_cliente
        r.Total = lblTotal.Text
        f.Relat(r)
        Me.Cursor = Cursors.Default
        f.Show()
    End Sub
    Private Sub btnSalvarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarPedido.Click
        pedido.data_pedido = Now()
        'pedido.cod_vendedor = cbVendedor.SelectedValue
        pedido.cod_tipo_pedido = 1
        intUsuario = acesso.retorna_codigo_usuario(frmMain.strUsuario)
        If origem = "novo" Then
            origem = "editar"
            lblNpedido.Text = pedido.num_pedido
            grpProdutos.Enabled = True
            grpServicos.Enabled = True
            txtQuant.Focus()
            GoTo final
        End If
        If origem = "editar" Then
            'Proedimento 5: Editar Pedido
            If acesso.verifica_permissao_usuario(intUsuario, 5) = False Then
                MessageBox.Show("Usuario não tem permissão para editar esse pedido", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            pedido.editar()
            pedido.Criterio_id_filial = pedido.id_filial
            pedido.Criterio_num_pedido = pedido.num_pedido
        End If
final:
        MsgBox(pedido.Salvar())
    End Sub

    Private Sub busca_produto(ByVal TFcod_prod As Boolean)
        Dim fc As New frmConsultaProdDiopCod
        If chkLente.Checked = False Then
            Dim tt As New DataTable
            tt = p.Consultar_produtos_barra(txtCodProd.Text)
            If tt.Rows.Count = 1 Then
                COD_PROD = tt.Rows(0)("cod_produto")
                GoTo Consulta_cod
            End If
        End If
        If txtCodProd.Text = "0" Then
            lblProduto.Text = ""
            Exit Sub
        End If
        If txtCodProd.Text = "" Then
            MsgBox("Digite o código da Tabela!")
            txtCodProd.Focus()
            Exit Sub
        End If
        If TFcod_prod = False Then
            fc.txtCodTabela.Text = txtCodProd.Text
            fc.tipo = L.tipo(txtCodProd.Text)
            fc.ShowDialog(Me)
            COD_PROD = fc.Result
        Else
            COD_PROD = txtCodProd.Text
        End If
        'If txtCodProd.Text = "" Then GoTo consulta
Consulta_cod:
        p.Source("Select * from produtos where cod_produto = " & COD_PROD & "")
        If p.max = 1 Then
            txtCodProd.Text = COD_PROD
            lblProduto.Text = p.fldProduto
            lblPrecoTabela.Text = Format(p.Preco_venda, "#,##0.00")
            lblDescontoTabela.Text = Format(descavista, "##0.00")


            'Verifica seo cliente não tem débito em aberto e a forma de pagamento é igual a 1
            If p.desconto(pedido.cod_cliente, pedido.cod_filial_cliente) > 0 Then
                'Retorna o valor da tabela promocional
                lblPrecoTabela.Text = Format(CDbl(lblPrecoTabela.Text) - (CDbl(lblPrecoTabela.Text) * p.desconto(pedido.cod_cliente, pedido.cod_filial_cliente) / 100), "#,##0.00")
                lblDescontoTabela.Text = Format(descavista, "##0.00")
            Else
                If CDbl(lblDescontoTabela.Text) > 0 Then
                    lblDescontoTabela.Text = Format(descavista, "##0.00")
                Else
                    descavista = Format(p.desconto(pedido.cod_cliente, pedido.cod_filial_cliente), "#,##0.00")
                    lblDescontoTabela.Text = Format(descavista, "##0.00")
                End If
            End If


            If cliente.cod_tipo_cliente = 2 Then
                lblPrecoTabela.Text = ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) + _
                               (p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) * 0.15)
                lblDescontoTabela.Text = descavista
            End If
            btnSalvarItem.Enabled = True
            btnSalvarItem.Focus()
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

consulta:
        'Dim f As New frmConsultaProduto
        'f.ShowDialog(Me)
        'txtCodProd.Text = f.cod_prod
        'f.Dispose()
        'GoTo Consulta_cod
    End Sub

    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter
                Dim f As New frmConsultaCliente
                f.txtNome.Text = lblCliente.Text
                f.ShowDialog(Me)
                lblCliente.Text = f.nome
                pedido.cod_cliente = f.cod_cliente
                pedido.cod_filial_cliente = f.cod_filial
        End Select
    End Sub
    Private Sub txtCodProd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodProd.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                busca_produto(False)
        End Select
    End Sub
    Private Sub btnSalvarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarItem.Click
        intUsuario = acesso.retorna_codigo_usuario(frmMain.strUsuario)

        If comparaAutorizacao() = True Then
            MessageBox.Show("Valor autorizado é menor que o valor total do pedido." & Chr(13) & "Por favor fale com seu gerente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If acesso.verifica_pedido_faturado(CInt(lblNpedido.Text), conf.Loja) = 0 Then
            'Pedidos gerados por OS não podem ser alterados
            If pedido.os(pedido.num_pedido, pedido.id_filial) > 0 Then
                AVISO("Este é um pedido gerado por uma OS e não pode ser alterado!", Me, frmAviso.tipo_aviso.tipo_ok)
                Exit Sub
            End If
            'Procedimento 6: Inserir Item Pedido
            If acesso.verifica_permissao_usuario(intUsuario, 6) = False Then
                MessageBox.Show("Usuário não tem permissão para inserir produtos no pedido!", "ERROR: 06", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If existe_item(txtCodProd.Text) = True Then
                acesso.atualiza_quantidade_itens_pedido(lblNpedido.Text, lblFilial.Text, txtCodProd.Text, txtQuant.Text)
                carrega_itens(pedido.num_pedido, pedido.id_filial)
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

            intItem = pedido.item(pedido.num_pedido, pedido.id_filial)

            inserir_produtos(pedido, pedido.num_pedido, pedido.id_filial, txtCodProd.Text, txtQuant.Text)

            'Instrução referente a gravação de dados nas tabelas para emissão do cupom fiscal utilizada pelo sistema Bazar 7
            'Ivanildo 22/10/2013
            If conf.Loja = 1 Then
                If verifica_existencia_registro("SELECT * FROM NOTA WHERE NUMERO = " & pedido.num_pedido & " AND ALMOX = " & pedido.id_filial) = False Then
                    inserirCabecalhoCupom()
                    inserirItensCupom()
                Else
                    inserirItensCupom()
                End If

                If verifica_existencia_registro("SELECT * FROM PRODUTO WHERE CODIGO = " & CInt(txtCodProd.Text) & "") = False Then
                    inserirProdutoCupom()
                End If

                If verifica_existencia_registro("SELECT * FROM CLIENTE WHERE CODIGO = " & pedido.cod_cliente & "") = False Then
                    inserirClienteCupom()
                End If
            End If
            'Fim instrução do cupom fiscal

            txtQuant.Text = 1
            txtCodProd.Text = ""
            lblProduto.Text = ""
            lblPrecoTabela.Text = ""
            lblDescontoTabela.Text = ""
            chkLente.Checked = True
            txtCodProd.Focus()
            txtCodProd.Focus()
        Else
            MessageBox.Show("Não é possível adicionar item a pedido já faturado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub inserir_produtos(ByVal xPedido As objPedidoBalcao, ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer, ByVal x_cod_prod As Integer, ByVal q As Integer)
        Dim p As New produtoClass
        Dim i, m As Integer
        Dim status_item As Integer = 1

        p.Source("Select * from produtos where cod_produto = " & x_cod_prod & "")
        m = txtQuant.Text
        'Avalia se há estoque para atender ao pedido
        If p.saldo_estoque_local(p.fldCod_produto, conf.Loja) >= q Then
            i = 0
            While m > i
                reserva(p.fldCod_produto, pedido.num_pedido)
                status_item = status_item_pedido.reservado
                i = i + 1
            End While
        Else
            Dim r As frmAviso.respo
            r = AVISO("Não há estoque para atender a sua solicitação! Solicitado: " & txtQuant.Text & "; Disponível: " & p.saldo_estoque_local(p.fldCod_produto, conf.Loja) & _
            ". Deseja fazer pedido destes itens?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
            If r = frmAviso.respo.SIM Then
                Dim q_pedido As Integer
                q_pedido = txtQuant.Text - p.saldo_estoque_local(p.fldCod_produto, conf.Loja)
                i = 0
                m = p.saldo_estoque_local(p.fldCod_produto, conf.Loja)
                While m > i
                    reserva(p.fldCod_produto, pedido.num_pedido)
                    status_item = status_item_pedido.reservado
                    i = i + 1
                End While
                pedido.Sugere_compra(x_cod_prod, q_pedido)
                status_item = status_item_pedido.aguardando_pedido
            Else
                GoTo fim
            End If
        End If

        Dim res As String
        res = xPedido.insere_item(x_num_pedido, x_id_filial, p.fldCod_produto, q, lblDescontoTabela.Text, lblPrecoTabela.Text, status_item)

        If res <> Nothing Then
            If res.StartsWith("ER") Then
                MsgBox(res.Substring(3), MsgBoxStyle.Critical)
            End If
        End If

        carrega_itens(pedido.num_pedido, pedido.id_filial)
fim:
    End Sub
    Private Sub reserva(ByVal x_cod_prod As Integer, ByVal x_num_pedido As Integer)
        Dim sql_res As String
        Dim chave As Integer
        chave = retorna_Chave("id_reserva", "reserva_lente_pedido", " where id_filial = " & conf.Loja & "")
        sql_res = "Insert into reserva_lente_pedido(id_reserva,id_filial,num_pedido,cod_produto," & _
        "id_status_reserva,data_reserva) values(" & _
        chave & "," & conf.Loja & "," & x_num_pedido & "," & x_cod_prod & _
        ",0," & d.pdtm(Now) & ")"
        d.Comando(sql_res, True)
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
    Private Sub btnExcluirServico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirServico.Click
        Dim item As Integer
        item = grdServico.CurrentRow.Cells(0).Value
        If pedido.os(pedido.num_pedido, pedido.id_filial) > 0 Then
            Dim intRes As Integer
            intRes = MsgBox("Pedido gerado por OS, deseja excluir o(s) servico(s)?", MsgBoxStyle.YesNo)
            If intRes = vbYes Then
                If user.login(Me).StartsWith("OK") Then
                    If user.acesso(33) = True Then
                        MsgBox(pedido.deleta_servico(pedido.num_pedido, pedido.id_filial, item))
                        carrega_itens(pedido.num_pedido, pedido.id_filial)
                        formata_grid_Servicos()
                        Exit Sub
                    Else
                        MsgBox(" Usuario nao esta autorizado a excluir servicos!", MsgBoxStyle.Critical)
                    End If
                End If
            End If
            AVISO("Este é um pedido gerado por uma OS e não pode ser alterado!", Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        Else
            If pedido.faturado = False Then
                MsgBox(pedido.deleta_servico(pedido.num_pedido, pedido.id_filial, item))
                carrega_itens(pedido.num_pedido, pedido.id_filial)
                formata_grid_Servicos()
            Else
                '33 Excluir itens pedido Cancelado
                Dim intRes As Integer
                intRes = MsgBox("Deseja excluir o(s) servico(s)?", MsgBoxStyle.YesNo)
                If intRes = vbYes Then
                    If user.login(Me).StartsWith("OK") Then
                        If user.acesso(33) = True Then
                            MsgBox(pedido.deleta_servico(pedido.num_pedido, pedido.id_filial, item))
                            carrega_itens(pedido.num_pedido, pedido.id_filial)
                            formata_grid_Servicos()
                        Else
                            MsgBox(" Usuario nao esta autorizado a excluir servicos!", MsgBoxStyle.Critical)
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btnExcluirProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirProd.Click
        Dim item As Integer
        Dim i As Integer = 0
        Dim res As String
        If pedido.os(pedido.num_pedido, pedido.id_filial) > 0 Or pedido.faturado = True Then
            Dim intRes As Integer
            intRes = MsgBox("Deseja excluir o(s) produtos(s)? Somente usuários autorizados têm acesso a exclusão", MsgBoxStyle.YesNo)
            If intRes = vbYes Then
                If user.login(Me).StartsWith("OK") Then
                    If user.acesso(33) = True Then
                        GoTo delete
                    Else
                        MsgBox(" Usuario nao esta autorizado a excluir produtos!", MsgBoxStyle.Critical)
                    End If
                End If
            End If
            AVISO("Este é um pedido gerado por uma OS e não pode ser alterado!", Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        Else
delete:
            item = grdProd.CurrentRow.Cells(0).Value
            res = res & vbCrLf & pedido.deleta_item(pedido.num_pedido, pedido.id_filial, item)
            excluiItemCupom(pedido.num_pedido, item)
        End If

        carrega_itens(pedido.num_pedido, pedido.id_filial)
        formata_grid_itens()
        MsgBox("Concluido!")

    End Sub

    Private Sub btnPrintEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintEstoque.Click
        Me.Cursor = Cursors.AppStarting
        Dim r As New rptItensPedidoEstoque
        Dim f As New frmRpt
        Dim eco As String = ""

        r.data = pedido.data_pedido
        r.cliente = lblCliente.Text
        r.n_pedido = pedido.num_pedido
        r.Vendedor = lblVendedor.Text
        r.DataSource = tb_itens
        'r.tbServ = tb_servico
        r.cod_cliente = pedido.cod_cliente
        'r.Total = lblTotal.Text
        f.Relat(r)
        Me.Cursor = Cursors.Default
        f.Show()
    End Sub

    Private Sub btnIncluirTodoEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluirTodoEstoque.Click
        Dim x_cod_tabela As Integer
        Dim tt As New DataTable
        Dim r As DataRow
        If UserID = 1 Then
            x_cod_tabela = InputBox("Digite o código da lente", "")
            tt = p.saldos_labo(x_cod_tabela, "", conf.Loja)
            For Each r In tt.Rows
                If r("saldo") > 0 Then
                    txtQuant.Text = r("saldo")
                    txtCodProd.Text = r("cod_produto")
                    busca_produto(True)
                    btnSalvarItem_Click(Me, EventArgs.Empty)
                    Application.DoEvents()
                End If
            Next
        End If


    End Sub

    Private Sub mniAtualizaPreco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniAtualizaPreco.Click
        Dim item As Integer
        Dim i As Integer = 0
        Dim res As String
        Dim prod As New produtoClass
        Dim user As New objUsuario
        If user.login(Me).StartsWith("OK") Then
            'Procedimento 29 atualiza o preço do item de acordo com 
            'o valor cadastrado na tabela
            If user.acesso(29) = False Then
                AVISO("Usuário não tem permissão para atualizar preço!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                Exit Sub
            End If
            item = grdProd.CurrentRow.Cells(0).Value
            prod.filtra(pedido.retorna_cod_item(item))
            res = res & vbCrLf & pedido.altera_preco_item(item, prod.Preco_venda)
        End If

        carrega_itens(pedido.num_pedido, pedido.id_filial)
        formata_grid_itens()
        MsgBox("Concluido!")

    End Sub
    Private Sub TrocaProdutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrocaProdutoToolStripMenuItem.Click
        Dim item As New Item
        Dim i As Integer = 0
        Dim res As String
        Dim quant As Integer
        Dim dev As New objDevolucaoEstoquePedido
        Dim total As Double
        If pedido.os(pedido.num_pedido, pedido.id_filial) > 0 Then
            AVISO("Este é um pedido gerado por uma OS e não pode ser alterado!", Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        Else
            Dim intRes As Integer
            intRes = MsgBox("Deseja devolver o(s) produtos(s)? Somente usuários de estoque autorizados têm acesso a devolução", MsgBoxStyle.YesNo)
            If intRes = vbYes Then
                'Procedimento 36: 
                If user.login(Me).StartsWith("OK") Then
                    If user.acesso(36) = False Then
                        MsgBox("Usuario nao está autorizado a devolver produtos!", MsgBoxStyle.Critical)
                        Exit Sub

                    End If
                End If
            End If
            dev.novo()
            dev.num_pedido = pedido.num_pedido
            dev.id_filial_pedido = pedido.id_filial
            dev.id_usuario = user.cod_usuario
            MsgBox(dev.Salvar())
            dev.atualiza_valor_itens(total)
            carrega_itens(pedido.num_pedido, pedido.id_filial)
            formata_grid_itens()
            MsgBox(res)
        End If
    End Sub

    Private Sub cbForma_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbForma.SelectedIndexChanged
        'Verifica se há pedido encontrado
        If CInt(lblNpedido.Text) > 0 Then

            'Busca o desconto de venda a vista para se aplciado na hora da venda
            Dim strSQL As String = "select desconto_venda_vista from controle"
            Dim tt As New DataTable
            tt = acesso.retornaRegistro(strSQL).Tables(0)

            'Verifica se o cliente tem ou não debito na empresa
            If (intContador = 0) Or (intContador = 3) Or (intContador = 4) Then
                If cbForma.SelectedValue = 1 Then
                    descavista = tt.Rows(0)("desconto_venda_vista")
                    lblDescontoTabela.Text = Format(descavista, "##0.00")
                Else
                    lblDescontoTabela.Text = Format(CDbl(0.0), "##0.00")
                    descavista = 0
                End If
            End If

            'Instrução responsável por pegar a data referente ao desconto de avista
            Dim strSQLData As String = "select data_desc_vista from controle"
            Dim ttData As New DataTable
            ttData = acesso.retornaRegistro(strSQLData).Tables(0)

            'Se a data do desconto avista for menor que a data do pedido ele atualiza atualzia a forma de pagamento do pedido
            'E verifica em seguida se há item vinculada ao pedido em caso positivo trabalha a alteração do desconto em cada item
            If ttData.Rows(0)("data_desc_vista") < pedido.data_pedido Then
                acesso.atualiza_forma_pagamento_pedido(CInt(cbForma.SelectedValue), CInt(lblNpedido.Text), CInt(lblFilial.Text))

                If grdProd.Rows.Count > 0 Then
                    For Each linha As DataGridViewRow In grdProd.Rows
                        If linha.Cells(9).Value Is DBNull.Value Then
                            acesso.atualiza_preco_desconto_pedido(CInt(lblNpedido.Text), CInt(lblFilial.Text), descavista, linha.Cells(0).Value)
                        End If
                    Next
                End If
                carrega_itens(pedido.num_pedido, pedido.id_filial)
            End If
        End If
    End Sub

    Private Sub busca_preco_desconto(ByVal codigo As String)
        If codigo = "0" Then
            codigo = ""
            Exit Sub
        End If

        'If txtCodProd.Text = "" Then GoTo consulta
Consulta_cod:
        p.Source("Select * from produtos where cod_produto = " & codigo & "")
        If p.max = 1 Then
            codigo = COD_PROD
            'lblProduto.Text = p.fldProduto
            lblPrecoTabela.Text = Format(p.Preco_venda, "#,##0.00")

            'Verifica seo cliente não tem débito em aberto e a forma de pagamento é igual a 1
            If p.desconto(pedido.cod_cliente, pedido.cod_filial_cliente) > 0 Then
                'Retorna o valor da tabela promocional
                lblPrecoTabela.Text = Format(CDbl(lblPrecoTabela.Text) - (CDbl(lblPrecoTabela.Text) * p.desconto(pedido.cod_cliente, pedido.cod_filial_cliente) / 100), "#,##0.00")
                lblDescontoTabela.Text = Format(descavista, "##0.00")
            Else
                descavista = Format(p.desconto(pedido.cod_cliente, pedido.cod_filial_cliente), "#,##0.00")
                lblDescontoTabela.Text = Format(descavista, "##0.00")
            End If

            btnSalvarItem.Enabled = True
            btnSalvarItem.Focus()
            Exit Sub
        Else
            Dim ret As String
            ret = p.Retorna_cod_prod(codigo)
            If ret <> "0" Then
                codigo = ret
                GoTo Consulta_cod
            Else
                GoTo consulta
            End If
        End If

consulta:
    End Sub

    'Grava o cabeçalho dentro da tabela Nota do Bazar 7
    Private Sub inserirCabecalhoCupom()
        Dim strSQL As String = "INSERT INTO NOTA (NUMERO,ALMOX, CLIENTE, VENDEDOR, FORMA, DATA,P_DESCONTO,DESCONTO,TIPO_DOCUMENTO, SITUACAO) " & _
            "VALUES(" & pedido.num_pedido & "," & pedido.id_filial & "," & pedido.cod_cliente & "," & pedido.cod_vendedor & "," & _
            1 & "," & d.Pdt(Now) & "," & 0.0 & "," & 0.0 & "," & "'CF'" & "," & "'A'" & ")"
        Dim cmd As New SqlCommand(strSQL, dn.con)
        Try
            dn.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            dn.desconecta()
        End Try
    End Sub

    'Grava os itens dentro da tabela I_Nota do Bazar 7
    Private Sub inserirItensCupom()
        Dim valor As Double = CDbl(lblPrecoTabela.Text) - (CDbl(lblPrecoTabela.Text) * CDbl(lblDescontoTabela.Text) / 100)
        Dim strSQL As String = "INSERT INTO I_NOTA (NUMERO,ITEM, PRODUTO, UNIDADE,QUANTIDADE, VALOR, DESCONTO) " & _
            "VALUES(" & pedido.num_pedido & "," & intItem & "," & CInt(txtCodProd.Text) & "," & "'UN'" & "," & CInt(txtQuant.Text) & "," & _
        Replace(valor, ",", ".") & "," & 0.0 & ")"
        Dim cmd As New SqlCommand(strSQL, dn.con)
        Try
            dn.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            dn.desconecta()
        End Try
    End Sub

    'Exclui os itens dentro da tabela I_Nota do Bazar 7
    Private Sub excluiItemCupom(ByVal pedido As Integer, ByVal item As Int16)
        Dim strSQL As String = "DELETE FROM I_NOTA WHERE NUMERO = " & pedido & " AND ITEM = " & item & ""
        Dim cmd As New SqlCommand(strSQL, dn.con)
        Try
            dn.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            dn.desconecta()
        End Try
    End Sub

    'Atualzia o valor do cupom dentro da tabela Nota do Bazar 7
    Private Sub atualizaValorCupom()
        Dim valor As Double = CDbl(lblTotProd.Text)
        Dim strSQL As String = "UPDATE NOTA SET VALOR = " & valor.ToString.Replace(",", ".") & " WHERE NUMERO = " & pedido.num_pedido & _
            " AND ALMOX = " & conf.Loja & ""
        Try
            dn.conecta()
            Dim cmd As New SqlCommand(strSQL, dn.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            dn.desconecta()
        End Try
    End Sub

    'Função responsável por verificar se um determinado registro existe ou não
    Private Function verifica_existencia_registro(ByVal instrucaoSQL As String) As Boolean
        Dim resultado As Boolean
        resultado = False
        Dim strSQL As String = instrucaoSQL
        Try
            dn.conecta()
            Dim cmd As New SqlCommand(strSQL, dn.con)
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            dn.desconecta()
        End Try
    End Function

    'Grava detalhe dos produtos dentro da tabela Produto do Bazar 7
    Private Sub inserirProdutoCupom()
        Dim intItem As Int16 = pedido.item(pedido.num_pedido, pedido.id_filial)
        Dim valor As Double = CDbl(lblPrecoTabela.Text)
        Dim strProduto As String

        If lblProduto.Text.Length > 40 Then
            strProduto = lblProduto.Text.Substring(0, 40)
        Else
            strProduto = lblProduto.Text
        End If

        Dim strSQL As String = "INSERT INTO PRODUTO (CODIGO,DESCRICAO, CLASSE, GRUPO, SUBGRUPO, MARCA, FABRICANTE, UNIDADE, CONTROLADO, CODIGOTRIBUTACAO, VENDA, SERIE, COR) " & _
            "VALUES(" & CInt(txtCodProd.Text) & ",'" & strProduto & "'," & 1 & "," & 1 & "," & 1 & "," & 1 & "," & 1 & "," & "'UN'" & ",'" & False & "'," & 0 & "," & _
            Replace(valor, ",", ".") & ",'" & False & "','" & False & "')"
        Try
            dn.conecta()
            Dim cmd As New SqlCommand(strSQL, dn.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            dn.desconecta()
        End Try
    End Sub

    'Grava detalhe dos produtos dentro da tabela Produto do Bazar 7
    Private Sub inserirClienteCupom()
        Dim intItem As Int16 = pedido.item(pedido.num_pedido, pedido.id_filial)
        Dim valor As Double = CDbl(lblPrecoTabela.Text)
        Dim strNome, strRazao, strEndereco As String
        If cliente.razao_social.Length > 40 Then
            strRazao = cliente.razao_social.Substring(0, 40)
        Else
            strRazao = cliente.razao_social
        End If

        If cliente.nome_cliente.Length > 40 Then
            strNome = cliente.nome_cliente.Substring(0, 40)
        Else
            strNome = cliente.nome_cliente
        End If

        If cliente.endereco.Length > 40 Then
            strEndereco = cliente.endereco.Substring(0, 40)
        Else
            strEndereco = cliente.endereco
        End If

        Dim strSQL As String = "INSERT INTO CLIENTE (CODIGO, RAZAOSOCIAL, FANTASIA, ENDERECO, NUMERO, T_INSCRICAO, CNPJ_CPF) " & _
            "VALUES(" & pedido.cod_cliente & ",'" & strRazao & "','" & strNome & "','" & _
            strEndereco & "'," & cliente.numero & "," & 1 & ",'" & cliente.cnpj & "')"
        Try
            dn.conecta()
            Dim cmd As New SqlCommand(strSQL, dn.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            dn.desconecta()
        End Try
    End Sub

    Private Sub frmPedido_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If conf.Loja = 1 Then
            atualizaValorCupom()
        End If
    End Sub


    Private Sub txtVendedorExterno_Leave(sender As System.Object, e As System.EventArgs) Handles txtVendedorExterno.Leave
        If txtVendedorExterno.Text = "" Then
            txtVendedorExterno.Text = 0
        End If
        If CInt(txtVendedorExterno.Text) > 0 Then
            Dim strSQL As String = "cod_vendedor_ext = " & CInt(txtVendedorExterno.Text) & " where num_pedido = " & CInt(lblNpedido.Text) & " and id_filial = " & CInt(lblFilial.Text)
            acesso.atualiza_registros("pedido_balcao", strSQL)
        End If
    End Sub

    Public Function restricoes_bloqueado() As Integer
        Dim tbRestricao As New DataTable
        tbRestricao = acesso.resumo_receber_cliente(cliente.cod_cliente, cliente.cod_filial_cliente)

        For Each linha As DataRow In tbRestricao.Rows
            If linha("acordo_atrasado") > 0 Then
                resultado = 1
            ElseIf linha("titulos_atraso") > 0 Then
                resultado = 2
            ElseIf acesso.resumo_receber_total_cliente(cliente.cod_cliente, cliente.cod_filial_cliente) > cliente.limite_credito Then
                resultado = 3
            Else
                resultado = 4
            End If
        Next
        Return resultado
    End Function

    Private Function retornaFormaPagPed() As Integer
        Dim strSQLForma As String = "SELECT FORMA FROM PEDIDO_BALCAO WHERE NUM_PEDIDO = " & CInt(lblNpedido.Text) & _
        " AND ID_FILIAL = " & CInt(lblFilial.Text)
        Dim ttFormaPag As New DataTable
        ttFormaPag = acesso.retornaRegistro(strSQLForma).Tables(0)
        If Not ttFormaPag.Rows(0)("Forma") Is DBNull.Value Then
            Return ttFormaPag.Rows(0)("Forma")
        End If
    End Function



    Private Sub btnSalvarServico_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvarServico.Click
        If acesso.verifica_pedido_faturado(CInt(lblNpedido.Text), conf.Loja) = 0 Then
            If pedido.os(pedido.num_pedido, pedido.id_filial) > 0 And UserID <> 1 Then
                AVISO("Este é um pedido gerado por uma OS e não pode ser alterado!", Me, frmAviso.tipo_aviso.tipo_ok)
                Exit Sub
            Else
                p.Source("Select * from produtos where cod_produto = " & cbServicos.SelectedValue & "")
                MsgBox(pedido.insere_servico(pedido.num_pedido, pedido.id_filial, p.fldCod_produto, txtQuantServ.Text, p.fldDesconto, p.fldPreco_venda, 1, Nothing))
                carrega_itens(pedido.num_pedido, pedido.id_filial)
            End If
        Else
            MessageBox.Show("Não é possível adicionar item a pedido já faturado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        cbServicos.Focus()
    End Sub

    Private Function comparaAutorizacao() As Boolean
        valorpedido = 0
        Dim resultado As Boolean = False
        Dim strSQL As String = "select sum(valor) as valor from autorizacao where cod_cliente = " & pedido.cod_cliente & _
        " and cod_filial_cliente = " & pedido.id_filial & " and data = " & d.Pdt(Now) & " and data_uso is null"
        Dim ttPedido As New DataTable
        ttPedido = acesso.retornaRegistro(strSQL).Tables(0)

        If grdProd.Rows.Count = 0 Then
            valorpedido = valorpedido + (CDbl(lblPrecoTabela.Text) - (CDbl(lblPrecoTabela.Text) * CDbl(lblDescontoTabela.Text) / 100)) * CInt(txtQuant.Text)
        End If

        If grdProd.Rows.Count > 0 Then
            For Each linha As DataGridViewRow In grdProd.Rows
                If linha.Cells(9).Value Is DBNull.Value Then
                    lblPrecoTabela.Text = 0
                    lblDescontoTabela.Text = 0
                    txtQuant.Text = 0
                    valorpedido = valorpedido + (CDbl(lblPrecoTabela.Text) - (CDbl(lblPrecoTabela.Text) * CDbl(lblDescontoTabela.Text) / 100)) * CInt(txtQuant.Text)
                    valorpedido = valorpedido + CDbl(linha.Cells(5).Value)
                End If
            Next
        End If

        If Not ttPedido.Rows(0)("valor") Is DBNull.Value Then
            If ttPedido.Rows(0)("valor") < valorpedido Then
                Return True
            End If
        End If
    End Function
End Class


Public Structure Item2
    Dim item As Integer
    Dim nome As String
    Dim quant As Integer
    Dim vunit As Integer
    Dim desc As Double
    Dim pct As Object
    Dim cod_produto As Integer
End Structure