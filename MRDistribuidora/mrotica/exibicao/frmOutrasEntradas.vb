Imports mrotica_util
Imports MRUtil
Public Class frmOutrasEntradas
    Dim Lancamento As New Lancamento
    Dim tb_dados As New DataTable
    Dim d As New dados
    Dim ip, lp As Integer 'IP Posição do registro no grid, lp última posição na hora de editar
    Dim conf As New config
    Dim caixa As New objMaster
    Dim intUsuario As Integer
    Dim strDado As String
    Private Sub frmDespesas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intUsuario = caixa.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        dtIni.Value = Now
        combos()
        travaControles(grpDesp.Controls)
        formata_grid_itens()
    End Sub
    Private Sub formata_grid_itens()
        grdItens.Columns.Clear()
        grdItens.DataSource = Nothing
        grdItens.AutoGenerateColumns = False
        grdItens.AllowUserToAddRows = False

        Dim cLanc As New DataGridViewTextBoxColumn
        cLanc.DataPropertyName = "Cod_Lancamento"
        cLanc.HeaderText = "Lançamento"
        cLanc.Width = 80
        cLanc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cLanc.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        cLanc.SortMode = DataGridViewColumnSortMode.NotSortable
        cLanc.DefaultCellStyle.Format = "00000"
        grdItens.Columns.Add(cLanc)

        Dim cConta As New DataGridViewTextBoxColumn
        cConta.DataPropertyName = "Conta"
        cConta.HeaderText = "Tipo"
        cConta.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        cConta.SortMode = DataGridViewColumnSortMode.NotSortable
        cConta.Width = 180
        grdItens.Columns.Add(cConta)

        Dim cHist As New DataGridViewTextBoxColumn
        cHist.DataPropertyName = "historico"
        cHist.HeaderText = "Histórico"
        cHist.Width = 330
        grdItens.Columns.Add(cHist)

        Dim cValor As New DataGridViewTextBoxColumn
        cValor.DataPropertyName = "valor_pago"
        cValor.HeaderText = "Valor"
        cValor.Width = 80
        cValor.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        cValor.SortMode = DataGridViewColumnSortMode.NotSortable
        cValor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        cValor.DefaultCellStyle.Format = "##0.00"
        grdItens.Columns.Add(cValor)

        grdItens.DataSource = Lancamento.ListarOutrasReceitasData(dtIni.Value.ToShortDateString(), dtFim.Value.ToShortDateString(), conf.Filial)

        'Verifica se há registro, se houver habila os botões de Editar e Excluir
        If Lancamento.ListarOutrasReceitasData(dtIni.Value.ToShortDateString(), dtFim.Value.ToShortDateString(), conf.Filial).Rows.Count > 0 Then
            txtTotal.Text = String.Format("{0:##0.00}", Lancamento.TotalOutrasReceitasData(dtIni.Value.ToShortDateString(), dtFim.Value.ToShortDateString(), conf.Filial))
            txtTotal.Enabled = True
            habilitaControle()
        Else
            txtTotal.Text = ""
            txtTotal.Enabled = False
            desabilitaControle()
        End If
    End Sub
    Private Sub combos()
        Dim sql As String
        Dim tt As New DataTable
        Dim tb_forma As New DataTable
        sql = "Select * from contas where (classificacao " &
        "like '1.3%') " &
        "and vis = 'S' order by nome"
        d.carrega_Tabela(sql, tt)
        cbTipo.DataSource = tt
        cbTipo.ValueMember = "conta"
        cbTipo.DisplayMember = "nome"


        d.carrega_Tabela("Select * from forma_pagamento", tb_forma)
        cbForma.DataSource = tb_forma
        cbForma.ValueMember = "cod_forma_pagamento"
        cbForma.DisplayMember = "forma_pagamento"
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        If caixa.convertedata(caixa.retornaDataCaixaAberto(conf.Filial)) = caixa.convertedata(caixa.retornaDataHoraServidor) Then
            Lancamento.Novo()
            btnNovo.Enabled = False
            btnSalvar.Text = "&Salvar"
            btnDeletar.Text = "&Cancelar"
            DestravaControles(grpDesp.Controls)
            grdItens.Enabled = False
            LimpaControles(grpDesp.Controls)
        Else
            MessageBox.Show("Não é possível lançar receita com caixa anterior aberto.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If caixa.retornaDataCaixaExistente(CDate(caixa.convertedata(dtLancamento.Value))) = True Then
            If caixa.retornaDataCaixaAberto(CDate(caixa.convertedata(dtLancamento.Value))) = False Then
                If btnSalvar.Text = "&Editar" Then
                    Lancamento.UsuarioAlt = intUsuario
                    btnNovo.Enabled = False
                    btnSalvar.Text = "&Salvar"
                    btnDeletar.Text = "&Cancelar"
                    grdItens.Enabled = False
                    DestravaControles(grpDesp.Controls)
                    Exit Sub
                Else
                    Lancamento.DataLancamento = dtLancamento.Value
                    Lancamento.DataVencimento = dtLancamento.Value
                    Lancamento.CodigoFilial = conf.Filial
                    Lancamento.CodigoFilialLancamento = conf.Filial
                    Lancamento.CodigoConta = cbTipo.SelectedValue
                    Lancamento.CodigoFormaPag = cbForma.SelectedValue
                    Lancamento.DataRecebimento = dtLancamento.Value
                    Lancamento.Historico = txtHistórico.Text
                    Lancamento.NumeroParcela = 1
                    Lancamento.NumeroParcelas = 1
                    Lancamento.Tipo = "E"
                    Lancamento.CodigoStatusLanc = 1
                    Lancamento.ValorPago = txtValor.Text
                    Lancamento.Acrescimo = 0
                    Lancamento.Juros = 0
                    Lancamento.Desconto = 0
                    Lancamento.Taxa = 0.0
                    Lancamento.UsuarioLanc = intUsuario
                    Lancamento.UsuarioAlt = 0

                    If strDado <> String.Empty Then
                        Lancamento.UsuarioAlt = intUsuario
                        Lancamento.AtualizaDespesaOutrasReceitas()
                    Else
                        Lancamento.SalvaLancamento()
                    End If

                    btnNovo.Enabled = True
                    btnSalvar.Text = "&Editar"
                    btnDeletar.Text = "&Deletar"
                    grdItens.Enabled = True
                    travaControles(grpDesp.Controls)
                    formata_grid_itens()
                End If
            Else
                MessageBox.Show("Não é possível fazer lançamento, a data informada" & Chr(13) & "já possui um caixa fechado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Não existe caixa aberto e nem fechado" & Chr(13) & "para a data informada.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDeletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletar.Click
        If btnDeletar.Text = "&Cancelar" Then
            btnNovo.Enabled = True
            btnSalvar.Text = "&Editar"
            btnDeletar.Text = "&Deletar"
            grdItens.Enabled = True
            travaControles(grpDesp.Controls)
            formata_grid_itens()
        Else
            Lancamento.ExcluiDespesasReceitas()
            formata_grid_itens()
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmRpt
        Dim r As New rptDespesas
        r.DataSource = Lancamento.ListarOutrasReceitasData(dtIni.Value.ToShortDateString(), dtFim.Value.ToShortDateString(), conf.Filial)
        r.diai = dtIni.Value
        r.diaf = dtFim.Value
        f.Relat(r)
        f.ShowDialog(Me)

    End Sub

    Private Sub habilitaControle()
        btnSalvar.Enabled = True
        btnDeletar.Enabled = True
    End Sub

    Private Sub grdItens_Click(sender As Object, e As EventArgs) Handles grdItens.Click
        Lancamento.RetornaRegistro(grdItens.CurrentRow.Cells(0).Value, "E")
        dtLancamento.Value = Lancamento.DataLancamento
        cbTipo.SelectedValue = Lancamento.CodigoConta
        txtValor.Text = String.Format("{0:##.00}", Lancamento.ValorPago)
        txtHistórico.Text = Lancamento.Historico
        strDado = grdItens.CurrentRow.Index
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        formata_grid_itens()
    End Sub

    Private Sub desabilitaControle()
        btnSalvar.Enabled = False
        btnDeletar.Enabled = False
    End Sub
End Class