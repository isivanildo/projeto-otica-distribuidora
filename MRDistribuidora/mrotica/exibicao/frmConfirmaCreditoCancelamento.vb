Imports mrotica_util
Public Class frmConfirmaCreditoCancelamento
    Dim Cred As New objCreditoCliente
    Dim conf As New config
    Dim tCred As New DataTable
    Dim r As DataRow
    Dim d As New dados
    Dim cliente As New objCliente
    Dim usuario As New objUsuario
    Private Sub frmConfirmaCreditoCancelamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            tCred = Cred.retorna_credito_cancelamento(conf.Filial, InputBox("Informe o número do crédito a confirmar:"))
        Catch ex As Exception
            AVISO(ex.ToString, Me, frmAviso.tipo_aviso.tipo_ok, False)
            Me.Close()
        End Try
        If tCred.Rows.Count = 1 Then
            r = tCred.Rows(0)
            If r("concluido") = "S" Then
                MsgBox("Credito já foi concluido!")
                Me.Close()
            End If
            txtDesc.Text = r("descricao")
            txtValor.Text = r("valor")
        End If

    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim resp As frmAviso.respo
        Dim res As String
        cliente.filtra_cod(r("cod_cliente"))
        resp = AVISO("Confirma o crédito de " & cdinShow(txtValor.Text) & _
        " para o cliente " & cliente.nome_cliente & "", Me, frmAviso.tipo_aviso.tipo_sim_nao, False)
        'Procedimento 26 Confirma/cancelar crédito de cancelamento
        If usuario.login(Me).StartsWith("OK") Then
            If resp = frmAviso.respo.SIM Then
                If usuario.acesso(26) = True Then
                    Cred.novo()
                    Cred.cod_filial_cliente = cliente.cod_filial_cliente
                    Cred.cod_cliente = cliente.cod_cliente
                    Cred.data = Now
                    Cred.id_filial = conf.Filial
                    Cred.id_usuario = usuario.cod_usuario
                    Cred.credito = txtValor.Text
                    Cred.historico = txtDesc.Text
                    res = Cred.Salvar
                    If res.StartsWith("OK") Then
                        res = Cred.confirma_credito_cancelamento(r("id_filial"), r("cod_credito_cancelamento"), _
                                                           True, usuario.cod_usuario)
                        MsgBox(res)
                        Dim rpt As New rptTexto
                        Dim fr As New frmRpt
                        rpt.strTitulo = "Comprovante de crédito. Cliente: " & cliente.nome_cliente
                        txtDesc.Text = txtDesc.Text & vbCrLf & vbCrLf & _
                        "Valor do Crédito: " & cdinShow(txtValor.Text)
                        rpt.texto = txtDesc.Text & vbCrLf & _
                         vbCrLf & _
                        vbCrLf & _
                        vbCrLf & vbCrLf & _
                        "Data ...../...../.......  Visto Caixa: x...." & _
                        "....................................................." & _
                        "....................................................." & _
                        vbCrLf & vbCrLf & _
                        "................................................" & _
                        "via caixa......................................." & _
                        vbCrLf & vbCrLf & txtDesc.Text & _
                        vbCrLf & vbCrLf & _
                        "Data ...../...../.......  Visto Cliente: x...." & _
                        "....................................................." & _
                        "....................................................."


                        fr.Relat(rpt)
                        fr.ShowDialog(Me)
                        Me.Close()
                    End If
                Else
                    AVISO("Usuário não tem acesso!", Me, frmAviso.tipo_aviso.tipo_ok)
                    Me.Close()
                End If
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancela.Click
        Dim resp As frmAviso.respo
        Dim res As String
        cliente.filtra_cod(r("cod_cliente"))
        resp = AVISO("Cancela o crédito de " & cdinShow(txtValor.Text) & _
        " para o cliente " & cliente.nome_cliente & "", Me, frmAviso.tipo_aviso.tipo_sim_nao, False)
        'Procedimento 26 Confirma/cancelar crédito de cancelamento
        If resp = frmAviso.respo.SIM Then
            If usuario.login(Me).StartsWith("OK") Then
                If resp = frmAviso.respo.SIM Then
                    If usuario.acesso(26) = True Then
                        res = Cred.confirma_credito_cancelamento(r("id_filial"), r("cod_credito_cancelamento"), _
                                                               False, usuario.cod_usuario)
                        MsgBox(res & vbCrLf & "Crédito Cancelado!", MsgBoxStyle.Exclamation)
                        Me.Close()
                    End If
                Else
                    AVISO("Usuário não tem acesso!", Me, frmAviso.tipo_aviso.tipo_ok)
                    Me.Close()
                End If
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
End Class