Public Class objBoletoCobranca

#Region "Variaveis"
    'Informações do Cedente
    Private _cedente_cod As String
    Private _cedente_nome As String
    Private _cedente_endereco As String
    Private _cedente_bairro As String
    Private _cedente_cep As String
    Private _cedente_cidade As String
    Private _cedente_uf As String
    Private _cedente_cnpj As String
    'Informações do Sacado
    Private _sacado_nome As String
    Private _sacado_endereco As String
    Private _sacado_bairro As String
    Private _sacado_cep As String
    Private _sacado_cidade As String
    Private _sacado_uf As String
    Private _sacado_cnpj As String
    'Informações do Boleto
    Private _boleto_nossonumero As String
    Private _boleto_convenio As String
    Private _boleto_agencia As String
    Private _boleto_agenciaDV As String
    Private _boleto_conta As String
    Private _boleto_contaDV As String
    Private _boleto_valor As String
    Private _boleto_vencimento As String
    Private _boleto_especiedoc As String
    Private _boleto_aceite As String
    Private _boleto_carteira As String
    Private _boleto_especie As String
#End Region

#Region "Funções"

    'MÓDULO 10 PARA CÁLCULO DE DÍGITO VERIFICADOR DOS CAMPOS DA LINHA DIGITÁVEL 
    Public Function Calculo_DV10(strNumero As String) As String
        'declara As variáveis
        Dim intContador As Integer
        Dim intNumero As Integer
        Dim intTotalNumero As Integer
        Dim intMultiplicador As Integer
        Dim intResto As Integer

        ' se nao for um valor numerico sai da função
        If Not IsNumeric(strNumero) Then
            Calculo_DV10 = ""
            Exit Function
        End If

        'inicia o multiplicador
        intMultiplicador = 2

        'pega cada caracter do numero a partir da direita
        For intContador = Len(strNumero) To 1 Step -1
            'extrai o caracter e multiplica pelo multiplicador
            intNumero = Val(Mid(strNumero, intContador, 1)) * intMultiplicador
            ' se o resultado for maior que nove soma os algarismos do resultado
            If intNumero > 9 Then
                intNumero = Val(Left(intNumero, 1)) + Val(Right(intNumero, 1))
            End If
            'soma o resultado para totalização
            intTotalNumero = intTotalNumero + intNumero

            'se o multiplicador for igual a 2 atribuir valor 1 se for 1 atribui 2
            intMultiplicador = IIf(intMultiplicador = 2, 1, 2)
        Next

        Dim DezenaSuperior As Integer
        If intTotalNumero < 10 Then
            DezenaSuperior = 10
        Else
            DezenaSuperior = 10 * (Val(Left(CStr(intTotalNumero), 1)) + 1)
        End If
        intResto = DezenaSuperior - intTotalNumero

        'verifica as exceções ( 0 -> DV=0 )
        Select Case intResto
            Case 0
                Calculo_DV10 = "0"
            Case Else
                Calculo_DV10 = Str(intResto)
        End Select
    End Function

    'MÓDULO 11 PARA CÁLCULO DE DÍGITO VERIFICADOR DE AGÊNCIA, CÓDIGO DE CEDENTE E NOSSO-NÚMERO
    Public Function Calculo_DV11(strNumero As String) As String
        'declara as variáveis
        Dim intContador As Integer
        Dim intNumero As Integer
        Dim intTotalNumero As Integer
        Dim intMultiplicador As Integer
        Dim intResto As Integer

        ' se nao for um valor numerico sai da função
        If Not IsNumeric(strNumero) Then
            Calculo_DV11 = ""
            Exit Function
        End If

        'inicia o multiplicador
        intMultiplicador = 9

        'pega cada caracter do numero a partir da direita
        For intContador = Len(strNumero) To 1 Step -1
            'extrai o caracter e multiplica prlo multiplicador
            intNumero = Val(Mid(strNumero, intContador, 1)) * intMultiplicador
            'soma o resultado para totalização
            intTotalNumero = intTotalNumero + intNumero
            'se o multiplicador for maior que 2 decrementa-o caso contrario atribuir valor padrao original
            intMultiplicador = IIf(intMultiplicador > 2, intMultiplicador - 1, 9)
        Next

        'calcula o resto da divisao do total por 11
        intResto = intTotalNumero Mod 11

        'verifica as exceções ( 0 -> DV=0    10 -> DV=X (para o BB) e retorna o DV
        Select Case intResto
            Case 0
                Calculo_DV11 = "0"
            Case 10
                Calculo_DV11 = "X"
            Case Else
                Calculo_DV11 = Str(intResto)
        End Select
    End Function


    'Função que iremos usar para montar o código de barras
    Public Function Monta_CodBarras(Banco As String, Moeda As String, valor As Single, vencimento As Date, Livre As String) As String
        Dim codigo_sequencia As String
        Dim database As Date
        Dim fator As Integer
        Dim intDac As Integer

        'database para calculo do fator
        database = CDate("7/10/1997")
        fator = DateDiff("d", database, CDate(vencimento))
        valor = Int(valor * 100)
        'Livre = Format(Livre, "0000000000000000000000000")

        ' sequencia sem o DV
        codigo_sequencia = Banco & Moeda & fator & Format(valor, "0000000000") & Livre
        'codigo_sequencia = Banco & Moeda & fator & teste & Livre

        ' calculo do DV
        intDac = calcula_DV_CodBarras(codigo_sequencia)

        ' monta a sequencia para o codigo de barras com o DV
        Monta_CodBarras = Left(codigo_sequencia, 4) & intDac & Right(codigo_sequencia, 39)
        'codigo_sequencia.Substring(0, 3) & codigo_sequencia.Substring(3, 1) & intDac & _
        'codigo_sequencia.Substring(4, 4) & codigo_sequencia.Substring(8, 10) & codigo_sequencia.Substring(18, 11) & _
        'codigo_sequencia.Substring(29, 4) & codigo_sequencia.Substring(33, 8) & codigo_sequencia.Substring(41, 2)

        'Left(codigo_sequencia, 4) & intDac & Right(codigo_sequencia, 39)
    End Function

    'A função que calcula o digito verificador do código de barras: 
    Public Function calcula_DV_CodBarras(sequencia As String) As Integer
        Dim intContador, intNumero, intTotalNumero As Integer
        Dim intMultiplicador, intResto, intresultado As Integer
        Dim caracter As String

        intMultiplicador = 2

        For intContador = 1 To 43
            caracter = Mid(Right(sequencia, intContador), 1, 1)
            If intMultiplicador > 9 Then
                intMultiplicador = 2
                intNumero = 0
            End If
            intNumero = caracter * intMultiplicador
            intTotalNumero = intTotalNumero + intNumero
            intMultiplicador = intMultiplicador + 1
        Next

        intResto = intTotalNumero Mod 11
        intresultado = 11 - intResto

        If intresultado = 10 Or intresultado = 11 Then
            calcula_DV_CodBarras = 1
        Else
            calcula_DV_CodBarras = intresultado
        End If
    End Function

    Public Function Linha_Digitavel(sequencia As String, DV_CodBarras As String, valor As Single) As String

        Dim seq1 As String
        Dim seq2 As String
        Dim seq3 As String

        Dim dv1, dv2, dv3 As Integer

        'separa a sequencia e prepara o valor
        seq1 = Left(sequencia, 9)
        seq2 = Mid(sequencia, 10, 10)
        seq3 = Right(sequencia, 10)
        valor = Int(valor * 100)

        ' calcula os dvs
        dv1 = Val(Calculo_DV10(seq1))
        dv2 = Val(Calculo_DV10(seq2))
        dv3 = Val(Calculo_DV10(seq3))

        'formata a sequencia
        seq1 = Left(seq1 & dv1, 5) & "." & Right(seq1 & dv1, 5)
        seq2 = Left(seq2 & dv2, 5) & "." & Right(seq2 & dv2, 6)
        seq3 = Left(seq3 & dv3, 5) & "." & Right(seq3 & dv3, 6)

        Linha_Digitavel = seq1 & " " & seq2 & " " & seq3 & " " & DV_CodBarras & " " & valor
    End Function

    Public Function Linha_Digitavel2(sequencia As String, vencimento As Date, valor As Single) As String

        Dim seq1 As String
        Dim seq2 As String
        Dim seq3 As String
        Dim campo1 As String
        Dim campo2 As String
        Dim campo3 As String
        Dim campo4 As String
        Dim campo5 As String
        Dim banco As String
        Dim moeda As String
        Dim strC As String
        Dim strD As String
        Dim strE As String
        Dim strK As String

        Dim dv1, dv2, dv3 As String

        banco = sequencia.Substring(0, 3)
        moeda = sequencia.Substring(3, 1)
        strC = sequencia.Substring(19, 5)
        dv1 = Calculo_DV10(banco & moeda & strC)
        campo1 = banco & moeda & Left(strC, 1) & "." & Right(strC, 4) & dv1

        strD = sequencia.Substring(23, 10)
        dv2 = Calculo_DV10(strD)
        campo2 = Left(strD, 5) & "." & Right(strD, 5) & dv2

        strE = sequencia.Substring(33, 10)
        dv3 = Calculo_DV10(strE)
        campo3 = Left(strE, 5) & "." & Right(strE, 5) & dv3

        strK = calcula_DV_CodBarras(sequencia)
        campo4 = strK

        Dim database As Date
        database = CDate("7/10/1997")
        Dim fator As Integer
        fator = DateDiff("d", database, CDate(vencimento))
        valor = Int(valor * 100)
        campo5 = fator & Format(valor, "0000000000")


        'separa a sequencia e prepara o valor
        'seq1 = Left(sequencia, 9)
        'seq2 = Mid(sequencia, 10, 10)
        'seq3 = Right(sequencia, 10)


        valor = Int(valor * 100)

        ' calcula os dvs
        'dv1 = Val(Calculo_DV10(seq1))
        'dv2 = Val(Calculo_DV10(seq2))
        'dv3 = Val(Calculo_DV10(seq3))

        'formata a sequencia
        'seq1 = Left(seq1 & dv1, 5) & "." & Right(seq1 & dv1, 5)
        'seq2 = Left(seq2 & dv2, 5) & "." & Right(seq2 & dv2, 6)
        'seq3 = Left(seq3 & dv3, 5) & "." & Right(seq3 & dv3, 6)

        Linha_Digitavel2 = campo1 & " " & campo2 & " " & campo3 & " " & strK & " " & campo5
    End Function
#End Region



End Class
