
Public Class objPagFatura
    Inherits objLancamentos
    Private _cod_pagamento_fatura As Integer
    Private _cod_fatura As Integer
    Dim d As New dados
    Dim confi As New config

    Public Property cod_pagamento_fatura()
        Get
            cod_pagamento_fatura = _cod_pagamento_fatura
        End Get
        Set(ByVal value)
            _cod_pagamento_fatura = value
        End Set
    End Property
    Public Property cod_fatura()
        Get
            cod_fatura = _cod_fatura
        End Get
        Set(ByVal value)
            _cod_fatura = value
        End Set
    End Property
    Public Sub novo_lancamento()
        novo()
        OrigemSalvar = "Novo"
        _cod_pagamento_fatura = Nothing
        _cod_fatura = Nothing
    End Sub
    Public Function salva_pag() As String
        Dim sql As String
        Dim chave As String
        Salvar()
        chave = retorna_Chave("cod_pagamento_fatura", "pagamentos_fatura", " where id_filial = " & id_filial & "")

        sql = "Insert into pagamentos_fatura (cod_pagamento_fatura,cod_fatura,id_filial," & _
        "cod_lancamento,id_filial_lancamento) values(" & _
        chave & _
        "," & _cod_fatura & _
        "," & id_filial & _
        "," & cod_lancamento & _
        "," & id_filial_lancamento & ")"
        Return d.Comando(sql, True)
    End Function
End Class
