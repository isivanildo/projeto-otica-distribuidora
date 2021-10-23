<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompraCredito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompraCredito))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblFilialFatura = New System.Windows.Forms.Label()
        Me.lblNFatura = New System.Windows.Forms.Label()
        Me.txtFilial = New System.Windows.Forms.TextBox()
        Me.txtCredito = New System.Windows.Forms.TextBox()
        Me.cbVencimento = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtParcelas = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnInsereRec = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtaPagar = New System.Windows.Forms.TextBox()
        Me.txtTotalPago = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtVencimento = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbForma = New System.Windows.Forms.ComboBox()
        Me.txtHistórico = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtValorCredito = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTextoBoleto = New System.Windows.Forms.RichTextBox()
        Me.grdRecebimento = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdRecebimento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(15, 10)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(142, 13)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Identificação do Cliente"
        '
        'lblFilialFatura
        '
        Me.lblFilialFatura.AutoSize = True
        Me.lblFilialFatura.Location = New System.Drawing.Point(12, 34)
        Me.lblFilialFatura.Name = "lblFilialFatura"
        Me.lblFilialFatura.Size = New System.Drawing.Size(27, 13)
        Me.lblFilialFatura.TabIndex = 4
        Me.lblFilialFatura.Text = "Filial"
        '
        'lblNFatura
        '
        Me.lblNFatura.AutoSize = True
        Me.lblNFatura.Location = New System.Drawing.Point(73, 34)
        Me.lblNFatura.Name = "lblNFatura"
        Me.lblNFatura.Size = New System.Drawing.Size(113, 13)
        Me.lblNFatura.TabIndex = 5
        Me.lblNFatura.Text = "Nº lançamento Crédito"
        '
        'txtFilial
        '
        Me.txtFilial.BackColor = System.Drawing.Color.White
        Me.txtFilial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilial.Location = New System.Drawing.Point(12, 50)
        Me.txtFilial.Name = "txtFilial"
        Me.txtFilial.ReadOnly = True
        Me.txtFilial.Size = New System.Drawing.Size(55, 20)
        Me.txtFilial.TabIndex = 10
        Me.txtFilial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCredito
        '
        Me.txtCredito.BackColor = System.Drawing.Color.White
        Me.txtCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredito.Location = New System.Drawing.Point(76, 50)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.ReadOnly = True
        Me.txtCredito.Size = New System.Drawing.Size(116, 20)
        Me.txtCredito.TabIndex = 11
        Me.txtCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbVencimento
        '
        Me.cbVencimento.AutoSize = True
        Me.cbVencimento.Location = New System.Drawing.Point(137, 175)
        Me.cbVencimento.Name = "cbVencimento"
        Me.cbVencimento.Size = New System.Drawing.Size(104, 17)
        Me.cbVencimento.TabIndex = 5
        Me.cbVencimento.Text = "Venc. para o dia"
        Me.cbVencimento.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Dias"
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(11, 175)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(43, 20)
        Me.txtDias.TabIndex = 3
        Me.txtDias.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nº de Parc."
        '
        'txtParcelas
        '
        Me.txtParcelas.Location = New System.Drawing.Point(63, 175)
        Me.txtParcelas.Name = "txtParcelas"
        Me.txtParcelas.Size = New System.Drawing.Size(62, 20)
        Me.txtParcelas.TabIndex = 4
        Me.txtParcelas.Text = "1"
        Me.txtParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnInsereRec)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.cbVencimento)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDias)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtaPagar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtTotalPago)
        Me.GroupBox1.Controls.Add(Me.txtParcelas)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtVencimento)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbForma)
        Me.GroupBox1.Location = New System.Drawing.Point(587, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 284)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recebimento"
        '
        'btnInsereRec
        '
        Me.btnInsereRec.Image = CType(resources.GetObject("btnInsereRec.Image"), System.Drawing.Image)
        Me.btnInsereRec.Location = New System.Drawing.Point(61, 239)
        Me.btnInsereRec.Name = "btnInsereRec"
        Me.btnInsereRec.Size = New System.Drawing.Size(73, 32)
        Me.btnInsereRec.TabIndex = 6
        Me.btnInsereRec.Text = "OK"
        Me.btnInsereRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInsereRec.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(140, 239)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(99, 32)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Imprimir"
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(121, 21)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(112, 18)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Total:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(66, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "A Pagar:"
        '
        'txtaPagar
        '
        Me.txtaPagar.BackColor = System.Drawing.Color.White
        Me.txtaPagar.ForeColor = System.Drawing.Color.Blue
        Me.txtaPagar.Location = New System.Drawing.Point(121, 68)
        Me.txtaPagar.Name = "txtaPagar"
        Me.txtaPagar.ReadOnly = True
        Me.txtaPagar.Size = New System.Drawing.Size(113, 20)
        Me.txtaPagar.TabIndex = 9
        Me.txtaPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPago
        '
        Me.txtTotalPago.BackColor = System.Drawing.Color.White
        Me.txtTotalPago.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalPago.Location = New System.Drawing.Point(121, 42)
        Me.txtTotalPago.Name = "txtTotalPago"
        Me.txtTotalPago.ReadOnly = True
        Me.txtTotalPago.Size = New System.Drawing.Size(113, 20)
        Me.txtTotalPago.TabIndex = 8
        Me.txtTotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Total Pago:"
        '
        'dtVencimento
        '
        Me.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVencimento.Location = New System.Drawing.Point(11, 128)
        Me.dtVencimento.Name = "dtVencimento"
        Me.dtVencimento.Size = New System.Drawing.Size(86, 20)
        Me.dtVencimento.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(103, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Forma Pagamento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Data Vencimento"
        '
        'cbForma
        '
        Me.cbForma.FormattingEnabled = True
        Me.cbForma.Location = New System.Drawing.Point(106, 128)
        Me.cbForma.Name = "cbForma"
        Me.cbForma.Size = New System.Drawing.Size(132, 21)
        Me.cbForma.TabIndex = 2
        '
        'txtHistórico
        '
        Me.txtHistórico.BackColor = System.Drawing.Color.White
        Me.txtHistórico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHistórico.Location = New System.Drawing.Point(12, 94)
        Me.txtHistórico.Multiline = True
        Me.txtHistórico.Name = "txtHistórico"
        Me.txtHistórico.ReadOnly = True
        Me.txtHistórico.Size = New System.Drawing.Size(562, 90)
        Me.txtHistórico.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Histórico"
        '
        'txtValorCredito
        '
        Me.txtValorCredito.BackColor = System.Drawing.Color.White
        Me.txtValorCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorCredito.Location = New System.Drawing.Point(201, 50)
        Me.txtValorCredito.Name = "txtValorCredito"
        Me.txtValorCredito.ReadOnly = True
        Me.txtValorCredito.Size = New System.Drawing.Size(90, 20)
        Me.txtValorCredito.TabIndex = 12
        Me.txtValorCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Valor do Crédito"
        '
        'txtTextoBoleto
        '
        Me.txtTextoBoleto.Location = New System.Drawing.Point(456, 299)
        Me.txtTextoBoleto.Name = "txtTextoBoleto"
        Me.txtTextoBoleto.Size = New System.Drawing.Size(63, 63)
        Me.txtTextoBoleto.TabIndex = 127
        Me.txtTextoBoleto.Text = resources.GetString("txtTextoBoleto.Text")
        Me.txtTextoBoleto.Visible = False
        '
        'grdRecebimento
        '
        Me.grdRecebimento.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("NewsGoth BT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdRecebimento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdRecebimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRecebimento.Location = New System.Drawing.Point(12, 197)
        Me.grdRecebimento.Name = "grdRecebimento"
        Me.grdRecebimento.RowHeadersVisible = False
        Me.grdRecebimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRecebimento.Size = New System.Drawing.Size(562, 175)
        Me.grdRecebimento.TabIndex = 14
        '
        'frmCompraCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(857, 392)
        Me.Controls.Add(Me.grdRecebimento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValorCredito)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtHistórico)
        Me.Controls.Add(Me.txtCredito)
        Me.Controls.Add(Me.txtFilial)
        Me.Controls.Add(Me.lblNFatura)
        Me.Controls.Add(Me.lblFilialFatura)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTextoBoleto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompraCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra de Pacote"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdRecebimento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblFilialFatura As System.Windows.Forms.Label
    Friend WithEvents lblNFatura As System.Windows.Forms.Label
    Friend WithEvents txtFilial As System.Windows.Forms.TextBox
    Friend WithEvents txtCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtParcelas As System.Windows.Forms.TextBox
    Friend WithEvents btnInsereRec As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtaPagar As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPago As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtHistórico As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtValorCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents cbVencimento As System.Windows.Forms.CheckBox
    Friend WithEvents txtDias As System.Windows.Forms.TextBox
    Friend WithEvents txtTextoBoleto As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grdRecebimento As System.Windows.Forms.DataGridView
    Friend WithEvents dtVencimento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbForma As System.Windows.Forms.ComboBox
End Class
