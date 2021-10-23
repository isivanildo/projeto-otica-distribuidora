Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports mrotica_util
Public Class rptOS
Inherits DataDynamics.ActiveReports.ActiveReport3
	Public Sub New()
	MyBase.New()
		InitializeComponent()
    End Sub

	#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Friend WithEvents subItens As SubReport
    Friend WithEvents PicExtra As Picture
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Line As Line
    Friend WithEvents Line1 As Line
    Friend WithEvents Line2 As Line
    Friend WithEvents Line5 As Line
    Friend WithEvents Line6 As Line
    Friend WithEvents Line7 As Line
    Friend WithEvents Label As Label
    Friend WithEvents fldLoja As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents fldOS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents fldEspecieOD As TextBox
    Friend WithEvents fldLenteOD As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents fldCodFabOE As TextBox
    Friend WithEvents fldLenteOE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Line8 As Line
    Friend WithEvents Label10 As Label
    Friend WithEvents fldNomeTabOE As TextBox
    Friend WithEvents fldTipoTAbOE As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents fldTipoTabOD As TextBox
    Friend WithEvents fldNomeTabOD As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents fldEsfODLonge As TextBox
    Friend WithEvents fldCilODLonge As TextBox
    Friend WithEvents fldEixoOD As TextBox
    Friend WithEvents fldDpOdLonge As TextBox
    Friend WithEvents fldAlturaOD As TextBox
    Friend WithEvents Line9 As Line
    Friend WithEvents lblData As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents fldEsfOeLonge As TextBox
    Friend WithEvents fldCilOELonge As TextBox
    Friend WithEvents fldEixo_oe As TextBox
    Friend WithEvents fldDnpOELonge As TextBox
    Friend WithEvents fldAlturaOE As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents fldEsfODPeerto As TextBox
    Friend WithEvents fldCilODPerto As TextBox
    Friend WithEvents fldDnpODPerto As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents fldEsfOEPerto As TextBox
    Friend WithEvents fldCilOEPerto As TextBox
    Friend WithEvents fldDNPOEPerto As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents fldBaseOD As TextBox
    Friend WithEvents fldBaseOE As TextBox
    Friend WithEvents fldAdicaoOE As TextBox
    Friend WithEvents fldAdicaoOD As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents fldDiametroOE As TextBox
    Friend WithEvents fldDiametroOD As TextBox
    Friend WithEvents Line10 As Line
    Friend WithEvents Label30 As Label
    Friend WithEvents Line11 As Line
    Friend WithEvents Line12 As Line
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents fldAroHorizontal As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents fldArmacao As Label
    Friend WithEvents Line13 As Line
    Friend WithEvents Label36 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Line14 As Line
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Line16 As Line
    Friend WithEvents fldCodFilialCliente As TextBox
    Friend WithEvents fldCodCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Barcode As Barcode
    Friend WithEvents txtTratamento As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Line15 As Line
    Friend WithEvents lblNpedido As Label
    Friend WithEvents lblLab As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Line3 As Line
    Friend WithEvents Line4 As Line
    Friend WithEvents Label42 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents fldOSLocal As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents fldLaborat As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents lblVia As Label
    Friend WithEvents lblextra As Label
    Friend WithEvents bcOtica As Barcode
    Friend WithEvents txtCodVendedora As TextBox
    Friend WithEvents txtVendedora As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txtNExtra As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents SubReport1 As SubReport
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptOS))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.subItens = New DataDynamics.ActiveReports.SubReport()
        Me.SubReport1 = New DataDynamics.ActiveReports.SubReport()
        Me.PicExtra = New DataDynamics.ActiveReports.Picture()
        Me.txtCliente = New DataDynamics.ActiveReports.TextBox()
        Me.Label13 = New DataDynamics.ActiveReports.Label()
        Me.Label19 = New DataDynamics.ActiveReports.Label()
        Me.Label18 = New DataDynamics.ActiveReports.Label()
        Me.Label17 = New DataDynamics.ActiveReports.Label()
        Me.Label16 = New DataDynamics.ActiveReports.Label()
        Me.Label15 = New DataDynamics.ActiveReports.Label()
        Me.Label29 = New DataDynamics.ActiveReports.Label()
        Me.Line = New DataDynamics.ActiveReports.Line()
        Me.Line1 = New DataDynamics.ActiveReports.Line()
        Me.Line2 = New DataDynamics.ActiveReports.Line()
        Me.Line5 = New DataDynamics.ActiveReports.Line()
        Me.Line6 = New DataDynamics.ActiveReports.Line()
        Me.Line7 = New DataDynamics.ActiveReports.Line()
        Me.Label = New DataDynamics.ActiveReports.Label()
        Me.fldLoja = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.fldOS = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.fldEspecieOD = New DataDynamics.ActiveReports.TextBox()
        Me.fldLenteOD = New DataDynamics.ActiveReports.TextBox()
        Me.Label6 = New DataDynamics.ActiveReports.Label()
        Me.fldCodFabOE = New DataDynamics.ActiveReports.TextBox()
        Me.fldLenteOE = New DataDynamics.ActiveReports.TextBox()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.Label9 = New DataDynamics.ActiveReports.Label()
        Me.Line8 = New DataDynamics.ActiveReports.Line()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.fldNomeTabOE = New DataDynamics.ActiveReports.TextBox()
        Me.fldTipoTAbOE = New DataDynamics.ActiveReports.TextBox()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.Label12 = New DataDynamics.ActiveReports.Label()
        Me.fldTipoTabOD = New DataDynamics.ActiveReports.TextBox()
        Me.fldNomeTabOD = New DataDynamics.ActiveReports.TextBox()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
        Me.Label20 = New DataDynamics.ActiveReports.Label()
        Me.fldEsfODLonge = New DataDynamics.ActiveReports.TextBox()
        Me.fldCilODLonge = New DataDynamics.ActiveReports.TextBox()
        Me.fldEixoOD = New DataDynamics.ActiveReports.TextBox()
        Me.fldDpOdLonge = New DataDynamics.ActiveReports.TextBox()
        Me.fldAlturaOD = New DataDynamics.ActiveReports.TextBox()
        Me.Line9 = New DataDynamics.ActiveReports.Line()
        Me.lblData = New DataDynamics.ActiveReports.Label()
        Me.Label21 = New DataDynamics.ActiveReports.Label()
        Me.fldEsfOeLonge = New DataDynamics.ActiveReports.TextBox()
        Me.fldCilOELonge = New DataDynamics.ActiveReports.TextBox()
        Me.fldEixo_oe = New DataDynamics.ActiveReports.TextBox()
        Me.fldDnpOELonge = New DataDynamics.ActiveReports.TextBox()
        Me.fldAlturaOE = New DataDynamics.ActiveReports.TextBox()
        Me.Label22 = New DataDynamics.ActiveReports.Label()
        Me.Label23 = New DataDynamics.ActiveReports.Label()
        Me.fldEsfODPeerto = New DataDynamics.ActiveReports.TextBox()
        Me.fldCilODPerto = New DataDynamics.ActiveReports.TextBox()
        Me.fldDnpODPerto = New DataDynamics.ActiveReports.TextBox()
        Me.Label24 = New DataDynamics.ActiveReports.Label()
        Me.fldEsfOEPerto = New DataDynamics.ActiveReports.TextBox()
        Me.fldCilOEPerto = New DataDynamics.ActiveReports.TextBox()
        Me.fldDNPOEPerto = New DataDynamics.ActiveReports.TextBox()
        Me.Label25 = New DataDynamics.ActiveReports.Label()
        Me.Label26 = New DataDynamics.ActiveReports.Label()
        Me.fldBaseOD = New DataDynamics.ActiveReports.TextBox()
        Me.fldBaseOE = New DataDynamics.ActiveReports.TextBox()
        Me.fldAdicaoOE = New DataDynamics.ActiveReports.TextBox()
        Me.fldAdicaoOD = New DataDynamics.ActiveReports.TextBox()
        Me.Label27 = New DataDynamics.ActiveReports.Label()
        Me.Label28 = New DataDynamics.ActiveReports.Label()
        Me.fldDiametroOE = New DataDynamics.ActiveReports.TextBox()
        Me.fldDiametroOD = New DataDynamics.ActiveReports.TextBox()
        Me.Line10 = New DataDynamics.ActiveReports.Line()
        Me.Label30 = New DataDynamics.ActiveReports.Label()
        Me.Line11 = New DataDynamics.ActiveReports.Line()
        Me.Line12 = New DataDynamics.ActiveReports.Line()
        Me.Label31 = New DataDynamics.ActiveReports.Label()
        Me.Label32 = New DataDynamics.ActiveReports.Label()
        Me.Label33 = New DataDynamics.ActiveReports.Label()
        Me.Label34 = New DataDynamics.ActiveReports.Label()
        Me.fldAroHorizontal = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.fldArmacao = New DataDynamics.ActiveReports.Label()
        Me.Line13 = New DataDynamics.ActiveReports.Line()
        Me.Label36 = New DataDynamics.ActiveReports.Label()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.Label38 = New DataDynamics.ActiveReports.Label()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.Line14 = New DataDynamics.ActiveReports.Line()
        Me.Label39 = New DataDynamics.ActiveReports.Label()
        Me.Label40 = New DataDynamics.ActiveReports.Label()
        Me.Label41 = New DataDynamics.ActiveReports.Label()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.Label45 = New DataDynamics.ActiveReports.Label()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.Line16 = New DataDynamics.ActiveReports.Line()
        Me.fldCodFilialCliente = New DataDynamics.ActiveReports.TextBox()
        Me.fldCodCliente = New DataDynamics.ActiveReports.TextBox()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Barcode = New DataDynamics.ActiveReports.Barcode()
        Me.txtTratamento = New DataDynamics.ActiveReports.TextBox()
        Me.Label35 = New DataDynamics.ActiveReports.Label()
        Me.Line15 = New DataDynamics.ActiveReports.Line()
        Me.lblNpedido = New DataDynamics.ActiveReports.Label()
        Me.lblLab = New DataDynamics.ActiveReports.Label()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.Line3 = New DataDynamics.ActiveReports.Line()
        Me.Line4 = New DataDynamics.ActiveReports.Line()
        Me.Label42 = New DataDynamics.ActiveReports.Label()
        Me.Label46 = New DataDynamics.ActiveReports.Label()
        Me.fldOSLocal = New DataDynamics.ActiveReports.TextBox()
        Me.Label47 = New DataDynamics.ActiveReports.Label()
        Me.fldLaborat = New DataDynamics.ActiveReports.TextBox()
        Me.Label48 = New DataDynamics.ActiveReports.Label()
        Me.lblVia = New DataDynamics.ActiveReports.Label()
        Me.lblextra = New DataDynamics.ActiveReports.Label()
        Me.bcOtica = New DataDynamics.ActiveReports.Barcode()
        Me.txtCodVendedora = New DataDynamics.ActiveReports.TextBox()
        Me.txtVendedora = New DataDynamics.ActiveReports.TextBox()
        Me.Label37 = New DataDynamics.ActiveReports.Label()
        Me.txtNExtra = New DataDynamics.ActiveReports.TextBox()
        Me.Label43 = New DataDynamics.ActiveReports.Label()
        CType(Me.PicExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldLoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldEspecieOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldLenteOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCodFabOE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldLenteOE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldNomeTabOE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldTipoTAbOE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldTipoTabOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldNomeTabOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldEsfODLonge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCilODLonge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldEixoOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDpOdLonge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldAlturaOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldEsfOeLonge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCilOELonge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldEixo_oe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDnpOELonge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldAlturaOE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldEsfODPeerto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCilODPerto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDnpODPerto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldEsfOEPerto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCilOEPerto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDNPOEPerto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldBaseOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldBaseOE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldAdicaoOE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldAdicaoOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDiametroOE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDiametroOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldAroHorizontal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldArmacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCodFilialCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCodCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTratamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNpedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldOSLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldLaborat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblVia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblextra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodVendedora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVendedora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.subItens, Me.SubReport1, Me.PicExtra, Me.txtCliente, Me.Label13, Me.Label19, Me.Label18, Me.Label17, Me.Label16, Me.Label15, Me.Label29, Me.Line, Me.Line1, Me.Line2, Me.Line5, Me.Line6, Me.Line7, Me.Label, Me.fldLoja, Me.Label1, Me.fldOS, Me.Label2, Me.Label3, Me.Label5, Me.fldEspecieOD, Me.fldLenteOD, Me.Label6, Me.fldCodFabOE, Me.fldLenteOE, Me.Label7, Me.Label8, Me.Label9, Me.Line8, Me.Label10, Me.fldNomeTabOE, Me.fldTipoTAbOE, Me.Label11, Me.Label12, Me.fldTipoTabOD, Me.fldNomeTabOD, Me.Label14, Me.Label20, Me.fldEsfODLonge, Me.fldCilODLonge, Me.fldEixoOD, Me.fldDpOdLonge, Me.fldAlturaOD, Me.Line9, Me.lblData, Me.Label21, Me.fldEsfOeLonge, Me.fldCilOELonge, Me.fldEixo_oe, Me.fldDnpOELonge, Me.fldAlturaOE, Me.Label22, Me.Label23, Me.fldEsfODPeerto, Me.fldCilODPerto, Me.fldDnpODPerto, Me.Label24, Me.fldEsfOEPerto, Me.fldCilOEPerto, Me.fldDNPOEPerto, Me.Label25, Me.Label26, Me.fldBaseOD, Me.fldBaseOE, Me.fldAdicaoOE, Me.fldAdicaoOD, Me.Label27, Me.Label28, Me.fldDiametroOE, Me.fldDiametroOD, Me.Line10, Me.Label30, Me.Line11, Me.Line12, Me.Label31, Me.Label32, Me.Label33, Me.Label34, Me.fldAroHorizontal, Me.TextBox1, Me.TextBox3, Me.TextBox4, Me.fldArmacao, Me.Line13, Me.Label36, Me.TextBox5, Me.Label38, Me.TextBox7, Me.Line14, Me.Label39, Me.Label40, Me.Label41, Me.TextBox8, Me.Label45, Me.TextBox9, Me.Line16, Me.fldCodFilialCliente, Me.fldCodCliente, Me.Label4, Me.Barcode, Me.txtTratamento, Me.Label35, Me.Line15, Me.lblNpedido, Me.lblLab, Me.TextBox10, Me.TextBox11, Me.Line3, Me.Line4, Me.Label42, Me.Label46, Me.fldOSLocal, Me.Label47, Me.fldLaborat, Me.Label48, Me.lblVia, Me.lblextra, Me.bcOtica, Me.txtCodVendedora, Me.txtVendedora, Me.Label37, Me.txtNExtra, Me.Label43})
        Me.Detail.Height = 9.34375!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        '
        'subItens
        '
        Me.subItens.Border.BottomColor = System.Drawing.Color.Black
        Me.subItens.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subItens.Border.LeftColor = System.Drawing.Color.Black
        Me.subItens.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subItens.Border.RightColor = System.Drawing.Color.Black
        Me.subItens.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subItens.Border.TopColor = System.Drawing.Color.Black
        Me.subItens.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.subItens.CloseBorder = False
        Me.subItens.Height = 0.1875!
        Me.subItens.Left = 0!
        Me.subItens.Name = "subItens"
        Me.subItens.Report = Nothing
        Me.subItens.Top = 0!
        Me.subItens.Width = 7.5625!
        '
        'SubReport1
        '
        Me.SubReport1.Border.BottomColor = System.Drawing.Color.Black
        Me.SubReport1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport1.Border.LeftColor = System.Drawing.Color.Black
        Me.SubReport1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport1.Border.RightColor = System.Drawing.Color.Black
        Me.SubReport1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport1.Border.TopColor = System.Drawing.Color.Black
        Me.SubReport1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.SubReport1.CloseBorder = False
        Me.SubReport1.Height = 0.1875!
        Me.SubReport1.Left = 0!
        Me.SubReport1.Name = "SubReport1"
        Me.SubReport1.Report = Nothing
        Me.SubReport1.Top = 0.3125!
        Me.SubReport1.Width = 7.5625!
        '
        'PicExtra
        '
        Me.PicExtra.Border.BottomColor = System.Drawing.Color.Black
        Me.PicExtra.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.PicExtra.Border.LeftColor = System.Drawing.Color.Black
        Me.PicExtra.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.PicExtra.Border.RightColor = System.Drawing.Color.Black
        Me.PicExtra.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.PicExtra.Border.TopColor = System.Drawing.Color.Black
        Me.PicExtra.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.PicExtra.Height = 5.0625!
        Me.PicExtra.Image = CType(resources.GetObject("PicExtra.Image"), System.Drawing.Image)
        Me.PicExtra.ImageData = CType(resources.GetObject("PicExtra.ImageData"), System.IO.Stream)
        Me.PicExtra.Left = 0!
        Me.PicExtra.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PicExtra.LineWeight = 0!
        Me.PicExtra.Name = "PicExtra"
        Me.PicExtra.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
        Me.PicExtra.Top = 0.625!
        Me.PicExtra.Visible = False
        Me.PicExtra.Width = 7.125!
        '
        'txtCliente
        '
        Me.txtCliente.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCliente.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCliente.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.Border.RightColor = System.Drawing.Color.Black
        Me.txtCliente.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.Border.TopColor = System.Drawing.Color.Black
        Me.txtCliente.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCliente.DataField = "NOME_CLIENTE"
        Me.txtCliente.Height = 0.16875!
        Me.txtCliente.Left = 0.5625!
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.OutputFormat = resources.GetString("txtCliente.OutputFormat")
        Me.txtCliente.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; "
        Me.txtCliente.Text = "TextBox1"
        Me.txtCliente.Top = 4.1875!
        Me.txtCliente.Width = 3.25!
        '
        'Label13
        '
        Me.Label13.Border.BottomColor = System.Drawing.Color.Black
        Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.LeftColor = System.Drawing.Color.Black
        Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.RightColor = System.Drawing.Color.Black
        Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.TopColor = System.Drawing.Color.Black
        Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Height = 0.1479167!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label13.Text = "dioptria:"
        Me.Label13.Top = 2.4375!
        Me.Label13.Width = 0.5520833!
        '
        'Label19
        '
        Me.Label19.Border.BottomColor = System.Drawing.Color.Black
        Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.LeftColor = System.Drawing.Color.Black
        Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.RightColor = System.Drawing.Color.Black
        Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.TopColor = System.Drawing.Color.Black
        Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Height = 0.1479167!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 3.25!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.Label19.Text = "Altura"
        Me.Label19.Top = 2.4375!
        Me.Label19.Width = 0.3645833!
        '
        'Label18
        '
        Me.Label18.Border.BottomColor = System.Drawing.Color.Black
        Me.Label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.LeftColor = System.Drawing.Color.Black
        Me.Label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.RightColor = System.Drawing.Color.Black
        Me.Label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.TopColor = System.Drawing.Color.Black
        Me.Label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Height = 0.1479167!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 2.75!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.Label18.Text = "DNP"
        Me.Label18.Top = 2.4375!
        Me.Label18.Width = 0.3020833!
        '
        'Label17
        '
        Me.Label17.Border.BottomColor = System.Drawing.Color.Black
        Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.LeftColor = System.Drawing.Color.Black
        Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.RightColor = System.Drawing.Color.Black
        Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.TopColor = System.Drawing.Color.Black
        Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Height = 0.1479167!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 2.3125!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.Label17.Text = "Eixo"
        Me.Label17.Top = 2.4375!
        Me.Label17.Width = 0.25!
        '
        'Label16
        '
        Me.Label16.Border.BottomColor = System.Drawing.Color.Black
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.LeftColor = System.Drawing.Color.Black
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.RightColor = System.Drawing.Color.Black
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.TopColor = System.Drawing.Color.Black
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Height = 0.1479167!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 1.5!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.Label16.Text = "Cil."
        Me.Label16.Top = 2.4375!
        Me.Label16.Width = 0.3958333!
        '
        'Label15
        '
        Me.Label15.Border.BottomColor = System.Drawing.Color.Black
        Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.LeftColor = System.Drawing.Color.Black
        Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.RightColor = System.Drawing.Color.Black
        Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.TopColor = System.Drawing.Color.Black
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Height = 0.1479167!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.9375!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.Label15.Text = "Esf."
        Me.Label15.Top = 2.4375!
        Me.Label15.Width = 0.3854167!
        '
        'Label29
        '
        Me.Label29.Border.BottomColor = System.Drawing.Color.Black
        Me.Label29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label29.Border.LeftColor = System.Drawing.Color.Black
        Me.Label29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label29.Border.RightColor = System.Drawing.Color.Black
        Me.Label29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label29.Border.TopColor = System.Drawing.Color.Black
        Me.Label29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label29.Height = 0.1479167!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 5.3125!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.Label29.Text = "Diametro"
        Me.Label29.Top = 2.4375!
        Me.Label29.Width = 0.4895833!
        '
        'Line
        '
        Me.Line.Border.BottomColor = System.Drawing.Color.Black
        Me.Line.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line.Border.LeftColor = System.Drawing.Color.Black
        Me.Line.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line.Border.RightColor = System.Drawing.Color.Black
        Me.Line.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line.Border.TopColor = System.Drawing.Color.Black
        Me.Line.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line.Height = 0!
        Me.Line.Left = 0!
        Me.Line.LineWeight = 1.0!
        Me.Line.Name = "Line"
        Me.Line.Top = 1.25!
        Me.Line.Width = 7.625!
        Me.Line.X1 = 0!
        Me.Line.X2 = 7.625!
        Me.Line.Y1 = 1.25!
        Me.Line.Y2 = 1.25!
        '
        'Line1
        '
        Me.Line1.Border.BottomColor = System.Drawing.Color.Black
        Me.Line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.LeftColor = System.Drawing.Color.Black
        Me.Line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.RightColor = System.Drawing.Color.Black
        Me.Line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.TopColor = System.Drawing.Color.Black
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Height = 0.6875!
        Me.Line1.Left = 0.6875!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.625!
        Me.Line1.Width = 0!
        Me.Line1.X1 = 0.6875!
        Me.Line1.X2 = 0.6875!
        Me.Line1.Y1 = 1.3125!
        Me.Line1.Y2 = 0.625!
        '
        'Line2
        '
        Me.Line2.Border.BottomColor = System.Drawing.Color.Black
        Me.Line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.LeftColor = System.Drawing.Color.Black
        Me.Line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.RightColor = System.Drawing.Color.Black
        Me.Line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.TopColor = System.Drawing.Color.Black
        Me.Line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Height = 0.625!
        Me.Line2.Left = 1.5625!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.625!
        Me.Line2.Width = 0!
        Me.Line2.X1 = 1.5625!
        Me.Line2.X2 = 1.5625!
        Me.Line2.Y1 = 1.25!
        Me.Line2.Y2 = 0.625!
        '
        'Line5
        '
        Me.Line5.Border.BottomColor = System.Drawing.Color.Black
        Me.Line5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.LeftColor = System.Drawing.Color.Black
        Me.Line5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.RightColor = System.Drawing.Color.Black
        Me.Line5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.TopColor = System.Drawing.Color.Black
        Me.Line5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Height = 0.625!
        Me.Line5.Left = 5.4375!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.8125!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 5.4375!
        Me.Line5.X2 = 5.4375!
        Me.Line5.Y1 = 2.4375!
        Me.Line5.Y2 = 1.8125!
        '
        'Line6
        '
        Me.Line6.Border.BottomColor = System.Drawing.Color.Black
        Me.Line6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.LeftColor = System.Drawing.Color.Black
        Me.Line6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.RightColor = System.Drawing.Color.Black
        Me.Line6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.TopColor = System.Drawing.Color.Black
        Me.Line6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Height = 0!
        Me.Line6.Left = 0!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.8125!
        Me.Line6.Width = 7.625!
        Me.Line6.X1 = 0!
        Me.Line6.X2 = 7.625!
        Me.Line6.Y1 = 1.8125!
        Me.Line6.Y2 = 1.8125!
        '
        'Line7
        '
        Me.Line7.Border.BottomColor = System.Drawing.Color.Black
        Me.Line7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.LeftColor = System.Drawing.Color.Black
        Me.Line7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.RightColor = System.Drawing.Color.Black
        Me.Line7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.TopColor = System.Drawing.Color.Black
        Me.Line7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Height = 1.3125!
        Me.Line7.Left = 3.75!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 2.4375!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 3.75!
        Me.Line7.X2 = 3.75!
        Me.Line7.Y1 = 3.75!
        Me.Line7.Y2 = 2.4375!
        '
        'Label
        '
        Me.Label.Border.BottomColor = System.Drawing.Color.Black
        Me.Label.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label.Border.LeftColor = System.Drawing.Color.Black
        Me.Label.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label.Border.RightColor = System.Drawing.Color.Black
        Me.Label.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label.Border.TopColor = System.Drawing.Color.Black
        Me.Label.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label.Height = 0.1479167!
        Me.Label.HyperLink = Nothing
        Me.Label.Left = 0!
        Me.Label.Name = "Label"
        Me.Label.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label.Text = "Estoque:"
        Me.Label.Top = 1.3125!
        Me.Label.Width = 1.0!
        '
        'fldLoja
        '
        Me.fldLoja.Border.BottomColor = System.Drawing.Color.Black
        Me.fldLoja.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLoja.Border.LeftColor = System.Drawing.Color.Black
        Me.fldLoja.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLoja.Border.RightColor = System.Drawing.Color.Black
        Me.fldLoja.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLoja.Border.TopColor = System.Drawing.Color.Black
        Me.fldLoja.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLoja.DataField = "cod_cliente"
        Me.fldLoja.Height = 0.1875!
        Me.fldLoja.Left = 0.0625!
        Me.fldLoja.Name = "fldLoja"
        Me.fldLoja.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 12pt; "
        Me.fldLoja.Text = "TextBox"
        Me.fldLoja.Top = 1.0625!
        Me.fldLoja.Width = 0.5729166!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Height = 0.1479167!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label1.Text = "Cliente:"
        Me.Label1.Top = 0.9375!
        Me.Label1.Width = 0.6354166!
        '
        'fldOS
        '
        Me.fldOS.Border.BottomColor = System.Drawing.Color.Black
        Me.fldOS.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldOS.Border.LeftColor = System.Drawing.Color.Black
        Me.fldOS.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldOS.Border.RightColor = System.Drawing.Color.Black
        Me.fldOS.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldOS.Border.TopColor = System.Drawing.Color.Black
        Me.fldOS.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldOS.DataField = "doc_cliente"
        Me.fldOS.Height = 0.1875!
        Me.fldOS.Left = 0.6875!
        Me.fldOS.Name = "fldOS"
        Me.fldOS.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 12pt; "
        Me.fldOS.Text = "TextBox"
        Me.fldOS.Top = 1.0625!
        Me.fldOS.Width = 0.8333333!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Height = 0.1479167!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.6875!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label2.Text = "OS Cliente"
        Me.Label2.Top = 0.9375!
        Me.Label2.Width = 0.8229167!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Height = 0.1479167!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.625!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label3.Text = "Data:"
        Me.Label3.Top = 0.625!
        Me.Label3.Width = 0.8645833!
        '
        'Label5
        '
        Me.Label5.Border.BottomColor = System.Drawing.Color.Black
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.LeftColor = System.Drawing.Color.Black
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.RightColor = System.Drawing.Color.Black
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.TopColor = System.Drawing.Color.Black
        Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Height = 0.1479167!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label5.Text = "OD:"
        Me.Label5.Top = 1.4375!
        Me.Label5.Width = 0.2395833!
        '
        'fldEspecieOD
        '
        Me.fldEspecieOD.Border.BottomColor = System.Drawing.Color.Black
        Me.fldEspecieOD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEspecieOD.Border.LeftColor = System.Drawing.Color.Black
        Me.fldEspecieOD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEspecieOD.Border.RightColor = System.Drawing.Color.Black
        Me.fldEspecieOD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEspecieOD.Border.TopColor = System.Drawing.Color.Black
        Me.fldEspecieOD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEspecieOD.DataField = "cod_produto_od"
        Me.fldEspecieOD.Height = 0.16875!
        Me.fldEspecieOD.Left = 0.3125!
        Me.fldEspecieOD.Name = "fldEspecieOD"
        Me.fldEspecieOD.Style = "ddo-char-set: 1; font-weight: normal; "
        Me.fldEspecieOD.Text = "TextBox"
        Me.fldEspecieOD.Top = 1.4375!
        Me.fldEspecieOD.Width = 0.5625!
        '
        'fldLenteOD
        '
        Me.fldLenteOD.Border.BottomColor = System.Drawing.Color.Black
        Me.fldLenteOD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLenteOD.Border.LeftColor = System.Drawing.Color.Black
        Me.fldLenteOD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLenteOD.Border.RightColor = System.Drawing.Color.Black
        Me.fldLenteOD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLenteOD.Border.TopColor = System.Drawing.Color.Black
        Me.fldLenteOD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLenteOD.CanGrow = False
        Me.fldLenteOD.CanShrink = True
        Me.fldLenteOD.DataField = "EST_OD"
        Me.fldLenteOD.Height = 0.16875!
        Me.fldLenteOD.Left = 0.875!
        Me.fldLenteOD.Name = "fldLenteOD"
        Me.fldLenteOD.Style = "ddo-char-set: 1; font-weight: normal; white-space: nowrap; "
        Me.fldLenteOD.Text = "TextBox"
        Me.fldLenteOD.Top = 1.4375!
        Me.fldLenteOD.Width = 5.125!
        '
        'Label6
        '
        Me.Label6.Border.BottomColor = System.Drawing.Color.Black
        Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.LeftColor = System.Drawing.Color.Black
        Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.RightColor = System.Drawing.Color.Black
        Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.TopColor = System.Drawing.Color.Black
        Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Height = 0.1479167!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label6.Text = "OE:"
        Me.Label6.Top = 1.625!
        Me.Label6.Width = 0.2395833!
        '
        'fldCodFabOE
        '
        Me.fldCodFabOE.Border.BottomColor = System.Drawing.Color.Black
        Me.fldCodFabOE.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCodFabOE.Border.LeftColor = System.Drawing.Color.Black
        Me.fldCodFabOE.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCodFabOE.Border.RightColor = System.Drawing.Color.Black
        Me.fldCodFabOE.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCodFabOE.Border.TopColor = System.Drawing.Color.Black
        Me.fldCodFabOE.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCodFabOE.DataField = "cod_produto_oe"
        Me.fldCodFabOE.Height = 0.16875!
        Me.fldCodFabOE.Left = 0.3125!
        Me.fldCodFabOE.Name = "fldCodFabOE"
        Me.fldCodFabOE.Style = "ddo-char-set: 1; font-weight: normal; "
        Me.fldCodFabOE.Text = "TextBox"
        Me.fldCodFabOE.Top = 1.625!
        Me.fldCodFabOE.Width = 0.5625!
        '
        'fldLenteOE
        '
        Me.fldLenteOE.Border.BottomColor = System.Drawing.Color.Black
        Me.fldLenteOE.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLenteOE.Border.LeftColor = System.Drawing.Color.Black
        Me.fldLenteOE.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLenteOE.Border.RightColor = System.Drawing.Color.Black
        Me.fldLenteOE.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLenteOE.Border.TopColor = System.Drawing.Color.Black
        Me.fldLenteOE.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLenteOE.CanGrow = False
        Me.fldLenteOE.CanShrink = True
        Me.fldLenteOE.DataField = "EST_OE"
        Me.fldLenteOE.Height = 0.16875!
        Me.fldLenteOE.Left = 0.875!
        Me.fldLenteOE.Name = "fldLenteOE"
        Me.fldLenteOE.Style = "ddo-char-set: 1; font-weight: normal; white-space: nowrap; "
        Me.fldLenteOE.Text = "TextBox2"
        Me.fldLenteOE.Top = 1.625!
        Me.fldLenteOE.Width = 5.125!
        '
        'Label7
        '
        Me.Label7.Border.BottomColor = System.Drawing.Color.Black
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.LeftColor = System.Drawing.Color.Black
        Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.RightColor = System.Drawing.Color.Black
        Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.TopColor = System.Drawing.Color.Black
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Height = 0.1479167!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.5!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label7.Text = "Solicitações da Área de Cálculo"
        Me.Label7.Top = 1.8125!
        Me.Label7.Width = 2.137385!
        '
        'Label8
        '
        Me.Label8.Border.BottomColor = System.Drawing.Color.Black
        Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.LeftColor = System.Drawing.Color.Black
        Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.RightColor = System.Drawing.Color.Black
        Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.TopColor = System.Drawing.Color.Black
        Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Height = 0.1479167!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 5.5!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label8.Text = "Nova Base OD:"
        Me.Label8.Top = 2.0!
        Me.Label8.Width = 0.9270833!
        '
        'Label9
        '
        Me.Label9.Border.BottomColor = System.Drawing.Color.Black
        Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.LeftColor = System.Drawing.Color.Black
        Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.RightColor = System.Drawing.Color.Black
        Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.TopColor = System.Drawing.Color.Black
        Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Height = 0.1479167!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 5.5!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label9.Text = "Nova Base OE:"
        Me.Label9.Top = 2.3125!
        Me.Label9.Width = 0.90625!
        '
        'Line8
        '
        Me.Line8.Border.BottomColor = System.Drawing.Color.Black
        Me.Line8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.LeftColor = System.Drawing.Color.Black
        Me.Line8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.RightColor = System.Drawing.Color.Black
        Me.Line8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.TopColor = System.Drawing.Color.Black
        Me.Line8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Height = 0!
        Me.Line8.Left = 0!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 2.4375!
        Me.Line8.Width = 7.625!
        Me.Line8.X1 = 0!
        Me.Line8.X2 = 7.625!
        Me.Line8.Y1 = 2.4375!
        Me.Line8.Y2 = 2.4375!
        '
        'Label10
        '
        Me.Label10.Border.BottomColor = System.Drawing.Color.Black
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.LeftColor = System.Drawing.Color.Black
        Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.RightColor = System.Drawing.Color.Black
        Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.TopColor = System.Drawing.Color.Black
        Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Height = 0.1479167!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label10.Text = "Tab. Preço:"
        Me.Label10.Top = 1.8125!
        Me.Label10.Width = 1.0!
        '
        'fldNomeTabOE
        '
        Me.fldNomeTabOE.Border.BottomColor = System.Drawing.Color.Black
        Me.fldNomeTabOE.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldNomeTabOE.Border.LeftColor = System.Drawing.Color.Black
        Me.fldNomeTabOE.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldNomeTabOE.Border.RightColor = System.Drawing.Color.Black
        Me.fldNomeTabOE.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldNomeTabOE.Border.TopColor = System.Drawing.Color.Black
        Me.fldNomeTabOE.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldNomeTabOE.CanGrow = False
        Me.fldNomeTabOE.DataField = "tab_oe"
        Me.fldNomeTabOE.Height = 0.19!
        Me.fldNomeTabOE.Left = 0.875!
        Me.fldNomeTabOE.Name = "fldNomeTabOE"
        Me.fldNomeTabOE.Style = "ddo-char-set: 1; font-weight: normal; white-space: nowrap; "
        Me.fldNomeTabOE.Text = "TextBox2"
        Me.fldNomeTabOE.Top = 2.25!
        Me.fldNomeTabOE.Width = 4.4375!
        '
        'fldTipoTAbOE
        '
        Me.fldTipoTAbOE.Border.BottomColor = System.Drawing.Color.Black
        Me.fldTipoTAbOE.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTipoTAbOE.Border.LeftColor = System.Drawing.Color.Black
        Me.fldTipoTAbOE.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTipoTAbOE.Border.RightColor = System.Drawing.Color.Black
        Me.fldTipoTAbOE.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTipoTAbOE.Border.TopColor = System.Drawing.Color.Black
        Me.fldTipoTAbOE.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTipoTAbOE.DataField = "cod_tab_oe"
        Me.fldTipoTAbOE.Height = 0.1875!
        Me.fldTipoTAbOE.Left = 0.3125!
        Me.fldTipoTAbOE.Name = "fldTipoTAbOE"
        Me.fldTipoTAbOE.Style = "ddo-char-set: 1; font-weight: normal; "
        Me.fldTipoTAbOE.Text = "TextBox1"
        Me.fldTipoTAbOE.Top = 2.25!
        Me.fldTipoTAbOE.Width = 0.5!
        '
        'Label11
        '
        Me.Label11.Border.BottomColor = System.Drawing.Color.Black
        Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.LeftColor = System.Drawing.Color.Black
        Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.RightColor = System.Drawing.Color.Black
        Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.TopColor = System.Drawing.Color.Black
        Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Height = 0.19!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label11.Text = "OE:"
        Me.Label11.Top = 2.25!
        Me.Label11.Width = 0.2395833!
        '
        'Label12
        '
        Me.Label12.Border.BottomColor = System.Drawing.Color.Black
        Me.Label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.LeftColor = System.Drawing.Color.Black
        Me.Label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.RightColor = System.Drawing.Color.Black
        Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.TopColor = System.Drawing.Color.Black
        Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Height = 0.19!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label12.Text = "OD:"
        Me.Label12.Top = 2.0!
        Me.Label12.Width = 0.2395833!
        '
        'fldTipoTabOD
        '
        Me.fldTipoTabOD.Border.BottomColor = System.Drawing.Color.Black
        Me.fldTipoTabOD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTipoTabOD.Border.LeftColor = System.Drawing.Color.Black
        Me.fldTipoTabOD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTipoTabOD.Border.RightColor = System.Drawing.Color.Black
        Me.fldTipoTabOD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTipoTabOD.Border.TopColor = System.Drawing.Color.Black
        Me.fldTipoTabOD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTipoTabOD.DataField = "cod_tab_od"
        Me.fldTipoTabOD.Height = 0.1875!
        Me.fldTipoTabOD.Left = 0.3125!
        Me.fldTipoTabOD.Name = "fldTipoTabOD"
        Me.fldTipoTabOD.Style = "ddo-char-set: 1; font-weight: normal; "
        Me.fldTipoTabOD.Text = "TextBox4"
        Me.fldTipoTabOD.Top = 2.0!
        Me.fldTipoTabOD.Width = 0.5!
        '
        'fldNomeTabOD
        '
        Me.fldNomeTabOD.Border.BottomColor = System.Drawing.Color.Black
        Me.fldNomeTabOD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldNomeTabOD.Border.LeftColor = System.Drawing.Color.Black
        Me.fldNomeTabOD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldNomeTabOD.Border.RightColor = System.Drawing.Color.Black
        Me.fldNomeTabOD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldNomeTabOD.Border.TopColor = System.Drawing.Color.Black
        Me.fldNomeTabOD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldNomeTabOD.CanGrow = False
        Me.fldNomeTabOD.DataField = "tab_od"
        Me.fldNomeTabOD.Height = 0.1875!
        Me.fldNomeTabOD.Left = 0.875!
        Me.fldNomeTabOD.Name = "fldNomeTabOD"
        Me.fldNomeTabOD.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; white-space: nowrap; "
        Me.fldNomeTabOD.Text = "TextBox5"
        Me.fldNomeTabOD.Top = 2.0!
        Me.fldNomeTabOD.Width = 4.4375!
        '
        'Label14
        '
        Me.Label14.Border.BottomColor = System.Drawing.Color.Black
        Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.LeftColor = System.Drawing.Color.Black
        Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.RightColor = System.Drawing.Color.Black
        Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.TopColor = System.Drawing.Color.Black
        Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Height = 0.1479167!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label14.Text = "Longe:"
        Me.Label14.Top = 2.8125!
        Me.Label14.Width = 0.4375!
        '
        'Label20
        '
        Me.Label20.Border.BottomColor = System.Drawing.Color.Black
        Me.Label20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.LeftColor = System.Drawing.Color.Black
        Me.Label20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.RightColor = System.Drawing.Color.Black
        Me.Label20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.TopColor = System.Drawing.Color.Black
        Me.Label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Height = 0.16875!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 0.5625!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label20.Text = "OD:"
        Me.Label20.Top = 2.625!
        Me.Label20.Width = 0.2395833!
        '
        'fldEsfODLonge
        '
        Me.fldEsfODLonge.Border.BottomColor = System.Drawing.Color.Black
        Me.fldEsfODLonge.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfODLonge.Border.LeftColor = System.Drawing.Color.Black
        Me.fldEsfODLonge.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfODLonge.Border.RightColor = System.Drawing.Color.Black
        Me.fldEsfODLonge.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfODLonge.Border.TopColor = System.Drawing.Color.Black
        Me.fldEsfODLonge.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfODLonge.DataField = "ESF_OD_LONGE"
        Me.fldEsfODLonge.Height = 0.16875!
        Me.fldEsfODLonge.Left = 0.8125!
        Me.fldEsfODLonge.Name = "fldEsfODLonge"
        Me.fldEsfODLonge.OutputFormat = resources.GetString("fldEsfODLonge.OutputFormat")
        Me.fldEsfODLonge.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldEsfODLonge.Text = "TextBox1"
        Me.fldEsfODLonge.Top = 2.625!
        Me.fldEsfODLonge.Width = 0.5104167!
        '
        'fldCilODLonge
        '
        Me.fldCilODLonge.Border.BottomColor = System.Drawing.Color.Black
        Me.fldCilODLonge.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilODLonge.Border.LeftColor = System.Drawing.Color.Black
        Me.fldCilODLonge.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilODLonge.Border.RightColor = System.Drawing.Color.Black
        Me.fldCilODLonge.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilODLonge.Border.TopColor = System.Drawing.Color.Black
        Me.fldCilODLonge.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilODLonge.DataField = "CIL_OD_LONGE"
        Me.fldCilODLonge.Height = 0.16875!
        Me.fldCilODLonge.Left = 1.375!
        Me.fldCilODLonge.Name = "fldCilODLonge"
        Me.fldCilODLonge.OutputFormat = resources.GetString("fldCilODLonge.OutputFormat")
        Me.fldCilODLonge.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldCilODLonge.Text = "TextBox1"
        Me.fldCilODLonge.Top = 2.625!
        Me.fldCilODLonge.Width = 0.5416666!
        '
        'fldEixoOD
        '
        Me.fldEixoOD.Border.BottomColor = System.Drawing.Color.Black
        Me.fldEixoOD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEixoOD.Border.LeftColor = System.Drawing.Color.Black
        Me.fldEixoOD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEixoOD.Border.RightColor = System.Drawing.Color.Black
        Me.fldEixoOD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEixoOD.Border.TopColor = System.Drawing.Color.Black
        Me.fldEixoOD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEixoOD.DataField = "EIXO_OD"
        Me.fldEixoOD.Height = 0.16875!
        Me.fldEixoOD.Left = 2.0625!
        Me.fldEixoOD.Name = "fldEixoOD"
        Me.fldEixoOD.OutputFormat = resources.GetString("fldEixoOD.OutputFormat")
        Me.fldEixoOD.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldEixoOD.Text = "TextBox1"
        Me.fldEixoOD.Top = 2.625!
        Me.fldEixoOD.Width = 0.4791667!
        '
        'fldDpOdLonge
        '
        Me.fldDpOdLonge.Border.BottomColor = System.Drawing.Color.Black
        Me.fldDpOdLonge.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDpOdLonge.Border.LeftColor = System.Drawing.Color.Black
        Me.fldDpOdLonge.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDpOdLonge.Border.RightColor = System.Drawing.Color.Black
        Me.fldDpOdLonge.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDpOdLonge.Border.TopColor = System.Drawing.Color.Black
        Me.fldDpOdLonge.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDpOdLonge.DataField = "DNP_OD_LONGE"
        Me.fldDpOdLonge.Height = 0.16875!
        Me.fldDpOdLonge.Left = 2.6875!
        Me.fldDpOdLonge.Name = "fldDpOdLonge"
        Me.fldDpOdLonge.OutputFormat = resources.GetString("fldDpOdLonge.OutputFormat")
        Me.fldDpOdLonge.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldDpOdLonge.Text = "TextBox1"
        Me.fldDpOdLonge.Top = 2.625!
        Me.fldDpOdLonge.Width = 0.40625!
        '
        'fldAlturaOD
        '
        Me.fldAlturaOD.Border.BottomColor = System.Drawing.Color.Black
        Me.fldAlturaOD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAlturaOD.Border.LeftColor = System.Drawing.Color.Black
        Me.fldAlturaOD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAlturaOD.Border.RightColor = System.Drawing.Color.Black
        Me.fldAlturaOD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAlturaOD.Border.TopColor = System.Drawing.Color.Black
        Me.fldAlturaOD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAlturaOD.DataField = "ALTURA_OD"
        Me.fldAlturaOD.Height = 0.16875!
        Me.fldAlturaOD.Left = 3.1875!
        Me.fldAlturaOD.Name = "fldAlturaOD"
        Me.fldAlturaOD.OutputFormat = resources.GetString("fldAlturaOD.OutputFormat")
        Me.fldAlturaOD.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldAlturaOD.Text = "TextBox1"
        Me.fldAlturaOD.Top = 2.625!
        Me.fldAlturaOD.Width = 0.40625!
        '
        'Line9
        '
        Me.Line9.Border.BottomColor = System.Drawing.Color.Black
        Me.Line9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.LeftColor = System.Drawing.Color.Black
        Me.Line9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.RightColor = System.Drawing.Color.Black
        Me.Line9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.TopColor = System.Drawing.Color.Black
        Me.Line9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Height = 0!
        Me.Line9.Left = 0!
        Me.Line9.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDotDot
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 5.6875!
        Me.Line9.Width = 7.625!
        Me.Line9.X1 = 0!
        Me.Line9.X2 = 7.625!
        Me.Line9.Y1 = 5.6875!
        Me.Line9.Y2 = 5.6875!
        '
        'lblData
        '
        Me.lblData.Border.BottomColor = System.Drawing.Color.Black
        Me.lblData.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblData.Border.LeftColor = System.Drawing.Color.Black
        Me.lblData.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblData.Border.RightColor = System.Drawing.Color.Black
        Me.lblData.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblData.Border.TopColor = System.Drawing.Color.Black
        Me.lblData.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblData.Height = 0.2208333!
        Me.lblData.HyperLink = Nothing
        Me.lblData.Left = 1.625!
        Me.lblData.Name = "lblData"
        Me.lblData.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 12pt; "
        Me.lblData.Text = ""
        Me.lblData.Top = 0.75!
        Me.lblData.Width = 0.875!
        '
        'Label21
        '
        Me.Label21.Border.BottomColor = System.Drawing.Color.Black
        Me.Label21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.LeftColor = System.Drawing.Color.Black
        Me.Label21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.RightColor = System.Drawing.Color.Black
        Me.Label21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.TopColor = System.Drawing.Color.Black
        Me.Label21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Height = 0.16875!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 0.5625!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label21.Text = "OE:"
        Me.Label21.Top = 2.875!
        Me.Label21.Width = 0.2395833!
        '
        'fldEsfOeLonge
        '
        Me.fldEsfOeLonge.Border.BottomColor = System.Drawing.Color.Black
        Me.fldEsfOeLonge.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfOeLonge.Border.LeftColor = System.Drawing.Color.Black
        Me.fldEsfOeLonge.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfOeLonge.Border.RightColor = System.Drawing.Color.Black
        Me.fldEsfOeLonge.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfOeLonge.Border.TopColor = System.Drawing.Color.Black
        Me.fldEsfOeLonge.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfOeLonge.DataField = "ESF_OE_LONGE"
        Me.fldEsfOeLonge.Height = 0.16875!
        Me.fldEsfOeLonge.Left = 0.8125!
        Me.fldEsfOeLonge.Name = "fldEsfOeLonge"
        Me.fldEsfOeLonge.OutputFormat = resources.GetString("fldEsfOeLonge.OutputFormat")
        Me.fldEsfOeLonge.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldEsfOeLonge.Text = "TextBox1"
        Me.fldEsfOeLonge.Top = 2.875!
        Me.fldEsfOeLonge.Width = 0.5104167!
        '
        'fldCilOELonge
        '
        Me.fldCilOELonge.Border.BottomColor = System.Drawing.Color.Black
        Me.fldCilOELonge.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilOELonge.Border.LeftColor = System.Drawing.Color.Black
        Me.fldCilOELonge.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilOELonge.Border.RightColor = System.Drawing.Color.Black
        Me.fldCilOELonge.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilOELonge.Border.TopColor = System.Drawing.Color.Black
        Me.fldCilOELonge.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilOELonge.DataField = "CIL_OE_LONGE"
        Me.fldCilOELonge.Height = 0.16875!
        Me.fldCilOELonge.Left = 1.375!
        Me.fldCilOELonge.Name = "fldCilOELonge"
        Me.fldCilOELonge.OutputFormat = resources.GetString("fldCilOELonge.OutputFormat")
        Me.fldCilOELonge.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldCilOELonge.Text = "TextBox1"
        Me.fldCilOELonge.Top = 2.875!
        Me.fldCilOELonge.Width = 0.5416666!
        '
        'fldEixo_oe
        '
        Me.fldEixo_oe.Border.BottomColor = System.Drawing.Color.Black
        Me.fldEixo_oe.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEixo_oe.Border.LeftColor = System.Drawing.Color.Black
        Me.fldEixo_oe.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEixo_oe.Border.RightColor = System.Drawing.Color.Black
        Me.fldEixo_oe.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEixo_oe.Border.TopColor = System.Drawing.Color.Black
        Me.fldEixo_oe.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEixo_oe.DataField = "EIXO_OE"
        Me.fldEixo_oe.Height = 0.16875!
        Me.fldEixo_oe.Left = 2.0625!
        Me.fldEixo_oe.Name = "fldEixo_oe"
        Me.fldEixo_oe.OutputFormat = resources.GetString("fldEixo_oe.OutputFormat")
        Me.fldEixo_oe.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldEixo_oe.Text = "TextBox1"
        Me.fldEixo_oe.Top = 2.875!
        Me.fldEixo_oe.Width = 0.4791667!
        '
        'fldDnpOELonge
        '
        Me.fldDnpOELonge.Border.BottomColor = System.Drawing.Color.Black
        Me.fldDnpOELonge.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDnpOELonge.Border.LeftColor = System.Drawing.Color.Black
        Me.fldDnpOELonge.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDnpOELonge.Border.RightColor = System.Drawing.Color.Black
        Me.fldDnpOELonge.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDnpOELonge.Border.TopColor = System.Drawing.Color.Black
        Me.fldDnpOELonge.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDnpOELonge.DataField = "DNP_OE_LONGE"
        Me.fldDnpOELonge.Height = 0.16875!
        Me.fldDnpOELonge.Left = 2.6875!
        Me.fldDnpOELonge.Name = "fldDnpOELonge"
        Me.fldDnpOELonge.OutputFormat = resources.GetString("fldDnpOELonge.OutputFormat")
        Me.fldDnpOELonge.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldDnpOELonge.Text = "TextBox1"
        Me.fldDnpOELonge.Top = 2.875!
        Me.fldDnpOELonge.Width = 0.40625!
        '
        'fldAlturaOE
        '
        Me.fldAlturaOE.Border.BottomColor = System.Drawing.Color.Black
        Me.fldAlturaOE.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAlturaOE.Border.LeftColor = System.Drawing.Color.Black
        Me.fldAlturaOE.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAlturaOE.Border.RightColor = System.Drawing.Color.Black
        Me.fldAlturaOE.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAlturaOE.Border.TopColor = System.Drawing.Color.Black
        Me.fldAlturaOE.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAlturaOE.DataField = "ALTURA_OE"
        Me.fldAlturaOE.Height = 0.16875!
        Me.fldAlturaOE.Left = 3.1875!
        Me.fldAlturaOE.Name = "fldAlturaOE"
        Me.fldAlturaOE.OutputFormat = resources.GetString("fldAlturaOE.OutputFormat")
        Me.fldAlturaOE.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldAlturaOE.Text = "TextBox1"
        Me.fldAlturaOE.Top = 2.875!
        Me.fldAlturaOE.Width = 0.40625!
        '
        'Label22
        '
        Me.Label22.Border.BottomColor = System.Drawing.Color.Black
        Me.Label22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.LeftColor = System.Drawing.Color.Black
        Me.Label22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.RightColor = System.Drawing.Color.Black
        Me.Label22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.TopColor = System.Drawing.Color.Black
        Me.Label22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Height = 0.1479167!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 0!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label22.Text = "Perto:"
        Me.Label22.Top = 3.375!
        Me.Label22.Width = 0.4375!
        '
        'Label23
        '
        Me.Label23.Border.BottomColor = System.Drawing.Color.Black
        Me.Label23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.LeftColor = System.Drawing.Color.Black
        Me.Label23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.RightColor = System.Drawing.Color.Black
        Me.Label23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.TopColor = System.Drawing.Color.Black
        Me.Label23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Height = 0.16875!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 0.5625!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label23.Text = "OD:"
        Me.Label23.Top = 3.1875!
        Me.Label23.Width = 0.2395833!
        '
        'fldEsfODPeerto
        '
        Me.fldEsfODPeerto.Border.BottomColor = System.Drawing.Color.Black
        Me.fldEsfODPeerto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfODPeerto.Border.LeftColor = System.Drawing.Color.Black
        Me.fldEsfODPeerto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfODPeerto.Border.RightColor = System.Drawing.Color.Black
        Me.fldEsfODPeerto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfODPeerto.Border.TopColor = System.Drawing.Color.Black
        Me.fldEsfODPeerto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfODPeerto.DataField = "ESF_OD_perto"
        Me.fldEsfODPeerto.Height = 0.16875!
        Me.fldEsfODPeerto.Left = 0.8125!
        Me.fldEsfODPeerto.Name = "fldEsfODPeerto"
        Me.fldEsfODPeerto.OutputFormat = resources.GetString("fldEsfODPeerto.OutputFormat")
        Me.fldEsfODPeerto.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldEsfODPeerto.Text = "TextBox1"
        Me.fldEsfODPeerto.Top = 3.1875!
        Me.fldEsfODPeerto.Width = 0.5104167!
        '
        'fldCilODPerto
        '
        Me.fldCilODPerto.Border.BottomColor = System.Drawing.Color.Black
        Me.fldCilODPerto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilODPerto.Border.LeftColor = System.Drawing.Color.Black
        Me.fldCilODPerto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilODPerto.Border.RightColor = System.Drawing.Color.Black
        Me.fldCilODPerto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilODPerto.Border.TopColor = System.Drawing.Color.Black
        Me.fldCilODPerto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilODPerto.DataField = "CIL_OD_PERTO"
        Me.fldCilODPerto.Height = 0.16875!
        Me.fldCilODPerto.Left = 1.375!
        Me.fldCilODPerto.Name = "fldCilODPerto"
        Me.fldCilODPerto.OutputFormat = resources.GetString("fldCilODPerto.OutputFormat")
        Me.fldCilODPerto.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldCilODPerto.Text = "TextBox1"
        Me.fldCilODPerto.Top = 3.1875!
        Me.fldCilODPerto.Width = 0.5416666!
        '
        'fldDnpODPerto
        '
        Me.fldDnpODPerto.Border.BottomColor = System.Drawing.Color.Black
        Me.fldDnpODPerto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDnpODPerto.Border.LeftColor = System.Drawing.Color.Black
        Me.fldDnpODPerto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDnpODPerto.Border.RightColor = System.Drawing.Color.Black
        Me.fldDnpODPerto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDnpODPerto.Border.TopColor = System.Drawing.Color.Black
        Me.fldDnpODPerto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDnpODPerto.DataField = "DNP_OD_PERTO"
        Me.fldDnpODPerto.Height = 0.16875!
        Me.fldDnpODPerto.Left = 2.6875!
        Me.fldDnpODPerto.Name = "fldDnpODPerto"
        Me.fldDnpODPerto.OutputFormat = resources.GetString("fldDnpODPerto.OutputFormat")
        Me.fldDnpODPerto.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldDnpODPerto.Text = "TextBox1"
        Me.fldDnpODPerto.Top = 3.1875!
        Me.fldDnpODPerto.Width = 0.40625!
        '
        'Label24
        '
        Me.Label24.Border.BottomColor = System.Drawing.Color.Black
        Me.Label24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.LeftColor = System.Drawing.Color.Black
        Me.Label24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.RightColor = System.Drawing.Color.Black
        Me.Label24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.TopColor = System.Drawing.Color.Black
        Me.Label24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Height = 0.16875!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0.5625!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label24.Text = "OE:"
        Me.Label24.Top = 3.4375!
        Me.Label24.Width = 0.2395833!
        '
        'fldEsfOEPerto
        '
        Me.fldEsfOEPerto.Border.BottomColor = System.Drawing.Color.Black
        Me.fldEsfOEPerto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfOEPerto.Border.LeftColor = System.Drawing.Color.Black
        Me.fldEsfOEPerto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfOEPerto.Border.RightColor = System.Drawing.Color.Black
        Me.fldEsfOEPerto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfOEPerto.Border.TopColor = System.Drawing.Color.Black
        Me.fldEsfOEPerto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldEsfOEPerto.DataField = "ESF_OE_PERTO"
        Me.fldEsfOEPerto.Height = 0.16875!
        Me.fldEsfOEPerto.Left = 0.8125!
        Me.fldEsfOEPerto.Name = "fldEsfOEPerto"
        Me.fldEsfOEPerto.OutputFormat = resources.GetString("fldEsfOEPerto.OutputFormat")
        Me.fldEsfOEPerto.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldEsfOEPerto.Text = "TextBox1"
        Me.fldEsfOEPerto.Top = 3.4375!
        Me.fldEsfOEPerto.Width = 0.5104166!
        '
        'fldCilOEPerto
        '
        Me.fldCilOEPerto.Border.BottomColor = System.Drawing.Color.Black
        Me.fldCilOEPerto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilOEPerto.Border.LeftColor = System.Drawing.Color.Black
        Me.fldCilOEPerto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilOEPerto.Border.RightColor = System.Drawing.Color.Black
        Me.fldCilOEPerto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilOEPerto.Border.TopColor = System.Drawing.Color.Black
        Me.fldCilOEPerto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCilOEPerto.DataField = "CIL_OE_PERTO"
        Me.fldCilOEPerto.Height = 0.16875!
        Me.fldCilOEPerto.Left = 1.375!
        Me.fldCilOEPerto.Name = "fldCilOEPerto"
        Me.fldCilOEPerto.OutputFormat = resources.GetString("fldCilOEPerto.OutputFormat")
        Me.fldCilOEPerto.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldCilOEPerto.Text = "TextBox1"
        Me.fldCilOEPerto.Top = 3.4375!
        Me.fldCilOEPerto.Width = 0.5416666!
        '
        'fldDNPOEPerto
        '
        Me.fldDNPOEPerto.Border.BottomColor = System.Drawing.Color.Black
        Me.fldDNPOEPerto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDNPOEPerto.Border.LeftColor = System.Drawing.Color.Black
        Me.fldDNPOEPerto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDNPOEPerto.Border.RightColor = System.Drawing.Color.Black
        Me.fldDNPOEPerto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDNPOEPerto.Border.TopColor = System.Drawing.Color.Black
        Me.fldDNPOEPerto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDNPOEPerto.DataField = "DNP_OE_PERTO"
        Me.fldDNPOEPerto.Height = 0.16875!
        Me.fldDNPOEPerto.Left = 2.6875!
        Me.fldDNPOEPerto.Name = "fldDNPOEPerto"
        Me.fldDNPOEPerto.OutputFormat = resources.GetString("fldDNPOEPerto.OutputFormat")
        Me.fldDNPOEPerto.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldDNPOEPerto.Text = "TextBox1"
        Me.fldDNPOEPerto.Top = 3.4375!
        Me.fldDNPOEPerto.Width = 0.40625!
        '
        'Label25
        '
        Me.Label25.Border.BottomColor = System.Drawing.Color.Black
        Me.Label25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label25.Border.LeftColor = System.Drawing.Color.Black
        Me.Label25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label25.Border.RightColor = System.Drawing.Color.Black
        Me.Label25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label25.Border.TopColor = System.Drawing.Color.Black
        Me.Label25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label25.Height = 0.16875!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 3.8125!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label25.Text = "OD:"
        Me.Label25.Top = 2.625!
        Me.Label25.Width = 0.2395833!
        '
        'Label26
        '
        Me.Label26.Border.BottomColor = System.Drawing.Color.Black
        Me.Label26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label26.Border.LeftColor = System.Drawing.Color.Black
        Me.Label26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label26.Border.RightColor = System.Drawing.Color.Black
        Me.Label26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label26.Border.TopColor = System.Drawing.Color.Black
        Me.Label26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label26.Height = 0.16875!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 3.8125!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label26.Text = "OE:"
        Me.Label26.Top = 2.875!
        Me.Label26.Width = 0.2395833!
        '
        'fldBaseOD
        '
        Me.fldBaseOD.Border.BottomColor = System.Drawing.Color.Black
        Me.fldBaseOD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldBaseOD.Border.LeftColor = System.Drawing.Color.Black
        Me.fldBaseOD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldBaseOD.Border.RightColor = System.Drawing.Color.Black
        Me.fldBaseOD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldBaseOD.Border.TopColor = System.Drawing.Color.Black
        Me.fldBaseOD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldBaseOD.DataField = "BASE_OD"
        Me.fldBaseOD.Height = 0.16875!
        Me.fldBaseOD.Left = 4.1875!
        Me.fldBaseOD.Name = "fldBaseOD"
        Me.fldBaseOD.OutputFormat = resources.GetString("fldBaseOD.OutputFormat")
        Me.fldBaseOD.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldBaseOD.Text = "TextBox1"
        Me.fldBaseOD.Top = 2.625!
        Me.fldBaseOD.Width = 0.3854167!
        '
        'fldBaseOE
        '
        Me.fldBaseOE.Border.BottomColor = System.Drawing.Color.Black
        Me.fldBaseOE.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldBaseOE.Border.LeftColor = System.Drawing.Color.Black
        Me.fldBaseOE.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldBaseOE.Border.RightColor = System.Drawing.Color.Black
        Me.fldBaseOE.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldBaseOE.Border.TopColor = System.Drawing.Color.Black
        Me.fldBaseOE.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldBaseOE.DataField = "BASE_OE"
        Me.fldBaseOE.Height = 0.16875!
        Me.fldBaseOE.Left = 4.1875!
        Me.fldBaseOE.Name = "fldBaseOE"
        Me.fldBaseOE.OutputFormat = resources.GetString("fldBaseOE.OutputFormat")
        Me.fldBaseOE.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldBaseOE.Text = "TextBox1"
        Me.fldBaseOE.Top = 2.875!
        Me.fldBaseOE.Width = 0.3854167!
        '
        'fldAdicaoOE
        '
        Me.fldAdicaoOE.Border.BottomColor = System.Drawing.Color.Black
        Me.fldAdicaoOE.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAdicaoOE.Border.LeftColor = System.Drawing.Color.Black
        Me.fldAdicaoOE.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAdicaoOE.Border.RightColor = System.Drawing.Color.Black
        Me.fldAdicaoOE.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAdicaoOE.Border.TopColor = System.Drawing.Color.Black
        Me.fldAdicaoOE.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAdicaoOE.DataField = "ADICAO_OE"
        Me.fldAdicaoOE.Height = 0.16875!
        Me.fldAdicaoOE.Left = 4.6875!
        Me.fldAdicaoOE.Name = "fldAdicaoOE"
        Me.fldAdicaoOE.OutputFormat = resources.GetString("fldAdicaoOE.OutputFormat")
        Me.fldAdicaoOE.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldAdicaoOE.Text = "TextBox1"
        Me.fldAdicaoOE.Top = 2.875!
        Me.fldAdicaoOE.Width = 0.40625!
        '
        'fldAdicaoOD
        '
        Me.fldAdicaoOD.Border.BottomColor = System.Drawing.Color.Black
        Me.fldAdicaoOD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAdicaoOD.Border.LeftColor = System.Drawing.Color.Black
        Me.fldAdicaoOD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAdicaoOD.Border.RightColor = System.Drawing.Color.Black
        Me.fldAdicaoOD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAdicaoOD.Border.TopColor = System.Drawing.Color.Black
        Me.fldAdicaoOD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAdicaoOD.DataField = "ADICAO_OD"
        Me.fldAdicaoOD.Height = 0.16875!
        Me.fldAdicaoOD.Left = 4.6875!
        Me.fldAdicaoOD.Name = "fldAdicaoOD"
        Me.fldAdicaoOD.OutputFormat = resources.GetString("fldAdicaoOD.OutputFormat")
        Me.fldAdicaoOD.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; "
        Me.fldAdicaoOD.Text = "TextBox1"
        Me.fldAdicaoOD.Top = 2.625!
        Me.fldAdicaoOD.Width = 0.40625!
        '
        'Label27
        '
        Me.Label27.Border.BottomColor = System.Drawing.Color.Black
        Me.Label27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label27.Border.LeftColor = System.Drawing.Color.Black
        Me.Label27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label27.Border.RightColor = System.Drawing.Color.Black
        Me.Label27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label27.Border.TopColor = System.Drawing.Color.Black
        Me.Label27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label27.Height = 0.1479167!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 4.1875!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.Label27.Text = "Base"
        Me.Label27.Top = 2.4375!
        Me.Label27.Width = 0.3854167!
        '
        'Label28
        '
        Me.Label28.Border.BottomColor = System.Drawing.Color.Black
        Me.Label28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label28.Border.LeftColor = System.Drawing.Color.Black
        Me.Label28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label28.Border.RightColor = System.Drawing.Color.Black
        Me.Label28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label28.Border.TopColor = System.Drawing.Color.Black
        Me.Label28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label28.Height = 0.1479167!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 4.75!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.Label28.Text = "Adição"
        Me.Label28.Top = 2.4375!
        Me.Label28.Width = 0.3958333!
        '
        'fldDiametroOE
        '
        Me.fldDiametroOE.Border.BottomColor = System.Drawing.Color.Black
        Me.fldDiametroOE.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDiametroOE.Border.LeftColor = System.Drawing.Color.Black
        Me.fldDiametroOE.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDiametroOE.Border.RightColor = System.Drawing.Color.Black
        Me.fldDiametroOE.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDiametroOE.Border.TopColor = System.Drawing.Color.Black
        Me.fldDiametroOE.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDiametroOE.DataField = "DIAMETRO_OE"
        Me.fldDiametroOE.Height = 0.16875!
        Me.fldDiametroOE.Left = 5.375!
        Me.fldDiametroOE.Name = "fldDiametroOE"
        Me.fldDiametroOE.OutputFormat = resources.GetString("fldDiametroOE.OutputFormat")
        Me.fldDiametroOE.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; "
        Me.fldDiametroOE.Text = Nothing
        Me.fldDiametroOE.Top = 2.875!
        Me.fldDiametroOE.Width = 0.40625!
        '
        'fldDiametroOD
        '
        Me.fldDiametroOD.Border.BottomColor = System.Drawing.Color.Black
        Me.fldDiametroOD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDiametroOD.Border.LeftColor = System.Drawing.Color.Black
        Me.fldDiametroOD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDiametroOD.Border.RightColor = System.Drawing.Color.Black
        Me.fldDiametroOD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDiametroOD.Border.TopColor = System.Drawing.Color.Black
        Me.fldDiametroOD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDiametroOD.DataField = "DIAMETRO_OD"
        Me.fldDiametroOD.Height = 0.16875!
        Me.fldDiametroOD.Left = 5.375!
        Me.fldDiametroOD.Name = "fldDiametroOD"
        Me.fldDiametroOD.OutputFormat = resources.GetString("fldDiametroOD.OutputFormat")
        Me.fldDiametroOD.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; "
        Me.fldDiametroOD.Text = Nothing
        Me.fldDiametroOD.Top = 2.625!
        Me.fldDiametroOD.Width = 0.40625!
        '
        'Line10
        '
        Me.Line10.Border.BottomColor = System.Drawing.Color.Black
        Me.Line10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.LeftColor = System.Drawing.Color.Black
        Me.Line10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.RightColor = System.Drawing.Color.Black
        Me.Line10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.TopColor = System.Drawing.Color.Black
        Me.Line10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Height = 0.6875!
        Me.Line10.Left = 5.9375!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 2.4375!
        Me.Line10.Width = 0!
        Me.Line10.X1 = 5.9375!
        Me.Line10.X2 = 5.9375!
        Me.Line10.Y1 = 3.125!
        Me.Line10.Y2 = 2.4375!
        '
        'Label30
        '
        Me.Label30.Border.BottomColor = System.Drawing.Color.Black
        Me.Label30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label30.Border.LeftColor = System.Drawing.Color.Black
        Me.Label30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label30.Border.RightColor = System.Drawing.Color.Black
        Me.Label30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label30.Border.TopColor = System.Drawing.Color.Black
        Me.Label30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label30.Height = 0.1479167!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 6.0!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
        Me.Label30.Text = "Tipo de Armação / Montagem"
        Me.Label30.Top = 2.4375!
        Me.Label30.Width = 1.625!
        '
        'Line11
        '
        Me.Line11.Border.BottomColor = System.Drawing.Color.Black
        Me.Line11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.LeftColor = System.Drawing.Color.Black
        Me.Line11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.RightColor = System.Drawing.Color.Black
        Me.Line11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.TopColor = System.Drawing.Color.Black
        Me.Line11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Height = 0!
        Me.Line11.Left = 0!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 3.75!
        Me.Line11.Width = 7.625!
        Me.Line11.X1 = 0!
        Me.Line11.X2 = 7.625!
        Me.Line11.Y1 = 3.75!
        Me.Line11.Y2 = 3.75!
        '
        'Line12
        '
        Me.Line12.Border.BottomColor = System.Drawing.Color.Black
        Me.Line12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.LeftColor = System.Drawing.Color.Black
        Me.Line12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.RightColor = System.Drawing.Color.Black
        Me.Line12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.TopColor = System.Drawing.Color.Black
        Me.Line12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Height = 0!
        Me.Line12.Left = 3.75!
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 3.125!
        Me.Line12.Width = 3.875!
        Me.Line12.X1 = 3.75!
        Me.Line12.X2 = 7.625!
        Me.Line12.Y1 = 3.125!
        Me.Line12.Y2 = 3.125!
        '
        'Label31
        '
        Me.Label31.Border.BottomColor = System.Drawing.Color.Black
        Me.Label31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label31.Border.LeftColor = System.Drawing.Color.Black
        Me.Label31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label31.Border.RightColor = System.Drawing.Color.Black
        Me.Label31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label31.Border.TopColor = System.Drawing.Color.Black
        Me.Label31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label31.Height = 0.1479167!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 3.8125!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.Label31.Text = "Aro Horizontal:"
        Me.Label31.Top = 3.1875!
        Me.Label31.Width = 0.9166667!
        '
        'Label32
        '
        Me.Label32.Border.BottomColor = System.Drawing.Color.Black
        Me.Label32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label32.Border.LeftColor = System.Drawing.Color.Black
        Me.Label32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label32.Border.RightColor = System.Drawing.Color.Black
        Me.Label32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label32.Border.TopColor = System.Drawing.Color.Black
        Me.Label32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label32.Height = 0.1479167!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 5.5625!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.Label32.Text = "Maior Diametro:"
        Me.Label32.Top = 3.1875!
        Me.Label32.Width = 0.9166667!
        '
        'Label33
        '
        Me.Label33.Border.BottomColor = System.Drawing.Color.Black
        Me.Label33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label33.Border.LeftColor = System.Drawing.Color.Black
        Me.Label33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label33.Border.RightColor = System.Drawing.Color.Black
        Me.Label33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label33.Border.TopColor = System.Drawing.Color.Black
        Me.Label33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label33.Height = 0.1479167!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 3.8125!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.Label33.Text = "Aro vertical:"
        Me.Label33.Top = 3.4375!
        Me.Label33.Width = 0.9166667!
        '
        'Label34
        '
        Me.Label34.Border.BottomColor = System.Drawing.Color.Black
        Me.Label34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label34.Border.LeftColor = System.Drawing.Color.Black
        Me.Label34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label34.Border.RightColor = System.Drawing.Color.Black
        Me.Label34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label34.Border.TopColor = System.Drawing.Color.Black
        Me.Label34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label34.Height = 0.1479167!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 5.5625!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.Label34.Text = "Ponte:"
        Me.Label34.Top = 3.4375!
        Me.Label34.Width = 0.9166667!
        '
        'fldAroHorizontal
        '
        Me.fldAroHorizontal.Border.BottomColor = System.Drawing.Color.Black
        Me.fldAroHorizontal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAroHorizontal.Border.LeftColor = System.Drawing.Color.Black
        Me.fldAroHorizontal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAroHorizontal.Border.RightColor = System.Drawing.Color.Black
        Me.fldAroHorizontal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAroHorizontal.Border.TopColor = System.Drawing.Color.Black
        Me.fldAroHorizontal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldAroHorizontal.DataField = "Aro_horizontal"
        Me.fldAroHorizontal.Height = 0.16875!
        Me.fldAroHorizontal.Left = 4.8125!
        Me.fldAroHorizontal.Name = "fldAroHorizontal"
        Me.fldAroHorizontal.OutputFormat = resources.GetString("fldAroHorizontal.OutputFormat")
        Me.fldAroHorizontal.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; "
        Me.fldAroHorizontal.Text = "TextBox1"
        Me.fldAroHorizontal.Top = 3.1875!
        Me.fldAroHorizontal.Width = 0.40625!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.DataField = "aro_vertical"
        Me.TextBox1.Height = 0.16875!
        Me.TextBox1.Left = 4.8125!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; "
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Top = 3.4375!
        Me.TextBox1.Width = 0.40625!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.DataField = "maior_diametro"
        Me.TextBox3.Height = 0.16875!
        Me.TextBox3.Left = 6.5!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; "
        Me.TextBox3.Text = "TextBox1"
        Me.TextBox3.Top = 3.1875!
        Me.TextBox3.Width = 0.40625!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.DataField = "ponte"
        Me.TextBox4.Height = 0.16875!
        Me.TextBox4.Left = 6.5!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; "
        Me.TextBox4.Text = "TextBox1"
        Me.TextBox4.Top = 3.4375!
        Me.TextBox4.Width = 0.40625!
        '
        'fldArmacao
        '
        Me.fldArmacao.Border.BottomColor = System.Drawing.Color.Black
        Me.fldArmacao.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldArmacao.Border.LeftColor = System.Drawing.Color.Black
        Me.fldArmacao.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldArmacao.Border.RightColor = System.Drawing.Color.Black
        Me.fldArmacao.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldArmacao.Border.TopColor = System.Drawing.Color.Black
        Me.fldArmacao.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldArmacao.Height = 0.182661!
        Me.fldArmacao.HyperLink = Nothing
        Me.fldArmacao.Left = 5.9375!
        Me.fldArmacao.Name = "fldArmacao"
        Me.fldArmacao.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; font-size: 10pt; "
        Me.fldArmacao.Text = ""
        Me.fldArmacao.Top = 2.625!
        Me.fldArmacao.Width = 1.677083!
        '
        'Line13
        '
        Me.Line13.Border.BottomColor = System.Drawing.Color.Black
        Me.Line13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.LeftColor = System.Drawing.Color.Black
        Me.Line13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.RightColor = System.Drawing.Color.Black
        Me.Line13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.TopColor = System.Drawing.Color.Black
        Me.Line13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Height = 0!
        Me.Line13.Left = 0!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 4.0!
        Me.Line13.Width = 7.625!
        Me.Line13.X1 = 0!
        Me.Line13.X2 = 7.625!
        Me.Line13.Y1 = 4.0!
        Me.Line13.Y2 = 4.0!
        '
        'Label36
        '
        Me.Label36.Border.BottomColor = System.Drawing.Color.Black
        Me.Label36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label36.Border.LeftColor = System.Drawing.Color.Black
        Me.Label36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label36.Border.RightColor = System.Drawing.Color.Black
        Me.Label36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label36.Border.TopColor = System.Drawing.Color.Black
        Me.Label36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label36.Height = 0.1479167!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 0!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
        Me.Label36.Text = "Confecção:"
        Me.Label36.Top = 3.8125!
        Me.Label36.Width = 0.6458334!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.DataField = "Confeccao"
        Me.TextBox5.Height = 0.16875!
        Me.TextBox5.Left = 0.6875!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; "
        Me.TextBox5.Text = "TextBox1"
        Me.TextBox5.Top = 3.8125!
        Me.TextBox5.Width = 0.40625!
        '
        'Label38
        '
        Me.Label38.Border.BottomColor = System.Drawing.Color.Black
        Me.Label38.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label38.Border.LeftColor = System.Drawing.Color.Black
        Me.Label38.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label38.Border.RightColor = System.Drawing.Color.Black
        Me.Label38.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label38.Border.TopColor = System.Drawing.Color.Black
        Me.Label38.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label38.Height = 0.1479167!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 1.1875!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; "
        Me.Label38.Text = "Cor:"
        Me.Label38.Top = 3.8125!
        Me.Label38.Width = 0.2812501!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.DataField = "cor_coloracao"
        Me.TextBox7.Height = 0.16875!
        Me.TextBox7.Left = 1.5!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; "
        Me.TextBox7.Text = "TextBox1"
        Me.TextBox7.Top = 3.8125!
        Me.TextBox7.Width = 2.875!
        '
        'Line14
        '
        Me.Line14.Border.BottomColor = System.Drawing.Color.Black
        Me.Line14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line14.Border.LeftColor = System.Drawing.Color.Black
        Me.Line14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line14.Border.RightColor = System.Drawing.Color.Black
        Me.Line14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line14.Border.TopColor = System.Drawing.Color.Black
        Me.Line14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line14.Height = 1.6875!
        Me.Line14.Left = 3.9375!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 4.0!
        Me.Line14.Width = 0!
        Me.Line14.X1 = 3.9375!
        Me.Line14.X2 = 3.9375!
        Me.Line14.Y1 = 5.6875!
        Me.Line14.Y2 = 4.0!
        '
        'Label39
        '
        Me.Label39.Border.BottomColor = System.Drawing.Color.Black
        Me.Label39.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label39.Border.LeftColor = System.Drawing.Color.Black
        Me.Label39.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label39.Border.RightColor = System.Drawing.Color.Black
        Me.Label39.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label39.Border.TopColor = System.Drawing.Color.Black
        Me.Label39.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label39.DataField = "data_venda"
        Me.Label39.Height = 0.2208333!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 0.875!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 12pt; "
        Me.Label39.Text = ""
        Me.Label39.Top = 4.625!
        Me.Label39.Width = 1.020833!
        '
        'Label40
        '
        Me.Label40.Border.BottomColor = System.Drawing.Color.Black
        Me.Label40.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label40.Border.LeftColor = System.Drawing.Color.Black
        Me.Label40.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label40.Border.RightColor = System.Drawing.Color.Black
        Me.Label40.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label40.Border.TopColor = System.Drawing.Color.Black
        Me.Label40.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label40.Height = 0.1479167!
        Me.Label40.HyperLink = Nothing
        Me.Label40.Left = 0!
        Me.Label40.Name = "Label40"
        Me.Label40.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label40.Text = "Data da Venda"
        Me.Label40.Top = 4.625!
        Me.Label40.Width = 0.8020833!
        '
        'Label41
        '
        Me.Label41.Border.BottomColor = System.Drawing.Color.Black
        Me.Label41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label41.Border.LeftColor = System.Drawing.Color.Black
        Me.Label41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label41.Border.RightColor = System.Drawing.Color.Black
        Me.Label41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label41.Border.TopColor = System.Drawing.Color.Black
        Me.Label41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label41.Height = 0.1854167!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 0!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label41.Text = "Data previsão entrega"
        Me.Label41.Top = 4.875!
        Me.Label41.Width = 1.375!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.CanGrow = False
        Me.TextBox8.DataField = "observacao"
        Me.TextBox8.Height = 1.457956!
        Me.TextBox8.Left = 4.0!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "ddo-char-set: 1; font-weight: normal; font-size: 10pt; "
        Me.TextBox8.Text = "TextBox2"
        Me.TextBox8.Top = 4.1875!
        Me.TextBox8.Width = 3.610237!
        '
        'Label45
        '
        Me.Label45.Border.BottomColor = System.Drawing.Color.Black
        Me.Label45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label45.Border.LeftColor = System.Drawing.Color.Black
        Me.Label45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label45.Border.RightColor = System.Drawing.Color.Black
        Me.Label45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label45.Border.TopColor = System.Drawing.Color.Black
        Me.Label45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label45.Height = 0.1479167!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 4.0!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label45.Text = "Obs."
        Me.Label45.Top = 4.0!
        Me.Label45.Width = 0.8020833!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.DataField = "data_previsao_entrega"
        Me.TextBox9.Height = 0.21875!
        Me.TextBox9.Left = 0!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 14pt; "
        Me.TextBox9.Text = "TextBox"
        Me.TextBox9.Top = 5.0625!
        Me.TextBox9.Width = 1.354167!
        '
        'Line16
        '
        Me.Line16.Border.BottomColor = System.Drawing.Color.Black
        Me.Line16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line16.Border.LeftColor = System.Drawing.Color.Black
        Me.Line16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line16.Border.RightColor = System.Drawing.Color.Black
        Me.Line16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line16.Border.TopColor = System.Drawing.Color.Black
        Me.Line16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line16.Height = 0!
        Me.Line16.Left = 0!
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 4.625!
        Me.Line16.Width = 3.9375!
        Me.Line16.X1 = 0!
        Me.Line16.X2 = 3.9375!
        Me.Line16.Y1 = 4.625!
        Me.Line16.Y2 = 4.625!
        '
        'fldCodFilialCliente
        '
        Me.fldCodFilialCliente.Border.BottomColor = System.Drawing.Color.Black
        Me.fldCodFilialCliente.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCodFilialCliente.Border.LeftColor = System.Drawing.Color.Black
        Me.fldCodFilialCliente.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCodFilialCliente.Border.RightColor = System.Drawing.Color.Black
        Me.fldCodFilialCliente.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCodFilialCliente.Border.TopColor = System.Drawing.Color.Black
        Me.fldCodFilialCliente.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCodFilialCliente.DataField = "COD_FILIAL_CLIENTE"
        Me.fldCodFilialCliente.Height = 0.16875!
        Me.fldCodFilialCliente.Left = 0.625!
        Me.fldCodFilialCliente.Name = "fldCodFilialCliente"
        Me.fldCodFilialCliente.OutputFormat = resources.GetString("fldCodFilialCliente.OutputFormat")
        Me.fldCodFilialCliente.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; "
        Me.fldCodFilialCliente.Text = "TextBox1"
        Me.fldCodFilialCliente.Top = 4.0!
        Me.fldCodFilialCliente.Visible = False
        Me.fldCodFilialCliente.Width = 0.3541667!
        '
        'fldCodCliente
        '
        Me.fldCodCliente.Border.BottomColor = System.Drawing.Color.Black
        Me.fldCodCliente.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCodCliente.Border.LeftColor = System.Drawing.Color.Black
        Me.fldCodCliente.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCodCliente.Border.RightColor = System.Drawing.Color.Black
        Me.fldCodCliente.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCodCliente.Border.TopColor = System.Drawing.Color.Black
        Me.fldCodCliente.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCodCliente.DataField = "COD_CLIENTE"
        Me.fldCodCliente.Height = 0.16875!
        Me.fldCodCliente.Left = 0!
        Me.fldCodCliente.Name = "fldCodCliente"
        Me.fldCodCliente.OutputFormat = resources.GetString("fldCodCliente.OutputFormat")
        Me.fldCodCliente.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; "
        Me.fldCodCliente.Text = "TextBox1"
        Me.fldCodCliente.Top = 4.1875!
        Me.fldCodCliente.Width = 0.5!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Height = 0.1479167!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
        Me.Label4.Text = "Cliente:"
        Me.Label4.Top = 4.0!
        Me.Label4.Width = 0.4583333!
        '
        'Barcode
        '
        Me.Barcode.Border.BottomColor = System.Drawing.Color.Black
        Me.Barcode.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode.Border.LeftColor = System.Drawing.Color.Black
        Me.Barcode.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode.Border.RightColor = System.Drawing.Color.Black
        Me.Barcode.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode.Border.TopColor = System.Drawing.Color.Black
        Me.Barcode.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Barcode.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Barcode.Height = 0.5!
        Me.Barcode.Left = 2.75!
        Me.Barcode.Name = "Barcode"
        Me.Barcode.Style = DataDynamics.ActiveReports.BarCodeStyle.Code_128_A
        Me.Barcode.Top = 0.6875!
        Me.Barcode.Width = 1.3125!
        '
        'txtTratamento
        '
        Me.txtTratamento.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTratamento.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTratamento.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTratamento.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTratamento.Border.RightColor = System.Drawing.Color.Black
        Me.txtTratamento.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTratamento.Border.TopColor = System.Drawing.Color.Black
        Me.txtTratamento.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTratamento.Height = 0.1875!
        Me.txtTratamento.Left = 4.1875!
        Me.txtTratamento.Name = "txtTratamento"
        Me.txtTratamento.OutputFormat = resources.GetString("txtTratamento.OutputFormat")
        Me.txtTratamento.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 12pt; "
        Me.txtTratamento.Text = Nothing
        Me.txtTratamento.Top = 0.75!
        Me.txtTratamento.Width = 2.395833!
        '
        'Label35
        '
        Me.Label35.Border.BottomColor = System.Drawing.Color.Black
        Me.Label35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label35.Border.LeftColor = System.Drawing.Color.Black
        Me.Label35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label35.Border.RightColor = System.Drawing.Color.Black
        Me.Label35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label35.Border.TopColor = System.Drawing.Color.Black
        Me.Label35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label35.Height = 0.1479167!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 4.1875!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
        Me.Label35.Text = "Tratamento:"
        Me.Label35.Top = 0.625!
        Me.Label35.Width = 0.9166667!
        '
        'Line15
        '
        Me.Line15.Border.BottomColor = System.Drawing.Color.Black
        Me.Line15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line15.Border.LeftColor = System.Drawing.Color.Black
        Me.Line15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line15.Border.RightColor = System.Drawing.Color.Black
        Me.Line15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line15.Border.TopColor = System.Drawing.Color.Black
        Me.Line15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line15.Height = 0!
        Me.Line15.Left = 0!
        Me.Line15.LineWeight = 1.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 0.625!
        Me.Line15.Width = 7.625!
        Me.Line15.X1 = 0!
        Me.Line15.X2 = 7.625!
        Me.Line15.Y1 = 0.625!
        Me.Line15.Y2 = 0.625!
        '
        'lblNpedido
        '
        Me.lblNpedido.Border.BottomColor = System.Drawing.Color.Black
        Me.lblNpedido.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNpedido.Border.LeftColor = System.Drawing.Color.Black
        Me.lblNpedido.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNpedido.Border.RightColor = System.Drawing.Color.Black
        Me.lblNpedido.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNpedido.Border.TopColor = System.Drawing.Color.Black
        Me.lblNpedido.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblNpedido.DataField = "num_pedido"
        Me.lblNpedido.Height = 0.1875!
        Me.lblNpedido.HyperLink = Nothing
        Me.lblNpedido.Left = 6.625!
        Me.lblNpedido.Name = "lblNpedido"
        Me.lblNpedido.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; "
        Me.lblNpedido.Text = ""
        Me.lblNpedido.Top = 0.8125!
        Me.lblNpedido.Width = 0.9375!
        '
        'lblLab
        '
        Me.lblLab.Border.BottomColor = System.Drawing.Color.Black
        Me.lblLab.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblLab.Border.LeftColor = System.Drawing.Color.Black
        Me.lblLab.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblLab.Border.RightColor = System.Drawing.Color.Black
        Me.lblLab.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblLab.Border.TopColor = System.Drawing.Color.Black
        Me.lblLab.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblLab.DataField = "id_laboratorio"
        Me.lblLab.Height = 0.1500001!
        Me.lblLab.HyperLink = Nothing
        Me.lblLab.Left = 5.5625!
        Me.lblLab.Name = "lblLab"
        Me.lblLab.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; "
        Me.lblLab.Text = ""
        Me.lblLab.Top = 1.0!
        Me.lblLab.Width = 2.0!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.DataField = "BASE_NOVAOD"
        Me.TextBox10.Height = 0.16875!
        Me.TextBox10.Left = 6.5!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
        Me.TextBox10.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; "
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 2.0!
        Me.TextBox10.Width = 0.40625!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.DataField = "BASE_NOVAOE"
        Me.TextBox11.Height = 0.16875!
        Me.TextBox11.Left = 6.5!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.OutputFormat = resources.GetString("TextBox11.OutputFormat")
        Me.TextBox11.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; "
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 2.25!
        Me.TextBox11.Width = 0.40625!
        '
        'Line3
        '
        Me.Line3.Border.BottomColor = System.Drawing.Color.Black
        Me.Line3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.LeftColor = System.Drawing.Color.Black
        Me.Line3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.RightColor = System.Drawing.Color.Black
        Me.Line3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.TopColor = System.Drawing.Color.Black
        Me.Line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Height = 0.625!
        Me.Line3.Left = 2.6875!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.625!
        Me.Line3.Width = 0!
        Me.Line3.X1 = 2.6875!
        Me.Line3.X2 = 2.6875!
        Me.Line3.Y1 = 1.25!
        Me.Line3.Y2 = 0.625!
        '
        'Line4
        '
        Me.Line4.Border.BottomColor = System.Drawing.Color.Black
        Me.Line4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.LeftColor = System.Drawing.Color.Black
        Me.Line4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.RightColor = System.Drawing.Color.Black
        Me.Line4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.TopColor = System.Drawing.Color.Black
        Me.Line4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Height = 0.625!
        Me.Line4.Left = 4.1875!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.625!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 4.1875!
        Me.Line4.X2 = 4.1875!
        Me.Line4.Y1 = 1.25!
        Me.Line4.Y2 = 0.625!
        '
        'Label42
        '
        Me.Label42.Border.BottomColor = System.Drawing.Color.Black
        Me.Label42.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label42.Border.LeftColor = System.Drawing.Color.Black
        Me.Label42.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label42.Border.RightColor = System.Drawing.Color.Black
        Me.Label42.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label42.Border.TopColor = System.Drawing.Color.Black
        Me.Label42.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label42.Height = 0.1479167!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 4.1875!
        Me.Label42.Name = "Label42"
        Me.Label42.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
        Me.Label42.Text = "Laboratório Montagem:"
        Me.Label42.Top = 1.0!
        Me.Label42.Width = 1.3125!
        '
        'Label46
        '
        Me.Label46.Border.BottomColor = System.Drawing.Color.Black
        Me.Label46.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label46.Border.LeftColor = System.Drawing.Color.Black
        Me.Label46.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label46.Border.RightColor = System.Drawing.Color.Black
        Me.Label46.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label46.Border.TopColor = System.Drawing.Color.Black
        Me.Label46.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label46.Height = 0.1479167!
        Me.Label46.HyperLink = Nothing
        Me.Label46.Left = 6.625!
        Me.Label46.Name = "Label46"
        Me.Label46.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
        Me.Label46.Text = "Pedido:"
        Me.Label46.Top = 0.625!
        Me.Label46.Width = 0.375!
        '
        'fldOSLocal
        '
        Me.fldOSLocal.Border.BottomColor = System.Drawing.Color.Black
        Me.fldOSLocal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldOSLocal.Border.LeftColor = System.Drawing.Color.Black
        Me.fldOSLocal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldOSLocal.Border.RightColor = System.Drawing.Color.Black
        Me.fldOSLocal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldOSLocal.Border.TopColor = System.Drawing.Color.Black
        Me.fldOSLocal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldOSLocal.DataField = "cod_os"
        Me.fldOSLocal.Height = 0.1875!
        Me.fldOSLocal.Left = 0.6875!
        Me.fldOSLocal.Name = "fldOSLocal"
        Me.fldOSLocal.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 12pt; "
        Me.fldOSLocal.Text = "TextBox"
        Me.fldOSLocal.Top = 0.75!
        Me.fldOSLocal.Width = 0.8333333!
        '
        'Label47
        '
        Me.Label47.Border.BottomColor = System.Drawing.Color.Black
        Me.Label47.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label47.Border.LeftColor = System.Drawing.Color.Black
        Me.Label47.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label47.Border.RightColor = System.Drawing.Color.Black
        Me.Label47.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label47.Border.TopColor = System.Drawing.Color.Black
        Me.Label47.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label47.Height = 0.1479167!
        Me.Label47.HyperLink = Nothing
        Me.Label47.Left = 0!
        Me.Label47.Name = "Label47"
        Me.Label47.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label47.Text = "Laboratório:"
        Me.Label47.Top = 0.625!
        Me.Label47.Width = 0.625!
        '
        'fldLaborat
        '
        Me.fldLaborat.Border.BottomColor = System.Drawing.Color.Black
        Me.fldLaborat.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLaborat.Border.LeftColor = System.Drawing.Color.Black
        Me.fldLaborat.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLaborat.Border.RightColor = System.Drawing.Color.Black
        Me.fldLaborat.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLaborat.Border.TopColor = System.Drawing.Color.Black
        Me.fldLaborat.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldLaborat.DataField = "id_filial"
        Me.fldLaborat.Height = 0.1875!
        Me.fldLaborat.Left = 0.0625!
        Me.fldLaborat.Name = "fldLaborat"
        Me.fldLaborat.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 12pt; "
        Me.fldLaborat.Text = "TextBox"
        Me.fldLaborat.Top = 0.75!
        Me.fldLaborat.Width = 0.5625!
        '
        'Label48
        '
        Me.Label48.Border.BottomColor = System.Drawing.Color.Black
        Me.Label48.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label48.Border.LeftColor = System.Drawing.Color.Black
        Me.Label48.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label48.Border.RightColor = System.Drawing.Color.Black
        Me.Label48.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label48.Border.TopColor = System.Drawing.Color.Black
        Me.Label48.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label48.Height = 0.1479167!
        Me.Label48.HyperLink = Nothing
        Me.Label48.Left = 0.6875!
        Me.Label48.Name = "Label48"
        Me.Label48.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.Label48.Text = "Ordem Serviço:"
        Me.Label48.Top = 0.625!
        Me.Label48.Width = 0.8229167!
        '
        'lblVia
        '
        Me.lblVia.Border.BottomColor = System.Drawing.Color.Black
        Me.lblVia.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVia.Border.LeftColor = System.Drawing.Color.Black
        Me.lblVia.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVia.Border.RightColor = System.Drawing.Color.Black
        Me.lblVia.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVia.Border.TopColor = System.Drawing.Color.Black
        Me.lblVia.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblVia.DataField = "via"
        Me.lblVia.Height = 0.2208333!
        Me.lblVia.HyperLink = Nothing
        Me.lblVia.Left = 1.625!
        Me.lblVia.Name = "lblVia"
        Me.lblVia.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 12pt; "
        Me.lblVia.Text = ""
        Me.lblVia.Top = 1.0625!
        Me.lblVia.Width = 0.875!
        '
        'lblextra
        '
        Me.lblextra.Border.BottomColor = System.Drawing.Color.Black
        Me.lblextra.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblextra.Border.LeftColor = System.Drawing.Color.Black
        Me.lblextra.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblextra.Border.RightColor = System.Drawing.Color.Black
        Me.lblextra.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblextra.Border.TopColor = System.Drawing.Color.Black
        Me.lblextra.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblextra.DataField = "extra"
        Me.lblextra.Height = 0.1479167!
        Me.lblextra.HyperLink = Nothing
        Me.lblextra.Left = 0!
        Me.lblextra.Name = "lblextra"
        Me.lblextra.Style = "ddo-char-set: 1; font-size: 8pt; "
        Me.lblextra.Text = "Extra"
        Me.lblextra.Top = 5.5625!
        Me.lblextra.Visible = False
        Me.lblextra.Width = 0.8645833!
        '
        'bcOtica
        '
        Me.bcOtica.Border.BottomColor = System.Drawing.Color.Black
        Me.bcOtica.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.bcOtica.Border.LeftColor = System.Drawing.Color.Black
        Me.bcOtica.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.bcOtica.Border.RightColor = System.Drawing.Color.Black
        Me.bcOtica.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.bcOtica.Border.TopColor = System.Drawing.Color.Black
        Me.bcOtica.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.bcOtica.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.bcOtica.Height = 0.5!
        Me.bcOtica.Left = 2.3125!
        Me.bcOtica.Name = "bcOtica"
        Me.bcOtica.Style = DataDynamics.ActiveReports.BarCodeStyle.Code_128_A
        Me.bcOtica.Top = 4.9375!
        Me.bcOtica.Width = 1.3125!
        '
        'txtCodVendedora
        '
        Me.txtCodVendedora.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCodVendedora.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodVendedora.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCodVendedora.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodVendedora.Border.RightColor = System.Drawing.Color.Black
        Me.txtCodVendedora.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodVendedora.Border.TopColor = System.Drawing.Color.Black
        Me.txtCodVendedora.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCodVendedora.DataField = "COD_vendedora"
        Me.txtCodVendedora.Height = 0.16875!
        Me.txtCodVendedora.Left = 4.4375!
        Me.txtCodVendedora.Name = "txtCodVendedora"
        Me.txtCodVendedora.OutputFormat = resources.GetString("txtCodVendedora.OutputFormat")
        Me.txtCodVendedora.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; "
        Me.txtCodVendedora.Text = "TextBox1"
        Me.txtCodVendedora.Top = 3.8125!
        Me.txtCodVendedora.Visible = False
        Me.txtCodVendedora.Width = 0.3541667!
        '
        'txtVendedora
        '
        Me.txtVendedora.Border.BottomColor = System.Drawing.Color.Black
        Me.txtVendedora.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVendedora.Border.LeftColor = System.Drawing.Color.Black
        Me.txtVendedora.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVendedora.Border.RightColor = System.Drawing.Color.Black
        Me.txtVendedora.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVendedora.Border.TopColor = System.Drawing.Color.Black
        Me.txtVendedora.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtVendedora.DataField = "NOME_CLIENTE"
        Me.txtVendedora.Height = 0.16875!
        Me.txtVendedora.Left = 4.8125!
        Me.txtVendedora.Name = "txtVendedora"
        Me.txtVendedora.OutputFormat = resources.GetString("txtVendedora.OutputFormat")
        Me.txtVendedora.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; "
        Me.txtVendedora.Text = "TextBox1"
        Me.txtVendedora.Top = 3.8125!
        Me.txtVendedora.Width = 2.8125!
        '
        'Label37
        '
        Me.Label37.Border.BottomColor = System.Drawing.Color.Black
        Me.Label37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label37.Border.LeftColor = System.Drawing.Color.Black
        Me.Label37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label37.Border.RightColor = System.Drawing.Color.Black
        Me.Label37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label37.Border.TopColor = System.Drawing.Color.Black
        Me.Label37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label37.Height = 0.2!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 2.3125!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 6pt; "
        Me.Label37.Text = "Código de Barras Ótica"
        Me.Label37.Top = 5.4375!
        Me.Label37.Width = 1.3125!
        '
        'txtNExtra
        '
        Me.txtNExtra.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNExtra.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNExtra.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNExtra.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNExtra.Border.RightColor = System.Drawing.Color.Black
        Me.txtNExtra.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNExtra.Border.TopColor = System.Drawing.Color.Black
        Me.txtNExtra.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNExtra.Height = 0.2!
        Me.txtNExtra.Left = 6.25!
        Me.txtNExtra.Name = "txtNExtra"
        Me.txtNExtra.Style = "ddo-char-set: 1; font-weight: bold; "
        Me.txtNExtra.Text = Nothing
        Me.txtNExtra.Top = 1.4375!
        Me.txtNExtra.Width = 1.0!
        '
        'Label43
        '
        Me.Label43.Border.BottomColor = System.Drawing.Color.Black
        Me.Label43.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label43.Border.LeftColor = System.Drawing.Color.Black
        Me.Label43.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label43.Border.RightColor = System.Drawing.Color.Black
        Me.Label43.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label43.Border.TopColor = System.Drawing.Color.Black
        Me.Label43.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label43.DataField = "armacao"
        Me.Label43.Height = 0.182661!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 5.9375!
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; font-size: 10pt; "
        Me.Label43.Text = ""
        Me.Label43.Top = 2.875!
        Me.Label43.Width = 1.677083!
        '
        'rptOS
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Left = 0.1965278!
        Me.PageSettings.Margins.Right = 0.1965278!
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.268056!
        Me.PrintWidth = 7.647802!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" &
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
        CType(Me.PicExtra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldLoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldEspecieOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldLenteOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCodFabOE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldLenteOE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldNomeTabOE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldTipoTAbOE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldTipoTabOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldNomeTabOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldEsfODLonge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCilODLonge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldEixoOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDpOdLonge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldAlturaOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldEsfOeLonge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCilOELonge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldEixo_oe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDnpOELonge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldAlturaOE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldEsfODPeerto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCilODPerto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDnpODPerto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldEsfOEPerto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCilOEPerto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDNPOEPerto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldBaseOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldBaseOE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldAdicaoOE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldAdicaoOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDiametroOE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDiametroOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldAroHorizontal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldArmacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCodFilialCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCodCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTratamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNpedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldOSLocal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldLaborat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblVia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblextra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodVendedora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVendedora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNExtra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
    Public Fila As Boolean
    Dim tb As New DataTable
    Dim pedido As New DataTable
    Public r As New rptPedido
    Public r2 As New rptPedido
    Dim d As New dados
    Dim andamentos As New objAndamentos
    Dim os As ObjOS
    Dim user As objUsuario
    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Dim sql, via As String
        Dim i As Integer = 0
        i = fldLoja.Text.Length
        fldLoja.Text = adiciona_zeros(fldLoja.Text, 3)
        fldOS.Text = adiciona_zeros(fldOS.Text, 6)
        If fldLoja.Text < 1000 Then
            bcOtica.Text = "O" & fldLoja.Text & fldOS.Text
            bcOtica.Visible = True
        Else
            bcOtica.Visible = False
        End If
        'OS Local
        i = fldLaborat.Text
        fldLaborat.Text = adiciona_zeros(fldLaborat.Text, 3)
        fldOSLocal.Text = adiciona_zeros(fldOSLocal.Text, 6)
        os = New ObjOS(fldOSLocal.Text, fldLaborat.Text)
        user = New objUsuario(txtCodVendedora.Text)
        txtVendedora.Text = user.nome
        Armacao()

        fldDpOdLonge.Visible = True
        fldDnpODPerto.Visible = True
        fldEixoOD.Visible = True
        fldAlturaOD.Visible = True

        fldDnpOELonge.Visible = True
        fldDNPOEPerto.Visible = True
        fldEixo_oe.Visible = True
        fldAlturaOE.Visible = True

        'Ivanildo 22/01/2015
        If os.cod_tab_od = 0 Then
            fldEspecieOD.Text = ""
            fldLenteOD.Text = ""
        End If
        If os.cod_tab_oe = 0 Then
            fldCodFabOE.Text = ""
            fldLenteOE.Text = ""
        End If
        If os.cod_tab_od = 0 Then
            fldTipoTabOD.Text = ""
            fldNomeTabOD.Text = ""
        End If
        If os.cod_tab_oe = 0 Then
            fldTipoTAbOE.Text = ""
            fldNomeTabOE.Text = ""
        End If
        'Fim 22/01/2015

        'Tipos Receita
        If os.tipo_receita_OD = tipo_Receita.PROGRESSIVA Or os.tipo_receita_OD = tipo_Receita.BIFOCAL Then
            fldEsfODPeerto.Visible = True
            fldCilODPerto.Visible = True

            fldEsfODLonge.Visible = True
            fldCilODLonge.Visible = True
        End If
        If os.tipo_receita_OE = tipo_Receita.PROGRESSIVA Or os.tipo_receita_OE = tipo_Receita.BIFOCAL Then
            fldEsfOEPerto.Visible = True
            fldCilOEPerto.Visible = True

            fldEsfOeLonge.Visible = True
            fldCilOELonge.Visible = True
        End If


        If os.tipo_receita_OD = tipo_Receita.VISAO_simples_longe Then
            fldEsfODPeerto.Visible = False
            fldCilODPerto.Visible = False

            fldEsfODLonge.Visible = True
            fldCilODLonge.Visible = True
        End If
        If os.tipo_receita_OE = tipo_Receita.VISAO_simples_longe Then
            fldEsfOEPerto.Visible = False
            fldCilOEPerto.Visible = False

            fldEsfOeLonge.Visible = True
            fldCilOELonge.Visible = True
        End If

        If os.tipo_receita_OD = tipo_Receita.VISAO_simples_perto Then
            fldEsfODPeerto.Visible = True
            fldCilODPerto.Visible = True

            fldEsfODLonge.Visible = False
            fldCilODLonge.Visible = False
        End If
        If os.tipo_receita_OE = tipo_Receita.VISAO_simples_perto Then
            fldEsfOEPerto.Visible = True
            fldCilOEPerto.Visible = True

            fldEsfOeLonge.Visible = False
            fldCilOELonge.Visible = False
        End If

        Barcode.Text = fldLaborat.Text & fldOSLocal.Text
        Barcode.Visible = True
        lblData.Text = Now.ToString("dd/MM/yy")
        'Lentes Estoque
        txtTratamento.Text = tratamentos(CInt(fldLaborat.Text), CInt(fldOSLocal.Text))
        lblLab.Text = laboratorio(lblLab.Text)

        via = lblVia.Text
        lblVia.Text = "Via: " & lblVia.Text & "ª"
        lblVia.Visible = True
        fldLenteOE.Visible = True
        fldNomeTabOE.Visible = True
        fldLenteOD.Visible = True
        fldNomeTabOD.Visible = True
        txtNExtra.Visible = False
        If lblextra.Text = "S" Then
            PicExtra.Visible = True
            extra()
        Else
            PicExtra.Visible = False
        End If
        txtCliente.Text = Cliente()
        eixo()
        If Fila = True Then
            sql = "update fila_impressao_os set data_impressao = " & d.pdtm(d.hora) &
            " Where cod_os = " & fldOSLocal.Text & " and id_filial = " &
            fldLaborat.Text & " and via = " & via & ""
            d.Comando(sql, False)
            If via = 1 Then
                andamentos.insere_andamento(objAndamentos.tipo.impressao_os, fldLaborat.Text,
                fldOSLocal.Text, UserID, "Impressão " & via & "ª via da OS")

            Else
                andamentos.insere_andamento(objAndamentos.tipo.reimpressao_os, fldLaborat.Text,
                            fldOSLocal.Text, UserID, "Impressão " & via & "ª via da OS")
            End If
            sql = "update os set cod_fase = " & Fases_os.Estoque_Aguardando_Laboratório &
               " where cod_os = " & fldOSLocal.Text & " and id_filial =" & fldLaborat.Text & ""
            d.Comando(sql, True)
        Else
            lblVia.Visible = False
            bcOtica.Visible = False
            Barcode.Visible = False
        End If

        subItens.Report = r
        SubReport1.Report = r2

    End Sub
    Private Sub eixo()
        If os.tipo_receita_OD = tipo_Receita.PROGRESSIVA Or os.tipo_receita_OD = tipo_Receita.BIFOCAL Then
            If os.cil_od_longe = 0 Or os.cil_od_longe Is DBNull.Value Then
                fldEixoOD.Visible = False
            Else
                fldEixoOD.Visible = True
            End If

        End If
        If os.tipo_receita_OE = tipo_Receita.PROGRESSIVA Or os.tipo_receita_OE = tipo_Receita.BIFOCAL Then
            If os.cil_oe_longe = 0 Or os.cil_oe_longe Is DBNull.Value Then
                fldEixo_oe.Visible = False
            Else
                fldEixo_oe.Visible = True
            End If
        End If


        If os.tipo_receita_OD = tipo_Receita.VISAO_simples_longe Then
            If os.cil_od_longe = 0 Or os.cil_od_longe Is DBNull.Value Then
                fldEixoOD.Visible = False
            Else
                fldEixoOD.Visible = True
            End If
        End If

        If os.tipo_receita_OE = tipo_Receita.VISAO_simples_longe Then
            If os.cil_oe_longe = 0 Or os.cil_oe_longe Is DBNull.Value Then
                fldEixo_oe.Visible = False
            Else
                fldEixo_oe.Visible = True
            End If
        End If

        If os.tipo_receita_OD = tipo_Receita.VISAO_simples_perto Then
            If os.cil_od_perto = 0 Or os.cil_od_perto Is DBNull.Value Then
                fldEixoOD.Visible = False
            Else
                fldEixoOD.Visible = True
            End If
        End If
        If os.tipo_receita_OE = tipo_Receita.VISAO_simples_perto Then
            If os.cil_oe_perto = 0 Or os.cil_oe_perto Is DBNull.Value Then
                fldEixo_oe.Visible = False
            Else
                fldEixo_oe.Visible = True
            End If
        End If
    End Sub
    Private Sub Armacao()
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select tipo_armacao from tipo_armacao where cod_tipo_armacao = " & os.cod_tipo_armacao & ""
        d.carrega_Tabela(sql, tt)
        Try
            fldArmacao.Text = tt.Rows(0)("tipo_armacao")
        Catch ex As Exception

        End Try
    End Sub
    Private Function laboratorio(ByVal id_lab As Integer)
        Dim tb As New DataTable
        d.carrega_Tabela("Select * from laboratorio_montagem where id_laboratorio = " & id_lab & "", tb)
        Try
            Return tb.Rows(0)("laboratorio")
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function Cliente() As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select nome_cliente from cliente where cod_filial_cliente = " & fldCodFilialCliente.Text & _
        " and cod_cliente = " & fldCodCliente.Text & ""
        d.carrega_Tabela(sql, tt)
        Try
            Return tt.Rows(0)("nome_cliente")
        Catch ex As Exception

        End Try
    End Function
    Private Sub extra()
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select cod_saida_extra,od,oe from saida_extra where cod_os = " & fldOSLocal.Text & _
        " and id_filial = " & fldLaborat.Text & " order by cod_saida_Extra Desc"
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            txtNExtra.Visible = True
            txtNExtra.Text = "Extra Nº " & tt.Rows(0)("cod_saida_extra")
            If tt.Rows(0)("od") = "S" Then
                fldLenteOD.Visible = True
                fldNomeTabOD.Visible = True
                fldEsfODLonge.Visible = True
                fldCilODLonge.Visible = True
                fldEsfODPeerto.Visible = True
                fldCilODPerto.Visible = True
                fldDpOdLonge.Visible = True
                fldDnpODPerto.Visible = True
                fldEixoOD.Visible = True
                fldAlturaOD.Visible = True
            Else
                fldLenteOD.Visible = False
                fldNomeTabOD.Visible = False
                fldEsfODLonge.Visible = False
                fldCilODLonge.Visible = False
                fldEsfODPeerto.Visible = False
                fldCilODPerto.Visible = False
                fldDpOdLonge.Visible = False
                fldDnpODPerto.Visible = False
                fldEixoOD.Visible = False
                fldAlturaOD.Visible = False
            End If
            If tt.Rows(0)("oe") = "S" Then
                fldLenteOE.Visible = True
                fldNomeTabOE.Visible = True
                fldEsfOeLonge.Visible = True
                fldCilOELonge.Visible = True
                fldEsfOEPerto.Visible = True
                fldCilOEPerto.Visible = True
                fldDnpOELonge.Visible = True
                fldDNPOEPerto.Visible = True
                fldEixo_oe.Visible = True
                fldAlturaOE.Visible = True
            Else
                fldLenteOE.Visible = False
                fldNomeTabOE.Visible = False
                fldEsfOeLonge.Visible = False
                fldCilOELonge.Visible = False
                fldEsfOEPerto.Visible = False
                fldCilOEPerto.Visible = False
                fldDnpOELonge.Visible = False
                fldDNPOEPerto.Visible = False
                fldEixo_oe.Visible = False
                fldAlturaOE.Visible = False
            End If
        End If
    End Sub
    Private Sub rptOS_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        
    End Sub
    Private Function retorna_lente(ByVal codigo_grupo As String, ByVal codigo_tipo As String) As String
        Dim tbLen As New Data.DataTable
        Dim sql As String
        Dim Retorno As String
        sql = "Select descricao from s1grplen where codigo_grupo = '" & codigo_grupo & "'"
        Try
            d.carrega_Tabela(sql, tbLen)
            Retorno = codigo_grupo & "-" & tbLen.Rows(0)("descricao")
        Catch ex As Exception
            Retorno = "Sem Grupo"
        End Try
        sql = "Select descricao from s2tiplen where codigo_grupo = '" & codigo_grupo & "' " & _
        "and codigo_tipo ='" & codigo_tipo & "'"
        Try
            d.carrega_Tabela(sql, tbLen)
            Retorno = Retorno & " " & codigo_tipo & "-" & tbLen.Rows(0)("descricao")
        Catch ex As Exception
            Retorno = Retorno & " Sem Lente"
        End Try
        Return Retorno
    End Function
    Private Function retorna_lente_tab(ByVal codigo_grupo As String, ByVal codigo_tipo As String) As String
        Dim tbLen As New Data.DataTable
        Dim sql As String
        Dim Retorno As String
        sql = "Select descricao from t3tabpre where codigo_grupo_tp = '" & codigo_grupo & "' " & _
        "and sequencial = '" & codigo_tipo & "'"
        Try
            d.carrega_Tabela(sql, tbLen)
            Retorno = tbLen.Rows(0)("descricao")
        Catch ex As Exception
            Retorno = "Sem Lente"
        End Try
        Return Retorno
    End Function
    Private Function armacao(ByVal tipo As String)
        If tipo = "Z" Then Return "Zylo"
        If tipo = "M" Then Return "Metal"
        If tipo = "N" Then Return "Fio de Nylon"
        If tipo = "F" Then Return "Fibra de Carbono"
        If tipo = "P" Then Return "Parafusada"
    End Function
    Private Sub via()
        Dim sql As String
        Dim tb As DataTable
        sql = "SELECT Last(fila_impressao_estoque.tipo) AS tipo, Last(fila_impressao_estoque.via) AS via " & _
        " FROM fila_impressao_estoque where " & _
        "codigo_filial= '" & fldLoja.Text & "' AND " & _
        "ordem_servico= '" & fldOS.Text & "'"
        d.carrega_Tabela(sql, tb)
        'lblTipo.Text = tb.Rows(0)("tipo")
        'lblVia.Text = tb.Rows(0)("via") & " VIA"
        ' tb.Dispose()
    End Sub
    Private Function tratamentos(ByVal id_filial As Integer, ByVal cod_os As Integer) As String
        Dim tTrat As New DataTable
        Dim strTratamentos As String = ""
        Dim sql As String
        Dim i As Integer = 0
        sql = "SELECT produtos.produto " & _
        "FROM tratamentos_os INNER JOIN " & _
        "produtos ON tratamentos_os.cod_produto = produtos.cod_produto " & _
        "where id_filial = " & id_filial & " and cod_os = " & cod_os & ""
        d.carrega_Tabela(sql, tTrat)

        While i < tTrat.Rows.Count
            If strTratamentos.Length = 0 Then
                strTratamentos = tTrat.Rows(i)(0)
            Else
                strTratamentos = strTratamentos & ";" & tTrat.Rows(i)(0)
            End If
            i = i + 1
        End While
        strTratamentos = strTratamentos & "."
        Return strTratamentos
    End Function
End Class
