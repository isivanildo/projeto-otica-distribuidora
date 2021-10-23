<%@ Page Language="VB" AutoEventWireup="false" CodeFile="resumoreceber.aspx.vb" Inherits="resumoreceber" %>

<DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
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
                &nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="rdTotal" runat="server" Checked="True" GroupName="ordem" 
                    Text="Ordenar por total" />
                &nbsp;
                <asp:RadioButton ID="rdAtrasos" runat="server" GroupName="ordem" 
                    Text="Ordenar por atrasados" />
                &nbsp;&nbsp;&nbsp;&nbsp; <a href="Default.aspx">Voltar</a> <br />
                <br />
                Total:<asp:Label ID="lblTotal" runat="server" Text="Total Aberto"></asp:Label>
                &nbsp;&nbsp; Em Atraso:
                <asp:Label ID="lblTotalAtraso" runat="server" Text="Total titulos atraso"></asp:Label>
                &nbsp;<asp:Label ID="lblPercAtraso" runat="server" Text="% Atraso"></asp:Label>
                &nbsp;<asp:GridView ID="grdAtrasos" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" Font-Size="Small">
                    <RowStyle BackColor="#EFF3FB" />
                    <Columns>
                        <asp:BoundField DataField="nome_cliente" HeaderText="Cliente" >
                        <ControlStyle Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Pedidos_nao_faturados" DataFormatString="{0:C}" 
                            HeaderText="Ped. Aberto" >
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Saldo_faturas" DataFormatString="{0:C}" 
                            HeaderText="Fat. Aberto" >
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="nao_faturados_Faturas_aberto" DataFormatString="{0:C}" 
                            HeaderText="Sub Total">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="titulos_atraso" HeaderText="Bol. Atraso" 
                            DataFormatString="{0:C}" >
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="titulos_a_vencer" HeaderText="Bol. Vencer" 
                            DataFormatString="{0:C}" >
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="titulos_aberto" DataFormatString="{0:C}" 
                            HeaderText="Tot. Boletos">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="cheques_a_vencer" DataFormatString="{0:C}" 
                            HeaderText="Cheques">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="total_aberto" DataFormatString="{0:c}" 
                            HeaderText="Total Aberto">
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
    <div>
    
    </div>
    </form>
</body>
</html>
