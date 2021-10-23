using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class Lancamentos
    {
        public int CodigoLancamento { get; set; }
        public int CodigoFilialLancamento { get; set; }
        public int CodigoFilial { get; set; }
        public DateTime DataLancamento { get; set; }
        public string CodigoConta { get; set; }
        public decimal ValorPago { get; set; }
        public int FormaPagamento { get; set; }
        public int NumeroParcela { get; set; }
        public int NumeroParcelas { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataRecebimento { get; set; }
        public string Historico { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public int StatusLancamento { get; set; }
        public int CodigoFatura { get; set; }
        public decimal Acrescimo { get; set; }
        public decimal Juros { get; set; }
        public decimal Desconto { get; set; }
        public decimal Taxas { get; set; }
        public int UsuarioLancamento { get; set; }
        public int UsuarioAlteracao { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoCredito { get; set; }

        ConexaoDB connDB = new ConexaoDB();

        public Lancamentos() { }

        public bool SalvaLancamento()
        {
            bool bResultado = false;
            int codigoLanc = connDB.RetornaChave("cod_lancamento", "lancamentos", "where id_filial_lancamento = " + CodigoFilialLancamento);

            string strSQL = "INSERT INTO lancamentos(cod_lancamento, id_filial_lancamento, id_filial, data_lancamento," +
                "cod_conta, valor_pago, cod_forma_pagamento, n_parcelas, n_parcela, data_vencimento, data_recebimento, " +
                "historico, doc, tipo, cod_status_lancamento, cod_fatura, acrescimo, juros, desconto, taxas, usuario_lanc, usuario_alt) " +
                "VALUES (" + codigoLanc + "," + CodigoFilialLancamento + "," + CodigoFilial + "," + 
                Geral.DataSQL(connDB.RetornaDataServidor().ToString()) + "," + CodigoConta + "," + Geral.ValorMoeda(ValorPago) + "," +
                FormaPagamento + "," + NumeroParcelas + "," + NumeroParcela + "," + 
                Geral.DataSQL(DataVencimento.ToString()) + "," + Geral.DataSQL(DataRecebimento.ToString()) + "," +
                Geral.AspasSQL(Historico) + "," + Geral.AspasSQL(Documento) + "," + Geral.AspasSQL(TipoDocumento) + "," + 
                StatusLancamento + "," + CodigoFatura + "," + Geral.ValorMoeda(Acrescimo) + "," + Geral.ValorMoeda(Juros) + "," + 
                Geral.ValorMoeda(Desconto) + "," + Geral.ValorMoeda(Taxas) + "," + UsuarioLancamento + "," + UsuarioAlteracao + ")";

            if (connDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                CodigoLancamento = codigoLanc;
                SalvaLancamentoCliente();
                bResultado = true;
            }

            return bResultado;
        }

        public void SalvaLancamentoCliente()
        {
            string strSQL = "INSERT INTO lancamentos_cliente(id_filial, cod_lancamento, cod_filial_cliente, cod_cliente) " +
                "VALUES (" + CodigoFilialLancamento + "," + CodigoLancamento + "," + CodigoFilial + "," + CodigoCliente + ")";

            connDB.SalvaAtualizaExcluiReg(strSQL);
        }

        public void SalvaPagamentoCredito()
        {
            int codigoPag = connDB.RetornaChave("cod_pagamento_credito", "pagamentos_credito", "where id_filial = " + CodigoFilialLancamento);

            string strSQL = "INSERT INTO pagamentos_credito(cod_pagamento_credito, cod_credito, id_filial, cod_cliente, cod_lancamento) " +
                "VALUES (" + codigoPag + "," + CodigoCredito  + ","  + CodigoFilialLancamento + "," + CodigoCliente + "," + CodigoLancamento + ")";

            connDB.SalvaAtualizaExcluiReg(strSQL);
        }

    }
}
