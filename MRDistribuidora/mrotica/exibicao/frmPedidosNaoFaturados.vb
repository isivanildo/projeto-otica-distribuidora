Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmPedidosNaoFaturados
    Dim d As New dados
    Dim acesso As New objMaster
    Dim pdfExport As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
    Dim excelExport As New DataDynamics.ActiveReports.Export.Xls.XlsExport
    Dim cidade As New objCliente
    Dim conf As New config
    Dim strListaItem As String = ""
    Dim strListaDesc As String = ""

    Private Sub frmPedidosNaoFaturados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carrega_tipo_compra()
    End Sub

    Private Sub carrega_tipo_compra()
        Dim tt As New DataTable
        Dim strSQL As String = ""
        strSQL = "select * from tipo_compra"
        d.carrega_Tabela(strSQL, tt)
        lstTipoCompra.DataSource = tt
        lstTipocompra.DisplayMember = "descricao"
        lstTipocompra.ValueMember = "codigo"
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim f As New frmRpt
        Dim r As New rptClientesFaturar
        Dim strsQL As String = ""
        Dim intTipoCompra As Int16
        Dim dtInicial As Date = dtIni.Value.ToShortDateString & " 00:00:01"
        Dim dtFinal As Date = dtFim.Value.ToShortDateString & " 23:59:59"

        Try
            If rbTudo.Checked = True Then
                If cbPeriodo.Checked = False Then
                    strsQL = "SELECT faturamento_mensal.*, tipo_compra.descricao FROM faturamento_mensal() " & _
                    "inner join tipo_compra on faturamento_mensal.forma = tipo_compra.codigo " & _
                    "WHERE cod_status_pedido IN (1,2) AND Total > 0 AND Faturado = 0 AND id_filial = " & conf.Filial & _
                    " AND cod_cliente > 1000 AND cod_cliente <> 10260 ORDER BY nome_cliente, data_pedido"
                End If
                If cbPeriodo.Checked = True Then
                    strsQL = "SELECT faturamento_mensal.*, tipo_compra.descricao FROM faturamento_mensal() " & _
                    "inner join tipo_compra on faturamento_mensal.forma = tipo_compra.codigo " & _
                    "WHERE cod_status_pedido IN (1,2) AND Total > 0 AND Faturado = 0 AND id_filial = " & conf.Filial & _
                    " AND cod_cliente > 1000 AND cod_cliente <> 10260 and data_pedido >= " & d.pdtm(dtInicial) & _
                    " and data_pedido <= " & d.pdtm(dtFinal) & " ORDER BY nome_cliente, data_pedido"
                End If
                r.Label3.Text = "Lista de Pedidos Não Faturado por Cliente"
            End If


            If rbTipoCompra.Checked = True Then
                strListaItem = tipocompra("I")
                strListaDesc = tipocompra("D")
                If cbPeriodo.Checked = False Then
                    strsQL = "SELECT faturamento_mensal.*, tipo_compra.descricao FROM faturamento_mensal() " & _
                    "inner join tipo_compra on faturamento_mensal.forma = tipo_compra.codigo " & _
                    "WHERE cod_status_pedido IN (1,2) AND forma IN (" & strListaItem & ") AND Total > 0 AND Faturado = 0 AND id_filial = " & conf.Filial & _
                    " AND cod_cliente > 1000 AND cod_cliente <> 10260 ORDER BY nome_cliente, data_pedido"
                End If
                If cbPeriodo.Checked = True Then
                    strsQL = "SELECT faturamento_mensal.*, tipo_compra.descricao FROM faturamento_mensal() " & _
                    "inner join tipo_compra on faturamento_mensal.forma = tipo_compra.codigo " & _
                    "WHERE cod_status_pedido IN (1,2) AND forma IN (" & strListaItem & ") AND Total > 0 AND Faturado = 0 AND id_filial = " & conf.Filial & _
                    " AND cod_cliente > 1000 AND cod_cliente <> 10260 and data_pedido >= " & d.pdtm(dtInicial) & _
                    " and data_pedido <= " & d.pdtm(dtFinal) & " ORDER BY nome_cliente, data_pedido"
                End If
                r.Label3.Text = "Lista de Pedidos Não Faturado por Cliente - (" & strListaDesc & ")"
            End If

            d.conecta()
            Dim da As New SqlDataAdapter(strsQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Cliente")
            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait

            If ds.Tables(0).Rows.Count > 0 Then
                r.DataSource = ds.Tables(0)
            Else
                MessageBox.Show("Não há registro a ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            f.Relat(r)
            f.ShowDialog()
            f.Dispose()
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub cbPeriodo_Click(sender As System.Object, e As System.EventArgs) Handles cbPeriodo.Click
        If cbPeriodo.Checked = True Then
            dtIni.Enabled = True
            dtFim.Enabled = True
        End If
        If cbPeriodo.Checked = False Then
            dtIni.Enabled = False
            dtFim.Enabled = False
        End If
    End Sub

    Private Sub exportaPDF(ByVal r As DataDynamics.ActiveReports.Document.Document, ByVal path As String)
        If MessageBox.Show("Deseja exportar os dados para área de trabalho?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            pdfExport.Export(r, path)
            MessageBox.Show("Arquivo exportado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub exportaExcel(ByVal r As DataDynamics.ActiveReports.Document.Document, ByVal path As String)
        If MessageBox.Show("Deseja exportar os dados para área de trabalho?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            excelExport.Export(r, path)
            MessageBox.Show("Arquivo exportado com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnExportarPDF_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarPDF.Click
        Dim f As New frmRpt
        Dim r As New rptClientesFaturar
        Dim strsQL As String = ""
        Dim intTipoCompra As Int16
        Dim dtInicial As Date = dtIni.Value.ToShortDateString & " 00:00:01"
        Dim dtFinal As Date = dtFim.Value.ToShortDateString & " 23:59:59"
        Dim path As String = ""

        Try
            If rbTudo.Checked = True Then
                If cbPeriodo.Checked = False Then
                    strsQL = "SELECT faturamento_mensal.*, tipo_compra.descricao FROM faturamento_mensal() " & _
                    "inner join tipo_compra on faturamento_mensal.forma = tipo_compra.codigo " & _
                    "WHERE cod_status_pedido IN (1,2) AND Total > 0 AND Faturado = 0 AND id_filial = " & conf.Filial & _
                    " AND cod_cliente > 1000 AND cod_cliente <> 10260 ORDER BY nome_cliente, data_pedido"
                    path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & "todos.pdf"
                End If
                If cbPeriodo.Checked = True Then
                    strsQL = "SELECT faturamento_mensal.*, tipo_compra.descricao FROM faturamento_mensal() " & _
                    "inner join tipo_compra on faturamento_mensal.forma = tipo_compra.codigo " & _
                    "WHERE cod_status_pedido IN (1,2) AND Total > 0 AND Faturado = 0 AND id_filial = " & conf.Filial & _
                    " AND cod_cliente > 1000 AND cod_cliente <> 10260 and data_pedido >= " & d.pdtm(dtInicial) & _
                    " and data_pedido <= " & d.pdtm(dtFinal) & " ORDER BY nome_cliente, data_pedido"
                    path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & "todos_" & dtIni.Value.ToShortDateString.Replace("/", "") & "_" & dtFim.Value.ToShortDateString.Replace("/", "") & ".pdf"
                End If
                r.Label3.Text = "Lista de Pedidos Não Faturado por Cliente"
            End If


            If rbTipoCompra.Checked = True Then
                strListaItem = tipocompra("I")
                strListaDesc = tipocompra("D")
                If cbPeriodo.Checked = False Then
                    strsQL = "SELECT faturamento_mensal.*, tipo_compra.descricao FROM faturamento_mensal() " & _
                    "inner join tipo_compra on faturamento_mensal.forma = tipo_compra.codigo " & _
                    "WHERE cod_status_pedido IN (1,2) AND forma IN (" & strListaItem & ") AND Total > 0 AND Faturado = 0 AND id_filial = " & conf.Filial & _
                    " AND cod_cliente > 1000 AND cod_cliente <> 10260 ORDER BY nome_cliente, data_pedido"
                    path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & "tipo_compra" & ".pdf"
                End If
                If cbPeriodo.Checked = True Then
                    strsQL = "SELECT faturamento_mensal.*, tipo_compra.descricao FROM faturamento_mensal() " & _
                    "inner join tipo_compra on faturamento_mensal.forma = tipo_compra.codigo " & _
                    "WHERE cod_status_pedido IN (1,2) AND forma IN (" & strListaItem & ") AND Total > 0 AND Faturado = 0 AND id_filial = " & conf.Filial & _
                    " AND cod_cliente > 1000 AND cod_cliente <> 10260 and data_pedido >= " & d.pdtm(dtInicial) & _
                    " and data_pedido <= " & d.pdtm(dtFinal) & " ORDER BY nome_cliente, data_pedido"
                    path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & "tipo_compra_" & dtIni.Value.ToShortDateString.Replace("/", "") & "_" & dtFim.Value.ToShortDateString.Replace("/", "") & ".pdf"
                End If
                r.Label3.Text = "Lista de Pedidos Não Faturado por Cliente - (" & strListaDesc & ")"
            End If


            d.conecta()
            Dim da As New SqlDataAdapter(strsQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Cliente")
            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            If ds.Tables(0).Rows.Count > 0 Then
                r.DataSource = ds.Tables(0)
            Else
                MessageBox.Show("Não há registro a ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            f.Relat(r)
            f.Dispose()
            exportaPDF(r.Document, path)
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnExportarExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportarExcel.Click
        Dim f As New frmRpt
        Dim r As New rptClientesFaturar
        Dim strsQL As String = ""
        Dim intTipoCompra As Int16
        Dim dtInicial As Date = dtIni.Value.ToShortDateString & " 00:00:01"
        Dim dtFinal As Date = dtFim.Value.ToShortDateString & " 23:59:59"
        Dim path As String = ""

        Try
            If rbTudo.Checked = True Then
                If cbPeriodo.Checked = False Then
                    strsQL = "SELECT faturamento_mensal.*, tipo_compra.descricao FROM faturamento_mensal() " & _
                    "inner join tipo_compra on faturamento_mensal.forma = tipo_compra.codigo " & _
                    "WHERE cod_status_pedido IN (1,2) AND Total > 0 AND Faturado = 0 AND id_filial = " & conf.Filial & _
                    " AND cod_cliente > 1000 AND cod_cliente <> 10260 ORDER BY nome_cliente, data_pedido"
                    path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & "todos.xls"
                End If
                If cbPeriodo.Checked = True Then
                    strsQL = "SELECT faturamento_mensal.*, tipo_compra.descricao FROM faturamento_mensal() " & _
                    "inner join tipo_compra on faturamento_mensal.forma = tipo_compra.codigo " & _
                    "WHERE cod_status_pedido IN (1,2) AND Total > 0 AND Faturado = 0 AND id_filial = " & conf.Filial & _
                    " AND cod_cliente > 1000 AND cod_cliente <> 10260 and data_pedido >= " & d.pdtm(dtInicial) & _
                    " and data_pedido <= " & d.pdtm(dtFinal) & " ORDER BY nome_cliente, data_pedido"
                    path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & "todos_" & dtIni.Value.ToShortDateString.Replace("/", "") & "_" & dtFim.Value.ToShortDateString.Replace("/", "") & ".xls"
                End If
                r.Label3.Text = "Lista de Pedidos Não Faturado por Cliente"
            End If


            If rbTipoCompra.Checked = True Then
                strListaItem = tipocompra("I")
                strListaDesc = tipocompra("D")
                If cbPeriodo.Checked = False Then
                    strsQL = "SELECT faturamento_mensal.*, tipo_compra.descricao FROM faturamento_mensal() " & _
                    "inner join tipo_compra on faturamento_mensal.forma = tipo_compra.codigo " & _
                    "WHERE cod_status_pedido IN (1,2,3) AND forma IN (" & strListaItem & ") AND Total > 0 AND Faturado = 0 AND id_filial = " & conf.Filial & _
                    " AND cod_cliente > 1000 AND cod_cliente <> 10260 ORDER BY nome_cliente, data_pedido"
                    path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & "tipo_compra" & ".xls"
                End If
                If cbPeriodo.Checked = True Then
                    strsQL = "SELECT faturamento_mensal.*, tipo_compra.descricao FROM faturamento_mensal() " & _
                    "inner join tipo_compra on faturamento_mensal.forma = tipo_compra.codigo " & _
                    "WHERE cod_status_pedido IN (1,2,3) AND forma IN (" & strListaItem & ") AND Total > 0 AND Faturado = 0 AND id_filial = " & conf.Filial & _
                    " AND cod_cliente > 1000 AND cod_cliente <> 10260 and data_pedido >= " & d.pdtm(dtInicial) & _
                    " and data_pedido <= " & d.pdtm(dtFinal) & " ORDER BY nome_cliente, data_pedido"
                    path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & "tipo_compra_" & dtIni.Value.ToShortDateString.Replace("/", "") & "_" & dtFim.Value.ToShortDateString.Replace("/", "") & ".xls"
                End If
                r.Label3.Text = "Lista de Pedidos Não Faturado por Cliente - (" & strListaDesc & ")"
            End If


            d.conecta()
            Dim da As New SqlDataAdapter(strsQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Cliente")
            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            If ds.Tables(0).Rows.Count > 0 Then
                r.DataSource = ds.Tables(0)
            Else
                MessageBox.Show("Não há registro a ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            f.Relat(r)
            f.Dispose()
            exportaExcel(r.Document, path)
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function tipocompra(ByVal tipo As Char) As String
        Dim i As Integer
        Dim strItem As String
        Dim strDescricao As String

        For i = 0 To lstTipoCompra.CheckedItems.Count - 1
            If i < lstTipoCompra.CheckedItems.Count - 1 Then
                strItem = strItem + lstTipoCompra.CheckedItems(i)(0).ToString & ","
                strDescricao = strDescricao + lstTipoCompra.CheckedItems(i)(1).ToString & ","
            Else
                strItem = strItem + lstTipoCompra.CheckedItems(i)(0).ToString
                strDescricao = strDescricao + lstTipoCompra.CheckedItems(i)(1).ToString
            End If
        Next
        If tipo = "I" Then
            Return strItem
        End If
        If tipo = "D" Then
            Return strDescricao
        End If
    End Function

    Private Sub rbTipoCompra_Click(sender As System.Object, e As System.EventArgs) Handles rbTipoCompra.Click
        lstTipoCompra.Enabled = True
    End Sub

    Private Sub rbTudo_Click(sender As System.Object, e As System.EventArgs) Handles rbTudo.Click
        lstTipoCompra.Enabled = False
    End Sub
End Class