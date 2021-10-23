Imports mrotica_util
Public Class frmTratamentosPeriodo
    Dim tt As New DataTable
    Dim sql As String
    Dim d As New dados
    Private Sub frmTratamentosPeriodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim di, df As Date
        Dim f As New frmRpt
        Dim r As New rptTratamentos
        r.titulo = "Tratamentos no período de " & dtini.Value.Date & " até " & dtFim.Value.Date
        di = dtini.Value.Date & " 00:00:00"
        df = dtFim.Value.Date & " 23:59:59"
        sql = "SELECT Controle_tratamento.cod_os, OS.cod_cliente, OS.doc_cliente, " & _
        "Controle_tratamento.data_envio, Controle_tratamento.data_retorno, Usuarios.NOME, " & _
        "produtos.produto, Controle_tratamento.obs " & _
        "FROM Controle_tratamento INNER JOIN " & _
        "OS ON Controle_tratamento.id_filial_os = OS.id_filial AND Controle_tratamento.cod_os = " & _
        "OS.cod_os INNER JOIN " & _
        "Usuarios ON Controle_tratamento.cod_usuario = Usuarios.cod_usuario INNER JOIN " & _
        "tratamentos_os ON OS.id_filial = tratamentos_os.id_filial AND OS.cod_os = " & _
        "tratamentos_os.cod_os INNER JOIN " & _
        "produtos ON tratamentos_os.cod_produto = produtos.cod_produto " & _
        "where Controle_tratamento.data_envio >= " & d.pdtm(di) & _
        " and Controle_tratamento.data_envio <= " & d.pdtm(df) & _
        " order by Controle_tratamento.data_envio ,OS.cod_cliente, OS.doc_cliente"

        d.carrega_Tabela(sql, tt)
        r.DataSource = tt
        f.Relat(r)
        f.Show()

    End Sub
End Class