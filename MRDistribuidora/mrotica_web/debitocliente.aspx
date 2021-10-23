<%@ Page Language="VB" AutoEventWireup="false" CodeFile="debitocliente.aspx.vb" Inherits="debitocliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-family: Verdana;
            font-size: small;
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
            
                <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                    <ProgressTemplate>
                        CARREGANDO DADOS, AGUARDE...<img alt="" src="images/indicator_circle_ball.gif" 
                            style="width: 16px; height: 16px" />
                    </ProgressTemplate>
                </asp:UpdateProgress>
                <asp:Button ID="btnLoad" runat="server" Text="Carregar" />
                &nbsp;&nbsp; <a href="Default.aspx">Voltar</a><br />
                <br />
                <span class="style1">Total:</span><asp:Label ID="lblTotal" runat="server" 
                    Text="Total titulos atraso" Font-Bold="True" Font-Names="Verdana" 
                    Font-Size="Small"></asp:Label>
&nbsp;<asp:GridView ID="grdAtrasos" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" Font-Names="Verdana" 
                    Font-Size="Small">
                    <RowStyle BackColor="#EFF3FB" />
                    <Columns>
                        <asp:BoundField DataField="cod_cliente" HeaderText="Código" />
                        <asp:BoundField DataField="nome_cliente" 
                            HeaderText="Cliente" >
                        <HeaderStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Data_Venc" DataFormatString="{0:d}" 
                            HeaderText="Vencimento" >
                        <HeaderStyle HorizontalAlign="Right" />
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Data_Lanc" DataFormatString="{0:d}" 
                            HeaderText="Ult. Compra">
                        <HeaderStyle HorizontalAlign="Right" />
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="valor" HeaderText="Valor" >
                        <HeaderStyle HorizontalAlign="Right" Width="70px" />
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Dias atraso">
                        <HeaderStyle HorizontalAlign="Right" />
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="situacao" HeaderText="Situação">
                        <HeaderStyle HorizontalAlign="Right" Width="120px" />
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                    </Columns>
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>

