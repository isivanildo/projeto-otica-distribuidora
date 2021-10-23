Imports System
Public Class objSqlTrans
    Private _instrucao As String = String.Empty
    Private tb As New DataTable
    Public Sub New()
        tb.Columns.Add("instrucao")
    End Sub
    Public Sub insere_instrucao(ByVal iSql As String)
        Dim r As DataRow
        r = tb.NewRow
        r("instrucao") = iSql
        tb.Rows.Add(r)
    End Sub
    Public Function instrucoes() As DataTable
        Return tb
    End Function
End Class

