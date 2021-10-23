namespace Boleto2Net
{
    /// <summary>
    /// Representa cada tipo de dado poss�vel em um arquivo EDI.
    /// </summary>
    public enum TTiposDadoEDI
    { 
        /// <summary>
        /// Representa um campo alfanum�rico, alinhado � esquerda e com brancos � direita. A propriedade ValorNatural � do tipo String
        /// </summary>
        ediAlphaAliEsquerda_____,
        /// <summary>
        /// Representa um campo alfanum�rico, alinhado � direita e com brancos � esquerda. A propriedade ValorNatural � do tipo String
        /// </summary>
        ediAlphaAliDireita______,
        /// <summary>
        /// Representa um campo num�rico inteiro alinhado � direita com zeros � esquerda. A propriedade ValorNatural � do tipo Int ou derivados
        /// </summary>
        ediInteiro______________,
        /// <summary>
        /// Representa um campo num�rico com decimais, sem o separador de decimal. A propriedade ValorNatural � do tipo Double
        /// </summary>
        ediNumericoSemSeparador_,
        /// <summary>
        /// Representa um campo num�rico com decimais, com o caracter ponto (.) como separador decimal,
        /// alinhado � direita com zeros � esquerda. A propriedade ValorNatural � do tipo Double
        /// </summary>
        ediNumericoComPonto_____,
        /// <summary>
        /// Representa um campo num�rico com decimais, com o caracter v�rgula (,) como separador decimal,
        /// alinhado � direita com zeros � esquerda. A propriedade ValorNatural � do tipo Double
        /// </summary>
        ediNumericoComVirgula___,
        /// <summary>
        /// Representa um campo de data no formato ddm/mm/aaaa. A propriedade ValorNatural � do tipo DateTime
        /// </summary>
        ediDataDDMMAAAA_________,
        /// <summary>
        /// Representa um campo de data no formato aaaa/mm/dd. A propriedade ValorNatural � do tipo DateTime
        /// </summary>
        ediDataAAAAMMDD_________,
        /// <summary>
        /// Representa um campo de data no formato dd/mm. A propriedade ValorNatural � do tipo DateTime, com o ano igual a 1900
        /// </summary>
        ediDataDDMM_____________,
        /// <summary>
        /// Representa um campo de data no formato mm/aaaa. A propriedade ValorNatural � do tipo DateTime, com o dia igual a 01
        /// </summary>
        ediDataMMAAAA___________,
        /// <summary>
        /// Representa um campo de data no formato mm/dd. A propriedade ValorNatural � do tipo DateTime com o ano igual a 1900
        /// </summary>
        ediDataMMDD_____________,
        /// <summary>
        /// Representa um campo de hora no formato HH:MM. A propriedade ValorNatural � do tipo DateTime, com a data igual a 01/01/1900
        /// </summary>
        ediHoraHHMM_____________,
        /// <summary>
        /// Representa um campo de hora no formato HH:MM:SS. A propriedade ValorNatural � do tipo DateTime, com a data igual a 01/01/1900
        /// </summary>
        ediHoraHHMMSS___________,
        /// <summary>
        /// Representa um campo de data no formato DD/MM/AAAA. A propriedade ValorNatural � do tipo DateTime.
        /// </summary>
        ediDataDDMMAA___________,
        /// <summary>
        /// Representa um campo de data no formato DD/MM/AAAA, por�m colocando zeros no lugar de espa�os no ValorFormatado. A propriedade
        /// ValorNatural � do tipo DateTime, e este deve ser nulo caso queira que a data seja zero.
        /// </summary>
        ediDataDDMMAAAAWithZeros,
        /// <summary>
        /// Representa um campo de data no formato AAAA/MM/DD, por�m colocando zeros no lugar de espa�os no ValorFormatado. A propriedade
        /// ValorNatural � do tipo DateTime, e este deve ser nulo caso queira que a data seja zero.
        /// </summary>
        ediDataAAAAMMDDWithZeros
    }
}