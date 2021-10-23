Imports winotica_util
Partial Class nota
    Inherits System.Web.UI.Page
    Dim total As Integer = 0
    Dim d As New dados("winweb", "winotica", "dellservidor", "winotica")
    Dim entrada As New objEntradaNota(d)
    Dim nota As Integer
    Dim filial As Integer
    Private Sub carrega_nota(ByVal nota As Integer, ByVal filial As Integer)
        Dim doc As String
        doc = entrada.documento_conferencia(nota, filial)
        grdItens.DataSource = entrada.lista_itens_impressao_nota(doc)
        grdItens.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        nota = Request.QueryString("nota")
        filial = Request.QueryString("filial")
        carrega_nota(nota, filial)

    End Sub

    Protected Sub grdItens_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdItens.DataBound
        For Each row As GridViewRow In grdItens.Rows
            total = total + row.Cells(1).Text
        Next
        Dim footer As GridViewRow
        footer = grdItens.FooterRow
        grdItens.FooterRow.Visible = True
        footer.Cells(1).HorizontalAlign = HorizontalAlign.Right
        footer.Cells(1).Text = total
    End Sub

End Class
