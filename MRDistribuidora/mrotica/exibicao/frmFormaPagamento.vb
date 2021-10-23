Imports mrotica_util

Public Class frmFormaPagamento

    Dim d As New dados
    Public intForma As Int16

    Private Sub frmFormaPagamento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carrega_forma()
    End Sub

    Private Sub carrega_forma()
        Dim tb_forma As New DataTable
        d.carrega_Tabela("Select * from forma_pagamento", tb_forma)
        cbForma.DataSource = tb_forma
        cbForma.ValueMember = "cod_forma_pagamento"
        cbForma.DisplayMember = "forma_pagamento"
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        intForma = cbForma.SelectedValue
        Me.Close()
    End Sub
End Class