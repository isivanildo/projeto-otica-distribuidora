using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRUtil.Belemtech;

namespace MRUtil
{
    public class Pagamento : Lancamento
    {
        ConexaoDB Conexao = new ConexaoDB();
        public int CodigoPagamentoFatura { get; set; }
        public int CodigoFaturaCredito { get; set; }
        public string TipoPag { get; set; }

        public bool SalvaPagamento()
        {
            bool bResultado = false;
            int intChave;
            string strSQL = string.Empty;

            SalvaLancamento();

            if (TipoPag == "Fatura")
            {
                intChave = (int)Conexao.RetornaChave("cod_pagamento_fatura", "pagamentos_fatura", "where id_filial = " + CodigoFilial);
                strSQL = "insert into pagamentos_fatura(cod_pagamento_fatura,cod_fatura,id_filial,cod_lancamento,id_filial_lancamento) values(" + intChave + "," +
                    CodigoFatura + "," + CodigoFilial + "," + CodigoLancamento + "," + CodigoFilialLancamento + ")";

                if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
                {
                    
                    bResultado = true;
                }
            }
            else
            {
                intChave = (int)Conexao.RetornaChave("cod_pagamento_credito", "pagamentos_credito", "where id_filial = " + CodigoFilial);
                strSQL = "insert into pagamentos_credito (cod_pagamento_credito, cod_credito, id_filial, cod_lancamento) values(" + intChave + "," +
                    CodigoFaturaCredito + "," + CodigoFilial + CodigoLancamento + ")";

                if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
                {
                    bResultado = true;
                }
            }

            return bResultado;
        }


    }
}
