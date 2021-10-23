using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRSystem.classes
{
    class Emitente
    {
        public string CnpjCpf { get; set; }
        public int Filial { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int Cidade { get; set; }
        public int Uf { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }
        public int TipoInscricao { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public int RegimeTributario { get; set; }
        public int Cnae { get; set; }
        public int Serie { get; set; }
        public int Modelo { get; set; }
        public string Certificado { get; set; }
        public byte LogoTipo { get; set; }
        public string Email { get; set; }
        public string ZonaHraria { get; set; }
        public bool Producao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }



    }
}
