Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Imports MRUtil
Public Class frmUsuario
    'Dim d As New dados
    Dim User As New UsuarioPermissao
    Dim geral As New Geral
    Dim perfil As New ObjPerfil
    Dim strTipoOp As Int32
    Dim acesso As New objMaster
    Dim objSecuranca As New objSecurity
    Dim tbTipoUsuario As New DataTable

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        pbUsuario.Value = 0
        Dim f As New frmConsulta_Usuarios
        f.ShowDialog()
        User.CodigoUsuario = f.xIntCodigo
        User.NomeUsuario = f.xStrUsuario
        User.SenhaUsuario = f.xStrSenha
        User.Perfil = f.xPerfil
        User.Ativo = f.xAtivo
        txtCodUsuario.Text = Format(User.CodigoUsuario, "000")
        txtNome.Text = User.NomeUsuario
        txtSenha.Text = User.SenhaUsuario
        cbAtivo.Checked = User.Ativo
        If txtCodUsuario.Text = "0" Then
            Exit Sub
        End If

        combo()

        If cbTipo.SelectedIndex = -1 Then
            Exit Sub
        End If

        'Instrução responsável por retornar o tipo de usuário para dentro do combobox
        cbTipo.SelectedValue = User.Perfil
        ExibePermissaoVinculadoUsuario()
        If txtCodUsuario.Text <> String.Empty Then
            btnExcluir.Enabled = True
            btnEditar.Enabled = True
            btnResetarSenha.Enabled = True
        End If
        tvAcesso.Enabled = False
    End Sub


    Private Sub Combo()
        Try
            cbTipo.DisplayMember = "perfil_desc"
            cbTipo.ValueMember = "cod_perfil"
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList
            cbTipo.DataSource = User.PerfilUsuario
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        pbUsuario.Value = 0
        strTipoOp = Belemtech.TiposReg.Novo
        User.Novo()
        Combo()
        geral.AtivaControles(Me)
        desativacontroles()

        cbAtivo.Checked = True

        tvAcesso.Nodes.Clear()
    End Sub

    Private Sub ExibePermissaoVinculadoUsuario()
        If String.IsNullOrEmpty(User.CodigoUsuario) Then
            btnResetarSenha.Enabled = False
            Exit Sub
        End If

        tvAcesso.Nodes.Clear()

        Dim tbProcedimento As New DataTable
        Dim tbacesso As New DataTable

        tbacesso = User.PermissaoAcessoUsuarios(Convert.ToInt32(txtCodUsuario.Text))
        Try
            tbProcedimento = User.ProcedimentoAcesso
            Dim i, j As Integer
            tvAcesso.Nodes.Add("Permissões de Acesso")
            tvAcesso.CheckBoxes = True
            For i = 0 To tbProcedimento.Rows.Count - 1
                tvAcesso.Nodes(0).Nodes.Add(Format(tbProcedimento.Rows(i)("cod_procedimento"), "000") & " - " & tbProcedimento.Rows(i)("Procedimento"))
                tvAcesso.Nodes(0).ExpandAll()
                For j = 0 To tbacesso.Rows.Count - 1
                    If tbacesso.Rows(j)("cod_procedimento") = tbProcedimento.Rows(i)("cod_procedimento") Then
                        tvAcesso.Nodes(0).Nodes(i).Checked = True
                    End If
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ExibeProcedimentoTipoPerfil()
        tvAcesso.Nodes.Clear()
        Dim tbAcessoPadrao As New DataTable
        Dim tbProcedimento As New DataTable
        Try
            tbAcessoPadrao = User.RetornaAcessoPadraoPerfil(cbTipo.SelectedValue)
            tbProcedimento = User.ProcedimentoAcesso()

            Dim i, j As Integer
            tvAcesso.Nodes.Add("Permissões Acesso")
            tvAcesso.CheckBoxes = True
            For i = 0 To tbProcedimento.Rows.Count - 1
                tvAcesso.Nodes(0).Nodes.Add(Format(tbProcedimento.Rows(i)("cod_procedimento"), "000") & " - " & tbProcedimento.Rows(i)("Procedimento"))
                tvAcesso.Nodes(0).ExpandAll()
                For j = 0 To tbAcessoPadrao.Rows.Count - 1
                    If tbAcessoPadrao.Rows(j)("cod_procedimento") = tbProcedimento.Rows(i)("cod_procedimento") Then
                        tvAcesso.Nodes(0).Nodes(i).Checked = True
                    End If
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ativacontroles()
        btnNovo.Enabled = True
        If strTipoOp = Belemtech.TiposReg.Novo Then
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
        Else
            btnEditar.Enabled = True
            btnExcluir.Enabled = True
        End If
        btnSalvar.Enabled = False
        btnCancelar.Enabled = False
        txtCodUsuario.Enabled = False
        txtNome.Enabled = False
        txtSenha.Enabled = False
        cbTipo.Enabled = False
        tvAcesso.Enabled = False
        cbAtivo.Enabled = False
    End Sub

    Private Sub desativacontroles()
        btnNovo.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        btnSalvar.Enabled = True
        btnCancelar.Enabled = True

        txtCodUsuario.Enabled = False
        txtNome.Enabled = True
        txtNome.Focus()
        txtSenha.Enabled = True
        cbTipo.Enabled = True
        tvAcesso.Enabled = True
        cbAtivo.Enabled = True

        txtSenha.CharacterCasing = CharacterCasing.Normal
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        If strTipoOp = Belemtech.TiposReg.Novo Then
            geral.AtivaControles(Me)
            cbTipo.DataSource = Nothing
            tvAcesso.Nodes.Clear()
        End If
        ativacontroles()
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        pbUsuario.Value = 0
        strTipoOp = Belemtech.TiposReg.Alterar
        desativacontroles()
        txtNome.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click

        User.NomeUsuario = txtNome.Text
        User.SenhaUsuario = txtSenha.Text
        User.Ativo = cbAtivo.Checked

        If User.CamposObrigatorios() = True Then
            Geral.TelaAviso(User.MensagemRetorno, "ERROR", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Informacao)
        End If

        Dim i As Integer

        If strTipoOp = Belemtech.TiposReg.Novo Then
            If Geral.TelaAviso("Deseja salvar as permissões de acesso para este usuário?", "INFORMAÇÃO", Me, Belemtech.TipoAviso.SIMNAO, Belemtech.ImagemAviso.Informacao) = Belemtech.Respo.SIM Then
                User.Perfil = cbTipo.SelectedValue
                If User.SalvarUsuario() = True Then
                    txtCodUsuario.Text = Format(User.CodigoUsuario, "000")
                    pbUsuario.Minimum = 0
                    pbUsuario.Maximum = tvAcesso.Nodes(0).Nodes.Count - 1

                    For i = 0 To tvAcesso.Nodes(0).Nodes.Count - 1
                        If tvAcesso.Nodes(0).Nodes(i).Checked = True Then
                            User.CodigoProcedimento = CInt(tvAcesso.Nodes(0).Nodes(i).Text.Substring(0, 3))
                            User.SalvarPermissao()
                        End If
                        pbUsuario.Increment(i + 1)
                        pbUsuario.Value = i
                    Next
                    ativacontroles()
                    Geral.TelaAviso("Usuário inserido com sucesso.", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Informacao)
                    'strTipoOp = ""
                End If
            End If
        Else
            If Geral.TelaAviso("Deseja salvar as alterações permissões de acesso para este usuário?", "INFORMAÇÃO", Me, Belemtech.TipoAviso.SIMNAO, Belemtech.ImagemAviso.Informacao) = Belemtech.Respo.SIM Then
                If cbTipo.SelectedValue <> User.Perfil Then
                    User.Perfil = cbTipo.SelectedValue
                End If

                User.AtualizaUsuario(User.CodigoUsuario) 'Atualiza o perfil do usuário

                User.ExcluirPermissao(User.CodigoUsuario) 'Exclui os acessos anteriores

                pbUsuario.Minimum = 0
                pbUsuario.Maximum = tvAcesso.Nodes(0).Nodes.Count - 1
                For i = 0 To tvAcesso.Nodes(0).Nodes.Count - 1
                    If tvAcesso.Nodes(0).Nodes(i).Checked = True Then
                        User.CodigoProcedimento = CInt(tvAcesso.Nodes(0).Nodes(i).Text.Substring(0, 3))
                        User.SalvarPermissao()
                    End If
                    pbUsuario.Increment(i + 1)
                    pbUsuario.Value = i
                Next

                ativacontroles()

                Geral.TelaAviso("Alteração realizada com sucesso.", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Informacao)
            End If
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click

        If Geral.TelaAviso("Deseja excluir este usuário?", "INFORMAÇÃO", Me, Belemtech.TipoAviso.SIMNAO, Belemtech.ImagemAviso.Informacao) = Belemtech.Respo.SIM Then
            If User.ExcluirUsuario() Then
                MessageBox.Show(User.MensagemRetorno, "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                geral.AtivaControles(Me)
                tvAcesso.Nodes.Clear()
                btnEditar.Enabled = False
                btnExcluir.Enabled = False
                pbUsuario.Value = 0
            End If
            Geral.TelaAviso(User.MensagemRetorno, "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Informacao)
        Else
            Geral.TelaAviso("Operação cancelada com sucesso.", "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Informacao)
        End If
    End Sub

    Private Sub btnResetarSenha_Click(sender As System.Object, e As System.EventArgs) Handles btnResetarSenha.Click
        If Geral.TelaAviso("Deseja resetar a senha para este usuário?", "INFORMAÇÃO", Me, Belemtech.TipoAviso.SIMNAO) = Belemtech.Respo.SIM Then
            If (User.ResetaSenha(User.CodigoUsuario) = True) Then
                Geral.TelaAviso(User.MensagemRetorno, "INFORMAÇÃO", Me, Belemtech.TipoAviso.OK, Belemtech.ImagemAviso.Informacao)
            End If
        Else

        End If
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbTipo.SelectedIndexChanged
        ExibeProcedimentoTipoPerfil()
    End Sub

    Private Sub frmUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class