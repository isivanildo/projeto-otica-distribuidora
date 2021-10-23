using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRUtil
{
    public class NaturezaOperacao
    {
        ConexaoDB Conexao = new ConexaoDB();
        public int CodigoNatureza { get; set; }
        public int TipoNFe { get; set; }
        public string Descricao { get; set; }

        public int PrecoUsado;

        public int ConsumidorFinal;
        public string Observacao { get; set; }
        public int DestinoOperacao { get; set; }
        public int ConsumidorPresente { get; set; }
        public int FinalidadeNota { get; set; }

        public NaturezaOperacao() { }

        public void Novo()
        {
            CodigoNatureza = 0;
            TipoNFe = 0;
            Descricao = string.Empty;
            PrecoUsado = 0;
            ConsumidorFinal = 0;
            Observacao = string.Empty;
            DestinoOperacao = 0;
            ConsumidorPresente = 0;
            FinalidadeNota = 0;
        }

        public void RetornaRegistro(int xCodigoNatureza)
        {
            string strSQL = "select * from naturezaoperacao where codigonat = " + xCodigoNatureza;
            
            if (Conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, Conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CodigoNatureza = Convert.ToInt16(dr["codigonat"].ToString());
                    TipoNFe = Convert.ToInt16(dr["tiponfe"].ToString());
                    Descricao = dr["descricao"].ToString();
                    PrecoUsado = Convert.ToInt16(dr["precousado"].ToString());
                    ConsumidorFinal = Convert.ToInt16(dr["consumidorfinal"].ToString());
                    Observacao = dr["observacao"].ToString();
                    DestinoOperacao = Convert.ToInt32(dr["destinooperacao"].ToString());
                    ConsumidorPresente = Convert.ToInt16(dr["consumidorpresente"].ToString());
                    FinalidadeNota = Convert.ToInt32(dr["finalidadenota"].ToString());
                }

                dr.Close();
            }

        }

        public void SalvaOperacao()
        {
            string strSQL = "";

            strSQL = "insert into naturezaoperacao (codigonat, tiponfe, descricao, precousado, consumidorfinal, observacao, destinooperacao, " +
                "consumidorpresente, finalidadenota) values(" + CodigoNatureza + "," + TipoNFe + "," + Geral.AspasSQL(Descricao) + "," + PrecoUsado + "," + 
                ConsumidorFinal + "," + Geral.AspasSQL(Observacao) + "," + DestinoOperacao + "," + ConsumidorPresente + "," + FinalidadeNota + ")";

            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public void AtualizaOperacao()
        {
            string strSQL = "";

            strSQL = "update naturezaoperacao set tiponfe = " + TipoNFe + "," + "descricao = " + Geral.AspasSQL(Descricao) + "," +
                "precousado = " + PrecoUsado + "," + "consumidorfinal = " + ConsumidorFinal + "," + "observacao = " + Geral.AspasSQL(Observacao) + "," +
                "destinooperacao = " + DestinoOperacao + "," +
                "consumidorpresente = " + ConsumidorPresente +
                " where codigonat = " + CodigoNatureza;

            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public void ExcluirOperacao(int xCodigoNatureza)
        {
            string strSQL = "";
            strSQL = "delete from naturezaoperacao where codigonat = " + xCodigoNatureza;

            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

        public AutoCompleteStringCollection CarregaListaOperacao()
        {
            AutoCompleteStringCollection _Lista = new AutoCompleteStringCollection();

            string strSQL = "select * from naturezaoperacao";

            if (Conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, Conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    _Lista.Add(dr["descricao"].ToString());
                }

                dr.Close();
            }
            return _Lista;
        }

    }
}
