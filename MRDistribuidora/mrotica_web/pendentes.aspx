<%@ Page Language="VB" AutoEventWireup="false" CodeFile="pendentes.aspx.vb" Inherits="pendentes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .titulo
        {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
            font-size:small; 
        }
        .tituloazul
        {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
            font-size:small; 
            color:Blue; 
        }
        .data
        {
             color: #FF0000;
             font-size: small;  
             font-family: Arial, Helvetica, sans-serif;
             font-weight:bold;  
        }
        .texto
        {
            font-family: Arial,Helvetica,sans-serif;
            font-size:small;
            font-weight:normal;   
        }
        
    </style>
</head>

<body>
    <form id="form1" runat="server">
    <div>
        
    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    
                                 </asp:ScriptManager>
                
                <asp:Panel ID="Panel1" runat="server">
                   <asp:Button ID="btnLoad" runat="server" Text="Carregar" />
                     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                
                         <ContentTemplate>
                             <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                                 <ProgressTemplate>
                                     Carregando...
                                 </ProgressTemplate>
                             </asp:UpdateProgress>
                         </ContentTemplate>
                
                </asp:UpdatePanel>
                </asp:Panel>
    </div>
    
    </form>
    </body>
</html>

