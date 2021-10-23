using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MRUtil
{
    public class NFe_Cobranca
    {
        ConexaoDB conn = new ConexaoDB();
        DataTable tb = new DataTable();

        public string Emitente { get; set; }
        public int NumeroNFe { get; set; }
        public int Serie { get; set; }
        public int Modelo { get; set; }
        public int? TipoPagamento { get; set; }
        public string MeioPagamento { get; set; }
     
        public NFe_Cobranca() { }

        public bool SalvaCobrancaNFe()
        {
            bool resultado = false;

            string strSQL = "INSERT INTO NFe_Cobranca(emitente, numero, serie, modelo, tipopagamento, " +
                "formapagamento) VALUES (" + Geral.AspasSQL(Emitente) + "," + NumeroNFe + "," + Serie + "," + Modelo + "," + 
                Geral.NumeroSQL(TipoPagamento) + "," + Geral.AspasSQL(MeioPagamento) + ")";

            if (conn.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }

        public void AtualizaCobrancaNFe()
        {
            string strSQL = "update NFe_cobranca set tipopagamento = " + Geral.NumeroSQL(TipoPagamento) + "," +
                "formapagamento = " + Geral.AspasSQL(MeioPagamento) + " where emitente = " + Geral.AspasSQL(Emitente) + " and numero = " + NumeroNFe +
                " and serie = " + Serie + " and modelo = " + Modelo;

            conn.SalvaAtualizaExcluiReg(strSQL);
        }

        public void Registro(string xemitente, int xserie, int xmodelo, int xnumeroNota)
        {
            string strSQL = "select * from nfe_cobranca where emitente = " + Geral.AspasSQL(xemitente) + " and numero = " + xnumeroNota +
                " and serie = " + xserie + " and modelo = " + xmodelo + "";

            conn.CarregaTabela(strSQL, ref tb);

            if (tb.Rows.Count > 0)
            {
                Emitente = tb.Rows[0]["emitente"].ToString();
                NumeroNFe = Convert.ToInt32(tb.Rows[0]["numero"].ToString());
                Serie = Convert.ToInt32(tb.Rows[0]["serie"].ToString());
                Modelo = Convert.ToInt32(tb.Rows[0]["modelo"].ToString());
                if (tb.Rows[0]["tipopagamento"] != DBNull.Value)
                {
                    TipoPagamento = Convert.ToInt32(tb.Rows[0]["tipopagamento"].ToString());
                }
                else
                {
                    TipoPagamento = null;
                }
                
                MeioPagamento = tb.Rows[0]["formapagamento"].ToString();
            }
        }
    }

}

