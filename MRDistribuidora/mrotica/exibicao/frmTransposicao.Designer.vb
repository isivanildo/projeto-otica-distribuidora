<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransposicao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransposicao))
        Me.gbDados = New System.Windows.Forms.GroupBox()
        Me.txtOEEixo = New System.Windows.Forms.TextBox()
        Me.txtOECil = New System.Windows.Forms.TextBox()
        Me.txtOEEsf = New System.Windows.Forms.TextBox()
        Me.txtODEixo = New System.Windows.Forms.TextBox()
        Me.txtODCil = New System.Windows.Forms.TextBox()
        Me.txtODEsf = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.gbDados.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDados
        '
        Me.gbDados.Controls.Add(Me.txtOEEixo)
        Me.gbDados.Controls.Add(Me.txtOECil)
        Me.gbDados.Controls.Add(Me.txtOEEsf)
        Me.gbDados.Controls.Add(Me.txtODEixo)
        Me.gbDados.Controls.Add(Me.txtODCil)
        Me.gbDados.Controls.Add(Me.txtODEsf)
        Me.gbDados.Controls.Add(Me.Label5)
        Me.gbDados.Controls.Add(Me.Label4)
        Me.gbDados.Controls.Add(Me.Label3)
        Me.gbDados.Controls.Add(Me.Label2)
        Me.gbDados.Controls.Add(Me.Label1)
        Me.gbDados.Location = New System.Drawing.Point(12, 12)
        Me.gbDados.Name = "gbDados"
        Me.gbDados.Size = New System.Drawing.Size(286, 111)
        Me.gbDados.TabIndex = 0
        Me.gbDados.TabStop = False
        Me.gbDados.Text = "Dados"
        '
        'txtOEEixo
        '
        Me.txtOEEixo.Location = New System.Drawing.Point(215, 77)
        Me.txtOEEixo.Name = "txtOEEixo"
        Me.txtOEEixo.Size = New System.Drawing.Size(58, 20)
        Me.txtOEEixo.TabIndex = 5
        Me.txtOEEixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOECil
        '
        Me.txtOECil.Location = New System.Drawing.Point(142, 77)
        Me.txtOECil.Name = "txtOECil"
        Me.txtOECil.Size = New System.Drawing.Size(58, 20)
        Me.txtOECil.TabIndex = 4
        Me.txtOECil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOEEsf
        '
        Me.txtOEEsf.Location = New System.Drawing.Point(70, 77)
        Me.txtOEEsf.Name = "txtOEEsf"
        Me.txtOEEsf.Size = New System.Drawing.Size(58, 20)
        Me.txtOEEsf.TabIndex = 3
        Me.txtOEEsf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtODEixo
        '
        Me.txtODEixo.Location = New System.Drawing.Point(215, 40)
        Me.txtODEixo.Name = "txtODEixo"
        Me.txtODEixo.Size = New System.Drawing.Size(58, 20)
        Me.txtODEixo.TabIndex = 2
        Me.txtODEixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtODCil
        '
        Me.txtODCil.Location = New System.Drawing.Point(142, 40)
        Me.txtODCil.Name = "txtODCil"
        Me.txtODCil.Size = New System.Drawing.Size(58, 20)
        Me.txtODCil.TabIndex = 1
        Me.txtODCil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtODEsf
        '
        Me.txtODEsf.Location = New System.Drawing.Point(70, 40)
        Me.txtODEsf.Name = "txtODEsf"
        Me.txtODEsf.Size = New System.Drawing.Size(58, 20)
        Me.txtODEsf.TabIndex = 0
        Me.txtODEsf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(215, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Eixo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cilíndrico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Esférico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "OE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OD"
        '
        'btnSair
        '
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.Location = New System.Drawing.Point(223, 136)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 31)
        Me.btnSair.TabIndex = 1
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmTransposicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 175)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.gbDados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransposicao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transposição"
        Me.gbDados.ResumeLayout(False)
        Me.gbDados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbDados As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOEEixo As System.Windows.Forms.TextBox
    Friend WithEvents txtOECil As System.Windows.Forms.TextBox
    Friend WithEvents txtOEEsf As System.Windows.Forms.TextBox
    Friend WithEvents txtODEixo As System.Windows.Forms.TextBox
    Friend WithEvents txtODCil As System.Windows.Forms.TextBox
    Friend WithEvents txtODEsf As System.Windows.Forms.TextBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
End Class
