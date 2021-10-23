<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaProdDiop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaProdDiop))
        Me.grpLente = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEsf = New System.Windows.Forms.TextBox()
        Me.grpBloco = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOlho = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAdicao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.grpLente.SuspendLayout()
        Me.grpBloco.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLente
        '
        Me.grpLente.Controls.Add(Me.Label2)
        Me.grpLente.Controls.Add(Me.txtCil)
        Me.grpLente.Controls.Add(Me.Label1)
        Me.grpLente.Controls.Add(Me.txtEsf)
        Me.grpLente.Location = New System.Drawing.Point(12, 6)
        Me.grpLente.Name = "grpLente"
        Me.grpLente.Size = New System.Drawing.Size(115, 57)
        Me.grpLente.TabIndex = 0
        Me.grpLente.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cilindrico"
        '
        'txtCil
        '
        Me.txtCil.Location = New System.Drawing.Point(57, 28)
        Me.txtCil.Name = "txtCil"
        Me.txtCil.Size = New System.Drawing.Size(42, 20)
        Me.txtCil.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Esférico"
        '
        'txtEsf
        '
        Me.txtEsf.Location = New System.Drawing.Point(9, 28)
        Me.txtEsf.Name = "txtEsf"
        Me.txtEsf.Size = New System.Drawing.Size(42, 20)
        Me.txtEsf.TabIndex = 1
        '
        'grpBloco
        '
        Me.grpBloco.Controls.Add(Me.Label5)
        Me.grpBloco.Controls.Add(Me.txtOlho)
        Me.grpBloco.Controls.Add(Me.Label3)
        Me.grpBloco.Controls.Add(Me.txtAdicao)
        Me.grpBloco.Controls.Add(Me.Label4)
        Me.grpBloco.Controls.Add(Me.txtBase)
        Me.grpBloco.Location = New System.Drawing.Point(12, 72)
        Me.grpBloco.Name = "grpBloco"
        Me.grpBloco.Size = New System.Drawing.Size(151, 56)
        Me.grpBloco.TabIndex = 5
        Me.grpBloco.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Olho"
        '
        'txtOlho
        '
        Me.txtOlho.Location = New System.Drawing.Point(105, 28)
        Me.txtOlho.Name = "txtOlho"
        Me.txtOlho.Size = New System.Drawing.Size(31, 20)
        Me.txtOlho.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Adicao"
        '
        'txtAdicao
        '
        Me.txtAdicao.Location = New System.Drawing.Point(57, 28)
        Me.txtAdicao.Name = "txtAdicao"
        Me.txtAdicao.Size = New System.Drawing.Size(42, 20)
        Me.txtAdicao.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Base"
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(9, 28)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(42, 20)
        Me.txtBase.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(52, 134)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmConsultaProdDiop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(172, 164)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.grpBloco)
        Me.Controls.Add(Me.grpLente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultaProdDiop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Confirma"
        Me.grpLente.ResumeLayout(False)
        Me.grpLente.PerformLayout()
        Me.grpBloco.ResumeLayout(False)
        Me.grpBloco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpLente As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEsf As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCil As System.Windows.Forms.TextBox
    Friend WithEvents grpBloco As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAdicao As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBase As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOlho As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
