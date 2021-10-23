using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class Uf
    {
        ConexaoDB conexao = new ConexaoDB();

        public int CodigoUF { get; set; }
        public string Estado { get; set; }

        public Uf() { }

        public List<Uf> RetornaEstado(int x_CodigoEstado)
        {
            List<Uf> _lista = new List<Uf>();
            string strSQL = "select * from uf where codigo = " + x_CodigoEstado;

            if (conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    _lista.Add(new Uf()
                    {
                        CodigoUF = Convert.ToInt16(dr["codigo"]), Estado = dr["estado"].ToString()
                    });
                }

                dr.Close();
            }

            return _lista;
        }

        public List<Uf> RetornaEstado()
        {
            List<Uf> _lista = new List<Uf>();
            string strSQL = "select * from uf order by estado";

            if (conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    _lista.Add(new Uf() { CodigoUF = Convert.ToInt16(dr["codigo"]), Estado = dr["estado"].ToString() });
                }

                dr.Close();
            }

            return _lista;
        }

        /// <summary>
        ///Retorna os dados da tabela UF, de acordo com a sigla do estado informado.
        /// </summary>
        public void RetornaEstado(string estado)
        {
            string strSQL = "select * from uf where estado = " + Geral.AspasSQL(estado);

            if (conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.CodigoUF = Convert.ToInt32(dr["codigo"].ToString());
                    this.Estado = dr["estado"].ToString();
                }

                dr.Close();
            }
        }
    }
}
