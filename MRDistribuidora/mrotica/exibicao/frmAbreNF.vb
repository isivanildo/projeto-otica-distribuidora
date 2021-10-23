Imports mrotica_util
Public Class frmAbreNF
    Dim entrada As New objEntradaNota
    Public x_id_conferencia, x_filial As Integer
    Public ttLista As New DataTable
    Public strConcluido As String
    Public tipo_form As String = ""

    Private Sub Cria_tabela()
        ttLista.Columns.Add("id_conferencia")
        ttLista.Columns.Add("id_filial")
        ttLista.Columns.Add("pedido")
        ttLista.Columns.Add("NF")
    End Sub
    Private Sub carrega_grd()
        Dim TStb As New DataGridTableStyle
        grdProd.DataSource = entrada.lista_notas(strConcluido)
        TStb.MappingName = grdProd.DataSource.tablename

        Dim cItem As New DataGridTextBoxColumn
        With cItem
            .MappingName = "documento"
            .HeaderText = "doc"
            .Width = 130
        End With
        TStb.GridColumnStyles.Add(cItem)

        Dim cdata As New DataGridTextBoxColumn
        With cdata
            .MappingName = "data"
            .HeaderText = "data"
            .Width = 65
        End With
        TStb.GridColumnStyles.Add(cdata)

        Dim p As New DataGridTextBoxColumn
        With p
            .MappingName = "parte"
            .HeaderText = "p"
            .Width = 20
        End With
        TStb.GridColumnStyles.Add(p)

        Dim conc As New DataGridTextBoxColumn
        With conc
            .MappingName = "concluido"
            .HeaderText = "Concluído"
        End With
        TStb.GridColumnStyles.Add(conc)

        Dim ped As New DataGridTextBoxColumn
        With ped
            .MappingName = "pedido"
            .HeaderText = "Pedido"
            .Width = 200
        End With
        TStb.GridColumnStyles.Add(ped)

        Dim usr As New DataGridTextBoxColumn
        With usr
            .MappingName = "usuario"
            .HeaderText = "usuario"
            .Width = 200
        End With
        TStb.GridColumnStyles.Add(usr)

        Dim idc As New DataGridTextBoxColumn
        With idc
            .MappingName = "id_conferencia"
            .HeaderText = "id"
        End With
        TStb.GridColumnStyles.Add(idc)

        Dim filial As New DataGridTextBoxColumn
        With filial
            .MappingName = "id_filial_nota"
            .HeaderText = "filial"
        End With
        TStb.GridColumnStyles.Add(filial)

        grdProd.TableStyles.Clear()
        grdProd.TableStyles.Add(TStb)

    End Sub
    Private Sub grdProd_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        x_id_conferencia = grdProd.Item(grdProd.CurrentCell.RowNumber, 6)
        x_filial = grdProd.Item(grdProd.CurrentCell.RowNumber, 7)
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim i As Integer = 0
        Dim r As DataRow
        Cria_tabela()
        x_id_conferencia = grdProd.Item(grdProd.CurrentCell.RowNumber, 6)
        x_filial = grdProd.Item(grdProd.CurrentCell.RowNumber, 7)
        tipo_form = grdProd.Item(grdProd.CurrentCell.RowNumber, 0)
        While i < grdProd.DataSource.rows.count
            If grdProd.IsSelected(i) = True Then
                r = ttLista.NewRow
                r("id_conferencia") = grdProd.Item(i, 6)
                r("id_filial") = grdProd.Item(i, 7)
                r("pedido") = grdProd.Item(i, 4)
                r("NF") = grdProd.Item(i, 0)
                ttLista.Rows.Add(r)
            End If
            i = i + 1
        End While

        If tipo_form = "ENTRADA MANUAL" Then
            Dim f As New frmEntradaManualEstoque
            f.novo = False
            f.x_id_conferencia = x_id_conferencia
            f.x_filial = x_filial
            f.ShowDialog()
        Else
            Dim f As New frmConferenciaNota
            f.novo = False
            f.x_id_conferencia = x_id_conferencia
            f.x_filial = x_filial
            f.ShowDialog()
        End If

        Me.Close()
    End Sub

    Private Sub frmAbreNF_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        strConcluido = "N"
        carrega_grd()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        strConcluido = "S"
        carrega_grd()
    End Sub
End Class