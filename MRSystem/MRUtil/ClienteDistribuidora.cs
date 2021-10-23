using System;
using System.Data.SqlClient;

namespace MRUtil
{
    public class ClienteDistribuidora : EnderecoCli
    {
        ConexaoDB conexao = new ConexaoDB();
        public string CpfCnpj { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoFilialCliente { get; set; }
        public char TipoPessoa { get; set; }
        public string NomeCliente { get; set; }
        public string RazaoSocial { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public char Sexo { get; set; }
        public string RgIe { get; set; }
        public int TipoIE { get; set; }
        public string InscMunicipal { get; set; }
        public byte Foto { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public decimal LimiteCredito { get; set; }
        public int QtdeDiaPagar { get; set; }
        public bool Situacao { get; set; }

        public ClienteDistribuidora() { }

        public void RetornaCliente(int codigo)
        {
            string strSQL = "select * from cliente where cod_cliente = " + codigo;

            if (conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CodigoCliente = Convert.ToInt32(dr["cod_cliente"].ToString());
                    NomeCliente = dr.GetStringOrEmpty("razao_social");
                }
            }
        }

        public void SalvaCliente()
        {
            string strSQL = "insert into cliente(cpf_cnpj, cod_cliente, cod_filial_cliente, nome_cliente, endereco, numero, complemento, bairro, cidade, " +
                "cidadeibge, uf, ufibge, cep, fones, data_nascimento, observacao, data_cadastro, data_alteracao, sexo, rg_ie, " +
                "email, tipoinscricaoestadual, tipo_pessoa) values(" + CodigoCliente + "," + CodigoFilialCliente + "," + Geral.AspasSQL(NomeCliente) + "," +
                Geral.AspasSQL(Logradouro) + "," + Numero + "," + Geral.AspasSQL(Complemento) + "," + Geral.AspasSQL(Bairro) + "," +
                Geral.AspasSQL(NomeCidade) + "," + CidadeIBGE + "," + Geral.AspasSQL(Uf) + "," + UfIBGE + "," + Geral.AspasSQL(Cep) + "," +
                Geral.AspasSQL(Telefone) + "," + Geral.DataSQL(DataNascimento.ToString()) + "," + Geral.AspasSQL(Observacao) + "," +
                Geral.DataSQL(DataCadastro.ToString()) + "," + Geral.DataSQL(DataAlteracao.ToString()) + "," + Geral.AspasSQL(Sexo.ToString()) + "," +
                Geral.AspasSQL(RgIe) + "," + Geral.AspasSQL(Email) + "," + TipoIE + "," + Geral.AspasSQL(TipoPessoa.ToString()) + ")";

            conexao.SalvaAtualizaExcluiReg(strSQL);
        }

    }
}
