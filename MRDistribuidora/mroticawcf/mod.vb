Imports mrotica_util
Imports System.IO
Imports System.Drawing.Printing
Imports System.Data
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
    Public confSQLServer As String
    Public confSQLUser As String
    Public confSQLPass As String
    Public confSQLDB As String
    Public confFilial As Integer = 1
    Public confAcrescimoCheque As Double = 2
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
    Public Function cdinShow(ByVal valor As String) As String
        Return Format(Replace(valor, ".", ","), "Currency")
    End Function
    Public Function cdinShow_noRS(ByVal valor As String) As String
        Return Format(Replace(valor, ".", ","), "#,##0.00")
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
        If IsDBNull(cn) = True Then Return Nothing Else Return (cn)
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
            Return strErro
        End If
    End Function
    Public Function retorna_Chave(ByVal fld As String, ByVal tbl As String, ByVal criterio As String) As Integer
        Dim tb As New DataTable
        Dim sql As String
        Dim v As Integer
        Dim d As New dados()
        Try
            sql = "Select max(" & fld & ") as chave from " & tbl & " " & criterio
            d.carrega_Tabela(sql, tb)
            If IsDBNull(tb.Rows(0)("chave")) = True Then v = 0 Else v = tb.Rows(0)("chave")
            Return v + 1
        Catch ex As Exception
            Return ex.ToString
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
#End Region
End Module
