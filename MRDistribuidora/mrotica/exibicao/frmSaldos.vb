Imports mrotica_util
Public Class frmSaldos
    Dim d As New dados
    Dim p As New produtoClass
    Dim conf As New config
    Dim tt As New DataTable
    Dim objSaldo As New objMaster
    Private Sub frmSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_Filial()
        cbFilial.SelectedValue = conf.Filial
    End Sub
    Private Sub formata_grid(ByVal t As DataTable)
        grdItens.Columns.Clear()
        grdItens.DataSource = Nothing
        grdItens.AutoGenerateColumns = False
        grdItens.AllowUserToAddRows = False

        Dim cc As New DataGridViewTextBoxColumn
        With cc
            .DataPropertyName = "cod_produto"
            .HeaderText = "Cód. Prod"
            .Width = 80
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdItens.Columns.Add(cc)


        Dim cnc As New DataGridViewTextBoxColumn
        With cnc
            .DataPropertyName = "Produto"
            .HeaderText = "Descrição do Produto"
            .Width = 460
        End With
        grdItens.Columns.Add(cnc)

        Dim cFilial As New DataGridViewTextBoxColumn
        With cFilial
            .DataPropertyName = "id_Filial"
            .HeaderText = "Filial"
            .Visible = False
        End With
        grdItens.Columns.Add(cFilial)

        Dim cSaldo As New DataGridViewTextBoxColumn
        With cSaldo
            .DataPropertyName = "saldo"
            .HeaderText = "Saldo"
            .Width = 75
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
        grdItens.Columns.Add(cSaldo)

        t = p.saldos_labo(txtTabela.Text, txtCrit.Text, cbFilial.Text)
        grdItens.DataSource = t
        tt = t
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        formata_grid(p.saldos_labo(txtTabela.Text, txtCrit.Text, cbFilial.Text))
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim r As New rptSaldos
        Dim f As New frmRpt
        r.DataSource = tt
        f.Relat(r)
        f.Show()
    End Sub



    Private Sub DetalhamentoSaldoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetalhamentoSaldoToolStripMenuItem.Click
        grdItens_DoubleClick(Me, EventArgs.Empty)
    End Sub

    Private Sub DetalhamentoPedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetalhamentoPedidosToolStripMenuItem.Click
        detalhamento_pedidos()
    End Sub
    Private Sub detalhamento_pedidos()
        Dim p As New produtoClass
        Dim cp As Integer
        Dim tit As String
        Dim f As New frmGrd
        cp = grdItens.CurrentRow.Cells(0).Value
        tit = "Detalhamento de pedidos " & grdItens.CurrentRow.Cells(1).Value & " filial " & _
        cbFilial.Text
        f.grd.DataSource = p.detalhamento_pedidos(cp, cbFilial.Text)
        f.Text = tit
        f.Show() 
    End Sub

    Private Sub carrega_Filial()
        Dim ttFilial As New DataTable
        Dim strSQL As String = "Select id_filial from almoxarifado"
        ttFilial = objSaldo.retornaRegistro(strSQL).Tables(0)
        cbFilial.DisplayMember = "id_filial"
        cbFilial.ValueMember = "id_filial"
        cbFilial.DataSource = ttFilial
    End Sub

  
    Private Sub grdItens_DoubleClick(sender As System.Object, e As System.EventArgs) Handles grdItens.DoubleClick
        Dim f As New frmRpt
        Dim r As New rptExtrato
        Dim p As New produtoClass
        Dim d As New frmDataPeriodo
        Dim cp As Integer
        Dim tit As String
        cp = grdItens.CurrentRow.Cells(0).Value
        'grdItens.Item(grdItens.CurrentCell.RowNumber, 0)
        d.ShowDialog(Me)
        tit = "Movimentação do produto " & grdItens.CurrentRow.Cells(1).Value & " entre " & _
        d.dtIni.Value.ToString.Substring(0, 10) & " e " & d.dtFim.Value.ToString.Substring(0, 10)
        r.titulo = tit
        r.DataSource = p.Extrato(cp, d.dtIni.Value.ToString.Substring(0, 10) & " 00:00:00", d.dtFim.Value.ToString.Substring(0, 10) & " 23:59:59", cbFilial.Text)
        f.Relat(r)
        f.Show()
    End Sub
End Class