Imports mrotica_util
Public Class frmChequePag
    Dim d As New dados
    Public n_cheque, n_cheques As Integer
    Public valor, valor_acrescimo, valor_parcela, Valor_pago As Double
    Public d_emissao, d_vencimento, d_pagamento As Date
    Public n_fatura, filial, forma, cod_filial_cliente, cod_cliente As Integer
    Dim tb_cheques As New DataTable
    Public tb_itens As DataTable
    Dim cheques As New objCheque(objPagamento.tipo_pagamento.Fatura)
    Dim conf As New config
    Private Sub frmChequePag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_combos()
        n_cheque = 1
        valor_acrescimo = 0
        Valor_pago = 0
        txtValor.Text = valor
        formataGrid()
        If forma = 2 Then
            txtValPag.ReadOnly = True
            chkAcrescimo.Enabled = False
        End If
        txtValPag.Text = (txtValor.Text / n_cheques)
    End Sub
    Private Sub carrega_combos()
        Dim Sql As String
        Dim tb_bancos As New DataTable
        Sql = "Select * from bancos Order by Pref,banco"
        d.carrega_Tabela(Sql, tb_bancos)

        cbBanco.DataSource = tb_bancos
        cbBanco.DisplayMember = "banco"
        cbBanco.ValueMember = "cod_banco"
    End Sub
    
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If n_cheque > n_cheques Then
            MsgBox("Cheques lan�ados")
            Exit Sub
        End If
        txtCheque.Text = txtCheque.Text
        cheques.novo_cheque()
        cheques.data_lancamento = d_emissao
        cheques.data_vencimento = dtVencimento.Value
        cheques.data_recebimento = d_pagamento
        cheques.cod_fat_cred = n_fatura
        cheques.id_filial = filial
        cheques.id_filial_lancamento = conf.Filial
        cheques.cod_conta = 102
        cheques.cod_forma_pagamento = forma
        cheques.cod_fatura_lanc = n_fatura
        cheques.historico = "Receb. do cheque " & n_cheque & " de " & n_cheques & _
        " da fatura " & adiciona_zeros(filial, 4) & "-" & _
        adiciona_zeros(n_fatura, 6) & _
        " Pedidos: " & pedidos()
        cheques.n_parcela = n_cheque
        cheques.n_parcelas = n_cheques
        cheques.cod_filial_cliente = cod_filial_cliente
        cheques.cod_cliente = cod_cliente
        cheques.tipo = "R"
        cheques.valor = txtValPag.Text
        cheques.cod_banco = cbBanco.SelectedValue
        cheques.conta = txtCC.Text
        cheques.doc = "Banco: " & cbBanco.SelectedValue & " Ag. " & _
        txtAgencia.Text & ". C/C:" & txtCC.Text & " Cheque N� " & txtCheque.Text
        cheques.agencia = txtAgencia.Text
        cheques.cheque = txtCheque.Text
        cheques.acrescimo = valor_acrescimo / n_cheques
        cheques.acrescimo_novo = valor_acrescimo / n_cheques
        cheques.juros_novo = 0.0
        cheques.desconto_novo = 0.0
        cheques.taxas = 0.0
        cheques.Salvar_cheque(objLancamentos.tiposalvar.Transaction)
        MsgBox(cheques.concluir_SQL_transaction())
        n_cheque = n_cheque + 1
        txtCheque.Text = txtCheque.Text + 1
        Valor_pago = Valor_pago + txtValPag.Text
        txtValPag.Text = txtValor.Text - Valor_pago
        dtVencimento.Value = DateAdd(DateInterval.Day, 30, dtVencimento.Value)
        formataGrid()
    End Sub
    Private Sub chkAcrescimo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAcrescimo.CheckedChanged
        If chkAcrescimo.Checked = True Then
            txtValor.Text = valor + (valor * ((confAcrescimoCheque * n_cheques) / 100))
            valor_parcela = txtValor.Text / n_cheques
            txtValPag.Text = valor_parcela
            valor_acrescimo = txtValor.Text - valor
        Else
            txtValor.Text = valor
            valor_parcela = txtValor.Text / n_cheques
            txtValPag.Text = valor_parcela
            valor_acrescimo = 0
        End If
    End Sub
    Private Sub formataGrid()
        tb_cheques = cheques.listar_cheques_fatura(n_fatura, filial)
        grdRec.DataSource = tb_cheques
        Dim TStb As New DataGridTableStyle

        TStb.MappingName = grdRec.DataSource.tablename

        Dim cCheque As New DataGridTextBoxColumn
        With cCheque
            .MappingName = "cheque"
            .HeaderText = "N� Cheque"
        End With
        TStb.GridColumnStyles.Add(cCheque)

        Dim cValor As New DataGridTextBoxColumn
        With cValor
            .MappingName = "Valor"
            .HeaderText = "valor."
            .Alignment = HorizontalAlignment.Right
            .Format = "#,##0.00"
            .Width = 75
        End With
        TStb.GridColumnStyles.Add(cValor)

        Dim cAcr As New DataGridTextBoxColumn
        With cAcr
            .MappingName = "acrescimo"
            .HeaderText = "Acr�scimo."
            .Alignment = HorizontalAlignment.Right
            .Format = "#,##0.00"
        End With
        TStb.GridColumnStyles.Add(cAcr)

        Dim cTotal As New DataGridTextBoxColumn
        With cTotal
            .MappingName = "total"
            .HeaderText = "Total."
            .Alignment = HorizontalAlignment.Right
            .Format = "#,##0.00"
            .Width = 75
        End With
        TStb.GridColumnStyles.Add(cTotal)

        grdRec.TableStyles.Clear()
        grdRec.TableStyles.Add(TStb)
    End Sub
    Private Sub grdRec_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdRec.DoubleClick
        Dim i As Integer
        Dim r As frmAviso.respo
        i = grdRec.CurrentRowIndex
        r = AVISO("Deseja deletar este cheque?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
        If r = frmAviso.respo.SIM Then
            MsgBox(cheques.deletar_cheque(tb_cheques.Rows(i)("cod_lancamento"), tb_cheques.Rows(i)("id_filial")))
            formataGrid()
        End If
    End Sub
    Private Function pedidos() As String
        Dim str As String
        Dim i, t As Integer
        i = 0
        t = tb_itens.Rows.Count
        While i < t
            str = str & " - " & tb_itens.Rows(i)("num_pedido")
            i = i + 1
        End While
        Return str
    End Function
End Class