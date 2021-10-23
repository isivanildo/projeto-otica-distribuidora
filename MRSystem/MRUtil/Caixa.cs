using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class Caixa
    {
        public int CodigoCaixa { get; set;}
        public int CaixaUsuario { get; set; }
        public DateTime DataCaixa { get; set; }
        public string Situacao { get; set; }
        public decimal ValorInicial { get; set; }
        public decimal ValorFinal { get; set; }
        public decimal ValorDinheiro { get; set; }
        public decimal ValorCredito { get; set; }
        public decimal ValorDebito { get; set; }
        public decimal Valorcheque { get; set; }
        public decimal ValorBoleto { get; set; }
        public decimal ValorOutros { get; set; }
        public int UsuarioAbertura { get; set; }
        public int UsuarioFechamento { get; set; }
        public int CodigoFilial { get; set; }

        private ConexaoDB connDB = new ConexaoDB();


        public Caixa() { }

        public void Novo()
        {
            CodigoCaixa = 0;
            CaixaUsuario = 0;
            DataCaixa = connDB.RetornaDataServidor();
            Situacao = "A";
            ValorInicial = 0;
            ValorFinal = 0;
            ValorDinheiro = 0;
            ValorCredito = 0;
            ValorDebito = 0;
            Valorcheque = 0;
            ValorBoleto = 0;
            ValorOutros = 0;
            UsuarioAbertura = 0;
            UsuarioFechamento = 0;
            CodigoFilial = 0;
        }

        public bool SalvaCaixa()
        {
            bool bResultado = false;

            int xCodigoCaixa = connDB.RetornaChave("cod_caixa", "caixa", "WHERE filial = " + CodigoFilial);

            string strSQL = "INSERT INTO caixa(cod_caixa, caixa, data_caixa, situacao, valor_inicial, valor_final, " +
                "valor_dinheiro, valor_credito, valor_debito, valor_cheque, valor_boleto, valor_outros, " +
                "usuario_abertura, usuario_fechamento, filial) VALUES(" + xCodigoCaixa + "," + CaixaUsuario + "," +
                Geral.DataSQL(DataCaixa.ToShortDateString()) + "," + Geral.AspasSQL(Situacao) + "," +
                Geral.ValorMoeda(ValorInicial) + "," + Geral.ValorMoeda(ValorFinal) + "," +
                Geral.ValorMoeda(ValorDinheiro) + "," + Geral.ValorMoeda(ValorCredito) + "," +
                Geral.ValorMoeda(ValorDebito) + "," + Geral.ValorMoeda(Valorcheque) + "," +
                Geral.ValorMoeda(ValorBoleto) + "," + Geral.ValorMoeda(ValorOutros) + "," + UsuarioAbertura + "," +
                UsuarioFechamento + "," + CodigoFilial + ")";

            if (connDB.SalvaAtualizaExcluiReg(strSQL))
            {
                bResultado = true;
            }

            return bResultado;
                
        }


    }
}
