<%@ Page Language="VB" AutoEventWireup="false" CodeFile="titulos_atraso.aspx.vb" Inherits="titulos_atraso" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

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
                &nbsp;&nbsp; <a href="Default.aspx">Voltar</a><br />
                <br />
                Total:<asp:Label ID="lblTotal" runat="server" Text="Total titulos atraso"></asp:Label>
&nbsp;<asp:GridView ID="grdAtrasos" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None">
                    <RowStyle BackColor="#EFF3FB" />
                    <Columns>
                        <asp:BoundField DataField="nome_cliente" HeaderText="Cliente" />
                        <asp:BoundField DataField="data_lancamento" DataFormatString="{0:d}" 
                            HeaderText="Emissao" />
                        <asp:BoundField DataField="data_vencimento" DataFormatString="{0:d}" 
                            HeaderText="Vencimento" />
                        <asp:BoundField DataField="Valor" DataFormatString="{0:C}" 
                            HeaderText="Valor">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tipo_documento" HeaderText="Tipo" />
                        <asp:BoundField DataField="documento" HeaderText="Documento" />
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

