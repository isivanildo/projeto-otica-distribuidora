<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcordo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcordo))
        Me.grdItens = New System.Windows.Forms.DataGrid()
        Me.grpRec = New System.Windows.Forms.GroupBox()
        Me.btnInsereRec = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNparcelas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbForma = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtVenc = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtEmissao = New System.Windows.Forms.DateTimePicker()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAcrescimo = New System.Windows.Forms.TextBox()
        Me.grdRec = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtaPagar = New System.Windows.Forms.TextBox()
        Me.txtTotalPago = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnInserir = New System.Windows.Forms.Button()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRec.SuspendLayout()
        CType(Me.grdRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdItens
        '
        Me.grdItens.AllowSorting = False
        Me.grdItens.DataMember = ""
        Me.grdItens.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdItens.Location = New System.Drawing.Point(1, 104)
        Me.grdItens.Name = "grdItens"
        Me.grdItens.ReadOnly = True
        Me.grdItens.Size = New System.Drawing.Size(571, 176)
        Me.grdItens.TabIndex = 3
        '
        'grpRec
        '
        Me.grpRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpRec.Controls.Add(Me.btnInsereRec)
        Me.grpRec.Controls.Add(Me.Label8)
        Me.grpRec.Controls.Add(Me.txtNparcelas)
        Me.grpRec.Controls.Add(Me.Label7)
        Me.grpRec.Controls.Add(Me.txtValor)
        Me.grpRec.Controls.Add(Me.Label6)
        Me.grpRec.Controls.Add(Me.cbForma)
        Me.grpRec.Controls.Add(Me.Label5)
        Me.grpRec.Controls.Add(Me.dtVenc)
        Me.grpRec.Controls.Add(Me.Label4)
        Me.grpRec.Controls.Add(Me.dtEmissao)
        Me.grpRec.Location = New System.Drawing.Point(2, 290)
        Me.grpRec.Name = "grpRec"
        Me.grpRec.Size = New System.Drawing.Size(570, 56)
        Me.grpRec.TabIndex = 17
        Me.grpRec.TabStop = False
        Me.grpRec.Text = "Recebimento"
        '
        'btnInsereRec
        '
        Me.btnInsereRec.Location = New System.Drawing.Point(515, 31)
        Me.btnInsereRec.Name = "btnInsereRec"
        Me.btnInsereRec.Size = New System.Drawing.Size(36, 23)
        Me.btnInsereRec.TabIndex = 10
        Me.btnInsereRec.Text = "OK"
        Me.btnInsereRec.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(431, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nº de Parcelas"
        '
        'txtNparcelas
        '
        Me.txtNparcelas.Location = New System.Drawing.Point(431, 32)
        Me.txtNparcelas.Name = "txtNparcelas"
        Me.txtNparcelas.Size = New System.Drawing.Size(78, 20)
        Me.txtNparcelas.TabIndex = 8
        Me.txtNparcelas.Text = "1"
        Me.txtNparcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(394, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Valor"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(325, 32)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 6
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(183, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Forma Pagamento"
        '
        'cbForma
        '
        Me.cbForma.FormattingEnabled = True
        Me.cbForma.Location = New System.Drawing.Point(186, 32)
        Me.cbForma.Name = "cbForma"
        Me.cbForma.Size = New System.Drawing.Size(132, 21)
        Me.cbForma.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(94, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Data Vencimento"
        '
        'dtVenc
        '
        Me.dtVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVenc.Location = New System.Drawing.Point(96, 32)
        Me.dtVenc.Name = "dtVenc"
        Me.dtVenc.Size = New System.Drawing.Size(84, 20)
        Me.dtVenc.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Data Emissao"
        '
        'dtEmissao
        '
        Me.dtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEmissao.Location = New System.Drawing.Point(6, 32)
        Me.dtEmissao.Name = "dtEmissao"
        Me.dtEmissao.Size = New System.Drawing.Size(84, 20)
        Me.dtEmissao.TabIndex = 0
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(484, 19)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(83, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "OK"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Descrição Acordo"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(8, 21)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(362, 63)
        Me.txtDescricao.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(378, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Acréscimo/Valor"
        '
        'txtAcrescimo
        '
        Me.txtAcrescimo.Location = New System.Drawing.Point(376, 21)
        Me.txtAcrescimo.Name = "txtAcrescimo"
        Me.txtAcrescimo.Size = New System.Drawing.Size(100, 20)
        Me.txtAcrescimo.TabIndex = 1
        Me.txtAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grdRec
        '
        Me.grdRec.AllowSorting = False
        Me.grdRec.DataMember = ""
        Me.grdRec.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdRec.Location = New System.Drawing.Point(2, 352)
        Me.grdRec.Name = "grdRec"
        Me.grdRec.ReadOnly = True
        Me.grdRec.Size = New System.Drawing.Size(337, 151)
        Me.grdRec.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtaPagar)
        Me.GroupBox1.Controls.Add(Me.txtTotalPago)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(346, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 116)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totais"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "A Pagar:"
        '
        'txtaPagar
        '
        Me.txtaPagar.BackColor = System.Drawing.Color.White
        Me.txtaPagar.ForeColor = System.Drawing.Color.Blue
        Me.txtaPagar.Location = New System.Drawing.Point(101, 74)
        Me.txtaPagar.Name = "txtaPagar"
        Me.txtaPagar.ReadOnly = True
        Me.txtaPagar.Size = New System.Drawing.Size(113, 20)
        Me.txtaPagar.TabIndex = 29
        Me.txtaPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPago
        '
        Me.txtTotalPago.BackColor = System.Drawing.Color.White
        Me.txtTotalPago.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalPago.Location = New System.Drawing.Point(101, 48)
        Me.txtTotalPago.Name = "txtTotalPago"
        Me.txtTotalPago.ReadOnly = True
        Me.txtTotalPago.Size = New System.Drawing.Size(113, 20)
        Me.txtTotalPago.TabIndex = 28
        Me.txtTotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Total Pago:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.ForeColor = System.Drawing.Color.Blue
        Me.txtTotal.Location = New System.Drawing.Point(101, 22)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(113, 20)
        Me.txtTotal.TabIndex = 22
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Total do Acordo"
        '
        'btnInserir
        '
        Me.btnInserir.Location = New System.Drawing.Point(381, 75)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(83, 23)
        Me.btnInserir.TabIndex = 25
        Me.btnInserir.Text = "Inserir Titulo"
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'frmAcordo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 509)
        Me.Controls.Add(Me.btnInserir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdRec)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAcrescimo)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.grpRec)
        Me.Controls.Add(Me.grdItens)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAcordo"
        Me.Text = "frmAcordo"
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRec.ResumeLayout(False)
        Me.grpRec.PerformLayout()
        CType(Me.grdRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdItens As System.Windows.Forms.DataGrid
    Friend WithEvents grpRec As System.Windows.Forms.GroupBox
    Friend WithEvents btnInsereRec As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNparcelas As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbForma As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtEmissao As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAcrescimo As System.Windows.Forms.TextBox
    Friend WithEvents grdRec As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtaPagar As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPago As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnInserir As System.Windows.Forms.Button
End Class
