Imports mrotica_util
Public Class frmContfora
    Dim d As New dados
    Dim trat As New objContFora
    Public novo As Boolean
    Public x_os, x_id_filial As Integer
    Dim os As New ObjOS
    Dim andamentos As New objAndamentos
    Dim usuario As New objUsuario
    Dim c As New config
    Private Sub frmContTratamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        abrir()
    End Sub
    Private Sub abrir()
        AVISO(usuario.login(Me), Me, frmAviso.tipo_aviso.tipo_ok)
        'Procedimento 9 Inserir controle de tratamento
        If usuario.acesso(usuario.cod_usuario, 9) = False Then
            AVISO("Usuário não tem permissão para controle de serviço feito fora!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            Me.Close()
            Exit Sub
        End If
        If novo = True Then
            trat.filtra(x_os, x_id_filial)
            btnConcluir.Enabled = False
            dtEnvio.Value = Now
            trat.novo()
        Else
            trat.filtra(x_os, x_id_filial)
            If trat.max = 0 Then
                AVISO("Esta OS não tem registro de controle de serviço feito fora!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                Exit Sub
                Me.Close()
            End If
            If trat.max > 1 Then
                While IsDate(trat.data_retorno) = True
                    trat.proximo()
                End While
            End If
            dtEnvio.Value = rdData(trat.data_envio)
            txtDoc3.Text = trat.os_fornecedor
            txtDescricao.Text = trat.obs
            chkSN(chkOD, trat.OD)
            chkSN(chkOE, trat.OE)
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
            r = andamentos.insere_andamento(objAndamentos.tipo.Envio_fazer_fora, x_id_filial, x_os, usuario.cod_usuario, txtDescricao.Text & vbCrLf & txtDoc3.Text)
            If r.StartsWith("ER") Then
                AVISO(r, Me, frmAviso.tipo_aviso.tipo_ok, True)
                Me.Close()
                Exit Sub
            End If
            trat.cod_os = x_os
            trat.id_filial_os = x_id_filial
            os = New ObjOS(x_os, x_id_filial)
            os.editar()
            os.cod_fase = 23
            os.Salvar()
            trat.data_envio = dtEnvio.Value
            trat.os_fornecedor = txtDoc3.Text
            trat.obs = txtDescricao.Text
            trat.cod_usuario = usuario.cod_usuario
            trat.OD = chkSN(chkOD)
            trat.OE = chkSN(chkOE)
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
            trat.OD = chkSN(chkOD)
            trat.OE = chkSN(chkOE)
            AVISO(trat.Salvar(), Me, frmAviso.tipo_aviso.tipo_ok, False)
        End If
    End Sub
    Private Sub btnConcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConcluir.Click
        Dim r As String
        Dim f As New objFilaImpressao
        Dim fb As New frmBaixaOS
        r = andamentos.insere_andamento(objAndamentos.tipo.Retorno_fazer_fora, x_id_filial, x_os, usuario.cod_usuario, "")
        If r.StartsWith("OK") Then
            Dim fextra As New frmSaidaExtra
            Dim res As String
            trat.data_retorno = Now
            r = r & vbCrLf & trat.Salvar
            os = New ObjOS(trat.cod_os, trat.cod_filial)
            os.editar()
            os.cod_lab_surf = 999999
            MsgBox(os.Salvar())
            res = os.processa_os_fora(trat)
            If res.StartsWith("EXTRA") Then
                fextra.nSaidaExtra = res.Substring(5)
                fextra.ShowDialog(Me)
                fextra.Dispose()
                Me.Close()
                Exit Sub
            Else
                AVISO(r, Me, frmAviso.tipo_aviso.tipo_ok)
                AVISO("Na fila para impressão:" & vbCrLf & f.Inserir_fila(os.cod_os, x_id_filial, confFilial), Me, frmAviso.tipo_aviso.tipo_ok)
                'AVISO("Na fila para impressão:" & vbCrLf & f.Inserir_fila(os.cod_os, os.id_filial, conf.Filial), Me, frmAviso.tipo_aviso.tipo_ok)
                Me.Close()
                Exit Sub
            End If
        Else
            AVISO(r, Me, frmAviso.tipo_aviso.tipo_ok, True)
            Me.Close()
            Exit Sub
        End If
    End Sub
End Class