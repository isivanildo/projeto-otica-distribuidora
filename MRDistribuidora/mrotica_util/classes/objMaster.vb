Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class objMaster
#Region "Atributos"
    Private _cod_movimento As Integer
    Private _id_filial As Integer
    Private _status_movimento As String = Nothing
    Private strSQL As String = Nothing
    Dim d As New dados
    Private _cod_fornecedor As Integer
    Private _fornecedor As String
    Private _endereco As String
    Private _bairro As String
    Private _cidade As String
    Private _uf As String
    Private _cep As String
    Private _telefone As String
    Private _cnpj As String
    Private _ie As String
    Private _email As String
    Private _vendedor As String
    Private _tel_vendedor As String
    Private _representante As String
    Private _tel_representante As String
    Private _tipofor As String
    Private _cod_usuario As Integer
    Private _preco_compra As Double
    Private _desconto_compra As Double
#End Region

#Region "Propriedades"
    Public Property cod_movimento As Integer
        Get
            cod_movimento = _cod_movimento
        End Get
        Set(value As Integer)
            _cod_movimento = value
        End Set
    End Property

    Public Property pid_filial() As Integer
        Get
            Return _id_filial
        End Get
        Set(ByVal value As Integer)
            _id_filial = value
        End Set
    End Property

    Public Property status_movimento
        Get
            status_movimento = _status_movimento
        End Get
        Set(value)
            _status_movimento = value
        End Set
    End Property

    Public Property pcod_fornecedor
        Get
            pcod_fornecedor = _cod_fornecedor
        End Get
        Set(value)
            _cod_fornecedor = value
        End Set
    End Property

    Public Property pfornecedor
        Get
            pfornecedor = _fornecedor
        End Get
        Set(value)
            _fornecedor = value
        End Set
    End Property

    Public Property pendereco
        Get
            pendereco = _endereco
        End Get
        Set(value)
            _endereco = value
        End Set
    End Property

    Public Property pbairro
        Get
            pbairro = _bairro
        End Get
        Set(value)
            _bairro = value
        End Set
    End Property

    Public Property pcidade
        Get
            pcidade = _cidade
        End Get
        Set(value)
            _cidade = value
        End Set
    End Property

    Public Property puf
        Get
            puf = _uf
        End Get
        Set(value)
            _uf = value
        End Set
    End Property

    Public Property pcep
        Get
            pcep = _cep
        End Get
        Set(value)
            _cep = value
        End Set
    End Property

    Public Property ptelefone
        Get
            ptelefone = _telefone
        End Get
        Set(value)
            _telefone = value
        End Set
    End Property

    Public Property pcnpj
        Get
            pcnpj = _cnpj
        End Get
        Set(value)
            _cnpj = value
        End Set
    End Property

    Public Property pie
        Get
            pie = _ie
        End Get
        Set(value)
            _ie = value
        End Set
    End Property

    Public Property pemail
        Get
            pemail = _email
        End Get
        Set(value)
            _email = value
        End Set
    End Property

    Public Property pvendedor
        Get
            pvendedor = _vendedor
        End Get
        Set(value)
            _vendedor = value
        End Set
    End Property

    Public Property ptel_vendedor
        Get
            ptel_vendedor = _tel_vendedor
        End Get
        Set(value)
            _tel_vendedor = value
        End Set
    End Property

    Public Property prepresentante
        Get
            prepresentante = _representante
        End Get
        Set(value)
            _representante = value
        End Set
    End Property

    Public Property ptel_representante
        Get
            ptel_representante = _tel_representante
        End Get
        Set(value)
            _tel_representante = value
        End Set
    End Property

    Public Property ptipo_for
        Get
            ptipo_for = _tipofor
        End Get
        Set(value)
            _tipofor = value
        End Set
    End Property

    Public Property pusuario
        Get
            pusuario = _cod_usuario
        End Get
        Set(value)
            _cod_usuario = value
        End Set
    End Property

    Public Property ppreco_compra
        Get
            ppreco_compra = _preco_compra
        End Get
        Set(value)
            _preco_compra = value
        End Set
    End Property

    Public Property pdesconto_compra
        Get
            pdesconto_compra = _desconto_compra
        End Get
        Set(value)
            _desconto_compra = value
        End Set
    End Property
#End Region

#Region "Procedimentos"
    'Função responsável por trazer o status do do movimento se esta concluido ou não
    Public Function busca_status_Movimento_Master(ByVal idconf As Integer, ByVal idfilial As Integer) As String
        strSQL = "select movimentomaster.concluido from conferencia_nota_master inner join movimentomaster on " &
            "conferencia_nota_master.cod_movimento = movimentomaster.cod_movimento where conferencia_nota_master.id_conferencia = " & idconf &
            " And movimentomaster.id_filial = " & idfilial
        'strSQL = "select concluido from movimentomaster where cod_movimento = " & cod_movimento & " and id_filial = " & idfilial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim dr As SqlDataReader
        Dim resultado As String = ""
        d.conecta()
        dr = cmd.ExecuteReader
        Try
            dr.Read()
            resultado = dr.GetString(0).ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
        Return resultado
    End Function

    'Função responsável por trazer o codigo do movimento
    Public Function busca_Codigo_Movimento(ByVal idconf As Integer, ByVal idfilial As Integer) As Integer
        strSQL = "select cod_movimento from conferencia_nota_master where id_conferencia = " & idconf & " and id_filial_nota = " & idfilial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim dr As SqlDataReader
        Dim resultado As Integer
        d.conecta()
        dr = cmd.ExecuteReader()
        Try
            dr.Read()
            resultado = dr.GetInt32(0).ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try

        Return resultado
    End Function

    'Função que só retorna números
    Public Function so_numeros(ByVal texto As String) As Int64
        Dim valor As New System.Text.StringBuilder
        Try
            For Each c As Char In texto.ToCharArray
                If IsNumeric(c) Then
                    valor.Append(c)
                End If
            Next
            Return valor.ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    'Função que só retorna números
    Public Function so_numerosNFe(ByVal texto As String) As String
        Dim valor As New System.Text.StringBuilder
        Try
            For Each c As Char In texto.ToCharArray
                If IsNumeric(c) Then
                    valor.Append(c)
                End If
            Next
            Return valor.ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    'Função que só retorna números
    Public Function so_texto(ByVal texto As String) As String
        Dim valor As New System.Text.StringBuilder

        For Each c As Char In texto.ToCharArray
            If Not IsNumeric(c) Then
                valor.Append(c)
            End If
        Next
        Return valor.ToString
    End Function

    'Rotina responsável por atualizar o status do pedido na tabela pedido_fornecedor
    Public Sub atualiza_status_pedido(ByVal status As Integer, ByVal codpedido As Integer, ByVal idfilial As Integer)
        strSQL = "update pedido_fornecedor set cod_status_pedido = " & status & " where cod_pedido = " & codpedido & " and id_filial = " & idfilial
        Dim cmd As New SqlCommand(strSQL, d.con)
        d.conecta()

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Função responsável por trazer o status do pedido do fornecedor
    Public Function retorna_status_pedido(ByVal texto As String) As Integer
        strSQL = "select cod_status_pedido from status_pedido_fornecedor where status_pedido_fornecedor = '" & LTrim(texto.Replace("-", "")) & "'"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim dr As SqlDataReader
        Dim resultado As Integer
        d.conecta()
        dr = cmd.ExecuteReader()
        Try
            dr.Read()
            resultado = dr.GetInt32(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try

        Return resultado
    End Function

    'Rotina responsável por inserir infromações na tabela nota_pedido
    Public Sub inseri_nota_pedido(ByVal codmov As Integer, ByVal notafiscal As Int64, ByVal codped As Integer, ByVal codfor As Integer,
                                      ByVal idfilial As Integer)
        strSQL = "INSERT INTO nota_pedido(cod_movimento, nota_fiscal,cod_pedido, cod_fornecedor, id_filial) " &
            "VALUES(@codmovimento, @notafiscal, @codpedido, @codfornecedor, @idfilial)"
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@codmovimento", codmov)
        cmd.Parameters.AddWithValue("@notafiscal", notafiscal)
        cmd.Parameters.AddWithValue("@codpedido", codped)
        cmd.Parameters.AddWithValue("@codfornecedor", codfor)
        cmd.Parameters.AddWithValue("@idfilial", idfilial)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Rotina responsável por inserir infromações na tabela promotor_cliente
    Public Sub grava_promotor(ByVal codpromotor As Integer, ByVal codfilialcli As Integer, ByVal codcliente As Integer)
        strSQL = "INSERT INTO promotor_cliente(cod_promotor, cod_filial_cliente, cod_cliente) " &
            "VALUES(" & codpromotor & "," & codfilialcli & "," & codcliente & ")"
        Dim cmd As New SqlCommand(strSQL, d.con)

        d.conecta()
        Try
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Rotina responsável por inserir infromações na tabela promotor_cliente
    Public Sub excluir_promotor(ByVal codpromotor As Integer, ByVal codfilial As Integer, ByVal codcliente As Integer)
        strSQL = "DELETE FROM promotor_cliente WHERE cod_promotor = @codpromotor AND cod_filial_cliente = @codfilial AND cod_cliente = @codcliente"
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@codpromotor", codpromotor)
        cmd.Parameters.AddWithValue("@codcliente", codcliente)
        cmd.Parameters.AddWithValue("@codfilial", codfilial)
        d.conecta()
        Try
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Função responsável por trazer o status do do movimento se esta concluido ou não
    Public Function exibi_promotor_cb(ByVal codfilialcli As Integer, ByVal codcliente As Integer, ByVal lista As ListBox) As String
        Dim strSQL As String
        strSQL = "select promotor.promotor as promotor from promotor inner join promotor_cliente on " &
    "promotor.cod_promotor = promotor_cliente.cod_promotor where promotor_cliente.cod_filial_cliente = " & codfilialcli &
    " And promotor_cliente.cod_cliente = " & codcliente & ""
        Dim tt As New DataTable
        d.carrega_Tabela(strSQL, tt)
        lista.DataSource = tt
        lista.DisplayMember = "promotor"
        lista.ValueMember = "promotor"
    End Function

    'Função responsável por trazer o status do do movimento se esta concluido ou não
    Public Function exibi_codigo_promotor(ByVal promotor As String) As Integer
        Dim strSQL As String
        strSQL = "select cod_promotor from promotor where promotor = '" & promotor & "'"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Function

    Public Sub retorna_dados_fornecedor(ByVal codigo As Integer)
        Dim strSQL As String = "select * from fornecedor where cod_fornecedor = @Codigo"
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@Codigo", codigo)
        Dim dr As SqlDataReader
        Try
            d.conecta()
            dr = cmd.ExecuteReader
            While dr.Read
                pfornecedor = dr("Fornecedor").ToString
                pcnpj = dr("Cgc").ToString
                pie = dr("I_Estadual").ToString
                pendereco = dr("Endereco").ToString
                pbairro = dr("Bairro").ToString
                pcidade = dr("Cidade").ToString
                puf = dr("Estado").ToString
                pcep = dr("Cep").ToString
                ptelefone = dr("Telefone").ToString
                pvendedor = dr("Vendedor").ToString
                ptel_vendedor = dr("TelefoneVendedor").ToString
                prepresentante = dr("Representante").ToString
                ptel_representante = dr("TelefoneRepresentante").ToString
                pemail = dr("E_mail").ToString
                ptipo_for = dr("tipo_for").ToString
            End While
        Catch ex As Exception
            MessageBox.Show("Erro de conexão de dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dr.Close()
            d.desconecta()
        End Try
    End Sub

    Public Sub salva_fornecedor(ByVal codigo As Integer, ByVal fornecedor As String, ByVal endereco As String, ByVal bairro As String,
                                ByVal cidade As String, ByVal uf As String, ByVal cep As String, ByVal telefone As String, ByVal cnpj As String,
                                ByVal ie As String, ByVal email As String, ByVal vendedor As String, ByVal telvend As String,
                                ByRef rep As String, ByVal telrep As String, ByVal tipofor As String)
        Dim strSQL As String = "INSERT INTO Fornecedor(Cod_Fornecedor,Fornecedor,Endereco,Bairro,Cidade, Estado,Cep,Telefone,Cgc, I_Estadual," &
            "E_mail, Vendedor, TelefoneVendedor,Representante, TelefoneRepresentante, tipo_for) VALUES(@codforn,@fornecedor,@Endereco,@Bairro,@Cidade," &
            "@Estado,@Cep,@Telefone,@Cgc,@Ie,@Email,@Vendedor,@TelVend,@Rep,@TelRep,@tipofor)"
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@codforn", codigo)
        cmd.Parameters.AddWithValue("@fornecedor", fornecedor)
        cmd.Parameters.AddWithValue("@Endereco", endereco)
        cmd.Parameters.AddWithValue("@Bairro", bairro)
        cmd.Parameters.AddWithValue("@Cidade", cidade)
        cmd.Parameters.AddWithValue("@Estado", uf)
        cmd.Parameters.AddWithValue("@Cep", cep)
        cmd.Parameters.AddWithValue("@Telefone", telefone)
        cmd.Parameters.AddWithValue("@Cgc", cnpj)
        cmd.Parameters.AddWithValue("@Ie", ie)
        cmd.Parameters.AddWithValue("@Email", email)
        cmd.Parameters.AddWithValue("@Vendedor", vendedor)
        cmd.Parameters.AddWithValue("@TelVend", telvend)
        cmd.Parameters.AddWithValue("@Rep", rep)
        cmd.Parameters.AddWithValue("@TelRep", telrep)
        cmd.Parameters.AddWithValue("@tipofor", tipofor)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o registro.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            d.desconecta()
        End Try
    End Sub

    Public Sub atualiza_fornecedor(ByVal codigo As Integer, ByVal fornecedor As String, ByVal endereco As String, ByVal bairro As String,
                            ByVal cidade As String, ByVal uf As String, ByVal cep As String, ByVal telefone As String, ByVal cnpj As String,
                            ByVal ie As String, ByVal email As String, ByVal vendedor As String, ByVal telvend As String,
                            ByRef rep As String, ByVal telrep As String, ByVal tipofor As String)
        Dim strSQL As String = "UPDATE Fornecedor SET Fornecedor=@fornecedor, Endereco=@Endereco ,Bairro=@Bairro, Cidade=@Cidade," &
            "Estado=@Estado, Cep=@Cep, Telefone=@Telefone, Cgc=@Cgc, I_Estadual=@Ie, E_mail=@Email, Vendedor=@Vendedor," &
            "TelefoneVendedor=@TelVend, Representante=@Rep, TelefoneRepresentante=@TelRep, tipo_for = @tipofor WHERE Cod_fornecedor=@codforn"

        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@codforn", codigo)
        cmd.Parameters.AddWithValue("@fornecedor", fornecedor)
        cmd.Parameters.AddWithValue("@Endereco", endereco)
        cmd.Parameters.AddWithValue("@Bairro", bairro)
        cmd.Parameters.AddWithValue("@Cidade", cidade)
        cmd.Parameters.AddWithValue("@Estado", uf)
        cmd.Parameters.AddWithValue("@Cep", cep)
        cmd.Parameters.AddWithValue("@Telefone", telefone)
        cmd.Parameters.AddWithValue("@Cgc", cnpj)
        cmd.Parameters.AddWithValue("@Ie", ie)
        cmd.Parameters.AddWithValue("@Email", email)
        cmd.Parameters.AddWithValue("@Vendedor", vendedor)
        cmd.Parameters.AddWithValue("@TelVend", telvend)
        cmd.Parameters.AddWithValue("@Rep", rep)
        cmd.Parameters.AddWithValue("@TelRep", telrep)
        cmd.Parameters.AddWithValue("@tipofor", tipofor)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar o registro.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            d.desconecta()
        End Try
    End Sub

    Public Sub exclui_fornecedor(ByVal codigo As Integer)
        Dim strSQL As String = "DELETE FROM Fornecedor WHERE Cod_fornecedor=@codforn"
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@codforn", codigo)

        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir o registro.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            d.desconecta()
        End Try
    End Sub

    Public Sub limpaTextBox(ByVal frmForm As Form)
        Dim controle As Control

        For Each controle In frmForm.Controls
            If TypeOf controle Is System.Windows.Forms.TextBox Then
                controle.Text = ""
            End If
        Next
    End Sub

    Public Sub limpaTextBoxAba(ByVal controle As TabControl)
        For Each aba As TabPage In controle.TabPages
            For Each ctl As Control In aba.Controls
                If TypeOf ctl Is System.Windows.Forms.TextBox Then
                    ctl.Text = ""
                End If
            Next
        Next
    End Sub


    Public Function verifica_produto_pedido(ByVal codpedido As Integer, ByVal codproduto As Integer, ByVal idfilial As Integer) As Boolean
        Dim strSQL As String = "select cod_pedido, cod_produto from pedido_fornecedor_itens " &
                                "where (cod_pedido = @codpedido) and (cod_produto = @codproduto) and (id_filial = @idfilial)"
        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@codpedido", codpedido)
        cmd.Parameters.AddWithValue("@codproduto", codproduto)
        cmd.Parameters.AddWithValue("@idfilial", idfilial)

        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
        Catch ex As Exception
            MessageBox.Show("Erro de conexão de dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            d.desconecta()
        End Try
        Return resultado
    End Function

    Public Function retorna_pedido_status(ByVal codpedido As Integer) As Boolean
        Dim strSQL As String = "select cod_pedido, cod_status_pedido from pedido_fornecedor " &
            "where cod_pedido =@codpedido and cod_status_pedido = 7"
        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@codpedido", codpedido)

        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
        Catch ex As Exception
            MessageBox.Show("Erro de conexão de dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            d.desconecta()
        End Try

        Return resultado
    End Function

    'Função responsável por trazer o código do usuário
    Public Function retorna_codigo_usuario(ByVal codusuario As Integer) As Integer
        strSQL = "select cod_usuario from usuarios where cod_usuario = '" & RTrim(codusuario) & "'"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim dr As SqlDataReader
        Dim resultado As Integer
        d.conecta()
        dr = cmd.ExecuteReader()
        Try
            dr.Read()
            resultado = dr.GetInt32(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try

        Return resultado
    End Function

    'Função responsável por trazer o preco de compra e o desconto de compra da tabela produtos
    Public Function retorna_preco_compra_desconto(ByVal codigoprod As Integer) As Double
        strSQL = "select preco_compra, desconto_compra from produtos where cod_produto = " & codigoprod & ""
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim dr As SqlDataReader
        Dim resultado As Integer
        d.conecta()
        dr = cmd.ExecuteReader()
        Try
            dr.Read()
            ppreco_compra = dr.Item("preco_compra").ToString
            pdesconto_compra = dr.Item("desconto_compra").ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
        'Return resultado
    End Function

    'Função responsável por trazer o preco de compra e o desconto de compra da tabela produtos
    Public Function retorna_preco_venda(ByVal codigoprod As Integer) As Double
        strSQL = "select preco_venda from produtos where cod_produto = " & codigoprod & ""
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim resultado As Double
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
        'Return resultado
    End Function

    'Função responsável por trazer o estoque fisico tabela produtos
    Public Function retorna_saldo_fisico(ByVal codigoprod As Integer, ByVal idfilial As Integer) As Integer
        strSQL = "select sum(movimento.quant) as saldo from movimento where movimento.cod_produto = " & codigoprod &
            " and movimento.id_filial = " & idfilial & ""
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim dr As SqlDataReader
        Dim resultado As Integer
        d.conecta()
        dr = cmd.ExecuteReader()
        Try
            dr.Read()
            resultado = dr.Item("saldo").ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
        Return resultado
    End Function

    'Função responsável por trazer o estoque fisico tabela produtos
    Public Function retorna_saldo_financeiro(ByVal codigoprod As Integer) As Double
        strSQL = "select sum(((preco_compra) - (preco_compra * (desconto_compra/100)))) AS TOTAL FROM PRODUTOS " &
            "WHERE COD_PRODUTO = " & codigoprod & " group by cod_produto, id_fabricante,cod_lente, cod_barra, cod_grupo, produto"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim dr As SqlDataReader
        Dim resultado As Integer
        d.conecta()
        dr = cmd.ExecuteReader()
        Try
            dr.Read()
            resultado = dr.Item("total").ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
        Return resultado
    End Function

    Public Sub conclui(ByVal codmovimento As Integer, ByVal idfilial As Integer)
        Dim strSQL As String = ""
        strSQL = "Update movimentomaster set concluido = 'S' " &
        "where cod_movimento = " & codmovimento &
        " and id_filial = " & idfilial & ""
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Function verifica_pedido_balcao(ByVal numpedido As Integer, ByVal idfilial As Integer) As Boolean
        Dim strSQL As String = "select num_pedido from pedido_balcao " &
            "where num_pedido = @numpedido and id_filial = @idfilial"
        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@numpedido", numpedido)
        cmd.Parameters.AddWithValue("@idfilial", idfilial)
        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
            Return resultado
        Catch ex As Exception
            MessageBox.Show("Erro de conexão de dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            d.desconecta()
        End Try
    End Function

    Public Sub atualiza_status_itens_pedido(ByVal numpedido As Integer, ByVal idfilial As Integer, ByVal codproduto As Integer, ByVal item As Integer)
        Dim strSQL As String = ""
        strSQL = "Update pedido_balcao_itens set cod_status_item = 5 " &
        "where num_pedido = " & numpedido & " and item = " & item & " and id_filial = " & idfilial & " and cod_produto = " & codproduto & ""
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub atualiza_quantidade_itens_pedido(ByVal numpedido As Integer, ByVal idfilial As Integer, ByVal codproduto As Integer, ByVal quant As Integer)
        Dim strSQL As String = ""
        strSQL = "Update pedido_balcao_itens set quant = quant + " & quant &
        "where num_pedido = " & numpedido & " and id_filial = " & idfilial & " and cod_produto = " & codproduto & ""
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub atualiza_quantidade_itens_servico(ByVal numpedido As Integer, ByVal idfilial As Integer, ByVal codservico As Integer, ByVal quant As Integer)
        Dim strSQL As String = ""
        strSQL = "Update pedido_balcao_servicos set quant = quant + " & quant &
        "where num_pedido = " & numpedido & " and id_filial = " & idfilial & " and cod_servico = " & codservico & ""
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Function verifica_itens_pedido(ByVal numpedido As Integer, ByVal idfilial As Integer, ByVal codproduto As Integer, ByVal item As Integer) As Boolean
        Dim strSQL As String = ""
        Dim resultado As Boolean = False
        strSQL = "Select * From pedido_balcao_itens " &
        "where num_pedido = " & numpedido & " and item = " & item & " and id_filial = " & idfilial & " and cod_produto = " & codproduto &
        " cod_status_item = 5"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return True
    End Function

    Public Sub grava_quant_itens_pedido_dev(ByVal numpedido As Integer, ByVal idfilial As Integer, ByVal item As Integer, ByVal codproduto As Integer,
                                               ByVal quant As Integer, ByVal preco As Double, ByVal desconto As Double, ByVal total As Double,
                                               ByVal codstatus As Integer, ByVal pacote As String, ByVal codpacote As Integer, ByVal desccaixa As Double)
        Dim strSQL As String = ""
        strSQL = "Insert Into pedido_balcao_itens (num_pedido, id_filial, item, cod_produto, quant, compra, desconto, preco, cod_status_item," &
            "pacote, cod_pacote, desc_caixa) Values(@numpedido, @idfilial, @item ,@codProduto, @quant, @compra, @desconto, @preco, @codstatusprod," &
            "@pacote, @codpacote, @desccaixa)"
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@numpedido", numpedido)
        cmd.Parameters.AddWithValue("@item", item)
        cmd.Parameters.AddWithValue("@idfilial", idfilial)
        cmd.Parameters.AddWithValue("@codProduto", codproduto)
        cmd.Parameters.AddWithValue("@quant", quant)
        cmd.Parameters.AddWithValue("@compra", preco)
        cmd.Parameters.AddWithValue("@desconto", desconto)
        cmd.Parameters.AddWithValue("@preco", total)
        cmd.Parameters.AddWithValue("@codstatusprod", codstatus)
        cmd.Parameters.AddWithValue("@pacote", pacote)
        cmd.Parameters.AddWithValue("@codpacote", codpacote)
        cmd.Parameters.AddWithValue("@desccaixa", desccaixa)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Function retona_produtos_estoque(ByVal numpedido As Integer, ByVal status As Integer, ByVal filial As Integer) As DataTable
        Dim strSQL As String = ""
        Dim tb As New DataTable
        strSQL = "SELECT pedido_balcao_itens.num_pedido, pedido_balcao_itens.id_filial, pedido_balcao_itens.item, " &
        "pedido_balcao_itens.cod_produto,pedido_balcao_itens.quant, pedido_balcao_itens.compra, pedido_balcao_itens.desconto," &
        "pedido_balcao_itens.preco, pedido_balcao_itens.cod_status_item, pedido_balcao_itens.Pacote, pedido_balcao_itens.cod_pacote," &
        "pedido_balcao_itens.desc_caixa,produtos.produto, lentes_blocos.cod_lente, lentes_tabela.cod_tabela, " &
        "(pedido_balcao_itens.quant*(round(pedido_balcao_itens.preco,2)-(round(pedido_balcao_itens.preco,2)*(pedido_balcao_itens.desconto/100)))) as total, " &
        "status_item_pedido.cod_status_item,status_item_pedido.status_item, pedido_balcao_itens.cod_pacote " &
        "FROM pedido_balcao_itens INNER JOIN produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " &
        "INNER JOIN lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente INNER JOIN lentes_tabela ON " &
        "lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " &
        "INNER JOIN status_item_pedido ON pedido_balcao_itens.cod_status_item = status_item_pedido.cod_status_item " &
        "WHERE pedido_balcao_itens.num_pedido = " & numpedido & " and pedido_balcao_itens.cod_status_item = " & status & " AND pedido_balcao_itens.id_filial = " & filial
        d.carrega_Tabela(strSQL, tb)
        Return tb
    End Function

    Public Function retona_produtos_estoque(ByVal numpedido As Integer, ByVal status As Integer) As DataTable
        Dim strSQL As String = ""
        Dim tb As New DataTable
        strSQL = "SELECT pedido_balcao_itens.num_pedido, pedido_balcao_itens.id_filial, pedido_balcao_itens.item, " &
        "pedido_balcao_itens.cod_produto,pedido_balcao_itens.quant, pedido_balcao_itens.compra, pedido_balcao_itens.desconto," &
        "pedido_balcao_itens.preco, pedido_balcao_itens.cod_status_item, pedido_balcao_itens.Pacote, pedido_balcao_itens.cod_pacote," &
        "pedido_balcao_itens.desc_caixa,produtos.produto, lentes_blocos.cod_lente, lentes_tabela.cod_tabela, " &
        "(pedido_balcao_itens.quant*(round(pedido_balcao_itens.preco,2)-(round(pedido_balcao_itens.preco,2)*(pedido_balcao_itens.desconto/100)))) as total, " &
        "status_item_pedido.cod_status_item,status_item_pedido.status_item, pedido_balcao_itens.cod_pacote " &
        "FROM pedido_balcao_itens INNER JOIN produtos ON pedido_balcao_itens.cod_produto = produtos.cod_produto " &
        "INNER JOIN lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente INNER JOIN lentes_tabela ON " &
        "lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " &
        "INNER JOIN status_item_pedido ON pedido_balcao_itens.cod_status_item = status_item_pedido.cod_status_item " &
        "WHERE pedido_balcao_itens.num_pedido = " & numpedido & " and pedido_balcao_itens.cod_status_item = " & status & ""
        d.carrega_Tabela(strSQL, tb)
        Return tb
    End Function

    Public Function retornaUltimoRegistro(ByVal tabela As String, ByVal campo As String, ByVal filial As Integer) As Integer
        Dim strSQL = "SELECT MAX(" & campo & ") FROM " & tabela & " WHERE ID_FILIAL = " & filial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim registro As Integer
        Try
            d.conecta()
            registro = cmd.ExecuteScalar
            Return registro
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function retornaUltimoRegistro(ByVal tabela As String, ByVal campo As String) As Long
        Dim strSQL = "SELECT MAX(" & campo & ") FROM " & tabela & ""
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim registro As Long
        Try
            d.conecta()
            registro = cmd.ExecuteScalar
            Return registro
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function retornaUltimoRegistro(ByVal tabela As String, ByVal campo As String, ByVal instrucao As String) As Integer
        Dim strSQL = "SELECT MAX(" & campo & ") FROM " & tabela & " " & instrucao
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim registro As Integer
        Try
            d.conecta()
            If cmd.ExecuteScalar Is DBNull.Value Then
                registro = 0
            Else
                registro = cmd.ExecuteScalar
            End If
            Return registro + 1
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function atualizaMovimentoMaster(ByVal dtData As DateTime, ByVal usuario As Integer, ByVal movimento As Integer, ByVal filial As Integer) As Integer
        Dim strSQL = "UPDATE MOVIMENTOMASTER SET DATA = '" & dtData & "', ID_USUARIO = " & usuario & ", CONCLUIDO = 'S' " &
            "WHERE COD_MOVIMENTO = " & movimento & " AND ID_FILIAL = " & filial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim registro As Integer
        Try
            d.conecta()
            registro = cmd.ExecuteScalar
            Return registro
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    'Função responsável por retornar situação do caixa se está aberto ou fechado
    Public Function retornaSituacaoCaixa(ByVal intFilial As Integer) As Boolean
        Dim resultado As Boolean
        resultado = False
        Dim strSQL As String = "SELECT 1 FROM CAIXA WHERE SITUACAO = 'A' AND FILIAL = " & intFilial & ""
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por retornar a data do último caixa aberto pela filial
    Public Function retornaDataCaixaAberto(ByVal intFilial As Integer) As DateTime
        Dim resultado As DateTime
        Dim strSQL As String = "SELECT data_caixa FROM CAIXA WHERE SITUACAO = 'A' AND FILIAL = " & intFilial & ""
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por informar se já foi aberto um caixa na data espefificada na hora de abrir o caixa pela filial
    Public Function retornaDataCaixaAberto(ByVal data As DateTime, ByVal filial As Integer) As Boolean
        Dim resultado As Boolean
        resultado = False
        Dim strSQL As String = "SELECT 1 FROM CAIXA WHERE DATA_CAIXA = @DATA AND FILIAL = @FILIAL"
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.Add("@DATA", data)
        cmd.Parameters.Add("@FILIAL", filial)
        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por verificar se o caixa já está fechado em uma data especifica
    Public Function retornaDataCaixaAberto(ByVal data As DateTime) As Boolean
        Dim resultado As Boolean
        resultado = False
        Dim strSQL As String = "SELECT 1 FROM CAIXA WHERE DATA_CAIXA = @DATA AND SITUACAO = 'F'"
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.Add("@DATA", data)
        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por verificar se o caixa existe
    Public Function retornaDataCaixaExistente(ByVal data As DateTime) As Boolean
        Dim resultado As Boolean
        resultado = False
        Dim strSQL As String = "SELECT 1 FROM CAIXA WHERE DATA_CAIXA = @DATA"
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@DATA", data)
        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por retornar data e hora do servidor
    Public Function retornaDataHoraServidor() As DateTime
        Dim resultado As DateTime
        Dim strSQL As String = "SELECT GETDATE()"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por retornar o nome do usuário
    Public Function retornaUsuario(ByVal codigo As Integer) As String
        Dim resultado As String = ""
        Dim strSQL As String = "SELECT NOME FROM USUARIOS WHERE COD_USUARIO = @CODIGO"
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@CODIGO", codigo)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por atualizar o status do caixa de aberto para fechado
    Public Sub atualiza_status_caixa(ByVal dtCaixa As DateTime, ByVal intFilial As Integer, ByVal vFinal As Double, ByVal vDinheiro As Double,
                                     ByVal vCredito As Double, ByVal vDebito As Double, ByVal vCheque As Double, ByVal vBoleto As Double,
                                     ByVal vOutros As Double, ByVal usuarioFechamento As Integer, ByVal filial As Integer)
        Dim strSQL As String = ""
        strSQL = "Update Caixa set situacao = 'F', " &
            "Valor_Final = " & d.cdin(vFinal) & "," &
            "Valor_Dinheiro = " & d.cdin(vDinheiro) & "," &
            "Valor_Credito = " & d.cdin(vCredito) & "," &
            "Valor_Debito = " & d.cdin(vDebito) & "," &
            "Valor_Cheque = " & d.cdin(vCheque) & "," &
            "Valor_Boleto = " & d.cdin(vBoleto) & "," &
            "Valor_Outros = " & d.cdin(vOutros) & "," &
            "Usuario_Fechamento = " & d.cdin(usuarioFechamento) & "," &
            "Filial = " & filial &
            " where data_caixa = " & d.pdtm(dtCaixa) & " And Filial = " & intFilial & ""
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Rotina responsável por inserir informações na tabela caixa
    Public Sub abre_caixa(ByVal codcaixa As Integer, ByVal caixa As Integer, ByVal data As DateTime, ByVal situacao As String,
                          ByVal vinicial As Double, ByVal vFinal As Double, ByVal usuarioabertura As Integer, ByVal filial As Integer)
        strSQL = "INSERT INTO caixa(Cod_Caixa, Caixa, Data_Caixa, Situacao, Valor_Inicial, Valor_Final,Valor_Dinheiro, Valor_Credito, Valor_Debito," &
            "Valor_Cheque, Valor_Boleto, Valor_Outros,Usuario_Abertura, Filial) " &
            "VALUES(@codcaixa, @caixa, @data, @situacao, @vinicial, @vfinal,@vdinheiro, @vcredito, @vdebito, @vcheque, @vboleto, @voutros," &
            "@usuarioabertura, @filial)"
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@codcaixa", codcaixa)
        cmd.Parameters.AddWithValue("@caixa", caixa)
        cmd.Parameters.AddWithValue("@data", data)
        cmd.Parameters.AddWithValue("@situacao", situacao)
        cmd.Parameters.AddWithValue("@vinicial", d.cdin(vinicial))
        cmd.Parameters.AddWithValue("@vfinal", d.cdin("0,00"))
        cmd.Parameters.AddWithValue("@vdinheiro", d.cdin("0,00"))
        cmd.Parameters.AddWithValue("@vcredito", d.cdin("0,00"))
        cmd.Parameters.AddWithValue("@vdebito", d.cdin("0,00"))
        cmd.Parameters.AddWithValue("@vcheque", d.cdin("0,00"))
        cmd.Parameters.AddWithValue("@vboleto", d.cdin("0,00"))
        cmd.Parameters.AddWithValue("@voutros", d.cdin("0,00"))
        cmd.Parameters.AddWithValue("@usuarioabertura", usuarioabertura)
        cmd.Parameters.AddWithValue("@filial", filial)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Função responsável por verificar a identidade do gerente, caso a senha e o codigo corresponda a um usuário com o status de gerente
    Public Function verifica_Gerente(ByVal codigo As Integer, ByVal strSenha As String) As Boolean
        Dim resultado As Boolean
        resultado = False
        Dim strSQL As String = "SELECT 1 FROM USUARIOS WHERE Cod_Usuario = " & codigo & " AND Senha = '" & strSenha & "' AND Cod_Tipo_Usuario = 5"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Function

    'Converte o valor informado para o formato da moeda corrente
    Public Function formataValorMoeda(ByVal valor As Double) As String
        Dim convertido As String
        convertido = Format(valor, "#,##0.00")
        Return convertido
    End Function

    'Converte a data informada no formato aaaa/mm/dd
    Public Function convertedata(ByVal data As DateTime, ByVal hora As String) As String
        Dim dia, mes, ano As Integer
        Dim strdata As String

        dia = data.Day
        mes = data.Month
        ano = data.Year
        strdata = ano & "/" & mes & "/" & dia & " " & hora

        Return strdata
    End Function

    'Converte a data informada no formato aaaa/mm/dd
    Public Function convertedata(ByVal data As DateTime) As String
        Dim dia, mes, ano As String
        Dim strdata As String

        dia = data.Day
        mes = data.Month
        ano = data.Year

        If dia.ToString.Length = 1 Then
            dia = "0" & dia
        End If

        If mes.ToString.Length = 1 Then
            mes = "0" & mes
        End If

        strdata = ano & "/" & mes & "/" & dia

        Return strdata
    End Function

    'Converte a data informada no formato aaaa/mm/dd
    Public Function convertedataNFe(ByVal data As DateTime) As String
        Dim dia, mes, ano, h, m, s As String
        Dim strdata As String

        dia = data.Day
        mes = data.Month
        ano = data.Year
        h = data.Hour
        m = data.Minute
        s = data.Second

        If dia.ToString.Length = 1 Then
            dia = "0" & dia
        End If

        If mes.ToString.Length = 1 Then
            mes = "0" & mes
        End If

        If h.ToString.Length = 1 Then
            h = "0" & h
        End If

        If m.ToString.Length = 1 Then
            m = "0" & m
        End If

        If s.ToString.Length = 1 Then
            s = "0" & s
        End If

        strdata = ano & "-" & mes & "-" & dia & "T" & h & ":" & m & ":" & s

        Return strdata
    End Function

    'Função responsável por retira a baixa de um titlo já baixado
    Public Sub exclui_baixa_titulo(ByVal lanc As Integer, ByVal filial As Integer)
        Dim resultado As Boolean
        resultado = False
        Dim strSQL As String = "UPDATE LANCAMENTOS SET DATA_RECEBIMENTO = NULL, ACRESCIMO = 0, JUROS = 0, DESCONTO = 0" &
                                " WHERE COD_LANCAMENTO = " & lanc & " AND ID_FILIAL = " & filial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Função responsável por retira a baixa de um titlo já baixado
    Public Sub exclui_baixa_titulo(ByVal lanc As Integer, ByVal filial As Integer, ByVal documento As Integer, ByVal usuario As Integer)
        Dim resultado As Boolean
        resultado = False
        Dim strSQL As String = "UPDATE BOLETO SET ACRESCIMO = 0, USUARIO_ALT = " & usuario &
                                " WHERE COD_LANCAMENTO = " & lanc & " AND ID_FILIAL = " & filial & " AND DOCUMENTO = " & documento
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Função responsável por verificar se o usuário tem permissão de acesso aos recursos do sistema
    'Para usar essa função primeiro o devemos usar a função retorna_cod_usuario
    Public Function verifica_permissao_usuario(ByVal codusuario As Integer, ByVal codacesso As Integer) As Boolean
        Dim resultado As Boolean
        resultado = False
        'Dim strSQL As String = "SELECT 1 FROM USUARIOS WHERE Cod_Usuario = " & codigo & " AND Senha = " & strSenha & ""
        Dim strSQL = "Select 1 from acessos_usuario where cod_usuario = " &
        codusuario & " and  cod_procedimento = " & codacesso & ""
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por verificar se o usuário tem permissão de acesso aos recursos do sistema
    'Para usar essa função primeiro o devemos usar a função retorna_cod_usuario
    Public Function verifica_permissao_menu(ByVal codusuario As Integer) As Integer
        Dim resultado As Boolean
        resultado = False
        'Dim strSQL As String = "SELECT 1 FROM USUARIOS WHERE Cod_Usuario = " & codigo & " AND Senha = " & strSenha & ""
        Dim strSQL = "Select cod_tipo_usuario from usuarios where cod_usuario = " &
        codusuario & ""
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim dr As SqlDataReader
        Try
            d.conecta()
            dr = cmd.ExecuteReader
            dr.Read()
            Return dr("cod_tipo_usuario")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por verificar se o tipo de usuário já está vinculado a algum usuário
    Public Function verifica_existencia_tipo_usuario(ByVal codtipousuario As Integer) As Boolean
        Dim resultado As Boolean
        resultado = False
        Dim strSQL = "Select 1 from usuarios where cod_tipo_usuario = " & codtipousuario
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por verificar se o tipo de usuário já está vinculado a algum usuário
    Public Function verifica_existencia_registro(ByVal instrucaoSQL As String) As Boolean
        Dim resultado As Boolean
        resultado = False
        Dim strSQL = instrucaoSQL
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por verificar se o tipo de usuário já está vinculado a algum usuário
    Public Function retornaRegistro(ByVal instrucaoSQL As String) As DataSet
        Dim strSQL = instrucaoSQL
        d.conecta()
        Dim da As New SqlDataAdapter(strSQL, d.con)
        Dim ds As New DataSet
        ds.Reset()
        Try
            da.Fill(ds, "Registro")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
        Return ds
    End Function

    Public Function dataPorExtenso() As String
        Dim dtData As Date

        dtData = Now

        Dim intDia As Integer = dtData.Day
        Dim intMes As Integer = dtData.Month
        Dim intAno As Integer = dtData.Year
        Dim strMes As String

        Select Case intMes
            Case 1
                strMes = "Janeiro"
            Case 2
                strMes = "Fevereiro"
            Case 3
                strMes = "Março"
            Case 4
                strMes = "Abril"
            Case 5
                strMes = "Maio"
            Case 6
                strMes = "Junho"
            Case 7
                strMes = "Julho"
            Case 8
                strMes = "Agosto"
            Case 9
                strMes = "Setembro"
            Case 10
                strMes = "Outubro"
            Case 11
                strMes = "Novembro"
            Case 12
                strMes = "Dezembro"
        End Select

        Return "Belém, " & intDia & " de " & strMes & " de " & intAno
    End Function

    Public Function dataPorExtensoSemBelem() As String
        Dim dtData As Date

        dtData = Now

        Dim intDia As Integer = dtData.Day
        Dim intMes As Integer = dtData.Month
        Dim intAno As Integer = dtData.Year
        Dim strMes As String

        Select Case intMes
            Case 1
                strMes = "Janeiro"
            Case 2
                strMes = "Fevereiro"
            Case 3
                strMes = "Março"
            Case 4
                strMes = "Abril"
            Case 5
                strMes = "Maio"
            Case 6
                strMes = "Junho"
            Case 7
                strMes = "Julho"
            Case 8
                strMes = "Agosto"
            Case 9
                strMes = "Setembro"
            Case 10
                strMes = "Outubro"
            Case 11
                strMes = "Novembro"
            Case 12
                strMes = "Dezembro"
        End Select

        Return intDia & " de " & strMes & " de " & intAno
    End Function

    'Rotina responsável por excluir pacote
    Public Sub excluir_pacote(ByVal codpacote As Integer, ByVal codcliente As Integer)
        strSQL = "DELETE FROM pacote_cliente WHERE cod_pacote = " & codpacote & " AND cod_cliente = " & codcliente
        d.conecta()
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Rotina responsável excluir item do pacote
    Public Sub excluir_item_pacote(ByVal codpacote As Integer, ByVal codcliente As Integer)
        strSQL = "DELETE FROM pacote_cliente_detalhes WHERE cod_pacote = " & codpacote & " AND cod_cliente = " & codcliente
        d.conecta()
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Rotina responsável excluir item do pacote
    Public Sub excluir_item_pacote(ByVal codpacote As Integer, ByVal codcliente As Integer, ByVal codtabela As Integer)
        strSQL = "DELETE FROM pacote_cliente_detalhes WHERE cod_pacote = " & codpacote & " AND cod_cliente = " & codcliente & " and cod_tabela = " & codtabela
        d.conecta()
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Rotina responsável excluir credito pacote
    Public Sub excluir_credito_pacote(ByVal codpacote As Integer, ByVal codcliente As Integer)
        strSQL = "DELETE FROM credito_pacote WHERE cod_pacote = " & codpacote & " AND cod_cliente = " & codcliente
        Dim cmd As New SqlCommand(strSQL, d.con)
        d.conecta()
        Try
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Rotina responsável por verificar se o pedido foi ou não faturado
    Public Function verifica_pedido_faturado(ByVal pedido As Integer, ByVal filial As Integer) As Integer
        strSQL = "select COUNT(item) as item from fatura_itens where num_pedido = @pedido and id_filial = @filial"
        Dim cmd As New SqlCommand(strSQL, d.con)
        cmd.Parameters.AddWithValue("@pedido", pedido)
        cmd.Parameters.AddWithValue("@filial", filial)
        d.conecta()

        Try
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Function

    Public Function retorna_Codigo_Credito(ByVal codpacote As Integer, ByVal codcliente As Integer) As Integer
        Dim strSQL As String = "select cod_cliente, cod_credito from credito_pacote where cod_pacote = " & codpacote &
            " and cod_cliente = " & codcliente
        Dim resultado As Integer
        'Instrução responsável por recuperar os dados de cod_credito e cod_cliente
        Try
            d.conecta()
            Dim cmd As New SqlCommand(strSQL, d.con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                resultado = CInt(dr("cod_credito").ToString)
            Else
                resultado = 0
            End If
            dr.Close()
            d.desconecta()
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function retorna_preco_servico(ByVal codproduto As Integer) As Double
        Dim strSQL As String = "select preco_venda from produtos where cod_produto = " & codproduto
        Dim resultado As Integer
        'Instrução responsável por recuperar os dados de cod_credito e cod_cliente
        Try
            d.conecta()
            Dim cmd As New SqlCommand(strSQL, d.con)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            dr.Read()
            resultado = CDbl(dr("preco_venda").ToString)
            dr.Close()
            d.desconecta()
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function


    'Teste

    'Função responsável por retornar o acréscimo de acordo com a data especificada
    Public Function retornaDataAcrescimo(ByVal codfatura As Integer, ByVal intFilial As Integer, ByVal data As String) As DateTime
        Dim resultado As DateTime
        Dim strSQL As String = "SELECT data FROM ACRESCIMOS_FATURA WHERE cod_fatura_cred = " & codfatura & " AND id_filial = " & intFilial & " AND convert(char(10),data,111) = '" & data & "'"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por retornar o desconto de acordo com a data especificada
    Public Function retornaDataDesconto(ByVal codfatura As Integer, ByVal intFilial As Integer, ByVal data As String) As DateTime
        Dim resultado As DateTime
        Dim strSQL As String = "SELECT data FROM DESCONTOS_FATURA WHERE cod_fatura = " & codfatura & " AND id_filial = " & intFilial & " AND convert(char(10),data,111) = '" & data & "'"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por retornar o valor do acréscimo
    Public Function retornaValorAcrescimo(ByVal codfatura As Integer, ByVal intFilial As Integer, ByVal data As String) As Double
        Dim resultado As Double
        Dim strSQL As String = "SELECT SUM(valor) FROM ACRESCIMOS_FATURA WHERE cod_fatura_cred = " & codfatura & " AND id_filial = " & intFilial & " AND CONVERT(char(10),data,111) = '" & data & "'"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por retornar o valor do desconto
    Public Function retornaValorDesconto(ByVal codfatura As Integer, ByVal intFilial As Integer, ByVal data As String) As Double
        Dim resultado As Double
        Dim strSQL As String = "SELECT SUM(valor) FROM DESCONTOS_FATURA WHERE cod_fatura = " & codfatura & " AND id_filial = " & intFilial & " AND CONVERT(char(10),data,111) = '" & data & "'"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function


    Public Sub salva_acordo(ByVal codacordo As Integer, ByVal codfilialcli As Integer, ByVal codcliente As Integer, ByVal data As Date, ByVal status As Char, ByVal codusuario As Integer)
        Dim strSQL As String = "INSERT INTO cliente_acordo(cod_acordo,cod_filial_cliente,cod_cliente,data,status_acordo,cod_usuario) " &
                               "VALUES(" & codacordo & "," & codfilialcli & "," & codcliente & "," & d.pdtm(data) & "," & d.PStr(status) & "," & codusuario & ")"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o registro na tabela cliente acordo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Função resposável por salvar as informações na tabela lançamentos
    Public Sub salva_lancamentos(ByVal codlanc As Integer, ByVal idfiliallanc As Integer, ByVal idfilial As Integer,
                                 ByVal datalanc As DateTime, ByVal codconta As Integer, ByVal valor As Double, ByVal formapag As Integer,
                                 ByVal nparcela As Integer, ByVal nparcelas As Integer, ByVal datavenc As DateTime,
                                 ByVal historico As String, ByVal doc As String, ByVal tipo As Char, ByVal codfatura As Integer,
                                 ByVal acrescimo As Double, ByVal juros As Double, ByVal desconto As Double, ByVal taxas As Double,
                                 ByVal usuariolanc As Integer, ByVal usuarioalt As Integer)
        Dim strSQL As String = "INSERT INTO lancamentos(cod_lancamento, id_filial_lancamento,id_filial,data_lancamento" &
           ",cod_conta,Valor,cod_forma_pagamento,n_parcelas,n_parcela, data_vencimento,historico,doc,tipo," &
           "cod_fatura,acrescimo,juros,desconto,taxas, usuario_lanc, usuario_alt) " &
           "VALUES (" & codlanc & "," & idfiliallanc & "," & idfilial & "," & d.pdtm(datalanc) & "," & codconta & "," & valor.ToString.Replace(",", ".") & "," &
           formapag & "," & nparcela & "," & nparcelas & "," & d.Pdt(datavenc) & ",'" & historico & "','" & doc & "','" & tipo &
           "'," & codfatura & "," & acrescimo.ToString.Replace(",", ".") & "," & juros.ToString.Replace(",", ".") & "," & desconto.ToString.Replace(",", ".") &
           "," & taxas.ToString.Replace(",", ".") & "," & usuariolanc & "," & usuarioalt & ")"

        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o registro na tabela lancamentos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Função resposável por salvar as informações na tabela lançamentos_cliente
    Public Sub salva_lancamento_cliente(ByVal idfilial As Integer, ByVal codlanc As Integer, ByVal codfilialcli As Integer, ByVal codcli As Integer)
        Dim strSQL As String = "INSERT INTO lancamentos_cliente(id_filial,cod_lancamento,cod_filial_cliente,cod_cliente) " &
           "VALUES(" & idfilial & "," & codlanc & "," & codfilialcli & "," & codcli & ")"

        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o registro na tabela lancamentos cliente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Função resposável por salvar as informações na tabela pagamentos_acordo
    Public Sub salva_pagamento_acordo(ByVal codpagamento As Integer, ByVal codacordo As Integer, ByVal codfilialcli As Integer,
                                      ByVal codlanc As Integer, ByVal filiallanc As Integer, ByVal codbarra As String, ByVal total As Double,
                                      ByVal acrescimo As Double, ByVal juros As Double, ByVal desconto As Double, ByVal taxas As Double)
        Dim strSQL As String = "Insert into pagamentos_acordo(cod_pagamento_acordo,cod_acordo,id_filial," &
            "cod_lancamento,id_filial_lancamento, cod_barra, total_acordo, acrescimo, juros, desconto, taxas) values(" &
            codpagamento & "," & codacordo & "," & codfilialcli & "," & codlanc & "," & filiallanc & ",'" & codbarra &
            "'," & total.ToString.Replace(",", ".") & "," & acrescimo.ToString.Replace(",", ".") & "," & juros.ToString.Replace(",", ".") &
            "," & desconto.ToString.Replace(",", ".") & "," & taxas.ToString.Replace(",", ".") & ")"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o registro na tabela pagamento acordo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Função resposável por salvar as informações na tabela boleto
    Public Sub salva_boletos(ByVal numboleto As Integer, ByVal codlanc As Integer, ByVal idfilial As Integer, ByVal documento As Integer,
                             ByVal banco As Integer, ByVal emitente As Integer, ByVal nossonumero As String, ByVal barra As String,
                             ByVal digitavel As String, ByVal tipodocumento As String, ByVal boljuros As Double, ByVal manual As Boolean,
                             ByVal acrescimo As Double, ByVal diasprotesto As Integer, ByVal acaocobranca As String, ByVal usuario_inc As Integer,
                             ByVal usuario_alt As Integer, ByVal enviado As Char)
        Dim strSQL As String = "INSERT INTO boleto (Numero,cod_lancamento,id_filial,Documento,Banco,Emitente,Nossonumero,Barra,Digitavel," &
            "tipo_documento,bol_juros,manual,acrescimo,diasprotesto,acaocobranca,usuario_inc,usuario_alt, enviado) VALUES (" & numboleto & "," & codlanc & "," & idfilial & "," & documento & "," &
            banco & "," & emitente & ",'" & nossonumero & "','" & barra & "','" & digitavel & "','" & tipodocumento & "'," & boljuros.ToString.Replace(",", ".") & ",'" &
            manual & "'," & acrescimo.ToString.Replace(",", ".") & "," & diasprotesto & ",'" & acaocobranca & "'," & usuario_inc & "," & usuario_alt & ",'" & enviado & "'" & ")"

        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o registro na tabela boleto.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            d.desconecta()
        End Try
    End Sub


    'Função responsável por retornar o valor total do acordo
    Public Function retornaValorAcordo(ByVal codacordo As Integer, ByVal intFilial As Integer) As Double
        Dim resultado As Double
        Dim strSQL As String = "select SUM(total_acordo+acrescimo+juros+taxas-desconto) as valor from Pagamentos_acordo " &
            "where cod_acordo = " & codacordo & " And id_filial = " & intFilial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por retornar o valor total do acréscimo
    Public Function retornaValorAcordoAcrescimo(ByVal codacordo As Integer, ByVal intFilial As Integer) As Double
        Dim resultado As Double
        Dim strSQL As String = "select SUM(acrescimo) as valor from Pagamentos_acordo " &
            "where cod_acordo = " & codacordo & " And id_filial = " & intFilial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por retornar o valor total do juros
    Public Function retornaValorAcordoJuros(ByVal codacordo As Integer, ByVal intFilial As Integer) As Double
        Dim resultado As Double
        Dim strSQL As String = "select SUM(juros) as valor from Pagamentos_acordo " &
            "where cod_acordo = " & codacordo & " And id_filial = " & intFilial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por retornar o valor total do juros
    Public Function retornaValorAcordoTaxas(ByVal codacordo As Integer, ByVal intFilial As Integer) As Double
        Dim resultado As Double
        Dim strSQL As String = "select SUM(taxas) as valor from Pagamentos_acordo " &
            "where cod_acordo = " & codacordo & " And id_filial = " & intFilial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por retornar o valor total do juros
    Public Function retornaValorAcordoDesconto(ByVal codacordo As Integer, ByVal intFilial As Integer) As Double
        Dim resultado As Double
        Dim strSQL As String = "select SUM(desconto) as valor from Pagamentos_acordo " &
            "where cod_acordo = " & codacordo & " And id_filial = " & intFilial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por retornar o valor total já pago no acordo
    Public Function retornaValorPagoAcordo(ByVal codacordo As Integer, ByVal intFilial As Integer) As Double
        Dim resultado As Double
        Dim strSQL As String = "select SUM(Pagamentos_acordo.total_acordo+Pagamentos_acordo.acrescimo+Pagamentos_acordo.juros+Pagamentos_acordo.taxas) from " &
            "lancamentos inner join Pagamentos_acordo on lancamentos.cod_lancamento = Pagamentos_acordo.cod_lancamento " &
            "inner join lancamentos_cliente on lancamentos_cliente.cod_lancamento = lancamentos.cod_lancamento " &
            "inner join cliente_acordo on cliente_acordo.cod_acordo = Pagamentos_acordo.cod_acordo " &
            "where Pagamentos_acordo.cod_acordo = " & codacordo & " And Pagamentos_acordo.id_filial = " & intFilial &
            " and lancamentos.cod_status_lancamento <> 2 and not lancamentos.data_recebimento is null"

        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por retornar o valor a pagar do acordo
    Public Function retornaValoraPagarAcordo(ByVal codacordo As Integer, ByVal intFilial As Integer) As Double
        Dim resultado As Double
        Dim strSQL As String = "select SUM(lancamentos.valor+lancamentos.acrescimo+lancamentos.juros+lancamentos.taxas+Pagamentos_acordo.acrescimo+" &
            "Pagamentos_acordo.juros+pagamentos_acordo.taxas-Pagamentos_acordo.desconto-lancamentos.desconto+lancamentos.taxas) from " &
            "lancamentos inner join Pagamentos_acordo on lancamentos.cod_lancamento = Pagamentos_acordo.cod_lancamento " &
            "inner join lancamentos_cliente on lancamentos_cliente.cod_lancamento = lancamentos.cod_lancamento " &
            "inner join cliente_acordo on cliente_acordo.cod_acordo = Pagamentos_acordo.cod_acordo " &
            "where Pagamentos_acordo.cod_acordo = " & codacordo & " And Pagamentos_acordo.id_filial = " & intFilial &
            " and lancamentos.cod_status_lancamento <> 2 and not lancamentos.data_recebimento is not null"

        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por retornar o valor total já pago no acordo com juros e acrescimos
    Public Function retornaValorPagoAcordoTotal(ByVal codacordo As Integer, ByVal intFilial As Integer) As Double
        Dim resultado As Double
        Dim strSQL As String = "select SUM(lancamentos.valor+lancamentos.acrescimo+lancamentos.juros+lancamentos.taxas+Pagamentos_acordo.acrescimo+" &
            "Pagamentos_acordo.juros+pagamentos_acordo.taxas-Pagamentos_acordo.desconto-lancamentos.desconto+lancamentos.taxas) from " &
            "lancamentos inner join Pagamentos_acordo on lancamentos.cod_lancamento = Pagamentos_acordo.cod_lancamento " &
            "inner join lancamentos_cliente on lancamentos_cliente.cod_lancamento = lancamentos.cod_lancamento " &
            "inner join cliente_acordo on cliente_acordo.cod_acordo = Pagamentos_acordo.cod_acordo " &
            "where Pagamentos_acordo.cod_acordo = " & codacordo & " And Pagamentos_acordo.id_filial = " & intFilial &
            " and lancamentos.cod_status_lancamento <> 2 and not lancamentos.data_recebimento is null"

        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    Public Function titulos_Cliente_Acordo(ByVal codcliente As Integer, ByVal filial As Integer) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select lancamentos.cod_lancamento, lancamentos.id_filial,lancamentos.data_lancamento, lancamentos.data_vencimento,lancamentos.data_recebimento,(lancamentos.Valor+ISNULL(pagamentos_acordo.acrescimo+" &
            "pagamentos_acordo.taxas+pagamentos_acordo.juros-pagamentos_acordo.desconto,0)) as valor," &
            "lancamentos.doc, pagamentos_fatura.cod_fatura as cod_fatura_real, Pagamentos_acordo.cod_acordo, credito_pacote.cod_pacote," &
            "round((((isnull(lancamentos.Valor,0)+isnull(Pagamentos_acordo.acrescimo+Pagamentos_acordo.taxas+Pagamentos_acordo.juros-Pagamentos_acordo.desconto,0)) * 1 / 100)),2) as multa_total, " &
            "round((((isnull(lancamentos.Valor,0)+isnull(Pagamentos_acordo.acrescimo+Pagamentos_acordo.taxas+Pagamentos_acordo.juros-Pagamentos_acordo.desconto,0)) * (5/30.0) / 100) * DATEDIFF(day,data_vencimento,getdate())),2) as juros_total " &
            "from lancamentos left join " &
            "lancamentos_cliente on lancamentos.cod_lancamento = lancamentos_cliente.cod_lancamento and " &
            "lancamentos.id_filial = lancamentos_cliente.id_filial left join Pagamentos_fatura on " &
            "Pagamentos_fatura.cod_lancamento = lancamentos.cod_lancamento and Pagamentos_fatura.id_filial = lancamentos.id_filial " &
            "left join pagamentos_acordo on Pagamentos_acordo.cod_lancamento = lancamentos.cod_lancamento and " &
            "Pagamentos_acordo.id_filial = lancamentos.id_filial " &
            "left join pagamentos_credito  on pagamentos_credito.cod_lancamento = lancamentos.cod_lancamento and pagamentos_credito.id_filial = lancamentos.id_filial " &
            "left join credito_pacote on credito_pacote.cod_credito = pagamentos_credito.cod_credito and pagamentos_credito.id_filial = credito_pacote.id_filial " &
            "where lancamentos_cliente.cod_cliente = " & codcliente &
            " And lancamentos_cliente.cod_filial_cliente = " & filial & " and lancamentos.data_recebimento is null and cod_status_lancamento =  1"
        '"and lancamentos.data_vencimento < " & d.Pdt(Now)
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function

    Public Function retorna_acordo(ByVal codcliente As Integer, ByVal filial As Integer) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select cliente_acordo.cod_acordo, status_acordo.status_acordo from cliente_acordo inner join status_acordo " &
            " on cliente_acordo.status_acordo = status_acordo.cod_status_acordo " &
            "where cod_cliente = " & codcliente & " And cod_filial_cliente = " & filial & ""
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function


    'Rotina responsável por atualizar o status do pedido na tabela pedido_fornecedor
    Public Sub atualiza_status_lancamentos(ByVal codlanc As Integer, ByVal idfilial As Integer, ByVal status As Integer)
        strSQL = "update lancamentos set cod_status_lancamento = " & status & " where cod_lancamento = " & codlanc & " and id_filial = " & idfilial
        Dim cmd As New SqlCommand(strSQL, d.con)
        d.conecta()
        Try
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Rotina responsável por atualizar o status do pedido na tabela pedido_fornecedor
    Public Sub atualiza_status_lancamentos_temp(ByVal codlanc As Integer, ByVal idfilial As Integer, ByVal status As Integer, ByVal codfatura As Integer)
        strSQL = "update lancamentos set cod_status_lancamento = " & status & ", cod_fatura = " & codfatura & " where cod_lancamento = " & codlanc & " and id_filial = " & idfilial
        Dim cmd As New SqlCommand(strSQL, d.con)
        d.conecta()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Função responsável por retornar o nome do cliente vinculado ao acordo.
    'Foi feito dessa maneira, pois não é possível fazer uma conciliação das informações do banco de dados.
    Public Function retornaNomeClienteAcordo(ByVal codacordo As Integer) As String
        Dim resultado As String
        Dim strSQL As String = "select cliente.nome_cliente from cliente inner join cliente_acordo " &
            "on cliente.cod_cliente = cliente_acordo.cod_cliente where cliente_acordo.cod_acordo = " & codacordo
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Função responsável por retornar o nome do cliente vinculado ao acordo.
    'Foi feito dessa maneira, pois não é possível fazer uma conciliação das informações do banco de dados.
    Public Function retornaCodigoClienteAcordo(ByVal codacordo As Integer) As String
        Dim resultado As String
        Dim strSQL As String = "select cliente.cod_cliente from cliente inner join cliente_acordo " &
            "on cliente.cod_cliente = cliente_acordo.cod_cliente where cliente_acordo.cod_acordo = " & codacordo
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    'Rotina responsável por atualizar o status da forma de pagamento do pedido
    Public Sub atualiza_forma_pagamento_pedido(ByVal forma As Integer, ByVal numpedido As Integer, ByVal idfilial As Integer)
        strSQL = "update pedido_balcao set forma = '" & forma & "' where num_pedido = " & numpedido & " and id_filial = " & idfilial
        Dim cmd As New SqlCommand(strSQL, d.con)
        d.conecta()
        Try
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    'Função responsável por retornar a forma de pagamento do pedido.
    Public Function retornaFormaPagamentoPedido(ByVal numpedido As Integer, ByVal idfilial As Integer) As Integer
        Dim resultado As Integer
        Dim strSQL As String = "select forma from pedido_balcao  where num_pedido = " & numpedido & " and id_filial = " & idfilial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            resultado = cmd.ExecuteScalar()
            Return resultado
        Catch ex As Exception

        Finally
            d.desconecta()
        End Try
    End Function

    Public Sub atualiza_preco_desconto_pedido(ByVal numpedido As Integer, ByVal idfilial As Integer, ByVal desconto As Double, ByVal precotabela As Double)
        Dim strSQL As String = ""
        strSQL = "Update pedido_balcao_itens set desconto = " & desconto.ToString.Replace(",", ".") &
            ", preco = " & precotabela.ToString.Replace(",", ".") &
        " where num_pedido = " & numpedido & " and id_filial = " & idfilial
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub atualiza_preco_desconto_pedido(ByVal numpedido As Integer, ByVal idfilial As Integer, ByVal desconto As Double, ByVal item As Integer, ByVal precotabela As Double)
        Dim strSQL As String = ""
        Dim preco As Double = precotabela - (precotabela * desconto / 100)
        strSQL = "Update pedido_balcao_itens set desconto = " & desconto.ToString.Replace(",", ".") &
                ", preco = " & preco.ToString.Replace(",", ".") &
                " where num_pedido = " & numpedido & " and id_filial = " & idfilial & " and item = " & item
        Dim cmd As New SqlCommand(strSQL, d.con)
        d.ComandoSQL(strSQL, True)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub atualiza_data_fila_exportacao(ByVal inicio As Integer, ByVal fim As Integer)
        Dim strSQL As String = ""
        strSQL = "Update fila_exportacao set data_exportacao = " & d.pdtm(Now()) &
                 " where id_fila >= " & inicio & " and id_fila <= " & fim
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub atualiza_registros(ByVal tabela As String, ByVal instrucaoSQL As String, ByVal exporta As Boolean)
        Dim strSQL As String = ""
        strSQL = "Update " & tabela & " Set " & instrucaoSQL
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            If exporta = True Then
                d.ComandoSQL(strSQL, True)
            End If
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub excluir_registros(ByVal tabela As String, ByVal instrucaoSQL As String, ByVal exporta As Boolean)
        Dim strSQL As String = ""
        strSQL = "Delete From " & tabela & " " & instrucaoSQL
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            If exporta = True Then
                d.ComandoSQL(strSQL, True)
            End If
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub grava_registros(ByVal instrucaoSQL As String, ByVal exporta As Boolean)
        Dim strSQL As String = ""
        strSQL = instrucaoSQL
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            cmd.ExecuteNonQuery()
            If exporta = True Then
                d.ComandoSQL(strSQL, True)
            End If
            d.desconecta()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Function retorna_Baixa_Titulo_Duplicado(ByVal nossonumero As String) As Boolean
        Dim strSQL As String = "SELECT  boleto.Nossonumero , boleto.tipo_documento, lancamentos.data_lancamento,boleto.documento," &
            "(lancamentos.Valor+lancamentos.acrescimo+lancamentos.juros-lancamentos.desconto+lancamentos.taxas) as Valor," &
            "lancamentos.data_vencimento, lancamentos.data_recebimento ,boleto.cod_lancamento, boleto.id_filial," &
            "lancamentos.id_filial_lancamento, lancamentos.n_parcela, cliente.razao_social, cliente.cnpj, cliente.endereco," &
            "cliente.bairro,cliente.municipio, cliente.uf, cliente.cep  FROM boleto INNER JOIN lancamentos ON " &
            "boleto.cod_lancamento = lancamentos.cod_lancamento AND boleto.id_filial = lancamentos.id_filial inner join " &
            "lancamentos_cliente on lancamentos.id_filial = lancamentos_cliente.id_filial And " &
            "lancamentos.cod_lancamento = lancamentos_cliente.cod_lancamento INNER JOIN cliente ON cliente.cod_cliente = lancamentos_cliente.cod_cliente " &
            "where boleto.Nossonumero = '" & nossonumero & "' and lancamentos.cod_status_lancamento = 1 And lancamentos.data_recebimento Is Not null"
        Dim resultado As Boolean = False
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
            Return resultado = True
        Catch ex As Exception
            MessageBox.Show("Erro de conexão de dados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            d.desconecta()
        End Try

        Return resultado
    End Function

    Public Function arredondaValor(ByVal valor As Double, ByVal parcelas As Int32) As Double
        Dim intQuantidadeCasasDecimais As Integer = 2

        Dim intElevado As Double = Math.Pow(10, intQuantidadeCasasDecimais)
        Dim valorParcelas As Double = Math.Truncate(valor / parcelas * intElevado) / intElevado
        Dim valorUltimaParcela As Double = valor - (valorParcelas * (parcelas - 1))
        Return valorUltimaParcela
    End Function

    Public Function retornaProdutos(ByVal codlente As Integer, ByVal codfabricante As Int16) As DataSet
        Dim strSQL As String = "SELECT * FROM PRODUTOS WHERE COD_LENTE = " & codlente & " AND ID_FABRICANTE = " & codfabricante & ""
        Dim ds As New DataSet
        ds.Reset()
        d.conecta()
        Dim da As New SqlDataAdapter(strSQL, d.con)
        da.Fill(ds, "produtos")
        d.desconecta()
        Return ds
    End Function

    Public Function retornaLentes(ByVal codproduto As Integer) As DataSet
        Dim strSQL As String = "SELECT * FROM LENTES WHERE COD_PRODUTO = " & codproduto & ""
        Dim ds As New DataSet
        ds.Reset()
        d.conecta()
        Dim da As New SqlDataAdapter(strSQL, d.con)
        da.Fill(ds, "lentes")
        d.desconecta()
        Return ds
    End Function

    Public Function retornaBloco(ByVal codproduto As Integer) As DataSet
        Dim strSQL As String = "SELECT * FROM BLOCOS WHERE COD_PRODUTO = " & codproduto & ""
        Dim ds As New DataSet
        ds.Reset()
        d.conecta()
        Dim da As New SqlDataAdapter(strSQL, d.con)
        da.Fill(ds, "lentes")
        d.desconecta()
        Return ds
    End Function

    Public Function filtraSaidaOS(ByVal x_cod_os As Integer, ByVal x_id_filial_os As Integer, ByVal x_concluido As String) As Boolean
        Dim strSQL As String
        Dim resultado As Boolean = False
        strSQL = "SELECT movimentomaster.cod_natureza, movimentomaster.data, " &
        "movimentomaster.doc,movimentomaster.concluido, " &
        "movimentomaster.id_usuario, saida_os.cod_movimento, " &
        "saida_os.id_filial,saida_os.id_filial_os, saida_os.cod_os, saida_os.cod_saida_os " &
        "FROM movimentomaster INNER JOIN " &
        "saida_os ON movimentomaster.cod_movimento = saida_os.cod_movimento AND " &
        "movimentomaster.id_filial = saida_os.id_filial " &
        "where saida_os.cod_os = " & x_cod_os &
        " And saida_os.id_filial_os = " & x_id_filial_os &
        " AND (movimentomaster.concluido = '" & x_concluido & "') order by movimentomaster.data Desc"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function existe_saida_os(ByVal x_cod_os As Integer, ByVal x_id_filial As Integer, ByVal x_id_filial_os As Integer) As Boolean
        Dim sql As String
        Dim tb_saida As New DataTable
        sql = "SELECT movimentomaster.cod_natureza, movimentomaster.data, " &
        "movimentomaster.doc, " &
        "movimentomaster.id_usuario, saida_os.cod_movimento, " &
        "saida_os.id_filial,saida_os.id_filial_os, saida_os.cod_os, saida_os.cod_saida_os " &
        "FROM movimentomaster INNER JOIN " &
        "saida_os ON movimentomaster.cod_movimento = saida_os.cod_movimento AND " &
        "movimentomaster.id_filial = saida_os.id_filial " &
        "where saida_os.cod_os = " & x_cod_os & " and saida_os.id_filial = " & x_id_filial &
        " and saida_os.id_filial_os = " & x_id_filial_os & ""
        d.carrega_Tabela(sql, tb_saida)
        If tb_saida.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub inseri_Detalhe_Acordo(ByVal codlanc As Int64, ByVal idfilial As Int16, ByVal codacordo As Integer, ByVal documento As Integer, ByVal doc As String)
        Dim strSQL As String = "insert into cliente_acordo_det (cod_lancamento, id_filial, cod_acordo, documento, tipo_documento) values(" &
            codlanc & "," & idfilial & "," & codacordo & "," & documento & "," & d.PStr(doc) & ")"
        Try
            d.conecta()
            Dim cmd As New SqlCommand(strSQL, d.con)
            cmd.ExecuteNonQuery()
            d.ComandoSQL(strSQL, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Sub

    Public Function filtra_Pacote(ByVal codcli As Integer, ByVal codfilialcli As Integer) As DataTable
        strSQL = "select * from pacote_cliente where cod_cliente = " &
        codcli & " and cod_filial_cliente = " & codfilialcli & ""

        Try
            d.conecta()
            Dim da As New SqlDataAdapter(strSQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try

    End Function

    Public Function filtra_pacote(ByVal codcli As Integer, ByVal codfilialcli As Integer, ByVal codpac As Integer) As DataTable
        strSQL = "select * from pacote_cliente where cod_cliente = " &
        codcli & " and cod_filial_cliente = " & codfilialcli &
        " and cod_pacote = " & codpac & ""

        Try
            d.conecta()
            Dim da As New SqlDataAdapter(strSQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Function

    Public Function filtra_Pacote_Det(ByVal codcli As Integer, ByVal codfilialcli As Integer, ByVal codpac As Integer, ByVal codtab As Integer) As DataTable
        strSQL = "SELECT Pacote_cliente_detalhes.*, " &
        "cliente.nome_cliente, lentes_tabela.nome_comercial, " &
        "lentes_tabela.preco_venda,Pacote_cliente_detalhes.desconto, " &
        "round((lentes_tabela.preco_venda-(lentes_tabela.preco_venda* " &
        "(pacote_cliente_detalhes.desconto/100))),2,2) as Preco_desconto, " &
        "(SELECT     SUM(Contratada - Utilizado) AS saldo " &
        "FROM  saldos_pacotes(pacote_cliente_detalhes.cod_tabela ," &
        "pacote_cliente_detalhes.cod_filial_cliente, pacote_cliente_detalhes.cod_cliente) " &
        "AS saldos WHERE (cod_Pacote = pacote_cliente_detalhes.cod_pacote)) as Saldo, " &
        "(Select produtos.produto from produtos where produtos.cod_produto = " &
        "pacote_cliente_detalhes.cod_surf) as surfacagem, " &
        "isnull(isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = " &
        "pacote_cliente_detalhes.cod_surf),0) - ( " &
        "isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = " &
        "pacote_cliente_detalhes.cod_surf),0)*(pacote_cliente_detalhes.desc_surf/100)),0) " &
        "as surf_desc, " &
        "(Select produtos.produto from produtos where produtos.cod_produto = " &
        "pacote_cliente_detalhes.cod_mont) as montagem, " &
        "isnull(isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = " &
        "pacote_cliente_detalhes.cod_mont),0) " &
        "- ( isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = " &
        "pacote_cliente_detalhes.cod_mont),0)*(pacote_cliente_detalhes.desc_mont/100)),0)" &
        "as mont_desc, " &
        "(Select produtos.produto from produtos where produtos.cod_produto = pacote_cliente_detalhes.cod_trat) as tratamento,isnull( " &
        "isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = pacote_cliente_detalhes.cod_trat),0) " &
        "- ( isnull((Select produtos.preco_venda from produtos where produtos.cod_produto = " &
        "pacote_cliente_detalhes.cod_trat),0)*(pacote_cliente_detalhes.desc_trat/100)),0) as trat_desc, pacote_cliente.data " &
        "FROM  lentes_tabela INNER JOIN cliente INNER JOIN " &
        "Pacote_cliente_detalhes ON cliente.cod_filial_cliente = Pacote_cliente_detalhes.cod_filial_cliente " &
        "AND cliente.cod_cliente = Pacote_cliente_detalhes.cod_cliente ON " &
        "lentes_tabela.cod_tabela = Pacote_cliente_detalhes.cod_tabela " &
        "INNER JOIN pacote_cliente on Pacote_cliente_detalhes.cod_Pacote = pacote_cliente.cod_Pacote " &
        "where pacote_cliente_detalhes.cod_cliente = " & codcli &
        " and pacote_cliente_detalhes.cod_filial_cliente = " & codfilialcli &
        " and pacote_cliente_detalhes.cod_pacote = " & codpac & " and pacote_cliente_detalhes.cod_tabela =  " & codtab & " order by item"
        Try
            d.conecta()
            Dim da As New SqlDataAdapter(strSQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Function

    Public Function filtra_Pacote_Det(ByVal codcli As Integer, ByVal codfilialcli As Integer, ByVal codpac As Integer) As DataTable
        Dim strSQL As String = ""
        strSQL = "SELECT Pacote_cliente_detalhes.*, cliente.nome_cliente, lentes_tabela.nome_comercial, " &
            "(SELECT SUM(Contratada - Utilizado) AS saldo FROM saldos_pacotes(pacote_cliente_detalhes.cod_tabela, " &
            "pacote_cliente_detalhes.cod_filial_cliente, pacote_cliente_detalhes.cod_cliente) AS saldos " &
            "WHERE (cod_Pacote = pacote_cliente_detalhes.cod_pacote)) as Saldo, (Select produtos.produto from produtos " &
            "where produtos.cod_produto = pacote_cliente_detalhes.cod_surf) as surfacagem, (Select produtos.produto " &
            "from produtos where produtos.cod_produto = pacote_cliente_detalhes.cod_mont) as montagem, (Select produtos.produto from " &
            "produtos where produtos.cod_produto = pacote_cliente_detalhes.cod_trat) as tratamento, pacote_cliente.data FROM " &
            "lentes_tabela INNER JOIN cliente INNER JOIN Pacote_cliente_detalhes ON cliente.cod_filial_cliente = Pacote_cliente_detalhes.cod_filial_cliente AND " &
            "cliente.cod_cliente = Pacote_cliente_detalhes.cod_cliente ON lentes_tabela.cod_tabela = Pacote_cliente_detalhes.cod_tabela " &
            "INNER JOIN pacote_cliente on Pacote_cliente_detalhes.cod_Pacote = pacote_cliente.cod_Pacote where pacote_cliente_detalhes.cod_cliente = " & codcli &
            " and pacote_cliente_detalhes.cod_filial_cliente = " & codfilialcli & " and pacote_cliente_detalhes.cod_pacote = " & codpac & " order by item"
        Try
            d.conecta()
            Dim da As New SqlDataAdapter(strSQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Function


    Public Function lista_pacotes(ByVal xCod_cliente As Integer, ByVal xCod_filial_cliente As Integer) As DataTable
        Dim tt As New DataTable
        strSQL = "select * from pacote_cliente where cod_cliente = " &
        xCod_cliente & " and cod_filial_cliente = " & xCod_filial_cliente & " order by cod_pacote desc"
        Try
            d.conecta()
            Dim da As New SqlDataAdapter(strSQL, d.con)
            Dim ds As New DataSet
            da.Fill(ds)
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Function

    'Public Function Total_Pacote(ByVal codcliente As Integer, ByVal codfilialcli As Integer, ByVal codpacote As Integer)
    'Dim sql As String
    'Dim tt As New DataTable
    'sql = "SELECT sum(preco_desc*quantidade_contratada)+ sum(preco_surf_desc*quantidade_surf)+" & _
    ' "sum(preco_mont_desc*quantidade_mont)+sum(preco_trat_desc*quantidade_trat) as total FROM " & _
    ' "Pacote_cliente_detalhes where cod_cliente = " & codcliente & " And cod_filial_cliente = " & codfilialcli & _
    '  " And cod_pacote = " & codpacote
    'Try
    '  d.carrega_Tabela(sql, tt)
    ' If tt.Rows.Count > 0 Then
    ' Return rdNum(tt.Rows(0)("total"))
    ' Else
    '     Return 0
    ' End If
    'Catch ex As Exception
    '   MsgBox(ex.ToString)
    'Finally
    '    d.desconecta()
    'End Try
    'End Function

    'Mostra detalhes do movimento das lentes referetne ao pacote informado na aba Pacote Desconto no cadastro do cliente
    Public Function detalhe_movimento_item(ByVal codpac As Integer, ByVal codtab As Integer) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT pedido_balcao_itens.num_pedido, Pacote_cliente_detalhes.cod_tabela, " &
        "pedido_balcao_itens.id_filial, produtos.produto, pedido_balcao_itens.quant, " &
        "pedido_balcao_itens.preco,pedido_balcao_itens.desconto, " &
        "(pedido_balcao_itens.preco * pedido_balcao_itens.quant) as pDesc," &
        "Pacote_cliente_detalhes.cod_Pacote, pedido_balcao.data_pedido " &
        "FROM Pacote_cliente_detalhes INNER JOIN " &
        "pedido_balcao_itens ON Pacote_cliente_detalhes.cod_Pacote = " &
        "pedido_balcao_itens.cod_pacote " &
        "INNER JOIN produtos ON pedido_balcao_itens.cod_produto = " &
        "produtos.cod_produto INNER JOIN pedido_balcao ON " &
        "pedido_balcao_itens.num_pedido = pedido_balcao.num_pedido AND " &
        "pedido_balcao_itens.id_filial = pedido_balcao.id_filial " &
        "INNER JOIN lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente" &
        " AND produtos.id_fabricante = lentes_blocos.id_fabricante AND " &
        "Pacote_cliente_detalhes.cod_tabela = lentes_blocos.cod_tabela " &
        "where (Pacote_cliente_detalhes.cod_Pacote = " & codpac & ") " &
        " and Pacote_cliente_detalhes.cod_tabela = " & codtab &
        " AND ((pedido_balcao_itens.cod_status_item <> 4) AND " &
        "(pedido_balcao_itens.cod_status_item <> 5)) " &
        "order by data_pedido,num_pedido,pedido_balcao_itens.item"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function


    Public Function resumo_receber_cliente(ByVal codcli As Integer, ByVal codfilialcli As Integer) As DataTable
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select round(receber.Pedidos_nao_faturados,2) as Pedidos," &
        "round(receber.Saldo_faturas,2) as Faturas_aberto, " &
        "round(receber.titulos_atraso,2) as titulos_atraso,round(receber.titulos_a_vencer,2) as titulos_vencer, " &
        "round((receber.titulos_atraso+receber.titulos_a_vencer),2) as titulos_aberto," &
        "round(receber.cheques_a_vencer,2) AS cheques_vencer ,round((receber.Pedidos_nao_faturados + receber.Saldo_faturas " &
        "+receber.titulos_atraso+receber.titulos_a_vencer+receber.cheques_a_vencer+receber.acordo_atrasado),2) " &
        "as total_aberto, round((receber.acordo_atrasado),2) as acordo_atrasado  from resumo_receber() as receber " &
        "where cod_cliente = " & codcli &
        " and cod_filial_cliente = " & codfilialcli & ""
        d.carrega_Tabela(tsql, tt)
        Return tt
    End Function

    Public Function resumo_receber_total_cliente(ByVal codcli As Integer, ByVal codfilialcli As Integer) As String

        Dim tsql As String
        Dim tt As New DataTable
        tsql = "select sum((receber.Pedidos_nao_faturados + receber.Saldo_faturas " &
        "+receber.titulos_atraso+receber.titulos_a_vencer+receber.cheques_a_vencer+receber.acordo_atrasado)) " &
        "as total_aberto   from resumo_receber() as receber " &
        "where cod_cliente = " & codcli &
        " and cod_filial_cliente = " & codfilialcli & ""
        d.carrega_Tabela(tsql, tt)
        Try
            Return cdinShow(tt.Rows(0)(0))
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function retornaFormaPagCli(ByVal codcli As Integer, ByVal codfilialcli As Integer) As Integer
        Dim strSQLForma As String = "SELECT TIPO_COMPRA FROM CLIENTE WHERE COD_CLIENTE = " & codcli &
        " AND COD_FILIAL_CLIENTE = " & codfilialcli
        Dim ttFormaPag As New DataTable
        ttFormaPag = retornaRegistro(strSQLForma).Tables(0)
        Return ttFormaPag.Rows(0)("Tipo_Compra")
    End Function



    'Verifica desconto na tabela promocional
    Public Function desconto_tabela_promocional(ByVal x_cod_tabela As Integer, ByVal xdi As Date, ByVal xdf As Date, ByVal x_Fil_cliente As Integer, ByVal x_cod_cliente As Integer) As Double
        Dim tsql As String
        Dim tt As New DataTable
        tsql = "SELECT tabela_promocional_itens.desconto " &
        "FROM tabela_promocional INNER JOIN tabela_promocional_clientes ON " &
        "tabela_promocional.cod_tabela_promocional = tabela_promocional_clientes.cod_tabela_promocional AND " &
        "tabela_promocional.id_filial = tabela_promocional_clientes.id_filial INNER JOIN " &
        "tabela_promocional_itens ON tabela_promocional.cod_tabela_promocional = " &
        "tabela_promocional_itens.cod_tabela_promocional AND " &
        "tabela_promocional.id_filial = tabela_promocional_itens.id_filial " &
        "WHERE (tabela_promocional_clientes.cod_cliente = " & x_cod_cliente & ") AND " &
        "(tabela_promocional_clientes.cod_filial_cliente = " & x_Fil_cliente & ") AND " &
        "(tabela_promocional.data_inicio <= " & d.pdtm(xdi) & ") AND " &
        "(tabela_promocional.data_termino >= " & d.pdtm(xdf) &
        ") AND (tabela_promocional_itens.cod_tabela = " & x_cod_tabela & ")"
        d.carrega_Tabela(tsql, tt)
        If tt.Rows.Count = 0 Then
            Return 0
        Else
            Return rdNum(tt.Rows(0)(0))
        End If
    End Function

    'Indica se o tipo é L = Lente ou B = Bloco
    Public Function tipo(ByVal x_cod_tabela As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select especie from lentes_tabela where cod_tabela = " & x_cod_tabela &
        ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 1 Then
            Return tt.Rows(0)("especie")
        Else
            Return ""
        End If
    End Function

    Public Function saldo_estoque(ByVal codprod As Integer, ByVal idfilial As Int16) As Integer
        Dim intTotal As Integer
        Dim strSQL As String = "select ISNULL(SUM(movimento.quant),0) as saldo from movimento where cod_produto = " & codprod & " and id_filial = " & idfilial
        Dim tt As New DataTable
        tt = retornaRegistro(strSQL).Tables(0)
        intTotal = tt.Rows(0)("saldo")
        Return intTotal
    End Function

    Public Function lista_itens_com_saldo_pacote(ByVal x_tabela As Integer, ByVal codcliente As Integer, ByVal codfilialcli As Integer) As DataTable
        Dim tt As New DataTable
        Dim strSQL As String = "SELECT Pacote_cliente_detalhes.*, " &
        "cliente.nome_cliente, lentes_tabela.nome_comercial, " &
        "lentes_tabela.preco_venda,Pacote_cliente_detalhes.desconto, " &
        "(lentes_tabela.preco_venda-(lentes_tabela.preco_venda* " &
        "(pacote_cliente_detalhes.desconto/100))) as Preco_desconto, " &
        "(SELECT     SUM(Contratada - Utilizado) AS saldo " &
        "FROM  saldos_pacotes(pacote_cliente_detalhes.cod_tabela ," &
        "pacote_cliente_detalhes.cod_filial_cliente, pacote_cliente_detalhes.cod_cliente) " &
        "AS saldos WHERE (cod_Pacote = pacote_cliente_detalhes.cod_pacote)) as Saldo " &
        "FROM  lentes_tabela INNER JOIN cliente INNER JOIN " &
        "Pacote_cliente_detalhes ON cliente.cod_filial_cliente = Pacote_cliente_detalhes.cod_filial_cliente " &
        "AND cliente.cod_cliente = Pacote_cliente_detalhes.cod_cliente ON " &
        "lentes_tabela.cod_tabela = Pacote_cliente_detalhes.cod_tabela " &
        "where pacote_cliente_detalhes.cod_cliente = " & codcliente &
        " and pacote_cliente_detalhes.cod_filial_cliente = " & codfilialcli &
        " and pacote_cliente_detalhes.cod_tabela = " & x_tabela &
        " and (SELECT     SUM(Contratada - Utilizado) AS saldo " &
        "FROM  saldos_pacotes(pacote_cliente_detalhes.cod_tabela ," &
        "pacote_cliente_detalhes.cod_filial_cliente, pacote_cliente_detalhes.cod_cliente) " &
        "AS saldos WHERE (cod_Pacote = pacote_cliente_detalhes.cod_pacote)) > 0 " &
        "and Pacote_cliente_detalhes.status_item  = 'L' " &
        "order by pacote_cliente_detalhes.cod_pacote"
        tt = retornaRegistro(strSQL).Tables(0)
        Return tt
    End Function

    ''''teste valida
    Function ValidaIE(pUF, pInscr) As Boolean
        Dim ChecaInscrE As Boolean = False
        Dim strBase
        Dim strBase2
        Dim strOrigem
        Dim strDigito1
        Dim strDigito2
        Dim intPos
        Dim intValor
        Dim intSoma As Integer
        Dim intResto
        Dim intNumero
        Dim intPeso
        Dim intDig
        strBase = ""
        strBase2 = ""
        strOrigem = ""

        If Trim(pInscr) = "ISENTO" Or Trim(pInscr) = "EX" Then
            ChecaInscrE = True
            Exit Function
        End If
        For intPos = 1 To Len(Trim(pInscr))
            If InStr(1, "0123456789P", Mid(pInscr, intPos, 1), vbTextCompare) > 0 Then
                strOrigem = strOrigem & Mid(pInscr, intPos, 1)
            End If
        Next

        Select Case pUF
            Case "PA"
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                If Left(strBase, 2) = "15" Then
                    intSoma = 0
                    For intPos = 1 To 8
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * (10 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intResto = intSoma Mod 11
                    strDigito1 = Right(IIf(intResto < 2, "0", CStr(11 - intResto)), 1)
                    strBase2 = Left(strBase, 8) & strDigito1
                    If strBase2 = strOrigem Then
                        ChecaInscrE = True
                    End If
                End If

            Case "AP"
                strBase = Left(Trim(strOrigem) & "000000000", 9)
                intPeso = 0
                intDig = 0
                If Left(strBase, 2) = "03" Then
                    intNumero = Fix(Left(strBase, 8))
                    If intNumero >= 3000001 And intNumero <= 3017000 Then
                        intPeso = 5
                        intDig = 0
                    ElseIf intNumero >= 3017001 And intNumero <= 3019022 Then
                        intPeso = 9
                        intDig = 1
                    ElseIf intNumero >= 3019023 Then
                        intPeso = 0
                        intDig = 0
                    End If
                    intSoma = intPeso
                    For intPos = 1 To 8
                        intValor = CInt(Mid(strBase, intPos, 1))
                        intValor = intValor * (10 - intPos)
                        intSoma = intSoma + intValor
                    Next
                    intResto = intSoma Mod 11
                    intValor = 11 - intResto
                    If intValor = 10 Then
                        intValor = 0
                    ElseIf intValor = 11 Then
                        intValor = intDig
                    End If
                    strDigito1 = Right(CStr(intValor), 1)
                    strBase2 = Left(strBase, 8) & strDigito1
                    If strBase2 = strOrigem Then
                        ChecaInscrE = True
                    End If
                End If

        End Select

        Return ChecaInscrE
    End Function

    Public Function lista_itens(ByVal idfilial As Integer, ByVal movimento As Integer) As DataTable
        Dim strSQL As String
        Dim tb_lista As New DataTable
        strSQL = "SELECT * FROM movimento " &
        " WHERE (id_filial = " & idfilial & ") AND " &
        "(cod_Movimento = " & movimento & ") and status = 0"
        d.carrega_Tabela(strSQL, tb_lista)
        Return tb_lista
        tb_lista.Dispose()
    End Function

    Public Function filtrar_devolucao(ByVal x_cod_devolucao_os As Integer, ByVal x_id_filial As Integer) As DataTable
        Dim tt As New DataTable
        Dim strSQL As String = "SELECT movimentomaster.cod_natureza, movimentomaster.data, movimentomaster.doc," &
                "movimentomaster.id_usuario, devolucao_Estoque_OS.cod_movimento, " &
                "devolucao_Estoque_OS.id_filial, devolucao_Estoque_OS.cod_os, " &
                "devolucao_Estoque_OS.id_filial_os, devolucao_Estoque_OS.cod_devolucao_os " &
                "FROM movimentomaster INNER JOIN devolucao_Estoque_OS ON " &
                "movimentomaster.cod_movimento = devolucao_Estoque_OS.cod_movimento AND " &
                "movimentomaster.id_filial = devolucao_Estoque_OS.id_filial " &
                "where devolucao_Estoque_OS.cod_devolucao_os = " & x_cod_devolucao_os &
                " and devolucao_Estoque_OS.id_filial = " & x_id_filial & ""
        d.carrega_Tabela(strSQL, tt)
        Return tt
    End Function

    'Função responsável por verificar se o tipo de usuário já está vinculado a algum usuário
    Public Function tem_produto(ByVal x_cod_prod As Integer, ByVal x_cod_movimento As Integer, ByVal x_id_filial As Integer) As Boolean
        Dim resultado As Boolean
        resultado = False
        Dim strSQL As String = "SELECT cod_produto, cod_Movimento, id_filial, status " &
        "FROM movimento WHERE (cod_Movimento = " & x_cod_movimento &
        ") AND (id_filial = " & x_id_filial & ") AND (cod_produto = " &
        x_cod_prod & ") AND (status = 0)"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
            Return resultado
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try
    End Function

    Public Function total_pacote(ByVal codcliente As Integer, ByVal filialcliente As Integer, ByVal codpacote As Integer) As Double
        Dim strSQL As String = "select isnull(SUM(preco_desc * quantidade_contratada),0) + ISNULL(SUM(preco_surf_desc * quantidade_surf),0) + " &
            "ISNULL(sum(preco_mont_desc * quantidade_mont),0) + isnull(SUM(preco_trat_desc * quantidade_trat),0) as total_pacote " &
            "from Pacote_cliente_detalhes where cod_pacote = " & codpacote & " And cod_cliente = " & codcliente & " And cod_filial_cliente = " & filialcliente
        Dim tbValor As New DataTable
        tbValor = retornaRegistro(strSQL).Tables(0)

        Return tbValor.Rows(0)("total_pacote")
    End Function

    Public Function total_pacote_pago(ByVal codcliente As Integer, ByVal filialcliente As Integer, ByVal codpacote As Integer) As Double
        Dim strSQL As String = "select isnull(SUM(valor),0) as total_pacote_pago from lancamentos inner join lancamentos_cliente on " &
            "lancamentos.cod_lancamento = lancamentos_cliente.cod_lancamento and lancamentos.id_filial = lancamentos_cliente.id_filial " &
            "inner join pagamentos_credito on lancamentos.cod_lancamento = pagamentos_credito.cod_lancamento " &
            "and lancamentos.id_filial = pagamentos_credito.id_filial inner join credito_pacote on " &
            "pagamentos_credito.cod_credito = credito_pacote.cod_credito and pagamentos_credito.id_filial = credito_pacote.id_filial " &
            "where lancamentos_cliente.cod_cliente = " & codcliente & " And lancamentos_cliente.cod_filial_cliente = " & filialcliente &
            " And credito_pacote.cod_pacote = " & codpacote
        Dim tbValor As New DataTable
        tbValor = retornaRegistro(strSQL).Tables(0)

        Return tbValor.Rows(0)("total_pacote_pago")
    End Function

    Public Function Saldo_anterior(ByVal codcliente As Integer, ByVal codfilialcliente As Integer) As Double
        Dim strSQL As String = "SELECT SUM(credito) AS saldo FROM credito_cliente WHERE  cod_cliente = " & codcliente &
        " AND cod_filial_cliente = " & codfilialcliente & ""
        Try
            Dim tbSaldo As New DataTable
            tbSaldo = retornaRegistro(strSQL).Tables(0)
            Return tbSaldo.Rows(0)("saldo")
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function retornaCodigoTabela(ByVal codprodutos) As Integer
        Dim strSQL As String = "select lentes_blocos.cod_tabela from lentes_blocos inner join lentes_tabela  on " &
            "lentes_blocos.cod_tabela = lentes_tabela.cod_tabela and lentes_blocos.cod_tipo_lente = lentes_tabela.cod_tipo_lente " &
            "inner join produtos on lentes_blocos.cod_lente = produtos.cod_lente where produtos.cod_produto = " & codprodutos
        Dim tbRegistro As New DataTable
        Dim intCodigo As Integer
        tbRegistro = retornaRegistro(strSQL).Tables(0)
        If tbRegistro.Rows.Count > 0 Then
            intCodigo = tbRegistro.Rows(0)("cod_tabela")
            Return intCodigo
        End If
    End Function


    'Função responsável por retornar o calculo de diametro para a lente
    Public Function calculaDiametro(ByVal AroHorizontal As Double, ByVal ponte As Double, ByVal dnp As Double, ByVal maiorDiametro As Double) As Double
        Dim db As Double
        db = (AroHorizontal + maiorDiametro + ponte) - (2 * dnp) + 2
        Return db
    End Function

    'Função responsável por validar a DNP para longe da lente
    Public Function validaDNP_longe(ByVal valor As Object, ByRef ctlDnpPerto As System.Windows.Forms.Control, ByVal tipo As Integer) As Boolean
        Dim resultado As Boolean = False
        If tipo = tipo_Receita.VISAO_simples_perto And valor = Nothing Then
            resultado = True
        End If
        If IsNumeric(valor) = True Then
            If valor < 0 Then
                resultado = False
                Exit Function
            End If
            If (CDbl(valor) Mod 0.5) > 0 Then
                resultado = False
                Exit Function
            End If
            If tipo = tipo_Receita.BIFOCAL Or tipo = tipo_Receita.PROGRESSIVA Then
                ctlDnpPerto.Text = CDbl(valor) - 2.5
            End If
            resultado = True
        Else
            resultado = False
        End If

        Return resultado
    End Function

    'Função responsável por validar a DNP para perto da lente
    Public Function valida_DNP_Perto(ByVal valor As Object, ByVal tipo As Integer) As Boolean
        If tipo = tipo_Receita.VISAO_simples_longe And valor = Nothing Then
            Return True
        End If
        If IsNumeric(valor) = True Then
            If valor < 0 Then
                Return False
            End If
            If (CDbl(valor) Mod 0.5) > 0 Then
                Return False
                Exit Function
            End If
            'If tipo = tipo_Receita.BIFOCAL Or tipo = tipo_Receita.PROGRESSIVA Then
            'ctlDnpPerto.Text = CDbl(valor) - 2.5
            'End If
            Return True
        Else
            Return False
        End If

    End Function

    'Função responsável por validar adição e adicionar o Esferico de Perto
    Public Function Valida_adicao(ByVal adicao As Object, ByVal esf As Object, ByVal cil As Object, ByRef ctlEsfPerto As System.Windows.Forms.Control, ByRef ctlCilPerto As System.Windows.Forms.Control, ByVal tipo As Integer) As String
        'se adição estiver vazia os campos esférico e cilíndrico serão limpados
        If adicao = Nothing Then
            ctlEsfPerto.Text = Nothing
            ctlCilPerto.Text = Nothing
            Return "OK!"
        End If

        'Se a adição for um valor numerico e não negativo a instrução será executado
        If IsNumeric(adicao) = True And Not CDbl(adicao) < 0 Then
            If (adicao Mod 0.25) > 0 Then
                Return "ER!Valor Incorreto!"
                Exit Function
            End If
            If esf = Nothing Then
                Return "ER!Esferico não informado!"
                Exit Function
            End If
            If tipo = tipo_Receita.PROGRESSIVA Or tipo = tipo_Receita.BIFOCAL Then
                ctlEsfPerto.Text = CDbl(esf) + CDbl(adicao)
                ctlCilPerto.Text = cil
            End If
            Return "OK!"
        Else
            Return "ER!Valor Incorreto!"
        End If
    End Function

    Public Function valida_Esf_Longe(ByVal esf As Object, ByVal ad As Object, ByVal ci As Object, ByRef ctlEsfPerto As Windows.Forms.TextBox, ByRef ctlCilPerto As Windows.Forms.TextBox, ByVal tipo As Integer) As Boolean
        Dim resultado As Boolean = False

        If tipo = tipo_Receita.VISAO_simples_perto Then
            resultado = False
        End If

        If IsNumeric(esf) = False Then
            resultado = False
        Else
            If esf < 0 Then
                If (-1 * (CDbl(esf) Mod 0.25)) > 0 Then
                    resultado = False
                    Exit Function
                End If
            Else
                If (CDbl(esf) Mod 0.25) > 0 Then
                    resultado = False
                    Exit Function
                End If
            End If
            If Not ad = Nothing Then
                Valida_adicao(ad, esf, ci, ctlEsfPerto, ctlCilPerto, tipo)
            End If
            resultado = True
        End If
        Return resultado
    End Function


    Public Function valida_cil_longe(ByVal ci As Object, ByVal ad As Object, ByVal esf As Object, ByRef ctlEsfPerto As System.Windows.Forms.Control, ByRef ctlCilPerto As System.Windows.Forms.Control, ByVal tipo As Integer, ByRef ctlEixo As System.Windows.Forms.Control) As Boolean
        If ci = Nothing Then
            Return False
        End If
        If IsNumeric(ci) = False Then
            Return False
        Else
            If ci = 0 Then
                ctlEixo.Enabled = False
            Else
                ctlEixo.Enabled = True
            End If
            If ci > 0 Then
                Return False
            End If
            If (-1 * (CDbl(ci) Mod 0.25)) > 0 Then
                Return False
            End If
        End If
        If Not ad = Nothing Then
            Valida_adicao(ad, esf, ci, ctlEsfPerto, ctlCilPerto, tipo)
        End If
        Return True
    End Function

    Public Function valida_valor_numerico(ByVal valor As Object, ByVal negativo As Boolean) As Boolean
        If IsNumeric(valor) Then
            If CDbl(valor) < 0 And negativo = False Then
                Return False
                Exit Function
            End If
            Return True
        End If
    End Function

    Public Function retorna_especie(ByVal x_cod_prod As Integer) As String
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT lentes_tabela.cod_tabela, lentes_tabela.especie " &
        "FROM produtos INNER JOIN lentes_blocos ON produtos.cod_lente = " &
        "lentes_blocos.cod_lente AND produtos.id_fabricante = " &
        "lentes_blocos.id_fabricante INNER JOIN " &
        "lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela " &
        "WHERE     (produtos.cod_produto = " & x_cod_prod & ")"
        d.carrega_Tabela(sql, tt)
        Try
            Return tt.Rows(0)("especie")
        Catch ex As Exception

        End Try
    End Function

    Public Function tem_bloco(ByVal intCodigo As Integer) As Boolean
        Dim tem As Boolean = False
        'Avalia se o olho direito é bloco
        Try
            If retorna_especie(intCodigo).Trim = "B" Then
                tem = True
            End If
            Return tem
        Catch ex As Exception

        End Try
    End Function

    'Função responsável por carregar o conteúdo de um arquivo seja no formato txt ou xml
    Public Function carregaArquivo(ByVal caminhoArq As String) As String
        Dim arquivo As New System.IO.FileStream(caminhoArq, IO.FileMode.Open) 'Abre o aquivo para leitura
        Dim objLerArquivo As New System.IO.StreamReader(arquivo) 'Ler o conteúdo do arquivo aberto
        Dim strLinha As String = ""
        Dim strTexto As String = ""

        'Verifica se o arquivo contem alguma linha ainda a ser pecorrida
        Do While objLerArquivo.Peek <> -1
            strLinha = strLinha & objLerArquivo.ReadLine & vbNewLine
        Loop

        strTexto = strLinha 'Passa o conteúdo para a variável strTexto

        objLerArquivo.Close() 'Fecha o objeto
        objLerArquivo.Dispose() 'Libera o objeto da memória
        arquivo.Close() 'Fecha o objeto
        arquivo.Dispose() 'Libera o objeto da memória

        Return strTexto
    End Function

    'Procedimento responsável por criar arquivo tanto no formato txt ou xml
    Public Sub criaArquivo(ByVal caminhoArq As String, ByVal textoArq As String)
        Dim arquivo As New System.IO.FileStream(caminhoArq, IO.FileMode.OpenOrCreate) 'Cria o arquivo especificado
        Dim texto As New System.IO.StreamWriter(arquivo) 'Abre o arquivo apra gravação de dados
        texto.WriteLine(textoArq) 'Escreve o conteúdo dentro do arquivo

        texto.Close() 'Fecha o objeto
        texto.Dispose() 'Libera o objeto da memória
        arquivo.Close() 'Fecha o objeto
        arquivo.Dispose() 'Libera o objeto da memória
    End Sub

    Public Function VerificaExistenciaRegistro(ByVal strComando As String) As Boolean
        Dim resultado As Boolean
        resultado = False
        Dim cmd As New SqlCommand(strComando, d.con)
        Try
            d.conecta()
            Dim obj As Object
            obj = cmd.ExecuteScalar
            resultado = (obj <> Nothing)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            d.desconecta()
        End Try

        Return resultado
    End Function

    Public Sub LimpaControle(ByVal controle As Control)
        For Each ctl As Control In controle.Controls
            If TypeOf ctl Is TextBox Then
                DirectCast(ctl, TextBox).Text = String.Empty
            ElseIf TypeOf ctl Is TreeView Then
                'DirectCast(ctl, TreeNode).CheckBoxes = False
            End If
        Next
    End Sub

    Public Sub LimpaControleTreeView(ByVal controle As TreeView)
        For Each item As TreeNode In controle.Nodes(0).Nodes
            If TypeOf item Is TreeNode Then item.Checked = False
        Next
    End Sub

    Public Sub AtivaControle(ByVal controle As Control)
        For Each ctl As Control In controle.Controls
            If TypeOf ctl Is TextBox Then
                DirectCast(ctl, TextBox).CharacterCasing = CharacterCasing.Upper
                ctl.Enabled = True
            End If

            If TypeOf ctl Is TreeView Then ctl.Enabled = True

            If ctl.Controls.Count > 0 Then
                AtivaControle(ctl)
            End If
        Next
    End Sub

    Public Sub DesativaControle(ByVal controle As Control)
        For Each ctl As Control In controle.Controls
            If TypeOf ctl Is TextBox Then ctl.Enabled = False
            If TypeOf ctl Is TreeView Then ctl.Enabled = False

            If ctl.Controls.Count > 0 Then
                AtivaControle(ctl)
            End If
        Next
    End Sub

    Public Function RetornaChave(ByVal campo As String, ByVal tabela As String, ByVal criterio As String) As Long
        Dim tb As New DataTable
        Dim sql As String
        Dim v As Long
        Try
            sql = "Select max(" & campo & ") as chave from " & tabela & " " & criterio
            d.carrega_Tabela(sql, tb)
            If tb.Rows.Count = 0 Then
                v = 1
                Exit Function
            End If
            If IsDBNull(tb.Rows(0)("chave")) = True Then v = 0 Else v = tb.Rows(0)("chave")
            v = v + 1
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        tb.Dispose()

        Return v
    End Function

    Public Sub AcaoBotaoNovo(ByVal controle As ToolStrip)
        For Each ctl As ToolStripItem In controle.Items
            Select Case ctl.Name
                Case "btnNovo"
                    ctl.Enabled = False
                Case "btnEditar"
                    ctl.Enabled = False
                Case "btnExcluir"
                    ctl.Enabled = False
                Case "btnSalvar"
                    ctl.Enabled = True
                Case "btnCancelar"
                    ctl.Enabled = True
                Case "btnSair"
                    ctl.Enabled = False
            End Select
        Next
    End Sub

    Public Sub AcaoBotaoEditar(ByVal controle As ToolStrip)
        For Each ctl As ToolStripItem In controle.Items
            Select Case ctl.Name
                Case "btnNovo"
                    ctl.Enabled = False
                Case "btnEditar"
                    ctl.Enabled = False
                Case "btnExcluir"
                    ctl.Enabled = True
                Case "btnSalvar"
                    ctl.Enabled = True
                Case "btnCancelar"
                    ctl.Enabled = True
                Case "btnSair"
                    ctl.Enabled = False
            End Select
        Next
    End Sub

    Public Sub AcaoBotaoExcluir(ByVal controle As ToolStrip)
        For Each ctl As ToolStripItem In controle.Items
            Select Case ctl.Name
                Case "btnNovo"
                    ctl.Enabled = True
                Case "btnEditar"
                    ctl.Enabled = True
                Case "btnExcluir"
                    ctl.Enabled = False
                Case "btnSalvar"
                    ctl.Enabled = False
                Case "btnCancelar"
                    ctl.Enabled = False
                Case "btnSair"
                    ctl.Enabled = True
            End Select
        Next
    End Sub

    Public Sub AcaoBotaoSalvar(ByVal controle As ToolStrip)
        For Each ctl As ToolStripItem In controle.Items
            Select Case ctl.Name
                Case "btnNovo"
                    ctl.Enabled = True
                Case "btnEditar"
                    ctl.Enabled = True
                Case "btnExcluir"
                    ctl.Enabled = False
                Case "btnSalvar"
                    ctl.Enabled = False
                Case "btnCancelar"
                    ctl.Enabled = False
                Case "btnSair"
                    ctl.Enabled = True
            End Select
        Next
    End Sub

    Public Sub AcaoBotaoCancelar(ByVal controle As ToolStrip)
        For Each ctl As ToolStripItem In controle.Items
            Select Case ctl.Name
                Case "btnNovo"
                    ctl.Enabled = True
                Case "btnEditar"
                    ctl.Enabled = True
                Case "btnExcluir"
                    ctl.Enabled = False
                Case "btnSalvar"
                    ctl.Enabled = False
                Case "btnCancelar"
                    ctl.Enabled = False
                Case "btnSair"
                    ctl.Enabled = True
            End Select
        Next
    End Sub

#End Region

End Class
