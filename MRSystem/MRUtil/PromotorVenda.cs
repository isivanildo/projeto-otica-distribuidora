using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MRUtil
{
    public class PromotorVenda
    {

        public int CodigoPromotor { get; set; }
        public string NomePromotor { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoFilialCliente { get; set; }

        ConexaoDB ConnDB = new ConexaoDB();

        public PromotorVenda() { }

        public bool SalvaPromotorVenda()
        {
            bool bResultado = false;

            string strSQL = "insert into promotor(cod_prmotor, promotor) values(" + CodigoPromotor + "," +
                Geral.AspasSQL(NomePromotor) + ")";
            if (ConnDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;

        }

        public bool AtualizaPromotorVenda()
        {
            bool bResultado = false;

            string strSQL = "update promotor set promotor = " + Geral.AspasSQL(NomePromotor) +
                " where cod_promotor = " + CodigoPromotor;

            if (ConnDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;
        }

        public void ExcluiPromotorVendaCliente(int xCodigoCliente, int xCodigoFilial)
        {
            string strSQL = "delete from promotor_cliente where cod_cliente = " + xCodigoCliente +
                " and cod_filial_cliente = " + xCodigoFilial;
            ConnDB.SalvaAtualizaExcluiReg(strSQL);
        }

        public void SalvaPromotorVendaCliente(string xPromotor)
        {
            string strSQL = string.Empty;

            strSQL = "select cod_promotor from promotor where promotor = " + Geral.AspasSQL(xPromotor);

            ConnDB.AbreConexaoBanco();

            using (var cmd = ConnDB.Conn.CreateCommand())
            {
                cmd.CommandText = strSQL;
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CodigoPromotor = Convert.ToInt32(reader["cod_promotor"]);
                        strSQL = "insert into promotor_cliente(cod_promotor, cod_filial_cliente," +
                            "cod_cliente) values(" + CodigoPromotor + "," + CodigoFilialCliente + "," +
                            CodigoCliente + ")";
                        ConnDB.SalvaAtualizaExcluiReg(strSQL);
                    }
                }
            }

        }

        public List<PromotorVenda> RetornaRegistro()
        {
            List<PromotorVenda> _lista = new List<PromotorVenda>();

            using (SqlConnection conn = new SqlConnection(ConnDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from promotor";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _lista.Add(new PromotorVenda()
                            {
                                CodigoPromotor = Convert.ToInt32(reader["cod_promotor"]),
                                NomePromotor = reader["promotor"].ToString()
                            });
                        }
                    }

                }
            }

                return _lista;
        }

        public List<PromotorVenda> RetornaPromotorVendaPorCliente(int xCodigoCliente)
        {
            List<PromotorVenda> _lista = new List<PromotorVenda>();

           using (SqlConnection conn = new SqlConnection(ConnDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select pc.cod_promotor, p.promotor from promotor p inner join " +
                        "promotor_cliente pc on p.cod_promotor = pc.cod_promotor " +
                        "where pc.cod_cliente = " + xCodigoCliente;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _lista.Add(new PromotorVenda()
                            {
                                CodigoPromotor = Convert.ToInt32(reader["cod_promotor"]),
                                NomePromotor = reader["promotor"].ToString()
                            });
                        }
                    }

                }
            }

            return _lista;
        }
    }
}
