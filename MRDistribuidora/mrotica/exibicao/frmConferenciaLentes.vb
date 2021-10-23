Imports mrotica_util
Public Class frmConferenciaLentes
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
    Friend WithEvents btnLimpa As System.Windows.Forms.Button
    Friend WithEvents txtCodBarra As System.Windows.Forms.TextBox
    Friend WithEvents btnRelat As System.Windows.Forms.Button
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents dtCont As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstNex As System.Windows.Forms.ListBox
    Friend WithEvents txtGaveta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRelatCaixa As System.Windows.Forms.Button
    Friend WithEvents btnLimpaCaixa As System.Windows.Forms.Button
    Friend WithEvents btnExcluiItem As System.Windows.Forms.Button
    Friend WithEvents btnCadBarra As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnInventario As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrepararAjuste As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents pb As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents grdProd As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConferenciaLentes))
        Me.txtCodBarra = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.dtCont = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstNex = New System.Windows.Forms.ListBox()
        Me.txtGaveta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnInventario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrepararAjuste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.pb = New System.Windows.Forms.ToolStripProgressBar()
        Me.grdProd = New System.Windows.Forms.DataGrid()
        Me.btnCadBarra = New System.Windows.Forms.Button()
        Me.btnExcluiItem = New System.Windows.Forms.Button()
        Me.btnLimpaCaixa = New System.Windows.Forms.Button()
        Me.btnRelatCaixa = New System.Windows.Forms.Button()
        Me.btnRelat = New System.Windows.Forms.Button()
        Me.btnLimpa = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodBarra
        '
        Me.txtCodBarra.Location = New System.Drawing.Point(623, 66)
        Me.txtCodBarra.Name = "txtCodBarra"
        Me.txtCodBarra.Size = New System.Drawing.Size(120, 20)
        Me.txtCodBarra.TabIndex = 3
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(8, 66)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(419, 20)
        Me.txtDesc.TabIndex = 0
        '
        'lblDesc
        '
        Me.lblDesc.Location = New System.Drawing.Point(8, 49)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(100, 16)
        Me.lblDesc.TabIndex = 9
        Me.lblDesc.Text = "Título do Relatório"
        '
        'dtCont
        '
        Me.dtCont.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCont.Location = New System.Drawing.Point(438, 66)
        Me.dtCont.Name = "dtCont"
        Me.dtCont.Size = New System.Drawing.Size(88, 20)
        Me.dtCont.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(438, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Data"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(623, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Código de Barras:"
        '
        'lstNex
        '
        Me.lstNex.FormattingEnabled = True
        Me.lstNex.Location = New System.Drawing.Point(647, 159)
        Me.lstNex.Name = "lstNex"
        Me.lstNex.Size = New System.Drawing.Size(120, 420)
        Me.lstNex.TabIndex = 11
        '
        'txtGaveta
        '
        Me.txtGaveta.Location = New System.Drawing.Point(536, 66)
        Me.txtGaveta.Name = "txtGaveta"
        Me.txtGaveta.Size = New System.Drawing.Size(77, 20)
        Me.txtGaveta.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(536, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Gaveta / Caixa:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnInventario, Me.ToolStripSeparator1, Me.btnPrepararAjuste, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(771, 39)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnInventario
        '
        Me.btnInventario.Image = CType(resources.GetObject("btnInventario.Image"), System.Drawing.Image)
        Me.btnInventario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(119, 36)
        Me.btnInventario.Text = "Estoque Inicial"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnPrepararAjuste
        '
        Me.btnPrepararAjuste.Image = CType(resources.GetObject("btnPrepararAjuste.Image"), System.Drawing.Image)
        Me.btnPrepararAjuste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrepararAjuste.Name = "btnPrepararAjuste"
        Me.btnPrepararAjuste.Size = New System.Drawing.Size(123, 36)
        Me.btnPrepararAjuste.Text = "Preparar Ajuste"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pb})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 585)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(771, 25)
        Me.ToolStrip2.TabIndex = 24
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'pb
        '
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(400, 22)
        '
        'grdProd
        '
        Me.grdProd.DataMember = ""
        Me.grdProd.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdProd.Location = New System.Drawing.Point(8, 159)
        Me.grdProd.Name = "grdProd"
        Me.grdProd.Size = New System.Drawing.Size(632, 420)
        Me.grdProd.TabIndex = 10
        '
        'btnCadBarra
        '
        Me.btnCadBarra.Image = CType(resources.GetObject("btnCadBarra.Image"), System.Drawing.Image)
        Me.btnCadBarra.Location = New System.Drawing.Point(607, 114)
        Me.btnCadBarra.Name = "btnCadBarra"
        Me.btnCadBarra.Size = New System.Drawing.Size(155, 33)
        Me.btnCadBarra.TabIndex = 9
        Me.btnCadBarra.Text = "Cad. Codigo de Barra"
        Me.btnCadBarra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnExcluiItem
        '
        Me.btnExcluiItem.Image = CType(resources.GetObject("btnExcluiItem.Image"), System.Drawing.Image)
        Me.btnExcluiItem.Location = New System.Drawing.Point(484, 114)
        Me.btnExcluiItem.Name = "btnExcluiItem"
        Me.btnExcluiItem.Size = New System.Drawing.Size(120, 33)
        Me.btnExcluiItem.TabIndex = 8
        Me.btnExcluiItem.Text = "Eliminar um item"
        Me.btnExcluiItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnLimpaCaixa
        '
        Me.btnLimpaCaixa.Image = CType(resources.GetObject("btnLimpaCaixa.Image"), System.Drawing.Image)
        Me.btnLimpaCaixa.Location = New System.Drawing.Point(341, 114)
        Me.btnLimpaCaixa.Name = "btnLimpaCaixa"
        Me.btnLimpaCaixa.Size = New System.Drawing.Size(139, 33)
        Me.btnLimpaCaixa.TabIndex = 7
        Me.btnLimpaCaixa.Text = "Limpa Gaveta / Caixa"
        Me.btnLimpaCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnRelatCaixa
        '
        Me.btnRelatCaixa.Image = CType(resources.GetObject("btnRelatCaixa.Image"), System.Drawing.Image)
        Me.btnRelatCaixa.Location = New System.Drawing.Point(171, 114)
        Me.btnRelatCaixa.Name = "btnRelatCaixa"
        Me.btnRelatCaixa.Size = New System.Drawing.Size(166, 33)
        Me.btnRelatCaixa.TabIndex = 6
        Me.btnRelatCaixa.Text = "Relatorio Gaveta / Caixa"
        Me.btnRelatCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnRelat
        '
        Me.btnRelat.Image = CType(resources.GetObject("btnRelat.Image"), System.Drawing.Image)
        Me.btnRelat.Location = New System.Drawing.Point(11, 114)
        Me.btnRelat.Name = "btnRelat"
        Me.btnRelat.Size = New System.Drawing.Size(78, 33)
        Me.btnRelat.TabIndex = 4
        Me.btnRelat.Text = "Relatorio"
        Me.btnRelat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnLimpa
        '
        Me.btnLimpa.Image = CType(resources.GetObject("btnLimpa.Image"), System.Drawing.Image)
        Me.btnLimpa.Location = New System.Drawing.Point(92, 114)
        Me.btnLimpa.Name = "btnLimpa"
        Me.btnLimpa.Size = New System.Drawing.Size(75, 33)
        Me.btnLimpa.TabIndex = 5
        Me.btnLimpa.Text = "Limpa"
        Me.btnLimpa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'frmConferenciaLentes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(771, 610)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnCadBarra)
        Me.Controls.Add(Me.btnExcluiItem)
        Me.Controls.Add(Me.btnLimpaCaixa)
        Me.Controls.Add(Me.btnRelatCaixa)
        Me.Controls.Add(Me.txtGaveta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstNex)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtCont)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.btnRelat)
        Me.Controls.Add(Me.txtCodBarra)
        Me.Controls.Add(Me.btnLimpa)
        Me.Controls.Add(Me.grdProd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConferenciaLentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conferência de Lentes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim tb As New DataTable
    Dim tbCont As New DataTable
    Dim d As New dados()
    Dim p As New produtoClass
    Dim user As New objUsuario(UserID)
    Public conf As New config
    Dim mov As New objMovimentoDetalhe
    Dim chave_movimento As Integer
    Dim acesso As New objMaster
    Dim intUsuario As Integer

    Private Sub frmConferenciaLentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Procedimento 16 Contagem Estoque 
        carrega_grd()
    End Sub
    Private Sub carrega_Contagem()
        Dim sql As String
    End Sub
    Private Sub carrega_grd()
        Dim sql As String
        Dim TStb As New DataGridTableStyle
        sql = "SELECT produtos.produto, produtos.cod_barra, SUM(conferencia_detalhes.quant) AS quantidade " &
        "FROM   conferencia_detalhes INNER JOIN " &
        "produtos ON conferencia_detalhes.cod_produto = produtos.cod_produto INNER JOIN " &
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND produtos.id_fabricante = lentes_blocos.id_fabricante " &
        "Where conferencia_detalhes.id_conferencia = 1 " &
        " GROUP BY  produtos.cod_barra,produtos.produto"
        d.carrega_Tabela(sql, tb)
        grdProd.DataSource = tb
        tb.Columns.Add("i")
        tb.Columns("i").DefaultValue = False
        grdProd.DataSource = tb
        TStb.MappingName = grdProd.DataSource.tablename
        Dim cItem As New DataGridTextBoxColumn
        With cItem
            .MappingName = "produto"
            .HeaderText = "Produto"
            .Width = 450
        End With
        TStb.GridColumnStyles.Add(cItem)

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
        End With
        TStb.GridColumnStyles.Add(quant)

        grdProd.TableStyles.Clear()
        grdProd.TableStyles.Add(TStb)
    End Sub
    Private Sub btnLimpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpa.Click
        If MessageBox.Show("Deseja excluir toda a contagem?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            d.Comando("Delete from conferencia_detalhes", False)
            carrega_grd()
            lstNex.Items.Clear()
            txtCodBarra.Focus()
        End If
    End Sub
    Private Sub txtCodBarra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodBarra.KeyDown
        Dim RES As String
        Select Case e.KeyCode
            Case Keys.Enter
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
        es = InputBox("Digite o tipo B para bloco e L para lente pronta!")
        If es.ToString.Trim.ToUpper <> "L" And es.ToString.ToUpper <> "B" Then
            som_erro()
            MsgBox("Erro!")
            Exit Sub
        End If
        'Se o produto for Lente pronta, abre o formulário 
        'de lente.
        If es = "L" Then
            f.tipo = "L"
            f.ShowDialog(Me)
            cod_prod = f.Result
        Else
            'Se o produto for bloco, abre o formulário 
            'de bloco.
            f.tipo = "B"
            f.ShowDialog(Me)
            cod_prod = f.Result
        End If
        sql = "Insert into conferencia_detalhes(id_conferencia,cod_produto,quant,gaveta) values(" &
                    "1," & cod_prod & ",1," & d.PStr(txtGaveta.Text) & ")"
        res = d.Comando(sql, False)

        If res.StartsWith("OK") Then
            som_ok()
        Else
            MsgBox(res)
            AVISO(res, Me, frmAviso.tipo_aviso.tipo_ok, True)
        End If
        carrega_grd()
        txtCodBarra.Focus()
    End Sub
    Private Sub processa_barra()
        Dim res As String
        Dim sql As String
        p.filtraBarras(txtCodBarra.Text)
        'tb = p.Consultar_produtos_barra(txtCodBarra.Text)
        If p.max > 0 Then
            sql = "Insert into conferencia_detalhes(id_conferencia,cod_produto,quant,gaveta) values(" &
            "1," & p.fldCod_produto & ",1," & d.PStr(txtGaveta.Text) & ")"
            res = d.Comando(sql, False)

            If res.StartsWith("OK") Then
                som_ok()
            Else
                MsgBox(res)
                AVISO(res, Me, frmAviso.tipo_aviso.tipo_ok, True)
            End If
            carrega_grd()
        Else
            AVISO(txtCodBarra.Text & vbCrLf & "Código de Barras não encontrado!", Me, frmAviso.tipo_aviso.tipo_ok, True)
            lstNex.Items.Add(txtCodBarra.Text)
        End If
        txtCodBarra.Text = Nothing
        txtCodBarra.Focus()
    End Sub
    Private Sub btnRelat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelat.Click
        Dim rp As New rptContagem
        Dim f As New frmRpt
        rp.titulo = txtDesc.Text & " " & dtCont.Value
        rp.DataSource = tb
        f.Relat(rp)
        f.ShowDialog(Me)
    End Sub
    Private Sub grdProd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdProd.Click
        If grdProd.CurrentCell.ColumnNumber = 3 Then
            MsgBox("OK" & grdProd.Item(grdProd.CurrentCell.RowNumber, grdProd.CurrentCell.ColumnNumber).ToString)
            Dim r As DataRow
            r = tb.Rows(grdProd.CurrentCell.RowNumber)
            r("i") = 0
            MsgBox(tb.Rows(grdProd.CurrentCell.RowNumber)("i"))
            carrega_grd()
        Else
            grdProd.CurrentCell.ColumnNumber.ToString()
        End If
    End Sub
    Private Sub insere_item_nota(ByVal _x_cod_prod As Integer, ByVal q As Double)
        Dim media_len, media_prod As Double
        Dim cod_len As Integer
        Dim p As New produtoClass
        p.filtra(_x_cod_prod)
        mov.novo()
        mov.item = mov.ret_ultimo_item(chave_movimento)
        mov.cod_movimento = chave_movimento
        mov.cod_produto = p.fldCod_produto
        mov.quant = q
        mov.desconto = p.Desconto_compra
        mov.pUnit = p.Preco_compra
        mov.estoqueFis = mov.ret_saldo_fisico(p.fldCod_produto) + CDbl(q)
        mov.estoqueFin = mov.estoqueFis * ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))))
        '( + mov.ret_saldo_fin(txtCodProd.Text)
        cod_len = mov.retorna_cod_lentebloco(p.fldCod_produto)

        media_len = media_movel(mov.ret_saldo_todos_fisico(cod_len), mov.ret_saldo_todos_fin(cod_len), q, (p.Preco_compra) - (p.Preco_compra * (p.Desconto_compra / 100)))
        media_prod = media_movel(mov.ret_saldo_fisico(p.fldCod_produto), mov.ret_saldo_fin(p.fldCod_produto), q, (p.Preco_compra) - (p.Preco_compra * (p.Desconto_compra / 100)))
        mov.atualiza_custo(cod_len, media_len, p.fldCod_produto, media_prod)
        mov.historico = txtDesc.Text
        lstNex.Items.Add(mov.Salvar().ToString)
    End Sub
    Private Sub btnRelatCaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelatCaixa.Click
        Dim tSQL As String
        Dim tt As New DataTable
        Dim f As New frmGaveta
        Dim gaveta As String
        Dim rp As New rptContagem
        Dim fr As New frmRpt
        f.ShowDialog(Me)
        gaveta = f.cbGaveta.Text
        tSQL = "SELECT produtos.produto, produtos.cod_barra, SUM(conferencia_detalhes.quant) AS quantidade  " &
        "FROM   conferencia_detalhes INNER JOIN  " &
        "produtos ON conferencia_detalhes.cod_produto = produtos.cod_produto INNER JOIN  " &
        "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND produtos.id_fabricante = lentes_blocos.id_fabricante  " &
        "Where id_conferencia = 1  and conferencia_detalhes.gaveta = " & d.PStr(gaveta) &
        " GROUP BY  produtos.cod_barra,produtos.produto"
        d.carrega_Tabela(tSQL, tt)
        rp.titulo = txtDesc.Text & " " & " Gaveta / Caixa: " & gaveta & " " & dtCont.Value
        rp.DataSource = tt
        fr.Relat(rp)
        fr.ShowDialog(Me)

    End Sub
    Private Sub btnLimpaCaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpaCaixa.Click
        Dim f As New frmGaveta
        Dim gav As String
        Dim r As frmAviso.respo
        f.ShowDialog(Me)
        gav = f.cbGaveta.Text
        If MessageBox.Show("Deseja excluir todos os itens desta gaveta/caixa?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            d.Comando("Delete from conferencia_detalhes where gaveta = " & d.PStr(gav) & "", False)
            carrega_grd()
            txtCodBarra.Focus()
        End If
    End Sub
    Private Sub btnExcluiItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiItem.Click
        Dim p As New produtoClass
        Dim f As New frmGaveta
        Dim g As String
        Dim cp As Integer
        Dim tsql As String
        f.ShowDialog(Me)
        g = f.cbGaveta.Text
        cp = p.Retorna_cod_prod(InputBox("Código de barras"))
        tsql = "DELETE TOP(1) FROM conferencia_detalhes " &
        "WHERE COD_PRODUTO = " & cp & " and gaveta = " & d.PStr(g) & ""
        AVISO(d.Comando(tsql, False), Me, frmAviso.tipo_aviso.tipo_ok)
        carrega_grd()
        txtCodBarra.Focus()
    End Sub
    Private Sub btnCadBarra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadBarra.Click
        Dim f As New frmCadBarraDiop
        f.Show()
    End Sub

    Private Sub insere_ajuste(ByVal x_cod_prod As Integer, ByVal Quant As Integer)
        Dim sql, isql As String
        Dim p As New produtoClass
        Dim r As String
        sql = "INSERT INTO conferencia_ajuste (id_conferencia,cod_produto" &
           ",quant,Estoque ,user_id) VALUES (" &
           "1," & x_cod_prod & "," & Quant & "," &
           p.ret_saldo_fisico(x_cod_prod, conf.Filial) & "," & intUsuario & ")"
        r = d.Comando(sql, False)
        If r.StartsWith("OK") Then
            isql = "update conferencia_detalhes Set processado = " &
                            d.pdtm(d.hora) & " where cod_produto = " & x_cod_prod & ""
            d.Comando(isql, False)
        End If

    End Sub

    Private Sub btnInventario_Click(sender As System.Object, e As System.EventArgs) Handles btnInventario.Click
        intUsuario = acesso.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim intAcesso As Integer = acesso.verifica_permissao_menu(intUsuario)

        If intAcesso <> 1 Then
            MessageBox.Show("Usuário não pode executar essa ação!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        btnRelat_Click(Me, e)
        Dim sql As String
        Dim tSql As String
        Dim iSql As String
        Dim tt As New DataTable
        Dim res As String
        Dim i, m As Integer
        Dim resp As Integer

        If MessageBox.Show("Deseja dar entrada nessas lentes?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        chave_movimento = retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & conf.Filial & "")
        sql = "INSERT INTO movimentomaster " &
               "(cod_movimento,cod_natureza,id_filial,data,doc,id_usuario,concluido) " &
               "VALUES ( " &
               chave_movimento &
               ",9" &
               "," & conf.Filial &
               "," & d.pdtm(d.hora) &
               ",'Inventário Inicial'" &
               "," & intUsuario &
               ",'S')"
        res = d.Comando(sql, True)
        tSql = "SELECT cod_produto, SUM(quant) AS saldo " &
        " FROM conferencia_detalhes where " &
        " processado is null GROUP BY cod_produto "
        d.carrega_Tabela(tSql, tt)
        If res.StartsWith("OK") Then
            i = 0
            pb.Minimum = 0
            m = tt.Rows.Count
            pb.Maximum = m
            While i < m
                insere_item_nota(tt.Rows(i)("cod_produto"), tt.Rows(i)("saldo"))
                Application.DoEvents()
                iSql = "update conferencia_detalhes Set processado = " &
                d.pdtm(d.hora) & " where cod_produto = " & tt.Rows(i)("cod_produto") & ""
                d.Comando(iSql, False)
                i = i + 1
                pb.Value = i
            End While
            AVISO("Concluído!", Me, frmAviso.tipo_aviso.tipo_ok)
            btnLimpa_Click(Me, e)
        End If
    End Sub

    Private Sub btnPrepararAjuste_Click(sender As System.Object, e As System.EventArgs) Handles btnPrepararAjuste.Click
        intUsuario = acesso.retorna_codigo_usuario(frmMain.intCodigoUsuario)
        Dim intAcesso As Integer = acesso.verifica_permissao_menu(intUsuario)

        If intAcesso <> 1 Then
            MessageBox.Show("Usuário não pode executar essa ação!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim sql As String
        Dim tSql As String
        Dim iSql As String
        Dim tt As New DataTable
        Dim res As String
        Dim i, m As Integer

        If MessageBox.Show("Tem certeza que deseja fazer Ajuste nessas lentes?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            d.Comando("Delete from conferencia_ajuste", False)
            tSql = "SELECT cod_produto, SUM(quant) AS saldo " &
            " FROM conferencia_detalhes where " &
            " processado is null GROUP BY cod_produto "
            d.carrega_Tabela(tSql, tt)
            i = 0
            pb.Minimum = 0
            m = tt.Rows.Count
            pb.Maximum = m
            While i < m
                insere_ajuste(tt.Rows(i)("cod_produto"), tt.Rows(i)("saldo"))
                Application.DoEvents()
                iSql = "update conferencia_detalhes Set processamento = " &
                d.pdtm(d.hora) & " where cod_produto = " & tt.Rows(i)("cod_produto") & ""
                d.Comando(iSql, False)
                i = i + 1
                pb.Value = i
            End While
            AVISO("Concluído!", Me, frmAviso.tipo_aviso.tipo_ok)
        End If

    End Sub

    Private Sub txtCodBarra_TextChanged(sender As Object, e As EventArgs) Handles txtCodBarra.TextChanged

    End Sub
End Class
