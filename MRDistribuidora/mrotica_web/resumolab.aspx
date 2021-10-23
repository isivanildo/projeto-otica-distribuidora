<%@ Page Language="VB" AutoEventWireup="false" CodeFile="resumolab.aspx.vb" Inherits="resumolab" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
    
      function pageLoad() {
      }
    
    </script>
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
            width: 533px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="style1">
                    <tr>
                        <td class="style3">
                            <asp:Label ID="Label1" runat="server" Text="Início"></asp:Label>
                            &nbsp;<asp:TextBox ID="txtInicio" runat="server" Width="108px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label2" runat="server" Text="Fim"></asp:Label>
                            <asp:TextBox ID="txtFim" runat="server" Width="108px"></asp:TextBox>
                            &nbsp;&nbsp;
                            <asp:Button ID="btnOk" runat="server" Text="OK" />
                        </td>
                        <td>
                            <asp:Label ID="Label3" runat="server" 
                                Text="Total de óculos montados no período: "></asp:Label>
                            <asp:Label ID="lblTotal" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="69px"></asp:Label>
                            &nbsp;
                            <asp:Label ID="Label4" runat="server" Text="Média Diária: "></asp:Label>
                            <asp:Label ID="lblMedia" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                Width="69px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                            <asp:CheckBox ID="chkMontagem" runat="server" Text="Só Montagem" />
                            <asp:CheckBox ID="chkSurfacagem" runat="server" Text="Só Surfacagem" />
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style3">
                            <a href="Default.aspx">Voltar Página Inicial</a></td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="2">
                            <asp:GridView ID="grdConcluidos" runat="server" AutoGenerateColumns="False" 
                                CellPadding="4" ForeColor="#333333" GridLines="None">
                                <RowStyle BackColor="#EFF3FB" />
                                <Columns>
                                    <asp:BoundField DataField="dia_saida" HeaderText="Dia" ReadOnly="True" />
                                    <asp:BoundField DataField="dia_semana" HeaderText="Dia da Semana" />
                                    <asp:BoundField DataField="quantidade" HeaderText="Quantidade Serviços" />
                                    <asp:BoundField DataField="porcentagem" HeaderText="Porcentagem" />
                                </Columns>
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <EditRowStyle BackColor="#2461BF" />
                                <AlternatingRowStyle BackColor="White" />
                            </asp:GridView>
                        </td>
                    </tr>
                                   </table>
               <br />
        
    </div>
    </form>
</body>
</html>
