Imports mrotica_util
Imports System.Net
Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml

Public Class frmEntradaManualEstoque
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents grdProd As System.Windows.Forms.DataGrid
    Friend WithEvents btnLimpa As System.Windows.Forms.Button
    Friend WithEvents txtCodBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstNex As System.Windows.Forms.ListBox
    Friend WithEvents btnInvetario As System.Windows.Forms.Button
    Friend WithEvents btnExcluiItem As System.Windows.Forms.Button
    Friend WithEvents grpDetalhes As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AtualizarPreçoCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents pb As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbReembolso As System.Windows.Forms.CheckBox
    Friend WithEvents txtOS As System.Windows.Forms.TextBox
    Friend WithEvents txtFilial As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQtde As System.Windows.Forms.TextBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntradaManualEstoque))
        Me.grdProd = New System.Windows.Forms.DataGrid()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AtualizarPreçoCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCodBarra = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstNex = New System.Windows.Forms.ListBox()
        Me.grpDetalhes = New System.Windows.Forms.GroupBox()
        Me.btnLimpa = New System.Windows.Forms.Button()
        Me.btnExcluiItem = New System.Windows.Forms.Button()
        Me.btnInvetario = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pb = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbReembolso = New System.Windows.Forms.CheckBox()
        Me.txtOS = New System.Windows.Forms.TextBox()
        Me.txtFilial = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQtde = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.grpDetalhes.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdProd
        '
        Me.grdProd.ContextMenuStrip = Me.ContextMenuStrip1
        Me.grdProd.DataMember = ""
        Me.grdProd.Enabled = False
        Me.grdProd.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdProd.Location = New System.Drawing.Point(8, 189)
        Me.grdProd.Name = "grdProd"
        Me.grdProd.ReadOnly = True
        Me.grdProd.Size = New System.Drawing.Size(665, 356)
        Me.grdProd.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtualizarPreçoCompraToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(200, 26)
        '
        'AtualizarPreçoCompraToolStripMenuItem
        '
        Me.AtualizarPreçoCompraToolStripMenuItem.Name = "AtualizarPreçoCompraToolStripMenuItem"
        Me.AtualizarPreçoCompraToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AtualizarPreçoCompraToolStripMenuItem.Text = "Atualizar Preço Compra"
        '
        'txtCodBarra
        '
        Me.txtCodBarra.Location = New System.Drawing.Point(101, 16)
        Me.txtCodBarra.Name = "txtCodBarra"
        Me.txtCodBarra.Size = New System.Drawing.Size(106, 20)
        Me.txtCodBarra.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "lixeira.png")
        Me.ImageList1.Images.SetKeyName(1, "excluir.png")
        Me.ImageList1.Images.SetKeyName(2, "barra.png")
        Me.ImageList1.Images.SetKeyName(3, "salvar.png")
        Me.ImageList1.Images.SetKeyName(4, "importa_nota.png")
        Me.ImageList1.Images.SetKeyName(5, "nota_manual.png")
        Me.ImageList1.Images.SetKeyName(6, "entrada_estoque.png")
        Me.ImageList1.Images.SetKeyName(7, "relatorio.png")
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Código de Barras:"
        '
        'lstNex
        '
        Me.lstNex.Enabled = False
        Me.lstNex.FormattingEnabled = True
        Me.lstNex.Location = New System.Drawing.Point(685, 189)
        Me.lstNex.Name = "lstNex"
        Me.lstNex.Size = New System.Drawing.Size(168, 355)
        Me.lstNex.TabIndex = 13
        '
        'grpDetalhes
        '
        Me.grpDetalhes.Controls.Add(Me.btnLimpa)
        Me.grpDetalhes.Controls.Add(Me.txtCodBarra)
        Me.grpDetalhes.Controls.Add(Me.btnExcluiItem)
        Me.grpDetalhes.Controls.Add(Me.Label2)
        Me.grpDetalhes.Controls.Add(Me.btnInvetario)
        Me.grpDetalhes.Enabled = False
        Me.grpDetalhes.Location = New System.Drawing.Point(8, 136)
        Me.grpDetalhes.Name = "grpDetalhes"
        Me.grpDetalhes.Size = New System.Drawing.Size(845, 46)
        Me.grpDetalhes.TabIndex = 3
        Me.grpDetalhes.TabStop = False
        Me.grpDetalhes.Text = "Detalhes"
        '
        'btnLimpa
        '
        Me.btnLimpa.ImageIndex = 0
        Me.btnLimpa.ImageList = Me.ImageList1
        Me.btnLimpa.Location = New System.Drawing.Point(224, 14)
        Me.btnLimpa.Name = "btnLimpa"
        Me.btnLimpa.Size = New System.Drawing.Size(75, 26)
        Me.btnLimpa.TabIndex = 1
        Me.btnLimpa.Text = "Limpa"
        Me.btnLimpa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnExcluiItem
        '
        Me.btnExcluiItem.ImageIndex = 1
        Me.btnExcluiItem.ImageList = Me.ImageList1
        Me.btnExcluiItem.Location = New System.Drawing.Point(304, 14)
        Me.btnExcluiItem.Name = "btnExcluiItem"
        Me.btnExcluiItem.Size = New System.Drawing.Size(113, 26)
        Me.btnExcluiItem.TabIndex = 2
        Me.btnExcluiItem.Text = "Eliminar um item"
        Me.btnExcluiItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnInvetario
        '
        Me.btnInvetario.ImageIndex = 6
        Me.btnInvetario.ImageList = Me.ImageList1
        Me.btnInvetario.Location = New System.Drawing.Point(432, 16)
        Me.btnInvetario.Name = "btnInvetario"
        Me.btnInvetario.Size = New System.Drawing.Size(138, 26)
        Me.btnInvetario.TabIndex = 16
        Me.btnInvetario.Text = "Entrar no Estoque"
        Me.btnInvetario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pb, Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 550)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(863, 22)
        Me.StatusStrip1.TabIndex = 43
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pb
        '
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(164, 16)
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbReembolso)
        Me.GroupBox1.Controls.Add(Me.txtOS)
        Me.GroupBox1.Controls.Add(Me.txtFilial)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtQtde)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalhe"
        '
        'cbReembolso
        '
        Me.cbReembolso.AutoSize = True
        Me.cbReembolso.Location = New System.Drawing.Point(354, 40)
        Me.cbReembolso.Name = "cbReembolso"
        Me.cbReembolso.Size = New System.Drawing.Size(102, 17)
        Me.cbReembolso.TabIndex = 59
        Me.cbReembolso.Text = "Reembolso Loja"
        Me.cbReembolso.UseVisualStyleBackColor = True
        '
        'txtOS
        '
        Me.txtOS.Enabled = False
        Me.txtOS.Location = New System.Drawing.Point(247, 38)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(100, 20)
        Me.txtOS.TabIndex = 2
        '
        'txtFilial
        '
        Me.txtFilial.Enabled = False
        Me.txtFilial.Location = New System.Drawing.Point(129, 38)
        Me.txtFilial.Name = "txtFilial"
        Me.txtFilial.Size = New System.Drawing.Size(100, 20)
        Me.txtFilial.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "OS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Filial Loja"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Obs:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Quantidade"
        '
        'txtQtde
        '
        Me.txtQtde.Location = New System.Drawing.Point(11, 39)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(100, 20)
        Me.txtQtde.TabIndex = 0
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(11, 83)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(521, 43)
        Me.txtObs.TabIndex = 3
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(354, 40)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 59
        Me.CheckBox1.Text = "Reembolso Loja"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.ImageIndex = 3
        Me.btnSalvar.ImageList = Me.ImageList1
        Me.btnSalvar.Location = New System.Drawing.Point(685, 55)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(72, 26)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'frmEntradaManualEstoque
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(863, 572)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.grpDetalhes)
        Me.Controls.Add(Me.lstNex)
        Me.Controls.Add(Me.grdProd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEntradaManualEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada e Conferência de Nota"
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.grpDetalhes.ResumeLayout(False)
        Me.grpDetalhes.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim tb As New DataTable
    Dim entrada As New objEntradaNota
    Dim tbCont As New DataTable
    Dim d As New dados()
    Dim p As New produtoClass
    Dim user As New objUsuario(UserID)
    Public conf As New config
    Dim mov As New objMovimentoDetalhe
    Dim chave_movimento As Integer
    Public novo As Boolean = True
    Public x_id_conferencia, x_filial As Integer
    Dim x_tabela As String = ""
    Dim x_tipo As String = ""
    Dim item As Integer = Nothing 'Guarda o número do item para inserir na entrada
    Dim trans As New objSqlTrans
    Dim lblCodTabela As New Label
    Dim lblCodTabela_Atualiza As New Label 'Guarda o código da lente
    Dim arquivonota As String = "" 'Guarda o caminho do arquivo xml para leitura da NFe
    Dim cnpjfor As String = "" 'Guarda o cnpj do Fornecedor
    Dim tiponota As String = ""
    Dim grdCalcula As New DataGridView 'Cria o grid em tempo de execução
    Dim nQtdeTotal As Integer  'Guarda o total de itens do grid em execução em tempo de execução
    Dim nValorTotal As Double 'Guarda o valor total do grid em tempo de execução
    Dim notafiscal As New objMaster
    Dim lblCodigoProd As New Label
    Dim lblCodigoPed As New Label
    Dim frete As String = ""
    Dim strDevolucao As String = ""
    Dim strReembolso As String = ""

    Private Function busca_fornecedor(ByVal codigo As Integer) As String
        Dim sql As String
        Dim resultado As String = ""
        sql = "Select fornecedor from fornecedor where cod_fornecedor = @codigo"
        Dim cmd As New SqlCommand(sql, d.con)
        cmd.Parameters.AddWithValue("@codigo", codigo)
        Dim dr As SqlDataReader
        d.conecta()
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            resultado = dr.Item("fornecedor").ToString
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
        Return resultado
    End Function

    Private Function busca_forma_pagamento(ByVal codigo As Integer) As String
        Dim sql As String
        Dim resultado As String = ""
        sql = "Select forma_pagamento from forma_pagamento where cod_forma_pagamento = @codigo"
        Dim cmd As New SqlCommand(sql, d.con)
        cmd.Parameters.AddWithValue("@codigo", codigo)
        Dim dr As SqlDataReader
        d.conecta()
        Try
            dr = cmd.ExecuteReader()
            dr.Read()
            resultado = dr.Item("forma_pagamento").ToString
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
        Return resultado
    End Function

    Private Sub carrega_grd()
        Dim sql As String
        Dim TStb As New DataGridTableStyle
        tb = entrada.lista_itens_exibir("DESC", conf.Filial)
        grdProd.DataSource = tb
        TStb.MappingName = grdProd.DataSource.tablename

        Dim cItem As New DataGridTextBoxColumn
        With cItem
            .MappingName = "id_item"
            .HeaderText = "Item"
            .Width = 30
        End With
        TStb.GridColumnStyles.Add(cItem)

        Dim cProd As New DataGridTextBoxColumn
        With cProd
            .MappingName = "produto"
            .HeaderText = "Produto"
            .Width = 430
        End With
        TStb.GridColumnStyles.Add(cProd)

        Dim cCod As New DataGridTextBoxColumn
        With cCod
            .MappingName = "cod_barra"
            .HeaderText = "Cod. Barras"
            .Width = 65
        End With
        TStb.GridColumnStyles.Add(cCod)

        Dim quant As New DataGridTextBoxColumn
        With quant
            .MappingName = "quantidade"
            .HeaderText = "quant."
            .Width = 40
        End With
        TStb.GridColumnStyles.Add(quant)

        Dim preco As New DataGridTextBoxColumn
        With preco
            .MappingName = "preco_nota"
            .Format = "#,##0.00"
            .HeaderText = "P. Nota"
            .Width = 60
        End With
        TStb.GridColumnStyles.Add(preco)

        grdProd.TableStyles.Clear()
        grdProd.TableStyles.Add(TStb)

    End Sub
    Private Sub btnLimpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpa.Click
        If entrada.concluido = "S" Then
            AVISO("Os produtos dessa nota já deram entrada no estoque, não é mais possível alterá-la!", Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End If
        Dim R As frmAviso.respo
        R = AVISO("Tem certeza que deseja excluir toda a contagem?", Me, frmAviso.tipo_aviso.tipo_sim_nao)
        If R = frmAviso.respo.SIM Then
            entrada.limpa_nota()
            carrega_grd()
            lstNex.Items.Clear()
            txtCodBarra.Focus()
        End If
    End Sub
    Private Sub txtCodBarra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodBarra.KeyDown
        Dim RES As String
        Select Case e.KeyCode
            Case Keys.Enter
                If entrada.concluido = "S" Then
                    AVISO("Os produtos dessa nota já deram entrada no estoque, não é mais possível alterá-la!", Me, frmAviso.tipo_aviso.tipo_ok)
                    Exit Sub
                End If
                If txtCodBarra.Text = "" Then
                    prod_manual()
                Else
                    processa_barra()
                End If
        End Select
    End Sub
    Private Sub prod_manual()
        Dim f As New frmConsultaProdDiopCod
        Dim es As String
        Dim cod_prod As Integer
        Dim prod As New produtoClass
        Dim sql As String
        Dim res As String
        Dim item As Integer
        Dim quant As Integer
        Dim strAvulsa As String
        es = InputBox("Digite o tipo B para bloco, L para lente pronta, BS para bloco surfaçado e LC para Lente de Contato!", "", x_tipo)
        x_tipo = es
        If es.ToString.Trim.ToUpper <> "L" And es.ToString.ToUpper <> "B" And es.ToString <> "BS" And es.ToString <> "LC" Then
            som_erro()
            MsgBox("Erro!")
            Exit Sub
        End If
        'Se o produto for Lente pronta, abre o formulário 
        'de lente.
        If es = "L" Then
            f.tipo = "L"
            f.txtCodTabela.Text = x_tabela
            f.ShowDialog(Me)
            cod_prod = f.Result
        ElseIf es = "B" Then
            'Se o produto for bloco, abre o formulário 
            'de bloco.
            f.tipo = "B"
            f.txtCodTabela.Text = x_tabela
            f.ShowDialog(Me)
            cod_prod = f.Result
        ElseIf es = "BS" Then
            f.tipo = "BS"
            f.txtCodTabela.Text = x_tabela
            f.ShowDialog(Me)
            cod_prod = f.Result
        ElseIf es = "LC" Then
            f.tipo = "LC"
            f.txtCodTabela.Text = x_tabela
            f.ShowDialog(Me)
            cod_prod = f.Result
        End If
        If cod_prod = 0 Then
            AVISO("Produto não encontrado!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            Exit Sub
        End If
        x_tabela = f.txtCodTabela.Text
        lblCodTabela.Text = x_tabela
        quant = InputBox("Quantidade:", "", 1)
        item = existe_produto(cod_prod)

        If txtCodBarra.Text <> "555555" Then
            lblCodigoProd.Text = cod_prod 'Pega o código do produto para ser utilizado na função verifica_produto_pedido
            'lblCodigoPed.Text = notafiscal.so_numeros(txtPedidos.Text) 'Pega o código do pedido para ser utilizado na função verifica_produto_pedido
        End If


        If item = 0 Then
            If txtCodBarra.Text <> "555555" Then
                inserir_produto(cod_prod, quant, busca_preco_lente(cod_prod), busca_cod_tabela(cod_prod),
                busca_desconto_lente(cod_prod), "N")
            Else
                inserir_produto(cod_prod, quant, busca_preco_lente_optifogue(20), 20, busca_desconto_lente_optifogue(20), "N")
            End If
            lblStatus.Text = "Último produto: " & cod_prod & " - " & "Conf: " & entrada.id_conferencia
        Else
            atualizar_produto(item, quant_produto(cod_prod) + quant)
        End If
        carrega_grd()
        txtCodBarra.Focus()
    End Sub
    Private Sub processa_barra()
        Dim res As String
        Dim sql As String
        Dim item As Integer
        Dim strAvulsa As String = ""
        Try
            'Consulta o produto na tabelaprodutos pelo codigo de barra
            tb = p.Consultar_produtos_barra(txtCodBarra.Text)

            If txtCodBarra.Text <> "555555" Then
                'Retorna o código da lente na tabela pelo codigo do produto "tabela_conferencia_nota
                lblCodTabela.Text = busca_cod_tabela(tb.Rows(0)("cod_produto"))
            End If

            lblCodigoProd.Text = tb.Rows(0)("cod_produto") 'Pega o código do produto para ser utilizado na função verifica_produto_pedido
            'lblCodigoPed.Text = notafiscal.so_numeros(txtPedidos.Text) 'Pega o código do pedido para ser utilizado na função verifica_produto_pedido


            If tb.Rows.Count > 0 Then
                item = existe_produto(tb.Rows(0)("cod_produto"))
                If item = 0 Then
                    If txtCodBarra.Text <> "555555" Then
                        inserir_produto(tb.Rows(0)("cod_produto"), 1, busca_preco_lente(tb.Rows(0)("cod_produto")), busca_cod_tabela(tb.Rows(0)("cod_produto")),
                        busca_desconto_lente(tb.Rows(0)("cod_produto")), "N")
                    Else
                        inserir_produto(tb.Rows(0)("cod_produto"), 1, busca_preco_lente_optifogue(20), 20, busca_desconto_lente_optifogue(20), "N")
                    End If

                    lblStatus.Text = "Último produto: " & tb.Rows(0)("Produto") & " - " & "Conf: " & entrada.id_conferencia
                Else
                    atualizar_produto(item, quant_produto(item) + 1)
                End If
                carrega_grd()
            Else
                AVISO(txtCodBarra.Text & vbCrLf & "Código de Barras não encontrado!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                lstNex.Items.Add(txtCodBarra.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString) 'depois tirar
        End Try
        txtCodBarra.Text = Nothing
        txtCodBarra.Focus()
    End Sub
    Private Sub inserir_produto(ByVal xCod_prod As Integer, ByVal xQuant As Integer, xpreco_nota As String,
                                xcod_tabela As Integer, ByVal xdesconto_compra As String, ByVal xavulsa As String)
        Dim sql As String
        Dim res As String
        res = entrada.insere_item(xCod_prod, xQuant, UserID, xpreco_nota, xcod_tabela, xdesconto_compra, xavulsa)
        If res.StartsWith("OK") Then
            som_ok()
        Else
            MsgBox(res)
            AVISO(res, Me, frmAviso.tipo_aviso.tipo_ok, True)
        End If
        carrega_grd()
    End Sub
    Private Sub atualizar_produto(ByVal xitem As Integer, ByVal xQuant As Integer)
        Dim res As String
        res = entrada.atualiza_quantidade(xitem, xQuant)
        If res.StartsWith("OK") Then
            som_ok()
        Else
            AVISO(res, Me, frmAviso.tipo_aviso.tipo_ok, True)
        End If
    End Sub

    Private Function existe_produto(ByVal xCod_prod As Integer) As Integer
        Dim tt As New DataTable
        Dim sql As String
        sql = "Select id_item from conferencia_nota where cod_produto = " & xCod_prod &
        " and id_conferencia = " & entrada.id_conferencia & " and id_filial_nota = " &
        entrada.id_filial_nota
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("id_item")
        Else
            Return 0
        End If
    End Function

    Private Function quant_produto(ByVal xitem As Integer) As Integer
        Dim tt As New DataTable
        Dim sql As String
        sql = "select quant from conferencia_nota where id_item = " & xitem & " and " &
        "id_conferencia = " & entrada.id_conferencia & " and id_filial_nota = " &
        entrada.id_filial_nota & ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("quant")
        Else
            Return 0
        End If
    End Function

    Private Sub btnInvetario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvetario.Click
        Dim valor As Double
        Dim valorconv As Double
        Dim quantidade As Integer
        Dim status As Integer
        Dim strDocumento As String = ""

        If calculaitens(entrada.id_conferencia) = CInt(txtQtde.Text) Then

            quantidade = CInt(txtQtde.Text)
            valorconv = Format(CDbl(nValorTotal), "#,##0.00")

            If grdProd.CurrentRowIndex > -1 Then
                Dim resp As String
                resp = user.login(Me)
                If resp.StartsWith("ER") = True Then
                    AVISO(resp, Me, frmAviso.tipo_aviso.tipo_ok)
                    Exit Sub
                End If
                If entrada.concluido = "S" Then
                    AVISO("Os itens dessa nota já deram entrada no estoque!", Me, frmAviso.tipo_aviso.tipo_ok, True)
                    Exit Sub
                End If
                Dim sql As String
                Dim tSql As String
                Dim iSql As String
                Dim tt As New DataTable
                Dim res As String
                Dim i, m As Integer
                'Seleciona os itens da tabela conferencia_nota para posterior inserção dos dados na tabela movimento
                tt = entrada.lista_itens("asc")
                i = 0
                pb.Minimum = 0
                m = tt.Rows.Count 'Guarda a quantidade de registro selecionado na instrução entrada.lista_itens
                pb.Maximum = m
                Dim dt As Object
                item = mov.ret_ultimo_item(entrada.cod_movimento) 'retorna o item inicial
                While i < m
                    dt = rdData(tt.Rows(i)("Processado"))
                    If dt = Nothing Then
                        insere_item_nota(tt.Rows(i)("cod_produto"), tt.Rows(i)("quantidade")) 'Insere os dados na tabela movimento
                        Application.DoEvents()
                        entrada.PROCESSADO(tt.Rows(i)("id_item")) 'atualiza a data em que foi processado o registro
                        entrada.PROCESSADO_AVULSA() 'atualiza a data em que foi processado o registro em que a entrada foi de forma avulsa
                    End If
                    i = i + 1
                    pb.Value = i
                End While
                entrada.editar()
                entrada.cod_usuario = user.cod_usuario 'retorna o codigo do usuário logado
                entrada.Salvar()
                AVISO("Concluído!", Me, frmAviso.tipo_aviso.tipo_ok)
                entrada.conclui()

                espelho_nota() 'Exibi o relatório referente o espelho da nota fiscal

            Else
                MessageBox.Show("Não existe itens para  serem lançados para nota fiscal.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Quantidade de itens informado não confere com o calculado pelo sistema." & Chr(13) & Chr(13) & "Itens calculado pelo sistema: " & calculaitens(entrada.id_conferencia),
                           "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

    End Sub
    Private Sub insere_item_nota(ByVal _x_cod_prod As Integer, ByVal q As Double)
        Dim media_len, media_prod As Double
        Dim cod_len As Integer
        Dim p As New produtoClass
        p.filtra(_x_cod_prod)
        mov.novo()
        mov.item = item
        mov.cod_movimento = entrada.cod_movimento
        mov.id_filial = entrada.id_filial
        mov.cod_produto = p.fldCod_produto
        mov.quant = q
        mov.desconto = p.Desconto_compra
        mov.pUnit = p.Preco_compra
        mov.estoqueFis = mov.ret_saldo_fisico(p.fldCod_produto) + CDbl(q)
        mov.estoqueFin = mov.estoqueFis * ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))))
        '( + mov.ret_saldo_fin(txtCodProd.Text)
        Try
            cod_len = mov.retorna_cod_lentebloco(p.fldCod_produto)
            media_len = media_movel(mov.ret_saldo_todos_fisico(cod_len), mov.ret_saldo_todos_fin(cod_len), q, (p.Preco_compra) - (p.Preco_compra * (p.Desconto_compra / 100)))
        Catch ex As Exception
            cod_len = 0
            media_len = 0
        End Try
        media_prod = media_movel(mov.ret_saldo_fisico(p.fldCod_produto), mov.ret_saldo_fin(p.fldCod_produto), q, (p.Preco_compra) - (p.Preco_compra * (p.Desconto_compra / 100)))
        mov.atualiza_custo(cod_len, media_len, p.fldCod_produto, media_prod)
        mov.historico = txtObs.Text
        lstNex.Items.Add(mov.Salvar().ToString)
    End Sub

    Private Sub btnExcluiItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiItem.Click
        If entrada.concluido = "S" Then
            AVISO("Os produtos dessa nota já deram entrada no estoque, não é mais possível alterá-la!", Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End If
        Dim p As New produtoClass
        Dim g As String
        Dim item As Integer
        item = InputBox("Digite o item que deseja excluir:", "", grdProd.Item(grdProd.CurrentRowIndex, 0))
        MsgBox(entrada.exclui_item(item))
        carrega_grd()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim codmovimento As Integer
        Dim codnota As Integer
        Dim codped As Integer
        Dim codfor As Integer

        If entrada.concluido = "S" Then
            AVISO("Os produtos dessa nota já deram entrada no estoque, não é mais possível alterá-la!", Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End If

        grpDetalhes.Enabled = True
        grdProd.Enabled = True
        lstNex.Enabled = True
        entrada.novo()
        entrada.data = Now()
        entrada.documento = "ENTRADA MANUAL"
        entrada.pedido = "ENTRADA MANUAL"
        entrada.cod_fornecedor = 0
        entrada.id_filial_nota = conf.Filial
        entrada.observacao = txtObs.Text
        entrada.parte = "1"
        entrada.cod_usuario = UserID
        entrada.valor_total_prod = "0.00"
        entrada.valor_total_nota = "0.00"
        entrada.valor_frete = "0.00"
        entrada.quantidade = txtQtde.Text
        entrada.num_parcela = 0
        entrada.valor_parcela = "0.00"
        entrada.tipo_nota = tiponota
        entrada.cod_forma_pagamento = 0
        entrada.frete_paga = frete
        If cbReembolso.Checked = True Then
            strReembolso = "S"
        Else
            strReembolso = "N"
        End If
        entrada.reembolso = strReembolso


        If txtFilial.Text = "" Then
            entrada.filial_loja = 0
        Else
            entrada.filial_loja = txtFilial.Text
        End If

        If txtOS.Text = "" Then
            entrada.os_loja = 0
        Else
            entrada.os_loja = txtOS.Text
        End If

        MsgBox(entrada.Salvar)

        'Retorna o código de movimento após a inserção dos dados na tabela conferencia_nota_master
        codmovimento = notafiscal.busca_Codigo_Movimento(entrada.id_conferencia, conf.Filial)
        'Insere os dados na tabela nota_pedido

        lstNex.Enabled = True
        btnSalvar.Enabled = False
        txtQtde.Enabled = False
        txtObs.Enabled = False
        txtFilial.Enabled = False
        txtOS.Enabled = False
        cbReembolso.Enabled = False
        'novo = False
    End Sub
    Private Sub grdProd_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdProd.DoubleClick
        If entrada.concluido = "S" Then
            AVISO("Os produtos dessa nota já deram entrada no estoque, não é mais possível alterá-la!", Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End If
        Dim item
        Try
            item = grdProd.Item(grdProd.CurrentRowIndex, 0)
            MsgBox(entrada.atualiza_quantidade(item, InputBox("Digite a nova quantidade:")))
        Catch ex As Exception

        End Try

        carrega_grd()
    End Sub

    'Função responsável por buscar o preço de compra da lente e o preço de desconto
    Private Function busca_preco_lente(ByVal xCod_prod As Integer) As String
        Dim tt As New DataTable
        Dim sql As String
        Dim valor As String = ""

        ' Dim cod_lente As Integer
        sql = "Select p.cod_lente,lb.cod_lente,lb.cod_tabela, lt.preco_nota from produtos p  inner join lentes_blocos lb " &
            "on p.cod_lente = lb.cod_lente inner join lentes_tabela lt on lb.cod_tabela = lt.cod_tabela where cod_produto = " & xCod_prod


        '"Select cod_lente from produtos where cod_produto = " & xCod_prod
        d.carrega_Tabela(sql, tt)

        If tt.Rows(0)("preco_nota").ToString = Nothing Then
            tt.Rows(0)("preco_nota") = "0,00"
            valor = Convert.ToString(tt.Rows(0)("preco_nota"))
            atualiza_preco_tabela_lente(Convert.ToInt32(lblCodTabela.Text), valor)
            'atualiza_preco_tabela_lente2(Label7.Text, "0,00")
            'Else
            'Return tt.Rows(0)("preco_nota")
        End If

        Return tt.Rows(0)("preco_nota").ToString   '& "-" & tt.Rows(1)("cod_tabela")
    End Function

    'Função responsável por buscar o preço de compra da lente e o preço de desconto
    Private Function busca_preco_lente_optifogue(ByVal xCod_tabela As Integer) As String
        Dim tt As New DataTable
        Dim sql As String
        Dim valor As String = ""

        ' Dim cod_lente As Integer
        sql = "Select preco_nota from lentes_tabela where cod_tabela = " & xCod_tabela

        '"Select cod_lente from produtos where cod_produto = " & xCod_prod
        d.carrega_Tabela(sql, tt)

        If tt.Rows(0)("preco_nota").ToString = Nothing Then
            tt.Rows(0)("preco_nota") = "0,00"
            valor = Convert.ToString(tt.Rows(0)("preco_nota"))
            atualiza_preco_tabela_lente(Convert.ToInt32(lblCodTabela.Text), valor)
            'atualiza_preco_tabela_lente2(Label7.Text, "0,00")
            'Else
            'Return tt.Rows(0)("preco_nota")
        End If

        Return tt.Rows(0)("preco_nota").ToString   '& "-" & tt.Rows(1)("cod_tabela")
    End Function

    Private Function busca_desconto_lente(ByVal xCod_prod As Integer) As String
        Dim tt As New DataTable
        Dim sql As String
        Dim total_geral As Double

        ' Dim cod_lente As Integer
        sql = "Select p.cod_lente,lb.cod_lente,lb.cod_tabela, lt.preco_compra, lt.preco_nota, " &
            "sum((lt.preco_nota/lt.preco_compra) * 100) as Total from produtos p  inner join lentes_blocos lb " &
            "on p.cod_lente = lb.cod_lente inner join lentes_tabela lt on lb.cod_tabela = lt.cod_tabela where cod_produto = " & xCod_prod &
            " group by p.cod_lente, lb.cod_lente, lb.cod_tabela, lt.preco_compra, lt.preco_nota"
        '"Select cod_lente from produtos where cod_produto = " & xCod_prod
        d.carrega_Tabela(sql, tt)
        Try
            total_geral = FormatNumber(tt.Rows(0)("Total").ToString, 2)
        Catch ex As Exception
            total_geral = 0
        End Try
        '& "-" & tt.Rows(1)("cod_tabela")

        Return total_geral
    End Function

    Private Function busca_desconto_lente_optifogue(ByVal xCod_tabela As Integer) As String
        Dim tt As New DataTable
        Dim sql As String
        Dim total_geral As Double

        ' Dim cod_lente As Integer
        sql = "Select sum((preco_nota/preco_compra) * 100) as Total from lentes_tabela where cod_tabela = " & xCod_tabela

        '"Select cod_lente from produtos where cod_produto = " & xCod_prod
        d.carrega_Tabela(sql, tt)

        total_geral = FormatNumber(tt.Rows(0)("Total").ToString, 2)   '& "-" & tt.Rows(1)("cod_tabela")

        Return total_geral
    End Function

    'Função responsável por buscar o preço de compra na tabela lentes_tabela
    Private Function busca_preco(ByVal xCod_tab As Integer) As Double
        Dim tt As New DataTable
        Dim sql As String

        sql = "Select preco_compra from lentes_tabela where cod_tabela = " & xCod_tab

        d.carrega_Tabela(sql, tt)

        Return tt.Rows(0)("preco_compra").ToString
    End Function

    'Função responsável por buscar o preço de compra na tabela lentes_tabela
    Private Function busca_preco_nota(ByVal xCod_tab As Integer) As String
        Dim tt As New DataTable
        Dim sql As String

        sql = "Select preco_nota from lentes_tabela where cod_tabela = " & xCod_tab

        d.carrega_Tabela(sql, tt)

        Return tt.Rows(0)("preco_nota").ToString
    End Function

    Private Function busca_cod_tabela(ByVal xCod_prod As Integer) As Double
        Dim tt As New DataTable
        Dim sql As String
        ' Dim cod_lente As Integer
        sql = "Select p.cod_lente,lb.cod_lente,lb.cod_tabela, lt.preco_nota from produtos p  inner join lentes_blocos lb " &
            "on p.cod_lente = lb.cod_lente inner join lentes_tabela lt on lb.cod_tabela = lt.cod_tabela where cod_produto = " & xCod_prod

        d.carrega_Tabela(sql, tt)

        Return tt.Rows(0)("cod_tabela")
    End Function

    Private Sub AtualizarPreçoCompraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AtualizarPreçoCompraToolStripMenuItem.Click
        Dim valor As String
        Dim nvalor As Double

        If entrada.concluido = "S" Then
            AVISO("Os produtos dessa nota já deram entrada no estoque, não é mais possível alterá-la!", Me, frmAviso.tipo_aviso.tipo_ok)
            Exit Sub
        End If

        Try
            valor = InputBox("Digite o novo valor de compra:")

            nvalor = CDbl(valor)

            'Pega o valor da linha e coluna selecionada
            item = grdProd.Item(grdProd.CurrentRowIndex, 0)

            'Atualiza o preço de compra da tabela conferencia_nota
            entrada.atualiza_preco_compra(item, nvalor)
            entrada.atualiza_desconto_compra(item, nvalor, busca_preco(lblCodTabela_Atualiza.Text))
            MsgBox("Preço atualizado com sucesso.")

            'Atualiza o preço nota da tabela lentes_tabela
            atualiza_preco_tabela_lente(entrada.retorna_codigo_tabela(grdProd.Item(grdProd.CurrentRowIndex, 0)), nvalor)

            atualiza_desconto_tabela_lente(lblCodTabela_Atualiza.Text, busca_preco(lblCodTabela_Atualiza.Text), busca_preco_nota(lblCodTabela_Atualiza.Text))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        carrega_grd()
    End Sub

    'Função responsável por atualizar preço da nota na tabela lentes_tabela
    Public Function atualiza_preco_tabela_lente(ByVal xcod_tabela As Integer, ByVal preco As Double) As String
        Dim valor As String
        valor = preco
        Dim sql As String
        Dim r As String
        sql = "update lentes_tabela" &
        " set preco_nota = " & valor.Replace(",", ".") &
        " where (cod_tabela = " & xcod_tabela & ")"
        r = d.Comando(sql, True)
        Return r
    End Function

    'Função responsável por atualizar o preço de desconto da compra na tabela lentes_tabela
    Public Function atualiza_desconto_tabela_lente(ByVal xcod_tabela As Integer, ByVal preco As String, ByVal nota As String) As String
        Dim valor_nota As Double
        Dim valor_preco As Double
        Dim Total As Double
        Dim Total_Formato As String
        Dim Total_Geral As String
        valor_nota = CDbl(nota)
        valor_preco = CDbl(preco)
        Total = (valor_nota / valor_preco) * 100
        Total_Formato = FormatNumber(Total, 2)
        Total_Geral = Total_Formato.Replace(",", ".")

        Dim sql As String
        Dim r As String
        sql = "update lentes_tabela" &
        " set desconto_compra = " & Total_Geral &
        " where (cod_tabela = " & xcod_tabela & ")"
        r = d.Comando(sql, True)
        Return r
    End Function

    Private Sub grdProd_Click(sender As System.Object, e As System.EventArgs) Handles grdProd.Click
        lblCodTabela_Atualiza.Text = entrada.retorna_codigo_tabela(grdProd.Item(grdProd.CurrentRowIndex, 0))
    End Sub

    'Rotina responsável por montar o grid para armazenar a quantidade e o valor total da nota
    Private Sub grid_calculo()
        'instrução sql que traz os registros
        Dim strSQL As String = "SELECT id_item,quant, preco_nota, sum(quant * preco_nota) as total FROM conferencia_nota where " &
        "id_conferencia = " & entrada.id_conferencia & " and id_filial_nota = " &
        entrada.id_filial_nota & " group by id_item,quant, preco_nota"
        'conecta aos banco de dados
        d.conecta()
        'objeto de leitura dos valores retornados
        Dim dr As SqlDataReader

        'Cria a coluna quantidade
        Dim quantidade As New DataGridViewTextBoxColumn
        quantidade.HeaderText = "Quantidade"
        quantidade.Width = 60
        grdCalcula.Columns.Add(quantidade)

        'Cria a coluna Valor
        Dim valor As New DataGridViewTextBoxColumn
        valor.HeaderText = "Valor"
        valor.Width = 40
        grdCalcula.Columns.Add(valor)

        'Cria a coluna Total
        Dim total As New DataGridViewTextBoxColumn
        total.HeaderText = "Total"
        total.Width = 40
        grdCalcula.Columns.Add(total)

        d.carrega_reader(strSQL, dr)

        While dr.Read()
            grdCalcula.Rows.Add(dr.Item("quant"), dr.Item("preco_nota"), dr.Item("total"))
        End While

        dr.Close()
        d.desconecta()
    End Sub

    Private Sub espelho_nota()
        Dim rp As New rptEspelhoNotaManual
        Dim f As New frmRpt
        If cbReembolso.Checked = False Then
            rp.Label7.Text = "Entrada Manual no Estoque"
        Else
            rp.Label7.Text = "Reembolso de produto(s) da OS: " & txtOS.Text & " - " & "Loja: " & txtFilial.Text
        End If
        rp.TextBox4.Text = txtObs.Text
        rp.DataSource = entrada.lista_itens_espelho_nota(x_id_conferencia, confFilial)
        rp.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        f.Relat(rp)
        f.ShowDialog(Me)
    End Sub

    Public Function retorna_Chave_cod_lancamento(ByVal fld As String, ByVal tbl As String, ByVal criterio As String) As Long
        Dim tabela As New DataTable
        Dim sql As String
        Dim v As Long
        Dim d As New dados
        Try
            sql = "Select max(" & fld & ") as chave from " & tbl & " " & criterio
            d.carrega_Tabela(sql, tabela)
            If tabela.Rows.Count = 0 Then
                Return 1
                Exit Function
            End If
            If IsDBNull(tabela.Rows(0)("chave")) = True Then v = 0 Else v = tabela.Rows(0)("chave")
            Return v + 1
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        tabela.Dispose()
    End Function

    Private Function calculaitens(ByVal id_conferencia As Integer) As Integer
        Dim strSQL As String = ""
        Dim total As Integer
        strSQL = "select sum(quant) as total from conferencia_nota where id_conferencia = " & id_conferencia &
            " and id_filial_nota = " & conf.Filial

        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim dr As SqlDataReader

        Try
            d.conecta()
            dr = cmd.ExecuteReader
            dr.Read()
            total = CInt(dr("total").ToString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            dr.Close()
            d.desconecta()
        End Try
        Return total
    End Function

    Private Sub frmEntradaManualEstoque_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Procedimento 18 Entrada de Nota Estoque
        If novo = False Then
            entrada.carrega_nota(x_id_conferencia, x_filial)
            txtQtde.Text = entrada.quantidade
            txtObs.Text = entrada.observacao

            txtFilial.Text = entrada.filial_loja

            txtOS.Text = entrada.os_loja

            If entrada.reembolso = "S" Then
                cbReembolso.Checked = True
                cbReembolso.Enabled = False
            Else
                cbReembolso.Checked = False
                cbReembolso.Enabled = False
            End If

            notafiscal.status_movimento = notafiscal.busca_status_Movimento_Master(x_id_conferencia, x_filial)

            If notafiscal.status_movimento = "N" Then
                btnInvetario.Enabled = True
                grpDetalhes.Enabled = True
                txtQtde.Enabled = False
                btnSalvar.Enabled = False
                txtObs.Enabled = False
                grpDetalhes.Enabled = True
                grdProd.Enabled = True
                lstNex.Enabled = True
            Else
                txtQtde.Enabled = False
                btnSalvar.Enabled = False
                txtObs.Enabled = False
            End If

            carrega_grd()
        End If
    End Sub


    Private Sub CheckBox1_Click(sender As System.Object, e As System.EventArgs) Handles cbReembolso.Click, CheckBox1.Click
        If cbReembolso.Checked = True Then
            txtFilial.Enabled = True
            txtOS.Enabled = True
        End If
    End Sub
End Class

