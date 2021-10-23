<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAviso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAviso))
        Me.lblMSg = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnSim = New System.Windows.Forms.Button
        Me.btnNao = New System.Windows.Forms.Button
        Me.btnEmerg = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblMSg
        '
        Me.lblMSg.AutoSize = True
        Me.lblMSg.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSg.Location = New System.Drawing.Point(1, 2)
        Me.lblMSg.Name = "lblMSg"
        Me.lblMSg.Size = New System.Drawing.Size(54, 16)
        Me.lblMSg.TabIndex = 0
        Me.lblMSg.Text = "lblMsg"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnOk.Location = New System.Drawing.Point(110, 102)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = False
        Me.btnOk.Visible = False
        '
        'btnSim
        '
        Me.btnSim.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSim.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSim.Location = New System.Drawing.Point(57, 102)
        Me.btnSim.Name = "btnSim"
        Me.btnSim.Size = New System.Drawing.Size(75, 23)
        Me.btnSim.TabIndex = 2
        Me.btnSim.Text = "&Sim"
        Me.btnSim.UseVisualStyleBackColor = False
        Me.btnSim.Visible = False
        '
        'btnNao
        '
        Me.btnNao.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNao.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNao.Location = New System.Drawing.Point(162, 102)
        Me.btnNao.Name = "btnNao"
        Me.btnNao.Size = New System.Drawing.Size(75, 23)
        Me.btnNao.TabIndex = 3
        Me.btnNao.Text = "&Não"
        Me.btnNao.UseVisualStyleBackColor = False
        Me.btnNao.Visible = False
        '
        'btnEmerg
        '
        Me.btnEmerg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmerg.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnEmerg.Location = New System.Drawing.Point(119, 102)
        Me.btnEmerg.Name = "btnEmerg"
        Me.btnEmerg.Size = New System.Drawing.Size(20, 23)
        Me.btnEmerg.TabIndex = 0
        Me.btnEmerg.Text = "Emerg"
        Me.btnEmerg.UseVisualStyleBackColor = True
        '
        'frmAviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(290, 127)
        Me.Controls.Add(Me.btnNao)
        Me.Controls.Add(Me.btnSim)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblMSg)
        Me.Controls.Add(Me.btnEmerg)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAviso"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aviso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMSg As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnSim As System.Windows.Forms.Button
    Friend WithEvents btnNao As System.Windows.Forms.Button
    Friend WithEvents btnEmerg As System.Windows.Forms.Button

End Class
