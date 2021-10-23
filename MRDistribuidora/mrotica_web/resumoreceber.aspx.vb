Imports winotica_util
Partial Public Class resumoreceber
    Inherits System.Web.UI.Page
    Dim d As New dados("winweb", "winotica", "dellservidor", "winotica")
    Dim cliente As New objCliente(d)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Sub carrega()
        grdAtrasos.DataSource = cliente.resumo_receber(ordem())
        lblTotal.Text = cliente.resumo_receber_total
        lblTotalAtraso.Text = cliente.titulos_atraso_total
        Try
            lblPercAtraso.Text = Math.Round((CDbl(lblTotalAtraso.Text) / CDbl(lblTotal.Text)) * 100, 2) & " %"
        Catch ex As Exception
            lblPercAtraso.Text = "%"
        End Try
        grdAtrasos.DataBind()
    End Sub
    Private Function ordem() As String
        Dim strOrdem As String = ""
        If rdAtrasos.Checked = True Then
            strOrdem = " Order by titulos_atraso desc"
        ElseIf rdTotal.Checked Then
            strOrdem = " Order by total_aberto desc"
        End If
        Return strOrdem
    End Function
    Protected Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        carrega()
    End Sub
End Class
