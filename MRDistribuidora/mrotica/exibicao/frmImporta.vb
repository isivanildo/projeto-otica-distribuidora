Imports mrotica_util

Public Class frmImporta
    Dim d As New dados
    Dim conf As New config
    Private Sub frmImporta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Function os_in_trans(ByVal tOS As DataSet)
        Dim tbTrat As New DataTable
        Dim tbOs As New DataTable
        Dim tt As New DataTable
        Dim Trans As New objSqlTrans
        Dim i, m As Integer
        Dim resp As String
        Dim r As DataRow
        Dim os As New ObjOS(d, 1, "")
        Dim anda As New objAndamentos(d)
        Dim es As String
        Dim esf, cil As Double
        Dim ltab As New objTabela(d)
        Dim ordem As Integer = 1
        Dim pedido As New objPedidoBalcao(d)
        tbTrat = tOS.Tables(1)
        tbOs = tOS.Tables(0)
        r = tbOs.Rows(0)
        os.filtra_os_cliente(r("id_filial"), r("cod_os"))
        If os.max = 0 Then
            ltab.filtra(rdNum(r("cod_tab_od")))
            If ltab.max > 0 Then
                If ltab.id_fabricante = 15 Or ltab.id_fabricante = 35 Or ltab.id_fabricante = 10 Then
                    Return "Produto processado pela matriz"
                    Exit Function
                   
                End If
                If ltab.id_fabricante = 40 And os.tem_tratamento = True Then
                    Return "Produto processado pela matriz"
                    Exit Function
                End If
            End If
            ltab.filtra(rdNum(r("cod_tab_oe")))
            If ltab.max > 0 Then
                If ltab.id_fabricante = 15 Or ltab.id_fabricante = 35 Or ltab.id_fabricante = 10 Then
                    Return "Produto processado pela matriz"
                    Exit Function
                End If
                If ltab.id_fabricante = 40 And os.tem_tratamento = True Then
                    Return "Produto processado pela matriz"
                    Exit Function
                End If
            End If
            os.novo()
        Else
            If os.andamentos_os.Rows.Count = 0 Then
                Dim sql As String
                Dim rs As String
                sql = "Delete from tratamentos_os where cod_os = " & _
                os.cod_os & " and id_filial = " & os.id_filial & ""
                d.Comando(sql, True)
                sql = "Delete from os where cod_os = " & os.cod_os & _
                " and id_filial = " & os.id_filial & ""
                rs = d.Comando(sql, True)
                If rs.StartsWith("OK") Then
                    os.novo()
                    GoTo Insere_os
                Else
                    Return rs
                    Exit Function
                End If
            End If
            Return "OS já existe!"
            Exit Function
        End If
Insere_os:
        Try
            os.id_filial = 1
            os.cod_tab_od = rdNum(r("cod_tab_od"))
            os.cod_tab_oe = rdNum(r("cod_tab_oe"))
            os.cod_produto_od = rdNum(r("cod_produto_od"))
            os.cod_produto_oe = rdNum(r("cod_produto_oe"))

            os.esf_od_longe = rdNum(r("esf_od_longe"))
            os.cil_od_longe = rdNum(r("cil_od_longe"))
            os.esf_od_perto = rdNum(r("esf_od_perto"))
            os.cil_od_perto = rdNum(r("cil_od_perto"))
            os.dnp_od_longe = rdNum(r("dnp_od_longe"))
            os.dnp_od_perto = rdNum(r("dnp_od_perto"))
            os.base_od = rdNum(r("base_od"))
            os.adicao_od = rdNum(r("adicao_od"))
            os.altura_od = rdNum(r("altura_od"))
            os.diametro_od = rdNum(r("diametro_od"))
            os.eixo_od = rdNum(r("eixo_od"))

            os.esf_oe_longe = rdNum(r("esf_oe_longe"))
            os.cil_oe_longe = rdNum(r("cil_oe_longe"))
            os.esf_oe_perto = rdNum(r("esf_oe_perto"))
            os.cil_oe_perto = rdNum(r("cil_oe_perto"))
            os.dnp_oe_longe = rdNum(r("dnp_oe_longe"))
            os.dnp_oe_perto = rdNum(r("dnp_oe_perto"))
            os.base_oe = rdNum(r("base_oe"))
            os.adicao_oe = rdNum(r("adicao_oe"))
            os.altura_oe = rdNum(r("altura_oe"))
            os.diametro_oe = rdNum(r("diametro_oe"))
            os.eixo_oe = rdNum(r("eixo_oe"))

            os.aro_horizontal = rdNum(r("aro_horizontal"))
            os.aro_vertical = rdNum(r("aro_vertical"))
            os.maior_diametro = rdNum(r("maior_diametro"))
            os.ponte = rdNum(r("ponte"))
            os.cod_tipo_armacao = rdNum(r("cod_tipo_armacao"))
            os.crm_oftalmologista = rdNum(r("crm_oftalmologista"))

            os.cod_filial_cliente = 1
            os.doc_cliente = rdNum(r("cod_os"))
            os.cod_cliente = rdNum(r("id_filial"))
            os.data_venda = rdData(r("data_venda"))
            os.data_previsao_entrega = rdData(r("data_previsao_entrega"))
            os.hora_previsao_entrega = rdTexto(r("hora_previsao_entrega"))
            os.cod_vendedora = 2
            os.observacao = rdTexto(r("observacao"))
            os.nota_serie = rdTexto(r("nota_serie"))
            os.cod_verif_por = 2
            os.data_verificacao = rdData(r("data_verificacao"))
            os.cod_surfacagem = rdNum(r("cod_surfacagem"))
            os.cod_montagem = rdNum(r("cod_montagem"))
            os.confeccao = rdTexto(r("confeccao"))
            os.coloracao = rdNum(r("coloracao"))
            os.cor_coloracao = rdTexto(r("cor_coloracao"))
            os.cod_fase = Fases_os.Transmissao
            os.tipo_receita_OD = rdNum(r("tipo_receita_od"))
            os.tipo_receita_OE = rdNum(r("tipo_receita_oe"))
            os.id_laboratorio = rdNum(r("id_laboratorio")) 'Laboratorio Montagem
            os.cod_lab_surf = rdNum(r("cod_lab_surf"))

            If os.cod_tab_od <> 11060 Then
                es = ltab.ret_especie(os.cod_tab_od)
                If es.Trim = "B" Then
                    If os.cod_produto_od <> os.Ret_estoque_bloco(os.cod_tab_od, os.base_od, os.adicao_od, "D") Then
                        os.cod_produto_od = os.Ret_estoque_bloco(os.cod_tab_od, os.base_od, os.adicao_od, "D")
                    End If
                Else
                    If os.tipo_receita_OD = tipo_Receita.VISAO_simples_longe Then
                        esf = os.esf_od_longe
                        cil = os.cil_od_longe
                    Else
                        esf = os.esf_od_perto
                        cil = os.cil_od_perto
                    End If
                    If os.cod_produto_od <> os.Ret_estoque_lente(os.cod_tab_od, esf, cil) Then
                        os.cod_produto_od = os.Ret_estoque_lente(os.cod_tab_od, esf, cil)
                    End If
                End If

            End If
            If os.cod_tab_oe <> 11060 Then
                es = ltab.ret_especie(os.cod_tab_oe)
                If es.Trim = "B" Then
                    If os.cod_produto_oe <> os.Ret_estoque_bloco(os.cod_tab_oe, os.base_oe, os.adicao_oe, "E") Then
                        os.cod_produto_oe = os.Ret_estoque_bloco(os.cod_tab_oe, os.base_oe, os.adicao_oe, "E")
                    End If
                Else
                    If os.tipo_receita_OE = tipo_Receita.VISAO_simples_longe Then
                        esf = os.esf_oe_longe
                        cil = os.cil_oe_longe
                    Else
                        esf = os.esf_oe_perto
                        cil = os.cil_oe_perto
                    End If
                    If os.cod_produto_oe <> os.Ret_estoque_lente(os.cod_tab_oe, esf, cil) Then
                        os.cod_produto_oe = os.Ret_estoque_lente(os.cod_tab_oe, esf, cil)
                    End If
                End If
            End If
            os.cod_fase = Fases_os.Verificacao

            Trans.insere_instrucao(os.Salvar_transaction)
        Catch ex As Exception
            Return "Erro mroticaservice" & vbCrLf & ex.ToString
            Exit Function
        End Try
        Try
            anda = New objAndamentos(os.cod_os, os.id_filial, d)
            'Caso a os tenha sido inserida, coloca andamentos de inclusao e verificacao
            Trans.insere_instrucao(anda.insere_andamento_trans(objAndamentos.tipo.inclusao_os, os.id_filial, os.cod_os, _
            2, "Os em processo de importação com SQLTransaction", ordem))
            ordem = ordem + 1
            Trans.insere_instrucao(anda.insere_andamento_trans(objAndamentos.tipo.verificacao_os, os.id_filial, _
            os.cod_os, 2, "Os em processo de importação com SQLTransaction", ordem))
            ordem = ordem + 1
            'Importa os Tratamentos, caso haja algum
            i = 0
            m = tbTrat.Rows.Count

            While i < m
                tt = os.insere_tratamento_trans(tbTrat.Rows(i)("cod_produto"), 3, ordem)
                ordem = ordem + 1
                If tt.Rows.Count > 0 Then
                    For Each rt As DataRow In tt.Rows
                        Trans.insere_instrucao(rt(0).ToString)
                    Next
                End If
                i = i + 1
            End While
        Catch ex As Exception
            Return ex.ToString & vbCrLf & tt.Rows(0)(0).ToString
            Exit Function
        End Try
        'resp = "ER:" & tt.Rows.Count & vbCrLf & tt.Rows(1)(0).ToString
        resp = d.executa_transaction(Trans.instrucoes, True)
        Try
            If resp.StartsWith("OK") Then
                Dim aut As New objAutorizacao(os.cod_cliente, os.cod_filial_cliente, d)
                pedido.novo()
                pedido.autorizacao = aut
                resp = pedido.novo_pedido_otica(os)
            End If
        Catch ex As Exception
            resp = resp & vbCrLf & ex.ToString
        End Try
        Return resp
    End Function

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim wsOtica As New anamaria.Service
        Dim dsOS As New DataSet
        Dim ds As New DataSet
        Dim dsTrat As New DataSet
        Dim dsLista As New DataSet
        Dim filial, os As Integer
        Dim dt As String
        Dim tt As New DataTable
        Dim dias As Integer = 7
        Try
            dias = InputBox("Quantos dias?", "", "7")
            txtStatus.Text = wsOtica.OS_Semana(dias, dsLista)
            If txtStatus.Text.StartsWith("OK") Then
                tt = dsLista.Tables(0)
                txtStatus.Text = "Importando " & tt.Rows.Count & " OSs"
                For Each r As DataRow In tt.Rows
                    txtStatus.Text = "Importando os " & filial & "-" & os & vbCrLf & txtStatus.Text
                    Application.DoEvents()
                    filial = r("id_filial")
                    os = r("cod_os")
                    ds = wsOtica.os_Out_labo(os, filial)
                    If ds.Tables.Count = 0 Or ds.Tables(0).Rows.Count = 0 Then
                        txtStatus.Text = "OS não existe no servidor principal!" & filial & "-" & os & vbCrLf & txtStatus.Text
                        Exit Sub
                    End If
                    dt = ds.Tables(0).Rows(0)("data_verificacao")
                    If IsDate(dt) = False Then
                        txtStatus.Text = "OS não verificada!" & filial & "-" & os & vbCrLf & txtStatus.Text
                        Exit Sub
                    End If
                    txtStatus.Text = os_in_trans(ds) & filial & "-" & os & vbCrLf & txtStatus.Text
                    If txtStatus.TextLength > 20000 Then
                        txtStatus.Text = ""
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        txtStatus.Text = "########################CONCLUÍDO########################" & vbCrLf & txtStatus.Text
    End Sub

    Private Sub btnLimpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpa.Click
        Dim tsql As String
        Dim tt As New DataTable
        Dim os As New ObjOS(d, 1, "")
        Dim ltab As New objTabela(d)
        tsql = "select * from OS where cod_cliente < 100 and data_venda >= '20140101 00:00:00'"
        d.carrega_Tabela(tsql, tt)
        txtStatus.Text = "Processando " & tt.Rows.Count & " OSs"
        For Each r As DataRow In tt.Rows
            os.filtra_os_cliente(r("cod_cliente"), r("doc_cliente"))
            If os.max > 0 And os.cod_fase <> Fases_os.Pausa_estoque Then
                ltab.filtra(rdNum(r("cod_tab_od")))
                If ltab.max > 0 Then
                    If ltab.id_fabricante = 15 Or ltab.id_fabricante = 35 Or ltab.id_fabricante = 10 Then
                        pausa_os(os)
                        GoTo final
                    End If
                    If ltab.id_fabricante = 40 And os.tem_tratamento = True Then
                        pausa_os(os)
                        GoTo final
                    End If
                End If
                ltab.filtra(rdNum(r("cod_tab_oe")))
                If ltab.max > 0 Then
                    If ltab.id_fabricante = 15 Or ltab.id_fabricante = 35 Or ltab.id_fabricante = 10 Then
                        pausa_os(os)
                        GoTo final
                    End If
                    If ltab.id_fabricante = 40 And os.tem_tratamento = True Then
                        pausa_os(os)
                        GoTo final
                    End If
                End If
            End If
final:
            Application.DoEvents()
        Next
    End Sub
    Public Sub pausa_os(ByRef os As ObjOS)
        Dim anda As New objAndamentos(d)
        anda.insere_andamento(objAndamentos.tipo.Pausa_os_estoque, os.id_filial, os.cod_os, 1, "OS Sai pela Ótica!")
        os.editar()
        os.cod_fase = Fases_os.Pausa_estoque
        txtStatus.Text = "OS " & os.cod_cliente & "-" & os.doc_cliente & " " & os.Salvar() & vbCrLf & txtStatus.Text
    End Sub

End Class
