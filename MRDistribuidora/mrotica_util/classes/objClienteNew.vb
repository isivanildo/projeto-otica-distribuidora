Public Class ObjClienteNew

    Dim d As New dados()
    Public Property CodigoFilialCliente As Integer
    Public Property CodigoCliente As Integer
    Public Property NomeCliente As String
    Public Property Endereco As String
    Public Property Complemento As String
    Public Property Bairro As String
    Public Property Cidade As String
    Public Property UF As String
    Public Property Cep As String
    Public Property Numero As String
    Public Property CodigoCidade As Integer

    Public Property Fone As String
    Public Property CPF As String
    Public Property TipoIE As Integer

    Public Sub New()
        CodigoFilialCliente = Nothing
        CodigoCliente = Nothing
        NomeCliente = Nothing
        Endereco = Nothing
        Complemento = Nothing
        Bairro = Nothing
        Cidade = Nothing
        UF = Nothing
        Cep = Nothing
        Numero = Nothing
        Fone = Nothing
        CPF = Nothing
        CodigoCidade = Nothing
        TipoIE = Nothing
    End Sub

    Public Sub RetornaCliente(ByVal x_CodigoCliente As Integer, ByVal x_FilialCliente As Integer)
        Dim tb As New DataTable()

        d.carrega_Tabela("select * from cliente where codigo_filial_cliente = " & x_FilialCliente &
                         " and codigo_cliente = " & x_CodigoCliente, tb)

        If tb.Rows.Count > 0 Then
            CodigoFilialCliente = tb.Rows(0)("codigo_filial_cliente").ToString()
            CodigoCliente = tb.Rows(0)("codigo_cliente").ToString()
            NomeCliente = tb.Rows(0)("nome_cliente").ToString()
            Endereco = tb.Rows(0)("endereco").ToString()
            Complemento = tb.Rows(0)("complemento").ToString()
            Bairro = tb.Rows(0)("bairro").ToString()
            Cidade = tb.Rows(0)("municipio").ToString()
            Cep = tb.Rows(0)("cep").ToString()
            Numero = tb.Rows(0)("numero").ToString()
            UF = tb.Rows(0)("uf").ToString()
            CodigoCidade = tb.Rows(0)("codigo_cidade")
            Fone = tb.Rows(0)("fones").ToString()
            CPF = tb.Rows(0)("cpf").ToString()
            TipoIE = tb.Rows(0)("tipoinscricaoestadual").ToString()
        End If

    End Sub




End Class
