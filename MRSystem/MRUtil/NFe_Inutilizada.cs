using System;
using System.Data;

namespace MRUtil
{
    public class NFe_Inutilizada
    {
        ConexaoDB conn = new ConexaoDB();
        DataTable tb = new DataTable();

        public string Emitente { get; set; }
        public int NumeroNFe { get; set; }
        public int Serie { get; set; }
        public int Modelo { get; set; }
        public string Justificativa { get; set; }

        public NFe_Inutilizada() { }

        public bool SalvaNFeInutilizada()
        {
            bool resultado = false;

            string strSQL = "INSERT INTO NFe_Inutilizada(emitente, numero, serie, modelo, justificativa) " +
                "VALUES (" + Geral.AspasSQL(Emitente) + "," + NumeroNFe + "," + Serie + "," + Modelo + "," +
                Geral.AspasSQL(Justificativa) + ")";

            if (conn.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }

        public bool AtualizaNFeInutilizada()
        {
            bool resultado = false;

            string strSQL = "update NFe_Inutilizada set justificativa = " + Geral.AspasSQL(Justificativa) + " where emitente = " + Geral.AspasSQL(Emitente) + 
                " and " + "numero = " + NumeroNFe + " and serie = " + Serie + " and modelo = " + Modelo;

            if (conn.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }

        public void Registro(string xemitente, int xserie, int xmodelo, int xnumeroNota)
        {
            string strSQL = "select * from nfe_inutilizada where emitente = " + Geral.AspasSQL(xemitente) + " and numero = " + xnumeroNota +
                " and serie = " + xserie + " and modelo = " + xmodelo + "";

            conn.CarregaTabela(strSQL, ref tb);

            if (tb.Rows.Count > 0)
            {
                Emitente = tb.Rows[0]["emitente"].ToString();
                NumeroNFe = Convert.ToInt32(tb.Rows[0]["numero"].ToString());
                Serie = Convert.ToInt32(tb.Rows[0]["serie"].ToString());
                Modelo = Convert.ToInt32(tb.Rows[0]["modelo"].ToString());
                Justificativa = tb.Rows[0]["justificativa"].ToString();
            }
        }
    }
}
