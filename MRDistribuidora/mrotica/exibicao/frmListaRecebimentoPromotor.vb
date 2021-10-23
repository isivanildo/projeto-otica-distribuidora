Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmListaRecebimentoPromotor
    Dim d As New dados

    Private Sub frmListaClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        combo_promotor()
    End Sub

    Private Sub combo_promotor()
        Dim strSQL As String = "SELECT * FROM PROMOTOR"
        d.conecta()
        Dim da As New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.Fill(ds, "Promotor")
        d.desconecta()

        cbPromotor.DataSource = ds.Tables(0)
        cbPromotor.DisplayMember = "promotor"
        cbPromotor.ValueMember = "cod_promotor"
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim f As New frmRpt
        Dim r As New rptRecebimentosPromotor
        Dim strsQL As String = ""
        Dim strTitulo As String = ""

        Try
            If rbRecebido.Checked = True And cbTudo.Checked = False Then
                strsQL = "select lancamentos.*, cliente.cod_cliente, cliente.nome_cliente, forma_pagamento.forma_pagamento from lancamentos inner join Pagamentos_fatura on lancamentos.cod_lancamento = Pagamentos_fatura.cod_lancamento " & _
                    "and lancamentos.id_filial = Pagamentos_fatura.id_filial inner join fatura on Pagamentos_fatura.cod_fatura = fatura.cod_fatura " & _
                    "and Pagamentos_fatura.id_filial = fatura.id_filial inner join Promotor_cliente on fatura.cod_cliente = Promotor_cliente.cod_cliente " & _
                    "inner join cliente on Promotor_cliente.cod_cliente = cliente.cod_cliente  inner join forma_pagamento on lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento " & _
                    "where Promotor_cliente.cod_promotor = " & cbPromotor.SelectedValue & " and lancamentos.data_recebimento >= " & d.Pdt(txtDataIni.Text) & _
                    " and lancamentos.data_recebimento <= " & d.Pdt(txtDataFim.Text) & " and lancamentos.cod_status_lancamento = 1 and lancamentos.cod_forma_pagamento IN (1,2,7,8) " & _
                    "order by cliente.nome_cliente"
                strTitulo = "Recebimento " & cbPromotor.Text
            End If

            If rbRecebido.Checked = True And cbTudo.Checked = True Then
                strsQL = "select lancamentos.*, cliente.cod_cliente, cliente.nome_cliente, forma_pagamento.forma_pagamento from lancamentos inner join Pagamentos_fatura on lancamentos.cod_lancamento = Pagamentos_fatura.cod_lancamento " & _
                    "and lancamentos.id_filial = Pagamentos_fatura.id_filial inner join fatura on Pagamentos_fatura.cod_fatura = fatura.cod_fatura " & _
                    "and Pagamentos_fatura.id_filial = fatura.id_filial inner join Promotor_cliente on fatura.cod_cliente = Promotor_cliente.cod_cliente " & _
                    "inner join cliente on Promotor_cliente.cod_cliente = cliente.cod_cliente  inner join forma_pagamento on lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento " & _
                    "where lancamentos.data_recebimento >= " & d.Pdt(txtDataIni.Text) & _
                    " and lancamentos.data_recebimento <= " & d.Pdt(txtDataFim.Text) & " and lancamentos.cod_status_lancamento = 1 and lancamentos.cod_forma_pagamento IN (1,2,7,8) " & _
                    "order by cliente.nome_cliente"
                strTitulo = "Recebimento Geral de Todos Promotor(as)"
            End If

            If rbReceber.Checked = True And cbTudo.Checked = False Then
                strsQL = "select lancamentos.*, cliente.cod_cliente, cliente.nome_cliente, forma_pagamento.forma_pagamento from lancamentos inner join Pagamentos_fatura on lancamentos.cod_lancamento = Pagamentos_fatura.cod_lancamento " & _
                    "and lancamentos.id_filial = Pagamentos_fatura.id_filial inner join fatura on Pagamentos_fatura.cod_fatura = fatura.cod_fatura " & _
                    "and Pagamentos_fatura.id_filial = fatura.id_filial inner join Promotor_cliente on fatura.cod_cliente = Promotor_cliente.cod_cliente " & _
                    "inner join cliente on Promotor_cliente.cod_cliente = cliente.cod_cliente  inner join forma_pagamento on lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento " & _
                    "where Promotor_cliente.cod_promotor = " & cbPromotor.SelectedValue & " and lancamentos.data_vencimento >= " & d.Pdt(txtDataIni.Text) & _
                    " and lancamentos.data_vencimento <= " & d.Pdt(txtDataFim.Text) & " and lancamentos.cod_status_lancamento = 1 and lancamentos.cod_forma_pagamento IN (1,2,7,8)" & _
                    " and lancamentos.data_recebimento is null " & _
                    "order by cliente.nome_cliente"
                strTitulo = "Pendências de Clientes " & cbPromotor.Text
            End If

            If rbReceber.Checked = True And cbTudo.Checked = True Then
                strsQL = "select lancamentos.*, cliente.cod_cliente, cliente.nome_cliente, forma_pagamento.forma_pagamento from lancamentos inner join Pagamentos_fatura on lancamentos.cod_lancamento = Pagamentos_fatura.cod_lancamento " & _
                    "and lancamentos.id_filial = Pagamentos_fatura.id_filial inner join fatura on Pagamentos_fatura.cod_fatura = fatura.cod_fatura " & _
                    "and Pagamentos_fatura.id_filial = fatura.id_filial inner join Promotor_cliente on fatura.cod_cliente = Promotor_cliente.cod_cliente " & _
                    "inner join cliente on Promotor_cliente.cod_cliente = cliente.cod_cliente  inner join forma_pagamento on lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento " & _
                    "where lancamentos.data_vencimento >= " & d.Pdt(txtDataIni.Text) & _
                    " and lancamentos.data_vencimento <= " & d.Pdt(txtDataFim.Text) & " and lancamentos.cod_status_lancamento = 1 and lancamentos.cod_forma_pagamento IN (1,2,7,8)" & _
                    " and lancamentos.data_recebimento is null " & _
                    "order by cliente.nome_cliente"
                strTitulo = "Pendências de Clientes Geral"
            End If

            d.conecta()
            Dim da As New SqlDataAdapter(strsQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Recebimento")
            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            r.lblTitulo.Text = strTitulo
            If rbReceber.Checked = True Then
                r.TextBox3.Text = "Vencimento"
                r.TextBox12.DataField = "data_vencimento"
            End If
            If ds.Tables(0).Rows.Count > 0 Then
                r.DataSource = ds.Tables(0)
            Else
                MessageBox.Show("Não há registro a ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            f.Relat(r)
            f.ShowDialog()
            f.Dispose()
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cbTudo_Click(sender As System.Object, e As System.EventArgs) Handles cbTudo.Click
        If cbTudo.Checked = True Then
            cbPromotor.Enabled = False
        Else
            cbPromotor.Enabled = True
        End If
    End Sub
End Class