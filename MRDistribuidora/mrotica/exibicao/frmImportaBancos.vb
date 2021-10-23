Imports mrotica_util
Public Class frmImportaBancos
    Dim banco As String()
    Dim d As New dados
    Private Sub btnProcessar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessar.Click
        Dim i As Integer = 0
        While i < txt.Lines.Length
            banco = txt.Lines(i).Split(";")
            salva_banco(banco(0), banco(1))
            i = i + 1
        End While
        MsgBox("OK")
    End Sub
    Private Sub salva_banco(ByVal cod, ByVal banco)
        Dim sql As String
        sql = "Insert into bancos(cod_banco,banco) values(" & tira(cod) & "," & d.PStr(tira(banco)) & ")"
        d.Comando(sql, False)
    End Sub
    Private Function tira(ByVal str)
        Dim st As String
        st = Replace(str, "'", "")
        str = Replace(st, "Banco ", "")
        Return str
    End Function
End Class