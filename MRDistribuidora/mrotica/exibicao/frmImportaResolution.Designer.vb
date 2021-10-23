<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportaResolution
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportaResolution))
        Me.btnCarregaResponse = New System.Windows.Forms.Button()
        Me.txtResponse = New System.Windows.Forms.RichTextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodTabela = New System.Windows.Forms.TextBox()
        Me.txtDiametro = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'btnCarregaResponse
        '
        Me.btnCarregaResponse.Location = New System.Drawing.Point(522, 23)
        Me.btnCarregaResponse.Name = "btnCarregaResponse"
        Me.btnCarregaResponse.Size = New System.Drawing.Size(96, 23)
        Me.btnCarregaResponse.TabIndex = 4
        Me.btnCarregaResponse.Text = "Carrega Arquivo"
        '
        'txtResponse
        '
        Me.txtResponse.Location = New System.Drawing.Point(12, 78)
        Me.txtResponse.Name = "txtResponse"
        Me.txtResponse.Size = New System.Drawing.Size(643, 163)
        Me.txtResponse.TabIndex = 5
        Me.txtResponse.Text = ""
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(12, 23)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(279, 20)
        Me.txtNome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nome da Lente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Código da Tabela"
        '
        'txtCodTabela
        '
        Me.txtCodTabela.Location = New System.Drawing.Point(297, 23)
        Me.txtCodTabela.Name = "txtCodTabela"
        Me.txtCodTabela.Size = New System.Drawing.Size(91, 20)
        Me.txtCodTabela.TabIndex = 1
        '
        'txtDiametro
        '
        Me.txtDiametro.Location = New System.Drawing.Point(394, 23)
        Me.txtDiametro.Name = "txtDiametro"
        Me.txtDiametro.Size = New System.Drawing.Size(91, 20)
        Me.txtDiametro.TabIndex = 2
        '
        'txtTipo
        '
        Me.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipo.Location = New System.Drawing.Point(491, 23)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(25, 20)
        Me.txtTipo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Diametro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(488, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Tipo"
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(12, 247)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(641, 23)
        Me.pb.TabIndex = 28
        '
        'frmImportaResolution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 487)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtDiametro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodTabela)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.btnCarregaResponse)
        Me.Controls.Add(Me.txtResponse)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImportaResolution"
        Me.Text = "frmImportaResolution"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCarregaResponse As System.Windows.Forms.Button
    Friend WithEvents txtResponse As System.Windows.Forms.RichTextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodTabela As System.Windows.Forms.TextBox
    Friend WithEvents txtDiametro As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
End Class
