using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace MRUtil
{
    public class Servicos : Produto 
    {
        ConexaoDB Conexao = new ConexaoDB();
        public int CodigoServico { get; set; }
        public int CodigoTipoServico { get; set; }  
        public decimal DescontoPacote { get; set; }
        public decimal ValorComDesconto { get; set; }
        public decimal ValorTotalProduto { get; set; }
        public int QuantidadePacote { get; set; }
        
        public decimal TotalSurfacagem { get; set; }
        public decimal TotalMontagem { get; set; }
        public decimal TotalTratamento { get; set; }
        public int Prazo { get; set; }

        private DataTable tb;
        private int intPosicao = 0;
        public int intPonteiro = 0;
        public int intContador = 0;
        private int intTotal = 0;
        public string TotalReg;
        public string ParametroPesquisa;
        public Servicos() { }

        public override void Novo()
        {
            CodigoProduto = 0;
            CodigoServico = 0;
            CodigoTipoServico = 0;
            CodigoFabricante = 0;
            CodigoGrupo = 0;
            Unidade = string.Empty;
            Prazo = 0;
            ProdutoDescricao = string.Empty;
            PrecoCusto = 0;
            PrecoVenda = 0;
            PrecoTabela = 0;
            Desconto = 0;
            FatorPreco = 1;
            Estoque = 0;
            NCM = 0;
            Observacao = string.Empty;
            CodigoTributacao = 0;
            Origem = 0;
            ControlaEstoque = false;
        }

        public override void RetornaRegistro(int xCodigoServico)
        {
            string strSQL = "select * from servicos where cod_Servico = " + xCodigoServico;

            using (SqlConnection conn = new SqlConnection(Conexao.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CodigoProduto = Convert.ToInt32(dr["cod_produto"].ToString());
                            CodigoServico = Convert.ToInt32(dr["cod_servico"].ToString());
                            CodigoTipoServico = Convert.ToInt32(dr["cod_tipo_servico"].ToString());
                            Prazo = Convert.ToInt32(dr["prazo"].ToString());
                        }
                    }
                }
            }

        }

        public List<Servicos> RetornaServicos(int xCodigoServico)
        {
            string strSQL = "SELECT servicos.cod_produto,produtos.produto FROM produtos " +
                "INNER JOIN servicos ON produtos.cod_produto = servicos.cod_produto WHERE " +
                "servicos.cod_tipo_servico = " + xCodigoServico;

            List<Servicos> _lista = new List<Servicos>();

            using (SqlConnection conn = new SqlConnection(Conexao.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            _lista.Add(new Servicos()
                            {
                                CodigoProduto = Convert.ToInt32(dr["cod_produto"].ToString()),
                                ProdutoDescricao = dr["produto"].ToString()
                            });
                        }
                    }
                }
            }

            return _lista;
        }

        public void RetornaValorProdutoServico(int xCodigo)
        {
            string strSQL = "SELECT preco_venda, preco_tabela FROM produtos where " +
                "cod_produto = " + xCodigo;
            using (SqlConnection conn = new SqlConnection(Conexao.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PrecoTabela = Convert.ToDecimal(reader["preco_tabela"].ToString());
                            PrecoVenda = Convert.ToDecimal(reader["preco_venda"].ToString());
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Calcula o valor total de cada item do pacote - baseado no preço e quantidade
        /// </summary>
        public decimal CalculaPrecoFinalItemPacote()
        {      
            ValorComDesconto = (decimal)(PrecoTabela) - ((decimal)PrecoTabela * (DescontoPacote/100));

            ValorTotalProduto = ValorComDesconto * QuantidadePacote;

            return ValorTotalProduto;
        }

        public DataTable RetornaRegistroPesquisa()
        {
            string strSQL = "select s.*, p.produto, p.id_fabricante, p.preco_custo, p.preco_venda, p.observacao from servicos s " +
                "inner join produtos p on s.cod_produto = p.cod_produto where p.produto like '%" + ParametroPesquisa + "%' and p.cod_grupo = 4";

            tb = new DataTable();
            Conexao.CarregaTabela(strSQL, ref tb);

            intTotal = tb.Rows.Count;

            return tb;
        }
        public void PrimeiroRegistro()
        {
            RetornaRegistroPesquisa();

            if (tb.Rows.Count > 0)
            {
                intPosicao = 0;
                intPonteiro = 1;
                intContador = tb.Rows.Count;

                TotalReg = string.Format("{0} de {1}", intPonteiro, tb.Rows.Count);

                CodigoProduto = Convert.ToInt32(tb.Rows[intPosicao]["cod_produto"].ToString());
                CodigoServico = Convert.ToInt32(tb.Rows[intPosicao]["cod_servico"].ToString());
                CodigoTipoServico = Convert.ToInt32(tb.Rows[intPosicao]["cod_tipo_servico"].ToString());
                CodigoFabricante = Convert.ToInt32(tb.Rows[intPosicao]["id_fabricante"].ToString());
                Prazo = Convert.ToInt32(tb.Rows[intPosicao]["prazo"].ToString());
                ProdutoDescricao = tb.Rows[intPosicao]["produto"].ToString();
                PrecoCusto = Convert.ToDecimal(tb.Rows[intPosicao]["preco_custo"].ToString());
                PrecoVenda = Convert.ToDecimal(tb.Rows[intPosicao]["preco_venda"].ToString());
                Observacao = tb.Rows[intPosicao]["observacao"].ToString();
            }

        }

        public void UltimoRegistro()
        {
            RetornaRegistroPesquisa();

            if (tb.Rows.Count > 0)
            {
                intPosicao = tb.Rows.Count - 1;
                intPonteiro = tb.Rows.Count;

                TotalReg = string.Format("{0} de {1}", intPonteiro, tb.Rows.Count);

                CodigoProduto = Convert.ToInt32(tb.Rows[intPosicao]["cod_produto"].ToString());
                CodigoServico = Convert.ToInt32(tb.Rows[intPosicao]["cod_servico"].ToString());
                CodigoTipoServico = Convert.ToInt32(tb.Rows[intPosicao]["cod_tipo_servico"].ToString());
                CodigoFabricante = Convert.ToInt32(tb.Rows[intPosicao]["id_fabricante"].ToString());
                Prazo = Convert.ToInt32(tb.Rows[intPosicao]["prazo"].ToString());
                ProdutoDescricao = tb.Rows[intPosicao]["produto"].ToString();
                PrecoCusto = Convert.ToDecimal(tb.Rows[intPosicao]["preco_custo"].ToString());
                PrecoVenda = Convert.ToDecimal(tb.Rows[intPosicao]["preco_venda"].ToString());
                Observacao = tb.Rows[intPosicao]["observacao"].ToString();
            }
        }

        public void ProximoRegistro()
        {
            RetornaRegistroPesquisa();

            if (intPosicao < tb.Rows.Count - 1)
            {
                intPosicao = intPosicao + 1;
                intPonteiro = intPosicao + 1;
                intContador = tb.Rows.Count;

                TotalReg = string.Format("{0} de {1}", intPonteiro, tb.Rows.Count);

                CodigoProduto = Convert.ToInt32(tb.Rows[intPosicao]["cod_produto"].ToString());
                CodigoServico = Convert.ToInt32(tb.Rows[intPosicao]["cod_servico"].ToString());
                CodigoTipoServico = Convert.ToInt32(tb.Rows[intPosicao]["cod_tipo_servico"].ToString());
                CodigoFabricante = Convert.ToInt32(tb.Rows[intPosicao]["id_fabricante"].ToString());
                Prazo = Convert.ToInt32(tb.Rows[intPosicao]["prazo"].ToString());
                ProdutoDescricao = tb.Rows[intPosicao]["produto"].ToString();
                PrecoCusto = Convert.ToDecimal(tb.Rows[intPosicao]["preco_custo"].ToString());
                PrecoVenda = Convert.ToDecimal(tb.Rows[intPosicao]["preco_venda"].ToString());
                Observacao = tb.Rows[intPosicao]["observacao"].ToString();
            }
        }

        public void AnteriorRegistro()
        {
            RetornaRegistroPesquisa();

            if (intPosicao == tb.Rows.Count -1 || intPosicao != 0)
            {
                intPosicao = intPosicao - 1;

                intPonteiro = intPosicao + 1;
                intContador = tb.Rows.Count;

                TotalReg = string.Format("{0} de {1}", intPonteiro, tb.Rows.Count);

                CodigoProduto = Convert.ToInt32(tb.Rows[intPosicao]["cod_produto"].ToString());
                CodigoServico = Convert.ToInt32(tb.Rows[intPosicao]["cod_servico"].ToString());
                CodigoTipoServico = Convert.ToInt32(tb.Rows[intPosicao]["cod_tipo_servico"].ToString());
                CodigoFabricante = Convert.ToInt32(tb.Rows[intPosicao]["id_fabricante"].ToString());
                Prazo = Convert.ToInt32(tb.Rows[intPosicao]["prazo"].ToString());
                ProdutoDescricao = tb.Rows[intPosicao]["produto"].ToString();
                PrecoCusto = Convert.ToDecimal(tb.Rows[intPosicao]["preco_custo"].ToString());
                PrecoVenda = Convert.ToDecimal(tb.Rows[intPosicao]["preco_venda"].ToString());
                Observacao = tb.Rows[intPosicao]["observacao"].ToString();
            }
        }

        public void SalvarServico()
        {
            string strSQL = string.Empty;

            strSQL = "insert into produtos(cod_produto, id_fabricante, cod_grupo, produto, unidade, preco_custo, preco_venda, preco_tabela, observacao, desconto, " +
                "fator_preco, estoque, ncm, tributacao, origem, controla_estoque) values(" + CodigoProduto + "," + CodigoFabricante + "," + CodigoGrupo + "," +
                Geral.AspasSQL(ProdutoDescricao) + "," + Geral.AspasSQL(Unidade) + "," + Geral.ValorMoeda(PrecoCusto) + "," + Geral.ValorMoeda(PrecoVenda) + "," +
                Geral.ValorMoeda(PrecoTabela) + "," + Geral.AspasSQL(Observacao) + "," + Geral.ValorMoeda(Desconto) + "," + Geral.ValorMoeda(FatorPreco) + "," + 
                Estoque + "," + NCM + "," + CodigoTributacao + "," + Origem + "," + Geral.AspasSQL(ControlaEstoque.ToString()) + ")";

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                strSQL = "insert into servicos(cod_produto, cod_servico, cod_tipo_servico, prazo) values(" + CodigoProduto + "," +
                    CodigoServico + "," + CodigoTipoServico + "," + Prazo + ")";

                Conexao.SalvaAtualizaExcluiReg(strSQL);
            }

        }

        public void ExcluirServico(int xCodigoServico, int xCodigoProduto)
        {
            string strSQL = string.Empty;

            strSQL = "delete from servicos where cod_servico = " + CodigoServico;

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                strSQL = "delete from produtos where cod_produto = " + CodigoProduto;
                Conexao.SalvaAtualizaExcluiReg(strSQL);
            }

        }

        public void AtualizaServico()
        {
            string strSQL = "update servicos set cod_tipo_servico = " + CodigoTipoServico + "," + "prazo = " + Prazo + " " +
                "where cod_produto = " + CodigoProduto + " and cod_servico = " + CodigoServico;

            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        private int VerificaCampos()
        {
            if (string.IsNullOrEmpty(ProdutoDescricao))
                return 1;
            if (string.IsNullOrEmpty(Convert.ToString(PrecoVenda)))
                return 2;
            if (string.IsNullOrEmpty(CodigoFabricante.ToString()) || CodigoFabricante == 0)
                return 3;
            if (string.IsNullOrEmpty(CodigoTipoServico.ToString()) || CodigoTipoServico == 0)
                return 4;

            return 0;
        }

        public bool VerificaCampoObrigatorio()
        {
            bool resultado = false;
            switch (VerificaCampos())
            {
                case 1:
                    MessageBox.Show("Campo Descrição do Serviço é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 2:
                    MessageBox.Show("Campo Preço Venda é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 3:
                    MessageBox.Show("Campo Fabricante é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 4:
                    MessageBox.Show("Campo Tipo de Serviço é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;

            }

            return resultado;

        }
    }
}
