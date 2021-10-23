Imports mrotica_util

Public Class frmCodBarraAndamentos
    Dim d As New dados
    Dim tb_temp As New DataTable
    Private Sub frmCodBarraUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaLista1()
        Cria_tb_temp()
    End Sub
    Private Sub CarregaLista1()
        Dim sql As String
        Dim tbAnd As New DataTable
        sql = "select andamento,cod_andamento from tipo_andamento where cod_setor > 2"
        d.carrega_Tabela(sql, tbAnd)
        lstAndamentos.DataSource = tbAnd
        lstAndamentos.DisplayMember = "andamento"
        lstAndamentos.ValueMember = "cod_andamento"
    End Sub
    Private Sub carregaLista2()
        lstPrint.DataSource = tb_temp
        lstPrint.DisplayMember = "andamento"
        lstPrint.ValueMember = "cod_andamento"
        lstPrint.Refresh()
    End Sub
    Private Sub Cria_tb_temp()
        tb_temp.Columns.Add("cod_andamento")
        tb_temp.Columns.Add("andamento")
    End Sub

    Private Sub lstUsuarios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstAndamentos.DoubleClick
        Dim r As DataRow
        r = tb_temp.NewRow
        r("cod_andamento") = lstAndamentos.SelectedValue
        r("andamento") = lstAndamentos.Text
        tb_temp.Rows.Add(r)
        carregaLista2()
    End Sub

    Private Sub btpPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btpPrint.Click
        Dim r As New rptCodBarraAndamentos
        Dim f As New frmRpt
        r.DataSource = tb_temp
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
        r.Dispose()
    End Sub
End Class