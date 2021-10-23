Imports mrotica_util

Public Class frmSaldoPrecoCompra
    Dim d As New dados

    Private Sub btnRelatorio_Click(sender As System.Object, e As System.EventArgs) Handles btnRelatorio.Click, Button1.Click
        Dim f As New frmRpt
        Dim r As New rptSaldoPrecoCompra
        r.DataSource = retorna_saldo(dtpInicial.Text, dtpFinal.Text)
        r.lblTitulo.Text = "Relatório de Saldo por Preço de Compra no Período de: " & dtpInicial.Text & " a " & dtpFinal.Text
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    'Função responsável por retorna os dados de saldo baseado no preço de compra
    Private Function retorna_saldo(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim di As Date
        Dim df As Date

        di = dataini & " 00:00:00.000"
        df = datafim & " 23:59:59.000"

        Dim sql As String
        Dim tt As New DataTable
        If rbTudo.Checked Then
            sql = "SELECT    id_conferencia, id_filial_nota, id_item, cod_produto, quant, processado, user_id, preco_nota, cod_tabela," & _
            "desconto_compra FROM conferencia_nota" & _
            " where conferencia_nota.processado <> ''" & _
            " and conferencia_nota.processado Between (" & d.pdtm(di) & ") and  (" & d.pdtm(df) & ")"
        End If

        If rbFilial.Checked Then
            sql = "select produtos.produto,produtos.cod_produto,conferencia_nota.cod_produto, sum(conferencia_nota.preco_compra) as Saldo, " & _
            "almoxarifado.filial" & _
            " from conferencia_nota inner join produtos on conferencia_nota.cod_produto = produtos.cod_produto" & _
            " inner join almoxarifado on conferencia_nota.id_filial_nota = almoxarifado.id_filial" & _
            " where conferencia_nota.preco_compra <> '' and conferencia_nota.processado <> ''" & _
            " and conferencia_nota.processado Between (" & d.pdtm(di) & ") and  (" & d.pdtm(df) & ")" & _
            " and id_filial_nota = " & cbFilial.SelectedValue & _
            " group by conferencia_nota.cod_produto, produtos.cod_produto, produtos.produto, almoxarifado.filial, conferencia_nota.id_filial_nota" & _
            " order by conferencia_nota.id_filial_nota, produtos.produto"
        End If

        d.carrega_Tabela(sql, tt)
        Return tt
    End Function

    'Função responsável por retorna os dados das filiais
    Private Function retorna_filial() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "select id_filial, filial from almoxarifado"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function

    Private Sub frmSaldoPrecoCompra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbFilial.DisplayMember = "filial"
        cbFilial.ValueMember = "id_filial"
        cbFilial.DataSource = retorna_filial()
    End Sub

    Private Sub rbTudo_Click(sender As System.Object, e As System.EventArgs) Handles rbTudo.Click
        cbFilial.Enabled = False
    End Sub

    Private Sub rbFilial_Click(sender As System.Object, e As System.EventArgs) Handles rbFilial.Click
        cbFilial.Enabled = True
    End Sub
End Class