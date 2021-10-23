Imports mrotica_util
Public Class frmConsultaCliente
    Dim tb As New DataTable
    Dim cl As New objCliente
    Dim p As Integer
    Public cod_cliente As Integer = Nothing
    Public cod_filial As Integer = Nothing
    Public nome As String
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Dim f As New frmAviso
        f.Left = Me.Left
        f.Top = Me.Top
        f.Show("Buscando. Aguarde...")
        Application.DoEvents()
        tb = cl.lista_clientes(txtNome.Text)
        grd_cliente()
        f.Dispose()
    End Sub
    Private Sub grd_cliente()
        grdCliente.DataSource = tb
        Dim TStb As New DataGridTableStyle
        TStb.MappingName = tb.TableName

        Dim cCod As New DataGridTextBoxColumn
        With cCod
            .MappingName = "cod_cliente"
            .HeaderText = "Código"
            .Width = 50
        End With
        TStb.GridColumnStyles.Add(cCod)

        Dim cNome As New DataGridTextBoxColumn
        With cNome
            .MappingName = "nome_cliente"
            .HeaderText = "Nome"
            .Width = 200
        End With
        TStb.GridColumnStyles.Add(cNome)

        Dim rs As New DataGridTextBoxColumn
        With RS
            .MappingName = "razao_social"
            .HeaderText = "Razão Social"
            .Width = 250
        End With
        TStb.GridColumnStyles.Add(rs)

        Dim cidade As New DataGridTextBoxColumn
        With cidade
            .MappingName = "cidade"
            .HeaderText = "cidade"
            .Width = 80
        End With
        TStb.GridColumnStyles.Add(cidade)

        Dim complemento As New DataGridTextBoxColumn
        With complemento
            .MappingName = "complemento"
            .HeaderText = "complemento"
            .Width = 200
        End With
        TStb.GridColumnStyles.Add(complemento)

        grdCliente.TableStyles.Clear()
        grdCliente.TableStyles.Add(TStb)
    End Sub
    Private Sub txtNome_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNome.GotFocus
        Me.AcceptButton = btnConsultar
    End Sub
    Private Sub txtNome_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNome.LostFocus
        Me.AcceptButton = btnOk
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            cod_cliente = tb.Rows(p)("cod_cliente")
            cod_filial = tb.Rows(p)("cod_filial_cliente")
            nome = tb.Rows(p)("nome_cliente")
        Catch ex As Exception

        End Try
        Me.Close()
    End Sub

    Private Sub grdCliente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdCliente.CurrentCellChanged
        Try
            p = grdCliente.CurrentRowIndex
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnOk_Click(Me, e.Empty)
        End If
    End Sub

End Class