Imports mrotica_util

Public Class frmConsultaLenteTabela
    Public cod_tabela As Integer = Nothing
    Public nome_tabela As String = Nothing
    Dim tab As New objTabela
    Public tabRes As DataTable
    Dim i As Integer = 0
    Dim d As New dados

    Private Sub monta_tabela()
        Dim i As Integer = 0
        Dim r As DataRow
        tabRes = New DataTable
        tabRes.TableName = "Codigos"
        tabRes.Columns.Add("cod_tabela")
        While i < grdLen.DataSource.rows.count
            If grdLen.IsSelected(i) Then
                r = tabRes.NewRow
                r("cod_tabela") = grdLen.Item(i, 1)
                tabRes.Rows.Add(r)
            End If
            i = i + 1
        End While
    End Sub
    Private Sub consulta()
        Dim sql As String
        Dim criterio As String = txtCriterio1.Text.Replace(" ", "%")
        sql = "Select cod_tabela,nome_comercial,preco_venda from lentes_tabela where nome_comercial like '%" & criterio & "%'"
        grdLen.DataSource = tab.lista_lentes(sql)
        formata_grid()
    End Sub
    Private Sub formata_grid()
        Dim TStb As New DataGridTableStyle
        TStb.MappingName = grdLen.DataSource.tablename
        Dim cItem As New DataGridTextBoxColumn
        With cItem
            .MappingName = "nome_comercial"
            .HeaderText = "Produto"
            .Width = 360
        End With
        TStb.GridColumnStyles.Add(cItem)
        Dim ccod As New DataGridTextBoxColumn
        With ccod
            .MappingName = "cod_tabela"
            .HeaderText = "código"
        End With
        TStb.GridColumnStyles.Add(ccod)

        Dim cpreco As New DataGridTextBoxColumn
        With cpreco
            .MappingName = "preco_venda"
            .HeaderText = "Preco :"
            .Width = 50
            .Alignment = HorizontalAlignment.Right
            .Format = "#,##0.00 "
        End With
        TStb.GridColumnStyles.Add(cpreco)

        grdLen.TableStyles.Clear()
        grdLen.TableStyles.Add(TStb)
    End Sub
    Private Sub grdLen_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdLen.CurrentCellChanged
        Try
            i = grdLen.CurrentRowIndex
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmConsultaLenteTabela_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            nome_tabela = grdLen.Item(i, 0)
            cod_tabela = grdLen.Item(i, 1)
            monta_tabela()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnFechar_Click(sender As System.Object, e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnLocalizar_Click(sender As System.Object, e As System.EventArgs) Handles btnLocalizar.Click
        consulta()
    End Sub
End Class