Imports mrotica_util

Public Class frmTesteFatura
    Dim os As New objMaster
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim tbOS As New DataTable
        Dim strsQL As String = "select os.id_filial, os.cod_os, os.num_pedido, os.cod_cliente, os.doc_cliente, pedido_balcao.cod_status_pedido " & _
            "from OS inner join pedido_balcao on os.num_pedido = pedido_balcao.num_pedido and os.cod_cliente = pedido_balcao.cod_cliente " & _
            "where os.cod_cliente < 1000 And pedido_balcao.cod_status_pedido = 2 And Not os.doc_cliente Is null " & _
            "order by cod_cliente"
        tbOS = os.retornaRegistro(strsQL).Tables(0)
        DataGridView1.DataSource = tbOS
    End Sub

    Private Sub frmTesteFatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class