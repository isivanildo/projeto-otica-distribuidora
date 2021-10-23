using System;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace MRUtil
{
    public class BuscaCEP
    {
        public string MensagemRetorno { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Unidade { get; set; }
        public int IbgeCodigo { get; set; }
        public string GiaCodigo { get; set; }
        public string Ddd { get; set; }
        public string Siafi { get; set; }

        public BuscaCEP() { }

        public void RetornoCep(string xCep)
        {
            xCep = xCep.Replace("_", "");
            xCep = xCep.Replace("-", "");
            if (xCep == string.Empty)
            {
                MensagemRetorno = "Por favor informar um CEP válido.";
                return;
            }

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + xCep + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MensagemRetorno = "Servidor indisponível.";
                return;
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"","");

                        string[] substrings = response.Split('\n');

                        int cont = 0;

                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());

                                if (valor[0] == "  erro")
                                {
                                    MensagemRetorno = "CEP informado não encontrado.";
                                    return;
                                }

                                Cep = valor[1];

                            }

                            //Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                Logradouro = valor[1];
                            }

                            //Complemento
                            if (cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                Complemento = valor[1];
                            }

                            //Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                Bairro = valor[1];
                            }

                            //Localidade (Cidade)
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                Cidade = valor[1];
                            }

                            //Estado (UF)
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                UF = valor[1];
                            }

                            //Codigo Cidade (IBGE)
                            if (cont == 7)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                IbgeCodigo = Convert.ToInt32(valor[1]);
                            }

                            //Codigo gia - somente para localidade de São Paulo
                            if (cont == 8)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                GiaCodigo = valor[1];
                            }

                            //Código DDD
                            if (cont == 9)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                Ddd = valor[1];
                            }

                            //Código Siafi
                            if (cont == 10)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                Siafi = valor[1];
                            }


                            cont++;
                        }
                    }
                }
            }

        }
        
    }
}
