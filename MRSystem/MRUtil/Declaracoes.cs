using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MRUtil
{
    public class Declaracoes
    {
        public static int iRetorno;

        #region Métodos NFCe

        // Metodo de Configuração NFCe
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regRetornarValor_NFCe_Daruma(string strPathChaveNFCe, StringBuilder StrValorRetornado);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regAlterarValor_NFCe_Daruma(string strPathChaveNFCe, string strValor);

        //Metodos de Emissão
        //Abertura de Venda
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFAbrir_NFCe_Daruma(string strCPF, string strNome, string strLgr, string strnro, string strBairro, string strcMun, string strMunicipio, string strUF, string strCEP);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFAbrirNumSerie_NFCe_Daruma(string strNNF, string strNSerie, string strCPF, string strNome, string strLgr, string strNro, string strBairro, string strcMun, string strMunicipio, string strUF, string strCEP);
        //Venda de Item
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFValorLeiImposto_NFCe_Daruma(string strValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfLeiImposto_NFCe_Daruma(string strNCM, string strEx, string strTipo, string strNacionalFed, string strImportadoFed, string strEstadual, string strMun);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfCombustivel_NFCe_Daruma(string strcProdANP, string strpMixGN, string strCODIF, string strqTemp, string strUFCons, string strqBCProd, string strvAliqProd, string strvCIDE, string strnBico, string strnBomba, string strnTanque, string strvEncInicial, string strvEncFinal, string strUsoFuturo);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFVender_NFCe_Daruma(string strCargaTributaria, string strQuantidade, string strPrecoUnitario, string strTipoDescAcresc, string strValorDescAcresc, string strCodigoItem, string strUnidadeMedida, string strDescricaoItem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFVenderCompleto_NFCe_Daruma(string strAliquota, string strQuantidade, string strPrecoUnitario, string strTipoDescAcresc, string strValorDescAcresc, string strCodigoItem, string strNCMm, string strCFOP, string strUnidadeMedida, string strDescricaoItem, string strUsoFuturo);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFVenderXml_NFCe_Daruma(string strXML);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFLancarAcrescimoItem_NFCe_Daruma(string strNumItem, string strTipoAcresc, string strValorAcresc);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFLancarDescontoItem_NFCe_Daruma(string strNumItem, string strTipoDesc, string strValorDesc);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFCancelarAcrescimoItem_NFCe_Daruma(string strNumItem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFCancelarDescontoItem_NFCe_Daruma(string strNumItem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFCancelarItemParcial_NFCe_Daruma(string strNumItem, string strQuant);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFCancelarItem_NFCe_Daruma(string strNumItem);
        //Configurar Impostos
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfImposto_NFCe_Daruma(string strNomeImposto, string strParametros);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfICMS00_NFCe_Daruma(string strOrig, string strCST, string strModBC, string strpICMS);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfICMS20_NFCe_Daruma(string strOrig, string strCST, string strModBC, string strpRedBC, string strpICMS);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfICMS40_NFCe_Daruma(string strOrig, string strCST, string strvICMSDeson, string strMotDesICMS);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfICMS60_NFCe_Daruma(string strOrig, string strCST, string strvBCSTRet, string strvICMSSTRet);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfICMS90_NFCe_Daruma(string strOrig, string strCST, string strModBC, string strpRedBC, string strpICMS, string strModBCST, string strpMVAST, string strpRedBCST, string strvBCST, string strpICMSST, string strvICMSDeson, string strmotDesICMS);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfICMSSN102_NFCe_Daruma(string strOrig, string strCSOSN);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfICMSSN500_NFCe_Daruma(string strOrig, string strCSOSN, string strvBCSTRet, string strvICMSSTRet);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfICMSSN900_NFCe_Daruma(string strOrig, string strCSOSN, string strmodBC, string strpRedBC, string strpICMS, string strmodBCST, string strpMVAST, string strpRedBCST, string strvBCST, string strpICMSST, string strvICMSST, string strpCredSN, string strvCredICMSSN);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfPisAliq_NFCe_Daruma(string strCST, string strpPIS);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfPisQtde_NFCe_Daruma(string strCST, string strvAliqProd);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfPisNT_NFCe_Daruma(string strCST);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfPisOutr_NFCe_Daruma(string strCST, string strpPIS, string strvAliqProd);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfCofinsAliq_NFCe_Daruma(string strCST, string strpCOFINS);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfCofinsQtde_NFCe_Daruma(string strCST, string strvAliqProd);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfCofinsNT_NFCe_Daruma(string strCST);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfCofinsOutr_NFCe_Daruma(string strCST, string strpCOFINS, string strvAliqProd);
        //Totalizacao de Venda
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFTotalizar_NFCe_Daruma(string strTipoDescAcresc, string strValorDescAcresc);
        //Pagamento da Venda
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFIdentificarCartao_NFCe_Daruma(string strCNPJ, string strBandeira, string strAutorizacao);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFEfetuarPagamento_NFCe_Daruma(string strFormaPgto, string strValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFEfetuarPagamentoCartao_NFCe_Daruma(string strTipoCartao, string strValorPgto, string strTipoIntegracao, string strCNPJCred, string strCodBandeira, string strAutorizacao, string strUsoFuturo);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFEstornarPagamento_NFCe_Daruma(string strNFormaPagtoEstornado, string strFormaPagtoEfetivado, string strValor);
        //Outros
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFIdentificarConsumidor_NFCe_Daruma(string strCPF, string strNome, string strLgr, string strNro, string strBairro, string strcMun, string strMunicipio, string strUF, string strCEP, string strEmail);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFIdentificarTransportadora_NFCe_Daruma(string strCPF_CNPJ, string strNome, string strIE, string strEndereco, string strMunicipio, string strUF);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFMsgPromocional_NFCe_Daruma(string strMsgPromocional, string strTextoLivre);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int aCFConfRastro_NFCe_Daruma(string strParametros);
        //Encerramento da Venda
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tCFEncerrar_NFCe_Daruma(string strMsgPromocional);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tCFEncerrarConfigMsg_NFCe_Daruma(string strMsgPromo, string strMsgFisco, string strUsoFuturo);
        //Descarte de Venda
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tCFCancelar_NFCe_Daruma(string strNNF, string strNSerie, string strChAcesso, string strProtAutorizacao, string strJustificativa);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tCFCancelarParametrizado_NFCe_Daruma(string strNNF, string strNSerie, string strChAcesso, string strProtAutorizacao, string strJustificativa, string strParametros);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tCFInutilizar_NFCe_Daruma(string strnNFInic, string strnNFFim, string strNSerie, string strJustificativa);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tDescartarNota_NFCe_Daruma(string strNF, string strSerie, string strOpcao);

        //Metodos de Impressão
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFImprimir_NFCe_Daruma(string strPathXMLVenda, string strPathRetornoWS, string strLinkQrCode, int iNumColunas, int iTipoNF);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFImprimirParametrizado_NFCe_Daruma(string strPathXMLVenda, string strPathRetornoWS, string strLinkQrCode, int iNumColunas, int iTipoNF, string strParametros);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iCFReImprimir_NFCe_Daruma(string strNNF, string strSerie, string strChaveAcesso);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iTEFImprimirResposta_NFCe_Daruma(string strPathNomeArquivo, int iNumeroVias, int iCorteEntreVias, int iTravarTeclado);

        //Metodos de Retorno e Status
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rLeituraX_NFCe_Daruma(string strData, string strSérie, string strTipoRetorno, StringBuilder StrRetorno);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rRecuperarXML_NFCe_Daruma(string strDataInicial, string strDataFinal, string strStatusNF, string strPathXML);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rRetornarInformacao_NFCe_Daruma(string strTipoIntervalo, string strInic, string strFim, string strSerie, string strChaveAcesso, string strInfoConsulta, StringBuilder StrResposta);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rRetornarInformacaoArq_NFCe_Daruma(string strTipoIntervalo, string strInic, string strFim, string strSerie, string strChaveAcesso, string strInfoConsulta, string strPathArqResposta);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rURLQrcode_NFCe_Daruma(StringBuilder StrRetornoUrl);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rAvisoErro_NFCe_Daruma(StringBuilder StrCodigo, StringBuilder StrMensagem);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rInfoEstendida_NFCe_Daruma(string strIndice, StringBuilder StrRetorno);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusWS_NFCe_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rStatusImpressora_NFCe_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rValidadeCertificado_NFCe_Daruma(StringBuilder StrDataVenc, StringBuilder StrDiasRestante);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rCFVerificarStatus_NFCe_Daruma();

        //Metodos Especiais
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eAtualizarEnviarXML_NFCe_Daruma(string strPathXML, string strParametros, string strEnviaXML);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eEmiteOffline_NFCe_Daruma(string strOpcao);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eAjustarDataHora_NFCe_Daruma();

        //Metodos de Contigencia Offline
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tCFCancelarOffline_NFCe_Daruma(string strNNF, string strNSerie, string strChAcesso, string strJustificativa);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tEnviarContingenciaOffline_NFCe_Daruma(int iQtdDocsContingencia);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tEnviarContingenciaCancOffline_NFCe_Daruma(int iQtdDocsCancContingencia);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tEnvioUnitContingenciaOffline_NFCe_Daruma(StringBuilder strCNPJEmit, StringBuilder strSerie, StringBuilder strnNF, StringBuilder strProtocolo, StringBuilder strChaveAcesso, StringBuilder strSitCodigo);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tEnvioUnitContingenciaCancOffline_NFCe_Daruma(StringBuilder strCNPJEmit, StringBuilder strSerie, StringBuilder strnNF, StringBuilder strProtocolo, StringBuilder strChaveAcesso, StringBuilder strSitCodigo);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rNumDocsContingencia_NFCe_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rNumDocsContingenciaCanc_NFCe_Daruma();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rRetornarInformacaoContingencia_NFCe_Daruma(string strChaveAcesso, string strNumNota, string strSerie, string strInfoConsulta, StringBuilder strRetorno);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int rUltimaCtg_NFCe_Daruma(StringBuilder strUltimaCtg, StringBuilder strTipoContingencia);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tEnvioUnitCtg_NFCe_Daruma(string strUltimaCtg, StringBuilder StrCNPJEmit, StringBuilder StrSerie, StringBuilder StrnNF, StringBuilder StrProtocolo, StringBuilder StrChaveAcesso, StringBuilder StrSitCodigo);

        //Metodos Impressora DUAL
        [DllImport("DarumaFrameWork.dll")]
        public static extern int iImprimirTexto_DUAL_DarumaFramework(string strTexto, int iTam);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int eBuscarPortaVelocidade_DUAL_DarumaFramework();
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regAlterarValor_Daruma(string strPathChave, string strValor);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int regRetornaValorChave_DarumaFramework(string strProduto, string strChave, StringBuilder StrValor);

        //NFe
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tEnviar_NFe_Daruma(string strDocumentos, string strParametros, int iQtdeDoc, int iTipoRetorno, StringBuilder StrRetorno);

        //TEF
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tTransacaoAdministrativaTEF_NFCe_Daruma(string strDocFiscal, string strTipoIdentificacaoCliente, string strIdentificacaoCliente, string strInfoAdicional, string strTaxaServico, string strTipoCartao, string strUsoFuturo);
        [DllImport("DarumaFrameWork.dll")]
        public static extern int tTransacaoCancelamentoTEF_NFCe_Daruma(string strDocFiscal, string strValorTotal, string strTipoIdentificacaoCliente, string strIdentificacaoCliente, string strNSU, string strRedeAdquirente, string strDataComprovante, string strHoraComprovante, string strInfoAdicional, string strTaxaServico, string strTipoCartao, string strUsoFuturo);

        #endregion

        #region Tratamento de Retorno

        /// <summary>
        /// Método responsavel por traduzir o retorno dos metodos da DFW, recebendo uma variavel inteira  
        /// com o retorno dometodo da DFW e retornando uma string com o significado do código.
        /// </summary>
        /// <param name="iRetMetodo"></param>
        /// <returns></returns>
        public static string TrataRetorno(int iRetMetodo)
        {
            string strRetorno = String.Empty;
            switch (iRetMetodo)
            {
                case 0:
                    strRetorno = "[0] - Não foi possível comunicar com a impressora não fiscal!";
                    break;
                case 1:
                    strRetorno = "[1] - Comando executado com sucesso!";
                    break;
                case -1:
                    strRetorno = "[-1] - Erro encontrado na execução do método!";
                    break;
                case -2:
                    strRetorno = "[-2] - Chave Inválida (Erro retornado pelo webservice)!";
                    break;
                case -3:
                    strRetorno = "[-3] - Falha no schema XML (Erro retornado pelo webservice)!";
                    break;
                case -4:
                    strRetorno = "[-4] - XML fora do padrão (Erro retornado pelo webservice)!";
                    break;
                case -5:
                    strRetorno = "[-5] - Erro genérico (Erro retornado pelo webservice)!";
                    break;
                case -6:
                    strRetorno = "[-6] - Nota já cadastrada na base de dados!";
                    break;
                case -8:
                    strRetorno = "[-8] - Usuário não Autorizado!";
                    break;
                case -9:
                    strRetorno = "[-9] - Usuário não Licenciado!";
                    break;
                case -10:
                    strRetorno = "[-10] - Documento e Ambiente não identificados!";
                    break;
                case -11:
                    strRetorno = "[-11] - Índice inexistente passado como parâmetro!";
                    break;
                case -12:
                    strRetorno = "[-12] - Pagamento informado não existe no cupom!";
                    break;
                case -13:
                    strRetorno = "[-13] - Tipo de Documento não identificado!";
                    break;
                case -14:
                    strRetorno = "[-14] -  Erro retornado pelo WebService!";
                    break;
                case -21:
                    strRetorno = "[-21] - Não existe acréscimo ou desconto a ser cancelado!";
                    break;
                case -30:
                    strRetorno = "[-30] - Lista não possui itens!";
                    break;
                case -31:
                    strRetorno = "[-31] - Quantidade informada não pode ser maior que a quantidade vendida!";
                    break;
                case -40:
                    strRetorno = "[-40] - Tag xml não encontrada!";
                    break;
                case -52:
                    strRetorno = "[-52] - Erro ao gravar em arquivo temporário!";
                    break;
                case -99:
                    strRetorno = "[-99] - Parâmetro inválido ou ponteiro nulo de parâmetro!";
                    break;
                case -100:
                    strRetorno = "[-100] - Estado do cupom inválido para execução o método!";
                    break;
                case -103:
                    strRetorno = "[-103] - Não foram encontradas as DLLs auxiliares (WS_Framework.dll e GNE_Framework.dll)!";
                    break;
                case -109:
                    strRetorno = "[-109] - Chave IDE\\indPres com preenchimento incorreto!";
                    break;
                case -120:
                    strRetorno = "[-120] - Encontrada tag inválida!";
                    break;
                case -121:
                    strRetorno = "[-121] - Estrutura Invalida!";
                    break;
                case -122:
                    strRetorno = "[-122] - Tag obrigatória não foi informada!";
                    break;
                case -123:
                    strRetorno = "[-123] - Tag obrigatória não tem valor preenchido!";
                    break;
                case -130:
                    strRetorno = "[-130] - NFCe ja aberta!";
                    break;
                case -131:
                    strRetorno = "[-131] - NFCe não aberta!";
                    break;
                case -132:
                    strRetorno = "[-132] - NFCe não em fase de venda!";
                    break;
                case -133:
                    strRetorno = "[-133] - NFCe não em fase de totalização!";
                    break;
                case -134:
                    strRetorno = "[-134] - NFCe não em fase de pagamento!";
                    break;
                case -135:
                    strRetorno = "[-135] - NFCe não em fase de encerramento!";
                    break;

                default:
                    strRetorno = "Erro desconhecido";
                    break;
            }

            return strRetorno;

        }
        #endregion

    }
}
