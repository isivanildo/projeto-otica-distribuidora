<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidoCompraAuto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidoCompraAuto))
        Me.txtFornecedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpCabecalho = New System.Windows.Forms.GroupBox()
        Me.txtDoc = New System.Windows.Forms.TextBox()
        Me.btnSalvarPedido = New System.Windows.Forms.Button()
        Me.dtPedido = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpItens = New System.Windows.Forms.GroupBox()
        Me.btnExcluiNumero = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.grdItens = New System.Windows.Forms.DataGrid()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.grpConferir = New System.Windows.Forms.GroupBox()
        Me.btnCadBarra = New System.Windows.Forms.Button()
        Me.txtCodBarra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPrintRelacao = New System.Windows.Forms.Button()
        Me.grpCabecalho.SuspendLayout()
        Me.grpItens.SuspendLayout()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConferir.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFornecedor
        '
        Me.txtFornecedor.Location = New System.Drawing.Point(9, 27)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(256, 20)
        Me.txtFornecedor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fornecedor"
        '
        'grpCabecalho
        '
        Me.grpCabecalho.Controls.Add(Me.txtDoc)
        Me.grpCabecalho.Controls.Add(Me.btnSalvarPedido)
        Me.grpCabecalho.Controls.Add(Me.dtPedido)
        Me.grpCabecalho.Controls.Add(Me.txtFornecedor)
        Me.grpCabecalho.Controls.Add(Me.Label1)
        Me.grpCabecalho.Controls.Add(Me.Label2)
        Me.grpCabecalho.Controls.Add(Me.Label4)
        Me.grpCabecalho.Location = New System.Drawing.Point(3, 3)
        Me.grpCabecalho.Name = "grpCabecalho"
        Me.grpCabecalho.Size = New System.Drawing.Size(739, 55)
        Me.grpCabecalho.TabIndex = 2
        Me.grpCabecalho.TabStop = False
        Me.grpCabecalho.Text = "Dados do Pedido"
        '
        'txtDoc
        '
        Me.txtDoc.BackColor = System.Drawing.Color.White
        Me.txtDoc.Location = New System.Drawing.Point(386, 26)
        Me.txtDoc.Name = "txtDoc"
        Me.txtDoc.ReadOnly = True
        Me.txtDoc.Size = New System.Drawing.Size(190, 20)
        Me.txtDoc.TabIndex = 2
        '
        'btnSalvarPedido
        '
        Me.btnSalvarPedido.Location = New System.Drawing.Point(582, 24)
        Me.btnSalvarPedido.Name = "btnSalvarPedido"
        Me.btnSalvarPedido.Size = New System.Drawing.Size(135, 23)
        Me.btnSalvarPedido.TabIndex = 3
        Me.btnSalvarPedido.Text = "Salvar"
        Me.btnSalvarPedido.UseVisualStyleBackColor = True
        '
        'dtPedido
        '
        Me.dtPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPedido.Location = New System.Drawing.Point(294, 27)
        Me.dtPedido.Name = "dtPedido"
        Me.dtPedido.Size = New System.Drawing.Size(86, 20)
        Me.dtPedido.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data Pedido" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(386, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Documento"
        '
        'grpItens
        '
        Me.grpItens.Controls.Add(Me.btnExcluiNumero)
        Me.grpItens.Controls.Add(Me.btnExcluir)
        Me.grpItens.Controls.Add(Me.grdItens)
        Me.grpItens.Enabled = False
        Me.grpItens.Location = New System.Drawing.Point(3, 88)
        Me.grpItens.Name = "grpItens"
        Me.grpItens.Size = New System.Drawing.Size(739, 404)
        Me.grpItens.TabIndex = 3
        Me.grpItens.TabStop = False
        Me.grpItens.Text = "Itens"
        '
        'btnExcluiNumero
        '
        Me.btnExcluiNumero.Location = New System.Drawing.Point(353, 375)
        Me.btnExcluiNumero.Name = "btnExcluiNumero"
        Me.btnExcluiNumero.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluiNumero.TabIndex = 6
        Me.btnExcluiNumero.Text = "Excluir Item"
        Me.btnExcluiNumero.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(263, 375)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 5
        Me.btnExcluir.Text = "Excluir Item"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'grdItens
        '
        Me.grdItens.AllowSorting = False
        Me.grdItens.DataMember = ""
        Me.grdItens.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdItens.Location = New System.Drawing.Point(9, 16)
        Me.grdItens.Name = "grdItens"
        Me.grdItens.ReadOnly = True
        Me.grdItens.Size = New System.Drawing.Size(724, 357)
        Me.grdItens.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(312, 498)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(135, 23)
        Me.btnImprimir.TabIndex = 5
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'grpConferir
        '
        Me.grpConferir.Controls.Add(Me.btnCadBarra)
        Me.grpConferir.Controls.Add(Me.txtCodBarra)
        Me.grpConferir.Controls.Add(Me.Label3)
        Me.grpConferir.Enabled = False
        Me.grpConferir.Location = New System.Drawing.Point(3, 51)
        Me.grpConferir.Name = "grpConferir"
        Me.grpConferir.Size = New System.Drawing.Size(739, 44)
        Me.grpConferir.TabIndex = 6
        Me.grpConferir.TabStop = False
        Me.grpConferir.Text = "Dados do Pedido"
        Me.grpConferir.Visible = False
        '
        'btnCadBarra
        '
        Me.btnCadBarra.Location = New System.Drawing.Point(562, 13)
        Me.btnCadBarra.Name = "btnCadBarra"
        Me.btnCadBarra.Size = New System.Drawing.Size(155, 23)
        Me.btnCadBarra.TabIndex = 22
        Me.btnCadBarra.Text = "Cad. Codigo de Barra"
        '
        'txtCodBarra
        '
        Me.txtCodBarra.Location = New System.Drawing.Point(98, 18)
        Me.txtCodBarra.Name = "txtCodBarra"
        Me.txtCodBarra.Size = New System.Drawing.Size(109, 20)
        Me.txtCodBarra.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Código de Barras"
        '
        'btnPrintRelacao
        '
        Me.btnPrintRelacao.Location = New System.Drawing.Point(475, 498)
        Me.btnPrintRelacao.Name = "btnPrintRelacao"
        Me.btnPrintRelacao.Size = New System.Drawing.Size(135, 23)
        Me.btnPrintRelacao.TabIndex = 7
        Me.btnPrintRelacao.Text = "Imprimir"
        Me.btnPrintRelacao.UseVisualStyleBackColor = True
        '
        'frmPedidoCompraAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 533)
        Me.Controls.Add(Me.btnPrintRelacao)
        Me.Controls.Add(Me.grpItens)
        Me.Controls.Add(Me.grpConferir)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.grpCabecalho)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPedidoCompraAuto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPedidoCompraAuto"
        Me.grpCabecalho.ResumeLayout(False)
        Me.grpCabecalho.PerformLayout()
        Me.grpItens.ResumeLayout(False)
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConferir.ResumeLayout(False)
        Me.grpConferir.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpCabecalho As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtPedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSalvarPedido As System.Windows.Forms.Button
    Friend WithEvents grpItens As System.Windows.Forms.GroupBox
    Friend WithEvents grdItens As System.Windows.Forms.DataGrid
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents grpConferir As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDoc As System.Windows.Forms.TextBox
    Friend WithEvents btnPrintRelacao As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnExcluiNumero As System.Windows.Forms.Button
    Friend WithEvents btnCadBarra As System.Windows.Forms.Button
End Class
