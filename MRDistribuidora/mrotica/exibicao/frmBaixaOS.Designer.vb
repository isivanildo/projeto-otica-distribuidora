<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaixaOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaixaOS))
        Me.txtBarraOD = New System.Windows.Forms.TextBox()
        Me.lblProdTabelaOD = New System.Windows.Forms.TextBox()
        Me.lblProdEstOD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblProdEstOE = New System.Windows.Forms.TextBox()
        Me.lblProdTabelaOE = New System.Windows.Forms.TextBox()
        Me.txtBarraOE = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnBaixa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSair = New System.Windows.Forms.ToolStripButton()
        Me.grdSaiu = New System.Windows.Forms.DataGrid()
        Me.chkProdDif = New System.Windows.Forms.CheckBox()
        Me.btnConcluir = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdSaiu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBarraOD
        '
        Me.txtBarraOD.Location = New System.Drawing.Point(419, 89)
        Me.txtBarraOD.Name = "txtBarraOD"
        Me.txtBarraOD.Size = New System.Drawing.Size(125, 20)
        Me.txtBarraOD.TabIndex = 0
        '
        'lblProdTabelaOD
        '
        Me.lblProdTabelaOD.BackColor = System.Drawing.SystemColors.Control
        Me.lblProdTabelaOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProdTabelaOD.Enabled = False
        Me.lblProdTabelaOD.Location = New System.Drawing.Point(9, 89)
        Me.lblProdTabelaOD.Name = "lblProdTabelaOD"
        Me.lblProdTabelaOD.ReadOnly = True
        Me.lblProdTabelaOD.Size = New System.Drawing.Size(397, 20)
        Me.lblProdTabelaOD.TabIndex = 1
        '
        'lblProdEstOD
        '
        Me.lblProdEstOD.BackColor = System.Drawing.SystemColors.Control
        Me.lblProdEstOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProdEstOD.Enabled = False
        Me.lblProdEstOD.Location = New System.Drawing.Point(9, 115)
        Me.lblProdEstOD.Name = "lblProdEstOD"
        Me.lblProdEstOD.ReadOnly = True
        Me.lblProdEstOD.Size = New System.Drawing.Size(397, 20)
        Me.lblProdEstOD.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Produto olho direito"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(416, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Confirmar código de barras"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(419, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Confirmar código de barras"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Produto olho esquerdo"
        '
        'lblProdEstOE
        '
        Me.lblProdEstOE.BackColor = System.Drawing.SystemColors.Control
        Me.lblProdEstOE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProdEstOE.Enabled = False
        Me.lblProdEstOE.Location = New System.Drawing.Point(12, 195)
        Me.lblProdEstOE.Name = "lblProdEstOE"
        Me.lblProdEstOE.ReadOnly = True
        Me.lblProdEstOE.Size = New System.Drawing.Size(397, 20)
        Me.lblProdEstOE.TabIndex = 8
        '
        'lblProdTabelaOE
        '
        Me.lblProdTabelaOE.BackColor = System.Drawing.SystemColors.Control
        Me.lblProdTabelaOE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProdTabelaOE.Enabled = False
        Me.lblProdTabelaOE.Location = New System.Drawing.Point(12, 169)
        Me.lblProdTabelaOE.Name = "lblProdTabelaOE"
        Me.lblProdTabelaOE.ReadOnly = True
        Me.lblProdTabelaOE.Size = New System.Drawing.Size(397, 20)
        Me.lblProdTabelaOE.TabIndex = 7
        '
        'txtBarraOE
        '
        Me.txtBarraOE.Location = New System.Drawing.Point(422, 169)
        Me.txtBarraOE.Name = "txtBarraOE"
        Me.txtBarraOE.Size = New System.Drawing.Size(125, 20)
        Me.txtBarraOE.TabIndex = 6
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBaixa, Me.ToolStripSeparator1, Me.btnSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(559, 39)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBaixa
        '
        Me.btnBaixa.Enabled = False
        Me.btnBaixa.Image = CType(resources.GetObject("btnBaixa.Image"), System.Drawing.Image)
        Me.btnBaixa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBaixa.Name = "btnBaixa"
        Me.btnBaixa.Size = New System.Drawing.Size(102, 36)
        Me.btnBaixa.Text = "Nova Baixa"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(62, 36)
        Me.btnSair.Text = "Sair"
        '
        'grdSaiu
        '
        Me.grdSaiu.AllowSorting = False
        Me.grdSaiu.CaptionText = "Itens"
        Me.grdSaiu.DataMember = ""
        Me.grdSaiu.FlatMode = True
        Me.grdSaiu.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdSaiu.Location = New System.Drawing.Point(12, 221)
        Me.grdSaiu.Name = "grdSaiu"
        Me.grdSaiu.ReadOnly = True
        Me.grdSaiu.Size = New System.Drawing.Size(540, 116)
        Me.grdSaiu.TabIndex = 23
        '
        'chkProdDif
        '
        Me.chkProdDif.AutoSize = True
        Me.chkProdDif.Location = New System.Drawing.Point(12, 42)
        Me.chkProdDif.Name = "chkProdDif"
        Me.chkProdDif.Size = New System.Drawing.Size(150, 17)
        Me.chkProdDif.TabIndex = 24
        Me.chkProdDif.Text = "Produtos diferentes da OS"
        Me.chkProdDif.UseVisualStyleBackColor = True
        '
        'btnConcluir
        '
        Me.btnConcluir.Location = New System.Drawing.Point(214, 348)
        Me.btnConcluir.Name = "btnConcluir"
        Me.btnConcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnConcluir.TabIndex = 25
        Me.btnConcluir.Text = "Concluir"
        Me.btnConcluir.UseVisualStyleBackColor = True
        '
        'frmBaixaOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 383)
        Me.Controls.Add(Me.btnConcluir)
        Me.Controls.Add(Me.chkProdDif)
        Me.Controls.Add(Me.grdSaiu)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtBarraOD)
        Me.Controls.Add(Me.txtBarraOE)
        Me.Controls.Add(Me.lblProdEstOE)
        Me.Controls.Add(Me.lblProdTabelaOE)
        Me.Controls.Add(Me.lblProdEstOD)
        Me.Controls.Add(Me.lblProdTabelaOD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBaixaOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baixa de Produto OS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdSaiu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBarraOD As System.Windows.Forms.TextBox
    Friend WithEvents lblProdTabelaOD As System.Windows.Forms.TextBox
    Friend WithEvents lblProdEstOD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblProdEstOE As System.Windows.Forms.TextBox
    Friend WithEvents lblProdTabelaOE As System.Windows.Forms.TextBox
    Friend WithEvents txtBarraOE As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBaixa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdSaiu As DataGrid
    Friend WithEvents chkProdDif As CheckBox
    Friend WithEvents btnConcluir As Button
End Class
