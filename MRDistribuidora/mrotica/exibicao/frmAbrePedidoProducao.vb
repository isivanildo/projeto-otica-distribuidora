Imports mrotica_util
Public Class frmAbrePedidoProducao
    Dim prod As New objEntradaProducao

    Private Sub frmAbrePedidoProducao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grd.DataSource = prod.lista_pedidos
    End Sub
End Class