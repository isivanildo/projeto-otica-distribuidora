Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Imports MRUtil

Public Class frmAutorizacao
    Dim User As New Usuario
    Dim objAut As New objMaster
    Dim conf As New config
    Dim d As New dados
    Dim tt As New DataTable

    Private Sub btnAutorizar_Click(sender As System.Object, e As System.EventArgs) Handles btnAutorizar.Click
        If MessageBox.Show("Deseja autorizar o valor informado para este cliente?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim chave As New Integer
            Dim valor As Double = CDbl(txtValorAutorizado.Text)
            Dim strDescricao As String = txtDescricaoAut.Text
            Dim intUsuario As Integer

            User.RetornaRegistro(frmMain.intCodigoUsuario)
            intUsuario = User.CodigoUsuario  ' objAut.retorna_codigo_usuario(frmMain.strUsuario)

            chave = objAut.retornaUltimoRegistro("autorizacao", "cod_autorizacao", " where filial_autorizacao = " & conf.Filial & "")

            Dim strSQL As String = "INSERT INTO autorizacao (cod_autorizacao ,filial_autorizacao ,cod_filial_cliente " &
            " ,cod_cliente,cod_usuario,valor,data,descricao) " &
            "VALUES(" & chave & "," & conf.Filial & "," & tt.Rows(0)("cod_filial_cliente") & "," & tt.Rows(0)("cod_cliente") & "," & intUsuario &
            "," & d.cdin(valor) & "," & d.pdtm(Now) & "," & d.PStr(strDescricao) & ")"

            objAut.grava_registros(strSQL, True)
            MessageBox.Show("Autorização realizada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub


    Private Sub txtCodCliente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCodCliente.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim strSQL As String = "Select nome_cliente, razao_social, cod_filial_cliente, cod_cliente from cliente where cod_cliente = " & CInt(txtCodCliente.Text) &
                    " and cod_filial_cliente = " & conf.Filial
                tt = objAut.retornaRegistro(strSQL).Tables(0)
                txtCodCliente.Text = tt.Rows(0)("cod_cliente")
                txtNome.Text = tt.Rows(0)("nome_cliente")
                txtRazao.Text = tt.Rows(0)("razao_social")
                If tt.Rows.Count > 0 Then
                    txtCodCliente.ReadOnly = True
                    txtValorAutorizado.Focus()
                End If
        End Select
    End Sub

    Private Sub txtCodCliente_Click(sender As System.Object, e As System.EventArgs) Handles txtCodCliente.Click
        txtCodCliente.ReadOnly = False
        txtCodCliente.SelectAll()
    End Sub

    Private Sub txtCodCliente_Leave(sender As System.Object, e As System.EventArgs) Handles txtCodCliente.Leave
        txtCodCliente.ReadOnly = True
    End Sub
End Class