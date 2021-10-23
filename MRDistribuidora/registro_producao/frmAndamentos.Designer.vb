<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAndamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAndamentos))
        Me.cbUsuario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodUsuario = New System.Windows.Forms.TextBox()
        Me.cbAndamento = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodAndamento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOS = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.TextBox()
        Me.grdAndamentos = New System.Windows.Forms.DataGrid()
        Me.btnAndamentos = New System.Windows.Forms.Button()
        CType(Me.grdAndamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbUsuario
        '
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(111, 22)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(213, 21)
        Me.cbUsuario.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuário"
        '
        'txtCodUsuario
        '
        Me.txtCodUsuario.Location = New System.Drawing.Point(5, 22)
        Me.txtCodUsuario.Name = "txtCodUsuario"
        Me.txtCodUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtCodUsuario.TabIndex = 6
        '
        'cbAndamento
        '
        Me.cbAndamento.FormattingEnabled = True
        Me.cbAndamento.Location = New System.Drawing.Point(111, 59)
        Me.cbAndamento.Name = "cbAndamento"
        Me.cbAndamento.Size = New System.Drawing.Size(213, 21)
        Me.cbAndamento.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Andamento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtCodAndamento
        '
        Me.txtCodAndamento.Location = New System.Drawing.Point(5, 59)
        Me.txtCodAndamento.Name = "txtCodAndamento"
        Me.txtCodAndamento.Size = New System.Drawing.Size(100, 20)
        Me.txtCodAndamento.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "OS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtOS
        '
        Me.txtOS.Location = New System.Drawing.Point(5, 97)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(100, 20)
        Me.txtOS.TabIndex = 12
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(330, 22)
        Me.lblStatus.Multiline = True
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.ReadOnly = True
        Me.lblStatus.Size = New System.Drawing.Size(388, 95)
        Me.lblStatus.TabIndex = 14
        '
        'grdAndamentos
        '
        Me.grdAndamentos.CaptionVisible = False
        Me.grdAndamentos.DataMember = ""
        Me.grdAndamentos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdAndamentos.Location = New System.Drawing.Point(5, 125)
        Me.grdAndamentos.Name = "grdAndamentos"
        Me.grdAndamentos.ReadOnly = True
        Me.grdAndamentos.Size = New System.Drawing.Size(713, 379)
        Me.grdAndamentos.TabIndex = 15
        '
        'btnAndamentos
        '
        Me.btnAndamentos.Location = New System.Drawing.Point(111, 94)
        Me.btnAndamentos.Name = "btnAndamentos"
        Me.btnAndamentos.Size = New System.Drawing.Size(213, 23)
        Me.btnAndamentos.TabIndex = 16
        Me.btnAndamentos.Text = "Andamentos"
        Me.btnAndamentos.UseVisualStyleBackColor = True
        '
        'frmAndamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 516)
        Me.Controls.Add(Me.btnAndamentos)
        Me.Controls.Add(Me.grdAndamentos)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOS)
        Me.Controls.Add(Me.cbAndamento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodAndamento)
        Me.Controls.Add(Me.cbUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAndamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Andamentos"
        CType(Me.grdAndamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodUsuario As System.Windows.Forms.TextBox
    Friend WithEvents cbAndamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodAndamento As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOS As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.TextBox
    Friend WithEvents grdAndamentos As System.Windows.Forms.DataGrid
    Friend WithEvents btnAndamentos As System.Windows.Forms.Button

End Class
