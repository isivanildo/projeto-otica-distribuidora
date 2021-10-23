Imports mrotica_util
Public Class frmTitulosAcordo
    Dim d As New dados
    Dim tb As New DataTable
    Dim id As Integer
    Public ttRes As New DataTable
    Public cliente As objCliente
    Private Sub frmTitulosAcordo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_titulos()
    End Sub
    Private Sub Cria_tabela()
        ttRes.Columns.Add("id_filial")
        ttRes.Columns.Add("cod_lancamento")
    End Sub
    Public Sub carrega_titulos()
        tb = cliente.lista_titulos_acordo
        grdTitulos.DataSource = tb
        formata_grid()
    End Sub
    Private Sub formata_grid()
        Dim TStb As New DataGridTableStyle
        TStb.MappingName = grdTitulos.DataSource.tablename

        Dim ctipo As New DataGridTextBoxColumn
        With ctipo
            .MappingName = "tipo_documento"
            .HeaderText = "tipo"
        End With
        TStb.GridColumnStyles.Add(ctipo)

        Dim cDoc As New DataGridTextBoxColumn
        With cDoc
            .MappingName = "documento"
            .HeaderText = "Documento"
        End With
        TStb.GridColumnStyles.Add(cDoc)
        Dim cNum As New DataGridTextBoxColumn
        With cNum
            .MappingName = "nossonumero"
            .HeaderText = "Boleto"
            .Width = 150
        End With
        TStb.GridColumnStyles.Add(cNum)

        Dim cData As New DataGridTextBoxColumn
        With cData
            .MappingName = "data_lancamento"
            .HeaderText = "Emissao"
        End With
        TStb.GridColumnStyles.Add(cData)
        Dim cVenc As New DataGridTextBoxColumn
        With cVenc
            .MappingName = "data_vencimento"
            .HeaderText = "Vencimento"
        End With
        TStb.GridColumnStyles.Add(cVenc)
        Dim cValor As New DataGridTextBoxColumn
        With cValor
            .MappingName = "valor"
            .HeaderText = "Valor"
            .Format = "R$#,##0.00"
        End With
        TStb.GridColumnStyles.Add(cValor)

        
        grdTitulos.TableStyles.Clear()
        grdTitulos.TableStyles.Add(TStb)
    End Sub
    Private Sub grdPedidos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTitulos.CurrentCellChanged
        Try
            id = grdTitulos.CurrentRowIndex
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            Dim i, m As Integer
            Dim r As DataRow
            Cria_tabela()
            i = 0
            m = tb.Rows.Count
            While i < m
                If grdTitulos.IsSelected(i) = True Then
                    r = ttRes.NewRow
                    r("id_filial") = tb.Rows(i)("id_filial")
                    r("cod_lancamento") = tb.Rows(i)("cod_lancamento")
                    ttRes.Rows.Add(r)
                End If
                i = i + 1
            End While
        Catch ex As Exception

        End Try
        Me.Close()
    End Sub
    
End Class