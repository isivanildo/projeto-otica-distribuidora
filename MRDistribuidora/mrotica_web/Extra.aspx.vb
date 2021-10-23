Imports winotica_util
Imports System.Data

Partial Public Class Extra


    Inherits System.Web.UI.Page
    Dim d As New dados("winweb", "winotica", "192.168.3.102", "winotica")

    Dim tt As New Data.DataTable
    Dim tabela_final As New Data.DataTable
    Dim tabela_producao As New Data.DataTable 'Tabela usada para calcular o valor da produção
    Dim ttot As New Data.DataTable
    Dim totalExtra, totalProd As Integer
    Dim di, df As String
    Protected Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim ds As New DataSet
        Try
            di = txtInicio.Text & " 00:00:00"
            df = txtFim.Text & " 23:59:59"
            carrega_extras()
            precos_labo()
            grdLabonorte.DataSource = tabela_final
            grdLabonorte.DataBind()
            totalExtra = d.readNum((tabela_final.Compute("SUM(olhos)", String.Empty)))
            lblTotal.Text = totalExtra.ToString & " lentes em " & _
            (tabela_final.Rows.Count) & " OS's."
            lblTotalDin.Text = FormatCurrency(d.readNum((tabela_final.Compute("SUM(Valor)", String.Empty))) _
                                             , 2)
            producao()
            lblPorQuant.Text = (CDbl(totalExtra) / CDbl(totalProd)).ToString("P")
            lblPorFin.Text = (CDbl(lblTotalDin.Text) / CDbl(lblTotalProdDin.Text)).ToString("P")
        Catch ex As Exception
            lblStatus.Text = ex.ToString
        End Try
    End Sub
    Private Sub precos_labo()
        Dim r As DataRow
        Dim valor As Double = 0
        Dim olhos As Integer = 0
        tabela_final.Columns.Add("Valor", Type.GetType("System.Double"))
        tabela_final.Columns.Add("olhos", Type.GetType("System.Int32"))
        For Each r In tabela_final.Rows
            olhos = 0
            valor = 0
            If r("OD") = "S" Then
                valor = d.rd_db_num(r("preco_od"))
                olhos = olhos + 1
            End If
            If r("OE") = "S" Then
                valor = valor + d.rd_db_num(r("preco_oe"))
                olhos = olhos + 1
            End If
            r("valor") = valor
            r("olhos") = olhos
        Next
    End Sub
    Private Sub carrega_extras()
        Dim sql As String
        sql = "SELECT OS.cod_cliente, OS.cod_os, saida_extra.Desc_saida_extra, saida_extra.od, " & _
        "saida_extra.oe,  movimentomaster.data," & _
        "(SELECT nome_comercial FROM lentes_tabela  WHERE (cod_tabela = OS.cod_tab_od)) AS POD, " & _
        "(SELECT nome_comercial FROM lentes_tabela  WHERE (cod_tabela = OS.cod_tab_oe)) AS POE, " & _
        "(SELECT preco_compra - (preco_compra * (desconto_compra / 100)) AS preco " & _
        "FROM lentes_tabela wHERE (cod_tabela = OS.cod_tab_od)) as preco_od, " & _
        "(SELECT preco_compra - (preco_compra * (desconto_compra / 100)) AS preco " & _
        "FROM lentes_tabela  WHERE (cod_tabela = OS.cod_tab_oe)) AS Preco_oe, " & _
        "OS.cod_tab_od, OS.cod_tab_oe, movimentomaster.id_usuario, Usuarios.NOME," & _
        "cliente.nome_cliente FROM saida_extra INNER JOIN " & _
        "OS ON saida_extra.id_filial = OS.id_filial AND saida_extra.cod_os = OS.cod_os INNER JOIN " & _
        "movimentomaster ON saida_extra.cod_movimento = movimentomaster.cod_movimento AND " & _
        "saida_extra.id_filial_movimento = movimentomaster.id_filial INNER JOIN " & _
        "Usuarios ON movimentomaster.id_usuario = Usuarios.cod_usuario " & _
        "inner join cliente on OS.cod_cliente = cliente.cod_cliente and OS.cod_filial_cliente = " & _
        "cliente.cod_filial_cliente WHERE (OS.cod_cliente > 999) AND (movimentomaster.data >= " & _
        d.pdtm(di) & ") AND (movimentomaster.data <= " & d.pdtm(df) & ") " & _
        "ORDER BY movimentomaster.data, cliente.nome_cliente, OS.cod_cliente, OS.cod_os"
        d.carrega_Tabela(sql, tabela_final)
    End Sub
    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        txtInicio.Text = "01/" & Now.Month & "/" & Now.Year
        txtFim.Text = Now.Day & "/" & Now.Month & "/" & Now.Year
    End Sub
    Private Sub producao()
        Dim sql As String
        Dim di, df As String
        Dim valor As Double
        Dim r As DataRow
        Dim olhos As Integer = 0
        Try
            di = txtInicio.Text & " 00:00:00"
            df = txtFim.Text & " 23:59:59"
            sql = "SELECT id_filial, cod_os, cod_tab_od, cod_tab_oe " & _
            "FROM dbo.OS_sai_lab_periodo(" & d.pdtm(di) & "," & d.pdtm(df) & ", 1) AS OS_sai_lab"
            d.carrega_Tabela(sql, tabela_producao)
            tabela_producao.Columns.Add("valor", Type.GetType("System.Double"))
            tabela_producao.Columns.Add("olhos", Type.GetType("System.Double"))
            For Each r In tabela_producao.Rows
                valor = 0
                olhos = 0
                valor = preco_winotica(r("cod_tab_od").ToString)
                olhos = fOlhos(r("cod_tab_od"))
                valor = valor + preco_winotica(r("cod_tab_oe").ToString)
                olhos = olhos + fOlhos(r("cod_tab_oe"))
                r("valor") = valor
                r("olhos") = olhos
            Next
            totalProd = tabela_producao.Compute("SUM(olhos)", String.Empty)

            lblTotalProd.Text = totalProd.ToString & " lentes em " & _
            (tabela_producao.Rows.Count) & " OS's."
            lblTotalProdDin.Text = FormatCurrency(tabela_producao.Compute("SUM(valor)", String.Empty), 2)
        Catch ex As Exception
            lblStatus.Text = ex.ToString
        End Try
    End Sub
    Private Function fOlhos(ByVal cod_tab As Integer) As Integer
        If cod_tab = 1 Or cod_tab = 2 Or cod_tab = 0 Then
            Return 0
        Else
            Return 1
        End If
    End Function
    Private Function diaSemanaINTtoSTR(ByVal dia As Integer) As String
        Try
            Select Case dia
                Case 1
                    Return "Domingo"
                Case 2
                    Return "Segunda"
                Case 3
                    Return "Terça"
                Case 4
                    Return "Quarta"
                Case 5
                    Return "Quinta"
                Case 6
                    Return "Sexta"
                Case 7
                    Return "Sábado"
                Case Else
                    Return Nothing
            End Select
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Function preco_winotica(ByVal cod_tabela As String) As Double
        Dim sql As String
        Dim tt As New DataTable
        Try

            If cod_tabela.Trim = "1" Or cod_tabela.Trim = "0" Or cod_tabela.Trim = "2" Then
                Return 0
                Exit Function
            End If
            sql = "SELECT preco_compra - (preco_compra * (desconto_compra / 100)) AS preco " & _
            "FROM lentes_tabela  WHERE (cod_tabela = " & cod_tabela & ")"
            d.carrega_Tabela(sql, tt)
            Return tt.Rows(0)("preco")
        Catch ex As Exception
            Return 0
            Exit Function
        End Try
    End Function
End Class