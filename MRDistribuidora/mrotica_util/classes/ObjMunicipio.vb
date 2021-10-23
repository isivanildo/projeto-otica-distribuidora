Public Class ObjMunicipio

    Dim d As New dados
    Public Property CidadeIBGE As Integer
    Public Property Cidade As String
    Public Property UfIBGE As Integer

    Public Sub New()

    End Sub

    Public Sub RetornaCidade(ByVal x_codigocidade)
        Dim tb As New DataTable

        d.carrega_Tabela("select * from cidade where codigo = " & x_codigocidade, tb)

        If tb.Rows.Count > 0 Then
            CidadeIBGE = Convert.ToInt32(tb.Rows(0)("codigo").ToString())
            Cidade = tb.Rows(0)("cidade")
            UfIBGE = Convert.ToInt32(tb.Rows(0)("uf").ToString())
        End If
    End Sub

End Class
