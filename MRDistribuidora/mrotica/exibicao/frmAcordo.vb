Imports mrotica_util
Public Class frmAcordo
    Dim d As New dados
    Public acordo As New objAcordo
    Dim item As item_acordo
    Public novo As Boolean
    Public cod_filial_cliente, cod_cliente As Integer
    Public cliente As objCliente
    Private Sub frmAcordo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_combos()
    End Sub
    Private Sub carrega_combos()
        Dim tb_forma As New DataTable
        d.carrega_Tabela("select * from forma_pagamento " & _
        "where(cod_forma_pagamento <> 8) " & _
        "and cod_forma_pagamento <> 10 " & _
        "and cod_forma_pagamento <> 6 " & _
        "and cod_forma_pagamento <> 9", tb_forma)
        cbForma.DataSource = tb_forma
        cbForma.ValueMember = "cod_forma_pagamento"
        cbForma.DisplayMember = "forma_pagamento"
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        If novo = True Then
            acordo.novo()
            acordo.data = Now
            acordo.descricao = txtDescricao.Text
            acordo.acrescimo = txtAcrescimo.Text
            acordo.cod_usuario = UserID
            acordo.cod_status_acordo = 1
            acordo.cod_filial_cliente = cod_filial_cliente
            acordo.cod_cliente = cod_cliente
            MsgBox(acordo.Salvar)
            novo = False
            Exit Sub
        Else
            acordo.editar()
            acordo.descricao = txtDescricao.Text
            acordo.acrescimo = txtAcrescimo.Text
            MsgBox(acordo.Salvar)
        End If
    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click
        Dim tt As New DataTable
        Dim f As New frmTitulosAcordo
        Dim item As item_acordo
        f.cliente = cliente
        f.ShowDialog(Me)
        tt = f.ttRes
        For Each r As DataRow In tt.Rows
            item = New item_acordo(acordo.cod_acordo, acordo.filial_acordo)
            item.cod_lancamento = r("cod_lancamento")
            item.id_filial_lancamento = r("id_filial")
            acordo.insere_item(item)
        Next
    End Sub
End Class