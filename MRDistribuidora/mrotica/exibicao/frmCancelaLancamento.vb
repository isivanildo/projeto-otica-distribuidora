Public Class frmCancelaLancamento
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtdesc.Text = "" Then
            AVISO("Informe o motivo do cancelamento!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            Exit Sub
        Else
            Me.Close()
        End If
    End Sub
End Class