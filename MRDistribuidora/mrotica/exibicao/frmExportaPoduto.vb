Imports mrotica_util
Public Class frmExportaPoduto
    Dim d As New dados
    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim ds As New DataSet
        Dim anaService As New anamaria.Service
        Dim tipo As String
        Dim tab As Long
        Dim l As New objLentesDiop
        Dim TTab, tLB, tPrd As New DataTable
        Try
            ds.Clear()
            tab = InputBox("Código da Tabela")
            tipo = InputBox("Tipo:")
            ds = Importa_produto(tab, tipo)
            txtStatus.Text = anaService.exporta_produto(ds, tipo, tab)
        Catch ex As Exception
            txtStatus.Text = ex.ToString
        End Try
    End Sub
    Public Function Importa_produto(ByVal x_cod_tabela As Long, ByVal tipo As String) As DataSet
        Dim sql As String
        Dim ds As New DataSet
        Dim t1, t2, t3 As New DataTable
        Dim ftr As String
        Dim i, m As Integer
        i = 0
        sql = "Select * from lentes_tabela where cod_tabela = " & x_cod_tabela & ""
        d.carrega_Tabela(sql, t1)
        t1.TableName = "lentes_tabela"
        ds.Tables.Add(t1.Copy)
        sql = "Select * from lentes_blocos where cod_tabela = " & x_cod_tabela & ""
        d.carrega_Tabela(sql, t2)
        t2.TableName = "Lente_blocos"
        ds.Tables.Add(t2.Copy)
        If tipo = "B" Then
            i = 0
            m = t2.Rows.Count
            sql = "SELECT produtos.*, blocos.*  FROM produtos INNER JOIN " & _
            " blocos ON produtos.cod_produto = blocos.Cod_produto "
            While i < m
                If i = 0 Then
                    ftr = " where produtos.cod_lente = " & t2.Rows(i)("cod_lente")
                Else
                    ftr = ftr & " or produtos.cod_lente = " & t2.Rows(i)("cod_lente")
                End If
                i = i + 1
            End While
            sql = sql & ftr
            d.carrega_Tabela(sql, t3)
            t3.TableName = "Produtos"
            ds.Tables.Add(t3.Copy)
        Else
            m = t2.Rows.Count
            sql = "SELECT produtos.*, lentes.* FROM produtos INNER JOIN " & _
                 "lentes ON produtos.cod_produto = lentes.cod_produto "
            i = 0
            While i < m
                If i = 0 Then
                    ftr = " where produtos.cod_lente = " & t2.Rows(i)("cod_lente")
                Else
                    ftr = ftr & " or produtos.cod_lente = " & t2.Rows(i)("cod_lente")
                End If
                i = i + 1
            End While
            sql = sql & ftr
            d.carrega_Tabela(sql, t3)
            t3.TableName = "Produtos"
            ds.Tables.Add(t3.Copy)
        End If
        Return ds
    End Function
End Class