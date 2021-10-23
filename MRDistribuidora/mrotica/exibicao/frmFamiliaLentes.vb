Imports mrotica_util
Imports System.Data
Imports System.Data.SqlClient
Public Class frmFamiliaLentes
    Dim familia As New objFamilia
    Dim d As New dados
    Dim dados As New objMaster
#Region "Load, Carrega_dados..."
    Private Sub frmFamiliaLentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AtivaControle(True)
        lblCodFamilia.Text = ""
        'travaControles(Me.Controls)
        'familia.primeiro()
        'c_dados()
    End Sub
    Private Sub c_dados()
        'If familia.max = 0 Then
        'LimpaControles(Me.Controls)
        'Exit Sub
        'End If
        txtFamilia.Text = familia.familia
        txtDescricao.Text = familia.descricao
        lblCodFamilia.Text = familia.cod_familia
        carrega_Lentes()
    End Sub
    'Private Sub carrega_lentes()
    'grdLentes.DataSource = familia.lista_produtos
    'grdLentes.Refresh()
    'End Sub
#End Region
#Region "Novo,Salvar, Editar MASTER"

    Private Sub btnDeletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim res As String = ""
        res = familia.deletar()
        If res.Trim.Substring(0, 3) = "OK:" Then
            MsgBox(res.Trim.Substring(3))
            c_dados()
            Cursor = Cursors.Default
        End If
        If res.Trim.Substring(0, 3) = "ER:" Then
            MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
        End If
    End Sub
#End Region
    Private Sub NovaLenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovaLenteToolStripMenuItem.Click
        Dim cod_lente As Integer
        Dim f As New frmConsultaLenteTabela
        f.ShowDialog(Me)
        If f.tabRes Is Nothing Then
            Exit Sub
        End If
        For Each r As DataRow In f.tabRes.Rows
            familia.Inserir_produto(r("cod_tabela"))
            Application.DoEvents()
        Next
        'cod_lente = f.cod_tabela
        'AVISO(familia.Inserir_produto(cod_lente), Me, frmAviso.tipo_aviso.tipo_ok, False)
        carrega_Lentes()
        MsgBox("Concluído!")
    End Sub

    Private Sub carrega_Lentes()
        grdLentes.Columns.Clear()
        'instrução sql que traz os registros
        Dim strSQL As String = "SELECT lentes_tabela.nome_comercial, familia_lentes_itens.cod_tabela " & _
        " FROM familia_lentes_itens INNER JOIN lentes_tabela ON familia_lentes_itens.cod_tabela = " & _
        "lentes_tabela.cod_tabela where familia_lentes_itens.cod_familia = " & familia.cod_familia & _
        " order by lentes_tabela.id_fabricante, lentes_tabela.nome_comercial"
        'conecta aos banco de dados
        d.conecta()
        'objeto de leitura dos valores retornados
        Dim dr As SqlDataReader

        'Cria a coluna Conta
        Dim nome As New DataGridViewTextBoxColumn
        nome.HeaderText = "Nome da Lente"
        nome.Width = 400
        grdLentes.Columns.Add(nome)

        'Cria a coluna Nome
        Dim codigo As New DataGridViewTextBoxColumn
        codigo.HeaderText = "Cód. Tabela"
        codigo.Width = 90
        codigo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdLentes.Columns.Add(codigo)

        d.carrega_reader(strSQL, dr)

        While dr.Read()
            grdLentes.Rows.Add(dr.Item("nome_comercial"), dr.Item("cod_tabela"))
        End While

        dr.Close()
        d.desconecta()
    End Sub

    Private Sub btnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles btnAnterior.Click
        familia.anterior()
        c_dados()
        AtivaControle(False)
    End Sub

    Private Sub btnProximo_Click(sender As System.Object, e As System.EventArgs) Handles btnProximo.Click
        familia.proximo()
        c_dados()
        AtivaControle(False)
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        familia.novo()
        AtivaControle(False)
        'DestravaControles(Me.Controls)
        'LimpaControles(Me.Controls)
        lblCodFamilia.Text = ""
        txtFamilia.Text = ""
        txtDescricao.Text = ""
        grdLentes.Columns.Clear()
        txtFamilia.Focus()
        lblCodFamilia.Text = dados.retornaUltimoRegistro("Familia_Lentes", "Cod_Familia") + 1
    End Sub

    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click
        Dim res As String = ""
        res = familia.deletar()
        If res.Trim.Substring(0, 3) = "OK:" Then
            MsgBox(res.Trim.Substring(3))
            c_dados()
            Cursor = Cursors.Default
        End If
        If res.Trim.Substring(0, 3) = "ER:" Then
            MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
        End If
        AtivaControle(True)
    End Sub

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
        Me.Cursor = Cursors.WaitCursor
        Dim res As String = ""
        'chave = retorna_Chave("codCliente", "clientes") + 1
        familia.familia = txtFamilia.Text
        familia.descricao = txtDescricao.Text
        res = familia.Salvar()
        MsgBox(res)
        c_dados()
        travaControles(Me.Controls)
        Me.Cursor = Cursors.Default
        AtivaControle(True)
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnUltimo_Click(sender As System.Object, e As System.EventArgs) Handles btnUltimo.Click
        familia.ultimo()
        c_dados()
        travaControles(Me.Controls)
        AtivaControle(False)
    End Sub

    Private Sub btnPrimeiro_Click(sender As System.Object, e As System.EventArgs) Handles btnPrimeiro.Click
        familia.primeiro()
        c_dados()
        AtivaControle(False)
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        familia.editar()
    End Sub

    Private Sub AtivaControle(ByVal valor As Boolean)
        If valor = True Then
            btnNovo.Enabled = True
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
            btnSalvar.Enabled = False
            btnCancelar.Enabled = False
            btnSair.Enabled = True
        Else
            btnNovo.Enabled = False
            btnEditar.Enabled = True
            btnExcluir.Enabled = True
            btnSalvar.Enabled = True
            btnCancelar.Enabled = True
            btnSair.Enabled = False
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        AtivaControle(True)
    End Sub

    Private Sub ExcluirLenteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExcluirLenteToolStripMenuItem.Click
        Dim cod_lente As Integer
        cod_lente = grdLentes.Item(1, grdLentes.CurrentCell.RowIndex).Value
        MsgBox(familia.remover_produto(cod_lente))
        carrega_Lentes()
    End Sub

End Class