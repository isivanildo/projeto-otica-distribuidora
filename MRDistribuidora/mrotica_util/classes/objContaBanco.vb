Imports System.Text
Public Class objContaBanco
#Region "Atributos"
    Private _Banco As Integer
    Private _NomeBanco As String
    Private _NomeAgencia As String
    Private _codigobanco As Int32
    Private _DvBanco As String
    Private _codigoAgencia As Int32
    Private _DVagencia As String
    Private _Carteira As String
    Private _contaCorrente As Int64
    Private _DVConta As String
    Private _DVAgenciaConta As String
    Private _cedente As Int64
    Private _DVCedente As String
    Private _endereco As String
    Private _bairro As String
    Private _cep As String
    Private _cidade As String
    Private _uf As String
    Private _convenio As String
    Private _mensagemPagamento1 As String
    Private _mensagemPagamento2 As String
    Private _mensagemBoleto As String
    Private _emitente As Int32
    Private _saldo As Double
    Private _nosso_inicial As Int64
    Private _sequencial_remessa As Int64 = 1
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
    Public Property banco01de25() As Integer
        Get
            banco01de25 = _Banco
        End Get
        Set(ByVal Value As Integer)
            _Banco = Value
        End Set
    End Property
    Public Property nomeBanco02de25() As Double
        Get
            nomeBanco02de25 = _NomeBanco
        End Get
        Set(ByVal Value As Double)
            _NomeBanco = Value
        End Set
    End Property
    Public Property nomeagencia03de25()
        Get
            nomeagencia03de25 = _NomeAgencia
        End Get
        Set(ByVal Value)
            _NomeAgencia = Value
        End Set
    End Property
    Public Property codigoBanco04de25()
        Get
            codigoBanco04de25 = _codigobanco
        End Get
        Set(ByVal Value)
            _codigobanco = Value
        End Set
    End Property
    Public Property DVBanco05de25()
        Get
            DVBanco05de25 = _DvBanco
        End Get
        Set(ByVal Value)
            _DvBanco = Value
        End Set
    End Property
    Public Property codigoAgencia06de25()
        Get
            codigoAgencia06de25 = _codigoAgencia
        End Get
        Set(ByVal Value)
            _codigoAgencia = Value
        End Set
    End Property
    Public Property DVAgencia07de25()
        Get
            DVAgencia07de25 = _DVagencia
        End Get
        Set(ByVal Value)
            _DVagencia = Value
        End Set
    End Property
    Public Property carteira08de25()
        Get
            carteira08de25 = _Carteira
        End Get
        Set(ByVal Value)
            _Carteira = Value
        End Set
    End Property
    Public Property ContaCorrente09de25()
        Get
            ContaCorrente09de25 = _contaCorrente
        End Get
        Set(ByVal Value)
            _contaCorrente = Value
        End Set
    End Property
    Public Property DVConta10de25()
        Get
            DVConta10de25 = _DVConta
        End Get
        Set(ByVal Value)
            _DVConta = Value
        End Set
    End Property
    Public Property DVAgenciaConta11de25()
        Get
            DVAgenciaConta11de25 = _DVAgenciaConta
        End Get
        Set(ByVal Value)
            _DVAgenciaConta = Value
        End Set
    End Property
    Public Property cedente12de25()
        Get
            cedente12de25 = _cedente
        End Get
        Set(ByVal Value)
            _cedente = Value
        End Set
    End Property
    Public Property DVCedente13de25()
        Get
            DVCedente13de25 = _DVCedente
        End Get
        Set(ByVal value)
            _DVCedente = value
        End Set
    End Property
    Public Property endereco14de25()
        Get
            endereco14de25 = _endereco
        End Get
        Set(ByVal value)
            _endereco = value
        End Set
    End Property
    Public Property Bairro15de25()
        Get
            Bairro15de25 = _bairro
        End Get
        Set(ByVal value)
            _bairro = value
        End Set
    End Property
    Public Property CEP16de25()
        Get
            CEP16de25 = _cep
        End Get
        Set(ByVal value)
            _cep = value
        End Set
    End Property
    Public Property cidade17de25()
        Get
            cidade17de25 = _cidade
        End Get
        Set(ByVal value)
            _cidade = value
        End Set
    End Property
    Public Property UF18de25()
        Get
            UF18de25 = _uf
        End Get
        Set(ByVal value)
            _uf = value
        End Set
    End Property
    Public Property convenio19de25()
        Get
            convenio19de25 = _convenio
        End Get
        Set(ByVal value)
            _convenio = value
        End Set
    End Property
    Public Property MensagemPagamento1_20de25()
        Get
            MensagemPagamento1_20de25 = _mensagemPagamento1
        End Get
        Set(ByVal value)
            _mensagemPagamento1 = value
        End Set
    End Property
    Public Property MensagemPagamento2_21de25()
        Get
            MensagemPagamento2_21de25 = _mensagemPagamento2
        End Get
        Set(ByVal value)
            _mensagemPagamento2 = value
        End Set
    End Property
    Public Property Mensagemboleto_22de25()
        Get
            Mensagemboleto_22de25 = _mensagemBoleto
        End Get
        Set(ByVal value)
            _mensagemBoleto = value
        End Set
    End Property
    Public Property emitente_23de25()
        Get
            emitente_23de25 = _emitente
        End Get
        Set(ByVal value)
            _emitente = value
        End Set
    End Property
    Public Property Saldo_24de25()
        Get
            Saldo_24de25 = _saldo
        End Get
        Set(ByVal value)
            _saldo = value
        End Set
    End Property
    Public Property nosso_inicial_25de25()
        Get
            nosso_inicial_25de25 = _nosso_inicial
        End Get
        Set(ByVal value)
            _nosso_inicial = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        Dim sql As String
        sql = "Select * from conta_Banco where banco = 0"
        Source(sql)
    End Sub
    Public Sub filtra(ByVal cod_emitente As Int32, ByVal cod_banco As Int32)
        sql = "Select * from conta_Banco where emitente = " & cod_emitente & _
        " and codigoBanco = " & cod_banco & ""
        Source(sql)
    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tabela)
        max = tabela.Rows.Count
        primeiro()
    End Sub
    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _Banco = tabela.Rows(p)("banco")
            _NomeBanco = tabela.Rows(p)("nomeBanco")
            _NomeAgencia = tabela.Rows(p)("nomeagencia")
            _codigobanco = rdNum(tabela.Rows(p)("codigoBanco"))
            _DvBanco = rdTexto(tabela.Rows(p)("dvBanco"))
            _codigoAgencia = rdNum(tabela.Rows(p)("codigoAgencia"))
            _DVagencia = rdTexto(tabela.Rows(p)("dvagencia"))
            _Carteira = rdTexto(tabela.Rows(p)("carteira"))
            _contaCorrente = rdNum(tabela.Rows(p)("contacorrente"))
            _DVConta = rdTexto(tabela.Rows(p)("dvconta"))
            _DVAgenciaConta = rdTexto(tabela.Rows(p)("dvagenciaconta"))
            _cedente = rdNum(tabela.Rows(p)("cedente"))
            _DVCedente = rdTexto(tabela.Rows(p)("dvcedente"))
            _endereco = rdTexto(tabela.Rows(p)("endereco"))
            _bairro = rdTexto(tabela.Rows(p)("bairro"))
            _cep = rdTexto(tabela.Rows(p)("cep"))
            _cidade = rdTexto(tabela.Rows(p)("cidade"))
            _uf = rdTexto(tabela.Rows(p)("uf"))
            _convenio = rdTexto(tabela.Rows(p)("convenio"))
            _mensagemPagamento1 = rdTexto(tabela.Rows(p)("mensagemPagamento1"))
            _mensagemPagamento2 = rdTexto(tabela.Rows(p)("mensagemPagamento2"))
            _mensagemBoleto = rdTexto(tabela.Rows(p)("mensagemboleto"))
            _emitente = rdNum(tabela.Rows(p)("emitente"))
            _saldo = rdNum(tabela.Rows(p)("saldo"))
            _nosso_inicial = rdNum(tabela.Rows(p)("nosso_inicial"))
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
        _Banco = Nothing
        _NomeBanco = Nothing
        _NomeAgencia = Nothing
        _codigobanco = Nothing
        _DvBanco = Nothing
        _codigoAgencia = Nothing
        _DVagencia = Nothing
        _Carteira = Nothing
        _contaCorrente = Nothing
        _DVConta = Nothing
        _DVAgenciaConta = Nothing
        _cedente = Nothing
        _DVCedente = Nothing
        _endereco = Nothing
        _bairro = Nothing
        _cep = Nothing
        _cidade = Nothing
        _uf = Nothing
        _convenio = Nothing
        _mensagemPagamento1 = Nothing
        _mensagemPagamento2 = Nothing
        _mensagemBoleto = Nothing
        _emitente = Nothing
        _saldo = Nothing
        _nosso_inicial = Nothing
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Sub
    Public Function Salvar() As String
        Dim sql As New StringBuilder
        Dim res As String 'Quantidade de registros afetados
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                _Banco = retorna_Chave("banco", "conta_banco", "")
                sql.Append("Insert into Bancos ")
                sql.Append("( Banco, NomeBanco, NomeAgencia, ")
                sql.Append("CodigoBanco, DvBanco, CodigoAgencia, DvAgencia, Carteira, ")
                sql.Append("ContaCorrente, DvConta, Endereco, Bairro, ")
                sql.Append("CEP, Cidade, UF, ")
                sql.Append("Convenio, DvAgenciaConta, MensagemPagamento1, ")
                sql.Append("Cedente, DvCedente, ")
                sql.Append("MensagemPagamento2, MensagemBoleto, Emitente, Saldo,nosso_inicial) ")
                sql.Append("VALUES ( ")
                sql.Append(_Banco + ", '" + d.PStr(_NomeBanco) + "', '" + d.PStr(_NomeAgencia) + "', ")
                sql.Append(_codigobanco + ", '" + d.PStr(_DvBanco) + "', " + _codigoAgencia + ", '" + d.PStr(_DVagencia) + "', '" + d.PStr(_Carteira) + "', ")
                sql.Append(_contaCorrente + ", '" + d.PStr(_DVConta) + "', '" + d.PStr(_endereco) + "', '" + d.PStr(_bairro) + "', '")
                sql.Append(d.PStr(_cep) + "', '" + d.PStr(_cidade) + "', '" + d.PStr(_uf) + "', '")
                sql.Append(d.PStr(_convenio) + "', '" + d.PStr(_DVAgenciaConta) + "', '" + d.PStr(_mensagemPagamento1) + "', ")
                sql.Append(_cedente + ", '" + d.PStr(_DVCedente) + "', '")
                sql.Append(d.PStr(_mensagemPagamento2) + "', '" + d.PStr(_mensagemBoleto) + "', " + _emitente + ",")
                sql.Append(d.PStr(_nosso_inicial) + ")")
                res = d.Comando(sql.ToString, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql.ToString 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tabela.NewRow
            r("Banco") = _Banco
            r("NomeBanco") = rdTexto(_NomeBanco)
            r("NomeAgencia") = rdTexto(_NomeAgencia)
            r("codigobanco") = rdNum(_codigobanco)
            r("DvBanco") = rdTexto(_DvBanco)
            r("codigoAgencia") = rdTexto(_codigoAgencia)
            r("DVagencia") = rdTexto(_DVagencia)
            r("Carteira") = rdTexto(_Carteira)
            r("contaCorrente") = rdNum(_contaCorrente)
            r("DVConta") = rdTexto(_DVConta)
            r("DVAgenciaConta") = rdTexto(_DVAgenciaConta)
            r("cedente") = rdNum(_cedente)
            r("DVCedente") = rdTexto(_DVCedente)
            r("endereco") = rdTexto(_endereco)
            r("bairro") = rdTexto(_bairro)
            r("cep") = rdTexto(_cep)
            r("cidade") = rdTexto(_cidade)
            r("uf") = rdTexto(_uf)
            r("convenio") = rdTexto(_convenio)
            r("mensagemPagamento1") = rdTexto(_mensagemPagamento1)
            r("mensagemPagamento2") = rdTexto(_mensagemPagamento2)
            r("mensagemBoleto") = rdTexto(_mensagemBoleto)
            r("emitente") = rdNum(_emitente)
            r("saldo") = rdNum(_saldo)
            r("nosso_inicial") = rdNum(_nosso_inicial)
            tabela.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) adicionado(s) com sucesso!"
        Else
            Try
                sql.Append("Update Bancos Set ")
                sql.Append("NomeBanco='" + d.PStr(_NomeBanco) + "', ")
                sql.Append("NomeAgencia='" + d.PStr(_NomeAgencia) + "', ")
                sql.Append("CodigoBanco=" + _codigobanco.ToString + ", ")
                sql.Append("DvBanco='" + d.PStr(_DvBanco) + "', ")
                sql.Append("CodigoAgencia=" + _codigoAgencia.ToString + ", ")
                sql.Append("DvAgencia='" + d.PStr(_DVagencia) + "', ")
                sql.Append("Carteira='" + d.PStr(_Carteira) + "', ")
                sql.Append("ContaCorrente=" + _contaCorrente.ToString + ", ")
                sql.Append("DvConta='" + d.PStr(_DVConta) + "', ")
                sql.Append("Endereco='" + d.PStr(_endereco) + "', ")
                sql.Append("Bairro='" + d.PStr(_bairro) + "', ")
                sql.Append("CEP='" + d.PStr(_cep) + "', ")
                sql.Append("Cidade='" + d.PStr(_cidade) + "', ")
                sql.Append("UF = '" + d.PStr(_uf) + "', ")
                sql.Append("Convenio='" + d.PStr(_convenio) + "', ")
                sql.Append("Cedente=" + _cedente.ToString + ", ")
                sql.Append("DvCedente='" + d.PStr(_DVCedente) + "', ")
                sql.Append("DvAgenciaConta='" + d.PStr(_DVAgenciaConta) + "', ")
                sql.Append("MensagemPagamento1='" + d.PStr(_mensagemPagamento1) + "', ")
                sql.Append("MensagemPagamento2='" + d.PStr(_mensagemPagamento2) + "', ")
                sql.Append("MensagemBoleto='" + d.PStr(_mensagemBoleto) + "', ")
                sql.Append("Emitente=" + _emitente.ToString + " ")
                sql.Append("nosso_inicial =" + _nosso_inicial.ToString + " ")
                sql.Append("WHERE Banco = " + _Banco)
                res = d.Comando(sql.ToString, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql.ToString  'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tabela.Rows(posicao)
            r("Banco") = _Banco
            r("NomeBanco") = rdTexto(_NomeBanco)
            r("NomeAgencia") = rdTexto(_NomeAgencia)
            r("codigobanco") = rdNum(_codigobanco)
            r("DvBanco") = rdTexto(_DvBanco)
            r("codigoAgencia") = rdTexto(_codigoAgencia)
            r("DVagencia") = rdTexto(_DVagencia)
            r("Carteira") = rdTexto(_Carteira)
            r("contaCorrente") = rdNum(_contaCorrente)
            r("DVConta") = rdTexto(_DVConta)
            r("DVAgenciaConta") = rdTexto(_DVAgenciaConta)
            r("cedente") = rdNum(_cedente)
            r("DVCedente") = rdTexto(_DVCedente)
            r("endereco") = rdTexto(_endereco)
            r("bairro") = rdTexto(_bairro)
            r("cep") = rdTexto(_cep)
            r("cidade") = rdTexto(_cidade)
            r("uf") = rdTexto(_uf)
            r("convenio") = rdTexto(_convenio)
            r("mensagemPagamento1") = rdTexto(_mensagemPagamento1)
            r("mensagemPagamento2") = rdTexto(_mensagemPagamento2)
            r("mensagemBoleto") = rdTexto(_mensagemBoleto)
            r("emitente") = rdNum(_emitente)
            r("saldo") = rdNum(_saldo)
            OrigemSalvar = ""
            Return "OK:" & res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function deletar(ByVal banco As Integer)
        Dim res As String
        Dim sql As String
        d.conecta()
        sql = "Delete from conta_banco where banco = " & banco & ""

        res = d.Comando(sql, True)
        Me.refreshData()
        Me.primeiro()
        Return res & " Registros foram apagados!"
    End Function
    Public Function atualiza_nosso_inicial()
        Dim tsql As String
        _nosso_inicial = retorna_Chave("nosso_inicial", "conta_Banco", " where banco = " & _Banco & "")
        tsql = "update conta_banco set nosso_inicial = " & _nosso_inicial & _
        " where banco = " & _Banco
        Return d.Comando(tsql, True)
    End Function
    Public Function NossoNumero() As String
        Dim Banco As Int16 = Convert.ToInt16(_codigobanco)
        Dim Num As Int64 = _nosso_inicial + 1
        'Controle.PegaInicial("Nosso" & String.Format("{0:d3}", Cod_Banco) & "-" & String.Format("{0:d3}", Emitente))
        Dim Nosso As String = ""
        Select Case Banco
            Case 1
                'Banco do Brasil
                If True Then
                    Dim Conv As Integer = _convenio
                    Dim NN As String = String.Format("{0:d7}", Conv) & String.Format("{0:d10}", Num)
                    Nosso = NN & String.Format("{0:d1}", Mod11BancoBrasil(NN))
                End If
                Exit Select

            Case 104
                'Caixa
                If True Then
                    Dim NN As String = "24" & String.Format("{0:d15}", Num)
                    Dim M As Integer = 2
                    Dim D As Integer = 0
                    For I As Integer = 0 To 16
                        If M = 1 Then
                            M = 9
                        End If
                        D += M * Convert.ToInt16(NN.Substring(I, 1))
                        M -= 1
                    Next
                    D = D Mod 11
                    D = 11 - D
                    If D = 10 Then
                        Nosso = NN & "0"
                    Else
                        Nosso = NN & String.Format("{0:d1}", D)
                    End If
                    Exit Select
                End If
            Case 237
                'Bradesco
                If True Then
                    Dim Cart As Integer = _Carteira
                    Dim NN As String = String.Format("{0:d2}", Cart) & String.Format("{0:d11}", Num)
                    Dim M As Integer = 2
                    Dim D As Integer = 0
                    For I As Integer = 0 To 12
                        If M = 1 Then
                            M = 7
                        End If
                        D += M * Convert.ToInt16(NN.Substring(I, 1))
                        M -= 1
                    Next
                    D = D Mod 11
                    D = 11 - D
                    NN = String.Format("{0:d11}", Num)
                    If D = 10 Then
                        Nosso = NN & "P"
                    ElseIf D = 11 Then
                        Nosso = NN & "0"
                    Else
                        Nosso = NN & String.Format("{0:d1}", D)
                    End If
                    Exit Select
                End If
        End Select
        Return Nosso
    End Function
    Public Function CalculaDv(ByVal Texto As String, ByVal Inicial As Integer) As String
        Dim D As Integer = 0, M As Integer = Inicial
        Dim N As String = ""
        For I As Integer = 0 To Texto.Length - 1
            D = M * Convert.ToInt16(Texto.Substring(I, 1))
            N += D.ToString()
            If M = 2 Then
                M = 1
            Else
                M = 2
            End If
        Next
        D = 0
        For I As Integer = 0 To N.Length - 1
            D += Convert.ToInt16(N.Substring(I, 1))
        Next
        D = D Mod 10
        D = 10 - D
        If D = 10 Then
            D = 0
        End If
        Return D.ToString()
    End Function
    Public Function FormataCodigoBarra(ByVal Vencimento As DateTime, ByVal Valor As Decimal, ByVal NossoNumero As String) As String
        Dim valorBoleto As String = Valor.ToString("f").Replace(",", "").Replace(".", "")
        Dim cod_barra As String
        Dim dv As Int16
        valorBoleto = adiciona_zeros(valorBoleto, 10)

        '#Region "Carteira 17"
        If _Carteira.StartsWith("17") Then
            If _convenio.ToString().Length = 7 Then
                cod_barra = String.Format("{0}{1}{2}{3}{4}{5}{6}", adiciona_zeros(_codigobanco, 3), 9, FatorVencimento(Vencimento), valorBoleto, "000000", _
                 NossoNumero.Substring(0, 17), adiciona_zeros(_Carteira.Substring(0, 2), 2))
            End If

        End If
        '#End Region

        dv = Mod11(cod_barra, 9)
        cod_barra = Strings.Left(cod_barra, 4) & dv & cod_barra.Substring(4)
        Return cod_barra
    End Function

    Public Function FormataLinhaDigitavel(ByVal COD_BARRA As String) As String
        Dim cmplivre As String = String.Empty
        Dim campo1 As String = String.Empty
        Dim campo2 As String = String.Empty
        Dim campo3 As String = String.Empty
        Dim campo4 As String = String.Empty
        Dim campo5 As String = String.Empty
        Dim icampo5 As Long = 0
        Dim digitoMod As Integer = 0
        Dim digitavel As String

        '
        '            Campos 1 (AAABC.CCCCX):
        '            A = Código do Banco na Câmara de Compensação “001”
        '            B = Código da moeda "9" (*)
        '            C = Posição 20 a 24 do código de barras
        '            X = DV que amarra o campo 1 (Módulo 10, contido no Anexo 7)
        '             


        cmplivre = Strings.Mid(COD_BARRA, 20, 25)

        campo1 = Strings.Left(COD_BARRA, 4) & Strings.Mid(cmplivre, 1, 5)
        digitoMod = Mod10(campo1)
        campo1 = campo1 + digitoMod.ToString()
        campo1 = Strings.Mid(campo1, 1, 5) & Strings.Mid(campo1, 6, 5)
        '
        '            Campo 2 (DDDDD.DDDDDY)
        '            D = Posição 25 a 34 do código de barras
        '            Y = DV que amarra o campo 2 (Módulo 10, contido no Anexo 7)
        '             

        campo2 = Strings.Mid(cmplivre, 6, 10)
        digitoMod = Mod10(campo2)
        campo2 = campo2 & digitoMod.ToString()
        campo2 = Strings.Mid(campo2, 1, 5) & Strings.Mid(campo2, 6, 6)


        '
        '            Campo 3 (EEEEE.EEEEEZ)
        '            E = Posição 35 a 44 do código de barras
        '            Z = DV que amarra o campo 3 (Módulo 10, contido no Anexo 7)
        '             

        campo3 = Strings.Mid(cmplivre, 16, 10)
        digitoMod = Mod10(campo3)
        campo3 = campo3 & digitoMod
        campo3 = Strings.Mid(campo3, 1, 5) & Strings.Mid(campo3, 6, 6)

        '
        '            Campo 4 (K)
        '            K = DV do Código de Barras (Módulo 11, contido no Anexo 10)
        '             

        campo4 = Strings.Mid(COD_BARRA, 5, 1)

        '
        '            Campo 5 (UUUUVVVVVVVVVV)
        '            U = Fator de Vencimento ( Anexo 10)
        '            V = Valor do Título (*)
        '             

        icampo5 = Convert.ToInt64(Strings.Mid(COD_BARRA, 6, 14))

        If icampo5 = 0 Then
            campo5 = "000"
        Else
            campo5 = icampo5.ToString()
        End If
        digitavel = campo1 & campo2 & campo3 & campo4 & campo5
        Return digitavel
    End Function

#Region "Mod"
    Friend Shared Function Mod10(ByVal seq As String) As Integer
        ' Variáveis
        '             * -------------
        '             * d - Dígito
        '             * s - Soma
        '             * p - Peso
        '             * b - Base
        '             * r - Resto
        '             


        Dim d As Integer, s As Integer = 0, p As Integer = 2, r As Integer

        For i As Integer = seq.Length To 1 Step -1
            r = (Convert.ToInt32(Microsoft.VisualBasic.Strings.Mid(seq, i, 1)) * p)

            If r > 9 Then
                r = (r \ 10) + (r Mod 10)
            End If

            s += r

            If p = 2 Then
                p = 1
            Else
                p = p + 1
            End If
        Next
        d = ((10 - (s Mod 10)) Mod 10)
        Return d
    End Function

    Protected Shared Function Mod11(ByVal seq As String) As Integer
        ' Variáveis
        '             * -------------
        '             * d - Dígito
        '             * s - Soma
        '             * p - Peso
        '             * b - Base
        '             * r - Resto
        '             


        Dim d As Integer, s As Integer = 0, p As Integer = 2, b As Integer = 9

        For i As Integer = 0 To seq.Length - 1
            s = s + (Convert.ToInt32(seq(i)) * p)
            If p < b Then
                p = p + 1
            Else
                p = 2
            End If
        Next

        d = 11 - (s Mod 11)
        If d > 9 Then
            d = 0
        End If
        Return d
    End Function

    Protected Shared Function Mod11(ByVal seq As String, ByVal b As Integer) As Integer
        ' Variáveis
        '             * -------------
        '             * d - Dígito
        '             * s - Soma
        '             * p - Peso
        '             * b - Base
        '             * r - Resto
        '             


        Dim d As Integer, s As Integer = 0, p As Integer = 2


        For i As Integer = seq.Length To 1 Step -1
            s = s + (Convert.ToInt32(Microsoft.VisualBasic.Strings.Mid(seq, i, 1)) * p)
            If p = b Then
                p = 2
            Else
                p = p + 1
            End If
        Next

        d = 11 - (s Mod 11)


        If (d > 9) OrElse (d = 0) OrElse (d = 1) Then
            d = 1
        End If

        Return d
    End Function

    Protected Shared Function Mod11Base9(ByVal seq As String) As Integer
        ' Variáveis
        '             * -------------
        '             * d - Dígito
        '             * s - Soma
        '             * p - Peso
        '             * b - Base
        '             * r - Resto
        '             


        Dim d As Integer, s As Integer = 0, p As Integer = 2, b As Integer = 9


        For i As Integer = seq.Length - 1 To 0 Step -1
            Dim aux As String = Convert.ToString(seq(i))
            s += (Convert.ToInt32(aux) * p)
            If p >= b Then
                p = 2
            Else
                p = p + 1
            End If
        Next

        If s < 11 Then
            d = 11 - s
            Return d
        Else
            d = 11 - (s Mod 11)
            If (d > 9) OrElse (d = 0) Then
                d = 0
            End If

            Return d
        End If
    End Function

    Protected Shared Function Mod11(ByVal seq As String, ByVal lim As Integer, ByVal flag As Integer) As Integer
        Dim mult As Integer = 0
        Dim total As Integer = 0
        Dim pos As Integer = 1
        'int res = 0;
        Dim ndig As Integer = 0
        Dim nresto As Integer = 0
        Dim num As String = String.Empty

        mult = 1 + (seq.Length Mod (lim - 1))

        If mult = 1 Then
            mult = lim
        End If


        While pos <= seq.Length
            num = Microsoft.VisualBasic.Strings.Mid(seq, pos, 1)
            total += Convert.ToInt32(num) * mult

            mult -= 1
            If mult = 1 Then
                mult = lim
            End If

            pos += 1
        End While
        nresto = (total Mod 11)
        If flag = 1 Then
            Return nresto
        Else
            If nresto = 0 OrElse nresto = 1 OrElse nresto = 10 Then
                ndig = 1
            Else
                ndig = (11 - nresto)
            End If

            Return ndig
        End If
    End Function
    Public Function Mod11BancoBrasil(ByVal value As String) As String
        '#Region "Trecho do manual DVMD11.doc"
        ' 
        '            Multiplicar cada algarismo que compõe o número pelo seu respectivo multiplicador (PESO).
        '            Os multiplicadores(PESOS) variam de 9 a 2.
        '            O primeiro dígito da direita para a esquerda deverá ser multiplicado por 9, o segundo por 8 e assim sucessivamente.
        '            O resultados das multiplicações devem ser somados:
        '            72+35+24+27+4+9+8=179
        '            O total da soma deverá ser dividido por 11:
        '            179 / 11=16
        '            RESTO=3
        '
        '            Se o resto da divisão for igual a 10 o D.V. será igual a X. 
        '            Se o resto da divisão for igual a 0 o D.V. será igual a 0.
        '            Se o resto for menor que 10, o D.V.  será igual ao resto.
        '
        '            No exemplo acima, o dígito verificador será igual a 3
        '            

        '#End Region

        ' d - Dígito
        '             * s - Soma
        '             * p - Peso
        '             * b - Base
        '             * r - Resto
        '             


        Dim d As String
        Dim s As Integer = 0, p As Integer = 9, b As Integer = 2

        For i As Integer = value.Length - 1 To 0 Step -1
            s += (Integer.Parse(value(i).ToString()) * p)
            If p = b Then
                p = 9
            Else
                p -= 1
            End If
        Next

        Dim r As Integer = (s Mod 11)
        If r = 10 Then
            d = "X"
        ElseIf r = 0 Then
            d = "0"
        Else
            d = r.ToString()
        End If

        Return d
    End Function

#End Region

    Protected Shared Function FatorVencimento(ByVal vencimento As Date) As Long
        Dim dateBase As New DateTime(2000, 7, 3, 0, 0, 0)
        Return DateDiff(DateInterval.Day, dateBase, vencimento) + 1000
    End Function
    Friend Shared Function DateDiff(ByVal Interval As DateInterval, ByVal StartDate As System.DateTime, ByVal EndDate As System.DateTime) As Long
        Dim lngDateDiffValue As Long = 0
        Dim TS As New System.TimeSpan(EndDate.Ticks - StartDate.Ticks)
        Select Case Interval
            Case DateInterval.Day
                lngDateDiffValue = CLng(TS.Days)
                Exit Select
            Case DateInterval.Hour
                lngDateDiffValue = CLng(TS.TotalHours)
                Exit Select
            Case DateInterval.Minute
                lngDateDiffValue = CLng(TS.TotalMinutes)
                Exit Select
            Case DateInterval.Month
                lngDateDiffValue = CLng(TS.Days / 30)
                Exit Select
            Case DateInterval.Quarter
                lngDateDiffValue = CLng((TS.Days / 30) \ 3)
                Exit Select
            Case DateInterval.Second
                lngDateDiffValue = CLng(TS.TotalSeconds)
                Exit Select
            Case DateInterval.Weekday
                lngDateDiffValue = CLng(TS.Days / 7)
                Exit Select
            Case DateInterval.Year
                lngDateDiffValue = CLng(TS.Days / 365)
                Exit Select
        End Select
        Return (lngDateDiffValue)
    End Function
#Region "Arquivo"
    Public Function headerBB07() As String
        Dim ret As New StringBuilder
        Dim tFilial As New DataTable
        Dim empresa As String
        Dim cnpj As String
        d.carrega_Tabela("Select * from almoxarifado where id_filial = " & _emitente, tFilial)
        empresa = tFilial.Rows(0)("RazaoSocial")
        '01 Posicao 001 a 001 Numerico T001 Identificacao do registro Header: "0"
        ret.Append("0")
        '02 Posicao 002 a 002 Numerico T001 Tipo de operacao: "1"
        ret.Append("1")
        '03 Posicao 003 a 009 Alfanumerico T007 Iedntificacao por extenso do tipo de
        'operacao: "REMESSA" para enviar arquivo para processamento
        '          "TESTE" para enviar arquivo de teste
        ret.Append(d.Completa("TESTE", 7))
        '04 Posicao 010 a 011 Numerico T002 Identificacao di tipo de servico: "01"
        ret.Append("01")
        '05 Posicao 012 a 019 Alfanumerico T008 identificacao por extenso do tipo de
        'servico: "COBRANCA" 
        ret.Append("COBRANCA")
        '06 Posicao 020 a 026 Alfanumerico T007 Complemento do registro: "Brancos"
        ret.Append(d.Espacos(7))
        '07 Posicao 027 a 030 Numerico T004 Numero da agencia onde esta cadastrado o 
        'convenio lider da empresa
        ret.Append(_codigoAgencia.ToString)
        '08 posicao 031 a 031 Numerico T001 Digito verificador da agencia
        ret.Append(_DVagencia.ToString)
        '09 posicao 032 a 039 Numerico T008 Numero da conta corrente
        ret.Append(d.adiciona_zeros(_contaCorrente.ToString, 8))
        '10 posicao 040 a 040 Numerico T001 Digito verificador da conta corrente
        ret.Append(_DVConta.ToString)
        '11 posicao 041 a 046 Numerico T006 Complemento do registro: "000000"
        ret.Append("000000")
        '12 posicao 047 a 076 Alfanumerico T030 Nome da Empresa Emissora
        empresa = d.Converte_Dos(empresa).ToUpper
        ret.Append(d.Completa(empresa, 30))
        '13 posicao 077 a 094 Alfanumerico T018: "001BANCODOBRASIL"
        ret.Append(d.Completa("001BANCODOBRASIL", 18))
        '14 posicao 095 a 100 numerico T006 Data da Gravacao: Informe formato DDMMAA
        Dim diaGeracao As String
        diaGeracao = Now.Day.ToString("00") & Now.Month.ToString("00") & Now.Year.ToString.Substring(2, 2)
        ret.Append(diaGeracao)
        '15 posicao 101 a 107 numerico T007 Sequencial da remessa (gerado pelo cliente)
        ret.Append(d.adiciona_zeros(_sequencial_remessa, 7))
        '16 posicao 108 a 129 Alfanumerico T022 Complemento de Registro: "Brancos"
        ret.Append(d.Completa("", 22))
        '17 posicao 130 a 136 Numerico T007 Numero do Convenio
        ret.Append(_convenio.ToString)
        '18 posicao 137 a 394 Alfanumerico T258 Complemento do registro: "Brancos"
        ret.Append(d.Completa("", 258))
        '19 posicao 395 a 400 Numerico T006 Sequencial do Registro: "000001"
        ret.Append("000001")
        Return ret.ToString
    End Function
    Public Function itemBB07(ByVal tbTitulos As DataTable) As String
        Dim ret As New StringBuilder
        Dim tFilial As New DataTable
        Dim empresa As String
        Dim cnpj As String
        Dim tControle As Integer
        Dim cliente As New objCliente
        Dim i As Integer
        d.carrega_Tabela("Select * from almoxarifado where id_filial = " & _emitente, tFilial)
        empresa = tFilial.Rows(0)("RazaoSocial")
        cnpj = rdTexto(tFilial.Rows(0)("CNPJ"))
        While i < tbTitulos.Rows.Count
            cliente.filtra_cod(tbTitulos.Rows(i)("cod_cliente"))

            '01 Posicao 001 a 001 Numerico T001 Identificacao do registro Detalhe: "0"
            ret.Append("7")
            '02 Posicao 002 a 003 Numerico T002 Tipo de inscricao da empresa: "01 cpf - 02 cnpj"
            ret.Append("01")
            '03 Posicao 004 a 017 Numerico T014 CPF/CNPJ da empresa
            ret.Append(adiciona_zeros(d.So_Numeros(cnpj), 14))
            '04 Posicao 018 a 021 Numerico T004 Prefixo da agência
            ret.Append(_codigoAgencia)
            '05 Posicao 022 a 022 Numerico T001 DV prefixo da agência
            ret.Append(_DVagencia)
            '06 Posicao 023 a 030 Alfanumerico T007 Número conta corrente"
            ret.Append(_contaCorrente)
            '07 Posicao 031 a 031 Numerico T001 Digito verificador Da conta corrente
            ret.Append(_DVConta.ToString)
            '08 posicao 032 a 038 Numerico T007 Número do convenio da empresa
            ret.Append(_convenio.ToString)
            '09 posicao 039 a 063 Numerico T025 Número de controle do participante
            ret.Append(d.adiciona_zeros(tbTitulos.Rows(i)("numero"), 25))
            '10 posicao 064 a 080 Numerico T017 Nosso número
            ret.Append(tbTitulos.Rows(i)("nossonumero").ToString.Substring(0, 17))
            '11 posicao 081 a 082 Numerico T002 Número da prestação: "00"
            ret.Append("00")
            '12 posicao 083 a 084 Numerico T002 Grupo de Valor: "00"
            ret.Append("00")
            '13 posicao 085 a 087 Numerico T003 complemento de registros: "Brancos"
            ret.Append(d.Completa("", 3))
            '14 posicao 088 a 088 Alfanumerico T001 Indicativo de mensagem Sacador Avalista: "Bancos" ou "A" nota 25
            ret.Append(d.Completa("", 1))
            '15 posicao 089 a 091 Alfanumerico T003 Prefixo do titulo: "Brancos"
            ret.Append(d.Completa("", 3))
            '16 posicao 092 a 094 Numerico T003 Variação da carteira: nota 02
            ret.Append("019")
            '17 posicao 095 a 095 Numerico T001 Conta Caução: "0" 
            ret.Append("0")
            '18 posicao 096 a 101 Numerico T006 Número do Borderô: "000000"
            ret.Append("000000")
            '19 posicao 102 a 106 Alfanumerico T005 Tipo de cobrança
            ret.Append(d.Completa("", 5))
            '20 posicao 107 a 108 Numerico T002 Carteira de cobranca: nota 27
            ret.Append("17")
            '21 posicao 109 a 110 Numerico T002 Comando: Nota 07
            ret.Append("01")
            '22 posicao 111 a 120 Alfanumerico T010 Seu Número/Número atribuida pela empresa
            Dim seunumero As String
            seunumero = tbTitulos.Rows(i)("tipo_documento").ToString & tbTitulos.Rows(i)("documento").ToString & _
            tbTitulos.Rows(i)("parcela").ToString
            ret.Append(d.Completa(seunumero, 10))
            '23 posicao 121 a 126 Numerico T006 Data de vencimento
            Dim diavencimento As String
            Dim venc As Date
            venc = tbTitulos.Rows(i)("data_vencimento")
            diavencimento = venc.Day.ToString("00") & venc.Month.ToString("00") & venc.Year.ToString.Substring(2, 2)
            ret.Append(diavencimento)
            '24 posicao 127 a 139 Numerico T011 Valor do Titulo
            Dim valor As Decimal
            valor = tbTitulos.Rows(i)("valor")
            ret.Append(String.Format("{0:d15}", Convert.ToInt64(valor * 100)))
            '25 posicao 140 a 142 Numerico T003 Numero do banco: "001" 
            ret.Append("001")
            '26 posicao 143 a 146 Numerico T004 Prefixo da agencia cobradora: "0000"
            ret.Append("0000")
            '27 posicao 147 a 147 Alfanumerico Digito verificador da agencia cobradora: "Brancos"
            ret.Append(d.Completa("", 1))
            '28 posicao 148 a 149 Numerico T002 Especie de titulo: Nota 09 (01) Duplicata Mercantil
            ret.Append("01")
            '29 posicao 150 a 150 Alfanumerico T001 Aceite do Titulo: N sem aceite A com aceite
            ret.Append("N")
            '30 posicao 151 a 156 Numerico T006 Data de Emissao
            Dim diaemissao As String
            Dim emissao As Date
            emissao = tbTitulos.Rows(i)("data_lancamento")
            diaemissao = emissao.Day.ToString("00") & emissao.Month.ToString("00") & emissao.Year.ToString.Substring(2, 2)
            ret.Append(diaemissao)
            '31 posicao 157 a 158 Numerico T002 Primeira instrucao codificada: Nota 10 (15 protestar após 15 dias corridos)
            ret.Append("15")
            '32 posicao 159 a 160 Numerico T002 Segunda instrucao codificada: Nota 10 (00 Sem instrução)
            ret.Append("00")
            '33 posicao 161 a 173 Numerico T011 Juros de mora por dia de atraso
            Dim juros As Decimal
            juros = tbTitulos.Rows(i)("bol_juros")
            ret.Append(String.Format("{0:d15}", Convert.ToInt64(juros * 100)))
            '34 posicao 174 a 179 Numerico T006 data limite para concessão de desconto
            ret.Append("000000")
            '35 posicao 180 a 192 Numerico T011 Valor do desconto
            ret.Append(d.Completa("0", 11))
            '36 posicao 193 a 205 Numerico T011 Valor do IOF
            ret.Append(d.Completa("0", 11))
            '37 posicao 206 a 218 Numerico T011 Valor do abatimento
            ret.Append(d.Completa("0", 11))
            '38 posicao 219 a 220 Numerico T002 tipo de incricao do sacado
            ret.Append("02")
            '39 posicao 221 a 234 Numerico T014 Numero do CNPJ/CPF do sacado
            ret.Append(adiciona_zeros(d.So_Numeros(cliente.cnpj), 14))
            '40 posicao 235 a 271 Alfanumerico T037 Nome do sacado
            Dim nome As String
            Dim size As Integer
            size = cliente.nome_cliente.Length
            If size >= 37 Then
                nome = cliente.nome_cliente.Substring(0, 37)
            Else
                nome = cliente.nome_cliente.Substring(0, size)
            End If
            nome = d.Converte_Dos(nome.ToUpper)
            size = nome.Length
            If size < 37 Then
                nome = d.Completa(nome, 37)
            End If
            ret.Append(nome)
            '41 posicao 272 a 274 Alfanumerico T003 Complemento do Registro: Brancos
            ret.Append(d.Completa("", 3))
            '42 posicao 275 a 311 Alfanumerico T037 Endereco do sacado
            Dim endereco As String
            endereco = cliente.endereco & ", " & cliente.numero
            endereco = d.Converte_Dos(endereco.ToUpper)
            ret.Append(d.Completa(endereco, 37))
            '43 posicao 312 a 326 Alfanumerico T015 Complemento do registro: "Brancos"
            ret.Append(d.Completa("", 15))
            '44 posicao 327 a 334 Numerico T008 Cep do sacado
            Dim cep As String
            cep = d.So_Numeros(cliente.cep)
            ret.Append(adiciona_zeros(cep, 8))
            '45 posicao 335 a 349 Alfanumerico T015 Cidade do sacado
            Dim cidade As String
            cidade = d.So_Numeros(cliente.nomecidade(cliente.cod_cidade))
            ret.Append(d.Completa(cidade.ToUpper, 15))
            '46 posicao 350 a 351 Alfanumerico T002 UF do sacado
            ret.Append(cliente.nomeUF(cliente.cod_cidade))
            '47 posicao 352 a 391 Alfanumerico T040 Observacao/mensagem ou sacador avalista
            ret.Append(d.Converte_Dos(d.Completa(_mensagemBoleto, 40)))
            '48 posicao 392 a 393 Alfanumerico T002 Numero de dias para protesto
            ret.Append("00")
            '49 posicao 394 a 394 Alfanumerico T001 Complemento de registro: "Brancos"
            ret.Append(d.Completa("", 1))
            '50 posicao 395 a 400 numerico T006 Sequencial de registro
            Dim sequencial As Int32
            sequencial = i + 1
            i = i + 1
            ret.Append(adiciona_zeros(sequencial, 6))
        End While
        Return ret.ToString
    End Function

    Public Function HeaderArquivo(ByVal Banco As Integer, ByVal Emitentes As Integer, ByVal Arquivo As Integer) As String
        Dim CodBanco As Integer = Convert.ToInt16(_codigobanco)
        Dim tFilial As New DataTable
        Dim ret As String = ""
        d.carrega_Tabela("Select * from almoxarifado where id_filial = " & _
                         Emitentes, tFilial)
        Select Case CodBanco
            Case 1
                If True Then
                    ret += String.Format("{0:d3}", Convert.ToInt16(_codigobanco))
                    'Codigo do Banco
                    ret += "0000"
                    'Lote
                    ret += "0"
                    ' Tipo de Registro
                    ret += d.Espacos(9)
                    ' Uso exclusivo do banco
                    ' Tipo de Inscricao (1)CPF (2)CNPJ
                    ret += "2"
                    ret += String.Format("{0:d14}", d.Converte32(d.So_Numeros(tFilial.Rows(0)("CNPJ").ToString())))
                    ' Inscricao
                    ret += d.Completa(_convenio.ToString(), 20)
                    ' Convenio
                    ret += String.Format("{0:d5}", Convert.ToInt32(_codigoAgencia))
                    'Codigo Agencia
                    ret += d.Completa(_DVagencia.ToString(), 1)
                    'Dv Agencia
                    ret += String.Format("{0:d12}", Convert.ToInt64(_contaCorrente))
                    ' Conta Corrente
                    ret += d.Completa(_DVConta.ToString(), 1)
                    'Dv Conta
                    ret += d.Completa(_DVAgenciaConta.ToString(), 1)
                    'Dv Agencia + Conta Corrente
                    ret += d.Completa(tFilial.Rows(0)("RazaoSocial").ToString(), 30)
                    ' Nome da Empresa
                    ret += d.Completa(_NomeBanco.ToString(), 30)
                    'Nome do Banco
                    ret += d.Espacos(10)
                    ' Para uso do Banco
                    ret += "1"
                    'Remessa(1) ou Retorno(2)
                    Dim Dado As String = DateTime.Now.ToString().Substring(0, 10)
                    Dado = d.So_Numeros(Dado)
                    ret += Dado
                    'Data da Geração
                    Dado = DateTime.Now.ToString().Substring(11, 8)
                    Dado = d.So_Numeros(Dado)
                    ret += Dado
                    'Hora da Geracao
                    ret += String.Format("{0:d6}", Arquivo)
                    'Número do Arquivo
                    ret += "082"
                    'Layout do Arquivo
                    ret += "00000"
                    'Densidade de Gravação
                    ret += d.Espacos(69)
                    'Reservaado pelo banco
                    Exit Select
                End If
            Case 104
                If True Then
                    '           ret += String.Format("{0:d3}", Convert.ToInt16(D_Banco("CodigoBanco")))
                    'Codigo do Banco
                    ret += "0000"
                    'Lote
                    ret += "0"
                    ' Tipo de Registro
                    ret += d.Espacos(9)
                    ' Uso exclusivo do banco
                    '          If Convert.ToInt16(D_Emitente("T_Inscricao")) = 1 Then
                    ' Tipo de Inscricao (1)CPF (2)CNPJ
                    ret += "2"
                Else
                    ret += "1"
                End If
                'ret += String.Format("{0:d14}", d.Converte32(d.So_Numeros(D_Emitente("CNPJ_CPF").ToString())))
                ' Inscricao
                'ret += d.Completa(D_Banco("Convenio").ToString(), 16)
                ' Convenio
                ret += d.Espacos(4)
                'Use uxclusivo 
                'ret += String.Format("{0:d5}", Convert.ToInt32(D_Banco("CodigoAgencia")))
                'Codigo Agencia
                'ret += d.Completa(D_Banco("DvAgencia").ToString(), 1)
                'Dv Agencia
                'ret += String.Format("{0:d12}", Convert.ToInt64(D_Banco("ContaCorrente")))
                ' Conta Corrente
                'ret += d.Completa(D_Banco("DvConta").ToString(), 1)
                'Dv Conta
                'ret += d.Completa(D_Banco("DvAgenciaConta").ToString(), 1)
                'Dv Agencia + Conta Corrente
                'ret += d.Completa(D_Emitente("RazaoSocial").ToString(), 30)
                ' Nome da Empresa
                'ret += d.Completa(D_Banco("NomeBanco").ToString(), 30)
                'Nome do Banco
                ret += d.Espacos(10)
                ' Para uso do Banco
                ret += "1"
                'Remessa(1) ou Retorno(2)
                Dim Dado As String = DateTime.Now.ToString().Substring(0, 10)
                Dado = d.So_Numeros(Dado)
                ret += Dado
                'Data da Geração
                Dado = DateTime.Now.ToString().Substring(11, 8)
                Dado = d.So_Numeros(Dado)
                ret += Dado
                'Hora da Geracao
                ret += String.Format("{0:d6}", Arquivo)
                'Número do Arquivo
                ret += "030"
                'Layout do Arquivo
                ret += "00000"
                'Densidade de Gravação
                ret += d.Espacos(69)
                'Reservaado pelo banco
                Exit Select
                'End If
            Case 237
                If True Then
                    ret = ""
                    Exit Select
                End If
        End Select
        Return ret
    End Function

    Public Function HeaderLote(ByVal Banco As Integer, ByVal Emitentes As Integer, ByVal Arquivo As Integer) As String
        Dim tFilial As New DataTable
        Dim CodBanco As Integer = Convert.ToInt16(_codigobanco)
        Dim ret As String = ""
        d.carrega_Tabela("Select * from almoxarifado where id_filial = " & _
                         Emitentes, tFilial)
        Select Case CodBanco
            Case 1
                If True Then
                    ret += String.Format("{0:d3}", CodBanco)
                    'Código do Banco
                    ret += "0001"
                    'Lote
                    ret += "1"
                    'Tipo de Registro
                    ret += "R"
                    'Tipo de Operação R - Remessa
                    ret += "01"
                    'Tipo de Serviço
                    ret += "  "
                    'Reservado Banco
                    ret += "041"
                    ' Layout do Lote
                    ret += " "
                    ' Reservado CNAB
                    ' Tipo de Inscricao (1)CPF (2)CNPJ
                    ret += "2"
                    ret += String.Format("{0:d15}", d.Converte32(d.So_Numeros(tFilial.Rows(0)("CNPJ").ToString())))
                    ' Inscricao
                    ret += d.Completa(_convenio.ToString(), 20)
                    'Convenio
                    ret += String.Format("{0:d5}", Convert.ToInt16(_codigoAgencia))
                    'Convenio
                    ret += d.Completa(_DVagencia.ToString(), 1)
                    'Dv Agencia
                    ret += String.Format("{0:d12}", Convert.ToInt64(_contaCorrente))
                    'Conta Corrente
                    ret += d.Completa(_DVConta.ToString(), 1)
                    'Dv Conta
                    ret += d.Completa(_DVAgenciaConta.ToString(), 1)
                    'Dv Agencia e Conta
                    ret += d.Completa(tFilial.Rows(0)("RazaoSocial").ToString(), 30)
                    ' Nome da Empresa
                    ret += d.Espacos(40)
                    'Mensagem1
                    ret += d.Espacos(40)
                    'Mensagem2
                    ret += String.Format("{0:d8}", Arquivo)
                    'Arquivo
                    Dim Dado As String = DateTime.Now.ToString().Substring(0, 10)
                    Dado = d.So_Numeros(Dado)
                    ret += Dado
                    'Data da Gravação
                    ret += "00000000"
                    'Data do Crédito valido somente para arquivo Retorno
                    ret += d.Espacos(33)
                    'Uso CNAB
                    Exit Select
                End If
            Case 104
                Exit Select
        End Select
        Return ret
    End Function

    Public Function Detalhe1(ByVal Banco As Integer, ByVal Emitentes As Integer, ByVal NossoNumero As String, ByVal Documento As String, ByVal Vencimento As DateTime, ByVal Valor As Decimal, _
     ByVal Emissao As DateTime, ByVal Juros As Decimal, ByVal Sequencial As Integer, ByVal CodCliente As Integer) As String
        'D_Emitente.Read()
        Dim CodBanco As Integer = _codigobanco
        Dim ret As String = ""
        Select Case CodBanco
            Case 1
                If True Then
                    ret += String.Format("{0:d3}", CodBanco)
                    'Codigo do Banco
                    ret += "0001"
                    'Numero do Lote
                    ret += "3"
                    'Tipo de Registro
                    ret += String.Format("{0:d5}", Sequencial)
                    'Sequencial
                    ret += "P"
                    'Seguimento
                    ret += " "
                    'Branco
                    ret += "01"
                    'Codigo do Movimento da Remessa
                    ret += String.Format("{0:d5}", Convert.ToInt32(_codigoAgencia))
                    ret += d.Completa(_DVagencia.ToString(), 1)
                    ret += String.Format("{0:d12}", Convert.ToInt64(_contaCorrente))
                    ret += d.Completa(_DVConta.ToString(), 1)
                    ret += d.Completa(_DVAgenciaConta.ToString(), 1)
                    ret += d.Completa(NossoNumero, 20)
                    ret += "1"
                    'Codigo da Carteira 1 - Cobrança Simples
                    ret += "1"
                    'Tipo de Cadastramento 1 - Com Registro
                    ret += "1"
                    'Tipo de Documento 1 - Tradicional 2 - Escritural
                    ret += "2"
                    'Emissao do Boleto 1 - Banco 2 - Cliente
                    ret += "2"
                    'Distribuição 1 - Banco 2 - Cliente
                    ret += d.Completa(Documento, 15)
                    'Documento
                    ret += d.So_Numeros(Vencimento.ToString().Substring(0, 10))
                    'Vencimento
                    ret += String.Format("{0:d15}", Convert.ToInt64(Valor * 100))
                    'Valor
                    ret += String.Format("{0:d5}", Convert.ToInt32(_codigoAgencia))
                    'Agencia Cobrdora
                    ret += d.Completa(_DVagencia.ToString(), 1)
                    'Dv Agencia Cobradora
                    ret += "02"
                    'Espécie de Tírulo
                    ret += "N"
                    'Aceite
                    ret += d.So_Numeros(Emissao.ToString().Substring(0, 10))
                    'Emissão
                    ret += "1"
                    'Código de Juros 1 - Por Dia
                    ret += "00000000"
                    'Data do Juros de Mora
                    ret += String.Format("{0:d15}", Convert.ToInt64(Juros * 100))
                    'Valor do Juros
                    ret += "1"
                    'Tipo de Desconto 1 - Valor até a data
                    ret += d.Repete("0", 8)
                    'Data apartir de quando é desconto
                    ret += d.Repete("0", 15)
                    'Valor do Desconto
                    ret += d.Repete("0", 15)
                    'Valor IOF
                    ret += d.Repete("0", 15)
                    'Valor Abatimento
                    ret += d.Espacos(25)
                    'Espaços em branco
                    ret += "3"
                    'Código de Protesto 3 - Não Protestar
                    ret += "00"
                    'Prazo de Protesto
                    ret += "2"
                    'Código de Baixa / Devolução 2 - Não Baixar
                    ret += "000"
                    'Prazo de Baixa / Devolução
                    ret += "09"
                    'Tipo de Moeda
                    ret += String.Format("{0:d10}", d.Converte64(_convenio.ToString()))
                    'Número de Contrato
                    ret += " "
                    'para uso do CNAB
                    Exit Select
                End If
        End Select
        Return ret
    End Function

    Public Function Detalhe2(ByVal Banco As Integer, ByVal Sequencial As Integer, ByVal CodCliente As Integer) As String
        Dim CodBanco As Integer = Convert.ToInt16(_codigobanco)
        Dim ret As String = ""
        Select Case CodBanco
            Case 1
                If True Then
                    ret += String.Format("{0:d3}", CodBanco)
                    'Codigo do Banco
                    ret += "0001"
                    'Numero do Lote
                    ret += "3"
                    'Tipo de Registro
                    ret += String.Format("{0:d5}", Sequencial)
                    'Sequencial
                    ret += "Q"
                    'Seguimento
                    ret += " "
                    'Branco
                    ret += "01"
                    'Código do movimento de remessa 01 - Entrada de títulos
                    Dim Cliente As New objCliente
                    Cliente.filtra_cod(CodCliente)
                    'tipo de Incricao 1-CPf 2-CNPJ
                    ret += "2"
                    ret += String.Format("{0:d15}", d.Converte64(d.So_Numeros(Cliente.cnpj.ToString())))
                    'Inscricao
                    ret += d.Completa(Cliente.razao_social.ToString(), 40)
                    'Nome do Sacado
                    ret += d.Completa(Cliente.endereco.ToString() & ", " & Cliente.numero.ToString(), 40)
                    'Endereço
                    ret += d.Completa(Cliente.bairro.ToString(), 15)
                    'Bairro
                    ret += String.Format("{0:d8}", d.Converte32(d.So_Numeros(Cliente.cep.ToString())))
                    'Cep
                    ret += d.Completa(Cliente.nomecidade(Cliente.cod_cidade).ToString(), 15)
                    'Cidade
                    ret += d.Completa(Cliente.nomeUF(Cliente.cod_cidade).ToString(), 2)
                    'UF
                    ret += "0"
                    'TIpo de Inscricao do Avalista
                    ret += d.Repete("0", 15)
                    'Inscrição do Avalista
                    ret += d.Espacos(40)
                    'Nome do Avalista
                    ret += "000"
                    'Código do Banco de Compensação
                    ret += d.Espacos(20)
                    'Nosso número no banco compensação
                    ret += d.Espacos(8)
                    'Uso Exclusivo CNAB
                    Exit Select
                End If
            Case 104
                ret = ""
                Exit Select
            Case 237
                If True Then
                    ret = ""
                    Exit Select
                End If
        End Select
        Return ret
    End Function

    Public Function TrailerLote(ByVal Banco As Integer, ByVal Sequencial As Integer, ByVal Quantidade As Integer, ByVal Valor As Decimal) As String

        Dim CodBanco As Integer = Convert.ToInt16(_codigobanco)
        Dim ret As String = ""
        Select Case CodBanco
            Case 1
                If True Then
                    ret += String.Format("{0:d3}", CodBanco)
                    'Código do Banco
                    ret += "0001"
                    'Lote de Remessa
                    ret += "5"
                    'Tipo de Registro
                    ret += d.Espacos(9)
                    'Espaços em Branco
                    ret += String.Format("{0:d6}", Sequencial)
                    'Quantidade de Registros
                    ret += String.Format("{0:d6}", Convert.ToInt64(Quantidade))
                    'Quantidade de Registros de Cobrança Simples
                    ret += String.Format("{0:d17}", Convert.ToInt64(Valor * 100))
                    'Valor de Registros de Cobrança Simples
                    ret += d.Repete("0", 6)
                    ' Quantidade de Títulos de Cobrança Vinculada
                    ret += d.Repete("0", 17)
                    'Valor de Títulos de Cobrança Vinculada
                    ret += d.Repete("0", 6)
                    'Quantidade de Títulos de Cobrança CAucionada
                    ret += d.Repete("0", 17)
                    'Valor de Título de Cobrança Caucionada
                    ret += d.Repete("0", 6)
                    'Quantidade de títulos Descontado
                    ret += d.Repete("0", 17)
                    'Valor de Títulos Descontados
                    ret += d.Repete("0", 8)
                    'Número de Aviso de Lançamento
                    ret += d.Espacos(117)
                    'Uso exclusivo do CNAB
                    Exit Select
                End If
            Case 104
                Exit Select
            Case 237
                If True Then
                    ret += "9"
                    'Tipo de Registro
                    ret += d.Espacos(393)
                    'Bancos
                    ret += String.Format("{0:d6}", Sequencial + 1)
                    'Seuquencial
                    Exit Select
                End If
        End Select
        Return ret
    End Function

    Public Function TrailerArquivo(ByVal Banco As Integer, ByVal Sequencial As Integer) As String

        Dim CodBanco As Integer = Convert.ToInt16(_codigobanco)
        Dim ret As String = ""
        Select Case CodBanco
            Case 1
                If True Then
                    ret += String.Format("{0:d3}", CodBanco)
                    'Código do Banco
                    ret += "9999"
                    'Lote de Serviço
                    ret += "9"
                    'Tipo de Registro
                    ret += d.Espacos(9)
                    'Uso CNAB
                    ret += "000001"
                    'Quantidade de Lote
                    ret += String.Format("{0:d6}", Sequencial)
                    'Quantidade de Registros
                    ret += "000000"
                    'Quantidade de COntas COnciliadas
                    ret += d.Espacos(205)
                    'Uso CNAB
                    Exit Select
                End If
            Case 104

                Exit Select
            Case 237
                If True Then
                    ret = ""
                    Exit Select
                End If
        End Select
        Return ret
    End Function

#End Region

#End Region
End Class
