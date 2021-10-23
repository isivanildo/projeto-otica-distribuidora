Imports System
Imports System.Windows.Forms
Public Class objLentesDiop
#Region "Atributos"
    Private _cod_produto As Integer
    Private _esferico As Object
    Private _cilindrico As Object
    Private _barra As Object
    Public posicao As Integer = 0
    Public max As Integer
    Public chaveCriterio As Object
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
#End Region
#Region "GET SET"
    Public Property cod_produto()
        Get
            cod_produto = _cod_produto
        End Get
        Set(ByVal Value)
            _cod_produto = Value
        End Set
    End Property
    Public Property esferico()
        Get
            esferico = _esferico
        End Get
        Set(ByVal Value)
            _esferico = Value
        End Set
    End Property
    Public Property cilindrico()
        Get
            cilindrico = _cilindrico
        End Get
        Set(ByVal Value)
            _cilindrico = Value
        End Set
    End Property
    Public Property barra()
        Get
            barra = _barra
        End Get
        Set(ByVal Value)
            _barra = Value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select lentes.esferico, " & _
        "lentes.cilindrico,produtos.cod_barra,produtos.cod_produto  from lentes_blocos " & _
        "inner JOIN produtos on lentes_blocos.cod_lente = " & _
        "produtos.cod_lente and lentes_blocos.id_fabricante = " & _
        "produtos.id_fabricante " & _
        "inner join lentes on produtos.cod_produto = lentes.Cod_produto " & _
        "where lentes.cod_produto = 0 ORDER BY lentes.esferico ASC,lentes.cilindrico DESC;"
        Source(sql)
    End Sub
    Public Sub New(ByVal id_fab, ByVal id_lente)
        lista_lentes(id_fab, id_lente)
    End Sub
    Public Sub filtra(ByVal id_fab As Integer, ByVal id_lente As Integer, ByVal sem_barra As Boolean, ByVal ordem_C_E As String, ByVal xcil As String)
        If sem_barra = True Then
            lista_lentes(id_fab, id_lente, True, ordem_C_E, xcil)
        Else
            lista_lentes(id_fab, id_lente, False, ordem_C_E, xcil)
        End If
    End Sub

    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tb)
        max = tb.Rows.Count
    End Sub
    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_produto = tb.Rows(p)("cod_produto")
            _esferico = tb.Rows(p)("esferico")
            _cilindrico = tb.Rows(p)("cilindrico")
            _barra = rdNum(tb.Rows(p)("cod_barra"))
        End If
    End Sub
    Public Sub proximo()
        If Me.posicao = Me.max - 1 Then Exit Sub
        Me.Registro(Me.posicao + 1)
    End Sub
    Public Sub anterior()
        Me.Registro(Me.posicao - 1)
    End Sub
    Public Sub ultimo()
        Me.Registro(Me.max - 1)
    End Sub
    Public Sub primeiro()
        Me.Registro(0)
    End Sub
    Public Sub ultima_posicao()
        Me.Registro(lastPos)
    End Sub
    Public Sub editar()
        OrigemSalvar = "Editar"
    End Sub
#End Region
#Region "Funções"
    Public Function novo()
        lastPos = posicao 'guarda a posição do último Registro
        'Zera Variáveis
        _cod_produto = 0
        _esferico = Nothing
        _cilindrico = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                sql = "Insert into lentes(cod_produto,esferico,cilindrico) " & _
                "Values(" & _
                _cod_produto & "," & d.cdin(_esferico) & "," & d.cdin(_cilindrico) & ")"
                d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_produto") = _cod_produto
            r("esferico") = _esferico
            r("cilindrico") = _cilindrico
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
        End If

        If Me.OrigemSalvar = "Editar" Then
            Try
                sql = "Update lentes set " & _
                "esferico = " & d.cdin(_esferico) & _
                ",cilindrico = " & d.cdin(_cilindrico) & _
                " where cod_produto = " & _cod_produto & ""
                d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("esferico") = _esferico
            r("cilindrico") = _cilindrico
            OrigemSalvar = ""
        End If
    End Function

    Public Function deletar(ByVal id_prod As Integer)
        Dim sql As String
        Dim res As String
        d.conecta()
        sql = "Delete from lentes where cod_produto = " & id_prod & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function lista_lentes(ByVal id_fabricante As Integer, ByVal id_lente As Integer) As DataTable
        sql = "Select lentes.esferico, " & _
        "lentes.cilindrico,produtos.cod_barra,produtos.cod_produto  from lentes_blocos " & _
        "inner JOIN produtos on lentes_blocos.cod_lente = " & _
        "produtos.cod_lente and lentes_blocos.id_fabricante = " & _
        "produtos.id_fabricante " & _
        "inner join lentes on produtos.cod_produto = lentes.Cod_produto " & _
        "where lentes_blocos.id_fabricante = " & id_fabricante & " and " & _
        "lentes_blocos.cod_lente = " & id_lente & _
        " ORDER BY lentes.cilindrico DESC,lentes.esferico DESC"
        Source(sql)
        Return tb
    End Function
    Public Function lista_lentes(ByVal id_fabricante As Integer, ByVal id_lente As Integer, ByVal sem_barras As Boolean, ByVal ordenar_C_E As String, ByVal xCil As String) As DataTable
        Dim barra As String
        Dim ordem As String
        If sem_barras = True Then
            barra = "is null"
        Else
            barra = "is not null"
        End If
        If ordenar_C_E = "C" Then
            ordem = " ORDER BY lentes.cilindrico DESC,lentes.esferico DESC"
        Else
            ordem = " ORDER BY lentes.esferico DESC,lentes.cilindrico DESC"
        End If
        If xCil = "" Then
            sql = "Select lentes.esferico, " & _
        "lentes.cilindrico,produtos.cod_barra,produtos.cod_produto  from lentes_blocos " & _
        "inner JOIN produtos on lentes_blocos.cod_lente = " & _
        "produtos.cod_lente and lentes_blocos.id_fabricante = " & _
        "produtos.id_fabricante " & _
        "inner join lentes on produtos.cod_produto = lentes.Cod_produto " & _
        "where lentes_blocos.id_fabricante = " & id_fabricante & " and " & _
        "lentes_blocos.cod_lente = " & id_lente & " and " & _
        "produtos.cod_barra " & barra & _
        ordem
        Else
            sql = "Select lentes.esferico, " & _
        "lentes.cilindrico,produtos.cod_barra,produtos.cod_produto  from lentes_blocos " & _
        "inner JOIN produtos on lentes_blocos.cod_lente = " & _
        "produtos.cod_lente and lentes_blocos.id_fabricante = " & _
        "produtos.id_fabricante " & _
        "inner join lentes on produtos.cod_produto = lentes.Cod_produto " & _
        "where lentes_blocos.id_fabricante = " & id_fabricante & " and " & _
        "lentes_blocos.cod_lente = " & id_lente & " and " & _
        "produtos.cod_barra " & barra & _
        " and lentes.cilindrico = " & d.cdin(xCil) & _
        ordem
        End If

        
        Source(sql)
        Return tb
    End Function
    Public Function confirma_lente_diop(ByVal x_esf As Double, ByVal x_cil As Double, ByVal x_cod_prod As Integer) As Boolean
        Dim sql As String
        Dim tb_d As New DataTable
        sql = "SELECT cod_produto FROM lentes " & _
        "WHERE (cod_produto = " & x_cod_prod & ") " & _
        "AND (esferico =" & d.cdin(x_esf) & ")" & _
        "AND (cilindrico = " & d.cdin(x_cil) & ")"
        d.carrega_Tabela(sql, tb_d)
        If tb_d.Rows.Count = 1 Then Return True Else Return False

    End Function
    Public Function retorna_cod_lente(ByVal x_cod_tabela As Integer, ByVal x_esf As Double, ByVal x_cil As Double) As Integer
        Dim sql As String
        Dim tb_d As New DataTable
        sql = "SELECT  lentes.cod_produto, lentes_blocos.diametro FROM produtos INNER JOIN " &
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " &
        "produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " &
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " &
        "lentes ON produtos.cod_produto = lentes.cod_produto " &
        "WHERE (lentes_tabela.cod_tabela = " & x_cod_tabela & ") AND " &
        "(lentes.esferico = " & d.cdin(x_esf) & ") AND " &
        "(lentes.cilindrico = " & d.cdin(x_cil) & ")" 
        d.carrega_Tabela(sql, tb_d)
        If tb_d.Rows.Count = 1 Then
            Return tb_d.Rows(0)(0)
        Else
            Return 0
        End If
    End Function

    Public Function retorna_cod_lente(ByVal x_cod_tabela As Integer, ByVal x_esf As Double, ByVal x_cil As Double, ByVal x_diametro As Int16) As Integer
        Dim sql As String
        Dim tb_d As New DataTable
        sql = "SELECT  lentes.cod_produto, lentes_blocos.diametro FROM produtos INNER JOIN " &
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " &
        "produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " &
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " &
        "lentes ON produtos.cod_produto = lentes.cod_produto " &
        "WHERE (lentes_tabela.cod_tabela = " & x_cod_tabela & ") AND " &
        "(lentes.esferico = " & d.cdin(x_esf) & ") AND " &
        "(lentes.cilindrico = " & d.cdin(x_cil) & ") AND " &
        "(lentes_blocos.diametro = " & x_diametro & ") AND " &
        "(lentes_blocos.ativo = 1)"
        d.carrega_Tabela(sql, tb_d)
        If tb_d.Rows.Count = 1 Then
            Return tb_d.Rows(0)(0)
        Else
            Return 0
        End If
    End Function

    Public Function dioptria_existe(ByVal xesf As Double, ByVal xcil As Double, ByVal xcod_tabela As Integer) As Boolean
        Dim tt As New DataTable
        Dim tsql As String
        tsql = "SELECT lentes.esferico, lentes.cilindrico, produtos.cod_lente, lentes_blocos.cod_tabela " & _
        "FROM lentes INNER JOIN produtos ON lentes.cod_produto = produtos.cod_produto " & _
        "INNER JOIN lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE (lentes.esferico =" & d.cdin(xesf) & ") AND " & _
        "(lentes.cilindrico = " & d.cdin(xcil) & ") AND " & _
        "(lentes_blocos.cod_tabela = " & xcod_tabela & ")"
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function Cod_prod_dioptria(ByVal xesf As Double, ByVal xcil As Double, ByVal xcod_tabela As Integer) As Integer
        Dim tt As New DataTable
        Dim tsql As String
        tsql = "SELECT lentes.esferico, lentes.cilindrico, produtos.cod_produto, lentes_blocos.cod_tabela " & _
        "FROM lentes INNER JOIN produtos ON lentes.cod_produto = produtos.cod_produto " & _
        "INNER JOIN lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
        "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
        "WHERE (lentes.esferico =" & d.cdin(xesf) & ") AND " & _
        "(lentes.cilindrico = " & d.cdin(xcil) & ") AND " & _
        "(lentes_blocos.cod_tabela = " & xcod_tabela & ")"
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count = 1 Then
            Return tt.Rows(0)("cod_produto")
        Else
            Return 0
        End If
    End Function
    Public Function tipo(ByVal x_cod_tabela As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select especie from lentes_tabela where cod_tabela = " & x_cod_tabela & _
        ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 1 Then
            Return tt.Rows(0)("especie")
        Else
            Return ""
        End If
    End Function
#End Region
End Class
