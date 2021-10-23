using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MRUtil
{
    public class Cidades
    {
        public int CodigoCidade { get; set; }
        public string NomeCidade { get; set; }

        public int Uf { get; set; }

        ConexaoDB ConnDB = new ConexaoDB();

        public Cidades() { }

        public void Novo()
        {
            CodigoCidade = 0;
            NomeCidade = string.Empty;
            Uf = 0;
        }

        public bool SalvaCidade()
        {
            bool bResultado = false;

            string strSQL = "insert into cidade(codigo, cidade, uf) values(" + CodigoCidade + "," +
                Geral.AspasSQL(NomeCidade) + "," + Uf;

            if (ConnDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;

        }

        public bool AtualizaCidade()
        {
            bool bResultado = false;

            string strSQL = "updade cidade set = codigo = " + CodigoCidade + "," +
                "cidade = " + Geral.AspasSQL(NomeCidade) + "," + "uf = " + Uf;

            if (ConnDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;
        }

        public bool ExcluirCidade()
        {
            bool bResultado = false;
            string strSQL = "delete from cidade where codigo = " + CodigoCidade;

            if (ConnDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;
        }

        public List<Cidades> RetornaCidade()
        {
            string strSQL = "select * from cidade";

            List<Cidades> _lista = new List<Cidades>();

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
                            _lista.Add(new Cidades()
                            {
                                CodigoCidade = Convert.ToInt32(reader["codigo"]),
                                NomeCidade = reader["cidade"].ToString(),
                                Uf = Convert.ToInt32(reader["uf"])
                            });
                        }
                    }
                    
                }
            }

            return _lista;

        }


    }
}
