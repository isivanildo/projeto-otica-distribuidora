using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace MRSystem.classes
{
    class Arquivo
    {
        public int Filial { get; private set; }
        public string Servidor { get; set; }
        public string Porta { get; set; }
        public string Banco { get; set; }
        public string UsuarioBanco { get; set; }
        public string SenhaUsuario { get; set; }

        //Método responsável po ler o arquivo de configuração com os dados de conexao ao banco de dados (config.xml)
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
                    Servidor = tb.Rows[0][1].ToString();
                    Porta = tb.Rows[0][2].ToString();
                    Banco = tb.Rows[0][3].ToString();
                    UsuarioBanco = tb.Rows[0][4].ToString();
                    SenhaUsuario = tb.Rows[0][5].ToString();
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
        public static string MensagemLog(string mensagem)
        {
            StreamWriter arquivo;
            string strCaminho = AppDomain.CurrentDomain.BaseDirectory + @"\log";
            if (Directory.Exists(strCaminho) == false)
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\log");
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
