Imports mrotica_util
Public Class TestePreco
    Dim acesso As New objMaster
    Dim d As New dados



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        For Each linha As DataGridViewRow In DataGridView1.Rows
            If Not linha.Cells(3).Value Is DBNull.Value Then
                Dim strSQL As String = "preco_tab = " & d.cdin(linha.Cells(3).Value) & _
                    ", preco = preco - (preco * desconto/100) " & _
                    "where num_pedido = " & linha.Cells(0).Value & _
                " and id_filial = " & linha.Cells(1).Value & " and item = " & linha.Cells(2).Value & " and desconto = 43.49999"
                acesso.atualiza_registros("pedido_balcao_itens", strSQL, True)
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = Nothing

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AutoGenerateColumns = False

        Dim pedido As New DataGridViewTextBoxColumn '00
        pedido.HeaderText = "Pedido"
        pedido.DataPropertyName = "num_pedido"
        pedido.Width = 100
        DataGridView1.Columns.Add(pedido)

        Dim id_filial As New DataGridViewTextBoxColumn '01
        id_filial.HeaderText = "Filial"
        id_filial.DataPropertyName = "id_filial"
        id_filial.Width = 40
        DataGridView1.Columns.Add(id_filial)

        Dim item As New DataGridViewTextBoxColumn '02
        item.HeaderText = "Item"
        item.DataPropertyName = "item"
        item.Width = 40
        DataGridView1.Columns.Add(item)

        Dim preco As New DataGridViewTextBoxColumn '03
        preco.HeaderText = "Preço"
        preco.DataPropertyName = "preco"
        preco.Width = 80
        DataGridView1.Columns.Add(preco)


        'Dim strSQL As String = "select num_pedido, id_filial, item, preco from pedido_balcao_itens"
        'Dim strSQL As String = "select num_pedido, id_filial, item, preco from pedido_balcao_itens where desconto = 0"
        Dim strSQL As String = "select num_pedido, id_filial, item, preco from pedido_balcao_itens where   preco_tab IS NULL"
        Dim tt As New DataTable

        tt = acesso.retornaRegistro(strSQL).Tables(0)

        Label1.Text = tt.Rows.Count

        DataGridView1.DataSource = tt
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = Nothing

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AutoGenerateColumns = False

        Dim pedido As New DataGridViewTextBoxColumn '00
        pedido.HeaderText = "Pedido"
        pedido.DataPropertyName = "num_pedido"
        pedido.Width = 100
        DataGridView1.Columns.Add(pedido)

        Dim id_filial As New DataGridViewTextBoxColumn '01
        id_filial.HeaderText = "Filial"
        id_filial.DataPropertyName = "id_filial"
        id_filial.Width = 40
        DataGridView1.Columns.Add(id_filial)

        Dim item As New DataGridViewTextBoxColumn '02
        item.HeaderText = "Item"
        item.DataPropertyName = "item_servico"
        item.Width = 40
        DataGridView1.Columns.Add(item)

        Dim preco As New DataGridViewTextBoxColumn '03
        preco.HeaderText = "Preço"
        preco.DataPropertyName = "preco"
        preco.Width = 80
        DataGridView1.Columns.Add(preco)


        'Dim strSQL As String = "select num_pedido, id_filial, item, preco from pedido_balcao_itens"
        Dim strSQL As String = "select num_pedido, id_filial, item_servico, preco from pedido_balcao_servicos"
        Dim tt As New DataTable

        tt = acesso.retornaRegistro(strSQL).Tables(0)

        DataGridView1.DataSource = tt
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        For Each linha As DataGridViewRow In DataGridView1.Rows
            If Not linha.Cells(3).Value Is DBNull.Value Then
                Dim strSQL As String = "preco_tab = " & d.cdin(linha.Cells(3).Value) & _
                    ", preco = preco - (preco * desconto/100) " & _
                    "where num_pedido = " & linha.Cells(0).Value & _
                " and id_filial = " & linha.Cells(1).Value & " and item_servico = " & linha.Cells(2).Value
                acesso.atualiza_registros("pedido_balcao_servicos", strSQL, True)
            End If
        Next
    End Sub

    Private Sub TestePreco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class