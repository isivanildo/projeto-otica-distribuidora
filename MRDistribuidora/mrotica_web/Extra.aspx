<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Extra.aspx.vb" Inherits="Extra" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
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
        }
        .style4
        {
            font-size: large;
            color: #0000FF;
            font-weight: bold;
        }
        .style5
        {
            text-align: left;
            width: 81px;
        }
        .style6
        {
            text-align: left;
            width: 137px;
        }
        .style7
        {
            width: 342px;
        }
        .style8
        {
            width: 81px;
        }
        .style9
        {
            text-align: right;
            width: 278px;
        }
        .style10
        {
            width: 342px;
            height: 30px;
        }
        .style11
        {
            text-align: right;
            width: 278px;
            height: 30px;
        }
        .style12
        {
            text-align: left;
            width: 137px;
            height: 30px;
        }
        .style13
        {
            text-align: left;
            width: 81px;
            height: 30px;
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
                        <td class="style10">
                            <asp:Label ID="Label1" runat="server" Text="Início"></asp:Label>
                            &nbsp;<asp:TextBox ID="txtInicio" runat="server" Width="76px"></asp:TextBox>
                            &nbsp;<asp:Label ID="Label2" runat="server" Text="Fim"></asp:Label>
                            <asp:TextBox ID="txtFim" runat="server" Width="81px"></asp:TextBox>
                            &nbsp;&nbsp;
                            <asp:Button ID="btnOk" runat="server" Text="OK" />
                        </td>
                        <td class="style11">
                            <asp:Label ID="Label3" runat="server" 
                                Text="Total de Extras no período: "></asp:Label>
                            </td>
                        <td class="style12">
                            <asp:Label ID="lblTotal" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                style="text-align: right" Width="211px"></asp:Label>
                        </td>
                        <td class="style13">
                            <asp:Label ID="lblTotalDin" runat="server" BorderStyle="Solid" 
                                BorderWidth="1px" style="text-align: right" Width="119px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            <a href="Default.aspx">Voltar Página inicial</a>
                        </td>
                        <td class="style9">
                            <asp:Label ID="Label4" runat="server" Text="Produção no período: "></asp:Label>
                        </td>
                        <td class="style6">
                            <asp:Label ID="lblTotalProd" runat="server" BorderStyle="Solid" 
                                BorderWidth="1px" style="text-align: right" Width="211px"></asp:Label>
                        </td>
                        <td class="style5">
                            <asp:Label ID="lblTotalProdDin" runat="server" BorderStyle="Solid" 
                                BorderWidth="1px" style="text-align: right; margin-left: 0px" Width="119px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            &nbsp;</td>
                        <td class="style9">
                            <asp:Label ID="Label5" runat="server" Text="Porcentagem:"></asp:Label>
                        </td>
                        <td class="style6">
                            <asp:Label ID="lblPorQuant" runat="server" BorderStyle="Solid" 
                                BorderWidth="1px" style="text-align: right" Width="211px"></asp:Label>
                        </td>
                        <td class="style5">
                            <asp:Label ID="lblPorFin" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                                style="text-align: right" Width="119px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3" colspan="3">
                            <b>Extras Labonorte</b><asp:UpdateProgress ID="UpdateProgress1" runat="server" 
                                AssociatedUpdatePanelID="UpdatePanel1">
                                <ProgressTemplate>
                                    <img alt="" src="images/indicator_circle_ball.gif" style="width: 16px; height: 16px" /><span 
                                        class="style4">CARREGANDO DADOS,&nbsp; Esse procedimento pode levar vários 
                                    minutos, por favor aguarde...</span>
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="3">
                            <asp:GridView ID="grdLabonorte" runat="server" 
                                CellPadding="4" 
                                AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" 
                                BorderStyle="None" BorderWidth="1px">
                                <RowStyle BackColor="White" ForeColor="#003399" />
                                <Columns>
                                    <asp:BoundField DataField="nome_cliente" HeaderText="Cliente" />
                                    <asp:BoundField DataField="cod_os" HeaderText="OS" />
                                    <asp:BoundField DataField="data" DataFormatString="{0:d}" HeaderText="Data" />
                                    <asp:BoundField DataField="nome" HeaderText="Solicitante" />
                                    <asp:BoundField DataField="desc_saida_extra" HeaderText="Descrição" />
                                    <asp:BoundField DataField="od" HeaderText="OD" />
                                    <asp:BoundField DataField="oe" HeaderText="OE" />
                                    <asp:BoundField DataField="POD" HeaderText="Prod. OD" />
                                    <asp:BoundField DataField="POE" HeaderText="Prod. OE" />
                                    <asp:BoundField DataField="valor" HeaderText="Valor" DataFormatString="{0:F}">
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="olhos" HeaderText="Olhos" />
                                </Columns>
                                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="2">
                            &nbsp;</td>
                        <td class="style8">
                            &nbsp;</td>
                    </tr>
                                   </table>
               <br />
               <asp:Label ID="lblStatus" runat="server" BorderStyle="Solid" 
                BorderWidth="1px" Width="1022px"></asp:Label>
               <br />
               </ContentTemplate> 
            </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
