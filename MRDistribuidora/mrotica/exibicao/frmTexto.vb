Imports mrotica_util

Public Class frmTexto
    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub frmTexto_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If txtTexto.Text = String.Empty Then
            MessageBox.Show("Informe o motivo do cancelamento da OS.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTexto.Focus()
            e.Cancel = True
        End If
    End Sub
End Class