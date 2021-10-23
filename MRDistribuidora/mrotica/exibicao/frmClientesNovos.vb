Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util

Public Class frmClientesNovos
    Dim d As New dados
    Dim acesso As New objMaster

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim f As New frmRpt
        Dim r As New rptClientesNovos
        Dim strsQL As String = ""
        Dim strsQL2 As String = ""
        Dim strSQL3 As String = ""
        Dim data As String = "01/" & "01/" & Now.Year
        Dim dt1 As Date = DateAdd(DateInterval.Year, -1, CDate(data))
        Dim dt2 As Date = DateAdd(DateInterval.Month, -1, Now())


        'Novo
        Dim data1 As String = "01/" & Now.Month & "/" & Now.Year
        Dim dt3 As Date = CDate(data1)
        Dim dt4 As Date = Now()

        Dim intCodCliente As String = ""
        Try
            strsQL = "select num_pedido,cod_cliente, id_filial,data_pedido,nome_cliente," &
                "datediff(day,data_pedido,getdate()) as dias from clientes(" & d.Pdt(dt1) & "," & d.Pdt(dt2) & ") " &
                "where(DateDiff(Day, data_pedido, getdate()) > 90)"

            strsQL2 = "select num_pedido,cod_cliente, id_filial,data_pedido,nome_cliente," &
            "datediff(day,data_pedido,getdate()) as dias from clientes(" & d.Pdt(dt3) & "," & d.Pdt(dt4) & ") " &
            "where(DateDiff(Day, data_pedido, getdate()) < 90)"


            d.conecta()
            Dim da As New SqlDataAdapter(strsQL, d.con)
            Dim dac As New SqlDataAdapter(strsQL2, d.con)
            Dim ds As New DataSet
            Dim dsc As New DataSet
            da.Fill(ds, "Cliente")
            dac.Fill(dsc, "Cliente2")
            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            r.Label3.Text = "Demonstrativo de Clientes que não compravam a mais de 90 dias e que tiveram movimentação de compra no mês corrente"
            r.TextBox10.Text = "Emitido em: " & acesso.dataPorExtensoSemBelem
            Dim i As Integer
            Dim j As Integer
            Dim virgula As String = ""
            For i = 0 To ds.Tables(0).Rows.Count - 1
                For j = 0 To dsc.Tables(0).Rows.Count - 1
                    If ds.Tables(0).Rows(i)("cod_cliente").ToString = dsc.Tables(0).Rows(j)("cod_cliente").ToString Then
                        intCodCliente = ds.Tables(0).Rows(i)("cod_cliente").ToString & virgula & intCodCliente
                        virgula = ","
                    End If
                Next
            Next
            strSQL3 = "select num_pedido,cod_cliente, id_filial,data_pedido,nome_cliente," &
                "datediff(day,data_pedido,getdate()) as dias from clientes(" & d.Pdt(dt1) & "," & d.Pdt(dt2) & ") " &
                "where  cod_cliente IN (" & intCodCliente & ") " &
                "and (DateDiff(Day, data_pedido, getdate()) > 90)"
            Dim dag As New SqlDataAdapter(strSQL3, d.con)
            Dim dsg As New DataSet
            dag.Fill(dsg, "Cliente3")
            'If ds.Tables(0).Rows.Count > 0 Then
            r.DataSource = dsg.Tables(0)
            'Else
            'MessageBox.Show("Não há registro a ser exibido.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Exit Sub
            'End If
            f.Relat(r)
            f.ShowDialog()
            f.Dispose()
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class