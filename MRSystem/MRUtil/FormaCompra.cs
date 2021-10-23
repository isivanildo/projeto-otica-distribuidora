using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MRUtil
{
    public class FormaCompra
    {
        public int CodigoFormaCompra { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoFilialCliente { get; set; }
        public string DescricaoCompra { get; set; }

        ConexaoDB ConnDB = new ConexaoDB();

        public FormaCompra() { }

        public bool SalvaFormaCompra()
        {
            bool bResultado = false;
            string strSQL = "insert into tipo_compra(codigo, descricao) " +
                "values(" + CodigoFormaCompra + "," + Geral.AspasSQL(DescricaoCompra) + ")";

            if (ConnDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;
        }

        public void ExcluiFormaCompraCliente(int xCodigoCliente, int xCodigoFilial)
        {
            string strSQL = "delete from forma_compra where cod_cliente = " + xCodigoCliente +
                " and cod_filial_cliente = " + xCodigoFilial;
            ConnDB.SalvaAtualizaExcluiReg(strSQL);
        }

        public void SalvaFormaCompraCliente(string xFormaCompra)
        {
            string strSQL = string.Empty;

            strSQL = "select codigo from tipo_compra where descricao = " + Geral.AspasSQL(xFormaCompra);

            using (SqlConnection conn = new SqlConnection(ConnDB.stringConexao))
            {
                conn.Open();
               using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CodigoFormaCompra = Convert.ToInt32(reader["codigo"]);
                            strSQL = "insert into forma_compra(codigo_tipo_compra, cod_cliente," +
                                "cod_filial_cliente) values(" + CodigoFormaCompra + "," + CodigoCliente + "," +
                                CodigoFilialCliente + ")";
                            ConnDB.SalvaAtualizaExcluiReg(strSQL);
                        }
                    }
                }
            }
        }

            public List<FormaCompra> RetornaDados()
            {
                List<FormaCompra> _lista = new List<FormaCompra>();

                using (SqlConnection conn = new SqlConnection(ConnDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from tipo_compra";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _lista.Add(new FormaCompra()
                            {
                                CodigoFormaCompra = Convert.ToInt32(reader["codigo"]),
                                DescricaoCompra = reader["descricao"].ToString()
                            });
                        }
                    }
                }
            }



                return _lista;
            }

            public List<FormaCompra> RetornaFormaCompra(int xCodigoCliente)
            {
                List<FormaCompra> _lista = new List<FormaCompra>();

                using (SqlConnection conn = new SqlConnection(ConnDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select fc.codigo_tipo_compra, tc.descricao from tipo_compra tc " +
                        "inner join forma_compra fc on tc.codigo = fc.codigo_tipo_compra " +
                        "where fc.cod_cliente = " + xCodigoCliente;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _lista.Add(new FormaCompra()
                            {
                                CodigoFormaCompra = Convert.ToInt32(reader["codigo_tipo_compra"]),
                                DescricaoCompra = reader["descricao"].ToString()
                            });
                        }
                    }
                }
            }



                return _lista;
            }
    }
}
