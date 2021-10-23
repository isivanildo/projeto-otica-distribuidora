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
    public class Cliente
    {
        ConexaoDB connDB = new ConexaoDB();

        public int CodigoCliente { get; set; }
        public int CodigoFilialCliente { get; set; }
        public string NomeCliente { get; set; }
        public string RazaoSocial { get; set; }
        public string CpfCnpj { get; set; }
        public string Ie { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string NomeCidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Observacao { get; set; }
        public decimal LimiteCompra { get; set; }
        public decimal LimiteCredito { get; set; }
        public decimal LimiteCheque { get; set; }
        public int? QtdeDiaPagar { get; set; }
        public bool SemDesconto { get; set; }
        public int CidadeIBGE { get; set; }
        public string Numero { get; set; }
        public string TelefoneNota { get; set; }
        public string Email { get; set; }
        public int CodigoTipoCliente { get; set; }
        public int TipoIE { get; set; }
        public int EstoquePreferencial { get; set; }
        public int InscricaoSuframa { get; set; }
        public bool Situacao { get; set; }
        public string TipoPessoa { get; set; }
        public string Rg { get; set; }
        public string TipoDocumento { get; set; } //Até aqui campo do banco
        public string UfIBGE { get; set; }
        public int PaisIBGE { get; set; }
        public string Pais { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public char Sexo { get; set; }
        public string InscMunicipal { get; set; }

        public string MensagemRetorno { get; private set; }

        public DataTable tb = new DataTable();
        public int intPonteiro = 0;
        public int intMax = 0;

        public Cliente() { }

        public void Novo()
        {
            CodigoCliente = 0;
            CodigoFilialCliente = 0;
            NomeCliente = string.Empty;
            RazaoSocial = string.Empty;
            CpfCnpj = string.Empty;
            Ie = string.Empty;
            Logradouro = string.Empty;
            Complemento = string.Empty;
            Bairro = string.Empty;
            NomeCidade = string.Empty;
            Uf = string.Empty;
            Cep = string.Empty;
            Telefone = string.Empty;
            Observacao = string.Empty;
            LimiteCompra = 0;
            LimiteCredito = 0;
            LimiteCheque = 0;
            QtdeDiaPagar = 0;
            SemDesconto = true;
            CidadeIBGE = 0;
            Numero = string.Empty;
            TelefoneNota = string.Empty;
            Email = string.Empty;
            CodigoTipoCliente = 0;
            TipoIE = 0;
            EstoquePreferencial = 0;
            InscricaoSuframa = 0;
            Situacao = false;
            TipoPessoa = string.Empty;
            Rg = string.Empty;
            TipoDocumento = string.Empty;
    }

        public bool RetornaCliente(int codigo)
        {
            bool bResultado = false;
            string strSQL = "select * from cliente where cod_cliente = " + codigo;

            using (SqlConnection conn = new SqlConnection(connDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                CodigoFilialCliente = Convert.ToInt32(dr["cod_filial_cliente"].ToString());
                                CodigoCliente = Convert.ToInt32(dr["cod_cliente"].ToString());
                                NomeCliente = dr.GetStringOrEmpty("nome_cliente");
                                RazaoSocial = dr.GetStringOrEmpty("razao_social");
                                CpfCnpj = dr.GetStringOrEmpty("cnpj");
                                Ie = dr.GetStringOrEmpty("ie");
                                Logradouro = dr.GetStringOrEmpty("endereco");
                                Complemento = dr.GetStringOrEmpty("complemento");
                                Bairro = dr.GetStringOrEmpty("bairro");
                                NomeCidade = dr.GetStringOrEmpty("municipio");
                                Uf = dr.GetStringOrEmpty("uf");
                                Cep = dr.GetStringOrEmpty("cep");
                                Telefone = dr.GetStringOrEmpty("fones");
                                Observacao = dr.GetStringOrEmpty("observacao");
                                LimiteCompra = Convert.ToDecimal(dr["limite_compra"]);
                                LimiteCredito = Convert.ToDecimal(dr["limite_credito"]);
                                LimiteCheque = Convert.ToDecimal(dr["limite_cheque"]);
                                QtdeDiaPagar = Convert.ToInt32(dr["qtd_dias_pagar"]);
                                SemDesconto = Convert.ToBoolean(dr["sem_desconto"].ToString());
                                CidadeIBGE = Convert.ToInt32(dr["codigo_cidade"]);
                                Numero = dr.GetStringOrEmpty("numero");
                                TelefoneNota = dr.GetStringOrEmpty("fone_nota");
                                Email = dr.GetStringOrEmpty("email");
                                CodigoTipoCliente = Convert.ToInt32(dr["cod_tipo_cliente"]);
                                TipoIE = Convert.ToInt32(dr["tipoinscricaoestadual"]);
                                EstoquePreferencial = Convert.ToInt32(dr["estoquepreferencial"]);
                                InscricaoSuframa = Convert.ToInt32(dr["insc_suframa"]);
                                Situacao = Convert.ToBoolean(dr["ativo"]);
                                TipoPessoa = dr.GetStringOrEmpty("tipo_pessoa");
                            }

                            bResultado = true;
                        }
                    }
                }
            }

            return bResultado;

        }

        public bool RetornaCliente(string xNome)
        {
            bool bResultado = false;
            string strSQL = "Select * from cliente where nome_cliente like '%" + xNome + "%' or razao_social like '%" + xNome + "%'";

            //Conexao.AbreConexaoBanco();

            using (var cmd = connDB.Conn.CreateCommand())
            {
                cmd.CommandText = strSQL;
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            CodigoFilialCliente = Convert.ToInt32(dr["cod_filial_cliente"].ToString());
                            CodigoCliente = Convert.ToInt32(dr["cod_cliente"].ToString());
                            NomeCliente = dr.GetStringOrEmpty("nome_cliente");
                            RazaoSocial = dr.GetStringOrEmpty("razao_social");
                            CpfCnpj = dr.GetStringOrEmpty("cnpj");
                            Ie = dr.GetStringOrEmpty("ie");
                            Logradouro = dr.GetStringOrEmpty("endereco");
                            Complemento = dr.GetStringOrEmpty("complemento");
                            Bairro = dr.GetStringOrEmpty("bairro");
                            NomeCidade = dr.GetStringOrEmpty("municipio");
                            Uf = dr.GetStringOrEmpty("uf");
                            Cep = dr.GetStringOrEmpty("cep");
                            Telefone = dr.GetStringOrEmpty("fones");
                            Observacao = dr.GetStringOrEmpty("observacao");
                            LimiteCompra = Convert.ToDecimal(dr["limite_compra"]);
                            LimiteCredito = Convert.ToDecimal(dr["limite_credito"]);
                            LimiteCheque = Convert.ToDecimal(dr["limite_cheque"]);
                            QtdeDiaPagar = Convert.ToInt32(dr["qtd_dias_pagar"]);
                            SemDesconto = Convert.ToBoolean(dr["sem_desconto"].ToString());
                            CidadeIBGE = Convert.ToInt32(dr["codigo_cidade"]);
                            Numero = dr.GetStringOrEmpty("numero");
                            TelefoneNota = dr.GetStringOrEmpty("fone_nota");
                            Email = dr.GetStringOrEmpty("email");
                            CodigoTipoCliente = Convert.ToInt32(dr["cod_tipo_cliente"]);
                            TipoIE = Convert.ToInt32(dr["tipoinscricaoestadual"]);
                            EstoquePreferencial = Convert.ToInt32(dr["estoquepreferencial"]);
                            InscricaoSuframa = Convert.ToInt32(dr["insc_suframa"]);
                            Situacao = Convert.ToBoolean(dr["ativo"]);
                            TipoPessoa = dr.GetStringOrEmpty("tipo_pessoa");
                        }

                        bResultado = true;
                    }
                }
            }


            return bResultado;

        }

        public bool RetornaRegistroNome(string xNome)
        {
            bool resultado = false;

            string strSQL = "Select * from cliente where nome_cliente like '%" + xNome + "%' or razao_social like '%" + xNome + "%'";

            tb = new DataTable();
            connDB.CarregaTabela(strSQL, ref tb);
            intMax = tb.Rows.Count;
            Primeiro();
            if (intMax > 0)
            {
                resultado = true;
            }

            return resultado;
        }
        public bool RetornaRegistroCodigo(int xCodigo)
        {
            bool bResultado = false;
            string strSQL = "select * from cliente where cod_cliente = " + xCodigo;

            tb = new DataTable();
            connDB.CarregaTabela(strSQL, ref tb);
            intMax = tb.Rows.Count;
            if (intMax > 0)
            {
                bResultado = true;
            }
            Primeiro();

            return bResultado;
        }

        public void Registro(int xPosicao)
        {
            int p = xPosicao;
            if (p <= 0) {p = 0; }

            if (p > intMax) { p = intMax; }

            intPonteiro = p;

            if (intMax > 0)
            {
                CodigoFilialCliente = Convert.ToInt32(tb.Rows[p]["cod_filial_cliente"].ToString());
                CodigoCliente = Convert.ToInt32(tb.Rows[p]["cod_cliente"].ToString());
                NomeCliente = tb.Rows[p]["nome_cliente"].ToString();
                RazaoSocial = tb.Rows[p]["razao_social"].ToString();
                CpfCnpj = tb.Rows[p]["cnpj"].ToString();
                Ie = tb.Rows[p]["ie"].ToString();
                Logradouro = tb.Rows[p]["endereco"].ToString();
                Complemento = tb.Rows[p]["complemento"].ToString();
                Bairro = tb.Rows[p]["bairro"].ToString();
                NomeCidade = tb.Rows[p]["municipio"].ToString();
                Uf = tb.Rows[p]["uf"].ToString();
                Cep = tb.Rows[p]["cep"].ToString();
                Telefone = tb.Rows[p]["fones"].ToString();
                Observacao = tb.Rows[p]["observacao"].ToString();
                LimiteCompra = Convert.ToDecimal(tb.Rows[p]["limite_compra"].ToString());
                LimiteCredito = Convert.ToDecimal(tb.Rows[p]["limite_credito"].ToString());
                LimiteCheque = Convert.ToDecimal(tb.Rows[p]["limite_cheque"].ToString());
                QtdeDiaPagar = Convert.ToInt32(tb.Rows[p]["qtd_dias_pagar"].ToString());
                SemDesconto = Convert.ToBoolean(tb.Rows[p]["sem_desconto"].ToString());
                CidadeIBGE = Convert.ToInt32(tb.Rows[p]["codigo_cidade"].ToString());
                Numero = tb.Rows[p]["numero"].ToString();
                TelefoneNota = tb.Rows[p]["fone_nota"].ToString();
                Email = tb.Rows[p]["email"].ToString();
                CodigoTipoCliente = Convert.ToInt32(tb.Rows[p]["cod_tipo_cliente"].ToString());
                TipoIE = Convert.ToInt32(tb.Rows[p]["tipoinscricaoestadual"].ToString());
                EstoquePreferencial = Convert.ToInt32(tb.Rows[p]["estoquepreferencial"].ToString());
                InscricaoSuframa = Convert.ToInt32(tb.Rows[p]["insc_suframa"].ToString());
                Situacao = Convert.ToBoolean(tb.Rows[p]["ativo"].ToString());
                TipoPessoa = tb.Rows[p]["tipo_pessoa"].ToString();
                Rg = tb.Rows[p]["rg"].ToString();
                TipoDocumento = tb.Rows[p]["tipodoc"].ToString();
            }
        }

        public bool SalvaCliente()
        {
            bool bResultado = false;

            int intCodigoCliente = connDB.RetornaChave("cod_cliente", "cliente", "");

            string strSQL = "insert into cliente(cod_filial_cliente, cod_cliente, nome_cliente, razao_social, cnpj, ie, endereco, complemento, bairro, municipio, " +
                "uf, cep, fones, observacao, limite_compra, limite_credito, limite_cheque, qtd_dias_pagar, sem_desconto, codigo_cidade, numero, " +
                "fone_nota, email, cod_tipo_cliente, tipoinscricaoestadual, estoquepreferencial, insc_suframa, ativo, tipo_pessoa, rg, tipodoc) " +
                "values(" + CodigoFilialCliente + "," + intCodigoCliente + "," + Geral.AspasSQL(NomeCliente) + "," + Geral.AspasSQL(RazaoSocial) + "," +
                Geral.AspasSQL(CpfCnpj) + "," + Geral.AspasSQL(Ie) + "," + Geral.AspasSQL(Logradouro) + "," + Geral.AspasSQL(Complemento) + "," +
                Geral.AspasSQL(Bairro) + "," + Geral.AspasSQL(NomeCidade) + "," + Geral.AspasSQL(Uf) + "," + Geral.AspasSQL(Cep) + "," + Geral.AspasSQL(Telefone) + "," +
                Geral.AspasSQL(Observacao) + "," + Geral.ValorMoeda(LimiteCompra) + "," + Geral.ValorMoeda(LimiteCredito) + "," +
                Geral.ValorMoeda(LimiteCheque) + "," + QtdeDiaPagar + "," + Geral.AspasSQL(SemDesconto.ToString()) + "," + CidadeIBGE + "," + Geral.AspasSQL(Numero) + "," + 
                Geral.AspasSQL(TelefoneNota) + "," + Geral.AspasSQL(Email) + "," + CodigoTipoCliente + "," + TipoIE + "," + EstoquePreferencial + "," + 
                InscricaoSuframa + "," + Geral.AspasSQL(Situacao.ToString()) + "," + Geral.AspasSQL(TipoPessoa) + "," + Geral.AspasSQL(Rg) + "," + 
                Geral.AspasSQL(TipoDocumento) + ")";

            if (connDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
                CodigoCliente = intCodigoCliente;
            }

            return bResultado;
        }

        public bool AtualizaCliente()
        {
            bool bResultado = false;

            string strSQL = "update cliente set nome_cliente = " + Geral.AspasSQL(NomeCliente) + "," + 
                "razao_social = " + Geral.AspasSQL(RazaoSocial) + "," + "cnpj = " + Geral.AspasSQL(CpfCnpj) + "," + 
                "ie = " + Geral.AspasSQL(Ie) + "," + "endereco = " + Geral.AspasSQL(Logradouro) + "," +
                "complemento = " + Geral.AspasSQL(Complemento) + "," + "bairro = " + Geral.AspasSQL(Bairro) + "," + 
                "municipio = " + Geral.AspasSQL(NomeCidade) + "," + "uf = " + Geral.AspasSQL(Uf) + "," + 
                "cep = " + Geral.AspasSQL(Cep) + "," + "fones = " + Geral.AspasSQL(Telefone) + "," +
                "observacao = " + Geral.AspasSQL(Observacao) + "," + "limite_compra = " + Geral.ValorMoeda(LimiteCompra) + "," + 
                "limite_credito = " + Geral.ValorMoeda(LimiteCredito) + "," + "limite_cheque = " + Geral.ValorMoeda(LimiteCheque) + "," +
                "qtd_dias_pagar = " + QtdeDiaPagar + "," + "sem_desconto = " + Geral.AspasSQL(SemDesconto.ToString()) + "," + 
                "codigo_cidade = " + CidadeIBGE + "," + "numero = " + Geral.AspasSQL(Numero) + "," + 
                "fone_nota = " + Geral.AspasSQL(TelefoneNota) + "," + "email = " + Geral.AspasSQL(Email) + "," + 
                "cod_tipo_cliente = " + CodigoTipoCliente + "," + "tipoinscricaoestadual = " + TipoIE + "," + 
                "estoquepreferencial = " + EstoquePreferencial + "," + "insc_suframa = " + InscricaoSuframa + "," + 
                "ativo = " + Geral.AspasSQL(Situacao.ToString()) + "," + "tipo_pessoa = " + Geral.AspasSQL(TipoPessoa) + "," + 
                "rg = " + Geral.AspasSQL(Rg) + "," + "tipodoc = " + Geral.AspasSQL(TipoDocumento) + 
                " where cod_filial_cliente = " + CodigoFilialCliente + " " +
                " and cod_cliente = " + CodigoCliente;

            if (connDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;
        }

        public bool ExcluirCliente()
        {
            bool bResultado = false;
            string strSQL = "delete from cliente where cod_cliente = " + CodigoCliente;

            if (connDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;

        }

        public decimal ResumoReceberTotalCliente()
        {
            decimal vValor = 0;

            string strSQL = "select sum((receber.Pedidos_nao_faturados +receber.Saldo_faturas + " +
                "receber.titulos_atraso + receber.titulos_a_vencer + receber.cheques_a_vencer)) as total_aberto from resumo_receber() as receber " +
                "where cod_cliente = " + CodigoCliente + " and cod_filial_cliente = " + CodigoFilialCliente;

            using (SqlConnection conn = new SqlConnection(connDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            vValor = Convert.ToDecimal(dr["total_aberto"].ToString());
                        }
                    }

                }
            }

            return vValor;
        }

        public decimal SaldoAnterior(int xCodigoCliente, int xCodigoFilialCliente)
        {
            decimal valor = 0;
            string strSQL = "SELECT SUM(credito) AS saldo FROM credito_cliente WHERE  cod_cliente = " + xCodigoCliente +
                " AND cod_filial_cliente = " + xCodigoFilialCliente;

            using (SqlConnection conn = new SqlConnection(connDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            valor = Convert.ToDecimal(dr["saldo"].ToString());
                        }
                    }
                }
            }

            return valor;

        }

        public DataTable ResumoReceberCliente(int xCodigoCliente, int xCodigoFilialCliente)
        {
            DataTable tt = new DataTable();
            string strSQL = "select round(receber.Pedidos_nao_faturados,2) as Pedidos, round(receber.Saldo_faturas,2) as Faturas_aberto, " +
                "round(receber.titulos_atraso,2) as titulos_atraso,round(receber.titulos_a_vencer,2) as titulos_vencer, " +
                "round((receber.titulos_atraso+receber.titulos_a_vencer),2) as titulos_aberto," +
                "round(receber.cheques_a_vencer,2) AS cheques_vencer ,round((receber.Pedidos_nao_faturados + receber.Saldo_faturas " +
                "+receber.titulos_atraso+receber.titulos_a_vencer+receber.cheques_a_vencer+receber.acordo_atrasado),2) " +
                "as total_aberto, round((receber.acordo_atrasado),2) as acordo_atrasado  from resumo_receber() as receber " +
                "where cod_cliente = " + xCodigoCliente + " and cod_filial_cliente = " + xCodigoFilialCliente;

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public DataTable RestricaoCliente(bool xTodas)
        {
            string strSQL = string.Empty;
            DataTable tt = new DataTable();

            strSQL = "SELECT restricoes_cliente.cod_restricao, restricoes_cliente.descricao, tipo_restricao.tipo_restricao,restricoes_cliente.data_inicio, " +
                "restricoes_cliente.data_fim, restricoes_cliente.cod_tipo_restricao FROM restricoes_cliente INNER JOIN tipo_restricao ON " +
                "restricoes_cliente.cod_tipo_restricao = tipo_restricao.cod_tipo_restricao where restricoes_cliente.cod_filial_cliente = " + CodigoFilialCliente +
                " and restricoes_cliente.cod_cliente = " + CodigoCliente;
            if (xTodas == false)
            {
                strSQL = strSQL + " and restricoes_cliente.data_fim is null ";
            }

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;

        }

        public DataTable FiltraPacoteCliente(int xCodigoCliente, int xCodigoFilialCliente, int xCodigoPacote)
        {
            DataTable tt = new DataTable();

            string strSQL = "SELECT pcd.cod_pacote, pcd.cod_cliente, pcd.cod_filial_cliente, pcd.item, " +
                "pcd.cod_produto, p.produto, pcd.preco_produto, pcd.desconto_produto, pcd.qtde_produto, " +
                "pcd.preco_final_produto, pcd.status_item, case when p.cod_lente IS NULL then p.produto " +
                "else (select lentes_blocos.nome_lente as nome from lentes_blocos where " +
                "cod_lente = pcd.cod_produto) end as descricao_prod, " +
                "(SELECT SUM(Contratada - Utilizado) AS saldo FROM saldos_pacotes(pcd.cod_produto, " +
                "pcd.cod_filial_cliente, pcd.cod_cliente) as saldos " +
                "where(cod_Pacote = pcd.cod_pacote)) as Saldo, pc.data from Pacote_cliente_detalhes pcd " +
                "inner join pacote_cliente pc on pcd.cod_Pacote = pc.cod_Pacote inner join produtos p " +
                "on pcd.cod_produto = p.cod_produto where pcd.cod_cliente = " + xCodigoCliente + 
                " and pcd.cod_filial_cliente = " + xCodigoFilialCliente + 
                " and pcd.cod_Pacote = " + xCodigoPacote + " order by item";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public void Primeiro()
        {
            this.Registro(0);
        }

        public void Proximo()
        {
            if (this.intPonteiro == this.intMax - 1)
                return;

            Registro(intPonteiro + 1);
        }

        public void Anterior()
        {
            Registro(intPonteiro - 1);
        }

        public void Ultimo()
        {
            Registro(intMax - 1);
        }

        public DataTable PedidoClienteFaturado(int xCodigoCliente, int xFilialCliente, bool xFaturado)
        {
            string strSQL = string.Empty;
            DataTable tt = new DataTable();
            string f;

            if (xFaturado == true)
            {
                f = " > 0 ";
            }
            else
            {
                f = " = 0 ";
            }

            strSQL = "SELECT cliente.cod_cliente,cliente.cod_filial_cliente,cliente.nome_cliente," + "pedido_balcao.id_filial, pedido_balcao.num_pedido, " +
                "(SELECT Left(OS,LEN(OS)-1)as delimited_list FROM (select CAST( (SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_os as varchar(10)) + ';' " +
                "FROM OS where (os.num_pedido = pedido_balcao.num_pedido and os.id_filial = pedido_balcao.id_filial and cod_fase <> 21) " +
                "for xml path ('')) as varchar(max)) as os) as temp ) as OS, pedido_balcao.data_pedido, pedido_balcao.cod_status_pedido, " +
                "status_pedido.Status_pedido, Usuarios.NOME,(SELECT count(item) as itens FROM fatura_itens WHERE (num_pedido =pedido_balcao.num_pedido) AND " +
                "(id_filial_pedido =pedido_balcao.id_filial)) as Faturado, isnull((SELECT sum(pedido_balcao_itens.quant * " +
                "(pedido_balcao_itens.preco - pedido_balcao_itens.preco * (pedido_balcao_itens.desconto / 100))) AS total  " +
                "FROM pedido_balcao_itens INNER JOIN produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " +
                "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND (pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0) " +
                "AS Produtos, isnull((SELECT sum(pedido_balcao_servicos.quant * (pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * " +
                "(pedido_balcao_servicos.desconto / 100))) AS total FROM pedido_balcao_servicos INNER JOIN produtos ON " +
                "pedido_balcao_servicos.cod_servico = produtos.cod_produto WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND " +
                "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0) as servicos, (isnull((SELECT sum(pedido_balcao_itens.quant * " +
                "(pedido_balcao_itens.preco - pedido_balcao_itens.preco * (pedido_balcao_itens.desconto / 100))) AS total FROM pedido_balcao_itens INNER JOIN " +
                "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND " +
                "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0) + isnull((SELECT sum(pedido_balcao_servicos.quant * " +
                "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * (pedido_balcao_servicos.desconto / 100))) AS total  " +
                "FROM pedido_balcao_servicos INNER JOIN produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " +
                "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND (pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0)) as Total " +
                ",(SELECT Left(item,LEN(item)-1)as delimited_list FROM (select CAST((SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_fatura as varchar(10)) + ';' " +
                "FROM fatura_itens where (fatura_itens.num_pedido = pedido_balcao.num_pedido And fatura_itens.id_filial_pedido = pedido_balcao.id_filial) " +
                "for xml path ('')) as varchar(max)) as item) as temp ) as n_fatura FROM pedido_balcao INNER JOIN status_pedido ON pedido_balcao.cod_status_pedido =  " +
                "status_pedido.cod_status_pedido INNER JOIN Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario " +
                "inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente and pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente " +
                "WHERE (pedido_balcao.cod_filial_cliente =" + CodigoFilialCliente + ") AND (pedido_balcao.cod_cliente = " + CodigoCliente + ")" +
                " and (SELECT count(item) as itens FROM fatura_itens WHERE (num_pedido =pedido_balcao.num_pedido) AND " +
                "(id_filial_pedido =pedido_balcao.id_filial)) " + f + " ORDER BY pedido_balcao.data_pedido Desc";
            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public DataTable PedidoClienteFaturado(int xCodigoCliente, int xFilialCliente, DateTime di, DateTime df, bool xFaturado)
        {
            string strSQL = string.Empty;
            DataTable tt = new DataTable();
            string f;

            if (xFaturado == true)
            {
                f = " > 0";
            }
            else
            {
                f = " = 0";
            }

            strSQL = "SELECT cliente.cod_cliente,cliente.cod_filial_cliente,cliente.nome_cliente, pedido_balcao.id_filial, pedido_balcao.num_pedido, " +
                "(SELECT Left(OS,LEN(OS)-1)as delimited_list FROM (select CAST((SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_os as varchar(10)) + ';' " +
                "FROM OS where (os.num_pedido = pedido_balcao.num_pedido and os.id_filial = pedido_balcao.id_filial and cod_fase <> 21) " +
                "for xml path ('')) as varchar(max)) as os) as temp ) as OS, pedido_balcao.data_pedido, pedido_balcao.cod_status_pedido, " +
                "status_pedido.Status_pedido, Usuarios.NOME, (SELECT count(item) as itens FROM fatura_itens WHERE (num_pedido =pedido_balcao.num_pedido) AND " +
                "(id_filial_pedido =pedido_balcao.id_filial)) as Faturado, isnull((SELECT sum(pedido_balcao_itens.quant * " +
                "(pedido_balcao_itens.preco - pedido_balcao_itens.preco * (pedido_balcao_itens.desconto / 100))) AS total FROM pedido_balcao_itens INNER JOIN " +
                "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND " +
                "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0) AS Produtos, isnull((SELECT sum(pedido_balcao_servicos.quant * " +
                "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * (pedido_balcao_servicos.desconto / 100))) AS total " +
                "FROM pedido_balcao_servicos INNER JOIN produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " +
                "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND " +
                "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0) as servicos, (isnull((SELECT sum(pedido_balcao_itens.quant * " +
                "(pedido_balcao_itens.preco - pedido_balcao_itens.preco * (pedido_balcao_itens.desconto / 100))) AS total FROM pedido_balcao_itens INNER JOIN " +
                "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND " +
                "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0) + isnull((SELECT sum(pedido_balcao_servicos.quant * " +
                "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * (pedido_balcao_servicos.desconto / 100))) AS total " +
                "FROM pedido_balcao_servicos INNER JOIN produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " +
                "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND (pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0)) " +
                "as Total, (SELECT Left(item,LEN(item)-1)as delimited_list FROM (select CAST((SELECT cast(id_filial as varchar(3)) + '-' + " +
                "cast(cod_fatura as varchar(10)) + ';' FROM fatura_itens " +
                "where (fatura_itens.num_pedido = pedido_balcao.num_pedido And fatura_itens.id_filial_pedido = pedido_balcao.id_filial) " +
                "for xml path ('')) as varchar(max)) as item ) as temp ) as n_fatura FROM pedido_balcao INNER JOIN " +
                "status_pedido ON pedido_balcao.cod_status_pedido =  status_pedido.cod_status_pedido INNER JOIN " +
                "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente " +
                "and pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente WHERE (pedido_balcao.cod_filial_cliente =" + CodigoFilialCliente + ") AND " +
                "(pedido_balcao.cod_cliente = " + CodigoCliente + ")" +
                " and (SELECT count(item) as itens FROM fatura_itens WHERE (num_pedido =pedido_balcao.num_pedido) AND " +
                "(id_filial_pedido =pedido_balcao.id_filial)) " +
                f + " and (pedido_balcao.data_pedido >= " + Geral.DataSQL(di.ToString()) +
                " and pedido_balcao.data_pedido <= " + Geral.DataSQL(df.ToString()) + ")" +
                " ORDER BY cliente.nome_cliente, pedido_balcao.data_pedido Desc";

           connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public DataTable PedidoClienteFaturado(int xCodigoCliente, int xFilialCliente, DateTime di, DateTime df)
        {
            string strSQL = string.Empty;
            DataTable tt = new DataTable();

            strSQL = "SELECT cliente.cod_cliente,cliente.cod_filial_cliente,cliente.nome_cliente, pedido_balcao.id_filial, pedido_balcao.num_pedido, " +
                "(SELECT Left(OS,LEN(OS)-1)as delimited_list FROM (select CAST((SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_os as varchar(10)) + ';' " +
                "FROM OS where (os.num_pedido = pedido_balcao.num_pedido and os.id_filial = pedido_balcao.id_filial and cod_fase <> 21) " +
                "for xml path ('')) as varchar(max)) as os) as temp ) as OS, pedido_balcao.data_pedido, pedido_balcao.cod_status_pedido, " +
                "status_pedido.Status_pedido, Usuarios.NOME, (SELECT count(item) as itens FROM fatura_itens WHERE (num_pedido =pedido_balcao.num_pedido) AND " +
                "(id_filial_pedido =pedido_balcao.id_filial)) as Faturado, isnull((SELECT sum(pedido_balcao_itens.quant * " +
                "(pedido_balcao_itens.preco - pedido_balcao_itens.preco * (pedido_balcao_itens.desconto / 100))) AS total FROM pedido_balcao_itens INNER JOIN " +
                "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND " +
                "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0) AS Produtos, isnull((SELECT sum(pedido_balcao_servicos.quant * " +
                "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * (pedido_balcao_servicos.desconto / 100))) AS total " +
                "FROM pedido_balcao_servicos INNER JOIN produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " +
                "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND " +
                "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0) as servicos, (isnull((SELECT sum(pedido_balcao_itens.quant * " +
                "(pedido_balcao_itens.preco - pedido_balcao_itens.preco * (pedido_balcao_itens.desconto / 100))) AS total FROM pedido_balcao_itens INNER JOIN " +
                "produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND " +
                "(pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0) + isnull((SELECT sum(pedido_balcao_servicos.quant * " +
                "(pedido_balcao_servicos.preco - pedido_balcao_servicos.preco * (pedido_balcao_servicos.desconto / 100))) AS total " +
                "FROM pedido_balcao_servicos INNER JOIN produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto " +
                "WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND (pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0)) " +
                "as Total, (SELECT Left(item,LEN(item)-1)as delimited_list FROM (select CAST((SELECT cast(id_filial as varchar(3)) + '-' + " +
                "cast(cod_fatura as varchar(10)) + ';' FROM fatura_itens " +
                "where (fatura_itens.num_pedido = pedido_balcao.num_pedido And fatura_itens.id_filial_pedido = pedido_balcao.id_filial) " +
                "for xml path ('')) as varchar(max)) as item ) as temp ) as n_fatura FROM pedido_balcao INNER JOIN " +
                "status_pedido ON pedido_balcao.cod_status_pedido =  status_pedido.cod_status_pedido INNER JOIN " +
                "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente " +
                "and pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente WHERE (pedido_balcao.cod_filial_cliente =" + CodigoFilialCliente + ") AND " +
                "(pedido_balcao.cod_cliente = " + CodigoCliente + ")" +
                " and (SELECT count(item) as itens FROM fatura_itens WHERE (num_pedido =pedido_balcao.num_pedido) AND " +
                "(id_filial_pedido =pedido_balcao.id_filial)) " +
                " and (pedido_balcao.data_pedido >= " + Geral.DataSQL(di.ToString()) +
                " and pedido_balcao.data_pedido <= " + Geral.DataSQL(df.ToString()) + ")" +
                " ORDER BY cliente.nome_cliente, pedido_balcao.data_pedido Desc";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;

        }

        public DataTable PedidosClientes()
        {
            string strSQL = string.Empty;
            DataTable tt = new DataTable();

            strSQL = "SELECT cliente.cod_cliente,cliente.cod_filial_cliente,cliente.nome_cliente, pedido_balcao.id_filial, pedido_balcao.num_pedido, " +
                "(SELECT Left(OS,LEN(OS)-1)as delimited_list FROM (select CAST((SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_os as varchar(10)) + ';' " +
                "FROM OS where (os.num_pedido = pedido_balcao.num_pedido and os.id_filial = pedido_balcao.id_filial and cod_fase <> 21) " +
                "for xml path ('')) as varchar(max)) as os) as temp ) as OS, pedido_balcao.data_pedido, pedido_balcao.cod_status_pedido, " +
                "status_pedido.Status_pedido, Usuarios.NOME, (SELECT count(item) as itens FROM fatura_itens WHERE (num_pedido =pedido_balcao.num_pedido) AND " +
                "(id_filial_pedido =pedido_balcao.id_filial)) as Faturado, isnull((SELECT sum(pedido_balcao_itens.quant * pedido_balcao_itens.preco) AS total " +
                "FROM pedido_balcao_itens INNER JOIN produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " +
                "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND (pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0) " +
                "AS Produtos, isnull((SELECT sum(pedido_balcao_servicos.quant * pedido_balcao_servicos.preco) AS total FROM pedido_balcao_servicos INNER JOIN " +
                "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND " +
                "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0) as servicos, (isnull((SELECT sum(pedido_balcao_itens.quant * " +
                "pedido_balcao_itens.preco) AS total FROM pedido_balcao_itens INNER JOIN produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " +
                "WHERE (pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido) AND (pedido_balcao_itens.id_filial = pedido_balcao.id_filial)),0) " +
                "+ isnull((SELECT sum(pedido_balcao_servicos.quant * pedido_balcao_servicos.preco) AS total FROM pedido_balcao_servicos INNER JOIN " +
                "produtos ON pedido_balcao_servicos.cod_servico = produtos.cod_produto WHERE (pedido_balcao_servicos.num_pedido = pedido_balcao.num_pedido) AND " +
                "(pedido_balcao_servicos.id_filial = pedido_balcao.id_filial)),0)) as Total,(SELECT Left(item,LEN(item)-1)as delimited_list FROM ( " +
                "select CAST((SELECT cast(id_filial as varchar(3)) + '-' + cast(cod_fatura as varchar(10)) + ';' FROM fatura_itens " +
                "where (fatura_itens.num_pedido = pedido_balcao.num_pedido And fatura_itens.id_filial_pedido = pedido_balcao.id_filial) " +
                "for xml path ('')) as varchar(max)) as item) as temp ) as n_fatura FROM pedido_balcao INNER JOIN " +
                "status_pedido ON pedido_balcao.cod_status_pedido = status_pedido.cod_status_pedido INNER JOIN " +
                "Usuarios ON pedido_balcao.cod_vendedor = Usuarios.cod_usuario inner join cliente on pedido_balcao.cod_cliente = cliente.cod_cliente and " +
                "pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente WHERE (pedido_balcao.cod_filial_cliente =" + CodigoFilialCliente + ") AND " +
                "(pedido_balcao.cod_cliente = " + CodigoCliente + ")" +
                " and dateadd(DAY ,30,pedido_balcao.data_pedido ) > " + Geral.DataSQL(DateTime.Now.ToString()) + " ORDER BY pedido_balcao.data_pedido Desc";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;

        }

        public DataTable FaturasCliente()
        {
            string strSQL = string.Empty;
            DataTable tt = new DataTable();

            strSQL = "SELECT faturas_cliente.* FROM faturas_cliente() AS faturas_cliente WHERE cod_filial_cliente = " + CodigoFilialCliente + " AND " +
                "cod_cliente = " + CodigoCliente + " ORDER BY data_lancamento DESC";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public DataTable FaturasCliente(DateTime di, DateTime df)
        {
            string strSQL = string.Empty;
            DataTable tt = new DataTable();

            strSQL = "SELECT faturas_cliente.* FROM faturas_cliente() AS faturas_cliente WHERE cod_filial_cliente = " + CodigoFilialCliente + " AND " +
                "cod_cliente = " + CodigoCliente + " and data_lancamento >= " + Geral.DataSQL(di.ToString()) +
                " and data_lancamento <= " + Geral.DataSQL(df.ToString()) + " ORDER BY data_lancamento DESC";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public decimal SaldoFaturasClienteApagar()
        {
            string strSQL = string.Empty;
            DataTable tt = new DataTable();

            strSQL = "SELECT isnull(SUM(saldo),0) AS Saldo FROM  faturas_cliente() AS faturas_cliente where (cod_cliente = " + CodigoCliente + ") " +
                "and cod_filial_cliente = " + CodigoFilialCliente + " and saldo < 0";

            connDB.CarregaTabela(strSQL, ref tt);

            return Convert.ToDecimal(tt.Rows[0][0]);
        }

        public decimal SaldoFaturasClienteAreceber()
        {
            string strSQL = string.Empty;
            DataTable tt = new DataTable();

            strSQL = "SELECT isnull(SUM(saldo),0) AS Saldo FROM  faturas_cliente() AS faturas_cliente where cod_cliente = (" + CodigoCliente + ") " +
                "and (cod_filial_cliente = " + CodigoFilialCliente + ") and saldo > 0";

            connDB.CarregaTabela(strSQL, ref tt);

            return Convert.ToDecimal(tt.Rows[0][0]);
        }

        public DataTable OSCliente()
        {
            string strSQL = string.Empty;
            DataTable tt = new DataTable();

            strSQL = "SELECT OS.cod_os, OS.id_filial, fases_OS.fase, os.observacao FROM OS INNER JOIN fases_OS ON OS.cod_fase = fases_OS.cod_fase where " +
                "os.cod_filial_cliente = " + CodigoFilialCliente + " and cod_cliente = " + CodigoCliente +
                " and dateadd(DAY ,30,os.data_previsao_entrega ) > " + Geral.DataSQL(DateTime.Now.ToString()) + " order by cod_os desc";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public DataTable OSCliente(DateTime dIni, DateTime dFim)
        {
            string strSQL = string.Empty;
            DataTable tt = new DataTable();

            strSQL = "SELECT OS.cod_os, OS.id_filial, fases_OS.fase, os.observacao FROM OS INNER JOIN fases_OS ON OS.cod_fase = fases_OS.cod_fase where " +
                "os.cod_filial_cliente = " + CodigoFilialCliente + " and cod_cliente = " + CodigoCliente +
                " and os.data_previsao_entrega >= " + Geral.DataSQL(dIni.ToString()) + " and os.data_previsao_entrega <= " +
                Geral.DataSQL(dFim.ToString()) + " order by cod_os desc";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public DataTable TitulosCliente()
        {
            string strSQL = string.Empty;
            DataTable tt = new DataTable();

            strSQL = "SELECT substring(boleto.Nossonumero,0,18) as nossonumero, boleto.tipo_documento, lancamentos.data_lancamento," +
                "boleto.documento,(lancamentos.Valor_pago+lancamentos.acrescimo+lancamentos.juros-lancamentos.desconto+lancamentos.taxas) + " +
                "ISNULL((Pagamentos_acordo.acrescimo + Pagamentos_acordo.juros + Pagamentos_acordo.taxas - Pagamentos_acordo.desconto),0) as Valor," +
                "lancamentos.data_vencimento, lancamentos.data_recebimento, boleto.cod_lancamento, boleto.id_filial,lancamentos.id_filial_lancamento " +
                "FROM boleto INNER JOIN lancamentos ON boleto.cod_lancamento = lancamentos.cod_lancamento AND boleto.id_filial = lancamentos.id_filial " +
                "inner join lancamentos_cliente on lancamentos.id_filial = lancamentos_cliente.id_filial and lancamentos.cod_lancamento = " +
                "lancamentos_cliente.cod_lancamento LEFT JOIN Pagamentos_acordo ON Pagamentos_acordo.cod_lancamento = lancamentos.cod_lancamento and " +
                "Pagamentos_acordo.id_filial = lancamentos.id_filial where lancamentos_cliente.cod_filial_cliente = " + CodigoFilialCliente +
                " and lancamentos_cliente.cod_cliente = " + CodigoCliente + " and lancamentos.cod_status_lancamento = 1 order by data_recebimento, data_vencimento";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public decimal TitulosAtrasoClienteTotal()
        {
            string strSQL = string.Empty;
            decimal vValor = 0;
            DataTable tt = new DataTable();

            strSQL = "SELECT sum(Valor)  from Titulos_aberto() as titulos_aberto where cod_cliente = " + CodigoCliente +
                " and cod_filial_cliente = " + CodigoFilialCliente + " and dateadd(day,0,data_vencimento) < " +
                Geral.DataSQL(DateTime.Now.ToString()) + " and data_recebimento is null";

            connDB.CarregaTabela(strSQL, ref tt);

            if (tt.Rows[0][0] != DBNull.Value)
            {
                vValor = Convert.ToDecimal(tt.Rows[0][0]);
            }
            else
            {
                vValor = 0;
            }

            return vValor;
        }

        public decimal TitulosClientePendenteTotalSemAtraso()
        {
            string strSQL = string.Empty;
            decimal vValor = 0;
            DataTable tt = new DataTable();

            strSQL = "SELECT sum(lancamentos.Valor_pago+ISNULL(pagamentos_acordo.acrescimo+pagamentos_acordo.juros+" +
                "pagamentos_acordo.taxas-pagamentos_acordo.desconto,0)) as valor FROM lancamentos left JOIN lancamentos_cliente ON lancamentos.cod_lancamento = " +
                "lancamentos_cliente.cod_lancamento AND lancamentos.id_filial = lancamentos_cliente.id_filial left JOIN cliente ON " +
                "lancamentos_cliente.cod_filial_cliente = cliente.cod_filial_cliente and lancamentos_cliente.cod_cliente = cliente.cod_cliente " +
                "left join forma_pagamento on forma_pagamento.cod_forma_pagamento = lancamentos.cod_forma_pagamento left join boleto on boleto.cod_lancamento = " +
                "lancamentos.cod_lancamento and boleto.id_filial = lancamentos.id_filial " +
                "left join Pagamentos_acordo on Pagamentos_acordo.cod_lancamento = lancamentos.cod_lancamento and Pagamentos_acordo.id_filial = lancamentos.id_filial " +
                "where lancamentos.data_recebimento is null and lancamentos.cod_status_lancamento <> 2 and lancamentos_cliente.cod_cliente = " + CodigoCliente +
                " and lancamentos_cliente.cod_filial_cliente = " + CodigoFilialCliente +
                " and lancamentos.data_vencimento >= " + Geral.DataSQL(DateTime.Now.ToString());

            connDB.CarregaTabela(strSQL, ref tt);

            if (tt.Rows[0][0] != DBNull.Value)
            {
                vValor = Convert.ToDecimal(tt.Rows[0][0]);
            }
            else
            {
                vValor = 0;
            }

            return vValor;
        }

        public DataTable ChequesCliente()
        {
            string strSQL = string.Empty;
            DataTable tt = new DataTable();

            strSQL = "SELECT bancos.banco, cheques.agencia, cheques.conta, cheques.cheque, cheques.acrescimo, lancamentos.Valor, lancamentos.data_vencimento, " +
                "lancamentos.data_recebimento, lancamentos.n_parcela, lancamentos.n_parcelas FROM cheques INNER JOIN lancamentos ON cheques.cod_lancamento = " +
                "lancamentos.cod_lancamento AND cheques.id_filial = lancamentos.id_filial INNER JOIN lancamentos_cliente ON " +
                "lancamentos.cod_lancamento = lancamentos_cliente.cod_lancamento AND lancamentos.id_filial = lancamentos_cliente.id_filial INNER JOIN " +
                "bancos ON cheques.cod_banco = bancos.cod_banco where lancamentos_cliente.cod_filial_cliente = " + CodigoFilialCliente +
                " and lancamentos_cliente.cod_cliente = " + CodigoCliente + " order by data_vencimento DESC";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public DataTable ResumoReceberCliente()
        {
            string strSQL = string.Empty;
            DataTable tt = new DataTable();

            strSQL = "select round(receber.Pedidos_nao_faturados,2) as Pedidos, round(receber.Saldo_faturas,2) as Faturas_aberto, " +
                "round(receber.titulos_atraso,2) as titulos_atraso,round(receber.titulos_a_vencer,2) as titulos_vencer, " +
                "round((receber.titulos_atraso+receber.titulos_a_vencer),2) as titulos_aberto," +
                "round(receber.cheques_a_vencer,2) AS cheques_vencer ,round((receber.Pedidos_nao_faturados + receber.Saldo_faturas " +
                "+receber.titulos_atraso+receber.titulos_a_vencer+receber.cheques_a_vencer+receber.acordo_atrasado),2) " +
                "as total_aberto, round((receber.acordo_atrasado),2) as acordo_atrasado  from resumo_receber() as receber " +
                "where cod_cliente = " + CodigoCliente + " and cod_filial_cliente = " + CodigoFilialCliente;

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public decimal TotalPacote(int xCodigoCliente, int xCodigoFilialCliente, int xCodigoPacote)
        {
            decimal valor = 0;

            string strSQL = "select isnull(SUM(preco_desc* quantidade_contratada),0) +ISNULL(SUM(preco_surf_desc * quantidade_surf), 0) + " +
                "ISNULL(sum(preco_mont_desc * quantidade_mont),0) + isnull(SUM(preco_trat_desc * quantidade_trat),0) as total_pacote " +
                "from Pacote_cliente_detalhes where cod_pacote = " + xCodigoPacote + " And cod_cliente = " + xCodigoCliente +
                " And cod_filial_cliente = " + xCodigoFilialCliente;

            using (SqlConnection conn = new SqlConnection(connDB.stringConexao))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            valor = Convert.ToDecimal(reader["total_pacote"]);
                        }
                    }
                }

            }
                return valor;
        }

        public DataTable ListaPacotes(int xCodigoCliente, int xCodigoFilialCliente)
        {
            DataTable tt = new DataTable();
            string strSQL = "select * from pacote_cliente where cod_cliente = " + xCodigoCliente +
                " and cod_filial_cliente = " + xCodigoFilialCliente + " order by cod_pacote desc";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public DataTable FiltraPacoteDetalhe(int xCodigoCliente, int xCodigoFilialCliente, int xCodigoPacote)
        {
            DataTable tt = new DataTable();
            string strSQL = "SELECT Pacote_cliente_detalhes.*, cliente.nome_cliente, lentes_tabela.nome_comercial, " +
                "(SELECT SUM(Contratada - Utilizado) AS saldo FROM saldos_pacotes(pacote_cliente_detalhes.cod_tabela, " +
                "pacote_cliente_detalhes.cod_filial_cliente, pacote_cliente_detalhes.cod_cliente) AS saldos " +
                "WHERE (cod_Pacote = pacote_cliente_detalhes.cod_pacote)) as Saldo, (Select produtos.produto from produtos " +
                "where produtos.cod_produto = pacote_cliente_detalhes.cod_surf) as surfacagem, (Select produtos.produto " +
                "from produtos where produtos.cod_produto = pacote_cliente_detalhes.cod_mont) as montagem, (Select produtos.produto from " +
                "produtos where produtos.cod_produto = pacote_cliente_detalhes.cod_trat) as tratamento, pacote_cliente.data FROM " +
                "lentes_tabela INNER JOIN cliente INNER JOIN Pacote_cliente_detalhes ON cliente.cod_filial_cliente = Pacote_cliente_detalhes.cod_filial_cliente AND " +
                "cliente.cod_cliente = Pacote_cliente_detalhes.cod_cliente ON lentes_tabela.cod_tabela = Pacote_cliente_detalhes.cod_tabela " +
                "INNER JOIN pacote_cliente on Pacote_cliente_detalhes.cod_Pacote = pacote_cliente.cod_Pacote where " +
                "pacote_cliente_detalhes.cod_cliente = " + xCodigoCliente +
                " and pacote_cliente_detalhes.cod_filial_cliente = " + xCodigoFilialCliente + " and pacote_cliente_detalhes.cod_pacote = " + xCodigoPacote + " order by item";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public DataTable FiltraPacoteDetalhe(int xCodigoCliente, int xCodigoFilialCliente, int xCodigoPacote, int xCodigoTabela)
        {
            DataTable tt = new DataTable();
            string strSQL = "SELECT Pacote_cliente_detalhes.*, cliente.nome_cliente, lentes_tabela.nome_comercial, lentes_tabela.preco_venda, " +
                "Pacote_cliente_detalhes.desconto, round((lentes_tabela.preco_venda-(lentes_tabela.preco_venda* " +
                "(pacote_cliente_detalhes.desconto/100))),2,2) as Preco_desconto, (SELECT SUM(Contratada - Utilizado) AS saldo " +
                "FROM  saldos_pacotes(pacote_cliente_detalhes.cod_tabela, pacote_cliente_detalhes.cod_filial_cliente, pacote_cliente_detalhes.cod_cliente) " +
                "AS saldos WHERE (cod_Pacote = pacote_cliente_detalhes.cod_pacote)) as Saldo, (Select produtos.produto from produtos where produtos.cod_produto = " +
                "pacote_cliente_detalhes.cod_surf) as surfacagem, isnull(isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = " +
                "pacote_cliente_detalhes.cod_surf),0) - (isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = " +
                "pacote_cliente_detalhes.cod_surf),0)*(pacote_cliente_detalhes.desc_surf/100)),0) as surf_desc, " +
                "(Select produtos.produto from produtos where produtos.cod_produto = pacote_cliente_detalhes.cod_mont) as montagem, " +
                "isnull(isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = pacote_cliente_detalhes.cod_mont),0) " +
                "- ( isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = " +
                "pacote_cliente_detalhes.cod_mont),0)*(pacote_cliente_detalhes.desc_mont/100)),0) as mont_desc, " +
                "(Select produtos.produto from produtos where produtos.cod_produto = pacote_cliente_detalhes.cod_trat) as tratamento,isnull( " +
                "isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = pacote_cliente_detalhes.cod_trat),0) " +
                "- ( isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = " +
                "pacote_cliente_detalhes.cod_trat),0)*(pacote_cliente_detalhes.desc_trat/100)),0) as trat_desc, pacote_cliente.data " +
                "FROM  lentes_tabela INNER JOIN cliente INNER JOIN Pacote_cliente_detalhes ON cliente.cod_filial_cliente = Pacote_cliente_detalhes.cod_filial_cliente " +
                "AND cliente.cod_cliente = Pacote_cliente_detalhes.cod_cliente ON lentes_tabela.cod_tabela = Pacote_cliente_detalhes.cod_tabela " +
                "INNER JOIN pacote_cliente on Pacote_cliente_detalhes.cod_Pacote = pacote_cliente.cod_Pacote where " +
                "pacote_cliente_detalhes.cod_cliente = " + xCodigoCliente + " and pacote_cliente_detalhes.cod_filial_cliente = " + xCodigoFilialCliente +
                " and pacote_cliente_detalhes.cod_pacote = " + xCodigoPacote + " and pacote_cliente_detalhes.cod_tabela =  " + xCodigoTabela + " order by item";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public void ExcluirItemPacote(int xCodigoPacote, int xCodigoCliente, int xCodigoTabela)
        {
            string strSQL = "delete from pacote_cliente_detalhes WHERE cod_pacote = " + xCodigoPacote + " and cod_cliente = " + xCodigoCliente +
                " and cod_tabela = " + xCodigoTabela;

            connDB.SalvaAtualizaExcluiReg(strSQL);          
        }

        public void ExcluirItemPacote(int xCodigoPacote, int xCodigoCliente)
        {
            string strSQL = "delete from pacote_cliente_detalhes WHERE cod_pacote = " + xCodigoPacote + " and cod_cliente = " + xCodigoCliente;

            connDB.SalvaAtualizaExcluiReg(strSQL);
        }

        public decimal TotalPacotePago(int xCodigoCliente, int xCodigoFilialCliente, int xCodigoPacote)
        {
            decimal valor = 0;

            string strSQL = "select isnull(SUM(valor_pago),0) as total_pacote_pago from lancamentos inner join lancamentos_cliente on " +
                "lancamentos.cod_lancamento = lancamentos_cliente.cod_lancamento and lancamentos.id_filial = lancamentos_cliente.id_filial " +
                "inner join pagamentos_credito on lancamentos.cod_lancamento = pagamentos_credito.cod_lancamento " +
                "and lancamentos.id_filial = pagamentos_credito.id_filial inner join credito_pacote on " +
                "pagamentos_credito.cod_credito = credito_pacote.cod_credito and pagamentos_credito.id_filial = credito_pacote.id_filial " +
                "where lancamentos_cliente.cod_cliente = " + xCodigoCliente + " And lancamentos_cliente.cod_filial_cliente = " + xCodigoFilialCliente +
                " And credito_pacote.cod_pacote = " + xCodigoPacote;

            connDB.AbreConexaoBanco();

            if (connDB.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, connDB.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    valor = Convert.ToDecimal(dr["total_pacote_pago"].ToString());
                }
            }

            return valor;
        }

        public decimal RetornaPrecoServico(int xCodigoProduto)
        {
            decimal valor = 0;

            string strSQL = "select preco_venda from produtos where cod_produto = " + xCodigoProduto;

            connDB.AbreConexaoBanco();
            if (connDB.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, connDB.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    valor = Convert.ToDecimal(dr["preco_venda"].ToString());
                }
            }

            return valor;
        }

        public DataTable TituloClienteAcordo(int xCodigoCliente, int xCodigoFilialCliente)
        {
            DataTable tt = new DataTable();
            string strSQL = "select lancamentos.cod_lancamento, lancamentos.id_filial,lancamentos.data_lancamento, lancamentos.data_vencimento, " +
                "lancamentos.data_recebimento,(lancamentos.Valor+ISNULL(pagamentos_acordo.acrescimo+pagamentos_acordo.taxas+pagamentos_acordo.juros-" +
                "pagamentos_acordo.desconto,0)) as valor, lancamentos.doc, pagamentos_fatura.cod_fatura as cod_fatura_real, Pagamentos_acordo.cod_acordo, " +
                "credito_pacote.cod_pacote, round((((isnull(lancamentos.Valor,0)+isnull(Pagamentos_acordo.acrescimo+Pagamentos_acordo.taxas+" +
                "Pagamentos_acordo.juros-Pagamentos_acordo.desconto,0)) * 1 / 100)),2) as multa_total, " +
                "round((((isnull(lancamentos.Valor,0)+isnull(Pagamentos_acordo.acrescimo+Pagamentos_acordo.taxas+Pagamentos_acordo.juros-" +
                "Pagamentos_acordo.desconto,0)) * (5/30.0) / 100) * DATEDIFF(day,data_vencimento,getdate())),2) as juros_total " +
                "from lancamentos left join lancamentos_cliente on lancamentos.cod_lancamento = lancamentos_cliente.cod_lancamento and " +
                "lancamentos.id_filial = lancamentos_cliente.id_filial left join Pagamentos_fatura on " +
                "Pagamentos_fatura.cod_lancamento = lancamentos.cod_lancamento and Pagamentos_fatura.id_filial = lancamentos.id_filial " +
                "left join pagamentos_acordo on Pagamentos_acordo.cod_lancamento = lancamentos.cod_lancamento and " +
                "Pagamentos_acordo.id_filial = lancamentos.id_filial left join pagamentos_credito  on pagamentos_credito.cod_lancamento = lancamentos.cod_lancamento and " +
                "pagamentos_credito.id_filial = lancamentos.id_filial left join credito_pacote on credito_pacote.cod_credito = pagamentos_credito.cod_credito and " +
                "pagamentos_credito.id_filial = credito_pacote.id_filial where lancamentos_cliente.cod_cliente = " + xCodigoCliente +
                " And lancamentos_cliente.cod_filial_cliente = " + xCodigoFilialCliente + " and lancamentos.data_recebimento is null and cod_status_lancamento =  1";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public DataTable DetalheMovimentoItem(int xCodigoPacote, int xCodigoTabela)
        {
            DataTable tt = new DataTable();
            string strSQL = "SELECT pedido_balcao_itens.num_pedido, Pacote_cliente_detalhes.cod_tabela, pedido_balcao_itens.id_filial, produtos.produto, " +
                "pedido_balcao_itens.quant, pedido_balcao_itens.preco,pedido_balcao_itens.desconto, (pedido_balcao_itens.preco * pedido_balcao_itens.quant) as pDesc," +
                "Pacote_cliente_detalhes.cod_Pacote, pedido_balcao.data_pedido FROM Pacote_cliente_detalhes INNER JOIN pedido_balcao_itens ON " +
                "Pacote_cliente_detalhes.cod_Pacote = pedido_balcao_itens.cod_pacote INNER JOIN produtos ON pedido_balcao_itens.cod_produto = " +
                "produtos.cod_produto INNER JOIN pedido_balcao ON pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido AND " +
                "pedido_balcao_itens.id_filial = pedido_balcao.id_filial INNER JOIN lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente" +
                " AND produtos.id_fabricante = lentes_blocos.id_fabricante AND Pacote_cliente_detalhes.cod_tabela = lentes_blocos.cod_tabela " +
                "where (Pacote_cliente_detalhes.cod_Pacote = " + xCodigoPacote + ") and Pacote_cliente_detalhes.cod_tabela = " + xCodigoTabela +
                " AND ((pedido_balcao_itens.cod_status_item <> 4) AND (pedido_balcao_itens.cod_status_item <> 5)) order by data_pedido,num_pedido,pedido_balcao_itens.item";

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public DataTable RetornaAcordo(int xCodigoCliente, int xCodigoFilialCliente)
        {
            DataTable tt = new DataTable();
            string strSQL = "select cliente_acordo.cod_acordo, status_acordo.status_acordo from cliente_acordo inner join status_acordo " +
                " on cliente_acordo.status_acordo = status_acordo.cod_status_acordo where cod_cliente = " + xCodigoCliente +
                " And cod_filial_cliente = " + xCodigoFilialCliente;

            connDB.CarregaTabela(strSQL, ref tt);

            return tt;
        }

        public int RetornaCodigoCredito(int xCodigoPacote, int xCodigoCliente)
        {
            int valor = 0;

            string strSQL = "select cod_cliente, cod_credito from credito_pacote where cod_pacote = " + xCodigoPacote + " and cod_cliente = " + xCodigoCliente;

            connDB.AbreConexaoBanco();

            if (connDB.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, connDB.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    valor = Convert.ToInt32(dr["cod_credito"].ToString());
                }
            }

            return valor;

        }

        private int VerificaCampos()
        {
            if (string.IsNullOrEmpty(TipoPessoa))
                return 1;
            if (string.IsNullOrEmpty(NomeCliente))
                return 2;
            if (string.IsNullOrEmpty(RazaoSocial))
                return 3;
            if (string.IsNullOrEmpty(CpfCnpj))
                return 4;
            if (string.IsNullOrEmpty(Cep))
                return 5;
            if (string.IsNullOrEmpty(Logradouro))
                return 6;
            if (string.IsNullOrEmpty(Numero))
                return 7;
            if (string.IsNullOrEmpty(Bairro))
                return 8;
            if (string.IsNullOrEmpty(NomeCidade))
                return 9;
            if (string.IsNullOrEmpty(Uf))
                return 10;
            if (CodigoTipoCliente == 0)
                return 11;

            return 0;
        }

        public bool VerificaCampoObrigatorio()
        {
            bool resultado = false;
            switch (VerificaCampos())
            {
                case 1:
                    MensagemRetorno = "Campo Tipo Pessoa é de preenchimento \nobrigatório!";
                    resultado = true;
                    break;
                case 2:
                     MensagemRetorno = "Campo Nome do Cliente é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 3:
                    MensagemRetorno = "Campo Razão Social é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 4:
                   MensagemRetorno = "Campo CNPJ/CPF é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 5:
                    MensagemRetorno = "Campo CEP é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 6:
                    MensagemRetorno = "Campo Endereço é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 7:
                    MensagemRetorno = "Campo Número é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 8:
                    MensagemRetorno = "Campo Bairro é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 9:
                    MensagemRetorno = "Campo Nome Cidade é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 10:
                     MensagemRetorno = "Campo UF é de preenchimento obrigatório!";
                    resultado = true;
                    break;
                case 11:
                    MensagemRetorno = "Campo Tipo Cliente é de preenchimento obrigatório!";
                    resultado = true;
                    break;
            }

            return resultado;

        }

    }
}
