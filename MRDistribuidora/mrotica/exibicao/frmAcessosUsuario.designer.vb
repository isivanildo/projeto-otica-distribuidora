<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcessosUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcessosUsuario))
        Me.cbProcedimento = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.grdItens = New System.Windows.Forms.DataGrid()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTipo = New System.Windows.Forms.Button()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbProcedimento
        '
        Me.cbProcedimento.FormattingEnabled = True
        Me.cbProcedimento.Location = New System.Drawing.Point(12, 19)
        Me.cbProcedimento.Name = "cbProcedimento"
        Me.cbProcedimento.Size = New System.Drawing.Size(215, 21)
        Me.cbProcedimento.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Acessos"
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(245, 19)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(75, 23)
        Me.btnIncluir.TabIndex = 2
        Me.btnIncluir.Text = "Incluir Acesso"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'grdItens
        '
        Me.grdItens.AllowSorting = False
        Me.grdItens.DataMember = ""
        Me.grdItens.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdItens.Location = New System.Drawing.Point(12, 106)
        Me.grdItens.Name = "grdItens"
        Me.grdItens.ReadOnly = True
        Me.grdItens.Size = New System.Drawing.Size(507, 236)
        Me.grdItens.TabIndex = 19
        '
        'cbTipo
        '
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(12, 63)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(152, 21)
        Me.cbTipo.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Tipo de Usuário"
        '
        'btnTipo
        '
        Me.btnTipo.Location = New System.Drawing.Point(170, 61)
        Me.btnTipo.Name = "btnTipo"
        Me.btnTipo.Size = New System.Drawing.Size(197, 23)
        Me.btnTipo.TabIndex = 22
        Me.btnTipo.Text = "Configurar Acessos por tipo"
        Me.btnTipo.UseVisualStyleBackColor = True
        '
        'frmAcessosUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 348)
        Me.Controls.Add(Me.btnTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.grdItens)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbProcedimento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAcessosUsuario"
        Me.Text = "frmAcessosUsuario"
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbProcedimento As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnIncluir As System.Windows.Forms.Button
    Friend WithEvents grdItens As System.Windows.Forms.DataGrid
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnTipo As System.Windows.Forms.Button
End Class
