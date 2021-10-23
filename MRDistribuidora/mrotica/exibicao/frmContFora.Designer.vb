<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContfora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContfora))
        Me.dtEnvio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDoc3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnConcluir = New System.Windows.Forms.Button()
        Me.chkOD = New System.Windows.Forms.CheckBox()
        Me.chkOE = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'dtEnvio
        '
        Me.dtEnvio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEnvio.Location = New System.Drawing.Point(12, 22)
        Me.dtEnvio.Name = "dtEnvio"
        Me.dtEnvio.Size = New System.Drawing.Size(89, 20)
        Me.dtEnvio.TabIndex = 0
        Me.dtEnvio.Value = New Date(2008, 5, 19, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Envio"
        '
        'txtDoc3
        '
        Me.txtDoc3.Location = New System.Drawing.Point(117, 23)
        Me.txtDoc3.Name = "txtDoc3"
        Me.txtDoc3.Size = New System.Drawing.Size(172, 20)
        Me.txtDoc3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Documeto do prestador de serviço"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(12, 95)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(277, 107)
        Me.txtDescricao.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descrição e anotações"
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(11, 208)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(106, 23)
        Me.btnSalvar.TabIndex = 6
        Me.btnSalvar.Text = "Salvar alterações"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnConcluir
        '
        Me.btnConcluir.Location = New System.Drawing.Point(142, 209)
        Me.btnConcluir.Name = "btnConcluir"
        Me.btnConcluir.Size = New System.Drawing.Size(142, 23)
        Me.btnConcluir.TabIndex = 7
        Me.btnConcluir.Text = "Chegou "
        Me.btnConcluir.UseVisualStyleBackColor = True
        '
        'chkOD
        '
        Me.chkOD.AutoSize = True
        Me.chkOD.Location = New System.Drawing.Point(15, 49)
        Me.chkOD.Name = "chkOD"
        Me.chkOD.Size = New System.Drawing.Size(79, 17)
        Me.chkOD.TabIndex = 3
        Me.chkOD.Text = "Olho direito"
        Me.chkOD.UseVisualStyleBackColor = True
        '
        'chkOE
        '
        Me.chkOE.AutoSize = True
        Me.chkOE.Location = New System.Drawing.Point(117, 49)
        Me.chkOE.Name = "chkOE"
        Me.chkOE.Size = New System.Drawing.Size(95, 17)
        Me.chkOE.TabIndex = 4
        Me.chkOE.Text = "Olho esquerdo"
        Me.chkOE.UseVisualStyleBackColor = True
        '
        'frmContfora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 244)
        Me.Controls.Add(Me.chkOE)
        Me.Controls.Add(Me.chkOD)
        Me.Controls.Add(Me.btnConcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDoc3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtEnvio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmContfora"
        Me.Text = "Controle de Serviço Feito Fora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtEnvio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDoc3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnConcluir As System.Windows.Forms.Button
    Friend WithEvents chkOD As System.Windows.Forms.CheckBox
    Friend WithEvents chkOE As System.Windows.Forms.CheckBox
End Class
