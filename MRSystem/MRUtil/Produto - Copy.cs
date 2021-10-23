using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class Produto2
    {
        ConexaoDB conn = new ConexaoDB();
        public int Codigo { get; set; }
        public string Grupo { get; set; }
        public int Marca { get; set; }
        public string Descricao { get; set; }
        public string Descricao_1 { get; set; }
        public string Descricao_2 { get; set; }
        public string Descricao_3 { get; set; }
        public string Unidade { get; set; }
        public string Cod_Barra { get; set; }
        public string Controlado { get; set; }
        public decimal E_Minimo { get; set; }
        public decimal E_Maximo { get; set; }
        public string C_Tributacao { get; set; }
        public decimal P_Entrega { get; set; }
        public decimal Venda { get; set; }
        public string Situacao { get; set; }
        public string Aplicacao { get; set; }
        public string D_Compra { get; set; }
        public decimal Compra { get; set; }
        public decimal V_Dolar { get; set; }
        public string Tamanho { get; set; }
        public string Cor { get; set; }
        public string Referencia { get; set; }
        public int Fornecedor { get; set; }
        public string Reajuste { get; set; }
        public string Tipo { get; set; }
        public decimal Custo { get; set; }
        public string Ativo { get; set; }
        public string Ult_Movimento { get; set; }
        public decimal Pontuacao { get; set; }
        public string Ult_Alteracao { get; set; }
        public int U_Ult_Alteracao { get; set; }
        public int U_Reajuste { get; set; }
        public string Disponibilidade { get; set; }
        public string Adicao { get; set; }
        public string IR { get; set; }
        public string Gravacao { get; set; }
        public string ACO_MIN { get; set; }
        public string Laboratorio { get; set; }
        public Int64 NCM { get; set; }
        public int Origem { get; set; }
        public int codigoTributacao { get; set; }
        public string GTIN { get; set; }

        public Produto2() {}

        public void SalvaProduto()
        {
            string strSQL = "";

            strSQL = "Insert into Produto_teste (Codigo, Grupo, Marca, Descricao, Descricao_1, Descricao_2, Descricao_3, Unidade, Cod_Barra, " +
                "Controlado, E_Minimo, E_Maximo, C_Tributacao, P_Entrega, Venda, Situacao, Aplicacao, D_Compra, Compra, V_Dolar, Tamanho, " +
                "Cor, Referencia, Fornecedor, Reajuste, Tipo, Custo, Ativo, Ult_Movimento, Pontuacao, Ult_Alteracao, U_Ult_Alteracao, U_Reajuste, " +
                "Disponibilidade, Adicao, IR, Gravacao, ACO_MIN, Laboratorio, NCM, Origem, CodigoTributacao,GTIN) VALUES (" +
                Codigo + ",'" + Grupo + "', " + cdin(Marca) + ", '" + Descricao + "', '" + Descricao_1 + "', '" + Descricao_2 + "', '" +
                Descricao_3 + "', '" + Unidade + "', '" + Cod_Barra + "', '" + Controlado + "', " + cdin(E_Minimo) + ", " + cdin(E_Maximo) + ", '" +
                C_Tributacao + "', " + cdin(P_Entrega) + ", " + cdin(Venda) + ", '" + Situacao + "', '" + Aplicacao + "', " + Pdt(D_Compra) + ", " +
                cdin(Compra) + ", " + cdin(V_Dolar) + ", '" + Tamanho + "', '" + Cor + "', '" + Referencia + "', " + cdin(Fornecedor) + ", " +
                Pdt(Reajuste) + ", '" + Tipo + "', " + cdin(Custo) + ", '" + Ativo + "', " + Pdt(Ult_Movimento) + ", " + cdin(Pontuacao) + ", " +
                Pdt(Ult_Alteracao) + ", " + cdin(U_Ult_Alteracao) + ", " + cdin(U_Reajuste) + ", '" + Disponibilidade + "', '" + Adicao + "', '" + IR + "', '" +
                Gravacao + "', '" + ACO_MIN + "', '" + Laboratorio + "', '" + NCM + "', '" + Origem + "', " + cdin(codigoTributacao) + ",'" + GTIN + "')";

            //conn.ConexaoDBAna();
            conn.SalvaAtualizaExcluiReg(strSQL);

        }

        public string cdin(object valor)
        {
            decimal dblValor;
            if (Convert.IsDBNull(valor))
            {
                return "0";
            }
            if (valor == null)
            {
                return "0";
            }
            if (string.IsNullOrEmpty(Convert.ToString(valor).Trim()))
            {
                return "0";
            }

            try
            {
                dblValor = Convert.ToDecimal(valor);
            }
            catch
            {
                return "NULL";
            }

            return dblValor.ToString().Replace(",", ".");
        }


        public string Pdt(object strValue)
        {
            string m = "";
            string d = "";
            string y = "";
            string dt;
            Boolean edata;
            if ((strValue == "00:00:00"))
            {
                return "NULL";
            }
            if ((strValue == null))
            {
                return "NULL";
            }
            if (((strValue.ToString().Trim() == "")
                        || (strValue.ToString().Trim() == "__/__/____")))
            {
                return "NULL";
            }
            edata = CheckDate(strValue.ToString());
            if (edata == false)
            {
                return "NULL";
            }

            else
            {

                if (strValue.ToString().Length >= 10)
                {

                    d = strValue.ToString().Substring(0, 2);
                    if ((d.Length == 1))
                    {
                        d = ("0" + d);
                    }
                    m = strValue.ToString().Substring(3, 2);
                    if ((m.Length == 1))
                    {
                        m = ("0" + m);
                    }
                    y = strValue.ToString().Substring(6, 4);
                }
                dt = (y + m + d);
                return "'" + dt + "'";

            }
        }

        protected bool CheckDate(String date)
        {
            try
            {
                DateTime dt = DateTime.Parse(date);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
