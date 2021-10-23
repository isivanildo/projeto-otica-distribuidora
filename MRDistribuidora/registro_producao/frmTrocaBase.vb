Imports mrotica_util
Public Class frmTrocaBase
    Dim os As New ObjOS
    Dim br As New brOS
    Dim d As New dados
    Dim andamentos As New objAndamentos
    Dim prod As New produtoClass
    Dim usuario As New objUsuario
    Dim troca As New objTrocaproduto
    Dim pod, poe, npod, npoe As Integer
    Public cod_OS As Integer
    Public Filial As Integer
    Dim conf As New config
    Dim valido As Boolean = True
    Private Sub frmTrocaBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        os = New ObjOS(cod_OS, Filial)
        andamentos = New objAndamentos(cod_OS, Filial)
        pod = os.cod_produto_od
        poe = os.cod_produto_oe
        If os.troca_produto > 0 Then
            MessageBox.Show("Esta OS tem uma troca de produto/base que ainda não foi concluída." & Chr(13) & _
            "Você deve concluir a troca anterior antes de efetuar uma nova!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Exit Sub
        End If
        If os.max > 0 Then
            txtBaseAtualOD.Text = os.base_od
            txtBaseAtualOE.Text = os.base_oe
        Else
            MessageBox.Show("OS inexistente, informe uma OS válida!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Exit Sub
        End If
        If usuario.login(Me).StartsWith("OK") Then
            txtCodUsuario.Text = usuario.cod_usuario
            lblusuario.Text = usuario.nome
        End If
    End Sub

    Private Sub txtNovaBaseOD_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNovaBaseOD.Validating
        If txtNovaBaseOD.Text = "" Then
            Exit Sub
        End If

        If Existe_od() = 0 Then
            MessageBox.Show("Esta base não existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNovaBaseOD.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtNovaBaseOE_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNovaBaseOE.Validating
        If txtNovaBaseOE.Text = "" Then
            Exit Sub
        End If

        If existe_oe() = 0 Then
            MessageBox.Show("Esta base não existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNovaBaseOE.Focus()
            Exit Sub
        End If
    End Sub

    Private Function Existe_od() As Integer
        Dim cod_prod As Integer
        Dim o As String
        If txtNovaBaseOD.Text = "" Then
            Return 0
        End If
        If os.tipo_receita_OD = tipo_Receita.PROGRESSIVA Or os.tipo_receita_OD = tipo_Receita.BIFOCAL Then
            o = "D"
            If os.cod_tab_od = "11003" Or os.cod_tab_od = "11139" Or os.cod_tab_od = "111392" _
            Or os.cod_tab_od = "11051" Or os.cod_tab_od = "11011" Or os.cod_tab_od = "11055" Then
                o = "A"
            End If
        Else
            o = "A"
        End If
        cod_prod = prod.Retorna_cod_prod(os.cod_tab_od, os.adicao_od, txtNovaBaseOD.Text, o)
        If cod_prod <> 0 Then
            prod.filtra(cod_prod)
            Return cod_prod
        Else
            Return 0
        End If
    End Function

    Private Function existe_oe() As Integer
        Dim cod_prod As Integer
        Dim o As String
        If txtNovaBaseOE.Text = "" Then
            Return 0
        End If
        If os.tipo_receita_OE = tipo_Receita.PROGRESSIVA Or os.tipo_receita_OE = tipo_Receita.BIFOCAL Then
            o = "E"
            If os.cod_tab_oe = "11003" Or os.cod_tab_oe = "11139" Or os.cod_tab_oe = "111392" _
            Or os.cod_tab_oe = "11051" Or os.cod_tab_oe = "11011" Or os.cod_tab_oe = "11055" Then
                o = "A"
            End If
        Else
            o = "A"
        End If
        cod_prod = prod.Retorna_cod_prod(os.cod_tab_oe, os.adicao_oe, txtNovaBaseOE.Text, o)
        If cod_prod <> 0 Then
            prod.filtra(cod_prod)
            'AVISO("Quantidade de " & prod.fldProduto & " :" & prod.saldo_estoque_local(cod_prod, confFilial) & _
            'prod.fldUnd & ".", Me, frmAviso.tipo_aviso.tipo_ok)
            Return cod_prod
        Else
            Return 0
        End If
    End Function
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim obs As String
        Dim troca As Integer
        'Procedimento 7 Solicitação de troca de base
        If usuario.acesso(txtCodUsuario.Text, 7) = False Then
            MessageBox.Show("Usuário não tem autorização para solicitar troca de base.", "ERROR: 7", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        atualiza_Os()
        troca = novatroca()
        'Cancela os andamentos de Produção
        obs = "Cancelado para solicitação de troca de base!"
        MessageBox.Show(andamentos.cancela_andamentos_producao(obs), "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        andamentos.insere_andamento(objAndamentos.tipo.solicitacao_troca_base, os.id_filial, _
         os.cod_os, txtCodUsuario.Text, "Troca de base nº " & troca)
    End Sub
    Private Sub atualiza_Os()
        os.editar()
        If txtBaseAtualOD.Text <> txtNovaBaseOD.Text Then
            If txtNovaBaseOD.Text <> "" Then
                os.base_od = txtNovaBaseOD.Text
                os.cod_produto_od = Existe_od()
            End If
        End If
        If txtBaseAtualOE.Text <> txtNovaBaseOE.Text Then
            If txtNovaBaseOE.Text <> "" Then
                os.base_oe = txtNovaBaseOE.Text
                os.cod_produto_oe = existe_oe()
            End If
        End If
        os.editar()
        os.cod_fase = Fases_os.estoque_aguardando_troca_base
        Debug.Print(os.Salvar() & vbCrLf & "alterado troca base")
    End Sub
    Private Function novatroca()
        With troca
            .novo()
            .cod_os = os.cod_os
            .id_filial = conf.Filial
            .id_filial_os = os.id_filial
            .cod_prod_od = pod
            .cod_prod_od_novo = Existe_od()
            .prod_od_OK = "N"
            .cod_prod_oe = poe
            .cod_prod_oe_novo = existe_oe()
            .prod_oe_OK = "N"
            .id_usuario = txtCodUsuario.Text
            .concluido = "N"
            .cod_tipo_troca = objTrocaproduto.tipo_troca.troca_base
            .obs = txtObservação.Text
            MessageBox.Show(.Salvar() & vbCrLf & "Anote o nº da troca na OS: " & troca.cod_troca_prod, "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return troca.cod_troca_prod
        End With
    End Function
End Class