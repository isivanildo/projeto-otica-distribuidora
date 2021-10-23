using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class BoletoLancamento : Pagamento
    {
        ConexaoDB Conexao = new ConexaoDB();
        public long Numero { get; set; }
        public long Doc { get; set; }
        public int Banco { get; set; }
        public int Emitente { get; set; }
        public string NossoNumeto { get; set; }
        public string Barra { get; set; }
        public string Digitavel { get; set; }
        public string TipoDocumento { get; set; }
        public decimal BoletoJuros { get; set; }
        public bool Manual { get; set; }
        public int DiasProtesto { get; set; }
        public string AcaoCobranca { get; set; }
        public string Enviado { get; set; }
        public DateTime DataEnvio { get; set; }

        public BoletoLancamento() { }

        public override void Novo()
        {
            Numero = 0;
            Doc = 0;
            Banco = 0;
            Emitente = 0;
            NossoNumeto = string.Empty;
            Barra = string.Empty;
            Digitavel = string.Empty;
            TipoDocumento = string.Empty;
            BoletoJuros = 0;
            Manual = false;
            DiasProtesto = 0;
            AcaoCobranca = string.Empty;
            Enviado = string.Empty;
            DataEnvio = DateTime.Now;
        }
        public bool SalvaBoleto()
        {
            bool bResutlado = false;
            string strSQL = string.Empty;

            if (SalvaPagamento() == true)
            {
                Numero = (int)Conexao.RetornaChave("numero", "boleto", "where id_filial = " + CodigoFilial);
                BoletoJuros = (Convert.ToDecimal(ValorPago) * (2 / 100)) / 30;

                strSQL = "insert into boleto (Numero, cod_lancamento, id_filial, Documento,Banco,Emitente, Nossonumero, Barra, Digitavel, tipo_documento, " +
                    "bol_juros, manual, acrescimo, diasprotesto, acaocobranca, usuario_inc, usuario_alt, enviado) values(" + Numero + "," + CodigoLancamento + "," +
                    CodigoFilial + "," + Doc + "," + Banco + "," + Emitente + "," + Geral.AspasSQL(NossoNumeto) + "," + Geral.AspasSQL(Barra) + "," +
                    Geral.AspasSQL(Digitavel) + "," + Geral.AspasSQL(TipoDocumento) + "," + Geral.ValorMoeda(BoletoJuros) + "," + Geral.AspasSQL(Manual.ToString()) + "," +
                    Geral.ValorMoeda(Acrescimo) + "," + DiasProtesto + "," + Geral.AspasSQL(AcaoCobranca) + "," + UsuarioLanc + "," + UsuarioAlt + "," +
                    Geral.AspasSQL(Enviado) + ")";

                if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
                {
                    bResutlado = true;
                }
            }

            return bResutlado;
        }




    }
}
