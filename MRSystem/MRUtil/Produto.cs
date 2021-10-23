using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRUtil
{
    public class Produto
    {
        ConexaoDB Conexao = new ConexaoDB();
        public int CodigoProduto { get; set; }
        public int CodigoFabricante { get; set; }
        public int CodigoLente { get; set; }
        public string CodigoBarra { get; set; }
        public int? CodigoGrupo { get; set; }
        public string ProdutoDescricao { get; set; }
        public string Unidade { get; set; }
        public decimal? EstoqueMinimo { get; set; }
        public decimal? EstoqueMaximo { get; set; }
        public decimal? PrecoCusto { get; set; }
        public decimal? PrecoVenda { get; set; }
        public decimal? PrecoTabela { get; set; }
        public decimal? Desconto { get; set; }
        public string Observacao { get; set; }
        public decimal? FatorPreco { get; set; }
        public int? Estoque { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal DescontoCompra { get; set; }
        public long NCM { get; set; }
        public int CodigoTributacao { get; set; }
        public int? Origem { get; set; }
        public string GTIN { get; set; }
        public int? CEST { get; set; }
        public string Referencia { get; set; }
        public bool ControlaEstoque { get; set; }

        public Produto() {}

        public virtual void Novo()
        {
            CodigoProduto = 0;
            CodigoFabricante = 0;
            CodigoLente = 0;
            CodigoBarra = string.Empty;
            CodigoGrupo = 0;
            ProdutoDescricao = string.Empty;
            Unidade = string.Empty;
            EstoqueMinimo = 0;
            EstoqueMaximo = 0;
            PrecoCusto = 0;
            PrecoVenda = 0;
            PrecoTabela = 0;
            Desconto = 0;
            Observacao = string.Empty;
            FatorPreco = 1;
            Estoque = 0;
            PrecoCompra = 0;
            DescontoCompra = 0;
            NCM = 0;
            CodigoTributacao = 0;
            Origem = 0;
            GTIN = "SEM GTIN";
            CEST = 0;
            Referencia = string.Empty;
            ControlaEstoque = false;
        }

        public virtual void RetornaRegistro(int xCodigoProduto)
        {
            //Conexao.AbreConexaoBanco();
            string strSQL = "Select * from produtos where cod_produto = " + xCodigoProduto;
            SqlCommand cmd = new SqlCommand(strSQL, Conexao.Conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CodigoProduto = Convert.ToInt32(dr["cod_produto"]);
                CodigoFabricante = Convert.ToInt32(dr["id_fabricante"]);
                CodigoLente = Convert.ToInt32(dr["cod_lente"]);
                CodigoBarra = dr["cod_barra"].ToString();
                CodigoGrupo = Convert.ToInt32(dr["cod_grupo"]);
                ProdutoDescricao = dr["produto"].ToString();
                Unidade = dr["unidade"].ToString();
                if (dr["min_estoque"] != DBNull.Value)
                {
                    EstoqueMinimo = Convert.ToDecimal(dr["min_estoque"]);
                }
                else
                {
                    EstoqueMinimo = null;
                }
                if (dr["max_estoque"] != DBNull.Value)
                {
                    EstoqueMaximo = Convert.ToDecimal(dr["max_estoque"]);
                }
                else
                {
                    EstoqueMaximo = null;
                }

                PrecoCusto = Convert.ToDecimal(dr["preco_custo"]);
                PrecoVenda = Convert.ToDecimal(dr["preco_venda"]);
                PrecoTabela = Convert.ToDecimal(dr["preco_tabela"]);
                Desconto = Convert.ToDecimal(dr["desconto"]);
                Observacao = dr["observacao"].ToString();
                FatorPreco = Convert.ToDecimal(dr["fator_preco"]);
                Estoque = Convert.ToInt32(dr["estoque"]);
                PrecoCompra = Convert.ToDecimal(dr["preco_compra"]);
                DescontoCompra = Convert.ToDecimal(dr["desconto_compra"]);
                NCM = Convert.ToInt32(dr["ncm"]);
                CodigoTributacao = Convert.ToInt32(dr["tributacao"]);
                if (dr["origem"] != DBNull.Value)
                {
                    Origem = Convert.ToInt32(dr["origem"]);
                }
                else
                {
                    Origem = null;
                }
                
                GTIN = dr["gtin"].ToString();

                if (dr["cest"] != DBNull.Value)
                {
                    CEST = Convert.ToInt32(dr["cest"]);
                }
                else
                {
                    CEST = null;
                }

                Referencia = dr["referencia"].ToString();
                ControlaEstoque = Convert.ToBoolean(dr["controla_estoque"].ToString());
                
            }

            dr.Close();
        }
        public Int64 Chave()
        {
            return Conexao.RetornaChave("cod_produto", "produtos", "");
        }
        public void SalvaProduto()
        {
            string strSQL = "";
            
            strSQL = "Insert into produtos (cod_produto, id_fabricante, cod_lente, cod_barra, cod_grupo, produto, unidade, min_estoque, " +
                "max_estoque, preco_custo, preco_venda, preco_tabela, desconto, observacao, fator_preco, estoque, preco_compra, desconto_compra, " +
                "ncm, tributacao, origem, gtin, cest, referencia, controla_estoque) VALUES (" + CodigoProduto + "," + CodigoFabricante + "," + CodigoLente + "," + 
                Geral.AspasSQL(CodigoBarra) + "," + CodigoGrupo + "," + Geral.AspasSQL(ProdutoDescricao) + "," + Geral.AspasSQL(Unidade) + "," + 
                Geral.ValorMoeda(EstoqueMinimo) + "," +  Geral.ValorMoeda(EstoqueMaximo) + "," + Geral.ValorMoeda(PrecoCusto) + "," + 
                Geral.ValorMoeda(PrecoVenda) + "," + Geral.ValorMoeda(PrecoTabela) + "," + Geral.ValorMoeda(Desconto) + "," + Geral.AspasSQL(Observacao) + "," + 
                Geral.ValorMoeda(FatorPreco) + "," + Estoque + "," + Geral.ValorMoeda(PrecoCompra) + "," + Geral.ValorMoeda(DescontoCompra) + "," + NCM + "," + 
                CodigoTributacao + "," + Origem + "," + Geral.AspasSQL(GTIN) + "," + Geral.NumeroSQL(CEST) + "," + Geral.AspasSQL(Referencia) + "," +
                Geral.AspasSQL(ControlaEstoque.ToString()) + ")";

            Conexao.SalvaAtualizaExcluiReg(strSQL);

        }

        public void AtualizaProduto()
        {
            string strSQL = "";

            strSQL = "update produtos set id_fabricante = " + CodigoFabricante + "," + "cod_lente = " + CodigoLente + "," + "cod_barra = " + CodigoBarra + "," + 
                "cod_grupo = " + CodigoGrupo + "," + "produto = " + Geral.AspasSQL(ProdutoDescricao) + "," + "unidade = " + Geral.AspasSQL(Unidade) + "," +
                "min_estoque = " + Geral.ValorMoeda(EstoqueMinimo) + "," + "max_estoque = " + Geral.ValorMoeda(EstoqueMaximo) + "," + 
                "preco_custo = " + Geral.ValorMoeda(PrecoCusto) + "," + "preco_venda = " + Geral.ValorMoeda(PrecoVenda) + "," + 
                "preco_tabela = " + Geral.ValorMoeda(PrecoTabela) + "," + "desconto = " + Geral.ValorMoeda(Desconto) + "," + 
                "observacao = " + Geral.AspasSQL(Observacao) + "," + "fator_preco = " + Geral.ValorMoeda(FatorPreco) + "," + 
                "estoque = " +  Estoque + "," + "preco_compra = " + Geral.ValorMoeda(PrecoCompra) + "," + 
                "desconto_compra = " + Geral.ValorMoeda(DescontoCompra) + "," + "ncm = " + NCM  + "," + "tributacao = " + CodigoTributacao + "," +
                "origem = " + Origem + "," + "gtin = " + Geral.AspasSQL(GTIN) + "," + "cest = " +  Geral.NumeroSQL(CEST) + "," + 
                "referencia = " + Geral.AspasSQL(Referencia) + "," + "controla_estoque = " + Geral.AspasSQL(ControlaEstoque.ToString()) + 
                " where cod_produto = " + CodigoProduto;

            Conexao.SalvaAtualizaExcluiReg(strSQL);

        }

        public AutoCompleteStringCollection  CarregaListaProduto()
        {
            AutoCompleteStringCollection _Lista = new AutoCompleteStringCollection();

            string strSQL = "select * from lentes_blocos lb inner join lentes_tabela lt on lb.cod_tabela = lt.cod_tabela";

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
                            _Lista.Add(dr["nome_comercial"].ToString() + "-" + dr["cod_tabela"].ToString()

                            );
                        }

                    }
                }
            }

            return _Lista;
        }

 
        public AutoCompleteStringCollection CarregaListaCliente()
        {
            AutoCompleteStringCollection _Lista = new AutoCompleteStringCollection();

            string strSQL = "select * from cliente";

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
                            _Lista.Add(dr["nome_cliente"].ToString()

                            );
                        }
                    }
                }
            }

            return _Lista;
        }

    }
}
