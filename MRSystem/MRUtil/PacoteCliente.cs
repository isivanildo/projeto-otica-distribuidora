using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MRUtil
{
    public class PacoteCliente
    {
        public int CodigoPacote { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoFilialCliente { get; set; }
        public string Concluido { get; set; }
        public DateTime DataPacote { get; set; }
        public string Observacao { get; set; }

        private ConexaoDB ConnDB = new ConexaoDB();
        private Arquivo conf = new Arquivo();

        public PacoteCliente() { }

        public void Novo()
        {
            CodigoPacote = 0;
            CodigoCliente = 0;
            CodigoFilialCliente = 0;
            Concluido = "N";
            DataPacote = ConnDB.RetornaDataServidor();
            Observacao = string.Empty;
        }

        public bool SalvaPacote()
        {
            bool bResultado = false;

            int codigoChave = ConnDB.RetornaChave("cod_pacote", "pacote_cliente", "where cod_cliente = " + CodigoCliente + " and cod_filial_cliente = " + CodigoFilialCliente);

            string strSQL = "insert into pacote_cliente(cod_pacote, cod_filial_cliente, cod_cliente, " +
                "concluido, data, observacao) values(" + codigoChave + "," + CodigoFilialCliente + "," +
                CodigoCliente + "," + Geral.AspasSQL(Concluido) + "," +
                Geral.DataSQL(DataPacote.ToString()) + "," + Geral.AspasSQL(Observacao) + ")";

            if (ConnDB.SalvaAtualizaExcluiReg(strSQL))
            {
                bResultado = true;
                CodigoPacote = codigoChave;
            }

            return bResultado;

        }

        public void AtualizaPacote()
        {
            string strSQL = "update pacote_cliente set concluido = " + Geral.AspasSQL(Concluido) + "," +
                "observacao = " + Geral.AspasSQL(Observacao) + " where cod_pacote = " + CodigoPacote +
                " and cod_cliente = " + CodigoCliente + " and cod_filial_cliente = " + CodigoFilialCliente;

            ConnDB.SalvaAtualizaExcluiReg(strSQL);

        }

        public List<PacoteCliente> RetornaPacote(int xCodigoCliente)
        {
            string strSQL = "select * from pacote_cliente where cod_cliente = " + xCodigoCliente;

            List<PacoteCliente> _lista = new List<PacoteCliente>();

            using (SqlConnection conn = new SqlConnection(ConnDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _lista.Add(new PacoteCliente()
                            {
                                CodigoPacote = Convert.ToInt32(reader["cod_pacote"]),
                                CodigoFilialCliente = Convert.ToInt32(reader["cod_filial_cliente"]),
                                CodigoCliente = Convert.ToInt32(reader["cod_cliente"]),
                            });
                        }
                    }
                }
            }

            return _lista;
        }
        public void RetornaDadosPacote()
        {
            string strSQL = "select * from pacote_cliente where cod_pacote = " + CodigoPacote + " and " +
                "cod_cliente = " + CodigoCliente + " and cod_filial_cliente = " + CodigoFilialCliente;

            using (SqlConnection conn = new SqlConnection(ConnDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CodigoPacote = Convert.ToInt32(reader["cod_pacote"]);
                            CodigoFilialCliente = Convert.ToInt32(reader["cod_filial_cliente"]);
                            CodigoCliente = Convert.ToInt32(reader["cod_cliente"]);
                            Concluido = reader["concluido"].ToString();
                            DataPacote = Convert.ToDateTime(reader["data"]);
                            Observacao = reader["observacao"].ToString();
                        }
                    }
                }
            }
        }

    }
}
