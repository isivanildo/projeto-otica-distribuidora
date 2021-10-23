using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MRUtil.Belemtech;

namespace MRUtil
{
    public class CstNFe
    {
        ConexaoDB conn = new ConexaoDB();
        public int CodigoNaturezaOperacao { get; set; }
        public int CodigoOrigemMercadoria { get; set; }
        public string CST { get; set; }
        public string CSOSN { get; set; }
        public string CST_PIS { get; set; }
        public string CST_COFINS { get; set; }
        public int? ModBC { get; set; }
        public int? ModBCST { get; set; }
        public decimal PIcms { get; set; }
        public decimal PPIS { get; set; }
        public decimal PCOFINS { get; set; }
        public decimal PMVast { get; set; }
        public decimal PRedBCST { get; set; }
        public decimal PICMSST { get; set; }
        public decimal PFCP { get; set; }
        public string CFOP { get; set; }

        ConexaoDB conexao = new ConexaoDB();

        public CstNFe()
        {

        }

        public void SalvaAtualizaExcluiCst()
        {
            string strSQL = string.Empty;

            if ((Geral.TipoReg == Belemtech.TiposReg.Novo) && (CST == "00"))
            {
                strSQL = "insert into cstfiscal (codigonat, origem, cst, modbc, picms, pfcp) values(" + CodigoNaturezaOperacao + "," +
                    (int)CodigoOrigemMercadoria + "," + Geral.AspasSQL(CST) + "," + Geral.NumeroSQL(ModBC) + "," + Geral.ValorMoeda(PIcms) + "," +
                    Geral.ValorMoeda(PFCP) + ")";
            }
            else if ((Geral.TipoReg == Belemtech.TiposReg.Alterar) && (CST == "00"))
            {
                strSQL = "update cstfiscal set origem = " + CodigoOrigemMercadoria + "," + "cst = " + Geral.AspasSQL(CST) + "," +
                    "modbc = " + Geral.NumeroSQL(ModBC) + "," + "picms = " + Geral.ValorMoeda(PIcms) + "," + "pfcp = " + Geral.ValorMoeda(PFCP) +
                    " where codigonat = " + CodigoNaturezaOperacao;
            }
            else if ((Geral.TipoReg == Belemtech.TiposReg.Excluir) && (CST == "00"))
            {
                strSQL = "delete from cstfiscal where codigonat = " + CodigoNaturezaOperacao;
            }

            conexao.SalvaAtualizaExcluiReg(strSQL);
        }
        public void RetornaRegistro(int codigoNatrurezaOp)
        {
            string instrucaoSQL = "select * from CstFiscal where codigonat = " + codigoNatrurezaOp;
            DataTable tb = new DataTable();
            conn.CarregaTabela(instrucaoSQL, ref tb);

            if (tb.Rows.Count > 0)
            {
                CodigoNaturezaOperacao = Convert.ToInt16(tb.Rows[0]["codigonat"].ToString());
                CFOP = tb.Rows[0]["cfop"].ToString();
                CodigoOrigemMercadoria = Convert.ToInt32(tb.Rows[0]["origem"].ToString());
                CST = tb.Rows[0]["cst"].ToString();
                CSOSN = tb.Rows[0]["csosn"].ToString();
                if (tb.Rows[0]["modbc"] != DBNull.Value)
                {
                    ModBC = Convert.ToInt32(tb.Rows[0]["modbc"].ToString());
                }
                else
                {
                    ModBC = null;
                }             
                PIcms = Convert.ToDecimal(tb.Rows[0]["picms"].ToString());
                if (tb.Rows[0]["modbcst"] != DBNull.Value)
                {
                    ModBCST = Convert.ToInt32(tb.Rows[0]["modbcst"].ToString());
                }
                else
                {
                    ModBCST = null;
                }
                PMVast = Convert.ToDecimal(tb.Rows[0]["pmvast"].ToString());
                PRedBCST = Convert.ToDecimal(tb.Rows[0]["predbcst"].ToString());
                PICMSST = Convert.ToDecimal(tb.Rows[0]["picmsst"].ToString());
                PFCP = Convert.ToDecimal(tb.Rows[0]["pfcp"].ToString());
                CST_PIS = tb.Rows[0]["cst_pis"].ToString();
                PPIS = Convert.ToDecimal(tb.Rows[0]["ppis"].ToString());
                CST_COFINS = tb.Rows[0]["cst_cofins"].ToString();
                PCOFINS = Convert.ToDecimal(tb.Rows[0]["pcofins"].ToString());
            }

        }

    }
}
