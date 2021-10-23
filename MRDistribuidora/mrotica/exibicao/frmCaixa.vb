Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Imports MRUtil

Public Class frmCaixa
    Dim d As New dados
    Dim conexao As New ConexaoDB()
    Dim UsuarioPermissao As New UsuarioPermissao()
    Dim CaixaNovo As Caixa
    'Public user As objUsuario
    Dim conf As New Arquivo
    Dim caixa As New objMaster
    Public ttRes As New DataTable
    Dim tb As New DataTable
    Dim id As Integer
    Dim fatura As New objFatura
    Dim Seguranca As New objSecurity
    'Variáveis acrescentadas por Ivanildo 05/12/2012
    Public cod_filial As Integer
    Public cod_filial_cliente As Integer
    Public cod_cliente As Integer
    Public strNome As String
    Dim intTotalItens As Integer
    Dim TotalGeralItens As Double
    Dim TotalGeralItensSel As Double
    Dim intControle As Int16
    Dim intUsuario As Integer

    Private Sub btnAbrirFatura_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAbrirFatura.Click
        Dim f As New frmFatura
        f.user = user
        f.abre_fatura(InputBox("Nº da Fatura:"), conf.Filial)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub btnDespesa_Click(sender As System.Object, e As System.EventArgs) Handles btnDespesa.Click
        Dim f As New frmDespesas
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub btnOutrasDespesas_Click(sender As System.Object, e As System.EventArgs) Handles btnOutrasDespesas.Click
        Dim f As New frmOutrasEntradas
        f.Show()
    End Sub

    Private Sub btnRelDespesas_Click(sender As System.Object, e As System.EventArgs) Handles btnRelDespesas.Click
        Dim f As New frmRpt
        Dim r As New rptDespesas
        Dim lanc As New objLancamentos
        Dim fdata As New frmDataCaixa
        fdata.ShowDialog()

        r.diai = fdata.dtIni.Value
        r.diaf = fdata.dtFim.Value
        r.DataSource = lanc.listar_despesas_data(fdata.dtIni.Value, fdata.dtFim.Value, conf.Filial)
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub btnRelRecFat_Click(sender As System.Object, e As System.EventArgs) Handles btnRelRecFat.Click
        Dim f As New frmRpt
        Dim r As New rptRecebimentosDia
        Dim lanc As New objLancamentos
        Dim Lancamento As New Lancamento
        Dim fdata As New frmDataCaixa
        fdata.ShowDialog()

        r.diai = fdata.dtIni.Value
        r.DataSource = Lancamento.ListarReceitasData(fdata.dtIni.Value.ToShortDateString(), fdata.dtFim.Value.ToShortDateString(), conf.Filial) 'lanc.listar_receitas_data(fdata.dtIni.Value, fdata.dtFim.Value, conf.Filial)
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub btnVendasDia_Click(sender As System.Object, e As System.EventArgs) Handles btnVendasDia.Click
        Dim f As New frmRpt
        Dim r As New rptPedidos_balcao
        Dim ped As New objPedidoBalcao
        Dim fdata As New frmDataCaixa
        fdata.ShowDialog()

        r.dia = fdata.dtIni.Value
        r.DataSource = ped.lista_pedidos_dia_labo(fdata.dtIni.Value, conf.Filial)
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub RelCaixa_Click(sender As System.Object, e As System.EventArgs) Handles RelCaixa.Click
        Dim fdata As New frmDataCaixa
        fdata.ShowDialog()
        If fdata.dtIni.Value.ToShortDateString > fdata.dtFim.Value.ToShortDateString Then
            MessageBox.Show("Data inicial não pode ser maior que a data final.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            fdata.dtIni.Focus()
            Exit Sub
        End If
        Dim f As New frmRpt
        Dim r As New rptCaixa
        Dim rr As New rptCaixaResumo
        r.diai = fdata.dtIni.Value.ToShortDateString
        r.diaf = fdata.dtFim.Value.ToShortDateString
        rr.diai = fdata.dtIni.Value.ToShortDateString
        rr.diaf = fdata.dtFim.Value.ToShortDateString

        r.intFilial = conf.Filial
        rr.intFilial = conf.Filial

        f.Relat(r)
        f.ShowDialog(Me)
        f.Relat(rr)
        f.ShowDialog(Me)

        f.Dispose()
        fdata.Dispose()
    End Sub


    Private Sub VendasDiaSintéticoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VendasDiaSintéticoToolStripMenuItem.Click
        Dim sql As String
        Dim f As New frmRpt
        Dim r As New rptVendasSintetico
        Dim tt As New DataTable
        Dim fdata As New frmDataCaixa
        fdata.ShowDialog()

        sql = "Select * from pedido_balcao where cod_cliente > 1000 " &
        "and (data_pedido >= " & d.pdtm(fdata.dtIni.Value.Date & " 00:00:00") &
        "and data_pedido <=" & d.pdtm(fdata.dtIni.Value.Date & " 23:59:59") &
        ") order by cod_cliente"
        d.carrega_Tabela(sql, tt)
        r.DataSource = tt
        r.dia = fdata.dtIni.Value
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub habilita_botoes()
        btnAbrirCaixa.Enabled = False
        gbDados.Visible = True
        btnAtualiza.Visible = True
        btnGerarFatura.Visible = True
        btnAbrirFatura.Enabled = True
        btnAbrePedido.Enabled = True
        btnCliente.Enabled = True
        btnEstorno.Enabled = True
        btnDespesa.Enabled = True
        btnOutrasDespesas.Enabled = True
        btnRelatorios.Enabled = True
        btnFecharCaixa.Enabled = True
    End Sub

    Private Sub desabilita_botoes()
        btnAbrirCaixa.Enabled = True
        gbDados.Visible = False
        btnAtualiza.Visible = False
        btnGerarFatura.Visible = False
        btnAbrirFatura.Enabled = False
        btnAbrePedido.Enabled = False
        btnCliente.Enabled = False
        btnEstorno.Enabled = False
        btnDespesa.Enabled = False
        btnOutrasDespesas.Enabled = False
        btnRelatorios.Enabled = False
        btnFecharCaixa.Enabled = False
        lblDataCaixa.Text = ""
    End Sub

    Private Sub btnAbrirCaixa_Click(sender As System.Object, e As System.EventArgs) Handles btnAbrirCaixa.Click
        pnCaixa.Visible = True
        txtDataAbertura.Focus()
    End Sub

    Private Sub frmCaixa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'intUsuario = caixa.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        CaixaNovo = New Caixa()
        UsuarioPermissao.RetornaRegistro(frmMain.intCodigoUsuario)

        If caixa.retornaSituacaoCaixa(conf.Filial) = True Then
            habilita_botoes()
            lblDataCaixa.Visible = True
            lblDataCaixa.Text = "Caixa aberto do dia: " & caixa.retornaDataCaixaAberto(conf.Filial)
            gbDados.Location = New System.Drawing.Point(896, 50)
            gbDados.Visible = True
            grdCaixa.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label5.Text = frmMain.intCodigoUsuario
            'carrega_pedidos(1, 10413)
            formata_grid(1)
        Else
            desabilita_botoes()
        End If
    End Sub

    Private Sub btnFecharCaixa_Click(sender As System.Object, e As System.EventArgs) Handles btnFecharCaixa.Click
        Try
            If MessageBox.Show("Deseja realmente fechar o caixa?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                grdCaixa.Visible = False
                gbDados.Visible = False
                pnFechaCaixa.Visible = True
                txtDinheiro.Text = "0,00"
                txtCartaoCredito.Text = "0,00"
                txtCartaoDebito.Text = "0,00"
                txtCheque.Text = "0,00"
                txtBoleto.Text = "0,00"
                txtOutro.Text = "0,00"
                txtDinheiro.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        pnCaixa.Visible = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim teste As Integer = UsuarioPermissao.Perfil
        Try
            If UsuarioPermissao.VerificaUsuarioLogado(CInt(txtCodGerente.Text), txtSenhaGerente.Text, 5) = True Then
                If Geral.TelaAviso("Deseja realmente abrir o caixa?", "INFORMAÇÃO", Me, Belemtech.TipoAviso.SIMNAO, Belemtech.ImagemAviso.Informacao) = Belemtech.Respo.SIM Then
                    CaixaNovo.Novo()
                    'Label5.Text = frmMain.intCodigoUsuario
                    CaixaNovo.CaixaUsuario = UsuarioPermissao.CodigoUsuario
                    CaixaNovo.Situacao = "A"
                    CaixaNovo.ValorInicial = Convert.ToDecimal(txtSaldoInicial.Text)
                    CaixaNovo.UsuarioAbertura = Convert.ToInt32(txtCodGerente.Text)
                    CaixaNovo.CodigoFilial = conf.Filial

                    If CaixaNovo.SalvaCaixa() = True Then
                        pnCaixa.Visible = False
                        lblDataCaixa.Location = New System.Drawing.Point(18, 45)
                        lblDataCaixa.Visible = True
                        lblDataCaixa.Text = "Caixa aberto do dia: " & caixa.retornaDataCaixaAberto(conf.Filial)
                        Label3.Visible = True
                        Label3.Text = "CAIXA:"
                        Label5.Visible = True
                        grdCaixa.Visible = True
                        habilita_botoes()
                        txtDataAbertura.Text = ""
                        txtSaldoInicial.Text = ""
                        txtCodGerente.Text = ""
                        txtSenhaGerente.Text = ""
                        formata_grid(1)
                    End If

                End If
            Else
                MessageBox.Show("Senha de gerente fornecida, não corresponde " & Chr(13) & "a uma senha válida de gerente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If (txtCodGerente2.Text = "") Or (txtSenhaGerente2.Text = "") Then
            MessageBox.Show("Código ou senha de gerente estão em branco.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim intUsuario As Integer = CInt(txtCodGerente2.Text)
        Dim vDinheiro As Double = CDbl(txtDinheiro.Text)
        Dim vCredito As Double = CDbl(txtCartaoCredito.Text)
        Dim vDebito As Double = CDbl(txtCartaoDebito.Text)
        Dim vCheque As Double = CDbl(txtCheque.Text)
        Dim vBoleto As Double = CDbl(txtBoleto.Text)
        Dim vOutro As Double = CDbl(txtOutro.Text)
        Dim vTotal As Double = CDbl(vDinheiro) + CDbl(vCredito) + CDbl(vDebito) + CDbl(vCheque) + CDbl(vBoleto) + CDbl(vOutro)

        Try
            If caixa.verifica_Gerente(CInt(txtCodGerente2.Text), Seguranca.EncryptText(txtSenhaGerente2.Text)) = True Then
                Dim data As DateTime = Convert.ToDateTime((lblDataCaixa.Text.Substring(21, 10)))
                caixa.atualiza_status_caixa(data, conf.Filial, vTotal, vDinheiro, vCredito, vDebito, vCheque, vBoleto, vOutro, intUsuario, conf.Filial)
                desabilita_botoes()
                Label3.Text = ""
                Label5.Text = ""
                MessageBox.Show("Caixa fechado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                pnFechaCaixa.Visible = False
                Relatorio_Caixa_Dia(data)
            Else
                MessageBox.Show("Senha de gerente fornecida, não corresponde " & Chr(13) & "a uma senha válida de gerente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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

    Private Sub txtCodGerente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodGerente.KeyPress
        If Not Char.IsNumber(e.KeyChar) And (Not e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSaldoInicial_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSaldoInicial.KeyPress
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

    Private Sub txtSaldoInicial_Leave(sender As System.Object, e As System.EventArgs) Handles txtSaldoInicial.Leave
        txtSaldoInicial.Text = caixa.formataValorMoeda(CDbl(txtSaldoInicial.Text))
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        gbDados.Visible = True
        pnFechaCaixa.Visible = False
        grdCaixa.Visible = True
        txtCodGerente2.Text = ""
        txtSenhaGerente2.Text = ""
    End Sub

    Private Sub Relatorio_Caixa_Dia(ByVal data As Date)
        Dim f As New frmRpt
        Dim r As New rptCaixa
        r.diai = data
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Public Sub carrega_pedidos(ByVal x_cod_filial_cliente As Integer, ByVal x_cod_cliente As Integer)
        Dim sql As String
        sql = "SELECT top(100) pedido_balcao.id_filial, pedido_balcao.num_pedido, " &
        "pedido_balcao.data_pedido, pedido_balcao.cod_status_pedido, " &
        "status_pedido.Status_pedido, Usuarios.NOME,  " &
        "(SELECT count(item) as itens FROM fatura_itens  " &
        "WHERE (num_pedido = pedido_balcao.num_pedido) AND  " &
        "(id_filial_pedido =pedido_balcao.id_filial)) as  " &
        "Faturado," &
        "isnull((SELECT sum(pedido_balcao_itens.quant *  " &
        "(pedido_balcao_itens.preco - pedido_balcao_itens.preco *  " &
        "(pedido_balcao_itens.desconto / 100))) AS total  " &
        "FROM pedido_balcao_itens INNER JOIN  " &
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " &
        "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " &
        "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " &
        "AS Produtos,  " &
        "isnull((SELECT sum(pedido_balcao_servicos.quant *  " &
        "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " &
        "(pedido_balcao_servicos.desconto / 100))) AS total  " &
        "FROM pedido_balcao_servicos INNER JOIN  " &
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " &
        "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " &
        "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0)  " &
        "as servicos,  " &
        "(isnull((SELECT sum(pedido_balcao_itens.quant *  " &
        "(pedido_balcao_itens.preco - pedido_balcao_itens.preco *  " &
        "(pedido_balcao_itens.desconto / 100))) AS total  " &
        "FROM pedido_balcao_itens INNER JOIN  " &
        "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto  " &
        "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND  " &
        "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0)  " &
        "+  " &
        "isnull((SELECT sum(pedido_balcao_servicos.quant *  " &
        "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco *  " &
        "(pedido_balcao_servicos.desconto / 100)))  " &
        "AS total  " &
        "FROM pedido_balcao_servicos INNER JOIN  " &
        "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto  " &
        "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND  " &
        "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0))  " &
        "as Total    " &
        "FROM pedido_balcao INNER JOIN  " &
        "status_pedido ON pedido_balcao.cod_status_pedido =  " &
        "status_pedido.cod_status_pedido INNER JOIN  " &
        "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario  " &
        "WHERE (pedido_balcao.cod_filial_cliente =" & x_cod_filial_cliente & ") AND " &
        "(pedido_balcao.cod_cliente = " & x_cod_cliente & ")" &
        " ORDER BY pedido_balcao.data_pedido Desc"
        'd.carrega_Tabela(sql, tb)
        'grdPedidos.DataSource = tb
        'formata_grid()
    End Sub

    Private Sub formata_grid(ByVal tipo As Integer)
        grdCaixa.Columns.Clear()
        grdCaixa.DataSource = Nothing
        grdCaixa.AllowUserToAddRows = False
        grdCaixa.AutoGenerateColumns = False

        Dim strSQL As String = ""
        Dim dtInicio As String = ""

        If tipo = 1 Then
            dtDifDias = DateAdd(DateInterval.Day, -30, Now.Date)
            dtInicio = d.pdtm(Convert.ToDateTime(dtDifDias & " 00:00:00"))
            dtFinal = d.pdtm((Now.Day) & "/" & (Now.Month) & "/" & Now.Year & " 23:59:59")

            strSQL = "SELECT * FROM faturamento_mensal() WHERE data_pedido >= " & dtInicio & "" &
                    " AND data_pedido <= " & dtFinal & "" &
                    " AND cod_status_pedido IN (1,5) AND id_filial = " & conf.Filial &
                    " AND Total > 0 ORDER BY data_pedido Desc"
        End If

        If tipo = 2 Then
            Dim intPedido As Integer = CInt(txtDataIni.Text)
            strSQL = "SELECT * FROM faturamento_mensal() WHERE num_pedido = " & intPedido & " AND COD_CLIENTE > 1000 AND cod_status_pedido IN (1,2,3,5)" &
                      " AND id_filial = " & conf.Filial & " AND Total > 0 ORDER BY data_pedido Desc"
        End If

        If tipo = 3 Then
            strSQL = "SELECT * FROM faturamento_mensal() WHERE cod_cliente = " & CInt(txtDataIni.Text) &
                       " AND COD_CLIENTE > 1000 AND cod_status_pedido IN (1,2,3,5) AND id_filial = " & conf.Filial &
                      " AND Total > 0 ORDER BY data_pedido Desc"
        End If


        If tipo = 4 Then
            dtInicio = txtDataIni.Text
            trSQL = "SELECT * FROM faturamento_mensal() WHERE nome_cliente like '%" & dtInicio & "%'" &
                  " AND COD_CLIENTE > 1000 AND cod_status_pedido IN (1,2,3,5) AND id_filial = " & conf.Filial &
                  " AND Total > 0 ORDER BY data_pedido Desc"
        End If

        Dim ttPedido As New DataTable

        Dim Filial As New DataGridViewTextBoxColumn 'Posição 00
        Filial.HeaderText = "Filial"
        Filial.DataPropertyName = "id_filial"
        Filial.Width = 30
        Filial.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Filial.ReadOnly = True
        grdCaixa.Columns.Add(Filial)

        Dim faturado As New DataGridViewCheckBoxColumn 'Posição 01
        faturado.HeaderText = "Faturado"
        faturado.Width = 50
        grdCaixa.Columns.Add(faturado)

        Dim numPedido As New DataGridViewTextBoxColumn 'Posição 02
        numPedido.HeaderText = "Pedido"
        numPedido.DataPropertyName = "num_pedido"
        numPedido.Width = 60
        numPedido.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        numPedido.ReadOnly = True
        grdCaixa.Columns.Add(numPedido)

        Dim dataPedido As New DataGridViewTextBoxColumn 'Posição 03
        dataPedido.HeaderText = "Data Pedido"
        dataPedido.DataPropertyName = "data_pedido"
        dataPedido.Width = 90
        dataPedido.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dataPedido.DefaultCellStyle.Format = "dd/MM/yyyy"
        dataPedido.ReadOnly = True
        grdCaixa.Columns.Add(dataPedido)

        Dim codFilialCliente As New DataGridViewTextBoxColumn 'Posição 04
        codFilialCliente.HeaderText = "Cod."
        codFilialCliente.DataPropertyName = "cod_filial_cliente"
        codFilialCliente.Width = 50
        codFilialCliente.ReadOnly = True
        codFilialCliente.Visible = False
        grdCaixa.Columns.Add(codFilialCliente)

        Dim codigoCliente As New DataGridViewTextBoxColumn 'Posição 05
        codigoCliente.HeaderText = "Cod."
        codigoCliente.DataPropertyName = "cod_cliente"
        codigoCliente.Width = 50
        codigoCliente.ReadOnly = True
        codigoCliente.Visible = False
        grdCaixa.Columns.Add(codigoCliente)

        Dim nomeCliente As New DataGridViewTextBoxColumn 'Posição 06
        nomeCliente.HeaderText = "Cliente"
        nomeCliente.DataPropertyName = "nome_cliente"
        nomeCliente.Width = 370
        nomeCliente.ReadOnly = True
        grdCaixa.Columns.Add(nomeCliente)

        Dim statusPedido As New DataGridViewTextBoxColumn 'Posição 07
        statusPedido.HeaderText = "Staus Pedido"
        statusPedido.DataPropertyName = "status_pedido"
        statusPedido.Width = 150
        statusPedido.ReadOnly = True
        grdCaixa.Columns.Add(statusPedido)

        Dim nomeVendedora As New DataGridViewTextBoxColumn 'Posição 08
        nomeVendedora.HeaderText = "Vendedor(a)"
        nomeVendedora.DataPropertyName = "nome"
        nomeVendedora.Width = 190
        nomeVendedora.ReadOnly = True
        grdCaixa.Columns.Add(nomeVendedora)

        Dim produtos As New DataGridViewTextBoxColumn 'Posição 09
        produtos.HeaderText = "Produtos"
        produtos.DataPropertyName = "produtos"
        produtos.Width = 65
        produtos.ReadOnly = True
        produtos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        produtos.DefaultCellStyle.Format = "#,##0.00"
        grdCaixa.Columns.Add(produtos)

        Dim servicos As New DataGridViewTextBoxColumn 'Posição 10
        servicos.HeaderText = "Serviços"
        servicos.DataPropertyName = "servicos"
        servicos.Width = 65
        servicos.ReadOnly = True
        servicos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        servicos.DefaultCellStyle.Format = "#,##0.00"
        grdCaixa.Columns.Add(servicos)

        Dim total As New DataGridViewTextBoxColumn 'Posição 11
        total.HeaderText = "Total/Pagar"
        total.DataPropertyName = "total"
        total.Width = 65
        total.ReadOnly = True
        total.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        total.DefaultCellStyle.Format = "#,##0.00"
        grdCaixa.Columns.Add(total)

        Dim valorpago As New DataGridViewTextBoxColumn 'Posição 12
        valorpago.HeaderText = "Pago"
        valorpago.DataPropertyName = "valor_pago"
        valorpago.Width = 65
        valorpago.ReadOnly = True
        valorpago.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        valorpago.DefaultCellStyle.Format = "#,##0.00"
        grdCaixa.Columns.Add(valorpago)

        Dim valorapagar As New DataGridViewTextBoxColumn 'Posição 13
        valorapagar.HeaderText = "A Pagar"
        valorapagar.DataPropertyName = "valor_apagar"
        valorapagar.Width = 68
        valorapagar.ReadOnly = True
        valorapagar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        valorapagar.DefaultCellStyle.Format = "#,##0.00"
        grdCaixa.Columns.Add(valorapagar)

        Dim numfatura As New DataGridViewTextBoxColumn 'Posição 14
        numfatura.HeaderText = "Fatura"
        numfatura.DataPropertyName = "fatura"
        numfatura.Width = 65
        numfatura.ReadOnly = True
        numfatura.Visible = False
        numfatura.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdCaixa.Columns.Add(numfatura)

        Dim codstatuspedido As New DataGridViewTextBoxColumn 'Posição 15
        codstatuspedido.HeaderText = "Cod. Status Ped."
        codstatuspedido.DataPropertyName = "cod_status_pedido"
        codstatuspedido.Visible = False
        grdCaixa.Columns.Add(codstatuspedido)

        Dim formacompra As New DataGridViewTextBoxColumn 'Posição 16
        formacompra.HeaderText = "Forma"
        formacompra.DataPropertyName = "forma"
        formacompra.Visible = False
        grdCaixa.Columns.Add(formacompra)

        Dim fatura As New DataGridViewTextBoxColumn 'Posição 17
        fatura.HeaderText = "Faturado"
        fatura.DataPropertyName = "faturado"
        fatura.Visible = False
        grdCaixa.Columns.Add(fatura)

        'Dim faturapago As New DataGridViewTextBoxColumn 'Posição 18
        'faturapago.HeaderText = "Fatura Pago"
        'faturapago.DataPropertyName = "fatura_pago"
        'faturapago.Visible = False
        'grdCaixa.Columns.Add(faturapago)

        ttPedido = caixa.retornaRegistro(strSQL).Tables(0)

        grdCaixa.DataSource = ttPedido

        If ttPedido.Rows.Count = 0 Then
            'MessageBox.Show("Registro não encontrado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            grdCaixa.Enabled = False
            lblTotalItens.Visible = False
            lblTotalGeral.Visible = False
        End If


        If ttPedido.Rows.Count > 0 Then
            grdCaixa.SelectedRows(0).Selected = False
            grdCaixa.Rows(0).Cells(1).Value = False
            grdCaixa.Enabled = True
            lblTotalItens.Visible = True
            lblTotalGeral.Visible = True
            lblTotalItens.Text = "Total Itens: " & grdCaixa.Rows.Count
            Dim TotalGeral As Double
            For Each linha As DataGridViewRow In grdCaixa.Rows
                TotalGeral = TotalGeral + linha.Cells(11).Value
            Next
            lblTotalGeral.Text = "Total: " & Format(TotalGeral, "#,##0.00")
        End If

        For Each linha As DataGridViewRow In grdCaixa.Rows
            If (linha.Cells(15).Value = 5) Or (linha.Cells(17).Value = 1) Then
                linha.Cells(1).Value = True
            End If
        Next
    End Sub


    Private Sub nova_fatura()
        fatura.novo()
        fatura.cod_filial_cliente = cod_filial_cliente
        fatura.cod_cliente = cod_cliente
        fatura.data_lancamento = Now
        fatura.id_filial = conf.Filial
        fatura.id_usuario = UserID
        fatura.Salvar()
    End Sub

    Private Sub grdPedido_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles grdCaixa.CellFormatting
        If grdCaixa.Rows(e.RowIndex).Cells(15).Value = 3 Then
            grdCaixa.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Green
            grdCaixa.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
            grdCaixa.Rows(e.RowIndex).Cells(1).ReadOnly = True
        ElseIf grdCaixa.Rows(e.RowIndex).Cells(15).Value = 1 Then
            grdCaixa.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            grdCaixa.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        ElseIf grdCaixa.Rows(e.RowIndex).Cells(15).Value = 5 Then
            grdCaixa.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
            grdCaixa.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            grdCaixa.Rows(e.RowIndex).Cells(1).ReadOnly = True
        ElseIf (grdCaixa.Rows(e.RowIndex).Cells(15).Value = 2) And (grdCaixa.Rows(e.RowIndex).Cells(17).Value = 1) Then
            grdCaixa.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.CadetBlue
            grdCaixa.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
            grdCaixa.Rows(e.RowIndex).Cells(1).ReadOnly = True
        ElseIf grdCaixa.Rows(e.RowIndex).Cells(15).Value = 2 Then
            grdCaixa.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.CadetBlue
            grdCaixa.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        End If
    End Sub

    Private Sub grdPedido_DoubleClick(sender As System.Object, e As System.EventArgs) Handles grdCaixa.DoubleClick
        cod_filial_cliente = grdCaixa.CurrentRow.Cells(4).Value
        cod_cliente = grdCaixa.CurrentRow.Cells(5).Value
        strNome = grdCaixa.CurrentRow.Cells(6).Value

        If grdCaixa.CurrentRow.Cells(14).Value Is DBNull.Value Then
            MessageBox.Show("Este pedido ainda não foi faturado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim f As New frmFatura
        Dim numfatura As Integer = CInt(grdCaixa.CurrentRow.Cells(14).Value)
        Dim numfilial As Integer = CInt(grdCaixa.CurrentRow.Cells(0).Value)
        f.lblCliente.Text = cod_filial_cliente & "-" & cod_cliente & " - " & strNome

        f.abre_fatura(numfatura, numfilial)
        f.ShowDialog()
    End Sub

    Private Sub grdPedido_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles grdCaixa.KeyDown
        cod_filial_cliente = grdCaixa.CurrentRow.Cells(4).Value
        cod_cliente = grdCaixa.CurrentRow.Cells(5).Value
        strNome = grdCaixa.CurrentRow.Cells(6).Value

        If grdCaixa.CurrentRow.Cells(14).Value = Nothing Then
            MessageBox.Show("Pedido ainda não faturado e nem com pendência financeira." & Chr(13) & "Selecione o registro para ser faturado.",
                            "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim f As New frmFatura
        Dim numfatura As Integer = CInt(grdCaixa.CurrentRow.Cells(14).Value)
        Dim numfilial As Integer = CInt(grdCaixa.CurrentRow.Cells(0).Value)
        f.lblCliente.Text = cod_filial_cliente & "-" & cod_cliente & " - " & strNome

        f.abre_fatura(numfatura, numfilial)
        f.ShowDialog()
    End Sub




    Private Sub rgPedido_Click(sender As System.Object, e As System.EventArgs) Handles rgPedido.Click
        If rgPedido.Checked = True Then
            gbDados.Width = 425
            gbDados.Location = New System.Drawing.Point(896, 50)
            lblInicio.Visible = False
            txtDataIni.Location = New System.Drawing.Point(230, 18)
            txtDataIni.Width = 80
            txtDataIni.Text = ""
            txtDataIni.Focus()
            lblFim.Visible = False
            btnLocalizar.Location = New System.Drawing.Point(336, 11)
            formata_grid(1)
        End If
    End Sub


    Private Sub btnLocalizar_Click(sender As System.Object, e As System.EventArgs) Handles btnLocalizar.Click
        If rgPedido.Checked = True Then
            formata_grid(2)
        ElseIf rgCodigo.Checked = True Then
            formata_grid(3)
        ElseIf rgNome.Checked = True Then
            formata_grid(4)
        End If
    End Sub

    Private Sub rgNome_Click(sender As System.Object, e As System.EventArgs) Handles rgNome.Click
        If rgNome.Checked = True Then
            gbDados.Width = 598
            gbDados.Location = New System.Drawing.Point(723, 50)
            lblInicio.Visible = False
            txtDataIni.Location = New System.Drawing.Point(225, 18)
            txtDataIni.Width = 260
            txtDataIni.Mask = ""
            txtDataIni.Focus()
            lblFim.Visible = False
            btnLocalizar.Location = New System.Drawing.Point(509, 11)
            formata_grid(1)
        End If
    End Sub

    Private Sub txtDataIni_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDataIni.KeyPress
        If rgPedido.Checked = True Then
            If Not Char.IsNumber(e.KeyChar) And (Not e.KeyChar = vbBack) And (Not e.KeyChar = Convert.ToChar(Keys.Return)) Then
                e.Handled = True
                MessageBox.Show("Digite somente números no campo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        If rgCodigo.Checked = True Then
            If Not IsNumeric(e.KeyChar) And (Not e.KeyChar = vbBack) And (Not e.KeyChar = Convert.ToChar(Keys.Return)) Then
                e.Handled = True
                MessageBox.Show("Campo só permite valor númerico no formato de data.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


    Private Sub DespesasAcumuladasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DespesasAcumuladasToolStripMenuItem.Click
        Dim intUsuario As Integer = caixa.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        If caixa.verifica_permissao_usuario(intUsuario, 43) = True Then
            Dim f As New frmDespesasAcumuladas
            f.Show()
        Else
            MessageBox.Show("Usuário sem permissão para acessar este módulo.", "ERROR: 43", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub OperaçõesDeCréditoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OperaçõesDeCréditoToolStripMenuItem.Click
        Dim f As New frmRpt
        Dim r As New rptOperacoesCredito
        Dim fdata As New frmDataCaixa
        fdata.ShowDialog()

        r.diai = fdata.dtIni.Value.ToShortDateString
        r.diaf = fdata.dtFim.Value.ToShortDateString
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub


    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles btnCliente.Click
        Dim fc As New frmCliente_Old
        fc.Show()
    End Sub

    Private Sub btnEstorno_Click(sender As System.Object, e As System.EventArgs) Handles btnEstorno.Click
        Dim f As New frmCredito
        Dim strPedido As String = InputBox("Nº do Pedido:")
        If strPedido <> String.Empty Then
            f.intAbrePedido = CInt(strPedido)
            f.ShowDialog(Me)
            f.Dispose()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnAbrePedido_Click(sender As System.Object, e As System.EventArgs) Handles btnAbrePedido.Click
        Dim f As New frmAbrePedido
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub btnAtualiza_Click(sender As System.Object, e As System.EventArgs) Handles btnAtualiza.Click
        formata_grid(1)
        txtDataIni.Text = ""
        txtDataIni.Mask = ""
        txtDataIni.Focus()
    End Sub

    Private Sub btnGerarFatura_Click(sender As System.Object, e As System.EventArgs) Handles btnGerarFatura.Click
        Dim intContador As Int32
        If caixa.convertedata(caixa.retornaDataCaixaAberto(conf.Filial)) = caixa.convertedata(caixa.retornaDataHoraServidor) Then
            cod_filial = grdCaixa.CurrentRow.Cells(0).Value
            cod_filial_cliente = grdCaixa.CurrentRow.Cells(4).Value
            cod_cliente = grdCaixa.CurrentRow.Cells(5).Value
            strNome = grdCaixa.CurrentRow.Cells(6).Value

            For Each Item As DataGridViewRow In grdCaixa.Rows
                If Item.Cells(1).Value = True Then 'Verifica se a caixa de marcação está selecionada
                    If (Item.Cells(15).Value = 1) Or (Item.Cells(15).Value = 2) Then 'verifica se o pedido está em aberto ou processado no estoque
                        If Item.Cells(17).Value = 0 Then 'Verifica se o pedido já foi faturado 0 = não faturado e 1 = faturado
                            If Item.Cells(16).Value = 1 Or Item.Cells(16).Value = 5 Then 'Verifica a forma de pagamento para o pedido se é avista ou contra entrega
                                If strNome <> Item.Cells(6).Value Then 'Caso seja selecionado clientes distintos para fatruamento a mensagem é exibida
                                    MessageBox.Show("Sistema não permite lançar pedidos de clientes diferentes" & Chr(13) & "dentro de uma mesma fatura.", "INFORMAÇÃO",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    formata_grid(1)
                                    Exit Sub
                                End If
                                intContador = 1
                                If intContador = 1 Then
                                    GoTo gera_fatura
                                End If
                            Else
                                MessageBox.Show("Pedido não pode ser faturado pelo caixa, devido a " & Chr(13) & "forma de pagamento ser diferente de avista ou contra entrega.",
                                                "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            Next

gera_fatura: If intContador = 1 Then
                nova_fatura()
            Else
                MessageBox.Show("Pedido não pode ser faturado, verifique a forma de pagamento." & Chr(13) & "ou verifique se o pedido está selecionado.",
                                "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            For Each strLinha As DataGridViewRow In grdCaixa.Rows
                'Verifica se a caixa de marcação está selecionada e o status do pedido 3 = faturado, 4 = cancelado e 5 = pago parcialmente e se o pedido já foi faturado
                'Isso se faz necessário por que somente pedidos em aberto e processados no estoque podem serem faturados pelo caixa
                If (strLinha.Cells(1).Value = True) And (strLinha.Cells(15).Value <> 3) And (strLinha.Cells(15).Value <> 4) And (strLinha.Cells(15).Value <> 5) And (strLinha.Cells(17).Value = 0) Then
                    If (strLinha.Cells(16).Value = 1) Or (strLinha.Cells(16).Value = 5) Then 'Verifica se a forma de pagamento é avista ou contra entrega
                        fatura.insere_itens_fatura(strLinha.Cells(2).Value, strLinha.Cells(0).Value)

                        'Instrução SQL que busca a exisitência de um determinado registro
                        Dim strSQL As String = "select * from pedidos where num_pedido = " & strLinha.Cells(2).Value & " and id_filial = " &
                        strLinha.Cells(0).Value & " and cod_cliente = " & strLinha.Cells(5).Value

                        If caixa.verifica_existencia_registro(strSQL) = False Then 'Caso o registro não exista, a instrução seguinte é executada.
                            Dim strSQLInsert As String = "insert into pedidos(num_pedido, id_filial, cod_cliente, cod_status_pedido) values(" &
                            strLinha.Cells(2).Value & "," & strLinha.Cells(0).Value & "," & strLinha.Cells(5).Value & "," & strLinha.Cells(15).Value & ")"
                            caixa.grava_registros(strSQLInsert, True)
                        End If
                    End If
                End If
            Next


            If cod_filial > 0 And fatura.cod_fatura > 0 Then
                Dim ttTipo As New DataTable
                Dim strSQLTipo As String = "select cod_tipo_cliente from cliente where cod_cliente = " & cod_cliente & " and cod_filial_cliente = " & cod_filial_cliente
                ttTipo = caixa.retornaRegistro(strSQLTipo).Tables(0)

                Dim f As New frmFatura
                f.lblCliente.Text = cod_filial_cliente & "-" & cod_cliente & " - " & strNome
                f.lblFilial.Text = cod_filial
                f.lblFatura.Text = fatura.cod_fatura
                f.intTipoCliente = ttTipo.Rows(0)("cod_tipo_cliente")
                f.ShowDialog(Me)
                cod_filial = 0
                fatura.cod_fatura = 0
            End If
        Else
            MessageBox.Show("Existe caixa anterior aberto. Por favor fechar caixa.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        formata_grid(1)
    End Sub

    Private Sub txtDataIni_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDataIni.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim strPedido As String
                If txtDataIni.Text.Length > 7 Then
                    strPedido = txtDataIni.Text.Substring(7, 7)
                Else
                    strPedido = txtDataIni.Text
                End If

                txtDataIni.Text = CInt(strPedido)
                intTotalItens = 0
                TotalGeralItens = 0
                TotalGeralItensSel = 0

                For Each linha As DataGridViewRow In grdCaixa.Rows
                    If linha.Cells(1).Value = True Then
                        If txtDataIni.Text = CInt(linha.Cells(2).Value) Then
                            MessageBox.Show("Pedido já foi selecionado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If

                    If CInt(linha.Cells(2).Value) = CInt(txtDataIni.Text) Then
                        linha.Cells(1).Value = True
                        linha.Selected = True
                        grdCaixa.CurrentCell = grdCaixa.Rows(linha.Index).Cells(1)
                        If intControle = 1 Then
                            intTotalItens = intTotalItens - 1
                        End If
                    End If

                    If linha.Cells(1).Value = True Then
                        intTotalItens = intTotalItens + 1
                        TotalGeralItensSel = TotalGeralItensSel + linha.Cells(11).Value
                    End If

                    TotalGeralItens = Format(TotalGeralItens + linha.Cells(11).Value, "#,##0.00")
                Next
                txtDataIni.Focus()
                lblTotalItens.Text = "Total Itens: " & intTotalItens & " / " & grdCaixa.Rows.Count
                lblTotalGeral.Text = "Total: " & Format(TotalGeralItensSel, "#,##0.00") & " / " & Format(TotalGeralItens, "#,##0.00")
                Call btnLocalizar_Click(sender, e)
        End Select
    End Sub

    Private Sub grdCaixa_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdCaixa.CellClick
        intControle = 1
        intTotalItens = 0
        TotalGeralItensSel = 0
        TotalGeralItens = 0
        grdCaixa.SelectedRows(0).Cells(1).Value = True
        For Each linha As DataGridViewRow In grdCaixa.Rows
            If linha.Cells(1).Value = True Then
                intTotalItens = intTotalItens + 1
                TotalGeralItensSel = TotalGeralItensSel + linha.Cells(11).Value
            End If
            TotalGeralItens = Format(TotalGeralItens + linha.Cells(11).Value, "#,##0.00")
        Next
        lblTotalItens.Text = "Total Itens: " & intTotalItens & " / " & grdCaixa.Rows.Count
        lblTotalGeral.Text = "Total: " & Format(TotalGeralItensSel, "#,##0.00") & " / " & Format(TotalGeralItens, "#,##0.00")
    End Sub

    Private Sub grdCaixa_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles grdCaixa.SelectionChanged
        If intControle = 1 Then
            intTotalItens = 0
            TotalGeralItensSel = 0
            TotalGeralItens = 0
            For Each linha As DataGridViewRow In grdCaixa.Rows
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
            lblTotalItens.Text = "Total Itens: " & intTotalItens & " / " & grdCaixa.Rows.Count
            lblTotalGeral.Text = "Total: " & Format(TotalGeralItensSel, "#,##0.00") & " / " & Format(TotalGeralItens, "#,##0.00")
        End If
    End Sub

    Private Sub rgCodigo_Click(sender As System.Object, e As System.EventArgs) Handles rgCodigo.Click
        If rgCodigo.Checked = True Then
            gbDados.Width = 425
            gbDados.Location = New System.Drawing.Point(896, 50)
            lblInicio.Visible = False
            txtDataIni.Location = New System.Drawing.Point(230, 18)
            txtDataIni.Width = 80
            txtDataIni.Text = ""
            txtDataIni.Focus()
            lblFim.Visible = False
            btnLocalizar.Location = New System.Drawing.Point(336, 11)
            formata_grid(1)
        End If
    End Sub

End Class