Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmPedidosFornecedor
    Dim d As New dados
    Public id_pedido As Integer
    Private Sub frmPedidosFornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formata_grid_faturas()
    End Sub
    Private Sub formata_grid_faturas()
        Dim strSQL As String = ""
        strSQL = "SELECT pedido_fornecedor.cod_pedido, fornecedor.Fornecedor, " & _
        "pedido_fornecedor.data_pedido, status_pedido_fornecedor.Status_pedido_fornecedor, " & _
        "(SELECT COUNT(item) FROM pedido_fornecedor_itens WHERE " & _
        " (cod_pedido = pedido_fornecedor.cod_pedido)) as quantidade " & _
        "FROM pedido_fornecedor INNER JOIN fornecedor ON pedido_fornecedor.cod_fornecedor " & _
        "= fornecedor.cod_fornecedor INNER JOIN " & _
        "status_pedido_fornecedor ON pedido_fornecedor.cod_status_pedido = " & _
        "status_pedido_fornecedor.cod_status_pedido order by pedido_fornecedor.cod_pedido desc"

        d.conecta()
        Dim da As New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.Fill(ds, "Pedido")
        d.desconecta()

        grdPedido.AutoGenerateColumns = False
        grdPedido.AllowUserToAddRows = False

        Dim pedido As New DataGridViewTextBoxColumn
        pedido.HeaderText = "Pedido"
        pedido.DataPropertyName = "cod_pedido"
        pedido.Width = 60
        pedido.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdPedido.Columns.Add(pedido)

        Dim fornecedor As New DataGridViewTextBoxColumn
        fornecedor.HeaderText = "Fornecedor"
        fornecedor.DataPropertyName = "Fornecedor"
        fornecedor.Width = 150
        grdPedido.Columns.Add(fornecedor)

        Dim quant As New DataGridViewTextBoxColumn
        quant.HeaderText = "Quantidade"
        quant.DataPropertyName = "quantidade"
        quant.Width = 85
        grdPedido.Columns.Add(quant)

        Dim status As New DataGridViewTextBoxColumn
        status.HeaderText = "Status"
        status.DataPropertyName = "status_pedido_fornecedor"
        status.Width = 130
        grdPedido.Columns.Add(status)

        Dim datapedido As New DataGridViewTextBoxColumn
        datapedido.HeaderText = "Data Pedido"
        datapedido.DataPropertyName = "data_pedido"
        datapedido.DefaultCellStyle.Format = "dd/MM/yyyy"
        datapedido.Width = 90
        datapedido.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdPedido.Columns.Add(datapedido)

        grdPedido.DataSource = ds.Tables(0)
    End Sub

    Private Sub grdPedido_DoubleClick(sender As System.Object, e As System.EventArgs) Handles grdPedido.DoubleClick
        id_pedido = grdPedido.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub

    Private Sub frmPedidosFornecedor_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        id_pedido = grdPedido.CurrentRow.Cells(0).Value
    End Sub
End Class