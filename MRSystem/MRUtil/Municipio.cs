using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class Municipio
    {
        ConexaoDB conexao = new ConexaoDB();

        public int CodigoCidade { get; set; }
        public string Cidade { get; set; }
        public int CodigoUF { get; set; }

        public Municipio() { }

        public List<Municipio> RetornaCidade()
        {
            List<Municipio> _Lista = new List<Municipio>();
            string strSQL = "select * from cidade order by cidade";

            if (conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    _Lista.Add(new Municipio()
                    {
                        CodigoCidade = Convert.ToInt32(dr["codigo"]),
                        Cidade = dr["cidade"].ToString(),
                        CodigoUF = Convert.ToInt16(dr["uf"])
                    });
                }

                dr.Close();
            }

            return _Lista;
        }
        public List<Municipio> RetornaCidade(int x_CodigoCidade)
        {
            List<Municipio> _Lista = new List<Municipio>();
            string strSQL = "seelct * from cidade order by cidade";

            if (conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    _Lista.Add(new Municipio() {
                        CodigoCidade = Convert.ToInt32(dr["codigo"]),
                        Cidade = dr["cidade"].ToString(),
                        CodigoUF = Convert.ToInt16(dr["uf"])
                    });
                }

                dr.Close();
            }

            return _Lista;
        }

        /// <summary>
        ///Retorna os dados da tabela Cidade, de acordo com a sigla da cidade e o código do estado informado.
        /// </summary>
        public void RetornaCidade(string cidade, int uf)
        {
            string strSQL = "select * from cidade where cidade = " + Geral.AspasSQL(cidade) + " and uf = " + uf;

            if (conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.CodigoCidade = Convert.ToInt32(dr["codigo"].ToString());
                    this.Cidade = dr["cidade"].ToString();
                    this.CodigoUF = Convert.ToInt32(dr["uf"].ToString());
                }

                dr.Close();
            }
        }

    }
}
