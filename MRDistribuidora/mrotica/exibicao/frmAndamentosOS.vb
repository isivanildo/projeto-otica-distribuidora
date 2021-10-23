Imports mrotica_util
Public Class frmAndamentosOS
    Dim anda As New objAndamentos
    Dim c As New config
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim r As New rptAndamentos
        Dim f As New frmRpt
        Dim os As New ObjOS
        r.xfilial = txtFilial.Text
        r.xos = txtOS.Text
        r.DataSource = os.andamentos_os(txtFilial.Text, txtOS.Text)
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnReimpressão_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReimpressão.Click
        Dim r As New objFilaImpressao
        Dim via As String
        Dim user As New objUsuario
        Dim res As String
        res = user.login(Me)
        'Procedimento 15 Reimpressão"
        If res.StartsWith("OK") Then
            If user.acesso(15) = True Then
                anda.insere_andamento(objAndamentos.tipo.aviso_os, txtFilial.Text, txtOS.Text, user.cod_usuario, "Reimpressão: " & InputBox("Informe o motivo da reimpressão:") & "")
                AVISO("Na fila para reimpressão:" & vbCrLf & r.Inserir_fila(txtOS.Text, txtFilial.Text, c.Filial), Me, frmAviso.tipo_aviso.tipo_ok)
            Else
                MsgBox("Usuário não tem acesso!")
            End If

        End If
    End Sub

    Private Sub frmAndamentosOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtOS.Focus()
    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        PrintOS()
    End Sub
    Private Sub PrintOS()
        Dim tsql As String
        Dim tt As New DataTable
        Dim r As New rptOS
        Dim f As New frmRpt
        Dim d As New dados
        tsql = "Select os.*, (select nome_comercial from lentes_tabela where cod_tabela = os.cod_tab_od) as TAB_OD, " & _
        "(select nome_comercial from lentes_tabela where cod_tabela = os.cod_tab_oe) as TAB_OE, " & _
        "(select produto from produtos where cod_produto = os.cod_produto_od) as EST_OD," & _
        "(select produto from produtos where cod_produto = os.cod_produto_oe) as EST_OE, " & _
        "(select produto from produtos where cod_produto = os.cod_montagem) as Armacao " & _
        "FROM OS where os.id_filial = " & txtFilial.Text & _
        "and OS.cod_os = " & txtOS.Text & ""
        d.carrega_Tabela(tsql, tt)
        r.DataSource = tt
        r.Fila = False
        f.Relat(r)
        f.ShowDialog(Me)
    End Sub
End Class