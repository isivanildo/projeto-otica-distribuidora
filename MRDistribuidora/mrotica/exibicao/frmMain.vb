Imports System.IO
Imports mrotica_util
Imports MRUtil
Imports System.Reflection
Imports System.Net
Imports System.Data
Imports System.Data.SqlClient
Public Class frmMain
    Inherits System.Windows.Forms.Form
    Dim d As New dados
    Dim dbCon As New ConexaoDB
    Dim arq As New Arquivo
    Dim UserPermissao As New UsuarioPermissao
    Dim user As New objUsuario
    Dim anda As New objAndamentos
    Public intCodigoUsuario As Integer
    Public strSenhaUsuario As String = ""
    Dim acesso As New objMaster

#Region "Form generated"
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GerencialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Relat�rioDeSa�dasDeLentePorPer�odoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Confer�nciaEEntradaDeNFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OssN�oConclu�dasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaixaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Relat�riosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DespesasPer�odoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TratamentoCrizalPer�odoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompraDeCr�ditosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjusteContagemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrocaDeDioptriaEstoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TratamentosOptikotEOptikotEasyClean�ticasAnaMariaPorPer�odoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbreNotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabelaDeLentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilitariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovaTabelaPromocionalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbreTabelaPromocionalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Relat�rio360AnaMariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TratamentoAntiRiscoNoPer�odoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Relat�rioPontua��esAnaMariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosN�oFaturadosPorClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FaturasComSaldoPorClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Confirma��oCr�ditoCancelamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrocarSenhaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RElat�riosOSsLentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OssComLifestyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoletosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaixaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BalcaoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AndamentosOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaldosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AvisoOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Saldos�ticaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelamentoDeOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumoNfePer�odoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PdfExport As DataDynamics.ActiveReports.Export.Pdf.PdfExport
    Friend WithEvents ImportarOSLabonorteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AndamentosUtilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjusteEstoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidoProdu��oToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidoLabonorteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlanoDeContasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Relat�rioSaldoPre�oCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FornecedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDivisao As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblData As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Usu�riosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinanceiroToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntradaManualNoEstoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Devolu��oParaOEstoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FamiliaDeLentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinanceiroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FaturamentoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerfilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Relat�rios2�ViaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosADevolverAoFornecedorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosEstornadosParaOEstoqueToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntradaNotaFiscalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mmGeral As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPedido As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents NovoPedidoCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirPedidoCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConferirPedidoCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompraDeLentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnOS As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents AvisoSobreAOS�ticaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OSPendentePorFornecedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OSsPendentePorForneceodr�ticaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OSsPendentesPorFornLabonorteecedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnMovimento As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents SaldoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GiroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarOSsPNomeDoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AvisoSobreAOSsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PararOSTemporariamenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReativarOSParadaNoEstoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetornoOSFeitaForaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OSPedidasPendentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OSsPendentesDataVerifica��oToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBaixaOsPedido As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents Sa�daOSLaborat�rioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnTrocaProduto As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents TrocaProdutoOSLabonorteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSaidaExtra As System.Windows.Forms.ToolStripButton
    Friend WithEvents BaixaOSLabonorteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BaixaOS�ticaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LentesEBlocosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabelaDeLentesToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Saldo�ticaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Servi�osToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAndamentos As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents AndamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Andamentos�ticaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Confer�nciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BaixaPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Impress�oDeOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EtiquetaUsu�rioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EtiquetaAndamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCaixa As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents DespesasAcumuladasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesEmD�bitoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents D�bitoClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents D�bitoDeClientesComJurosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FaturarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrePedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CartaDeCobran�aToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Opera��eToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaixaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents T�tuloDeClienteAVencerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents T�tuloDeClientePagoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComercialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FaturamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasDeClientesComT�tulosEmAbertoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents D�bitoClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents D�bitoDeClientesComJurosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents T�tuloDeClienteAVencerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents T�tuloDeClientePagoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesNovosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeClientesPorConsultorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TesteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GerarArquivoExporta��oToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TesteRemessaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirBoletoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecebimentoPromotoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PacoteSemCompran�aCadastradaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrativoGerencialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasDeProdutosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntregaOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Transposi��oToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OSsPendentesDeEntregaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Configura��esToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PromotoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Relat�rioDeVendasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Autoriza��oParaClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtualizaCampoDescontoTabPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutorizarVendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstornarCr�ditoDinheiroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtualizaPrecoTabelaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtualizaFaturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FamiliaLentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimeNFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaFiscalEletronicaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaFiscalEletronicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmitirNFeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Configura��oToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CidadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CFOPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Classifica��oFiscalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstoquePreferencialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrocaDeBaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrocaDeProdutoEBaseCSa�daDoEstoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelProdNotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmitirNFeNFCeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EvenyosNFCeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FabricanteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EmissaoRemessaBBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
#End Region
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Configura��esToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoquePreferencialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FamiliaLentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LentesEBlocosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromotoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Servi�osToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabelaDeLentesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Usu�riosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FabricanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerencialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbreTabelaPromocionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjusteEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaTabelaPromocionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FamiliaDeLentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanoDeContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Relat�rioDeSa�dasDeLentePorPer�odoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OssN�oConclu�dasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OSsPendentesDeEntregaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidoProdu��oToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Relat�rio360AnaMariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Relat�rioPontua��esAnaMariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TratamentoAntiRiscoNoPer�odoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TratamentoCrizalPer�odoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TratamentosOptikotEOptikotEasyClean�ticasAnaMariaPorPer�odoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalcaoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AndamentosOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvisoOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Saldos�ticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Transposi��oToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbreNotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjusteContagemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrocaDeDioptriaEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Confer�nciaEEntradaDeNFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Devolu��oParaOEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradaManualNoEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstornarCr�ditoDinheiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimeNFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarOSLabonorteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidoLabonorteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Relat�rios2�ViaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosADevolverAoFornecedorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosEstornadosParaOEstoqueToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradaNotaFiscalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RElat�riosOSsLentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OssComLifestyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Relat�rioSaldoPre�oCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabelaDeLentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaixaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoletosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmissaoRemessaBBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaixaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelamentoDeOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraDeCr�ditosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Confirma��oCr�ditoCancelamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Relat�riosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DespesasPer�odoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaturasComSaldoPorClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosN�oFaturadosPorClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumoNfePer�odoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilitariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AndamentosUtilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtiquetaAndamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtiquetaUsu�rioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerarArquivoExporta��oToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrocarSenhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinanceiroToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrativoGerencialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasDeProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Relat�rioDeVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TesteRemessaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Autoriza��oParaClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CartaDeCobran�aToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaturarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinanceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaixaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesEmD�bitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.D�bitoClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.D�bitoDeClientesComJurosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DespesasAcumuladasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaturamentoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Opera��eToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacoteSemCompran�aCadastradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecebimentoPromotoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.T�tuloDeClienteAVencerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.T�tuloDeClientePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirBoletoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorizarVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComercialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesNovosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasDeClientesComT�tulosEmAbertoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.D�bitoClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.D�bitoDeClientesComJurosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaturamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeClientesPorConsultorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.T�tuloDeClientePagoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.T�tuloDeClienteAVencerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaFiscalEletronicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Configura��oToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CidadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CFOPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Classifica��oFiscalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmitirNFeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmitirNFeNFCeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvenyosNFCeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TesteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtualizaCampoDescontoTabPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtualizaPrecoTabelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtualizaFaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotaFiscalEletronicaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelProdNotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PdfExport = New DataDynamics.ActiveReports.Export.Pdf.PdfExport()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDivisao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mmGeral = New System.Windows.Forms.ToolStrip()
        Me.btnCliente = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPedido = New System.Windows.Forms.ToolStripSplitButton()
        Me.AbrePedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirPedidoCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraDeLentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConferirPedidoCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoPedidoCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnOS = New System.Windows.Forms.ToolStripSplitButton()
        Me.AvisoSobreAOSsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvisoSobreAOS�ticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarOSsPNomeDoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntregaOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Impress�oDeOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OSPedidasPendentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OSsPendentesDataVerifica��oToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OSPendentePorFornecedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OSsPendentesPorFornLabonorteecedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OSsPendentePorForneceodr�ticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PararOSTemporariamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReativarOSParadaNoEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetornoOSFeitaForaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sa�daOSLaborat�rioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnMovimento = New System.Windows.Forms.ToolStripSplitButton()
        Me.Confer�nciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Saldo�ticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBaixaOsPedido = New System.Windows.Forms.ToolStripSplitButton()
        Me.BaixaPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaixaOSLabonorteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaixaOS�ticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnTrocaProduto = New System.Windows.Forms.ToolStripSplitButton()
        Me.TrocaProdutoOSLabonorteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrocaDeBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrocaDeProdutoEBaseCSa�daDoEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSaidaExtra = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAndamentos = New System.Windows.Forms.ToolStripSplitButton()
        Me.AndamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Andamentos�ticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCaixa = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.mmGeral.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.GerencialToolStripMenuItem, Me.BalcaoToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.CaixaToolStripMenuItem, Me.UtilitariosToolStripMenuItem, Me.TrocarSenhaToolStripMenuItem, Me.FinanceiroToolStripMenuItem1, Me.ComercialToolStripMenuItem, Me.NotaFiscalEletronicaToolStripMenuItem, Me.TesteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.Configura��esToolStripMenuItem, Me.EstoquePreferencialToolStripMenuItem, Me.FamiliaLentesToolStripMenuItem, Me.FornecedorToolStripMenuItem, Me.PerfilToolStripMenuItem, Me.LentesEBlocosToolStripMenuItem, Me.PromotoraToolStripMenuItem, Me.Servi�osToolStripMenuItem, Me.TabelaDeLentesToolStripMenuItem2, Me.Usu�riosToolStripMenuItem, Me.EmpresaToolStripMenuItem, Me.FabricanteToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        Me.CadastroToolStripMenuItem.Visible = False
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Image = CType(resources.GetObject("ClientesToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(208, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'Configura��esToolStripMenuItem
        '
        Me.Configura��esToolStripMenuItem.Image = CType(resources.GetObject("Configura��esToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Configura��esToolStripMenuItem.Name = "Configura��esToolStripMenuItem"
        Me.Configura��esToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.Configura��esToolStripMenuItem.Text = "Configura��es"
        '
        'EstoquePreferencialToolStripMenuItem
        '
        Me.EstoquePreferencialToolStripMenuItem.Image = CType(resources.GetObject("EstoquePreferencialToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EstoquePreferencialToolStripMenuItem.Name = "EstoquePreferencialToolStripMenuItem"
        Me.EstoquePreferencialToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.EstoquePreferencialToolStripMenuItem.Text = "Estoque Preferencial"
        Me.EstoquePreferencialToolStripMenuItem.Visible = False
        '
        'FamiliaLentesToolStripMenuItem
        '
        Me.FamiliaLentesToolStripMenuItem.Image = CType(resources.GetObject("FamiliaLentesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FamiliaLentesToolStripMenuItem.Name = "FamiliaLentesToolStripMenuItem"
        Me.FamiliaLentesToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.FamiliaLentesToolStripMenuItem.Text = "Familia Lentes"
        '
        'FornecedorToolStripMenuItem
        '
        Me.FornecedorToolStripMenuItem.Image = CType(resources.GetObject("FornecedorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FornecedorToolStripMenuItem.Name = "FornecedorToolStripMenuItem"
        Me.FornecedorToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.FornecedorToolStripMenuItem.Text = "Fornecedor"
        '
        'PerfilToolStripMenuItem
        '
        Me.PerfilToolStripMenuItem.Image = CType(resources.GetObject("PerfilToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        Me.PerfilToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.PerfilToolStripMenuItem.Text = "Grupo de Usu�rios"
        '
        'LentesEBlocosToolStripMenuItem
        '
        Me.LentesEBlocosToolStripMenuItem.Image = CType(resources.GetObject("LentesEBlocosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LentesEBlocosToolStripMenuItem.Name = "LentesEBlocosToolStripMenuItem"
        Me.LentesEBlocosToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.LentesEBlocosToolStripMenuItem.Text = "Produtos/Lentes e Blocos"
        '
        'PromotoraToolStripMenuItem
        '
        Me.PromotoraToolStripMenuItem.Image = CType(resources.GetObject("PromotoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PromotoraToolStripMenuItem.Name = "PromotoraToolStripMenuItem"
        Me.PromotoraToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.PromotoraToolStripMenuItem.Text = "Promotor(a) de Venda"
        '
        'Servi�osToolStripMenuItem
        '
        Me.Servi�osToolStripMenuItem.Image = CType(resources.GetObject("Servi�osToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Servi�osToolStripMenuItem.Name = "Servi�osToolStripMenuItem"
        Me.Servi�osToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.Servi�osToolStripMenuItem.Text = "Servi�os"
        '
        'TabelaDeLentesToolStripMenuItem2
        '
        Me.TabelaDeLentesToolStripMenuItem2.Image = CType(resources.GetObject("TabelaDeLentesToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.TabelaDeLentesToolStripMenuItem2.Name = "TabelaDeLentesToolStripMenuItem2"
        Me.TabelaDeLentesToolStripMenuItem2.Size = New System.Drawing.Size(208, 22)
        Me.TabelaDeLentesToolStripMenuItem2.Text = "Tabela de Lentes"
        Me.TabelaDeLentesToolStripMenuItem2.Visible = False
        '
        'Usu�riosToolStripMenuItem
        '
        Me.Usu�riosToolStripMenuItem.Image = CType(resources.GetObject("Usu�riosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Usu�riosToolStripMenuItem.Name = "Usu�riosToolStripMenuItem"
        Me.Usu�riosToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.Usu�riosToolStripMenuItem.Text = "Usu�rios"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Image = CType(resources.GetObject("EmpresaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'FabricanteToolStripMenuItem
        '
        Me.FabricanteToolStripMenuItem.Name = "FabricanteToolStripMenuItem"
        Me.FabricanteToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.FabricanteToolStripMenuItem.Text = "Fabricante"
        Me.FabricanteToolStripMenuItem.Visible = False
        '
        'GerencialToolStripMenuItem
        '
        Me.GerencialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbreTabelaPromocionalToolStripMenuItem, Me.AjusteEstoqueToolStripMenuItem, Me.NovaTabelaPromocionalToolStripMenuItem, Me.FamiliaDeLentesToolStripMenuItem, Me.PlanoDeContasToolStripMenuItem, Me.Relat�rioDeSa�dasDeLentePorPer�odoToolStripMenuItem, Me.OssN�oConclu�dasToolStripMenuItem, Me.OSsPendentesDeEntregaToolStripMenuItem, Me.PedidoProdu��oToolStripMenuItem, Me.Relat�rio360AnaMariaToolStripMenuItem, Me.Relat�rioPontua��esAnaMariaToolStripMenuItem, Me.TratamentoAntiRiscoNoPer�odoToolStripMenuItem, Me.TratamentoCrizalPer�odoToolStripMenuItem, Me.TratamentosOptikotEOptikotEasyClean�ticasAnaMariaPorPer�odoToolStripMenuItem})
        Me.GerencialToolStripMenuItem.Name = "GerencialToolStripMenuItem"
        Me.GerencialToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.GerencialToolStripMenuItem.Text = "Gerencial"
        Me.GerencialToolStripMenuItem.Visible = False
        '
        'AbreTabelaPromocionalToolStripMenuItem
        '
        Me.AbreTabelaPromocionalToolStripMenuItem.Image = CType(resources.GetObject("AbreTabelaPromocionalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbreTabelaPromocionalToolStripMenuItem.Name = "AbreTabelaPromocionalToolStripMenuItem"
        Me.AbreTabelaPromocionalToolStripMenuItem.Size = New System.Drawing.Size(451, 22)
        Me.AbreTabelaPromocionalToolStripMenuItem.Text = "Abre Tabela Promocional"
        '
        'AjusteEstoqueToolStripMenuItem
        '
        Me.AjusteEstoqueToolStripMenuItem.Image = CType(resources.GetObject("AjusteEstoqueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AjusteEstoqueToolStripMenuItem.Name = "AjusteEstoqueToolStripMenuItem"
        Me.AjusteEstoqueToolStripMenuItem.Size = New System.Drawing.Size(451, 22)
        Me.AjusteEstoqueToolStripMenuItem.Text = "Ajuste Estoque"
        '
        'NovaTabelaPromocionalToolStripMenuItem
        '
        Me.NovaTabelaPromocionalToolStripMenuItem.Image = CType(resources.GetObject("NovaTabelaPromocionalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NovaTabelaPromocionalToolStripMenuItem.Name = "NovaTabelaPromocionalToolStripMenuItem"
        Me.NovaTabelaPromocionalToolStripMenuItem.Size = New System.Drawing.Size(451, 22)
        Me.NovaTabelaPromocionalToolStripMenuItem.Text = "Nova Tabela Promocional"
        '
        'FamiliaDeLentesToolStripMenuItem
        '
        Me.FamiliaDeLentesToolStripMenuItem.Image = CType(resources.GetObject("FamiliaDeLentesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FamiliaDeLentesToolStripMenuItem.Name = "FamiliaDeLentesToolStripMenuItem"
        Me.FamiliaDeLentesToolStripMenuItem.Size = New System.Drawing.Size(451, 22)
        Me.FamiliaDeLentesToolStripMenuItem.Text = "Familia de Lentes"
        '
        'PlanoDeContasToolStripMenuItem
        '
        Me.PlanoDeContasToolStripMenuItem.Image = CType(resources.GetObject("PlanoDeContasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PlanoDeContasToolStripMenuItem.Name = "PlanoDeContasToolStripMenuItem"
        Me.PlanoDeContasToolStripMenuItem.Size = New System.Drawing.Size(451, 22)
        Me.PlanoDeContasToolStripMenuItem.Text = "Plano de Contas"
        '
        'Relat�rioDeSa�dasDeLentePorPer�odoToolStripMenuItem
        '
        Me.Relat�rioDeSa�dasDeLentePorPer�odoToolStripMenuItem.Image = CType(resources.GetObject("Relat�rioDeSa�dasDeLentePorPer�odoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Relat�rioDeSa�dasDeLentePorPer�odoToolStripMenuItem.Name = "Relat�rioDeSa�dasDeLentePorPer�odoToolStripMenuItem"
        Me.Relat�rioDeSa�dasDeLentePorPer�odoToolStripMenuItem.Size = New System.Drawing.Size(451, 22)
        Me.Relat�rioDeSa�dasDeLentePorPer�odoToolStripMenuItem.Text = "Relat�rio de Sa�das de Lente por Per�odo"
        '
        'OssN�oConclu�dasToolStripMenuItem
        '
        Me.OssN�oConclu�dasToolStripMenuItem.Image = CType(resources.GetObject("OssN�oConclu�dasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OssN�oConclu�dasToolStripMenuItem.Name = "OssN�oConclu�dasToolStripMenuItem"
        Me.OssN�oConclu�dasToolStripMenuItem.Size = New System.Drawing.Size(451, 22)
        Me.OssN�oConclu�dasToolStripMenuItem.Text = "Os's n�o conclu�das"
        '
        'OSsPendentesDeEntregaToolStripMenuItem
        '
        Me.OSsPendentesDeEntregaToolStripMenuItem.Image = CType(resources.GetObject("OSsPendentesDeEntregaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OSsPendentesDeEntregaToolStripMenuItem.Name = "OSsPendentesDeEntregaToolStripMenuItem"
        Me.OSsPendentesDeEntregaToolStripMenuItem.Size = New System.Drawing.Size(451, 22)
        Me.OSsPendentesDeEntregaToolStripMenuItem.Text = "OS's Pendentes de Entrega"
        '
        'PedidoProdu��oToolStripMenuItem
        '
        Me.PedidoProdu��oToolStripMenuItem.Name = "PedidoProdu��oToolStripMenuItem"
        Me.PedidoProdu��oToolStripMenuItem.Size = New System.Drawing.Size(451, 22)
        Me.PedidoProdu��oToolStripMenuItem.Text = "Pedido Produ��o"
        Me.PedidoProdu��oToolStripMenuItem.Visible = False
        '
        'Relat�rio360AnaMariaToolStripMenuItem
        '
        Me.Relat�rio360AnaMariaToolStripMenuItem.Name = "Relat�rio360AnaMariaToolStripMenuItem"
        Me.Relat�rio360AnaMariaToolStripMenuItem.Size = New System.Drawing.Size(451, 22)
        Me.Relat�rio360AnaMariaToolStripMenuItem.Text = "Relat�rio 360 Ana Maria"
        Me.Relat�rio360AnaMariaToolStripMenuItem.Visible = False
        '
        'Relat�rioPontua��esAnaMariaToolStripMenuItem
        '
        Me.Relat�rioPontua��esAnaMariaToolStripMenuItem.Name = "Relat�rioPontua��esAnaMariaToolStripMenuItem"
        Me.Relat�rioPontua��esAnaMariaToolStripMenuItem.Size = New System.Drawing.Size(451, 22)
        Me.Relat�rioPontua��esAnaMariaToolStripMenuItem.Text = "Relat�rio Pontua��es Ana Maria"
        Me.Relat�rioPontua��esAnaMariaToolStripMenuItem.Visible = False
        '
        'TratamentoAntiRiscoNoPer�odoToolStripMenuItem
        '
        Me.TratamentoAntiRiscoNoPer�odoToolStripMenuItem.Name = "TratamentoAntiRiscoNoPer�odoToolStripMenuItem"
        Me.TratamentoAntiRiscoNoPer�odoToolStripMenuItem.Size = New System.Drawing.Size(451, 22)
        Me.TratamentoAntiRiscoNoPer�odoToolStripMenuItem.Text = "Tratamento Anti-Risco no Per�odo"
        Me.TratamentoAntiRiscoNoPer�odoToolStripMenuItem.Visible = False
        '
        'TratamentoCrizalPer�odoToolStripMenuItem
        '
        Me.TratamentoCrizalPer�odoToolStripMenuItem.Name = "TratamentoCrizalPer�odoToolStripMenuItem"
        Me.TratamentoCrizalPer�odoToolStripMenuItem.Size = New System.Drawing.Size(451, 22)
        Me.TratamentoCrizalPer�odoToolStripMenuItem.Text = "Tratamentos Crizal Aliz� e Crizal A2 no per�odo"
        Me.TratamentoCrizalPer�odoToolStripMenuItem.Visible = False
        '
        'TratamentosOptikotEOptikotEasyClean�ticasAnaMariaPorPer�odoToolStripMenuItem
        '
        Me.TratamentosOptikotEOptikotEasyClean�ticasAnaMariaPorPer�odoToolStripMenuItem.Name = "TratamentosOptikotEOptikotEasyClean�ticasAnaMariaPorPer�odoToolStripMenuItem"
        Me.TratamentosOptikotEOptikotEasyClean�ticasAnaMariaPorPer�odoToolStripMenuItem.Size = New System.Drawing.Size(451, 22)
        Me.TratamentosOptikotEOptikotEasyClean�ticasAnaMariaPorPer�odoToolStripMenuItem.Text = "Tratamentos Optikot e Optikot Easy Clean �ticas Ana Maria por Per�odo"
        Me.TratamentosOptikotEOptikotEasyClean�ticasAnaMariaPorPer�odoToolStripMenuItem.Visible = False
        '
        'BalcaoToolStripMenuItem
        '
        Me.BalcaoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AndamentosOSToolStripMenuItem, Me.AvisoOSToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.SaldosToolStripMenuItem, Me.Saldos�ticaToolStripMenuItem, Me.Transposi��oToolStripMenuItem})
        Me.BalcaoToolStripMenuItem.Name = "BalcaoToolStripMenuItem"
        Me.BalcaoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.BalcaoToolStripMenuItem.Text = "Balc�o"
        Me.BalcaoToolStripMenuItem.Visible = False
        '
        'AndamentosOSToolStripMenuItem
        '
        Me.AndamentosOSToolStripMenuItem.Image = CType(resources.GetObject("AndamentosOSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AndamentosOSToolStripMenuItem.Name = "AndamentosOSToolStripMenuItem"
        Me.AndamentosOSToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AndamentosOSToolStripMenuItem.Text = "Andamentos OS"
        '
        'AvisoOSToolStripMenuItem
        '
        Me.AvisoOSToolStripMenuItem.Image = CType(resources.GetObject("AvisoOSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AvisoOSToolStripMenuItem.Name = "AvisoOSToolStripMenuItem"
        Me.AvisoOSToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AvisoOSToolStripMenuItem.Text = "Aviso OS"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'SaldosToolStripMenuItem
        '
        Me.SaldosToolStripMenuItem.Image = CType(resources.GetObject("SaldosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaldosToolStripMenuItem.Name = "SaldosToolStripMenuItem"
        Me.SaldosToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SaldosToolStripMenuItem.Text = "Saldos"
        '
        'Saldos�ticaToolStripMenuItem
        '
        Me.Saldos�ticaToolStripMenuItem.Image = CType(resources.GetObject("Saldos�ticaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Saldos�ticaToolStripMenuItem.Name = "Saldos�ticaToolStripMenuItem"
        Me.Saldos�ticaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.Saldos�ticaToolStripMenuItem.Text = "Saldos �tica"
        Me.Saldos�ticaToolStripMenuItem.Visible = False
        '
        'Transposi��oToolStripMenuItem
        '
        Me.Transposi��oToolStripMenuItem.Image = CType(resources.GetObject("Transposi��oToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Transposi��oToolStripMenuItem.Name = "Transposi��oToolStripMenuItem"
        Me.Transposi��oToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.Transposi��oToolStripMenuItem.Text = "Transposi��o"
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbreNotaToolStripMenuItem, Me.AjusteContagemToolStripMenuItem, Me.TrocaDeDioptriaEstoqueToolStripMenuItem, Me.CancelaToolStripMenuItem, Me.Confer�nciaEEntradaDeNFToolStripMenuItem, Me.Devolu��oParaOEstoqueToolStripMenuItem, Me.EntradaManualNoEstoqueToolStripMenuItem, Me.EstornarCr�ditoDinheiroToolStripMenuItem, Me.ImprimeNFToolStripMenuItem, Me.ImportarOSLabonorteToolStripMenuItem, Me.PedidoLabonorteToolStripMenuItem, Me.Relat�rios2�ViaToolStripMenuItem, Me.RElat�riosOSsLentesToolStripMenuItem, Me.Relat�rioSaldoPre�oCompraToolStripMenuItem, Me.TabelaDeLentesToolStripMenuItem})
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.EstoqueToolStripMenuItem.Text = "Estoque"
        Me.EstoqueToolStripMenuItem.Visible = False
        '
        'AbreNotaToolStripMenuItem
        '
        Me.AbreNotaToolStripMenuItem.Image = CType(resources.GetObject("AbreNotaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbreNotaToolStripMenuItem.Name = "AbreNotaToolStripMenuItem"
        Me.AbreNotaToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.AbreNotaToolStripMenuItem.Text = "Abre Nota"
        '
        'AjusteContagemToolStripMenuItem
        '
        Me.AjusteContagemToolStripMenuItem.Image = CType(resources.GetObject("AjusteContagemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AjusteContagemToolStripMenuItem.Name = "AjusteContagemToolStripMenuItem"
        Me.AjusteContagemToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.AjusteContagemToolStripMenuItem.Text = "Ajuste Contagem"
        '
        'TrocaDeDioptriaEstoqueToolStripMenuItem
        '
        Me.TrocaDeDioptriaEstoqueToolStripMenuItem.Image = CType(resources.GetObject("TrocaDeDioptriaEstoqueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TrocaDeDioptriaEstoqueToolStripMenuItem.Name = "TrocaDeDioptriaEstoqueToolStripMenuItem"
        Me.TrocaDeDioptriaEstoqueToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.TrocaDeDioptriaEstoqueToolStripMenuItem.Text = "Ajuste de Produto no Estoque"
        '
        'CancelaToolStripMenuItem
        '
        Me.CancelaToolStripMenuItem.Image = CType(resources.GetObject("CancelaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CancelaToolStripMenuItem.Name = "CancelaToolStripMenuItem"
        Me.CancelaToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.CancelaToolStripMenuItem.Text = "Cancelamento de OS"
        '
        'Confer�nciaEEntradaDeNFToolStripMenuItem
        '
        Me.Confer�nciaEEntradaDeNFToolStripMenuItem.Image = CType(resources.GetObject("Confer�nciaEEntradaDeNFToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Confer�nciaEEntradaDeNFToolStripMenuItem.Name = "Confer�nciaEEntradaDeNFToolStripMenuItem"
        Me.Confer�nciaEEntradaDeNFToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.Confer�nciaEEntradaDeNFToolStripMenuItem.Text = "Confer�ncia e Entrada de NF"
        '
        'Devolu��oParaOEstoqueToolStripMenuItem
        '
        Me.Devolu��oParaOEstoqueToolStripMenuItem.Image = CType(resources.GetObject("Devolu��oParaOEstoqueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Devolu��oParaOEstoqueToolStripMenuItem.Name = "Devolu��oParaOEstoqueToolStripMenuItem"
        Me.Devolu��oParaOEstoqueToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.Devolu��oParaOEstoqueToolStripMenuItem.Text = "Devolu��o para o Estoque"
        '
        'EntradaManualNoEstoqueToolStripMenuItem
        '
        Me.EntradaManualNoEstoqueToolStripMenuItem.Image = CType(resources.GetObject("EntradaManualNoEstoqueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EntradaManualNoEstoqueToolStripMenuItem.Name = "EntradaManualNoEstoqueToolStripMenuItem"
        Me.EntradaManualNoEstoqueToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.EntradaManualNoEstoqueToolStripMenuItem.Text = "Entrada Manual no Estoque"
        '
        'EstornarCr�ditoDinheiroToolStripMenuItem
        '
        Me.EstornarCr�ditoDinheiroToolStripMenuItem.Image = CType(resources.GetObject("EstornarCr�ditoDinheiroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EstornarCr�ditoDinheiroToolStripMenuItem.Name = "EstornarCr�ditoDinheiroToolStripMenuItem"
        Me.EstornarCr�ditoDinheiroToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.EstornarCr�ditoDinheiroToolStripMenuItem.Text = "Estornar Cr�dito/Dinheiro"
        '
        'ImprimeNFToolStripMenuItem
        '
        Me.ImprimeNFToolStripMenuItem.Name = "ImprimeNFToolStripMenuItem"
        Me.ImprimeNFToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.ImprimeNFToolStripMenuItem.Text = "Imprimir Nota Fiscal"
        Me.ImprimeNFToolStripMenuItem.Visible = False
        '
        'ImportarOSLabonorteToolStripMenuItem
        '
        Me.ImportarOSLabonorteToolStripMenuItem.Name = "ImportarOSLabonorteToolStripMenuItem"
        Me.ImportarOSLabonorteToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.ImportarOSLabonorteToolStripMenuItem.Text = "Importar OS das �ticas Ana Maria"
        Me.ImportarOSLabonorteToolStripMenuItem.Visible = False
        '
        'PedidoLabonorteToolStripMenuItem
        '
        Me.PedidoLabonorteToolStripMenuItem.Name = "PedidoLabonorteToolStripMenuItem"
        Me.PedidoLabonorteToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.PedidoLabonorteToolStripMenuItem.Text = "Pedido Labonorte"
        Me.PedidoLabonorteToolStripMenuItem.Visible = False
        '
        'Relat�rios2�ViaToolStripMenuItem
        '
        Me.Relat�rios2�ViaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosADevolverAoFornecedorToolStripMenuItem1, Me.ProdutosEstornadosParaOEstoqueToolStripMenuItem1, Me.EntradaNotaFiscalToolStripMenuItem})
        Me.Relat�rios2�ViaToolStripMenuItem.Image = CType(resources.GetObject("Relat�rios2�ViaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Relat�rios2�ViaToolStripMenuItem.Name = "Relat�rios2�ViaToolStripMenuItem"
        Me.Relat�rios2�ViaToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.Relat�rios2�ViaToolStripMenuItem.Text = "Relat�rios 2� Via"
        Me.Relat�rios2�ViaToolStripMenuItem.Visible = False
        '
        'ProdutosADevolverAoFornecedorToolStripMenuItem1
        '
        Me.ProdutosADevolverAoFornecedorToolStripMenuItem1.Name = "ProdutosADevolverAoFornecedorToolStripMenuItem1"
        Me.ProdutosADevolverAoFornecedorToolStripMenuItem1.Size = New System.Drawing.Size(264, 22)
        Me.ProdutosADevolverAoFornecedorToolStripMenuItem1.Text = "Produtos a devolver ao fornecedor"
        '
        'ProdutosEstornadosParaOEstoqueToolStripMenuItem1
        '
        Me.ProdutosEstornadosParaOEstoqueToolStripMenuItem1.Name = "ProdutosEstornadosParaOEstoqueToolStripMenuItem1"
        Me.ProdutosEstornadosParaOEstoqueToolStripMenuItem1.Size = New System.Drawing.Size(264, 22)
        Me.ProdutosEstornadosParaOEstoqueToolStripMenuItem1.Text = "Produtos estornados para o estoque"
        '
        'EntradaNotaFiscalToolStripMenuItem
        '
        Me.EntradaNotaFiscalToolStripMenuItem.Name = "EntradaNotaFiscalToolStripMenuItem"
        Me.EntradaNotaFiscalToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.EntradaNotaFiscalToolStripMenuItem.Text = "Entrada Nota fiscal"
        '
        'RElat�riosOSsLentesToolStripMenuItem
        '
        Me.RElat�riosOSsLentesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OssComLifestyleToolStripMenuItem})
        Me.RElat�riosOSsLentesToolStripMenuItem.Image = CType(resources.GetObject("RElat�riosOSsLentesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RElat�riosOSsLentesToolStripMenuItem.Name = "RElat�riosOSsLentesToolStripMenuItem"
        Me.RElat�riosOSsLentesToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.RElat�riosOSsLentesToolStripMenuItem.Text = "Relat�rios OS's Lentes"
        Me.RElat�riosOSsLentesToolStripMenuItem.Visible = False
        '
        'OssComLifestyleToolStripMenuItem
        '
        Me.OssComLifestyleToolStripMenuItem.Name = "OssComLifestyleToolStripMenuItem"
        Me.OssComLifestyleToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.OssComLifestyleToolStripMenuItem.Text = "Os's com TrueForm �tica"
        '
        'Relat�rioSaldoPre�oCompraToolStripMenuItem
        '
        Me.Relat�rioSaldoPre�oCompraToolStripMenuItem.Name = "Relat�rioSaldoPre�oCompraToolStripMenuItem"
        Me.Relat�rioSaldoPre�oCompraToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.Relat�rioSaldoPre�oCompraToolStripMenuItem.Text = "Relat�rio de Saldo Por Pre�o Compra"
        Me.Relat�rioSaldoPre�oCompraToolStripMenuItem.Visible = False
        '
        'TabelaDeLentesToolStripMenuItem
        '
        Me.TabelaDeLentesToolStripMenuItem.Image = CType(resources.GetObject("TabelaDeLentesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TabelaDeLentesToolStripMenuItem.Name = "TabelaDeLentesToolStripMenuItem"
        Me.TabelaDeLentesToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.TabelaDeLentesToolStripMenuItem.Text = "Tabela de Lentes"
        '
        'CaixaToolStripMenuItem
        '
        Me.CaixaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoletosToolStripMenuItem, Me.CaixaToolStripMenuItem1, Me.CancelamentoDeOSToolStripMenuItem, Me.CompraDeCr�ditosToolStripMenuItem, Me.Confirma��oCr�ditoCancelamentoToolStripMenuItem, Me.Relat�riosToolStripMenuItem})
        Me.CaixaToolStripMenuItem.Name = "CaixaToolStripMenuItem"
        Me.CaixaToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CaixaToolStripMenuItem.Text = "Caixa"
        Me.CaixaToolStripMenuItem.Visible = False
        '
        'BoletosToolStripMenuItem
        '
        Me.BoletosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmissaoRemessaBBToolStripMenuItem})
        Me.BoletosToolStripMenuItem.Image = CType(resources.GetObject("BoletosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BoletosToolStripMenuItem.Name = "BoletosToolStripMenuItem"
        Me.BoletosToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.BoletosToolStripMenuItem.Text = "Boletos"
        '
        'EmissaoRemessaBBToolStripMenuItem
        '
        Me.EmissaoRemessaBBToolStripMenuItem.Name = "EmissaoRemessaBBToolStripMenuItem"
        Me.EmissaoRemessaBBToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.EmissaoRemessaBBToolStripMenuItem.Text = "Emissao Remessa BB"
        '
        'CaixaToolStripMenuItem1
        '
        Me.CaixaToolStripMenuItem1.Image = CType(resources.GetObject("CaixaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.CaixaToolStripMenuItem1.Name = "CaixaToolStripMenuItem1"
        Me.CaixaToolStripMenuItem1.Size = New System.Drawing.Size(265, 22)
        Me.CaixaToolStripMenuItem1.Text = "Caixa"
        '
        'CancelamentoDeOSToolStripMenuItem
        '
        Me.CancelamentoDeOSToolStripMenuItem.Image = CType(resources.GetObject("CancelamentoDeOSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CancelamentoDeOSToolStripMenuItem.Name = "CancelamentoDeOSToolStripMenuItem"
        Me.CancelamentoDeOSToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.CancelamentoDeOSToolStripMenuItem.Text = "Cancelamento de OS"
        '
        'CompraDeCr�ditosToolStripMenuItem
        '
        Me.CompraDeCr�ditosToolStripMenuItem.Name = "CompraDeCr�ditosToolStripMenuItem"
        Me.CompraDeCr�ditosToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.CompraDeCr�ditosToolStripMenuItem.Text = "Compra de Cr�ditos"
        Me.CompraDeCr�ditosToolStripMenuItem.Visible = False
        '
        'Confirma��oCr�ditoCancelamentoToolStripMenuItem
        '
        Me.Confirma��oCr�ditoCancelamentoToolStripMenuItem.Name = "Confirma��oCr�ditoCancelamentoToolStripMenuItem"
        Me.Confirma��oCr�ditoCancelamentoToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.Confirma��oCr�ditoCancelamentoToolStripMenuItem.Text = "Confirma��o Cr�dito Cancelamento"
        Me.Confirma��oCr�ditoCancelamentoToolStripMenuItem.Visible = False
        '
        'Relat�riosToolStripMenuItem
        '
        Me.Relat�riosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DespesasPer�odoToolStripMenuItem, Me.FaturasComSaldoPorClientesToolStripMenuItem, Me.PedidosN�oFaturadosPorClientesToolStripMenuItem, Me.ResumoNfePer�odoToolStripMenuItem})
        Me.Relat�riosToolStripMenuItem.Image = CType(resources.GetObject("Relat�riosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Relat�riosToolStripMenuItem.Name = "Relat�riosToolStripMenuItem"
        Me.Relat�riosToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.Relat�riosToolStripMenuItem.Text = "Relat�rios"
        '
        'DespesasPer�odoToolStripMenuItem
        '
        Me.DespesasPer�odoToolStripMenuItem.Image = CType(resources.GetObject("DespesasPer�odoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DespesasPer�odoToolStripMenuItem.Name = "DespesasPer�odoToolStripMenuItem"
        Me.DespesasPer�odoToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.DespesasPer�odoToolStripMenuItem.Text = "Despesas Per�odo"
        '
        'FaturasComSaldoPorClientesToolStripMenuItem
        '
        Me.FaturasComSaldoPorClientesToolStripMenuItem.Image = CType(resources.GetObject("FaturasComSaldoPorClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FaturasComSaldoPorClientesToolStripMenuItem.Name = "FaturasComSaldoPorClientesToolStripMenuItem"
        Me.FaturasComSaldoPorClientesToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.FaturasComSaldoPorClientesToolStripMenuItem.Text = "Faturas com saldo Por Clientes"
        '
        'PedidosN�oFaturadosPorClientesToolStripMenuItem
        '
        Me.PedidosN�oFaturadosPorClientesToolStripMenuItem.Image = CType(resources.GetObject("PedidosN�oFaturadosPorClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PedidosN�oFaturadosPorClientesToolStripMenuItem.Name = "PedidosN�oFaturadosPorClientesToolStripMenuItem"
        Me.PedidosN�oFaturadosPorClientesToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.PedidosN�oFaturadosPorClientesToolStripMenuItem.Text = "Pedidos n�o Faturados por Clientes"
        '
        'ResumoNfePer�odoToolStripMenuItem
        '
        Me.ResumoNfePer�odoToolStripMenuItem.Image = CType(resources.GetObject("ResumoNfePer�odoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResumoNfePer�odoToolStripMenuItem.Name = "ResumoNfePer�odoToolStripMenuItem"
        Me.ResumoNfePer�odoToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.ResumoNfePer�odoToolStripMenuItem.Text = "Resumo Nfe Per�odo"
        '
        'UtilitariosToolStripMenuItem
        '
        Me.UtilitariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AndamentosUtilToolStripMenuItem, Me.EtiquetaAndamentosToolStripMenuItem, Me.EtiquetaUsu�rioToolStripMenuItem, Me.GerarArquivoExporta��oToolStripMenuItem})
        Me.UtilitariosToolStripMenuItem.Name = "UtilitariosToolStripMenuItem"
        Me.UtilitariosToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.UtilitariosToolStripMenuItem.Text = "Utilit�rios"
        Me.UtilitariosToolStripMenuItem.Visible = False
        '
        'AndamentosUtilToolStripMenuItem
        '
        Me.AndamentosUtilToolStripMenuItem.Name = "AndamentosUtilToolStripMenuItem"
        Me.AndamentosUtilToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AndamentosUtilToolStripMenuItem.Text = "Andamentos Util"
        '
        'EtiquetaAndamentosToolStripMenuItem
        '
        Me.EtiquetaAndamentosToolStripMenuItem.Image = CType(resources.GetObject("EtiquetaAndamentosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EtiquetaAndamentosToolStripMenuItem.Name = "EtiquetaAndamentosToolStripMenuItem"
        Me.EtiquetaAndamentosToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.EtiquetaAndamentosToolStripMenuItem.Text = "Etiqueta Andamentos"
        '
        'EtiquetaUsu�rioToolStripMenuItem
        '
        Me.EtiquetaUsu�rioToolStripMenuItem.Image = CType(resources.GetObject("EtiquetaUsu�rioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EtiquetaUsu�rioToolStripMenuItem.Name = "EtiquetaUsu�rioToolStripMenuItem"
        Me.EtiquetaUsu�rioToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.EtiquetaUsu�rioToolStripMenuItem.Text = "Etiqueta Usu�rio"
        '
        'GerarArquivoExporta��oToolStripMenuItem
        '
        Me.GerarArquivoExporta��oToolStripMenuItem.Name = "GerarArquivoExporta��oToolStripMenuItem"
        Me.GerarArquivoExporta��oToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.GerarArquivoExporta��oToolStripMenuItem.Text = "Gerar Arquivo Exporta��o"
        '
        'TrocarSenhaToolStripMenuItem
        '
        Me.TrocarSenhaToolStripMenuItem.Name = "TrocarSenhaToolStripMenuItem"
        Me.TrocarSenhaToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.TrocarSenhaToolStripMenuItem.Text = "Trocar Senha"
        Me.TrocarSenhaToolStripMenuItem.Visible = False
        '
        'FinanceiroToolStripMenuItem1
        '
        Me.FinanceiroToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrativoGerencialToolStripMenuItem, Me.TesteRemessaToolStripMenuItem, Me.Autoriza��oParaClientesToolStripMenuItem, Me.CartaDeCobran�aToolStripMenuItem, Me.FaturarToolStripMenuItem, Me.FinanceiroToolStripMenuItem, Me.ImprimirBoletoToolStripMenuItem, Me.ListaDeClientesToolStripMenuItem, Me.AutorizarVendaToolStripMenuItem})
        Me.FinanceiroToolStripMenuItem1.Name = "FinanceiroToolStripMenuItem1"
        Me.FinanceiroToolStripMenuItem1.Size = New System.Drawing.Size(74, 20)
        Me.FinanceiroToolStripMenuItem1.Text = "Financeiro"
        Me.FinanceiroToolStripMenuItem1.Visible = False
        '
        'AdministrativoGerencialToolStripMenuItem
        '
        Me.AdministrativoGerencialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasDeProdutosToolStripMenuItem, Me.Relat�rioDeVendasToolStripMenuItem})
        Me.AdministrativoGerencialToolStripMenuItem.Image = CType(resources.GetObject("AdministrativoGerencialToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdministrativoGerencialToolStripMenuItem.Name = "AdministrativoGerencialToolStripMenuItem"
        Me.AdministrativoGerencialToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.AdministrativoGerencialToolStripMenuItem.Text = "Administrativo/Gerencial"
        '
        'ComprasDeProdutosToolStripMenuItem
        '
        Me.ComprasDeProdutosToolStripMenuItem.Image = CType(resources.GetObject("ComprasDeProdutosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ComprasDeProdutosToolStripMenuItem.Name = "ComprasDeProdutosToolStripMenuItem"
        Me.ComprasDeProdutosToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ComprasDeProdutosToolStripMenuItem.Text = "Compras de Produtos"
        '
        'Relat�rioDeVendasToolStripMenuItem
        '
        Me.Relat�rioDeVendasToolStripMenuItem.Image = CType(resources.GetObject("Relat�rioDeVendasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Relat�rioDeVendasToolStripMenuItem.Name = "Relat�rioDeVendasToolStripMenuItem"
        Me.Relat�rioDeVendasToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.Relat�rioDeVendasToolStripMenuItem.Text = "Relat�rio de Vendas / Comiss�o"
        '
        'TesteRemessaToolStripMenuItem
        '
        Me.TesteRemessaToolStripMenuItem.Image = CType(resources.GetObject("TesteRemessaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TesteRemessaToolStripMenuItem.Name = "TesteRemessaToolStripMenuItem"
        Me.TesteRemessaToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.TesteRemessaToolStripMenuItem.Text = "Arquivo Remessa/Retorno"
        '
        'Autoriza��oParaClientesToolStripMenuItem
        '
        Me.Autoriza��oParaClientesToolStripMenuItem.Name = "Autoriza��oParaClientesToolStripMenuItem"
        Me.Autoriza��oParaClientesToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.Autoriza��oParaClientesToolStripMenuItem.Text = "Autorizar Compra de Clientes"
        '
        'CartaDeCobran�aToolStripMenuItem
        '
        Me.CartaDeCobran�aToolStripMenuItem.Image = CType(resources.GetObject("CartaDeCobran�aToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CartaDeCobran�aToolStripMenuItem.Name = "CartaDeCobran�aToolStripMenuItem"
        Me.CartaDeCobran�aToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.CartaDeCobran�aToolStripMenuItem.Text = "Carta de Cobran�a"
        '
        'FaturarToolStripMenuItem
        '
        Me.FaturarToolStripMenuItem.Image = CType(resources.GetObject("FaturarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FaturarToolStripMenuItem.Name = "FaturarToolStripMenuItem"
        Me.FaturarToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.FaturarToolStripMenuItem.Text = "Faturar"
        '
        'FinanceiroToolStripMenuItem
        '
        Me.FinanceiroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaixaToolStripMenuItem2, Me.ClientesEmD�bitoToolStripMenuItem, Me.D�bitoClientesToolStripMenuItem, Me.D�bitoDeClientesComJurosToolStripMenuItem, Me.DespesasAcumuladasToolStripMenuItem, Me.FaturamentoToolStripMenuItem1, Me.Opera��eToolStripMenuItem, Me.PacoteSemCompran�aCadastradaToolStripMenuItem, Me.ToolStripMenuItem1, Me.RecebimentoPromotoraToolStripMenuItem, Me.T�tuloDeClienteAVencerToolStripMenuItem, Me.T�tuloDeClientePagoToolStripMenuItem})
        Me.FinanceiroToolStripMenuItem.Image = CType(resources.GetObject("FinanceiroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FinanceiroToolStripMenuItem.Name = "FinanceiroToolStripMenuItem"
        Me.FinanceiroToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.FinanceiroToolStripMenuItem.Text = "Financeiro"
        '
        'CaixaToolStripMenuItem2
        '
        Me.CaixaToolStripMenuItem2.Image = CType(resources.GetObject("CaixaToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.CaixaToolStripMenuItem2.Name = "CaixaToolStripMenuItem2"
        Me.CaixaToolStripMenuItem2.Size = New System.Drawing.Size(359, 22)
        Me.CaixaToolStripMenuItem2.Text = "Caixa"
        '
        'ClientesEmD�bitoToolStripMenuItem
        '
        Me.ClientesEmD�bitoToolStripMenuItem.Image = CType(resources.GetObject("ClientesEmD�bitoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesEmD�bitoToolStripMenuItem.Name = "ClientesEmD�bitoToolStripMenuItem"
        Me.ClientesEmD�bitoToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.ClientesEmD�bitoToolStripMenuItem.Text = "Compras de Clientes com T�tulos em Aberto"
        '
        'D�bitoClientesToolStripMenuItem
        '
        Me.D�bitoClientesToolStripMenuItem.Image = CType(resources.GetObject("D�bitoClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.D�bitoClientesToolStripMenuItem.Name = "D�bitoClientesToolStripMenuItem"
        Me.D�bitoClientesToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.D�bitoClientesToolStripMenuItem.Text = "D�bito Clientes Anal�tico/Sint�tico"
        '
        'D�bitoDeClientesComJurosToolStripMenuItem
        '
        Me.D�bitoDeClientesComJurosToolStripMenuItem.Image = CType(resources.GetObject("D�bitoDeClientesComJurosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.D�bitoDeClientesComJurosToolStripMenuItem.Name = "D�bitoDeClientesComJurosToolStripMenuItem"
        Me.D�bitoDeClientesComJurosToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.D�bitoDeClientesComJurosToolStripMenuItem.Text = "D�bito de Clientes com Juros"
        '
        'DespesasAcumuladasToolStripMenuItem
        '
        Me.DespesasAcumuladasToolStripMenuItem.Image = CType(resources.GetObject("DespesasAcumuladasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DespesasAcumuladasToolStripMenuItem.Name = "DespesasAcumuladasToolStripMenuItem"
        Me.DespesasAcumuladasToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.DespesasAcumuladasToolStripMenuItem.Text = "Despesas Acumuladas"
        '
        'FaturamentoToolStripMenuItem1
        '
        Me.FaturamentoToolStripMenuItem1.Image = CType(resources.GetObject("FaturamentoToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.FaturamentoToolStripMenuItem1.Name = "FaturamentoToolStripMenuItem1"
        Me.FaturamentoToolStripMenuItem1.Size = New System.Drawing.Size(359, 22)
        Me.FaturamentoToolStripMenuItem1.Text = "Faturamento"
        Me.FaturamentoToolStripMenuItem1.Visible = False
        '
        'Opera��eToolStripMenuItem
        '
        Me.Opera��eToolStripMenuItem.Image = CType(resources.GetObject("Opera��eToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Opera��eToolStripMenuItem.Name = "Opera��eToolStripMenuItem"
        Me.Opera��eToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.Opera��eToolStripMenuItem.Text = "Opera��es de Cr�dito"
        '
        'PacoteSemCompran�aCadastradaToolStripMenuItem
        '
        Me.PacoteSemCompran�aCadastradaToolStripMenuItem.Image = CType(resources.GetObject("PacoteSemCompran�aCadastradaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PacoteSemCompran�aCadastradaToolStripMenuItem.Name = "PacoteSemCompran�aCadastradaToolStripMenuItem"
        Me.PacoteSemCompran�aCadastradaToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.PacoteSemCompran�aCadastradaToolStripMenuItem.Text = "Pacote sem Cobran�a Cadastrada"
        Me.PacoteSemCompran�aCadastradaToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(359, 22)
        Me.ToolStripMenuItem1.Text = "Pedidos N�o Faturados por Clientes"
        '
        'RecebimentoPromotoraToolStripMenuItem
        '
        Me.RecebimentoPromotoraToolStripMenuItem.Image = CType(resources.GetObject("RecebimentoPromotoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RecebimentoPromotoraToolStripMenuItem.Name = "RecebimentoPromotoraToolStripMenuItem"
        Me.RecebimentoPromotoraToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.RecebimentoPromotoraToolStripMenuItem.Text = "Recebimento/Pend�ncias de Clientes por Promotor(a)"
        '
        'T�tuloDeClienteAVencerToolStripMenuItem
        '
        Me.T�tuloDeClienteAVencerToolStripMenuItem.Image = CType(resources.GetObject("T�tuloDeClienteAVencerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.T�tuloDeClienteAVencerToolStripMenuItem.Name = "T�tuloDeClienteAVencerToolStripMenuItem"
        Me.T�tuloDeClienteAVencerToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.T�tuloDeClienteAVencerToolStripMenuItem.Text = "T�tulo de Cliente a Vencer"
        '
        'T�tuloDeClientePagoToolStripMenuItem
        '
        Me.T�tuloDeClientePagoToolStripMenuItem.Image = CType(resources.GetObject("T�tuloDeClientePagoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.T�tuloDeClientePagoToolStripMenuItem.Name = "T�tuloDeClientePagoToolStripMenuItem"
        Me.T�tuloDeClientePagoToolStripMenuItem.Size = New System.Drawing.Size(359, 22)
        Me.T�tuloDeClientePagoToolStripMenuItem.Text = "T�tulo de Cliente Pago"
        '
        'ImprimirBoletoToolStripMenuItem
        '
        Me.ImprimirBoletoToolStripMenuItem.Image = CType(resources.GetObject("ImprimirBoletoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimirBoletoToolStripMenuItem.Name = "ImprimirBoletoToolStripMenuItem"
        Me.ImprimirBoletoToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ImprimirBoletoToolStripMenuItem.Text = "Imprimir Boleto"
        '
        'ListaDeClientesToolStripMenuItem
        '
        Me.ListaDeClientesToolStripMenuItem.Image = CType(resources.GetObject("ListaDeClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListaDeClientesToolStripMenuItem.Name = "ListaDeClientesToolStripMenuItem"
        Me.ListaDeClientesToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ListaDeClientesToolStripMenuItem.Text = "Listagem de Clientes"
        '
        'AutorizarVendaToolStripMenuItem
        '
        Me.AutorizarVendaToolStripMenuItem.Image = CType(resources.GetObject("AutorizarVendaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AutorizarVendaToolStripMenuItem.Name = "AutorizarVendaToolStripMenuItem"
        Me.AutorizarVendaToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.AutorizarVendaToolStripMenuItem.Text = "Autorizar Venda"
        '
        'ComercialToolStripMenuItem
        '
        Me.ComercialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesNovosToolStripMenuItem, Me.ComprasDeClientesComT�tulosEmAbertoToolStripMenuItem, Me.D�bitoClientesToolStripMenuItem1, Me.D�bitoDeClientesComJurosToolStripMenuItem1, Me.FaturamentoToolStripMenuItem, Me.ListaDeClientesPorConsultorToolStripMenuItem, Me.T�tuloDeClientePagoToolStripMenuItem1, Me.T�tuloDeClienteAVencerToolStripMenuItem1})
        Me.ComercialToolStripMenuItem.Name = "ComercialToolStripMenuItem"
        Me.ComercialToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ComercialToolStripMenuItem.Text = "Comercial"
        Me.ComercialToolStripMenuItem.Visible = False
        '
        'ClientesNovosToolStripMenuItem
        '
        Me.ClientesNovosToolStripMenuItem.Image = CType(resources.GetObject("ClientesNovosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesNovosToolStripMenuItem.Name = "ClientesNovosToolStripMenuItem"
        Me.ClientesNovosToolStripMenuItem.Size = New System.Drawing.Size(307, 22)
        Me.ClientesNovosToolStripMenuItem.Text = "Clientes Novos"
        Me.ClientesNovosToolStripMenuItem.Visible = False
        '
        'ComprasDeClientesComT�tulosEmAbertoToolStripMenuItem
        '
        Me.ComprasDeClientesComT�tulosEmAbertoToolStripMenuItem.Image = CType(resources.GetObject("ComprasDeClientesComT�tulosEmAbertoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ComprasDeClientesComT�tulosEmAbertoToolStripMenuItem.Name = "ComprasDeClientesComT�tulosEmAbertoToolStripMenuItem"
        Me.ComprasDeClientesComT�tulosEmAbertoToolStripMenuItem.Size = New System.Drawing.Size(307, 22)
        Me.ComprasDeClientesComT�tulosEmAbertoToolStripMenuItem.Text = "Compras de Clientes com T�tulos em Aberto"
        '
        'D�bitoClientesToolStripMenuItem1
        '
        Me.D�bitoClientesToolStripMenuItem1.Image = CType(resources.GetObject("D�bitoClientesToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.D�bitoClientesToolStripMenuItem1.Name = "D�bitoClientesToolStripMenuItem1"
        Me.D�bitoClientesToolStripMenuItem1.Size = New System.Drawing.Size(307, 22)
        Me.D�bitoClientesToolStripMenuItem1.Text = "D�bito Clientes Anal�tico/Sint�tico"
        '
        'D�bitoDeClientesComJurosToolStripMenuItem1
        '
        Me.D�bitoDeClientesComJurosToolStripMenuItem1.Image = CType(resources.GetObject("D�bitoDeClientesComJurosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.D�bitoDeClientesComJurosToolStripMenuItem1.Name = "D�bitoDeClientesComJurosToolStripMenuItem1"
        Me.D�bitoDeClientesComJurosToolStripMenuItem1.Size = New System.Drawing.Size(307, 22)
        Me.D�bitoDeClientesComJurosToolStripMenuItem1.Text = "D�bito de Clientes com Juros"
        '
        'FaturamentoToolStripMenuItem
        '
        Me.FaturamentoToolStripMenuItem.Image = CType(resources.GetObject("FaturamentoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FaturamentoToolStripMenuItem.Name = "FaturamentoToolStripMenuItem"
        Me.FaturamentoToolStripMenuItem.Size = New System.Drawing.Size(307, 22)
        Me.FaturamentoToolStripMenuItem.Text = "Faturamento"
        '
        'ListaDeClientesPorConsultorToolStripMenuItem
        '
        Me.ListaDeClientesPorConsultorToolStripMenuItem.Image = CType(resources.GetObject("ListaDeClientesPorConsultorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListaDeClientesPorConsultorToolStripMenuItem.Name = "ListaDeClientesPorConsultorToolStripMenuItem"
        Me.ListaDeClientesPorConsultorToolStripMenuItem.Size = New System.Drawing.Size(307, 22)
        Me.ListaDeClientesPorConsultorToolStripMenuItem.Text = "Lista de Clientes"
        '
        'T�tuloDeClientePagoToolStripMenuItem1
        '
        Me.T�tuloDeClientePagoToolStripMenuItem1.Image = CType(resources.GetObject("T�tuloDeClientePagoToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.T�tuloDeClientePagoToolStripMenuItem1.Name = "T�tuloDeClientePagoToolStripMenuItem1"
        Me.T�tuloDeClientePagoToolStripMenuItem1.Size = New System.Drawing.Size(307, 22)
        Me.T�tuloDeClientePagoToolStripMenuItem1.Text = "T�tulo de Cliente Pago"
        '
        'T�tuloDeClienteAVencerToolStripMenuItem1
        '
        Me.T�tuloDeClienteAVencerToolStripMenuItem1.Image = CType(resources.GetObject("T�tuloDeClienteAVencerToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.T�tuloDeClienteAVencerToolStripMenuItem1.Name = "T�tuloDeClienteAVencerToolStripMenuItem1"
        Me.T�tuloDeClienteAVencerToolStripMenuItem1.Size = New System.Drawing.Size(307, 22)
        Me.T�tuloDeClienteAVencerToolStripMenuItem1.Text = "T�tulo de Cliente a Vencer"
        '
        'NotaFiscalEletronicaToolStripMenuItem
        '
        Me.NotaFiscalEletronicaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Configura��oToolStripMenuItem, Me.EmitirNFeToolStripMenuItem})
        Me.NotaFiscalEletronicaToolStripMenuItem.Name = "NotaFiscalEletronicaToolStripMenuItem"
        Me.NotaFiscalEletronicaToolStripMenuItem.Size = New System.Drawing.Size(148, 20)
        Me.NotaFiscalEletronicaToolStripMenuItem.Text = "Documentos Eletr�nicos"
        Me.NotaFiscalEletronicaToolStripMenuItem.Visible = False
        '
        'Configura��oToolStripMenuItem
        '
        Me.Configura��oToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CidadeToolStripMenuItem, Me.CFOPToolStripMenuItem, Me.Classifica��oFiscalToolStripMenuItem})
        Me.Configura��oToolStripMenuItem.Image = CType(resources.GetObject("Configura��oToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Configura��oToolStripMenuItem.Name = "Configura��oToolStripMenuItem"
        Me.Configura��oToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.Configura��oToolStripMenuItem.Text = "Configura��o"
        '
        'CidadeToolStripMenuItem
        '
        Me.CidadeToolStripMenuItem.Image = CType(resources.GetObject("CidadeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CidadeToolStripMenuItem.Name = "CidadeToolStripMenuItem"
        Me.CidadeToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CidadeToolStripMenuItem.Text = "Cidade"
        '
        'CFOPToolStripMenuItem
        '
        Me.CFOPToolStripMenuItem.Image = CType(resources.GetObject("CFOPToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CFOPToolStripMenuItem.Name = "CFOPToolStripMenuItem"
        Me.CFOPToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CFOPToolStripMenuItem.Text = "CFOP"
        '
        'Classifica��oFiscalToolStripMenuItem
        '
        Me.Classifica��oFiscalToolStripMenuItem.Image = CType(resources.GetObject("Classifica��oFiscalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Classifica��oFiscalToolStripMenuItem.Name = "Classifica��oFiscalToolStripMenuItem"
        Me.Classifica��oFiscalToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.Classifica��oFiscalToolStripMenuItem.Text = "Classifica��o Fiscal"
        '
        'EmitirNFeToolStripMenuItem
        '
        Me.EmitirNFeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmitirNFeNFCeToolStripMenuItem, Me.EvenyosNFCeToolStripMenuItem})
        Me.EmitirNFeToolStripMenuItem.Image = CType(resources.GetObject("EmitirNFeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmitirNFeToolStripMenuItem.Name = "EmitirNFeToolStripMenuItem"
        Me.EmitirNFeToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.EmitirNFeToolStripMenuItem.Text = "Emitir NF-e/NFC-e"
        '
        'EmitirNFeNFCeToolStripMenuItem
        '
        Me.EmitirNFeNFCeToolStripMenuItem.Image = CType(resources.GetObject("EmitirNFeNFCeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmitirNFeNFCeToolStripMenuItem.Name = "EmitirNFeNFCeToolStripMenuItem"
        Me.EmitirNFeNFCeToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.EmitirNFeNFCeToolStripMenuItem.Text = "Emitir NF-e/NFC-e"
        '
        'EvenyosNFCeToolStripMenuItem
        '
        Me.EvenyosNFCeToolStripMenuItem.Image = CType(resources.GetObject("EvenyosNFCeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EvenyosNFCeToolStripMenuItem.Name = "EvenyosNFCeToolStripMenuItem"
        Me.EvenyosNFCeToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.EvenyosNFCeToolStripMenuItem.Text = "Eventos NFC-e"
        '
        'TesteToolStripMenuItem
        '
        Me.TesteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreditoToolStripMenuItem, Me.TipoCompraToolStripMenuItem, Me.AtualizaCampoDescontoTabPedidoToolStripMenuItem, Me.AtualizaPrecoTabelaToolStripMenuItem, Me.AtualizaFaturaToolStripMenuItem, Me.NotaFiscalEletronicaToolStripMenuItem1, Me.RelProdNotaToolStripMenuItem, Me.TToolStripMenuItem, Me.ConsultaProdutoToolStripMenuItem})
        Me.TesteToolStripMenuItem.Name = "TesteToolStripMenuItem"
        Me.TesteToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.TesteToolStripMenuItem.Text = "Teste"
        Me.TesteToolStripMenuItem.Visible = False
        '
        'CreditoToolStripMenuItem
        '
        Me.CreditoToolStripMenuItem.Name = "CreditoToolStripMenuItem"
        Me.CreditoToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.CreditoToolStripMenuItem.Text = "Credito"
        '
        'TipoCompraToolStripMenuItem
        '
        Me.TipoCompraToolStripMenuItem.Name = "TipoCompraToolStripMenuItem"
        Me.TipoCompraToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.TipoCompraToolStripMenuItem.Text = "Tipo Compra"
        '
        'AtualizaCampoDescontoTabPedidoToolStripMenuItem
        '
        Me.AtualizaCampoDescontoTabPedidoToolStripMenuItem.Name = "AtualizaCampoDescontoTabPedidoToolStripMenuItem"
        Me.AtualizaCampoDescontoTabPedidoToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.AtualizaCampoDescontoTabPedidoToolStripMenuItem.Text = "Atualiza campo desconto tab. pedido"
        '
        'AtualizaPrecoTabelaToolStripMenuItem
        '
        Me.AtualizaPrecoTabelaToolStripMenuItem.Name = "AtualizaPrecoTabelaToolStripMenuItem"
        Me.AtualizaPrecoTabelaToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.AtualizaPrecoTabelaToolStripMenuItem.Text = "Atualiza Preco Tabela"
        '
        'AtualizaFaturaToolStripMenuItem
        '
        Me.AtualizaFaturaToolStripMenuItem.Name = "AtualizaFaturaToolStripMenuItem"
        Me.AtualizaFaturaToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.AtualizaFaturaToolStripMenuItem.Text = "Atualiza Fatura"
        '
        'NotaFiscalEletronicaToolStripMenuItem1
        '
        Me.NotaFiscalEletronicaToolStripMenuItem1.Name = "NotaFiscalEletronicaToolStripMenuItem1"
        Me.NotaFiscalEletronicaToolStripMenuItem1.Size = New System.Drawing.Size(271, 22)
        Me.NotaFiscalEletronicaToolStripMenuItem1.Text = "Nota Fiscal eletronica"
        '
        'RelProdNotaToolStripMenuItem
        '
        Me.RelProdNotaToolStripMenuItem.Name = "RelProdNotaToolStripMenuItem"
        Me.RelProdNotaToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.RelProdNotaToolStripMenuItem.Text = "Rel Prod Nota"
        '
        'TToolStripMenuItem
        '
        Me.TToolStripMenuItem.Name = "TToolStripMenuItem"
        Me.TToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.TToolStripMenuItem.Text = "Teste NFe Novo"
        '
        'ConsultaProdutoToolStripMenuItem
        '
        Me.ConsultaProdutoToolStripMenuItem.Name = "ConsultaProdutoToolStripMenuItem"
        Me.ConsultaProdutoToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.ConsultaProdutoToolStripMenuItem.Text = "Consulta Produto"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuario, Me.lblDivisao, Me.ToolStripStatusLabel1, Me.lblData})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 594)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1284, 22)
        Me.StatusStrip1.TabIndex = 43
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblUsuario
        '
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(0, 17)
        '
        'lblDivisao
        '
        Me.lblDivisao.BackColor = System.Drawing.Color.Transparent
        Me.lblDivisao.Name = "lblDivisao"
        Me.lblDivisao.Size = New System.Drawing.Size(10, 17)
        Me.lblDivisao.Text = "|"
        Me.lblDivisao.Visible = False
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'lblData
        '
        Me.lblData.BackColor = System.Drawing.Color.Transparent
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(0, 17)
        '
        'mmGeral
        '
        Me.mmGeral.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mmGeral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCliente, Me.ToolStripSeparator1, Me.btnPedido, Me.ToolStripSeparator2, Me.btnOS, Me.ToolStripSeparator3, Me.btnMovimento, Me.ToolStripSeparator4, Me.btnBaixaOsPedido, Me.ToolStripSeparator5, Me.btnTrocaProduto, Me.ToolStripSeparator6, Me.btnSaidaExtra, Me.ToolStripSeparator7, Me.btnAndamentos, Me.ToolStripSeparator8, Me.btnCaixa})
        Me.mmGeral.Location = New System.Drawing.Point(0, 24)
        Me.mmGeral.Name = "mmGeral"
        Me.mmGeral.Size = New System.Drawing.Size(1284, 39)
        Me.mmGeral.TabIndex = 44
        Me.mmGeral.Text = "ToolStrip1"
        Me.mmGeral.Visible = False
        '
        'btnCliente
        '
        Me.btnCliente.Image = CType(resources.GetObject("btnCliente.Image"), System.Drawing.Image)
        Me.btnCliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(151, 36)
        Me.btnCliente.Text = "Cadastro de Clientes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnPedido
        '
        Me.btnPedido.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrePedidoToolStripMenuItem, Me.AbrirPedidoCompraToolStripMenuItem, Me.CompraDeLentesToolStripMenuItem, Me.ConferirPedidoCompraToolStripMenuItem, Me.NovoPedidoCompraToolStripMenuItem})
        Me.btnPedido.Image = CType(resources.GetObject("btnPedido.Image"), System.Drawing.Image)
        Me.btnPedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPedido.Name = "btnPedido"
        Me.btnPedido.Size = New System.Drawing.Size(97, 36)
        Me.btnPedido.Text = "Pedidos"
        '
        'AbrePedidoToolStripMenuItem
        '
        Me.AbrePedidoToolStripMenuItem.Name = "AbrePedidoToolStripMenuItem"
        Me.AbrePedidoToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AbrePedidoToolStripMenuItem.Text = "Abre Pedido"
        '
        'AbrirPedidoCompraToolStripMenuItem
        '
        Me.AbrirPedidoCompraToolStripMenuItem.Name = "AbrirPedidoCompraToolStripMenuItem"
        Me.AbrirPedidoCompraToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AbrirPedidoCompraToolStripMenuItem.Text = "Abrir Pedido Compra"
        '
        'CompraDeLentesToolStripMenuItem
        '
        Me.CompraDeLentesToolStripMenuItem.Name = "CompraDeLentesToolStripMenuItem"
        Me.CompraDeLentesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CompraDeLentesToolStripMenuItem.Text = "Compra de Lentes"
        '
        'ConferirPedidoCompraToolStripMenuItem
        '
        Me.ConferirPedidoCompraToolStripMenuItem.Name = "ConferirPedidoCompraToolStripMenuItem"
        Me.ConferirPedidoCompraToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ConferirPedidoCompraToolStripMenuItem.Text = "Conferir Pedido Compra"
        '
        'NovoPedidoCompraToolStripMenuItem
        '
        Me.NovoPedidoCompraToolStripMenuItem.Name = "NovoPedidoCompraToolStripMenuItem"
        Me.NovoPedidoCompraToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.NovoPedidoCompraToolStripMenuItem.Text = "Novo Pedido Compra"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnOS
        '
        Me.btnOS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvisoSobreAOSsToolStripMenuItem, Me.AvisoSobreAOS�ticaToolStripMenuItem, Me.ConsultarOSsPNomeDoClienteToolStripMenuItem, Me.EntregaOSToolStripMenuItem, Me.EnviarToolStripMenuItem, Me.Impress�oDeOSToolStripMenuItem, Me.OSPedidasPendentesToolStripMenuItem, Me.OSsPendentesDataVerifica��oToolStripMenuItem, Me.OSPendentePorFornecedorToolStripMenuItem, Me.OSsPendentesPorFornLabonorteecedorToolStripMenuItem, Me.OSsPendentePorForneceodr�ticaToolStripMenuItem, Me.PararOSTemporariamenteToolStripMenuItem, Me.ReativarOSParadaNoEstoqueToolStripMenuItem, Me.RetornoOSFeitaForaToolStripMenuItem, Me.Sa�daOSLaborat�rioToolStripMenuItem})
        Me.btnOS.Image = CType(resources.GetObject("btnOS.Image"), System.Drawing.Image)
        Me.btnOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOS.Name = "btnOS"
        Me.btnOS.Size = New System.Drawing.Size(149, 36)
        Me.btnOS.Text = "Ordem de Servi�o"
        '
        'AvisoSobreAOSsToolStripMenuItem
        '
        Me.AvisoSobreAOSsToolStripMenuItem.Image = CType(resources.GetObject("AvisoSobreAOSsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AvisoSobreAOSsToolStripMenuItem.Name = "AvisoSobreAOSsToolStripMenuItem"
        Me.AvisoSobreAOSsToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.AvisoSobreAOSsToolStripMenuItem.Text = "Aviso sobre a OS"
        '
        'AvisoSobreAOS�ticaToolStripMenuItem
        '
        Me.AvisoSobreAOS�ticaToolStripMenuItem.Name = "AvisoSobreAOS�ticaToolStripMenuItem"
        Me.AvisoSobreAOS�ticaToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.AvisoSobreAOS�ticaToolStripMenuItem.Text = "Aviso Sobre a OS �tica"
        Me.AvisoSobreAOS�ticaToolStripMenuItem.Visible = False
        '
        'ConsultarOSsPNomeDoClienteToolStripMenuItem
        '
        Me.ConsultarOSsPNomeDoClienteToolStripMenuItem.Image = CType(resources.GetObject("ConsultarOSsPNomeDoClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarOSsPNomeDoClienteToolStripMenuItem.Name = "ConsultarOSsPNomeDoClienteToolStripMenuItem"
        Me.ConsultarOSsPNomeDoClienteToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.ConsultarOSsPNomeDoClienteToolStripMenuItem.Text = "Consultar OS's p/ Nome do Cliente"
        '
        'EntregaOSToolStripMenuItem
        '
        Me.EntregaOSToolStripMenuItem.Image = CType(resources.GetObject("EntregaOSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EntregaOSToolStripMenuItem.Name = "EntregaOSToolStripMenuItem"
        Me.EntregaOSToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.EntregaOSToolStripMenuItem.Text = "Entrega de OS"
        '
        'EnviarToolStripMenuItem
        '
        Me.EnviarToolStripMenuItem.Name = "EnviarToolStripMenuItem"
        Me.EnviarToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.EnviarToolStripMenuItem.Text = "Enviar OS Fazer Fora"
        Me.EnviarToolStripMenuItem.Visible = False
        '
        'Impress�oDeOSToolStripMenuItem
        '
        Me.Impress�oDeOSToolStripMenuItem.Image = CType(resources.GetObject("Impress�oDeOSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Impress�oDeOSToolStripMenuItem.Name = "Impress�oDeOSToolStripMenuItem"
        Me.Impress�oDeOSToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.Impress�oDeOSToolStripMenuItem.Text = "Impress�o de OS"
        '
        'OSPedidasPendentesToolStripMenuItem
        '
        Me.OSPedidasPendentesToolStripMenuItem.Name = "OSPedidasPendentesToolStripMenuItem"
        Me.OSPedidasPendentesToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.OSPedidasPendentesToolStripMenuItem.Text = "OS' Pedidas Pendentes"
        Me.OSPedidasPendentesToolStripMenuItem.Visible = False
        '
        'OSsPendentesDataVerifica��oToolStripMenuItem
        '
        Me.OSsPendentesDataVerifica��oToolStripMenuItem.Name = "OSsPendentesDataVerifica��oToolStripMenuItem"
        Me.OSsPendentesDataVerifica��oToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.OSsPendentesDataVerifica��oToolStripMenuItem.Text = "OS's Pendentes Data Verifica��o"
        Me.OSsPendentesDataVerifica��oToolStripMenuItem.Visible = False
        '
        'OSPendentePorFornecedorToolStripMenuItem
        '
        Me.OSPendentePorFornecedorToolStripMenuItem.Name = "OSPendentePorFornecedorToolStripMenuItem"
        Me.OSPendentePorFornecedorToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.OSPendentePorFornecedorToolStripMenuItem.Text = "OS's Pendente por Fornecedor"
        Me.OSPendentePorFornecedorToolStripMenuItem.Visible = False
        '
        'OSsPendentesPorFornLabonorteecedorToolStripMenuItem
        '
        Me.OSsPendentesPorFornLabonorteecedorToolStripMenuItem.Name = "OSsPendentesPorFornLabonorteecedorToolStripMenuItem"
        Me.OSsPendentesPorFornLabonorteecedorToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.OSsPendentesPorFornLabonorteecedorToolStripMenuItem.Text = "OS's Pendentes por Fornecedor Labonorte"
        Me.OSsPendentesPorFornLabonorteecedorToolStripMenuItem.Visible = False
        '
        'OSsPendentePorForneceodr�ticaToolStripMenuItem
        '
        Me.OSsPendentePorForneceodr�ticaToolStripMenuItem.Name = "OSsPendentePorForneceodr�ticaToolStripMenuItem"
        Me.OSsPendentePorForneceodr�ticaToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.OSsPendentePorForneceodr�ticaToolStripMenuItem.Text = "OS's Pendente por Fornecedor �tica"
        Me.OSsPendentePorForneceodr�ticaToolStripMenuItem.Visible = False
        '
        'PararOSTemporariamenteToolStripMenuItem
        '
        Me.PararOSTemporariamenteToolStripMenuItem.Name = "PararOSTemporariamenteToolStripMenuItem"
        Me.PararOSTemporariamenteToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.PararOSTemporariamenteToolStripMenuItem.Text = "Parar OS Temporariamente"
        Me.PararOSTemporariamenteToolStripMenuItem.Visible = False
        '
        'ReativarOSParadaNoEstoqueToolStripMenuItem
        '
        Me.ReativarOSParadaNoEstoqueToolStripMenuItem.Name = "ReativarOSParadaNoEstoqueToolStripMenuItem"
        Me.ReativarOSParadaNoEstoqueToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.ReativarOSParadaNoEstoqueToolStripMenuItem.Text = "Reativar OS Parada no Estoque"
        Me.ReativarOSParadaNoEstoqueToolStripMenuItem.Visible = False
        '
        'RetornoOSFeitaForaToolStripMenuItem
        '
        Me.RetornoOSFeitaForaToolStripMenuItem.Name = "RetornoOSFeitaForaToolStripMenuItem"
        Me.RetornoOSFeitaForaToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.RetornoOSFeitaForaToolStripMenuItem.Text = "Retorno OS Feita Fora"
        Me.RetornoOSFeitaForaToolStripMenuItem.Visible = False
        '
        'Sa�daOSLaborat�rioToolStripMenuItem
        '
        Me.Sa�daOSLaborat�rioToolStripMenuItem.Name = "Sa�daOSLaborat�rioToolStripMenuItem"
        Me.Sa�daOSLaborat�rioToolStripMenuItem.Size = New System.Drawing.Size(296, 22)
        Me.Sa�daOSLaborat�rioToolStripMenuItem.Text = "Sa�da OS Laborat�rio"
        Me.Sa�daOSLaborat�rioToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btnMovimento
        '
        Me.btnMovimento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Confer�nciaToolStripMenuItem, Me.GiroToolStripMenuItem, Me.SaldoToolStripMenuItem, Me.Saldo�ticaToolStripMenuItem})
        Me.btnMovimento.Image = CType(resources.GetObject("btnMovimento.Image"), System.Drawing.Image)
        Me.btnMovimento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMovimento.Name = "btnMovimento"
        Me.btnMovimento.Size = New System.Drawing.Size(97, 36)
        Me.btnMovimento.Text = "Estoque"
        Me.btnMovimento.ToolTipText = "Movimento Estoque"
        '
        'Confer�nciaToolStripMenuItem
        '
        Me.Confer�nciaToolStripMenuItem.Image = CType(resources.GetObject("Confer�nciaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.Confer�nciaToolStripMenuItem.Name = "Confer�nciaToolStripMenuItem"
        Me.Confer�nciaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.Confer�nciaToolStripMenuItem.Text = "Confer�ncia"
        '
        'GiroToolStripMenuItem
        '
        Me.GiroToolStripMenuItem.Image = CType(resources.GetObject("GiroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GiroToolStripMenuItem.Name = "GiroToolStripMenuItem"
        Me.GiroToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GiroToolStripMenuItem.Text = "Giro Estoque"
        '
        'SaldoToolStripMenuItem
        '
        Me.SaldoToolStripMenuItem.Image = CType(resources.GetObject("SaldoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaldoToolStripMenuItem.Name = "SaldoToolStripMenuItem"
        Me.SaldoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SaldoToolStripMenuItem.Text = "Saldo Estoque"
        '
        'Saldo�ticaToolStripMenuItem
        '
        Me.Saldo�ticaToolStripMenuItem.Name = "Saldo�ticaToolStripMenuItem"
        Me.Saldo�ticaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.Saldo�ticaToolStripMenuItem.Text = "Saldo �tica"
        Me.Saldo�ticaToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'btnBaixaOsPedido
        '
        Me.btnBaixaOsPedido.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaixaPedidoToolStripMenuItem, Me.BaixaOSLabonorteToolStripMenuItem, Me.BaixaOS�ticaToolStripMenuItem})
        Me.btnBaixaOsPedido.Image = CType(resources.GetObject("btnBaixaOsPedido.Image"), System.Drawing.Image)
        Me.btnBaixaOsPedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBaixaOsPedido.Name = "btnBaixaOsPedido"
        Me.btnBaixaOsPedido.Size = New System.Drawing.Size(166, 36)
        Me.btnBaixaOsPedido.Text = "Baixa de OS e Pedido"
        Me.btnBaixaOsPedido.ToolTipText = "Baixa de OS/ Pedido"
        '
        'BaixaPedidoToolStripMenuItem
        '
        Me.BaixaPedidoToolStripMenuItem.Image = CType(resources.GetObject("BaixaPedidoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BaixaPedidoToolStripMenuItem.Name = "BaixaPedidoToolStripMenuItem"
        Me.BaixaPedidoToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.BaixaPedidoToolStripMenuItem.Text = "Baixa de Pedido"
        '
        'BaixaOSLabonorteToolStripMenuItem
        '
        Me.BaixaOSLabonorteToolStripMenuItem.Image = CType(resources.GetObject("BaixaOSLabonorteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BaixaOSLabonorteToolStripMenuItem.Name = "BaixaOSLabonorteToolStripMenuItem"
        Me.BaixaOSLabonorteToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.BaixaOSLabonorteToolStripMenuItem.Text = "Baixa de OS"
        '
        'BaixaOS�ticaToolStripMenuItem
        '
        Me.BaixaOS�ticaToolStripMenuItem.Name = "BaixaOS�ticaToolStripMenuItem"
        Me.BaixaOS�ticaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.BaixaOS�ticaToolStripMenuItem.Text = "Baixa OS �tica"
        Me.BaixaOS�ticaToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'btnTrocaProduto
        '
        Me.btnTrocaProduto.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrocaProdutoOSLabonorteToolStripMenuItem, Me.TrocaDeBaseToolStripMenuItem, Me.TrocaDeProdutoEBaseCSa�daDoEstoqueToolStripMenuItem})
        Me.btnTrocaProduto.Image = CType(resources.GetObject("btnTrocaProduto.Image"), System.Drawing.Image)
        Me.btnTrocaProduto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTrocaProduto.Name = "btnTrocaProduto"
        Me.btnTrocaProduto.Size = New System.Drawing.Size(133, 36)
        Me.btnTrocaProduto.Text = "Trocar Produto"
        Me.btnTrocaProduto.ToolTipText = "Troca de Produto"
        '
        'TrocaProdutoOSLabonorteToolStripMenuItem
        '
        Me.TrocaProdutoOSLabonorteToolStripMenuItem.Name = "TrocaProdutoOSLabonorteToolStripMenuItem"
        Me.TrocaProdutoOSLabonorteToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.TrocaProdutoOSLabonorteToolStripMenuItem.Text = "Produto Sem Ter Saido do Estoque"
        '
        'TrocaDeBaseToolStripMenuItem
        '
        Me.TrocaDeBaseToolStripMenuItem.Name = "TrocaDeBaseToolStripMenuItem"
        Me.TrocaDeBaseToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.TrocaDeBaseToolStripMenuItem.Text = "Base Sem Ter Saido do Estoque"
        '
        'TrocaDeProdutoEBaseCSa�daDoEstoqueToolStripMenuItem
        '
        Me.TrocaDeProdutoEBaseCSa�daDoEstoqueToolStripMenuItem.Name = "TrocaDeProdutoEBaseCSa�daDoEstoqueToolStripMenuItem"
        Me.TrocaDeProdutoEBaseCSa�daDoEstoqueToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.TrocaDeProdutoEBaseCSa�daDoEstoqueToolStripMenuItem.Text = "Produto e Base Com Saida do Estoque"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'btnSaidaExtra
        '
        Me.btnSaidaExtra.Image = CType(resources.GetObject("btnSaidaExtra.Image"), System.Drawing.Image)
        Me.btnSaidaExtra.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaidaExtra.Name = "btnSaidaExtra"
        Me.btnSaidaExtra.Size = New System.Drawing.Size(100, 36)
        Me.btnSaidaExtra.Text = "Sa�da Extra"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'btnAndamentos
        '
        Me.btnAndamentos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AndamentosToolStripMenuItem, Me.Andamentos�ticaToolStripMenuItem})
        Me.btnAndamentos.Image = CType(resources.GetObject("btnAndamentos.Image"), System.Drawing.Image)
        Me.btnAndamentos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAndamentos.Name = "btnAndamentos"
        Me.btnAndamentos.Size = New System.Drawing.Size(123, 36)
        Me.btnAndamentos.Text = "Andamentos"
        '
        'AndamentosToolStripMenuItem
        '
        Me.AndamentosToolStripMenuItem.Image = CType(resources.GetObject("AndamentosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AndamentosToolStripMenuItem.Name = "AndamentosToolStripMenuItem"
        Me.AndamentosToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AndamentosToolStripMenuItem.Text = "Andamentos OS"
        '
        'Andamentos�ticaToolStripMenuItem
        '
        Me.Andamentos�ticaToolStripMenuItem.Name = "Andamentos�ticaToolStripMenuItem"
        Me.Andamentos�ticaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.Andamentos�ticaToolStripMenuItem.Text = "Andamentos �tica"
        Me.Andamentos�ticaToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 39)
        '
        'btnCaixa
        '
        Me.btnCaixa.Image = CType(resources.GetObject("btnCaixa.Image"), System.Drawing.Image)
        Me.btnCaixa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCaixa.Name = "btnCaixa"
        Me.btnCaixa.Size = New System.Drawing.Size(72, 36)
        Me.btnCaixa.Text = "Caixa"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.BTSistemas.My.Resources.Resources.tela_teste
        Me.PictureBox1.Location = New System.Drawing.Point(0, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1284, 531)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1284, 616)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mmGeral)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.mmGeral.ResumeLayout(False)
        Me.mmGeral.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
#Region "Atualiza��o"
    Dim strfile As String
    Dim v As String
    Private Function versao() As Boolean
        Dim r As String
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\atualiza.ok") = True Then
            Return False
        End If
        r = File.ReadAllText("//dellservidor/arquivos/mrotica/versao.txt")
        If r.Substring(7, 4) < strfile.Substring(7, 4) Then
            Return False
        End If
        If r.Trim.ToUpper <> strfile.Trim.ToUpper Then
            strfile = r & ".exe"
            Return True
        Else
            Return False
        End If
    End Function
    Private Function ver() As String
        Dim r As String
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\atualiza.ok") = True Then
            Return False
        End If
        r = File.ReadAllText("//dellservidor/arquivos/mrotica/versao.txt")
        strfile = r & ".exe"
        Return strfile
    End Function
    Private Sub baixa_normal()
        If versao() = False Then
            Exit Sub
        End If
        Try
            File.Copy("\\dellservidor\arquivos\mrotica\" & strfile, Application.StartupPath & "\" & strfile)
            MsgBox("Atualiza��o dispon�vel, feche o aplicativo para atualizar!")
            File.Create(Application.StartupPath & "\" & "atualiza.ok")
            Application.Exit()
        Catch ex As Exception
            AVISO(ex.Message & vbCrLf & "Pode n�o haver vers�o mais atual ou n�o foi poss�vel conectar! Tentando via proxy.", Me, frmAviso.tipo_aviso.tipo_ok)
        End Try

    End Sub
#End Region
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmConsultaProduto
        f.ShowDialog(Me)
        f.Dispose()
    End Sub
    Private Function currentDomain_AssemblyResolve(ByVal sender As Object, ByVal args As ResolveEventArgs) As Assembly
        'This handler is called only when the common language runtime tries to bind to the assembly and fails.

        'Retrieve the list of referenced assemblies in an array of AssemblyName.
        Dim MyAssembly As Assembly, objExecutingAssemblies As Assembly
        Dim strTempAssmbPath As String = ""

        objExecutingAssemblies = Assembly.GetExecutingAssembly()
        Dim arrReferencedAssmbNames As AssemblyName() = objExecutingAssemblies.GetReferencedAssemblies()

        'Loop through the array of referenced assembly names.
        For Each strAssmbName As AssemblyName In arrReferencedAssmbNames
            'Check for the assembly names that have raised the "AssemblyResolve" event.
            If strAssmbName.FullName.Substring(0, strAssmbName.FullName.IndexOf(",")) = args.Name.Substring(0, args.Name.IndexOf(",")) Then
                'Build the path of the assembly from where it has to be loaded.
                'The following line is probably the only line of code in this method you may need to modify:
                strTempAssmbPath = Application.StartupPath & "\dll3rdprt\"
                If strTempAssmbPath.EndsWith("\") Then
                    strTempAssmbPath += "\"
                End If
                strTempAssmbPath += args.Name.Substring(0, args.Name.IndexOf(",")) & ".dll"
            End If
        Next
        'Load the assembly from the specified path.
        MyAssembly = Assembly.LoadFrom(strTempAssmbPath)

        'Return the loaded assembly.
        Return MyAssembly
    End Function
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If dbCon.ConectadoBanco = False Then
            Dim f As New frmConfiguracao
            f.ShowDialog()
            f.Dispose()
            Exit Sub
        End If

        Dim fSenha As New Formulario.frmSenha
        fSenha.ShowDialog()
        UserPermissao.RetornaRegistro(fSenha.CodigoUsuario)
        intCodigoUsuario = fSenha.CodigoUsuario
        fSenha.Dispose()
        'Dim currentDomain As AppDomain = AppDomain.CurrentDomain
        'AddHandler currentDomain.AssemblyResolve, AddressOf currentDomain_AssemblyResolve
        'res = user.login(Me)
        'If res.StartsWith("OK") Then
        'UserID = user.cod_usuario
        'Else
        'AVISO(res, Me, frmAviso.tipo_aviso.tipo_ok, True)
        'Me.Close()
        'Exit Sub
        'End If
        'ATUALIZAR()
        'acessos()
        Me.Text = Application.ProductName & " Vers�o: " & Application.ProductVersion &
        " DB: " & arq.BancoDB & " Servidor: " & arq.ServidorDB & " Loja: " & arq.Filial

        lblDivisao.Visible = True
        lblUsuario.Text = "USU�RIO: " & UserPermissao.NomeUsuario
        lblData.Text = FormatDateTime(Now(), DateFormat.ShortDate)
        AcessoMenu()
    End Sub
    Private Sub ATUALIZAR()
        Dim strPath As String
        Dim vs As String
        Exit Sub
        v = Application.ProductVersion.ToString.Replace(".", "")
        strfile = "mrotica" & v
        Try
            baixa_normal()
        Catch ex As Exception

        End Try

        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\atualiza.ok") = True Then
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\atualiza.ok")
            vs = CInt(v)
            vs = vs + 1
            If vs.Length < 4 Then
                vs = adiciona_zeros(vs, 4)
            End If
            Try
                Shell(Application.StartupPath & "\" & ver() & " /S")
                Application.ExitThread()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            vs = CInt(v)
            If vs.Length < 4 Then
                vs = adiciona_zeros(vs, 4)
            End If
            strPath = Application.StartupPath & "\mrotica" & vs & ".exe"
            If My.Computer.FileSystem.FileExists(strPath) = True Then
                My.Computer.FileSystem.DeleteFile(strPath)
            End If
        End If
    End Sub
    Private Sub btnConsBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmConsBase
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub btnConsultaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmConsultaCliente
        f.ShowDialog(Me)
        MsgBox(f.cod_cliente & " - " & f.cod_filial & "-" & f.nome)
        f.Dispose()
    End Sub
    Private Sub btnOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmOS
        f.Show()
    End Sub

    Private Sub btnPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmPedido
        'f._num_pedido = 1
        'f._id_filial = 1
        f.origem = "novo"
        f.Show()
    End Sub

    Private Sub abreCaixa()
        Dim f As New frmCaixa
        If UserPermissao.Perfil = 5 Or UserPermissao.Perfil = 1 _
        Or UserPermissao.Perfil = 6 Then
            'f.user = user
            f.ShowDialog(Me)
        Else
            AVISO("Usu�rio n�o tem acesso a esse m�dulo!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                Exit Sub
            End If
    End Sub

    Private Sub btnForn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmConsultaForPesq
        f.ShowDialog(Me)
        f.Dispose()
    End Sub
    Private Sub btnPedidoCompraAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmPedidoCompraAuto
        f.acao = pedido_compra_acao.pedido_novo
        f.tipo_pedido = tipo_pedido_compra.Pedido_auto
        f.ShowDialog(Me)
        f.Dispose()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmPedidoCompraAuto
        f.acao = pedido_compra_acao.pedido_edicao
        f.ShowDialog(Me)
        f.Dispose()
    End Sub
    Private Sub btnImprimePedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New DataTable
        Dim sql As String
        Dim f As New frmRpt
        Dim r As New rptListaPedido
        sql = "SELECT lentes_tabela.cod_tabela, produtos.produto, produtos.cod_barra," &
        "SUM(pedido_fornecedor_itens.quantidade) AS quant, " &
        "pedido_fornecedor_itens.Preco_compra - pedido_fornecedor_itens.Preco_compra * " &
        "(pedido_fornecedor_itens.desconto_compra / 100) AS Preco, " &
        "pedido_fornecedor_itens.Preco_compra, pedido_fornecedor_itens.desconto_compra, " &
        "SUM((pedido_fornecedor_itens.Preco_compra - pedido_fornecedor_itens.Preco_compra * " &
        "(pedido_fornecedor_itens.desconto_compra / 100)) * pedido_fornecedor_itens.quantidade) " &
        "AS Total,lentes_tabela.nome_comercial FROM pedido_fornecedor_itens INNER JOIN " &
        "produtos ON pedido_fornecedor_itens.cod_produto = produtos.cod_produto INNER JOIN " &
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " &
        "produtos.id_fabricante = lentes_blocos.id_fabricante INNER JOIN " &
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " &
        "WHERE  (pedido_fornecedor_itens.cod_pedido = 1 ) AND " &
        "(pedido_fornecedor_itens.id_filial = 1) " &
        "GROUP BY lentes_tabela.cod_tabela, produtos.produto, produtos.cod_barra, " &
        "pedido_fornecedor_itens.Preco_compra,pedido_fornecedor_itens.desconto_compra, " &
        "pedido_fornecedor_itens.Preco_compra - pedido_fornecedor_itens.Preco_compra " &
        "* (pedido_fornecedor_itens.desconto_compra / 100),lentes_tabela.nome_comercial"
        d.carrega_Tabela(sql, t)
        r.DataSource = t
        f.Relat(r)
        f.ShowDialog(Me)
    End Sub
    Private Sub btnConferirPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmPedidoCompraAuto
        f.acao = pedido_compra_acao.pedido_Entrada
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub btnAlteraOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmOS
        f.novo = False
        f.n_OS = InputBox("Digite o n�mero da OS")
        f.Filial = 1
        f.Show()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmUpdate
        f.ShowDialog(Me)
        f.Dispose()
    End Sub
    Private Sub btnImportaRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmImportaResolution
        f.ShowDialog(Me)
        f.Dispose()
    End Sub
    Private Sub btnTeste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tit As New objBoleto
        Dim banco As New objContaBanco
        Dim d As New frmData
        d.ShowDialog(Me)
        banco.filtra(1, 1)
        My.Computer.Clipboard.SetText(banco.itemBB07(tit.listar_boletos_remessa(d.dtIni.Value)))
    End Sub
    Private Sub atualiza_cliente_lancamento()
        Dim tsql As String
        Dim isql As String
        Dim tt As New DataTable
        tsql = "SELECT lancamentos.id_filial,lancamentos.cod_lancamento, " &
        "cliente.cod_filial_cliente, " &
        " cliente.cod_cliente, cliente.nome_cliente FROM lancamentos INNER JOIN " &
        "Pagamentos_fatura ON lancamentos.cod_lancamento = Pagamentos_fatura.cod_lancamento " &
        "AND lancamentos.id_filial = Pagamentos_fatura.id_filial INNER JOIN " &
        "Fatura ON Pagamentos_fatura.cod_fatura = Fatura.cod_fatura AND " &
        "Pagamentos_fatura.id_filial = Fatura.id_filial INNER JOIN " &
        "cliente ON Fatura.cod_filial_cliente = cliente.cod_filial_cliente AND " &
        "Fatura.cod_cliente = cliente.cod_cliente"
        d.carrega_Tabela(tsql, tt)
        For Each r As DataRow In tt.Rows
            isql = "INSERT INTO lancamentos_cliente (id_filial" &
           ",cod_lancamento,cod_filial_cliente,cod_cliente) " &
           "VALUES(" & r("id_filial") &
           "," & r("cod_lancamento") &
           "," & r("cod_filial_cliente") &
           "," & r("cod_cliente") & ")"
            d.Comando(isql, True)
        Next
        MsgBox("Fim")
    End Sub
    Private Function data_master(ByVal x_cod As Integer) As Date
        Dim sql As String
        Dim tt As New DataTable
        sql = "select data from movimentomaster where cod_movimento = " & x_cod & ""
        d.carrega_Tabela(sql, tt)
        Return tt.Rows(0)("data")
    End Function
    Private Sub atualizadata(ByVal data As Date, ByVal cod_l As Integer, ByVal f As Integer)
        Dim sql As String
        sql = "Update movimento set data_lancamento = " & d.pdtm(data) &
        " where cod_lancamento = " & cod_l & " and id_filial = " & f & ""
        d.Comando(sql, True)
    End Sub


    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmCliente_Old
        f.Show()
    End Sub

    Private Sub btnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmConfig
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub btnCadBarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmCadBarraDiop
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub btnRelatTratamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmTratamentosPeriodo
        f.Show()
    End Sub

    Private Sub btnRelatSaidasLentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Relat�rioDeSa�dasDeLentePorPer�odoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Relat�rioDeSa�dasDeLentePorPer�odoToolStripMenuItem.Click
        Dim f As New frmSaidasLentesFabricante
        f.ShowDialog()
    End Sub

    Private Sub Confer�nciaEEntradaDeNFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Confer�nciaEEntradaDeNFToolStripMenuItem.Click
        Dim f As New frmConferenciaNota
        f.novo = True
        f.x_filial = 0
        f.x_id_conferencia = 0
        f.Show()
    End Sub

    Private Sub OssN�oConclu�dasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OssN�oConclu�dasToolStripMenuItem.Click
        Dim f As New frmOsNaoConcluida
        f.Show()
    End Sub

    Private Sub DespesasPer�odoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespesasPer�odoToolStripMenuItem.Click
        Dim f As New frmRpt
        Dim r As New rptDespesas
        Dim lanc As New objLancamentos
        Dim fdata As New frmDataCaixa
        fdata.ShowDialog()

        r.diai = fdata.dtIni.Value
        r.diaf = fdata.dtFim.Value
        r.DataSource = lanc.listar_despesas_data(fdata.dtIni.Value, fdata.dtFim.Value, arq.Filial)
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub btnPendEstoqueVerificacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub aviso_OS()
        Dim f As New frmAvisoOS
        f.labo = True
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub TratamentoCrizalPer�odoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TratamentoCrizalPer�odoToolStripMenuItem.Click
        Dim sql As String
        Dim di, df As Date
        Dim fp As New frmDataPeriodo
        Dim tt As New DataTable
        Dim fR As New frmRpt
        Dim r As New rptRelatorioTratamentoPeriodo
        fp.ShowDialog(Me)
        di = fp.dtIni.Value.Date & " 00:00:00"
        df = fp.dtFim.Value.Date & " 23:59:59"
        sql = "SELECT     lugar, Cliente, Tratamento, SUM(Olhos) AS quant, cod_cliente,cod_produto " &
        "FROM dbo.Trat_crizal_e_A2(" & d.pdtm(di) & ", " & d.pdtm(df) & ") AS Trat_crizal_e_A2_1 " &
        "GROUP BY lugar, Cliente, Tratamento, cod_cliente,cod_produto " &
        "HAVING (lugar = '�ticas Ana Maria') " &
        "ORDER BY lugar Desc, cod_cliente, Tratamento"
        d.carrega_Tabela(sql, tt)
        r.tipoRelatorio = rptRelatorioTratamentoPeriodo.tipo.Alize_A2
        r.titulo = "Tratamentos Crizal Aliz� e Crizal A2 �ticas Ana Maria entre " & di.Date & " e " & df.Date & "."
        r.DataSource = tt
        fR.Relat(r)
        fR.Show()
    End Sub

    Private Sub CompraDeCr�ditosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompraDeCr�ditosToolStripMenuItem.Click
        'Dim f As New frmCompraCredito
        'f.ShowDialog(Me)
        'f.Dispose()
    End Sub

    Private Sub AjusteContagemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjusteContagemToolStripMenuItem.Click
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        If acesso.verifica_permissao_usuario(intUsuario, 55) = True Then
            Dim f As New frmAjusteContagem
            f.Show()
        Else
            MessageBox.Show("Usu�rio sem permiss�o para acessar este m�dulo.", "ERROR: 55", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub TrocaDeDioptriaEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrocaDeDioptriaEstoqueToolStripMenuItem.Click
        Dim f As New frmTrocaDioptria
        f.ShowDialog(Me)
        f.Dispose()
    End Sub


    Private Sub TratamentosOptikotEOptikotEasyClean�ticasAnaMariaPorPer�odoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TratamentosOptikotEOptikotEasyClean�ticasAnaMariaPorPer�odoToolStripMenuItem.Click
        Dim sql As String
        Dim di, df As Date
        Dim fp As New frmDataPeriodo
        Dim tt As New DataTable
        Dim fR As New frmRpt
        Dim r As New rptRelatorioTratamentoPeriodo
        fp.ShowDialog(Me)
        di = fp.dtIni.Value.Date & " 00:00:00"
        df = fp.dtFim.Value.Date & " 23:59:59"
        sql = "SELECT lugar, Cliente, Tratamento, SUM(Olhos) AS quant, cod_cliente,cod_produto " &
        "FROM dbo.Trat_OPT_e_EASY(" & d.pdtm(di) & ", " & d.pdtm(df) & ") AS Trat " &
        "GROUP BY lugar, Cliente, Tratamento, cod_cliente,cod_produto " &
        "HAVING (lugar = '�ticas Ana Maria') " &
        "ORDER BY lugar Desc, cod_cliente, Tratamento"
        d.carrega_Tabela(sql, tt)
        r.tipoRelatorio = rptRelatorioTratamentoPeriodo.tipo.OPT_EASY
        r.titulo = "Tratamentos OPTIKOT e OPTIKOT EASY CLEAN Ana Maria entre " & di.Date & " e " & df.Date & "."
        r.DataSource = tt
        fR.Relat(r)
        fR.Show()
    End Sub

    Private Sub AbreNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbreNotaToolStripMenuItem.Click
        'Dim f As New frmConferenciaNota
        Dim fn As New frmAbreNF
        fn.ShowDialog(Me)
    End Sub

    Private Sub TabelaDeLentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabelaDeLentesToolStripMenuItem.Click
        Dim tt As New DataTable
        Dim f As New frmRpt
        Dim r As New rptTabela
        Dim sql As String
        sql = "SELECT lentes_tabela.nome_comercial, lentes_tabela.cod_tabela, " &
        "fabricante.fabricante, lentes_tabela.especie FROM lentes_tabela INNER JOIN " &
        "fabricante ON lentes_tabela.id_fabricante = fabricante.id_fabricante " &
        "where (cod_tabela <> 0 and cod_tabela <> 1 and cod_tabela <> 2 and " &
        "cod_tabela <> 11163) " &
        "ORDER BY fabricante.fabricante, lentes_tabela.especie, lentes_tabela.nome_comercial"
        d.carrega_Tabela(sql, tt)
        r.DataSource = tt
        f.Relat(r)
        f.Show()
    End Sub

    Private Sub CancelaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelaToolStripMenuItem.Click
        Dim f As New frmCancelaOS
        f.ShowDialog()
    End Sub

    Private Sub NovaTabelaPromocionalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovaTabelaPromocionalToolStripMenuItem.Click
        Dim f As New frmTabelaPromocional
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub AbreTabelaPromocionalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbreTabelaPromocionalToolStripMenuItem.Click
        Dim f As New frmAbreTabelaPromocional
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub Relat�rio360AnaMariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Relat�rio360AnaMariaToolStripMenuItem.Click
        Dim r As New rptVendasVarilux360
        Dim fr As New frmRpt
        Dim dt As New frmDataPeriodo
        Dim sql As String
        Dim di, df As String
        Dim d As New dados
        Dim tt As New DataTable
        Dim path As String
        Dim os As New anamaria.Service
        dt.ShowDialog(Me)

        di = dt.dtIni.Value.Date & " 00:00:00"
        df = dt.dtFim.Value.Date & " 23:59:59"
        MsgBox(di.ToString)

        'd.carrega_Tabela(sql, tt)
        tt = os.R360(di, df).Tables(0)
        r.DataSource = tt
        r.titulo = "Vendas de Essilor 360 no per�odo de " & dt.dtIni.Value.Date &
        " at� " & dt.dtFim.Value.Date & "."
        fr.Relat(r)
        fr.ShowDialog(Me)
    End Sub

    Private Sub OssComLifestyleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OssComLifestyleToolStripMenuItem.Click
        Dim r As New rptOSsFamilia
        Dim fr As New frmRpt
        Dim dt As New frmDataPeriodo
        Dim di, df As String
        Dim d As New dados
        Dim tt As New DataTable
        Dim os As New anamaria.Service
        dt.ShowDialog(Me)

        di = dt.dtIni.Value.Date & " 00:00:00"
        df = dt.dtFim.Value.Date & " 23:59:59"


        'd.carrega_Tabela(sql, tt)
        'tt = os.RTrueForm(di, df).Tables(0)
        r.DataSource = tt
        r.titulo = "Vendas de True Form no per�odo de " & dt.dtIni.Value.Date &
        " at� " & dt.dtFim.Value.Date & "."
        fr.Relat(r)
        fr.ShowDialog(Me)
    End Sub
    Private Sub TratamentoAntiRiscoNoPer�odoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TratamentoAntiRiscoNoPer�odoToolStripMenuItem.Click
        Dim sql As String
        Dim di, df As Date
        Dim fp As New frmDataPeriodo
        Dim tt As New DataTable
        Dim fR As New frmRpt
        Dim r As New rptRelatorioTratamentoPeriodo
        fp.ShowDialog(Me)
        di = fp.dtIni.Value.Date & " 00:00:00"
        df = fp.dtFim.Value.Date & " 23:59:59"
        sql = "SELECT     lugar, Cliente, Tratamento, SUM(Olhos) AS quant, cod_cliente,cod_produto " &
        "FROM dbo.Trat_Anti_risco(" & d.pdtm(di) & ", " & d.pdtm(df) & ") AS Trat " &
        "GROUP BY lugar, Cliente, Tratamento, cod_cliente,cod_produto " &
        "ORDER BY lugar Desc, cod_cliente, Tratamento"
        d.carrega_Tabela(sql, tt)
        r.tipoRelatorio = rptRelatorioTratamentoPeriodo.tipo.Anti_Risco
        r.titulo = "Tratamentos Anti-Risco entre " & di.Date & " e " & df.Date & "."
        r.DataSource = tt
        fR.Relat(r)
        fR.Show()
    End Sub
    Private Sub Relat�rioPontua��esAnaMariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Relat�rioPontua��esAnaMariaToolStripMenuItem.Click
        Dim user As New objUsuario
        Dim fi As New frmDataPeriodo
        Dim t As New DataTable
        Dim f As New frmRpt
        Dim r As New rptListaPontuacao
        Dim o As New anamaria.Service
        'Dim path As String
        Dim di, df As String
        'Dim pr As New WebProxy("firewall", 8080)
        Dim cr As New NetworkCredential()
        fi.ShowDialog(Me)
        cr.UserName = "labonorte"
        cr.Password = "senha"
        cr.Domain = "labonorte"
        'pr.Credentials = cr
        'o.Proxy = pr
        di = fi.dtIni.Value.Date & " 00:00:00"
        df = fi.dtFim.Value.Date & " 23:59:59"
        Try
            t = o.RPontuacao(di, df).Tables(0)
            't = o.RPontuacao(fi.dtIni.Value, fi.dtFim.Value).Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        r.DataSource = t
        r.titulo = "Relat�rio de Pontua��es no per�odo de " & fi.dtIni.Value.Date & " at� " &
        fi.dtFim.Value.Date & ". Emitido em " & Now.ToLongDateString
        fi.Dispose()
        f.Relat(r)
        f.Show()

    End Sub

    Private Sub PedidosN�oFaturadosPorClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidosN�oFaturadosPorClientesToolStripMenuItem.Click
        Dim rpt As New rptPedidosCliente
        Dim f As New frmRpt
        Dim cliente As New objCliente
        rpt.DataSource = cliente.pedido_clientes_faturado(arq.Filial, False)
        rpt.TITULO = "Pedidos n�o faturados por Cliente"
        f.Relat(rpt)
        f.Show()
    End Sub

    Private Sub FaturasComSaldoPorClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaturasComSaldoPorClientesToolStripMenuItem.Click
        Dim rpt As New rptFaturasPorCiente
        Dim f As New frmRpt
        Dim cliente As New objCliente
        rpt.DataSource = cliente.faturas_clientes_com_saldo
        rpt.lblTitulo.Text = "Faturas com saldo por Cliente"
        f.Relat(rpt)
        f.Show()
    End Sub


    Private Sub Confirma��oCr�ditoCancelamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Confirma��oCr�ditoCancelamentoToolStripMenuItem.Click
        Dim f As New frmConfirmaCreditoCancelamento
        f.ShowDialog(Me)

    End Sub
    Private Sub giro_otica()
        Dim f As New frmRpt
        Dim r As Object
        Dim prod As New produtoClass
        Dim wsAna As New anamaria.Service
        Dim cod_tabela As String
        Dim es As String
        Dim di, df, filial As String
        Dim tb As New DataTable
        cod_tabela = InputBox("Digite o c�digo da lente:")
        es = prod.ret_especie(cod_tabela)
        di = Now.ToShortDateString & " 00:00:00"
        df = Now.ToShortDateString & " 23:59:59"
        filial = 1
        Try
            If es.ToUpper.Trim = "L" Then
                r = New rptGiroLentes
            Else
                r = New rptGiroblocos
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Me.Cursor = Cursors.AppStarting
        Try
            tb = wsAna.RGiro(cod_tabela, di, df, filial).Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try
        Me.Cursor = Cursors.Default
        r.titulo = "Relat�rio de Giro do Produto " & cod_tabela & " " &
        " no periodo entre " & di & " e " & df & " em Ana Maria Loja " & adiciona_zeros(filial, 2)
        r.DataSource = tb
        f.Relat(r)
        f.Show()
    End Sub

    Private Sub TrocarSenhaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrocarSenhaToolStripMenuItem.Click
        Dim f As New frmTrocaSenha
        f.codusuario = acesso.retorna_codigo_usuario(strUsuario)
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub EmissaoRemessaBBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmissaoRemessaBBToolStripMenuItem.Click
        Dim bancos As New objContaBanco
        Dim boletos As New objBoleto
        Dim CodBanco As Integer
        Dim CodEmitente As Integer
        Dim fd As New frmData
        Dim Remessa As DataTable
        'Titulos.Remessa(CodBanco, CodEmitente, Data.Value, P_Juros).Tables(0)
        fd.ShowDialog(Me)
        bancos.filtra(1, 1)
        CodBanco = bancos.codigoBanco04de25
        Remessa = boletos.listar_boletos_remessa(fd.dtIni.Value)
        If Remessa.Rows.Count = 0 Then
            MessageBox.Show("N�o existe Boleto nesta Data, Banco e Emitente")
            Return
        End If
        Dim Arquivo As Int32 = 1
        Dim Dir As String = "Banco" & String.Format("{0:D4}", CodBanco)
        If Not Directory.Exists(Dir) Then
            Directory.CreateDirectory(Dir)
        End If
        Dim Na As Integer = 0
        Dim N_Arquivo As String = Dir & "\REM" & String.Format("{0:D4}", DateTime.Today.Year) & String.Format("{0:D2}", DateTime.Today.Month) & String.Format("{0:D2}", DateTime.Today.Day) & String.Format("{0:D2}", Na) & ".TXT"
        While File.Exists(N_Arquivo)
            Na += 1
            N_Arquivo = Dir & "\REM" & String.Format("{0:D4}", DateTime.Today.Year) & String.Format("{0:D2}", DateTime.Today.Month) & String.Format("{0:D2}", DateTime.Today.Day) & String.Format("{0:D2}", Na) & ".TXT"
        End While
        Dim Arq As New StreamWriter(N_Arquivo)
        Dim Linha As String = bancos.HeaderArquivo(CodBanco, CodEmitente, Arquivo)
        If Linha <> "" Then
            Arq.WriteLine(Linha)
        End If
        Linha = bancos.HeaderLote(CodBanco, CodEmitente, Arquivo)
        If Linha <> "" Then
            Arq.WriteLine(Linha)
        End If
        Dim Seq As Int32 = 0
        Dim Tot As Decimal = 0
        For I As Integer = 0 To Remessa.Rows.Count - 1
            Seq += 1
            Linha = bancos.Detalhe1(CodBanco, CodEmitente, Remessa.Rows(I)("NossoNumero").ToString(), Remessa.Rows(I)("N_Documento").ToString(), Convert.ToDateTime(Remessa.Rows(I)("Vencimento")), Convert.ToDecimal(Remessa.Rows(I)("Valor")),
             Convert.ToDateTime(Remessa.Rows(I)("Emissao")), Convert.ToDecimal(Remessa.Rows(I)("Juros")), Seq, Convert.ToInt32(Remessa.Rows(I)("Cliente")))
            Tot += Convert.ToDecimal(Remessa.Rows(I)("Valor"))
            If Linha <> "" Then
                Arq.WriteLine(Linha)
            Else
                Seq -= 1
            End If
            Seq += 1
            Linha = bancos.Detalhe2(CodBanco, Seq, Convert.ToInt32(Remessa.Rows(I)("Cliente")))
            If Linha <> "" Then
                Arq.WriteLine(Linha)
            Else
                Seq -= 1
            End If
        Next
        Seq += 1
        Linha = bancos.TrailerLote(CodBanco, Seq, Seq - 1, Tot)
        Arq.WriteLine(Linha)
        Seq += 1
        Linha = bancos.TrailerArquivo(CodBanco, Seq)
        Arq.WriteLine(Linha)
        Arq.Close()
        MessageBox.Show("Fim da Gera��o")
        Close()
    End Sub

    Private Sub CaixaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaixaToolStripMenuItem1.Click
        abreCaixa()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim fc As New frmCliente_Old
        fc.Show()
    End Sub

    Private Sub AndamentosOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AndamentosOSToolStripMenuItem.Click
        Dim f As New frmAndamentosOS
        f.Show()
    End Sub

    Private Sub SaldosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldosToolStripMenuItem.Click
        Dim f As New frmSaldos
        f.Show()
    End Sub

    Private Sub AvisoOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvisoOSToolStripMenuItem.Click
        aviso_OS()
    End Sub

    Private Sub Saldos�ticaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Saldos�ticaToolStripMenuItem.Click
        giro_otica()
    End Sub

    Private Sub CancelamentoDeOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelamentoDeOSToolStripMenuItem.Click
        Dim f As New frmCancelaOS
        f.Show()
    End Sub

    Private Sub ResumoNfePer�odoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumoNfePer�odoToolStripMenuItem.Click
        Dim fp As New frmDataPeriodo
        Dim ini, fim As Date
        Dim fat As New objFatura
        Dim fr As New frmRpt
        Dim r As New rptResumoNfePeriodo
        fp.ShowDialog(Me)
        ini = fp.dtIni.Value.ToString("dd/MM/yyyy") & " 00:00:00"
        fim = fp.dtFim.Value.ToString("dd/MM/yyyy") & " 23:59:59"
        r.titulo = "NFe emitidas entre " & fp.dtIni.Value.ToString("dd/MM/yyyy") &
        " e " & fp.dtFim.Value.ToString("dd/MM/yyyy")
        r.DataSource = fat.resumo_nfe_periodo(ini, fim)
        fr.Relat(r)
        fr.ShowDialog()
    End Sub


    Private Sub ImportarOSLabonorteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarOSLabonorteToolStripMenuItem.Click
        Dim wsOtica As New anamaria.Service
        Dim dsOS As New DataSet
        Dim ds As New DataSet
        Dim dsTrat As New DataSet
        Dim filial, os As Integer
        Dim dt As String
        Try
            filial = InputBox("Digite o N� da Filial Ana Maria:")
            os = InputBox("Digite o n�mero da OS da Ana Maria")
            '    ds = wsOtica.os_Out_labo(os, filial)
            ds = os_Out_labo(os, filial)
            If ds.Tables.Count = 0 Or ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("OS n�o existe no servidor principal.", "INFORMA��O", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            dt = ds.Tables(0).Rows(0)("data_verificacao")
            If IsDate(dt) = False Then
                AVISO("OS n�o verificada!", Me, frmAviso.tipo_aviso.tipo_ok)
                Exit Sub
            End If
            MessageBox.Show(os_in_trans(ds), "INFORMA��O", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Function os_in_trans(ByVal ds As DataSet) As String
        Dim tbTrat As New DataTable
        Dim tbOs As New DataTable
        Dim tt As New DataTable
        Dim Trans As New objSqlTrans
        Dim i, m As Integer
        Dim resp As String
        Dim r As DataRow
        Dim os As New ObjOS(d, 1, "")
        Dim anda As New objAndamentos(d)
        Dim es As String
        Dim esf, cil As Double
        Dim ltab As New objTabela(d)
        Dim ordem As Integer = 1
        Dim andamentos As New objAndamentos
        Dim pedido As New objPedidoBalcao(d)

        os = New ObjOS()
        tbOs = ds.Tables(0)
        If ds.Tables.Count = 2 Then
            tbTrat = ds.Tables(1)
        ElseIf ds.Tables.Count = 3 Then
            tbTrat = ds.Tables(2)
        End If
        r = tbOs.Rows(0)
        os.filtra_os_cliente(r("id_filial"), r("cod_os"))
        If os.max = 0 Then
            os.novo()
        Else
            If os.andamentos_os.Rows.Count = 0 Then
                Dim sql As String
                Dim rs As String
                sql = "Delete from tratamentos_os where cod_os = " &
                os.cod_os & " and id_filial = " & os.id_filial & ""
                d.Comando(sql, True)
                sql = "Delete from os where cod_os = " & os.cod_os &
                " and id_filial = " & os.id_filial & ""
                rs = d.Comando(sql, True)
                If rs.StartsWith("OK") Then
                    os.novo()
                    GoTo Insere_os
                Else
                    Return rs
                    Exit Function
                End If
            End If
            Return "OS j� existe!"
            Exit Function
        End If
Insere_os:
        'Try
        os.id_filial = arq.Filial
        os.cod_tab_od = rdNum(r("cod_tab_od"))
        os.cod_tab_oe = rdNum(r("cod_tab_oe"))
        os.cod_produto_od = r("cod_produto_od")
        os.cod_produto_oe = r("cod_produto_oe")

        os.esf_od_longe = rdNum(r("esf_od_longe"))
        os.cil_od_longe = rdNum(r("cil_od_longe"))
        os.esf_od_perto = rdNum(r("esf_od_perto"))
        os.cil_od_perto = rdNum(r("cil_od_perto"))
        os.dnp_od_longe = rdNum(r("dnp_od_longe"))
        os.dnp_od_perto = rdNum(r("dnp_od_perto"))
        os.base_od = rdNum(r("base_od"))
        os.adicao_od = rdNum(r("adicao_od"))
        os.altura_od = rdNum(r("altura_od"))
        os.diametro_od = rdNum(r("diametro_od"))
        os.eixo_od = rdNum(r("eixo_od"))

        os.esf_oe_longe = rdNum(r("esf_oe_longe"))
        os.cil_oe_longe = rdNum(r("cil_oe_longe"))
        os.esf_oe_perto = rdNum(r("esf_oe_perto"))
        os.cil_oe_perto = rdNum(r("cil_oe_perto"))
        os.dnp_oe_longe = rdNum(r("dnp_oe_longe"))
        os.dnp_oe_perto = rdNum(r("dnp_oe_perto"))
        os.base_oe = rdNum(r("base_oe"))
        os.adicao_oe = rdNum(r("adicao_oe"))
        os.altura_oe = rdNum(r("altura_oe"))
        os.diametro_oe = rdNum(r("diametro_oe"))
        os.eixo_oe = rdNum(r("eixo_oe"))

        os.aro_horizontal = rdNum(r("aro_horizontal"))
        os.aro_vertical = rdNum(r("aro_vertical"))
        os.maior_diametro = rdNum(r("maior_diametro"))
        os.ponte = rdNum(r("ponte"))
        os.cod_tipo_armacao = rdNum(r("cod_tipo_armacao"))
        os.crm_oftalmologista = rdNum(r("crm_oftalmologista"))

        os.cod_filial_cliente = 1
        os.doc_cliente = rdNum(r("cod_os"))
        os.cod_cliente = rdNum(r("id_filial"))
        os.data_venda = rdData(r("data_venda"))
        os.data_previsao_entrega = rdData(r("data_previsao_entrega"))
        os.hora_previsao_entrega = rdTexto(r("hora_previsao_entrega"))
        os.cod_vendedora = 2
        os.observacao = rdTexto(r("observacao"))
        os.nota_serie = rdTexto(r("nota_serie"))
        os.cod_verif_por = 2
        os.data_verificacao = rdData(r("data_verificacao"))
        os.cod_surfacagem = rdNum(r("cod_surfacagem"))
        os.cod_montagem = rdNum(r("cod_montagem"))
        os.confeccao = rdTexto(r("confeccao"))
        os.coloracao = rdNum(r("coloracao"))
        os.cor_coloracao = rdTexto(r("cor_coloracao"))
        os.cod_fase = Fases_os.Transmissao
        os.tipo_receita_OD = rdNum(r("tipo_receita_od"))
        os.tipo_receita_OE = rdNum(r("tipo_receita_oe"))
        os.id_laboratorio = rdNum(r("id_laboratorio")) 'Laboratorio Montagem
        os.cod_lab_surf = rdNum(r("cod_lab_surf"))

        If os.cod_tab_od <> 11060 Then
            es = ltab.ret_especie(os.cod_tab_od)
            If es.Trim = "B" Then
                If os.cod_produto_od <> os.Ret_estoque_bloco(os.cod_tab_od, os.base_od, os.adicao_od, "D") Then
                    os.cod_produto_od = os.Ret_estoque_bloco(os.cod_tab_od, os.base_od, os.adicao_od, "D")
                End If
            Else
                If os.tipo_receita_OD = tipo_Receita.VISAO_simples_longe Then
                    esf = os.esf_od_longe
                    cil = os.cil_od_longe
                Else
                    esf = os.esf_od_perto
                    cil = os.cil_od_perto
                End If
                If os.cod_produto_od <> os.Ret_estoque_lente(os.cod_tab_od, esf, cil) Then
                    os.cod_produto_od = os.Ret_estoque_lente(os.cod_tab_od, esf, cil)
                End If
            End If

        End If
        If os.cod_tab_oe <> 11060 Then
            es = ltab.ret_especie(os.cod_tab_oe)
            If es.Trim = "B" Then
                If os.cod_produto_oe <> os.Ret_estoque_bloco(os.cod_tab_oe, os.base_oe, os.adicao_oe, "E") Then
                    os.cod_produto_oe = os.Ret_estoque_bloco(os.cod_tab_oe, os.base_oe, os.adicao_oe, "E")
                End If
            Else
                If os.tipo_receita_OE = tipo_Receita.VISAO_simples_longe Then
                    esf = os.esf_oe_longe
                    cil = os.cil_oe_longe
                Else
                    esf = os.esf_oe_perto
                    cil = os.cil_oe_perto
                End If
                If os.cod_produto_oe <> os.Ret_estoque_lente(os.cod_tab_oe, esf, cil) Then
                    os.cod_produto_oe = os.Ret_estoque_lente(os.cod_tab_oe, esf, cil)
                End If
            End If
        End If
        os.cod_fase = Fases_os.Verificacao

        Trans.insere_instrucao(os.Salvar_transaction)
        'Catch ex As Exception
        'Return "Erro mroticaservice" & vbCrLf & ex.ToString
        'Exit Function
        'End Try
        Try
            andamentos = New objAndamentos(os.cod_os, os.id_filial, d)
            'Caso a os tenha sido inserida, coloca andamentos de inclusao e verificacao
            Trans.insere_instrucao(andamentos.insere_andamento_trans(objAndamentos.tipo.inclusao_os, os.id_filial, os.cod_os,
            2, "Os em processo de importa��o com SQLTransaction", ordem))
            ordem = ordem + 1
            Trans.insere_instrucao(andamentos.insere_andamento_trans(objAndamentos.tipo.verificacao_os, os.id_filial,
            os.cod_os, 2, "Os em processo de importa��o com SQLTransaction", ordem))
            ordem = ordem + 1
            'Importa os Tratamentos, caso haja algum
            i = 0
            m = tbTrat.Rows.Count

            While i < m
                tt = os.insere_tratamento_trans(tbTrat.Rows(i)("cod_produto"), 3, ordem)
                ordem = ordem + 1
                If tt.Rows.Count > 0 Then
                    For Each rt As DataRow In tt.Rows
                        Trans.insere_instrucao(rt(0).ToString)
                    Next
                End If
                i = i + 1
            End While
        Catch ex As Exception
            Return ex.ToString & vbCrLf & tt.Rows(0)(0).ToString
            Exit Function
        End Try
        resp = d.executa_transaction(Trans.instrucoes, True)
        If resp.StartsWith("OK") Then
            pedido.novo()
            resp = pedido.novo_pedido_otica(os)
        End If
        Return resp
    End Function
    Private Sub AndamentosUtilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AndamentosUtilToolStripMenuItem.Click
        Dim f As New frmAndamentosUtil
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub PedidoProdu��oToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidoProdu��oToolStripMenuItem.Click
        Dim f As New frmPedidoProducao
        Dim r As Integer
        r = MsgBox("Novo Pedido?", MsgBoxStyle.YesNo)
        If r = vbYes Then
            f.origem = "novo"
        Else

            Dim fa As New frmAbrePedidoProducao
            Try
                fa.ShowDialog(Me)
                f._id_filial = fa.grd.Item(8, fa.grd.CurrentCell.RowIndex).Value
                f._num_pedido = fa.grd.Item(7, fa.grd.CurrentCell.RowIndex).Value
            Catch ex As Exception
                Exit Sub
            End Try

        End If
        f.Show()
    End Sub
    Private Sub PedidoLabonorteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidoLabonorteToolStripMenuItem.Click
        Dim f As New frmPedidoProducao
        Dim r As Integer
        r = MsgBox("Novo Pedido?", MsgBoxStyle.YesNo)
        If r = vbYes Then
            f.origem = "novo"
        Else

            Dim fa As New frmAbrePedidoProducao
            Try
                fa.ShowDialog(Me)
                f._id_filial = fa.grd.Item(8, fa.grd.CurrentCell.RowIndex).Value
                f._num_pedido = fa.grd.Item(7, fa.grd.CurrentCell.RowIndex).Value
            Catch ex As Exception
                Exit Sub
            End Try

        End If
        f.Show()
    End Sub

    Private Sub PlanoDeContasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlanoDeContasToolStripMenuItem.Click
        Dim f As New frmPlanoContas
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub Relat�rioSaldoPre�oCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Relat�rioSaldoPre�oCompraToolStripMenuItem.Click
        Dim f As New frmSaldoPrecoCompra
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub FornecedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedorToolStripMenuItem.Click
        Dim ff As New frmFornecedor
        ff.ShowDialog()
        ff.Dispose()
    End Sub

    Private Sub Usu�riosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Usu�riosToolStripMenuItem.Click
        Dim intAcesso As Integer = UserPermissao.VerificaPermissaoMenu(UserPermissao.CodigoUsuario)
        If intAcesso = 1 Or intAcesso = 5 Then
            Dim f As New frmUsuario
            f.ShowDialog(Me)
            f.Dispose()
        Else
            MessageBox.Show("Usu�rio sem acesso a este m�dulo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub �ViaDeProdutosADevolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EntradaManualNoEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaManualNoEstoqueToolStripMenuItem.Click
        Dim f As New frmEntradaManualEstoque
        f.Show()
    End Sub

    Private Sub Devolu��oParaOEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Devolu��oParaOEstoqueToolStripMenuItem.Click
        Dim f As New frmDevolucaoEstoque
        f.Show()
    End Sub

    Private Sub FamiliaDeLentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FamiliaDeLentesToolStripMenuItem.Click
        Dim f As New frmFamiliaLentes
        f.ShowDialog(Me)
    End Sub

    Private Sub PerfilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmPerfil
        f.ShowDialog(Me)
    End Sub

    Private Sub FaturamentoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaturamentoToolStripMenuItem1.Click
        Dim f As New frmFaturamento
        f.Show()
    End Sub

    Private Sub PerfilToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerfilToolStripMenuItem.Click
        Dim intAcesso As Integer = UserPermissao.VerificaPermissaoMenu(UserPermissao.CodigoUsuario)
        If intAcesso = 1 Or intAcesso = 5 Then
            Dim f As New frmPerfil
            f.ShowDialog()
        Else
            MessageBox.Show("Usu�rio sem acesso a este m�dulo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ProdutosADevolverAoFornecedorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutosADevolverAoFornecedorToolStripMenuItem1.Click
        Dim f As New frmDevolucaoProduto
        f.ShowDialog(Me)
    End Sub

    Private Sub ProdutosEstornadosParaOEstoqueToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutosEstornadosParaOEstoqueToolStripMenuItem1.Click
        Dim f As New frmDevolucaoProdutoEstoque
        f.ShowDialog(Me)
    End Sub

    Private Sub EntradaNotaFiscalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaNotaFiscalToolStripMenuItem.Click
        Dim f As New frmConferenciaNotaRel
        f.Show()
    End Sub

    Private Sub NovoPedidoCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoPedidoCompraToolStripMenuItem.Click
        Dim f As New frmPedidoCompra
        f.acao = pedido_compra_acao.pedido_novo
        f.Show()
    End Sub

    Private Sub AbrirPedidoCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirPedidoCompraToolStripMenuItem.Click
        Dim fp As New frmPedidosFornecedor
        Dim f As New frmPedidoCompra
        fp.ShowDialog(Me)
        f.n_pedido = fp.id_pedido
        f.acao = pedido_compra_acao.pedido_edicao
        f.Show()
    End Sub

    Private Sub ConferirPedidoCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConferirPedidoCompraToolStripMenuItem.Click
        Dim fp As New frmPedidosFornecedor
        Dim f As New frmPedidoCompra
        fp.ShowDialog(Me)
        f.n_pedido = fp.id_pedido
        f.acao = pedido_compra_acao.pedido_Entrada
        f.ShowDialog(Me)
        f.Dispose()
    End Sub
    Private Sub CompraDeLentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompraDeLentesToolStripMenuItem.Click
        Dim f As New frmCompra
        f.NOVO = False
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub AvisoSobreAOS�ticaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvisoSobreAOS�ticaToolStripMenuItem.Click
        Dim f As New frmAvisoOS
        f.labo = False
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub OSPendentePorFornecedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OSPendentePorFornecedorToolStripMenuItem.Click
        Dim rpt As New rptListaEstoqueForncecedor
        Dim rp As New frmRpt
        Dim os As New ObjOS
        Try
            rpt.DataSource = os.lista_pendentes_estoque_otica_e_labonorte_forncecedor
            rp.Relat(rpt)
            rp.ShowDialog(Me)
        Catch ex As Exception
            AVISO(ex.Message, Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End Try
        Exit Sub
    End Sub

    Private Sub OSsPendentePorForneceodr�ticaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OSsPendentePorForneceodr�ticaToolStripMenuItem.Click
        Dim rpt As New rptListaEstoqueForncecedor
        Dim rp As New frmRpt
        Dim os As New ObjOS
        Dim tbOS As New DataTable
        Dim tbOSLista As New DataTable
        Dim i As Integer
        Try
            ''
            Dim strSQLVerifca As String = "select verifica_lista_ana_duplicada from controle"
            Dim tbVerifica As New DataTable
            tbVerifica = acesso.retornaRegistro(strSQLVerifca).Tables(0)
            'Verifica se a data atual � maior que a �ltima data verificada na tabela controle em caso positivo
            'a rotina seguinte � executada e tira da listagem todas as OS que j� forma dadas baixas e duplicaram da Ana Maria
            If d.pdtm(Now()) > d.pdtm(tbVerifica.Rows(0)("verifica_lista_ana_duplicada")) Then

                'Retorna a listagem das OS a serem baixadas
                Dim strSQL As String = "SELECT OS.cod_os, OS.id_filial, os.num_pedido,  OS.cod_cliente, OS.doc_cliente, " &
                    "(Select top(1) andamentos.data from andamentos where cod_os = os.cod_os and id_filial = os.id_filial) as data_importacao, " &
                    "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) AS OD, " &
                    "(SELECT nome_comercial FROM lentes_tabela wHERE (cod_tabela = OS.cod_tab_oe)) AS OE, fases_OS.fase, " &
                    "cliente.nome_cliente FROM fabricante INNER JOIN lentes_tabela ON fabricante.id_fabricante = lentes_tabela.id_fabricante " &
                    "FULL OUTER JOIN OS INNER JOIN fases_OS ON OS.cod_fase = fases_OS.cod_fase INNER JOIN cliente ON " &
                    "OS.cod_filial_cliente = cliente.cod_filial_cliente AND OS.cod_cliente = cliente.cod_cliente ON " &
                    "lentes_tabela.cod_tabela = OS.cod_tab_od AND lentes_tabela.cod_tabela = OS.cod_tab_oe WHERE ((OS.cod_fase = 2) OR " &
                    "(OS.cod_fase = 3) OR (OS.cod_fase = 5)  OR (OS.cod_fase = 20)) and (os.cod_cliente < 1000) " &
                    "and ((os.cod_tab_od + os.cod_tab_oe) > 5) and not os.num_pedido is null and not doc_cliente is null ORDER BY fabricante.fabricante, " &
                    "OD,OE, OS.base_od, OS.adicao_od, OS.base_oe, OS.adicao_oe, OS. esf_od_longe, os.cil_od_longe, os.esf_od_perto, " &
                    "os.cil_od_perto, os.esf_oe_longe, os.cil_oe_longe, os.esf_oe_perto, os.cil_oe_perto, os.data_verificacao, os.cod_cliente," &
                    "os.doc_cliente"
                tbOSLista = acesso.retornaRegistro(strSQL).Tables(0)

                If tbOSLista.Rows.Count > 0 Then
                    For i = 0 To tbOSLista.Rows.Count - 1
                        'Retorna todas as OS da Ana Maria j� baixadas
                        Dim strSQLOS As String = "select os.id_filial, os.cod_os, os.num_pedido, os.cod_cliente, os.doc_cliente," &
                            "pedido_balcao.cod_status_pedido from OS inner join pedido_balcao on os.num_pedido = pedido_balcao.num_pedido and " &
                            "os.cod_cliente = pedido_balcao.cod_cliente where os.cod_cliente = " & tbOSLista.Rows(i)("cod_cliente") &
                            " And os.doc_cliente = " & tbOSLista.Rows(i)("doc_cliente") & " And pedido_balcao.cod_status_pedido = 2 order by cod_cliente"
                        tbOS = acesso.retornaRegistro(strSQLOS).Tables(0)

                        If tbOS.Rows.Count > 0 Then
                            Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
                            Dim strObservacao As String = "OS Duplicada da Ana Maria"
                            Dim intStatusAndamento As Int16 = 1
                            Dim intCodAndamento As Integer = 221
                            Dim strSQLFaseOS As String = "cod_fase = 24 where cod_os = " & tbOSLista.Rows(i)("cod_os") & " and id_filial = " & tbOSLista.Rows(i)("id_filial") &
                                " and cod_cliente = " & tbOSLista.Rows(i)("cod_cliente") & " and doc_cliente = " & tbOSLista.Rows(i)("doc_cliente")
                            acesso.atualiza_registros("OS", strSQLFaseOS, True)
                            Dim intOrdem As Integer = acesso.retornaUltimoRegistro("andamentos", "ordem", "where cod_os = " & tbOSLista.Rows(i)("cod_os") & " and id_filial = " & tbOSLista.Rows(i)("id_filial"))
                            Dim strSQLAndamento As String = "Insert Into Andamentos Values(" & tbOSLista.Rows(i)("id_filial") & "," &
                                tbOSLista.Rows(i)("cod_os") & "," & arq.Filial & "," & intOrdem & "," &
                                d.pdtm(Now()) & "," & intCodAndamento & "," & intUsuario & "," & intStatusAndamento & "," & d.PStr(strObservacao) & ")"
                            acesso.grava_registros(strSQLAndamento, True)
                        End If
                    Next
                End If

                'Acrescenta um dia a proxima data de verifica��o para a execu�� da rotina anterior
                Dim proximasinc As DateTime = DateAdd(DateInterval.Day, 1, tbVerifica.Rows(0)("verifica_lista_ana_duplicada")).ToShortDateString & " 08:00:00"
                Dim strSQLAtualizaData As String = "verifica_lista_ana_duplicada = " & d.pdtm(proximasinc)
                acesso.atualiza_registros("Controle", strSQLAtualizaData, False)
            End If

            If arq.Filial = 2 Then
                rpt.DataSource = os.lista_pendentes_estoque_otica_forncecedor("15,26")
            Else
                Dim strSQLFor As String = "Select filiais_ana_macapa from controle"
                Dim tbFornecedor As New DataTable
                tbFornecedor = acesso.retornaRegistro(strSQLFor).Tables(0)
                rpt.DataSource = os.lista_pendentes_estoque_otica_forncecedor(True, tbFornecedor.Rows(0)("filiais_ana_macapa"))
            End If

            rp.Relat(rpt)
            rp.ShowDialog(Me)
        Catch ex As Exception
            AVISO(ex.Message, Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End Try
        Exit Sub
    End Sub

    Private Sub OSsPendentesPorFornLabonorteecedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OSsPendentesPorFornLabonorteecedorToolStripMenuItem.Click
        Dim rpt As New rptListaEstoqueForncecedor
        Dim rp As New frmRpt
        Dim os As New ObjOS
        Try
            rpt.DataSource = os.lista_pendentes_estoque_labonorte_forncecedor
            rp.Relat(rpt)
            rp.ShowDialog(Me)
        Catch ex As Exception
            AVISO(ex.Message, Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End Try
        Exit Sub
    End Sub

    Private Sub SaldoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldoToolStripMenuItem.Click
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        If acesso.verifica_permissao_usuario(intUsuario, 46) = True Then
            Dim f As New frmSaldos
            f.ShowDialog(Me)
        Else
            MessageBox.Show("Usu�rio sem permiss�o para acessar este m�dulo.", "ERROR: 46", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub GiroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GiroToolStripMenuItem.Click
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        If acesso.verifica_permissao_usuario(intUsuario, 46) = True Then
            Dim f As New frmGiro
            f.Show()
        Else
            MessageBox.Show("Usu�rio sem permiss�o para acessar este m�dulo.", "ERROR: 46", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ConsultarOSsPNomeDoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarOSsPNomeDoClienteToolStripMenuItem.Click
        Dim f As New frmConsultaOSNomeCliente
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub AvisoSobreAOSsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvisoSobreAOSsToolStripMenuItem.Click
        aviso_OS()
    End Sub

    Private Sub PararOSTemporariamenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PararOSTemporariamenteToolStripMenuItem.Click
        Dim anda As New objAndamentos
        Dim ios, ifilial As Integer
        Dim obs As String
        Dim os As New ObjOS
        Dim us As New objUsuario
        'If us.login(Me).ToString.StartsWith("OK") Then
        '16 Pausa OS no estoque
        If us.acesso(16) = False Then
            AVISO("Usu�rio n�o tem acesso a Esse Procedimento!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            Exit Sub
        Else
            ifilial = InputBox("Digite o c�digo da loja:")
            ios = InputBox("Digite o c�digo da OS:")
            obs = InputBox("Digite o motivo da Paraliza��o:")
            os = New ObjOS(ios, ifilial, "")
            MsgBox(anda.insere_andamento(objAndamentos.tipo.Pausa_os_estoque, os.id_filial, os.cod_os, us.cod_usuario, obs))
            os.editar()
            os.cod_fase = Fases_os.Pausa_estoque
            os.Salvar()
        End If

        'End If
    End Sub

    Private Sub ReativarOSParadaNoEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReativarOSParadaNoEstoqueToolStripMenuItem.Click
        Dim anda As New objAndamentos
        Dim ios, ifilial As Integer
        Dim obs As String
        Dim os As New ObjOS
        Dim us As New objUsuario
        'If us.login(Me).ToString.StartsWith("OK") Then
        '17 Reativar OS Parada no estoque
        If us.acesso(17) = False Then
            AVISO("Usu�rio n�o tem acesso a Esse Procedimento!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            Exit Sub
        Else
            ifilial = InputBox("Digite o c�digo da loja:")
            ios = InputBox("Digite o c�digo da OS:")
            obs = InputBox("Digite o motivo da Rativa��o:")
            os = New ObjOS(ios, ifilial, "")
            MsgBox(anda.insere_andamento(objAndamentos.tipo.aviso_os, os.id_filial, os.cod_os, us.cod_usuario, obs))
            os.editar()
            os.cod_fase = Fases_os.Estoque_Aguardando_Processamento
            os.Salvar()
        End If

        'End If
    End Sub

    Private Sub EnviarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarToolStripMenuItem.Click
        Dim f As New frmContfora()
        Dim r As frmAviso.respo
        Dim fil, nOs As Integer
        r = AVISO("Essa OS � da �tica?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
        If r = frmAviso.respo.SIM Then
            fil = InputBox("Informe a Filial:")
            nOs = InputBox("Informe a OS:")
            Dim os As New ObjOS(nOs, fil, "")
            nOs = os.cod_os
            fil = os.id_filial
        Else
            fil = InputBox("Informe a Filial:")
            nOs = InputBox("Informe a OS da Labonorte:")
        End If
        f.novo = True
        f.x_id_filial = fil
        f.x_os = nOs
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub RetornoOSFeitaForaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetornoOSFeitaForaToolStripMenuItem.Click
        Dim f As New frmContfora
        Dim r As frmAviso.respo
        Dim fil, nOs As Integer
        Try
            r = AVISO("Essa OS � da �tica?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
            If r = frmAviso.respo.SIM Then
                fil = InputBox("Informe a Filial:")
                nOs = InputBox("Informe a OS:")
                Dim os As New ObjOS(nOs, fil, "")
                nOs = os.cod_os
                fil = os.id_filial
            Else
                fil = InputBox("Informe a Filial:")
                nOs = InputBox("Informe a OS da Labonorte:")
            End If
            f.novo = False
            f.x_id_filial = fil
            f.x_os = nOs
            f.ShowDialog(Me)
            f.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OSPedidasPendentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OSPedidasPendentesToolStripMenuItem.Click
        Dim rpt As New rptListaEstoqueForncecedor
        Dim rp As New frmRpt
        Dim os As New ObjOS
        Try
            rpt.DataSource = os.pedidos_aguardando_lente
            rp.Relat(rpt)
            rp.ShowDialog(Me)
        Catch ex As Exception
            AVISO(ex.Message, Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End Try
        Exit Sub
    End Sub


    Private Sub OSsPendentesDataVerifica��oToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OSsPendentesDataVerifica��oToolStripMenuItem.Click
        Dim rpt As New rptListaEstoqueForncecedor
        Dim rp As New frmRpt
        Dim os As New ObjOS
        Dim fd As New frmData
        Dim d As Date
        Try
            fd.ShowDialog(Me)
            d = fd.dtIni.Value.Date & " 23:59:59"
            rpt.titulo = " Verificadas do dia " & d.Date & " para tr�s."
            rpt.DataSource = os.lista_pendentes_estoque_otica_forncecedor_verificacao(d)
            rp.Relat(rpt)
            rp.ShowDialog(Me)
        Catch ex As Exception
            AVISO(ex.Message, Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End Try
        Exit Sub

    End Sub

    Private Sub TrocaBaseEstoqueToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        If acesso.verifica_permissao_usuario(intUsuario, 14) = True Then
            Dim f As New frmTrocaBase
            f.ShowDialog(Me)
            f.Dispose()
        Else
            MessageBox.Show("Usu�rio sem permiss�o para acessar este m�dulo.", "ERROR: 14", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Sa�daOSLaborat�rioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sa�daOSLaborat�rioToolStripMenuItem.Click
        Dim f As New frmSaidaOsLaboratorio
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub TrocaProdutoOSLabonorteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrocaProdutoOSLabonorteToolStripMenuItem.Click
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        If acesso.verifica_permissao_usuario(intUsuario, 47) = True Then
            Try
                Dim fr As New frmOS
                fr.novo = False
                fr.Filial = InputBox("Digite o N� da Filial:")
                fr.n_OS = InputBox("Digite o N� da OS:")

                Dim strSQLPedido As String = "Select num_pedido, id_filial from os where cod_os = " & fr.n_OS & " and id_filial = " & fr.Filial
                Dim ttPedido As New DataTable
                ttPedido = acesso.retornaRegistro(strSQLPedido).Tables(0)

                If ttPedido.Rows.Count > 0 Then
                    If ttPedido.Rows(0)("num_pedido") IsNot DBNull.Value Then
                        Dim strSQLStatusPed As String = "select pedido_balcao.cod_status_pedido, os.cod_cliente from pedido_balcao inner join OS " &
                            "on pedido_balcao.num_pedido = os.num_pedido and pedido_balcao.id_filial = os.id_filial " &
                            "where pedido_balcao.num_pedido = " & ttPedido.Rows(0)("num_pedido") & " And pedido_balcao.id_filial = " & ttPedido.Rows(0)("id_filial")
                        Dim ttStatusPedido As New DataTable
                        ttStatusPedido = acesso.retornaRegistro(strSQLStatusPed).Tables(0)

                        If (ttStatusPedido.Rows(0)("cod_status_pedido") = 2) And (ttStatusPedido.Rows(0)("cod_cliente") > 1000) Then
                            Dim strSQLTroca As String = "Select cod_troca_prod From Troca_Produto where cod_os = " & fr.n_OS & " and id_filial = " & fr.Filial & " and concluido = 'N'"
                            Dim tbTroca As New DataTable
                            tbTroca = acesso.retornaRegistro(strSQLTroca).Tables(0)
                            Dim strMesnagem As String = ""
                            If tbTroca.Rows.Count = 0 Then
                                strMesnagem = "Esta OS j� foi baixada pelo estoque, n�o pode ser mais alterada." & Chr(13) & "Solicite uma troca de produto para altera��o da OS."
                            Else
                                strMesnagem = "Existe uma solicita��o de troca de produto para a OS informada." & Chr(13) & "N� da Troca: " & tbTroca.Rows(0)("cod_troca_prod")
                            End If
                            MessageBox.Show(strMesnagem, "INFORMA��O", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                        fr.otica = False
                        fr.tipo_acao = frmOS.ACAO.TROCA_PRODUTO
                        fr.ShowDialog(Me)
                    End If
                Else
                    MessageBox.Show("N�o foi poss�vel localizar a OS informada.", "INFORMA��O", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Usu�rio sem permiss�o para acessar este m�dulo.", "ERROR: 47", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BaixaOSLabonorteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaixaOSLabonorteToolStripMenuItem.Click
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        If acesso.verifica_permissao_usuario(intUsuario, 44) = True Then
            Dim f As New frmBaixaOS
            Dim tt As New DataTable
            Dim ttPedido As New DataTable
            Dim intOS As Integer = InputBox("Digite o N� da OS.")
            Dim intFilial As Integer = InputBox("Digite o N� da Filial.", "", arq.Filial.ToString)
            Try
                Dim strSQLPedido As String = "select num_pedido from os where cod_os = " & intOS & " and id_filial = " & intFilial
                ttPedido = acesso.retornaRegistro(strSQLPedido).Tables(0)

                If ttPedido.Rows.Count > 0 Then
                    Dim strSQL As String = "select pedido_balcao.cod_status_pedido,pedido_balcao.forma,cliente.tipo_compra from pedido_balcao inner join cliente " &
                    "on pedido_balcao.cod_cliente = cliente.cod_cliente and pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente " &
                    "where pedido_balcao.num_pedido = " & CInt(ttPedido.Rows(0)("num_pedido").ToString) & " and pedido_balcao.id_filial = " & intFilial
                    d.carrega_Tabela(strSQL, tt)

                    Dim strSQLPedFat As String = "select * from fatura_itens where num_pedido = " & CInt(ttPedido.Rows(0)("num_pedido").ToString) & " and id_filial = " & intFilial

                    If tt.Rows(0)("forma") = 0 Then
                        MessageBox.Show("OS n�o pode ser baixada, devido a vendedor(a) n�o ter" & Chr(13) & "informado a forma de pagamento na hora da venda.", "INFORMA��O", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    If (tt.Rows(0)("forma") = 1) And (acesso.verifica_existencia_registro(strSQLPedFat) = False) Then
                        MessageBox.Show("OS com forma de pagamento a vista." & Chr(13) & "Precisar ser faturado no caixa para libera��o.", "INFORMA��O", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    f.carrega_os(intOS, intFilial)
                    f.ShowDialog(Me)
                    f.Dispose()
                Else
                    MessageBox.Show("N�o existe pedido vinculado a esta OS informada.", "INFORMA��O", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Usu�rio sem permiss�o para acessar este m�dulo.", "ERROR: 44", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BaixaOS�ticaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaixaOS�ticaToolStripMenuItem.Click
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        If acesso.verifica_permissao_usuario(intUsuario, 44) = True Then
            Dim f As New frmBaixaOS
            Dim os As New ObjOS
            Dim xfilial, xos As Integer
            Try
                xfilial = InputBox("Digite o N� da Filial.")
                xos = InputBox("Digite o N� da OS.")
                os = New ObjOS(xos, xfilial, "")
                f.carrega_os(os.cod_os, os.id_filial)
                f.ShowDialog(Me)
                f.Dispose()
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Usu�rio sem permiss�o para acessar este m�dulo.", "ERROR: 44", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub LentesEBlocosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LentesEBlocosToolStripMenuItem.Click
        Dim f As New frmLentes_blocos
        f.Show(Me)
    End Sub

    Private Sub TabelaDeLentesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabelaDeLentesToolStripMenuItem2.Click
        Dim f As New frmLentes_tabela
        f.Show(Me)
    End Sub

    Private Sub Saldo�ticaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Saldo�ticaToolStripMenuItem.Click
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        If acesso.verifica_permissao_usuario(intUsuario, 46) = True Then
            giro_otica()
        Else
            MessageBox.Show("Usu�rio sem permiss�o para acessar este m�dulo.", "ERROR: 46", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Servi�osToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Servi�osToolStripMenuItem.Click
        Dim intAcesso As Integer = UserPermissao.VerificaPermissaoMenu(UserPermissao.CodigoUsuario)
        If intAcesso = 1 Or intAcesso = 5 Then
            Dim f As New frmServicos
            f.ShowDialog(Me)
            f.Dispose()
        Else
            MessageBox.Show("Usu�rio sem acesso a este m�dulo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub AndamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AndamentosToolStripMenuItem.Click
        Dim f As New frmAndamentosOS
        f.Show()
    End Sub

    Private Sub Andamentos�ticaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Andamentos�ticaToolStripMenuItem.Click
        Dim f As New frmAndamentosOSOtica
        f.Show()
    End Sub

    Private Sub Confer�nciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Confer�nciaToolStripMenuItem.Click
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        If acesso.verifica_permissao_usuario(intUsuario, 46) = True Then
            Dim f As New frmConferenciaLentes
            f.ShowDialog(Me)
            f.Dispose()
        Else
            MessageBox.Show("Usu�rio sem permiss�o para acessar este m�dulo.", "ERROR: 46", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BaixaPedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaixaPedidoToolStripMenuItem.Click
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        Dim intPedido As String = ""
        Dim tt As New DataTable
        Dim ttTipo As New DataTable

        If acesso.verifica_permissao_usuario(intUsuario, 44) = True Then
            Dim f As New frmBaixaPedido
            Try
                intPedido = InputBox("Digite o N� do Pedido.")
                If intPedido <> String.Empty Then
                    Dim strSQL As String = "select pedido_balcao.cod_status_pedido,pedido_balcao.forma,cliente.tipo_compra from pedido_balcao inner join cliente " &
                    "on pedido_balcao.cod_cliente = cliente.cod_cliente and pedido_balcao.cod_filial_cliente = cliente.cod_filial_cliente " &
                    "where pedido_balcao.num_pedido = " & intPedido & " and pedido_balcao.id_filial = " & arq.Filial
                    d.carrega_Tabela(strSQL, tt)

                    Dim strSQLPedFat As String = "select * from fatura_itens where num_pedido = " & intPedido & " and id_filial = " & arq.Filial

                    If tt.Rows(0)("forma") = 0 Then
                        MessageBox.Show("Pedido n�o pode ser baixado, devido a vendedor(a) n�o ter" & Chr(13) & "informado a forma de pagamento na hora da venda.", "INFORMA��O", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    If (tt.Rows(0)("forma") = 1) And (acesso.verifica_existencia_registro(strSQLPedFat) = False) Then
                        MessageBox.Show("Pedido com forma de pagamento a vista." & Chr(13) & "Precisar ser faturado no caixa para libera��o.", "INFORMA��O", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    f.carrega_pedido(intPedido, arq.Filial)
                    f.ShowDialog(Me)

                Else
                    MessageBox.Show("Digite somente valor n�merico.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                f.Dispose()
                Exit Sub
            End Try
            f.Dispose()
        Else
            MessageBox.Show("Usu�rio sem permiss�o para acessar este m�dulo.", "ERROR: 44", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Impress�oDeOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Impress�oDeOSToolStripMenuItem.Click
        Dim sql As String
        Dim tb As New DataTable
        Dim r As New rptOS
        Dim f As New frmRpt
        sql = "Select os.*, (select nome_comercial from lentes_tabela where cod_tabela = os.cod_tab_od) as TAB_OD, " &
        "(select nome_comercial from lentes_tabela where cod_tabela = os.cod_tab_oe) as TAB_OE, " &
        "(select produto from produtos where cod_produto = os.cod_produto_od) as EST_OD," &
        "(select produto from produtos where cod_produto = os.cod_produto_oe) as EST_OE, " &
        "(select produto from produtos where cod_produto = os.cod_montagem) as Armacao, " &
        "Cliente.NOME_CLIENTE,fila_impressao_os.via,fila_impressao_os.extra, " &
        "fila_impressao_os.filial_impressao " &
        "FROM OS INNER JOIN " &
        "Cliente ON OS.cod_filial_cliente = Cliente.cod_filial_cliente " &
        "AND OS.cod_cliente = Cliente.cod_cliente " &
        "INNER JOIN FILA_IMPRESSAO_OS ON OS.id_filial = FILA_IMPRESSAO_OS.ID_FILIAL " &
        "and OS.cod_os = fila_impressao_os.cod_os " &
        "where fila_impressao_os.data_impressao is null and fila_impressao_os.filial_impressao = " & arq.Filial &
        " order by fila_impressao_os.data_inclusao"
        d.carrega_Tabela(sql, tb)
        r.Fila = True
        If tb.Rows.Count = 0 Then
            AVISO("N�o h� OS's aguardando na fila de impress�o!", Me, frmAviso.tipo_aviso.tipo_ok)
            tb.Dispose()
            r.Dispose()
            f.Dispose()
            Exit Sub
        End If
        r.DataSource = tb
        f.Relat(r)
        f.ShowDialog(Me)
    End Sub

    Private Sub EtiquetaUsu�rioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtiquetaUsu�rioToolStripMenuItem.Click
        Dim f As New frmCodBarraUsuarios
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub EtiquetaAndamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtiquetaAndamentosToolStripMenuItem.Click
        Dim f As New frmCodBarraAndamentos
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub btnCaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaixa.Click
        abreCaixa()
    End Sub

    Private Sub btnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.Click
        Dim fc As New frmCliente
        fc.Show()
    End Sub

    Private Sub AcessoMenu()

        Dim intAcesso As Integer = UserPermissao.VerificaPermissaoMenu(UserPermissao.CodigoUsuario)
        Select Case intAcesso
            Case 1 'Acesso 1 grupo desenvolvimento
                CadastroToolStripMenuItem.Visible = True
                GerencialToolStripMenuItem.Visible = True
                BalcaoToolStripMenuItem.Visible = True
                EstoqueToolStripMenuItem.Visible = True
                CaixaToolStripMenuItem.Visible = True
                UtilitariosToolStripMenuItem.Visible = True
                TrocarSenhaToolStripMenuItem.Visible = True
                FinanceiroToolStripMenuItem1.Visible = True
                ComercialToolStripMenuItem.Visible = True
                NotaFiscalEletronicaToolStripMenuItem.Visible = True
                mmGeral.Visible = True

            Case 2 'Acesso 2 grupo Balcao
                CadastroToolStripMenuItem.Visible = False
                GerencialToolStripMenuItem.Visible = False
                BalcaoToolStripMenuItem.Visible = True
                EstoqueToolStripMenuItem.Visible = False
                CaixaToolStripMenuItem.Visible = False
                UtilitariosToolStripMenuItem.Visible = True
                TrocarSenhaToolStripMenuItem.Visible = True
                FinanceiroToolStripMenuItem1.Visible = False
                mmGeral.Visible = True
                ToolStripSeparator2.Visible = False
                btnPedido.Visible = False
                ToolStripSeparator3.Visible = True
                btnOS.Visible = True
                ToolStripSeparator4.Visible = True
                btnMovimento.Visible = True
                ToolStripSeparator5.Visible = False
                btnBaixaOsPedido.Visible = False
                ToolStripSeparator6.Visible = False
                btnTrocaProduto.Visible = False
                ToolStripSeparator7.Visible = False
                btnSaidaExtra.Visible = False
                ToolStripSeparator8.Visible = True
                btnAndamentos.Visible = True
                ToolStripSeparator1.Visible = False
                btnCaixa.Visible = False
                GiroToolStripMenuItem.Visible = False
                Confer�nciaToolStripMenuItem.Visible = False
                AvisoSobreAOS�ticaToolStripMenuItem.Visible = False
                OSPendentePorFornecedorToolStripMenuItem.Visible = False
                OSsPendentePorForneceodr�ticaToolStripMenuItem.Visible = False
                OSsPendentesPorFornLabonorteecedorToolStripMenuItem.Visible = False
                ConsultarOSsPNomeDoClienteToolStripMenuItem.Visible = True
                PararOSTemporariamenteToolStripMenuItem.Visible = False
                ReativarOSParadaNoEstoqueToolStripMenuItem.Visible = False
                EnviarToolStripMenuItem.Visible = False
                RetornoOSFeitaForaToolStripMenuItem.Visible = False
                OSPedidasPendentesToolStripMenuItem.Visible = False
                OSsPendentesDataVerifica��oToolStripMenuItem.Visible = False
                Sa�daOSLaborat�rioToolStripMenuItem.Visible = False
                Impress�oDeOSToolStripMenuItem.Visible = False
                ComercialToolStripMenuItem.Visible = False
                NotaFiscalEletronicaToolStripMenuItem1.Visible = False
            Case 3 'Acesso 3 grupo Estoque
                CadastroToolStripMenuItem.Visible = True
                GerencialToolStripMenuItem.Visible = False
                BalcaoToolStripMenuItem.Visible = True
                EstoqueToolStripMenuItem.Visible = True
                CaixaToolStripMenuItem.Visible = False
                UtilitariosToolStripMenuItem.Visible = True
                TrocarSenhaToolStripMenuItem.Visible = True
                FinanceiroToolStripMenuItem1.Visible = False
                mmGeral.Visible = True
                btnCaixa.Visible = False
                ToolStripSeparator1.Visible = False
                btnCliente.Visible = False
                ComercialToolStripMenuItem.Visible = False
                NotaFiscalEletronicaToolStripMenuItem1.Visible = False
            Case 4 'Acesso grupo Laborat�rio
                CadastroToolStripMenuItem.Visible = False
                GerencialToolStripMenuItem.Visible = False
                BalcaoToolStripMenuItem.Visible = True
                EstoqueToolStripMenuItem.Visible = False
                CaixaToolStripMenuItem.Visible = False
                UtilitariosToolStripMenuItem.Visible = True
                TrocarSenhaToolStripMenuItem.Visible = True
                FinanceiroToolStripMenuItem1.Visible = False
                mmGeral.Visible = True
                btnPedido.Visible = False
                btnMovimento.Visible = False
                btnBaixaOsPedido.Visible = False
                btnTrocaProduto.Visible = False
                btnSaidaExtra.Visible = False
                btnAndamentos.Visible = False
                btnCaixa.Visible = False
                AvisoSobreAOS�ticaToolStripMenuItem.Visible = False
                OSPendentePorFornecedorToolStripMenuItem.Visible = False
                OSsPendentePorForneceodr�ticaToolStripMenuItem.Visible = False
                OSsPendentesPorFornLabonorteecedorToolStripMenuItem.Visible = False
                AvisoSobreAOSsToolStripMenuItem.Visible = False
                PararOSTemporariamenteToolStripMenuItem.Visible = False
                ReativarOSParadaNoEstoqueToolStripMenuItem.Visible = False
                EnviarToolStripMenuItem.Visible = False
                RetornoOSFeitaForaToolStripMenuItem.Visible = False
                OSsPendentesDataVerifica��oToolStripMenuItem.Visible = False
                OSPedidasPendentesToolStripMenuItem.Visible = False
                OSPedidasPendentesToolStripMenuItem.Visible = False
                Sa�daOSLaborat�rioToolStripMenuItem.Visible = False
                Impress�oDeOSToolStripMenuItem.Visible = False
                btnCliente.Visible = False
                ToolStripSeparator2.Visible = False
                ToolStripSeparator3.Visible = False
                ToolStripSeparator4.Visible = False
                ToolStripSeparator5.Visible = False
                ToolStripSeparator6.Visible = False
                ToolStripSeparator7.Visible = False
                ToolStripSeparator8.Visible = False
                ToolStripSeparator1.Visible = False
                ComercialToolStripMenuItem.Visible = False
                NotaFiscalEletronicaToolStripMenuItem1.Visible = False
            Case 5 'Grupo Gerencia
                CadastroToolStripMenuItem.Visible = True
                GerencialToolStripMenuItem.Visible = True
                BalcaoToolStripMenuItem.Visible = True
                EstoqueToolStripMenuItem.Visible = True
                CaixaToolStripMenuItem.Visible = True
                UtilitariosToolStripMenuItem.Visible = True
                TrocarSenhaToolStripMenuItem.Visible = True
                FinanceiroToolStripMenuItem1.Visible = True
                ComercialToolStripMenuItem.Visible = True
                mmGeral.Visible = True
                NotaFiscalEletronicaToolStripMenuItem1.Visible = True
            Case 6 'Acesso 6 grupo Caixa
                CadastroToolStripMenuItem.Visible = False
                GerencialToolStripMenuItem.Visible = False
                BalcaoToolStripMenuItem.Visible = True
                EstoqueToolStripMenuItem.Visible = False
                CaixaToolStripMenuItem.Visible = True
                UtilitariosToolStripMenuItem.Visible = True
                TrocarSenhaToolStripMenuItem.Visible = True
                FinanceiroToolStripMenuItem1.Visible = False
                mmGeral.Visible = True
                ToolStripSeparator2.Visible = False
                btnPedido.Visible = False
                ToolStripSeparator3.Visible = False
                btnOS.Visible = False
                ToolStripSeparator4.Visible = False
                btnMovimento.Visible = False
                ToolStripSeparator5.Visible = False
                btnBaixaOsPedido.Visible = False
                ToolStripSeparator6.Visible = False
                btnTrocaProduto.Visible = False
                ToolStripSeparator7.Visible = False
                btnSaidaExtra.Visible = False
                ToolStripSeparator8.Visible = False
                btnAndamentos.Visible = False
                ComercialToolStripMenuItem.Visible = False
                NotaFiscalEletronicaToolStripMenuItem1.Visible = False
            Case 7 'Acesso 7 grupo Promotoras
                CadastroToolStripMenuItem.Visible = False
                GerencialToolStripMenuItem.Visible = False
                BalcaoToolStripMenuItem.Visible = True
                EstoqueToolStripMenuItem.Visible = False
                CaixaToolStripMenuItem.Visible = False
                UtilitariosToolStripMenuItem.Visible = True
                TrocarSenhaToolStripMenuItem.Visible = True
                FinanceiroToolStripMenuItem1.Visible = False
                mmGeral.Visible = True
                ToolStripSeparator2.Visible = False
                btnPedido.Visible = False
                ToolStripSeparator3.Visible = True
                btnOS.Visible = True
                ToolStripSeparator4.Visible = True
                btnMovimento.Visible = True
                ToolStripSeparator5.Visible = False
                btnBaixaOsPedido.Visible = False
                ToolStripSeparator6.Visible = False
                btnTrocaProduto.Visible = False
                ToolStripSeparator7.Visible = False
                btnSaidaExtra.Visible = False
                ToolStripSeparator8.Visible = True
                btnAndamentos.Visible = True
                ToolStripSeparator1.Visible = False
                btnCaixa.Visible = False
                GiroToolStripMenuItem.Visible = False
                Confer�nciaToolStripMenuItem.Visible = False
                AvisoSobreAOS�ticaToolStripMenuItem.Visible = False
                OSPendentePorFornecedorToolStripMenuItem.Visible = False
                OSsPendentePorForneceodr�ticaToolStripMenuItem.Visible = False
                OSsPendentesPorFornLabonorteecedorToolStripMenuItem.Visible = False
                ConsultarOSsPNomeDoClienteToolStripMenuItem.Visible = False
                PararOSTemporariamenteToolStripMenuItem.Visible = False
                ReativarOSParadaNoEstoqueToolStripMenuItem.Visible = False
                EnviarToolStripMenuItem.Visible = False
                RetornoOSFeitaForaToolStripMenuItem.Visible = False
                OSPedidasPendentesToolStripMenuItem.Visible = False
                OSsPendentesDataVerifica��oToolStripMenuItem.Visible = False
                Sa�daOSLaborat�rioToolStripMenuItem.Visible = False
                Impress�oDeOSToolStripMenuItem.Visible = False
                ComercialToolStripMenuItem.Visible = True
                NotaFiscalEletronicaToolStripMenuItem1.Visible = False
            Case 8 'Grupo Comercial
                CadastroToolStripMenuItem.Visible = True
                GerencialToolStripMenuItem.Visible = True
                BalcaoToolStripMenuItem.Visible = True
                EstoqueToolStripMenuItem.Visible = True
                CaixaToolStripMenuItem.Visible = True
                UtilitariosToolStripMenuItem.Visible = True
                TrocarSenhaToolStripMenuItem.Visible = True
                FinanceiroToolStripMenuItem1.Visible = False
                ComercialToolStripMenuItem.Visible = True
                mmGeral.Visible = True
                NotaFiscalEletronicaToolStripMenuItem1.Visible = False
                'Acesso 6 grupo Caixa
        End Select

    End Sub

    Private Sub DespesasAcumuladasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespesasAcumuladasToolStripMenuItem.Click
        Dim f As New frmDespesasAcumuladas
        f.ShowDialog()
    End Sub

    Private Sub ClientesEmD�bitoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesEmD�bitoToolStripMenuItem.Click
        Dim f As New frmDebitoClienteVenc
        f.ShowDialog()
    End Sub

    Private Sub D�bitoClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D�bitoClientesToolStripMenuItem.Click
        Dim f As New frmDebitoCliente
        f.ShowDialog()
    End Sub

    Private Sub D�bitoDeClientesComJurosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D�bitoDeClientesComJurosToolStripMenuItem.Click
        Dim f As New frmDebitoClienteJurosMUlta
        f.ShowDialog()
    End Sub

    Private Sub FaturarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaturarToolStripMenuItem.Click
        Dim f As New frmFaturaCliente
        f.ShowDialog()
    End Sub

    Private Sub AbrePedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrePedidoToolStripMenuItem.Click
        Dim f As New frmAbrePedido
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub CartaDeCobran�aToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CartaDeCobran�aToolStripMenuItem.Click
        Dim f As New frmCartaCobrancaCliente
        f.ShowDialog()
    End Sub


    Private Sub TesteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Opera��eToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opera��eToolStripMenuItem.Click
        Dim fdata As New frmData
        fdata.ShowDialog()
        fdata.Dispose()
        Dim f As New frmRpt
        Dim r As New rptOperacoesCredito
        r.diai = fdata.dtIni.Value.ToShortDateString
        r.diaf = fdata.dtFim.Value.ToShortDateString
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub CaixaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaixaToolStripMenuItem2.Click
        Dim fdata As New frmData
        fdata.ShowDialog()
        fdata.Dispose()
    End Sub


    Private Sub T�tuloDeClienteAVencerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T�tuloDeClienteAVencerToolStripMenuItem.Click
        Dim f As New frmTituloClienteAVencer
        f.ShowDialog()
    End Sub

    Private Sub T�tuloDeClientePagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T�tuloDeClientePagoToolStripMenuItem.Click
        Dim f As New frmTituloClientePago
        f.ShowDialog()
    End Sub

    Private Sub FaturamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaturamentoToolStripMenuItem.Click
        Dim f As New frmFaturamento
        f.Show()
    End Sub

    Private Sub ComprasDeClientesComT�tulosEmAbertoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasDeClientesComT�tulosEmAbertoToolStripMenuItem.Click
        Dim f As New frmDebitoClienteVenc
        f.ShowDialog()
    End Sub

    Private Sub D�bitoClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D�bitoClientesToolStripMenuItem1.Click
        Dim f As New frmDebitoCliente
        f.ShowDialog()
    End Sub

    Private Sub D�bitoDeClientesComJurosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D�bitoDeClientesComJurosToolStripMenuItem1.Click
        Dim f As New frmDebitoClienteJurosMUlta
        f.ShowDialog()
    End Sub

    Private Sub T�tuloDeClienteAVencerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T�tuloDeClienteAVencerToolStripMenuItem1.Click
        Dim f As New frmTituloClienteAVencer
        f.ShowDialog()
    End Sub

    Private Sub T�tuloDeClientePagoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T�tuloDeClientePagoToolStripMenuItem1.Click
        Dim f As New frmTituloClientePago
        f.ShowDialog()
    End Sub

    Private Sub ClientesNovosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesNovosToolStripMenuItem.Click
        Dim f As New frmClientesNovos
        f.Show()
    End Sub

    Private Sub ListaDeClientesPorConsultorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaDeClientesPorConsultorToolStripMenuItem.Click
        Dim f As New frmListaClientes
        f.ShowDialog()
    End Sub

    Private Sub CreditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditoToolStripMenuItem.Click
        Dim f As New frmRpt
        Dim r As New rptTeste
        Dim strsQL As String = ""
        Dim strTitulo As String = ""
        Try
            strsQL = "select cliente.nome_cliente, credito_cliente.*, Usuarios.NOME from credito_cliente " &
                "inner join cliente on cliente.cod_cliente = credito_cliente.cod_cliente " &
                "inner join Usuarios on Usuarios.cod_usuario = credito_cliente.id_usuario " &
                "where (historico NOT LIKE '%aquisi%') AND (historico NOT LIKE '%abati%') AND (historico NOT LIKE '%devolu��o%') " &
                "and (historico NOT LIKE '%estorno%') order by cliente.nome_cliente, credito_cliente.data"
            strTitulo = "Lista de Cr�dito Cedidos por Clientes."

            d.conecta()
            Dim da As New SqlDataAdapter(strsQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Cliente")
            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            r.Label3.Text = strTitulo
            If ds.Tables(0).Rows.Count > 0 Then
                r.DataSource = ds.Tables(0)
            Else
                MessageBox.Show("N�o h� registro a ser exibido.", "INFORMA��O", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            f.Relat(r)
            f.ShowDialog()
            f.Dispose()
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ListaDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaDeClientesToolStripMenuItem.Click
        Dim f As New frmListaClientes
        f.ShowDialog()
    End Sub


    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim f As New frmPedidosNaoFaturados
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub GerarArquivoExporta��oToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GerarArquivoExporta��oToolStripMenuItem.Click
        Try
            Dim Tsql As String
            Dim tt As New DataTable
            Dim ds As New DataSet
            Dim i, f As Integer
            Dim nReg As String = InputBox("Digite a quantidade de registros")
            Dim filial As String = InputBox("Informe a filial")
            Tsql = "Select top(" & nReg & ") * from fila_exportacao where destino = " & filial & " and data_exportacao is null order by id_fila"
            d.carrega_ds(Tsql, ds)
            tt = ds.Tables(0)
            i = tt.Rows(0)("id_fila")
            f = tt.Rows(tt.Rows.Count - 1)("id_fila")
            ds.WriteXml(My.Computer.FileSystem.SpecialDirectories.Desktop & "\dados.xml")
            acesso.atualiza_data_fila_exportacao(i, f)
            MessageBox.Show("Arquivo gerado com sucesso.", "INFORMA��O", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TesteRemessaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TesteRemessaToolStripMenuItem.Click
        'Dim f As New frmArquivoRemessa
        'f.ShowDialog()
    End Sub

    Private Sub ImprimirBoletoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirBoletoToolStripMenuItem.Click
        Dim f As New frmBoleto
        f.ShowDialog()
    End Sub

    Private Sub RecebimentoPromotoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecebimentoPromotoraToolStripMenuItem.Click
        Dim f As New frmListaRecebimentoPromotor
        f.ShowDialog()
    End Sub

    Private Sub PacoteSemCompran�aCadastradaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacoteSemCompran�aCadastradaToolStripMenuItem.Click
        Dim f As New frmRpt
        Dim r As New rptPacoteAberto
        Dim strsQL As String = ""

        Try
            strsQL = "select pacote_cliente.*, cliente.razao_social, cliente.nome_cliente, " &
                "isnull(SUM(pacote_cliente_detalhes.preco_desc*Pacote_cliente_detalhes.quantidade_contratada) + " &
                "SUM(pacote_cliente_detalhes.preco_surf_desc * Pacote_cliente_detalhes.quantidade_surf) + " &
                "SUM(pacote_cliente_detalhes.preco_mont_desc * Pacote_cliente_detalhes.quantidade_mont) + " &
                "SUM(pacote_cliente_detalhes.preco_trat_desc * Pacote_cliente_detalhes.quantidade_trat),0) as total " &
                "from pacote_cliente inner join cliente on pacote_cliente.cod_cliente = cliente.cod_cliente inner join " &
                "Pacote_cliente_detalhes on Pacote_cliente_detalhes.cod_Pacote = pacote_cliente.cod_Pacote and " &
                "Pacote_cliente_detalhes.cod_cliente = pacote_cliente.cod_cliente where pacote_cliente.concluido = 'N' " &
                "group by pacote_cliente.cod_Pacote, pacote_cliente.cod_filial_cliente, pacote_cliente.cod_cliente, pacote_cliente.concluido," &
                "pacote_cliente.data, cliente.cod_cliente, cliente.razao_social, cliente.nome_cliente"

            d.conecta()
            Dim da As New SqlDataAdapter(strsQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds, "Cliente")
            r.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            r.Label3.Text = "Demonstrativo de Pacotes sem cobran�a emitida"
            If ds.Tables(0).Rows.Count > 0 Then
                r.DataSource = ds.Tables(0)
            Else
                MessageBox.Show("N�o h� registro a ser exibido.", "INFORMA��O", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            f.Relat(r)
            f.ShowDialog()
            f.Dispose()
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ComprasDeProdutosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasDeProdutosToolStripMenuItem.Click
        Dim f As New frmCompraProdutos
        f.ShowDialog()
    End Sub

    Private Sub EntregaOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntregaOSToolStripMenuItem.Click
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        Dim intLoja As Int16
        Dim intOS As Integer
        intLoja = arq.Filial
        Try
            intOS = InputBox("Digite o n�mero da OS Local (Labonorte):")
        Catch ex As Exception
            MsgBox("Erro ao converter tipo de dados.")
            Exit Sub
        End Try

        If MessageBox.Show("Deseja finalizar a OS: " & intOS & "?", "INFORMA��O", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim strMensagem As String = "Servi�o Entregue para o Cliente"
            anda.insere_andamento(objAndamentos.tipo.aviso_os, intLoja, intOS, intUsuario, strMensagem)
            MessageBox.Show("OS: " & intOS & " finalizada com sucesso.", "INFORMA��O", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Opera��o cancelada com sucesso.", "INFORMA��O", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Transposi��oToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Transposi��oToolStripMenuItem.Click
        Dim f As New frmTransposicao
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub OSsPendentesDeEntregaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OSsPendentesDeEntregaToolStripMenuItem.Click
        Dim f As New frmOSPendentes
        f.ShowDialog()
        f.Dispose()
    End Sub


    Private Sub Configura��esToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Configura��esToolStripMenuItem.Click
        Dim intAcesso As Integer = UserPermissao.VerificaPermissaoMenu(UserPermissao.CodigoUsuario)
        If intAcesso = 1 Or intAcesso = 5 Then
            Dim f As New frmConfiguracao
            f.ShowDialog(Me)
            f.Dispose()
        Else
            MessageBox.Show("Usu�rio sem acesso a este m�dulo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PromotoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromotoraToolStripMenuItem.Click
        Dim intAcesso As Integer = UserPermissao.VerificaPermissaoMenu(UserPermissao.CodigoUsuario)
        If intAcesso = 1 Or intAcesso = 5 Then
            Dim f As New frmPromotora
            f.ShowDialog(Me)
            f.Dispose()
        Else
            MessageBox.Show("Usu�rio sem acesso a este m�dulo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function arredondamento(ByVal valor As Double, ByVal parc As Integer) As Double
        'Dim vlValor As Double = Math.Round(10 / 3, 2)
        Dim vlvalor As Double = 0.0
        Dim i As Integer
        Dim vlDif As Double = 0.0

        'For i = 0 To parc
        'vlValor = vlValor + vlValor
        'Next

        If valor Mod 3 Then
            vlvalor = acesso.arredondaValor(valor, parc)
        End If

        Return vlvalor

        ' If vlValor < valor Then
        'vlDif = valor - vlValor
        'End If



    End Function

    Private Sub Relat�rioDeVendasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Relat�rioDeVendasToolStripMenuItem.Click
        Dim f As New frmVendas
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim fc As New frmCliente_Old
        fc.Show()
    End Sub

    Private Sub Autoriza��oParaClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Autoriza��oParaClientesToolStripMenuItem.Click
        Dim f As New frmAutorizacao
        f.ShowDialog()
    End Sub

    Private Sub TipoCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoCompraToolStripMenuItem.Click
        Dim strSQL As String = "select * from cliente"
        Dim strSQLInsert As String = ""
        Dim tt As New DataTable
        tt = acesso.retornaRegistro(strSQL).Tables(0)

        Dim i As Integer

        For i = 0 To tt.Rows.Count - 1
            If tt.Rows(i)("TIPO_COMPRA") = 1 Then
                strSQLInsert = "INSERT INTO FORMA_COMPRA (CODIGO_TIPO_COMPRA,COD_CLIENTE,COD_FILIAL_CLIENTE) VALUES(" & tt.Rows(i)("TIPO_COMPRA") & "," &
                tt.Rows(i)("COD_CLIENTE") & "," & tt.Rows(i)("COD_FILIAL_CLIENTE") & ")"
                acesso.grava_registros(strSQLInsert, True)
            End If

            If tt.Rows(i)("TIPO_COMPRA") = 2 Then
                strSQLInsert = "INSERT INTO FORMA_COMPRA (CODIGO_TIPO_COMPRA,COD_CLIENTE,COD_FILIAL_CLIENTE) VALUES(" & "1" & "," &
                tt.Rows(i)("COD_CLIENTE") & "," & tt.Rows(i)("COD_FILIAL_CLIENTE") & ")"
                acesso.grava_registros(strSQLInsert, True)

                strSQLInsert = "INSERT INTO FORMA_COMPRA (CODIGO_TIPO_COMPRA,COD_CLIENTE,COD_FILIAL_CLIENTE) VALUES(" & "2" & "," &
                tt.Rows(i)("COD_CLIENTE") & "," & tt.Rows(i)("COD_FILIAL_CLIENTE") & ")"
                acesso.grava_registros(strSQLInsert, True)
            End If

            If tt.Rows(i)("TIPO_COMPRA") = 3 Then
                strSQLInsert = "INSERT INTO FORMA_COMPRA (CODIGO_TIPO_COMPRA,COD_CLIENTE,COD_FILIAL_CLIENTE) VALUES(" & "1" & "," &
                tt.Rows(i)("COD_CLIENTE") & "," & tt.Rows(i)("COD_FILIAL_CLIENTE") & ")"
                acesso.grava_registros(strSQLInsert, True)
                strSQLInsert = "INSERT INTO FORMA_COMPRA (CODIGO_TIPO_COMPRA,COD_CLIENTE,COD_FILIAL_CLIENTE) VALUES(" & "2" & "," &
                tt.Rows(i)("COD_CLIENTE") & "," & tt.Rows(i)("COD_FILIAL_CLIENTE") & ")"
                acesso.grava_registros(strSQLInsert, True)
            End If
        Next
    End Sub

    Private Sub AtualizaCampoDescontoTabPedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizaCampoDescontoTabPedidoToolStripMenuItem.Click

        Dim strSQL As String = "select * from pedido_balcao_itens"
        Dim tt As New DataTable
        tt = acesso.retornaRegistro(strSQL).Tables(0)
        Dim i As Integer
        Dim strSQLAtualiza As String
        For i = 0 To tt.Rows.Count - 1
            If tt.Rows(i)("desconto") > 0 Then
                strSQLAtualiza = "desconto = 'S' where num_pedido = " & tt.Rows(i)("num_pedido") & " and id_filial = " & tt.Rows(i)("id_filial")
            Else
                strSQLAtualiza = "desconto = 'N' where num_pedido = " & tt.Rows(i)("num_pedido") & " and id_filial = " & tt.Rows(i)("id_filial")
            End If
            atualiza("pedido_balcao", strSQLAtualiza)
        Next

    End Sub

    Private Sub atualiza(ByVal tabela As String, ByVal instrucaoSQL As String)
        strSQL = "Update " & tabela & " Set " & instrucaoSQL
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub AutorizarVendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutorizarVendaToolStripMenuItem.Click
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        If acesso.verifica_permissao_usuario(intUsuario, 31) = True Then
            Dim f As New frmPedidoAutorizacao
            f.ShowDialog()
        Else
            MessageBox.Show("Usu�rio sem permiss�o para conceder autoriza�ao" & Chr(13) & "de venda para o cliente, fale com seu gerente.", "ERROR: 31", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub EstornarCr�ditoDinheiroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstornarCr�ditoDinheiroToolStripMenuItem.Click
        Dim f As New frmCredito
        Dim strPedido As String = InputBox("N� do Pedido:")
        If strPedido <> String.Empty Then
            f.intAbrePedido = CInt(strPedido)
            f.ShowDialog(Me)
            f.Dispose()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub AtualizaPrecoTabelaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizaPrecoTabelaToolStripMenuItem.Click
        Dim f As New TestePreco
        f.ShowDialog()
    End Sub

    Private Sub AtualizaFaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtualizaFaturaToolStripMenuItem.Click
        Dim f As New frmTesteFatura
        f.ShowDialog()
    End Sub

    Private Sub AjusteEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjusteEstoqueToolStripMenuItem.Click
        Dim intAcesso As Integer = UserPermissao.VerificaPermissaoMenu(UserPermissao.CodigoUsuario)
        If UserPermissao.VerificaPermissaoUsuario(55) = True Then
            Dim f As New frmConferenciaLentes
            f.ShowDialog()
            f.Dispose()
        Else
            MessageBox.Show("Usu�rio sem permiss�o para acessar este m�dulo.", "ERROR: 55", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FamiliaLentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FamiliaLentesToolStripMenuItem.Click
        Dim f As New frmFamiliaLentes
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub ImprimeNFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimeNFToolStripMenuItem.Click
        Dim rp As New rptContagem
        Dim entrada As New objEntradaNota
        Dim f As New frmRpt
        Dim NF As String
        Dim path As String
        Dim r As Integer
        NF = InputBox("Digite o n�mero do Documento: (Ex.: NF 23618)")
        path = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & NF & ".pdf"
        rp.titulo = "Entrada no estoque do documento: " & NF
        rp.DataSource = entrada.lista_itens_impressao_nota(NF)
        f.Relat(rp)
        f.ShowDialog(Me)
        r = MsgBox("Deseja gerar arquivo PDF?", MsgBoxStyle.YesNo)
        If r = vbYes Then
            PdfExport.Export(rp.Document, path)
        End If
    End Sub


    Private Sub NotaFiscalEletronicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaFiscalEletronicaToolStripMenuItem1.Click
        'Dim f As New frmNotaFiscalEletronica
        'f.ShowDialog()
        'f.Dispose()
    End Sub

    Private Sub EToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Classifica��oFiscalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Classifica��oFiscalToolStripMenuItem.Click
        Dim f As New frmClassificacaoFiscal
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub EstoquePreferencialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstoquePreferencialToolStripMenuItem.Click
        Dim f As New frmEstoquePreferencial
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub TrocaDeBaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrocaDeBaseToolStripMenuItem.Click
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        If acesso.verifica_permissao_usuario(intUsuario, 14) = True Then
            Dim f As New frmTrocaBase
            f.ShowDialog(Me)
            f.Dispose()
        Else
            MessageBox.Show("Usu�rio sem permiss�o para acessar este m�dulo.", "ERROR: 14", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TrocaDeProdutoEBaseCSa�daDoEstoqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrocaDeProdutoEBaseCSa�daDoEstoqueToolStripMenuItem.Click
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        If acesso.verifica_permissao_usuario(intUsuario, 8) = True Then
            Dim f As New frmTrocaProduto
            Try
                f.x_cod_troca = InputBox("Digite o N� da Troca do Produto ou Troca de Base.")
                f.x_id_filial = InputBox("Informe o N� da Filial", "", arq.Filial)
                f.ShowDialog(Me)
                f.Dispose()
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Usu�rio sem permiss�o para acessar este m�dulo.", "ERROR: 08", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RelProdNotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelProdNotaToolStripMenuItem.Click
        Dim f As New frmRelacaoCodFornecedorSistema
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TToolStripMenuItem.Click
        Dim teste As frmTesteNFeNovo = New frmTesteNFeNovo
        teste.ShowDialog()
        teste.Dispose()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        Dim f As frmEmitente = New frmEmitente
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub ConsultaProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaProdutoToolStripMenuItem.Click
        Dim f As New frmConsultaProduto
        f.ShowDialog()
    End Sub

    Private Sub EmitirNFeNFCeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmitirNFeNFCeToolStripMenuItem.Click
        Dim f As New frmNFe
        f.TipoRegistro = "N"
        f.ShowDialog()
    End Sub

    Private Sub EvenyosNFCeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvenyosNFCeToolStripMenuItem.Click
        Dim f As New frmNFeLista
        f.ShowDialog()
    End Sub

    Private Sub FabricanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FabricanteToolStripMenuItem.Click
        Dim f As New frmFabricante
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub btnSaidaExtra_Click(sender As Object, e As EventArgs) Handles btnSaidaExtra.Click
        Dim intUsuario As Integer = acesso.retorna_codigo_usuario(strUsuario)
        If acesso.verifica_permissao_usuario(intUsuario, 45) = True Then
            Dim f As New frmSaidaExtra
            f.ShowDialog(Me)
            f.Dispose()
        Else
            MessageBox.Show("Usu�rio sem permiss�o para acessar este m�dulo.", "ERROR: 45", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class