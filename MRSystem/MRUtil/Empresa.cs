using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Reflection;

namespace MRUtil
{
    public class Empresa
    {
        ConexaoDB conexao = new ConexaoDB();
        DataTable tb = new DataTable();

        public int? Filial { get; set; }
        public char TipoPessoa { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int? CidadeIBGE { get; set; }
        public string NomeCidade { get; set; }
        public string Uf { get; set; }
        public int? UfIBGE { get; set; }
        public string Pais { get; set; }
        public int? PaisIBGE { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCel { get; set; }
        public string CnpjCpf { get; set; }
        public string CpfCnpjAutBaixaXml { get; set; }
        public string InscricaoEstadual { get; set; }
        public string IESubtitutoTributario { get; set; }
        public string InscricaoMunicipal { get; set; }
        public int? CNAEFiscal { get; set; }
        public int? CRT { get; set; }
        public int? NumeroNFe { get; set; }
        public int? NumeroNFCe { get; set; }
        public int? SerieNFe { get; set; }
        public int? SerieNFCe { get; set; }
        public int? ModeloNFe { get; set; }
        public int? ModeloNFCe { get; set; }
        public string Certificado { get; set; }
        public byte? LogoTipo { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public bool Situacao { get; set; }
        public string ZonaHoraria { get; set; }
        public bool Producao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string WebService { get; set; }
        public string IdEmpresa { get; set; }
        public string IdSistemaNFe { get; set; }
        public string IdSistemaNFCe { get; set; }
        public string IdSistemaNFeCan { get; set; }
        public string IdSistemaNFCeCan { get; set; }
        public string IdSistemaNFeCCe { get; set; }
        public string IdSistemaInutilizaNFe { get; set; }
        public string CodigoCSC { get; set; }
        public string InformacaoCompelentar { get; set; }
        public string Impressora { get; set; }
        public bool DLLInicializada { get; set; }

        public string MensagemRetorno { get; private set; }

        public Empresa()
        {

        }

        public Empresa(int xFilial)
        {
            string strSQL = "select * from emitente where filial= " + xFilial;

            if (conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CnpjCpf = dr["cnpj_cpf"].ToString();
                        Filial = dr.GetInt16OrNull("filial");
                        RazaoSocial = dr["razao_social"].ToString();
                        NomeFantasia = dr["nome_fantasia"].ToString();
                        Cep = dr["cep"].ToString();
                        Logradouro = dr["endereco"].ToString();
                        Numero = dr["Numero"].ToString();
                        Complemento = dr["complemento"].ToString();
                        Bairro = dr["bairro"].ToString();
                        CidadeIBGE = dr.GetInt32OrNull("cidade");
                        UfIBGE = dr.GetInt16OrNull("uf");
                        PaisIBGE = dr.GetInt16OrNull("pais");
                        TelefoneFixo = dr.GetStringOrEmpty("telefone_fixo");
                        TelefoneCel = dr.GetStringOrEmpty("telefone_cel");
                        InscricaoEstadual = dr.GetStringOrEmpty("i_estadual");
                        IESubtitutoTributario = dr.GetStringOrNull("ie_st");
                        InscricaoMunicipal = dr.GetStringOrNull("i_municipal");
                        CpfCnpjAutBaixaXml = dr.GetStringOrNull("cnpjcpf_aut_xml");
                        CRT = dr.GetInt16OrNull("crt");
                        CNAEFiscal = dr.GetInt16OrNull("cnae");
                        SerieNFe = dr.GetInt16OrNull("serie");
                        SerieNFCe = dr.GetInt16OrNull("serienfce");
                        ModeloNFe = dr.GetInt16OrNull("modelo");
                        ModeloNFCe = dr.GetInt16OrNull("modelonfce");
                        NumeroNFe = dr.GetInt32OrNull("numero_nfe");
                        NumeroNFCe = dr.GetInt32OrNull("numeronfce");
                        Certificado = dr.GetStringOrNull("certificado");
                        //LogoTipo = Convert.ToByte(tb.Rows[0]["logo_tipo"]);
                        Email = dr.GetStringOrNull("email");
                        ZonaHoraria = dr.GetStringOrNull("zonahoraria");
                        Producao = dr.GetBoolean("producao");
                        DataCadastro = dr.GetDateTimeOrNull("data_cad");
                        DataAlteracao = dr.GetDateTimeOrNull("data_alt");
                        Situacao = dr.GetBoolean("situacao");
                        TipoPessoa = Convert.ToChar(dr["tipopessoa"].ToString());
                        WebService = dr.GetStringOrNull("webservice");
                        IdEmpresa = dr.GetStringOrEmpty("idempresa");
                        IdSistemaNFe = dr.GetStringOrEmpty("idsistemanfe");
                        IdSistemaNFCe = dr.GetStringOrEmpty("idsistemanfce");
                        IdSistemaNFeCan = dr.GetStringOrEmpty("idsistemanfecan");
                        IdSistemaNFCeCan = dr.GetStringOrEmpty("idsistemanfcecan");
                        IdSistemaNFeCCe = dr.GetStringOrEmpty("idsistemanfecce");
                        IdSistemaInutilizaNFe = dr.GetStringOrEmpty("idsistemainutizanfe");
                        CodigoCSC = dr.GetStringOrEmpty("codigocsc");
                        InformacaoCompelentar = dr.GetStringOrEmpty("infocomplementar");
                        Impressora = dr.GetStringOrEmpty("impressora");
                    }
                }
            }

        }

        private int VerificaCampos()
        {
            if (string.IsNullOrEmpty(CnpjCpf))
                return 1;
            if (string.IsNullOrEmpty(Convert.ToString(Filial)))
                return 2;
            if (string.IsNullOrEmpty(RazaoSocial))
                return 3;
            if (string.IsNullOrEmpty(NomeFantasia))
                return 4;
            if (string.IsNullOrEmpty(Cep))
                return 5;
            if (string.IsNullOrEmpty(Logradouro))
                return 6;
            if (string.IsNullOrEmpty(Bairro))
                return 7;
            if (string.IsNullOrEmpty(CidadeIBGE.ToString()))
                return 8;
            if (string.IsNullOrEmpty(UfIBGE.ToString()))
                return 9;
            if (string.IsNullOrEmpty(PaisIBGE.ToString()))
                return 10;
            if (string.IsNullOrEmpty(InscricaoEstadual))
                return 11;
            if (string.IsNullOrEmpty(CRT.ToString()))
                return 12;
            if (string.IsNullOrEmpty(CNAEFiscal.ToString()))
                return 13;
            if (string.IsNullOrEmpty(SerieNFe.ToString()))
                return 14;
            if (string.IsNullOrEmpty(ModeloNFe.ToString()))
                return 15;
            if (string.IsNullOrEmpty(NumeroNFe.ToString()))
                return 16;
            if (string.IsNullOrEmpty(ZonaHoraria))
                return 17;
            if (string.IsNullOrEmpty(SerieNFCe.ToString()))
                return 18;
            if (string.IsNullOrEmpty(ModeloNFCe.ToString()))
                return 19;
            if (string.IsNullOrEmpty(NumeroNFCe.ToString()))
                return 20;


            return 0;
        }

        public bool VerificaCampoObrigatorio()
        {
            bool resultado = false;
            switch (VerificaCampos())
            {
                case 1:
                    MensagemRetorno = "Campo CNPJ é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 2:
                    MensagemRetorno = "Campo Filial é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 3:
                    MensagemRetorno = "Campo Razão Social é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 4:
                    MensagemRetorno = "Campo Nome Fantasia é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 5:
                    MensagemRetorno = "Campo CEP é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 6:
                    MensagemRetorno = "Campo Endereço é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 7:
                     MensagemRetorno = "Campo Bairro é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 8:
                    MensagemRetorno = "Campo Cidade é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 9:
                    MensagemRetorno = "Campo UF é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 10:
                    MensagemRetorno = "Campo País é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 11:
                     MensagemRetorno = "Campo Inscrição Estadual é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 12:
                    MensagemRetorno = "Campo CRT é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 13:
                     MensagemRetorno = "Campo CNAE é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 14:
                    MensagemRetorno = "Campo Série NF-e é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 15:
                    MensagemRetorno = "Campo Modelo NF-e é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 16:
                    MensagemRetorno = "Campo Número Nota Fiscal é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 17:
                    MensagemRetorno = "Campo Zona Horária é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 18:
                    MensagemRetorno = "Campo Série NFC-e é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 19:
                    MensagemRetorno = "Campo Modelo NFC-e é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 20:
                    MensagemRetorno = "Campo Número Cupom Fiscal é de preenchimento obrigatório!";
                    resultado = true;
                    break;
            }

            return resultado;

        }

        public List<Empresa> CarregaRegistro()
        {
            List<Empresa> _Lista = new List<Empresa>();

            string strSQL = "select * from emitente";

            conexao.AbreConexaoBanco();

            if (conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    _Lista.Add(new Empresa()
                    {
                        CnpjCpf = dr.GetStringOrEmpty("cnpj_cpf").ToString(),
                        Filial = Convert.ToInt32(dr["filial"]),
                        RazaoSocial = dr["razao_social"].ToString(),
                        NomeFantasia = dr["nome_fantasia"].ToString(),
                        Cep = dr["cep"].ToString(),
                        Logradouro = dr["endereco"].ToString(),
                        Numero = dr["Numero"].ToString(),
                        Complemento = dr["complemento"].ToString(),
                        Bairro = dr["bairro"].ToString(),
                        CidadeIBGE = Convert.ToInt32(dr["cidade"]),
                        UfIBGE = Convert.ToInt32(dr["uf"]),
                        PaisIBGE = Convert.ToInt32(dr["pais"]),
                        TelefoneFixo = dr["telefone_fixo"].ToString(),
                        TelefoneCel = dr["telefone_cel"].ToString(),
                        InscricaoEstadual = dr["i_estadual"].ToString(),
                        IESubtitutoTributario = dr["ie_st"].ToString(),
                        InscricaoMunicipal = dr["i_municipal"].ToString(),
                        CpfCnpjAutBaixaXml = dr["cnpjcpf_aut_xml"].ToString(),
                        CRT = Convert.ToInt32(dr["crt"].ToString()),
                        CNAEFiscal = Convert.ToInt32(dr["cnae"].ToString()),
                        SerieNFe = Convert.ToInt32(dr["serie"].ToString()),
                        SerieNFCe = Convert.ToInt32(dr["serienfce"].ToString()),
                        ModeloNFe = Convert.ToInt32(dr["modelo"].ToString()),
                        ModeloNFCe = Convert.ToInt32(dr["modelonfce"].ToString()),
                        NumeroNFe = Convert.ToInt32(dr["numero_nfe"]),
                        NumeroNFCe = Convert.ToInt32(dr["numeronfce"]),
                        Certificado = dr["certificado"].ToString(),
                        LogoTipo = dr.GetByteOrNull("logo_tipo"),
                        Email = dr.GetStringOrEmpty("email"),
                        ZonaHoraria = dr["zonahoraria"].ToString(),
                        Producao = Convert.ToBoolean(dr["producao"]),
                        DataCadastro = dr.GetDateTimeOrNull("data_cad"),
                        DataAlteracao = dr.GetDateTimeOrNull("data_alt"),
                        Situacao = Convert.ToBoolean(dr["situacao"]),
                        TipoPessoa = Convert.ToChar(dr["tipopessoa"].ToString()),
                        WebService = dr["webservice"].ToString(),
                        IdEmpresa = dr["idempresa"].ToString(),
                        IdSistemaNFe = dr["idsistemanfe"].ToString(),
                        IdSistemaNFCe = dr["idsistemanfce"].ToString(),
                        IdSistemaNFeCan = dr["idsistemanfecan"].ToString(),
                        IdSistemaNFCeCan = dr["idsistemanfcecan"].ToString(),
                        IdSistemaNFeCCe = dr["idsistemanfecce"].ToString(),
                        IdSistemaInutilizaNFe = dr["idsistemainutizanfe"].ToString(),
                        CodigoCSC = dr["codigocsc"].ToString(),
                        InformacaoCompelentar = dr.GetStringOrEmpty("infocomplementar"),
                        Impressora = dr.GetStringOrEmpty("impressora")
                    });
                }

                dr.Close();
            }
            return _Lista;
        }

        public void RetornaRegistro(string x_cnpjcpf)
        {
            string strSQL = "select * from emitente where cnpj_cpf = " + Geral.AspasSQL(x_cnpjcpf);

            if (conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CnpjCpf = dr["cnpj_cpf"].ToString();
                        Filial = dr.GetInt16OrNull("filial");
                        RazaoSocial = dr["razao_social"].ToString();
                        NomeFantasia = dr["nome_fantasia"].ToString();
                        Cep = dr["cep"].ToString();
                        Logradouro = dr["endereco"].ToString();
                        Numero = dr["Numero"].ToString();
                        Complemento = dr["complemento"].ToString();
                        Bairro = dr["bairro"].ToString();
                        CidadeIBGE = dr.GetInt32OrNull("cidade");
                        UfIBGE = dr.GetInt16OrNull("uf");
                        PaisIBGE = dr.GetInt16OrNull("pais");
                        TelefoneFixo = dr.GetStringOrEmpty("telefone_fixo");
                        TelefoneCel = dr.GetStringOrEmpty("telefone_cel");
                        InscricaoEstadual = dr.GetStringOrEmpty("i_estadual");
                        IESubtitutoTributario = dr.GetStringOrNull("ie_st");
                        InscricaoMunicipal = dr.GetStringOrNull("i_municipal");
                        CpfCnpjAutBaixaXml = dr.GetStringOrNull("cnpjcpf_aut_xml");
                        CRT = dr.GetInt16OrNull("crt");
                        CNAEFiscal = dr.GetInt16OrNull("cnae");
                        SerieNFe = dr.GetInt16OrNull("serie");
                        SerieNFCe = dr.GetInt16OrNull("serienfce");
                        ModeloNFe = dr.GetInt16OrNull("modelo");
                        ModeloNFCe = dr.GetInt16OrNull("modelonfce");
                        NumeroNFe = dr.GetInt32OrNull("numero_nfe");
                        NumeroNFCe = dr.GetInt32OrNull("numeronfce");
                        Certificado = dr.GetStringOrNull("certificado");
                        //LogoTipo = Convert.ToByte(tb.Rows[0]["logo_tipo"]);
                        Email = dr.GetStringOrNull("email");
                        ZonaHoraria = dr.GetStringOrNull("zonahoraria");
                        Producao = dr.GetBoolean("producao");
                        DataCadastro = dr.GetDateTimeOrNull("data_cad");
                        DataAlteracao = dr.GetDateTimeOrNull("data_alt");
                        Situacao = dr.GetBoolean("situacao");
                        TipoPessoa = Convert.ToChar(dr["tipopessoa"].ToString());
                        WebService = dr.GetStringOrNull("webservice");
                        IdEmpresa = dr.GetStringOrEmpty("idempresa");
                        IdSistemaNFe = dr.GetStringOrEmpty("idsistemanfe");
                        IdSistemaNFCe = dr.GetStringOrEmpty("idsistemanfce");
                        IdSistemaNFeCan = dr.GetStringOrEmpty("idsistemanfecan");
                        IdSistemaNFCeCan = dr.GetStringOrEmpty("idsistemanfcecan");
                        IdSistemaNFeCCe = dr.GetStringOrEmpty("idsistemanfecce");
                        IdSistemaInutilizaNFe = dr.GetStringOrEmpty("idsistemainutizanfe");
                        CodigoCSC = dr.GetStringOrEmpty("codigocsc");
                        InformacaoCompelentar = dr.GetStringOrEmpty("infocomplementar");
                        Impressora = dr.GetStringOrEmpty("impressora");
                    }
                }
            }
        }

        public bool SalvaEmpresa()
        {
            bool resultado = false;

            string strSQL = "insert into emitente(cnpj_cpf, filial, razao_social, nome_fantasia, cep, endereco, Numero, complemento," +
                "bairro, cidade, uf, pais, telefone_fixo, telefone_cel, i_estadual, ie_st, i_municipal, " +
                "cnpjcpf_aut_xml, crt, cnae, serie, modelo, Numero_nfe, certificado, logo_tipo, email, zonahoraria, producao, " +
                "data_cad, data_alt, situacao, modelonfce, numeronfce, serienfce, tipopessoa, webservice, idempresa, idsistemanfe, idsistemanfce, " + "" +
                "idsistemanfecan, idsistemanfcecan, idsistemanfecce, idsistemainutizanfe, codigocsc, infocomplementar, impressora) values(" +
                Geral.AspasSQL(CnpjCpf) + "," + Geral.NumeroSQL(Filial) + "," + Geral.AspasSQL(RazaoSocial) + "," + Geral.AspasSQL(NomeFantasia) + "," +
                Geral.AspasSQL(Cep) + "," + Geral.AspasSQL(Logradouro) + "," + Geral.AspasSQL(Numero) + "," + Geral.AspasSQL(Complemento) + "," +
                Geral.AspasSQL(Bairro) + "," + CidadeIBGE + "," + UfIBGE + "," + PaisIBGE + "," + Geral.AspasSQL(TelefoneFixo) + "," +
                Geral.AspasSQL(TelefoneCel) + "," + Geral.AspasSQL(InscricaoEstadual) + "," + Geral.AspasSQL(IESubtitutoTributario) + "," +
                Geral.AspasSQL(InscricaoMunicipal) + "," + Geral.AspasSQL(CpfCnpjAutBaixaXml) + "," + CRT + "," + CNAEFiscal + "," + SerieNFe + "," +
                ModeloNFe + "," + NumeroNFe + "," + Geral.AspasSQL(Certificado) + "," + Geral.AspasSQL(Convert.ToString(LogoTipo)) + "," +
                Geral.AspasSQL(Email) + "," + Geral.AspasSQL(ZonaHoraria) + "," + Geral.AspasSQL(Convert.ToString(Producao)) + "," +
                Geral.DataSQL(DataCadastro.ToString()) + "," + Geral.DataSQL(DataAlteracao.ToString()) + "," + Geral.AspasSQL(Situacao.ToString()) + "," +
                ModeloNFCe + "," + NumeroNFCe + "," + SerieNFCe + "," + Geral.AspasSQL(TipoPessoa.ToString()) + "," + Geral.AspasSQL(WebService) + "," +
                Geral.AspasSQL(IdEmpresa) + "," + Geral.AspasSQL(IdSistemaNFe) + "," + Geral.AspasSQL(IdSistemaNFCe) + "," +
                Geral.AspasSQL(IdSistemaNFeCan) + "," + Geral.AspasSQL(IdSistemaNFCeCan) + "," + Geral.AspasSQL(IdSistemaNFeCCe) + "," +
                Geral.AspasSQL(IdSistemaInutilizaNFe) + "," + Geral.AspasSQL(CodigoCSC) + "," + Geral.AspasSQL(InformacaoCompelentar) + "," +
                Geral.AspasSQL(Impressora) + ")";

            if (conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }

        public bool AtualizaEmpresa()
        {
            bool resultado = false;

            string strSQL = "update emitente set filial = " + Geral.NumeroSQL(Filial) + "," + "razao_social = " + Geral.AspasSQL(RazaoSocial) + "," +
                "nome_fantasia = " + Geral.AspasSQL(NomeFantasia) + "," + "cep = " + Geral.AspasSQL(Cep) + "," + "endereco = " + Geral.AspasSQL(Logradouro) + "," +
                "Numero = " + Geral.AspasSQL(Numero) + "," + "complemento = " + Geral.AspasSQL(Complemento) + "," + "bairro = " + Geral.AspasSQL(Bairro) + "," +
                "cidade = " + CidadeIBGE + "," + "uf = " + UfIBGE + "," + "pais = " + PaisIBGE + "," + "telefone_fixo = " + Geral.AspasSQL(TelefoneFixo) + "," +
                "telefone_cel = " + Geral.AspasSQL(TelefoneCel) + "," + "i_estadual = " + Geral.AspasSQL(InscricaoEstadual) + "," +
                "ie_st = " + Geral.AspasSQL(IESubtitutoTributario) + "," + "i_municipal = " + Geral.AspasSQL(InscricaoMunicipal) + "," +
                "cnpjcpf_aut_xml = " + Geral.AspasSQL(CpfCnpjAutBaixaXml) + "," + "crt = " + CRT + "," + "cnae = " + CNAEFiscal + "," + "serie = " + SerieNFe + "," +
                "modelo = " + ModeloNFe + "," + "Numero_nfe = " + NumeroNFe + "," + "certificado = " + Geral.AspasSQL(Certificado) + "," +
                "logo_tipo = " + Geral.AspasSQL(Convert.ToString(LogoTipo)) + "," + "email = " + Geral.AspasSQL(Email) + "," +
                "zonahoraria = " + Geral.AspasSQL(ZonaHoraria) + "," + "producao = " + Geral.AspasSQL(Convert.ToString(Producao)) + "," +
                "data_cad = " + Geral.DataSQL(DataCadastro.ToString()) + "," + "data_alt = " + Geral.DataSQL(DataAlteracao.ToString()) + "," +
                "situacao = " + Geral.AspasSQL(Situacao.ToString()) + "," + "modelonfce = " + ModeloNFCe + "," + "numeronfce = " + NumeroNFCe + "," +
                "serienfce = " + SerieNFCe + "," + "tipopessoa = " + Geral.AspasSQL(TipoPessoa.ToString()) + "," + "webservice = " + Geral.AspasSQL(WebService) + "," +
                "idempresa = " + Geral.AspasSQL(IdEmpresa) + "," + "idsistemanfe = " + Geral.AspasSQL(IdSistemaNFe) + "," +
                "idsistemanfce = " + Geral.AspasSQL(IdSistemaNFCe) + "," + "idsistemanfecan = " + Geral.AspasSQL(IdSistemaNFeCan) + "," +
                "idsistemanfcecan = " + Geral.AspasSQL(IdSistemaNFCeCan) + "," + "idsistemanfecce = " + Geral.AspasSQL(IdSistemaNFeCCe) + "," +
                "idsistemainutizanfe = " + Geral.AspasSQL(IdSistemaInutilizaNFe) + "," + "codigocsc = " + Geral.AspasSQL(CodigoCSC) + "," +
                "infocomplementar = " + Geral.AspasSQL(InformacaoCompelentar) + "," + "impressora = " + Geral.AspasSQL(Impressora) + " where " +
                "cnpj_cpf = " + Geral.AspasSQL(CnpjCpf);

            if (conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }

        public bool ExcluirEmpresa(string xCnpj)
        {
            bool resultado = false;

            string strSQL = "delete from emitente where cnpj_cpf = " + Geral.AspasSQL(xCnpj);

            if (conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }

        public void AtualizaNumeroNota(string tipoNota)
        {
            int numeroNota = 0;
            string strSQL = "update emitente set ";
            if (tipoNota == "NFe")
            {
                numeroNota = Convert.ToInt32(NumeroNFe) + 1;
                strSQL += "numero_nfe = " + numeroNota;
            }
            else
            {
                numeroNota = Convert.ToInt32(NumeroNFCe) + 1;
                strSQL += "numeronfce = " + numeroNota;
            }

            strSQL += " where cnpj_cpf = " + Geral.AspasSQL(CnpjCpf);

            conexao.SalvaAtualizaExcluiReg(strSQL);
        }

    }
}
