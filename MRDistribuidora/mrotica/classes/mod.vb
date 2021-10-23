Imports mrotica_util
Imports System.IO
Imports System.Drawing.Printing
Module _mod
    Public Declare Function SetDllDirectoryW Lib "kernel32" (ByVal lpPathName As String) As Long
#Region "Enum"
    Public Enum desenho As Integer
        SV = 21
        PAL = 11
        BF = 30
    End Enum
    Public Enum tipo_Receita As Integer
        VISAO_simples_longe = 1
        VISAO_simples_perto = 2
        BIFOCAL = 3
        PROGRESSIVA = 4
    End Enum
    Public Function lista_tipo_receita() As DataTable
        Dim tb As New DataTable
        tb.Columns.Add("cod_tipo")
        tb.Columns.Add("tipo")
        Dim r As DataRow
        r = tb.NewRow
        r(0) = 1
        r(1) = "Visão Simples Longe"
        tb.Rows.Add(r)

        r = tb.NewRow
        r(0) = 2
        r(1) = "Visão Simples Perto"
        tb.Rows.Add(r)

        r = tb.NewRow
        r(0) = 3
        r(1) = "Bifocal"
        tb.Rows.Add(r)

        r = tb.NewRow
        r(0) = 4
        r(1) = "Progressiva"
        tb.Rows.Add(r)

        Return tb
    End Function
    Public Enum tipo_lente As Integer
        PROGRESSIVA = 11
        UNIFOCAIS = 21
        BIFOCAIS = 30
        INTERMEDIARIAS = 40
    End Enum
    Public Enum tipo_serv As Integer
        LOCAL = 1
        REMOTO = 2
    End Enum
    Public Enum status_item_pedido As Integer
        Aguardando_processamento = 1
        reservado = 2
        baixado_estoque = 3
        cancelado = 4
        devolvido_estoque = 5
        aguardando_pedido = 6
    End Enum
    Public Enum status_pedido As Integer
        Em_Aberto = 1
        Processado_no_estoque = 2
        Faturado = 3
        cancelado = 4
    End Enum
    Public Enum status_sugestao_pedido
        sugerido = 1
        efetuado = 2
        nao_efetuado = 3
        pedido_2 = 4
        cancelado = 5
    End Enum
    Public Enum Fases_os As Integer
        Venda_Pedido = 1
        Verificacao = 2
        Estoque_Aguardando_Processamento = 3
        Estoque_aguardando_Saída_extra = 4
        Estoque_Aguardando_Pedido = 5
        Estoque_Aguardando_Impressão = 6
        Estoque_Aguardando_Laboratório = 7
        Laboratório_aguardando_manuseio = 8
        Laboratório_Surfaçagem = 9
        Laboratório_Controle_de_Qualidade = 10
        Laboratório_Montagem = 11
        Tratamento_Aguardando_Envio = 12
        Tratamento_Aguardando_Retorno = 13
        Concluído_Laboratório = 14
        Expedição = 15
        Recebido_Loja = 16
        Entregue_Cliente = 17
        Estoque_aguardando_troca_base = 18
        Estoque_aguardando_troca_produto = 19
        Transmissao = 20
        Cancelada = 21
        Pausa_estoque = 22
    End Enum
    Public Enum tipo_pedido_compra
        Pedido_auto = 1
        Pedido_normal = 2
    End Enum
    Public Enum pedido_compra_acao
        pedido_novo = 1
        pedido_edicao = 2
        pedido_Entrada = 3
    End Enum
#End Region
#Region "Variaveis"
    Public connStr As String
    'Public con As New Data.SqlClient.SqlConnection
    Public intHandle As IntPtr
    Public strUsuario As String = ""
    Public strNomeCompleto As String = ""
    Public strTipo As String = ""
    Public UserID As String = 1
    Public confServer As String = "servidor"
    Public confMysql As String = "servidor"
    Public confFilial As Integer = 1
    Public confAcrescimoCheque As Double = 2
    Public confModServ As tipo_serv = tipo_serv.LOCAL
    Public rltDespesas As Double
#End Region
#Region "funções comuns"
    Public Function adiciona_zeros(ByVal Valor As String, ByVal digitos As Integer) As String
        Dim i As Integer
        i = Valor.Length
        While i < digitos
            Valor = "0" & Valor
            i = i + 1
        End While
        Return Valor
    End Function
    Public Function cdin(ByVal valor As String) As Object
        If valor = "" Or valor = Nothing Then
            Return "NULL"
        End If
        Return Replace(CDbl(valor), ",", ".")
    End Function
    Public Function cdinShow(ByVal valor As String) As String
        Return Format(Replace(valor, ".", ","), "Currency")
    End Function
    Public Function cdinShow_noRS(ByVal valor As String) As String
        Return Format(valor, "#.##0,00")
    End Function
    Public Function uf(ByVal ctr As ComboBox)
        ctr.Items.Add("AC")
        ctr.Items.Add("AL")
        ctr.Items.Add("AP")
        ctr.Items.Add("AM")
        ctr.Items.Add("BA")
        ctr.Items.Add("CE")
        ctr.Items.Add("DF")
        ctr.Items.Add("ES")
        ctr.Items.Add("GO")
        ctr.Items.Add("MA")
        ctr.Items.Add("MT")
        ctr.Items.Add("MS")
        ctr.Items.Add("MG")
        ctr.Items.Add("PA")
        ctr.Items.Add("PB")
        ctr.Items.Add("PR")
        ctr.Items.Add("PE")
        ctr.Items.Add("PI")
        ctr.Items.Add("RJ")
        ctr.Items.Add("RN")
        ctr.Items.Add("RS")
        ctr.Items.Add("RO")
        ctr.Items.Add("RR")
        ctr.Items.Add("SC")
        ctr.Items.Add("SE")
        ctr.Items.Add("TO")
    End Function
    Public Sub valida_controle_txt(ByVal cn, ByRef ctr)
        If IsDBNull(cn) = False Then ctr.Text = cn Else ctr.Text = ""
    End Sub
    Public Sub valida_controle_din(ByVal cn, ByRef ctr)
        If IsDBNull(cn) = False Then ctr.Text = cdinShow(cn) Else ctr.Text = "R$ 0,00"
    End Sub
    Public Function TiraApostrofe(ByVal strValue As String) As String
        TiraApostrofe = Replace(strValue, "'", "´")
    End Function
    Public Function diaSemanaINTtoSTR(ByVal dia As Integer)
        If dia = 1 Then diaSemanaINTtoSTR = "Domingo"
        If dia = 2 Then diaSemanaINTtoSTR = "Segunda"
        If dia = 3 Then diaSemanaINTtoSTR = "Terça"
        If dia = 4 Then diaSemanaINTtoSTR = "Quarta"
        If dia = 5 Then diaSemanaINTtoSTR = "Quinta"
        If dia = 6 Then diaSemanaINTtoSTR = "Sexta"
        If dia = 7 Then diaSemanaINTtoSTR = "Sábado"
    End Function
    Public Function diaSemanaSTRtoINT(ByVal dia As String)
        If dia = "Domingo" Then diaSemanaSTRtoINT = 1
        If dia = "Segunda" Then diaSemanaSTRtoINT = 2
        If dia = "Terça" Then diaSemanaSTRtoINT = 3
        If dia = "Quarta" Then diaSemanaSTRtoINT = 4
        If dia = "Quinta" Then diaSemanaSTRtoINT = 5
        If dia = "Sexta" Then diaSemanaSTRtoINT = 6
        If dia = "Sábado" Then diaSemanaSTRtoINT = 7

    End Function
    Public Function AVISO(ByVal MSG As String, ByRef FRM As Form, ByVal tipo As frmAviso.tipo_aviso) As frmAviso.respo
        Dim F As New frmAviso
        F.alarme = False
        F.tipo = tipo
        F.lblMSg.Text = MSG
        F.ShowDialog(FRM)
        Return F.resposta
    End Function
    Public Function AVISO(ByVal MSG As String, ByRef FRM As Form, ByVal tipo As frmAviso.tipo_aviso, ByVal alarme As Boolean) As frmAviso.respo
        Dim F As New frmAviso
        F.alarme = alarme
        F.tipo = tipo
        F.lblMSg.Text = MSG
        F.ShowDialog(FRM)
        Return F.resposta
    End Function
    Public Function AVISO(ByVal MSG As String, ByRef FRM As Form, ByVal tipo As frmAviso.tipo_aviso, ByVal alarme As Boolean, ByVal backColor As Color) As frmAviso.respo
        Dim F As New frmAviso
        F.alarme = alarme
        F.BackColor = backColor
        F.tipo = tipo
        F.lblMSg.Text = MSG
        F.ShowDialog(FRM)
        Return F.resposta
    End Function
    Public Sub som_erro()
        My.Computer.Audio.Play(Application.StartupPath & "\sounds\ohoh.wav")
    End Sub
    Public Sub som_ok()
        My.Computer.Audio.Play(Application.StartupPath & "\sounds\blip1.wav")
    End Sub
#End Region
#Region "Trava Destrava Controles"
    Public Sub travaControles(ByVal cont As Object)
        'Dim ctl As Control
        For Each ctl As Control In cont
            If TypeOf ctl Is TextBox And Not ctl.Name = "txtFiltro" Then bloqueiaTXT(ctl)
            If TypeOf ctl Is ComboBox Then bloqueiaCB(ctl)
            If TypeOf ctl Is CheckBox Then BloqueiaChB(ctl)
            If TypeOf ctl Is DateTimePicker Then bloqueiaDT(ctl)
            If TypeOf ctl Is MaskedTextBox Then bloqueiaMSK(ctl)
        Next
    End Sub
    Public Sub DestravaControles(ByVal cont As Object)
        'Dim ctl As Control
        For Each ctl As Control In cont
            If TypeOf ctl Is TextBox Then DesBloqueiaTXT(ctl)
            If TypeOf ctl Is ComboBox Then DesBloqueiaCB(ctl)
            If TypeOf ctl Is CheckBox Then DesBloqueiaChB(ctl)
            If TypeOf ctl Is DateTimePicker Then desbloqueiaDT(ctl)
            If TypeOf ctl Is MaskedTextBox Then DesBloqueiaMSK(ctl)
        Next
    End Sub
    Public Sub bloqueiaDT(ByRef ctl As DateTimePicker)
        ctl.Enabled = False
    End Sub
    Public Sub bloqueiaTXT(ByRef ctl As TextBox)
        ctl.ReadOnly = True
    End Sub
    Public Sub bloqueiaMSK(ByRef ctl As MaskedTextBox)
        ctl.ReadOnly = True
    End Sub
    Public Sub bloqueiaCB(ByRef ctl As ComboBox)
        ctl.Enabled = False
    End Sub
    Public Sub BloqueiaChB(ByRef ctl As CheckBox)
        ctl.Enabled = False
    End Sub
    Public Sub desbloqueiaDT(ByRef ctl As DateTimePicker)
        ctl.Enabled = True
    End Sub
    Public Sub DesBloqueiaTXT(ByRef ctl As TextBox)
        ctl.ReadOnly = False
    End Sub
    Public Sub DesBloqueiaMSK(ByRef ctl As MaskedTextBox)
        ctl.ReadOnly = False
    End Sub
    Public Sub DesBloqueiaCB(ByRef ctl As ComboBox)
        ctl.Enabled = True
    End Sub
    Public Sub DesBloqueiaChB(ByRef ctl As CheckBox)
        ctl.Enabled = True
    End Sub
    Public Sub LimpaControles(ByVal cont As Object)
        'Dim ctl As Control
        For Each ctl As Control In cont
            If TypeOf ctl Is TextBox And Not ctl.Name = "txtFiltro" Then ctl.Text = ""
            If TypeOf ctl Is ComboBox Then ctl.Text = ""
        Next
    End Sub
#End Region
#Region "Outras Funções"
    Public Function rdTexto(ByVal cn)
        If IsDBNull(cn) = True Then Return "" Else Return cn
    End Function
    Public Function rdData(ByVal cn)
        If IsDate(cn) = True Then Return (cn) Else Return Nothing
    End Function
    Public Function rdDinheiro(ByVal cn)
        Try
            If cn.ToString = "" Then Return "0"
        Catch ex As Exception

        End Try
        If IsDBNull(cn) = True Then Return "R$ 0,00" Else Return cdinShow(cn)
    End Function
    Public Function rdNum(ByVal cn As Object)
        'Avalia o valor numérico retornado do banco de dados,
        'se for nulo retorna vazio.
        If IsDBNull(cn) = True Then Return "0" Else Return (cn)
        If IsNumeric(cn) = False Then
            If cn = "" Then Return "0"
            Exit Function
        End If

    End Function
    Public Function wrNum(ByVal cn)
        'Avalia o valor numérico, se estiver vazio,  
        'grava o valor nulo no banco de dados
        If IsDBNull(cn) = True Then
            Return DBNull.Value
        End If
        If cn = Nothing Then
            Return DBNull.Value
        Else
            Return CDbl(cn)
        End If
    End Function
    Public Function wrData(ByVal cn)
        If IsDate(cn) = True Then Return (cn) Else Return DBNull.Value
    End Function
#End Region
#Region "validação"
    Public Sub read_db_texto(ByVal cn, ByRef var)
        If IsDBNull(cn) = False Then var = cn Else var = ""
    End Sub
    Public Sub read_db_num(ByVal cn, ByRef var)
        If IsDBNull(cn) = False Then var = cn Else var = 0
    End Sub
    Public Sub read_db_data(ByVal cn, ByRef var)
        If IsDBNull(cn) = False Then var = cn Else var = Nothing
    End Sub
    Public Sub valida_db_din(ByVal cn, ByRef ctr)
        If IsDBNull(cn) = False Then ctr.text = Format(cn, "currency") Else ctr.text = "R$ 0,00"
    End Sub
    Public Function pnum(ByVal n As Object)
        If n = "" Or n = Nothing Then
            Return Nothing
        Else
            Return n
        End If
    End Function
#End Region
#Region "outras"
    Public Function Nome_mes(ByVal m As Integer)
        Select Case m
            Case 1
                Return "JANEIRO"
            Case 2
                Return "FEVEREIRO"
            Case 3
                Return "MARÇO"
            Case 4
                Return "ABRIL"
            Case 5
                Return "MAIO"
            Case 6
                Return "JUNHO"
            Case 7
                Return "JULHO"
            Case 8
                Return "AGOSTO"
            Case 9
                Return "SETEMBRO"
            Case 10
                Return "OUTUBRO"
            Case 11
                Return "NOVEMBRO"
            Case 12
                Return "DEZEMBRO"
        End Select
    End Function
    Public Function trata_erro(ByVal strErro As String)
        Dim int As Integer
        int = strErro.IndexOf("PRIMARY KEY")
        If int <> -1 Then
            Return "Índice Duplicado, adição não será possível! Verifique se o código que está tentando inserir já existe!"
        Else
            'Return strErro
            Return "Registro não pode ser excluído, por haver relação de integridade de dados."
        End If
    End Function
    Public Function retorna_Chave(ByVal fld As String, ByVal tbl As String, ByVal criterio As String) As Integer
        Dim tb As New DataTable
        Dim sql As String
        Dim v As Integer
        Dim d As New dados
        Try
            sql = "Select max(" & fld & ") as chave from " & tbl & " " & criterio
            d.carrega_Tabela(sql, tb)
            If IsDBNull(tb.Rows(0)("chave")) = True Then v = 0 Else v = tb.Rows(0)("chave")
            Return v + 1
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        tb.Dispose()
    End Function
    Public Function media_movel(ByVal qSoma As Double, ByVal vSoma As Double, ByVal q2 As Double, ByVal v2 As Double)
        'Onde q1 é o saldo físico atual do estoque,
        'v1 é o saldo financeiro atual do estoque, 
        'q2 é a quantidade sendo inserida no estoque,
        'v2 é o preço dos itens sendo inseridos no estoque.
        Dim media As Double
        media = ((vSoma) + (v2 * q2)) / (qSoma + q2)
        Return media
    End Function
    Public Function chkSN(ByVal chk As CheckBox) As String
        If chk.Checked = True Then
            Return "S"
        Else
            Return "N"
        End If
    End Function
    Public Sub chkSN(ByRef chk As CheckBox, ByVal str As String)
        If str = "S" Then
            chk.Checked = True
        Else
            chk.Checked = False
        End If
    End Sub
    Public Function FindValueFromArray(ByVal Values As Object(), ByVal valueToSearch As Object) As Boolean

        Dim retVal As Boolean = False

        Dim myArray As Array = DirectCast(Values, Array)
        Try
            Dim found As Integer = Array.BinarySearch(myArray, valueToSearch)

            If found <> -1 Then

                retVal = True

            End If
        Catch ex As Exception
            retVal = False
        End Try
        

        Return retVal

    End Function
    Public Function trataSTRNFe(ByVal input As String) As String
        Dim strResult As String
        strResult = input.Replace("é", "e")
        strResult = strResult.Replace("É", "E")
        strResult = strResult.Replace("Ê", "E")
        strResult = strResult.Replace("ê", "e")
        strResult = strResult.Replace("á", "a")
        strResult = strResult.Replace("Á", "A")
        strResult = strResult.Replace("â", "a")
        strResult = strResult.Replace("Â", "A")
        strResult = strResult.Replace("à", "a")
        strResult = strResult.Replace("À", "A")
        strResult = strResult.Replace("Õ", "O")
        strResult = strResult.Replace("õ", "o")
        strResult = strResult.Replace("Ô", "O")
        strResult = strResult.Replace("ô", "o")
        strResult = strResult.Replace("Ó", "o")
        strResult = strResult.Replace("ó", "o")
        strResult = strResult.Replace("Í", "I")
        strResult = strResult.Replace("í", "i")
        strResult = strResult.Replace("Î", "I")
        strResult = strResult.Replace("î", "i")
        strResult = strResult.Replace("Ì", "I")
        strResult = strResult.Replace("ì", "i")
        strResult = strResult.Replace("Ú", "U")
        strResult = strResult.Replace("ú", "u")
        strResult = strResult.Replace("Û", "U")
        strResult = strResult.Replace("û", "u")
        strResult = strResult.Replace("Ù", "U")
        strResult = strResult.Replace("ù", "u")
        strResult = strResult.Replace("&", "e")
        strResult = strResult.Replace("Ø", " ")
        Return strResult
    End Function
    Public Function os_Out_labo(ByVal nOS As Integer, ByVal nFilial As Integer) As DataSet
        Dim d As New dados("Ivanildo", "Ea1dd9rm7l9mtd", "192.168.3.250", "mrotica")
        Dim ds As New DataSet
        Dim tTrat As New DataTable
        Dim tOS As New DataTable
        Dim tsql As String
        d.carrega_Tabela("Select * from OS where cod_os = " & nOS & " and id_filial = " & nFilial & "", tOS)
        tsql = "Select tratamentos_os.* , produtos.produto as tratamento " &
        "FROM  tratamentos_os INNER JOIN produtos ON tratamentos_os.cod_produto " &
        "= produtos.cod_produto where " &
        " cod_os = " & nOS & " and id_filial = " &
        nFilial & ""
        d.carrega_Tabela(tsql, tTrat)

        tTrat.TableName = "Tratamentos"
        tOS.TableName = "OS"
        ds.Tables.Add(tOS.Copy)
        ds.Tables.Add(tTrat.Copy)
        Return ds
    End Function
    Public Function ana_maria_baixado(ByVal nOS As Integer, ByVal nFilial As Integer) As String
        Dim d As New dados("Ivanildo", "Ea1dd9rm7l9mtd", "192.168.3.250", "mrotica")
        Dim tsql As String
        tsql = "update OS set cod_fase = 7 where cod_os = " & nOS & " and id_filial = " & nFilial & ""
        Return d.Comando(tsql, False)
    End Function
#End Region
End Module
