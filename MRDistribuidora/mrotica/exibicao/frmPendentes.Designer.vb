<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPendentes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPendentes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOS = New System.Windows.Forms.TextBox()
        Me.txtPOD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPOE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAvancar = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnBaixar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OS"
        '
        'txtOS
        '
        Me.txtOS.Enabled = False
        Me.txtOS.Location = New System.Drawing.Point(12, 22)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(81, 20)
        Me.txtOS.TabIndex = 1
        '
        'txtPOD
        '
        Me.txtPOD.Enabled = False
        Me.txtPOD.Location = New System.Drawing.Point(99, 22)
        Me.txtPOD.Name = "txtPOD"
        Me.txtPOD.Size = New System.Drawing.Size(365, 20)
        Me.txtPOD.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Produto Olho Direito"
        '
        'txtPOE
        '
        Me.txtPOE.Enabled = False
        Me.txtPOE.Location = New System.Drawing.Point(99, 60)
        Me.txtPOE.Name = "txtPOE"
        Me.txtPOE.Size = New System.Drawing.Size(365, 20)
        Me.txtPOE.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Produto Olho Esquerdo"
        '
        'btnAvancar
        '
        Me.btnAvancar.Location = New System.Drawing.Point(289, 86)
        Me.btnAvancar.Name = "btnAvancar"
        Me.btnAvancar.Size = New System.Drawing.Size(75, 23)
        Me.btnAvancar.TabIndex = 6
        Me.btnAvancar.Text = ">>>>"
        Me.btnAvancar.UseVisualStyleBackColor = True
        '
        'btnVoltar
        '
        Me.btnVoltar.Location = New System.Drawing.Point(127, 86)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.btnVoltar.TabIndex = 7
        Me.btnVoltar.Text = "<<<<"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Blue
        Me.lblStatus.Location = New System.Drawing.Point(45, 122)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(392, 35)
        Me.lblStatus.TabIndex = 56
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBaixar
        '
        Me.btnBaixar.Location = New System.Drawing.Point(208, 86)
        Me.btnBaixar.Name = "btnBaixar"
        Me.btnBaixar.Size = New System.Drawing.Size(75, 23)
        Me.btnBaixar.TabIndex = 57
        Me.btnBaixar.Text = "Baixar OS"
        Me.btnBaixar.UseVisualStyleBackColor = True
        '
        'frmPendentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 187)
        Me.Controls.Add(Me.btnBaixar)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnAvancar)
        Me.Controls.Add(Me.txtPOE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPOD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOS)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPendentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPendentes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOS As System.Windows.Forms.TextBox
    Friend WithEvents txtPOD As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPOE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAvancar As System.Windows.Forms.Button
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnBaixar As System.Windows.Forms.Button
End Class
