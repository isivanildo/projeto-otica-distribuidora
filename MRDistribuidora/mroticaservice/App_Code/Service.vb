Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports mrotica_util
Imports System.Data
Imports System.Data.SqlClient
<WebService(Namespace:="http://www.labonorte.com.br/mroticaservicelabo/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
    Inherits System.Web.Services.WebService
    Dim d As New dados("mrotica", "mrotica", "192.168.3.120", "labonorte")
    Dim m As New objMaster
    'Dim conf As New config(Server.MapPath("bin/"))
    Public loja_logada As Integer
    Dim andamentos As objAndamentos
    <WebMethod()> _
    Public Function Saldo_produto(ByVal x_cod_produto As Integer, ByVal x_id_filial As Integer) As Integer
        Dim p As New produtoClass(d)
        Return p.saldo_estoque_local(x_cod_produto, x_id_filial)
    End Function
    <WebMethod()> _
    Public Function logar(ByVal loja As Integer, ByVal cred As String) As Integer
        Dim sql As String
        Dim tt As New Data.DataTable
        sql = "Select cod_cliente,chave_seguranca from cliente where cod_cliente = " & _
        loja & ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            If tt.Rows(0)("chave_seguranca").ToString.Trim = cred Then
                Return tt.Rows(0)("cod_cliente")
            Else
                Return 0
            End If
        Else
            Return False
        End If
    End Function
    <WebMethod()> _
    Public Function trans_filial_matriz(ByVal tbinst As DataTable, ByVal origem As Integer) As Boolean
        Dim sql As String
        Dim r As String
        Dim instrucao As DataRow
        instrucao = tbinst.Rows(0)
        With instrucao
            sql = "INSERT INTO Fila_importacao (id_fila" & _
           ",origem,gerado,destino,instrucao,data_inclusao" & _
           ",data_processamento) VALUES " & _
           "(" & ("id_fila") & _
           "," & ("origem") & _
           "," & ("gerado") & _
           "," & ("destino") & _
           "," & d.PStr(d.inst_fila(("instrucao"))) & _
           "," & d.pdtm(("data_inclusao")) & _
           "," & d.pdtm(("data_processamento")) & ")"
            r = d.Comando(sql, False)
            If r.StartsWith("OK") Then
                fila(instrucao)
                Return True
            Else
                Return False
            End If

        End With

    End Function
    Public Function fila(ByVal r As DataRow) As Boolean
        Dim tb As New DataTable
        Dim res As Integer = 0
        Dim sql As String
        Dim i, m As Integer
        Try
            d.carrega_Tabela("Select id_filial from almoxarifado where id_filial <> 0 and id_filial <> 1", tb)
            i = 0
            m = tb.Rows.Count
            While i < m
                sql = "INSERT INTO Fila_Exportacao (id_fila" & _
                ",origem,gerado,destino,instrucao,data_inclusao) VALUES " & _
                "(" & ("id_fila") & _
                "," & ("origem") & _
                "," & ("gerado") & _
                "," & tb.Rows(i)("id_filial") & _
                "," & d.PStr(d.inst_fila("instrucao")) & _
                "," & d.pdtm(("data_inclusao")) & _
                ")"
                i = i + 1
            End While
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    <WebMethod()> _
    Public Function andamentos_OS(ByVal x_id_filial As Integer, ByVal x_os As Integer) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Try
            sql = "SELECT andamentos.data, tipo_andamento.andamento, Usuarios.NOME, andamentos.Observacao " & _
                    "FROM andamentos INNER JOIN OS ON andamentos.id_filial = OS.id_filial AND andamentos.cod_os = OS.cod_os INNER JOIN " & _
                    "Usuarios ON andamentos.cod_usuario = Usuarios.cod_usuario INNER JOIN " & _
                    "tipo_andamento ON andamentos.cod_andamento = tipo_andamento.cod_andamento " & _
                    "WHERE (OS.cod_cliente = " & x_id_filial & " ) AND (OS.doc_cliente = " & x_os & ")"
            d.carrega_ds(sql, ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function
#Region "Produtos"
    <WebMethod()> _
    Public Function fila_produtos() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        sql = "Select top 5000 * from fila_exportacao_produtos where data_processamento is null "
        d.carrega_ds(sql, ds)
        Return ds
    End Function
    <WebMethod()> _
    Public Function fila_produtos_ok(ByVal id_fila) As String
        Dim sql As String
        Dim res As String
        sql = "update fila_exportacao_produtos set data_processamento =  " & d.pdtm(d.hora) & _
        " where id_fila = " & id_fila & ""
        res = d.Comando(sql, False)
        Return res
    End Function
    <WebMethod()> _
    Public Function Importa_produto(ByVal x_cod_tabela As Long, ByVal tipo As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim t1, t2, t3 As New DataTable
        Dim ftr As String
        Dim i, m As Integer
        i = 0
        sql = "Select * from lentes_tabela where cod_tabela = " & x_cod_tabela & ""
        d.carrega_Tabela(sql, t1)
        t1.TableName = "lentes_tabela"
        ds.Tables.Add(t1.Copy)
        sql = "Select * from lentes_blocos where cod_tabela = " & x_cod_tabela & ""
        d.carrega_Tabela(sql, t2)
        t2.TableName = "Lente_blocos"
        ds.Tables.Add(t2.Copy)
        If tipo = "B" Then
            i = 0
            m = t2.Rows.Count
            sql = "SELECT produtos.*, blocos.*  FROM produtos INNER JOIN " & _
            " blocos ON produtos.cod_produto = blocos.Cod_produto "
            While i < m
                If i = 0 Then
                    ftr = " where produtos.cod_lente = " & t2.Rows(i)("cod_lente")
                Else
                    ftr = ftr & " or produtos.cod_lente = " & t2.Rows(i)("cod_lente")
                End If
                i = i + 1
            End While
            sql = sql & ftr
            d.carrega_Tabela(sql, t3)
            t3.TableName = "Produtos"
            ds.Tables.Add(t3.Copy)
        Else
            m = t2.Rows.Count
            sql = "SELECT produtos.*, lentes.* FROM produtos INNER JOIN " & _
                 "lentes ON produtos.cod_produto = lentes.cod_produto "
            i = 0
            While i < m
                If i = 0 Then
                    ftr = " where produtos.cod_lente = " & t2.Rows(i)("cod_lente")
                Else
                    ftr = ftr & " or produtos.cod_lente = " & t2.Rows(i)("cod_lente")
                End If
                i = i + 1
            End While
            sql = sql & ftr
            d.carrega_Tabela(sql, t3)
            t3.TableName = "Produtos"
            ds.Tables.Add(t3.Copy)
        End If
        Return ds
    End Function
#End Region
    <WebMethod()> _
    Public Function fila_trigger() As DataSet
        Dim sql As String
        Dim ds As New DataSet
        sql = "Select top 1000 * from fila_estoque_anaMaria where data_processamento IS NULL"
        d.carrega_ds(sql, ds)
        Return ds
    End Function
    <WebMethod()> _
    Public Function marca_trigger_ok(ByVal id_fila As Integer)
        Dim sql As String
        sql = "update fila_estoque_anaMaria set data_processamento = " & d.pdtm(d.hora) & _
        " where id_fila = " & id_fila & ""
        d.Comando(sql, False)
    End Function
#Region "Importação OS"
    <WebMethod()> _
    Public Function os_in(ByVal tOS As DataSet, ByVal dsTrat As DataSet) As String
        Dim tbTrat As New DataTable
        Dim tbOs As New DataTable
        Dim i, m As Integer
        Dim resp As String
        Dim r As DataRow
        Dim os As New ObjOS(d, 1, "")
        Dim anda As New objAndamentos(d)

        tbTrat = dsTrat.Tables(0)
        tbOs = tOS.Tables(0)
        r = tbOs.Rows(0)
        os.filtra_os_cliente(r("id_filial"), r("cod_os"))
        If os.max = 0 Then
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
            resp = os.Salvar()
        Catch ex As Exception
            Return ex.ToString
            Exit Function
        End Try
        Try
            If resp.StartsWith("OK") Then
                andamentos = New objAndamentos(os.cod_os, os.id_filial, d)
                'Caso a os tenha sido inserida, coloca andamentos de inclusao e verificacao
                andamentos.insere_andamento(objAndamentos.tipo.inclusao_os, os.id_filial, os.cod_os, _
                2, "Os em processo de importação")
                andamentos.insere_andamento(objAndamentos.tipo.verificacao_os, os.id_filial, _
                os.cod_os, 2, "Os em processo de importação")
                'Importa os Tratamentos, caso haja algum
                resp = resp & " Importado Labonorte!"
                i = 0
                m = tbTrat.Rows.Count
                While i < m
                    os.insere_tratamento(tbTrat.Rows(i)("cod_produto"), 3)
                    i = i + 1
                End While

                Dim es As String
                Dim esf, cil As Double
                Dim ltab As New objTabela(d)
                If os.cod_tab_od <> 11060 Then
                    es = ltab.ret_especie(os.cod_tab_od)
                    If es.Trim = "B" Then
                        If os.cod_produto_od <> os.Ret_estoque_bloco(os.cod_tab_od, os.base_od, os.adicao_od, "D") Then
                            os.editar()
                            os.cod_produto_od = os.Ret_estoque_bloco(os.cod_tab_od, os.base_od, os.adicao_od, "D")
                            os.Salvar()
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
                            os.editar()
                            os.cod_produto_od = os.Ret_estoque_lente(os.cod_tab_od, esf, cil)
                            os.Salvar()
                        End If
                    End If
                End If
                If os.cod_tab_oe <> 11060 Then
                    es = ltab.ret_especie(os.cod_tab_oe)
                    If es.Trim = "B" Then
                        If os.cod_produto_oe <> os.Ret_estoque_bloco(os.cod_tab_oe, os.base_oe, os.adicao_oe, "E") Then
                            os.editar()
                            os.cod_produto_oe = os.Ret_estoque_bloco(os.cod_tab_oe, os.base_oe, os.adicao_oe, "E")
                            os.Salvar()
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
                            os.editar()
                            os.cod_produto_oe = os.Ret_estoque_lente(os.cod_tab_oe, esf, cil)
                            os.Salvar()
                        End If
                    End If
                End If
                os.editar()
                os.cod_fase = Fases_os.Verificacao
                os.Salvar()
                'novo_pedido(os)
            End If
        Catch ex As Exception
            Return ex.ToString
            Exit Function
        End Try
        Return resp
    End Function
    <WebMethod()> _
    Public Function os_in_trans(ByVal tOS As DataSet, ByVal dsTrat As DataSet) As String
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
        'Dim pedido As New objPedidoBalcao(d)
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
            andamentos = New objAndamentos(os.cod_os, os.id_filial, d)
            'Caso a os tenha sido inserida, coloca andamentos de inclusao e verificacao
            Trans.insere_instrucao(andamentos.insere_andamento_trans(objAndamentos.tipo.inclusao_os, os.id_filial, os.cod_os, _
            2, "Os em processo de importação com SQLTransaction", ordem))
            ordem = ordem + 1
            Trans.insere_instrucao(andamentos.insere_andamento_trans(objAndamentos.tipo.verificacao_os, os.id_filial, _
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
        'Try
        'If resp.StartsWith("OK") Then
        'Dim aut As New objAutorizacao(os.cod_cliente, os.cod_filial_cliente, d)
        'pedido.novo()
        'pedido.autorizacao = aut
        'resp = pedido.novo_pedido_otica(os)
        'End If
        'Catch ex As SoapException
        'resp = resp & vbCrLf & ex.ToString
        'End Try
        Return resp
    End Function
    Private Function novo_pedido(ByVal os As ObjOS) As String
        Dim resp As String = ""
        If os.num_pedido = 0 Then
            Dim pedido As New objPedidoBalcao
            pedido.novo()
            pedido.num_pedido = d.retorna_Chave("num_pedido", "pedido_balcao") + 1
            pedido.id_filial = 1
            pedido.cod_cliente = os.cod_cliente
            pedido.cod_filial_cliente = os.cod_filial_cliente
            pedido.cod_vendedor = 2
            pedido.data_pedido = Now
            pedido.Salvar()
            resp = inserir_produtos(pedido, pedido.num_pedido, pedido.id_filial, os)
        End If
        Return resp
    End Function
    Private Function inserir_produtos(ByVal xPedido As objPedidoBalcao, ByVal x_num_pedido As Integer, ByVal x_id_filial As Integer, ByVal os As ObjOS) As String
        Dim p As New produtoClass
        Dim i, m As Integer
        Dim status_item As Integer = 1
        Dim fase_os As Fases_os
        Dim andamentos As New objAndamentos(os.cod_os, os.id_filial)
        Dim tbTratamentos As New DataTable
        Dim resp As String
        'Processando olho direito
        p.Source("Select * from produtos where cod_produto = " & os.cod_produto_od & "")
        'Avalia se há estoque na Loja para Atender ao pedido
        xPedido.insere_item(x_num_pedido, x_id_filial, os.cod_produto_od, 1, p.Desconto_compra, _
                            ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) + _
                           (p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) * 0.15), status_item)
        'Processando olho esquerdo
        status_item = Nothing
        p.Source("Select * from produtos where cod_produto = " & os.cod_produto_oe & "")

        os.editar()
        os.cod_fase = fase_os
        os.Salvar()
        xPedido.insere_item(x_num_pedido, x_id_filial, os.cod_produto_od, 1, p.Desconto_compra, _
                           ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) + _
                          (p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))) * 0.15), status_item)
        'Processando Serviços
        If os.cod_surfacagem <> 0 Then
            p.Source("Select * from produtos where cod_produto = " & os.cod_surfacagem & "")
            xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, os.quant_lentes, p.fldDesconto, p.fldPreco_venda, 1, os.cod_surfacagem, Nothing, p.fldPreco_venda)
        End If
        If os.cod_montagem <> 0 Then
            p.Source("Select * from produtos where cod_produto = " & os.cod_montagem & "")
            xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, os.quant_lentes, p.fldDesconto, p.fldPreco_venda, 1, os.cod_montagem, Nothing, p.fldPreco_venda)
        End If
        If os.coloracao <> 0 Then
            p.Source("Select * from produtos where cod_produto = " & os.coloracao & "")
            xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, os.quant_lentes, p.fldDesconto, p.fldPreco_venda, 1, os.coloracao, Nothing, p.Preco_venda)
        End If
        tbTratamentos = os.lista_tratamentos
        m = tbTratamentos.Rows.Count
        While i < m
            p.Source("Select * from produtos where cod_produto = " & tbTratamentos.Rows(i)("cod_produto") & "")
            xPedido.insere_servico(x_num_pedido, x_id_filial, p.fldCod_produto, os.quant_lentes, p.fldDesconto, p.fldPreco_venda, 1, xPedido, Nothing, p.fldPreco_venda)
            i = i + 1
        End While
        resp = "OK:Pedido gerado"
        Return resp
    End Function
#End Region
#Region "pedidos"
    <WebMethod()> _
    Public Function Pedido_balcao(ByVal num_pedido As Integer) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        sql = "SELECT item, cod_produto, quant " & _
        "FROM pedido_balcao_itens WHERE (num_pedido = " & _
        num_pedido & ")"
        d.carrega_ds(sql, ds)
        Return ds
    End Function
#End Region
    <WebMethod()> _
    Public Function SaidaExtra(ByVal id_Filial As Integer, ByVal os As Integer, ByVal OD As Boolean _
                               , ByVal OE As Boolean, ByVal motivo As String) As String
        Dim extra As New objSaidaExtra(d)
        Dim ordser As ObjOS
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
    <WebMethod()> _
    Public Function extras(ByVal di As String, ByVal df As String) As DataSet
        Dim sql As String
        Dim dsret As New DataSet
        sql = "SELECT  OS.cod_cliente, OS.doc_cliente,  saida_extra.Desc_saida_extra, saida_extra.od," & _
        "saida_extra.oe,  movimentomaster.data," & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = os.cod_tab_od)) AS POD," & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_oe)) AS POE, " & _
        "os.cod_Tab_od,os.cod_Tab_oe " & _
        "FROM         saida_extra INNER JOIN " & _
        "OS ON saida_extra.id_filial = OS.id_filial AND saida_extra.cod_os = OS.cod_os INNER JOIN " & _
        " movimentomaster ON saida_extra.cod_movimento = movimentomaster.cod_movimento AND " & _
        "saida_extra.id_filial_movimento = movimentomaster.id_filial " & _
        "where (OS.cod_cliente < 999) " & _
        "and movimentomaster.data >= " & d.pdtm(di) & _
        "and movimentomaster.data <= " & d.pdtm(df) & _
        " order by data,cod_cliente,doc_cliente"
        d.carrega_ds(sql, dsret)
        Return dsret
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

    <WebMethod()> _
    Public Function importaOS(ByVal codosini As Integer, ByVal codosfim As Integer, ByVal idfilial As Integer) As DataTable
        Dim tbImportaOS As New DataTable
        'Instrução responsável por recuperaros dados da OS informado
        Dim strSQL As String = "select  id_filial, cod_os, num_pedido, cod_tab_od, cod_tab_oe, cod_produto_od, cod_produto_oe, esf_od_longe," & _
            "cil_od_longe, esf_od_perto, cil_od_perto, dnp_od_longe, dnp_od_perto, base_od, adicao_od, altura_od, diametro_od, eixo_od," & _
            "esf_oe_longe, cil_oe_longe, esf_oe_perto, cil_oe_perto, dnp_oe_longe, dnp_oe_perto, base_oe, adicao_oe, altura_oe, diametro_oe," & _
            "eixo_oe, aro_horizontal, aro_vertical, maior_diametro, ponte, cod_Tipo_Armacao, crm_oftalmologista, cod_filial_cliente," & _
            "doc_cliente, cod_cliente, data_venda, data_previsao_entrega, hora_previsao_entrega, cod_vendedora, cod_qfez, observacao," & _
            "nota_serie, cod_verif_por, data_verificacao, cod_surfacagem, cod_montagem, confeccao, coloracao, cor_coloracao, data_recebimento," & _
            "data_fim_servico, cod_fase, tipo_receita_OD, tipo_receita_OE, id_laboratorio, cod_lab_surf, listado, forma, cod_tipo_os " & _
            "from os where cod_os >= " & codosini & " and cod_os <= " & codosfim & " and id_filial = " & idfilial & ""
        'carregaa os dados da OS na tabela
        d.carrega_Tabela(strSQL, tbImportaOS)
        Return tbImportaOS
    End Function

    <WebMethod()> _
    Public Function importaOSFiliaisLabonorteData(ByVal di As DateTime, ByVal df As DateTime) As DataSet
        'Instrução responsável por recuperaros dados da OS informado
        Dim strSQL As String = "select  id_filial, cod_os, num_pedido, cod_tab_od, cod_tab_oe, cod_produto_od, cod_produto_oe, esf_od_longe," & _
            "cil_od_longe, esf_od_perto, cil_od_perto, dnp_od_longe, dnp_od_perto, base_od, adicao_od, altura_od, diametro_od, eixo_od," & _
            "esf_oe_longe, cil_oe_longe, esf_oe_perto, cil_oe_perto, dnp_oe_longe, dnp_oe_perto, base_oe, adicao_oe, altura_oe, diametro_oe," & _
            "eixo_oe, aro_horizontal, aro_vertical, maior_diametro, ponte, cod_Tipo_Armacao, crm_oftalmologista, cod_filial_cliente," & _
            "doc_cliente, cod_cliente, data_venda, data_previsao_entrega, hora_previsao_entrega, cod_vendedora, cod_qfez, observacao," & _
            "nota_serie, cod_verif_por, data_verificacao, cod_surfacagem, cod_montagem, confeccao, coloracao, cor_coloracao, data_recebimento," & _
            "data_fim_servico, cod_fase, tipo_receita_OD, tipo_receita_OE, id_laboratorio, cod_lab_surf, listado, forma, cod_tipo_os " & _
            "from os where data_verificacao >= " & d.pdtm(di) & " and data_verificacao <= " & d.pdtm(df) & ""
        d.conecta()
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "OS")
        d.desconecta()
        Return ds
    End Function

    <WebMethod()> _
    Public Function importaOSFiliaisLabonortePedido(ByVal numPedido As Integer, ByVal idFilial As Integer) As DataSet
        'Instrução responsável por recuperaros dados da OS informado
        Dim strSQL As String = "select  id_filial, cod_os, num_pedido, cod_tab_od, cod_tab_oe, cod_produto_od, cod_produto_oe, esf_od_longe," & _
            "cil_od_longe, esf_od_perto, cil_od_perto, dnp_od_longe, dnp_od_perto, base_od, adicao_od, altura_od, diametro_od, eixo_od," & _
            "esf_oe_longe, cil_oe_longe, esf_oe_perto, cil_oe_perto, dnp_oe_longe, dnp_oe_perto, base_oe, adicao_oe, altura_oe, diametro_oe," & _
            "eixo_oe, aro_horizontal, aro_vertical, maior_diametro, ponte, cod_Tipo_Armacao, crm_oftalmologista, cod_filial_cliente," & _
            "doc_cliente, cod_cliente, data_venda, data_previsao_entrega, hora_previsao_entrega, cod_vendedora, cod_qfez, observacao," & _
            "nota_serie, cod_verif_por, data_verificacao, cod_surfacagem, cod_montagem, confeccao, coloracao, cor_coloracao, data_recebimento," & _
            "data_fim_servico, cod_fase, tipo_receita_OD, tipo_receita_OE, id_laboratorio, cod_lab_surf, listado, forma, cod_tipo_os " & _
            "from os where num_pedido = " & numPedido & " and id_filial =  " & idFilial & ""
        d.conecta()
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "Pedido")
        d.desconecta()
        Return ds
    End Function

    <WebMethod()> _
    Public Function importaOSFiliaisLabonorteNumero(ByVal codos As Integer, ByVal idFilial As Integer) As DataSet
        'Instrução responsável por recuperaros dados da OS informado
        Dim strSQL As String = "select  id_filial, cod_os, num_pedido, cod_tab_od, cod_tab_oe, cod_produto_od, cod_produto_oe, esf_od_longe," & _
            "cil_od_longe, esf_od_perto, cil_od_perto, dnp_od_longe, dnp_od_perto, base_od, adicao_od, altura_od, diametro_od, eixo_od," & _
            "esf_oe_longe, cil_oe_longe, esf_oe_perto, cil_oe_perto, dnp_oe_longe, dnp_oe_perto, base_oe, adicao_oe, altura_oe, diametro_oe," & _
            "eixo_oe, aro_horizontal, aro_vertical, maior_diametro, ponte, cod_Tipo_Armacao, crm_oftalmologista, cod_filial_cliente," & _
            "doc_cliente, cod_cliente, data_venda, data_previsao_entrega, hora_previsao_entrega, cod_vendedora, cod_qfez, observacao," & _
            "nota_serie, cod_verif_por, data_verificacao, cod_surfacagem, cod_montagem, confeccao, coloracao, cor_coloracao, data_recebimento," & _
            "data_fim_servico, cod_fase, tipo_receita_OD, tipo_receita_OE, id_laboratorio, cod_lab_surf, listado, forma, cod_tipo_os " & _
            "from os where cod_os = " & codos & " and id_filial =  " & idFilial & ""
        d.conecta()
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "OS")
        d.desconecta()
        Return ds
    End Function

    <WebMethod()> _
    Public Function importaOSFiliaisLabonorteOS(ByVal osIni As Integer, ByVal osFim As Integer, ByVal idFilial As Integer) As DataSet
        'Instrução responsável por recuperaros dados da OS informado
        Dim strSQL As String = "select  id_filial, cod_os, num_pedido, cod_tab_od, cod_tab_oe, cod_produto_od, cod_produto_oe, esf_od_longe," & _
            "cil_od_longe, esf_od_perto, cil_od_perto, dnp_od_longe, dnp_od_perto, base_od, adicao_od, altura_od, diametro_od, eixo_od," & _
            "esf_oe_longe, cil_oe_longe, esf_oe_perto, cil_oe_perto, dnp_oe_longe, dnp_oe_perto, base_oe, adicao_oe, altura_oe, diametro_oe," & _
            "eixo_oe, aro_horizontal, aro_vertical, maior_diametro, ponte, cod_Tipo_Armacao, crm_oftalmologista, cod_filial_cliente," & _
            "doc_cliente, cod_cliente, data_venda, data_previsao_entrega, hora_previsao_entrega, cod_vendedora, cod_qfez, observacao," & _
            "nota_serie, cod_verif_por, data_verificacao, cod_surfacagem, cod_montagem, confeccao, coloracao, cor_coloracao, data_recebimento," & _
            "data_fim_servico, cod_fase, tipo_receita_OD, tipo_receita_OE, id_laboratorio, cod_lab_surf, listado, forma, cod_tipo_os " & _
            "from os where cod_os >= " & osIni & " and cod_os <= " & osFim & " and id_filial =  " & idFilial & ""
        d.conecta()
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "OS")
        d.desconecta()
        Return ds
    End Function

    <WebMethod()> _
    Public Function importaAndamentoOS(ByVal codos As Integer, ByVal idfilial As Integer) As DataSet
        'Instrução responsável por recuperar os dados da OS informado
        Dim strSQL As String = "select * from andamentos where cod_os = " & codos & " and id_filial = " & idfilial & ""
        d.conecta()
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "Andamentos")
        d.desconecta()
        Return ds
    End Function


    'Procedimento responsável por enviar as informaçoes da tabela fila exportação da filia para a tabela fila_importacao da matriz
    <WebMethod()> _
    Public Sub FilaEnvioMatriz(ByVal idfila As Integer, ByVal origem As Integer, ByVal gerado As Integer, ByVal destino As Integer, _
                                    ByVal instrucao As String, ByVal datainc As DateTime, ByVal dataproc As DateTime)
        Dim res As Boolean = False
        Dim strInstrucao As String = ""

        Dim strSQL As String = "INSERT INTO Fila_importacao (id_fila" & _
                       ",origem,gerado,destino,instrucao,data_inclusao, data_processamento" & _
                       ") VALUES " & _
                       "(" & idfila & _
                       "," & origem & _
                       "," & gerado & _
                       "," & destino & _
                       "," & d.PStr(instrucao) & _
                       "," & d.pdtm(datainc) & _
                       "," & d.pdtm(dataproc) & _
                       ")"
        Try
            d.conecta()
            Dim cmd As New SqlCommand(strSQL, d.con)
            cmd.ExecuteNonQuery()
            strInstrucao = Replace(instrucao, "`", "'")
            d.Comando(strInstrucao, False)
            d.desconecta()
            res = True
        Catch ex As SoapException
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Procedimento responsável por atualizar a data de processamento da tabela fila_importacao da matriz
    <WebMethod()> _
    Public Sub atualizaFilaEnvio(ByVal idfila As Integer, ByVal origem As Integer, ByVal data As DateTime)
        Dim strSQL As String = "update fila_importacao set data_processamento = " & d.pdtm(data) & " where id_fila = " & idfila & " and origem = " & origem & ""
        d.conecta()
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.ExecuteNonQuery()
        d.desconecta()
    End Sub

    'Função responsável por verificar se um determinado resgistro existe na tabela fila_importacao
    <WebMethod()> _
    Public Function verificaImportados(ByVal idfila As Integer, ByVal origem As Integer) As Boolean
        Dim strSQL As String = "select 1 from fila_importacao where id_fila = " & idfila & " and origem = " & origem & ""
        Dim resultado As Boolean = False
        Dim obj As Object
        Try
            d.conecta()
            Dim cmd As New SqlCommand(strSQL, d.con)
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    'Função responsável por retornar os registro da tabela fila_exportação que vai da matriz para a filial
    <WebMethod()> _
    Public Function FilaRetornoMatriz(ByVal filial As Integer, ByVal nReg As Integer) As DataTable
        Dim Tsql As String
        Dim tt As New DataTable
        Tsql = "Select top(" & nReg & ") * from fila_exportacao where destino = " & filial & " and data_exportacao is null order by data_inclusao"
        d.carrega_Tabela(Tsql, tt)
        Return tt
    End Function

    'Procedimento responsável por atualizar a data de exportação da tabela fila_exportacao da matriz
    <WebMethod()> _
    Public Sub atualizaExportado(ByVal idfila As Integer, ByVal destino As Integer, ByVal data As DateTime)
        Dim strSQL As String = "update fila_exportacao set data_exportacao = " & d.pdtm(data) & " where id_fila = " & idfila & " and destino = " & destino & ""
        Try
            d.conecta()
            Dim cmdAndamento As New SqlCommand(strSQL, d.con)
            cmdAndamento.ExecuteNonQuery()
            d.desconecta()
        Catch ex As SoapException
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Função responsável por importar pedidos
    <WebMethod()> _
    Public Function importaPedido(ByVal numpedido As Integer, ByVal idfilial As Integer) As DataSet
        'Instrução responsável por recuperar os dados da OS informado
        Dim strSQL As String = "select * from pedido_balcao where num_pedido = " & numpedido & " and id_filial = " & idfilial & ""
        d.conecta()
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "Pedido")
        d.desconecta()
        Return ds
    End Function

    'Função responsável por importar pedidos
    <WebMethod()> _
    Public Function importaPedidoData(ByVal idfilial As Integer, ByVal di As DateTime, ByVal df As DateTime) As DataSet
        'Instrução responsável por recuperar os dados da OS informado
        Dim strSQL As String = "select * from pedido_balcao where data_pedido >= " & d.pdtm(di) & " and data_pedido <= " & d.pdtm(df) & " and id_filial = " & idfilial
        d.conecta()
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "Pedido_Balcao")
        d.desconecta()
        Return ds
    End Function

    'Função responsável por importar itens do pedido
    <WebMethod()> _
    Public Function importaPedidoItem(ByVal numpedido As Integer, ByVal idfilial As Integer) As DataSet
        'Instrução responsável por recuperar os dados da OS informado
        Dim strSQL As String = "select * from pedido_balcao_itens where num_pedido = " & numpedido & " and id_filial = " & idfilial & ""
        d.conecta()
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "Pedido_Balcao")
        d.desconecta()
        Return ds
    End Function

    'Função responsável por importar itens do pedido
    <WebMethod()> _
    Public Function importaPedidoServico(ByVal numpedido As Integer, ByVal idfilial As Integer) As DataSet
        'Instrução responsável por recuperar os dados da OS informado
        Dim strSQL As String = "select * from pedido_balcao_servicos where num_pedido = " & numpedido & " and id_filial = " & idfilial & ""
        d.conecta()
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "Pedido_Balcao")
        d.desconecta()
        Return ds
    End Function

    'Função responsável por importar pedidos
    <WebMethod()> _
    Public Function importaFatura(ByVal idfilial As Integer, ByVal di As DateTime, ByVal df As DateTime) As DataSet
        'Instrução responsável por recuperar os dados da OS informado
        Dim strSQL As String = "select * from fatura where id_filial = " & idfilial & " and data_lancamento >= " & d.pdtm(di) & " and data_lancamento <= " & d.pdtm(df)
        d.conecta()
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "Fatura")
        d.desconecta()
        Return ds
    End Function

    'Função responsável por importar pedidos
    <WebMethod()> _
    Public Function importaFaturaNumero(ByVal codfatura As Integer, ByVal idfilial As Integer) As DataSet
        'Instrução responsável por recuperar os dados da OS informado
        Dim strSQL As String = "select * from fatura where cod_fatura = " & codfatura & " and id_filial = " & idfilial
        d.conecta()
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "Fatura")
        d.desconecta()
        Return ds
    End Function

    'Função responsável por importar itens do pedido
    <WebMethod()> _
    Public Function importaFaturaItem(ByVal codfatura As Integer, ByVal idfilial As Integer) As DataSet
        'Instrução responsável por recuperar os dados da OS informado
        Dim strSQL As String = "select * from fatura_itens where cod_fatura = " & codfatura & " and id_filial = " & idfilial
        d.conecta()
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "Fatura_Itens")
        d.desconecta()
        Return ds
    End Function

    <WebMethod()> _
    Public Function importaMovimentoMaster(ByVal dtIni As DateTime, ByVal dtFim As DateTime) As DataSet
        'Instrução responsável por recuperaros dados da OS informado
        Dim strSQL As String = "select * from movimentomaster where data >= " & d.pdtm(dtIni) & " and data <= " & d.pdtm(dtFim)
        d.conecta()
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "MovimentoMaster")
        d.desconecta()
        Return ds
    End Function

    'Função responsável por retornar os registro da tabela fila_exportação que vai da matriz para a filial
    <WebMethod()> _
    Public Function FilaRetornoLabonorte(ByVal filial As Integer, ByVal nReg As Integer) As DataSet
        Dim strSQL As String
        strSQL = "Select top(" & nReg & ") * from fila_exportacao where destino = " & filial & " and data_exportacao is null order by data_inclusao"
        d.conecta()
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSQL, d.con)
        Dim ds As DataSet = New DataSet()
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds, "exportacao")
        d.desconecta()
        Return ds
    End Function
End Class