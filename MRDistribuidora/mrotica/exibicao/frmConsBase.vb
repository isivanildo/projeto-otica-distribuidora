Imports mrotica_util
Public Class frmConsBase
    Inherits System.Windows.Forms.Form
    'CONSIDERAÇÕES CÁLCULO  
    'Se Perto só visão Simples.
    'Se Longe quando visão simples não tem adição se tiver adição,
    'mostrar grau Perto somando adição.
    'Se hipermetrope considerar apenas esférico.
    'Se miope, considerar Cilindrico.
    'Se Cilíndrico, exigir eixo. 
    'A miopia corrige-se com uma lente divergente (côncava), 
    'A hipermetropia corrige-se com uma lente convergente (convexa).
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEsfODLonge As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCilOd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnBase As System.Windows.Forms.Button
    Friend WithEvents txtDNP As System.Windows.Forms.TextBox
    Friend WithEvents txtAroH As System.Windows.Forms.TextBox
    Friend WithEvents txtPonte As System.Windows.Forms.TextBox
    Friend WithEvents txtMaiorDiametro As System.Windows.Forms.TextBox
    Friend WithEvents btnDiametro As System.Windows.Forms.Button
    Friend WithEvents lblLenteOD As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDiam As System.Windows.Forms.Label
    Friend WithEvents txtCodLente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAdicao As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsBase))
        Me.txtEsfODLonge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAdicao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCilOd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBase = New System.Windows.Forms.Button()
        Me.txtDNP = New System.Windows.Forms.TextBox()
        Me.txtAroH = New System.Windows.Forms.TextBox()
        Me.txtPonte = New System.Windows.Forms.TextBox()
        Me.txtMaiorDiametro = New System.Windows.Forms.TextBox()
        Me.btnDiametro = New System.Windows.Forms.Button()
        Me.lblLenteOD = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDiam = New System.Windows.Forms.Label()
        Me.txtCodLente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEsfODLonge
        '
        Me.txtEsfODLonge.Location = New System.Drawing.Point(8, 24)
        Me.txtEsfODLonge.Name = "txtEsfODLonge"
        Me.txtEsfODLonge.Size = New System.Drawing.Size(64, 20)
        Me.txtEsfODLonge.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Esf. OD Longe"
        '
        'txtAdicao
        '
        Me.txtAdicao.Location = New System.Drawing.Point(160, 24)
        Me.txtAdicao.Name = "txtAdicao"
        Me.txtAdicao.Size = New System.Drawing.Size(64, 20)
        Me.txtAdicao.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(160, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ADICAO"
        '
        'txtCilOd
        '
        Me.txtCilOd.Location = New System.Drawing.Point(88, 24)
        Me.txtCilOd.Name = "txtCilOd"
        Me.txtCilOd.Size = New System.Drawing.Size(64, 20)
        Me.txtCilOd.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(96, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cilindrico"
        '
        'btnBase
        '
        Me.btnBase.Location = New System.Drawing.Point(304, 24)
        Me.btnBase.Name = "btnBase"
        Me.btnBase.Size = New System.Drawing.Size(88, 23)
        Me.btnBase.TabIndex = 4
        Me.btnBase.Text = "Consulta Base"
        '
        'txtDNP
        '
        Me.txtDNP.Location = New System.Drawing.Point(8, 120)
        Me.txtDNP.Name = "txtDNP"
        Me.txtDNP.Size = New System.Drawing.Size(64, 20)
        Me.txtDNP.TabIndex = 11
        Me.txtDNP.Text = "txtDNP"
        '
        'txtAroH
        '
        Me.txtAroH.Location = New System.Drawing.Point(88, 120)
        Me.txtAroH.Name = "txtAroH"
        Me.txtAroH.Size = New System.Drawing.Size(64, 20)
        Me.txtAroH.TabIndex = 12
        Me.txtAroH.Text = "txtAroH"
        '
        'txtPonte
        '
        Me.txtPonte.Location = New System.Drawing.Point(168, 120)
        Me.txtPonte.Name = "txtPonte"
        Me.txtPonte.Size = New System.Drawing.Size(64, 20)
        Me.txtPonte.TabIndex = 13
        Me.txtPonte.Text = "Ponte"
        '
        'txtMaiorDiametro
        '
        Me.txtMaiorDiametro.Location = New System.Drawing.Point(248, 120)
        Me.txtMaiorDiametro.Name = "txtMaiorDiametro"
        Me.txtMaiorDiametro.Size = New System.Drawing.Size(64, 20)
        Me.txtMaiorDiametro.TabIndex = 14
        Me.txtMaiorDiametro.Text = "txtMaiorDiametro"
        '
        'btnDiametro
        '
        Me.btnDiametro.Location = New System.Drawing.Point(320, 120)
        Me.btnDiametro.Name = "btnDiametro"
        Me.btnDiametro.Size = New System.Drawing.Size(96, 23)
        Me.btnDiametro.TabIndex = 15
        Me.btnDiametro.Text = "Diametro Bloco"
        '
        'lblLenteOD
        '
        Me.lblLenteOD.Location = New System.Drawing.Point(472, 24)
        Me.lblLenteOD.Name = "lblLenteOD"
        Me.lblLenteOD.Size = New System.Drawing.Size(240, 40)
        Me.lblLenteOD.TabIndex = 16
        Me.lblLenteOD.Text = "Esf. OD Longe"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "DNP"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(88, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Aro Horizontal"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(168, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Ponte"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(248, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Maior Diametro"
        '
        'lblDiam
        '
        Me.lblDiam.Location = New System.Drawing.Point(416, 120)
        Me.lblDiam.Name = "lblDiam"
        Me.lblDiam.Size = New System.Drawing.Size(288, 16)
        Me.lblDiam.TabIndex = 21
        Me.lblDiam.Text = "Esf. OD Longe"
        '
        'txtCodLente
        '
        Me.txtCodLente.Location = New System.Drawing.Point(232, 24)
        Me.txtCodLente.Name = "txtCodLente"
        Me.txtCodLente.Size = New System.Drawing.Size(64, 20)
        Me.txtCodLente.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(232, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "cod_Lente"
        '
        'frmConsBase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 273)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCodLente)
        Me.Controls.Add(Me.lblDiam)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLenteOD)
        Me.Controls.Add(Me.btnDiametro)
        Me.Controls.Add(Me.txtMaiorDiametro)
        Me.Controls.Add(Me.txtPonte)
        Me.Controls.Add(Me.txtAroH)
        Me.Controls.Add(Me.txtDNP)
        Me.Controls.Add(Me.btnBase)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCilOd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAdicao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEsfODLonge)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsBase"
        Me.Text = "frmConsBase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim sql As String
    Dim esfBase As Double
    Dim diametro As Double
    Private Sub frmConsBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Function Adiciona(ByVal Esf As Double, ByVal ad As Double) As Double
    End Function
    Private Sub btnBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBase.Click
        Dim d As New dados
        Dim tb As New DataTable
        If CDbl(txtEsfODLonge.Text) < 0 Then
            esfBase = CDbl(txtEsfODLonge.Text) + CDbl(txtCilOd.Text)
        Else
            esfBase = CDbl(txtEsfODLonge.Text)
        End If
        sql = "SELECT lentes_tabela.nome_comercial, lentes_blocos.nome_lente, blocos.Base_nominal, blocos.Adicao, blocos.olho, blocos.ESF_MAIOR, " & _
              " blocos.ESF_MENOR, produtos.cod_barra, lentes_blocos.diametro, lentes_blocos.cod_tabela, lentes_blocos.cod_lente " & _
              " FROM lentes_blocos INNER JOIN " & _
              "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " & _
              "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " & _
              "blocos ON produtos.cod_produto = blocos.Cod_produto " & _
              "WHERE blocos.ESF_MAIOR >= " & d.cdin(esfBase) & " AND blocos.ESF_MENOR <=" & d.cdin(esfBase) & " AND (blocos.olho = 'D' or blocos.olho = 'A') " & _
              " AND dbo.blocos.Adicao = " & d.cdin(txtAdicao.Text) & " and lentes_tabela.cod_tabela = " & d.cdin(txtCodLente.Text) & ""
        d.carrega_Tabela(sql, tb)
        If tb.Rows.Count > 0 Then
            lblLenteOD.Text = tb.Rows(0)("nome_comercial") & vbCrLf & tb.Rows(0)("nome_lente") & " Base " & tb.Rows(0)("base_nominal") & " Barra " & tb.Rows(0)("cod_barra")
            diametro = tb.Rows(0)("diametro")
        Else
            MsgBox("Dioptria Indisponível")
        End If
    End Sub
    Private Sub btnDiametro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiametro.Click
        Dim db As Double
        db = ((CDbl(txtAroH.Text) + CDbl(txtPonte.Text)) - (2 * CDbl(txtDNP.Text))) + CDbl(txtMaiorDiametro.Text) + 2
        If db > diametro Then
            lblDiam.Text = "Diametro " & db & " maior que o do bloco."
        Else
            lblDiam.Text = "Diametro " & db & ""
        End If
    End Sub
End Class
