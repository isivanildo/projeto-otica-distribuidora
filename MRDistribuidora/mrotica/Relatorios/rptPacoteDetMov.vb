Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports mrotica_util
Public Class rptPacoteDetMov 
    Dim tab As New objTabela
    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        lblLente.Text = tab.ret_nome_tabela(txtCodTabela.Text)
    End Sub
End Class
