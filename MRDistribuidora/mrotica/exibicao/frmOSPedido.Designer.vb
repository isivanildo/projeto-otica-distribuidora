<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOSPedido
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOSPedido))
        Me.txtBaseAtualOD = New System.Windows.Forms.TextBox()
        Me.txtNovaBaseOD = New System.Windows.Forms.TextBox()
        Me.txtBaseAtualOE = New System.Windows.Forms.TextBox()
        Me.txtNovaBaseOE = New System.Windows.Forms.TextBox()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.chkOd = New System.Windows.Forms.CheckBox()
        Me.chkOE = New System.Windows.Forms.CheckBox()
        Me.txtPod = New System.Windows.Forms.TextBox()
        Me.txtPOE = New System.Windows.Forms.TextBox()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBaseAtualOD
        '
        Me.txtBaseAtualOD.Location = New System.Drawing.Point(550, 22)
        Me.txtBaseAtualOD.Name = "txtBaseAtualOD"
        Me.txtBaseAtualOD.ReadOnly = True
        Me.txtBaseAtualOD.Size = New System.Drawing.Size(47, 20)
        Me.txtBaseAtualOD.TabIndex = 0
        '
        'txtNovaBaseOD
        '
        Me.txtNovaBaseOD.Location = New System.Drawing.Point(603, 22)
        Me.txtNovaBaseOD.Name = "txtNovaBaseOD"
        Me.txtNovaBaseOD.Size = New System.Drawing.Size(75, 20)
        Me.txtNovaBaseOD.TabIndex = 1
        '
        'txtBaseAtualOE
        '
        Me.txtBaseAtualOE.Location = New System.Drawing.Point(550, 64)
        Me.txtBaseAtualOE.Name = "txtBaseAtualOE"
        Me.txtBaseAtualOE.ReadOnly = True
        Me.txtBaseAtualOE.Size = New System.Drawing.Size(47, 20)
        Me.txtBaseAtualOE.TabIndex = 2
        '
        'txtNovaBaseOE
        '
        Me.txtNovaBaseOE.Location = New System.Drawing.Point(603, 64)
        Me.txtNovaBaseOE.Name = "txtNovaBaseOE"
        Me.txtNovaBaseOE.Size = New System.Drawing.Size(75, 20)
        Me.txtNovaBaseOE.TabIndex = 3
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(550, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Base OD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(600, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nova Base OD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(600, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nova Base OE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(550, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Base OE"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(40, 98)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(121, 98)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(118, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'chkOd
        '
        Me.chkOd.AutoSize = True
        Me.chkOd.Location = New System.Drawing.Point(25, 25)
        Me.chkOd.Name = "chkOd"
        Me.chkOd.Size = New System.Drawing.Size(42, 17)
        Me.chkOd.TabIndex = 10
        Me.chkOd.Text = "OD"
        Me.chkOd.UseVisualStyleBackColor = True
        '
        'chkOE
        '
        Me.chkOE.AutoSize = True
        Me.chkOE.Location = New System.Drawing.Point(25, 64)
        Me.chkOE.Name = "chkOE"
        Me.chkOE.Size = New System.Drawing.Size(41, 17)
        Me.chkOE.TabIndex = 11
        Me.chkOE.Text = "OE"
        Me.chkOE.UseVisualStyleBackColor = True
        '
        'txtPod
        '
        Me.txtPod.Location = New System.Drawing.Point(73, 22)
        Me.txtPod.Name = "txtPod"
        Me.txtPod.ReadOnly = True
        Me.txtPod.Size = New System.Drawing.Size(460, 20)
        Me.txtPod.TabIndex = 12
        '
        'txtPOE
        '
        Me.txtPOE.Location = New System.Drawing.Point(73, 62)
        Me.txtPOE.Name = "txtPOE"
        Me.txtPOE.ReadOnly = True
        Me.txtPOE.Size = New System.Drawing.Size(460, 20)
        Me.txtPOE.TabIndex = 13
        '
        'frmOSPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 136)
        Me.Controls.Add(Me.txtPOE)
        Me.Controls.Add(Me.txtPod)
        Me.Controls.Add(Me.chkOE)
        Me.Controls.Add(Me.chkOd)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNovaBaseOE)
        Me.Controls.Add(Me.txtBaseAtualOE)
        Me.Controls.Add(Me.txtNovaBaseOD)
        Me.Controls.Add(Me.txtBaseAtualOD)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOSPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTrocaBase"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBaseAtualOD As System.Windows.Forms.TextBox
    Friend WithEvents txtNovaBaseOD As System.Windows.Forms.TextBox
    Friend WithEvents txtBaseAtualOE As System.Windows.Forms.TextBox
    Friend WithEvents txtNovaBaseOE As System.Windows.Forms.TextBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents chkOE As System.Windows.Forms.CheckBox
    Friend WithEvents chkOd As System.Windows.Forms.CheckBox
    Friend WithEvents txtPOE As System.Windows.Forms.TextBox
    Friend WithEvents txtPod As System.Windows.Forms.TextBox
End Class
