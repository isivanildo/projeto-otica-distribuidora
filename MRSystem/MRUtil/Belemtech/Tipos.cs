using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRUtil.Belemtech
{
    public enum TiposReg
    {
        Novo = 1,
        Salvar = 2,
        Excluir = 3,
        Alterar = 4,
        Cancelar = 5,
        NovoDoc = 6,
        GerarNFE = 7,
        EmitirNFE = 8,
        Localizar = 9,
        EntrarPacote = 10
    }

    public enum TipoAviso
    {
        OK = 1,
        SIMNAO = 2
    }

    public enum Respo
    {
        SIM = 1,
        NAO = 2,
        OK = 3,
        Cancel = 4

    }

    public enum ImagemAviso
    {
        Informacao = 1,
        Advertencia = 2,
        Error = 3
    }
}
