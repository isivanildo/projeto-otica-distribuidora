Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rptTitulosCaixa
    Public diai As String
    Public diaf As String

    Private Sub ReportHeader1_Format(sender As System.Object, e As System.EventArgs) Handles ReportHeader1.Format
        If diai = diaf Then
            lblTitulo.Text = "Recebimentos Caixa Banco do dia " & diai
        Else
            lblTitulo.Text = "Recebimentos Caixa Banco do dia " & diai & " até " & diaf
        End If
    End Sub
End Class
