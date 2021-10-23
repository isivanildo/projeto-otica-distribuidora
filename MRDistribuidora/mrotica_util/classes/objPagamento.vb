Public Class objPagamento
    Inherits objLancamentos
    Dim conf As New config
    Private _cod_pagamento As Integer
    Private _cod_fat_cred As Integer
    Dim d As New dados
    Dim tPag As tipo_pagamento
    Public Enum tipo_pagamento
        Fatura = 1
        credito = 2
    End Enum
    Public Property cod_pagamento()
        Get
            cod_pagamento = _cod_pagamento
        End Get
        Set(ByVal value)
            _cod_pagamento = value
        End Set
    End Property
    Public Property cod_fat_cred()
        Get
            cod_fat_cred = _cod_fat_cred
        End Get
        Set(ByVal value)
            _cod_fat_cred = value
        End Set
    End Property
    Public Sub New(ByVal tipo As tipo_pagamento)
        tPag = tipo
    End Sub
    Public Sub novo_lancamento()
        novo()
        OrigemSalvar = "Novo"
        _cod_pagamento = Nothing
        _cod_fat_cred = Nothing
    End Sub
    Public Function salva_pag(ByVal tipo As tiposalvar) As String
        Dim sql As String
        Dim chave As String

        Salvar()

        If tPag = tipo_pagamento.Fatura Then
            chave = retorna_Chave("cod_pagamento_fatura", "pagamentos_fatura", " where id_filial = " & id_filial & "")
            sql = "Insert into pagamentos_fatura (cod_pagamento_fatura,cod_fatura,id_filial," & _
            "cod_lancamento,id_filial_lancamento) values(" & _
            chave & _
            "," & _cod_fat_cred & _
            "," & id_filial & _
            "," & cod_lancamento & _
            "," & id_filial_lancamento & ")"
            Return d.Comando(sql, True)

        Else

            chave = retorna_Chave("cod_pagamento_credito", " pagamentos_credito", " where id_filial = " & conf.Filial & "")

            sql = "INSERT INTO pagamentos_credito " & _
               "(cod_pagamento_credito " & _
               ",cod_credito " & _
               ",id_filial " & _
               ",cod_lancamento) VALUES(" & _
               chave & _
               "," & _cod_fat_cred & _
               "," & id_filial_lancamento & _
               "," & cod_lancamento & _
                ")"
            Return d.Comando(sql, True)
        End If
    End Function

End Class
