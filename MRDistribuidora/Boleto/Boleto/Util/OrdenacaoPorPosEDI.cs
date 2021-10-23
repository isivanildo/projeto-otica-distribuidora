using System.Collections.Generic;

namespace Boleto2Net
{
    //Classes b�sicas para manipula��o de registros para gera��o/interpreta��o de EDI

    /// <summary>
    /// Classe para ordena��o pela propriedade Posi��o no Registro EDI
    /// </summary>
    internal class OrdenacaoPorPosEDI : IComparer<TCampoRegistroEDI>
    {
        public int Compare(TCampoRegistroEDI x, TCampoRegistroEDI y)
        {
            return x.OrdemNoRegistroEDI.CompareTo(y.OrdemNoRegistroEDI);
        }
    }
}
