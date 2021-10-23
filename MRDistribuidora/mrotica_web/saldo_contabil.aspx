<%@ Page Language="VB" AutoEventWireup="false" CodeFile="saldo_contabil.aspx.vb" Inherits="saldo_contabil" %>

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
        .style3
        {
            width: 329px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
    
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table class="style1">
                    <tr>
                        <td class="style3">
                            <asp:Label ID="Label1" runat="server" Text="Data:"></asp:Label>
                            <asp:TextBox ID="txtData" runat="server" Width="90px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label2" runat="server" Text="Filial:"></asp:Label>
                            <asp:TextBox ID="txtFilial" runat="server" Width="54px">1</asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="btnOK" runat="server" Text="Carregar" />
                            &nbsp; <a href="Default.aspx">Voltar</a></td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="2">
                            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                                <ProgressTemplate>
                                    CARREGANDO DADOS, AGUARDE...<img alt="" src="images/indicator_circle_ball.gif" 
                            style="width: 16px; height: 16px" />
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="2">
                            <asp:GridView ID="grdSaldos" runat="server" AutoGenerateColumns="False" 
                                CellPadding="4" ForeColor="#333333" 
                                GridLines="None">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="nome_comercial" HeaderText="Produto" />
                                    <asp:BoundField DataField="Preco" DataFormatString="{0:c}" HeaderText="Preço">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="saldo" HeaderText="Quant." />
                                    <asp:BoundField DataField="total" DataFormatString="{0:c}" HeaderText="Total">
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="ncm" HeaderText="NCM" />
                                </Columns>
                                <EditRowStyle BackColor="#2461BF" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#EFF3FB" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
