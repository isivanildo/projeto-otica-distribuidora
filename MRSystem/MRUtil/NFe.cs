using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MRUtil
{
    public class NFe
    {
        ConexaoDB conn = new ConexaoDB();
        DataTable tb = new DataTable();

        public string Emitente { get; set; }
        public int NumeroDocFiscal { get; set; }
        public int NaturezaOperacao { get; set; }
        public int Serie { get; set; }
        public int Modelo { get; set; }
        public int TipoNFe { get; set; }
        public DateTime? DataEmissao { get; set; }
        public int CodigoFilial { get; set; }
        public int CodigoCliente { get; set; }
        public int ConsumidorFinal { get; set; }
        public decimal BaseICMS { get; set; }
        public decimal ValorICMS { get; set; }
        public decimal BaseICMSSub { get; set; }
        public decimal ValorICMSSub { get; set; }
        public decimal ValorProdutos { get; set; }
        public decimal ValorServicos { get; set; }
        public decimal BaseISS { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValoIPI { get; set; }
        public decimal ValorPIS { get; set; }
        public decimal ValorCofins { get; set; }
        public decimal ValorISS { get; set; }
        public decimal ValorNota { get; set; }
        public string Observacao { get; set; }
        public string SituacaoNFe { get; set; }
        public DateTime? DataSaida { get; set; }
        public string ChaveNFe { get; set; }
        public string ProtocoloAutorizacao { get; set; }
        public DateTime? DataProtocoloAut { get; set; }
        public string Justificativa { get; set; }
        public string NFeAssinadaXml { get; set; }
        public string ProtocoloCancelamento { get; set; }
        public DateTime? DataProtocoloCancelamento { get; set; }
        public string ReferenciaChaveNFe { get; set; }
        public decimal ValorImpostos { get; set; }
        public int Frete { get; set; }
        public int InclusaoUsuario { get; set; }
        public int AlteracaoUsuario { get; set; }
        public string NFeCanceladaXml { get; set; }
        public int CanceladoUsuario { get; set; }
        public char TipoFatura { get; set; }
        public int DestinoOperacao { get; set; }
        public int ConsumidorPresente { get; set; }
        public int Documento { get; set; }
        public int FilialDocumento { get; set; }
        public int FilialCliente { get; set; }
        public string OrigemDoc {get; set;}
        public int FinaldiadeNota { get; set; }

        public NFe() { }

        public bool SalvaNFe()
        {
            bool resultado = false;

            string strSQL = "INSERT INTO NFe(emitente, numero, natoperacao, serie, modelo, tipoNFe, d_emissao, " +
                 "filial, cliente, consumidorfinal, situacao, destinooperacao, consumidorpresente, documento, filial_doc, filial_cliente, finalidadenota) VALUES (" +
                 Geral.AspasSQL(Emitente) + "," + NumeroDocFiscal + "," + NaturezaOperacao + "," + Serie + "," +
                 Modelo + "," + TipoNFe + "," + Geral.DataSQL(DataEmissao.ToString()) +"," + CodigoFilial + "," + CodigoCliente + "," + ConsumidorFinal + "," + Geral.AspasSQL(SituacaoNFe) + "," +
                 DestinoOperacao + "," + ConsumidorPresente + "," + Documento + "," + FilialDocumento + "," + FilialCliente + "," + FinaldiadeNota + ")";

            if (conn.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }

        public bool SalvaNFeDistribuidora()
        {
            bool resultado = false;

            string strSQL = "INSERT INTO NFe(emitente, numero, natoperacao, serie, modelo, tipoNFe, d_emissao, " +
                 "filial, cliente, consumidorfinal, situacao, destinooperacao, consumidorpresente, documento, origem_doc) VALUES (" +
                 Geral.AspasSQL(Emitente) + "," + NumeroDocFiscal + "," + NaturezaOperacao + "," + Serie + "," +
                 Modelo + "," + TipoNFe + "," + Geral.DataSQL(DataEmissao.ToString()) + "," + CodigoFilial + "," + CodigoCliente + "," + ConsumidorFinal + "," + Geral.AspasSQL(SituacaoNFe) + "," +
                 DestinoOperacao + "," + ConsumidorPresente + "," + Documento + "," + Geral.AspasSQL(OrigemDoc) + ")";

            if (conn.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }


        public bool AtualizaNFe()
        {
            bool resultado = false;
            string strSQL = "update NFe set natoperacao = " + NaturezaOperacao + "," + "tipoNFe = " + TipoNFe + "," + 
                "d_emissao = " + Geral.DataSQL(DataEmissao.ToString()) + "," + "filial = " + CodigoFilial + "," +
                "cliente = " + CodigoCliente + "," + "consumidorfinal = " + ConsumidorFinal + "," + "situacao = " + Geral.AspasSQL(SituacaoNFe) + "," +
                "destinooperacao = " + DestinoOperacao + "," + "consumidorpresente = " + ConsumidorPresente + "," +
                "documento = " + Documento + "," + "filial_doc = " + FilialDocumento + "," + "filial_cliente = " + FilialCliente + "," +
                "finalidadenota = " + FinaldiadeNota + " where emitente = " + Geral.AspasSQL(Emitente) + " and " +
                "numero = " + NumeroDocFiscal + " and serie = " + Serie + " and modelo = " + Modelo;

            if (conn.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }

        public void AtualizaNFeGerada()
        {
            string strSQL = "update NFe set b_icms = " + Geral.ValorMoeda(BaseICMS) + "," +
                "v_icms = " + Geral.ValorMoeda(ValorICMS) + "," + "b_icms_sub = " + Geral.ValorMoeda(BaseICMSSub) + "," +
                "v_icms_sub = " + Geral.ValorMoeda(ValorICMSSub) + "," + "v_produtos = " +
                Geral.ValorMoeda(ValorProdutos) + "," + "v_servicos = " + Geral.ValorMoeda(ValorServicos) + "," +
                "b_iss = " + Geral.ValorMoeda(BaseISS) + "," +
                "desconto = " + Geral.ValorMoeda(Desconto) + "," + "v_ipi = " + Geral.ValorMoeda(ValoIPI) + "," +
                "v_pis = " + Geral.ValorMoeda(ValorPIS) + "," + "v_cofins = " + Geral.ValorMoeda(ValorCofins) + "," +
                "iss = " + Geral.ValorMoeda(ValorISS) + "," + "valornota = " + Geral.ValorMoeda(ValorNota) + "," +
                "observacao = " + Geral.AspasSQL(Observacao) + "," + "situacao = " + Geral.AspasSQL(SituacaoNFe) + "," +
                "d_saida = " + Geral.DataSQL(DataSaida.ToString()) + "," + "chaveNFe = " + Geral.AspasSQL(ChaveNFe) + "," +
                "protocolo_aut = " + Geral.AspasSQL(ProtocoloAutorizacao) + "," +
                "d_protocoloaut = " + Geral.DataSQL(DataProtocoloAut.ToString()) + "," +
                "justificativa = " + Geral.AspasSQL(Justificativa) + "," + "NFeAssinadaXml = " + Geral.AspasSQL(NFeAssinadaXml) + "," +
                "protocolocancelamento = " + Geral.AspasSQL(ProtocoloCancelamento) + "," +
                "d_protocoloCancelamento = " + Geral.DataSQL(DataProtocoloCancelamento.ToString()) + "," +
                "referenciaNF = " + Geral.AspasSQL(ReferenciaChaveNFe) + "," +
                "v_impostos = " + Geral.ValorMoeda(ValorImpostos) + "," + "frete = " + Frete + "," +
                "inc_Usuario = " + InclusaoUsuario + "," + "alt_usuario = " + AlteracaoUsuario + "," +
                "NFeCanceladaXml = " + Geral.AspasSQL(NFeCanceladaXml) + "," + "can_usuario = " + CanceladoUsuario + "," +
                "tipo_fatura = " + Geral.AspasSQL(TipoFatura.ToString()) + "," + "destinooperacao = " + DestinoOperacao + "," +
                "consumidorpresente = " + ConsumidorPresente + "," + "finalidadenota = " + FinaldiadeNota + 
                " where emitente = " + Geral.AspasSQL(Emitente) + " and numero = " + NumeroDocFiscal +
                " and serie = " + Serie + " and modelo = " + Modelo;

            conn.SalvaAtualizaExcluiReg(strSQL);
        }

        public void AtualizaNFeEnviada()
        {
            string strSQL = "update NFe set d_emissao = " + Geral.DataSQL(DataEmissao.ToString()) + "," +
                "situacao = " + Geral.AspasSQL(SituacaoNFe) + "," + "d_saida = " + Geral.DataSQL(DataSaida.ToString()) + "," +
                "chavenfe = " + Geral.AspasSQL(ChaveNFe) + "," + "protocolo_aut = " + Geral.AspasSQL(ProtocoloAutorizacao) + "," +
                "d_protocoloaut = " + Geral.DataSQL(DataProtocoloAut.ToString()) + "," +
                "justificativa = " + Geral.AspasSQL(Justificativa) + "," +
                "NFeassinadaxml = " + Geral.AspasSQL(NFeAssinadaXml) +
                " where emitente = " + Geral.AspasSQL(Emitente) + " and numero = " + NumeroDocFiscal + " and serie = " + Serie + " and modelo = " + Modelo;

            conn.SalvaAtualizaExcluiReg(strSQL);
        }

        public void AtualizaNFeCancelada()
        {
            string strSQL = "update NFe set situacao = " + Geral.AspasSQL(SituacaoNFe) + "," + "protocolocancelamento = " + Geral.AspasSQL(ProtocoloCancelamento) + "," +
                "d_protocolocancelamento = " + Geral.DataSQL(DataProtocoloCancelamento.ToString()) + "," +
                "justificativa = " + Geral.AspasSQL(Justificativa) + "," +
                "NFecanceladaxml = " + Geral.AspasSQL(NFeCanceladaXml) + "," + "can_usuario = " + CanceladoUsuario +
                " where emitente = " + Geral.AspasSQL(Emitente) + " and numero = " + NumeroDocFiscal + " and serie = " + Serie + " and modelo = " + Modelo;

            conn.SalvaAtualizaExcluiReg(strSQL);
        }

        public void Registro(string xemitente, int xserie, int xmodelo, int xnumeroNota)
        {
            string strSQL = "select * from nfe where emitente = " + Geral.AspasSQL(xemitente) + " and numero = " + xnumeroNota +
                " and serie = " + xserie + " and modelo = " + xmodelo + "";

            conn.CarregaTabela(strSQL, ref tb);

            if (tb.Rows.Count > 0)
            {
                Emitente = tb.Rows[0]["emitente"].ToString();
                NumeroDocFiscal = Convert.ToInt32(tb.Rows[0]["numero"]);
                NaturezaOperacao = Convert.ToInt32(tb.Rows[0]["natoperacao"].ToString());
                Serie = Convert.ToInt32(tb.Rows[0]["serie"].ToString());
                Modelo = Convert.ToInt32(tb.Rows[0]["modelo"].ToString());
                TipoNFe = Convert.ToInt32(tb.Rows[0]["tipoNFe"].ToString());
                if (tb.Rows[0]["d_emissao"] != DBNull.Value)
                {
                    DataEmissao = Convert.ToDateTime(tb.Rows[0]["d_emissao"].ToString());
                }
                else
                {
                    DataEmissao = null;
                }
                CodigoFilial = Convert.ToInt32(tb.Rows[0]["filial"].ToString());
                CodigoCliente = Convert.ToInt32(tb.Rows[0]["cliente"].ToString());
                ConsumidorFinal = Convert.ToInt32(tb.Rows[0]["consumidorfinal"].ToString());
                BaseICMS = Convert.ToDecimal(tb.Rows[0]["b_icms"].ToString());
                ValorICMS = Convert.ToDecimal(tb.Rows[0]["v_icms"].ToString());
                BaseICMSSub = Convert.ToDecimal(tb.Rows[0]["b_icms_sub"].ToString());
                ValorICMSSub = Convert.ToDecimal(tb.Rows[0]["v_icms_sub"].ToString());
                ValorProdutos = Convert.ToDecimal(tb.Rows[0]["v_produtos"].ToString());
                ValorServicos = Convert.ToDecimal(tb.Rows[0]["v_servicos"].ToString());
                BaseISS = Convert.ToDecimal(tb.Rows[0]["b_iss"].ToString());
                Desconto = Convert.ToDecimal(tb.Rows[0]["desconto"].ToString());
                ValoIPI = Convert.ToDecimal(tb.Rows[0]["v_ipi"].ToString());
                ValorPIS = Convert.ToDecimal(tb.Rows[0]["v_pis"].ToString());
                ValorCofins = Convert.ToDecimal(tb.Rows[0]["v_cofins"].ToString());
                ValorISS = Convert.ToDecimal(tb.Rows[0]["iss"].ToString());
                ValorNota = Convert.ToDecimal(tb.Rows[0]["valornota"]);
                Observacao = tb.Rows[0]["observacao"].ToString();
                SituacaoNFe = tb.Rows[0]["situacao"].ToString();
                if (tb.Rows[0]["d_saida"] != DBNull.Value)
                {
                    DataSaida = Convert.ToDateTime(tb.Rows[0]["d_saida"].ToString());
                }
                else
                {
                    DataSaida = null;
                }
                ChaveNFe = tb.Rows[0]["chaveNFe"].ToString();
                ProtocoloAutorizacao = tb.Rows[0]["protocolo_aut"].ToString();
                if (tb.Rows[0]["d_protocoloaut"] != DBNull.Value)
                {
                    DataProtocoloAut = Convert.ToDateTime(tb.Rows[0]["d_protocoloaut"]);
                }
                else
                {
                    DataProtocoloAut = null;
                }
                Justificativa = tb.Rows[0]["justificativa"].ToString();
                NFeAssinadaXml = tb.Rows[0]["NFeAssinadaXml"].ToString();
                ProtocoloCancelamento = tb.Rows[0]["protocolocancelamento"].ToString();
                if (tb.Rows[0]["d_protocoloCancelamento"] != DBNull.Value)
                {
                    DataProtocoloCancelamento = Convert.ToDateTime(tb.Rows[0]["d_protocoloCancelamento"]);
                }
                else
                {
                    DataProtocoloCancelamento = null;
                }
                ReferenciaChaveNFe = tb.Rows[0]["referenciaNF"].ToString();
                ValorImpostos = Convert.ToDecimal(tb.Rows[0]["v_impostos"].ToString());
                Frete = Convert.ToInt32(tb.Rows[0]["frete"].ToString());
                InclusaoUsuario = Convert.ToInt32(tb.Rows[0]["inc_Usuario"].ToString());
                AlteracaoUsuario = Convert.ToInt32(tb.Rows[0]["alt_usuario"].ToString());
                NFeCanceladaXml = tb.Rows[0]["NFeCanceladaXml"].ToString();
                CanceladoUsuario = Convert.ToInt32(tb.Rows[0]["can_usuario"].ToString());
                TipoFatura = Convert.ToChar(tb.Rows[0]["tipo_fatura"].ToString());
                DestinoOperacao = Convert.ToInt32(tb.Rows[0]["destinooperacao"]);
                ConsumidorPresente = Convert.ToInt32(tb.Rows[0]["consumidorpresente"]);
                Documento = Convert.ToInt32(tb.Rows[0]["documento"]);
                FilialDocumento = Convert.ToInt32(tb.Rows[0]["filial_doc"]);
                FilialCliente = Convert.ToInt32(tb.Rows[0]["filial_cliente"]);
                FinaldiadeNota = Convert.ToInt32(tb.Rows[0]["finalidadenota"]);
            }
        }

    }

}

