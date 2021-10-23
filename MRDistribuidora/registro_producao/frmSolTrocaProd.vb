Imports mrotica_util
Public Class frmSolTrocaProd
    Dim troca As New objTrocaproduto
    Dim os As New ObjOS
    Dim x_os, x_filial As Integer
    Dim usuario As New objUsuario
    Dim andamentos As New objAndamentos
    Dim produto As New objMaster
    Private Sub frmSolTrocaProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        x_filial = confFilial
        x_os = InputBox("Número da OS:")

        Dim strSQL As String = "SELECT cod_troca_prod, id_filial, cod_os from troca_produto where cod_os = " & x_os & " and id_filial = " & x_filial & _
            " and concluido = 'N'"
        Dim ttTroca As New DataTable
        ttTroca = produto.retornaRegistro(strSQL).Tables(0)
        If produto.verifica_existencia_registro(strSQL) = False Then
            os = New ObjOS(x_os, x_filial)
            'Abre a Os e verifica se existe
            If os.max = 0 Then
                MessageBox.Show("Esta OS não foi encontrada.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Exit Sub
            End If
            usuario.login(Me)
            If usuario.acesso(10) = False Then
                MessageBox.Show("Usuário não tem autorização para solicitar troca de produto.", "ERROR: 10", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Exit Sub
            End If
            With troca
                .novo()
                .cod_tipo_troca = objTrocaproduto.tipo_troca.troca_produto
                andamentos = New objAndamentos(os.cod_os, os.id_filial)
            End With
        Else
            MessageBox.Show("Existe uma solicitação de troca em aberto para a OS nº " & x_os & "." & Chr(13) & "Número da troca encontrada: " & ttTroca.Rows(0)("cod_troca_prod"), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim obs As String
        obs = "Cancelado para solicitação de troca de Produto"
        andamentos.cancela_andamentos_producao(obs)

        troca.cod_os = os.cod_os
        troca.id_filial = os.id_filial
        troca.id_filial_os = os.id_filial
        If chkOD.Checked Then
            troca.cod_prod_od = os.cod_produto_od
            troca.prod_od_OK = "N"
        Else
            troca.cod_prod_od = 0
            troca.prod_od_OK = "S"
        End If
        If chkOE.Checked Then
            troca.cod_prod_oe = os.cod_produto_oe
            troca.prod_oe_OK = "N"
        Else
            troca.cod_prod_oe = 0
            troca.prod_oe_OK = "S"
        End If
        troca.id_usuario = usuario.cod_usuario
        troca.obs = txtObs.Text
        MessageBox.Show(troca.Salvar & vbCrLf & "Anote na sua OS o número da troca de produto: " & troca.cod_troca_prod, "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show(andamentos.insere_andamento(objAndamentos.tipo.solicitacao_troca_produto, os.id_filial, _
        os.cod_os, usuario.cod_usuario, txtObs.Text & " Troca nº " & troca.cod_troca_prod), "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class