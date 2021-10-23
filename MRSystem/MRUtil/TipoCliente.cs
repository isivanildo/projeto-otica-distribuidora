using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MRUtil
{
    public class TipoCliente
    {
        public int CodigoTipoCliente { get; set; }
        public string DescTipoCliente { get; set; }

        ConexaoDB ConnDB = new ConexaoDB();

        public TipoCliente() { }

        public bool SalavaTipoCliente()
        {
            bool bResultado = false;
            string strSQL = "insert into tipo_cliente(cod_tipo_cliente, tipo_cliente) " +
                "values(" + CodigoTipoCliente  + "," + Geral.AspasSQL(DescTipoCliente) +")";

            if (ConnDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;
        }

        public bool AtualizaTipoCliente()
        {
            bool bResultado = false;
            string strSQL = "update tipo_cliente set tipo_cliente = " + Geral.AspasSQL(DescTipoCliente) +
                " where cod_tipo_cliente = " + CodigoTipoCliente;

            if (ConnDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;
        }

        public List<TipoCliente> RetornaDados()
        {
            List<TipoCliente> _lista = new List<TipoCliente>();

            using (SqlConnection conn = new SqlConnection(ConnDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from tipo_cliente";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _lista.Add(new TipoCliente()
                            {
                                CodigoTipoCliente = Convert.ToInt32(reader["cod_tipo_cliente"]),
                                DescTipoCliente = reader["tipo_cliente"].ToString()
                            });
                        }
                    }
                }
            }



                return _lista;
        }


    }
}
