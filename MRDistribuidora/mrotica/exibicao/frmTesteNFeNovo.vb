Imports System.IO
Imports System.Web
Imports MRUtil
Public Class frmTesteNFeNovo

    Public requestData As String
    Private Sub frmTesteNFeNovo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSendRequest_Click(sender As Object, e As EventArgs) Handles btnSendRequest.Click
        Dim teste As NFeFuncoesEnvioAPI = New NFeFuncoesEnvioAPI()
        Dim strCaminho As String = AppDomain.CurrentDomain.BaseDirectory + "Arquivo.tx2"

        Dim arquivo As StreamReader = New StreamReader(strCaminho)

        mmRetEnv.Text = "Processando Requisição..."
        requestData = "encode=true&cnpj=" & edtCnpj.Text & "&grupo=" & edtGrupo.Text &
                "&arquivo=" & HttpUtility.UrlEncode(arquivo.ReadToEnd())
        teste.ServdorUrl = cbServidor.Text
        teste.Senha = edtSenha.Text
        teste.Usuario = edtUsuario.Text
        mmRetEnv.Text = teste.Request(requestData, cbDocumento.Text, tbControl.SelectedTab.Text.ToLower(), "POST")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim caminho As String = AppDomain.CurrentDomain.BaseDirectory & "Arquivo.tx2"

        Dim arquivo As StreamWriter

        If File.Exists(caminho) = False Then
            arquivo = File.CreateText(caminho)
        Else
            arquivo = File.AppendText(caminho)
        End If

        arquivo.WriteLine("FORMATO=tx2")
        arquivo.WriteLine("INCLUIR")
        arquivo.WriteLine("Id_A03=" & "0") 'Campo de preenchimento automático, não é necessário informar
        arquivo.WriteLine("versao_A02=" & "4.00") 'Exemplo de preenchimento: 4.00
        arquivo.WriteLine("cUF_B02=" & "15") '/Exemplo de preenchimento: 41 (Paraná)
        arquivo.WriteLine("cNF_B03=" & "1") 'Campo de preenchimento livre, de controle a critério Do desevolvedor
        arquivo.WriteLine("natOp_B04=" & "VENDA DE MERCADORIA ADQ. DE TERCEIRO - PF E PJ NAO CONTRIBUI")
        arquivo.WriteLine("mod_B06=" & "55") 'Exemplo de preenchimento: 55 para NFe
        arquivo.WriteLine("serie_B07=" & "1") 'Informação obtida com o contador Do emissor
        arquivo.WriteLine("nNF_B08=" & "1") 'Numeração da NFe, deve ser Sequência l e não pode se repetir dentro da mesma série
        arquivo.WriteLine("DHEMI_B09=" + DateTime.UtcNow)
        arquivo.WriteLine("DHSAIENT_B10=" & "2019-08-12T17:00:00-03:00")
        arquivo.WriteLine("tpNF_B11=" & "1") '0=Entrada; 1=Saída
        arquivo.WriteLine("IDDEST_B11A=" & "1") '1=Operação interna; 2=Operação interestadual; 3=Operação com exterior.
        arquivo.WriteLine("cMunFG_B12=" & "1501402") '/Informar o município de ocorrência Do fato gerador Do ICMS.Utilizar códigos Do IBGE

        arquivo.WriteLine("tpImp_B21=" + "1") '0=Sem geração de DANFE; 1=DANFE normal, Retrato; 2=DANFE normal, Paisagem; 3=DANFE Simplificado;
        arquivo.WriteLine("tpEmis_B22=" + "1") '1=Emissão normal (não em contingência) 2 = Contingência FS - IA, com impressão Do DANFE em formulário de segurança
        ' 3 = Contingência SCAN(Sistema de Contingência do Ambiente Nacional) 4 = Contingência DPEC(Declaração Prévia da Emissão em Contingência)
        '5 = Contingência FS - DA, com impressão do DANFE em formulário de segurança 6 = Contingência SVC - AN(SEFAZ Virtual de Contingência do AN)
        ' 7 = Contingência SVC - RS(SEFAZ Virtual de Contingência do RS)
        arquivo.WriteLine("cDV_B23=" & "0")
        arquivo.WriteLine("tpAmb_B24=" & "2")
        arquivo.WriteLine("finNFe_B25=" & "1")
        arquivo.WriteLine("INDFINAL_B25A=" & "1")
        arquivo.WriteLine("INDPRES_B25B=" & "1")
        arquivo.WriteLine("procEmi_B26=" & "0")
        arquivo.WriteLine("verProc_B27=" & "5")

        arquivo.WriteLine("")

        arquivo.WriteLine("CRT_C21=3")
        arquivo.WriteLine("CNPJ_C02=34164396000124")
        arquivo.WriteLine("xNome_C03=A L TAVEIRA")
        arquivo.WriteLine("xFant_C04=ANA MARIA")
        arquivo.WriteLine("xLgr_C06=TRAVESSA PADRE EUTIQUIO")
        arquivo.WriteLine("nro_C07=2656")
        arquivo.WriteLine("xBairro_C09=BATISTA CAMPOS")
        arquivo.WriteLine("cMun_C10=1501402")
        arquivo.WriteLine("xMun_C11=BELEM")
        arquivo.WriteLine("UF_C12=PA")
        arquivo.WriteLine("CEP_C13=66083100")
        arquivo.WriteLine("cPais_C14=1058")
        arquivo.WriteLine("xPais_C15=BRASIL")
        arquivo.WriteLine("fone_C16=91984117203")
        arquivo.WriteLine("IE_C17=156522004")

        arquivo.WriteLine("")

        arquivo.WriteLine("CNPJ_E02=10465424000185")
        arquivo.WriteLine("IDESTRANGEIRO_E03A=")
        arquivo.WriteLine("xNome_E04=NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL")
        arquivo.WriteLine("xLgr_E06=RUA DO CENTRO")
        arquivo.WriteLine("nro_E07=897")
        arquivo.WriteLine("xBairro_E09=CENTRAL")
        arquivo.WriteLine("cMun_E10=3550308")
        arquivo.WriteLine("xMun_E11=sao paulo")
        arquivo.WriteLine("UF_E12=SP")
        arquivo.WriteLine("CEP_E13=87500000")
        arquivo.WriteLine("cPais_E14=1058")
        arquivo.WriteLine("xPais_E15=BRASIL")
        arquivo.WriteLine("fone_E16=445555555")
        arquivo.WriteLine("INDIEDEST_E16A=1")
        arquivo.WriteLine("IE_E17=257036006115")
        arquivo.WriteLine("IM_E18A=")

        arquivo.WriteLine("")

        arquivo.Write("email_e19=")

        arquivo.WriteLine("")

        arquivo.WriteLine("CNPJ_GA02=")

        arquivo.WriteLine("")

        arquivo.WriteLine("INCLUIRITEM")
        arquivo.WriteLine("nItem_H02=1")
        arquivo.WriteLine("cProd_I02=0999")
        arquivo.WriteLine("cEAN_I03=")
        arquivo.WriteLine("xProd_I04=ARMACAO ANGELO FALCONI")
        arquivo.WriteLine("NCM_I05=11081200")
        arquivo.WriteLine("CEST_I05c=0123456")
        arquivo.WriteLine("indEscala_I05d=S")
        arquivo.WriteLine("CFOP_I08=5102")
        arquivo.WriteLine("uCom_I09=UN")
        arquivo.WriteLine("qCom_I10=2")
        arquivo.WriteLine("vUnCom_I10a=0.2000")
        arquivo.WriteLine("vProd_I11=0.40")
        arquivo.WriteLine("cEANTrib_I12=")
        arquivo.WriteLine("uTrib_I13=UN")
        arquivo.WriteLine("qTrib_I14=2")
        arquivo.WriteLine("vUnTrib_I14a=0.2000")
        arquivo.WriteLine("indTot_I17b=1")
        arquivo.WriteLine("orig_N11=0")
        arquivo.WriteLine("CST_N12=00")
        arquivo.WriteLine("modBC_N13=0")
        arquivo.WriteLine("vBC_N15=0.40")
        arquivo.WriteLine("pICMS_N16=17.00")
        arquivo.WriteLine("vICMS_N17=0.06")
        arquivo.WriteLine("VICMSDESON_N28A=0.00")
        arquivo.WriteLine("")

        arquivo.WriteLine("CST_Q06=01")
        arquivo.WriteLine("vBC_Q07=0.40")
        arquivo.WriteLine("pPIS_Q08=1.65")
        arquivo.WriteLine("vPIS_Q09=0.00")
        arquivo.WriteLine("")

        arquivo.WriteLine("CST_S06=01")
        arquivo.WriteLine("vBC_S07=0.40")
        arquivo.WriteLine("pCOFINS_S08=7.60")
        arquivo.WriteLine("vCOFINS_S11=0.03")
        arquivo.WriteLine("")

        arquivo.WriteLine("nLote_I81=123")
        arquivo.WriteLine("qLote_I82=5565.000")
        arquivo.WriteLine("dFab_I83=2017-07-23")
        arquivo.WriteLine("dVal_I84=2018-07-23")
        arquivo.WriteLine("")

        arquivo.WriteLine("SALVARITEM")
        arquivo.WriteLine("")

        arquivo.WriteLine("vBC_W03=0.40")
        arquivo.WriteLine("vICMS_W04=0.06")
        arquivo.WriteLine("vICMSDeson_W04a=0.00")
        arquivo.WriteLine("vFCP_W04h=0.00")
        arquivo.WriteLine("vBCST_W05=0.00")
        arquivo.WriteLine("vST_W06=0.00")
        arquivo.WriteLine("vFCPST_W06a=0.00")
        arquivo.WriteLine("vFCPSTRet_W06b=0.00")
        arquivo.WriteLine("vST_W06=0.00")
        arquivo.WriteLine("vFCPST_W06a=0.00")
        arquivo.WriteLine("vFCPSTRet_W06b=0.00")
        arquivo.WriteLine("vProd_W07=0.40")
        arquivo.WriteLine("vFrete_W08=0.00")
        arquivo.WriteLine("vSeg_W09=0.00")
        arquivo.WriteLine("vDesc_W10=0.00")
        arquivo.WriteLine("vII_W11=0.00")
        arquivo.WriteLine("vIPI_W12=0.00")
        arquivo.WriteLine("vIPIDevol_W12a=0.00")
        arquivo.WriteLine("vPIS_W13=0.00")
        arquivo.WriteLine("vCOFINS_W14=0.03")
        arquivo.WriteLine("vOutro_W15=0.00")
        arquivo.WriteLine("vNF_W16=0.40")
        arquivo.WriteLine("")

        arquivo.WriteLine("modFrete_X02=0")
        arquivo.WriteLine("")

        arquivo.WriteLine("nFat_Y03=2000")
        arquivo.WriteLine("vOrig_Y04=0.10")
        arquivo.WriteLine("vDesc_Y05=0.08")
        arquivo.WriteLine("vLiq_Y06=0.02")
        arquivo.WriteLine("")

        arquivo.WriteLine("INCLUIRPARTE=YA")
        arquivo.WriteLine("tPag_YA02=03")
        arquivo.WriteLine("vPag_YA03=0.01")
        arquivo.WriteLine("tpIntegra_YA04a=1")
        arquivo.WriteLine("CNPJ_YA05=57748734000170")
        arquivo.WriteLine("tBand_YA06=06")
        arquivo.WriteLine("cAut_YA07=12345")
        arquivo.WriteLine("SALVARPARTE=YA")
        arquivo.WriteLine("")

        arquivo.WriteLine("INCLUIRPARTE=YA")
        arquivo.WriteLine("tPag_YA02=01")
        arquivo.WriteLine("vPag_YA03=0.01")
        arquivo.WriteLine("SALVARPARTE=YA")
        arquivo.WriteLine("")
        arquivo.WriteLine("")

        arquivo.WriteLine("SALVAR")


        arquivo.Close()
    End Sub
End Class