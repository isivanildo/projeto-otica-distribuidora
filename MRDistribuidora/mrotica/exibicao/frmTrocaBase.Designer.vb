<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrocaBase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrocaBase))
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
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBaseAtualOD
        '
        Me.txtBaseAtualOD.BackColor = System.Drawing.SystemColors.Control
        Me.txtBaseAtualOD.Enabled = False
        Me.txtBaseAtualOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseAtualOD.Location = New System.Drawing.Point(12, 22)
        Me.txtBaseAtualOD.Name = "txtBaseAtualOD"
        Me.txtBaseAtualOD.ReadOnly = True
        Me.txtBaseAtualOD.Size = New System.Drawing.Size(100, 20)
        Me.txtBaseAtualOD.TabIndex = 0
        '
        'txtNovaBaseOD
        '
        Me.txtNovaBaseOD.Location = New System.Drawing.Point(139, 22)
        Me.txtNovaBaseOD.Name = "txtNovaBaseOD"
        Me.txtNovaBaseOD.Size = New System.Drawing.Size(124, 20)
        Me.txtNovaBaseOD.TabIndex = 1
        '
        'txtBaseAtualOE
        '
        Me.txtBaseAtualOE.BackColor = System.Drawing.SystemColors.Control
        Me.txtBaseAtualOE.Enabled = False
        Me.txtBaseAtualOE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseAtualOE.Location = New System.Drawing.Point(12, 61)
        Me.txtBaseAtualOE.Name = "txtBaseAtualOE"
        Me.txtBaseAtualOE.ReadOnly = True
        Me.txtBaseAtualOE.Size = New System.Drawing.Size(100, 20)
        Me.txtBaseAtualOE.TabIndex = 2
        '
        'txtNovaBaseOE
        '
        Me.txtNovaBaseOE.Location = New System.Drawing.Point(139, 61)
        Me.txtNovaBaseOE.Name = "txtNovaBaseOE"
        Me.txtNovaBaseOE.Size = New System.Drawing.Size(124, 20)
        Me.txtNovaBaseOE.TabIndex = 3
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Base Olho Direito"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nova Base Olho Direito"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(136, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nova Base Olho Esquerdo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Base Olho Esquerdo"
        '
        'btnOk
        '
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.Location = New System.Drawing.Point(94, 98)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 32)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "Ok"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(171, 98)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 32)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmTrocaBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 136)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTrocaBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Troca de Base OS"
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
End Class
