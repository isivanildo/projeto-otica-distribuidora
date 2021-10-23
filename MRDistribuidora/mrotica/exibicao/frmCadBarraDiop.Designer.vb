<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadBarraDiop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadBarraDiop))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBarra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomeLente = New System.Windows.Forms.TextBox()
        Me.btnBarra = New System.Windows.Forms.Button()
        Me.txtCodTabela = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Informar Lente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBarra
        '
        Me.txtBarra.Location = New System.Drawing.Point(12, 124)
        Me.txtBarra.Name = "txtBarra"
        Me.txtBarra.Size = New System.Drawing.Size(117, 20)
        Me.txtBarra.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Codigo Barra"
        '
        'txtNomeLente
        '
        Me.txtNomeLente.Location = New System.Drawing.Point(12, 81)
        Me.txtNomeLente.Name = "txtNomeLente"
        Me.txtNomeLente.Size = New System.Drawing.Size(542, 20)
        Me.txtNomeLente.TabIndex = 4
        '
        'btnBarra
        '
        Me.btnBarra.Location = New System.Drawing.Point(135, 124)
        Me.btnBarra.Name = "btnBarra"
        Me.btnBarra.Size = New System.Drawing.Size(157, 23)
        Me.btnBarra.TabIndex = 6
        Me.btnBarra.Text = "Cadastrar Código de Barras"
        Me.btnBarra.UseVisualStyleBackColor = True
        '
        'txtCodTabela
        '
        Me.txtCodTabela.Location = New System.Drawing.Point(15, 23)
        Me.txtCodTabela.Name = "txtCodTabela"
        Me.txtCodTabela.Size = New System.Drawing.Size(100, 20)
        Me.txtCodTabela.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Codigo Tabela"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(121, 23)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(17, 20)
        Me.txtTipo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "tipo"
        '
        'frmCadBarraDiop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 298)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodTabela)
        Me.Controls.Add(Me.btnBarra)
        Me.Controls.Add(Me.txtNomeLente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBarra)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadBarraDiop"
        Me.Text = "frmCadBarraDiop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomeLente As System.Windows.Forms.TextBox
    Friend WithEvents btnBarra As System.Windows.Forms.Button
    Friend WithEvents txtCodTabela As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
