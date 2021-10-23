using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MRUtil
{
    public class RestricaoBloqueio
    {
        public DateTime DataVencTituloAberto { get; set; }
        public DateTime DataVencAcordoAberto { get; set; }

        ConexaoDB ConnDB = new ConexaoDB();
        public RestricaoBloqueio() { }
        
        public DateTime DataVencimentoTituloAberto(int xCodCliente, int xFilialCliente)
        {
            using (SqlConnection conn = new SqlConnection(ConnDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select data_vencimento from Titulos_aberto() " +
                        "where cod_cliente = " + xCodCliente +
                        " and cod_filial_cliente = " + xFilialCliente +
                        " and data_vencimento < GETDATE() and data_recebimento is null";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataVencTituloAberto = Convert.ToDateTime(reader["data_vencimento"]);
                        }
                    }
                }
            }
            
            return DataVencTituloAberto;
        }

        public DateTime? DataVencimentoAcordoAberto(int xCodCliente, int xFilialCliente)
        {
            using (SqlConnection conn = new SqlConnection(ConnDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select data_vencimento  from Acordo_Aberto() " +
                        "where cod_cliente = " + xCodCliente + " and " +
                        "cod_filial_cliente = " + xFilialCliente + " and " +
                        "data_vencimento < GETDATE() and data_recebimento is null";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataVencAcordoAberto = Convert.ToDateTime(reader["data_vencimento"]);
                        }
                    }
                }
            }

          return DataVencAcordoAberto;
        }

    }
}
