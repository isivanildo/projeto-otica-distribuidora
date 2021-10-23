Public Class objForn
#Region "Atributos"
    Private _cod_filial_cliente As Integer
    Private _cod_cliente As Integer
    Private _nome_cliente As String
    Private _endereco As String
    Private _complemento As String
    Private _bairro As String
    Private _municipio As String
    Private _uf As String
    Private _cep As String
    Private _fones As String
    Private _data_ult_alteracao As Date
    Private _observacao As String
    Private _perc_desc As Double
    Private _limite_compra As Double
    Private _limite_credito As Double


    Public posicao As Integer = 0
    Public max As Integer
    Public Criterio_cod_cliente, Criterio_cod_filial As Object
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
#End Region
#Region "GET SET"
    Public Property cod_filial_cliente() As Integer
        Get
            cod_filial_cliente = _cod_filial_cliente
        End Get
        Set(ByVal Value As Integer)
            _cod_filial_cliente = Value
        End Set
    End Property
    Public Property cod_cliente() As Integer
        Get
            cod_cliente = _cod_cliente
        End Get
        Set(ByVal Value As Integer)
            _cod_cliente = Value
        End Set
    End Property
    Public Property nome_cliente() As String
        Get
            nome_cliente = _nome_cliente
        End Get
        Set(ByVal Value As String)
            _nome_cliente = Value
        End Set
    End Property
    Public Property endereco() As String
        Get
            endereco = _endereco
        End Get
        Set(ByVal Value As String)
            _endereco = Value
        End Set
    End Property
    Public Property complemento() As String
        Get
            complemento = _complemento
        End Get
        Set(ByVal Value As String)
            _complemento = Value
        End Set
    End Property
    Public Property bairro() As String
        Get
            bairro = _bairro
        End Get
        Set(ByVal Value As String)
            _bairro = Value
        End Set
    End Property
    Public Property municipio() As String
        Get
            municipio = _municipio
        End Get
        Set(ByVal Value As String)
            _municipio = Value
        End Set
    End Property
    Public Property uf() As String
        Get
            uf = _uf
        End Get
        Set(ByVal Value As String)
            _uf = Value
        End Set
    End Property
    Public Property cep() As String
        Get
            cep = _cep
        End Get
        Set(ByVal Value As String)
            _cep = Value
        End Set
    End Property
    Public Property fones() As String
        Get
            fones = _fones
        End Get
        Set(ByVal Value As String)
            _fones = Value
        End Set
    End Property
    Public Property observacao() As String
        Get
            observacao = _observacao
        End Get
        Set(ByVal Value As String)
            _observacao = Value
        End Set
    End Property
    Public Property data_ult_alteracao() As Object
        Get
            data_ult_alteracao = _data_ult_alteracao
        End Get
        Set(ByVal Value As Object)
            _data_ult_alteracao = Value
        End Set
    End Property
    Public Property perc_desc() As Double
        Get
            perc_desc = _perc_desc
        End Get
        Set(ByVal Value As Double)
            _perc_desc = Value
        End Set
    End Property
    Public Property limite_compra() As Double
        Get
            limite_compra = _limite_compra
        End Get
        Set(ByVal Value As Double)
            _limite_compra = Value
        End Set
    End Property
    Public Property limite_credito() As Double
        Get
            limite_credito = _limite_credito
        End Get
        Set(ByVal Value As Double)
            _limite_credito = Value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from cliente where cod_cliente = 0"
        Source(sql)
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
            _cod_cliente = tb.Rows(p)("cod_cliente")
            _cod_filial_cliente = tb.Rows(p)("cod_filial_cliente")
            _nome_cliente = rdTexto(tb.Rows(p)("nome_cliente"))
            _endereco = rdTexto(tb.Rows(p)("endereco"))
            _complemento = rdTexto(tb.Rows(p)("endereco"))
            _bairro = rdTexto(tb.Rows(p)("bairro"))
            _municipio = rdTexto(tb.Rows(p)("municipio"))
            _uf = rdTexto(tb.Rows(p)("uf"))
            _cep = rdTexto(tb.Rows(p)("cep"))
            _fones = rdTexto(tb.Rows(p)("fones"))
            _observacao = rdTexto(tb.Rows(p)("observacao"))
            '_data_ult_alteracao = rdData(tb.Rows(p)("data_ult_alteracao"))
            _perc_desc = rdNum(tb.Rows(p)("perc_desc"))
            _limite_compra = rdNum(tb.Rows(p)("limite_compra"))
            _limite_credito = rdNum(tb.Rows(p)("limite_credito"))
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
    Public Sub novo()
        lastPos = posicao 'guarda a posição do último Registro
        'Zera Variáveis
        _cod_cliente = Nothing
        _cod_filial_cliente = Nothing
        _nome_cliente = Nothing
        _endereco = Nothing
        _complemento = Nothing
        _bairro = Nothing
        _municipio = Nothing
        _uf = Nothing
        _cep = Nothing
        _fones = Nothing
        _observacao = Nothing
        _data_ult_alteracao = Now.ToString("dd/MM/yyyy")
        _perc_desc = 0
        _limite_compra = 0
        _limite_credito = 0
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Sub
    Public Function Salvar() As String
        Dim cmd As New SqlClient.SqlCommand
        Dim sql As String
        Dim res As Integer 'Quantidade de registros afetados
        d.conecta()
        cmd.Connection = d.con
        If OrigemSalvar = "Novo" Then
            Try
                sql = "Insert cliente(cod_filial_cliente,cod_cliente,nome_cliente," & _
                "endereco,complemento,bairro,municipio,uf,cep,fones," & _
                "observacao,data_ult_alteracao,perc_desc,limite_compra,limite_credito)" & _
                " Values(" & _
                _cod_filial_cliente & "," & _cod_cliente & "," & d.PStr(_nome_cliente) & _
                "," & d.PStr(_endereco) & "," & d.PStr(_complemento) & "," & d.PStr(_bairro) & _
                "," & d.PStr(_municipio) & "," & d.PStr(_uf) & "," & d.PStr(_cep) & "," & _
                "," & d.PStr(_fones) & "," & d.Pdt(_data_ult_alteracao) & "," & _
                d.cdin(_perc_desc) & "," & d.cdin(_limite_compra) & "," & _
                d.cdin(_limite_credito) & ")"
                cmd.CommandText = sql
                res = cmd.ExecuteNonQuery()
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_cliente") = wrNum(_cod_cliente)
            r("cod_filial_cliente") = wrNum(_cod_filial_cliente)
            r("nome_cliente") = rdTexto(_nome_cliente)
            r("endereco") = rdTexto(_endereco)
            r("complemento") = rdTexto(_complemento)
            r("bairro") = rdTexto(_bairro)
            r("municipio") = rdTexto(_municipio)
            r("uf") = rdTexto(_uf)
            r("cep") = rdTexto(_cep)
            r("fones") = rdTexto(_fones)
            r("observacao") = rdTexto(_observacao)
            r("data_ult_alteracao") = rdData(_data_ult_alteracao)
            r("perc_desc") = wrNum(_perc_desc)
            r("limite_compra") = wrNum(_limite_compra)
            r("limite_credito") = wrNum(_limite_credito)
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) adicionado(s) com sucesso!"
        End If
        If Me.OrigemSalvar = "Editar" Then
            Try
                sql = "Update clientes set " & _
                "nome_cliente = " & d.PStr(_nome_cliente) & _
                ",endereco=" & d.PStr(_endereco) & _
                ",complemento=" & d.PStr(_complemento) & _
                ",bairro=" & d.PStr(_bairro) & _
                ",municipio=" & d.PStr(_municipio) & _
                ",uf=" & d.PStr(_uf) & _
                ",cep=" & d.PStr(_cep) & _
                ",fones=" & d.PStr(_fones) & _
                ",observacao =" & d.PStr(_observacao) & _
                ",data_ult_alteracao=" & d.Pdt(Now.ToString("dd/MM/yyyy")) & _
                ",perc_desc=" & d.cdin(_perc_desc) & _
                ",limite_compra = " & d.cdin(_limite_compra) & _
                ",limite_credito = " & d.cdin(_limite_credito) & _
                " where cod_cliente = " & Criterio_cod_cliente & _
                " and cod_filial_cliente = " & Criterio_cod_filial & ""
                cmd.CommandText = sql
                res = cmd.ExecuteNonQuery()
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("nome_cliente") = rdTexto(_nome_cliente)
            r("endereco") = rdTexto(_endereco)
            r("complemento") = rdTexto(_complemento)
            r("bairro") = rdTexto(_bairro)
            r("municipio") = rdTexto(_municipio)
            r("uf") = rdTexto(_uf)
            r("cep") = rdTexto(_cep)
            r("fones") = rdTexto(_fones)
            r("observacao") = rdTexto(_observacao)
            r("data_ult_alteracao") = rdData(_data_ult_alteracao)
            r("perc_desc") = wrNum(_perc_desc)
            r("limite_compra") = wrNum(_limite_compra)
            r("limite_credito") = wrNum(_limite_credito)
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal cod_cliente As Integer, ByVal cod_filial_cliente As Integer)
        Dim cmd As New SqlClient.SqlCommand
        Dim res As Integer
        d.conecta()
        cmd.Connection = d.con
        cmd.CommandText = "Delete from cliente where cod_cliente = " & cod_cliente & _
        " and cod_filial_cliente = " & cod_filial_cliente & ""
        Try
            res = cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function lista_Fornecedores(ByVal crit_nome As String) As DataTable
        sql = "Select * from fornecedor where fornecedor like '%" & crit_nome & "%'"
        Source(sql)
        Return tb
    End Function
    Public Function retorna_nome(ByVal x_cod As Integer) As String
        Dim sql As String
        Dim tb As New DataTable
        sql = "select fornecedor from fornecedor where cod_fornecedor = " & x_cod & ""
        d.carrega_Tabela(sql, tb)
        If tb.Rows.Count > 0 Then
            Return tb.Rows(0)(0)
        Else
            Return "Não Encontrado!"
        End If
    End Function

#End Region
End Class
