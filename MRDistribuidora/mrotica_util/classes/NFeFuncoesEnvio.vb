Imports System.IO
Imports System.Text
Imports System.Net

Public Class NFeFuncoesEnvio

    Public Property ServdorUrl As String
    Public Property Usuario As String
    Public Property Senha As String
    Public Property MensagemRetorno As String

    Public Function Request(ByVal _requestData As String, ByVal _documento As String, ByVal _route As String, ByVal _method As String) As String
        If _method = "POST" Then
            Return PostRequest(_requestData, _documento, _route)
        Else
            Return GetRequest(_requestData, _documento, _route)
        End If
    End Function

    Public Function PostRequest(ByVal post_requestData As String, ByVal post_documento As String, ByVal post_route As String) As String
        Dim Result As String = ""

        Try
            Dim request As WebRequest = WebRequest.Create(ServdorUrl & "ManagerAPIWeb/" & post_documento.ToLower() & "/" & post_route)
            request.ContentType = "application/x-www-form-urlencoded"
            Dim credentials As Byte() = New UTF8Encoding().GetBytes(Usuario & ":" + Senha)
            request.Headers("Authorization") = "Basic " & Convert.ToBase64String(credentials)
            MensagemRetorno = request.Headers("Authorization")
            request.Method = "POST"
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(post_requestData)
            request.ContentLength = byteArray.Length
            MensagemRetorno = ServdorUrl & "ManagerAPIWeb/" & post_documento.ToLower() & "/" & post_route
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As StreamReader = New StreamReader(dataStream)
            Result = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()
        Catch ex As Exception
            Result = "EXCEPTION: Erro ao obter retorno do servidor remoto"
        End Try

        Return Result
    End Function

    Public Function GetRequest(ByVal get_requestData As String, ByVal get_documento As String, ByVal get_route As String) As String
        Dim Result As String

        If ServdorUrl.Contains("PesquisarNCM") Then
            Dim urlNCM As String = ServdorUrl & "?" & get_requestData
            Dim _requestNCM As WebClient = New WebClient()
            Result = _requestNCM.DownloadString(urlNCM)
        Else
            Dim url As String = ServdorUrl & "ManagerAPIWeb/" & get_documento.ToLower() & "/" & get_route & "?" & get_requestData
            Dim _request As WebClient = New WebClient()
            Dim credentials As Byte() = New UTF8Encoding().GetBytes(Usuario & ":" + Senha)
            _request.Headers(HttpRequestHeader.Authorization) = "Basic " & Convert.ToBase64String(credentials)
            MensagemRetorno = _request.Headers("Authorization")
            MensagemRetorno = url
            Result = ""

            Try
                Result = _request.DownloadString(url)
            Catch [error] As Exception
                Result = "Não Foi Possível Concluir a Requisição." & vbLf & "- - - - - - - - - - - - - ERRO - - - - - - - - - - - - -" & vbLf & [error].ToString()
            End Try
        End If

        Return Result
    End Function

End Class
