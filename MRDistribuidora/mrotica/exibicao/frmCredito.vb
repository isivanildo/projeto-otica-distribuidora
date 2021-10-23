Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmCredito

    Dim tbfatura As New DataTable
    Dim d As New dados
    Dim conf As New config
    Public intAbrePedido As Integer
    Dim creditoObj As New objMaster
    Dim intUsuario As Integer
    Dim estoque As New objEntradaNota
    Dim ttPedidoInfo As New DataTable
    Dim valorCreditoProd As Double
    Dim valorCreditoServ As Double
    Dim valorCredito As Double

    Private Sub frmFatura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostraCabecalhoPedido()
        mostraPedido()
        mostraServico()

        Dim strSQL As String = "select 1 from pedido_balcao where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial") & _
            " and cod_status_pedido = 6"
        If creditoObj.verifica_existencia_registro(strSQL) = True Then
            GroupBox1.Enabled = False
            btnEstornar.Enabled = False
            grdPedido.ReadOnly = True
            grdServico.ReadOnly = True
        End If
    End Sub

    Private Sub mostraPedido()
        grdPedido.Columns.Clear()
        grdPedido.DataSource = Nothing
        grdPedido.AutoGenerateColumns = False
        grdPedido.AllowUserToAddRows = False

        Dim strSQL As String = ""
        strSQL = "select pedido_balcao_itens.num_pedido, pedido_balcao_itens.id_filial, pedido_balcao_itens.item, pedido_balcao_itens.cod_produto, " & _
            "pedido_balcao_itens.quant, pedido_balcao_itens.compra, pedido_balcao_itens.desconto, pedido_balcao_itens.preco_tab, " & _
            "pedido_balcao_itens.preco, isnull(pedido_balcao_itens.preco * pedido_balcao_itens.quant ,0) as total, " & _
            "pedido_balcao_itens.cod_status_item, pedido_balcao_itens.Pacote, pedido_balcao_itens.cod_pacote, pedido_balcao_itens.desc_caixa, " & _
            "produtos.produto, status_item_pedido.status_item, pedido_balcao_itens.usuario_can, pedido_balcao_itens.tipo_devolucao, " & _
            "pedido_balcao_itens.devolvido_estoque, pedido_balcao_itens.data_devolucao from pedido_balcao_itens inner join produtos on " & _
            "pedido_balcao_itens.cod_produto = produtos.cod_produto inner join status_item_pedido on " & _
            "status_item_pedido.cod_status_item = pedido_balcao_itens.cod_status_item " & _
            "where pedido_balcao_itens.num_pedido = " & intAbrePedido & " And pedido_balcao_itens.id_filial = " & conf.Filial

        Dim ttPedidoProduto As New DataTable
        ttPedidoProduto = creditoObj.retornaRegistro(strSQL).Tables(0)

        Try
            Dim Selecionar As New DataGridViewCheckBoxColumn 'Posição 00
            Selecionar.HeaderText = "Sel."
            Selecionar.Width = 40
            grdPedido.Columns.Add(Selecionar)

            Dim produto As New DataGridViewTextBoxColumn 'Posição 01
            produto.HeaderText = "Produto"
            produto.DataPropertyName = "produto"
            produto.Width = 380
            grdPedido.Columns.Add(produto)

            Dim quant As New DataGridViewTextBoxColumn 'Posição 02
            quant.HeaderText = "Quant."
            quant.DataPropertyName = "Quant"
            quant.Width = 50
            quant.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grdPedido.Columns.Add(quant)

            Dim precotab As New DataGridViewTextBoxColumn 'Posição 03
            precotab.HeaderText = "Preço Tab."
            precotab.DataPropertyName = "preco_tab"
            precotab.DefaultCellStyle.Format = "#,##0.00"
            precotab.Width = 85
            precotab.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grdPedido.Columns.Add(precotab)

            Dim desc As New DataGridViewTextBoxColumn 'Posição 04
            desc.HeaderText = "Desc. %"
            desc.DataPropertyName = "desconto"
            desc.DefaultCellStyle.Format = "#,##0.00"
            desc.Width = 70
            desc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grdPedido.Columns.Add(desc)

            Dim precounit As New DataGridViewTextBoxColumn 'Posição 05
            precounit.HeaderText = "P. Unit"
            precounit.DataPropertyName = "preco"
            precounit.DefaultCellStyle.Format = "#,##0.00"
            precounit.Width = 80
            precounit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grdPedido.Columns.Add(precounit)

            Dim valorpago As New DataGridViewTextBoxColumn 'Posição 06
            valorpago.HeaderText = "Total"
            valorpago.DataPropertyName = "total"
            valorpago.DefaultCellStyle.Format = "#,##0.00"
            valorpago.Width = 80
            valorpago.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grdPedido.Columns.Add(valorpago)

            Dim desccaixa As New DataGridViewTextBoxColumn 'Posição 07
            desccaixa.HeaderText = "Desc. Caixa"
            desccaixa.DataPropertyName = "desc_caixa"
            desccaixa.DefaultCellStyle.Format = "#,##0.00"
            desccaixa.Width = 90
            desccaixa.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grdPedido.Columns.Add(desccaixa)

            Dim status As New DataGridViewTextBoxColumn 'Posição 08
            status.HeaderText = "Status Item"
            status.DataPropertyName = "Status_Item"
            status.Width = 110
            grdPedido.Columns.Add(status)

            Dim codproduto As New DataGridViewTextBoxColumn 'Posição 09
            codproduto.HeaderText = "Cod. Produto"
            codproduto.DataPropertyName = "cod_produto"
            codproduto.Width = 50
            codproduto.Visible = False
            grdPedido.Columns.Add(codproduto)

            Dim item As New DataGridViewTextBoxColumn 'Posição 10
            item.HeaderText = "Item"
            item.DataPropertyName = "item"
            item.Width = 50
            item.Visible = False
            grdPedido.Columns.Add(item)

            Dim numpedido As New DataGridViewTextBoxColumn 'Posição 11
            numpedido.HeaderText = "Pedido"
            numpedido.DataPropertyName = "num_pedido"
            numpedido.Width = 50
            numpedido.Visible = False
            grdPedido.Columns.Add(numpedido)

            Dim statusitem As New DataGridViewTextBoxColumn 'Posição 12
            statusitem.HeaderText = "Cod. Status Item"
            statusitem.DataPropertyName = "cod_status_item"
            statusitem.Width = 20
            statusitem.Visible = False
            grdPedido.Columns.Add(statusitem)

            Dim pacote As New DataGridViewTextBoxColumn 'Posição 13
            pacote.HeaderText = "Pacote"
            pacote.DataPropertyName = "cod_pacote"
            pacote.Width = 50
            pacote.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            pacote.Visible = True
            grdPedido.Columns.Add(pacote)

            Dim idfilial As New DataGridViewTextBoxColumn 'Posição 14
            idfilial.HeaderText = "Filial"
            idfilial.DataPropertyName = "id_filial"
            idfilial.Width = 10
            idfilial.Visible = False
            grdPedido.Columns.Add(idfilial)

            grdPedido.DataSource = ttPedidoProduto

            For Each linha As DataGridViewRow In grdPedido.Rows
                If linha.Cells(12).Value = 4 Or linha.Cells(12).Value = 5 Then
                    linha.Cells(0).Value = True
                    btnComprovante.Enabled = True
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub mostraServico()
        grdServico.Columns.Clear()
        grdServico.DataSource = Nothing
        grdServico.AutoGenerateColumns = False
        grdServico.AllowUserToAddRows = False


        Dim strSQL As String = "select pedido_balcao_servicos.num_pedido, pedido_balcao_servicos.id_filial, pedido_balcao_servicos.item_servico, " & _
            "pedido_balcao_servicos.cod_servico, pedido_balcao_servicos.quant, pedido_balcao_servicos.compra, pedido_balcao_servicos.desconto, " & _
            "pedido_balcao_servicos.preco_tab, pedido_balcao_servicos.preco, isnull(pedido_balcao_servicos.preco * pedido_balcao_servicos.quant ,0) as total, " & _
            "pedido_balcao_servicos.cod_status_servico, pedido_balcao_servicos.Pacote, pedido_balcao_servicos.cod_pacote, " & _
            "pedido_balcao_servicos.desc_caixa, produtos.produto, status_servico_pedido.status_servico, pedido_balcao_servicos.usuario_can, " & _
            "pedido_balcao_servicos.tipo_devolucao, pedido_balcao_servicos.devolvido_estoque, pedido_balcao_servicos.data_devolucao from " & _
            "pedido_balcao_servicos inner join produtos on pedido_balcao_servicos.cod_servico = produtos.cod_produto inner join status_servico_pedido on " & _
            "status_servico_pedido.cod_status_servico = pedido_balcao_servicos.cod_status_servico where " & _
            "pedido_balcao_servicos.num_pedido = " & intAbrePedido & " And pedido_balcao_servicos.id_filial = " & conf.Filial


        Dim ttServico As New DataTable
        ttServico = creditoObj.retornaRegistro(strSQL).Tables(0)

        Try

            Dim Selecionar As New DataGridViewCheckBoxColumn 'Posição 00
            Selecionar.HeaderText = "Sel."
            Selecionar.Width = 40
            grdServico.Columns.Add(Selecionar)

            Dim produto As New DataGridViewTextBoxColumn 'Posição 01
            produto.HeaderText = "Produto"
            produto.DataPropertyName = "produto"
            produto.Width = 380
            grdServico.Columns.Add(produto)

            Dim quant As New DataGridViewTextBoxColumn 'Posição 02
            quant.HeaderText = "Quant."
            quant.DataPropertyName = "Quant"
            quant.Width = 50
            quant.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grdServico.Columns.Add(quant)

            Dim preco As New DataGridViewTextBoxColumn 'Posição 03
            preco.HeaderText = "Preço Tab"
            preco.DataPropertyName = "preco_tab"
            preco.DefaultCellStyle.Format = "#,##0.00"
            preco.Width = 85
            preco.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grdServico.Columns.Add(preco)

            Dim desconto As New DataGridViewTextBoxColumn 'Posição 04
            desconto.HeaderText = "Desc. %"
            desconto.DataPropertyName = "desc_caixa"
            desconto.DefaultCellStyle.Format = "#,##0.00"
            desconto.Width = 70
            desconto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grdServico.Columns.Add(desconto)

            Dim precounit As New DataGridViewTextBoxColumn 'Posição 05
            precounit.HeaderText = "P. Unit"
            precounit.DataPropertyName = "preco"
            precounit.DefaultCellStyle.Format = "#,##0.00"
            precounit.Width = 80
            precounit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grdServico.Columns.Add(precounit)

            Dim total As New DataGridViewTextBoxColumn 'Posição 06
            total.HeaderText = "Total"
            total.DataPropertyName = "total"
            total.DefaultCellStyle.Format = "#,##0.00"
            total.Width = 80
            total.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grdServico.Columns.Add(total)

            Dim desccaixa As New DataGridViewTextBoxColumn 'Posição 07
            desccaixa.HeaderText = "Desc. Caixa"
            desccaixa.DataPropertyName = "desc_caixa"
            desccaixa.DefaultCellStyle.Format = "#,##0.00"
            desccaixa.Width = 90
            desccaixa.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grdServico.Columns.Add(desccaixa)

            Dim codstatusserv As New DataGridViewTextBoxColumn 'Posição 08
            codstatusserv.HeaderText = "Cod. Status"
            codstatusserv.DataPropertyName = "cod_status_servico"
            codstatusserv.Visible = False
            grdServico.Columns.Add(codstatusserv)

            Dim statusserv As New DataGridViewTextBoxColumn 'Posição 09
            statusserv.HeaderText = "Status Serviço"
            statusserv.DataPropertyName = "status_servico"
            statusserv.Width = 110
            grdServico.Columns.Add(statusserv)

            Dim item As New DataGridViewTextBoxColumn 'Posição 10
            item.HeaderText = "Item"
            item.DataPropertyName = "item_servico"
            item.Width = 50
            item.Visible = False
            grdServico.Columns.Add(item)

            Dim numpedido As New DataGridViewTextBoxColumn 'Posição 11
            numpedido.HeaderText = "Pedido"
            numpedido.DataPropertyName = "num_pedido"
            numpedido.Width = 50
            numpedido.Visible = False
            grdServico.Columns.Add(numpedido)

            Dim pacote As New DataGridViewTextBoxColumn 'Posição 12
            pacote.HeaderText = "Pacote"
            pacote.DataPropertyName = "cod_pacote"
            pacote.Width = 50
            pacote.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            grdServico.Columns.Add(pacote)

            Dim idfilial As New DataGridViewTextBoxColumn 'Posição 13
            idfilial.HeaderText = "Filial"
            idfilial.DataPropertyName = "id_filial"
            idfilial.Width = 10
            idfilial.Visible = False
            grdServico.Columns.Add(idfilial)

            Dim codservico As New DataGridViewTextBoxColumn 'Posição 14
            codservico.HeaderText = "Cod. Serviço"
            codservico.DataPropertyName = "cod_servico"
            codservico.Width = 10
            codservico.Visible = False
            grdServico.Columns.Add(codservico)

            grdServico.DataSource = ttServico

            For Each linha As DataGridViewRow In grdServico.Rows
                If linha.Cells(7).Value = 2 Then
                    linha.Cells(0).Value = True
                    btnComprovante.Enabled = True
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub mostraCabecalhoPedido()
        Dim strSQL As String = "select cliente.nome_cliente, pedido_balcao.cod_cliente, pedido_balcao.id_filial, pedido_balcao.num_pedido, " & _
            "pedido_balcao.forma, pedido_balcao.cod_status_pedido, status_pedido.Status_pedido, pedido_balcao.valor_pago, pedido_balcao.cod_vendedor, " & _
            "Usuarios.NOME from cliente inner join pedido_balcao on cliente.cod_cliente = pedido_balcao.cod_cliente inner join status_pedido " & _
            "on pedido_balcao.cod_status_pedido = status_pedido.cod_status_pedido inner join Usuarios on pedido_balcao.cod_vendedor = Usuarios.cod_usuario " & _
            "where pedido_balcao.num_pedido = " & intAbrePedido & " and id_filial = " & conf.Filial

        ttPedidoInfo = creditoObj.retornaRegistro(strSQL).Tables(0)

        If ttPedidoInfo.Rows.Count > 0 Then
            lblCliente.Text = ttPedidoInfo.Rows(0)("cod_cliente").ToString & " - " & ttPedidoInfo.Rows(0)("nome_cliente").ToString
            Label13.Text = ttPedidoInfo.Rows(0)("id_filial").ToString & " - " & ttPedidoInfo.Rows(0)("num_pedido").ToString & " - " & _
            RTrim(ttPedidoInfo.Rows(0)("status_pedido").ToString) & " - " & " Valor pago: " & Format(ttPedidoInfo.Rows(0)("valor_pago"), "#,##0.00")

            'Busca a fatura em que o pedido está cadastrado.
            Dim strSQLFatura As String = "Select cod_fatura from fatura_itens where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & _
                " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial")
            Dim ttFatura As New DataTable
            ttFatura = creditoObj.retornaRegistro(strSQLFatura).Tables(0)
            If ttFatura.Rows.Count > 0 Then
                lblCodFatura.Text = ttFatura.Rows(0)("cod_fatura").ToString
            End If
        Else
            MessageBox.Show("Não foi possível localizar nenhum registro.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    'Rotina responsável por devolver o crédito ao cliente
    Private Sub devolvecredito()
        Dim strSQLOS As String = "select cod_os from os where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial")
        Dim ttOS As New DataTable
        ttOS = creditoObj.retornaRegistro(strSQLOS).Tables(0)

        Dim credito As New objCreditoCliente
        credito.novo()
        credito.cod_filial_cliente = ttPedidoInfo.Rows(0)("id_filial").ToString
        credito.cod_cliente = ttPedidoInfo.Rows(0)("cod_cliente").ToString
        credito.data = Now
        credito.id_filial = conf.Filial
        credito.id_usuario = intUsuario
        credito.credito = valorCredito
        If creditoObj.verifica_existencia_registro(strSQLOS) = True Then
            credito.historico = "Estorno de crédito referente ao pedido Nº. " & ttPedidoInfo.Rows(0)("num_pedido").ToString & " vinculado a OS Nº " & ttOS.Rows(0)("cod_os") & " da fatura Nº " & CInt(lblCodFatura.Text)
        Else
            credito.historico = "Estorno de crédito referente ao pedido Nº. " & ttPedidoInfo.Rows(0)("num_pedido").ToString & " da fatura nº " & CInt(lblCodFatura.Text)
        End If
        credito.Salvar()
        MessageBox.Show("Crédito estornado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Rotina responsável por devolver o dinheiro para o cliente
    Private Sub devolvedinheiro()
        Try
            Dim strSQLOS As String = "select cod_os from os where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial")
            Dim ttOS As New DataTable
            ttOS = creditoObj.retornaRegistro(strSQLOS).Tables(0)

            Dim lanc As New objLancamentos
            lanc.novo()
            lanc.data_lancamento = creditoObj.retornaDataHoraServidor
            lanc.data_vencimento = creditoObj.retornaDataHoraServidor
            lanc.id_filial = conf.Filial
            lanc.id_filial_lancamento = conf.Filial
            lanc.cod_conta = 2722
            lanc.cod_forma_pagamento = ttPedidoInfo.Rows(0)("forma")
            lanc.data_recebimento = creditoObj.retornaDataHoraServidor
            If creditoObj.verifica_existencia_registro(strSQLOS) = True Then
                lanc.historico = "Estorno de dinheiro para o cliente " & ttPedidoInfo.Rows(0)("cod_cliente") & " - " & ttPedidoInfo.Rows(0)("nome_cliente").ToString & _
                                " Referente ao pedido: " & ttPedidoInfo.Rows(0)("num_pedido").ToString & " vinculado a OS Nº " & ttOS.Rows(0)("cod_os") & " da fatura Nº " & CInt(lblCodFatura.Text)
            Else
                lanc.historico = "Estorno de dinheiro para o cliente " & ttPedidoInfo.Rows(0)("cod_cliente") & " - " & ttPedidoInfo.Rows(0)("nome_cliente").ToString & _
                " Referente ao pedido: " & ttPedidoInfo.Rows(0)("num_pedido").ToString & " da fatura nº " & CInt(lblCodFatura.Text)
            End If
            lanc.n_parcela = 1
            lanc.n_parcelas = 1
            lanc.tipo = "S"
            lanc.cod_fatura_lanc = CInt(lblCodFatura.Text)
            lanc.valor = valorCredito
            lanc.acrescimo_novo = 0.0
            lanc.juros_novo = 0.0
            lanc.desconto_novo = 0.0
            lanc.taxas = 0.0
            lanc.Salvar()
            MessageBox.Show("Dinheiro estornado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Rotina responsável por devolver o item ao estoque fisico
    Private Sub devolveestoque(ByVal qdte As Integer, ByVal codprod As Integer, ByVal numpedido As Integer, ByVal item As Integer)
        Dim strSQLOS As String = "select cod_os from os where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial")
        Dim ttOS As New DataTable
        ttOS = creditoObj.retornaRegistro(strSQLOS).Tables(0)

        Dim strSQL As String = ""
        Dim i As Integer = 0
        Dim intUsuario As Integer = creditoObj.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim intQuant As Integer = qdte 'ds.Tables(0).Rows(i)("quant").ToString
        Dim intcodproduto As Integer = codprod 'ds.Tables(0).Rows(i)("cod_produto").ToString
        Dim intPedido As Integer = numpedido 'ds.Tables(0).Rows(i)("num_pedido").ToString
        Dim intItem As Integer = item  'ds.Tables(0).Rows(i)("item").ToString
        Dim cod_lancamento = retorna_Chave("cod_lancamento", "movimento", " where id_filial = " & conf.Filial & "")
        Dim estoqueFis As Double = CInt(creditoObj.retorna_saldo_fisico(intcodproduto, confFilial)) + intQuant
        Dim estoqueFin As Double = d.cdin(estoqueFis) * d.cdin(creditoObj.retorna_saldo_financeiro(codprod))
        creditoObj.retorna_preco_compra_desconto(codprod)
        Dim codmovimento As Integer = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial & "")
        Dim punit As Double = creditoObj.ppreco_compra
        Dim desconto As Double = creditoObj.pdesconto_compra
        Dim pvenda As Double = 0
        Dim descVenda As Double = 0
        Dim icms As Double = 17
        Dim ipi As Double = 0
        Dim documento As String = ""

        If creditoObj.verifica_existencia_registro(strSQLOS) = True Then
            documento = "Devolução p/ Estoque referente ao pedido Nº. " & ttPedidoInfo.Rows(0)("num_pedido").ToString & " vinculado a OS Nº " & ttOS.Rows(0)("cod_os") & " da fatura Nº " & CInt(lblCodFatura.Text)
        Else
            documento = "Devolução p/ Estoque referente ao pedido Nº. " & ttPedidoInfo.Rows(0)("num_pedido").ToString & " faturado na fatura nº " & CInt(lblCodFatura.Text)
        End If

        Try
            strSQL = "INSERT INTO movimentomaster " & _
            "(cod_movimento,cod_natureza,id_filial,data,doc,id_usuario,concluido) " & _
            "VALUES ( " & _
            codmovimento & _
            ",12" & _
            "," & conf.Filial & _
            "," & d.pdtm(creditoObj.retornaDataHoraServidor) & _
            "," & d.PStr(documento) & _
            "," & intUsuario & _
            ",'N')"
            Dim cmd As New SqlCommand(strSQL, d.con)
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            strSQL = "INSERT INTO movimento (cod_lancamento ,id_filial ,item ,cod_Movimento " & _
            ",cod_produto,quant,desconto ,pUnit ,estoqueFis ,estoqueFin ,status ,pVenda " & _
            ",descVenda,historico,icms,ipi,data_lancamento) " & _
            "VALUES(" & cod_lancamento & "," & confFilial & "," & intItem & ", " & _
            codmovimento & "," & intcodproduto & "," & intQuant & "," & cdin(desconto) & _
            "," & d.cdin(punit) & "," & d.cdin(estoqueFis) & "," & d.cdin(estoqueFin) & _
            "," & 0 & "," & d.cdin(pvenda) & "," & d.cdin(descVenda) & _
            "," & d.PStr(documento) & "," & d.cdin(icms) & "," & d.cdin(ipi) & _
            "," & d.pdtm(Now()) & ")"
            Dim cmd As New SqlCommand(strSQL, d.con)
            estoque.cod_movimento = codmovimento
            estoque.id_filial = conf.Filial
            estoque.conclui()
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try

    End Sub


    Private Sub btnComprovante_Click(sender As System.Object, e As System.EventArgs) Handles btnComprovante.Click
        Dim f As New frmRpt
        Dim r As New rptEstornoCreditoEstoque
        Try
            r.intPedido = ttPedidoInfo.Rows(0)("num_pedido")
            r.intFilial = ttPedidoInfo.Rows(0)("id_filial")
            r.TextBox7.Text = ttPedidoInfo.Rows(0)("cod_cliente")
            r.TextBox.Text = ttPedidoInfo.Rows(0)("nome_cliente")
            f.Relat(r)
            f.ShowDialog(Me)
            f.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnEstornar_Click(sender As System.Object, e As System.EventArgs) Handles btnEstornar.Click
        Dim intContador As Integer
        Dim intQtdeItem As Integer
        If MessageBox.Show("Deseja realizar o estorno de crédito ou dinheiro para o cliente?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            intUsuario = creditoObj.retorna_codigo_usuario(frmMain.intCodigoUsuario)
            Dim intControle As Int16 = 1
            Dim strSQLFaturado As String = "select 1 from fatura_itens where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & _
                " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial")

            For Each linhaProd As DataGridViewRow In grdPedido.Rows
                'Verifica se a opção crédito foi marcada
                If rbCredito.Checked = True Then
                    If linhaProd.Cells(0).Value = True Then
                        'Verifica se o item já foi baixado do estoque
                        If linhaProd.Cells(12).Value = 3 Then
                            If creditoObj.verifica_permissao_usuario(intUsuario, 48) = True Then
                                'Verifica se o pedido já foi faturado e em seguida devolve o valor do crédito para o cliente
                                If creditoObj.verifica_existencia_registro(strSQLFaturado) = True Then
                                    devolveestoque(linhaProd.Cells(2).Value, linhaProd.Cells(9).Value, linhaProd.Cells(11).Value, linhaProd.Cells(10).Value)
                                    valorCreditoProd = valorCreditoProd + linhaProd.Cells(6).Value
                                    Dim strSQL As String = "cod_status_item = 5, usuario_can = " & intUsuario & ", tipo_devolucao = 'C'," & _
                                        "devolvido_estoque = 'S', data_devolucao = " & d.pdtm(Now()) & _
                                    " where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & _
                                    " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial") & " and item = " & linhaProd.Cells(10).Value
                                    creditoObj.atualiza_registros("pedido_balcao_itens", strSQL, True)
                                Else
                                    MessageBox.Show("Devolução de crédito não pode ser efetuada devido" & Chr(13) & "pedido ainda não ter sido faturado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If
                                intControle = 2
                            Else
                                MessageBox.Show("Usuário sem permissão para estornar item baixado do estoque.", "ERROR:49", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        End If
                        ''

                        If intControle = 1 Then
                            'Verifica se o item já foi baixado do estoque
                            If (linhaProd.Cells(12).Value <> 4) And (linhaProd.Cells(12).Value <> 5) Then
                                If creditoObj.verifica_permissao_usuario(intUsuario, 49) = True Then
                                    'Verifica se o pedido já foi faturado e em seguida devolve o valor do crédito para o cliente
                                    If creditoObj.verifica_existencia_registro(strSQLFaturado) = True Then
                                        valorCreditoProd = valorCreditoProd + linhaProd.Cells(6).Value
                                        Dim strSQL As String = "cod_status_item = 4, usuario_can = " & intUsuario & ", tipo_devolucao = 'C', " & _
                                            "devolvido_estoque = 'N', data_devolucao = " & d.pdtm(Now()) & _
                                            " where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & _
                                            " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial") & " and item = " & linhaProd.Cells(10).Value
                                        creditoObj.atualiza_registros("pedido_balcao_itens", strSQL, True)
                                    Else
                                        MessageBox.Show("Devolução de crédito não pode ser efetuada devido" & Chr(13) & "pedido ainda não ter sido faturado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                Else
                                    MessageBox.Show("Usuário sem permissão para estornar crédito para o cliente.", "ERROR:49", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If
                            End If
                        End If
                        intQtdeItem = intQtdeItem + 1
                    End If
                End If

                'Verifica se a opção dinheiro foi marcada
                If rbDinheiro.Checked = True Then
                    If linhaProd.Cells(0).Value = True Then
                        'Verifica se o item já foi baixado do estoque
                        If linhaProd.Cells(12).Value = 3 Then
                            If creditoObj.verifica_permissao_usuario(intUsuario, 48) = True Then
                                'Verifica se o pedido já foi faturado e em seguida devolve o valor do crédito para o cliente
                                If creditoObj.verifica_existencia_registro(strSQLFaturado) = True Then
                                    devolveestoque(linhaProd.Cells(2).Value, linhaProd.Cells(9).Value, linhaProd.Cells(11).Value, linhaProd.Cells(10).Value)
                                    valorCreditoProd = valorCreditoProd + linhaProd.Cells(6).Value
                                    Dim strSQL As String = "cod_status_item = 5, usuario_can = " & intUsuario & ", tipo_devolucao = 'D'," & _
                                        "devolvido_estoque = 'S', data_devolucao = " & d.pdtm(Now()) & _
                                    " where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & _
                                    " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial") & " and item = " & linhaProd.Cells(10).Value
                                    creditoObj.atualiza_registros("pedido_balcao_itens", strSQL, True)
                                Else
                                    MessageBox.Show("Devolução de crédito não pode ser efetuada devido" & Chr(13) & "pedido ainda não ter sido faturado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If
                                intControle = 1
                            Else
                                MessageBox.Show("Usuário sem permissão para estornar item baixado do estoque.", "ERROR:48", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        End If
                        ''

                        If intControle = 0 Then
                            'Verifica se o item já foi baixado do estoque
                            If (linhaProd.Cells(12).Value <> 4) And (linhaProd.Cells(12).Value <> 5) Then
                                If creditoObj.verifica_permissao_usuario(intUsuario, 49) = True Then
                                    'Verifica se o pedido já foi faturado e em seguida devolve o valor do crédito para o cliente
                                    If creditoObj.verifica_existencia_registro(strSQLFaturado) = True Then
                                        valorCreditoProd = valorCreditoProd + linhaProd.Cells(6).Value
                                        Dim strSQL As String = "cod_status_item = 4, usuario_can = " & intUsuario & ", tipo_devolucao = 'D', " & _
                                            "devolvido_estoque = 'N', data_devolucao = " & d.pdtm(Now()) & _
                                            " where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & _
                                            " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial") & " and item = " & linhaProd.Cells(10).Value
                                        creditoObj.atualiza_registros("pedido_balcao_itens", strSQL, True)
                                    Else
                                        MessageBox.Show("Devolução de crédito não pode ser efetuada devido" & Chr(13) & "pedido ainda não ter sido faturado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                Else
                                    MessageBox.Show("Usuário sem permissão para estornar crédito para o cliente.", "ERROR:49", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If
                            End If
                        End If
                        intQtdeItem = intQtdeItem + 1
                    End If
                End If
            Next

            For Each linhServ As DataGridViewRow In grdServico.Rows
                If rbCredito.Checked = True Then
                    If linhServ.Cells(0).Value = True Then
                        If creditoObj.verifica_existencia_registro(strSQLFaturado) = True Then
                            valorCreditoServ = valorCreditoServ + linhServ.Cells(6).Value
                            Dim strSQLServico As String = "cod_status_servico = 2, usuario_can = " & intUsuario & ", tipo_devolucao = 'C', " & _
                            "devolvido_estoque = 'N', data_devolucao = " & d.pdtm(Now()) & _
                            " where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & _
                            " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial") & " and item_servico = " & linhServ.Cells(10).Value & _
                            " and cod_servico = " & linhServ.Cells(14).Value
                            creditoObj.atualiza_registros("pedido_balcao_servicos", strSQLServico, True)
                        End If
                        intQtdeItem = intQtdeItem + 1
                    End If
                End If

                If rbDinheiro.Checked = True Then
                    If linhServ.Cells(0).Value = True Then
                        If creditoObj.verifica_existencia_registro(strSQLFaturado) = True Then
                            valorCreditoServ = valorCreditoServ + linhServ.Cells(6).Value
                            Dim strSQLServico As String = "cod_status_servico = 2, usuario_can = " & intUsuario & ", tipo_devolucao = 'D', " & _
                            "devolvido_estoque = 'N', data_devolucao = " & d.pdtm(Now()) & _
                            " where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & _
                            " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial") & " and item_servico = " & linhServ.Cells(10).Value & _
                            " and cod_servico = " & linhServ.Cells(14).Value
                            creditoObj.atualiza_registros("pedido_balcao_servicos", strSQLServico, True)
                        End If
                        intQtdeItem = intQtdeItem + 1
                    End If
                End If
            Next

            intContador = grdPedido.Rows.Count + grdServico.Rows.Count

            'Verifica se a quantidade de itens selecionados é igual a quantidade de itens dentro dos grids caso seja muda o status do pedido para estono de crédito/dinheiro
            If intContador = intQtdeItem Then
                Dim strSQL As String = "cod_status_pedido = 6 where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial")
                creditoObj.atualiza_registros("pedido_balcao", strSQL, True)
                GroupBox1.Enabled = False
                btnEstornar.Enabled = False
            End If

            valorCredito = valorCreditoProd + valorCreditoServ
            If (valorCredito > 0) And (rbCredito.Checked = True) Then
                If ttPedidoInfo.Rows(0)("valor_pago") < valorCredito Then
                    valorCredito = ttPedidoInfo.Rows(0)("valor_pago")
                    MessageBox.Show("Valor a ser devolvido é menor que os valores selecionados" & Chr(13) & "valor a ser devolvido será de " & Format(ttPedidoInfo.Rows(0)("valor_pago"), "#,##0.00"), "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                devolvecredito()
                Dim strSQL As String = "valor_devolvido = valor_devolvido + " & Replace(valorCredito, ",", ".") & " where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & _
                    " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial")
                creditoObj.atualiza_registros("pedido_balcao", strSQL, True)
            End If

            If (valorCredito > 0) And (rbDinheiro.Checked = True) Then
                If ttPedidoInfo.Rows(0)("valor_pago") < valorCredito Then
                    valorCredito = ttPedidoInfo.Rows(0)("valor_pago")
                    MessageBox.Show("Valor a ser devolvido é menor que os valores selecionados" & Chr(13) & "valor a ser devolvido será de " & Format(ttPedidoInfo.Rows(0)("valor_pago"), "#,##0.00"), "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                devolvedinheiro()
                Dim strSQL As String = "valor_devolvido = valor_devolvido + " & Replace(valorCredito, ",", ".") & " where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & _
                    " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial")
                creditoObj.atualiza_registros("pedido_balcao", strSQL, True)
            End If

            If (intControle = 1) Or (intControle = 2) Then
                Dim strSQLOSFase As String = "cod_fase = 21 where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial")
                Dim strSQLOS As String = "Select cod_os, id_filial from os where num_pedido = " & ttPedidoInfo.Rows(0)("num_pedido") & " and id_filial = " & ttPedidoInfo.Rows(0)("id_filial")
                Dim ttOS As New DataTable
                ttOS = creditoObj.retornaRegistro(strSQLOS).Tables(0)

                If ttOS.Rows.Count = 1 Then
                    Dim intOrdem As Integer
                    Dim strTexto As String = "OS cancelada com opção de crédito/débito pelo sistema."
                    creditoObj.atualiza_registros("OS", strSQLOSFase, True)
                    Dim strSQLInsert As String = "Insert into OS_Cancelada(cod_os, id_filial,descricao,data,usuario) values(" & _
                    ttOS.Rows(0)("cod_os") & "," & ttOS.Rows(0)("id_filial") & "," & d.PStr(strTexto) & "," & d.Pdt(Now()) & "," & intUsuario & ")"
                    creditoObj.grava_registros(strSQLInsert, True)

                    intOrdem = creditoObj.retornaUltimoRegistro("andamentos", "ordem", "where cod_os = " & ttOS.Rows(0)("cod_os") & " and id_filial = " & ttOS.Rows(0)("id_filial"))

                    Dim strSQLOrdem As String = "INSERT INTO andamentos(id_filial, cod_os, id_filial_andamento, ordem, data, cod_andamento, cod_usuario," & _
                    "cod_status_andamento ,Observacao) VALUES(" & ttOS.Rows(0)("id_filial") & "," & ttOS.Rows(0)("cod_os") & "," & conf.Filial & _
                    "," & intOrdem & "," & d.pdtm(Now()) & "," & 703 & "," & intUsuario & "," & 1 & "," & d.PStr(strTexto) & ")"
                    creditoObj.grava_registros(strSQLOrdem, True)
                End If

                valorCreditoProd = 0
                valorCreditoServ = 0
                valorCredito = 0
                mostraPedido()
                mostraServico()
            End If
        End If
    End Sub
End Class