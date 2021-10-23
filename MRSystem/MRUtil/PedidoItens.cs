using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class PedidoItens
    {
        ConexaoDB Conexao = new ConexaoDB();
        public int NumeroPedido { get; set; }
        public int CodigoFilial { get; set; }
        public int Item { get; set; }
        public int CodigoProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal? PrecoCompra { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? Preco { get; set; }
        public int CodigoStatusItem { get; set; }
        public string Pacote { get; set; }
        public int? CodigoPacote { get; set; }
        public int UsuarioCancelado { get; set; }
        public string TipoDevolucao { get; set; }
        public string DevolvidoEstoque { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public decimal PrecoTabela { get; set; }
        public decimal? CMV { get; set; }

        public PedidoItens() { }

        public void Novo()
        {
            NumeroPedido = 0;
            CodigoFilial = 0;
            Item = 0;
            CodigoProduto = 0;
            Quantidade = 0;
            PrecoCompra = 0;
            Desconto = 0;
            Preco = 0;
            CodigoStatusItem = 0;
            Pacote = "";
            CodigoPacote = 0;
            UsuarioCancelado = 0;
            TipoDevolucao = "";
            DevolvidoEstoque = "";
            DataDevolucao = null;
            PrecoTabela = 0;
            CMV = 0;
        }

        public void RetornaRegistro(int xNumeroPedido, int xFilial)
        {
            string strSQL = "selec * from pedido_balcao_itens where num_pedido = " + xNumeroPedido + " and id_filial = " + xFilial;

            SqlCommand cmd = new SqlCommand(strSQL, Conexao.Conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                NumeroPedido = Convert.ToInt32(dr["num_pedido"]);
                CodigoFilial = Convert.ToInt32(dr["id_filial"]);
                Item = Convert.ToInt32("item");
                CodigoProduto = Convert.ToInt32(dr["cod_produto"]);
                Quantidade = Convert.ToInt32(dr["quant"]);
                PrecoCompra = Convert.ToDecimal(dr["compra"]);
                Desconto = Convert.ToDecimal(dr["desconto"]);
                Preco = Convert.ToDecimal(dr["preco"]);
                CodigoStatusItem = Convert.ToInt32(dr["cod_status_item"]);
                Pacote = dr["quant"].ToString();
                CodigoPacote = Convert.ToInt32(dr["cod_pacote"]);
                UsuarioCancelado = Convert.ToInt32(dr["usuario_can"]);
                TipoDevolucao = dr["tipo_devolucao"].ToString();
                DevolvidoEstoque = dr["devolvido_estoque"].ToString();
                DataDevolucao = Convert.ToDateTime(dr["data_devolucao"]);
                PrecoTabela = Convert.ToInt32(dr["preco_tab"]);
                CMV = Convert.ToDecimal(dr["quant"]);
            }

        }

        public void SalvaItens()
        {
            Item = Chave();
            string strSQL = "insert into pedido_balcao_itens(num_pedido, cod_filial, item, cod_produto, quant, compra, desconto, preco, cod_status_item, " +
                "pacote, cod_pacote, usuario_can, tipo_devolucao, devolvido_estoque, data_devolucao, preco_tab, cmv) " + " " +
                NumeroPedido + "," + CodigoFilial + "," + Item + "," + CodigoProduto + "," + Quantidade + "," + Geral.ValorMoeda(PrecoCompra) + "," +
                Geral.ValorMoeda(Desconto) + "," + Preco + "," + "cod_status_item" + "," + Pacote + "," + CodigoPacote + "," +
                UsuarioCancelado + "," + TipoDevolucao + "," + DevolvidoEstoque + "," + DataDevolucao + "," + PrecoTabela + "," + CMV;

            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public void AtualizaItem()
        {
            string strSQL = "update pedido_balcao_itens set num_pedido = " + NumeroPedido + "," + "cod_filial = " + CodigoFilial + "," +
                "item = " + Item + "," + "cod_produto = " + "," + "quant = " + Quantidade + "," + "compra = " + PrecoCompra + "," +
                "desconto = " + Desconto + "," + "preco, cod_status_item = " + CodigoStatusItem + "," + "pacote = " + Pacote + "," +
                "cod_pacote = " + CodigoPacote + "," + "usuario_can = " + UsuarioCancelado + "," + "tipo_devolucao = " + TipoDevolucao + "," +
                "devolvido_estoque = " + DevolvidoEstoque + "," + "data_devolucao = " + DataDevolucao + "," + "preco_tab = " + PrecoTabela + "," +
                "cmv = " + CMV + " wherne num_pedido = " + NumeroPedido + "and id_filial = " + CodigoFilial;

            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public void QuantidadeAtualizada(int xNumPedido, int xFilial, int xCodigoProduto, int xQtde)
        {
            string strSQL = "update pedido_balcao_itens set quant = quant + " + xQtde + " where num_pedido = " + xNumPedido +
                " and id_filial = " + xFilial + " and cod_produto = " + xCodigoProduto;

            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public void QuantidadeAtualizadaServico(int xNumPedido, int xFilial, int xCodigoServico, int xQtde)
        {
            string strSQL = "update pedido_balcao_servicos set quant = quant + " + xQtde + "where num_pedido = " + xNumPedido +
                " and id_filial = " + xFilial + " and cod_servico = " + xCodigoServico;

            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public void AtualizaPrecoItem(int xNumPedido, int xFilial, int xItem, int xCodigoProduto, decimal xValor)
        {
            string strSQL = "update pedido_balcao_itens set preco = " + Geral.ValorMoeda(xValor) + " where num_pedido = " + xNumPedido + " " +
                " and id_filial = " + xFilial + " and item = " + xItem + " and cod_produto = " + xCodigoProduto;
            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public void AtualizaPrecoItemDescFatura(int xNumPedido, int xFilial, int xItem, int xCodigoProduto, decimal xValor, decimal xDesconto)
        {
            string strSQL = "update pedido_balcao_itens set preco = " + Geral.ValorMoeda(xValor) + "," + " desconto = " + Geral.ValorMoeda(xDesconto) + 
                " where num_pedido = " + xNumPedido + " and id_filial = " + xFilial + " and item = " + xItem + " and cod_produto = " + xCodigoProduto;
            Conexao.SalvaAtualizaExcluiReg(strSQL);

        }

        public void AtualizaPrecoItemFatura(int xNumPedido, int xFilial, int xItem, int xCodigoProduto, decimal xValor)
        {
            string strSQL = "update pedido_balcao_itens set preco_fat = " + Geral.ValorMoeda(xValor) +
                " where num_pedido = " + xNumPedido + " and id_filial = " + xFilial + " and item = " + xItem + " and cod_produto = " + xCodigoProduto;
            Conexao.SalvaAtualizaExcluiReg(strSQL);

        }

        public int Chave()
        {
            return (int)Conexao.RetornaChave("item", "pedido_balcao_itens", "");
        }

    }
}
