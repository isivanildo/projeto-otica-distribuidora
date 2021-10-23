Imports System.Data
Public Class dados
    Public con As New SqlClient.SqlConnection
    Dim connstr As String = "user id=belemtech;data source=.\SQLEXPRESS;persist security info=True;initial catalog=winlabo " &
       ";password=Belemtech123;pooling=true;timeout=60"
    Private m_FieldInfo As ArrayList, m_FieldList As String
    Private GroupByFieldInfo As ArrayList, GroupByFieldList As String
    Dim conf As config
#Region "Dados"
    Public Sub New()
        conf = New config
        connstr = String.Format("user id=" & conf.usuarioSql & ";data source=" & conf.servidorDB & ";persist security info=True;initial catalog=" & conf.Banco &
       ";password=" & conf.senha & ";pooling=true;timeout=60")
    End Sub
    Public Sub New(ByVal usuario As String, ByVal senha As String, ByVal servidor As String, ByVal db As String)
        connstr = String.Format("user id=" & usuario & ";data source=" & servidor & ";persist security info=True;initial catalog=" & db & _
      ";password=" & senha & ";pooling=true;timeout=240")
    End Sub
    Public Function conecta() As String
inicio:
        Dim resultado As String = ""
        If con.State = ConnectionState.Open Then
            Return True
            Exit Function
        End If
        'connstr = String.Format("data source=desenvolvimento\sqlexpress;persist security info=True;initial catalog=mrotica_loja; Integrated Security=yes;pooling=true ")
        'connstr = String.Format("user id=" & conf.usuarioSql & ";data source=" & conf.servidorSQL & ";persist security info=True;initial catalog=" & conf.dbmrotica & _
        '";password=" & conf.SenhaSql & ";pooling=true;timeout=240")
        'connStr = String.Format("server=" & confServer & ";user id=root; password=eaddrml; database=ti_manager_dbo; pooling=false")
        con.ConnectionString = connstr
        Try
            con.Open()
            resultado = True
        Catch ex As Exception
            resultado = False
            'Return ex.Message & vbCrLf & connstr
            con.Dispose()
        End Try
        Return resultado
    End Function
    Public Sub desconecta()
        con.Dispose()
        con.Close()
    End Sub
    Public Function carrega_Tabela(ByVal sql As String, ByRef tabela As Data.DataTable) As String
        Dim cmdDados As New SqlClient.SqlCommand
        Dim daDados As New SqlClient.SqlDataAdapter
        Dim dsDados As New Data.DataSet
        Try
            conecta()
            cmdDados.Connection = con
            cmdDados.CommandTimeout = 240
            cmdDados.CommandText = sql
            daDados.SelectCommand = cmdDados
            daDados.Fill(dsDados)
            tabela = dsDados.Tables(0)
        Catch ex As Exception
            Return "ER: " & ex.Message & vbCrLf & sql & vbCrLf & connstr
        End Try
        cmdDados.Dispose()
        daDados.Dispose()
        dsDados.Dispose()
        desconecta()
        Return "OK;"
    End Function

    Public Function carrega_Tabela_novo(ByVal sql As String, ByRef tabela As Data.DataTable) As DataTable
        Dim cmdDados As New SqlClient.SqlCommand
        Dim daDados As New SqlClient.SqlDataAdapter
        Dim dsDados As New Data.DataSet
        Try
            conecta()
            cmdDados.Connection = con
            cmdDados.CommandTimeout = 240
            cmdDados.CommandText = sql
            daDados.SelectCommand = cmdDados
            daDados.Fill(dsDados)
            tabela = dsDados.Tables(0)
        Catch ex As Exception
            'Return "ER: " & ex.Message & vbCrLf & sql & vbCrLf & connstr
        End Try
        cmdDados.Dispose()
        daDados.Dispose()
        dsDados.Dispose()
        desconecta()
        Return tabela
        'Return "OK;"
    End Function

    Public Sub carrega_ds(ByVal sql As String, ByRef ds As Data.DataSet)
        Dim cmdDados As New SqlClient.SqlCommand
        Dim daDados As New SqlClient.SqlDataAdapter
        Try
            conecta()
            cmdDados.Connection = con
            cmdDados.CommandText = sql
            daDados.SelectCommand = cmdDados
            ds.Clear()
            daDados.Fill(ds)
        Catch ex As Exception
            'MsgBox(ex.Message & vbCrLf & sql)
        End Try
        cmdDados.Dispose()
        daDados.Dispose()
    End Sub
    Public Sub carrega_ds_noclear(ByVal sql As String, ByRef ds As Data.DataSet)
        Dim cmdDados As New SqlClient.SqlCommand
        Dim daDados As New SqlClient.SqlDataAdapter
        Try
            conecta()
            cmdDados.Connection = con
            cmdDados.CommandText = sql
            daDados.SelectCommand = cmdDados
            daDados.Fill(ds)
        Catch ex As Exception
            'MsgBox(ex.Message & vbCrLf & sql)
        End Try
        cmdDados.Dispose()
        daDados.Dispose()
    End Sub
    Public Sub carrega_reader(ByVal sql As String, ByRef rd As SqlClient.SqlDataReader)
        Dim cmdDados As New SqlClient.SqlCommand
        Try
            conecta()
            cmdDados.Connection = con
            cmdDados.CommandText = sql
            rd = cmdDados.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        cmdDados.Dispose()
    End Sub
    Public Function retorna_Chave(ByVal fld As String, ByVal tbl As String, ByVal criterio As String) As String
        Dim tabela As New DataTable
        Dim sql As String
        Dim v As Integer
        Try
            sql = "Select max(" & fld & ") as chave from " & tbl & " " & criterio
            carrega_Tabela(sql, tabela)
            If IsDBNull(tabela.Rows(0)("chave")) = True Then v = 0 Else v = tabela.Rows(0)("chave")
            Return v + 1
        Catch ex As Exception
            Return sql
        End Try
        tabela.Dispose()
    End Function
    Public Function retorna_Chave(ByVal fld As String, ByVal tbl As String) As Integer
        Dim tabela As New DataTable
        Dim sql As String
        Dim v As Integer
        sql = "Select max(" & fld & ") as chave from " & tbl & ""
        carrega_Tabela(sql, tabela)
        If IsDBNull(tabela.Rows(0)("chave")) = True Then v = 0 Else v = tabela.Rows(0)("chave")
        Return v
        tabela.Dispose()
    End Function
    Public Function Comando(ByVal sql As String, ByVal exporta As Boolean) As String
        Dim cmd As New SqlClient.SqlCommand
        Dim res As String
        Dim r_fila As String
        conecta()
        cmd.Connection = con
        cmd.CommandText = sql
        Try
            res = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Return "ER:" & ex.ToString & vbCrLf & sql 'Retorna o prefixo ER: para indicar erro e a descrição do erro
            Exit Function
        End Try
        If exporta = True Then
            r_fila = fila(sql.ToString)
        End If
        desconecta()
        Return "OK: " & res & " registro(s)" & vbCrLf & " Fila de exportação: " & r_fila & " "
    End Function

    Public Function ComandoSQL(ByVal sql As String, ByVal exporta As Boolean) As String
        Dim r_fila As String
        If exporta = True Then
            r_fila = fila(sql.ToString)
        End If
        desconecta()
        Return "Exportado para a fila de exportação."
    End Function

    Public Function fila(ByVal sqlexp As String) As Boolean
        Dim tabela As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        Dim res As Integer = 0
        Dim sql As String
        Dim tSql As String
        Dim i, m As Integer
        Return True
        Exit Function
        If sqlexp.ToUpper.Contains("INSERT INTO PRODUTOS") _
            Or sqlexp.ToUpper.Contains("DELETE FROM PRODUTOS") _
            Or sqlexp.ToUpper.Contains("UPDATE PRODUTOS") _
            Or sqlexp.ToUpper.Contains("INSERT INTO LENTES_TABELA") _
            Or sqlexp.ToUpper.Contains("DELETE FROM LENTES_TABELA") _
            Or sqlexp.ToUpper.Contains("UPDATE LENTES_TABELA") _
            Or sqlexp.ToUpper.Contains("INSERT INTO LENTES_BLOCOS") _
            Or sqlexp.ToUpper.Contains("DELETE FROM LENTES_BLOCOS") _
            Or sqlexp.ToUpper.Contains("UPDATE LENTES_BLOCOS") _
            Or sqlexp.ToUpper.Contains("INSERT INTO LENTES") _
            Or sqlexp.ToUpper.Contains("DELETE FROM LENTES") _
            Or sqlexp.ToUpper.Contains("UPDATE LENTES") _
            Or sqlexp.ToUpper.Contains("INSERT INTO BLOCOS") _
            Or sqlexp.ToUpper.Contains("DELETE FROM BLOCOS") _
            Or sqlexp.ToUpper.Contains("UPDATE BLOCOS") _
            Or sqlexp.ToUpper.Contains("INSERT INTO SERVICOS") _
            Or sqlexp.ToUpper.Contains("DELETE FROM SERVICOS") _
            Or sqlexp.ToUpper.Contains("INSERT INTO FAMILIA_LENTES") _
            Or sqlexp.ToUpper.Contains("UPDATE FAMILIA_LENTES") _
            Or sqlexp.ToUpper.Contains("DELETE FROM FAMILIA_LENTES") _
            Or sqlexp.ToUpper.Contains("INSERT INTO FAMILIA_LENTES_ITENS") _
            Or sqlexp.ToUpper.Contains("UPDATE FAMILIA_LENTES_ITENS") _
            Or sqlexp.ToUpper.Contains("DELETE FROM FAMILIA_LENTES_ITENS") _
            Or sqlexp.ToUpper.Contains("INSERT INTO BLOCO_SURFACADO") _
            Or sqlexp.ToUpper.Contains("UPDATE BLOCO_SURFACADO") _
            Or sqlexp.ToUpper.Contains("DELETE FROM BLOCO_SURFACADO") _
            Or sqlexp.ToUpper.Contains("INSERT LENTE_CONTATO") _
            Or sqlexp.ToUpper.Contains("UPDATE LENTE_CONTATO") _
            Or sqlexp.ToUpper.Contains("DELETE LENTE_CONTATO") Then
            tSql = "Insert into fila_exportacao_produtos(id_fila,instrucao,data_inclusao)" & _
            " values(" & retorna_Chave("id_fila", "fila_exportacao_produtos") + 1 & "," & _
            PStr(inst_fila(sqlexp)) & "," & pdtm(Now.ToString) & ")"
            Comando(tSql, False)
        End If
        Try
            If conf.Filial = 0 Or conf.Filial = 1 Then
                carrega_Tabela("Select id_filial from almoxarifado where id_filial <> 0 and id_filial <> 1", tabela)
                i = 0
                m = tabela.Rows.Count
                While i < m
                    sql = "Insert into fila_exportacao(id_fila,origem,gerado,destino,instrucao,data_inclusao) values(" &
                      retorna_Chave("id_fila", "fila_exportacao") + 1 &
                      "," & confFilial & "," & confFilial & "," & tabela.Rows(i)("id_filial") & "," &
                      PStr(inst_fila(sqlexp)) & "," & pdtm(Now.ToString) & ")"
                    Comando(sql, False)
                    i = i + 1
                End While
            Else
                sql = "Insert into fila_exportacao(id_fila,origem,gerado,destino,instrucao,data_inclusao) values(" &
                      retorna_Chave("id_fila", "fila_exportacao", " where origem = " & conf.Filial) + 1 &
                      "," & conf.Filial & "," & conf.Filial & ", 1," &
                      PStr(inst_fila(sqlexp)) & "," & pdtm(Now.ToString) & ")"
                Comando(sql, False)
            End If
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Public Function inst_fila(ByVal sql As String) As String
        sql = Replace(sql, "'", "`")
        Return sql
    End Function
    Public Function executa_transaction(ByRef sqlList As DataTable, ByVal exporta As Boolean) As String
        Dim cmd As New SqlClient.SqlCommand
        Dim trans As SqlClient.SqlTransaction
        Dim res As String = ""
        Dim isql As String
        Dim instList As String = ""
        Dim r_fila As String = ""
        'sqlList.Columns.Add("Instrucao")
        conecta()
        trans = con.BeginTransaction()
        cmd.Connection = con
        cmd.Transaction = trans
        Try
            For Each r As DataRow In sqlList.Rows
                isql = r("instrucao")
                instList = instList & vbCrLf & isql
                cmd.CommandText = isql
                cmd.ExecuteNonQuery()
            Next
            trans.Commit()
        Catch ex As Exception
            Try
                trans.Rollback()
            Catch e As Exception
                Return "ER:" & e.ToString & vbCrLf & instList
            End Try
            Return "ER:" & ex.ToString & vbCrLf & instList 'Retorna o prefixo ER: para indicar erro e a descrição do erro
            Exit Function
        End Try
        If exporta = True Then
            For Each r As DataRow In sqlList.Rows
                r_fila = r_fila & vbTab & fila(r("instrucao"))
            Next
        End If
        desconecta()
        Return "OK: Transação Concluída com êxito!" & vbCrLf & " Fila de exportação: " & r_fila & " "
    End Function

    Public Function hora() As Date
        Dim sql As String
        Dim t As New DataTable
        sql = "Select getdate()"
        carrega_Tabela(sql, t)
        Return (t.Rows(0)(0))
    End Function
#End Region
#Region "Formata Dados"
    Public Function pdtm(ByVal TheDate As Object) As String
        If IsDBNull(TheDate) = True Then Return "NULL"
        If CStr(TheDate) = "" Or TheDate = Nothing Then
            Return "NULL"
        End If
        Dim str As String
        Dim TDate As Date
        TDate = Convert.ToDateTime(TheDate)
        With TDate
            str = (.Year.ToString.PadLeft(2, Convert.ToChar("0")) & .Month.ToString.PadLeft(2, Convert.ToChar("0")) & .Day.ToString.PadLeft(2, Convert.ToChar("0")) & " " & .Hour.ToString.PadLeft(2, Convert.ToChar("0")) & ":" & .Minute.ToString.PadLeft(2, Convert.ToChar("0")) & ":" & .Second.ToString.PadLeft(2, Convert.ToChar("0")) & ":" & .Millisecond.ToString.PadLeft(2, Convert.ToChar("0")))
        End With
        Return "'" & str & "'"
    End Function
    Public Function PStr(ByVal strValue As Object) As String
        If IsDBNull(strValue) Then GoTo nulo
        If strValue = Nothing Then
            Return "NULL"
        End If
        If CStr(strValue).Trim() = "" Then
nulo:
            Return "NULL"
        Else
            Return "'" & CStr(strValue).Trim() & "'"
        End If
    End Function
    Public Function Pcb(ByVal strValue As String) As String
        If strValue = Nothing Then
            Return "NULL"
        End If
        If strValue.Trim() = "" Then
            Return "NULL"
        Else
            Return strValue.Trim()
        End If
    End Function
    Public Function Pdt(ByVal strValue As Object) As String
        If IsDBNull(strValue) = True Then
            Return "NULL"
        Else
            strValue = CStr(strValue)
        End If
        Dim m, d, y, dt As String
        If strValue = "00:00:00" Then
            Return "NULL"
        End If
        If strValue = Nothing Then
            Return "NULL"
        End If
        If strValue.Trim() = "" Or strValue.Trim() = "__/__/____" Then
            Return "NULL"
        Else
            d = DateAndTime.Day(strValue)
            If Len(d) = 1 Then d = "0" & d
            m = DateAndTime.Month(strValue)
            If Len(m) = 1 Then m = "0" & m
            y = DateAndTime.Year(strValue)
            dt = y & m & d
            Return "'" & dt & "'"
        End If
    End Function
    Public Function readNum(ByVal cn As Object) As Double
        'Avalia o valor numérico retornado do banco de dados,
        'se for nulo retorna vazio.
        Try
            cn = CStr(cn)
            If cn = "" Then Return Nothing
        Catch ex As Exception

        End Try

        Try
            If IsDBNull(cn) = True Then Return Nothing Else Return (cn)
        Catch ex As Exception

        End Try

    End Function
    Public Function cdin(ByVal valor As Object) As String
        If IsDBNull(valor) Then valor = Nothing
        Try
            If valor.ToString = 0 Then Return Replace(CDbl(valor), ",", ".")
        Catch ex As Exception

        End Try

        If valor = Nothing Then Return "NULL"
        Return Replace(CDbl(valor), ",", ".")
    End Function
    Public Function cdinShow(ByVal valor As String) As String
        Return Format(Replace(valor, ".", ","), "Currency")
    End Function
    Public Function So_Numeros(ByVal Campo As String) As String
        Dim Retorno As String = ""
        For I As Integer = 0 To Campo.Length - 1
            For K As Integer = 0 To 9
                If K.ToString() = Campo.Substring(I, 1) Then
                    Retorno += Campo.Substring(I, 1)
                End If
            Next
        Next
        Return Retorno
    End Function
    Public Function Completa(ByVal Texto As String, ByVal Quantos As Integer) As String
        Dim I As Integer = Quantos - Texto.Length
        Dim ret As String
        If I < 0 Then
            ret = Texto.Substring(0, Quantos)
        Else
            ret = Texto + Espacos(I)
        End If
        Return ret
    End Function
    Public Function Repete(ByVal Texto As String, ByVal Quantos As Integer) As String
        Dim ret As String = ""
        For I As Integer = 0 To Quantos - 1
            ret += Texto
        Next
        Return ret
    End Function
    Public Function Espacos(ByVal Quantos As Integer) As String
        Dim ret As String = ""
        For I As Integer = 0 To Quantos - 1
            ret += " "
        Next
        Return ret
    End Function
    Public Function Converte64(ByVal Texto As String) As Int64
        Dim cod As Int64 = 0
        Try
            cod = Convert.ToInt64(Texto)
        Catch generatedExceptionName As System.Exception
            cod = 0
        End Try
        Return cod
    End Function
    Public Function Converte32(ByVal Texto As String) As Int32
        Dim cod As Int32 = 0
        Try
            cod = Convert.ToInt32(Texto)
        Catch generatedExceptionName As System.Exception
            cod = 0
        End Try
        Return cod
    End Function
    Public Function Converte_Dos(ByVal Texto As String) As String
        Dim Windows As String = "áàãâéèêíìîóòõôúùûçÁÀÃÂÉÈÊÍÌÎÓÒÕÔÇ&"
        Dim Dos As String = "aaaaeeeiiioooouuucAAAAEEEIIIOOOOCE"
        Dim Res As String = ""
        Dim Ok As Boolean = False
        For I As Integer = 0 To Texto.Length - 1
            Ok = False
            Dim K As Integer = 0
            For J As Integer = 0 To Windows.Length - 1
                If Texto(I) = Windows(J) Then
                    Ok = True
                    K = J
                End If
            Next
            If Ok Then
                Res += Dos(K)
            Else
                Res += Texto(I)
            End If
        Next
        Return Res
    End Function

#End Region
    Public Sub read_db_texto(ByVal cn, ByRef var)
        If IsDBNull(cn) = False Then var = cn Else var = ""
    End Sub
    Public Function rd_db_num(ByVal cn)
        Try
            If cn.ToString.Trim = "" Then Return 0
        Catch ex As Exception

        End Try
        If IsDBNull(cn) = False Then Return cn Else Return 0
    End Function
    Public Sub read_db_data(ByVal cn, ByRef var)
        If IsDBNull(cn) = False Then var = cn Else var = Nothing
    End Sub
    Public Sub valida_db_din(ByVal cn, ByRef ctr)
        If IsDBNull(cn) = False Then ctr.text = Format(cn, "currency") Else ctr.text = "R$ 0,00"
    End Sub
    Public Function pnum(ByVal n As Object)
        If n = "" Or n = Nothing Then
            Return Nothing
        Else
            Return n
        End If
    End Function
    Public Function adiciona_zeros(ByVal Valor As String, ByVal digitos As Integer) As String
        Dim i As Integer
        i = Valor.Length
        While i < digitos
            Valor = "0" & Valor
            i = i + 1
        End While
        Return Valor
    End Function
End Class
