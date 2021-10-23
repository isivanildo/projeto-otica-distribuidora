<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="clientes.aspx.vb" Inherits="mroticaonline.cliente" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .Pesquisar
        {
            width: 50%;
        }
        .Tab_Limites_Credito
        {
        	width: 50%
        }

        .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 85px;
    }
    .style9
    {
        width: 170px;
    }

        .style10
        {
            width: 95%;
        }

        .style11
        {
            width: 100%;
        }

        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>

    <table class="style1">
        <tr>
            <td>
                <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </asp:ToolkitScriptManager>
            </td>
        </tr>
        <tr>
            <td>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" 
                            Width="902px" AutoPostBack="True">
                            <asp:TabPanel ID="TabPanel1" runat="server" HeaderText="TabPanel1">
                                <HeaderTemplate>
                                    Dados Cadastrais
                                </HeaderTemplate>
                                <ContentTemplate>
                                    <table class="style1">
                                        <tr>
                                            <td class="style2" colspan="7">
                                                <table class="style10">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label3" runat="server" Text="Nome"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label2" runat="server" Text="Cód. Cliente"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label33" runat="server" Text="Filial Cadastro"></asp:Label>
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td rowspan="2">
                                                            <asp:Button ID="btnStatus" runat="server" Font-Size="X-Small" Height="40px" 
                                                                Text="Button" Width="200px" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="txtNomeCliente" runat="server" Width="400px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtCodCliente" runat="server" Width="100px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtFilialCadastro" runat="server" Width="100px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:ImageButton ID="btnFiltrar" runat="server" CausesValidation="False" 
                                                                ImageUrl="Imagens/btnfiltrar.jpg" />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style2" colspan="7">
                                                <table class="style10">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label4" runat="server" Text="Razão Social"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label5" runat="server" Text="CNPJ/CPF"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label6" runat="server" Text="I.E/RG"></asp:Label>
                                                        </td>
                                                        <td rowspan="4" bgcolor="#FF9933">
                                                            <table class="style10">
                                                                <tr>
                                                                    <td colspan="2">
                                                                        <asp:Label ID="Label34" runat="server" Font-Bold="True" Text="Limites e Prazos"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label35" runat="server" Text="Limite Compra"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label38" runat="server" Text="Dias p/ Faturar"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:TextBox ID="txtLimiteCompra" runat="server" Width="100px"></asp:TextBox>
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtDiasPagar" runat="server" Width="100px"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label36" runat="server" Text="Limite Credito"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label37" runat="server" Text="Limite Disponível"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:TextBox ID="txtLimiteCredito" runat="server" Width="100px"></asp:TextBox>
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtLimiteDisponivel" runat="server" Width="100px"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="txtRazao" runat="server" Width="410px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtCnpj" runat="server" Width="110px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtIe" runat="server" Width="90px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label7" runat="server" Text="Endereço"></asp:Label>
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <asp:TextBox ID="txtEndereco" runat="server" Width="520px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style2" colspan="7">
                                                <table class="style10">
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="Label8" runat="server" Text="Número"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label9" runat="server" Text="Complemento"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label10" runat="server" Text="Bairro"></asp:Label>
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="Label30" runat="server" Text="Cidade"></asp:Label>
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="txtNumero" runat="server" Width="100px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtComplemento" runat="server" Width="350px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtBairro" runat="server"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:DropDownList ID="cbCidade" runat="server" Width="170px">
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style2" colspan="7">
                                                <table class="style10">
                                                    <tr>
                                                        <td colspan="4">
                                                            <table class="style10">
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label12" runat="server" Text="UF"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label13" runat="server" Text="CEP"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label14" runat="server" Text="Telefones"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label15" runat="server" Text="Telefone NF"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:TextBox ID="txtUf" runat="server" Width="30px"></asp:TextBox>
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtCep" runat="server" Width="90px"></asp:TextBox>
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtTelefones" runat="server" Width="200px"></asp:TextBox>
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtTelefoneNf" runat="server" Width="100px"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td colspan="3">
                                                                        <asp:Label ID="Label16" runat="server" Text="E-mail NF"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label18" runat="server" Text="Tipo Cliente"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td colspan="3">
                                                                        <asp:TextBox ID="txtEmailNf" runat="server" Width="350px"></asp:TextBox>
                                                                    </td>
                                                                    <td>
                                                                        <asp:DropDownList ID="cbTipoCliente" runat="server" style="margin-top: 0px" 
                                                                            Width="100px">
                                                                        </asp:DropDownList>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label27" runat="server" Text="Observações"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td colspan="4">
                                                                        <asp:TextBox ID="txtObservacoes" runat="server" Height="104px" 
                                                                            TextMode="MultiLine" Width="350px" Wrap="False"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td valign="top">
                                                            <table class="style10">
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label19" runat="server" Text="Tipo Compra" Font-Bold="True"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:GridView ID="grdForma" runat="server" CellPadding="4" ForeColor="#333333" 
                                                                            GridLines="None">
                                                                            <AlternatingRowStyle BackColor="White" />
                                                                            <EditRowStyle BackColor="#2461BF" />
                                                                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                                                            <RowStyle BackColor="#EFF3FB" />
                                                                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                                                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                                                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                                                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                                                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                                                          </asp:GridView>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td valign="top">
                                                            <table class="style10">
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label20" runat="server" Text="Promotor(es)"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:DropDownList ID="dbPromotor" runat="server" Width="200px">
                                                                        </asp:DropDownList>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <asp:ListBox ID="ListBox1" runat="server" Width="200px"></asp:ListBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <table class="style10">
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:ImageButton ID="btnAdicionar" runat="server" 
                                                                                        ImageUrl="Imagens/btnAdicionar.jpg" OnClientClick="mensagemSalvar()" 
                                                                                        style="height: 26px" />
                                                                                </td>
                                                                                <td>
                                                                                    <asp:ImageButton ID="btnExcluiPromotor" runat="server" 
                                                                                        ImageUrl="Imagens/btnExcluir.jpg" OnClientClick="mensagemExcluir()" />
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                        <td>
                                                            &nbsp;</td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style2" colspan="7">
                                                <asp:GridView ID="grdResumo" runat="server">
                                                </asp:GridView>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style2">
                                                &nbsp;</td>
                                            <td class="style9">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style2" colspan="2">
                                                &nbsp;</td>
                                            <td colspan="5">
                                                <asp:Panel ID="Panel2" runat="server" BackColor="#0066CC">
                                                    <table class="style11">
                                                        <tr>
                                                            <td>
                                                                <asp:ImageButton ID="btnNovo" runat="server" CausesValidation="False" 
                                                                    ImageUrl="Imagens/btnNovo24.jpg" Enabled="False" />
                                                            </td>
                                                            <td>
                                                                <asp:ImageButton ID="btnEditar" runat="server" CausesValidation="False" 
                                                                    ImageUrl="Imagens/btnEditar24.jpg" Enabled="False" />
                                                            </td>
                                                            <td>
                                                                <asp:ImageButton ID="btnExcluir" runat="server" CausesValidation="False" 
                                                                    Enabled="False" ImageUrl="Imagens/btnExcluir24.jpg" 
                                                                    onclientclick="mensagemExcluir()" />
                                                            </td>
                                                            <td>
                                                                <asp:ImageButton ID="btnSalvar" runat="server" Enabled="False" Height="32px" 
                                                                    ImageUrl="Imagens/btnSalvar24.jpg" onclientclick="mensagemSalvar()" />
                                                            </td>
                                                            <td>
                                                                <asp:ImageButton ID="btnCancelar" runat="server" CausesValidation="False" 
                                                                    Enabled="False" ImageUrl="Imagens/btnCancelar24.jpg" />
                                                            </td>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </asp:Panel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style2">
                                                &nbsp;</td>
                                            <td class="style9">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style2">
                                                &nbsp;</td>
                                            <td class="style9">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style2">
                                                &nbsp;</td>
                                            <td class="style9">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:TabPanel>
                            <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
                                <HeaderTemplate>
                                    Pacote de Desconto
                                </HeaderTemplate>
                            </asp:TabPanel>
                            <asp:TabPanel ID="TabPanel3" runat="server" HeaderText="TabPanel3">
                                <HeaderTemplate>
                                    Pedidos
                                </HeaderTemplate>
                            </asp:TabPanel>
                            <asp:TabPanel ID="TabPanel4" runat="server" HeaderText="TabPanel4">
                                <HeaderTemplate>
                                    OS do Cliente
                                </HeaderTemplate>
                            </asp:TabPanel>
                            <asp:TabPanel ID="TabPanel5" runat="server" HeaderText="TabPanel5">
                                <HeaderTemplate>
                                    Faturas
                                </HeaderTemplate>
                            </asp:TabPanel>
                            <asp:TabPanel ID="TabPanel6" runat="server" HeaderText="TabPanel6">
                                <HeaderTemplate>
                                    Créditos
                                </HeaderTemplate>
                            </asp:TabPanel>
                            <asp:TabPanel ID="TabPanel7" runat="server" HeaderText="TabPanel7">
                                <HeaderTemplate>
                                    Titulos
                                </HeaderTemplate>
                                <ContentTemplate>
                                    <table class="style1">
                                        <tr>
                                            <td>
                                                <asp:GridView ID="grdTitulo" runat="server">
                                                </asp:GridView>
                                            </td>
                                            <td valign="top">
                                                <table class="style11">
                                                    <tr>
                                                        <td bgcolor="#FF3300">
                                                            <asp:Label ID="Label31" runat="server" Text="Títulos Atrasados:" 
                                                                Font-Bold="True"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right" bgcolor="#FF3300">
                                                            <asp:Label ID="lblAtrasados" runat="server" Text="Label" BackColor="Red" 
                                                                ForeColor="White" Font-Bold="True"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td bgcolor="Yellow">
                                                            <asp:Label ID="Label32" runat="server" Text="Títulos a Vencer" Font-Bold="True"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="right" bgcolor="Yellow">
                                                            <asp:Label ID="lblPendentes" runat="server" BackColor="Yellow" 
                                                                ForeColor="Black" Text="Label" Font-Bold="True"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:TabPanel>
                            <asp:TabPanel ID="TabPanel8" runat="server" HeaderText="TabPanel8">
                                <HeaderTemplate>
                                    Acordo
                                </HeaderTemplate>
                            </asp:TabPanel>
                        </asp:TabContainer>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>

</div>
    </asp:Content>
