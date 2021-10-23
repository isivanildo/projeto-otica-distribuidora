using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRUtil;

namespace MRUtil
{
    public class Fatura
    {
        ConexaoDB Conexao = new ConexaoDB();
        public int? CodigoFatura { get; set; }
        public int? CodigoFilial { get; set; }
        public int CodigoCliente { get; set; }
        public DateTime? DataLancamento { get; set; }
        public int? StatusFatura { get; set; }
        public decimal TotalProdutos { get; set; }
        public decimal TotalServicos { get; set; }
        public decimal TotalFatura { get; set; }
        public decimal TotalPago { get; set; }
        public decimal TotalAcrescimo { get; set; }
        public decimal TotalDesconto { get; set; }

        public Fatura() { }

        public void Novo()
        {
            CodigoFatura = 0;
            CodigoFilial = 0;
            CodigoCliente = 0;
            DataLancamento = null;
            StatusFatura = 1;
            TotalProdutos = 0;
            TotalServicos = 0;
            TotalFatura = 0;
            TotalPago = 0;
            TotalAcrescimo = 0;
            TotalDesconto = 0;
        }

        public void RetornaRegistro(int xCodigoFatura, int xCodigoFilial)
        {
            string strSQL = string.Empty;
            strSQL = "select * from fatura where cod_fatura = " + xCodigoFatura + " and id_filial = " + xCodigoFilial;

            SqlCommand cmd;
            SqlDataReader dr;

            if (Conexao.ConectadoBanco == true)
            {
                cmd = new SqlCommand(strSQL, Conexao.Conn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CodigoFatura = Convert.ToInt32(dr["cod_fatura"]);
                    CodigoFilial = Convert.ToInt32(dr["id_filial"]);
                    CodigoCliente = Convert.ToInt32(dr["cod_cliente"]);
                    DataLancamento = Convert.ToDateTime(dr["data_lancamento"]);
                    StatusFatura = Convert.ToInt32(dr["cod_status_fatura"]);
                }

                dr.Close();
            }


        }
        public void RetornaTotais(int xCodigoFatura, int x_Filial)
        {
            string strSQL = string.Empty;
            strSQL = "SELECT isnull(SUM(pedido_balcao_itens.quant * pedido_balcao_itens.preco_fat),0) AS Produtos " +
                "FROM fatura_itens INNER JOIN pedido_balcao_itens ON fatura_itens.num_pedido = " +
                "pedido_balcao_itens.num_pedido AND fatura_itens.id_filial_pedido = pedido_balcao_itens.id_filial WHERE " +
                "(fatura_itens.cod_fatura = " + xCodigoFatura + ") AND " + "(fatura_itens.id_filial = " + x_Filial +
                " AND NOT (pedido_balcao_itens.cod_status_item in (4,5)))";

            SqlCommand cmd;
            SqlDataReader dr;

            if (Conexao.ConectadoBanco == true)
            {
                cmd = new SqlCommand(strSQL, Conexao.Conn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["Produtos"] != DBNull.Value)
                    {
                        TotalProdutos = Convert.ToDecimal(dr["Produtos"]);
                    }
                    else
                    {
                        TotalProdutos = 0;
                    }

                }

                dr.Close();

                strSQL = "SELECT round(SUM(pedido_balcao_servicos.quant * pedido_balcao_servicos.preco),2) as Servicos FROM fatura_itens INNER JOIN " +
                    "pedido_balcao_servicos ON fatura_itens.num_pedido = " + "pedido_balcao_servicos.num_pedido AND  fatura_itens.id_filial_pedido = " +
                    "pedido_balcao_servicos.id_filial WHERE (fatura_itens.cod_fatura = " + xCodigoFatura + ") " +
                    "AND (fatura_itens.id_filial = " + x_Filial + " and pedido_balcao_servicos.cod_status_servico = 1" + ")";
                cmd = new SqlCommand(strSQL, Conexao.Conn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["Servicos"] != DBNull.Value)
                    {
                        TotalServicos = Convert.ToDecimal(dr["Servicos"]);
                    }
                    else
                    {
                        TotalServicos = 0;
                    }
                }

                dr.Close();

                TotalFatura = Convert.ToDecimal(TotalProdutos + TotalServicos);


                strSQL = "SELECT SUM((valor_pago + acrescimo + juros + taxas) - desconto) as ValorPago FROM lancamentos WHERE cod_fatura = " + xCodigoFatura +
                    " AND id_filial = " + x_Filial;
                cmd = new SqlCommand(strSQL, Conexao.Conn);
                dr = cmd.ExecuteReader();

                decimal valorPago = 0;

                while (dr.Read())
                {
                    if (dr["ValorPago"] != DBNull.Value)
                    {
                        valorPago += Convert.ToDecimal(dr["ValorPago"]);
                    }
                    else
                    {
                        valorPago += 0;
                    }
                }

                dr.Close();

                TotalPago = valorPago;

                strSQL = "SELECT SUM(acrescimo) as Acrescimo FROM lancamentos WHERE cod_fatura = " + xCodigoFatura +
                    " AND id_filial = " + x_Filial;
                cmd = new SqlCommand(strSQL, Conexao.Conn);
                dr = cmd.ExecuteReader();

                decimal valorAcrescimo = 0;

                while (dr.Read())
                {
                    if (dr["Acrescimo"] != DBNull.Value)
                    {
                        valorAcrescimo += Convert.ToDecimal(dr["Acrescimo"]);
                    }
                    else
                    {
                        valorAcrescimo += 0;
                    }
                }

                dr.Close();

                TotalAcrescimo = valorAcrescimo;

                strSQL = "SELECT SUM(desconto) as Desconto FROM lancamentos WHERE cod_fatura = " + xCodigoFatura +
                    " AND id_filial = " + x_Filial;
                cmd = new SqlCommand(strSQL, Conexao.Conn);
                dr = cmd.ExecuteReader();

                decimal valorDesconto = 0;

                while (dr.Read())
                {
                    if (dr["Desconto"] != DBNull.Value)
                    {
                        valorDesconto += Convert.ToDecimal(dr["Desconto"]);
                    }
                    else
                    {
                        valorDesconto += 0;
                    }
                }

                dr.Close();

                TotalDesconto = valorDesconto;
            }

        }

    }
}
