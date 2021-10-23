<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebitoClienteJurosMUlta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDebitoClienteJurosMUlta))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtIni = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbGeral = New System.Windows.Forms.CheckBox()
        Me.dtFim = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTaxaCartorio = New System.Windows.Forms.TextBox()
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbCidade = New System.Windows.Forms.RadioButton()
        Me.rbPromotora = New System.Windows.Forms.RadioButton()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.rbGeral = New System.Windows.Forms.RadioButton()
        Me.cbCidade = New System.Windows.Forms.ComboBox()
        Me.cbPromotor = New System.Windows.Forms.ComboBox()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.gbTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "De:"
        '
        'dtIni
        '
        Me.dtIni.Enabled = False
        Me.dtIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIni.Location = New System.Drawing.Point(36, 19)
        Me.dtIni.Name = "dtIni"
        Me.dtIni.Size = New System.Drawing.Size(83, 20)
        Me.dtIni.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbGeral)
        Me.GroupBox3.Controls.Add(Me.dtFim)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.dtIni)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(306, 56)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Período"
        '
        'cbGeral
        '
        Me.cbGeral.AutoSize = True
        Me.cbGeral.Checked = True
        Me.cbGeral.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbGeral.Location = New System.Drawing.Point(252, 20)
        Me.cbGeral.Name = "cbGeral"
        Me.cbGeral.Size = New System.Drawing.Size(51, 17)
        Me.cbGeral.TabIndex = 13
        Me.cbGeral.Text = "Tudo"
        Me.cbGeral.UseVisualStyleBackColor = True
        '
        'dtFim
        '
        Me.dtFim.Enabled = False
        Me.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFim.Location = New System.Drawing.Point(156, 19)
        Me.dtFim.Name = "dtFim"
        Me.dtFim.Size = New System.Drawing.Size(83, 20)
        Me.dtFim.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Até:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Código Cliente"
        Me.Label1.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(9, 134)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(76, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Taxa Cartório"
        '
        'txtTaxaCartorio
        '
        Me.txtTaxaCartorio.Location = New System.Drawing.Point(92, 134)
        Me.txtTaxaCartorio.Name = "txtTaxaCartorio"
        Me.txtTaxaCartorio.Size = New System.Drawing.Size(76, 20)
        Me.txtTaxaCartorio.TabIndex = 2
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.rbCidade)
        Me.gbTipo.Controls.Add(Me.rbPromotora)
        Me.gbTipo.Controls.Add(Me.rbCliente)
        Me.gbTipo.Controls.Add(Me.rbGeral)
        Me.gbTipo.Location = New System.Drawing.Point(9, 65)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(305, 40)
        Me.gbTipo.TabIndex = 12
        Me.gbTipo.TabStop = False
        Me.gbTipo.Text = "Por"
        '
        'rbCidade
        '
        Me.rbCidade.AutoSize = True
        Me.rbCidade.Location = New System.Drawing.Point(241, 15)
        Me.rbCidade.Name = "rbCidade"
        Me.rbCidade.Size = New System.Drawing.Size(58, 17)
        Me.rbCidade.TabIndex = 3
        Me.rbCidade.TabStop = True
        Me.rbCidade.Text = "Cidade"
        Me.rbCidade.UseVisualStyleBackColor = True
        '
        'rbPromotora
        '
        Me.rbPromotora.AutoSize = True
        Me.rbPromotora.Location = New System.Drawing.Point(158, 15)
        Me.rbPromotora.Name = "rbPromotora"
        Me.rbPromotora.Size = New System.Drawing.Size(67, 17)
        Me.rbPromotora.TabIndex = 2
        Me.rbPromotora.TabStop = True
        Me.rbPromotora.Text = "Promotor"
        Me.rbPromotora.UseVisualStyleBackColor = True
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.Location = New System.Drawing.Point(83, 15)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(57, 17)
        Me.rbCliente.TabIndex = 1
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'rbGeral
        '
        Me.rbGeral.AutoSize = True
        Me.rbGeral.Checked = True
        Me.rbGeral.Location = New System.Drawing.Point(10, 15)
        Me.rbGeral.Name = "rbGeral"
        Me.rbGeral.Size = New System.Drawing.Size(50, 17)
        Me.rbGeral.TabIndex = 0
        Me.rbGeral.TabStop = True
        Me.rbGeral.Text = "Geral"
        Me.rbGeral.UseVisualStyleBackColor = True
        '
        'cbCidade
        '
        Me.cbCidade.FormattingEnabled = True
        Me.cbCidade.Location = New System.Drawing.Point(187, 142)
        Me.cbCidade.Name = "cbCidade"
        Me.cbCidade.Size = New System.Drawing.Size(133, 21)
        Me.cbCidade.TabIndex = 14
        Me.cbCidade.Visible = False
        '
        'cbPromotor
        '
        Me.cbPromotor.FormattingEnabled = True
        Me.cbPromotor.Location = New System.Drawing.Point(173, 111)
        Me.cbPromotor.Name = "cbPromotor"
        Me.cbPromotor.Size = New System.Drawing.Size(147, 21)
        Me.cbPromotor.TabIndex = 13
        Me.cbPromotor.Visible = False
        '
        'btnExcel
        '
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(340, 83)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(106, 32)
        Me.btnExcel.TabIndex = 16
        Me.btnExcel.Text = "Exportar Excel"
        Me.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnPDF
        '
        Me.btnPDF.Image = CType(resources.GetObject("btnPDF.Image"), System.Drawing.Image)
        Me.btnPDF.Location = New System.Drawing.Point(340, 49)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(106, 32)
        Me.btnPDF.TabIndex = 15
        Me.btnPDF.Text = "Exportar PDF"
        Me.btnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.Location = New System.Drawing.Point(340, 117)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(106, 32)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(340, 15)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(106, 32)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmDebitoClienteJurosMUlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 183)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.cbCidade)
        Me.Controls.Add(Me.cbPromotor)
        Me.Controls.Add(Me.gbTipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTaxaCartorio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDebitoClienteJurosMUlta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Debito Cliente c/ Juros, Multa e Taxa de Cartório"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents dtIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTaxaCartorio As System.Windows.Forms.TextBox
    Friend WithEvents cbGeral As System.Windows.Forms.CheckBox
    Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rbCidade As System.Windows.Forms.RadioButton
    Friend WithEvents rbPromotora As System.Windows.Forms.RadioButton
    Friend WithEvents rbCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbGeral As System.Windows.Forms.RadioButton
    Friend WithEvents cbCidade As System.Windows.Forms.ComboBox
    Friend WithEvents cbPromotor As System.Windows.Forms.ComboBox
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
End Class
