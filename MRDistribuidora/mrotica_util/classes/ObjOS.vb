Public Class ObjOS
    'CONSIDERAÇÕES CÁLCULO  
    'Se Perto só visão Simples.
    'Se Longe quando visão simples não tem adição se tiver adição,
    'mostrar grau Perto somando adição.
    'Se hipermetrope considerar apenas esférico.
    'Se miope, considerar Cilindrico.
    'Se Cilíndrico, exigir eixo. 
    'A miopia corrige-se com uma lente divergente (côncava), 
    'A hipermetropia corrige-se com uma lente convergente (convexa).
#Region "Atributos"
    Private _id_filial As Integer
    Private _cod_os As Integer
    Private _num_pedido As Object
    Private _cod_tab_od As Integer
    Private _cod_tab_oe As Integer
    Private _cod_produto_od As Long
    Private _cod_produto_oe As Long
    Private _esf_od_longe As Object
    Private _cil_od_longe As Object
    Private _esf_od_perto As Object
    Private _cil_od_perto As Object
    Private _dnp_od_longe As Object 'dnp_perto + 2,5
    Private _dnp_od_perto As Object 'dnp_longe - 2,5
    Private _base_od As Object
    Private _adicao_od As Object
    Private _altura_od As Object
    Private _diametro_od As Object
    Private _eixo_od As Object
    Private _esf_oe_longe As Object
    Private _cil_oe_longe As Object
    Private _esf_oe_perto As Object
    Private _cil_oe_perto As Object
    Private _dnp_oe_longe As Object 'dnp_perto + 2,5
    Private _dnp_oe_perto As Object 'dnp_longe - 2,5
    Private _base_oe As Object
    Private _adicao_oe As Object
    Private _altura_oe As Object
    Private _diametro_oe As Object
    Private _eixo_oe As Object
    Private _aro_horizontal As Object
    Private _aro_vertical As Object
    Private _maior_diametro As Object
    Private _ponte As Object
    Private _cod_Tipo_Armacao As Integer
    Private _crm_oftalmologista As Object
    Private _cod_filial_cliente As Integer
    Private _cod_cliente As Integer
    Private _data_venda As Object
    Private _data_previsao_entrega As Object
    Private _hora_previsao_entrega As String
    Private _cod_vendedora As Integer
    Private _cod_qfez As Integer
    Private _observacao As String
    Private _nota_serie As String
    Private _cod_verif_por As Integer
    Private _data_verificacao As Object
    Private _doc_cliente As Object
    Private _cod_surfacagem As Object
    Private _cod_montagem As Object
    Private _confeccao As String
    Private _coloracao As Object
    Private _cor_coloracao As String
    Private _data_recebimento As Object
    Private _data_fim_servico As Object
    Private _cod_fase As Integer 'Identifica a fase em que a OS se encontra
    Private _tipo_receita_OD As Integer 'Identifica o tipo da Receita em Unifocal Perto,Unifocal longe, bifocal e Progressiva.
    Private _tipo_receita_OE As Integer
    Private _id_laboratorio As Integer
    Private _cod_lab_surf As Integer
    Private _cod_tipo_os As Integer

    Public posicao As Integer = 0
    Public max As Integer
    Public CriterioOS, criterioFilial As Object
    Public tb As New DataTable
    Public OrigemSalvar As String = ""
    Private lastPos As Integer = 0
    Private sql As String
    Dim d As New dados
    Dim loja As Integer = 1
    Dim tempRow As Data.DataRow
    Dim andamentos As New objAndamentos(d)
    Dim prod As New produtoClass(d)
    Dim conf As config
    Dim osMaster As New objMaster
#End Region
#Region "GET SET"
    Public Property id_filial() As Integer
        Get
            id_filial = _id_filial
        End Get
        Set(ByVal Value As Integer)
            _id_filial = Value
        End Set
    End Property
    Public Property cod_os() As Integer
        Get
            cod_os = _cod_os
        End Get
        Set(ByVal Value As Integer)
            _cod_os = Value
        End Set
    End Property
    Public Property num_pedido() As Object
        Get
            num_pedido = _num_pedido
        End Get
        Set(ByVal Value As Object)
            _num_pedido = Value
        End Set
    End Property
    Public Property cod_tab_od() As Integer
        Get
            cod_tab_od = _cod_tab_od
        End Get
        Set(ByVal Value As Integer)
            _cod_tab_od = Value
        End Set
    End Property
    Public Property cod_tab_oe() As Integer
        Get
            cod_tab_oe = _cod_tab_oe
        End Get
        Set(ByVal Value As Integer)
            _cod_tab_oe = Value
        End Set
    End Property
    Public Property cod_produto_od() As Long
        Get
            cod_produto_od = _cod_produto_od
        End Get
        Set(ByVal Value As Long)
            _cod_produto_od = Value
        End Set
    End Property
    Public Property cod_produto_oe() As Long
        Get
            cod_produto_oe = _cod_produto_oe
        End Get
        Set(ByVal Value As Long)
            _cod_produto_oe = Value
        End Set
    End Property
    Public Property esf_od_longe() As Object
        Get
            esf_od_longe = _esf_od_longe
        End Get
        Set(ByVal Value As Object)
            _esf_od_longe = Value
        End Set
    End Property
    Public Property cil_od_longe() As Object
        Get
            cil_od_longe = _cil_od_longe
        End Get
        Set(ByVal Value As Object)
            _cil_od_longe = Value
        End Set
    End Property
    Public Property esf_od_perto() As Object
        Get
            esf_od_perto = _esf_od_perto
        End Get
        Set(ByVal Value As Object)
            _esf_od_perto = Value
        End Set
    End Property
    Public Property cil_od_perto() As Object
        Get
            cil_od_perto = _cil_od_perto
        End Get
        Set(ByVal Value As Object)
            _cil_od_perto = Value
        End Set
    End Property
    Public Property dnp_od_longe() As Object
        Get
            dnp_od_longe = _dnp_od_longe
        End Get
        Set(ByVal Value As Object)
            _dnp_od_longe = Value
        End Set
    End Property
    Public Property dnp_od_perto() As Object
        Get
            dnp_od_perto = _dnp_od_perto
        End Get
        Set(ByVal Value As Object)
            _dnp_od_perto = Value
        End Set
    End Property
    Public Property base_od() As Object
        Get
            base_od = _base_od
        End Get
        Set(ByVal Value As Object)
            _base_od = Value
        End Set
    End Property
    Public Property adicao_od() As Object
        Get
            adicao_od = _adicao_od
        End Get
        Set(ByVal Value As Object)
            _adicao_od = Value
        End Set
    End Property
    Public Property altura_od() As Object
        Get
            altura_od = _altura_od
        End Get
        Set(ByVal Value As Object)
            _altura_od = Value
        End Set
    End Property
    Public Property diametro_od() As Object
        Get
            diametro_od = _diametro_od
        End Get
        Set(ByVal Value As Object)
            _diametro_od = Value
        End Set
    End Property
    Public Property eixo_od() As Object
        Get
            eixo_od = _eixo_od
        End Get
        Set(ByVal Value As Object)
            _eixo_od = Value
        End Set
    End Property
    Public Property esf_oe_longe() As Object
        Get
            esf_oe_longe = _esf_oe_longe
        End Get
        Set(ByVal Value As Object)
            _esf_oe_longe = Value
        End Set
    End Property
    Public Property cil_oe_longe() As Object
        Get
            cil_oe_longe = _cil_oe_longe
        End Get
        Set(ByVal Value As Object)
            _cil_oe_longe = Value
        End Set
    End Property
    Public Property esf_oe_perto() As Object
        Get
            esf_oe_perto = _esf_oe_perto
        End Get
        Set(ByVal Value As Object)
            _esf_oe_perto = Value
        End Set
    End Property
    Public Property cil_oe_perto() As Object
        Get
            cil_oe_perto = _cil_oe_perto
        End Get
        Set(ByVal Value As Object)
            _cil_oe_perto = Value
        End Set
    End Property
    Public Property dnp_oe_longe() As Object
        Get
            dnp_oe_longe = _dnp_oe_longe
        End Get
        Set(ByVal Value As Object)
            _dnp_oe_longe = Value
        End Set
    End Property
    Public Property dnp_oe_perto() As Object
        Get
            dnp_oe_perto = _dnp_oe_perto
        End Get
        Set(ByVal Value As Object)
            _dnp_oe_perto = Value
        End Set
    End Property
    Public Property base_oe() As Object
        Get
            base_oe = _base_oe
        End Get
        Set(ByVal Value As Object)
            _base_oe = Value
        End Set
    End Property
    Public Property adicao_oe() As Object
        Get
            adicao_oe = _adicao_oe
        End Get
        Set(ByVal Value As Object)
            _adicao_oe = Value
        End Set
    End Property
    Public Property altura_oe() As Object
        Get
            altura_oe = _altura_oe
        End Get
        Set(ByVal Value As Object)
            _altura_oe = Value
        End Set
    End Property
    Public Property diametro_oe() As Object
        Get
            diametro_oe = _diametro_oe
        End Get
        Set(ByVal Value As Object)
            _diametro_oe = Value
        End Set
    End Property
    Public Property eixo_oe() As Object
        Get
            eixo_oe = _eixo_oe
        End Get
        Set(ByVal Value As Object)
            _eixo_oe = Value
        End Set
    End Property
    Public Property aro_horizontal() As Object
        Get
            aro_horizontal = _aro_horizontal
        End Get
        Set(ByVal Value As Object)
            _aro_horizontal = Value
        End Set
    End Property
    Public Property aro_vertical() As Object
        Get
            aro_vertical = _aro_vertical
        End Get
        Set(ByVal Value As Object)
            _aro_vertical = Value
        End Set
    End Property
    Public Property maior_diametro() As Double
        Get
            maior_diametro = _maior_diametro
        End Get
        Set(ByVal Value As Double)
            _maior_diametro = Value
        End Set
    End Property
    Public Property ponte() As Double
        Get
            ponte = _ponte
        End Get
        Set(ByVal Value As Double)
            _ponte = Value
        End Set
    End Property
    Public Property cod_tipo_armacao() As Integer
        Get
            cod_tipo_armacao = _cod_Tipo_Armacao
        End Get
        Set(ByVal Value As Integer)
            _cod_Tipo_Armacao = Value
        End Set
    End Property
    Public Property crm_oftalmologista() As Integer
        Get
            crm_oftalmologista = _crm_oftalmologista
        End Get
        Set(ByVal Value As Integer)
            _crm_oftalmologista = Value
        End Set
    End Property
    Public Property cod_filial_cliente() As Integer
        Get
            cod_filial_cliente = _cod_filial_cliente
        End Get
        Set(ByVal Value As Integer)
            _cod_filial_cliente = Value
        End Set
    End Property
    Public Property cod_cliente() As Integer
        Get
            cod_cliente = _cod_cliente
        End Get
        Set(ByVal Value As Integer)
            _cod_cliente = Value
        End Set
    End Property
    Public Property data_venda()
        Get
            data_venda = _data_venda
        End Get
        Set(ByVal Value)
            _data_venda = Value
        End Set
    End Property
    Public Property data_previsao_entrega()
        Get
            data_previsao_entrega = _data_previsao_entrega
        End Get
        Set(ByVal Value)
            _data_previsao_entrega = Value
        End Set
    End Property
    Public Property hora_previsao_entrega() As String
        Get
            hora_previsao_entrega = _hora_previsao_entrega
        End Get
        Set(ByVal Value As String)
            _hora_previsao_entrega = Value
        End Set
    End Property
    Public Property cod_vendedora() As Integer
        Get
            cod_vendedora = _cod_vendedora
        End Get
        Set(ByVal Value As Integer)
            _cod_vendedora = Value
        End Set
    End Property
    Public Property cod_qfez() As Integer
        Get
            cod_qfez = _cod_qfez
        End Get
        Set(ByVal Value As Integer)
            _cod_qfez = Value
        End Set
    End Property
    Public Property observacao() As String
        Get
            observacao = _observacao
        End Get
        Set(ByVal Value As String)
            _observacao = Value
        End Set
    End Property
    Public Property nota_serie() As String
        Get
            nota_serie = _nota_serie
        End Get
        Set(ByVal Value As String)
            _nota_serie = Value
        End Set
    End Property
    Public Property cod_verif_por() As Integer
        Get
            cod_verif_por = _cod_verif_por
        End Get
        Set(ByVal Value As Integer)
            _cod_verif_por = Value
        End Set
    End Property
    Public Property data_verificacao() As Date
        Get
            data_verificacao = _data_verificacao
        End Get
        Set(ByVal Value As Date)
            _data_verificacao = Value
        End Set
    End Property
    Public Property cod_surfacagem()
        Get
            cod_surfacagem = _cod_surfacagem
        End Get
        Set(ByVal Value)
            _cod_surfacagem = Value
        End Set
    End Property
    Public Property cod_montagem()
        Get
            cod_montagem = _cod_montagem
        End Get
        Set(ByVal Value)
            _cod_montagem = Value
        End Set
    End Property
    Public Property confeccao() As String
        Get
            confeccao = _confeccao
        End Get
        Set(ByVal Value As String)
            _confeccao = Value
        End Set
    End Property
    Public Property coloracao()
        Get
            coloracao = _coloracao
        End Get
        Set(ByVal Value)
            _coloracao = Value
        End Set
    End Property
    Public Property cor_coloracao() As String
        Get
            cor_coloracao = _cor_coloracao
        End Get
        Set(ByVal Value As String)
            _cor_coloracao = Value
        End Set
    End Property
    Public Property data_recebimento()
        Get
            data_recebimento = _data_recebimento
        End Get
        Set(ByVal Value)
            _data_recebimento = Value
        End Set
    End Property
    Public Property data_fim_servico()
        Get
            data_fim_servico = _data_fim_servico
        End Get
        Set(ByVal Value)
            _data_fim_servico = Value
        End Set
    End Property
    Public Property doc_cliente()
        Get
            doc_cliente = _doc_cliente
        End Get
        Set(ByVal Value)
            _doc_cliente = Value
        End Set
    End Property
    Public Property cod_fase() As Integer
        Get
            cod_fase = _cod_fase
        End Get
        Set(ByVal Value As Integer)
            _cod_fase = Value
        End Set
    End Property
    Public Property tipo_receita_OD() As Integer
        Get
            tipo_receita_OD = _tipo_receita_OD
        End Get
        Set(ByVal Value As Integer)
            _tipo_receita_OD = Value
        End Set
    End Property
    Public Property tipo_receita_OE() As Integer
        Get
            tipo_receita_OE = _tipo_receita_OE
        End Get
        Set(ByVal Value As Integer)
            _tipo_receita_OE = Value
        End Set
    End Property
    Public Property id_laboratorio() As Integer
        Get
            id_laboratorio = _id_laboratorio
        End Get
        Set(ByVal Value As Integer)
            _id_laboratorio = Value
        End Set
    End Property
    Public Property cod_lab_surf() As Integer
        Get
            cod_lab_surf = _cod_lab_surf
        End Get
        Set(ByVal Value As Integer)
            _cod_lab_surf = Value
        End Set
    End Property
    Public Property cod_tipo_os As Integer
        Get
            cod_tipo_os = _cod_tipo_os
        End Get
        Set(ByVal value As Integer)
            _cod_tipo_os = value
        End Set
    End Property

#End Region
#Region "Procedimentos"
    Public Sub New()
        conf = New config
        loja = conf.Filial
        sql = "Select * from OS " & _
        "where cod_os = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal xdados As dados, ByVal xloja As Integer, ByVal O As String)
        d = xdados
        loja = xloja
        andamentos = New objAndamentos(d)
        prod = New produtoClass(d)
        sql = "Select * from OS " & _
       "where cod_os = 0"
        Source(sql)
    End Sub
    Public Sub New(ByVal os As Integer, ByVal filial As Integer, ByVal xDADos As dados)
        d = xDADos
        andamentos = New objAndamentos(d)
        prod = New produtoClass(d)
        sql = "Select * from OS " & _
        "where cod_os = " & os & " and id_filial = " & filial & ""
        Source(sql)
        Me.primeiro()
    End Sub
    Public Sub New(ByVal os As Integer, ByVal filial As Integer)
        sql = "Select * from OS " & _
        "where cod_os = " & os & " and id_filial = " & filial & ""
        Source(sql)
        Me.primeiro()
    End Sub
    Public Sub New(ByVal os_cliente As Integer, ByVal filial As Integer, ByVal o As String)
        sql = "Select * from OS " & _
        "where doc_cliente = " & os_cliente & " and cod_cliente = " & filial & ""
        Source(sql)
        Me.primeiro()
    End Sub
    Public Sub New(ByVal os_cliente As Integer, ByVal filial As Integer, ByVal o As String, ByVal xdados As dados)
        d = xdados
        andamentos = New objAndamentos(d)
        prod = New produtoClass(d)
        sql = "Select * from OS " & _
        "where doc_cliente = " & os_cliente & " and cod_cliente = " & filial & ""
        Source(sql)
        Me.primeiro()
    End Sub
    Public Function Source(ByVal iSql As String) As String
        sql = iSql
        Return Me.refreshData()
    End Function
    Public Function refreshData() As String
        Dim res As String
        res = d.carrega_Tabela(sql, tb)
        max = tb.Rows.Count
        primeiro()
        Return res
    End Function
    Public Sub Registro(ByVal pos As Integer) 'Move o Registro para a posição indicada
        Dim p As Integer = pos
        If p <= 0 Then p = 0
        If p > max Then p = max
        posicao = p
        If max > 0 Then
            _id_filial = tb.Rows(pos)("id_filial")
            _cod_os = tb.Rows(pos)("cod_os")
            _num_pedido = rdNum(tb.Rows(pos)("num_pedido"))
            _cod_tab_od = rdNum(tb.Rows(pos)("cod_tab_od"))
            _cod_tab_oe = rdNum(tb.Rows(pos)("cod_tab_oe"))
            _cod_produto_od = rdNum(tb.Rows(pos)("cod_produto_od"))
            _cod_produto_oe = rdNum(tb.Rows(pos)("cod_produto_oe"))

            _esf_od_longe = rdNum(tb.Rows(pos)("esf_od_longe"))
            _cil_od_longe = rdNum(tb.Rows(pos)("cil_od_longe"))
            _esf_od_perto = rdNum(tb.Rows(pos)("esf_od_perto"))
            _cil_od_perto = rdNum(tb.Rows(pos)("cil_od_perto"))
            _dnp_od_longe = rdNum(tb.Rows(pos)("dnp_od_longe"))
            _dnp_od_perto = rdNum(tb.Rows(pos)("dnp_od_perto"))
            _base_od = rdNum(tb.Rows(pos)("base_od"))
            _adicao_od = rdNum(tb.Rows(pos)("adicao_od"))
            _altura_od = rdNum(tb.Rows(pos)("altura_od"))
            _diametro_od = rdNum(tb.Rows(pos)("diametro_od"))
            _eixo_od = rdNum(tb.Rows(pos)("eixo_od"))

            _esf_oe_longe = rdNum(tb.Rows(pos)("esf_oe_longe"))
            _cil_oe_longe = rdNum(tb.Rows(pos)("cil_oe_longe"))
            _esf_oe_perto = rdNum(tb.Rows(pos)("esf_oe_perto"))
            _cil_oe_perto = rdNum(tb.Rows(pos)("cil_oe_perto"))
            _dnp_oe_longe = rdNum(tb.Rows(pos)("dnp_oe_longe"))
            _dnp_oe_perto = rdNum(tb.Rows(pos)("dnp_oe_perto"))
            _base_oe = rdNum(tb.Rows(pos)("base_oe"))
            _adicao_oe = rdNum(tb.Rows(pos)("adicao_oe"))
            _altura_oe = rdNum(tb.Rows(pos)("altura_oe"))
            _diametro_oe = rdNum(tb.Rows(pos)("diametro_oe"))
            _eixo_oe = rdNum(tb.Rows(pos)("eixo_oe"))

            _aro_horizontal = rdNum(tb.Rows(pos)("aro_horizontal"))
            _aro_vertical = rdNum(tb.Rows(pos)("aro_vertical"))
            _maior_diametro = rdNum(tb.Rows(pos)("maior_diametro"))
            _ponte = rdNum(tb.Rows(pos)("ponte"))
            _cod_Tipo_Armacao = rdNum(tb.Rows(pos)("cod_tipo_armacao"))
            _crm_oftalmologista = rdNum(tb.Rows(pos)("crm_oftalmologista"))
            _cod_filial_cliente = rdNum(tb.Rows(pos)("cod_filial_cliente"))
            _cod_cliente = rdNum(tb.Rows(pos)("cod_cliente"))
            _data_venda = rdData(tb.Rows(pos)("data_venda"))
            _data_previsao_entrega = rdData(tb.Rows(pos)("data_previsao_entrega"))
            _hora_previsao_entrega = rdTexto(tb.Rows(pos)("hora_previsao_entrega"))
            _cod_vendedora = rdNum(tb.Rows(pos)("cod_vendedora"))
            _cod_qfez = rdNum(tb.Rows(pos)("cod_qfez"))
            _observacao = rdTexto(tb.Rows(pos)("observacao"))
            _nota_serie = rdTexto(tb.Rows(pos)("nota_serie"))
            _cod_verif_por = rdNum(tb.Rows(pos)("cod_verif_por"))
            _data_verificacao = rdData(tb.Rows(pos)("data_verificacao"))
            _doc_cliente = rdTexto(tb.Rows(pos)("doc_cliente"))

            _cod_surfacagem = rdNum(tb.Rows(pos)("cod_surfacagem"))
            _cod_montagem = rdNum(tb.Rows(pos)("cod_montagem"))
            _confeccao = rdTexto(tb.Rows(pos)("confeccao"))
            _coloracao = rdNum(tb.Rows(pos)("coloracao"))
            _cor_coloracao = rdTexto(tb.Rows(pos)("cor_coloracao"))
            _data_recebimento = rdData(tb.Rows(pos)("data_recebimento"))
            _data_fim_servico = rdData(tb.Rows(pos)("data_fim_servico"))
            _cod_fase = rdNum(tb.Rows(pos)("cod_fase"))
            _tipo_receita_OD = rdNum(tb.Rows(pos)("tipo_receita_od"))
            _tipo_receita_OE = rdNum(tb.Rows(pos)("tipo_receita_oe"))
            _id_laboratorio = rdNum(tb.Rows(pos)("id_laboratorio"))
            _cod_lab_surf = rdNum(tb.Rows(pos)("cod_lab_surf"))
            _cod_tipo_os = rdNum(tb.Rows(pos)("cod_tipo_os"))

        End If
    End Sub
    Public Sub proximo()
        If Me.posicao = Me.max - 1 Then Exit Sub
        Me.Registro(Me.posicao + 1)
    End Sub
    Public Function filtra_os_cliente(ByVal x_cod_cliente As Integer, ByVal x_doc_cliente As String) As String
        Dim sql As String
        Dim res As String
        sql = "Select * from OS " & _
        "where cod_cliente = " & x_cod_cliente & _
        " and doc_cliente = " & x_doc_cliente & ""
        res = Source(sql)
        primeiro()
        Return res
    End Function
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
    Public Sub editar()
        OrigemSalvar = "Editar"
        CriterioOS = cod_os
        criterioFilial = id_filial
        tempRow = tb.Rows(posicao)
    End Sub

#End Region
#Region "Funções"
    Public Sub novo()
        lastPos = posicao 'guarda a posição do último Registro
        'Zera Variáveis
        _id_filial = Nothing
        _cod_os = Nothing
        _num_pedido = Nothing
        _cod_tab_od = Nothing
        _cod_tab_oe = Nothing
        _cod_produto_od = Nothing
        _cod_produto_oe = Nothing
        _esf_od_longe = Nothing
        _cil_od_longe = Nothing
        _esf_od_perto = Nothing
        _cil_od_perto = Nothing
        _dnp_od_longe = Nothing
        _dnp_od_perto = Nothing
        _base_od = Nothing
        _adicao_od = Nothing
        _altura_od = Nothing
        _diametro_od = Nothing
        _eixo_od = Nothing
        _esf_oe_longe = Nothing
        _cil_oe_longe = Nothing
        _esf_oe_perto = Nothing
        _cil_oe_perto = Nothing
        _dnp_oe_longe = Nothing
        _dnp_oe_perto = Nothing
        _base_oe = Nothing
        _adicao_oe = Nothing
        _altura_oe = Nothing
        _diametro_oe = Nothing
        _eixo_oe = Nothing
        _aro_horizontal = Nothing
        _aro_vertical = Nothing
        _maior_diametro = Nothing
        _ponte = Nothing
        _cod_Tipo_Armacao = Nothing
        _crm_oftalmologista = Nothing
        _cod_filial_cliente = Nothing
        _cod_cliente = Nothing
        _data_venda = Nothing
        _data_previsao_entrega = Nothing
        _hora_previsao_entrega = Nothing
        _cod_vendedora = Nothing
        _cod_qfez = Nothing
        _observacao = Nothing
        _nota_serie = Nothing
        _cod_verif_por = Nothing
        _data_verificacao = Nothing
        _cod_surfacagem = Nothing
        _cod_montagem = Nothing
        _confeccao = Nothing
        _coloracao = Nothing
        _cor_coloracao = Nothing
        _data_recebimento = Nothing
        _data_fim_servico = Nothing
        _cod_fase = 1
        _tipo_receita_OD = Nothing
        _tipo_receita_OE = Nothing
        _id_laboratorio = Nothing
        _cod_tipo_os = 1
        OrigemSalvar = "Novo" 'Define o tipo de ação ao salvar
    End Sub
    Public Function n_os() As Integer
        Dim tsql As String
        Dim tt As New DataTable
        Dim n As Integer = 0
        Dim res As String
inicio:
        tsql = "Select * from num_os where id_filial = " & _id_filial & " "
        d.carrega_Tabela(tsql, tt)
        If tt.Rows(0)("lock") = 1 Then
            GoTo inicio
        Else
            Try
                If d.Comando("Update num_os set lock = 1 where id_filial = " & _id_filial, False).StartsWith("OK") Then
                    n = tt.Rows(0)("cod_os") + 1
                    res = d.Comando("Update num_os set cod_os = " & n & ", lock = 0 where id_filial = " & _id_filial, False)
                    If res.StartsWith("OK") Then
                        Return n
                    End If
                End If
            Catch ex As Exception
                GoTo inicio
            End Try
        End If
    End Function
    Public Function n_pedido() As Integer
        Dim tsql As String
        Dim tt As New DataTable
        Dim n As Integer = 0
        Dim res As String
inicio:
        tsql = "Select * from num_pedido where id_filial = " & _id_filial & " "
        d.carrega_Tabela(tsql, tt)
        If tt.Rows(0)("lock") = 1 Then
            GoTo inicio
        Else
            Try
                If d.Comando("Update num_pedido set lock = 1 where id_filial = " & _id_filial, False).StartsWith("OK") Then
                    n = tt.Rows(0)("num_pedido") + 1
                    res = d.Comando("Update num_pedido set num_pedido = " & n & ", lock = 0 where id_filial = " & _id_filial, False)
                    If res.StartsWith("OK") Then
                        Return n
                    End If
                End If
            Catch ex As Exception
                GoTo inicio
            End Try
        End If
    End Function
    Public Function Salvar() As String
        Dim sql As String
        Dim res As String 'Resposta da inserção de registros
        d.conecta()
        If OrigemSalvar = "Novo" Then
            Try
                _cod_os = n_os()
                If _num_pedido = Nothing Then _num_pedido = n_pedido()
                sql = "Insert into OS(" & _
                "id_filial,cod_os,num_pedido,cod_tab_od,cod_tab_oe," & _
                "cod_produto_od,cod_produto_oe,esf_od_longe,cil_od_longe," & _
                "esf_od_perto,cil_od_perto,dnp_od_longe,dnp_od_perto,base_od," & _
                "adicao_od,altura_od,diametro_od,eixo_od,esf_oe_longe,cil_oe_longe," & _
                "esf_oe_perto,cil_oe_perto,dnp_oe_longe,dnp_oe_perto,base_oe," & _
                "adicao_oe,altura_oe,diametro_oe,eixo_oe,aro_horizontal,aro_vertical," & _
                "maior_diametro,ponte,cod_Tipo_Armacao,crm_oftalmologista," & _
                "cod_filial_cliente,cod_cliente,data_venda,data_previsao_entrega," & _
                "hora_previsao_entrega,cod_vendedora,cod_qfez,observacao,nota_serie," & _
                "cod_verif_por,data_verificacao,cod_surfacagem,cod_montagem,confeccao,coloracao," & _
                "cor_coloracao,data_recebimento,data_fim_servico,cod_fase,tipo_receita_od," & _
                "tipo_receita_oe, id_laboratorio,doc_cliente,cod_lab_surf,cod_tipo_os) values(" & _
                _id_filial & "," & _cod_os & "," & d.cdin(_num_pedido) & "," & _
                d.cdin(cod_tab_od) & "," & d.cdin(_cod_tab_oe) & "," & _
                _cod_produto_od & "," & _cod_produto_oe & "," & _
                d.cdin(_esf_od_longe) & "," & d.cdin(_cil_od_longe) & "," & _
                d.cdin(_esf_od_perto) & "," & d.cdin(_cil_od_perto) & "," & _
                d.cdin(_dnp_od_longe) & "," & d.cdin(_dnp_od_perto) & "," & _
                d.cdin(_base_od) & "," & d.cdin(_adicao_od) & "," & _
                d.cdin(_altura_od) & "," & d.cdin(_diametro_od) & "," & _
                d.cdin(_eixo_od) & "," & d.cdin(_esf_oe_longe) & "," & _
                d.cdin(_cil_oe_longe) & "," & d.cdin(_esf_oe_perto) & "," & _
                d.cdin(_cil_oe_perto) & "," & d.cdin(_dnp_oe_longe) & "," & _
                d.cdin(_dnp_oe_perto) & "," & d.cdin(_base_oe) & "," & _
                d.cdin(_adicao_oe) & "," & d.cdin(_altura_oe) & "," & _
                d.cdin(_diametro_oe) & "," & d.cdin(_eixo_oe) & "," & _
                d.cdin(_aro_horizontal) & "," & d.cdin(_aro_vertical) & "," & _
                d.cdin(_maior_diametro) & "," & d.cdin(_ponte) & "," & _
                d.cdin(_cod_Tipo_Armacao) & "," & d.cdin(_crm_oftalmologista) & "," & _
                d.cdin(_cod_filial_cliente) & "," & d.cdin(_cod_cliente) & "," & _
                d.Pdt(_data_venda) & "," & d.Pdt(_data_previsao_entrega) & "," & _
                d.PStr(_hora_previsao_entrega) & "," & d.cdin(_cod_vendedora) & "," & _
                d.cdin(_cod_qfez) & "," & d.PStr(_observacao) & "," & _
                d.PStr(_nota_serie) & "," & d.cdin(_cod_verif_por) & "," & _
                d.Pdt(_data_verificacao) & "," & d.cdin(_cod_surfacagem) & "," & _
                d.cdin(_cod_montagem) & "," & _
                d.PStr(_confeccao) & "," & d.PStr(_coloracao) & "," & _
                d.PStr(_cor_coloracao) & "," & d.Pdt(_data_recebimento) & "," & _
                d.Pdt(_data_fim_servico) & "," & d.cdin(_cod_fase) & "," & _
                d.cdin(_tipo_receita_OD) & "," & d.cdin(_tipo_receita_OE) & _
                "," & d.cdin(_id_laboratorio) & _
                "," & d.PStr(_doc_cliente) & "," & d.cdin(_cod_lab_surf) & _
                "," & _cod_tipo_os & ")"
                res = d.Comando(sql, True)
            Catch ex As Exception
                Return "ER:" & ex.ToString & vbCrLf & sql & vbCrLf & _
                "cod_pd_od" & _cod_produto_od
                'Retorna o prefixo ER: para indicar erro e a descrição do erro
                Registro(lastPos)
                Exit Function
            End Try
            Dim r As DataRow
            r = tb.NewRow
            r("id_filial") = _id_filial
            r("cod_os") = _cod_os
            r("num_pedido") = wrNum(_num_pedido)
            r("cod_tab_od") = wrNum(_cod_tab_od)
            r("cod_tab_oe") = wrNum(_cod_tab_oe)
            r("cod_produto_od") = wrNum(_cod_produto_od)
            r("cod_produto_oe") = wrNum(_cod_produto_oe)
            r("esf_od_longe") = wrNum(_esf_od_longe)
            r("cil_od_longe") = wrNum(_cil_od_longe)
            r("esf_od_perto") = wrNum(_esf_od_perto)
            r("cil_od_perto") = wrNum(_cil_od_perto)
            r("dnp_od_longe") = wrNum(_dnp_od_longe) 'dnp_perto + 2,5
            r("dnp_od_perto") = wrNum(_dnp_od_perto) 'dnp_longe - 2,5
            r("base_od") = wrNum(_base_od)
            r("adicao_od") = wrNum(_adicao_od)
            r("altura_od") = wrNum(_altura_od)
            r("diametro_od") = wrNum(_diametro_od)
            r("diametro_oe") = wrNum(_diametro_oe)
            r("eixo_od") = wrNum(_eixo_od)
            r("esf_oe_longe") = wrNum(_esf_oe_longe)
            r("cil_oe_longe") = wrNum(_cil_oe_longe)
            r("esf_oe_perto") = wrNum(_esf_oe_perto)
            r("cil_oe_perto") = wrNum(_cil_oe_perto)
            r("dnp_oe_longe") = wrNum(_dnp_oe_longe) 'dnp_perto + 2,5
            r("dnp_oe_perto") = wrNum(_dnp_oe_perto)  'dnp_longe - 2,5
            r("base_oe") = wrNum(_base_oe)
            r("adicao_oe") = wrNum(_adicao_oe)
            r("altura_oe") = wrNum(_altura_oe)
            r("diametro_oe") = wrNum(_diametro_oe)
            r("eixo_oe") = wrNum(_eixo_oe)
            r("aro_horizontal") = wrNum(_aro_horizontal)
            r("aro_vertical") = wrNum(_aro_vertical)
            r("maior_diametro") = wrNum(_maior_diametro)
            r("ponte") = wrNum(_ponte)
            r("cod_tipo_armacao") = wrNum(_cod_Tipo_Armacao)
            r("crm_oftalmologista") = wrNum(_crm_oftalmologista)
            r("cod_filial_cliente") = wrNum(_cod_filial_cliente)
            r("cod_cliente") = wrNum(_cod_cliente)
            r("Data_venda") = wrData(_data_venda)
            r("data_previsao_entrega") = wrData(_data_previsao_entrega)
            r("hora_previsao_entrega") = _hora_previsao_entrega
            r("cod_vendedora") = wrNum(_cod_vendedora)
            r("cod_qfez") = wrNum(_cod_qfez)
            r("observacao") = _observacao
            r("nota_serie") = _nota_serie
            r("cod_verif_por") = wrNum(_cod_verif_por)
            r("data_verificacao") = wrData(_data_verificacao)
            r("cod_surfacagem") = wrNum(_cod_surfacagem)
            r("cod_montagem") = wrNum(_cod_surfacagem)
            r("confeccao") = _confeccao
            r("coloracao") = wrNum(_coloracao)
            r("cor_coloracao") = _cor_coloracao
            r("data_recebimento") = wrData(_data_recebimento)
            r("data_fim_servico") = wrData(_data_fim_servico)
            r("cod_fase") = _cod_fase
            r("tipo_receita_od") = wrNum(_tipo_receita_OD)
            r("tipo_receita_oe") = wrNum(_tipo_receita_OE)
            r("id_laboratorio") = wrNum(_tipo_receita_OE)
            r("doc_cliente") = wrNum(_doc_cliente)
            r("cod_lab_surf") = wrNum(_cod_lab_surf)
            r("cod_tipo_os") = wrNum(_cod_tipo_os)
            tb.Rows.Add(r)
            max = max + 1
            If max = 1 Then
                posicao = 0
            Else
                posicao = max - 1
            End If
            OrigemSalvar = ""
            Return res & " adicionado(s) com sucesso!"
        End If
        If Me.OrigemSalvar = "Editar" Then
            Try
                'If row_editado.StartsWith("ER") Then
                'OrigemSalvar = ""
                'res = 0
                'Return "OK: " & " Não houve alteração do(s) registro(s)!"
                'Exit Function
                'End If
                sql = "Update OS set " & _
                "num_pedido =" & d.cdin(_num_pedido) & ",cod_tab_od = " & _
                d.cdin(_cod_tab_od) & ",cod_tab_oe = " & d.cdin(_cod_tab_oe) & _
                ",cod_produto_od = " & d.cdin(_cod_produto_od) & _
                ",cod_produto_oe = " & d.cdin(_cod_produto_oe) & _
                ",esf_od_longe = " & d.cdin(_esf_od_longe) & _
                ",cil_od_longe = " & d.cdin(_cil_od_longe) & _
                ",esf_od_perto = " & d.cdin(_esf_od_perto) & _
                ",cil_od_perto = " & d.cdin(_cil_od_perto) & _
                ",dnp_od_longe = " & d.cdin(_dnp_od_longe) & _
                ",dnp_od_perto = " & d.cdin(_dnp_od_perto) & _
                ",base_od = " & d.cdin(_base_od) & _
                ",adicao_od = " & d.cdin(_adicao_od) & _
                ", altura_od = " & d.cdin(_altura_od) & _
                ",diametro_od = " & d.cdin(_diametro_od) & _
                ",eixo_od = " & d.cdin(_eixo_od) & _
                ",esf_oe_longe = " & d.cdin(_esf_oe_longe) & _
                ",cil_oe_longe = " & d.cdin(_cil_oe_longe) & _
                ",esf_oe_perto = " & d.cdin(_esf_oe_perto) & _
                ",cil_oe_perto = " & d.cdin(_cil_oe_perto) & _
                ",dnp_oe_longe = " & d.cdin(_dnp_oe_longe) & _
                ",dnp_oe_perto = " & d.cdin(_dnp_oe_perto) & _
                ",base_oe = " & d.cdin(_base_oe) & _
                ",adicao_oe = " & d.cdin(_adicao_oe) & _
                ",altura_oe = " & d.cdin(_altura_oe) & _
                ",diametro_oe = " & d.cdin(_diametro_oe) & _
                ",eixo_oe = " & d.cdin(_eixo_oe) & _
                ",aro_horizontal = " & d.cdin(_aro_horizontal) & _
                ",aro_vertical = " & d.cdin(_aro_vertical) & _
                ",maior_diametro = " & d.cdin(_maior_diametro) & _
                ",ponte = " & d.cdin(_ponte) & _
                ", cod_tipo_armacao = " & d.cdin(_cod_Tipo_Armacao) & _
                ", crm_oftalmologista = " & d.cdin(_crm_oftalmologista) & _
                ", cod_filial_cliente = " & d.cdin(_cod_filial_cliente) & _
                ", cod_cliente = " & d.cdin(_cod_cliente) & _
                ", data_venda = " & d.Pdt(_data_venda) & _
                ", data_previsao_entrega = " & d.pdtm(_data_previsao_entrega) & _
                ", hora_previsao_entrega = " & d.PStr(_hora_previsao_entrega) & _
                ", cod_vendedora = " & d.cdin(_cod_vendedora) & _
                ", cod_qfez = " & d.cdin(_cod_qfez) & _
                ", observacao = " & d.PStr(_observacao) & _
                ", nota_serie = " & d.PStr(_nota_serie) & _
                ", cod_verif_por = " & d.cdin(_cod_verif_por) & _
                ", data_verificacao = " & d.pdtm(_data_verificacao) & _
                ", cod_surfacagem =" & d.cdin(_cod_surfacagem) & _
                ", cod_montagem =" & d.cdin(_cod_montagem) & _
                ", confeccao = " & d.PStr(_confeccao) & _
                ", coloracao = " & d.cdin(_coloracao) & _
                ", cor_coloracao = " & d.PStr(_cor_coloracao) & _
                ", data_recebimento = " & d.pdtm(_data_recebimento) & _
                ", data_fim_servico = " & d.pdtm(_data_fim_servico) & _
                ", cod_fase = " & d.cdin(_cod_fase) & _
                ", tipo_receita_od = " & d.cdin(_tipo_receita_OD) & _
                ", tipo_receita_oe = " & d.cdin(_tipo_receita_OE) & _
                ", id_laboratorio = " & d.cdin(_id_laboratorio) & _
                ", doc_cliente = " & d.PStr(_doc_cliente) & _
                ", cod_lab_surf = " & d.cdin(_cod_lab_surf) & _
                ", cod_tipo_os = " & _cod_tipo_os & _
                " where " & _
                "id_filial = " & Me._id_filial & " and cod_os = " & _
                Me._cod_os & ""
                res = d.Comando(sql, True)
            Catch ex As Exception

            End Try
            Dim r As DataRow
            r = tb.Rows(posicao)
            r("num_pedido") = wrNum(_num_pedido)
            r("cod_tab_od") = wrNum(_cod_tab_od)
            r("cod_tab_oe") = wrNum(_cod_tab_oe)
            r("cod_produto_od") = wrNum(_cod_produto_od)
            r("cod_produto_oe") = wrNum(_cod_produto_oe)
            r("esf_od_longe") = wrNum(_esf_od_longe)
            r("cil_od_longe") = wrNum(_cil_od_longe)
            r("esf_od_perto") = wrNum(_esf_od_perto)
            r("cil_od_perto") = wrNum(_cil_od_perto)
            r("dnp_od_longe") = wrNum(_dnp_od_longe) 'dnp_perto + 2,5
            r("dnp_od_perto") = wrNum(_dnp_od_perto) 'dnp_longe - 2,5
            r("base_od") = wrNum(_base_od)
            r("adicao_od") = wrNum(_adicao_od)
            r("altura_od") = wrNum(_altura_od)
            r("diametro_od") = wrNum(_diametro_od)
            r("diametro_oe") = wrNum(_diametro_oe)
            r("eixo_od") = wrNum(_eixo_od)
            r("esf_oe_longe") = wrNum(_esf_oe_longe)
            r("cil_oe_longe") = wrNum(_cil_oe_longe)
            r("esf_oe_perto") = wrNum(_esf_oe_perto)
            r("cil_oe_perto") = wrNum(_cil_oe_perto)
            r("dnp_oe_longe") = wrNum(_dnp_oe_longe) 'dnp_perto + 2,5
            r("dnp_oe_perto") = wrNum(_dnp_oe_perto)  'dnp_longe - 2,5
            r("base_oe") = wrNum(_base_oe)
            r("adicao_oe") = wrNum(_adicao_oe)
            r("altura_oe") = wrNum(_altura_oe)
            r("diametro_oe") = wrNum(_diametro_oe)
            r("eixo_oe") = wrNum(_eixo_oe)
            r("aro_horizontal") = wrNum(_aro_horizontal)
            r("aro_vertical") = wrNum(_aro_vertical)
            r("maior_diametro") = wrNum(_maior_diametro)
            r("ponte") = wrNum(_ponte)
            r("cod_tipo_armacao") = wrNum(_cod_Tipo_Armacao)
            r("crm_oftalmologista") = wrNum(_crm_oftalmologista)
            r("cod_filial_cliente") = wrNum(_cod_filial_cliente)
            r("cod_cliente") = wrNum(_cod_cliente)
            r("Data_venda") = wrData(_data_venda)
            r("data_previsao_entrega") = wrData(_data_previsao_entrega)
            r("hora_previsao_entrega") = _hora_previsao_entrega
            r("cod_vendedora") = wrNum(_cod_vendedora)
            r("cod_qfez") = wrNum(_cod_qfez)
            r("observacao") = _observacao
            r("nota_serie") = _nota_serie
            r("cod_verif_por") = wrNum(_cod_verif_por)
            r("data_verificacao") = wrData(_data_verificacao)
            r("cod_surfacagem") = wrNum(_cod_surfacagem)
            r("cod_montagem") = wrNum(_cod_surfacagem)
            r("confeccao") = _confeccao
            r("coloracao") = wrNum(_coloracao)
            r("cor_coloracao") = _cor_coloracao
            r("data_recebimento") = wrData(_data_recebimento)
            r("data_fim_servico") = wrData(_data_fim_servico)
            r("cod_fase") = _cod_fase
            r("tipo_receita_od") = wrNum(_tipo_receita_OD)
            r("tipo_receita_oe") = wrNum(_tipo_receita_OE)
            r("id_laboratorio") = wrNum(_id_laboratorio)
            r("doc_cliente") = wrNum(_doc_cliente)
            r("cod_lab_surf") = wrNum(_cod_lab_surf)
            r("cod_tipo_os") = wrNum(_cod_tipo_os)
            OrigemSalvar = ""
            Return res & " registro(s) atualizado(s) com sucesso!"
        End If
    End Function
    Public Function Salvar_transaction() As String
        'Retorna a instrução sql para inserir na transaction
        Dim isql As String
        If OrigemSalvar = "Novo" Then
            _cod_os = n_os()
            '_cod_os = d.retorna_Chave("Cod_os", "OS", " where id_filial = " & conf.Filial & "")
            isql = "Insert into OS(" & _
            "id_filial,cod_os,num_pedido,cod_tab_od,cod_tab_oe," & _
            "cod_produto_od,cod_produto_oe,esf_od_longe,cil_od_longe," & _
            "esf_od_perto,cil_od_perto,dnp_od_longe,dnp_od_perto,base_od," & _
            "adicao_od,altura_od,diametro_od,eixo_od,esf_oe_longe,cil_oe_longe," & _
            "esf_oe_perto,cil_oe_perto,dnp_oe_longe,dnp_oe_perto,base_oe," & _
            "adicao_oe,altura_oe,diametro_oe,eixo_oe,aro_horizontal,aro_vertical," & _
            "maior_diametro,ponte,cod_Tipo_Armacao,crm_oftalmologista," & _
            "cod_filial_cliente,cod_cliente,data_venda,data_previsao_entrega," & _
            "hora_previsao_entrega,cod_vendedora,cod_qfez,observacao,nota_serie," & _
            "cod_verif_por,data_verificacao,cod_surfacagem,cod_montagem,confeccao,coloracao," & _
            "cor_coloracao,data_recebimento,data_fim_servico,cod_fase,tipo_receita_od," & _
            "tipo_receita_oe, id_laboratorio,doc_cliente,cod_lab_surf,cod_tipo_os) values(" & _
            _id_filial & "," & _cod_os & "," & d.cdin(_num_pedido) & "," & _
            d.cdin(cod_tab_od) & "," & d.cdin(_cod_tab_oe) & "," & _
            _cod_produto_od & "," & _cod_produto_oe & "," & _
            d.cdin(_esf_od_longe) & "," & d.cdin(_cil_od_longe) & "," & _
            d.cdin(_esf_od_perto) & "," & d.cdin(_cil_od_perto) & "," & _
            d.cdin(_dnp_od_longe) & "," & d.cdin(_dnp_od_perto) & "," & _
            d.cdin(_base_od) & "," & d.cdin(_adicao_od) & "," & _
            d.cdin(_altura_od) & "," & d.cdin(_diametro_od) & "," & _
            d.cdin(_eixo_od) & "," & d.cdin(_esf_oe_longe) & "," & _
            d.cdin(_cil_oe_longe) & "," & d.cdin(_esf_oe_perto) & "," & _
            d.cdin(_cil_oe_perto) & "," & d.cdin(_dnp_oe_longe) & "," & _
            d.cdin(_dnp_oe_perto) & "," & d.cdin(_base_oe) & "," & _
            d.cdin(_adicao_oe) & "," & d.cdin(_altura_oe) & "," & _
            d.cdin(_diametro_oe) & "," & d.cdin(_eixo_oe) & "," & _
            d.cdin(_aro_horizontal) & "," & d.cdin(_aro_vertical) & "," & _
            d.cdin(_maior_diametro) & "," & d.cdin(_ponte) & "," & _
            d.cdin(_cod_Tipo_Armacao) & "," & d.cdin(_crm_oftalmologista) & "," & _
            d.cdin(_cod_filial_cliente) & "," & d.cdin(_cod_cliente) & "," & _
            d.Pdt(_data_venda) & "," & d.Pdt(_data_previsao_entrega) & "," & _
            d.PStr(_hora_previsao_entrega) & "," & d.cdin(_cod_vendedora) & "," & _
            d.cdin(_cod_qfez) & "," & d.PStr(_observacao) & "," & _
            d.PStr(_nota_serie) & "," & d.cdin(_cod_verif_por) & "," & _
            d.Pdt(_data_verificacao) & "," & d.cdin(_cod_surfacagem) & "," & _
            d.cdin(_cod_montagem) & "," & _
            d.PStr(_confeccao) & "," & d.PStr(_coloracao) & "," & _
            d.PStr(_cor_coloracao) & "," & d.Pdt(_data_recebimento) & "," & _
            d.Pdt(_data_fim_servico) & "," & d.cdin(_cod_fase) & "," & _
            d.cdin(_tipo_receita_OD) & "," & d.cdin(_tipo_receita_OE) & _
            "," & d.cdin(_id_laboratorio) & _
            "," & d.PStr(_doc_cliente) & "," & d.cdin(_cod_lab_surf) & _
            "," & _cod_tipo_os & ")"
            OrigemSalvar = ""
            Return isql
        End If
        If Me.OrigemSalvar = "Editar" Then
            isql = "Update OS set " & _
            "num_pedido =" & d.cdin(_num_pedido) & ",cod_tab_od = " & _
            d.cdin(_cod_tab_od) & ",cod_tab_oe = " & d.cdin(_cod_tab_oe) & _
            ",cod_produto_od = " & d.cdin(_cod_produto_od) & _
            ",cod_produto_oe = " & d.cdin(_cod_produto_oe) & _
            ",esf_od_longe = " & d.cdin(_esf_od_longe) & _
            ",cil_od_longe = " & d.cdin(_cil_od_longe) & _
            ",esf_od_perto = " & d.cdin(_esf_od_perto) & _
            ",cil_od_perto = " & d.cdin(_cil_od_perto) & _
            ",dnp_od_longe = " & d.cdin(_dnp_od_longe) & _
            ",dnp_od_perto = " & d.cdin(_dnp_od_perto) & _
            ",base_od = " & d.cdin(_base_od) & _
            ",adicao_od = " & d.cdin(_adicao_od) & _
            ", altura_od = " & d.cdin(_altura_od) & _
            ",diametro_od = " & d.cdin(_diametro_od) & _
            ",eixo_od = " & d.cdin(_eixo_od) & _
            ",esf_oe_longe = " & d.cdin(_esf_oe_longe) & _
            ",cil_oe_longe = " & d.cdin(_cil_oe_longe) & _
            ",esf_oe_perto = " & d.cdin(_esf_oe_perto) & _
            ",cil_oe_perto = " & d.cdin(_cil_oe_perto) & _
            ",dnp_oe_longe = " & d.cdin(_dnp_oe_longe) & _
            ",dnp_oe_perto = " & d.cdin(_dnp_oe_perto) & _
            ",base_oe = " & d.cdin(_base_oe) & _
            ",adicao_oe = " & d.cdin(_adicao_oe) & _
            ",altura_oe = " & d.cdin(_altura_oe) & _
            ",diametro_oe = " & d.cdin(_diametro_oe) & _
            ",eixo_oe = " & d.cdin(_eixo_oe) & _
            ",aro_horizontal = " & d.cdin(_aro_horizontal) & _
            ",aro_vertical = " & d.cdin(_aro_vertical) & _
            ",maior_diametro = " & d.cdin(_maior_diametro) & _
            ",ponte = " & d.cdin(_ponte) & _
            ", cod_tipo_armacao = " & d.cdin(_cod_Tipo_Armacao) & _
            ", crm_oftalmologista = " & d.cdin(_crm_oftalmologista) & _
            ", cod_filial_cliente = " & d.cdin(_cod_filial_cliente) & _
            ", cod_cliente = " & d.cdin(_cod_cliente) & _
            ", data_venda = " & d.Pdt(_data_venda) & _
            ", data_previsao_entrega = " & d.pdtm(_data_previsao_entrega) & _
            ", hora_previsao_entrega = " & d.PStr(_hora_previsao_entrega) & _
            ", cod_vendedora = " & d.cdin(_cod_vendedora) & _
            ", cod_qfez = " & d.cdin(_cod_qfez) & _
            ", observacao = " & d.PStr(_observacao) & _
            ", nota_serie = " & d.PStr(_nota_serie) & _
            ", cod_verif_por = " & d.cdin(_cod_verif_por) & _
            ", data_verificacao = " & d.pdtm(_data_verificacao) & _
            ", cod_surfacagem =" & d.cdin(_cod_surfacagem) & _
            ", cod_montagem =" & d.cdin(_cod_montagem) & _
            ", confeccao = " & d.PStr(_confeccao) & _
            ", coloracao = " & d.cdin(_coloracao) & _
            ", cor_coloracao = " & d.PStr(_cor_coloracao) & _
            ", data_recebimento = " & d.pdtm(_data_recebimento) & _
            ", data_fim_servico = " & d.pdtm(_data_fim_servico) & _
            ", cod_fase = " & d.cdin(_cod_fase) & _
            ", tipo_receita_od = " & d.cdin(_tipo_receita_OD) & _
            ", tipo_receita_oe = " & d.cdin(_tipo_receita_OE) & _
            ", id_laboratorio = " & d.cdin(_id_laboratorio) & _
            ", doc_cliente = " & d.PStr(_doc_cliente) & _
            ", cod_lab_surf = " & d.cdin(_cod_lab_surf) & _
            ", cod_tipo_os = " & _cod_tipo_os & _
            " where " & _
            "id_filial = " & Me._id_filial & " and cod_os = " & _
            Me._cod_os & ""
            'cmd.CommandText = sql
            OrigemSalvar = ""
            Return isql
        End If
    End Function
    Public Function deletar(ByVal id_filial As Integer, ByVal cod_os As Integer)
        Dim sql As String
        Dim res As Integer
        d.conecta()
        sql = "Delete from OS where cod_os = " & cod_os & " and id_filial = " & _
        id_filial & ""
        Try
            res = d.Comando(sql, True)
        Catch ex As Exception

        End Try
        Me.refreshData()
        Me.primeiro()
        Return res & " foram apagados!"
    End Function
    Public Function retorna_chave(ByVal filial As Integer) As Integer
        Dim sql As String
        Dim t As New DataTable
        sql = "Select cod_os  from os where id_filial = " & filial & " ORDER BY cod_os DESC"
        d.carrega_Tabela(sql, t)
        If t.Rows.Count = 0 Then
            Return 1
        Else
            Return t.Rows(0)("cod_os") + 1
        End If
    End Function
    Public Function retorna_id_reserva_pend(ByVal X_cod_prod As Integer)
        Dim sql As String
        Dim tb_res As New DataTable
        sql = "Select id_reserva from reserva_lente_os where cod_os = " & Me._cod_os & _
        " and id_filial = " & Me._id_filial & " and cod_produto = " & X_cod_prod & " and id_status_reserva = 0"
        d.carrega_Tabela(sql, tb_res)
        If tb_res.Rows.Count > 0 Then
            Return tb_res.Rows(0)("id_reserva")
        Else
            Return 0
        End If
    End Function
    Public Function Sugere_compra(ByVal cod_prod As Integer, ByVal doc As String)
        Dim sql As String
        'Faz uma Sugestão de Pedido Automático, para itens que não estão
        'disponíveis no estoque!
        sql = "INSERT INTO sugestao_pedido_auto_os " & _
        "(cod_produto,doc_cliente,data,cod_status,cod_os,id_filial) VALUES " & _
        "(" & cod_prod & _
        "," & d.PStr(doc) & _
        "," & d.pdtm(Now.ToString) & _
        ",1," & Me.cod_os & "," & Me.id_filial & ")"
        Return d.Comando(sql, False)
    End Function
    Public Function tem_Sugestao_compra(ByVal cod_prod As Integer)
        Dim sql As String
        'Verifica se já há uma sugestão de compra em aberto para 
        'determinado produto!
        sql = "SELECT     quant, cod_produto " & _
        "FROM sugestao_pedido_auto_os " & _
        " WHERE  cod_status = 1 and " & _
        "cod_prod = " & cod_prod & _
        "and cod_os = " & Me.cod_os & "," & Me.id_filial & ")"
        d.Comando(sql, False)
    End Function
    Public Function insere_andamento()

    End Function
    Public Function olhos() As Int16
        Dim nOlhos As Integer = 0
        If _cod_tab_od > 1 Then
            nOlhos = nOlhos + 1
        End If
        If _cod_tab_oe > 1 Then
            nOlhos = nOlhos + 1
        End If
        Return nOlhos
    End Function
    Public Function OlhosBloco() As Int16
        Dim nolhosBloco As Integer = 0
        If _cod_tab_od > 1 And tem_bloco_od() Then
            nolhosBloco = nolhosBloco + 1
        End If
        If _cod_tab_oe > 1 And tem_bloco_oe() Then
            nolhosBloco = nolhosBloco + 1
        End If
        Return nolhosBloco
    End Function
    Public Function nome_cliente()
        Dim sql As String
        Dim tc As New DataTable
        sql = "Select nome_cliente from cliente where cod_filial_cliente = " & Me._cod_filial_cliente & _
        " and cod_cliente = " & Me._cod_cliente & ""
        d.carrega_Tabela(sql, tc)
        If tc.Rows.Count > 0 Then
            Return tc.Rows(0)("nome_cliente")
        Else
            Return Nothing
        End If

    End Function
    Public Function nome_tabela(ByVal cod As Integer)
        Dim sql As String
        Dim t_tab As New DataTable
        sql = "Select nome_comercial from lentes_tabela where cod_tabela = " & cod & ""
        d.carrega_Tabela(sql, t_tab)
        Return t_tab.Rows(0)("Nome_comercial")
    End Function
    Public Function nome_Estoque(ByVal cod As Integer)
        Dim sql As String
        Dim t_tab As New DataTable
        sql = "Select produto from produtos where cod_produto = " & cod & ""
        d.carrega_Tabela(sql, t_tab)
        Return (t_tab.Rows(0)("produto"))
    End Function
    Public Function tem_surfacagem() As Boolean
        If Me.cod_surfacagem = Nothing Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function tem_bloco() As Boolean
        Dim tem As Boolean = False
        'Avalia se algum dos produtos da OS é Bloco
        'Olho direito
        Try
            If prod.retorna_especie(Me._cod_produto_od).Trim = "B" Then
                tem = True
                GoTo fim
            End If
            'Olho esquerdo
            If prod.retorna_especie(Me._cod_produto_oe).Trim = "B" Then
                tem = True
            End If
fim:
            Return tem
        Catch ex As Exception

        End Try
       
    End Function
    Public Function tem_bloco_od() As Boolean
        Dim tem As Boolean = False
        'Avalia se o olho direito é bloco
        Try
            If prod.retorna_especie(Me._cod_produto_od).Trim = "B" Then
                tem = True
            End If
            Return tem
        Catch ex As Exception

        End Try
    End Function
    Public Function tem_bloco_oe() As Boolean
        Dim tem As Boolean = False
        'Avalia se o olho direito é bloco
        Try
            If prod.retorna_especie(Me._cod_produto_oe).Trim = "B" Then
                tem = True
            End If
            Return tem
        Catch ex As Exception

        End Try
    End Function
    Public Function tem_montagem() As Boolean
        If Me.cod_montagem = Nothing Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function tem_tratamento() As Boolean
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select * from tratamentos_os where cod_os = " & Me.cod_os & _
        " and id_filial = " & Me.id_filial & " and cod_produto <> 27366"
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function tem_anti_risco() As Boolean
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select * from tratamentos_os where cod_os = " & Me.cod_os & _
        " and id_filial = " & Me.id_filial & " and cod_produto = 27366"
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function tem_coloracao() As Boolean
        If Me.coloracao = Nothing Or Me.coloracao = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function andamentos_os() As DataTable
        Dim sql As String
        Dim tb_and As New DataTable
        sql = "SELECT andamentos.id_filial, andamentos.cod_os, andamentos.ordem," & _
        "andamentos.cod_andamento," & _
        "andamentos.data, tipo_andamento.andamento, Usuarios.NOME AS usuario," & _
        "andamentos.Observacao FROM andamentos INNER JOIN " & _
        "tipo_andamento ON andamentos.cod_andamento = tipo_andamento.cod_andamento " & _
        "INNER JOIN Usuarios ON andamentos.cod_usuario = Usuarios.cod_usuario " & _
        "where andamentos.id_filial = " & _id_filial & _
        "and andamentos.cod_os = " & _cod_os & _
        " order by ordem"
        d.carrega_Tabela(sql, tb_and)
        Return tb_and
    End Function
    Public Function andamentos_os_validos(ByVal tira_aviso_reimpressao As Boolean) As DataTable
        Dim sql As String
        Dim tb_and As New DataTable
        sql = "SELECT andamentos.id_filial, andamentos.cod_os, andamentos.ordem," & _
        "andamentos.cod_andamento," & _
        "andamentos.data, tipo_andamento.andamento, Usuarios.NOME AS usuario," & _
        "andamentos.Observacao FROM andamentos INNER JOIN " & _
        "tipo_andamento ON andamentos.cod_andamento = tipo_andamento.cod_andamento " & _
        "INNER JOIN Usuarios ON andamentos.cod_usuario = Usuarios.cod_usuario " & _
        "where andamentos.id_filial = " & _id_filial & _
        "and andamentos.cod_os = " & _cod_os & _
        "and andamentos.cod_status_andamento = 1 " & _
        " and andamentos.cod_andamento <> 701 "
        If tira_aviso_reimpressao = True Then
            sql = sql & " and andamentos.cod_andamento <> 211 "
        End If
        sql = sql & " order by ordem"
        d.carrega_Tabela(sql, tb_and)
        Return tb_and
    End Function
    Public Function andamentos_os(ByVal x_id_filial As Integer, ByVal x_cod_os As Integer) As DataTable
        Dim sql As String
        Dim tb_and As New DataTable
        sql = "SELECT andamentos.id_filial, andamentos.cod_os, andamentos.ordem," & _
        "andamentos.data, tipo_andamento.andamento, Usuarios.NOME AS usuario," & _
        "andamentos.Observacao FROM andamentos INNER JOIN " & _
        "tipo_andamento ON andamentos.cod_andamento = tipo_andamento.cod_andamento " & _
        "INNER JOIN Usuarios ON andamentos.cod_usuario = Usuarios.cod_usuario " & _
        "where andamentos.id_filial = " & x_id_filial & _
        " and andamentos.cod_os = " & x_cod_os & _
        " order by ordem"
        d.carrega_Tabela(sql, tb_and)
        Return tb_and
    End Function

    Public Function os_pendentes(ByVal x_id_filial As Integer, ByVal x_cod_os As Integer) As DataTable
        Dim sql As String
        Dim tb_and As New DataTable
        sql = "SELECT andamentos.id_filial, andamentos.cod_os, andamentos.ordem," & _
        "andamentos.data, tipo_andamento.andamento, Usuarios.NOME AS usuario," & _
        "andamentos.Observacao FROM andamentos INNER JOIN " & _
        "tipo_andamento ON andamentos.cod_andamento = tipo_andamento.cod_andamento " & _
        "INNER JOIN Usuarios ON andamentos.cod_usuario = Usuarios.cod_usuario " & _
        "where andamentos.id_filial = " & x_id_filial & _
        "and andamentos.cod_os = " & x_cod_os & _
        " order by ordem"
        d.carrega_Tabela(sql, tb_and)
        Return tb_and
    End Function

    Public Function andamentos_os_otica(ByVal x_id_filial As Integer, ByVal x_cod_os As Integer) As DataTable
        Dim sql As String
        Dim tb_and As New DataTable
        sql = "SELECT  OS.doc_cliente as id_filial, OS.cod_cliente as cod_os, andamentos.ordem, andamentos.data, " & _
        "tipo_andamento.andamento, Usuarios.NOME AS usuario, " & _
        "andamentos.Observacao, OS.doc_cliente, OS.cod_cliente FROM andamentos INNER JOIN " & _
        "tipo_andamento ON andamentos.cod_andamento = tipo_andamento.cod_andamento INNER JOIN " & _
        "Usuarios ON andamentos.cod_usuario = Usuarios.cod_usuario INNER JOIN " & _
        "OS ON andamentos.id_filial = OS.id_filial AND andamentos.cod_os = OS.cod_os " & _
        "WHERE (OS.doc_cliente = " & x_cod_os & ") AND (OS.cod_cliente = " & x_id_filial & ") " & _
        "ORDER BY andamentos.ordem"
        d.carrega_Tabela(sql, tb_and)
        Return tb_and
    End Function
    Public Function andamentos_os_producao_validos() As DataTable
        Dim strSql As String
        Dim tb_and As New DataTable
        strSql = "SELECT andamentos.*, Usuarios.NOME, " & _
        "tipo_andamento.andamento, tipo_andamento.andamento + ' - ' + " & _
        "Usuarios.NOME  as exibicao FROM andamentos INNER JOIN " & _
        "tipo_andamento ON andamentos.cod_andamento = tipo_andamento.cod_andamento " & _
        "INNER JOIN Usuarios ON andamentos.cod_usuario = Usuarios.cod_usuario " & _
        "WHERE (andamentos.id_filial = " & Me._id_filial & ") AND " & _
        "(andamentos.cod_os = " & Me._cod_os & ") AND " & _
        "((tipo_andamento.cod_setor = 3) OR (tipo_andamento.cod_setor = 4)" & _
        "or (tipo_andamento.cod_setor = 6) or (andamentos.cod_andamento = 212) " & _
        "or (andamentos.cod_andamento = 702))  " & _
        " AND (andamentos.cod_status_andamento = 1)"

        d.carrega_Tabela(strSql, tb_and)
        Return tb_and
    End Function
    Public Function retorna_fase_str() As String
        Dim sql As String
        Dim tbf As New DataTable
        sql = "Select fase from fases_os where cod_fase = " & Me.cod_fase & ""
        d.carrega_Tabela(sql, tbf)
        Return tbf.Rows(0)("fase")
    End Function
    Public Function troca_produto() As Integer
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select * from troca_produto where  " & _
        " cod_os = " & Me._cod_os & " and id_filial = " & _
        Me._id_filial & " and concluido = 'N'"
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then
            Return tt.Rows(0)("cod_troca_prod")
        Else
            Return 0
        End If

    End Function
    Public Function desverifica_os() As String
        Dim Us As New objUsuario
        Us.login(Nothing)
        'Procedimento 11: desverificar OS
        If Us.acesso(11) = False Then
            Return "ER:Usuário não tem permissao p/ desverificar OS!"
        Else
            editar()
            data_verificacao = Nothing
            Salvar()
            Return "OK: Desverificado!"
        End If
    End Function
    Public Function lista_pendentes_estoque() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT OS.cod_os, OS.id_filial, OS.cod_produto_od, OS.cod_produto_oe, " & _
        "os.data_verificacao," & _
        "os.cod_cliente,os.doc_cliente," & _
        "(SELECT produto FROM produtos WHERE (cod_produto = OS.cod_produto_od)) AS OD," & _
        "(SELECT produto FROM produtos WHERE (cod_produto = OS.cod_produto_oe)) AS OE," & _
        "fases_OS.fase, cliente.nome_cliente FROM OS INNER JOIN " & _
        "fases_OS ON OS.cod_fase = fases_OS.cod_fase INNER JOIN " & _
        "cliente ON OS.cod_filial_cliente = cliente.cod_filial_cliente " & _
        "AND OS.cod_cliente = cliente.cod_cliente " & _
        "WHERE (OS.cod_fase = 3) OR (OS.cod_fase = 5) " & _
        "ORDER BY OS.cod_fase, OS.data_verificacao "
        d.carrega_Tabela(sql, tt)
        Return tt

    End Function
    Public Function lista_pendentes_estoque_otica() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT OS.cod_os, OS.id_filial, OS.data_verificacao, OS.cod_cliente, OS.doc_cliente, " & _
        " os.cod_Tab_od,os.cod_tab_oe," & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) AS OD, " & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) AS OE, " & _
        "fases_OS.fase, cliente.nome_cliente, OS.esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, " & _
        "OS.cil_od_perto, OS.base_od, OS.adicao_od, OS.esf_oe_longe, OS.cil_oe_longe, " & _
        "OS.esf_oe_perto, OS.cil_oe_perto, OS.base_oe, OS.adicao_oe " & _
        "FROM OS INNER JOIN fases_OS ON OS.cod_fase = fases_OS.cod_fase INNER JOIN " & _
        "cliente ON OS.cod_filial_cliente = cliente.cod_filial_cliente AND OS.cod_cliente = " & _
        "cliente.cod_cliente WHERE (OS.cod_fase = 3 OR OS.cod_fase = 5) AND (OS.cod_cliente < 20) " & _
        "ORDER BY OS.cod_cliente, OS.doc_cliente "
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_pendentes_estoque_otica_e_labonorte() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT OS.cod_os, OS.id_filial, OS.data_verificacao, OS.cod_cliente, OS.doc_cliente, " & _
        " os.cod_Tab_od,os.cod_tab_oe," & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) AS OD, " & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_oe)) AS OE, " & _
        "fases_OS.fase, cliente.nome_cliente, OS.esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, " & _
        "OS.cil_od_perto, OS.base_od, OS.adicao_od, OS.esf_oe_longe, OS.cil_oe_longe, " & _
        "OS.esf_oe_perto, OS.cil_oe_perto, OS.base_oe, OS.adicao_oe " & _
        "FROM OS INNER JOIN fases_OS ON OS.cod_fase = fases_OS.cod_fase INNER JOIN " & _
        "cliente ON OS.cod_filial_cliente = cliente.cod_filial_cliente AND OS.cod_cliente = " & _
        "cliente.cod_cliente WHERE (OS.cod_fase = 3 OR OS.cod_fase = 5) " & _
        "ORDER BY OS.cod_cliente, OS.doc_cliente "
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_pendentes_estoque_otica_e_labonorte_forncecedor() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT OS.cod_os, OS.id_filial, os.data_venda,OS.data_verificacao, OS.cod_cliente, OS.doc_cliente, " & _
        "OS.cod_tab_od, OS.cod_tab_oe, " & _
        "(Select top(1) andamentos.data from andamentos where cod_os = os.cod_os " & _
        "and id_filial = os.id_filial) as data_importacao, " & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) AS OD, " & _
        "(SELECT nome_comercial FROM lentes_tabela wHERE (cod_tabela = OS.cod_tab_oe)) AS OE, " & _
        "fases_OS.fase, cliente.nome_cliente, OS.esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, " & _
        "OS.cil_od_perto, OS.base_od, OS.adicao_od, OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, " & _
        "OS.cil_oe_perto, OS.base_oe, OS.adicao_oe, fabricante.fabricante " & _
        "FROM fabricante INNER JOIN lentes_tabela ON fabricante.id_fabricante = " & _
        "lentes_tabela.id_fabricante FULL OUTER JOIN " & _
        "OS INNER JOIN fases_OS ON OS.cod_fase = fases_OS.cod_fase INNER JOIN " & _
        "cliente ON OS.cod_filial_cliente = cliente.cod_filial_cliente AND " & _
        "OS.cod_cliente = cliente.cod_cliente ON lentes_tabela.cod_tabela = OS.cod_tab_od AND " & _
        "lentes_tabela.cod_tabela = OS.cod_tab_oe WHERE ((OS.cod_fase = 2) or (OS.cod_fase = 3) OR (OS.cod_fase = 5) " & _
        " OR (OS.cod_fase = 20)) and ((os.cod_tab_od + os.cod_tab_oe) > 5) " & _
        "ORDER BY fabricante.fabricante, OD,OE, OS.base_od, OS.adicao_od, " & _
        "OS.base_oe, OS.adicao_oe, OS.esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, OS.cil_od_perto, " & _
        "OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, OS.cil_oe_perto, " & _
        "OS.data_verificacao," & _
        "OS.cod_cliente, OS.doc_cliente "
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_pendentes_estoque_otica_forncecedor(ByVal sai As Boolean, ByVal filiais As String) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT OS.cod_os, OS.id_filial, os.data_venda,OS.data_verificacao, OS.cod_cliente, OS.doc_cliente, " & _
        "OS.cod_tab_od, OS.cod_tab_oe, " & _
        "(Select top(1) andamentos.data from andamentos where cod_os = os.cod_os " & _
        "and id_filial = os.id_filial) as data_importacao, " & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) AS OD, " & _
        "(SELECT nome_comercial FROM lentes_tabela wHERE (cod_tabela = OS.cod_tab_oe)) AS OE, " & _
        "fases_OS.fase, cliente.nome_cliente, OS.esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, " & _
        "OS.cil_od_perto, OS.base_od, OS.adicao_od, OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, " & _
        "OS.cil_oe_perto, OS.base_oe, OS.adicao_oe, fabricante.fabricante, lentes_tabela.labonorte_sai " & _
        "FROM fabricante INNER JOIN lentes_tabela ON fabricante.id_fabricante = " & _
        "lentes_tabela.id_fabricante FULL OUTER JOIN " & _
        "OS INNER JOIN fases_OS ON OS.cod_fase = fases_OS.cod_fase INNER JOIN " & _
        "cliente ON OS.cod_filial_cliente = cliente.cod_filial_cliente AND " & _
        "OS.cod_cliente = cliente.cod_cliente ON lentes_tabela.cod_tabela = OS.cod_tab_od AND " & _
        "lentes_tabela.cod_tabela = OS.cod_tab_oe WHERE ((OS.cod_fase = 2) OR (OS.cod_fase = 3) OR (OS.cod_fase = 5) " & _
        " OR (OS.cod_fase = 20)) and (os.cod_cliente < 1000) " & _
        " and ((os.cod_tab_od + os.cod_tab_oe) > 5) and lentes_tabela.labonorte_sai = '" & sai & "' " & _
        "ORDER BY fabricante.fabricante, OD,OE, OS.base_od, OS.adicao_od, " & _
        "OS.base_oe, OS.adicao_oe, OS. esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, OS.cil_od_perto, " & _
        "OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, OS.cil_oe_perto, " & _
        "OS.data_verificacao," & _
        "OS.cod_cliente, OS.doc_cliente "
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_pendentes_estoque_otica_forncecedor(ByVal lojas As String) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        Dim loja As String()
        Dim Parametro As String
        Dim i As Integer = 0
        loja = lojas.Split(",")
        Parametro = "("
        For Each l In loja
            If i = 0 Then
                Parametro = Parametro & " os.cod_cliente = " & l & ""
            Else
                Parametro = Parametro & " or os.cod_cliente =" & l & ""
            End If
            i = i + 1
        Next
        Parametro = Parametro & ")"
        sql = "SELECT OS.cod_os, OS.id_filial, os.data_venda,OS.data_verificacao, OS.cod_cliente, OS.doc_cliente, " & _
        "OS.cod_tab_od, OS.cod_tab_oe, " & _
        "(Select top(1) andamentos.data from andamentos where cod_os = os.cod_os " & _
        "and id_filial = os.id_filial) as data_importacao, " & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) AS OD, " & _
        "(SELECT nome_comercial FROM lentes_tabela wHERE (cod_tabela = OS.cod_tab_oe)) AS OE, " & _
        "fases_OS.fase, cliente.nome_cliente, OS.esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, " & _
        "OS.cil_od_perto, OS.base_od, OS.adicao_od, OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, " & _
        "OS.cil_oe_perto, OS.base_oe, OS.adicao_oe, fabricante.fabricante " & _
        "FROM fabricante INNER JOIN lentes_tabela ON fabricante.id_fabricante = " & _
        "lentes_tabela.id_fabricante FULL OUTER JOIN " & _
        "OS INNER JOIN fases_OS ON OS.cod_fase = fases_OS.cod_fase INNER JOIN " & _
        "cliente ON OS.cod_filial_cliente = cliente.cod_filial_cliente AND " & _
        "OS.cod_cliente = cliente.cod_cliente ON lentes_tabela.cod_tabela = OS.cod_tab_od AND " & _
        "lentes_tabela.cod_tabela = OS.cod_tab_oe WHERE ((OS.cod_fase = 2) OR (OS.cod_fase = 3) OR (OS.cod_fase = 5) " & _
        " OR (OS.cod_fase = 20)) and " & _
        Parametro & _
        " and ((os.cod_tab_od + os.cod_tab_oe) > 5) " & _
        "ORDER BY fabricante.fabricante, OD,OE, OS.base_od, OS.adicao_od, " & _
        "OS.base_oe, OS.adicao_oe, OS. esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, OS.cil_od_perto, " & _
        "OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, OS.cil_oe_perto, " & _
        "OS.data_verificacao," & _
        "OS.cod_cliente, OS.doc_cliente "
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_pendentes_estoque_otica_por_loja() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT OS.cod_os, OS.id_filial, os.data_venda,OS.data_verificacao, OS.cod_cliente, OS.doc_cliente, " & _
        "OS.cod_tab_od, OS.cod_tab_oe, cliente.nome_cliente," & _
        "(Select top(1) andamentos.data from andamentos where cod_os = os.cod_os " & _
        "and id_filial = os.id_filial) as data_importacao, " & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) AS OD, " & _
        "(SELECT nome_comercial FROM lentes_tabela wHERE (cod_tabela = OS.cod_tab_oe)) AS OE, " & _
        "fases_OS.fase, cliente.nome_cliente, OS.esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, " & _
        "OS.cil_od_perto, OS.base_od, OS.adicao_od, OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, " & _
        "OS.cil_oe_perto, OS.base_oe, OS.adicao_oe, fabricante.fabricante " & _
        "FROM fabricante INNER JOIN lentes_tabela ON fabricante.id_fabricante = " & _
        "lentes_tabela.id_fabricante FULL OUTER JOIN " & _
        "OS INNER JOIN fases_OS ON OS.cod_fase = fases_OS.cod_fase INNER JOIN " & _
        "cliente ON OS.cod_filial_cliente = cliente.cod_filial_cliente AND " & _
        "OS.cod_cliente = cliente.cod_cliente ON lentes_tabela.cod_tabela = OS.cod_tab_od AND " & _
        "lentes_tabela.cod_tabela = OS.cod_tab_oe WHERE ((OS.cod_fase = 2) OR (OS.cod_fase = 3) OR (OS.cod_fase = 5) " & _
        " OR (OS.cod_fase = 20)) and (os.cod_cliente < 1000) " & _
        " and ((os.cod_tab_od + os.cod_tab_oe) > 5) " & _
        "ORDER BY OS.cod_cliente, OS.doc_cliente , fabricante.fabricante, OD,OE, OS.base_od, OS.adicao_od, " & _
        "OS.base_oe, OS.adicao_oe, OS. esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, OS.cil_od_perto, " & _
        "OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, OS.cil_oe_perto, " & _
        "OS.data_verificacao"

        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_pendentes_estoque_otica_forncecedor_verificacao(ByVal dv As Date) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT OS.cod_os, OS.id_filial, os.data_venda,OS.data_verificacao, OS.cod_cliente, OS.doc_cliente, " & _
        "OS.cod_tab_od, OS.cod_tab_oe, " & _
        "(Select top(1) andamentos.data from andamentos where cod_os = os.cod_os " & _
        "and id_filial = os.id_filial) as data_importacao, " & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) AS OD, " & _
        "(SELECT nome_comercial FROM lentes_tabela wHERE (cod_tabela = OS.cod_tab_oe)) AS OE, " & _
        "fases_OS.fase, cliente.nome_cliente, OS.esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, " & _
        "OS.cil_od_perto, OS.base_od, OS.adicao_od, OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, " & _
        "OS.cil_oe_perto, OS.base_oe, OS.adicao_oe, fabricante.fabricante " & _
        "FROM fabricante INNER JOIN lentes_tabela ON fabricante.id_fabricante = " & _
        "lentes_tabela.id_fabricante FULL OUTER JOIN " & _
        "OS INNER JOIN fases_OS ON OS.cod_fase = fases_OS.cod_fase INNER JOIN " & _
        "cliente ON OS.cod_filial_cliente = cliente.cod_filial_cliente AND " & _
        "OS.cod_cliente = cliente.cod_cliente ON lentes_tabela.cod_tabela = OS.cod_tab_od AND " & _
        "lentes_tabela.cod_tabela = OS.cod_tab_oe WHERE ((OS.cod_fase = 2) OR (OS.cod_fase = 3) OR (OS.cod_fase = 5) " & _
        " OR (OS.cod_fase = 20)) and (os.cod_cliente < 1000) " & _
        " and (os.data_verificacao <= " & d.pdtm(dv) & ") " & _
        " and ((os.cod_tab_od + os.cod_tab_oe) > 5) " & _
        "ORDER BY fabricante.fabricante, OD,OE, OS.base_od, OS.adicao_od, " & _
        "OS.base_oe, OS.adicao_oe, OS. esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, OS.cil_od_perto, " & _
        "OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, OS.cil_oe_perto, " & _
        "OS.data_verificacao," & _
        "OS.cod_cliente, OS.doc_cliente "
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_pendentes_estoque_labonorte_forncecedor() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT OS.cod_os, OS.id_filial, os.data_venda,OS.data_verificacao, OS.cod_cliente, OS.doc_cliente, " & _
        "OS.cod_tab_od, OS.cod_tab_oe, " & _
        "(Select top(1) andamentos.data from andamentos where cod_os = os.cod_os " & _
        "and id_filial = os.id_filial) as data_importacao, " & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) AS OD, " & _
        "(SELECT nome_comercial FROM lentes_tabela wHERE (cod_tabela = OS.cod_tab_oe)) AS OE, " & _
        "fases_OS.fase, cliente.nome_cliente, OS.esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, " & _
        "OS.cil_od_perto, OS.base_od, OS.adicao_od, OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, " & _
        "OS.cil_oe_perto, OS.base_oe, OS.adicao_oe, fabricante.fabricante " & _
        "FROM fabricante INNER JOIN lentes_tabela ON fabricante.id_fabricante = " & _
        "lentes_tabela.id_fabricante FULL OUTER JOIN " & _
        "OS INNER JOIN fases_OS ON OS.cod_fase = fases_OS.cod_fase INNER JOIN " & _
        "cliente ON OS.cod_filial_cliente = cliente.cod_filial_cliente AND " & _
        "OS.cod_cliente = cliente.cod_cliente ON lentes_tabela.cod_tabela = OS.cod_tab_od AND " & _
        "lentes_tabela.cod_tabela = OS.cod_tab_oe WHERE ((OS.cod_fase = 2) or (OS.cod_fase = 3) OR (OS.cod_fase = 5)) " & _
        " and (os.cod_cliente > 1000) " & _
         " and ((os.cod_tab_od + os.cod_tab_oe) > 5) " & _
        "ORDER BY fabricante.fabricante, OD, OE, OS.adicao_od, " & _
        "OS.base_oe, OS.adicao_oe, OS. esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, OS.cil_od_perto, " & _
        "OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, OS.cil_oe_perto, " & _
        "OS.data_verificacao," & _
        "OS.cod_cliente, OS.doc_cliente "
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function pedidos_aguardando_lente() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT OS_pedido.cod_os, OS.cod_tab_od, OS.cod_tab_oe, fases_OS.fase, OS.cod_cliente, " & _
        "OS.doc_cliente, lentes_tabela.id_fabricante,fabricante.fabricante, " & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) AS OD, " & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_oe)) AS OE, " & _
        "OS.base_od, OS.adicao_od, OS.esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, OS.cil_od_perto, " & _
        "OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, OS.cil_oe_perto, OS.base_oe, OS.adicao_oe, " & _
        "OS.data_verificacao FROM fabricante INNER JOIN " & _
        "lentes_tabela ON fabricante.id_fabricante = lentes_tabela.id_fabricante RIGHT OUTER JOIN " & _
        "OS_pedido INNER JOIN OS ON OS_pedido.id_filial = OS.id_filial AND OS_pedido.cod_os " & _
        "= OS.cod_os INNER JOIN fases_OS ON OS.cod_fase = fases_OS.cod_fase ON " & _
        "lentes_tabela.cod_tabela = OS.cod_tab_od And lentes_tabela.cod_tabela = OS.cod_tab_oe " & _
        "WHERE     (OS.cod_fase = 2) OR (OS.cod_fase = 3) OR (OS.cod_fase = 5) OR " & _
        "(OS.cod_fase = 4) OR (OS.cod_fase = 18) GROUP BY OS_pedido.cod_os, OS.cod_tab_od, " & _
        "OS.cod_tab_oe, fases_OS.fase, OS.cod_cliente, OS.doc_cliente, lentes_tabela.id_fabricante, fabricante.fabricante," & _
        "OS.base_od, OS.adicao_od, OS.esf_od_longe, OS.cil_od_longe, " & _
        "OS.esf_od_perto, OS.cil_od_perto, OS.esf_oe_longe,OS.cil_oe_longe, OS.esf_oe_perto, " & _
        "OS.cil_oe_perto, OS.base_oe, OS.adicao_oe, OS.data_verificacao " & _
        "ORDER BY lentes_tabela.id_fabricante, fabricante.fabricante, OD, OE, OS.data_verificacao, " & _
        "OS.base_od, OS.adicao_od, OS.base_oe, " & _
        "OS.adicao_oe, OS.esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, " & _
        "OS.cil_od_perto, OS.esf_oe_longe, OS.cil_oe_longe, OS.esf_oe_perto, " & _
        "OS.cil_oe_perto,  OS.cod_cliente, OS.doc_cliente"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_pendentes_estoque_otica_so_lente() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT OS.cod_os, OS.id_filial, OS.data_verificacao, OS.cod_cliente, OS.doc_cliente, " & _
        " os.cod_Tab_od,os.cod_tab_oe," & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) AS OD, " & _
        "(SELECT nome_comercial FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) AS OE, " & _
        "fases_OS.fase, cliente.nome_cliente, OS.esf_od_longe, OS.cil_od_longe, OS.esf_od_perto, " & _
        "OS.cil_od_perto, OS.base_od, OS.adicao_od, OS.esf_oe_longe, OS.cil_oe_longe, " & _
        "OS.esf_oe_perto, OS.cil_oe_perto, OS.base_oe, OS.adicao_oe " & _
        "FROM OS INNER JOIN fases_OS ON OS.cod_fase = fases_OS.cod_fase INNER JOIN " & _
        "cliente ON OS.cod_filial_cliente = cliente.cod_filial_cliente AND OS.cod_cliente = " & _
        "cliente.cod_cliente WHERE (OS.cod_fase = 2 or OS.cod_fase = 3 OR OS.cod_fase = 5) AND (OS.cod_cliente < 20) " & _
        "and ((SELECT especie FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) = 'L' or " & _
        "(SELECT especie FROM lentes_tabela WHERE (cod_tabela = OS.cod_tab_od)) = 'L') " & _
        "ORDER BY OS.cod_cliente, OS.doc_cliente "
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function lista_tratamentos() As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select * from tratamentos_os where " & _
        " cod_os = " & _cod_os & " and id_filial = " & _
        _id_filial & ""
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function insere_tratamento(ByVal x_cod_produto As Integer, ByVal XUser As Integer)
        Dim sql As String
        Dim dv As New DataView
        Dim res As String
        Try
            dv.Table = lista_tratamentos()
            dv.RowFilter = "cod_produto = " & x_cod_produto & ""
            If dv.Count > 0 Then
                dv.Dispose()
                Return "ER:Tratamento já esxixte!"
                Exit Function
            End If
        Catch ex As Exception
            Return "ER:" & ex.Message & vbCrLf & "LISTA tratamentos"
        End Try
        sql = "insert into tratamentos_os(id_filial,cod_os,cod_produto) values(" & _
        _id_filial & "," & _cod_os & "," & x_cod_produto & ")"
        res = d.Comando(sql, True)
        If res.StartsWith("OK") Then
            Try
                prod.filtra(x_cod_produto)
                res = andamentos.insere_andamento(objAndamentos.tipo.aviso_os, Me._id_filial, Me._cod_os, _
                                            XUser, "Adicionado Tratamento " & prod.fldProduto & "")
            Catch ex As Exception
                res = "ER: " & ex.ToString
            End Try
            
        End If
        Return res
    End Function
    Public Function insere_tratamento_trans(ByVal x_cod_produto As Integer, ByVal XUser As Integer, ByVal ordem_and As Integer) As DataTable
        Dim sql As String
        Dim trans As New objSqlTrans
        Dim dv As New DataView
        Dim res As String
        sql = "insert into tratamentos_os(id_filial,cod_os,cod_produto) values(" & _
        _id_filial & "," & _cod_os & "," & x_cod_produto & ")"
        trans.insere_instrucao(sql)
        prod.filtra(x_cod_produto)
        res = andamentos.insere_andamento_trans(objAndamentos.tipo.aviso_os, Me._id_filial, Me._cod_os, _
                                    XUser, "Adicionado Tratamento " & prod.fldProduto & "", ordem_and)
        trans.insere_instrucao(res)

        Return trans.instrucoes
    End Function
    Public Function quant_lentes()
        Dim i As Integer = 0
        If _cod_tab_od <> 1 Or _cod_tab_od <> 2 Then
            i = i + 1
        End If
        If _cod_tab_oe <> 1 Or _cod_tab_oe <> 2 Then
            i = i + 1
        End If
        Return i
    End Function
    Public Function lista_os_nao_concluidas(ByVal ft As String) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT fases_OS.fase, OS.id_filial, OS.cod_os as os_local, " & _
        "OS.cod_cliente, OS.doc_cliente, " & _
        "(SELECT produto FROM produtos WHERE (cod_produto = os.cod_produto_od)) as OD, " & _
        "(SELECT produto FROM produtos WHERE (cod_produto = os.cod_produto_oe)) as Oe, " & _
        "(SELECT top 1 produtos.produto FROM tratamentos_os LEFT OUTER JOIN " & _
        "produtos ON tratamentos_os.cod_produto = produtos.cod_produto " & _
        "WHERE (tratamentos_os.id_filial = os.id_filial) AND " & _
        "(tratamentos_os.cod_os = os.cod_os)) as tratamento, " & _
        "OS.data_verificacao, OS.data_previsao_entrega, " & _
        "(SELECT min(data) AS dia FROM andamentos " & _
        "WHERE (id_filial = os.id_filial) AND (cod_os = os.cod_os)) as data_PrimeiroAndamento," & _
        "(SELECT MAX(data) AS dia FROM andamentos " & _
        "WHERE     (id_filial = os.id_filial) AND (cod_os = os.cod_os)) as data_ultimoAndamento, " & _
        "(SELECT   top 1  (tipo_andamento.andamento) AS andamento " & _
        "FROM  andamentos INNER JOIN tipo_andamento ON andamentos.cod_andamento = " & _
        "tipo_andamento.cod_andamento WHERE (andamentos.id_filial = os.id_filial) AND " & _
        "(andamentos.cod_os = os.cod_os) order by andamentos.data Desc ) as  ultimo_andamento " & _
        "FROM  fases_OS INNER JOIN OS ON fases_OS.cod_fase = OS.cod_fase " & _
        "where(os.cod_fase <> 15 And os.cod_fase <> 21) " & _
        ft & _
        " ORDER BY OS.cod_cliente, OS.doc_cliente "

        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function Ret_estoque_lente(ByVal cod_tab As Integer, ByVal esf As Double, ByVal cil As Double) As Long
        Dim tb As New DataTable
        Dim sql As String
        Dim esp As Char = Nothing
        Dim lTab As New objTabela(d)
        sql = "SELECT lentes_tabela.nome_comercial, lentes_blocos.nome_lente,produtos.cod_produto, produtos.cod_barra, lentes_blocos.diametro, lentes_blocos.cod_tabela, " & _
            "lentes_blocos.cod_lente FROM lentes_blocos INNER JOIN lentes_tabela ON lentes_blocos.cod_tabela = lentes_tabela.cod_tabela INNER JOIN " & _
            "produtos ON lentes_blocos.cod_lente = produtos.cod_lente AND lentes_blocos.id_fabricante = produtos.id_fabricante INNER JOIN " & _
            "lentes ON produtos.cod_produto = lentes.cod_produto Where " & _
            "lentes.esferico = " & d.cdin(esf) & " AND lentes.cilindrico = " & _
            d.cdin(cil) & " and lentes_tabela.cod_tabela = " & cod_tab & ""
        d.carrega_Tabela(sql, tb)
        If tb.Rows.Count > 0 Then
            Return tb.Rows(0)("cod_produto")
        Else
            Return 0
        End If
    End Function
    Public Function Ret_estoque_bloco(ByVal cod_tab As Long, ByVal Base As Double, ByVal Adicao As Double, ByVal olho As String) As Long
        Dim tb As New DataTable
        Dim sql As String
        sql = "SELECT produtos.cod_produto, lentes_blocos.cod_tabela, blocos.Base_nominal, " & _
            "blocos.Adicao, blocos.olho FROM blocos INNER JOIN " & _
            "produtos ON blocos.Cod_produto = produtos.cod_produto INNER JOIN " & _
            "lentes_blocos ON produtos.cod_lente = lentes_blocos.cod_lente AND " & _
            "produtos.id_fabricante = lentes_blocos.id_fabricante " & _
            "WHERE     (lentes_blocos.cod_tabela = " & cod_tab & ") AND " & _
            "(blocos.Base_nominal = " & d.cdin(Base) & ") AND (blocos.Adicao = " & d.cdin(Adicao) & ") " & _
            "AND (blocos.olho =  " & d.PStr(olho) & " or blocos.olho = 'A')"
        d.carrega_Tabela(sql, tb)
        If tb.Rows.Count > 0 Then
            Return tb.Rows(0)("cod_produto")
        Else
            Return 0
        End If
    End Function
    Public Function OS_nome_cliente(ByVal nome As String) As DataTable
        Dim sql As String
        Dim tt As New DataTable
        sql = "Select cod_cliente,doc_cliente,observacao,cod_os from OS where observacao like '%" & nome.Replace(" ", "%") & "%'"
        d.carrega_Tabela(sql, tt)
        Return tt
    End Function
    Public Function grava_numero_pedido(ByVal n_pedido As Integer, ByVal nOS As Integer, ByVal n_filial As Integer) As String
        Dim tsql As String
        tsql = "Update OS set num_pedido = " & n_pedido & " where cod_os = " & nOS & " and id_filial = " & n_filial & ""
        Return d.Comando(tsql, True)
    End Function
#End Region
#Region "importacao"
    Public Function os_in_trans(ByVal tOS As DataSet, ByVal dsTrat As DataSet) As String
        Dim tbTrat As New DataTable
        Dim tbOs As New DataTable
        Dim tt As New DataTable
        Dim Trans As New objSqlTrans
        Dim i, m As Integer
        Dim resp As String
        Dim r As DataRow
        Dim os As New ObjOS(d, 1, "")
        Dim anda As New objAndamentos(d)
        Dim es As String
        Dim esf, cil As Double
        Dim ltab As New objTabela(d)
        Dim ordem As Integer = 1
        'Dim pedido As New objPedidoBalcao(d)
        tbTrat = dsTrat.Tables(0)
        tbOs = tOS.Tables(0)
        r = tbOs.Rows(0)
        os.filtra_os_cliente(r("id_filial"), r("cod_os"))
        If os.max = 0 Then
            ltab.filtra(rdNum(r("cod_tab_od")))
            If ltab.max > 0 Then
                If ltab.id_fabricante = 15 Or ltab.id_fabricante = 35 Or ltab.id_fabricante = 10 Then
                    Return "Produto processado pela matriz"
                    Exit Function
                End If
            End If
            ltab.filtra(rdNum(r("cod_tab_oe")))
            If ltab.max > 0 Then
                If ltab.id_fabricante = 15 Or ltab.id_fabricante = 35 Or ltab.id_fabricante = 10 Then
                    Return "Produto processado pela matriz"
                    Exit Function
                End If
            End If
            os.novo()
        Else
            If os.andamentos_os.Rows.Count = 0 Then
                Dim sql As String
                Dim rs As String
                sql = "Delete from tratamentos_os where cod_os = " & _
                os.cod_os & " and id_filial = " & os.id_filial & ""
                d.Comando(sql, True)
                sql = "Delete from os where cod_os = " & os.cod_os & _
                " and id_filial = " & os.id_filial & ""
                rs = d.Comando(sql, True)
                If rs.StartsWith("OK") Then
                    os.novo()
                    GoTo Insere_os
                Else
                    Return rs
                    Exit Function
                End If
            End If
            Return "OS já existe!"
            Exit Function
        End If
Insere_os:
        Try
            os.id_filial = 1
            os.cod_tab_od = rdNum(r("cod_tab_od"))
            os.cod_tab_oe = rdNum(r("cod_tab_oe"))
            os.cod_produto_od = rdNum(r("cod_produto_od"))
            os.cod_produto_oe = rdNum(r("cod_produto_oe"))

            os.esf_od_longe = rdNum(r("esf_od_longe"))
            os.cil_od_longe = rdNum(r("cil_od_longe"))
            os.esf_od_perto = rdNum(r("esf_od_perto"))
            os.cil_od_perto = rdNum(r("cil_od_perto"))
            os.dnp_od_longe = rdNum(r("dnp_od_longe"))
            os.dnp_od_perto = rdNum(r("dnp_od_perto"))
            os.base_od = rdNum(r("base_od"))
            os.adicao_od = rdNum(r("adicao_od"))
            os.altura_od = rdNum(r("altura_od"))
            os.diametro_od = rdNum(r("diametro_od"))
            os.eixo_od = rdNum(r("eixo_od"))

            os.esf_oe_longe = rdNum(r("esf_oe_longe"))
            os.cil_oe_longe = rdNum(r("cil_oe_longe"))
            os.esf_oe_perto = rdNum(r("esf_oe_perto"))
            os.cil_oe_perto = rdNum(r("cil_oe_perto"))
            os.dnp_oe_longe = rdNum(r("dnp_oe_longe"))
            os.dnp_oe_perto = rdNum(r("dnp_oe_perto"))
            os.base_oe = rdNum(r("base_oe"))
            os.adicao_oe = rdNum(r("adicao_oe"))
            os.altura_oe = rdNum(r("altura_oe"))
            os.diametro_oe = rdNum(r("diametro_oe"))
            os.eixo_oe = rdNum(r("eixo_oe"))

            os.aro_horizontal = rdNum(r("aro_horizontal"))
            os.aro_vertical = rdNum(r("aro_vertical"))
            os.maior_diametro = rdNum(r("maior_diametro"))
            os.ponte = rdNum(r("ponte"))
            os.cod_tipo_armacao = rdNum(r("cod_tipo_armacao"))
            os.crm_oftalmologista = rdNum(r("crm_oftalmologista"))

            os.cod_filial_cliente = 1
            os.doc_cliente = rdNum(r("cod_os"))
            os.cod_cliente = rdNum(r("id_filial"))
            os.data_venda = rdData(r("data_venda"))
            os.data_previsao_entrega = rdData(r("data_previsao_entrega"))
            os.hora_previsao_entrega = rdTexto(r("hora_previsao_entrega"))
            os.cod_vendedora = 2
            os.observacao = rdTexto(r("observacao"))
            os.nota_serie = rdTexto(r("nota_serie"))
            os.cod_verif_por = 2
            os.data_verificacao = rdData(r("data_verificacao"))
            os.cod_surfacagem = rdNum(r("cod_surfacagem"))
            os.cod_montagem = rdNum(r("cod_montagem"))
            os.confeccao = rdTexto(r("confeccao"))
            os.coloracao = rdNum(r("coloracao"))
            os.cor_coloracao = rdTexto(r("cor_coloracao"))
            os.cod_fase = Fases_os.Transmissao
            os.tipo_receita_OD = rdNum(r("tipo_receita_od"))
            os.tipo_receita_OE = rdNum(r("tipo_receita_oe"))
            os.id_laboratorio = rdNum(r("id_laboratorio")) 'Laboratorio Montagem
            os.cod_lab_surf = rdNum(r("cod_lab_surf"))

            If os.cod_tab_od <> 11060 Then
                es = ltab.ret_especie(os.cod_tab_od)
                If es.Trim = "B" Then
                    If os.cod_produto_od <> os.Ret_estoque_bloco(os.cod_tab_od, os.base_od, os.adicao_od, "D") Then
                        os.cod_produto_od = os.Ret_estoque_bloco(os.cod_tab_od, os.base_od, os.adicao_od, "D")
                    End If
                Else
                    If os.tipo_receita_OD = tipo_Receita.VISAO_simples_longe Then
                        esf = os.esf_od_longe
                        cil = os.cil_od_longe
                    Else
                        esf = os.esf_od_perto
                        cil = os.cil_od_perto
                    End If
                    If os.cod_produto_od <> os.Ret_estoque_lente(os.cod_tab_od, esf, cil) Then
                        os.cod_produto_od = os.Ret_estoque_lente(os.cod_tab_od, esf, cil)
                    End If
                End If

            End If
            If os.cod_tab_oe <> 11060 Then
                es = ltab.ret_especie(os.cod_tab_oe)
                If es.Trim = "B" Then
                    If os.cod_produto_oe <> os.Ret_estoque_bloco(os.cod_tab_oe, os.base_oe, os.adicao_oe, "E") Then
                        os.cod_produto_oe = os.Ret_estoque_bloco(os.cod_tab_oe, os.base_oe, os.adicao_oe, "E")
                    End If
                Else
                    If os.tipo_receita_OE = tipo_Receita.VISAO_simples_longe Then
                        esf = os.esf_oe_longe
                        cil = os.cil_oe_longe
                    Else
                        esf = os.esf_oe_perto
                        cil = os.cil_oe_perto
                    End If
                    If os.cod_produto_oe <> os.Ret_estoque_lente(os.cod_tab_oe, esf, cil) Then
                        os.cod_produto_oe = os.Ret_estoque_lente(os.cod_tab_oe, esf, cil)
                    End If
                End If
            End If
            os.cod_fase = Fases_os.Verificacao

            Trans.insere_instrucao(os.Salvar_transaction)
        Catch ex As Exception
            Return "Erro mroticaservice" & vbCrLf & ex.ToString
            Exit Function
        End Try
        Try
            andamentos = New objAndamentos(os.cod_os, os.id_filial, d)
            'Caso a os tenha sido inserida, coloca andamentos de inclusao e verificacao
            Trans.insere_instrucao(andamentos.insere_andamento_trans(objAndamentos.tipo.inclusao_os, os.id_filial, os.cod_os, _
            2, "Os em processo de importação com SQLTransaction", ordem))
            ordem = ordem + 1
            Trans.insere_instrucao(andamentos.insere_andamento_trans(objAndamentos.tipo.verificacao_os, os.id_filial, _
            os.cod_os, 2, "Os em processo de importação com SQLTransaction", ordem))
            ordem = ordem + 1
            'Importa os Tratamentos, caso haja algum
            i = 0
            m = tbTrat.Rows.Count

            While i < m
                tt = os.insere_tratamento_trans(tbTrat.Rows(i)("cod_produto"), 3, ordem)
                ordem = ordem + 1
                If tt.Rows.Count > 0 Then
                    For Each rt As DataRow In tt.Rows
                        Trans.insere_instrucao(rt(0).ToString)
                    Next
                End If
                i = i + 1
            End While
        Catch ex As Exception
            Return ex.ToString & vbCrLf & tt.Rows(0)(0).ToString
            Exit Function
        End Try
        'resp = "ER:" & tt.Rows.Count & vbCrLf & tt.Rows(1)(0).ToString
        resp = d.executa_transaction(Trans.instrucoes, True)
        'Try
        'If resp.StartsWith("OK") Then
        'Dim aut As New objAutorizacao(os.cod_cliente, os.cod_filial_cliente, d)
        'pedido.novo()
        'pedido.autorizacao = aut
        'resp = pedido.novo_pedido_otica(os)
        'End If
        'Catch ex As SoapException
        'resp = resp & vbCrLf & ex.ToString
        'End Try
        Return resp
    End Function

#End Region
    Dim lenteTabela As New objTabela
#Region "Bloco Digital"
    Public Function produto_od_estoque()
        lenteTabela.Source("Select * from lentes_tabela where cod_tabela = " & _cod_tab_od & "")
        If lenteTabela.especie = "BD" Then
            Return prod.Retorna_cod_prod(lenteTabela.bloco_digital.cod_origem, 0, _base_od, "A")
        Else
            Return _cod_produto_od
        End If
    End Function
    Public Function produto_estoque(ByVal cod_tab, ByVal base)
        lenteTabela.Source("Select * from lentes_tabela where cod_tabela = " & cod_tab & "")
        If lenteTabela.especie = "BD" Then
            Return prod.Retorna_cod_prod(lenteTabela.bloco_digital.cod_origem, 0, base, "A")
        Else
            Return Nothing
        End If
    End Function

    Public Function produto_oe_estoque()
        lenteTabela.Source("Select * from lentes_tabela where cod_tabela = " & _cod_tab_oe & "")
        If lenteTabela.especie = "BD" Then
            Return prod.Retorna_cod_prod(lenteTabela.bloco_digital.cod_origem, 0, _base_oe, "A")
        Else
            Return _cod_produto_oe
        End If
    End Function
#End Region
#Region "OS feita Fora"
    Dim anda As objAndamentos
    Dim mDet As New objMovimentoDetalhe
    Dim p As New produtoClass(d)
    Public Function processa_os_fora(ByVal fora As objContFora) As String
        Dim sql As String
        Dim mov As Integer
        Dim res As String
        Dim extra As New objSaidaExtra
        Try
            anda = New objAndamentos(_cod_os, _id_filial, d)
            mov = d.retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & loja & "")
            sql = "INSERT INTO movimentomaster (cod_movimento " & _
            ",cod_natureza,id_filial,data,doc,id_usuario,concluido) " & _
            "VALUES (" & _
            mov & _
            "," & 1 & _
            "," & loja & _
            "," & d.pdtm(fora.data_retorno) & _
            "," & d.PStr("OS.: " & adiciona_zeros(_id_filial, 3) & adiciona_zeros(_cod_os, 6)) & _
            ",3" & _
            ",'S')"
            res = d.Comando(sql, True)
            MsgBox(res)
            'Olho Direito
            If _cod_tab_od <> 0 Or _cod_tab_od <> 1 Or _cod_tab_od <> 2 Then
                If fora.OD = "S" Then insere_item(_cod_produto_od, 1, mov, fora.data_retorno)
            End If
            'Olho Esquerdo
            If _cod_tab_oe <> 0 Or _cod_tab_oe <> 1 Or _cod_tab_oe <> 2 Then
                If fora.OE = "S" Then insere_item(_cod_produto_oe, 1, mov, fora.data_retorno)
            End If
            extra.filtra(_cod_os, _id_filial, "N")
            If extra.max = 1 Then
                Return "EXTRA" & extra.cod_saida_extra
            Else
                baixa_os(fora)
                Return "OK"
            End If
        Catch ex As Exception
            Return "ER:" & ex.Message
        End Try
        Return True
    End Function
    Private Sub insere_item(ByVal _x_cod_prod As Integer, ByVal q As Double, ByVal M As Integer, ByVal d_proc As Date)
        Dim media_len, media_prod As Double
        Dim cod_len As Integer
        p.filtra(_x_cod_prod)
        mDet.novo()
        mDet.item = mDet.ret_ultimo_item(M)
        mDet.cod_movimento = M
        mDet.cod_produto = p.fldCod_produto
        mDet.quant = q
        mDet.desconto = p.Desconto_compra
        mDet.pUnit = p.Preco_compra
        mDet.estoqueFis = mDet.ret_saldo_fisico(p.fldCod_produto) + CDbl(q)
        mDet.estoqueFin = mDet.estoqueFis * ((p.Preco_compra - (p.Preco_compra * (p.Desconto_compra / 100))))
        '( +mDet.ret_saldo_fin(txtCodProd.Text)
        cod_len = mDet.retorna_cod_lentebloco(p.fldCod_produto)
        media_len = media_movel(mDet.ret_saldo_todos_fisico(cod_len), mDet.ret_saldo_todos_fin(cod_len), q, (p.Preco_compra) - (p.Preco_compra * (p.Desconto_compra / 100)))
        media_prod = media_movel(mDet.ret_saldo_fisico(p.fldCod_produto), mDet.ret_saldo_fin(p.fldCod_produto), q, (p.Preco_compra) - (p.Preco_compra * (p.Desconto_compra / 100)))
        mDet.atualiza_custo(cod_len, media_len, p.fldCod_produto, media_prod)
        mDet.historico = "Entrada Automatica OS " & adiciona_zeros(_id_filial, 3) & adiciona_zeros(_cod_os, 6)
        mDet.data_lancamento = d_proc
        mDet.Salvar()
        anda.insere_andamento(objAndamentos.tipo.aviso_os, _id_filial, _cod_os, 3, _
        "Produto " & p.Retorna_nome_prod(p.fldCod_produto) & " Entrou no Estoque! Origem: Laboratório Externo.")
    End Sub
    Private Sub baixa_os(ByVal fora As objContFora)
        Dim saida As New objSaidaOS
        Dim q As Integer = -1
        saida.novo()
        saida.cod_movimento = d.retorna_Chave("cod_movimento", "movimentomaster", " where id_filial = " & loja & "")
        saida.cod_saida_os = d.retorna_Chave("cod_saida_os", "saida_os", " where cod_movimento = " & saida.cod_movimento & " and id_filial = " & loja & "") + 1
        saida.cod_natureza = 2
        saida.cod_os = _cod_os
        saida.id_filial_os = _id_filial
        saida.data = fora.data_retorno
        saida.doc = "OS.: " & adiciona_zeros(_id_filial, 3) & adiciona_zeros(_cod_os, 6)
        saida.id_usuario = 3
        saida.Salvar()
        'Baixa estoque
        'OD
        If fora.OD = "S" Then
            p.Source("Select * from produtos where cod_produto = " & _cod_produto_od & "")
            mDet.novo()
            mDet.item = mDet.ret_ultimo_item(saida.cod_movimento)
            mDet.cod_movimento = saida.cod_movimento
            mDet.cod_produto = p.fldCod_produto
            mDet.quant = q
            mDet.desconto = 0
            mDet.pUnit = p.fldPreco_custo
            mDet.Pvenda = p.fldPreco_venda
            mDet.descVenda = p.fldDesconto
            mDet.estoqueFis = mDet.ret_saldo_fisico(_cod_produto_od) + CDbl(q)
            mDet.estoqueFin = mDet.ret_saldo_fin(_cod_produto_od) + ((p.fldPreco_custo) * q)
            mDet.historico = "Baixa do olho direito da OS. " & _id_filial & "-" & _cod_os
            mDet.data_lancamento = fora.data_retorno
            mDet.Salvar()
            anda.insere_andamento(objAndamentos.tipo.Baixa_os, _id_filial, _
            _cod_os, 3, "Baixa de Lente do Olho Direito")
        End If
        'OE
        If fora.OE = "S" Then
            p.Source("Select * from produtos where cod_produto = " & _cod_produto_oe & "")
            mDet.novo()
            mDet.item = mDet.ret_ultimo_item(saida.cod_movimento)
            mDet.cod_movimento = saida.cod_movimento
            mDet.cod_produto = p.fldCod_produto
            mDet.quant = q
            mDet.desconto = 0
            mDet.pUnit = p.fldPreco_custo
            mDet.Pvenda = p.fldPreco_venda
            mDet.descVenda = p.fldDesconto
            mDet.estoqueFis = mDet.ret_saldo_fisico(_cod_produto_od) + CDbl(q)
            mDet.estoqueFin = mDet.ret_saldo_fin(_cod_produto_od) + ((p.fldPreco_custo) * q)
            mDet.historico = "Baixa do olho direito da OS. " & _id_filial & "-" & _cod_os
            mDet.data_lancamento = fora.data_retorno
            mDet.Salvar()
            anda.insere_andamento(objAndamentos.tipo.Baixa_os, _id_filial, _
            _cod_os, 3, "Baixa de Lente do Olho Esquerdo")
        End If
    End Sub

    Public Function row_editado() As String
        Dim editado As Boolean = False
        Dim Edit As String = ""
        With tb.Rows(posicao)
            If rdNum(.Item("num_pedido")) <> rdNum(_num_pedido) Then
                editado = True
            End If
            If rdNum(.Item("cod_tab_od")) <> rdNum(_cod_tab_od) Then
                editado = True
                Edit = Edit & " Trocado cod_tab_od de " & rdNum(.Item("cod_tab_od")) & _
                " para " & rdNum(_cod_tab_od) & ". "
            End If
            If rdNum(.Item("cod_tab_oe")) <> rdNum(_cod_tab_oe) Then
                editado = True
                Edit = Edit & " Trocado cod_tab_oe de " & rdNum(.Item("cod_tab_oe")) & _
                " para " & rdNum(_cod_tab_oe) & ". "
            End If
            If rdNum(.Item("cod_produto_od")) <> rdNum(_cod_produto_od) Then
                editado = True
                Edit = Edit & " Trocado cod_produto_od de " & rdNum(.Item("cod_produto_od")) & _
               " para " & rdNum(_cod_produto_od) & ". "
            End If

            If rdNum(.Item("cod_produto_oe")) <> rdNum(_cod_produto_oe) Then
                editado = True
                Edit = Edit & " Trocado cod_produto_oe de " & rdNum(.Item("cod_produto_oe")) & _
               " para " & rdNum(_cod_produto_oe) & ". "
            End If
            If rdNum(.Item("esf_od_longe")) <> rdNum(_esf_od_longe) Then
                editado = True
                Edit = Edit & " Trocado esf OD Longe de " & rdNum(.Item("esf_od_longe")) & _
                                " para " & rdNum(_esf_od_longe) & ". "

            End If
            If rdNum(.Item("cil_od_longe")) <> rdNum(_cil_od_longe) Then
                editado = True
                Edit = Edit & " Trocado Cil OD Longe de " & rdNum(.Item("cil_od_longe")) & _
                                " para " & rdNum(_cil_od_longe) & ". "
            End If
            If rdNum(.Item("esf_od_perto")) <> rdNum(_esf_od_perto) Then
                editado = True
                Edit = Edit & " Trocado esf OD perto de " & rdNum(.Item("esf_od_perto")) & _
                                " para " & rdNum(_esf_od_perto) & ". "

            End If
            If rdNum(.Item("cil_od_perto")) <> rdNum(_cil_od_perto) Then
                editado = True
                Edit = Edit & " Trocado cil OD perto de " & rdNum(.Item("cil_od_perto")) & _
                                " para " & rdNum(_cil_od_perto) & ". "

            End If
            If rdNum(.Item("dnp_od_longe")) <> rdNum(_dnp_od_longe) Then
                editado = True
                Edit = Edit & " Trocado DNP OD Longe de " & rdNum(.Item("dnp_od_longe")) & _
                                " para " & rdNum(_dnp_od_longe) & ". "

            End If
            If rdNum(.Item("dnp_od_perto")) <> rdNum(_dnp_od_perto) Then
                editado = True
                Edit = Edit & " Trocado DNP OD Perto de " & rdNum(.Item("dnp_od_perto")) & _
                                " para " & rdNum(_dnp_od_perto) & ". "

            End If
            If rdNum(.Item("base_od")) <> rdNum(_base_od) Then
                editado = True
            End If
            If rdNum(.Item("adicao_od")) <> rdNum(_adicao_od) Then
                editado = True
                Edit = Edit & " Trocado Adição OD de " & rdNum(.Item("adicao_od")) & _
                                " para " & rdNum(_adicao_od) & ". "

            End If
            If rdNum(.Item("altura_od")) <> rdNum(_altura_od) Then
                editado = True
                Edit = Edit & " Trocado Altura OD de " & rdNum(.Item("altura_od")) & _
                                " para " & rdNum(_altura_od) & ". "

            End If
            If rdNum(.Item("diametro_od")) <> rdNum(_diametro_od) Then
                editado = True
            End If
            If rdNum(.Item("diametro_oe")) <> rdNum(_diametro_oe) Then
                editado = True
            End If
            If rdNum(.Item("eixo_od")) <> rdNum(_eixo_od) Then
                editado = True
                Edit = Edit & " Trocado Eixo OD de " & rdNum(.Item("eixo_od")) & _
                                " para " & rdNum(_eixo_od) & ". "
            End If

            If rdNum(.Item("esf_oe_longe")) <> rdNum(_esf_oe_longe) Then
                editado = True
                Edit = Edit & " Trocado Esf OE longe de " & rdNum(.Item("esf_oe_longe")) & _
                                " para " & rdNum(_esf_oe_longe) & ". "

            End If

            If rdNum(.Item("cil_oe_longe")) <> rdNum(_cil_oe_longe) Then
                editado = True
                Edit = Edit & " Trocado Cil OE longe de " & rdNum(.Item("cil_oe_longe")) & _
                                " para " & rdNum(_cil_oe_longe) & ". "

            End If

            If rdNum(.Item("esf_oe_perto")) <> rdNum(_esf_oe_perto) Then
                editado = True
                Edit = Edit & " Trocado Esf OE perto de " & rdNum(.Item("esf_oe_perto")) & _
                                " para " & rdNum(_esf_oe_perto) & ". "

            End If

            If rdNum(.Item("cil_oe_perto")) <> rdNum(_cil_oe_perto) Then
                editado = True
                Edit = Edit & " Trocado cil OE perto de " & rdNum(.Item("cil_oe_perto")) & _
                                " para " & rdNum(_cil_oe_perto) & ". "

            End If

            If rdNum(.Item("dnp_oe_longe")) <> rdNum(_dnp_oe_longe) Then
                editado = True
                Edit = Edit & " Trocado DNP OE longe de " & rdNum(.Item("dnp_oe_longe")) & _
                                " para " & rdNum(_dnp_oe_longe) & ". "

            End If
            If rdNum(.Item("dnp_oe_perto")) <> rdNum(_dnp_oe_perto) Then
                editado = True
                Edit = Edit & " Trocado DNP OE perto de " & rdNum(.Item("dnp_oe_perto")) & _
                                " para " & rdNum(_dnp_oe_perto) & ". "

            End If

            If rdNum(.Item("base_oe")) <> rdNum(_base_oe) Then
                editado = True
            End If
            If rdNum(.Item("adicao_oe")) <> rdNum(_adicao_oe) Then
                editado = True
                Edit = Edit & " Trocado Adicao OE de " & rdNum(.Item("adicao_oe")) & _
                                " para " & rdNum(_adicao_oe) & ". "

            End If
            If rdNum(.Item("altura_oe")) <> rdNum(_altura_oe) Then
                editado = True
                Edit = Edit & " Trocado Altura OE de " & rdNum(.Item("altura_oe")) & _
                                " para " & rdNum(_altura_oe) & ". "
            End If

            If rdNum(.Item("diametro_oe")) <> rdNum(_diametro_oe) Then
                editado = True
            End If
            If rdNum(.Item("eixo_oe")) <> rdNum(_eixo_oe) Then
                editado = True
                Edit = Edit & " Trocado Eixo OE de " & rdNum(.Item("eixo_oe")) & _
                                " para " & rdNum(_eixo_oe) & ". "

            End If

            If rdNum(.Item("aro_horizontal")) <> rdNum(_aro_horizontal) Then
                editado = True
                Edit = Edit & " Aro Horizontal de " & rdNum(.Item("aro_horizontal")) & _
                                " para " & rdNum(_aro_horizontal) & ". "

            End If

            If rdNum(.Item("aro_vertical")) <> rdNum(_aro_vertical) Then
                editado = True
                Edit = Edit & " Aro Vertical de " & rdNum(.Item("aro_Vertical")) & _
                                " para " & rdNum(_aro_vertical) & ". "

            End If

            If rdNum(.Item("maior_diametro")) <> rdNum(_maior_diametro) Then
                editado = True
                Edit = Edit & " Maior Diâmetro de " & rdNum(.Item("maior_diametro")) & _
                                " para " & rdNum(_maior_diametro) & ". "

            End If

            If rdNum(.Item("ponte")) <> rdNum(_ponte) Then
                editado = True
                Edit = Edit & " Ponte de " & rdNum(.Item("ponte")) & _
                                " para " & rdNum(_ponte) & ". "

            End If

            If rdNum(.Item("cod_tipo_armacao")) <> rdNum(_cod_Tipo_Armacao) Then
                editado = True
            End If

            If rdNum(.Item("crm_oftalmologista")) <> rdNum(_crm_oftalmologista) Then
                editado = True
            End If

            If rdNum(.Item("cod_filial_cliente")) <> rdNum(_cod_filial_cliente) Then
                editado = True
            End If
            If rdNum(.Item("cod_cliente")) <> rdNum(_cod_cliente) Then
                editado = True
            End If
            If rdData(.Item("Data_venda")) <> rdData(_data_venda) Then
                editado = True
            End If
            If rdData(.Item("data_previsao_entrega")) <> rdData(_data_previsao_entrega) Then
                editado = True
            End If
            If rdTexto(.Item("hora_previsao_entrega")) <> rdTexto(_hora_previsao_entrega) Then
                editado = True
            End If
            If rdNum(.Item("cod_vendedora")) <> rdNum(_cod_vendedora) Then
                editado = True
            End If
            If rdNum(.Item("cod_qfez")) <> rdNum(_cod_qfez) Then
                editado = True
            End If
            If rdTexto(.Item("observacao")) <> rdTexto(_observacao) Then
                editado = True
            End If

            If rdTexto(.Item("nota_serie")) <> rdTexto(_nota_serie) Then
                editado = True
            End If

            If rdNum(.Item("cod_verif_por")) <> rdNum(_cod_verif_por) Then
                editado = True
            End If

            If rdData(.Item("data_verificacao")) <> rdData(_data_verificacao) Then
                editado = True
            End If

            If rdNum(.Item("cod_surfacagem")) <> rdNum(_cod_surfacagem) Then
                editado = True
            End If

            If rdNum(.Item("cod_montagem")) <> rdNum(_cod_montagem) Then
                editado = True
            End If

            If rdTexto(.Item("confeccao")) <> rdTexto(_confeccao) Then editado = True
            If rdNum(.Item("coloracao")) <> rdNum(_coloracao) Then editado = True
            If rdTexto(.Item("cor_coloracao")) <> rdTexto(_cor_coloracao) Then editado = True
            If rdData(.Item("data_recebimento")) <> rdData(_data_recebimento) Then editado = True
            If rdData(.Item("data_fim_servico")) <> rdData(_data_fim_servico) Then editado = True
            If rdNum(.Item("cod_fase")) <> rdNum(_cod_fase) Then editado = True
            If rdNum(.Item("tipo_receita_od")) <> rdNum(_tipo_receita_OD) Then editado = True
            If rdNum(.Item("tipo_receita_oe")) <> rdNum(_tipo_receita_OE) Then editado = True
            If rdNum(.Item("id_laboratorio")) <> rdNum(_id_laboratorio) Then editado = True
            If rdNum(.Item("doc_cliente")) <> rdNum(_doc_cliente) Then editado = True
            If rdNum(.Item("cod_lab_surf")) <> rdNum(_cod_lab_surf) Then editado = True
        End With
        If editado = True Then
            Return "OK:" & Edit
        Else
            Return "ER:"
        End If
    End Function
#End Region
End Class
