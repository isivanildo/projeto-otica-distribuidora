<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>


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
            width: 413px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td align="center" colspan="2">
                    <asp:Image ID="Image1" runat="server" Height="140px" 
                        ImageUrl="~/images/logo.jpg" Width="436px" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <a href="pendentes.aspx">OS Pendentes</a></td>
                <td>
                    <a href="titulos_atraso.aspx">Titulos Atraso</a> | <a href="debitocliente.aspx"> Titulos Atraso pós Vencimento</td>
            </tr>
            <tr>
                <td class="style2">
                    <a href="extra.aspx">Saídas Extras</a></td>
                <td>
                    <a href="saldo_fatura.aspx">Faturas com Saldo</a></td>
            </tr>
            <tr>
                <td class="style2">
                    <a href="OSOtica.aspx">Consultar OS Ótica</a></td>
                <td>
                    <a href="resumoreceber.aspx">Resumo Receber</a> |
                    <a href="reports/resumoatraso.aspx">Resumo Atrasados</a></td>
            </tr>
            <tr>
                <td class="style2">
                    <a href="saldo_lentes.aspx">Saldos Lentes</a> | <a href="saldo_contabil.aspx">Saldo Lentes Cont.</a></td>
                <td>
                    <a href="resumolab.aspx">Produção Laboratorio</a></td>
            </tr>
            <tr>
                <td class="style2">
                    <a href="reports/faturamento_produtos.aspx">Faturamento Produtos</a></td>
                <td>
                    <a href="reports/clientes.aspx">Lista Clientes</a> | <a href="notas.aspx">Notas</a> </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
