using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Devart.Data.PostgreSql;

namespace MRSystem.classes
{
    class Conexao
    {
        private string stringConexao;
        private PgSqlConnection conn;
        Arquivo conf = new Arquivo();

        public Conexao()
        {
            conf.ArquivoConfig(AppDomain.CurrentDomain.BaseDirectory + @"\config.xml");
            stringConexao = "User Id = " + conf.UsuarioBanco + ";" +
                "Password = " + Criptografia.TextoDescriptografado(conf.SenhaUsuario) + ";" + "Host = " + conf.Servidor + ";" +
                "Port = " + conf.Porta + ";" + "Database = " + conf.Banco + ";" + "Pooling=true " + ";" +
                "Min Pool Size = 0" + ";" + "Max Pool Size = 100; Connection Lifetime = 0";
        }

        public bool AbreConexao()
        {
            bool bResultado = false;

            conn = new PgSqlConnection(stringConexao);

            try
            {
                conn.Open();
                bResultado = true;
            }
            catch (Exception ex)
            {
                Arquivo.MensagemLog(ex.ToString());
            }
            finally
            {
                conn.Dispose();
                conn.Close();
            }

            return bResultado;
        }

        public void FechaConexao()
        {
            conn.Close();
            conn.Dispose();
        }

        public DataTable CarregaTabela(string strSql)
        {
            PgSqlCommand cmd = new PgSqlCommand();
            PgSqlDataAdapter da = new PgSqlDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandTimeout = 240;
            cmd.CommandText = strSql;

            return ds.Tables[0];

        }
        
    }
}
