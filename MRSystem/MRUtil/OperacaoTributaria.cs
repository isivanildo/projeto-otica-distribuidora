using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MRUtil
{
    public class OperacaoTributaria
    {
        public int Codigo { get; set; }

        private string tipoEntradaSada;
        public string Descricao { get; set; }

        private int precoUsado;

        private int destinatario;
        public string Observacao { get; set; }
        public bool Complementar { get; set; }
        public bool Devolucao { get; set; }

        private int destino;
        public bool Normal { get; set; }
        public bool Ajuste { get; set; }

        private int operacaoNFe;
 
        ConexaoDB conexao = new ConexaoDB();

        public string TipoEntradaSaida
        {
            get
            {
                if (tipoEntradaSada == "S")
                {
                    return "Saída";
                }
                else
                {
                    return "Entada";
                }
            }
            set
            {
                tipoEntradaSada = value;
            }
        }

        public string PrecoUsado
        {
            get
            {
                if (precoUsado == 1)
                {
                    return "Custo";
                }
                else
                {
                    return "Venda";
                }
            }
            set
            {
                precoUsado = Convert.ToInt32(value);
            }
        }

        public string Destinatario
        {
            get
            {
                if (destinatario == 1)
                {
                    return "Cliente";
                }
                else
                {
                    return "Fornecedor";
                }
            }
            set
            {
                destinatario = Convert.ToInt32(value);
            }
        }

        public string Destino
        {
            get
            {
                if (destino == 1)
                {
                    return "Interno";
                }
                else if (destino == 2)
                {
                    return "Interestadual";
                }
                else
                {
                    return "Exterior";
                }
            }
            set
            {
                destino = Convert.ToInt32(value);
            }
        }
        public string OperacaoNFe
        {
            get
            {
                if (operacaoNFe == 1)
                {
                    return "Consumidor";
                }
                else
                {
                    return "Normal";
                }
            }
            set
            {
                operacaoNFe = Convert.ToInt32(value);
            }
        }

        public OperacaoTributaria()
        {

        }

        public void Novo()
        {
            if (Geral.TipoReg == Belemtech.TiposReg.Novo)
            {
                Codigo = Convert.ToInt16(conexao.RetornaUltimoRegistro("select max(codigonat) from naturezaoperacao"));
            }
        }

        public List<OperacaoTributaria> RetornaDados(string instrucaoSQL)
        {
            List<OperacaoTributaria> _lista = new List<OperacaoTributaria>();
            if (conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(instrucaoSQL, conexao.Conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    _lista.Add(new OperacaoTributaria()
                    {
                        Codigo = Int16.Parse(dr["codigonat"].ToString()),
                        TipoEntradaSaida = dr["tipoentradasaida"].ToString(),
                        Descricao = dr["descricao"].ToString(),
                        PrecoUsado = dr["precousado"].ToString(),
                        Destinatario = dr["destinatario"].ToString(),
                        Observacao = dr["observacao"].ToString(),
                        Complementar = Convert.ToBoolean(dr["complementar"].ToString()),
                        Devolucao = Convert.ToBoolean(dr["devolucao"].ToString()),
                        Destino = dr["destino"].ToString(),
                        Normal = Convert.ToBoolean(dr["normal"].ToString()),
                        Ajuste = Convert.ToBoolean(dr["ajuste"].ToString()),
                        OperacaoNFe = dr["operacaonfe"].ToString(),              
                    });

                }
            }

            return _lista;
        }

        public void RetornaRegistro(string instrucaoSQL)
        {
            if (conexao.ConectadoBanco == true)
            {
                SqlCommand cmd = new SqlCommand(instrucaoSQL, conexao.Conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Codigo = Convert.ToInt16(dr["codigonat"].ToString());
                    TipoEntradaSaida = dr["tipoentradasaida"].ToString();
                    Descricao = dr["descricao"].ToString();
                    PrecoUsado = dr["precousado"].ToString();
                    Observacao = dr["observacao"].ToString();
                    Normal = Convert.ToBoolean(dr["normal"]);
                    Complementar = Convert.ToBoolean(dr["complementar"]);
                    Ajuste = Convert.ToBoolean(dr["ajuste"]);
                    Devolucao = Convert.ToBoolean(dr["devolucao"]);
                    Destinatario = Convert.ToString(dr["destinatario"]);
                    Destino = Convert.ToString(dr["destino"]);
                    OperacaoNFe = dr["operacaonfe"].ToString();
                }
            }

        }
        public bool SalvaAtualizaExclui()
        {
            bool resultado = false;
            string strSQL = "";

            if (Geral.TipoReg == Belemtech.TiposReg.Novo)
            {
                strSQL = "insert into naturezaoperacao (codigonat, tipoentradasaida, descricao, precousado, destinatario," +
                "observacao, complementar, devolucao, destino, normal, ajuste, operacaonfe, cfop, codigocst) values(" + Codigo + "," +
                Geral.AspasSQL(tipoEntradaSada) + "," + Geral.AspasSQL(Descricao) + "," + precoUsado + "," + destinatario + "," + 
                Geral.AspasSQL(Observacao) + "," + Geral.AspasSQL(Complementar.ToString()) + "," + Geral.AspasSQL(Devolucao.ToString()) + "," + 
                destino + "," + Geral.AspasSQL(Normal.ToString()) + "," + Geral.AspasSQL(Ajuste.ToString()) + "," + operacaoNFe + ")";
            }

            if (Geral.TipoReg == Belemtech.TiposReg.Alterar)
            {
                strSQL = "update naturezaoperacao set tipoentradasaida = " + Geral.AspasSQL(tipoEntradaSada) + "," + 
                    "descricao = " + Geral.AspasSQL(Descricao) + "," + "precousado = " + precoUsado + "," + "destinatario = " + 
                    destinatario + "," + "observacao = " + Geral.AspasSQL(Observacao) + "," + 
                    "complementar = " + Geral.AspasSQL(Complementar.ToString()) + "," + "devolucao = " + Geral.AspasSQL(Devolucao.ToString()) + "," + 
                    "destino = " + destino + "," + "normal = " + Geral.AspasSQL(Normal.ToString()) + "," + 
                    "ajuste = " + Geral.AspasSQL(Ajuste.ToString()) + "," + "operacaonfe = " + operacaoNFe + "," +
                    " where codigonat = " + Codigo;
            }

            if (Geral.TipoReg == Belemtech.TiposReg.Excluir)
            {
                strSQL = "delete from naturezaoperacao where codigonat = " + Codigo;
            }

           if (conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }
    }
}
