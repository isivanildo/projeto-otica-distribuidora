<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaLenteTabela
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaLenteTabela))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCriterio1 = New System.Windows.Forms.TextBox()
        Me.grdLen = New System.Windows.Forms.DataGrid()
        Me.gbPesquisa = New System.Windows.Forms.GroupBox()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        CType(Me.grdLen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPesquisa.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nome da Lente:"
        '
        'txtCriterio1
        '
        Me.txtCriterio1.Location = New System.Drawing.Point(96, 23)
        Me.txtCriterio1.Name = "txtCriterio1"
        Me.txtCriterio1.Size = New System.Drawing.Size(438, 20)
        Me.txtCriterio1.TabIndex = 2
        '
        'grdLen
        '
        Me.grdLen.DataMember = ""
        Me.grdLen.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdLen.Location = New System.Drawing.Point(13, 75)
        Me.grdLen.Name = "grdLen"
        Me.grdLen.Size = New System.Drawing.Size(600, 309)
        Me.grdLen.TabIndex = 2
        '
        'gbPesquisa
        '
        Me.gbPesquisa.Controls.Add(Me.btnLocalizar)
        Me.gbPesquisa.Controls.Add(Me.txtCriterio1)
        Me.gbPesquisa.Controls.Add(Me.Label1)
        Me.gbPesquisa.Location = New System.Drawing.Point(13, 11)
        Me.gbPesquisa.Name = "gbPesquisa"
        Me.gbPesquisa.Size = New System.Drawing.Size(599, 52)
        Me.gbPesquisa.TabIndex = 0
        Me.gbPesquisa.TabStop = False
        Me.gbPesquisa.Text = "Pesquisar por"
        '
        'btnLocalizar
        '
        Me.btnLocalizar.Image = CType(resources.GetObject("btnLocalizar.Image"), System.Drawing.Image)
        Me.btnLocalizar.Location = New System.Drawing.Point(549, 19)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(43, 27)
        Me.btnLocalizar.TabIndex = 4
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.Location = New System.Drawing.Point(273, 400)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(79, 33)
        Me.btnFechar.TabIndex = 3
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'frmConsultaLenteTabela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 447)
        Me.Controls.Add(Me.gbPesquisa)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.grdLen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaLenteTabela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Lente Tabela"
        CType(Me.grdLen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPesquisa.ResumeLayout(False)
        Me.gbPesquisa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents txtCriterio1 As System.Windows.Forms.TextBox
    Friend WithEvents grdLen As System.Windows.Forms.DataGrid
    Friend WithEvents gbPesquisa As System.Windows.Forms.GroupBox
    Friend WithEvents btnLocalizar As System.Windows.Forms.Button
End Class
