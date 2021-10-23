<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaForPesq
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaForPesq))
        Me.grdForn = New System.Windows.Forms.DataGrid()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        CType(Me.grdForn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdForn
        '
        Me.grdForn.AlternatingBackColor = System.Drawing.Color.RoyalBlue
        Me.grdForn.BackColor = System.Drawing.Color.Maroon
        Me.grdForn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdForn.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.grdForn.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.grdForn.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.grdForn.CaptionVisible = False
        Me.grdForn.DataMember = ""
        Me.grdForn.FlatMode = True
        Me.grdForn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.grdForn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grdForn.GridLineColor = System.Drawing.Color.DarkRed
        Me.grdForn.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.grdForn.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.grdForn.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.grdForn.HeaderForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdForn.LinkColor = System.Drawing.Color.Teal
        Me.grdForn.Location = New System.Drawing.Point(12, 46)
        Me.grdForn.Name = "grdForn"
        Me.grdForn.ParentRowsBackColor = System.Drawing.Color.Maroon
        Me.grdForn.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.grdForn.ReadOnly = True
        Me.grdForn.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.grdForn.SelectionForeColor = System.Drawing.Color.Maroon
        Me.grdForn.Size = New System.Drawing.Size(393, 223)
        Me.grdForn.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(12, 12)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(298, 20)
        Me.txtNome.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "pesquisar.png")
        Me.ImageList1.Images.SetKeyName(1, "ok20.png")
        '
        'btnConsultar
        '
        Me.btnConsultar.ImageIndex = 0
        Me.btnConsultar.ImageList = Me.ImageList1
        Me.btnConsultar.Location = New System.Drawing.Point(315, 9)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(91, 28)
        Me.btnConsultar.TabIndex = 1
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.ImageIndex = 1
        Me.btnOk.ImageList = Me.ImageList1
        Me.btnOk.Location = New System.Drawing.Point(175, 280)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 28)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&Ok"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmConsultaForPesq
        '
        Me.AcceptButton = Me.btnConsultar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 314)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.grdForn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultaForPesq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta Fornecedor"
        CType(Me.grdForn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdForn As System.Windows.Forms.DataGrid
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
