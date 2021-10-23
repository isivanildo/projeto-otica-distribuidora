' NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in Web.config.
<ServiceContract()> _
Public Interface IService1

    <OperationContract()> _
    Function GetData(ByVal value As Integer) As String
    <OperationContract()> _
    Function andamentos(ByVal filial As Integer, ByVal xos As Integer) As DataTable
    <OperationContract()> _
    Function FilaRetorno(ByVal filial As Integer, ByVal nReg As Integer) As DataTable
    <OperationContract()> _
    Function FilaEnvio(ByVal tb As DataTable, ByVal filial As Integer, ByRef strLog As String) As DataTable
    <OperationContract()> _
    Function devolve_importados(ByVal tb As DataTable) As String
    <OperationContract()> _
    Function os_in_trans(ByVal tOS As DataSet, ByVal dsTrat As DataSet) As String
    <OperationContract()> _
    Function SaidaExtra(ByVal id_Filial As Integer, ByVal os As Integer, ByVal OD As Boolean _
                               , ByVal OE As Boolean, ByVal motivo As String) As String
    ' TODO: Add your service operations here

End Interface



