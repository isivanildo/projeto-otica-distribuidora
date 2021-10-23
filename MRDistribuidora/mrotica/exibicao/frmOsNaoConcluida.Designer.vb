<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOsNaoConcluida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOsNaoConcluida))
        Me.grdOS = New System.Windows.Forms.DataGrid()
        Me.grpIntervalo = New System.Windows.Forms.GroupBox()
        Me.chkVerif = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtVerifFim = New System.Windows.Forms.DateTimePicker()
        Me.dtVerifIni = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbLoja = New System.Windows.Forms.ComboBox()
        Me.chkLoja = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkEntrega = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtEntregaFim = New System.Windows.Forms.DateTimePicker()
        Me.dtEntregaIni = New System.Windows.Forms.DateTimePicker()
        Me.txtMax = New System.Windows.Forms.TextBox()
        CType(Me.grdOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIntervalo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdOS
        '
        Me.grdOS.DataMember = ""
        Me.grdOS.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdOS.Location = New System.Drawing.Point(12, 62)
        Me.grdOS.Name = "grdOS"
        Me.grdOS.Size = New System.Drawing.Size(968, 480)
        Me.grdOS.TabIndex = 5
        '
        'grpIntervalo
        '
        Me.grpIntervalo.Controls.Add(Me.chkVerif)
        Me.grpIntervalo.Controls.Add(Me.Label2)
        Me.grpIntervalo.Controls.Add(Me.Label1)
        Me.grpIntervalo.Controls.Add(Me.dtVerifFim)
        Me.grpIntervalo.Controls.Add(Me.dtVerifIni)
        Me.grpIntervalo.Location = New System.Drawing.Point(12, 3)
        Me.grpIntervalo.Name = "grpIntervalo"
        Me.grpIntervalo.Size = New System.Drawing.Size(244, 53)
        Me.grpIntervalo.TabIndex = 6
        Me.grpIntervalo.TabStop = False
        Me.grpIntervalo.Text = "Intervalo Verificacao"
        '
        'chkVerif
        '
        Me.chkVerif.AutoSize = True
        Me.chkVerif.Location = New System.Drawing.Point(182, 10)
        Me.chkVerif.Name = "chkVerif"
        Me.chkVerif.Size = New System.Drawing.Size(51, 17)
        Me.chkVerif.TabIndex = 4
        Me.chkVerif.Text = "Filtrar"
        Me.chkVerif.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Inicial"
        '
        'dtVerifFim
        '
        Me.dtVerifFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVerifFim.Location = New System.Drawing.Point(107, 27)
        Me.dtVerifFim.Name = "dtVerifFim"
        Me.dtVerifFim.Size = New System.Drawing.Size(83, 20)
        Me.dtVerifFim.TabIndex = 1
        '
        'dtVerifIni
        '
        Me.dtVerifIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVerifIni.Location = New System.Drawing.Point(6, 27)
        Me.dtVerifIni.Name = "dtVerifIni"
        Me.dtVerifIni.Size = New System.Drawing.Size(83, 20)
        Me.dtVerifIni.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbLoja)
        Me.GroupBox1.Controls.Add(Me.chkLoja)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(262, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 53)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loja / Cliente"
        '
        'cbLoja
        '
        Me.cbLoja.FormattingEnabled = True
        Me.cbLoja.Location = New System.Drawing.Point(12, 27)
        Me.cbLoja.Name = "cbLoja"
        Me.cbLoja.Size = New System.Drawing.Size(274, 21)
        Me.cbLoja.TabIndex = 5
        '
        'chkLoja
        '
        Me.chkLoja.AutoSize = True
        Me.chkLoja.Location = New System.Drawing.Point(187, 10)
        Me.chkLoja.Name = "chkLoja"
        Me.chkLoja.Size = New System.Drawing.Size(51, 17)
        Me.chkLoja.TabIndex = 4
        Me.chkLoja.Text = "Filtrar"
        Me.chkLoja.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Inicial"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkEntrega)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dtEntregaFim)
        Me.GroupBox2.Controls.Add(Me.dtEntregaIni)
        Me.GroupBox2.Location = New System.Drawing.Point(573, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 53)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Intervalo Previsão Entrega"
        '
        'chkEntrega
        '
        Me.chkEntrega.AutoSize = True
        Me.chkEntrega.Location = New System.Drawing.Point(182, 10)
        Me.chkEntrega.Name = "chkEntrega"
        Me.chkEntrega.Size = New System.Drawing.Size(51, 17)
        Me.chkEntrega.TabIndex = 4
        Me.chkEntrega.Text = "Filtrar"
        Me.chkEntrega.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Inicial"
        '
        'dtEntregaFim
        '
        Me.dtEntregaFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEntregaFim.Location = New System.Drawing.Point(107, 27)
        Me.dtEntregaFim.Name = "dtEntregaFim"
        Me.dtEntregaFim.Size = New System.Drawing.Size(83, 20)
        Me.dtEntregaFim.TabIndex = 1
        '
        'dtEntregaIni
        '
        Me.dtEntregaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEntregaIni.Location = New System.Drawing.Point(6, 27)
        Me.dtEntregaIni.Name = "dtEntregaIni"
        Me.dtEntregaIni.Size = New System.Drawing.Size(83, 20)
        Me.dtEntregaIni.TabIndex = 0
        '
        'txtMax
        '
        Me.txtMax.BackColor = System.Drawing.Color.White
        Me.txtMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMax.Location = New System.Drawing.Point(823, 10)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.ReadOnly = True
        Me.txtMax.Size = New System.Drawing.Size(157, 20)
        Me.txtMax.TabIndex = 9
        '
        'frmOsNaoConcluida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 552)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpIntervalo)
        Me.Controls.Add(Me.grdOS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOsNaoConcluida"
        Me.Text = "OS's não concluídas"
        CType(Me.grdOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpIntervalo.ResumeLayout(False)
        Me.grpIntervalo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdOS As System.Windows.Forms.DataGrid
    Friend WithEvents grpIntervalo As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtVerifFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtVerifIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkVerif As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbLoja As System.Windows.Forms.ComboBox
    Friend WithEvents chkLoja As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkEntrega As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtEntregaFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtEntregaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
End Class
