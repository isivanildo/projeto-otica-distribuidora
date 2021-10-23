Imports winotica_util
Partial Class clientes
    Inherits System.Web.UI.Page
    Dim fat As objFaturamento
    Dim d As New dados("winweb", "winotica", "dellservidor", "winotica")
    Protected Sub btnCarrega_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCarrega.Click
        Dim clientes As New objCliente(d)
        Dim tt As New Data.DataTable
        If rdTodos.Checked = True Then
            tt = clientes.lista_clientes
        ElseIf rd30Dias.Checked = True Then
            tt = clientes.lista_clientes_30
        Else
            tt = clientes.lista_clientes_Ativos_nao_30
        End If

        rpView.LocalReport.ReportEmbeddedResource = Server.MapPath("rptListaClientes.rdlc")
        ' Dim pr = New Microsoft.Reporting.WebForms.ReportParameter("titulo", "Listagem de Clientes")
        Dim rds = New Microsoft.Reporting.WebForms.ReportDataSource("ds", tt)

        rpView.LocalReport.DataSources.Clear()
        rpView.LocalReport.DataSources.Add(rds)
        rpView.LocalReport.Refresh()

    End Sub

    Protected Sub btnVoltar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Response.Redirect("../default.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then

        End If
    End Sub
End Class
