Imports System.Data
Imports System.Data.SqlClient
Imports mrotica_util
Public Class frmMain
    Dim labowcf As New Labonorte.Service1Client
    Dim tRetorno As New DataTable
    Dim tbImpRec As New DataTable
    Dim d As New dados
    Dim c As New config
    Dim master As New objMaster
    Dim enviando As Boolean = False
    Dim recebendo As Boolean = False
    Dim processando As Boolean = False
    Dim hora As Date = Now
    Dim importados As Long = 0
    Dim importando As Boolean = False
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " " & Application.ProductVersion & " " &
            c.Filial
    End Sub
#Region "Receber Registros"

    Private Sub cria_tb_impRec()
        tbImpRec.Columns.Add("id_fila")
        tbImpRec.Columns.Add("id_filial")
        tbImpRec.Columns.Add("dt")
    End Sub
    Private Sub RECEBE()
        Dim tt As New DataTable
        Dim i As Integer
        Dim l As Integer
        Dim qReg As Integer = 100
        Dim intTotal As Integer
        Dim wsRecebe As New labonorte_cliente.Service
        If recebendo = True Then
            Exit Sub
        End If
        l = c.Filial
        If l = 1 Then
            log("Loja " & l & " não recebe ")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        log(vbCrLf & l & vbCrLf & "Recebendo registros...")
        Try
            tt = wsRecebe.FilaRetornoLabonorte(c.Filial, qReg).Tables(0)
            intTotal = tt.Rows.Count
            If tt.Rows.Count > 0 Then
                Do While i < tt.Rows.Count
                    If verificaImportados(tt.Rows(i)("id_fila"), tt.Rows(i)("destino")) = False Then
                        gravaFilaImportado(tt.Rows(i)("id_fila"), tt.Rows(i)("origem"), tt.Rows(i)("gerado"), tt.Rows(i)("destino"), tt.Rows(i)("instrucao"), Now)
                    Else
                        atualizaFilaImportacao(tt.Rows(i)("id_fila"), tt.Rows(i)("destino"), Now)
                    End If
                    wsRecebe.atualizaExportado(tt.Rows(i)("id_fila"), tt.Rows(i)("destino"), Now)
                    i = i + 1
                    log("Recebendo " & i & " registro(s) de " & intTotal)
                Loop
            End If
        Catch ex As Exception
            log(ex.Message)
            recebendo = False
            Exit Sub
        End Try
        recebendo = False
    End Sub

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
        Return res
    End Function
    Private Sub marca_transmitido_rec(ByVal id_fila As Integer, ByVal id_filial As Integer, ByVal dt As Date)
        Dim r As DataRow
        r = tbImpRec.NewRow
        r("id_fila") = id_fila
        r("id_filial") = id_filial
        r("dt") = dt
        tbImpRec.Rows.Add(r)
    End Sub
    Private Sub Processa()
        Dim tb As New DataTable
        Dim sql As String = ""
        Dim sInsert As String
        Dim i, m As Integer
        Dim res As String = ""
        Dim dia As Date
        Dim destino As Integer
        processando = True
        destino = c.Filial
        dia = DateAdd(DateInterval.Month, -3, Now)
        sql = "delete top(500)  from fila_exportacao where data_exportacao is not null and data_inclusao <= " & d.Pdt(dia) & ""
        log("Limpando fila_exportacao... " & d.Comando(sql, False))
        sql = "delete top(500)  from fila_importacao where data_processamento is not null and data_inclusao <= " & d.Pdt(dia) & ""
        log("Limpando fila_importacao... " & d.Comando(sql, False))

        sql = "Select top(200000) * from fila_importacao where destino = " & destino & " and " &
        "data_processamento IS NULL Order By data_inclusao"
        'd.carrega_Tabela(sql, tb)
        tb = master.retornaRegistro(sql).Tables(0)
        i = 0
        m = tb.Rows.Count
        log("processando LOJA " & destino)
        While i < m
            sInsert = tb.Rows(i)("instrucao")
            sInsert = Replace(sInsert, "`", "'")
            res = d.Comando(sInsert, False)
            log("processando " & i & " de " & m & " - > " & tb.Rows(i)("id_fila") & ": " & res)
            If res.StartsWith("OK") Or res.ToUpper.Contains("PRIMARY KEY") Or res.ToUpper.Contains("CHAVE DUPLICADA") _
            Or res.ToUpper.Contains("CHAVE PRIMÁRIA") Or res.ToLower.Contains("insert duplicate key") Then
                sql = "Update fila_importacao set data_processamento = " & d.pdtm(Now) &
                " where id_fila = " & tb.Rows(i)("id_fila") & " and destino = " & destino & ""
                d.Comando(sql, False)
            Else
                log(res)
            End If
            i = i + 1
            Application.DoEvents()
        End While
    End Sub
#End Region

#Region "Enviar Registros"


    Private Sub Enviar()
        Dim tt As New DataTable
        Dim strSQL As String = ""
        Dim msg As String = ""
        Dim qReg As Integer = 100 'Quantidade de registros a ser enviados
        Dim i, intTotal As Integer
        Dim wsEnvia As New labonorte_cliente.Service
        If enviando = True Then
            log("Envio em andamento, aguardando próximo ciclo!")
            Exit Sub
        End If
        Try
            strSQL = "select top(" & qReg & ") * from fila_exportacao where data_exportacao is null and origem = " & c.Filial & ""
            tt = master.retornaRegistro(strSQL).Tables(0)
            'd.carrega_Tabela("select top(" & qReg & ") * from fila_exportacao where data_exportacao is null and origem = " & c.Filial & "", tt)
            'tt.TableName = "Enviados"
            intTotal = tt.Rows.Count
            If tt.Rows.Count > 0 Then
                Do While i < tt.Rows.Count
                    If wsEnvia.verificaImportados(tt.Rows(i)("id_fila"), tt.Rows(i)("origem")) = False Then
                        wsEnvia.FilaEnvioMatriz(tt.Rows(i)("id_fila"), tt.Rows(i)("origem"), tt.Rows(i)("gerado"), tt.Rows(i)("destino"), tt.Rows(i)("instrucao"), Now, Now)
                    Else
                        wsEnvia.atualizaFilaEnvio(tt.Rows(i)("id_fila"), tt.Rows(i)("origem"), Now)
                    End If
                    atualizaExportado(tt.Rows(i)("id_fila"), c.Filial, Now)
                    i = i + 1
                    log("Enviando " & i & " registro(s) de " & intTotal)
                Loop
                log("Servidor respondeu com " & tt.Rows.Count & " Registro(s). Iniciando processamento fila_exportacao")
            End If
        Catch ex As Exception
            log(ex.ToString)
        End Try
    End Sub

    Private Sub marca_transmitidos(ByVal tb As DataTable)
        Dim sql As String
        Dim i, m As Integer
        i = 0
        m = tb.Rows.Count
        While i < m
            sql = "Update fila_exportacao set data_exportacao = " & d.pdtm(tb.Rows(i)("dt")) &
                    " where id_fila = " & tb.Rows(i)("id_fila") & " and origem = " & tb.Rows(i)("id_filial")
            log(d.Comando(sql, False))
            i = i + 1
        End While
    End Sub
#End Region
#Region "Funções Auxiliares"
    Private Sub log(ByVal texto As String)
        txtLog.Text = Now.ToString & " --> " & texto & vbCrLf & txtLog.Text
        Application.DoEvents()
        If txtLog.Text.Length > 10000 Then
            txtLog.Text = ""
        End If
    End Sub
#End Region
    Private Sub tmrIniciar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrIniciar.Tick
        tmrIniciar.Enabled = False
        Me.WindowState = FormWindowState.Minimized
        Me.Hide()
        tmrSincroniza.Enabled = True
    End Sub
    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        Else
            Me.Show()
        End If
        Me.Text = Me.ProductName & " Versão: " & Me.ProductVersion & " Loja " & c.Filial
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub
    Private Sub tmrSincroniza_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSincroniza.Tick
        If importando = True Then
            Exit Sub
        End If

        If Now >= hora And processando = False Then
            processando = True
            Enviar()
            RECEBE()
            Processa()

            '
            Dim strSQL As String = "Select ultima_sincronizacao, proxima_sincronizacao from controle"
            Dim ttSincronizacao As New DataTable
            ttSincronizacao = master.retornaRegistro(strSQL).Tables(0)
            Dim proximasinc As DateTime = DateAdd(DateInterval.Day, 1, ttSincronizacao.Rows(0)("proxima_sincronizacao")).ToShortDateString & " 23:00:00"

            If d.pdtm(Now) > d.pdtm(ttSincronizacao.Rows(0)("proxima_sincronizacao")) Then
                Dim strSQLAtualiza As String = "ultima_sincronizacao = " & d.pdtm(Now) & "," & "proxima_sincronizacao = " & d.pdtm(proximasinc)
                master.atualiza_registros("Controle", strSQLAtualiza, False)
                processando = True
                ImportaOSLabonorte()
                importaMovimentoMaster()
                processando = False
            End If
            '

            hora = DateAdd(DateInterval.Second, 5, Now)
            log("Tempo: " & Now.ToString & " Próxima Sincronização: " & hora.ToString & vbCrLf & " -> Importados nessa sessão:" & importados.ToString)
            processando = False
        End If
    End Sub


    Private Sub RECEBE_arquivo()
        Dim tt As New DataTable
        Dim i, t As Integer
        Dim dl As New OpenFileDialog
        Dim ds As New DataSet
        Dim r As String
        Dim l As Integer
        Me.Cursor = Cursors.AppStarting
        dl.ShowDialog(Me)
        l = c.Filial
        ds.ReadXml(dl.FileName)
        log(l)
        Try
            tt = ds.Tables(0)
        Catch ex As Exception
            log(ex.Message)
            Exit Sub
        End Try
        i = 0
        t = tt.Rows.Count
        While i < t
            r = insere_recebido(tt.Rows(i))
            log("Reg " & i + 1 & " de " & t & vbTab & r)
            i = i + 1
            Application.DoEvents()
        End While
        Me.Cursor = Cursors.Default
    End Sub

    'Colocado hoje
    Private Function comparaAndamento(ByVal intCodOS As Integer, ByVal intFilial As Integer, ByVal intOrdem As Integer) As DataTable
        Dim tbAndamento As New DataTable
        Dim strSQL As String = "select id_filial, cod_os, ordem from andamentos where cod_os = " & intCodOS & " and id_filial = " & intFilial & _
            " and ordem = " & intOrdem & ""
        d.carrega_Tabela(strSQL, tbAndamento)
        Return tbAndamento
    End Function

    Private Function comparaOS(ByVal intCodOS As Integer, ByVal intFilial As Integer) As DataTable
        Dim tbOS As New DataTable
        Dim strSQL As String = "select id_filial, cod_os from os where cod_os = " & intCodOS & " and id_filial = " & intFilial & ""
        d.carrega_Tabela(strSQL, tbOS)
        Return tbOS
    End Function

    '28/08/2014
    Private Function comparaPedido(ByVal intPedido As Integer, ByVal intFilial As Integer) As DataTable
        Dim tbPedido As New DataTable
        Dim strSQL As String = "select id_filial, num_pedido from pedido_balcao where num_pedido = " & intPedido & " and id_filial = " & intFilial & ""
        d.carrega_Tabela(strSQL, tbPedido)
        Return tbPedido
    End Function

    Private Sub inseriAndamento(ByVal idfilial As Int16, ByVal intCodOs As Integer, ByVal intFilialAndamento As Integer, ByVal intOrdem As Integer, _
                                ByVal dtData As DateTime, ByVal intCodAndamento As Integer, ByVal intUsuario As Integer, _
                                ByVal intCodStatusAndamento As Integer, ByVal obs As String)
        Dim strSQLInsertAndamento As String = "insert into andamentos (id_filial, cod_os, id_filial_andamento, ordem, data," & _
                        "cod_andamento, cod_usuario, cod_status_andamento, Observacao) values(" & idfilial & "," & _
                        intCodOs & "," & intFilialAndamento & "," & intOrdem & "," & _
                        d.pdtm(dtData) & "," & intCodAndamento & "," & intUsuario & "," & _
                        intCodStatusAndamento & "," & d.PStr(obs) & ")"
        d.conecta()
        Try
            Dim cmdAndamento As New SqlCommand(strSQLInsertAndamento, d.con)
            cmdAndamento.ExecuteNonQuery()
            d.desconecta()
        Catch ex As Exception
            log(ex.ToString)
        End Try
    End Sub

    Private Sub atualizaExportado(ByVal idfila As Integer, ByVal filial As Int16, ByVal data As DateTime)
        Dim strSQL As String = "update fila_exportacao set data_exportacao = " & d.pdtm(data) & " where id_fila = " & idfila & " and origem = " & filial & ""
        d.conecta()
        Dim cmdAndamento As New SqlCommand(strSQL, d.con)
        cmdAndamento.ExecuteNonQuery()
        d.desconecta()
    End Sub

    Public Sub gravaFilaImportado(ByVal idfila As Integer, ByVal origem As Integer, ByVal gerado As Integer, ByVal destino As Integer, _
                                ByVal instrucao As String, ByVal datainc As DateTime)
        Dim res As Boolean = False
        Dim strInstrucao As String = ""

        Dim strSQL As String = "INSERT INTO Fila_importacao (id_fila" & _
                       ",origem,gerado,destino,instrucao,data_inclusao" & _
                       ") VALUES " & _
                       "(" & idfila & _
                       "," & origem & _
                       "," & gerado & _
                       "," & destino & _
                       "," & d.PStr(instrucao) & _
                       "," & d.pdtm(datainc) & _
                       ")"
        Try
            d.conecta()
            Dim cmd As New SqlCommand(strSQL, d.con)
            cmd.ExecuteNonQuery()
            strInstrucao = Replace(instrucao, "`", "'")
            d.Comando(strInstrucao, False)
            d.desconecta()
            res = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Function verificaImportados(ByVal idfila As Integer, ByVal destino As Integer) As Boolean
        Dim strSQL As String = "select 1 from fila_importacao where id_fila = " & idfila & " and destino = " & destino & ""
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

    Public Sub atualizaFilaImportacao(ByVal idfila As Integer, ByVal destino As Integer, ByVal data As DateTime)
        Dim strSQL As String = "update fila_importacao set data_processamento = " & d.pdtm(data) & " where id_fila = " & idfila & " and destino = " & destino & ""
        d.conecta()
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.ExecuteNonQuery()
        d.desconecta()
    End Sub

    Private Sub btnReceber_Click(sender As System.Object, e As System.EventArgs) Handles btnReceber.Click
        RECEBE()
    End Sub

    Private Sub btnEnviar_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviar.Click
        Enviar()
    End Sub

    Private Sub btnProcessa_Click(sender As System.Object, e As System.EventArgs) Handles btnProcessa.Click
        Processa()
    End Sub

    Private Sub btnReiniciar_Click(sender As System.Object, e As System.EventArgs) Handles btnReiniciar.Click
        processando = False
        hora = DateAdd(DateInterval.Second, 10, Now)
        tmrSincroniza.Enabled = True
        log("Tempo: " & Now.ToString & " Próxima Sincronização: " & hora.ToString)
    End Sub

    Private Sub btnImportar_Click(sender As System.Object, e As System.EventArgs) Handles btnImportar.Click
        importando = True
        RECEBE_arquivo()
        importando = False
    End Sub

    Private Sub btnImportarGeral_Click(sender As System.Object, e As System.EventArgs) Handles btnImportarGeral.Click
        processando = True
        Dim f As New frmPedidoData
        f.ShowDialog()
        f.Dispose()
        processando = False
    End Sub

    'Importa as OS das Óticas Ana Maria, pois as os gerada nessas lojas não são transmitidadas para a labonorte, e quando ocorre algum andamento
    'Para a respectiva OS acaba por gerar uma quantidade grande de registro na fila de importação das filias da Labonorte.
    Private Sub ImportaOSLabonorte()
        Dim tbOS As New DataTable
        Dim tbOSAndamento As New DataTable
        Dim tbPedido As New DataTable
        Dim tbPedidoItem As New DataTable
        Dim tbServico As New DataTable
        Dim di As DateTime = DateAdd(DateInterval.Day, c.dias, Now).ToShortDateString & " 00:00:00"
        Dim df As DateTime = Now.ToShortDateString & " 23:59:59"
        Dim wsOS As New labonorte_cliente.Service
        tbOS = wsOS.importaOSFiliaisLabonorteData(di, df).Tables(0)  'Traz todos os registro de OS feitas nas Ótica Ana Maria
        Dim i, j, l, m As Integer

        'Pecorre todos os registros da tabela OS
        For i = 0 To tbOS.Rows.Count - 1
            'Retorna se a OS foi encontrada
            Dim strSQL As String = "Select 1 From OS where num_pedido = " & tbOS.Rows(i)("num_pedido") & " and id_filial = " & tbOS.Rows(i)("id_filial")
            If tbOS.Rows(i)("num_pedido") IsNot DBNull.Value Then
                If master.verifica_existencia_registro(strSQL) = False Then 'Caso não exista a OS na base local insere a OS
                    Dim strSQLInsertOS As String = "Insert Into OS(id_filial, cod_os, num_pedido, cod_tab_od, cod_tab_oe, cod_produto_od, cod_produto_oe, " & _
                    "esf_od_longe, cil_od_longe, esf_od_perto, cil_od_perto, dnp_od_longe, dnp_od_perto, base_od, adicao_od, altura_od, diametro_od, " & _
                    "eixo_od, esf_oe_longe, cil_oe_longe, esf_oe_perto, cil_oe_perto, dnp_oe_longe, dnp_oe_perto, base_oe, adicao_oe, altura_oe, " & _
                    "diametro_oe, eixo_oe, aro_horizontal, aro_vertical, maior_diametro, ponte, cod_Tipo_Armacao, crm_oftalmologista, " & _
                    "cod_filial_cliente, doc_cliente, cod_cliente, data_venda, data_previsao_entrega, hora_previsao_entrega, cod_vendedora, " & _
                    "cod_qfez, observacao, nota_serie, cod_verif_por, data_verificacao, cod_surfacagem, cod_montagem, confeccao, coloracao, " & _
                    "cor_coloracao, data_recebimento, data_fim_servico, cod_fase, tipo_receita_OD, tipo_receita_OE, id_laboratorio, cod_lab_surf, " & _
                    "listado, forma, cod_tipo_os) values(" & tbOS.Rows(i)("id_filial") & "," & tbOS.Rows(i)("cod_os") & "," & _
                    d.cdin(tbOS.Rows(i)("num_pedido")) & "," & d.cdin(tbOS.Rows(i)("cod_tab_od")) & "," & tbOS.Rows(i)("cod_tab_oe") & "," & _
                    d.cdin(tbOS.Rows(i)("cod_produto_od")) & "," & d.cdin(tbOS.Rows(i)("cod_produto_oe")) & "," & _
                    d.cdin(tbOS.Rows(i)("esf_od_longe")) & "," & d.cdin(tbOS.Rows(i)("cil_od_longe")) & "," & d.cdin(tbOS.Rows(i)("esf_od_perto")) & "," & _
                    d.cdin(tbOS.Rows(i)("cil_od_perto")) & "," & d.cdin(tbOS.Rows(i)("dnp_od_longe")) & "," & d.cdin(tbOS.Rows(i)("dnp_od_perto")) & "," & _
                    d.cdin(tbOS.Rows(i)("base_od")) & "," & d.cdin(tbOS.Rows(i)("adicao_od")) & "," & d.cdin(tbOS.Rows(i)("altura_od")) & "," & _
                    d.cdin(tbOS.Rows(i)("diametro_od")) & "," & d.cdin(tbOS.Rows(i)("eixo_od")) & "," & d.cdin(tbOS.Rows(i)("esf_oe_longe")) & "," & _
                    d.cdin(tbOS.Rows(i)("cil_oe_longe")) & "," & d.cdin(tbOS.Rows(i)("esf_oe_perto")) & "," & d.cdin(tbOS.Rows(i)("cil_oe_perto")) & "," & _
                    d.cdin(tbOS.Rows(i)("dnp_oe_longe")) & "," & d.cdin(tbOS.Rows(i)("dnp_oe_perto")) & "," & d.cdin(tbOS.Rows(i)("base_oe")) & "," & _
                    d.cdin(tbOS.Rows(i)("adicao_oe")) & "," & d.cdin(tbOS.Rows(i)("altura_oe")) & "," & d.cdin(tbOS.Rows(i)("diametro_oe")) & "," & _
                    d.cdin(tbOS.Rows(i)("eixo_oe")) & "," & d.cdin(tbOS.Rows(i)("aro_horizontal")) & "," & d.cdin(tbOS.Rows(i)("aro_vertical")) & "," & _
                    d.cdin(tbOS.Rows(i)("maior_diametro")) & "," & d.cdin(tbOS.Rows(i)("ponte")) & "," & d.cdin(tbOS.Rows(i)("cod_Tipo_Armacao")) & "," & _
                    d.cdin(tbOS.Rows(i)("crm_oftalmologista")) & "," & d.cdin(tbOS.Rows(i)("cod_filial_cliente")) & "," & _
                    d.cdin(tbOS.Rows(i)("doc_cliente")) & "," & d.cdin(tbOS.Rows(i)("cod_cliente")) & "," & d.Pdt(tbOS.Rows(i)("data_venda")) & "," & _
                    d.Pdt(tbOS.Rows(i)("data_previsao_entrega")) & "," & d.PStr(tbOS.Rows(i)("hora_previsao_entrega")) & "," & _
                    d.cdin(tbOS.Rows(i)("cod_vendedora")) & "," & d.cdin(tbOS.Rows(i)("cod_qfez")) & "," & d.PStr(tbOS.Rows(i)("observacao")) & "," & _
                    d.PStr(tbOS.Rows(i)("nota_serie")) & "," & d.cdin(tbOS.Rows(i)("cod_verif_por")) & "," & _
                    d.Pdt(tbOS.Rows(i)("data_verificacao")) & "," & d.cdin(tbOS.Rows(i)("cod_surfacagem")) & "," & d.cdin(tbOS.Rows(i)("cod_montagem")) & "," & _
                    d.PStr(tbOS.Rows(i)("confeccao")) & "," & d.PStr(tbOS.Rows(i)("coloracao")) & "," & _
                    d.PStr(tbOS.Rows(i)("cor_coloracao")) & "," & d.Pdt(tbOS.Rows(i)("data_recebimento")) & "," & _
                    d.Pdt(tbOS.Rows(i)("data_fim_servico")) & "," & d.cdin(tbOS.Rows(i)("cod_fase")) & "," & d.cdin(tbOS.Rows(i)("tipo_receita_OD")) & "," & _
                    d.cdin(tbOS.Rows(i)("tipo_receita_OE")) & "," & d.cdin(tbOS.Rows(i)("id_laboratorio")) & "," & d.cdin(tbOS.Rows(i)("cod_lab_surf")) & "," & _
                    d.Pdt(tbOS.Rows(i)("listado")) & "," & d.PStr(tbOS.Rows(i)("forma")) & "," & d.cdin(tbOS.Rows(i)("cod_tipo_os")) & ")"
                    d.conecta()
                    Dim cmdOS As New SqlCommand(strSQLInsertOS, d.con)
                    cmdOS.ExecuteNonQuery()

                    'Importa os andamentos da OS em questão
                    tbOSAndamento = wsOS.importaAndamentoOS(tbOS.Rows(i)("cod_os"), tbOS.Rows(i)("id_filial")).Tables(0)
                    If tbOSAndamento.Rows.Count > 0 Then
                        For j = 0 To tbOSAndamento.Rows.Count - 1
                            Dim strSQLAndamento As String = "Select 1 from andamentos where cod_os = " & tbOSAndamento.Rows(j)("cod_os") & _
                                " and id_filial = " & tbOSAndamento.Rows(j)("id_filial") & " and id_filial_andamento = " & _
                                tbOSAndamento.Rows(j)("id_filial_andamento") & " and ordem = " & tbOSAndamento.Rows(j)("ordem")
                            If master.verifica_existencia_registro(strSQLAndamento) = False Then
                                'Grava os andamentos da OS
                                inseriAndamento(tbOSAndamento.Rows(j)("id_filial"), tbOSAndamento.Rows(j)("cod_os"), tbOSAndamento.Rows(j)("id_filial_andamento"), _
                                tbOSAndamento.Rows(j)("ordem"), tbOSAndamento.Rows(j)("data"), tbOSAndamento.Rows(j)("cod_andamento"), _
                                tbOSAndamento.Rows(j)("cod_usuario"), tbOSAndamento.Rows(j)("cod_status_andamento"), _
                                tbOSAndamento.Rows(j)("observacao").ToString)
                            End If
                        Next
                    End If

                    'Importa Pedido ---
                    tbPedido = wsOS.importaPedido(tbOS.Rows(i)("num_pedido"), tbOS.Rows(i)("id_filial")).Tables(0) 'Retorna o Pedido
                    If tbPedido.Rows.Count > 0 Then
                        Dim strSQLPedido As String = "Select 1 From Pedido_Balcao where num_pedido = " & tbPedido.Rows(0)("num_pedido") & " and id_filial = " & tbPedido.Rows(0)("id_filial")
                        If master.verifica_existencia_registro(strSQLPedido) = False Then
                            Dim strSQLInsertPedido As String = "Insert Into Pedido_Balcao(num_pedido, id_filial, cod_vendedor, data_pedido, cod_cliente, cod_filial_cliente, " & _
                            "cod_status_pedido, cod_autorizacao, filial_autorizacao, forma, cod_tipo_pedido, valor_pago, valor_apagar, " & _
                            "valor_devolvido, cod_vendedor_ext, desconto) values(" & tbPedido.Rows(0)("num_pedido") & "," & tbPedido.Rows(0)("id_filial") & "," & _
                            tbPedido.Rows(0)("cod_vendedor") & "," & d.pdtm(tbPedido.Rows(0)("data_pedido")) & "," & tbPedido.Rows(0)("cod_cliente") & "," & _
                            tbPedido.Rows(0)("cod_filial_cliente") & "," & tbPedido.Rows(0)("cod_status_pedido") & "," & _
                            d.cdin(tbPedido.Rows(0)("cod_autorizacao")) & "," & d.cdin(tbPedido.Rows(0)("filial_autorizacao")) & "," & _
                            d.PStr(tbPedido.Rows(0)("forma")) & "," & d.cdin(tbPedido.Rows(0)("cod_tipo_pedido")) & "," & _
                            d.cdin(tbPedido.Rows(0)("valor_pago")) & "," & d.cdin(tbPedido.Rows(0)("valor_apagar")) & "," & _
                            d.cdin(tbPedido.Rows(0)("valor_devolvido")) & "," & _
                            tbPedido.Rows(0)("cod_vendedor_ext") & "," & d.PStr(tbPedido.Rows(0)("desconto")) & ")"
                            d.conecta()
                            Dim cmdPedido As New SqlCommand(strSQLInsertPedido, d.con)
                            cmdPedido.ExecuteNonQuery()

                            'Retorna o item do pedido apta dentro do obejto tbPedidoItem
                            tbPedidoItem = wsOS.importaPedidoItem(tbPedido.Rows(0)("num_pedido"), tbPedido.Rows(0)("id_filial")).Tables(0)
                            If tbPedidoItem.Rows.Count > 0 Then
                                For l = 0 To tbPedidoItem.Rows.Count - 1
                                    Dim strSQLPedidoItem As String = "Select 1 from pedido_balcao_itens where num_pedido = " & tbPedidoItem.Rows(l)("num_pedido") & " and id_filial = " & tbPedidoItem.Rows(l)("id_filial") & _
                                        " and item = " & tbPedidoItem.Rows(l)("item")
                                    If master.verifica_existencia_registro(strSQLPedidoItem) = False Then
                                        Dim strSQLItemPedido As String = "Insert Into Pedido_Balcao_Itens(num_pedido, id_filial, item, cod_produto, quant, compra, " & _
                                        "desconto, preco, cod_status_item, Pacote, cod_pacote, desc_caixa, usuario_can, tipo_devolucao, devolvido_estoque, " & _
                                        "data_devolucao, preco_tab) values(" & tbPedidoItem.Rows(l)("num_pedido") & "," & _
                                        tbPedidoItem.Rows(l)("id_filial") & "," & tbPedidoItem.Rows(l)("item") & "," & _
                                        tbPedidoItem.Rows(l)("cod_produto") & "," & tbPedidoItem.Rows(l)("quant") & "," & _
                                        d.cdin(tbPedidoItem.Rows(l)("compra")) & "," & d.cdin(tbPedidoItem.Rows(l)("desconto")) & "," & _
                                        d.cdin(tbPedidoItem.Rows(l)("preco")) & "," & tbPedidoItem.Rows(l)("cod_status_item") & "," & _
                                        d.PStr(tbPedidoItem.Rows(l)("pacote")) & "," & d.cdin(tbPedidoItem.Rows(l)("cod_pacote")) & "," & _
                                        d.cdin(tbPedidoItem.Rows(l)("desc_caixa")) & "," & d.cdin(tbPedidoItem.Rows(l)("usuario_can")) & "," & _
                                        d.PStr(tbPedidoItem.Rows(l)("tipo_devolucao")) & "," & d.PStr(tbPedidoItem.Rows(l)("devolvido_estoque")) & "," & _
                                        d.pdtm(tbPedidoItem.Rows(l)("data_devolucao")) & "," & d.cdin(tbPedidoItem.Rows(l)("preco_tab")) & ")"
                                        d.conecta()

                                        Dim cmdItemPedido As New SqlCommand(strSQLItemPedido, d.con)
                                        cmdItemPedido.ExecuteNonQuery()
                                    End If
                                Next
                            End If

                            'Retorna o serviço caso exista para dentro do objeto tbServico
                            tbServico = wsOS.importaPedidoServico(tbPedido.Rows(0)("num_pedido"), tbPedido.Rows(0)("id_filial")).Tables(0)
                            If tbServico.Rows.Count > 0 Then
                                For m = 0 To tbServico.Rows.Count - 1
                                    Dim strSQLServicoPedido As String = "Select 1 from pedido_balcao_servicos where num_pedido = " & tbServico.Rows(m)("num_pedido") & _
                                    " and id_filial = " & tbServico.Rows(m)("id_filial") & " and item_servico = " & tbServico.Rows(m)("item_servico")
                                    If master.verifica_existencia_registro(strSQLServicoPedido) = False Then
                                        'Grava os serviços do Pedido
                                        Dim strSQLServico As String = "Insert Into Pedido_Balcao_Servicos(num_pedido, id_filial, item_servico, " & _
                                            "cod_servico, quant, compra, desconto, preco, desc_caixa, cod_status_servico, pacote, cod_pacote, " & _
                                            "usuario_can, tipo_devolucao, devolvido_estoque, data_devolucao, preco_tab) values(" & _
                                            tbServico.Rows(m)("num_pedido") & "," & tbServico.Rows(m)("id_filial") & "," & _
                                            tbServico.Rows(m)("item_servico") & "," & tbServico.Rows(m)("cod_servico") & "," & _
                                            tbServico.Rows(m)("quant") & "," & d.cdin(tbServico.Rows(m)("compra")) & "," & _
                                            d.cdin(tbServico.Rows(m)("desconto")) & "," & d.cdin(tbServico.Rows(m)("preco")) & "," & _
                                            d.cdin(tbServico.Rows(m)("desc_caixa")) & "," & tbServico.Rows(m)("cod_status_servico") & "," & _
                                            d.PStr(tbServico.Rows(m)("pacote")) & "," & d.cdin(tbServico.Rows(m)("cod_pacote")) & "," & _
                                            d.cdin(tbServico.Rows(m)("usuario_can")) & "," & d.PStr(tbServico.Rows(m)("tipo_devolucao")) & "," & _
                                            d.cdin(tbServico.Rows(m)("devolvido_estoque")) & "," & d.pdtm(tbServico.Rows(m)("data_devolucao")) & "," & _
                                            d.cdin(tbServico.Rows(m)("preco_tab")) & ")"
                                        d.conecta()

                                        Dim cmdServido As New SqlCommand(strSQLServico, d.con)
                                        cmdServido.ExecuteNonQuery()
                                    End If
                                Next
                            End If
                        End If
                    End If
                    'Caso o pedido existar
                Else
                    'Importa Pedido ---
                    tbPedido = wsOS.importaPedido(tbOS.Rows(i)("num_pedido"), tbOS.Rows(i)("id_filial")).Tables(0) 'Retorna o Pedido
                    If tbPedido.Rows.Count > 0 Then
                        Dim strSQLPedido As String = "Select 1 From Pedido_Balcao where num_pedido = " & tbPedido.Rows(0)("num_pedido") & " and id_filial = " & tbPedido.Rows(0)("id_filial")
                        If master.verifica_existencia_registro(strSQLPedido) = False Then
                            Dim strSQLInsertPedido As String = "Insert Into Pedido_Balcao(num_pedido, id_filial, cod_vendedor, data_pedido, cod_cliente, cod_filial_cliente, " & _
                            "cod_status_pedido, cod_autorizacao, filial_autorizacao, forma, cod_tipo_pedido, valor_pago, valor_apagar, " & _
                            "valor_devolvido, cod_vendedor_ext, desconto) values(" & tbPedido.Rows(0)("num_pedido") & "," & tbPedido.Rows(0)("id_filial") & "," & _
                            tbPedido.Rows(0)("cod_vendedor") & "," & d.pdtm(tbPedido.Rows(0)("data_pedido")) & "," & tbPedido.Rows(0)("cod_cliente") & "," & _
                            tbPedido.Rows(0)("cod_filial_cliente") & "," & tbPedido.Rows(0)("cod_status_pedido") & "," & _
                            d.cdin(tbPedido.Rows(0)("cod_autorizacao")) & "," & d.cdin(tbPedido.Rows(0)("filial_autorizacao")) & "," & _
                            d.PStr(tbPedido.Rows(0)("forma")) & "," & d.cdin(tbPedido.Rows(0)("cod_tipo_pedido")) & "," & _
                            d.cdin(tbPedido.Rows(0)("valor_pago")) & "," & d.cdin(tbPedido.Rows(0)("valor_apagar")) & "," & _
                            d.cdin(tbPedido.Rows(0)("valor_devolvido")) & "," & _
                            tbPedido.Rows(0)("cod_vendedor_ext") & "," & d.PStr(tbPedido.Rows(0)("desconto")) & ")"
                            d.conecta()
                            Dim cmdPedido As New SqlCommand(strSQLInsertPedido, d.con)
                            cmdPedido.ExecuteNonQuery()

                            'Retorna o item do pedido apta dentro do obejto tbPedidoItem
                            tbPedidoItem = wsOS.importaPedidoItem(tbPedido.Rows(0)("num_pedido"), tbPedido.Rows(0)("id_filial")).Tables(0)
                            If tbPedidoItem.Rows.Count > 0 Then
                                For l = 0 To tbPedidoItem.Rows.Count - 1
                                    Dim strSQLPedidoItem As String = "Select 1 from pedido_balcao_itens where num_pedido = " & tbPedidoItem.Rows(l)("num_pedido") & " and id_filial = " & tbPedidoItem.Rows(l)("id_filial") & _
                                        " and item = " & tbPedidoItem.Rows(l)("item")
                                    If master.verifica_existencia_registro(strSQLPedidoItem) = False Then
                                        Dim strSQLItemPedido As String = "Insert Into Pedido_Balcao_Itens(num_pedido, id_filial, item, cod_produto, quant, compra, " & _
                                        "desconto, preco, cod_status_item, Pacote, cod_pacote, desc_caixa, usuario_can, tipo_devolucao, devolvido_estoque, " & _
                                        "data_devolucao, preco_tab) values(" & tbPedidoItem.Rows(l)("num_pedido") & "," & _
                                        tbPedidoItem.Rows(l)("id_filial") & "," & tbPedidoItem.Rows(l)("item") & "," & _
                                        tbPedidoItem.Rows(l)("cod_produto") & "," & tbPedidoItem.Rows(l)("quant") & "," & _
                                        d.cdin(tbPedidoItem.Rows(l)("compra")) & "," & d.cdin(tbPedidoItem.Rows(l)("desconto")) & "," & _
                                        d.cdin(tbPedidoItem.Rows(l)("preco")) & "," & tbPedidoItem.Rows(l)("cod_status_item") & "," & _
                                        d.PStr(tbPedidoItem.Rows(l)("pacote")) & "," & d.cdin(tbPedidoItem.Rows(l)("cod_pacote")) & "," & _
                                        d.cdin(tbPedidoItem.Rows(l)("desc_caixa")) & "," & d.cdin(tbPedidoItem.Rows(l)("usuario_can")) & "," & _
                                        d.PStr(tbPedidoItem.Rows(l)("tipo_devolucao")) & "," & d.PStr(tbPedidoItem.Rows(l)("devolvido_estoque")) & "," & _
                                        d.pdtm(tbPedidoItem.Rows(l)("data_devolucao")) & "," & d.cdin(tbPedidoItem.Rows(l)("preco_tab")) & ")"
                                        d.conecta()

                                        Dim cmdItemPedido As New SqlCommand(strSQLItemPedido, d.con)
                                        cmdItemPedido.ExecuteNonQuery()
                                    End If
                                Next
                            End If

                            'Retorna o serviço caso exista para dentro do objeto tbServico
                            tbServico = wsOS.importaPedidoServico(tbPedido.Rows(0)("num_pedido"), tbPedido.Rows(0)("id_filial")).Tables(0)
                            If tbServico.Rows.Count > 0 Then
                                For m = 0 To tbServico.Rows.Count - 1
                                    Dim strSQLServicoPedido As String = "Select 1 from pedido_balcao_servicos where num_pedido = " & tbServico.Rows(m)("num_pedido") & _
                                    " and id_filial = " & tbServico.Rows(m)("id_filial") & " and item_servico = " & tbServico.Rows(m)("item_servico")
                                    If master.verifica_existencia_registro(strSQLServicoPedido) = False Then
                                        'Grava os serviços do Pedido
                                        Dim strSQLServico As String = "Insert Into Pedido_Balcao_Servicos(num_pedido, id_filial, item_servico, " & _
                                            "cod_servico, quant, compra, desconto, preco, desc_caixa, cod_status_servico, pacote, cod_pacote, " & _
                                            "usuario_can, tipo_devolucao, devolvido_estoque, data_devolucao, preco_tab) values(" & _
                                            tbServico.Rows(m)("num_pedido") & "," & tbServico.Rows(m)("id_filial") & "," & _
                                            tbServico.Rows(m)("item_servico") & "," & tbServico.Rows(m)("cod_servico") & "," & _
                                            tbServico.Rows(m)("quant") & "," & d.cdin(tbServico.Rows(m)("compra")) & "," & _
                                            d.cdin(tbServico.Rows(m)("desconto")) & "," & d.cdin(tbServico.Rows(m)("preco")) & "," & _
                                            d.cdin(tbServico.Rows(m)("desc_caixa")) & "," & tbServico.Rows(m)("cod_status_servico") & "," & _
                                            d.PStr(tbServico.Rows(m)("pacote")) & "," & d.cdin(tbServico.Rows(m)("cod_pacote")) & "," & _
                                            d.cdin(tbServico.Rows(m)("usuario_can")) & "," & d.PStr(tbServico.Rows(m)("tipo_devolucao")) & "," & _
                                            d.cdin(tbServico.Rows(m)("devolvido_estoque")) & "," & d.pdtm(tbServico.Rows(m)("data_devolucao")) & "," & _
                                            d.cdin(tbServico.Rows(m)("preco_tab")) & ")"
                                        d.conecta()

                                        Dim cmdServido As New SqlCommand(strSQLServico, d.con)
                                        cmdServido.ExecuteNonQuery()
                                    End If
                                Next
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub btnOpcoes_Click(sender As System.Object, e As System.EventArgs) Handles btnOpcoes.Click
        processando = True
        Dim f As New frmConfiguracao
        f.ShowDialog()
        f.Dispose()
        processando = False
    End Sub

    Private Sub importaMovimentoMaster()
        Dim tbMovimento As New DataTable
        Dim di As DateTime = DateAdd(DateInterval.Day, c.dias, Now).ToShortDateString & " 00:00:00"
        Dim df As DateTime = Now.ToShortDateString & " 23:59:59"
        Dim wsMovimento As New labonorte_cliente.Service
        Dim i As Integer

        tbMovimento = wsMovimento.importaMovimentoMaster(di, df).Tables(0)

        If tbMovimento.Rows.Count > 0 Then
            For i = 0 To tbMovimento.Rows.Count - 1
                Dim strSQL As String = "select 1 from movimentomaster where cod_movimento = " & tbMovimento.Rows(i)("cod_movimento") & _
                    " and id_filial = " & tbMovimento.Rows(i)("id_filial")
                If master.verifica_existencia_registro(strSQL) = False Then
                    Dim strSQLInsert As String = "Insert Into movimentomaster(cod_movimento,cod_natureza,id_filial,data,doc,id_usuario,concluido) " & _
                    "values(" & tbMovimento.Rows(i)("cod_movimento") & "," & tbMovimento.Rows(i)("cod_natureza") & "," & _
                    tbMovimento.Rows(i)("id_filial") & "," & d.pdtm(tbMovimento.Rows(i)("data")) & "," & d.PStr(tbMovimento.Rows(i)("doc")) & "," & _
                    tbMovimento.Rows(i)("id_usuario") & "," & d.PStr(tbMovimento.Rows(i)("concluido")) & ")"
                    Dim cmd As New SqlCommand(strSQLInsert, d.con)
                    d.conecta()
                    cmd.ExecuteNonQuery()
                    log("Importando Movimento Master da Labonorte:" & tbMovimento.Rows(i)("cod_movimento"))
                    d.desconecta()
                End If
            Next
        End If
    End Sub
End Class
