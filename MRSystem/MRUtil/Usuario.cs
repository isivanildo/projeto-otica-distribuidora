using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MRUtil
{
    public class Usuario
    {
        public int CodigoUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string NomeCompletoUsuario { get; set; }
        private string _senhaUsuario { get; set; }
        public int? Perfil { get; set; }
        public bool Ativo { get; set; }
        public bool UsuarioLogado { get; set; }
        public string MensagemRetorno { get; private set; }

        private string _resetaSenha = "12345";


        ConexaoDB Conexao = new ConexaoDB();

        public Usuario() { }

        public string SenhaUsuario
        {
            get => _senhaUsuario;

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.Length > 15)
                    {
                        MensagemRetorno = "Senha deve ter no máximo 15 caracteres.";
                        return;
                    }
                    else
                    {
                        _senhaUsuario = value;
                    }
                }
            }
        }

        /// <summary>
        /// Limpa as propriedades
        /// </summary>
        public void Novo()
        {
            CodigoUsuario = 0;
            NomeUsuario = string.Empty;
            NomeCompletoUsuario = string.Empty;
            SenhaUsuario = string.Empty;
            Perfil = 0;
            Ativo = true;
        }

        public bool SalvarUsuario()
        {
            bool bResultado = false;
            int codigo = Conexao.RetornaChave("cod_usuario", "usuarios", "");

            string strSQL = "insert into usuarios(cod_usuario, nome, senha, nome_completo, perfil, ativo) " +
                "values (" + codigo  + "," + Geral.AspasSQL(NomeUsuario) + "," + 
                Geral.AspasSQL(Criptografia.TextoCriptografado(_senhaUsuario)) + "," + 
                Geral.AspasSQL(NomeCompletoUsuario) + "," + Perfil + "," + Geral.AspasSQL(Ativo.ToString()) + ")";

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
                CodigoUsuario = codigo;
            }

            return bResultado;
        }

        public bool AtualizaUsuario(int xCodigoUsuario)
        {
            bool bResultado = false;

            string strSQL = "update usuarios set nome = " + Geral.AspasSQL(NomeUsuario) + "," +
                "senha = " + Geral.AspasSQL(Criptografia.TextoCriptografado(_senhaUsuario)) + "," +
                "nome_completo = " + Geral.AspasSQL(NomeCompletoUsuario) + "," + 
                "perfil = " + Perfil + "," + "ativo = " +  Geral.AspasSQL(Ativo.ToString()) + " where cod_usuario = " + xCodigoUsuario;
            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
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
         /// Usado para excluir um determinado usuário
         /// </summary>
        public bool ExcluirUsuario()
        {
            bool bResultado = false;
            string strSQL = "";

            strSQL = "delete from acessos_usuario where cod_usuario = " + CodigoUsuario;

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                strSQL = "delete from usuarios where cod_usuario = " + CodigoUsuario;
                if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
                {
                    bResultado = true;
                    MensagemRetorno = "Usuário excluído com sucesso!";
                }
            }

            if (!string.IsNullOrEmpty(Conexao.MensagemErro))
            {
                MensagemRetorno = Conexao.MensagemErro;
            }

            return bResultado;
                       
        }        

        /// <summary>
        /// Verifica se o usuário teve exito no logoff
        /// </summary>
        /// <param name="xCodUsuario">Código usuário</param>
        /// <param name="xSenha">Senha do usuário</param>
        /// <returns>verdadeiro = çogado e falso - deslogado</returns>
        public bool VerificaUsuarioLogado(int xCodUsuario, string xSenha)
        {
            string strSQL = "select 1 from usuarios where cod_usuario = " + xCodUsuario + " and senha = '" +
                Criptografia.TextoCriptografado(xSenha) + "'";
            
            using (SqlConnection conn = new SqlConnection(Conexao.stringConexao))
            {
                try
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = strSQL;
                        var retorno = cmd.ExecuteScalar();

                        if (retorno != null && retorno != DBNull.Value && Convert.ToInt32(retorno).Equals(1))
                        {
                            UsuarioLogado = true;
                        }
                        else
                        {
                            UsuarioLogado = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return UsuarioLogado;
        }

        /// <summary>
        /// Verifica se o usuário está logado, baseado no perfil
        /// </summary>
        /// <param name="xCodUsuario"></param>
        /// <param name="xSenha"></param>
        /// <param name="xPerfil"></param>
        /// <returns></returns>
        public bool VerificaUsuarioLogado(int xCodUsuario, string xSenha, int xPerfil)
        {
            string strSQL = "select 1 from usuarios where cod_usuario = " + xCodUsuario + " and senha = '" +
                Criptografia.TextoCriptografado(xSenha) + "' and perfil = " + xPerfil;

            using (SqlConnection conn = new SqlConnection(Conexao.stringConexao))
            {
                try
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = strSQL;
                        var retorno = cmd.ExecuteScalar();

                        if (retorno != null && retorno != DBNull.Value && Convert.ToInt32(retorno).Equals(1))
                        {
                            UsuarioLogado = true;
                        }
                        else
                        {
                            UsuarioLogado = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return UsuarioLogado;
        }

        public List<Usuario> RetornaRegistroLista(int codigo)
        {
            string strSQL = "select * from usuarios where cod_usuario = " + codigo;
            List<Usuario> _usuario = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(Conexao.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            _usuario.Add(new Usuario()
                            {
                                CodigoUsuario = Int32.Parse(dr["Cod_Usuario"].ToString()),
                                NomeUsuario = dr["Nome"].ToString(),
                                SenhaUsuario = dr["Senha"].ToString(),
                                NomeCompletoUsuario = dr["nome_completo"].ToString(),
                                Perfil = int.Parse(dr["Perfil"].ToString()),
                                Ativo = Convert.ToBoolean(dr["Ativo"].ToString())
                            });
                        }

                        if (_usuario.Count == 0)
                        {
                            MensagemRetorno = "Usuário não cadastrado para acesso ao sistema.";
                        }
                    }
                }
            }
             
            return _usuario;
        }

        /// <summary>
        /// aaaaaa
        /// </summary>
        /// <returns>bbbbbbbb</returns>
        public DataTable RetornaDados()
        {
            string strSQL = "select u.cod_usuario, u.nome, u.senha, u.nome_completo, p.perfil_desc," +
                "u.ativo, u.perfil from usuarios u inner join perfil_usuario p on u.perfil = p.cod_perfil";
            DataTable tb = new DataTable();

            using (SqlConnection conn = new SqlConnection(Conexao.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            tb.Load(reader);
                        }
                    }
                }
            }

            return tb;

        }

        /// <summary>
        /// Habilita as opções de menu de acordo com o perfil do usuário.
        /// </summary>
        /// <param name="xCodigoUsuario">Código do usuário para verificar o perfil do mesmo</param>
        /// <returns>Retorna o perfil do usuário</returns>
        public int VerificaPermissaoMenu(int xCodigoUsuario)
        {
            int resultado = 0;
            string strSQL = "Select perfil from usuarios where cod_usuario = " + xCodigoUsuario;

            using (SqlConnection conn = new SqlConnection(Conexao.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            resultado = Convert.ToInt32(dr["perfil"].ToString());
                        }
                    }
                }
            }

            return resultado;
        }

        public void RetornaRegistro(string xNomeUsuario)
        {
            string strSQL = "select * from usuarios where nome = " + Geral.AspasSQL(xNomeUsuario);

            using (SqlConnection conn = new SqlConnection(Conexao.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CodigoUsuario = Convert.ToInt32(dr["cod_usuario"].ToString());
                            NomeUsuario = dr["nome"].ToString();
                            SenhaUsuario = Criptografia.TextoDescriptografado(dr["senha"].ToString());
                            NomeCompletoUsuario = dr["nome_completo"].ToString();
                            Perfil = Convert.ToInt32(dr["perfil"].ToString());
                            Ativo = Convert.ToBoolean(dr["ativo"].ToString());
                        }

                    }
                }
            }

        }

        //Retorna os dados dos usuários logados, a partir do fornecimento do codigo do usuário
        public void RetornaRegistro(int xCodigoUsuario)
        {
            string strSQL = "select * from usuarios where cod_usuario = " + xCodigoUsuario;

            using (SqlConnection conn = new SqlConnection(Conexao.stringConexao))
            {
;                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = strSQL;
                    conn.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CodigoUsuario = Convert.ToInt32(dr["cod_usuario"].ToString());
                            NomeUsuario = dr["nome"].ToString();
                            SenhaUsuario = Criptografia.TextoDescriptografado(dr["senha"].ToString());
                            NomeCompletoUsuario = dr["nome_completo"].ToString();
                            Perfil = Convert.ToInt32(dr["perfil"].ToString());
                            Ativo = Convert.ToBoolean(dr["ativo"].ToString());
                        }
                    }
                }
            }

        }

        public DataTable PerfilUsuario()
        {
            DataTable tb = new DataTable();

            using (SqlConnection conn = new SqlConnection(Conexao.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from perfil_usuario";
                    using (var reader = cmd.ExecuteReader())
                    {
                        tb.Load(reader);
                    }
                }
            }

            return tb;
        }


        public DataTable ProcedimentoAcesso()
        {
            string strSQL = "select * from procedimentos_acesso";
            DataTable tb = new DataTable();

            using (SqlConnection conn = new SqlConnection(Conexao.stringConexao))
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

        public DataTable RetornaAcessoPadraoPerfil(int xPerfil)
        {
            string strSQL = "select * from perfil_usuario_padrao where cod_perfil = " + xPerfil;
            DataTable tb = new DataTable();

            using (SqlConnection conn = new SqlConnection(Conexao.stringConexao))
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

        private int VerificaCampos()
        {
            int indice = 0;

            if (string.IsNullOrEmpty(NomeUsuario))
            {
                indice = 1;
            }
            else if (string.IsNullOrEmpty(SenhaUsuario))
            {
                indice = 2;
            }
            else if (string.IsNullOrEmpty(Perfil.ToString()))
            {
                indice = 3;
            }

            return indice;
        }

        public bool CamposObrigatorios()
        {
            bool bResultado = false;

            switch (VerificaCampos())
            {
                case 1:
                    MensagemRetorno = "Campo nome de usuário é obrigatório!!";
                    bResultado = true;
                break;
                case 2:
                    MensagemRetorno = "Campo senha de usuário é obrigatório!!";
                    bResultado = true;
                    break;
                case 3:
                    MensagemRetorno = "Campo perfil de usuário é obrigatório!!";
                    bResultado = true;
                    break;
            }

            return bResultado;
        }

        /// <summary>
        /// Usada para resetar a senha do usuário para o padrão 12345
        /// </summary>
        /// <param name="xCodigoUsuario">Código do usuário</param>
        /// <returns>Retornará verdadeiro caso corro rudo certo com a instrução</returns>
        public bool ResetaSenha(int xCodigoUsuario)
        {
            bool bResultado = false;

            string strSQL = "update usuarios set senha = " +
                Geral.AspasSQL(Criptografia.TextoCriptografado(_resetaSenha)) +
                " where cod_usuario = " + CodigoUsuario;

            if (Conexao.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                MensagemRetorno = "Sua senha foi resetada para: " + _resetaSenha.ToString();
                bResultado = true;
            }

            return bResultado;
        }

    }

}
