Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmEstoquePreferencial
    Dim objEstoque As New objMaster

    Private Sub frmEstoquePreferencial_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carregaCombo()
    End Sub

    Private Sub carregaCombo()
        Dim strSQL As String = "Select id_filial, filial from almoxarifado"
        Dim tt As New DataTable
        tt = objEstoque.retornaRegistro(strSQL).Tables(0)

        cbFilial.DisplayMember = "filial"
        cbFilial.ValueMember = "id_filial"
        cbFilial.DataSource = tt
        cbFilial.SelectedIndex = -1
    End Sub

    Private Sub carregaLentes()
        grdLentes.Columns.Clear()
        grdLentes.AutoGenerateColumns = False
        grdLentes.AllowUserToAddRows = False
        grdLentes.DataSource = Nothing

        Dim codtabela As New DataGridViewTextBoxColumn
        codtabela.HeaderText = "Cód. Tabela"
        codtabela.DataPropertyName = "cod_tabela"
        codtabela.Width = 100
        codtabela.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdLentes.Columns.Add(codtabela)

        Dim nome As New DataGridViewTextBoxColumn
        nome.HeaderText = "Lente"
        nome.DataPropertyName = "nome_comercial"
        nome.Width = 450
        grdLentes.Columns.Add(nome)

        Dim filial As New DataGridViewTextBoxColumn
        filial.HeaderText = "Filial"
        filial.DataPropertyName = "id_filial"
        filial.Width = 20
        filial.Visible = False
        grdLentes.Columns.Add(filial)

        Dim strSQL As String = "select estoque_preferencial.cod_tabela, estoque_preferencial.id_filial, lentes_tabela.nome_comercial " & _
            "from estoque_preferencial inner join lentes_tabela on estoque_preferencial.cod_tabela = lentes_tabela.cod_tabela " & _
            "where id_filial = " & cbFilial.SelectedValue

        Dim tt As New DataTable
        tt = objEstoque.retornaRegistro(strSQL).Tables(0)
        grdLentes.DataSource = tt
        If tt.Rows.Count > 0 Then
            Me.Text = "Estoque Preferêncial - Total de Lentes: " & tt.Rows.Count
        End If
    End Sub

    Private Sub cbFilial_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cbFilial.SelectionChangeCommitted
        If cbFilial.Text <> String.Empty Then
            carregaLentes()
        End If
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja excluir este item?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim strSQLExc As String = "where cod_tabela = " & grdLentes.CurrentRow.Cells(0).Value & " and id_filial = " & cbFilial.SelectedValue
            objEstoque.excluir_registros("estoque_preferencial", strSQLExc, True)
            MessageBox.Show("Item excluído com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            carregaLentes()
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        Dim codigo As String = InputBox("Digite o código da lente a ser cadastrada.", "Lentes", "")
        Dim filial As Integer = cbFilial.SelectedValue

        Dim strSQL As String = "Select 1 From estoque_preferencial where cod_tabela = " & codigo & " and " & " id_filial = " & filial

        If Not IsNumeric(codigo) And codigo <> "" Then
            MessageBox.Show("Só é permitido a entrada de valores númericos.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If objEstoque.verifica_existencia_registro(strSQL) = False Then
                Dim strSQLInsert As String = "Insert Into estoque_preferencial(cod_tabela,id_filial) values(" & codigo & "," & filial & ")"
                objEstoque.grava_registros(strSQLInsert, True)
                MessageBox.Show("Lente cadastrada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                carregaLentes()
            Else
                MessageBox.Show("Registro já existente na tabela do banco de dados.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class