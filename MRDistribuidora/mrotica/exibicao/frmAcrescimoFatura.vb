Imports mrotica_util
Public Class frmAcrescimosFatura
    Public fatura As objFatura
    Public credito As objCreditoCliente
    Public origem As tipoAcrescimo
    Dim conf As New config
    Public Enum tipoAcrescimo As Integer
        fatura = 1
        credito = 2
    End Enum
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        'Dim r As Integer
        'If origem = tipoAcrescimo.fatura Then
        'r = MsgBox("Deseja lançar acréscimo como crédito!", MsgBoxStyle.YesNo)
        'If r = vbYes Then
        'credito = New objCreditoCliente
        'credito.novo()
        'credito.cod_filial_cliente = fatura.cod_filial_cliente
        'credito.cod_cliente = fatura.cod_cliente
        'credito.data = Now
        'credito.id_filial = conf.Filial
        'credito.historico = ""
        'credito.credito = txtValor.Text
        'credito.historico = txtDesc.Text
        'credito.id_usuario = UserID
        'credito.Salvar()
        'End If
        fatura.Historico_Desc_Texto = txtDesc.Text
        MsgBox(fatura.insere_acrescimo(txtValor.Text, UserID, txtDesc.Text))
        grdAcres.DataSource = fatura.listaAcrescimos
        'Else
        'MsgBox(credito.insere_acrescimo(txtValor.Text, UserID, txtDesc.Text))
        'grdAcres.DataSource = credito.listaAcrescimos
        'End If
    End Sub
    Private Sub frmDescontosFatura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If origem = tipoAcrescimo.fatura Then
        grdAcres.DataSource = fatura.listaAcrescimos
        'Else
        'grdAcres.DataSource = credito.listaAcrescimos
        'End If
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub grdDesc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdAcres.DoubleClick
        Dim id As Integer
        id = grdAcres.Item(0, grdAcres.CurrentCell.ColumnNumber)
        If origem = tipoAcrescimo.fatura Then
            fatura.deleta_acrescimo(id)
            grdAcres.DataSource = fatura.listaAcrescimos
        Else
            credito.deleta_acrescimo(id)
            grdAcres.DataSource = credito.listaAcrescimos
        End If
    End Sub
End Class