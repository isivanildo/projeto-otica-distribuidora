Imports DFe
Imports NFe
Imports NFe.Utils.NFe
Imports NFe.Classes.Informacoes
Imports NFe.Classes.Informacoes.Detalhe
Imports System.Collections.Generic
Imports mrotica_util

Public Class frmRelacaoCodFornecedorSistema
    Dim p As New produtoClass
    Private Sub frmRelacaoCodFornecedorSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click

    End Sub
    Private Sub carregaGrid(ByVal it As List(Of itemNfImp))
        grdProd.DataSource = it
        grdProd.Columns(0).Width = 80
        grdProd.Columns(1).Width = 300
        grdProd.Columns(2).Width = 80
        grdProd.Columns(3).Width = 300
        grdProd.Columns(4).Width = 80


    End Sub


End Class
Public Class itemNfImp
    Dim _codbarra As String
    Dim _produto As String
    Dim _codSis As String
    Dim _nomeSis As String
    Dim _valor As Double
    Public Property codbarra
        Get
            codbarra = _codbarra
        End Get
        Set(value)
            _codbarra = value
        End Set
    End Property
    Public Property produto
        Get
            produto = _produto
        End Get
        Set(value)
            _produto = value
        End Set
    End Property
    Public Property codSis
        Get
            codSis = _codSis
        End Get
        Set(value)
            _codSis = value
        End Set
    End Property
    Public Property nomeSis
        Get
            nomeSis = _nomeSis
        End Get
        Set(value)
            _nomeSis = value
        End Set
    End Property
    Public Property valor
        Get
            valor = _valor
        End Get
        Set(value)
            _valor = value
        End Set
    End Property
End Class