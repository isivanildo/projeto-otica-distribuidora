Imports winotica_util
Imports anamaria
Imports System.Data

Partial Public Class OSOtica
    Inherits System.Web.UI.Page
    Dim d As New dados("winweb", "winotica", "192.168.0.102", "winotica")
    Dim rOS As New Service
    Dim lt As New objTabela(d)
    Dim cred As New Net.NetworkCredential("labonorte", "senha", "labonorte.local")
    Dim pr As New Net.WebProxy
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pr.Credentials = cred
    End Sub

    Protected Sub btnConsulta_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConsulta.Click
        Dim ds As New DataSet
        Dim tOS, tAnd, tTrat As New DataTable
        Try
            rOS.Proxy = pr
            ds = rOS.os_com_andamentos(txtOS.Text, txtFilial.Text)
            txtOD.Text = ""
            txtOE.Text = ""
            txtOBS.Text = ""
            lblStatus.Text = ""
            tOS = ds.Tables(0)
            tAnd = ds.Tables(1)
            tTrat = ds.Tables(2)
            txtOD.Text = "OD: " & lt.ret_nome_tabela(tOS.Rows(0)("cod_tab_od"))
            txtOE.Text = "Oe: " & lt.ret_nome_tabela(tOS.Rows(0)("cod_tab_oe"))
            txtOBS.Text = tOS.Rows(0)("observacao")
            grdTratamentos.DataSource = tTrat
            grdTratamentos.DataBind()
        Catch ex As Exception
            lblStatus.Text = ex.Message
        End Try


    End Sub
End Class
