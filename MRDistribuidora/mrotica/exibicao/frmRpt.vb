Imports DataDynamics.ActiveReports
Public Class frmRpt
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents arView As DataDynamics.ActiveReports.Viewer.Viewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRpt))
        Me.arView = New DataDynamics.ActiveReports.Viewer.Viewer()
        Me.SuspendLayout()
        '
        'arView
        '
        Me.arView.BackColor = System.Drawing.SystemColors.Control
        Me.arView.Document = New DataDynamics.ActiveReports.Document.Document("ARNet Document")
        Me.arView.Location = New System.Drawing.Point(8, 0)
        Me.arView.Name = "arView"
        Me.arView.ReportViewer.CurrentPage = 0
        Me.arView.ReportViewer.MultiplePageCols = 3
        Me.arView.ReportViewer.MultiplePageRows = 2
        Me.arView.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.arView.Size = New System.Drawing.Size(416, 360)
        Me.arView.TabIndex = 0
        Me.arView.TableOfContents.Text = "Contents"
        Me.arView.TableOfContents.Width = 200
        Me.arView.TabTitleLength = 35
        Me.arView.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmRpt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 366)
        Me.Controls.Add(Me.arView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRpt"
        Me.Text = "frmRpt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Public Sub Relat(ByVal report As Object)
        Dim r As New DataDynamics.ActiveReports.ActiveReport3
        Dim st As New frmAviso
        Application.DoEvents()
        st.Show("Carregando relatório. Aguarde...")
        Application.DoEvents()
        r = report
        r.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        'Try
        r.PageSettings.Margins.Bottom = 0.3
        r.PageSettings.Margins.Top = 0.3
        r.PageSettings.Margins.Left = 0.3
        r.PageSettings.Margins.Right = 0.3
        r.Run()
        arView.Document = r.Document
        arView.ReportViewer.Zoom = 0.9
        'Catch ex As Exception
        'MsgBox(ex.ToString)
        'st.Dispose()
        'End Try
        st.Dispose()
    End Sub
    Private Sub frmRpt_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        arView.Width = Me.Width - 10
        arView.Height = Me.Height - 10
    End Sub

End Class
