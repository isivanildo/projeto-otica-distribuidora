Imports mrotica_util
Public Class frmRetificacao
    Dim os As New ObjOS
    Dim anda As New objAndamentos
    Dim user As New objUsuario
    Dim conf As New config
    Dim n_os As Integer
    Private Sub frmAvisoOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As String
        r = user.login(Me)
        If r.StartsWith("OK") Then
            Dim res As frmAviso.respo
            Dim fil, nOs As Integer
            res = AVISO("Essa OS é da Ótica?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
            If res = frmAviso.respo.SIM Then
                fil = InputBox("Informe a Filial:")
                nOs = InputBox("Informe a OS:")
                Dim os As New ObjOS(nOs, fil, "")
                n_os = os.cod_os
            Else
                n_os = InputBox("Informe a OS da Labonorte:")
            End If
        End If
    End Sub

    Private Sub btnAviso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAviso.Click
        AVISO(anda.insere_andamento(objAndamentos.tipo.aviso_os, conf.Filial, n_os, user.cod_usuario, "RETIFICAÇÃO:" & vbTab & txtAviso.Text), Me, frmAviso.tipo_aviso.tipo_ok)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class