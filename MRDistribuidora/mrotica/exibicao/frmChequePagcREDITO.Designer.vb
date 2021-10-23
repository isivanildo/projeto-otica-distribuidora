<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequePagCredito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequePagCredito))
        Me.cbBanco = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAgencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.chkAcrescimo = New System.Windows.Forms.CheckBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtValPag = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtVencimento = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grdRec = New System.Windows.Forms.DataGrid()
        CType(Me.grdRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbBanco
        '
        Me.cbBanco.FormattingEnabled = True
        Me.cbBanco.Location = New System.Drawing.Point(5, 220)
        Me.cbBanco.Name = "cbBanco"
        Me.cbBanco.Size = New System.Drawing.Size(268, 21)
        Me.cbBanco.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Banco"
        '
        'txtAgencia
        '
        Me.txtAgencia.Location = New System.Drawing.Point(5, 261)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Size = New System.Drawing.Size(74, 20)
        Me.txtAgencia.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Agência"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Conta Corrente"
        '
        'txtCC
        '
        Me.txtCC.Location = New System.Drawing.Point(85, 261)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(78, 20)
        Me.txtCC.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nº do Cheque"
        '
        'txtCheque
        '
        Me.txtCheque.Location = New System.Drawing.Point(169, 261)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(94, 20)
        Me.txtCheque.TabIndex = 6
        '
        'chkAcrescimo
        '
        Me.chkAcrescimo.AutoSize = True
        Me.chkAcrescimo.Location = New System.Drawing.Point(140, 2)
        Me.chkAcrescimo.Name = "chkAcrescimo"
        Me.chkAcrescimo.Size = New System.Drawing.Size(75, 17)
        Me.chkAcrescimo.TabIndex = 1
        Me.chkAcrescimo.Text = "Acréscimo"
        Me.chkAcrescimo.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(105, 297)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(248, 23)
        Me.btnSalvar.TabIndex = 21
        Me.btnSalvar.Text = "&Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Total"
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.Location = New System.Drawing.Point(45, 2)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ReadOnly = True
        Me.txtValor.Size = New System.Drawing.Size(74, 20)
        Me.txtValor.TabIndex = 0
        '
        'txtValPag
        '
        Me.txtValPag.Location = New System.Drawing.Point(269, 261)
        Me.txtValPag.Name = "txtValPag"
        Me.txtValPag.Size = New System.Drawing.Size(85, 20)
        Me.txtValPag.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(266, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Valor"
        '
        'dtVencimento
        '
        Me.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVencimento.Location = New System.Drawing.Point(5, 300)
        Me.dtVencimento.Name = "dtVencimento"
        Me.dtVencimento.Size = New System.Drawing.Size(94, 20)
        Me.dtVencimento.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Data Vencimento"
        '
        'grdRec
        '
        Me.grdRec.AllowSorting = False
        Me.grdRec.DataMember = ""
        Me.grdRec.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdRec.Location = New System.Drawing.Point(5, 25)
        Me.grdRec.Name = "grdRec"
        Me.grdRec.ReadOnly = True
        Me.grdRec.Size = New System.Drawing.Size(348, 175)
        Me.grdRec.TabIndex = 16
        '
        'frmChequePagCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 337)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtVencimento)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtValPag)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.grdRec)
        Me.Controls.Add(Me.chkAcrescimo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCheque)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAgencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbBanco)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChequePagCredito"
        Me.Text = "Pagamentos com Cheque"
        CType(Me.grdRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAgencia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents chkAcrescimo As System.Windows.Forms.CheckBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents txtValPag As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtVencimento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grdRec As System.Windows.Forms.DataGrid
End Class
