using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace MRUtil
{
    public class NFeFuncoesEnvioAPI
    {
        public string ServdorUrl { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string MensagemRetorno { get; set; }

        public string Request(string _requestData, string _documento, string _route, string _method)
        {
            if (_method == "POST")
            {
                return PostRequest(_requestData, _documento, _route);
            }
            else
            {
                return GetRequest(_requestData, _documento, _route);
            }
        }

        public string PostRequest(string post_requestData, string post_documento, string post_route)
        {
            string Result;
            //Cria a rota para o servidor da requisição
            WebRequest request = WebRequest.Create(ServdorUrl + "ManagerAPIWeb/" + post_documento.ToLower() + "/" + post_route);
            //Define o formato da requisição
            request.ContentType = "application/x-www-form-urlencoded";
            //Monta a hash de autorização
            byte[] credentials = new UTF8Encoding().GetBytes(Usuario + ":" + Senha);
            //Converte a hash de autorização para o header da requisição
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(credentials);
            MensagemRetorno = request.Headers["Authorization"];
            //Define o método da requisição
            request.Method = "POST";
            //Encoda o conteúdo da requisição em um array de bytes
            byte[] byteArray = Encoding.UTF8.GetBytes(post_requestData);
            //Define o tamanho da requisição
            request.ContentLength = byteArray.Length;
            MensagemRetorno = ServdorUrl + "ManagerAPIWeb/" + post_documento.ToLower() + "/" + post_route;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            //Captura a resposta da requisição
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            //Implementa um TextReader que lê caracteres de um fluxo de bytes em uma codificação específica.
            StreamReader reader = new StreamReader(dataStream);
            Result = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();

            return Result;
        }

        public string GetRequest(string get_requestData, string get_documento, string get_route)
        {
            string Result;
            if (ServdorUrl.Contains("PesquisarNCM"))
            {
                string urlNCM = ServdorUrl + "?" + get_requestData;
                WebClient _requestNCM = new WebClient();
                Result = _requestNCM.DownloadString(urlNCM);
            }
            else
            {
                string url = ServdorUrl + "ManagerAPIWeb/" + get_documento.ToLower() + "/" + get_route + "?" + get_requestData;
                WebClient _request = new WebClient();
                byte[] credentials = new UTF8Encoding().GetBytes(Usuario + ":" + Senha);
                _request.Headers[HttpRequestHeader.Authorization] = "Basic " + Convert.ToBase64String(credentials);
                MensagemRetorno = _request.Headers["Authorization"];
                MensagemRetorno = url;
                Result = "";
                try
                {
                    Result = _request.DownloadString(url);
                }
                catch (Exception error)
                {
                    Result = "Não Foi Possível Concluir a Requisição.\n" +
                        "- - - - - - - - - - - - - ERRO - - - - - - - - - - - - -\n" + error.ToString();
                }
            }
            return Result;
        }
    }
}
