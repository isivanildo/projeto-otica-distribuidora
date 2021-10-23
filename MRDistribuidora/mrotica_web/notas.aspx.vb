Imports winotica_util
Imports System.Data
Partial Class notas
    Inherits System.Web.UI.Page
    Dim d As New dados("winweb", "winotica", "dellservidor", "winotica")
    Dim tb As New DataTable

    Protected Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        d.carrega_Tabela(filtra, tb)
        grdNotas.DataSource = tb
        grdNotas.DataBind()
        If tb.Rows.Count = 0 Then
            txtStatus.Text = "Nenhum registro encontrado"
        Else
            txtStatus.Text = tb.Rows.Count & " nota(s) encontrada(s)"
        End If
    End Sub
    Private Function filtra() As String
        Dim tsql As String
        tsql = "select conferencia_nota_master.*,fornecedor.Fornecedor,  " & _
            "(select SUM(conferencia_nota.quant) AS quantidade FROM conferencia_nota " & _
            "where conferencia_nota.id_conferencia = conferencia_nota_master.id_conferencia and " & _
            "conferencia_nota.id_filial_nota  = conferencia_nota_master.id_filial_nota)  as quantidade " & _
            "from conferencia_nota_master " & _
            "inner join fornecedor on conferencia_nota_master.cod_fornecedor = fornecedor.cod_fornecedor " & _
            "where data >=" & d.Pdt(txtDI.Text) & " and data <= " & d.Pdt(txtDF.Text) & _
            "and id_filial = " & txtFilial.Text & ""
        Return tsql
    End Function
    Private Function filtraNota() As String
        Dim tsql As String
        tsql = "select conferencia_nota_master.*,fornecedor.Fornecedor,  " & _
            "(select SUM(conferencia_nota.quant) AS quantidade FROM conferencia_nota " & _
            "where conferencia_nota.id_conferencia = conferencia_nota_master.id_conferencia and " & _
            "conferencia_nota.id_filial_nota  = conferencia_nota_master.id_filial_nota)  as quantidade " & _
            "from conferencia_nota_master " & _
            "inner join fornecedor on conferencia_nota_master.cod_fornecedor = fornecedor.cod_fornecedor " & _
            "where conferencia_nota_master.Documento like '%" & txtNota.Text & "%' " & _
            "and id_filial = " & txtFilial.Text & ""
        Return tsql
    End Function

    Protected Sub btnOKNota_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOKNota.Click
        d.carrega_Tabela(filtraNota, tb)
        grdNotas.DataSource = tb
        grdNotas.DataBind()
        If tb.Rows.Count = 0 Then
            txtStatus.Text = "Nenhum registro encontrado"
        Else
            txtStatus.Text = tb.Rows.Count & " nota(s) encontrada(s)"
        End If
    End Sub
End Class
