<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebitoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDebitoCliente))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtIni = New System.Windows.Forms.DateTimePicker()
        Me.gbRelatorio = New System.Windows.Forms.GroupBox()
        Me.rbSintetico = New System.Windows.Forms.RadioButton()
        Me.rbAnalitico = New System.Windows.Forms.RadioButton()
        Me.gbTipo = New System.Windows.Forms.GroupBox()
        Me.rbCidade = New System.Windows.Forms.RadioButton()
        Me.rbPromotora = New System.Windows.Forms.RadioButton()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.rbGeral = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtFim = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cbPromotor = New System.Windows.Forms.ComboBox()
        Me.cbCidade = New System.Windows.Forms.ComboBox()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.gbRelatorio.SuspendLayout()
        Me.gbTipo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.dtIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIni.Location = New System.Drawing.Point(36, 19)
        Me.dtIni.Name = "dtIni"
        Me.dtIni.Size = New System.Drawing.Size(83, 20)
        Me.dtIni.TabIndex = 0
        '
        'gbRelatorio
        '
        Me.gbRelatorio.Controls.Add(Me.rbSintetico)
        Me.gbRelatorio.Controls.Add(Me.rbAnalitico)
        Me.gbRelatorio.Location = New System.Drawing.Point(9, 78)
        Me.gbRelatorio.Name = "gbRelatorio"
        Me.gbRelatorio.Size = New System.Drawing.Size(265, 40)
        Me.gbRelatorio.TabIndex = 1
        Me.gbRelatorio.TabStop = False
        Me.gbRelatorio.Text = "Tipo Relatório"
        '
        'rbSintetico
        '
        Me.rbSintetico.AutoSize = True
        Me.rbSintetico.Checked = True
        Me.rbSintetico.Location = New System.Drawing.Point(85, 16)
        Me.rbSintetico.Name = "rbSintetico"
        Me.rbSintetico.Size = New System.Drawing.Size(66, 17)
        Me.rbSintetico.TabIndex = 1
        Me.rbSintetico.TabStop = True
        Me.rbSintetico.Text = "Sintético"
        Me.rbSintetico.UseVisualStyleBackColor = True
        '
        'rbAnalitico
        '
        Me.rbAnalitico.AutoSize = True
        Me.rbAnalitico.Location = New System.Drawing.Point(12, 16)
        Me.rbAnalitico.Name = "rbAnalitico"
        Me.rbAnalitico.Size = New System.Drawing.Size(67, 17)
        Me.rbAnalitico.TabIndex = 0
        Me.rbAnalitico.TabStop = True
        Me.rbAnalitico.Text = "Analítico"
        Me.rbAnalitico.UseVisualStyleBackColor = True
        '
        'gbTipo
        '
        Me.gbTipo.Controls.Add(Me.rbCidade)
        Me.gbTipo.Controls.Add(Me.rbPromotora)
        Me.gbTipo.Controls.Add(Me.rbCliente)
        Me.gbTipo.Controls.Add(Me.rbGeral)
        Me.gbTipo.Location = New System.Drawing.Point(9, 134)
        Me.gbTipo.Name = "gbTipo"
        Me.gbTipo.Size = New System.Drawing.Size(266, 40)
        Me.gbTipo.TabIndex = 2
        Me.gbTipo.TabStop = False
        Me.gbTipo.Text = "Por"
        '
        'rbCidade
        '
        Me.rbCidade.AutoSize = True
        Me.rbCidade.Location = New System.Drawing.Point(203, 15)
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
        Me.rbPromotora.Location = New System.Drawing.Point(125, 15)
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
        Me.rbCliente.Location = New System.Drawing.Point(65, 15)
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtFim)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.dtIni)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(265, 56)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Período"
        '
        'dtFim
        '
        Me.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFim.Location = New System.Drawing.Point(156, 19)
        Me.dtFim.Name = "dtFim"
        Me.dtFim.Size = New System.Drawing.Size(83, 20)
        Me.dtFim.TabIndex = 1
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
        Me.Label1.Location = New System.Drawing.Point(9, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Código Cliente"
        Me.Label1.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(9, 208)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 7
        Me.txtCodigo.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(297, 14)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Tudo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cbPromotor
        '
        Me.cbPromotor.FormattingEnabled = True
        Me.cbPromotor.Location = New System.Drawing.Point(112, 208)
        Me.cbPromotor.Name = "cbPromotor"
        Me.cbPromotor.Size = New System.Drawing.Size(147, 21)
        Me.cbPromotor.TabIndex = 8
        Me.cbPromotor.Visible = False
        '
        'cbCidade
        '
        Me.cbCidade.FormattingEnabled = True
        Me.cbCidade.Location = New System.Drawing.Point(264, 207)
        Me.cbCidade.Name = "cbCidade"
        Me.cbCidade.Size = New System.Drawing.Size(133, 21)
        Me.cbCidade.TabIndex = 9
        Me.cbCidade.Visible = False
        '
        'btnPDF
        '
        Me.btnPDF.Image = CType(resources.GetObject("btnPDF.Image"), System.Drawing.Image)
        Me.btnPDF.Location = New System.Drawing.Point(297, 73)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(106, 32)
        Me.btnPDF.TabIndex = 4
        Me.btnPDF.Text = "Exportar PDF"
        Me.btnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(297, 107)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(106, 32)
        Me.btnExcel.TabIndex = 5
        Me.btnExcel.Text = "Exportar Excel"
        Me.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.Location = New System.Drawing.Point(297, 142)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(106, 32)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.Location = New System.Drawing.Point(297, 38)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(106, 32)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmDebitoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 241)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.cbCidade)
        Me.Controls.Add(Me.cbPromotor)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.gbRelatorio)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.gbTipo)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDebitoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Debito Cliente Analítico/Sintético"
        Me.gbRelatorio.ResumeLayout(False)
        Me.gbRelatorio.PerformLayout()
        Me.gbTipo.ResumeLayout(False)
        Me.gbTipo.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents dtIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbRelatorio As System.Windows.Forms.GroupBox
    Friend WithEvents rbSintetico As System.Windows.Forms.RadioButton
    Friend WithEvents rbAnalitico As System.Windows.Forms.RadioButton
    Friend WithEvents gbTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rbCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbGeral As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents rbCidade As System.Windows.Forms.RadioButton
    Friend WithEvents rbPromotora As System.Windows.Forms.RadioButton
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents cbPromotor As System.Windows.Forms.ComboBox
    Friend WithEvents cbCidade As System.Windows.Forms.ComboBox
    Friend WithEvents btnPDF As System.Windows.Forms.Button
End Class
