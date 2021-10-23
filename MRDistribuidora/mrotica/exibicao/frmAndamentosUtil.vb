Imports mrotica_util
Public Class frmAndamentosUtil
    Dim c As New config
    Dim d As New dados
    Dim os As ObjOS
    Dim andamentos As New objAndamentos
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            os = New ObjOS(txtOS.Text, txtFilial.Text)
            carrega_grd()
            cbStatus.SelectedValue = os.cod_fase
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
      
    End Sub
    Public Sub carrega_grd()
        grdAndamentos.DataSource = os.andamentos_os
        grdAndamentos.Refresh()
    End Sub

    Private Sub frmAndamentosUtil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_combo()
    End Sub
    Private Sub carrega_combo()
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "Select * from fases_os"
        d.carrega_Tabela(tsql, tt)
        cbStatus.DataSource = tt
        cbStatus.ValueMember = "cod_fase"
        cbStatus.DisplayMember = "fase"
    End Sub

    Private Sub DeletarAndamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletarAndamentoToolStripMenuItem.Click
        Dim i As Integer
        Dim filial As Integer
        Dim cod_os As Integer
        Dim ord As Integer
        i = grdAndamentos.CurrentRow.Index
        ord = grdAndamentos.Item(2, i).Value
        cod_os = os.cod_os
        filial = os.id_filial
        MsgBox(andamentos.exclui_andamento(filial, cod_os, ord))
        carrega_grd()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        os.editar()
        os.cod_fase = cbStatus.SelectedValue
        MsgBox(os.Salvar)
    End Sub

    Private Sub txtOS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOS.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnOK_Click(Me, EventArgs.Empty)
        End Select
    End Sub

    Private Sub txtOS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOS.TextChanged

    End Sub
End Class