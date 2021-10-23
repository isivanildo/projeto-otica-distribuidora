Imports mrotica_util
Public Class frmSaidasLentesFabricante
    Dim d As New dados
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        relatorio()
    End Sub
    Private Sub relatorio()
        Dim sql As String
        Dim tt As New DataTable
        Dim r As New rptSaidasLentesFabricante
        Dim di, df As Date
        Dim f As New frmRpt
        di = dtIni.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        sql = "SELECT SUM(movimento.quant)*-1 AS saidas, " & _
        "lentes_tabela.nome_comercial, lentes_tabela.cod_tabela, " & _
        "lentes_blocos.id_fabricante " & _
        "FROM movimento INNER JOIN movimentomaster ON movimento.cod_Movimento " & _
        "= movimentomaster.cod_movimento AND " & _
        "movimento.id_filial = movimentomaster.id_filial INNER JOIN " & _
        "produtos ON movimento.cod_produto = produtos.cod_produto AND " & _
        "movimento.cod_produto = produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente  " & _
        "AND produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " & _
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " & _
        "WHERE (movimento.quant < 0) AND (movimentomaster.data >= " & _
        d.pdtm(di) & ") AND (movimentomaster.data <= " & _
        d.pdtm(df) & ") AND (lentes_blocos.id_fabricante = " & _
        cbFabricante.SelectedValue & ") and (lentes_tabela.cod_tabela<> 0)" & _
        " and (lentes_tabela.cod_tabela <> 1) GROUP BY lentes_tabela.nome_comercial," & _
        "lentes_tabela.cod_tabela,lentes_blocos.id_fabricante " & _
        " ORDER BY lentes_tabela.nome_comercial"
        r.titulo = "Saídas de Lentes no período de " & dtIni.Value.Date & " até " & dtFim.Value.Date & _
        " impresso em " & Now.ToString
        d.carrega_Tabela(sql, tt)
        r.DataSource = tt
        f.Relat(r)
        f.Show()

    End Sub
    Private Sub carrega_combos()
        Dim tbFab As New DataTable
        Dim tbTipo As New DataTable
        Dim tbMat As New DataTable
        d.carrega_Tabela("Select * from fabricante order by id_fabricante", tbFab)

        cbFabricante.DataSource = tbFab
        cbFabricante.DisplayMember = "fabricante"
        cbFabricante.ValueMember = "id_fabricante"

    End Sub

    Private Sub frmSaidasLentesFabricante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_combos()
        dtIni.Value = Now
        dtFim.Value = Now
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class