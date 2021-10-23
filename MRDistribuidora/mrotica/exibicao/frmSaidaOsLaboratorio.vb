Imports mrotica_util
Public Class frmSaidaOsLaboratorio
    Dim tb As New DataTable
    Dim sql As String
    Dim dv As New DataView
    Dim d As New dados
    Dim tb_temp As New DataTable
    Dim os As ObjOS
    Dim andamento As New objAndamentos
    Dim objSaida As New objMaster
    Dim intUsuario As Integer

    Private Sub frmSaidaOsLaboratorio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intUsuario = objSaida.retorna_codigo_usuario(frmMain.intCodigoUsuario)
    End Sub

    Private Sub baixa()
        Dim fil As Integer
        Dim c_os As Integer
        Dim os_cliente As String
        Dim res As String
        Dim strOS As String
        fil = txtOS.Text.Substring(0, 3)
        c_os = txtOS.Text.Substring(3)

        Dim strSQL As String = ""

        strSQL = "select id_filial, cod_os, cod_cliente, doc_cliente, cod_produto_od, cod_produto_oe from OS where cod_os = " & c_os & " and id_filial = " & fil
        Dim tbSaida As New DataTable
        tbSaida = objSaida.retornaRegistro(strSQL).Tables(0)

        If tbSaida.Rows.Count > 0 Then
            strSQL = "cod_fase = 8 where cod_os = " & c_os & " and id_filial = " & fil
            objSaida.atualiza_registros("OS", strSQL, True)

            os_cliente = ""
            If tbSaida.Rows(0)("cod_cliente") < 1000 Then
                os_cliente = adiciona_zeros(tbSaida.Rows(0)("cod_cliente"), 3) & "-" & adiciona_zeros(tbSaida.Rows(0)("doc_cliente"), 6)
            End If
            If os_cliente <> String.Empty Then
                txtRetiradas.Text = Now & " -> OS Ana Maria: " & os_cliente & " / OS Labonorte: " & txtOS.Text &
                " Usuário: " & frmMain.intCodigoUsuario & vbCrLf & txtRetiradas.Text
            Else
                txtRetiradas.Text = Now & " -> OS Labonorte: " & txtOS.Text & " Usuário: " & frmMain.intCodigoUsuario & vbCrLf & txtRetiradas.Text
            End If
            andamento.insere_andamento(objAndamentos.tipo.retirada_os_laboratorio, fil, c_os, intUsuario,
            "OS retirada do Estoque por: " & frmMain.intCodigoUsuario & "")

            If tbSaida.Rows(0)("cod_cliente") < 1000 Then
                If objSaida.tem_bloco(tbSaida.Rows(0)("cod_produto_od")) Or objSaida.tem_bloco(tbSaida.Rows(0)("cod_produto_oe")) Then
                    res = andamento.insere_andamento(objAndamentos.tipo.malote_loja, tbSaida.Rows(0)("id_filial"), _
                    tbSaida.Rows(0)("cod_os"), intUsuario, "No malote p/ Lab. Matriz")
                End If
            End If
        Else
            MessageBox.Show(res, "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtOS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOS.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                baixa()
                txtOS.Text = ""
                txtOS.Focus()
                Me.Focus()
        End Select
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Dim fp As New frmRpt
        Dim r As New rptOSsRetiradas
        r.texto = txtRetiradas.Text
        fp.Relat(r)
        fp.ShowDialog(Me)
    End Sub

End Class