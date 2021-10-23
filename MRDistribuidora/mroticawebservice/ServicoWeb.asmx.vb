Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports winotica_util
Imports System.Data
Imports System.Data.SqlClient

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://localhost/winoticawebservice")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class ServicoWeb
    Inherits System.Web.Services.WebService
    Dim d As New dados("winweb", "winotica", "desenvolvimento\sql2008r2", "winotica")
    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Olá Mundo"
    End Function

    <WebMethod()> _
    Public Function retornaDadosFila() As String
        Dim strResultado As String
        d.conecta()
        Dim strSQL As String = "SELECT INSTRUCAO FROM FILA_IMPORTACAO WHERE DATA_PROCESSAMENTO IS NULL"
        Dim cmd As New SqlCommand(strSQL, d.con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        dr.Read()
        strResultado = dr("instrucao").ToString
        d.desconecta()
        Return strResultado
    End Function

End Class