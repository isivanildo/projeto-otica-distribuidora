Imports mrotica_util
Public Class frmAbreTabelaPromocional
    Dim tab As New objTabelaPromocional
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAbreTabelaPromocional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_tabelas()
    End Sub
    Private Sub carrega_tabelas()
        Dim TStb As New DataGridTableStyle
        grdTab.DataSource = tab.lista_tabelas
        TStb.MappingName = grdTab.DataSource.tablename

        Dim codTab As New DataGridTextBoxColumn
        With codTab
            .MappingName = "cod_tabela_promocional"
            .HeaderText = "Código"
            .Width = 50
        End With
        TStb.GridColumnStyles.Add(codTab)

        Dim Fil As New DataGridTextBoxColumn
        With Fil
            .MappingName = "id_filial"
            .HeaderText = "Filial"
            .Width = 50
        End With
        TStb.GridColumnStyles.Add(Fil)

        Dim cNome As New DataGridTextBoxColumn
        With cNome
            .MappingName = "Tabela_promocional"
            .HeaderText = "Descrição"
            .Width = 250
        End With
        TStb.GridColumnStyles.Add(cNome)

        Dim cDI As New DataGridTextBoxColumn
        With cDI
            .MappingName = "data_inicio"
            .HeaderText = "Inicio"
        End With
        TStb.GridColumnStyles.Add(cDI)

        Dim cDF As New DataGridTextBoxColumn
        With cDF
            .MappingName = "data_termino"
            .HeaderText = "Término"
        End With
        TStb.GridColumnStyles.Add(cDF)
        
        grdTab.TableStyles.Clear()
        grdTab.TableStyles.Add(TStb)
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim fil, cod As Integer
        Dim f As New frmTabelaPromocional
        Try
            cod = grdTab.Item(grdTab.CurrentRowIndex, 0)
            fil = grdTab.Item(grdTab.CurrentRowIndex, 1)
        Catch ex As Exception
            Exit Sub
        End Try
        f.x_cod_tabela = cod
        f.x_id_filial = fil
        f.ShowDialog(Me)
        f.Dispose()
        Me.Close()
    End Sub
End Class