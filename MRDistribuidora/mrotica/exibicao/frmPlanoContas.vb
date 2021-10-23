Imports mrotica_util
Imports System.Data
Imports System.Data.SqlClient

Public Class frmPlanoContas
    Dim d As New dados
    Dim conf As New config
    Private idConta As Label

    Private Sub frmPlanoContas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carregaPlano()
        Me.Height = 381
    End Sub

    Private Sub carregaPlano()
        'instrução sql que traz os registros
        Dim strSQL As String = "Select * from Contas Order By Classificacao"
        'conecta aos banco de dados
        d.conecta()
        'objeto de leitura dos valores retornados
        Dim dr As SqlDataReader

        'Cria a coluna Conta
        Dim conta As New DataGridViewTextBoxColumn
        conta.HeaderText = "Conta"
        conta.Width = 60
        grdPlano.Columns.Add(conta)

        'Cria a coluna Nome
        Dim nome As New DataGridViewTextBoxColumn
        nome.HeaderText = "Nome da Conta"
        nome.Width = 200
        grdPlano.Columns.Add(nome)

        'cria a coluna Classificação
        Dim classificacao As New DataGridViewTextBoxColumn
        classificacao.HeaderText = "Classificação"
        classificacao.Width = 90
        grdPlano.Columns.Add(classificacao)

        'cria a coluna Tipo
        Dim tipo As New DataGridViewTextBoxColumn
        tipo.HeaderText = "Tipo"
        tipo.Width = 60
        grdPlano.Columns.Add(tipo)

        d.carrega_reader(strSQL, dr)

        While dr.Read()
            grdPlano.Rows.Add(dr.Item("Conta"), dr.Item("Nome"), dr.Item("Classificacao"), dr.Item("Tipo"))
        End While

        dr.Close()
        d.desconecta()
    End Sub

    Private Sub gravaRegistro()
        'cria o objeto de conexao com o banco de dados
        Dim conn As New SqlConnection
        'instrução sql que traz os registros
        Dim strSQL As String = "Insert Into Contas(Conta,Nome,Classificacao,Tipo,Vis) Values(@Conta,@Nome,@Class,@Tipo,@Vis)"
        'conecta aos banco de dados
        d.conecta()

        Dim cmd As New SqlCommand(strSQL, conn)
        cmd.Parameters.AddWithValue("@Conta", txtConta.Text)
        cmd.Parameters.AddWithValue("@Nome", txtNome.Text)
        cmd.Parameters.AddWithValue("@Class", txtClassificacao.Text)
        cmd.Parameters.AddWithValue("@Tipo", txtTipo.Text)

        If cbVis.SelectedIndex = 0 Then
            cmd.Parameters.AddWithValue("@Vis", "S")
        Else
            cmd.Parameters.AddWithValue("@Vis", "N")
        End If

        'abre conexao com o banco de dados
        cmd.Connection = d.con
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Conta salva com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox("Erro ao gravar registro: " & ex.Message)
        End Try

    End Sub

    Private Sub excluiRegistro(ByVal conta As String)
        'cria o objeto de conexao com o banco de dados
        Dim conn As New SqlConnection
        'instrução sql que traz os registros
        Dim strSQL As String = "Delete From Contas Where Conta = @Conta And NOt Classificacao IN ('1','2','3','4')"
        'conecta aos banco de dados
        d.conecta()

        Dim cmd As New SqlCommand(strSQL, conn)
        cmd.Parameters.AddWithValue("@Conta", idConta.Text)

        'abre conexao com o banco de dados
        cmd.Connection = d.con
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Conta excluída com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox("Erro ao excluir registro: " & ex.Message)
        End Try

    End Sub

    Private Function verificaConta(ByVal conta As String) As Boolean
        Dim resultado As Boolean
        'cria o objeto de conexao com o banco de dados
        Dim conn As New SqlConnection
        'instrução sql que traz os registros
        Dim strSQL As String = "Select 1 From Lancamentos Where Cod_Conta = @Conta"
        'conecta aos banco de dados
        d.conecta()

        Dim cmd As New SqlCommand(strSQL, conn)
        cmd.Parameters.AddWithValue("@Conta", idConta.Text)

        'abre conexao com o banco de dados
        cmd.Connection = d.con

        Try
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
        Finally
            conn.Close()
        End Try

        Return resultado

    End Function



    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        Me.Height = 499
        btnExcluir.Enabled = False
        btnNovo.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Height = 381
        btnExcluir.Enabled = True
        btnNovo.Enabled = True
    End Sub

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
        gravaRegistro()
        grdPlano.Rows.Clear()
        grdPlano.Columns.Clear()
        carregaPlano()
        Me.Height = 381
        btnExcluir.Enabled = True
        btnNovo.Enabled = True
        txtConta.Text = ""
        txtNome.Text = ""
        txtClassificacao.Text = ""
        txtTipo.Text = ""
        cbVis.SelectedIndex = -1
    End Sub

    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja realmente excluir o registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            If verificaConta(idConta.Text) = False Then
                excluiRegistro(idConta.Text)
                grdPlano.Rows.Clear()
                grdPlano.Columns.Clear()
                carregaPlano()
            Else
                MessageBox.Show("Conta não pode ser excluída, existe(m) registro(s) " & Chr(13) & Chr(13) &
                                "vinculados a ela na tabela lançamentos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub grdPlano_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPlano.CellEnter


        idConta = New Label
        idConta.Text = grdPlano.Rows(e.RowIndex).Cells(0).Value
        'Label6.Text = idConta.Text
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Dim f As New frmRpt
        Dim r As New rptPlanoContas
        'r.dia = dtRelat.Value.ToShortDateString
        r.DataSource = retorna_plano()
        f.Relat(r)
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Function retorna_plano() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select * from contas order by classificacao"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
End Class