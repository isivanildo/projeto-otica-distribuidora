Imports mrotica_util
Public Class frmChequePagCredito
    Dim d As New dados
    Public n_cheque, n_cheques As Integer
    Public valor, valor_acrescimo, valor_parcela, Valor_pago As Double
    Public d_emissao, d_vencimento As Date
    Public n_Credito, filial, forma, cod_cliente, cod_filial_cliente As Integer
    Dim tb_cheques As New DataTable
    Public tb_itens As DataTable
    Dim cheques As New objCheque(objPagamento.tipo_pagamento.credito)
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
            MsgBox("Cheques lançados")
            Exit Sub
        End If
        txtCheque.Text = txtCheque.Text
        cheques.novo_cheque()
        cheques.data_lancamento = d_emissao
        cheques.data_vencimento = dtVencimento.Value
        cheques.cod_fat_cred = n_Credito
        cheques.id_filial = filial
        cheques.id_filial_lancamento = conf.Filial
        cheques.cod_conta = 102
        cheques.cod_forma_pagamento = forma
        cheques.historico = "Receb. do cheque " & n_cheque & " de " & n_cheques & _
        " do credito " & adiciona_zeros(filial, 4) & "-" & _
        adiciona_zeros(n_Credito, 6)
        cheques.n_parcela = n_cheque
        cheques.n_parcelas = n_cheques
        cheques.tipo = "R"
        cheques.valor = txtValPag.Text
        cheques.cod_banco = cbBanco.SelectedValue
        cheques.conta = txtCC.Text
        cheques.doc = "Banco: " & cbBanco.SelectedValue & " Ag. " & _
        txtAgencia.Text & ". C/C:" & txtCC.Text & " Cheque Nº " & txtCheque.Text
        cheques.agencia = txtAgencia.Text
        cheques.cheque = txtCheque.Text
        cheques.acrescimo = valor_acrescimo / n_cheques
        cheques.cod_filial_cliente = cod_filial_cliente
        cheques.cod_cliente = cod_cliente
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
        tb_cheques = cheques.listar_cheques_credito(n_Credito, filial)
        grdRec.DataSource = tb_cheques
        Dim TStb As New DataGridTableStyle

        TStb.MappingName = grdRec.DataSource.tablename

        Dim cCheque As New DataGridTextBoxColumn
        With cCheque
            .MappingName = "cheque"
            .HeaderText = "Nº Cheque"
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
            .HeaderText = "Acréscimo."
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
End Class