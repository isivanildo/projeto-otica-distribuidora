using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class Estoque
    {
        ConexaoDB Conexao = new ConexaoDB();
        public int CodigoMovimento { get; set; }
        public int CodigoLancamento { get; set; }
        public int CodigoNatureza { get; set; }
        public int CodigoFilial { get; set; }
        public DateTime Data { get; set; }
        public string Documento { get; set; }
        public int CodigoUsuario { get; set; }
        public string Concluido { get; set; }
        public int Item { get; set; }
        public int Codigoproduto { get; set; }
        public decimal Desconto { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal EstoqueFisico { get; set; }
        public decimal EstoqueFinanceiro { get; set; }
        public int StatusMov { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal DescontoVenda { get; set; }
        public string Historico { get; set; }
        public decimal ICMS { get; set; }
        public decimal IPI { get; set; }
        public DateTime DataLancamento { get; set; }
        public decimal Saldo { get; set; }

        public Estoque() { }

        public bool SalvaMovimentoMaster()
        {
            bool resultado = false;

            CodigoMovimento = Convert.ToInt32(Conexao.RetornaChave("cod_movimento", "movimentomaster", ""));

            string strSQL = "insert into movimentomaster(cod_movimento, cod_natureza, id_filial, data, doc, id_usuario, concluido) values(" +
                CodigoMovimento + "," + CodigoNatureza + "," + CodigoFilial + "," + Geral.DataSQL(Data.ToString()) + "," + Geral.AspasSQL(Documento) + "," +
                CodigoUsuario + "," + Geral.AspasSQL(Concluido) + ")";

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }

        public void SalvaMovimentaEstoque()
        {
            CodigoLancamento = Convert.ToInt32(Conexao.RetornaChave("cod_lancamento", "movimento", ""));

            string strSQL = "insert into movimento(cod_lancamento, id_filial, item, cod_movimento, cod_produto, desconto, punit, quant, estoquefis, estoquefin, " +
                "status, pvenda, descvenda, historico, icms, ipi, data_lancamento) values(" + CodigoLancamento + "," + CodigoFilial + "," + Item + "," +
                CodigoMovimento + "," + Codigoproduto + "," + Geral.ValorMoeda(Desconto) + "," + Geral.ValorMoeda(PrecoUnitario) + "," +
                Geral.ValorMoeda(Quantidade) + "," + Geral.ValorMoeda(EstoqueFisico) + "," + Geral.ValorMoeda(EstoqueFinanceiro) + "," + StatusMov + "," +
                Geral.ValorMoeda(PrecoVenda) + "," + Geral.ValorMoeda(DescontoVenda) + "," + Geral.AspasSQL(Historico) + "," +
                Geral.ValorMoeda(ICMS) + "," + Geral.ValorMoeda(IPI) + "," + Geral.DataSQL(DataLancamento.ToString()) + ")";

            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public decimal RetornaSaldo()
        {
            string strSQL = "select isnull(sum(quant),0) as saldo from movimento where cod_produto = " + Codigoproduto + " and id_filial = " + CodigoFilial;

            if (Conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, Conexao.Conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Saldo = Convert.ToDecimal(dr["saldo"]);
                }
            }

            return Saldo;
            
        }
    }
}
