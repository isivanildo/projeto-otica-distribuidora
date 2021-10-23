using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class FaturaItens
    {
        ConexaoDB Conexao = new ConexaoDB();
        public int Item { get; set; }
        public int CodigoFatura { get; set; }
        public int CodigoFilial { get; set; }
        public int NumeroPedido { get; set; }
        public decimal CodigoFilialPedido { get; set; }
   
        public FaturaItens() { }

        public void RetornaRegistro(int xCodigoFatura, int xCodigoFilial)
        {
            string strSQL = string.Empty;
            strSQL = "select * from fatura_itens where cod_fatura = " + xCodigoFatura + " and id_filial = " + xCodigoFilial;

            SqlCommand cmd;
            SqlDataReader dr;

            if (Conexao.ConectadoBanco == true)
            {
                cmd = new SqlCommand(strSQL, Conexao.Conn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Item = Convert.ToInt32(dr["item"]);
                    xCodigoFatura = Convert.ToInt32(dr["cod_fatura"]);
                    CodigoFilial = Convert.ToInt32(dr["id_filial"]);
                    NumeroPedido = Convert.ToInt32(dr["num_pedido"]);
                    CodigoFilialPedido = Convert.ToInt32(dr["id_filial_pedido"]);
                }

                dr.Close();
            }


        }

        public int VerificaPedidoFaturado(int xNumPedido, int xFilial)
        {
            int resultado = 0;
            string strSQL = "select 1 from fatura_itens where num_pedido = " + xNumPedido + " and id_filial = " + xFilial;

            if (Conexao.VerificaExistenciaReg(strSQL) == 0)
            {
                resultado = 0;
            }
            else
            {
                resultado = 1;
            }

            return resultado;

        }

    }
}
