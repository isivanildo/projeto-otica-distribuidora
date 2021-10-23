Imports mrotica_util

Public Class frmFornecedor
    Dim pedido As New objPedidoCompra
    Dim fornecedor As New objMaster
    Dim status As Integer

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub txtCodigo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        Dim f As New frmConsulta
        Select Case e.KeyCode
            Case Keys.Enter
                fornecedor.limpaTextBox(Me)
                'f.ShowDialog(Me)
                btnAlterar_Click(sender, e)
                'txtCodigo.Text = f.codigo_form.ToString
                'txtCodigo.Focus()
        End Select
    End Sub

    Private Sub btnAlterar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar.Click
        status = 2
        Dim f As New frmConsulta
        f.ShowDialog(Me)

        txtCodigo.Text = f.codigo_form.ToString
        fornecedor.retorna_dados_fornecedor(CInt(f.codigo_form.ToString))

        If (txtCodigo.Text = 0) Then
            fornecedor.limpaTextBox(Me)
            btnSalvar.Enabled = False
            btnExcluir.Enabled = False
            btnNovo.Enabled = True
            btnAlterar.Enabled = True
            btnCancelar.Enabled = True
            gbTipoFor.Enabled = False
            rbFisica.Checked = False
            rbJuridica.Checked = False
            desabilita_caixa_texto()
            Exit Sub
        End If

        If fornecedor.ptipo_for = "F" Then
            rbFisica.Checked = True
            Label9.Text = "CPF"
            txtCnpj.Mask = "000.000.000-00"
        ElseIf fornecedor.ptipo_for = "J" Then
            rbJuridica.Checked = True
            Label9.Text = "CNPJ"
            txtCnpj.Mask = "00.000.000/0000-00"
        End If

        txtCep.Mask = "00000-000"
        txtTelefone.Mask = "(99)0000-0000"
        txtTelVendedor.Mask = "(99)0000-0000"
        txtTelRepresentante.Mask = "(99)0000-0000"

        txtFornecedor.Text = fornecedor.pfornecedor
        txtCnpj.Text = fornecedor.pcnpj
        txtInscEst.Text = fornecedor.pie
        txtEndereco.Text = fornecedor.pendereco
        txtBairro.Text = fornecedor.pbairro
        txtCidade.Text = fornecedor.pcidade
        txtEstado.Text = fornecedor.puf
        txtCep.Text = fornecedor.pcep
        txtTelefone.Text = fornecedor.ptelefone
        txtVendedor.Text = fornecedor.pvendedor
        txtTelVendedor.Text = fornecedor.ptel_vendedor
        txtRepresentante.Text = fornecedor.prepresentante
        txtTelRepresentante.Text = fornecedor.ptel_representante
        txtEmail.Text = fornecedor.pemail
        btnNovo.Enabled = False
        btnAlterar.Enabled = False
        btnSalvar.Enabled = True
        btnExcluir.Enabled = True
        btnCancelar.Enabled = True
        gbTipoFor.Enabled = True
        habilita_caixa_texto()
        txtCodigo.Focus()
        txtCodigo.ReadOnly = True
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        status = 1
        fornecedor.limpaTextBox(Me)
        btnNovo.Enabled = False
        btnAlterar.Enabled = False
        btnSalvar.Enabled = True
        btnExcluir.Enabled = True
        btnCancelar.Enabled = True
        gbTipoFor.Enabled = True
        rbJuridica.Checked = True
        habilita_caixa_texto()
        txtCodigo.ReadOnly = False
        txtCnpj.Mask = ""
        txtCnpj.Text = ""
        txtCep.Mask = "00000-000"
        txtCep.Text = "00000000"
        txtTelefone.Mask = "(99)0000-0000"
        txtTelefone.Text = "0000000000"
        txtTelVendedor.Mask = "(99)0000-0000"
        txtTelVendedor.Text = "0000000000"
        txtTelRepresentante.Mask = "(99)0000-0000"
        txtTelRepresentante.Text = "0000000000"
        txtCnpj.Mask = ""
        txtCodigo.Focus()
    End Sub

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
        Dim tipofor As String = ""
        Dim cnpjcpf As String = ""
        Dim cep As String = ""
        Dim strTelefone As String = ""
        Dim strTelVendedor As String = ""
        Dim strTelRepresentante As String = ""

        If rbFisica.Checked = True Then
            tipofor = "F"
        Else
            tipofor = "J"
        End If

        If (txtCodigo.Text <> "") And (txtFornecedor.Text <> "") And (txtCnpj.Text <> "") Then
            If status = 1 Then
                If MessageBox.Show("Deseja salvar o registro do fornecedor?" & Chr(13) & txtFornecedor.Text, "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        If rbFisica.Checked = True Then
                            cnpjcpf = txtCnpj.Text.Substring(0, 3) & txtCnpj.Text.Substring(4, 3) & txtCnpj.Text.Substring(8, 3) & txtCnpj.Text.Substring(12, 2)
                        End If

                        If rbJuridica.Checked = True Then
                            cnpjcpf = txtCnpj.Text.Substring(0, 2) & txtCnpj.Text.Substring(3, 3) & txtCnpj.Text.Substring(7, 3) & txtCnpj.Text.Substring(11, 4) & txtCnpj.Text.Substring(16, 2)
                        End If

                        cep = txtCep.Text.Substring(0, 5) & txtCep.Text.Substring(6, 3)
                        strTelefone = txtTelefone.Text.Substring(1, 2) & txtTelefone.Text.Substring(4, 4) & txtTelefone.Text.Substring(9, 4)
                        strTelVendedor = txtTelVendedor.Text.Substring(1, 2) & txtTelVendedor.Text.Substring(4, 4) & txtTelVendedor.Text.Substring(9, 4)
                        strTelRepresentante = txtTelRepresentante.Text.Substring(1, 2) & txtTelRepresentante.Text.Substring(4, 4) & txtTelRepresentante.Text.Substring(9, 4)

                        fornecedor.salva_fornecedor(CInt(txtCodigo.Text), txtFornecedor.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text, _
                        cep, strTelefone, cnpjcpf, txtInscEst.Text, txtEmail.Text, txtVendedor.Text, strTelVendedor, _
                        txtRepresentante.Text, strTelRepresentante, tipofor)

                        btnNovo.Enabled = True
                        btnAlterar.Enabled = True
                        btnSalvar.Enabled = False
                        btnExcluir.Enabled = False
                        btnCancelar.Enabled = False
                        gbTipoFor.Enabled = False
                        desabilita_caixa_texto()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                End If
            ElseIf status = 2 Then
                If MessageBox.Show("Deseja atualizar o registro do fornecedor?" & Chr(13) & txtFornecedor.Text, "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try

                        If rbFisica.Checked = True Then
                            cnpjcpf = txtCnpj.Text.Substring(0, 3) & txtCnpj.Text.Substring(4, 3) & txtCnpj.Text.Substring(8, 3) & txtCnpj.Text.Substring(12, 2)
                        End If

                        If rbJuridica.Checked = True Then
                            cnpjcpf = txtCnpj.Text.Substring(0, 2) & txtCnpj.Text.Substring(3, 3) & txtCnpj.Text.Substring(7, 3) & txtCnpj.Text.Substring(11, 4) & txtCnpj.Text.Substring(16, 2)
                        End If

                        cep = txtCep.Text.Substring(0, 5) & txtCep.Text.Substring(6, 3)
                        strTelefone = txtTelefone.Text.Substring(1, 2) & txtTelefone.Text.Substring(4, 4) & txtTelefone.Text.Substring(9, 4)
                        strTelVendedor = txtTelVendedor.Text.Substring(1, 2) & txtTelVendedor.Text.Substring(4, 4) & txtTelVendedor.Text.Substring(9, 4)
                        strTelRepresentante = txtTelRepresentante.Text.Substring(1, 2) & txtTelRepresentante.Text.Substring(4, 4) & txtTelRepresentante.Text.Substring(9, 4)

                        fornecedor.atualiza_fornecedor(CInt(txtCodigo.Text), txtFornecedor.Text, txtEndereco.Text, txtBairro.Text, txtCidade.Text, txtEstado.Text, _
                        cep, strTelefone, cnpjcpf, txtInscEst.Text, txtEmail.Text, txtVendedor.Text, strTelVendedor, _
                        txtRepresentante.Text, strTelRepresentante, tipofor)

                        btnNovo.Enabled = True
                        btnAlterar.Enabled = True
                        btnSalvar.Enabled = False
                        btnExcluir.Enabled = False
                        btnCancelar.Enabled = False
                        gbTipoFor.Enabled = False
                        desabilita_caixa_texto()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                End If
            End If
        Else
            MessageBox.Show("Por favor preencha o código, nome ou CNPJ do fornecedor.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub desabilita_caixa_texto()
        txtCodigo.Enabled = False
        txtFornecedor.Enabled = False
        txtCnpj.Enabled = False
        txtInscEst.Enabled = False
        txtEndereco.Enabled = False
        txtBairro.Enabled = False
        txtCidade.Enabled = False
        txtEstado.Enabled = False
        txtCep.Enabled = False
        txtTelefone.Enabled = False
        txtVendedor.Enabled = False
        txtTelVendedor.Enabled = False
        txtRepresentante.Enabled = False
        txtTelRepresentante.Enabled = False
        txtEmail.Enabled = False
    End Sub

    Private Sub habilita_caixa_texto()
        txtCodigo.Enabled = True
        txtFornecedor.Enabled = True
        txtCnpj.Enabled = True
        txtInscEst.Enabled = True
        txtEndereco.Enabled = True
        txtBairro.Enabled = True
        txtCidade.Enabled = True
        txtEstado.Enabled = True
        txtCep.Enabled = True
        txtTelefone.Enabled = True
        txtVendedor.Enabled = True
        txtTelVendedor.Enabled = True
        txtRepresentante.Enabled = True
        txtTelRepresentante.Enabled = True
        txtEmail.Enabled = True
    End Sub


    Private Sub frmFornecedor_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        desabilita_caixa_texto()
    End Sub

    Private Sub Label15_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtTelefone_Leave(sender As System.Object, e As System.EventArgs) Handles txtTelefone.Leave
        If txtTelefone.Text.Length = 10 Then
            txtTelefone.Mask = "(99)0000-0000"
        Else
            MessageBox.Show("Telefone tem que conter 10 digitos.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTelefone.Focus()
        End If
    End Sub

    Private Sub txtTelefone_Enter(sender As System.Object, e As System.EventArgs) Handles txtTelefone.Enter
        txtTelefone.Mask = ""
    End Sub

    Private Sub txtTelVendedor_Leave(sender As System.Object, e As System.EventArgs) Handles txtTelVendedor.Leave
        If txtTelVendedor.Text.Length = 10 Then
            txtTelVendedor.Mask = "(99)0000-0000"
        Else
            MessageBox.Show("Telefone tem que conter 10 digitos.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTelVendedor.Focus()
        End If
    End Sub

    Private Sub txtTelVendedor_Enter(sender As System.Object, e As System.EventArgs) Handles txtTelVendedor.Enter
        txtTelVendedor.Mask = ""
    End Sub

    Private Sub txtTelRepresentante_Leave(sender As System.Object, e As System.EventArgs) Handles txtTelRepresentante.Leave
        If txtTelRepresentante.Text.Length = 10 Then
            txtTelRepresentante.Mask = "(99)0000-0000"
        Else
            MessageBox.Show("Telefone tem que conter 10 digitos.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTelRepresentante.Focus()
        End If
    End Sub

    Private Sub txtTelRepresentante_Enter(sender As System.Object, e As System.EventArgs) Handles txtTelRepresentante.Enter
        txtTelRepresentante.Mask = ""
    End Sub

    Private Sub txtCep_Leave(sender As System.Object, e As System.EventArgs) Handles txtCep.Leave
        If (txtCep.Text.Length = 8) Then
            txtCep.Mask = "00000-000"
        Else
            MessageBox.Show("CEP tem que conter 8 digitos.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCep.Focus()
        End If

    End Sub

    Private Sub txtCep_Enter(sender As System.Object, e As System.EventArgs) Handles txtCep.Enter
        txtCep.Mask = ""
    End Sub

    Private Sub txtCnpj_Enter(sender As System.Object, e As System.EventArgs) Handles txtCnpj.Enter
        txtCnpj.Mask = ""
    End Sub

    Private Sub rbFisica_Click(sender As System.Object, e As System.EventArgs) Handles rbFisica.Click
        Label9.Text = "CPF"
    End Sub

    Private Sub rbJuridica_Click(sender As System.Object, e As System.EventArgs) Handles rbJuridica.Click
        Label9.Text = "CNPJ"
    End Sub

    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click
        If (txtCodigo.Text <> "") And (txtFornecedor.Text <> "") Then
            If MessageBox.Show("Deseja excluir o registro do fornecedor?" & Chr(13) & txtFornecedor.Text, "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    fornecedor.exclui_fornecedor(CInt(txtCodigo.Text))
                    fornecedor.limpaTextBox(Me)
                    desabilita_caixa_texto()
                    txtCnpj.Mask = ""
                    txtCnpj.Text = ""
                    txtCep.Mask = ""
                    txtCep.Text = ""
                    txtTelefone.Mask = ""
                    txtTelefone.Text = ""
                    txtTelVendedor.Mask = ""
                    txtTelVendedor.Text = ""
                    txtTelRepresentante.Mask = ""
                    txtTelRepresentante.Text = ""
                    btnNovo.Enabled = True
                    btnAlterar.Enabled = True
                    btnSalvar.Enabled = False
                    btnExcluir.Enabled = False
                    btnCancelar.Enabled = False
                    gbTipoFor.Enabled = False
                    rbFisica.Checked = False
                    rbJuridica.Checked = False
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Por favor preencha o código ou o nome do fornecedor.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        fornecedor.limpaTextBox(Me)
        desabilita_caixa_texto()
        txtCnpj.Mask = ""
        txtCnpj.Text = ""
        txtCep.Mask = ""
        txtCep.Text = ""
        txtTelefone.Mask = ""
        txtTelefone.Text = ""
        txtTelVendedor.Mask = ""
        txtTelVendedor.Text = ""
        txtTelRepresentante.Mask = ""
        txtTelRepresentante.Text = ""
        btnNovo.Enabled = True
        btnAlterar.Enabled = True
        btnSalvar.Enabled = False
        btnExcluir.Enabled = False
        btnCancelar.Enabled = False
        gbTipoFor.Enabled = False
    End Sub

    Private Sub txtCnpj_Leave(sender As System.Object, e As System.EventArgs) Handles txtCnpj.Leave
        If rbFisica.Checked = True Then
            txtCnpj.Mask = "000.000.000-00"
        End If

        If rbJuridica.Checked = True Then
            txtCnpj.Mask = "00.000.000/0000-00"
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripSeparator1_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator1.Click

    End Sub

    Private Sub ToolStripSeparator2_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator2.Click

    End Sub

    Private Sub ToolStripSeparator3_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator3.Click

    End Sub

    Private Sub ToolStripSeparator4_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator4.Click

    End Sub

    Private Sub ToolStripSeparator5_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator5.Click

    End Sub

    Private Sub ToolStripSeparator6_Click(sender As Object, e As EventArgs) Handles ToolStripSeparator6.Click

    End Sub

    Private Sub txtVendedor_TextChanged(sender As Object, e As EventArgs) Handles txtVendedor.TextChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub txtTelefone_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtTelefone.MaskInputRejected

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub txtCep_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtCep.MaskInputRejected

    End Sub

    Private Sub txtTelVendedor_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtTelVendedor.MaskInputRejected

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub txtEstado_TextChanged(sender As Object, e As EventArgs) Handles txtEstado.TextChanged

    End Sub

    Private Sub txtTelRepresentante_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtTelRepresentante.MaskInputRejected

    End Sub

    Private Sub txtRepresentante_TextChanged(sender As Object, e As EventArgs) Handles txtRepresentante.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label15_Click_1(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtCidade_TextChanged(sender As Object, e As EventArgs) Handles txtCidade.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtBairro_TextChanged(sender As Object, e As EventArgs) Handles txtBairro.TextChanged

    End Sub

    Private Sub txtEndereco_TextChanged(sender As Object, e As EventArgs) Handles txtEndereco.TextChanged

    End Sub

    Private Sub txtCnpj_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtCnpj.MaskInputRejected

    End Sub

    Private Sub txtInscEst_TextChanged(sender As Object, e As EventArgs) Handles txtInscEst.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtFornecedor_TextChanged(sender As Object, e As EventArgs) Handles txtFornecedor.TextChanged

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub gbTipoFor_Enter(sender As Object, e As EventArgs) Handles gbTipoFor.Enter

    End Sub

    Private Sub rbJuridica_CheckedChanged(sender As Object, e As EventArgs) Handles rbJuridica.CheckedChanged

    End Sub

    Private Sub rbFisica_CheckedChanged(sender As Object, e As EventArgs) Handles rbFisica.CheckedChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class