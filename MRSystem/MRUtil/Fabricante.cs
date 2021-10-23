using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MRUtil
{
    public class Fabricante
    {
        ConexaoDB Conexao = new ConexaoDB();

        public int CodigoFabricante { get; set; }
        public string NomeFabricante { get; set; }
        public int? TipoFabricante { get; set; }

        public void Novo()
        {
            CodigoFabricante = 0;
            NomeFabricante = string.Empty;
            TipoFabricante = 0;
        }

        public void RetornaRegistro()
        {
            string strSQL = "select from fabricante";

            if (Conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, Conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CodigoFabricante = Convert.ToInt32(dr["id_fabricante"]);
                    NomeFabricante = dr["fabricante"].ToString();
                    TipoFabricante = Convert.ToInt32(dr["tipo"].ToString());
                }

                dr.Close();
            }

        }

        public void SalvaFabricante()
        {
            string strSQL = "insert into fabricante(id_fabricante, fabricante, tipo) values(" + CodigoFabricante + "," + Geral.AspasSQL(NomeFabricante) + "," +
                TipoFabricante + ")";
            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public void AtualizaFabricante(int xCodigo)
        {
            string strSQL = "update fabricante set fabricante = " + Geral.AspasSQL(NomeFabricante) + ", tipo = " + TipoFabricante +
                " where id_fabricante = " + CodigoFabricante;
            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public string ExcluiFabricante(int xCodigoFAbricante)
        {
            string resultado = string.Empty;
            string strSQL = "delete from fabricante where id_fabricante = " + xCodigoFAbricante;

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = "OK";
            }

            return resultado;
        }

        private int VerificaCampos()
        {
            if (string.IsNullOrEmpty(NomeFabricante))
                return 1;
            if (TipoFabricante == -1)
                return 2;

            return 0;
        }

        public bool VerificaCampoObrigatorio()
        {
            bool resultado = false;
            switch (VerificaCampos())
            {
                case 1:
                    MessageBox.Show("Campo Nome Fabricante é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 2:
                    MessageBox.Show("Campo Tipo Fabricante é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
            }

            return resultado;
        }


    }
}
