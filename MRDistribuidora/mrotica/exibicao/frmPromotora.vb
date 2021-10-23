Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Imports MRUtil
Public Class frmPromotora
    Dim d As New dados
    Dim Conexao As New ConexaoDB()
    Dim Util As New Geral()
    Dim Promotor As New Promotor()

    'Dim promotor As New objMaster
    Dim strTipo As String = ""
    Dim intCodigo As Integer

    Private Sub frmPromotora_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carregaGrid()
    End Sub

    Public Sub carregaGrid()
        grdPromotora.Columns.Clear()
        grdPromotora.DataSource = Nothing
        grdPromotora.AutoGenerateColumns = False
        grdPromotora.AllowUserToAddRows = False
        Dim codigo As New DataGridViewTextBoxColumn
        codigo.HeaderText = "Código"
        codigo.DataPropertyName = "cod_Promotor"
        codigo.Width = 60
        codigo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        codigo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        codigo.SortMode = DataGridViewColumnSortMode.NotSortable
        grdPromotora.Columns.Add(codigo)

        Dim promotor As New DataGridViewTextBoxColumn
        promotor.HeaderText = "Promotor"
        promotor.DataPropertyName = "promotor"
        promotor.Width = 270
        grdPromotora.Columns.Add(promotor)

        Dim situacao As New DataGridViewTextBoxColumn
        situacao.HeaderText = "Situacao"
        situacao.DataPropertyName = "situacao"
        situacao.Visible = False
        grdPromotora.Columns.Add(situacao)

        Dim strSQL As String = "select * from promotor"
        Dim tbPromotor As New DataTable

        Conexao.CarregaTabela(strSQL, tbPromotor)
        grdPromotora.DataSource = tbPromotor
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        Geral.TipoReg = "N"
        Util.AtivaControles(Me)
        Util.AcaoBotoes(ToolStrip1, "Novo")
        Dim intCodigo As Integer = Conexao.RetornaChave("cod_promotor", "promotor", "")
        txtCodPromotor.Text = intCodigo
        txtNome.Focus()
    End Sub

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
        Promotor.CodigoPromotor = Convert.ToInt32(txtCodPromotor.Text)
        Promotor.NomePromotor = txtNome.Text
        Promotor.Situacao = cbAtivo.Checked

        If Promotor.VerificaCampoObrigatorio() = True Then
            Exit Sub
        End If

        If MessageBox.Show("Deseja salvar ou alterar este registro?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If Geral.TipoReg = "N" Then
                Promotor.SalvaPromotor()
            Else
                Promotor.AtualizaPromotor(Promotor.CodigoPromotor)
            End If
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        carregaGrid()
        Util.AcaoBotoes(ToolStrip1, "Salvar")
        Util.DesativaControles(Me)
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Deseja cancelar esta operação?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            txtNome.Text = ""
            txtCodPromotor.Text = ""
            Util.DesativaControles(Me)
            Util.AcaoBotoes(ToolStrip1, "Cancelar")
        End If
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar.Click
        Geral.TipoReg = "A"
        Util.AtivaControles(Me)
        Util.AcaoBotoes(ToolStrip1, "Alterar")
        txtCodPromotor.Text = grdPromotora.CurrentRow.Cells(0).Value
        txtNome.Text = grdPromotora.CurrentRow.Cells(1).Value
        txtNome.Focus()
    End Sub

    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja excluir este registro?" & Chr(13) & grdPromotora.CurrentRow.Cells(1).Value, "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If Promotor.ExcluirPromotor(Convert.ToInt32(txtCodPromotor.Text)) = "OK" Then
                carregaGrid()
            Else
                MessageBox.Show("Promotor associado a outro registro" & vbCrLf & "Por tanto não pode ser excluído.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Util.DesativaControles(Me)
            Util.AcaoBotoes(ToolStrip1, "Excluir")
        End If
    End Sub

    Private Sub grdPromotora_SelectionChanged(sender As Object, e As EventArgs) Handles grdPromotora.SelectionChanged
        txtCodPromotor.Text = Convert.ToInt32(grdPromotora.CurrentRow.Cells(0).Value)
        txtNome.Text = grdPromotora.CurrentRow.Cells(1).Value
        cbAtivo.Checked = grdPromotora.CurrentRow.Cells(2).Value
    End Sub
End Class