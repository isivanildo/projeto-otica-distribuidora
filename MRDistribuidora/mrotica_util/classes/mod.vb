Imports System.IO
Imports System.Runtime.InteropServices
Module _mod
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
        Dim tabela As New DataTable
        tabela.Columns.Add("cod_tipo")
        tabela.Columns.Add("tipo")
        Dim r As DataRow
        r = tabela.NewRow
        r(0) = 1
        r(1) = "Visão Simples Longe"
        tabela.Rows.Add(r)

        r = tabela.NewRow
        r(0) = 2
        r(1) = "Visão Simples Perto"
        tabela.Rows.Add(r)

        r = tabela.NewRow
        r(0) = 3
        r(1) = "Bifocal"
        tabela.Rows.Add(r)

        r = tabela.NewRow
        r(0) = 4
        r(1) = "Progressiva"
        tabela.Rows.Add(r)

        Return tabela
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
    Public Enum tiposalvar
        Normal = 1
        Transaction = 2
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
    Public confUser As String
    Public confSenha As String
    Public confServidor As String
    Public confPorta As String
    Public confUsuarioDB As String
    Public confSenhaDB As String
    Public confExportar As String
    Public confLog As String
    Public confBanco As String
    Public confDBBazar As String
    Public confDias As Integer
    Public confFilial As Integer
    Public confLabMont As Integer
    Public confLabSurf As Integer = 1
    Public confAcrescimoCheque As Double = 2
    Public confBloqueio As String
    Public imagemRel As String
    Public confModServ As tipo_serv = tipo_serv.LOCAL
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
    Public Function cdinN(ByVal valor As String) As Object
        Dim vr As String
        If valor = "" Or valor = Nothing Or valor = "0" Then
            Return "0"
        End If
        vr = Replace(Convert.ToDecimal(valor).ToString("N4"), ".", "")
        Return vr.Replace(",", ".")
    End Function
    Public Function cdinShow(ByVal valor As String) As String
        Return Format(Replace(valor, ".", ","), "Currency")
    End Function
    Public Function cdinShow_noRS(ByVal valor As String) As String
        Return Format(Replace(valor, ".", ","), "Number")
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
        Try
            cn = CStr(cn)
            If cn = "" Then Return 0
        Catch ex As Exception

        End Try

        Try
            If IsDBNull(cn) = True Then Return Nothing Else Return (cn)
        Catch ex As Exception

        End Try

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
    Public Function extrai_data_dmy(ByVal dt As Date) As String
        Dim ret As String
        ret = dt.Day & "/" & dt.Month & "/" & dt.Year
        Return ret
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
            Return strErro
        End If
    End Function
    Public Function retorna_Chave(ByVal fld As String, ByVal tbl As String, ByVal criterio As String) As Long
        Dim tabela As New DataTable
        Dim sql As String
        Dim v As Long
        Dim d As New dados
        Try
            sql = "Select max(" & fld & ") as chave from " & tbl & " " & criterio
            d.carrega_Tabela(sql, tabela)
            If tabela.Rows.Count = 0 Then
                Return 1
                Exit Function
            End If
            If IsDBNull(tabela.Rows(0)("chave")) = True Then v = 0 Else v = tabela.Rows(0)("chave")
            Return v + 1
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        tabela.Dispose()
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
        strResult = strResult.Replace("Ã", "A")
        strResult = strResult.Replace("ã", "a")
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
        strResult = strResult.Replace("Ø", "")
        Return strResult
    End Function
    Public Function limpa_fone(ByVal fone As String) As String
        Dim strResult As String
        strResult = fone.Replace("(", "")
        strResult = strResult.Replace(")", "")
        strResult = strResult.Replace("-", "")
        strResult = strResult.Replace(" ", "")
        strResult = strResult.Trim
        Return strResult
    End Function
#End Region
    <DllImport("DllInscE32.dll")> _
    Public Function ConsisteInscricaoEstadual(ByVal vInsc As String, ByVal vUF As String) As Integer
    End Function



End Module
