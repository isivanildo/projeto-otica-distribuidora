<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGiro))
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtTabela = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtI = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtF = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnANA = New System.Windows.Forms.Button()
        Me.cbFilial = New System.Windows.Forms.ComboBox()
        Me.grdItens = New System.Windows.Forms.DataGrid()
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.Location = New System.Drawing.Point(298, 21)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(84, 26)
        Me.btnConsultar.TabIndex = 5
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtTabela
        '
        Me.txtTabela.Location = New System.Drawing.Point(7, 24)
        Me.txtTabela.Name = "txtTabela"
        Me.txtTabela.Size = New System.Drawing.Size(82, 20)
        Me.txtTabela.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Código Tabela"
        '
        'dtI
        '
        Me.dtI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtI.Location = New System.Drawing.Point(95, 24)
        Me.dtI.Name = "dtI"
        Me.dtI.Size = New System.Drawing.Size(90, 20)
        Me.dtI.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Data Inicial"
        '
        'dtF
        '
        Me.dtF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtF.Location = New System.Drawing.Point(202, 24)
        Me.dtF.Name = "dtF"
        Me.dtF.Size = New System.Drawing.Size(90, 20)
        Me.dtF.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Data Final"
        '
        'btnANA
        '
        Me.btnANA.Image = CType(resources.GetObject("btnANA.Image"), System.Drawing.Image)
        Me.btnANA.Location = New System.Drawing.Point(524, 21)
        Me.btnANA.Name = "btnANA"
        Me.btnANA.Size = New System.Drawing.Size(184, 26)
        Me.btnANA.TabIndex = 12
        Me.btnANA.Text = "Consultar Ana Maria"
        Me.btnANA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnANA.UseVisualStyleBackColor = True
        '
        'cbFilial
        '
        Me.cbFilial.FormattingEnabled = True
        Me.cbFilial.Location = New System.Drawing.Point(420, 24)
        Me.cbFilial.Name = "cbFilial"
        Me.cbFilial.Size = New System.Drawing.Size(90, 21)
        Me.cbFilial.TabIndex = 13
        '
        'grdItens
        '
        Me.grdItens.AllowSorting = False
        Me.grdItens.DataMember = ""
        Me.grdItens.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdItens.Location = New System.Drawing.Point(7, 54)
        Me.grdItens.Name = "grdItens"
        Me.grdItens.ReadOnly = True
        Me.grdItens.Size = New System.Drawing.Size(703, 354)
        Me.grdItens.TabIndex = 4
        '
        'frmGiro
        '
        Me.AcceptButton = Me.btnConsultar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 412)
        Me.Controls.Add(Me.cbFilial)
        Me.Controls.Add(Me.btnANA)
        Me.Controls.Add(Me.dtF)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTabela)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.grdItens)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Giro do Estoque"
        CType(Me.grdItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents txtTabela As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnANA As System.Windows.Forms.Button
    Friend WithEvents cbFilial As System.Windows.Forms.ComboBox
    Friend WithEvents grdItens As System.Windows.Forms.DataGrid
End Class
