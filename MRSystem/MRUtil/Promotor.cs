using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MRUtil
{
    public class Promotor
    {
        ConexaoDB Conexao = new ConexaoDB();

        public int CodigoPromotor { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoFilialCliente { get; set; }
        public string NomePromotor { get; set; }
        public bool Situacao { get; set; }

        public void Novo()
        {
            CodigoPromotor = 0;
            NomePromotor = string.Empty;
            Situacao = true;
        }

        public void RetornaRegistro()
        {
            string strSQL = "select from promotor";

            //Conexao.AbreConexaoBanco();
            SqlCommand cmd = new SqlCommand(strSQL, Conexao.Conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CodigoPromotor = Convert.ToInt32(dr["cod_promotor"]);
                NomePromotor = dr["promotor"].ToString();
                Situacao = Convert.ToBoolean(dr["promotor"].ToString());
            }

            dr.Close();
        }

        public DataTable CarregaRegistro(int xCodigoFilial, int xCodigoCliente)
        {
            DataTable tbPromotor = new DataTable();

            string strSQL = "select promotor.promotor as promotor from promotor inner join promotor_cliente on " +
                "promotor.cod_promotor = promotor_cliente.cod_promotor where promotor_cliente.cod_filial_cliente = " + xCodigoFilial +
                " and promotor_cliente.cod_cliente = " + xCodigoCliente;

            Conexao.CarregaTabela(strSQL, ref tbPromotor);
            return tbPromotor;
        }

        public void SalvaPromotor()
        {
            string strSQL = "insert into promotor(cod_promotor, promotor, situacao) values(" + CodigoPromotor + "," +
                Geral.AspasSQL(NomePromotor) + Geral.AspasSQL(Situacao.ToString()) + ")";
            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public void AtualizaPromotor(int xCodigo)
        {
            string strSQL = "update promotor set promotor = " + Geral.AspasSQL(NomePromotor) + "," + "situacao = " + Geral.AspasSQL(Situacao.ToString()) +
                " where cod_promotor = " + xCodigo;
            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public string ExcluirPromotor(int xCodigoPromotor)
        {
            string resultado = string.Empty;
            string strSQL = "delete from promotor where cod_promotor = " + xCodigoPromotor;

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = "OK";
            }

            return resultado;
        }

        public bool SalvaPromotorCliente()
        {
            bool bResultado = false;

            string strSQL = "insert into promotor_cliente(cod_promotor, cod_filial_cliente, cod_cliente) " +
            "values(" + CodigoPromotor + "," + CodigoFilialCliente + "," + CodigoCliente + ")";

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;
        }

        private int VerificaCampos()
        {
            if (string.IsNullOrEmpty(NomePromotor))
                return 1;

            return 0;
        }

        public bool VerificaCampoObrigatorio()
        {
            bool resultado = false;
            switch (VerificaCampos())
            {
                case 1:
                    MessageBox.Show("Campo Nome Promotor é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
            }

            return resultado;
        }


    }
}
