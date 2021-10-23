using System.Data;
using System.Data.SqlClient;

namespace MRUtil
{
    public class UsuarioPermissao : Usuario
    {
        public int CodigoProcedimento { get; set; }
        public int IdAcessos { get; set; }

        ConexaoDB connDB = new ConexaoDB();

        public UsuarioPermissao() { }

        public bool SalvarPermissao()
        {
            bool resultado = false;
            int codigoAcesso = connDB.RetornaChave("id_acessos", "acessos_usuario", "");

            string strSQL = "insert into acessos_usuario(cod_usuario, cod_procedimento, id_acessos) values(" +
                CodigoUsuario + "," + CodigoProcedimento + "," + codigoAcesso + ")";

            if (connDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                resultado = true;
            }

            return resultado;
        }

        public void ExcluirPermissao(int xCodigoUsuario)
        {
            string strsQL = "delete from acessos_usuario where cod_usuario = " + xCodigoUsuario;

            connDB.SalvaAtualizaExcluiReg(strsQL);
        }

        /// <summary>
        /// Utilizada para verificar se o usuário já tem uma dada permissão de acesso
        /// </summary>
        /// <returns>Retorna verdadeiro caso a permissão já existe e falso caso a permissão não exista</returns>
        public bool VerificaPermissaoUsuario(int xCodPermissao)
        {
            bool bResultado = false;
            string strSQL = "Select 1 from acessos_usuario where cod_usuario = " + CodigoUsuario + 
                " and  cod_procedimento = " + xCodPermissao;

            if (connDB.VerificaExistenciaReg(strSQL) == 1)
            {
                bResultado = true;
            }
            else
            {
                bResultado = false;
            }

            return bResultado;
        }

        /// <summary>
        /// Retorna todo o acesso vinculado ao usuário atual
        /// </summary>
        /// <param name="xCodigoUsuario">Código do usuário a ser verificado</param>
        /// <returns>Retorna todos os acesso permitido para o usuário atual</returns>
        public DataTable PermissaoAcessoUsuarios(int xCodigoUsuario)
        {
            string strSQL = "select * from acessos_usuario where cod_usuario = " + xCodigoUsuario;
            DataTable tb = new DataTable();

            using (SqlConnection conn = new SqlConnection(connDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var reader = cmd.ExecuteReader())
                    {
                        tb.Load(reader);
                    }
                }
            }

            return tb;

        }
    }
}
