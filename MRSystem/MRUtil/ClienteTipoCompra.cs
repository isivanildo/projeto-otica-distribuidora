using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class ClienteTipoCompra
    {
        public int CodigoTipoCompra { get; set; }
        public string DescricaoCompra { get; set; }

        ConexaoDB ConnDB = new ConexaoDB();

        public ClienteTipoCompra() { }

        public bool SalvaTipoCompra()
        {
            bool bResultado = false;

            string strSQL = "insert into tipo_compra(codigo, descricao) values(" + CodigoTipoCompra + "," +
                Geral.AspasSQL(DescricaoCompra) + ")";
            if (ConnDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;

        }

        public bool AtualizaTipoCompra()
        {
            bool bResultado = false;

            string strSQL = "update tipo_compra set descricao = " + Geral.AspasSQL(DescricaoCompra) +
                " where codigo = " + CodigoTipoCompra;

            if (ConnDB.SalvaAtualizaExcluiReg(strSQL) == true)
            {
                bResultado = true;
            }

            return bResultado;
        }

        public List<ClienteTipoCompra> RetornaRegistro()
        {
            List<ClienteTipoCompra> _lista = new List<ClienteTipoCompra>();

            ConnDB.AbreConexaoBanco();

            using (var cmd = ConnDB.Conn.CreateCommand())
            {
                cmd.CommandText = "select * from tipo_compra"; 
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        _lista.Add(new ClienteTipoCompra()
                        {
                            CodigoTipoCompra = Convert.ToInt32(reader["codigo"]),
                            DescricaoCompra = reader["descricao"].ToString()
                        });
                    }
                }

            }

            return _lista;
        }
    }
}
