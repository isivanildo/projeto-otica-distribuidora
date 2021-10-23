using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class TabelaPromocional
    {
        public int CodigoPromocao { get; set; }
        public int CodigoFilial { get; set; }
        public int CodigoFilialCliente { get; set; }
        public string Descricao { get; set; }
        public DateTime DataIinicio { get; set; }
        public DateTime DataTerminoi { get; set; }
        public int Item { get; set; }
        public int CodigoTabela { get; set; }
        public decimal DescontoPercentual { get; set; }
        public decimal Valor { get; set; }

        ConexaoDB Conexao = new ConexaoDB();
        Lentes LentesBlocos;

        public TabelaPromocional() {}
     
        public bool RetornaValorDesconto(int xCodigoTabela)
        {
            bool resultado = false;

            DataTable tbItem = new DataTable();
            DataTable tbPromocao = new DataTable(); 
            string strSQL = string.Empty;

            strSQL = "select * from tabela_promocional_itens where cod_Tabela = " + xCodigoTabela;

            Conexao.CarregaTabela(strSQL, ref tbItem);

            foreach (DataRow linha in tbItem.Rows)
            {
                strSQL = "select * from tabela_promocional where cod_tabela_promocional = " + linha["cod_tabela_promocional"];

                Conexao.CarregaTabela(strSQL, ref tbPromocao);

                if (tbPromocao.Rows.Count > 0)
                {
                    string teste1 = Conexao.RetornaDataServidor().ToShortDateString();
                    string teste2 = Convert.ToDateTime(tbPromocao.Rows[0]["data_termino"].ToString()).ToShortDateString();
                    if (Convert.ToDateTime(teste2) >= Convert.ToDateTime(teste1))
                    {
                        DescontoPercentual = Convert.ToDecimal(linha["desconto"].ToString());
                        resultado = true;
                    }
                }
            }

            LentesBlocos = new Lentes();

            LentesBlocos.RetornaRegistro(xCodigoTabela);

            if (LentesBlocos.PrecoTabela == null)
            {
                LentesBlocos.PrecoTabela = 0;
            }

            Valor = (decimal)LentesBlocos.PrecoTabela - (((decimal)LentesBlocos.PrecoTabela * DescontoPercentual) / 100);

            return resultado;
        }
    }
}
