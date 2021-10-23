Imports mrotica_util
Public Class frmOsNaoConcluida
    Dim d As New dados
    Dim os As New ObjOS
    Dim tt As New DataTable
    Private Sub frmOsNaoConcluida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_todos()
        carrega_combo()
    End Sub
    Private Sub carrega_combo()
        Dim t As New DataTable
        Dim sql As String
        sql = "Select cod_cliente,nome_cliente from cliente order by cod_cliente"
        d.carrega_Tabela(sql, t)
        cbLoja.DataSource = t
        cbLoja.DisplayMember = "nome_cliente"
        cbLoja.ValueMember = "cod_cliente"
    End Sub
    Private Sub carrega_todos()
        tt = os.lista_os_nao_concluidas("")
        carrega_grd()
    End Sub
    Private Sub carrega_grd()
        Dim TStb As New DataGridTableStyle
        grdOS.DataSource = tt
        TStb.MappingName = tt.TableName
        Dim cFase As New DataGridTextBoxColumn
        With cFase
            .MappingName = "Fase"
            .HeaderText = "Fase"
            .Width = 200
        End With
        TStb.GridColumnStyles.Add(cFase)

        Dim cOSLocal As New DataGridTextBoxColumn
        With cOSLocal
            .MappingName = "os_local"
            .HeaderText = "OS Local"
        End With
        TStb.GridColumnStyles.Add(cOSLocal)

        Dim cCliente As New DataGridTextBoxColumn
        With cCliente
            .MappingName = "cod_cliente"
            .HeaderText = "Cliente"
        End With
        TStb.GridColumnStyles.Add(cCliente)

        Dim cOSCliente As New DataGridTextBoxColumn
        With cOSCliente
            .MappingName = "Doc_cliente"
            .HeaderText = "OS Cliente"
        End With
        TStb.GridColumnStyles.Add(cOSCliente)

        Dim cOD As New DataGridTextBoxColumn
        With cOD
            .MappingName = "OD"
            .HeaderText = "Olho Direito"
            .Width = 310
        End With
        TStb.GridColumnStyles.Add(cOD)

        Dim cOe As New DataGridTextBoxColumn
        With cOe
            .MappingName = "OE"
            .HeaderText = "Olho Esquerdo"
            .Width = 310
        End With
        TStb.GridColumnStyles.Add(cOe)

        Dim cTrat As New DataGridTextBoxColumn
        With cTrat
            .MappingName = "Tratamento"
            .HeaderText = "Tratamento"
            .Width = 90
        End With
        TStb.GridColumnStyles.Add(cTrat)

        Dim cVerificacao As New DataGridTextBoxColumn
        With cVerificacao
            .MappingName = "data_verificacao"
            .HeaderText = "Data Verificacao"
            .Width = 100
        End With
        TStb.GridColumnStyles.Add(cVerificacao)

        Dim cPrevisao As New DataGridTextBoxColumn
        With cPrevisao
            .MappingName = "data_previsao_entrega"
            .HeaderText = "Data Previsão Entrega"
            .Format = "dd/MM/yy"
        End With
        TStb.GridColumnStyles.Add(cPrevisao)

        Dim cPrimeiro As New DataGridTextBoxColumn
        With cPrimeiro
            .MappingName = "data_Primeiroandamento"
            .HeaderText = "Importado"
            .Width = 100
        End With
        TStb.GridColumnStyles.Add(cPrimeiro)

        Dim cUltimo As New DataGridTextBoxColumn
        With cUltimo
            .MappingName = "data_Ultimoandamento"
            .HeaderText = "Último andamento em"
            .Width = 100
        End With
        TStb.GridColumnStyles.Add(cUltimo)

        Dim cUltimoAnd As New DataGridTextBoxColumn
        With cUltimoAnd
            .MappingName = "ultimo_andamento"
            .HeaderText = "Último andamento"
            .Width = 200
        End With
        TStb.GridColumnStyles.Add(cUltimoAnd)

        txtMax.Text = "Total: " & tt.Rows.Count

        grdOS.TableStyles.Clear()
        grdOS.TableStyles.Add(TStb)
    End Sub

    Private Sub chkVerif_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVerif.CheckedChanged
        filtrar()
    End Sub
    Private Sub filtrar()
        Dim ftr As String
        Dim ft1, ft2, ft3 As String

        If chkVerif.Checked = True Then
            ft1 = " and (os.data_verificacao >= " & d.pdtm(dtVerifIni.Value.Date & " 00:00:00") & _
            " and os.data_verificacao <= " & d.pdtm(dtVerifFim.Value.Date & " 23:59:59") & ")"
        Else
            ft1 = ""
        End If
        If chkLoja.Checked = True Then
            ft2 = " and (os.cod_cliente = " & cbLoja.SelectedValue & ")"
        Else
            ft2 = ""
        End If

        If chkEntrega.Checked = True Then
            ft3 = " and (OS.data_previsao_entrega >= " & d.pdtm(dtEntregaIni.Value.Date & " 00:00:00") & _
            " and OS.data_previsao_entrega <= " & d.pdtm(dtEntregaFim.Value.Date & " 23:59:59") & ")"
        Else
            ft3 = ""
        End If

        ftr = ft1 & ft2 & ft3
        tt = os.lista_os_nao_concluidas(ftr)
        carrega_grd()
    End Sub

    Private Sub chkLoja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLoja.CheckedChanged
        filtrar()
    End Sub

    Private Sub chkEntrega_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEntrega.CheckedChanged
        filtrar()

    End Sub
End Class