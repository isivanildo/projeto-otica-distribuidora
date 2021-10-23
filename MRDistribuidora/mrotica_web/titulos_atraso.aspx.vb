Imports winotica_util
Partial Public Class titulos_atraso
    Inherits System.Web.UI.Page
    Dim d As New dados("winweb", "winotica", "dellservidor", "winotica")
    Dim cliente As New objCliente(d)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Sub carrega()
        grdAtrasos.DataSource = cliente.titulos_atraso
        lblTotal.Text = cliente.titulos_atraso_total
        grdAtrasos.DataBind()
    End Sub

    Protected Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        carrega()
    End Sub
End Class
