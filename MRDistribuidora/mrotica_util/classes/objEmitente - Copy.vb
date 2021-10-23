Public Class objEmitente
#Region "Atributos"
    Private _codigo As Integer
    Private _RazaoSocial As Object
    Private _Fantasia As Object
    Private _endereco As Object
    Private _numero As Object
    Private _complemento As Object
    Private _cidade As Object
    Private _bairro As Object
    Private _cep As Object
    Private _telefone As Object
    Private _cnpj_cpf As Object
    Private _i_estadual As Object
    Private _email As Object

    Public posicao As Integer = 0
    Public max As Integer
    Public chaveCriterio As Object
    Public tabela As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
#End Region
#Region "GET SET"
    Public Property codigo() As Integer
        Get
            codigo = _codigo
        End Get
        Set(ByVal Value As Integer)
            _codigo = Value
        End Set
    End Property
    Public Property razaoSocial() As String
        Get
            razaoSocial = _RazaoSocial
        End Get
        Set(ByVal Value As String)
            _RazaoSocial = Value
        End Set
    End Property
    Public Property fantasia()
        Get
            fantasia = _Fantasia
        End Get
        Set(ByVal Value)
            _Fantasia = Value
        End Set
    End Property
    Public Property endereco()
        Get
            endereco = _endereco
        End Get
        Set(ByVal Value)
            _endereco = Value
        End Set
    End Property
    Public Property numero()
        Get
            numero = _numero
        End Get
        Set(ByVal Value)
            _numero = Value
        End Set
    End Property
    Public Property complemento()
        Get
            complemento = _complemento
        End Get
        Set(ByVal Value)
            _complemento = Value
        End Set
    End Property
    Public Property bairro()
        Get
            bairro = _bairro
        End Get
        Set(ByVal value)
            _bairro = value
        End Set
    End Property
    Public Property cidade()
        Get
            cidade = _cidade
        End Get
        Set(ByVal Value)
            _cidade = Value
        End Set
    End Property
    Public Property cep()
        Get
            cep = _cep
        End Get
        Set(ByVal Value)
            _cep = Value
        End Set
    End Property
    Public Property telefone()
        Get
            telefone = _telefone
        End Get
        Set(ByVal value)
            _telefone = value
        End Set
    End Property
    Public Property cnpj_cpf()
        Get
            cnpj_cpf = _cnpj_cpf
        End Get
        Set(ByVal Value)
            _cnpj_cpf = Value
        End Set
    End Property
    Public Property email()
        Get
            email = _email
        End Get
        Set(ByVal value)
            _email = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from emitente"
        Source(sql)
    End Sub
    Public Sub New(ByVal id_filial)
        sql = "Select * from emitente where codigo = " & id_filial & ""
        Source(sql)

    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()

    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tabela)
        max = tabela.Rows.Count
        Registro(0)
    End Sub
    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _codigo = tabela.Rows(p)("codigo")
            _RazaoSocial = tabela.Rows(p)("RazaoSocial")
            _Fantasia = tabela.Rows(p)("fantasia")
            _endereco = tabela.Rows(p)("endereco")
            _numero = rdNum(tabela.Rows(p)("numero"))
            _complemento = tabela.Rows(p)("complemento")
            _bairro = rdTexto(tabela.Rows(p)("bairro"))
            _cidade = tabela.Rows(p)("cidade")
            _cep = rdTexto(tabela.Rows(p)("cep"))
            _telefone = rdTexto(tabela.Rows(p)("telefone"))
            _email = rdTexto(tabela.Rows(p)("email"))

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
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Function
    Public Function cidadeStr(ByVal cod_cidade As Long) As String
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "Select * from cidades where codigo = " & cod_cidade & ""
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("cidade") & "-" & tt.Rows(0)("UF")
        Else
            Return ""
        End If
    End Function
    Public Function Salvar() As String
    End Function
#End Region
End Class
