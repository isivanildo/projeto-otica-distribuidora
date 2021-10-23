using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace MRUtil
{
    public class CreditoCliente : PacoteCliente
    {
        public int CodigoFilial { get; set; }
        public int CodigoCredito { get; set; }
        public decimal CreditoAnterior { get; private set; }
        public decimal Credito { get; set; }
        public decimal Saldo { get; set; }
        public string Historico { get; set; }
        public DateTime DataCredito {get; private set;}
        public int CodigoUsuario { get; set; }

        private ConexaoDB connDB = new ConexaoDB();

        public CreditoCliente()
        {

        }

        /// <summary>
        /// Salva o crédito para o cliente
        /// </summary>
        /// <returns></returns>
        public bool SalvaCreditoCliente()
        {
            string strSQL = "";
            bool bResultado = false;

            int intCodigoCredito = connDB.RetornaChave("cod_credito", "credito_cliente", "where id_filial = " + CodigoFilial);

            SomaSaldoCredito();

            strSQL = "insert into credito_cliente(cod_credito, cod_cliente, cod_filial_cliente, id_filial," +
                "credito_anterior, credito, saldo, historico, data, id_usuario) values(" + intCodigoCredito + "," +
                CodigoCliente + "," + CodigoFilialCliente + "," + CodigoFilial + "," +
                Geral.ValorMoeda(CreditoAnterior) + "," + Geral.ValorMoeda(Credito) + "," + 
                Geral.ValorMoeda(Saldo) + "," + Geral.AspasSQL(Historico) + "," +
                Geral.DataSQL(connDB.RetornaDataServidor().ToString()) + "," + CodigoUsuario + ")";
            if (connDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
                CodigoCredito = intCodigoCredito;
                SalvaCreditoPacote();
                AtualizaPacote();
                AtualizaStatusItem();
            }

            return bResultado;
        }

        private void SalvaCreditoPacote()
        {
            string strSQL = "";

            strSQL = "insert into credito_pacote (cod_pacote, cod_filial_cliente, cod_cliente, " +
                    "cod_credito, id_filial) VALUES(" + CodigoPacote + "," + CodigoFilialCliente + "," +
                    CodigoCliente + "," + CodigoCredito + "," + CodigoFilial + ")";

            connDB.SalvaAtualizaExcluiReg(strSQL);
        }

        public void RetornaCodigoCredito()
        {
            string strSQL = "select cod_credito from credito_pacote where cod_pacote = " + CodigoPacote + " and " +
                "cod_cliente = " + CodigoCliente + " and cod_filial_cliente = " + CodigoFilialCliente;

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
                            CodigoCredito = Convert.ToInt32(reader["cod_credito"]);
                        }
                    }
                }
            }
        }

        private void SomaSaldoCredito()
        {
            string strSQL = "SELECT SUM(credito) AS saldo FROM credito_cliente WHERE cod_cliente = " + CodigoCliente +
                " AND cod_filial_cliente = " + CodigoFilialCliente;

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
                            if (!reader.IsDBNull(0))
                            {
                                CreditoAnterior = Convert.ToDecimal(reader["saldo"]);
                            } else
                            {
                                CreditoAnterior = 0;
                            }

                            Saldo = CreditoAnterior + Credito;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Retorna o valor total do pacote na geração dos creditos
        /// </summary>
        public decimal TotalPacotePagoCredito(int xCodigoCredito, int xCodigoCliente, int xCodigoFilialCliente)
        {
            decimal? total = 0;

            string strSQL = "SELECT SUM(lancamentos.Valor_Pago) AS Total FROM lancamentos INNER JOIN " +
                "pagamentos_credito ON lancamentos.cod_lancamento = pagamentos_credito.cod_lancamento " +
                "AND lancamentos.id_filial = pagamentos_credito.id_filial WHERE " +
                "pagamentos_credito.cod_credito = " + xCodigoCredito + " AND " +
                "pagamentos_credito.cod_cliente = " + xCodigoCliente + " AND " +
                "pagamentos_credito.id_filial = " + xCodigoFilialCliente + " AND " +
                "lancamentos.cod_status_lancamento <> 2";

            using (SqlConnection conn = new SqlConnection(connDB.stringConexao))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                       while (reader.Read())
                        {
                            total = reader.GetDecimalOrNull("Total");
                            if (total == null)
                            {
                                total = 0;
                            }
                        }
                    }
                }
            }

            return (decimal)total;
        }

        /// <summary>
        /// Retorna o valor total do pag de um determinado pacote
        /// </summary>
        public decimal TotalPacotePago(int xCodigoPacote, int xCodigoCliente, int xCodigoFilialCliente)
        {
            decimal? total = 0;

            string strSQL = "select isnull(SUM(valor_pago),0) as total_pacote_pago from lancamentos inner join lancamentos_cliente on " +
                "lancamentos.cod_lancamento = lancamentos_cliente.cod_lancamento and lancamentos.id_filial = lancamentos_cliente.id_filial " +
                "inner join pagamentos_credito on lancamentos.cod_lancamento = pagamentos_credito.cod_lancamento " +
                "and lancamentos.id_filial = pagamentos_credito.id_filial inner join credito_pacote on " +
                "pagamentos_credito.cod_credito = credito_pacote.cod_credito and pagamentos_credito.id_filial = credito_pacote.id_filial " +
                "where lancamentos_cliente.cod_cliente = " + xCodigoCliente + " And lancamentos_cliente.cod_filial_cliente = " + xCodigoFilialCliente +
                " And credito_pacote.cod_pacote = " + xCodigoPacote;

            using (SqlConnection conn = new SqlConnection(connDB.stringConexao))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            total = reader.GetDecimalOrNull("total_pacote_pago");
                            if (total == null)
                            {
                                total = 0;
                            }
                        }
                    }
                }
            }

            return (decimal)total;
        }

        private void AtualizaStatusItem()
        {
            string strSQL = "update pacote_cliente_detalhes set status_item = 'L' where " +
                "cod_pacote = " + CodigoPacote + " and cod_cliente = " + CodigoCliente + " and " +
                "cod_filial_cliente = " + CodigoFilialCliente;

            connDB.SalvaAtualizaExcluiReg(strSQL);
        }

        public DataTable RetornaLancamentoPacote()
        {
            DataTable tb = new DataTable();

            string strSQL = "SELECT lancamentos.*, forma_pagamento.forma_pagamento, pagamentos_credito.cod_credito FROM " +
                 "lancamentos INNER JOIN forma_pagamento ON lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento INNER JOIN " +
                 "pagamentos_credito ON lancamentos.cod_lancamento = pagamentos_credito.cod_lancamento AND " +
                 "lancamentos.id_filial = pagamentos_credito.id_filial WHERE pagamentos_credito.id_filial = " + CodigoFilial +
                 " and pagamentos_credito.cod_credito = " + CodigoCredito + " and lancamentos.cod_status_lancamento <> 2";

            connDB.CarregaTabela(strSQL, ref tb);

            return tb;
        }

        public void RetornaRegistroCredito(int xCodigoCredito, int xFilial)
        {
            string strSQL = "select * from credito_cliente where cod_credito = " + xCodigoCredito +
                " and cod_cliente = " + CodigoCliente + " and cod_filial_cliente = " + xFilial;

            using (SqlConnection conn = new SqlConnection(connDB.stringConexao))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CodigoCredito = Convert.ToInt32(reader["cod_credito"]);
                            CodigoCliente = Convert.ToInt32(reader["cod_cliente"]);
                            CodigoFilialCliente = Convert.ToInt32(reader["cod_filial_cliente"]);
                            CodigoFilial = reader.GetInt32("id_filial");
                            CreditoAnterior = Convert.ToDecimal(reader["credito_anterior"]);
                            Credito = Convert.ToDecimal(reader["credito"]);
                            Saldo = Convert.ToDecimal(reader["saldo"]);
                            Historico = reader["historico"].ToString();
                            DataCredito = Convert.ToDateTime(reader["data"]);
                            CodigoUsuario = Convert.ToInt32(reader["id_usuario"]);
                        }
                    }
                }
            }
        }

    }
}
