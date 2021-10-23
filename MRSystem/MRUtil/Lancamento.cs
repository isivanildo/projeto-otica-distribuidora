using System;
using System.Data;
using System.Data.SqlClient;

namespace MRUtil
{
    public class Lancamento
    {
        ConexaoDB Conexao = new ConexaoDB();
        Fatura Fat = new Fatura();
        //FaturaItens FatItem;
        Arquivo Conf = new Arquivo();

        public int CodigoCliente { get; set; }
        public int CodigoLancamento { get; set; }
        public int CodigoFilialLancamento { get; set; }
        public int CodigoFilial { get; set; }
        public DateTime? DataLancamento { get; set; }
        public int CodigoConta { get; set; }
        public decimal? ValorPago { get; set; }
        public int? CodigoFormaPag { get; set; }
        public int? NumeroParcela { get; set; }
        public int? NumeroParcelas { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime? DataRecebimento { get; set; }
        public string Historico { get; set; }
        public string Documento { get; set; }
        public string Tipo { get; set; }
        public int? CodigoStatusLanc { get; set; }
        public int? CodigoFatura { get; set; }
        public decimal? Acrescimo { get; set; }
        public decimal? Juros { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? Taxa { get; set; }
        public int? UsuarioLanc { get; set; }
        public int? UsuarioAlt { get; set; }

        public decimal? TotalFatura { get; set; }

        public Lancamento() { }

        public virtual void Novo()
        {
            CodigoLancamento = 0;
            CodigoFilialLancamento = 0;
            CodigoFilial = 0;
            DataLancamento = null;
            CodigoConta = 0;
            ValorPago = 0;
            CodigoFormaPag = 0;
            NumeroParcela = null;
            NumeroParcelas = null;
            DataVencimento = null;
            DataRecebimento = null;
            Historico = null;
            Documento = null;
            Tipo = null;
            CodigoStatusLanc = null;
            CodigoFatura = null;
            Acrescimo = null;
            Juros = null;
            Desconto = null;
            Taxa = null;
            UsuarioLanc = null;
            UsuarioAlt = null;
        }

        public void RetornaRegistro(string xDataIni, string xDataFim, int xFilial)
        {
            xDataIni = xDataIni + " 00:00:01";
            xDataFim = xDataFim + " 23:59:59";
            string strSQL = string.Empty;
            strSQL = "select * from lancamentos where id_filial = " + xFilial + " and data_lancamento >= " + Geral.DataSQL(xDataIni.ToString()) +
                " and data_lancamento <= " + Geral.DataSQL(xDataFim.ToString());

            SqlCommand cmd;
            SqlDataReader dr;

            if (Conexao.ConectadoBanco == true)
            {
                cmd = new SqlCommand(strSQL, Conexao.Conn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CodigoLancamento = Convert.ToInt32(dr["cod_lancamento"]);
                    CodigoFilialLancamento = Convert.ToInt32(dr["id_filial_lancamento"]);
                    CodigoFilial = Convert.ToInt32(dr["id_filial"]);
                    DataLancamento = Convert.ToDateTime(dr["data_lancamento"]);
                    CodigoConta = Convert.ToInt32(dr["cod_conta"]);
                    ValorPago = Convert.ToDecimal(dr["valor_pago"]);
                    CodigoFormaPag = Convert.ToInt32(dr["cod_forma_pagamento"]);
                    NumeroParcela = Convert.ToInt32(dr["n_parcelas"]);
                    NumeroParcelas = Convert.ToInt32(dr["n_parcela"]);
                    DataVencimento = Convert.ToDateTime(dr["data_vencimento"]);
                    DataRecebimento = Convert.ToDateTime(dr["data_recebimento"]);
                    Historico = dr["historico"].ToString();
                    Documento = dr["doc"].ToString();
                    Tipo = dr["tipo"].ToString();
                    CodigoStatusLanc = Convert.ToInt32(dr["cod_status_lancamento"]);

                    if (dr["cod_fatura"] != DBNull.Value)
                    {
                        CodigoFatura = Convert.ToInt32(dr["cod_fatura"]);
                    }
                    else
                    {
                        CodigoFatura = null;
                    }

                    Acrescimo = Convert.ToDecimal(dr["acrescimo"]);
                    Juros = Convert.ToDecimal(dr["juros"]);
                    Desconto = Convert.ToDecimal(dr["desconto"]);
                    Taxa = Convert.ToDecimal(dr["taxas"]);
                    UsuarioLanc = Convert.ToInt32(dr["usuario_lanc"]);
                    UsuarioAlt = Convert.ToInt32(dr["usuario_alt"]);
                }

                dr.Close();
            }

        }

        public void RetornaRegistro(int xCodigoLancamento, string xTipo)
        {
            string strSQL = string.Empty;
            strSQL = "select * from lancamentos where cod_lancamento = " + xCodigoLancamento + " and tipo = " + Geral.AspasSQL(xTipo);

            SqlCommand cmd;
            SqlDataReader dr;

            if (Conexao.ConectadoBanco == true)
            {
                cmd = new SqlCommand(strSQL, Conexao.Conn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CodigoLancamento = Convert.ToInt32(dr["cod_lancamento"]);
                    CodigoFilialLancamento = Convert.ToInt32(dr["id_filial_lancamento"]);
                    CodigoFilial = Convert.ToInt32(dr["id_filial"]);
                    DataLancamento = Convert.ToDateTime(dr["data_lancamento"]);
                    CodigoConta = Convert.ToInt32(dr["cod_conta"]);
                    ValorPago = Convert.ToDecimal(dr["valor_pago"]);
                    CodigoFormaPag = Convert.ToInt32(dr["cod_forma_pagamento"]);
                    NumeroParcela = Convert.ToInt32(dr["n_parcelas"]);
                    NumeroParcelas = Convert.ToInt32(dr["n_parcela"]);
                    DataVencimento = Convert.ToDateTime(dr["data_vencimento"]);
                    DataRecebimento = Convert.ToDateTime(dr["data_recebimento"]);
                    Historico = dr["historico"].ToString();
                    Documento = dr["doc"].ToString();
                    Tipo = dr["tipo"].ToString();
                    CodigoStatusLanc = Convert.ToInt32(dr["cod_status_lancamento"]);

                    if (dr["cod_fatura"] != DBNull.Value)
                    {
                        CodigoFatura = Convert.ToInt32(dr["cod_fatura"]);
                    }
                    else
                    {
                        CodigoFatura = null;
                    }

                    Acrescimo = Convert.ToDecimal(dr["acrescimo"]);
                    Juros = Convert.ToDecimal(dr["juros"]);
                    Desconto = Convert.ToDecimal(dr["desconto"]);
                    Taxa = Convert.ToDecimal(dr["taxas"]);
                    UsuarioLanc = Convert.ToInt32(dr["usuario_lanc"]);
                    UsuarioAlt = Convert.ToInt32(dr["usuario_alt"]);
                }

                dr.Close();
            }


        }
        public string SalvaLancamento()
        {
            string resultado = string.Empty;

            int Chave = (int)Conexao.RetornaChave("cod_lancamento", "lancamentos", "where id_filial_lancamento = " + CodigoFilialLancamento);
            CodigoLancamento = Chave;

            string strSQL = "insert into lancamentos(cod_lancamento, id_filial_lancamento, id_filial, data_lancamento, cod_conta, valor_pago, cod_forma_pagamento, " +
                "n_parcelas, n_parcela, data_vencimento, data_recebimento, historico, doc, tipo, cod_status_lancamento, cod_fatura, acrescimo, juros, " +
                "desconto, taxas, usuario_lanc,usuario_alt) values(" + CodigoLancamento + "," + CodigoFilialLancamento + "," + CodigoFilial + "," +
                Geral.DataSQL(DataLancamento.ToString()) + "," + Geral.NumeroSQL(CodigoConta) + "," + Geral.ValorMoeda(ValorPago) + "," +
                CodigoFormaPag + "," + NumeroParcelas + "," + NumeroParcela + "," + Geral.DataSQL(DataVencimento.ToString()) + "," + 
                Geral.DataSQL(DataRecebimento.ToString()) + "," + Geral.AspasSQL(Historico) + "," + Geral.AspasSQL(Documento) + "," + Geral.AspasSQL(Tipo) + "," + 
                Geral.NumeroSQL(CodigoStatusLanc) + "," + Geral.NumeroSQL(CodigoFatura) + "," + Geral.ValorMoeda(Acrescimo) + "," + Geral.ValorMoeda(Juros) + "," + 
                Geral.ValorMoeda(Desconto) + "," + Geral.ValorMoeda(Taxa) + "," + Geral.NumeroSQL(UsuarioLanc) + "," + Geral.NumeroSQL(UsuarioAlt) + ")";

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
              if (CodigoCliente > 0)
                {
                    SalvaLancamentoCliente();
                }     
            }

            return "OK";

        }

        public void SalvaLancamentoCliente()
        {
            string strSQL = "insert into lancamentos_cliente (id_filial, cod_lancamento, cod_filial_cliente, cod_cliente) values(" + CodigoFilialLancamento + "," +
                CodigoLancamento + "," + CodigoFilial + "," + CodigoCliente + ")";

            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }
        public DataTable ListaRecebimentoFatura(int xCodigoFilial, int xCodigoFatura)
        {
            string strSQL = "select lancamentos.data_lancamento,lancamentos.cod_conta, sum(lancamentos.valor_pago+lancamentos.acrescimo-lancamentos.desconto) as valor, " +
                "lancamentos.cod_forma_pagamento, lancamentos.n_parcelas, lancamentos.n_parcela,lancamentos.data_vencimento,lancamentos.data_recebimento, " +
                "lancamentos.historico, lancamentos.doc, lancamentos.tipo, lancamentos.cod_status_lancamento,lancamentos.cod_fatura,lancamentos.acrescimo, " +
                "lancamentos.juros, lancamentos.desconto, forma_pagamento.forma_pagamento FROM lancamentos INNER JOIN forma_pagamento ON " +
                "lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento WHERE(lancamentos.cod_fatura = " + xCodigoFatura +") " +
                "AND(lancamentos.id_filial = " + xCodigoFilial + ") And (lancamentos.cod_status_lancamento <> 2) group by lancamentos.cod_lancamento, " +
                "lancamentos.id_filial_lancamento,lancamentos.id_filial, lancamentos.data_lancamento, lancamentos.cod_conta,lancamentos.cod_forma_pagamento, " +
                "lancamentos.n_parcelas, lancamentos.n_parcela, lancamentos.data_vencimento,lancamentos.data_recebimento, lancamentos.historico, " +
                "lancamentos.doc, lancamentos.tipo, lancamentos.cod_status_lancamento, lancamentos.cod_fatura, lancamentos.acrescimo, lancamentos.juros, " +
                "lancamentos.desconto, forma_pagamento.forma_pagamento";

            DataTable tb = new DataTable();
            Conexao.CarregaTabela(strSQL, ref tb);

            return tb;
        }

        public DataTable ListarReceitasData(string xDataInicial, string xDataFinal, int xFilial)
        {
            DateTime di = Convert.ToDateTime(xDataInicial + " 00:00:01");
            DateTime df = Convert.ToDateTime(xDataFinal + " 23:59:59");

            string strSQL = "select fp.forma_pagamento, l.cod_forma_pagamento, l.historico, l.Valor_Pago, l.acrescimo, l.juros, l.desconto, l.taxas, " +
                "((l.Valor_Pago + isnull((l.acrescimo),0) - isnull((l.desconto),0))) as total, " +
                "l.data_lancamento, l.doc, l.cod_fatura, f.cod_cliente, c.nome_cliente, l.data_recebimento from lancamentos l inner join forma_pagamento fp on " +
                "fp.cod_forma_pagamento = l.cod_forma_pagamento inner join Fatura f on l.cod_fatura = f.cod_fatura and l.id_filial = f.id_filial inner join " +
                "cliente c on f.cod_cliente = c.cod_cliente  And f.id_filial = c.cod_filial_cliente where " +
                "l.data_recebimento >= " + Geral.DataSQL(di.ToString()) + 
                " and l.data_recebimento <= " + Geral.DataSQL(df.ToString()) +
                " and l.tipo IN ('E','R') and l.id_filial = " + xFilial + " order by cod_forma_pagamento, data_recebimento";

            DataTable tb = new DataTable();
            Conexao.CarregaTabela(strSQL, ref tb);

            return tb;
        }

        public DataTable ListarDespesasData(string xDataInicial, string xDataFinal, int xFilial)
        {
            DateTime di = Convert.ToDateTime(xDataInicial + " 00:00:01");
            DateTime df = Convert.ToDateTime(xDataFinal + " 23:59:59");

            string strSQL = "SELECT lancamentos.*, Contas.NOME AS conta FROM lancamentos INNER JOIN " +
                "Contas ON lancamentos.cod_conta = Contas.CONTA where lancamentos.data_lancamento >= " + Geral.DataSQL(di.ToString()) +
                "and lancamentos.data_lancamento <= " + Geral.DataSQL(df.ToString()) + " and id_filial_lancamento = " + xFilial +
                " and contas.tipo  = 'S' and (lancamentos.cod_status_lancamento <> 2)";

            DataTable tb = new DataTable();
            Conexao.CarregaTabela(strSQL, ref tb);

            return tb;
        }

        public DataTable ListarOutrasReceitasData(string xDataInicial, string xDataFinal, int xFilial)
        {
            DateTime di = Convert.ToDateTime(xDataInicial + " 00:00:01");
            DateTime df = Convert.ToDateTime(xDataFinal + " 23:59:59");

            string strSQL = "SELECT lancamentos.*, Contas.NOME AS conta FROM lancamentos INNER JOIN " + "Contas ON lancamentos.cod_conta = Contas.CONTA where " +
                "lancamentos.data_lancamento >= " + Geral.DataSQL(di.ToString()) + " and lancamentos.data_lancamento <= " + Geral.DataSQL(df.ToString()) +
                " and id_filial_lancamento = " + xFilial + " and contas.classificacao like '1.3%' " + " and (lancamentos.cod_status_lancamento <> 2)";

            DataTable tb = new DataTable();
            Conexao.CarregaTabela(strSQL, ref tb);

            return tb;
        }

        public DataTable ListarResumoFormasPagamento(string xDataInicial, string xDataFinal, int xFilial)
        {
            DateTime di = Convert.ToDateTime(xDataInicial + " 00:00:01");
            DateTime df = Convert.ToDateTime(xDataFinal + " 23:59:59");

            DataTable tt = new DataTable();
            DataTable ttTeste = new DataTable();

            int i, j;
            decimal valor = 0;

            string sql = "SELECT SUM((lancamentos.Valor_pago+lancamentos.acrescimo + lancamentos.juros + lancamentos.taxas - lancamentos.desconto) +" +
                "ISNULL((Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros+Pagamentos_acordo.taxas-Pagamentos_acordo.desconto),0)) as Total," +
                "lancamentos.cod_forma_pagamento, forma_pagamento.forma_pagamento FROM lancamentos INNER JOIN  forma_pagamento ON " +
                "lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento LEFT JOIN Pagamentos_acordo ON " +
                "LANCAMENTOS.cod_lancamento = Pagamentos_acordo.cod_lancamento AND lancamentos.id_filial = Pagamentos_acordo.id_filial " +
                "WHERE (lancamentos.data_recebimento >= " + Geral.DataSQL(di.ToString()) +
                " and lancamentos.data_recebimento <= " + Geral.DataSQL(df.ToString()) + " and lancamentos.tipo <> 'S' " +
                " and (lancamentos.cod_status_lancamento = 1) and (lancamentos.id_filial_lancamento = " + xFilial + ")" +
                ") GROUP BY lancamentos.cod_forma_pagamento,forma_pagamento.forma_pagamento";

            string strSQL = "SELECT SUM((lancamentos.Valor_Pago+lancamentos.acrescimo+lancamentos.juros+lancamentos.taxas-lancamentos.desconto) + " +
                 "ISNULL((Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros+Pagamentos_acordo.taxas-Pagamentos_acordo.desconto),0)) as Total, " +
                 "lancamentos.cod_forma_pagamento, forma_pagamento.forma_pagamento FROM lancamentos INNER JOIN  forma_pagamento ON " +
                 "lancamentos.cod_forma_pagamento = forma_pagamento.cod_forma_pagamento LEFT JOIN Pagamentos_acordo ON " +
                 "LANCAMENTOS.cod_lancamento = Pagamentos_acordo.cod_lancamento AND lancamentos.id_filial = Pagamentos_acordo.id_filial " +
                 "WHERE (lancamentos.data_recebimento >= " + Geral.DataSQL(di.ToString()) + " and " +
                 "lancamentos.data_recebimento <= " + Geral.DataSQL(df.ToString()) + " and lancamentos.tipo <> 'S' " +
                 "and (lancamentos.cod_status_lancamento = 1) and (lancamentos.id_filial_lancamento IN (1,2,3,4))" +
                 ") GROUP BY lancamentos.cod_forma_pagamento,forma_pagamento.forma_pagamento";


            Conexao.CarregaTabela(strSQL, ref ttTeste);

            for (j = 0; j <= ttTeste.Rows.Count - 1; j++)
            {
                if (Convert.ToInt32(ttTeste.Rows[j]["cod_forma_pagamento"]) == 8)
                {
                    valor += Convert.ToDecimal(ttTeste.Rows[j]["total"]);
                }
   
            }

            Conexao.CarregaTabela(sql, ref tt);

            for (i = 0; i <= tt.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(tt.Rows[i]["cod_forma_pagamento"]) == 8)
                {
                    tt.Rows[i]["total"] = string.Format("{0:##0.00}", valor);
                }

                if (Conf.Filial != 1)
                {
                    if (Convert.ToInt32(tt.Rows[i]["cod_forma_pagamento"]) == 8)
                    {
                        tt.Rows[i]["total"] = string.Format("{0:##0.00}", valor);
                    }
                }
            }

            return tt;
        }

        public DataTable TitulosBaixadosDia(string xDataInicial, string xDataFinal)
        {
            DateTime di = Convert.ToDateTime(xDataInicial + " 00:00:01");
            DateTime df = Convert.ToDateTime(xDataFinal + " 23:59:59");

            string strSQL = "SELECT cliente.cod_cliente,nome_cliente,boleto.Nossonumero, boleto.tipo_documento,boleto.documento, lancamentos.data_lancamento," +
                "(lancamentos.Valor_Pago + isnull((Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros+Pagamentos_acordo.taxas-Pagamentos_acordo.desconto),0)) as Valor," +
                "lancamentos.Valor_Pago,lancamentos.acrescimo,lancamentos.juros, lancamentos.desconto," +
                "(lancamentos.Valor_Pago+lancamentos.acrescimo+lancamentos.juros+lancamentos.taxas-lancamentos.desconto) + " +
                "ISNULL((Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros+Pagamentos_acordo.taxas-Pagamentos_acordo.desconto),0) as total," +
                "lancamentos.data_vencimento, lancamentos.data_recebimento FROM boleto INNER JOIN lancamentos ON boleto.cod_lancamento = " +
                "lancamentos.cod_lancamento AND boleto.id_filial = lancamentos.id_filial inner join lancamentos_cliente on lancamentos.id_filial = " +
                "lancamentos_cliente.id_filial and lancamentos.cod_lancamento = lancamentos_cliente.cod_lancamento inner join cliente on " +
                "lancamentos_cliente.cod_filial_cliente = cliente.cod_filial_cliente and lancamentos_cliente.cod_cliente = " +
                "cliente.cod_cliente LEFT JOIN Pagamentos_acordo ON LANCAMENTOS.cod_lancamento = Pagamentos_acordo.cod_lancamento AND " +
                "lancamentos.id_filial = Pagamentos_acordo.id_filial where lancamentos.data_recebimento >= " + Geral.DataSQL(di.ToString()) +
                " and lancamentos.data_recebimento <= " + Geral.DataSQL(df.ToString()) + " and not (lancamentos.cod_status_lancamento in (2,3)) " +
                " and lancamentos.id_filial_lancamento IN (1,2,3,4) order by lancamentos.data_recebimento, boleto.nossonumero";

            DataTable tb = new DataTable();
            Conexao.CarregaTabela(strSQL, ref tb);

            return tb;
        }

        public decimal TotalDespesasData(string xDtIni, string xDtFim, int xFilial)
        {
            decimal resultado = 0;
            DateTime di, df;
            di = Convert.ToDateTime(xDtIni + " 00:00:01");
            df = Convert.ToDateTime(xDtFim + " 23:59:59");

            string strSQL = "select SUM(lancamentos.Valor_pago) AS Total FROM lancamentos INNER JOIN Contas ON lancamentos.cod_conta = Contas.CONTA where " +
                "lancamentos.data_lancamento >= " + Geral.DataSQL(di.ToString()) + " and lancamentos.data_lancamento <= " + Geral.DataSQL(df.ToString()) + " " +
                "and id_filial_lancamento = " + xFilial + " and contas.tipo  = 'S' " + " and (lancamentos.cod_status_lancamento <> 2)";

            if (Conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, Conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    resultado = Convert.ToDecimal(dr["total"]);
                }
            }

            return resultado;
        }

        public decimal TotalOutrasReceitasData(string xDtIni, string xDtFim, int xFilial)
        {
            decimal resultado = 0;
            DateTime di, df;
            di = Convert.ToDateTime(xDtIni + " 00:00:01");
            df = Convert.ToDateTime(xDtFim + " 23:59:59");

            string strSQL = "select SUM(lancamentos.Valor_pago) AS Total FROM lancamentos INNER JOIN Contas ON lancamentos.cod_conta = Contas.CONTA where " +
                "lancamentos.data_lancamento >= " + Geral.DataSQL(di.ToString()) + " and lancamentos.data_lancamento <= " + Geral.DataSQL(df.ToString()) + " " +
                "and id_filial_lancamento = " + xFilial + " and contas.tipo  = 'E' " + "and lancamentos.cod_conta <> 101" + " and (lancamentos.cod_status_lancamento <> 2)";

            if (Conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(strSQL, Conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    resultado = Convert.ToDecimal(dr["total"]);
                }
            }

            return resultado;
        }

        public void ExcluiDespesasReceitas()
        {
            string strSQL = "Delete from lancamentos where cod_lancamento = " + CodigoLancamento + " and id_filial_lancamento = " + CodigoFilial;

            Conexao.SalvaAtualizaExcluiReg(strSQL);

        }

        public void AtualizaDespesaOutrasReceitas()
        {
            string strSQL = "update lancamentos set data_lancamento = " + Geral.DataSQL(DataLancamento.ToString()) + "," +
                "cod_conta = " + Geral.NumeroSQL(CodigoConta) + "," + "valor_pago = " + Geral.ValorMoeda(ValorPago) + "," +
                "historico = " + Geral.AspasSQL(Historico) + "," + "usuario_alt = " + Geral.NumeroSQL(UsuarioAlt) + " " +
                "where cod_lancamento = " + CodigoLancamento + " and id_filial = " + CodigoFilial;

            Conexao.SalvaAtualizaExcluiReg(strSQL);
        }

    }
}
