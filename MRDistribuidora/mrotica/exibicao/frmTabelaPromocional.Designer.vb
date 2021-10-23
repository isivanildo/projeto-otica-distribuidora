<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTabelaPromocional
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTabelaPromocional))
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.dtIni = New System.Windows.Forms.DateTimePicker()
        Me.dtFim = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpCabecalho = New System.Windows.Forms.GroupBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.grpProdutos = New System.Windows.Forms.GroupBox()
        Me.btnInsereProduto = New System.Windows.Forms.Button()
        Me.txtCodTabela = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grdItens = New System.Windows.Forms.DataGrid()
        Me.GrpClientes = New System.Windows.Forms.GroupBox()
        Me.btnInsereCliente = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grdCliente = New System.Windows.Forms.DataGrid()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbProdutos = New System.Windows.Forms.TabPage()
        Me.tbClientes = New System.Windows.Forms.TabPage()
        Me.grpCabecalho.SuspendLayout()
        Me.grpProdutos.SuspendLayout()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpClientes.SuspendLayout()
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tbProdutos.SuspendLayout()
        Me.tbClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(6, 31)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(374, 20)
        Me.txtDescricao.TabIndex = 0
        '
        'dtIni
        '
        Me.dtIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIni.Location = New System.Drawing.Point(397, 31)
        Me.dtIni.Name = "dtIni"
        Me.dtIni.Size = New System.Drawing.Size(86, 20)
        Me.dtIni.TabIndex = 1
        '
        'dtFim
        '
        Me.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFim.Location = New System.Drawing.Point(489, 31)
        Me.dtFim.Name = "dtFim"
        Me.dtFim.Size = New System.Drawing.Size(86, 20)
        Me.dtFim.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tabela Promocional"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(394, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Início"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(486, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Término"
        '
        'grpCabecalho
        '
        Me.grpCabecalho.Controls.Add(Me.btnSalvar)
        Me.grpCabecalho.Controls.Add(Me.Label1)
        Me.grpCabecalho.Controls.Add(Me.Label3)
        Me.grpCabecalho.Controls.Add(Me.txtDescricao)
        Me.grpCabecalho.Controls.Add(Me.Label2)
        Me.grpCabecalho.Controls.Add(Me.dtIni)
        Me.grpCabecalho.Controls.Add(Me.dtFim)
        Me.grpCabecalho.Location = New System.Drawing.Point(3, 2)
        Me.grpCabecalho.Name = "grpCabecalho"
        Me.grpCabecalho.Size = New System.Drawing.Size(778, 67)
        Me.grpCabecalho.TabIndex = 6
        Me.grpCabecalho.TabStop = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(581, 31)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(178, 23)
        Me.btnSalvar.TabIndex = 6
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'grpProdutos
        '
        Me.grpProdutos.Controls.Add(Me.btnInsereProduto)
        Me.grpProdutos.Controls.Add(Me.txtCodTabela)
        Me.grpProdutos.Controls.Add(Me.Label5)
        Me.grpProdutos.Controls.Add(Me.txtDesconto)
        Me.grpProdutos.Controls.Add(Me.Label4)
        Me.grpProdutos.Controls.Add(Me.grdItens)
        Me.grpProdutos.Location = New System.Drawing.Point(8, 2)
        Me.grpProdutos.Name = "grpProdutos"
        Me.grpProdutos.Size = New System.Drawing.Size(710, 496)
        Me.grpProdutos.TabIndex = 7
        Me.grpProdutos.TabStop = False
        '
        'btnInsereProduto
        '
        Me.btnInsereProduto.Location = New System.Drawing.Point(304, 11)
        Me.btnInsereProduto.Name = "btnInsereProduto"
        Me.btnInsereProduto.Size = New System.Drawing.Size(71, 23)
        Me.btnInsereProduto.TabIndex = 10
        Me.btnInsereProduto.Text = "OK"
        Me.btnInsereProduto.UseVisualStyleBackColor = True
        '
        'txtCodTabela
        '
        Me.txtCodTabela.Location = New System.Drawing.Point(88, 13)
        Me.txtCodTabela.Name = "txtCodTabela"
        Me.txtCodTabela.Size = New System.Drawing.Size(86, 20)
        Me.txtCodTabela.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(183, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Desconto %"
        '
        'txtDesconto
        '
        Me.txtDesconto.Location = New System.Drawing.Point(253, 12)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(43, 20)
        Me.txtDesconto.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Código Tabela"
        '
        'grdItens
        '
        Me.grdItens.AllowSorting = False
        Me.grdItens.DataMember = ""
        Me.grdItens.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdItens.Location = New System.Drawing.Point(9, 40)
        Me.grdItens.Name = "grdItens"
        Me.grdItens.ReadOnly = True
        Me.grdItens.Size = New System.Drawing.Size(695, 442)
        Me.grdItens.TabIndex = 5
        '
        'GrpClientes
        '
        Me.GrpClientes.Controls.Add(Me.btnInsereCliente)
        Me.GrpClientes.Controls.Add(Me.txtCliente)
        Me.GrpClientes.Controls.Add(Me.Label6)
        Me.GrpClientes.Controls.Add(Me.grdCliente)
        Me.GrpClientes.Location = New System.Drawing.Point(6, 8)
        Me.GrpClientes.Name = "GrpClientes"
        Me.GrpClientes.Size = New System.Drawing.Size(710, 496)
        Me.GrpClientes.TabIndex = 8
        Me.GrpClientes.TabStop = False
        Me.GrpClientes.Text = "Clientes"
        '
        'btnInsereCliente
        '
        Me.btnInsereCliente.BackColor = System.Drawing.SystemColors.Control
        Me.btnInsereCliente.Location = New System.Drawing.Point(292, 35)
        Me.btnInsereCliente.Name = "btnInsereCliente"
        Me.btnInsereCliente.Size = New System.Drawing.Size(56, 24)
        Me.btnInsereCliente.TabIndex = 29
        Me.btnInsereCliente.Text = "Salvar"
        Me.btnInsereCliente.UseVisualStyleBackColor = False
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(8, 37)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(278, 20)
        Me.txtCliente.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Cliente"
        '
        'grdCliente
        '
        Me.grdCliente.AllowSorting = False
        Me.grdCliente.DataMember = ""
        Me.grdCliente.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdCliente.Location = New System.Drawing.Point(8, 63)
        Me.grdCliente.Name = "grdCliente"
        Me.grdCliente.ReadOnly = True
        Me.grdCliente.Size = New System.Drawing.Size(470, 427)
        Me.grdCliente.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbProdutos)
        Me.TabControl1.Controls.Add(Me.tbClientes)
        Me.TabControl1.Location = New System.Drawing.Point(9, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(730, 536)
        Me.TabControl1.TabIndex = 9
        '
        'tbProdutos
        '
        Me.tbProdutos.Controls.Add(Me.grpProdutos)
        Me.tbProdutos.Location = New System.Drawing.Point(4, 22)
        Me.tbProdutos.Name = "tbProdutos"
        Me.tbProdutos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbProdutos.Size = New System.Drawing.Size(722, 510)
        Me.tbProdutos.TabIndex = 0
        Me.tbProdutos.Text = "Produtos"
        Me.tbProdutos.UseVisualStyleBackColor = True
        '
        'tbClientes
        '
        Me.tbClientes.Controls.Add(Me.GrpClientes)
        Me.tbClientes.Location = New System.Drawing.Point(4, 22)
        Me.tbClientes.Name = "tbClientes"
        Me.tbClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbClientes.Size = New System.Drawing.Size(722, 510)
        Me.tbClientes.TabIndex = 1
        Me.tbClientes.Text = "Clientes"
        Me.tbClientes.UseVisualStyleBackColor = True
        '
        'frmTabelaPromocional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 620)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.grpCabecalho)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTabelaPromocional"
        Me.Text = "frmTabelaPromocional"
        Me.grpCabecalho.ResumeLayout(False)
        Me.grpCabecalho.PerformLayout()
        Me.grpProdutos.ResumeLayout(False)
        Me.grpProdutos.PerformLayout()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpClientes.ResumeLayout(False)
        Me.GrpClientes.PerformLayout()
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tbProdutos.ResumeLayout(False)
        Me.tbClientes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents dtIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpCabecalho As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents grpProdutos As System.Windows.Forms.GroupBox
    Friend WithEvents GrpClientes As System.Windows.Forms.GroupBox
    Friend WithEvents grdItens As System.Windows.Forms.DataGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodTabela As System.Windows.Forms.TextBox
    Friend WithEvents btnInsereProduto As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDesconto As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbProdutos As System.Windows.Forms.TabPage
    Friend WithEvents tbClientes As System.Windows.Forms.TabPage
    Friend WithEvents grdCliente As System.Windows.Forms.DataGrid
    Friend WithEvents btnInsereCliente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
