Imports mrotica_util
Public Class frmImportaResolution
    Dim tb As New DataTable
    Dim linha As String
    Dim txt As String()
    Dim cod_lente, intDesenho As Integer
    Dim strNome, diametro, barrad, barrae, olho, strBarra As String
    Dim base, adicao, esf, cil As Double
    Private Sub btnCarregaResponse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregaResponse.Click
        Dim i As Integer = 0
        pb.Maximum = txtResponse.Lines.Length
        pb.Value = 0
        While i < txtResponse.Lines.Length
            linha = txtResponse.Lines(i)
            txt = linha.Split(",")
            'nome = txt(2)
            intDesenho = desenho(txt(6))
            barrad = tiraAspas(txt(10))
            barrae = tiraAspas(txt(11))
            diametro = txtDiametro.Text
            If i = 0 Then Salva_lente()
            If txtTipo.Text = "B" Then
                base = Replace(txt(13), ".", ",")
                adicao = Replace(txt(14), ".", ",")
                If barrad = barrae Then
                    olho = "A"
                    strBarra = barrad
                    salva_blocos()
                Else
                    olho = "D"
                    strBarra = barrad
                    salva_blocos()
                    olho = "E"
                    strBarra = barrae
                    salva_blocos()
                    Application.DoEvents()
                End If
            Else
                esf = Replace(txt(13), ".", ",")
                cil = Replace(txt(14), ".", ",")
                strBarra = barrad
                salva_lentes()
                Application.DoEvents()
            End If
            i = i + 1
            pb.Value = i
        End While
    End Sub
    Private Function desenho(ByVal d As String) As desenho
        Dim str As String
        d = tiraAspas(d)
        str = d.Substring(0, 2)
        Select Case str
            Case "SV"
                Return _mod.desenho.SV
            Case "PR"
                Return _mod.desenho.PAL
        End Select
    End Function
    Private Function tiraAspas(ByVal str As String) As String
        Dim s As String = """"
        Return str.Replace(s, "")
    End Function
    Private Sub frmImportaResolution_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Salva_lente()
        Dim res As String
        Dim lb As New objLentes
        'chave = retorna_Chave("codCliente", "clientes") + 1
        lb.novo()
        lb.cod_lente = cod_lente
        lb.id_fabricante = 70
        lb.cod_tipo_lente = intDesenho
        lb.nome_lente = txtNome.Text
        lb.especie = strTipo
        lb.cod_tabela = txtCodTabela.Text
        'lb.esf_maior = pnum(txtEsfMaior.Text)
        'lb.esf_menor = pnum(txtEsfMenor.Text)
        If txtTipo.Text = "B" Then lb.cil_menor = -4 Else lb.cil_menor = -2
        lb.especie = txtTipo.Text
        lb.diametro = diametro
        res = lb.Salvar()
        If res.Trim.Substring(0, 3) = "OK:" Then
            MsgBox(res.Trim.Substring(3))
            cod_lente = lb.cod_lente
        End If
        If res.Trim.Substring(0, 3) = "ER:" Then
            MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
            lb.ultima_posicao()
        End If
    End Sub
    Private Sub salva_blocos()
        Dim b As New objblocos
        Dim p As New produtoClass
        'INSERINDO BASES PARA MULTIFOCAL
        b.lista_blocos(70, cod_lente)
        b.novo()
        p.novo()
        p.fldCod_barra = strBarra
        p.fld_id_fabricante = 70
        p.fldcod_grupo = 1
        p.Cod_lente = cod_lente
        p.fldProduto = txtNome.Text & " Base " & base & " Adição " & adicao & " olho " & olho
        Dim res As String
        res = p.Salvar(produtoClass.tiposalvar.Normal)
        If res.Trim.Substring(0, 3) = "OK:" Then

        End If
        If res.Trim.Substring(0, 3) = "ER:" Then
            MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
        End If
salva_lente:
        b.cod_produto = p.fldCod_produto
        b.base = base
        b.adicao = adicao
        b.olho = olho
        'b.esf_maior = txtEsfMaiorBloco.Text
        'b.esf_menor = txtEsfMenorBloco.Text
        b.barra = strBarra
        res = b.Salvar()
        If res.Trim.Substring(0, 3) = "OK:" Then

        End If
        If res.Trim.Substring(0, 3) = "ER:" Then
            MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
        End If
        'FIM INSERINDO BASES MULTIFOCAL
    End Sub
    Private Sub salva_lentes()
        Dim p As New produtoClass
        Dim l As New objLentesDiop
        Dim res As String
        p.novo()
        l.novo()
        p.fldCod_barra = strBarra
        p.fld_id_fabricante = 70
        p.fldcod_grupo = 1
        p.Cod_lente = cod_lente
        p.fldProduto = txtNome.Text & " " & esf & " com " & cil
        res = p.Salvar(produtoClass.tiposalvar.Normal)
        If res.Trim.Substring(0, 3) = "OK:" Then
            'MsgBox(res.Trim.Substring(3))
        End If
        If res.Trim.Substring(0, 3) = "ER:" Then
            MsgBox(trata_erro(res.Trim.Substring(3)), MsgBoxStyle.Critical)
        End If
salva_lente:
        l.cod_produto = p.fldCod_produto
        l.esferico = esf
        l.cilindrico = cil
        res = l.Salvar()
    End Sub

End Class