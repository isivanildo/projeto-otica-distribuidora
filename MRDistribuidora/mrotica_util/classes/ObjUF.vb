Public Class ObjUF
    Dim d As New dados
    Public Property CidadeIBGE As Integer
    Public Property UfIBGE As Integer
    Public Property Cidade As String
    Public Property Estado As String

    Public Sub New()

    End Sub

    Public Sub RetornaUF(ByVal x_codigocidade)
        Dim tb As New DataTable

        d.carrega_Tabela("select c.*, e.estado from cidade as c left join uf as e on c.uf = e.codigo where c.codigo = " & x_codigocidade, tb)

        If tb.Rows.Count > 0 Then
            CidadeIBGE = Convert.ToInt32(tb.Rows(0)("codigo").ToString())
            Cidade = tb.Rows(0)("cidade")
            UfIBGE = Convert.ToInt32(tb.Rows(0)("uf").ToString())
            Estado = tb.Rows(0)("estado").ToString()
        End If
    End Sub
End Class
