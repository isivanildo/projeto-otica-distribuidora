Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmPedidoAutorizacao
    Dim autorizacao As New objMaster
    Dim conf As New config
    Dim d As New dados

    Private Sub txtCodCliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCodCliente.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim strSQL As String = "Select cod_filial_cliente, nome_cliente, razao_social from cliente where cod_cliente = " & CInt(txtCodCliente.Text)
                Dim tt As New DataTable
                tt = autorizacao.retornaRegistro(strSQL).Tables(0)

                If tt.Rows.Count > 0 Then
                    txtIdFilial.Text = tt.Rows(0)("cod_filial_cliente").ToString
                    lblNomeCliente.Text = tt.Rows(0)("nome_cliente").ToString
                    lblRazao.Text = tt.Rows(0)("razao_social").ToString
                    lblNomeCliente.Visible = True
                    lblRazao.Visible = True
                Else
                    MessageBox.Show("Cliente não encontrado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub


    Private Sub btnAutorizar_Click(sender As System.Object, e As System.EventArgs) Handles btnAutorizar.Click
        If MessageBox.Show("Deseja autorizar venda para este cliente?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim intUsuario As Integer = autorizacao.retorna_codigo_usuario(frmMain.intCodigoUsuario)
            Dim strSQL As String = "Select autorizacao from controle"
            Dim intReg As Integer = autorizacao.retornaUltimoRegistro("controle", "autorizacao") + 1

            Dim strSQLInsert As String = "insert into pedido_autorizacao(cod_autorizacao,id_filial_autorizacao,cod_cliente,cod_filial_cliente,data_autorizacao,usuario) " & _
                "values(" & intReg & "," & conf.Filial & "," & CInt(txtCodCliente.Text) & "," & CInt(txtIdFilial.Text) & "," & d.Pdt(autorizacao.retornaDataHoraServidor()) & "," & _
                intUsuario & ")"
            autorizacao.grava_registros(strSQLInsert, True)

            Dim strSQLAtualiza As String = "autorizacao = " & intReg
            autorizacao.atualiza_registros("controle", strSQLAtualiza, True)
            MessageBox.Show("Autorização efetuada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class