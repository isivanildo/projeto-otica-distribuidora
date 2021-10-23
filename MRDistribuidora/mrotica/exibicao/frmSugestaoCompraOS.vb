Imports mrotica_util
Public Class frmSugestaoCompraOS
    Public fabricantes() As String
    Dim filtro As String = ""
    Dim sql As String = ""
    Dim tb As New DataTable
    Dim d As New dados
    Public tbRet As New DataTable
    Private Sub frmSugestaoCompraOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        If fabricantes.Length = 0 Then
            carrega()
            Exit Sub
        End If
        While fabricantes.Length > i
            filtro = filtro & " produtos.id_fabricante = " & fabricantes(i) & " or"
            i = i + 1
        End While
        filtro = filtro.Remove(filtro.Length - 2, 2)
        filtro = " Where (" & filtro & ") and (sugestao_pedido_auto_os.cod_status= 1) "
        carrega()
    End Sub
    Public Sub carrega()
        sql = "SELECT lentes_blocos.cod_tabela, sugestao_pedido_auto_os.cod_produto, " & _
        "sugestao_pedido_auto_os.quant," & _
        "produtos.produto, lentes_tabela.Preco_compra, lentes_tabela.desconto_compra, " & _
        "status_sugestao_pedido_os.status, sugestao_pedido_auto_os.cod_os, " & _
        "sugestao_pedido_auto_os.id_filial,sugestao_pedido_auto_os.data, " & _
        "sugestao_pedido_auto_os.num_pedido," & _
        "sugestao_pedido_auto_os.doc_cliente,sugestao_pedido_auto_os.id FROM sugestao_pedido_auto_os INNER JOIN " & _
        "status_sugestao_pedido_os ON sugestao_pedido_auto_os.cod_status = status_sugestao_pedido_os.cod_status " & _
        "INNER JOIN produtos ON sugestao_pedido_auto_os.cod_produto = produtos.cod_produto " & _
        "INNER JOIN lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "INNER JOIN lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela "

        sql = sql & filtro & " Order By sugestao_pedido_auto_os.data"
        d.carrega_Tabela(sql, tb)
        grdItens.DataSource = tb
        grdItens.Refresh()
        formata_grid()
    End Sub
    Private Sub formata_grid()
        Dim TStb As New DataGridTableStyle
        TStb.MappingName = grdItens.DataSource.tablename
        Dim cFilial As New DataGridTextBoxColumn
        With cFilial
            .MappingName = "id_filial"
            .HeaderText = "Filial"
            .Width = 50
        End With
        TStb.GridColumnStyles.Add(cFilial)
        Dim cOS As New DataGridTextBoxColumn
        With cOS
            .MappingName = "cod_os"
            .HeaderText = "OS"
        End With
        TStb.GridColumnStyles.Add(cOS)

        Dim cDoc As New DataGridTextBoxColumn
        With cDoc
            .MappingName = "doc_cliente"
            .HeaderText = "Doc"
        End With
        TStb.GridColumnStyles.Add(cDoc)

        Dim cProd As New DataGridTextBoxColumn
        With cProd
            .MappingName = "Produto"
            .HeaderText = "Produto"
            .Width = 300
        End With
        TStb.GridColumnStyles.Add(cProd)

        Dim cTabela As New DataGridTextBoxColumn
        With cTabela
            .MappingName = "cod_tabela"
            .HeaderText = "Tabela"
        End With
        TStb.GridColumnStyles.Add(cTabela)

        Dim cCod_prod As New DataGridTextBoxColumn
        With cCod_prod
            .MappingName = "cod_produto"
            .HeaderText = "Cod Prod"
        End With
        TStb.GridColumnStyles.Add(cCod_prod)

        Dim cStatus As New DataGridTextBoxColumn
        With cStatus
            .MappingName = "status"
            .HeaderText = "Status"
        End With
        TStb.GridColumnStyles.Add(cStatus)

        grdItens.TableStyles.Clear()
        grdItens.TableStyles.Add(TStb)
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim i As Integer
        Try
            tbRet.Columns.Add("cod_produto")
            tbRet.Columns.Add("id")
            tbRet.Columns.Add("preco_compra")
            tbRet.Columns.Add("desconto")
            tbRet.Columns.Add("doc_cliente")
            tbRet.Columns.Add("cod_os")
            tbRet.Columns.Add("id_filial")
            tbRet.Columns.Add("num_pedido")
            tbRet.Columns.Add("quant")
        Catch ex As Exception

        End Try
        
        i = 0
        While i < tb.Rows.Count
            If grdItens.IsSelected(i) = True Then
                If tb.Rows(i)("status").ToString.Trim.ToUpper = "SUGERIDO" _
                Or tb.Rows(i)("status").ToString.Trim.ToUpper = "2º PEDIDO" Then
                    Dim r As DataRow
                    r = tbRet.NewRow
                    r("cod_produto") = tb.Rows(i)("cod_produto")
                    r("id") = tb.Rows(i)("id")
                    r("preco_compra") = tb.Rows(i)("preco_compra")
                    r("desconto") = tb.Rows(i)("desconto_compra")
                    r("doc_cliente") = tb.Rows(i)("doc_cliente")
                    r("cod_os") = tb.Rows(i)("cod_os")
                    r("id_filial") = tb.Rows(i)("id_filial")
                    r("num_pedido") = tb.Rows(i)("num_pedido")
                    r("quant") = tb.Rows(i)("quant")
                    tbRet.Rows.Add(r)
                    marca_atendido(tb.Rows(i)("id"))
                End If
            End If
            i = i + 1
        End While
        carrega()
    End Sub
    Private Sub marca_atendido(ByVal id As Integer)
        Dim sql As String
        sql = "update sugestao_pedido_auto_os set cod_status = 2 where id = " & id & ""
        d.Comando(sql, True)
    End Sub
End Class