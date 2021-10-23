Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmDevolucaoEstoque
    Dim d As New dados
    Dim conf As New config
    Dim estoque As New objMaster
    Dim cod_movimento As Integer
    Dim cliente As New objCreditoCliente
    Dim nQuantidade As Integer
    Dim npreco As Double
    Dim ndesconto As Double
    Dim ntotal As Double
    Dim strpacote As String
    Dim ndesccaixa As Double
    Dim item As Integer
    Dim strForma As Char

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If (txtNumPedido.Text = String.Empty) Or (txtFilial.Text = String.Empty) Then
            MessageBox.Show("Os campos Número Pedido e Filial são obrigatórios para a operação.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If estoque.verifica_pedido_balcao(CInt(txtNumPedido.Text), CInt(txtFilial.Text)) = True Then
            Try
                lblNumPedido.Visible = True
                lblFilial.Visible = True
                lblVendedor.Visible = True
                lblData.Visible = True
                lblCliente.Visible = True
                lblCodCli.Visible = True
                txtNumPedido.Enabled = False
                btnOK.Enabled = False
                btnDevolver.Enabled = True
                btnImprimir.Enabled = True
                txtFilial.Enabled = False
                carrega_pedido(txtNumPedido.Text, txtFilial.Text)
                carrega_grid(txtNumPedido.Text, txtFilial.Text)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MessageBox.Show("Pedido: " & txtNumPedido.Text & " inexistente.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub carrega_pedido(ByVal numpedido As Integer, ByVal filial As Integer)
        Dim strSQL As String = "Select pedido_balcao.num_pedido, pedido_balcao.id_filial,usuarios.nome,  pedido_balcao.data_pedido, " & _
            "pedido_balcao.cod_cliente, pedido_balcao.cod_filial_cliente, pedido_balcao.cod_status_pedido, cliente.nome_cliente, " & _
            "pedido_balcao.forma from pedido_balcao INNER JOIN usuarios ON  pedido_balcao.cod_vendedor =  usuarios.cod_usuario " & _
            "INNER JOIN cliente ON pedido_balcao.cod_cliente = cliente.cod_cliente  where pedido_balcao.num_pedido = " & numpedido & _
            " And pedido_balcao.id_filial = " & filial & ""
        Dim ttPedido As New DataTable
        ttPedido = estoque.retornaRegistro(strSQL).Tables(0)

        Try
            lblNumPedido.Text = ttPedido.Rows(0)("num_pedido")
            lblFilial.Text = ttPedido.Rows(0)("id_filial")
            lblVendedor.Text = ttPedido.Rows(0)("nome")
            lblData.Text = FormatDateTime(ttPedido.Rows(0)("data_pedido"), DateFormat.ShortDate)
            lblCliente.Text = ttPedido.Rows(0)("nome_cliente")
            lblCodCli.Text = ttPedido.Rows(0)("cod_cliente")
            strForma = ttPedido.Rows(0)("forma")

            If ttPedido.Rows(0)("cod_status_pedido") = 4 Then
                btnDevolver.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub carrega_grid(ByVal numpedido As Integer, ByVal filial As Integer)
        Dim strSQL As String = "SELECT pedido_balcao_itens.num_pedido, pedido_balcao_itens.id_filial, pedido_balcao_itens.item, " & _
        "pedido_balcao_itens.cod_produto,pedido_balcao_itens.quant, pedido_balcao_itens.compra, pedido_balcao_itens.desconto," & _
        "pedido_balcao_itens.preco, pedido_balcao_itens.cod_status_item, pedido_balcao_itens.Pacote, pedido_balcao_itens.cod_pacote," & _
        "pedido_balcao_itens.desc_caixa,produtos.produto, lentes_blocos.cod_lente, lentes_tabela.cod_tabela, " & _
        "(pedido_balcao_itens.quant*(round(pedido_balcao_itens.preco,2)-(round(pedido_balcao_itens.preco,2)*(pedido_balcao_itens.desconto/100)))) as total, " & _
        "status_item_pedido.cod_status_item,status_item_pedido.status_item, pedido_balcao_itens.cod_pacote " & _
        "FROM pedido_balcao_itens INNER JOIN produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " & _
        "INNER JOIN lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente INNER JOIN lentes_tabela ON " & _
        "lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " & _
        "INNER JOIN status_item_pedido ON pedido_balcao_itens.cod_status_item = status_item_pedido.cod_status_item " & _
        "WHERE pedido_balcao_itens.num_pedido = " & numpedido & " AND pedido_balcao_itens.id_filial = " & conf.Filial

        grdProduto.Columns.Clear()
        grdProduto.DataSource = Nothing
        grdProduto.AllowUserToAddRows = False
        grdProduto.AutoGenerateColumns = False

        Dim Devolver As New DataGridViewCheckBoxColumn 'Posição 00
        Devolver.HeaderText = "Dev."
        Devolver.Width = 50
        grdProduto.Columns.Add(Devolver)

        Dim item As New DataGridViewTextBoxColumn 'Posição 01
        item.HeaderText = "Item"
        item.DataPropertyName = "item"
        item.Width = 50
        item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        item.ReadOnly = True
        grdProduto.Columns.Add(item)

        Dim codigo As New DataGridViewTextBoxColumn 'Posição 02
        codigo.HeaderText = "Cod. Prod"
        codigo.DataPropertyName = "cod_produto"
        codigo.Width = 80
        codigo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        codigo.ReadOnly = True
        grdProduto.Columns.Add(codigo)

        Dim produto As New DataGridViewTextBoxColumn 'Posição 03
        produto.HeaderText = "Descrição do Produto"
        produto.DataPropertyName = "Produto"
        produto.Width = 390
        produto.ReadOnly = True
        grdProduto.Columns.Add(produto)

        Dim Qtde As New DataGridViewTextBoxColumn 'Posição 04
        Qtde.HeaderText = "Qtde"
        Qtde.DataPropertyName = "Quant"
        Qtde.Width = 35
        Qtde.ReadOnly = True
        Qtde.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdProduto.Columns.Add(Qtde)

        Dim Preco As New DataGridViewTextBoxColumn 'Posição 05
        Preco.HeaderText = "Preço"
        Preco.DataPropertyName = "preco"
        Preco.Width = 65
        Preco.ReadOnly = True
        Preco.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Preco.DefaultCellStyle.Format = "#,##0.00"
        grdProduto.Columns.Add(Preco)

        Dim Desconto As New DataGridViewTextBoxColumn 'Posição 06
        Desconto.HeaderText = "Desc. (%)"
        Desconto.DataPropertyName = "desconto"
        Desconto.Width = 75
        Desconto.ReadOnly = True
        Desconto.DefaultCellStyle.Format = "#,##0.00"
        Desconto.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdProduto.Columns.Add(Desconto)

        Dim Total As New DataGridViewTextBoxColumn 'Posição 07
        Total.HeaderText = "Total"
        Total.DataPropertyName = "Total"
        Total.Width = 70
        Total.ReadOnly = True
        Total.DefaultCellStyle.Format = "#,##0.00"
        Total.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight 'Posição 08
        grdProduto.Columns.Add(Total)

        Dim statusitem As New DataGridViewTextBoxColumn 'Posição 08
        statusitem.HeaderText = "Status Item"
        statusitem.DataPropertyName = "status_item"
        statusitem.Width = 140
        statusitem.ReadOnly = True
        grdProduto.Columns.Add(statusitem)


        Dim pacote As New DataGridViewTextBoxColumn 'Posição 09
        pacote.HeaderText = "Pct."
        pacote.DataPropertyName = "cod_pacote"
        pacote.Width = 50
        pacote.ReadOnly = True
        grdProduto.Columns.Add(pacote)

        Dim pacotedes As New DataGridViewTextBoxColumn 'Posição 10
        pacotedes.HeaderText = "Pacote"
        pacote.DataPropertyName = "pacote"
        pacotedes.Width = 70
        pacotedes.Visible = False
        grdProduto.Columns.Add(pacotedes)

        Dim codstatusitem As New DataGridViewTextBoxColumn 'Posição 11
        codstatusitem.HeaderText = "Status Item"
        codstatusitem.DataPropertyName = "cod_status_item"
        codstatusitem.Width = 20
        codstatusitem.Visible = False
        grdProduto.Columns.Add(codstatusitem)

        'Dim desccaixa As New DataGridViewTextBoxColumn
        'desccaixa.HeaderText = "Pacote"
        'desccaixa.Width = 70
        'desccaixa.Visible = False
        'grdProd.Columns.Add(desccaixa)

        Try
            grdProduto.DataSource = estoque.retornaRegistro(strSQL).Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally

        End Try

        Dim nNumPedido As Integer = CInt(lblNumPedido.Text)
        Dim nIdFilial As Integer = CInt(lblFilial.Text)
    End Sub

    Private Sub insere_item_nota(ByVal codproduto As Integer, ByVal quant As Double)
        Dim strSQL As String = ""
        Dim cod_lancamento = retorna_Chave("cod_lancamento", "movimento", " where movimento.id_filial = " & conf.Filial & "")
        Dim estoqueFis As Double = CInt(estoque.retorna_saldo_fisico(codproduto, conf.Filial)) + quant
        Dim estoqueFin As Double = estoqueFis * estoque.retorna_saldo_financeiro(codproduto)
        estoque.retorna_preco_compra_desconto(codproduto)
        Dim punit As Double = estoque.ppreco_compra
        Dim desconto As Double = estoque.pdesconto_compra
        Dim pvenda As Double = 0
        Dim descVenda As Double = 0
        Dim icms As Double = 17
        Dim ipi As Double = 0

        strSQL = "INSERT INTO movimento (cod_lancamento ,id_filial ,item ,cod_Movimento " & _
        ",cod_produto,quant,desconto ,pUnit ,estoqueFis ,estoqueFin ,status ,pVenda " & _
        ",descVenda,historico,icms,ipi,data_lancamento) " & _
        "VALUES(" & cod_lancamento & "," & conf.Filial & "," & item & "," & _
        cod_movimento & "," & codproduto & "," & quant & "," & cdin(desconto) & _
        "," & d.cdin(punit) & "," & d.cdin(estoqueFis) & "," & d.cdin(estoqueFin) & _
        "," & 0 & "," & d.cdin(pvenda) & "," & d.cdin(descVenda) & _
        "," & d.PStr("Devolução p/ Estoque ref. ao pedido n. " & lblNumPedido.Text) & "," & d.cdin(icms) & "," & d.cdin(ipi) & _
        "," & d.pdtm(Now()) & ")"

        Dim cmd As New SqlCommand(strSQL, d.con)

        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try

    End Sub


    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Dim rp As New rptProdutoDevEstoque
        Dim f As New frmRpt

        Try
            rp.TextBox11.Text = lblVendedor.Text
            rp.TextBox4.Text = lblCliente.Text
            rp.TextBox9.Text = lblNumPedido.Text
            rp.Label10.Text = "Produtos estornados para o estoque."
            rp.TextBox18.Text = lblData.Text
            rp.TextBox3.Text = lblCodCli.Text
            rp.Label6.Text = "Cód. Movimento: " & cod_movimento
            rp.DataSource = estoque.retona_produtos_estoque(CInt(lblNumPedido.Text), 5, conf.Filial)
            rp.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
            f.Relat(rp)
            f.ShowDialog(Me)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub grdProd_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles grdProduto.CellFormatting
        If grdProduto.Rows(e.RowIndex).Cells(11).Value = 5 Then
            grdProduto.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            grdProduto.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
            grdProduto.Rows(e.RowIndex).ReadOnly = True
            grdProduto.Rows(e.RowIndex).Cells(0).Value = True
        Else
            grdProduto.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            grdProduto.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub insere_movimento_master()
        Dim chave_movimento As Integer
        Dim id_filial As Integer
        Dim cod_usuario As Integer = estoque.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        chave_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial & "")
        cod_movimento = chave_movimento
        id_filial = conf.Filial
        Dim strSQL As String = "INSERT INTO movimentomaster " & _
        "(cod_movimento,cod_natureza,id_filial,data,doc,id_usuario,concluido) " & _
        "VALUES ( " & _
        chave_movimento & _
        ",15" & _
        "," & conf.Filial & _
        "," & d.pdtm(d.hora) & _
        "," & d.PStr("Devolução p/ Estoque ref. ao pedido n. " & lblNumPedido.Text) & _
        "," & cod_usuario & _
        ",'N')"

        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    Private Sub btnDevolver_Click(sender As System.Object, e As System.EventArgs) Handles btnDevolver.Click
        Dim selecao As Boolean
        Dim num As Int16
        Dim intStatusItem As String
        Dim strSQLFatura As String = "Select 1 From Fatura_Itens where num_pedido = " & CInt(txtNumPedido.Text) & " and id_filial = " & CInt(txtFilial.Text)

        If estoque.verifica_existencia_registro(strSQLFatura) = True Then
            If strForma = "1" Then
                MessageBox.Show("Produto não pode ser estornado por esta opção." & Chr(13) & "Produto deve ser estornado pela opção Crédito/Débito." & Chr(13), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                carrega_grid(txtNumPedido.Text, txtFilial.Text)
                Exit Sub
            End If
        End If

        If MessageBox.Show("Deseja devolver o(s) produto(s) para o estoque?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                insere_movimento_master()
                For Each campo As DataGridViewRow In grdProduto.Rows
                    selecao = campo.Cells(0).Value
                    intStatusItem = campo.Cells(11).Value
                    If (selecao = True) And (intStatusItem = 3) Then
                        estoque.conclui(cod_movimento, conf.Filial)
                        insere_item_nota(campo.Cells(2).Value, campo.Cells(4).Value)
                        estoque.atualiza_status_itens_pedido(CInt(lblNumPedido.Text), CInt(conf.Filial), campo.Cells(2).Value, campo.Cells(1).Value)
                        num = 1
                    End If
                Next
                If num = 0 Then
                    MessageBox.Show("Impossível retornar produto que ainda não foi baixado do estoque.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            If num = 1 Then
                MessageBox.Show("Devolução para o estoque efetuado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lblStatus.Visible = True
                lblStatus.Text = "Cod. Movimento: " & cod_movimento
                carrega_grid(txtNumPedido.Text, txtFilial.Text)
                atualizaStatusPedido(txtNumPedido.Text, txtFilial.Text)
            End If
        End If
    End Sub

    Private Sub atualizaStatusPedido(ByVal numPedido As Integer, ByVal idFilial As Integer)
        Dim intQte As Integer
        For Each linha As DataGridViewRow In grdProduto.Rows
            If linha.Cells(11).Value = 5 Then
                intQte = intQte + 1
            End If
        Next

        If intQte = grdProduto.Rows.Count Then
            Dim strSQLUpdate As String = "cod_status_pedido = 4 where num_pedido = " & numPedido & " and id_filial = " & idFilial
            estoque.atualiza_registros("pedido_balcao", strSQLUpdate, True)
            btnDevolver.Enabled = False
        End If
    End Sub


End Class