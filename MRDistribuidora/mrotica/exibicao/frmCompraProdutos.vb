Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmCompraProdutos
    Dim d As New dados
    Dim conf As New config
    Dim intFornecedor As Integer

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        Dim f As New frmRpt
        Dim r As New rptCompraProdutos
        Dim strSQL As String = ""
        Dim dtInicial As DateTime = dtIni.Value.ToShortDateString & " 00:00:01"
        Dim dtFinal As DateTime = dtFim.Value.ToShortDateString & " 23:59:59"
        Try

            If rbProduto.Checked = True Then
                strSQL = "select sum(conferencia_nota.quant) as quant, lentes_tabela.nome_comercial, lentes_tabela.cod_tabela," & _
                    "conferencia_nota.preco_nota, SUM(conferencia_nota.quant * conferencia_nota.preco_nota) as total from conferencia_nota inner join produtos on " & _
                    "conferencia_nota.cod_produto = produtos.cod_produto inner join lentes_blocos on " & _
                    "produtos.cod_lente = lentes_blocos.cod_lente inner join lentes_tabela on " & _
                    "lentes_blocos.cod_tabela = lentes_tabela.cod_tabela inner join conferencia_nota_master on " & _
                    "conferencia_nota_master.id_conferencia = conferencia_nota.id_conferencia inner join movimentomaster on " & _
                    "movimentomaster.cod_movimento = conferencia_nota_master.cod_movimento where " & _
                    "movimentomaster.data >= " & d.pdtm(dtInicial) & " and movimentomaster.data <= " & d.pdtm(dtFinal) & _
                    " and movimentomaster.concluido = 'S' and conferencia_nota.avulsa = 'N' and conferencia_nota.id_filial_nota = " & conf.Filial & _
                    " group by lentes_tabela.nome_comercial, lentes_tabela.cod_tabela, conferencia_nota.preco_nota " & _
                    "order by nome_comercial "
                r.Label3.Text = "Relatório de Compras por Produtos referente ao período de " & dtIni.Text & " à " & dtFim.Text
                r.GroupHeader1.Height = 0.0
                r.Label5.Visible = False
                r.Label6.Visible = False
                r.TextBox5.Visible = False
            End If

            If rbFornecedor.Checked = True Then
                If cbFornecedor.Text = "Todos" Then
                    strSQL = "select sum(conferencia_nota.quant) as quant, lentes_tabela.nome_comercial, lentes_tabela.cod_tabela," & _
                        "conferencia_nota.preco_nota, fabricante.fabricante, SUM(conferencia_nota.quant * conferencia_nota.preco_nota) as total " & _
                        "from conferencia_nota inner join produtos on " & _
                        "conferencia_nota.cod_produto = produtos.cod_produto inner join lentes_blocos on " & _
                        "produtos.cod_lente = lentes_blocos.cod_lente inner join lentes_tabela on " & _
                        "lentes_blocos.cod_tabela = lentes_tabela.cod_tabela  inner join conferencia_nota_master on " & _
                        "conferencia_nota_master.id_conferencia = conferencia_nota.id_conferencia inner join movimentomaster on " & _
                        "movimentomaster.cod_movimento = conferencia_nota_master.cod_movimento inner join fabricante on " & _
                        "fabricante.id_fabricante = lentes_tabela.id_fabricante where movimentomaster.data >= " & d.pdtm(dtInicial) & _
                        " and movimentomaster.data <= " & d.pdtm(dtFinal) & " and movimentomaster.concluido = 'S' and " & _
                        "conferencia_nota.avulsa IN ('N','S') and conferencia_nota.id_filial_nota = " & conf.Filial & _
                        " group by lentes_tabela.nome_comercial, lentes_tabela.cod_tabela, conferencia_nota.preco_nota, fabricante.fabricante " & _
                        "order by fabricante"
                Else
                    strSQL = "select sum(conferencia_nota.quant) as quant, lentes_tabela.nome_comercial, lentes_tabela.cod_tabela," & _
                        "conferencia_nota.preco_nota, fabricante.fabricante, SUM(conferencia_nota.quant * conferencia_nota.preco_nota) as total " & _
                        "from conferencia_nota inner join produtos on " & _
                        "conferencia_nota.cod_produto = produtos.cod_produto inner join lentes_blocos on " & _
                        "produtos.cod_lente = lentes_blocos.cod_lente inner join lentes_tabela on " & _
                        "lentes_blocos.cod_tabela = lentes_tabela.cod_tabela  inner join conferencia_nota_master on " & _
                        "conferencia_nota_master.id_conferencia = conferencia_nota.id_conferencia inner join movimentomaster on " & _
                        "movimentomaster.cod_movimento = conferencia_nota_master.cod_movimento inner join fabricante on " & _
                        "fabricante.id_fabricante = lentes_tabela.id_fabricante where movimentomaster.data >= " & d.pdtm(dtInicial) & _
                        " and movimentomaster.data <= " & d.pdtm(dtFinal) & " and movimentomaster.concluido = 'S' and " & _
                        "conferencia_nota.avulsa IN ('N','S') and conferencia_nota.id_filial_nota = " & conf.Filial & _
                        " and lentes_tabela.id_fabricante = " & intFornecedor & _
                        " group by lentes_tabela.nome_comercial, lentes_tabela.cod_tabela, conferencia_nota.preco_nota, fabricante.fabricante " & _
                        "order by fabricante"
                End If

                r.Label3.Text = "Relatório de Compras por Fornecedor referente ao período de " & dtIni.Text & " à " & dtFim.Text
                r.GroupHeader1.DataField = "fabricante"
                r.Label5.DataField = "fabricante"
                r.GroupHeader1.BackColor = Color.BurlyWood
            End If


            d.conecta()
            Dim da As New SqlDataAdapter(strSQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Compras")

            If ds.Tables(0).Rows.Count > 0 Then
                r.DataSource = ds.Tables(0)
            Else
                MessageBox.Show("Não há registro a ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            f.Relat(r)
            f.ShowDialog()
            f.Dispose()
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub frmCompraProdutos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbFornecedor.Items.Insert(0, "Todos")
        carrega_cb()
    End Sub

    Private Sub carrega_cb()
        Dim sql As String
        sql = "Select id_fabricante,fabricante from fabricante order by fabricante"
        Dim cmd As New SqlCommand(sql, d.con)
        Dim dr As SqlDataReader
        d.conecta()
        dr = cmd.ExecuteReader
        Do While dr.Read()
            cbFornecedor.Items.Add(dr("fabricante").ToString)
        Loop
        dr.Close()
        d.desconecta()
    End Sub

    Private Function retorna_codigo_fabricante(ByVal fabricante As String) As Integer
        Dim sql As String
        Dim retorno As Integer
        sql = "Select id_fabricante from fabricante where fabricante = '" & fabricante & "'"
        Dim cmd As New SqlCommand(sql, d.con)
        Dim dr As SqlDataReader
        Try
            d.conecta()
            dr = cmd.ExecuteReader
            dr.Read()
            retorno = dr("id_fabricante").ToString
            dr.Close()
            d.desconecta()
            Return retorno
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub rbFornecedor_Click(sender As System.Object, e As System.EventArgs) Handles rbFornecedor.Click
        If rbFornecedor.Checked = True Then
            cbFornecedor.Visible = True
        End If
    End Sub

    Private Sub rbProduto_Click(sender As System.Object, e As System.EventArgs) Handles rbProduto.Click
        If rbProduto.Checked = True Then
            cbFornecedor.Visible = False
        End If
    End Sub


    Private Sub cbFornecedor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbFornecedor.SelectedIndexChanged
        If cbFornecedor.SelectedIndex <> 0 Then
            intFornecedor = retorna_codigo_fabricante(cbFornecedor.Text)
        End If
    End Sub
End Class