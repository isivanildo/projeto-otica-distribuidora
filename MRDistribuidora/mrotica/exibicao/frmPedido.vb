Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Imports MRUtil
Public Class frmPedido
    Dim tb_pedido As New DataTable
    Dim tb_itens As New DataTable
    Dim tb_servico As New DataTable
    Dim tb_Serv As New DataTable
    Dim ttForma As New DataTable
    Dim ttDesconto As New DataTable
    Dim pedido As New objPedidoBalcao
    Dim cliente As New objCliente
    Dim tbUs As New DataTable
    Dim p As New produtoClass
    Dim prod As New Produto
    Dim lentebloco As New Lentes
    Dim tabelapromo As New TabelaPromocional
    Dim PedItem As New PedidoItens
    Dim FaturaItens As New FaturaItens
    Dim Usu As New UsuarioPermissao
    Dim d As New dados
    Dim Conexao As New ConexaoDB
    Dim dados As New ConexaoDB
    Dim usuario As New objUsuario
    Dim COD_PROD As Long
    Public _num_pedido, _id_filial As Integer
    Public origem As String
    Public os As Boolean = False
    Public intContador As Integer
    Public intControle As Int16
    Dim intForma As Integer
    Dim L As New objLentesDiop
    Dim conf As New config
    Dim user As New objUsuario
    Dim acesso As New objMaster
    Dim intUsuario As Integer
    Dim intItem As Int16
    Dim descavista As Double = 0
    Dim resultado As Integer = 0
    Dim valorpedido As Double = 0.0
    Dim intcodtabela As Integer
    Public intTipoCliente As Int16
    Public strOS As Char
    Dim ttProduto As New DataTable
    Dim dn As New dados(conf.usuarioSql, conf.SenhaSql, conf.servidorDB, conf.dbBazar)

    Private Sub frmPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(frmMain.intCodigoUsuario)

        'intTipoCliente = cliente.cod_tipo_cliente

        'If intTipoCliente <> 2 Then

        If origem = "troca" Then
            troca()
        End If

        carrega_pedido(_num_pedido, _id_filial)
        carrega_combos() 'Carrega as fromas de pagamento para o cliente
        cbForma.SelectedValue = retornaFormaPagPed() 'Retorna a forma de pagamento que foi escolhida na hora de gerar o pedido

        'Se os dados do pedido vierem de uma OS a instrução seguinte é executada
        'If strOS = "S" Then
        'If (intContador = 1) Or (intContador = 2) Or (intContador = 3) Then
        'cbForma.SelectedValue = 0
        'cbForma.Enabled = True
        'End If
        ' End If


        'Dim strSQLOSPed As String = "select cod_os from os where num_pedido = " & CInt(lblNpedido.Text) & " and id_filial = " & CInt(lblFilial.Text)

        ' If dados.VerificaExistenciaReg(strSQLOSPed) = 1 Then
        'txtVendedorExterno.Enabled = False
        'chkLente.Enabled = False
        'txtQuant.Enabled = False
        'txtCodProd.Enabled = False
        'btnExcluirProd.Enabled = False
        'cbServicos.Enabled = False
        'txtQuantServ.Enabled = False
        'btnExcluirServico.Enabled = False
        'strOS = "S"

        'If comparaAutorizacao() = True Then
        'MessageBox.Show("Valor autorizado é menor que o valor total do pedido." & Chr(13) & "Por favor fale com seu gerente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Dim strSQLAtuPed As String = "cod_status_pedido = 4 where num_pedido = " & pedido.num_pedido & " and cod_cliente = " & pedido.cod_cliente &
        '       " and id_filial = " & conf.Filial
        'acesso.atualiza_registros("Pedido_balcao", strSQLAtuPed, True)

        'Dim strSQLAtuItem As String = "cod_status_item = 4 where num_pedido = " & pedido.num_pedido & " And id_filial = " & conf.Filial
        'acesso.atualiza_registros("Pedido_balcao_itens", strSQLAtuItem, True)
        'Exit Sub
        ' If
        'End If


        'Novo 30/04/2014
        '  If strOS = "S" Then
        'Instrução responsável por pegar a data referente ao desconto de avista para não influenciar em descontos anteriores em caso de abertura
        'de um pedido para verificação com desconto anterior a data cadastrada
        ' Dim strSQLData As String = "select data_desc_vista from controle"
        'Dim strSQLDesconto As String = "select desconto from pedido_balcao_itens where num_pedido = " & pedido.num_pedido &
        '       " and id_filial = " & pedido.id_filial
        'Dim ttData As New DataTable
        'Dim ttDesconto As New DataTable

        'ttData = acesso.retornaRegistro(strSQLData).Tables(0)
        'ttDesconto = acesso.retornaRegistro(strSQLDesconto).Tables(0)
        'If ttDesconto.Rows.Count > 0 Then
        'descavista = ttDesconto.Rows(0)("desconto")
        'End If

        ' If (intContador = 1) Or (intContador = 2) Then 'Indica bloqueio por atraso no acordo ou na fatura, o cliente so poderá comprar a vista
        'MessageBox.Show("Este cliente só pode comprar a vista.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'If retornaFormaPagPed() > 0 Then
        'cbForma.SelectedValue = retornaFormaPagPed()
        'Else
        '   cbForma.SelectedValue = 1
        'End If

        'temp   
        'If ttForma.Rows(0)("codigo") = 5 Then
        'cbForma.SelectedValue = ttForma.Rows(0)("codigo")
        'End If
        'fim temp

        '     cbForma.Enabled = False
        '    lblDescontoTabela.Text = Format(0.0, "##0.00")
        '   descavista = Format(0.0, "##0.00")
        '  atualizaStatusDesconto("N")
        'ElseIf (intContador = 3) Then
        ' Dim strSQLOS As String = "select desconto_venda_vista from controle"
        'Dim ttOS As New DataTable
        'ttOS = acesso.retornaRegistro(strSQLOS).Tables(0)
        'lblDescontoTabela.Text = Format(0.0, "#,##0.00")
        'descavista = Format(descavista, "##0.00")
        'cbForma.SelectedValue = retornaFormaPagPed()
        '  cbForma.Enabled = True
        '   atualizaStatusDesconto("S")
        'ElseIf (intContador = 4) Then
        'Dim strSQLOS As String = "select desconto_venda_vista from controle"
        'Dim ttOS As New DataTable
        ' ttOS = acesso.retornaRegistro(strSQLOS).Tables(0)
        'lblDescontoTabela.Text = Format(CDbl(ttOS.Rows(0)("desconto_venda_vista")), "##0.00")
        '  lblDescontoTabela.Text = Format(0.0, "#,##0.00")
        '   descavista = Format(descavista, "##0.00")
        '    cbForma.SelectedValue = retornaFormaPagPed()
        '     cbForma.Enabled = True
        '      atualizaStatusDesconto("S")
        '  End If

        'Dim preco As Double

        'Se a data do desconto avista for menor que a data do pedido ele atualiza a forma de pagamento do pedido
        'E verifica em seguida se há item vinculada ao pedido em caso positivo trabalha a alteração do desconto em cada item
        ' If ttData.Rows(0)("data_desc_vista") < pedido.data_pedido Then
        'If grdProd.Rows.Count > 0 Then
        ' For Each linha As DataGridViewRow In grdProd.Rows
        '      If linha.Cells(8).Value Is DBNull.Value Then
        '           preco = CDbl(linha.Cells(3).Value) - (CDbl(linha.Cells(3).Value) * CDbl(lblDescontoTabela.Text) / 100)
        '            acesso.atualiza_preco_desconto_pedido(CInt(lblNpedido.Text), CInt(lblFilial.Text), descavista, linha.Cells(0).Value, preco)
        '             acesso.atualiza_forma_pagamento_pedido(CInt(cbForma.SelectedValue), CInt(lblNpedido.Text), CInt(lblFilial.Text))
        '          End If
        '       Next
        '    End If
        '     carrega_itens(pedido.num_pedido, pedido.id_filial)
        '  End If
        '   btnExcluirProd.Enabled = False
        '    btnSalvarServico.Enabled = False
        ' End If

        'fim novo

        If origem = "editar" Then
            cbForma.Enabled = False
            btnExcluirProd.Enabled = False
        End If
        'Else
        '    carrega_pedido(_num_pedido, _id_filial)
        '   carrega_combos() 'Carrega as fromas de pagamento para o cliente
        '    cbForma.SelectedValue = 1
        '    atualizaStatusDesconto("N")
        'End If

        desativaControle()
    End Sub

    Private Sub troca()
        travaControles(Me.grpCabecalho.Controls)
        travaControles(Me.grpProdutos.Controls)
        travaControles(Me.grpProdutos.Controls)
        btnSalvarItem.Enabled = False
        btnExcluirProd.Enabled = False
        btnExcluirServico.Enabled = False
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
        pedido.id_filial = conf.Filial
        lblFilial.Text = pedido.id_filial
        Dim intCodUsuario As Integer = acesso.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        lblVendedor.Text = acesso.retornaUsuario(intCodUsuario)
    End Sub
    Public Sub carrega_combos()
        Dim sqlc As String

        sqlc = "SELECT produtos.cod_produto, " &
        "(produtos.produto + ' R$ ' +  cast(produtos.preco_venda as varchar(12)) + " &
        "',00') AS produto FROM produtos INNER JOIN  " &
        "servicos ON produtos.cod_produto = servicos.cod_produto  " &
        "WHERE servicos.cod_tipo_servico = 1 or " &
        "servicos.cod_tipo_servico = 2 or " &
        "servicos.cod_tipo_servico = 3 or " &
        "servicos.cod_tipo_servico = 4 " &
        "order by servicos.cod_tipo_servico "
        d.carrega_Tabela(sqlc, tb_Serv)
        cbServicos.DataSource = tb_Serv
        cbServicos.DisplayMember = "produto"
        cbServicos.ValueMember = "cod_produto"

        strSQL = "select tipo_compra.* from tipo_compra inner join forma_compra on tipo_compra.codigo = forma_compra.codigo_tipo_compra " &
            "where forma_compra.cod_cliente = " & pedido.cod_cliente & " and  forma_compra.cod_filial_cliente = " & pedido.cod_filial_cliente
        d.carrega_Tabela(strSQL, ttForma)
        cbForma.DisplayMember = "descricao"
        cbForma.ValueMember = "codigo"
        cbForma.DataSource = ttForma
    End Sub
    Public Sub cerrega_cliente(ByVal x_cod_cliente As Integer, ByVal x_cod_filial_cliente As Integer)
        cliente.Source("Select * from cliente where cod_filial_cliente = " & x_cod_filial_cliente &
        " and cod_cliente = " & x_cod_cliente & "")
        cliente.primeiro()
        lblCliente.Text = cliente.nome_cliente
    End Sub
    Public Sub carrega_pedido(ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer)
        pedido.Source("Select * from pedido_balcao where num_pedido = " & x_num_pedido &
        " and id_filial = " & x_id_filial)
        If pedido.max > 0 Then
            lblNpedido.Text = pedido.num_pedido
            lblFilial.Text = pedido.id_filial
            lblVendedor.Text = acesso.retornaUsuario(pedido.cod_vendedor)
            lblData.Text = Format(pedido.data_pedido, "Short Date")
            txtVendedorExterno.Text = pedido.cod_vendedor_externo
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

        Dim cPreco As New DataGridViewTextBoxColumn 'Posição 03
        With cPreco
            .DataPropertyName = "preco_tab"
            .HeaderText = "P. Tab"
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 70
        End With
        grdProd.Columns.Add(cPreco)

        Dim cDesc As New DataGridViewTextBoxColumn 'Posição 04
        With cDesc
            .DataPropertyName = "desconto"
            .HeaderText = "Desc. (%)"
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 80
        End With
        grdProd.Columns.Add(cDesc)

        Dim cPrecoUnit As New DataGridViewTextBoxColumn 'Posição 05
        With cPrecoUnit
            .DataPropertyName = "preco"
            .HeaderText = "P. Unit"
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 70
        End With
        grdProd.Columns.Add(cPrecoUnit)

        Dim cTotal As New DataGridViewTextBoxColumn 'Posição 06
        With cTotal
            .DataPropertyName = "Total"
            .HeaderText = "Total"
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 70
        End With
        grdProd.Columns.Add(cTotal)

        Dim cStatus_item As New DataGridViewTextBoxColumn ' Posição 07
        With cStatus_item
            .DataPropertyName = "status_item"
            .HeaderText = "Status"
            .Width = 120
        End With
        grdProd.Columns.Add(cStatus_item)

        Dim cPacote As New DataGridViewTextBoxColumn 'Posição 08
        With cPacote
            .DataPropertyName = "cod_pacote"
            .HeaderText = "Pacote"
            .Width = 60
        End With
        grdProd.Columns.Add(cPacote)

        Dim cCod As New DataGridViewTextBoxColumn 'Posição 09
        With cCod
            .DataPropertyName = "cod_produto"
            .HeaderText = "Código"
            .Width = 70
        End With
        grdProd.Columns.Add(cCod)

        grdProd.DataSource = tb_itens

        If tb_itens.Rows.Count > 0 Then
            If (pedido.cod_status_pedido = 2) Or (pedido.cod_status_pedido = 3) Or (pedido.cod_status_pedido = 4) Then
                txtVendedorExterno.Enabled = False
                cbForma.Enabled = False
                chkLente.Enabled = False
                txtQuant.Enabled = False
                txtCodProd.Enabled = False
                btnExcluirProd.Enabled = False
                cbServicos.Enabled = False
                txtQuantServ.Enabled = False
                btnExcluirServico.Enabled = False
            ElseIf (pedido.cod_status_pedido = 1) Then
                btnExcluirProd.Enabled = True
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
            .Width = 320
        End With
        grdServico.Columns.Add(cProd)

        Dim cQuant As New DataGridViewTextBoxColumn 'Posição 02
        With cQuant
            .DataPropertyName = "quant"
            .HeaderText = "Qtde"
            .Width = 40
        End With
        grdServico.Columns.Add(cQuant)

        Dim cPreco_tab As New DataGridViewTextBoxColumn 'Posição 03
        With cPreco_tab
            .DataPropertyName = "preco_tab"
            .HeaderText = "P. Tab"
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 70
        End With
        grdServico.Columns.Add(cPreco_tab)

        Dim cDesc As New DataGridViewTextBoxColumn 'Posição 04
        With cDesc
            .DataPropertyName = "desconto"
            .HeaderText = "Desc. (%)"
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 80
        End With
        grdServico.Columns.Add(cDesc)

        Dim cPreco As New DataGridViewTextBoxColumn 'Posição 05
        With cPreco
            .DataPropertyName = "preco"
            .HeaderText = "P. Unit"
            .DefaultCellStyle.Format = "#,##0.00"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Width = 70
        End With
        grdServico.Columns.Add(cPreco)

        Dim cTotal As New DataGridViewTextBoxColumn 'Posição 06
        With cTotal
            .DataPropertyName = "Total"
            .HeaderText = "Total."
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DefaultCellStyle.Format = "#,##0.00"
            .Width = 70
        End With
        grdServico.Columns.Add(cTotal)

        Dim cStatus As New DataGridViewTextBoxColumn 'Posição 08
        With cStatus
            .DataPropertyName = "status_servico"
            .HeaderText = "Status"
            .Width = 120
        End With
        grdServico.Columns.Add(cStatus)

        Dim cPacote As New DataGridViewTextBoxColumn 'Posição 09
        With cPacote
            .DataPropertyName = "cod_pacote"
            .HeaderText = "Pacote"
            .Width = 60
        End With
        grdServico.Columns.Add(cPacote)

        Dim cCodServico As New DataGridViewTextBoxColumn 'Posição 10
        With cCodServico
            .DataPropertyName = "cod_servico"
            .HeaderText = "Código"
            .Width = 70
        End With
        grdServico.Columns.Add(cCodServico)

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
                btnExcluirServico.Enabled = False
            End If
        End If
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
            fc.tipo = acesso.tipo(txtCodProd.Text)
            fc.ShowDialog(Me)
            COD_PROD = fc.Result
        Else
            COD_PROD = txtCodProd.Text
        End If
        'If txtCodProd.Text = "" Then GoTo consulta
Consulta_cod:
        Dim strSQL As String = "Select * from produtos where cod_produto = " & COD_PROD & ""
        Dim ttProduto As New DataTable
        ttProduto = acesso.retornaRegistro(strSQL).Tables(0)
        If ttProduto.Rows.Count = 1 Then
            Dim precoReal As Double = ttProduto.Rows(0)("preco_venda") - (ttProduto.Rows(0)("preco_venda") * ttProduto.Rows(0)("desconto") / 100)
            txtCodProd.Text = COD_PROD
            lblProduto.Text = ttProduto.Rows(0)("Produto").ToString
            If cliente.sem_desconto = 0 Then
                lblPrecoTabela.Text = Format(precoReal, "#,##0.00")
                lblDescontoTabela.Text = Format(descavista, "##0.00")
            Else
                lblPrecoTabela.Text = Format(ttProduto.Rows(0)("preco_venda"), "#,##0.00")
                lblDescontoTabela.Text = Format(descavista, "##0.00")
            End If

            'Verifica seo cliente não tem débito em aberto e a forma de pagamento é igual a 1
            'If p.desconto(pedido.cod_cliente, pedido.cod_filial_cliente) > 0 Then
            'Retorna o valor da tabela promocional
            'lblPrecoTabela.Text = Format(CDbl(lblPrecoTabela.Text) - (CDbl(lblPrecoTabela.Text) * p.desconto(pedido.cod_cliente, pedido.cod_filial_cliente) / 100), "#,##0.00")
            '  lblDescontoTabela.Text = Format(descavista, "##0.00")
            'Else
            ' If CDbl(lblDescontoTabela.Text) > 0 Then
            'lblDescontoTabela.Text = Format(descavista, "##0.00")
            ' Else
            '  descavista = Format(p.desconto(pedido.cod_cliente, pedido.cod_filial_cliente), "#,##0.00")
            '  lblDescontoTabela.Text = Format(descavista, "##0.00")
            ' End If
            'End If




            If cliente.cod_tipo_cliente = 2 Then
                lblPrecoTabela.Text = ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) +
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

    Private Sub busca_produto()
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

        'intcodtabela = CInt(txtCodProd.Text)

        fc.txtCodTabela.Text = txtCodProd.Text
        fc.tipo = acesso.tipo(txtCodProd.Text)
        fc.ShowDialog(Me)
        COD_PROD = fc.Result

        'Retorna informações sobre o produto encontrado.
Consulta_cod:
        Dim strSQL As String = "Select * from produtos where cod_produto = " & COD_PROD & ""
        ttProduto = acesso.retornaRegistro(strSQL).Tables(0)
        If ttProduto.Rows.Count = 1 Then
            Dim precoReal As Double = (ttProduto.Rows(0)("preco_venda") * ttProduto.Rows(0)("fator_preco")) - (ttProduto.Rows(0)("preco_venda") * ttProduto.Rows(0)("desconto") / 100)
            txtCodProd.Text = COD_PROD
            lblProduto.Text = ttProduto.Rows(0)("Produto").ToString
            lblPrecoTabela.Text = Format(precoReal, "#,##0.00")
            'lblDescontoTabela.Text = Format(descavista, "##0.00")

            If cliente.cod_tipo_cliente = 2 Then
                lblPrecoTabela.Text = ((ttProduto.Rows(0)("preco_compra") - (ttProduto.Rows(0)("preco_compra") * (ttProduto.Rows(0)("desconto_compra") / 100))) +
                               (ttProduto.Rows(0)("preco_compra") - (ttProduto.Rows(0)("preco_compra") * (ttProduto.Rows(0)("desconto_compra") / 100))) * 0.15)
                'lblPrecoTabela.Text = ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) + _
                '(p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) * 0.15)
                lblDescontoTabela.Text = descavista
            End If

            If cliente.cod_tipo_cliente = 4 Then
                lblDescontoTabela.Text = Format(0.0, "##0.00")
            End If

            btnSalvarItem.Enabled = True
            btnSalvarItem.Focus()
            Exit Sub
        End If
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
                Dim f As New frmConsultaProduto
                f.strTela = "Consultar Produto"
                f.strLocalConsulta = "Produtos"
                f.ShowDialog()
                COD_PROD = f.cod_prod
                txtCodProd.Text = f.cod_prod
                'Novo
                prod.RetornaRegistro(COD_PROD)
                lentebloco.RetornaCodigoTabela(f.cod_lente)
                If tabelapromo.RetornaValorDesconto(lentebloco.CodigoTabela) = True Then
                    lblPrecoTabela.Text = String.Format("{0:##0.00}", tabelapromo.Valor)
                    lblProduto.Text = prod.ProdutoDescricao
                Else
                    lblProduto.Text = prod.ProdutoDescricao
                    lblPrecoTabela.Text = String.Format("{0:##0.00}", prod.PrecoTabela)
                End If
                'Fim Novo

                If cliente.cod_tipo_cliente = 2 Then
                    lblPrecoTabela.Text = ((ttProduto.Rows(0)("preco_compra") - (ttProduto.Rows(0)("preco_compra") * (ttProduto.Rows(0)("desconto_compra") / 100))) +
                               (ttProduto.Rows(0)("preco_compra") - (ttProduto.Rows(0)("preco_compra") * (ttProduto.Rows(0)("desconto_compra") / 100))) * 0.15)

                    lblDescontoTabela.Text = descavista
                End If

                If cliente.cod_tipo_cliente = 4 Then
                    lblDescontoTabela.Text = Format(0.0, "##0.00")
                End If

                btnSalvarItem.Enabled = True
                btnSalvarItem.Focus()
        End Select
    End Sub
    Private Sub btnSalvarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarItem.Click
        If cbForma.SelectedIndex = -1 Then
            MessageBox.Show("Por favor informe a forma de pagamento do cliente.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'instrução será executada somente no caso de pagamento a vista
        AplicaDescontoAvista()

        intUsuario = acesso.retorna_codigo_usuario(frmMain.intCodigoUsuario)

        If FaturaItens.VerificaPedidoFaturado(CInt(lblNpedido.Text), conf.Filial) = 0 Then
            'Procedimento 6: Inserir Item Pedido
            If Usu.VerificaPermissaoUsuario(6) = False Then
                MessageBox.Show("Usuário não tem permissão para inserir produtos no pedido!", "ERROR: 06", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'Caso o produto já existe apenas agrega a quantidade nova a já existente
            Dim strSQL As String = "select 1 from pedido_balcao_itens where num_pedido = " & pedido.num_pedido & " and id_filial = " & pedido.id_filial &
                " and cod_produto = " & CInt(txtCodProd.Text)
            If Conexao.VerificaExistenciaReg(strSQL) = 1 Then
                PedItem.QuantidadeAtualizada(lblNpedido.Text, lblFilial.Text, txtCodProd.Text, txtQuant.Text)

                'Caso exista pacote associado ao serviço a quantidade é atualizada
                Dim ttPacote As New DataTable
                ttPacote = acesso.lista_itens_com_saldo_pacote(intcodtabela, cliente.cod_cliente, cliente.cod_filial_cliente)

                If ttPacote.Rows.Count > 0 Then
                    If ttPacote.Rows(0)("cod_surf") > 0 Then
                        PedItem.QuantidadeAtualizadaServico(lblNpedido.Text, lblFilial.Text, ttPacote.Rows(0)("cod_surf"), txtQuant.Text)
                    End If

                    If ttPacote.Rows(0)("cod_mont") > 0 Then
                        PedItem.QuantidadeAtualizadaServico(lblNpedido.Text, lblFilial.Text, ttPacote.Rows(0)("cod_mont"), txtQuant.Text)
                    End If

                    If ttPacote.Rows(0)("cod_trat") > 0 Then
                        PedItem.QuantidadeAtualizadaServico(lblNpedido.Text, lblFilial.Text, ttPacote.Rows(0)("cod_trat"), txtQuant.Text)
                    End If
                End If
                carrega_itens(pedido.num_pedido, pedido.id_filial)
                Exit Sub
            End If

            intItem = pedido.item(pedido.num_pedido, pedido.id_filial)

            inserir_produtos(pedido.num_pedido, pedido.id_filial, txtCodProd.Text, txtQuant.Text)

            acesso.atualiza_forma_pagamento_pedido(CInt(cbForma.SelectedValue), CInt(lblNpedido.Text), CInt(lblFilial.Text))

            ''''

            'Fim instrução do cupom fiscal

            txtQuant.Text = 1
            txtCodProd.Text = ""
            lblProduto.Text = ""
            lblPrecoTabela.Text = ""
            'lblDescontoTabela.Text = ""
            chkLente.Checked = True
            txtCodProd.Focus()
            txtCodProd.Focus()
        Else
            MessageBox.Show("Não é possível adicionar item a pedido já faturado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub inserir_produtos(ByVal num_pedido As Integer, ByVal id_filial As Integer, ByVal intcod_prod As Integer, ByVal q As Integer)
        'Dim p As New produtoClass
        Dim i, m As Integer
        Dim status_item As Integer = 1
        Dim intTotalEstoque As Integer

        Dim strSQL As String = "Select * from produtos where cod_produto = " & CInt(txtCodProd.Text) & ""
        Dim ttProduto As New DataTable

        'Guarda os registros encontrados referente aos produtos
        ttProduto = acesso.retornaRegistro(strSQL).Tables(0)
        m = txtQuant.Text
        intTotalEstoque = acesso.saldo_estoque(ttProduto.Rows(0)("cod_produto"), conf.Filial)

        'Verifica se há saldo para o produto especificado

        If intTotalEstoque >= m Then
            i = 0
            Do While m > i
                status_item = 2 'Item reservado no estoque
                i = i + 1
            Loop
        Else
            If MessageBox.Show("Não há estoque para atender a sua solicitação! Solicitado: " & CInt(txtQuant.Text) & "; Disponível: " & intTotalEstoque & "." &
                            Chr(13) & "Deseja fazer pedido destes itens?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                status_item = 6 'Aguardando Pedido
            End If
        End If

        'Mexendo aqui em diante
        Dim ttPacote As New DataTable
        ttPacote = acesso.lista_itens_com_saldo_pacote(intcodtabela, cliente.cod_cliente, cliente.cod_filial_cliente)
        Dim valorcompra As Double = Format(ttProduto.Rows(0)("preco_compra") - (ttProduto.Rows(0)("preco_compra") * ttProduto.Rows(0)("desconto_compra") / 100), "#,##0.00")
        Dim valorpreco As Double
        Try
            valorpreco = Format(CDbl(lblPrecoTabela.Text) - (CDbl(lblPrecoTabela.Text) * CInt(lblDescontoTabela.Text) / 100), "#,##0.00")
        Catch ex As Exception
            valorpreco = Format(CDbl(lblPrecoTabela.Text), "#,##0.00")
        End Try


        If ttPacote.Rows.Count > 0 Then
            'Instrução responsável por verificar se existem débitos em aberto de pacote caso exista o produto do pacote não é colocado
            'Como de pacote e sim como um produto normal. 11/11/2014
            Dim strSQLCredito As String = ""
            If ttPacote.Rows(0)("cod_pacote_ant") = 0 Then
                strSQLCredito = "Select cod_credito from credito_pacote where cod_cliente = " & cliente.cod_cliente &
                    " and cod_filial_cliente = " & cliente.cod_filial_cliente & " and cod_pacote = " & ttPacote.Rows(0)("cod_pacote")
            Else
                strSQLCredito = "Select cod_credito from credito_pacote where cod_cliente = " & cliente.cod_cliente &
                    " and cod_filial_cliente = " & cliente.cod_filial_cliente & " and cod_pacote = " & ttPacote.Rows(0)("cod_pacote_ant")
            End If

            Dim tbCredito As New DataTable
            tbCredito = acesso.retornaRegistro(strSQLCredito).Tables(0)
            Dim strSQLCreditoLanc As String = "Select * From Pagamentos_Credito where cod_credito = " & tbCredito.Rows(0)("cod_credito") & " and id_filial = " & conf.Filial
            Dim tbCreditoLanc As New DataTable
            tbCreditoLanc = acesso.retornaRegistro(strSQLCreditoLanc).Tables(0)
            For Each linha As DataRow In tbCreditoLanc.Rows
                Dim strSQLLanc As String = "Select cod_lancamento, data_vencimento, data_recebimento from lancamentos where cod_lancamento = " & linha("cod_lancamento") &
                    " and id_filial = " & conf.Filial
                Dim tbLancamento As New DataTable
                tbLancamento = acesso.retornaRegistro(strSQLLanc).Tables(0)
                If (DateAdd(DateInterval.Day, 6, tbLancamento.Rows(0)("data_vencimento")) < Now) And tbLancamento.Rows(0)("data_recebimento") Is DBNull.Value Then
                    MessageBox.Show("Cliente não poderá usar item de pacote existente." & Chr(13) & "Débito em aberto referente ao pacote nº " & ttPacote.Rows(0)("cod_pacote"),
                                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GoTo s_pacote
                End If
            Next
            'Fim - 11/11/2014

            Dim strSQLPacote As String = "Select 1 From Pacote_cliente where cod_pacote = " & ttPacote.Rows(0)("cod_pacote") & " and cod_cliente = " & ttPacote.Rows(0)("cod_cliente") &
            " and concluido = 'S'"
            If acesso.verifica_existencia_registro(strSQLPacote) = True Then
                sql_item = "Insert into pedido_balcao_itens(num_pedido," &
                "id_filial,item,cod_produto,quant,compra,desconto,preco,cod_status_item,pacote,cod_pacote,preco_tab) " &
                "values(" & CInt(lblNpedido.Text) & "," & conf.Filial & "," & intItem & "," &
                COD_PROD & "," & q & "," & d.cdin(valorcompra) &
                "," & d.cdin(ttPacote.Rows(0)("desconto")) & "," &
                d.cdin(ttPacote.Rows(0)("preco_desc")) & "," & status_item &
                ",'S'," & ttPacote.Rows(0)("cod_pacote") & "," & d.cdin(ttPacote.Rows(0)("preco_tabela")) & ")"
                acesso.grava_registros(sql_item, True)


                If ttPacote.Rows(0)("cod_surf") > 0 Then
                    Dim strSQLPedido As String = "select 1 from pedido_balcao_servicos where num_pedido = " & CInt(lblNpedido.Text) &
                    " and id_filial = " & conf.Filial & " and cod_servico = " & ttPacote.Rows(0)("cod_surf")
                    If acesso.verifica_existencia_registro(strSQLPedido) = False Then
                        pedido.insere_servico(CInt(lblNpedido.Text), conf.Filial, ttPacote.Rows(0)("cod_surf"), q, ttPacote.Rows(0)("desc_surf"), ttPacote.Rows(0)("preco_surf_desc"), 1, ttPacote.Rows(0)("cod_pacote"), "S", ttPacote.Rows(0)("preco_tabela_surf"))
                    Else
                        acesso.atualiza_quantidade_itens_servico(lblNpedido.Text, lblFilial.Text, ttPacote.Rows(0)("cod_surf"), txtQuant.Text)
                    End If
                End If


                If ttPacote.Rows(0)("cod_mont") > 0 Then
                    Dim strSQLPedido As String = "select 1 from pedido_balcao_servicos where num_pedido = " & CInt(lblNpedido.Text) &
                    " and id_filial = " & conf.Filial & " and cod_servico = " & ttPacote.Rows(0)("cod_mont")
                    If acesso.verifica_existencia_registro(strSQLPedido) = False Then
                        pedido.insere_servico(CInt(lblNpedido.Text), conf.Filial, ttPacote.Rows(0)("cod_mont"), q, ttPacote.Rows(0)("desc_mont"), ttPacote.Rows(0)("preco_mont_desc"), 1, ttPacote.Rows(0)("cod_pacote"), "S", ttPacote.Rows(0)("preco_tabela_mont"))
                    Else
                        acesso.atualiza_quantidade_itens_servico(lblNpedido.Text, lblFilial.Text, ttPacote.Rows(0)("cod_mont"), txtQuant.Text)
                    End If
                End If

                If ttPacote.Rows(0)("cod_trat") > 0 Then
                    Dim strSQLPedido As String = "select 1 from pedido_balcao_servicos where num_pedido = " & CInt(lblNpedido.Text) &
                    " and id_filial = " & conf.Filial & " and cod_servico = " & ttPacote.Rows(0)("cod_trat")
                    If acesso.verifica_existencia_registro(strSQLPedido) = False Then
                        pedido.insere_servico(CInt(lblNpedido.Text), conf.Filial, ttPacote.Rows(0)("cod_trat"), q, ttPacote.Rows(0)("desc_trat"), ttPacote.Rows(0)("preco_trat_desc"), 1, ttPacote.Rows(0)("cod_pacote"), "S", ttPacote.Rows(0)("preco_tabela_trat"))
                    Else
                        acesso.atualiza_quantidade_itens_servico(lblNpedido.Text, lblFilial.Text, ttPacote.Rows(0)("cod_trat"), txtQuant.Text)
                    End If
                End If


            Else
                GoTo s_pacote
            End If
        Else
s_pacote:   sql_item = "Insert into pedido_balcao_itens (num_pedido," &
            "id_filial,item,cod_produto,quant,compra,desconto,preco,cod_status_item,preco_tab,preco_fat) " &
            "values(" & CInt(lblNpedido.Text) & "," & conf.Filial & "," & intItem & "," &
            COD_PROD & "," & q & "," & d.cdin(valorcompra) &
            "," & d.cdin((lblDescontoTabela.Text)) & "," &
            d.cdin(valorpreco) & "," & status_item &
            "," & d.cdin(lblPrecoTabela.Text) & "," &
            d.cdin(valorpreco) & ")"
            acesso.grava_registros(sql_item, True)
        End If
        carrega_itens(pedido.num_pedido, pedido.id_filial)
    End Sub

    Private Sub reserva(ByVal x_cod_prod As Integer, ByVal x_num_pedido As Integer)
        Dim sql_res As String
        Dim chave As Integer
        chave = retorna_Chave("id_reserva", "reserva_lente_pedido", " where id_filial = " & conf.Filial & "")
        sql_res = "Insert into reserva_lente_pedido(id_reserva,id_filial,num_pedido,cod_produto," &
        "id_status_reserva,data_reserva) values(" &
        chave & "," & conf.Filial & "," & x_num_pedido & "," & x_cod_prod &
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
        intUsuario = acesso.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim item As Integer

        If pedido.os(pedido.num_pedido, pedido.id_filial) > 0 Or pedido.faturado = True Then
            If MessageBox.Show("Deseja excluir o(s) produto(s)?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If acesso.verifica_permissao_usuario(intUsuario, 33) = True Then
                    GoTo delete
                Else
                    MessageBox.Show("Usuário não tem autorização para excluir produtos.", "ERROR: 33", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            MessageBox.Show("Este é um pedido gerado por uma OS e não pode ser alterado!", "INFORMAÇÃO", MessageBoxButtons.OK)
            Exit Sub
        Else
delete:
            item = grdProd.CurrentRow.Cells(0).Value
            pedido.deleta_item(pedido.num_pedido, pedido.id_filial, item)

        End If

        carrega_itens(pedido.num_pedido, pedido.id_filial)
        formata_grid_itens()
        MessageBox.Show("Item excluído com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub mniAtualizaPreco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniAtualizaPreco.Click
        Dim item As Integer
        Dim i As Integer = 0
        Dim res As String
        Dim desconto As Double = 0.0
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
            desconto = grdProd.CurrentRow.Cells(4).Value
            prod.filtra(pedido.retorna_cod_item(item))
            res = res & vbCrLf & pedido.altera_preco_item(item, prod.preco_tabela, desconto)
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
        Dim strSQL As String = "INSERT INTO NOTA (NUMERO,ALMOX, CLIENTE, VENDEDOR, FORMA, DATA,P_DESCONTO,DESCONTO,TIPO_DOCUMENTO, SITUACAO) " &
            "VALUES(" & pedido.num_pedido & "," & pedido.id_filial & "," & pedido.cod_cliente & "," & pedido.cod_vendedor & "," &
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
        Exit Sub
        Dim valor As Double = CDbl(lblPrecoTabela.Text) - (CDbl(lblPrecoTabela.Text) * CDbl(lblDescontoTabela.Text) / 100)
        Dim strSQL As String = "INSERT INTO I_NOTA (NUMERO,ITEM, PRODUTO, UNIDADE,QUANTIDADE, VALOR, DESCONTO) " &
            "VALUES(" & pedido.num_pedido & "," & intItem & "," & CInt(txtCodProd.Text) & "," & "'UN'" & "," & CInt(txtQuant.Text) & "," &
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
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            dn.desconecta()
        End Try
    End Sub

    'Atualzia o valor do cupom dentro da tabela Nota do Bazar 7
    Private Sub atualizaValorCupom()
        Dim valor As Double = CDbl(lblTotProd.Text)
        Dim strSQL As String = "UPDATE NOTA SET VALOR = " & valor.ToString.Replace(",", ".") & " WHERE NUMERO = " & pedido.num_pedido &
            " AND ALMOX = " & conf.Filial & ""
        Try
            dn.conecta()
            Dim cmd As New SqlCommand(strSQL, dn.con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(ex.ToString)
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

        Dim strSQL As String = "INSERT INTO PRODUTO (CODIGO,DESCRICAO, CLASSE, GRUPO, SUBGRUPO, MARCA, FABRICANTE, UNIDADE, CONTROLADO, CODIGOTRIBUTACAO, VENDA, SERIE, COR) " &
            "VALUES(" & CInt(txtCodProd.Text) & ",'" & strProduto & "'," & 1 & "," & 1 & "," & 1 & "," & 1 & "," & 1 & "," & "'UN'" & ",'" & False & "'," & 0 & "," &
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

        Dim strSQL As String = "INSERT INTO CLIENTE (CODIGO, RAZAOSOCIAL, FANTASIA, ENDERECO, NUMERO, T_INSCRICAO, CNPJ_CPF) " &
            "VALUES(" & pedido.cod_cliente & ",'" & strRazao & "','" & strNome & "','" &
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
        'If strOS = "S" Then
        'If cbForma.SelectedValue = 0 Then
        'Box.Show("Escolher uma forma de pagamento antes de fechar a janela?", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'e.Cancel = True
        'End If
        'End If

        'If conf.Filial = 1 Then
        'atualizaValorCupom()
        'End If
    End Sub


    Private Sub txtVendedorExterno_Leave(sender As System.Object, e As System.EventArgs) Handles txtVendedorExterno.Leave
        If txtVendedorExterno.Text = "" Then
            txtVendedorExterno.Text = 0
        End If
        If CInt(txtVendedorExterno.Text) > 0 Then
            Dim strSQL As String = "cod_vendedor_ext = " & CInt(txtVendedorExterno.Text) & " where num_pedido = " & CInt(lblNpedido.Text) & " and id_filial = " & CInt(lblFilial.Text)
            acesso.atualiza_registros("pedido_balcao", strSQL, True)
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
        Dim strSQLForma As String = "SELECT FORMA FROM PEDIDO_BALCAO WHERE NUM_PEDIDO = " & CInt(lblNpedido.Text) &
        " AND ID_FILIAL = " & CInt(lblFilial.Text)
        Dim ttFormaPag As New DataTable
        ttFormaPag = acesso.retornaRegistro(strSQLForma).Tables(0)
        If Not ttFormaPag.Rows(0)("Forma") Is DBNull.Value Then
            Return ttFormaPag.Rows(0)("Forma")
        End If
    End Function



    Private Sub btnSalvarServico_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvarServico.Click
        If cbForma.SelectedIndex = -1 Then
            MessageBox.Show("Por favor informe a forma de pagamento do cliente.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If acesso.verifica_pedido_faturado(CInt(lblNpedido.Text), conf.Filial) = 0 Then
            If pedido.os(pedido.num_pedido, pedido.id_filial) > 0 And UserID <> 1 Then
                AVISO("Este é um pedido gerado por uma OS e não pode ser alterado!", Me, frmAviso.tipo_aviso.tipo_ok)
                Exit Sub
            Else
                p.Source("Select * from produtos where cod_produto = " & cbServicos.SelectedValue & "")

                'Caso o serviço já existe apenas agrega a quantidade nova a já existente
                Dim strSQL As String = "select 1 from pedido_balcao_servicos where num_pedido = " & pedido.num_pedido & " and id_filial = " & pedido.id_filial &
                " and cod_servico = " & p.fldCod_produto

                If acesso.verifica_existencia_registro(strSQL) = True Then
                    acesso.atualiza_quantidade_itens_servico(lblNpedido.Text, lblFilial.Text, p.fldCod_produto, txtQuant.Text)
                Else
                    pedido.insere_servico(pedido.num_pedido, pedido.id_filial, p.fldCod_produto, txtQuantServ.Text, p.fldDesconto, p.fldPreco_venda, 1, 0, Nothing, p.fldPreco_venda)
                End If

                'pedido.insere_servico(pedido.num_pedido, pedido.id_filial, p.fldCod_produto, txtQuantServ.Text, p.fldDesconto, p.fldPreco_venda, 1, 0, Nothing, p.fldPreco_venda)

                acesso.atualiza_forma_pagamento_pedido(CInt(cbForma.SelectedValue), CInt(lblNpedido.Text), CInt(lblFilial.Text))
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
        Dim strSQL As String = "select sum(valor) as valor from autorizacao where cod_cliente = " & pedido.cod_cliente &
        " and cod_filial_cliente = " & pedido.id_filial & " and data = " & d.Pdt(Now) & " and data_uso is null"
        Dim ttPedido As New DataTable
        ttPedido = acesso.retornaRegistro(strSQL).Tables(0)

        If grdProd.Rows.Count = 0 Then
            'valorpedido = valorpedido + (CDbl(lblPrecoTabela.Text) - (CDbl(lblPrecoTabela.Text) * CDbl(lblDescontoTabela.Text) / 100)) * CInt(txtQuant.Text)
        End If

        If grdProd.Rows.Count > 0 Then
            For Each linha As DataGridViewRow In grdProd.Rows
                If linha.Cells(8).Value Is DBNull.Value Then
                    lblPrecoTabela.Text = 0
                    lblDescontoTabela.Text = 0
                    txtQuant.Text = 1
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

    Private Sub atualizaStatusDesconto(ByVal status As Char)
        strSQLAtauliza = "desconto = '" & status & "' where num_pedido = " & CInt(lblNpedido.Text) & " and id_filial = " & CInt(lblFilial.Text)
        acesso.atualiza_registros("pedido_balcao", strSQLAtauliza, True)
    End Sub

    Private Sub cbForma_Leave(sender As System.Object, e As System.EventArgs) Handles cbForma.Leave
        'Busca o desconto de venda a vista para se aplciado na hora da venda
        Dim strSQL As String = "select desconto_venda_vista from controle"
        Dim strSQLAtauliza As String = ""
        Dim tt As New DataTable
        tt = acesso.retornaRegistro(strSQL).Tables(0)

        'instrução será executada somente no caso de pagamento a vista
        AplicaDescontoAvista()

        'Instrução responsável por pegar a data referente ao desconto de avista para não influenciar em descontos anteriores em caso de abertura
        'de um pedido para verificação com desconto anterior a data cadastrada
        Dim strSQLData As String = "select data_desc_vista from controle"
        Dim ttData As New DataTable
        ttData = acesso.retornaRegistro(strSQLData).Tables(0)

        Dim preco As Double

        'Se a data do desconto avista for menor que a data do pedido ele atualiza a forma de pagamento do pedido
        'E verifica em seguida se há item vinculada ao pedido em caso positivo trabalha a alteração do desconto em cada item
        If ttData.Rows(0)("data_desc_vista") < pedido.data_pedido Then
            If grdProd.Rows.Count > 0 Then
                For Each linha As DataGridViewRow In grdProd.Rows
                    If linha.Cells(9).Value Is DBNull.Value Then
                        Dim strSQLProd As String = "Select * from produtos where cod_produto = " & CInt(linha.Cells(10).Value) & ""
                        ttProdutoPreco = acesso.retornaRegistro(strSQLProd).Tables(0)
                        preco = ttProdutoPreco.Rows(0)("preco_tabela")
                        acesso.atualiza_preco_desconto_pedido(CInt(lblNpedido.Text), CInt(lblFilial.Text), descavista, linha.Cells(0).Value, preco)
                        acesso.atualiza_forma_pagamento_pedido(CInt(cbForma.SelectedValue), CInt(lblNpedido.Text), CInt(lblFilial.Text))
                    Else
                        acesso.atualiza_forma_pagamento_pedido(CInt(cbForma.SelectedValue), CInt(lblNpedido.Text), CInt(lblFilial.Text))
                    End If
                Next
            End If
        Else
            acesso.atualiza_forma_pagamento_pedido(CInt(cbForma.SelectedValue), CInt(lblNpedido.Text), CInt(lblFilial.Text))
        End If
        carrega_itens(pedido.num_pedido, pedido.id_filial)
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Me.Cursor = Cursors.AppStarting
        'Dim r As New rptPedido
        Dim r As New rptPedidoBalcao2vias
        Dim f As New frmRpt
        Dim eco As String = ""
        Dim tt As New DataTable
        Dim strSQL As String = "SELECT CIDADE, UF FROM CIDADES WHERE CODIGO = " & cliente.cod_cidade
        tt = acesso.retornaRegistro(strSQL).Tables(0)

        If pedido.diferenca_desconto > 0 Then
            eco = "VOCÊ ECONOMIZOU " & Format(pedido.diferenca_desconto, "#,##0.00") & " EM DESCONTOS!"
        End If
        r.r.filial = pedido.id_filial
        r.r2.filial = pedido.id_filial
        r.r3.filial = pedido.id_filial
        r.r.TextBox1.Text = "Cidade/UF: " & tt.Rows(0)("Cidade").ToString & " - " & tt.Rows(0)("UF").ToString
        r.r2.TextBox1.Text = "Cidade/UF: " & tt.Rows(0)("Cidade").ToString & " - " & tt.Rows(0)("UF").ToString
        r.r3.TextBox1.Text = "Cidade/UF: " & tt.Rows(0)("Cidade").ToString & " - " & tt.Rows(0)("UF").ToString
        r.r.data = pedido.data_pedido
        r.r2.data = pedido.data_pedido
        r.r3.data = pedido.data_pedido
        r.r.tbItens = tb_itens
        r.r2.tbItens = tb_itens
        r.r3.tbItens = tb_itens
        r.r.tbServ = tb_servico
        r.r2.tbServ = tb_servico
        r.r3.tbServ = tb_servico
        r.r.cliente = lblCliente.Text
        r.r2.cliente = lblCliente.Text
        r.r3.cliente = lblCliente.Text
        r.r.n_pedido = pedido.num_pedido
        r.r2.n_pedido = pedido.num_pedido
        r.r3.n_pedido = pedido.num_pedido
        r.r.Vendedor = lblVendedor.Text
        r.r2.Vendedor = lblVendedor.Text
        r.r3.Vendedor = lblVendedor.Text
        r.r.cod_cliente = pedido.cod_cliente
        r.r2.cod_cliente = pedido.cod_cliente
        r.r3.cod_cliente = pedido.cod_cliente
        r.r.Total = lblTotal.Text
        r.r2.Total = lblTotal.Text
        r.r3.Total = lblTotal.Text
        r.r.Barcode1.Text = pedido.cod_filial_cliente.ToString.PadLeft(2, "0") & pedido.cod_cliente.ToString.PadLeft(5, "0") & pedido.num_pedido.ToString.PadLeft(7, "0")
        r.r2.Barcode1.Text = pedido.cod_filial_cliente.ToString.PadLeft(2, "0") & pedido.cod_cliente.ToString.PadLeft(5, "0") & pedido.num_pedido.ToString.PadLeft(7, "0")
        r.r3.Barcode1.Text = pedido.cod_filial_cliente.ToString.PadLeft(2, "0") & pedido.cod_cliente.ToString.PadLeft(5, "0") & pedido.num_pedido.ToString.PadLeft(7, "0")

        Dim strSQLForma As String = "select descricao from tipo_compra where codigo = " & cbForma.SelectedValue
        Dim ttForma As New DataTable
        ttForma = acesso.retornaRegistro(strSQLForma).Tables(0)

        If ttForma.Rows.Count > 0 Then
            r.r.TextBox2.Text = ttForma.Rows(0)("descricao")
            r.r2.TextBox2.Text = ttForma.Rows(0)("descricao")
            r.r3.TextBox2.Text = ttForma.Rows(0)("descricao")
        Else
            r.r.TextBox2.Text = "Não Informado."
            r.r2.TextBox2.Text = "Não Informado."
            r.r3.TextBox2.Text = "Não Informado."
        End If

        r.data = pedido.data_pedido
        r.cliente = lblCliente.Text
        r.n_pedido = pedido.num_pedido
        r.Vendedor = lblVendedor.Text
        r.cod_cliente = pedido.cod_cliente
        r.Total = lblTotal.Text
        r.Serv = Format(pedido.total_servicos, "#,##0.00")
        r.Prod = Format(pedido.total_itens, "#,##0.00")

        If pedido.total_prod_desc(CInt(lblNpedido.Text), CInt(lblFilial.Text)) > 0 Then
            Dim prod As Double = pedido.total_prod_desc(CInt(lblNpedido.Text), CInt(lblFilial.Text))
            Dim serv As Double = pedido.total_serv_desc(CInt(lblNpedido.Text), CInt(lblFilial.Text))
            Dim total As Double = Format(prod - serv, "#,##0.00")
            r.r.lblEconomia.Text = "VOCÊ ECONOMIZOU " & total & " EM DESCONTO."
            r.r2.lblEconomia.Text = "VOCÊ ECONOMIZOU " & total & " EM DESCONTO."
            r.r3.lblEconomia.Text = "VOCÊ ECONOMIZOU " & total & " EM DESCONTO."
        End If

        f.Relat(r)
        Me.Cursor = Cursors.Default
        f.Show()
    End Sub


    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Cursor = Cursors.AppStarting
        Dim r As New rptPedido
        Dim f As New frmRpt
        Dim eco As String = ""
        Dim tt As New DataTable
        Dim strSQL As String = "SELECT CIDADE, UF FROM CIDADES WHERE CODIGO = " & cliente.cod_cidade
        tt = acesso.retornaRegistro(strSQL).Tables(0)
        If pedido.diferenca_desconto > 0 Then
            eco = "VOCÊ ECONOMIZOU " & Format(pedido.diferenca_desconto, "#,##0.00") & " EM DESCONTOS!"
        End If
        r.filial = pedido.id_filial
        r.data = pedido.data_pedido
        r.cliente = lblCliente.Text
        r.n_pedido = pedido.num_pedido
        r.TextBox1.Text = "Cidade/UF: " & tt.Rows(0)("Cidade").ToString & " - " & tt.Rows(0)("UF").ToString
        r.Vendedor = lblVendedor.Text
        r.Barcode1.Text = pedido.cod_filial_cliente & " " & pedido.cod_cliente & " " & pedido.num_pedido

        Dim strSQLForma As String = "select descricao from tipo_compra where codigo = " & pedido.forma_pagamento
        Dim ttForma As New DataTable
        ttForma = acesso.retornaRegistro(strSQLForma).Tables(0)

        If ttForma.Rows.Count > 0 Then
            r.TextBox2.Text = ttForma.Rows(0)("descricao")
        Else
            r.TextBox2.Text = "Não Informado."
        End If

        r.tbItens = tb_itens
        r.tbServ = tb_servico
        r.cod_cliente = pedido.cod_cliente
        r.Total = lblTotal.Text
        f.Relat(r)
        Me.Cursor = Cursors.Default
        f.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
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

    Private Sub btnCancelarPedido_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelarPedido.Click
        If MessageBox.Show("Deseja cancelar este pedido?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim strSQL As String = "cod_status_pedido = 4 where num_pedido = " & pedido.num_pedido & " and id_filial = " & pedido.id_filial
            acesso.atualiza_registros("pedido_balcao", strSQL, True)

            Dim strSQLItem As String = "cod_status_item = 4 where num_pedido = " & pedido.num_pedido & " and id_filial = " & pedido.id_filial
            acesso.atualiza_registros("pedido_balcao_itens", strSQLItem, True)

            Dim strSQLItemServ As String = "cod_status_servico = 2 where num_pedido = " & pedido.num_pedido & " and id_filial = " & pedido.id_filial
            acesso.atualiza_registros("pedido_balcao_servicos", strSQLItemServ, True)

            MessageBox.Show("Pedido Nº " & pedido.num_pedido & " cancelado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)

            desativaControle()
        End If
    End Sub

    Private Sub PreçoManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreçoManualToolStripMenuItem.Click
        Dim item As Integer
        Dim i As Integer = 0
        Dim res As String
        Dim desconto As Double = 0.0
        Dim prod As New produtoClass
        Dim user As New objUsuario
        If user.login(Me).StartsWith("OK") Then
            'Procedimento 58 Alterar o preço do produto manualmente
            If user.acesso(58) = False Then
                AVISO("Usuário não tem permissão para atualizar preço!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                Exit Sub
            End If
            item = grdProd.CurrentRow.Cells(0).Value
            desconto = grdProd.CurrentRow.Cells(4).Value
            prod.filtra(pedido.retorna_cod_item(item))
            res = res & vbCrLf & pedido.altera_preco_item(item, InputBox("Digite o valor da lente"), InputBox("Digite o % de desconto"))
        End If

        carrega_itens(pedido.num_pedido, pedido.id_filial)
        formata_grid_itens()
        MsgBox("Concluido!")

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim item As Integer
        Dim i As Integer = 0
        Dim res As String
        Dim desconto As Double = 0.0
        Dim preco As Double = 0.0
        Dim prod As New produtoClass
        Dim user As New objUsuario
        If user.login(Me).StartsWith("OK") Then
            'Procedimento 58 Alterar o preço do produto manualmente
            If user.acesso(58) = False Then
                AVISO("Usuário não tem permissão para atualizar preço!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                Exit Sub
            End If
            item = grdServico.CurrentRow.Cells(0).Value
            desconto = grdServico.CurrentRow.Cells(4).Value
            preco = grdServico.CurrentRow.Cells(3).Value
            prod.filtra(grdServico.CurrentRow.Cells(10).Value)
            res = res & vbCrLf & pedido.altera_preco_servico(item, InputBox("Digite o valor do serviço", "Valor", preco), InputBox("Digite o % de desconto"))



        End If

        carrega_itens(pedido.num_pedido, pedido.id_filial)
        formata_grid_Servicos()
        MsgBox("Concluido!")

    End Sub


    Private Sub desativaControle()
        Dim strSQL As String = "Select cod_status_pedido From pedido_balcao where num_pedido = " & pedido.num_pedido & " and id_filial = " & pedido.id_filial
        Dim tt As New DataTable
        tt = acesso.retornaRegistro(strSQL).Tables(0)

        If (tt.Rows(0)("cod_status_pedido") = 2) Or (tt.Rows(0)("cod_status_pedido") = 3) Or (tt.Rows(0)("cod_status_pedido") = 4) Or (tt.Rows(0)("cod_status_pedido") = 6) Then
            cbForma.Enabled = False
            txtVendedorExterno.Enabled = False
            txtQuant.Enabled = False
            txtCodProd.Enabled = False
            btnSalvarItem.Enabled = False
            btnExcluirProd.Enabled = False
            cbServicos.Enabled = False
            txtQuantServ.Enabled = False
            btnSalvarServico.Enabled = False
            btnExcluirServico.Enabled = False
            chkLente.Enabled = False
            mnuProdutos.Enabled = False
            btnImprimir.Enabled = True
            ToolStripButton2.Enabled = True
            ToolStripButton3.Enabled = False
            btnCancelarPedido.Enabled = False
        End If
    End Sub

    Private Sub AlterarPreçoProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarPreçoProdutoToolStripMenuItem.Click
        Dim item As Integer
        Dim valor As Decimal = 0.0
        Dim codProduto As Integer
        Dim user As New objUsuario
        If user.login(Me).StartsWith("OK") Then
            'Procedimento 29 atualiza o preço do item de acordo com 
            'o valor cadastrado na tabela
            If user.acesso(29) = False Then
                AVISO("Usuário não tem permissão para atualizar preço!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                Exit Sub
            End If
            item = grdProd.CurrentRow.Cells(0).Value
            codProduto = grdProd.CurrentRow.Cells(9).Value
            valor = InputBox("Informe o novo valor", "Altera valor", "")
            PedItem.AtualizaPrecoItem(pedido.num_pedido, pedido.id_filial, item, codProduto, valor)
        End If

        carrega_itens(pedido.num_pedido, pedido.id_filial)
        formata_grid_itens()
        MsgBox("Concluido!")
    End Sub

    Private Sub AplicaDescontoAvista()
        Dim tt As New DataTable
        Dim strSQLDesc As String = "select desconto_venda_vista from controle"
        tt = acesso.retornaRegistro(strSQLDesc).Tables(0)
        If (cbForma.SelectedValue = 1) Or (cbForma.SelectedValue = 3) Or (cbForma.SelectedValue = 4) Or (cbForma.SelectedValue = 5) Then
            descavista = tt.Rows(0)("desconto_venda_vista")
            atualizaStatusDesconto("S")
            lblDescontoTabela.Text = String.Format("{0:#0.00}", descavista)
        Else
            lblDescontoTabela.Text = Format(CDbl(0.0), "##0.00")
            descavista = 0
            atualizaStatusDesconto("N")
        End If
    End Sub


End Class


Public Structure Item
    Dim item As Integer
    Dim nome As String
    Dim quant As Integer
    Dim vunit As Integer
    Dim desc As Double
    Dim pct As Object
    Dim cod_produto As Integer
End Structure