Imports mrotica_util
Public Class frmAvisoOS
    Dim os As New ObjOS
    Dim anda As New objAndamentos
    Dim user As New objUsuario
    Dim conf As New config
    Dim n_os As Integer
    Dim i_loja As Integer
    Public labo As Boolean = False
    Dim intUsuario As Integer
    Dim objAviso As New objMaster
    Private Sub frmAvisoOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As String
        intUsuario = objAviso.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        'r = user.login(Me)
        'If r.StartsWith("OK") Then
        If labo = True Then
            i_loja = InputBox("Digite o número da Filial:")
            n_os = InputBox("Digite o número da OS Local (Labonorte):")
        Else
            i_loja = InputBox("Digite o número da Loja:")
            n_os = InputBox("Digite o número da OS:")
            os = New ObjOS(n_os, i_loja, "")
            n_os = os.cod_os
            i_loja = os.id_filial
        End If
        'End If
    End Sub
    Private Sub btnAviso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAviso.Click
        AVISO(anda.insere_andamento(objAndamentos.tipo.aviso_os, i_loja, n_os, intUsuario, txtAviso.Text), Me, frmAviso.tipo_aviso.tipo_ok)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class