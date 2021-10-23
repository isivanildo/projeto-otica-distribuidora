namespace Boleto2Net
{
    /// <summary>
    /// Indica os tipos de registro poss�veis em um arquivo EDI
    /// </summary>
    public enum TTipoRegistroEDI
    {
        /// <summary>
        /// Indicador de registro Header
        /// </summary>
        treHeader,
        /// <summary>
        /// Indica um registro detalhe
        /// </summary>
        treDetalhe,
        /// <summary>
        /// Indica um registro Trailler
        /// </summary>
        treTrailler,
        /// <summary>
        /// Indica um registro sem defini��es, utilizado para transmiss�o socket ou similar
        /// </summary>
        treLinhaUnica
    }
}