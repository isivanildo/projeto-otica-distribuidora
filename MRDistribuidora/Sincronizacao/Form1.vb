Imports System.Data
Imports System.Data.SqlClient
Imports winotica_util

Public Class Form1
    Dim d As New dados
    Dim strTeste As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim teste As New ServicoWebCliente.ServicoWeb
        Dim strInst As String = Replace(teste.retornaDadosFila, "`", "'")
        strInst = Replace(strInst, "produtos", "produtosteste")
        d.conecta()
        Dim cmd As New SqlCommand(strInst, d.con)
        cmd.ExecuteNonQuery()
        d.desconecta()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        d.conecta()
        Dim strSQL As String = "SELECT TOP(1) INSTRUCAO FROM FILA_IMPORTACAO WHERE DATA_PROCESSAMENTO IS NULL"
        strSQL = Replace(strSQL, "`", "'")
        Dim CMD As New SqlCommand(strSQL, d.con)
        Dim dr As SqlDataReader
        dr = CMD.ExecuteReader
        dr.Read()
        strTeste = dr("INSTRUCAO").ToString
        d.desconecta()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        d.conecta()
        Dim CMD As New SqlCommand(strTeste, d.con)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        d.desconecta()
    End Sub
End Class
