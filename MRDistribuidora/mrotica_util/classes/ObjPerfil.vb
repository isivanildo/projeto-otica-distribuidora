'********************************************************************************/
'* Esta clase contém toda a estrutura e referência necessária para trabalharmos */
'* o controle de dados sobre o perfil do usuário, como o tipo de acesso que     */
'* mesmo terá sobre o acesso ao sistema                                         */
'*                                                                              */
'* Direitos Autorais Reservados (c) 2019 MR Informática                         

Imports System.Windows.Forms

Public Class ObjPerfil
    Private d As New dados()
    Private master As New objMaster
    Private tb As New DataTable
    Private _codTipoUsuario As Integer
    Private _tipoUsuarioDescricao As String
    Private _permissaoPadrao As Integer
    Private _novo As Boolean

    Public Property CodigoTipoUsuario()
        Get
            CodigoTipoUsuario = _codTipoUsuario
        End Get
        Set(ByVal value)
            _codTipoUsuario = value
        End Set
    End Property

    Public Property TipoUsuarioDescricao()
        Get
            TipoUsuarioDescricao = _tipoUsuarioDescricao
        End Get
        Set(ByVal value)
            _tipoUsuarioDescricao = value
        End Set
    End Property

    Public Property Permissao()
        Get
            Permissao = _permissaoPadrao
        End Get
        Set(ByVal value)
            _permissaoPadrao = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub Registro(ByVal codigoTipoUsuario)
        Dim strSQL = "select * from tipo_usuario where cod_tipo_usuario = " & codigoTipoUsuario
        d.carrega_Tabela(strSQL, tb)
        If tb.Rows.Count > 0 Then
            _codTipoUsuario = tb.Rows(0)("cod_tipo_usuario")
            _tipoUsuarioDescricao = tb.Rows(0)("tipo_usuario")
        End If
    End Sub

    Public Function Novo()
        _codTipoUsuario = Nothing
        _tipoUsuarioDescricao = Nothing
        _novo = True
        Return _novo
    End Function

    Public Function Editar()
        _novo = False
    End Function

    Public Sub SalvarPefil()
        Dim res As String = ""
        Dim strSQL = ""
        Try
            If _novo = True Then
                strSQL = "insert into tipo_usuario(cod_tipo_usuario, tipo_usuario) values(" & _codTipoUsuario & "," &
                    d.PStr(_tipoUsuarioDescricao) & ")"
                d.Comando(strSQL, True)
            End If

            If _novo = False Then
                strSQL = "update tipo_usuario set tipo_usuario = " & d.PStr(_tipoUsuarioDescricao) & " " &
                    "where cod_tipo_usuario = " & _codTipoUsuario
                d.Comando(strSQL, True)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Public Sub SalvaPerfilPadrao(ByVal codigoTipoUsuario As Integer, ByVal lista As TreeView)
        Dim strSQL As String = ""
        Dim i As Integer
        Try
            If _novo = True Then
                For i = 0 To lista.Nodes(0).Nodes.Count - 1
                    If lista.Nodes(0).Nodes(i).Checked = True Then
                        Dim codigoProcedimento As Integer = lista.Nodes(0).Nodes(i).Text.Trim.Substring(0, 3)
                        strSQL = "insert into tipo_usuario_padrao(cod_tipo_usuario, cod_procedimento) values(" & codigoTipoUsuario & "," &
                                codigoProcedimento & ")"
                        d.Comando(strSQL, True)
                    End If
                Next
            End If

            If _novo = False Then
                For i = 0 To lista.Nodes(0).Nodes.Count - 1
                    If lista.Nodes(0).Nodes(i).Checked = True Then
                        Dim codigoProcedimento As Integer = lista.Nodes(0).Nodes(i).Text.Trim.Substring(0, 3)
                        strSQL = "select 1 from tipo_usuario_padrao where cod_tipo_usuario = " & codigoTipoUsuario & " " &
                            "and cod_procedimento = " & codigoProcedimento
                        If master.VerificaExistenciaRegistro(strSQL) = False Then
                            strSQL = "insert into tipo_usuario_padrao(cod_tipo_usuario, cod_procedimento) values(" & codigoTipoUsuario & "," &
                                codigoProcedimento & ")"
                            d.Comando(strSQL, True)
                        End If
                    End If

                    If lista.Nodes(0).Nodes(i).Checked = False Then
                        Dim codigoProcedimento As Integer = lista.Nodes(0).Nodes(i).Text.Trim.Substring(0, 3)
                        strSQL = "select 1 from tipo_usuario_padrao where cod_tipo_usuario = " & codigoTipoUsuario & " " &
                            "and cod_procedimento = " & codigoProcedimento
                        If master.VerificaExistenciaRegistro(strSQL) = True Then
                            strSQL = "delete from tipo_usuario_padrao where cod_tipo_usuario = " & codigoTipoUsuario & " " &
                                "and cod_procedimento = " & codigoProcedimento
                            d.Comando(strSQL, True)
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Public Sub ExcluiPerfil(ByVal codigoTipoUsuario)
        Dim strSQL As String = String.Empty
        Try
            strSQL = "delete from tipo_usuario where cod_tipo_usuario = " & codigoTipoUsuario
            d.Comando(strSQL, True)
            strSQL = "delete from tipo_usuario_padrao where cod_tipo_usuario = " & codigoTipoUsuario
            d.Comando(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Public Sub ExibeAcessoPerfil(ByVal lista As TreeView, ByVal codigoTipoUsuario As Integer)
        lista.Nodes.Clear()
        Dim strSQL As String = "select * from procedimentos_acesso"
        Dim i, j As Integer
        Dim tbProcedimento As New DataTable
        Dim tbPermissao As New DataTable
        Try
            If tbProcedimento.Rows.Count = 0 Then
                d.carrega_Tabela(strSQL, tbProcedimento)
            End If
            lista.Nodes.Add("Permissões de Acesso")
            lista.CheckBoxes = True
            tbPermissao = ChecaTipoAcesso(codigoTipoUsuario)
            For i = 0 To tbProcedimento.Rows.Count - 1
                lista.Nodes(0).Nodes.Add(Format(tbProcedimento.Rows(i)("cod_procedimento"), "000") & " - " & tbProcedimento.Rows(i)("procedimento"))
                lista.Nodes(0).ExpandAll()
                For j = 0 To tbPermissao.Rows.Count - 1
                    If lista.Nodes(0).Nodes(i).Text.Trim.Substring(0, 3) = tbPermissao.Rows(j)("cod_procedimento") Then
                        lista.Nodes(0).Nodes(i).Checked = True
                    End If
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function ChecaTipoAcesso(ByVal tipoUsuario As Integer) As DataTable
        Dim strSQL As String = "select cod_procedimento from tipo_usuario_padrao where cod_tipo_usuario = " & tipoUsuario
        Try
            d.carrega_Tabela(strSQL, tb)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return tb
    End Function

    Public Function MontaDatGrid(ByVal grid As DataGridView) As DataGridView
        grid.Columns.Clear()
        grid.AutoGenerateColumns = False
        grid.AllowUserToAddRows = False
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grid.RowHeadersVisible = False
        grid.ReadOnly = True

        Dim codigo As New DataGridViewTextBoxColumn
        codigo.HeaderText = "Código"
        codigo.DataPropertyName = "cod_tipo_usuario"
        codigo.DefaultCellStyle.Format = "000"
        codigo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        codigo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        codigo.Width = 70
        grid.Columns.Add(codigo)

        Dim descricao As New DataGridViewTextBoxColumn
        descricao.HeaderText = "Descrição"
        descricao.DataPropertyName = "tipo_usuario"
        descricao.Width = 400
        grid.Columns.Add(descricao)

        d.carrega_Tabela("select * from tipo_usuario", tb)

        grid.DataSource = tb

        Return grid

    End Function


End Class
