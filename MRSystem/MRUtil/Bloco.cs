using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class Bloco
    {
        ConexaoDB Conexao = new ConexaoDB();
        public int CodigoProduto { get; set; }
        public decimal? BaseNominal { get; set; }
        public decimal? Adicao { get; set; }
        public string Olho { get; set; }
        public decimal? EsfericoMaior { get; set; }
        public decimal? EsfericoMenor { get; set; }

        public Bloco() { }
        public void Novo()
        {
            CodigoProduto = 0;
            BaseNominal = null;
            Adicao = null;
            Olho = string.Empty;
            EsfericoMaior = null;
            EsfericoMenor = null;
        }

        public void RetornaRegistro(int codigoproduto)
        {
            string strSQL = "select * from blocos where cod_produto = " + codigoproduto;

            if (Conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, Conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.CodigoProduto = Convert.ToInt32(dr["cod_lente"]);
                    this.BaseNominal = Convert.ToDecimal(dr["cod_tabela"]);
                    this.Adicao = Convert.ToDecimal(dr["adicao"]);
                    this.Olho = dr["olho"].ToString();
                    this.EsfericoMaior = Convert.ToDecimal(dr["esf_maior"]);
                    this.EsfericoMenor = Convert.ToDecimal(dr["esf_menor"]);
                }

                dr.Close();
            }
        }
        public bool SalvaBlocos()
        {
            bool resultado = false;
            string strSQL = "insert into blocos(cod_produto, base_nominal, adicao, olho, esf_maior, esf_menor) Values(" + CodigoProduto + "," +
                Geral.ValorMoeda(BaseNominal) + "," + Geral.ValorMoeda(Adicao) + "," + Geral.AspasSQL(Olho) + "," + Geral.ValorMoeda(EsfericoMaior) + "," + Geral.ValorMoeda(EsfericoMenor) + ")";

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true; 
            }

            return resultado;
        }

        public void AtualizaBlocos(int codigoproduto)
        {
            string strSQL = "update blocos set base_nominal = " + Geral.ValorMoeda(BaseNominal) + "," + "adicao = " + Geral.ValorMoeda(Adicao) + "," + 
                "olho = " + Geral.AspasSQL(Olho) + "," + "esf_maior = " + Geral.ValorMoeda(EsfericoMaior) + "," + "esf_menor = " + 
                Geral.ValorMoeda(EsfericoMenor) + " where cod_produto = " + codigoproduto;

            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public void ExcluirBlocos(int codigoproduto)
        {
            string strSQL = "delete from blocos where cod_produto = " + codigoproduto;

            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public bool VerificaExistenciaBaseAdicaoOlho(decimal x_base, decimal x_adicao, string x_olho, int x_codigotabela)
        {
            bool resultado = false;

            string strSQL = "select blocos.Base_nominal, blocos.Adicao, blocos.olho, lentes_blocos.cod_tabela " + "FROM blocos INNER JOIN produtos " +
                "ON blocos.Cod_produto = produtos.cod_produto INNER JOIN " + "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " +
                "produtos.id_fabricante = lentes_blocos.id_fabricante " + "WHERE blocos.Base_nominal = " + Geral.ValorMoeda(x_base) +
                " And blocos.adicao = " + Geral.ValorMoeda(x_adicao) + " AND blocos.olho = " + Geral.AspasSQL(x_olho) +
                "AND lentes_blocos.cod_tabela = " + x_codigotabela;

            if (Conexao.VerificaExistenciaReg(strSQL) == 1)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }
    }
}
