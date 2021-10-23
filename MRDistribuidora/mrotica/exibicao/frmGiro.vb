Imports mrotica_util
Public Class frmGiro
    Dim d As New dados
    Dim p As New produtoClass
    Dim mov As New objMovimentoDetalhe
    Dim conf As New config
    Dim tb As New DataTable
    Dim tab As New objTabela
    Dim objGiro As New objMaster

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Dim f As New frmRpt
        Dim r As Object
        Dim prod As New produtoClass
        Dim es As String

        Try
            es = prod.ret_especie(txtTabela.Text)
            If es.ToUpper.Trim = "L" Then
                r = New rptGiroLentes
            Else
                r = New rptGiroblocos

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Me.Cursor = Cursors.AppStarting
        If cbFilial.Text = "Todos" Then
            tb = mov.Giro_produtos(txtTabela.Text, dtI.Value, dtF.Value)
            r.titulo = "Relatório de Giro do Produto " & txtTabela.Text & " " & tab.ret_nome_tabela(txtTabela.Text) & _
        " no periodo entre " & dtI.Value.Date & " e " & dtF.Value.Date
        Else
            tb = mov.Giro_produtos(txtTabela.Text, dtI.Value, dtF.Value, cbFilial.Text)
            r.titulo = "Relatório de Giro do Produto " & txtTabela.Text & " " & tab.ret_nome_tabela(txtTabela.Text) & _
        " no periodo entre " & dtI.Value.Date & " e " & dtF.Value.Date & " Filial " & cbFilial.Text
        End If

        Me.Cursor = Cursors.Default

        grdItens.DataSource = tb
        r.DataSource = tb
        f.Relat(r)
        f.Show()
    End Sub

    Private Sub frmGiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtI.Value = "01" & "/" & Month(Now) & "/" & Year(Now)
        dtF.Value = Now
        carrega_Filial()
        cbFilial.SelectedValue = conf.Filial
    End Sub

    Private Sub btnANA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnANA.Click
        Dim f As New frmRpt
        Dim r As Object
        Dim prod As New produtoClass
        Dim wsAna As New anamaria.Service
        Dim es As String
        Dim di, df, filial As String
        es = prod.ret_especie(txtTabela.Text)
        di = dtI.Value.Date.ToShortDateString & " 00:00:00"
        df = dtF.Value.Date.ToShortDateString & " 23:59:59"
        filial = InputBox("Filial")
        Try
            If es.ToUpper.Trim = "L" Then
                r = New rptGiroLentes
            Else
                r = New rptGiroblocos
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Me.Cursor = Cursors.AppStarting
        Try
            tb = wsAna.RGiro(txtTabela.Text, di, df, filial).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try
        Me.Cursor = Cursors.Default
        r.titulo = "Relatório de Giro do Produto " & txtTabela.Text & " " & tab.ret_nome_tabela(txtTabela.Text) & _
        " no periodo entre " & dtI.Value.Date & " e " & dtF.Value.Date & " em Ana Maria Loja " & adiciona_zeros(filial, 2)
        grdItens.DataSource = tb
        r.DataSource = tb
        f.Relat(r)
        f.Show()
    End Sub

    Private Sub carrega_Filial()
        Dim ttFilial As New DataTable
        Dim strSQL As String = "Select id_filial from almoxarifado"
        ttFilial = objGiro.retornaRegistro(strSQL).Tables(0)
        cbFilial.DisplayMember = "id_filial"
        cbFilial.ValueMember = "id_filial"
        cbFilial.DataSource = ttFilial
    End Sub

End Class