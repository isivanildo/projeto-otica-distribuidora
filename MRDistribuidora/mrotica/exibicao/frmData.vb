Imports mrotica_util
Public Class frmData

    Dim conf As New config

    Private Sub frmData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFilial.Text = conf.Filial
        Me.dtIni.Value = Now
        Me.dtFim.Value = Now
    End Sub


    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        If dtIni.Value.ToShortDateString > dtFim.Value.ToShortDateString Then
            MessageBox.Show("Data inicial não pode ser maior que a data final.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtIni.Focus()
            Exit Sub
        End If
        Dim intFilial As Integer
        intFilial = txtFilial.Text
        Dim f As New frmRpt
        Dim r As New rptCaixa
        r.diai = dtIni.Value.ToShortDateString
        r.diaf = dtFim.Value.ToShortDateString
        r.intFilial = intFilial
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class