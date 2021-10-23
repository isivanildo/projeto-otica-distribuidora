Imports mrotica_util
Public Class frmAcessosUsuario
    Public tLista As New DataTable
    Public UserId As Integer
    Dim user As New objUsuario
    Dim d As New dados
    Dim iPos As Integer
    Private Sub frmAcessosUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        user = New objUsuario(UserId)
        tLista = user.lista_acessos_usuario
        formata_grid_itens()
        combos()
    End Sub
    Private Sub formata_grid_itens()
        Dim TStb As New DataGridTableStyle
        grdItens.DataSource = tLista
        TStb.MappingName = grdItens.DataSource.tablename
        Dim cProc As New DataGridTextBoxColumn
        With cProc
            .MappingName = "procedimento"
            .HeaderText = "Procedimento"
            .Width = 300
        End With
        TStb.GridColumnStyles.Add(cProc)

        grdItens.TableStyles.Clear()
        grdItens.TableStyles.Add(TStb)
    End Sub
    Private Sub combos()
        Dim sql As String
        Dim tt As New DataTable
        Dim tbtip As New DataTable
        sql = "Select * from procedimentos_acesso"

        d.carrega_Tabela(sql, tt)
        cbProcedimento.DataSource = tt
        cbProcedimento.ValueMember = "cod_procedimento"
        cbProcedimento.DisplayMember = "procedimento"

        d.carrega_Tabela("Select * from tipo_usuario", tbtip)

        cbTipo.DataSource = tbtip
        cbTipo.DisplayMember = "tipo_usuario"
        cbTipo.ValueMember = "cod_tipo_usuario"
    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluir.Click
        AVISO(user.inclui_acesso(cbProcedimento.SelectedValue), Me, frmAviso.tipo_aviso.tipo_ok)
        tLista = user.lista_acessos_usuario
        formata_grid_itens()
    End Sub

    Private Sub grdItens_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdItens.CurrentCellChanged
        Try
            iPos = grdItens.CurrentRowIndex
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdItens_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdItens.DoubleClick
        Dim id As Integer
        id = tLista.Rows(iPos)("id_acessos")
        AVISO(user.exclui_acesso(id), Me, frmAviso.tipo_aviso.tipo_ok)
        tLista = user.lista_acessos_usuario
        formata_grid_itens()
    End Sub

    Private Sub btnTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTipo.Click
        user.exclui_acesso(user.cod_usuario)
        AVISO(user.inclui_acessos_tipo(cbTipo.SelectedValue), Me, frmAviso.tipo_aviso.tipo_ok)
        tLista = user.lista_acessos_usuario
        formata_grid_itens()
    End Sub
End Class