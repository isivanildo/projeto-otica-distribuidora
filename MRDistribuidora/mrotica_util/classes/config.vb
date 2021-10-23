Public Class config
    Dim ds As New DataSet
#Region "Get Set#"
    Public Property usuario()
        Get
            usuario = confUser
        End Get
        Set(ByVal value)
            confUser = value
        End Set
    End Property
    Public Property senha()
        Get
            senha = confSenha
        End Get
        Set(ByVal value)
            confSenha = value
        End Set
    End Property
    Public Property servidorDB()
        Get
            servidorDB = confServidor
        End Get
        Set(ByVal value)
            confServidor = value
        End Set
    End Property

    Public Property portaDB()
        Get
            portaDB = confPorta
        End Get
        Set(ByVal value)
            confServidor = value
        End Set
    End Property
    Public Property usuarioSql()
        Get
            usuarioSql = confUsuarioDB
        End Get
        Set(ByVal value)
            confUsuarioDB = value
        End Set
    End Property
    Public Property SenhaSql()
        Get
            SenhaSql = confSenhaDB
        End Get
        Set(ByVal value)
            confSenhaDB = value
        End Set
    End Property

    Public Property Exportar()
        Get
            Return confExportar
        End Get
        Set(value)
            confExportar = value
        End Set
    End Property

    Public Property Log()
        Get
            Return confLog
        End Get
        Set(value)
            confLog = value
        End Set
    End Property

    Public Property Banco()
        Get
            Banco = confBanco
        End Get
        Set(ByVal value)
            confBanco = value
        End Set
    End Property

    Public Property Filial()
        Get
            Filial = confFilial
        End Get
        Set(ByVal value)
            confFilial = value
        End Set
    End Property
    Public Property dbBazar()
        Get
            dbBazar = confDBBazar
        End Get
        Set(ByVal value)
            confDBBazar = value
        End Set
    End Property
    Public Property dias()
        Get
            dias = confDias
        End Get
        Set(value)
            confDias = value
        End Set
    End Property
    Public Property labMont()
        Get
            labMont = confLabMont
        End Get
        Set(ByVal value)
            confLabMont = value
        End Set
    End Property
    Public Property labSurf()
        Get
            labSurf = confLabSurf
        End Get
        Set(ByVal value)
            confLabSurf = value
        End Set
    End Property
    Public Property Bloqueio()
        Get
            Bloqueio = confBloqueio
        End Get
        Set(ByVal value)
            confBloqueio = value
        End Set
    End Property
    Public Property ImagemRelatorio()
        Get
            Return imagemRel
        End Get
        Set(ByVal value)
            imagemRel = value
        End Set
    End Property
#End Region
    Public Sub New()
        load_config()
    End Sub
    Public Sub New(ByVal strPath As String)
        load_config(strPath)
    End Sub
    Public Function load_config() As String
        Dim o As New objSecurity
        Dim ds As New DataSet
        Dim tabela As New DataTable
        Try
            ds.ReadXml("config.xml")
        Catch ex As Exception
            Return ex.Message
            Exit Function
        End Try
        Try
            tabela = ds.Tables(0)
            confFilial = tabela.Rows(0)(0)
            confServidor = tabela.Rows(0)(1)
            confPorta = tabela.Rows(0)(2)
            confBanco = tabela.Rows(0)(3)
            confUsuarioDB = tabela.Rows(0)(4)
            confSenha = o.DecryptText(tabela.Rows(0)(5))
            confExportar = tabela.Rows(0)(6)
            confLog = tabela.Rows(0)(7)


            Return "OK:"
            tabela.Dispose()
            ds.Tables.Clear()
        Catch ex As Exception
            Return ex.ToString
        End Try

    End Function
    Public Function load_config(ByVal strPath As String) As String
        Dim o As New objSecurity
        Dim ds As New DataSet
        Dim tabela As New DataTable
        strPath = strPath & "\config.xml"
        Try
            ds.ReadXml(strPath)
        Catch ex As Exception
            Return ex.Message
            Exit Function
        End Try
        Try
            tabela = ds.Tables(0)
            confFilial = tabela.Rows(0)(0)
            confServidor = tabela.Rows(0)(1)
            confPorta = tabela.Rows(0)(2)
            confBanco = tabela.Rows(0)(3)
            confUsuarioDB = tabela.Rows(0)(4)
            confSenha = o.DecryptText(tabela.Rows(0)(5))
            confExportar = o.DecryptText(tabela.Rows(0)(6))
            confLog = o.DecryptText(tabela.Rows(0)(7))

            confUser = tabela.Rows(0)(0)
            confSenha = o.DecryptText(tabela.Rows(0)(1))


            Return "OK:"
            tabela.Dispose()
            ds.Tables.Clear()
        Catch ex As Exception

        End Try

    End Function
End Class
