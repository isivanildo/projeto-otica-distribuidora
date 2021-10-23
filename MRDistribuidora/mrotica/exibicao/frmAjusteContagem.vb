Imports mrotica_util
Imports DataDynamics.Utility
Public Class frmAjusteContagem
    Dim tt As New DataTable
    Dim sql As String
    Dim d As New dados
    Dim mov As New objMovimentoDetalhe
    Dim chave_movimento As Integer
    Dim conf As New config
    Private Sub frmAjusteContagem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "SELECT lentes_tabela.cod_tabela,lentes_tabela.nome_comercial," & _
        "produtos.produto, produtos.cod_produto, " & _
        "conferencia_ajuste.quant, conferencia_ajuste.Estoque," & _
        "(conferencia_ajuste.quant-conferencia_ajuste.Estoque) as Diferenca " & _
        "FROM conferencia_ajuste INNER JOIN " & _
        "produtos ON conferencia_ajuste.cod_produto = " & _
        "produtos.cod_produto INNER JOIN " & _
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente " & _
        "AND produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " & _
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " & _
        "where (conferencia_ajuste.quant-conferencia_ajuste.Estoque) <> 0"
        prepara_tabela()
        carrega_grd()
    End Sub
    Private Sub prepara_tabela()
        Dim t As New DataTable
        Dim str As String = ""
        Dim i, m As Integer
        d.carrega_Tabela(sql, tt)
        sql = "SELECT lentes_blocos.cod_tabela " & _
         "FROM conferencia_ajuste INNER JOIN " & _
         "produtos ON conferencia_ajuste.cod_produto = " & _
         "produtos.cod_produto INNER JOIN " & _
         "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente " & _
         "AND produtos.id_fabricante = lentes_blocos.id_fabricante " & _
         "GROUP BY lentes_blocos.cod_tabela ORDER BY lentes_blocos.cod_tabela desc"
        d.carrega_Tabela(sql, t)
        i = 0
        m = t.Rows.Count
        While i < m
            Dim cod_tabela As Long
            cod_tabela = t.Rows(i)("cod_tabela")
            If cod_tabela > 2 Then
                If i = 0 Then
                    str = str & "lentes_tabela.cod_tabela = " & cod_tabela & " "
                Else
                    str = str & " or lentes_tabela.cod_tabela = " & cod_tabela & " "
                End If
            End If
            i = i + 1
        End While
        sql = "SELECT lentes_tabela.cod_tabela, lentes_tabela.nome_comercial, " &
        "produtos.produto, produtos.cod_produto, isnull((select quant from conferencia_ajuste " &
        "where conferencia_ajuste.cod_produto = produtos.cod_produto),0) as quant, " &
        "ISNULL((SELECT SUM(quant) FROM movimento WHERE " &
        "(cod_produto = produtos.cod_produto) and id_filial = " & conf.Filial & "), 0) AS Estoque, " &
        "(isnull((select quant from conferencia_ajuste where " &
        "conferencia_ajuste.cod_produto = produtos.cod_produto),0) " &
        "- ISNULL((SELECT SUM(quant) FROM movimento WHERE " &
        "(cod_produto = produtos.cod_produto) and id_filial = " & conf.Filial & "), 0)) as diferenca " &
        "FROM lentes_blocos INNER JOIN " &
        "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND " &
        "lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " &
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " &
        "WHERE " &
        "(isnull((select quant from conferencia_ajuste where " &
        "conferencia_ajuste.cod_produto = produtos.cod_produto),0) <> " &
        "ISNULL((SELECT SUM(quant) FROM movimento WHERE    " &
        "(cod_produto = produtos.cod_produto) and id_filial = " & conf.Filial & "), 0)) " &
        " and (" &
        str & ") order by produtos.produto"
        txtsql.Text = sql
        d.carrega_Tabela(sql, tt)


    End Sub
    Private Sub carrega_grd()
        Dim TStb As New DataGridTableStyle
        grdProd.DataSource = tt

        TStb.MappingName = grdProd.DataSource.tablename
        Dim cItem As New DataGridTextBoxColumn
        With cItem
            .MappingName = "produto"
            .HeaderText = "Produto"
            .Width = 300
        End With
        TStb.GridColumnStyles.Add(cItem)

        Dim cConferido As New DataGridTextBoxColumn
        With cConferido
            .MappingName = "quant"
            .HeaderText = "Conferido"
            .Width = 65
        End With
        TStb.GridColumnStyles.Add(cConferido)
        Dim quant As New DataGridTextBoxColumn
        With quant
            .MappingName = "Estoque"
            .HeaderText = "Sistema"
        End With
        TStb.GridColumnStyles.Add(quant)

        Dim Dif As New DataGridTextBoxColumn
        With Dif
            .MappingName = "diferenca"
            .HeaderText = "Diferença"
        End With
        TStb.GridColumnStyles.Add(Dif)

        grdProd.TableStyles.Clear()
        grdProd.TableStyles.Add(TStb)
    End Sub


    Private Sub insere_item_nota(ByVal _x_cod_prod As Integer, ByVal q As Double)
        Dim media_len, media_prod As Double
        Dim cod_len As Integer
        Dim p As New produtoClass
        p.filtra(_x_cod_prod)
        mov.novo()
        mov.item = mov.ret_ultimo_item(chave_movimento)
        mov.cod_movimento = chave_movimento
        mov.cod_produto = p.fldCod_produto
        mov.quant = q
        mov.desconto = p.Desconto_compra
        mov.pUnit = p.Preco_compra
        mov.estoqueFis = mov.ret_saldo_fisico(p.fldCod_produto) + CDbl(q)
        mov.estoqueFin = mov.estoqueFis * ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))))
        '( + mov.ret_saldo_fin(txtCodProd.Text)
        cod_len = mov.retorna_cod_lentebloco(p.fldCod_produto)

        media_len = media_movel(mov.ret_saldo_todos_fisico(cod_len), mov.ret_saldo_todos_fin(cod_len), q, (p.Preco_compra) - (p.Preco_compra * (p.Desconto_compra / 100)))
        media_prod = media_movel(mov.ret_saldo_fisico(p.fldCod_produto), mov.ret_saldo_fin(p.fldCod_produto), q, (p.Preco_compra) - (p.Preco_compra * (p.Desconto_compra / 100)))
        mov.atualiza_custo(cod_len, media_len, p.fldCod_produto, media_prod)
        mov.historico = "Ajuste de Estoque por contagem! " & Now.Date.ToString
        mov.Salvar()
    End Sub

    Private Sub btnInventario_Click(sender As System.Object, e As System.EventArgs) Handles btnInventario.Click
        Dim sql As String
        Dim res As String
        Dim i, m As Integer
        Dim resp As Integer
        resp = MsgBox("Tem certeza que deseja Ajustar essas lentes?", MsgBoxStyle.YesNo)
        If resp = vbNo Then
            Exit Sub
        End If
        chave_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial & "")
        sql = "INSERT INTO movimentomaster " &
               "(cod_movimento,cod_natureza,id_filial,data,doc,id_usuario,concluido) " &
               "VALUES ( " &
               chave_movimento &
               ",9" &
               "," & conf.Filial &
               "," & d.pdtm(d.hora) &
               ",'Ajuste Contagem'" &
               ",1" &
               ",'S')"
        res = d.Comando(sql, True)
        If res.StartsWith("OK") Then
            i = 0
            pb.Minimum = 0
            m = tt.Rows.Count
            pb.Maximum = m
            While i < m
                insere_item_nota(tt.Rows(i)("cod_produto"), tt.Rows(i)("diferenca"))
                Application.DoEvents()
                i = i + 1
                pb.Value = i
            End While
            AVISO("Concluído!", Me, frmAviso.tipo_aviso.tipo_ok)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim r As New rptAjuste
        Dim f As New frmRpt
        Dim path As String
        r.DataSource = tt
        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Diferenca.pdf"
        f.Relat(r)
        Pdf.Export(r.Document, path)
        f.Show()
    End Sub

End Class