using System;
using System.Data;
using System.Data.SqlClient;


namespace MRUtil
{
    public class PacoteClienteDetalhes : PacoteCliente
    {
        public int ItemPacote { get; set; }
        public int CodigoProduto { get; set; }
        public decimal PrecoProduto { get; set; }
        public decimal DescontoProduto { get; set; }
        public decimal PrecoFinalProduto { get; set; }
        public int QtdeProduto { get; set; }
        public string StatusItem { get; set; }
        public string TipoServico { get; set; }

        private decimal totalPacote;

        public string MensagemRetorno;

        ConexaoDB connDB = new ConexaoDB();


        public PacoteClienteDetalhes() { }

        public void NovoItemPacote()
        {
            ItemPacote = 0;
            CodigoProduto = 0;
            PrecoProduto = 0;
            DescontoProduto = 0;
            PrecoFinalProduto = 0;
            QtdeProduto = 0;
            StatusItem = "A";
        }

        public bool SalvarItemPacote()
        {
            bool bResultado = false;
            ItemPacote = connDB.RetornaChave("item", "pacote_cliente_detalhes", "where cod_pacote = " + CodigoPacote + 
                " and cod_cliente = " + CodigoCliente + " and cod_filial_cliente = " + CodigoFilialCliente);

            string strSQL = "INSERT INTO Pacote_cliente_detalhes(cod_Pacote, cod_filial_cliente, " +
                "cod_cliente, item, cod_produto, preco_produto, desconto_produto, preco_final_produto, " +
                "qtde_produto, status_item, tipo) VALUES(" + CodigoPacote + "," + CodigoFilialCliente + "," +
                CodigoCliente + "," + ItemPacote + "," + CodigoProduto + "," + 
                Geral.ValorMoeda(PrecoProduto) + "," + Geral.ValorMoeda(DescontoProduto) + "," + 
                Geral.ValorMoeda(PrecoFinalProduto) + "," + QtdeProduto + "," + 
                Geral.AspasSQL(StatusItem) + "," + Geral.AspasSQL(TipoServico) + ")";

            if (connDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;
        }

        public bool AtualizaItemPacote()
        {
            bool bResultado = false;

            string strSQL = "UPDATE Pacote_cliente_detalhes SET cod_produto =  " + CodigoProduto + "," +
                "preco_produto = " + Geral.ValorMoeda(PrecoProduto) + "," +
                "desconto_produto = " + Geral.ValorMoeda(DescontoProduto) + "," +
                "preco_final_produto = " + Geral.ValorMoeda(PrecoFinalProduto) + "," +
                "qtde_produto = " + QtdeProduto + "," + "tipo = " + Geral.AspasSQL(TipoServico) +
                " WHERE cod_pacote = " + CodigoPacote + " and cod_cliente = " + CodigoCliente +
                " and cod_filial_cliente = " + CodigoFilialCliente + " and item = " + ItemPacote; 

            if (connDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;
        }

        public void ExcluirItemPacote(int xPacote, int xCliente, int xFilial, int xItem)
        {
            string strSQL = "delete from pacote_cliente_detalhes where cod_pacote = " + xPacote +
                " and cod_cliente = " + xCliente + " and cod_filial_cliente = " + xFilial +
                " and item = " + xItem;

            connDB.SalvaAtualizaExcluiReg(strSQL);
        }

        public void RetornaDadosItemPacote(int xCodigoCliente, int xFilia, int xPacote, int xItem)
        {
            string strSQL = "SELECT pcd.cod_pacote, pcd.cod_cliente, pcd.cod_filial_cliente, pcd.item, " +
                "pcd.cod_produto, p.produto, pcd.preco_produto, pcd.desconto_produto, pcd.qtde_produto, " +
                "pcd.preco_final_produto, pcd.status_item, case when p.cod_lente IS NULL then p.produto " +
                "else (select lentes_blocos.nome_lente as nome from lentes_blocos where " +
                "cod_lente = pcd.cod_produto) end as descricao_prod, " +
                "(SELECT SUM(Contratada - Utilizado) AS saldo FROM saldos_pacotes(pcd.cod_produto, " +
                "pcd.cod_filial_cliente, pcd.cod_cliente) as saldos " +
                "where(cod_Pacote = pcd.cod_pacote)) as Saldo, pc.data, pcd.tipo " +
                "from Pacote_cliente_detalhes pcd inner join pacote_cliente pc on " +
                "pcd.cod_Pacote = pc.cod_Pacote inner join produtos p " +
                "on pcd.cod_produto = p.cod_produto where pcd.cod_cliente = " + xCodigoCliente +
                " and pcd.cod_filial_cliente = " + xFilia +
                " and pcd.cod_Pacote = " + xPacote + " and pcd.item = " + xItem;

            using (SqlConnection conn = new SqlConnection(connDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CodigoProduto = Convert.ToInt32(reader["cod_produto"]);
                            PrecoProduto = Convert.ToDecimal(reader["preco_produto"]);
                            DescontoProduto = Convert.ToDecimal(reader["desconto_produto"]);
                            PrecoFinalProduto = Convert.ToDecimal(reader["preco_final_produto"]);
                            QtdeProduto = Convert.ToInt32(reader["qtde_produto"]);
                            TipoServico = reader["tipo"].ToString();
                        }
                    }
                }
            }
        }

        public DataTable FiltraPacoteCliente(int xCodigoCliente, int xCodigoFilialCliente, int xCodigoPacote)
        {
            DataTable tt = new DataTable();


            string strSQL = "SELECT pcd.cod_pacote, pcd.cod_cliente, pcd.cod_filial_cliente, pcd.item, " +
                "pcd.cod_produto, p.produto, pcd.preco_produto, pcd.desconto_produto, pcd.qtde_produto, " +
                "pcd.preco_final_produto, pcd.status_item, case when p.cod_lente IS NULL then p.produto " +
                "else (select lentes_blocos.nome_lente as nome from lentes_blocos where " +
                "cod_lente = pcd.cod_produto) end as descricao_prod, " +
                "(SELECT SUM(Contratada - Utilizado) AS saldo FROM saldos_pacotes(pcd.cod_produto, " +
                "pcd.cod_filial_cliente, pcd.cod_cliente) as saldos " +
                "where(cod_Pacote = pcd.cod_pacote)) as Saldo, pc.data from Pacote_cliente_detalhes pcd " +
                "inner join pacote_cliente pc on pcd.cod_Pacote = pc.cod_Pacote inner join produtos p " +
                "on pcd.cod_produto = p.cod_produto where pcd.cod_cliente = " + xCodigoCliente +
                " and pcd.cod_filial_cliente = " + xCodigoFilialCliente +
                " and pcd.cod_Pacote = " + xCodigoPacote + " order by item";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        private int VerificaCampos()
        {
            if (CodigoProduto == 0)
                return 1;
            if (QtdeProduto == 0)
                return 2;
            if (DescontoProduto == 0)
                return 3;

            return 0;
        }

        public bool VerificaCampoObrigatorio()
        {
            bool resultado = false;
            switch (VerificaCampos())
            {
                case 1:
                    MensagemRetorno = "Campo código lente é de preenchimento \nobrigatório!";
                    resultado = true;
                    break;
                case 2:
                    MensagemRetorno = "Campo quantidae produto é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 3:
                    MensagemRetorno = "Campo desconto produto é de preenchimento obrigatório!";
                    resultado = true;
                    break;
            }

            return resultado;

        }

        /// <summary>
        /// Calcula o preço final do pacote
        /// </summary>
        public decimal CalculaPrecoFinalPacote()
        {
            string strSQL = "select * from Pacote_cliente_detalhes where cod_cliente = " + CodigoCliente +
                " and cod_filial_cliente = " + CodigoFilialCliente + " and cod_Pacote = " + CodigoPacote;

            totalPacote = 0;

            using (SqlConnection conn = new SqlConnection(connDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PrecoFinalProduto = Convert.ToDecimal(reader["preco_final_produto"]);
                            QtdeProduto = Convert.ToInt32(reader["qtde_produto"]);

                            totalPacote += (PrecoFinalProduto * QtdeProduto);
                        }

                        PrecoFinalProduto = 0;
                        QtdeProduto = 0;
                    }
                }
            }

            return totalPacote;
        }

    }
}
