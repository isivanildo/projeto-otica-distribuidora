Imports mrotica_util
Public Class frmCompra
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
    Friend WithEvents grpNota As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbFabricante As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalvarNota As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQuant As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPrecoTabela As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grpDetalhes As System.Windows.Forms.GroupBox
    Friend WithEvents grdMov As System.Windows.Forms.DataGrid
    Friend WithEvents btnSalvarItem As System.Windows.Forms.Button
    Friend WithEvents lblPrecoDesconto As System.Windows.Forms.Label
    Friend WithEvents lblDiferenca As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPreco As System.Windows.Forms.TextBox
    Friend WithEvents txtDesconto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents txtIpi As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIcms As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDescontoTabela As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompra))
        Me.grpNota = New System.Windows.Forms.GroupBox()
        Me.btnSalvarNota = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDoc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFabricante = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpDetalhes = New System.Windows.Forms.GroupBox()
        Me.txtIpi = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIcms = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.lblDiferenca = New System.Windows.Forms.Label()
        Me.lblPrecoDesconto = New System.Windows.Forms.Label()
        Me.btnSalvarItem = New System.Windows.Forms.Button()
        Me.txtDescontoTabela = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrecoTabela = New System.Windows.Forms.TextBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQuant = New System.Windows.Forms.TextBox()
        Me.grdMov = New System.Windows.Forms.DataGrid()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grpNota.SuspendLayout()
        Me.grpDetalhes.SuspendLayout()
        CType(Me.grdMov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpNota
        '
        Me.grpNota.Controls.Add(Me.btnSalvarNota)
        Me.grpNota.Controls.Add(Me.Label3)
        Me.grpNota.Controls.Add(Me.txtDoc)
        Me.grpNota.Controls.Add(Me.Label2)
        Me.grpNota.Controls.Add(Me.dtData)
        Me.grpNota.Controls.Add(Me.Label1)
        Me.grpNota.Controls.Add(Me.cbFabricante)
        Me.grpNota.Location = New System.Drawing.Point(8, 8)
        Me.grpNota.Name = "grpNota"
        Me.grpNota.Size = New System.Drawing.Size(680, 56)
        Me.grpNota.TabIndex = 6
        Me.grpNota.TabStop = False
        Me.grpNota.Text = "Dados da Nota"
        '
        'btnSalvarNota
        '
        Me.btnSalvarNota.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalvarNota.Location = New System.Drawing.Point(432, 16)
        Me.btnSalvarNota.Name = "btnSalvarNota"
        Me.btnSalvarNota.Size = New System.Drawing.Size(128, 32)
        Me.btnSalvarNota.TabIndex = 3
        Me.btnSalvarNota.Text = "Salvar"
        Me.btnSalvarNota.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(320, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Documento"
        '
        'txtDoc
        '
        Me.txtDoc.Location = New System.Drawing.Point(320, 28)
        Me.txtDoc.Name = "txtDoc"
        Me.txtDoc.Size = New System.Drawing.Size(100, 20)
        Me.txtDoc.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(208, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Data"
        '
        'dtData
        '
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(208, 28)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(88, 20)
        Me.dtData.TabIndex = 1
        Me.dtData.Value = New Date(2007, 2, 8, 10, 44, 12, 99)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fornecedor"
        '
        'cbFabricante
        '
        Me.cbFabricante.ItemHeight = 13
        Me.cbFabricante.Location = New System.Drawing.Point(16, 28)
        Me.cbFabricante.Name = "cbFabricante"
        Me.cbFabricante.Size = New System.Drawing.Size(160, 21)
        Me.cbFabricante.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'grpDetalhes
        '
        Me.grpDetalhes.BackColor = System.Drawing.Color.White
        Me.grpDetalhes.Controls.Add(Me.txtIpi)
        Me.grpDetalhes.Controls.Add(Me.Label10)
        Me.grpDetalhes.Controls.Add(Me.Label11)
        Me.grpDetalhes.Controls.Add(Me.txtIcms)
        Me.grpDetalhes.Controls.Add(Me.btnImprimir)
        Me.grpDetalhes.Controls.Add(Me.txtDesconto)
        Me.grpDetalhes.Controls.Add(Me.Label9)
        Me.grpDetalhes.Controls.Add(Me.Label8)
        Me.grpDetalhes.Controls.Add(Me.txtPreco)
        Me.grpDetalhes.Controls.Add(Me.lblDiferenca)
        Me.grpDetalhes.Controls.Add(Me.lblPrecoDesconto)
        Me.grpDetalhes.Controls.Add(Me.btnSalvarItem)
        Me.grpDetalhes.Controls.Add(Me.txtDescontoTabela)
        Me.grpDetalhes.Controls.Add(Me.Label6)
        Me.grpDetalhes.Controls.Add(Me.txtPrecoTabela)
        Me.grpDetalhes.Controls.Add(Me.lblProduto)
        Me.grpDetalhes.Controls.Add(Me.txtCodProd)
        Me.grpDetalhes.Controls.Add(Me.Label4)
        Me.grpDetalhes.Controls.Add(Me.txtQuant)
        Me.grpDetalhes.Controls.Add(Me.grdMov)
        Me.grpDetalhes.Controls.Add(Me.Label7)
        Me.grpDetalhes.Controls.Add(Me.Label5)
        Me.grpDetalhes.Location = New System.Drawing.Point(8, 64)
        Me.grpDetalhes.Name = "grpDetalhes"
        Me.grpDetalhes.Size = New System.Drawing.Size(680, 387)
        Me.grpDetalhes.TabIndex = 7
        Me.grpDetalhes.TabStop = False
        Me.grpDetalhes.Text = "Itens da Nota"
        '
        'txtIpi
        '
        Me.txtIpi.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIpi.Location = New System.Drawing.Point(129, 42)
        Me.txtIpi.Name = "txtIpi"
        Me.txtIpi.Size = New System.Drawing.Size(47, 20)
        Me.txtIpi.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(96, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 20)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "ipi"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(11, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 20)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Icms"
        '
        'txtIcms
        '
        Me.txtIcms.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIcms.Location = New System.Drawing.Point(49, 42)
        Me.txtIcms.Name = "txtIcms"
        Me.txtIcms.Size = New System.Drawing.Size(32, 20)
        Me.txtIcms.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprimir.Location = New System.Drawing.Point(274, 353)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(128, 32)
        Me.btnImprimir.TabIndex = 10
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'txtDesconto
        '
        Me.txtDesconto.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtDesconto.Location = New System.Drawing.Point(458, 42)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.ReadOnly = True
        Me.txtDesconto.Size = New System.Drawing.Size(72, 20)
        Me.txtDesconto.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(366, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Desc. Real %"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(233, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "P. Nota"
        '
        'txtPreco
        '
        Me.txtPreco.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPreco.Location = New System.Drawing.Point(288, 42)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(72, 20)
        Me.txtPreco.TabIndex = 6
        '
        'lblDiferenca
        '
        Me.lblDiferenca.Location = New System.Drawing.Point(536, 42)
        Me.lblDiferenca.Name = "lblDiferenca"
        Me.lblDiferenca.Size = New System.Drawing.Size(74, 14)
        Me.lblDiferenca.TabIndex = 22
        '
        'lblPrecoDesconto
        '
        Me.lblPrecoDesconto.Location = New System.Drawing.Point(536, 16)
        Me.lblPrecoDesconto.Name = "lblPrecoDesconto"
        Me.lblPrecoDesconto.Size = New System.Drawing.Size(76, 16)
        Me.lblPrecoDesconto.TabIndex = 21
        '
        'btnSalvarItem
        '
        Me.btnSalvarItem.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalvarItem.Location = New System.Drawing.Point(616, 16)
        Me.btnSalvarItem.Name = "btnSalvarItem"
        Me.btnSalvarItem.Size = New System.Drawing.Size(56, 24)
        Me.btnSalvarItem.TabIndex = 9
        Me.btnSalvarItem.Text = "Salvar"
        Me.btnSalvarItem.UseVisualStyleBackColor = False
        '
        'txtDescontoTabela
        '
        Me.txtDescontoTabela.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtDescontoTabela.Location = New System.Drawing.Point(458, 16)
        Me.txtDescontoTabela.Name = "txtDescontoTabela"
        Me.txtDescontoTabela.ReadOnly = True
        Me.txtDescontoTabela.Size = New System.Drawing.Size(72, 20)
        Me.txtDescontoTabela.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(230, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "P. Tabela"
        '
        'txtPrecoTabela
        '
        Me.txtPrecoTabela.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPrecoTabela.Location = New System.Drawing.Point(288, 16)
        Me.txtPrecoTabela.Name = "txtPrecoTabela"
        Me.txtPrecoTabela.ReadOnly = True
        Me.txtPrecoTabela.Size = New System.Drawing.Size(72, 20)
        Me.txtPrecoTabela.TabIndex = 5
        '
        'lblProduto
        '
        Me.lblProduto.Location = New System.Drawing.Point(8, 65)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(408, 16)
        Me.lblProduto.TabIndex = 16
        '
        'txtCodProd
        '
        Me.txtCodProd.Location = New System.Drawing.Point(129, 16)
        Me.txtCodProd.MaxLength = 12
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(80, 20)
        Me.txtCodProd.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Quant."
        '
        'txtQuant
        '
        Me.txtQuant.BackColor = System.Drawing.Color.White
        Me.txtQuant.Location = New System.Drawing.Point(49, 16)
        Me.txtQuant.Name = "txtQuant"
        Me.txtQuant.ReadOnly = True
        Me.txtQuant.Size = New System.Drawing.Size(32, 20)
        Me.txtQuant.TabIndex = 1
        Me.txtQuant.Text = "1"
        '
        'grdMov
        '
        Me.grdMov.CaptionVisible = False
        Me.grdMov.DataMember = ""
        Me.grdMov.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdMov.Location = New System.Drawing.Point(8, 89)
        Me.grdMov.Name = "grdMov"
        Me.grdMov.ReadOnly = True
        Me.grdMov.Size = New System.Drawing.Size(664, 264)
        Me.grdMov.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(366, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Desc. Tabela %"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(84, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Produto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(492, 470)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "ICMS"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(527, 468)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(527, 486)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(501, 488)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "IPI"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(527, 502)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(490, 504)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Total"
        '
        'frmCompra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(696, 534)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.grpDetalhes)
        Me.Controls.Add(Me.grpNota)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCompra"
        Me.Text = "frmCompra"
        Me.grpNota.ResumeLayout(False)
        Me.grpNota.PerformLayout()
        Me.grpDetalhes.ResumeLayout(False)
        Me.grpDetalhes.PerformLayout()
        CType(Me.grdMov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim tbFab As New DataTable
    Dim tbMov As New DataTable
    Dim d As New dados
    Dim cp As New objcompras
    Public NOVO As Boolean = False
    Dim p As New produtoClass
    Dim mov As New objMovimentoDetalhe
    Dim conf As New config
#Region "Load, Carrega dados"
    Private Sub frmCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_combos()
        If NOVO = False Then
            cp = New objcompras(InputBox("Compra:"))
            abre_compra()
        End If
        formata_grid()
    End Sub
    Private Sub carrega_combos()
        Dim tbFab As New DataTable
        Dim tbTipo As New DataTable
        Dim tbMat As New DataTable
        d.carrega_Tabela("Select * from fornecedor", tbFab)
        cbFabricante.DataSource = tbFab
        cbFabricante.DisplayMember = "fornecedor"
        cbFabricante.ValueMember = "cod_fornecedor"
    End Sub
    Private Sub formata_grid()
        tbMov = mov.lista_compra(cp.cod_movimento, cp.id_filial)
        Dim TStb As New DataGridTableStyle
        grdMov.DataSource = tbMov
        TStb.MappingName = grdMov.DataSource.tablename

        Dim cItem As New DataGridTextBoxColumn
        With cItem
            .MappingName = "item"
            .HeaderText = "item"
            .Width = 30
        End With
        TStb.GridColumnStyles.Add(cItem)

        Dim cProd As New DataGridTextBoxColumn
        With cProd
            .MappingName = "produto"
            .HeaderText = "Produto"
            .Width = 400
        End With
        TStb.GridColumnStyles.Add(cProd)


        Dim cPunit As New DataGridTextBoxColumn
        With cPunit
            .MappingName = "pUnit"
            .HeaderText = "p. unit."
            .Alignment = HorizontalAlignment.Right
            .Format = "#,##0.00"
            .Width = 50
        End With
        TStb.GridColumnStyles.Add(cPunit)

        Dim cQuant As New DataGridTextBoxColumn
        With cQuant
            .MappingName = "quant"
            .HeaderText = "Quant"
            .Width = 40
        End With
        TStb.GridColumnStyles.Add(cQuant)

        Dim cPdesc As New DataGridTextBoxColumn
        With cPdesc
            .MappingName = "pDesc"
            .HeaderText = "P. Desc."
            .Alignment = HorizontalAlignment.Right
            .Format = "#,##0.00"
            .Width = 50
        End With
        TStb.GridColumnStyles.Add(cPdesc)

        Dim cptotDesc As New DataGridTextBoxColumn
        With cptotDesc
            .MappingName = "ptotDesc"
            .HeaderText = "Total."
            .Alignment = HorizontalAlignment.Right
            .Format = "#,##0.00"
            .Width = 50
        End With
        TStb.GridColumnStyles.Add(cptotDesc)
        grdMov.TableStyles.Clear()
        grdMov.TableStyles.Add(TStb)
    End Sub
    Private Sub abre_compra()
        cbFabricante.SelectedValue = cp.cod_fornecedor
        dtData.Value = cp.data
        txtDoc.Text = cp.doc
        mov.abre_movimento(cp.cod_movimento, cp.id_filial)
        grdMov_CurrentCellChanged(Me, Nothing)
    End Sub
#End Region
    Private Sub btnSalvarNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarNota.Click
        If NOVO = True Then inserenota()
    End Sub
    Private Sub inserenota()
        cp.novo()
        cp.cod_fornecedor = cbFabricante.SelectedValue
        cp.data = dtData.Value
        cp.doc = txtDoc.Text
        MsgBox(cp.Salvar())
        NOVO = False
        grpDetalhes.Enabled = True 'Desbloqueia os controles de adição de produtos
    End Sub
    Private Sub busca_produto()
        If txtCodProd.Text.Length > 10 Then
            txtCodProd.Text = ""
            txtCodProd.Focus()
            Exit Sub
        End If
        If txtCodProd.Text = "0" Then
            lblProduto.Text = ""
            Exit Sub
        End If
        If txtCodProd.Text = "" Then GoTo consulta
Consulta_cod:
        p.Source("Select * from produtos where cod_produto = " & txtCodProd.Text & "")
        If p.max = 1 Then
            lblProduto.Text = p.fldProduto
            txtPrecoTabela.Text = p.Preco_compra
            txtDescontoTabela.Text = p.Desconto_compra
            desconto(p.Preco_compra, p.Desconto_compra)
            txtPreco.Text = lblPrecoDesconto.Text / txtQuant.Text
            txtDesconto.Text = p.Desconto_compra
            Dim t As New DataTable
            d.carrega_Tabela("select * from diferenca_desconto where cod_movimento = " & _
            mov.cod_movimento & " and id_filial = " & mov.id_filial & " and cod_lancamento = " & _
            mov.cod_lancamento & "", t)
            If t.Rows.Count > 0 Then
                txtPreco.Text = t.Rows(0)("Preco_real")
                txtDesconto.Text = t.Rows(0)("desconto")
            End If
            Exit Sub
        Else
            Dim ret As String
            ret = p.Retorna_cod_prod(txtCodProd.Text)
            If ret <> "0" Then
                txtCodProd.Text = ret
                GoTo Consulta_cod
            Else
                GoTo consulta
            End If
        End If

consulta:
        Dim f As New frmConsultaProduto
        f.ShowDialog(Me)
        txtCodProd.Text = f.cod_prod
        f.Dispose()
        GoTo Consulta_cod
    End Sub
    Private Sub desconto(ByVal preco As Double, ByVal desc As Double)
        Dim final As Double
        Dim preco_tabela As Double
        final = CDbl(txtQuant.Text) * (preco - (preco * (desc / 100)))
        preco_tabela = CDbl(txtQuant.Text) * (p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100)))
        lblPrecoDesconto.Text = final
        lblDiferenca.Text = cdinShow(preco_tabela - final)
    End Sub
    Private Sub btnSalvarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarItem.Click
        If txtCodProd.Text = "" Or txtCodProd.Text = "0" Then
            txtCodProd.Focus()
            Exit Sub
        End If
        Dim media_len, media_prod As Double
        Dim cod_len As Integer
        mov.editar()
        'mov.item = mov.ret_ultimo_item(cp.cod_movimento)
        mov.cod_movimento = cp.cod_movimento
        mov.cod_produto = txtCodProd.Text
        mov.quant = txtQuant.Text
        mov.desconto = txtDescontoTabela.Text
        mov.pUnit = txtPrecoTabela.Text
        mov.estoqueFis = mov.ret_saldo_fisico(txtCodProd.Text) + CDbl(txtQuant.Text)
        mov.estoqueFin = mov.estoqueFis * ((txtPrecoTabela.Text - (txtPrecoTabela.Text * (txtDescontoTabela.Text / 100))))
        '( + mov.ret_saldo_fin(txtCodProd.Text)
        cod_len = mov.retorna_cod_lentebloco(txtCodProd.Text)
        media_len = media_movel(mov.ret_saldo_todos_fisico(cod_len), mov.ret_saldo_todos_fin(cod_len), txtQuant.Text, (txtPrecoTabela.Text) - (txtPrecoTabela.Text * (txtDescontoTabela.Text / 100)))
        media_prod = media_movel(mov.ret_saldo_fisico(txtCodProd.Text), mov.ret_saldo_fin(txtCodProd.Text), txtQuant.Text, (txtPrecoTabela.Text) - (txtPrecoTabela.Text * (txtDescontoTabela.Text / 100)))
        'MsgBox(mov.ret_saldo_todos_fisico(cod_len) & "-" & mov.ret_saldo_todos_fin(cod_len) & "-" & txtQuant.Text & "-" & (txtPrecoTabela.Text) - (txtPrecoTabela.Text * (txtDescontoTabela.Text / 100)))
        mov.atualiza_custo(cod_len, media_len, txtCodProd.Text, media_prod)
        mov.historico = "Compra conforme Doc. " & txtDoc.Text & ""
        mov.icms = txtIcms.Text
        mov.ipi = txtIpi.Text
        MsgBox(mov.Salvar())
        mov.diferenca_desconto(mov.cod_movimento, mov.cod_lancamento, conf.Filial, txtDesconto.Text, lblDiferenca.Text, txtPreco.Text)
        formata_grid()
    End Sub
    Private Sub txtCodProd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodProd.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                busca_produto()
        End Select
    End Sub
    Private Sub txtDesconto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescontoTabela.LostFocus
        'desconto(txtPrecoTabela.Text, txtDescontoTabela.Text)
    End Sub
    Private Sub txtPreco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPreco.TextChanged
        Try
            'txtDesconto.Text = Format((((txtPreco.Text - txtPrecoTabela.Text) / (txtPrecoTabela.Text)) * 100 * -1), "#,##0.00")
            txtDesconto.Text = (((txtPreco.Text - txtPrecoTabela.Text) / (txtPrecoTabela.Text)) * 100 * -1)
            lblDiferenca.Text = (txtPreco.Text - (lblPrecoDesconto.Text / txtQuant.Text))
        Catch ex As Exception

        End Try

    End Sub
    Private Sub grdMov_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdMov.CurrentCellChanged
        Dim i As Integer
        Try
            i = grdMov.CurrentRowIndex
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        mov.Registro(i)
        txtCodProd.Text = mov.cod_produto
        txtQuant.Text = mov.quant
        busca_produto()
        txtIcms.Text = mov.icms
        txtIpi.Text = mov.ipi
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim rp As New rptCompra
        Dim fr As New frmRpt
        rp.DataSource = cp.listar_detalhes_compra_dif
        fr.Relat(rp)
        fr.ShowDialog(Me)
        fr.Dispose()
        rp.Dispose()
    End Sub
End Class
