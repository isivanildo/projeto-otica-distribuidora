Module dialupMod
    Public Declare Function InternetGetConnectedState Lib "wininet.dll" (ByRef lpdwFlags As Int32, ByVal dwReserved As Int32) As Boolean
    Public Declare Function InternetDial Lib "Wininet.dll" (ByVal hwndParent As IntPtr, ByVal lpszConnectoid As String, ByVal dwFlags As Int32, ByRef lpdwConnection As Int32, ByVal dwReserved As Int32) As Int32
    Public Declare Function InternetHangUp Lib "Wininet.dll" (ByVal lpdwConnection As Int32, ByVal dwReserved As Int32) As Int32
    Public Declare Function iDialItemize Lib "Wininet.dll" () As Integer

    Public Enum Flags As Integer
        'Local system uses a LAN to connect to the Internet.
        INTERNET_CONNECTION_LAN = &H2
        'Local system uses a modem to connect to the Internet.
        INTERNET_CONNECTION_MODEM = &H1
        'Local system uses a proxy server to connect to the Internet.
        INTERNET_CONNECTION_PROXY = &H4
        'Local system has RAS installed.
        INTERNET_RAS_INSTALLED = &H10
        SEM_CONEXAO = 0
    End Enum
    'Declaration Used For InternetDialUp.
    Public Enum DialUpOptions As Integer
        INTERNET_DIAL_UNATTENDED = &H8000
        INTERNET_DIAL_SHOW_OFFLINE = &H4000
        INTERNET_DIAL_FORCE_PROMPT = &H2000
    End Enum
    Public Const ERROR_SUCCESS = &H0
    Public Const ERROR_INVALID_PARAMETER = &H87
    Public mlConnection As Int32
    Public Function DetectConnection() As String
        Dim lngFlags As Long
        If InternetGetConnectedState(lngFlags, 0) Then
            'connected.
            If lngFlags And Flags.INTERNET_CONNECTION_LAN Then
                'LAN connection.
                Return "LAN"
            ElseIf lngFlags And Flags.INTERNET_CONNECTION_MODEM Then
                'Modem connection.
                Return "Modem"
            ElseIf lngFlags And Flags.INTERNET_CONNECTION_PROXY Then
                'Proxy connection.
                Return "Proxy"
            End If
        Else
            'not connected.
            Return "Sem Conexão"
        End If
    End Function
    Public Function Dialup(ByVal hwndParent As IntPtr)
        Dim DResult As Int32
        DResult = InternetDial(hwndParent, "sdsds", DialUpOptions.INTERNET_DIAL_UNATTENDED, mlConnection, 0)
        If (DResult = ERROR_SUCCESS) Then

        Else
            Return "Conexão não foi discada!" & DResult
        End If
    End Function
    Public Sub Hangup()
        Dim Result As Int32

        If Not (mlConnection = 0) Then
            Result = InternetHangUp(mlConnection, 0&)
            If Result = 0 Then
                'MessageBox.Show("Hang up successful", "Hang Up Connection")
            Else
                'MessageBox.Show("Hang up NOT successful", "Hang Up Connection")
            End If
        Else
            'MessageBox.Show("You must dial a connection first!", "Hang Up Connection")
        End If
    End Sub
End Module
