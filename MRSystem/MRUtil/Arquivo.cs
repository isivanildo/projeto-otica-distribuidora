using System;
using System.Data;
using System.IO;

namespace MRUtil
{
    public class Arquivo
    {
        public int Filial { get; set; }
        public string ServidorDB { get; set; }
        public string PortaDB { get; set; }
        public string BancoDB { get; set; }
        public string UsuarioDB { get; set; }
        public string SenhaDB { get; set; }
        public bool Exportar { get; set; }
        public bool Log { get; set; }

        public Arquivo()
        {

            DataSet ds = new DataSet();
            DataTable tb = new DataTable();

            try
            {
                ds.ReadXml("config.xml");

                tb = ds.Tables[0];

                if (tb.Rows.Count > 0)
                {
                    Filial = int.Parse(tb.Rows[0][0].ToString());
                    ServidorDB = tb.Rows[0][1].ToString();
                    PortaDB = tb.Rows[0][2].ToString();
                    BancoDB = tb.Rows[0][3].ToString();
                    UsuarioDB = tb.Rows[0][4].ToString();
                    SenhaDB = tb.Rows[0][5].ToString();
                    Exportar = Convert.ToBoolean(tb.Rows[0][6].ToString());
                    Log = Convert.ToBoolean(tb.Rows[0][7].ToString());

                }

            }
            catch (Exception ex)
            {
                MensagemLog(ex.ToString());
            }
            finally
            {
                tb.Dispose();
                ds.Tables.Clear();
            }
        }

        //Método responsável por ler o arquivo de configuração com os dados de conexao ao banco de dados (config.xml)
        public bool ArquivoConfig(string strCaminho)
        {
            bool bResultado = false;

            DataSet ds = new DataSet();
            DataTable tb = new DataTable();

            try
            {
                ds.ReadXml(strCaminho);

                tb = ds.Tables[0];

                if (tb.Rows.Count > 0)
                {
                    Filial = int.Parse(tb.Rows[0][0].ToString());
                    ServidorDB = tb.Rows[0][1].ToString();
                    PortaDB = tb.Rows[0][2].ToString();
                    BancoDB = tb.Rows[0][3].ToString();
                    UsuarioDB = tb.Rows[0][4].ToString();
                    SenhaDB = tb.Rows[0][5].ToString();
                    Exportar = Convert.ToBoolean(tb.Rows[0][6].ToString());
                    Log = Convert.ToBoolean(tb.Rows[0][7].ToString());

                }

                bResultado = true;
            }
            catch (Exception ex)
            {
                bResultado = false;
                MensagemLog(ex.ToString());
            }
            finally
            {
                tb.Dispose();
                ds.Tables.Clear();
            }

            return bResultado;
        }

        //Método responsável por criar e gravar os log com os erros gerados
        public string MensagemLog(string mensagem)
        {
            StreamWriter arquivo;
            string strCaminho = AppDomain.CurrentDomain.BaseDirectory + @"\belemtech_log";
            if (Directory.Exists(strCaminho) == false)
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\belemtech_log");
                arquivo = File.CreateText(strCaminho + @"\log.txt");
                arquivo.WriteLine("Data e hora do log: " + DateTime.Now);
                arquivo.WriteLine();
                arquivo.WriteLine(mensagem.ToString());
                arquivo.WriteLine("====================================================================================");
                arquivo.WriteLine();
            }
            else
            {
                arquivo = File.AppendText(strCaminho + @"\log.txt");
                arquivo.WriteLine("Data e hora do log: " + DateTime.Now);
                arquivo.WriteLine();
                arquivo.WriteLine(mensagem.ToString());
                arquivo.WriteLine("====================================================================================");
                arquivo.WriteLine();
            }

            arquivo.Close();

            return mensagem;
        }
    }
}
