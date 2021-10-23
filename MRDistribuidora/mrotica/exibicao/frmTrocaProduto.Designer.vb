<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrocaProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrocaProduto))
        Me.grpDevolucao = New System.Windows.Forms.GroupBox()
        Me.txtCodBarraOE = New System.Windows.Forms.TextBox()
        Me.txtCodbarraOD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPoe = New System.Windows.Forms.TextBox()
        Me.txtPod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodOE = New System.Windows.Forms.TextBox()
        Me.txtcodOD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.grpNovo = New System.Windows.Forms.GroupBox()
        Me.txtCodBarraNOE = New System.Windows.Forms.TextBox()
        Me.txtCodBarraNOD = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnPoe = New System.Windows.Forms.TextBox()
        Me.txtnpod = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodNOE = New System.Windows.Forms.TextBox()
        Me.txtCodnOD = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.grpDevolucao.SuspendLayout()
        Me.grpNovo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDevolucao
        '
        Me.grpDevolucao.Controls.Add(Me.txtCodBarraOE)
        Me.grpDevolucao.Controls.Add(Me.txtCodbarraOD)
        Me.grpDevolucao.Controls.Add(Me.Label4)
        Me.grpDevolucao.Controls.Add(Me.Label5)
        Me.grpDevolucao.Controls.Add(Me.txtPoe)
        Me.grpDevolucao.Controls.Add(Me.txtPod)
        Me.grpDevolucao.Controls.Add(Me.Label2)
        Me.grpDevolucao.Controls.Add(Me.Label3)
        Me.grpDevolucao.Controls.Add(Me.txtCodOE)
        Me.grpDevolucao.Controls.Add(Me.txtcodOD)
        Me.grpDevolucao.Controls.Add(Me.Label1)
        Me.grpDevolucao.Controls.Add(Me.lbl)
        Me.grpDevolucao.Location = New System.Drawing.Point(12, 2)
        Me.grpDevolucao.Name = "grpDevolucao"
        Me.grpDevolucao.Size = New System.Drawing.Size(597, 113)
        Me.grpDevolucao.TabIndex = 0
        Me.grpDevolucao.TabStop = False
        Me.grpDevolucao.Text = "Devolução para o estoque."
        '
        'txtCodBarraOE
        '
        Me.txtCodBarraOE.Location = New System.Drawing.Point(467, 75)
        Me.txtCodBarraOE.Name = "txtCodBarraOE"
        Me.txtCodBarraOE.Size = New System.Drawing.Size(100, 20)
        Me.txtCodBarraOE.TabIndex = 5
        '
        'txtCodbarraOD
        '
        Me.txtCodbarraOD.Location = New System.Drawing.Point(467, 36)
        Me.txtCodbarraOD.Name = "txtCodbarraOD"
        Me.txtCodbarraOD.Size = New System.Drawing.Size(100, 20)
        Me.txtCodbarraOD.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(464, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Código de Barras"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(464, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Código de Barras"
        '
        'txtPoe
        '
        Me.txtPoe.Location = New System.Drawing.Point(123, 75)
        Me.txtPoe.Name = "txtPoe"
        Me.txtPoe.ReadOnly = True
        Me.txtPoe.Size = New System.Drawing.Size(335, 20)
        Me.txtPoe.TabIndex = 4
        '
        'txtPod
        '
        Me.txtPod.Location = New System.Drawing.Point(123, 36)
        Me.txtPod.Name = "txtPod"
        Me.txtPod.ReadOnly = True
        Me.txtPod.Size = New System.Drawing.Size(335, 20)
        Me.txtPod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Codigo olho esquerdo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Codigo olho direito"
        '
        'txtCodOE
        '
        Me.txtCodOE.Location = New System.Drawing.Point(10, 75)
        Me.txtCodOE.Name = "txtCodOE"
        Me.txtCodOE.ReadOnly = True
        Me.txtCodOE.Size = New System.Drawing.Size(100, 20)
        Me.txtCodOE.TabIndex = 3
        '
        'txtcodOD
        '
        Me.txtcodOD.Location = New System.Drawing.Point(10, 36)
        Me.txtcodOD.Name = "txtcodOD"
        Me.txtcodOD.ReadOnly = True
        Me.txtcodOD.Size = New System.Drawing.Size(100, 20)
        Me.txtcodOD.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo olho esquerdo"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(7, 20)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(94, 13)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "Codigo olho direito"
        '
        'grpNovo
        '
        Me.grpNovo.Controls.Add(Me.txtCodBarraNOE)
        Me.grpNovo.Controls.Add(Me.txtCodBarraNOD)
        Me.grpNovo.Controls.Add(Me.Label6)
        Me.grpNovo.Controls.Add(Me.Label7)
        Me.grpNovo.Controls.Add(Me.txtnPoe)
        Me.grpNovo.Controls.Add(Me.txtnpod)
        Me.grpNovo.Controls.Add(Me.Label8)
        Me.grpNovo.Controls.Add(Me.Label9)
        Me.grpNovo.Controls.Add(Me.txtCodNOE)
        Me.grpNovo.Controls.Add(Me.txtCodnOD)
        Me.grpNovo.Controls.Add(Me.Label10)
        Me.grpNovo.Controls.Add(Me.Label11)
        Me.grpNovo.Enabled = False
        Me.grpNovo.Location = New System.Drawing.Point(12, 121)
        Me.grpNovo.Name = "grpNovo"
        Me.grpNovo.Size = New System.Drawing.Size(597, 116)
        Me.grpNovo.TabIndex = 1
        Me.grpNovo.TabStop = False
        Me.grpNovo.Text = "Baixa produto Novo"
        '
        'txtCodBarraNOE
        '
        Me.txtCodBarraNOE.Location = New System.Drawing.Point(467, 75)
        Me.txtCodBarraNOE.Name = "txtCodBarraNOE"
        Me.txtCodBarraNOE.Size = New System.Drawing.Size(100, 20)
        Me.txtCodBarraNOE.TabIndex = 5
        '
        'txtCodBarraNOD
        '
        Me.txtCodBarraNOD.Location = New System.Drawing.Point(467, 36)
        Me.txtCodBarraNOD.Name = "txtCodBarraNOD"
        Me.txtCodBarraNOD.Size = New System.Drawing.Size(100, 20)
        Me.txtCodBarraNOD.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(464, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Código de Barras"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(464, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Código de Barras"
        '
        'txtnPoe
        '
        Me.txtnPoe.Location = New System.Drawing.Point(123, 75)
        Me.txtnPoe.Name = "txtnPoe"
        Me.txtnPoe.ReadOnly = True
        Me.txtnPoe.Size = New System.Drawing.Size(335, 20)
        Me.txtnPoe.TabIndex = 4
        '
        'txtnpod
        '
        Me.txtnpod.Location = New System.Drawing.Point(123, 36)
        Me.txtnpod.Name = "txtnpod"
        Me.txtnpod.ReadOnly = True
        Me.txtnpod.Size = New System.Drawing.Size(335, 20)
        Me.txtnpod.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(120, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Codigo olho esquerdo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(120, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Codigo olho direito"
        '
        'txtCodNOE
        '
        Me.txtCodNOE.Location = New System.Drawing.Point(10, 75)
        Me.txtCodNOE.Name = "txtCodNOE"
        Me.txtCodNOE.ReadOnly = True
        Me.txtCodNOE.Size = New System.Drawing.Size(100, 20)
        Me.txtCodNOE.TabIndex = 3
        '
        'txtCodnOD
        '
        Me.txtCodnOD.Location = New System.Drawing.Point(10, 36)
        Me.txtCodnOD.Name = "txtCodnOD"
        Me.txtCodnOD.ReadOnly = True
        Me.txtCodnOD.Size = New System.Drawing.Size(100, 20)
        Me.txtCodnOD.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Codigo olho esquerdo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Codigo olho direito"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(12, 244)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(597, 77)
        Me.txtObs.TabIndex = 2
        '
        'frmTrocaProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 333)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.grpNovo)
        Me.Controls.Add(Me.grpDevolucao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTrocaProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Troca de Produto"
        Me.grpDevolucao.ResumeLayout(False)
        Me.grpDevolucao.PerformLayout()
        Me.grpNovo.ResumeLayout(False)
        Me.grpNovo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpDevolucao As System.Windows.Forms.GroupBox
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodOD As System.Windows.Forms.TextBox
    Friend WithEvents txtCodOE As System.Windows.Forms.TextBox
    Friend WithEvents txtPoe As System.Windows.Forms.TextBox
    Friend WithEvents txtPod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodBarraOE As System.Windows.Forms.TextBox
    Friend WithEvents txtCodbarraOD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grpNovo As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodBarraNOE As System.Windows.Forms.TextBox
    Friend WithEvents txtCodBarraNOD As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnPoe As System.Windows.Forms.TextBox
    Friend WithEvents txtnpod As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCodNOE As System.Windows.Forms.TextBox
    Friend WithEvents txtCodnOD As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
End Class
