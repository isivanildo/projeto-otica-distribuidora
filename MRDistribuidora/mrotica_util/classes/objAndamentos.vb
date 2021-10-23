Public Class objAndamentos
    Dim d As New dados()
    Dim os As ObjOS
    Dim x_cod_os, x_id_filial As Integer
    Dim ultimo As tipo
    Public Sub New(ByVal os, ByVal filial)
        x_cod_os = os
        x_id_filial = filial
    End Sub
    Public Sub New(ByVal os As Integer, ByVal filial As Integer, ByVal xdados As dados)
        d = xdados
        x_cod_os = os
        x_id_filial = filial
    End Sub
    Public Sub New(ByVal xdados As dados)
        d = xdados
    End Sub
    Public Sub New()

    End Sub
    Public Enum tipo As Integer
        'Loja
        inclusao_os = 101
        alteracao_os = 102
        verificacao_os = 103
        recebido_laboratorio = 104
        entregue_cliente = 105
        Solicita_alt_OS_loja = 106
        'Estoque
        Reserva_lente = 201
        sugestao_pedido = 202
        Cancela_reserva_lente = 203
        Cancela_sugestao_pedido = 204
        Troca_base = 205
        Troca_produto = 206
        Prod_solicitado_fornecedor = 207
        prod_chegou_forn = 208
        Baixa_os = 209
        impressao_os = 210
        reimpressao_os = 211
        retirada_os_laboratorio = 212
        alteracao_os_estoque = 213
        solicita_transf_estoque = 214
        chegou_transf_estoque = 215
        devolucao_estoque = 216
        desverificacao_estoque = 217
        Pausa_os_estoque = 218
        Envio_fazer_fora = 219
        Retorno_fazer_fora = 220
        'Surfaçagem
        Calculo = 301
        Eixo_fita = 302
        Blocagem = 303
        sl2 = 304
        Lixa_polimento = 305
        Retificacao = 306
        solicitaccao_saida_extra = 307
        solicitacao_troca_base = 308
        solicitacao_troca_produto = 309
        surfacagem_fora = 310
        'Controle de Qualidade
        x1ª_conferencia_montagem = 401
        x1ª_conferencia_tratamento = 402
        reprovado_controle_qualidade = 403
        x2ª_conferencia_montagem = 404
        Termino_controle_qualidade = 405
        'Tratamento
        Anti_risco = 501
        Enviado_tratamento = 502
        retorno_tratamento = 503
        'Montagem
        Leitor = 601
        Faceta = 602
        Coloracao = 603
        encaixe = 604
        Parafusado = 605
        'Expedição & Controle
        aviso_os = 701
        malote_loja = 702

    End Enum
    Public Enum setor As Integer
        aviso = 0
        Balcão_loja = 1
        estoque = 2
        surfaçagem = 3
        controle_Qualidade = 4
        controle_tratamento = 5
        montagem = 6
        expedicao_controle = 7
    End Enum
    Public Function insere_andamento(ByVal tipo As tipo, ByVal id_filial As Integer, ByVal cod_os As Integer, _
    ByVal usuario As Integer, ByVal desc As String) As String
        Dim sql As String
        Dim ordem As Integer
        Dim r As String
        ordem = ordem_and(cod_os, id_filial)
        os = New ObjOS(cod_os, id_filial, d)
        Select Case tipo
            Case objAndamentos.tipo.solicitacao_troca_base
                GoTo REGISTRA
            Case objAndamentos.tipo.solicitacao_troca_produto
                GoTo REGISTRA
            Case objAndamentos.tipo.solicitaccao_saida_extra
                GoTo REGISTRA
            Case tipo.reprovado_controle_qualidade
                GoTo REGISTRA
            Case objAndamentos.tipo.aviso_os
                GoTo REGISTRA
        End Select
        If setor_and(tipo) = 3 Or setor_and(tipo) = 4 Or setor_and(tipo) = 5 Or _
        setor_and(tipo) = 6 Or setor_and(tipo) = setor.expedicao_controle Then
            r = avalia_andamentos_prod(tipo, id_filial, cod_os)
            If r.Substring(0, 3) = "ER:" Then
                Return r
                Exit Function
            End If
        End If
REGISTRA:
        If tipo = objAndamentos.tipo.reprovado_controle_qualidade Then
            desc = InputBox("Digite o motivo da reprovação!")
        End If
        sql = "INSERT INTO andamentos " &
           "(id_filial " &
           ",cod_os" &
           ",id_filial_andamento" &
           ",ordem" &
           ",data" &
           ",cod_andamento" &
           ",cod_usuario" &
           ",cod_status_andamento" &
           ",Observacao)" &
           " VALUES( " &
           id_filial &
           "," & cod_os &
           "," & confFilial &
           "," & ordem &
           "," & d.pdtm(d.hora) &
           "," & tipo &
           "," & usuario &
           ",1" &
           "," & d.PStr(desc) & ")"
        r = d.Comando(sql, True) & " Andamento"
        If r.Substring(0, 3) = "OK:" Then
            muda_fase(cod_os, id_filial, tipo)
        End If
        Return r
    End Function
    Public Function insere_andamento_trans(ByVal tipo As tipo, ByVal id_filial As Integer, ByVal cod_os As Integer, _
    ByVal usuario As Integer, ByVal desc As String, ByVal ordem As Integer) As String
        'Retorna a instrução sql do andamento para a transaction
        Dim sql As String
        Dim r As String
        'ordem = ordem_and(cod_os, id_filial)
        os = New ObjOS(cod_os, id_filial, d)
        Select Case tipo
            Case objAndamentos.tipo.solicitacao_troca_base
                GoTo REGISTRA
            Case objAndamentos.tipo.solicitacao_troca_produto
                GoTo REGISTRA
            Case objAndamentos.tipo.solicitaccao_saida_extra
                GoTo REGISTRA
            Case tipo.reprovado_controle_qualidade
                GoTo REGISTRA
            Case objAndamentos.tipo.aviso_os
                GoTo REGISTRA
            Case objAndamentos.tipo.malote_loja
                GoTo REGISTRA
        End Select
        If setor_and(tipo) = 3 Or setor_and(tipo) = 4 Or setor_and(tipo) = 5 Or _
        setor_and(tipo) = 6 Or setor_and(tipo) = setor.expedicao_controle Then
            r = avalia_andamentos_prod(tipo, id_filial, cod_os)
            If r.Substring(0, 3) = "ER:" Then
                Return r
                Exit Function
            End If
        End If
REGISTRA:
        If tipo = objAndamentos.tipo.reprovado_controle_qualidade Then
            desc = InputBox("Digite o motivo da reprovação!")
        End If
        sql = "INSERT INTO andamentos " &
           "(id_filial " &
           ",cod_os" &
           ",id_filial_andamento" &
           ",ordem" &
           ",data" &
           ",cod_andamento" &
           ",cod_usuario" &
           ",cod_status_andamento" &
           ",Observacao)" &
           " VALUES( " &
           id_filial &
           "," & cod_os &
           "," & confFilial &
           "," & ordem &
           "," & d.pdtm(d.hora) &
           "," & tipo &
           "," & usuario &
           ",1" &
           "," & d.PStr(desc) & ")"
        Return sql
    End Function
    Private Function ordem_and(ByVal cod_os As Integer, ByVal id_filial As Integer) As Integer
        Dim tt As New DataTable
        Dim sql As String
        sql = "Select max(ordem) as chave from andamentos where cod_os = " & cod_os & " and id_filial = " & id_filial & ""
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 0 Then
            Return 1
        Else
            If IsDBNull(tt.Rows(0)(0)) = True Then Return 1 Else Return tt.Rows(0)(0) + 1
        End If
    End Function
    Private Function avalia_andamentos_prod(ByVal x_tipo As tipo, ByVal id_filial As Integer, ByVal cod_os As Integer) As String
        Dim sql As String
        Dim tabela As New DataTable
        os = New ObjOS(cod_os, id_filial, d)
        If andamento_existe(cod_os, id_filial, x_tipo) = True Then
            'Caso o andamento já tenha sido efetuado, 
            Return "ER:Este andamento já existe, não podem haver dois andamentos do mesmo tipo para " & _
            "a produção! Caso o andamento anterior seja inválido, contate o responsável pelo laboratório " & _
            "e solicite o cancelamento do andamento!"
            Exit Function
        End If

        'Verifica se a OS está aguardando manuseio
        'caso esteja, sómente andamentos de surfaçagem ou controle de qualidade
        'podem ser efetuados
        If os.cod_fase = Fases_os.Expedição Then
            GoTo montagem
        End If
        If os.cod_fase = Fases_os.Laboratório_aguardando_manuseio Then
            Select Case setor_and(x_tipo)
                Case setor.surfaçagem
                    GoTo Surfaçagem
                Case setor.controle_Qualidade
                    GoTo controle_de_qualidade
                Case setor.expedicao_controle
                    GoTo expedicao
            End Select
        End If
        'Fim bloco

        'Verifica se a OS está na Surfaçagem
        If os.cod_fase = Fases_os.Laboratório_Surfaçagem Then
            Select Case setor_and(x_tipo)
                Case setor.surfaçagem
                    GoTo Surfaçagem
                Case setor.controle_Qualidade
                    GoTo controle_de_qualidade
            End Select
        End If
        'Verifica se a OS está no Controle de Qualidade
        If os.cod_fase = Fases_os.Laboratório_Controle_de_Qualidade Then
            Select Case setor_and(x_tipo)
                Case setor.controle_Qualidade
                    GoTo controle_de_qualidade
                Case setor.controle_tratamento
                    GoTo Tratamento
                Case setor.montagem
                    GoTo montagem
                Case setor.expedicao_controle
                    GoTo expedicao
            End Select
        End If

        'Verifica se a OS está na Montagem
        If os.cod_fase = Fases_os.Laboratório_Montagem Then
            Select Case setor_and(x_tipo)
                Case setor.controle_Qualidade
                    GoTo controle_de_qualidade
                Case setor.montagem
                    GoTo montagem
                Case setor.controle_tratamento
                    GoTo Tratamento
            End Select
        End If

        'verifica se a OS está aguardando tratamento
        If os.cod_fase = Fases_os.Tratamento_Aguardando_Retorno Then
            Select Case setor_and(x_tipo)
                Case setor.controle_Qualidade
                    GoTo controle_de_qualidade
                Case setor.controle_tratamento
                    GoTo Tratamento
            End Select
        End If

        'Se nenhuma das condições for atendida, retorna erro.
Retorna_erro:
        Return "ER:Andamento não pode ser realizado! Verifique a ordem de andamentos e em que fase a " & _
        "OS está! Fase da OS: " & os.retorna_fase_str & ". Último andamento: " & retorna_andamento_str( _
        ultimo_andamento(cod_os, id_filial)) & "."
        Exit Function
        'Blocos para tratar por setor
Surfaçagem:
        'verifica se o setor de Andamentos é o 3, Surfaçagem
        If setor_and(x_tipo) = 3 Then
            Dim t As New DataTable
            Dim q, Ord As Integer
            t = andamentos_setor_ord(3)
            os = New ObjOS(cod_os, id_filial, d)
            'Verifica se os produtos da OS são blocos, caso contrário, 
            'não poderá haver andamentos de surfaçagem.
            If os.tem_bloco() = False Then
                Return "ER:Nenhum dos produtos da OS é um bloco, esta os não pode receber " & _
                "andamentos de surfaçagem"
                Exit Function
            End If
            If x_tipo = tipo.surfacagem_fora Then
                Return "OK:"
            End If
            If t.Rows.Count = 0 Then
                Ord = 0
                'Caso Não haja outros andamentos de surfaçagem, o único 
                'possível é Cálculo
                If x_tipo = tipo.Calculo Then
                    Return "OK:"
                Else
                    GoTo Retorna_erro
                End If
            Else
                q = t.Rows.Count
                Ord = t.Rows(q - 1)("ordem_setor")
                Debug.Print("Ordem " & Ord)
                Select Case Ord
                    Case 1
                        Debug.Print("Eixo/Fita")
                        'O último andamento foi Cálculo, o único andamento 
                        'Possível é Eixo/Fita
                        If x_tipo = tipo.Eixo_fita Then
                            Return "OK:"
                        Else
                            GoTo Retorna_erro
                        End If
                    Case 2
                        Debug.Print("Blocagem")
                        'O ÚLtimo andamento foi Eixo/FIta, o único andamento 
                        'Possível é Blocagem
                        If x_tipo = tipo.Blocagem Then
                            Return "OK:"
                        Else
                            GoTo Retorna_erro
                        End If
                    Case 3
                        Debug.Print("SL2")
                        'O ÚLtimo andamento foi Blocagem, o único andamento 
                        'Possível é SL2
                        If x_tipo = tipo.sl2 Then
                            Return "OK:"
                        Else
                            GoTo Retorna_erro
                        End If
                    Case 4
                        Debug.Print("Lixa/Polimento")
                        'O último andamento foi SL2, o único andamento possível
                        'é Lixa / Polimento.
                        If x_tipo = tipo.Lixa_polimento Then
                            Return "OK:"
                        Else
                            GoTo Retorna_erro
                        End If
                End Select
            End If

        Else
            GoTo Retorna_erro
        End If
controle_de_qualidade:
        'Verifica se o setor de Andametos é o 4, Controle de Qualidade.
        If setor_and(x_tipo) = setor.controle_Qualidade Then
            Select Case x_tipo
                '1ª Conferência Início
                Case tipo.x1ª_conferencia_montagem
                    ultimo = ultimo_andamento(cod_os, id_filial)
                    If os.cod_lab_surf = 999999 And andamento_existe(os.cod_os, os.id_filial, tipo.Retorno_fazer_fora) = True Then
                        Return "OK:"
                    End If
                    If os.tem_tratamento = True Then
                        Return "ER:Esta OS tem tratamento e deve ser liberada " & _
                        "primeiro para tratamento!"
                    End If
                    If os.tem_anti_risco = True Then
                        Return "ER:Esta OS tem anti-risco e deve ser liberada " & _
                        "primeiro para tratamento!"
                    End If
                    If os.tem_bloco = True Then
                        If ultimo = tipo.Lixa_polimento Then
                            Return "OK:"
                        Else
                            Return "ER:Esta OS tem bloco para surfaçar, deve primeiro " & _
                                   "passar pela surfaçagem!"
                        End If
                    End If
                    If ultimo = tipo.retirada_os_laboratorio Then
                        Return "OK:"
                    Else
                        If ultimo = tipo.Lixa_polimento Or ultimo = tipo.surfacagem_fora Then
                            Return "OK:"
                        Else
                            GoTo Retorna_erro
                        End If
                    End If
                    '1ª Conferência Fim
                    '1ª Conferência Tratamento inicio
                Case tipo.x1ª_conferencia_tratamento
                    ultimo = ultimo_andamento(cod_os, id_filial)
                    If os.tem_tratamento = False Then
                        If os.tem_anti_risco = False Then
                            Return "ER:Esta OS não tem tratamento nem anti-risco " & _
                            "e deve ser liberada para montagem!"
                        End If
                    End If

                    If ultimo = tipo.retirada_os_laboratorio And os.tem_bloco = False Then
                        Return "OK:"
                    Else
                        If ultimo = tipo.Lixa_polimento Or ultimo = tipo.surfacagem_fora Then
                            Return "OK:"
                        Else
                            GoTo Retorna_erro
                        End If
                    End If
                    '1ª Conferência Tratamento Fim
                    '2ª Conferência Início
                Case tipo.x2ª_conferencia_montagem
                    Dim penultimo As Integer
                    Dim antepenultimo As Integer
                    ultimo = ultimo_andamento(cod_os, id_filial)
                    penultimo = penultimo_andamento(cod_os, id_filial)
                    antepenultimo = antepenultimo_andamento(cod_os, id_filial)
                    If ultimo = tipo.retorno_tratamento Or ultimo _
                    = tipo.Anti_risco Or penultimo = tipo.retorno_tratamento Or antepenultimo = tipo.Retorno_fazer_fora _
                    Or ultimo = tipo.Coloracao Then
                        Debug.Print("2ª Conf. ultimo")
                        Return "OK:"
                    Else
                        GoTo Retorna_erro
                    End If
                    '2ª Conferência Fim
                    'Término do Controle de Qualidade Inicio
                Case tipo.Termino_controle_qualidade
                    If (os.tem_coloracao = True) And (os.tem_montagem = False) Then
                        If andamento_existe(os.cod_os, os.id_filial, tipo.Coloracao) = True Then
                            Debug.Print(os.tem_coloracao & " " & x_tipo)
                            'Caso o Último andamento seja ordem 2,
                            'e tiver coloração, o único andamento
                            'possível é coloração
                            Return "OK:"
                        Else
                            GoTo Retorna_erro
                        End If
                    End If
                    ultimo = ultimo_andamento(cod_os, id_filial)
                    If (ultimo = tipo.encaixe Or ultimo = tipo.Parafusado) Then
                        Return "OK:"
                    Else
                        GoTo Retorna_erro
                    End If
                    'Término do Controle de Qualidade Fim
                    'Reprovado Controle de qualidade Inicio

            End Select
        Else
            GoTo Retorna_erro
        End If
Tratamento:
        'Verifica se o Setor é o 5, Tratamento.
        If setor_and(x_tipo) = setor.controle_tratamento Then
            ultimo = ultimo_andamento(cod_os, id_filial)
            Debug.Print("Controle Tratamento")
            Debug.Print("Último " & ultimo)
            Debug.Print("Andamento: " & x_tipo)
            Select Case x_tipo
                'Inicio Enviado para Tratamento
                Case tipo.Enviado_tratamento
                    If os.tem_tratamento = False Then
                        Return "ER:Essa OS não tem tratamento!"
                    Else
                        If os.tem_coloracao = True Then
                            If ultimo = tipo.Coloracao Then
                                Return "OK:Tratamento com coloração"
                            Else
                                Return "ER:É preciso colorir antes de enviar p/ tratamento!"
                            End If
                        Else
                            If ultimo = tipo.x1ª_conferencia_tratamento Or ultimo = tipo.Anti_risco Then
                                Return "OK:"
                            Else
                                GoTo Retorna_erro
                            End If
                        End If
                    End If
                    'Fim Enviado para Tratamento
                    'inicio Retorna Tratamento
                Case tipo.retorno_tratamento
                    If ultimo <> tipo.Enviado_tratamento Then
                        Return "ER:É preciso enviar para o tratameto primeiro!"
                    Else
                        Return "OK:"
                    End If
                    'fim retorna tratamento
                    'inicio Anti-risco
                Case tipo.Anti_risco
                    Debug.Print("Anti-Risco " & os.tem_anti_risco)
                    If os.tem_anti_risco = False Then
                        Return "ER:Essa OS não tem anti-risco"
                    End If
                    If ultimo = tipo.x1ª_conferencia_tratamento Then
                        Debug.Print("OK.")
                        Return "OK:"
                    Else
                        GoTo Retorna_erro
                    End If
                    'Fim Anti-risco
                    'Inicio Coloração
            End Select
        Else
            GoTo Retorna_erro
        End If
montagem:
        'Verifica se o setor é o 6, montagem
        If setor_and(x_tipo) = 6 Then
            ultimo = ultimo_andamento(cod_os, id_filial)
            Debug.Print("Montagem!")
            Dim t As New DataTable
            Dim q, Ord As Integer
            If (os.tem_anti_risco = True Or os.tem_tratamento = True) Then
                Debug.Print(ultimo)
                If andamento_existe(cod_os, id_filial, tipo.x1ª_conferencia_tratamento) = True Then
                    If x_tipo = tipo.Coloracao Then
                        Return "OK:Coloração com tratamento."
                    End If
                End If
                If andamento_existe(cod_os, id_filial, tipo.x2ª_conferencia_montagem) = False Then
                    Return "ER:Esta OS tem tratamentos e deve" & _
                    " passar pela 2ª " & _
                    "conferência antes de montar!"
                End If

            End If
            'Retorna os andamentos ordenados já efetuados de
            'montagem.
            t = andamentos_setor_ord(6, os.tem_coloracao)
            If t.Rows.Count = 0 Then
                Ord = 0
                'Como não há nenhum outro andamento de montagem,
                'o único andamento que pode ser executado é
                'o leitor Gama.

                If (os.tem_coloracao = True) And (os.tem_montagem = False) Then
                    If andamento_existe(os.cod_os, os.id_filial, tipo.Coloracao) = False Then
                        Debug.Print(os.tem_coloracao & " " & x_tipo)
                        'Caso o Último andamento seja ordem 2,
                        'e tiver coloração, o único andamento
                        'possível é coloração
                        If x_tipo = tipo.Coloracao Then
                            Return "OK:"
                        Else
                            Return "ER:Esta OS tem coloração! É preciso colorir " & _
                            "antes de concluir a montagem!"
                        End If
                    End If
                End If

                If x_tipo = objAndamentos.tipo.Leitor Then
                    Return "OK:"
                Else
                    GoTo Retorna_erro
                End If
            Else
                q = t.Rows.Count
                Ord = t.Rows(q - 1)("ordem_setor")
                Debug.Print("Ordem " & Ord)
                Select Case Ord
                    Case 1
                        'Caso o último andamento seja ordem 1,
                        'Faceta deverá ser o próximo.
                        If x_tipo = objAndamentos.tipo.Faceta Then
                            Return "OK:"
                            Exit Function
                        Else
                            GoTo Retorna_erro
                        End If
                    Case 2
                        If (os.tem_coloracao = True) Then
                            If andamento_existe(os.cod_os, os.id_filial, tipo.Coloracao) = True _
                            And os.tem_montagem = True Then
                                GoTo fim_montagem
                            End If
                            Debug.Print(os.tem_coloracao & " " & x_tipo)
                            'Caso o Último andamento seja ordem 2,
                            'e tiver coloração, o único andamento
                            'possível é coloração
                            If x_tipo = tipo.Coloracao Then
                                Return "OK:"
                            Else
                                Return "ER:Esta OS tem coloração! É preciso colorir " & _
                                "antes de concluir a montagem!"
                            End If
                        Else
                            GoTo fim_montagem
                        End If
                        'Fim Coloração

                    Case 3
fim_montagem:
                        Select Case x_tipo
                            Case objAndamentos.tipo.Parafusado
                                If é_parafusado() = True Then
                                    Return "OK:"
                                Else
                                    Return "ER:O tipo de armação da OS não é Parafusada. " & _
                                    "Este andamento só pode ser dado para armações " & _
                                    "parafusadas!Se você concluiu esta montagem " & _
                                    ", use o andamento ENCAIXE!"
                                    Exit Function
                                End If
                            Case objAndamentos.tipo.encaixe
                                If é_parafusado() = False Then
                                    Return "OK:"
                                Else
                                    Return "ER:O tipo de armação da OS é Parafusada. " & _
                                    "Se você concluiu esta montagem " & _
                                    ", use o andamento PARAFUSADO!"
                                    Exit Function
                                End If
                        End Select
                        GoTo Retorna_erro
                    Case 4
                        'Os andamentos possíveis já foram dados.
                        GoTo Retorna_erro
                End Select
            End If
        Else
            GoTo Retorna_erro
        End If
        'fim bloco Montagem
        'Início Bloco Expedição
expedicao:
        If setor_and(x_tipo) = 7 Then
            ultimo = ultimo_andamento(cod_os, id_filial)
            Debug.Print("Expedição!")
            Dim t As New DataTable
            If ultimo = tipo.retirada_os_laboratorio Then
                If os.cod_cliente < 999 Then
                    Return "OK:"
                End If
            End If
            If ultimo = tipo.x1ª_conferencia_montagem Or _
            ultimo = tipo.Termino_controle_qualidade Or _
            ultimo = tipo.x2ª_conferencia_montagem Then
                Return "OK:"
            Else
                GoTo Retorna_erro
            End If
        Else
            GoTo Retorna_erro
        End If
        'Fim Bloco Expedição
    End Function
    
    Private Function setor_and(ByVal tipo As tipo) As setor
        Dim sql As String
        Dim tbSetor As New DataTable
        sql = "Select cod_setor from tipo_andamento where " & _
        " cod_andamento = " & tipo & ""
        d.carrega_Tabela(sql, tbSetor)
        Try
            Return tbSetor.Rows(0)(0)
        Catch ex As Exception
            Return setor.aviso
        End Try
    End Function
    Private Function ultimo_andamento(ByVal cod_os As Integer, ByVal id_filial As Integer) As tipo
        Dim tabela As New DataTable
        os = New ObjOS(cod_os, id_filial, d)
        tabela = os.andamentos_os_validos(True)
        Try
            Return tabela.Rows(tabela.Rows.Count - 1)("cod_andamento")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Function penultimo_andamento(ByVal cod_os As Integer, ByVal id_filial As Integer) As tipo
        Dim tabela As New DataTable
        os = New ObjOS(cod_os, id_filial, d)
        tabela = os.andamentos_os_validos(True)
        Try
            Return tabela.Rows(tabela.Rows.Count - 2)("cod_andamento")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Function antepenultimo_andamento(ByVal cod_os As Integer, ByVal id_filial As Integer) As tipo
        Dim tabela As New DataTable
        os = New ObjOS(cod_os, id_filial, d)
        tabela = os.andamentos_os_validos(True)
        Try
            Return tabela.Rows(tabela.Rows.Count - 3)("cod_andamento")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Function tem_controle(ByVal cod_os As Integer, ByVal id_filial As Integer) As Boolean
        Dim dv As New DataView
        os = New ObjOS(cod_os, id_filial, d)
    End Function
    Private Sub muda_fase(ByVal cod_os As Integer, ByVal id_filial As Integer, ByVal tipo As tipo)
        os = New ObjOS(cod_os, id_filial, d)
        If tipo = objAndamentos.tipo.retirada_os_laboratorio Then
            os.editar()
            os.cod_fase = Fases_os.Laboratório_aguardando_manuseio
            os.Salvar()
        End If
        If setor_and(tipo) = 3 Then
            If tipo = objAndamentos.tipo.solicitacao_troca_produto Then
                os.editar()
                os.cod_fase = Fases_os.Estoque_aguardando_troca_produto
                os.Salvar()
                Exit Sub
            End If
            If tipo = objAndamentos.tipo.solicitaccao_saida_extra Then
                os.editar()
                os.cod_fase = Fases_os.Estoque_aguardando_Saída_extra
                os.Salvar()
                Exit Sub
            End If
            os.editar()
            os.cod_fase = Fases_os.Laboratório_Surfaçagem
            os.Salvar()
        End If
        If setor_and(tipo) = 4 Then
            os.editar()
            os.cod_fase = Fases_os.Laboratório_Controle_de_Qualidade
            os.Salvar()
        End If
        If setor_and(tipo) = 5 And tipo <> objAndamentos.tipo.Anti_risco Then
            os.editar()
            os.cod_fase = Fases_os.Tratamento_Aguardando_Retorno
            os.Salvar()
        End If
        If setor_and(tipo) = 6 Then
            os.editar()
            os.cod_fase = Fases_os.Laboratório_Montagem
            os.Salvar()
        End If
        If setor_and(tipo) = setor.expedicao_controle Then
            os.editar()
            os.cod_fase = Fases_os.Expedição
            os.Salvar()
        End If

    End Sub
    Private Function retorna_andamento_str(ByVal cod As Integer) As String
        Dim sql As String
        Dim tbt As New DataTable
        sql = "select andamento from tipo_andamento where cod_andamento = " & cod & ""
        d.carrega_Tabela(sql, tbt)
        Return tbt.Rows(0)("andamento")
    End Function
    Private Function andamentos_setor_and(ByVal setor As Integer) As DataTable
        Dim sql As String
        Dim tbAnd As New DataTable
        sql = "SELECT     andamentos.*, tipo_andamento.ordem_setor " & _
        "FROM andamentos INNER JOIN tipo_andamento ON andamentos.cod_andamento = " & _
        "tipo_andamento.cod_andamento WHERE " & _
        "(tipo_andamento.cod_setor = " & setor & ") AND " & _
        "(andamentos.id_filial = " & x_id_filial & ") " & _
        "AND (andamentos.cod_os = " & x_cod_os & ") " & _
        " ORDER BY andamentos.ordem"
        d.carrega_Tabela(sql, tbAnd)
        Return tbAnd
    End Function
    Private Function andamentos_setor_ord(ByVal setor As Integer) As DataTable
        Dim sql As String
        Dim tbAnd As New DataTable
        sql = "SELECT     andamentos.*, tipo_andamento.ordem_setor " & _
        "FROM andamentos INNER JOIN tipo_andamento ON andamentos.cod_andamento = " & _
        "tipo_andamento.cod_andamento WHERE " & _
        "(tipo_andamento.cod_setor = " & setor & ") AND " & _
        "(andamentos.id_filial = " & x_id_filial & ") " & _
        "AND (andamentos.cod_os = " & x_cod_os & ") " & _
        "AND (andamentos.cod_status_andamento = 1) " & _
        "AND (tipo_andamento.ordem_setor IS NOT NULL) "
        sql = sql & " ORDER BY andamentos.ordem"
        d.carrega_Tabela(sql, tbAnd)
        Return tbAnd
    End Function
    Private Function andamentos_setor_ord(ByVal setor As Integer, ByVal coloracao_e_tratamento As Boolean) As DataTable
        Dim sql As String
        Dim tbAnd As New DataTable
        sql = "SELECT     andamentos.*, tipo_andamento.ordem_setor " & _
        "FROM andamentos INNER JOIN tipo_andamento ON andamentos.cod_andamento = " & _
        "tipo_andamento.cod_andamento WHERE " & _
        "(tipo_andamento.cod_setor = " & setor & ") AND " & _
        "(andamentos.id_filial = " & x_id_filial & ") " & _
        "AND (andamentos.cod_os = " & x_cod_os & ") " & _
        "AND (andamentos.cod_status_andamento = 1) " & _
        "AND (tipo_andamento.ordem_setor IS NOT NULL) "
        If coloracao_e_tratamento = True Then
            sql = sql & " and (andamentos.cod_andamento <> 603) "
        End If
        sql = sql & " ORDER BY andamentos.ordem"
        d.carrega_Tabela(sql, tbAnd)
        Return tbAnd
    End Function
    Private Function é_parafusado() As Boolean
        Dim sql As String
        Dim tt As New DataTable
        '16081
        sql = "select cod_tipo_armacao from os where " & _
        "(cod_os = " & x_cod_os & ") and (id_filial = " & _
        x_id_filial & ") and (cod_tipo_armacao = 1)"
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function
    Private Function andamento_existe(ByVal cod_os As Integer, ByVal id_filial As Integer, ByVal x_tipo As tipo) As Boolean
        Dim sql As String
        Dim tt As New DataTable
        sql = "SELECT andamentos.*, tipo_andamento.cod_setor, tipo_andamento.ordem_setor " & _
        "FROM andamentos INNER JOIN tipo_andamento ON andamentos.cod_andamento = " & _
        "tipo_andamento.cod_andamento WHERE (andamentos.id_filial = " & id_filial & ") AND " & _
        "(andamentos.cod_os = " & cod_os & ") AND (andamentos.cod_andamento = " & _
        x_tipo & ") AND (andamentos.cod_status_andamento = 1)"
        d.carrega_Tabela(sql, tt)
        If tt.Rows.Count > 0 Then Return True Else Return False
    End Function
    Public Function cancela_andamentos_producao(ByVal obs As String) As String
        Dim sql As String
        sql = "UPDATE    andamentos set cod_status_andamento = 2, " & _
        " observacao = " & d.PStr(obs) & _
        " FROM andamentos INNER JOIN tipo_andamento ON andamentos.cod_andamento = " & _
        "tipo_andamento.cod_andamento WHERE (andamentos.id_filial = " & x_id_filial & _
        ") AND (andamentos.cod_os = " & x_cod_os & ") and (" & _
        "(tipo_andamento.cod_setor = 3) OR " & _
        "(tipo_andamento.cod_setor = 4) OR " & _
        "(tipo_andamento.cod_setor = 5) OR " & _
         "(tipo_andamento.cod_setor = 6) OR " & _
        "(tipo_andamento.cod_setor = 7)) and " & _
        "((andamentos.cod_andamento <> 307) and " & _
        "(andamentos.cod_andamento <> 403))"
        Return d.Comando(sql, True)
    End Function
    Public Function exclui_andamento(ByVal filial As Integer, ByVal cod_os As Integer, ByVal ord As Integer) As String
        Dim tsql As String
        Dim res As String
        tsql = "delete from andamentos where cod_os = " & cod_os & " and id_filial = " & filial & " and ordem = " & ord
        Try
            res = d.Comando(tsql, True)
        Catch ex As Exception
            res = "ER: " & ex.Message
        End Try
        Return res
    End Function
End Class
