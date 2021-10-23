Imports winotica_util
Partial Class resumolabB
    Inherits System.Web.UI.Page
    Dim d As New dados("winweb", "winotica", "dellservidor", "winotica")
    Dim tt As New Data.DataTable
    Dim tabela_final As New Data.DataTable
    Dim ttot As New Data.DataTable
    Dim total As Integer
    Protected Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim sql As String = ""
        Dim di, df As String

        Try
            di = txtInicio.Text & " 00:00:00"
            df = txtFim.Text & " 23:59:59"
            sql = "SELECT count(id_filial) as quantidade,dia_saida, datepart(weekday,dia_saida_en) dia_semana " & _
            "FROM  dbo.OS_sai_lab_periodo(" & d.pdtm(di) & ", " & d.pdtm(df) & " , 1 ) AS OS_sai_lab_periodo "
            If chkMontagem.Checked = True Then
                sql = sql + " where leitor > 0 "
            End If
            If chkSurfacagem.Checked = True Then
                sql = sql + " where lixa > 0 "
            End If
            sql = sql & " group by dia_saida,dia_saida_en " & _
            "order by dia_saida"
            d.carrega_Tabela(sql, tt)
            sql = "SELECT count(id_filial) as quantidade " & _
            "FROM  dbo.OS_sai_lab_periodo(" & d.pdtm(di) & ", " & d.pdtm(df) & " , 1 ) AS OS_sai_lab_periodo "
            If chkMontagem.Checked = True Then
                sql = sql + " where leitor > 0 "
            End If
            If chkSurfacagem.Checked = True Then
                sql = sql + " where lixa > 0 "
            End If
            d.carrega_Tabela(sql, ttot)
            total = ttot.Rows(0)(0)
            monta_tabela()
            carrega_dados()
            lblTotal.Text = total
            lblMedia.Text = Format((total / tt.Rows.Count), "#,##0.00")
            grdConcluidos.DataSource = tabela_final
            grdConcluidos.DataBind()
        Catch ex As Exception
            Response.Write(ex.ToString)
        End Try
    End Sub
    Private Sub monta_tabela()
        tabela_final.Columns.Add("quantidade")
        tabela_final.Columns.Add("dia_saida")
        tabela_final.Columns.Add("dia_semana")
        tabela_final.Columns.Add("porcentagem")
    End Sub
    Private Sub carrega_dados()
        Dim nr As Data.DataRow
        For Each r As Data.DataRow In tt.Rows
            nr = tabela_final.NewRow
            nr("quantidade") = r("quantidade")
            nr("dia_saida") = r("dia_saida")
            nr("dia_semana") = diaSemanaINTtoSTR(r("dia_semana"))
            nr("porcentagem") = Format((r("quantidade") / total), "#,##0.00%")
            tabela_final.Rows.Add(nr)
        Next
    End Sub
    Private Function diaSemanaINTtoSTR(ByVal dia As Integer) As String
        Try
            Select Case dia
                Case 1
                    Return "Domingo"
                Case 2
                    Return "Segunda"
                Case 3
                    Return "Terça"
                Case 4
                    Return "Quarta"
                Case 5
                    Return "Quinta"
                Case 6
                    Return "Sexta"
                Case 7
                    Return "Sábado"
                Case Else
                    Return Nothing
            End Select
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        txtInicio.Text = "01/" & Now.Month & "/" & Now.Year
        txtFim.Text = Now.Day & "/" & Now.Month & "/" & Now.Year
    End Sub

    Protected Sub chkMontagem_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMontagem.CheckedChanged
        If chkMontagem.Checked = True Then
            chkSurfacagem.Checked = False
        End If
    End Sub
End Class
