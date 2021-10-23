Public Class objPagCredito
    Inherits objLancamentos
    Private _cod_pagamento_credito As Integer
    Private _cod_credito As Integer
    Dim conf As New config
    Dim d As New dados
    Public Property cod_pagamento_credito()
        Get
            cod_pagamento_credito = _cod_pagamento_credito
        End Get
        Set(ByVal value)
            _cod_pagamento_credito = value
        End Set
    End Property
    Public Property cod_credito()
        Get
            cod_credito = _cod_credito
        End Get
        Set(ByVal value)
            _cod_credito = value
        End Set
    End Property
    Public Sub novo_lancamento()
        novo()
        OrigemSalvar = "Novo"
        _cod_pagamento_credito = Nothing
        _cod_credito = Nothing
    End Sub
    Public Function salva_pag() As String
        Dim sql As String
        Dim chave As String
        Salvar()
        chave = retorna_Chave("cod_pagamento_credito", " pagamentos_credito", " where id_filial = " & conf.Filial & "")

        sql = "INSERT INTO pagamentos_credito " &
           "(cod_pagamento_credito " &
           ",cod_credito " &
           ",id_filial " &
           ",cod_lancamento) VALUES(" &
           chave &
           "," & _cod_credito &
           "," & conf.Filial &
           "," & cod_lancamento &
            ")"
        Return d.Comando(sql, True)
    End Function
End Class
