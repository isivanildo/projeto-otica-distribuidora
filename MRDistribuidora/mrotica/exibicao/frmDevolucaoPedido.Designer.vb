<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevolucaoPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevolucaoPedido))
        Me.grpBaixa = New System.Windows.Forms.GroupBox()
        Me.txtBarra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblQDevolvida = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblQDevolver = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdDevolvido = New System.Windows.Forms.DataGrid()
        Me.btnConcluir = New System.Windows.Forms.Button()
        Me.grdProd = New System.Windows.Forms.DataGrid()
        Me.grpBaixa.SuspendLayout()
        CType(Me.grdDevolvido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBaixa
        '
        Me.grpBaixa.Controls.Add(Me.txtBarra)
        Me.grpBaixa.Controls.Add(Me.Label6)
        Me.grpBaixa.Controls.Add(Me.lblQDevolvida)
        Me.grpBaixa.Controls.Add(Me.Label7)
        Me.grpBaixa.Controls.Add(Me.lblQDevolver)
        Me.grpBaixa.Controls.Add(Me.Label2)
        Me.grpBaixa.Controls.Add(Me.grdDevolvido)
        Me.grpBaixa.Location = New System.Drawing.Point(5, 200)
        Me.grpBaixa.Name = "grpBaixa"
        Me.grpBaixa.Size = New System.Drawing.Size(692, 175)
        Me.grpBaixa.TabIndex = 21
        Me.grpBaixa.TabStop = False
        '
        'txtBarra
        '
        Me.txtBarra.Location = New System.Drawing.Point(490, 30)
        Me.txtBarra.Name = "txtBarra"
        Me.txtBarra.Size = New System.Drawing.Size(125, 20)
        Me.txtBarra.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(487, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Confirmar código de barras"
        '
        'lblQDevolvida
        '
        Me.lblQDevolvida.AutoSize = True
        Me.lblQDevolvida.Location = New System.Drawing.Point(614, 68)
        Me.lblQDevolvida.Name = "lblQDevolvida"
        Me.lblQDevolvida.Size = New System.Drawing.Size(13, 13)
        Me.lblQDevolvida.TabIndex = 25
        Me.lblQDevolvida.Text = "0"
        Me.lblQDevolvida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(489, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Quantidade devolvida"
        '
        'lblQDevolver
        '
        Me.lblQDevolver.AutoSize = True
        Me.lblQDevolver.Location = New System.Drawing.Point(614, 53)
        Me.lblQDevolver.Name = "lblQDevolver"
        Me.lblQDevolver.Size = New System.Drawing.Size(13, 13)
        Me.lblQDevolver.TabIndex = 23
        Me.lblQDevolver.Text = "0"
        Me.lblQDevolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Quantidade a devolver"
        '
        'grdDevolvido
        '
        Me.grdDevolvido.AllowSorting = False
        Me.grdDevolvido.CaptionText = "Devolucões"
        Me.grdDevolvido.DataMember = ""
        Me.grdDevolvido.FlatMode = True
        Me.grdDevolvido.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdDevolvido.Location = New System.Drawing.Point(6, 11)
        Me.grdDevolvido.Name = "grdDevolvido"
        Me.grdDevolvido.ReadOnly = True
        Me.grdDevolvido.Size = New System.Drawing.Size(475, 158)
        Me.grdDevolvido.TabIndex = 19
        '
        'btnConcluir
        '
        Me.btnConcluir.Location = New System.Drawing.Point(252, 381)
        Me.btnConcluir.Name = "btnConcluir"
        Me.btnConcluir.Size = New System.Drawing.Size(145, 23)
        Me.btnConcluir.TabIndex = 26
        Me.btnConcluir.Text = "Concluir Devolução"
        Me.btnConcluir.UseVisualStyleBackColor = True
        '
        'grdProd
        '
        Me.grdProd.AllowSorting = False
        Me.grdProd.CaptionText = "Produtos"
        Me.grdProd.DataMember = ""
        Me.grdProd.FlatMode = True
        Me.grdProd.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdProd.Location = New System.Drawing.Point(5, 11)
        Me.grdProd.Name = "grdProd"
        Me.grdProd.ReadOnly = True
        Me.grdProd.Size = New System.Drawing.Size(692, 183)
        Me.grdProd.TabIndex = 20
        '
        'frmDevolucaoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 411)
        Me.Controls.Add(Me.grpBaixa)
        Me.Controls.Add(Me.grdProd)
        Me.Controls.Add(Me.btnConcluir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDevolucaoPedido"
        Me.Text = "frmDevolucaoPedido"
        Me.grpBaixa.ResumeLayout(False)
        Me.grpBaixa.PerformLayout()
        CType(Me.grdDevolvido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBaixa As System.Windows.Forms.GroupBox
    Friend WithEvents txtBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnConcluir As System.Windows.Forms.Button
    Friend WithEvents lblQDevolvida As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblQDevolver As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grdDevolvido As System.Windows.Forms.DataGrid
    Friend WithEvents grdProd As System.Windows.Forms.DataGrid
End Class
