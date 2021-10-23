using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class NFe_Item
    {
        ConexaoDB conn = new ConexaoDB();
        public string Emitente { get; set; }
        public Int64 NumeroDocFiscal { get; set; }
        public int Serie { get; set; }
        public int Modelo { get; set; }
        public int Item { get; set; }
        public int ProdutoCodigo { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public string CFOP { get; set; }
        public string CST { get; set; }
        public int NCM { get; set;  }
        public string Origem { get; set; }
        public string Unidade { get; set; }
        public decimal PICMS { get; set; }
        public decimal BICMS { get; set; }
        public decimal VICMS { get; set; }
        public decimal PICMSSub { get; set; }
        public decimal BICMSSub { get; set; }
        public decimal VICMSSub { get; set; }
        public decimal PIPI { get; set; }
        public decimal BIPI { get; set; }
        public decimal VIPI { get; set; }
        public decimal PPIS { get; set; }
        public decimal BPIS { get; set; }
        public decimal VPIS { get; set; }
        public decimal PCOFINS { get; set; }
        public decimal BCOFINS { get; set; }
        public decimal VCOFINS { get; set; }
        public decimal PISS { get; set; }
        public decimal BISS { get; set; }
        public decimal VISS { get; set; }
        public decimal PReducao { get; set; }
        public decimal MargemST { get; set; }
        public decimal ReducaoST {get; set;}
        public decimal VImposto { get; set; }
        public decimal VDesconto { get; set; }
        public string CSTPIS { get; set; }
        public string CSTCOFINS { get; set; }
        public int? ModBC { get; set; }
        public int? ModBCST { get; set; }
        public int FlagIPI { get; set; }
        public int? CEST { get;set; }

        public NFe_Item() { }

        public void SalvaNFeItem()
        {
            string strSQL = "INSERT INTO NFe_Item(emitente, numero, serie, modelo, item, produto, " +
                "quantidade, v_unitario, cfop, cst, ncm, origem, unidade, p_icms, b_icms, v_icms, " +
                "p_substituicao" + "," + " b_substituicao, v_substituicao, p_ipi, b_ipi, v_ipi, p_pis, b_pis, " + 
                "v_pis, p_cofins, b_cofins, " + "v_cofins, p_iss, b_iss, v_iss, p_reducao, margem_st, " + 
                "reducao_st, v_impostos, v_desconto" + "," + " cst_pis, cst_cofins, modbc, modbcst, flagipi, cest) " +
                "VALUES (" +
                Geral.AspasSQL(Emitente) + "," + NumeroDocFiscal + "," + Serie + "," + Modelo + "," + Item + "," + 
                ProdutoCodigo + "," + Quantidade + "," + Geral.ValorMoeda(ValorUnitario) + "," + CFOP + "," +
                Geral.AspasSQL(CST) + "," + NCM + "," + Origem + "," + Geral.AspasSQL(Unidade) + "," + Geral.ValorMoeda(PICMS) + "," + 
                Geral.ValorMoeda(BICMS) + "," + Geral.ValorMoeda(VICMS) + "," + Geral.ValorMoeda(PICMSSub) + "," + 
                Geral.ValorMoeda(BICMSSub) + "," + Geral.ValorMoeda(VICMSSub) + "," + Geral.ValorMoeda(PIPI) + "," + 
                Geral.ValorMoeda(BIPI) + "," + Geral.ValorMoeda(VIPI) + "," + Geral.ValorMoeda(PPIS) + "," + 
                Geral.ValorMoeda(BPIS) + "," + Geral.ValorMoeda(VPIS) + "," + Geral.ValorMoeda(PCOFINS) + "," + 
                Geral.ValorMoeda(BCOFINS) + "," + Geral.ValorMoeda(VCOFINS) + "," + Geral.ValorMoeda(PISS) + "," + 
                Geral.ValorMoeda(BISS) + "," + Geral.ValorMoeda(VISS) + "," + Geral.ValorMoeda(PReducao) + "," + 
                Geral.ValorMoeda(MargemST) + "," + Geral.ValorMoeda(ReducaoST) + "," + 
                Geral.ValorMoeda(VImposto) + "," + Geral.ValorMoeda(VDesconto) + "," + Geral.AspasSQL(CSTPIS) + "," + 
                Geral.AspasSQL(CSTCOFINS) + "," + Geral.NumeroSQL(ModBC) + "," + Geral.NumeroSQL(ModBCST) + "," + 
                FlagIPI + "," + Geral.NumeroSQL(CEST) + ")";

            conn.SalvaAtualizaExcluiReg(strSQL);
        }

        public void AtualizaNFeItem()
        {
            string strSQL = "update NFe_Item set produto = " + ProdutoCodigo + "," + "quantidade = " + Quantidade + "," +
                "v_unitario = " + Geral.ValorMoeda(ValorUnitario) + "," + "cfop = " + CFOP + "," + "cst = " + Geral.AspasSQL(CST) + "," + "ncm = " + NCM + "," +
                "origem = " + Origem + "," + "unidade = " + Geral.AspasSQL(Unidade) + "," + "p_icms = " + Geral.ValorMoeda(PICMS) + "," +
                "b_icms = " + Geral.ValorMoeda(BICMS) + "," + "v_icms = " + Geral.ValorMoeda(VICMS) + "," +
                "p_substituicao = " + Geral.ValorMoeda(PICMSSub) + "," + "b_substituicao = " + Geral.ValorMoeda(BICMSSub) + "," +
                "v_substituicao = " + Geral.ValorMoeda(VICMSSub) + "," + "p_ipi = " + Geral.ValorMoeda(PIPI) + "," + "" +
                "b_ipi = " + Geral.ValorMoeda(BIPI) + "," + "v_ipi = " + Geral.ValorMoeda(VIPI) + "," + "p_pis = " + Geral.ValorMoeda(PPIS) + "," +
                "b_pis = " + Geral.ValorMoeda(BPIS) + "," + "v_pis = " + Geral.ValorMoeda(VPIS) + "," + "p_cofins = " + Geral.ValorMoeda(PCOFINS) + "," +
                "b_cofins = " + Geral.ValorMoeda(BCOFINS) + "," + "v_cofins = " + Geral.ValorMoeda(VCOFINS) + "," + "p_iss = " + Geral.ValorMoeda(PISS) + "," +
                "b_iss = " + Geral.ValorMoeda(BISS) + "," + "v_iss = " + Geral.ValorMoeda(VISS) + "," + "p_reducao = " + Geral.ValorMoeda(PReducao) + "," +
                "margem_st = " + Geral.ValorMoeda(MargemST) + "," + "reducao_st = " + Geral.ValorMoeda(ReducaoST) + "," +
                "v_impostos = " + Geral.ValorMoeda(VImposto) + "," + "v_desconto = " + Geral.ValorMoeda(VDesconto) + "," +
                "cst_pis = " + Geral.AspasSQL(CSTPIS) + "," + "cst_cofins = " + Geral.AspasSQL(CSTCOFINS) + "," + "modbc = " + Geral.NumeroSQL(ModBC) + "," +
                "modbcst = " + Geral.NumeroSQL(ModBCST) + "," + "flagipi = " + FlagIPI + "," +  "cest = " + Geral.NumeroSQL(CEST) + 
                " where emitente = " + Geral.AspasSQL(Emitente) + " and " + "numero = " + NumeroDocFiscal + " and serie = " + Serie + " and modelo = " + Modelo +
                " and item = " + Item;

            conn.SalvaAtualizaExcluiReg(strSQL);
        }

        public void ExcluirNFeItem()
        {
             string strSQL = "delete from nfe_item where emitente = " + Geral.AspasSQL(Emitente) + " and numero = " + NumeroDocFiscal +
                " and serie = " + Serie + " and modelo = " + Modelo;
            conn.SalvaAtualizaExcluiReg(strSQL);
        }
    }
}
