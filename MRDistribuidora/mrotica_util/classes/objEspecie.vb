Public Class objEspecie
    Dim tb As DataTable
    Private Sub cria_tabela()
        tb = New DataTable
        tb.Columns.Add("tipo")
        tb.Columns.Add("desc")
    End Sub
    Private Sub popula_tabela()
        Dim r As DataRow
        r = tb.NewRow
        r("tipo") = "B"
        r("desc") = "Bloco"
        tb.Rows.Add(r)

        r = tb.NewRow
        r("tipo") = "L"
        r("desc") = "Lente"
        tb.Rows.Add(r)

        r = tb.NewRow
        r("tipo") = "BS"
        r("desc") = "Bloco Surfaçado"
        tb.Rows.Add(r)

        r = tb.NewRow
        r("tipo") = "LC"
        r("desc") = "Lente de Contato"

        r = tb.NewRow
        r("tipo") = "AR"
        r("desc") = "Armação"
        tb.Rows.Add(r)

    End Sub
    Public Sub New()
        cria_tabela()
        popula_tabela()
    End Sub
    Public Function especies() As DataTable
        Return tb
    End Function
End Class
