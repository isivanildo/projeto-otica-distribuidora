Imports winotica_util
Partial Public Class debitocliente
    Inherits System.Web.UI.Page
    Dim d As New dados("winweb", "winotica", "dellservidor", "winotica")
    Dim cliente As New objCliente(d)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Sub carrega()
        Dim valor As Double = 0.0
        grdAtrasos.DataSource = cliente.Debito_Cliente(Now())
        grdAtrasos.DataBind()
        For Each linha As GridViewRow In grdAtrasos.Rows
            valor = valor + CDbl(linha.Cells(4).Text)
        Next
        lblTotal.Text = Format(CDbl(valor), "#,##0.00")
    End Sub

    Protected Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        carrega()
    End Sub

    Protected Sub grdAtrasos_PreRender(sender As Object, e As System.EventArgs) Handles grdAtrasos.PreRender
        For Each linha As GridViewRow In grdAtrasos.Rows
            linha.Cells(5).Text = DateDiff(DateInterval.Day, CDate(linha.Cells(3).Text), CDate(linha.Cells(2).Text))
            linha.Cells(4).Text = Format(CDbl(linha.Cells(4).Text), "#,##0.00")
            If linha.Cells(5).Text > 0 Then
                linha.Cells(5).Text = 0
            End If
        Next
    End Sub
End Class
