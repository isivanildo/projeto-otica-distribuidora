Public Class frmObservacao

    Public strObservacao As String

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        strObservacao = TextBox1.Text
        Me.Close()
    End Sub
End Class