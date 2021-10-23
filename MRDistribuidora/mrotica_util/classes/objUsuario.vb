
Public Class objUsuario
#Region "Atributos"
    Dim d As New dados()
    Private _cod_usuario As Integer
    Private _nome As String
    Private _senha As String
    Private _nomeCompleto As String
    Private _cod_tipo_usuario As Integer
    Public Shadows posicao As Integer = 0
    Public Shadows max As Integer
    Public tb As New DataTable
    Public p As Integer
    Public _novo As Boolean
    Private lastPos As Integer = 0
    Dim sql As String
    Dim objSeguranca As New objSecurity
#End Region
#Region "Get Set"
    Public Property cod_usuario()
        Get
            cod_usuario = _cod_usuario
        End Get
        Set(ByVal value)
            _cod_usuario = value
        End Set
    End Property
    Public Property nome()
        Get
            nome = _nome
        End Get
        Set(ByVal value)
            _nome = value
        End Set
    End Property
    Public Property senha()
        Get
            senha = _senha
        End Get
        Set(ByVal value)
            _senha = value
        End Set
    End Property
    Public Property cod_tipo_usuario()
        Get
            cod_tipo_usuario = _cod_tipo_usuario
        End Get
        Set(ByVal value)
            _cod_tipo_usuario = value
        End Set
    End Property
#End Region
#Region "Procedimentos"
    Public Sub New()
        sql = "Select * from usuarios"
        Source(sql)
    End Sub
    Public Sub New(ByVal x_cod_us As Integer)
        sql = "Select * from usuarios where cod_usuario = " & x_cod_us & ""
        Source(sql)
    End Sub
    Public Sub Source(ByVal iSql As String)
        sql = iSql
        Me.refreshData()
    End Sub
    Public Sub refreshData()
        d.carrega_Tabela(sql, tb)
        max = tb.Rows.Count
        primeiro()
    End Sub
    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _cod_usuario = tb.Rows(p)("cod_usuario")
            _nome = tb.Rows(p)("nome")
            _cod_tipo_usuario = rdNum(tb.Rows(p)("perfil"))
            _senha = rdTexto(tb.Rows(p)("Senha"))
        End If
    End Sub
    Public Sub proximo()
        If Me.posicao = Me.max - 1 Then Exit Sub
        Me.Registro(Me.posicao + 1)
    End Sub
    Public Sub anterior()
        Me.Registro(Me.posicao - 1)
    End Sub
    Public Sub ultimo()
        Me.Registro(Me.max - 1)
    End Sub
    Public Sub primeiro()
        Me.Registro(0)
    End Sub
    Public Sub ultima_posicao()
        Me.Registro(lastPos)
    End Sub
    Public Sub editar_servico()
        _novo = False
        editar()
    End Sub
#End Region
#Region "Funções"
    Public Function novo()
        lastPos = posicao 'guarda a posição do último Registro
        'Zera Variáveis
        _cod_usuario = Nothing
        _nome = Nothing
        _senha = Nothing
        _nomeCompleto = Nothing
        _cod_tipo_usuario = Nothing
        _novo = True  'Define o tipo de ação ao salvar
    End Function
    Public Function editar()
        _novo = False  'Define o tipo de ação ao salvar
    End Function
    Public Function Salvar() As String
        Dim strSQL As String
        Dim res As String = ""
        If novo() = True Then
            Try
                strSQL = "Insert into usuarios(cod_usuario,nome, senha, nome_completo cod_tipo_usuario)" &
                "Values(" &
                _cod_usuario & "," & _nome & "," & d.PStr(_senha) & "," & d.PStr(_nome) & "," & _cod_tipo_usuario & ")"
                res = d.Comando(strSQL, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("cod_usuario") = _cod_usuario
            r("nome") = rdTexto(_nome)
            r("senha") = rdTexto(_senha)
            r("nome_completo") = rdTexto(_nomeCompleto)
            r("cod_tipo_usuario") = _cod_tipo_usuario
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            _novo = False
            Return res & " registro(s) adicionado(s) com sucesso!"
        End If
        If _novo = False Then
            Try
                sql = "Update usuarios set " &
                "nome = " & d.PStr(_nome) &
                ",senha = " & d.PStr(_senha) &
                ",nome_completo = " & d.PStr(_nomeCompleto) &
                ",cod_tipo_usuario = " & _cod_tipo_usuario &
                " where cod_usuario = " & Me._cod_usuario & ""
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("cod_tipo_usuario") = _cod_tipo_usuario
            r("nome") = rdTexto(_nome)
            r("senha") = rdTexto(_senha)
            _novo = False
        End If
        Return res & " registro(s) atualizado(s) com sucesso!"
    End Function
    Public Function deletar(ByVal x_cod_usuario As Integer)
        Dim res As String = ""

        sql = "Delete from usuarios where cod_usuario = " & x_cod_usuario & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception
        End Try
        Me.refreshData()
        Me.primeiro()
        Return res
    End Function
    Public Function acesso(ByVal x_cod_usuario As Integer, ByVal x_cod_proc As Integer) As Boolean
        Dim sql As String
        Dim tb_ac As New DataTable
        sql = "Select * from acessos_usuario where cod_usuario = " &
        x_cod_usuario & " and  cod_procedimento = " & x_cod_proc & ""
        d.carrega_Tabela(sql, tb_ac)
        If tb_ac.Rows.Count = 1 Then Return True Else Return False
    End Function
    Public Function acesso(ByVal x_cod_proc As Integer) As Boolean
        Dim sql As String
        Dim tb_ac As New DataTable
        sql = "Select * from acessos_usuario where cod_usuario = " &
        _cod_usuario & " and  cod_procedimento = " & x_cod_proc & ""
        d.carrega_Tabela(sql, tb_ac)
        If tb_ac.Rows.Count = 1 Then Return True Else Return False
    End Function
    Public Function login(ByRef f As Windows.Forms.Form) As String
        Dim x_cod As Integer
        Dim x_senha As String
        Dim sql As String
        Dim tt As New DataTable
        Dim fs As New frmSenha
        fs.ShowDialog(f)
        Try
            x_cod = fs.txtUsuario.Text
            x_senha = objSeguranca.EncryptText(fs.txtSenha.Text)
            fs.Dispose()
            sql = "select senha,nome from usuarios where " &
            "cod_usuario = " & x_cod & ""
            d.carrega_Tabela(sql, tt)
            If tt.Rows.Count = 0 Then
                Return "ER:Usuário não existe!"
            Else
                If tt.Rows(0)("senha").ToString.ToUpper.Trim = x_senha.ToUpper.Trim Then
                    Source("Select * from usuarios where cod_usuario = " & x_cod & "")
                    Return "OK:Login efetuado com sucesso!"
                Else
                    Return "ER:Senha não confere!"
                End If
            End If
        Catch ex As Exception
            Return "ER:" & ex.ToString
        End Try
    End Function

    Public Function nome_usuario(ByVal x_cod As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "select nome from usuarios where " &
        "cod_usuario = " & x_cod & ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 0 Then
            Return "Usuário não existe!"
        Else
            Return tt.Rows(0)("nome")
        End If
    End Function
    Public Function lista_acessos_usuario() As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT procedimentos_acesso.procedimento, Usuarios.cod_usuario, " &
        "procedimentos_acesso.cod_procedimento, acessos_usuario.id_acessos " &
        "FROM acessos_usuario INNER JOIN " &
        "procedimentos_acesso ON acessos_usuario.cod_procedimento = " &
        "procedimentos_acesso.cod_procedimento INNER JOIN " &
        "Usuarios ON acessos_usuario.cod_usuario = Usuarios.cod_usuario " &
        " WHERE (Usuarios.cod_usuario = " & Me._cod_usuario & ")"
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function inclui_acesso(ByVal x_cod_acesso As Integer) As String
        Dim tsql As String
        Dim res As String
        If acesso(x_cod_acesso) = True Then
            res = "Este acesso já existe!"
            Return res
            Exit Function
        End If
        tsql = "INSERT INTO acessos_usuario(cod_usuario ,cod_procedimento,id_acessos) " &
        " VALUES(" & Me._cod_usuario & "," & x_cod_acesso &
        "," & retorna_Chave("id_acessos", "acessos_usuario", "") & ")"
        res = d.Comando(tsql, True)
        Return res
    End Function
    Public Function exclui_acesso(ByVal x_id_acesso As Integer) As String
        Dim tsql As String
        Dim res As String
        tsql = "Delete from acessos_usuario " &
        " where id_acessos = " & x_id_acesso & ""
        res = d.Comando(tsql, True)
        Return res
    End Function
    Public Function limpar_acessos_usuario(ByVal x_Cod_usuario) As String
        Dim tsql As String
        Dim res As String
        tsql = "Delete from acessos_usuario " &
        " where cod_usuario = " & x_Cod_usuario & ""
        res = d.Comando(tsql, True)
        Return res
    End Function
    Public Function lista_acessos_tipo(ByVal x_cod_tipo As Integer) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT * from tipo_usuario_acessos where cod_tipo_usuario = " &
        x_cod_tipo & ""
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function
    Public Function inclui_acessos_tipo(ByVal x_cod_tipo As Integer) As String
        Dim tList As New DataTable
        Dim i, m As Integer
        Dim res As String = ""
        tList = lista_acessos_tipo(x_cod_tipo)
        i = 0
        m = tList.Rows.Count
        While i < m
            res = res & vbCrLf & inclui_acesso(tList.Rows(i)("cod_procedimento"))
            i = i + 1
        End While
        Return res
    End Function
#End Region
End Class
