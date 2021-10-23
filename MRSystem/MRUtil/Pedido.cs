using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class Pedido
    {
        ConexaoDB conexao = new ConexaoDB();

        public int NumeroPedido { get; set; }
        public int CodigoFilial { get; set; }
        public int CodigoVendedor { get; set; }
        public DateTime DataPedido { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoFiliaCliente { get; set; }
        public int CodigoStatusPedido { get; set; }
        public int CodigoAutorizacao { get; set; }
        public string Forma { get; set; }
        public int CodigoTipoPedido { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorAPagar { get; set; }
        public decimal ValorDevolvido { get; set; }
        public int CodigoVendedorExterno { get; set; }
        public string TermDesconto { get; set; }
        public DateTime DataPedidoFora { get; set; }


        public Pedido() { }


        public void RetornaPedido(int x_NumPedido, int x_Filial)
        {
            string strSQL = "select * from pedido_balcao where num_pedido = " + x_NumPedido + " and id_filial = " + x_Filial;

            if (conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    NumeroPedido = Convert.ToInt32(dr["num_pedido"].ToString());
                    CodigoFilial = Convert.ToInt32(dr["id_filial"].ToString());
                    CodigoVendedor = Convert.ToInt32(dr["cod_vendedor"].ToString());
                    DataPedido = Convert.ToDateTime(dr["data_pedido"].ToString());
                    CodigoCliente = Convert.ToInt32(dr["cod_cliente"].ToString());
                    CodigoFiliaCliente = Convert.ToInt32(dr["cod_filial_cliente"].ToString());
                }
            }

        }


    }
}
