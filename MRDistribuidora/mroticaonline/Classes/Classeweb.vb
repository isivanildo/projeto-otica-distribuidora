Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Public Class Classeweb
    Dim conecta As New SqlConnection(WebConfigurationManager.ConnectionStrings("conexaoSQL").ConnectionString)

#Region "Atributos"
    Private _cod_filial_cliente As Integer
    Private _cod_cliente As Integer
    Private _nome_cliente As String
    Private _razao_social As String
    Private _cnpj As String
    Private _ie As String
    Private _endereco As String
    Private _complemento As String
    Private _bairro As String
    Private _municipio As String
    Private _uf As String
    Private _cep As String
    Private _fones As String
    Private _data_ult_alteracao As Date
    Private _observacao As String
    Private _limite_compra As Double
    Private _limite_credito As Double
    Private _limite_cheque As Double
    Private _qtd_dias_pagar As Integer
    Private _cod_promotor As Integer
    Private _sem_desconto As Integer
    Private _cod_cidade As Integer
    Private _numero As Integer
    Private _fone_nota As Int64
    Private _cod_tipo_cliente As Integer
    Private _e_mail As String
    Private _cod_tipo_compra As Integer
#End Region

#Region "Propriedades"
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
    Public Property razao_social() As String
        Get
            razao_social = _razao_social
        End Get
        Set(ByVal Value As String)
            _razao_social = Value
        End Set
    End Property
    Public Property cnpj() As String
        Get
            cnpj = _cnpj
        End Get
        Set(ByVal Value As String)
            _cnpj = Value
        End Set
    End Property
    Public Property ie() As String
        Get
            ie = _ie
        End Get
        Set(ByVal Value As String)
            _ie = Value
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
    Public Property fone_nota()
        Get
            fone_nota = _fone_nota
        End Get
        Set(ByVal value)
            _fone_nota = value
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
    Public Property limite_compra()
        Get
            limite_compra = _limite_compra
        End Get
        Set(ByVal Value As Object)
            _limite_compra = Value
        End Set
    End Property
    Public Property limite_credito()
        Get
            limite_credito = _limite_credito
        End Get
        Set(ByVal Value As Object)
            _limite_credito = Value
        End Set
    End Property
    Public Property limite_cheque() As Object
        Get
            limite_cheque = _limite_cheque
        End Get
        Set(ByVal Value As Object)
            _limite_cheque = Value
        End Set
    End Property
    Public Property qtd_dias_pagar()
        Get
            qtd_dias_pagar = _qtd_dias_pagar
        End Get
        Set(ByVal value)
            _qtd_dias_pagar = value
        End Set
    End Property
    Public Property cod_promotor()
        Get
            cod_promotor = _cod_promotor
        End Get
        Set(ByVal value)
            _cod_promotor = value
        End Set
    End Property
    Public Property sem_desconto() As Boolean
        Get
            sem_desconto = _sem_desconto
        End Get
        Set(ByVal value As Boolean)
            _sem_desconto = CInt(value)
        End Set
    End Property
    Public Property cod_cidade()
        Get
            cod_cidade = _cod_cidade
        End Get
        Set(ByVal value)
            _cod_cidade = value
        End Set
    End Property
    Public Property numero()
        Get
            numero = _numero
        End Get
        Set(ByVal value)
            _numero = value
        End Set
    End Property
    Public Property cod_tipo_cliente
        Get
            cod_tipo_cliente = _cod_tipo_cliente
        End Get
        Set(ByVal value)
            _cod_tipo_cliente = value
        End Set
    End Property
    Public Property e_mail
        Get
            e_mail = _e_mail
        End Get
        Set(ByVal value)
            _e_mail = value
        End Set
    End Property
    Public Property cod_tipo_compra
        Get
            cod_tipo_compra = _cod_tipo_compra
        End Get
        Set(value)
            _cod_tipo_compra = value
        End Set
    End Property
#End Region

    Public tabela As New DataTable

    Public Function carrega_Tabela(ByVal sql As String, ByRef tabela As Data.DataTable) As DataTable
        Dim cmdDados As New SqlClient.SqlCommand
        Dim daDados As New SqlClient.SqlDataAdapter
        Dim dsDados As New Data.DataSet
        Try
            conecta.Close()
            conecta.Open()
            cmdDados.Connection = conecta
            cmdDados.CommandTimeout = 240
            cmdDados.CommandText = sql
            daDados.SelectCommand = cmdDados
            daDados.Fill(dsDados)
            tabela = dsDados.Tables(0)
        Catch ex As Exception
            'Return "ER: " & ex.Message & vbCrLf & sql & vbCrLf & conecta()
        End Try
        cmdDados.Dispose()
        daDados.Dispose()
        dsDados.Dispose()
        conecta.Close()

        Return tabela
    End Function

    'Função responsável por trazer o status do do movimento se esta concluido ou não
    Public Function exibi_promotor_cb(ByVal codfilialcli As Integer, ByVal codcliente As Integer, ByVal lista As ListBox) As DataTable
        Dim strSQL As String
        strSQL = "select promotor.promotor as promotor from promotor inner join promotor_cliente on " & _
    "promotor.cod_promotor = promotor_cliente.cod_promotor where promotor_cliente.cod_filial_cliente = " & codfilialcli & _
    " And promotor_cliente.cod_cliente = " & codcliente & ""
        Dim tt As New DataTable
        carrega_Tabela(strSQL, tt)
        lista.DataTextField = "promotor"
        lista.DataValueField = "promotor"
        lista.DataSource = tt
        lista.DataBind()
        Return tt
    End Function

    Public Sub filtra_nome(ByVal n As String)
        Dim tsql As String
        tsql = "Select * from cliente where (nome_cliente like '%" & n & "%') or " & _
        "(razao_social like '%" & n & "%')"

        carrega_Tabela(tsql, tabela)

        _cod_cliente = tabela.Rows(0)("cod_cliente")
        _cod_filial_cliente = tabela.Rows(0)("cod_filial_cliente")
        _nome_cliente = tabela.Rows(0)("nome_cliente")
        _razao_social = tabela.Rows(0)("razao_social")
        _cnpj = tabela.Rows(0)("cnpj")
        _ie = tabela.Rows(0)("ie").ToString
        _endereco = tabela.Rows(0)("endereco").ToString
        _numero = tabela.Rows(0)("numero").ToString
        _complemento = tabela.Rows(0)("complemento").ToString
        _bairro = tabela.Rows(0)("bairro").ToString
        _municipio = tabela.Rows(0)("municipio").ToString
        _uf = tabela.Rows(0)("uf").ToString
        _cep = tabela.Rows(0)("cep").ToString
        _fones = tabela.Rows(0)("fones").ToString
        _fone_nota = rdNum(tabela.Rows(0)("fone_nota"))
        _observacao = tabela.Rows(0)("observacao").ToString
        _limite_compra = rdNum(tabela.Rows(0)("limite_compra"))
        _limite_credito = rdNum(tabela.Rows(0)("limite_credito"))
        _limite_cheque = rdNum(tabela.Rows(0)("limite_cheque"))
        _qtd_dias_pagar = rdNum(tabela.Rows(0)("qtd_dias_pagar"))
        _cod_promotor = rdNum(tabela.Rows(0)("cod_promotor"))
        _sem_desconto = tabela.Rows(0)("sem_desconto")
        _cod_cidade = rdNum(tabela.Rows(0)("codigo_cidade"))
        _cod_tipo_cliente = rdNum(tabela.Rows(0)("cod_tipo_cliente"))
        _e_mail = tabela.Rows(0)("e_mail").ToString
        _cod_tipo_compra = rdNum(tabela.Rows(0)("tipo_compra"))
    End Sub

    Public Sub filtra_cod(ByVal cod As Integer)
        Dim tsql As String
        tsql = "Select * from cliente where cod_cliente = " & cod

        carrega_Tabela(tsql, tabela)

        _cod_cliente = tabela.Rows(0)("cod_cliente")
        _cod_filial_cliente = tabela.Rows(0)("cod_filial_cliente")
        _nome_cliente = tabela.Rows(0)("nome_cliente")
        _razao_social = tabela.Rows(0)("razao_social")
        _cnpj = tabela.Rows(0)("cnpj")
        _ie = tabela.Rows(0)("ie").ToString
        _endereco = tabela.Rows(0)("endereco").ToString
        _numero = tabela.Rows(0)("numero").ToString
        _complemento = tabela.Rows(0)("complemento").ToString
        _bairro = tabela.Rows(0)("bairro").ToString
        _municipio = tabela.Rows(0)("municipio").ToString
        _uf = tabela.Rows(0)("uf").ToString
        _cep = tabela.Rows(0)("cep").ToString
        _fones = tabela.Rows(0)("fones").ToString
        _fone_nota = rdNum(tabela.Rows(0)("fone_nota"))
        _observacao = tabela.Rows(0)("observacao").ToString
        _limite_compra = rdNum(tabela.Rows(0)("limite_compra"))
        _limite_credito = rdNum(tabela.Rows(0)("limite_credito"))
        _limite_cheque = rdNum(tabela.Rows(0)("limite_cheque"))
        _qtd_dias_pagar = rdNum(tabela.Rows(0)("qtd_dias_pagar"))
        _cod_promotor = rdNum(tabela.Rows(0)("cod_promotor"))
        _sem_desconto = tabela.Rows(0)("sem_desconto")
        _cod_cidade = rdNum(tabela.Rows(0)("codigo_cidade"))
        _cod_tipo_cliente = rdNum(tabela.Rows(0)("cod_tipo_cliente"))
        _e_mail = tabela.Rows(0)("e_mail").ToString
        _cod_tipo_compra = rdNum(tabela.Rows(0)("tipo_compra"))
    End Sub

    Public Function resumo_receber_total_cliente() As String

        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select sum((receber.Pedidos_nao_faturados + receber.Saldo_faturas " & _
        "+receber.titulos_atraso+receber.titulos_a_vencer+receber.cheques_a_vencer)) " & _
        "as total_aberto   from resumo_receber() as receber " & _
        "where cod_cliente = " & _cod_cliente & _
        " and cod_filial_cliente = " & _cod_filial_cliente & ""
        carrega_Tabela(tsql, tt)
        Try
            Return tt.Rows(0)(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function resumo_receber_cliente() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select round(receber.Pedidos_nao_faturados,2) as Pedidos," & _
        "round(receber.Saldo_faturas,2) as Faturas_aberto, " & _
        "round(receber.titulos_atraso,2) as titulos_atraso,round(receber.titulos_a_vencer,2) as titulos_vencer, " & _
        "round((receber.titulos_atraso+receber.titulos_a_vencer),2) as titulos_aberto," & _
        "round(receber.cheques_a_vencer,2) AS cheques_vencer ,round((receber.Pedidos_nao_faturados + receber.Saldo_faturas " & _
        "+receber.titulos_atraso+receber.titulos_a_vencer+receber.cheques_a_vencer+receber.acordo_atrasado),2) " & _
        "as total_aberto, round((receber.acordo_atrasado),2) as acordo_atrasado  from resumo_receber() as receber " & _
        "where cod_cliente = " & _cod_cliente & _
        " and cod_filial_cliente = " & _cod_filial_cliente & ""
        carrega_Tabela(tsql, tt)
        Return tt
    End Function

    Public Function tb_tipo_cliente() As DataTable
        Dim tt As New DataTable
        carrega_Tabela("select * from tipo_cliente", tt)
        Return tt
    End Function

    Public Function PStr(ByVal strValue As Object) As String
        If IsDBNull(strValue) Then GoTo nulo
        If strValue = Nothing Then
            Return "NULL"
        End If
        If CStr(strValue).Trim() = "" Then
nulo:
            Return "NULL"
        Else
            Return "'" & CStr(strValue).Trim() & "'"
        End If
    End Function

    Public Function cdin(ByVal valor As Object) As String
        If IsDBNull(valor) Then valor = Nothing
        Try
            If valor.ToString = 0 Then Return Replace(CDbl(valor), ",", ".")
        Catch ex As Exception

        End Try

        If valor = Nothing Then Return "NULL"
        Return Replace(CDbl(valor), ",", ".")
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

    Public Function inst_fila(ByVal sql As String) As String
        sql = Replace(sql, "'", "`")
        Return sql
    End Function

    Public Sub ComandoSQL(ByVal sql As String, ByVal exporta As Boolean)
        Try
            If exporta = True Then
                sql = "Insert into fila_exportacao(id_fila,origem,gerado,destino,instrucao,data_inclusao) values(" & _
                retornaUltimoRegistro("fila_exportacao", "id_fila", " where origem = 1") & _
                "," & 1 & "," & 1 & ", 1," & _
                PStr(inst_fila(sql)) & "," & pdtm(Now.ToString) & ")"
                conecta.Close()
                conecta.Open()
                Dim cmd As New SqlCommand(sql, conecta)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conecta.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Salvar()
        Dim strSQL As String = "Insert into cliente(cod_filial_cliente,cod_cliente,nome_cliente," & _
        "razao_social,cnpj,ie,endereco,complemento,bairro,municipio,uf,cep,fones," & _
        "observacao,cod_promotor,limite_compra,limite_credito,limite_cheque,qtd_dias_pagar," & _
        "sem_desconto,codigo_cidade,numero,fone_nota, cod_tipo_cliente,e_mail,tipo_compra)" & _
        " Values(" & _
        _cod_filial_cliente & "," & _cod_cliente & "," & _
        PStr(_nome_cliente) & _
        "," & PStr(_razao_social) & _
        "," & PStr(_cnpj) & "," & PStr(_ie) & _
        "," & PStr(_endereco) & "," & PStr(_complemento) & "," & PStr(_bairro) & _
        "," & PStr(_municipio) & "," & PStr(_uf) & "," & PStr(_cep) & _
        "," & PStr(_fones) & "," & PStr(_observacao) & "," & _
        "0" & "," & _
        cdin(_limite_compra) & "," & _
        cdin(_limite_credito) & "," & _
        cdin(_limite_cheque) & _
        "," & _qtd_dias_pagar & _
        "," & _sem_desconto & _
        "," & _cod_cidade & _
        "," & cdin(_numero) & _
        "," & _fone_nota & _
        "," & _cod_tipo_cliente & _
        "," & PStr(_e_mail) & _
        "," & _cod_tipo_compra & ")"
        conecta.Open()
        Dim cmd As New SqlCommand(strSQL, conecta)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conecta.Close()
        ComandoSQL(strSQL, True)
    End Sub

    Public Sub Editar()
        Dim strSQL As String = "Update cliente set " & _
        "cod_cliente = " & _cod_cliente & _
        ",nome_cliente = " & PStr(_nome_cliente) & _
        ",razao_social = " & PStr(_razao_social) & _
        ",cnpj = " & PStr(_cnpj) & _
        ",ie = " & PStr(_ie) & _
        ",endereco=" & PStr(_endereco) & _
        ",complemento=" & PStr(_complemento) & _
        ",bairro=" & PStr(_bairro) & _
        ",municipio=" & PStr(_municipio) & _
        ",uf=" & PStr(_uf) & _
        ",cep=" & PStr(_cep) & _
        ",fones=" & PStr(_fones) & _
        ",observacao =" & PStr(_observacao) & _
        ",cod_promotor = 0" & _
        ",limite_compra = " & cdin(_limite_compra) & _
        ",limite_credito = " & cdin(_limite_credito) & _
        ",limite_cheque = " & cdin(_limite_cheque) & _
        ",qtd_dias_pagar = " & cdin(_qtd_dias_pagar) & _
        ",sem_desconto = " & _sem_desconto & _
        ",codigo_cidade = " & _cod_cidade & _
        ",numero = " & _numero & _
        ",fone_nota = " & _fone_nota & _
        ",cod_tipo_cliente = " & _cod_tipo_cliente & _
        ",e_mail = " & PStr(_e_mail) & _
                ",tipo_compra = " & _cod_tipo_compra & _
        " where cod_cliente = " & Me._cod_cliente & _
        " and cod_filial_cliente = " & Me._cod_filial_cliente & ""
        conecta.Open()
        Dim cmd As New SqlCommand(strSQL, conecta)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            cmd.Dispose()
            conecta.Close()
        End Try
        ComandoSQL(strSQL, True)
    End Sub

    Public Function retornaUltimoRegistro(ByVal tabela As String, ByVal campo As String, ByVal instrucao As String) As Integer
        Dim strSQL = "SELECT MAX(" & campo & ") FROM " & tabela & " " & instrucao
        Dim registro As Integer
        Dim cmd As SqlCommand
        Try
            conecta.Close()
            conecta.Open()
            cmd = New SqlCommand(strSQL, conecta)
            If cmd.ExecuteScalar Is DBNull.Value Then
                registro = 0
            Else
                registro = cmd.ExecuteScalar
            End If
            Return registro + 1
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return registro
        cmd.Dispose()
        conecta.Close()
    End Function

    Public Function pdtm(ByVal TheDate As Object) As String
        If IsDBNull(TheDate) = True Then Return "NULL"
        If CStr(TheDate) = "" Or TheDate = Nothing Then
            Return "NULL"
        End If
        Dim str As String
        Dim TDate As Date
        TDate = Convert.ToDateTime(TheDate)
        With TDate
            str = (.Year.ToString.PadLeft(2, Convert.ToChar("0")) & .Month.ToString.PadLeft(2, Convert.ToChar("0")) & .Day.ToString.PadLeft(2, Convert.ToChar("0")) & " " & .Hour.ToString.PadLeft(2, Convert.ToChar("0")) & ":" & .Minute.ToString.PadLeft(2, Convert.ToChar("0")) & ":" & .Second.ToString.PadLeft(2, Convert.ToChar("0")) & ":" & .Millisecond.ToString.PadLeft(2, Convert.ToChar("0")))
        End With
        Return "'" & str & "'"
    End Function

    Public Sub grava_promotor(ByVal codpromotor As Integer, ByVal codfilialcli As Integer, ByVal codcliente As Integer)
        Dim strSQL As String = "INSERT INTO promotor_cliente(cod_promotor, cod_filial_cliente, cod_cliente) " & _
            "VALUES(@codpromotor, @codfilialcli, @codcliente)"

        conecta.Close()
        conecta.Open()
        Dim cmd As New SqlCommand(strSQL, conecta)
        cmd.Parameters.AddWithValue("@codpromotor", codpromotor)
        cmd.Parameters.AddWithValue("@codfilialcli", codfilialcli)
        cmd.Parameters.AddWithValue("@codcliente", codcliente)
        Try
            cmd.ExecuteNonQuery()
            ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conecta.Close()
        End Try
    End Sub

    'Rotina responsável por inserir infromações na tabela promotor_cliente
    Public Sub excluir_promotor(ByVal codpromotor As Integer, ByVal codfilial As Integer, ByVal codcliente As Integer)
        Dim strSQL As String = "DELETE FROM promotor_cliente WHERE cod_promotor = @codpromotor AND cod_filial_cliente = @codfilial AND cod_cliente = @codcliente"
        conecta.Close()
        conecta.Open()
        Dim cmd As New SqlCommand(strSQL, conecta)
        cmd.Parameters.AddWithValue("@codpromotor", codpromotor)
        cmd.Parameters.AddWithValue("@codcliente", codcliente)
        cmd.Parameters.AddWithValue("@codfilial", codfilial)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conecta.Close()
        End Try
    End Sub

    'Função responsável por trazer o status do do movimento se esta concluido ou não
    Public Function exibi_codigo_promotor(ByVal promotor As String) As Integer
        Dim strSQL As String
        strSQL = "select cod_promotor from promotor where promotor = '" & promotor & "'"
        conecta.Close()
        conecta.Open()
        Dim cmd As New SqlCommand(strSQL, conecta)
        Try
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conecta.Close()
        End Try
    End Function

    Public Function Pdt(ByVal strValue As Object) As String
        If IsDBNull(strValue) = True Then
            Return "NULL"
        Else
            strValue = CStr(strValue)
        End If
        Dim m, d, y, dt As String
        If strValue = "00:00:00" Then
            Return "NULL"
        End If
        If strValue = Nothing Then
            Return "NULL"
        End If
        If strValue.Trim() = "" Or strValue.Trim() = "__/__/____" Then
            Return "NULL"
        Else
            d = DateAndTime.Day(strValue)
            If Len(d) = 1 Then d = "0" & d
            m = DateAndTime.Month(strValue)
            If Len(m) = 1 Then m = "0" & m
            y = DateAndTime.Year(strValue)
            dt = y & m & d
            Return "'" & dt & "'"
        End If
    End Function


    Public Function restricoes_cliente(ByVal todas As Boolean) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT restricoes_cliente.cod_restricao, restricoes_cliente.descricao, " & _
        "tipo_restricao.tipo_restricao,restricoes_cliente.data_inicio, " & _
        "restricoes_cliente.data_fim, restricoes_cliente.cod_tipo_restricao " & _
        "FROM restricoes_cliente INNER JOIN " & _
        "tipo_restricao ON restricoes_cliente.cod_tipo_restricao = " & _
        "tipo_restricao.cod_tipo_restricao where restricoes_cliente.cod_filial_cliente = " & _
        _cod_filial_cliente & " and restricoes_cliente.cod_cliente = " & _cod_cliente & ""
        If todas = False Then
            tsql = tsql & " and restricoes_cliente.data_fim is null "
        End If
        carrega_Tabela(tsql, tt)
        Return tt
    End Function

    Public Function titulos_atraso_cliente_total(ByVal codcliente As Int32, ByVal filial As Int16) As String
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT sum(Valor)  from Titulos_aberto() as titulos_aberto " & _
        " where cod_cliente = " & codcliente & _
        " and cod_filial_cliente = " & filial & _
        " and dateadd(day,0,data_vencimento) < " & Pdt(Now) & " and data_recebimento is null"

        carrega_Tabela(tsql, tt)
        Try
            Return tt.Rows(0)(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function titulos_cliente_pendente_total_sem_atraso(ByVal codcliente As Int32, ByVal filial As Int16) As String
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT sum(lancamentos.Valor+ISNULL(pagamentos_acordo.acrescimo+pagamentos_acordo.juros+pagamentos_acordo.taxas-pagamentos_acordo.desconto,0)) as valor " & _
        "FROM lancamentos left JOIN lancamentos_cliente ON lancamentos.cod_lancamento =" & _
        "lancamentos_cliente.cod_lancamento AND lancamentos.id_filial = " & _
        "lancamentos_cliente.id_filial left JOIN cliente ON " & _
        "lancamentos_cliente.cod_filial_cliente = cliente.cod_filial_cliente " & _
        "and lancamentos_cliente.cod_cliente = cliente.cod_cliente  " & _
        "left join forma_pagamento on forma_pagamento.cod_forma_pagamento = " & _
        "lancamentos.cod_forma_pagamento left join boleto on boleto.cod_lancamento = " & _
        "lancamentos.cod_lancamento and boleto.id_filial = lancamentos.id_filial " & _
        "left join Pagamentos_acordo on Pagamentos_acordo.cod_lancamento = lancamentos.cod_lancamento and Pagamentos_acordo.id_filial = lancamentos.id_filial " & _
        "where lancamentos.data_recebimento is null " & _
        " and lancamentos.cod_status_lancamento <> 2 " & _
        " and lancamentos_cliente.cod_cliente = " & codcliente & _
        " and lancamentos_cliente.cod_filial_cliente = " & filial & _
        " and lancamentos.data_vencimento >= " & Pdt(Now) & ""
        carrega_Tabela(tsql, tt)
        Try
            Return tt.Rows(0)(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function titulos_Cliente(ByVal filial As Int16, ByVal codcliente As Int32) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT substring(boleto.Nossonumero,0,18) as nossonumero, boleto.tipo_documento, lancamentos.data_lancamento," & _
           "boleto.documento,(lancamentos.Valor+lancamentos.acrescimo+lancamentos.juros-lancamentos.desconto+lancamentos.taxas) + " & _
           "ISNULL((Pagamentos_acordo.acrescimo + Pagamentos_acordo.juros + Pagamentos_acordo.taxas - Pagamentos_acordo.desconto),0) as Valor," & _
           "lancamentos.data_vencimento, lancamentos.data_recebimento ," & _
           "boleto.cod_lancamento, boleto.id_filial,lancamentos.id_filial_lancamento " & _
           " FROM boleto INNER JOIN lancamentos ON boleto.cod_lancamento = " & _
           "lancamentos.cod_lancamento AND boleto.id_filial = lancamentos.id_filial " & _
           "inner join lancamentos_cliente on lancamentos.id_filial = " & _
           "lancamentos_cliente.id_filial and lancamentos.cod_lancamento = " & _
           "lancamentos_cliente.cod_lancamento " & _
           "LEFT JOIN Pagamentos_acordo ON Pagamentos_acordo.cod_lancamento = lancamentos.cod_lancamento and " & _
           "Pagamentos_acordo.id_filial = lancamentos.id_filial " & _
           "where lancamentos_cliente.cod_filial_cliente = " & _
           filial & " and lancamentos_cliente.cod_cliente = " & _
           codcliente & " and lancamentos.cod_status_lancamento = 1 order by data_recebimento, data_vencimento"
        carrega_Tabela(tsql, tt)
        Return tt
    End Function

    'Função responsável por verificar se o tipo de usuário já está vinculado a algum usuário
    Public Function retornaRegistro(ByVal instrucaoSQL As String) As DataSet
        Dim strSQL = instrucaoSQL
        conecta.Open()
        Dim da As New SqlDataAdapter(strSQL, conecta)
        Dim ds As New DataSet
        ds.Reset()
        Try
            da.Fill(ds, "Registro")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conecta.Close()
        End Try
        Return ds
    End Function
End Class
