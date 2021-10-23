<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolTrocaProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSolTrocaProd))
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.chkOD = New System.Windows.Forms.CheckBox()
        Me.chkOE = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(12, 62)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(268, 86)
        Me.txtObs.TabIndex = 2
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(109, 163)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 30)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "salvar"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'chkOD
        '
        Me.chkOD.AutoSize = True
        Me.chkOD.Location = New System.Drawing.Point(16, 16)
        Me.chkOD.Name = "chkOD"
        Me.chkOD.Size = New System.Drawing.Size(81, 17)
        Me.chkOD.TabIndex = 0
        Me.chkOD.Text = "Olho Direito"
        Me.chkOD.UseVisualStyleBackColor = True
        '
        'chkOE
        '
        Me.chkOE.AutoSize = True
        Me.chkOE.Location = New System.Drawing.Point(16, 37)
        Me.chkOE.Name = "chkOE"
        Me.chkOE.Size = New System.Drawing.Size(96, 17)
        Me.chkOE.TabIndex = 1
        Me.chkOE.Text = "Olho Esquerdo"
        Me.chkOE.UseVisualStyleBackColor = True
        '
        'frmSolTrocaProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 207)
        Me.Controls.Add(Me.chkOE)
        Me.Controls.Add(Me.chkOD)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtObs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSolTrocaProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Troca de produto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents chkOD As System.Windows.Forms.CheckBox
    Friend WithEvents chkOE As System.Windows.Forms.CheckBox
End Class
