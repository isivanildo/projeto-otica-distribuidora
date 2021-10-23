Imports mrotica_util

Public Class frmConsultaForPesq
    Dim tb As New DataTable
    Dim forn As New objForn
    Dim p As Integer
    Public cod_fornecedor As Integer = Nothing
    Public nome As String
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Dim f As New frmAviso
        f.Left = Me.Left
        f.Top = Me.Top
        f.Show("Buscando. Aguarde...")
        Application.DoEvents()
        tb = forn.lista_Fornecedores(txtNome.Text)
        grd_cliente()
        f.Dispose()
    End Sub
    Private Sub grd_cliente()
        grdForn.DataSource = tb
        Dim TStb As New DataGridTableStyle
        TStb.MappingName = tb.TableName
        Dim cNome As New DataGridTextBoxColumn
        With cNome
            .MappingName = "fornecedor"
            .HeaderText = "Nome"
            .Width = 300
        End With
        TStb.GridColumnStyles.Add(cNome)
        grdForn.TableStyles.Clear()
        grdForn.TableStyles.Add(TStb)
    End Sub
    Private Sub txtNome_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNome.GotFocus
        Me.AcceptButton = btnConsultar
    End Sub
    Private Sub txtNome_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNome.LostFocus
        Me.AcceptButton = btnOk
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            cod_fornecedor = tb.Rows(p)("cod_fornecedor")
            nome = tb.Rows(p)("fornecedor")
        Catch ex As Exception

        End Try
        Me.Close()
    End Sub

    Private Sub grdCliente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdForn.CurrentCellChanged
        Try
            p = grdForn.CurrentRowIndex
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdForn.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnOk_Click(Me, e.Empty)
        End If
    End Sub
End Class