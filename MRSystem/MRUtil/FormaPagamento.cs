using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MRUtil
{
    public class FormaPagamento
    {
        public int CodigoFormaPagamento { get; set; }
        public string DescricaoFormaPagamento { get; set; }
        public string Status { get; set; }
        ConexaoDB connDB = new ConexaoDB();
        public FormaPagamento() { }

        public List<FormaPagamento> RetornaFormaPagamento()
        {
            List<FormaPagamento> _lista = new List<FormaPagamento>();

            using (SqlConnection conn = new SqlConnection(connDB.stringConexao))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from forma_pagamento where status = 'A'";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _lista.Add(new FormaPagamento()
                            {
                                CodigoFormaPagamento = Convert.ToInt32(reader["cod_forma_pagamento"]),
                                DescricaoFormaPagamento = reader["forma_pagamento"].ToString(),
                                Status = reader["status"].ToString()
                            });
                        }
                    }

                }
            }

            return _lista;
        }
    }
}
