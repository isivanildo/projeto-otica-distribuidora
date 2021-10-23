<%@ Page Language="VB" AutoEventWireup="false" CodeFile="notas.aspx.vb" Inherits="notas" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style4
        {
        }
        .style6
        {
        }
        .style11
        {
            width: 402px;
        }
        .style12
        {
            width: 450px;
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
                <table class="style1" width="1024">
                    <tr>
                        <td class="style12">
                        <ajaxToolkit:MaskedEditExtender
                            TargetControlID="txtDI" 
                            Mask="99/99/9999"
                            MessageValidatorTip="true" 
                            OnFocusCssClass="MaskedEditFocus" 
                            OnInvalidCssClass="MaskedEditError"
                            MaskType="Date" 
                            InputDirection="RightToLeft" 
                            ErrorTooltipEnabled="True"
                            runat="server" Century="2000" ClearTextOnInvalid="True"/>
                           
                            <asp:Label ID="Label1" runat="server" Text="Início:"></asp:Label>
                            <asp:TextBox ID="txtDI" runat="server" Width="80px"></asp:TextBox>
                            <asp:Label ID="Label2" runat="server" Text="Fim:"></asp:Label>
                            <asp:TextBox ID="txtDF" runat="server" Width="80px"></asp:TextBox>
                            <ajaxToolkit:MaskedEditExtender ID="txtDF_MaskedEditExtender" runat="server" 
                                ErrorTooltipEnabled="True" InputDirection="RightToLeft" Mask="99/99/9999" 
                                MaskType="Date" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus" 
                                OnInvalidCssClass="MaskedEditError" TargetControlID="txtDF" />
                            <asp:Button ID="btnOK" runat="server" Text="Carregar" Width="90px" />
                            <asp:Label ID="Label4" runat="server" Text="Filial:"></asp:Label>
                            <asp:TextBox ID="txtFilial" runat="server" Width="28px">1</asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Nota:"></asp:Label>
                            <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
                            <asp:Button ID="btnOKNota" runat="server" Text="Carregar" Width="90px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style12">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style4" colspan="2">
                            <asp:GridView ID="grdNotas" runat="server" AutoGenerateColumns="False" 
                                BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
                                CellPadding="3" GridLines="Horizontal">
                                <AlternatingRowStyle BackColor="#F7F7F7" />
                                <Columns>
                                    <asp:BoundField DataField="Documento" HeaderText="Nota" />
                                    <asp:BoundField DataField="Fornecedor" HeaderText="Fornecedor" />
                                    <asp:BoundField DataField="data" DataFormatString="{0:d}" HeaderText="Data" />
                                    <asp:BoundField DataField="quantidade" HeaderText="Itens">
                                    <HeaderStyle HorizontalAlign="Right" />
                                    <ItemStyle HorizontalAlign="Right" />
                                    </asp:BoundField>
                                    <asp:HyperLinkField DataNavigateUrlFields="id_conferencia,id_filial" 
                                        DataNavigateUrlFormatString="nota.aspx?nota={0}&amp;filial={1}" DataTextField="id_conferencia" 
                                        DataTextFormatString="Abrir" NavigateUrl="~/nota.aspx" Target="_blank" />
                                </Columns>
                                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                                <SortedDescendingHeaderStyle BackColor="#3E3277" />
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4" colspan="2">
                            <asp:TextBox ID="txtStatus" runat="server" Width="1000px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6" colspan="2">
                            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                                <ProgressTemplate>
                                    Carregando...
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
