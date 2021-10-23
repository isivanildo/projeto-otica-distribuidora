<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidoCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidoCompra))
        Me.txtFornecedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpCabecalho = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNumPedido = New System.Windows.Forms.Label()
        Me.txtDoc = New System.Windows.Forms.TextBox()
        Me.btnSalvarPedido = New System.Windows.Forms.Button()
        Me.dtPedido = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpItens = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.btnItensDaOS = New System.Windows.Forms.Button()
        Me.grdItens = New System.Windows.Forms.DataGrid()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.grpConferir = New System.Windows.Forms.GroupBox()
        Me.txtCodBarra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PdfExport = New DataDynamics.ActiveReports.Export.Pdf.PdfExport()
        Me.btnXMLEssilor = New System.Windows.Forms.Button()
        Me.grpCabecalho.SuspendLayout()
        Me.grpItens.SuspendLayout()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConferir.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFornecedor
        '
        Me.txtFornecedor.Location = New System.Drawing.Point(78, 33)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(256, 20)
        Me.txtFornecedor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fornecedor"
        '
        'grpCabecalho
        '
        Me.grpCabecalho.Controls.Add(Me.Label7)
        Me.grpCabecalho.Controls.Add(Me.lblNumPedido)
        Me.grpCabecalho.Controls.Add(Me.txtDoc)
        Me.grpCabecalho.Controls.Add(Me.btnSalvarPedido)
        Me.grpCabecalho.Controls.Add(Me.dtPedido)
        Me.grpCabecalho.Controls.Add(Me.txtFornecedor)
        Me.grpCabecalho.Controls.Add(Me.Label1)
        Me.grpCabecalho.Controls.Add(Me.Label2)
        Me.grpCabecalho.Controls.Add(Me.Label4)
        Me.grpCabecalho.Location = New System.Drawing.Point(3, 3)
        Me.grpCabecalho.Name = "grpCabecalho"
        Me.grpCabecalho.Size = New System.Drawing.Size(739, 60)
        Me.grpCabecalho.TabIndex = 0
        Me.grpCabecalho.TabStop = False
        Me.grpCabecalho.Text = "Dados do Pedido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Nº Pedido"
        '
        'lblNumPedido
        '
        Me.lblNumPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPedido.Location = New System.Drawing.Point(9, 35)
        Me.lblNumPedido.Name = "lblNumPedido"
        Me.lblNumPedido.Size = New System.Drawing.Size(55, 13)
        Me.lblNumPedido.TabIndex = 0
        '
        'txtDoc
        '
        Me.txtDoc.BackColor = System.Drawing.Color.White
        Me.txtDoc.Location = New System.Drawing.Point(435, 33)
        Me.txtDoc.Name = "txtDoc"
        Me.txtDoc.ReadOnly = True
        Me.txtDoc.Size = New System.Drawing.Size(190, 20)
        Me.txtDoc.TabIndex = 3
        '
        'btnSalvarPedido
        '
        Me.btnSalvarPedido.Image = CType(resources.GetObject("btnSalvarPedido.Image"), System.Drawing.Image)
        Me.btnSalvarPedido.Location = New System.Drawing.Point(647, 20)
        Me.btnSalvarPedido.Name = "btnSalvarPedido"
        Me.btnSalvarPedido.Size = New System.Drawing.Size(86, 34)
        Me.btnSalvarPedido.TabIndex = 4
        Me.btnSalvarPedido.Text = "Salvar"
        Me.btnSalvarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvarPedido.UseVisualStyleBackColor = True
        '
        'dtPedido
        '
        Me.dtPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPedido.Location = New System.Drawing.Point(343, 33)
        Me.dtPedido.Name = "dtPedido"
        Me.dtPedido.Size = New System.Drawing.Size(86, 20)
        Me.dtPedido.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data Pedido" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(435, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Documento"
        '
        'grpItens
        '
        Me.grpItens.Controls.Add(Me.Label5)
        Me.grpItens.Controls.Add(Me.txtCodProd)
        Me.grpItens.Controls.Add(Me.btnItensDaOS)
        Me.grpItens.Controls.Add(Me.grdItens)
        Me.grpItens.Enabled = False
        Me.grpItens.Location = New System.Drawing.Point(3, 67)
        Me.grpItens.Name = "grpItens"
        Me.grpItens.Size = New System.Drawing.Size(739, 405)
        Me.grpItens.TabIndex = 1
        Me.grpItens.TabStop = False
        Me.grpItens.Text = "Itens"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Digite o Código da Tabela e ENTER"
        '
        'txtCodProd
        '
        Me.txtCodProd.Location = New System.Drawing.Point(190, 14)
        Me.txtCodProd.MaxLength = 12
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.Size = New System.Drawing.Size(80, 20)
        Me.txtCodProd.TabIndex = 0
        '
        'btnItensDaOS
        '
        Me.btnItensDaOS.Image = CType(resources.GetObject("btnItensDaOS.Image"), System.Drawing.Image)
        Me.btnItensDaOS.Location = New System.Drawing.Point(598, 11)
        Me.btnItensDaOS.Name = "btnItensDaOS"
        Me.btnItensDaOS.Size = New System.Drawing.Size(135, 34)
        Me.btnItensDaOS.TabIndex = 2
        Me.btnItensDaOS.Text = "Inserir Itens da OS"
        Me.btnItensDaOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnItensDaOS.UseVisualStyleBackColor = True
        '
        'grdItens
        '
        Me.grdItens.AllowSorting = False
        Me.grdItens.DataMember = ""
        Me.grdItens.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdItens.Location = New System.Drawing.Point(9, 49)
        Me.grdItens.Name = "grdItens"
        Me.grdItens.ReadOnly = True
        Me.grdItens.Size = New System.Drawing.Size(724, 349)
        Me.grdItens.TabIndex = 1
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(647, 487)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(95, 34)
        Me.btnExcluir.TabIndex = 5
        Me.btnExcluir.Text = "Excluir Item"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(454, 487)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(86, 34)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'grpConferir
        '
        Me.grpConferir.Controls.Add(Me.txtCodBarra)
        Me.grpConferir.Controls.Add(Me.Label3)
        Me.grpConferir.Enabled = False
        Me.grpConferir.Location = New System.Drawing.Point(25, 482)
        Me.grpConferir.Name = "grpConferir"
        Me.grpConferir.Size = New System.Drawing.Size(238, 44)
        Me.grpConferir.TabIndex = 2
        Me.grpConferir.TabStop = False
        Me.grpConferir.Text = "Dados do Pedido"
        Me.grpConferir.Visible = False
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
        'btnXMLEssilor
        '
        Me.btnXMLEssilor.Image = CType(resources.GetObject("btnXMLEssilor.Image"), System.Drawing.Image)
        Me.btnXMLEssilor.Location = New System.Drawing.Point(546, 487)
        Me.btnXMLEssilor.Name = "btnXMLEssilor"
        Me.btnXMLEssilor.Size = New System.Drawing.Size(95, 34)
        Me.btnXMLEssilor.TabIndex = 4
        Me.btnXMLEssilor.Text = "Xml Essilor"
        Me.btnXMLEssilor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnXMLEssilor.UseVisualStyleBackColor = True
        '
        'frmPedidoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 533)
        Me.Controls.Add(Me.btnXMLEssilor)
        Me.Controls.Add(Me.grpItens)
        Me.Controls.Add(Me.grpConferir)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.grpCabecalho)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPedidoCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido de Compra de Lentes"
        Me.grpCabecalho.ResumeLayout(False)
        Me.grpCabecalho.PerformLayout()
        Me.grpItens.ResumeLayout(False)
        Me.grpItens.PerformLayout()
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
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnItensDaOS As System.Windows.Forms.Button
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PdfExport As DataDynamics.ActiveReports.Export.Pdf.PdfExport
    Friend WithEvents btnXMLEssilor As System.Windows.Forms.Button
    Friend WithEvents lblNumPedido As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
