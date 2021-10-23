using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace MRUtil
{
    public class ConexaoDB
    {
        public string stringConexao;
        public string MensagemErro { get; private set; }
        public SqlConnection Conn { get; private set; }
        public bool ConectadoBanco { get; set; }

        Arquivo conf = new Arquivo();

        public ConexaoDB()
        {
            try
            {
                conf.ArquivoConfig(AppDomain.CurrentDomain.BaseDirectory + @"\config.xml");
                /*stringConexao = "Data Source = " + conf.ServidorDB + ";" + "Initial Catalog = " + conf.BancoDB + ";" +
                    "User Id = " + conf.UsuarioDB + ";" + "Password = " + Criptografia.TextoDescriptografado(conf.SenhaDB) + ";" +
                    "Integrated Security = True";*/
                stringConexao = @"Data Source = " + conf.ServidorDB + ";" + "Initial Catalog = " + conf.BancoDB + ";" +
                    "Trusted_Connection = True";
                AbreConexaoBanco();
            }
            catch (Exception ex)
            {
                if (conf.Log == true)
                {
                    conf.MensagemLog(ex.Message);
                }
            }
        }

        public ConexaoDB(string servidor, string banco, string usuario, string senha)
        {
            try
            {
                stringConexao = "Data Source = " + servidor + ";" + "Initial Catalog = " + banco + ";" +
                    "User Id = " + usuario + ";" + "Password = " + senha + ";" +
                    "Integrated Security = True";
            }
            catch (Exception ex)
            {
                if (conf.Log == true)
                {
                    conf.MensagemLog(ex.Message);
                }
            }
        }

        public bool AbreConexaoBanco()
        {
            ConectadoBanco = false;
            using (Conn = new SqlConnection(stringConexao))
            {
                try
                {
                    if (Conn.State == ConnectionState.Closed)
                    {
                        Conn.Open();
                        ConectadoBanco = true;
                    }
                }
                catch (Exception ex)
                {
                    if (conf.Log == true)
                    {
                        conf.MensagemLog(ex.Message);
                    }

                    MensagemErro = ex.Message;
                }
            }

            return ConectadoBanco;
        }

        public void FechaConexaoBanco()
        {
            if (Conn != null)
            {
                Conn.Close();
                Conn.Dispose();
            }
        }

        public DataTable CarregaTabela(string instrucaoSQL, ref DataTable tabela)
        {  
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = instrucaoSQL;
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        try
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = instrucaoSQL;
                            cmd.CommandTimeout = 240;
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                            tabela = ds.Tables[0];
                        }
                        catch (Exception ex)
                        {
                            if (conf.Log == true)
                            {
                                conf.MensagemLog(ex.Message);
                            }

                            MensagemErro = ex.Message;
                        }
                    }
                }
            }
            return tabela;
        }

        public DataSet CarregaDataSet(string instrucaoSQL, ref DataSet dsDataset)
        {
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = instrucaoSQL;
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        try
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = instrucaoSQL;
                            da.SelectCommand = cmd;
                            //dsDataset.Clear();
                            da.Fill(dsDataset);
                        }
                        catch (Exception ex)
                        {
                            if (conf.Log == true)
                            {
                                conf.MensagemLog(ex.Message);
                            }

                            MensagemErro = ex.Message;
                        }
                    }
                }
            }

            return dsDataset;
        }

        public bool SalvaAtualizaExcluiReg(string instrucaoSQL)
        {
            bool resultado = false;                  

            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = instrucaoSQL;
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            cmd.Transaction = tran;
                            cmd.ExecuteNonQuery();
                            tran.Commit();
                            resultado = true;
                            if (conf.Exportar == true)
                            {
                                Exporta(instrucaoSQL);
                            }
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            if (conf.Log == true)
                            {
                                conf.MensagemLog(ex.Message);
                            }

                            MensagemErro = ex.Message;
                        }
                    }
                }
            }

            return resultado;
        }

        public void Exporta(string instrucaoSQL)
        {
            string strSQL = string.Empty;
            DataTable tb = new DataTable();

            AbreConexaoBanco();

            try
            {
                strSQL = "Select id_filial from almoxarifado where id_filial <> 0 and id_filial <> 1 and ativo = 1";
                CarregaTabela(strSQL, ref tb);

                int m = tb.Rows.Count;
                int i = 0;

                while (i < m)
                {
                    strSQL = "insert into fila_exportacao(id_fila, origem, gerado, destino, instrucao, data_inclusao) values(" +
                        RetornaChave("id_fila", "fila_exportacao", "") + "," + conf.Filial + "," + conf.Filial + "," + tb.Rows[i]["id_filial"] + "," +
                        Geral.AspasSQL(Fila(instrucaoSQL)) + "," + Geral.DataSQL(DateTime.Now.ToShortDateString()) + ")";

                    conf.Exportar = false;
                    SalvaAtualizaExcluiReg(strSQL);

                    i += 1;
                }
            }
            catch (SqlException ex)
            {
                if (conf.Log == true)
                {
                    conf.MensagemLog(ex.Message);
                }

                MensagemErro = ex.Message;
            }
            finally
            {
                FechaConexaoBanco();
            }

        }

        public string RetornaUltimoRegistro(string instrucaoSQL)
        {
            string resultado = string.Empty;

            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = instrucaoSQL;
                    using (var dr = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (dr.Read())
                            {
                                resultado = dr[0].ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            if (conf.Log == true)
                            {
                                conf.MensagemLog(ex.Message);
                            }

                            MensagemErro = ex.Message;
                        }
                    }
                }
            }

            return resultado;
        }

        public int VerificaExistenciaReg(string instrucaoSQL)
        {
            int resultado = 0;
            
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = instrucaoSQL;
                    using (var reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            if (reader.HasRows)
                            {
                                resultado = 1;
                            }
                        }
                        catch (Exception ex)
                        {
                            if (conf.Log == true)
                            {
                                conf.MensagemLog(ex.Message);
                            }

                            MensagemErro = ex.Message;
                        }
                    }
                }
            }
            


            return resultado;
        }

        public int RetornaChave(string campo, string tabela, string criterio)
        {
            int resultado = 0;
            string strSQL = "select max(" + campo + ") from " + tabela + " " + criterio;

            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;

                    using (var reader = cmd.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                if (reader[0] != DBNull.Value)
                                {
                                    resultado = Convert.ToInt32(reader[0].ToString());
                                }
                                else
                                {
                                    resultado = 0;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            if (conf.Log == true)
                            {
                                conf.MensagemLog(ex.Message);
                            }

                            MensagemErro = ex.Message;
                        }
                    }
                }
            }
            

            return resultado + 1;
        }

        private string Fila(string texto)
        {
            texto = texto.Replace("'", "`");
            return texto;
        }

        public DateTime RetornaDataServidor()
        {
            DateTime? resultado = null;
            string strSQL = "SELECT GETDATE()";

            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            resultado = (DateTime)dr[0];
                        }
                    }
                }
            }
            

            return (DateTime)resultado;
        }

    }
}
