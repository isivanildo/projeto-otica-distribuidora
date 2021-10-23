using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace MRUtil
{
    public class ClienteOtica : EnderecoCli
    {
        ConexaoDB conexao = new ConexaoDB();
        public string CpfCnpj { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoFilial { get; set; }
        public string NomeCliente { get; set; }
        public string RazaoSocial { get; set; }
        public string Telefones { get; set; }
        public string TelefoneNFe { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Observacao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public char Sexo { get; set; }
        public string RgIe { get; set; }
        public string Email { get; set; }
        public int TipoIE { get; set; }
        public string TipoPessoa { get; set; }

        public ClienteOtica() { }

        public void Novo()
        {
            CpfCnpj = string.Empty;
            CodigoCliente = 0;
            CodigoFilial = 0;
            NomeCliente = string.Empty;
            RazaoSocial = string.Empty;
        }

        private int VerificaCampos()
        {
            if (string.IsNullOrEmpty(TipoPessoa))
                return 1;
            if (string.IsNullOrEmpty(CpfCnpj))
                return 2;
            if (string.IsNullOrEmpty(NomeCliente))
                return 3;
            if (string.IsNullOrEmpty(Logradouro))
                return 4;
            if (string.IsNullOrEmpty(Numero))
                return 5;
            if (string.IsNullOrEmpty(NomeCidade))
                return 6;
            if (string.IsNullOrEmpty(Uf))
                return 7;
            if (string.IsNullOrEmpty(Cep))
                return 8;
            if (TipoIE == 0)
                return 9;
            if (string.IsNullOrEmpty(Bairro))
                return 10;

            return 0;
        }
        public bool VerificaCampoObrigatorio()
        {
            bool resultado = false;

            switch (VerificaCampos())
            {
                case 1:
                    MessageBox.Show("Opção Tipo Pessoa é de escolha obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 2:
                    MessageBox.Show("Campo CPF/CNPJ é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 3:
                    MessageBox.Show("Campo Nome Cliente é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 4:
                    MessageBox.Show("Campo Logradouro é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 5:
                    MessageBox.Show("Campo Número é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 6:
                    MessageBox.Show("Campo Cidade é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 7:
                    MessageBox.Show("Campo UF é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 8:
                    MessageBox.Show("Campo CEP é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 9:
                    MessageBox.Show("Campo Tipo I.E é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 10:
                    MessageBox.Show("Campo Bairro é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
            }

            return resultado;

        }
        public void RetornaCliente(string xcpfcnpj)
        {
            string strSQL = "select * from cliente where cpf_cnpj = " + Geral.AspasSQL(xcpfcnpj);

            if (conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CpfCnpj = dr["cpf_cnpj"].ToString();
                    CodigoCliente = Convert.ToInt32(dr["cod_cliente"].ToString());
                    CodigoFilial = Convert.ToInt32(dr["cod_filial"].ToString());
                    NomeCliente = dr.GetStringOrEmpty("nome_cliente");
                    Logradouro = dr["endereco"].ToString();
                    Numero = dr["numero"].ToString();
                    Complemento = dr["complemento"].ToString();
                    Bairro = dr["bairro"].ToString();
                    NomeCidade = dr["cidade"].ToString();
                    CidadeIBGE = Convert.ToInt32(dr["cidade_ibge"].ToString());
                    Uf = dr["uf"].ToString();
                    UfIBGE = Convert.ToInt32(dr["uf_ibge"].ToString());
                    PaisIBGE = Convert.ToInt32(dr["pais"].ToString());
                    Cep = dr["cep"].ToString();
                    Telefones = dr["fones"].ToString();
                    TelefoneNFe = dr["fone_nfe"].ToString();
                    DataNascimento = Convert.ToDateTime(dr["data_nascimento"].ToString());
                    Observacao = dr["observacao"].ToString();
                    DataCadastro = Convert.ToDateTime(dr["data_cadastro"].ToString());
                    DataAlteracao = Convert.ToDateTime(dr["data_alteracao"].ToString());
                    Sexo = Convert.ToChar(dr["sexo"].ToString());
                    RgIe = dr["rg_ie"].ToString();
                    Email = dr["email"].ToString();
                    TipoIE = Convert.ToInt32(dr["tipoie"].ToString());
                    TipoPessoa = dr["cpf_cnpj"].ToString();
                }

                dr.Close();
            }

        }

        public void FiltraCliente(int xCodigoCliente)
        {
            Novo();
            string strSQL = "select * from cliente where cod_cliente = " + xCodigoCliente;

            if (conexao .ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CpfCnpj = dr["cnpj"].ToString();
                    CodigoCliente = Convert.ToInt32(dr["cod_cliente"].ToString());
                    CodigoFilial = Convert.ToInt32(dr["cod_filial_cliente"].ToString());
                    NomeCliente = dr.GetStringOrEmpty("nome_cliente");
                    Logradouro = dr["endereco"].ToString();
                    Numero = dr["numero"].ToString();
                    //Complemento = dr["complemento"].ToString();
                    //Bairro = dr["bairro"].ToString();
                    // NomeCidade = dr["cidade"].ToString();
                    // CidadeIBGE = Convert.ToInt32(dr["cidade_ibge"].ToString());
                    //Uf = dr["uf"].ToString();
                    // UfIBGE = Convert.ToInt32(dr["uf_ibge"].ToString());
                    // PaisIBGE = Convert.ToInt32(dr["pais"].ToString());
                    // Cep = dr["cep"].ToString();
                    //Telefones = dr["fones"].ToString();
                    //TelefoneNFe = dr["fone_nfe"].ToString();
                    //DataNascimento = Convert.ToDateTime(dr["data_nascimento"].ToString());
                    //Observacao = dr["observacao"].ToString();
                    //DataCadastro = Convert.ToDateTime(dr["data_cadastro"].ToString());
                    //DataAlteracao = Convert.ToDateTime(dr["data_alteracao"].ToString());
                    //Sexo = Convert.ToChar(dr["sexo"].ToString());
                    //RgIe = dr["rie"].ToString();
                    //Email = dr["email"].ToString();
                    // TipoIE = Convert.ToInt32(dr["tipoie"].ToString());
                    //TipoPessoa = dr["cpf_cnpj"].ToString();
                }
                dr.Close();
            }

        }
        public void SalvaCliente()
        {
            string strSQL = "insert into cliente(cpf_cnpj, cod_cliente, cod_filial_cliente, nome_cliente, endereco, numero, complemento, bairro, cidade, " +
                "cidade_ibge, uf, uf_ibge, pais, cep, fones, fone_nfe, data_nascimento, observacao, data_cadastro, data_alteracao, sexo, rg_ie, " +
                "email, tipoie, tipo_pessoa) values(" + Geral.AspasSQL(CpfCnpj) + "," + CodigoCliente + "," + CodigoFilial + "," +
                Geral.AspasSQL(NomeCliente) + "," + Geral.AspasSQL(Logradouro) + "," + Numero + "," + Geral.AspasSQL(Complemento) + "," +
                Geral.AspasSQL(Bairro) + "," + Geral.AspasSQL(NomeCidade) + "," + CidadeIBGE + "," + Geral.AspasSQL(Uf) + "," + UfIBGE + "," + PaisIBGE + "," +
                Geral.AspasSQL(Cep) + "," + Geral.AspasSQL(Telefones) + "," + Geral.AspasSQL(TelefoneNFe) + "," + Geral.DataSQL(DataNascimento.ToString()) + "," +
                Geral.AspasSQL(Observacao) + "," + Geral.DataSQL(DataCadastro.ToString()) + "," + Geral.DataSQL(DataAlteracao.ToString()) + "," +
                Geral.AspasSQL(Sexo.ToString()) + "," + Geral.AspasSQL(RgIe) + "," + Geral.AspasSQL(Email) + "," + TipoIE + "," +
                Geral.AspasSQL(TipoPessoa.ToString()) + ")";

            conexao.SalvaAtualizaExcluiReg(strSQL);
        }

    }
}
