using System;
using System.Data;

namespace MRUtil
{
    public class NFe_CCe
    {
        ConexaoDB conn = new ConexaoDB();
        DataTable tb = new DataTable();

        public string Emitente { get; set; }
        public int NumeroNFe { get; set; }
        public int Serie { get; set; }
        public int Modelo { get; set; }
        public int NumeroEvento { get; set; }
        public string Descricao { get; set; }
        public string ChaveNFe { get; set; }
        public string Protocolo { get; set; }
        public DateTime? DataEvento { get; set; }
        public string CCeAssinada { get; set; }
        public int UsuarioInclusao { get; set; }

        public NFe_CCe() { }

        public bool SalvaCCeNFe()
        {
            bool resultado = false;

            string strSQL = "INSERT INTO NFe_CCe(emitente, numero, serie, modelo, num_evento, descricao, inc_usuario) " +
                "VALUES (" + Geral.AspasSQL(Emitente) + "," + NumeroNFe + "," + Serie + "," + Modelo + "," +
                NumeroEvento + "," + Geral.AspasSQL(Descricao) + "," + UsuarioInclusao + ")";

            if (conn.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }

        public bool AtualizaCCeNFe()
        {
            bool resultado = false;

            string strSQL = "update NFe_CCe set descricao = " + Geral.AspasSQL(Descricao) + "," + "chavenfe = " + Geral.AspasSQL(ChaveNFe) + "," +
                "protocolo = " + Geral.AspasSQL(Protocolo) + "," + "d_evento = " + Geral.DataSQL(DataEvento.ToString()) + "," +
                "cceassinada = " + Geral.AspasSQL(CCeAssinada) + " where emitente = " + Geral.AspasSQL(Emitente) + " and " +
                "numero = " + NumeroNFe + " and serie = " + Serie + " and modelo = " + Modelo; 

            if (conn.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }

        public void Registro(string xemitente, int xserie, int xmodelo, int xnumeroNota)
        {
            string strSQL = "select * from nfe_cce where emitente = " + Geral.AspasSQL(xemitente) + " and numero = " + xnumeroNota +
                " and serie = " + xserie + " and modelo = " + xmodelo + "";

            conn.CarregaTabela(strSQL, ref tb);

            if (tb.Rows.Count > 0)
            {
                Emitente = tb.Rows[0]["emitente"].ToString();
                NumeroNFe = Convert.ToInt32(tb.Rows[0]["numero"].ToString());
                Serie = Convert.ToInt32(tb.Rows[0]["serie"].ToString());
                Modelo = Convert.ToInt32(tb.Rows[0]["modelo"].ToString());
                NumeroEvento = Convert.ToInt32(tb.Rows[0]["num_evento"].ToString());
                Descricao = tb.Rows[0]["descricao"].ToString();
                ChaveNFe = tb.Rows[0]["chavenfe"].ToString();
                Protocolo = tb.Rows[0]["protocolo"].ToString();
                DataEvento = Convert.ToDateTime(tb.Rows[0]["d_evento"].ToString());
                CCeAssinada = tb.Rows[0]["cceassinada"].ToString();
                UsuarioInclusao = Convert.ToInt32(tb.Rows[0]["inc_usuario"].ToString());
            }
        }

        public int RegistroNumeroEvento(string xemitente, int xserie, int xmodelo, int xnumeroNota)
        {
            string strSQL = "select sum(num_evento) as num_evento from NFe_CCe where emitente = " + Geral.AspasSQL(xemitente) + " and numero = " + xnumeroNota +
                " and serie = " + xserie + " and modelo = " + xmodelo + "";

            conn.CarregaTabela(strSQL, ref tb);

            if (tb.Rows.Count > 0)
            {
                if (tb.Rows[0]["num_evento"] != DBNull.Value)
                {
                    NumeroEvento = Convert.ToInt32(tb.Rows[0]["num_evento"]) + 1;
                }
                else
                {
                    NumeroEvento = 1;
                }
            }

            return NumeroEvento;
        }
    }
}
