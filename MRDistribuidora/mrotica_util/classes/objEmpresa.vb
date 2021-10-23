Imports System.Windows.Forms

Public Class objEmpresa

    Dim conn As New dados()
    Dim tb As DataTable = New DataTable()

    Public Property Filial As Integer?
    Public Property TipoPessoa As Char
    Public Property RazaoSocial As String
    Public Property NomeFantasia As String
    Public Property Logradouro As String
    Public Property Numero As String
    Public Property Complemento As String
    Public Property Bairro As String
    Public Property Cep As String
    Public Property CidadeIBGE As Integer?
    Public Property NomeCidade As String
    Public Property Uf As String
    Public Property UfIBGE As Integer?
    Public Property Pais As String
    Public Property PaisIBGE As Integer?
    Public Property TelefoneFixo As String
    Public Property TelefoneCel As String
    Public Property CnpjCpf As String
    Public Property CpfCnpjAutBaixaXml As String
    Public Property TipoInscricao As Integer?
    Public Property InscricaoEstadual As String
    Public Property IESubtitutoTributario As String
    Public Property InscricaoMunicipal As String
    Public Property CNAEFiscal As Integer?
    Public Property CRT As Integer?
    Public Property NumeroNFe As Integer?
    Public Property NumeroNFCE As Integer?
    Public Property SerieNFe As Integer?
    Public Property SerieNFCe As Integer?
    Public Property ModeloNFE As Integer?
    Public Property ModeloNFCE As Integer?
    Public Property Certificado As String
    Public Property LogoTipo As Byte
    Public Property Email As String
    Public Property Observacao As String
    Public Property Situacao As Boolean
    Public Property ZonaHoraria As String
    Public Property Producao As Boolean
    Public Property DataCadastro As DateTime?
    Public Property DataAlteracao As DateTime?
    Public Property WebService As String

    Public Sub New()

    End Sub

    Private Function VerificaCampos() As Integer
        If String.IsNullOrEmpty(CnpjCpf) Then Return 1
        If String.IsNullOrEmpty(Convert.ToString(Filial)) Then Return 2
        If String.IsNullOrEmpty(TipoPessoa.ToString()) Then Return 3
        If String.IsNullOrEmpty(RazaoSocial) Then Return 4
        If String.IsNullOrEmpty(NomeFantasia) Then Return 5
        If String.IsNullOrEmpty(Cep) Then Return 6
        If String.IsNullOrEmpty(Logradouro) Then Return 7
        If String.IsNullOrEmpty(Bairro) Then Return 8
        If String.IsNullOrEmpty(CidadeIBGE.ToString()) Then Return 9
        If String.IsNullOrEmpty(UfIBGE.ToString()) Then Return 10
        If String.IsNullOrEmpty(PaisIBGE.ToString()) Then Return 11
        If String.IsNullOrEmpty(InscricaoEstadual) Then Return 12
        If String.IsNullOrEmpty(CRT.ToString()) Then Return 13
        If String.IsNullOrEmpty(CNAEFiscal.ToString()) Then Return 14
        If String.IsNullOrEmpty(SerieNFe.ToString()) Then Return 15
        If String.IsNullOrEmpty(SerieNFCe.ToString()) Then Return 16
        If String.IsNullOrEmpty(ModeloNFE.ToString()) Then Return 17
        If String.IsNullOrEmpty(ModeloNFCE.ToString()) Then Return 18
        If String.IsNullOrEmpty(NumeroNFe.ToString()) Then Return 19
        If String.IsNullOrEmpty(NumeroNFCE.ToString()) Then Return 20
        If String.IsNullOrEmpty(ZonaHoraria) Then Return 21
        If String.IsNullOrEmpty(WebService) Then Return 22

        Return 0
    End Function


    Public Function VerificaCampoObrigatorio() As Boolean
        Dim resultado As Boolean = False

        Select Case VerificaCampos()
            Case 1
                MessageBox.Show("Campo CNPJ é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 2
                MessageBox.Show("Campo Filial é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 3
                MessageBox.Show("Campo Tipo Pessoa é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 4
                MessageBox.Show("Campo Razão Social é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 5
                MessageBox.Show("Campo Nome Fantasia é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 6
                MessageBox.Show("Campo CEP é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 7
                MessageBox.Show("Campo Endereço é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 8
                MessageBox.Show("Campo Bairro é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 9
                MessageBox.Show("Campo Cidade é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 10
                MessageBox.Show("Campo UF é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 11
                MessageBox.Show("Campo País é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 12
                MessageBox.Show("Campo Inscrição Estadual é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 13
                MessageBox.Show("Campo CRT é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 14
                MessageBox.Show("Campo CNAE é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 15
                MessageBox.Show("Campo Série NF-e é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 16
                MessageBox.Show("Campo Série NFC-e é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 17
                MessageBox.Show("Campo Modelo NF-e é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 18
                MessageBox.Show("Campo Modelo NFC-e é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 19
                MessageBox.Show("Campo Número Nota Fiscal é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 20
                MessageBox.Show("Campo Número Cupom Fiscal é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 21
                MessageBox.Show("Campo Zona Horária é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
            Case 21
                MessageBox.Show("Campo WebService é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                resultado = True
        End Select

        Return resultado
    End Function

    Public Sub Registro(ByVal x_cnpjcpf As String)
        conn.carrega_Tabela("select * from emitente where cnpj_cpf = '" & x_cnpjcpf & "'", tb)

        If tb.Rows.Count > 0 Then
            CnpjCpf = tb.Rows(0)("cnpj_cpf").ToString()
            Filial = Convert.ToInt32(tb.Rows(0)("filial"))
            RazaoSocial = tb.Rows(0)("razao_social").ToString()
            NomeFantasia = tb.Rows(0)("nome_fantasia").ToString()
            Cep = tb.Rows(0)("cep").ToString()
            Logradouro = tb.Rows(0)("endereco").ToString()
            Numero = tb.Rows(0)("Numero").ToString()
            Complemento = tb.Rows(0)("complemento").ToString()
            Bairro = tb.Rows(0)("bairro").ToString()
            CidadeIBGE = Convert.ToInt32(tb.Rows(0)("cidade"))
            UfIBGE = Convert.ToInt32(tb.Rows(0)("uf"))
            PaisIBGE = Convert.ToInt32(tb.Rows(0)("pais"))
            TelefoneFixo = tb.Rows(0)("telefone_fixo").ToString()
            TelefoneCel = tb.Rows(0)("telefone_cel").ToString()
            TipoInscricao = rdNum(tb.Rows(0)("t_inscricao").ToString())
            InscricaoEstadual = tb.Rows(0)("i_estadual").ToString()
            IESubtitutoTributario = tb.Rows(0)("ie_st").ToString()
            InscricaoMunicipal = tb.Rows(0)("i_municipal").ToString()
            CpfCnpjAutBaixaXml = tb.Rows(0)("cnpjcpf_aut_xml").ToString()
            CRT = Convert.ToInt32(tb.Rows(0)("crt").ToString())
            CNAEFiscal = Convert.ToInt32(tb.Rows(0)("cnae").ToString())
            SerieNFe = Convert.ToInt32(tb.Rows(0)("serie").ToString())
            SerieNFCe = Convert.ToInt32(tb.Rows(0)("serienfce").ToString())
            ModeloNFE = Convert.ToInt32(tb.Rows(0)("modelo").ToString())
            ModeloNFCE = Convert.ToInt32(tb.Rows(0)("modelonfce").ToString())
            NumeroNFe = Convert.ToInt32(tb.Rows(0)("Numero_nfe"))
            NumeroNFCE = Convert.ToInt32(tb.Rows(0)("Numeronfce"))
            Certificado = tb.Rows(0)("certificado").ToString()
            'LogoTipo = Convert.ToByte(tb.Rows(0)("logo_tipo"))
            Email = tb.Rows(0)("email").ToString()
            ZonaHoraria = tb.Rows(0)("zonahoraria").ToString()
            Producao = Convert.ToBoolean(tb.Rows(0)("producao"))
            DataCadastro = rdData(Convert.ToDateTime(tb.Rows(0)("data_cad")))
            DataAlteracao = rdData(tb.Rows(0)("data_alt"))
            Situacao = Convert.ToBoolean(tb.Rows(0)("situacao"))
            TipoPessoa = tb.Rows(0)("TipoPessoa").ToString()
            WebService = tb.Rows(0)("WebService").ToString()
        End If
    End Sub

    Public Sub Registro(ByVal filial As Int16)
        conn.carrega_Tabela("select * from emitente where filial = " & filial, tb)

        If tb.Rows.Count > 0 Then
            CnpjCpf = tb.Rows(0)("cnpj_cpf").ToString()
            filial = Convert.ToInt32(tb.Rows(0)("filial"))
            RazaoSocial = tb.Rows(0)("razao_social").ToString()
            NomeFantasia = tb.Rows(0)("nome_fantasia").ToString()
            Cep = tb.Rows(0)("cep").ToString()
            Logradouro = tb.Rows(0)("endereco").ToString()
            Numero = tb.Rows(0)("Numero").ToString()
            Complemento = tb.Rows(0)("complemento").ToString()
            Bairro = tb.Rows(0)("bairro").ToString()
            CidadeIBGE = Convert.ToInt32(tb.Rows(0)("cidade"))
            UfIBGE = Convert.ToInt32(tb.Rows(0)("uf"))
            PaisIBGE = Convert.ToInt32(tb.Rows(0)("pais"))
            TelefoneFixo = tb.Rows(0)("telefone_fixo").ToString()
            TelefoneCel = tb.Rows(0)("telefone_cel").ToString()
            TipoInscricao = rdNum(tb.Rows(0)("t_inscricao").ToString())
            InscricaoEstadual = tb.Rows(0)("i_estadual").ToString()
            IESubtitutoTributario = tb.Rows(0)("ie_st").ToString()
            InscricaoMunicipal = tb.Rows(0)("i_municipal").ToString()
            CpfCnpjAutBaixaXml = tb.Rows(0)("cnpjcpf_aut_xml").ToString()
            CRT = Convert.ToInt32(tb.Rows(0)("crt").ToString())
            CNAEFiscal = Convert.ToInt32(tb.Rows(0)("cnae").ToString())
            SerieNFe = Convert.ToInt32(tb.Rows(0)("serie").ToString())
            SerieNFCe = Convert.ToInt32(tb.Rows(0)("serienfce").ToString())
            ModeloNFE = Convert.ToInt32(tb.Rows(0)("modelo").ToString())
            ModeloNFCE = Convert.ToInt32(tb.Rows(0)("modelonfce").ToString())
            NumeroNFe = Convert.ToInt32(tb.Rows(0)("Numero_nfe"))
            NumeroNFCE = Convert.ToInt32(tb.Rows(0)("Numeronfce"))
            Certificado = tb.Rows(0)("certificado").ToString()
            'LogoTipo = Convert.ToByte(tb.Rows(0)("logo_tipo"))
            Email = tb.Rows(0)("email").ToString()
            ZonaHoraria = tb.Rows(0)("zonahoraria").ToString()
            Producao = Convert.ToBoolean(tb.Rows(0)("producao"))
            DataCadastro = rdData(Convert.ToDateTime(tb.Rows(0)("data_cad")))
            DataAlteracao = rdData(tb.Rows(0)("data_alt"))
            Situacao = Convert.ToBoolean(tb.Rows(0)("situacao"))
            TipoPessoa = tb.Rows(0)("TipoPessoa").ToString()
            WebService = tb.Rows(0)("WebService").ToString()
        End If
    End Sub

    Public Sub SalvaEmpresa()
        Dim strSQL As String = "insert into emitente(cnpj_cpf, filial, razao_social, nome_fantasia, cep, endereco, Numero, " &
            "complemento, bairro, cidade, uf, pais, telefone_fixo, telefone_cel, t_inscricao, i_estadual, ie_st, i_municipal, " &
            "cnpjcpf_aut_xml, crt, cnae, serie, modelo, Numero_nfe, certificado, logo_tipo, email, zonahoraria, producao, " &
            "data_cad, data_alt, situacao, modelonfce, numeronfce, serienfce) values(" & objGeral.AspasSQL(CnpjCpf) & "," & objGeral.NumeroSQL(Filial) & "," &
            objGeral.AspasSQL(RazaoSocial) & "," & objGeral.AspasSQL(NomeFantasia) & "," & objGeral.AspasSQL(Cep) & "," &
            objGeral.AspasSQL(Logradouro) & "," & objGeral.AspasSQL(Numero) & "," & objGeral.AspasSQL(Complemento) & "," &
        objGeral.AspasSQL(Bairro) & "," & CidadeIBGE & "," & UfIBGE & "," & PaisIBGE & "," & objGeral.AspasSQL(TelefoneFixo) & "," &
        objGeral.AspasSQL(TelefoneCel) & "," & objGeral.NumeroSQL(TipoInscricao) & "," & objGeral.AspasSQL(InscricaoEstadual) & "," &
        objGeral.AspasSQL(IESubtitutoTributario) & "," & objGeral.AspasSQL(InscricaoMunicipal) & "," &
        objGeral.AspasSQL(CpfCnpjAutBaixaXml) & "," & CRT & "," & CNAEFiscal & "," & SerieNFe & "," & ModeloNFE & "," &
        NumeroNFe & "," & objGeral.AspasSQL(Certificado) & "," & objGeral.AspasSQL(Convert.ToString(LogoTipo)) & "," &
        objGeral.AspasSQL(Email) & "," & objGeral.AspasSQL(ZonaHoraria) & "," & objGeral.AspasSQL(Convert.ToString(Producao)) & "," &
        objGeral.DataSQL(DataCadastro.ToString()) & "," & objGeral.DataSQL(DataAlteracao.ToString()) & "," &
        objGeral.AspasSQL(Situacao.ToString()) & "," & ModeloNFCE & "," & NumeroNFCE & "," & SerieNFCe & ")"
        conn.ComandoSQL(strSQL, False)
    End Sub


End Class
