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
    Public otica As Boolean = False
    Dim conf As New config
    ' Dim user As New objUsuario
    Dim objBase As New objMaster
    Dim intUsuario As Integer
    Dim strTexto As String = ""

    Private Sub frmTrocaBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intUsuario = objBase.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Try
            If otica = False Then
                cod_OS = InputBox("Informe o Nº da OS da Labonorte")
                Filial = InputBox("Informe a filial Labonorte:")
                os = New ObjOS(cod_OS, Filial)
            Else
                Filial = InputBox("Informe o número da loja Ana Maria:")
                cod_OS = InputBox("Informe a OS da loja Ana Maria:")
                os = New ObjOS(cod_OS, Filial, "")
            End If
            andamentos = New objAndamentos(cod_OS, Filial)
            pod = os.cod_produto_od
            poe = os.cod_produto_oe
            If os.max > 0 Then
                txtBaseAtualOD.Text = os.base_od
                txtBaseAtualOE.Text = os.base_oe
            Else
                MessageBox.Show("OS inexistente, informe uma OS válida.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Exit Sub
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtNovaBaseOD_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNovaBaseOD.Validating
        If txtNovaBaseOD.Text = "" Then
            Exit Sub
        End If

        If Existe_od() = 0 Then
            MessageBox.Show("Esta base informada não existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNovaBaseOD.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub txtNovaBaseOE_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNovaBaseOE.Validating
        If txtNovaBaseOE.Text = "" Then
            Exit Sub
        End If

        If existe_oe() = 0 Then
            MessageBox.Show("Esta base informada não existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            If os.cod_tab_od = "11003" Or os.cod_tab_od = "110032" Or os.cod_tab_od = "11139" Or os.cod_tab_od = "111392" _
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
            If os.cod_tab_oe = "11003" Or os.cod_tab_oe = "110032" Or os.cod_tab_oe = "11139" Or os.cod_tab_oe = "111392" _
            Or os.cod_tab_oe = "11051" Or os.cod_tab_oe = "11011" Or os.cod_tab_oe = "11055" Then
                o = "A"
            End If
        Else
            o = "A"
        End If
        cod_prod = prod.Retorna_cod_prod(os.cod_tab_oe, os.adicao_oe, txtNovaBaseOE.Text, o)
        If cod_prod <> 0 Then
            prod.filtra(cod_prod)
            Return cod_prod
        Else
            Return 0
        End If
    End Function
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim strSQL As String = ""
        strSQL = "Select 1 From Pedido_balcao where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & " and cod_status_pedido = 2"
        If objBase.verifica_existencia_registro(strSQL) = True Then
            MessageBox.Show("Não é possível realizar a troca de base quando o" & Chr(13) & "produto já foi baixado do estoque.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If objBase.verifica_permissao_usuario(intUsuario, 14) = True Then
            atualiza_Os()
            andamentos.insere_andamento(objAndamentos.tipo.Troca_base, Filial, cod_OS, intUsuario, "Base trocada no estoque! " & strTexto)
            Me.Close()
        Else
            MessageBox.Show("Usuário não tem acesso a troca de base no estoque.", "ERROR: 14", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End If
    End Sub

    Private Sub atualiza_Os()
        Dim strTextoOD As String = ""
        Dim strTextoOE As String = ""
        os.editar()
        If txtBaseAtualOD.Text <> txtNovaBaseOD.Text Then
            If txtNovaBaseOD.Text <> "" Then
                os.base_od = txtNovaBaseOD.Text
                os.cod_produto_od = Existe_od()
                atualiza_prod_od()
                strTextoOD = "Troca da base OD de " & txtBaseAtualOE.Text & " para " & txtNovaBaseOD.Text
            End If
        End If
        If txtBaseAtualOE.Text <> txtNovaBaseOE.Text Then
            If txtNovaBaseOE.Text <> "" Then
                os.base_oe = txtNovaBaseOE.Text
                os.cod_produto_oe = existe_oe()
                atualiza_prod_oe()
                strTextoOE = "Troca da base OE de " & txtBaseAtualOE.Text & " para " & txtNovaBaseOE.Text
            End If
        End If

        'Novo
        If txtNovaBaseOD.Text <> "" And txtNovaBaseOE.Text <> "" Then
            strTexto = strTextoOD & " e " & strTextoOE
        End If

        If txtNovaBaseOD.Text = "" And txtNovaBaseOE.Text <> "" Then
            strTexto = strTextoOE
        End If

        If txtNovaBaseOD.Text <> "" And txtNovaBaseOE.Text = "" Then
            strTexto = strTextoOD
        End If
        'Fim

        os.editar()
        MessageBox.Show(os.Salvar() & vbCrLf & "alterada base com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub atualiza_prod_od()
        Dim strSQL As String
        strSQL = "cod_produto = " & os.cod_produto_od & " where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & " and item = 1"
        objBase.atualiza_registros("pedido_balcao_itens", strSQL, True)
    End Sub

    Private Sub atualiza_prod_oe()
        Dim strSQL As String
        strSQL = "cod_produto = " & os.cod_produto_oe & " where num_pedido = " & os.num_pedido & " and id_filial = " & os.id_filial & " and item = 2"
        objBase.atualiza_registros("pedido_balcao_itens", strSQL, True)
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class