<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaixaPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaixaPedido))
        Me.lblNpedido = New System.Windows.Forms.Label()
        Me.lblFilial = New System.Windows.Forms.Label()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grdProd = New System.Windows.Forms.DataGrid()
        Me.grpBaixa = New System.Windows.Forms.GroupBox()
        Me.txtBarra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnConcluirItem = New System.Windows.Forms.Button()
        Me.lblQAtendida = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblQReq = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grdReserva = New System.Windows.Forms.DataGrid()
        Me.txti = New System.Windows.Forms.TextBox()
        Me.chkBaixados = New System.Windows.Forms.CheckBox()
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBaixa.SuspendLayout()
        CType(Me.grdReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNpedido
        '
        Me.lblNpedido.AutoSize = True
        Me.lblNpedido.Location = New System.Drawing.Point(7, 21)
        Me.lblNpedido.Name = "lblNpedido"
        Me.lblNpedido.Size = New System.Drawing.Size(13, 13)
        Me.lblNpedido.TabIndex = 11
        Me.lblNpedido.Text = "0"
        '
        'lblFilial
        '
        Me.lblFilial.AutoSize = True
        Me.lblFilial.Location = New System.Drawing.Point(102, 21)
        Me.lblFilial.Name = "lblFilial"
        Me.lblFilial.Size = New System.Drawing.Size(13, 13)
        Me.lblFilial.TabIndex = 13
        Me.lblFilial.Text = "0"
        '
        'dtData
        '
        Me.dtData.Enabled = False
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(156, 21)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(87, 20)
        Me.dtData.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Data Venda"
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.Location = New System.Drawing.Point(249, 21)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(278, 20)
        Me.txtCliente.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(246, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Número Pedido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Filial"
        '
        'grdProd
        '
        Me.grdProd.AllowSorting = False
        Me.grdProd.CaptionText = "Produtos"
        Me.grdProd.DataMember = ""
        Me.grdProd.FlatMode = True
        Me.grdProd.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdProd.Location = New System.Drawing.Point(10, 47)
        Me.grdProd.Name = "grdProd"
        Me.grdProd.ReadOnly = True
        Me.grdProd.Size = New System.Drawing.Size(727, 183)
        Me.grdProd.TabIndex = 18
        '
        'grpBaixa
        '
        Me.grpBaixa.Controls.Add(Me.txtBarra)
        Me.grpBaixa.Controls.Add(Me.Label6)
        Me.grpBaixa.Controls.Add(Me.btnConcluirItem)
        Me.grpBaixa.Controls.Add(Me.lblQAtendida)
        Me.grpBaixa.Controls.Add(Me.Label7)
        Me.grpBaixa.Controls.Add(Me.lblQReq)
        Me.grpBaixa.Controls.Add(Me.Label2)
        Me.grpBaixa.Controls.Add(Me.grdReserva)
        Me.grpBaixa.Enabled = False
        Me.grpBaixa.Location = New System.Drawing.Point(10, 236)
        Me.grpBaixa.Name = "grpBaixa"
        Me.grpBaixa.Size = New System.Drawing.Size(727, 175)
        Me.grpBaixa.TabIndex = 19
        Me.grpBaixa.TabStop = False
        '
        'txtBarra
        '
        Me.txtBarra.Location = New System.Drawing.Point(572, 29)
        Me.txtBarra.Name = "txtBarra"
        Me.txtBarra.Size = New System.Drawing.Size(125, 20)
        Me.txtBarra.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(569, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Confirmar código de barras"
        '
        'btnConcluirItem
        '
        Me.btnConcluirItem.Location = New System.Drawing.Point(615, 148)
        Me.btnConcluirItem.Name = "btnConcluirItem"
        Me.btnConcluirItem.Size = New System.Drawing.Size(104, 23)
        Me.btnConcluirItem.TabIndex = 26
        Me.btnConcluirItem.Text = "Concluir Item"
        Me.btnConcluirItem.UseVisualStyleBackColor = True
        '
        'lblQAtendida
        '
        Me.lblQAtendida.AutoSize = True
        Me.lblQAtendida.Location = New System.Drawing.Point(706, 120)
        Me.lblQAtendida.Name = "lblQAtendida"
        Me.lblQAtendida.Size = New System.Drawing.Size(13, 13)
        Me.lblQAtendida.TabIndex = 25
        Me.lblQAtendida.Text = "0"
        Me.lblQAtendida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(612, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Quantidade Atendida"
        '
        'lblQReq
        '
        Me.lblQReq.AutoSize = True
        Me.lblQReq.Location = New System.Drawing.Point(706, 94)
        Me.lblQReq.Name = "lblQReq"
        Me.lblQReq.Size = New System.Drawing.Size(13, 13)
        Me.lblQReq.TabIndex = 23
        Me.lblQReq.Text = "0"
        Me.lblQReq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(598, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Quantidade Requisitada"
        '
        'grdReserva
        '
        Me.grdReserva.AllowSorting = False
        Me.grdReserva.CaptionText = "Reservas"
        Me.grdReserva.DataMember = ""
        Me.grdReserva.FlatMode = True
        Me.grdReserva.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdReserva.Location = New System.Drawing.Point(6, 11)
        Me.grdReserva.Name = "grdReserva"
        Me.grdReserva.ReadOnly = True
        Me.grdReserva.Size = New System.Drawing.Size(540, 158)
        Me.grdReserva.TabIndex = 19
        '
        'txti
        '
        Me.txti.Location = New System.Drawing.Point(607, 47)
        Me.txti.Name = "txti"
        Me.txti.ReadOnly = True
        Me.txti.Size = New System.Drawing.Size(100, 20)
        Me.txti.TabIndex = 29
        '
        'chkBaixados
        '
        Me.chkBaixados.AutoSize = True
        Me.chkBaixados.Location = New System.Drawing.Point(631, 20)
        Me.chkBaixados.Name = "chkBaixados"
        Me.chkBaixados.Size = New System.Drawing.Size(106, 17)
        Me.chkBaixados.TabIndex = 30
        Me.chkBaixados.Text = "Só não Baixados"
        Me.chkBaixados.UseVisualStyleBackColor = True
        '
        'frmBaixaPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 417)
        Me.Controls.Add(Me.chkBaixados)
        Me.Controls.Add(Me.txti)
        Me.Controls.Add(Me.grpBaixa)
        Me.Controls.Add(Me.grdProd)
        Me.Controls.Add(Me.lblNpedido)
        Me.Controls.Add(Me.lblFilial)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmBaixaPedido"
        Me.Text = "frmBaixaPedido"
        CType(Me.grdProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBaixa.ResumeLayout(False)
        Me.grpBaixa.PerformLayout()
        CType(Me.grdReserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNpedido As System.Windows.Forms.Label
    Friend WithEvents lblFilial As System.Windows.Forms.Label
    Friend WithEvents dtData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grdProd As System.Windows.Forms.DataGrid
    Friend WithEvents grpBaixa As System.Windows.Forms.GroupBox
    Friend WithEvents grdReserva As System.Windows.Forms.DataGrid
    Friend WithEvents lblQReq As System.Windows.Forms.Label
    Friend WithEvents lblQAtendida As System.Windows.Forms.Label
    Friend WithEvents btnConcluirItem As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txti As System.Windows.Forms.TextBox
    Friend WithEvents chkBaixados As System.Windows.Forms.CheckBox
End Class
