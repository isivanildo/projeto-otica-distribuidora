Imports winotica_util
Partial Class saldo_contabil
    Inherits System.Web.UI.Page
    Dim d As New dados("winweb", "winotica", "dellservidor", "winotica")
    Dim tt As New Data.DataTable
    Protected Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim sql As String
        Dim dia As String
        dia = txtData.Text & " 23:59:59"
        sql = "Select *, (preco*saldo) as total from saldos_lentes(" & d.pdtm(dia) & "," & _
          txtFilial.Text & ") " & _
        " where(saldo > 0) order by nome_comercial "
        d.carrega_Tabela(sql, tt)
        grdSaldos.DataSource = tt
        grdSaldos.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            txtData.Text = Now.Date.ToString("dd/MM/yyyy")
        End If
    End Sub
End Class
