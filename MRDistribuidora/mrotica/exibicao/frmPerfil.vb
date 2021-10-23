Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmPerfil
    Dim d As New dados
    Dim Perfil As New ObjPerfil
    Dim Master As New objMaster
    Private Sub frmPerfil_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Perfil.ExibeAcessoPerfil(tvAcesso, 0)
        Perfil.MontaDatGrid(DataGridView1)
    End Sub
    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Perfil.Novo()
        Master.AcaoBotaoNovo(ToolStrip1)
        Master.LimpaControle(Me)
        Master.LimpaControleTreeView(tvAcesso)
        txtCodigo.Text = Master.RetornaChave("cod_tipo_usuario", "tipo_usuario", "")
        Master.AtivaControle(Me)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Perfil.Editar()
        Master.AcaoBotaoEditar(ToolStrip1)
        Master.AtivaControle(Me)
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja excluir este grupo?", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Question) = DialogResult.Yes Then
            Perfil.ExcluiPerfil(CInt(txtCodigo.Text))
            Master.AcaoBotaoExcluir(ToolStrip1)
            Master.LimpaControle(Me)
            Master.LimpaControleTreeView(tvAcesso)
            Master.DesativaControle(Me)
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtDescricao.Text = String.Empty Then
            MessageBox.Show("Por favor preencher a descrição do grupo!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("Deseja salvar este grupo de usuário?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Perfil.CodigoTipoUsuario = txtCodigo.Text
            Perfil.TipoUsuarioDescricao = txtDescricao.Text
            Perfil.SalvarPefil()
            Perfil.SalvaPerfilPadrao(Perfil.CodigoTipoUsuario, tvAcesso)
            Master.AcaoBotaoSalvar(ToolStrip1)
            Master.DesativaControle(Me)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Master.AcaoBotaoCancelar(ToolStrip1)
        Master.DesativaControle(Me)
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim index As Integer = DataGridView1.CurrentRow.Cells(0).Value

        Perfil.Registro(index)
        txtCodigo.Text = Perfil.CodigoTipoUsuario
        txtDescricao.Text = Perfil.TipoUsuarioDescricao
        Perfil.ExibeAcessoPerfil(tvAcesso, Perfil.CodigoTipoUsuario)
    End Sub
End Class