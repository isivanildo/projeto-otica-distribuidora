Imports mrotica_util
Imports MRUtil
Imports System.Collections.Generic

Public Class frmConsultaNatOperacao
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
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents grdOperacao As DataGridView
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaNatOperacao))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grdOperacao = New System.Windows.Forms.DataGridView()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdOperacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescricao)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(690, 61)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros"
        '
        'txtDescricao
        '
        Me.txtDescricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDescricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(116, 23)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(434, 23)
        Me.txtDescricao.TabIndex = 1
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.Location = New System.Drawing.Point(569, 15)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(93, 37)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Descrição Produto"
        '
        'grdOperacao
        '
        Me.grdOperacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOperacao.Location = New System.Drawing.Point(10, 88)
        Me.grdOperacao.Name = "grdOperacao"
        Me.grdOperacao.RowHeadersVisible = False
        Me.grdOperacao.Size = New System.Drawing.Size(690, 309)
        Me.grdOperacao.TabIndex = 5
        '
        'btnFechar
        '
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.Location = New System.Drawing.Point(311, 407)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(88, 37)
        Me.btnFechar.TabIndex = 6
        Me.btnFechar.Text = "&Fechar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'frmConsultaNatOperacao
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(712, 454)
        Me.Controls.Add(Me.grdOperacao)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnFechar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaNatOperacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Produto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdOperacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Conexao As New ConexaoDB()
    Dim op As New NaturezaOperacao()
    Public codigonat As Integer

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        formata_grid()
    End Sub
    Private Sub formata_grid()
        grdOperacao.Columns.Clear()
        grdOperacao.AllowUserToAddRows = False
        grdOperacao.AutoGenerateColumns = False
        grdOperacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdOperacao.ReadOnly = True
        grdOperacao.DataSource = Nothing

        Dim codigo As New DataGridViewTextBoxColumn
        codigo.DataPropertyName = "codigonat"
        codigo.HeaderText = "Código"
        codigo.Width = 70
        codigo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        codigo.DefaultCellStyle.Format = "000"
        codigo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        codigo.SortMode = DataGridViewColumnSortMode.NotSortable
        grdOperacao.Columns.Add(codigo)

        Dim tiponota As New DataGridViewTextBoxColumn
        tiponota.HeaderText = "Tipo Nota"
        tiponota.Width = 100
        tiponota.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        tiponota.SortMode = DataGridViewColumnSortMode.NotSortable
        grdOperacao.Columns.Add(tiponota)

        Dim descricao As New DataGridViewTextBoxColumn
        descricao.DataPropertyName = "descricao"
        descricao.HeaderText = "Descrição"
        descricao.Width = 300
        grdOperacao.Columns.Add(descricao)

        Dim tipo As New DataGridViewTextBoxColumn
        tipo.DataPropertyName = "tiponfe"
        tipo.HeaderText = "Tipo Nota"
        tipo.Visible = False
        grdOperacao.Columns.Add(tipo)

        Dim strSQL As String = String.Empty

        If txtDescricao.Text = String.Empty Then
            strSQL = "select* from naturezaoperacao"
        Else
            strSQL = "select * from naturezaoperacao where descricao like '%" & txtDescricao.Text & "%'"
        End If

        Dim tb As New DataTable
        Conexao.CarregaTabela(strSQL, tb)

        grdOperacao.DataSource = tb
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Dim indice As Integer = grdOperacao.CurrentRow.Index
        codigonat = grdOperacao.Rows(indice).Cells(0).Value
        Me.Close()
    End Sub

    Private Sub frmConsultaNatOperacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDescricao.AutoCompleteCustomSource = op.CarregaListaOperacao()
    End Sub

    Private Sub frmConsultaNatOperacao_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub grdOperacao_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles grdOperacao.CellFormatting
        For Each linha As DataGridViewRow In grdOperacao.Rows
            If linha.Cells(3).Value = 0 Then
                linha.Cells(1).Value = "ENTRADA"
            Else
                linha.Cells(1).Value = "SAIDA"
            End If
        Next
    End Sub
End Class
