Imports winotica_util
Imports System.Data
Partial Public Class saldo_lentes
    Inherits System.Web.UI.Page
    Dim d As New dados("winweb", "winotica", "dellservidor", "winotica")
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Private Sub cria_tabela()
        Dim tb As New DataTable
        Dim tb_lojas As New DataTable
        Dim lentes As New objTabela(d)
        Dim htTable As New HtmlTable
        Dim dtRow As New HtmlTableRow
        Dim cell As New HtmlTableCell
        Dim loja As String = ""
        Dim saldoLente As Integer = 0
        Dim saldoLenteFin As Double = 0
        Dim saldoFabricante As Integer = 0
        Dim saldoFabricanteFin As Double = 0
        Dim cod_fabricante As Integer = 0
        Dim i As Integer = 0
        Dim saldo_final As Integer = 0
        Dim saldo_final_fin As Double = 0
        Dim cod_lente As Integer = 0
        Dim Lente As String
        Dim iLente As Integer = 0
        Dim tsql As String
        Dim fabricante As String

        htTable.Border = 1
        htTable.BorderColor = "Black"

        lentes.Source("Select * from lentes_tabela where id_fabricante <> 99 order by id_fabricante,nome_comercial")

        tb = lentes.tb
        'Monta Títulos
        dtRow = New HtmlTableRow

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Lente</label>"
        dtRow.Cells.Add(cell)


        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Saldo</label>"
        dtRow.Cells.Add(cell)


        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Saldo Fin.</label>"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Ent. 30</label>"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Sai. 30</label>"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Ent. 60</label>"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Sai. 60</label>"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Ent. 90</label>"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Sai. 90</label>"
        dtRow.Cells.Add(cell)

        htTable.Rows.Add(dtRow)

        While iLente < lentes.max
            Dim saldo_analise As Integer
            saldo_analise = lentes.saldo("saldo")
            If saldo_analise > 0 Then
                If lentes.id_fabricante <> cod_fabricante Then
                    If cod_fabricante = 0 Then
                        fabricante = lentes.nome_fabricante
                        dtRow = New HtmlTableRow
                        cell = New HtmlTableCell
                        cell.InnerHtml = "<label class=titulo>Fabricante:" & fabricante & "</label>"

                        dtRow.Cells.Add(cell)

                        htTable.Rows.Add(dtRow)
                        cod_fabricante = lentes.id_fabricante
                    End If
                End If
                If lentes.cod_tabela <> cod_lente Then
                    If cod_lente <> 0 Then
                        dtRow = New HtmlTableRow
                        cell = New HtmlTableCell
                        cell.InnerHtml = "<label class=tituloazul>Total</label>"
                        cell.Align = "Right"
                        dtRow.Cells.Add(cell)

                        cell = New HtmlTableCell
                        cell.InnerHtml = "<label class=titulo>" & saldoLente & "</label>"
                        cell.Align = "Right"
                        dtRow.Cells.Add(cell)

                        cell = New HtmlTableCell
                        cell.InnerHtml = "<label class=titulo>" & FormatCurrency(saldoLenteFin) & "</label>"
                        cell.Align = "Right"
                        dtRow.Cells.Add(cell)

                        htTable.Rows.Add(dtRow)

                        saldoLente = 0
                        saldoLenteFin = 0
                    End If
                    If lentes.id_fabricante <> cod_fabricante Then
                        dtRow = New HtmlTableRow
                        cell = New HtmlTableCell
                        cell.InnerHtml = "<label class=tituloazul>Total Fabricante " & fabricante & "</label>"
                        cell.Align = "Right"
                        dtRow.Cells.Add(cell)

                        cell = New HtmlTableCell
                        cell.InnerHtml = "<label class=titulo>" & saldoFabricante & "</label>"
                        cell.Align = "Right"
                        dtRow.Cells.Add(cell)

                        cell = New HtmlTableCell
                        cell.InnerHtml = "<label class=titulo>" & FormatCurrency(saldoFabricanteFin) & "</label>"
                        cell.Align = "Right"
                        dtRow.Cells.Add(cell)

                        htTable.Rows.Add(dtRow)

                        saldoFabricante = 0
                        saldoFabricanteFin = 0

                        dtRow = New HtmlTableRow
                        cell = New HtmlTableCell
                        cell.InnerHtml = "<label class=titulo>Fabricante:" & lentes.nome_fabricante & "</label>"

                        dtRow.Cells.Add(cell)

                        htTable.Rows.Add(dtRow)
                        cod_fabricante = lentes.id_fabricante
                        fabricante = lentes.nome_fabricante
                    End If

                    dtRow = New HtmlTableRow
                    cell = New HtmlTableCell
                    cod_lente = lentes.cod_tabela
                    Lente = lentes.nome_comercial
                    cell.InnerHtml = "<label class=tituloazul>" & cod_lente & "-" & Lente & "</label>"
                    dtRow.Cells.Add(cell)
                    htTable.Rows.Add(dtRow)
                End If
                tsql = "Select * from almoxarifado"
                d.carrega_Tabela(tsql, tb_lojas)

                ' tb_lojas = lentes.lista_filiais_lente(row("cod_tabela"))

                For Each rFilial As DataRow In tb_lojas.Rows
                    Dim saldo As Integer
                    Dim saldo_fin As Double
                    Dim di, df As Date
                    Dim ent_30, sai_30, ent_60, sai_60, ent_90, sai_90 As Double
                    Dim rSaldos As DataRow
                    dtRow = New HtmlTableRow

                    cell = New HtmlTableCell
                    cell.InnerHtml = "<label class=titulo>Filial: " & rFilial("filial").ToString & "</label>"
                    'cell.Width = 180
                    dtRow.Cells.Add(cell)
                    Try
                        rSaldos = lentes.saldo_filial(rFilial("id_filial"))
                        saldo = rSaldos("saldo")
                        saldo_fin = rSaldos("saldo_fin")
                        di = DateAdd(DateInterval.Day, -30, Now).ToShortDateString & " 00:00:00"
                        df = Day(Now) & "/" & d.adiciona_zeros(Month(Now), 2).ToString & "/" & Year(Now) & " 23:59:59"
                        ent_30 = lentes.entrada_periodo_filial(di, df, rFilial("id_filial"))
                        sai_30 = lentes.saida_periodo_filial(di, df, rFilial("id_filial"))

                        di = DateAdd(DateInterval.Day, -60, Now).ToShortDateString & " 00:00:00"
                        df = Day(Now) & "/" & d.adiciona_zeros(Month(Now), 2).ToString & "/" & Year(Now) & " 23:59:59"
                        ent_60 = lentes.entrada_periodo_filial(di, df, rFilial("id_filial"))
                        sai_60 = lentes.saida_periodo_filial(di, df, rFilial("id_filial"))

                        di = DateAdd(DateInterval.Day, -90, Now).ToShortDateString & " 00:00:00"
                        df = Day(Now) & "/" & d.adiciona_zeros(Month(Now), 2).ToString & "/" & Year(Now) & " 23:59:59"
                        ent_90 = lentes.entrada_periodo_filial(di, df, rFilial("id_filial"))
                        sai_90 = lentes.saida_periodo_filial(di, df, rFilial("id_filial"))
                    Catch ex As Exception
                        saldo = 0
                        saldo_fin = 0
                        ent_30 = 0
                        sai_30 = 0
                        ent_60 = 0
                        sai_60 = 0
                        ent_90 = 0
                        sai_90 = 0
                    End Try


                    cell = New HtmlTableCell
                    cell.InnerHtml = "<label class=texto>" & saldo & "</label>"
                    cell.Align = "Right"
                    dtRow.Cells.Add(cell)

                    cell = New HtmlTableCell
                    cell.InnerHtml = "<label class=texto>" & FormatCurrency(saldo_fin, 2) & "</label>"
                    cell.Align = "Right"
                    dtRow.Cells.Add(cell)

                    cell = New HtmlTableCell
                    cell.InnerHtml = "<label class=texto>" & ent_30 & "</label>"
                    cell.Align = "Right"
                    dtRow.Cells.Add(cell)

                    cell = New HtmlTableCell
                    cell.InnerHtml = "<label class=texto>" & sai_30 & "</label>"
                    cell.Align = "Right"
                    dtRow.Cells.Add(cell)

                    cell = New HtmlTableCell
                    cell.InnerHtml = "<label class=texto>" & ent_60 & "</label>"
                    cell.Align = "Right"
                    dtRow.Cells.Add(cell)

                    cell = New HtmlTableCell
                    cell.InnerHtml = "<label class=texto>" & sai_60 & "</label>"
                    cell.Align = "Right"
                    dtRow.Cells.Add(cell)

                    cell = New HtmlTableCell
                    cell.InnerHtml = "<label class=texto>" & ent_90 & "</label>"
                    cell.Align = "Right"
                    dtRow.Cells.Add(cell)

                    cell = New HtmlTableCell
                    cell.InnerHtml = "<label class=texto>" & sai_90 & "</label>"
                    cell.Align = "Right"
                    dtRow.Cells.Add(cell)


                    htTable.Rows.Add(dtRow)

                    saldoLente = saldoLente + saldo
                    saldoLenteFin = saldoLenteFin + saldo_fin
                    saldoFabricante = saldoFabricante + saldo
                    saldoFabricanteFin = saldoFabricanteFin + saldo_fin
                    saldo_final = saldo_final + saldoLente
                    saldo_final_fin = saldo_final_fin + saldoLenteFin
                Next
            End If
            iLente = iLente + 1
            lentes.proximo()
        End While


        dtRow = New HtmlTableRow
        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=tituloazul>Total</label>"
        cell.Align = "Right"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>" & saldoLente & "</label>"
        cell.Align = "Right"
        dtRow.Cells.Add(cell)
        htTable.Rows.Add(dtRow)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>" & FormatCurrency(saldoLenteFin) & "</label>"
        cell.Align = "Right"
        dtRow.Cells.Add(cell)

        dtRow = New HtmlTableRow
        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=tituloazul>Total Fabricante " & fabricante & "</label>"
        cell.Align = "Right"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>" & saldoFabricante & "</label>"
        cell.Align = "Right"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>" & FormatCurrency(saldoFabricanteFin) & "</label>"
        cell.Align = "Right"
        dtRow.Cells.Add(cell)

        htTable.Rows.Add(dtRow)


        dtRow = New HtmlTableRow
        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=tituloazul>Total Lentes</label>"
        cell.Align = "Right"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=tituloazul>" & saldo_final & "</label>"
        cell.Align = "Right"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=tituloazul>" & FormatCurrency(saldo_final_fin) & "</label>"
        cell.Align = "Right"
        dtRow.Cells.Add(cell)

        htTable.Rows.Add(dtRow)

        Panel1.Controls.Add(htTable)



    End Sub
    Protected Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        cria_tabela()
    End Sub
End Class