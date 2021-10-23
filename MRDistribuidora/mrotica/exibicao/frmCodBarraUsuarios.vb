Imports mrotica_util

Public Class frmCodBarraUsuarios
    Dim d As New dados
    Dim tb_temp As New DataTable
    Private Sub frmCodBarraUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaLista1()
        Cria_tb_temp()
    End Sub
    Private Sub CarregaLista1()
        Dim sql As String
        Dim tbUsu As New DataTable
        sql = "select Nome,cod_usuario from usuarios "
        d.carrega_Tabela(sql, tbUsu)
        lstUsuarios.DataSource = tbUsu
        lstUsuarios.DisplayMember = "Nome"
        lstUsuarios.ValueMember = "cod_usuario"
    End Sub
    Private Sub carregaLista2()
        lstPrint.DataSource = tb_temp
        lstPrint.DisplayMember = "nome"
        lstPrint.ValueMember = "cod_usuario"
        lstPrint.Refresh()
    End Sub
    Private Sub Cria_tb_temp()
        tb_temp.Columns.Add("cod_usuario")
        tb_temp.Columns.Add("nome")
    End Sub

    Private Sub lstUsuarios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstUsuarios.DoubleClick
        Dim r As DataRow
        r = tb_temp.NewRow
        r("cod_usuario") = lstUsuarios.SelectedValue
        r("nome") = lstUsuarios.Text
        tb_temp.Rows.Add(r)
        carregaLista2()
    End Sub

    Private Sub btpPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btpPrint.Click
        Dim r As New rptCodBarraUsuario
        Dim f As New frmRpt
        r.DataSource = tb_temp
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
        r.Dispose()
    End Sub
End Class