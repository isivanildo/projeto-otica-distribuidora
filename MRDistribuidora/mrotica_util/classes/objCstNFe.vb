Public Class objCstNFe

    Public Property CodigoNaturezaOperacao As Integer
    Public Property CodigoOrigemMercadoria As Integer
    Public Property CST As String
    Public Property CSOSN As String
    Public Property CST_PIS As String
    Public Property CST_COFINS As String
    Public Property ModBC As String
    Public Property ModBCST As String
    Public Property PIcms As Decimal
    Public Property PPIS As Decimal
    Public Property PCOFINS As Decimal
    Public Property PMVast As Decimal
    Public Property PRedBCST As Decimal
    Public Property PICMSST As Decimal
    Public Property PFCP As Decimal
    Public Property CFOP As String

    Dim d As New dados()


    Public Sub New()

    End Sub

    Public Sub SalvaAtualizaExcluiCst()
        Dim strSQL As String = String.Empty

        If (objGeral.TipoReg = "N"c) AndAlso (CST = "00") Then
            strSQL = "insert into cstfiscal (codigonat, cfop, origem, cst, modbc, picms, pfcp) values(" & CodigoNaturezaOperacao & "," &
                objGeral.AspasSQL(CFOP) & "," & CInt(CodigoOrigemMercadoria) & "," & objGeral.AspasSQL(CST) & "," & ModBC & "," &
                objGeral.ValorMoeda(PIcms) & "," & objGeral.ValorMoeda(PFCP) & ")"
        ElseIf (objGeral.TipoReg = "A"c) AndAlso (CST = "00") Then
            strSQL = "update cstfiscal set origem = " & CodigoOrigemMercadoria & "," & "cst = " & objGeral.AspasSQL(CST) & "," &
                "modbc = " & ModBC & "," & "picms = " & objGeral.ValorMoeda(PIcms) & "," & "pfcp = " + objGeral.ValorMoeda(PFCP) &
                " where codigonat = " + CodigoNaturezaOperacao
        ElseIf (objGeral.TipoReg = "E"c) AndAlso (CST = "00") Then
            strSQL = "delete from cstfiscal where codigonat = " & CodigoNaturezaOperacao
        End If

        d.Comando(strSQL, True)
    End Sub

    Public Sub RetornaRegistro(ByVal codigoNatrurezaOp As Integer)
        Dim instrucaoSQL As String = "select * from CstFiscal where codigonat = " & codigoNatrurezaOp
        Dim tb As New DataTable()

        d.carrega_Tabela(instrucaoSQL, tb)

        If tb.Rows.Count > 0 Then
            CodigoNaturezaOperacao = Convert.ToInt16(tb.Rows(0)("codigonat").ToString())
            CFOP = tb.Rows(0)("cfop").ToString()
            CodigoOrigemMercadoria = Convert.ToInt32(tb.Rows(0)("origem").ToString())
            CST = tb.Rows(0)("cst").ToString()
            CSOSN = tb.Rows(0)("csosn").ToString()
            ModBC = tb.Rows(0)("modbc").ToString()
            PIcms = Convert.ToDecimal(tb.Rows(0)("picms").ToString())
            ModBCST = tb.Rows(0)("modbcst").ToString()
            PMVast = Convert.ToDecimal(tb.Rows(0)("pmvast").ToString())
            PRedBCST = Convert.ToDecimal(tb.Rows(0)("predbcst").ToString())
            PICMSST = Convert.ToDecimal(tb.Rows(0)("picmsst").ToString())
            PFCP = Convert.ToDecimal(tb.Rows(0)("pfcp").ToString())
            CST_PIS = tb.Rows(0)("cst_pis").ToString()
            PPIS = Convert.ToDecimal(tb.Rows(0)("ppis").ToString())
            CST_COFINS = tb.Rows(0)("cst_cofins").ToString()
            PCOFINS = Convert.ToDecimal(tb.Rows(0)("pcofins").ToString())
        End If
    End Sub

End Class
