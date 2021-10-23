Imports mrotica_util
Imports System.Diagnostics
' NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in Web.config and in the associated .svc file.
Public Class Service1
    Implements IService1
    Dim d As New dados("winweb", "mrotica", "192.168.3.102", "mrotica")
    Dim tRecepcao As New DataTable
    Public Sub New()

    End Sub
    Private Sub cria_tb_impRec()
        'Cria a estrutura da tabela que será retornada contendo as chaves id_fila e id_filial
        'assim como o campo dt cujo timestamp representa a hora em que o registro fio inserido
        'na tabela fila_importacao
        tRecepcao.Columns.Add("id_fila")
        tRecepcao.Columns.Add("id_filial")
        tRecepcao.Columns.Add("dt")
    End Sub
    Public Function GetData(ByVal value As Integer) As String Implements IService1.GetData
        Return "Você digitou : " & CStr(value)
    End Function
    Public Function andamentos(ByVal filial As Integer, ByVal xos As Integer) As DataTable Implements IService1.andamentos
        Dim os As New ObjOS(xos, filial, "", d)
        Return os.andamentos_os
    End Function
    Public Function FilaRetorno(ByVal filial As Integer, ByVal nReg As Integer) As DataTable Implements IService1.FilaRetorno
        Dim Tsql As String
        Dim tt As New DataTable
        Tsql = "Select top(" & nReg & ") * from fila_exportacao where destino = " & filial & " and data_exportacao is null order by data_inclusao"
        d.carrega_Tabela(Tsql, tt)
        Return tt
    End Function

    Public Function os_in_trans(ByVal tOS As DataSet, ByVal dsTrat As DataSet) As String Implements IService1.os_in_trans
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
        tbTrat = dsTrat.Tables(0)
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
            End If
            ltab.filtra(rdNum(r("cod_tab_oe")))
            If ltab.max > 0 Then
                If ltab.id_fabricante = 15 Or ltab.id_fabricante = 35 Or ltab.id_fabricante = 10 Then
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
                pedido.novo()
                resp = pedido.novo_pedido_otica(os)
            End If
        Catch ex As Exception
            resp = resp & vbCrLf & ex.ToString
        End Try
        Return resp
    End Function

    Public Function FilaEnvio(ByVal tb As DataTable, ByVal filial As Integer, ByRef strLog As String) As DataTable Implements IService1.FilaEnvio
        Dim i, t As Integer
        Dim r As String
        tRecepcao = Nothing
        tRecepcao = New DataTable
        tRecepcao.TableName = "Importados"
        cria_tb_impRec()
        i = 0
        t = tb.Rows.Count
        strLog = "Transmissão" & tb.Rows.Count
        While i < t
            r = insere_recebido(tb.Rows(i))
            'strLog = strLog & vbCrLf & i & "-" & r
            If r.StartsWith("OK") Or r.Contains("PRIMARY KEY") Then
                Try
                    marca_transmitido_rec(tb.Rows(i)("id_fila"), filial, Now.ToString)
                    'm.Marca_transmitido(tt.Rows(i)("id_fila"), conf.Filial, Now)
                Catch ex As Exception
                    strLog = vbCrLf & ex.ToString
                End Try
            Else
                'myLog.WriteEntry(r)
            End If
            i = i + 1
        End While
        Processa()
        Return tRecepcao
    End Function
    Private Function insere_recebido(ByVal r As DataRow) As String
        Dim sql As String = ""
        Dim inst As DataRow
        Dim res As String = ""
        inst = r
        sql = "INSERT INTO Fila_importacao (id_fila" & _
                       ",origem,gerado,destino,instrucao,data_inclusao" & _
                       ") VALUES " & _
                       "(" & inst("id_fila") & _
                       "," & inst("origem") & _
                       "," & inst("gerado") & _
                       "," & inst("destino") & _
                       "," & d.PStr(d.inst_fila(inst("instrucao"))) & _
                       "," & d.pdtm(inst("data_inclusao")) & _
                       ")"
        res = d.Comando(sql, False)
        If res.StartsWith("OK") Then
            res = res & vbCrLf & fila(inst)
            Return res
        Else
            Return res
        End If
    End Function
    Private Sub marca_transmitido_rec(ByVal id_fila As Integer, ByVal id_filial As Integer, ByVal dt As Date)
        Dim r As DataRow
        r = tRecepcao.NewRow
        r("id_fila") = id_fila
        r("id_filial") = id_filial
        r("dt") = dt
        tRecepcao.Rows.Add(r)
    End Sub
    Public Function fila(ByVal r As DataRow) As String
        Dim tb As New DataTable
        Dim res As Integer = 0
        Dim sql As String = ""
        Dim i, m As Integer
        Try
            d.carrega_Tabela("Select id_filial from almoxarifado where id_filial <> 0 and id_filial <> 1 and id_filial <> " & r("origem") & "", tb)
            i = 0
            m = tb.Rows.Count
            While i < m
                sql = "INSERT INTO Fila_Exportacao (id_fila" & _
                ",origem,gerado,destino,instrucao,data_inclusao) VALUES " & _
                "(" & r("id_fila") & _
                "," & r("origem") & _
                "," & r("gerado") & _
                "," & tb.Rows(i)("id_filial") & _
                "," & d.PStr(d.inst_fila(r("instrucao"))) & _
                "," & d.pdtm(r("data_inclusao")) & _
                ")"
                d.Comando(sql, False)
                i = i + 1
            End While
        Catch ex As Exception
            Return "ER:" & ex.ToString
        End Try
        Return "OK:Fila Matriz"
    End Function
    Private Sub Processa()
        Dim tb As New DataTable
        Dim sql As String = ""
        Dim sInsert As String
        Dim i, m As Integer
        Dim res As String = ""
        Dim dia As Date
        Dim destino As Integer
        destino = 1
        dia = DateAdd(DateInterval.Month, -1, Now)
        ' sql = "delete top(500)  from fila_exportacao where data_exportacao is not null and data_exportacao <= " & d.Pdt(dia) & ""
        ' d.Comando(sql, False)
        ' sql = "delete top(500)  from fila_importacao where data_processamento is not null and data_processamento <= " & d.Pdt(dia) & ""
        ' d.Comando(sql, False)
        'sql = "Select * from fila_importacao where destino = 0 and " & _
        '"data_processamento IS NULL"
        'd.carrega_Tabela(sql, tb)
        sql = "Select top(100) * from fila_importacao where destino = " & destino & " and " & _
        "data_processamento IS NULL Order By data_inclusao"
        d.carrega_Tabela(sql, tb)
        i = 0
        m = tb.Rows.Count
        Try
            While i < m
                sInsert = tb.Rows(i)("instrucao")
                sInsert = Replace(sInsert, "`", "'")
                res = d.Comando(sInsert, False)
                If res.StartsWith("OK") Or res.ToUpper.Contains("PRIMARY KEY") Or res.ToUpper.Contains("CHAVE DUPLICADA") _
                Or res.ToUpper.Contains("CHAVE PRIMÁRIA") Then
                    sql = "Update fila_importacao set data_processamento = " & d.pdtm(d.hora) & _
                    " where id_fila = " & tb.Rows(i)("id_fila") & " and destino = " & destino & ""
                    d.Comando(sql, False)
                End If
                i = i + 1
            End While
        Catch ex As Exception

        End Try
    End Sub
    Public Function devolve_importados(ByVal tb As DataTable) As String Implements IService1.devolve_importados
        'Envia registro para fila de recepção da Matriz
        Dim res As String = ""
        Dim r As DataRow
        Dim i As Integer = 0
        While i < tb.Rows.Count
            r = tb.Rows(i)
            Marca_transmitido(r(0), r(1), r(2))
            i = i + 1
        End While
        res = tb.TableName & " " & tb.Rows.Count & " Processados: " & i
        Return res
    End Function
    Public Function Marca_transmitido(ByVal id_fila As Integer, ByVal filial As Integer, ByVal dt As Date) As String
        Dim sql As String = ""
        Dim res As String = ""
        sql = "update fila_exportacao set data_exportacao = " & d.pdtm(dt) & " where id_fila =" & _
        id_fila & " and destino = " & filial & ""

        Try
            res = d.Comando(sql, False)
            Return res
        Catch ex As Exception
            Return ex.Message & " Erro Importa!"
        End Try
    End Function

    Public Function SaidaExtra(ByVal id_Filial As Integer, ByVal os As Integer, ByVal OD As Boolean _
                               , ByVal OE As Boolean, ByVal motivo As String) As String Implements IService1.SaidaExtra
        Dim extra As New objSaidaExtra(d)
        Dim ordser As ObjOS
        Dim andamentos As New objAndamentos()
        'Inícialização
        Try
            ordser = New ObjOS(os, id_Filial, "", d)
            'Caso a OS não exista, fecha o form
            If ordser.max = 0 Then
                Return "ER: Esta OS não existe!"
                Exit Function
            End If
            'Procedimento 12 Solicitação de saída extra

            'Verifica se há uma saída extra em aberto para essa OS
            extra.filtra(ordser.cod_os, ordser.id_filial, "N")
            If extra.max > 0 Then
                Return "ER: Já há uma saída extra em aberto para essa OS. É necessário concluí-la" & _
                " para iniciar uma nova saída extra !"
                Exit Function
            Else
                With extra
                    .novo()
                    andamentos = New objAndamentos(ordser.cod_os, ordser.id_filial, d)
                End With
            End If
        Catch ex As Exception
            Return "ER: " & ex.Message
        End Try
        'Fim inicialização

        Dim r As String
        With extra
            .id_filial_movimento = 1
            .id_usuario = 4
            .data = d.hora
            .id_filial_os = ordser.id_filial
            .cod_os = ordser.cod_os
            .Desc_saida_extra = motivo
            .id_usuario_perda = 4
            .od = sn(OD)
            .oe = sn(OE)
            .troca_Produto_od = "N"
            .troca_Produto_oe = "N"
            r = .Salvar
            If r.StartsWith("OK") Then
                andamentos.cancela_andamentos_producao("Cancelado saída extra!")
                andamentos.insere_andamento(objAndamentos.tipo.solicitaccao_saida_extra, ordser.id_filial, _
                ordser.cod_os, 4, "Nº saída Extra: " & .cod_saida_extra & " " & motivo)
                Return "OK: Extra Nº " & .cod_saida_extra
            Else
                Return r
            End If
        End With
    End Function
    Private Function sn(ByVal ctl As Boolean) As String
        'Retorna variável de texto S ou N de acordo
        'com a opção marcada no checkbox.
        If ctl = True Then
            Return "S"
        Else
            Return "N"
        End If
    End Function
End Class
