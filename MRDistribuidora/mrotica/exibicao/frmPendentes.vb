Imports mrotica_util
Public Class frmPendentes
    Public tb As New DataTable
    Dim max, pos As Integer
    Dim os As New ObjOS
    Private Sub frmPendentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        max = tb.Rows.Count
        pos = 0
        Carrega_dados()
    End Sub
    Private Sub Carrega_dados()
        If max = 0 Then
            lblStatus.Text = "Não há os's pendentes!"
            Exit Sub
        End If
        If pos = max Then pos = pos - 1
        If pos > max Then pos = pos = max - 1
        If pos < 0 Then pos = 0
        txtPOD.Text = rdTexto(tb.Rows(pos)("OD"))
        txtPOE.Text = rdTexto(tb.Rows(pos)("OE"))
        txtOS.Text = adiciona_zeros(tb.Rows(pos)("id_filial"), 3) & adiciona_zeros(tb.Rows(pos)("cod_os"), 6)
        status()
    End Sub
    Public Sub status()
        lblStatus.Text = "OS " & pos + 1 & " de " & max
    End Sub

    Private Sub btnAvancar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvancar.Click
        pos = pos + 1
        Carrega_dados()
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        pos = pos - 1
        Carrega_dados()
    End Sub

    Private Sub btnBaixar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaixar.Click
        Dim f As New frmBaixaOS
        f.carrega_os(tb.Rows(pos)("cod_os"), tb.Rows(pos)("id_filial"))
        f.ShowDialog(Me)
        f.Dispose()
        tb = os.lista_pendentes_estoque
        max = tb.Rows.Count
        pos = 0
        LimpaControles(Me.Controls)
        Carrega_dados()
    End Sub
End Class