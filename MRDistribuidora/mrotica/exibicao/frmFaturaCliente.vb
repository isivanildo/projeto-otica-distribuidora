Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Public Class frmFaturaCliente
    Dim d As New dados
    Public user As objUsuario
    Dim conf As New config
    Dim caixa As New objMaster
    Public ttRes As New DataTable
    Dim tb As New DataTable
    Dim id As Integer
    Dim fatura As New objFatura
    'Variáveis acrescentadas por Ivanildo 05/12/2012
    Public cod_filial As Integer
    Public cod_filial_cliente As Integer
    Public cod_cliente As Integer
    Public strNome As String
    Dim intTotalItens As Integer
    Dim TotalGeralItens As Double
    Dim TotalGeralItensSel As Double
    Dim intControle As Int16

    Private Sub btnDespesa_Click(sender As System.Object, e As System.EventArgs)
        Dim f As New frmDespesas
        f.ShowDialog(Me)
        f.Dispose()
    End Sub


    Private Sub btnOutrasDespesas_Click(sender As System.Object, e As System.EventArgs)
        Dim f As New frmOutrasEntradas
        f.Show()
    End Sub


    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDinheiro.KeyPress
        If Not Char.IsNumber(e.KeyChar) And (Not e.KeyChar = vbBack) And (Not e.KeyChar = ".") And (Not e.KeyChar = ",") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCartaoCredito.KeyPress
        If Not Char.IsNumber(e.KeyChar) And (Not e.KeyChar = vbBack) And (Not e.KeyChar = ".") And (Not e.KeyChar = ",") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCartaoDebito.KeyPress
        If Not Char.IsNumber(e.KeyChar) And (Not e.KeyChar = vbBack) And (Not e.KeyChar = ".") And (Not e.KeyChar = ",") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCheque.KeyPress
        If Not Char.IsNumber(e.KeyChar) And (Not e.KeyChar = vbBack) And (Not e.KeyChar = ".") And (Not e.KeyChar = ",") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoleto.KeyPress
        If Not Char.IsNumber(e.KeyChar) And (Not e.KeyChar = vbBack) And (Not e.KeyChar = ".") And (Not e.KeyChar = ",") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtOutro.KeyPress
        If Not Char.IsNumber(e.KeyChar) And (Not e.KeyChar = vbBack) And (Not e.KeyChar = ".") And (Not e.KeyChar = ",") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodGerente2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodGerente2.KeyPress
        If Not Char.IsNumber(e.KeyChar) And (Not e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodGerente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And (Not e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSaldoInicial_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And (Not e.KeyChar = vbBack) And (Not e.KeyChar = ".") And (Not e.KeyChar = ",") Then
            e.Handled = True
        End If
    End Sub



    Private Sub txtDinheiro_Leave(sender As System.Object, e As System.EventArgs) Handles txtDinheiro.Leave
        txtDinheiro.Text = caixa.formataValorMoeda(CDbl(txtDinheiro.Text))
    End Sub

    Private Sub txtCartaoCredito_Leave(sender As System.Object, e As System.EventArgs) Handles txtCartaoCredito.Leave
        txtCartaoCredito.Text = caixa.formataValorMoeda(CDbl(txtCartaoCredito.Text))
    End Sub

    Private Sub txtCartaoDebito_Leave(sender As System.Object, e As System.EventArgs) Handles txtCartaoDebito.Leave
        txtCartaoDebito.Text = caixa.formataValorMoeda(CDbl(txtCartaoDebito.Text))
    End Sub

    Private Sub txtCheque_Leave(sender As System.Object, e As System.EventArgs) Handles txtCheque.Leave
        txtCheque.Text = caixa.formataValorMoeda(CDbl(txtCheque.Text))
    End Sub

    Private Sub txtBoleto_Leave(sender As System.Object, e As System.EventArgs) Handles txtBoleto.Leave
        txtBoleto.Text = caixa.formataValorMoeda(CDbl(txtBoleto.Text))
    End Sub

    Private Sub txtOutro_Leave(sender As System.Object, e As System.EventArgs) Handles txtOutro.Leave
        txtOutro.Text = caixa.formataValorMoeda(CDbl(txtOutro.Text))
    End Sub


    Public Sub carrega_pedidos(ByVal x_cod_filial_cliente As Integer, ByVal x_cod_cliente As Integer)
        Dim sql As String
        sql = "SELECT top(100) pedido_balcao.id_filial, pedido_balcao.num_pedido, " & _
        "pedido_balcao.data_pedido, pedido_balcao.cod_status_pedido, " & _
        "status_pedido.Status_pedido, Usuarios.NOME,  " & _
        "(SELECT count(item) as itens FROM fatura_itens  " & _
        "WHERE (num_pedido = pedido_balcao.num_pedido) AND  " & _
        "(id_filial_pedido =pedido_balcao.id_filial)) as  " & _
        "Faturado," & _
        "isnull((SELECT sum(pedido_balcao_itens.quant *  " & _
        "(pedido_balcao_itens.preco - pedido_balcao_itens.preco *  " & _
        "(pedido_balcao_itens.desconto / 100))) AS total  " & _
        "FROM pedido_balcao_itens INNER JOIN  " & _
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " & _
        "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " & _
        "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " & _
        "AS Produtos,  " & _
        "isnull((SELECT sum(pedido_balcao_servicos.quant *  " & _
        "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " & _
        "(pedido_balcao_servicos.desconto / 100))) AS total  " & _
        "FROM pedido_balcao_servicos INNER JOIN  " & _
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " & _
        "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " & _
        "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0)  " & _
        "as servicos,  " & _
        "(isnull((SELECT sum(pedido_balcao_itens.quant *  " & _
        "(pedido_balcao_itens.preco - pedido_balcao_itens.preco *  " & _
        "(pedido_balcao_itens.desconto / 100))) AS total  " & _
        "FROM pedido_balcao_itens INNER JOIN  " & _
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " & _
        "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " & _
        "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " & _
        "+  " & _
        "isnull((SELECT sum(pedido_balcao_servicos.quant *  " & _
        "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " & _
        "(pedido_balcao_servicos.desconto / 100)))  " & _
        "AS total  " & _
        "FROM pedido_balcao_servicos INNER JOIN  " & _
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " & _
        "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " & _
        "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0))  " & _
        "as Total    " & _
        "FROM pedido_balcao INNER JOIN  " & _
        "status_pedido ON pedido_balcao.cod_status_pedido =  " & _
        "status_pedido.cod_status_pedido INNER JOIN  " & _
        "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario  " & _
        "WHERE (pedido_balcao.cod_filial_cliente =" & x_cod_filial_cliente & ") AND " & _
        "(pedido_balcao.cod_cliente = " & x_cod_cliente & ")" & _
        " ORDER BY pedido_balcao.data_pedido Desc"
        'd.carrega_Tabela(sql, tb)
        'grdPedidos.DataSource = tb
        'formata_grid()
    End Sub

    Private Sub formata_grid(ByVal tipo As Integer)
        'grdPedido.Rows.Clear()
        grdPedido.Columns.Clear()
        grdPedido.DataSource = Nothing
        grdPedido.AllowUserToAddRows = False
        grdPedido.AutoGenerateColumns = False
        Dim dtInicial As DateTime = dtIni.Value.ToShortDateString & " 00:00:01"
        Dim dtFinal As DateTime = dtFim.Value.ToShortDateString & " 23:59:59"

        Dim strSQL As String = ""

        If tipo = 1 Then
            strSQL = "SELECT * FROM faturamento_mensal() " & _
            "WHERE cod_cliente = " & CInt(txtCodigo.Text) & _
            " AND cod_status_pedido IN (1,2) AND Total > 0 AND Faturado = 0 AND id_filial = " & conf.Filial & _
            " ORDER BY data_pedido Desc"
        End If

        If tipo = 2 Then
            Dim strNome As String = txtCodigo.Text
            strSQL = "SELECT * FROM faturamento_mensal() " & _
            "WHERE nome_cliente like '%" & strNome & "%'" & _
            " AND cod_status_pedido IN (1,2) AND Total > 0 AND Faturado = 0 " & _
            " AND id_filial = " & conf.Filial & _
            " ORDER BY data_pedido Desc"
        End If

        If tipo = 3 Then
            strSQL = "SELECT * FROM faturamento_mensal() " & _
            "WHERE cod_cliente = " & CInt(txtCodigo.Text) & _
            " AND data_pedido >= " & d.pdtm(dtInicial) & " AND data_pedido <= " & d.pdtm(dtFinal) & _
            " AND cod_status_pedido IN (1,2) AND Total > 0 AND Faturado = 0 AND id_filial = " & conf.Filial & _
            " ORDER BY data_pedido Desc"
        End If

        If tipo = 4 Then
            Dim strNome As String = txtCodigo.Text
            strSQL = "SELECT * FROM faturamento_mensal() " & _
            "WHERE nome_cliente like '%" & strNome & "%'" & _
            " AND data_pedido >= " & d.pdtm(dtInicial) & " AND data_pedido <= " & d.pdtm(dtFinal) & _
            " AND cod_status_pedido IN (1,2) AND Total > 0 AND Faturado = 0 " & _
            " AND id_filial = " & conf.Filial & _
            " ORDER BY data_pedido Desc"
        End If

        Dim ttPedidos As New DataTable

        'Dim cmd As New SqlCommand(strSQL, d.con)
        'Dim dr As SqlDataReader

        Dim Filial As New DataGridViewTextBoxColumn 'Posição 00
        Filial.HeaderText = "Filial"
        Filial.DataPropertyName = "id_filial"
        Filial.Width = 30
        Filial.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Filial.ReadOnly = True
        grdPedido.Columns.Add(Filial)

        Dim faturado As New DataGridViewCheckBoxColumn 'Posição 01
        faturado.HeaderText = "Faturado"
        faturado.Width = 50
        grdPedido.Columns.Add(faturado)

        Dim numPedido As New DataGridViewTextBoxColumn 'Posição 02
        numPedido.HeaderText = "Pedido"
        numPedido.DataPropertyName = "num_pedido"
        numPedido.Width = 60
        numPedido.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        numPedido.ReadOnly = True
        grdPedido.Columns.Add(numPedido)

        Dim dataPedido As New DataGridViewTextBoxColumn 'Posição 03
        dataPedido.HeaderText = "Data Pedido"
        dataPedido.DataPropertyName = "data_pedido"
        dataPedido.Width = 90
        dataPedido.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dataPedido.DefaultCellStyle.Format = "dd/MM/yyyy"
        dataPedido.ReadOnly = True
        grdPedido.Columns.Add(dataPedido)

        Dim codFilialCliente As New DataGridViewTextBoxColumn 'Posição 04
        codFilialCliente.HeaderText = "Cod."
        codFilialCliente.DataPropertyName = "cod_filial_cliente"
        codFilialCliente.Width = 50
        codFilialCliente.ReadOnly = True
        codFilialCliente.Visible = False
        grdPedido.Columns.Add(codFilialCliente)

        Dim codigoCliente As New DataGridViewTextBoxColumn 'Posição 05
        codigoCliente.HeaderText = "Cod."
        codigoCliente.DataPropertyName = "cod_cliente"
        codigoCliente.Width = 50
        codigoCliente.ReadOnly = True
        codigoCliente.Visible = False
        grdPedido.Columns.Add(codigoCliente)

        Dim nomeCliente As New DataGridViewTextBoxColumn 'Posição 06
        nomeCliente.HeaderText = "Cliente"
        nomeCliente.DataPropertyName = "nome_cliente"
        nomeCliente.Width = 380
        nomeCliente.ReadOnly = True
        grdPedido.Columns.Add(nomeCliente)

        Dim statusPedido As New DataGridViewTextBoxColumn 'Posição 07
        statusPedido.HeaderText = "Staus Pedido"
        statusPedido.DataPropertyName = "status_pedido"
        statusPedido.Width = 150
        statusPedido.ReadOnly = True
        grdPedido.Columns.Add(statusPedido)

        Dim nomeVendedora As New DataGridViewTextBoxColumn 'Posição 08
        nomeVendedora.HeaderText = "Vendedor(a)"
        nomeVendedora.DataPropertyName = "nome"
        nomeVendedora.Width = 180
        nomeVendedora.ReadOnly = True
        grdPedido.Columns.Add(nomeVendedora)

        Dim produtos As New DataGridViewTextBoxColumn 'Posição 09
        produtos.HeaderText = "Produtos"
        produtos.DataPropertyName = "produtos"
        produtos.Width = 65
        produtos.ReadOnly = True
        produtos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        produtos.DefaultCellStyle.Format = "#,##0.00"
        grdPedido.Columns.Add(produtos)

        Dim servicos As New DataGridViewTextBoxColumn 'Posição 10
        servicos.HeaderText = "Serviços"
        servicos.DataPropertyName = "servicos"
        servicos.Width = 65
        servicos.ReadOnly = True
        servicos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        servicos.DefaultCellStyle.Format = "#,##0.00"
        grdPedido.Columns.Add(servicos)

        Dim total As New DataGridViewTextBoxColumn 'Posição 11
        total.HeaderText = "Total/Pagar"
        total.DataPropertyName = "total"
        total.Width = 65
        total.ReadOnly = True
        total.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        total.DefaultCellStyle.Format = "#,##0.00"
        grdPedido.Columns.Add(total)

        Dim numfatura As New DataGridViewTextBoxColumn 'Posição 12
        numfatura.HeaderText = "Fatura"
        numfatura.DataPropertyName = "fatura"
        numfatura.Width = 65
        numfatura.ReadOnly = True
        numfatura.Visible = False
        numfatura.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdPedido.Columns.Add(numfatura)

        Dim codstatuspedido As New DataGridViewTextBoxColumn 'Posição 13
        codstatuspedido.HeaderText = "Cod. Status Ped."
        codstatuspedido.DataPropertyName = "cod_status_pedido"
        codstatuspedido.Width = 40
        codstatuspedido.ReadOnly = True
        codstatuspedido.Visible = False
        grdPedido.Columns.Add(codstatuspedido)

        ttPedidos = caixa.retornaRegistro(strSQL).Tables(0)
        grdPedido.DataSource = ttPedidos

        If ttPedidos.Rows.Count = 0 Then
            MessageBox.Show("Registro não encontrado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            gbPedido.Enabled = False
            lblTotalItens.Visible = False
            lblTotalGeral.Visible = False
        End If

        If ttPedidos.Rows.Count > 0 Then
            grdPedido.SelectedRows(0).Selected = False
            grdPedido.Rows(0).Cells(1).Value = False
            gbPedido.Enabled = True
            lblTotalItens.Visible = True
            lblTotalGeral.Visible = True
            lblTotalItens.Text = "Total Itens: " & grdPedido.Rows.Count
            Dim TotalGeral As Double
            For Each linha As DataGridViewRow In grdPedido.Rows
                TotalGeral = TotalGeral + linha.Cells(11).Value
            Next
            lblTotalGeral.Text = "Total: " & Format(TotalGeral, "#,##0.00")
        End If
    End Sub

    Private Sub nova_fatura()
        fatura.novo()
        fatura.cod_filial_cliente = cod_filial_cliente
        fatura.cod_cliente = cod_cliente
        fatura.data_lancamento = Now
        fatura.id_filial = conf.Filial
        fatura.id_usuario = UserID
        MsgBox(fatura.Salvar())
    End Sub

    Private Sub grdPedido_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles grdPedido.CellFormatting, grdPedido.CellFormatting
        If (grdPedido.Rows(e.RowIndex).Cells(13).Value = 1) Then
            grdPedido.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            grdPedido.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        End If
        If (grdPedido.Rows(e.RowIndex).Cells(13).Value = 2) Then
            grdPedido.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            grdPedido.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        End If
        If (grdPedido.Rows(e.RowIndex).Cells(13).Value = 3) Then
            grdPedido.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            grdPedido.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        End If

        If (grdPedido.Rows(e.RowIndex).Cells(1).Value = 1) Then
            grdPedido.Rows(e.RowIndex).ReadOnly = True
        End If
    End Sub

    Private Sub grdPedido_DoubleClick(sender As System.Object, e As System.EventArgs) Handles grdPedido.DoubleClick
        Dim f As New frmPedido
        Dim intFilial As Integer = CInt(grdPedido.CurrentRow.Cells(0).Value)
        Dim numPedido As Integer = CInt(grdPedido.CurrentRow.Cells(2).Value)
        f._id_filial = intFilial
        f._num_pedido = numPedido
        f.ShowDialog()
    End Sub

    Private Sub DespesasAcumuladasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim intUsuario As Integer = caixa.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        If caixa.verifica_permissao_usuario(intUsuario, 43) = True Then
            Dim f As New frmDespesasAcumuladas
            f.Show()
        Else
            MessageBox.Show("Usuário sem permissão para acessar este módulo.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAtualizar_Click(sender As System.Object, e As System.EventArgs)
        formata_grid(1)
    End Sub

    Private Sub btnLocalizar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnLocalizar.Click
        If cbTudo.Checked = True Then
            If rgCodigo.Checked = True Then
                formata_grid(3)
            End If

            If rgNome.Checked = True Then
                formata_grid(4)
            End If
            Exit Sub
        End If

        If rgCodigo.Checked = True Then
            formata_grid(1)
        End If

        If rgNome.Checked = True Then
            formata_grid(2)
        End If
    End Sub

    Private Sub btnFaturar_Click(sender As System.Object, e As System.EventArgs) Handles btnFaturar.Click
        cod_filial = grdPedido.CurrentRow.Cells(0).Value
        cod_filial_cliente = grdPedido.CurrentRow.Cells(4).Value
        cod_cliente = grdPedido.CurrentRow.Cells(5).Value
        strNome = grdPedido.CurrentRow.Cells(6).Value

        For Each Item As DataGridViewRow In grdPedido.Rows
            If Item.Cells(1).Value = True Then
                If strNome = Item.Cells(6).Value Then
                Else
                    MessageBox.Show("Sistema não permite lançar pedidos de clientes diferentes" & Chr(13) & "dentro de uma mesma fatura.", "INFORMAÇÃO", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        Next

        If (grdPedido.CurrentRow.Cells(1).Value = True) Or (grdPedido.CurrentRow.Cells(7).Value = "Em Aberto") Or (grdPedido.CurrentRow.Cells(7).Value = "Processado no Estoque") Then
            nova_fatura()
        Else
            MessageBox.Show("Selecione o(s) pedido(s) a ser(em) faturado(s).", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'nova_fatura()

        For Each strLinha As DataGridViewRow In grdPedido.Rows
            If (strLinha.Cells(1).Value = True) And (strLinha.Cells(7).Value <> "Pago Parcialmente") Then
                fatura.insere_itens_fatura(strLinha.Cells(2).Value, strLinha.Cells(0).Value)

                'Instrução SQL que busca a exisitência de um determinado registro
                Dim strSQL As String = "select * from pedidos where num_pedido = " & strLinha.Cells(2).Value & " and id_filial = " & _
                strLinha.Cells(0).Value & " and cod_cliente = " & strLinha.Cells(5).Value

                If caixa.verifica_existencia_registro(strSQL) = False Then 'Caso o registro não exista, a instrução seguinte é executada.
                    Dim strSQLInsert As String = "insert into pedidos(num_pedido, id_filial, cod_cliente, cod_status_pedido) values(" & _
                    strLinha.Cells(2).Value & "," & strLinha.Cells(0).Value & "," & strLinha.Cells(5).Value & "," & strLinha.Cells(13).Value & ")"
                    caixa.grava_registros(strSQLInsert, True)
                End If
            End If
        Next

        Dim ttTipo As New DataTable
        Dim strSQLTipo As String = "select cod_tipo_cliente from cliente where cod_cliente = " & cod_cliente & " and cod_filial_cliente = " & cod_filial_cliente
        ttTipo = caixa.retornaRegistro(strSQLTipo).Tables(0)

        Dim f As New frmFatura
        f.lblCliente.Text = cod_filial_cliente & "-" & cod_cliente & " - " & strNome
        f.lblFilial.Text = cod_filial
        f.lblFatura.Text = fatura.cod_fatura
        f.intTipoCliente = ttTipo.Rows(0)("cod_tipo_cliente")
        f.ShowDialog(Me)
        Call btnLocalizar_Click_1(sender, e)
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Dim f As New frmFatura
        Dim intFilial As Integer = InputBox("Digite o nº da filial", "Filial", 1)
        f.user = user
        f.abre_fatura(InputBox("Nº da Fatura:"), intFilial)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub rgNome_Click(sender As System.Object, e As System.EventArgs) Handles rgNome.Click
        gbDados.Width = 499
        txtCodigo.Width = 240
        btnLocalizar.Location = New System.Drawing.Point(404, 10)
        GroupBox2.Location = New System.Drawing.Point(525, 38)
        txtCodigo.Text = ""
        txtCodigo.Focus()
    End Sub

    Private Sub rgCodigo_Click(sender As System.Object, e As System.EventArgs) Handles rgCodigo.Click
        gbDados.Width = 330
        txtCodigo.Width = 80
        btnLocalizar.Location = New System.Drawing.Point(237, 10)
        GroupBox2.Location = New System.Drawing.Point(356, 38)
        txtCodigo.Text = ""
        txtCodigo.Focus()
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Dim f As New frmRpt
        Dim r As New rptFaturaClienteMes
        r.DataSource = faturamento_mes()
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Function faturamento_mes() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "select cod_cliente,nome_cliente, status_pedido  from faturamento_mensal() " & _
            "where cod_cliente > 1000 and Total > 0 And id_filial = " & conf.Filial & " AND cod_status_pedido IN (1,2) " & _
            "group by cod_cliente, nome_cliente, status_pedido"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function


    Private Sub txtCodigo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If rgCodigo.Checked = True Then
            If Not IsNumeric(e.KeyChar) And (Not e.KeyChar = vbBack) And (Not e.KeyChar = Convert.ToChar(Keys.Return)) Then
                e.Handled = True
                MessageBox.Show("Campo só permite valor númerico.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub cbTudo_Click(sender As System.Object, e As System.EventArgs) Handles cbTudo.Click
        If cbTudo.Checked = True Then
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Dim fc As New frmCliente_Old
        fc.txtCodCliente.Text = CInt(txtCodigo.Text)
        fc.Show()
    End Sub

    Private Sub grdPedido_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles grdPedido.SelectionChanged
        If intControle = 1 Then
            intTotalItens = 0
            TotalGeralItensSel = 0
            TotalGeralItens = 0
            For Each linha As DataGridViewRow In grdPedido.Rows
                If linha.Selected = True Then
                    If linha.Cells(1).Value = False Then
                        linha.Cells(1).Value = True
                    End If
                End If

                If linha.Cells(1).Value = True Then
                    intTotalItens = intTotalItens + 1
                    TotalGeralItensSel = TotalGeralItensSel + linha.Cells(11).Value
                End If
                TotalGeralItens = Format(TotalGeralItens + linha.Cells(11).Value, "#,##0.00")
            Next
            lblTotalItens.Text = "Total Itens: " & intTotalItens & " / " & grdPedido.Rows.Count
            lblTotalGeral.Text = "Total: " & Format(TotalGeralItensSel, "#,##0.00") & " / " & Format(TotalGeralItens, "#,##0.00")
        End If
    End Sub


    Private Sub txtPedido_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPedido.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim strPedido As String
                If txtPedido.Text.Length > 7 Then
                    strPedido = txtPedido.Text.Substring(7, 7)
                Else
                    strPedido = txtPedido.Text
                End If

                txtPedido.Text = CInt(strPedido)
                intTotalItens = 0
                TotalGeralItens = 0
                TotalGeralItensSel = 0

                For Each linha As DataGridViewRow In grdPedido.Rows
                    If linha.Cells(1).Value = True Then
                        If txtPedido.Text = CInt(linha.Cells(2).Value) Then
                            MessageBox.Show("Pedido já foi selecionado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If

                    If CInt(linha.Cells(2).Value) = CInt(txtPedido.Text) Then
                        linha.Cells(1).Value = True
                        linha.Selected = True
                        grdPedido.CurrentCell = grdPedido.Rows(linha.Index).Cells(1)
                        If intControle = 1 Then
                            intTotalItens = intTotalItens - 1
                        End If
                        'intTotalItens = intTotalItens + 1
                        'TotalGeralItensSel = TotalGeralItensSel + linha.Cells(11).Value
                    End If

                    If linha.Cells(1).Value = True Then
                        intTotalItens = intTotalItens + 1
                        TotalGeralItensSel = TotalGeralItensSel + linha.Cells(11).Value
                    End If

                    TotalGeralItens = Format(TotalGeralItens + linha.Cells(11).Value, "#,##0.00")
                Next
                txtPedido.Text = ""
                txtPedido.Focus()
                lblTotalItens.Text = "Total Itens: " & intTotalItens & " / " & grdPedido.Rows.Count
                lblTotalGeral.Text = "Total: " & Format(TotalGeralItensSel, "#,##0.00") & " / " & Format(TotalGeralItens, "#,##0.00")
        End Select
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
        Dispose()
    End Sub

    Private Sub txtCodigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim strCodigo As String = txtCodigo.Text

                If strCodigo.Length > 5 Then
                    txtCodigo.Text = strCodigo.Substring(2, 5)
                Else
                    txtCodigo.Text = strCodigo
                End If

                Call btnLocalizar_Click_1(sender, e)
                txtPedido.Focus()
        End Select
    End Sub

    Private Sub grdPedido_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPedido.CellClick
        intControle = 1
        intTotalItens = 0
        TotalGeralItensSel = 0
        TotalGeralItens = 0
        grdPedido.SelectedRows(0).Cells(1).Value = True
        For Each linha As DataGridViewRow In grdPedido.Rows
            If linha.Cells(1).Value = True Then
                intTotalItens = intTotalItens + 1
                TotalGeralItensSel = TotalGeralItensSel + linha.Cells(11).Value
            End If
            TotalGeralItens = Format(TotalGeralItens + linha.Cells(11).Value, "#,##0.00")
        Next
        lblTotalItens.Text = "Total Itens: " & intTotalItens & " / " & grdPedido.Rows.Count
        lblTotalGeral.Text = "Total: " & Format(TotalGeralItensSel, "#,##0.00") & " / " & Format(TotalGeralItens, "#,##0.00")
    End Sub
End Class