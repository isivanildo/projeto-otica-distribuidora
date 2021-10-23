Imports mrotica_util
Public Class frmOSPedido
    Dim os As New ObjOS
    Dim br As New brOS
    Dim d As New dados
    Dim andamentos As New objAndamentos
    Dim prod As New produtoClass
    Dim usuario As New objUsuario
    Dim ltab As New objTabela
    Dim pod, poe, npod, npoe As Integer
    Public retPOD, retPOE As Long
    Public cod_OS As Integer
    Public Filial As Integer
    Public otica As Boolean = False
    Dim conf As New config
    Dim valido As Boolean = True
    Dim user As New objUsuario
    Private Sub frmTrocaBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cod_OS = InputBox("Informe o código da OS local (Labonorte)")
        Filial = conf.Filial
        abre_os()
    End Sub
    Private Sub abre_os()
        os = New ObjOS(cod_OS, Filial)
        Dim es As String
        Dim esf, cil As Double
        If os.max > 0 Then
            pod = os.cod_produto_od
            retPOD = pod
            If os.cod_tab_od = 0 Or os.cod_tab_od = 1 Then
                chkOd.Enabled = False
            End If

            poe = os.cod_produto_oe
            retPOE = poe
            If os.cod_tab_oe = 0 Or os.cod_tab_oe = 1 Then
                chkOE.Enabled = False
            End If
            txtPod.Text = prod.Retorna_nome_prod(os.cod_produto_od)
            txtPOE.Text = prod.Retorna_nome_prod(os.cod_produto_oe)
            txtBaseAtualOD.Text = os.base_od
            txtBaseAtualOE.Text = os.base_oe
        Else
            AVISO("OS inexistente, informe uma OS válida!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            Me.Close()
            Exit Sub
        End If
    End Sub
    Private Sub Validar()
        txtNovaBaseOD_Validating(Me, Nothing)
        txtNovaBaseOE_Validating(Me, Nothing)
    End Sub
    Private Sub txtNovaBaseOD_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNovaBaseOD.Validating
        If txtNovaBaseOD.Text = "" Then Exit Sub
        If Existe_od() = 0 Then
            err.SetError(txtNovaBaseOD, "Esta base não existe!")
            valido = False
            txtNovaBaseOD.Focus()
            Exit Sub
        Else
            err.SetError(txtNovaBaseOD, Nothing)
        End If
    End Sub
    Private Sub txtNovaBaseOE_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNovaBaseOE.Validating
        If txtNovaBaseOE.Text = "" Then Exit Sub
        If existe_oe() = 0 Then
            err.SetError(txtNovaBaseOE, "Esta base não existe!")
            valido = False
            txtNovaBaseOE.Focus()
            Exit Sub
        Else
            err.SetError(txtNovaBaseOE, Nothing)
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
            Or os.cod_tab_od = "11051" Then
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
            Or os.cod_tab_oe = "11051" Then
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
        valido = True
        Validar()
        If valido = True Then
            atualiza_Os()
            abre_os()
        Else
            AVISO("Há problemas com a troca de base, corrija os erros para continuar!", Me, frmAviso.tipo_aviso.tipo_ok, True)
        End If
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
        Debug.Print(os.Salvar() & vbCrLf & "alterado troca base")
    End Sub

End Class