Imports winotica_util
Imports System.Data

Partial Public Class pendentes
    Inherits System.Web.UI.Page
    Dim d As New dados("winweb", "winotica", "dellservidor", "winotica")
    Dim os As New ObjOS(d, 1, "")
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub
    Private Sub cria_tabela()
        Dim tb As New DataTable
        Dim htTable As New HtmlTable
        Dim dtRow As New HtmlTableRow
        Dim cell As New HtmlTableCell
        Dim loja As String = ""
        Dim i As Integer = 0
        Dim m As Integer = 0
        Dim codcliente As Integer
        Dim cliente As String
        htTable.Border = 1
        htTable.BorderColor = "Black"

        tb = os.lista_pendentes_estoque_otica_por_loja
        'Monta Títulos
        dtRow = New HtmlTableRow

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>OS/Data</label>"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Lentes OD/OE</label>"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Esf. Longe</label>"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Cil. Longe</label>"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Esf. Perto</label>"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Cil. Perto</label>"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Base</label>"
        dtRow.Cells.Add(cell)

        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=titulo>Adição</label>"
        dtRow.Cells.Add(cell)

        htTable.Rows.Add(dtRow)

        For Each row In tb.Rows
            If row("cod_cliente") <> codcliente Then
                If codcliente <> 0 Then
                    dtRow = New HtmlTableRow
                    cell = New HtmlTableCell
                    cell.InnerHtml = "<label class=tituloazul>OS's de " & cliente & "=" & _
                    i & "</label>"
                    dtRow.Cells.Add(cell)
                    htTable.Rows.Add(dtRow)
                    i = 0
                End If
                dtRow = New HtmlTableRow
                cell = New HtmlTableCell
                codcliente = row("cod_cliente")
                cliente = row("nome_cliente").ToString
                cell.InnerHtml = "<label class=tituloazul>" & cliente & "</label>"
                dtRow.Cells.Add(cell)
                htTable.Rows.Add(dtRow)
            End If

            dtRow = New HtmlTableRow

            cell = New HtmlTableCell
            cell.InnerHtml = "<label class=titulo>OS: " & d.adiciona_zeros(row("cod_cliente").ToString, 3) & "-" & _
            d.adiciona_zeros(row("doc_cliente").ToString, 6) & "</label>"
            'cell.Width = 180
            dtRow.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<label class=texto>OD:" & row("OD").ToString & "</label>"
            cell.Width = 300
            dtRow.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<label class=texto>" & FormatNumber(d.rd_db_num(row("esf_od_longe").ToString), 2) & "</label>"
            dtRow.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<label class=texto>" & FormatNumber(d.rd_db_num(row("cil_od_longe").ToString), 2) & "</label>"
            dtRow.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<label class=texto>" & FormatNumber(d.rd_db_num(row("esf_od_perto").ToString), 2) & "</label>"
            dtRow.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<label class=texto>" & FormatNumber(d.rd_db_num(row("cil_od_perto").ToString), 2) & "</label>"
            dtRow.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<label  class=texto>" & FormatNumber(d.rd_db_num(row("Base_od").ToString), 2) & "</label>"
            dtRow.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<label class=texto>" & FormatNumber(d.rd_db_num(row("adicao_od").ToString), 2) & "</label>"
            dtRow.Cells.Add(cell)


            htTable.Rows.Add(dtRow)


            dtRow = New HtmlTableRow

            cell = New HtmlTableCell
            cell.InnerHtml = "<label class=data>D. Verificacao:" & FormatDateTime(row("data_verificacao"), DateFormat.ShortDate) & _
            " Tempo:" & DateDiff(DateInterval.Day, row("data_verificacao"), Now) & "</label>"
            dtRow.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<label class=texto>OE:" & row("OE").ToString & "</label>"
            cell.Width = 300
            dtRow.Cells.Add(cell)

            cell = New HtmlTableCell

            cell.InnerHtml = "<label class=texto>" & FormatNumber(d.rd_db_num(row("esf_oe_longe").ToString), 2) & "</label>"
            dtRow.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<label class=texto>" & FormatNumber(d.rd_db_num(row("cil_oe_longe").ToString), 2) & "</label>"
            dtRow.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<label class=texto>" & FormatNumber(d.rd_db_num(row("esf_oe_perto").ToString), 2) & "</label>"
            dtRow.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<label class=texto>" & FormatNumber(d.rd_db_num(row("cil_oe_perto").ToString), 2) & "</label>"
            dtRow.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<label class=texto>" & FormatNumber(d.rd_db_num(row("Base_oe").ToString), 2) & "</label>"
            dtRow.Cells.Add(cell)

            cell = New HtmlTableCell
            cell.InnerHtml = "<label class=texto>" & FormatNumber(d.rd_db_num(row("adicao_oe").ToString), 2) & "</label>"
            dtRow.Cells.Add(cell)


            htTable.Rows.Add(dtRow)
            i = i + 1
            m = m + 1

        Next

        dtRow = New HtmlTableRow
        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=tituloazul>OS's de " & cliente & "=" & _
        i & "</label>"
        dtRow.Cells.Add(cell)
        htTable.Rows.Add(dtRow)

        dtRow = New HtmlTableRow
        cell = New HtmlTableCell
        cell.InnerHtml = "<label class=tituloazul>Total OS's pendentes=" & _
        m & "</label>"
        dtRow.Cells.Add(cell)
        htTable.Rows.Add(dtRow)

        Panel1.Controls.Add(htTable)


    End Sub
    Protected Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        cria_tabela()
    End Sub
End Class
