using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil
{
    public class EnderecoCli
    {
        Uf UF;
        Municipio cid;
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int CidadeIBGE { get; set; }
        public string NomeCidade { get; set; }
        public int UfIBGE { get; set; }
        public string Uf { get; set; }
        public int PaisIBGE { get; set; }
        public string Pais { get; set; }

        public EnderecoCli() { }

        public string RetornaEndereco(string cep)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                string strResultado = string.Empty; 
                try
                {
                    UF = new Uf();
                    cid = new Municipio();
                    var resultado = ws.consultaCEP(cep);

                    Logradouro = resultado.end;
                    Complemento = resultado.complemento2;
                    Bairro = resultado.bairro;
                    //UF.RetornaEstado(resultado.uf);
                    UfIBGE = UF.CodigoUF;
                    cid.RetornaCidade(resultado.cidade, UfIBGE);
                    CidadeIBGE = cid.CodigoCidade;

                    strResultado = "OK";
                }      
                catch (Exception ex)
                {
                    strResultado = ex.ToString();
                }

                return strResultado;
            }
        }

    }
}
