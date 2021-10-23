Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Imports System.Windows.Forms

Public Class frmTrocaSenha
    Public codusuario As Integer
    Dim d As New dados
    Dim objSeguranca As New objSecurity
    Dim objSenha As New objMaster

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtAnterior.Text = String.Empty Then
            MessageBox.Show("Por favor informar senha anterior.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If txtNovaSenha.Text = String.Empty Then
            MessageBox.Show("Por favor informar nova senha.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txtNovaSenha.Text.Trim.Length > 15 Then
            MessageBox.Show("Senha deve conter no máximo 15 dígitos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("Deseja alterar a senha anterior pela nova senha informada?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If txtAnterior.Text = objSeguranca.DecryptText(senhaAnterior(codusuario)) Then
                Dim strSQL As String = "SENHA = '" & objSeguranca.EncryptText(txtNovaSenha.Text) & "' WHERE COD_USUARIO = " & codusuario
                objSenha.atualiza_registros("Usuarios", strSQL, True)
                MessageBox.Show("Senha alterada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Senha anterior informada não confere com a atual." & Chr(13) & "Senha não foi alterada.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Operação cancelada com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Public Function senhaAnterior(ByVal codusuario As Integer) As String
        Dim res As String = ""
        Dim strSQL As String = "SELECT SENHA FROM USUARIOS WHERE COD_USUARIO = " & codusuario & ""
        d.conecta()
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim dr As SqlDataReader
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                res = dr("SENHA").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
        Return res
    End Function
End Class