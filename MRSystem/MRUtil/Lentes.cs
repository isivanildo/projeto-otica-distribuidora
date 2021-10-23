using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class Lentes
    {
        ConexaoDB Conexao = new ConexaoDB();
        public int? CodigoLente { get; set; }
        public int? CodigoTabela { get; set; }
        public int? CodigoFamilia { get; set; }
        public int? CodigoFabricante { get; set; }
        public int? CodigoTipoLente { get; set; }
        public string NomeProduto { get; set; }
        public string NomeComercial { get; set; }
        public string Especie { get; set; }
        public decimal? EsfericoMaior { get; set; }
        public decimal? EsfericoMenor { get; set; }
        public decimal? CilindricoMenor { get; set; }
        public decimal? AdicaoMenor { get; set; }
        public decimal? AdicaoMaior { get; set; }
        public decimal? IR { get; set; }
        public int? ACOMinimo { get; set; }
        public int? ABBE { get; set; }
        public decimal? PrecoCusto { get; set; }
        public decimal? PrecoCompra { get; set; }
        public decimal? DescontoCompra { get; set; }
        public decimal? PrecoNota { get; set; }
        public decimal? PrecoVenda { get; set; }
        public decimal? DescontoVenda { get; set; }
        public decimal? PrecoTabela { get; set; }
        public string Caracteristicas { get; set; }
        public int? IdMaterial { get; set; }
        public decimal? Diametro { get; set; }
        public int? Ativo { get; set; }
        public string Disponibilidade { get; set; }
        public string AdicaoDisponivel { get; set; }
        public int? NCM { get; set; }
        public int? Tributacao { get; set; }
        public int? Origem { get; set; }
        public string Unidade { get; set; }
        public string GTIN { get; set; }
        public int? CEST { get; set; }
        public decimal? CMV { get; set; }
        public int? QtdeEntrada { get; set; }
        public int? QtdeEstoque { get; set; }
        public bool ControlaEstoque { get; set; }
        public string ParametroPesquisa { get; set; }

        public decimal DescontoPacote { get; set; } //Usado somente para aba de pacote no cadastro
        public decimal ValorComDesconto { get; set; } //Usado somente para aba de pacote no cadastro
        public decimal ValorTotalProduto { get; set; } //Usado somente para aba de pacote no cadastro
        public decimal QuantidadePacote { get; set; } //Usado somente para aba de pacote no cadastro
        public decimal TotalProdutoPacote { get; set; }


        public Lentes() { }

        public void Novo()
        {
            CodigoLente = null;
            CodigoTabela = null;
            CodigoFamilia = null;
            CodigoFabricante = null;
            CodigoTipoLente = null;
            NomeProduto = string.Empty;
            Especie = string.Empty;
            EsfericoMaior = null;
            EsfericoMenor = null;
            CilindricoMenor = null;
            AdicaoMenor = null;
            AdicaoMaior = null;
            IR = null;
            ACOMinimo = null;
            ABBE = null;
            PrecoCusto = 0;
            PrecoCompra = 0;
            DescontoCompra = 0;
            PrecoNota = 0;
            PrecoVenda = 0;
            DescontoVenda = 0;
            PrecoTabela = 0;
            Caracteristicas = string.Empty;
            IdMaterial = null;
            Diametro = null;
            Ativo = 0;
            Disponibilidade = string.Empty;
            AdicaoDisponivel = string.Empty;
            NCM = null;
            Tributacao = null;
            Origem = null;
            Unidade = string.Empty;
            GTIN = string.Empty;
            CEST = null;
            CMV = 0;
            QtdeEntrada = 0;
            QtdeEstoque = 0;
            ControlaEstoque = false;
        }

        public bool RetornaRegistro(long codigotabela)
        {
            bool bResultado = false;

            string strSQL = string.Empty;

            strSQL = "select lb.*, lt.nome_comercial from lentes_blocos lb inner join lentes_tabela lt on " + 
                "lb.cod_tabela = lt.cod_tabela where lb.cod_tabela = " + codigotabela;

            if (Conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, Conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.CodigoLente = dr.GetInt32OrNull("cod_lente");
                    this.CodigoTabela = dr.GetInt32OrNull("cod_tabela");
                    this.CodigoFamilia = dr.GetInt32OrNull("cod_familia");
                    this.CodigoFabricante = dr.GetInt32OrNull("id_fabricante");
                    this.CodigoTipoLente = dr.GetInt32OrNull("cod_tipo_lente");
                    this.NomeProduto = dr.GetStringOrEmpty("nome_lente");
                    this.NomeComercial = dr.GetStringOrEmpty("nome_comercial");
                    this.Especie = dr.GetStringOrEmpty("especie");

                    if (dr["esf_maior"] != DBNull.Value)
                    {
                        this.EsfericoMaior = Convert.ToDecimal(dr["esf_maior"]);
                    }
                    else
                    {
                        this.EsfericoMaior = null;
                    }

                    if (dr["esf_menor"] != DBNull.Value)
                    {
                        this.EsfericoMenor = Convert.ToDecimal(dr["esf_menor"]);
                    }
                    else
                    {
                        this.EsfericoMenor = null;
                    }

                    if (dr["cil_menor"] != DBNull.Value)
                    {
                        this.CilindricoMenor = Convert.ToDecimal(dr["cil_menor"]);
                    }
                    else
                    {
                        this.CilindricoMenor = null;
                    }

                    if (dr["adicao_menor"] != DBNull.Value)
                    {
                        this.AdicaoMenor = Convert.ToDecimal(dr["adicao_menor"]);
                    }
                    else
                    {
                        this.AdicaoMenor = null;
                    }
                    if (dr["adicao_maior"] != DBNull.Value)
                    {
                        this.AdicaoMaior = Convert.ToDecimal(dr["adicao_maior"]);
                    }
                    else
                    {
                        this.AdicaoMaior = null;
                    }

                    if (dr["ir"] != DBNull.Value)
                    {
                        this.IR = Convert.ToDecimal(dr["ir"]);
                    }
                    else
                    {
                        this.IR = null;
                    }

                    this.ACOMinimo = dr.GetInt32OrNull("aco_minimo");

                    if (dr["abbe"] != DBNull.Value)
                    {
                        this.ABBE = (int)dr["abbe"];
                    }
                    else
                    {
                        this.ABBE = null;
                    }

                    this.PrecoCusto = Convert.ToDecimal(dr["preco_custo"]);
                    this.PrecoCompra = Convert.ToDecimal(dr["preco_compra"]);
                    this.DescontoCompra = Convert.ToDecimal(dr["desconto_compra"]);
                    this.PrecoVenda = Convert.ToDecimal(dr["preco_venda"]);
                    this.DescontoVenda = Convert.ToDecimal(dr["desconto_venda"]);
                    if (dr["preco_nota"] != DBNull.Value)
                    {
                        this.PrecoNota = Convert.ToDecimal(dr["preco_nota"]);
                    }
                    else
                    {
                        this.PrecoNota = null;
                    }
                    if (dr["preco_tabela"] != DBNull.Value)
                    {
                        this.PrecoTabela = Convert.ToDecimal(dr["preco_tabela"]);
                    }
                    else
                    {
                        this.PrecoTabela = null;
                    }
                    this.Caracteristicas = dr.GetStringOrEmpty("caracteristicas");

                    this.IdMaterial = dr.GetInt32OrNull("id_material");

                    if (dr["diametro"] != DBNull.Value)
                    {
                        this.Diametro = Convert.ToDecimal(dr["diametro"]);
                    }
                    else
                    {
                        this.Diametro = null;
                    }

                    this.Ativo = dr.GetInt32OrNull("ativo");
                    this.Disponibilidade = dr.GetStringOrEmpty("disponibilidade");
                    this.AdicaoDisponivel = dr.GetStringOrEmpty("adicao");
                    if (dr["ncm"] != DBNull.Value)
                    {
                        this.NCM = Convert.ToInt32(dr["ncm"]);
                    }
                    else
                    {
                        this.NCM = null;
                    }
                    if (dr["tributacao"] != DBNull.Value)
                    {
                        this.Tributacao = Convert.ToInt32(dr["tributacao"]);
                    }
                    else
                    {
                        this.Tributacao = null;
                    }
                    if (dr["origem"] != DBNull.Value)
                    {
                        this.Origem = Convert.ToInt32(dr["origem"]);
                    }
                    else
                    {
                        this.Origem = null;
                    }
                    this.Unidade = dr.GetStringOrEmpty("unidade");
                    this.GTIN = dr.GetStringOrEmpty("gtin");
                    if (dr["cest"] != DBNull.Value)
                    {
                        this.CEST = (int)dr["cest"];
                    }
                    else
                    {
                        this.CEST = null;
                    }

                    if (dr["cmv"] != DBNull.Value)
                    {
                        this.CMV = Convert.ToDecimal(dr["cmv"]);
                    }
                    else
                    {
                        this.CMV = null;
                    }

                    if (dr["qtde_entrada"] != DBNull.Value)
                    {
                        this.QtdeEntrada = (int)dr["qtde_entrada"];
                    }
                    else
                    {
                        this.QtdeEntrada = null;
                    }

                    if (dr["qtde_estoque"] != DBNull.Value)
                    {
                        this.QtdeEstoque = (int)dr["qtde_estoque"];
                    }
                    else
                    {
                        this.QtdeEstoque = null;
                    }

                    if (dr["controla_estoque"] != DBNull.Value)
                    {
                        this.ControlaEstoque = Convert.ToBoolean(dr["controla_estoque"].ToString());
                    }
                    else
                    {
                        this.ControlaEstoque = false;
                    }

                    bResultado = true;

                }

                dr.NextResult();
                dr.Close();
            }

            return bResultado;
        }

        public void RetornaCodigoTabela(int xCodigoLente)
        {
            string strSQL = "select * from lentes_blocos where cod_lente = " + xCodigoLente;

            using(SqlConnection conn = new SqlConnection(Conexao.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            this.CodigoLente = dr.GetInt32OrNull("cod_lente");
                            this.CodigoTabela = dr.GetInt32OrNull("cod_tabela");
                            this.NomeProduto = dr["nome_lente"].ToString();
                            this.PrecoVenda = Convert.ToDecimal(dr["preco_venda"]);
                        }
                    }
                }
            }
 
        }
        public void SalvaLente()
        {
            string strSQL = string.Empty;

            strSQL = "insert into lentes_tabela(cod_tabela, id_fabricante, cod_tipo_lente, nome_comercial, especie) values(" +
                CodigoTabela + "," + CodigoFabricante + "," + CodigoTipoLente + "," + Geral.AspasSQL(NomeComercial) + "," + Geral.AspasSQL(Especie) + ")";

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                strSQL = "insert into lentes_blocos(cod_lente, cod_tabela, cod_familia, id_fabricante, cod_tipo_lente, nome_lente, especie, esf_maior, " +
                    "esf_menor, cil_menor, adicao_menor, adicao_maior, ir, aco_minimo, abbe, preco_custo, preco_compra, desconto_compra, preco_venda, " +
                    "desconto_venda, caracteristicas, id_material, diametro, ativo, disponibilidade, adicao, ncm, tributacao, origem, unidade, gtin, cest, " +
                    "cmv, qtde_entrada, qtde_estoque, preco_tabela, preco_nota, controla_estoque) values(" + CodigoLente + "," + CodigoTabela + "," +
                    Geral.NumeroSQL(CodigoFamilia) + "," + CodigoFabricante + "," + CodigoTipoLente + "," + Geral.AspasSQL(NomeProduto) + "," +
                    Geral.AspasSQL(Especie) + "," + Geral.ValorMoeda(EsfericoMaior) + "," + Geral.ValorMoeda(EsfericoMenor) + "," +
                    Geral.ValorMoeda(CilindricoMenor) + "," + Geral.ValorMoeda(AdicaoMenor) + "," + Geral.ValorMoeda(AdicaoMaior) + "," +
                    Geral.ValorMoeda(IR) + "," + Geral.NumeroSQL(ACOMinimo) + "," + Geral.NumeroSQL(ABBE) + "," + Geral.ValorMoeda(PrecoCusto) + "," +
                    Geral.ValorMoeda(PrecoCompra) + "," + Geral.ValorMoeda(DescontoCompra) + "," + Geral.ValorMoeda(PrecoVenda) + "," +
                    Geral.ValorMoeda(DescontoVenda) + "," + Geral.AspasSQL(Caracteristicas) + "," + Geral.NumeroSQL(IdMaterial) + "," +
                    Geral.ValorMoeda(Diametro) + "," + Ativo + "," + Geral.AspasSQL(Disponibilidade) + "," + Geral.AspasSQL(AdicaoDisponivel) + "," +
                    Geral.NumeroSQL(NCM) + "," + Geral.NumeroSQL(Tributacao) + "," + Geral.NumeroSQL(Origem) + "," + Geral.AspasSQL(Unidade) + "," +
                    Geral.AspasSQL(GTIN) + "," + Geral.NumeroSQL(CEST) + "," + Geral.ValorMoeda(CMV) + "," + Geral.NumeroSQL(QtdeEntrada) + "," +
                    Geral.NumeroSQL(QtdeEstoque) + "," + Geral.ValorMoeda(PrecoTabela) + "," + Geral.ValorMoeda(PrecoNota) + "," +
                    Geral.AspasSQL(ControlaEstoque.ToString()) + ")";

                Conexao.SalvaAtualizaExcluiReg(strSQL);
            }
        }

        public void AtualizaDadosLente()
        {
            string strSQL = string.Empty;

            strSQL = "update lentes_blocos set cod_familia = " + Geral.NumeroSQL(CodigoFamilia) + "," + "id_fabricante = " + CodigoFabricante + "," +
            "cod_tipo_lente = " + CodigoTipoLente + "," + "nome_lente = " + Geral.AspasSQL(NomeProduto) + "," + "especie = " + Geral.AspasSQL(Especie) + "," +
            "esf_maior = " + Geral.ValorMoeda(EsfericoMaior) + "," + "esf_menor = " + Geral.ValorMoeda(EsfericoMenor) + "," +
            "cil_menor = " + Geral.ValorMoeda(CilindricoMenor) + "," + "adicao_menor = " + Geral.ValorMoeda(AdicaoMenor) + "," +
            "adicao_maior = " + Geral.ValorMoeda(AdicaoMaior) + "," + "ir = " + Geral.ValorMoeda(IR) + "," + "aco_minimo = " + Geral.NumeroSQL(ACOMinimo) + "," +
            "abbe = " + Geral.NumeroSQL(ABBE) + "," + "preco_custo = " + Geral.ValorMoeda(PrecoCusto) + "," + "preco_compra = " + Geral.ValorMoeda(PrecoCompra) + "," +
            "desconto_compra = " + Geral.ValorMoeda(DescontoCompra) + "," + "preco_venda = " + Geral.ValorMoeda(PrecoVenda) + "," +
            "desconto_venda = " + Geral.ValorMoeda(DescontoVenda) + "," + "caracteristicas = " + Geral.AspasSQL(Caracteristicas) + "," +
            "id_material = " + Geral.NumeroSQL(IdMaterial) + "," + "diametro = " + Geral.ValorMoeda(Diametro) + "," + "ativo = " + Ativo + "," +
            "disponibilidade = " + Geral.AspasSQL(Disponibilidade) + "," + "adicao = " + Geral.AspasSQL(AdicaoDisponivel) + "," +
            "ncm = " + Geral.NumeroSQL(NCM) + "," + "tributacao = " + Geral.NumeroSQL(Tributacao) + "," + "origem = " + Geral.NumeroSQL(Origem) + "," +
            "unidade = " + Geral.AspasSQL(Unidade) + "," + "gtin = " + Geral.AspasSQL(GTIN) + "," + "cest = " + Geral.NumeroSQL(CEST) + "," +
            "cmv = " + Geral.ValorMoeda(CMV) + "," + "qtde_entrada = " + Geral.NumeroSQL(QtdeEntrada) + "," +
            "qtde_estoque = " + Geral.NumeroSQL(QtdeEstoque) + "," + "preco_tabela = " + Geral.ValorMoeda(PrecoTabela) + "," +
            "preco_nota = " + Geral.ValorMoeda(PrecoNota) + "," + "controla_estoque = " + Geral.AspasSQL(ControlaEstoque.ToString()) +
            " where cod_lente = " + CodigoLente + " and cod_tabela = " + CodigoTabela;

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                strSQL = "update lentes_tabela set id_fabricante = " + CodigoFabricante + "," + "cod_tipo_lente = " + CodigoTipoLente + "," +
                    "nome_comercial = " + Geral.AspasSQL(NomeComercial) + "," + "especie = " + Geral.AspasSQL(Especie) + " " +
                    "where cod_tabela = " + CodigoTabela;
                Conexao.SalvaAtualizaExcluiReg(strSQL);
            }
        }

        public string AtualizaDadosProdutos()
        {
            string strSQL = string.Empty;
            string resultado = string.Empty;
            decimal PrecoTabela = (decimal)(PrecoVenda - (PrecoVenda * DescontoVenda / 100));

            strSQL = "update produtos set unidade = " + Geral.AspasSQL(Unidade) + "," +
                "preco_venda = " + Geral.ValorMoeda(PrecoVenda) + "," + "desconto = " + Geral.ValorMoeda(DescontoVenda) + "," +
                "preco_tabela = " + Geral.ValorMoeda(PrecoTabela) + "," + "fator_preco = " + 1 + "," +
                "preco_compra = " + Geral.ValorMoeda(PrecoCompra) + "," + "desconto_compra = " + Geral.ValorMoeda(DescontoCompra) + "," +
                "ncm = " + NCM + "," + "tributacao = " + Geral.NumeroSQL(Tributacao) + "," +
                "produtos.origem = " + Geral.NumeroSQL(Origem) + "," + "produtos.gtin = " + Geral.AspasSQL(GTIN) + "," +
                "produtos.controla_estoque = " + Geral.AspasSQL(ControlaEstoque.ToString()) +
                " where cod_lente = " + CodigoLente;

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                strSQL = "select isnull(count(*), 0) as total from produtos where cod_lente = " + CodigoLente;
                DataTable tb = new DataTable();
                Conexao.CarregaTabela(strSQL, ref tb);

                if (tb.Rows.Count > 0)
                {
                    resultado = "Quantidade de registros atualizados: " + tb.Rows[0]["total"].ToString();
                }

            }

            return resultado;
        }

        private int VerificaCampos()
        {
            if (string.IsNullOrEmpty(CodigoLente.ToString()))
                return 1;
            if (string.IsNullOrEmpty(CodigoTabela.ToString()))
                return 2;
            if (string.IsNullOrEmpty(CodigoFabricante.ToString()))
                return 3;
            if (string.IsNullOrEmpty(CodigoTipoLente.ToString()))
                return 4;
            if (string.IsNullOrEmpty(NomeProduto))
                return 5;
            if (string.IsNullOrEmpty(IdMaterial.ToString()))
                return 6;
            if (string.IsNullOrEmpty(Especie))
                return 7;
            if (Especie != "AR")
            {
                if (string.IsNullOrEmpty(Diametro.ToString()))
                    return 8;
                if (string.IsNullOrEmpty(IR.ToString()))
                    return 9;
                if (string.IsNullOrEmpty(EsfericoMaior.ToString()))
                    return 10;
                if (string.IsNullOrEmpty(EsfericoMenor.ToString()))
                    return 11;
                if (string.IsNullOrEmpty(CilindricoMenor.ToString()))
                    return 12;
            }
            if (Especie == "B")
            {
                if (string.IsNullOrEmpty(AdicaoMaior.ToString()))
                    return 13;
                if (string.IsNullOrEmpty(AdicaoMenor.ToString()))
                    return 14;
            }
            if (string.IsNullOrEmpty(NCM.ToString()))
                return 15;
            if (string.IsNullOrEmpty(Tributacao.ToString()))
                return 16;
            if (string.IsNullOrEmpty(Origem.ToString()))
                return 17;
            if (string.IsNullOrEmpty(Unidade.ToString()))
                return 18;
            if (string.IsNullOrEmpty(GTIN.ToString()))
                return 19;
            if (string.IsNullOrEmpty(PrecoCompra.ToString()))
                return 20;
            if (string.IsNullOrEmpty(DescontoCompra.ToString()))
                return 21;
            if (string.IsNullOrEmpty(PrecoNota.ToString()))
                return 22;
            if (string.IsNullOrEmpty(PrecoVenda.ToString()))
                return 23;
            if (string.IsNullOrEmpty(DescontoVenda.ToString()))
                return 24;
            if (string.IsNullOrEmpty(PrecoTabela.ToString()))
                return 25;

            return 0;
        }

        public bool VerificaCampoObrigatorio()
        {
            bool resultado = false;
            switch (VerificaCampos())
            {
                case 1:
                    MessageBox.Show("Campo Código Lente é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 2:
                    MessageBox.Show("Campo Código Tabela é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 3:
                    MessageBox.Show("Campo Fabricante é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 4:
                    MessageBox.Show("Campo Tipo deLente é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 5:
                    MessageBox.Show("Campo Nome da Lente é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 6:
                    MessageBox.Show("Campo Tipo Material é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 7:
                    MessageBox.Show("Campo Espécie é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 8:
                    MessageBox.Show("Campo Diametro é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 9:
                    MessageBox.Show("Campo I.R é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 10:
                    MessageBox.Show("Campo Esférico Maior é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 11:
                    MessageBox.Show("Campo Esférico Menor é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 12:
                    MessageBox.Show("Campo Cilindrico Menor é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 13:
                    MessageBox.Show("Campo Adição Maior é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 14:
                    MessageBox.Show("Campo Adição Menor é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 15:
                    MessageBox.Show("Campo NCM é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 16:
                    MessageBox.Show("Campo Tributação é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 17:
                    MessageBox.Show("Campo Origem é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 18:
                    MessageBox.Show("Campo Unidade é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 19:
                    MessageBox.Show("Campo GTIN é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 20:
                    MessageBox.Show("Campo Preço Compra é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 21:
                    MessageBox.Show("Campo Desconto Compra é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 22:
                    MessageBox.Show("Campo Preço Nota é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 23:
                    MessageBox.Show("Campo Preço Venda é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 24:
                    MessageBox.Show("Campo Desconto Venda é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                case 25:
                    MessageBox.Show("Campo Preço Final é de preenchimento obrigatório!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
            }

            return resultado;

        }

        public decimal CalculaPrecoFinalItem()
        {
            ValorComDesconto = (decimal)(PrecoTabela) - ((decimal)PrecoTabela * (DescontoPacote / 100));

            ValorTotalProduto = ValorComDesconto * QuantidadePacote;

            return ValorTotalProduto;
        }

    }
}
