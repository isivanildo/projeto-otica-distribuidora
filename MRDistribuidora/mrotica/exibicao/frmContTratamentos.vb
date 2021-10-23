Imports mrotica_util
Public Class frmContTratamentos
    Dim d As New dados
    Dim trat As New objContTratamentos
    Public novo As Boolean
    Public x_os, x_id_filial As Integer
    Dim andamentos As New objAndamentos
    Dim usuario As New objUsuario
    Private Sub frmContTratamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        abrir()
    End Sub
    Private Sub abrir()
        AVISO(usuario.login(Me), Me, frmAviso.tipo_aviso.tipo_ok)
        'Procedimento 9 Inserir controle de tratamento
        If usuario.acesso(usuario.cod_usuario, 9) = False Then
            AVISO("Usuário não tem permissão para controle de tratamento!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            Me.Close()
            Exit Sub
        End If
        If novo = True Then
            btnConcluir.Enabled = False
            dtEnvio.Value = Now
            trat.novo()
        Else
            trat.filtra(x_os, x_id_filial)
            If trat.max = 0 Then
                AVISO("Esta OS não tem registro de controle de tratamento!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                Exit Sub
                Me.Close()
            End If
            dtEnvio.Value = rdData(trat.data_envio)
            txtDoc3.Text = trat.os_fornecedor
            txtDescricao.Text = trat.obs
            dtEnvio.Enabled = False
            If trat.data_retorno = Nothing Then
                trat.editar()
            Else
                btnSalvar.Enabled = False
                btnConcluir.Enabled = False
            End If

        End If
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim r As String
        If novo = True Then
            r = andamentos.insere_andamento(objAndamentos.tipo.Enviado_tratamento, x_id_filial, x_os, usuario.cod_usuario, "")
            If r.StartsWith("ER") Then
                AVISO(r, Me, frmAviso.tipo_aviso.tipo_ok, True)
                Me.Close()
                Exit Sub
            End If
            trat.cod_os = x_os
            trat.id_filial_os = x_id_filial
            trat.data_envio = dtEnvio.Value
            trat.os_fornecedor = txtDoc3.Text
            trat.obs = txtDescricao.Text
            trat.cod_usuario = usuario.cod_usuario
            r = trat.Salvar()
            AVISO(r, Me, frmAviso.tipo_aviso.tipo_ok, False)
            novo = False
            Exit Sub
        Else
            trat.cod_os = x_os
            trat.id_filial_os = x_id_filial
            trat.data_envio = dtEnvio.Value
            trat.os_fornecedor = txtDoc3.Text
            trat.obs = txtDescricao.Text
            AVISO(trat.Salvar(), Me, frmAviso.tipo_aviso.tipo_ok, False)
        End If
    End Sub
    Private Sub btnConcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConcluir.Click
        Dim r As String
        r = andamentos.insere_andamento(objAndamentos.tipo.retorno_tratamento, x_id_filial, x_os, usuario.cod_usuario, "")
        If r.StartsWith("OK") Then
            trat.data_retorno = Now
            r = r & vbCrLf & trat.Salvar
            AVISO(r, Me, frmAviso.tipo_aviso.tipo_ok)
        Else
            AVISO(r, Me, frmAviso.tipo_aviso.tipo_ok, True)
            Me.Close()
            Exit Sub
        End If
    End Sub
End Class