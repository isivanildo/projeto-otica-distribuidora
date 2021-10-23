Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Imports MRUtil
Public Class frmFabricante
    Dim Conexao As New ConexaoDB()
    Dim Util As New Geral()
    Dim Fabricante As New Fabricante()

    Private Sub frmFabricante_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carregaGrid()
    End Sub

    Public Sub carregaGrid()
        grdFabricante.Columns.Clear()
        grdFabricante.DataSource = Nothing
        grdFabricante.AutoGenerateColumns = False
        grdFabricante.AllowUserToAddRows = False

        Dim codigo As New DataGridViewTextBoxColumn
        codigo.HeaderText = "Código"
        codigo.DataPropertyName = "id_fabricante"
        codigo.Width = 70
        codigo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        codigo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        codigo.SortMode = DataGridViewColumnSortMode.NotSortable
        grdFabricante.Columns.Add(codigo)

        Dim fabricante As New DataGridViewTextBoxColumn
        fabricante.HeaderText = "Fabricante"
        fabricante.DataPropertyName = "fabricante"
        fabricante.Width = 320
        grdFabricante.Columns.Add(fabricante)

        Dim tipo As New DataGridViewTextBoxColumn
        tipo.HeaderText = "Tipo"
        tipo.DataPropertyName = "tipo"
        tipo.Visible = False
        grdFabricante.Columns.Add(tipo)

        Dim strSQL As String = "select * from fabricante"
        Dim tb As New DataTable
        tb = Conexao.CarregaTabela(strSQL, tb)
        grdFabricante.DataSource = tb
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        Geral.TipoReg = "N"
        Fabricante.Novo()
        Dim chave As String = Conexao.RetornaChave("id_fabricante", "Fabricante", "")
        Util.AtivaControles(Me)
        Util.AcaoBotoes(ToolStrip1, "Novo")
        txtCodFabricante.Text = chave
        txtFabricante.Focus()
    End Sub

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
        Fabricante.CodigoFabricante = Convert.ToInt32(txtCodFabricante.Text)
        Fabricante.NomeFabricante = txtFabricante.Text
        Fabricante.TipoFabricante = cbTipo.SelectedIndex

        If Fabricante.VerificaCampoObrigatorio() = True Then
            Exit Sub
        End If

        If MessageBox.Show("Deseja salvar ou alterar este registro?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If cbTipo.SelectedIndex = 0 Then
                Fabricante.TipoFabricante = Belemtech.TipoFabricante.Lente
            ElseIf cbTipo.SelectedIndex = 1 Then
                Fabricante.TipoFabricante = Belemtech.TipoFabricante.Armacao
            Else
                Fabricante.TipoFabricante = Belemtech.TipoFabricante.LenteArmacao
            End If

            If Geral.TipoReg = "N" Then
                Fabricante.SalvaFabricante()
            Else
                Fabricante.AtualizaFabricante(Fabricante.CodigoFabricante)
            End If
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        carregaGrid()
        Util.AcaoBotoes(ToolStrip1, "Salvar")
        Util.DesativaControles(Me)
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        txtFabricante.Text = ""
        txtCodFabricante.Text = ""
        Util.DesativaControles(Me)
        Util.AcaoBotoes(ToolStrip1, "Cancelar")
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar.Click
        Geral.TipoReg = "A"
        Util.AtivaControles(Me)
        Util.AcaoBotoes(ToolStrip1, "Alterar")
        txtCodFabricante.Text = grdFabricante.CurrentRow.Cells(0).Value
        txtFabricante.Text = grdFabricante.CurrentRow.Cells(1).Value
        txtFabricante.Focus()
    End Sub

    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja excluir este registro?" & Chr(13) & grdFabricante.CurrentRow.Cells(1).Value, "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If Fabricante.ExcluiFabricante(Convert.ToInt32(txtCodFabricante.Text)) = "OK" Then
                carregaGrid()
            Else
                MessageBox.Show("Fabricante associado a outro registro" & vbCrLf & "Por tanto não pode ser excluído.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Util.DesativaControles(Me)
            Util.AcaoBotoes(ToolStrip1, "Excluir")
        End If
    End Sub

    Private Sub grdFabricante_SelectionChanged(sender As Object, e As EventArgs) Handles grdFabricante.SelectionChanged
        txtCodFabricante.Text = Convert.ToInt32(grdFabricante.CurrentRow.Cells(0).Value)
        txtFabricante.Text = grdFabricante.CurrentRow.Cells(1).Value

        If grdFabricante.CurrentRow.Cells(2).Value.ToString() <> String.Empty Then
            If grdFabricante.CurrentRow.Cells(2).Value = 0 Then
                cbTipo.SelectedIndex = Belemtech.TipoFabricante.Lente
            ElseIf grdFabricante.CurrentRow.Cells(2).Value = 1 Then
                cbTipo.SelectedIndex = Belemtech.TipoFabricante.Armacao
            ElseIf grdFabricante.CurrentRow.Cells(2).Value = 2 Then
                cbTipo.SelectedIndex = Belemtech.TipoFabricante.LenteArmacao
            End If
        Else
            cbTipo.SelectedIndex = -1
        End If

    End Sub
End Class