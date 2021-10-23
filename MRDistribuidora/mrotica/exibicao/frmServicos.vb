Imports mrotica_util
Imports MRUtil
Imports System.Xml
Imports System.IO
Imports System.Text
Imports System.Data

Public Class frmServicos
    Dim d As New ConexaoDB
    Dim chave As Integer
    Dim servico As New Servicos
    Dim Util As New Geral
    Dim strPesquisa As String = String.Empty

    Private Sub frmServicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Util.DesativaControles(Me)
        Carrega_combos()
    End Sub

    Private Sub Carrega_combos()
        Dim tbFab As New DataTable
        Dim tbTipo As New DataTable

        d.CarregaTabela("select * from fabricante", tbFab)
        cbFabricante.DataSource = tbFab
        cbFabricante.DisplayMember = "fabricante"
        cbFabricante.ValueMember = "id_fabricante"
        cbFabricante.SelectedIndex = -1

        d.CarregaTabela("Select * from tipo_servico ORDER by tipo_Servico", tbTipo)
        cbTipoServico.DataSource = tbTipo
        cbTipoServico.DisplayMember = "tipo_servico"
        cbTipoServico.ValueMember = "cod_tipo_servico"
        cbTipoServico.SelectedIndex = -1

    End Sub

    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        servico.PrimeiroRegistro()
        If servico.intPonteiro = 1 And servico.intContador > servico.intPonteiro Then
            btnPrimeiro.Enabled = False
            btnAnterior.Enabled = False
            btnProximo.Enabled = True
            btnUltimo.Enabled = True
        ElseIf servico.intPonteiro = 1 And servico.intContador = servico.intPonteiro Then
            btnPrimeiro.Enabled = False
            btnAnterior.Enabled = False
            btnProximo.Enabled = False
            btnUltimo.Enabled = False
        End If
        Campos()
    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        servico.ProximoRegistro()
        If servico.intPonteiro > 1 And servico.intContador > servico.intPonteiro Then
            btnPrimeiro.Enabled = True
            btnAnterior.Enabled = True
            btnProximo.Enabled = True
            btnUltimo.Enabled = True
        ElseIf servico.intPonteiro = servico.intPonteiro Then
            btnPrimeiro.Enabled = True
            btnAnterior.Enabled = True
            btnProximo.Enabled = False
            btnUltimo.Enabled = False
        End If
        Campos()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        servico.AnteriorRegistro()
        If servico.intPonteiro > 1 And servico.intContador > servico.intPonteiro Then
            btnPrimeiro.Enabled = True
            btnAnterior.Enabled = True
            btnProximo.Enabled = True
            btnUltimo.Enabled = True
        ElseIf servico.intPonteiro = 1 Then
            btnPrimeiro.Enabled = False
            btnAnterior.Enabled = False
            btnProximo.Enabled = True
            btnUltimo.Enabled = True
        End If
        Campos()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        servico.UltimoRegistro()
        If servico.intContador = servico.intPonteiro Then
            btnPrimeiro.Enabled = True
            btnAnterior.Enabled = True
            btnProximo.Enabled = False
            btnUltimo.Enabled = False
        End If
        Campos()
    End Sub

    Private Sub Campos()
        lblReg.Text = servico.TotalReg
        txtDescricao.Text = servico.ProdutoDescricao
        txtpvenda.Text = servico.PrecoVenda
        txtCusto.Text = servico.PrecoCusto
        cbFabricante.SelectedValue = servico.CodigoFabricante
        cbTipoServico.SelectedValue = servico.CodigoTipoServico
        txtPrazo.Text = servico.Prazo
        txtObs.Text = servico.Observacao
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Geral.TipoReg = Belemtech.TiposReg.Novo
        servico.Novo()
        lblReg.Text = "0"
        Util.AcaoBotoes(ToolStrip1, Belemtech.TiposReg.Novo)
        Util.AtivaControles(Me)
        txtDescricao.Focus()
        cbFabricante.SelectedIndex = -1
        cbTipoServico.SelectedIndex = -1
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Util.AcaoBotoes(ToolStrip1, Belemtech.TiposReg.Alterar)
        Util.AtivaControles(Me)
        txtDescricao.Focus()
        btnLocalizar.Enabled = True
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja excluir este registro?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            servico.ExcluirServico(servico.CodigoServico, servico.CodigoProduto)
            Util.AcaoBotoes(ToolStrip1, "Excluir")
            Geral.TipoReg = "N"
            Util.DesativaControles(Me)
        End If

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If MessageBox.Show("Deseja salvar este registro?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            servico.CodigoProduto = servico.Chave
            servico.CodigoServico = d.RetornaChave("cod_servico", "servicos", "")
            servico.CodigoFabricante = cbFabricante.SelectedValue
            servico.CodigoTipoServico = cbTipoServico.SelectedValue
            servico.CodigoGrupo = 4
            servico.ProdutoDescricao = txtDescricao.Text
            servico.Unidade = "UNI"
            If txtCusto.Text = "" Then
                txtCusto.Text = "0"
            End If
            servico.PrecoCusto = Convert.ToDecimal(txtCusto.Text)
            If txtpvenda.Text <> String.Empty Then
                servico.PrecoVenda = Convert.ToDecimal(txtpvenda.Text)
                servico.PrecoTabela = Convert.ToDecimal(txtpvenda.Text)
            Else
                servico.PrecoVenda = Nothing
            End If

            If txtPrazo.Text = "" Then
                txtPrazo.Text = "0"
            End If
            servico.Prazo = Convert.ToInt32(txtPrazo.Text)
            servico.Observacao = txtObs.Text

            If servico.VerificaCampoObrigatorio() = True Then
                Exit Sub
            End If

            servico.SalvarServico()

            Util.AcaoBotoes(ToolStrip1, Belemtech.TiposReg.Salvar)
            Util.DesativaControles(Me)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Util.AcaoBotoes(ToolStrip1, "Cancelar")
        Util.DesativaControles(Me)
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Close()
    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        servico.ParametroPesquisa = txtDescricao.Text
        servico.PrimeiroRegistro()
        If servico.intPonteiro = 1 And servico.intContador > servico.intPonteiro Then
            btnPrimeiro.Enabled = False
            btnAnterior.Enabled = False
            btnProximo.Enabled = True
            btnUltimo.Enabled = True
        ElseIf servico.intPonteiro = 1 And servico.intContador = servico.intPonteiro Then
            btnPrimeiro.Enabled = False
            btnAnterior.Enabled = False
            btnProximo.Enabled = False
            btnUltimo.Enabled = False
        End If
        Campos()
    End Sub

    Private Sub frmServicos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class