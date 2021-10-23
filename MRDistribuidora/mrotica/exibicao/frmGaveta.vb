Imports mrotica_util
Public Class frmGaveta
    Dim d As New dados
    Private Sub frmGaveta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT gaveta FROM conferencia_detalhes GROUP BY gaveta order by gaveta"
        d.carrega_Tabela(sql, tt)
        cbGaveta.DataSource = tt
        cbGaveta.DisplayMember = "gaveta"
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class