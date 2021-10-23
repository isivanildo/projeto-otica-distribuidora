Public Class ObjNaturezaOperacao

    Dim d As New dados()
    Public Property Codigo As Integer
    Public Property Descricao As String
    Private _precoUsado As Integer
    Private _destinatario As Integer
    Public Property Observacao As String
    Public Property Complementar As Boolean
    Public Property Devolucao As Boolean
    Public Property Normal As Boolean
    Public Property Ajuste As Boolean
    Public Property TipoEntradaSaida As String
    Public Property PrecoUsado As String
        Get

            If _precoUsado = 1 Then
                Return "Custo"
            Else
                Return "Venda"
            End If
        End Get
        Set(ByVal value As String)
            _precoUsado = Convert.ToInt32(value)
        End Set
    End Property

    Public Property Destinatario As String
        Get

            If _destinatario = 1 Then
                Return "Cliente"
            Else
                Return "Fornecedor"
            End If
        End Get
        Set(ByVal value As String)
            _destinatario = Convert.ToInt32(value)
        End Set
    End Property

    Public Property Destino As Integer
    Public Property OperacaoNFe As Integer

    Public Sub New()

    End Sub

    Public Sub Novo()
        If objGeral.TipoReg = "N"c Then
            Codigo = Convert.ToInt16(d.retorna_Chave("codigonat", "naturezaoperacao", ""))
        End If
    End Sub

    Public Sub RetornaNaturezaOperacao(ByVal x_codigo_nat As Integer)
        Dim tb As New DataTable()

        d.carrega_Tabela("select * From naturezaoperacao where codigonat = " & x_codigo_nat, tb)

        If tb.Rows.Count > 0 Then
            Codigo = tb.Rows(0)("codigonat")
            TipoEntradaSaida = tb.Rows(0)("tipoentradasaida")
            Descricao = tb.Rows(0)("descricao")
            PrecoUsado = tb.Rows(0)("precousado")
            Destinatario = tb.Rows(0)("destinatario")
            Observacao = tb.Rows(0)("observacao")
            Complementar = tb.Rows(0)("complementar")
            Devolucao = tb.Rows(0)("devolucao")
            Destino = tb.Rows(0)("destino")
            Normal = tb.Rows(0)("normal")
            Ajuste = tb.Rows(0)("ajuste")
            OperacaoNFe = tb.Rows(0)("operacaonfe")
        End If
    End Sub

    Public Sub SalvaAtualizaExclui()
        Dim resultado As Boolean = False
        Dim strSQL As String = ""

        If objGeral.TipoReg = "N"c Then
            strSQL = "insert into naturezaoperacao (codigonat, tipoentradasaida, descricao, precousado, destinatario," &
                "observacao, complementar, devolucao, destino, normal, ajuste, operacaonfe, cfop, codigocst) values(" & Codigo & "," &
                objGeral.AspasSQL(TipoEntradaSaida) & "," & objGeral.AspasSQL(Descricao) & "," & PrecoUsado & "," &
                Destinatario & "," & objGeral.AspasSQL(Observacao) & "," & objGeral.AspasSQL(Complementar.ToString()) & "," &
                objGeral.AspasSQL(Devolucao.ToString()) & "," + Destino & "," + objGeral.AspasSQL(Normal.ToString()) & "," &
                objGeral.AspasSQL(Ajuste.ToString()) & "," & OperacaoNFe & ")"
        End If

        If objGeral.TipoReg = "A"c Then
            strSQL = "update naturezaoperacao set tipoentradasaida = " & objGeral.AspasSQL(TipoEntradaSaida) & "," & "descricao = " &
                objGeral.AspasSQL(Descricao) & "," & "precousado = " & PrecoUsado & "," & "destinatario = " &
                Destinatario & "," & "observacao = " & objGeral.AspasSQL(Observacao) & "," & "complementar = " &
                objGeral.AspasSQL(Complementar.ToString()) & "," & "devolucao = " & objGeral.AspasSQL(Devolucao.ToString()) & "," &
                "destino = " & Destino & "," & "normal = " & objGeral.AspasSQL(Normal.ToString()) & "," & "ajuste = " &
                objGeral.AspasSQL(Ajuste.ToString()) & "," & "operacaonfe = " + OperacaoNFe & "," & "cfop = " &
                " where codigonat = " & Codigo
        End If

        If objGeral.TipoReg = "E"c Then
            strSQL = "delete from naturezaoperacao where codigonat = " & Codigo
        End If

        d.Comando(strSQL, False)
    End Sub
End Class
