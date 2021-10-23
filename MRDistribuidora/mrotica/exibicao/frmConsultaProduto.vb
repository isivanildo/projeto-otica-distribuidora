Imports mrotica_util
Imports MRUtil
Imports System.Collections.Generic

Public Class frmConsultaProduto
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCodTabela As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtDescricaoProd As TextBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents lblDescricao As Label
    Friend WithEvents grdProd As DataGridView
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaProduto))
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodTabela = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtDescricaoProd = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.grdProd = New System.Windows.Forms.DataGridView()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.BTSistemas.WaitForm1), True, True)
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFechar
        '
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.Location = New System.Drawing.Point(311, 407)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(88, 37)
        Me.btnFechar.TabIndex = 7
        Me.btnFechar.Text = "&Fechar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodTabela)
        Me.GroupBox1.Controls.Add(Me.lblCodigo)
        Me.GroupBox1.Controls.Add(Me.txtDescricaoProd)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.lblDescricao)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(690, 74)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros"
        '
        'txtCodTabela
        '
        Me.txtCodTabela.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTabela.Location = New System.Drawing.Point(116, 18)
        Me.txtCodTabela.Name = "txtCodTabela"
        Me.txtCodTabela.Size = New System.Drawing.Size(86, 23)
        Me.txtCodTabela.TabIndex = 5
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(5, 24)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(91, 13)
        Me.lblCodigo.TabIndex = 4
        Me.lblCodigo.Text = "Código da Tabela"
        '
        'txtDescricaoProd
        '
        Me.txtDescricaoProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDescricaoProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDescricaoProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricaoProd.Location = New System.Drawing.Point(116, 46)
        Me.txtDescricaoProd.Name = "txtDescricaoProd"
        Me.txtDescricaoProd.Size = New System.Drawing.Size(434, 23)
        Me.txtDescricaoProd.TabIndex = 2
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.Location = New System.Drawing.Point(569, 33)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(93, 37)
        Me.btnConsultar.TabIndex = 3
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(5, 52)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(95, 13)
        Me.lblDescricao.TabIndex = 1
        Me.lblDescricao.Text = "Descrição Produto"
        '
        'grdProd
        '
        Me.grdProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProd.Location = New System.Drawing.Point(10, 88)
        Me.grdProd.Name = "grdProd"
        Me.grdProd.RowHeadersVisible = False
        Me.grdProd.Size = New System.Drawing.Size(690, 309)
        Me.grdProd.TabIndex = 6
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'frmConsultaProduto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(712, 454)
        Me.Controls.Add(Me.grdProd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnFechar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Produto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim p As produtoClass
    Dim tb As DataTable
    Dim cli As New Cliente
    Public cod_prod As Integer = 0
    Public cod_lente As Integer = 0
    Public nome_prod As String
    Public codigoCliente As Integer
    Public filialCliente As Int32
    Dim produto As New Produto
    'Usada para montar o grid com os dados da consulta correta
    Public strTela As String = ""
    'Usada para identificar de ue formulário vem a solicitação para consulta
    Public strLocalConsulta As String = ""

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        SplashScreenManager1.ShowWaitForm()
        Dim strDescricao As String = txtDescricaoProd.Text

        tb = New DataTable

        If strLocalConsulta = "Produtos" Then
            p = New produtoClass
            If txtCodTabela.Text = "" Then
                strDescricao = strDescricao.Substring(0, strDescricao.IndexOf("-"))
                tb = p.ConsultarProdutoDescricao(strDescricao, strTela)
            Else
                tb = p.ConsultarProdutoTabela(txtCodTabela.Text, strTela)
            End If
        End If

        If strTela = "Consultar Produto" Then
            gridConsultaProduto()
        ElseIf strTela = "Localizar Produto" Then
            gridLocalizaProduto()
        ElseIf strTela = "Localizar Cliente" Then
            If cli.RetornaRegistroNome(strDescricao) = True Then
                tb = cli.tb
            End If
            gridLocalizaCliente()
        End If

        SplashScreenManager1.CloseWaitForm()
    End Sub
    Private Sub gridConsultaProduto()
        grdProd.Columns.Clear()
        grdProd.AllowUserToAddRows = False
        grdProd.AutoGenerateColumns = False
        grdProd.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdProd.ReadOnly = True
        grdProd.DataSource = Nothing

        Dim nomecomercial As New DataGridViewTextBoxColumn
        nomecomercial.DataPropertyName = "nome_lente"
        nomecomercial.HeaderText = "Poduto"
        nomecomercial.Width = 250
        grdProd.Columns.Add(nomecomercial)

        Dim descricao As New DataGridViewTextBoxColumn
        descricao.DataPropertyName = "produto"
        descricao.HeaderText = "Descrição Grade"
        descricao.Width = 360
        grdProd.Columns.Add(descricao)

        Dim idFabricante As New DataGridViewTextBoxColumn
        idFabricante.DataPropertyName = "id_fabricante"
        idFabricante.HeaderText = "Fab."
        idFabricante.Width = 30
        grdProd.Columns.Add(idFabricante)

        Dim codigo As New DataGridViewTextBoxColumn
        codigo.DataPropertyName = "cod_Lente"
        codigo.HeaderText = "C. Lente"
        codigo.Width = 70
        grdProd.Columns.Add(codigo)

        Dim codigoproduto As New DataGridViewTextBoxColumn
        codigoproduto.DataPropertyName = "cod_produto"
        codigoproduto.HeaderText = "cod. Prod."
        codigoproduto.Width = 100
        grdProd.Columns.Add(codigoproduto)

        grdProd.DataSource = tb
    End Sub

    Private Sub gridLocalizaProduto()
        grdProd.Columns.Clear()
        grdProd.AllowUserToAddRows = False
        grdProd.AutoGenerateColumns = False
        grdProd.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdProd.ReadOnly = True
        grdProd.DataSource = Nothing

        Dim nomecomercial As New DataGridViewTextBoxColumn
        nomecomercial.DataPropertyName = "nome_comercial"
        nomecomercial.HeaderText = "Poduto"
        nomecomercial.Width = 250
        grdProd.Columns.Add(nomecomercial)

        Dim descricao As New DataGridViewTextBoxColumn
        descricao.DataPropertyName = "nome_lente"
        descricao.HeaderText = "Nome da Lenta"
        descricao.Width = 360
        grdProd.Columns.Add(descricao)

        Dim idFabricante As New DataGridViewTextBoxColumn
        idFabricante.DataPropertyName = "id_fabricante"
        idFabricante.HeaderText = "Fab."
        idFabricante.Width = 30
        grdProd.Columns.Add(idFabricante)

        Dim codigo As New DataGridViewTextBoxColumn
        codigo.DataPropertyName = "cod_Lente"
        codigo.HeaderText = "C. Lente"
        codigo.Width = 70
        grdProd.Columns.Add(codigo)

        grdProd.DataSource = tb
    End Sub

    Private Sub gridLocalizaCliente()
        grdProd.Columns.Clear()
        grdProd.AllowUserToAddRows = False
        grdProd.AutoGenerateColumns = False
        grdProd.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdProd.ReadOnly = True
        grdProd.DataSource = Nothing

        Dim codigofilial As New DataGridViewTextBoxColumn
        codigofilial.DataPropertyName = "cod_filial_cliente"
        codigofilial.HeaderText = "Filial"
        codigofilial.Width = 60
        codigofilial.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdProd.Columns.Add(codigofilial)

        Dim codigocliente As New DataGridViewTextBoxColumn
        codigocliente.DataPropertyName = "cod_cliente"
        codigocliente.HeaderText = "Código"
        codigocliente.Width = 60
        grdProd.Columns.Add(codigocliente)

        Dim nomecliente As New DataGridViewTextBoxColumn
        nomecliente.DataPropertyName = "nome_cliente"
        nomecliente.HeaderText = "Nome"
        nomecliente.Width = 300
        grdProd.Columns.Add(nomecliente)

        Dim cpfcnpj As New DataGridViewTextBoxColumn
        cpfcnpj.DataPropertyName = "cnpj"
        cpfcnpj.HeaderText = "CPF/CNPJ"
        cpfcnpj.Width = 120
        grdProd.Columns.Add(cpfcnpj)

        grdProd.DataSource = tb
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Try
            Dim indice As Integer = grdProd.CurrentRow.Index
            If strLocalConsulta = "Produtos" Then
                nome_prod = grdProd.Rows(indice).Cells(0).Value
                cod_lente = grdProd.Rows(indice).Cells(3).Value
                If strTela = "Consultar Produto" Then
                    cod_prod = grdProd.Rows(indice).Cells(4).Value
                End If
            ElseIf strLocalConsulta = "Clientes" Then
                filialCliente = grdProd.Rows(indice).Cells(0).Value
                codigoCliente = grdProd.Rows(indice).Cells(1).Value
            End If

            Me.Close()
        Catch ex As Exception
            cod_prod = 0
            nome_prod = ""
        End Try

    End Sub

    Private Sub frmConsultaProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim teste As New Produto
        If strLocalConsulta = "Produtos" Then
            txtDescricaoProd.AutoCompleteCustomSource = teste.CarregaListaProduto()
        ElseIf strLocalConsulta = "Clientes" Then
            txtDescricaoProd.AutoCompleteCustomSource = teste.CarregaListaCliente()
        End If

    End Sub

    Private Sub frmConsultaProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

End Class
