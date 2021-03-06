<%@ Page Language="VB" AutoEventWireup="false" CodeFile="faturamento_produtos.aspx.vb" Inherits="reports_faturamento_produtos" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
        }
        .style4
        {
            font-size: large;
            color: #0000FF;
            font-weight: bold;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table class="style1">
                    <tr>
                        <td>
                            <asp:TextBox ID="txtIni" runat="server"></asp:TextBox>
                            <asp:TextBox ID="txtFim" runat="server"></asp:TextBox>
                            <asp:Button ID="btnCarrega" runat="server" Text="OK" />
                            &nbsp;<asp:Button ID="btnVoltar" runat="server" Text="Voltar" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:UpdateProgress ID="UpdateProgress1" runat="server" 
                                AssociatedUpdatePanelID="UpdatePanel1">
                                <ProgressTemplate>
                                    <img alt="" src="../images/indicator_circle_ball.gif" style="width: 16px; height: 16px" />
                                    <span class="style4">CARREGANDO DADOS,&nbsp; Esse procedimento pode levar vários 
                                    minutos, por favor aguarde...</span>
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="2">
                            <rsweb:ReportViewer ID="rpView" runat="server" Font-Names="Verdana" 
                        Font-Size="8pt" Height="600px" InteractiveDeviceInfos="(Collection)" 
                        WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1075px">
                                <LocalReport ReportPath="reports\rptFaturamentoProdutos.rdlc">
                                </LocalReport>
                            </rsweb:ReportViewer>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
