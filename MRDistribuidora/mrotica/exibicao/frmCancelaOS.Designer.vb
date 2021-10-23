<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelaOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCancelaOS))
        Me.txtOS = New System.Windows.Forms.TextBox()
        Me.grpOS = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFilial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdescricao = New System.Windows.Forms.TextBox()
        Me.grpDevolve = New System.Windows.Forms.GroupBox()
        Me.txtCodBarraOE = New System.Windows.Forms.TextBox()
        Me.txtCodBarraOD = New System.Windows.Forms.TextBox()
        Me.lblPOE = New System.Windows.Forms.Label()
        Me.lblPOD = New System.Windows.Forms.Label()
        Me.grpDesc = New System.Windows.Forms.GroupBox()
        Me.txtDesc = New System.Windows.Forms.RichTextBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnOKOS = New System.Windows.Forms.Button()
        Me.grpOS.SuspendLayout()
        Me.grpDevolve.SuspendLayout()
        Me.grpDesc.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOS
        '
        Me.txtOS.Location = New System.Drawing.Point(143, 23)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(100, 20)
        Me.txtOS.TabIndex = 1
        '
        'grpOS
        '
        Me.grpOS.Controls.Add(Me.Label3)
        Me.grpOS.Controls.Add(Me.Label2)
        Me.grpOS.Controls.Add(Me.txtFilial)
        Me.grpOS.Controls.Add(Me.Label1)
        Me.grpOS.Controls.Add(Me.txtdescricao)
        Me.grpOS.Controls.Add(Me.txtOS)
        Me.grpOS.Location = New System.Drawing.Point(12, 12)
        Me.grpOS.Name = "grpOS"
        Me.grpOS.Size = New System.Drawing.Size(551, 148)
        Me.grpOS.TabIndex = 0
        Me.grpOS.TabStop = False
        Me.grpOS.Text = "Dados da OS a ser cancelada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nº OS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Filial:"
        '
        'txtFilial
        '
        Me.txtFilial.Location = New System.Drawing.Point(42, 23)
        Me.txtFilial.Name = "txtFilial"
        Me.txtFilial.Size = New System.Drawing.Size(44, 20)
        Me.txtFilial.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Motivo"
        '
        'txtdescricao
        '
        Me.txtdescricao.Enabled = False
        Me.txtdescricao.Location = New System.Drawing.Point(5, 70)
        Me.txtdescricao.Multiline = True
        Me.txtdescricao.Name = "txtdescricao"
        Me.txtdescricao.Size = New System.Drawing.Size(536, 66)
        Me.txtdescricao.TabIndex = 2
        '
        'grpDevolve
        '
        Me.grpDevolve.Controls.Add(Me.txtCodBarraOE)
        Me.grpDevolve.Controls.Add(Me.txtCodBarraOD)
        Me.grpDevolve.Controls.Add(Me.lblPOE)
        Me.grpDevolve.Controls.Add(Me.lblPOD)
        Me.grpDevolve.Location = New System.Drawing.Point(12, 177)
        Me.grpDevolve.Name = "grpDevolve"
        Me.grpDevolve.Size = New System.Drawing.Size(551, 72)
        Me.grpDevolve.TabIndex = 2
        Me.grpDevolve.TabStop = False
        Me.grpDevolve.Text = "Devolução"
        '
        'txtCodBarraOE
        '
        Me.txtCodBarraOE.Enabled = False
        Me.txtCodBarraOE.Location = New System.Drawing.Point(439, 42)
        Me.txtCodBarraOE.Name = "txtCodBarraOE"
        Me.txtCodBarraOE.Size = New System.Drawing.Size(100, 20)
        Me.txtCodBarraOE.TabIndex = 3
        '
        'txtCodBarraOD
        '
        Me.txtCodBarraOD.Enabled = False
        Me.txtCodBarraOD.Location = New System.Drawing.Point(439, 16)
        Me.txtCodBarraOD.Name = "txtCodBarraOD"
        Me.txtCodBarraOD.Size = New System.Drawing.Size(100, 20)
        Me.txtCodBarraOD.TabIndex = 1
        '
        'lblPOE
        '
        Me.lblPOE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPOE.Location = New System.Drawing.Point(13, 44)
        Me.lblPOE.Name = "lblPOE"
        Me.lblPOE.Size = New System.Drawing.Size(418, 18)
        Me.lblPOE.TabIndex = 2
        Me.lblPOE.Text = "OE"
        '
        'lblPOD
        '
        Me.lblPOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPOD.Location = New System.Drawing.Point(13, 16)
        Me.lblPOD.Name = "lblPOD"
        Me.lblPOD.Size = New System.Drawing.Size(418, 18)
        Me.lblPOD.TabIndex = 0
        Me.lblPOD.Text = "OD"
        '
        'grpDesc
        '
        Me.grpDesc.Controls.Add(Me.txtDesc)
        Me.grpDesc.Location = New System.Drawing.Point(12, 254)
        Me.grpDesc.Name = "grpDesc"
        Me.grpDesc.Size = New System.Drawing.Size(551, 239)
        Me.grpDesc.TabIndex = 3
        Me.grpDesc.TabStop = False
        Me.grpDesc.Text = "Descrição"
        '
        'txtDesc
        '
        Me.txtDesc.Enabled = False
        Me.txtDesc.Location = New System.Drawing.Point(5, 19)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(536, 213)
        Me.txtDesc.TabIndex = 0
        Me.txtDesc.Text = ""
        '
        'btnSair
        '
        Me.btnSair.Enabled = False
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.Location = New System.Drawing.Point(569, 51)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(83, 31)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnOKOS
        '
        Me.btnOKOS.Enabled = False
        Me.btnOKOS.Image = CType(resources.GetObject("btnOKOS.Image"), System.Drawing.Image)
        Me.btnOKOS.Location = New System.Drawing.Point(569, 16)
        Me.btnOKOS.Name = "btnOKOS"
        Me.btnOKOS.Size = New System.Drawing.Size(83, 31)
        Me.btnOKOS.TabIndex = 1
        Me.btnOKOS.Text = "OK"
        Me.btnOKOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOKOS.UseVisualStyleBackColor = True
        '
        'frmCancelaOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 509)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.grpDesc)
        Me.Controls.Add(Me.grpDevolve)
        Me.Controls.Add(Me.grpOS)
        Me.Controls.Add(Me.btnOKOS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCancelaOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelamento de OS"
        Me.grpOS.ResumeLayout(False)
        Me.grpOS.PerformLayout()
        Me.grpDevolve.ResumeLayout(False)
        Me.grpDevolve.PerformLayout()
        Me.grpDesc.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtOS As System.Windows.Forms.TextBox
    Friend WithEvents grpOS As System.Windows.Forms.GroupBox
    Friend WithEvents btnOKOS As System.Windows.Forms.Button
    Friend WithEvents grpDevolve As System.Windows.Forms.GroupBox
    Friend WithEvents lblPOD As System.Windows.Forms.Label
    Friend WithEvents lblPOE As System.Windows.Forms.Label
    Friend WithEvents txtCodBarraOE As System.Windows.Forms.TextBox
    Friend WithEvents txtCodBarraOD As System.Windows.Forms.TextBox
    Friend WithEvents grpDesc As System.Windows.Forms.GroupBox
    Friend WithEvents txtDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents txtdescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFilial As System.Windows.Forms.TextBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
