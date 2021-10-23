Imports mrotica_util
Imports System.Data
Imports System.Data.SqlClient

Public Class frmDevolucaoProdutoEstoque
    Dim estoque As New objMaster
    Dim d As New dados

    Dim nota As New objEntradaNota

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim rp As New rptProdutoDevEstoque
        Dim f As New frmRpt

        If (txtNumPedido.Text = String.Empty) Or (txtIdFilial.Text = String.Empty) Then
            MessageBox.Show("Os campos Número Pedido e Filial são obrigatórios para a operação.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim strSQL As String = "Select pedido_balcao.num_pedido, pedido_balcao.id_filial,usuarios.nome,  pedido_balcao.data_pedido, " & _
        "pedido_balcao.cod_cliente, pedido_balcao.cod_filial_cliente, pedido_balcao.cod_status_pedido, cliente.nome_cliente " & _
        "from pedido_balcao INNER JOIN usuarios ON  pedido_balcao.cod_vendedor =  usuarios.cod_usuario " & _
        "INNER JOIN cliente ON pedido_balcao.cod_cliente = cliente.cod_cliente  where pedido_balcao.num_pedido = " & CInt(txtNumPedido.Text) & _
        " And pedido_balcao.id_filial = " & CInt(txtIdFilial.Text) & ""
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim dr As SqlDataReader

        Try
            d.conecta()
            dr = cmd.ExecuteReader
            dr.Read()
            rp.TextBox9.Text = dr.Item("Num_Pedido").ToString
            'rp.TextBox3.Text = dr.Item("id_filial").ToString
            rp.TextBox11.Text = dr.Item("nome").ToString
            rp.TextBox18.Text = FormatDateTime(dr.Item("data_pedido").ToString, DateFormat.ShortDate)
            rp.TextBox4.Text = dr.Item("nome_cliente").ToString
            rp.TextBox3.Text = dr.Item("cod_cliente").ToString
            rp.Label6.Visible = False
            rp.Label10.Text = "Produtos estornados para o estoque."
            rp.DataSource = estoque.retona_produtos_estoque(CInt(txtNumPedido.Text), 5)
            rp.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
            f.Relat(rp)
            f.ShowDialog(Me)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

End Class