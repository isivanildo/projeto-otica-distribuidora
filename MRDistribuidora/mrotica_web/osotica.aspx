<%@ Page Language="VB" AutoEventWireup="false" CodeFile="osotica.aspx.vb" Inherits="osotica" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
        }
        .style3
        {
            width: 133px;
        }
        .style4
        {
            width: 186px;
        }
        .style5
        {
            width: 112px;
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
                        <td class="style5">
                            <asp:Label ID="Label1" runat="server" Text="Filial"></asp:Label>
                            <asp:TextBox ID="txtFilial" runat="server" Width="71px"></asp:TextBox>
                        </td>
                        <td class="style4">
                            <asp:Label ID="Label2" runat="server" Text="OS: "></asp:Label>
                            <asp:TextBox ID="txtOS" runat="server" Width="100px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="btnConsulta" runat="server" Text="OK" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="3">
                            <asp:UpdateProgress ID="UpdateProgress1" runat="server" 
                                AssociatedUpdatePanelID="UpdatePanel1">
                                <ProgressTemplate>
                                <asp:Image ID="Image1" runat="server"  
                        ImageUrl="~/images/indicator_circle_ball.gif"/>
                                    &nbsp;Carregando, Aguarde...
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </td>
                    </tr>
                </table>
                
                <table>
                    <tr>
                        <td>
                                                        <asp:TextBox ID="txtOD" runat="server" Width="388px"></asp:TextBox>
                        </td>
                        <td class="style3">
                                                        <asp:TextBox ID="txtOE" runat="server" Width="388px"></asp:TextBox>
                        </td>
                                      </tr>
                                           <tr>
                                              
                                               <td colspan="2">
                                           <asp:TextBox ID="txtOBS" runat="server" Width="780px" Height="68px" 
                                                       TextMode="MultiLine"></asp:TextBox>
                                           </td>
                                           </tr>
                                            <asp:GridView ID="grdTratamentos" runat="server" 
                        BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
                        CellPadding="3" GridLines="Vertical" AutoGenerateColumns="False">
                                                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                                                <Columns>
                                                    <asp:BoundField DataField="tratamento" HeaderText="Tratamento" />
                                                </Columns>
                                                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                                <AlternatingRowStyle BackColor="#DCDCDC" />
                                               </asp:GridView>
                                          
                </table>
                <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
                
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
