using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class LentesDioptria
    {
        ConexaoDB Conexao = new ConexaoDB();
        public int? CodigoProduto { get; set; }
        public decimal? Esferico { get; set; }
        public decimal? Cilindrico { get; set; }
        public string CodigoBarra { get; set; }

        public DataTable tb = new DataTable();

        public LentesDioptria() { }

        public void Novo()
        {
            CodigoProduto = null;
            Esferico = null;
            Cilindrico = null;
            CodigoBarra = string.Empty;
        }

        public bool SalvaLentes()
        {
            bool resultado = false;
            string strSQL = "insert into lentes(cod_produto, esferico, cilindrico) Values(" + CodigoProduto + "," +
                Geral.ValorMoeda(Esferico) + "," + Geral.ValorMoeda(Cilindrico) + ")";

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }

        public bool AtualizaLentes(int xCodigoProduto)
        {
            bool resultado = false;
            string strSQL = "update lentes set esferico = " + Geral.ValorMoeda(Esferico) + "," + "cilindrico = " + Geral.ValorMoeda(Cilindrico) + " " +
                "where cod_produto = " + xCodigoProduto;

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }

        public void Filtra(int xCodigoFabricante, int xCodigoLente, string xOrdem, string xCil)
        {
            ListaLentes(xCodigoFabricante, xCodigoLente, xOrdem, xCil);
        }

        public DataTable ListaLentes(int xFabricante, int xCodigoLente, string xOrdernar, string xCil)
        {
            string barra = string.Empty;
            string ordem = string.Empty;
            string strSQL = string.Empty;

            if (xOrdernar == "C")
            {
                ordem = " ORDER BY lentes.cilindrico DESC,lentes.esferico DESC";
            }
            else
            {
                ordem = " ORDER BY lentes.esferico DESC,lentes.cilindrico DESC";
            }

            if (xCil == string.Empty )
            {
                strSQL = "Select lentes.esferico, lentes.cilindrico,produtos.cod_barra,produtos.cod_produto  from lentes_blocos " +
                    "inner JOIN produtos on lentes_blocos.cod_lente = produtos.cod_lente and lentes_blocos.id_fabricante = " +
                    "produtos.id_fabricante inner join lentes on produtos.cod_produto = lentes.Cod_produto " +
                    "where lentes_blocos.id_fabricante = " + xFabricante + " and lentes_blocos.cod_lente = " + xCodigoLente  +
                    ordem;
            }
            else
            {
                strSQL = "Select lentes.esferico, lentes.cilindrico,produtos.cod_barra,produtos.cod_produto  from lentes_blocos " +
                    "inner JOIN produtos on lentes_blocos.cod_lente = produtos.cod_lente and lentes_blocos.id_fabricante = " +
                    "produtos.id_fabricante inner join lentes on produtos.cod_produto = lentes.Cod_produto " +
                    "where lentes_blocos.id_fabricante = " + xFabricante + " and lentes_blocos.cod_lente = " + xCodigoLente + 
                    " and lentes.cilindrico = " + xCil + ordem;
            }

            Conexao.CarregaTabela(strSQL, ref tb);

            return tb;

        }

        public bool VerificaDioptriaExistente(decimal xEsferico,decimal xCilindrico, int xCodigoTabela)
        {
            bool resultado = false;

            string strSQL = "SELECT lentes.esferico, lentes.cilindrico, produtos.cod_lente, lentes_blocos.cod_tabela FROM lentes INNER JOIN produtos ON " +
                "lentes.cod_produto = produtos.cod_produto INNER JOIN lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " +
                "produtos.id_fabricante = lentes_blocos.id_fabricante WHERE (lentes.esferico =" + Geral.ValorMoeda(xEsferico) + ") AND " +
                "(lentes.cilindrico = " + Geral.ValorMoeda(xCilindrico) + ") AND (lentes_blocos.cod_tabela = " + xCodigoTabela + ")";

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
