<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelacaoCodFornecedorSistema
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelacaoCodFornecedorSistema))
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.grdProd = New System.Windows.Forms.DataGridView()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImportar
        '
        Me.btnImportar.ImageIndex = 4
        Me.btnImportar.Location = New System.Drawing.Point(12, 7)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(102, 26)
        Me.btnImportar.TabIndex = 14
        Me.btnImportar.Text = "Nota Importada"
        Me.btnImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'grdProd
        '
        Me.grdProd.AllowUserToAddRows = False
        Me.grdProd.AllowUserToDeleteRows = False
        Me.grdProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProd.Location = New System.Drawing.Point(12, 39)
        Me.grdProd.Name = "grdProd"
        Me.grdProd.ReadOnly = True
        Me.grdProd.Size = New System.Drawing.Size(1006, 378)
        Me.grdProd.TabIndex = 15
        '
        'frmRelacaoCodFornecedorSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 450)
        Me.Controls.Add(Me.grdProd)
        Me.Controls.Add(Me.btnImportar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelacaoCodFornecedorSistema"
        Me.Text = "frmRelacaoCodFornecedorSistema"
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnImportar As Button
    Friend WithEvents grdProd As DataGridView
End Class
