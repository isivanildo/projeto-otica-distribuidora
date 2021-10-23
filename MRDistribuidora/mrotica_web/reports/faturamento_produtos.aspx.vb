Imports winotica_util
Partial Class reports_faturamento_produtos
    Inherits System.Web.UI.Page
    Dim fat As objFaturamento
    Dim d As New dados("winweb", "winotica", "dellservidor", "winotica")
    Protected Sub btnCarrega_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCarrega.Click
        fat = New objFaturamento(d)
        fat.data_inicial = txtIni.Text & " 00:00:00"
        fat.data_final = txtFim.Text & " 23:59:59"

        rpView.LocalReport.ReportEmbeddedResource = Server.MapPath("rptFatutamentoProdutods.rdlc")
        Dim rds = New Microsoft.Reporting.WebForms.ReportDataSource("ds", fat.faturamento_produtos)
        rpView.LocalReport.DataSources.Clear()
        rpView.LocalReport.DataSources.Add(rds)
        rpView.LocalReport.Refresh()

    End Sub

    Protected Sub btnVoltar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Response.Redirect("../default.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            txtIni.Text = "01/" & Now.Month & "/" & Now.Year
            txtFim.Text = Now.ToString("dd/MM/yyyy")
        End If
    End Sub
End Class
